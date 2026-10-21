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
        public IBodyWorkflowAction<CalculateAverageResponse> CalculateAverage(Expression<Func<string[]>> bodyarray, Expression<Func<string>> bodykey)
        {
            var __workflow_bodyarray = WorkflowExpression.Compile(bodyarray, nameof(bodyarray), required: true);
            var __workflow_bodykey = WorkflowExpression.Compile(bodykey, nameof(bodykey), required: true);
            return new DeferredBodyAction<CalculateAverageResponse>(() =>
            {
                var apiCallPath = "/array/calculate-average";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["array"] = ExpressionConverter.ConvertO(__workflow_bodyarray);
                bodypropCount++;
                body["key"] = ExpressionConverter.ConvertO(__workflow_bodykey);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CalculateAverageResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<ChunkAnArrayResponse> ChunkAnArray(Expression<Func<string[]>> bodyarray, Expression<Func<int>> bodysize)
        {
            var __workflow_bodyarray = WorkflowExpression.Compile(bodyarray, nameof(bodyarray), required: true);
            var __workflow_bodysize = WorkflowExpression.Compile(bodysize, nameof(bodysize), required: true);
            return new DeferredBodyAction<ChunkAnArrayResponse>(() =>
            {
                var apiCallPath = "/array/chunk";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/json");
                callPayload.Headers["Accept"] = Convert.ToString(" application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["array"] = ExpressionConverter.ConvertO(__workflow_bodyarray);
                bodypropCount++;
                body["size"] = ExpressionConverter.ConvertO(__workflow_bodysize);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ChunkAnArrayResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<CombineArrayResponse> CombineArray(Expression<Func<string>> contentType, Expression<Func<string>> accept, Expression<Func<string[]>> bodykeys, Expression<Func<string[]>> bodyvalues)
        {
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: true);
            var __workflow_accept = WorkflowExpression.Compile(accept, nameof(accept), required: true);
            var __workflow_bodykeys = WorkflowExpression.Compile(bodykeys, nameof(bodykeys), required: true);
            var __workflow_bodyvalues = WorkflowExpression.Compile(bodyvalues, nameof(bodyvalues), required: true);
            return new DeferredBodyAction<CombineArrayResponse>(() =>
            {
                var apiCallPath = "/array/combine";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Headers["Accept"] = ExpressionConverter.Convert(__workflow_accept);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["keys"] = ExpressionConverter.ConvertO(__workflow_bodykeys);
                bodypropCount++;
                body["values"] = ExpressionConverter.ConvertO(__workflow_bodyvalues);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CombineArrayResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<CheckIfArrayContainAValueResponse> CheckIfArrayContainAValue(Expression<Func<string[]>> bodyarray, Expression<Func<string>> bodykey, Expression<Func<string>> bodysearch)
        {
            var __workflow_bodyarray = WorkflowExpression.Compile(bodyarray, nameof(bodyarray), required: true);
            var __workflow_bodykey = WorkflowExpression.Compile(bodykey, nameof(bodykey), required: true);
            var __workflow_bodysearch = WorkflowExpression.Compile(bodysearch, nameof(bodysearch), required: true);
            return new DeferredBodyAction<CheckIfArrayContainAValueResponse>(() =>
            {
                var apiCallPath = "/array/contains";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["array"] = ExpressionConverter.ConvertO(__workflow_bodyarray);
                bodypropCount++;
                body["key"] = ExpressionConverter.ConvertO(__workflow_bodykey);
                bodypropCount++;
                body["search"] = ExpressionConverter.ConvertO(__workflow_bodysearch);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CheckIfArrayContainAValueResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<FindDifferenceBetweenArraysResponse> FindDifferenceBetweenArrays(Expression<Func<string[]>> bodyarray, Expression<Func<string[]>> bodycompare)
        {
            var __workflow_bodyarray = WorkflowExpression.Compile(bodyarray, nameof(bodyarray), required: true);
            var __workflow_bodycompare = WorkflowExpression.Compile(bodycompare, nameof(bodycompare), required: true);
            return new DeferredBodyAction<FindDifferenceBetweenArraysResponse>(() =>
            {
                var apiCallPath = "/array/difference";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/json");
                callPayload.Headers["Accept"] = Convert.ToString(" application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["array"] = ExpressionConverter.ConvertO(__workflow_bodyarray);
                bodypropCount++;
                body["compare"] = ExpressionConverter.ConvertO(__workflow_bodycompare);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<FindDifferenceBetweenArraysResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<FindDuplicatesInArraysResponse> FindDuplicatesInArrays(Expression<Func<string[]>> bodyarray, Expression<Func<string>> bodykey = null)
        {
            var __workflow_bodyarray = WorkflowExpression.Compile(bodyarray, nameof(bodyarray), required: true);
            var __workflow_bodykey = WorkflowExpression.Compile(bodykey, nameof(bodykey), required: false);
            return new DeferredBodyAction<FindDuplicatesInArraysResponse>(() =>
            {
                var apiCallPath = "/array/duplicate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["array"] = ExpressionConverter.ConvertO(__workflow_bodyarray);
                if (__workflow_bodykey != null)
                {
                    body["key"] = ExpressionConverter.ConvertO(__workflow_bodykey);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<FindDuplicatesInArraysResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<FilterAnArrayResponse> FilterAnArray(Expression<Func<string[]>> bodyarray, Expression<Func<bool>> bodypreserveKeys)
        {
            var __workflow_bodyarray = WorkflowExpression.Compile(bodyarray, nameof(bodyarray), required: true);
            var __workflow_bodypreserveKeys = WorkflowExpression.Compile(bodypreserveKeys, nameof(bodypreserveKeys), required: true);
            return new DeferredBodyAction<FilterAnArrayResponse>(() =>
            {
                var apiCallPath = "/array/filter";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/json");
                callPayload.Headers["Accept"] = Convert.ToString(" application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["array"] = ExpressionConverter.ConvertO(__workflow_bodyarray);
                bodypropCount++;
                body["preserveKeys"] = ExpressionConverter.ConvertO(__workflow_bodypreserveKeys);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<FilterAnArrayResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<FirstWhereWithinAnArrayResponse> FirstWhereWithinAnArray(Expression<Func<string[]>> bodyarray, Expression<Func<string>> bodykey, Expression<Func<string>> bodyvalue, Expression<Func<bodyOperatorInput>> bodyOperator = null)
        {
            var __workflow_bodyarray = WorkflowExpression.Compile(bodyarray, nameof(bodyarray), required: true);
            var __workflow_bodykey = WorkflowExpression.Compile(bodykey, nameof(bodykey), required: true);
            var __workflow_bodyvalue = WorkflowExpression.Compile(bodyvalue, nameof(bodyvalue), required: true);
            var __workflow_bodyOperator = WorkflowExpression.Compile(bodyOperator, nameof(bodyOperator), required: false);
            return new DeferredBodyAction<FirstWhereWithinAnArrayResponse>(() =>
            {
                var apiCallPath = "/array/first-where";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["array"] = ExpressionConverter.ConvertO(__workflow_bodyarray);
                bodypropCount++;
                body["key"] = ExpressionConverter.ConvertO(__workflow_bodykey);
                if (__workflow_bodyOperator != null)
                {
                    body["operator"] = ExpressionConverter.ConvertO(__workflow_bodyOperator);
                    bodypropCount++;
                }

                bodypropCount++;
                body["value"] = ExpressionConverter.ConvertO(__workflow_bodyvalue);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<FirstWhereWithinAnArrayResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<FlattenAnArrayResponse> FlattenAnArray(Expression<Func<string[]>> bodyarray, Expression<Func<int>> bodydepth = null)
        {
            var __workflow_bodyarray = WorkflowExpression.Compile(bodyarray, nameof(bodyarray), required: true);
            var __workflow_bodydepth = WorkflowExpression.Compile(bodydepth, nameof(bodydepth), required: false);
            return new DeferredBodyAction<FlattenAnArrayResponse>(() =>
            {
                var apiCallPath = "/array/flatten";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["array"] = ExpressionConverter.ConvertO(__workflow_bodyarray);
                if (__workflow_bodydepth != null)
                {
                    body["depth"] = ExpressionConverter.ConvertO(__workflow_bodydepth);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<FlattenAnArrayResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<RemoveItemFromArrayResponse> RemoveItemFromArray(Expression<Func<string[]>> bodyarray, Expression<Func<string>> bodykey)
        {
            var __workflow_bodyarray = WorkflowExpression.Compile(bodyarray, nameof(bodyarray), required: true);
            var __workflow_bodykey = WorkflowExpression.Compile(bodykey, nameof(bodykey), required: true);
            return new DeferredBodyAction<RemoveItemFromArrayResponse>(() =>
            {
                var apiCallPath = "/array/forget";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["array"] = ExpressionConverter.ConvertO(__workflow_bodyarray);
                bodypropCount++;
                body["key"] = ExpressionConverter.ConvertO(__workflow_bodykey);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<RemoveItemFromArrayResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<GroupByAnArrayKeyResponse> GroupByAnArrayKey(Expression<Func<string[]>> bodyarray, Expression<Func<string>> bodykey)
        {
            var __workflow_bodyarray = WorkflowExpression.Compile(bodyarray, nameof(bodyarray), required: true);
            var __workflow_bodykey = WorkflowExpression.Compile(bodykey, nameof(bodykey), required: true);
            return new DeferredBodyAction<GroupByAnArrayKeyResponse>(() =>
            {
                var apiCallPath = "/array/group-by";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["array"] = ExpressionConverter.ConvertO(__workflow_bodyarray);
                bodypropCount++;
                body["key"] = ExpressionConverter.ConvertO(__workflow_bodykey);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GroupByAnArrayKeyResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<StandardArrayResponse> SortAnArray(Expression<Func<string[]>> bodyarray, Expression<Func<bodysortInput>> bodysort)
        {
            var __workflow_bodyarray = WorkflowExpression.Compile(bodyarray, nameof(bodyarray), required: true);
            var __workflow_bodysort = WorkflowExpression.Compile(bodysort, nameof(bodysort), required: true);
            return new DeferredBodyAction<StandardArrayResponse>(() =>
            {
                var apiCallPath = "/array/sort";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/json");
                callPayload.Headers["Accept"] = Convert.ToString(" application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["array"] = ExpressionConverter.ConvertO(__workflow_bodyarray);
                bodypropCount++;
                body["sort"] = ExpressionConverter.ConvertO(__workflow_bodysort);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<StandardArrayResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<GetUniqueItemsInAnArrayResponse> GetUniqueItemsInAnArray(Expression<Func<string[]>> bodyarray, Expression<Func<string>> bodykey = null)
        {
            var __workflow_bodyarray = WorkflowExpression.Compile(bodyarray, nameof(bodyarray), required: true);
            var __workflow_bodykey = WorkflowExpression.Compile(bodykey, nameof(bodykey), required: false);
            return new DeferredBodyAction<GetUniqueItemsInAnArrayResponse>(() =>
            {
                var apiCallPath = "/array/unique";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["array"] = ExpressionConverter.ConvertO(__workflow_bodyarray);
                if (__workflow_bodykey != null)
                {
                    body["key"] = ExpressionConverter.ConvertO(__workflow_bodykey);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GetUniqueItemsInAnArrayResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<AddOrSubtractFromTimeOrDatesResponse> AddOrSubtractFromTimeOrDates(Expression<Func<bodyactionInput>> bodyaction, Expression<Func<string>> bodydatetime, Expression<Func<bodyOperatorInput>> bodyOperator, Expression<Func<int>> bodyvalue, Expression<Func<string>> bodyoutputFormat = null)
        {
            var __workflow_bodyaction = WorkflowExpression.Compile(bodyaction, nameof(bodyaction), required: true);
            var __workflow_bodydatetime = WorkflowExpression.Compile(bodydatetime, nameof(bodydatetime), required: true);
            var __workflow_bodyOperator = WorkflowExpression.Compile(bodyOperator, nameof(bodyOperator), required: true);
            var __workflow_bodyvalue = WorkflowExpression.Compile(bodyvalue, nameof(bodyvalue), required: true);
            var __workflow_bodyoutputFormat = WorkflowExpression.Compile(bodyoutputFormat, nameof(bodyoutputFormat), required: false);
            return new DeferredBodyAction<AddOrSubtractFromTimeOrDatesResponse>(() =>
            {
                var apiCallPath = "/datetime/add-or-subtract";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/json");
                callPayload.Headers["Accept"] = Convert.ToString(" application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["action"] = ExpressionConverter.ConvertO(__workflow_bodyaction);
                bodypropCount++;
                body["datetime"] = ExpressionConverter.ConvertO(__workflow_bodydatetime);
                bodypropCount++;
                body["operator"] = ExpressionConverter.ConvertO(__workflow_bodyOperator);
                if (__workflow_bodyoutputFormat != null)
                {
                    body["outputFormat"] = ExpressionConverter.ConvertO(__workflow_bodyoutputFormat);
                    bodypropCount++;
                }

                bodypropCount++;
                body["value"] = ExpressionConverter.ConvertO(__workflow_bodyvalue);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<AddOrSubtractFromTimeOrDatesResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<ConvertAStringToADatetimeObjectResponse> ConvertAStringToADatetimeObject(Expression<Func<string>> contentType, Expression<Func<string>> accept, Expression<Func<string>> bodyinputFormat, Expression<Func<string>> bodyoutputFormat, Expression<Func<string>> bodystring, Expression<Func<string>> bodytimezone = null)
        {
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: true);
            var __workflow_accept = WorkflowExpression.Compile(accept, nameof(accept), required: true);
            var __workflow_bodyinputFormat = WorkflowExpression.Compile(bodyinputFormat, nameof(bodyinputFormat), required: true);
            var __workflow_bodyoutputFormat = WorkflowExpression.Compile(bodyoutputFormat, nameof(bodyoutputFormat), required: true);
            var __workflow_bodystring = WorkflowExpression.Compile(bodystring, nameof(bodystring), required: true);
            var __workflow_bodytimezone = WorkflowExpression.Compile(bodytimezone, nameof(bodytimezone), required: false);
            return new DeferredBodyAction<ConvertAStringToADatetimeObjectResponse>(() =>
            {
                var apiCallPath = "/datetime/string-to-datetime";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Headers["Accept"] = ExpressionConverter.Convert(__workflow_accept);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["inputFormat"] = ExpressionConverter.ConvertO(__workflow_bodyinputFormat);
                bodypropCount++;
                body["outputFormat"] = ExpressionConverter.ConvertO(__workflow_bodyoutputFormat);
                bodypropCount++;
                body["string"] = ExpressionConverter.ConvertO(__workflow_bodystring);
                if (__workflow_bodytimezone != null)
                {
                    body["timezone"] = ExpressionConverter.ConvertO(__workflow_bodytimezone);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ConvertAStringToADatetimeObjectResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<PerformOcrOnAScannedPdfOrImageFileResponse> PerformOcrOnAScannedPdfOrImageFile(Expression<Func<string>> bodyfile, Expression<Func<bodyoemInput>> bodyoem, Expression<Func<bodypsmInput>> bodypsm, Expression<Func<bool>> bodytrim, Expression<Func<bodytypeInput>> bodytype, Expression<Func<string>> bodylanguage = null)
        {
            var __workflow_bodyfile = WorkflowExpression.Compile(bodyfile, nameof(bodyfile), required: true);
            var __workflow_bodyoem = WorkflowExpression.Compile(bodyoem, nameof(bodyoem), required: true);
            var __workflow_bodypsm = WorkflowExpression.Compile(bodypsm, nameof(bodypsm), required: true);
            var __workflow_bodytrim = WorkflowExpression.Compile(bodytrim, nameof(bodytrim), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: true);
            var __workflow_bodylanguage = WorkflowExpression.Compile(bodylanguage, nameof(bodylanguage), required: false);
            return new DeferredBodyAction<PerformOcrOnAScannedPdfOrImageFileResponse>(() =>
            {
                var apiCallPath = "/ocr/perform-ocr";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/json");
                callPayload.Headers["Accept"] = Convert.ToString(" application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["file"] = ExpressionConverter.ConvertO(__workflow_bodyfile);
                if (__workflow_bodylanguage != null)
                {
                    if (__workflow_bodylanguage != null)
                    {
                        body["language"] = ExpressionConverter.ConvertO(__workflow_bodylanguage);
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
                body["oem"] = ExpressionConverter.ConvertO(__workflow_bodyoem);
                bodypropCount++;
                body["psm"] = ExpressionConverter.ConvertO(__workflow_bodypsm);
                bodypropCount++;
                body["trim"] = ExpressionConverter.ConvertO(__workflow_bodytrim);
                bodypropCount++;
                body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PerformOcrOnAScannedPdfOrImageFileResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<CombineMultiplePdfFilesResponse> CombineMultiplePdfFiles(Expression<Func<string[]>> bodypdfs)
        {
            var __workflow_bodypdfs = WorkflowExpression.Compile(bodypdfs, nameof(bodypdfs), required: true);
            return new DeferredBodyAction<CombineMultiplePdfFilesResponse>(() =>
            {
                var apiCallPath = "/pdf/combine-pdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/json");
                callPayload.Headers["Accept"] = Convert.ToString(" application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["pdfs"] = ExpressionConverter.ConvertO(__workflow_bodypdfs);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CombineMultiplePdfFilesResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<GetPdfMetadataInformationResponse> GetPdfMetadataInformation(Expression<Func<string>> bodypdf)
        {
            var __workflow_bodypdf = WorkflowExpression.Compile(bodypdf, nameof(bodypdf), required: true);
            return new DeferredBodyAction<GetPdfMetadataInformationResponse>(() =>
            {
                var apiCallPath = "/pdf/pdf-metadata";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/json");
                callPayload.Headers["Accept"] = Convert.ToString(" application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["pdf"] = ExpressionConverter.ConvertO(__workflow_bodypdf);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GetPdfMetadataInformationResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<StandardArrayResponse> ConvertAPdfFileToText(Expression<Func<bodylayoutInput>> bodylayout, Expression<Func<string>> bodypdf, Expression<Func<int>> bodyendPage = null, Expression<Func<int>> bodystartPage = null)
        {
            var __workflow_bodylayout = WorkflowExpression.Compile(bodylayout, nameof(bodylayout), required: true);
            var __workflow_bodypdf = WorkflowExpression.Compile(bodypdf, nameof(bodypdf), required: true);
            var __workflow_bodyendPage = WorkflowExpression.Compile(bodyendPage, nameof(bodyendPage), required: false);
            var __workflow_bodystartPage = WorkflowExpression.Compile(bodystartPage, nameof(bodystartPage), required: false);
            return new DeferredBodyAction<StandardArrayResponse>(() =>
            {
                var apiCallPath = "/pdf/pdf-to-text";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/json");
                callPayload.Headers["Accept"] = Convert.ToString(" application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyendPage != null)
                {
                    body["endPage"] = ExpressionConverter.ConvertO(__workflow_bodyendPage);
                    bodypropCount++;
                }

                bodypropCount++;
                body["layout"] = ExpressionConverter.ConvertO(__workflow_bodylayout);
                bodypropCount++;
                body["pdf"] = ExpressionConverter.ConvertO(__workflow_bodypdf);
                if (__workflow_bodystartPage != null)
                {
                    body["startPage"] = ExpressionConverter.ConvertO(__workflow_bodystartPage);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<StandardArrayResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<SetPasswordOnAPdfFileResponse> SetPasswordOnAPdfFile(Expression<Func<string>> contentType, Expression<Func<string>> accept, Expression<Func<string>> bodypassword, Expression<Func<string>> bodypdf)
        {
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: true);
            var __workflow_accept = WorkflowExpression.Compile(accept, nameof(accept), required: true);
            var __workflow_bodypassword = WorkflowExpression.Compile(bodypassword, nameof(bodypassword), required: true);
            var __workflow_bodypdf = WorkflowExpression.Compile(bodypdf, nameof(bodypdf), required: true);
            return new DeferredBodyAction<SetPasswordOnAPdfFileResponse>(() =>
            {
                var apiCallPath = "/pdf/set-password";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Headers["Accept"] = ExpressionConverter.Convert(__workflow_accept);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["password"] = ExpressionConverter.ConvertO(__workflow_bodypassword);
                bodypropCount++;
                body["pdf"] = ExpressionConverter.ConvertO(__workflow_bodypdf);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SetPasswordOnAPdfFileResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<ReplaceTextInStringBasedOnARegularExpressionResponse> ReplaceTextInStringBasedOnARegularExpression(Expression<Func<string>> bodypattern, Expression<Func<string>> bodyreplacement, Expression<Func<string>> bodytext)
        {
            var __workflow_bodypattern = WorkflowExpression.Compile(bodypattern, nameof(bodypattern), required: true);
            var __workflow_bodyreplacement = WorkflowExpression.Compile(bodyreplacement, nameof(bodyreplacement), required: true);
            var __workflow_bodytext = WorkflowExpression.Compile(bodytext, nameof(bodytext), required: true);
            return new DeferredBodyAction<ReplaceTextInStringBasedOnARegularExpressionResponse>(() =>
            {
                var apiCallPath = "/regex/regex-replace";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/json");
                callPayload.Headers["Accept"] = Convert.ToString(" application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["pattern"] = ExpressionConverter.ConvertO(__workflow_bodypattern);
                bodypropCount++;
                body["replacement"] = ExpressionConverter.ConvertO(__workflow_bodyreplacement);
                bodypropCount++;
                body["text"] = ExpressionConverter.ConvertO(__workflow_bodytext);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ReplaceTextInStringBasedOnARegularExpressionResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<FindValuesFromAStringBasedOnARegularExpressionResponse> FindValuesFromAStringBasedOnARegularExpression(Expression<Func<string>> bodypattern, Expression<Func<string>> bodytext, Expression<Func<int>> bodygroup = null)
        {
            var __workflow_bodypattern = WorkflowExpression.Compile(bodypattern, nameof(bodypattern), required: true);
            var __workflow_bodytext = WorkflowExpression.Compile(bodytext, nameof(bodytext), required: true);
            var __workflow_bodygroup = WorkflowExpression.Compile(bodygroup, nameof(bodygroup), required: false);
            return new DeferredBodyAction<FindValuesFromAStringBasedOnARegularExpressionResponse>(() =>
            {
                var apiCallPath = "/regex/regex-search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/json");
                callPayload.Headers["Accept"] = Convert.ToString(" application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodygroup != null)
                {
                    body["group"] = ExpressionConverter.ConvertO(__workflow_bodygroup);
                    bodypropCount++;
                }

                bodypropCount++;
                body["pattern"] = ExpressionConverter.ConvertO(__workflow_bodypattern);
                bodypropCount++;
                body["text"] = ExpressionConverter.ConvertO(__workflow_bodytext);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<FindValuesFromAStringBasedOnARegularExpressionResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<ReplaceTextInStringResponse> ReplaceTextInString(Expression<Func<string>> contentType, Expression<Func<string>> accept, Expression<Func<string>> bodyreplace, Expression<Func<string>> bodysearch, Expression<Func<string>> bodytext)
        {
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: true);
            var __workflow_accept = WorkflowExpression.Compile(accept, nameof(accept), required: true);
            var __workflow_bodyreplace = WorkflowExpression.Compile(bodyreplace, nameof(bodyreplace), required: true);
            var __workflow_bodysearch = WorkflowExpression.Compile(bodysearch, nameof(bodysearch), required: true);
            var __workflow_bodytext = WorkflowExpression.Compile(bodytext, nameof(bodytext), required: true);
            return new DeferredBodyAction<ReplaceTextInStringResponse>(() =>
            {
                var apiCallPath = "/text/text-replace";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Headers["Accept"] = ExpressionConverter.Convert(__workflow_accept);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["replace"] = ExpressionConverter.ConvertO(__workflow_bodyreplace);
                bodypropCount++;
                body["search"] = ExpressionConverter.ConvertO(__workflow_bodysearch);
                bodypropCount++;
                body["text"] = ExpressionConverter.ConvertO(__workflow_bodytext);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ReplaceTextInStringResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyoemInput
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
