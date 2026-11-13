//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientpdfocr
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NutrientpdfocrActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientpdfocr")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientpdfocr")]
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
    }

    public class NutrientpdfocrTriggers([ConnectionName] string connectionId)
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

    public class OcrPdfInputDataInput
    {
        public OcrPdfInputDataInput(string sourceFileName, global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent sourceFileContent)
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
        internal bool MetaData { get; set; } = false;

        [JsonProperty("language", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputLanguageType? Language { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientpdfocr.InputDataInputLanguageType.English;

        [JsonProperty("performance", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputPerformanceType? Performance { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientpdfocr.InputDataInputPerformanceType.SlowButAccurate;

        [JsonProperty("characters_option", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputBlacklistWhitelistType? BlacklistWhitelist { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientpdfocr.InputDataInputBlacklistWhitelistType.None;

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
        public OcrTextInputDataInput(string sourceFileName, global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent sourceFileContent)
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
        public InputDataInputLanguageType? Language { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientpdfocr.InputDataInputLanguageType.English;

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
        public InputDataInputPerformanceType? Performance { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientpdfocr.InputDataInputPerformanceType.SlowButAccurate;

        [JsonProperty("characters_option", DefaultValueHandling = DefaultValueHandling.Include)]
        public InputDataInputBlacklistWhitelistType? BlacklistWhitelist { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientpdfocr.InputDataInputBlacklistWhitelistType.None;

        [JsonProperty("characters")]
        public string Characters { get; set; }

        [JsonProperty("paginate", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? UsePagination { get; set; } = false;

        [JsonProperty("fail_on_error", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? FailOnError { get; set; } = true;
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientpdfocr;

    public partial class WorkflowManagedActions
    {
        public NutrientpdfocrActions Nutrientpdfocr(string connectionId) => new NutrientpdfocrActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public NutrientpdfocrTriggers Nutrientpdfocr(string connectionId) => new NutrientpdfocrTriggers(connectionId);
    }
}