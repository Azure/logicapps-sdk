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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientextractfromp")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientextractfromp")]
        public IBodyWorkflowAction<OcrOperationResponse, ApiConnectionActionConfiguration> OcrText(Expression<Func<InputDataInput>> inputData)
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

    public class ExtractTextInputPdfDataInput
    {
        public ExtractTextInputPdfDataInput(string sourceFileName, global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent sourceFileContent)
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

        [JsonProperty("page_range", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PageRange { get; set; } = "*";

        [JsonProperty("fail_on_error", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? FailOnError { get; set; } = true;
    }

    public class ExtractKeyValuePairsInputPdfDataInput
    {
        public ExtractKeyValuePairsInputPdfDataInput(string sourceFileName, global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent sourceFileContent)
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

        [JsonProperty("ocr_language", DefaultValueHandling = DefaultValueHandling.Include)]
        public string OCRLanguage { get; set; } = "eng";

        [JsonProperty("dpi", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputPdfDataInputDPIType? DPI { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientextractfromp.InputPdfDataInputDPIType._300;

        [JsonProperty("kvp_format", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputPdfDataInputKVPOutputFormatType? KVPOutputFormat { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientextractfromp.InputPdfDataInputKVPOutputFormatType.Json;

        [JsonProperty("page_range", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PageRange { get; set; } = "*";

        [JsonProperty("autorotate", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputPdfDataInputAutorotateType? Autorotate { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientextractfromp.InputPdfDataInputAutorotateType.Default;

        [JsonProperty("trim_symbols", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputPdfDataInputTrimSymbolsType? TrimSymbols { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientextractfromp.InputPdfDataInputTrimSymbolsType.Default;

        [JsonProperty("include_key_bounding_box", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputPdfDataInputIncludeKeyBoundingBoxType? IncludeKeyBoundingBox { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientextractfromp.InputPdfDataInputIncludeKeyBoundingBoxType.Default;

        [JsonProperty("include_value_bounding_box", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputPdfDataInputIncludeValueBoundingBoxType? IncludeValueBoundingBox { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientextractfromp.InputPdfDataInputIncludeValueBoundingBoxType.Default;

        [JsonProperty("include_page_number", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputPdfDataInputIncludePageNumberType? IncludePageNumber { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientextractfromp.InputPdfDataInputIncludePageNumberType.Default;

        [JsonProperty("include_confidence", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputPdfDataInputIncludeConfidenceType? IncludeConfidence { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientextractfromp.InputPdfDataInputIncludeConfidenceType.Default;

        [JsonProperty("confidence_threshold", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? ConfidenceThreshold { get; set; } = 50;

        [JsonProperty("include_type", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputPdfDataInputIncludeTypeType? IncludeType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientextractfromp.InputPdfDataInputIncludeTypeType.Default;

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

    public class InputDataInput
    {
        public InputDataInput(string sourceFileName, global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent sourceFileContent)
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

        [JsonProperty("language", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputLanguageType? Language { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientextractfromp.InputDataInputLanguageType.English;

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
        public InputDataInputPerformanceType? Performance { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientextractfromp.InputDataInputPerformanceType.SlowButAccurate;

        [JsonProperty("characters_option", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputBlacklistWhitelistType? BlacklistWhitelist { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientextractfromp.InputDataInputBlacklistWhitelistType.None;

        [JsonProperty("characters")]
        public string Characters { get; set; }

        [JsonProperty("paginate", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? UsePagination { get; set; } = false;

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