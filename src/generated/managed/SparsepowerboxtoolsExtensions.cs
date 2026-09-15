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
        public IBodyWorkflowAction<Resp200PdfStampImage> PdfStampImage(Expression<Func<string>> reqPdfStampImagepDF, Expression<Func<string>> reqPdfStampImageimage, Expression<Func<double>> reqPdfStampImageoptionsopacity = null, Expression<Func<double>> reqPdfStampImageoptionsscale = null, Expression<Func<int>> reqPdfStampImageoptionsrotate = null, Expression<Func<int>> reqPdfStampImageoptionspositionyOffset = null, Expression<Func<string>> reqPdfStampImageoptionspositionstartOfYOffset = null, Expression<Func<int>> reqPdfStampImageoptionspositionxOffset = null)
        {
            var apiCallPath = "/pdf/stamp/image";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var reqPdfStampImage = new JObject();
            var reqPdfStampImagepropCount = 0;
            reqPdfStampImagepropCount++;
            reqPdfStampImage["pdf"] = CSharpExpressionConverter.ConvertToken(reqPdfStampImagepDF);
            reqPdfStampImagepropCount++;
            reqPdfStampImage["image"] = CSharpExpressionConverter.ConvertToken(reqPdfStampImageimage);
            var optionsObject = new JObject();
            var optionsObjectpropCount = 0;
            if (reqPdfStampImageoptionsopacity != null)
            {
                if (reqPdfStampImageoptionsopacity != null)
                {
                    optionsObject["opacity"] = CSharpExpressionConverter.ConvertToken(reqPdfStampImageoptionsopacity);
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
                    optionsObject["scale"] = CSharpExpressionConverter.ConvertToken(reqPdfStampImageoptionsscale);
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
                    optionsObject["rotate"] = CSharpExpressionConverter.ConvertToken(reqPdfStampImageoptionsrotate);
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
                    positionObject["yOffset"] = CSharpExpressionConverter.ConvertToken(reqPdfStampImageoptionspositionyOffset);
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
                    positionObject["yOffsetStart"] = CSharpExpressionConverter.ConvertToken(reqPdfStampImageoptionspositionstartOfYOffset);
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
                    positionObject["xOffset"] = CSharpExpressionConverter.ConvertToken(reqPdfStampImageoptionspositionxOffset);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sparsepowerboxtools")]
        public IBodyWorkflowAction<Resp200ExcelSheetAddRows> ExcelSheetAddRows(Expression<Func<string>> reqExcelSheetAddrowssheetname, Expression<Func<string>> reqExcelSheetAddrowsexcel, Expression<Func<JToken[]>> reqExcelSheetAddrowsdata = null)
        {
            var apiCallPath = "/excel/sheet/add-rows";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var reqExcelSheetAddrows = new JObject();
            var reqExcelSheetAddrowspropCount = 0;
            reqExcelSheetAddrowspropCount++;
            reqExcelSheetAddrows["sheet"] = CSharpExpressionConverter.ConvertToken(reqExcelSheetAddrowssheetname);
            if (reqExcelSheetAddrowsdata != null)
            {
                reqExcelSheetAddrows["data"] = CSharpExpressionConverter.ConvertToken(reqExcelSheetAddrowsdata);
                reqExcelSheetAddrowspropCount++;
            }

            reqExcelSheetAddrowspropCount++;
            reqExcelSheetAddrows["excelFile"] = CSharpExpressionConverter.ConvertToken(reqExcelSheetAddrowsexcel);
            if (reqExcelSheetAddrowspropCount > 0)
            {
                callPayload.Body = reqExcelSheetAddrows;
            }

            return new ApiConnectionAction<Resp200ExcelSheetAddRows>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sparsepowerboxtools")]
        public IBodyWorkflowAction<Resp200PdfCreateByHtml> PdfCreateByHtml(Expression<Func<string>> reqPdfCreateByHtmlhTML, Expression<Func<string>> reqPdfCreateByHtmloptionsmediaType = null, Expression<Func<string>> reqPdfCreateByHtmloptionspageFormat = null, Expression<Func<bool>> reqPdfCreateByHtmloptionslandscape = null, Expression<Func<string>> reqPdfCreateByHtmloptionsmarginmarginLeft = null, Expression<Func<string>> reqPdfCreateByHtmloptionsmarginmarginRight = null, Expression<Func<string>> reqPdfCreateByHtmloptionsmarginmarginTop = null, Expression<Func<string>> reqPdfCreateByHtmloptionsmarginmarginBottom = null)
        {
            var apiCallPath = "/pdf/create/by-html";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var reqPdfCreateByHtml = new JObject();
            var reqPdfCreateByHtmlpropCount = 0;
            reqPdfCreateByHtmlpropCount++;
            reqPdfCreateByHtml["content"] = CSharpExpressionConverter.ConvertToken(reqPdfCreateByHtmlhTML);
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
                    optionsObject["mediaType"] = CSharpExpressionConverter.ConvertToken(reqPdfCreateByHtmloptionsmediaType);
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
                    optionsObject["format"] = CSharpExpressionConverter.ConvertToken(reqPdfCreateByHtmloptionspageFormat);
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
                    optionsObject["landscape"] = CSharpExpressionConverter.ConvertToken(reqPdfCreateByHtmloptionslandscape);
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
                    marginObject["left"] = CSharpExpressionConverter.ConvertToken(reqPdfCreateByHtmloptionsmarginmarginLeft);
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
                    marginObject["right"] = CSharpExpressionConverter.ConvertToken(reqPdfCreateByHtmloptionsmarginmarginRight);
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
                    marginObject["top"] = CSharpExpressionConverter.ConvertToken(reqPdfCreateByHtmloptionsmarginmarginTop);
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
                    marginObject["bottom"] = CSharpExpressionConverter.ConvertToken(reqPdfCreateByHtmloptionsmarginmarginBottom);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sparsepowerboxtools")]
        public IBodyWorkflowAction<Resp200ImageMergeDrawing> ImageMergeDrawing(Expression<Func<string>> reqImageMergeDrawingbackground, Expression<Func<string>> reqImageMergeDrawingdrawing)
        {
            var apiCallPath = "/image/merge/drawing";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var reqImageMergeDrawing = new JObject();
            var reqImageMergeDrawingpropCount = 0;
            reqImageMergeDrawingpropCount++;
            reqImageMergeDrawing["background"] = CSharpExpressionConverter.ConvertToken(reqImageMergeDrawingbackground);
            reqImageMergeDrawingpropCount++;
            reqImageMergeDrawing["drawing"] = CSharpExpressionConverter.ConvertToken(reqImageMergeDrawingdrawing);
            if (reqImageMergeDrawingpropCount > 0)
            {
                callPayload.Body = reqImageMergeDrawing;
            }

            return new ApiConnectionAction<Resp200ImageMergeDrawing>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sparsepowerboxtools")]
        public IBodyWorkflowAction<Resp200PdfStampText> PdfStampText(Expression<Func<string>> reqPdfStampTextpDF, Expression<Func<string>> reqPdfStampTexttext, Expression<Func<string>> reqPdfStampTextoptionsfontColor = null, Expression<Func<int>> reqPdfStampTextoptionsfontSize = null, Expression<Func<int>> reqPdfStampTextoptionsrotate = null, Expression<Func<int>> reqPdfStampTextoptionspositionyOffset = null, Expression<Func<string>> reqPdfStampTextoptionspositionstartOfYOffset = null, Expression<Func<int>> reqPdfStampTextoptionspositionxOffset = null)
        {
            var apiCallPath = "/pdf/stamp/text";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var reqPdfStampText = new JObject();
            var reqPdfStampTextpropCount = 0;
            reqPdfStampTextpropCount++;
            reqPdfStampText["pdf"] = CSharpExpressionConverter.ConvertToken(reqPdfStampTextpDF);
            reqPdfStampTextpropCount++;
            reqPdfStampText["text"] = CSharpExpressionConverter.ConvertToken(reqPdfStampTexttext);
            var optionsObject = new JObject();
            var optionsObjectpropCount = 0;
            if (reqPdfStampTextoptionsfontColor != null)
            {
                if (reqPdfStampTextoptionsfontColor != null)
                {
                    optionsObject["color"] = CSharpExpressionConverter.ConvertToken(reqPdfStampTextoptionsfontColor);
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
                    optionsObject["size"] = CSharpExpressionConverter.ConvertToken(reqPdfStampTextoptionsfontSize);
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
                    optionsObject["rotate"] = CSharpExpressionConverter.ConvertToken(reqPdfStampTextoptionsrotate);
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
                    positionObject["yOffset"] = CSharpExpressionConverter.ConvertToken(reqPdfStampTextoptionspositionyOffset);
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
                    positionObject["yOffsetStart"] = CSharpExpressionConverter.ConvertToken(reqPdfStampTextoptionspositionstartOfYOffset);
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
                    positionObject["xOffset"] = CSharpExpressionConverter.ConvertToken(reqPdfStampTextoptionspositionxOffset);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sparsepowerboxtools")]
        public IBodyWorkflowAction<Resp200CsvToJson> CsvToJson(Expression<Func<string>> reqCsvToJsoncSV, Expression<Func<bool>> reqCsvToJsonoptionshasHeaders = null, Expression<Func<string>> reqCsvToJsonoptionsdelimiter = null)
        {
            var apiCallPath = "/csv/to-json";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var reqCsvToJson = new JObject();
            var reqCsvToJsonpropCount = 0;
            reqCsvToJsonpropCount++;
            reqCsvToJson["csv"] = CSharpExpressionConverter.ConvertToken(reqCsvToJsoncSV);
            var optionsObject = new JObject();
            var optionsObjectpropCount = 0;
            if (reqCsvToJsonoptionshasHeaders != null)
            {
                if (reqCsvToJsonoptionshasHeaders != null)
                {
                    optionsObject["hasHeaders"] = CSharpExpressionConverter.ConvertToken(reqCsvToJsonoptionshasHeaders);
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
                    optionsObject["delimiter"] = CSharpExpressionConverter.ConvertToken(reqCsvToJsonoptionsdelimiter);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sparsepowerboxtools")]
        public IBodyWorkflowAction<Resp200PdfCreateByUrl> PdfCreateByUrl(Expression<Func<string>> reqPdfCreateByUrlhTML, Expression<Func<string>> reqPdfCreateByUrloptionsmediaType = null, Expression<Func<string>> reqPdfCreateByUrloptionspageFormat = null, Expression<Func<bool>> reqPdfCreateByUrloptionslandscape = null, Expression<Func<string>> reqPdfCreateByUrloptionsmarginmarginLeft = null, Expression<Func<string>> reqPdfCreateByUrloptionsmarginmarginRight = null, Expression<Func<string>> reqPdfCreateByUrloptionsmarginmarginTop = null, Expression<Func<string>> reqPdfCreateByUrloptionsmarginmarginBottom = null)
        {
            var apiCallPath = "/pdf/create/by-url";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var reqPdfCreateByUrl = new JObject();
            var reqPdfCreateByUrlpropCount = 0;
            reqPdfCreateByUrlpropCount++;
            reqPdfCreateByUrl["url"] = CSharpExpressionConverter.ConvertToken(reqPdfCreateByUrlhTML);
            var optionsObject = new JObject();
            var optionsObjectpropCount = 0;
            if (reqPdfCreateByUrloptionsmediaType != null)
            {
                if (reqPdfCreateByUrloptionsmediaType != null)
                {
                    optionsObject["mediaType"] = CSharpExpressionConverter.ConvertToken(reqPdfCreateByUrloptionsmediaType);
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
                    optionsObject["format"] = CSharpExpressionConverter.ConvertToken(reqPdfCreateByUrloptionspageFormat);
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
                    optionsObject["landscape"] = CSharpExpressionConverter.ConvertToken(reqPdfCreateByUrloptionslandscape);
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
                    marginObject["left"] = CSharpExpressionConverter.ConvertToken(reqPdfCreateByUrloptionsmarginmarginLeft);
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
                    marginObject["right"] = CSharpExpressionConverter.ConvertToken(reqPdfCreateByUrloptionsmarginmarginRight);
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
                    marginObject["top"] = CSharpExpressionConverter.ConvertToken(reqPdfCreateByUrloptionsmarginmarginTop);
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
                    marginObject["bottom"] = CSharpExpressionConverter.ConvertToken(reqPdfCreateByUrloptionsmarginmarginBottom);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sparsepowerboxtools")]
        public IBodyWorkflowAction<Resp200ImageStampText> ImageStampText(Expression<Func<string>> reqImageStampTextimage = null, Expression<Func<string>> reqImageStampTexttextToStamp = null, Expression<Func<string>> reqImageStampTextoptionslocationOfTheStamp = null, Expression<Func<string>> reqImageStampTextoptionsfontcolor = null, Expression<Func<int>> reqImageStampTextoptionsfontsize = null)
        {
            var apiCallPath = "/image/stamp/text";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var reqImageStampText = new JObject();
            var reqImageStampTextpropCount = 0;
            if (reqImageStampTextimage != null)
            {
                reqImageStampText["image"] = CSharpExpressionConverter.ConvertToken(reqImageStampTextimage);
                reqImageStampTextpropCount++;
            }

            if (reqImageStampTexttextToStamp != null)
            {
                reqImageStampText["text"] = CSharpExpressionConverter.ConvertToken(reqImageStampTexttextToStamp);
                reqImageStampTextpropCount++;
            }

            var optionsObject = new JObject();
            var optionsObjectpropCount = 0;
            if (reqImageStampTextoptionslocationOfTheStamp != null)
            {
                if (reqImageStampTextoptionslocationOfTheStamp != null)
                {
                    optionsObject["location"] = CSharpExpressionConverter.ConvertToken(reqImageStampTextoptionslocationOfTheStamp);
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
                    optionsObject["fontColor"] = CSharpExpressionConverter.ConvertToken(reqImageStampTextoptionsfontcolor);
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
                    optionsObject["fontSize"] = CSharpExpressionConverter.ConvertToken(reqImageStampTextoptionsfontsize);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sparsepowerboxtools")]
        public IBodyWorkflowAction<Resp200ImageResize> ImageResize(Expression<Func<string>> reqImageResizeimage = null, Expression<Func<int>> reqImageResizewidth = null, Expression<Func<int>> reqImageResizeheight = null, Expression<Func<bool>> reqImageResizeoptionsignoreTheAspectRation = null)
        {
            var apiCallPath = "/image/resize";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var reqImageResize = new JObject();
            var reqImageResizepropCount = 0;
            if (reqImageResizeimage != null)
            {
                reqImageResize["image"] = CSharpExpressionConverter.ConvertToken(reqImageResizeimage);
                reqImageResizepropCount++;
            }

            if (reqImageResizewidth != null)
            {
                reqImageResize["width"] = CSharpExpressionConverter.ConvertToken(reqImageResizewidth);
                reqImageResizepropCount++;
            }

            if (reqImageResizeheight != null)
            {
                reqImageResize["height"] = CSharpExpressionConverter.ConvertToken(reqImageResizeheight);
                reqImageResizepropCount++;
            }

            var optionsObject = new JObject();
            var optionsObjectpropCount = 0;
            if (reqImageResizeoptionsignoreTheAspectRation != null)
            {
                if (reqImageResizeoptionsignoreTheAspectRation != null)
                {
                    optionsObject["ignoreAspectRation"] = CSharpExpressionConverter.ConvertToken(reqImageResizeoptionsignoreTheAspectRation);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sparsepowerboxtools")]
        public IBodyWorkflowAction<Resp200PdfSplitByPage> PdfSplitByPage(Expression<Func<string>> reqPdfSplitByPagepDFFile = null, Expression<Func<double>> reqPdfSplitByPageoptionsnumberOfPages = null)
        {
            var apiCallPath = "/pdf/split/by-page";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var reqPdfSplitByPage = new JObject();
            var reqPdfSplitByPagepropCount = 0;
            if (reqPdfSplitByPagepDFFile != null)
            {
                reqPdfSplitByPage["pdf"] = CSharpExpressionConverter.ConvertToken(reqPdfSplitByPagepDFFile);
                reqPdfSplitByPagepropCount++;
            }

            var optionsObject = new JObject();
            var optionsObjectpropCount = 0;
            if (reqPdfSplitByPageoptionsnumberOfPages != null)
            {
                if (reqPdfSplitByPageoptionsnumberOfPages != null)
                {
                    optionsObject["numberOfPages"] = CSharpExpressionConverter.ConvertToken(reqPdfSplitByPageoptionsnumberOfPages);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sparsepowerboxtools")]
        public IBodyWorkflowAction<Resp200ImageStampExif> ImageStampExif(Expression<Func<string>> reqImageStampExifimage = null, Expression<Func<string[]>> reqImageStampExifoptionstags = null, Expression<Func<string>> reqImageStampExifoptionslocationOfTheStamp = null, Expression<Func<string>> reqImageStampExifoptionsfontcolor = null, Expression<Func<int>> reqImageStampExifoptionsfontsize = null, Expression<Func<bool>> reqImageStampExifoptionsprintTagName = null)
        {
            var apiCallPath = "/image/stamp/exif";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var reqImageStampExif = new JObject();
            var reqImageStampExifpropCount = 0;
            if (reqImageStampExifimage != null)
            {
                reqImageStampExif["image"] = CSharpExpressionConverter.ConvertToken(reqImageStampExifimage);
                reqImageStampExifpropCount++;
            }

            var optionsObject = new JObject();
            var optionsObjectpropCount = 0;
            if (reqImageStampExifoptionstags != null)
            {
                optionsObject["tags"] = CSharpExpressionConverter.ConvertToken(reqImageStampExifoptionstags);
                optionsObjectpropCount++;
            }

            if (reqImageStampExifoptionslocationOfTheStamp != null)
            {
                if (reqImageStampExifoptionslocationOfTheStamp != null)
                {
                    optionsObject["location"] = CSharpExpressionConverter.ConvertToken(reqImageStampExifoptionslocationOfTheStamp);
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
                    optionsObject["fontColor"] = CSharpExpressionConverter.ConvertToken(reqImageStampExifoptionsfontcolor);
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
                    optionsObject["fontSize"] = CSharpExpressionConverter.ConvertToken(reqImageStampExifoptionsfontsize);
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
                    optionsObject["printTagName"] = CSharpExpressionConverter.ConvertToken(reqImageStampExifoptionsprintTagName);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sparsepowerboxtools")]
        public IBodyWorkflowAction<Resp200PdfFillForm> PdfFillForm(Expression<Func<string>> reqPdfFillFormpDFFile = null)
        {
            var apiCallPath = "/form/fill";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var reqPdfFillForm = new JObject();
            var reqPdfFillFormpropCount = 0;
            if (reqPdfFillFormpDFFile != null)
            {
                reqPdfFillForm["pdf"] = CSharpExpressionConverter.ConvertToken(reqPdfFillFormpDFFile);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sparsepowerboxtools")]
        public IBodyWorkflowAction<Resp200PdfGetFormData> PdfGetFormData(Expression<Func<string>> reqPdfGetFormDatapDFFile = null)
        {
            var apiCallPath = "/form/getdata";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var reqPdfGetFormData = new JObject();
            var reqPdfGetFormDatapropCount = 0;
            if (reqPdfGetFormDatapDFFile != null)
            {
                reqPdfGetFormData["pdf"] = CSharpExpressionConverter.ConvertToken(reqPdfGetFormDatapDFFile);
                reqPdfGetFormDatapropCount++;
            }

            if (reqPdfGetFormDatapropCount > 0)
            {
                callPayload.Body = reqPdfGetFormData;
            }

            return new ApiConnectionAction<Resp200PdfGetFormData>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sparsepowerboxtools")]
        public IBodyWorkflowAction<Resp200PdfMergeSimple> PdfMergeSimple(Expression<Func<string[]>> reqPdfMergeSimplepDFFile = null)
        {
            var apiCallPath = "/pdf/merge/simple";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var reqPdfMergeSimple = new JObject();
            var reqPdfMergeSimplepropCount = 0;
            if (reqPdfMergeSimplepDFFile != null)
            {
                reqPdfMergeSimple["pdfs"] = CSharpExpressionConverter.ConvertToken(reqPdfMergeSimplepDFFile);
                reqPdfMergeSimplepropCount++;
            }

            if (reqPdfMergeSimplepropCount > 0)
            {
                callPayload.Body = reqPdfMergeSimple;
            }

            return new ApiConnectionAction<Resp200PdfMergeSimple>(callPayload);
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