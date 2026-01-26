//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Plumsail
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PlumsailActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsail")]
        public IBodyWorkflowAction<ProfileInfo> ProfilesMeGet()
        {
            var apiCallPath = "/profiles/me";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ProfileInfo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsail")]
        public IBodyWorkflowAction<string> FlowV1DocumentsJobsApplyDocxTemplatePost(Expression<Func<string>> requesttemplateFile, Expression<Func<requestdocumentOutputTypeInput>> requestdocumentOutputType, Expression<Func<requestlocaleInput>> requestlocale = null, Expression<Func<requesttimeZoneInput>> requesttimeZone = null, Expression<Func<requesttemplateEngineInput>> requesttemplateEngine = null)
        {
            var apiCallPath = "/flow/v1/Documents/jobs/ApplyDocxTemplate";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["documentContent"] = ExpressionConverter.ConvertO(requesttemplateFile);
            var dataObject = new JObject();
            var dataObjectpropCount = 0;
            if (dataObjectpropCount > 0)
            {
                request["data"] = dataObject;
                requestpropCount++;
            }

            requestpropCount++;
            request["outputType"] = ExpressionConverter.ConvertO(requestdocumentOutputType);
            if (requestlocale != null)
            {
                request["locale"] = ExpressionConverter.ConvertO(requestlocale);
                requestpropCount++;
            }

            if (requesttimeZone != null)
            {
                request["timezone"] = ExpressionConverter.ConvertO(requesttimeZone);
                requestpropCount++;
            }

            if (requesttemplateEngine != null)
            {
                request["engine"] = ExpressionConverter.ConvertO(requesttemplateEngine);
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsail")]
        public IBodyWorkflowAction<string> FlowV1DocumentsJobsApplyXlsxTemplatePost(Expression<Func<string>> requesttemplateFile, Expression<Func<requestdocumentOutputTypeInput>> requestdocumentOutputType, Expression<Func<requestlocaleInput>> requestlocale = null, Expression<Func<requesttimeZoneInput>> requesttimeZone = null)
        {
            var apiCallPath = "/flow/v1/Documents/jobs/ApplyXlsxTemplate";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["documentContent"] = ExpressionConverter.ConvertO(requesttemplateFile);
            var dataObject = new JObject();
            var dataObjectpropCount = 0;
            if (dataObjectpropCount > 0)
            {
                request["data"] = dataObject;
                requestpropCount++;
            }

            requestpropCount++;
            request["outputType"] = ExpressionConverter.ConvertO(requestdocumentOutputType);
            if (requestlocale != null)
            {
                request["locale"] = ExpressionConverter.ConvertO(requestlocale);
                requestpropCount++;
            }

            if (requesttimeZone != null)
            {
                request["timezone"] = ExpressionConverter.ConvertO(requesttimeZone);
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsail")]
        public IBodyWorkflowAction<DocumentProcessingResponse> FlowV1DocumentsJobsApplyPptxPost(Expression<Func<string>> requesttemplateFile, Expression<Func<requestdocumentOutputTypeInput>> requestdocumentOutputType, Expression<Func<requestlocaleInput>> requestlocale = null, Expression<Func<requesttimeZoneInput>> requesttimeZone = null)
        {
            var apiCallPath = "/flow/v1/Documents/jobs/ApplyPptx";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["documentContent"] = ExpressionConverter.ConvertO(requesttemplateFile);
            var dataObject = new JObject();
            var dataObjectpropCount = 0;
            if (dataObjectpropCount > 0)
            {
                request["data"] = dataObject;
                requestpropCount++;
            }

            requestpropCount++;
            request["outputType"] = ExpressionConverter.ConvertO(requestdocumentOutputType);
            if (requestlocale != null)
            {
                request["locale"] = ExpressionConverter.ConvertO(requestlocale);
                requestpropCount++;
            }

            if (requesttimeZone != null)
            {
                request["timezone"] = ExpressionConverter.ConvertO(requesttimeZone);
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<DocumentProcessingResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsail")]
        public IBodyWorkflowAction<DocumentProcessingResponse> FlowV1DocumentsJobsApplyDocxPost(Expression<Func<string>> requestdOCXDocumentContent)
        {
            var apiCallPath = "/flow/v1/Documents/jobs/ApplyDocx";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["docxDocument"] = ExpressionConverter.ConvertO(requestdOCXDocumentContent);
            var dataObject = new JObject();
            var dataObjectpropCount = 0;
            if (dataObjectpropCount > 0)
            {
                request["data"] = dataObject;
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<DocumentProcessingResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsail")]
        public IBodyWorkflowAction<ApplyHtmlTemplateResponse> FlowV1DocumentsJobsApplyHtmlPost(Expression<Func<string>> requestsourceHTML, Expression<Func<requestlocaleInput>> requestlocale = null, Expression<Func<requesttimeZoneInput>> requesttimeZone = null)
        {
            var apiCallPath = "/flow/v1/Documents/jobs/ApplyHtml";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["html"] = ExpressionConverter.ConvertO(requestsourceHTML);
            var dataObject = new JObject();
            var dataObjectpropCount = 0;
            if (dataObjectpropCount > 0)
            {
                request["data"] = dataObject;
                requestpropCount++;
            }

            if (requestlocale != null)
            {
                request["locale"] = ExpressionConverter.ConvertO(requestlocale);
                requestpropCount++;
            }

            if (requesttimeZone != null)
            {
                request["timezone"] = ExpressionConverter.ConvertO(requesttimeZone);
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<ApplyHtmlTemplateResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsail")]
        public IBodyWorkflowAction<DocumentProcessingResponse> FlowV1DocumentsJobsHtml2PdfPost(Expression<Func<string>> requestsourceHTML, Expression<Func<requestengineInput>> requestengine = null, Expression<Func<requestpaperSizeInput>> requestpaperSize = null, Expression<Func<requestorientationInput>> requestorientation = null, Expression<Func<string>> requestmargins = null, Expression<Func<string>> requestheaderHTML = null, Expression<Func<string>> requestfooterHTML = null)
        {
            var apiCallPath = "/flow/v1/Documents/jobs/Html2Pdf";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["html"] = ExpressionConverter.ConvertO(requestsourceHTML);
            if (requestengine != null)
            {
                request["engine"] = ExpressionConverter.ConvertO(requestengine);
                requestpropCount++;
            }

            if (requestpaperSize != null)
            {
                request["size"] = ExpressionConverter.ConvertO(requestpaperSize);
                requestpropCount++;
            }

            if (requestorientation != null)
            {
                request["orientation"] = ExpressionConverter.ConvertO(requestorientation);
                requestpropCount++;
            }

            if (requestmargins != null)
            {
                request["margins"] = ExpressionConverter.ConvertO(requestmargins);
                requestpropCount++;
            }

            if (requestheaderHTML != null)
            {
                request["headerHtml"] = ExpressionConverter.ConvertO(requestheaderHTML);
                requestpropCount++;
            }

            if (requestfooterHTML != null)
            {
                request["footerHtml"] = ExpressionConverter.ConvertO(requestfooterHTML);
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<DocumentProcessingResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsail")]
        public IBodyWorkflowAction<DocumentProcessingResponse> FlowV1DocumentsJobsHtml2DocxPost(Expression<Func<string>> requestfileContent = null, Expression<Func<string>> requesthTMLData = null, Expression<Func<string>> requesthTMLURL = null, Expression<Func<requestpaperSizeInput>> requestpaperSize = null, Expression<Func<requestorientationInput>> requestorientation = null, Expression<Func<bool>> requestdecodeHTML = null, Expression<Func<string>> requestmargins = null)
        {
            var apiCallPath = "/flow/v1/Documents/jobs/Html2Docx";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            if (requestfileContent != null)
            {
                request["fileContent"] = ExpressionConverter.ConvertO(requestfileContent);
                requestpropCount++;
            }

            if (requesthTMLData != null)
            {
                request["rawHtml"] = ExpressionConverter.ConvertO(requesthTMLData);
                requestpropCount++;
            }

            if (requesthTMLURL != null)
            {
                request["htmlUrl"] = ExpressionConverter.ConvertO(requesthTMLURL);
                requestpropCount++;
            }

            if (requestpaperSize != null)
            {
                request["paperSize"] = ExpressionConverter.ConvertO(requestpaperSize);
                requestpropCount++;
            }

            if (requestorientation != null)
            {
                request["orientation"] = ExpressionConverter.ConvertO(requestorientation);
                requestpropCount++;
            }

            if (requestdecodeHTML != null)
            {
                request["decodeHtml"] = ExpressionConverter.ConvertO(requestdecodeHTML);
                requestpropCount++;
            }

            if (requestmargins != null)
            {
                request["margins"] = ExpressionConverter.ConvertO(requestmargins);
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<DocumentProcessingResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsail")]
        public IBodyWorkflowAction<DocumentProcessingResponse> FlowV1DocumentsJobsDocx2PdfPost(Expression<Func<string>> requestdocumentContent)
        {
            var apiCallPath = "/flow/v1/Documents/jobs/Docx2Pdf";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["documentContent"] = ExpressionConverter.ConvertO(requestdocumentContent);
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<DocumentProcessingResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsail")]
        public IBodyWorkflowAction<string> FlowV1DocumentsJobsXslx2PdfPost(Expression<Func<string>> requestdocumentContent)
        {
            var apiCallPath = "/flow/v1/Documents/jobs/Xslx2Pdf";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["documentContent"] = ExpressionConverter.ConvertO(requestdocumentContent);
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsail")]
        public IBodyWorkflowAction<string> FlowV1DocumentsJobsPptx2PdfPost(Expression<Func<string>> requestdocumentContent)
        {
            var apiCallPath = "/flow/v1/Documents/jobs/Pptx2Pdf";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["documentContent"] = ExpressionConverter.ConvertO(requestdocumentContent);
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsail")]
        public IBodyWorkflowAction<string> FlowV1DocumentsJobsAny2PdfPost(Expression<Func<string>> requestdocumentContent, Expression<Func<string>> requestfilename)
        {
            var apiCallPath = "/flow/v1/Documents/jobs/Any2Pdf";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["documentContent"] = ExpressionConverter.ConvertO(requestdocumentContent);
            requestpropCount++;
            request["filename"] = ExpressionConverter.ConvertO(requestfilename);
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsail")]
        public IBodyWorkflowAction<string> FlowV1DocumentsJobsEmail2PdfPost(Expression<Func<string>> requestemailContent, Expression<Func<bool>> requestmergeAttachments)
        {
            var apiCallPath = "/flow/v1/Documents/jobs/Email2Pdf";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["documentContent"] = ExpressionConverter.ConvertO(requestemailContent);
            requestpropCount++;
            request["mergeAttachments"] = ExpressionConverter.ConvertO(requestmergeAttachments);
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsail")]
        public IBodyWorkflowAction<string> FlowV1DocumentsJobsDoc2DocxPost(Expression<Func<string>> requestdocumentContent)
        {
            var apiCallPath = "/flow/v1/Documents/jobs/Doc2Docx";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["documentContent"] = ExpressionConverter.ConvertO(requestdocumentContent);
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsail")]
        public IBodyWorkflowAction<string> FlowV1DocumentsJobsXls2XlsxPost(Expression<Func<string>> requestdocumentContent)
        {
            var apiCallPath = "/flow/v1/Documents/jobs/Xls2Xlsx";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["documentContent"] = ExpressionConverter.ConvertO(requestdocumentContent);
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsail")]
        public IBodyWorkflowAction<string> FlowV1DocumentsJobsPpt2PptxPost(Expression<Func<string>> requestdocumentContent)
        {
            var apiCallPath = "/flow/v1/Documents/jobs/Ppt2Pptx";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["documentContent"] = ExpressionConverter.ConvertO(requestdocumentContent);
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsail")]
        public IBodyWorkflowAction<DocumentsWithFilenamesResponse> FlowV1DocumentsJobsSplitPdfV2Post(Expression<Func<typeInput>> type, Expression<Func<object>> request = null)
        {
            var apiCallPath = "/flow/v1/Documents/jobs/SplitPdfV2";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["type"] = ExpressionConverter.Convert(type);
            callPayload.Body = ExpressionConverter.ConvertO(request);
            return new ApiConnectionAction<DocumentsWithFilenamesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsail")]
        public IBodyWorkflowAction<string> FlowV1DocumentsJobsMergeAnyToPdfPost(Expression<Func<MergeAny2PdfFileData[]>> requestfiles, Expression<Func<bool>> requestgenerateBookmarks = null, Expression<Func<bool>> requestpreserveBookmarks = null)
        {
            var apiCallPath = "/flow/v1/Documents/jobs/MergeAnyToPdf";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["files"] = ExpressionConverter.ConvertO(requestfiles);
            if (requestgenerateBookmarks != null)
            {
                request["generateBookmarks"] = ExpressionConverter.ConvertO(requestgenerateBookmarks);
                requestpropCount++;
            }

            if (requestpreserveBookmarks != null)
            {
                request["preserveBookmarks"] = ExpressionConverter.ConvertO(requestpreserveBookmarks);
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsail")]
        public IBodyWorkflowAction<DocumentProcessingResponse> FlowV1DocumentsJobsExtractTextFromPdfPost(Expression<Func<string>> requestdocumentContent, Expression<Func<int>> requeststartPage = null, Expression<Func<int>> requestendPage = null, Expression<Func<requestresultTypeInput>> requestresultType = null, Expression<Func<string>> requestpassword = null)
        {
            var apiCallPath = "/flow/v1/Documents/jobs/ExtractTextFromPdf";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["documentContent"] = ExpressionConverter.ConvertO(requestdocumentContent);
            if (requeststartPage != null)
            {
                request["startPage"] = ExpressionConverter.ConvertO(requeststartPage);
                requestpropCount++;
            }

            if (requestendPage != null)
            {
                request["endPage"] = ExpressionConverter.ConvertO(requestendPage);
                requestpropCount++;
            }

            if (requestresultType != null)
            {
                request["resultType"] = ExpressionConverter.ConvertO(requestresultType);
                requestpropCount++;
            }

            if (requestpassword != null)
            {
                request["password"] = ExpressionConverter.ConvertO(requestpassword);
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<DocumentProcessingResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsail")]
        public IBodyWorkflowAction<DocumentsWithFilenamesResponse> FlowV1DocumentsJobsPdf2ImageV2Post(Expression<Func<string>> requestdocumentContent, Expression<Func<string>> requestfilenamePrefix = null, Expression<Func<int>> requeststartPage = null, Expression<Func<int>> requestendPage = null, Expression<Func<string>> requestpages = null, Expression<Func<requestimageFormatInput>> requestimageFormat = null, Expression<Func<int>> requestdPI = null, Expression<Func<string>> requestpassword = null)
        {
            var apiCallPath = "/flow/v1/Documents/jobs/Pdf2ImageV2";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["documentContent"] = ExpressionConverter.ConvertO(requestdocumentContent);
            if (requestfilenamePrefix != null)
            {
                request["filenamePrefix"] = ExpressionConverter.ConvertO(requestfilenamePrefix);
                requestpropCount++;
            }

            if (requeststartPage != null)
            {
                request["startPage"] = ExpressionConverter.ConvertO(requeststartPage);
                requestpropCount++;
            }

            if (requestendPage != null)
            {
                request["endPage"] = ExpressionConverter.ConvertO(requestendPage);
                requestpropCount++;
            }

            if (requestpages != null)
            {
                request["pages"] = ExpressionConverter.ConvertO(requestpages);
                requestpropCount++;
            }

            if (requestimageFormat != null)
            {
                request["format"] = ExpressionConverter.ConvertO(requestimageFormat);
                requestpropCount++;
            }

            if (requestdPI != null)
            {
                request["dpi"] = ExpressionConverter.ConvertO(requestdPI);
                requestpropCount++;
            }

            if (requestpassword != null)
            {
                request["password"] = ExpressionConverter.ConvertO(requestpassword);
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<DocumentsWithFilenamesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsail")]
        public IBodyWorkflowAction<string> FlowV1DocumentsJobsImage2PdfPost(Expression<Func<string[]>> requestimageContent, Expression<Func<bool>> requestsingleImagePerPage = null)
        {
            var apiCallPath = "/flow/v1/Documents/jobs/Image2Pdf";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            if (requestsingleImagePerPage != null)
            {
                request["imagePerPage"] = ExpressionConverter.ConvertO(requestsingleImagePerPage);
                requestpropCount++;
            }

            requestpropCount++;
            request["imageContent"] = ExpressionConverter.ConvertO(requestimageContent);
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsail")]
        public IBodyWorkflowAction<DocumentProcessingResponse> FlowV1DocumentsJobsFillInPdfFormPost(Expression<Func<string>> requestdocumentContent, Expression<Func<bool>> requestlockFormFields = null, Expression<Func<string>> requestpassword = null)
        {
            var apiCallPath = "/flow/v1/Documents/jobs/FillInPdfForm";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["documentContent"] = ExpressionConverter.ConvertO(requestdocumentContent);
            var jsonDataObject = new JObject();
            var jsonDataObjectpropCount = 0;
            if (jsonDataObjectpropCount > 0)
            {
                request["jsonData"] = jsonDataObject;
                requestpropCount++;
            }

            if (requestlockFormFields != null)
            {
                request["lockFormFields"] = ExpressionConverter.ConvertO(requestlockFormFields);
                requestpropCount++;
            }

            if (requestpassword != null)
            {
                request["password"] = ExpressionConverter.ConvertO(requestpassword);
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<DocumentProcessingResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsail")]
        public IBodyWorkflowAction<JToken> FlowV1DocumentsJobsGetPdfFormPost(Expression<Func<string>> requestdocumentContent, Expression<Func<string>> requestpassword = null)
        {
            var apiCallPath = "/flow/v1/Documents/jobs/GetPdfForm";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["documentContent"] = ExpressionConverter.ConvertO(requestdocumentContent);
            if (requestpassword != null)
            {
                request["password"] = ExpressionConverter.ConvertO(requestpassword);
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsail")]
        public IBodyWorkflowAction<DocumentProcessingResponse> FlowV1DocumentsJobsProtectPdfPost(Expression<Func<string>> requestdocumentContent, Expression<Func<bool>> requestenablePrinting, Expression<Func<bool>> requestenableModification, Expression<Func<bool>> requestenableExtractData, Expression<Func<bool>> requestenableAnnotate, Expression<Func<string>> requestpDFOwnerPassword = null, Expression<Func<string>> requestpDFUserPassword = null, Expression<Func<string>> requestpassword = null)
        {
            var apiCallPath = "/flow/v1/Documents/jobs/ProtectPdf";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["documentContent"] = ExpressionConverter.ConvertO(requestdocumentContent);
            requestpropCount++;
            request["allowPrinting"] = ExpressionConverter.ConvertO(requestenablePrinting);
            requestpropCount++;
            request["allowModification"] = ExpressionConverter.ConvertO(requestenableModification);
            requestpropCount++;
            request["allowExtract"] = ExpressionConverter.ConvertO(requestenableExtractData);
            requestpropCount++;
            request["allowAnnotate"] = ExpressionConverter.ConvertO(requestenableAnnotate);
            if (requestpDFOwnerPassword != null)
            {
                request["newOwnerPassword"] = ExpressionConverter.ConvertO(requestpDFOwnerPassword);
                requestpropCount++;
            }

            if (requestpDFUserPassword != null)
            {
                request["newUserPassword"] = ExpressionConverter.ConvertO(requestpDFUserPassword);
                requestpropCount++;
            }

            if (requestpassword != null)
            {
                request["password"] = ExpressionConverter.ConvertO(requestpassword);
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<DocumentProcessingResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsail")]
        public IBodyWorkflowAction<GetPdfProtectionInfoResponse> FlowV1DocumentsJobsGetPdfProtectionInfoPost(Expression<Func<string>> requestdocumentContent)
        {
            var apiCallPath = "/flow/v1/Documents/jobs/GetPdfProtectionInfo";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["documentContent"] = ExpressionConverter.ConvertO(requestdocumentContent);
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<GetPdfProtectionInfoResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsail")]
        public IBodyWorkflowAction<string> FlowV1DocumentsJobsCompressPdfPost(Expression<Func<string>> requestdocumentContent, Expression<Func<requestlosslessModeInput>> requestlosslessMode = null, Expression<Func<string>> requestpassword = null)
        {
            var apiCallPath = "/flow/v1/Documents/jobs/CompressPdf";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["documentContent"] = ExpressionConverter.ConvertO(requestdocumentContent);
            if (requestlosslessMode != null)
            {
                request["losslessMode"] = ExpressionConverter.ConvertO(requestlosslessMode);
                requestpropCount++;
            }

            if (requestpassword != null)
            {
                request["password"] = ExpressionConverter.ConvertO(requestpassword);
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsail")]
        public IBodyWorkflowAction<DocumentProcessingResponse> FlowV1DocumentsJobsAddWatermarkToPdfPost(Expression<Func<typeInput>> type, Expression<Func<object>> request = null)
        {
            var apiCallPath = "/flow/v1/Documents/jobs/AddWatermarkToPdf";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["type"] = ExpressionConverter.Convert(type);
            callPayload.Body = ExpressionConverter.ConvertO(request);
            return new ApiConnectionAction<DocumentProcessingResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsail")]
        public IBodyWorkflowAction<DocumentProcessingResponse> FlowV1DocumentsJobsMergeDocxPost(Expression<Func<string[]>> requestcontent, Expression<Func<bool>> requestapplyHeaderAndFooter)
        {
            var apiCallPath = "/flow/v1/Documents/jobs/MergeDocx";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["documentsContents"] = ExpressionConverter.ConvertO(requestcontent);
            requestpropCount++;
            request["applyHeaderAndFooter"] = ExpressionConverter.ConvertO(requestapplyHeaderAndFooter);
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<DocumentProcessingResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsail")]
        public IBodyWorkflowAction<JToken> FlowV1DocumentsJobsParseCsvPost(Expression<Func<string>> requestcontentOfCSVDocument, Expression<Func<string>> requestheaders, Expression<Func<requestdelimiterInput>> requestdelimiter = null, Expression<Func<requestlocaleInput>> requestlocale = null, Expression<Func<int>> requestlimit = null, Expression<Func<bool>> requestskipFirstLine = null)
        {
            var apiCallPath = "/flow/v1/Documents/jobs/ParseCsv";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["content"] = ExpressionConverter.ConvertO(requestcontentOfCSVDocument);
            if (requestdelimiter != null)
            {
                request["delimiter"] = ExpressionConverter.ConvertO(requestdelimiter);
                requestpropCount++;
            }

            if (requestlocale != null)
            {
                request["locale"] = ExpressionConverter.ConvertO(requestlocale);
                requestpropCount++;
            }

            if (requestlimit != null)
            {
                request["limit"] = ExpressionConverter.ConvertO(requestlimit);
                requestpropCount++;
            }

            requestpropCount++;
            request["headers"] = ExpressionConverter.ConvertO(requestheaders);
            if (requestskipFirstLine != null)
            {
                request["skipFirstLine"] = ExpressionConverter.ConvertO(requestskipFirstLine);
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsail")]
        public IBodyWorkflowAction<string> FlowV1DocumentsJobsCsv2XlsxPost(Expression<Func<string>> requestcontentOfCSVDocument, Expression<Func<requestdelimiterInput>> requestdelimiter = null, Expression<Func<requestlocaleInput>> requestlocale = null, Expression<Func<int>> requestlimit = null, Expression<Func<bool>> requestuseFirstLineAsHeaders = null, Expression<Func<Csv2XlsxColumnMapping[]>> requestmappings = null)
        {
            var apiCallPath = "/flow/v1/Documents/jobs/Csv2Xlsx";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["content"] = ExpressionConverter.ConvertO(requestcontentOfCSVDocument);
            if (requestdelimiter != null)
            {
                request["delimiter"] = ExpressionConverter.ConvertO(requestdelimiter);
                requestpropCount++;
            }

            if (requestlocale != null)
            {
                request["locale"] = ExpressionConverter.ConvertO(requestlocale);
                requestpropCount++;
            }

            if (requestlimit != null)
            {
                request["limit"] = ExpressionConverter.ConvertO(requestlimit);
                requestpropCount++;
            }

            if (requestuseFirstLineAsHeaders != null)
            {
                request["hasHeaderRecords"] = ExpressionConverter.ConvertO(requestuseFirstLineAsHeaders);
                requestpropCount++;
            }

            if (requestmappings != null)
            {
                request["mappings"] = ExpressionConverter.ConvertO(requestmappings);
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsail")]
        public IBodyWorkflowAction<string> FlowV1DocumentsJobsJson2XlsxPost(Expression<Func<string>> requestjSONFileContent = null, Expression<Func<string>> requestjSONData = null, Expression<Func<requestlocaleInput>> requestlocale = null, Expression<Func<string>> requestpathToJSONArray = null, Expression<Func<Json2XlsxColumnMapping[]>> requestmappings = null)
        {
            var apiCallPath = "/flow/v1/Documents/jobs/Json2Xlsx";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            if (requestjSONFileContent != null)
            {
                request["content"] = ExpressionConverter.ConvertO(requestjSONFileContent);
                requestpropCount++;
            }

            if (requestjSONData != null)
            {
                request["jsonData"] = ExpressionConverter.ConvertO(requestjSONData);
                requestpropCount++;
            }

            if (requestlocale != null)
            {
                request["locale"] = ExpressionConverter.ConvertO(requestlocale);
                requestpropCount++;
            }

            if (requestpathToJSONArray != null)
            {
                request["pathToJsonArray"] = ExpressionConverter.ConvertO(requestpathToJSONArray);
                requestpropCount++;
            }

            if (requestmappings != null)
            {
                request["mappings"] = ExpressionConverter.ConvertO(requestmappings);
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsail")]
        public IBodyWorkflowAction<string> FlowV1DocumentsJobsJson2CsvPost(Expression<Func<string>> requestjSONFileContent = null, Expression<Func<string>> requestjSONData = null, Expression<Func<requestlocaleInput>> requestlocale = null, Expression<Func<string>> requestpathToJSONArray = null, Expression<Func<requestdelimiterInput>> requestdelimiter = null)
        {
            var apiCallPath = "/flow/v1/Documents/jobs/Json2Csv";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            if (requestjSONFileContent != null)
            {
                request["content"] = ExpressionConverter.ConvertO(requestjSONFileContent);
                requestpropCount++;
            }

            if (requestjSONData != null)
            {
                request["jsonData"] = ExpressionConverter.ConvertO(requestjSONData);
                requestpropCount++;
            }

            if (requestlocale != null)
            {
                request["locale"] = ExpressionConverter.ConvertO(requestlocale);
                requestpropCount++;
            }

            if (requestpathToJSONArray != null)
            {
                request["pathToJsonArray"] = ExpressionConverter.ConvertO(requestpathToJSONArray);
                requestpropCount++;
            }

            if (requestdelimiter != null)
            {
                request["delimiter"] = ExpressionConverter.ConvertO(requestdelimiter);
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsail")]
        public IBodyWorkflowAction<JToken> FlowV1DocumentsJobsRegExpMatchPost(Expression<Func<string>> requestpattern, Expression<Func<string>> requesttext)
        {
            var apiCallPath = "/flow/v1/Documents/jobs/RegExpMatch";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["pattern"] = ExpressionConverter.ConvertO(requestpattern);
            requestpropCount++;
            request["text"] = ExpressionConverter.ConvertO(requesttext);
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsail")]
        public IBodyWorkflowAction<StringResultResponse> FlowV1DocumentsJobsRegExpReplacePost(Expression<Func<string>> requestpattern, Expression<Func<string>> requesttext, Expression<Func<string>> requestreplacement = null)
        {
            var apiCallPath = "/flow/v1/Documents/jobs/RegExpReplace";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["pattern"] = ExpressionConverter.ConvertO(requestpattern);
            requestpropCount++;
            request["text"] = ExpressionConverter.ConvertO(requesttext);
            if (requestreplacement != null)
            {
                request["replacement"] = ExpressionConverter.ConvertO(requestreplacement);
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<StringResultResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsail")]
        public IBodyWorkflowAction<BooleanResultResponse> FlowV1DocumentsJobsRegExpTestPost(Expression<Func<string>> requestpattern, Expression<Func<string>> requesttext)
        {
            var apiCallPath = "/flow/v1/Documents/jobs/RegExpTest";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["pattern"] = ExpressionConverter.ConvertO(requestpattern);
            requestpropCount++;
            request["text"] = ExpressionConverter.ConvertO(requesttext);
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<BooleanResultResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsail")]
        public IBodyWorkflowAction<DocumentContentWithFilenameResponse> FlowV1DocumentsJobsCreateArchivePost(Expression<Func<string>> requestfileName, Expression<Func<FileData[]>> requestdocuments, Expression<Func<string>> requestpassword = null)
        {
            var apiCallPath = "/flow/v1/Documents/jobs/CreateArchive";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["fileName"] = ExpressionConverter.ConvertO(requestfileName);
            requestpropCount++;
            request["data"] = ExpressionConverter.ConvertO(requestdocuments);
            if (requestpassword != null)
            {
                request["password"] = ExpressionConverter.ConvertO(requestpassword);
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<DocumentContentWithFilenameResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsail")]
        public IBodyWorkflowAction<DocumentsWithFilenamesResponse> FlowV1DocumentsJobsExtractArchivePost(Expression<Func<string>> requestarchiveFile = null, Expression<Func<bool>> requestincludeFolders = null, Expression<Func<string>> requestpassword = null)
        {
            var apiCallPath = "/flow/v1/Documents/jobs/ExtractArchive";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            if (requestarchiveFile != null)
            {
                request["fileContent"] = ExpressionConverter.ConvertO(requestarchiveFile);
                requestpropCount++;
            }

            if (requestincludeFolders != null)
            {
                request["includeFolders"] = ExpressionConverter.ConvertO(requestincludeFolders);
                requestpropCount++;
            }

            if (requestpassword != null)
            {
                request["password"] = ExpressionConverter.ConvertO(requestpassword);
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<DocumentsWithFilenamesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsail")]
        public IBodyWorkflowAction<DocumentProcessingResponse> FlowV1DocumentsJobsMergeXlsxPost(Expression<Func<string[]>> requestcontent)
        {
            var apiCallPath = "/flow/v1/Documents/jobs/MergeXlsx";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["documentsContents"] = ExpressionConverter.ConvertO(requestcontent);
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<DocumentProcessingResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsail")]
        public IBodyWorkflowAction<string> FlowV1ProcessesFlowJobsExecuteProcessPost(Expression<Func<string>> processId)
        {
            var apiCallPath = "/flow/v1/ProcessesFlow/jobs/ExecuteProcess";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["processId"] = ExpressionConverter.Convert(processId);
            var jsonContent = new JObject();
            var jsonContentpropCount = 0;
            if (jsonContentpropCount > 0)
            {
                callPayload.Body = jsonContent;
            }

            return new ApiConnectionAction<string>(callPayload);
        }
    }

    public class PlumsailTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger FlowV1ProcessesFlowTriggersPost(Expression<Func<string>> dataprocessName, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/flow/v1/ProcessesFlow/triggers";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var data = new JObject();
            var datapropCount = 0;
            datapropCount++;
            data["processId"] = ExpressionConverter.ConvertO(dataprocessName);
            data["hookUrl"] = "@listCallbackUrl()";
            datapropCount++;
            if (datapropCount > 0)
            {
                callPayload.Body = data;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }
    }

    public class ProfileInfo
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("licenseStatus")]
        public string LicenseStatus { get; set; }

        [JsonProperty("teamName")]
        public string TeamName { get; set; }

        [JsonProperty("licenseInfo")]
        public LicenseInfo LicenseInfo { get; set; }

        [JsonProperty("shortUserId")]
        public string ShortUserId { get; set; }
    }

    public class LicenseInfo
    {
        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("additionalCredits")]
        public int AdditionalCredits { get; set; }

        [JsonProperty("expirationDate")]
        public string ExpirationDate { get; set; }
    }

    public enum requestdocumentOutputTypeInput
    {
        PPTX,
        PDF
    }

    public enum requestlocaleInput
    {
        [EnumMember(Value = "aa-DJ")]
        AaDJ,
        [EnumMember(Value = "aa-ER")]
        AaER,
        [EnumMember(Value = "aa-ET")]
        AaET,
        [EnumMember(Value = "af-NA")]
        AfNA,
        [EnumMember(Value = "af-ZA")]
        AfZA,
        [EnumMember(Value = "agq-CM")]
        AgqCM,
        [EnumMember(Value = "ak-GH")]
        AkGH,
        [EnumMember(Value = "am-ET")]
        AmET,
        [EnumMember(Value = "ar-001")]
        Ar001,
        [EnumMember(Value = "ar-AE")]
        ArAE,
        [EnumMember(Value = "ar-BH")]
        ArBH,
        [EnumMember(Value = "ar-DJ")]
        ArDJ,
        [EnumMember(Value = "ar-DZ")]
        ArDZ,
        [EnumMember(Value = "ar-EG")]
        ArEG,
        [EnumMember(Value = "ar-ER")]
        ArER,
        [EnumMember(Value = "ar-IL")]
        ArIL,
        [EnumMember(Value = "ar-IQ")]
        ArIQ,
        [EnumMember(Value = "ar-JO")]
        ArJO,
        [EnumMember(Value = "ar-KM")]
        ArKM,
        [EnumMember(Value = "ar-KW")]
        ArKW,
        [EnumMember(Value = "ar-LB")]
        ArLB,
        [EnumMember(Value = "ar-LY")]
        ArLY,
        [EnumMember(Value = "ar-MA")]
        ArMA,
        [EnumMember(Value = "ar-MR")]
        ArMR,
        [EnumMember(Value = "ar-OM")]
        ArOM,
        [EnumMember(Value = "ar-PS")]
        ArPS,
        [EnumMember(Value = "ar-QA")]
        ArQA,
        [EnumMember(Value = "ar-SA")]
        ArSA,
        [EnumMember(Value = "ar-SD")]
        ArSD,
        [EnumMember(Value = "ar-SO")]
        ArSO,
        [EnumMember(Value = "ar-SS")]
        ArSS,
        [EnumMember(Value = "ar-SY")]
        ArSY,
        [EnumMember(Value = "ar-TD")]
        ArTD,
        [EnumMember(Value = "ar-TN")]
        ArTN,
        [EnumMember(Value = "ar-YE")]
        ArYE,
        [EnumMember(Value = "arn-CL")]
        ArnCL,
        [EnumMember(Value = "as-IN")]
        AsIN,
        [EnumMember(Value = "asa-TZ")]
        AsaTZ,
        [EnumMember(Value = "ast-ES")]
        AstES,
        [EnumMember(Value = "az-Cyrl-AZ")]
        AzCyrlAZ,
        [EnumMember(Value = "az-Latn-AZ")]
        AzLatnAZ,
        [EnumMember(Value = "ba-RU")]
        BaRU,
        [EnumMember(Value = "bas-CM")]
        BasCM,
        [EnumMember(Value = "be-BY")]
        BeBY,
        [EnumMember(Value = "bem-ZM")]
        BemZM,
        [EnumMember(Value = "bez-TZ")]
        BezTZ,
        [EnumMember(Value = "bg-BG")]
        BgBG,
        [EnumMember(Value = "bm-ML")]
        BmML,
        [EnumMember(Value = "bn-BD")]
        BnBD,
        [EnumMember(Value = "bn-IN")]
        BnIN,
        [EnumMember(Value = "bo-CN")]
        BoCN,
        [EnumMember(Value = "bo-IN")]
        BoIN,
        [EnumMember(Value = "br-FR")]
        BrFR,
        [EnumMember(Value = "brx-IN")]
        BrxIN,
        [EnumMember(Value = "bs-Cyrl-BA")]
        BsCyrlBA,
        [EnumMember(Value = "bs-Latn-BA")]
        BsLatnBA,
        [EnumMember(Value = "byn-ER")]
        BynER,
        [EnumMember(Value = "ca-AD")]
        CaAD,
        [EnumMember(Value = "ca-ES")]
        CaES,
        [EnumMember(Value = "ca-FR")]
        CaFR,
        [EnumMember(Value = "ca-IT")]
        CaIT,
        [EnumMember(Value = "ccp-BD")]
        CcpBD,
        [EnumMember(Value = "ccp-IN")]
        CcpIN,
        [EnumMember(Value = "ce-RU")]
        CeRU,
        [EnumMember(Value = "ceb-PH")]
        CebPH,
        [EnumMember(Value = "cgg-UG")]
        CggUG,
        [EnumMember(Value = "chr-US")]
        ChrUS,
        [EnumMember(Value = "ckb-IQ")]
        CkbIQ,
        [EnumMember(Value = "ckb-IR")]
        CkbIR,
        [EnumMember(Value = "co-FR")]
        CoFR,
        [EnumMember(Value = "cs-CZ")]
        CsCZ,
        [EnumMember(Value = "cu-RU")]
        CuRU,
        [EnumMember(Value = "cy-GB")]
        CyGB,
        [EnumMember(Value = "da-DK")]
        DaDK,
        [EnumMember(Value = "da-GL")]
        DaGL,
        [EnumMember(Value = "dav-KE")]
        DavKE,
        [EnumMember(Value = "de-AT")]
        DeAT,
        [EnumMember(Value = "de-BE")]
        DeBE,
        [EnumMember(Value = "de-CH")]
        DeCH,
        [EnumMember(Value = "de-DE")]
        DeDE,
        [EnumMember(Value = "de-IT")]
        DeIT,
        [EnumMember(Value = "de-LI")]
        DeLI,
        [EnumMember(Value = "de-LU")]
        DeLU,
        [EnumMember(Value = "dje-NE")]
        DjeNE,
        [EnumMember(Value = "dsb-DE")]
        DsbDE,
        [EnumMember(Value = "dua-CM")]
        DuaCM,
        [EnumMember(Value = "dv-MV")]
        DvMV,
        [EnumMember(Value = "dyo-SN")]
        DyoSN,
        [EnumMember(Value = "dz-BT")]
        DzBT,
        [EnumMember(Value = "ebu-KE")]
        EbuKE,
        [EnumMember(Value = "ee-GH")]
        EeGH,
        [EnumMember(Value = "ee-TG")]
        EeTG,
        [EnumMember(Value = "el-CY")]
        ElCY,
        [EnumMember(Value = "el-GR")]
        ElGR,
        [EnumMember(Value = "en-001")]
        En001,
        [EnumMember(Value = "en-150")]
        En150,
        [EnumMember(Value = "en-AE")]
        EnAE,
        [EnumMember(Value = "en-AG")]
        EnAG,
        [EnumMember(Value = "en-AI")]
        EnAI,
        [EnumMember(Value = "en-AS")]
        EnAS,
        [EnumMember(Value = "en-AT")]
        EnAT,
        [EnumMember(Value = "en-AU")]
        EnAU,
        [EnumMember(Value = "en-BB")]
        EnBB,
        [EnumMember(Value = "en-BE")]
        EnBE,
        [EnumMember(Value = "en-BI")]
        EnBI,
        [EnumMember(Value = "en-BM")]
        EnBM,
        [EnumMember(Value = "en-BS")]
        EnBS,
        [EnumMember(Value = "en-BW")]
        EnBW,
        [EnumMember(Value = "en-BZ")]
        EnBZ,
        [EnumMember(Value = "en-CA")]
        EnCA,
        [EnumMember(Value = "en-CC")]
        EnCC,
        [EnumMember(Value = "en-CH")]
        EnCH,
        [EnumMember(Value = "en-CK")]
        EnCK,
        [EnumMember(Value = "en-CM")]
        EnCM,
        [EnumMember(Value = "en-CX")]
        EnCX,
        [EnumMember(Value = "en-CY")]
        EnCY,
        [EnumMember(Value = "en-DE")]
        EnDE,
        [EnumMember(Value = "en-DK")]
        EnDK,
        [EnumMember(Value = "en-DM")]
        EnDM,
        [EnumMember(Value = "en-ER")]
        EnER,
        [EnumMember(Value = "en-FI")]
        EnFI,
        [EnumMember(Value = "en-FJ")]
        EnFJ,
        [EnumMember(Value = "en-FK")]
        EnFK,
        [EnumMember(Value = "en-FM")]
        EnFM,
        [EnumMember(Value = "en-GB")]
        EnGB,
        [EnumMember(Value = "en-GD")]
        EnGD,
        [EnumMember(Value = "en-GG")]
        EnGG,
        [EnumMember(Value = "en-GH")]
        EnGH,
        [EnumMember(Value = "en-GI")]
        EnGI,
        [EnumMember(Value = "en-GM")]
        EnGM,
        [EnumMember(Value = "en-GU")]
        EnGU,
        [EnumMember(Value = "en-GY")]
        EnGY,
        [EnumMember(Value = "en-HK")]
        EnHK,
        [EnumMember(Value = "en-IE")]
        EnIE,
        [EnumMember(Value = "en-IL")]
        EnIL,
        [EnumMember(Value = "en-IM")]
        EnIM,
        [EnumMember(Value = "en-IN")]
        EnIN,
        [EnumMember(Value = "en-IO")]
        EnIO,
        [EnumMember(Value = "en-JE")]
        EnJE,
        [EnumMember(Value = "en-JM")]
        EnJM,
        [EnumMember(Value = "en-KE")]
        EnKE,
        [EnumMember(Value = "en-KI")]
        EnKI,
        [EnumMember(Value = "en-KN")]
        EnKN,
        [EnumMember(Value = "en-KY")]
        EnKY,
        [EnumMember(Value = "en-LC")]
        EnLC,
        [EnumMember(Value = "en-LR")]
        EnLR,
        [EnumMember(Value = "en-LS")]
        EnLS,
        [EnumMember(Value = "en-MG")]
        EnMG,
        [EnumMember(Value = "en-MH")]
        EnMH,
        [EnumMember(Value = "en-MO")]
        EnMO,
        [EnumMember(Value = "en-MP")]
        EnMP,
        [EnumMember(Value = "en-MS")]
        EnMS,
        [EnumMember(Value = "en-MT")]
        EnMT,
        [EnumMember(Value = "en-MU")]
        EnMU,
        [EnumMember(Value = "en-MW")]
        EnMW,
        [EnumMember(Value = "en-MY")]
        EnMY,
        [EnumMember(Value = "en-NA")]
        EnNA,
        [EnumMember(Value = "en-NF")]
        EnNF,
        [EnumMember(Value = "en-NG")]
        EnNG,
        [EnumMember(Value = "en-NL")]
        EnNL,
        [EnumMember(Value = "en-NR")]
        EnNR,
        [EnumMember(Value = "en-NU")]
        EnNU,
        [EnumMember(Value = "en-NZ")]
        EnNZ,
        [EnumMember(Value = "en-PG")]
        EnPG,
        [EnumMember(Value = "en-PH")]
        EnPH,
        [EnumMember(Value = "en-PK")]
        EnPK,
        [EnumMember(Value = "en-PN")]
        EnPN,
        [EnumMember(Value = "en-PR")]
        EnPR,
        [EnumMember(Value = "en-PW")]
        EnPW,
        [EnumMember(Value = "en-RW")]
        EnRW,
        [EnumMember(Value = "en-SB")]
        EnSB,
        [EnumMember(Value = "en-SC")]
        EnSC,
        [EnumMember(Value = "en-SD")]
        EnSD,
        [EnumMember(Value = "en-SE")]
        EnSE,
        [EnumMember(Value = "en-SG")]
        EnSG,
        [EnumMember(Value = "en-SH")]
        EnSH,
        [EnumMember(Value = "en-SI")]
        EnSI,
        [EnumMember(Value = "en-SL")]
        EnSL,
        [EnumMember(Value = "en-SS")]
        EnSS,
        [EnumMember(Value = "en-SX")]
        EnSX,
        [EnumMember(Value = "en-SZ")]
        EnSZ,
        [EnumMember(Value = "en-TC")]
        EnTC,
        [EnumMember(Value = "en-TK")]
        EnTK,
        [EnumMember(Value = "en-TO")]
        EnTO,
        [EnumMember(Value = "en-TT")]
        EnTT,
        [EnumMember(Value = "en-TV")]
        EnTV,
        [EnumMember(Value = "en-TZ")]
        EnTZ,
        [EnumMember(Value = "en-UG")]
        EnUG,
        [EnumMember(Value = "en-UM")]
        EnUM,
        [EnumMember(Value = "en-US")]
        EnUS,
        [EnumMember(Value = "en-US-POSIX")]
        EnUSPOSIX,
        [EnumMember(Value = "en-VC")]
        EnVC,
        [EnumMember(Value = "en-VG")]
        EnVG,
        [EnumMember(Value = "en-VI")]
        EnVI,
        [EnumMember(Value = "en-VU")]
        EnVU,
        [EnumMember(Value = "en-WS")]
        EnWS,
        [EnumMember(Value = "en-ZA")]
        EnZA,
        [EnumMember(Value = "en-ZM")]
        EnZM,
        [EnumMember(Value = "en-ZW")]
        EnZW,
        [EnumMember(Value = "eo-001")]
        Eo001,
        [EnumMember(Value = "es-419")]
        Es419,
        [EnumMember(Value = "es-AR")]
        EsAR,
        [EnumMember(Value = "es-BO")]
        EsBO,
        [EnumMember(Value = "es-BR")]
        EsBR,
        [EnumMember(Value = "es-BZ")]
        EsBZ,
        [EnumMember(Value = "es-CL")]
        EsCL,
        [EnumMember(Value = "es-CO")]
        EsCO,
        [EnumMember(Value = "es-CR")]
        EsCR,
        [EnumMember(Value = "es-CU")]
        EsCU,
        [EnumMember(Value = "es-DO")]
        EsDO,
        [EnumMember(Value = "es-EC")]
        EsEC,
        [EnumMember(Value = "es-ES")]
        EsES,
        [EnumMember(Value = "es-GQ")]
        EsGQ,
        [EnumMember(Value = "es-GT")]
        EsGT,
        [EnumMember(Value = "es-HN")]
        EsHN,
        [EnumMember(Value = "es-MX")]
        EsMX,
        [EnumMember(Value = "es-NI")]
        EsNI,
        [EnumMember(Value = "es-PA")]
        EsPA,
        [EnumMember(Value = "es-PE")]
        EsPE,
        [EnumMember(Value = "es-PH")]
        EsPH,
        [EnumMember(Value = "es-PR")]
        EsPR,
        [EnumMember(Value = "es-PY")]
        EsPY,
        [EnumMember(Value = "es-SV")]
        EsSV,
        [EnumMember(Value = "es-US")]
        EsUS,
        [EnumMember(Value = "es-UY")]
        EsUY,
        [EnumMember(Value = "es-VE")]
        EsVE,
        [EnumMember(Value = "et-EE")]
        EtEE,
        [EnumMember(Value = "eu-ES")]
        EuES,
        [EnumMember(Value = "ewo-CM")]
        EwoCM,
        [EnumMember(Value = "fa-AF")]
        FaAF,
        [EnumMember(Value = "fa-IR")]
        FaIR,
        [EnumMember(Value = "ff-Latn-BF")]
        FfLatnBF,
        [EnumMember(Value = "ff-Latn-CM")]
        FfLatnCM,
        [EnumMember(Value = "ff-Latn-GH")]
        FfLatnGH,
        [EnumMember(Value = "ff-Latn-GM")]
        FfLatnGM,
        [EnumMember(Value = "ff-Latn-GN")]
        FfLatnGN,
        [EnumMember(Value = "ff-Latn-GW")]
        FfLatnGW,
        [EnumMember(Value = "ff-Latn-LR")]
        FfLatnLR,
        [EnumMember(Value = "ff-Latn-MR")]
        FfLatnMR,
        [EnumMember(Value = "ff-Latn-NE")]
        FfLatnNE,
        [EnumMember(Value = "ff-Latn-NG")]
        FfLatnNG,
        [EnumMember(Value = "ff-Latn-SL")]
        FfLatnSL,
        [EnumMember(Value = "ff-Latn-SN")]
        FfLatnSN,
        [EnumMember(Value = "fi-FI")]
        FiFI,
        [EnumMember(Value = "fil-PH")]
        FilPH,
        [EnumMember(Value = "fo-DK")]
        FoDK,
        [EnumMember(Value = "fo-FO")]
        FoFO,
        [EnumMember(Value = "fr-BE")]
        FrBE,
        [EnumMember(Value = "fr-BF")]
        FrBF,
        [EnumMember(Value = "fr-BI")]
        FrBI,
        [EnumMember(Value = "fr-BJ")]
        FrBJ,
        [EnumMember(Value = "fr-BL")]
        FrBL,
        [EnumMember(Value = "fr-CA")]
        FrCA,
        [EnumMember(Value = "fr-CD")]
        FrCD,
        [EnumMember(Value = "fr-CF")]
        FrCF,
        [EnumMember(Value = "fr-CG")]
        FrCG,
        [EnumMember(Value = "fr-CH")]
        FrCH,
        [EnumMember(Value = "fr-CI")]
        FrCI,
        [EnumMember(Value = "fr-CM")]
        FrCM,
        [EnumMember(Value = "fr-DJ")]
        FrDJ,
        [EnumMember(Value = "fr-DZ")]
        FrDZ,
        [EnumMember(Value = "fr-FR")]
        FrFR,
        [EnumMember(Value = "fr-GA")]
        FrGA,
        [EnumMember(Value = "fr-GF")]
        FrGF,
        [EnumMember(Value = "fr-GN")]
        FrGN,
        [EnumMember(Value = "fr-GP")]
        FrGP,
        [EnumMember(Value = "fr-GQ")]
        FrGQ,
        [EnumMember(Value = "fr-HT")]
        FrHT,
        [EnumMember(Value = "fr-KM")]
        FrKM,
        [EnumMember(Value = "fr-LU")]
        FrLU,
        [EnumMember(Value = "fr-MA")]
        FrMA,
        [EnumMember(Value = "fr-MC")]
        FrMC,
        [EnumMember(Value = "fr-MF")]
        FrMF,
        [EnumMember(Value = "fr-MG")]
        FrMG,
        [EnumMember(Value = "fr-ML")]
        FrML,
        [EnumMember(Value = "fr-MQ")]
        FrMQ,
        [EnumMember(Value = "fr-MR")]
        FrMR,
        [EnumMember(Value = "fr-MU")]
        FrMU,
        [EnumMember(Value = "fr-NC")]
        FrNC,
        [EnumMember(Value = "fr-NE")]
        FrNE,
        [EnumMember(Value = "fr-PF")]
        FrPF,
        [EnumMember(Value = "fr-PM")]
        FrPM,
        [EnumMember(Value = "fr-RE")]
        FrRE,
        [EnumMember(Value = "fr-RW")]
        FrRW,
        [EnumMember(Value = "fr-SC")]
        FrSC,
        [EnumMember(Value = "fr-SN")]
        FrSN,
        [EnumMember(Value = "fr-SY")]
        FrSY,
        [EnumMember(Value = "fr-TD")]
        FrTD,
        [EnumMember(Value = "fr-TG")]
        FrTG,
        [EnumMember(Value = "fr-TN")]
        FrTN,
        [EnumMember(Value = "fr-VU")]
        FrVU,
        [EnumMember(Value = "fr-WF")]
        FrWF,
        [EnumMember(Value = "fr-YT")]
        FrYT,
        [EnumMember(Value = "fur-IT")]
        FurIT,
        [EnumMember(Value = "fy-NL")]
        FyNL,
        [EnumMember(Value = "ga-IE")]
        GaIE,
        [EnumMember(Value = "gd-GB")]
        GdGB,
        [EnumMember(Value = "gl-ES")]
        GlES,
        [EnumMember(Value = "gn-PY")]
        GnPY,
        [EnumMember(Value = "gsw-CH")]
        GswCH,
        [EnumMember(Value = "gsw-FR")]
        GswFR,
        [EnumMember(Value = "gsw-LI")]
        GswLI,
        [EnumMember(Value = "gu-IN")]
        GuIN,
        [EnumMember(Value = "guz-KE")]
        GuzKE,
        [EnumMember(Value = "gv-IM")]
        GvIM,
        [EnumMember(Value = "ha-GH")]
        HaGH,
        [EnumMember(Value = "ha-NE")]
        HaNE,
        [EnumMember(Value = "ha-NG")]
        HaNG,
        [EnumMember(Value = "haw-US")]
        HawUS,
        [EnumMember(Value = "he-IL")]
        HeIL,
        [EnumMember(Value = "hi-IN")]
        HiIN,
        [EnumMember(Value = "hr-BA")]
        HrBA,
        [EnumMember(Value = "hr-HR")]
        HrHR,
        [EnumMember(Value = "hsb-DE")]
        HsbDE,
        [EnumMember(Value = "hu-HU")]
        HuHU,
        [EnumMember(Value = "hy-AM")]
        HyAM,
        [EnumMember(Value = "ia-001")]
        Ia001,
        [EnumMember(Value = "id-ID")]
        IdID,
        [EnumMember(Value = "ig-NG")]
        IgNG,
        [EnumMember(Value = "ii-CN")]
        IiCN,
        [EnumMember(Value = "is-IS")]
        IsIS,
        [EnumMember(Value = "it-CH")]
        ItCH,
        [EnumMember(Value = "it-IT")]
        ItIT,
        [EnumMember(Value = "it-SM")]
        ItSM,
        [EnumMember(Value = "it-VA")]
        ItVA,
        [EnumMember(Value = "iu-CA")]
        IuCA,
        [EnumMember(Value = "iu-Latn-CA")]
        IuLatnCA,
        [EnumMember(Value = "ja-JP")]
        JaJP,
        [EnumMember(Value = "jgo-CM")]
        JgoCM,
        [EnumMember(Value = "jmc-TZ")]
        JmcTZ,
        [EnumMember(Value = "jv-ID")]
        JvID,
        [EnumMember(Value = "ka-GE")]
        KaGE,
        [EnumMember(Value = "kab-DZ")]
        KabDZ,
        [EnumMember(Value = "kam-KE")]
        KamKE,
        [EnumMember(Value = "kde-TZ")]
        KdeTZ,
        [EnumMember(Value = "kea-CV")]
        KeaCV,
        [EnumMember(Value = "khq-ML")]
        KhqML,
        [EnumMember(Value = "ki-KE")]
        KiKE,
        [EnumMember(Value = "kk-KZ")]
        KkKZ,
        [EnumMember(Value = "kkj-CM")]
        KkjCM,
        [EnumMember(Value = "kl-GL")]
        KlGL,
        [EnumMember(Value = "kln-KE")]
        KlnKE,
        [EnumMember(Value = "km-KH")]
        KmKH,
        [EnumMember(Value = "kn-IN")]
        KnIN,
        [EnumMember(Value = "ko-KP")]
        KoKP,
        [EnumMember(Value = "ko-KR")]
        KoKR,
        [EnumMember(Value = "kok-IN")]
        KokIN,
        [EnumMember(Value = "ks-IN")]
        KsIN,
        [EnumMember(Value = "ksb-TZ")]
        KsbTZ,
        [EnumMember(Value = "ksf-CM")]
        KsfCM,
        [EnumMember(Value = "ksh-DE")]
        KshDE,
        [EnumMember(Value = "kw-GB")]
        KwGB,
        [EnumMember(Value = "ky-KG")]
        KyKG,
        [EnumMember(Value = "lag-TZ")]
        LagTZ,
        [EnumMember(Value = "lb-LU")]
        LbLU,
        [EnumMember(Value = "lg-UG")]
        LgUG,
        [EnumMember(Value = "lkt-US")]
        LktUS,
        [EnumMember(Value = "ln-AO")]
        LnAO,
        [EnumMember(Value = "ln-CD")]
        LnCD,
        [EnumMember(Value = "ln-CF")]
        LnCF,
        [EnumMember(Value = "ln-CG")]
        LnCG,
        [EnumMember(Value = "lo-LA")]
        LoLA,
        [EnumMember(Value = "lrc-IQ")]
        LrcIQ,
        [EnumMember(Value = "lrc-IR")]
        LrcIR,
        [EnumMember(Value = "lt-LT")]
        LtLT,
        [EnumMember(Value = "lu-CD")]
        LuCD,
        [EnumMember(Value = "luo-KE")]
        LuoKE,
        [EnumMember(Value = "luy-KE")]
        LuyKE,
        [EnumMember(Value = "lv-LV")]
        LvLV,
        [EnumMember(Value = "mas-KE")]
        MasKE,
        [EnumMember(Value = "mas-TZ")]
        MasTZ,
        [EnumMember(Value = "mer-KE")]
        MerKE,
        [EnumMember(Value = "mfe-MU")]
        MfeMU,
        [EnumMember(Value = "mg-MG")]
        MgMG,
        [EnumMember(Value = "mgh-MZ")]
        MghMZ,
        [EnumMember(Value = "mgo-CM")]
        MgoCM,
        [EnumMember(Value = "mi-NZ")]
        MiNZ,
        [EnumMember(Value = "mk-MK")]
        MkMK,
        [EnumMember(Value = "ml-IN")]
        MlIN,
        [EnumMember(Value = "mn-MN")]
        MnMN,
        [EnumMember(Value = "mn-Mong-CN")]
        MnMongCN,
        [EnumMember(Value = "mn-Mong-MN")]
        MnMongMN,
        [EnumMember(Value = "moh-CA")]
        MohCA,
        [EnumMember(Value = "mr-IN")]
        MrIN,
        [EnumMember(Value = "ms-BN")]
        MsBN,
        [EnumMember(Value = "ms-MY")]
        MsMY,
        [EnumMember(Value = "ms-SG")]
        MsSG,
        [EnumMember(Value = "mt-MT")]
        MtMT,
        [EnumMember(Value = "mua-CM")]
        MuaCM,
        [EnumMember(Value = "my-MM")]
        MyMM,
        [EnumMember(Value = "mzn-IR")]
        MznIR,
        [EnumMember(Value = "naq-NA")]
        NaqNA,
        [EnumMember(Value = "nb-NO")]
        NbNO,
        [EnumMember(Value = "nb-SJ")]
        NbSJ,
        [EnumMember(Value = "nd-ZW")]
        NdZW,
        [EnumMember(Value = "nds-DE")]
        NdsDE,
        [EnumMember(Value = "nds-NL")]
        NdsNL,
        [EnumMember(Value = "ne-IN")]
        NeIN,
        [EnumMember(Value = "ne-NP")]
        NeNP,
        [EnumMember(Value = "nl-AW")]
        NlAW,
        [EnumMember(Value = "nl-BE")]
        NlBE,
        [EnumMember(Value = "nl-BQ")]
        NlBQ,
        [EnumMember(Value = "nl-CW")]
        NlCW,
        [EnumMember(Value = "nl-NL")]
        NlNL,
        [EnumMember(Value = "nl-SR")]
        NlSR,
        [EnumMember(Value = "nl-SX")]
        NlSX,
        [EnumMember(Value = "nmg-CM")]
        NmgCM,
        [EnumMember(Value = "nn-NO")]
        NnNO,
        [EnumMember(Value = "nnh-CM")]
        NnhCM,
        [EnumMember(Value = "nqo-GN")]
        NqoGN,
        [EnumMember(Value = "nr-ZA")]
        NrZA,
        [EnumMember(Value = "nso-ZA")]
        NsoZA,
        [EnumMember(Value = "nus-SS")]
        NusSS,
        [EnumMember(Value = "nyn-UG")]
        NynUG,
        [EnumMember(Value = "oc-FR")]
        OcFR,
        [EnumMember(Value = "om-ET")]
        OmET,
        [EnumMember(Value = "om-KE")]
        OmKE,
        [EnumMember(Value = "or-IN")]
        OrIN,
        [EnumMember(Value = "os-GE")]
        OsGE,
        [EnumMember(Value = "os-RU")]
        OsRU,
        [EnumMember(Value = "pa-Arab-PK")]
        PaArabPK,
        [EnumMember(Value = "pa-Guru-IN")]
        PaGuruIN,
        [EnumMember(Value = "pl-PL")]
        PlPL,
        [EnumMember(Value = "prg-001")]
        Prg001,
        [EnumMember(Value = "ps-AF")]
        PsAF,
        [EnumMember(Value = "ps-PK")]
        PsPK,
        [EnumMember(Value = "pt-AO")]
        PtAO,
        [EnumMember(Value = "pt-BR")]
        PtBR,
        [EnumMember(Value = "pt-CH")]
        PtCH,
        [EnumMember(Value = "pt-CV")]
        PtCV,
        [EnumMember(Value = "pt-GQ")]
        PtGQ,
        [EnumMember(Value = "pt-GW")]
        PtGW,
        [EnumMember(Value = "pt-LU")]
        PtLU,
        [EnumMember(Value = "pt-MO")]
        PtMO,
        [EnumMember(Value = "pt-MZ")]
        PtMZ,
        [EnumMember(Value = "pt-PT")]
        PtPT,
        [EnumMember(Value = "pt-ST")]
        PtST,
        [EnumMember(Value = "pt-TL")]
        PtTL,
        [EnumMember(Value = "qu-BO")]
        QuBO,
        [EnumMember(Value = "qu-EC")]
        QuEC,
        [EnumMember(Value = "qu-PE")]
        QuPE,
        [EnumMember(Value = "quc-GT")]
        QucGT,
        [EnumMember(Value = "rm-CH")]
        RmCH,
        [EnumMember(Value = "rn-BI")]
        RnBI,
        [EnumMember(Value = "ro-MD")]
        RoMD,
        [EnumMember(Value = "ro-RO")]
        RoRO,
        [EnumMember(Value = "rof-TZ")]
        RofTZ,
        [EnumMember(Value = "ru-BY")]
        RuBY,
        [EnumMember(Value = "ru-KG")]
        RuKG,
        [EnumMember(Value = "ru-KZ")]
        RuKZ,
        [EnumMember(Value = "ru-MD")]
        RuMD,
        [EnumMember(Value = "ru-RU")]
        RuRU,
        [EnumMember(Value = "ru-UA")]
        RuUA,
        [EnumMember(Value = "rw-RW")]
        RwRW,
        [EnumMember(Value = "rwk-TZ")]
        RwkTZ,
        [EnumMember(Value = "sa-IN")]
        SaIN,
        [EnumMember(Value = "sah-RU")]
        SahRU,
        [EnumMember(Value = "saq-KE")]
        SaqKE,
        [EnumMember(Value = "sbp-TZ")]
        SbpTZ,
        [EnumMember(Value = "sd-PK")]
        SdPK,
        [EnumMember(Value = "se-FI")]
        SeFI,
        [EnumMember(Value = "se-NO")]
        SeNO,
        [EnumMember(Value = "se-SE")]
        SeSE,
        [EnumMember(Value = "seh-MZ")]
        SehMZ,
        [EnumMember(Value = "ses-ML")]
        SesML,
        [EnumMember(Value = "sg-CF")]
        SgCF,
        [EnumMember(Value = "shi-Latn-MA")]
        ShiLatnMA,
        [EnumMember(Value = "shi-Tfng-MA")]
        ShiTfngMA,
        [EnumMember(Value = "si-LK")]
        SiLK,
        [EnumMember(Value = "sk-SK")]
        SkSK,
        [EnumMember(Value = "sl-SI")]
        SlSI,
        [EnumMember(Value = "sma-NO")]
        SmaNO,
        [EnumMember(Value = "sma-SE")]
        SmaSE,
        [EnumMember(Value = "smj-NO")]
        SmjNO,
        [EnumMember(Value = "smj-SE")]
        SmjSE,
        [EnumMember(Value = "smn-FI")]
        SmnFI,
        [EnumMember(Value = "sms-FI")]
        SmsFI,
        [EnumMember(Value = "sn-ZW")]
        SnZW,
        [EnumMember(Value = "so-DJ")]
        SoDJ,
        [EnumMember(Value = "so-ET")]
        SoET,
        [EnumMember(Value = "so-KE")]
        SoKE,
        [EnumMember(Value = "so-SO")]
        SoSO,
        [EnumMember(Value = "sq-AL")]
        SqAL,
        [EnumMember(Value = "sq-MK")]
        SqMK,
        [EnumMember(Value = "sq-XK")]
        SqXK,
        [EnumMember(Value = "sr-Cyrl-BA")]
        SrCyrlBA,
        [EnumMember(Value = "sr-Cyrl-ME")]
        SrCyrlME,
        [EnumMember(Value = "sr-Cyrl-RS")]
        SrCyrlRS,
        [EnumMember(Value = "sr-Cyrl-XK")]
        SrCyrlXK,
        [EnumMember(Value = "sr-Latn-BA")]
        SrLatnBA,
        [EnumMember(Value = "sr-Latn-ME")]
        SrLatnME,
        [EnumMember(Value = "sr-Latn-RS")]
        SrLatnRS,
        [EnumMember(Value = "sr-Latn-XK")]
        SrLatnXK,
        [EnumMember(Value = "ss-SZ")]
        SsSZ,
        [EnumMember(Value = "ss-ZA")]
        SsZA,
        [EnumMember(Value = "ssy-ER")]
        SsyER,
        [EnumMember(Value = "st-LS")]
        StLS,
        [EnumMember(Value = "st-ZA")]
        StZA,
        [EnumMember(Value = "sv-AX")]
        SvAX,
        [EnumMember(Value = "sv-FI")]
        SvFI,
        [EnumMember(Value = "sv-SE")]
        SvSE,
        [EnumMember(Value = "sw-CD")]
        SwCD,
        [EnumMember(Value = "sw-KE")]
        SwKE,
        [EnumMember(Value = "sw-TZ")]
        SwTZ,
        [EnumMember(Value = "sw-UG")]
        SwUG,
        [EnumMember(Value = "syr-SY")]
        SyrSY,
        [EnumMember(Value = "ta-IN")]
        TaIN,
        [EnumMember(Value = "ta-LK")]
        TaLK,
        [EnumMember(Value = "ta-MY")]
        TaMY,
        [EnumMember(Value = "ta-SG")]
        TaSG,
        [EnumMember(Value = "te-IN")]
        TeIN,
        [EnumMember(Value = "teo-KE")]
        TeoKE,
        [EnumMember(Value = "teo-UG")]
        TeoUG,
        [EnumMember(Value = "tg-TJ")]
        TgTJ,
        [EnumMember(Value = "th-TH")]
        ThTH,
        [EnumMember(Value = "ti-ER")]
        TiER,
        [EnumMember(Value = "ti-ET")]
        TiET,
        [EnumMember(Value = "tig-ER")]
        TigER,
        [EnumMember(Value = "tk-TM")]
        TkTM,
        [EnumMember(Value = "tn-BW")]
        TnBW,
        [EnumMember(Value = "tn-ZA")]
        TnZA,
        [EnumMember(Value = "to-TO")]
        ToTO,
        [EnumMember(Value = "tr-CY")]
        TrCY,
        [EnumMember(Value = "tr-TR")]
        TrTR,
        [EnumMember(Value = "ts-ZA")]
        TsZA,
        [EnumMember(Value = "tt-RU")]
        TtRU,
        [EnumMember(Value = "twq-NE")]
        TwqNE,
        [EnumMember(Value = "tzm-MA")]
        TzmMA,
        [EnumMember(Value = "ug-CN")]
        UgCN,
        [EnumMember(Value = "uk-UA")]
        UkUA,
        [EnumMember(Value = "ur-IN")]
        UrIN,
        [EnumMember(Value = "ur-PK")]
        UrPK,
        [EnumMember(Value = "uz-Arab-AF")]
        UzArabAF,
        [EnumMember(Value = "uz-Cyrl-UZ")]
        UzCyrlUZ,
        [EnumMember(Value = "uz-Latn-UZ")]
        UzLatnUZ,
        [EnumMember(Value = "vai-Latn-LR")]
        VaiLatnLR,
        [EnumMember(Value = "vai-Vaii-LR")]
        VaiVaiiLR,
        [EnumMember(Value = "ve-ZA")]
        VeZA,
        [EnumMember(Value = "vi-VN")]
        ViVN,
        [EnumMember(Value = "vo-001")]
        Vo001,
        [EnumMember(Value = "vun-TZ")]
        VunTZ,
        [EnumMember(Value = "wae-CH")]
        WaeCH,
        [EnumMember(Value = "wal-ET")]
        WalET,
        [EnumMember(Value = "wo-SN")]
        WoSN,
        [EnumMember(Value = "xh-ZA")]
        XhZA,
        [EnumMember(Value = "xog-UG")]
        XogUG,
        [EnumMember(Value = "yav-CM")]
        YavCM,
        [EnumMember(Value = "yi-001")]
        Yi001,
        [EnumMember(Value = "yo-BJ")]
        YoBJ,
        [EnumMember(Value = "yo-NG")]
        YoNG,
        [EnumMember(Value = "zgh-MA")]
        ZghMA,
        [EnumMember(Value = "zh-Hans-CN")]
        ZhHansCN,
        [EnumMember(Value = "zh-Hans-HK")]
        ZhHansHK,
        [EnumMember(Value = "zh-Hans-MO")]
        ZhHansMO,
        [EnumMember(Value = "zh-Hans-SG")]
        ZhHansSG,
        [EnumMember(Value = "zh-Hant-HK")]
        ZhHantHK,
        [EnumMember(Value = "zh-Hant-MO")]
        ZhHantMO,
        [EnumMember(Value = "zh-Hant-TW")]
        ZhHantTW,
        [EnumMember(Value = "zu-ZA")]
        ZuZA
    }

    public enum requesttimeZoneInput
    {
        [EnumMember(Value = "Australia/Darwin")]
        AustraliaDarwin,
        [EnumMember(Value = "Australia/Sydney")]
        AustraliaSydney,
        [EnumMember(Value = "Australia/Melbourne")]
        AustraliaMelbourne,
        [EnumMember(Value = "Asia/Kabul")]
        AsiaKabul,
        [EnumMember(Value = "America/Anchorage")]
        AmericaAnchorage,
        [EnumMember(Value = "America/Juneau")]
        AmericaJuneau,
        [EnumMember(Value = "America/Metlakatla")]
        AmericaMetlakatla,
        [EnumMember(Value = "America/Nome")]
        AmericaNome,
        [EnumMember(Value = "America/Sitka")]
        AmericaSitka,
        [EnumMember(Value = "America/Yakutat")]
        AmericaYakutat,
        [EnumMember(Value = "America/Adak")]
        AmericaAdak,
        [EnumMember(Value = "Asia/Barnaul")]
        AsiaBarnaul,
        [EnumMember(Value = "Asia/Riyadh")]
        AsiaRiyadh,
        [EnumMember(Value = "Asia/Bahrain")]
        AsiaBahrain,
        [EnumMember(Value = "Asia/Kuwait")]
        AsiaKuwait,
        [EnumMember(Value = "Asia/Qatar")]
        AsiaQatar,
        [EnumMember(Value = "Asia/Aden")]
        AsiaAden,
        [EnumMember(Value = "Asia/Dubai")]
        AsiaDubai,
        [EnumMember(Value = "Asia/Muscat")]
        AsiaMuscat,
        [EnumMember(Value = "Etc/GMT-4")]
        EtcGMT4,
        [EnumMember(Value = "Asia/Baghdad")]
        AsiaBaghdad,
        [EnumMember(Value = "America/Buenos_Aires")]
        AmericaBuenosAires,
        [EnumMember(Value = "America/Argentina/La_Rioja")]
        AmericaArgentinaLaRioja,
        [EnumMember(Value = "America/Argentina/Rio_Gallegos")]
        AmericaArgentinaRioGallegos,
        [EnumMember(Value = "America/Argentina/Salta")]
        AmericaArgentinaSalta,
        [EnumMember(Value = "America/Argentina/San_Juan")]
        AmericaArgentinaSanJuan,
        [EnumMember(Value = "America/Argentina/San_Luis")]
        AmericaArgentinaSanLuis,
        [EnumMember(Value = "America/Argentina/Tucuman")]
        AmericaArgentinaTucuman,
        [EnumMember(Value = "America/Argentina/Ushuaia")]
        AmericaArgentinaUshuaia,
        [EnumMember(Value = "America/Catamarca")]
        AmericaCatamarca,
        [EnumMember(Value = "America/Cordoba")]
        AmericaCordoba,
        [EnumMember(Value = "America/Jujuy")]
        AmericaJujuy,
        [EnumMember(Value = "America/Mendoza")]
        AmericaMendoza,
        [EnumMember(Value = "Europe/Astrakhan")]
        EuropeAstrakhan,
        [EnumMember(Value = "Europe/Ulyanovsk")]
        EuropeUlyanovsk,
        [EnumMember(Value = "America/Halifax")]
        AmericaHalifax,
        [EnumMember(Value = "Atlantic/Bermuda")]
        AtlanticBermuda,
        [EnumMember(Value = "America/Glace_Bay")]
        AmericaGlaceBay,
        [EnumMember(Value = "America/Goose_Bay")]
        AmericaGooseBay,
        [EnumMember(Value = "America/Moncton")]
        AmericaMoncton,
        [EnumMember(Value = "America/Thule")]
        AmericaThule,
        [EnumMember(Value = "Australia/Eucla")]
        AustraliaEucla,
        [EnumMember(Value = "Asia/Baku")]
        AsiaBaku,
        [EnumMember(Value = "Atlantic/Azores")]
        AtlanticAzores,
        [EnumMember(Value = "America/Scoresbysund")]
        AmericaScoresbysund,
        [EnumMember(Value = "America/Bahia")]
        AmericaBahia,
        [EnumMember(Value = "Asia/Dhaka")]
        AsiaDhaka,
        [EnumMember(Value = "Asia/Thimphu")]
        AsiaThimphu,
        [EnumMember(Value = "Europe/Minsk")]
        EuropeMinsk,
        [EnumMember(Value = "Pacific/Bougainville")]
        PacificBougainville,
        [EnumMember(Value = "America/Regina")]
        AmericaRegina,
        [EnumMember(Value = "America/Swift_Current")]
        AmericaSwiftCurrent,
        [EnumMember(Value = "Atlantic/Cape_Verde")]
        AtlanticCapeVerde,
        [EnumMember(Value = "Etc/GMT+1")]
        EtcGMT1,
        [EnumMember(Value = "Asia/Yerevan")]
        AsiaYerevan,
        [EnumMember(Value = "Australia/Adelaide")]
        AustraliaAdelaide,
        [EnumMember(Value = "Australia/Broken_Hill")]
        AustraliaBrokenHill,
        [EnumMember(Value = "America/Guatemala")]
        AmericaGuatemala,
        [EnumMember(Value = "America/Belize")]
        AmericaBelize,
        [EnumMember(Value = "America/Costa_Rica")]
        AmericaCostaRica,
        [EnumMember(Value = "Pacific/Galapagos")]
        PacificGalapagos,
        [EnumMember(Value = "America/Tegucigalpa")]
        AmericaTegucigalpa,
        [EnumMember(Value = "America/Managua")]
        AmericaManagua,
        [EnumMember(Value = "America/El_Salvador")]
        AmericaElSalvador,
        [EnumMember(Value = "Etc/GMT+6")]
        EtcGMT6,
        [EnumMember(Value = "Asia/Bishkek")]
        AsiaBishkek,
        [EnumMember(Value = "Antarctica/Vostok")]
        AntarcticaVostok,
        [EnumMember(Value = "Asia/Urumqi")]
        AsiaUrumqi,
        [EnumMember(Value = "Indian/Chagos")]
        IndianChagos,
        [EnumMember(Value = "Etc/GMT-6")]
        EtcGMT6,
        [EnumMember(Value = "America/Cuiaba")]
        AmericaCuiaba,
        [EnumMember(Value = "America/Campo_Grande")]
        AmericaCampoGrande,
        [EnumMember(Value = "Europe/Budapest")]
        EuropeBudapest,
        [EnumMember(Value = "Europe/Tirane")]
        EuropeTirane,
        [EnumMember(Value = "Europe/Prague")]
        EuropePrague,
        [EnumMember(Value = "Europe/Podgorica")]
        EuropePodgorica,
        [EnumMember(Value = "Europe/Belgrade")]
        EuropeBelgrade,
        [EnumMember(Value = "Europe/Ljubljana")]
        EuropeLjubljana,
        [EnumMember(Value = "Europe/Bratislava")]
        EuropeBratislava,
        [EnumMember(Value = "Europe/Warsaw")]
        EuropeWarsaw,
        [EnumMember(Value = "Europe/Sarajevo")]
        EuropeSarajevo,
        [EnumMember(Value = "Europe/Zagreb")]
        EuropeZagreb,
        [EnumMember(Value = "Europe/Skopje")]
        EuropeSkopje,
        [EnumMember(Value = "Pacific/Guadalcanal")]
        PacificGuadalcanal,
        [EnumMember(Value = "Antarctica/Casey")]
        AntarcticaCasey,
        [EnumMember(Value = "Pacific/Ponape")]
        PacificPonape,
        [EnumMember(Value = "Pacific/Kosrae")]
        PacificKosrae,
        [EnumMember(Value = "Pacific/Noumea")]
        PacificNoumea,
        [EnumMember(Value = "Pacific/Efate")]
        PacificEfate,
        [EnumMember(Value = "Etc/GMT-11")]
        EtcGMT11,
        [EnumMember(Value = "America/Mexico_City")]
        AmericaMexicoCity,
        [EnumMember(Value = "America/Bahia_Banderas")]
        AmericaBahiaBanderas,
        [EnumMember(Value = "America/Merida")]
        AmericaMerida,
        [EnumMember(Value = "America/Monterrey")]
        AmericaMonterrey,
        [EnumMember(Value = "America/Chihuahua")]
        AmericaChihuahua,
        [EnumMember(Value = "America/Chicago")]
        AmericaChicago,
        [EnumMember(Value = "America/Winnipeg")]
        AmericaWinnipeg,
        [EnumMember(Value = "America/Rankin_Inlet")]
        AmericaRankinInlet,
        [EnumMember(Value = "America/Resolute")]
        AmericaResolute,
        [EnumMember(Value = "America/Matamoros")]
        AmericaMatamoros,
        [EnumMember(Value = "America/Ojinaga")]
        AmericaOjinaga,
        [EnumMember(Value = "America/Indiana/Knox")]
        AmericaIndianaKnox,
        [EnumMember(Value = "America/Indiana/Tell_City")]
        AmericaIndianaTellCity,
        [EnumMember(Value = "America/Menominee")]
        AmericaMenominee,
        [EnumMember(Value = "America/North_Dakota/Beulah")]
        AmericaNorthDakotaBeulah,
        [EnumMember(Value = "America/North_Dakota/Center")]
        AmericaNorthDakotaCenter,
        [EnumMember(Value = "America/North_Dakota/New_Salem")]
        AmericaNorthDakotaNewSalem,
        [EnumMember(Value = "Pacific/Chatham")]
        PacificChatham,
        [EnumMember(Value = "Asia/Shanghai")]
        AsiaShanghai,
        [EnumMember(Value = "Asia/Hong_Kong")]
        AsiaHongKong,
        [EnumMember(Value = "Asia/Macau")]
        AsiaMacau,
        [EnumMember(Value = "America/Havana")]
        AmericaHavana,
        [EnumMember(Value = "Etc/GMT+12")]
        EtcGMT12,
        [EnumMember(Value = "Africa/Nairobi")]
        AfricaNairobi,
        [EnumMember(Value = "Antarctica/Syowa")]
        AntarcticaSyowa,
        [EnumMember(Value = "Africa/Djibouti")]
        AfricaDjibouti,
        [EnumMember(Value = "Africa/Asmera")]
        AfricaAsmera,
        [EnumMember(Value = "Africa/Addis_Ababa")]
        AfricaAddisAbaba,
        [EnumMember(Value = "Indian/Comoro")]
        IndianComoro,
        [EnumMember(Value = "Indian/Antananarivo")]
        IndianAntananarivo,
        [EnumMember(Value = "Africa/Mogadishu")]
        AfricaMogadishu,
        [EnumMember(Value = "Africa/Dar_es_Salaam")]
        AfricaDarEsSalaam,
        [EnumMember(Value = "Africa/Kampala")]
        AfricaKampala,
        [EnumMember(Value = "Indian/Mayotte")]
        IndianMayotte,
        [EnumMember(Value = "Etc/GMT-3")]
        EtcGMT3,
        [EnumMember(Value = "Australia/Brisbane")]
        AustraliaBrisbane,
        [EnumMember(Value = "Australia/Lindeman")]
        AustraliaLindeman,
        [EnumMember(Value = "Europe/Chisinau")]
        EuropeChisinau,
        [EnumMember(Value = "America/Sao_Paulo")]
        AmericaSaoPaulo,
        [EnumMember(Value = "Pacific/Easter")]
        PacificEaster,
        [EnumMember(Value = "America/Cancun")]
        AmericaCancun,
        [EnumMember(Value = "America/New_York")]
        AmericaNewYork,
        [EnumMember(Value = "America/Nassau")]
        AmericaNassau,
        [EnumMember(Value = "America/Toronto")]
        AmericaToronto,
        [EnumMember(Value = "America/Iqaluit")]
        AmericaIqaluit,
        [EnumMember(Value = "America/Detroit")]
        AmericaDetroit,
        [EnumMember(Value = "America/Indiana/Petersburg")]
        AmericaIndianaPetersburg,
        [EnumMember(Value = "America/Indiana/Vincennes")]
        AmericaIndianaVincennes,
        [EnumMember(Value = "America/Indiana/Winamac")]
        AmericaIndianaWinamac,
        [EnumMember(Value = "America/Kentucky/Monticello")]
        AmericaKentuckyMonticello,
        [EnumMember(Value = "America/Louisville")]
        AmericaLouisville,
        [EnumMember(Value = "Africa/Cairo")]
        AfricaCairo,
        [EnumMember(Value = "Asia/Yekaterinburg")]
        AsiaYekaterinburg,
        [EnumMember(Value = "Europe/Kiev")]
        EuropeKiev,
        [EnumMember(Value = "Europe/Mariehamn")]
        EuropeMariehamn,
        [EnumMember(Value = "Europe/Sofia")]
        EuropeSofia,
        [EnumMember(Value = "Europe/Tallinn")]
        EuropeTallinn,
        [EnumMember(Value = "Europe/Helsinki")]
        EuropeHelsinki,
        [EnumMember(Value = "Europe/Vilnius")]
        EuropeVilnius,
        [EnumMember(Value = "Europe/Riga")]
        EuropeRiga,
        [EnumMember(Value = "Pacific/Fiji")]
        PacificFiji,
        [EnumMember(Value = "Europe/London")]
        EuropeLondon,
        [EnumMember(Value = "Atlantic/Canary")]
        AtlanticCanary,
        [EnumMember(Value = "Atlantic/Faeroe")]
        AtlanticFaeroe,
        [EnumMember(Value = "Europe/Guernsey")]
        EuropeGuernsey,
        [EnumMember(Value = "Europe/Dublin")]
        EuropeDublin,
        [EnumMember(Value = "Europe/Isle_of_Man")]
        EuropeIsleOfMan,
        [EnumMember(Value = "Europe/Jersey")]
        EuropeJersey,
        [EnumMember(Value = "Europe/Lisbon")]
        EuropeLisbon,
        [EnumMember(Value = "Atlantic/Madeira")]
        AtlanticMadeira,
        [EnumMember(Value = "Europe/Bucharest")]
        EuropeBucharest,
        [EnumMember(Value = "Asia/Nicosia")]
        AsiaNicosia,
        [EnumMember(Value = "Asia/Famagusta")]
        AsiaFamagusta,
        [EnumMember(Value = "Europe/Athens")]
        EuropeAthens,
        [EnumMember(Value = "Asia/Tbilisi")]
        AsiaTbilisi,
        [EnumMember(Value = "America/Godthab")]
        AmericaGodthab,
        [EnumMember(Value = "Atlantic/Reykjavik")]
        AtlanticReykjavik,
        [EnumMember(Value = "Atlantic/St_Helena")]
        AtlanticStHelena,
        [EnumMember(Value = "Africa/Ouagadougou")]
        AfricaOuagadougou,
        [EnumMember(Value = "Africa/Abidjan")]
        AfricaAbidjan,
        [EnumMember(Value = "Africa/Accra")]
        AfricaAccra,
        [EnumMember(Value = "America/Danmarkshavn")]
        AmericaDanmarkshavn,
        [EnumMember(Value = "Africa/Banjul")]
        AfricaBanjul,
        [EnumMember(Value = "Africa/Conakry")]
        AfricaConakry,
        [EnumMember(Value = "Africa/Bissau")]
        AfricaBissau,
        [EnumMember(Value = "Africa/Monrovia")]
        AfricaMonrovia,
        [EnumMember(Value = "Africa/Bamako")]
        AfricaBamako,
        [EnumMember(Value = "Africa/Nouakchott")]
        AfricaNouakchott,
        [EnumMember(Value = "Africa/Freetown")]
        AfricaFreetown,
        [EnumMember(Value = "Africa/Dakar")]
        AfricaDakar,
        [EnumMember(Value = "Africa/Lome")]
        AfricaLome,
        [EnumMember(Value = "America/Port-au-Prince")]
        AmericaPortAuPrince,
        [EnumMember(Value = "Pacific/Honolulu")]
        PacificHonolulu,
        [EnumMember(Value = "Pacific/Rarotonga")]
        PacificRarotonga,
        [EnumMember(Value = "Pacific/Tahiti")]
        PacificTahiti,
        [EnumMember(Value = "Etc/GMT+10")]
        EtcGMT10,
        [EnumMember(Value = "Asia/Calcutta")]
        AsiaCalcutta,
        [EnumMember(Value = "Asia/Tehran")]
        AsiaTehran,
        [EnumMember(Value = "Asia/Jerusalem")]
        AsiaJerusalem,
        [EnumMember(Value = "Asia/Amman")]
        AsiaAmman,
        [EnumMember(Value = "Europe/Kaliningrad")]
        EuropeKaliningrad,
        [EnumMember(Value = "Asia/Seoul")]
        AsiaSeoul,
        [EnumMember(Value = "Africa/Tripoli")]
        AfricaTripoli,
        [EnumMember(Value = "Pacific/Kiritimati")]
        PacificKiritimati,
        [EnumMember(Value = "Etc/GMT-14")]
        EtcGMT14,
        [EnumMember(Value = "Australia/Lord_Howe")]
        AustraliaLordHowe,
        [EnumMember(Value = "Asia/Magadan")]
        AsiaMagadan,
        [EnumMember(Value = "America/Punta_Arenas")]
        AmericaPuntaArenas,
        [EnumMember(Value = "Pacific/Marquesas")]
        PacificMarquesas,
        [EnumMember(Value = "Indian/Mauritius")]
        IndianMauritius,
        [EnumMember(Value = "Indian/Reunion")]
        IndianReunion,
        [EnumMember(Value = "Indian/Mahe")]
        IndianMahe,
        [EnumMember(Value = "Asia/Beirut")]
        AsiaBeirut,
        [EnumMember(Value = "America/Montevideo")]
        AmericaMontevideo,
        [EnumMember(Value = "Africa/Casablanca")]
        AfricaCasablanca,
        [EnumMember(Value = "Africa/El_Aaiun")]
        AfricaElAaiun,
        [EnumMember(Value = "America/Mazatlan")]
        AmericaMazatlan,
        [EnumMember(Value = "America/Denver")]
        AmericaDenver,
        [EnumMember(Value = "America/Edmonton")]
        AmericaEdmonton,
        [EnumMember(Value = "America/Cambridge_Bay")]
        AmericaCambridgeBay,
        [EnumMember(Value = "America/Inuvik")]
        AmericaInuvik,
        [EnumMember(Value = "America/Ciudad_Juarez")]
        AmericaCiudadJuarez,
        [EnumMember(Value = "America/Boise")]
        AmericaBoise,
        [EnumMember(Value = "Asia/Rangoon")]
        AsiaRangoon,
        [EnumMember(Value = "Indian/Cocos")]
        IndianCocos,
        [EnumMember(Value = "Asia/Novosibirsk")]
        AsiaNovosibirsk,
        [EnumMember(Value = "Africa/Windhoek")]
        AfricaWindhoek,
        [EnumMember(Value = "Asia/Katmandu")]
        AsiaKatmandu,
        [EnumMember(Value = "Pacific/Auckland")]
        PacificAuckland,
        [EnumMember(Value = "Antarctica/McMurdo")]
        AntarcticaMcMurdo,
        [EnumMember(Value = "America/St_Johns")]
        AmericaStJohns,
        [EnumMember(Value = "Pacific/Norfolk")]
        PacificNorfolk,
        [EnumMember(Value = "Asia/Irkutsk")]
        AsiaIrkutsk,
        [EnumMember(Value = "Asia/Krasnoyarsk")]
        AsiaKrasnoyarsk,
        [EnumMember(Value = "Asia/Novokuznetsk")]
        AsiaNovokuznetsk,
        [EnumMember(Value = "Asia/Pyongyang")]
        AsiaPyongyang,
        [EnumMember(Value = "Asia/Omsk")]
        AsiaOmsk,
        [EnumMember(Value = "America/Santiago")]
        AmericaSantiago,
        [EnumMember(Value = "America/Tijuana")]
        AmericaTijuana,
        [EnumMember(Value = "America/Los_Angeles")]
        AmericaLosAngeles,
        [EnumMember(Value = "America/Vancouver")]
        AmericaVancouver,
        [EnumMember(Value = "Asia/Karachi")]
        AsiaKarachi,
        [EnumMember(Value = "America/Asuncion")]
        AmericaAsuncion,
        [EnumMember(Value = "Asia/Qyzylorda")]
        AsiaQyzylorda,
        [EnumMember(Value = "Europe/Paris")]
        EuropeParis,
        [EnumMember(Value = "Europe/Brussels")]
        EuropeBrussels,
        [EnumMember(Value = "Europe/Copenhagen")]
        EuropeCopenhagen,
        [EnumMember(Value = "Africa/Ceuta")]
        AfricaCeuta,
        [EnumMember(Value = "Europe/Madrid")]
        EuropeMadrid,
        [EnumMember(Value = "Asia/Srednekolymsk")]
        AsiaSrednekolymsk,
        [EnumMember(Value = "Asia/Kamchatka")]
        AsiaKamchatka,
        [EnumMember(Value = "Asia/Anadyr")]
        AsiaAnadyr,
        [EnumMember(Value = "Europe/Samara")]
        EuropeSamara,
        [EnumMember(Value = "Europe/Moscow")]
        EuropeMoscow,
        [EnumMember(Value = "Europe/Kirov")]
        EuropeKirov,
        [EnumMember(Value = "Europe/Simferopol")]
        EuropeSimferopol,
        [EnumMember(Value = "America/Cayenne")]
        AmericaCayenne,
        [EnumMember(Value = "Antarctica/Rothera")]
        AntarcticaRothera,
        [EnumMember(Value = "Antarctica/Palmer")]
        AntarcticaPalmer,
        [EnumMember(Value = "America/Fortaleza")]
        AmericaFortaleza,
        [EnumMember(Value = "America/Belem")]
        AmericaBelem,
        [EnumMember(Value = "America/Maceio")]
        AmericaMaceio,
        [EnumMember(Value = "America/Recife")]
        AmericaRecife,
        [EnumMember(Value = "America/Santarem")]
        AmericaSantarem,
        [EnumMember(Value = "Atlantic/Stanley")]
        AtlanticStanley,
        [EnumMember(Value = "America/Paramaribo")]
        AmericaParamaribo,
        [EnumMember(Value = "Etc/GMT+3")]
        EtcGMT3,
        [EnumMember(Value = "America/Bogota")]
        AmericaBogota,
        [EnumMember(Value = "America/Rio_Branco")]
        AmericaRioBranco,
        [EnumMember(Value = "America/Eirunepe")]
        AmericaEirunepe,
        [EnumMember(Value = "America/Coral_Harbour")]
        AmericaCoralHarbour,
        [EnumMember(Value = "America/Guayaquil")]
        AmericaGuayaquil,
        [EnumMember(Value = "America/Jamaica")]
        AmericaJamaica,
        [EnumMember(Value = "America/Cayman")]
        AmericaCayman,
        [EnumMember(Value = "America/Panama")]
        AmericaPanama,
        [EnumMember(Value = "America/Lima")]
        AmericaLima,
        [EnumMember(Value = "Etc/GMT+5")]
        EtcGMT5,
        [EnumMember(Value = "America/La_Paz")]
        AmericaLaPaz,
        [EnumMember(Value = "America/Antigua")]
        AmericaAntigua,
        [EnumMember(Value = "America/Anguilla")]
        AmericaAnguilla,
        [EnumMember(Value = "America/Aruba")]
        AmericaAruba,
        [EnumMember(Value = "America/Barbados")]
        AmericaBarbados,
        [EnumMember(Value = "America/St_Barthelemy")]
        AmericaStBarthelemy,
        [EnumMember(Value = "America/Kralendijk")]
        AmericaKralendijk,
        [EnumMember(Value = "America/Manaus")]
        AmericaManaus,
        [EnumMember(Value = "America/Boa_Vista")]
        AmericaBoaVista,
        [EnumMember(Value = "America/Porto_Velho")]
        AmericaPortoVelho,
        [EnumMember(Value = "America/Blanc-Sablon")]
        AmericaBlancSablon,
        [EnumMember(Value = "America/Curacao")]
        AmericaCuracao,
        [EnumMember(Value = "America/Dominica")]
        AmericaDominica,
        [EnumMember(Value = "America/Santo_Domingo")]
        AmericaSantoDomingo,
        [EnumMember(Value = "America/Grenada")]
        AmericaGrenada,
        [EnumMember(Value = "America/Guadeloupe")]
        AmericaGuadeloupe,
        [EnumMember(Value = "America/Guyana")]
        AmericaGuyana,
        [EnumMember(Value = "America/St_Kitts")]
        AmericaStKitts,
        [EnumMember(Value = "America/St_Lucia")]
        AmericaStLucia,
        [EnumMember(Value = "America/Marigot")]
        AmericaMarigot,
        [EnumMember(Value = "America/Martinique")]
        AmericaMartinique,
        [EnumMember(Value = "America/Montserrat")]
        AmericaMontserrat,
        [EnumMember(Value = "America/Puerto_Rico")]
        AmericaPuertoRico,
        [EnumMember(Value = "America/Lower_Princes")]
        AmericaLowerPrinces,
        [EnumMember(Value = "America/Port_of_Spain")]
        AmericaPortOfSpain,
        [EnumMember(Value = "America/St_Vincent")]
        AmericaStVincent,
        [EnumMember(Value = "America/Tortola")]
        AmericaTortola,
        [EnumMember(Value = "America/St_Thomas")]
        AmericaStThomas,
        [EnumMember(Value = "Etc/GMT+4")]
        EtcGMT4,
        [EnumMember(Value = "Asia/Bangkok")]
        AsiaBangkok,
        [EnumMember(Value = "Antarctica/Davis")]
        AntarcticaDavis,
        [EnumMember(Value = "Indian/Christmas")]
        IndianChristmas,
        [EnumMember(Value = "Asia/Jakarta")]
        AsiaJakarta,
        [EnumMember(Value = "Asia/Pontianak")]
        AsiaPontianak,
        [EnumMember(Value = "Asia/Phnom_Penh")]
        AsiaPhnomPenh,
        [EnumMember(Value = "Asia/Vientiane")]
        AsiaVientiane,
        [EnumMember(Value = "Asia/Saigon")]
        AsiaSaigon,
        [EnumMember(Value = "Etc/GMT-7")]
        EtcGMT7,
        [EnumMember(Value = "America/Miquelon")]
        AmericaMiquelon,
        [EnumMember(Value = "Asia/Sakhalin")]
        AsiaSakhalin,
        [EnumMember(Value = "Pacific/Apia")]
        PacificApia,
        [EnumMember(Value = "Africa/Sao_Tome")]
        AfricaSaoTome,
        [EnumMember(Value = "Europe/Saratov")]
        EuropeSaratov,
        [EnumMember(Value = "Asia/Singapore")]
        AsiaSingapore,
        [EnumMember(Value = "Asia/Brunei")]
        AsiaBrunei,
        [EnumMember(Value = "Asia/Makassar")]
        AsiaMakassar,
        [EnumMember(Value = "Asia/Kuala_Lumpur")]
        AsiaKualaLumpur,
        [EnumMember(Value = "Asia/Kuching")]
        AsiaKuching,
        [EnumMember(Value = "Asia/Manila")]
        AsiaManila,
        [EnumMember(Value = "Etc/GMT-8")]
        EtcGMT8,
        [EnumMember(Value = "Africa/Johannesburg")]
        AfricaJohannesburg,
        [EnumMember(Value = "Africa/Bujumbura")]
        AfricaBujumbura,
        [EnumMember(Value = "Africa/Gaborone")]
        AfricaGaborone,
        [EnumMember(Value = "Africa/Lubumbashi")]
        AfricaLubumbashi,
        [EnumMember(Value = "Africa/Maseru")]
        AfricaMaseru,
        [EnumMember(Value = "Africa/Blantyre")]
        AfricaBlantyre,
        [EnumMember(Value = "Africa/Maputo")]
        AfricaMaputo,
        [EnumMember(Value = "Africa/Kigali")]
        AfricaKigali,
        [EnumMember(Value = "Africa/Mbabane")]
        AfricaMbabane,
        [EnumMember(Value = "Africa/Lusaka")]
        AfricaLusaka,
        [EnumMember(Value = "Africa/Harare")]
        AfricaHarare,
        [EnumMember(Value = "Etc/GMT-2")]
        EtcGMT2,
        [EnumMember(Value = "Africa/Juba")]
        AfricaJuba,
        [EnumMember(Value = "Asia/Colombo")]
        AsiaColombo,
        [EnumMember(Value = "Africa/Khartoum")]
        AfricaKhartoum,
        [EnumMember(Value = "Asia/Damascus")]
        AsiaDamascus,
        [EnumMember(Value = "Asia/Taipei")]
        AsiaTaipei,
        [EnumMember(Value = "Australia/Hobart")]
        AustraliaHobart,
        [EnumMember(Value = "Antarctica/Macquarie")]
        AntarcticaMacquarie,
        [EnumMember(Value = "America/Araguaina")]
        AmericaAraguaina,
        [EnumMember(Value = "Asia/Tokyo")]
        AsiaTokyo,
        [EnumMember(Value = "Asia/Jayapura")]
        AsiaJayapura,
        [EnumMember(Value = "Pacific/Palau")]
        PacificPalau,
        [EnumMember(Value = "Asia/Dili")]
        AsiaDili,
        [EnumMember(Value = "Etc/GMT-9")]
        EtcGMT9,
        [EnumMember(Value = "Asia/Tomsk")]
        AsiaTomsk,
        [EnumMember(Value = "Pacific/Tongatapu")]
        PacificTongatapu,
        [EnumMember(Value = "Asia/Chita")]
        AsiaChita,
        [EnumMember(Value = "Europe/Istanbul")]
        EuropeIstanbul,
        [EnumMember(Value = "America/Grand_Turk")]
        AmericaGrandTurk,
        [EnumMember(Value = "America/Indianapolis")]
        AmericaIndianapolis,
        [EnumMember(Value = "America/Indiana/Marengo")]
        AmericaIndianaMarengo,
        [EnumMember(Value = "America/Indiana/Vevay")]
        AmericaIndianaVevay,
        [EnumMember(Value = "America/Phoenix")]
        AmericaPhoenix,
        [EnumMember(Value = "America/Creston")]
        AmericaCreston,
        [EnumMember(Value = "America/Dawson_Creek")]
        AmericaDawsonCreek,
        [EnumMember(Value = "America/Fort_Nelson")]
        AmericaFortNelson,
        [EnumMember(Value = "America/Hermosillo")]
        AmericaHermosillo,
        [EnumMember(Value = "Etc/GMT+7")]
        EtcGMT7,
        [EnumMember(Value = "Etc/GMT-12")]
        EtcGMT12,
        [EnumMember(Value = "Pacific/Tarawa")]
        PacificTarawa,
        [EnumMember(Value = "Pacific/Majuro")]
        PacificMajuro,
        [EnumMember(Value = "Pacific/Kwajalein")]
        PacificKwajalein,
        [EnumMember(Value = "Pacific/Nauru")]
        PacificNauru,
        [EnumMember(Value = "Pacific/Funafuti")]
        PacificFunafuti,
        [EnumMember(Value = "Pacific/Wake")]
        PacificWake,
        [EnumMember(Value = "Pacific/Wallis")]
        PacificWallis,
        [EnumMember(Value = "Etc/GMT-13")]
        EtcGMT13,
        [EnumMember(Value = "Pacific/Enderbury")]
        PacificEnderbury,
        [EnumMember(Value = "Pacific/Fakaofo")]
        PacificFakaofo,
        [EnumMember(Value = "Etc/UTC")]
        EtcUTC,
        [EnumMember(Value = "Etc/GMT")]
        EtcGMT,
        [EnumMember(Value = "Etc/GMT+2")]
        EtcGMT2,
        [EnumMember(Value = "America/Noronha")]
        AmericaNoronha,
        [EnumMember(Value = "Atlantic/South_Georgia")]
        AtlanticSouthGeorgia,
        [EnumMember(Value = "Etc/GMT+8")]
        EtcGMT8,
        [EnumMember(Value = "Pacific/Pitcairn")]
        PacificPitcairn,
        [EnumMember(Value = "Etc/GMT+9")]
        EtcGMT9,
        [EnumMember(Value = "Pacific/Gambier")]
        PacificGambier,
        [EnumMember(Value = "Etc/GMT+11")]
        EtcGMT11,
        [EnumMember(Value = "Pacific/Pago_Pago")]
        PacificPagoPago,
        [EnumMember(Value = "Pacific/Niue")]
        PacificNiue,
        [EnumMember(Value = "Pacific/Midway")]
        PacificMidway,
        [EnumMember(Value = "Asia/Ulaanbaatar")]
        AsiaUlaanbaatar,
        [EnumMember(Value = "America/Caracas")]
        AmericaCaracas,
        [EnumMember(Value = "Asia/Vladivostok")]
        AsiaVladivostok,
        [EnumMember(Value = "Asia/Ust-Nera")]
        AsiaUstNera,
        [EnumMember(Value = "Europe/Volgograd")]
        EuropeVolgograd,
        [EnumMember(Value = "Australia/Perth")]
        AustraliaPerth,
        [EnumMember(Value = "Africa/Lagos")]
        AfricaLagos,
        [EnumMember(Value = "Africa/Luanda")]
        AfricaLuanda,
        [EnumMember(Value = "Africa/Porto-Novo")]
        AfricaPortoNovo,
        [EnumMember(Value = "Africa/Kinshasa")]
        AfricaKinshasa,
        [EnumMember(Value = "Africa/Bangui")]
        AfricaBangui,
        [EnumMember(Value = "Africa/Brazzaville")]
        AfricaBrazzaville,
        [EnumMember(Value = "Africa/Douala")]
        AfricaDouala,
        [EnumMember(Value = "Africa/Algiers")]
        AfricaAlgiers,
        [EnumMember(Value = "Africa/Libreville")]
        AfricaLibreville,
        [EnumMember(Value = "Africa/Malabo")]
        AfricaMalabo,
        [EnumMember(Value = "Africa/Niamey")]
        AfricaNiamey,
        [EnumMember(Value = "Africa/Ndjamena")]
        AfricaNdjamena,
        [EnumMember(Value = "Africa/Tunis")]
        AfricaTunis,
        [EnumMember(Value = "Etc/GMT-1")]
        EtcGMT1,
        [EnumMember(Value = "Europe/Berlin")]
        EuropeBerlin,
        [EnumMember(Value = "Europe/Andorra")]
        EuropeAndorra,
        [EnumMember(Value = "Europe/Vienna")]
        EuropeVienna,
        [EnumMember(Value = "Europe/Zurich")]
        EuropeZurich,
        [EnumMember(Value = "Europe/Busingen")]
        EuropeBusingen,
        [EnumMember(Value = "Europe/Gibraltar")]
        EuropeGibraltar,
        [EnumMember(Value = "Europe/Rome")]
        EuropeRome,
        [EnumMember(Value = "Europe/Vaduz")]
        EuropeVaduz,
        [EnumMember(Value = "Europe/Luxembourg")]
        EuropeLuxembourg,
        [EnumMember(Value = "Europe/Monaco")]
        EuropeMonaco,
        [EnumMember(Value = "Europe/Malta")]
        EuropeMalta,
        [EnumMember(Value = "Europe/Amsterdam")]
        EuropeAmsterdam,
        [EnumMember(Value = "Europe/Oslo")]
        EuropeOslo,
        [EnumMember(Value = "Europe/Stockholm")]
        EuropeStockholm,
        [EnumMember(Value = "Arctic/Longyearbyen")]
        ArcticLongyearbyen,
        [EnumMember(Value = "Europe/San_Marino")]
        EuropeSanMarino,
        [EnumMember(Value = "Europe/Vatican")]
        EuropeVatican,
        [EnumMember(Value = "Asia/Hovd")]
        AsiaHovd,
        [EnumMember(Value = "Asia/Tashkent")]
        AsiaTashkent,
        [EnumMember(Value = "Antarctica/Mawson")]
        AntarcticaMawson,
        [EnumMember(Value = "Asia/Oral")]
        AsiaOral,
        [EnumMember(Value = "Asia/Almaty")]
        AsiaAlmaty,
        [EnumMember(Value = "Asia/Aqtau")]
        AsiaAqtau,
        [EnumMember(Value = "Asia/Aqtobe")]
        AsiaAqtobe,
        [EnumMember(Value = "Asia/Atyrau")]
        AsiaAtyrau,
        [EnumMember(Value = "Asia/Qostanay")]
        AsiaQostanay,
        [EnumMember(Value = "Indian/Maldives")]
        IndianMaldives,
        [EnumMember(Value = "Indian/Kerguelen")]
        IndianKerguelen,
        [EnumMember(Value = "Asia/Dushanbe")]
        AsiaDushanbe,
        [EnumMember(Value = "Asia/Ashgabat")]
        AsiaAshgabat,
        [EnumMember(Value = "Asia/Samarkand")]
        AsiaSamarkand,
        [EnumMember(Value = "Etc/GMT-5")]
        EtcGMT5,
        [EnumMember(Value = "Asia/Hebron")]
        AsiaHebron,
        [EnumMember(Value = "Asia/Gaza")]
        AsiaGaza,
        [EnumMember(Value = "Pacific/Port_Moresby")]
        PacificPortMoresby,
        [EnumMember(Value = "Antarctica/DumontDUrville")]
        AntarcticaDumontDUrville,
        [EnumMember(Value = "Pacific/Truk")]
        PacificTruk,
        [EnumMember(Value = "Pacific/Guam")]
        PacificGuam,
        [EnumMember(Value = "Pacific/Saipan")]
        PacificSaipan,
        [EnumMember(Value = "Etc/GMT-10")]
        EtcGMT10,
        [EnumMember(Value = "Asia/Yakutsk")]
        AsiaYakutsk,
        [EnumMember(Value = "Asia/Khandyga")]
        AsiaKhandyga,
        [EnumMember(Value = "America/Whitehorse")]
        AmericaWhitehorse,
        [EnumMember(Value = "America/Dawson")]
        AmericaDawson,
        Iceland,
        [EnumMember(Value = "Africa/Timbuktu")]
        AfricaTimbuktu,
        Egypt,
        [EnumMember(Value = "Africa/Asmara")]
        AfricaAsmara,
        Libya,
        [EnumMember(Value = "America/Atka")]
        AmericaAtka,
        [EnumMember(Value = "US/Aleutian")]
        USAleutian,
        [EnumMember(Value = "US/Alaska")]
        USAlaska,
        [EnumMember(Value = "America/Argentina/Buenos_Aires")]
        AmericaArgentinaBuenosAires,
        [EnumMember(Value = "America/Argentina/Catamarca")]
        AmericaArgentinaCatamarca,
        [EnumMember(Value = "America/Argentina/ComodRivadavia")]
        AmericaArgentinaComodRivadavia,
        [EnumMember(Value = "America/Argentina/Cordoba")]
        AmericaArgentinaCordoba,
        [EnumMember(Value = "America/Rosario")]
        AmericaRosario,
        [EnumMember(Value = "America/Argentina/Jujuy")]
        AmericaArgentinaJujuy,
        [EnumMember(Value = "America/Argentina/Mendoza")]
        AmericaArgentinaMendoza,
        [EnumMember(Value = "US/Central")]
        USCentral,
        CST6CDT,
        [EnumMember(Value = "America/Shiprock")]
        AmericaShiprock,
        Navajo,
        [EnumMember(Value = "US/Mountain")]
        USMountain,
        MST7MDT,
        [EnumMember(Value = "US/Michigan")]
        USMichigan,
        [EnumMember(Value = "Canada/Mountain")]
        CanadaMountain,
        [EnumMember(Value = "America/Yellowknife")]
        AmericaYellowknife,
        [EnumMember(Value = "Canada/Atlantic")]
        CanadaAtlantic,
        Cuba,
        [EnumMember(Value = "America/Indiana/Indianapolis")]
        AmericaIndianaIndianapolis,
        [EnumMember(Value = "US/East-Indiana")]
        USEastIndiana,
        [EnumMember(Value = "America/Knox_IN")]
        AmericaKnoxIN,
        [EnumMember(Value = "US/Indiana-Starke")]
        USIndianaStarke,
        [EnumMember(Value = "America/Pangnirtung")]
        AmericaPangnirtung,
        Jamaica,
        [EnumMember(Value = "America/Kentucky/Louisville")]
        AmericaKentuckyLouisville,
        [EnumMember(Value = "US/Pacific")]
        USPacific,
        PST8PDT,
        [EnumMember(Value = "Brazil/West")]
        BrazilWest,
        [EnumMember(Value = "Mexico/BajaSur")]
        MexicoBajaSur,
        [EnumMember(Value = "Mexico/General")]
        MexicoGeneral,
        [EnumMember(Value = "US/Eastern")]
        USEastern,
        EST5EDT,
        [EnumMember(Value = "Brazil/DeNoronha")]
        BrazilDeNoronha,
        [EnumMember(Value = "America/Nuuk")]
        AmericaNuuk,
        [EnumMember(Value = "America/Atikokan")]
        AmericaAtikokan,
        EST,
        [EnumMember(Value = "US/Arizona")]
        USArizona,
        MST,
        [EnumMember(Value = "America/Virgin")]
        AmericaVirgin,
        [EnumMember(Value = "Canada/Saskatchewan")]
        CanadaSaskatchewan,
        [EnumMember(Value = "America/Porto_Acre")]
        AmericaPortoAcre,
        [EnumMember(Value = "Brazil/Acre")]
        BrazilAcre,
        [EnumMember(Value = "Chile/Continental")]
        ChileContinental,
        [EnumMember(Value = "Brazil/East")]
        BrazilEast,
        [EnumMember(Value = "Canada/Newfoundland")]
        CanadaNewfoundland,
        [EnumMember(Value = "America/Ensenada")]
        AmericaEnsenada,
        [EnumMember(Value = "Mexico/BajaNorte")]
        MexicoBajaNorte,
        [EnumMember(Value = "America/Santa_Isabel")]
        AmericaSantaIsabel,
        [EnumMember(Value = "America/Montreal")]
        AmericaMontreal,
        [EnumMember(Value = "Canada/Eastern")]
        CanadaEastern,
        [EnumMember(Value = "America/Nipigon")]
        AmericaNipigon,
        [EnumMember(Value = "America/Thunder_Bay")]
        AmericaThunderBay,
        [EnumMember(Value = "Canada/Pacific")]
        CanadaPacific,
        [EnumMember(Value = "Canada/Yukon")]
        CanadaYukon,
        [EnumMember(Value = "Canada/Central")]
        CanadaCentral,
        [EnumMember(Value = "America/Rainy_River")]
        AmericaRainyRiver,
        [EnumMember(Value = "Asia/Ashkhabad")]
        AsiaAshkhabad,
        [EnumMember(Value = "Asia/Dacca")]
        AsiaDacca,
        [EnumMember(Value = "Asia/Ho_Chi_Minh")]
        AsiaHoChiMinh,
        Hongkong,
        [EnumMember(Value = "Asia/Tel_Aviv")]
        AsiaTelAviv,
        Israel,
        [EnumMember(Value = "Asia/Kathmandu")]
        AsiaKathmandu,
        [EnumMember(Value = "Asia/Kolkata")]
        AsiaKolkata,
        [EnumMember(Value = "Asia/Macao")]
        AsiaMacao,
        [EnumMember(Value = "Asia/Ujung_Pandang")]
        AsiaUjungPandang,
        [EnumMember(Value = "Europe/Nicosia")]
        EuropeNicosia,
        ROK,
        [EnumMember(Value = "Asia/Chongqing")]
        AsiaChongqing,
        [EnumMember(Value = "Asia/Chungking")]
        AsiaChungking,
        [EnumMember(Value = "Asia/Harbin")]
        AsiaHarbin,
        PRC,
        Singapore,
        ROC,
        Iran,
        [EnumMember(Value = "Asia/Thimbu")]
        AsiaThimbu,
        Japan,
        [EnumMember(Value = "Asia/Ulan_Bator")]
        AsiaUlanBator,
        [EnumMember(Value = "Asia/Choibalsan")]
        AsiaChoibalsan,
        [EnumMember(Value = "Asia/Kashgar")]
        AsiaKashgar,
        [EnumMember(Value = "Asia/Yangon")]
        AsiaYangon,
        [EnumMember(Value = "Atlantic/Faroe")]
        AtlanticFaroe,
        [EnumMember(Value = "Australia/South")]
        AustraliaSouth,
        [EnumMember(Value = "Australia/Queensland")]
        AustraliaQueensland,
        [EnumMember(Value = "Australia/Yancowinna")]
        AustraliaYancowinna,
        [EnumMember(Value = "Australia/North")]
        AustraliaNorth,
        [EnumMember(Value = "Australia/Tasmania")]
        AustraliaTasmania,
        [EnumMember(Value = "Australia/Currie")]
        AustraliaCurrie,
        [EnumMember(Value = "Australia/LHI")]
        AustraliaLHI,
        [EnumMember(Value = "Australia/Victoria")]
        AustraliaVictoria,
        [EnumMember(Value = "Australia/West")]
        AustraliaWest,
        [EnumMember(Value = "Australia/ACT")]
        AustraliaACT,
        [EnumMember(Value = "Australia/Canberra")]
        AustraliaCanberra,
        [EnumMember(Value = "Australia/NSW")]
        AustraliaNSW,
        [EnumMember(Value = "Etc/GMT+0")]
        EtcGMT0,
        [EnumMember(Value = "Etc/GMT-0")]
        EtcGMT0,
        [EnumMember(Value = "Etc/GMT0")]
        EtcGMT0,
        [EnumMember(Value = "Etc/Greenwich")]
        EtcGreenwich,
        GMT,
        [EnumMember(Value = "GMT+0")]
        GMT0,
        [EnumMember(Value = "GMT-0")]
        GMT0,
        GMT0,
        Greenwich,
        [EnumMember(Value = "Etc/UCT")]
        EtcUCT,
        [EnumMember(Value = "Etc/Universal")]
        EtcUniversal,
        [EnumMember(Value = "Etc/Zulu")]
        EtcZulu,
        UCT,
        UTC,
        Universal,
        Zulu,
        EET,
        [EnumMember(Value = "Atlantic/Jan_Mayen")]
        AtlanticJanMayen,
        CET,
        MET,
        [EnumMember(Value = "Europe/Tiraspol")]
        EuropeTiraspol,
        Eire,
        [EnumMember(Value = "Asia/Istanbul")]
        AsiaIstanbul,
        Turkey,
        [EnumMember(Value = "Europe/Kyiv")]
        EuropeKyiv,
        [EnumMember(Value = "Europe/Zaporozhye")]
        EuropeZaporozhye,
        [EnumMember(Value = "Europe/Uzhgorod")]
        EuropeUzhgorod,
        Portugal,
        WET,
        [EnumMember(Value = "Europe/Belfast")]
        EuropeBelfast,
        GB,
        [EnumMember(Value = "GB-Eire")]
        GBEire,
        [EnumMember(Value = "W-SU")]
        WSU,
        Poland,
        [EnumMember(Value = "Antarctica/South_Pole")]
        AntarcticaSouthPole,
        NZ,
        [EnumMember(Value = "NZ-CHAT")]
        NZCHAT,
        [EnumMember(Value = "Chile/EasterIsland")]
        ChileEasterIsland,
        [EnumMember(Value = "Pacific/Pohnpei")]
        PacificPohnpei,
        [EnumMember(Value = "US/Hawaii")]
        USHawaii,
        [EnumMember(Value = "Pacific/Johnston")]
        PacificJohnston,
        HST,
        [EnumMember(Value = "Pacific/Kanton")]
        PacificKanton,
        Kwajalein,
        [EnumMember(Value = "Pacific/Samoa")]
        PacificSamoa,
        [EnumMember(Value = "US/Samoa")]
        USSamoa,
        [EnumMember(Value = "Pacific/Chuuk")]
        PacificChuuk,
        [EnumMember(Value = "Pacific/Yap")]
        PacificYap,
        [EnumMember(Value = "America/Fort_Wayne")]
        AmericaFortWayne,
        [EnumMember(Value = "Antarctica/Troll")]
        AntarcticaTroll
    }

    public enum requesttemplateEngineInput
    {
        Classic,
        Modern
    }

    public class DocumentProcessingResponse
    {
        [JsonProperty("fileContent")]
        public string ResultFile { get; set; }
    }

    public class ApplyHtmlTemplateResponse
    {
        [JsonProperty("htmlResult")]
        public string ResultHTML { get; set; }
    }

    public enum requestengineInput
    {
        Modern,
        Classic
    }

    public enum requestpaperSizeInput
    {
        A4,
        Letter,
        LetterSmall,
        Tabloid,
        Ledger,
        Legal,
        Statement,
        Executive,
        A2,
        A3,
        A4Small,
        A5,
        B4,
        B5
    }

    public enum requestorientationInput
    {
        Portrait,
        Landscape
    }

    public class DocumentsWithFilenamesResponse
    {
        [JsonProperty("resultFiles")]
        public DocumentContentWithFilenameResponse[] ResultFiles { get; set; }
    }

    public class DocumentContentWithFilenameResponse
    {
        [JsonProperty("filename")]
        public string Filename { get; set; }

        [JsonProperty("fileContent")]
        public string FileContent { get; set; }
    }

    public enum typeInput
    {
        Text,
        Image,
        Pdf
    }

    public class MergeAny2PdfFileData
    {
        [JsonProperty("fileName")]
        public string Filename { get; set; }

        [JsonProperty("content")]
        public string FileContent { get; set; }
    }

    public enum requestresultTypeInput
    {
        Raw,
        HTML
    }

    public enum requestimageFormatInput
    {
        Jpeg,
        Png,
        Gif,
        Bmp
    }

    public class GetPdfProtectionInfoResponse
    {
        [JsonProperty("isPasswordProtected")]
        public bool IsPasswordProtected { get; set; }
    }

    public enum requestlosslessModeInput
    {
        On,
        Off
    }

    public enum requestdelimiterInput
    {
        Comma,
        Semicolon,
        Tab,
        Pipe
    }

    public class Csv2XlsxColumnMapping
    {
        [JsonProperty("csvColumnIndexOrName")]
        public string CSVColumnNameOrIndex { get; set; }

        [JsonProperty("xlsxColumnType")]
        public Csv2XlsxColumnMappingXLSXColumnTypeType XLSXColumnType { get; set; }

        [JsonProperty("xlsxColumnName")]
        public string XLSXColumnName { get; set; }
    }

    public enum Csv2XlsxColumnMappingXLSXColumnTypeType
    {
        General,
        Text,
        Integer,
        TwoDecimal,
        ThousandInteger,
        ThousandTwoDecimal,
        IntegerPercentage,
        TwoDecimalPercentage,
        Scientific,
        ShortDate,
        ShortDateTime,
        LongDate
    }

    public class Json2XlsxColumnMapping
    {
        [JsonProperty("jsonProperty")]
        public string JSONProperty { get; set; }

        [JsonProperty("xlsxColumnType")]
        public Json2XlsxColumnMappingXLSXColumnTypeType XLSXColumnType { get; set; }

        [JsonProperty("xlsxColumnName")]
        public string XLSXColumnName { get; set; }
    }

    public enum Json2XlsxColumnMappingXLSXColumnTypeType
    {
        General,
        Text,
        Integer,
        TwoDecimal,
        ThousandInteger,
        ThousandTwoDecimal,
        IntegerPercentage,
        TwoDecimalPercentage,
        Scientific,
        ShortDate,
        ShortDateTime,
        LongDate
    }

    public class StringResultResponse
    {
        [JsonProperty("result")]
        public string Result { get; set; }
    }

    public class BooleanResultResponse
    {
        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }
    }

    public class FileData
    {
        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("content")]
        public string FileContent { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Plumsail;

    public partial class WorkflowManagedActions
    {
        public PlumsailActions Plumsail(string connectionId) => new PlumsailActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PlumsailTriggers Plumsail(string connectionId) => new PlumsailTriggers(connectionId);
    }
}