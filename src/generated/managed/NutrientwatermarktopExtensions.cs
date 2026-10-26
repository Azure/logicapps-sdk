//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientwatermarktop
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NutrientwatermarktopActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientwatermarktop")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientwatermarktop")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientwatermarktop")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientwatermarktop")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientwatermarktop")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientwatermarktop")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientwatermarktop")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientwatermarktop")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientwatermarktop")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientwatermarktop")]
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

    public class NutrientwatermarktopTriggers([ConnectionName] string connectionId)
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
    using Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientwatermarktop;

    public partial class WorkflowManagedActions
    {
        public NutrientwatermarktopActions Nutrientwatermarktop(string connectionId) => new NutrientwatermarktopActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public NutrientwatermarktopTriggers Nutrientwatermarktop(string connectionId) => new NutrientwatermarktopTriggers(connectionId);
    }
}