//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Optiapi
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OptiapiActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<CalculateAverageResponse> CalculateAverage([WorkflowExpression] Func<string[]> bodyarray, [WorkflowExpression] Func<string> bodykey)
        {
            SourceExpression.Validate(bodyarray, nameof(bodyarray), required: true);
            SourceExpression.Validate(bodykey, nameof(bodykey), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/array/calculate-average";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["array"] = SourceExpressionConverter.ConvertToken(bodyarray);
                bodypropCount++;
                body["key"] = SourceExpressionConverter.ConvertToken(bodykey);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CalculateAverageResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<ChunkAnArrayResponse> ChunkAnArray([WorkflowExpression] Func<string[]> bodyarray, [WorkflowExpression] Func<int> bodysize)
        {
            SourceExpression.Validate(bodyarray, nameof(bodyarray), required: true);
            SourceExpression.Validate(bodysize, nameof(bodysize), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/array/chunk";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/json");
                callPayload.Headers["Accept"] = Convert.ToString(" application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["array"] = SourceExpressionConverter.ConvertToken(bodyarray);
                bodypropCount++;
                body["size"] = SourceExpressionConverter.ConvertToken(bodysize);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ChunkAnArrayResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<CombineArrayResponse> CombineArray([WorkflowExpression] Func<string> contentType, [WorkflowExpression] Func<string> accept, [WorkflowExpression] Func<string[]> bodykeys, [WorkflowExpression] Func<string[]> bodyvalues)
        {
            SourceExpression.Validate(contentType, nameof(contentType), required: true);
            SourceExpression.Validate(accept, nameof(accept), required: true);
            SourceExpression.Validate(bodykeys, nameof(bodykeys), required: true);
            SourceExpression.Validate(bodyvalues, nameof(bodyvalues), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/array/combine";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = SourceExpressionConverter.ConvertO(contentType);
                callPayload.Headers["Accept"] = SourceExpressionConverter.ConvertO(accept);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["keys"] = SourceExpressionConverter.ConvertToken(bodykeys);
                bodypropCount++;
                body["values"] = SourceExpressionConverter.ConvertToken(bodyvalues);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CombineArrayResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<CheckIfArrayContainAValueResponse> CheckIfArrayContainAValue([WorkflowExpression] Func<string[]> bodyarray, [WorkflowExpression] Func<string> bodykey, [WorkflowExpression] Func<string> bodysearch)
        {
            SourceExpression.Validate(bodyarray, nameof(bodyarray), required: true);
            SourceExpression.Validate(bodykey, nameof(bodykey), required: true);
            SourceExpression.Validate(bodysearch, nameof(bodysearch), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/array/contains";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["array"] = SourceExpressionConverter.ConvertToken(bodyarray);
                bodypropCount++;
                body["key"] = SourceExpressionConverter.ConvertToken(bodykey);
                bodypropCount++;
                body["search"] = SourceExpressionConverter.ConvertToken(bodysearch);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CheckIfArrayContainAValueResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<FindDifferenceBetweenArraysResponse> FindDifferenceBetweenArrays([WorkflowExpression] Func<string[]> bodyarray, [WorkflowExpression] Func<string[]> bodycompare)
        {
            SourceExpression.Validate(bodyarray, nameof(bodyarray), required: true);
            SourceExpression.Validate(bodycompare, nameof(bodycompare), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/array/difference";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/json");
                callPayload.Headers["Accept"] = Convert.ToString(" application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["array"] = SourceExpressionConverter.ConvertToken(bodyarray);
                bodypropCount++;
                body["compare"] = SourceExpressionConverter.ConvertToken(bodycompare);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<FindDifferenceBetweenArraysResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<FindDuplicatesInArraysResponse> FindDuplicatesInArrays([WorkflowExpression] Func<string[]> bodyarray, [WorkflowExpression] Func<string> bodykey = null)
        {
            SourceExpression.Validate(bodyarray, nameof(bodyarray), required: true);
            SourceExpression.Validate(bodykey, nameof(bodykey), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/array/duplicate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["array"] = SourceExpressionConverter.ConvertToken(bodyarray);
                if (bodykey != null)
                {
                    body["key"] = SourceExpressionConverter.ConvertToken(bodykey);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<FindDuplicatesInArraysResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<FilterAnArrayResponse> FilterAnArray([WorkflowExpression] Func<string[]> bodyarray, [WorkflowExpression] Func<bool> bodypreserveKeys)
        {
            SourceExpression.Validate(bodyarray, nameof(bodyarray), required: true);
            SourceExpression.Validate(bodypreserveKeys, nameof(bodypreserveKeys), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/array/filter";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/json");
                callPayload.Headers["Accept"] = Convert.ToString(" application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["array"] = SourceExpressionConverter.ConvertToken(bodyarray);
                bodypropCount++;
                body["preserveKeys"] = SourceExpressionConverter.ConvertToken(bodypreserveKeys);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<FilterAnArrayResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<FirstWhereWithinAnArrayResponse> FirstWhereWithinAnArray([WorkflowExpression] Func<string[]> bodyarray, [WorkflowExpression] Func<string> bodykey, [WorkflowExpression] Func<string> bodyvalue, [WorkflowExpression] Func<bodyOperatorInput> bodyOperator = null)
        {
            SourceExpression.Validate(bodyarray, nameof(bodyarray), required: true);
            SourceExpression.Validate(bodykey, nameof(bodykey), required: true);
            SourceExpression.Validate(bodyvalue, nameof(bodyvalue), required: true);
            SourceExpression.Validate(bodyOperator, nameof(bodyOperator), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/array/first-where";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["array"] = SourceExpressionConverter.ConvertToken(bodyarray);
                bodypropCount++;
                body["key"] = SourceExpressionConverter.ConvertToken(bodykey);
                if (bodyOperator != null)
                {
                    body["operator"] = SourceExpressionConverter.Convert(bodyOperator);
                    bodypropCount++;
                }

                bodypropCount++;
                body["value"] = SourceExpressionConverter.ConvertToken(bodyvalue);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<FirstWhereWithinAnArrayResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<FlattenAnArrayResponse> FlattenAnArray([WorkflowExpression] Func<string[]> bodyarray, [WorkflowExpression] Func<int> bodydepth = null)
        {
            SourceExpression.Validate(bodyarray, nameof(bodyarray), required: true);
            SourceExpression.Validate(bodydepth, nameof(bodydepth), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/array/flatten";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["array"] = SourceExpressionConverter.ConvertToken(bodyarray);
                if (bodydepth != null)
                {
                    body["depth"] = SourceExpressionConverter.ConvertToken(bodydepth);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<FlattenAnArrayResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<RemoveItemFromArrayResponse> RemoveItemFromArray([WorkflowExpression] Func<string[]> bodyarray, [WorkflowExpression] Func<string> bodykey)
        {
            SourceExpression.Validate(bodyarray, nameof(bodyarray), required: true);
            SourceExpression.Validate(bodykey, nameof(bodykey), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/array/forget";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["array"] = SourceExpressionConverter.ConvertToken(bodyarray);
                bodypropCount++;
                body["key"] = SourceExpressionConverter.ConvertToken(bodykey);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<RemoveItemFromArrayResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<GroupByAnArrayKeyResponse> GroupByAnArrayKey([WorkflowExpression] Func<string[]> bodyarray, [WorkflowExpression] Func<string> bodykey)
        {
            SourceExpression.Validate(bodyarray, nameof(bodyarray), required: true);
            SourceExpression.Validate(bodykey, nameof(bodykey), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/array/group-by";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["array"] = SourceExpressionConverter.ConvertToken(bodyarray);
                bodypropCount++;
                body["key"] = SourceExpressionConverter.ConvertToken(bodykey);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GroupByAnArrayKeyResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<StandardArrayResponse> SortAnArray([WorkflowExpression] Func<string[]> bodyarray, [WorkflowExpression] Func<bodysortInput> bodysort)
        {
            SourceExpression.Validate(bodyarray, nameof(bodyarray), required: true);
            SourceExpression.Validate(bodysort, nameof(bodysort), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/array/sort";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/json");
                callPayload.Headers["Accept"] = Convert.ToString(" application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["array"] = SourceExpressionConverter.ConvertToken(bodyarray);
                bodypropCount++;
                body["sort"] = SourceExpressionConverter.Convert(bodysort);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<StandardArrayResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<GetUniqueItemsInAnArrayResponse> GetUniqueItemsInAnArray([WorkflowExpression] Func<string[]> bodyarray, [WorkflowExpression] Func<string> bodykey = null)
        {
            SourceExpression.Validate(bodyarray, nameof(bodyarray), required: true);
            SourceExpression.Validate(bodykey, nameof(bodykey), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/array/unique";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["array"] = SourceExpressionConverter.ConvertToken(bodyarray);
                if (bodykey != null)
                {
                    body["key"] = SourceExpressionConverter.ConvertToken(bodykey);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetUniqueItemsInAnArrayResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<AddOrSubtractFromTimeOrDatesResponse> AddOrSubtractFromTimeOrDates([WorkflowExpression] Func<bodyactionInput> bodyaction, [WorkflowExpression] Func<string> bodydatetime, [WorkflowExpression] Func<bodyOperatorInput> bodyOperator, [WorkflowExpression] Func<int> bodyvalue, [WorkflowExpression] Func<string> bodyoutputFormat = null)
        {
            SourceExpression.Validate(bodyaction, nameof(bodyaction), required: true);
            SourceExpression.Validate(bodydatetime, nameof(bodydatetime), required: true);
            SourceExpression.Validate(bodyOperator, nameof(bodyOperator), required: true);
            SourceExpression.Validate(bodyvalue, nameof(bodyvalue), required: true);
            SourceExpression.Validate(bodyoutputFormat, nameof(bodyoutputFormat), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/datetime/add-or-subtract";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/json");
                callPayload.Headers["Accept"] = Convert.ToString(" application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["action"] = SourceExpressionConverter.Convert(bodyaction);
                bodypropCount++;
                body["datetime"] = SourceExpressionConverter.ConvertToken(bodydatetime);
                bodypropCount++;
                body["operator"] = SourceExpressionConverter.Convert(bodyOperator);
                if (bodyoutputFormat != null)
                {
                    body["outputFormat"] = SourceExpressionConverter.ConvertToken(bodyoutputFormat);
                    bodypropCount++;
                }

                bodypropCount++;
                body["value"] = SourceExpressionConverter.ConvertToken(bodyvalue);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AddOrSubtractFromTimeOrDatesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<ConvertAStringToADatetimeObjectResponse> ConvertAStringToADatetimeObject([WorkflowExpression] Func<string> contentType, [WorkflowExpression] Func<string> accept, [WorkflowExpression] Func<string> bodyinputFormat, [WorkflowExpression] Func<string> bodyoutputFormat, [WorkflowExpression] Func<string> bodyString, [WorkflowExpression] Func<string> bodytimezone = null)
        {
            SourceExpression.Validate(contentType, nameof(contentType), required: true);
            SourceExpression.Validate(accept, nameof(accept), required: true);
            SourceExpression.Validate(bodyinputFormat, nameof(bodyinputFormat), required: true);
            SourceExpression.Validate(bodyoutputFormat, nameof(bodyoutputFormat), required: true);
            SourceExpression.Validate(bodyString, nameof(bodyString), required: true);
            SourceExpression.Validate(bodytimezone, nameof(bodytimezone), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/datetime/string-to-datetime";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = SourceExpressionConverter.ConvertO(contentType);
                callPayload.Headers["Accept"] = SourceExpressionConverter.ConvertO(accept);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["inputFormat"] = SourceExpressionConverter.ConvertToken(bodyinputFormat);
                bodypropCount++;
                body["outputFormat"] = SourceExpressionConverter.ConvertToken(bodyoutputFormat);
                bodypropCount++;
                body["string"] = SourceExpressionConverter.ConvertToken(bodyString);
                if (bodytimezone != null)
                {
                    body["timezone"] = SourceExpressionConverter.ConvertToken(bodytimezone);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ConvertAStringToADatetimeObjectResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<PerformOcrOnAScannedPdfOrImageFileResponse> PerformOcrOnAScannedPdfOrImageFile([WorkflowExpression] Func<string> bodyFile, [WorkflowExpression] Func<bodyoemInput> bodyoem, [WorkflowExpression] Func<bodypsmInput> bodypsm, [WorkflowExpression] Func<bool> bodytrim, [WorkflowExpression] Func<bodytypeInput> bodytype, [WorkflowExpression] Func<string> bodylanguage = null)
        {
            SourceExpression.Validate(bodyFile, nameof(bodyFile), required: true);
            SourceExpression.Validate(bodyoem, nameof(bodyoem), required: true);
            SourceExpression.Validate(bodypsm, nameof(bodypsm), required: true);
            SourceExpression.Validate(bodytrim, nameof(bodytrim), required: true);
            SourceExpression.Validate(bodytype, nameof(bodytype), required: true);
            SourceExpression.Validate(bodylanguage, nameof(bodylanguage), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/ocr/perform-ocr";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/json");
                callPayload.Headers["Accept"] = Convert.ToString(" application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["file"] = SourceExpressionConverter.ConvertToken(bodyFile);
                if (bodylanguage != null)
                {
                    if (bodylanguage != null)
                    {
                        body["language"] = SourceExpressionConverter.ConvertToken(bodylanguage);
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
                body["oem"] = SourceExpressionConverter.Convert(bodyoem);
                bodypropCount++;
                body["psm"] = SourceExpressionConverter.Convert(bodypsm);
                bodypropCount++;
                body["trim"] = SourceExpressionConverter.ConvertToken(bodytrim);
                bodypropCount++;
                body["type"] = SourceExpressionConverter.Convert(bodytype);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PerformOcrOnAScannedPdfOrImageFileResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<CombineMultiplePdfFilesResponse> CombineMultiplePdfFiles([WorkflowExpression] Func<string[]> bodypdfs)
        {
            SourceExpression.Validate(bodypdfs, nameof(bodypdfs), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/pdf/combine-pdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/json");
                callPayload.Headers["Accept"] = Convert.ToString(" application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["pdfs"] = SourceExpressionConverter.ConvertToken(bodypdfs);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CombineMultiplePdfFilesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<GetPdfMetadataInformationResponse> GetPdfMetadataInformation([WorkflowExpression] Func<string> bodypdf)
        {
            SourceExpression.Validate(bodypdf, nameof(bodypdf), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/pdf/pdf-metadata";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/json");
                callPayload.Headers["Accept"] = Convert.ToString(" application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["pdf"] = SourceExpressionConverter.ConvertToken(bodypdf);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetPdfMetadataInformationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<StandardArrayResponse> ConvertAPdfFileToText([WorkflowExpression] Func<bodylayoutInput> bodylayout, [WorkflowExpression] Func<string> bodypdf, [WorkflowExpression] Func<int> bodyendPage = null, [WorkflowExpression] Func<int> bodystartPage = null)
        {
            SourceExpression.Validate(bodylayout, nameof(bodylayout), required: true);
            SourceExpression.Validate(bodypdf, nameof(bodypdf), required: true);
            SourceExpression.Validate(bodyendPage, nameof(bodyendPage), required: false);
            SourceExpression.Validate(bodystartPage, nameof(bodystartPage), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                    body["endPage"] = SourceExpressionConverter.ConvertToken(bodyendPage);
                    bodypropCount++;
                }

                bodypropCount++;
                body["layout"] = SourceExpressionConverter.Convert(bodylayout);
                bodypropCount++;
                body["pdf"] = SourceExpressionConverter.ConvertToken(bodypdf);
                if (bodystartPage != null)
                {
                    body["startPage"] = SourceExpressionConverter.ConvertToken(bodystartPage);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<StandardArrayResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<SetPasswordOnAPdfFileResponse> SetPasswordOnAPdfFile([WorkflowExpression] Func<string> contentType, [WorkflowExpression] Func<string> accept, [WorkflowExpression] Func<string> bodypassword, [WorkflowExpression] Func<string> bodypdf)
        {
            SourceExpression.Validate(contentType, nameof(contentType), required: true);
            SourceExpression.Validate(accept, nameof(accept), required: true);
            SourceExpression.Validate(bodypassword, nameof(bodypassword), required: true);
            SourceExpression.Validate(bodypdf, nameof(bodypdf), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/pdf/set-password";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = SourceExpressionConverter.ConvertO(contentType);
                callPayload.Headers["Accept"] = SourceExpressionConverter.ConvertO(accept);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["password"] = SourceExpressionConverter.ConvertToken(bodypassword);
                bodypropCount++;
                body["pdf"] = SourceExpressionConverter.ConvertToken(bodypdf);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SetPasswordOnAPdfFileResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<ReplaceTextInStringBasedOnARegularExpressionResponse> ReplaceTextInStringBasedOnARegularExpression([WorkflowExpression] Func<string> bodypattern, [WorkflowExpression] Func<string> bodyreplacement, [WorkflowExpression] Func<string> bodytext)
        {
            SourceExpression.Validate(bodypattern, nameof(bodypattern), required: true);
            SourceExpression.Validate(bodyreplacement, nameof(bodyreplacement), required: true);
            SourceExpression.Validate(bodytext, nameof(bodytext), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/regex/regex-replace";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/json");
                callPayload.Headers["Accept"] = Convert.ToString(" application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["pattern"] = SourceExpressionConverter.ConvertToken(bodypattern);
                bodypropCount++;
                body["replacement"] = SourceExpressionConverter.ConvertToken(bodyreplacement);
                bodypropCount++;
                body["text"] = SourceExpressionConverter.ConvertToken(bodytext);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ReplaceTextInStringBasedOnARegularExpressionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<FindValuesFromAStringBasedOnARegularExpressionResponse> FindValuesFromAStringBasedOnARegularExpression([WorkflowExpression] Func<string> bodypattern, [WorkflowExpression] Func<string> bodytext, [WorkflowExpression] Func<int> bodygroup = null)
        {
            SourceExpression.Validate(bodypattern, nameof(bodypattern), required: true);
            SourceExpression.Validate(bodytext, nameof(bodytext), required: true);
            SourceExpression.Validate(bodygroup, nameof(bodygroup), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                    body["group"] = SourceExpressionConverter.ConvertToken(bodygroup);
                    bodypropCount++;
                }

                bodypropCount++;
                body["pattern"] = SourceExpressionConverter.ConvertToken(bodypattern);
                bodypropCount++;
                body["text"] = SourceExpressionConverter.ConvertToken(bodytext);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<FindValuesFromAStringBasedOnARegularExpressionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "optiapi")]
        public IBodyWorkflowAction<ReplaceTextInStringResponse> ReplaceTextInString([WorkflowExpression] Func<string> contentType, [WorkflowExpression] Func<string> accept, [WorkflowExpression] Func<string> bodyreplace, [WorkflowExpression] Func<string> bodysearch, [WorkflowExpression] Func<string> bodytext)
        {
            SourceExpression.Validate(contentType, nameof(contentType), required: true);
            SourceExpression.Validate(accept, nameof(accept), required: true);
            SourceExpression.Validate(bodyreplace, nameof(bodyreplace), required: true);
            SourceExpression.Validate(bodysearch, nameof(bodysearch), required: true);
            SourceExpression.Validate(bodytext, nameof(bodytext), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/text/text-replace";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = SourceExpressionConverter.ConvertO(contentType);
                callPayload.Headers["Accept"] = SourceExpressionConverter.ConvertO(accept);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["replace"] = SourceExpressionConverter.ConvertToken(bodyreplace);
                bodypropCount++;
                body["search"] = SourceExpressionConverter.ConvertToken(bodysearch);
                bodypropCount++;
                body["text"] = SourceExpressionConverter.ConvertToken(bodytext);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ReplaceTextInStringResponse>(BuildSourceInput);
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
        _0 = 0,
        _1 = 1
    }

    public enum bodypsmInput
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