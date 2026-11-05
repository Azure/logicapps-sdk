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
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GenerateDocumentUsingTemplate(Expression<Func<GenerateDocumentUsingTemplateInput>> body)
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
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> AddPageNumber(Expression<Func<AddPageNumberInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/AddPageNumber";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> _1ResizeDocument(Expression<Func<_1ResizeDocumentV1Input>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ResizePdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> AddAttachmentToPdf(Expression<Func<AddAttachmentToPdfV1Input>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/AddAttachmentToPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> AddFormField(Expression<Func<AddFormFieldV1Input>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/AddFormField";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> AddHtmlHeaderFooter(Expression<Func<AddHtmlHeaderFooterV1Input>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/AddHtmlHeaderFooter";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> AddMargin(Expression<Func<AddMarginV1Input>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/AddMargin";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<ClassifyDocumentV1Response, ApiConnectionActionConfiguration> ClassifyDocument(Expression<Func<ClassifyDocumentV1Input>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ClassifyDocumentV1Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ClassifyDocument";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ClassifyDocumentV1Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> CreatePdfA(Expression<Func<CreatePdfAV1Input>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/PdfA";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> CreateZugferdInvoice(Expression<Func<schemaValInput>> schemaVal = null, Expression<Func<object>> operation = null)
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
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> CropPdf(Expression<Func<CropPdfV1Input>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/CropPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CustomAPI(Expression<Func<string>> featurePath, Expression<Func<string>> contentType, Expression<Func<string>> body = null)
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
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> DeleteBlankPages(Expression<Func<DeleteBlankPagesV1Input>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/DeleteBlankPages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> DeletePages(Expression<Func<DeletePagesV1Input>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/DeletePages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> DigitalSignPdf(Expression<Func<DigitalSignPdfV1Input>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/DigitalSignPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<ExtractAttachmentFromPdfV1Response, ApiConnectionActionConfiguration> ExtractAttachmentFromPdf(Expression<Func<ExtractAttachmentFromPdfV1Input>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ExtractAttachmentFromPdfV1Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ExtractAttachmentFromPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ExtractAttachmentFromPdfV1Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ExtractPages(Expression<Func<ExtractPagesV1Input>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/Extract";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<ExtractPdfFormDataV1Response, ApiConnectionActionConfiguration> ExtractPdfFormData(Expression<Func<ExtractPdfFormDataV1Input>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ExtractPdfFormDataV1Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ExtractPdfFormData";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ExtractPdfFormDataV1Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<ExtractResourcesV1Response, ApiConnectionActionConfiguration> ExtractResources(Expression<Func<ExtractResourcesV1Input>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ExtractResourcesV1Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ExtractResources";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ExtractResourcesV1Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<ExtractTableFromPdfV1Response, ApiConnectionActionConfiguration> ExtractTableFromPdf(Expression<Func<ExtractTableFromPdfV1Input>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ExtractTableFromPdfV1Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ExtractTableFromPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ExtractTableFromPdfV1Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<ExtractTextByExpressionV1Response, ApiConnectionActionConfiguration> ExtractTextByExpression(Expression<Func<ExtractTextByExpressionV1Input>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ExtractTextByExpressionV1Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ExtractTextByExpression";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ExtractTextByExpressionV1Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> FindAndReplace(Expression<Func<FindAndReplaceV2Input>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/FindAndReplaceV2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> FlattenPdf(Expression<Func<FlattenPdfV1Input>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/FlattenPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GenerateDocumentFromPdf(Expression<Func<GenerateDocumentFromPdfV2Input>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/GenerateDocumentFromPdfV2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<GenerateDocumentMultipleV1Response, ApiConnectionActionConfiguration> GenerateDocumentMultiple(Expression<Func<GenerateDocumentMultipleV1Input>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<GenerateDocumentMultipleV1Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/GenerateDocumentMultiple";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GenerateDocumentMultipleV1Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GenerateDocumentSingle(Expression<Func<GenerateDocumentSingleV1Input>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/GenerateDocumentSingle";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<GetPdfMetadataV1Response, ApiConnectionActionConfiguration> GetPdfMetadata(Expression<Func<GetPdfMetadataV1Input>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<GetPdfMetadataV1Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/GetPdfMetadata";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetPdfMetadataV1Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> HighlightText(Expression<Func<HighlightTextV1Input>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/HighlightText";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ImageStamp(Expression<Func<ImageStampV1Input>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ImageStamp";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> LinearizePdf(Expression<Func<LinearizePdfV1Input>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/LinearizePdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> Merge(Expression<Func<MergeV1Input>> body)
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
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> MergeOverlay(Expression<Func<MergeOverlayV1Input>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/MergeOverlay";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> Optimize(Expression<Func<OptimizeV1Input>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/Optimize";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<ParseDocumentV1Response, ApiConnectionActionConfiguration> ParseDocument(Expression<Func<ParseDocumentV1Input>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ParseDocumentV1Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ParseDocument";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ParseDocumentV1Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> PdfOcr(Expression<Func<PdfOcrV1Input>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ConvertOcrPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> PrepareForPrint(Expression<Func<schemaValInput2>> schemaVal = null, Expression<Func<object>> operation = null)
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
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ProtectDocument(Expression<Func<ProtectDocumentV1Input>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/Protect";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> RedactPdf(Expression<Func<RedactPdfV1Input>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/RedactPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> RepairPdf(Expression<Func<RepairPdfV1Input>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/RepairPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ReplaceTextWithImage(Expression<Func<ReplaceTextWithImageV1Input>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ReplaceTextWithImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> RotateDocument(Expression<Func<RotateDocumentV1Input>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/Rotate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> RotatePage(Expression<Func<RotatePageV1Input>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/RotatePage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> SetPDFMetadata(Expression<Func<SetPDFMetadataV1Input>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/SetPDFMetadata";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> SignPdf(Expression<Func<SignPdfV1Input>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/SignPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<SplitByTextV1Response, ApiConnectionActionConfiguration> SplitByText(Expression<Func<SplitByTextV1Input>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SplitByTextV1Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/SplitByText";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SplitByTextV1Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<SplitDocumentV1Response, ApiConnectionActionConfiguration> SplitDocument(Expression<Func<SplitDocumentV1Input>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SplitDocumentV1Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/SplitPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SplitDocumentV1Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> Stamp(Expression<Func<StampV1Input>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/Stamp";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<StartPDF4meWfV1Response, ApiConnectionActionConfiguration> StartPDF4meWf(Expression<Func<StartPDF4meWfV1Input>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<StartPDF4meWfV1Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ExecuteWfTrigger";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<StartPDF4meWfV1Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> Unlock(Expression<Func<UnlockV1Input>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/Unlock";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<UploadBlobAllV1Response, ApiConnectionActionConfiguration> UploadBlobAll(Expression<Func<UploadBlobAllV1Input>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<UploadBlobAllV1Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/UploadBlobAll";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UploadBlobAllV1Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mepdf")]
        public IBodyWorkflowAction<ValidatePDFAV1Response, ApiConnectionActionConfiguration> ValidatePDFA(Expression<Func<ValidatePDFAV1Input>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ValidatePDFAV1Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ValidatePDFA";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ValidatePDFAV1Response>(callPayload);
            });
        }
    }

    public class Pdf4mepdfTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<string, ApiConnectionTriggerConfiguration> GetDocumentFromPDF4me(Expression<Func<GetDocumentFromPDF4meInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<string, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/WebhookSubscribe";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<string>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class GenerateDocumentUsingTemplateInput
    {
        [JsonProperty("templateFileName")]
        public string TemplateName { get; set; }

        [JsonProperty("documentDataType", DefaultValueHandling = DefaultValueHandling.Include)]
        public GenerateDocumentUsingTemplateInputDocumentDataTypeType? DocumentDataType { get; set; } = GenerateDocumentUsingTemplateInputDocumentDataTypeType.Json;

        [JsonProperty("documentDataText")]
        public string DocumentDataText { get; set; }

        [JsonProperty("documentDataFile")]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocumentDataFile { get; set; }

        [JsonProperty("metaDataJson")]
        public string MetaDataJson { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GenerateDocumentUsingTemplateInputDocumentDataTypeType
    {
        Json,
        XML
    }

    public class AddPageNumberInput
    {
        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("docName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocName { get; set; }

        [JsonProperty("pageNumberFormat", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PageNumberFormat { get; set; } = "# of {totalPages}";

        [JsonProperty("alignX", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddPageNumberInputAlignXType AlignX { get; set; } = AddPageNumberInputAlignXType.Left;

        [JsonProperty("alignY", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddPageNumberInputAlignYType AlignY { get; set; } = AddPageNumberInputAlignYType.Top;

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
    public enum AddPageNumberInputAlignXType
    {
        Left,
        Center,
        Right
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddPageNumberInputAlignYType
    {
        Top,
        Middle,
        Bottom
    }

    public class _1ResizeDocumentV1Input
    {
        [JsonProperty("docContent")]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document")]
        public _1ResizeDocumentV1InputDocumentType Document { get; set; }

        [JsonProperty("pageSequence", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PageSequence { get; set; } = "all";

        [JsonProperty("isPageSizeRequested", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool IsPageSizeRequested { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public _1ResizeDocumentV1InputPageSizeType PageSize { get; set; } = new _1ResizeDocumentV1InputPageSizeType();

        [JsonProperty("paddingTop", DefaultValueHandling = DefaultValueHandling.Include)]
        public double? PaddingTop { get; set; } = 0;

        [JsonProperty("paddingBottom", DefaultValueHandling = DefaultValueHandling.Include)]
        public double? PaddingBottom { get; set; } = 0;

        [JsonProperty("paddingLeft", DefaultValueHandling = DefaultValueHandling.Include)]
        public double? PaddingLeft { get; set; } = 0;

        [JsonProperty("paddingRight", DefaultValueHandling = DefaultValueHandling.Include)]
        public double? PaddingRight { get; set; } = 0;
    }

    public class _1ResizeDocumentV1InputDocumentType
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
    }

    public class _1ResizeDocumentV1InputPageSizeType
    {
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public _1ResizeDocumentV1InputPageSizeTypeTypeType Type { get; set; } = _1ResizeDocumentV1InputPageSizeTypeTypeType.A4;

        [JsonProperty("customWidth")]
        public string CustomWidth { get; set; }

        [JsonProperty("customHeight")]
        public string CustomHeight { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum _1ResizeDocumentV1InputPageSizeTypeTypeType
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

    public class AddAttachmentToPdfV1Input
    {
        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddAttachmentToPdfV1InputDocumentType Document { get; set; }

        [JsonProperty("attachments", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddAttachmentToPdfV1InputAttachmentsTypeItem[] Attachments { get; set; }
    }

    public class AddAttachmentToPdfV1InputDocumentType
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
    }

    public class AddAttachmentToPdfV1InputAttachmentsTypeItem
    {
        [JsonProperty("docContent")]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document")]
        public AddAttachmentToPdfV1InputAttachmentsTypeItemDocumentType Document { get; set; }
    }

    public class AddAttachmentToPdfV1InputAttachmentsTypeItemDocumentType
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
    }

    public class AddFormFieldV1Input
    {
        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddFormFieldV1InputDocumentType Document { get; set; }

        [JsonProperty("fieldName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FieldName { get; set; }

        [JsonProperty("formFieldType", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddFormFieldV1InputFormFieldTypeType FormFieldType { get; set; } = AddFormFieldV1InputFormFieldTypeType.TextBox;

        [JsonProperty("initialValue")]
        public string InitialValue { get; set; }

        [JsonProperty("positionX", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? PositionX { get; set; } = 0;

        [JsonProperty("positionY", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? PositionY { get; set; } = 0;

        [JsonProperty("pages", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Pages { get; set; } = "1";
    }

    public class AddFormFieldV1InputDocumentType
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddFormFieldV1InputFormFieldTypeType
    {
        TextBox,
        CheckBox
    }

    public class AddHtmlHeaderFooterV1Input
    {
        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddHtmlHeaderFooterV1InputDocumentType Document { get; set; }

        [JsonProperty("htmlContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public string HtmlContent { get; set; }

        [JsonProperty("location", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddHtmlHeaderFooterV1InputLocationType? Location { get; set; } = AddHtmlHeaderFooterV1InputLocationType.Header;

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

    public class AddHtmlHeaderFooterV1InputDocumentType
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddHtmlHeaderFooterV1InputLocationType
    {
        Header,
        Footer,
        Both
    }

    public class AddMarginV1Input
    {
        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddMarginV1InputDocumentType Document { get; set; }

        [JsonProperty("marginLeft", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MarginLeft { get; set; }

        [JsonProperty("marginRight", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MarginRight { get; set; }

        [JsonProperty("marginTop", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MarginTop { get; set; }

        [JsonProperty("marginBottom", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MarginBottom { get; set; }
    }

    public class AddMarginV1InputDocumentType
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
    }

    public class ClassifyDocumentV1Response
    {
        [JsonProperty("className")]
        public string ClassName { get; set; }
    }

    public class ClassifyDocumentV1Input
    {
        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document")]
        public ClassifyDocumentV1InputDocumentType Document { get; set; }
    }

    public class ClassifyDocumentV1InputDocumentType
    {
        public string Name { get; set; }
    }

    public class CreatePdfAV1Input
    {
        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreatePdfAV1InputDocumentType Document { get; set; }

        [JsonProperty("compliance", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreatePdfAV1InputComplianceType Compliance { get; set; } = CreatePdfAV1InputComplianceType.PdfA1b;

        [JsonProperty("allowUpgrade", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AllowUpgrade { get; set; } = true;

        [JsonProperty("allowDowngrade", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AllowDowngrade { get; set; } = true;
    }

    public class CreatePdfAV1InputDocumentType
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreatePdfAV1InputComplianceType
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
    public enum schemaValInput
    {
        [EnumMember(Value = "1.0-XML")]
        _10XML,
        [EnumMember(Value = "1.0-JSON")]
        _10JSON,
        [EnumMember(Value = "1.0-CSV")]
        _10CSV,
        [EnumMember(Value = "2.0-XML")]
        _20XML,
        [EnumMember(Value = "2.0-JSON")]
        _20JSON,
        [EnumMember(Value = "2.0-CSV")]
        _20CSV
    }

    public class CropPdfV1Input
    {
        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public CropPdfV1InputDocumentType Document { get; set; }

        [JsonProperty("cropType", DefaultValueHandling = DefaultValueHandling.Include)]
        public CropPdfV1InputCropTypeType CropType { get; set; }

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

    public class CropPdfV1InputDocumentType
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CropPdfV1InputCropTypeType
    {
        Border,
        Rectangle
    }

    public class DeleteBlankPagesV1Input
    {
        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public DeleteBlankPagesV1InputDocumentType Document { get; set; }

        [JsonProperty("deletePageOption", DefaultValueHandling = DefaultValueHandling.Include)]
        public DeleteBlankPagesV1InputDeletePageOptionType DeletePageOption { get; set; } = DeleteBlankPagesV1InputDeletePageOptionType.NoTextNoImages;
    }

    public class DeleteBlankPagesV1InputDocumentType
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DeleteBlankPagesV1InputDeletePageOptionType
    {
        NoTextNoImages,
        NoText,
        NoImages
    }

    public class DeletePagesV1Input
    {
        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public DeletePagesV1InputDocumentType Document { get; set; }

        [JsonProperty("pageNumbers", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PageNumbers { get; set; }
    }

    public class DeletePagesV1InputDocumentType
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
    }

    public class DigitalSignPdfV1Input
    {
        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public DigitalSignPdfV1InputDocumentType Document { get; set; }

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

    public class DigitalSignPdfV1InputDocumentType
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
    }

    public class ExtractAttachmentFromPdfV1Response
    {
        [JsonProperty("outputDocuments")]
        public ExtractAttachmentFromPdfV1ResponseOutputDocumentsTypeItem[] OutputDocuments { get; set; }
    }

    public class ExtractAttachmentFromPdfV1ResponseOutputDocumentsTypeItem
    {
        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("streamFile")]
        public string StreamFile { get; set; }
    }

    public class ExtractAttachmentFromPdfV1Input
    {
        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public ExtractAttachmentFromPdfV1InputDocumentType Document { get; set; }
    }

    public class ExtractAttachmentFromPdfV1InputDocumentType
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
    }

    public class ExtractPagesV1Input
    {
        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public ExtractPagesV1InputDocumentType Document { get; set; }

        [JsonProperty("pageNumbers", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PageNumbers { get; set; }
    }

    public class ExtractPagesV1InputDocumentType
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
    }

    public class ExtractPdfFormDataV1Response
    {
        [JsonProperty("traceId")]
        public string TraceId { get; set; }

        [JsonProperty("formData")]
        public JToken FormData { get; set; }
    }

    public class ExtractPdfFormDataV1Input
    {
        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public ExtractPdfFormDataV1InputDocumentType Document { get; set; }
    }

    public class ExtractPdfFormDataV1InputDocumentType
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
    }

    public class ExtractResourcesV1Response
    {
        [JsonProperty("texts")]
        public string[] Texts { get; set; }

        [JsonProperty("images")]
        public ExtractResourcesV1ResponseImagesTypeItem[] Images { get; set; }
    }

    public class ExtractResourcesV1ResponseImagesTypeItem
    {
        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("streamFile")]
        public string StreamFile { get; set; }
    }

    public class ExtractResourcesV1Input
    {
        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public ExtractResourcesV1InputDocumentType Document { get; set; }

        [JsonProperty("extractText", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ExtractText { get; set; } = true;

        [JsonProperty("extractImages", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ExtractImages { get; set; } = true;
    }

    public class ExtractResourcesV1InputDocumentType
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
    }

    public class ExtractTableFromPdfV1Response
    {
        [JsonProperty("tableList")]
        public ExtractTableFromPdfV1ResponseTableListTypeItem[] TableList { get; set; }
    }

    public class ExtractTableFromPdfV1ResponseTableListTypeItem
    {
        [JsonProperty("pageNumber")]
        public int PageNumber { get; set; }

        [JsonProperty("table")]
        public string[][] Table { get; set; }
    }

    public class ExtractTableFromPdfV1Input
    {
        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public ExtractTableFromPdfV1InputDocumentType Document { get; set; }
    }

    public class ExtractTableFromPdfV1InputDocumentType
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
    }

    public class ExtractTextByExpressionV1Response
    {
        [JsonProperty("textList")]
        public string[] TextList { get; set; }
    }

    public class ExtractTextByExpressionV1Input
    {
        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public ExtractTextByExpressionV1InputDocumentType Document { get; set; }

        [JsonProperty("expression", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Expression { get; set; }

        [JsonProperty("pageSequence", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PageSequence { get; set; } = "all";
    }

    public class ExtractTextByExpressionV1InputDocumentType
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
    }

    public class FindAndReplaceV2Input
    {
        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public FindAndReplaceV2InputDocumentType Document { get; set; }

        [JsonProperty("findReplaceList")]
        public FindAndReplaceV2InputFindReplaceListTypeItem[] FindReplaceList { get; set; }
    }

    public class FindAndReplaceV2InputDocumentType
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
    }

    public class FindAndReplaceV2InputFindReplaceListTypeItem
    {
        [JsonProperty("oldText", DefaultValueHandling = DefaultValueHandling.Include)]
        public string OldText { get; set; }

        [JsonProperty("newText", DefaultValueHandling = DefaultValueHandling.Include)]
        public string NewText { get; set; }

        [JsonProperty("pageSequence", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PageSequence { get; set; } = "all";
    }

    public class FlattenPdfV1Input
    {
        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public FlattenPdfV1InputDocumentType Document { get; set; }
    }

    public class FlattenPdfV1InputDocumentType
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
    }

    public class GenerateDocumentFromPdfV2Input
    {
        [JsonProperty("templateDocContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent TemplateDocContent { get; set; }

        [JsonProperty("templateDocName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TemplateDocName { get; set; }

        [JsonProperty("dataArray", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DataArray { get; set; }

        [JsonProperty("keepPdfEditable", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? KeepPdfEditable { get; set; } = false;
    }

    public class GenerateDocumentMultipleV1Response
    {
        [JsonProperty("outputDocuments")]
        public GenerateDocumentMultipleV1ResponseOutputDocumentsTypeItem[] OutputDocuments { get; set; }
    }

    public class GenerateDocumentMultipleV1ResponseOutputDocumentsTypeItem
    {
        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("streamFile")]
        public string StreamFile { get; set; }
    }

    public class GenerateDocumentMultipleV1Input
    {
        [JsonProperty("templateFileType", DefaultValueHandling = DefaultValueHandling.Include)]
        public GenerateDocumentMultipleV1InputTemplateFileTypeType TemplateFileType { get; set; } = GenerateDocumentMultipleV1InputTemplateFileTypeType.Docx;

        [JsonProperty("templateFileName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TemplateFileName { get; set; }

        [JsonProperty("templateFileData", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent TemplateFileData { get; set; }

        [JsonProperty("documentDataType", DefaultValueHandling = DefaultValueHandling.Include)]
        public GenerateDocumentMultipleV1InputDocumentDataTypeType DocumentDataType { get; set; } = GenerateDocumentMultipleV1InputDocumentDataTypeType.Json;

        [JsonProperty("documentDataFile")]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocumentDataFile { get; set; }

        [JsonProperty("documentDataText")]
        public string DocumentDataText { get; set; }

        [JsonProperty("metaDataJson")]
        public string MetaDataJson { get; set; }

        [JsonProperty("outputType", DefaultValueHandling = DefaultValueHandling.Include)]
        public GenerateDocumentMultipleV1InputOutputTypeType OutputType { get; set; } = GenerateDocumentMultipleV1InputOutputTypeType.Docx;

        [JsonProperty("keepPdfEditable", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? KeepPdfEditable { get; set; } = false;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GenerateDocumentMultipleV1InputTemplateFileTypeType
    {
        Docx,
        Html,
        Pdf
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GenerateDocumentMultipleV1InputDocumentDataTypeType
    {
        Json,
        XML
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GenerateDocumentMultipleV1InputOutputTypeType
    {
        PDF,
        Docx,
        Html
    }

    public class GenerateDocumentSingleV1Input
    {
        [JsonProperty("templateFileType", DefaultValueHandling = DefaultValueHandling.Include)]
        public GenerateDocumentSingleV1InputTemplateFileTypeType TemplateFileType { get; set; } = GenerateDocumentSingleV1InputTemplateFileTypeType.DocxPDF4meTemplateSyntax;

        [JsonProperty("templateFileName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TemplateFileName { get; set; }

        [JsonProperty("templateFileData", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent TemplateFileData { get; set; }

        [JsonProperty("documentDataType", DefaultValueHandling = DefaultValueHandling.Include)]
        public GenerateDocumentSingleV1InputDocumentDataTypeType DocumentDataType { get; set; } = GenerateDocumentSingleV1InputDocumentDataTypeType.Json;

        [JsonProperty("documentDataFile")]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocumentDataFile { get; set; }

        [JsonProperty("documentDataText")]
        public string DocumentDataText { get; set; }

        [JsonProperty("metaDataJson")]
        public string MetaDataJson { get; set; }

        [JsonProperty("outputType", DefaultValueHandling = DefaultValueHandling.Include)]
        public GenerateDocumentSingleV1InputOutputTypeType OutputType { get; set; } = GenerateDocumentSingleV1InputOutputTypeType.Docx;

        [JsonProperty("keepPdfEditable", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? KeepPdfEditable { get; set; } = false;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GenerateDocumentSingleV1InputTemplateFileTypeType
    {
        [EnumMember(Value = "Docx")]
        DocxPDF4meTemplateSyntax,
        [EnumMember(Value = "Html")]
        HtmlHandlebarsSyntax,
        [EnumMember(Value = "Pdf")]
        PdfForm,
        [EnumMember(Value = "MailMerge")]
        DocxMailMerge,
        GoogleDocs
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GenerateDocumentSingleV1InputDocumentDataTypeType
    {
        Json,
        XML
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GenerateDocumentSingleV1InputOutputTypeType
    {
        PDF,
        Docx,
        Html
    }

    public class GetPdfMetadataV1Response
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

    public class GetPdfMetadataV1Input
    {
        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public GetPdfMetadataV1InputDocumentType Document { get; set; }
    }

    public class GetPdfMetadataV1InputDocumentType
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
    }

    public class HighlightTextV1Input
    {
        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public HighlightTextV1InputDocumentType Document { get; set; }

        [JsonProperty("textHighlightList", DefaultValueHandling = DefaultValueHandling.Include)]
        public HighlightTextV1InputTextHighlightListTypeItem[] TextHighlightList { get; set; }
    }

    public class HighlightTextV1InputDocumentType
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
    }

    public class HighlightTextV1InputTextHighlightListTypeItem
    {
        [JsonProperty("text", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Text { get; set; }

        [JsonProperty("highlightColor", DefaultValueHandling = DefaultValueHandling.Include)]
        public string HighlightColor { get; set; }
    }

    public class ImageStampV1Input
    {
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
        public ImageStampV1InputAlignXType AlignX { get; set; } = ImageStampV1InputAlignXType.Left;

        [JsonProperty("alignY", DefaultValueHandling = DefaultValueHandling.Include)]
        public ImageStampV1InputAlignYType AlignY { get; set; } = ImageStampV1InputAlignYType.Top;

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
    public enum ImageStampV1InputAlignXType
    {
        [EnumMember(Value = "left")]
        Left,
        [EnumMember(Value = "center")]
        Center,
        [EnumMember(Value = "right")]
        Right
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ImageStampV1InputAlignYType
    {
        [EnumMember(Value = "top")]
        Top,
        [EnumMember(Value = "middle")]
        Middle,
        [EnumMember(Value = "bottom")]
        Bottom
    }

    public class LinearizePdfV1Input
    {
        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public LinearizePdfV1InputDocumentType Document { get; set; }

        [JsonProperty("optimizeProfile", DefaultValueHandling = DefaultValueHandling.Include)]
        public LinearizePdfV1InputOptimizeProfileType OptimizeProfile { get; set; } = LinearizePdfV1InputOptimizeProfileType.Default;
    }

    public class LinearizePdfV1InputDocumentType
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum LinearizePdfV1InputOptimizeProfileType
    {
        Default,
        Max
    }

    public class MergeV1Input
    {
        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent[] DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public MergeV1InputDocumentType Document { get; set; }
    }

    public class MergeV1InputDocumentType
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
    }

    public class MergeOverlayV1Input
    {
        [JsonProperty("baseDocContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent BaseDocContent { get; set; }

        [JsonProperty("baseDocName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string BaseDocName { get; set; }

        [JsonProperty("layerDocContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent LayerDocContent { get; set; }

        [JsonProperty("layerDocName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string LayerDocName { get; set; }
    }

    public class OptimizeV1Input
    {
        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public OptimizeV1InputDocumentType Document { get; set; }

        [JsonProperty("optimizeProfile", DefaultValueHandling = DefaultValueHandling.Include)]
        public OptimizeV1InputOptimizeProfileType OptimizeProfile { get; set; } = OptimizeV1InputOptimizeProfileType.Max;
    }

    public class OptimizeV1InputDocumentType
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OptimizeV1InputOptimizeProfileType
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

    public class ParseDocumentV1Response
    {
        [JsonProperty("traceId")]
        public string TraceId { get; set; }

        [JsonProperty("parseInfo")]
        public JToken ParseInfo { get; set; }
    }

    public class ParseDocumentV1Input
    {
        [JsonProperty("docContent")]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document")]
        public ParseDocumentV1InputDocumentType Document { get; set; }
        public string TemplateName { get; set; }
    }

    public class ParseDocumentV1InputDocumentType
    {
        public string Name { get; set; }
    }

    public class PdfOcrV1Input
    {
        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public PdfOcrV1InputDocumentType Document { get; set; }

        [JsonProperty("qualityType", DefaultValueHandling = DefaultValueHandling.Include)]
        public PdfOcrV1InputQualityTypeType QualityType { get; set; } = PdfOcrV1InputQualityTypeType.Draft;

        [JsonProperty("ocrWhenNeeded", DefaultValueHandling = DefaultValueHandling.Include)]
        public PdfOcrV1InputOcrWhenNeededType? OcrWhenNeeded { get; set; } = PdfOcrV1InputOcrWhenNeededType.False;

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("isAsync", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IsAsync { get; set; } = false;
    }

    public class PdfOcrV1InputDocumentType
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PdfOcrV1InputQualityTypeType
    {
        Draft,
        High
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PdfOcrV1InputOcrWhenNeededType
    {
        [EnumMember(Value = "false")]
        False,
        [EnumMember(Value = "true")]
        True
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum schemaValInput2
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

    public class ProtectDocumentV1Input
    {
        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public ProtectDocumentV1InputDocumentType Document { get; set; }

        [JsonProperty("password", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Password { get; set; }

        [JsonProperty("pdfPermission", DefaultValueHandling = DefaultValueHandling.Include)]
        public ProtectDocumentV1InputPdfPermissionType PdfPermission { get; set; } = ProtectDocumentV1InputPdfPermissionType.All;
    }

    public class ProtectDocumentV1InputDocumentType
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ProtectDocumentV1InputPdfPermissionType
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

    public class RedactPdfV1Input
    {
        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public RedactPdfV1InputDocumentType Document { get; set; }

        [JsonProperty("redactPdfAction", DefaultValueHandling = DefaultValueHandling.Include)]
        public RedactPdfV1InputRedactPdfActionType RedactPdfAction { get; set; }
    }

    public class RedactPdfV1InputDocumentType
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
    }

    public class RedactPdfV1InputRedactPdfActionType
    {
        [JsonProperty("redactBoxes", DefaultValueHandling = DefaultValueHandling.Include)]
        public RedactPdfV1InputRedactPdfActionTypeRedactBoxesTypeItem[] RedactBoxes { get; set; }
    }

    public class RedactPdfV1InputRedactPdfActionTypeRedactBoxesTypeItem
    {
        [JsonProperty("coordinates", DefaultValueHandling = DefaultValueHandling.Include)]
        public RedactPdfV1InputRedactPdfActionTypeRedactBoxesTypeItemCoordinatesType Coordinates { get; set; } = new RedactPdfV1InputRedactPdfActionTypeRedactBoxesTypeItemCoordinatesType();

        [JsonProperty("color", DefaultValueHandling = DefaultValueHandling.Include)]
        public RedactPdfV1InputRedactPdfActionTypeRedactBoxesTypeItemColorType Color { get; set; } = new RedactPdfV1InputRedactPdfActionTypeRedactBoxesTypeItemColorType();

        [JsonProperty("fillColor", DefaultValueHandling = DefaultValueHandling.Include)]
        public RedactPdfV1InputRedactPdfActionTypeRedactBoxesTypeItemFillColorType FillColor { get; set; } = new RedactPdfV1InputRedactPdfActionTypeRedactBoxesTypeItemFillColorType();

        [JsonProperty("borderColor", DefaultValueHandling = DefaultValueHandling.Include)]
        public RedactPdfV1InputRedactPdfActionTypeRedactBoxesTypeItemBorderColorType BorderColor { get; set; } = new RedactPdfV1InputRedactPdfActionTypeRedactBoxesTypeItemBorderColorType();

        [JsonProperty("overlayText")]
        public string OverlayText { get; set; }

        [JsonProperty("overlayTextAlignment", DefaultValueHandling = DefaultValueHandling.Include)]
        public RedactPdfV1InputRedactPdfActionTypeRedactBoxesTypeItemOverlayTextAlignmentType? OverlayTextAlignment { get; set; } = RedactPdfV1InputRedactPdfActionTypeRedactBoxesTypeItemOverlayTextAlignmentType.None;

        [JsonProperty("page", DefaultValueHandling = DefaultValueHandling.Include)]
        public int Page { get; set; } = 1;

        [JsonProperty("repeatText", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RepeatText { get; set; } = false;
    }

    public class RedactPdfV1InputRedactPdfActionTypeRedactBoxesTypeItemCoordinatesType
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

    public class RedactPdfV1InputRedactPdfActionTypeRedactBoxesTypeItemColorType
    {
        [JsonProperty("red", DefaultValueHandling = DefaultValueHandling.Include)]
        public double Red { get; set; } = 0;

        [JsonProperty("green", DefaultValueHandling = DefaultValueHandling.Include)]
        public double Green { get; set; } = 0;

        [JsonProperty("blue", DefaultValueHandling = DefaultValueHandling.Include)]
        public double Blue { get; set; } = 0;
    }

    public class RedactPdfV1InputRedactPdfActionTypeRedactBoxesTypeItemFillColorType
    {
        [JsonProperty("red", DefaultValueHandling = DefaultValueHandling.Include)]
        public double Red { get; set; } = 0;

        [JsonProperty("green", DefaultValueHandling = DefaultValueHandling.Include)]
        public double Green { get; set; } = 0;

        [JsonProperty("blue", DefaultValueHandling = DefaultValueHandling.Include)]
        public double Blue { get; set; } = 0;
    }

    public class RedactPdfV1InputRedactPdfActionTypeRedactBoxesTypeItemBorderColorType
    {
        [JsonProperty("red", DefaultValueHandling = DefaultValueHandling.Include)]
        public double Red { get; set; } = 0;

        [JsonProperty("green", DefaultValueHandling = DefaultValueHandling.Include)]
        public double Green { get; set; } = 0;

        [JsonProperty("blue", DefaultValueHandling = DefaultValueHandling.Include)]
        public double Blue { get; set; } = 0;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum RedactPdfV1InputRedactPdfActionTypeRedactBoxesTypeItemOverlayTextAlignmentType
    {
        None,
        Left,
        Center,
        Right,
        Justify,
        FullJustify
    }

    public class RepairPdfV1Input
    {
        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public RepairPdfV1InputDocumentType Document { get; set; }
    }

    public class RepairPdfV1InputDocumentType
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
    }

    public class ReplaceTextWithImageV1Input
    {
        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public ReplaceTextWithImageV1InputDocumentType Document { get; set; }

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

    public class ReplaceTextWithImageV1InputDocumentType
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
    }

    public class RotateDocumentV1Input
    {
        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public RotateDocumentV1InputDocumentType Document { get; set; }

        [JsonProperty("rotationType", DefaultValueHandling = DefaultValueHandling.Include)]
        public RotateDocumentV1InputRotationTypeType RotationType { get; set; } = RotateDocumentV1InputRotationTypeType.NoRotation;
    }

    public class RotateDocumentV1InputDocumentType
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum RotateDocumentV1InputRotationTypeType
    {
        NoRotation,
        Clockwise,
        CounterClockwise,
        UpsideDown
    }

    public class RotatePageV1Input
    {
        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("docName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocName { get; set; }

        [JsonProperty("page", DefaultValueHandling = DefaultValueHandling.Include)]
        public int Page { get; set; } = 1;

        [JsonProperty("rotationType", DefaultValueHandling = DefaultValueHandling.Include)]
        public RotatePageV1InputRotationTypeType RotationType { get; set; } = RotatePageV1InputRotationTypeType.NoRotation;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum RotatePageV1InputRotationTypeType
    {
        NoRotation,
        Clockwise,
        CounterClockwise,
        UpsideDown
    }

    public class SetPDFMetadataV1Input
    {
        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public SetPDFMetadataV1InputDocumentType Document { get; set; }

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
        public SetPDFMetadataV1InputPermissionsTypeItem[] Permissions { get; set; }
    }

    public class SetPDFMetadataV1InputDocumentType
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SetPDFMetadataV1InputPermissionsTypeItem
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

    public class SignPdfV1Input
    {
        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("docName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocName { get; set; }

        [JsonProperty("imageFile", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent ImageFile { get; set; }

        [JsonProperty("imageName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ImageName { get; set; }

        [JsonProperty("alignX", DefaultValueHandling = DefaultValueHandling.Include)]
        public SignPdfV1InputAlignXType AlignX { get; set; } = SignPdfV1InputAlignXType.Left;

        [JsonProperty("alignY", DefaultValueHandling = DefaultValueHandling.Include)]
        public SignPdfV1InputAlignYType AlignY { get; set; } = SignPdfV1InputAlignYType.Top;

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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SignPdfV1InputAlignXType
    {
        [EnumMember(Value = "left")]
        Left,
        [EnumMember(Value = "center")]
        Center,
        [EnumMember(Value = "right")]
        Right
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SignPdfV1InputAlignYType
    {
        [EnumMember(Value = "top")]
        Top,
        [EnumMember(Value = "middle")]
        Middle,
        [EnumMember(Value = "bottom")]
        Bottom
    }

    public class SplitByTextV1Response
    {
        [JsonProperty("splitedDocuments")]
        public SplitByTextV1ResponseSplitedDocumentsTypeItem[] SplitedDocuments { get; set; }
    }

    public class SplitByTextV1ResponseSplitedDocumentsTypeItem
    {
        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("docText")]
        public string DocText { get; set; }

        [JsonProperty("streamFile")]
        public string StreamFile { get; set; }
    }

    public class SplitByTextV1Input
    {
        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public SplitByTextV1InputDocumentType Document { get; set; }

        [JsonProperty("text", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Text { get; set; }

        [JsonProperty("splitTextPage", DefaultValueHandling = DefaultValueHandling.Include)]
        public SplitByTextV1InputSplitTextPageType SplitTextPage { get; set; } = SplitByTextV1InputSplitTextPageType.Before;

        [JsonProperty("fileNaming", DefaultValueHandling = DefaultValueHandling.Include)]
        public SplitByTextV1InputFileNamingType? FileNaming { get; set; } = SplitByTextV1InputFileNamingType.NameAsPerOrder;
    }

    public class SplitByTextV1InputDocumentType
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SplitByTextV1InputSplitTextPageType
    {
        [EnumMember(Value = "before")]
        Before,
        [EnumMember(Value = "after")]
        After
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SplitByTextV1InputFileNamingType
    {
        WithPageNumber,
        NameAsPerOrder
    }

    public class SplitDocumentV1Response
    {
        [JsonProperty("splitedDocuments")]
        public SplitDocumentV1ResponseSplitedDocumentsTypeItem[] SplitedDocuments { get; set; }
    }

    public class SplitDocumentV1ResponseSplitedDocumentsTypeItem
    {
        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("streamFile")]
        public string StreamFile { get; set; }
    }

    public class SplitDocumentV1Input
    {
        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public SplitDocumentV1InputDocumentType Document { get; set; }

        [JsonProperty("splitAction", DefaultValueHandling = DefaultValueHandling.Include)]
        public SplitDocumentV1InputSplitActionType SplitAction { get; set; } = SplitDocumentV1InputSplitActionType.SplitAfterPage;

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
        public SplitDocumentV1InputFileNamingType? FileNaming { get; set; } = SplitDocumentV1InputFileNamingType.NameAsPerOrder;
    }

    public class SplitDocumentV1InputDocumentType
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SplitDocumentV1InputSplitActionType
    {
        SplitAfterPage,
        RecurringSplitAfterPage,
        SplitSequence,
        SplitRanges
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SplitDocumentV1InputFileNamingType
    {
        WithPageNumber,
        NameAsPerOrder
    }

    public class StampV1Input
    {
        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public StampV1InputDocumentType Document { get; set; }

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
        public StampV1InputAlignXType AlignX { get; set; } = StampV1InputAlignXType.Left;

        [JsonProperty("alignY", DefaultValueHandling = DefaultValueHandling.Include)]
        public StampV1InputAlignYType AlignY { get; set; } = StampV1InputAlignYType.Top;

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

    public class StampV1InputDocumentType
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum StampV1InputAlignXType
    {
        [EnumMember(Value = "left")]
        Left,
        [EnumMember(Value = "center")]
        Center,
        [EnumMember(Value = "right")]
        Right
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum StampV1InputAlignYType
    {
        [EnumMember(Value = "top")]
        Top,
        [EnumMember(Value = "middle")]
        Middle,
        [EnumMember(Value = "bottom")]
        Bottom
    }

    public class StartPDF4meWfV1Response
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }
    }

    public class StartPDF4meWfV1Input
    {
        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("docName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocName { get; set; }

        [JsonProperty("wfName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string WfName { get; set; }
    }

    public class UnlockV1Input
    {
        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("docName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocName { get; set; }

        [JsonProperty("password", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Password { get; set; }
    }

    public class UploadBlobAllV1Response
    {
        public string BlobId { get; set; }
    }

    public class UploadBlobAllV1Input
    {
        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("docName")]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocName { get; set; }
    }

    public class ValidatePDFAV1Response
    {
        public string Conformance { get; set; }
        public bool IsConforming { get; set; }
        public bool IsPdfA { get; set; }
    }

    public class ValidatePDFAV1Input
    {
        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public ValidatePDFAV1InputDocumentType Document { get; set; }
    }

    public class ValidatePDFAV1InputDocumentType
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
    }

    public class GetDocumentFromPDF4meInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallBackUrl { get; set; } = "#{listCallbackUrl()}";
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