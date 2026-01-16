//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientextractfromp
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NutrientextractfrompActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientextractfromp")]
        public IBodyWorkflowAction<OperationResponse> ExtractText(Expression<Func<string>> inputPdfDatasourceFileName, Expression<Func<string>> inputPdfDatasourceFileContent, Expression<Func<string>> inputPdfDatapageRange = null, Expression<Func<bool>> inputPdfDatafailOnError = null)
        {
            var apiCallPath = "/v1/operations/extract_text";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var inputPdfData = new JObject();
            var inputPdfDatapropCount = 0;
            inputPdfData["use_async_pattern"] = false;
            inputPdfDatapropCount++;
            inputPdfDatapropCount++;
            inputPdfData["source_file_name"] = ExpressionConverter.ConvertO(inputPdfDatasourceFileName);
            var sharepoint_fileObject = new JObject();
            var sharepoint_fileObjectpropCount = 0;
            if (sharepoint_fileObjectpropCount > 0)
            {
                inputPdfData["sharepoint_file"] = sharepoint_fileObject;
                inputPdfDatapropCount++;
            }

            inputPdfDatapropCount++;
            inputPdfData["source_file_content"] = ExpressionConverter.ConvertO(inputPdfDatasourceFileContent);
            if (inputPdfDatapageRange != null)
            {
                inputPdfData["page_range"] = ExpressionConverter.ConvertO(inputPdfDatapageRange);
                inputPdfDatapropCount++;
            }

            if (inputPdfDatafailOnError != null)
            {
                inputPdfData["fail_on_error"] = ExpressionConverter.ConvertO(inputPdfDatafailOnError);
                inputPdfDatapropCount++;
            }

            if (inputPdfDatapropCount > 0)
            {
                callPayload.Body = inputPdfData;
            }

            return new ApiConnectionAction<OperationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientextractfromp")]
        public IBodyWorkflowAction<OperationResponse> ExtractKeyValuePairs(Expression<Func<string>> inputPdfDatasourceFileName, Expression<Func<string>> inputPdfDatasourceFileContent, Expression<Func<string>> inputPdfDataoCRLanguage = null, Expression<Func<inputPdfDatadPIInput>> inputPdfDatadPI = null, Expression<Func<inputPdfDatakVPOutputFormatInput>> inputPdfDatakVPOutputFormat = null, Expression<Func<string>> inputPdfDatapageRange = null, Expression<Func<inputPdfDataautorotateInput>> inputPdfDataautorotate = null, Expression<Func<inputPdfDatatrimSymbolsInput>> inputPdfDatatrimSymbols = null, Expression<Func<inputPdfDataincludeKeyBoundingBoxInput>> inputPdfDataincludeKeyBoundingBox = null, Expression<Func<inputPdfDataincludeValueBoundingBoxInput>> inputPdfDataincludeValueBoundingBox = null, Expression<Func<inputPdfDataincludePageNumberInput>> inputPdfDataincludePageNumber = null, Expression<Func<inputPdfDataincludeConfidenceInput>> inputPdfDataincludeConfidence = null, Expression<Func<int>> inputPdfDataconfidenceThreshold = null, Expression<Func<inputPdfDataincludeTypeInput>> inputPdfDataincludeType = null, Expression<Func<string>> inputPdfDataexpectedKeys = null, Expression<Func<bool>> inputPdfDatafailOnError = null)
        {
            var apiCallPath = "/v1/operations/key_value_pairs";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var inputPdfData = new JObject();
            var inputPdfDatapropCount = 0;
            inputPdfData["use_async_pattern"] = false;
            inputPdfDatapropCount++;
            inputPdfDatapropCount++;
            inputPdfData["source_file_name"] = ExpressionConverter.ConvertO(inputPdfDatasourceFileName);
            var sharepoint_fileObject = new JObject();
            var sharepoint_fileObjectpropCount = 0;
            if (sharepoint_fileObjectpropCount > 0)
            {
                inputPdfData["sharepoint_file"] = sharepoint_fileObject;
                inputPdfDatapropCount++;
            }

            inputPdfDatapropCount++;
            inputPdfData["source_file_content"] = ExpressionConverter.ConvertO(inputPdfDatasourceFileContent);
            if (inputPdfDataoCRLanguage != null)
            {
                inputPdfData["ocr_language"] = ExpressionConverter.ConvertO(inputPdfDataoCRLanguage);
                inputPdfDatapropCount++;
            }

            if (inputPdfDatadPI != null)
            {
                inputPdfData["dpi"] = ExpressionConverter.ConvertO(inputPdfDatadPI);
                inputPdfDatapropCount++;
            }

            if (inputPdfDatakVPOutputFormat != null)
            {
                inputPdfData["kvp_format"] = ExpressionConverter.ConvertO(inputPdfDatakVPOutputFormat);
                inputPdfDatapropCount++;
            }

            if (inputPdfDatapageRange != null)
            {
                inputPdfData["page_range"] = ExpressionConverter.ConvertO(inputPdfDatapageRange);
                inputPdfDatapropCount++;
            }

            if (inputPdfDataautorotate != null)
            {
                inputPdfData["autorotate"] = ExpressionConverter.ConvertO(inputPdfDataautorotate);
                inputPdfDatapropCount++;
            }

            if (inputPdfDatatrimSymbols != null)
            {
                inputPdfData["trim_symbols"] = ExpressionConverter.ConvertO(inputPdfDatatrimSymbols);
                inputPdfDatapropCount++;
            }

            if (inputPdfDataincludeKeyBoundingBox != null)
            {
                inputPdfData["include_key_bounding_box"] = ExpressionConverter.ConvertO(inputPdfDataincludeKeyBoundingBox);
                inputPdfDatapropCount++;
            }

            if (inputPdfDataincludeValueBoundingBox != null)
            {
                inputPdfData["include_value_bounding_box"] = ExpressionConverter.ConvertO(inputPdfDataincludeValueBoundingBox);
                inputPdfDatapropCount++;
            }

            if (inputPdfDataincludePageNumber != null)
            {
                inputPdfData["include_page_number"] = ExpressionConverter.ConvertO(inputPdfDataincludePageNumber);
                inputPdfDatapropCount++;
            }

            if (inputPdfDataincludeConfidence != null)
            {
                inputPdfData["include_confidence"] = ExpressionConverter.ConvertO(inputPdfDataincludeConfidence);
                inputPdfDatapropCount++;
            }

            if (inputPdfDataconfidenceThreshold != null)
            {
                inputPdfData["confidence_threshold"] = ExpressionConverter.ConvertO(inputPdfDataconfidenceThreshold);
                inputPdfDatapropCount++;
            }

            if (inputPdfDataincludeType != null)
            {
                inputPdfData["include_type"] = ExpressionConverter.ConvertO(inputPdfDataincludeType);
                inputPdfDatapropCount++;
            }

            if (inputPdfDataexpectedKeys != null)
            {
                inputPdfData["expected_keys"] = ExpressionConverter.ConvertO(inputPdfDataexpectedKeys);
                inputPdfDatapropCount++;
            }

            if (inputPdfDatafailOnError != null)
            {
                inputPdfData["fail_on_error"] = ExpressionConverter.ConvertO(inputPdfDatafailOnError);
                inputPdfDatapropCount++;
            }

            if (inputPdfDatapropCount > 0)
            {
                callPayload.Body = inputPdfData;
            }

            return new ApiConnectionAction<OperationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientextractfromp")]
        public IBodyWorkflowAction<OcrOperationResponse> OcrText(Expression<Func<string>> inputDatasourceFileName, Expression<Func<string>> inputDatasourceFileContent, Expression<Func<inputDatalanguageInput>> inputDatalanguage = null, Expression<Func<string>> inputDataxCoordinate = null, Expression<Func<string>> inputDatayCoordinate = null, Expression<Func<string>> inputDatawidth = null, Expression<Func<string>> inputDataheight = null, Expression<Func<string>> inputDatapageNumber = null, Expression<Func<inputDataperformanceInput>> inputDataperformance = null, Expression<Func<inputDatablacklistWhitelistInput>> inputDatablacklistWhitelist = null, Expression<Func<string>> inputDatacharacters = null, Expression<Func<bool>> inputDatausePagination = null, Expression<Func<bool>> inputDatafailOnError = null)
        {
            var apiCallPath = "/v1/operations/ocr_text";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var inputData = new JObject();
            var inputDatapropCount = 0;
            inputData["use_async_pattern"] = false;
            inputDatapropCount++;
            inputDatapropCount++;
            inputData["source_file_name"] = ExpressionConverter.ConvertO(inputDatasourceFileName);
            inputDatapropCount++;
            inputData["source_file_content"] = ExpressionConverter.ConvertO(inputDatasourceFileContent);
            var sharepoint_fileObject = new JObject();
            var sharepoint_fileObjectpropCount = 0;
            if (sharepoint_fileObjectpropCount > 0)
            {
                inputData["sharepoint_file"] = sharepoint_fileObject;
                inputDatapropCount++;
            }

            if (inputDatalanguage != null)
            {
                inputData["language"] = ExpressionConverter.ConvertO(inputDatalanguage);
                inputDatapropCount++;
            }

            if (inputDataxCoordinate != null)
            {
                inputData["x"] = ExpressionConverter.ConvertO(inputDataxCoordinate);
                inputDatapropCount++;
            }

            if (inputDatayCoordinate != null)
            {
                inputData["y"] = ExpressionConverter.ConvertO(inputDatayCoordinate);
                inputDatapropCount++;
            }

            if (inputDatawidth != null)
            {
                inputData["width"] = ExpressionConverter.ConvertO(inputDatawidth);
                inputDatapropCount++;
            }

            if (inputDataheight != null)
            {
                inputData["height"] = ExpressionConverter.ConvertO(inputDataheight);
                inputDatapropCount++;
            }

            if (inputDatapageNumber != null)
            {
                inputData["page_number"] = ExpressionConverter.ConvertO(inputDatapageNumber);
                inputDatapropCount++;
            }

            if (inputDataperformance != null)
            {
                inputData["performance"] = ExpressionConverter.ConvertO(inputDataperformance);
                inputDatapropCount++;
            }

            if (inputDatablacklistWhitelist != null)
            {
                inputData["characters_option"] = ExpressionConverter.ConvertO(inputDatablacklistWhitelist);
                inputDatapropCount++;
            }

            if (inputDatacharacters != null)
            {
                inputData["characters"] = ExpressionConverter.ConvertO(inputDatacharacters);
                inputDatapropCount++;
            }

            if (inputDatausePagination != null)
            {
                inputData["paginate"] = ExpressionConverter.ConvertO(inputDatausePagination);
                inputDatapropCount++;
            }

            if (inputDatafailOnError != null)
            {
                inputData["fail_on_error"] = ExpressionConverter.ConvertO(inputDatafailOnError);
                inputDatapropCount++;
            }

            if (inputDatapropCount > 0)
            {
                callPayload.Body = inputData;
            }

            return new ApiConnectionAction<OcrOperationResponse>(callPayload);
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

    public enum inputPdfDatakVPOutputFormatInput
    {
        [EnumMember(Value = "json")]
        Json,
        [EnumMember(Value = "csv")]
        Csv,
        [EnumMember(Value = "xml")]
        Xml
    }

    public enum inputPdfDataautorotateInput
    {
        Default,
        Yes,
        No
    }

    public enum inputPdfDatatrimSymbolsInput
    {
        Default,
        Yes,
        No
    }

    public enum inputPdfDataincludeKeyBoundingBoxInput
    {
        Default,
        Yes,
        No
    }

    public enum inputPdfDataincludeValueBoundingBoxInput
    {
        Default,
        Yes,
        No
    }

    public enum inputPdfDataincludePageNumberInput
    {
        Default,
        Yes,
        No
    }

    public enum inputPdfDataincludeConfidenceInput
    {
        Default,
        Yes,
        No
    }

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

    public enum inputDataperformanceInput
    {
        [EnumMember(Value = "Slow but accurate")]
        SlowButAccurate,
        [EnumMember(Value = "Faster and less accurate")]
        FasterAndLessAccurate,
        [EnumMember(Value = "Fastest and least accurate")]
        FastestAndLeastAccurate
    }

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