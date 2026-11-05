//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MuhimbiActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> CompositeWatermark(Expression<Func<CompositeWatermarkInputDataInput>> inputData)
        {
            var __workflow_inputData = WorkflowExpression.Compile(inputData, nameof(inputData), required: true);
            return new DeferredBodyAction<OperationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/operations/composite_watermark";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_inputData);
                return new ApiConnectionAction<OperationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> CompressPdf(Expression<Func<CompressPdfInputPdfDataInput>> inputPdfData)
        {
            var __workflow_inputPdfData = WorkflowExpression.Compile(inputPdfData, nameof(inputPdfData), required: true);
            return new DeferredBodyAction<OperationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/operations/compress_pdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_inputPdfData);
                return new ApiConnectionAction<OperationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> Convert(Expression<Func<ConvertInputDataInput>> inputData)
        {
            var __workflow_inputData = WorkflowExpression.Compile(inputData, nameof(inputData), required: true);
            return new DeferredBodyAction<OperationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/operations/convert";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_inputData);
                return new ApiConnectionAction<OperationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> ConvertCad(Expression<Func<InputCadDataInput>> inputCadData)
        {
            var __workflow_inputCadData = WorkflowExpression.Compile(inputCadData, nameof(inputCadData), required: true);
            return new DeferredBodyAction<OperationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/operations/convert_cad";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_inputCadData);
                return new ApiConnectionAction<OperationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> ConvertEmail(Expression<Func<InputEmailDataInput>> inputEmailData)
        {
            var __workflow_inputEmailData = WorkflowExpression.Compile(inputEmailData, nameof(inputEmailData), required: true);
            return new DeferredBodyAction<OperationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/operations/convert_email";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_inputEmailData);
                return new ApiConnectionAction<OperationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> ConvertExcel(Expression<Func<InputExcelDataInput>> inputExcelData)
        {
            var __workflow_inputExcelData = WorkflowExpression.Compile(inputExcelData, nameof(inputExcelData), required: true);
            return new DeferredBodyAction<OperationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/operations/convert_excel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_inputExcelData);
                return new ApiConnectionAction<OperationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> ConvertHtml(Expression<Func<ConvertHtmlInputDataInput>> inputData)
        {
            var __workflow_inputData = WorkflowExpression.Compile(inputData, nameof(inputData), required: true);
            return new DeferredBodyAction<OperationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/operations/convert_html";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_inputData);
                return new ApiConnectionAction<OperationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> ConvertInfopath(Expression<Func<InputInfopathDataInput>> inputInfopathData)
        {
            var __workflow_inputInfopathData = WorkflowExpression.Compile(inputInfopathData, nameof(inputInfopathData), required: true);
            return new DeferredBodyAction<OperationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/operations/convert_infopath";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_inputInfopathData);
                return new ApiConnectionAction<OperationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> ConvertPdfa(Expression<Func<ConvertPdfaInputPdfDataInput>> inputPdfData)
        {
            var __workflow_inputPdfData = WorkflowExpression.Compile(inputPdfData, nameof(inputPdfData), required: true);
            return new DeferredBodyAction<OperationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/operations/convert_pdfa";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_inputPdfData);
                return new ApiConnectionAction<OperationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> ConvertPowerpoint(Expression<Func<InputPowerpointDataInput>> inputPowerpointData)
        {
            var __workflow_inputPowerpointData = WorkflowExpression.Compile(inputPowerpointData, nameof(inputPowerpointData), required: true);
            return new DeferredBodyAction<OperationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/operations/convert_powerpoint";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_inputPowerpointData);
                return new ApiConnectionAction<OperationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> ConvertVisio(Expression<Func<InputVisioDataInput>> inputVisioData)
        {
            var __workflow_inputVisioData = WorkflowExpression.Compile(inputVisioData, nameof(inputVisioData), required: true);
            return new DeferredBodyAction<OperationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/operations/convert_visio";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_inputVisioData);
                return new ApiConnectionAction<OperationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> ConvertWord(Expression<Func<InputWordDataInput>> inputWordData)
        {
            var __workflow_inputWordData = WorkflowExpression.Compile(inputWordData, nameof(inputWordData), required: true);
            return new DeferredBodyAction<OperationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/operations/convert_word";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_inputWordData);
                return new ApiConnectionAction<OperationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
        public IBodyWorkflowAction<OperationResponseCommon, ApiConnectionActionConfiguration> CopyMetadata(Expression<Func<CopyMetadataInputDataInput>> inputData)
        {
            var __workflow_inputData = WorkflowExpression.Compile(inputData, nameof(inputData), required: true);
            return new DeferredBodyAction<OperationResponseCommon, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/operations/copy_metadata";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_inputData);
                return new ApiConnectionAction<OperationResponseCommon>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> EllipseWatermark(Expression<Func<EllipseWatermarkInputDataInput>> inputData)
        {
            var __workflow_inputData = WorkflowExpression.Compile(inputData, nameof(inputData), required: true);
            return new DeferredBodyAction<OperationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/operations/ellipse_watermark";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_inputData);
                return new ApiConnectionAction<OperationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> ExportFormData(Expression<Func<InputFromPdfDataInput>> inputFromPdfData)
        {
            var __workflow_inputFromPdfData = WorkflowExpression.Compile(inputFromPdfData, nameof(inputFromPdfData), required: true);
            return new DeferredBodyAction<OperationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/operations/export_form_data";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_inputFromPdfData);
                return new ApiConnectionAction<OperationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> ExtractText(Expression<Func<ExtractTextInputPdfDataInput>> inputPdfData)
        {
            var __workflow_inputPdfData = WorkflowExpression.Compile(inputPdfData, nameof(inputPdfData), required: true);
            return new DeferredBodyAction<OperationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/operations/extract_text";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_inputPdfData);
                return new ApiConnectionAction<OperationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> ImageWatermark(Expression<Func<ImageWatermarkInputDataInput>> inputData)
        {
            var __workflow_inputData = WorkflowExpression.Compile(inputData, nameof(inputData), required: true);
            return new DeferredBodyAction<OperationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/operations/image_watermark";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_inputData);
                return new ApiConnectionAction<OperationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> ImportFormData(Expression<Func<InputXmlDataInput>> inputXmlData)
        {
            var __workflow_inputXmlData = WorkflowExpression.Compile(inputXmlData, nameof(inputXmlData), required: true);
            return new DeferredBodyAction<OperationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/operations/import_form_data";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_inputXmlData);
                return new ApiConnectionAction<OperationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> ExtractKeyValuePairs(Expression<Func<ExtractKeyValuePairsInputPdfDataInput>> inputPdfData)
        {
            var __workflow_inputPdfData = WorkflowExpression.Compile(inputPdfData, nameof(inputPdfData), required: true);
            return new DeferredBodyAction<OperationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/operations/key_value_pairs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_inputPdfData);
                return new ApiConnectionAction<OperationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> LineWatermark(Expression<Func<LineWatermarkInputDataInput>> inputData)
        {
            var __workflow_inputData = WorkflowExpression.Compile(inputData, nameof(inputData), required: true);
            return new DeferredBodyAction<OperationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/operations/line_watermark";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_inputData);
                return new ApiConnectionAction<OperationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> LinearBarcodeWatermark(Expression<Func<LinearBarcodeWatermarkInputDataInput>> inputData)
        {
            var __workflow_inputData = WorkflowExpression.Compile(inputData, nameof(inputData), required: true);
            return new DeferredBodyAction<OperationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/operations/linear_barcode_watermark";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_inputData);
                return new ApiConnectionAction<OperationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> MergeToPdf(Expression<Func<MergeToPdfInputDataInput>> inputData)
        {
            var __workflow_inputData = WorkflowExpression.Compile(inputData, nameof(inputData), required: true);
            return new DeferredBodyAction<OperationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/operations/merge_to_pdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_inputData);
                return new ApiConnectionAction<OperationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> OcrPdf(Expression<Func<OcrPdfInputDataInput>> inputData)
        {
            var __workflow_inputData = WorkflowExpression.Compile(inputData, nameof(inputData), required: true);
            return new DeferredBodyAction<OperationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/operations/ocr_pdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_inputData);
                return new ApiConnectionAction<OperationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
        public IBodyWorkflowAction<OcrOperationResponse, ApiConnectionActionConfiguration> OcrText(Expression<Func<OcrTextInputDataInput>> inputData)
        {
            var __workflow_inputData = WorkflowExpression.Compile(inputData, nameof(inputData), required: true);
            return new DeferredBodyAction<OcrOperationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/operations/ocr_text";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_inputData);
                return new ApiConnectionAction<OcrOperationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> PdfWatermark(Expression<Func<PdfWatermarkInputDataInput>> inputData)
        {
            var __workflow_inputData = WorkflowExpression.Compile(inputData, nameof(inputData), required: true);
            return new DeferredBodyAction<OperationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/operations/pdf_watermark";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_inputData);
                return new ApiConnectionAction<OperationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> QrCodeWatermark(Expression<Func<QrCodeWatermarkInputDataInput>> inputData)
        {
            var __workflow_inputData = WorkflowExpression.Compile(inputData, nameof(inputData), required: true);
            return new DeferredBodyAction<OperationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/operations/qr_code_watermark";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_inputData);
                return new ApiConnectionAction<OperationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> RectangleWatermark(Expression<Func<RectangleWatermarkInputDataInput>> inputData)
        {
            var __workflow_inputData = WorkflowExpression.Compile(inputData, nameof(inputData), required: true);
            return new DeferredBodyAction<OperationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/operations/rectangle_watermark";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_inputData);
                return new ApiConnectionAction<OperationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> Redact(Expression<Func<RedactInputPdfDataInput>> inputPdfData)
        {
            var __workflow_inputPdfData = WorkflowExpression.Compile(inputPdfData, nameof(inputPdfData), required: true);
            return new DeferredBodyAction<OperationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/operations/redact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_inputPdfData);
                return new ApiConnectionAction<OperationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> RedactSmart(Expression<Func<RedactSmartInputPdfDataInput>> inputPdfData)
        {
            var __workflow_inputPdfData = WorkflowExpression.Compile(inputPdfData, nameof(inputPdfData), required: true);
            return new DeferredBodyAction<OperationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/operations/redact_smart";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_inputPdfData);
                return new ApiConnectionAction<OperationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> RtfWatermark(Expression<Func<RtfWatermarkInputDataInput>> inputData)
        {
            var __workflow_inputData = WorkflowExpression.Compile(inputData, nameof(inputData), required: true);
            return new DeferredBodyAction<OperationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/operations/rtf_watermark";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_inputData);
                return new ApiConnectionAction<OperationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> SecurePdf(Expression<Func<SecurePdfInputDataInput>> inputData)
        {
            var __workflow_inputData = WorkflowExpression.Compile(inputData, nameof(inputData), required: true);
            return new DeferredBodyAction<OperationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/operations/secure_pdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_inputData);
                return new ApiConnectionAction<OperationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
        public IBodyWorkflowAction<SplitOperationResponse, ApiConnectionActionConfiguration> SplitPdf(Expression<Func<SplitPdfInputDataInput>> inputData)
        {
            var __workflow_inputData = WorkflowExpression.Compile(inputData, nameof(inputData), required: true);
            return new DeferredBodyAction<SplitOperationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/operations/split_pdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_inputData);
                return new ApiConnectionAction<SplitOperationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbi")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> TextWatermark(Expression<Func<TextWatermarkInputDataInput>> inputData)
        {
            var __workflow_inputData = WorkflowExpression.Compile(inputData, nameof(inputData), required: true);
            return new DeferredBodyAction<OperationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/operations/text_watermark";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_inputData);
                return new ApiConnectionAction<OperationResponse>(callPayload);
            });
        }
    }

    public class MuhimbiTriggers([ConnectionName] string connectionId)
    {
    }

    public class OperationResponse
    {
        [JsonProperty("processed_file_content")]
        public string ProcessedFileContent { get; set; }

        [JsonProperty("base_file_name")]
        public string BaseFileName { get; set; }

        [JsonProperty("result_code")]
        public OperationResponseResultCodeType ResultCode { get; set; }

        [JsonProperty("result_details")]
        public string ResultDetails { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OperationResponseResultCodeType
    {
        Success,
        ProcessingError,
        SubscriptionNotFound,
        SubscriptionExpired,
        ActivationPending,
        TrialExpired,
        OperationSizeExceeded,
        OperationsExceeded,
        InputFileTypeNotSupported,
        OutputFileTypeNotSupported,
        OperationNotSupported,
        Accepted,
        AccessDenied,
        InvalidExtension
    }

    public class CompositeWatermarkInputDataInput
    {
        [JsonProperty("source_file_name")]
        public string SourceFileName { get; set; }

        [JsonProperty("use_async_pattern", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool UseAsyncPattern { get; set; } = false;

        [JsonProperty("source_file_content", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent SourceFileContent { get; set; }

        [JsonProperty("sharepoint_file")]
        public SharepointFile SharepointFile { get; set; }

        [JsonProperty("watermark_data", DefaultValueHandling = DefaultValueHandling.Include)]
        public string WatermarkData { get; set; }

        [JsonProperty("fail_on_error", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? FailOnError { get; set; } = true;
    }

    public class SharepointFile
    {
    }

    public class CompressPdfInputPdfDataInput
    {
        [JsonProperty("use_async_pattern", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool UseAsyncPattern { get; set; } = false;

        [JsonProperty("source_file_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceFileName { get; set; }

        [JsonProperty("sharepoint_file")]
        public SharepointFile SharepointFile { get; set; }

        [JsonProperty("source_file_content", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent SourceFileContent { get; set; }

        [JsonProperty("remove_annotations", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputPdfDataInputRemoveAnnotationsType? RemoveAnnotations { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputPdfDataInputRemoveAnnotationsType.Default;

        [JsonProperty("remove_blank_pages", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputPdfDataInputRemoveBlankPagesType? RemoveBlankPages { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputPdfDataInputRemoveBlankPagesType.Default;

        [JsonProperty("remove_bookmarks", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputPdfDataInputRemoveBookmarksType? RemoveBookmarks { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputPdfDataInputRemoveBookmarksType.Default;

        [JsonProperty("remove_embedded_files", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputPdfDataInputRemoveEmbeddedFilesType? RemoveEmbeddedFiles { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputPdfDataInputRemoveEmbeddedFilesType.Default;

        [JsonProperty("remove_form_fields", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputPdfDataInputRemoveFormFieldsType? RemoveFormFields { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputPdfDataInputRemoveFormFieldsType.Default;

        [JsonProperty("remove_hyperlinks", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputPdfDataInputRemoveHyperlinksType? RemoveHyperlinks { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputPdfDataInputRemoveHyperlinksType.Default;

        [JsonProperty("remove_javascript", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputPdfDataInputRemoveJavaScriptType? RemoveJavaScript { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputPdfDataInputRemoveJavaScriptType.Default;

        [JsonProperty("remove_metadata", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputPdfDataInputRemoveMetadataType? RemoveMetadata { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputPdfDataInputRemoveMetadataType.Default;

        [JsonProperty("remove_page_thumbnails", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputPdfDataInputRemovePageThumbnailsType? RemovePageThumbnails { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputPdfDataInputRemovePageThumbnailsType.Default;

        [JsonProperty("pack_fonts", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputPdfDataInputPackFontsType? PackFonts { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputPdfDataInputPackFontsType.Default;

        [JsonProperty("pack_document", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputPdfDataInputPackDocumentType? PackDocument { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputPdfDataInputPackDocumentType.Default;

        [JsonProperty("recompress_images", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputPdfDataInputRecompressImagesType? RecompressImages { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputPdfDataInputRecompressImagesType.Default;

        [JsonProperty("enable_mrc", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputPdfDataInputEnableMRCType? EnableMRC { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputPdfDataInputEnableMRCType.Default;

        [JsonProperty("downscale_resolution_mrc", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? DownscaleResolutionMRC { get; set; } = 100;

        [JsonProperty("preserve_smoothing", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputPdfDataInputPreserveSmoothingType? PreserveSmoothing { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputPdfDataInputPreserveSmoothingType.Default;

        [JsonProperty("image_quality", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputPdfDataInputImageQualityType? ImageQuality { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputPdfDataInputImageQualityType.Default;

        [JsonProperty("downscale_images", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputPdfDataInputDownscaleImagesType? DownscaleImages { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputPdfDataInputDownscaleImagesType.Default;

        [JsonProperty("downscale_resolution", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? DownscaleResolution { get; set; } = 200;

        [JsonProperty("enable_color_detection", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputPdfDataInputEnableColorDetectionType? EnableColorDetection { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputPdfDataInputEnableColorDetectionType.Default;

        [JsonProperty("enable_char_repair", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputPdfDataInputEnableCharRepairType? EnableCharRepair { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputPdfDataInputEnableCharRepairType.Default;

        [JsonProperty("enable_jpeg2000", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputPdfDataInputEnableJPEG2000Type? EnableJPEG2000 { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputPdfDataInputEnableJPEG2000Type.Default;

        [JsonProperty("enable_jbig2", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputPdfDataInputEnableJBIG2Type? EnableJBIG2 { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputPdfDataInputEnableJBIG2Type.Default;

        [JsonProperty("jbig2_pms_threshold", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? JBIG2PMSThreshold { get; set; } = 85;

        [JsonProperty("override_settings")]
        public string OverrideSettings { get; set; }

        [JsonProperty("fail_on_error", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? FailOnError { get; set; } = true;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputPdfDataInputRemoveAnnotationsType
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputPdfDataInputRemoveBlankPagesType
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputPdfDataInputRemoveBookmarksType
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputPdfDataInputRemoveEmbeddedFilesType
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputPdfDataInputRemoveFormFieldsType
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputPdfDataInputRemoveHyperlinksType
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputPdfDataInputRemoveJavaScriptType
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputPdfDataInputRemoveMetadataType
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputPdfDataInputRemovePageThumbnailsType
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputPdfDataInputPackFontsType
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputPdfDataInputPackDocumentType
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputPdfDataInputRecompressImagesType
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputPdfDataInputEnableMRCType
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputPdfDataInputPreserveSmoothingType
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputPdfDataInputImageQualityType
    {
        Default,
        [EnumMember(Value = "Very Very High")]
        VeryVeryHigh,
        [EnumMember(Value = "Very High")]
        VeryHigh,
        High,
        Medium,
        Low,
        [EnumMember(Value = "Very Low")]
        VeryLow
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputPdfDataInputDownscaleImagesType
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputPdfDataInputEnableColorDetectionType
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputPdfDataInputEnableCharRepairType
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputPdfDataInputEnableJPEG2000Type
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputPdfDataInputEnableJBIG2Type
    {
        Default,
        Yes,
        No
    }

    public class ConvertInputDataInput
    {
        [JsonProperty("use_async_pattern", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool UseAsyncPattern { get; set; } = false;

        [JsonProperty("source_file_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceFileName { get; set; }

        [JsonProperty("source_file_content", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent SourceFileContent { get; set; }

        [JsonProperty("sharepoint_file")]
        public SharepointFile SharepointFile { get; set; }

        [JsonProperty("output_format", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputOutputFormatType OutputFormat { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputDataInputOutputFormatType.PDF;

        [JsonProperty("copy_metadata", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool CopyMetadata { get; set; } = false;

        [JsonProperty("override_settings")]
        public string OverrideSettings { get; set; }

        [JsonProperty("template_file_content")]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent TemplateFileContent { get; set; }

        [JsonProperty("fail_on_error", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? FailOnError { get; set; } = true;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputDataInputOutputFormatType
    {
        PDF,
        XPS,
        DOCX,
        DOC,
        ODT,
        RTF,
        TXT,
        MHT,
        HTML,
        XML,
        XLS,
        XLSX,
        CSV,
        ODS,
        PPT,
        PPTX,
        ODP,
        PPS,
        PPSX,
        TIFF,
        PNG,
        GIF,
        JPG,
        BMP,
        PS,
        PCL,
        EPS,
        FDF,
        XFDF
    }

    public class InputCadDataInput
    {
        [JsonProperty("use_async_pattern", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool UseAsyncPattern { get; set; } = false;

        [JsonProperty("source_file_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceFileName { get; set; }

        [JsonProperty("sharepoint_file")]
        public SharepointFile SharepointFile { get; set; }

        [JsonProperty("source_file_content", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent SourceFileContent { get; set; }

        [JsonProperty("copy_metadata", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool CopyMetadata { get; set; } = false;

        [JsonProperty("paper_size", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputCadDataInputPaperSizeType? PaperSize { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputCadDataInputPaperSizeType.Letter;

        [JsonProperty("paper_size_custom")]
        public string PaperSizeCustom { get; set; }

        [JsonProperty("page_margins", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PageMargins { get; set; } = "0.25";

        [JsonProperty("background_color", DefaultValueHandling = DefaultValueHandling.Include)]
        public string BackgroundColor { get; set; } = "White";

        [JsonProperty("foreground_color", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputCadDataInputForegroundColorType? ForegroundColor { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputCadDataInputForegroundColorType.GreyscaleDarken;

        [JsonProperty("foreground_color_custom")]
        public string ForegroundColorCustom { get; set; }

        [JsonProperty("empty_layout_detection_mode", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputCadDataInputEmptyLayoutDetectionType? EmptyLayoutDetection { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputCadDataInputEmptyLayoutDetectionType.SkipEmptyLayouts;

        [JsonProperty("layout_sort_order", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputCadDataInputLayoutSortOrderType? LayoutSortOrder { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputCadDataInputLayoutSortOrderType.Ascending;

        [JsonProperty("start_page")]
        public int? StartPage { get; set; }

        [JsonProperty("end_page")]
        public int? EndPage { get; set; }

        [JsonProperty("override_settings")]
        public string OverrideSettings { get; set; }

        [JsonProperty("fail_on_error", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? FailOnError { get; set; } = true;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputCadDataInputPaperSizeType
    {
        A3,
        A4,
        A5,
        Legal,
        Letter,
        Custom
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputCadDataInputForegroundColorType
    {
        Default,
        CorrectForBackground,
        Greyscale,
        GreyscaleDarken,
        GreyscaleLighten,
        Darken,
        Lighten,
        Custom
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputCadDataInputEmptyLayoutDetectionType
    {
        Default,
        SkipNone,
        SkipEmptyLayouts,
        SkipLayoutsWithoutViewports
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputCadDataInputLayoutSortOrderType
    {
        Default,
        Ascending,
        Descending,
        TabOrder
    }

    public class InputEmailDataInput
    {
        [JsonProperty("use_async_pattern", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool UseAsyncPattern { get; set; } = false;

        [JsonProperty("source_file_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceFileName { get; set; }

        [JsonProperty("sharepoint_file")]
        public SharepointFile SharepointFile { get; set; }

        [JsonProperty("source_file_content", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent SourceFileContent { get; set; }

        [JsonProperty("copy_metadata", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool CopyMetadata { get; set; } = false;

        [JsonProperty("convert_attachments", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IncludeAttachments { get; set; } = true;

        [JsonProperty("attachment_merge_mode")]
        public InputEmailDataInputAttachmentActionType? AttachmentAction { get; set; }

        [JsonProperty("display_attachment_summary", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AttachmentSummary { get; set; } = true;

        [JsonProperty("unsupported_attachment_behaviour", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputEmailDataInputUnsupportedAttachmentActionType? UnsupportedAttachmentAction { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputEmailDataInputUnsupportedAttachmentActionType.Error;

        [JsonProperty("include_attachment_types")]
        public string IncludeAttachmentFilter { get; set; }

        [JsonProperty("exclude_attachment_types")]
        public string ExcludeAttachmentFilter { get; set; }

        [JsonProperty("viewport_Size", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ViewportSize { get; set; } = "Paper";

        [JsonProperty("paper_size", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputEmailDataInputPaperSizeType? PaperSize { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputEmailDataInputPaperSizeType.Letter;

        [JsonProperty("paper_size_custom")]
        public string PaperSizeCustom { get; set; }

        [JsonProperty("page_margins", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PageMargins { get; set; } = "0.5,0.5,0.5,0.5";

        [JsonProperty("break_merge_on_error")]
        public bool? AttachmentErrors { get; set; }

        [JsonProperty("minimum_image_attachment_dimension", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MinImageSize { get; set; } = 150;

        [JsonProperty("enable_offline_mode", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OfflineMode { get; set; } = false;

        [JsonProperty("start_page")]
        public int? StartPage { get; set; }

        [JsonProperty("end_page")]
        public int? EndPage { get; set; }

        [JsonProperty("quality")]
        public InputEmailDataInputConversionQualityType? ConversionQuality { get; set; }

        [JsonProperty("override_settings")]
        public string OverrideSettings { get; set; }

        [JsonProperty("fail_on_error", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? FailOnError { get; set; } = true;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputEmailDataInputAttachmentActionType
    {
        Default,
        Merge,
        AttachAsPDF,
        AttachOriginal
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputEmailDataInputUnsupportedAttachmentActionType
    {
        Error,
        Remove,
        AttachOriginal
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputEmailDataInputPaperSizeType
    {
        A3,
        A4,
        A5,
        Legal,
        Letter,
        Custom
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputEmailDataInputConversionQualityType
    {
        OptimizeForPrint,
        OptimizeForOnScreen,
        Original
    }

    public class InputExcelDataInput
    {
        [JsonProperty("use_async_pattern", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool UseAsyncPattern { get; set; } = false;

        [JsonProperty("source_file_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceFileName { get; set; }

        [JsonProperty("sharepoint_file")]
        public SharepointFile SharepointFile { get; set; }

        [JsonProperty("source_file_content", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent SourceFileContent { get; set; }

        [JsonProperty("output_format", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputExcelDataInputOutputFormatType OutputFormat { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputExcelDataInputOutputFormatType.PDF;

        [JsonProperty("copy_metadata", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool CopyMetadata { get; set; } = false;

        [JsonProperty("range")]
        public InputExcelDataInputRangeType? Range { get; set; }

        [JsonProperty("unhide_all_rows", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RevealHiddenRows { get; set; } = false;

        [JsonProperty("unhide_all_columns", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RevealHiddenColumns { get; set; } = false;

        [JsonProperty("fit_to_pages_wide")]
        public int? FitToPagesWide { get; set; }

        [JsonProperty("fit_to_pages_tall")]
        public int? FitToPagesTall { get; set; }

        [JsonProperty("start_page")]
        public int? StartPage { get; set; }

        [JsonProperty("end_page")]
        public int? EndPage { get; set; }

        [JsonProperty("quality")]
        public InputExcelDataInputQualityType? Quality { get; set; }

        [JsonProperty("override_settings")]
        public string OverrideSettings { get; set; }

        [JsonProperty("fail_on_error", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? FailOnError { get; set; } = true;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputExcelDataInputOutputFormatType
    {
        PDF,
        XPS,
        DOCX,
        DOC,
        ODT,
        RTF,
        TXT,
        MHT,
        HTML,
        XML,
        XLS,
        XLSX,
        CSV,
        ODS
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputExcelDataInputRangeType
    {
        VisibleDocuments,
        AllDocuments,
        ActiveDocuments
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputExcelDataInputQualityType
    {
        OptimizeForPrint,
        OptimizeForOnScreen,
        Original
    }

    public class ConvertHtmlInputDataInput
    {
        [JsonProperty("use_async_pattern", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool UseAsyncPattern { get; set; } = false;

        [JsonProperty("source_url_or_html", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceURLOrHTML { get; set; }

        [JsonProperty("page_orientation", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputPageOrientationType? PageOrientation { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputDataInputPageOrientationType.Portrait;

        [JsonProperty("media_type", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputMediaTypeType? MediaType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputDataInputMediaTypeType.Screen;

        [JsonProperty("authentication_type", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputAuthenticationTypeType? AuthenticationType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputDataInputAuthenticationTypeType.Anonymous;

        [JsonProperty("username")]
        public string UserName { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("viewport_size")]
        public string ViewportSize { get; set; }

        [JsonProperty("conversion_delay")]
        public int? ConversionDelay { get; set; }

        [JsonProperty("fail_on_error", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? FailOnError { get; set; } = true;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputDataInputPageOrientationType
    {
        Portrait,
        Landscape
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputDataInputMediaTypeType
    {
        Screen,
        Print
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputDataInputAuthenticationTypeType
    {
        Anonymous,
        [EnumMember(Value = "SharePoint Online")]
        SharePointOnline,
        Web
    }

    public class InputInfopathDataInput
    {
        [JsonProperty("use_async_pattern", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool UseAsyncPattern { get; set; } = false;

        [JsonProperty("source_file_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceFileName { get; set; }

        [JsonProperty("sharepoint_file")]
        public SharepointFile SharepointFile { get; set; }

        [JsonProperty("source_file_content", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent SourceFileContent { get; set; }

        [JsonProperty("output_format", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputInfopathDataInputOutputFormatType OutputFormat { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputInfopathDataInputOutputFormatType.PDF;

        [JsonProperty("copy_metadata", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool CopyMetadata { get; set; } = false;

        [JsonProperty("template_file_content")]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent TemplateFileContent { get; set; }

        [JsonProperty("views_to_convert")]
        public string ViewNames { get; set; }

        [JsonProperty("convert_attachments", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IncludeAttachment { get; set; } = true;

        [JsonProperty("attachment_merge_mode")]
        public InputInfopathDataInputAttachmentActionType? AttachmentAction { get; set; }

        [JsonProperty("unsupported_attachment_behaviour")]
        public InputInfopathDataInputUnsupportedAttachmentActionType? UnsupportedAttachmentAction { get; set; }

        [JsonProperty("break_merge_on_error")]
        public bool? BreakMergeOnError { get; set; }

        [JsonProperty("include_attachment_types")]
        public string IncludeAttachmentFilter { get; set; }

        [JsonProperty("exclude_attachment_types")]
        public string ExcludeAttachmentFilter { get; set; }

        [JsonProperty("default_paper_size")]
        public InputInfopathDataInputDefaultPaperSizeType? DefaultPaperSize { get; set; }

        [JsonProperty("default_paper_size_custom")]
        public string DefaultPaperSizeCustom { get; set; }

        [JsonProperty("force_paper_size")]
        public InputInfopathDataInputForcePaperSizeType? ForcePaperSize { get; set; }

        [JsonProperty("force_paper_size_custom")]
        public string ForcePaperSizeCustom { get; set; }

        [JsonProperty("default_page_orientation", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputInfopathDataInputDefaultPageOrientationType? DefaultPageOrientation { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputInfopathDataInputDefaultPageOrientationType.Default;

        [JsonProperty("force_page_orientation")]
        public InputInfopathDataInputForcePageOrientationType? ForcePageOrientation { get; set; }

        [JsonProperty("start_page")]
        public int? StartPage { get; set; }

        [JsonProperty("end_page")]
        public int? EndPage { get; set; }

        [JsonProperty("quality")]
        public InputInfopathDataInputConversionQualityType? ConversionQuality { get; set; }

        [JsonProperty("override_settings")]
        public string OverrideSettings { get; set; }

        [JsonProperty("fail_on_error", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? FailOnError { get; set; } = true;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputInfopathDataInputOutputFormatType
    {
        PDF,
        XPS,
        DOCX,
        DOC,
        ODT,
        RTF,
        TXT,
        MHT,
        HTML,
        XML,
        XLS,
        XLSX,
        CSV,
        ODS
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputInfopathDataInputAttachmentActionType
    {
        Default,
        Merge,
        AttachAsPDF,
        AttachOriginal
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputInfopathDataInputUnsupportedAttachmentActionType
    {
        Error,
        Remove,
        AttachOriginal
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputInfopathDataInputDefaultPaperSizeType
    {
        A3,
        A4,
        A5,
        Legal,
        Letter,
        Custom
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputInfopathDataInputForcePaperSizeType
    {
        A3,
        A4,
        A5,
        Legal,
        Letter,
        Custom
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputInfopathDataInputDefaultPageOrientationType
    {
        Default,
        Portrait,
        Landscape,
        Both
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputInfopathDataInputForcePageOrientationType
    {
        Default,
        Portrait,
        Landscape,
        Both
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputInfopathDataInputConversionQualityType
    {
        OptimizeForPrint,
        OptimizeForOnScreen,
        Original
    }

    public class ConvertPdfaInputPdfDataInput
    {
        [JsonProperty("use_async_pattern", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool UseAsyncPattern { get; set; } = false;

        [JsonProperty("source_file_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceFileName { get; set; }

        [JsonProperty("sharepoint_file")]
        public SharepointFile SharepointFile { get; set; }

        [JsonProperty("source_file_content", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent SourceFileContent { get; set; }

        [JsonProperty("copy_metadata", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool CopyMetadata { get; set; } = false;

        [JsonProperty("pdf_profile", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputPdfDataInputPDFProfileType PDFProfile { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputPdfDataInputPDFProfileType.PDFA2B;

        [JsonProperty("override_settings")]
        public string OverrideSettings { get; set; }

        [JsonProperty("fail_on_error", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? FailOnError { get; set; } = true;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputPdfDataInputPDFProfileType
    {
        Default,
        [EnumMember(Value = "PDF_1_5")]
        PDF15,
        [EnumMember(Value = "PDF_A1B")]
        PDFA1B,
        [EnumMember(Value = "PDF_A2B")]
        PDFA2B,
        [EnumMember(Value = "PDF_A2U")]
        PDFA2U,
        [EnumMember(Value = "PDF_A3B")]
        PDFA3B,
        [EnumMember(Value = "PDF_A3U")]
        PDFA3U,
        [EnumMember(Value = "PDF_1_1")]
        PDF11,
        [EnumMember(Value = "PDF_1_2")]
        PDF12,
        [EnumMember(Value = "PDF_1_3")]
        PDF13,
        [EnumMember(Value = "PDF_1_4")]
        PDF14,
        [EnumMember(Value = "PDF_1_6")]
        PDF16,
        [EnumMember(Value = "PDF_1_7")]
        PDF17
    }

    public class InputPowerpointDataInput
    {
        [JsonProperty("use_async_pattern", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool UseAsyncPattern { get; set; } = false;

        [JsonProperty("source_file_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceFileName { get; set; }

        [JsonProperty("sharepoint_file")]
        public SharepointFile SharepointFile { get; set; }

        [JsonProperty("source_file_content", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent SourceFileContent { get; set; }

        [JsonProperty("output_format", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputPowerpointDataInputOutputFormatType OutputFormat { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputPowerpointDataInputOutputFormatType.PDF;

        [JsonProperty("copy_metadata", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool CopyMetadata { get; set; } = false;

        [JsonProperty("range")]
        public InputPowerpointDataInputRangeType? Range { get; set; }

        [JsonProperty("print_output_type", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputPowerpointDataInputPrintLayoutHandoutsType? PrintLayoutHandouts { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputPowerpointDataInputPrintLayoutHandoutsType.Slides;

        [JsonProperty("frame_slides", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? FrameSlides { get; set; } = true;

        [JsonProperty("start_page")]
        public int? StartPage { get; set; }

        [JsonProperty("end_page")]
        public int? EndPage { get; set; }

        [JsonProperty("quality")]
        public InputPowerpointDataInputQualityType? Quality { get; set; }

        [JsonProperty("override_settings")]
        public string OverrideSettings { get; set; }

        [JsonProperty("fail_on_error", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? FailOnError { get; set; } = true;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputPowerpointDataInputOutputFormatType
    {
        PDF,
        XPS,
        MHT,
        XML,
        PPT,
        PPTX,
        ODP,
        PPS,
        PPSX
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputPowerpointDataInputRangeType
    {
        VisibleDocuments,
        AllDocuments,
        ActiveDocuments
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputPowerpointDataInputPrintLayoutHandoutsType
    {
        Slides,
        OneSlideHandouts,
        TwoSlideHandouts,
        ThreeSlideHandouts,
        FourSlideHandouts,
        SixSlideHandouts,
        NineSlideHandouts,
        NotesPages,
        Outline
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputPowerpointDataInputQualityType
    {
        OptimizeForPrint,
        OptimizeForOnScreen,
        Original
    }

    public class InputVisioDataInput
    {
        [JsonProperty("use_async_pattern", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool UseAsyncPattern { get; set; } = false;

        [JsonProperty("source_file_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceFileName { get; set; }

        [JsonProperty("sharepoint_file")]
        public SharepointFile SharepointFile { get; set; }

        [JsonProperty("source_file_content", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent SourceFileContent { get; set; }

        [JsonProperty("output_format", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputVisioDataInputOutputFormatType OutputFormat { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputVisioDataInputOutputFormatType.PDF;

        [JsonProperty("copy_metadata", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool CopyMetadata { get; set; } = false;

        [JsonProperty("range")]
        public InputVisioDataInputRangeType? Range { get; set; }

        [JsonProperty("start_page")]
        public int? StartPage { get; set; }

        [JsonProperty("end_page")]
        public int? EndPage { get; set; }

        [JsonProperty("quality")]
        public InputVisioDataInputQualityType? Quality { get; set; }

        [JsonProperty("override_settings")]
        public string OverrideSettings { get; set; }

        [JsonProperty("fail_on_error", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? FailOnError { get; set; } = true;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputVisioDataInputOutputFormatType
    {
        PDF,
        XPS
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputVisioDataInputRangeType
    {
        AllDocuments,
        ActiveDocuments
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputVisioDataInputQualityType
    {
        OptimizeForPrint,
        OptimizeForOnScreen,
        Original
    }

    public class InputWordDataInput
    {
        [JsonProperty("use_async_pattern", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool UseAsyncPattern { get; set; } = false;

        [JsonProperty("source_file_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceFileName { get; set; }

        [JsonProperty("sharepoint_file")]
        public SharepointFile SharepointFile { get; set; }

        [JsonProperty("source_file_content", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent SourceFileContent { get; set; }

        [JsonProperty("output_format", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputWordDataInputOutputFormatType OutputFormat { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputWordDataInputOutputFormatType.PDF;

        [JsonProperty("copy_metadata", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool CopyMetadata { get; set; } = false;

        [JsonProperty("revisions_and_comments_display_mode", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputWordDataInputDisplayForReviewType? DisplayForReview { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputWordDataInputDisplayForReviewType.Final;

        [JsonProperty("revisions_and_comments_markup_mode", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputWordDataInputReviewMarkupModeType? ReviewMarkupMode { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputWordDataInputReviewMarkupModeType.InLine;

        [JsonProperty("generate_bookmarks")]
        public InputWordDataInputGenerateBookmarksType? GenerateBookmarks { get; set; }

        [JsonProperty("start_page")]
        public int? StartPage { get; set; }

        [JsonProperty("end_page")]
        public int? EndPage { get; set; }

        [JsonProperty("quality")]
        public InputWordDataInputQualityType? Quality { get; set; }

        [JsonProperty("override_settings")]
        public string OverrideSettings { get; set; }

        [JsonProperty("fail_on_error", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? FailOnError { get; set; } = true;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputWordDataInputOutputFormatType
    {
        PDF,
        XPS,
        DOCX,
        DOC,
        ODT,
        RTF,
        TXT,
        MHT,
        HTML,
        XML,
        XLS,
        XLSX,
        CSV,
        ODS
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputWordDataInputDisplayForReviewType
    {
        Final,
        Original,
        FinalShowingMarkup,
        OriginalShowingMarkup
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputWordDataInputReviewMarkupModeType
    {
        Balloon,
        InLine,
        Mixed
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputWordDataInputGenerateBookmarksType
    {
        Disabled,
        Automatic,
        Custom
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputWordDataInputQualityType
    {
        OptimizeForPrint,
        OptimizeForOnScreen,
        Original
    }

    public class OperationResponseCommon
    {
        [JsonProperty("base_file_name")]
        public string BaseFileName { get; set; }

        [JsonProperty("result_code")]
        public OperationResponseCommonResultCodeType ResultCode { get; set; }

        [JsonProperty("result_details")]
        public string ResultDetails { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OperationResponseCommonResultCodeType
    {
        Success,
        ProcessingError,
        SubscriptionNotFound,
        SubscriptionExpired,
        ActivationPending,
        TrialExpired,
        OperationSizeExceeded,
        OperationsExceeded,
        InputFileTypeNotSupported,
        OutputFileTypeNotSupported,
        OperationNotSupported,
        Accepted,
        AccessDenied,
        InvalidExtension
    }

    public class CopyMetadataInputDataInput
    {
        [JsonProperty("site_url", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SiteUrl { get; set; }

        [JsonProperty("source_file_url", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceFileUrl { get; set; }

        [JsonProperty("destination_file_url", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DestinationFilePath { get; set; }

        [JsonProperty("username")]
        public string UserName { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("copy_fields")]
        public string FieldsToCopy { get; set; }

        [JsonProperty("content_type")]
        public string DestinationContentType { get; set; }

        [JsonProperty("fail_on_error", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? FailOnError { get; set; } = true;
    }

    public class EllipseWatermarkInputDataInput
    {
        [JsonProperty("source_file_name")]
        public string SourceFileName { get; set; }

        [JsonProperty("use_async_pattern", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool UseAsyncPattern { get; set; } = false;

        [JsonProperty("source_file_content", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent SourceFileContent { get; set; }

        [JsonProperty("position", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputPositionType Position { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputDataInputPositionType.MiddleCenter;

        [JsonProperty("sharepoint_file")]
        public SharepointFile SharepointFile { get; set; }

        [JsonProperty("width", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Width { get; set; }

        [JsonProperty("height", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Height { get; set; }

        [JsonProperty("x")]
        public string XCoordinate { get; set; }

        [JsonProperty("y")]
        public string YCoordinate { get; set; }

        [JsonProperty("layer", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputLayerType? Layer { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputDataInputLayerType.Foreground;

        [JsonProperty("rotation")]
        public string Rotation { get; set; }

        [JsonProperty("opacity", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Opacity { get; set; } = "100";

        [JsonProperty("fill_color")]
        public string FillColor { get; set; }

        [JsonProperty("line_color")]
        public string LineColor { get; set; }

        [JsonProperty("line_width")]
        public string LineWidth { get; set; }

        [JsonProperty("start_page")]
        public int? WatermarkStartPage { get; set; }

        [JsonProperty("end_page")]
        public int? WatermarkEndPage { get; set; }

        [JsonProperty("page_interval")]
        public int? WatermarkPageInterval { get; set; }

        [JsonProperty("page_orientation", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputWatermarkPageOrientationType? WatermarkPageOrientation { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputDataInputWatermarkPageOrientationType.Both;

        [JsonProperty("print_only", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputPrintOnlyType? PrintOnly { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputDataInputPrintOnlyType.False;

        [JsonProperty("start_section")]
        public int? WatermarkStartSection { get; set; }

        [JsonProperty("end_section")]
        public int? WatermarkEndSection { get; set; }

        [JsonProperty("page_type")]
        public string WatermarkPageType { get; set; }

        [JsonProperty("fail_on_error", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? FailOnError { get; set; } = true;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputDataInputPositionType
    {
        [EnumMember(Value = "Top Left")]
        TopLeft,
        [EnumMember(Value = "Top Center")]
        TopCenter,
        [EnumMember(Value = "Top Right")]
        TopRight,
        [EnumMember(Value = "Middle Left")]
        MiddleLeft,
        [EnumMember(Value = "Middle Center")]
        MiddleCenter,
        [EnumMember(Value = "Middle Right")]
        MiddleRight,
        [EnumMember(Value = "Bottom Left")]
        BottomLeft,
        [EnumMember(Value = "Bottom Center")]
        BottomCenter,
        [EnumMember(Value = "Bottom Right")]
        BottomRight,
        Absolute,
        Random
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputDataInputLayerType
    {
        Background,
        Foreground
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputDataInputWatermarkPageOrientationType
    {
        Portrait,
        Landscape,
        Both
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputDataInputPrintOnlyType
    {
        [EnumMember(Value = "false")]
        False,
        [EnumMember(Value = "true")]
        True
    }

    public class InputFromPdfDataInput
    {
        [JsonProperty("use_async_pattern", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool UseAsyncPattern { get; set; } = false;

        [JsonProperty("source_file_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceFileName { get; set; }

        [JsonProperty("sharepoint_file")]
        public SharepointFile SharepointFile { get; set; }

        [JsonProperty("source_file_content", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent SourceFileContent { get; set; }

        [JsonProperty("output_format", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputFromPdfDataInputOutputDataFormatType OutputDataFormat { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputFromPdfDataInputOutputDataFormatType.XML;

        [JsonProperty("copy_metadata", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool CopyMetadata { get; set; } = false;

        [JsonProperty("fail_on_error", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? FailOnError { get; set; } = true;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputFromPdfDataInputOutputDataFormatType
    {
        XML,
        FDF,
        XFDF
    }

    public class ExtractTextInputPdfDataInput
    {
        [JsonProperty("use_async_pattern", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool UseAsyncPattern { get; set; } = false;

        [JsonProperty("source_file_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceFileName { get; set; }

        [JsonProperty("sharepoint_file")]
        public SharepointFile SharepointFile { get; set; }

        [JsonProperty("source_file_content", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent SourceFileContent { get; set; }

        [JsonProperty("page_range", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PageRange { get; set; } = "*";

        [JsonProperty("fail_on_error", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? FailOnError { get; set; } = true;
    }

    public class ImageWatermarkInputDataInput
    {
        [JsonProperty("source_file_name")]
        public string SourceFileName { get; set; }

        [JsonProperty("use_async_pattern", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool UseAsyncPattern { get; set; } = false;

        [JsonProperty("source_file_content", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent SourceFileContent { get; set; }

        [JsonProperty("image_file", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent Image { get; set; }

        [JsonProperty("sharepoint_file")]
        public SharepointFile SharepointFile { get; set; }

        [JsonProperty("position", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputPositionType Position { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputDataInputPositionType.MiddleCenter;

        [JsonProperty("width", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Width { get; set; }

        [JsonProperty("height", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Height { get; set; }

        [JsonProperty("x")]
        public string XCoordinate { get; set; }

        [JsonProperty("y")]
        public string YCoordinate { get; set; }

        [JsonProperty("layer", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputLayerType? Layer { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputDataInputLayerType.Foreground;

        [JsonProperty("rotation")]
        public string Rotation { get; set; }

        [JsonProperty("opacity", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Opacity { get; set; } = "100";

        [JsonProperty("fill_color")]
        public string WatermarkBackgroundColor { get; set; }

        [JsonProperty("line_color")]
        public string WatermarkOutlineColor { get; set; }

        [JsonProperty("line_width")]
        public string WatermarkOutlineWidth { get; set; }

        [JsonProperty("start_page")]
        public int? WatermarkStartPage { get; set; }

        [JsonProperty("end_page")]
        public int? WatermarkEndPage { get; set; }

        [JsonProperty("page_interval")]
        public int? WatermarkPageInterval { get; set; }

        [JsonProperty("page_orientation", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputWatermarkPageOrientationType? WatermarkPageOrientation { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputDataInputWatermarkPageOrientationType.Both;

        [JsonProperty("print_only", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputPrintOnlyType? PrintOnly { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputDataInputPrintOnlyType.False;

        [JsonProperty("start_section")]
        public int? WatermarkStartSection { get; set; }

        [JsonProperty("end_section")]
        public int? WatermarkEndSection { get; set; }

        [JsonProperty("page_type")]
        public string WatermarkPageType { get; set; }

        [JsonProperty("fail_on_error", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? FailOnError { get; set; } = true;
    }

    public class InputXmlDataInput
    {
        [JsonProperty("use_async_pattern", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool UseAsyncPattern { get; set; } = false;

        [JsonProperty("source_file_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceFileName { get; set; }

        [JsonProperty("sharepoint_file")]
        public SharepointFile SharepointFile { get; set; }

        [JsonProperty("source_file_content", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent SourceFileContent { get; set; }

        [JsonProperty("copy_metadata", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool CopyMetadata { get; set; } = false;

        [JsonProperty("pdf_template_file_content")]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent PDFFormFileContent { get; set; }

        [JsonProperty("pdf_template_url")]
        public string PDFFormURL { get; set; }

        [JsonProperty("pdf_template_username")]
        public string Username { get; set; }

        [JsonProperty("pdf_template_domain")]
        public string Domain { get; set; }

        [JsonProperty("pdf_template_password")]
        public string Password { get; set; }

        [JsonProperty("flatten", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputXmlDataInputFlattenType? Flatten { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputXmlDataInputFlattenType.Default;

        [JsonProperty("read_only", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputXmlDataInputReadOnlyType? ReadOnly { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputXmlDataInputReadOnlyType.Default;

        [JsonProperty("override_settings")]
        public string OverrideSettings { get; set; }

        [JsonProperty("fail_on_error", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? FailOnError { get; set; } = true;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputXmlDataInputFlattenType
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputXmlDataInputReadOnlyType
    {
        Default,
        Yes,
        No
    }

    public class ExtractKeyValuePairsInputPdfDataInput
    {
        [JsonProperty("use_async_pattern", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool UseAsyncPattern { get; set; } = false;

        [JsonProperty("source_file_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceFileName { get; set; }

        [JsonProperty("sharepoint_file")]
        public SharepointFile SharepointFile { get; set; }

        [JsonProperty("source_file_content", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent SourceFileContent { get; set; }

        [JsonProperty("ocr_language", DefaultValueHandling = DefaultValueHandling.Include)]
        public string OCRLanguage { get; set; } = "eng";

        [JsonProperty("dpi", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputPdfDataInputDPIType? DPI { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputPdfDataInputDPIType._300;

        [JsonProperty("kvp_format", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputPdfDataInputKVPOutputFormatType? KVPOutputFormat { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputPdfDataInputKVPOutputFormatType.Json;

        [JsonProperty("page_range", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PageRange { get; set; } = "*";

        [JsonProperty("autorotate", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputPdfDataInputAutorotateType? Autorotate { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputPdfDataInputAutorotateType.Default;

        [JsonProperty("trim_symbols", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputPdfDataInputTrimSymbolsType? TrimSymbols { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputPdfDataInputTrimSymbolsType.Default;

        [JsonProperty("include_key_bounding_box", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputPdfDataInputIncludeKeyBoundingBoxType? IncludeKeyBoundingBox { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputPdfDataInputIncludeKeyBoundingBoxType.Default;

        [JsonProperty("include_value_bounding_box", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputPdfDataInputIncludeValueBoundingBoxType? IncludeValueBoundingBox { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputPdfDataInputIncludeValueBoundingBoxType.Default;

        [JsonProperty("include_page_number", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputPdfDataInputIncludePageNumberType? IncludePageNumber { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputPdfDataInputIncludePageNumberType.Default;

        [JsonProperty("include_confidence", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputPdfDataInputIncludeConfidenceType? IncludeConfidence { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputPdfDataInputIncludeConfidenceType.Default;

        [JsonProperty("confidence_threshold", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? ConfidenceThreshold { get; set; } = 50;

        [JsonProperty("include_type", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputPdfDataInputIncludeTypeType? IncludeType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputPdfDataInputIncludeTypeType.Default;

        [JsonProperty("expected_keys")]
        public string ExpectedKeys { get; set; }

        [JsonProperty("fail_on_error", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? FailOnError { get; set; } = true;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputPdfDataInputDPIType
    {
        [EnumMember(Value = "500")]
        _500,
        [EnumMember(Value = "400")]
        _400,
        [EnumMember(Value = "300")]
        _300,
        [EnumMember(Value = "200")]
        _200,
        [EnumMember(Value = "150")]
        _150
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputPdfDataInputKVPOutputFormatType
    {
        [EnumMember(Value = "json")]
        Json,
        [EnumMember(Value = "csv")]
        Csv,
        [EnumMember(Value = "xml")]
        Xml
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputPdfDataInputAutorotateType
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputPdfDataInputTrimSymbolsType
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputPdfDataInputIncludeKeyBoundingBoxType
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputPdfDataInputIncludeValueBoundingBoxType
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputPdfDataInputIncludePageNumberType
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputPdfDataInputIncludeConfidenceType
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputPdfDataInputIncludeTypeType
    {
        Default,
        Yes,
        No
    }

    public class LineWatermarkInputDataInput
    {
        [JsonProperty("source_file_name")]
        public string SourceFileName { get; set; }

        [JsonProperty("use_async_pattern", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool UseAsyncPattern { get; set; } = false;

        [JsonProperty("source_file_content", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent SourceFileContent { get; set; }

        [JsonProperty("position", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputPositionType Position { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputDataInputPositionType.MiddleCenter;

        [JsonProperty("sharepoint_file")]
        public SharepointFile SharepointFile { get; set; }

        [JsonProperty("x", DefaultValueHandling = DefaultValueHandling.Include)]
        public string XCoordinateStart { get; set; }

        [JsonProperty("y", DefaultValueHandling = DefaultValueHandling.Include)]
        public string YCoordinateStart { get; set; }

        [JsonProperty("end_x", DefaultValueHandling = DefaultValueHandling.Include)]
        public string XCoordinateEnd { get; set; }

        [JsonProperty("end_y", DefaultValueHandling = DefaultValueHandling.Include)]
        public string YCoordinateEnd { get; set; }

        [JsonProperty("layer", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputLayerType? Layer { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputDataInputLayerType.Foreground;

        [JsonProperty("rotation")]
        public string Rotation { get; set; }

        [JsonProperty("opacity", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Opacity { get; set; } = "100";

        [JsonProperty("line_color")]
        public string LineColor { get; set; }

        [JsonProperty("line_width")]
        public string LineWidth { get; set; }

        [JsonProperty("start_page")]
        public int? WatermarkStartPage { get; set; }

        [JsonProperty("end_page")]
        public int? WatermarkEndPage { get; set; }

        [JsonProperty("page_interval")]
        public int? WatermarkPageInterval { get; set; }

        [JsonProperty("page_orientation", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputWatermarkPageOrientationType? WatermarkPageOrientation { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputDataInputWatermarkPageOrientationType.Both;

        [JsonProperty("print_only", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputPrintOnlyType? PrintOnly { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputDataInputPrintOnlyType.False;

        [JsonProperty("start_section")]
        public int? WatermarkStartSection { get; set; }

        [JsonProperty("end_section")]
        public int? WatermarkEndSection { get; set; }

        [JsonProperty("page_type")]
        public string WatermarkPageType { get; set; }

        [JsonProperty("fail_on_error", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? FailOnError { get; set; } = true;
    }

    public class LinearBarcodeWatermarkInputDataInput
    {
        [JsonProperty("source_file_name")]
        public string SourceFileName { get; set; }

        [JsonProperty("use_async_pattern", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool UseAsyncPattern { get; set; } = false;

        [JsonProperty("source_file_content", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent SourceFileContent { get; set; }

        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public string BarcodeContent { get; set; }

        [JsonProperty("sharepoint_file")]
        public SharepointFile SharepointFile { get; set; }

        [JsonProperty("barcode_type", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputBarcodeTypeType BarcodeType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputDataInputBarcodeTypeType.Codabar;

        [JsonProperty("omit_start_stop_symbols", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputOmitEncodingOfStartStopSymbolsType? OmitEncodingOfStartStopSymbols { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputDataInputOmitEncodingOfStartStopSymbolsType.False;

        [JsonProperty("disable_checkdigit", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputDisableCheckDigitType DisableCheckDigit { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputDataInputDisableCheckDigitType.False;

        [JsonProperty("show_checkdigit", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputShowCheckDigitType ShowCheckDigit { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputDataInputShowCheckDigitType.False;

        [JsonProperty("margin")]
        public string Margin { get; set; }

        [JsonProperty("font_family_name")]
        public string FontFamily { get; set; }

        [JsonProperty("font_size")]
        public string FontSize { get; set; }

        [JsonProperty("font_style")]
        public string FontStyle { get; set; }

        [JsonProperty("label_placement", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputLabelPlacementType? LabelPlacement { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputDataInputLabelPlacementType.BottomCenter;

        [JsonProperty("position", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputPositionType Position { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputDataInputPositionType.MiddleCenter;

        [JsonProperty("width", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Width { get; set; }

        [JsonProperty("height", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Height { get; set; }

        [JsonProperty("x")]
        public string XCoordinate { get; set; }

        [JsonProperty("y")]
        public string YCoordinate { get; set; }

        [JsonProperty("layer", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputLayerType? Layer { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputDataInputLayerType.Foreground;

        [JsonProperty("rotation")]
        public string Rotation { get; set; }

        [JsonProperty("opacity", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Opacity { get; set; } = "100";

        [JsonProperty("fill_color")]
        public string BarcodeBackgroundColor { get; set; }

        [JsonProperty("line_color")]
        public string BarcodeBarColor { get; set; }

        [JsonProperty("start_page")]
        public int? WatermarkStartPage { get; set; }

        [JsonProperty("end_page")]
        public int? WatermarkEndPage { get; set; }

        [JsonProperty("page_interval")]
        public int? WatermarkPageInterval { get; set; }

        [JsonProperty("page_orientation", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputWatermarkPageOrientationType? WatermarkPageOrientation { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputDataInputWatermarkPageOrientationType.Both;

        [JsonProperty("print_only", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputPrintOnlyType? PrintOnly { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputDataInputPrintOnlyType.False;

        [JsonProperty("start_section")]
        public int? WatermarkStartSection { get; set; }

        [JsonProperty("end_section")]
        public int? WatermarkEndSection { get; set; }

        [JsonProperty("page_type")]
        public string WatermarkPageType { get; set; }

        [JsonProperty("fail_on_error", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? FailOnError { get; set; } = true;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputDataInputBarcodeTypeType
    {
        Codabar,
        Code11,
        Code32,
        Code39,
        Code39Extended,
        Code93,
        Code93Extended,
        Code128,
        Code128A,
        Code128B,
        Code128C,
        GS1Code128,
        [EnumMember(Value = "UPC_A")]
        UPCA
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputDataInputOmitEncodingOfStartStopSymbolsType
    {
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputDataInputDisableCheckDigitType
    {
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputDataInputShowCheckDigitType
    {
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputDataInputLabelPlacementType
    {
        [EnumMember(Value = "Top Left")]
        TopLeft,
        [EnumMember(Value = "Top Center")]
        TopCenter,
        [EnumMember(Value = "Top Right")]
        TopRight,
        None,
        [EnumMember(Value = "Bottom Left")]
        BottomLeft,
        [EnumMember(Value = "Bottom Center")]
        BottomCenter,
        [EnumMember(Value = "Bottom Right")]
        BottomRight
    }

    public class MergeToPdfInputDataInput
    {
        [JsonProperty("use_async_pattern", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool UseAsyncPattern { get; set; } = false;

        [JsonProperty("source_file_name_1")]
        public string SourceFileName1 { get; set; }

        [JsonProperty("source_file_content_1")]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent SourceFileContent1 { get; set; }

        [JsonProperty("source_file_name_2")]
        public string SourceFileName2 { get; set; }

        [JsonProperty("source_file_content_2")]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent SourceFileContent2 { get; set; }

        [JsonProperty("source_file_name_3")]
        public string SourceFileName3 { get; set; }

        [JsonProperty("source_file_content_3")]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent SourceFileContent3 { get; set; }

        [JsonProperty("source_file_name_4")]
        public string SourceFileName4 { get; set; }

        [JsonProperty("source_file_content_4")]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent SourceFileContent4 { get; set; }

        [JsonProperty("source_file_name_5")]
        public string SourceFileName5 { get; set; }

        [JsonProperty("source_file_content_5")]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent SourceFileContent5 { get; set; }

        [JsonProperty("sharepoint_file")]
        public SharepointFile SharepointFile { get; set; }

        [JsonProperty("document_start_page", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputEachDocumentType? EachDocument { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputDataInputEachDocumentType.StartsOnTheNextPage;

        [JsonProperty("source_files")]
        public MergeSourceFile[] SourceFiles { get; set; }

        [JsonProperty("override_settings")]
        public string OverrideSettings { get; set; }

        [JsonProperty("fail_on_error", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? FailOnError { get; set; } = true;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputDataInputEachDocumentType
    {
        [EnumMember(Value = "Starts on the default page")]
        StartsOnTheDefaultPage,
        [EnumMember(Value = "Starts on the next page")]
        StartsOnTheNextPage,
        [EnumMember(Value = "Starts on the next odd page")]
        StartsOnTheNextOddPage,
        [EnumMember(Value = "Starts on the next even page")]
        StartsOnTheNextEvenPage
    }

    public class MergeSourceFile
    {
        [JsonProperty("source_file_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("source_file_content", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent Content { get; set; }
    }

    public class OcrPdfInputDataInput
    {
        [JsonProperty("use_async_pattern", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool UseAsyncPattern { get; set; } = false;

        [JsonProperty("source_file_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceFileName { get; set; }

        [JsonProperty("source_file_content", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent SourceFileContent { get; set; }

        [JsonProperty("sharepoint_file")]
        public SharepointFile SharepointFile { get; set; }

        [JsonProperty("copy_metadata", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool MetaData { get; set; } = false;

        [JsonProperty("language", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputLanguageType? Language { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputDataInputLanguageType.English;

        [JsonProperty("performance", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputPerformanceType? Performance { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputDataInputPerformanceType.SlowButAccurate;

        [JsonProperty("characters_option", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputBlacklistWhitelistType? BlacklistWhitelist { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputDataInputBlacklistWhitelistType.None;

        [JsonProperty("characters")]
        public string Characters { get; set; }

        [JsonProperty("paginate", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? UsePagination { get; set; } = false;

        [JsonProperty("regions")]
        public string Regions { get; set; }

        [JsonProperty("fail_on_error", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? FailOnError { get; set; } = true;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputDataInputLanguageType
    {
        English,
        Arabic,
        Danish,
        German,
        Dutch,
        Finnish,
        French,
        Hebrew,
        Hungarian,
        Italian,
        Norwegian,
        Portuguese,
        Spanish,
        Swedish,
        Russian
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputDataInputPerformanceType
    {
        [EnumMember(Value = "Slow but accurate")]
        SlowButAccurate,
        [EnumMember(Value = "Faster and less accurate")]
        FasterAndLessAccurate,
        [EnumMember(Value = "Fastest and least accurate")]
        FastestAndLeastAccurate
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputDataInputBlacklistWhitelistType
    {
        None,
        Whitelist,
        Blacklist
    }

    public class OcrOperationResponse
    {
        [JsonProperty("out_text")]
        public string OutText { get; set; }

        [JsonProperty("base_file_name")]
        public string BaseFileName { get; set; }

        [JsonProperty("result_code")]
        public OcrOperationResponseResultCodeType ResultCode { get; set; }

        [JsonProperty("result_details")]
        public string ResultDetails { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OcrOperationResponseResultCodeType
    {
        Success,
        ProcessingError,
        SubscriptionNotFound,
        SubscriptionExpired,
        ActivationPending,
        TrialExpired,
        OperationSizeExceeded,
        OperationsExceeded,
        InputFileTypeNotSupported,
        OutputFileTypeNotSupported,
        OperationNotSupported,
        Accepted,
        AccessDenied,
        InvalidExtension
    }

    public class OcrTextInputDataInput
    {
        [JsonProperty("use_async_pattern", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool UseAsyncPattern { get; set; } = false;

        [JsonProperty("source_file_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceFileName { get; set; }

        [JsonProperty("source_file_content", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent SourceFileContent { get; set; }

        [JsonProperty("sharepoint_file")]
        public SharepointFile SharepointFile { get; set; }

        [JsonProperty("language", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputLanguageType? Language { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputDataInputLanguageType.English;

        [JsonProperty("x")]
        public string XCoordinate { get; set; }

        [JsonProperty("y")]
        public string YCoordinate { get; set; }

        [JsonProperty("width")]
        public string Width { get; set; }

        [JsonProperty("height")]
        public string Height { get; set; }

        [JsonProperty("page_number", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PageNumber { get; set; } = "";

        [JsonProperty("performance", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputPerformanceType? Performance { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputDataInputPerformanceType.SlowButAccurate;

        [JsonProperty("characters_option", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputBlacklistWhitelistType? BlacklistWhitelist { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputDataInputBlacklistWhitelistType.None;

        [JsonProperty("characters")]
        public string Characters { get; set; }

        [JsonProperty("paginate", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? UsePagination { get; set; } = false;

        [JsonProperty("fail_on_error", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? FailOnError { get; set; } = true;
    }

    public class PdfWatermarkInputDataInput
    {
        [JsonProperty("source_file_name")]
        public string SourceFileName { get; set; }

        [JsonProperty("use_async_pattern", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool UseAsyncPattern { get; set; } = false;

        [JsonProperty("source_file_content", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent SourceFileContent { get; set; }

        [JsonProperty("pdf_file", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent PDFWatermark { get; set; }

        [JsonProperty("sharepoint_file")]
        public SharepointFile SharepointFile { get; set; }

        [JsonProperty("position", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputPositionType Position { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputDataInputPositionType.MiddleCenter;

        [JsonProperty("width", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Width { get; set; }

        [JsonProperty("height", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Height { get; set; }

        [JsonProperty("x")]
        public string XCoordinate { get; set; }

        [JsonProperty("y")]
        public string YCoordinate { get; set; }

        [JsonProperty("layer", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputLayerType? Layer { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputDataInputLayerType.Foreground;

        [JsonProperty("rotation")]
        public string Rotation { get; set; }

        [JsonProperty("opacity", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Opacity { get; set; } = "100";

        [JsonProperty("start_page")]
        public int? WatermarkStartPage { get; set; }

        [JsonProperty("end_page")]
        public int? WatermarkEndPage { get; set; }

        [JsonProperty("page_interval")]
        public int? WatermarkPageInterval { get; set; }

        [JsonProperty("page_orientation", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputWatermarkPageOrientationType? WatermarkPageOrientation { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputDataInputWatermarkPageOrientationType.Both;

        [JsonProperty("print_only", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputPrintOnlyType? PrintOnly { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputDataInputPrintOnlyType.False;

        [JsonProperty("start_section")]
        public int? WatermarkStartSection { get; set; }

        [JsonProperty("end_section")]
        public int? WatermarkEndSection { get; set; }

        [JsonProperty("page_type")]
        public string WatermarkPageType { get; set; }

        [JsonProperty("fail_on_error", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? FailOnError { get; set; } = true;
    }

    public class QrCodeWatermarkInputDataInput
    {
        [JsonProperty("source_file_name")]
        public string SourceFileName { get; set; }

        [JsonProperty("use_async_pattern", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool UseAsyncPattern { get; set; } = false;

        [JsonProperty("source_file_content", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent SourceFileContent { get; set; }

        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Content { get; set; }

        [JsonProperty("sharepoint_file")]
        public SharepointFile SharepointFile { get; set; }

        [JsonProperty("version", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputVersionType Version { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputDataInputVersionType.Auto;

        [JsonProperty("input_mode", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputInputModeType InputMode { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputDataInputInputModeType.Binary;

        [JsonProperty("error_correction_level", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputErrorCorrectionLevelType ErrorCorrectionLevel { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputDataInputErrorCorrectionLevelType.Low;

        [JsonProperty("position", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputPositionType Position { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputDataInputPositionType.MiddleCenter;

        [JsonProperty("width", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Width { get; set; }

        [JsonProperty("height", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Height { get; set; }

        [JsonProperty("x")]
        public string XCoordinate { get; set; }

        [JsonProperty("y")]
        public string YCoordinate { get; set; }

        [JsonProperty("layer", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputLayerType? Layer { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputDataInputLayerType.Foreground;

        [JsonProperty("rotation")]
        public string Rotation { get; set; }

        [JsonProperty("opacity", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Opacity { get; set; } = "100";

        [JsonProperty("fill_color")]
        public string WatermarkBackgroundColor { get; set; }

        [JsonProperty("line_color")]
        public string WatermarkForegroundColor { get; set; }

        [JsonProperty("start_page")]
        public int? WatermarkStartPage { get; set; }

        [JsonProperty("end_page")]
        public int? WatermarkEndPage { get; set; }

        [JsonProperty("page_interval")]
        public int? WatermarkPageInterval { get; set; }

        [JsonProperty("page_orientation", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputWatermarkPageOrientationType? WatermarkPageOrientation { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputDataInputWatermarkPageOrientationType.Both;

        [JsonProperty("print_only", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputPrintOnlyType? PrintOnly { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputDataInputPrintOnlyType.False;

        [JsonProperty("start_section")]
        public int? WatermarkStartSection { get; set; }

        [JsonProperty("end_section")]
        public int? WatermarkEndSection { get; set; }

        [JsonProperty("page_type")]
        public string WatermarkPageType { get; set; }

        [JsonProperty("fail_on_error", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? FailOnError { get; set; } = true;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputDataInputVersionType
    {
        Auto,
        [EnumMember(Value = "Version 1")]
        Version1,
        [EnumMember(Value = "Version 2")]
        Version2,
        [EnumMember(Value = "Version 3")]
        Version3,
        [EnumMember(Value = "Version 4")]
        Version4,
        [EnumMember(Value = "Version 5")]
        Version5,
        [EnumMember(Value = "Version 6")]
        Version6,
        [EnumMember(Value = "Version 7")]
        Version7,
        [EnumMember(Value = "Version 8")]
        Version8,
        [EnumMember(Value = "Version 9")]
        Version9,
        [EnumMember(Value = "Version 10")]
        Version10,
        [EnumMember(Value = "Version 11")]
        Version11,
        [EnumMember(Value = "Version 12")]
        Version12,
        [EnumMember(Value = "Version 13")]
        Version13,
        [EnumMember(Value = "Version 14")]
        Version14,
        [EnumMember(Value = "Version 15")]
        Version15,
        [EnumMember(Value = "Version 16")]
        Version16,
        [EnumMember(Value = "Version 17")]
        Version17,
        [EnumMember(Value = "Version 18")]
        Version18,
        [EnumMember(Value = "Version 19")]
        Version19,
        [EnumMember(Value = "Version 20")]
        Version20,
        [EnumMember(Value = "Version 21")]
        Version21,
        [EnumMember(Value = "Version 22")]
        Version22,
        [EnumMember(Value = "Version 23")]
        Version23,
        [EnumMember(Value = "Version 24")]
        Version24,
        [EnumMember(Value = "Version 25")]
        Version25,
        [EnumMember(Value = "Version 26")]
        Version26,
        [EnumMember(Value = "Version 27")]
        Version27,
        [EnumMember(Value = "Version 28")]
        Version28,
        [EnumMember(Value = "Version 29")]
        Version29,
        [EnumMember(Value = "Version 30")]
        Version30,
        [EnumMember(Value = "Version 31")]
        Version31,
        [EnumMember(Value = "Version 32")]
        Version32,
        [EnumMember(Value = "Version 33")]
        Version33,
        [EnumMember(Value = "Version 34")]
        Version34,
        [EnumMember(Value = "Version 35")]
        Version35,
        [EnumMember(Value = "Version 36")]
        Version36,
        [EnumMember(Value = "Version 37")]
        Version37,
        [EnumMember(Value = "Version 38")]
        Version38,
        [EnumMember(Value = "Version 39")]
        Version39,
        [EnumMember(Value = "Version 40")]
        Version40
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputDataInputInputModeType
    {
        Binary,
        Alphanumeric,
        Numeric
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputDataInputErrorCorrectionLevelType
    {
        Low,
        Medium,
        High,
        Quartile
    }

    public class RectangleWatermarkInputDataInput
    {
        [JsonProperty("source_file_name")]
        public string SourceFileName { get; set; }

        [JsonProperty("use_async_pattern", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool UseAsyncPattern { get; set; } = false;

        [JsonProperty("source_file_content", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent SourceFileContent { get; set; }

        [JsonProperty("position", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputPositionType Position { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputDataInputPositionType.MiddleCenter;

        [JsonProperty("sharepoint_file")]
        public SharepointFile SharepointFile { get; set; }

        [JsonProperty("width", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Width { get; set; }

        [JsonProperty("height", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Height { get; set; }

        [JsonProperty("x")]
        public string XCoordinate { get; set; }

        [JsonProperty("y")]
        public string YCoordinate { get; set; }

        [JsonProperty("layer", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputLayerType? Layer { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputDataInputLayerType.Foreground;

        [JsonProperty("rotation")]
        public string Rotation { get; set; }

        [JsonProperty("opacity", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Opacity { get; set; } = "100";

        [JsonProperty("fill_color")]
        public string WatermarkBackgroundColor { get; set; }

        [JsonProperty("line_color")]
        public string WatermarkOutlineColor { get; set; }

        [JsonProperty("line_width")]
        public string WatermarkOutlineWidth { get; set; }

        [JsonProperty("start_page")]
        public int? WatermarkStartPage { get; set; }

        [JsonProperty("end_page")]
        public int? WatermarkEndPage { get; set; }

        [JsonProperty("page_interval")]
        public int? WatermarkPageInterval { get; set; }

        [JsonProperty("page_orientation", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputWatermarkPageOrientationType? WatermarkPageOrientation { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputDataInputWatermarkPageOrientationType.Both;

        [JsonProperty("print_only", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputPrintOnlyType? PrintOnly { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputDataInputPrintOnlyType.False;

        [JsonProperty("start_section")]
        public int? WatermarkStartSection { get; set; }

        [JsonProperty("end_section")]
        public int? WatermarkEndSection { get; set; }

        [JsonProperty("page_type")]
        public string WatermarkPageType { get; set; }

        [JsonProperty("fail_on_error", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? FailOnError { get; set; } = true;
    }

    public class RedactInputPdfDataInput
    {
        [JsonProperty("use_async_pattern", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool UseAsyncPattern { get; set; } = false;

        [JsonProperty("source_file_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceFileName { get; set; }

        [JsonProperty("source_file_content", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent SourceFileContent { get; set; }

        [JsonProperty("sharepoint_file")]
        public SharepointFile SharepointFile { get; set; }

        [JsonProperty("redaction_type", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputPdfDataInputRedactionTypeType RedactionType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputPdfDataInputRedactionTypeType.Text;

        [JsonProperty("redact_text", DefaultValueHandling = DefaultValueHandling.Include)]
        public string RedactPattern { get; set; }

        [JsonProperty("include_annotations", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IncludeAnnotations { get; set; } = true;

        [JsonProperty("case_sensitive", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CaseSensitive { get; set; } = false;

        [JsonProperty("page_range", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PageRange { get; set; } = "*";

        [JsonProperty("open_password")]
        public string OpenPassword { get; set; }

        [JsonProperty("fail_on_error", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? FailOnError { get; set; } = true;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputPdfDataInputRedactionTypeType
    {
        Text,
        Regex
    }

    public class RedactSmartInputPdfDataInput
    {
        [JsonProperty("use_async_pattern", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool UseAsyncPattern { get; set; } = false;

        [JsonProperty("source_file_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceFileName { get; set; }

        [JsonProperty("sharepoint_file")]
        public SharepointFile SharepointFile { get; set; }

        [JsonProperty("source_file_content", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent SourceFileContent { get; set; }

        [JsonProperty("redact_credit_card_number", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool RedactCreditCardNumber { get; set; } = false;

        [JsonProperty("redact_date", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool RedactDate { get; set; } = false;

        [JsonProperty("redact_email_address", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool RedactEmailAddress { get; set; } = false;

        [JsonProperty("redact_international_phone_number", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool RedactInternationalPhoneNumber { get; set; } = false;

        [JsonProperty("redact_ipv4", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool RedactIPv4Address { get; set; } = false;

        [JsonProperty("redact_ipv6", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool RedactIPv6Address { get; set; } = false;

        [JsonProperty("redact_mac_address", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool RedactMACAddress { get; set; } = false;

        [JsonProperty("redact_north_american_phone_number", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool RedactNorthAmericanPhoneNumber { get; set; } = false;

        [JsonProperty("redact_social_security_number", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool RedactSocialSecurityNumber { get; set; } = false;

        [JsonProperty("redact_time", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool RedactTime { get; set; } = false;

        [JsonProperty("redact_url", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool RedactURL { get; set; } = false;

        [JsonProperty("redact_us_zip_code", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool RedactUSZipCode { get; set; } = false;

        [JsonProperty("redact_vin", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool RedactVIN { get; set; } = false;

        [JsonProperty("include_annotations", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IncludeAnnotations { get; set; } = true;

        [JsonProperty("page_range", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PageRange { get; set; } = "*";

        [JsonProperty("open_password")]
        public string OpenPassword { get; set; }

        [JsonProperty("fail_on_error", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? FailOnError { get; set; } = true;
    }

    public class RtfWatermarkInputDataInput
    {
        [JsonProperty("source_file_name")]
        public string SourceFileName { get; set; }

        [JsonProperty("use_async_pattern", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool UseAsyncPattern { get; set; } = false;

        [JsonProperty("source_file_content", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent SourceFileContent { get; set; }

        [JsonProperty("rtf_data", DefaultValueHandling = DefaultValueHandling.Include)]
        public string WatermarkContent { get; set; }

        [JsonProperty("sharepoint_file")]
        public SharepointFile SharepointFile { get; set; }

        [JsonProperty("position", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputPositionType Position { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputDataInputPositionType.MiddleCenter;

        [JsonProperty("width", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Width { get; set; }

        [JsonProperty("height", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Height { get; set; }

        [JsonProperty("x")]
        public string XCoordinate { get; set; }

        [JsonProperty("y")]
        public string YCoordinate { get; set; }

        [JsonProperty("layer", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputLayerType? Layer { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputDataInputLayerType.Foreground;

        [JsonProperty("rotation")]
        public string Rotation { get; set; }

        [JsonProperty("opacity", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Opacity { get; set; } = "100";

        [JsonProperty("fill_color")]
        public string WatermarkBackgroundColor { get; set; }

        [JsonProperty("line_color")]
        public string WatermarkOutlineColor { get; set; }

        [JsonProperty("line_width")]
        public string WatermarkOutlineWidth { get; set; }

        [JsonProperty("start_page")]
        public int? WatermarkStartPage { get; set; }

        [JsonProperty("end_page")]
        public int? WatermarkEndPage { get; set; }

        [JsonProperty("page_interval")]
        public int? WatermarkPageInterval { get; set; }

        [JsonProperty("page_orientation", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputWatermarkPageOrientationType? WatermarkPageOrientation { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputDataInputWatermarkPageOrientationType.Both;

        [JsonProperty("print_only", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputPrintOnlyType? PrintOnly { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputDataInputPrintOnlyType.False;

        [JsonProperty("start_section")]
        public int? WatermarkStartSection { get; set; }

        [JsonProperty("end_section")]
        public int? WatermarkEndSection { get; set; }

        [JsonProperty("page_type")]
        public string WatermarkPageType { get; set; }

        [JsonProperty("fail_on_error", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? FailOnError { get; set; } = true;
    }

    public class SecurePdfInputDataInput
    {
        [JsonProperty("use_async_pattern", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool UseAsyncPattern { get; set; } = false;

        [JsonProperty("source_file_name")]
        public string SourceFileName { get; set; }

        [JsonProperty("source_file_content", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent SourceFileContent { get; set; }

        [JsonProperty("sharepoint_file")]
        public SharepointFile SharepointFile { get; set; }

        [JsonProperty("open_password")]
        public string OpenPassword { get; set; }

        [JsonProperty("owner_password")]
        public string OwnerPassword { get; set; }

        [JsonProperty("security_options")]
        public string PDFRestrictions { get; set; }

        [JsonProperty("fail_on_error", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? FailOnError { get; set; } = true;
    }

    public class SplitOperationResponse
    {
        [JsonProperty("processed_files")]
        public ProcessedFiles[] ProcessedFiles { get; set; }

        [JsonProperty("result_code")]
        public SplitOperationResponseResultCodeType ResultCode { get; set; }

        [JsonProperty("result_details")]
        public string ResultDetails { get; set; }
    }

    public class ProcessedFiles
    {
        [JsonProperty("processed_file_name")]
        public string ProcessedFileName { get; set; }

        [JsonProperty("processed_file_content")]
        public string ProcessedFileContent { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SplitOperationResponseResultCodeType
    {
        Success,
        ProcessingError,
        SubscriptionNotFound,
        SubscriptionExpired,
        ActivationPending,
        TrialExpired,
        OperationSizeExceeded,
        OperationsExceeded,
        InputFileTypeNotSupported,
        OutputFileTypeNotSupported,
        OperationNotSupported,
        Accepted,
        AccessDenied,
        InvalidExtension
    }

    public class SplitPdfInputDataInput
    {
        [JsonProperty("use_async_pattern", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool UseAsyncPattern { get; set; } = false;

        [JsonProperty("source_file_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceFileName { get; set; }

        [JsonProperty("source_file_content", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent SourceFileContent { get; set; }

        [JsonProperty("sharepoint_file")]
        public SharepointFile SharepointFile { get; set; }

        [JsonProperty("file_name_template")]
        public string FileNameTemplate { get; set; }

        [JsonProperty("file_split_by", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputSplitByType SplitBy { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputDataInputSplitByType.NumberOfPages;

        [JsonProperty("split_parameter", DefaultValueHandling = DefaultValueHandling.Include)]
        public int SplitParameter { get; set; } = 1;

        [JsonProperty("fail_on_error", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? FailOnError { get; set; } = true;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputDataInputSplitByType
    {
        [EnumMember(Value = "Number of Pages")]
        NumberOfPages,
        [EnumMember(Value = "Bookmark Level")]
        BookmarkLevel
    }

    public class TextWatermarkInputDataInput
    {
        [JsonProperty("source_file_name")]
        public string SourceFileName { get; set; }

        [JsonProperty("use_async_pattern", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool UseAsyncPattern { get; set; } = false;

        [JsonProperty("source_file_content", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent SourceFileContent { get; set; }

        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public string WatermarkContent { get; set; }

        [JsonProperty("sharepoint_file")]
        public SharepointFile SharepointFile { get; set; }

        [JsonProperty("font_family_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FontFamilyName { get; set; }

        [JsonProperty("font_size", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FontSize { get; set; } = "12";

        [JsonProperty("fill_color", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FontColor { get; set; } = "#000000";

        [JsonProperty("alignment", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputTextAlignmentType TextAlignment { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputDataInputTextAlignmentType.TopLeft;

        [JsonProperty("word_wrap", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputWordWrapType WordWrap { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputDataInputWordWrapType.Word;

        [JsonProperty("position", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputPositionType Position { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputDataInputPositionType.MiddleCenter;

        [JsonProperty("width", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Width { get; set; }

        [JsonProperty("height", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Height { get; set; }

        [JsonProperty("x")]
        public string XCoordinate { get; set; }

        [JsonProperty("y")]
        public string YCoordinate { get; set; }

        [JsonProperty("layer", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputLayerType? Layer { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputDataInputLayerType.Foreground;

        [JsonProperty("rotation")]
        public string Rotation { get; set; }

        [JsonProperty("opacity", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Opacity { get; set; } = "100";

        [JsonProperty("font_style")]
        public string FontStyle { get; set; }

        [JsonProperty("line_color")]
        public string FontOutlineColor { get; set; }

        [JsonProperty("line_width")]
        public string FontOutlineWidth { get; set; }

        [JsonProperty("start_page")]
        public int? WatermarkStartPage { get; set; }

        [JsonProperty("end_page")]
        public int? WatermarkEndPage { get; set; }

        [JsonProperty("page_interval")]
        public int? WatermarkPageInterval { get; set; }

        [JsonProperty("page_orientation", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputWatermarkPageOrientationType? WatermarkPageOrientation { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputDataInputWatermarkPageOrientationType.Both;

        [JsonProperty("print_only", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputPrintOnlyType? PrintOnly { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi.InputDataInputPrintOnlyType.False;

        [JsonProperty("start_section")]
        public int? WatermarkStartSection { get; set; }

        [JsonProperty("end_section")]
        public int? WatermarkEndSection { get; set; }

        [JsonProperty("page_type")]
        public string WatermarkPageType { get; set; }

        [JsonProperty("fail_on_error", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? FailOnError { get; set; } = true;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputDataInputTextAlignmentType
    {
        [EnumMember(Value = "Top Left")]
        TopLeft,
        [EnumMember(Value = "Top Center")]
        TopCenter,
        [EnumMember(Value = "Top Right")]
        TopRight,
        [EnumMember(Value = "Top Justfiy")]
        TopJustfiy,
        [EnumMember(Value = "Middle Left")]
        MiddleLeft,
        [EnumMember(Value = "Middle Center")]
        MiddleCenter,
        [EnumMember(Value = "Middle Right")]
        MiddleRight,
        [EnumMember(Value = "Middle Justfiy")]
        MiddleJustfiy,
        [EnumMember(Value = "Bottom Left")]
        BottomLeft,
        [EnumMember(Value = "Bottom Center")]
        BottomCenter,
        [EnumMember(Value = "Bottom Right")]
        BottomRight,
        [EnumMember(Value = "Bottom Justfiy")]
        BottomJustfiy
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InputDataInputWordWrapType
    {
        WordOnly,
        Character,
        None,
        Word
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbi;

    public partial class WorkflowManagedActions
    {
        public MuhimbiActions Muhimbi(string connectionId) => new MuhimbiActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MuhimbiTriggers Muhimbi(string connectionId) => new MuhimbiTriggers(connectionId);
    }
}