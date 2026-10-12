//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientextractfromp
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NutrientextractfrompActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientextractfromp")]
        [WorkflowExpressionFactory(nameof(__BuildExtractText))]
        public IBodyWorkflowAction<OperationResponse> ExtractText([WorkflowExpression] Func<string> inputPdfDatasourceFileName, [WorkflowExpression] Func<string> inputPdfDatasourceFileContent, [WorkflowExpression] Func<string> inputPdfDatapageRange = null, [WorkflowExpression] Func<bool> inputPdfDatafailOnError = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OperationResponse> __BuildExtractText(WorkflowExpression<string> inputPdfDatasourceFileName, WorkflowExpression<string> inputPdfDatasourceFileContent, WorkflowExpression<string> inputPdfDatapageRange = null, WorkflowExpression<bool> inputPdfDatafailOnError = null)
        {
            WorkflowExpression.Validate(inputPdfDatasourceFileName, nameof(inputPdfDatasourceFileName), required: true);
            WorkflowExpression.Validate(inputPdfDatasourceFileContent, nameof(inputPdfDatasourceFileContent), required: true);
            WorkflowExpression.Validate(inputPdfDatapageRange, nameof(inputPdfDatapageRange), required: false);
            WorkflowExpression.Validate(inputPdfDatafailOnError, nameof(inputPdfDatafailOnError), required: false);
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
                inputPdfData["source_file_name"] = ExpressionConverter.ConvertO(inputPdfDatasourceFileName);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputPdfData["sharepoint_file"] = sharepointFileObject;
                    inputPdfDatapropCount++;
                }

                inputPdfDatapropCount++;
                inputPdfData["source_file_content"] = ExpressionConverter.ConvertO(inputPdfDatasourceFileContent);
                if (inputPdfDatapageRange != null)
                {
                    if (inputPdfDatapageRange != null)
                    {
                        inputPdfData["page_range"] = ExpressionConverter.ConvertO(inputPdfDatapageRange);
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
                        inputPdfData["fail_on_error"] = ExpressionConverter.ConvertO(inputPdfDatafailOnError);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientextractfromp")]
        [WorkflowExpressionFactory(nameof(__BuildExtractKeyValuePairs))]
        public IBodyWorkflowAction<OperationResponse> ExtractKeyValuePairs([WorkflowExpression] Func<string> inputPdfDatasourceFileName, [WorkflowExpression] Func<string> inputPdfDatasourceFileContent, [WorkflowExpression] Func<string> inputPdfDataoCRLanguage = null, [WorkflowExpression] Func<inputPdfDatadPIInput> inputPdfDatadPI = null, [WorkflowExpression] Func<inputPdfDatakVPOutputFormatInput> inputPdfDatakVPOutputFormat = null, [WorkflowExpression] Func<string> inputPdfDatapageRange = null, [WorkflowExpression] Func<inputPdfDataautorotateInput> inputPdfDataautorotate = null, [WorkflowExpression] Func<inputPdfDatatrimSymbolsInput> inputPdfDatatrimSymbols = null, [WorkflowExpression] Func<inputPdfDataincludeKeyBoundingBoxInput> inputPdfDataincludeKeyBoundingBox = null, [WorkflowExpression] Func<inputPdfDataincludeValueBoundingBoxInput> inputPdfDataincludeValueBoundingBox = null, [WorkflowExpression] Func<inputPdfDataincludePageNumberInput> inputPdfDataincludePageNumber = null, [WorkflowExpression] Func<inputPdfDataincludeConfidenceInput> inputPdfDataincludeConfidence = null, [WorkflowExpression] Func<int> inputPdfDataconfidenceThreshold = null, [WorkflowExpression] Func<inputPdfDataincludeTypeInput> inputPdfDataincludeType = null, [WorkflowExpression] Func<string> inputPdfDataexpectedKeys = null, [WorkflowExpression] Func<bool> inputPdfDatafailOnError = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OperationResponse> __BuildExtractKeyValuePairs(WorkflowExpression<string> inputPdfDatasourceFileName, WorkflowExpression<string> inputPdfDatasourceFileContent, WorkflowExpression<string> inputPdfDataoCRLanguage = null, WorkflowExpression<inputPdfDatadPIInput> inputPdfDatadPI = null, WorkflowExpression<inputPdfDatakVPOutputFormatInput> inputPdfDatakVPOutputFormat = null, WorkflowExpression<string> inputPdfDatapageRange = null, WorkflowExpression<inputPdfDataautorotateInput> inputPdfDataautorotate = null, WorkflowExpression<inputPdfDatatrimSymbolsInput> inputPdfDatatrimSymbols = null, WorkflowExpression<inputPdfDataincludeKeyBoundingBoxInput> inputPdfDataincludeKeyBoundingBox = null, WorkflowExpression<inputPdfDataincludeValueBoundingBoxInput> inputPdfDataincludeValueBoundingBox = null, WorkflowExpression<inputPdfDataincludePageNumberInput> inputPdfDataincludePageNumber = null, WorkflowExpression<inputPdfDataincludeConfidenceInput> inputPdfDataincludeConfidence = null, WorkflowExpression<int> inputPdfDataconfidenceThreshold = null, WorkflowExpression<inputPdfDataincludeTypeInput> inputPdfDataincludeType = null, WorkflowExpression<string> inputPdfDataexpectedKeys = null, WorkflowExpression<bool> inputPdfDatafailOnError = null)
        {
            WorkflowExpression.Validate(inputPdfDatasourceFileName, nameof(inputPdfDatasourceFileName), required: true);
            WorkflowExpression.Validate(inputPdfDatasourceFileContent, nameof(inputPdfDatasourceFileContent), required: true);
            WorkflowExpression.Validate(inputPdfDataoCRLanguage, nameof(inputPdfDataoCRLanguage), required: false);
            WorkflowExpression.Validate(inputPdfDatadPI, nameof(inputPdfDatadPI), required: false);
            WorkflowExpression.Validate(inputPdfDatakVPOutputFormat, nameof(inputPdfDatakVPOutputFormat), required: false);
            WorkflowExpression.Validate(inputPdfDatapageRange, nameof(inputPdfDatapageRange), required: false);
            WorkflowExpression.Validate(inputPdfDataautorotate, nameof(inputPdfDataautorotate), required: false);
            WorkflowExpression.Validate(inputPdfDatatrimSymbols, nameof(inputPdfDatatrimSymbols), required: false);
            WorkflowExpression.Validate(inputPdfDataincludeKeyBoundingBox, nameof(inputPdfDataincludeKeyBoundingBox), required: false);
            WorkflowExpression.Validate(inputPdfDataincludeValueBoundingBox, nameof(inputPdfDataincludeValueBoundingBox), required: false);
            WorkflowExpression.Validate(inputPdfDataincludePageNumber, nameof(inputPdfDataincludePageNumber), required: false);
            WorkflowExpression.Validate(inputPdfDataincludeConfidence, nameof(inputPdfDataincludeConfidence), required: false);
            WorkflowExpression.Validate(inputPdfDataconfidenceThreshold, nameof(inputPdfDataconfidenceThreshold), required: false);
            WorkflowExpression.Validate(inputPdfDataincludeType, nameof(inputPdfDataincludeType), required: false);
            WorkflowExpression.Validate(inputPdfDataexpectedKeys, nameof(inputPdfDataexpectedKeys), required: false);
            WorkflowExpression.Validate(inputPdfDatafailOnError, nameof(inputPdfDatafailOnError), required: false);
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
                inputPdfData["source_file_name"] = ExpressionConverter.ConvertO(inputPdfDatasourceFileName);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputPdfData["sharepoint_file"] = sharepointFileObject;
                    inputPdfDatapropCount++;
                }

                inputPdfDatapropCount++;
                inputPdfData["source_file_content"] = ExpressionConverter.ConvertO(inputPdfDatasourceFileContent);
                if (inputPdfDataoCRLanguage != null)
                {
                    if (inputPdfDataoCRLanguage != null)
                    {
                        inputPdfData["ocr_language"] = ExpressionConverter.ConvertO(inputPdfDataoCRLanguage);
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
                        inputPdfData["dpi"] = ExpressionConverter.ConvertO(inputPdfDatadPI);
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
                        inputPdfData["kvp_format"] = ExpressionConverter.ConvertO(inputPdfDatakVPOutputFormat);
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
                        inputPdfData["page_range"] = ExpressionConverter.ConvertO(inputPdfDatapageRange);
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
                        inputPdfData["autorotate"] = ExpressionConverter.ConvertO(inputPdfDataautorotate);
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
                        inputPdfData["trim_symbols"] = ExpressionConverter.ConvertO(inputPdfDatatrimSymbols);
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
                        inputPdfData["include_key_bounding_box"] = ExpressionConverter.ConvertO(inputPdfDataincludeKeyBoundingBox);
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
                        inputPdfData["include_value_bounding_box"] = ExpressionConverter.ConvertO(inputPdfDataincludeValueBoundingBox);
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
                        inputPdfData["include_page_number"] = ExpressionConverter.ConvertO(inputPdfDataincludePageNumber);
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
                        inputPdfData["include_confidence"] = ExpressionConverter.ConvertO(inputPdfDataincludeConfidence);
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
                        inputPdfData["confidence_threshold"] = ExpressionConverter.ConvertO(inputPdfDataconfidenceThreshold);
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
                        inputPdfData["include_type"] = ExpressionConverter.ConvertO(inputPdfDataincludeType);
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
                    inputPdfData["expected_keys"] = ExpressionConverter.ConvertO(inputPdfDataexpectedKeys);
                    inputPdfDatapropCount++;
                }

                if (inputPdfDatafailOnError != null)
                {
                    if (inputPdfDatafailOnError != null)
                    {
                        inputPdfData["fail_on_error"] = ExpressionConverter.ConvertO(inputPdfDatafailOnError);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientextractfromp")]
        [WorkflowExpressionFactory(nameof(__BuildOcrText))]
        public IBodyWorkflowAction<OcrOperationResponse> OcrText([WorkflowExpression] Func<string> inputDatasourceFileName, [WorkflowExpression] Func<string> inputDatasourceFileContent, [WorkflowExpression] Func<inputDatalanguageInput> inputDatalanguage = null, [WorkflowExpression] Func<string> inputDataxCoordinate = null, [WorkflowExpression] Func<string> inputDatayCoordinate = null, [WorkflowExpression] Func<string> inputDatawidth = null, [WorkflowExpression] Func<string> inputDataheight = null, [WorkflowExpression] Func<string> inputDatapageNumber = null, [WorkflowExpression] Func<inputDataperformanceInput> inputDataperformance = null, [WorkflowExpression] Func<inputDatablacklistWhitelistInput> inputDatablacklistWhitelist = null, [WorkflowExpression] Func<string> inputDatacharacters = null, [WorkflowExpression] Func<bool> inputDatausePagination = null, [WorkflowExpression] Func<bool> inputDatafailOnError = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OcrOperationResponse> __BuildOcrText(WorkflowExpression<string> inputDatasourceFileName, WorkflowExpression<string> inputDatasourceFileContent, WorkflowExpression<inputDatalanguageInput> inputDatalanguage = null, WorkflowExpression<string> inputDataxCoordinate = null, WorkflowExpression<string> inputDatayCoordinate = null, WorkflowExpression<string> inputDatawidth = null, WorkflowExpression<string> inputDataheight = null, WorkflowExpression<string> inputDatapageNumber = null, WorkflowExpression<inputDataperformanceInput> inputDataperformance = null, WorkflowExpression<inputDatablacklistWhitelistInput> inputDatablacklistWhitelist = null, WorkflowExpression<string> inputDatacharacters = null, WorkflowExpression<bool> inputDatausePagination = null, WorkflowExpression<bool> inputDatafailOnError = null)
        {
            WorkflowExpression.Validate(inputDatasourceFileName, nameof(inputDatasourceFileName), required: true);
            WorkflowExpression.Validate(inputDatasourceFileContent, nameof(inputDatasourceFileContent), required: true);
            WorkflowExpression.Validate(inputDatalanguage, nameof(inputDatalanguage), required: false);
            WorkflowExpression.Validate(inputDataxCoordinate, nameof(inputDataxCoordinate), required: false);
            WorkflowExpression.Validate(inputDatayCoordinate, nameof(inputDatayCoordinate), required: false);
            WorkflowExpression.Validate(inputDatawidth, nameof(inputDatawidth), required: false);
            WorkflowExpression.Validate(inputDataheight, nameof(inputDataheight), required: false);
            WorkflowExpression.Validate(inputDatapageNumber, nameof(inputDatapageNumber), required: false);
            WorkflowExpression.Validate(inputDataperformance, nameof(inputDataperformance), required: false);
            WorkflowExpression.Validate(inputDatablacklistWhitelist, nameof(inputDatablacklistWhitelist), required: false);
            WorkflowExpression.Validate(inputDatacharacters, nameof(inputDatacharacters), required: false);
            WorkflowExpression.Validate(inputDatausePagination, nameof(inputDatausePagination), required: false);
            WorkflowExpression.Validate(inputDatafailOnError, nameof(inputDatafailOnError), required: false);
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
                inputData["source_file_name"] = ExpressionConverter.ConvertO(inputDatasourceFileName);
                inputDatapropCount++;
                inputData["source_file_content"] = ExpressionConverter.ConvertO(inputDatasourceFileContent);
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
                        inputData["language"] = ExpressionConverter.ConvertO(inputDatalanguage);
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
                    if (inputDatapageNumber != null)
                    {
                        inputData["page_number"] = ExpressionConverter.ConvertO(inputDatapageNumber);
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
                        inputData["performance"] = ExpressionConverter.ConvertO(inputDataperformance);
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
                        inputData["characters_option"] = ExpressionConverter.ConvertO(inputDatablacklistWhitelist);
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
                    inputData["characters"] = ExpressionConverter.ConvertO(inputDatacharacters);
                    inputDatapropCount++;
                }

                if (inputDatausePagination != null)
                {
                    if (inputDatausePagination != null)
                    {
                        inputData["paginate"] = ExpressionConverter.ConvertO(inputDatausePagination);
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
                        inputData["fail_on_error"] = ExpressionConverter.ConvertO(inputDatafailOnError);
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