//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientextractfromp
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class NutrientextractfrompActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientextractfromp")]
        public IBodyWorkflowAction<OperationResponse> ExtractText(Expression<Func<string>> inputPdfDatasourceFileName, Expression<Func<string>> inputPdfDatasourceFileContent, Expression<Func<string>> inputPdfDatapageRange = null, Expression<Func<bool>> inputPdfDatafailOnError = null)
        {
            var __workflow_inputPdfDatasourceFileName = inputPdfDatasourceFileName == null ? null : WorkflowExpression.Compile(inputPdfDatasourceFileName);
            WorkflowExpression.Validate(__workflow_inputPdfDatasourceFileName, nameof(inputPdfDatasourceFileName), required: true);
            var __workflow_inputPdfDatasourceFileContent = inputPdfDatasourceFileContent == null ? null : WorkflowExpression.Compile(inputPdfDatasourceFileContent);
            WorkflowExpression.Validate(__workflow_inputPdfDatasourceFileContent, nameof(inputPdfDatasourceFileContent), required: true);
            var __workflow_inputPdfDatapageRange = inputPdfDatapageRange == null ? null : WorkflowExpression.Compile(inputPdfDatapageRange);
            WorkflowExpression.Validate(__workflow_inputPdfDatapageRange, nameof(inputPdfDatapageRange), required: false);
            var __workflow_inputPdfDatafailOnError = inputPdfDatafailOnError == null ? null : WorkflowExpression.Compile(inputPdfDatafailOnError);
            WorkflowExpression.Validate(__workflow_inputPdfDatafailOnError, nameof(inputPdfDatafailOnError), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientextractfromp")]
        public IBodyWorkflowAction<OperationResponse> ExtractKeyValuePairs(Expression<Func<string>> inputPdfDatasourceFileName, Expression<Func<string>> inputPdfDatasourceFileContent, Expression<Func<string>> inputPdfDataoCRLanguage = null, Expression<Func<inputPdfDatadPIInput>> inputPdfDatadPI = null, Expression<Func<inputPdfDatakVPOutputFormatInput>> inputPdfDatakVPOutputFormat = null, Expression<Func<string>> inputPdfDatapageRange = null, Expression<Func<inputPdfDataautorotateInput>> inputPdfDataautorotate = null, Expression<Func<inputPdfDatatrimSymbolsInput>> inputPdfDatatrimSymbols = null, Expression<Func<inputPdfDataincludeKeyBoundingBoxInput>> inputPdfDataincludeKeyBoundingBox = null, Expression<Func<inputPdfDataincludeValueBoundingBoxInput>> inputPdfDataincludeValueBoundingBox = null, Expression<Func<inputPdfDataincludePageNumberInput>> inputPdfDataincludePageNumber = null, Expression<Func<inputPdfDataincludeConfidenceInput>> inputPdfDataincludeConfidence = null, Expression<Func<int>> inputPdfDataconfidenceThreshold = null, Expression<Func<inputPdfDataincludeTypeInput>> inputPdfDataincludeType = null, Expression<Func<string>> inputPdfDataexpectedKeys = null, Expression<Func<bool>> inputPdfDatafailOnError = null)
        {
            var __workflow_inputPdfDatasourceFileName = inputPdfDatasourceFileName == null ? null : WorkflowExpression.Compile(inputPdfDatasourceFileName);
            WorkflowExpression.Validate(__workflow_inputPdfDatasourceFileName, nameof(inputPdfDatasourceFileName), required: true);
            var __workflow_inputPdfDatasourceFileContent = inputPdfDatasourceFileContent == null ? null : WorkflowExpression.Compile(inputPdfDatasourceFileContent);
            WorkflowExpression.Validate(__workflow_inputPdfDatasourceFileContent, nameof(inputPdfDatasourceFileContent), required: true);
            var __workflow_inputPdfDataoCRLanguage = inputPdfDataoCRLanguage == null ? null : WorkflowExpression.Compile(inputPdfDataoCRLanguage);
            WorkflowExpression.Validate(__workflow_inputPdfDataoCRLanguage, nameof(inputPdfDataoCRLanguage), required: false);
            var __workflow_inputPdfDatadPI = inputPdfDatadPI == null ? null : WorkflowExpression.Compile(inputPdfDatadPI);
            WorkflowExpression.Validate(__workflow_inputPdfDatadPI, nameof(inputPdfDatadPI), required: false);
            var __workflow_inputPdfDatakVPOutputFormat = inputPdfDatakVPOutputFormat == null ? null : WorkflowExpression.Compile(inputPdfDatakVPOutputFormat);
            WorkflowExpression.Validate(__workflow_inputPdfDatakVPOutputFormat, nameof(inputPdfDatakVPOutputFormat), required: false);
            var __workflow_inputPdfDatapageRange = inputPdfDatapageRange == null ? null : WorkflowExpression.Compile(inputPdfDatapageRange);
            WorkflowExpression.Validate(__workflow_inputPdfDatapageRange, nameof(inputPdfDatapageRange), required: false);
            var __workflow_inputPdfDataautorotate = inputPdfDataautorotate == null ? null : WorkflowExpression.Compile(inputPdfDataautorotate);
            WorkflowExpression.Validate(__workflow_inputPdfDataautorotate, nameof(inputPdfDataautorotate), required: false);
            var __workflow_inputPdfDatatrimSymbols = inputPdfDatatrimSymbols == null ? null : WorkflowExpression.Compile(inputPdfDatatrimSymbols);
            WorkflowExpression.Validate(__workflow_inputPdfDatatrimSymbols, nameof(inputPdfDatatrimSymbols), required: false);
            var __workflow_inputPdfDataincludeKeyBoundingBox = inputPdfDataincludeKeyBoundingBox == null ? null : WorkflowExpression.Compile(inputPdfDataincludeKeyBoundingBox);
            WorkflowExpression.Validate(__workflow_inputPdfDataincludeKeyBoundingBox, nameof(inputPdfDataincludeKeyBoundingBox), required: false);
            var __workflow_inputPdfDataincludeValueBoundingBox = inputPdfDataincludeValueBoundingBox == null ? null : WorkflowExpression.Compile(inputPdfDataincludeValueBoundingBox);
            WorkflowExpression.Validate(__workflow_inputPdfDataincludeValueBoundingBox, nameof(inputPdfDataincludeValueBoundingBox), required: false);
            var __workflow_inputPdfDataincludePageNumber = inputPdfDataincludePageNumber == null ? null : WorkflowExpression.Compile(inputPdfDataincludePageNumber);
            WorkflowExpression.Validate(__workflow_inputPdfDataincludePageNumber, nameof(inputPdfDataincludePageNumber), required: false);
            var __workflow_inputPdfDataincludeConfidence = inputPdfDataincludeConfidence == null ? null : WorkflowExpression.Compile(inputPdfDataincludeConfidence);
            WorkflowExpression.Validate(__workflow_inputPdfDataincludeConfidence, nameof(inputPdfDataincludeConfidence), required: false);
            var __workflow_inputPdfDataconfidenceThreshold = inputPdfDataconfidenceThreshold == null ? null : WorkflowExpression.Compile(inputPdfDataconfidenceThreshold);
            WorkflowExpression.Validate(__workflow_inputPdfDataconfidenceThreshold, nameof(inputPdfDataconfidenceThreshold), required: false);
            var __workflow_inputPdfDataincludeType = inputPdfDataincludeType == null ? null : WorkflowExpression.Compile(inputPdfDataincludeType);
            WorkflowExpression.Validate(__workflow_inputPdfDataincludeType, nameof(inputPdfDataincludeType), required: false);
            var __workflow_inputPdfDataexpectedKeys = inputPdfDataexpectedKeys == null ? null : WorkflowExpression.Compile(inputPdfDataexpectedKeys);
            WorkflowExpression.Validate(__workflow_inputPdfDataexpectedKeys, nameof(inputPdfDataexpectedKeys), required: false);
            var __workflow_inputPdfDatafailOnError = inputPdfDatafailOnError == null ? null : WorkflowExpression.Compile(inputPdfDatafailOnError);
            WorkflowExpression.Validate(__workflow_inputPdfDatafailOnError, nameof(inputPdfDatafailOnError), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientextractfromp")]
        public IBodyWorkflowAction<OcrOperationResponse> OcrText(Expression<Func<string>> inputDatasourceFileName, Expression<Func<string>> inputDatasourceFileContent, Expression<Func<inputDatalanguageInput>> inputDatalanguage = null, Expression<Func<string>> inputDataxCoordinate = null, Expression<Func<string>> inputDatayCoordinate = null, Expression<Func<string>> inputDatawidth = null, Expression<Func<string>> inputDataheight = null, Expression<Func<string>> inputDatapageNumber = null, Expression<Func<inputDataperformanceInput>> inputDataperformance = null, Expression<Func<inputDatablacklistWhitelistInput>> inputDatablacklistWhitelist = null, Expression<Func<string>> inputDatacharacters = null, Expression<Func<bool>> inputDatausePagination = null, Expression<Func<bool>> inputDatafailOnError = null)
        {
            var __workflow_inputDatasourceFileName = inputDatasourceFileName == null ? null : WorkflowExpression.Compile(inputDatasourceFileName);
            WorkflowExpression.Validate(__workflow_inputDatasourceFileName, nameof(inputDatasourceFileName), required: true);
            var __workflow_inputDatasourceFileContent = inputDatasourceFileContent == null ? null : WorkflowExpression.Compile(inputDatasourceFileContent);
            WorkflowExpression.Validate(__workflow_inputDatasourceFileContent, nameof(inputDatasourceFileContent), required: true);
            var __workflow_inputDatalanguage = inputDatalanguage == null ? null : WorkflowExpression.Compile(inputDatalanguage);
            WorkflowExpression.Validate(__workflow_inputDatalanguage, nameof(inputDatalanguage), required: false);
            var __workflow_inputDataxCoordinate = inputDataxCoordinate == null ? null : WorkflowExpression.Compile(inputDataxCoordinate);
            WorkflowExpression.Validate(__workflow_inputDataxCoordinate, nameof(inputDataxCoordinate), required: false);
            var __workflow_inputDatayCoordinate = inputDatayCoordinate == null ? null : WorkflowExpression.Compile(inputDatayCoordinate);
            WorkflowExpression.Validate(__workflow_inputDatayCoordinate, nameof(inputDatayCoordinate), required: false);
            var __workflow_inputDatawidth = inputDatawidth == null ? null : WorkflowExpression.Compile(inputDatawidth);
            WorkflowExpression.Validate(__workflow_inputDatawidth, nameof(inputDatawidth), required: false);
            var __workflow_inputDataheight = inputDataheight == null ? null : WorkflowExpression.Compile(inputDataheight);
            WorkflowExpression.Validate(__workflow_inputDataheight, nameof(inputDataheight), required: false);
            var __workflow_inputDatapageNumber = inputDatapageNumber == null ? null : WorkflowExpression.Compile(inputDatapageNumber);
            WorkflowExpression.Validate(__workflow_inputDatapageNumber, nameof(inputDatapageNumber), required: false);
            var __workflow_inputDataperformance = inputDataperformance == null ? null : WorkflowExpression.Compile(inputDataperformance);
            WorkflowExpression.Validate(__workflow_inputDataperformance, nameof(inputDataperformance), required: false);
            var __workflow_inputDatablacklistWhitelist = inputDatablacklistWhitelist == null ? null : WorkflowExpression.Compile(inputDatablacklistWhitelist);
            WorkflowExpression.Validate(__workflow_inputDatablacklistWhitelist, nameof(inputDatablacklistWhitelist), required: false);
            var __workflow_inputDatacharacters = inputDatacharacters == null ? null : WorkflowExpression.Compile(inputDatacharacters);
            WorkflowExpression.Validate(__workflow_inputDatacharacters, nameof(inputDatacharacters), required: false);
            var __workflow_inputDatausePagination = inputDatausePagination == null ? null : WorkflowExpression.Compile(inputDatausePagination);
            WorkflowExpression.Validate(__workflow_inputDatausePagination, nameof(inputDatausePagination), required: false);
            var __workflow_inputDatafailOnError = inputDatafailOnError == null ? null : WorkflowExpression.Compile(inputDatafailOnError);
            WorkflowExpression.Validate(__workflow_inputDatafailOnError, nameof(inputDatafailOnError), required: false);
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
