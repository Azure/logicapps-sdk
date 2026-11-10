//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pdfco
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PdfcoActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<HtmlToPdfResponse, ApiConnectionActionConfiguration> HtmlToPdf(Expression<Func<HtmlToPdfBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<HtmlToPdfResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pdf/convert/from/html";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<HtmlToPdfResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<UrlToPdfResponse, ApiConnectionActionConfiguration> UrlToPdf(Expression<Func<UrlToPdfBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UrlToPdfResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pdf/convert/from/url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UrlToPdfResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PdfFillerResponse, ApiConnectionActionConfiguration> PdfFiller(Expression<Func<PdfFillerBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PdfFillerResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pdf/edit/add";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PdfFillerResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<MergePdfSimplifiedResponse, ApiConnectionActionConfiguration> MergePdfSimplified(Expression<Func<MergePdfBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<MergePdfSimplifiedResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pdf/merge";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MergePdfSimplifiedResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<MergePdfResponse, ApiConnectionActionConfiguration> MergePdf(Expression<Func<MergePdfBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<MergePdfResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pdf/merge2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MergePdfResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<SplitPdfResponse, ApiConnectionActionConfiguration> SplitPdf(Expression<Func<SplitPdfBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SplitPdfResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pdf/split";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SplitPdfResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<SplitPdf2Response, ApiConnectionActionConfiguration> SplitPdf2(Expression<Func<SplitPdf2BodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SplitPdf2Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pdf/split2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SplitPdf2Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFSerarchTextResponse, ApiConnectionActionConfiguration> PDFSerarchText(Expression<Func<PDFSerarchTextBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PDFSerarchTextResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pdf/find";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PDFSerarchTextResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<DocumentParserResponse, ApiConnectionActionConfiguration> DocumentParser(Expression<Func<DocumentParserBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<DocumentParserResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pdf/documentparser";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DocumentParserResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<JobCheckResponse, ApiConnectionActionConfiguration> JobCheck(Expression<Func<JobCheckBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<JobCheckResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/job/check";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JobCheckResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<BarcodeGeneratorResponse, ApiConnectionActionConfiguration> BarcodeGenerator(Expression<Func<BarcodeGeneratorBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<BarcodeGeneratorResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/barcode/generate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<BarcodeGeneratorResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<BarcodeReaderResponse, ApiConnectionActionConfiguration> BarcodeReader(Expression<Func<BarcodeReaderBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<BarcodeReaderResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/barcode/read/from/url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<BarcodeReaderResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFInfoReaderResponse, ApiConnectionActionConfiguration> PDFInfoReader(Expression<Func<PDFInfoReaderBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PDFInfoReaderResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pdf/info";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PDFInfoReaderResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFFormsInfoReaderResponse, ApiConnectionActionConfiguration> PDFFormsInfoReader(Expression<Func<PDFFormsInfoReaderBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PDFFormsInfoReaderResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pdf/info/fields";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PDFFormsInfoReaderResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFFindTableResponse, ApiConnectionActionConfiguration> PDFFindTable(Expression<Func<PDFFindTableBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PDFFindTableResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pdf/find/table";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PDFFindTableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<SearchAndReplaceResponse, ApiConnectionActionConfiguration> SearchAndReplace(Expression<Func<SearchAndReplaceBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SearchAndReplaceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pdf/edit/replace-text";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SearchAndReplaceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<SearchAndReplaceWithImageResponse, ApiConnectionActionConfiguration> SearchAndReplaceWithImage(Expression<Func<SearchAndReplaceWithImageBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SearchAndReplaceWithImageResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pdf/edit/replace-text-with-image";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SearchAndReplaceWithImageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<SearchAndDeleteTextResponse, ApiConnectionActionConfiguration> SearchAndDeleteText(Expression<Func<SearchAndDeleteTextBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SearchAndDeleteTextResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pdf/edit/delete-text";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SearchAndDeleteTextResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFSearchableResponse, ApiConnectionActionConfiguration> PDFSearchable(Expression<Func<PDFSearchableBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PDFSearchableResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pdf/makesearchable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PDFSearchableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFUnSearchableResponse, ApiConnectionActionConfiguration> PDFUnSearchable(Expression<Func<PDFUnSearchableBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PDFUnSearchableResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pdf/makeunsearchable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PDFUnSearchableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFToCSVResponse, ApiConnectionActionConfiguration> PDFToCSV(Expression<Func<PDFToCSVBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PDFToCSVResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pdf/convert/to/csv";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PDFToCSVResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFToJSONResponse, ApiConnectionActionConfiguration> PDFToJSON(Expression<Func<PDFToCSVBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PDFToJSONResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pdf/convert/to/json2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PDFToJSONResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFToJSONMetaResponse, ApiConnectionActionConfiguration> PDFToJSONMeta(Expression<Func<PDFToCSVBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PDFToJSONMetaResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pdf/convert/to/json-meta";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PDFToJSONMetaResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFToTextResponse, ApiConnectionActionConfiguration> PDFToText(Expression<Func<PDFToCSVBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PDFToTextResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pdf/convert/to/text";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PDFToTextResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFToTextSimpleResponse, ApiConnectionActionConfiguration> PDFToTextSimple(Expression<Func<PDFToTextSimpleBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PDFToTextSimpleResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pdf/convert/to/text-simple";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PDFToTextSimpleResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFToXLSResponse, ApiConnectionActionConfiguration> PDFToXLS(Expression<Func<PDFToXLSBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PDFToXLSResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pdf/convert/to/xls";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PDFToXLSResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFToXLSXResponse, ApiConnectionActionConfiguration> PDFToXLSX(Expression<Func<PDFToXLSBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PDFToXLSXResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pdf/convert/to/xlsx";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PDFToXLSXResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFToXMLResponse, ApiConnectionActionConfiguration> PDFToXML(Expression<Func<PDFToCSVBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PDFToXMLResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pdf/convert/to/xml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PDFToXMLResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFToJPGResponse, ApiConnectionActionConfiguration> PDFToJPG(Expression<Func<PDFToJPGBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PDFToJPGResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pdf/convert/to/jpg";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PDFToJPGResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFToPNGResponse, ApiConnectionActionConfiguration> PDFToPNG(Expression<Func<PDFToJPGBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PDFToPNGResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pdf/convert/to/png";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PDFToPNGResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFToWEBPResponse, ApiConnectionActionConfiguration> PDFToWEBP(Expression<Func<PDFToJPGBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PDFToWEBPResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pdf/convert/to/webp";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PDFToWEBPResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFToTIFFResponse, ApiConnectionActionConfiguration> PDFToTIFF(Expression<Func<PDFToJPGBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PDFToTIFFResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pdf/convert/to/tiff";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PDFToTIFFResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFFromCSVResponse, ApiConnectionActionConfiguration> PDFFromCSV(Expression<Func<PDFFromCSVBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PDFFromCSVResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pdf/convert/from/csv";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PDFFromCSVResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFFromDocResponse, ApiConnectionActionConfiguration> PDFFromDoc(Expression<Func<PDFFromCSVBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PDFFromDocResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pdf/convert/from/doc";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PDFFromDocResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFFromImagesResponse, ApiConnectionActionConfiguration> PDFFromImages(Expression<Func<PDFFromImagesBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PDFFromImagesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pdf/convert/from/image";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PDFFromImagesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFFromEmailResponse, ApiConnectionActionConfiguration> PDFFromEmail(Expression<Func<PDFFromEmailBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PDFFromEmailResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pdf/convert/from/email";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PDFFromEmailResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFAddSecurityResponse, ApiConnectionActionConfiguration> PDFAddSecurity(Expression<Func<PDFAddSecurityBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PDFAddSecurityResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pdf/security/add";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PDFAddSecurityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFSecurityRemoveResponse, ApiConnectionActionConfiguration> PDFSecurityRemove(Expression<Func<PDFSecurityRemoveBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PDFSecurityRemoveResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pdf/security/remove";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PDFSecurityRemoveResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFFromXLSXLSXResponse, ApiConnectionActionConfiguration> PDFFromXLSXLSX(Expression<Func<PDFFromXLSXLSXBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PDFFromXLSXLSXResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/xls/convert/to/pdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PDFFromXLSXLSXResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<XLStoCSVResponse, ApiConnectionActionConfiguration> XLStoCSV(Expression<Func<XLStoCSVBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<XLStoCSVResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/xls/convert/to/csv";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<XLStoCSVResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<XLStoJSONResponse, ApiConnectionActionConfiguration> XLStoJSON(Expression<Func<PDFFromXLSXLSXBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<XLStoJSONResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/xls/convert/to/json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<XLStoJSONResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<XLStoHTMLResponse, ApiConnectionActionConfiguration> XLStoHTML(Expression<Func<PDFFromXLSXLSXBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<XLStoHTMLResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/xls/convert/to/html";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<XLStoHTMLResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<XLStoTXTResponse, ApiConnectionActionConfiguration> XLStoTXT(Expression<Func<PDFFromXLSXLSXBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<XLStoTXTResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/xls/convert/to/txt";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<XLStoTXTResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<XLStoXMLResponse, ApiConnectionActionConfiguration> XLStoXML(Expression<Func<PDFFromXLSXLSXBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<XLStoXMLResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/xls/convert/to/xml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<XLStoXMLResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFRotatePagesResponse, ApiConnectionActionConfiguration> PDFRotatePages(Expression<Func<PDFRotatePagesBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PDFRotatePagesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pdf/edit/rotate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PDFRotatePagesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFAutoRotatePagesResponse, ApiConnectionActionConfiguration> PDFAutoRotatePages(Expression<Func<PDFAutoRotatePagesBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PDFAutoRotatePagesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pdf/edit/rotate/auto";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PDFAutoRotatePagesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFDeletePagesResponse, ApiConnectionActionConfiguration> PDFDeletePages(Expression<Func<PDFDeletePagesBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PDFDeletePagesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pdf/edit/delete-pages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PDFDeletePagesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFCompressResponse, ApiConnectionActionConfiguration> PDFCompress(Expression<Func<PDFCompressBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PDFCompressResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pdf/optimize";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PDFCompressResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFClassifierResponse, ApiConnectionActionConfiguration> PDFClassifier(Expression<Func<PDFClassifierBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PDFClassifierResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pdf/classifier";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PDFClassifierResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<EmailSendResponse, ApiConnectionActionConfiguration> EmailSend(Expression<Func<EmailSendBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<EmailSendResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/email/send";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<EmailSendResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<EmailDecodeResponse, ApiConnectionActionConfiguration> EmailDecode(Expression<Func<EmailAttachmentExtractionBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<EmailDecodeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/email/decode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<EmailDecodeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<EmailAttachmentExtractionResponse, ApiConnectionActionConfiguration> EmailAttachmentExtraction(Expression<Func<EmailAttachmentExtractionBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<EmailAttachmentExtractionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/email/extract-attachments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<EmailAttachmentExtractionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFAttachmentExtractionResponse, ApiConnectionActionConfiguration> PDFAttachmentExtraction(Expression<Func<PDFAttachmentExtractionBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PDFAttachmentExtractionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pdf/attachments/extract";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                else
                    callPayload.Body = new PDFAttachmentExtractionBodyInput().ToJToken();
                return new ApiConnectionAction<PDFAttachmentExtractionResponse>(callPayload);
            });
        }
    }

    public class PdfcoTriggers([ConnectionName] string connectionId)
    {
    }

    public class HtmlToPdfResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }
    }

    public class HtmlToPdfBodyInput
    {
        public HtmlToPdfBodyInput(string html)
        {
            this.Html = html;
        }

        [JsonProperty("html", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Html { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("margins", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Margins { get; set; } = "5px 5px 5px 5px";

        [JsonProperty("paperSize", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputPaperSizeType? PaperSize { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdfco.BodyInputPaperSizeType.Letter;

        [JsonProperty("orientation", DefaultValueHandling = DefaultValueHandling.Include)]
        public HtmlToPdfBodyInputOrientationType? Orientation { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdfco.HtmlToPdfBodyInputOrientationType.Portrait;

        [JsonProperty("printBackground", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? PrintBackground { get; set; } = true;

        [JsonProperty("header")]
        public string Header { get; set; }

        [JsonProperty("footer")]
        public string Footer { get; set; }

        [JsonProperty("expiration", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Expiration { get; set; } = 60;

        [JsonProperty("profiles")]
        public string Profiles { get; set; }

        [JsonProperty("async", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Async { get; set; } = false;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputPaperSizeType
    {
        Letter,
        Legal,
        Tabloid,
        Ledger,
        A0,
        A1,
        A2,
        A3,
        A4,
        A5,
        A6
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum HtmlToPdfBodyInputOrientationType
    {
        [EnumMember(Value = "portrait")]
        Portrait,
        [EnumMember(Value = "landscape")]
        Landscape
    }

    public class UrlToPdfResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }
    }

    public class UrlToPdfBodyInput
    {
        public UrlToPdfBodyInput(string url)
        {
            this.Url = url;
        }

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Url { get; set; }

        [JsonProperty("margins", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Margins { get; set; } = "5mm";

        [JsonProperty("paperSize", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PaperSize { get; set; } = "Letter";

        [JsonProperty("orientation", DefaultValueHandling = DefaultValueHandling.Include)]
        public UrlToPdfBodyInputOrientationType? Orientation { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdfco.UrlToPdfBodyInputOrientationType.Portrait;

        [JsonProperty("printBackground", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? PrintBackground { get; set; } = true;

        [JsonProperty("header")]
        public string Header { get; set; }

        [JsonProperty("footer")]
        public string Footer { get; set; }

        [JsonProperty("expiration", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Expiration { get; set; } = 60;

        [JsonProperty("profiles")]
        public string Profiles { get; set; }

        [JsonProperty("async", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Async { get; set; } = false;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UrlToPdfBodyInputOrientationType
    {
        Portrait,
        Landscape
    }

    public class PdfFillerResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }
    }

    public class PdfFillerBodyInput
    {
        public PdfFillerBodyInput(string url)
        {
            this.Url = url;
        }

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Url { get; set; }

        [JsonProperty("annotationsString")]
        public string AnnotationsString { get; set; }

        [JsonProperty("imagesString")]
        public string ImagesString { get; set; }

        [JsonProperty("fieldsString")]
        public string FieldsString { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("inline", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Inline { get; set; } = true;

        [JsonProperty("expiration", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Expiration { get; set; } = 60;

        [JsonProperty("profiles")]
        public string Profiles { get; set; }

        [JsonProperty("async", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Async { get; set; } = false;
    }

    public class MergePdfSimplifiedResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }
    }

    public class MergePdfBodyInput
    {
        public MergePdfBodyInput(string url)
        {
            this.Url = url;
        }

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Url { get; set; }

        [JsonProperty("expiration", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Expiration { get; set; } = 60;

        [JsonProperty("profiles")]
        public string Profiles { get; set; }

        [JsonProperty("async", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Async { get; set; } = false;
    }

    public class MergePdfResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }
    }

    public class SplitPdfResponse
    {
        [JsonProperty("urls")]
        public string[] Urls { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }
    }

    public class SplitPdfBodyInput
    {
        public SplitPdfBodyInput(string url, string pages)
        {
            this.Url = url;
            this.Pages = pages;
        }

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Url { get; set; }

        [JsonProperty("pages", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Pages { get; set; }

        [JsonProperty("inline", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Inline { get; set; } = true;

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("expiration", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Expiration { get; set; } = 60;

        [JsonProperty("profiles")]
        public string Profiles { get; set; }

        [JsonProperty("async", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Async { get; set; } = false;
    }

    public class SplitPdf2Response
    {
        [JsonProperty("urls")]
        public string[] Urls { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }
    }

    public class SplitPdf2BodyInput
    {
        public SplitPdf2BodyInput(string url, string searchString)
        {
            this.Url = url;
            this.SearchString = searchString;
        }

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Url { get; set; }

        [JsonProperty("searchString", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchString { get; set; }

        [JsonProperty("excludeKeyPages", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ExcludeKeyPages { get; set; } = false;

        [JsonProperty("regexSearch", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RegexSearch { get; set; } = false;

        [JsonProperty("caseSensitive", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CaseSensitive { get; set; } = false;

        [JsonProperty("lang", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Lang { get; set; } = "eng";

        [JsonProperty("inline", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Inline { get; set; } = true;

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("expiration", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Expiration { get; set; } = 60;

        [JsonProperty("profiles")]
        public string Profiles { get; set; }

        [JsonProperty("async", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Async { get; set; } = false;
    }

    public class PDFSerarchTextResponse
    {
        [JsonProperty("body")]
        public PDFSerarchTextResponseBodyTypeItem[] Body { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public class PDFSerarchTextResponseBodyTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("left")]
        public double Left { get; set; }

        [JsonProperty("top")]
        public double Top { get; set; }

        [JsonProperty("width")]
        public double Width { get; set; }

        [JsonProperty("height")]
        public double Height { get; set; }

        [JsonProperty("pageIndex")]
        public int PageIndex { get; set; }
    }

    public class PDFSerarchTextBodyInput
    {
        public PDFSerarchTextBodyInput(string url, string searchString)
        {
            this.Url = url;
            this.SearchString = searchString;
        }

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Url { get; set; }

        [JsonProperty("searchString", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchString { get; set; }

        [JsonProperty("regexSearch", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RegexSearch { get; set; } = false;

        [JsonProperty("pages")]
        public string Pages { get; set; }

        [JsonProperty("inline", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Inline { get; set; } = true;

        [JsonProperty("wordMatchingMode")]
        public BodyInputWordMatchingModeType? WordMatchingMode { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("async", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Async { get; set; } = false;

        [JsonProperty("profiles")]
        public string Profiles { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputWordMatchingModeType
    {
        [EnumMember(Value = "")]
        None,
        SmartMatch,
        ExactMatch,
        [EnumMember(Value = "None")]
        None2
    }

    public class DocumentParserResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("body")]
        public DocumentParserResponseBodyType Body { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class DocumentParserResponseBodyType
    {
        [JsonProperty("objects")]
        public DocumentParserResponseBodyTypeObjectsTypeItem[] Objects { get; set; }
    }

    public class DocumentParserResponseBodyTypeObjectsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("objectType")]
        public string ObjectType { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("pageIndex")]
        public int PageIndex { get; set; }

        [JsonProperty("rectangle")]
        public double[] Rectangle { get; set; }

        [JsonProperty("rows")]
        public JToken[] Rows { get; set; }
    }

    public class DocumentParserBodyInput
    {
        public DocumentParserBodyInput(string url)
        {
            this.Url = url;
        }

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Url { get; set; }

        [JsonProperty("templateId")]
        public string TemplateId { get; set; }

        [JsonProperty("outputFormat", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputOutputFormatType OutputFormat { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdfco.BodyInputOutputFormatType.JSON;

        [JsonProperty("inline")]
        public bool? Inline { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("profiles")]
        public string Profiles { get; set; }

        [JsonProperty("expiration", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Expiration { get; set; } = 60;

        [JsonProperty("async")]
        public bool? Async { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputOutputFormatType
    {
        JSON,
        CSV,
        XML
    }

    public class JobCheckResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("jobDuration")]
        public int JobDuration { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("errorCode")]
        public int ErrorCode { get; set; }
    }

    public class JobCheckBodyInput
    {
        public JobCheckBodyInput(string jobid)
        {
            this.Jobid = jobid;
        }

        [JsonProperty("jobid", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Jobid { get; set; }
    }

    public class BarcodeGeneratorResponse
    {
        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public class BarcodeGeneratorBodyInput
    {
        public BarcodeGeneratorBodyInput(string value)
        {
            this.Value = value;
        }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Value { get; set; }

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputTypeType Type { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdfco.BodyInputTypeType.QRCode;

        [JsonProperty("decorationImage")]
        public string DecorationImage { get; set; }

        [JsonProperty("async", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Async { get; set; } = false;

        [JsonProperty("expiration", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Expiration { get; set; } = 60;

        [JsonProperty("profiles")]
        public string Profiles { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputTypeType
    {
        Code128,
        Code39,
        Postnet,
        UPCA,
        EAN8,
        ISBN,
        Codabar,
        I2of5,
        Code93,
        EAN13,
        JAN13,
        Bookland,
        UPCE,
        PDF417,
        PDF417Truncated,
        DataMatrix,
        QRCode,
        Aztec,
        Planet,
        EAN128,
        [EnumMember(Value = "GS1_128")]
        GS1128,
        USPSSackLabel,
        USPSTrayLabel,
        DeutschePostIdentcode,
        DeutschePostLeitcode,
        Numly,
        PZN,
        OpticalProduct,
        SwissPostParcel,
        RoyalMail,
        DutchKix,
        SingaporePostalCode,
        EAN2,
        EAN5,
        EAN14,
        MacroPDF417,
        MicroPDF417,
        [EnumMember(Value = "GS1_DataMatrix")]
        GS1DataMatrix,
        Telepen,
        IntelligentMail,
        [EnumMember(Value = "GS1_DataBar_Omnidirectional")]
        GS1DataBarOmnidirectional,
        [EnumMember(Value = "GS1_DataBar_Truncated")]
        GS1DataBarTruncated,
        [EnumMember(Value = "GS1_DataBar_Stacked")]
        GS1DataBarStacked,
        [EnumMember(Value = "GS1_DataBar_Stacked_Omnidirectional")]
        GS1DataBarStackedOmnidirectional,
        [EnumMember(Value = "GS1_DataBar_Limited")]
        GS1DataBarLimited,
        [EnumMember(Value = "GS1_DataBar_Expanded")]
        GS1DataBarExpanded,
        [EnumMember(Value = "GS1_DataBar_Expanded_Stacked")]
        GS1DataBarExpandedStacked,
        MaxiCode,
        Plessey,
        MSI,
        ITF14,
        GTIN12,
        GTIN8,
        GTIN13,
        GTIN14,
        [EnumMember(Value = "GS1_QRCode")]
        GS1QRCode,
        PharmaCode
    }

    public class BarcodeReaderResponse
    {
        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("barcodes")]
        public BarcodeReaderResponseBarcodesTypeItem[] Barcodes { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public class BarcodeReaderResponseBarcodesTypeItem
    {
        public string Value { get; set; }
        public int Type { get; set; }
        public string Rect { get; set; }
        public int Page { get; set; }
        public string File { get; set; }
        public double Confidence { get; set; }
        public string Metadata { get; set; }
        public string TypeName { get; set; }
    }

    public class BarcodeReaderBodyInput
    {
        public BarcodeReaderBodyInput(string url)
        {
            this.Url = url;
        }

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Url { get; set; }

        [JsonProperty("types", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Types { get; set; } = "QRCode";

        [JsonProperty("pages")]
        public string Pages { get; set; }

        [JsonProperty("profiles")]
        public string Profiles { get; set; }

        [JsonProperty("async", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Async { get; set; } = false;
    }

    public class PDFInfoReaderResponse
    {
        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("info")]
        public PDFInfoReaderResponseInfoType Info { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public class PDFInfoReaderResponseInfoType
    {
        public int PageCount { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Producer { get; set; }
        public string Subject { get; set; }
        public string CreationDate { get; set; }
        public string Bookmarks { get; set; }
        public string Keywords { get; set; }
        public string Creator { get; set; }
        public bool Encrypted { get; set; }
        public bool PasswordProtected { get; set; }
        public PDFInfoReaderResponseInfoTypePageRectangleType PageRectangle { get; set; }
        public string ModificationDate { get; set; }
        public int AttachmentCount { get; set; }
        public string EncryptionAlgorithm { get; set; }
        public bool PermissionPrinting { get; set; }
        public bool PermissionModifyDocument { get; set; }
        public bool PermissionContentExtraction { get; set; }
        public bool PermissionModifyAnnotations { get; set; }
        public bool PermissionFillForms { get; set; }
        public bool PermissionAccessibility { get; set; }
        public bool PermissionAssemble { get; set; }
        public bool PermissionHighQualityPrint { get; set; }
    }

    public class PDFInfoReaderResponseInfoTypePageRectangleType
    {
        public PDFInfoReaderResponseInfoTypePageRectangleTypeLocationType Location { get; set; }
        public string Size { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double Left { get; set; }
        public double Top { get; set; }
        public double Right { get; set; }
        public double Bottom { get; set; }
        public bool IsEmpty { get; set; }
    }

    public class PDFInfoReaderResponseInfoTypePageRectangleTypeLocationType
    {
        public bool IsEmpty { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
    }

    public class PDFInfoReaderBodyInput
    {
        public PDFInfoReaderBodyInput(string url)
        {
            this.Url = url;
        }

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Url { get; set; }

        [JsonProperty("async")]
        public bool? Async { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("profiles")]
        public string Profiles { get; set; }
    }

    public class PDFFormsInfoReaderResponse
    {
        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("info")]
        public PDFFormsInfoReaderResponseInfoType Info { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public class PDFFormsInfoReaderResponseInfoType
    {
        public int PageCount { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Producer { get; set; }
        public string Subject { get; set; }
        public string CreationDate { get; set; }
        public string Bookmarks { get; set; }
        public string Keywords { get; set; }
        public string Creator { get; set; }
        public bool Encrypted { get; set; }
        public bool PasswordProtected { get; set; }
        public PDFFormsInfoReaderResponseInfoTypePageRectangleType PageRectangle { get; set; }
        public string ModificationDate { get; set; }
        public int AttachmentCount { get; set; }
        public string EncryptionAlgorithm { get; set; }
        public bool PermissionPrinting { get; set; }
        public bool PermissionModifyDocument { get; set; }
        public bool PermissionContentExtraction { get; set; }
        public bool PermissionModifyAnnotations { get; set; }
        public bool PermissionFillForms { get; set; }
        public bool PermissionAccessibility { get; set; }
        public bool PermissionAssemble { get; set; }
        public bool PermissionHighQualityPrint { get; set; }
        public PDFFormsInfoReaderResponseInfoTypeCustomPropertiesTypeItem[] CustomProperties { get; set; }
        public PDFFormsInfoReaderResponseInfoTypeFieldsInfoType FieldsInfo { get; set; }
    }

    public class PDFFormsInfoReaderResponseInfoTypePageRectangleType
    {
        public PDFFormsInfoReaderResponseInfoTypePageRectangleTypeLocationType Location { get; set; }
        public string Size { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double Left { get; set; }
        public double Top { get; set; }
        public double Right { get; set; }
        public double Bottom { get; set; }
        public bool IsEmpty { get; set; }
    }

    public class PDFFormsInfoReaderResponseInfoTypePageRectangleTypeLocationType
    {
        public bool IsEmpty { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
    }

    public class PDFFormsInfoReaderResponseInfoTypeCustomPropertiesTypeItem
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }

    public class PDFFormsInfoReaderResponseInfoTypeFieldsInfoType
    {
        public PDFFormsInfoReaderResponseInfoTypeFieldsInfoTypeFieldsTypeItem[] Fields { get; set; }
    }

    public class PDFFormsInfoReaderResponseInfoTypeFieldsInfoTypeFieldsTypeItem
    {
        public int PageIndex { get; set; }
        public string Type { get; set; }
        public string FieldName { get; set; }
        public string AltFieldName { get; set; }
        public string Value { get; set; }
        public double Left { get; set; }
        public double Top { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
    }

    public class PDFFormsInfoReaderBodyInput
    {
        public PDFFormsInfoReaderBodyInput(string url)
        {
            this.Url = url;
        }

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Url { get; set; }

        [JsonProperty("async", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Async { get; set; } = false;

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("profiles")]
        public string Profiles { get; set; }
    }

    public class PDFFindTableResponse
    {
        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("body")]
        public PDFFindTableResponseBodyType Body { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public class PDFFindTableResponseBodyType
    {
        [JsonProperty("tables")]
        public PDFFindTableResponseBodyTypeTablesTypeItem[] Tables { get; set; }
    }

    public class PDFFindTableResponseBodyTypeTablesTypeItem
    {
        public int PageIndex { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double[] Columns { get; set; }

        [JsonProperty("rect")]
        public string Rect { get; set; }
    }

    public class PDFFindTableBodyInput
    {
        public PDFFindTableBodyInput(string url)
        {
            this.Url = url;
        }

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Url { get; set; }

        [JsonProperty("pages")]
        public string Pages { get; set; }

        [JsonProperty("inline", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Inline { get; set; } = true;

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("profiles")]
        public string Profiles { get; set; }

        [JsonProperty("expiration", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Expiration { get; set; } = 60;

        [JsonProperty("async", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Async { get; set; } = false;
    }

    public class SearchAndReplaceResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public class SearchAndReplaceBodyInput
    {
        public SearchAndReplaceBodyInput(string url, string[] searchStrings)
        {
            this.Url = url;
            this.SearchStrings = searchStrings;
        }

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Url { get; set; }

        [JsonProperty("searchStrings", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] SearchStrings { get; set; }

        [JsonProperty("replaceStrings")]
        public string[] ReplaceStrings { get; set; }

        [JsonProperty("caseSensitive")]
        public bool? CaseSensitive { get; set; }

        [JsonProperty("replacementLimit")]
        public int? ReplacementLimit { get; set; }

        [JsonProperty("regex")]
        public bool? Regex { get; set; }

        [JsonProperty("pages")]
        public string Pages { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("expiration", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Expiration { get; set; } = 60;

        [JsonProperty("async", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Async { get; set; } = false;
    }

    public class SearchAndReplaceWithImageResponse
    {
        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public class SearchAndReplaceWithImageBodyInput
    {
        public SearchAndReplaceWithImageBodyInput(string url, string searchString, string replaceImage)
        {
            this.Url = url;
            this.SearchString = searchString;
            this.ReplaceImage = replaceImage;
        }

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Url { get; set; }

        [JsonProperty("caseSensitive", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CaseSensitive { get; set; } = false;

        [JsonProperty("searchString", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchString { get; set; }

        [JsonProperty("replaceImage", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ReplaceImage { get; set; }

        [JsonProperty("pages")]
        public string Pages { get; set; }

        [JsonProperty("async", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Async { get; set; } = false;

        [JsonProperty("regex", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Regex { get; set; } = false;

        [JsonProperty("replacementLimit", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? ReplacementLimit { get; set; } = 0;

        [JsonProperty("expiration", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Expiration { get; set; } = 60;

        [JsonProperty("password")]
        public string Password { get; set; }
    }

    public class SearchAndDeleteTextResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public class SearchAndDeleteTextBodyInput
    {
        public SearchAndDeleteTextBodyInput(string url, string[] searchStrings)
        {
            this.Url = url;
            this.SearchStrings = searchStrings;
        }

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Url { get; set; }

        [JsonProperty("searchStrings", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] SearchStrings { get; set; }

        [JsonProperty("caseSensitive", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CaseSensitive { get; set; } = false;

        [JsonProperty("regex")]
        public bool? Regex { get; set; }

        [JsonProperty("replacementLimit", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? ReplacementLimit { get; set; } = 0;

        [JsonProperty("expiration", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Expiration { get; set; } = 60;

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("pages")]
        public string Pages { get; set; }

        [JsonProperty("profiles")]
        public string Profiles { get; set; }

        [JsonProperty("async", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Async { get; set; } = false;
    }

    public class PDFSearchableResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public class PDFSearchableBodyInput
    {
        public PDFSearchableBodyInput(string url)
        {
            this.Url = url;
        }

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Url { get; set; }

        [JsonProperty("lang", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Lang { get; set; } = "eng";

        [JsonProperty("pages")]
        public string Pages { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("async")]
        public bool? Async { get; set; }

        [JsonProperty("profiles")]
        public string Profiles { get; set; }
    }

    public class PDFUnSearchableResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public class PDFUnSearchableBodyInput
    {
        public PDFUnSearchableBodyInput(string url)
        {
            this.Url = url;
        }

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Url { get; set; }

        [JsonProperty("pages")]
        public string Pages { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("async")]
        public bool? Async { get; set; }

        [JsonProperty("profiles")]
        public string Profiles { get; set; }
    }

    public class PDFToCSVResponse
    {
        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public class PDFToCSVBodyInput
    {
        public PDFToCSVBodyInput(string url)
        {
            this.Url = url;
        }

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Url { get; set; }

        [JsonProperty("lang")]
        public string Lang { get; set; }

        [JsonProperty("inline", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Inline { get; set; } = true;

        [JsonProperty("unwrap")]
        public BodyInputUnwrapType? Unwrap { get; set; }

        [JsonProperty("pages")]
        public string Pages { get; set; }

        [JsonProperty("rect")]
        public string Rect { get; set; }

        [JsonProperty("async", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Async { get; set; } = false;

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("lineGrouping")]
        public string LineGrouping { get; set; }

        [JsonProperty("expiration", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Expiration { get; set; } = 60;

        [JsonProperty("profiles")]
        public string Profiles { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputUnwrapType
    {
        [EnumMember(Value = "")]
        None,
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False
    }

    public class PDFToJSONResponse
    {
        [JsonProperty("body")]
        public JToken Body { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public class PDFToJSONMetaResponse
    {
        [JsonProperty("body")]
        public JToken Body { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public class PDFToTextResponse
    {
        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public class PDFToTextSimpleResponse
    {
        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public class PDFToTextSimpleBodyInput
    {
        public PDFToTextSimpleBodyInput(string url)
        {
            this.Url = url;
        }

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Url { get; set; }

        [JsonProperty("inline", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Inline { get; set; } = true;

        [JsonProperty("pages")]
        public string Pages { get; set; }

        [JsonProperty("async", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Async { get; set; } = false;

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("expiration", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Expiration { get; set; } = 60;
    }

    public class PDFToXLSResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public class PDFToXLSBodyInput
    {
        public PDFToXLSBodyInput(string url)
        {
            this.Url = url;
        }

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Url { get; set; }

        [JsonProperty("lang")]
        public string Lang { get; set; }

        [JsonProperty("unwrap")]
        public BodyInputUnwrapType? Unwrap { get; set; }

        [JsonProperty("pages")]
        public string Pages { get; set; }

        [JsonProperty("rect")]
        public string Rect { get; set; }

        [JsonProperty("async", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Async { get; set; } = false;

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("lineGrouping")]
        public string LineGrouping { get; set; }

        [JsonProperty("expiration", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Expiration { get; set; } = 60;

        [JsonProperty("profiles")]
        public string Profiles { get; set; }
    }

    public class PDFToXLSXResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public class PDFToXMLResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public class PDFToJPGResponse
    {
        [JsonProperty("urls")]
        public string[] Urls { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public class PDFToJPGBodyInput
    {
        public PDFToJPGBodyInput(string url)
        {
            this.Url = url;
        }

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Url { get; set; }

        [JsonProperty("inline")]
        public bool? Inline { get; set; }

        [JsonProperty("pages")]
        public string Pages { get; set; }

        [JsonProperty("rect")]
        public string Rect { get; set; }

        [JsonProperty("expiration", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Expiration { get; set; } = 60;

        [JsonProperty("async")]
        public bool? Async { get; set; }

        [JsonProperty("profiles")]
        public string Profiles { get; set; }
    }

    public class PDFToPNGResponse
    {
        [JsonProperty("urls")]
        public string[] Urls { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public class PDFToWEBPResponse
    {
        [JsonProperty("urls")]
        public string[] Urls { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public class PDFToTIFFResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public class PDFFromCSVResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public class PDFFromCSVBodyInput
    {
        public PDFFromCSVBodyInput(string url)
        {
            this.Url = url;
        }

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Url { get; set; }

        [JsonProperty("pages")]
        public string Pages { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("expiration", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Expiration { get; set; } = 60;

        [JsonProperty("async")]
        public bool? Async { get; set; }

        [JsonProperty("profiles")]
        public string Profiles { get; set; }
    }

    public class PDFFromDocResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public class PDFFromImagesResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public class PDFFromImagesBodyInput
    {
        public PDFFromImagesBodyInput(string url)
        {
            this.Url = url;
        }

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Url { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("expiration", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Expiration { get; set; } = 60;

        [JsonProperty("async")]
        public bool? Async { get; set; }

        [JsonProperty("profiles")]
        public string Profiles { get; set; }
    }

    public class PDFFromEmailResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public class PDFFromEmailBodyInput
    {
        public PDFFromEmailBodyInput(string url)
        {
            this.Url = url;
        }

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Url { get; set; }

        [JsonProperty("embedAttachments")]
        public bool? EmbedAttachments { get; set; }

        [JsonProperty("convertAttachments")]
        public bool? ConvertAttachments { get; set; }

        [JsonProperty("margins")]
        public string Margins { get; set; }

        [JsonProperty("paperSize")]
        public string PaperSize { get; set; }

        [JsonProperty("orientation")]
        public PDFFromEmailBodyInputOrientationType? Orientation { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("expiration", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Expiration { get; set; } = 60;

        [JsonProperty("async")]
        public bool? Async { get; set; }

        [JsonProperty("profiles")]
        public string Profiles { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PDFFromEmailBodyInputOrientationType
    {
        [EnumMember(Value = "")]
        None,
        Portait,
        Landscape
    }

    public class PDFAddSecurityResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public class PDFAddSecurityBodyInput
    {
        public PDFAddSecurityBodyInput(string url, string ownerPassword)
        {
            this.Url = url;
            this.OwnerPassword = ownerPassword;
        }

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Url { get; set; }

        [JsonProperty("ownerPassword", DefaultValueHandling = DefaultValueHandling.Include)]
        public string OwnerPassword { get; set; }

        [JsonProperty("userPassword")]
        public string UserPassword { get; set; }

        [JsonProperty("encryptionAlgorithm")]
        public BodyInputEncryptionAlgorithmType? EncryptionAlgorithm { get; set; }

        [JsonProperty("allowAccessibilitySupport")]
        public bool? AllowAccessibilitySupport { get; set; }

        [JsonProperty("allowAssemblyDocument")]
        public bool? AllowAssemblyDocument { get; set; }

        [JsonProperty("allowPrintDocument")]
        public bool? AllowPrintDocument { get; set; }

        [JsonProperty("allowFillForms")]
        public bool? AllowFillForms { get; set; }

        [JsonProperty("allowModifyDocument")]
        public bool? AllowModifyDocument { get; set; }

        [JsonProperty("allowContentExtraction")]
        public bool? AllowContentExtraction { get; set; }

        [JsonProperty("allowModifyAnnotations")]
        public bool? AllowModifyAnnotations { get; set; }

        [JsonProperty("printQuality")]
        public BodyInputPrintQualityType? PrintQuality { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("expiration", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Expiration { get; set; } = 60;

        [JsonProperty("async")]
        public bool? Async { get; set; }

        [JsonProperty("profiles")]
        public string Profiles { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputEncryptionAlgorithmType
    {
        [EnumMember(Value = "")]
        None,
        [EnumMember(Value = "RC4_40bit")]
        RC440bit,
        [EnumMember(Value = "RC4_128bit")]
        RC4128bit,
        [EnumMember(Value = "AES_128bit")]
        AES128bit,
        [EnumMember(Value = "AES_256bit")]
        AES256bit
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputPrintQualityType
    {
        [EnumMember(Value = "")]
        None,
        HighResolution,
        LowResolution
    }

    public class PDFSecurityRemoveResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public class PDFSecurityRemoveBodyInput
    {
        public PDFSecurityRemoveBodyInput(string url, string password)
        {
            this.Url = url;
            this.Password = password;
        }

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Url { get; set; }

        [JsonProperty("password", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Password { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("expiration", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Expiration { get; set; } = 60;

        [JsonProperty("async")]
        public bool? Async { get; set; }

        [JsonProperty("profiles")]
        public string Profiles { get; set; }
    }

    public class PDFFromXLSXLSXResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public class PDFFromXLSXLSXBodyInput
    {
        public PDFFromXLSXLSXBodyInput(string url)
        {
            this.Url = url;
        }

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Url { get; set; }

        [JsonProperty("worksheetIndex", DefaultValueHandling = DefaultValueHandling.Include)]
        public string WorksheetIndex { get; set; } = "0";

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("expiration", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Expiration { get; set; } = 60;

        [JsonProperty("async")]
        public bool? Async { get; set; }

        [JsonProperty("profiles")]
        public string Profiles { get; set; }
    }

    public class XLStoCSVResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public class XLStoCSVBodyInput
    {
        public XLStoCSVBodyInput(string url)
        {
            this.Url = url;
        }

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Url { get; set; }

        [JsonProperty("worksheetIndex", DefaultValueHandling = DefaultValueHandling.Include)]
        public string WorksheetIndex { get; set; } = "0";

        [JsonProperty("quotationSymbol")]
        public string QuotationSymbol { get; set; }

        [JsonProperty("separatorSymbol")]
        public string SeparatorSymbol { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("expiration", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Expiration { get; set; } = 60;

        [JsonProperty("async")]
        public bool? Async { get; set; }

        [JsonProperty("profiles")]
        public string Profiles { get; set; }
    }

    public class XLStoJSONResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public class XLStoHTMLResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public class XLStoTXTResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public class XLStoXMLResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public class PDFRotatePagesResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public class PDFRotatePagesBodyInput
    {
        public PDFRotatePagesBodyInput(string url)
        {
            this.Url = url;
        }

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Url { get; set; }

        [JsonProperty("angle")]
        public BodyInputAngleType? Angle { get; set; }

        [JsonProperty("pages")]
        public string Pages { get; set; }

        [JsonProperty("expiration", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Expiration { get; set; } = 60;

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("profiles")]
        public string Profiles { get; set; }

        [JsonProperty("async", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Async { get; set; } = false;
    }

    public enum BodyInputAngleType
    {
        _90 = 90,
        _180 = 180,
        _270 = 270
    }

    public class PDFAutoRotatePagesResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public class PDFAutoRotatePagesBodyInput
    {
        public PDFAutoRotatePagesBodyInput(string url)
        {
            this.Url = url;
        }

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Url { get; set; }

        [JsonProperty("lang", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Lang { get; set; } = "eng";

        [JsonProperty("expiration", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Expiration { get; set; } = 60;

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("profiles")]
        public string Profiles { get; set; }

        [JsonProperty("async", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Async { get; set; } = false;
    }

    public class PDFDeletePagesResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public class PDFDeletePagesBodyInput
    {
        public PDFDeletePagesBodyInput(string url)
        {
            this.Url = url;
        }

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Url { get; set; }

        [JsonProperty("pages")]
        public string Pages { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("expiration", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Expiration { get; set; } = 60;

        [JsonProperty("profiles")]
        public string Profiles { get; set; }

        [JsonProperty("async", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Async { get; set; } = false;
    }

    public class PDFCompressResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public class PDFCompressBodyInput
    {
        public PDFCompressBodyInput(string url)
        {
            this.Url = url;
        }

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Url { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("expiration", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Expiration { get; set; } = 60;

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("profiles")]
        public string Profiles { get; set; }

        [JsonProperty("async", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Async { get; set; } = false;
    }

    public class PDFClassifierResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("body")]
        public PDFClassifierResponseBodyType Body { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public class PDFClassifierResponseBodyType
    {
        [JsonProperty("classes")]
        public PDFClassifierResponseBodyTypeClassesTypeItem[] Classes { get; set; }
    }

    public class PDFClassifierResponseBodyTypeClassesTypeItem
    {
        [JsonProperty("class")]
        public string Class { get; set; }
    }

    public class PDFClassifierBodyInput
    {
        public PDFClassifierBodyInput(string url)
        {
            this.Url = url;
        }

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Url { get; set; }

        [JsonProperty("rulescsv")]
        public string Rulescsv { get; set; }

        [JsonProperty("rulescsvurl")]
        public string Rulescsvurl { get; set; }

        [JsonProperty("caseSensitive", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CaseSensitive { get; set; } = true;

        [JsonProperty("inline", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Inline { get; set; } = true;

        [JsonProperty("expiration", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Expiration { get; set; } = 60;

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("profiles")]
        public string Profiles { get; set; }

        [JsonProperty("async", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Async { get; set; } = false;
    }

    public class EmailSendResponse
    {
        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public class EmailSendBodyInput
    {
        public EmailSendBodyInput(string url, string from, string to, string subject, string smtpserver, string smtpport, string smtpusername, string smtppassword)
        {
            this.Url = url;
            this.From = from;
            this.To = to;
            this.Subject = subject;
            this.Smtpserver = smtpserver;
            this.Smtpport = smtpport;
            this.Smtpusername = smtpusername;
            this.Smtppassword = smtppassword;
        }

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Url { get; set; }

        [JsonProperty("from", DefaultValueHandling = DefaultValueHandling.Include)]
        public string From { get; set; }

        [JsonProperty("to", DefaultValueHandling = DefaultValueHandling.Include)]
        public string To { get; set; }

        [JsonProperty("subject", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Subject { get; set; }

        [JsonProperty("bodytext")]
        public string Bodytext { get; set; }

        [JsonProperty("bodyhtml")]
        public string Bodyhtml { get; set; }

        [JsonProperty("smtpserver", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Smtpserver { get; set; }

        [JsonProperty("smtpport", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Smtpport { get; set; }

        [JsonProperty("smtpusername", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Smtpusername { get; set; }

        [JsonProperty("smtppassword", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Smtppassword { get; set; }

        [JsonProperty("profiles")]
        public string Profiles { get; set; }

        [JsonProperty("async", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Async { get; set; } = false;
    }

    public class EmailDecodeResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("body")]
        public EmailDecodeResponseBodyType Body { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public class EmailDecodeResponseBodyType
    {
        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("fromName")]
        public string FromName { get; set; }

        [JsonProperty("to")]
        public EmailDecodeResponseBodyTypeToTypeItem[] To { get; set; }

        [JsonProperty("cc")]
        public EmailDecodeResponseBodyTypeCcTypeItem[] Cc { get; set; }

        [JsonProperty("bcc")]
        public EmailDecodeResponseBodyTypeBccTypeItem[] Bcc { get; set; }

        [JsonProperty("sentAt")]
        public string SentAt { get; set; }

        [JsonProperty("receivedAt")]
        public string ReceivedAt { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("bodyHtml")]
        public string BodyHtml { get; set; }

        [JsonProperty("bodyText")]
        public string BodyText { get; set; }

        [JsonProperty("attachmentCount")]
        public int AttachmentCount { get; set; }
    }

    public class EmailDecodeResponseBodyTypeToTypeItem
    {
        [JsonProperty("address")]
        public string Address { get; set; }
        public string Name { get; set; }
    }

    public class EmailDecodeResponseBodyTypeCcTypeItem
    {
        [JsonProperty("address")]
        public string Address { get; set; }
        public string Name { get; set; }
    }

    public class EmailDecodeResponseBodyTypeBccTypeItem
    {
        [JsonProperty("address")]
        public string Address { get; set; }
        public string Name { get; set; }
    }

    public class EmailAttachmentExtractionBodyInput
    {
        public EmailAttachmentExtractionBodyInput(string url)
        {
            this.Url = url;
        }

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Url { get; set; }

        [JsonProperty("profiles")]
        public string Profiles { get; set; }

        [JsonProperty("async", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Async { get; set; } = false;
    }

    public class EmailAttachmentExtractionResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("body")]
        public EmailAttachmentExtractionResponseBodyType Body { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }
    }

    public class EmailAttachmentExtractionResponseBodyType
    {
        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("bodyHtml")]
        public string BodyHtml { get; set; }

        [JsonProperty("bodyText")]
        public string BodyText { get; set; }

        [JsonProperty("attachments")]
        public EmailAttachmentExtractionResponseBodyTypeAttachmentsTypeItem[] Attachments { get; set; }
    }

    public class EmailAttachmentExtractionResponseBodyTypeAttachmentsTypeItem
    {
        [JsonProperty("filename")]
        public string Filename { get; set; }

        [JsonProperty("contentid")]
        public string Contentid { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("filesizeinbytes")]
        public int Filesizeinbytes { get; set; }
    }

    public class PDFAttachmentExtractionResponse
    {
        [JsonProperty("urls")]
        public string[] Urls { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("remainingCredits")]
        public int RemainingCredits { get; set; }
    }

    public class PDFAttachmentExtractionBodyInput
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Url { get; set; } = "";

        [JsonProperty("inline", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Inline { get; set; } = true;

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("expiration", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Expiration { get; set; } = 60;

        [JsonProperty("profiles")]
        public string Profiles { get; set; }

        [JsonProperty("async", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Async { get; set; } = false;
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Pdfco;

    public partial class WorkflowManagedActions
    {
        public PdfcoActions Pdfco(string connectionId) => new PdfcoActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PdfcoTriggers Pdfco(string connectionId) => new PdfcoTriggers(connectionId);
    }
}