//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Sparsepowerboxtools
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SparsepowerboxtoolsActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sparsepowerboxtools")]
        [WorkflowExpressionFactory(nameof(__BuildPdfStampImage))]
        public IBodyWorkflowAction<Resp200PdfStampImage> PdfStampImage([WorkflowExpression] Func<string> reqPdfStampImagepDF, [WorkflowExpression] Func<string> reqPdfStampImageimage, [WorkflowExpression] Func<double> reqPdfStampImageoptionsopacity = null, [WorkflowExpression] Func<double> reqPdfStampImageoptionsscale = null, [WorkflowExpression] Func<int> reqPdfStampImageoptionsrotate = null, [WorkflowExpression] Func<int> reqPdfStampImageoptionspositionyOffset = null, [WorkflowExpression] Func<string> reqPdfStampImageoptionspositionstartOfYOffset = null, [WorkflowExpression] Func<int> reqPdfStampImageoptionspositionxOffset = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Resp200PdfStampImage> __BuildPdfStampImage(WorkflowExpression<string> reqPdfStampImagepDF, WorkflowExpression<string> reqPdfStampImageimage, WorkflowExpression<double> reqPdfStampImageoptionsopacity = null, WorkflowExpression<double> reqPdfStampImageoptionsscale = null, WorkflowExpression<int> reqPdfStampImageoptionsrotate = null, WorkflowExpression<int> reqPdfStampImageoptionspositionyOffset = null, WorkflowExpression<string> reqPdfStampImageoptionspositionstartOfYOffset = null, WorkflowExpression<int> reqPdfStampImageoptionspositionxOffset = null)
        {
            WorkflowExpression.Validate(reqPdfStampImagepDF, nameof(reqPdfStampImagepDF), required: true);
            WorkflowExpression.Validate(reqPdfStampImageimage, nameof(reqPdfStampImageimage), required: true);
            WorkflowExpression.Validate(reqPdfStampImageoptionsopacity, nameof(reqPdfStampImageoptionsopacity), required: false);
            WorkflowExpression.Validate(reqPdfStampImageoptionsscale, nameof(reqPdfStampImageoptionsscale), required: false);
            WorkflowExpression.Validate(reqPdfStampImageoptionsrotate, nameof(reqPdfStampImageoptionsrotate), required: false);
            WorkflowExpression.Validate(reqPdfStampImageoptionspositionyOffset, nameof(reqPdfStampImageoptionspositionyOffset), required: false);
            WorkflowExpression.Validate(reqPdfStampImageoptionspositionstartOfYOffset, nameof(reqPdfStampImageoptionspositionstartOfYOffset), required: false);
            WorkflowExpression.Validate(reqPdfStampImageoptionspositionxOffset, nameof(reqPdfStampImageoptionspositionxOffset), required: false);
            return new DeferredBodyAction<Resp200PdfStampImage>(() =>
            {
                var apiCallPath = "/pdf/stamp/image";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqPdfStampImage = new JObject();
                var reqPdfStampImagepropCount = 0;
                reqPdfStampImagepropCount++;
                reqPdfStampImage["pdf"] = ExpressionConverter.ConvertO(reqPdfStampImagepDF);
                reqPdfStampImagepropCount++;
                reqPdfStampImage["image"] = ExpressionConverter.ConvertO(reqPdfStampImageimage);
                var optionsObject = new JObject();
                var optionsObjectpropCount = 0;
                if (reqPdfStampImageoptionsopacity != null)
                {
                    if (reqPdfStampImageoptionsopacity != null)
                    {
                        optionsObject["opacity"] = ExpressionConverter.ConvertO(reqPdfStampImageoptionsopacity);
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
                        optionsObject["scale"] = ExpressionConverter.ConvertO(reqPdfStampImageoptionsscale);
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
                        optionsObject["rotate"] = ExpressionConverter.ConvertO(reqPdfStampImageoptionsrotate);
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
                        positionObject["yOffset"] = ExpressionConverter.ConvertO(reqPdfStampImageoptionspositionyOffset);
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
                        positionObject["yOffsetStart"] = ExpressionConverter.ConvertO(reqPdfStampImageoptionspositionstartOfYOffset);
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
                        positionObject["xOffset"] = ExpressionConverter.ConvertO(reqPdfStampImageoptionspositionxOffset);
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

                return new ApiConnectionAction<Resp200PdfStampImage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sparsepowerboxtools")]
        [WorkflowExpressionFactory(nameof(__BuildExcelSheetAddRows))]
        public IBodyWorkflowAction<Resp200ExcelSheetAddRows> ExcelSheetAddRows([WorkflowExpression] Func<string> reqExcelSheetAddrowssheetname, [WorkflowExpression] Func<string> reqExcelSheetAddrowsexcel, [WorkflowExpression] Func<JToken[]> reqExcelSheetAddrowsdata = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Resp200ExcelSheetAddRows> __BuildExcelSheetAddRows(WorkflowExpression<string> reqExcelSheetAddrowssheetname, WorkflowExpression<string> reqExcelSheetAddrowsexcel, WorkflowExpression<JToken[]> reqExcelSheetAddrowsdata = null)
        {
            WorkflowExpression.Validate(reqExcelSheetAddrowssheetname, nameof(reqExcelSheetAddrowssheetname), required: true);
            WorkflowExpression.Validate(reqExcelSheetAddrowsexcel, nameof(reqExcelSheetAddrowsexcel), required: true);
            WorkflowExpression.Validate(reqExcelSheetAddrowsdata, nameof(reqExcelSheetAddrowsdata), required: false);
            return new DeferredBodyAction<Resp200ExcelSheetAddRows>(() =>
            {
                var apiCallPath = "/excel/sheet/add-rows";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqExcelSheetAddrows = new JObject();
                var reqExcelSheetAddrowspropCount = 0;
                reqExcelSheetAddrowspropCount++;
                reqExcelSheetAddrows["sheet"] = ExpressionConverter.ConvertO(reqExcelSheetAddrowssheetname);
                if (reqExcelSheetAddrowsdata != null)
                {
                    reqExcelSheetAddrows["data"] = ExpressionConverter.ConvertO(reqExcelSheetAddrowsdata);
                    reqExcelSheetAddrowspropCount++;
                }

                reqExcelSheetAddrowspropCount++;
                reqExcelSheetAddrows["excelFile"] = ExpressionConverter.ConvertO(reqExcelSheetAddrowsexcel);
                if (reqExcelSheetAddrowspropCount > 0)
                {
                    callPayload.Body = reqExcelSheetAddrows;
                }

                return new ApiConnectionAction<Resp200ExcelSheetAddRows>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sparsepowerboxtools")]
        [WorkflowExpressionFactory(nameof(__BuildPdfCreateByHtml))]
        public IBodyWorkflowAction<Resp200PdfCreateByHtml> PdfCreateByHtml([WorkflowExpression] Func<string> reqPdfCreateByHtmlhTML, [WorkflowExpression] Func<string> reqPdfCreateByHtmloptionsmediaType = null, [WorkflowExpression] Func<string> reqPdfCreateByHtmloptionspageFormat = null, [WorkflowExpression] Func<bool> reqPdfCreateByHtmloptionslandscape = null, [WorkflowExpression] Func<string> reqPdfCreateByHtmloptionsmarginmarginLeft = null, [WorkflowExpression] Func<string> reqPdfCreateByHtmloptionsmarginmarginRight = null, [WorkflowExpression] Func<string> reqPdfCreateByHtmloptionsmarginmarginTop = null, [WorkflowExpression] Func<string> reqPdfCreateByHtmloptionsmarginmarginBottom = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Resp200PdfCreateByHtml> __BuildPdfCreateByHtml(WorkflowExpression<string> reqPdfCreateByHtmlhTML, WorkflowExpression<string> reqPdfCreateByHtmloptionsmediaType = null, WorkflowExpression<string> reqPdfCreateByHtmloptionspageFormat = null, WorkflowExpression<bool> reqPdfCreateByHtmloptionslandscape = null, WorkflowExpression<string> reqPdfCreateByHtmloptionsmarginmarginLeft = null, WorkflowExpression<string> reqPdfCreateByHtmloptionsmarginmarginRight = null, WorkflowExpression<string> reqPdfCreateByHtmloptionsmarginmarginTop = null, WorkflowExpression<string> reqPdfCreateByHtmloptionsmarginmarginBottom = null)
        {
            WorkflowExpression.Validate(reqPdfCreateByHtmlhTML, nameof(reqPdfCreateByHtmlhTML), required: true);
            WorkflowExpression.Validate(reqPdfCreateByHtmloptionsmediaType, nameof(reqPdfCreateByHtmloptionsmediaType), required: false);
            WorkflowExpression.Validate(reqPdfCreateByHtmloptionspageFormat, nameof(reqPdfCreateByHtmloptionspageFormat), required: false);
            WorkflowExpression.Validate(reqPdfCreateByHtmloptionslandscape, nameof(reqPdfCreateByHtmloptionslandscape), required: false);
            WorkflowExpression.Validate(reqPdfCreateByHtmloptionsmarginmarginLeft, nameof(reqPdfCreateByHtmloptionsmarginmarginLeft), required: false);
            WorkflowExpression.Validate(reqPdfCreateByHtmloptionsmarginmarginRight, nameof(reqPdfCreateByHtmloptionsmarginmarginRight), required: false);
            WorkflowExpression.Validate(reqPdfCreateByHtmloptionsmarginmarginTop, nameof(reqPdfCreateByHtmloptionsmarginmarginTop), required: false);
            WorkflowExpression.Validate(reqPdfCreateByHtmloptionsmarginmarginBottom, nameof(reqPdfCreateByHtmloptionsmarginmarginBottom), required: false);
            return new DeferredBodyAction<Resp200PdfCreateByHtml>(() =>
            {
                var apiCallPath = "/pdf/create/by-html";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqPdfCreateByHtml = new JObject();
                var reqPdfCreateByHtmlpropCount = 0;
                reqPdfCreateByHtmlpropCount++;
                reqPdfCreateByHtml["content"] = ExpressionConverter.ConvertO(reqPdfCreateByHtmlhTML);
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
                        optionsObject["mediaType"] = ExpressionConverter.ConvertO(reqPdfCreateByHtmloptionsmediaType);
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
                        optionsObject["format"] = ExpressionConverter.ConvertO(reqPdfCreateByHtmloptionspageFormat);
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
                        optionsObject["landscape"] = ExpressionConverter.ConvertO(reqPdfCreateByHtmloptionslandscape);
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
                        marginObject["left"] = ExpressionConverter.ConvertO(reqPdfCreateByHtmloptionsmarginmarginLeft);
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
                        marginObject["right"] = ExpressionConverter.ConvertO(reqPdfCreateByHtmloptionsmarginmarginRight);
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
                        marginObject["top"] = ExpressionConverter.ConvertO(reqPdfCreateByHtmloptionsmarginmarginTop);
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
                        marginObject["bottom"] = ExpressionConverter.ConvertO(reqPdfCreateByHtmloptionsmarginmarginBottom);
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

                return new ApiConnectionAction<Resp200PdfCreateByHtml>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sparsepowerboxtools")]
        [WorkflowExpressionFactory(nameof(__BuildImageMergeDrawing))]
        public IBodyWorkflowAction<Resp200ImageMergeDrawing> ImageMergeDrawing([WorkflowExpression] Func<string> reqImageMergeDrawingbackground, [WorkflowExpression] Func<string> reqImageMergeDrawingdrawing)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Resp200ImageMergeDrawing> __BuildImageMergeDrawing(WorkflowExpression<string> reqImageMergeDrawingbackground, WorkflowExpression<string> reqImageMergeDrawingdrawing)
        {
            WorkflowExpression.Validate(reqImageMergeDrawingbackground, nameof(reqImageMergeDrawingbackground), required: true);
            WorkflowExpression.Validate(reqImageMergeDrawingdrawing, nameof(reqImageMergeDrawingdrawing), required: true);
            return new DeferredBodyAction<Resp200ImageMergeDrawing>(() =>
            {
                var apiCallPath = "/image/merge/drawing";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqImageMergeDrawing = new JObject();
                var reqImageMergeDrawingpropCount = 0;
                reqImageMergeDrawingpropCount++;
                reqImageMergeDrawing["background"] = ExpressionConverter.ConvertO(reqImageMergeDrawingbackground);
                reqImageMergeDrawingpropCount++;
                reqImageMergeDrawing["drawing"] = ExpressionConverter.ConvertO(reqImageMergeDrawingdrawing);
                if (reqImageMergeDrawingpropCount > 0)
                {
                    callPayload.Body = reqImageMergeDrawing;
                }

                return new ApiConnectionAction<Resp200ImageMergeDrawing>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sparsepowerboxtools")]
        [WorkflowExpressionFactory(nameof(__BuildPdfStampText))]
        public IBodyWorkflowAction<Resp200PdfStampText> PdfStampText([WorkflowExpression] Func<string> reqPdfStampTextpDF, [WorkflowExpression] Func<string> reqPdfStampTexttext, [WorkflowExpression] Func<string> reqPdfStampTextoptionsfontColor = null, [WorkflowExpression] Func<int> reqPdfStampTextoptionsfontSize = null, [WorkflowExpression] Func<int> reqPdfStampTextoptionsrotate = null, [WorkflowExpression] Func<int> reqPdfStampTextoptionspositionyOffset = null, [WorkflowExpression] Func<string> reqPdfStampTextoptionspositionstartOfYOffset = null, [WorkflowExpression] Func<int> reqPdfStampTextoptionspositionxOffset = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Resp200PdfStampText> __BuildPdfStampText(WorkflowExpression<string> reqPdfStampTextpDF, WorkflowExpression<string> reqPdfStampTexttext, WorkflowExpression<string> reqPdfStampTextoptionsfontColor = null, WorkflowExpression<int> reqPdfStampTextoptionsfontSize = null, WorkflowExpression<int> reqPdfStampTextoptionsrotate = null, WorkflowExpression<int> reqPdfStampTextoptionspositionyOffset = null, WorkflowExpression<string> reqPdfStampTextoptionspositionstartOfYOffset = null, WorkflowExpression<int> reqPdfStampTextoptionspositionxOffset = null)
        {
            WorkflowExpression.Validate(reqPdfStampTextpDF, nameof(reqPdfStampTextpDF), required: true);
            WorkflowExpression.Validate(reqPdfStampTexttext, nameof(reqPdfStampTexttext), required: true);
            WorkflowExpression.Validate(reqPdfStampTextoptionsfontColor, nameof(reqPdfStampTextoptionsfontColor), required: false);
            WorkflowExpression.Validate(reqPdfStampTextoptionsfontSize, nameof(reqPdfStampTextoptionsfontSize), required: false);
            WorkflowExpression.Validate(reqPdfStampTextoptionsrotate, nameof(reqPdfStampTextoptionsrotate), required: false);
            WorkflowExpression.Validate(reqPdfStampTextoptionspositionyOffset, nameof(reqPdfStampTextoptionspositionyOffset), required: false);
            WorkflowExpression.Validate(reqPdfStampTextoptionspositionstartOfYOffset, nameof(reqPdfStampTextoptionspositionstartOfYOffset), required: false);
            WorkflowExpression.Validate(reqPdfStampTextoptionspositionxOffset, nameof(reqPdfStampTextoptionspositionxOffset), required: false);
            return new DeferredBodyAction<Resp200PdfStampText>(() =>
            {
                var apiCallPath = "/pdf/stamp/text";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqPdfStampText = new JObject();
                var reqPdfStampTextpropCount = 0;
                reqPdfStampTextpropCount++;
                reqPdfStampText["pdf"] = ExpressionConverter.ConvertO(reqPdfStampTextpDF);
                reqPdfStampTextpropCount++;
                reqPdfStampText["text"] = ExpressionConverter.ConvertO(reqPdfStampTexttext);
                var optionsObject = new JObject();
                var optionsObjectpropCount = 0;
                if (reqPdfStampTextoptionsfontColor != null)
                {
                    if (reqPdfStampTextoptionsfontColor != null)
                    {
                        optionsObject["color"] = ExpressionConverter.ConvertO(reqPdfStampTextoptionsfontColor);
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
                        optionsObject["size"] = ExpressionConverter.ConvertO(reqPdfStampTextoptionsfontSize);
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
                        optionsObject["rotate"] = ExpressionConverter.ConvertO(reqPdfStampTextoptionsrotate);
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
                        positionObject["yOffset"] = ExpressionConverter.ConvertO(reqPdfStampTextoptionspositionyOffset);
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
                        positionObject["yOffsetStart"] = ExpressionConverter.ConvertO(reqPdfStampTextoptionspositionstartOfYOffset);
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
                        positionObject["xOffset"] = ExpressionConverter.ConvertO(reqPdfStampTextoptionspositionxOffset);
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

                return new ApiConnectionAction<Resp200PdfStampText>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sparsepowerboxtools")]
        [WorkflowExpressionFactory(nameof(__BuildCsvToJson))]
        public IBodyWorkflowAction<Resp200CsvToJson> CsvToJson([WorkflowExpression] Func<string> reqCsvToJsoncSV, [WorkflowExpression] Func<bool> reqCsvToJsonoptionshasHeaders = null, [WorkflowExpression] Func<string> reqCsvToJsonoptionsdelimiter = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Resp200CsvToJson> __BuildCsvToJson(WorkflowExpression<string> reqCsvToJsoncSV, WorkflowExpression<bool> reqCsvToJsonoptionshasHeaders = null, WorkflowExpression<string> reqCsvToJsonoptionsdelimiter = null)
        {
            WorkflowExpression.Validate(reqCsvToJsoncSV, nameof(reqCsvToJsoncSV), required: true);
            WorkflowExpression.Validate(reqCsvToJsonoptionshasHeaders, nameof(reqCsvToJsonoptionshasHeaders), required: false);
            WorkflowExpression.Validate(reqCsvToJsonoptionsdelimiter, nameof(reqCsvToJsonoptionsdelimiter), required: false);
            return new DeferredBodyAction<Resp200CsvToJson>(() =>
            {
                var apiCallPath = "/csv/to-json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqCsvToJson = new JObject();
                var reqCsvToJsonpropCount = 0;
                reqCsvToJsonpropCount++;
                reqCsvToJson["csv"] = ExpressionConverter.ConvertO(reqCsvToJsoncSV);
                var optionsObject = new JObject();
                var optionsObjectpropCount = 0;
                if (reqCsvToJsonoptionshasHeaders != null)
                {
                    if (reqCsvToJsonoptionshasHeaders != null)
                    {
                        optionsObject["hasHeaders"] = ExpressionConverter.ConvertO(reqCsvToJsonoptionshasHeaders);
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
                        optionsObject["delimiter"] = ExpressionConverter.ConvertO(reqCsvToJsonoptionsdelimiter);
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

                return new ApiConnectionAction<Resp200CsvToJson>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sparsepowerboxtools")]
        [WorkflowExpressionFactory(nameof(__BuildPdfCreateByUrl))]
        public IBodyWorkflowAction<Resp200PdfCreateByUrl> PdfCreateByUrl([WorkflowExpression] Func<string> reqPdfCreateByUrlhTML, [WorkflowExpression] Func<string> reqPdfCreateByUrloptionsmediaType = null, [WorkflowExpression] Func<string> reqPdfCreateByUrloptionspageFormat = null, [WorkflowExpression] Func<bool> reqPdfCreateByUrloptionslandscape = null, [WorkflowExpression] Func<string> reqPdfCreateByUrloptionsmarginmarginLeft = null, [WorkflowExpression] Func<string> reqPdfCreateByUrloptionsmarginmarginRight = null, [WorkflowExpression] Func<string> reqPdfCreateByUrloptionsmarginmarginTop = null, [WorkflowExpression] Func<string> reqPdfCreateByUrloptionsmarginmarginBottom = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Resp200PdfCreateByUrl> __BuildPdfCreateByUrl(WorkflowExpression<string> reqPdfCreateByUrlhTML, WorkflowExpression<string> reqPdfCreateByUrloptionsmediaType = null, WorkflowExpression<string> reqPdfCreateByUrloptionspageFormat = null, WorkflowExpression<bool> reqPdfCreateByUrloptionslandscape = null, WorkflowExpression<string> reqPdfCreateByUrloptionsmarginmarginLeft = null, WorkflowExpression<string> reqPdfCreateByUrloptionsmarginmarginRight = null, WorkflowExpression<string> reqPdfCreateByUrloptionsmarginmarginTop = null, WorkflowExpression<string> reqPdfCreateByUrloptionsmarginmarginBottom = null)
        {
            WorkflowExpression.Validate(reqPdfCreateByUrlhTML, nameof(reqPdfCreateByUrlhTML), required: true);
            WorkflowExpression.Validate(reqPdfCreateByUrloptionsmediaType, nameof(reqPdfCreateByUrloptionsmediaType), required: false);
            WorkflowExpression.Validate(reqPdfCreateByUrloptionspageFormat, nameof(reqPdfCreateByUrloptionspageFormat), required: false);
            WorkflowExpression.Validate(reqPdfCreateByUrloptionslandscape, nameof(reqPdfCreateByUrloptionslandscape), required: false);
            WorkflowExpression.Validate(reqPdfCreateByUrloptionsmarginmarginLeft, nameof(reqPdfCreateByUrloptionsmarginmarginLeft), required: false);
            WorkflowExpression.Validate(reqPdfCreateByUrloptionsmarginmarginRight, nameof(reqPdfCreateByUrloptionsmarginmarginRight), required: false);
            WorkflowExpression.Validate(reqPdfCreateByUrloptionsmarginmarginTop, nameof(reqPdfCreateByUrloptionsmarginmarginTop), required: false);
            WorkflowExpression.Validate(reqPdfCreateByUrloptionsmarginmarginBottom, nameof(reqPdfCreateByUrloptionsmarginmarginBottom), required: false);
            return new DeferredBodyAction<Resp200PdfCreateByUrl>(() =>
            {
                var apiCallPath = "/pdf/create/by-url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqPdfCreateByUrl = new JObject();
                var reqPdfCreateByUrlpropCount = 0;
                reqPdfCreateByUrlpropCount++;
                reqPdfCreateByUrl["url"] = ExpressionConverter.ConvertO(reqPdfCreateByUrlhTML);
                var optionsObject = new JObject();
                var optionsObjectpropCount = 0;
                if (reqPdfCreateByUrloptionsmediaType != null)
                {
                    if (reqPdfCreateByUrloptionsmediaType != null)
                    {
                        optionsObject["mediaType"] = ExpressionConverter.ConvertO(reqPdfCreateByUrloptionsmediaType);
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
                        optionsObject["format"] = ExpressionConverter.ConvertO(reqPdfCreateByUrloptionspageFormat);
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
                        optionsObject["landscape"] = ExpressionConverter.ConvertO(reqPdfCreateByUrloptionslandscape);
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
                        marginObject["left"] = ExpressionConverter.ConvertO(reqPdfCreateByUrloptionsmarginmarginLeft);
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
                        marginObject["right"] = ExpressionConverter.ConvertO(reqPdfCreateByUrloptionsmarginmarginRight);
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
                        marginObject["top"] = ExpressionConverter.ConvertO(reqPdfCreateByUrloptionsmarginmarginTop);
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
                        marginObject["bottom"] = ExpressionConverter.ConvertO(reqPdfCreateByUrloptionsmarginmarginBottom);
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

                return new ApiConnectionAction<Resp200PdfCreateByUrl>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sparsepowerboxtools")]
        [WorkflowExpressionFactory(nameof(__BuildImageStampText))]
        public IBodyWorkflowAction<Resp200ImageStampText> ImageStampText([WorkflowExpression] Func<string> reqImageStampTextimage = null, [WorkflowExpression] Func<string> reqImageStampTexttextToStamp = null, [WorkflowExpression] Func<string> reqImageStampTextoptionslocationOfTheStamp = null, [WorkflowExpression] Func<string> reqImageStampTextoptionsfontcolor = null, [WorkflowExpression] Func<int> reqImageStampTextoptionsfontsize = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Resp200ImageStampText> __BuildImageStampText(WorkflowExpression<string> reqImageStampTextimage = null, WorkflowExpression<string> reqImageStampTexttextToStamp = null, WorkflowExpression<string> reqImageStampTextoptionslocationOfTheStamp = null, WorkflowExpression<string> reqImageStampTextoptionsfontcolor = null, WorkflowExpression<int> reqImageStampTextoptionsfontsize = null)
        {
            WorkflowExpression.Validate(reqImageStampTextimage, nameof(reqImageStampTextimage), required: false);
            WorkflowExpression.Validate(reqImageStampTexttextToStamp, nameof(reqImageStampTexttextToStamp), required: false);
            WorkflowExpression.Validate(reqImageStampTextoptionslocationOfTheStamp, nameof(reqImageStampTextoptionslocationOfTheStamp), required: false);
            WorkflowExpression.Validate(reqImageStampTextoptionsfontcolor, nameof(reqImageStampTextoptionsfontcolor), required: false);
            WorkflowExpression.Validate(reqImageStampTextoptionsfontsize, nameof(reqImageStampTextoptionsfontsize), required: false);
            return new DeferredBodyAction<Resp200ImageStampText>(() =>
            {
                var apiCallPath = "/image/stamp/text";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqImageStampText = new JObject();
                var reqImageStampTextpropCount = 0;
                if (reqImageStampTextimage != null)
                {
                    reqImageStampText["image"] = ExpressionConverter.ConvertO(reqImageStampTextimage);
                    reqImageStampTextpropCount++;
                }

                if (reqImageStampTexttextToStamp != null)
                {
                    reqImageStampText["text"] = ExpressionConverter.ConvertO(reqImageStampTexttextToStamp);
                    reqImageStampTextpropCount++;
                }

                var optionsObject = new JObject();
                var optionsObjectpropCount = 0;
                if (reqImageStampTextoptionslocationOfTheStamp != null)
                {
                    if (reqImageStampTextoptionslocationOfTheStamp != null)
                    {
                        optionsObject["location"] = ExpressionConverter.ConvertO(reqImageStampTextoptionslocationOfTheStamp);
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
                        optionsObject["fontColor"] = ExpressionConverter.ConvertO(reqImageStampTextoptionsfontcolor);
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
                        optionsObject["fontSize"] = ExpressionConverter.ConvertO(reqImageStampTextoptionsfontsize);
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

                return new ApiConnectionAction<Resp200ImageStampText>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sparsepowerboxtools")]
        [WorkflowExpressionFactory(nameof(__BuildImageResize))]
        public IBodyWorkflowAction<Resp200ImageResize> ImageResize([WorkflowExpression] Func<string> reqImageResizeimage = null, [WorkflowExpression] Func<int> reqImageResizewidth = null, [WorkflowExpression] Func<int> reqImageResizeheight = null, [WorkflowExpression] Func<bool> reqImageResizeoptionsignoreTheAspectRation = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Resp200ImageResize> __BuildImageResize(WorkflowExpression<string> reqImageResizeimage = null, WorkflowExpression<int> reqImageResizewidth = null, WorkflowExpression<int> reqImageResizeheight = null, WorkflowExpression<bool> reqImageResizeoptionsignoreTheAspectRation = null)
        {
            WorkflowExpression.Validate(reqImageResizeimage, nameof(reqImageResizeimage), required: false);
            WorkflowExpression.Validate(reqImageResizewidth, nameof(reqImageResizewidth), required: false);
            WorkflowExpression.Validate(reqImageResizeheight, nameof(reqImageResizeheight), required: false);
            WorkflowExpression.Validate(reqImageResizeoptionsignoreTheAspectRation, nameof(reqImageResizeoptionsignoreTheAspectRation), required: false);
            return new DeferredBodyAction<Resp200ImageResize>(() =>
            {
                var apiCallPath = "/image/resize";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqImageResize = new JObject();
                var reqImageResizepropCount = 0;
                if (reqImageResizeimage != null)
                {
                    reqImageResize["image"] = ExpressionConverter.ConvertO(reqImageResizeimage);
                    reqImageResizepropCount++;
                }

                if (reqImageResizewidth != null)
                {
                    reqImageResize["width"] = ExpressionConverter.ConvertO(reqImageResizewidth);
                    reqImageResizepropCount++;
                }

                if (reqImageResizeheight != null)
                {
                    reqImageResize["height"] = ExpressionConverter.ConvertO(reqImageResizeheight);
                    reqImageResizepropCount++;
                }

                var optionsObject = new JObject();
                var optionsObjectpropCount = 0;
                if (reqImageResizeoptionsignoreTheAspectRation != null)
                {
                    if (reqImageResizeoptionsignoreTheAspectRation != null)
                    {
                        optionsObject["ignoreAspectRation"] = ExpressionConverter.ConvertO(reqImageResizeoptionsignoreTheAspectRation);
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

                return new ApiConnectionAction<Resp200ImageResize>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sparsepowerboxtools")]
        [WorkflowExpressionFactory(nameof(__BuildPdfSplitByPage))]
        public IBodyWorkflowAction<Resp200PdfSplitByPage> PdfSplitByPage([WorkflowExpression] Func<string> reqPdfSplitByPagepDFFile = null, [WorkflowExpression] Func<double> reqPdfSplitByPageoptionsnumberOfPages = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Resp200PdfSplitByPage> __BuildPdfSplitByPage(WorkflowExpression<string> reqPdfSplitByPagepDFFile = null, WorkflowExpression<double> reqPdfSplitByPageoptionsnumberOfPages = null)
        {
            WorkflowExpression.Validate(reqPdfSplitByPagepDFFile, nameof(reqPdfSplitByPagepDFFile), required: false);
            WorkflowExpression.Validate(reqPdfSplitByPageoptionsnumberOfPages, nameof(reqPdfSplitByPageoptionsnumberOfPages), required: false);
            return new DeferredBodyAction<Resp200PdfSplitByPage>(() =>
            {
                var apiCallPath = "/pdf/split/by-page";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqPdfSplitByPage = new JObject();
                var reqPdfSplitByPagepropCount = 0;
                if (reqPdfSplitByPagepDFFile != null)
                {
                    reqPdfSplitByPage["pdf"] = ExpressionConverter.ConvertO(reqPdfSplitByPagepDFFile);
                    reqPdfSplitByPagepropCount++;
                }

                var optionsObject = new JObject();
                var optionsObjectpropCount = 0;
                if (reqPdfSplitByPageoptionsnumberOfPages != null)
                {
                    if (reqPdfSplitByPageoptionsnumberOfPages != null)
                    {
                        optionsObject["numberOfPages"] = ExpressionConverter.ConvertO(reqPdfSplitByPageoptionsnumberOfPages);
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

                return new ApiConnectionAction<Resp200PdfSplitByPage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sparsepowerboxtools")]
        [WorkflowExpressionFactory(nameof(__BuildImageStampExif))]
        public IBodyWorkflowAction<Resp200ImageStampExif> ImageStampExif([WorkflowExpression] Func<string> reqImageStampExifimage = null, [WorkflowExpression] Func<string[]> reqImageStampExifoptionstags = null, [WorkflowExpression] Func<string> reqImageStampExifoptionslocationOfTheStamp = null, [WorkflowExpression] Func<string> reqImageStampExifoptionsfontcolor = null, [WorkflowExpression] Func<int> reqImageStampExifoptionsfontsize = null, [WorkflowExpression] Func<bool> reqImageStampExifoptionsprintTagName = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Resp200ImageStampExif> __BuildImageStampExif(WorkflowExpression<string> reqImageStampExifimage = null, WorkflowExpression<string[]> reqImageStampExifoptionstags = null, WorkflowExpression<string> reqImageStampExifoptionslocationOfTheStamp = null, WorkflowExpression<string> reqImageStampExifoptionsfontcolor = null, WorkflowExpression<int> reqImageStampExifoptionsfontsize = null, WorkflowExpression<bool> reqImageStampExifoptionsprintTagName = null)
        {
            WorkflowExpression.Validate(reqImageStampExifimage, nameof(reqImageStampExifimage), required: false);
            WorkflowExpression.Validate(reqImageStampExifoptionstags, nameof(reqImageStampExifoptionstags), required: false);
            WorkflowExpression.Validate(reqImageStampExifoptionslocationOfTheStamp, nameof(reqImageStampExifoptionslocationOfTheStamp), required: false);
            WorkflowExpression.Validate(reqImageStampExifoptionsfontcolor, nameof(reqImageStampExifoptionsfontcolor), required: false);
            WorkflowExpression.Validate(reqImageStampExifoptionsfontsize, nameof(reqImageStampExifoptionsfontsize), required: false);
            WorkflowExpression.Validate(reqImageStampExifoptionsprintTagName, nameof(reqImageStampExifoptionsprintTagName), required: false);
            return new DeferredBodyAction<Resp200ImageStampExif>(() =>
            {
                var apiCallPath = "/image/stamp/exif";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqImageStampExif = new JObject();
                var reqImageStampExifpropCount = 0;
                if (reqImageStampExifimage != null)
                {
                    reqImageStampExif["image"] = ExpressionConverter.ConvertO(reqImageStampExifimage);
                    reqImageStampExifpropCount++;
                }

                var optionsObject = new JObject();
                var optionsObjectpropCount = 0;
                if (reqImageStampExifoptionstags != null)
                {
                    optionsObject["tags"] = ExpressionConverter.ConvertO(reqImageStampExifoptionstags);
                    optionsObjectpropCount++;
                }

                if (reqImageStampExifoptionslocationOfTheStamp != null)
                {
                    if (reqImageStampExifoptionslocationOfTheStamp != null)
                    {
                        optionsObject["location"] = ExpressionConverter.ConvertO(reqImageStampExifoptionslocationOfTheStamp);
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
                        optionsObject["fontColor"] = ExpressionConverter.ConvertO(reqImageStampExifoptionsfontcolor);
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
                        optionsObject["fontSize"] = ExpressionConverter.ConvertO(reqImageStampExifoptionsfontsize);
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
                        optionsObject["printTagName"] = ExpressionConverter.ConvertO(reqImageStampExifoptionsprintTagName);
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

                return new ApiConnectionAction<Resp200ImageStampExif>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sparsepowerboxtools")]
        [WorkflowExpressionFactory(nameof(__BuildPdfFillForm))]
        public IBodyWorkflowAction<Resp200PdfFillForm> PdfFillForm([WorkflowExpression] Func<string> reqPdfFillFormpDFFile = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Resp200PdfFillForm> __BuildPdfFillForm(WorkflowExpression<string> reqPdfFillFormpDFFile = null)
        {
            WorkflowExpression.Validate(reqPdfFillFormpDFFile, nameof(reqPdfFillFormpDFFile), required: false);
            return new DeferredBodyAction<Resp200PdfFillForm>(() =>
            {
                var apiCallPath = "/form/fill";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqPdfFillForm = new JObject();
                var reqPdfFillFormpropCount = 0;
                if (reqPdfFillFormpDFFile != null)
                {
                    reqPdfFillForm["pdf"] = ExpressionConverter.ConvertO(reqPdfFillFormpDFFile);
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

                return new ApiConnectionAction<Resp200PdfFillForm>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sparsepowerboxtools")]
        [WorkflowExpressionFactory(nameof(__BuildPdfGetFormData))]
        public IBodyWorkflowAction<Resp200PdfGetFormData> PdfGetFormData([WorkflowExpression] Func<string> reqPdfGetFormDatapDFFile = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Resp200PdfGetFormData> __BuildPdfGetFormData(WorkflowExpression<string> reqPdfGetFormDatapDFFile = null)
        {
            WorkflowExpression.Validate(reqPdfGetFormDatapDFFile, nameof(reqPdfGetFormDatapDFFile), required: false);
            return new DeferredBodyAction<Resp200PdfGetFormData>(() =>
            {
                var apiCallPath = "/form/getdata";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqPdfGetFormData = new JObject();
                var reqPdfGetFormDatapropCount = 0;
                if (reqPdfGetFormDatapDFFile != null)
                {
                    reqPdfGetFormData["pdf"] = ExpressionConverter.ConvertO(reqPdfGetFormDatapDFFile);
                    reqPdfGetFormDatapropCount++;
                }

                if (reqPdfGetFormDatapropCount > 0)
                {
                    callPayload.Body = reqPdfGetFormData;
                }

                return new ApiConnectionAction<Resp200PdfGetFormData>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sparsepowerboxtools")]
        [WorkflowExpressionFactory(nameof(__BuildPdfMergeSimple))]
        public IBodyWorkflowAction<Resp200PdfMergeSimple> PdfMergeSimple([WorkflowExpression] Func<string[]> reqPdfMergeSimplepDFFile = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Resp200PdfMergeSimple> __BuildPdfMergeSimple(WorkflowExpression<string[]> reqPdfMergeSimplepDFFile = null)
        {
            WorkflowExpression.Validate(reqPdfMergeSimplepDFFile, nameof(reqPdfMergeSimplepDFFile), required: false);
            return new DeferredBodyAction<Resp200PdfMergeSimple>(() =>
            {
                var apiCallPath = "/pdf/merge/simple";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqPdfMergeSimple = new JObject();
                var reqPdfMergeSimplepropCount = 0;
                if (reqPdfMergeSimplepDFFile != null)
                {
                    reqPdfMergeSimple["pdfs"] = ExpressionConverter.ConvertO(reqPdfMergeSimplepDFFile);
                    reqPdfMergeSimplepropCount++;
                }

                if (reqPdfMergeSimplepropCount > 0)
                {
                    callPayload.Body = reqPdfMergeSimple;
                }

                return new ApiConnectionAction<Resp200PdfMergeSimple>(callPayload);
            });
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