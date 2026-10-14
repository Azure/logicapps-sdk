//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Sparsepowerboxtools
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class SparsepowerboxtoolsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sparsepowerboxtools")]
        public IBodyWorkflowAction<Resp200PdfStampImage> PdfStampImage(Expression<Func<string>> reqPdfStampImagepDF, Expression<Func<string>> reqPdfStampImageimage, Expression<Func<double>> reqPdfStampImageoptionsopacity = null, Expression<Func<double>> reqPdfStampImageoptionsscale = null, Expression<Func<int>> reqPdfStampImageoptionsrotate = null, Expression<Func<int>> reqPdfStampImageoptionspositionyOffset = null, Expression<Func<string>> reqPdfStampImageoptionspositionstartOfYOffset = null, Expression<Func<int>> reqPdfStampImageoptionspositionxOffset = null)
        {
            var __workflow_reqPdfStampImagepDF = reqPdfStampImagepDF == null ? null : WorkflowExpression.Compile(reqPdfStampImagepDF);
            WorkflowExpression.Validate(__workflow_reqPdfStampImagepDF, nameof(reqPdfStampImagepDF), required: true);
            var __workflow_reqPdfStampImageimage = reqPdfStampImageimage == null ? null : WorkflowExpression.Compile(reqPdfStampImageimage);
            WorkflowExpression.Validate(__workflow_reqPdfStampImageimage, nameof(reqPdfStampImageimage), required: true);
            var __workflow_reqPdfStampImageoptionsopacity = reqPdfStampImageoptionsopacity == null ? null : WorkflowExpression.Compile(reqPdfStampImageoptionsopacity);
            WorkflowExpression.Validate(__workflow_reqPdfStampImageoptionsopacity, nameof(reqPdfStampImageoptionsopacity), required: false);
            var __workflow_reqPdfStampImageoptionsscale = reqPdfStampImageoptionsscale == null ? null : WorkflowExpression.Compile(reqPdfStampImageoptionsscale);
            WorkflowExpression.Validate(__workflow_reqPdfStampImageoptionsscale, nameof(reqPdfStampImageoptionsscale), required: false);
            var __workflow_reqPdfStampImageoptionsrotate = reqPdfStampImageoptionsrotate == null ? null : WorkflowExpression.Compile(reqPdfStampImageoptionsrotate);
            WorkflowExpression.Validate(__workflow_reqPdfStampImageoptionsrotate, nameof(reqPdfStampImageoptionsrotate), required: false);
            var __workflow_reqPdfStampImageoptionspositionyOffset = reqPdfStampImageoptionspositionyOffset == null ? null : WorkflowExpression.Compile(reqPdfStampImageoptionspositionyOffset);
            WorkflowExpression.Validate(__workflow_reqPdfStampImageoptionspositionyOffset, nameof(reqPdfStampImageoptionspositionyOffset), required: false);
            var __workflow_reqPdfStampImageoptionspositionstartOfYOffset = reqPdfStampImageoptionspositionstartOfYOffset == null ? null : WorkflowExpression.Compile(reqPdfStampImageoptionspositionstartOfYOffset);
            WorkflowExpression.Validate(__workflow_reqPdfStampImageoptionspositionstartOfYOffset, nameof(reqPdfStampImageoptionspositionstartOfYOffset), required: false);
            var __workflow_reqPdfStampImageoptionspositionxOffset = reqPdfStampImageoptionspositionxOffset == null ? null : WorkflowExpression.Compile(reqPdfStampImageoptionspositionxOffset);
            WorkflowExpression.Validate(__workflow_reqPdfStampImageoptionspositionxOffset, nameof(reqPdfStampImageoptionspositionxOffset), required: false);
            return new DeferredBodyAction<Resp200PdfStampImage>(() =>
            {
                var apiCallPath = "/pdf/stamp/image";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqPdfStampImage = new JObject();
                var reqPdfStampImagepropCount = 0;
                reqPdfStampImagepropCount++;
                reqPdfStampImage["pdf"] = ExpressionConverter.ConvertO(__workflow_reqPdfStampImagepDF);
                reqPdfStampImagepropCount++;
                reqPdfStampImage["image"] = ExpressionConverter.ConvertO(__workflow_reqPdfStampImageimage);
                var optionsObject = new JObject();
                var optionsObjectpropCount = 0;
                if (__workflow_reqPdfStampImageoptionsopacity != null)
                {
                    if (__workflow_reqPdfStampImageoptionsopacity != null)
                    {
                        optionsObject["opacity"] = ExpressionConverter.ConvertO(__workflow_reqPdfStampImageoptionsopacity);
                        optionsObjectpropCount++;
                    }

                    optionsObjectpropCount++;
                }
                else
                {
                    optionsObject["opacity"] = 1;
                    optionsObjectpropCount++;
                }

                if (__workflow_reqPdfStampImageoptionsscale != null)
                {
                    if (__workflow_reqPdfStampImageoptionsscale != null)
                    {
                        optionsObject["scale"] = ExpressionConverter.ConvertO(__workflow_reqPdfStampImageoptionsscale);
                        optionsObjectpropCount++;
                    }

                    optionsObjectpropCount++;
                }
                else
                {
                    optionsObject["scale"] = 1;
                    optionsObjectpropCount++;
                }

                if (__workflow_reqPdfStampImageoptionsrotate != null)
                {
                    if (__workflow_reqPdfStampImageoptionsrotate != null)
                    {
                        optionsObject["rotate"] = ExpressionConverter.ConvertO(__workflow_reqPdfStampImageoptionsrotate);
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
                if (__workflow_reqPdfStampImageoptionspositionyOffset != null)
                {
                    if (__workflow_reqPdfStampImageoptionspositionyOffset != null)
                    {
                        positionObject["yOffset"] = ExpressionConverter.ConvertO(__workflow_reqPdfStampImageoptionspositionyOffset);
                        positionObjectpropCount++;
                    }

                    positionObjectpropCount++;
                }
                else
                {
                    positionObject["yOffset"] = 25;
                    positionObjectpropCount++;
                }

                if (__workflow_reqPdfStampImageoptionspositionstartOfYOffset != null)
                {
                    if (__workflow_reqPdfStampImageoptionspositionstartOfYOffset != null)
                    {
                        positionObject["yOffsetStart"] = ExpressionConverter.ConvertO(__workflow_reqPdfStampImageoptionspositionstartOfYOffset);
                        positionObjectpropCount++;
                    }

                    positionObjectpropCount++;
                }
                else
                {
                    positionObject["yOffsetStart"] = "bottom";
                    positionObjectpropCount++;
                }

                if (__workflow_reqPdfStampImageoptionspositionxOffset != null)
                {
                    if (__workflow_reqPdfStampImageoptionspositionxOffset != null)
                    {
                        positionObject["xOffset"] = ExpressionConverter.ConvertO(__workflow_reqPdfStampImageoptionspositionxOffset);
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
        public IBodyWorkflowAction<Resp200ExcelSheetAddRows> ExcelSheetAddRows(Expression<Func<string>> reqExcelSheetAddrowssheetname, Expression<Func<string>> reqExcelSheetAddrowsexcel, Expression<Func<JToken[]>> reqExcelSheetAddrowsdata = null)
        {
            var __workflow_reqExcelSheetAddrowssheetname = reqExcelSheetAddrowssheetname == null ? null : WorkflowExpression.Compile(reqExcelSheetAddrowssheetname);
            WorkflowExpression.Validate(__workflow_reqExcelSheetAddrowssheetname, nameof(reqExcelSheetAddrowssheetname), required: true);
            var __workflow_reqExcelSheetAddrowsexcel = reqExcelSheetAddrowsexcel == null ? null : WorkflowExpression.Compile(reqExcelSheetAddrowsexcel);
            WorkflowExpression.Validate(__workflow_reqExcelSheetAddrowsexcel, nameof(reqExcelSheetAddrowsexcel), required: true);
            var __workflow_reqExcelSheetAddrowsdata = reqExcelSheetAddrowsdata == null ? null : WorkflowExpression.Compile(reqExcelSheetAddrowsdata);
            WorkflowExpression.Validate(__workflow_reqExcelSheetAddrowsdata, nameof(reqExcelSheetAddrowsdata), required: false);
            return new DeferredBodyAction<Resp200ExcelSheetAddRows>(() =>
            {
                var apiCallPath = "/excel/sheet/add-rows";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqExcelSheetAddrows = new JObject();
                var reqExcelSheetAddrowspropCount = 0;
                reqExcelSheetAddrowspropCount++;
                reqExcelSheetAddrows["sheet"] = ExpressionConverter.ConvertO(__workflow_reqExcelSheetAddrowssheetname);
                if (__workflow_reqExcelSheetAddrowsdata != null)
                {
                    reqExcelSheetAddrows["data"] = ExpressionConverter.ConvertO(__workflow_reqExcelSheetAddrowsdata);
                    reqExcelSheetAddrowspropCount++;
                }

                reqExcelSheetAddrowspropCount++;
                reqExcelSheetAddrows["excelFile"] = ExpressionConverter.ConvertO(__workflow_reqExcelSheetAddrowsexcel);
                if (reqExcelSheetAddrowspropCount > 0)
                {
                    callPayload.Body = reqExcelSheetAddrows;
                }

                return new ApiConnectionAction<Resp200ExcelSheetAddRows>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sparsepowerboxtools")]
        public IBodyWorkflowAction<Resp200PdfCreateByHtml> PdfCreateByHtml(Expression<Func<string>> reqPdfCreateByHtmlhTML, Expression<Func<string>> reqPdfCreateByHtmloptionsmediaType = null, Expression<Func<string>> reqPdfCreateByHtmloptionspageFormat = null, Expression<Func<bool>> reqPdfCreateByHtmloptionslandscape = null, Expression<Func<string>> reqPdfCreateByHtmloptionsmarginmarginLeft = null, Expression<Func<string>> reqPdfCreateByHtmloptionsmarginmarginRight = null, Expression<Func<string>> reqPdfCreateByHtmloptionsmarginmarginTop = null, Expression<Func<string>> reqPdfCreateByHtmloptionsmarginmarginBottom = null)
        {
            var __workflow_reqPdfCreateByHtmlhTML = reqPdfCreateByHtmlhTML == null ? null : WorkflowExpression.Compile(reqPdfCreateByHtmlhTML);
            WorkflowExpression.Validate(__workflow_reqPdfCreateByHtmlhTML, nameof(reqPdfCreateByHtmlhTML), required: true);
            var __workflow_reqPdfCreateByHtmloptionsmediaType = reqPdfCreateByHtmloptionsmediaType == null ? null : WorkflowExpression.Compile(reqPdfCreateByHtmloptionsmediaType);
            WorkflowExpression.Validate(__workflow_reqPdfCreateByHtmloptionsmediaType, nameof(reqPdfCreateByHtmloptionsmediaType), required: false);
            var __workflow_reqPdfCreateByHtmloptionspageFormat = reqPdfCreateByHtmloptionspageFormat == null ? null : WorkflowExpression.Compile(reqPdfCreateByHtmloptionspageFormat);
            WorkflowExpression.Validate(__workflow_reqPdfCreateByHtmloptionspageFormat, nameof(reqPdfCreateByHtmloptionspageFormat), required: false);
            var __workflow_reqPdfCreateByHtmloptionslandscape = reqPdfCreateByHtmloptionslandscape == null ? null : WorkflowExpression.Compile(reqPdfCreateByHtmloptionslandscape);
            WorkflowExpression.Validate(__workflow_reqPdfCreateByHtmloptionslandscape, nameof(reqPdfCreateByHtmloptionslandscape), required: false);
            var __workflow_reqPdfCreateByHtmloptionsmarginmarginLeft = reqPdfCreateByHtmloptionsmarginmarginLeft == null ? null : WorkflowExpression.Compile(reqPdfCreateByHtmloptionsmarginmarginLeft);
            WorkflowExpression.Validate(__workflow_reqPdfCreateByHtmloptionsmarginmarginLeft, nameof(reqPdfCreateByHtmloptionsmarginmarginLeft), required: false);
            var __workflow_reqPdfCreateByHtmloptionsmarginmarginRight = reqPdfCreateByHtmloptionsmarginmarginRight == null ? null : WorkflowExpression.Compile(reqPdfCreateByHtmloptionsmarginmarginRight);
            WorkflowExpression.Validate(__workflow_reqPdfCreateByHtmloptionsmarginmarginRight, nameof(reqPdfCreateByHtmloptionsmarginmarginRight), required: false);
            var __workflow_reqPdfCreateByHtmloptionsmarginmarginTop = reqPdfCreateByHtmloptionsmarginmarginTop == null ? null : WorkflowExpression.Compile(reqPdfCreateByHtmloptionsmarginmarginTop);
            WorkflowExpression.Validate(__workflow_reqPdfCreateByHtmloptionsmarginmarginTop, nameof(reqPdfCreateByHtmloptionsmarginmarginTop), required: false);
            var __workflow_reqPdfCreateByHtmloptionsmarginmarginBottom = reqPdfCreateByHtmloptionsmarginmarginBottom == null ? null : WorkflowExpression.Compile(reqPdfCreateByHtmloptionsmarginmarginBottom);
            WorkflowExpression.Validate(__workflow_reqPdfCreateByHtmloptionsmarginmarginBottom, nameof(reqPdfCreateByHtmloptionsmarginmarginBottom), required: false);
            return new DeferredBodyAction<Resp200PdfCreateByHtml>(() =>
            {
                var apiCallPath = "/pdf/create/by-html";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqPdfCreateByHtml = new JObject();
                var reqPdfCreateByHtmlpropCount = 0;
                reqPdfCreateByHtmlpropCount++;
                reqPdfCreateByHtml["content"] = ExpressionConverter.ConvertO(__workflow_reqPdfCreateByHtmlhTML);
                var dataObject = new JObject();
                var dataObjectpropCount = 0;
                if (dataObjectpropCount > 0)
                {
                    reqPdfCreateByHtml["data"] = dataObject;
                    reqPdfCreateByHtmlpropCount++;
                }

                var optionsObject = new JObject();
                var optionsObjectpropCount = 0;
                if (__workflow_reqPdfCreateByHtmloptionsmediaType != null)
                {
                    if (__workflow_reqPdfCreateByHtmloptionsmediaType != null)
                    {
                        optionsObject["mediaType"] = ExpressionConverter.ConvertO(__workflow_reqPdfCreateByHtmloptionsmediaType);
                        optionsObjectpropCount++;
                    }

                    optionsObjectpropCount++;
                }
                else
                {
                    optionsObject["mediaType"] = "print";
                    optionsObjectpropCount++;
                }

                if (__workflow_reqPdfCreateByHtmloptionspageFormat != null)
                {
                    if (__workflow_reqPdfCreateByHtmloptionspageFormat != null)
                    {
                        optionsObject["format"] = ExpressionConverter.ConvertO(__workflow_reqPdfCreateByHtmloptionspageFormat);
                        optionsObjectpropCount++;
                    }

                    optionsObjectpropCount++;
                }
                else
                {
                    optionsObject["format"] = "A4";
                    optionsObjectpropCount++;
                }

                if (__workflow_reqPdfCreateByHtmloptionslandscape != null)
                {
                    if (__workflow_reqPdfCreateByHtmloptionslandscape != null)
                    {
                        optionsObject["landscape"] = ExpressionConverter.ConvertO(__workflow_reqPdfCreateByHtmloptionslandscape);
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
                if (__workflow_reqPdfCreateByHtmloptionsmarginmarginLeft != null)
                {
                    if (__workflow_reqPdfCreateByHtmloptionsmarginmarginLeft != null)
                    {
                        marginObject["left"] = ExpressionConverter.ConvertO(__workflow_reqPdfCreateByHtmloptionsmarginmarginLeft);
                        marginObjectpropCount++;
                    }

                    marginObjectpropCount++;
                }
                else
                {
                    marginObject["left"] = "0px";
                    marginObjectpropCount++;
                }

                if (__workflow_reqPdfCreateByHtmloptionsmarginmarginRight != null)
                {
                    if (__workflow_reqPdfCreateByHtmloptionsmarginmarginRight != null)
                    {
                        marginObject["right"] = ExpressionConverter.ConvertO(__workflow_reqPdfCreateByHtmloptionsmarginmarginRight);
                        marginObjectpropCount++;
                    }

                    marginObjectpropCount++;
                }
                else
                {
                    marginObject["right"] = "0px";
                    marginObjectpropCount++;
                }

                if (__workflow_reqPdfCreateByHtmloptionsmarginmarginTop != null)
                {
                    if (__workflow_reqPdfCreateByHtmloptionsmarginmarginTop != null)
                    {
                        marginObject["top"] = ExpressionConverter.ConvertO(__workflow_reqPdfCreateByHtmloptionsmarginmarginTop);
                        marginObjectpropCount++;
                    }

                    marginObjectpropCount++;
                }
                else
                {
                    marginObject["top"] = "0px";
                    marginObjectpropCount++;
                }

                if (__workflow_reqPdfCreateByHtmloptionsmarginmarginBottom != null)
                {
                    if (__workflow_reqPdfCreateByHtmloptionsmarginmarginBottom != null)
                    {
                        marginObject["bottom"] = ExpressionConverter.ConvertO(__workflow_reqPdfCreateByHtmloptionsmarginmarginBottom);
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
        public IBodyWorkflowAction<Resp200ImageMergeDrawing> ImageMergeDrawing(Expression<Func<string>> reqImageMergeDrawingbackground, Expression<Func<string>> reqImageMergeDrawingdrawing)
        {
            var __workflow_reqImageMergeDrawingbackground = reqImageMergeDrawingbackground == null ? null : WorkflowExpression.Compile(reqImageMergeDrawingbackground);
            WorkflowExpression.Validate(__workflow_reqImageMergeDrawingbackground, nameof(reqImageMergeDrawingbackground), required: true);
            var __workflow_reqImageMergeDrawingdrawing = reqImageMergeDrawingdrawing == null ? null : WorkflowExpression.Compile(reqImageMergeDrawingdrawing);
            WorkflowExpression.Validate(__workflow_reqImageMergeDrawingdrawing, nameof(reqImageMergeDrawingdrawing), required: true);
            return new DeferredBodyAction<Resp200ImageMergeDrawing>(() =>
            {
                var apiCallPath = "/image/merge/drawing";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqImageMergeDrawing = new JObject();
                var reqImageMergeDrawingpropCount = 0;
                reqImageMergeDrawingpropCount++;
                reqImageMergeDrawing["background"] = ExpressionConverter.ConvertO(__workflow_reqImageMergeDrawingbackground);
                reqImageMergeDrawingpropCount++;
                reqImageMergeDrawing["drawing"] = ExpressionConverter.ConvertO(__workflow_reqImageMergeDrawingdrawing);
                if (reqImageMergeDrawingpropCount > 0)
                {
                    callPayload.Body = reqImageMergeDrawing;
                }

                return new ApiConnectionAction<Resp200ImageMergeDrawing>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sparsepowerboxtools")]
        public IBodyWorkflowAction<Resp200PdfStampText> PdfStampText(Expression<Func<string>> reqPdfStampTextpDF, Expression<Func<string>> reqPdfStampTexttext, Expression<Func<string>> reqPdfStampTextoptionsfontColor = null, Expression<Func<int>> reqPdfStampTextoptionsfontSize = null, Expression<Func<int>> reqPdfStampTextoptionsrotate = null, Expression<Func<int>> reqPdfStampTextoptionspositionyOffset = null, Expression<Func<string>> reqPdfStampTextoptionspositionstartOfYOffset = null, Expression<Func<int>> reqPdfStampTextoptionspositionxOffset = null)
        {
            var __workflow_reqPdfStampTextpDF = reqPdfStampTextpDF == null ? null : WorkflowExpression.Compile(reqPdfStampTextpDF);
            WorkflowExpression.Validate(__workflow_reqPdfStampTextpDF, nameof(reqPdfStampTextpDF), required: true);
            var __workflow_reqPdfStampTexttext = reqPdfStampTexttext == null ? null : WorkflowExpression.Compile(reqPdfStampTexttext);
            WorkflowExpression.Validate(__workflow_reqPdfStampTexttext, nameof(reqPdfStampTexttext), required: true);
            var __workflow_reqPdfStampTextoptionsfontColor = reqPdfStampTextoptionsfontColor == null ? null : WorkflowExpression.Compile(reqPdfStampTextoptionsfontColor);
            WorkflowExpression.Validate(__workflow_reqPdfStampTextoptionsfontColor, nameof(reqPdfStampTextoptionsfontColor), required: false);
            var __workflow_reqPdfStampTextoptionsfontSize = reqPdfStampTextoptionsfontSize == null ? null : WorkflowExpression.Compile(reqPdfStampTextoptionsfontSize);
            WorkflowExpression.Validate(__workflow_reqPdfStampTextoptionsfontSize, nameof(reqPdfStampTextoptionsfontSize), required: false);
            var __workflow_reqPdfStampTextoptionsrotate = reqPdfStampTextoptionsrotate == null ? null : WorkflowExpression.Compile(reqPdfStampTextoptionsrotate);
            WorkflowExpression.Validate(__workflow_reqPdfStampTextoptionsrotate, nameof(reqPdfStampTextoptionsrotate), required: false);
            var __workflow_reqPdfStampTextoptionspositionyOffset = reqPdfStampTextoptionspositionyOffset == null ? null : WorkflowExpression.Compile(reqPdfStampTextoptionspositionyOffset);
            WorkflowExpression.Validate(__workflow_reqPdfStampTextoptionspositionyOffset, nameof(reqPdfStampTextoptionspositionyOffset), required: false);
            var __workflow_reqPdfStampTextoptionspositionstartOfYOffset = reqPdfStampTextoptionspositionstartOfYOffset == null ? null : WorkflowExpression.Compile(reqPdfStampTextoptionspositionstartOfYOffset);
            WorkflowExpression.Validate(__workflow_reqPdfStampTextoptionspositionstartOfYOffset, nameof(reqPdfStampTextoptionspositionstartOfYOffset), required: false);
            var __workflow_reqPdfStampTextoptionspositionxOffset = reqPdfStampTextoptionspositionxOffset == null ? null : WorkflowExpression.Compile(reqPdfStampTextoptionspositionxOffset);
            WorkflowExpression.Validate(__workflow_reqPdfStampTextoptionspositionxOffset, nameof(reqPdfStampTextoptionspositionxOffset), required: false);
            return new DeferredBodyAction<Resp200PdfStampText>(() =>
            {
                var apiCallPath = "/pdf/stamp/text";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqPdfStampText = new JObject();
                var reqPdfStampTextpropCount = 0;
                reqPdfStampTextpropCount++;
                reqPdfStampText["pdf"] = ExpressionConverter.ConvertO(__workflow_reqPdfStampTextpDF);
                reqPdfStampTextpropCount++;
                reqPdfStampText["text"] = ExpressionConverter.ConvertO(__workflow_reqPdfStampTexttext);
                var optionsObject = new JObject();
                var optionsObjectpropCount = 0;
                if (__workflow_reqPdfStampTextoptionsfontColor != null)
                {
                    if (__workflow_reqPdfStampTextoptionsfontColor != null)
                    {
                        optionsObject["color"] = ExpressionConverter.ConvertO(__workflow_reqPdfStampTextoptionsfontColor);
                        optionsObjectpropCount++;
                    }

                    optionsObjectpropCount++;
                }
                else
                {
                    optionsObject["color"] = "#000000";
                    optionsObjectpropCount++;
                }

                if (__workflow_reqPdfStampTextoptionsfontSize != null)
                {
                    if (__workflow_reqPdfStampTextoptionsfontSize != null)
                    {
                        optionsObject["size"] = ExpressionConverter.ConvertO(__workflow_reqPdfStampTextoptionsfontSize);
                        optionsObjectpropCount++;
                    }

                    optionsObjectpropCount++;
                }
                else
                {
                    optionsObject["size"] = 50;
                    optionsObjectpropCount++;
                }

                if (__workflow_reqPdfStampTextoptionsrotate != null)
                {
                    if (__workflow_reqPdfStampTextoptionsrotate != null)
                    {
                        optionsObject["rotate"] = ExpressionConverter.ConvertO(__workflow_reqPdfStampTextoptionsrotate);
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
                if (__workflow_reqPdfStampTextoptionspositionyOffset != null)
                {
                    if (__workflow_reqPdfStampTextoptionspositionyOffset != null)
                    {
                        positionObject["yOffset"] = ExpressionConverter.ConvertO(__workflow_reqPdfStampTextoptionspositionyOffset);
                        positionObjectpropCount++;
                    }

                    positionObjectpropCount++;
                }
                else
                {
                    positionObject["yOffset"] = 25;
                    positionObjectpropCount++;
                }

                if (__workflow_reqPdfStampTextoptionspositionstartOfYOffset != null)
                {
                    if (__workflow_reqPdfStampTextoptionspositionstartOfYOffset != null)
                    {
                        positionObject["yOffsetStart"] = ExpressionConverter.ConvertO(__workflow_reqPdfStampTextoptionspositionstartOfYOffset);
                        positionObjectpropCount++;
                    }

                    positionObjectpropCount++;
                }
                else
                {
                    positionObject["yOffsetStart"] = "bottom";
                    positionObjectpropCount++;
                }

                if (__workflow_reqPdfStampTextoptionspositionxOffset != null)
                {
                    if (__workflow_reqPdfStampTextoptionspositionxOffset != null)
                    {
                        positionObject["xOffset"] = ExpressionConverter.ConvertO(__workflow_reqPdfStampTextoptionspositionxOffset);
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
        public IBodyWorkflowAction<Resp200CsvToJson> CsvToJson(Expression<Func<string>> reqCsvToJsoncSV, Expression<Func<bool>> reqCsvToJsonoptionshasHeaders = null, Expression<Func<string>> reqCsvToJsonoptionsdelimiter = null)
        {
            var __workflow_reqCsvToJsoncSV = reqCsvToJsoncSV == null ? null : WorkflowExpression.Compile(reqCsvToJsoncSV);
            WorkflowExpression.Validate(__workflow_reqCsvToJsoncSV, nameof(reqCsvToJsoncSV), required: true);
            var __workflow_reqCsvToJsonoptionshasHeaders = reqCsvToJsonoptionshasHeaders == null ? null : WorkflowExpression.Compile(reqCsvToJsonoptionshasHeaders);
            WorkflowExpression.Validate(__workflow_reqCsvToJsonoptionshasHeaders, nameof(reqCsvToJsonoptionshasHeaders), required: false);
            var __workflow_reqCsvToJsonoptionsdelimiter = reqCsvToJsonoptionsdelimiter == null ? null : WorkflowExpression.Compile(reqCsvToJsonoptionsdelimiter);
            WorkflowExpression.Validate(__workflow_reqCsvToJsonoptionsdelimiter, nameof(reqCsvToJsonoptionsdelimiter), required: false);
            return new DeferredBodyAction<Resp200CsvToJson>(() =>
            {
                var apiCallPath = "/csv/to-json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqCsvToJson = new JObject();
                var reqCsvToJsonpropCount = 0;
                reqCsvToJsonpropCount++;
                reqCsvToJson["csv"] = ExpressionConverter.ConvertO(__workflow_reqCsvToJsoncSV);
                var optionsObject = new JObject();
                var optionsObjectpropCount = 0;
                if (__workflow_reqCsvToJsonoptionshasHeaders != null)
                {
                    if (__workflow_reqCsvToJsonoptionshasHeaders != null)
                    {
                        optionsObject["hasHeaders"] = ExpressionConverter.ConvertO(__workflow_reqCsvToJsonoptionshasHeaders);
                        optionsObjectpropCount++;
                    }

                    optionsObjectpropCount++;
                }
                else
                {
                    optionsObject["hasHeaders"] = true;
                    optionsObjectpropCount++;
                }

                if (__workflow_reqCsvToJsonoptionsdelimiter != null)
                {
                    if (__workflow_reqCsvToJsonoptionsdelimiter != null)
                    {
                        optionsObject["delimiter"] = ExpressionConverter.ConvertO(__workflow_reqCsvToJsonoptionsdelimiter);
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
        public IBodyWorkflowAction<Resp200PdfCreateByUrl> PdfCreateByUrl(Expression<Func<string>> reqPdfCreateByUrlhTML, Expression<Func<string>> reqPdfCreateByUrloptionsmediaType = null, Expression<Func<string>> reqPdfCreateByUrloptionspageFormat = null, Expression<Func<bool>> reqPdfCreateByUrloptionslandscape = null, Expression<Func<string>> reqPdfCreateByUrloptionsmarginmarginLeft = null, Expression<Func<string>> reqPdfCreateByUrloptionsmarginmarginRight = null, Expression<Func<string>> reqPdfCreateByUrloptionsmarginmarginTop = null, Expression<Func<string>> reqPdfCreateByUrloptionsmarginmarginBottom = null)
        {
            var __workflow_reqPdfCreateByUrlhTML = reqPdfCreateByUrlhTML == null ? null : WorkflowExpression.Compile(reqPdfCreateByUrlhTML);
            WorkflowExpression.Validate(__workflow_reqPdfCreateByUrlhTML, nameof(reqPdfCreateByUrlhTML), required: true);
            var __workflow_reqPdfCreateByUrloptionsmediaType = reqPdfCreateByUrloptionsmediaType == null ? null : WorkflowExpression.Compile(reqPdfCreateByUrloptionsmediaType);
            WorkflowExpression.Validate(__workflow_reqPdfCreateByUrloptionsmediaType, nameof(reqPdfCreateByUrloptionsmediaType), required: false);
            var __workflow_reqPdfCreateByUrloptionspageFormat = reqPdfCreateByUrloptionspageFormat == null ? null : WorkflowExpression.Compile(reqPdfCreateByUrloptionspageFormat);
            WorkflowExpression.Validate(__workflow_reqPdfCreateByUrloptionspageFormat, nameof(reqPdfCreateByUrloptionspageFormat), required: false);
            var __workflow_reqPdfCreateByUrloptionslandscape = reqPdfCreateByUrloptionslandscape == null ? null : WorkflowExpression.Compile(reqPdfCreateByUrloptionslandscape);
            WorkflowExpression.Validate(__workflow_reqPdfCreateByUrloptionslandscape, nameof(reqPdfCreateByUrloptionslandscape), required: false);
            var __workflow_reqPdfCreateByUrloptionsmarginmarginLeft = reqPdfCreateByUrloptionsmarginmarginLeft == null ? null : WorkflowExpression.Compile(reqPdfCreateByUrloptionsmarginmarginLeft);
            WorkflowExpression.Validate(__workflow_reqPdfCreateByUrloptionsmarginmarginLeft, nameof(reqPdfCreateByUrloptionsmarginmarginLeft), required: false);
            var __workflow_reqPdfCreateByUrloptionsmarginmarginRight = reqPdfCreateByUrloptionsmarginmarginRight == null ? null : WorkflowExpression.Compile(reqPdfCreateByUrloptionsmarginmarginRight);
            WorkflowExpression.Validate(__workflow_reqPdfCreateByUrloptionsmarginmarginRight, nameof(reqPdfCreateByUrloptionsmarginmarginRight), required: false);
            var __workflow_reqPdfCreateByUrloptionsmarginmarginTop = reqPdfCreateByUrloptionsmarginmarginTop == null ? null : WorkflowExpression.Compile(reqPdfCreateByUrloptionsmarginmarginTop);
            WorkflowExpression.Validate(__workflow_reqPdfCreateByUrloptionsmarginmarginTop, nameof(reqPdfCreateByUrloptionsmarginmarginTop), required: false);
            var __workflow_reqPdfCreateByUrloptionsmarginmarginBottom = reqPdfCreateByUrloptionsmarginmarginBottom == null ? null : WorkflowExpression.Compile(reqPdfCreateByUrloptionsmarginmarginBottom);
            WorkflowExpression.Validate(__workflow_reqPdfCreateByUrloptionsmarginmarginBottom, nameof(reqPdfCreateByUrloptionsmarginmarginBottom), required: false);
            return new DeferredBodyAction<Resp200PdfCreateByUrl>(() =>
            {
                var apiCallPath = "/pdf/create/by-url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqPdfCreateByUrl = new JObject();
                var reqPdfCreateByUrlpropCount = 0;
                reqPdfCreateByUrlpropCount++;
                reqPdfCreateByUrl["url"] = ExpressionConverter.ConvertO(__workflow_reqPdfCreateByUrlhTML);
                var optionsObject = new JObject();
                var optionsObjectpropCount = 0;
                if (__workflow_reqPdfCreateByUrloptionsmediaType != null)
                {
                    if (__workflow_reqPdfCreateByUrloptionsmediaType != null)
                    {
                        optionsObject["mediaType"] = ExpressionConverter.ConvertO(__workflow_reqPdfCreateByUrloptionsmediaType);
                        optionsObjectpropCount++;
                    }

                    optionsObjectpropCount++;
                }
                else
                {
                    optionsObject["mediaType"] = "print";
                    optionsObjectpropCount++;
                }

                if (__workflow_reqPdfCreateByUrloptionspageFormat != null)
                {
                    if (__workflow_reqPdfCreateByUrloptionspageFormat != null)
                    {
                        optionsObject["format"] = ExpressionConverter.ConvertO(__workflow_reqPdfCreateByUrloptionspageFormat);
                        optionsObjectpropCount++;
                    }

                    optionsObjectpropCount++;
                }
                else
                {
                    optionsObject["format"] = "A4";
                    optionsObjectpropCount++;
                }

                if (__workflow_reqPdfCreateByUrloptionslandscape != null)
                {
                    if (__workflow_reqPdfCreateByUrloptionslandscape != null)
                    {
                        optionsObject["landscape"] = ExpressionConverter.ConvertO(__workflow_reqPdfCreateByUrloptionslandscape);
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
                if (__workflow_reqPdfCreateByUrloptionsmarginmarginLeft != null)
                {
                    if (__workflow_reqPdfCreateByUrloptionsmarginmarginLeft != null)
                    {
                        marginObject["left"] = ExpressionConverter.ConvertO(__workflow_reqPdfCreateByUrloptionsmarginmarginLeft);
                        marginObjectpropCount++;
                    }

                    marginObjectpropCount++;
                }
                else
                {
                    marginObject["left"] = "0px";
                    marginObjectpropCount++;
                }

                if (__workflow_reqPdfCreateByUrloptionsmarginmarginRight != null)
                {
                    if (__workflow_reqPdfCreateByUrloptionsmarginmarginRight != null)
                    {
                        marginObject["right"] = ExpressionConverter.ConvertO(__workflow_reqPdfCreateByUrloptionsmarginmarginRight);
                        marginObjectpropCount++;
                    }

                    marginObjectpropCount++;
                }
                else
                {
                    marginObject["right"] = "0px";
                    marginObjectpropCount++;
                }

                if (__workflow_reqPdfCreateByUrloptionsmarginmarginTop != null)
                {
                    if (__workflow_reqPdfCreateByUrloptionsmarginmarginTop != null)
                    {
                        marginObject["top"] = ExpressionConverter.ConvertO(__workflow_reqPdfCreateByUrloptionsmarginmarginTop);
                        marginObjectpropCount++;
                    }

                    marginObjectpropCount++;
                }
                else
                {
                    marginObject["top"] = "0px";
                    marginObjectpropCount++;
                }

                if (__workflow_reqPdfCreateByUrloptionsmarginmarginBottom != null)
                {
                    if (__workflow_reqPdfCreateByUrloptionsmarginmarginBottom != null)
                    {
                        marginObject["bottom"] = ExpressionConverter.ConvertO(__workflow_reqPdfCreateByUrloptionsmarginmarginBottom);
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
        public IBodyWorkflowAction<Resp200ImageStampText> ImageStampText(Expression<Func<string>> reqImageStampTextimage = null, Expression<Func<string>> reqImageStampTexttextToStamp = null, Expression<Func<string>> reqImageStampTextoptionslocationOfTheStamp = null, Expression<Func<string>> reqImageStampTextoptionsfontcolor = null, Expression<Func<int>> reqImageStampTextoptionsfontsize = null)
        {
            var __workflow_reqImageStampTextimage = reqImageStampTextimage == null ? null : WorkflowExpression.Compile(reqImageStampTextimage);
            WorkflowExpression.Validate(__workflow_reqImageStampTextimage, nameof(reqImageStampTextimage), required: false);
            var __workflow_reqImageStampTexttextToStamp = reqImageStampTexttextToStamp == null ? null : WorkflowExpression.Compile(reqImageStampTexttextToStamp);
            WorkflowExpression.Validate(__workflow_reqImageStampTexttextToStamp, nameof(reqImageStampTexttextToStamp), required: false);
            var __workflow_reqImageStampTextoptionslocationOfTheStamp = reqImageStampTextoptionslocationOfTheStamp == null ? null : WorkflowExpression.Compile(reqImageStampTextoptionslocationOfTheStamp);
            WorkflowExpression.Validate(__workflow_reqImageStampTextoptionslocationOfTheStamp, nameof(reqImageStampTextoptionslocationOfTheStamp), required: false);
            var __workflow_reqImageStampTextoptionsfontcolor = reqImageStampTextoptionsfontcolor == null ? null : WorkflowExpression.Compile(reqImageStampTextoptionsfontcolor);
            WorkflowExpression.Validate(__workflow_reqImageStampTextoptionsfontcolor, nameof(reqImageStampTextoptionsfontcolor), required: false);
            var __workflow_reqImageStampTextoptionsfontsize = reqImageStampTextoptionsfontsize == null ? null : WorkflowExpression.Compile(reqImageStampTextoptionsfontsize);
            WorkflowExpression.Validate(__workflow_reqImageStampTextoptionsfontsize, nameof(reqImageStampTextoptionsfontsize), required: false);
            return new DeferredBodyAction<Resp200ImageStampText>(() =>
            {
                var apiCallPath = "/image/stamp/text";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqImageStampText = new JObject();
                var reqImageStampTextpropCount = 0;
                if (__workflow_reqImageStampTextimage != null)
                {
                    reqImageStampText["image"] = ExpressionConverter.ConvertO(__workflow_reqImageStampTextimage);
                    reqImageStampTextpropCount++;
                }

                if (__workflow_reqImageStampTexttextToStamp != null)
                {
                    reqImageStampText["text"] = ExpressionConverter.ConvertO(__workflow_reqImageStampTexttextToStamp);
                    reqImageStampTextpropCount++;
                }

                var optionsObject = new JObject();
                var optionsObjectpropCount = 0;
                if (__workflow_reqImageStampTextoptionslocationOfTheStamp != null)
                {
                    if (__workflow_reqImageStampTextoptionslocationOfTheStamp != null)
                    {
                        optionsObject["location"] = ExpressionConverter.ConvertO(__workflow_reqImageStampTextoptionslocationOfTheStamp);
                        optionsObjectpropCount++;
                    }

                    optionsObjectpropCount++;
                }
                else
                {
                    optionsObject["location"] = "Center";
                    optionsObjectpropCount++;
                }

                if (__workflow_reqImageStampTextoptionsfontcolor != null)
                {
                    if (__workflow_reqImageStampTextoptionsfontcolor != null)
                    {
                        optionsObject["fontColor"] = ExpressionConverter.ConvertO(__workflow_reqImageStampTextoptionsfontcolor);
                        optionsObjectpropCount++;
                    }

                    optionsObjectpropCount++;
                }
                else
                {
                    optionsObject["fontColor"] = "#ffffff";
                    optionsObjectpropCount++;
                }

                if (__workflow_reqImageStampTextoptionsfontsize != null)
                {
                    if (__workflow_reqImageStampTextoptionsfontsize != null)
                    {
                        optionsObject["fontSize"] = ExpressionConverter.ConvertO(__workflow_reqImageStampTextoptionsfontsize);
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
        public IBodyWorkflowAction<Resp200ImageResize> ImageResize(Expression<Func<string>> reqImageResizeimage = null, Expression<Func<int>> reqImageResizewidth = null, Expression<Func<int>> reqImageResizeheight = null, Expression<Func<bool>> reqImageResizeoptionsignoreTheAspectRation = null)
        {
            var __workflow_reqImageResizeimage = reqImageResizeimage == null ? null : WorkflowExpression.Compile(reqImageResizeimage);
            WorkflowExpression.Validate(__workflow_reqImageResizeimage, nameof(reqImageResizeimage), required: false);
            var __workflow_reqImageResizewidth = reqImageResizewidth == null ? null : WorkflowExpression.Compile(reqImageResizewidth);
            WorkflowExpression.Validate(__workflow_reqImageResizewidth, nameof(reqImageResizewidth), required: false);
            var __workflow_reqImageResizeheight = reqImageResizeheight == null ? null : WorkflowExpression.Compile(reqImageResizeheight);
            WorkflowExpression.Validate(__workflow_reqImageResizeheight, nameof(reqImageResizeheight), required: false);
            var __workflow_reqImageResizeoptionsignoreTheAspectRation = reqImageResizeoptionsignoreTheAspectRation == null ? null : WorkflowExpression.Compile(reqImageResizeoptionsignoreTheAspectRation);
            WorkflowExpression.Validate(__workflow_reqImageResizeoptionsignoreTheAspectRation, nameof(reqImageResizeoptionsignoreTheAspectRation), required: false);
            return new DeferredBodyAction<Resp200ImageResize>(() =>
            {
                var apiCallPath = "/image/resize";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqImageResize = new JObject();
                var reqImageResizepropCount = 0;
                if (__workflow_reqImageResizeimage != null)
                {
                    reqImageResize["image"] = ExpressionConverter.ConvertO(__workflow_reqImageResizeimage);
                    reqImageResizepropCount++;
                }

                if (__workflow_reqImageResizewidth != null)
                {
                    reqImageResize["width"] = ExpressionConverter.ConvertO(__workflow_reqImageResizewidth);
                    reqImageResizepropCount++;
                }

                if (__workflow_reqImageResizeheight != null)
                {
                    reqImageResize["height"] = ExpressionConverter.ConvertO(__workflow_reqImageResizeheight);
                    reqImageResizepropCount++;
                }

                var optionsObject = new JObject();
                var optionsObjectpropCount = 0;
                if (__workflow_reqImageResizeoptionsignoreTheAspectRation != null)
                {
                    if (__workflow_reqImageResizeoptionsignoreTheAspectRation != null)
                    {
                        optionsObject["ignoreAspectRation"] = ExpressionConverter.ConvertO(__workflow_reqImageResizeoptionsignoreTheAspectRation);
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
        public IBodyWorkflowAction<Resp200PdfSplitByPage> PdfSplitByPage(Expression<Func<string>> reqPdfSplitByPagepDFFile = null, Expression<Func<double>> reqPdfSplitByPageoptionsnumberOfPages = null)
        {
            var __workflow_reqPdfSplitByPagepDFFile = reqPdfSplitByPagepDFFile == null ? null : WorkflowExpression.Compile(reqPdfSplitByPagepDFFile);
            WorkflowExpression.Validate(__workflow_reqPdfSplitByPagepDFFile, nameof(reqPdfSplitByPagepDFFile), required: false);
            var __workflow_reqPdfSplitByPageoptionsnumberOfPages = reqPdfSplitByPageoptionsnumberOfPages == null ? null : WorkflowExpression.Compile(reqPdfSplitByPageoptionsnumberOfPages);
            WorkflowExpression.Validate(__workflow_reqPdfSplitByPageoptionsnumberOfPages, nameof(reqPdfSplitByPageoptionsnumberOfPages), required: false);
            return new DeferredBodyAction<Resp200PdfSplitByPage>(() =>
            {
                var apiCallPath = "/pdf/split/by-page";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqPdfSplitByPage = new JObject();
                var reqPdfSplitByPagepropCount = 0;
                if (__workflow_reqPdfSplitByPagepDFFile != null)
                {
                    reqPdfSplitByPage["pdf"] = ExpressionConverter.ConvertO(__workflow_reqPdfSplitByPagepDFFile);
                    reqPdfSplitByPagepropCount++;
                }

                var optionsObject = new JObject();
                var optionsObjectpropCount = 0;
                if (__workflow_reqPdfSplitByPageoptionsnumberOfPages != null)
                {
                    if (__workflow_reqPdfSplitByPageoptionsnumberOfPages != null)
                    {
                        optionsObject["numberOfPages"] = ExpressionConverter.ConvertO(__workflow_reqPdfSplitByPageoptionsnumberOfPages);
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
        public IBodyWorkflowAction<Resp200ImageStampExif> ImageStampExif(Expression<Func<string>> reqImageStampExifimage = null, Expression<Func<string[]>> reqImageStampExifoptionstags = null, Expression<Func<string>> reqImageStampExifoptionslocationOfTheStamp = null, Expression<Func<string>> reqImageStampExifoptionsfontcolor = null, Expression<Func<int>> reqImageStampExifoptionsfontsize = null, Expression<Func<bool>> reqImageStampExifoptionsprintTagName = null)
        {
            var __workflow_reqImageStampExifimage = reqImageStampExifimage == null ? null : WorkflowExpression.Compile(reqImageStampExifimage);
            WorkflowExpression.Validate(__workflow_reqImageStampExifimage, nameof(reqImageStampExifimage), required: false);
            var __workflow_reqImageStampExifoptionstags = reqImageStampExifoptionstags == null ? null : WorkflowExpression.Compile(reqImageStampExifoptionstags);
            WorkflowExpression.Validate(__workflow_reqImageStampExifoptionstags, nameof(reqImageStampExifoptionstags), required: false);
            var __workflow_reqImageStampExifoptionslocationOfTheStamp = reqImageStampExifoptionslocationOfTheStamp == null ? null : WorkflowExpression.Compile(reqImageStampExifoptionslocationOfTheStamp);
            WorkflowExpression.Validate(__workflow_reqImageStampExifoptionslocationOfTheStamp, nameof(reqImageStampExifoptionslocationOfTheStamp), required: false);
            var __workflow_reqImageStampExifoptionsfontcolor = reqImageStampExifoptionsfontcolor == null ? null : WorkflowExpression.Compile(reqImageStampExifoptionsfontcolor);
            WorkflowExpression.Validate(__workflow_reqImageStampExifoptionsfontcolor, nameof(reqImageStampExifoptionsfontcolor), required: false);
            var __workflow_reqImageStampExifoptionsfontsize = reqImageStampExifoptionsfontsize == null ? null : WorkflowExpression.Compile(reqImageStampExifoptionsfontsize);
            WorkflowExpression.Validate(__workflow_reqImageStampExifoptionsfontsize, nameof(reqImageStampExifoptionsfontsize), required: false);
            var __workflow_reqImageStampExifoptionsprintTagName = reqImageStampExifoptionsprintTagName == null ? null : WorkflowExpression.Compile(reqImageStampExifoptionsprintTagName);
            WorkflowExpression.Validate(__workflow_reqImageStampExifoptionsprintTagName, nameof(reqImageStampExifoptionsprintTagName), required: false);
            return new DeferredBodyAction<Resp200ImageStampExif>(() =>
            {
                var apiCallPath = "/image/stamp/exif";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqImageStampExif = new JObject();
                var reqImageStampExifpropCount = 0;
                if (__workflow_reqImageStampExifimage != null)
                {
                    reqImageStampExif["image"] = ExpressionConverter.ConvertO(__workflow_reqImageStampExifimage);
                    reqImageStampExifpropCount++;
                }

                var optionsObject = new JObject();
                var optionsObjectpropCount = 0;
                if (__workflow_reqImageStampExifoptionstags != null)
                {
                    optionsObject["tags"] = ExpressionConverter.ConvertO(__workflow_reqImageStampExifoptionstags);
                    optionsObjectpropCount++;
                }

                if (__workflow_reqImageStampExifoptionslocationOfTheStamp != null)
                {
                    if (__workflow_reqImageStampExifoptionslocationOfTheStamp != null)
                    {
                        optionsObject["location"] = ExpressionConverter.ConvertO(__workflow_reqImageStampExifoptionslocationOfTheStamp);
                        optionsObjectpropCount++;
                    }

                    optionsObjectpropCount++;
                }
                else
                {
                    optionsObject["location"] = "Center";
                    optionsObjectpropCount++;
                }

                if (__workflow_reqImageStampExifoptionsfontcolor != null)
                {
                    if (__workflow_reqImageStampExifoptionsfontcolor != null)
                    {
                        optionsObject["fontColor"] = ExpressionConverter.ConvertO(__workflow_reqImageStampExifoptionsfontcolor);
                        optionsObjectpropCount++;
                    }

                    optionsObjectpropCount++;
                }
                else
                {
                    optionsObject["fontColor"] = "#ffffff";
                    optionsObjectpropCount++;
                }

                if (__workflow_reqImageStampExifoptionsfontsize != null)
                {
                    if (__workflow_reqImageStampExifoptionsfontsize != null)
                    {
                        optionsObject["fontSize"] = ExpressionConverter.ConvertO(__workflow_reqImageStampExifoptionsfontsize);
                        optionsObjectpropCount++;
                    }

                    optionsObjectpropCount++;
                }
                else
                {
                    optionsObject["fontSize"] = 25;
                    optionsObjectpropCount++;
                }

                if (__workflow_reqImageStampExifoptionsprintTagName != null)
                {
                    if (__workflow_reqImageStampExifoptionsprintTagName != null)
                    {
                        optionsObject["printTagName"] = ExpressionConverter.ConvertO(__workflow_reqImageStampExifoptionsprintTagName);
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
        public IBodyWorkflowAction<Resp200PdfFillForm> PdfFillForm(Expression<Func<string>> reqPdfFillFormpDFFile = null)
        {
            var __workflow_reqPdfFillFormpDFFile = reqPdfFillFormpDFFile == null ? null : WorkflowExpression.Compile(reqPdfFillFormpDFFile);
            WorkflowExpression.Validate(__workflow_reqPdfFillFormpDFFile, nameof(reqPdfFillFormpDFFile), required: false);
            return new DeferredBodyAction<Resp200PdfFillForm>(() =>
            {
                var apiCallPath = "/form/fill";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqPdfFillForm = new JObject();
                var reqPdfFillFormpropCount = 0;
                if (__workflow_reqPdfFillFormpDFFile != null)
                {
                    reqPdfFillForm["pdf"] = ExpressionConverter.ConvertO(__workflow_reqPdfFillFormpDFFile);
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
        public IBodyWorkflowAction<Resp200PdfGetFormData> PdfGetFormData(Expression<Func<string>> reqPdfGetFormDatapDFFile = null)
        {
            var __workflow_reqPdfGetFormDatapDFFile = reqPdfGetFormDatapDFFile == null ? null : WorkflowExpression.Compile(reqPdfGetFormDatapDFFile);
            WorkflowExpression.Validate(__workflow_reqPdfGetFormDatapDFFile, nameof(reqPdfGetFormDatapDFFile), required: false);
            return new DeferredBodyAction<Resp200PdfGetFormData>(() =>
            {
                var apiCallPath = "/form/getdata";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqPdfGetFormData = new JObject();
                var reqPdfGetFormDatapropCount = 0;
                if (__workflow_reqPdfGetFormDatapDFFile != null)
                {
                    reqPdfGetFormData["pdf"] = ExpressionConverter.ConvertO(__workflow_reqPdfGetFormDatapDFFile);
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
        public IBodyWorkflowAction<Resp200PdfMergeSimple> PdfMergeSimple(Expression<Func<string[]>> reqPdfMergeSimplepDFFile = null)
        {
            var __workflow_reqPdfMergeSimplepDFFile = reqPdfMergeSimplepDFFile == null ? null : WorkflowExpression.Compile(reqPdfMergeSimplepDFFile);
            WorkflowExpression.Validate(__workflow_reqPdfMergeSimplepDFFile, nameof(reqPdfMergeSimplepDFFile), required: false);
            return new DeferredBodyAction<Resp200PdfMergeSimple>(() =>
            {
                var apiCallPath = "/pdf/merge/simple";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqPdfMergeSimple = new JObject();
                var reqPdfMergeSimplepropCount = 0;
                if (__workflow_reqPdfMergeSimplepDFFile != null)
                {
                    reqPdfMergeSimple["pdfs"] = ExpressionConverter.ConvertO(__workflow_reqPdfMergeSimplepDFFile);
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
