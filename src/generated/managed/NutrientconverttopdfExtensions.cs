//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientconverttopdf
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NutrientconverttopdfActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientconverttopdf")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientconverttopdf")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientconverttopdf")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientconverttopdf")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientconverttopdf")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientconverttopdf")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientconverttopdf")]
        public IBodyWorkflowAction<OperationResponse, ApiConnectionActionConfiguration> ConvertPdfa(Expression<Func<InputPdfDataInput>> inputPdfData)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientconverttopdf")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientconverttopdf")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientconverttopdf")]
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
    }

    public class NutrientconverttopdfTriggers([ConnectionName] string connectionId)
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

    public class ConvertInputDataInput
    {
        public ConvertInputDataInput(string sourceFileName, global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent sourceFileContent)
        {
            this.SourceFileName = sourceFileName;
            this.SourceFileContent = sourceFileContent;
        }

        [JsonProperty("use_async_pattern", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool UseAsyncPattern { get; set; } = false;

        [JsonProperty("source_file_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceFileName { get; set; }

        [JsonProperty("source_file_content", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent SourceFileContent { get; set; }

        [JsonProperty("output_format", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputOutputFormatType OutputFormat { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientconverttopdf.InputDataInputOutputFormatType.PDF;

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
        public InputCadDataInput(string sourceFileName, global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent sourceFileContent)
        {
            this.SourceFileName = sourceFileName;
            this.SourceFileContent = sourceFileContent;
        }

        [JsonProperty("use_async_pattern", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool UseAsyncPattern { get; set; } = false;

        [JsonProperty("source_file_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceFileName { get; set; }

        [JsonProperty("source_file_content", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent SourceFileContent { get; set; }

        [JsonProperty("copy_metadata", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool CopyMetadata { get; set; } = false;

        [JsonProperty("paper_size", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputCadDataInputPaperSizeType? PaperSize { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientconverttopdf.InputCadDataInputPaperSizeType.Letter;

        [JsonProperty("paper_size_custom")]
        public string PaperSizeCustom { get; set; }

        [JsonProperty("page_margins", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PageMargins { get; set; } = "0.25";

        [JsonProperty("background_color", DefaultValueHandling = DefaultValueHandling.Include)]
        public string BackgroundColor { get; set; } = "White";

        [JsonProperty("foreground_color", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputCadDataInputForegroundColorType? ForegroundColor { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientconverttopdf.InputCadDataInputForegroundColorType.GreyscaleDarken;

        [JsonProperty("foreground_color_custom")]
        public string ForegroundColorCustom { get; set; }

        [JsonProperty("empty_layout_detection_mode", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputCadDataInputEmptyLayoutDetectionType? EmptyLayoutDetection { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientconverttopdf.InputCadDataInputEmptyLayoutDetectionType.SkipEmptyLayouts;

        [JsonProperty("layout_sort_order", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputCadDataInputLayoutSortOrderType? LayoutSortOrder { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientconverttopdf.InputCadDataInputLayoutSortOrderType.Ascending;

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
        public InputEmailDataInput(string sourceFileName, global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent sourceFileContent)
        {
            this.SourceFileName = sourceFileName;
            this.SourceFileContent = sourceFileContent;
        }

        [JsonProperty("use_async_pattern", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool UseAsyncPattern { get; set; } = false;

        [JsonProperty("source_file_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceFileName { get; set; }

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
        public InputEmailDataInputUnsupportedAttachmentActionType? UnsupportedAttachmentAction { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientconverttopdf.InputEmailDataInputUnsupportedAttachmentActionType.Error;

        [JsonProperty("include_attachment_types")]
        public string IncludeAttachmentFilter { get; set; }

        [JsonProperty("exclude_attachment_types")]
        public string ExcludeAttachmentFilter { get; set; }

        [JsonProperty("viewport_Size", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ViewportSize { get; set; } = "Paper";

        [JsonProperty("paper_size", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputEmailDataInputPaperSizeType? PaperSize { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientconverttopdf.InputEmailDataInputPaperSizeType.Letter;

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
        public InputExcelDataInput(string sourceFileName, global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent sourceFileContent)
        {
            this.SourceFileName = sourceFileName;
            this.SourceFileContent = sourceFileContent;
        }

        [JsonProperty("use_async_pattern", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool UseAsyncPattern { get; set; } = false;

        [JsonProperty("source_file_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceFileName { get; set; }

        [JsonProperty("source_file_content", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent SourceFileContent { get; set; }

        [JsonProperty("output_format", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputExcelDataInputOutputFormatType OutputFormat { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientconverttopdf.InputExcelDataInputOutputFormatType.PDF;

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
        public ConvertHtmlInputDataInput(string sourceURLOrHTML)
        {
            this.SourceURLOrHTML = sourceURLOrHTML;
        }

        [JsonProperty("use_async_pattern", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool UseAsyncPattern { get; set; } = false;

        [JsonProperty("source_url_or_html", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceURLOrHTML { get; set; }

        [JsonProperty("page_orientation", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputPageOrientationType? PageOrientation { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientconverttopdf.InputDataInputPageOrientationType.Portrait;

        [JsonProperty("media_type", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputMediaTypeType? MediaType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientconverttopdf.InputDataInputMediaTypeType.Screen;

        [JsonProperty("authentication_type", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputAuthenticationTypeType? AuthenticationType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientconverttopdf.InputDataInputAuthenticationTypeType.Anonymous;

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
        public InputInfopathDataInput(string sourceFileName, global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent sourceFileContent)
        {
            this.SourceFileName = sourceFileName;
            this.SourceFileContent = sourceFileContent;
        }

        [JsonProperty("use_async_pattern", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool UseAsyncPattern { get; set; } = false;

        [JsonProperty("source_file_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceFileName { get; set; }

        [JsonProperty("source_file_content", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent SourceFileContent { get; set; }

        [JsonProperty("output_format", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputInfopathDataInputOutputFormatType OutputFormat { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientconverttopdf.InputInfopathDataInputOutputFormatType.PDF;

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
        public InputInfopathDataInputDefaultPageOrientationType? DefaultPageOrientation { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientconverttopdf.InputInfopathDataInputDefaultPageOrientationType.Default;

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

    public class InputPdfDataInput
    {
        public InputPdfDataInput(string sourceFileName, global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent sourceFileContent)
        {
            this.SourceFileName = sourceFileName;
            this.SourceFileContent = sourceFileContent;
        }

        [JsonProperty("use_async_pattern", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool UseAsyncPattern { get; set; } = false;

        [JsonProperty("source_file_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceFileName { get; set; }

        [JsonProperty("source_file_content", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent SourceFileContent { get; set; }

        [JsonProperty("copy_metadata", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool CopyMetadata { get; set; } = false;

        [JsonProperty("pdf_profile", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputPdfDataInputPDFProfileType PDFProfile { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientconverttopdf.InputPdfDataInputPDFProfileType.PDFA2B;

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
        public InputPowerpointDataInput(string sourceFileName, global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent sourceFileContent)
        {
            this.SourceFileName = sourceFileName;
            this.SourceFileContent = sourceFileContent;
        }

        [JsonProperty("use_async_pattern", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool UseAsyncPattern { get; set; } = false;

        [JsonProperty("source_file_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceFileName { get; set; }

        [JsonProperty("source_file_content", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent SourceFileContent { get; set; }

        [JsonProperty("output_format", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputPowerpointDataInputOutputFormatType OutputFormat { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientconverttopdf.InputPowerpointDataInputOutputFormatType.PDF;

        [JsonProperty("copy_metadata", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool CopyMetadata { get; set; } = false;

        [JsonProperty("range")]
        public InputPowerpointDataInputRangeType? Range { get; set; }

        [JsonProperty("print_output_type", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputPowerpointDataInputPrintLayoutHandoutsType? PrintLayoutHandouts { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientconverttopdf.InputPowerpointDataInputPrintLayoutHandoutsType.Slides;

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
        public InputVisioDataInput(string sourceFileName, global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent sourceFileContent)
        {
            this.SourceFileName = sourceFileName;
            this.SourceFileContent = sourceFileContent;
        }

        [JsonProperty("use_async_pattern", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool UseAsyncPattern { get; set; } = false;

        [JsonProperty("source_file_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceFileName { get; set; }

        [JsonProperty("source_file_content", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent SourceFileContent { get; set; }

        [JsonProperty("output_format", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputVisioDataInputOutputFormatType OutputFormat { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientconverttopdf.InputVisioDataInputOutputFormatType.PDF;

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
        public InputWordDataInput(string sourceFileName, global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent sourceFileContent)
        {
            this.SourceFileName = sourceFileName;
            this.SourceFileContent = sourceFileContent;
        }

        [JsonProperty("use_async_pattern", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool UseAsyncPattern { get; set; } = false;

        [JsonProperty("source_file_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceFileName { get; set; }

        [JsonProperty("source_file_content", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent SourceFileContent { get; set; }

        [JsonProperty("output_format", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputWordDataInputOutputFormatType OutputFormat { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientconverttopdf.InputWordDataInputOutputFormatType.PDF;

        [JsonProperty("copy_metadata", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool CopyMetadata { get; set; } = false;

        [JsonProperty("revisions_and_comments_display_mode", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputWordDataInputDisplayForReviewType? DisplayForReview { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientconverttopdf.InputWordDataInputDisplayForReviewType.Final;

        [JsonProperty("revisions_and_comments_markup_mode", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputWordDataInputReviewMarkupModeType? ReviewMarkupMode { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientconverttopdf.InputWordDataInputReviewMarkupModeType.InLine;

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
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientconverttopdf;

    public partial class WorkflowManagedActions
    {
        public NutrientconverttopdfActions Nutrientconverttopdf(string connectionId) => new NutrientconverttopdfActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public NutrientconverttopdfTriggers Nutrientconverttopdf(string connectionId) => new NutrientconverttopdfTriggers(connectionId);
    }
}