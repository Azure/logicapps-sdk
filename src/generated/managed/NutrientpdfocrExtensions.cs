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

            inputData["copy_metadata"] = false;
            inputDatapropCount++;
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

            if (inputDataregions != null)
            {
                inputData["regions"] = CSharpExpressionConverter.ConvertToken(inputDataregions);
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