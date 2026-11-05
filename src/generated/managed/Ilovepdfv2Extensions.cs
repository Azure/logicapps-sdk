//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ilovepdfv2
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Ilovepdfv2Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        public IBodyWorkflowAction<object, ApiConnectionActionConfiguration> Compress(Expression<Func<CompressBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<object, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/compress";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<object>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        public IBodyWorkflowAction<object, ApiConnectionActionConfiguration> Split(Expression<Func<SplitBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<object, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/split";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<object>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        public IBodyWorkflowAction<object, ApiConnectionActionConfiguration> Protect(Expression<Func<ProtectBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<object, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/protect";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<object>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        public IBodyWorkflowAction<object, ApiConnectionActionConfiguration> PDFtoJPG(Expression<Func<PDFtoJPGBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<object, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pdftojpg";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<object>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        public IBodyWorkflowAction<object, ApiConnectionActionConfiguration> ImageToPDF(Expression<Func<ImageToPDFBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<object, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/jpgtoimg";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<object>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        public IBodyWorkflowAction<object, ApiConnectionActionConfiguration> PDFtoPDFA(Expression<Func<PDFtoPDFABodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<object, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pdftopdfa";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<object>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        public IBodyWorkflowAction<object, ApiConnectionActionConfiguration> Unlock(Expression<Func<UnlockBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<object, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/unlock";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<object>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        public IBodyWorkflowAction<object, ApiConnectionActionConfiguration> AddPageNumber(Expression<Func<AddPageNumberBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<object, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pagenumber";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<object>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        public IBodyWorkflowAction<object, ApiConnectionActionConfiguration> Merge(Expression<Func<MergeBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<object, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/merge";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<object>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        public IBodyWorkflowAction<object, ApiConnectionActionConfiguration> Watermark(Expression<Func<WatermarkBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<object, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/watermark";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<object>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        public IBodyWorkflowAction<object, ApiConnectionActionConfiguration> Rotate(Expression<Func<RotateBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<object, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/rotate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<object>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        public IBodyWorkflowAction<object, ApiConnectionActionConfiguration> PDFOCR(Expression<Func<PDFOCRBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<object, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pdfocr";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<object>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        public IBodyWorkflowAction<object, ApiConnectionActionConfiguration> OfficeToPDF(Expression<Func<DetectFormsBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<object, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/officetopdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<object>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        public IBodyWorkflowAction<object, ApiConnectionActionConfiguration> DetectForms(Expression<Func<DetectFormsBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<object, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/detectforms";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<object>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        public IBodyWorkflowAction<object, ApiConnectionActionConfiguration> Summarize(Expression<Func<SummarizeBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<object, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/summarize";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<object>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        public IBodyWorkflowAction<object, ApiConnectionActionConfiguration> Translate(Expression<Func<TranslateBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<object, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/translate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<object>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        public IBodyWorkflowAction<object, ApiConnectionActionConfiguration> SplitSmart(Expression<Func<SplitSmartBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<object, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/splitsmart";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<object>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ilovepdfv2")]
        public IBodyWorkflowAction<object, ApiConnectionActionConfiguration> PDFMarkdown(Expression<Func<DetectFormsBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<object, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pdfmarkdown";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<object>(callPayload);
            });
        }
    }

    public class Ilovepdfv2Triggers([ConnectionName] string connectionId)
    {
    }

    public class CompressBodyInput
    {
        [JsonProperty("file_source", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputFileSourceType FileSource { get; set; }

        [JsonProperty("file_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FileName { get; set; }

        [JsonProperty("file")]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent File { get; set; }

        [JsonProperty("file_url")]
        public string FileUrl { get; set; }

        [JsonProperty("compression_level")]
        public BodyInputCompressionLevelType? CompressionLevel { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputFileSourceType
    {
        [EnumMember(Value = "binary")]
        Binary,
        [EnumMember(Value = "url")]
        Url
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputCompressionLevelType
    {
        [EnumMember(Value = "extreme")]
        Extreme,
        [EnumMember(Value = "recommended")]
        Recommended,
        [EnumMember(Value = "low")]
        Low
    }

    public class SplitBodyInput
    {
        [JsonProperty("file_source", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputFileSourceType FileSource { get; set; }

        [JsonProperty("file_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FileName { get; set; }

        [JsonProperty("file")]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent File { get; set; }

        [JsonProperty("file_url")]
        public string FileUrl { get; set; }

        [JsonProperty("split_mode", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputSplitModeType SplitMode { get; set; }

        [JsonProperty("ranges")]
        public string Ranges { get; set; }

        [JsonProperty("fixed_range")]
        public string FixedRange { get; set; }

        [JsonProperty("remove_pages")]
        public string RemovePages { get; set; }

        [JsonProperty("merge_after")]
        public BodyInputMergeAfterType? MergeAfter { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputSplitModeType
    {
        [EnumMember(Value = "fixed_ranges")]
        FixedRanges,
        [EnumMember(Value = "ranges")]
        Ranges,
        [EnumMember(Value = "fixed_range")]
        FixedRange,
        [EnumMember(Value = "remove_pages")]
        RemovePages,
        [EnumMember(Value = "filesize")]
        Filesize
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputMergeAfterType
    {
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False
    }

    public class ProtectBodyInput
    {
        [JsonProperty("file_source", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputFileSourceType FileSource { get; set; }

        [JsonProperty("file_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FileName { get; set; }

        [JsonProperty("file")]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent File { get; set; }

        [JsonProperty("file_url")]
        public string FileUrl { get; set; }

        [JsonProperty("password", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Password { get; set; }
    }

    public class PDFtoJPGBodyInput
    {
        [JsonProperty("file_source", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputFileSourceType FileSource { get; set; }

        [JsonProperty("file_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FileName { get; set; }

        [JsonProperty("file")]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent File { get; set; }

        [JsonProperty("file_url")]
        public string FileUrl { get; set; }

        [JsonProperty("pdfjpg_mode")]
        public BodyInputPdfjpgModeType? PdfjpgMode { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputPdfjpgModeType
    {
        [EnumMember(Value = "pages")]
        Pages,
        [EnumMember(Value = "extract")]
        Extract
    }

    public class ImageToPDFBodyInput
    {
        [JsonProperty("file_source", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputFileSourceType FileSource { get; set; }

        [JsonProperty("file_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FileName { get; set; }

        [JsonProperty("file")]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent File { get; set; }

        [JsonProperty("file_url")]
        public string FileUrl { get; set; }

        [JsonProperty("orientation")]
        public string Orientation { get; set; }

        [JsonProperty("margin")]
        public string Margin { get; set; }

        [JsonProperty("pagesize")]
        public BodyInputPagesizeType? Pagesize { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputPagesizeType
    {
        [EnumMember(Value = "fit")]
        Fit,
        A4,
        [EnumMember(Value = "letter")]
        Letter
    }

    public class PDFtoPDFABodyInput
    {
        [JsonProperty("file_source", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputFileSourceType FileSource { get; set; }

        [JsonProperty("file_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FileName { get; set; }

        [JsonProperty("file")]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent File { get; set; }

        [JsonProperty("file_url")]
        public string FileUrl { get; set; }

        [JsonProperty("conformance")]
        public BodyInputConformanceType? Conformance { get; set; }

        [JsonProperty("allow_downgrade")]
        public BodyInputAllowDowngradeType? AllowDowngrade { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputConformanceType
    {
        [EnumMember(Value = "pdfa-1b")]
        Pdfa1b,
        [EnumMember(Value = "pdfa-1a")]
        Pdfa1a,
        [EnumMember(Value = "pdfa-2b")]
        Pdfa2b,
        [EnumMember(Value = "pdfa-2u")]
        Pdfa2u,
        [EnumMember(Value = "pdfa-2a")]
        Pdfa2a,
        [EnumMember(Value = "pdfa-3b")]
        Pdfa3b,
        [EnumMember(Value = "pdfa-3u")]
        Pdfa3u,
        [EnumMember(Value = "pdfa-3a")]
        Pdfa3a
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputAllowDowngradeType
    {
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False
    }

    public class UnlockBodyInput
    {
        [JsonProperty("file_source", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputFileSourceType FileSource { get; set; }

        [JsonProperty("file_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FileName { get; set; }

        [JsonProperty("file")]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent File { get; set; }

        [JsonProperty("file_url")]
        public string FileUrl { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }
    }

    public class AddPageNumberBodyInput
    {
        [JsonProperty("file_source", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputFileSourceType FileSource { get; set; }

        [JsonProperty("file_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FileName { get; set; }

        [JsonProperty("file")]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent File { get; set; }

        [JsonProperty("file_url")]
        public string FileUrl { get; set; }

        [JsonProperty("facing_pages")]
        public BodyInputFacingPagesType? FacingPages { get; set; }

        [JsonProperty("first_cover")]
        public BodyInputFirstCoverType? FirstCover { get; set; }

        [JsonProperty("pages")]
        public string Pages { get; set; }

        [JsonProperty("starting_number")]
        public string StartingNumber { get; set; }

        [JsonProperty("vertical_position")]
        public AddPageNumberBodyInputVerticalPositionType? VerticalPosition { get; set; }

        [JsonProperty("horizontal_position")]
        public BodyInputHorizontalPositionType? HorizontalPosition { get; set; }

        [JsonProperty("vertical_position_adjustment")]
        public string VerticalPositionAdjustment { get; set; }

        [JsonProperty("horizontal_position_adjustment")]
        public string HorizontalPositionAdjustment { get; set; }

        [JsonProperty("font_family")]
        public BodyInputFontFamilyType? FontFamily { get; set; }

        [JsonProperty("font_size")]
        public string FontSize { get; set; }

        [JsonProperty("font_color")]
        public string FontColor { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputFacingPagesType
    {
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputFirstCoverType
    {
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddPageNumberBodyInputVerticalPositionType
    {
        [EnumMember(Value = "bottom")]
        Bottom,
        [EnumMember(Value = "top")]
        Top
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputHorizontalPositionType
    {
        [EnumMember(Value = "left")]
        Left,
        [EnumMember(Value = "center")]
        Center,
        [EnumMember(Value = "right")]
        Right
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputFontFamilyType
    {
        Arial,
        [EnumMember(Value = "Arial Unicode MS")]
        ArialUnicodeMS,
        Verdana,
        Courier,
        [EnumMember(Value = "Times New Roman")]
        TimesNewRoman,
        [EnumMember(Value = "Comic Sans MS")]
        ComicSansMS,
        [EnumMember(Value = "WenQuanYi Zen Hei")]
        WenQuanYiZenHei,
        [EnumMember(Value = "Lohit Marathi")]
        LohitMarathi
    }

    public class MergeBodyInput
    {
        [JsonProperty("file_source", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputFileSourceType FileSource { get; set; }

        [JsonProperty("file_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FileName { get; set; }

        [JsonProperty("file")]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent File { get; set; }

        [JsonProperty("file_url")]
        public string FileUrl { get; set; }

        [JsonProperty("file_source2")]
        public BodyInputFileSource2Type? FileSource2 { get; set; }

        [JsonProperty("file_name2")]
        public string FileName2 { get; set; }

        [JsonProperty("file2")]
        public string File2 { get; set; }

        [JsonProperty("file_url2")]
        public string FileUrl2 { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputFileSource2Type
    {
        [EnumMember(Value = "binary")]
        Binary,
        [EnumMember(Value = "url")]
        Url
    }

    public class WatermarkBodyInput
    {
        [JsonProperty("file_source", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputFileSourceType FileSource { get; set; }

        [JsonProperty("file_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FileName { get; set; }

        [JsonProperty("file")]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent File { get; set; }

        [JsonProperty("file_url")]
        public string FileUrl { get; set; }

        [JsonProperty("mode")]
        public BodyInputModeType? Mode { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("image_source")]
        public string ImageSource { get; set; }

        [JsonProperty("image_name")]
        public string ImageName { get; set; }

        [JsonProperty("image_file")]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent ImageFile { get; set; }

        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }

        [JsonProperty("pages")]
        public string Pages { get; set; }

        [JsonProperty("vertical_position")]
        public WatermarkBodyInputVerticalPositionType? VerticalPosition { get; set; }

        [JsonProperty("horizontal_position")]
        public BodyInputHorizontalPositionType? HorizontalPosition { get; set; }

        [JsonProperty("vertical_position_adjustment")]
        public string VerticalPositionAdjustment { get; set; }

        [JsonProperty("horizontal_position_adjustment")]
        public string HorizontalPositionAdjustment { get; set; }

        [JsonProperty("mosaic")]
        public BodyInputMosaicType? Mosaic { get; set; }

        [JsonProperty("rotation")]
        public string Rotation { get; set; }

        [JsonProperty("font_family")]
        public BodyInputFontFamilyType? FontFamily { get; set; }

        [JsonProperty("font_style")]
        public BodyInputFontStyleType? FontStyle { get; set; }

        [JsonProperty("font_size")]
        public string FontSize { get; set; }

        [JsonProperty("font_color")]
        public string FontColor { get; set; }

        [JsonProperty("transparency")]
        public string Transparency { get; set; }

        [JsonProperty("layer")]
        public BodyInputLayerType? Layer { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputModeType
    {
        [EnumMember(Value = "text")]
        Text,
        [EnumMember(Value = "image")]
        Image
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum WatermarkBodyInputVerticalPositionType
    {
        [EnumMember(Value = "bottom")]
        Bottom,
        [EnumMember(Value = "middle")]
        Middle,
        [EnumMember(Value = "top")]
        Top
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputMosaicType
    {
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputFontStyleType
    {
        Bold,
        Italic
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputLayerType
    {
        [EnumMember(Value = "above")]
        Above,
        [EnumMember(Value = "below")]
        Below
    }

    public class RotateBodyInput
    {
        [JsonProperty("file_source", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputFileSourceType FileSource { get; set; }

        [JsonProperty("file_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FileName { get; set; }

        [JsonProperty("file")]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent File { get; set; }

        [JsonProperty("file_url")]
        public string FileUrl { get; set; }

        [JsonProperty("rotate")]
        public BodyInputRotateType? Rotate { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputRotateType
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "90")]
        _90,
        [EnumMember(Value = "180")]
        _180,
        [EnumMember(Value = "270")]
        _270
    }

    public class PDFOCRBodyInput
    {
        [JsonProperty("file_source", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputFileSourceType FileSource { get; set; }

        [JsonProperty("file_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FileName { get; set; }

        [JsonProperty("file")]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent File { get; set; }

        [JsonProperty("file_url")]
        public string FileUrl { get; set; }

        [JsonProperty("ocr_languages")]
        public string OcrLanguages { get; set; }
    }

    public class DetectFormsBodyInput
    {
        [JsonProperty("file_source", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputFileSourceType FileSource { get; set; }

        [JsonProperty("file_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FileName { get; set; }

        [JsonProperty("file")]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent File { get; set; }

        [JsonProperty("file_url")]
        public string FileUrl { get; set; }
    }

    public class SummarizeBodyInput
    {
        [JsonProperty("file_source", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputFileSourceType FileSource { get; set; }

        [JsonProperty("file_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FileName { get; set; }

        [JsonProperty("file")]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent File { get; set; }

        [JsonProperty("file_url")]
        public string FileUrl { get; set; }

        [JsonProperty("language", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Language { get; set; }

        [JsonProperty("output_format")]
        public string OutputFormat { get; set; }
    }

    public class TranslateBodyInput
    {
        [JsonProperty("file_source", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputFileSourceType FileSource { get; set; }

        [JsonProperty("file_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FileName { get; set; }

        [JsonProperty("file")]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent File { get; set; }

        [JsonProperty("file_url")]
        public string FileUrl { get; set; }

        [JsonProperty("language_output")]
        public string LanguageOutput { get; set; }

        [JsonProperty("translate_mode")]
        public string TranslateMode { get; set; }
    }

    public class SplitSmartBodyInput
    {
        [JsonProperty("file_source", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputFileSourceType FileSource { get; set; }

        [JsonProperty("file_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FileName { get; set; }

        [JsonProperty("file")]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent File { get; set; }

        [JsonProperty("file_url")]
        public string FileUrl { get; set; }

        [JsonProperty("prompt", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Prompt { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Ilovepdfv2;

    public partial class WorkflowManagedActions
    {
        public Ilovepdfv2Actions Ilovepdfv2(string connectionId) => new Ilovepdfv2Actions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Ilovepdfv2Triggers Ilovepdfv2(string connectionId) => new Ilovepdfv2Triggers(connectionId);
    }
}