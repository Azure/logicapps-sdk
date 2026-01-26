//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pdfco
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PdfcoActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<HtmlToPdfResponse> HtmlToPdf(Expression<Func<string>> bodyhtml, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodymargins = null, Expression<Func<bodypaperSizeInput>> bodypaperSize = null, Expression<Func<bodyorientationInput>> bodyorientation = null, Expression<Func<bool>> bodyprintBackground = null, Expression<Func<string>> bodyheader = null, Expression<Func<string>> bodyfooter = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<string>> bodyprofiles = null, Expression<Func<bool>> bodyasync = null)
        {
            var apiCallPath = "/v1/pdf/convert/from/html";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["html"] = ExpressionConverter.ConvertO(bodyhtml);
            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodymargins != null)
            {
                body["margins"] = ExpressionConverter.ConvertO(bodymargins);
                bodypropCount++;
            }

            if (bodypaperSize != null)
            {
                body["paperSize"] = ExpressionConverter.ConvertO(bodypaperSize);
                bodypropCount++;
            }

            if (bodyorientation != null)
            {
                body["orientation"] = ExpressionConverter.ConvertO(bodyorientation);
                bodypropCount++;
            }

            if (bodyprintBackground != null)
            {
                body["printBackground"] = ExpressionConverter.ConvertO(bodyprintBackground);
                bodypropCount++;
            }

            if (bodyheader != null)
            {
                body["header"] = ExpressionConverter.ConvertO(bodyheader);
                bodypropCount++;
            }

            if (bodyfooter != null)
            {
                body["footer"] = ExpressionConverter.ConvertO(bodyfooter);
                bodypropCount++;
            }

            if (bodyexpiration != null)
            {
                body["expiration"] = ExpressionConverter.ConvertO(bodyexpiration);
                bodypropCount++;
            }

            if (bodyprofiles != null)
            {
                body["profiles"] = ExpressionConverter.ConvertO(bodyprofiles);
                bodypropCount++;
            }

            if (bodyasync != null)
            {
                body["async"] = ExpressionConverter.ConvertO(bodyasync);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<HtmlToPdfResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<UrlToPdfResponse> UrlToPdf(Expression<Func<string>> bodyurl, Expression<Func<string>> bodymargins = null, Expression<Func<string>> bodypaperSize = null, Expression<Func<bodyorientationInput>> bodyorientation = null, Expression<Func<bool>> bodyprintBackground = null, Expression<Func<string>> bodyheader = null, Expression<Func<string>> bodyfooter = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<string>> bodyprofiles = null, Expression<Func<bool>> bodyasync = null)
        {
            var apiCallPath = "/v1/pdf/convert/from/url";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["url"] = ExpressionConverter.ConvertO(bodyurl);
            if (bodymargins != null)
            {
                body["margins"] = ExpressionConverter.ConvertO(bodymargins);
                bodypropCount++;
            }

            if (bodypaperSize != null)
            {
                body["paperSize"] = ExpressionConverter.ConvertO(bodypaperSize);
                bodypropCount++;
            }

            if (bodyorientation != null)
            {
                body["orientation"] = ExpressionConverter.ConvertO(bodyorientation);
                bodypropCount++;
            }

            if (bodyprintBackground != null)
            {
                body["printBackground"] = ExpressionConverter.ConvertO(bodyprintBackground);
                bodypropCount++;
            }

            if (bodyheader != null)
            {
                body["header"] = ExpressionConverter.ConvertO(bodyheader);
                bodypropCount++;
            }

            if (bodyfooter != null)
            {
                body["footer"] = ExpressionConverter.ConvertO(bodyfooter);
                bodypropCount++;
            }

            if (bodyexpiration != null)
            {
                body["expiration"] = ExpressionConverter.ConvertO(bodyexpiration);
                bodypropCount++;
            }

            if (bodyprofiles != null)
            {
                body["profiles"] = ExpressionConverter.ConvertO(bodyprofiles);
                bodypropCount++;
            }

            if (bodyasync != null)
            {
                body["async"] = ExpressionConverter.ConvertO(bodyasync);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UrlToPdfResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PdfFillerResponse> PdfFiller(Expression<Func<string>> bodyurl, Expression<Func<string>> bodyannotationsString = null, Expression<Func<string>> bodyimagesString = null, Expression<Func<string>> bodyfieldsString = null, Expression<Func<string>> bodyname = null, Expression<Func<bool>> bodyinline = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<string>> bodyprofiles = null, Expression<Func<bool>> bodyasync = null)
        {
            var apiCallPath = "/v1/pdf/edit/add";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["url"] = ExpressionConverter.ConvertO(bodyurl);
            if (bodyannotationsString != null)
            {
                body["annotationsString"] = ExpressionConverter.ConvertO(bodyannotationsString);
                bodypropCount++;
            }

            if (bodyimagesString != null)
            {
                body["imagesString"] = ExpressionConverter.ConvertO(bodyimagesString);
                bodypropCount++;
            }

            if (bodyfieldsString != null)
            {
                body["fieldsString"] = ExpressionConverter.ConvertO(bodyfieldsString);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodyinline != null)
            {
                body["inline"] = ExpressionConverter.ConvertO(bodyinline);
                bodypropCount++;
            }

            if (bodyexpiration != null)
            {
                body["expiration"] = ExpressionConverter.ConvertO(bodyexpiration);
                bodypropCount++;
            }

            if (bodyprofiles != null)
            {
                body["profiles"] = ExpressionConverter.ConvertO(bodyprofiles);
                bodypropCount++;
            }

            if (bodyasync != null)
            {
                body["async"] = ExpressionConverter.ConvertO(bodyasync);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PdfFillerResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<MergePdfSimplifiedResponse> MergePdfSimplified(Expression<Func<string>> bodyurl, Expression<Func<int>> bodyexpiration = null, Expression<Func<string>> bodyprofiles = null, Expression<Func<bool>> bodyasync = null)
        {
            var apiCallPath = "/v1/pdf/merge";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["url"] = ExpressionConverter.ConvertO(bodyurl);
            if (bodyexpiration != null)
            {
                body["expiration"] = ExpressionConverter.ConvertO(bodyexpiration);
                bodypropCount++;
            }

            if (bodyprofiles != null)
            {
                body["profiles"] = ExpressionConverter.ConvertO(bodyprofiles);
                bodypropCount++;
            }

            if (bodyasync != null)
            {
                body["async"] = ExpressionConverter.ConvertO(bodyasync);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<MergePdfSimplifiedResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<MergePdfResponse> MergePdf(Expression<Func<string>> bodyurl, Expression<Func<int>> bodyexpiration = null, Expression<Func<string>> bodyprofiles = null, Expression<Func<bool>> bodyasync = null)
        {
            var apiCallPath = "/v1/pdf/merge2";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["url"] = ExpressionConverter.ConvertO(bodyurl);
            if (bodyexpiration != null)
            {
                body["expiration"] = ExpressionConverter.ConvertO(bodyexpiration);
                bodypropCount++;
            }

            if (bodyprofiles != null)
            {
                body["profiles"] = ExpressionConverter.ConvertO(bodyprofiles);
                bodypropCount++;
            }

            if (bodyasync != null)
            {
                body["async"] = ExpressionConverter.ConvertO(bodyasync);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<MergePdfResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<SplitPdfResponse> SplitPdf(Expression<Func<string>> bodyurl, Expression<Func<string>> bodypages, Expression<Func<bool>> bodyinline = null, Expression<Func<string>> bodyname = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<string>> bodyprofiles = null, Expression<Func<bool>> bodyasync = null)
        {
            var apiCallPath = "/v1/pdf/split";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["url"] = ExpressionConverter.ConvertO(bodyurl);
            bodypropCount++;
            body["pages"] = ExpressionConverter.ConvertO(bodypages);
            if (bodyinline != null)
            {
                body["inline"] = ExpressionConverter.ConvertO(bodyinline);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodyexpiration != null)
            {
                body["expiration"] = ExpressionConverter.ConvertO(bodyexpiration);
                bodypropCount++;
            }

            if (bodyprofiles != null)
            {
                body["profiles"] = ExpressionConverter.ConvertO(bodyprofiles);
                bodypropCount++;
            }

            if (bodyasync != null)
            {
                body["async"] = ExpressionConverter.ConvertO(bodyasync);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SplitPdfResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<SplitPdf2Response> SplitPdf2(Expression<Func<string>> bodyurl, Expression<Func<string>> bodysearchString, Expression<Func<bool>> bodyexcludeKeyPages = null, Expression<Func<bool>> bodyregexSearch = null, Expression<Func<bool>> bodycaseSensitive = null, Expression<Func<string>> bodylang = null, Expression<Func<bool>> bodyinline = null, Expression<Func<string>> bodyname = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<string>> bodyprofiles = null, Expression<Func<bool>> bodyasync = null)
        {
            var apiCallPath = "/v1/pdf/split2";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["url"] = ExpressionConverter.ConvertO(bodyurl);
            bodypropCount++;
            body["searchString"] = ExpressionConverter.ConvertO(bodysearchString);
            if (bodyexcludeKeyPages != null)
            {
                body["excludeKeyPages"] = ExpressionConverter.ConvertO(bodyexcludeKeyPages);
                bodypropCount++;
            }

            if (bodyregexSearch != null)
            {
                body["regexSearch"] = ExpressionConverter.ConvertO(bodyregexSearch);
                bodypropCount++;
            }

            if (bodycaseSensitive != null)
            {
                body["caseSensitive"] = ExpressionConverter.ConvertO(bodycaseSensitive);
                bodypropCount++;
            }

            if (bodylang != null)
            {
                body["lang"] = ExpressionConverter.ConvertO(bodylang);
                bodypropCount++;
            }

            if (bodyinline != null)
            {
                body["inline"] = ExpressionConverter.ConvertO(bodyinline);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodyexpiration != null)
            {
                body["expiration"] = ExpressionConverter.ConvertO(bodyexpiration);
                bodypropCount++;
            }

            if (bodyprofiles != null)
            {
                body["profiles"] = ExpressionConverter.ConvertO(bodyprofiles);
                bodypropCount++;
            }

            if (bodyasync != null)
            {
                body["async"] = ExpressionConverter.ConvertO(bodyasync);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SplitPdf2Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFSerarchTextResponse> PDFSerarchText(Expression<Func<string>> bodyurl, Expression<Func<string>> bodysearchString, Expression<Func<bool>> bodyregexSearch = null, Expression<Func<string>> bodypages = null, Expression<Func<bool>> bodyinline = null, Expression<Func<bodywordMatchingModeInput>> bodywordMatchingMode = null, Expression<Func<string>> bodypassword = null, Expression<Func<bool>> bodyasync = null, Expression<Func<string>> bodyprofiles = null)
        {
            var apiCallPath = "/v1/pdf/find";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["url"] = ExpressionConverter.ConvertO(bodyurl);
            bodypropCount++;
            body["searchString"] = ExpressionConverter.ConvertO(bodysearchString);
            if (bodyregexSearch != null)
            {
                body["regexSearch"] = ExpressionConverter.ConvertO(bodyregexSearch);
                bodypropCount++;
            }

            if (bodypages != null)
            {
                body["pages"] = ExpressionConverter.ConvertO(bodypages);
                bodypropCount++;
            }

            if (bodyinline != null)
            {
                body["inline"] = ExpressionConverter.ConvertO(bodyinline);
                bodypropCount++;
            }

            if (bodywordMatchingMode != null)
            {
                body["wordMatchingMode"] = ExpressionConverter.ConvertO(bodywordMatchingMode);
                bodypropCount++;
            }

            if (bodypassword != null)
            {
                body["password"] = ExpressionConverter.ConvertO(bodypassword);
                bodypropCount++;
            }

            if (bodyasync != null)
            {
                body["async"] = ExpressionConverter.ConvertO(bodyasync);
                bodypropCount++;
            }

            if (bodyprofiles != null)
            {
                body["profiles"] = ExpressionConverter.ConvertO(bodyprofiles);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PDFSerarchTextResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<DocumentParserResponse> DocumentParser(Expression<Func<string>> bodyurl, Expression<Func<bodyoutputFormatInput>> bodyoutputFormat, Expression<Func<string>> bodytemplateId = null, Expression<Func<bool>> bodyinline = null, Expression<Func<string>> bodypassword = null, Expression<Func<string>> bodyprofiles = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<bool>> bodyasync = null)
        {
            var apiCallPath = "/v1/pdf/documentparser";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["url"] = ExpressionConverter.ConvertO(bodyurl);
            if (bodytemplateId != null)
            {
                body["templateId"] = ExpressionConverter.ConvertO(bodytemplateId);
                bodypropCount++;
            }

            bodypropCount++;
            body["outputFormat"] = ExpressionConverter.ConvertO(bodyoutputFormat);
            if (bodyinline != null)
            {
                body["inline"] = ExpressionConverter.ConvertO(bodyinline);
                bodypropCount++;
            }

            if (bodypassword != null)
            {
                body["password"] = ExpressionConverter.ConvertO(bodypassword);
                bodypropCount++;
            }

            if (bodyprofiles != null)
            {
                body["profiles"] = ExpressionConverter.ConvertO(bodyprofiles);
                bodypropCount++;
            }

            if (bodyexpiration != null)
            {
                body["expiration"] = ExpressionConverter.ConvertO(bodyexpiration);
                bodypropCount++;
            }

            if (bodyasync != null)
            {
                body["async"] = ExpressionConverter.ConvertO(bodyasync);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<DocumentParserResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<JobCheckResponse> JobCheck(Expression<Func<string>> bodyjobid)
        {
            var apiCallPath = "/v1/job/check";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["jobid"] = ExpressionConverter.ConvertO(bodyjobid);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JobCheckResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<BarcodeGeneratorResponse> BarcodeGenerator(Expression<Func<string>> bodyvalue, Expression<Func<bodytypeInput>> bodytype, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydecorationImage = null, Expression<Func<bool>> bodyasync = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<string>> bodyprofiles = null)
        {
            var apiCallPath = "/v1/barcode/generate";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            bodypropCount++;
            body["value"] = ExpressionConverter.ConvertO(bodyvalue);
            bodypropCount++;
            body["type"] = ExpressionConverter.ConvertO(bodytype);
            if (bodydecorationImage != null)
            {
                body["decorationImage"] = ExpressionConverter.ConvertO(bodydecorationImage);
                bodypropCount++;
            }

            if (bodyasync != null)
            {
                body["async"] = ExpressionConverter.ConvertO(bodyasync);
                bodypropCount++;
            }

            if (bodyexpiration != null)
            {
                body["expiration"] = ExpressionConverter.ConvertO(bodyexpiration);
                bodypropCount++;
            }

            if (bodyprofiles != null)
            {
                body["profiles"] = ExpressionConverter.ConvertO(bodyprofiles);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<BarcodeGeneratorResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<BarcodeReaderResponse> BarcodeReader(Expression<Func<string>> bodyurl, Expression<Func<string>> bodytypes, Expression<Func<string>> bodypages = null, Expression<Func<string>> bodyprofiles = null, Expression<Func<bool>> bodyasync = null)
        {
            var apiCallPath = "/v1/barcode/read/from/url";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["url"] = ExpressionConverter.ConvertO(bodyurl);
            bodypropCount++;
            body["types"] = ExpressionConverter.ConvertO(bodytypes);
            if (bodypages != null)
            {
                body["pages"] = ExpressionConverter.ConvertO(bodypages);
                bodypropCount++;
            }

            if (bodyprofiles != null)
            {
                body["profiles"] = ExpressionConverter.ConvertO(bodyprofiles);
                bodypropCount++;
            }

            if (bodyasync != null)
            {
                body["async"] = ExpressionConverter.ConvertO(bodyasync);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<BarcodeReaderResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFInfoReaderResponse> PDFInfoReader(Expression<Func<string>> bodyurl, Expression<Func<bool>> bodyasync = null, Expression<Func<string>> bodypassword = null, Expression<Func<string>> bodyprofiles = null)
        {
            var apiCallPath = "/v1/pdf/info";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["url"] = ExpressionConverter.ConvertO(bodyurl);
            if (bodyasync != null)
            {
                body["async"] = ExpressionConverter.ConvertO(bodyasync);
                bodypropCount++;
            }

            if (bodypassword != null)
            {
                body["password"] = ExpressionConverter.ConvertO(bodypassword);
                bodypropCount++;
            }

            if (bodyprofiles != null)
            {
                body["profiles"] = ExpressionConverter.ConvertO(bodyprofiles);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PDFInfoReaderResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFFormsInfoReaderResponse> PDFFormsInfoReader(Expression<Func<string>> bodyurl, Expression<Func<bool>> bodyasync = null, Expression<Func<string>> bodypassword = null, Expression<Func<string>> bodyprofiles = null)
        {
            var apiCallPath = "/v1/pdf/info/fields";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["url"] = ExpressionConverter.ConvertO(bodyurl);
            if (bodyasync != null)
            {
                body["async"] = ExpressionConverter.ConvertO(bodyasync);
                bodypropCount++;
            }

            if (bodypassword != null)
            {
                body["password"] = ExpressionConverter.ConvertO(bodypassword);
                bodypropCount++;
            }

            if (bodyprofiles != null)
            {
                body["profiles"] = ExpressionConverter.ConvertO(bodyprofiles);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PDFFormsInfoReaderResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFFindTableResponse> PDFFindTable(Expression<Func<string>> bodyurl, Expression<Func<string>> bodypages = null, Expression<Func<bool>> bodyinline = null, Expression<Func<string>> bodypassword = null, Expression<Func<string>> bodyprofiles = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<bool>> bodyasync = null)
        {
            var apiCallPath = "/v1/pdf/find/table";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["url"] = ExpressionConverter.ConvertO(bodyurl);
            if (bodypages != null)
            {
                body["pages"] = ExpressionConverter.ConvertO(bodypages);
                bodypropCount++;
            }

            if (bodyinline != null)
            {
                body["inline"] = ExpressionConverter.ConvertO(bodyinline);
                bodypropCount++;
            }

            if (bodypassword != null)
            {
                body["password"] = ExpressionConverter.ConvertO(bodypassword);
                bodypropCount++;
            }

            if (bodyprofiles != null)
            {
                body["profiles"] = ExpressionConverter.ConvertO(bodyprofiles);
                bodypropCount++;
            }

            if (bodyexpiration != null)
            {
                body["expiration"] = ExpressionConverter.ConvertO(bodyexpiration);
                bodypropCount++;
            }

            if (bodyasync != null)
            {
                body["async"] = ExpressionConverter.ConvertO(bodyasync);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PDFFindTableResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<SearchAndReplaceResponse> SearchAndReplace(Expression<Func<string>> bodyurl, Expression<Func<string[]>> bodysearchStrings, Expression<Func<string[]>> bodyreplaceStrings = null, Expression<Func<bool>> bodycaseSensitive = null, Expression<Func<int>> bodyreplacementLimit = null, Expression<Func<bool>> bodyregex = null, Expression<Func<string>> bodypages = null, Expression<Func<string>> bodypassword = null, Expression<Func<string>> bodyname = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<bool>> bodyasync = null)
        {
            var apiCallPath = "/v1/pdf/edit/replace-text";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["url"] = ExpressionConverter.ConvertO(bodyurl);
            bodypropCount++;
            body["searchStrings"] = ExpressionConverter.ConvertO(bodysearchStrings);
            if (bodyreplaceStrings != null)
            {
                body["replaceStrings"] = ExpressionConverter.ConvertO(bodyreplaceStrings);
                bodypropCount++;
            }

            if (bodycaseSensitive != null)
            {
                body["caseSensitive"] = ExpressionConverter.ConvertO(bodycaseSensitive);
                bodypropCount++;
            }

            if (bodyreplacementLimit != null)
            {
                body["replacementLimit"] = ExpressionConverter.ConvertO(bodyreplacementLimit);
                bodypropCount++;
            }

            if (bodyregex != null)
            {
                body["regex"] = ExpressionConverter.ConvertO(bodyregex);
                bodypropCount++;
            }

            if (bodypages != null)
            {
                body["pages"] = ExpressionConverter.ConvertO(bodypages);
                bodypropCount++;
            }

            if (bodypassword != null)
            {
                body["password"] = ExpressionConverter.ConvertO(bodypassword);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodyexpiration != null)
            {
                body["expiration"] = ExpressionConverter.ConvertO(bodyexpiration);
                bodypropCount++;
            }

            if (bodyasync != null)
            {
                body["async"] = ExpressionConverter.ConvertO(bodyasync);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SearchAndReplaceResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<SearchAndReplaceWithImageResponse> SearchAndReplaceWithImage(Expression<Func<string>> bodyurl, Expression<Func<string>> bodysearchString, Expression<Func<string>> bodyreplaceImage, Expression<Func<bool>> bodycaseSensitive = null, Expression<Func<string>> bodypages = null, Expression<Func<bool>> bodyasync = null, Expression<Func<bool>> bodyregex = null, Expression<Func<int>> bodyreplacementLimit = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<string>> bodypassword = null)
        {
            var apiCallPath = "/v1/pdf/edit/replace-text-with-image";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["url"] = ExpressionConverter.ConvertO(bodyurl);
            if (bodycaseSensitive != null)
            {
                body["caseSensitive"] = ExpressionConverter.ConvertO(bodycaseSensitive);
                bodypropCount++;
            }

            bodypropCount++;
            body["searchString"] = ExpressionConverter.ConvertO(bodysearchString);
            bodypropCount++;
            body["replaceImage"] = ExpressionConverter.ConvertO(bodyreplaceImage);
            if (bodypages != null)
            {
                body["pages"] = ExpressionConverter.ConvertO(bodypages);
                bodypropCount++;
            }

            if (bodyasync != null)
            {
                body["async"] = ExpressionConverter.ConvertO(bodyasync);
                bodypropCount++;
            }

            if (bodyregex != null)
            {
                body["regex"] = ExpressionConverter.ConvertO(bodyregex);
                bodypropCount++;
            }

            if (bodyreplacementLimit != null)
            {
                body["replacementLimit"] = ExpressionConverter.ConvertO(bodyreplacementLimit);
                bodypropCount++;
            }

            if (bodyexpiration != null)
            {
                body["expiration"] = ExpressionConverter.ConvertO(bodyexpiration);
                bodypropCount++;
            }

            if (bodypassword != null)
            {
                body["password"] = ExpressionConverter.ConvertO(bodypassword);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SearchAndReplaceWithImageResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<SearchAndDeleteTextResponse> SearchAndDeleteText(Expression<Func<string>> bodyurl, Expression<Func<string[]>> bodysearchStrings, Expression<Func<bool>> bodycaseSensitive = null, Expression<Func<bool>> bodyregex = null, Expression<Func<int>> bodyreplacementLimit = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodypassword = null, Expression<Func<string>> bodypages = null, Expression<Func<string>> bodyprofiles = null, Expression<Func<bool>> bodyasync = null)
        {
            var apiCallPath = "/v1/pdf/edit/delete-text";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["url"] = ExpressionConverter.ConvertO(bodyurl);
            bodypropCount++;
            body["searchStrings"] = ExpressionConverter.ConvertO(bodysearchStrings);
            if (bodycaseSensitive != null)
            {
                body["caseSensitive"] = ExpressionConverter.ConvertO(bodycaseSensitive);
                bodypropCount++;
            }

            if (bodyregex != null)
            {
                body["regex"] = ExpressionConverter.ConvertO(bodyregex);
                bodypropCount++;
            }

            if (bodyreplacementLimit != null)
            {
                body["replacementLimit"] = ExpressionConverter.ConvertO(bodyreplacementLimit);
                bodypropCount++;
            }

            if (bodyexpiration != null)
            {
                body["expiration"] = ExpressionConverter.ConvertO(bodyexpiration);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodypassword != null)
            {
                body["password"] = ExpressionConverter.ConvertO(bodypassword);
                bodypropCount++;
            }

            if (bodypages != null)
            {
                body["pages"] = ExpressionConverter.ConvertO(bodypages);
                bodypropCount++;
            }

            if (bodyprofiles != null)
            {
                body["profiles"] = ExpressionConverter.ConvertO(bodyprofiles);
                bodypropCount++;
            }

            if (bodyasync != null)
            {
                body["async"] = ExpressionConverter.ConvertO(bodyasync);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SearchAndDeleteTextResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFSearchableResponse> PDFSearchable(Expression<Func<string>> bodyurl, Expression<Func<string>> bodylang = null, Expression<Func<string>> bodypages = null, Expression<Func<string>> bodypassword = null, Expression<Func<bool>> bodyasync = null, Expression<Func<string>> bodyprofiles = null)
        {
            var apiCallPath = "/v1/pdf/makesearchable";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["url"] = ExpressionConverter.ConvertO(bodyurl);
            if (bodylang != null)
            {
                body["lang"] = ExpressionConverter.ConvertO(bodylang);
                bodypropCount++;
            }

            if (bodypages != null)
            {
                body["pages"] = ExpressionConverter.ConvertO(bodypages);
                bodypropCount++;
            }

            if (bodypassword != null)
            {
                body["password"] = ExpressionConverter.ConvertO(bodypassword);
                bodypropCount++;
            }

            if (bodyasync != null)
            {
                body["async"] = ExpressionConverter.ConvertO(bodyasync);
                bodypropCount++;
            }

            if (bodyprofiles != null)
            {
                body["profiles"] = ExpressionConverter.ConvertO(bodyprofiles);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PDFSearchableResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFUnSearchableResponse> PDFUnSearchable(Expression<Func<string>> bodyurl, Expression<Func<string>> bodypages = null, Expression<Func<string>> bodypassword = null, Expression<Func<bool>> bodyasync = null, Expression<Func<string>> bodyprofiles = null)
        {
            var apiCallPath = "/v1/pdf/makeunsearchable";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["url"] = ExpressionConverter.ConvertO(bodyurl);
            if (bodypages != null)
            {
                body["pages"] = ExpressionConverter.ConvertO(bodypages);
                bodypropCount++;
            }

            if (bodypassword != null)
            {
                body["password"] = ExpressionConverter.ConvertO(bodypassword);
                bodypropCount++;
            }

            if (bodyasync != null)
            {
                body["async"] = ExpressionConverter.ConvertO(bodyasync);
                bodypropCount++;
            }

            if (bodyprofiles != null)
            {
                body["profiles"] = ExpressionConverter.ConvertO(bodyprofiles);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PDFUnSearchableResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFToCSVResponse> PDFToCSV(Expression<Func<string>> bodyurl, Expression<Func<string>> bodylang = null, Expression<Func<bool>> bodyinline = null, Expression<Func<bodyunwrapInput>> bodyunwrap = null, Expression<Func<string>> bodypages = null, Expression<Func<string>> bodyrect = null, Expression<Func<bool>> bodyasync = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodylineGrouping = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<string>> bodyprofiles = null)
        {
            var apiCallPath = "/v1/pdf/convert/to/csv";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["url"] = ExpressionConverter.ConvertO(bodyurl);
            if (bodylang != null)
            {
                body["lang"] = ExpressionConverter.ConvertO(bodylang);
                bodypropCount++;
            }

            if (bodyinline != null)
            {
                body["inline"] = ExpressionConverter.ConvertO(bodyinline);
                bodypropCount++;
            }

            if (bodyunwrap != null)
            {
                body["unwrap"] = ExpressionConverter.ConvertO(bodyunwrap);
                bodypropCount++;
            }

            if (bodypages != null)
            {
                body["pages"] = ExpressionConverter.ConvertO(bodypages);
                bodypropCount++;
            }

            if (bodyrect != null)
            {
                body["rect"] = ExpressionConverter.ConvertO(bodyrect);
                bodypropCount++;
            }

            if (bodyasync != null)
            {
                body["async"] = ExpressionConverter.ConvertO(bodyasync);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodylineGrouping != null)
            {
                body["lineGrouping"] = ExpressionConverter.ConvertO(bodylineGrouping);
                bodypropCount++;
            }

            if (bodyexpiration != null)
            {
                body["expiration"] = ExpressionConverter.ConvertO(bodyexpiration);
                bodypropCount++;
            }

            if (bodyprofiles != null)
            {
                body["profiles"] = ExpressionConverter.ConvertO(bodyprofiles);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PDFToCSVResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFToJSONResponse> PDFToJSON(Expression<Func<string>> bodyurl, Expression<Func<string>> bodylang = null, Expression<Func<bool>> bodyinline = null, Expression<Func<bodyunwrapInput>> bodyunwrap = null, Expression<Func<string>> bodypages = null, Expression<Func<string>> bodyrect = null, Expression<Func<bool>> bodyasync = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodylineGrouping = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<string>> bodyprofiles = null)
        {
            var apiCallPath = "/v1/pdf/convert/to/json2";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["url"] = ExpressionConverter.ConvertO(bodyurl);
            if (bodylang != null)
            {
                body["lang"] = ExpressionConverter.ConvertO(bodylang);
                bodypropCount++;
            }

            if (bodyinline != null)
            {
                body["inline"] = ExpressionConverter.ConvertO(bodyinline);
                bodypropCount++;
            }

            if (bodyunwrap != null)
            {
                body["unwrap"] = ExpressionConverter.ConvertO(bodyunwrap);
                bodypropCount++;
            }

            if (bodypages != null)
            {
                body["pages"] = ExpressionConverter.ConvertO(bodypages);
                bodypropCount++;
            }

            if (bodyrect != null)
            {
                body["rect"] = ExpressionConverter.ConvertO(bodyrect);
                bodypropCount++;
            }

            if (bodyasync != null)
            {
                body["async"] = ExpressionConverter.ConvertO(bodyasync);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodylineGrouping != null)
            {
                body["lineGrouping"] = ExpressionConverter.ConvertO(bodylineGrouping);
                bodypropCount++;
            }

            if (bodyexpiration != null)
            {
                body["expiration"] = ExpressionConverter.ConvertO(bodyexpiration);
                bodypropCount++;
            }

            if (bodyprofiles != null)
            {
                body["profiles"] = ExpressionConverter.ConvertO(bodyprofiles);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PDFToJSONResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFToJSONMetaResponse> PDFToJSONMeta(Expression<Func<string>> bodyurl, Expression<Func<string>> bodylang = null, Expression<Func<bool>> bodyinline = null, Expression<Func<bodyunwrapInput>> bodyunwrap = null, Expression<Func<string>> bodypages = null, Expression<Func<string>> bodyrect = null, Expression<Func<bool>> bodyasync = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodylineGrouping = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<string>> bodyprofiles = null)
        {
            var apiCallPath = "/v1/pdf/convert/to/json-meta";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["url"] = ExpressionConverter.ConvertO(bodyurl);
            if (bodylang != null)
            {
                body["lang"] = ExpressionConverter.ConvertO(bodylang);
                bodypropCount++;
            }

            if (bodyinline != null)
            {
                body["inline"] = ExpressionConverter.ConvertO(bodyinline);
                bodypropCount++;
            }

            if (bodyunwrap != null)
            {
                body["unwrap"] = ExpressionConverter.ConvertO(bodyunwrap);
                bodypropCount++;
            }

            if (bodypages != null)
            {
                body["pages"] = ExpressionConverter.ConvertO(bodypages);
                bodypropCount++;
            }

            if (bodyrect != null)
            {
                body["rect"] = ExpressionConverter.ConvertO(bodyrect);
                bodypropCount++;
            }

            if (bodyasync != null)
            {
                body["async"] = ExpressionConverter.ConvertO(bodyasync);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodylineGrouping != null)
            {
                body["lineGrouping"] = ExpressionConverter.ConvertO(bodylineGrouping);
                bodypropCount++;
            }

            if (bodyexpiration != null)
            {
                body["expiration"] = ExpressionConverter.ConvertO(bodyexpiration);
                bodypropCount++;
            }

            if (bodyprofiles != null)
            {
                body["profiles"] = ExpressionConverter.ConvertO(bodyprofiles);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PDFToJSONMetaResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFToTextResponse> PDFToText(Expression<Func<string>> bodyurl, Expression<Func<string>> bodylang = null, Expression<Func<bool>> bodyinline = null, Expression<Func<bodyunwrapInput>> bodyunwrap = null, Expression<Func<string>> bodypages = null, Expression<Func<string>> bodyrect = null, Expression<Func<bool>> bodyasync = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodylineGrouping = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<string>> bodyprofiles = null)
        {
            var apiCallPath = "/v1/pdf/convert/to/text";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["url"] = ExpressionConverter.ConvertO(bodyurl);
            if (bodylang != null)
            {
                body["lang"] = ExpressionConverter.ConvertO(bodylang);
                bodypropCount++;
            }

            if (bodyinline != null)
            {
                body["inline"] = ExpressionConverter.ConvertO(bodyinline);
                bodypropCount++;
            }

            if (bodyunwrap != null)
            {
                body["unwrap"] = ExpressionConverter.ConvertO(bodyunwrap);
                bodypropCount++;
            }

            if (bodypages != null)
            {
                body["pages"] = ExpressionConverter.ConvertO(bodypages);
                bodypropCount++;
            }

            if (bodyrect != null)
            {
                body["rect"] = ExpressionConverter.ConvertO(bodyrect);
                bodypropCount++;
            }

            if (bodyasync != null)
            {
                body["async"] = ExpressionConverter.ConvertO(bodyasync);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodylineGrouping != null)
            {
                body["lineGrouping"] = ExpressionConverter.ConvertO(bodylineGrouping);
                bodypropCount++;
            }

            if (bodyexpiration != null)
            {
                body["expiration"] = ExpressionConverter.ConvertO(bodyexpiration);
                bodypropCount++;
            }

            if (bodyprofiles != null)
            {
                body["profiles"] = ExpressionConverter.ConvertO(bodyprofiles);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PDFToTextResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFToTextSimpleResponse> PDFToTextSimple(Expression<Func<string>> bodyurl, Expression<Func<bool>> bodyinline = null, Expression<Func<string>> bodypages = null, Expression<Func<bool>> bodyasync = null, Expression<Func<string>> bodyname = null, Expression<Func<int>> bodyexpiration = null)
        {
            var apiCallPath = "/v1/pdf/convert/to/text-simple";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["url"] = ExpressionConverter.ConvertO(bodyurl);
            if (bodyinline != null)
            {
                body["inline"] = ExpressionConverter.ConvertO(bodyinline);
                bodypropCount++;
            }

            if (bodypages != null)
            {
                body["pages"] = ExpressionConverter.ConvertO(bodypages);
                bodypropCount++;
            }

            if (bodyasync != null)
            {
                body["async"] = ExpressionConverter.ConvertO(bodyasync);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodyexpiration != null)
            {
                body["expiration"] = ExpressionConverter.ConvertO(bodyexpiration);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PDFToTextSimpleResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFToXLSResponse> PDFToXLS(Expression<Func<string>> bodyurl, Expression<Func<string>> bodylang = null, Expression<Func<bodyunwrapInput>> bodyunwrap = null, Expression<Func<string>> bodypages = null, Expression<Func<string>> bodyrect = null, Expression<Func<bool>> bodyasync = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodylineGrouping = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<string>> bodyprofiles = null)
        {
            var apiCallPath = "/v1/pdf/convert/to/xls";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["url"] = ExpressionConverter.ConvertO(bodyurl);
            if (bodylang != null)
            {
                body["lang"] = ExpressionConverter.ConvertO(bodylang);
                bodypropCount++;
            }

            if (bodyunwrap != null)
            {
                body["unwrap"] = ExpressionConverter.ConvertO(bodyunwrap);
                bodypropCount++;
            }

            if (bodypages != null)
            {
                body["pages"] = ExpressionConverter.ConvertO(bodypages);
                bodypropCount++;
            }

            if (bodyrect != null)
            {
                body["rect"] = ExpressionConverter.ConvertO(bodyrect);
                bodypropCount++;
            }

            if (bodyasync != null)
            {
                body["async"] = ExpressionConverter.ConvertO(bodyasync);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodylineGrouping != null)
            {
                body["lineGrouping"] = ExpressionConverter.ConvertO(bodylineGrouping);
                bodypropCount++;
            }

            if (bodyexpiration != null)
            {
                body["expiration"] = ExpressionConverter.ConvertO(bodyexpiration);
                bodypropCount++;
            }

            if (bodyprofiles != null)
            {
                body["profiles"] = ExpressionConverter.ConvertO(bodyprofiles);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PDFToXLSResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFToXLSXResponse> PDFToXLSX(Expression<Func<string>> bodyurl, Expression<Func<string>> bodylang = null, Expression<Func<bodyunwrapInput>> bodyunwrap = null, Expression<Func<string>> bodypages = null, Expression<Func<string>> bodyrect = null, Expression<Func<bool>> bodyasync = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodylineGrouping = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<string>> bodyprofiles = null)
        {
            var apiCallPath = "/v1/pdf/convert/to/xlsx";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["url"] = ExpressionConverter.ConvertO(bodyurl);
            if (bodylang != null)
            {
                body["lang"] = ExpressionConverter.ConvertO(bodylang);
                bodypropCount++;
            }

            if (bodyunwrap != null)
            {
                body["unwrap"] = ExpressionConverter.ConvertO(bodyunwrap);
                bodypropCount++;
            }

            if (bodypages != null)
            {
                body["pages"] = ExpressionConverter.ConvertO(bodypages);
                bodypropCount++;
            }

            if (bodyrect != null)
            {
                body["rect"] = ExpressionConverter.ConvertO(bodyrect);
                bodypropCount++;
            }

            if (bodyasync != null)
            {
                body["async"] = ExpressionConverter.ConvertO(bodyasync);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodylineGrouping != null)
            {
                body["lineGrouping"] = ExpressionConverter.ConvertO(bodylineGrouping);
                bodypropCount++;
            }

            if (bodyexpiration != null)
            {
                body["expiration"] = ExpressionConverter.ConvertO(bodyexpiration);
                bodypropCount++;
            }

            if (bodyprofiles != null)
            {
                body["profiles"] = ExpressionConverter.ConvertO(bodyprofiles);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PDFToXLSXResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFToXMLResponse> PDFToXML(Expression<Func<string>> bodyurl, Expression<Func<bool>> bodyinline = null, Expression<Func<string>> bodylang = null, Expression<Func<bodyunwrapInput>> bodyunwrap = null, Expression<Func<string>> bodypages = null, Expression<Func<string>> bodyrect = null, Expression<Func<bool>> bodyasync = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodylineGrouping = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<string>> bodyprofiles = null)
        {
            var apiCallPath = "/v1/pdf/convert/to/xml";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["url"] = ExpressionConverter.ConvertO(bodyurl);
            if (bodyinline != null)
            {
                body["inline"] = ExpressionConverter.ConvertO(bodyinline);
                bodypropCount++;
            }

            if (bodylang != null)
            {
                body["lang"] = ExpressionConverter.ConvertO(bodylang);
                bodypropCount++;
            }

            if (bodyunwrap != null)
            {
                body["unwrap"] = ExpressionConverter.ConvertO(bodyunwrap);
                bodypropCount++;
            }

            if (bodypages != null)
            {
                body["pages"] = ExpressionConverter.ConvertO(bodypages);
                bodypropCount++;
            }

            if (bodyrect != null)
            {
                body["rect"] = ExpressionConverter.ConvertO(bodyrect);
                bodypropCount++;
            }

            if (bodyasync != null)
            {
                body["async"] = ExpressionConverter.ConvertO(bodyasync);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodylineGrouping != null)
            {
                body["lineGrouping"] = ExpressionConverter.ConvertO(bodylineGrouping);
                bodypropCount++;
            }

            if (bodyexpiration != null)
            {
                body["expiration"] = ExpressionConverter.ConvertO(bodyexpiration);
                bodypropCount++;
            }

            if (bodyprofiles != null)
            {
                body["profiles"] = ExpressionConverter.ConvertO(bodyprofiles);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PDFToXMLResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFToJPGResponse> PDFToJPG(Expression<Func<string>> bodyurl, Expression<Func<bool>> bodyinline = null, Expression<Func<string>> bodypages = null, Expression<Func<string>> bodyrect = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<bool>> bodyasync = null, Expression<Func<string>> bodyprofiles = null)
        {
            var apiCallPath = "/v1/pdf/convert/to/jpg";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["url"] = ExpressionConverter.ConvertO(bodyurl);
            if (bodyinline != null)
            {
                body["inline"] = ExpressionConverter.ConvertO(bodyinline);
                bodypropCount++;
            }

            if (bodypages != null)
            {
                body["pages"] = ExpressionConverter.ConvertO(bodypages);
                bodypropCount++;
            }

            if (bodyrect != null)
            {
                body["rect"] = ExpressionConverter.ConvertO(bodyrect);
                bodypropCount++;
            }

            if (bodyexpiration != null)
            {
                body["expiration"] = ExpressionConverter.ConvertO(bodyexpiration);
                bodypropCount++;
            }

            if (bodyasync != null)
            {
                body["async"] = ExpressionConverter.ConvertO(bodyasync);
                bodypropCount++;
            }

            if (bodyprofiles != null)
            {
                body["profiles"] = ExpressionConverter.ConvertO(bodyprofiles);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PDFToJPGResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFToPNGResponse> PDFToPNG(Expression<Func<string>> bodyurl, Expression<Func<bool>> bodyinline = null, Expression<Func<string>> bodypages = null, Expression<Func<string>> bodyrect = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<bool>> bodyasync = null, Expression<Func<string>> bodyprofiles = null)
        {
            var apiCallPath = "/v1/pdf/convert/to/png";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["url"] = ExpressionConverter.ConvertO(bodyurl);
            if (bodyinline != null)
            {
                body["inline"] = ExpressionConverter.ConvertO(bodyinline);
                bodypropCount++;
            }

            if (bodypages != null)
            {
                body["pages"] = ExpressionConverter.ConvertO(bodypages);
                bodypropCount++;
            }

            if (bodyrect != null)
            {
                body["rect"] = ExpressionConverter.ConvertO(bodyrect);
                bodypropCount++;
            }

            if (bodyexpiration != null)
            {
                body["expiration"] = ExpressionConverter.ConvertO(bodyexpiration);
                bodypropCount++;
            }

            if (bodyasync != null)
            {
                body["async"] = ExpressionConverter.ConvertO(bodyasync);
                bodypropCount++;
            }

            if (bodyprofiles != null)
            {
                body["profiles"] = ExpressionConverter.ConvertO(bodyprofiles);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PDFToPNGResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFToWEBPResponse> PDFToWEBP(Expression<Func<string>> bodyurl, Expression<Func<bool>> bodyinline = null, Expression<Func<string>> bodypages = null, Expression<Func<string>> bodyrect = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<bool>> bodyasync = null, Expression<Func<string>> bodyprofiles = null)
        {
            var apiCallPath = "/v1/pdf/convert/to/webp";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["url"] = ExpressionConverter.ConvertO(bodyurl);
            if (bodyinline != null)
            {
                body["inline"] = ExpressionConverter.ConvertO(bodyinline);
                bodypropCount++;
            }

            if (bodypages != null)
            {
                body["pages"] = ExpressionConverter.ConvertO(bodypages);
                bodypropCount++;
            }

            if (bodyrect != null)
            {
                body["rect"] = ExpressionConverter.ConvertO(bodyrect);
                bodypropCount++;
            }

            if (bodyexpiration != null)
            {
                body["expiration"] = ExpressionConverter.ConvertO(bodyexpiration);
                bodypropCount++;
            }

            if (bodyasync != null)
            {
                body["async"] = ExpressionConverter.ConvertO(bodyasync);
                bodypropCount++;
            }

            if (bodyprofiles != null)
            {
                body["profiles"] = ExpressionConverter.ConvertO(bodyprofiles);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PDFToWEBPResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFToTIFFResponse> PDFToTIFF(Expression<Func<string>> bodyurl, Expression<Func<bool>> bodyinline = null, Expression<Func<string>> bodypages = null, Expression<Func<string>> bodyrect = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<bool>> bodyasync = null, Expression<Func<string>> bodyprofiles = null)
        {
            var apiCallPath = "/v1/pdf/convert/to/tiff";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["url"] = ExpressionConverter.ConvertO(bodyurl);
            if (bodyinline != null)
            {
                body["inline"] = ExpressionConverter.ConvertO(bodyinline);
                bodypropCount++;
            }

            if (bodypages != null)
            {
                body["pages"] = ExpressionConverter.ConvertO(bodypages);
                bodypropCount++;
            }

            if (bodyrect != null)
            {
                body["rect"] = ExpressionConverter.ConvertO(bodyrect);
                bodypropCount++;
            }

            if (bodyexpiration != null)
            {
                body["expiration"] = ExpressionConverter.ConvertO(bodyexpiration);
                bodypropCount++;
            }

            if (bodyasync != null)
            {
                body["async"] = ExpressionConverter.ConvertO(bodyasync);
                bodypropCount++;
            }

            if (bodyprofiles != null)
            {
                body["profiles"] = ExpressionConverter.ConvertO(bodyprofiles);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PDFToTIFFResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFFromCSVResponse> PDFFromCSV(Expression<Func<string>> bodyurl, Expression<Func<string>> bodypages = null, Expression<Func<string>> bodyname = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<bool>> bodyasync = null, Expression<Func<string>> bodyprofiles = null)
        {
            var apiCallPath = "/v1/pdf/convert/from/csv";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["url"] = ExpressionConverter.ConvertO(bodyurl);
            if (bodypages != null)
            {
                body["pages"] = ExpressionConverter.ConvertO(bodypages);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodyexpiration != null)
            {
                body["expiration"] = ExpressionConverter.ConvertO(bodyexpiration);
                bodypropCount++;
            }

            if (bodyasync != null)
            {
                body["async"] = ExpressionConverter.ConvertO(bodyasync);
                bodypropCount++;
            }

            if (bodyprofiles != null)
            {
                body["profiles"] = ExpressionConverter.ConvertO(bodyprofiles);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PDFFromCSVResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFFromDocResponse> PDFFromDoc(Expression<Func<string>> bodyurl, Expression<Func<string>> bodypages = null, Expression<Func<string>> bodyname = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<bool>> bodyasync = null, Expression<Func<string>> bodyprofiles = null)
        {
            var apiCallPath = "/v1/pdf/convert/from/doc";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["url"] = ExpressionConverter.ConvertO(bodyurl);
            if (bodypages != null)
            {
                body["pages"] = ExpressionConverter.ConvertO(bodypages);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodyexpiration != null)
            {
                body["expiration"] = ExpressionConverter.ConvertO(bodyexpiration);
                bodypropCount++;
            }

            if (bodyasync != null)
            {
                body["async"] = ExpressionConverter.ConvertO(bodyasync);
                bodypropCount++;
            }

            if (bodyprofiles != null)
            {
                body["profiles"] = ExpressionConverter.ConvertO(bodyprofiles);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PDFFromDocResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFFromImagesResponse> PDFFromImages(Expression<Func<string>> bodyurl, Expression<Func<string>> bodyname = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<bool>> bodyasync = null, Expression<Func<string>> bodyprofiles = null)
        {
            var apiCallPath = "/v1/pdf/convert/from/image";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["url"] = ExpressionConverter.ConvertO(bodyurl);
            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodyexpiration != null)
            {
                body["expiration"] = ExpressionConverter.ConvertO(bodyexpiration);
                bodypropCount++;
            }

            if (bodyasync != null)
            {
                body["async"] = ExpressionConverter.ConvertO(bodyasync);
                bodypropCount++;
            }

            if (bodyprofiles != null)
            {
                body["profiles"] = ExpressionConverter.ConvertO(bodyprofiles);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PDFFromImagesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFFromEmailResponse> PDFFromEmail(Expression<Func<string>> bodyurl, Expression<Func<bool>> bodyembedAttachments = null, Expression<Func<bool>> bodyconvertAttachments = null, Expression<Func<string>> bodymargins = null, Expression<Func<string>> bodypaperSize = null, Expression<Func<bodyorientationInput>> bodyorientation = null, Expression<Func<string>> bodyname = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<bool>> bodyasync = null, Expression<Func<string>> bodyprofiles = null)
        {
            var apiCallPath = "/v1/pdf/convert/from/email";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["url"] = ExpressionConverter.ConvertO(bodyurl);
            if (bodyembedAttachments != null)
            {
                body["embedAttachments"] = ExpressionConverter.ConvertO(bodyembedAttachments);
                bodypropCount++;
            }

            if (bodyconvertAttachments != null)
            {
                body["convertAttachments"] = ExpressionConverter.ConvertO(bodyconvertAttachments);
                bodypropCount++;
            }

            if (bodymargins != null)
            {
                body["margins"] = ExpressionConverter.ConvertO(bodymargins);
                bodypropCount++;
            }

            if (bodypaperSize != null)
            {
                body["paperSize"] = ExpressionConverter.ConvertO(bodypaperSize);
                bodypropCount++;
            }

            if (bodyorientation != null)
            {
                body["orientation"] = ExpressionConverter.ConvertO(bodyorientation);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodyexpiration != null)
            {
                body["expiration"] = ExpressionConverter.ConvertO(bodyexpiration);
                bodypropCount++;
            }

            if (bodyasync != null)
            {
                body["async"] = ExpressionConverter.ConvertO(bodyasync);
                bodypropCount++;
            }

            if (bodyprofiles != null)
            {
                body["profiles"] = ExpressionConverter.ConvertO(bodyprofiles);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PDFFromEmailResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFAddSecurityResponse> PDFAddSecurity(Expression<Func<string>> bodyurl, Expression<Func<string>> bodyownerPassword, Expression<Func<string>> bodyuserPassword = null, Expression<Func<bodyencryptionAlgorithmInput>> bodyencryptionAlgorithm = null, Expression<Func<bool>> bodyallowAccessibilitySupport = null, Expression<Func<bool>> bodyallowAssemblyDocument = null, Expression<Func<bool>> bodyallowPrintDocument = null, Expression<Func<bool>> bodyallowFillForms = null, Expression<Func<bool>> bodyallowModifyDocument = null, Expression<Func<bool>> bodyallowContentExtraction = null, Expression<Func<bool>> bodyallowModifyAnnotations = null, Expression<Func<bodyprintQualityInput>> bodyprintQuality = null, Expression<Func<string>> bodyname = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<bool>> bodyasync = null, Expression<Func<string>> bodyprofiles = null)
        {
            var apiCallPath = "/v1/pdf/security/add";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["url"] = ExpressionConverter.ConvertO(bodyurl);
            bodypropCount++;
            body["ownerPassword"] = ExpressionConverter.ConvertO(bodyownerPassword);
            if (bodyuserPassword != null)
            {
                body["userPassword"] = ExpressionConverter.ConvertO(bodyuserPassword);
                bodypropCount++;
            }

            if (bodyencryptionAlgorithm != null)
            {
                body["encryptionAlgorithm"] = ExpressionConverter.ConvertO(bodyencryptionAlgorithm);
                bodypropCount++;
            }

            if (bodyallowAccessibilitySupport != null)
            {
                body["allowAccessibilitySupport"] = ExpressionConverter.ConvertO(bodyallowAccessibilitySupport);
                bodypropCount++;
            }

            if (bodyallowAssemblyDocument != null)
            {
                body["allowAssemblyDocument"] = ExpressionConverter.ConvertO(bodyallowAssemblyDocument);
                bodypropCount++;
            }

            if (bodyallowPrintDocument != null)
            {
                body["allowPrintDocument"] = ExpressionConverter.ConvertO(bodyallowPrintDocument);
                bodypropCount++;
            }

            if (bodyallowFillForms != null)
            {
                body["allowFillForms"] = ExpressionConverter.ConvertO(bodyallowFillForms);
                bodypropCount++;
            }

            if (bodyallowModifyDocument != null)
            {
                body["allowModifyDocument"] = ExpressionConverter.ConvertO(bodyallowModifyDocument);
                bodypropCount++;
            }

            if (bodyallowContentExtraction != null)
            {
                body["allowContentExtraction"] = ExpressionConverter.ConvertO(bodyallowContentExtraction);
                bodypropCount++;
            }

            if (bodyallowModifyAnnotations != null)
            {
                body["allowModifyAnnotations"] = ExpressionConverter.ConvertO(bodyallowModifyAnnotations);
                bodypropCount++;
            }

            if (bodyprintQuality != null)
            {
                body["printQuality"] = ExpressionConverter.ConvertO(bodyprintQuality);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodyexpiration != null)
            {
                body["expiration"] = ExpressionConverter.ConvertO(bodyexpiration);
                bodypropCount++;
            }

            if (bodyasync != null)
            {
                body["async"] = ExpressionConverter.ConvertO(bodyasync);
                bodypropCount++;
            }

            if (bodyprofiles != null)
            {
                body["profiles"] = ExpressionConverter.ConvertO(bodyprofiles);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PDFAddSecurityResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFSecurityRemoveResponse> PDFSecurityRemove(Expression<Func<string>> bodyurl, Expression<Func<string>> bodypassword, Expression<Func<string>> bodyname = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<bool>> bodyasync = null, Expression<Func<string>> bodyprofiles = null)
        {
            var apiCallPath = "/v1/pdf/security/remove";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["url"] = ExpressionConverter.ConvertO(bodyurl);
            bodypropCount++;
            body["password"] = ExpressionConverter.ConvertO(bodypassword);
            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodyexpiration != null)
            {
                body["expiration"] = ExpressionConverter.ConvertO(bodyexpiration);
                bodypropCount++;
            }

            if (bodyasync != null)
            {
                body["async"] = ExpressionConverter.ConvertO(bodyasync);
                bodypropCount++;
            }

            if (bodyprofiles != null)
            {
                body["profiles"] = ExpressionConverter.ConvertO(bodyprofiles);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PDFSecurityRemoveResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFFromXLSXLSXResponse> PDFFromXLSXLSX(Expression<Func<string>> bodyurl, Expression<Func<string>> bodyworksheetIndex = null, Expression<Func<string>> bodyname = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<bool>> bodyasync = null, Expression<Func<string>> bodyprofiles = null)
        {
            var apiCallPath = "/v1/xls/convert/to/pdf";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["url"] = ExpressionConverter.ConvertO(bodyurl);
            if (bodyworksheetIndex != null)
            {
                body["worksheetIndex"] = ExpressionConverter.ConvertO(bodyworksheetIndex);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodyexpiration != null)
            {
                body["expiration"] = ExpressionConverter.ConvertO(bodyexpiration);
                bodypropCount++;
            }

            if (bodyasync != null)
            {
                body["async"] = ExpressionConverter.ConvertO(bodyasync);
                bodypropCount++;
            }

            if (bodyprofiles != null)
            {
                body["profiles"] = ExpressionConverter.ConvertO(bodyprofiles);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PDFFromXLSXLSXResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<XLStoCSVResponse> XLStoCSV(Expression<Func<string>> bodyurl, Expression<Func<string>> bodyworksheetIndex = null, Expression<Func<string>> bodyquotationSymbol = null, Expression<Func<string>> bodyseparatorSymbol = null, Expression<Func<string>> bodyname = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<bool>> bodyasync = null, Expression<Func<string>> bodyprofiles = null)
        {
            var apiCallPath = "/v1/xls/convert/to/csv";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["url"] = ExpressionConverter.ConvertO(bodyurl);
            if (bodyworksheetIndex != null)
            {
                body["worksheetIndex"] = ExpressionConverter.ConvertO(bodyworksheetIndex);
                bodypropCount++;
            }

            if (bodyquotationSymbol != null)
            {
                body["quotationSymbol"] = ExpressionConverter.ConvertO(bodyquotationSymbol);
                bodypropCount++;
            }

            if (bodyseparatorSymbol != null)
            {
                body["separatorSymbol"] = ExpressionConverter.ConvertO(bodyseparatorSymbol);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodyexpiration != null)
            {
                body["expiration"] = ExpressionConverter.ConvertO(bodyexpiration);
                bodypropCount++;
            }

            if (bodyasync != null)
            {
                body["async"] = ExpressionConverter.ConvertO(bodyasync);
                bodypropCount++;
            }

            if (bodyprofiles != null)
            {
                body["profiles"] = ExpressionConverter.ConvertO(bodyprofiles);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<XLStoCSVResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<XLStoJSONResponse> XLStoJSON(Expression<Func<string>> bodyurl, Expression<Func<string>> bodyworksheetIndex = null, Expression<Func<string>> bodyname = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<bool>> bodyasync = null, Expression<Func<string>> bodyprofiles = null)
        {
            var apiCallPath = "/v1/xls/convert/to/json";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["url"] = ExpressionConverter.ConvertO(bodyurl);
            if (bodyworksheetIndex != null)
            {
                body["worksheetIndex"] = ExpressionConverter.ConvertO(bodyworksheetIndex);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodyexpiration != null)
            {
                body["expiration"] = ExpressionConverter.ConvertO(bodyexpiration);
                bodypropCount++;
            }

            if (bodyasync != null)
            {
                body["async"] = ExpressionConverter.ConvertO(bodyasync);
                bodypropCount++;
            }

            if (bodyprofiles != null)
            {
                body["profiles"] = ExpressionConverter.ConvertO(bodyprofiles);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<XLStoJSONResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<XLStoHTMLResponse> XLStoHTML(Expression<Func<string>> bodyurl, Expression<Func<string>> bodyworksheetIndex = null, Expression<Func<string>> bodyname = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<bool>> bodyasync = null, Expression<Func<string>> bodyprofiles = null)
        {
            var apiCallPath = "/v1/xls/convert/to/html";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["url"] = ExpressionConverter.ConvertO(bodyurl);
            if (bodyworksheetIndex != null)
            {
                body["worksheetIndex"] = ExpressionConverter.ConvertO(bodyworksheetIndex);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodyexpiration != null)
            {
                body["expiration"] = ExpressionConverter.ConvertO(bodyexpiration);
                bodypropCount++;
            }

            if (bodyasync != null)
            {
                body["async"] = ExpressionConverter.ConvertO(bodyasync);
                bodypropCount++;
            }

            if (bodyprofiles != null)
            {
                body["profiles"] = ExpressionConverter.ConvertO(bodyprofiles);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<XLStoHTMLResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<XLStoTXTResponse> XLStoTXT(Expression<Func<string>> bodyurl, Expression<Func<string>> bodyworksheetIndex = null, Expression<Func<string>> bodyname = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<bool>> bodyasync = null, Expression<Func<string>> bodyprofiles = null)
        {
            var apiCallPath = "/v1/xls/convert/to/txt";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["url"] = ExpressionConverter.ConvertO(bodyurl);
            if (bodyworksheetIndex != null)
            {
                body["worksheetIndex"] = ExpressionConverter.ConvertO(bodyworksheetIndex);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodyexpiration != null)
            {
                body["expiration"] = ExpressionConverter.ConvertO(bodyexpiration);
                bodypropCount++;
            }

            if (bodyasync != null)
            {
                body["async"] = ExpressionConverter.ConvertO(bodyasync);
                bodypropCount++;
            }

            if (bodyprofiles != null)
            {
                body["profiles"] = ExpressionConverter.ConvertO(bodyprofiles);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<XLStoTXTResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<XLStoXMLResponse> XLStoXML(Expression<Func<string>> bodyurl, Expression<Func<string>> bodyworksheetIndex = null, Expression<Func<string>> bodyname = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<bool>> bodyasync = null, Expression<Func<string>> bodyprofiles = null)
        {
            var apiCallPath = "/v1/xls/convert/to/xml";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["url"] = ExpressionConverter.ConvertO(bodyurl);
            if (bodyworksheetIndex != null)
            {
                body["worksheetIndex"] = ExpressionConverter.ConvertO(bodyworksheetIndex);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodyexpiration != null)
            {
                body["expiration"] = ExpressionConverter.ConvertO(bodyexpiration);
                bodypropCount++;
            }

            if (bodyasync != null)
            {
                body["async"] = ExpressionConverter.ConvertO(bodyasync);
                bodypropCount++;
            }

            if (bodyprofiles != null)
            {
                body["profiles"] = ExpressionConverter.ConvertO(bodyprofiles);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<XLStoXMLResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFRotatePagesResponse> PDFRotatePages(Expression<Func<string>> bodyurl, Expression<Func<bodyangleInput>> bodyangle = null, Expression<Func<string>> bodypages = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<string>> bodypassword = null, Expression<Func<string>> bodyprofiles = null, Expression<Func<bool>> bodyasync = null)
        {
            var apiCallPath = "/v1/pdf/edit/rotate";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["url"] = ExpressionConverter.ConvertO(bodyurl);
            if (bodyangle != null)
            {
                body["angle"] = ExpressionConverter.ConvertO(bodyangle);
                bodypropCount++;
            }

            if (bodypages != null)
            {
                body["pages"] = ExpressionConverter.ConvertO(bodypages);
                bodypropCount++;
            }

            if (bodyexpiration != null)
            {
                body["expiration"] = ExpressionConverter.ConvertO(bodyexpiration);
                bodypropCount++;
            }

            if (bodypassword != null)
            {
                body["password"] = ExpressionConverter.ConvertO(bodypassword);
                bodypropCount++;
            }

            if (bodyprofiles != null)
            {
                body["profiles"] = ExpressionConverter.ConvertO(bodyprofiles);
                bodypropCount++;
            }

            if (bodyasync != null)
            {
                body["async"] = ExpressionConverter.ConvertO(bodyasync);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PDFRotatePagesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFAutoRotatePagesResponse> PDFAutoRotatePages(Expression<Func<string>> bodyurl, Expression<Func<string>> bodylang = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<string>> bodypassword = null, Expression<Func<string>> bodyprofiles = null, Expression<Func<bool>> bodyasync = null)
        {
            var apiCallPath = "/v1/pdf/edit/rotate/auto";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["url"] = ExpressionConverter.ConvertO(bodyurl);
            if (bodylang != null)
            {
                body["lang"] = ExpressionConverter.ConvertO(bodylang);
                bodypropCount++;
            }

            if (bodyexpiration != null)
            {
                body["expiration"] = ExpressionConverter.ConvertO(bodyexpiration);
                bodypropCount++;
            }

            if (bodypassword != null)
            {
                body["password"] = ExpressionConverter.ConvertO(bodypassword);
                bodypropCount++;
            }

            if (bodyprofiles != null)
            {
                body["profiles"] = ExpressionConverter.ConvertO(bodyprofiles);
                bodypropCount++;
            }

            if (bodyasync != null)
            {
                body["async"] = ExpressionConverter.ConvertO(bodyasync);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PDFAutoRotatePagesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFDeletePagesResponse> PDFDeletePages(Expression<Func<string>> bodyurl, Expression<Func<string>> bodypages = null, Expression<Func<string>> bodyname = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<string>> bodyprofiles = null, Expression<Func<bool>> bodyasync = null)
        {
            var apiCallPath = "/v1/pdf/edit/delete-pages";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["url"] = ExpressionConverter.ConvertO(bodyurl);
            if (bodypages != null)
            {
                body["pages"] = ExpressionConverter.ConvertO(bodypages);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodyexpiration != null)
            {
                body["expiration"] = ExpressionConverter.ConvertO(bodyexpiration);
                bodypropCount++;
            }

            if (bodyprofiles != null)
            {
                body["profiles"] = ExpressionConverter.ConvertO(bodyprofiles);
                bodypropCount++;
            }

            if (bodyasync != null)
            {
                body["async"] = ExpressionConverter.ConvertO(bodyasync);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PDFDeletePagesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFCompressResponse> PDFCompress(Expression<Func<string>> bodyurl, Expression<Func<string>> bodyname = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<string>> bodypassword = null, Expression<Func<string>> bodyprofiles = null, Expression<Func<bool>> bodyasync = null)
        {
            var apiCallPath = "/v1/pdf/optimize";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["url"] = ExpressionConverter.ConvertO(bodyurl);
            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodyexpiration != null)
            {
                body["expiration"] = ExpressionConverter.ConvertO(bodyexpiration);
                bodypropCount++;
            }

            if (bodypassword != null)
            {
                body["password"] = ExpressionConverter.ConvertO(bodypassword);
                bodypropCount++;
            }

            if (bodyprofiles != null)
            {
                body["profiles"] = ExpressionConverter.ConvertO(bodyprofiles);
                bodypropCount++;
            }

            if (bodyasync != null)
            {
                body["async"] = ExpressionConverter.ConvertO(bodyasync);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PDFCompressResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFClassifierResponse> PDFClassifier(Expression<Func<string>> bodyurl, Expression<Func<string>> bodyrulescsv = null, Expression<Func<string>> bodyrulescsvurl = null, Expression<Func<bool>> bodycaseSensitive = null, Expression<Func<bool>> bodyinline = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<string>> bodypassword = null, Expression<Func<string>> bodyprofiles = null, Expression<Func<bool>> bodyasync = null)
        {
            var apiCallPath = "/v1/pdf/classifier";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["url"] = ExpressionConverter.ConvertO(bodyurl);
            if (bodyrulescsv != null)
            {
                body["rulescsv"] = ExpressionConverter.ConvertO(bodyrulescsv);
                bodypropCount++;
            }

            if (bodyrulescsvurl != null)
            {
                body["rulescsvurl"] = ExpressionConverter.ConvertO(bodyrulescsvurl);
                bodypropCount++;
            }

            if (bodycaseSensitive != null)
            {
                body["caseSensitive"] = ExpressionConverter.ConvertO(bodycaseSensitive);
                bodypropCount++;
            }

            if (bodyinline != null)
            {
                body["inline"] = ExpressionConverter.ConvertO(bodyinline);
                bodypropCount++;
            }

            if (bodyexpiration != null)
            {
                body["expiration"] = ExpressionConverter.ConvertO(bodyexpiration);
                bodypropCount++;
            }

            if (bodypassword != null)
            {
                body["password"] = ExpressionConverter.ConvertO(bodypassword);
                bodypropCount++;
            }

            if (bodyprofiles != null)
            {
                body["profiles"] = ExpressionConverter.ConvertO(bodyprofiles);
                bodypropCount++;
            }

            if (bodyasync != null)
            {
                body["async"] = ExpressionConverter.ConvertO(bodyasync);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PDFClassifierResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<EmailSendResponse> EmailSend(Expression<Func<string>> bodyurl, Expression<Func<string>> bodyfrom, Expression<Func<string>> bodyto, Expression<Func<string>> bodysubject, Expression<Func<string>> bodysmtpserver, Expression<Func<string>> bodysmtpport, Expression<Func<string>> bodysmtpusername, Expression<Func<string>> bodysmtppassword, Expression<Func<string>> bodybodytext = null, Expression<Func<string>> bodybodyhtml = null, Expression<Func<string>> bodyprofiles = null, Expression<Func<bool>> bodyasync = null)
        {
            var apiCallPath = "/v1/email/send";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["url"] = ExpressionConverter.ConvertO(bodyurl);
            bodypropCount++;
            body["from"] = ExpressionConverter.ConvertO(bodyfrom);
            bodypropCount++;
            body["to"] = ExpressionConverter.ConvertO(bodyto);
            bodypropCount++;
            body["subject"] = ExpressionConverter.ConvertO(bodysubject);
            if (bodybodytext != null)
            {
                body["bodytext"] = ExpressionConverter.ConvertO(bodybodytext);
                bodypropCount++;
            }

            if (bodybodyhtml != null)
            {
                body["bodyhtml"] = ExpressionConverter.ConvertO(bodybodyhtml);
                bodypropCount++;
            }

            bodypropCount++;
            body["smtpserver"] = ExpressionConverter.ConvertO(bodysmtpserver);
            bodypropCount++;
            body["smtpport"] = ExpressionConverter.ConvertO(bodysmtpport);
            bodypropCount++;
            body["smtpusername"] = ExpressionConverter.ConvertO(bodysmtpusername);
            bodypropCount++;
            body["smtppassword"] = ExpressionConverter.ConvertO(bodysmtppassword);
            if (bodyprofiles != null)
            {
                body["profiles"] = ExpressionConverter.ConvertO(bodyprofiles);
                bodypropCount++;
            }

            if (bodyasync != null)
            {
                body["async"] = ExpressionConverter.ConvertO(bodyasync);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<EmailSendResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<EmailDecodeResponse> EmailDecode(Expression<Func<string>> bodyurl, Expression<Func<string>> bodyprofiles = null, Expression<Func<bool>> bodyasync = null)
        {
            var apiCallPath = "/v1/email/decode";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["url"] = ExpressionConverter.ConvertO(bodyurl);
            if (bodyprofiles != null)
            {
                body["profiles"] = ExpressionConverter.ConvertO(bodyprofiles);
                bodypropCount++;
            }

            if (bodyasync != null)
            {
                body["async"] = ExpressionConverter.ConvertO(bodyasync);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<EmailDecodeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<EmailAttachmentExtractionResponse> EmailAttachmentExtraction(Expression<Func<string>> bodyurl, Expression<Func<string>> bodyprofiles = null, Expression<Func<bool>> bodyasync = null)
        {
            var apiCallPath = "/v1/email/extract-attachments";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["url"] = ExpressionConverter.ConvertO(bodyurl);
            if (bodyprofiles != null)
            {
                body["profiles"] = ExpressionConverter.ConvertO(bodyprofiles);
                bodypropCount++;
            }

            if (bodyasync != null)
            {
                body["async"] = ExpressionConverter.ConvertO(bodyasync);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<EmailAttachmentExtractionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdfco")]
        public IBodyWorkflowAction<PDFAttachmentExtractionResponse> PDFAttachmentExtraction(Expression<Func<string>> bodyurl, Expression<Func<bool>> bodyinline = null, Expression<Func<string>> bodyname = null, Expression<Func<int>> bodyexpiration = null, Expression<Func<string>> bodyprofiles = null, Expression<Func<bool>> bodyasync = null)
        {
            var apiCallPath = "/v1/pdf/attachments/extract";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["url"] = ExpressionConverter.ConvertO(bodyurl);
            if (bodyinline != null)
            {
                body["inline"] = ExpressionConverter.ConvertO(bodyinline);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodyexpiration != null)
            {
                body["expiration"] = ExpressionConverter.ConvertO(bodyexpiration);
                bodypropCount++;
            }

            if (bodyprofiles != null)
            {
                body["profiles"] = ExpressionConverter.ConvertO(bodyprofiles);
                bodypropCount++;
            }

            if (bodyasync != null)
            {
                body["async"] = ExpressionConverter.ConvertO(bodyasync);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PDFAttachmentExtractionResponse>(callPayload);
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

    public enum bodypaperSizeInput
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

    public enum bodyorientationInput
    {
        [EnumMember(Value = "")]
        None,
        Portait,
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

    public enum bodywordMatchingModeInput
    {
        [EnumMember(Value = "")]
        None,
        SmartMatch,
        ExactMatch,
        None
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

    public enum bodyoutputFormatInput
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

    public enum bodytypeInput
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

    public enum bodyunwrapInput
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

    public enum bodyencryptionAlgorithmInput
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

    public enum bodyprintQualityInput
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

    public enum bodyangleInput
    {
        [EnumMember(Value = "90")]
        _90,
        [EnumMember(Value = "180")]
        _180,
        [EnumMember(Value = "270")]
        _270
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