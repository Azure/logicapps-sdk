//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientpdfocr
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NutrientpdfocrActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientpdfocr")]
        [WorkflowExpressionFactory(nameof(__BuildOcrPdf))]
        public IBodyWorkflowAction<OperationResponse> OcrPdf([WorkflowExpression] Func<string> inputDatasourceFileName, [WorkflowExpression] Func<string> inputDatasourceFileContent, [WorkflowExpression] Func<inputDatalanguageInput> inputDatalanguage = null, [WorkflowExpression] Func<inputDataperformanceInput> inputDataperformance = null, [WorkflowExpression] Func<inputDatablacklistWhitelistInput> inputDatablacklistWhitelist = null, [WorkflowExpression] Func<string> inputDatacharacters = null, [WorkflowExpression] Func<bool> inputDatausePagination = null, [WorkflowExpression] Func<string> inputDataregions = null, [WorkflowExpression] Func<bool> inputDatafailOnError = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientpdfocr")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OperationResponse> __BuildOcrPdf(WorkflowExpression<string> inputDatasourceFileName, WorkflowExpression<string> inputDatasourceFileContent, WorkflowExpression<inputDatalanguageInput> inputDatalanguage = null, WorkflowExpression<inputDataperformanceInput> inputDataperformance = null, WorkflowExpression<inputDatablacklistWhitelistInput> inputDatablacklistWhitelist = null, WorkflowExpression<string> inputDatacharacters = null, WorkflowExpression<bool> inputDatausePagination = null, WorkflowExpression<string> inputDataregions = null, WorkflowExpression<bool> inputDatafailOnError = null)
        {
            WorkflowExpression.Validate(inputDatasourceFileName, nameof(inputDatasourceFileName), required: true);
            WorkflowExpression.Validate(inputDatasourceFileContent, nameof(inputDatasourceFileContent), required: true);
            WorkflowExpression.Validate(inputDatalanguage, nameof(inputDatalanguage), required: false);
            WorkflowExpression.Validate(inputDataperformance, nameof(inputDataperformance), required: false);
            WorkflowExpression.Validate(inputDatablacklistWhitelist, nameof(inputDatablacklistWhitelist), required: false);
            WorkflowExpression.Validate(inputDatacharacters, nameof(inputDatacharacters), required: false);
            WorkflowExpression.Validate(inputDatausePagination, nameof(inputDatausePagination), required: false);
            WorkflowExpression.Validate(inputDataregions, nameof(inputDataregions), required: false);
            WorkflowExpression.Validate(inputDatafailOnError, nameof(inputDatafailOnError), required: false);
            return new DeferredBodyAction<OperationResponse>(() =>
            {
                var apiCallPath = "/v1/operations/ocr_pdf";
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

                inputData["copy_metadata"] = false;
                inputDatapropCount++;
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

                if (inputDataregions != null)
                {
                    inputData["regions"] = ExpressionConverter.ConvertO(inputDataregions);
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

                return new ApiConnectionAction<OperationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientpdfocr")]
        [WorkflowExpressionFactory(nameof(__BuildOcrText))]
        public IBodyWorkflowAction<OcrOperationResponse> OcrText([WorkflowExpression] Func<string> inputDatasourceFileName, [WorkflowExpression] Func<string> inputDatasourceFileContent, [WorkflowExpression] Func<inputDatalanguageInput> inputDatalanguage = null, [WorkflowExpression] Func<string> inputDataxCoordinate = null, [WorkflowExpression] Func<string> inputDatayCoordinate = null, [WorkflowExpression] Func<string> inputDatawidth = null, [WorkflowExpression] Func<string> inputDataheight = null, [WorkflowExpression] Func<string> inputDatapageNumber = null, [WorkflowExpression] Func<inputDataperformanceInput> inputDataperformance = null, [WorkflowExpression] Func<inputDatablacklistWhitelistInput> inputDatablacklistWhitelist = null, [WorkflowExpression] Func<string> inputDatacharacters = null, [WorkflowExpression] Func<bool> inputDatausePagination = null, [WorkflowExpression] Func<bool> inputDatafailOnError = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientpdfocr")]
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