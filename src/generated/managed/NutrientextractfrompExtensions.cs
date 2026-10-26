//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientextractfromp
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NutrientextractfrompActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientextractfromp")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientextractfromp")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientextractfromp")]
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
    }

    public class NutrientextractfrompTriggers([ConnectionName] string connectionId)
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
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientextractfromp;

    public partial class WorkflowManagedActions
    {
        public NutrientextractfrompActions Nutrientextractfromp(string connectionId) => new NutrientextractfrompActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public NutrientextractfrompTriggers Nutrientextractfromp(string connectionId) => new NutrientextractfrompTriggers(connectionId);
    }
}