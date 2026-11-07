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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientwatermarktop")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientwatermarktop")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientwatermarktop")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientwatermarktop")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientwatermarktop")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientwatermarktop")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientwatermarktop")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientwatermarktop")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientwatermarktop")]
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

    public class CompositeWatermarkInputDataInput
    {
        [JsonProperty("source_file_name")]
        public string SourceFileName { get; set; }

        [JsonProperty("use_async_pattern", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool UseAsyncPattern { get; set; } = false;

        [JsonProperty("source_file_content", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent SourceFileContent { get; set; }

        [JsonProperty("watermark_data", DefaultValueHandling = DefaultValueHandling.Include)]
        public string WatermarkData { get; set; }

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
        public InputDataInputPositionType Position { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientwatermarktop.InputDataInputPositionType.MiddleCenter;

        [JsonProperty("width", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Width { get; set; }

        [JsonProperty("height", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Height { get; set; }

        [JsonProperty("x")]
        public string XCoordinate { get; set; }

        [JsonProperty("y")]
        public string YCoordinate { get; set; }

        [JsonProperty("layer", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputLayerType? Layer { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientwatermarktop.InputDataInputLayerType.Foreground;

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
        public InputDataInputWatermarkPageOrientationType? WatermarkPageOrientation { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientwatermarktop.InputDataInputWatermarkPageOrientationType.Both;

        [JsonProperty("print_only", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputPrintOnlyType? PrintOnly { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientwatermarktop.InputDataInputPrintOnlyType.False;

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

        [JsonProperty("position", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputPositionType Position { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientwatermarktop.InputDataInputPositionType.MiddleCenter;

        [JsonProperty("width", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Width { get; set; }

        [JsonProperty("height", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Height { get; set; }

        [JsonProperty("x")]
        public string XCoordinate { get; set; }

        [JsonProperty("y")]
        public string YCoordinate { get; set; }

        [JsonProperty("layer", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputLayerType? Layer { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientwatermarktop.InputDataInputLayerType.Foreground;

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
        public InputDataInputWatermarkPageOrientationType? WatermarkPageOrientation { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientwatermarktop.InputDataInputWatermarkPageOrientationType.Both;

        [JsonProperty("print_only", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputPrintOnlyType? PrintOnly { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientwatermarktop.InputDataInputPrintOnlyType.False;

        [JsonProperty("start_section")]
        public int? WatermarkStartSection { get; set; }

        [JsonProperty("end_section")]
        public int? WatermarkEndSection { get; set; }

        [JsonProperty("page_type")]
        public string WatermarkPageType { get; set; }

        [JsonProperty("fail_on_error", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? FailOnError { get; set; } = true;
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
        public InputDataInputPositionType Position { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientwatermarktop.InputDataInputPositionType.MiddleCenter;

        [JsonProperty("x", DefaultValueHandling = DefaultValueHandling.Include)]
        public string XCoordinateStart { get; set; }

        [JsonProperty("y", DefaultValueHandling = DefaultValueHandling.Include)]
        public string YCoordinateStart { get; set; }

        [JsonProperty("end_x", DefaultValueHandling = DefaultValueHandling.Include)]
        public string XCoordinateEnd { get; set; }

        [JsonProperty("end_y", DefaultValueHandling = DefaultValueHandling.Include)]
        public string YCoordinateEnd { get; set; }

        [JsonProperty("layer", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputLayerType? Layer { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientwatermarktop.InputDataInputLayerType.Foreground;

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
        public InputDataInputWatermarkPageOrientationType? WatermarkPageOrientation { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientwatermarktop.InputDataInputWatermarkPageOrientationType.Both;

        [JsonProperty("print_only", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputPrintOnlyType? PrintOnly { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientwatermarktop.InputDataInputPrintOnlyType.False;

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

        [JsonProperty("barcode_type", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputBarcodeTypeType BarcodeType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientwatermarktop.InputDataInputBarcodeTypeType.Codabar;

        [JsonProperty("omit_start_stop_symbols", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputOmitEncodingOfStartStopSymbolsType? OmitEncodingOfStartStopSymbols { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientwatermarktop.InputDataInputOmitEncodingOfStartStopSymbolsType.False;

        [JsonProperty("disable_checkdigit", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputDisableCheckDigitType DisableCheckDigit { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientwatermarktop.InputDataInputDisableCheckDigitType.False;

        [JsonProperty("show_checkdigit", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputShowCheckDigitType ShowCheckDigit { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientwatermarktop.InputDataInputShowCheckDigitType.False;

        [JsonProperty("margin")]
        public string Margin { get; set; }

        [JsonProperty("font_family_name")]
        public string FontFamily { get; set; }

        [JsonProperty("font_size")]
        public string FontSize { get; set; }

        [JsonProperty("font_style")]
        public string FontStyle { get; set; }

        [JsonProperty("label_placement", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputLabelPlacementType? LabelPlacement { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientwatermarktop.InputDataInputLabelPlacementType.BottomCenter;

        [JsonProperty("position", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputPositionType Position { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientwatermarktop.InputDataInputPositionType.MiddleCenter;

        [JsonProperty("width", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Width { get; set; }

        [JsonProperty("height", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Height { get; set; }

        [JsonProperty("x")]
        public string XCoordinate { get; set; }

        [JsonProperty("y")]
        public string YCoordinate { get; set; }

        [JsonProperty("layer", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputLayerType? Layer { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientwatermarktop.InputDataInputLayerType.Foreground;

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
        public InputDataInputWatermarkPageOrientationType? WatermarkPageOrientation { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientwatermarktop.InputDataInputWatermarkPageOrientationType.Both;

        [JsonProperty("print_only", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputPrintOnlyType? PrintOnly { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientwatermarktop.InputDataInputPrintOnlyType.False;

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

        [JsonProperty("position", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputPositionType Position { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientwatermarktop.InputDataInputPositionType.MiddleCenter;

        [JsonProperty("width", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Width { get; set; }

        [JsonProperty("height", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Height { get; set; }

        [JsonProperty("x")]
        public string XCoordinate { get; set; }

        [JsonProperty("y")]
        public string YCoordinate { get; set; }

        [JsonProperty("layer", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputLayerType? Layer { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientwatermarktop.InputDataInputLayerType.Foreground;

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
        public InputDataInputWatermarkPageOrientationType? WatermarkPageOrientation { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientwatermarktop.InputDataInputWatermarkPageOrientationType.Both;

        [JsonProperty("print_only", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputPrintOnlyType? PrintOnly { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientwatermarktop.InputDataInputPrintOnlyType.False;

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

        [JsonProperty("version", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputVersionType Version { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientwatermarktop.InputDataInputVersionType.Auto;

        [JsonProperty("input_mode", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputInputModeType InputMode { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientwatermarktop.InputDataInputInputModeType.Binary;

        [JsonProperty("error_correction_level", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputErrorCorrectionLevelType ErrorCorrectionLevel { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientwatermarktop.InputDataInputErrorCorrectionLevelType.Low;

        [JsonProperty("position", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputPositionType Position { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientwatermarktop.InputDataInputPositionType.MiddleCenter;

        [JsonProperty("width", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Width { get; set; }

        [JsonProperty("height", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Height { get; set; }

        [JsonProperty("x")]
        public string XCoordinate { get; set; }

        [JsonProperty("y")]
        public string YCoordinate { get; set; }

        [JsonProperty("layer", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputLayerType? Layer { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientwatermarktop.InputDataInputLayerType.Foreground;

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
        public InputDataInputWatermarkPageOrientationType? WatermarkPageOrientation { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientwatermarktop.InputDataInputWatermarkPageOrientationType.Both;

        [JsonProperty("print_only", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputPrintOnlyType? PrintOnly { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientwatermarktop.InputDataInputPrintOnlyType.False;

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
        public InputDataInputPositionType Position { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientwatermarktop.InputDataInputPositionType.MiddleCenter;

        [JsonProperty("width", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Width { get; set; }

        [JsonProperty("height", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Height { get; set; }

        [JsonProperty("x")]
        public string XCoordinate { get; set; }

        [JsonProperty("y")]
        public string YCoordinate { get; set; }

        [JsonProperty("layer", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputLayerType? Layer { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientwatermarktop.InputDataInputLayerType.Foreground;

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
        public InputDataInputWatermarkPageOrientationType? WatermarkPageOrientation { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientwatermarktop.InputDataInputWatermarkPageOrientationType.Both;

        [JsonProperty("print_only", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputPrintOnlyType? PrintOnly { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientwatermarktop.InputDataInputPrintOnlyType.False;

        [JsonProperty("start_section")]
        public int? WatermarkStartSection { get; set; }

        [JsonProperty("end_section")]
        public int? WatermarkEndSection { get; set; }

        [JsonProperty("page_type")]
        public string WatermarkPageType { get; set; }

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

        [JsonProperty("position", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputPositionType Position { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientwatermarktop.InputDataInputPositionType.MiddleCenter;

        [JsonProperty("width", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Width { get; set; }

        [JsonProperty("height", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Height { get; set; }

        [JsonProperty("x")]
        public string XCoordinate { get; set; }

        [JsonProperty("y")]
        public string YCoordinate { get; set; }

        [JsonProperty("layer", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputLayerType? Layer { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientwatermarktop.InputDataInputLayerType.Foreground;

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
        public InputDataInputWatermarkPageOrientationType? WatermarkPageOrientation { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientwatermarktop.InputDataInputWatermarkPageOrientationType.Both;

        [JsonProperty("print_only", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputPrintOnlyType? PrintOnly { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientwatermarktop.InputDataInputPrintOnlyType.False;

        [JsonProperty("start_section")]
        public int? WatermarkStartSection { get; set; }

        [JsonProperty("end_section")]
        public int? WatermarkEndSection { get; set; }

        [JsonProperty("page_type")]
        public string WatermarkPageType { get; set; }

        [JsonProperty("fail_on_error", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? FailOnError { get; set; } = true;
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

        [JsonProperty("font_family_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FontFamilyName { get; set; }

        [JsonProperty("font_size", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FontSize { get; set; } = "12";

        [JsonProperty("fill_color", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FontColor { get; set; } = "#000000";

        [JsonProperty("alignment", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputTextAlignmentType TextAlignment { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientwatermarktop.InputDataInputTextAlignmentType.TopLeft;

        [JsonProperty("word_wrap", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputWordWrapType WordWrap { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientwatermarktop.InputDataInputWordWrapType.Word;

        [JsonProperty("position", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputPositionType Position { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientwatermarktop.InputDataInputPositionType.MiddleCenter;

        [JsonProperty("width", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Width { get; set; }

        [JsonProperty("height", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Height { get; set; }

        [JsonProperty("x")]
        public string XCoordinate { get; set; }

        [JsonProperty("y")]
        public string YCoordinate { get; set; }

        [JsonProperty("layer", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputLayerType? Layer { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientwatermarktop.InputDataInputLayerType.Foreground;

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
        public InputDataInputWatermarkPageOrientationType? WatermarkPageOrientation { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientwatermarktop.InputDataInputWatermarkPageOrientationType.Both;

        [JsonProperty("print_only", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputPrintOnlyType? PrintOnly { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientwatermarktop.InputDataInputPrintOnlyType.False;

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