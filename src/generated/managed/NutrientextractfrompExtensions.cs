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
            inputPdfData["source_file_name"] = CSharpExpressionConverter.ConvertToken(inputPdfDatasourceFileName);
            var sharepointFileObject = new JObject();
            var sharepointFileObjectpropCount = 0;
            if (sharepointFileObjectpropCount > 0)
            {
                inputPdfData["sharepoint_file"] = sharepointFileObject;
                inputPdfDatapropCount++;
            }

            inputPdfDatapropCount++;
            inputPdfData["source_file_content"] = CSharpExpressionConverter.ConvertToken(inputPdfDatasourceFileContent);
            if (inputPdfDatapageRange != null)
            {
                if (inputPdfDatapageRange != null)
                {
                    inputPdfData["page_range"] = CSharpExpressionConverter.ConvertToken(inputPdfDatapageRange);
                    inputPdfDatapropCount++;
                }

                inputPdfDatapropCount++;
            }
            else
            {
                inputPdfData["page_range"] = "*";
                inputPdfDatapropCount++;
            }

            if (inputPdfDatafailOnError != null)
            {
                if (inputPdfDatafailOnError != null)
                {
                    inputPdfData["fail_on_error"] = CSharpExpressionConverter.ConvertToken(inputPdfDatafailOnError);
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
            inputPdfData["source_file_name"] = CSharpExpressionConverter.ConvertToken(inputPdfDatasourceFileName);
            var sharepointFileObject = new JObject();
            var sharepointFileObjectpropCount = 0;
            if (sharepointFileObjectpropCount > 0)
            {
                inputPdfData["sharepoint_file"] = sharepointFileObject;
                inputPdfDatapropCount++;
            }

            inputPdfDatapropCount++;
            inputPdfData["source_file_content"] = CSharpExpressionConverter.ConvertToken(inputPdfDatasourceFileContent);
            if (inputPdfDataoCRLanguage != null)
            {
                if (inputPdfDataoCRLanguage != null)
                {
                    inputPdfData["ocr_language"] = CSharpExpressionConverter.ConvertToken(inputPdfDataoCRLanguage);
                    inputPdfDatapropCount++;
                }

                inputPdfDatapropCount++;
            }
            else
            {
                inputPdfData["ocr_language"] = "eng";
                inputPdfDatapropCount++;
            }

            if (inputPdfDatadPI != null)
            {
                if (inputPdfDatadPI != null)
                {
                    inputPdfData["dpi"] = CSharpExpressionConverter.Convert(inputPdfDatadPI);
                    inputPdfDatapropCount++;
                }

                inputPdfDatapropCount++;
            }
            else
            {
                inputPdfData["dpi"] = "300";
                inputPdfDatapropCount++;
            }

            if (inputPdfDatakVPOutputFormat != null)
            {
                if (inputPdfDatakVPOutputFormat != null)
                {
                    inputPdfData["kvp_format"] = CSharpExpressionConverter.Convert(inputPdfDatakVPOutputFormat);
                    inputPdfDatapropCount++;
                }

                inputPdfDatapropCount++;
            }
            else
            {
                inputPdfData["kvp_format"] = "json";
                inputPdfDatapropCount++;
            }

            if (inputPdfDatapageRange != null)
            {
                if (inputPdfDatapageRange != null)
                {
                    inputPdfData["page_range"] = CSharpExpressionConverter.ConvertToken(inputPdfDatapageRange);
                    inputPdfDatapropCount++;
                }

                inputPdfDatapropCount++;
            }
            else
            {
                inputPdfData["page_range"] = "*";
                inputPdfDatapropCount++;
            }

            if (inputPdfDataautorotate != null)
            {
                if (inputPdfDataautorotate != null)
                {
                    inputPdfData["autorotate"] = CSharpExpressionConverter.Convert(inputPdfDataautorotate);
                    inputPdfDatapropCount++;
                }

                inputPdfDatapropCount++;
            }
            else
            {
                inputPdfData["autorotate"] = "Default";
                inputPdfDatapropCount++;
            }

            if (inputPdfDatatrimSymbols != null)
            {
                if (inputPdfDatatrimSymbols != null)
                {
                    inputPdfData["trim_symbols"] = CSharpExpressionConverter.Convert(inputPdfDatatrimSymbols);
                    inputPdfDatapropCount++;
                }

                inputPdfDatapropCount++;
            }
            else
            {
                inputPdfData["trim_symbols"] = "Default";
                inputPdfDatapropCount++;
            }

            if (inputPdfDataincludeKeyBoundingBox != null)
            {
                if (inputPdfDataincludeKeyBoundingBox != null)
                {
                    inputPdfData["include_key_bounding_box"] = CSharpExpressionConverter.Convert(inputPdfDataincludeKeyBoundingBox);
                    inputPdfDatapropCount++;
                }

                inputPdfDatapropCount++;
            }
            else
            {
                inputPdfData["include_key_bounding_box"] = "Default";
                inputPdfDatapropCount++;
            }

            if (inputPdfDataincludeValueBoundingBox != null)
            {
                if (inputPdfDataincludeValueBoundingBox != null)
                {
                    inputPdfData["include_value_bounding_box"] = CSharpExpressionConverter.Convert(inputPdfDataincludeValueBoundingBox);
                    inputPdfDatapropCount++;
                }

                inputPdfDatapropCount++;
            }
            else
            {
                inputPdfData["include_value_bounding_box"] = "Default";
                inputPdfDatapropCount++;
            }

            if (inputPdfDataincludePageNumber != null)
            {
                if (inputPdfDataincludePageNumber != null)
                {
                    inputPdfData["include_page_number"] = CSharpExpressionConverter.Convert(inputPdfDataincludePageNumber);
                    inputPdfDatapropCount++;
                }

                inputPdfDatapropCount++;
            }
            else
            {
                inputPdfData["include_page_number"] = "Default";
                inputPdfDatapropCount++;
            }

            if (inputPdfDataincludeConfidence != null)
            {
                if (inputPdfDataincludeConfidence != null)
                {
                    inputPdfData["include_confidence"] = CSharpExpressionConverter.Convert(inputPdfDataincludeConfidence);
                    inputPdfDatapropCount++;
                }

                inputPdfDatapropCount++;
            }
            else
            {
                inputPdfData["include_confidence"] = "Default";
                inputPdfDatapropCount++;
            }

            if (inputPdfDataconfidenceThreshold != null)
            {
                if (inputPdfDataconfidenceThreshold != null)
                {
                    inputPdfData["confidence_threshold"] = CSharpExpressionConverter.ConvertToken(inputPdfDataconfidenceThreshold);
                    inputPdfDatapropCount++;
                }

                inputPdfDatapropCount++;
            }
            else
            {
                inputPdfData["confidence_threshold"] = 50;
                inputPdfDatapropCount++;
            }

            if (inputPdfDataincludeType != null)
            {
                if (inputPdfDataincludeType != null)
                {
                    inputPdfData["include_type"] = CSharpExpressionConverter.Convert(inputPdfDataincludeType);
                    inputPdfDatapropCount++;
                }

                inputPdfDatapropCount++;
            }
            else
            {
                inputPdfData["include_type"] = "Default";
                inputPdfDatapropCount++;
            }

            if (inputPdfDataexpectedKeys != null)
            {
                inputPdfData["expected_keys"] = CSharpExpressionConverter.ConvertToken(inputPdfDataexpectedKeys);
                inputPdfDatapropCount++;
            }

            if (inputPdfDatafailOnError != null)
            {
                if (inputPdfDatafailOnError != null)
                {
                    inputPdfData["fail_on_error"] = CSharpExpressionConverter.ConvertToken(inputPdfDatafailOnError);
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
            inputData["source_file_name"] = CSharpExpressionConverter.ConvertToken(inputDatasourceFileName);
            inputDatapropCount++;
            inputData["source_file_content"] = CSharpExpressionConverter.ConvertToken(inputDatasourceFileContent);
            var sharepointFileObject = new JObject();
            var sharepointFileObjectpropCount = 0;
            if (sharepointFileObjectpropCount > 0)
            {
                inputData["sharepoint_file"] = sharepointFileObject;
                inputDatapropCount++;
            }

            if (inputDatalanguage != null)
            {
                if (inputDatalanguage != null)
                {
                    inputData["language"] = CSharpExpressionConverter.Convert(inputDatalanguage);
                    inputDatapropCount++;
                }

                inputDatapropCount++;
            }
            else
            {
                inputData["language"] = "English";
                inputDatapropCount++;
            }

            if (inputDataxCoordinate != null)
            {
                inputData["x"] = CSharpExpressionConverter.ConvertToken(inputDataxCoordinate);
                inputDatapropCount++;
            }

            if (inputDatayCoordinate != null)
            {
                inputData["y"] = CSharpExpressionConverter.ConvertToken(inputDatayCoordinate);
                inputDatapropCount++;
            }

            if (inputDatawidth != null)
            {
                inputData["width"] = CSharpExpressionConverter.ConvertToken(inputDatawidth);
                inputDatapropCount++;
            }

            if (inputDataheight != null)
            {
                inputData["height"] = CSharpExpressionConverter.ConvertToken(inputDataheight);
                inputDatapropCount++;
            }

            if (inputDatapageNumber != null)
            {
                if (inputDatapageNumber != null)
                {
                    inputData["page_number"] = CSharpExpressionConverter.ConvertToken(inputDatapageNumber);
                    inputDatapropCount++;
                }

                inputDatapropCount++;
            }
            else
            {
                inputData["page_number"] = "";
                inputDatapropCount++;
            }

            if (inputDataperformance != null)
            {
                if (inputDataperformance != null)
                {
                    inputData["performance"] = CSharpExpressionConverter.Convert(inputDataperformance);
                    inputDatapropCount++;
                }

                inputDatapropCount++;
            }
            else
            {
                inputData["performance"] = "Slow but accurate";
                inputDatapropCount++;
            }

            if (inputDatablacklistWhitelist != null)
            {
                if (inputDatablacklistWhitelist != null)
                {
                    inputData["characters_option"] = CSharpExpressionConverter.Convert(inputDatablacklistWhitelist);
                    inputDatapropCount++;
                }

                inputDatapropCount++;
            }
            else
            {
                inputData["characters_option"] = "None";
                inputDatapropCount++;
            }

            if (inputDatacharacters != null)
            {
                inputData["characters"] = CSharpExpressionConverter.ConvertToken(inputDatacharacters);
                inputDatapropCount++;
            }

            if (inputDatausePagination != null)
            {
                if (inputDatausePagination != null)
                {
                    inputData["paginate"] = CSharpExpressionConverter.ConvertToken(inputDatausePagination);
                    inputDatapropCount++;
                }

                inputDatapropCount++;
            }
            else
            {
                inputData["paginate"] = false;
                inputDatapropCount++;
            }

            if (inputDatafailOnError != null)
            {
                if (inputDatafailOnError != null)
                {
                    inputData["fail_on_error"] = CSharpExpressionConverter.ConvertToken(inputDatafailOnError);
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