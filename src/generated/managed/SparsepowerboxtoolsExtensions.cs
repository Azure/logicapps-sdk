//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Sparsepowerboxtools
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SparsepowerboxtoolsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sparsepowerboxtools")]
        public IBodyWorkflowAction<Resp200PdfStampImage, ApiConnectionActionConfiguration> PdfStampImage(Expression<Func<PdfStampImageInput>> reqPdfStampImage = null)
        {
            var __workflow_reqPdfStampImage = WorkflowExpression.Compile(reqPdfStampImage, nameof(reqPdfStampImage), required: false);
            return new DeferredBodyAction<Resp200PdfStampImage, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pdf/stamp/image";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_reqPdfStampImage != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_reqPdfStampImage);
                return new ApiConnectionAction<Resp200PdfStampImage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sparsepowerboxtools")]
        public IBodyWorkflowAction<Resp200ExcelSheetAddRows, ApiConnectionActionConfiguration> ExcelSheetAddRows(Expression<Func<ExcelSheetAddRowsInput>> reqExcelSheetAddrows = null)
        {
            var __workflow_reqExcelSheetAddrows = WorkflowExpression.Compile(reqExcelSheetAddrows, nameof(reqExcelSheetAddrows), required: false);
            return new DeferredBodyAction<Resp200ExcelSheetAddRows, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/excel/sheet/add-rows";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_reqExcelSheetAddrows != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_reqExcelSheetAddrows);
                return new ApiConnectionAction<Resp200ExcelSheetAddRows>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sparsepowerboxtools")]
        public IBodyWorkflowAction<Resp200PdfCreateByHtml, ApiConnectionActionConfiguration> PdfCreateByHtml(Expression<Func<PdfCreateByHtmlInput>> reqPdfCreateByHtml = null)
        {
            var __workflow_reqPdfCreateByHtml = WorkflowExpression.Compile(reqPdfCreateByHtml, nameof(reqPdfCreateByHtml), required: false);
            return new DeferredBodyAction<Resp200PdfCreateByHtml, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pdf/create/by-html";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_reqPdfCreateByHtml != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_reqPdfCreateByHtml);
                return new ApiConnectionAction<Resp200PdfCreateByHtml>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sparsepowerboxtools")]
        public IBodyWorkflowAction<Resp200ImageMergeDrawing, ApiConnectionActionConfiguration> ImageMergeDrawing(Expression<Func<ImageMergeDrawingInput>> reqImageMergeDrawing = null)
        {
            var __workflow_reqImageMergeDrawing = WorkflowExpression.Compile(reqImageMergeDrawing, nameof(reqImageMergeDrawing), required: false);
            return new DeferredBodyAction<Resp200ImageMergeDrawing, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/image/merge/drawing";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_reqImageMergeDrawing != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_reqImageMergeDrawing);
                return new ApiConnectionAction<Resp200ImageMergeDrawing>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sparsepowerboxtools")]
        public IBodyWorkflowAction<Resp200PdfStampText, ApiConnectionActionConfiguration> PdfStampText(Expression<Func<PdfStampTextInput>> reqPdfStampText = null)
        {
            var __workflow_reqPdfStampText = WorkflowExpression.Compile(reqPdfStampText, nameof(reqPdfStampText), required: false);
            return new DeferredBodyAction<Resp200PdfStampText, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pdf/stamp/text";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_reqPdfStampText != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_reqPdfStampText);
                return new ApiConnectionAction<Resp200PdfStampText>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sparsepowerboxtools")]
        public IBodyWorkflowAction<Resp200CsvToJson, ApiConnectionActionConfiguration> CsvToJson(Expression<Func<CsvToJsonInput>> reqCsvToJson = null)
        {
            var __workflow_reqCsvToJson = WorkflowExpression.Compile(reqCsvToJson, nameof(reqCsvToJson), required: false);
            return new DeferredBodyAction<Resp200CsvToJson, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/csv/to-json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_reqCsvToJson != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_reqCsvToJson);
                return new ApiConnectionAction<Resp200CsvToJson>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sparsepowerboxtools")]
        public IBodyWorkflowAction<Resp200PdfCreateByUrl, ApiConnectionActionConfiguration> PdfCreateByUrl(Expression<Func<PdfCreateByUrlInput>> reqPdfCreateByUrl = null)
        {
            var __workflow_reqPdfCreateByUrl = WorkflowExpression.Compile(reqPdfCreateByUrl, nameof(reqPdfCreateByUrl), required: false);
            return new DeferredBodyAction<Resp200PdfCreateByUrl, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pdf/create/by-url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_reqPdfCreateByUrl != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_reqPdfCreateByUrl);
                return new ApiConnectionAction<Resp200PdfCreateByUrl>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sparsepowerboxtools")]
        public IBodyWorkflowAction<Resp200ImageStampText, ApiConnectionActionConfiguration> ImageStampText(Expression<Func<ImageStampTextInput>> reqImageStampText = null)
        {
            var __workflow_reqImageStampText = WorkflowExpression.Compile(reqImageStampText, nameof(reqImageStampText), required: false);
            return new DeferredBodyAction<Resp200ImageStampText, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/image/stamp/text";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_reqImageStampText != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_reqImageStampText);
                return new ApiConnectionAction<Resp200ImageStampText>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sparsepowerboxtools")]
        public IBodyWorkflowAction<Resp200ImageResize, ApiConnectionActionConfiguration> ImageResize(Expression<Func<ImageResizeInput>> reqImageResize = null)
        {
            var __workflow_reqImageResize = WorkflowExpression.Compile(reqImageResize, nameof(reqImageResize), required: false);
            return new DeferredBodyAction<Resp200ImageResize, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/image/resize";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_reqImageResize != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_reqImageResize);
                return new ApiConnectionAction<Resp200ImageResize>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sparsepowerboxtools")]
        public IBodyWorkflowAction<Resp200PdfSplitByPage, ApiConnectionActionConfiguration> PdfSplitByPage(Expression<Func<PdfSplitByPageInput>> reqPdfSplitByPage = null)
        {
            var __workflow_reqPdfSplitByPage = WorkflowExpression.Compile(reqPdfSplitByPage, nameof(reqPdfSplitByPage), required: false);
            return new DeferredBodyAction<Resp200PdfSplitByPage, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pdf/split/by-page";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_reqPdfSplitByPage != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_reqPdfSplitByPage);
                return new ApiConnectionAction<Resp200PdfSplitByPage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sparsepowerboxtools")]
        public IBodyWorkflowAction<Resp200ImageStampExif, ApiConnectionActionConfiguration> ImageStampExif(Expression<Func<ImageStampExifInput>> reqImageStampExif = null)
        {
            var __workflow_reqImageStampExif = WorkflowExpression.Compile(reqImageStampExif, nameof(reqImageStampExif), required: false);
            return new DeferredBodyAction<Resp200ImageStampExif, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/image/stamp/exif";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_reqImageStampExif != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_reqImageStampExif);
                return new ApiConnectionAction<Resp200ImageStampExif>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sparsepowerboxtools")]
        public IBodyWorkflowAction<Resp200PdfFillForm, ApiConnectionActionConfiguration> PdfFillForm(Expression<Func<PdfFillFormInput>> reqPdfFillForm = null)
        {
            var __workflow_reqPdfFillForm = WorkflowExpression.Compile(reqPdfFillForm, nameof(reqPdfFillForm), required: false);
            return new DeferredBodyAction<Resp200PdfFillForm, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/form/fill";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_reqPdfFillForm != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_reqPdfFillForm);
                return new ApiConnectionAction<Resp200PdfFillForm>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sparsepowerboxtools")]
        public IBodyWorkflowAction<Resp200PdfGetFormData, ApiConnectionActionConfiguration> PdfGetFormData(Expression<Func<PdfGetFormDataInput>> reqPdfGetFormData = null)
        {
            var __workflow_reqPdfGetFormData = WorkflowExpression.Compile(reqPdfGetFormData, nameof(reqPdfGetFormData), required: false);
            return new DeferredBodyAction<Resp200PdfGetFormData, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/form/getdata";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_reqPdfGetFormData != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_reqPdfGetFormData);
                return new ApiConnectionAction<Resp200PdfGetFormData>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sparsepowerboxtools")]
        public IBodyWorkflowAction<Resp200PdfMergeSimple, ApiConnectionActionConfiguration> PdfMergeSimple(Expression<Func<PdfMergeSimpleInput>> reqPdfMergeSimple = null)
        {
            var __workflow_reqPdfMergeSimple = WorkflowExpression.Compile(reqPdfMergeSimple, nameof(reqPdfMergeSimple), required: false);
            return new DeferredBodyAction<Resp200PdfMergeSimple, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pdf/merge/simple";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_reqPdfMergeSimple != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_reqPdfMergeSimple);
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

    public class PdfStampImageInput
    {
        [JsonProperty("pdf", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PDF { get; set; }

        [JsonProperty("image", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Image { get; set; }

        [JsonProperty("options")]
        public PdfStampImageInputOptionsType Options { get; set; }
    }

    public class PdfStampImageInputOptionsType
    {
        [JsonProperty("opacity", DefaultValueHandling = DefaultValueHandling.Include)]
        public double? Opacity { get; set; } = 1;

        [JsonProperty("scale", DefaultValueHandling = DefaultValueHandling.Include)]
        public double? Scale { get; set; } = 1;

        [JsonProperty("rotate", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Rotate { get; set; } = 0;

        [JsonProperty("position")]
        public PdfStampImageInputOptionsTypePositionType Position { get; set; }
    }

    public class PdfStampImageInputOptionsTypePositionType
    {
        [JsonProperty("yOffset", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? YOffset { get; set; } = 25;

        [JsonProperty("yOffsetStart", DefaultValueHandling = DefaultValueHandling.Include)]
        public string StartOfYOffset { get; set; } = "bottom";

        [JsonProperty("xOffset", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? XOffset { get; set; } = 50;
    }

    public class Resp200ExcelSheetAddRows
    {
        [JsonProperty("result")]
        public string ExcelSheet { get; set; }
    }

    public class ExcelSheetAddRowsInput
    {
        [JsonProperty("sheet", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Sheetname { get; set; }

        [JsonProperty("data")]
        public JToken[] Data { get; set; }

        [JsonProperty("excelFile", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Excel { get; set; }
    }

    public class Resp200PdfCreateByHtml
    {
        [JsonProperty("result")]
        public string PDFFile { get; set; }
    }

    public class PdfCreateByHtmlInput
    {
        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public string HTML { get; set; }

        [JsonProperty("data")]
        public JToken Data { get; set; }

        [JsonProperty("options")]
        public PdfCreateByHtmlInputOptionsType Options { get; set; }
    }

    public class PdfCreateByHtmlInputOptionsType
    {
        [JsonProperty("mediaType", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MediaType { get; set; } = "print";

        [JsonProperty("format", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PageFormat { get; set; } = "A4";

        [JsonProperty("landscape", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Landscape { get; set; } = false;

        [JsonProperty("margin")]
        public PdfCreateByHtmlInputOptionsTypeMarginType Margin { get; set; }
    }

    public class PdfCreateByHtmlInputOptionsTypeMarginType
    {
        [JsonProperty("left", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MarginLeft { get; set; } = "0px";

        [JsonProperty("right", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MarginRight { get; set; } = "0px";

        [JsonProperty("top", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MarginTop { get; set; } = "0px";

        [JsonProperty("bottom", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MarginBottom { get; set; } = "0px";
    }

    public class Resp200ImageMergeDrawing
    {
        [JsonProperty("result")]
        public string Image { get; set; }
    }

    public class ImageMergeDrawingInput
    {
        [JsonProperty("background", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Background { get; set; }

        [JsonProperty("drawing", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Drawing { get; set; }
    }

    public class Resp200PdfStampText
    {
        [JsonProperty("result")]
        public string PDFFile { get; set; }
    }

    public class PdfStampTextInput
    {
        [JsonProperty("pdf", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PDF { get; set; }

        [JsonProperty("text", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Text { get; set; }

        [JsonProperty("options")]
        public PdfStampTextInputOptionsType Options { get; set; }
    }

    public class PdfStampTextInputOptionsType
    {
        [JsonProperty("color", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FontColor { get; set; } = "#000000";

        [JsonProperty("size", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? FontSize { get; set; } = 50;

        [JsonProperty("rotate", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Rotate { get; set; } = 0;

        [JsonProperty("position")]
        public PdfStampTextInputOptionsTypePositionType Position { get; set; }
    }

    public class PdfStampTextInputOptionsTypePositionType
    {
        [JsonProperty("yOffset", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? YOffset { get; set; } = 25;

        [JsonProperty("yOffsetStart", DefaultValueHandling = DefaultValueHandling.Include)]
        public string StartOfYOffset { get; set; } = "bottom";

        [JsonProperty("xOffset", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? XOffset { get; set; } = 50;
    }

    public class Resp200CsvToJson
    {
        [JsonProperty("records")]
        public JToken[] Records { get; set; }
    }

    public class CsvToJsonInput
    {
        [JsonProperty("csv", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CSV { get; set; }

        [JsonProperty("options", DefaultValueHandling = DefaultValueHandling.Include)]
        public CsvToJsonInputOptionsType Options { get; set; }
    }

    public class CsvToJsonInputOptionsType
    {
        [JsonProperty("hasHeaders", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool HasHeaders { get; set; } = true;

        [JsonProperty("delimiter", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Delimiter { get; set; } = ",";
    }

    public class Resp200PdfCreateByUrl
    {
        [JsonProperty("result")]
        public string PDFFile { get; set; }
    }

    public class PdfCreateByUrlInput
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        public string HTML { get; set; }

        [JsonProperty("options")]
        public PdfCreateByUrlInputOptionsType Options { get; set; }
    }

    public class PdfCreateByUrlInputOptionsType
    {
        [JsonProperty("mediaType", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MediaType { get; set; } = "print";

        [JsonProperty("format", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PageFormat { get; set; } = "A4";

        [JsonProperty("landscape", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Landscape { get; set; } = false;

        [JsonProperty("margin")]
        public PdfCreateByUrlInputOptionsTypeMarginType Margin { get; set; }
    }

    public class PdfCreateByUrlInputOptionsTypeMarginType
    {
        [JsonProperty("left", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MarginLeft { get; set; } = "0px";

        [JsonProperty("right", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MarginRight { get; set; } = "0px";

        [JsonProperty("top", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MarginTop { get; set; } = "0px";

        [JsonProperty("bottom", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MarginBottom { get; set; } = "0px";
    }

    public class Resp200ImageStampText
    {
        [JsonProperty("result")]
        public string StampedImage { get; set; }
    }

    public class ImageStampTextInput
    {
        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("text")]
        public string TextToStamp { get; set; }

        [JsonProperty("options")]
        public ImageStampTextInputOptionsType Options { get; set; }
    }

    public class ImageStampTextInputOptionsType
    {
        [JsonProperty("location", DefaultValueHandling = DefaultValueHandling.Include)]
        public string LocationOfTheStamp { get; set; } = "Center";

        [JsonProperty("fontColor", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Fontcolor { get; set; } = "#ffffff";

        [JsonProperty("fontSize", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Fontsize { get; set; } = 25;
    }

    public class Resp200ImageResize
    {
        [JsonProperty("result")]
        public string ResizedImage { get; set; }
    }

    public class ImageResizeInput
    {
        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("width")]
        public int? Width { get; set; }

        [JsonProperty("height")]
        public int? Height { get; set; }

        [JsonProperty("options")]
        public ImageResizeInputOptionsType Options { get; set; }
    }

    public class ImageResizeInputOptionsType
    {
        [JsonProperty("ignoreAspectRation", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IgnoreTheAspectRation { get; set; } = false;
    }

    public class Resp200PdfSplitByPage
    {
        [JsonProperty("results")]
        public string[] PDFFile { get; set; }
    }

    public class PdfSplitByPageInput
    {
        [JsonProperty("pdf")]
        public string PDFFile { get; set; }

        [JsonProperty("options")]
        public PdfSplitByPageInputOptionsType Options { get; set; }
    }

    public class PdfSplitByPageInputOptionsType
    {
        [JsonProperty("numberOfPages", DefaultValueHandling = DefaultValueHandling.Include)]
        public double? NumberOfPages { get; set; } = 1;
    }

    public class Resp200ImageStampExif
    {
        [JsonProperty("result")]
        public string StampedImage { get; set; }

        [JsonProperty("printedTags")]
        public string[] PrintedTags { get; set; }
    }

    public class ImageStampExifInput
    {
        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("options")]
        public ImageStampExifInputOptionsType Options { get; set; }
    }

    public class ImageStampExifInputOptionsType
    {
        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("location", DefaultValueHandling = DefaultValueHandling.Include)]
        public string LocationOfTheStamp { get; set; } = "Center";

        [JsonProperty("fontColor", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Fontcolor { get; set; } = "#ffffff";

        [JsonProperty("fontSize", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Fontsize { get; set; } = 25;

        [JsonProperty("printTagName", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? PrintTagName { get; set; } = false;
    }

    public class Resp200PdfFillForm
    {
        [JsonProperty("result")]
        public string PDFFile { get; set; }
    }

    public class PdfFillFormInput
    {
        [JsonProperty("pdf")]
        public string PDFFile { get; set; }

        [JsonProperty("data")]
        public JToken Data { get; set; }
    }

    public class Resp200PdfGetFormData
    {
        [JsonProperty("result")]
        public JToken FormData { get; set; }
    }

    public class PdfGetFormDataInput
    {
        [JsonProperty("pdf")]
        public string PDFFile { get; set; }
    }

    public class Resp200PdfMergeSimple
    {
        [JsonProperty("result")]
        public string PDFFile { get; set; }
    }

    public class PdfMergeSimpleInput
    {
        [JsonProperty("pdfs")]
        public string[] PDFFile { get; set; }
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