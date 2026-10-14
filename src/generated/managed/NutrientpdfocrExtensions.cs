//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientpdfocr
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class NutrientpdfocrActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientpdfocr")]
        public IBodyWorkflowAction<OperationResponse> OcrPdf(Expression<Func<string>> inputDatasourceFileName, Expression<Func<string>> inputDatasourceFileContent, Expression<Func<inputDatalanguageInput>> inputDatalanguage = null, Expression<Func<inputDataperformanceInput>> inputDataperformance = null, Expression<Func<inputDatablacklistWhitelistInput>> inputDatablacklistWhitelist = null, Expression<Func<string>> inputDatacharacters = null, Expression<Func<bool>> inputDatausePagination = null, Expression<Func<string>> inputDataregions = null, Expression<Func<bool>> inputDatafailOnError = null)
        {
            var __workflow_inputDatasourceFileName = inputDatasourceFileName == null ? null : WorkflowExpression.Compile(inputDatasourceFileName);
            WorkflowExpression.Validate(__workflow_inputDatasourceFileName, nameof(inputDatasourceFileName), required: true);
            var __workflow_inputDatasourceFileContent = inputDatasourceFileContent == null ? null : WorkflowExpression.Compile(inputDatasourceFileContent);
            WorkflowExpression.Validate(__workflow_inputDatasourceFileContent, nameof(inputDatasourceFileContent), required: true);
            var __workflow_inputDatalanguage = inputDatalanguage == null ? null : WorkflowExpression.Compile(inputDatalanguage);
            WorkflowExpression.Validate(__workflow_inputDatalanguage, nameof(inputDatalanguage), required: false);
            var __workflow_inputDataperformance = inputDataperformance == null ? null : WorkflowExpression.Compile(inputDataperformance);
            WorkflowExpression.Validate(__workflow_inputDataperformance, nameof(inputDataperformance), required: false);
            var __workflow_inputDatablacklistWhitelist = inputDatablacklistWhitelist == null ? null : WorkflowExpression.Compile(inputDatablacklistWhitelist);
            WorkflowExpression.Validate(__workflow_inputDatablacklistWhitelist, nameof(inputDatablacklistWhitelist), required: false);
            var __workflow_inputDatacharacters = inputDatacharacters == null ? null : WorkflowExpression.Compile(inputDatacharacters);
            WorkflowExpression.Validate(__workflow_inputDatacharacters, nameof(inputDatacharacters), required: false);
            var __workflow_inputDatausePagination = inputDatausePagination == null ? null : WorkflowExpression.Compile(inputDatausePagination);
            WorkflowExpression.Validate(__workflow_inputDatausePagination, nameof(inputDatausePagination), required: false);
            var __workflow_inputDataregions = inputDataregions == null ? null : WorkflowExpression.Compile(inputDataregions);
            WorkflowExpression.Validate(__workflow_inputDataregions, nameof(inputDataregions), required: false);
            var __workflow_inputDatafailOnError = inputDatafailOnError == null ? null : WorkflowExpression.Compile(inputDatafailOnError);
            WorkflowExpression.Validate(__workflow_inputDatafailOnError, nameof(inputDatafailOnError), required: false);
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

                inputData["copy_metadata"] = false;
                inputDatapropCount++;
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

                if (__workflow_inputDataregions != null)
                {
                    inputData["regions"] = ExpressionConverter.ConvertO(__workflow_inputDataregions);
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

                return new ApiConnectionAction<OperationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientpdfocr")]
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
