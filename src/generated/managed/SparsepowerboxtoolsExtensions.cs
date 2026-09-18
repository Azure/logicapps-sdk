//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Sparsepowerboxtools
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SparsepowerboxtoolsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sparsepowerboxtools")]
        public IBodyWorkflowAction<Resp200PdfStampImage> PdfStampImage([WorkflowExpression] Func<string> reqPdfStampImagepDF, [WorkflowExpression] Func<string> reqPdfStampImageimage, [WorkflowExpression] Func<double> reqPdfStampImageoptionsopacity = null, [WorkflowExpression] Func<double> reqPdfStampImageoptionsscale = null, [WorkflowExpression] Func<int> reqPdfStampImageoptionsrotate = null, [WorkflowExpression] Func<int> reqPdfStampImageoptionspositionyOffset = null, [WorkflowExpression] Func<string> reqPdfStampImageoptionspositionstartOfYOffset = null, [WorkflowExpression] Func<int> reqPdfStampImageoptionspositionxOffset = null)
        {
            SourceExpression.Validate(reqPdfStampImagepDF, nameof(reqPdfStampImagepDF), required: true);
            SourceExpression.Validate(reqPdfStampImageimage, nameof(reqPdfStampImageimage), required: true);
            SourceExpression.Validate(reqPdfStampImageoptionsopacity, nameof(reqPdfStampImageoptionsopacity), required: false);
            SourceExpression.Validate(reqPdfStampImageoptionsscale, nameof(reqPdfStampImageoptionsscale), required: false);
            SourceExpression.Validate(reqPdfStampImageoptionsrotate, nameof(reqPdfStampImageoptionsrotate), required: false);
            SourceExpression.Validate(reqPdfStampImageoptionspositionyOffset, nameof(reqPdfStampImageoptionspositionyOffset), required: false);
            SourceExpression.Validate(reqPdfStampImageoptionspositionstartOfYOffset, nameof(reqPdfStampImageoptionspositionstartOfYOffset), required: false);
            SourceExpression.Validate(reqPdfStampImageoptionspositionxOffset, nameof(reqPdfStampImageoptionspositionxOffset), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/pdf/stamp/image";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqPdfStampImage = new JObject();
                var reqPdfStampImagepropCount = 0;
                reqPdfStampImagepropCount++;
                reqPdfStampImage["pdf"] = SourceExpressionConverter.ConvertToken(reqPdfStampImagepDF);
                reqPdfStampImagepropCount++;
                reqPdfStampImage["image"] = SourceExpressionConverter.ConvertToken(reqPdfStampImageimage);
                var optionsObject = new JObject();
                var optionsObjectpropCount = 0;
                if (reqPdfStampImageoptionsopacity != null)
                {
                    if (reqPdfStampImageoptionsopacity != null)
                    {
                        optionsObject["opacity"] = SourceExpressionConverter.ConvertToken(reqPdfStampImageoptionsopacity);
                        optionsObjectpropCount++;
                    }

                    optionsObjectpropCount++;
                }
                else
                {
                    optionsObject["opacity"] = 1;
                    optionsObjectpropCount++;
                }

                if (reqPdfStampImageoptionsscale != null)
                {
                    if (reqPdfStampImageoptionsscale != null)
                    {
                        optionsObject["scale"] = SourceExpressionConverter.ConvertToken(reqPdfStampImageoptionsscale);
                        optionsObjectpropCount++;
                    }

                    optionsObjectpropCount++;
                }
                else
                {
                    optionsObject["scale"] = 1;
                    optionsObjectpropCount++;
                }

                if (reqPdfStampImageoptionsrotate != null)
                {
                    if (reqPdfStampImageoptionsrotate != null)
                    {
                        optionsObject["rotate"] = SourceExpressionConverter.ConvertToken(reqPdfStampImageoptionsrotate);
                        optionsObjectpropCount++;
                    }

                    optionsObjectpropCount++;
                }
                else
                {
                    optionsObject["rotate"] = 0;
                    optionsObjectpropCount++;
                }

                var positionObject = new JObject();
                var positionObjectpropCount = 0;
                if (reqPdfStampImageoptionspositionyOffset != null)
                {
                    if (reqPdfStampImageoptionspositionyOffset != null)
                    {
                        positionObject["yOffset"] = SourceExpressionConverter.ConvertToken(reqPdfStampImageoptionspositionyOffset);
                        positionObjectpropCount++;
                    }

                    positionObjectpropCount++;
                }
                else
                {
                    positionObject["yOffset"] = 25;
                    positionObjectpropCount++;
                }

                if (reqPdfStampImageoptionspositionstartOfYOffset != null)
                {
                    if (reqPdfStampImageoptionspositionstartOfYOffset != null)
                    {
                        positionObject["yOffsetStart"] = SourceExpressionConverter.ConvertToken(reqPdfStampImageoptionspositionstartOfYOffset);
                        positionObjectpropCount++;
                    }

                    positionObjectpropCount++;
                }
                else
                {
                    positionObject["yOffsetStart"] = "bottom";
                    positionObjectpropCount++;
                }

                if (reqPdfStampImageoptionspositionxOffset != null)
                {
                    if (reqPdfStampImageoptionspositionxOffset != null)
                    {
                        positionObject["xOffset"] = SourceExpressionConverter.ConvertToken(reqPdfStampImageoptionspositionxOffset);
                        positionObjectpropCount++;
                    }

                    positionObjectpropCount++;
                }
                else
                {
                    positionObject["xOffset"] = 50;
                    positionObjectpropCount++;
                }

                if (positionObjectpropCount > 0)
                {
                    optionsObject["position"] = positionObject;
                    optionsObjectpropCount++;
                }

                if (optionsObjectpropCount > 0)
                {
                    reqPdfStampImage["options"] = optionsObject;
                    reqPdfStampImagepropCount++;
                }

                if (reqPdfStampImagepropCount > 0)
                {
                    callPayload.Body = reqPdfStampImage;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Resp200PdfStampImage>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sparsepowerboxtools")]
        public IBodyWorkflowAction<Resp200ExcelSheetAddRows> ExcelSheetAddRows([WorkflowExpression] Func<string> reqExcelSheetAddrowssheetname, [WorkflowExpression] Func<string> reqExcelSheetAddrowsexcel, [WorkflowExpression] Func<JToken[]> reqExcelSheetAddrowsdata = null)
        {
            SourceExpression.Validate(reqExcelSheetAddrowssheetname, nameof(reqExcelSheetAddrowssheetname), required: true);
            SourceExpression.Validate(reqExcelSheetAddrowsexcel, nameof(reqExcelSheetAddrowsexcel), required: true);
            SourceExpression.Validate(reqExcelSheetAddrowsdata, nameof(reqExcelSheetAddrowsdata), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/excel/sheet/add-rows";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqExcelSheetAddrows = new JObject();
                var reqExcelSheetAddrowspropCount = 0;
                reqExcelSheetAddrowspropCount++;
                reqExcelSheetAddrows["sheet"] = SourceExpressionConverter.ConvertToken(reqExcelSheetAddrowssheetname);
                if (reqExcelSheetAddrowsdata != null)
                {
                    reqExcelSheetAddrows["data"] = SourceExpressionConverter.ConvertToken(reqExcelSheetAddrowsdata);
                    reqExcelSheetAddrowspropCount++;
                }

                reqExcelSheetAddrowspropCount++;
                reqExcelSheetAddrows["excelFile"] = SourceExpressionConverter.ConvertToken(reqExcelSheetAddrowsexcel);
                if (reqExcelSheetAddrowspropCount > 0)
                {
                    callPayload.Body = reqExcelSheetAddrows;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Resp200ExcelSheetAddRows>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sparsepowerboxtools")]
        public IBodyWorkflowAction<Resp200PdfCreateByHtml> PdfCreateByHtml([WorkflowExpression] Func<string> reqPdfCreateByHtmlhTML, [WorkflowExpression] Func<string> reqPdfCreateByHtmloptionsmediaType = null, [WorkflowExpression] Func<string> reqPdfCreateByHtmloptionspageFormat = null, [WorkflowExpression] Func<bool> reqPdfCreateByHtmloptionslandscape = null, [WorkflowExpression] Func<string> reqPdfCreateByHtmloptionsmarginmarginLeft = null, [WorkflowExpression] Func<string> reqPdfCreateByHtmloptionsmarginmarginRight = null, [WorkflowExpression] Func<string> reqPdfCreateByHtmloptionsmarginmarginTop = null, [WorkflowExpression] Func<string> reqPdfCreateByHtmloptionsmarginmarginBottom = null)
        {
            SourceExpression.Validate(reqPdfCreateByHtmlhTML, nameof(reqPdfCreateByHtmlhTML), required: true);
            SourceExpression.Validate(reqPdfCreateByHtmloptionsmediaType, nameof(reqPdfCreateByHtmloptionsmediaType), required: false);
            SourceExpression.Validate(reqPdfCreateByHtmloptionspageFormat, nameof(reqPdfCreateByHtmloptionspageFormat), required: false);
            SourceExpression.Validate(reqPdfCreateByHtmloptionslandscape, nameof(reqPdfCreateByHtmloptionslandscape), required: false);
            SourceExpression.Validate(reqPdfCreateByHtmloptionsmarginmarginLeft, nameof(reqPdfCreateByHtmloptionsmarginmarginLeft), required: false);
            SourceExpression.Validate(reqPdfCreateByHtmloptionsmarginmarginRight, nameof(reqPdfCreateByHtmloptionsmarginmarginRight), required: false);
            SourceExpression.Validate(reqPdfCreateByHtmloptionsmarginmarginTop, nameof(reqPdfCreateByHtmloptionsmarginmarginTop), required: false);
            SourceExpression.Validate(reqPdfCreateByHtmloptionsmarginmarginBottom, nameof(reqPdfCreateByHtmloptionsmarginmarginBottom), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/pdf/create/by-html";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqPdfCreateByHtml = new JObject();
                var reqPdfCreateByHtmlpropCount = 0;
                reqPdfCreateByHtmlpropCount++;
                reqPdfCreateByHtml["content"] = SourceExpressionConverter.ConvertToken(reqPdfCreateByHtmlhTML);
                var dataObject = new JObject();
                var dataObjectpropCount = 0;
                if (dataObjectpropCount > 0)
                {
                    reqPdfCreateByHtml["data"] = dataObject;
                    reqPdfCreateByHtmlpropCount++;
                }

                var optionsObject = new JObject();
                var optionsObjectpropCount = 0;
                if (reqPdfCreateByHtmloptionsmediaType != null)
                {
                    if (reqPdfCreateByHtmloptionsmediaType != null)
                    {
                        optionsObject["mediaType"] = SourceExpressionConverter.ConvertToken(reqPdfCreateByHtmloptionsmediaType);
                        optionsObjectpropCount++;
                    }

                    optionsObjectpropCount++;
                }
                else
                {
                    optionsObject["mediaType"] = "print";
                    optionsObjectpropCount++;
                }

                if (reqPdfCreateByHtmloptionspageFormat != null)
                {
                    if (reqPdfCreateByHtmloptionspageFormat != null)
                    {
                        optionsObject["format"] = SourceExpressionConverter.ConvertToken(reqPdfCreateByHtmloptionspageFormat);
                        optionsObjectpropCount++;
                    }

                    optionsObjectpropCount++;
                }
                else
                {
                    optionsObject["format"] = "A4";
                    optionsObjectpropCount++;
                }

                if (reqPdfCreateByHtmloptionslandscape != null)
                {
                    if (reqPdfCreateByHtmloptionslandscape != null)
                    {
                        optionsObject["landscape"] = SourceExpressionConverter.ConvertToken(reqPdfCreateByHtmloptionslandscape);
                        optionsObjectpropCount++;
                    }

                    optionsObjectpropCount++;
                }
                else
                {
                    optionsObject["landscape"] = false;
                    optionsObjectpropCount++;
                }

                var marginObject = new JObject();
                var marginObjectpropCount = 0;
                if (reqPdfCreateByHtmloptionsmarginmarginLeft != null)
                {
                    if (reqPdfCreateByHtmloptionsmarginmarginLeft != null)
                    {
                        marginObject["left"] = SourceExpressionConverter.ConvertToken(reqPdfCreateByHtmloptionsmarginmarginLeft);
                        marginObjectpropCount++;
                    }

                    marginObjectpropCount++;
                }
                else
                {
                    marginObject["left"] = "0px";
                    marginObjectpropCount++;
                }

                if (reqPdfCreateByHtmloptionsmarginmarginRight != null)
                {
                    if (reqPdfCreateByHtmloptionsmarginmarginRight != null)
                    {
                        marginObject["right"] = SourceExpressionConverter.ConvertToken(reqPdfCreateByHtmloptionsmarginmarginRight);
                        marginObjectpropCount++;
                    }

                    marginObjectpropCount++;
                }
                else
                {
                    marginObject["right"] = "0px";
                    marginObjectpropCount++;
                }

                if (reqPdfCreateByHtmloptionsmarginmarginTop != null)
                {
                    if (reqPdfCreateByHtmloptionsmarginmarginTop != null)
                    {
                        marginObject["top"] = SourceExpressionConverter.ConvertToken(reqPdfCreateByHtmloptionsmarginmarginTop);
                        marginObjectpropCount++;
                    }

                    marginObjectpropCount++;
                }
                else
                {
                    marginObject["top"] = "0px";
                    marginObjectpropCount++;
                }

                if (reqPdfCreateByHtmloptionsmarginmarginBottom != null)
                {
                    if (reqPdfCreateByHtmloptionsmarginmarginBottom != null)
                    {
                        marginObject["bottom"] = SourceExpressionConverter.ConvertToken(reqPdfCreateByHtmloptionsmarginmarginBottom);
                        marginObjectpropCount++;
                    }

                    marginObjectpropCount++;
                }
                else
                {
                    marginObject["bottom"] = "0px";
                    marginObjectpropCount++;
                }

                if (marginObjectpropCount > 0)
                {
                    optionsObject["margin"] = marginObject;
                    optionsObjectpropCount++;
                }

                if (optionsObjectpropCount > 0)
                {
                    reqPdfCreateByHtml["options"] = optionsObject;
                    reqPdfCreateByHtmlpropCount++;
                }

                if (reqPdfCreateByHtmlpropCount > 0)
                {
                    callPayload.Body = reqPdfCreateByHtml;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Resp200PdfCreateByHtml>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sparsepowerboxtools")]
        public IBodyWorkflowAction<Resp200ImageMergeDrawing> ImageMergeDrawing([WorkflowExpression] Func<string> reqImageMergeDrawingbackground, [WorkflowExpression] Func<string> reqImageMergeDrawingdrawing)
        {
            SourceExpression.Validate(reqImageMergeDrawingbackground, nameof(reqImageMergeDrawingbackground), required: true);
            SourceExpression.Validate(reqImageMergeDrawingdrawing, nameof(reqImageMergeDrawingdrawing), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/image/merge/drawing";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqImageMergeDrawing = new JObject();
                var reqImageMergeDrawingpropCount = 0;
                reqImageMergeDrawingpropCount++;
                reqImageMergeDrawing["background"] = SourceExpressionConverter.ConvertToken(reqImageMergeDrawingbackground);
                reqImageMergeDrawingpropCount++;
                reqImageMergeDrawing["drawing"] = SourceExpressionConverter.ConvertToken(reqImageMergeDrawingdrawing);
                if (reqImageMergeDrawingpropCount > 0)
                {
                    callPayload.Body = reqImageMergeDrawing;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Resp200ImageMergeDrawing>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sparsepowerboxtools")]
        public IBodyWorkflowAction<Resp200PdfStampText> PdfStampText([WorkflowExpression] Func<string> reqPdfStampTextpDF, [WorkflowExpression] Func<string> reqPdfStampTexttext, [WorkflowExpression] Func<string> reqPdfStampTextoptionsfontColor = null, [WorkflowExpression] Func<int> reqPdfStampTextoptionsfontSize = null, [WorkflowExpression] Func<int> reqPdfStampTextoptionsrotate = null, [WorkflowExpression] Func<int> reqPdfStampTextoptionspositionyOffset = null, [WorkflowExpression] Func<string> reqPdfStampTextoptionspositionstartOfYOffset = null, [WorkflowExpression] Func<int> reqPdfStampTextoptionspositionxOffset = null)
        {
            SourceExpression.Validate(reqPdfStampTextpDF, nameof(reqPdfStampTextpDF), required: true);
            SourceExpression.Validate(reqPdfStampTexttext, nameof(reqPdfStampTexttext), required: true);
            SourceExpression.Validate(reqPdfStampTextoptionsfontColor, nameof(reqPdfStampTextoptionsfontColor), required: false);
            SourceExpression.Validate(reqPdfStampTextoptionsfontSize, nameof(reqPdfStampTextoptionsfontSize), required: false);
            SourceExpression.Validate(reqPdfStampTextoptionsrotate, nameof(reqPdfStampTextoptionsrotate), required: false);
            SourceExpression.Validate(reqPdfStampTextoptionspositionyOffset, nameof(reqPdfStampTextoptionspositionyOffset), required: false);
            SourceExpression.Validate(reqPdfStampTextoptionspositionstartOfYOffset, nameof(reqPdfStampTextoptionspositionstartOfYOffset), required: false);
            SourceExpression.Validate(reqPdfStampTextoptionspositionxOffset, nameof(reqPdfStampTextoptionspositionxOffset), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/pdf/stamp/text";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqPdfStampText = new JObject();
                var reqPdfStampTextpropCount = 0;
                reqPdfStampTextpropCount++;
                reqPdfStampText["pdf"] = SourceExpressionConverter.ConvertToken(reqPdfStampTextpDF);
                reqPdfStampTextpropCount++;
                reqPdfStampText["text"] = SourceExpressionConverter.ConvertToken(reqPdfStampTexttext);
                var optionsObject = new JObject();
                var optionsObjectpropCount = 0;
                if (reqPdfStampTextoptionsfontColor != null)
                {
                    if (reqPdfStampTextoptionsfontColor != null)
                    {
                        optionsObject["color"] = SourceExpressionConverter.ConvertToken(reqPdfStampTextoptionsfontColor);
                        optionsObjectpropCount++;
                    }

                    optionsObjectpropCount++;
                }
                else
                {
                    optionsObject["color"] = "#000000";
                    optionsObjectpropCount++;
                }

                if (reqPdfStampTextoptionsfontSize != null)
                {
                    if (reqPdfStampTextoptionsfontSize != null)
                    {
                        optionsObject["size"] = SourceExpressionConverter.ConvertToken(reqPdfStampTextoptionsfontSize);
                        optionsObjectpropCount++;
                    }

                    optionsObjectpropCount++;
                }
                else
                {
                    optionsObject["size"] = 50;
                    optionsObjectpropCount++;
                }

                if (reqPdfStampTextoptionsrotate != null)
                {
                    if (reqPdfStampTextoptionsrotate != null)
                    {
                        optionsObject["rotate"] = SourceExpressionConverter.ConvertToken(reqPdfStampTextoptionsrotate);
                        optionsObjectpropCount++;
                    }

                    optionsObjectpropCount++;
                }
                else
                {
                    optionsObject["rotate"] = 0;
                    optionsObjectpropCount++;
                }

                var positionObject = new JObject();
                var positionObjectpropCount = 0;
                if (reqPdfStampTextoptionspositionyOffset != null)
                {
                    if (reqPdfStampTextoptionspositionyOffset != null)
                    {
                        positionObject["yOffset"] = SourceExpressionConverter.ConvertToken(reqPdfStampTextoptionspositionyOffset);
                        positionObjectpropCount++;
                    }

                    positionObjectpropCount++;
                }
                else
                {
                    positionObject["yOffset"] = 25;
                    positionObjectpropCount++;
                }

                if (reqPdfStampTextoptionspositionstartOfYOffset != null)
                {
                    if (reqPdfStampTextoptionspositionstartOfYOffset != null)
                    {
                        positionObject["yOffsetStart"] = SourceExpressionConverter.ConvertToken(reqPdfStampTextoptionspositionstartOfYOffset);
                        positionObjectpropCount++;
                    }

                    positionObjectpropCount++;
                }
                else
                {
                    positionObject["yOffsetStart"] = "bottom";
                    positionObjectpropCount++;
                }

                if (reqPdfStampTextoptionspositionxOffset != null)
                {
                    if (reqPdfStampTextoptionspositionxOffset != null)
                    {
                        positionObject["xOffset"] = SourceExpressionConverter.ConvertToken(reqPdfStampTextoptionspositionxOffset);
                        positionObjectpropCount++;
                    }

                    positionObjectpropCount++;
                }
                else
                {
                    positionObject["xOffset"] = 50;
                    positionObjectpropCount++;
                }

                if (positionObjectpropCount > 0)
                {
                    optionsObject["position"] = positionObject;
                    optionsObjectpropCount++;
                }

                if (optionsObjectpropCount > 0)
                {
                    reqPdfStampText["options"] = optionsObject;
                    reqPdfStampTextpropCount++;
                }

                if (reqPdfStampTextpropCount > 0)
                {
                    callPayload.Body = reqPdfStampText;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Resp200PdfStampText>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sparsepowerboxtools")]
        public IBodyWorkflowAction<Resp200CsvToJson> CsvToJson([WorkflowExpression] Func<string> reqCsvToJsoncSV, [WorkflowExpression] Func<bool> reqCsvToJsonoptionshasHeaders = null, [WorkflowExpression] Func<string> reqCsvToJsonoptionsdelimiter = null)
        {
            SourceExpression.Validate(reqCsvToJsoncSV, nameof(reqCsvToJsoncSV), required: true);
            SourceExpression.Validate(reqCsvToJsonoptionshasHeaders, nameof(reqCsvToJsonoptionshasHeaders), required: false);
            SourceExpression.Validate(reqCsvToJsonoptionsdelimiter, nameof(reqCsvToJsonoptionsdelimiter), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/csv/to-json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqCsvToJson = new JObject();
                var reqCsvToJsonpropCount = 0;
                reqCsvToJsonpropCount++;
                reqCsvToJson["csv"] = SourceExpressionConverter.ConvertToken(reqCsvToJsoncSV);
                var optionsObject = new JObject();
                var optionsObjectpropCount = 0;
                if (reqCsvToJsonoptionshasHeaders != null)
                {
                    if (reqCsvToJsonoptionshasHeaders != null)
                    {
                        optionsObject["hasHeaders"] = SourceExpressionConverter.ConvertToken(reqCsvToJsonoptionshasHeaders);
                        optionsObjectpropCount++;
                    }

                    optionsObjectpropCount++;
                }
                else
                {
                    optionsObject["hasHeaders"] = true;
                    optionsObjectpropCount++;
                }

                if (reqCsvToJsonoptionsdelimiter != null)
                {
                    if (reqCsvToJsonoptionsdelimiter != null)
                    {
                        optionsObject["delimiter"] = SourceExpressionConverter.ConvertToken(reqCsvToJsonoptionsdelimiter);
                        optionsObjectpropCount++;
                    }

                    optionsObjectpropCount++;
                }
                else
                {
                    optionsObject["delimiter"] = ",";
                    optionsObjectpropCount++;
                }

                if (optionsObjectpropCount > 0)
                {
                    reqCsvToJson["options"] = optionsObject;
                    reqCsvToJsonpropCount++;
                }

                if (reqCsvToJsonpropCount > 0)
                {
                    callPayload.Body = reqCsvToJson;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Resp200CsvToJson>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sparsepowerboxtools")]
        public IBodyWorkflowAction<Resp200PdfCreateByUrl> PdfCreateByUrl([WorkflowExpression] Func<string> reqPdfCreateByUrlhTML, [WorkflowExpression] Func<string> reqPdfCreateByUrloptionsmediaType = null, [WorkflowExpression] Func<string> reqPdfCreateByUrloptionspageFormat = null, [WorkflowExpression] Func<bool> reqPdfCreateByUrloptionslandscape = null, [WorkflowExpression] Func<string> reqPdfCreateByUrloptionsmarginmarginLeft = null, [WorkflowExpression] Func<string> reqPdfCreateByUrloptionsmarginmarginRight = null, [WorkflowExpression] Func<string> reqPdfCreateByUrloptionsmarginmarginTop = null, [WorkflowExpression] Func<string> reqPdfCreateByUrloptionsmarginmarginBottom = null)
        {
            SourceExpression.Validate(reqPdfCreateByUrlhTML, nameof(reqPdfCreateByUrlhTML), required: true);
            SourceExpression.Validate(reqPdfCreateByUrloptionsmediaType, nameof(reqPdfCreateByUrloptionsmediaType), required: false);
            SourceExpression.Validate(reqPdfCreateByUrloptionspageFormat, nameof(reqPdfCreateByUrloptionspageFormat), required: false);
            SourceExpression.Validate(reqPdfCreateByUrloptionslandscape, nameof(reqPdfCreateByUrloptionslandscape), required: false);
            SourceExpression.Validate(reqPdfCreateByUrloptionsmarginmarginLeft, nameof(reqPdfCreateByUrloptionsmarginmarginLeft), required: false);
            SourceExpression.Validate(reqPdfCreateByUrloptionsmarginmarginRight, nameof(reqPdfCreateByUrloptionsmarginmarginRight), required: false);
            SourceExpression.Validate(reqPdfCreateByUrloptionsmarginmarginTop, nameof(reqPdfCreateByUrloptionsmarginmarginTop), required: false);
            SourceExpression.Validate(reqPdfCreateByUrloptionsmarginmarginBottom, nameof(reqPdfCreateByUrloptionsmarginmarginBottom), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/pdf/create/by-url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqPdfCreateByUrl = new JObject();
                var reqPdfCreateByUrlpropCount = 0;
                reqPdfCreateByUrlpropCount++;
                reqPdfCreateByUrl["url"] = SourceExpressionConverter.ConvertToken(reqPdfCreateByUrlhTML);
                var optionsObject = new JObject();
                var optionsObjectpropCount = 0;
                if (reqPdfCreateByUrloptionsmediaType != null)
                {
                    if (reqPdfCreateByUrloptionsmediaType != null)
                    {
                        optionsObject["mediaType"] = SourceExpressionConverter.ConvertToken(reqPdfCreateByUrloptionsmediaType);
                        optionsObjectpropCount++;
                    }

                    optionsObjectpropCount++;
                }
                else
                {
                    optionsObject["mediaType"] = "print";
                    optionsObjectpropCount++;
                }

                if (reqPdfCreateByUrloptionspageFormat != null)
                {
                    if (reqPdfCreateByUrloptionspageFormat != null)
                    {
                        optionsObject["format"] = SourceExpressionConverter.ConvertToken(reqPdfCreateByUrloptionspageFormat);
                        optionsObjectpropCount++;
                    }

                    optionsObjectpropCount++;
                }
                else
                {
                    optionsObject["format"] = "A4";
                    optionsObjectpropCount++;
                }

                if (reqPdfCreateByUrloptionslandscape != null)
                {
                    if (reqPdfCreateByUrloptionslandscape != null)
                    {
                        optionsObject["landscape"] = SourceExpressionConverter.ConvertToken(reqPdfCreateByUrloptionslandscape);
                        optionsObjectpropCount++;
                    }

                    optionsObjectpropCount++;
                }
                else
                {
                    optionsObject["landscape"] = false;
                    optionsObjectpropCount++;
                }

                var marginObject = new JObject();
                var marginObjectpropCount = 0;
                if (reqPdfCreateByUrloptionsmarginmarginLeft != null)
                {
                    if (reqPdfCreateByUrloptionsmarginmarginLeft != null)
                    {
                        marginObject["left"] = SourceExpressionConverter.ConvertToken(reqPdfCreateByUrloptionsmarginmarginLeft);
                        marginObjectpropCount++;
                    }

                    marginObjectpropCount++;
                }
                else
                {
                    marginObject["left"] = "0px";
                    marginObjectpropCount++;
                }

                if (reqPdfCreateByUrloptionsmarginmarginRight != null)
                {
                    if (reqPdfCreateByUrloptionsmarginmarginRight != null)
                    {
                        marginObject["right"] = SourceExpressionConverter.ConvertToken(reqPdfCreateByUrloptionsmarginmarginRight);
                        marginObjectpropCount++;
                    }

                    marginObjectpropCount++;
                }
                else
                {
                    marginObject["right"] = "0px";
                    marginObjectpropCount++;
                }

                if (reqPdfCreateByUrloptionsmarginmarginTop != null)
                {
                    if (reqPdfCreateByUrloptionsmarginmarginTop != null)
                    {
                        marginObject["top"] = SourceExpressionConverter.ConvertToken(reqPdfCreateByUrloptionsmarginmarginTop);
                        marginObjectpropCount++;
                    }

                    marginObjectpropCount++;
                }
                else
                {
                    marginObject["top"] = "0px";
                    marginObjectpropCount++;
                }

                if (reqPdfCreateByUrloptionsmarginmarginBottom != null)
                {
                    if (reqPdfCreateByUrloptionsmarginmarginBottom != null)
                    {
                        marginObject["bottom"] = SourceExpressionConverter.ConvertToken(reqPdfCreateByUrloptionsmarginmarginBottom);
                        marginObjectpropCount++;
                    }

                    marginObjectpropCount++;
                }
                else
                {
                    marginObject["bottom"] = "0px";
                    marginObjectpropCount++;
                }

                if (marginObjectpropCount > 0)
                {
                    optionsObject["margin"] = marginObject;
                    optionsObjectpropCount++;
                }

                if (optionsObjectpropCount > 0)
                {
                    reqPdfCreateByUrl["options"] = optionsObject;
                    reqPdfCreateByUrlpropCount++;
                }

                if (reqPdfCreateByUrlpropCount > 0)
                {
                    callPayload.Body = reqPdfCreateByUrl;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Resp200PdfCreateByUrl>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sparsepowerboxtools")]
        public IBodyWorkflowAction<Resp200ImageStampText> ImageStampText([WorkflowExpression] Func<string> reqImageStampTextimage = null, [WorkflowExpression] Func<string> reqImageStampTexttextToStamp = null, [WorkflowExpression] Func<string> reqImageStampTextoptionslocationOfTheStamp = null, [WorkflowExpression] Func<string> reqImageStampTextoptionsfontcolor = null, [WorkflowExpression] Func<int> reqImageStampTextoptionsfontsize = null)
        {
            SourceExpression.Validate(reqImageStampTextimage, nameof(reqImageStampTextimage), required: false);
            SourceExpression.Validate(reqImageStampTexttextToStamp, nameof(reqImageStampTexttextToStamp), required: false);
            SourceExpression.Validate(reqImageStampTextoptionslocationOfTheStamp, nameof(reqImageStampTextoptionslocationOfTheStamp), required: false);
            SourceExpression.Validate(reqImageStampTextoptionsfontcolor, nameof(reqImageStampTextoptionsfontcolor), required: false);
            SourceExpression.Validate(reqImageStampTextoptionsfontsize, nameof(reqImageStampTextoptionsfontsize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/image/stamp/text";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqImageStampText = new JObject();
                var reqImageStampTextpropCount = 0;
                if (reqImageStampTextimage != null)
                {
                    reqImageStampText["image"] = SourceExpressionConverter.ConvertToken(reqImageStampTextimage);
                    reqImageStampTextpropCount++;
                }

                if (reqImageStampTexttextToStamp != null)
                {
                    reqImageStampText["text"] = SourceExpressionConverter.ConvertToken(reqImageStampTexttextToStamp);
                    reqImageStampTextpropCount++;
                }

                var optionsObject = new JObject();
                var optionsObjectpropCount = 0;
                if (reqImageStampTextoptionslocationOfTheStamp != null)
                {
                    if (reqImageStampTextoptionslocationOfTheStamp != null)
                    {
                        optionsObject["location"] = SourceExpressionConverter.ConvertToken(reqImageStampTextoptionslocationOfTheStamp);
                        optionsObjectpropCount++;
                    }

                    optionsObjectpropCount++;
                }
                else
                {
                    optionsObject["location"] = "Center";
                    optionsObjectpropCount++;
                }

                if (reqImageStampTextoptionsfontcolor != null)
                {
                    if (reqImageStampTextoptionsfontcolor != null)
                    {
                        optionsObject["fontColor"] = SourceExpressionConverter.ConvertToken(reqImageStampTextoptionsfontcolor);
                        optionsObjectpropCount++;
                    }

                    optionsObjectpropCount++;
                }
                else
                {
                    optionsObject["fontColor"] = "#ffffff";
                    optionsObjectpropCount++;
                }

                if (reqImageStampTextoptionsfontsize != null)
                {
                    if (reqImageStampTextoptionsfontsize != null)
                    {
                        optionsObject["fontSize"] = SourceExpressionConverter.ConvertToken(reqImageStampTextoptionsfontsize);
                        optionsObjectpropCount++;
                    }

                    optionsObjectpropCount++;
                }
                else
                {
                    optionsObject["fontSize"] = 25;
                    optionsObjectpropCount++;
                }

                if (optionsObjectpropCount > 0)
                {
                    reqImageStampText["options"] = optionsObject;
                    reqImageStampTextpropCount++;
                }

                if (reqImageStampTextpropCount > 0)
                {
                    callPayload.Body = reqImageStampText;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Resp200ImageStampText>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sparsepowerboxtools")]
        public IBodyWorkflowAction<Resp200ImageResize> ImageResize([WorkflowExpression] Func<string> reqImageResizeimage = null, [WorkflowExpression] Func<int> reqImageResizewidth = null, [WorkflowExpression] Func<int> reqImageResizeheight = null, [WorkflowExpression] Func<bool> reqImageResizeoptionsignoreTheAspectRation = null)
        {
            SourceExpression.Validate(reqImageResizeimage, nameof(reqImageResizeimage), required: false);
            SourceExpression.Validate(reqImageResizewidth, nameof(reqImageResizewidth), required: false);
            SourceExpression.Validate(reqImageResizeheight, nameof(reqImageResizeheight), required: false);
            SourceExpression.Validate(reqImageResizeoptionsignoreTheAspectRation, nameof(reqImageResizeoptionsignoreTheAspectRation), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/image/resize";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqImageResize = new JObject();
                var reqImageResizepropCount = 0;
                if (reqImageResizeimage != null)
                {
                    reqImageResize["image"] = SourceExpressionConverter.ConvertToken(reqImageResizeimage);
                    reqImageResizepropCount++;
                }

                if (reqImageResizewidth != null)
                {
                    reqImageResize["width"] = SourceExpressionConverter.ConvertToken(reqImageResizewidth);
                    reqImageResizepropCount++;
                }

                if (reqImageResizeheight != null)
                {
                    reqImageResize["height"] = SourceExpressionConverter.ConvertToken(reqImageResizeheight);
                    reqImageResizepropCount++;
                }

                var optionsObject = new JObject();
                var optionsObjectpropCount = 0;
                if (reqImageResizeoptionsignoreTheAspectRation != null)
                {
                    if (reqImageResizeoptionsignoreTheAspectRation != null)
                    {
                        optionsObject["ignoreAspectRation"] = SourceExpressionConverter.ConvertToken(reqImageResizeoptionsignoreTheAspectRation);
                        optionsObjectpropCount++;
                    }

                    optionsObjectpropCount++;
                }
                else
                {
                    optionsObject["ignoreAspectRation"] = false;
                    optionsObjectpropCount++;
                }

                if (optionsObjectpropCount > 0)
                {
                    reqImageResize["options"] = optionsObject;
                    reqImageResizepropCount++;
                }

                if (reqImageResizepropCount > 0)
                {
                    callPayload.Body = reqImageResize;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Resp200ImageResize>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sparsepowerboxtools")]
        public IBodyWorkflowAction<Resp200PdfSplitByPage> PdfSplitByPage([WorkflowExpression] Func<string> reqPdfSplitByPagepDFFile = null, [WorkflowExpression] Func<double> reqPdfSplitByPageoptionsnumberOfPages = null)
        {
            SourceExpression.Validate(reqPdfSplitByPagepDFFile, nameof(reqPdfSplitByPagepDFFile), required: false);
            SourceExpression.Validate(reqPdfSplitByPageoptionsnumberOfPages, nameof(reqPdfSplitByPageoptionsnumberOfPages), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/pdf/split/by-page";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqPdfSplitByPage = new JObject();
                var reqPdfSplitByPagepropCount = 0;
                if (reqPdfSplitByPagepDFFile != null)
                {
                    reqPdfSplitByPage["pdf"] = SourceExpressionConverter.ConvertToken(reqPdfSplitByPagepDFFile);
                    reqPdfSplitByPagepropCount++;
                }

                var optionsObject = new JObject();
                var optionsObjectpropCount = 0;
                if (reqPdfSplitByPageoptionsnumberOfPages != null)
                {
                    if (reqPdfSplitByPageoptionsnumberOfPages != null)
                    {
                        optionsObject["numberOfPages"] = SourceExpressionConverter.ConvertToken(reqPdfSplitByPageoptionsnumberOfPages);
                        optionsObjectpropCount++;
                    }

                    optionsObjectpropCount++;
                }
                else
                {
                    optionsObject["numberOfPages"] = 1;
                    optionsObjectpropCount++;
                }

                if (optionsObjectpropCount > 0)
                {
                    reqPdfSplitByPage["options"] = optionsObject;
                    reqPdfSplitByPagepropCount++;
                }

                if (reqPdfSplitByPagepropCount > 0)
                {
                    callPayload.Body = reqPdfSplitByPage;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Resp200PdfSplitByPage>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sparsepowerboxtools")]
        public IBodyWorkflowAction<Resp200ImageStampExif> ImageStampExif([WorkflowExpression] Func<string> reqImageStampExifimage = null, [WorkflowExpression] Func<string[]> reqImageStampExifoptionstags = null, [WorkflowExpression] Func<string> reqImageStampExifoptionslocationOfTheStamp = null, [WorkflowExpression] Func<string> reqImageStampExifoptionsfontcolor = null, [WorkflowExpression] Func<int> reqImageStampExifoptionsfontsize = null, [WorkflowExpression] Func<bool> reqImageStampExifoptionsprintTagName = null)
        {
            SourceExpression.Validate(reqImageStampExifimage, nameof(reqImageStampExifimage), required: false);
            SourceExpression.Validate(reqImageStampExifoptionstags, nameof(reqImageStampExifoptionstags), required: false);
            SourceExpression.Validate(reqImageStampExifoptionslocationOfTheStamp, nameof(reqImageStampExifoptionslocationOfTheStamp), required: false);
            SourceExpression.Validate(reqImageStampExifoptionsfontcolor, nameof(reqImageStampExifoptionsfontcolor), required: false);
            SourceExpression.Validate(reqImageStampExifoptionsfontsize, nameof(reqImageStampExifoptionsfontsize), required: false);
            SourceExpression.Validate(reqImageStampExifoptionsprintTagName, nameof(reqImageStampExifoptionsprintTagName), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/image/stamp/exif";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqImageStampExif = new JObject();
                var reqImageStampExifpropCount = 0;
                if (reqImageStampExifimage != null)
                {
                    reqImageStampExif["image"] = SourceExpressionConverter.ConvertToken(reqImageStampExifimage);
                    reqImageStampExifpropCount++;
                }

                var optionsObject = new JObject();
                var optionsObjectpropCount = 0;
                if (reqImageStampExifoptionstags != null)
                {
                    optionsObject["tags"] = SourceExpressionConverter.ConvertToken(reqImageStampExifoptionstags);
                    optionsObjectpropCount++;
                }

                if (reqImageStampExifoptionslocationOfTheStamp != null)
                {
                    if (reqImageStampExifoptionslocationOfTheStamp != null)
                    {
                        optionsObject["location"] = SourceExpressionConverter.ConvertToken(reqImageStampExifoptionslocationOfTheStamp);
                        optionsObjectpropCount++;
                    }

                    optionsObjectpropCount++;
                }
                else
                {
                    optionsObject["location"] = "Center";
                    optionsObjectpropCount++;
                }

                if (reqImageStampExifoptionsfontcolor != null)
                {
                    if (reqImageStampExifoptionsfontcolor != null)
                    {
                        optionsObject["fontColor"] = SourceExpressionConverter.ConvertToken(reqImageStampExifoptionsfontcolor);
                        optionsObjectpropCount++;
                    }

                    optionsObjectpropCount++;
                }
                else
                {
                    optionsObject["fontColor"] = "#ffffff";
                    optionsObjectpropCount++;
                }

                if (reqImageStampExifoptionsfontsize != null)
                {
                    if (reqImageStampExifoptionsfontsize != null)
                    {
                        optionsObject["fontSize"] = SourceExpressionConverter.ConvertToken(reqImageStampExifoptionsfontsize);
                        optionsObjectpropCount++;
                    }

                    optionsObjectpropCount++;
                }
                else
                {
                    optionsObject["fontSize"] = 25;
                    optionsObjectpropCount++;
                }

                if (reqImageStampExifoptionsprintTagName != null)
                {
                    if (reqImageStampExifoptionsprintTagName != null)
                    {
                        optionsObject["printTagName"] = SourceExpressionConverter.ConvertToken(reqImageStampExifoptionsprintTagName);
                        optionsObjectpropCount++;
                    }

                    optionsObjectpropCount++;
                }
                else
                {
                    optionsObject["printTagName"] = false;
                    optionsObjectpropCount++;
                }

                if (optionsObjectpropCount > 0)
                {
                    reqImageStampExif["options"] = optionsObject;
                    reqImageStampExifpropCount++;
                }

                if (reqImageStampExifpropCount > 0)
                {
                    callPayload.Body = reqImageStampExif;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Resp200ImageStampExif>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sparsepowerboxtools")]
        public IBodyWorkflowAction<Resp200PdfFillForm> PdfFillForm([WorkflowExpression] Func<string> reqPdfFillFormpDFFile = null)
        {
            SourceExpression.Validate(reqPdfFillFormpDFFile, nameof(reqPdfFillFormpDFFile), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/form/fill";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqPdfFillForm = new JObject();
                var reqPdfFillFormpropCount = 0;
                if (reqPdfFillFormpDFFile != null)
                {
                    reqPdfFillForm["pdf"] = SourceExpressionConverter.ConvertToken(reqPdfFillFormpDFFile);
                    reqPdfFillFormpropCount++;
                }

                var dataObject = new JObject();
                var dataObjectpropCount = 0;
                if (dataObjectpropCount > 0)
                {
                    reqPdfFillForm["data"] = dataObject;
                    reqPdfFillFormpropCount++;
                }

                if (reqPdfFillFormpropCount > 0)
                {
                    callPayload.Body = reqPdfFillForm;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Resp200PdfFillForm>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sparsepowerboxtools")]
        public IBodyWorkflowAction<Resp200PdfGetFormData> PdfGetFormData([WorkflowExpression] Func<string> reqPdfGetFormDatapDFFile = null)
        {
            SourceExpression.Validate(reqPdfGetFormDatapDFFile, nameof(reqPdfGetFormDatapDFFile), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/form/getdata";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqPdfGetFormData = new JObject();
                var reqPdfGetFormDatapropCount = 0;
                if (reqPdfGetFormDatapDFFile != null)
                {
                    reqPdfGetFormData["pdf"] = SourceExpressionConverter.ConvertToken(reqPdfGetFormDatapDFFile);
                    reqPdfGetFormDatapropCount++;
                }

                if (reqPdfGetFormDatapropCount > 0)
                {
                    callPayload.Body = reqPdfGetFormData;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Resp200PdfGetFormData>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sparsepowerboxtools")]
        public IBodyWorkflowAction<Resp200PdfMergeSimple> PdfMergeSimple([WorkflowExpression] Func<string[]> reqPdfMergeSimplepDFFile = null)
        {
            SourceExpression.Validate(reqPdfMergeSimplepDFFile, nameof(reqPdfMergeSimplepDFFile), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/pdf/merge/simple";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqPdfMergeSimple = new JObject();
                var reqPdfMergeSimplepropCount = 0;
                if (reqPdfMergeSimplepDFFile != null)
                {
                    reqPdfMergeSimple["pdfs"] = SourceExpressionConverter.ConvertToken(reqPdfMergeSimplepDFFile);
                    reqPdfMergeSimplepropCount++;
                }

                if (reqPdfMergeSimplepropCount > 0)
                {
                    callPayload.Body = reqPdfMergeSimple;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Resp200PdfMergeSimple>(BuildSourceInput);
        }
    }

    public class SparsepowerboxtoolsTriggers([ConnectionName] string connectionId)
    {
    }

    public class Resp200PdfStampImage
    {
        [JsonProperty("result")]
        public string PDFFile { get; set; }
    }

    public class Resp200ExcelSheetAddRows
    {
        [JsonProperty("result")]
        public string ExcelSheet { get; set; }
    }

    public class Resp200PdfCreateByHtml
    {
        [JsonProperty("result")]
        public string PDFFile { get; set; }
    }

    public class Resp200ImageMergeDrawing
    {
        [JsonProperty("result")]
        public string Image { get; set; }
    }

    public class Resp200PdfStampText
    {
        [JsonProperty("result")]
        public string PDFFile { get; set; }
    }

    public class Resp200CsvToJson
    {
        [JsonProperty("records")]
        public JToken[] Records { get; set; }
    }

    public class Resp200PdfCreateByUrl
    {
        [JsonProperty("result")]
        public string PDFFile { get; set; }
    }

    public class Resp200ImageStampText
    {
        [JsonProperty("result")]
        public string StampedImage { get; set; }
    }

    public class Resp200ImageResize
    {
        [JsonProperty("result")]
        public string ResizedImage { get; set; }
    }

    public class Resp200PdfSplitByPage
    {
        [JsonProperty("results")]
        public string[] PDFFile { get; set; }
    }

    public class Resp200ImageStampExif
    {
        [JsonProperty("result")]
        public string StampedImage { get; set; }

        [JsonProperty("printedTags")]
        public string[] PrintedTags { get; set; }
    }

    public class Resp200PdfFillForm
    {
        [JsonProperty("result")]
        public string PDFFile { get; set; }
    }

    public class Resp200PdfGetFormData
    {
        [JsonProperty("result")]
        public JToken FormData { get; set; }
    }

    public class Resp200PdfMergeSimple
    {
        [JsonProperty("result")]
        public string PDFFile { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Sparsepowerboxtools;

    public partial class WorkflowManagedActions
    {
        public SparsepowerboxtoolsActions Sparsepowerboxtools(string connectionId) => new SparsepowerboxtoolsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SparsepowerboxtoolsTriggers Sparsepowerboxtools(string connectionId) => new SparsepowerboxtoolsTriggers(connectionId);
    }
}