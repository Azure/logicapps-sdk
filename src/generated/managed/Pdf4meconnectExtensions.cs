//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meconnect
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Pdf4meconnectActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> AddBarcode(Expression<Func<AddBarcodeBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/AddBarcode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> CompressImage(Expression<Func<CompressImageBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/CompressImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ConvertHtmlToPdf(Expression<Func<ConvertHtmlToPdfBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ConvertHtmlToPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ConvertImageFormat(Expression<Func<ConvertImageFormatBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ConvertImageFormat";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ConvertJsonToExcel(Expression<Func<ConvertJsonToExcelBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ConvertJsonToExcel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ConvertMdToPdf(Expression<Func<ConvertMdToPdfBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ConvertMdToPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ConvertToPdf(Expression<Func<ConvertToPdfBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ConvertToPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ConvertUrlToPdf(Expression<Func<ConvertUrlToPdfBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ConvertUrlToPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ConvertVisio(Expression<Func<ConvertVisioSchemaValInput>> schemaVal = null, Expression<Func<object>> operation = null)
        {
            var __workflow_schemaVal = WorkflowExpression.Compile(schemaVal, nameof(schemaVal), required: false);
            var __workflow_operation = WorkflowExpression.Compile(operation, nameof(operation), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ConvertVisio";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["schemaVal"] = Convert.ToString("PDF");
                if (__workflow_schemaVal != null)
                    callPayload.Queries["schemaVal"] = ExpressionConverter.Convert(__workflow_schemaVal);
                if (__workflow_operation != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_operation);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ConvertWordToPdfForm(Expression<Func<ConvertToPdfBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ConvertWordToPdfForm";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> Createbarcode(Expression<Func<CreatebarcodeBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/CreateBarcode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> CreateEpcQrCode(Expression<Func<CreateEpcQrCodeBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/CreateEpcQrCode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> CropImage(Expression<Func<CropImageSchemaValInput>> schemaVal = null, Expression<Func<object>> operation = null)
        {
            var __workflow_schemaVal = WorkflowExpression.Compile(schemaVal, nameof(schemaVal), required: false);
            var __workflow_operation = WorkflowExpression.Compile(operation, nameof(operation), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/CropImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["schemaVal"] = Convert.ToString("Border");
                if (__workflow_schemaVal != null)
                    callPayload.Queries["schemaVal"] = ExpressionConverter.Convert(__workflow_schemaVal);
                if (__workflow_operation != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_operation);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CustomAPI(Expression<Func<string>> featurePath, Expression<Func<string>> body = null)
        {
            var __workflow_featurePath = WorkflowExpression.Compile(featurePath, nameof(featurePath), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/FlowV2/{0}", __workflow_featurePath.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-type"] = Convert.ToString("application/json");
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                else
                    callPayload.Body = ("{\"docContent\":\"\"}").ToJToken();
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> DisableTrackChangesInWord(Expression<Func<ConvertToPdfBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/DisableTrackingChangesInWord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> EnableTrackChangesInWord(Expression<Func<ConvertToPdfBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/EnableTrackingChangesInWord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
        public IBodyWorkflowAction<ExtractAttachmentFromPdfResponse, ApiConnectionActionConfiguration> ExtractAttachmentFromPdf(Expression<Func<ConvertToPdfBodyInput>> body)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
        public IBodyWorkflowAction<ExtractPdfFormDataResponse, ApiConnectionActionConfiguration> ExtractPdfFormData(Expression<Func<ConvertToPdfBodyInput>> body)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
        public IBodyWorkflowAction<ExtractTableFromPdfResponse, ApiConnectionActionConfiguration> ExtractTableFromPdf(Expression<Func<ConvertToPdfBodyInput>> body)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
        public IBodyWorkflowAction<ExtractTextFromWordResponse, ApiConnectionActionConfiguration> ExtractTextFromWord(Expression<Func<ExtractTextFromWordBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ExtractTextFromWordResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ExtractTextFromWord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ExtractTextFromWordResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> FindAndReplace(Expression<Func<FindAndReplaceBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/FindAndReplace";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> FlattenPdf(Expression<Func<ConvertToPdfBodyInput>> body)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> FlipImage(Expression<Func<FlipImageBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/FlipImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GenerateDocumentSingle(Expression<Func<GenerateDocumentMultipleBodyInput>> body)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
        public IBodyWorkflowAction<GetPdfMetadataResponse, ApiConnectionActionConfiguration> GetPdfMetadata(Expression<Func<ConvertToPdfBodyInput>> body)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
        public IBodyWorkflowAction<GetTrackedChangesInWordResponse, ApiConnectionActionConfiguration> GetTrackedChangesInWord(Expression<Func<ConvertToPdfBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GetTrackedChangesInWordResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/GetTrackingChangesInWord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetTrackedChangesInWordResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> PdfToExcel(Expression<Func<PdfToExcelBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ConvertPdfToExcel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> PdfToPowerPoint(Expression<Func<PdfToPowerPointBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ConvertPdfToPowerPoint";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> PdfToWord(Expression<Func<PdfToWordBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ConvertPdfToWord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
        public IBodyWorkflowAction<ReadBarcodesResponse, ApiConnectionActionConfiguration> ReadBarcodes(Expression<Func<ReadBarcodesBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ReadBarcodesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ReadBarcodes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ReadBarcodesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> RemoveExifTagsFromImage(Expression<Func<RemoveExifTagsFromImageBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/RemoveEXIFTagsFromImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> RepairPdf(Expression<Func<ConvertToPdfBodyInput>> body)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ResizeImage(Expression<Func<ResizeImageSchemaValInput>> schemaVal = null, Expression<Func<object>> operation = null)
        {
            var __workflow_schemaVal = WorkflowExpression.Compile(schemaVal, nameof(schemaVal), required: false);
            var __workflow_operation = WorkflowExpression.Compile(operation, nameof(operation), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ResizeImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["schemaVal"] = Convert.ToString("Percentage");
                if (__workflow_schemaVal != null)
                    callPayload.Queries["schemaVal"] = ExpressionConverter.Convert(__workflow_schemaVal);
                if (__workflow_operation != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_operation);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
        public IBodyWorkflowAction<SplitDocByBarcodeResponse, ApiConnectionActionConfiguration> SplitDocByBarcode(Expression<Func<SplitDocByBarcodeBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SplitDocByBarcodeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/SplitPdfByBarcode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SplitDocByBarcodeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
        public IBodyWorkflowAction<StartPDF4meWfResponse, ApiConnectionActionConfiguration> StartPDF4meWf(Expression<Func<StartPDF4meWfBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<StartPDF4meWfResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ExecuteWfTrigger";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<StartPDF4meWfResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4meconnect")]
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
    }

    public class Pdf4meconnectTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<string, ApiConnectionPollingTriggerConfiguration> GetDocumentFromPDF4me(Expression<Func<GetDocumentFromPDF4meBodyInput>> body)
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
        public AddBarcodeBodyInputAlignXType AlignX { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meconnect.AddBarcodeBodyInputAlignXType.Left;

        [JsonProperty("alignY", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddBarcodeBodyInputAlignYType AlignY { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meconnect.AddBarcodeBodyInputAlignYType.Top;

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
    public enum AddBarcodeBodyInputAlignXType
    {
        Left,
        Center,
        Right
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddBarcodeBodyInputAlignYType
    {
        Top,
        Middle,
        Bottom
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

    public class AddAttachmentToPdfBodyInputDocumentType
    {
        public AddAttachmentToPdfBodyInputDocumentType(string name)
        {
            this.Name = name;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
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

    public class AddBarcodeBodyInput
    {
        public AddBarcodeBodyInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent docContent, string docName, string text)
        {
            this.DocContent = docContent;
            this.DocName = docName;
            this.Text = text;
        }

        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("docName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocName { get; set; }

        [JsonProperty("text", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Text { get; set; }

        [JsonProperty("barcodeType", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddBarcodeBodyInputBarcodeTypeType BarcodeType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meconnect.AddBarcodeBodyInputBarcodeTypeType.QrCode;

        [JsonProperty("pages", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Pages { get; set; } = "1";

        [JsonProperty("alignX", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddBarcodeBodyInputAlignXType AlignX { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meconnect.AddBarcodeBodyInputAlignXType.Left;

        [JsonProperty("alignY", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddBarcodeBodyInputAlignYType AlignY { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meconnect.AddBarcodeBodyInputAlignYType.Top;

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

        [JsonProperty("displayText")]
        public string DisplayText { get; set; }

        [JsonProperty("isTextAbove", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IsTextAbove { get; set; } = false;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddBarcodeBodyInputBarcodeTypeType
    {
        QrCode,
        Datamatrix,
        Code128,
        Aztec,
        Pdf417,
        Hanxin
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
        public BodyInputFormFieldTypeType FormFieldType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meconnect.BodyInputFormFieldTypeType.TextBox;

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
        public BodyInputLocationType? Location { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meconnect.BodyInputLocationType.Header;

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

    public class CompressImageBodyInput
    {
        public CompressImageBodyInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent docContent, AddAttachmentToPdfBodyInputDocumentType document, BodyInputImageTypeType imageType)
        {
            this.DocContent = docContent;
            this.Document = document;
            this.ImageType = imageType;
        }

        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddAttachmentToPdfBodyInputDocumentType Document { get; set; }

        [JsonProperty("imageType", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputImageTypeType ImageType { get; set; }

        [JsonProperty("compressionLevel")]
        public BodyInputCompressionLevelType? CompressionLevel { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputImageTypeType
    {
        JPG,
        PNG
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputCompressionLevelType
    {
        Max,
        Medium,
        Low
    }

    public class ConvertHtmlToPdfBodyInput
    {
        public ConvertHtmlToPdfBodyInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent docContent, string docName)
        {
            this.DocContent = docContent;
            this.DocName = docName;
        }

        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("docName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocName { get; set; }

        [JsonProperty("indexFilePath")]
        public string IndexFilePath { get; set; }

        [JsonProperty("layout", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputLayoutType? Layout { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meconnect.BodyInputLayoutType.Portrait;

        [JsonProperty("format", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputFormatType? Format { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meconnect.BodyInputFormatType.A4;

        [JsonProperty("scale", DefaultValueHandling = DefaultValueHandling.Include)]
        public double? Scale { get; set; } = 0.8;

        [JsonProperty("topMargin", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TopMargin { get; set; } = "40px";

        [JsonProperty("bottomMargin", DefaultValueHandling = DefaultValueHandling.Include)]
        public string BottomMargin { get; set; } = "40px";

        [JsonProperty("leftMargin", DefaultValueHandling = DefaultValueHandling.Include)]
        public string LeftMargin { get; set; } = "40px";

        [JsonProperty("rightMargin", DefaultValueHandling = DefaultValueHandling.Include)]
        public string RightMargin { get; set; } = "40px";

        [JsonProperty("printBackground", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? PrintBackground { get; set; } = true;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputLayoutType
    {
        [EnumMember(Value = "")]
        None,
        Portrait,
        Landscape
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputFormatType
    {
        [EnumMember(Value = "")]
        None,
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

    public class ConvertImageFormatBodyInput
    {
        public ConvertImageFormatBodyInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent docContent, AddAttachmentToPdfBodyInputDocumentType document, BodyInputCurrentImageFormatType currentImageFormat, BodyInputNewImageFormatType newImageFormat)
        {
            this.DocContent = docContent;
            this.Document = document;
            this.CurrentImageFormat = currentImageFormat;
            this.NewImageFormat = newImageFormat;
        }

        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddAttachmentToPdfBodyInputDocumentType Document { get; set; }

        [JsonProperty("currentImageFormat", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputCurrentImageFormatType CurrentImageFormat { get; set; }

        [JsonProperty("newImageFormat", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputNewImageFormatType NewImageFormat { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputCurrentImageFormatType
    {
        BMP,
        JPG,
        GIF,
        PNG,
        TIF
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputNewImageFormatType
    {
        BMP,
        JPG,
        GIF,
        PNG,
        TIF
    }

    public class ConvertJsonToExcelBodyInput
    {
        public ConvertJsonToExcelBodyInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent docContent, AddAttachmentToPdfBodyInputDocumentType document)
        {
            this.DocContent = docContent;
            this.Document = document;
        }

        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddAttachmentToPdfBodyInputDocumentType Document { get; set; }

        [JsonProperty("firstRow", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? FirstRow { get; set; } = 0;

        [JsonProperty("firstColumn", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? FirstColumn { get; set; } = 0;

        [JsonProperty("worksheetName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string WorksheetName { get; set; } = "Sheet1";

        [JsonProperty("convertNumberAndDate", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ConvertNumberAndDate { get; set; } = false;

        [JsonProperty("dateFormat")]
        public string DateFormat { get; set; }

        [JsonProperty("numberFormat")]
        public string NumberFormat { get; set; }

        [JsonProperty("ignoreNullValues", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IgnoreNullValues { get; set; } = false;

        [JsonProperty("isTitleBold", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IsTitleBold { get; set; } = true;

        [JsonProperty("isTitleWrapText", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IsTitleWrapText { get; set; } = true;
    }

    public class ConvertMdToPdfBodyInput
    {
        public ConvertMdToPdfBodyInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent docContent, string docName)
        {
            this.DocContent = docContent;
            this.DocName = docName;
        }

        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("docName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocName { get; set; }

        [JsonProperty("mdFilePath")]
        public string MdFilePath { get; set; }
    }

    public class ConvertToPdfBodyInput
    {
        public ConvertToPdfBodyInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent docContent, AddAttachmentToPdfBodyInputDocumentType document)
        {
            this.DocContent = docContent;
            this.Document = document;
        }

        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddAttachmentToPdfBodyInputDocumentType Document { get; set; }
    }

    public class ConvertUrlToPdfBodyInput
    {
        public ConvertUrlToPdfBodyInput(string webUrl)
        {
            this.WebUrl = webUrl;
        }

        [JsonProperty("webUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string WebUrl { get; set; }

        [JsonProperty("authType", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputAuthTypeType? AuthType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meconnect.BodyInputAuthTypeType.NoAuth;

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputAuthTypeType
    {
        NoAuth,
        SharePointLogin
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ConvertVisioSchemaValInput
    {
        PDF,
        BMP,
        GIF,
        PNG,
        JPG,
        SVG,
        TIFF,
        HTML,
        VSDX
    }

    public class CreatebarcodeBodyInput
    {
        public CreatebarcodeBodyInput(string text)
        {
            this.Text = text;
        }

        [JsonProperty("barcodeType", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddBarcodeBodyInputBarcodeTypeType BarcodeType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meconnect.AddBarcodeBodyInputBarcodeTypeType.QrCode;

        [JsonProperty("text", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Text { get; set; }

        [JsonProperty("hideText", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? HideText { get; set; } = true;
    }

    public class CreateEpcQrCodeBodyInput
    {
        public CreateEpcQrCodeBodyInput(BodyInputEpcQrCodeActionType epcQrCodeAction)
        {
            this.EpcQrCodeAction = epcQrCodeAction;
        }

        [JsonProperty("epcQrCodeAction", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputEpcQrCodeActionType EpcQrCodeAction { get; set; }
    }

    public class BodyInputEpcQrCodeActionType
    {
        public BodyInputEpcQrCodeActionType(string receiverName, string iban, double amount)
        {
            this.ReceiverName = receiverName;
            this.Iban = iban;
            this.Amount = amount;
        }

        [JsonProperty("serviceTag", DefaultValueHandling = DefaultValueHandling.Include)]
        internal BodyInputEpcQrCodeActionTypeServiceTagType ServiceTag { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meconnect.BodyInputEpcQrCodeActionTypeServiceTagType.BCD;

        [JsonProperty("version", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputEpcQrCodeActionTypeVersionType Version { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meconnect.BodyInputEpcQrCodeActionTypeVersionType.V2;

        [JsonProperty("characterSet", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputEpcQrCodeActionTypeCharacterSetType? CharacterSet { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meconnect.BodyInputEpcQrCodeActionTypeCharacterSetType.UTF8;

        [JsonProperty("identificationCode", DefaultValueHandling = DefaultValueHandling.Include)]
        internal BodyInputEpcQrCodeActionTypeIdentificationCodeType IdentificationCode { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meconnect.BodyInputEpcQrCodeActionTypeIdentificationCodeType.SCT;

        [JsonProperty("bic")]
        public string Bic { get; set; }

        [JsonProperty("receiverName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ReceiverName { get; set; }

        [JsonProperty("iban", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Iban { get; set; }

        [JsonProperty("currency", DefaultValueHandling = DefaultValueHandling.Include)]
        internal BodyInputEpcQrCodeActionTypeCurrencyType Currency { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meconnect.BodyInputEpcQrCodeActionTypeCurrencyType.EUR;

        [JsonProperty("amount", DefaultValueHandling = DefaultValueHandling.Include)]
        public double Amount { get; set; }

        [JsonProperty("purpose")]
        public string Purpose { get; set; }

        [JsonProperty("remittanceReference")]
        public string RemittanceReference { get; set; }

        [JsonProperty("remittanceText")]
        public string RemittanceText { get; set; }

        [JsonProperty("information")]
        public string Information { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputEpcQrCodeActionTypeServiceTagType
    {
        BCD
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputEpcQrCodeActionTypeVersionType
    {
        V1,
        V2
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputEpcQrCodeActionTypeCharacterSetType
    {
        UTF8,
        [EnumMember(Value = "ISO8859_1")]
        ISO88591,
        [EnumMember(Value = "ISO8859_2")]
        ISO88592,
        [EnumMember(Value = "ISO8859_4")]
        ISO88594,
        [EnumMember(Value = "ISO8859_5")]
        ISO88595,
        [EnumMember(Value = "ISO8859_7")]
        ISO88597,
        [EnumMember(Value = "ISO8859_10")]
        ISO885910,
        [EnumMember(Value = "ISO8859_15")]
        ISO885915
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputEpcQrCodeActionTypeIdentificationCodeType
    {
        SCT
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputEpcQrCodeActionTypeCurrencyType
    {
        EUR
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
        public BodyInputComplianceType Compliance { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meconnect.BodyInputComplianceType.PdfA1b;

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
    public enum CropImageSchemaValInput
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
        public BodyInputDeletePageOptionType DeletePageOption { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meconnect.BodyInputDeletePageOptionType.NoTextNoImages;
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

    public class ExtractTextFromWordResponse
    {
        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("docData")]
        public string DocData { get; set; }

        [JsonProperty("docText")]
        public string DocText { get; set; }
    }

    public class ExtractTextFromWordBodyInput
    {
        public ExtractTextFromWordBodyInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent docContent, AddAttachmentToPdfBodyInputDocumentType document)
        {
            this.DocContent = docContent;
            this.Document = document;
        }

        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddAttachmentToPdfBodyInputDocumentType Document { get; set; }

        [JsonProperty("startPageNumber")]
        public string StartPageNumber { get; set; }

        [JsonProperty("endPageNumber")]
        public string EndPageNumber { get; set; }

        [JsonProperty("removeComments", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RemoveComments { get; set; } = true;

        [JsonProperty("acceptChanges", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AcceptChanges { get; set; } = true;
    }

    public class FindAndReplaceBodyInput
    {
        public FindAndReplaceBodyInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent docContent, AddAttachmentToPdfBodyInputDocumentType document, string oldText, string newText)
        {
            this.DocContent = docContent;
            this.Document = document;
            this.OldText = oldText;
            this.NewText = newText;
        }

        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddAttachmentToPdfBodyInputDocumentType Document { get; set; }

        [JsonProperty("oldText", DefaultValueHandling = DefaultValueHandling.Include)]
        public string OldText { get; set; }

        [JsonProperty("newText", DefaultValueHandling = DefaultValueHandling.Include)]
        public string NewText { get; set; }

        [JsonProperty("pageSequence", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PageSequence { get; set; } = "all";
    }

    public class FlipImageBodyInput
    {
        public FlipImageBodyInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent docContent, AddAttachmentToPdfBodyInputDocumentType document, BodyInputOrientationTypeType orientationType)
        {
            this.DocContent = docContent;
            this.Document = document;
            this.OrientationType = orientationType;
        }

        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddAttachmentToPdfBodyInputDocumentType Document { get; set; }

        [JsonProperty("orientationType", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputOrientationTypeType OrientationType { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputOrientationTypeType
    {
        Horizontal,
        Vertical,
        HorizontalAndVertical
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
        public BodyInputTemplateFileTypeType TemplateFileType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meconnect.BodyInputTemplateFileTypeType.Docx;

        [JsonProperty("templateFileName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TemplateFileName { get; set; }

        [JsonProperty("templateFileData", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent TemplateFileData { get; set; }

        [JsonProperty("documentDataType", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputDocumentDataTypeType DocumentDataType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meconnect.BodyInputDocumentDataTypeType.Json;

        [JsonProperty("documentDataFile")]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocumentDataFile { get; set; }

        [JsonProperty("documentDataText")]
        public string DocumentDataText { get; set; }

        [JsonProperty("metaDataJson")]
        public string MetaDataJson { get; set; }

        [JsonProperty("outputType", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputOutputTypeType OutputType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meconnect.BodyInputOutputTypeType.Docx;

        [JsonProperty("keepPdfEditable", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? KeepPdfEditable { get; set; } = false;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputTemplateFileTypeType
    {
        Docx,
        Html,
        Pdf
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputDocumentDataTypeType
    {
        Json,
        XML
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputOutputTypeType
    {
        PDF,
        Docx,
        Html
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

    public class GetTrackedChangesInWordResponse
    {
        [JsonProperty("trackingChanges")]
        public GetTrackedChangesInWordResponseTrackingChangesTypeItem[] TrackingChanges { get; set; }
    }

    public class GetTrackedChangesInWordResponseTrackingChangesTypeItem
    {
        [JsonProperty("revisionNumber")]
        public int RevisionNumber { get; set; }

        [JsonProperty("revisionType")]
        public string RevisionType { get; set; }

        [JsonProperty("revisionText")]
        public string RevisionText { get; set; }

        [JsonProperty("revisionAuthor")]
        public string RevisionAuthor { get; set; }

        [JsonProperty("dateTimeStamp")]
        public string DateTimeStamp { get; set; }

        [JsonProperty("pageNumber")]
        public int PageNumber { get; set; }
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
        public ImageStampBodyInputAlignXType AlignX { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meconnect.ImageStampBodyInputAlignXType.Left;

        [JsonProperty("alignY", DefaultValueHandling = DefaultValueHandling.Include)]
        public ImageStampBodyInputAlignYType AlignY { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meconnect.ImageStampBodyInputAlignYType.Top;

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
        public LinearizePdfBodyInputOptimizeProfileType OptimizeProfile { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meconnect.LinearizePdfBodyInputOptimizeProfileType.Default;
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
        public OptimizeBodyInputOptimizeProfileType OptimizeProfile { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meconnect.OptimizeBodyInputOptimizeProfileType.Max;
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
        public BodyInputQualityTypeType QualityType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meconnect.BodyInputQualityTypeType.Draft;

        [JsonProperty("ocrWhenNeeded", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputOcrWhenNeededType? OcrWhenNeeded { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meconnect.BodyInputOcrWhenNeededType.False;

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

    public class PdfToExcelBodyInput
    {
        public PdfToExcelBodyInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent docContent, AddAttachmentToPdfBodyInputDocumentType document)
        {
            this.DocContent = docContent;
            this.Document = document;
        }

        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddAttachmentToPdfBodyInputDocumentType Document { get; set; }

        [JsonProperty("qualityType", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputQualityTypeType QualityType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meconnect.BodyInputQualityTypeType.Draft;

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("mergeAllSheets", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MergeAllSheets { get; set; } = false;

        [JsonProperty("outputFormat", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputOutputFormatType? OutputFormat { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meconnect.BodyInputOutputFormatType.None;

        [JsonProperty("isAsync", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IsAsync { get; set; } = false;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputOutputFormatType
    {
        [EnumMember(Value = "")]
        None,
        Excel,
        CSV
    }

    public class PdfToPowerPointBodyInput
    {
        public PdfToPowerPointBodyInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent docContent, AddAttachmentToPdfBodyInputDocumentType document)
        {
            this.DocContent = docContent;
            this.Document = document;
        }

        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddAttachmentToPdfBodyInputDocumentType Document { get; set; }

        [JsonProperty("qualityType", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputQualityTypeType? QualityType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meconnect.BodyInputQualityTypeType.High;

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("isAsync", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IsAsync { get; set; } = false;
    }

    public class PdfToWordBodyInput
    {
        public PdfToWordBodyInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent docContent, AddAttachmentToPdfBodyInputDocumentType document)
        {
            this.DocContent = docContent;
            this.Document = document;
        }

        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddAttachmentToPdfBodyInputDocumentType Document { get; set; }

        [JsonProperty("qualityType", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputQualityTypeType QualityType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meconnect.BodyInputQualityTypeType.Draft;

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("isAsync", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IsAsync { get; set; } = false;
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
        public BodyInputPdfPermissionType PdfPermission { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meconnect.BodyInputPdfPermissionType.All;
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

    public class ReadBarcodesResponse
    {
        [JsonProperty("barcodes")]
        public ReadBarcodesResponseBarcodesTypeItem[] Barcodes { get; set; }
    }

    public class ReadBarcodesResponseBarcodesTypeItem
    {
        [JsonProperty("barcodeType")]
        public string BarcodeType { get; set; }
        public string Value { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }
    }

    public class ReadBarcodesBodyInput
    {
        public ReadBarcodesBodyInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent docContent, AddAttachmentToPdfBodyInputDocumentType document, BodyInputBarcodeTypeTypeItem[] barcodeType)
        {
            this.DocContent = docContent;
            this.Document = document;
            this.BarcodeType = barcodeType;
        }

        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddAttachmentToPdfBodyInputDocumentType Document { get; set; }

        [JsonProperty("barcodeType", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputBarcodeTypeTypeItem[] BarcodeType { get; set; }

        [JsonProperty("pages", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Pages { get; set; } = "all";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputBarcodeTypeTypeItem
    {
        All,
        QrCode,
        Datamatrix,
        Code128,
        Code39,
        Pdf417,
        Code93
    }

    public class RemoveExifTagsFromImageBodyInput
    {
        public RemoveExifTagsFromImageBodyInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent docContent, AddAttachmentToPdfBodyInputDocumentType document, BodyInputImageTypeType imageType)
        {
            this.DocContent = docContent;
            this.Document = document;
            this.ImageType = imageType;
        }

        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddAttachmentToPdfBodyInputDocumentType Document { get; set; }

        [JsonProperty("imageType", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputImageTypeType ImageType { get; set; }
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ResizeImageSchemaValInput
    {
        Percentage,
        Specific
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
        public BodyInputRotationTypeType RotationType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meconnect.BodyInputRotationTypeType.NoRotation;
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
        public BodyInputRotationTypeType RotationType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meconnect.BodyInputRotationTypeType.NoRotation;
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
        public ImageStampBodyInputAlignXType AlignX { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meconnect.ImageStampBodyInputAlignXType.Left;

        [JsonProperty("alignY", DefaultValueHandling = DefaultValueHandling.Include)]
        public ImageStampBodyInputAlignYType AlignY { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meconnect.ImageStampBodyInputAlignYType.Top;

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
        public BodyInputSplitTextPageType SplitTextPage { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meconnect.BodyInputSplitTextPageType.Before;

        [JsonProperty("fileNaming", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputFileNamingType? FileNaming { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meconnect.BodyInputFileNamingType.NameAsPerOrder;
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

    public class SplitDocByBarcodeResponse
    {
        [JsonProperty("splitedDocuments")]
        public SplitDocByBarcodeResponseSplitedDocumentsTypeItem[] SplitedDocuments { get; set; }
    }

    public class SplitDocByBarcodeResponseSplitedDocumentsTypeItem
    {
        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("barcodeText")]
        public string BarcodeText { get; set; }

        [JsonProperty("streamFile")]
        public string StreamFile { get; set; }
    }

    public class SplitDocByBarcodeBodyInput
    {
        public SplitDocByBarcodeBodyInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent docContent, AddAttachmentToPdfBodyInputDocumentType document, string barcodeString)
        {
            this.DocContent = docContent;
            this.Document = document;
            this.BarcodeString = barcodeString;
        }

        [JsonProperty("docContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent DocContent { get; set; }

        [JsonProperty("document", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddAttachmentToPdfBodyInputDocumentType Document { get; set; }

        [JsonProperty("barcodeFilter", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputBarcodeFilterType BarcodeFilter { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meconnect.BodyInputBarcodeFilterType.StartsWith;

        [JsonProperty("barcodeString", DefaultValueHandling = DefaultValueHandling.Include)]
        public string BarcodeString { get; set; }

        [JsonProperty("barcodeType", DefaultValueHandling = DefaultValueHandling.Include)]
        public SplitDocByBarcodeBodyInputBarcodeTypeType BarcodeType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meconnect.SplitDocByBarcodeBodyInputBarcodeTypeType.Any;

        [JsonProperty("splitBarcodePage", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputSplitBarcodePageType SplitBarcodePage { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meconnect.BodyInputSplitBarcodePageType.Before;

        [JsonProperty("combinePagesWithSameConsecutiveBarcodes", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CombinePagesWithSameConsecutiveBarcodes { get; set; } = false;

        [JsonProperty("pdfRenderDpi", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PdfRenderDpi { get; set; } = "150";

        [JsonProperty("isAsync", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IsAsync { get; set; } = false;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputBarcodeFilterType
    {
        [EnumMember(Value = "startsWith")]
        StartsWith,
        [EnumMember(Value = "endsWith")]
        EndsWith,
        [EnumMember(Value = "contains")]
        Contains,
        [EnumMember(Value = "exact")]
        Exact
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SplitDocByBarcodeBodyInputBarcodeTypeType
    {
        [EnumMember(Value = "any")]
        Any,
        [EnumMember(Value = "datamatrix")]
        Datamatrix,
        [EnumMember(Value = "qrcode")]
        Qrcode
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputSplitBarcodePageType
    {
        [EnumMember(Value = "before")]
        Before,
        [EnumMember(Value = "after")]
        After,
        [EnumMember(Value = "remove")]
        Remove
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
        public BodyInputSplitActionType SplitAction { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meconnect.BodyInputSplitActionType.SplitAfterPage;

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
        public BodyInputFileNamingType? FileNaming { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meconnect.BodyInputFileNamingType.NameAsPerOrder;
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
        public ImageStampBodyInputAlignXType AlignX { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meconnect.ImageStampBodyInputAlignXType.Left;

        [JsonProperty("alignY", DefaultValueHandling = DefaultValueHandling.Include)]
        public ImageStampBodyInputAlignYType AlignY { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meconnect.ImageStampBodyInputAlignYType.Top;

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

    public class StartPDF4meWfResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("jobId")]
        public string JobId { get; set; }
    }

    public class StartPDF4meWfBodyInput
    {
        public StartPDF4meWfBodyInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent docContent, string docName, string wfName)
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

    public class GetDocumentFromPDF4meBodyInput
    {
        public GetDocumentFromPDF4meBodyInput(string name)
        {
            this.Name = name;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallBackUrl { get; set; } = "#{listCallbackUrl()}";
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4meconnect;

    public partial class WorkflowManagedActions
    {
        public Pdf4meconnectActions Pdf4meconnect(string connectionId) => new Pdf4meconnectActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Pdf4meconnectTriggers Pdf4meconnect(string connectionId) => new Pdf4meconnectTriggers(connectionId);
    }
}