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
        public IBodyWorkflowAction<OperationResponse> ExtractText([WorkflowExpression] Func<string> inputPdfDatasourceFileName, [WorkflowExpression] Func<string> inputPdfDatasourceFileContent, [WorkflowExpression] Func<string> inputPdfDatapageRange = null, [WorkflowExpression] Func<bool> inputPdfDatafailOnError = null)
        {
            SourceExpression.Validate(inputPdfDatasourceFileName, nameof(inputPdfDatasourceFileName), required: true);
            SourceExpression.Validate(inputPdfDatasourceFileContent, nameof(inputPdfDatasourceFileContent), required: true);
            SourceExpression.Validate(inputPdfDatapageRange, nameof(inputPdfDatapageRange), required: false);
            SourceExpression.Validate(inputPdfDatafailOnError, nameof(inputPdfDatafailOnError), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/operations/extract_text";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputPdfData = new JObject();
                var inputPdfDatapropCount = 0;
                inputPdfData["use_async_pattern"] = false;
                inputPdfDatapropCount++;
                inputPdfDatapropCount++;
                inputPdfData["source_file_name"] = SourceExpressionConverter.ConvertToken(inputPdfDatasourceFileName);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputPdfData["sharepoint_file"] = sharepointFileObject;
                    inputPdfDatapropCount++;
                }

                inputPdfDatapropCount++;
                inputPdfData["source_file_content"] = SourceExpressionConverter.ConvertToken(inputPdfDatasourceFileContent);
                if (inputPdfDatapageRange != null)
                {
                    if (inputPdfDatapageRange != null)
                    {
                        inputPdfData["page_range"] = SourceExpressionConverter.ConvertToken(inputPdfDatapageRange);
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
                        inputPdfData["fail_on_error"] = SourceExpressionConverter.ConvertToken(inputPdfDatafailOnError);
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
                return callPayload;
            }

            return new ApiConnectionAction<OperationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientextractfromp")]
        public IBodyWorkflowAction<OperationResponse> ExtractKeyValuePairs([WorkflowExpression] Func<string> inputPdfDatasourceFileName, [WorkflowExpression] Func<string> inputPdfDatasourceFileContent, [WorkflowExpression] Func<string> inputPdfDataoCRLanguage = null, [WorkflowExpression] Func<inputPdfDatadPIInput> inputPdfDatadPI = null, [WorkflowExpression] Func<inputPdfDatakVPOutputFormatInput> inputPdfDatakVPOutputFormat = null, [WorkflowExpression] Func<string> inputPdfDatapageRange = null, [WorkflowExpression] Func<inputPdfDataautorotateInput> inputPdfDataautorotate = null, [WorkflowExpression] Func<inputPdfDatatrimSymbolsInput> inputPdfDatatrimSymbols = null, [WorkflowExpression] Func<inputPdfDataincludeKeyBoundingBoxInput> inputPdfDataincludeKeyBoundingBox = null, [WorkflowExpression] Func<inputPdfDataincludeValueBoundingBoxInput> inputPdfDataincludeValueBoundingBox = null, [WorkflowExpression] Func<inputPdfDataincludePageNumberInput> inputPdfDataincludePageNumber = null, [WorkflowExpression] Func<inputPdfDataincludeConfidenceInput> inputPdfDataincludeConfidence = null, [WorkflowExpression] Func<int> inputPdfDataconfidenceThreshold = null, [WorkflowExpression] Func<inputPdfDataincludeTypeInput> inputPdfDataincludeType = null, [WorkflowExpression] Func<string> inputPdfDataexpectedKeys = null, [WorkflowExpression] Func<bool> inputPdfDatafailOnError = null)
        {
            SourceExpression.Validate(inputPdfDatasourceFileName, nameof(inputPdfDatasourceFileName), required: true);
            SourceExpression.Validate(inputPdfDatasourceFileContent, nameof(inputPdfDatasourceFileContent), required: true);
            SourceExpression.Validate(inputPdfDataoCRLanguage, nameof(inputPdfDataoCRLanguage), required: false);
            SourceExpression.Validate(inputPdfDatadPI, nameof(inputPdfDatadPI), required: false);
            SourceExpression.Validate(inputPdfDatakVPOutputFormat, nameof(inputPdfDatakVPOutputFormat), required: false);
            SourceExpression.Validate(inputPdfDatapageRange, nameof(inputPdfDatapageRange), required: false);
            SourceExpression.Validate(inputPdfDataautorotate, nameof(inputPdfDataautorotate), required: false);
            SourceExpression.Validate(inputPdfDatatrimSymbols, nameof(inputPdfDatatrimSymbols), required: false);
            SourceExpression.Validate(inputPdfDataincludeKeyBoundingBox, nameof(inputPdfDataincludeKeyBoundingBox), required: false);
            SourceExpression.Validate(inputPdfDataincludeValueBoundingBox, nameof(inputPdfDataincludeValueBoundingBox), required: false);
            SourceExpression.Validate(inputPdfDataincludePageNumber, nameof(inputPdfDataincludePageNumber), required: false);
            SourceExpression.Validate(inputPdfDataincludeConfidence, nameof(inputPdfDataincludeConfidence), required: false);
            SourceExpression.Validate(inputPdfDataconfidenceThreshold, nameof(inputPdfDataconfidenceThreshold), required: false);
            SourceExpression.Validate(inputPdfDataincludeType, nameof(inputPdfDataincludeType), required: false);
            SourceExpression.Validate(inputPdfDataexpectedKeys, nameof(inputPdfDataexpectedKeys), required: false);
            SourceExpression.Validate(inputPdfDatafailOnError, nameof(inputPdfDatafailOnError), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/operations/key_value_pairs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputPdfData = new JObject();
                var inputPdfDatapropCount = 0;
                inputPdfData["use_async_pattern"] = false;
                inputPdfDatapropCount++;
                inputPdfDatapropCount++;
                inputPdfData["source_file_name"] = SourceExpressionConverter.ConvertToken(inputPdfDatasourceFileName);
                var sharepointFileObject = new JObject();
                var sharepointFileObjectpropCount = 0;
                if (sharepointFileObjectpropCount > 0)
                {
                    inputPdfData["sharepoint_file"] = sharepointFileObject;
                    inputPdfDatapropCount++;
                }

                inputPdfDatapropCount++;
                inputPdfData["source_file_content"] = SourceExpressionConverter.ConvertToken(inputPdfDatasourceFileContent);
                if (inputPdfDataoCRLanguage != null)
                {
                    if (inputPdfDataoCRLanguage != null)
                    {
                        inputPdfData["ocr_language"] = SourceExpressionConverter.ConvertToken(inputPdfDataoCRLanguage);
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
                        inputPdfData["dpi"] = SourceExpressionConverter.Convert(inputPdfDatadPI);
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
                        inputPdfData["kvp_format"] = SourceExpressionConverter.Convert(inputPdfDatakVPOutputFormat);
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
                        inputPdfData["page_range"] = SourceExpressionConverter.ConvertToken(inputPdfDatapageRange);
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
                        inputPdfData["autorotate"] = SourceExpressionConverter.Convert(inputPdfDataautorotate);
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
                        inputPdfData["trim_symbols"] = SourceExpressionConverter.Convert(inputPdfDatatrimSymbols);
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
                        inputPdfData["include_key_bounding_box"] = SourceExpressionConverter.Convert(inputPdfDataincludeKeyBoundingBox);
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
                        inputPdfData["include_value_bounding_box"] = SourceExpressionConverter.Convert(inputPdfDataincludeValueBoundingBox);
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
                        inputPdfData["include_page_number"] = SourceExpressionConverter.Convert(inputPdfDataincludePageNumber);
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
                        inputPdfData["include_confidence"] = SourceExpressionConverter.Convert(inputPdfDataincludeConfidence);
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
                        inputPdfData["confidence_threshold"] = SourceExpressionConverter.ConvertToken(inputPdfDataconfidenceThreshold);
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
                        inputPdfData["include_type"] = SourceExpressionConverter.Convert(inputPdfDataincludeType);
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
                    inputPdfData["expected_keys"] = SourceExpressionConverter.ConvertToken(inputPdfDataexpectedKeys);
                    inputPdfDatapropCount++;
                }

                if (inputPdfDatafailOnError != null)
                {
                    if (inputPdfDatafailOnError != null)
                    {
                        inputPdfData["fail_on_error"] = SourceExpressionConverter.ConvertToken(inputPdfDatafailOnError);
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
                return callPayload;
            }

            return new ApiConnectionAction<OperationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientextractfromp")]
        public IBodyWorkflowAction<OcrOperationResponse> OcrText([WorkflowExpression] Func<string> inputDatasourceFileName, [WorkflowExpression] Func<string> inputDatasourceFileContent, [WorkflowExpression] Func<inputDatalanguageInput> inputDatalanguage = null, [WorkflowExpression] Func<string> inputDataxCoordinate = null, [WorkflowExpression] Func<string> inputDatayCoordinate = null, [WorkflowExpression] Func<string> inputDatawidth = null, [WorkflowExpression] Func<string> inputDataheight = null, [WorkflowExpression] Func<string> inputDatapageNumber = null, [WorkflowExpression] Func<inputDataperformanceInput> inputDataperformance = null, [WorkflowExpression] Func<inputDatablacklistWhitelistInput> inputDatablacklistWhitelist = null, [WorkflowExpression] Func<string> inputDatacharacters = null, [WorkflowExpression] Func<bool> inputDatausePagination = null, [WorkflowExpression] Func<bool> inputDatafailOnError = null)
        {
            SourceExpression.Validate(inputDatasourceFileName, nameof(inputDatasourceFileName), required: true);
            SourceExpression.Validate(inputDatasourceFileContent, nameof(inputDatasourceFileContent), required: true);
            SourceExpression.Validate(inputDatalanguage, nameof(inputDatalanguage), required: false);
            SourceExpression.Validate(inputDataxCoordinate, nameof(inputDataxCoordinate), required: false);
            SourceExpression.Validate(inputDatayCoordinate, nameof(inputDatayCoordinate), required: false);
            SourceExpression.Validate(inputDatawidth, nameof(inputDatawidth), required: false);
            SourceExpression.Validate(inputDataheight, nameof(inputDataheight), required: false);
            SourceExpression.Validate(inputDatapageNumber, nameof(inputDatapageNumber), required: false);
            SourceExpression.Validate(inputDataperformance, nameof(inputDataperformance), required: false);
            SourceExpression.Validate(inputDatablacklistWhitelist, nameof(inputDatablacklistWhitelist), required: false);
            SourceExpression.Validate(inputDatacharacters, nameof(inputDatacharacters), required: false);
            SourceExpression.Validate(inputDatausePagination, nameof(inputDatausePagination), required: false);
            SourceExpression.Validate(inputDatafailOnError, nameof(inputDatafailOnError), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/operations/ocr_text";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputData = new JObject();
                var inputDatapropCount = 0;
                inputData["use_async_pattern"] = false;
                inputDatapropCount++;
                inputDatapropCount++;
                inputData["source_file_name"] = SourceExpressionConverter.ConvertToken(inputDatasourceFileName);
                inputDatapropCount++;
                inputData["source_file_content"] = SourceExpressionConverter.ConvertToken(inputDatasourceFileContent);
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
                        inputData["language"] = SourceExpressionConverter.Convert(inputDatalanguage);
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
                    inputData["x"] = SourceExpressionConverter.ConvertToken(inputDataxCoordinate);
                    inputDatapropCount++;
                }

                if (inputDatayCoordinate != null)
                {
                    inputData["y"] = SourceExpressionConverter.ConvertToken(inputDatayCoordinate);
                    inputDatapropCount++;
                }

                if (inputDatawidth != null)
                {
                    inputData["width"] = SourceExpressionConverter.ConvertToken(inputDatawidth);
                    inputDatapropCount++;
                }

                if (inputDataheight != null)
                {
                    inputData["height"] = SourceExpressionConverter.ConvertToken(inputDataheight);
                    inputDatapropCount++;
                }

                if (inputDatapageNumber != null)
                {
                    if (inputDatapageNumber != null)
                    {
                        inputData["page_number"] = SourceExpressionConverter.ConvertToken(inputDatapageNumber);
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
                        inputData["performance"] = SourceExpressionConverter.Convert(inputDataperformance);
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
                        inputData["characters_option"] = SourceExpressionConverter.Convert(inputDatablacklistWhitelist);
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
                    inputData["characters"] = SourceExpressionConverter.ConvertToken(inputDatacharacters);
                    inputDatapropCount++;
                }

                if (inputDatausePagination != null)
                {
                    if (inputDatausePagination != null)
                    {
                        inputData["paginate"] = SourceExpressionConverter.ConvertToken(inputDatausePagination);
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
                        inputData["fail_on_error"] = SourceExpressionConverter.ConvertToken(inputDatafailOnError);
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
                return callPayload;
            }

            return new ApiConnectionAction<OcrOperationResponse>(BuildSourceInput);
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