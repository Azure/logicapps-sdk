//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbipdf
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MuhimbipdfActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> CompositeWatermark(Expression<Func<CompositeWatermarkInput>> inputData)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> CompressPdf(Expression<Func<CompressPdfInput>> inputPdfData)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> Convert(Expression<Func<ConvertInput>> inputData)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> ConvertCad(Expression<Func<ConvertCadInput>> inputCadData)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> ConvertEmail(Expression<Func<ConvertEmailInput>> inputEmailData)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> ConvertExcel(Expression<Func<ConvertExcelInput>> inputExcelData)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> ConvertHtml(Expression<Func<ConvertHtmlInput>> inputData)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> ConvertInfopath(Expression<Func<ConvertInfopathInput>> inputInfopathData)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> ConvertPdfa(Expression<Func<ConvertPdfaInput>> inputPdfData)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> ConvertPowerpoint(Expression<Func<ConvertPowerpointInput>> inputPowerpointData)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> ConvertVisio(Expression<Func<ConvertVisioInput>> inputVisioData)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> ConvertWord(Expression<Func<ConvertWordInput>> inputWordData)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponseCommon, ApiConnectionActionConfiguration> CopyMetadata(Expression<Func<CopyMetadataInput>> inputData)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> EllipseWatermark(Expression<Func<EllipseWatermarkInput>> inputData)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> ExportFormData(Expression<Func<ExportFormDataInput>> inputFromPdfData)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> ExtractText(Expression<Func<ExtractTextInput>> inputPdfData)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> ImageWatermark(Expression<Func<ImageWatermarkInput>> inputData)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> ImportFormData(Expression<Func<ImportFormDataInput>> inputXmlData)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> ExtractKeyValuePairs(Expression<Func<ExtractKeyValuePairsInput>> inputPdfData)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> LineWatermark(Expression<Func<LineWatermarkInput>> inputData)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> LinearBarcodeWatermark(Expression<Func<LinearBarcodeWatermarkInput>> inputData)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> MergeToPdf(Expression<Func<MergeToPdfInput>> inputData)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> OcrPdf(Expression<Func<OcrPdfInput>> inputData)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OcrOperationResponse, ApiConnectionActionConfiguration> OcrText(Expression<Func<OcrTextInput>> inputData)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> PdfWatermark(Expression<Func<PdfWatermarkInput>> inputData)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> QrCodeWatermark(Expression<Func<QrCodeWatermarkInput>> inputData)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> RectangleWatermark(Expression<Func<RectangleWatermarkInput>> inputData)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> RtfWatermark(Expression<Func<RtfWatermarkInput>> inputData)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> SecurePdf(Expression<Func<SecurePdfInput>> inputData)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<SplitOperationResponse, ApiConnectionActionConfiguration> SplitPdf(Expression<Func<SplitPdfInput>> inputData)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "muhimbipdf")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> TextWatermark(Expression<Func<TextWatermarkInput>> inputData)
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

    public class MuhimbipdfTriggers([ConnectionName] string connectionId)
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

    public class CompositeWatermarkInput
    {
        [JsonProperty("source_file_name")]
        public string SourceFileName { get; set; }

        [JsonProperty("use_async_pattern", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool UseAsyncPattern { get; set; } = false;

        [JsonProperty("source_file_content", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceFileContent { get; set; }

        [JsonProperty("sharepoint_file")]
        public SharepointFile SharepointFile { get; set; }

        [JsonProperty("watermark_data", DefaultValueHandling = DefaultValueHandling.Include)]
        public string WatermarkData { get; set; }

        [JsonProperty("fail_on_error", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? FailOnError { get; set; } = true;
    }

    public class SharepointFile
    {
        [JsonProperty("site_url")]
        public string SiteUrl { get; set; }

        [JsonProperty("source_file_url")]
        public string SourceFilePath { get; set; }

        [JsonProperty("destination_file_url")]
        public string DestinationFilePath { get; set; }

        [JsonProperty("username")]
        public string UserName { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }
    }

    public class CompressPdfInput
    {
        [JsonProperty("use_async_pattern", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool UseAsyncPattern { get; set; } = false;

        [JsonProperty("source_file_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceFileName { get; set; }

        [JsonProperty("sharepoint_file")]
        public SharepointFile SharepointFile { get; set; }

        [JsonProperty("source_file_content", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceFileContent { get; set; }

        [JsonProperty("remove_annotations", DefaultValueHandling = DefaultValueHandling.Include)]
        public CompressPdfInputRemoveAnnotationsType? RemoveAnnotations { get; set; } = CompressPdfInputRemoveAnnotationsType.Default;

        [JsonProperty("remove_blank_pages", DefaultValueHandling = DefaultValueHandling.Include)]
        public CompressPdfInputRemoveBlankPagesType? RemoveBlankPages { get; set; } = CompressPdfInputRemoveBlankPagesType.Default;

        [JsonProperty("remove_bookmarks", DefaultValueHandling = DefaultValueHandling.Include)]
        public CompressPdfInputRemoveBookmarksType? RemoveBookmarks { get; set; } = CompressPdfInputRemoveBookmarksType.Default;

        [JsonProperty("remove_embedded_files", DefaultValueHandling = DefaultValueHandling.Include)]
        public CompressPdfInputRemoveEmbeddedFilesType? RemoveEmbeddedFiles { get; set; } = CompressPdfInputRemoveEmbeddedFilesType.Default;

        [JsonProperty("remove_form_fields", DefaultValueHandling = DefaultValueHandling.Include)]
        public CompressPdfInputRemoveFormFieldsType? RemoveFormFields { get; set; } = CompressPdfInputRemoveFormFieldsType.Default;

        [JsonProperty("remove_hyperlinks", DefaultValueHandling = DefaultValueHandling.Include)]
        public CompressPdfInputRemoveHyperlinksType? RemoveHyperlinks { get; set; } = CompressPdfInputRemoveHyperlinksType.Default;

        [JsonProperty("remove_javascript", DefaultValueHandling = DefaultValueHandling.Include)]
        public CompressPdfInputRemoveJavaScriptType? RemoveJavaScript { get; set; } = CompressPdfInputRemoveJavaScriptType.Default;

        [JsonProperty("remove_metadata", DefaultValueHandling = DefaultValueHandling.Include)]
        public CompressPdfInputRemoveMetadataType? RemoveMetadata { get; set; } = CompressPdfInputRemoveMetadataType.Default;

        [JsonProperty("remove_page_thumbnails", DefaultValueHandling = DefaultValueHandling.Include)]
        public CompressPdfInputRemovePageThumbnailsType? RemovePageThumbnails { get; set; } = CompressPdfInputRemovePageThumbnailsType.Default;

        [JsonProperty("pack_fonts", DefaultValueHandling = DefaultValueHandling.Include)]
        public CompressPdfInputPackFontsType? PackFonts { get; set; } = CompressPdfInputPackFontsType.Default;

        [JsonProperty("pack_document", DefaultValueHandling = DefaultValueHandling.Include)]
        public CompressPdfInputPackDocumentType? PackDocument { get; set; } = CompressPdfInputPackDocumentType.Default;

        [JsonProperty("recompress_images", DefaultValueHandling = DefaultValueHandling.Include)]
        public CompressPdfInputRecompressImagesType? RecompressImages { get; set; } = CompressPdfInputRecompressImagesType.Default;

        [JsonProperty("enable_mrc", DefaultValueHandling = DefaultValueHandling.Include)]
        public CompressPdfInputEnableMRCType? EnableMRC { get; set; } = CompressPdfInputEnableMRCType.Default;

        [JsonProperty("downscale_resolution_mrc", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? DownscaleResolutionMRC { get; set; } = 100;

        [JsonProperty("preserve_smoothing", DefaultValueHandling = DefaultValueHandling.Include)]
        public CompressPdfInputPreserveSmoothingType? PreserveSmoothing { get; set; } = CompressPdfInputPreserveSmoothingType.Default;

        [JsonProperty("image_quality", DefaultValueHandling = DefaultValueHandling.Include)]
        public CompressPdfInputImageQualityType? ImageQuality { get; set; } = CompressPdfInputImageQualityType.Default;

        [JsonProperty("downscale_images", DefaultValueHandling = DefaultValueHandling.Include)]
        public CompressPdfInputDownscaleImagesType? DownscaleImages { get; set; } = CompressPdfInputDownscaleImagesType.Default;

        [JsonProperty("downscale_resolution", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? DownscaleResolution { get; set; } = 200;

        [JsonProperty("enable_color_detection", DefaultValueHandling = DefaultValueHandling.Include)]
        public CompressPdfInputEnableColorDetectionType? EnableColorDetection { get; set; } = CompressPdfInputEnableColorDetectionType.Default;

        [JsonProperty("enable_char_repair", DefaultValueHandling = DefaultValueHandling.Include)]
        public CompressPdfInputEnableCharRepairType? EnableCharRepair { get; set; } = CompressPdfInputEnableCharRepairType.Default;

        [JsonProperty("enable_jpeg2000", DefaultValueHandling = DefaultValueHandling.Include)]
        public CompressPdfInputEnableJPEG2000Type? EnableJPEG2000 { get; set; } = CompressPdfInputEnableJPEG2000Type.Default;

        [JsonProperty("enable_jbig2", DefaultValueHandling = DefaultValueHandling.Include)]
        public CompressPdfInputEnableJBIG2Type? EnableJBIG2 { get; set; } = CompressPdfInputEnableJBIG2Type.Default;

        [JsonProperty("jbig2_pms_threshold", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? JBIG2PMSThreshold { get; set; } = 85;

        [JsonProperty("override_settings")]
        public string OverrideSettings { get; set; }

        [JsonProperty("fail_on_error", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? FailOnError { get; set; } = true;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CompressPdfInputRemoveAnnotationsType
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CompressPdfInputRemoveBlankPagesType
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CompressPdfInputRemoveBookmarksType
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CompressPdfInputRemoveEmbeddedFilesType
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CompressPdfInputRemoveFormFieldsType
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CompressPdfInputRemoveHyperlinksType
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CompressPdfInputRemoveJavaScriptType
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CompressPdfInputRemoveMetadataType
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CompressPdfInputRemovePageThumbnailsType
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CompressPdfInputPackFontsType
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CompressPdfInputPackDocumentType
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CompressPdfInputRecompressImagesType
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CompressPdfInputEnableMRCType
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CompressPdfInputPreserveSmoothingType
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CompressPdfInputImageQualityType
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
    public enum CompressPdfInputDownscaleImagesType
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CompressPdfInputEnableColorDetectionType
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CompressPdfInputEnableCharRepairType
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CompressPdfInputEnableJPEG2000Type
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CompressPdfInputEnableJBIG2Type
    {
        Default,
        Yes,
        No
    }

    public class ConvertInput
    {
        [JsonProperty("use_async_pattern", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool UseAsyncPattern { get; set; } = false;

        [JsonProperty("source_file_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceFileName { get; set; }

        [JsonProperty("source_file_content", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceFileContent { get; set; }

        [JsonProperty("sharepoint_file")]
        public SharepointFile SharepointFile { get; set; }

        [JsonProperty("output_format", DefaultValueHandling = DefaultValueHandling.Include)]
        public ConvertInputOutputFormatType OutputFormat { get; set; } = ConvertInputOutputFormatType.PDF;

        [JsonProperty("copy_metadata", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool CopyMetadata { get; set; } = false;

        [JsonProperty("override_settings")]
        public string OverrideSettings { get; set; }

        [JsonProperty("template_file_content")]
        public string TemplateFileContent { get; set; }

        [JsonProperty("fail_on_error", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? FailOnError { get; set; } = true;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ConvertInputOutputFormatType
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

    public class ConvertCadInput
    {
        [JsonProperty("use_async_pattern", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool UseAsyncPattern { get; set; } = false;

        [JsonProperty("source_file_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceFileName { get; set; }

        [JsonProperty("sharepoint_file")]
        public SharepointFile SharepointFile { get; set; }

        [JsonProperty("source_file_content", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceFileContent { get; set; }

        [JsonProperty("copy_metadata", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool CopyMetadata { get; set; } = false;

        [JsonProperty("paper_size", DefaultValueHandling = DefaultValueHandling.Include)]
        public ConvertCadInputPaperSizeType? PaperSize { get; set; } = ConvertCadInputPaperSizeType.Letter;

        [JsonProperty("paper_size_custom")]
        public string PaperSizeCustom { get; set; }

        [JsonProperty("page_margins", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PageMargins { get; set; } = "0.25";

        [JsonProperty("background_color", DefaultValueHandling = DefaultValueHandling.Include)]
        public string BackgroundColor { get; set; } = "White";

        [JsonProperty("foreground_color", DefaultValueHandling = DefaultValueHandling.Include)]
        public ConvertCadInputForegroundColorType? ForegroundColor { get; set; } = ConvertCadInputForegroundColorType.GreyscaleDarken;

        [JsonProperty("foreground_color_custom")]
        public string ForegroundColorCustom { get; set; }

        [JsonProperty("empty_layout_detection_mode", DefaultValueHandling = DefaultValueHandling.Include)]
        public ConvertCadInputEmptyLayoutDetectionType? EmptyLayoutDetection { get; set; } = ConvertCadInputEmptyLayoutDetectionType.SkipEmptyLayouts;

        [JsonProperty("layout_sort_order", DefaultValueHandling = DefaultValueHandling.Include)]
        public ConvertCadInputLayoutSortOrderType? LayoutSortOrder { get; set; } = ConvertCadInputLayoutSortOrderType.Ascending;

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
    public enum ConvertCadInputPaperSizeType
    {
        A3,
        A4,
        A5,
        Legal,
        Letter,
        Custom
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ConvertCadInputForegroundColorType
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
    public enum ConvertCadInputEmptyLayoutDetectionType
    {
        Default,
        SkipNone,
        SkipEmptyLayouts,
        SkipLayoutsWithoutViewports
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ConvertCadInputLayoutSortOrderType
    {
        Default,
        Ascending,
        Descending,
        TabOrder
    }

    public class ConvertEmailInput
    {
        [JsonProperty("use_async_pattern", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool UseAsyncPattern { get; set; } = false;

        [JsonProperty("source_file_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceFileName { get; set; }

        [JsonProperty("sharepoint_file")]
        public SharepointFile SharepointFile { get; set; }

        [JsonProperty("source_file_content", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceFileContent { get; set; }

        [JsonProperty("copy_metadata", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool CopyMetadata { get; set; } = false;

        [JsonProperty("convert_attachments", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IncludeAttachments { get; set; } = true;

        [JsonProperty("attachment_merge_mode")]
        public ConvertEmailInputAttachmentActionType? AttachmentAction { get; set; }

        [JsonProperty("display_attachment_summary", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AttachmentSummary { get; set; } = true;

        [JsonProperty("unsupported_attachment_behaviour", DefaultValueHandling = DefaultValueHandling.Include)]
        public ConvertEmailInputUnsupportedAttachmentActionType? UnsupportedAttachmentAction { get; set; } = ConvertEmailInputUnsupportedAttachmentActionType.Error;

        [JsonProperty("include_attachment_types")]
        public string IncludeAttachmentFilter { get; set; }

        [JsonProperty("exclude_attachment_types")]
        public string ExcludeAttachmentFilter { get; set; }

        [JsonProperty("viewport_Size", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ViewportSize { get; set; } = "Paper";

        [JsonProperty("paper_size", DefaultValueHandling = DefaultValueHandling.Include)]
        public ConvertEmailInputPaperSizeType? PaperSize { get; set; } = ConvertEmailInputPaperSizeType.Letter;

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
        public ConvertEmailInputConversionQualityType? ConversionQuality { get; set; }

        [JsonProperty("override_settings")]
        public string OverrideSettings { get; set; }

        [JsonProperty("fail_on_error", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? FailOnError { get; set; } = true;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ConvertEmailInputAttachmentActionType
    {
        Default,
        Merge,
        AttachAsPDF,
        AttachOriginal
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ConvertEmailInputUnsupportedAttachmentActionType
    {
        Error,
        Remove,
        AttachOriginal
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ConvertEmailInputPaperSizeType
    {
        A3,
        A4,
        A5,
        Legal,
        Letter,
        Custom
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ConvertEmailInputConversionQualityType
    {
        OptimizeForPrint,
        OptimizeForOnScreen,
        Original
    }

    public class ConvertExcelInput
    {
        [JsonProperty("use_async_pattern", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool UseAsyncPattern { get; set; } = false;

        [JsonProperty("source_file_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceFileName { get; set; }

        [JsonProperty("sharepoint_file")]
        public SharepointFile SharepointFile { get; set; }

        [JsonProperty("source_file_content", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceFileContent { get; set; }

        [JsonProperty("output_format", DefaultValueHandling = DefaultValueHandling.Include)]
        public ConvertExcelInputOutputFormatType OutputFormat { get; set; } = ConvertExcelInputOutputFormatType.PDF;

        [JsonProperty("copy_metadata", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool CopyMetadata { get; set; } = false;

        [JsonProperty("range")]
        public ConvertExcelInputRangeType? Range { get; set; }

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
        public ConvertExcelInputQualityType? Quality { get; set; }

        [JsonProperty("override_settings")]
        public string OverrideSettings { get; set; }

        [JsonProperty("fail_on_error", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? FailOnError { get; set; } = true;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ConvertExcelInputOutputFormatType
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
    public enum ConvertExcelInputRangeType
    {
        VisibleDocuments,
        AllDocuments,
        ActiveDocuments
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ConvertExcelInputQualityType
    {
        OptimizeForPrint,
        OptimizeForOnScreen,
        Original
    }

    public class ConvertHtmlInput
    {
        [JsonProperty("use_async_pattern", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool UseAsyncPattern { get; set; } = false;

        [JsonProperty("source_url_or_html", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceURLOrHTML { get; set; }

        [JsonProperty("page_orientation", DefaultValueHandling = DefaultValueHandling.Include)]
        public ConvertHtmlInputPageOrientationType? PageOrientation { get; set; } = ConvertHtmlInputPageOrientationType.Portrait;

        [JsonProperty("media_type", DefaultValueHandling = DefaultValueHandling.Include)]
        public ConvertHtmlInputMediaTypeType? MediaType { get; set; } = ConvertHtmlInputMediaTypeType.Screen;

        [JsonProperty("authentication_type", DefaultValueHandling = DefaultValueHandling.Include)]
        public ConvertHtmlInputAuthenticationTypeType? AuthenticationType { get; set; } = ConvertHtmlInputAuthenticationTypeType.Anonymous;

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
    public enum ConvertHtmlInputPageOrientationType
    {
        Portrait,
        Landscape
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ConvertHtmlInputMediaTypeType
    {
        Screen,
        Print
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ConvertHtmlInputAuthenticationTypeType
    {
        Anonymous,
        [EnumMember(Value = "SharePoint Online")]
        SharePointOnline,
        Web
    }

    public class ConvertInfopathInput
    {
        [JsonProperty("use_async_pattern", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool UseAsyncPattern { get; set; } = false;

        [JsonProperty("source_file_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceFileName { get; set; }

        [JsonProperty("sharepoint_file")]
        public SharepointFile SharepointFile { get; set; }

        [JsonProperty("source_file_content", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceFileContent { get; set; }

        [JsonProperty("output_format", DefaultValueHandling = DefaultValueHandling.Include)]
        public ConvertInfopathInputOutputFormatType OutputFormat { get; set; } = ConvertInfopathInputOutputFormatType.PDF;

        [JsonProperty("copy_metadata", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool CopyMetadata { get; set; } = false;

        [JsonProperty("template_file_content")]
        public string TemplateFileContent { get; set; }

        [JsonProperty("views_to_convert")]
        public string ViewNames { get; set; }

        [JsonProperty("convert_attachments", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IncludeAttachment { get; set; } = true;

        [JsonProperty("attachment_merge_mode")]
        public ConvertInfopathInputAttachmentActionType? AttachmentAction { get; set; }

        [JsonProperty("unsupported_attachment_behaviour")]
        public ConvertInfopathInputUnsupportedAttachmentActionType? UnsupportedAttachmentAction { get; set; }

        [JsonProperty("break_merge_on_error")]
        public bool? BreakMergeOnError { get; set; }

        [JsonProperty("include_attachment_types")]
        public string IncludeAttachmentFilter { get; set; }

        [JsonProperty("exclude_attachment_types")]
        public string ExcludeAttachmentFilter { get; set; }

        [JsonProperty("default_paper_size")]
        public ConvertInfopathInputDefaultPaperSizeType? DefaultPaperSize { get; set; }

        [JsonProperty("default_paper_size_custom")]
        public string DefaultPaperSizeCustom { get; set; }

        [JsonProperty("force_paper_size")]
        public ConvertInfopathInputForcePaperSizeType? ForcePaperSize { get; set; }

        [JsonProperty("force_paper_size_custom")]
        public string ForcePaperSizeCustom { get; set; }

        [JsonProperty("default_page_orientation", DefaultValueHandling = DefaultValueHandling.Include)]
        public ConvertInfopathInputDefaultPageOrientationType? DefaultPageOrientation { get; set; } = ConvertInfopathInputDefaultPageOrientationType.Default;

        [JsonProperty("force_page_orientation")]
        public ConvertInfopathInputForcePageOrientationType? ForcePageOrientation { get; set; }

        [JsonProperty("start_page")]
        public int? StartPage { get; set; }

        [JsonProperty("end_page")]
        public int? EndPage { get; set; }

        [JsonProperty("quality")]
        public ConvertInfopathInputConversionQualityType? ConversionQuality { get; set; }

        [JsonProperty("override_settings")]
        public string OverrideSettings { get; set; }

        [JsonProperty("fail_on_error", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? FailOnError { get; set; } = true;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ConvertInfopathInputOutputFormatType
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
    public enum ConvertInfopathInputAttachmentActionType
    {
        Default,
        Merge,
        AttachAsPDF,
        AttachOriginal
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ConvertInfopathInputUnsupportedAttachmentActionType
    {
        Error,
        Remove,
        AttachOriginal
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ConvertInfopathInputDefaultPaperSizeType
    {
        A3,
        A4,
        A5,
        Legal,
        Letter,
        Custom
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ConvertInfopathInputForcePaperSizeType
    {
        A3,
        A4,
        A5,
        Legal,
        Letter,
        Custom
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ConvertInfopathInputDefaultPageOrientationType
    {
        Default,
        Portrait,
        Landscape,
        Both
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ConvertInfopathInputForcePageOrientationType
    {
        Default,
        Portrait,
        Landscape,
        Both
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ConvertInfopathInputConversionQualityType
    {
        OptimizeForPrint,
        OptimizeForOnScreen,
        Original
    }

    public class ConvertPdfaInput
    {
        [JsonProperty("use_async_pattern", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool UseAsyncPattern { get; set; } = false;

        [JsonProperty("source_file_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceFileName { get; set; }

        [JsonProperty("sharepoint_file")]
        public SharepointFile SharepointFile { get; set; }

        [JsonProperty("source_file_content", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceFileContent { get; set; }

        [JsonProperty("copy_metadata", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool CopyMetadata { get; set; } = false;

        [JsonProperty("pdf_profile", DefaultValueHandling = DefaultValueHandling.Include)]
        public ConvertPdfaInputPDFProfileType PDFProfile { get; set; } = ConvertPdfaInputPDFProfileType.PDFA2B;

        [JsonProperty("override_settings")]
        public string OverrideSettings { get; set; }

        [JsonProperty("fail_on_error", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? FailOnError { get; set; } = true;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ConvertPdfaInputPDFProfileType
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

    public class ConvertPowerpointInput
    {
        [JsonProperty("use_async_pattern", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool UseAsyncPattern { get; set; } = false;

        [JsonProperty("source_file_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceFileName { get; set; }

        [JsonProperty("sharepoint_file")]
        public SharepointFile SharepointFile { get; set; }

        [JsonProperty("source_file_content", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceFileContent { get; set; }

        [JsonProperty("output_format", DefaultValueHandling = DefaultValueHandling.Include)]
        public ConvertPowerpointInputOutputFormatType OutputFormat { get; set; } = ConvertPowerpointInputOutputFormatType.PDF;

        [JsonProperty("copy_metadata", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool CopyMetadata { get; set; } = false;

        [JsonProperty("range")]
        public ConvertPowerpointInputRangeType? Range { get; set; }

        [JsonProperty("print_output_type", DefaultValueHandling = DefaultValueHandling.Include)]
        public ConvertPowerpointInputPrintLayoutHandoutsType? PrintLayoutHandouts { get; set; } = ConvertPowerpointInputPrintLayoutHandoutsType.Slides;

        [JsonProperty("frame_slides", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? FrameSlides { get; set; } = true;

        [JsonProperty("start_page")]
        public int? StartPage { get; set; }

        [JsonProperty("end_page")]
        public int? EndPage { get; set; }

        [JsonProperty("quality")]
        public ConvertPowerpointInputQualityType? Quality { get; set; }

        [JsonProperty("override_settings")]
        public string OverrideSettings { get; set; }

        [JsonProperty("fail_on_error", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? FailOnError { get; set; } = true;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ConvertPowerpointInputOutputFormatType
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
    public enum ConvertPowerpointInputRangeType
    {
        VisibleDocuments,
        AllDocuments,
        ActiveDocuments
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ConvertPowerpointInputPrintLayoutHandoutsType
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
    public enum ConvertPowerpointInputQualityType
    {
        OptimizeForPrint,
        OptimizeForOnScreen,
        Original
    }

    public class ConvertVisioInput
    {
        [JsonProperty("use_async_pattern", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool UseAsyncPattern { get; set; } = false;

        [JsonProperty("source_file_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceFileName { get; set; }

        [JsonProperty("sharepoint_file")]
        public SharepointFile SharepointFile { get; set; }

        [JsonProperty("source_file_content", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceFileContent { get; set; }

        [JsonProperty("output_format", DefaultValueHandling = DefaultValueHandling.Include)]
        public ConvertVisioInputOutputFormatType OutputFormat { get; set; } = ConvertVisioInputOutputFormatType.PDF;

        [JsonProperty("copy_metadata", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool CopyMetadata { get; set; } = false;

        [JsonProperty("range")]
        public ConvertVisioInputRangeType? Range { get; set; }

        [JsonProperty("start_page")]
        public int? StartPage { get; set; }

        [JsonProperty("end_page")]
        public int? EndPage { get; set; }

        [JsonProperty("quality")]
        public ConvertVisioInputQualityType? Quality { get; set; }

        [JsonProperty("override_settings")]
        public string OverrideSettings { get; set; }

        [JsonProperty("fail_on_error", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? FailOnError { get; set; } = true;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ConvertVisioInputOutputFormatType
    {
        PDF,
        XPS
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ConvertVisioInputRangeType
    {
        AllDocuments,
        ActiveDocuments
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ConvertVisioInputQualityType
    {
        OptimizeForPrint,
        OptimizeForOnScreen,
        Original
    }

    public class ConvertWordInput
    {
        [JsonProperty("use_async_pattern", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool UseAsyncPattern { get; set; } = false;

        [JsonProperty("source_file_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceFileName { get; set; }

        [JsonProperty("sharepoint_file")]
        public SharepointFile SharepointFile { get; set; }

        [JsonProperty("source_file_content", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceFileContent { get; set; }

        [JsonProperty("output_format", DefaultValueHandling = DefaultValueHandling.Include)]
        public ConvertWordInputOutputFormatType OutputFormat { get; set; } = ConvertWordInputOutputFormatType.PDF;

        [JsonProperty("copy_metadata", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool CopyMetadata { get; set; } = false;

        [JsonProperty("revisions_and_comments_display_mode", DefaultValueHandling = DefaultValueHandling.Include)]
        public ConvertWordInputDisplayForReviewType? DisplayForReview { get; set; } = ConvertWordInputDisplayForReviewType.Final;

        [JsonProperty("revisions_and_comments_markup_mode", DefaultValueHandling = DefaultValueHandling.Include)]
        public ConvertWordInputReviewMarkupModeType? ReviewMarkupMode { get; set; } = ConvertWordInputReviewMarkupModeType.InLine;

        [JsonProperty("generate_bookmarks")]
        public ConvertWordInputGenerateBookmarksType? GenerateBookmarks { get; set; }

        [JsonProperty("start_page")]
        public int? StartPage { get; set; }

        [JsonProperty("end_page")]
        public int? EndPage { get; set; }

        [JsonProperty("quality")]
        public ConvertWordInputQualityType? Quality { get; set; }

        [JsonProperty("override_settings")]
        public string OverrideSettings { get; set; }

        [JsonProperty("fail_on_error", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? FailOnError { get; set; } = true;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ConvertWordInputOutputFormatType
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
    public enum ConvertWordInputDisplayForReviewType
    {
        Final,
        Original,
        FinalShowingMarkup,
        OriginalShowingMarkup
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ConvertWordInputReviewMarkupModeType
    {
        Balloon,
        InLine,
        Mixed
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ConvertWordInputGenerateBookmarksType
    {
        Disabled,
        Automatic,
        Custom
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ConvertWordInputQualityType
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

    public class CopyMetadataInput
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

    public class EllipseWatermarkInput
    {
        [JsonProperty("source_file_name")]
        public string SourceFileName { get; set; }

        [JsonProperty("use_async_pattern", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool UseAsyncPattern { get; set; } = false;

        [JsonProperty("source_file_content", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceFileContent { get; set; }

        [JsonProperty("position", DefaultValueHandling = DefaultValueHandling.Include)]
        public EllipseWatermarkInputPositionType Position { get; set; } = EllipseWatermarkInputPositionType.MiddleCenter;

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
        public EllipseWatermarkInputLayerType? Layer { get; set; } = EllipseWatermarkInputLayerType.Foreground;

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
        public EllipseWatermarkInputWatermarkPageOrientationType? WatermarkPageOrientation { get; set; } = EllipseWatermarkInputWatermarkPageOrientationType.Both;

        [JsonProperty("print_only", DefaultValueHandling = DefaultValueHandling.Include)]
        public EllipseWatermarkInputPrintOnlyType? PrintOnly { get; set; } = EllipseWatermarkInputPrintOnlyType.False;

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
    public enum EllipseWatermarkInputPositionType
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
    public enum EllipseWatermarkInputLayerType
    {
        Background,
        Foreground
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EllipseWatermarkInputWatermarkPageOrientationType
    {
        Portrait,
        Landscape,
        Both
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EllipseWatermarkInputPrintOnlyType
    {
        [EnumMember(Value = "false")]
        False,
        [EnumMember(Value = "true")]
        True
    }

    public class ExportFormDataInput
    {
        [JsonProperty("use_async_pattern", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool UseAsyncPattern { get; set; } = false;

        [JsonProperty("source_file_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceFileName { get; set; }

        [JsonProperty("sharepoint_file")]
        public SharepointFile SharepointFile { get; set; }

        [JsonProperty("source_file_content", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceFileContent { get; set; }

        [JsonProperty("output_format", DefaultValueHandling = DefaultValueHandling.Include)]
        public ExportFormDataInputOutputDataFormatType OutputDataFormat { get; set; } = ExportFormDataInputOutputDataFormatType.XML;

        [JsonProperty("copy_metadata", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool CopyMetadata { get; set; } = false;

        [JsonProperty("fail_on_error", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? FailOnError { get; set; } = true;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ExportFormDataInputOutputDataFormatType
    {
        XML,
        FDF,
        XFDF
    }

    public class ExtractTextInput
    {
        [JsonProperty("use_async_pattern", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool UseAsyncPattern { get; set; } = false;

        [JsonProperty("source_file_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceFileName { get; set; }

        [JsonProperty("sharepoint_file")]
        public SharepointFile SharepointFile { get; set; }

        [JsonProperty("source_file_content", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceFileContent { get; set; }

        [JsonProperty("page_range", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PageRange { get; set; } = "*";

        [JsonProperty("fail_on_error", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? FailOnError { get; set; } = true;
    }

    public class ImageWatermarkInput
    {
        [JsonProperty("source_file_name")]
        public string SourceFileName { get; set; }

        [JsonProperty("use_async_pattern", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool UseAsyncPattern { get; set; } = false;

        [JsonProperty("source_file_content", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceFileContent { get; set; }

        [JsonProperty("image_file", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Image { get; set; }

        [JsonProperty("sharepoint_file")]
        public SharepointFile SharepointFile { get; set; }

        [JsonProperty("position", DefaultValueHandling = DefaultValueHandling.Include)]
        public ImageWatermarkInputPositionType Position { get; set; } = ImageWatermarkInputPositionType.MiddleCenter;

        [JsonProperty("width", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Width { get; set; }

        [JsonProperty("height", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Height { get; set; }

        [JsonProperty("x")]
        public string XCoordinate { get; set; }

        [JsonProperty("y")]
        public string YCoordinate { get; set; }

        [JsonProperty("layer", DefaultValueHandling = DefaultValueHandling.Include)]
        public ImageWatermarkInputLayerType? Layer { get; set; } = ImageWatermarkInputLayerType.Foreground;

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
        public ImageWatermarkInputWatermarkPageOrientationType? WatermarkPageOrientation { get; set; } = ImageWatermarkInputWatermarkPageOrientationType.Both;

        [JsonProperty("print_only", DefaultValueHandling = DefaultValueHandling.Include)]
        public ImageWatermarkInputPrintOnlyType? PrintOnly { get; set; } = ImageWatermarkInputPrintOnlyType.False;

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
    public enum ImageWatermarkInputPositionType
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
    public enum ImageWatermarkInputLayerType
    {
        Background,
        Foreground
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ImageWatermarkInputWatermarkPageOrientationType
    {
        Portrait,
        Landscape,
        Both
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ImageWatermarkInputPrintOnlyType
    {
        [EnumMember(Value = "false")]
        False,
        [EnumMember(Value = "true")]
        True
    }

    public class ImportFormDataInput
    {
        [JsonProperty("use_async_pattern", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool UseAsyncPattern { get; set; } = false;

        [JsonProperty("source_file_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceFileName { get; set; }

        [JsonProperty("sharepoint_file")]
        public SharepointFile SharepointFile { get; set; }

        [JsonProperty("source_file_content", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceFileContent { get; set; }

        [JsonProperty("copy_metadata", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool CopyMetadata { get; set; } = false;

        [JsonProperty("pdf_template_file_content")]
        public string PDFFormFileContent { get; set; }

        [JsonProperty("pdf_template_url")]
        public string PDFFormURL { get; set; }

        [JsonProperty("pdf_template_username")]
        public string Username { get; set; }

        [JsonProperty("pdf_template_domain")]
        public string Domain { get; set; }

        [JsonProperty("pdf_template_password")]
        public string Password { get; set; }

        [JsonProperty("flatten", DefaultValueHandling = DefaultValueHandling.Include)]
        public ImportFormDataInputFlattenType? Flatten { get; set; } = ImportFormDataInputFlattenType.Default;

        [JsonProperty("read_only", DefaultValueHandling = DefaultValueHandling.Include)]
        public ImportFormDataInputReadOnlyType? ReadOnly { get; set; } = ImportFormDataInputReadOnlyType.Default;

        [JsonProperty("override_settings")]
        public string OverrideSettings { get; set; }

        [JsonProperty("fail_on_error", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? FailOnError { get; set; } = true;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ImportFormDataInputFlattenType
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ImportFormDataInputReadOnlyType
    {
        Default,
        Yes,
        No
    }

    public class ExtractKeyValuePairsInput
    {
        [JsonProperty("use_async_pattern", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool UseAsyncPattern { get; set; } = false;

        [JsonProperty("source_file_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceFileName { get; set; }

        [JsonProperty("sharepoint_file")]
        public SharepointFile SharepointFile { get; set; }

        [JsonProperty("source_file_content", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceFileContent { get; set; }

        [JsonProperty("ocr_language", DefaultValueHandling = DefaultValueHandling.Include)]
        public string OCRLanguage { get; set; } = "eng";

        [JsonProperty("dpi", DefaultValueHandling = DefaultValueHandling.Include)]
        public ExtractKeyValuePairsInputDPIType? DPI { get; set; } = ExtractKeyValuePairsInputDPIType._300;

        [JsonProperty("kvp_format", DefaultValueHandling = DefaultValueHandling.Include)]
        public ExtractKeyValuePairsInputKVPOutputFormatType? KVPOutputFormat { get; set; } = ExtractKeyValuePairsInputKVPOutputFormatType.Json;

        [JsonProperty("page_range", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PageRange { get; set; } = "*";

        [JsonProperty("autorotate", DefaultValueHandling = DefaultValueHandling.Include)]
        public ExtractKeyValuePairsInputAutorotateType? Autorotate { get; set; } = ExtractKeyValuePairsInputAutorotateType.Default;

        [JsonProperty("trim_symbols", DefaultValueHandling = DefaultValueHandling.Include)]
        public ExtractKeyValuePairsInputTrimSymbolsType? TrimSymbols { get; set; } = ExtractKeyValuePairsInputTrimSymbolsType.Default;

        [JsonProperty("include_key_bounding_box", DefaultValueHandling = DefaultValueHandling.Include)]
        public ExtractKeyValuePairsInputIncludeKeyBoundingBoxType? IncludeKeyBoundingBox { get; set; } = ExtractKeyValuePairsInputIncludeKeyBoundingBoxType.Default;

        [JsonProperty("include_value_bounding_box", DefaultValueHandling = DefaultValueHandling.Include)]
        public ExtractKeyValuePairsInputIncludeValueBoundingBoxType? IncludeValueBoundingBox { get; set; } = ExtractKeyValuePairsInputIncludeValueBoundingBoxType.Default;

        [JsonProperty("include_page_number", DefaultValueHandling = DefaultValueHandling.Include)]
        public ExtractKeyValuePairsInputIncludePageNumberType? IncludePageNumber { get; set; } = ExtractKeyValuePairsInputIncludePageNumberType.Default;

        [JsonProperty("include_confidence", DefaultValueHandling = DefaultValueHandling.Include)]
        public ExtractKeyValuePairsInputIncludeConfidenceType? IncludeConfidence { get; set; } = ExtractKeyValuePairsInputIncludeConfidenceType.Default;

        [JsonProperty("confidence_threshold", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? ConfidenceThreshold { get; set; } = 50;

        [JsonProperty("include_type", DefaultValueHandling = DefaultValueHandling.Include)]
        public ExtractKeyValuePairsInputIncludeTypeType? IncludeType { get; set; } = ExtractKeyValuePairsInputIncludeTypeType.Default;

        [JsonProperty("expected_keys")]
        public string ExpectedKeys { get; set; }

        [JsonProperty("fail_on_error", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? FailOnError { get; set; } = true;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ExtractKeyValuePairsInputDPIType
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
    public enum ExtractKeyValuePairsInputKVPOutputFormatType
    {
        [EnumMember(Value = "json")]
        Json,
        [EnumMember(Value = "csv")]
        Csv,
        [EnumMember(Value = "xml")]
        Xml
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ExtractKeyValuePairsInputAutorotateType
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ExtractKeyValuePairsInputTrimSymbolsType
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ExtractKeyValuePairsInputIncludeKeyBoundingBoxType
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ExtractKeyValuePairsInputIncludeValueBoundingBoxType
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ExtractKeyValuePairsInputIncludePageNumberType
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ExtractKeyValuePairsInputIncludeConfidenceType
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ExtractKeyValuePairsInputIncludeTypeType
    {
        Default,
        Yes,
        No
    }

    public class LineWatermarkInput
    {
        [JsonProperty("source_file_name")]
        public string SourceFileName { get; set; }

        [JsonProperty("use_async_pattern", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool UseAsyncPattern { get; set; } = false;

        [JsonProperty("source_file_content", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceFileContent { get; set; }

        [JsonProperty("position", DefaultValueHandling = DefaultValueHandling.Include)]
        public LineWatermarkInputPositionType Position { get; set; } = LineWatermarkInputPositionType.MiddleCenter;

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
        public LineWatermarkInputLayerType? Layer { get; set; } = LineWatermarkInputLayerType.Foreground;

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
        public LineWatermarkInputWatermarkPageOrientationType? WatermarkPageOrientation { get; set; } = LineWatermarkInputWatermarkPageOrientationType.Both;

        [JsonProperty("print_only", DefaultValueHandling = DefaultValueHandling.Include)]
        public LineWatermarkInputPrintOnlyType? PrintOnly { get; set; } = LineWatermarkInputPrintOnlyType.False;

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
    public enum LineWatermarkInputPositionType
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
    public enum LineWatermarkInputLayerType
    {
        Background,
        Foreground
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum LineWatermarkInputWatermarkPageOrientationType
    {
        Portrait,
        Landscape,
        Both
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum LineWatermarkInputPrintOnlyType
    {
        [EnumMember(Value = "false")]
        False,
        [EnumMember(Value = "true")]
        True
    }

    public class LinearBarcodeWatermarkInput
    {
        [JsonProperty("source_file_name")]
        public string SourceFileName { get; set; }

        [JsonProperty("use_async_pattern", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool UseAsyncPattern { get; set; } = false;

        [JsonProperty("source_file_content", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceFileContent { get; set; }

        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public string BarcodeContent { get; set; }

        [JsonProperty("sharepoint_file")]
        public SharepointFile SharepointFile { get; set; }

        [JsonProperty("barcode_type", DefaultValueHandling = DefaultValueHandling.Include)]
        public LinearBarcodeWatermarkInputBarcodeTypeType BarcodeType { get; set; } = LinearBarcodeWatermarkInputBarcodeTypeType.Codabar;

        [JsonProperty("omit_start_stop_symbols", DefaultValueHandling = DefaultValueHandling.Include)]
        public LinearBarcodeWatermarkInputOmitEncodingOfStartStopSymbolsType? OmitEncodingOfStartStopSymbols { get; set; } = LinearBarcodeWatermarkInputOmitEncodingOfStartStopSymbolsType.False;

        [JsonProperty("disable_checkdigit", DefaultValueHandling = DefaultValueHandling.Include)]
        public LinearBarcodeWatermarkInputDisableCheckDigitType DisableCheckDigit { get; set; } = LinearBarcodeWatermarkInputDisableCheckDigitType.False;

        [JsonProperty("show_checkdigit", DefaultValueHandling = DefaultValueHandling.Include)]
        public LinearBarcodeWatermarkInputShowCheckDigitType ShowCheckDigit { get; set; } = LinearBarcodeWatermarkInputShowCheckDigitType.False;

        [JsonProperty("margin")]
        public string Margin { get; set; }

        [JsonProperty("font_family_name")]
        public string FontFamily { get; set; }

        [JsonProperty("font_size")]
        public string FontSize { get; set; }

        [JsonProperty("font_style")]
        public string FontStyle { get; set; }

        [JsonProperty("label_placement", DefaultValueHandling = DefaultValueHandling.Include)]
        public LinearBarcodeWatermarkInputLabelPlacementType? LabelPlacement { get; set; } = LinearBarcodeWatermarkInputLabelPlacementType.BottomCenter;

        [JsonProperty("position", DefaultValueHandling = DefaultValueHandling.Include)]
        public LinearBarcodeWatermarkInputPositionType Position { get; set; } = LinearBarcodeWatermarkInputPositionType.MiddleCenter;

        [JsonProperty("width", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Width { get; set; }

        [JsonProperty("height", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Height { get; set; }

        [JsonProperty("x")]
        public string XCoordinate { get; set; }

        [JsonProperty("y")]
        public string YCoordinate { get; set; }

        [JsonProperty("layer", DefaultValueHandling = DefaultValueHandling.Include)]
        public LinearBarcodeWatermarkInputLayerType? Layer { get; set; } = LinearBarcodeWatermarkInputLayerType.Foreground;

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
        public LinearBarcodeWatermarkInputWatermarkPageOrientationType? WatermarkPageOrientation { get; set; } = LinearBarcodeWatermarkInputWatermarkPageOrientationType.Both;

        [JsonProperty("print_only", DefaultValueHandling = DefaultValueHandling.Include)]
        public LinearBarcodeWatermarkInputPrintOnlyType? PrintOnly { get; set; } = LinearBarcodeWatermarkInputPrintOnlyType.False;

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
    public enum LinearBarcodeWatermarkInputBarcodeTypeType
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
    public enum LinearBarcodeWatermarkInputOmitEncodingOfStartStopSymbolsType
    {
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum LinearBarcodeWatermarkInputDisableCheckDigitType
    {
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum LinearBarcodeWatermarkInputShowCheckDigitType
    {
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum LinearBarcodeWatermarkInputLabelPlacementType
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum LinearBarcodeWatermarkInputPositionType
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
    public enum LinearBarcodeWatermarkInputLayerType
    {
        Background,
        Foreground
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum LinearBarcodeWatermarkInputWatermarkPageOrientationType
    {
        Portrait,
        Landscape,
        Both
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum LinearBarcodeWatermarkInputPrintOnlyType
    {
        [EnumMember(Value = "false")]
        False,
        [EnumMember(Value = "true")]
        True
    }

    public class MergeToPdfInput
    {
        [JsonProperty("use_async_pattern", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool UseAsyncPattern { get; set; } = false;

        [JsonProperty("source_file_name_1")]
        public string SourceFileName1 { get; set; }

        [JsonProperty("source_file_content_1")]
        public string SourceFileContent1 { get; set; }

        [JsonProperty("source_file_name_2")]
        public string SourceFileName2 { get; set; }

        [JsonProperty("source_file_content_2")]
        public string SourceFileContent2 { get; set; }

        [JsonProperty("source_file_name_3")]
        public string SourceFileName3 { get; set; }

        [JsonProperty("source_file_content_3")]
        public string SourceFileContent3 { get; set; }

        [JsonProperty("source_file_name_4")]
        public string SourceFileName4 { get; set; }

        [JsonProperty("source_file_content_4")]
        public string SourceFileContent4 { get; set; }

        [JsonProperty("source_file_name_5")]
        public string SourceFileName5 { get; set; }

        [JsonProperty("source_file_content_5")]
        public string SourceFileContent5 { get; set; }

        [JsonProperty("sharepoint_file")]
        public SharepointFile SharepointFile { get; set; }

        [JsonProperty("document_start_page", DefaultValueHandling = DefaultValueHandling.Include)]
        public MergeToPdfInputEachDocumentType? EachDocument { get; set; } = MergeToPdfInputEachDocumentType.StartsOnTheNextPage;

        [JsonProperty("source_files")]
        public MergeSourceFile[] SourceFiles { get; set; }

        [JsonProperty("override_settings")]
        public string OverrideSettings { get; set; }

        [JsonProperty("fail_on_error", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? FailOnError { get; set; } = true;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MergeToPdfInputEachDocumentType
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
        [JsonProperty("source_file_name")]
        public string Name { get; set; }

        [JsonProperty("source_file_content")]
        public string Content { get; set; }
    }

    public class OcrPdfInput
    {
        [JsonProperty("use_async_pattern", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool UseAsyncPattern { get; set; } = false;

        [JsonProperty("source_file_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceFileName { get; set; }

        [JsonProperty("source_file_content", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceFileContent { get; set; }

        [JsonProperty("sharepoint_file")]
        public SharepointFile SharepointFile { get; set; }

        [JsonProperty("copy_metadata", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool MetaData { get; set; } = false;

        [JsonProperty("language", DefaultValueHandling = DefaultValueHandling.Include)]
        public OcrPdfInputLanguageType? Language { get; set; } = OcrPdfInputLanguageType.English;

        [JsonProperty("performance", DefaultValueHandling = DefaultValueHandling.Include)]
        public OcrPdfInputPerformanceType? Performance { get; set; } = OcrPdfInputPerformanceType.SlowButAccurate;

        [JsonProperty("characters_option", DefaultValueHandling = DefaultValueHandling.Include)]
        public OcrPdfInputBlacklistWhitelistType? BlacklistWhitelist { get; set; } = OcrPdfInputBlacklistWhitelistType.None;

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
    public enum OcrPdfInputLanguageType
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
    public enum OcrPdfInputPerformanceType
    {
        [EnumMember(Value = "Slow but accurate")]
        SlowButAccurate,
        [EnumMember(Value = "Faster and less accurate")]
        FasterAndLessAccurate,
        [EnumMember(Value = "Fastest and least accurate")]
        FastestAndLeastAccurate
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OcrPdfInputBlacklistWhitelistType
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

    public class OcrTextInput
    {
        [JsonProperty("use_async_pattern", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool UseAsyncPattern { get; set; } = false;

        [JsonProperty("source_file_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceFileName { get; set; }

        [JsonProperty("source_file_content", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceFileContent { get; set; }

        [JsonProperty("sharepoint_file")]
        public SharepointFile SharepointFile { get; set; }

        [JsonProperty("language", DefaultValueHandling = DefaultValueHandling.Include)]
        public OcrTextInputLanguageType? Language { get; set; } = OcrTextInputLanguageType.English;

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
        public OcrTextInputPerformanceType? Performance { get; set; } = OcrTextInputPerformanceType.SlowButAccurate;

        [JsonProperty("characters_option", DefaultValueHandling = DefaultValueHandling.Include)]
        public OcrTextInputBlacklistWhitelistType? BlacklistWhitelist { get; set; } = OcrTextInputBlacklistWhitelistType.None;

        [JsonProperty("characters")]
        public string Characters { get; set; }

        [JsonProperty("paginate", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? UsePagination { get; set; } = false;

        [JsonProperty("fail_on_error", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? FailOnError { get; set; } = true;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OcrTextInputLanguageType
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
    public enum OcrTextInputPerformanceType
    {
        [EnumMember(Value = "Slow but accurate")]
        SlowButAccurate,
        [EnumMember(Value = "Faster and less accurate")]
        FasterAndLessAccurate,
        [EnumMember(Value = "Fastest and least accurate")]
        FastestAndLeastAccurate
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OcrTextInputBlacklistWhitelistType
    {
        None,
        Whitelist,
        Blacklist
    }

    public class PdfWatermarkInput
    {
        [JsonProperty("source_file_name")]
        public string SourceFileName { get; set; }

        [JsonProperty("use_async_pattern", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool UseAsyncPattern { get; set; } = false;

        [JsonProperty("source_file_content", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceFileContent { get; set; }

        [JsonProperty("pdf_file", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PDFWatermark { get; set; }

        [JsonProperty("sharepoint_file")]
        public SharepointFile SharepointFile { get; set; }

        [JsonProperty("position", DefaultValueHandling = DefaultValueHandling.Include)]
        public PdfWatermarkInputPositionType Position { get; set; } = PdfWatermarkInputPositionType.MiddleCenter;

        [JsonProperty("width", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Width { get; set; }

        [JsonProperty("height", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Height { get; set; }

        [JsonProperty("x")]
        public string XCoordinate { get; set; }

        [JsonProperty("y")]
        public string YCoordinate { get; set; }

        [JsonProperty("layer", DefaultValueHandling = DefaultValueHandling.Include)]
        public PdfWatermarkInputLayerType? Layer { get; set; } = PdfWatermarkInputLayerType.Foreground;

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
        public PdfWatermarkInputWatermarkPageOrientationType? WatermarkPageOrientation { get; set; } = PdfWatermarkInputWatermarkPageOrientationType.Both;

        [JsonProperty("print_only", DefaultValueHandling = DefaultValueHandling.Include)]
        public PdfWatermarkInputPrintOnlyType? PrintOnly { get; set; } = PdfWatermarkInputPrintOnlyType.False;

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
    public enum PdfWatermarkInputPositionType
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
    public enum PdfWatermarkInputLayerType
    {
        Background,
        Foreground
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PdfWatermarkInputWatermarkPageOrientationType
    {
        Portrait,
        Landscape,
        Both
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PdfWatermarkInputPrintOnlyType
    {
        [EnumMember(Value = "false")]
        False,
        [EnumMember(Value = "true")]
        True
    }

    public class QrCodeWatermarkInput
    {
        [JsonProperty("source_file_name")]
        public string SourceFileName { get; set; }

        [JsonProperty("use_async_pattern", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool UseAsyncPattern { get; set; } = false;

        [JsonProperty("source_file_content", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceFileContent { get; set; }

        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Content { get; set; }

        [JsonProperty("sharepoint_file")]
        public SharepointFile SharepointFile { get; set; }

        [JsonProperty("version", DefaultValueHandling = DefaultValueHandling.Include)]
        public QrCodeWatermarkInputVersionType Version { get; set; } = QrCodeWatermarkInputVersionType.Auto;

        [JsonProperty("input_mode", DefaultValueHandling = DefaultValueHandling.Include)]
        public QrCodeWatermarkInputInputModeType InputMode { get; set; } = QrCodeWatermarkInputInputModeType.Binary;

        [JsonProperty("error_correction_level", DefaultValueHandling = DefaultValueHandling.Include)]
        public QrCodeWatermarkInputErrorCorrectionLevelType ErrorCorrectionLevel { get; set; } = QrCodeWatermarkInputErrorCorrectionLevelType.Low;

        [JsonProperty("position", DefaultValueHandling = DefaultValueHandling.Include)]
        public QrCodeWatermarkInputPositionType Position { get; set; } = QrCodeWatermarkInputPositionType.MiddleCenter;

        [JsonProperty("width", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Width { get; set; }

        [JsonProperty("height", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Height { get; set; }

        [JsonProperty("x")]
        public string XCoordinate { get; set; }

        [JsonProperty("y")]
        public string YCoordinate { get; set; }

        [JsonProperty("layer", DefaultValueHandling = DefaultValueHandling.Include)]
        public QrCodeWatermarkInputLayerType? Layer { get; set; } = QrCodeWatermarkInputLayerType.Foreground;

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
        public QrCodeWatermarkInputWatermarkPageOrientationType? WatermarkPageOrientation { get; set; } = QrCodeWatermarkInputWatermarkPageOrientationType.Both;

        [JsonProperty("print_only", DefaultValueHandling = DefaultValueHandling.Include)]
        public QrCodeWatermarkInputPrintOnlyType? PrintOnly { get; set; } = QrCodeWatermarkInputPrintOnlyType.False;

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
    public enum QrCodeWatermarkInputVersionType
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
    public enum QrCodeWatermarkInputInputModeType
    {
        Binary,
        Alphanumeric,
        Numeric
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum QrCodeWatermarkInputErrorCorrectionLevelType
    {
        Low,
        Medium,
        High,
        Quartile
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum QrCodeWatermarkInputPositionType
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
    public enum QrCodeWatermarkInputLayerType
    {
        Background,
        Foreground
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum QrCodeWatermarkInputWatermarkPageOrientationType
    {
        Portrait,
        Landscape,
        Both
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum QrCodeWatermarkInputPrintOnlyType
    {
        [EnumMember(Value = "false")]
        False,
        [EnumMember(Value = "true")]
        True
    }

    public class RectangleWatermarkInput
    {
        [JsonProperty("source_file_name")]
        public string SourceFileName { get; set; }

        [JsonProperty("use_async_pattern", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool UseAsyncPattern { get; set; } = false;

        [JsonProperty("source_file_content", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceFileContent { get; set; }

        [JsonProperty("position", DefaultValueHandling = DefaultValueHandling.Include)]
        public RectangleWatermarkInputPositionType Position { get; set; } = RectangleWatermarkInputPositionType.MiddleCenter;

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
        public RectangleWatermarkInputLayerType? Layer { get; set; } = RectangleWatermarkInputLayerType.Foreground;

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
        public RectangleWatermarkInputWatermarkPageOrientationType? WatermarkPageOrientation { get; set; } = RectangleWatermarkInputWatermarkPageOrientationType.Both;

        [JsonProperty("print_only", DefaultValueHandling = DefaultValueHandling.Include)]
        public RectangleWatermarkInputPrintOnlyType? PrintOnly { get; set; } = RectangleWatermarkInputPrintOnlyType.False;

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
    public enum RectangleWatermarkInputPositionType
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
    public enum RectangleWatermarkInputLayerType
    {
        Background,
        Foreground
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum RectangleWatermarkInputWatermarkPageOrientationType
    {
        Portrait,
        Landscape,
        Both
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum RectangleWatermarkInputPrintOnlyType
    {
        [EnumMember(Value = "false")]
        False,
        [EnumMember(Value = "true")]
        True
    }

    public class RtfWatermarkInput
    {
        [JsonProperty("source_file_name")]
        public string SourceFileName { get; set; }

        [JsonProperty("use_async_pattern", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool UseAsyncPattern { get; set; } = false;

        [JsonProperty("source_file_content", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceFileContent { get; set; }

        [JsonProperty("rtf_data", DefaultValueHandling = DefaultValueHandling.Include)]
        public string WatermarkContent { get; set; }

        [JsonProperty("sharepoint_file")]
        public SharepointFile SharepointFile { get; set; }

        [JsonProperty("position", DefaultValueHandling = DefaultValueHandling.Include)]
        public RtfWatermarkInputPositionType Position { get; set; } = RtfWatermarkInputPositionType.MiddleCenter;

        [JsonProperty("width", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Width { get; set; }

        [JsonProperty("height", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Height { get; set; }

        [JsonProperty("x")]
        public string XCoordinate { get; set; }

        [JsonProperty("y")]
        public string YCoordinate { get; set; }

        [JsonProperty("layer", DefaultValueHandling = DefaultValueHandling.Include)]
        public RtfWatermarkInputLayerType? Layer { get; set; } = RtfWatermarkInputLayerType.Foreground;

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
        public RtfWatermarkInputWatermarkPageOrientationType? WatermarkPageOrientation { get; set; } = RtfWatermarkInputWatermarkPageOrientationType.Both;

        [JsonProperty("print_only", DefaultValueHandling = DefaultValueHandling.Include)]
        public RtfWatermarkInputPrintOnlyType? PrintOnly { get; set; } = RtfWatermarkInputPrintOnlyType.False;

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
    public enum RtfWatermarkInputPositionType
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
    public enum RtfWatermarkInputLayerType
    {
        Background,
        Foreground
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum RtfWatermarkInputWatermarkPageOrientationType
    {
        Portrait,
        Landscape,
        Both
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum RtfWatermarkInputPrintOnlyType
    {
        [EnumMember(Value = "false")]
        False,
        [EnumMember(Value = "true")]
        True
    }

    public class SecurePdfInput
    {
        [JsonProperty("use_async_pattern", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool UseAsyncPattern { get; set; } = false;

        [JsonProperty("source_file_name")]
        public string SourceFileName { get; set; }

        [JsonProperty("source_file_content", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceFileContent { get; set; }

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

    public class SplitPdfInput
    {
        [JsonProperty("use_async_pattern", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool UseAsyncPattern { get; set; } = false;

        [JsonProperty("source_file_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceFileName { get; set; }

        [JsonProperty("source_file_content", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceFileContent { get; set; }

        [JsonProperty("sharepoint_file")]
        public SharepointFile SharepointFile { get; set; }

        [JsonProperty("file_name_template")]
        public string FileNameTemplate { get; set; }

        [JsonProperty("file_split_by", DefaultValueHandling = DefaultValueHandling.Include)]
        public SplitPdfInputSplitByType SplitBy { get; set; } = SplitPdfInputSplitByType.NumberOfPages;

        [JsonProperty("split_parameter", DefaultValueHandling = DefaultValueHandling.Include)]
        public int SplitParameter { get; set; } = 1;

        [JsonProperty("fail_on_error", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? FailOnError { get; set; } = true;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SplitPdfInputSplitByType
    {
        [EnumMember(Value = "Number of Pages")]
        NumberOfPages,
        [EnumMember(Value = "Bookmark Level")]
        BookmarkLevel
    }

    public class TextWatermarkInput
    {
        [JsonProperty("source_file_name")]
        public string SourceFileName { get; set; }

        [JsonProperty("use_async_pattern", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool UseAsyncPattern { get; set; } = false;

        [JsonProperty("source_file_content", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceFileContent { get; set; }

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
        public TextWatermarkInputTextAlignmentType TextAlignment { get; set; } = TextWatermarkInputTextAlignmentType.TopLeft;

        [JsonProperty("word_wrap", DefaultValueHandling = DefaultValueHandling.Include)]
        public TextWatermarkInputWordWrapType WordWrap { get; set; } = TextWatermarkInputWordWrapType.Word;

        [JsonProperty("position", DefaultValueHandling = DefaultValueHandling.Include)]
        public TextWatermarkInputPositionType Position { get; set; } = TextWatermarkInputPositionType.MiddleCenter;

        [JsonProperty("width", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Width { get; set; }

        [JsonProperty("height", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Height { get; set; }

        [JsonProperty("x")]
        public string XCoordinate { get; set; }

        [JsonProperty("y")]
        public string YCoordinate { get; set; }

        [JsonProperty("layer", DefaultValueHandling = DefaultValueHandling.Include)]
        public TextWatermarkInputLayerType? Layer { get; set; } = TextWatermarkInputLayerType.Foreground;

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
        public TextWatermarkInputWatermarkPageOrientationType? WatermarkPageOrientation { get; set; } = TextWatermarkInputWatermarkPageOrientationType.Both;

        [JsonProperty("print_only", DefaultValueHandling = DefaultValueHandling.Include)]
        public TextWatermarkInputPrintOnlyType? PrintOnly { get; set; } = TextWatermarkInputPrintOnlyType.False;

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
    public enum TextWatermarkInputTextAlignmentType
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
    public enum TextWatermarkInputWordWrapType
    {
        WordOnly,
        Character,
        None,
        Word
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TextWatermarkInputPositionType
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
    public enum TextWatermarkInputLayerType
    {
        Background,
        Foreground
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TextWatermarkInputWatermarkPageOrientationType
    {
        Portrait,
        Landscape,
        Both
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TextWatermarkInputPrintOnlyType
    {
        [EnumMember(Value = "false")]
        False,
        [EnumMember(Value = "true")]
        True
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Muhimbipdf;

    public partial class WorkflowManagedActions
    {
        public MuhimbipdfActions Muhimbipdf(string connectionId) => new MuhimbipdfActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MuhimbipdfTriggers Muhimbipdf(string connectionId) => new MuhimbipdfTriggers(connectionId);
    }
}