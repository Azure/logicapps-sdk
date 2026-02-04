//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Nutrientpdfocr
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NutrientpdfocrActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientpdfocr")]
        public IBodyWorkflowAction<OperationResponse> OcrPdf(Expression<Func<string>> inputDatasourceFileName, Expression<Func<string>> inputDatasourceFileContent, Expression<Func<inputDatalanguageInput>> inputDatalanguage = null, Expression<Func<inputDataperformanceInput>> inputDataperformance = null, Expression<Func<inputDatablacklistWhitelistInput>> inputDatablacklistWhitelist = null, Expression<Func<string>> inputDatacharacters = null, Expression<Func<bool>> inputDatausePagination = null, Expression<Func<string>> inputDataregions = null, Expression<Func<bool>> inputDatafailOnError = null)
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
                inputData["language"] = ExpressionConverter.ConvertO(inputDatalanguage);
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

            if (inputDataregions != null)
            {
                inputData["regions"] = ExpressionConverter.ConvertO(inputDataregions);
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

            return new ApiConnectionAction<OperationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nutrientpdfocr")]
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
            var sharepointFileObject = new JObject();
            var sharepointFileObjectpropCount = 0;
            if (sharepointFileObjectpropCount > 0)
            {
                inputData["sharepoint_file"] = sharepointFileObject;
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