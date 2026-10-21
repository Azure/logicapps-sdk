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
        public IBodyWorkflowAction<OperationResponse> ExtractText(Expression<Func<string>> inputPdfDatasourceFileName, Expression<Func<string>> inputPdfDatasourceFileContent, Expression<Func<string>> inputPdfDatapageRange = null, Expression<Func<bool>> inputPdfDatafailOnError = null)
        {
            var __workflow_inputPdfDatasourceFileName = WorkflowExpression.Compile(inputPdfDatasourceFileName, nameof(inputPdfDatasourceFileName), required: true);
            var __workflow_inputPdfDatasourceFileContent = WorkflowExpression.Compile(inputPdfDatasourceFileContent, nameof(inputPdfDatasourceFileContent), required: true);
            var __workflow_inputPdfDatapageRange = WorkflowExpression.Compile(inputPdfDatapageRange, nameof(inputPdfDatapageRange), required: false);
            var __workflow_inputPdfDatafailOnError = WorkflowExpression.Compile(inputPdfDatafailOnError, nameof(inputPdfDatafailOnError), required: false);
            return new DeferredBodyAction<OperationResponse>(() =>
            {
                var apiCallPath = "/v1/operations/extract_text";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputPdfData = new JObject();
                var inputPdfDatapropCount = 0;
                inputPdfData["use_async_pattern"] = false;
                inputPdfDatapropCount++;
                inputPdfDatapropCount++;
                inputPdfData["source_file_name"] = ExpressionConverter.ConvertO(__workflow_inputPdfDatasourceFileName);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputPdfData["sharepoint_file"] = sharepointFileObject;
                    inputPdfDatapropCount++;
                }

                inputPdfDatapropCount++;
                inputPdfData["source_file_content"] = ExpressionConverter.ConvertO(__workflow_inputPdfDatasourceFileContent);
                if (__workflow_inputPdfDatapageRange != null)
                {
                    if (__workflow_inputPdfDatapageRange != null)
                    {
                        inputPdfData["page_range"] = ExpressionConverter.ConvertO(__workflow_inputPdfDatapageRange);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["page_range"] = "*";
                    inputPdfDatapropCount++;
                }

                if (__workflow_inputPdfDatafailOnError != null)
                {
                    if (__workflow_inputPdfDatafailOnError != null)
                    {
                        inputPdfData["fail_on_error"] = ExpressionConverter.ConvertO(__workflow_inputPdfDatafailOnError);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["fail_on_error"] = true;
                    inputPdfDatapropCount++;
                }

                if (inputPdfDatapropCount > 0)
                {
                    callPayload.Body = inputPdfData;
                }

                return new ApiConnectionAction<OperationResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientextractfromp")]
        public IBodyWorkflowAction<OperationResponse> ExtractKeyValuePairs(Expression<Func<string>> inputPdfDatasourceFileName, Expression<Func<string>> inputPdfDatasourceFileContent, Expression<Func<string>> inputPdfDataoCRLanguage = null, Expression<Func<inputPdfDatadPIInput>> inputPdfDatadPI = null, Expression<Func<inputPdfDatakVPOutputFormatInput>> inputPdfDatakVPOutputFormat = null, Expression<Func<string>> inputPdfDatapageRange = null, Expression<Func<inputPdfDataautorotateInput>> inputPdfDataautorotate = null, Expression<Func<inputPdfDatatrimSymbolsInput>> inputPdfDatatrimSymbols = null, Expression<Func<inputPdfDataincludeKeyBoundingBoxInput>> inputPdfDataincludeKeyBoundingBox = null, Expression<Func<inputPdfDataincludeValueBoundingBoxInput>> inputPdfDataincludeValueBoundingBox = null, Expression<Func<inputPdfDataincludePageNumberInput>> inputPdfDataincludePageNumber = null, Expression<Func<inputPdfDataincludeConfidenceInput>> inputPdfDataincludeConfidence = null, Expression<Func<int>> inputPdfDataconfidenceThreshold = null, Expression<Func<inputPdfDataincludeTypeInput>> inputPdfDataincludeType = null, Expression<Func<string>> inputPdfDataexpectedKeys = null, Expression<Func<bool>> inputPdfDatafailOnError = null)
        {
            var __workflow_inputPdfDatasourceFileName = WorkflowExpression.Compile(inputPdfDatasourceFileName, nameof(inputPdfDatasourceFileName), required: true);
            var __workflow_inputPdfDatasourceFileContent = WorkflowExpression.Compile(inputPdfDatasourceFileContent, nameof(inputPdfDatasourceFileContent), required: true);
            var __workflow_inputPdfDataoCRLanguage = WorkflowExpression.Compile(inputPdfDataoCRLanguage, nameof(inputPdfDataoCRLanguage), required: false);
            var __workflow_inputPdfDatadPI = WorkflowExpression.Compile(inputPdfDatadPI, nameof(inputPdfDatadPI), required: false);
            var __workflow_inputPdfDatakVPOutputFormat = WorkflowExpression.Compile(inputPdfDatakVPOutputFormat, nameof(inputPdfDatakVPOutputFormat), required: false);
            var __workflow_inputPdfDatapageRange = WorkflowExpression.Compile(inputPdfDatapageRange, nameof(inputPdfDatapageRange), required: false);
            var __workflow_inputPdfDataautorotate = WorkflowExpression.Compile(inputPdfDataautorotate, nameof(inputPdfDataautorotate), required: false);
            var __workflow_inputPdfDatatrimSymbols = WorkflowExpression.Compile(inputPdfDatatrimSymbols, nameof(inputPdfDatatrimSymbols), required: false);
            var __workflow_inputPdfDataincludeKeyBoundingBox = WorkflowExpression.Compile(inputPdfDataincludeKeyBoundingBox, nameof(inputPdfDataincludeKeyBoundingBox), required: false);
            var __workflow_inputPdfDataincludeValueBoundingBox = WorkflowExpression.Compile(inputPdfDataincludeValueBoundingBox, nameof(inputPdfDataincludeValueBoundingBox), required: false);
            var __workflow_inputPdfDataincludePageNumber = WorkflowExpression.Compile(inputPdfDataincludePageNumber, nameof(inputPdfDataincludePageNumber), required: false);
            var __workflow_inputPdfDataincludeConfidence = WorkflowExpression.Compile(inputPdfDataincludeConfidence, nameof(inputPdfDataincludeConfidence), required: false);
            var __workflow_inputPdfDataconfidenceThreshold = WorkflowExpression.Compile(inputPdfDataconfidenceThreshold, nameof(inputPdfDataconfidenceThreshold), required: false);
            var __workflow_inputPdfDataincludeType = WorkflowExpression.Compile(inputPdfDataincludeType, nameof(inputPdfDataincludeType), required: false);
            var __workflow_inputPdfDataexpectedKeys = WorkflowExpression.Compile(inputPdfDataexpectedKeys, nameof(inputPdfDataexpectedKeys), required: false);
            var __workflow_inputPdfDatafailOnError = WorkflowExpression.Compile(inputPdfDatafailOnError, nameof(inputPdfDatafailOnError), required: false);
            return new DeferredBodyAction<OperationResponse>(() =>
            {
                var apiCallPath = "/v1/operations/key_value_pairs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputPdfData = new JObject();
                var inputPdfDatapropCount = 0;
                inputPdfData["use_async_pattern"] = false;
                inputPdfDatapropCount++;
                inputPdfDatapropCount++;
                inputPdfData["source_file_name"] = ExpressionConverter.ConvertO(__workflow_inputPdfDatasourceFileName);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputPdfData["sharepoint_file"] = sharepointFileObject;
                    inputPdfDatapropCount++;
                }

                inputPdfDatapropCount++;
                inputPdfData["source_file_content"] = ExpressionConverter.ConvertO(__workflow_inputPdfDatasourceFileContent);
                if (__workflow_inputPdfDataoCRLanguage != null)
                {
                    if (__workflow_inputPdfDataoCRLanguage != null)
                    {
                        inputPdfData["ocr_language"] = ExpressionConverter.ConvertO(__workflow_inputPdfDataoCRLanguage);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["ocr_language"] = "eng";
                    inputPdfDatapropCount++;
                }

                if (__workflow_inputPdfDatadPI != null)
                {
                    if (__workflow_inputPdfDatadPI != null)
                    {
                        inputPdfData["dpi"] = ExpressionConverter.ConvertO(__workflow_inputPdfDatadPI);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["dpi"] = "300";
                    inputPdfDatapropCount++;
                }

                if (__workflow_inputPdfDatakVPOutputFormat != null)
                {
                    if (__workflow_inputPdfDatakVPOutputFormat != null)
                    {
                        inputPdfData["kvp_format"] = ExpressionConverter.ConvertO(__workflow_inputPdfDatakVPOutputFormat);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["kvp_format"] = "json";
                    inputPdfDatapropCount++;
                }

                if (__workflow_inputPdfDatapageRange != null)
                {
                    if (__workflow_inputPdfDatapageRange != null)
                    {
                        inputPdfData["page_range"] = ExpressionConverter.ConvertO(__workflow_inputPdfDatapageRange);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["page_range"] = "*";
                    inputPdfDatapropCount++;
                }

                if (__workflow_inputPdfDataautorotate != null)
                {
                    if (__workflow_inputPdfDataautorotate != null)
                    {
                        inputPdfData["autorotate"] = ExpressionConverter.ConvertO(__workflow_inputPdfDataautorotate);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["autorotate"] = "Default";
                    inputPdfDatapropCount++;
                }

                if (__workflow_inputPdfDatatrimSymbols != null)
                {
                    if (__workflow_inputPdfDatatrimSymbols != null)
                    {
                        inputPdfData["trim_symbols"] = ExpressionConverter.ConvertO(__workflow_inputPdfDatatrimSymbols);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["trim_symbols"] = "Default";
                    inputPdfDatapropCount++;
                }

                if (__workflow_inputPdfDataincludeKeyBoundingBox != null)
                {
                    if (__workflow_inputPdfDataincludeKeyBoundingBox != null)
                    {
                        inputPdfData["include_key_bounding_box"] = ExpressionConverter.ConvertO(__workflow_inputPdfDataincludeKeyBoundingBox);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["include_key_bounding_box"] = "Default";
                    inputPdfDatapropCount++;
                }

                if (__workflow_inputPdfDataincludeValueBoundingBox != null)
                {
                    if (__workflow_inputPdfDataincludeValueBoundingBox != null)
                    {
                        inputPdfData["include_value_bounding_box"] = ExpressionConverter.ConvertO(__workflow_inputPdfDataincludeValueBoundingBox);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["include_value_bounding_box"] = "Default";
                    inputPdfDatapropCount++;
                }

                if (__workflow_inputPdfDataincludePageNumber != null)
                {
                    if (__workflow_inputPdfDataincludePageNumber != null)
                    {
                        inputPdfData["include_page_number"] = ExpressionConverter.ConvertO(__workflow_inputPdfDataincludePageNumber);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["include_page_number"] = "Default";
                    inputPdfDatapropCount++;
                }

                if (__workflow_inputPdfDataincludeConfidence != null)
                {
                    if (__workflow_inputPdfDataincludeConfidence != null)
                    {
                        inputPdfData["include_confidence"] = ExpressionConverter.ConvertO(__workflow_inputPdfDataincludeConfidence);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["include_confidence"] = "Default";
                    inputPdfDatapropCount++;
                }

                if (__workflow_inputPdfDataconfidenceThreshold != null)
                {
                    if (__workflow_inputPdfDataconfidenceThreshold != null)
                    {
                        inputPdfData["confidence_threshold"] = ExpressionConverter.ConvertO(__workflow_inputPdfDataconfidenceThreshold);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["confidence_threshold"] = 50;
                    inputPdfDatapropCount++;
                }

                if (__workflow_inputPdfDataincludeType != null)
                {
                    if (__workflow_inputPdfDataincludeType != null)
                    {
                        inputPdfData["include_type"] = ExpressionConverter.ConvertO(__workflow_inputPdfDataincludeType);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["include_type"] = "Default";
                    inputPdfDatapropCount++;
                }

                if (__workflow_inputPdfDataexpectedKeys != null)
                {
                    inputPdfData["expected_keys"] = ExpressionConverter.ConvertO(__workflow_inputPdfDataexpectedKeys);
                    inputPdfDatapropCount++;
                }

                if (__workflow_inputPdfDatafailOnError != null)
                {
                    if (__workflow_inputPdfDatafailOnError != null)
                    {
                        inputPdfData["fail_on_error"] = ExpressionConverter.ConvertO(__workflow_inputPdfDatafailOnError);
                        inputPdfDatapropCount++;
                    }

                    inputPdfDatapropCount++;
                }
                else
                {
                    inputPdfData["fail_on_error"] = true;
                    inputPdfDatapropCount++;
                }

                if (inputPdfDatapropCount > 0)
                {
                    callPayload.Body = inputPdfData;
                }

                return new ApiConnectionAction<OperationResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientextractfromp")]
        public IBodyWorkflowAction<OcrOperationResponse> OcrText(Expression<Func<string>> inputDatasourceFileName, Expression<Func<string>> inputDatasourceFileContent, Expression<Func<inputDatalanguageInput>> inputDatalanguage = null, Expression<Func<string>> inputDataxCoordinate = null, Expression<Func<string>> inputDatayCoordinate = null, Expression<Func<string>> inputDatawidth = null, Expression<Func<string>> inputDataheight = null, Expression<Func<string>> inputDatapageNumber = null, Expression<Func<inputDataperformanceInput>> inputDataperformance = null, Expression<Func<inputDatablacklistWhitelistInput>> inputDatablacklistWhitelist = null, Expression<Func<string>> inputDatacharacters = null, Expression<Func<bool>> inputDatausePagination = null, Expression<Func<bool>> inputDatafailOnError = null)
        {
            var __workflow_inputDatasourceFileName = WorkflowExpression.Compile(inputDatasourceFileName, nameof(inputDatasourceFileName), required: true);
            var __workflow_inputDatasourceFileContent = WorkflowExpression.Compile(inputDatasourceFileContent, nameof(inputDatasourceFileContent), required: true);
            var __workflow_inputDatalanguage = WorkflowExpression.Compile(inputDatalanguage, nameof(inputDatalanguage), required: false);
            var __workflow_inputDataxCoordinate = WorkflowExpression.Compile(inputDataxCoordinate, nameof(inputDataxCoordinate), required: false);
            var __workflow_inputDatayCoordinate = WorkflowExpression.Compile(inputDatayCoordinate, nameof(inputDatayCoordinate), required: false);
            var __workflow_inputDatawidth = WorkflowExpression.Compile(inputDatawidth, nameof(inputDatawidth), required: false);
            var __workflow_inputDataheight = WorkflowExpression.Compile(inputDataheight, nameof(inputDataheight), required: false);
            var __workflow_inputDatapageNumber = WorkflowExpression.Compile(inputDatapageNumber, nameof(inputDatapageNumber), required: false);
            var __workflow_inputDataperformance = WorkflowExpression.Compile(inputDataperformance, nameof(inputDataperformance), required: false);
            var __workflow_inputDatablacklistWhitelist = WorkflowExpression.Compile(inputDatablacklistWhitelist, nameof(inputDatablacklistWhitelist), required: false);
            var __workflow_inputDatacharacters = WorkflowExpression.Compile(inputDatacharacters, nameof(inputDatacharacters), required: false);
            var __workflow_inputDatausePagination = WorkflowExpression.Compile(inputDatausePagination, nameof(inputDatausePagination), required: false);
            var __workflow_inputDatafailOnError = WorkflowExpression.Compile(inputDatafailOnError, nameof(inputDatafailOnError), required: false);
            return new DeferredBodyAction<OcrOperationResponse>(() =>
            {
                var apiCallPath = "/v1/operations/ocr_text";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputData = new JObject();
                var inputDatapropCount = 0;
                inputData["use_async_pattern"] = false;
                inputDatapropCount++;
                inputDatapropCount++;
                inputData["source_file_name"] = ExpressionConverter.ConvertO(__workflow_inputDatasourceFileName);
                inputDatapropCount++;
                inputData["source_file_content"] = ExpressionConverter.ConvertO(__workflow_inputDatasourceFileContent);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputData["sharepoint_file"] = sharepointFileObject;
                    inputDatapropCount++;
                }

                if (__workflow_inputDatalanguage != null)
                {
                    if (__workflow_inputDatalanguage != null)
                    {
                        inputData["language"] = ExpressionConverter.ConvertO(__workflow_inputDatalanguage);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["language"] = "English";
                    inputDatapropCount++;
                }

                if (__workflow_inputDataxCoordinate != null)
                {
                    inputData["x"] = ExpressionConverter.ConvertO(__workflow_inputDataxCoordinate);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatayCoordinate != null)
                {
                    inputData["y"] = ExpressionConverter.ConvertO(__workflow_inputDatayCoordinate);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatawidth != null)
                {
                    inputData["width"] = ExpressionConverter.ConvertO(__workflow_inputDatawidth);
                    inputDatapropCount++;
                }

                if (__workflow_inputDataheight != null)
                {
                    inputData["height"] = ExpressionConverter.ConvertO(__workflow_inputDataheight);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatapageNumber != null)
                {
                    if (__workflow_inputDatapageNumber != null)
                    {
                        inputData["page_number"] = ExpressionConverter.ConvertO(__workflow_inputDatapageNumber);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["page_number"] = "";
                    inputDatapropCount++;
                }

                if (__workflow_inputDataperformance != null)
                {
                    if (__workflow_inputDataperformance != null)
                    {
                        inputData["performance"] = ExpressionConverter.ConvertO(__workflow_inputDataperformance);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["performance"] = "Slow but accurate";
                    inputDatapropCount++;
                }

                if (__workflow_inputDatablacklistWhitelist != null)
                {
                    if (__workflow_inputDatablacklistWhitelist != null)
                    {
                        inputData["characters_option"] = ExpressionConverter.ConvertO(__workflow_inputDatablacklistWhitelist);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["characters_option"] = "None";
                    inputDatapropCount++;
                }

                if (__workflow_inputDatacharacters != null)
                {
                    inputData["characters"] = ExpressionConverter.ConvertO(__workflow_inputDatacharacters);
                    inputDatapropCount++;
                }

                if (__workflow_inputDatausePagination != null)
                {
                    if (__workflow_inputDatausePagination != null)
                    {
                        inputData["paginate"] = ExpressionConverter.ConvertO(__workflow_inputDatausePagination);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["paginate"] = false;
                    inputDatapropCount++;
                }

                if (__workflow_inputDatafailOnError != null)
                {
                    if (__workflow_inputDatafailOnError != null)
                    {
                        inputData["fail_on_error"] = ExpressionConverter.ConvertO(__workflow_inputDatafailOnError);
                        inputDatapropCount++;
                    }

                    inputDatapropCount++;
                }
                else
                {
                    inputData["fail_on_error"] = true;
                    inputDatapropCount++;
                }

                if (inputDatapropCount > 0)
                {
                    callPayload.Body = inputData;
                }

                return new ApiConnectionAction<OcrOperationResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputPdfDatadPIInput
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
    public enum inputPdfDatakVPOutputFormatInput
    {
        [EnumMember(Value = "json")]
        Json,
        [EnumMember(Value = "csv")]
        Csv,
        [EnumMember(Value = "xml")]
        Xml
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputPdfDataautorotateInput
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputPdfDatatrimSymbolsInput
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputPdfDataincludeKeyBoundingBoxInput
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputPdfDataincludeValueBoundingBoxInput
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputPdfDataincludePageNumberInput
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputPdfDataincludeConfidenceInput
    {
        Default,
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputPdfDataincludeTypeInput
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputDatalanguageInput
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
    public enum inputDataperformanceInput
    {
        [EnumMember(Value = "Slow but accurate")]
        SlowButAccurate,
        [EnumMember(Value = "Faster and less accurate")]
        FasterAndLessAccurate,
        [EnumMember(Value = "Fastest and least accurate")]
        FastestAndLeastAccurate
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputDatablacklistWhitelistInput
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
