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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientconverttopdf")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientconverttopdf")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientconverttopdf")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientconverttopdf")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientconverttopdf")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientconverttopdf")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientconverttopdf")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientconverttopdf")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientconverttopdf")]
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