//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Optiapi
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OptiapiActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<CalculateAverageResponse> CalculateAverage([WorkflowExpression] Func<string[]> bodyarray, [WorkflowExpression] Func<string> bodykey)
        {
            var apiCallPath = "/array/calculate-average";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["array"] = ExpressionConverter.ConvertO(bodyarray);
            bodypropCount++;
            body["key"] = ExpressionConverter.ConvertO(bodykey);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CalculateAverageResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<ChunkAnArrayResponse> ChunkAnArray([WorkflowExpression] Func<string[]> bodyarray, [WorkflowExpression] Func<int> bodysize)
        {
            var apiCallPath = "/array/chunk";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString(" application/json");
            callPayload.Headers["Accept"] = Convert.ToString(" application/json");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["array"] = ExpressionConverter.ConvertO(bodyarray);
            bodypropCount++;
            body["size"] = ExpressionConverter.ConvertO(bodysize);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ChunkAnArrayResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<CombineArrayResponse> CombineArray([WorkflowExpression] Func<string> contentType, [WorkflowExpression] Func<string> accept, [WorkflowExpression] Func<string[]> bodykeys, [WorkflowExpression] Func<string[]> bodyvalues)
        {
            var apiCallPath = "/array/combine";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
            callPayload.Headers["Accept"] = ExpressionConverter.Convert(accept);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["keys"] = ExpressionConverter.ConvertO(bodykeys);
            bodypropCount++;
            body["values"] = ExpressionConverter.ConvertO(bodyvalues);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CombineArrayResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<CheckIfArrayContainAValueResponse> CheckIfArrayContainAValue([WorkflowExpression] Func<string[]> bodyarray, [WorkflowExpression] Func<string> bodykey, [WorkflowExpression] Func<string> bodysearch)
        {
            var apiCallPath = "/array/contains";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["array"] = ExpressionConverter.ConvertO(bodyarray);
            bodypropCount++;
            body["key"] = ExpressionConverter.ConvertO(bodykey);
            bodypropCount++;
            body["search"] = ExpressionConverter.ConvertO(bodysearch);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CheckIfArrayContainAValueResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<FindDifferenceBetweenArraysResponse> FindDifferenceBetweenArrays([WorkflowExpression] Func<string[]> bodyarray, [WorkflowExpression] Func<string[]> bodycompare)
        {
            var apiCallPath = "/array/difference";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString(" application/json");
            callPayload.Headers["Accept"] = Convert.ToString(" application/json");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["array"] = ExpressionConverter.ConvertO(bodyarray);
            bodypropCount++;
            body["compare"] = ExpressionConverter.ConvertO(bodycompare);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<FindDifferenceBetweenArraysResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<FindDuplicatesInArraysResponse> FindDuplicatesInArrays([WorkflowExpression] Func<string[]> bodyarray, [WorkflowExpression] Func<string> bodykey = null)
        {
            var apiCallPath = "/array/duplicate";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["array"] = ExpressionConverter.ConvertO(bodyarray);
            if (bodykey != null)
            {
                body["key"] = ExpressionConverter.ConvertO(bodykey);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<FindDuplicatesInArraysResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<FilterAnArrayResponse> FilterAnArray([WorkflowExpression] Func<string[]> bodyarray, [WorkflowExpression] Func<bool> bodypreserveKeys)
        {
            var apiCallPath = "/array/filter";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString(" application/json");
            callPayload.Headers["Accept"] = Convert.ToString(" application/json");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["array"] = ExpressionConverter.ConvertO(bodyarray);
            bodypropCount++;
            body["preserveKeys"] = ExpressionConverter.ConvertO(bodypreserveKeys);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<FilterAnArrayResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<FirstWhereWithinAnArrayResponse> FirstWhereWithinAnArray([WorkflowExpression] Func<string[]> bodyarray, [WorkflowExpression] Func<string> bodykey, [WorkflowExpression] Func<string> bodyvalue, [WorkflowExpression] Func<bodyOperatorInput> bodyOperator = null)
        {
            var apiCallPath = "/array/first-where";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["array"] = ExpressionConverter.ConvertO(bodyarray);
            bodypropCount++;
            body["key"] = ExpressionConverter.ConvertO(bodykey);
            if (bodyOperator != null)
            {
                body["operator"] = ExpressionConverter.ConvertO(bodyOperator);
                bodypropCount++;
            }

            bodypropCount++;
            body["value"] = ExpressionConverter.ConvertO(bodyvalue);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<FirstWhereWithinAnArrayResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<FlattenAnArrayResponse> FlattenAnArray([WorkflowExpression] Func<string[]> bodyarray, [WorkflowExpression] Func<int> bodydepth = null)
        {
            var apiCallPath = "/array/flatten";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["array"] = ExpressionConverter.ConvertO(bodyarray);
            if (bodydepth != null)
            {
                body["depth"] = ExpressionConverter.ConvertO(bodydepth);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<FlattenAnArrayResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<RemoveItemFromArrayResponse> RemoveItemFromArray([WorkflowExpression] Func<string[]> bodyarray, [WorkflowExpression] Func<string> bodykey)
        {
            var apiCallPath = "/array/forget";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["array"] = ExpressionConverter.ConvertO(bodyarray);
            bodypropCount++;
            body["key"] = ExpressionConverter.ConvertO(bodykey);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<RemoveItemFromArrayResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<GroupByAnArrayKeyResponse> GroupByAnArrayKey([WorkflowExpression] Func<string[]> bodyarray, [WorkflowExpression] Func<string> bodykey)
        {
            var apiCallPath = "/array/group-by";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["array"] = ExpressionConverter.ConvertO(bodyarray);
            bodypropCount++;
            body["key"] = ExpressionConverter.ConvertO(bodykey);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GroupByAnArrayKeyResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<StandardArrayResponse> SortAnArray([WorkflowExpression] Func<string[]> bodyarray, [WorkflowExpression] Func<bodysortInput> bodysort)
        {
            var apiCallPath = "/array/sort";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString(" application/json");
            callPayload.Headers["Accept"] = Convert.ToString(" application/json");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["array"] = ExpressionConverter.ConvertO(bodyarray);
            bodypropCount++;
            body["sort"] = ExpressionConverter.ConvertO(bodysort);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<StandardArrayResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<GetUniqueItemsInAnArrayResponse> GetUniqueItemsInAnArray([WorkflowExpression] Func<string[]> bodyarray, [WorkflowExpression] Func<string> bodykey = null)
        {
            var apiCallPath = "/array/unique";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["array"] = ExpressionConverter.ConvertO(bodyarray);
            if (bodykey != null)
            {
                body["key"] = ExpressionConverter.ConvertO(bodykey);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GetUniqueItemsInAnArrayResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<AddOrSubtractFromTimeOrDatesResponse> AddOrSubtractFromTimeOrDates([WorkflowExpression] Func<bodyactionInput> bodyaction, [WorkflowExpression] Func<string> bodydatetime, [WorkflowExpression] Func<bodyOperatorInput> bodyOperator, [WorkflowExpression] Func<int> bodyvalue, [WorkflowExpression] Func<string> bodyoutputFormat = null)
        {
            var apiCallPath = "/datetime/add-or-subtract";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString(" application/json");
            callPayload.Headers["Accept"] = Convert.ToString(" application/json");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["action"] = ExpressionConverter.ConvertO(bodyaction);
            bodypropCount++;
            body["datetime"] = ExpressionConverter.ConvertO(bodydatetime);
            bodypropCount++;
            body["operator"] = ExpressionConverter.ConvertO(bodyOperator);
            if (bodyoutputFormat != null)
            {
                body["outputFormat"] = ExpressionConverter.ConvertO(bodyoutputFormat);
                bodypropCount++;
            }

            bodypropCount++;
            body["value"] = ExpressionConverter.ConvertO(bodyvalue);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<AddOrSubtractFromTimeOrDatesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<ConvertAStringToADatetimeObjectResponse> ConvertAStringToADatetimeObject([WorkflowExpression] Func<string> contentType, [WorkflowExpression] Func<string> accept, [WorkflowExpression] Func<string> bodyinputFormat, [WorkflowExpression] Func<string> bodyoutputFormat, [WorkflowExpression] Func<string> bodystring, [WorkflowExpression] Func<string> bodytimezone = null)
        {
            var apiCallPath = "/datetime/string-to-datetime";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
            callPayload.Headers["Accept"] = ExpressionConverter.Convert(accept);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["inputFormat"] = ExpressionConverter.ConvertO(bodyinputFormat);
            bodypropCount++;
            body["outputFormat"] = ExpressionConverter.ConvertO(bodyoutputFormat);
            bodypropCount++;
            body["string"] = ExpressionConverter.ConvertO(bodystring);
            if (bodytimezone != null)
            {
                body["timezone"] = ExpressionConverter.ConvertO(bodytimezone);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ConvertAStringToADatetimeObjectResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<PerformOcrOnAScannedPdfOrImageFileResponse> PerformOcrOnAScannedPdfOrImageFile([WorkflowExpression] Func<string> bodyfile, [WorkflowExpression] Func<bodyoemInput> bodyoem, [WorkflowExpression] Func<bodypsmInput> bodypsm, [WorkflowExpression] Func<bool> bodytrim, [WorkflowExpression] Func<bodytypeInput> bodytype, [WorkflowExpression] Func<string> bodylanguage = null)
        {
            var apiCallPath = "/ocr/perform-ocr";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString(" application/json");
            callPayload.Headers["Accept"] = Convert.ToString(" application/json");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["file"] = ExpressionConverter.ConvertO(bodyfile);
            if (bodylanguage != null)
            {
                if (bodylanguage != null)
                {
                    body["language"] = ExpressionConverter.ConvertO(bodylanguage);
                    bodypropCount++;
                }

                bodypropCount++;
            }
            else
            {
                body["language"] = "eng";
                bodypropCount++;
            }

            bodypropCount++;
            body["oem"] = ExpressionConverter.ConvertO(bodyoem);
            bodypropCount++;
            body["psm"] = ExpressionConverter.ConvertO(bodypsm);
            bodypropCount++;
            body["trim"] = ExpressionConverter.ConvertO(bodytrim);
            bodypropCount++;
            body["type"] = ExpressionConverter.ConvertO(bodytype);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PerformOcrOnAScannedPdfOrImageFileResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<CombineMultiplePdfFilesResponse> CombineMultiplePdfFiles([WorkflowExpression] Func<string[]> bodypdfs)
        {
            var apiCallPath = "/pdf/combine-pdf";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString(" application/json");
            callPayload.Headers["Accept"] = Convert.ToString(" application/json");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["pdfs"] = ExpressionConverter.ConvertO(bodypdfs);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CombineMultiplePdfFilesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<GetPdfMetadataInformationResponse> GetPdfMetadataInformation([WorkflowExpression] Func<string> bodypdf)
        {
            var apiCallPath = "/pdf/pdf-metadata";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString(" application/json");
            callPayload.Headers["Accept"] = Convert.ToString(" application/json");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["pdf"] = ExpressionConverter.ConvertO(bodypdf);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GetPdfMetadataInformationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<StandardArrayResponse> ConvertAPdfFileToText([WorkflowExpression] Func<bodylayoutInput> bodylayout, [WorkflowExpression] Func<string> bodypdf, [WorkflowExpression] Func<int> bodyendPage = null, [WorkflowExpression] Func<int> bodystartPage = null)
        {
            var apiCallPath = "/pdf/pdf-to-text";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString(" application/json");
            callPayload.Headers["Accept"] = Convert.ToString(" application/json");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyendPage != null)
            {
                body["endPage"] = ExpressionConverter.ConvertO(bodyendPage);
                bodypropCount++;
            }

            bodypropCount++;
            body["layout"] = ExpressionConverter.ConvertO(bodylayout);
            bodypropCount++;
            body["pdf"] = ExpressionConverter.ConvertO(bodypdf);
            if (bodystartPage != null)
            {
                body["startPage"] = ExpressionConverter.ConvertO(bodystartPage);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<StandardArrayResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<SetPasswordOnAPdfFileResponse> SetPasswordOnAPdfFile([WorkflowExpression] Func<string> contentType, [WorkflowExpression] Func<string> accept, [WorkflowExpression] Func<string> bodypassword, [WorkflowExpression] Func<string> bodypdf)
        {
            var apiCallPath = "/pdf/set-password";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
            callPayload.Headers["Accept"] = ExpressionConverter.Convert(accept);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["password"] = ExpressionConverter.ConvertO(bodypassword);
            bodypropCount++;
            body["pdf"] = ExpressionConverter.ConvertO(bodypdf);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SetPasswordOnAPdfFileResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<ReplaceTextInStringBasedOnARegularExpressionResponse> ReplaceTextInStringBasedOnARegularExpression([WorkflowExpression] Func<string> bodypattern, [WorkflowExpression] Func<string> bodyreplacement, [WorkflowExpression] Func<string> bodytext)
        {
            var apiCallPath = "/regex/regex-replace";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString(" application/json");
            callPayload.Headers["Accept"] = Convert.ToString(" application/json");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["pattern"] = ExpressionConverter.ConvertO(bodypattern);
            bodypropCount++;
            body["replacement"] = ExpressionConverter.ConvertO(bodyreplacement);
            bodypropCount++;
            body["text"] = ExpressionConverter.ConvertO(bodytext);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ReplaceTextInStringBasedOnARegularExpressionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<FindValuesFromAStringBasedOnARegularExpressionResponse> FindValuesFromAStringBasedOnARegularExpression([WorkflowExpression] Func<string> bodypattern, [WorkflowExpression] Func<string> bodytext, [WorkflowExpression] Func<int> bodygroup = null)
        {
            var apiCallPath = "/regex/regex-search";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString(" application/json");
            callPayload.Headers["Accept"] = Convert.ToString(" application/json");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodygroup != null)
            {
                body["group"] = ExpressionConverter.ConvertO(bodygroup);
                bodypropCount++;
            }

            bodypropCount++;
            body["pattern"] = ExpressionConverter.ConvertO(bodypattern);
            bodypropCount++;
            body["text"] = ExpressionConverter.ConvertO(bodytext);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<FindValuesFromAStringBasedOnARegularExpressionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<ReplaceTextInStringResponse> ReplaceTextInString([WorkflowExpression] Func<string> contentType, [WorkflowExpression] Func<string> accept, [WorkflowExpression] Func<string> bodyreplace, [WorkflowExpression] Func<string> bodysearch, [WorkflowExpression] Func<string> bodytext)
        {
            var apiCallPath = "/text/text-replace";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
            callPayload.Headers["Accept"] = ExpressionConverter.Convert(accept);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["replace"] = ExpressionConverter.ConvertO(bodyreplace);
            bodypropCount++;
            body["search"] = ExpressionConverter.ConvertO(bodysearch);
            bodypropCount++;
            body["text"] = ExpressionConverter.ConvertO(bodytext);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ReplaceTextInStringResponse>(callPayload);
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

    public class ChunkAnArrayResponse
    {
        [JsonProperty("array")]
        public string[] Array { get; set; }
    }

    public class CombineArrayResponse
    {
        [JsonProperty("array")]
        public string[] Array { get; set; }
    }

    public class CheckIfArrayContainAValueResponse
    {
        [JsonProperty("contains")]
        public bool Contains { get; set; }
    }

    public class FindDifferenceBetweenArraysResponse
    {
        [JsonProperty("array")]
        public string[] Array { get; set; }
    }

    public class FindDuplicatesInArraysResponse
    {
        [JsonProperty("array")]
        public string[] Array { get; set; }
    }

    public class FilterAnArrayResponse
    {
        [JsonProperty("array")]
        public string[] Array { get; set; }
    }

    public class FirstWhereWithinAnArrayResponse
    {
        [JsonProperty("array")]
        public string[] Array { get; set; }
    }

    public enum bodyOperatorInput
    {
        Add,
        Subtract
    }

    public class FlattenAnArrayResponse
    {
        [JsonProperty("array")]
        public string[] Array { get; set; }
    }

    public class RemoveItemFromArrayResponse
    {
        [JsonProperty("array")]
        public string[] Array { get; set; }
    }

    public class GroupByAnArrayKeyResponse
    {
        [JsonProperty("array")]
        public string[] Array { get; set; }
    }

    public class StandardArrayResponse
    {
        [JsonProperty("array")]
        public string[] ResultArray { get; set; }
    }

    public enum bodysortInput
    {
        Ascending,
        Descending
    }

    public class GetUniqueItemsInAnArrayResponse
    {
        [JsonProperty("array")]
        public string[] Array { get; set; }
    }

    public class AddOrSubtractFromTimeOrDatesResponse
    {
        [JsonProperty("datetime")]
        public string Datetime { get; set; }
    }

    public enum bodyactionInput
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

    public class ConvertAStringToADatetimeObjectResponse
    {
        [JsonProperty("datetime")]
        public string Datetime { get; set; }
    }

    public class PerformOcrOnAScannedPdfOrImageFileResponse
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public enum bodyoemInput
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1
    }

    public enum bodypsmInput
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3,
        [EnumMember(Value = "4")]
        _4,
        [EnumMember(Value = "5")]
        _5,
        [EnumMember(Value = "6")]
        _6,
        [EnumMember(Value = "7")]
        _7,
        [EnumMember(Value = "8")]
        _8,
        [EnumMember(Value = "9")]
        _9,
        [EnumMember(Value = "10")]
        _10,
        [EnumMember(Value = "11")]
        _11,
        [EnumMember(Value = "12")]
        _12,
        [EnumMember(Value = "13")]
        _13
    }

    public enum bodytypeInput
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

    public enum bodylayoutInput
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

    public class ReplaceTextInStringBasedOnARegularExpressionResponse
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class FindValuesFromAStringBasedOnARegularExpressionResponse
    {
        [JsonProperty("values")]
        public string[] Values { get; set; }
    }

    public class ReplaceTextInStringResponse
    {
        [JsonProperty("text")]
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