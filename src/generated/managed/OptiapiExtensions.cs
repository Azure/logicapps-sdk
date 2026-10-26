//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Optiapi
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OptiapiActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<CalculateAverageResponse, ApiConnectionActionConfiguration> CalculateAverage(Expression<Func<CalculateAverageInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CalculateAverageResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/array/calculate-average";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CalculateAverageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<ChunkAnArrayResponse, ApiConnectionActionConfiguration> ChunkAnArray(Expression<Func<ChunkAnArrayInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ChunkAnArrayResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/array/chunk";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/json");
                callPayload.Headers["Accept"] = Convert.ToString(" application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ChunkAnArrayResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<CombineArrayResponse, ApiConnectionActionConfiguration> CombineArray(Expression<Func<string>> contentType, Expression<Func<string>> accept, Expression<Func<CombineArrayInput>> body)
        {
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: true);
            var __workflow_accept = WorkflowExpression.Compile(accept, nameof(accept), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CombineArrayResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/array/combine";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Headers["Accept"] = ExpressionConverter.Convert(__workflow_accept);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CombineArrayResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<CheckIfArrayContainAValueResponse, ApiConnectionActionConfiguration> CheckIfArrayContainAValue(Expression<Func<CheckIfArrayContainAValueInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CheckIfArrayContainAValueResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/array/contains";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CheckIfArrayContainAValueResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<FindDifferenceBetweenArraysResponse, ApiConnectionActionConfiguration> FindDifferenceBetweenArrays(Expression<Func<FindDifferenceBetweenArraysInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<FindDifferenceBetweenArraysResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/array/difference";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/json");
                callPayload.Headers["Accept"] = Convert.ToString(" application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<FindDifferenceBetweenArraysResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<FindDuplicatesInArraysResponse, ApiConnectionActionConfiguration> FindDuplicatesInArrays(Expression<Func<FindDuplicatesInArraysInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<FindDuplicatesInArraysResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/array/duplicate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<FindDuplicatesInArraysResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<FilterAnArrayResponse, ApiConnectionActionConfiguration> FilterAnArray(Expression<Func<FilterAnArrayInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<FilterAnArrayResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/array/filter";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/json");
                callPayload.Headers["Accept"] = Convert.ToString(" application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<FilterAnArrayResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<FirstWhereWithinAnArrayResponse, ApiConnectionActionConfiguration> FirstWhereWithinAnArray(Expression<Func<FirstWhereWithinAnArrayInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<FirstWhereWithinAnArrayResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/array/first-where";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<FirstWhereWithinAnArrayResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<FlattenAnArrayResponse, ApiConnectionActionConfiguration> FlattenAnArray(Expression<Func<FlattenAnArrayInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<FlattenAnArrayResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/array/flatten";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<FlattenAnArrayResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<RemoveItemFromArrayResponse, ApiConnectionActionConfiguration> RemoveItemFromArray(Expression<Func<RemoveItemFromArrayInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<RemoveItemFromArrayResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/array/forget";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<RemoveItemFromArrayResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<GroupByAnArrayKeyResponse, ApiConnectionActionConfiguration> GroupByAnArrayKey(Expression<Func<GroupByAnArrayKeyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<GroupByAnArrayKeyResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/array/group-by";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GroupByAnArrayKeyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<StandardArrayResponse, ApiConnectionActionConfiguration> SortAnArray(Expression<Func<SortAnArrayInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<StandardArrayResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/array/sort";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/json");
                callPayload.Headers["Accept"] = Convert.ToString(" application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<StandardArrayResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<GetUniqueItemsInAnArrayResponse, ApiConnectionActionConfiguration> GetUniqueItemsInAnArray(Expression<Func<GetUniqueItemsInAnArrayInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GetUniqueItemsInAnArrayResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/array/unique";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetUniqueItemsInAnArrayResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<AddOrSubtractFromTimeOrDatesResponse, ApiConnectionActionConfiguration> AddOrSubtractFromTimeOrDates(Expression<Func<AddOrSubtractFromTimeOrDatesInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<AddOrSubtractFromTimeOrDatesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/datetime/add-or-subtract";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/json");
                callPayload.Headers["Accept"] = Convert.ToString(" application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AddOrSubtractFromTimeOrDatesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<ConvertAStringToADatetimeObjectResponse, ApiConnectionActionConfiguration> ConvertAStringToADatetimeObject(Expression<Func<string>> contentType, Expression<Func<string>> accept, Expression<Func<ConvertAStringToADatetimeObjectInput>> body)
        {
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: true);
            var __workflow_accept = WorkflowExpression.Compile(accept, nameof(accept), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ConvertAStringToADatetimeObjectResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/datetime/string-to-datetime";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Headers["Accept"] = ExpressionConverter.Convert(__workflow_accept);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ConvertAStringToADatetimeObjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<PerformOcrOnAScannedPdfOrImageFileResponse, ApiConnectionActionConfiguration> PerformOcrOnAScannedPdfOrImageFile(Expression<Func<PerformOcrOnAScannedPdfOrImageFileInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PerformOcrOnAScannedPdfOrImageFileResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/ocr/perform-ocr";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/json");
                callPayload.Headers["Accept"] = Convert.ToString(" application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PerformOcrOnAScannedPdfOrImageFileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<CombineMultiplePdfFilesResponse, ApiConnectionActionConfiguration> CombineMultiplePdfFiles(Expression<Func<CombineMultiplePdfFilesInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CombineMultiplePdfFilesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pdf/combine-pdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/json");
                callPayload.Headers["Accept"] = Convert.ToString(" application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CombineMultiplePdfFilesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<GetPdfMetadataInformationResponse, ApiConnectionActionConfiguration> GetPdfMetadataInformation(Expression<Func<GetPdfMetadataInformationInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GetPdfMetadataInformationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pdf/pdf-metadata";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/json");
                callPayload.Headers["Accept"] = Convert.ToString(" application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetPdfMetadataInformationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<StandardArrayResponse, ApiConnectionActionConfiguration> ConvertAPdfFileToText(Expression<Func<ConvertAPdfFileToTextInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<StandardArrayResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pdf/pdf-to-text";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/json");
                callPayload.Headers["Accept"] = Convert.ToString(" application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<StandardArrayResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<SetPasswordOnAPdfFileResponse, ApiConnectionActionConfiguration> SetPasswordOnAPdfFile(Expression<Func<string>> contentType, Expression<Func<string>> accept, Expression<Func<SetPasswordOnAPdfFileInput>> body)
        {
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: true);
            var __workflow_accept = WorkflowExpression.Compile(accept, nameof(accept), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SetPasswordOnAPdfFileResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pdf/set-password";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Headers["Accept"] = ExpressionConverter.Convert(__workflow_accept);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SetPasswordOnAPdfFileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<ReplaceTextInStringBasedOnARegularExpressionResponse, ApiConnectionActionConfiguration> ReplaceTextInStringBasedOnARegularExpression(Expression<Func<ReplaceTextInStringBasedOnARegularExpressionInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ReplaceTextInStringBasedOnARegularExpressionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/regex/regex-replace";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/json");
                callPayload.Headers["Accept"] = Convert.ToString(" application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ReplaceTextInStringBasedOnARegularExpressionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<FindValuesFromAStringBasedOnARegularExpressionResponse, ApiConnectionActionConfiguration> FindValuesFromAStringBasedOnARegularExpression(Expression<Func<FindValuesFromAStringBasedOnARegularExpressionInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<FindValuesFromAStringBasedOnARegularExpressionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/regex/regex-search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/json");
                callPayload.Headers["Accept"] = Convert.ToString(" application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<FindValuesFromAStringBasedOnARegularExpressionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<ReplaceTextInStringResponse, ApiConnectionActionConfiguration> ReplaceTextInString(Expression<Func<string>> contentType, Expression<Func<string>> accept, Expression<Func<ReplaceTextInStringInput>> body)
        {
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: true);
            var __workflow_accept = WorkflowExpression.Compile(accept, nameof(accept), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ReplaceTextInStringResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/text/text-replace";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Headers["Accept"] = ExpressionConverter.Convert(__workflow_accept);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ReplaceTextInStringResponse>(callPayload);
            });
        }
    }

    public class OptiapiTriggers([ConnectionName] string connectionId)
    {
    }

    public class CalculateAverageResponse
    {
        [JsonProperty("average")]
        public int Average { get; set; }
    }

    public class CalculateAverageInput
    {
        [JsonProperty("array", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] Array { get; set; }

        [JsonProperty("key", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Key { get; set; }
    }

    public class ChunkAnArrayResponse
    {
        [JsonProperty("array")]
        public string[] Array { get; set; }
    }

    public class ChunkAnArrayInput
    {
        [JsonProperty("array", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] Array { get; set; }

        [JsonProperty("size", DefaultValueHandling = DefaultValueHandling.Include)]
        public int Size { get; set; }
    }

    public class CombineArrayResponse
    {
        [JsonProperty("array")]
        public string[] Array { get; set; }
    }

    public class CombineArrayInput
    {
        [JsonProperty("keys", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] Keys { get; set; }

        [JsonProperty("values", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] Values { get; set; }
    }

    public class CheckIfArrayContainAValueResponse
    {
        [JsonProperty("contains")]
        public bool Contains { get; set; }
    }

    public class CheckIfArrayContainAValueInput
    {
        [JsonProperty("array", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] Array { get; set; }

        [JsonProperty("key", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Key { get; set; }

        [JsonProperty("search", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Search { get; set; }
    }

    public class FindDifferenceBetweenArraysResponse
    {
        [JsonProperty("array")]
        public string[] Array { get; set; }
    }

    public class FindDifferenceBetweenArraysInput
    {
        [JsonProperty("array", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] Array { get; set; }

        [JsonProperty("compare", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] Compare { get; set; }
    }

    public class FindDuplicatesInArraysResponse
    {
        [JsonProperty("array")]
        public string[] Array { get; set; }
    }

    public class FindDuplicatesInArraysInput
    {
        [JsonProperty("array", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] Array { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }
    }

    public class FilterAnArrayResponse
    {
        [JsonProperty("array")]
        public string[] Array { get; set; }
    }

    public class FilterAnArrayInput
    {
        [JsonProperty("array", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] Array { get; set; }

        [JsonProperty("preserveKeys", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool PreserveKeys { get; set; } = true;
    }

    public class FirstWhereWithinAnArrayResponse
    {
        [JsonProperty("array")]
        public string[] Array { get; set; }
    }

    public class FirstWhereWithinAnArrayInput
    {
        [JsonProperty("array", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] Array { get; set; }

        [JsonProperty("key", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Key { get; set; }

        [JsonProperty("operator")]
        public FirstWhereWithinAnArrayInputOperatorType? Operator { get; set; }

        [JsonProperty("value", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Value { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum FirstWhereWithinAnArrayInputOperatorType
    {
        [EnumMember(Value = ">=")]
        Unnamed6,
        [EnumMember(Value = "<=")]
        Unnamed3,
        [EnumMember(Value = ">")]
        Unnamed5,
        [EnumMember(Value = "<")]
        Unnamed2,
        [EnumMember(Value = "=")]
        Unnamed4,
        [EnumMember(Value = "!=")]
        Unnamed
    }

    public class FlattenAnArrayResponse
    {
        [JsonProperty("array")]
        public string[] Array { get; set; }
    }

    public class FlattenAnArrayInput
    {
        [JsonProperty("array", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] Array { get; set; }

        [JsonProperty("depth")]
        public int? Depth { get; set; }
    }

    public class RemoveItemFromArrayResponse
    {
        [JsonProperty("array")]
        public string[] Array { get; set; }
    }

    public class RemoveItemFromArrayInput
    {
        [JsonProperty("array", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] Array { get; set; }

        [JsonProperty("key", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Key { get; set; }
    }

    public class GroupByAnArrayKeyResponse
    {
        [JsonProperty("array")]
        public string[] Array { get; set; }
    }

    public class GroupByAnArrayKeyInput
    {
        [JsonProperty("array", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] Array { get; set; }

        [JsonProperty("key", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Key { get; set; }
    }

    public class StandardArrayResponse
    {
        [JsonProperty("array")]
        public string[] ResultArray { get; set; }
    }

    public class SortAnArrayInput
    {
        [JsonProperty("array", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] Array { get; set; }

        [JsonProperty("sort", DefaultValueHandling = DefaultValueHandling.Include)]
        public SortAnArrayInputSortType Sort { get; set; } = SortAnArrayInputSortType.Ascending;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SortAnArrayInputSortType
    {
        Ascending,
        Descending
    }

    public class GetUniqueItemsInAnArrayResponse
    {
        [JsonProperty("array")]
        public string[] Array { get; set; }
    }

    public class GetUniqueItemsInAnArrayInput
    {
        [JsonProperty("array", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] Array { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }
    }

    public class AddOrSubtractFromTimeOrDatesResponse
    {
        [JsonProperty("datetime")]
        public string Datetime { get; set; }
    }

    public class AddOrSubtractFromTimeOrDatesInput
    {
        [JsonProperty("action", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddOrSubtractFromTimeOrDatesInputActionType Action { get; set; } = AddOrSubtractFromTimeOrDatesInputActionType.Week;

        [JsonProperty("datetime", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Datetime { get; set; }

        [JsonProperty("operator", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddOrSubtractFromTimeOrDatesInputOperatorType Operator { get; set; } = AddOrSubtractFromTimeOrDatesInputOperatorType.Add;

        [JsonProperty("outputFormat")]
        public string OutputFormat { get; set; }

        [JsonProperty("value", DefaultValueHandling = DefaultValueHandling.Include)]
        public int Value { get; set; } = 1;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddOrSubtractFromTimeOrDatesInputActionType
    {
        Year,
        Quarter,
        Month,
        Week,
        Weekday,
        Day,
        Hour,
        Minute,
        Second
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddOrSubtractFromTimeOrDatesInputOperatorType
    {
        Add,
        Subtract
    }

    public class ConvertAStringToADatetimeObjectResponse
    {
        [JsonProperty("datetime")]
        public string Datetime { get; set; }
    }

    public class ConvertAStringToADatetimeObjectInput
    {
        [JsonProperty("inputFormat", DefaultValueHandling = DefaultValueHandling.Include)]
        public string InputFormat { get; set; } = "dd.mm.yyyy";

        [JsonProperty("outputFormat", DefaultValueHandling = DefaultValueHandling.Include)]
        public string OutputFormat { get; set; } = "dd/mm/yyyy";

        [JsonProperty("string", DefaultValueHandling = DefaultValueHandling.Include)]
        public string String { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }
    }

    public class PerformOcrOnAScannedPdfOrImageFileResponse
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PerformOcrOnAScannedPdfOrImageFileInput
    {
        [JsonProperty("file", DefaultValueHandling = DefaultValueHandling.Include)]
        public string File { get; set; }

        [JsonProperty("language", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Language { get; set; } = "eng";

        [JsonProperty("oem", DefaultValueHandling = DefaultValueHandling.Include)]
        public PerformOcrOnAScannedPdfOrImageFileInputOemType Oem { get; set; }

        [JsonProperty("psm", DefaultValueHandling = DefaultValueHandling.Include)]
        public PerformOcrOnAScannedPdfOrImageFileInputPsmType Psm { get; set; } = PerformOcrOnAScannedPdfOrImageFileInputPsmType._3;

        [JsonProperty("trim", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool Trim { get; set; } = false;

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public PerformOcrOnAScannedPdfOrImageFileInputTypeType Type { get; set; }
    }

    public enum PerformOcrOnAScannedPdfOrImageFileInputOemType
    {
        _0 = 0,
        _1 = 1
    }

    public enum PerformOcrOnAScannedPdfOrImageFileInputPsmType
    {
        _0 = 0,
        _1 = 1,
        _2 = 2,
        _3 = 3,
        _4 = 4,
        _5 = 5,
        _6 = 6,
        _7 = 7,
        _8 = 8,
        _9 = 9,
        _10 = 10,
        _11 = 11,
        _12 = 12,
        _13 = 13
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PerformOcrOnAScannedPdfOrImageFileInputTypeType
    {
        [EnumMember(Value = "pdf")]
        Pdf,
        [EnumMember(Value = "jpg")]
        Jpg,
        [EnumMember(Value = "jpeg")]
        Jpeg,
        [EnumMember(Value = "png")]
        Png,
        [EnumMember(Value = "gif")]
        Gif
    }

    public class CombineMultiplePdfFilesResponse
    {
        [JsonProperty("content")]
        public string Content { get; set; }
    }

    public class CombineMultiplePdfFilesInput
    {
        [JsonProperty("pdfs", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] Pdfs { get; set; }
    }

    public class GetPdfMetadataInformationResponse
    {
        [JsonProperty("metadata")]
        public GetPdfMetadataInformationResponseMetadataType Metadata { get; set; }
    }

    public class GetPdfMetadataInformationResponseMetadataType
    {
        public string PDFVersion { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("creationDate")]
        public string CreationDate { get; set; }

        [JsonProperty("creator")]
        public string Creator { get; set; }

        [JsonProperty("encrypted")]
        public string Encrypted { get; set; }

        [JsonProperty("fileSize")]
        public string FileSize { get; set; }

        [JsonProperty("form")]
        public string Form { get; set; }

        [JsonProperty("modDate")]
        public string ModDate { get; set; }

        [JsonProperty("optimized")]
        public string Optimized { get; set; }

        [JsonProperty("output")]
        public string[] Output { get; set; }

        [JsonProperty("pageRot")]
        public string PageRot { get; set; }

        [JsonProperty("pageSize")]
        public string PageSize { get; set; }

        [JsonProperty("pages")]
        public string Pages { get; set; }

        [JsonProperty("producer")]
        public string Producer { get; set; }

        [JsonProperty("tagged")]
        public string Tagged { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class GetPdfMetadataInformationInput
    {
        [JsonProperty("pdf", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Pdf { get; set; }
    }

    public class ConvertAPdfFileToTextInput
    {
        [JsonProperty("endPage")]
        public int? EndPage { get; set; }

        [JsonProperty("layout", DefaultValueHandling = DefaultValueHandling.Include)]
        public ConvertAPdfFileToTextInputLayoutType Layout { get; set; } = ConvertAPdfFileToTextInputLayoutType.Raw;

        [JsonProperty("pdf", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Pdf { get; set; }

        [JsonProperty("startPage")]
        public int? StartPage { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ConvertAPdfFileToTextInputLayoutType
    {
        [EnumMember(Value = "raw")]
        Raw,
        [EnumMember(Value = "original")]
        Original
    }

    public class SetPasswordOnAPdfFileResponse
    {
        [JsonProperty("content")]
        public string Content { get; set; }
    }

    public class SetPasswordOnAPdfFileInput
    {
        [JsonProperty("password", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Password { get; set; }

        [JsonProperty("pdf", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Pdf { get; set; }
    }

    public class ReplaceTextInStringBasedOnARegularExpressionResponse
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class ReplaceTextInStringBasedOnARegularExpressionInput
    {
        [JsonProperty("pattern", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Pattern { get; set; } = "/string/i";

        [JsonProperty("replacement", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Replacement { get; set; }

        [JsonProperty("text", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Text { get; set; }
    }

    public class FindValuesFromAStringBasedOnARegularExpressionResponse
    {
        [JsonProperty("values")]
        public string[] Values { get; set; }
    }

    public class FindValuesFromAStringBasedOnARegularExpressionInput
    {
        [JsonProperty("group")]
        public int? Group { get; set; }

        [JsonProperty("pattern", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Pattern { get; set; } = "/string/i";

        [JsonProperty("text", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Text { get; set; }
    }

    public class ReplaceTextInStringResponse
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class ReplaceTextInStringInput
    {
        [JsonProperty("replace", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Replace { get; set; }

        [JsonProperty("search", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Search { get; set; }

        [JsonProperty("text", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Text { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Optiapi;

    public partial class WorkflowManagedActions
    {
        public OptiapiActions Optiapi(string connectionId) => new OptiapiActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public OptiapiTriggers Optiapi(string connectionId) => new OptiapiTriggers(connectionId);
    }
}