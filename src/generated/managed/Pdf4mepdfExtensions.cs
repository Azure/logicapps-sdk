//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4mepdf
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Pdf4mepdfActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GenerateDocumentUsingTemplate(Expression<Func<GenerateDocumentUsingTemplateBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/GenerateDocumentSingleV2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> AddPageNumber(Expression<Func<AddPageNumberBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/AddPageNumber";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> _1ResizeDocument(Expression<Func<_1ResizeDocumentBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ResizePdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> AddAttachmentToPdf(Expression<Func<AddAttachmentToPdfBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/AddAttachmentToPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> AddFormField(Expression<Func<AddFormFieldBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/AddFormField";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> AddHtmlHeaderFooter(Expression<Func<AddHtmlHeaderFooterBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/AddHtmlHeaderFooter";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> AddMargin(Expression<Func<AddMarginBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/AddMargin";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<ClassifyDocumentResponse, ApiConnectionActionConfiguration> ClassifyDocument(Expression<Func<ClassifyDocumentBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ClassifyDocumentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ClassifyDocument";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ClassifyDocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> CreatePdfA(Expression<Func<CreatePdfABodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/PdfA";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> CreateZugferdInvoice(Expression<Func<CreateZugferdInvoiceSchemaValInput>> schemaVal = null, Expression<Func<object>> operation = null)
        {
            var __workflow_schemaVal = WorkflowExpression.Compile(schemaVal, nameof(schemaVal), required: false);
            var __workflow_operation = WorkflowExpression.Compile(operation, nameof(operation), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/CreateZugferdInvoiceV2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["schemaVal"] = Convert.ToString("2.0-XML");
                if (__workflow_schemaVal != null)
                    callPayload.Queries["schemaVal"] = ExpressionConverter.Convert(__workflow_schemaVal);
                if (__workflow_operation != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_operation);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> CropPdf(Expression<Func<CropPdfBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/CropPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CustomApi(Expression<Func<string>> featurePath, Expression<Func<string>> contentType, Expression<Func<string>> body = null)
        {
            var __workflow_featurePath = WorkflowExpression.Compile(featurePath, nameof(featurePath), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/FlowV2/{0}", __workflow_featurePath.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-type"] = ExpressionConverter.Convert(__workflow_contentType);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                else
                    callPayload.Body = ("{\"docContent\":\"\"}").ToJToken();
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> DeleteBlankPages(Expression<Func<DeleteBlankPagesBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/DeleteBlankPages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> DeletePages(Expression<Func<DeletePagesBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/DeletePages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> DigitalSignPdf(Expression<Func<DigitalSignPdfBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/DigitalSignPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<ExtractAttachmentFromPdfResponse, ApiConnectionActionConfiguration> ExtractAttachmentFromPdf(Expression<Func<ExtractAttachmentFromPdfBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ExtractAttachmentFromPdfResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ExtractAttachmentFromPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ExtractAttachmentFromPdfResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ExtractPages(Expression<Func<DeletePagesBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/Extract";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<ExtractPdfFormDataResponse, ApiConnectionActionConfiguration> ExtractPdfFormData(Expression<Func<ExtractAttachmentFromPdfBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ExtractPdfFormDataResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ExtractPdfFormData";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ExtractPdfFormDataResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<ExtractResourcesResponse, ApiConnectionActionConfiguration> ExtractResources(Expression<Func<ExtractResourcesBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ExtractResourcesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ExtractResources";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ExtractResourcesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<ExtractTableFromPdfResponse, ApiConnectionActionConfiguration> ExtractTableFromPdf(Expression<Func<ExtractAttachmentFromPdfBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ExtractTableFromPdfResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ExtractTableFromPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ExtractTableFromPdfResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<ExtractTextByExpressionResponse, ApiConnectionActionConfiguration> ExtractTextByExpression(Expression<Func<ExtractTextByExpressionBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ExtractTextByExpressionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ExtractTextByExpression";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ExtractTextByExpressionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> FindAndReplace(Expression<Func<FindAndReplaceBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/FindAndReplaceV2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> FlattenPdf(Expression<Func<ExtractAttachmentFromPdfBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/FlattenPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GenerateDocumentFromPdf(Expression<Func<GenerateDocumentFromPdfBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/GenerateDocumentFromPdfV2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<GenerateDocumentMultipleResponse, ApiConnectionActionConfiguration> GenerateDocumentMultiple(Expression<Func<GenerateDocumentMultipleBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GenerateDocumentMultipleResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/GenerateDocumentMultiple";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GenerateDocumentMultipleResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GenerateDocumentSingle(Expression<Func<GenerateDocumentSingleBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/GenerateDocumentSingle";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<GetPdfMetadataResponse, ApiConnectionActionConfiguration> GetPdfMetadata(Expression<Func<ExtractAttachmentFromPdfBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GetPdfMetadataResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/GetPdfMetadata";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetPdfMetadataResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> HighlightText(Expression<Func<HighlightTextBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/HighlightText";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ImageStamp(Expression<Func<ImageStampBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ImageStamp";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> LinearizePdf(Expression<Func<LinearizePdfBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/LinearizePdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> Merge(Expression<Func<MergeBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/Merge";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> MergeOverlay(Expression<Func<MergeOverlayBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/MergeOverlay";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> Optimize(Expression<Func<OptimizeBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/Optimize";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<ParseDocumentResponse, ApiConnectionActionConfiguration> ParseDocument(Expression<Func<ParseDocumentBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ParseDocumentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ParseDocument";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ParseDocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> PdfOcr(Expression<Func<PdfOcrBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ConvertOcrPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> PrepareForPrint(Expression<Func<PrepareForPrintSchemaValInput>> schemaVal = null, Expression<Func<object>> operation = null)
        {
            var __workflow_schemaVal = WorkflowExpression.Compile(schemaVal, nameof(schemaVal), required: false);
            var __workflow_operation = WorkflowExpression.Compile(operation, nameof(operation), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/PrepareForPrint";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["schemaVal"] = Convert.ToString("A4");
                if (__workflow_schemaVal != null)
                    callPayload.Queries["schemaVal"] = ExpressionConverter.Convert(__workflow_schemaVal);
                if (__workflow_operation != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_operation);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ProtectDocument(Expression<Func<ProtectDocumentBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/Protect";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> RedactPdf(Expression<Func<RedactPdfBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/RedactPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> RepairPdf(Expression<Func<ExtractAttachmentFromPdfBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/RepairPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ReplaceTextWithImage(Expression<Func<ReplaceTextWithImageBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ReplaceTextWithImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> RotateDocument(Expression<Func<RotateDocumentBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/Rotate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> RotatePage(Expression<Func<RotatePageBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/RotatePage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> SetPdfMetadata(Expression<Func<SetPdfMetadataBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/SetPDFMetadata";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> SignPdf(Expression<Func<SignPdfBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/SignPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<SplitByTextResponse, ApiConnectionActionConfiguration> SplitByText(Expression<Func<SplitByTextBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SplitByTextResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/SplitByText";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SplitByTextResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<SplitDocumentResponse, ApiConnectionActionConfiguration> SplitDocument(Expression<Func<SplitDocumentBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SplitDocumentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/SplitPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SplitDocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> Stamp(Expression<Func<StampBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/Stamp";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<StartPdf4meWfResponse, ApiConnectionActionConfiguration> StartPdf4meWf(Expression<Func<StartPdf4meWfBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<StartPdf4meWfResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ExecuteWfTrigger";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<StartPdf4meWfResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> Unlock(Expression<Func<UnlockBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/Unlock";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<UploadBlobAllResponse, ApiConnectionActionConfiguration> UploadBlobAll(Expression<Func<UploadBlobAllBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UploadBlobAllResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/UploadBlobAll";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UploadBlobAllResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<ValidatePdfaResponse, ApiConnectionActionConfiguration> ValidatePdfa(Expression<Func<ExtractAttachmentFromPdfBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ValidatePdfaResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ValidatePDFA";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ValidatePdfaResponse>(callPayload);
            });
        }
    }

    public class Pdf4mepdfTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<string, ApiConnectionPollingTriggerConfiguration> GetDocumentFromPdf4me(Expression<Func<GetDocumentFromPdf4meBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<string, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/WebhookSubscribe";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger<string>(callPayload);
            });
        }
    }

    public class GenerateDocumentUsingTemplateBodyInput
    {
        [JsonProperty("templateFileName")]
        public string TemplateName { get; set; }

        [JsonProperty("documentDataType", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputDocumentDataTypeType? DocumentDataType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4mepdf.BodyInputDocumentDataTypeType.Json;

        [JsonProperty("documentDataText")]
        public string DocumentDataText { get; set; }

        [JsonProperty("documentDataFile")]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocumentDataFile { get; set; }

        [JsonProperty("metaDataJson")]
        public string MetadataJson { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputDocumentDataTypeType
    {
        Json,
        [EnumMember(Value = "XML")]
        Xml
    }

    public class AddPageNumberBodyInput
    {
        public AddPageNumberBodyInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent docContent, string docName)
        {
            this.DocContent = docContent;
            this.DocName = docName;
        }

        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("docName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocName { get; set; }

        [JsonProperty("pageNumberFormat", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PageNumberFormat { get; set; } = "# of {totalPages}";

        [JsonProperty("alignX", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddPageNumberBodyInputAlignXType AlignX { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4mepdf.AddPageNumberBodyInputAlignXType.Left;

        [JsonProperty("alignY", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddPageNumberBodyInputAlignYType AlignY { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4mepdf.AddPageNumberBodyInputAlignYType.Top;

        [JsonProperty("marginXinMM", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MarginXinMM { get; set; } = 0;

        [JsonProperty("marginYinMM", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MarginYinMM { get; set; } = 0;

        [JsonProperty("fontSize", DefaultValueHandling = DefaultValueHandling.Include)]
        public int FontSize { get; set; } = 12;

        [JsonProperty("isBold", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IsBold { get; set; } = false;

        [JsonProperty("isItalic", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IsItalic { get; set; } = false;

        [JsonProperty("skipFirstPage", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SkipFirstPage { get; set; } = false;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddPageNumberBodyInputAlignXType
    {
        Left,
        Center,
        Right
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddPageNumberBodyInputAlignYType
    {
        Top,
        Middle,
        Bottom
    }

    public class _1ResizeDocumentBodyInput
    {
        public _1ResizeDocumentBodyInput(bool isPageSizeRequested)
        {
            this.IsPageSizeRequested = isPageSizeRequested;
        }

        [JsonProperty("docContent")]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document")]
        public AddAttachmentToPdfBodyInputDocumentType Document { get; set; }

        [JsonProperty("pageSequence", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PageSequence { get; set; } = "all";

        [JsonProperty("isPageSizeRequested", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool IsPageSizeRequested { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputPageSizeType PageSize { get; set; } = new BodyInputPageSizeType();

        [JsonProperty("paddingTop", DefaultValueHandling = DefaultValueHandling.Include)]
        public double? PaddingTop { get; set; } = 0;

        [JsonProperty("paddingBottom", DefaultValueHandling = DefaultValueHandling.Include)]
        public double? PaddingBottom { get; set; } = 0;

        [JsonProperty("paddingLeft", DefaultValueHandling = DefaultValueHandling.Include)]
        public double? PaddingLeft { get; set; } = 0;

        [JsonProperty("paddingRight", DefaultValueHandling = DefaultValueHandling.Include)]
        public double? PaddingRight { get; set; } = 0;
    }

    public class AddAttachmentToPdfBodyInputDocumentType
    {
        public AddAttachmentToPdfBodyInputDocumentType(string name)
        {
            this.Name = name;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
    }

    public class BodyInputPageSizeType
    {
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputPageSizeTypeTypeType Type { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4mepdf.BodyInputPageSizeTypeTypeType.A4;

        [JsonProperty("customWidth")]
        public string CustomWidth { get; set; }

        [JsonProperty("customHeight")]
        public string CustomHeight { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputPageSizeTypeTypeType
    {
        Custom,
        A0,
        A1,
        A2,
        A3,
        A4,
        A5,
        A6,
        B5,
        Letter,
        Legal,
        Ledger,
        [EnumMember(Value = "p11x17")]
        P11x17
    }

    public class AddAttachmentToPdfBodyInput
    {
        public AddAttachmentToPdfBodyInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent docContent, AddAttachmentToPdfBodyInputDocumentType document, BodyInputAttachmentsTypeItem[] attachments)
        {
            this.DocContent = docContent;
            this.Document = document;
            this.Attachments = attachments;
        }

        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddAttachmentToPdfBodyInputDocumentType Document { get; set; }

        [JsonProperty("attachments", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputAttachmentsTypeItem[] Attachments { get; set; }
    }

    public class BodyInputAttachmentsTypeItem
    {
        [JsonProperty("docContent")]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document")]
        public BodyInputAttachmentsTypeItemDocumentType Document { get; set; }
    }

    public class BodyInputAttachmentsTypeItemDocumentType
    {
        public BodyInputAttachmentsTypeItemDocumentType(string name)
        {
            this.Name = name;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
    }

    public class AddFormFieldBodyInput
    {
        public AddFormFieldBodyInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent docContent, AddAttachmentToPdfBodyInputDocumentType document, string fieldName)
        {
            this.DocContent = docContent;
            this.Document = document;
            this.FieldName = fieldName;
        }

        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddAttachmentToPdfBodyInputDocumentType Document { get; set; }

        [JsonProperty("fieldName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FieldName { get; set; }

        [JsonProperty("formFieldType", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputFormFieldTypeType FormFieldType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4mepdf.BodyInputFormFieldTypeType.TextBox;

        [JsonProperty("initialValue")]
        public string InitialValue { get; set; }

        [JsonProperty("positionX", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? PositionX { get; set; } = 0;

        [JsonProperty("positionY", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? PositionY { get; set; } = 0;

        [JsonProperty("pages", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Pages { get; set; } = "1";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputFormFieldTypeType
    {
        TextBox,
        CheckBox
    }

    public class AddHtmlHeaderFooterBodyInput
    {
        public AddHtmlHeaderFooterBodyInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent docContent, AddAttachmentToPdfBodyInputDocumentType document, string htmlContent)
        {
            this.DocContent = docContent;
            this.Document = document;
            this.HtmlContent = htmlContent;
        }

        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddAttachmentToPdfBodyInputDocumentType Document { get; set; }

        [JsonProperty("htmlContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public string HtmlContent { get; set; }

        [JsonProperty("location", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputLocationType? Location { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4mepdf.BodyInputLocationType.Header;

        [JsonProperty("pages", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Pages { get; set; } = "all";

        [JsonProperty("skipFirstPage", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SkipFirstPage { get; set; } = false;

        [JsonProperty("marginLeft")]
        public string MarginLeft { get; set; }

        [JsonProperty("marginRight")]
        public string MarginRight { get; set; }

        [JsonProperty("marginTop")]
        public string MarginTop { get; set; }

        [JsonProperty("marginBottom")]
        public string MarginBottom { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputLocationType
    {
        Header,
        Footer,
        Both
    }

    public class AddMarginBodyInput
    {
        public AddMarginBodyInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent docContent, AddAttachmentToPdfBodyInputDocumentType document, string marginLeft, string marginRight, string marginTop, string marginBottom)
        {
            this.DocContent = docContent;
            this.Document = document;
            this.MarginLeft = marginLeft;
            this.MarginRight = marginRight;
            this.MarginTop = marginTop;
            this.MarginBottom = marginBottom;
        }

        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddAttachmentToPdfBodyInputDocumentType Document { get; set; }

        [JsonProperty("marginLeft", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MarginLeft { get; set; }

        [JsonProperty("marginRight", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MarginRight { get; set; }

        [JsonProperty("marginTop", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MarginTop { get; set; }

        [JsonProperty("marginBottom", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MarginBottom { get; set; }
    }

    public class ClassifyDocumentResponse
    {
        [JsonProperty("className")]
        public string ClassName { get; set; }
    }

    public class ClassifyDocumentBodyInput
    {
        public ClassifyDocumentBodyInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent docContent)
        {
            this.DocContent = docContent;
        }

        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document")]
        public ClassifyDocumentBodyInputDocumentType Document { get; set; }
    }

    public class ClassifyDocumentBodyInputDocumentType
    {
        public string Name { get; set; }
    }

    public class CreatePdfABodyInput
    {
        public CreatePdfABodyInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent docContent, AddAttachmentToPdfBodyInputDocumentType document)
        {
            this.DocContent = docContent;
            this.Document = document;
        }

        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddAttachmentToPdfBodyInputDocumentType Document { get; set; }

        [JsonProperty("compliance", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputComplianceType Compliance { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4mepdf.BodyInputComplianceType.PdfA1b;

        [JsonProperty("allowUpgrade", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AllowUpgrade { get; set; } = true;

        [JsonProperty("allowDowngrade", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AllowDowngrade { get; set; } = true;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputComplianceType
    {
        PdfA1b,
        PdfA1a,
        PdfA2b,
        PdfA2u,
        PdfA2a,
        PdfA3b,
        PdfA3u,
        PdfA3a
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateZugferdInvoiceSchemaValInput
    {
        [EnumMember(Value = "1.0-XML")]
        _10Xml,
        [EnumMember(Value = "1.0-JSON")]
        _10Json,
        [EnumMember(Value = "1.0-CSV")]
        _10Csv,
        [EnumMember(Value = "2.0-XML")]
        _20Xml,
        [EnumMember(Value = "2.0-JSON")]
        _20Json,
        [EnumMember(Value = "2.0-CSV")]
        _20Csv
    }

    public class CropPdfBodyInput
    {
        public CropPdfBodyInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent docContent, AddAttachmentToPdfBodyInputDocumentType document, BodyInputCropTypeType cropType)
        {
            this.DocContent = docContent;
            this.Document = document;
            this.CropType = cropType;
        }

        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddAttachmentToPdfBodyInputDocumentType Document { get; set; }

        [JsonProperty("cropType", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputCropTypeType CropType { get; set; }

        [JsonProperty("leftBorder", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? LeftBorder { get; set; } = 0;

        [JsonProperty("rightBorder", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? RightBorder { get; set; } = 0;

        [JsonProperty("topBorder", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? TopBorder { get; set; } = 0;

        [JsonProperty("bottomBorder", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? BottomBorder { get; set; } = 0;

        [JsonProperty("lowerLeftX", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? LowerLeftX { get; set; } = 0;

        [JsonProperty("lowerLeftY", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? LowerLeftY { get; set; } = 0;

        [JsonProperty("width", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Width { get; set; } = 0;

        [JsonProperty("height", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Height { get; set; } = 0;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputCropTypeType
    {
        Border,
        Rectangle
    }

    public class DeleteBlankPagesBodyInput
    {
        public DeleteBlankPagesBodyInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent docContent, AddAttachmentToPdfBodyInputDocumentType document)
        {
            this.DocContent = docContent;
            this.Document = document;
        }

        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddAttachmentToPdfBodyInputDocumentType Document { get; set; }

        [JsonProperty("deletePageOption", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputDeletePageOptionType DeletePageOption { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4mepdf.BodyInputDeletePageOptionType.NoTextNoImages;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputDeletePageOptionType
    {
        NoTextNoImages,
        NoText,
        NoImages
    }

    public class DeletePagesBodyInput
    {
        public DeletePagesBodyInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent docContent, AddAttachmentToPdfBodyInputDocumentType document, string pageNumbers)
        {
            this.DocContent = docContent;
            this.Document = document;
            this.PageNumbers = pageNumbers;
        }

        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddAttachmentToPdfBodyInputDocumentType Document { get; set; }

        [JsonProperty("pageNumbers", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PageNumbers { get; set; }
    }

    public class DigitalSignPdfBodyInput
    {
        public DigitalSignPdfBodyInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent docContent, AddAttachmentToPdfBodyInputDocumentType document, global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent signCertificate, string signCertificatePassword)
        {
            this.DocContent = docContent;
            this.Document = document;
            this.SignCertificate = signCertificate;
            this.SignCertificatePassword = signCertificatePassword;
        }

        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddAttachmentToPdfBodyInputDocumentType Document { get; set; }

        [JsonProperty("signCertificate", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent SignCertificate { get; set; }

        [JsonProperty("signCertificatePassword", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SignCertificatePassword { get; set; }

        [JsonProperty("pageNr", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PageNr { get; set; } = "1";

        [JsonProperty("marginX", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MarginX { get; set; } = 0;

        [JsonProperty("marginY", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MarginY { get; set; } = 0;

        [JsonProperty("width", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Width { get; set; } = 100;

        [JsonProperty("height", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Height { get; set; } = 100;

        [JsonProperty("sigLocation")]
        public string SigLocation { get; set; }

        [JsonProperty("signerName")]
        public string SignerName { get; set; }

        [JsonProperty("sigReason")]
        public string SigReason { get; set; }

        [JsonProperty("visible", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Visible { get; set; } = true;
    }

    public class ExtractAttachmentFromPdfResponse
    {
        [JsonProperty("outputDocuments")]
        public ExtractAttachmentFromPdfResponseOutputDocumentsTypeItem[] OutputDocuments { get; set; }
    }

    public class ExtractAttachmentFromPdfResponseOutputDocumentsTypeItem
    {
        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("streamFile")]
        public string StreamFile { get; set; }
    }

    public class ExtractAttachmentFromPdfBodyInput
    {
        public ExtractAttachmentFromPdfBodyInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent docContent, AddAttachmentToPdfBodyInputDocumentType document)
        {
            this.DocContent = docContent;
            this.Document = document;
        }

        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddAttachmentToPdfBodyInputDocumentType Document { get; set; }
    }

    public class ExtractPdfFormDataResponse
    {
        [JsonProperty("traceId")]
        public string TraceId { get; set; }

        [JsonProperty("formData")]
        public JToken FormData { get; set; }
    }

    public class ExtractResourcesResponse
    {
        [JsonProperty("texts")]
        public string[] Texts { get; set; }

        [JsonProperty("images")]
        public ExtractResourcesResponseImagesTypeItem[] Images { get; set; }
    }

    public class ExtractResourcesResponseImagesTypeItem
    {
        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("streamFile")]
        public string StreamFile { get; set; }
    }

    public class ExtractResourcesBodyInput
    {
        public ExtractResourcesBodyInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent docContent, AddAttachmentToPdfBodyInputDocumentType document)
        {
            this.DocContent = docContent;
            this.Document = document;
        }

        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddAttachmentToPdfBodyInputDocumentType Document { get; set; }

        [JsonProperty("extractText", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ExtractText { get; set; } = true;

        [JsonProperty("extractImages", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ExtractImages { get; set; } = true;
    }

    public class ExtractTableFromPdfResponse
    {
        [JsonProperty("tableList")]
        public ExtractTableFromPdfResponseTableListTypeItem[] TableList { get; set; }
    }

    public class ExtractTableFromPdfResponseTableListTypeItem
    {
        [JsonProperty("pageNumber")]
        public int PageNumber { get; set; }

        [JsonProperty("table")]
        public string[][] Table { get; set; }
    }

    public class ExtractTextByExpressionResponse
    {
        [JsonProperty("textList")]
        public string[] TextList { get; set; }
    }

    public class ExtractTextByExpressionBodyInput
    {
        public ExtractTextByExpressionBodyInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent docContent, AddAttachmentToPdfBodyInputDocumentType document, string expression)
        {
            this.DocContent = docContent;
            this.Document = document;
            this.Expression = expression;
        }

        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddAttachmentToPdfBodyInputDocumentType Document { get; set; }

        [JsonProperty("expression", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Expression { get; set; }

        [JsonProperty("pageSequence", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PageSequence { get; set; } = "all";
    }

    public class FindAndReplaceBodyInput
    {
        public FindAndReplaceBodyInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent docContent, AddAttachmentToPdfBodyInputDocumentType document)
        {
            this.DocContent = docContent;
            this.Document = document;
        }

        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddAttachmentToPdfBodyInputDocumentType Document { get; set; }

        [JsonProperty("findReplaceList")]
        public BodyInputFindReplaceListTypeItem[] FindReplaceList { get; set; }
    }

    public class BodyInputFindReplaceListTypeItem
    {
        public BodyInputFindReplaceListTypeItem(string oldText, string newText)
        {
            this.OldText = oldText;
            this.NewText = newText;
        }

        [JsonProperty("oldText", DefaultValueHandling = DefaultValueHandling.Include)]
        public string OldText { get; set; }

        [JsonProperty("newText", DefaultValueHandling = DefaultValueHandling.Include)]
        public string NewText { get; set; }

        [JsonProperty("pageSequence", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PageSequence { get; set; } = "all";
    }

    public class GenerateDocumentFromPdfBodyInput
    {
        public GenerateDocumentFromPdfBodyInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent templateDocContent, string templateDocName, string dataArray)
        {
            this.TemplateDocContent = templateDocContent;
            this.TemplateDocName = templateDocName;
            this.DataArray = dataArray;
        }

        [JsonProperty("templateDocContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent TemplateDocContent { get; set; }

        [JsonProperty("templateDocName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TemplateDocName { get; set; }

        [JsonProperty("dataArray", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DataArray { get; set; }

        [JsonProperty("keepPdfEditable", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? KeepPdfEditable { get; set; } = false;
    }

    public class GenerateDocumentMultipleResponse
    {
        [JsonProperty("outputDocuments")]
        public GenerateDocumentMultipleResponseOutputDocumentsTypeItem[] OutputDocuments { get; set; }
    }

    public class GenerateDocumentMultipleResponseOutputDocumentsTypeItem
    {
        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("streamFile")]
        public string StreamFile { get; set; }
    }

    public class GenerateDocumentMultipleBodyInput
    {
        public GenerateDocumentMultipleBodyInput(string templateFileName, global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent templateFileData)
        {
            this.TemplateFileName = templateFileName;
            this.TemplateFileData = templateFileData;
        }

        [JsonProperty("templateFileType", DefaultValueHandling = DefaultValueHandling.Include)]
        public GenerateDocumentMultipleBodyInputTemplateFileTypeType TemplateFileType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4mepdf.GenerateDocumentMultipleBodyInputTemplateFileTypeType.Docx;

        [JsonProperty("templateFileName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TemplateFileName { get; set; }

        [JsonProperty("templateFileData", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent TemplateFileData { get; set; }

        [JsonProperty("documentDataType", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputDocumentDataTypeType DocumentDataType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4mepdf.BodyInputDocumentDataTypeType.Json;

        [JsonProperty("documentDataFile")]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocumentDataFile { get; set; }

        [JsonProperty("documentDataText")]
        public string DocumentDataText { get; set; }

        [JsonProperty("metaDataJson")]
        public string MetadataJson { get; set; }

        [JsonProperty("outputType", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputOutputTypeType OutputType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4mepdf.BodyInputOutputTypeType.Docx;

        [JsonProperty("keepPdfEditable", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? KeepPdfEditable { get; set; } = false;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GenerateDocumentMultipleBodyInputTemplateFileTypeType
    {
        Docx,
        Html,
        Pdf
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputOutputTypeType
    {
        [EnumMember(Value = "PDF")]
        Pdf,
        Docx,
        Html
    }

    public class GenerateDocumentSingleBodyInput
    {
        public GenerateDocumentSingleBodyInput(string templateFileName, global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent templateFileData)
        {
            this.TemplateFileName = templateFileName;
            this.TemplateFileData = templateFileData;
        }

        [JsonProperty("templateFileType", DefaultValueHandling = DefaultValueHandling.Include)]
        public GenerateDocumentSingleBodyInputTemplateFileTypeType TemplateFileType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4mepdf.GenerateDocumentSingleBodyInputTemplateFileTypeType.DocxPdf4meTemplateSyntax;

        [JsonProperty("templateFileName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TemplateFileName { get; set; }

        [JsonProperty("templateFileData", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent TemplateFileData { get; set; }

        [JsonProperty("documentDataType", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputDocumentDataTypeType DocumentDataType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4mepdf.BodyInputDocumentDataTypeType.Json;

        [JsonProperty("documentDataFile")]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocumentDataFile { get; set; }

        [JsonProperty("documentDataText")]
        public string DocumentDataText { get; set; }

        [JsonProperty("metaDataJson")]
        public string MetadataJson { get; set; }

        [JsonProperty("outputType", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputOutputTypeType OutputType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4mepdf.BodyInputOutputTypeType.Docx;

        [JsonProperty("keepPdfEditable", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? KeepPdfEditable { get; set; } = false;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GenerateDocumentSingleBodyInputTemplateFileTypeType
    {
        [EnumMember(Value = "Docx")]
        DocxPdf4meTemplateSyntax,
        [EnumMember(Value = "Html")]
        HtmlHandlebarsSyntax,
        [EnumMember(Value = "Pdf")]
        PdfForm,
        [EnumMember(Value = "MailMerge")]
        DocxMailMerge,
        GoogleDocs
    }

    public class GetPdfMetadataResponse
    {
        public string Title { get; set; }
        public string Subject { get; set; }
        public string PageCount { get; set; }
        public string Author { get; set; }
        public string Size { get; set; }
        public string Creator { get; set; }
        public string Producer { get; set; }
        public string CreationDate { get; set; }
        public string ModDate { get; set; }
        public bool IsEncrypted { get; set; }
        public bool IsLinearized { get; set; }
        public string PdfCompliance { get; set; }
        public bool IsSigned { get; set; }
        public string PdfVersion { get; set; }
    }

    public class HighlightTextBodyInput
    {
        public HighlightTextBodyInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent docContent, AddAttachmentToPdfBodyInputDocumentType document, BodyInputTextHighlightListTypeItem[] textHighlightList)
        {
            this.DocContent = docContent;
            this.Document = document;
            this.TextHighlightList = textHighlightList;
        }

        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddAttachmentToPdfBodyInputDocumentType Document { get; set; }

        [JsonProperty("textHighlightList", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputTextHighlightListTypeItem[] TextHighlightList { get; set; }
    }

    public class BodyInputTextHighlightListTypeItem
    {
        public BodyInputTextHighlightListTypeItem(string text, string highlightColor)
        {
            this.Text = text;
            this.HighlightColor = highlightColor;
        }

        [JsonProperty("text", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Text { get; set; }

        [JsonProperty("highlightColor", DefaultValueHandling = DefaultValueHandling.Include)]
        public string HighlightColor { get; set; }
    }

    public class ImageStampBodyInput
    {
        public ImageStampBodyInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent docContent, string docName, global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent imageFile, string imageName)
        {
            this.DocContent = docContent;
            this.DocName = docName;
            this.ImageFile = imageFile;
            this.ImageName = imageName;
        }

        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("docName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocName { get; set; }

        [JsonProperty("imageFile", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent ImageFile { get; set; }

        [JsonProperty("imageName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ImageName { get; set; }

        [JsonProperty("pages", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Pages { get; set; } = "all";

        [JsonProperty("alignX", DefaultValueHandling = DefaultValueHandling.Include)]
        public ImageStampBodyInputAlignXType AlignX { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4mepdf.ImageStampBodyInputAlignXType.Left;

        [JsonProperty("alignY", DefaultValueHandling = DefaultValueHandling.Include)]
        public ImageStampBodyInputAlignYType AlignY { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4mepdf.ImageStampBodyInputAlignYType.Top;

        [JsonProperty("heightInMM", DefaultValueHandling = DefaultValueHandling.Include)]
        public string HeightInMM { get; set; } = "0";

        [JsonProperty("widthInMM", DefaultValueHandling = DefaultValueHandling.Include)]
        public string WidthInMM { get; set; } = "0";

        [JsonProperty("marginXInMM", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MarginXInMM { get; set; } = "0";

        [JsonProperty("marginYInMM", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MarginYInMM { get; set; } = "0";

        [JsonProperty("opacity", DefaultValueHandling = DefaultValueHandling.Include)]
        public int Opacity { get; set; } = 100;

        [JsonProperty("showOnlyInPrint", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ShowOnlyInPrint { get; set; } = false;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ImageStampBodyInputAlignXType
    {
        [EnumMember(Value = "left")]
        Left,
        [EnumMember(Value = "center")]
        Center,
        [EnumMember(Value = "right")]
        Right
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ImageStampBodyInputAlignYType
    {
        [EnumMember(Value = "top")]
        Top,
        [EnumMember(Value = "middle")]
        Middle,
        [EnumMember(Value = "bottom")]
        Bottom
    }

    public class LinearizePdfBodyInput
    {
        public LinearizePdfBodyInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent docContent, AddAttachmentToPdfBodyInputDocumentType document)
        {
            this.DocContent = docContent;
            this.Document = document;
        }

        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddAttachmentToPdfBodyInputDocumentType Document { get; set; }

        [JsonProperty("optimizeProfile", DefaultValueHandling = DefaultValueHandling.Include)]
        public LinearizePdfBodyInputOptimizeProfileType OptimizeProfile { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4mepdf.LinearizePdfBodyInputOptimizeProfileType.Default;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum LinearizePdfBodyInputOptimizeProfileType
    {
        Default,
        Max
    }

    public class MergeBodyInput
    {
        public MergeBodyInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent[] docContent, AddAttachmentToPdfBodyInputDocumentType document)
        {
            this.DocContent = docContent;
            this.Document = document;
        }

        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent[] DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddAttachmentToPdfBodyInputDocumentType Document { get; set; }
    }

    public class MergeOverlayBodyInput
    {
        public MergeOverlayBodyInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent baseDocContent, string baseDocName, global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent layerDocContent, string layerDocName)
        {
            this.BaseDocContent = baseDocContent;
            this.BaseDocName = baseDocName;
            this.LayerDocContent = layerDocContent;
            this.LayerDocName = layerDocName;
        }

        [JsonProperty("baseDocContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent BaseDocContent { get; set; }

        [JsonProperty("baseDocName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string BaseDocName { get; set; }

        [JsonProperty("layerDocContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent LayerDocContent { get; set; }

        [JsonProperty("layerDocName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string LayerDocName { get; set; }
    }

    public class OptimizeBodyInput
    {
        public OptimizeBodyInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent docContent, AddAttachmentToPdfBodyInputDocumentType document)
        {
            this.DocContent = docContent;
            this.Document = document;
        }

        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddAttachmentToPdfBodyInputDocumentType Document { get; set; }

        [JsonProperty("optimizeProfile", DefaultValueHandling = DefaultValueHandling.Include)]
        public OptimizeBodyInputOptimizeProfileType OptimizeProfile { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4mepdf.OptimizeBodyInputOptimizeProfileType.Max;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OptimizeBodyInputOptimizeProfileType
    {
        Default,
        Max,
        Web,
        WebMax,
        Print,
        PrintMax,
        PrintGray,
        Compress,
        CompressMax
    }

    public class ParseDocumentResponse
    {
        [JsonProperty("traceId")]
        public string TraceId { get; set; }

        [JsonProperty("parseInfo")]
        public JToken ParseInfo { get; set; }
    }

    public class ParseDocumentBodyInput
    {
        [JsonProperty("docContent")]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document")]
        public ClassifyDocumentBodyInputDocumentType Document { get; set; }
        public string TemplateName { get; set; }
    }

    public class PdfOcrBodyInput
    {
        public PdfOcrBodyInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent docContent, AddAttachmentToPdfBodyInputDocumentType document)
        {
            this.DocContent = docContent;
            this.Document = document;
        }

        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddAttachmentToPdfBodyInputDocumentType Document { get; set; }

        [JsonProperty("qualityType", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputQualityTypeType QualityType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4mepdf.BodyInputQualityTypeType.Draft;

        [JsonProperty("ocrWhenNeeded", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputOcrWhenNeededType? OcrWhenNeeded { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4mepdf.BodyInputOcrWhenNeededType.False;

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("isAsync", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IsAsync { get; set; } = false;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputQualityTypeType
    {
        Draft,
        High
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputOcrWhenNeededType
    {
        [EnumMember(Value = "false")]
        False,
        [EnumMember(Value = "true")]
        True
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PrepareForPrintSchemaValInput
    {
        Default,
        A0,
        A1,
        A2,
        A3,
        A4,
        A5,
        A6,
        B5,
        PageLetter,
        PageLegal,
        PageLedger,
        P11x17,
        Custom
    }

    public class ProtectDocumentBodyInput
    {
        public ProtectDocumentBodyInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent docContent, AddAttachmentToPdfBodyInputDocumentType document, string password)
        {
            this.DocContent = docContent;
            this.Document = document;
            this.Password = password;
        }

        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddAttachmentToPdfBodyInputDocumentType Document { get; set; }

        [JsonProperty("password", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Password { get; set; }

        [JsonProperty("pdfPermission", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputPdfPermissionType PdfPermission { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4mepdf.BodyInputPdfPermissionType.All;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputPdfPermissionType
    {
        All,
        None,
        Copy,
        Annotate,
        FillForms,
        SupportDisabilities,
        Assemble,
        DigitalPrint,
        Print,
        Modify
    }

    public class RedactPdfBodyInput
    {
        public RedactPdfBodyInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent docContent, AddAttachmentToPdfBodyInputDocumentType document, BodyInputRedactPdfActionType redactPdfAction)
        {
            this.DocContent = docContent;
            this.Document = document;
            this.RedactPdfAction = redactPdfAction;
        }

        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddAttachmentToPdfBodyInputDocumentType Document { get; set; }

        [JsonProperty("redactPdfAction", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputRedactPdfActionType RedactPdfAction { get; set; }
    }

    public class BodyInputRedactPdfActionType
    {
        public BodyInputRedactPdfActionType(BodyInputRedactPdfActionTypeRedactBoxesTypeItem[] redactBoxes)
        {
            this.RedactBoxes = redactBoxes;
        }

        [JsonProperty("redactBoxes", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputRedactPdfActionTypeRedactBoxesTypeItem[] RedactBoxes { get; set; }
    }

    public class BodyInputRedactPdfActionTypeRedactBoxesTypeItem
    {
        [JsonProperty("coordinates", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputRedactPdfActionTypeRedactBoxesTypeItemCoordinatesType Coordinates { get; set; } = new BodyInputRedactPdfActionTypeRedactBoxesTypeItemCoordinatesType();

        [JsonProperty("color", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputRedactPdfActionTypeRedactBoxesTypeItemColorType Color { get; set; } = new BodyInputRedactPdfActionTypeRedactBoxesTypeItemColorType();

        [JsonProperty("fillColor", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputRedactPdfActionTypeRedactBoxesTypeItemFillColorType FillColor { get; set; } = new BodyInputRedactPdfActionTypeRedactBoxesTypeItemFillColorType();

        [JsonProperty("borderColor", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputRedactPdfActionTypeRedactBoxesTypeItemBorderColorType BorderColor { get; set; } = new BodyInputRedactPdfActionTypeRedactBoxesTypeItemBorderColorType();

        [JsonProperty("overlayText")]
        public string OverlayText { get; set; }

        [JsonProperty("overlayTextAlignment", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputRedactPdfActionTypeRedactBoxesTypeItemOverlayTextAlignmentType? OverlayTextAlignment { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4mepdf.BodyInputRedactPdfActionTypeRedactBoxesTypeItemOverlayTextAlignmentType.None;

        [JsonProperty("page", DefaultValueHandling = DefaultValueHandling.Include)]
        public int Page { get; set; } = 1;

        [JsonProperty("repeatText", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RepeatText { get; set; } = false;
    }

    public class BodyInputRedactPdfActionTypeRedactBoxesTypeItemCoordinatesType
    {
        [JsonProperty("x1", DefaultValueHandling = DefaultValueHandling.Include)]
        public int X1 { get; set; } = 0;

        [JsonProperty("y1", DefaultValueHandling = DefaultValueHandling.Include)]
        public int Y1 { get; set; } = 0;

        [JsonProperty("x2", DefaultValueHandling = DefaultValueHandling.Include)]
        public int X2 { get; set; } = 0;

        [JsonProperty("y2", DefaultValueHandling = DefaultValueHandling.Include)]
        public int Y2 { get; set; } = 0;
    }

    public class BodyInputRedactPdfActionTypeRedactBoxesTypeItemColorType
    {
        [JsonProperty("red", DefaultValueHandling = DefaultValueHandling.Include)]
        public double Red { get; set; } = 0;

        [JsonProperty("green", DefaultValueHandling = DefaultValueHandling.Include)]
        public double Green { get; set; } = 0;

        [JsonProperty("blue", DefaultValueHandling = DefaultValueHandling.Include)]
        public double Blue { get; set; } = 0;
    }

    public class BodyInputRedactPdfActionTypeRedactBoxesTypeItemFillColorType
    {
        [JsonProperty("red", DefaultValueHandling = DefaultValueHandling.Include)]
        public double Red { get; set; } = 0;

        [JsonProperty("green", DefaultValueHandling = DefaultValueHandling.Include)]
        public double Green { get; set; } = 0;

        [JsonProperty("blue", DefaultValueHandling = DefaultValueHandling.Include)]
        public double Blue { get; set; } = 0;
    }

    public class BodyInputRedactPdfActionTypeRedactBoxesTypeItemBorderColorType
    {
        [JsonProperty("red", DefaultValueHandling = DefaultValueHandling.Include)]
        public double Red { get; set; } = 0;

        [JsonProperty("green", DefaultValueHandling = DefaultValueHandling.Include)]
        public double Green { get; set; } = 0;

        [JsonProperty("blue", DefaultValueHandling = DefaultValueHandling.Include)]
        public double Blue { get; set; } = 0;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputRedactPdfActionTypeRedactBoxesTypeItemOverlayTextAlignmentType
    {
        None,
        Left,
        Center,
        Right,
        Justify,
        FullJustify
    }

    public class ReplaceTextWithImageBodyInput
    {
        public ReplaceTextWithImageBodyInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent docContent, AddAttachmentToPdfBodyInputDocumentType document, string replaceText)
        {
            this.DocContent = docContent;
            this.Document = document;
            this.ReplaceText = replaceText;
        }

        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddAttachmentToPdfBodyInputDocumentType Document { get; set; }

        [JsonProperty("replaceText", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ReplaceText { get; set; }

        [JsonProperty("imageContent")]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent ImageContent { get; set; }

        [JsonProperty("imageHeight", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ImageHeight { get; set; } = "0";

        [JsonProperty("imageWidth", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ImageWidth { get; set; } = "0";

        [JsonProperty("pageSequence", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PageSequence { get; set; } = "all";
    }

    public class RotateDocumentBodyInput
    {
        public RotateDocumentBodyInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent docContent, AddAttachmentToPdfBodyInputDocumentType document)
        {
            this.DocContent = docContent;
            this.Document = document;
        }

        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddAttachmentToPdfBodyInputDocumentType Document { get; set; }

        [JsonProperty("rotationType", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputRotationTypeType RotationType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4mepdf.BodyInputRotationTypeType.NoRotation;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputRotationTypeType
    {
        NoRotation,
        Clockwise,
        CounterClockwise,
        UpsideDown
    }

    public class RotatePageBodyInput
    {
        public RotatePageBodyInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent docContent, string docName)
        {
            this.DocContent = docContent;
            this.DocName = docName;
        }

        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("docName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocName { get; set; }

        [JsonProperty("page", DefaultValueHandling = DefaultValueHandling.Include)]
        public int Page { get; set; } = 1;

        [JsonProperty("rotationType", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputRotationTypeType RotationType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4mepdf.BodyInputRotationTypeType.NoRotation;
    }

    public class SetPdfMetadataBodyInput
    {
        public SetPdfMetadataBodyInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent docContent, AddAttachmentToPdfBodyInputDocumentType document)
        {
            this.DocContent = docContent;
            this.Document = document;
        }

        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddAttachmentToPdfBodyInputDocumentType Document { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("keywords")]
        public string Keywords { get; set; }

        [JsonProperty("creator")]
        public string Creator { get; set; }

        [JsonProperty("producer")]
        public string Producer { get; set; }

        [JsonProperty("permissions")]
        public BodyInputPermissionsTypeItem[] Permissions { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputPermissionsTypeItem
    {
        All,
        None,
        Copy,
        Annotate,
        FillForms,
        SupportDisabilities,
        Assemble,
        DigitalPrint,
        Print,
        Modify
    }

    public class SignPdfBodyInput
    {
        public SignPdfBodyInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent docContent, string docName, global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent imageFile, string imageName, string marginXInMM, string marginYInMM)
        {
            this.DocContent = docContent;
            this.DocName = docName;
            this.ImageFile = imageFile;
            this.ImageName = imageName;
            this.MarginXInMM = marginXInMM;
            this.MarginYInMM = marginYInMM;
        }

        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("docName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocName { get; set; }

        [JsonProperty("imageFile", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent ImageFile { get; set; }

        [JsonProperty("imageName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ImageName { get; set; }

        [JsonProperty("alignX", DefaultValueHandling = DefaultValueHandling.Include)]
        public ImageStampBodyInputAlignXType AlignX { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4mepdf.ImageStampBodyInputAlignXType.Left;

        [JsonProperty("alignY", DefaultValueHandling = DefaultValueHandling.Include)]
        public ImageStampBodyInputAlignYType AlignY { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4mepdf.ImageStampBodyInputAlignYType.Top;

        [JsonProperty("pages", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Pages { get; set; } = "1";

        [JsonProperty("heightInMM")]
        public string HeightInMM { get; set; }

        [JsonProperty("widthInMM")]
        public string WidthInMM { get; set; }

        [JsonProperty("marginXInMM", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MarginXInMM { get; set; }

        [JsonProperty("marginYInMM", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MarginYInMM { get; set; }

        [JsonProperty("opacity", DefaultValueHandling = DefaultValueHandling.Include)]
        public int Opacity { get; set; } = 100;
    }

    public class SplitByTextResponse
    {
        [JsonProperty("splitedDocuments")]
        public SplitByTextResponseSplitedDocumentsTypeItem[] SplitedDocuments { get; set; }
    }

    public class SplitByTextResponseSplitedDocumentsTypeItem
    {
        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("docText")]
        public string DocText { get; set; }

        [JsonProperty("streamFile")]
        public string StreamFile { get; set; }
    }

    public class SplitByTextBodyInput
    {
        public SplitByTextBodyInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent docContent, AddAttachmentToPdfBodyInputDocumentType document, string text)
        {
            this.DocContent = docContent;
            this.Document = document;
            this.Text = text;
        }

        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddAttachmentToPdfBodyInputDocumentType Document { get; set; }

        [JsonProperty("text", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Text { get; set; }

        [JsonProperty("splitTextPage", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputSplitTextPageType SplitTextPage { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4mepdf.BodyInputSplitTextPageType.Before;

        [JsonProperty("fileNaming", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputFileNamingType? FileNaming { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4mepdf.BodyInputFileNamingType.NameAsPerOrder;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputSplitTextPageType
    {
        [EnumMember(Value = "before")]
        Before,
        [EnumMember(Value = "after")]
        After
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputFileNamingType
    {
        WithPageNumber,
        NameAsPerOrder
    }

    public class SplitDocumentResponse
    {
        [JsonProperty("splitedDocuments")]
        public SplitDocumentResponseSplitedDocumentsTypeItem[] SplitedDocuments { get; set; }
    }

    public class SplitDocumentResponseSplitedDocumentsTypeItem
    {
        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("streamFile")]
        public string StreamFile { get; set; }
    }

    public class SplitDocumentBodyInput
    {
        public SplitDocumentBodyInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent docContent, AddAttachmentToPdfBodyInputDocumentType document)
        {
            this.DocContent = docContent;
            this.Document = document;
        }

        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddAttachmentToPdfBodyInputDocumentType Document { get; set; }

        [JsonProperty("splitAction", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputSplitActionType SplitAction { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4mepdf.BodyInputSplitActionType.SplitAfterPage;

        [JsonProperty("splitActionNumber", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? SplitActionNumber { get; set; } = 1;

        [JsonProperty("splitSequence", DefaultValueHandling = DefaultValueHandling.Include)]
        public int[] SplitSequence { get; set; } = new int[]
        {
            1,
            4,
            7
        };

        [JsonProperty("splitRanges", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SplitRanges { get; set; } = "1-3,5-";

        [JsonProperty("fileNaming", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputFileNamingType? FileNaming { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4mepdf.BodyInputFileNamingType.NameAsPerOrder;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputSplitActionType
    {
        SplitAfterPage,
        RecurringSplitAfterPage,
        SplitSequence,
        SplitRanges
    }

    public class StampBodyInput
    {
        public StampBodyInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent docContent, AddAttachmentToPdfBodyInputDocumentType document, string text)
        {
            this.DocContent = docContent;
            this.Document = document;
            this.Text = text;
        }

        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddAttachmentToPdfBodyInputDocumentType Document { get; set; }

        [JsonProperty("text", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Text { get; set; }

        [JsonProperty("fontSize", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? FontSize { get; set; } = 12;

        [JsonProperty("fontColor", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FontColor { get; set; } = "#000000";

        [JsonProperty("isBold", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IsBold { get; set; } = false;

        [JsonProperty("isItalics", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IsItalics { get; set; } = false;

        [JsonProperty("underline", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Underline { get; set; } = false;

        [JsonProperty("pages", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Pages { get; set; } = "all";

        [JsonProperty("alignX", DefaultValueHandling = DefaultValueHandling.Include)]
        public ImageStampBodyInputAlignXType AlignX { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4mepdf.ImageStampBodyInputAlignXType.Left;

        [JsonProperty("alignY", DefaultValueHandling = DefaultValueHandling.Include)]
        public ImageStampBodyInputAlignYType AlignY { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4mepdf.ImageStampBodyInputAlignYType.Top;

        [JsonProperty("marginXInMM", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MarginXInMM { get; set; } = "0";

        [JsonProperty("marginYInMM", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MarginYInMM { get; set; } = "0";

        [JsonProperty("opacity", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Opacity { get; set; } = "100";

        [JsonProperty("rotate", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Rotate { get; set; } = 0;

        [JsonProperty("showOnlyInPrint", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ShowOnlyInPrint { get; set; } = false;

        [JsonProperty("transverse", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Transverse { get; set; } = false;

        [JsonProperty("fitTextOverPage", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? FitTextOverPage { get; set; } = false;
    }

    public class StartPdf4meWfResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }
    }

    public class StartPdf4meWfBodyInput
    {
        public StartPdf4meWfBodyInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent docContent, string docName, string wfName)
        {
            this.DocContent = docContent;
            this.DocName = docName;
            this.WfName = wfName;
        }

        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("docName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocName { get; set; }

        [JsonProperty("wfName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string WfName { get; set; }
    }

    public class UnlockBodyInput
    {
        public UnlockBodyInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent docContent, string docName, string password)
        {
            this.DocContent = docContent;
            this.DocName = docName;
            this.Password = password;
        }

        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("docName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocName { get; set; }

        [JsonProperty("password", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Password { get; set; }
    }

    public class UploadBlobAllResponse
    {
        public string BlobId { get; set; }
    }

    public class UploadBlobAllBodyInput
    {
        public UploadBlobAllBodyInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent docContent)
        {
            this.DocContent = docContent;
        }

        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("docName")]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocName { get; set; }
    }

    public class ValidatePdfaResponse
    {
        public string Conformance { get; set; }
        public bool IsConforming { get; set; }
        public bool IsPdfA { get; set; }
    }

    public class GetDocumentFromPdf4meBodyInput
    {
        public GetDocumentFromPdf4meBodyInput(string name)
        {
            this.Name = name;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("CallBackUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackUrl { get; set; } = "#{listCallbackUrl()}";
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4mepdf;

    public partial class WorkflowManagedActions
    {
        public Pdf4mepdfActions Pdf4mepdf(string connectionId) => new Pdf4mepdfActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Pdf4mepdfTriggers Pdf4mepdf(string connectionId) => new Pdf4mepdfTriggers(connectionId);
    }
}