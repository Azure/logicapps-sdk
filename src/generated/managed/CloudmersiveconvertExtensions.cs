//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cloudmersiveconvert
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CloudmersiveconvertActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<CreateBlankDocxResponse, ApiConnectionActionConfiguration> EditDocumentDocxCreateBlankDocument(Expression<Func<EditDocumentDocxCreateBlankDocumentInputInput>> input)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            return new DeferredBodyAction<CreateBlankDocxResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/docx/create/blank";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_input);
                return new ApiConnectionAction<CreateBlankDocxResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> EditDocumentDocxDeletePages(Expression<Func<EditDocumentDocxDeletePagesReqConfigInput>> reqConfig)
        {
            var __workflow_reqConfig = WorkflowExpression.Compile(reqConfig, nameof(reqConfig), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/docx/delete-pages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_reqConfig);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<DeleteDocxTableRowResponse, ApiConnectionActionConfiguration> EditDocumentDocxDeleteTableRow(Expression<Func<EditDocumentDocxDeleteTableRowReqConfigInput>> reqConfig)
        {
            var __workflow_reqConfig = WorkflowExpression.Compile(reqConfig, nameof(reqConfig), required: true);
            return new DeferredBodyAction<DeleteDocxTableRowResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/docx/delete-table-row";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_reqConfig);
                return new ApiConnectionAction<DeleteDocxTableRowResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<DeleteDocxTableRowRangeResponse, ApiConnectionActionConfiguration> EditDocumentDocxDeleteTableRowRange(Expression<Func<EditDocumentDocxDeleteTableRowRangeReqConfigInput>> reqConfig)
        {
            var __workflow_reqConfig = WorkflowExpression.Compile(reqConfig, nameof(reqConfig), required: true);
            return new DeferredBodyAction<DeleteDocxTableRowRangeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/docx/delete-table-row/range";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_reqConfig);
                return new ApiConnectionAction<DeleteDocxTableRowRangeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<GetDocxBodyResponse, ApiConnectionActionConfiguration> EditDocumentDocxBody(Expression<Func<EditDocumentDocxBodyReqConfigInput>> reqConfig)
        {
            var __workflow_reqConfig = WorkflowExpression.Compile(reqConfig, nameof(reqConfig), required: true);
            return new DeferredBodyAction<GetDocxBodyResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/docx/get-body";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_reqConfig);
                return new ApiConnectionAction<GetDocxBodyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<GetDocxCommentsHierarchicalResponse, ApiConnectionActionConfiguration> EditDocumentDocxGetCommentsHierarchical(Expression<Func<EditDocumentDocxBodyReqConfigInput>> reqConfig)
        {
            var __workflow_reqConfig = WorkflowExpression.Compile(reqConfig, nameof(reqConfig), required: true);
            return new DeferredBodyAction<GetDocxCommentsHierarchicalResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/docx/get-comments/hierarchical";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_reqConfig);
                return new ApiConnectionAction<GetDocxCommentsHierarchicalResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<GetDocxHeadersAndFootersResponse, ApiConnectionActionConfiguration> EditDocumentDocxGetHeadersAndFooters(Expression<Func<EditDocumentDocxBodyReqConfigInput>> reqConfig)
        {
            var __workflow_reqConfig = WorkflowExpression.Compile(reqConfig, nameof(reqConfig), required: true);
            return new DeferredBodyAction<GetDocxHeadersAndFootersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/docx/get-headers-and-footers";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_reqConfig);
                return new ApiConnectionAction<GetDocxHeadersAndFootersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<GetDocxImagesResponse, ApiConnectionActionConfiguration> EditDocumentDocxGetImages(Expression<Func<EditDocumentDocxBodyReqConfigInput>> reqConfig)
        {
            var __workflow_reqConfig = WorkflowExpression.Compile(reqConfig, nameof(reqConfig), required: true);
            return new DeferredBodyAction<GetDocxImagesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/docx/get-images";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_reqConfig);
                return new ApiConnectionAction<GetDocxImagesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<GetDocxPagesResponse, ApiConnectionActionConfiguration> EditDocumentDocxPages(Expression<Func<EditDocumentDocxBodyReqConfigInput>> reqConfig)
        {
            var __workflow_reqConfig = WorkflowExpression.Compile(reqConfig, nameof(reqConfig), required: true);
            return new DeferredBodyAction<GetDocxPagesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/docx/get-pages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_reqConfig);
                return new ApiConnectionAction<GetDocxPagesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<GetDocxSectionsResponse, ApiConnectionActionConfiguration> EditDocumentDocxGetSections(Expression<Func<EditDocumentDocxBodyReqConfigInput>> reqConfig)
        {
            var __workflow_reqConfig = WorkflowExpression.Compile(reqConfig, nameof(reqConfig), required: true);
            return new DeferredBodyAction<GetDocxSectionsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/docx/get-sections";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_reqConfig);
                return new ApiConnectionAction<GetDocxSectionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<GetDocxStylesResponse, ApiConnectionActionConfiguration> EditDocumentDocxGetStyles(Expression<Func<EditDocumentDocxBodyReqConfigInput>> reqConfig)
        {
            var __workflow_reqConfig = WorkflowExpression.Compile(reqConfig, nameof(reqConfig), required: true);
            return new DeferredBodyAction<GetDocxStylesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/docx/get-styles";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_reqConfig);
                return new ApiConnectionAction<GetDocxStylesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<GetDocxTableRowResponse, ApiConnectionActionConfiguration> EditDocumentDocxGetTableRow(Expression<Func<EditDocumentDocxDeleteTableRowReqConfigInput>> reqConfig)
        {
            var __workflow_reqConfig = WorkflowExpression.Compile(reqConfig, nameof(reqConfig), required: true);
            return new DeferredBodyAction<GetDocxTableRowResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/docx/get-table-row";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_reqConfig);
                return new ApiConnectionAction<GetDocxTableRowResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<GetDocxTableByIndexResponse, ApiConnectionActionConfiguration> EditDocumentDocxGetTableByIndex(Expression<Func<EditDocumentDocxGetTableByIndexReqConfigInput>> reqConfig)
        {
            var __workflow_reqConfig = WorkflowExpression.Compile(reqConfig, nameof(reqConfig), required: true);
            return new DeferredBodyAction<GetDocxTableByIndexResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/docx/get-table/by-index";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_reqConfig);
                return new ApiConnectionAction<GetDocxTableByIndexResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<GetDocxTablesResponse, ApiConnectionActionConfiguration> EditDocumentDocxGetTables(Expression<Func<EditDocumentDocxBodyReqConfigInput>> reqConfig)
        {
            var __workflow_reqConfig = WorkflowExpression.Compile(reqConfig, nameof(reqConfig), required: true);
            return new DeferredBodyAction<GetDocxTablesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/docx/get-tables";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_reqConfig);
                return new ApiConnectionAction<GetDocxTablesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<InsertDocxCommentOnParagraphResponse, ApiConnectionActionConfiguration> EditDocumentDocxInsertCommentOnParagraph(Expression<Func<EditDocumentDocxInsertCommentOnParagraphReqConfigInput>> reqConfig)
        {
            var __workflow_reqConfig = WorkflowExpression.Compile(reqConfig, nameof(reqConfig), required: true);
            return new DeferredBodyAction<InsertDocxCommentOnParagraphResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/docx/insert-comment/on/paragraph";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_reqConfig);
                return new ApiConnectionAction<InsertDocxCommentOnParagraphResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<DocxInsertImageResponse, ApiConnectionActionConfiguration> EditDocumentDocxInsertImage(Expression<Func<EditDocumentDocxInsertImageReqConfigInput>> reqConfig)
        {
            var __workflow_reqConfig = WorkflowExpression.Compile(reqConfig, nameof(reqConfig), required: true);
            return new DeferredBodyAction<DocxInsertImageResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/docx/insert-image";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_reqConfig);
                return new ApiConnectionAction<DocxInsertImageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<InsertDocxInsertParagraphResponse, ApiConnectionActionConfiguration> EditDocumentDocxInsertParagraph(Expression<Func<EditDocumentDocxInsertParagraphReqConfigInput>> reqConfig)
        {
            var __workflow_reqConfig = WorkflowExpression.Compile(reqConfig, nameof(reqConfig), required: true);
            return new DeferredBodyAction<InsertDocxInsertParagraphResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/docx/insert-paragraph";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_reqConfig);
                return new ApiConnectionAction<InsertDocxInsertParagraphResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<InsertDocxTablesResponse, ApiConnectionActionConfiguration> EditDocumentDocxInsertTable(Expression<Func<EditDocumentDocxInsertTableReqConfigInput>> reqConfig)
        {
            var __workflow_reqConfig = WorkflowExpression.Compile(reqConfig, nameof(reqConfig), required: true);
            return new DeferredBodyAction<InsertDocxTablesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/docx/insert-table";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_reqConfig);
                return new ApiConnectionAction<InsertDocxTablesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<InsertDocxTableRowResponse, ApiConnectionActionConfiguration> EditDocumentDocxInsertTableRow(Expression<Func<EditDocumentDocxInsertTableRowReqConfigInput>> reqConfig)
        {
            var __workflow_reqConfig = WorkflowExpression.Compile(reqConfig, nameof(reqConfig), required: true);
            return new DeferredBodyAction<InsertDocxTableRowResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/docx/insert-table-row";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_reqConfig);
                return new ApiConnectionAction<InsertDocxTableRowResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<RemoveDocxHeadersAndFootersResponse, ApiConnectionActionConfiguration> EditDocumentDocxRemoveHeadersAndFooters(Expression<Func<EditDocumentDocxRemoveHeadersAndFootersReqConfigInput>> reqConfig)
        {
            var __workflow_reqConfig = WorkflowExpression.Compile(reqConfig, nameof(reqConfig), required: true);
            return new DeferredBodyAction<RemoveDocxHeadersAndFootersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/docx/remove-headers-and-footers";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_reqConfig);
                return new ApiConnectionAction<RemoveDocxHeadersAndFootersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<DocxRemoveObjectResponse, ApiConnectionActionConfiguration> EditDocumentDocxRemoveObject(Expression<Func<EditDocumentDocxRemoveObjectReqConfigInput>> reqConfig)
        {
            var __workflow_reqConfig = WorkflowExpression.Compile(reqConfig, nameof(reqConfig), required: true);
            return new DeferredBodyAction<DocxRemoveObjectResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/docx/remove-object";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_reqConfig);
                return new ApiConnectionAction<DocxRemoveObjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> EditDocumentDocxReplace(Expression<Func<EditDocumentDocxReplaceReqConfigInput>> reqConfig)
        {
            var __workflow_reqConfig = WorkflowExpression.Compile(reqConfig, nameof(reqConfig), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/docx/replace-all";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_reqConfig);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<DocxSetFooterResponse, ApiConnectionActionConfiguration> EditDocumentDocxSetFooter(Expression<Func<EditDocumentDocxSetFooterReqConfigInput>> reqConfig)
        {
            var __workflow_reqConfig = WorkflowExpression.Compile(reqConfig, nameof(reqConfig), required: true);
            return new DeferredBodyAction<DocxSetFooterResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/docx/set-footer";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_reqConfig);
                return new ApiConnectionAction<DocxSetFooterResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<DocxSetFooterResponse, ApiConnectionActionConfiguration> EditDocumentDocxSetFooterAddPageNumber(Expression<Func<EditDocumentDocxSetFooterAddPageNumberReqConfigInput>> reqConfig)
        {
            var __workflow_reqConfig = WorkflowExpression.Compile(reqConfig, nameof(reqConfig), required: true);
            return new DeferredBodyAction<DocxSetFooterResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/docx/set-footer/add-page-number";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_reqConfig);
                return new ApiConnectionAction<DocxSetFooterResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<DocxSetHeaderResponse, ApiConnectionActionConfiguration> EditDocumentDocxSetHeader(Expression<Func<EditDocumentDocxSetHeaderReqConfigInput>> reqConfig)
        {
            var __workflow_reqConfig = WorkflowExpression.Compile(reqConfig, nameof(reqConfig), required: true);
            return new DeferredBodyAction<DocxSetHeaderResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/docx/set-header";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_reqConfig);
                return new ApiConnectionAction<DocxSetHeaderResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<UpdateDocxTableCellResponse, ApiConnectionActionConfiguration> EditDocumentDocxUpdateTableCell(Expression<Func<EditDocumentDocxUpdateTableCellReqConfigInput>> reqConfig)
        {
            var __workflow_reqConfig = WorkflowExpression.Compile(reqConfig, nameof(reqConfig), required: true);
            return new DeferredBodyAction<UpdateDocxTableCellResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/docx/update-table-cell";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_reqConfig);
                return new ApiConnectionAction<UpdateDocxTableCellResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<UpdateDocxTableRowResponse, ApiConnectionActionConfiguration> EditDocumentDocxUpdateTableRow(Expression<Func<EditDocumentDocxUpdateTableRowReqConfigInput>> reqConfig)
        {
            var __workflow_reqConfig = WorkflowExpression.Compile(reqConfig, nameof(reqConfig), required: true);
            return new DeferredBodyAction<UpdateDocxTableRowResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/docx/update-table-row";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_reqConfig);
                return new ApiConnectionAction<UpdateDocxTableRowResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> EditDocumentFinishEditing(Expression<Func<EditDocumentFinishEditingReqConfigInput>> reqConfig)
        {
            var __workflow_reqConfig = WorkflowExpression.Compile(reqConfig, nameof(reqConfig), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/finish-editing";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_reqConfig);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> EditDocumentPptxDeleteSlides(Expression<Func<EditDocumentPptxDeleteSlidesReqConfigInput>> reqConfig)
        {
            var __workflow_reqConfig = WorkflowExpression.Compile(reqConfig, nameof(reqConfig), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/pptx/delete-slides";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_reqConfig);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> EditDocumentPptxReplace(Expression<Func<EditDocumentDocxReplaceReqConfigInput>> reqConfig)
        {
            var __workflow_reqConfig = WorkflowExpression.Compile(reqConfig, nameof(reqConfig), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/pptx/replace-all";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_reqConfig);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<ClearXlsxCellResponse, ApiConnectionActionConfiguration> EditDocumentXlsxClearCellByIndex(Expression<Func<EditDocumentXlsxClearCellByIndexInputInput>> input)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            return new DeferredBodyAction<ClearXlsxCellResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/xlsx/clear-cell/by-index";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_input);
                return new ApiConnectionAction<ClearXlsxCellResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<CreateBlankSpreadsheetResponse, ApiConnectionActionConfiguration> EditDocumentXlsxCreateBlankSpreadsheet(Expression<Func<EditDocumentXlsxCreateBlankSpreadsheetInputInput>> input)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            return new DeferredBodyAction<CreateBlankSpreadsheetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/xlsx/create/blank";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_input);
                return new ApiConnectionAction<CreateBlankSpreadsheetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<CreateSpreadsheetFromDataResponse, ApiConnectionActionConfiguration> EditDocumentXlsxCreateSpreadsheetFromData(Expression<Func<EditDocumentXlsxCreateSpreadsheetFromDataInputInput>> input)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            return new DeferredBodyAction<CreateSpreadsheetFromDataResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/xlsx/create/from/data";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_input);
                return new ApiConnectionAction<CreateSpreadsheetFromDataResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> EditDocumentXlsxDeleteWorksheet(Expression<Func<EditDocumentXlsxDeleteWorksheetReqConfigInput>> reqConfig)
        {
            var __workflow_reqConfig = WorkflowExpression.Compile(reqConfig, nameof(reqConfig), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/xlsx/delete-worksheet";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_reqConfig);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<GetXlsxCellByIdentifierResponse, ApiConnectionActionConfiguration> EditDocumentXlsxGetCellByIdentifier(Expression<Func<EditDocumentXlsxGetCellByIdentifierInputInput>> input)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            return new DeferredBodyAction<GetXlsxCellByIdentifierResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/xlsx/get-cell/by-identifier";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_input);
                return new ApiConnectionAction<GetXlsxCellByIdentifierResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<GetXlsxCellResponse, ApiConnectionActionConfiguration> EditDocumentXlsxGetCellByIndex(Expression<Func<EditDocumentXlsxGetCellByIndexInputInput>> input)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            return new DeferredBodyAction<GetXlsxCellResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/xlsx/get-cell/by-index";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_input);
                return new ApiConnectionAction<GetXlsxCellResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<GetXlsxColumnsResponse, ApiConnectionActionConfiguration> EditDocumentXlsxGetColumns(Expression<Func<EditDocumentXlsxGetColumnsInputInput>> input)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            return new DeferredBodyAction<GetXlsxColumnsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/xlsx/get-columns";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_input);
                return new ApiConnectionAction<GetXlsxColumnsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<GetXlsxImagesResponse, ApiConnectionActionConfiguration> EditDocumentXlsxGetImages(Expression<Func<EditDocumentXlsxGetColumnsInputInput>> input)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            return new DeferredBodyAction<GetXlsxImagesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/xlsx/get-images";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_input);
                return new ApiConnectionAction<GetXlsxImagesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<GetXlsxRowsAndCellsResponse, ApiConnectionActionConfiguration> EditDocumentXlsxGetRowsAndCells(Expression<Func<EditDocumentXlsxGetColumnsInputInput>> input)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            return new DeferredBodyAction<GetXlsxRowsAndCellsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/xlsx/get-rows-and-cells";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_input);
                return new ApiConnectionAction<GetXlsxRowsAndCellsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<GetXlsxStylesResponse, ApiConnectionActionConfiguration> EditDocumentXlsxGetStyles(Expression<Func<EditDocumentXlsxGetStylesInputInput>> input)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            return new DeferredBodyAction<GetXlsxStylesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/xlsx/get-styles";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_input);
                return new ApiConnectionAction<GetXlsxStylesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<GetXlsxWorksheetsResponse, ApiConnectionActionConfiguration> EditDocumentXlsxGetWorksheets(Expression<Func<EditDocumentXlsxGetStylesInputInput>> input)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            return new DeferredBodyAction<GetXlsxWorksheetsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/xlsx/get-worksheets";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_input);
                return new ApiConnectionAction<GetXlsxWorksheetsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<InsertXlsxWorksheetResponse, ApiConnectionActionConfiguration> EditDocumentXlsxInsertWorksheet(Expression<Func<EditDocumentXlsxInsertWorksheetInputInput>> input)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            return new DeferredBodyAction<InsertXlsxWorksheetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/xlsx/insert-worksheet";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_input);
                return new ApiConnectionAction<InsertXlsxWorksheetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<SetXlsxCellByIdentifierResponse, ApiConnectionActionConfiguration> EditDocumentXlsxSetCellByIdentifier(Expression<Func<EditDocumentXlsxSetCellByIdentifierInputInput>> input)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            return new DeferredBodyAction<SetXlsxCellByIdentifierResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/xlsx/set-cell/by-identifier";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_input);
                return new ApiConnectionAction<SetXlsxCellByIdentifierResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<SetXlsxCellResponse, ApiConnectionActionConfiguration> EditDocumentXlsxSetCellByIndex(Expression<Func<EditDocumentXlsxSetCellByIndexInputInput>> input)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            return new DeferredBodyAction<SetXlsxCellResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/xlsx/set-cell/by-index";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_input);
                return new ApiConnectionAction<SetXlsxCellResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ConvertWebHtmlToDocx(Expression<Func<InputRequestInput>> inputRequest)
        {
            var __workflow_inputRequest = WorkflowExpression.Compile(inputRequest, nameof(inputRequest), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/html/to/docx";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_inputRequest);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ConvertDataJsonToXml(Expression<Func<object>> jsonObject)
        {
            var __workflow_jsonObject = WorkflowExpression.Compile(jsonObject, nameof(jsonObject), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/json/to/xml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jsonObject);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<HtmlTemplateApplicationResponse, ApiConnectionActionConfiguration> ConvertTemplateApplyHtmlTemplate(Expression<Func<ValueInput>> value)
        {
            var __workflow_value = WorkflowExpression.Compile(value, nameof(value), required: true);
            return new DeferredBodyAction<HtmlTemplateApplicationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/template/html/apply";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_value);
                return new ApiConnectionAction<HtmlTemplateApplicationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ConvertWebHtmlToPdf(Expression<Func<ConvertWebHtmlToPdfInputInput>> input)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/web/html/to/pdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_input);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> ConvertWebHtmlToPng(Expression<Func<ConvertWebHtmlToPngInputInput>> input)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/web/html/to/png";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_input);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<HtmlToTextResponse, ApiConnectionActionConfiguration> ConvertWebHtmlToTxt(Expression<Func<ConvertWebHtmlToTxtInputInput>> input)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            return new DeferredBodyAction<HtmlToTextResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/web/html/to/txt";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_input);
                return new ApiConnectionAction<HtmlToTextResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ConvertWebUrlToPdf(Expression<Func<ConvertWebUrlToPdfInputInput>> input)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/web/url/to/pdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_input);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ConvertWebUrlToScreenshot(Expression<Func<ConvertWebUrlToPdfInputInput>> input)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/web/url/to/screenshot";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_input);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<UrlToTextResponse, ApiConnectionActionConfiguration> ConvertWebUrlToTxt(Expression<Func<ConvertWebUrlToTxtInputInput>> input)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            return new DeferredBodyAction<UrlToTextResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/web/url/to/txt";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_input);
                return new ApiConnectionAction<UrlToTextResponse>(callPayload);
            });
        }
    }

    public class CloudmersiveconvertTriggers([ConnectionName] string connectionId)
    {
    }

    public class CreateBlankDocxResponse
    {
        public string EditedDocumentURL { get; set; }
        public bool Successful { get; set; }
    }

    public class EditDocumentDocxCreateBlankDocumentInputInput
    {
        public string InitialText { get; set; }
    }

    public class EditDocumentDocxDeletePagesReqConfigInput
    {
        public int? EndDeletePageNumber { get; set; }
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent InputFileBytes { get; set; }
        public string InputFileUrl { get; set; }
        public int? StartDeletePageNumber { get; set; }
    }

    public class DeleteDocxTableRowResponse
    {
        public string EditedDocumentURL { get; set; }
        public bool Successful { get; set; }
    }

    public class EditDocumentDocxDeleteTableRowReqConfigInput
    {
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent InputFileBytes { get; set; }
        public string InputFileUrl { get; set; }
        public string TablePath { get; set; }
        public int? TableRowRowIndex { get; set; }
    }

    public class DeleteDocxTableRowRangeResponse
    {
        public string EditedDocumentURL { get; set; }
        public bool Successful { get; set; }
    }

    public class EditDocumentDocxDeleteTableRowRangeReqConfigInput
    {
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent InputFileBytes { get; set; }
        public string InputFileUrl { get; set; }
        public string TablePath { get; set; }
        public int? TableRowRowIndexEnd { get; set; }
        public int? TableRowRowIndexStart { get; set; }
    }

    public class GetDocxBodyResponse
    {
        public DocxBody Body { get; set; }
        public bool Successful { get; set; }
    }

    public class DocxBody
    {
        public EditDocumentDocxBodyDocxParagraphResponse[] AllParagraphs { get; set; }
        public EditDocumentDocxBodyDocxTableResponse[] AllTables { get; set; }
        public string Path { get; set; }
    }

    public class EditDocumentDocxBodyDocxParagraphResponse
    {
        public EditDocumentDocxBodyDocxRunResponse[] ContentRuns { get; set; }
        public int ParagraphIndex { get; set; }
        public string Path { get; set; }

        [JsonProperty("StyleID")]
        public string StyleId { get; set; }
    }

    public class EditDocumentDocxBodyDocxRunResponse
    {
        public bool Bold { get; set; }
        public string FontFamily { get; set; }
        public string FontSize { get; set; }
        public bool Italic { get; set; }
        public string Path { get; set; }
        public int RunIndex { get; set; }
        public EditDocumentDocxBodyDocxTextResponse[] TextItems { get; set; }
        public string Underline { get; set; }
    }

    public class EditDocumentDocxBodyDocxTextResponse
    {
        public string Path { get; set; }
        public string TextContent { get; set; }
        public int TextIndex { get; set; }
    }

    public class EditDocumentDocxBodyDocxTableResponse
    {
        public string BottomBorderColor { get; set; }
        public int BottomBorderSize { get; set; }
        public int BottomBorderSpace { get; set; }
        public string BottomBorderType { get; set; }
        public string CellHorizontalBorderColor { get; set; }
        public int CellHorizontalBorderSize { get; set; }
        public int CellHorizontalBorderSpace { get; set; }
        public string CellHorizontalBorderType { get; set; }
        public string CellVerticalBorderColor { get; set; }
        public int CellVerticalBorderSize { get; set; }
        public int CellVerticalBorderSpace { get; set; }
        public string CellVerticalBorderType { get; set; }
        public string EndBorderColor { get; set; }
        public int EndBorderSize { get; set; }
        public int EndBorderSpace { get; set; }
        public string EndBorderType { get; set; }
        public string LeftBorderColor { get; set; }
        public int LeftBorderSize { get; set; }
        public int LeftBorderSpace { get; set; }
        public string LeftBorderType { get; set; }
        public string Path { get; set; }
        public string RightBorderColor { get; set; }
        public int RightBorderSize { get; set; }
        public int RightBorderSpace { get; set; }
        public string RightBorderType { get; set; }
        public string StartBorderColor { get; set; }
        public int StartBorderSize { get; set; }
        public int StartBorderSpace { get; set; }
        public string StartBorderType { get; set; }

        [JsonProperty("TableID")]
        public string TableId { get; set; }
        public string TableIndentationMode { get; set; }
        public int TableIndentationWidth { get; set; }
        public EditDocumentDocxBodyDocxTableRowResponse[] TableRows { get; set; }
        public string TopBorderColor { get; set; }
        public int TopBorderSize { get; set; }
        public int TopBorderSpace { get; set; }
        public string TopBorderType { get; set; }
        public string Width { get; set; }
        public string WidthType { get; set; }
    }

    public class EditDocumentDocxBodyDocxTableRowResponse
    {
        public string Path { get; set; }
        public EditDocumentDocxBodyDocxTableCellResponse[] RowCells { get; set; }
        public int RowIndex { get; set; }
    }

    public class EditDocumentDocxBodyDocxTableCellResponse
    {
        public int CellIndex { get; set; }
        public string CellShadingColor { get; set; }
        public string CellShadingFill { get; set; }
        public string CellShadingPattern { get; set; }
        public string CellWidth { get; set; }
        public string CellWidthMode { get; set; }
        public EditDocumentDocxBodyDocxParagraphResponse[] Paragraphs { get; set; }
        public string Path { get; set; }
    }

    public class EditDocumentDocxBodyReqConfigInput
    {
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent InputFileBytes { get; set; }
        public string InputFileUrl { get; set; }
    }

    public class GetDocxCommentsHierarchicalResponse
    {
        public DocxTopLevelComment[] Comments { get; set; }
        public bool Successful { get; set; }
        public int TopLevelCommentCount { get; set; }
    }

    public class DocxTopLevelComment
    {
        public string Author { get; set; }
        public string AuthorInitials { get; set; }
        public string CommentDate { get; set; }
        public string CommentText { get; set; }
        public bool Done { get; set; }
        public string Path { get; set; }
        public EditDocumentDocxGetCommentsHierarchicalDocxCommentResponse[] ReplyChildComments { get; set; }
    }

    public class EditDocumentDocxGetCommentsHierarchicalDocxCommentResponse
    {
        public string Author { get; set; }
        public string AuthorInitials { get; set; }
        public string CommentDate { get; set; }
        public string CommentText { get; set; }
        public bool Done { get; set; }
        public bool IsReply { get; set; }
        public bool IsTopLevel { get; set; }
        public string ParentCommentPath { get; set; }
        public string Path { get; set; }
    }

    public class GetDocxHeadersAndFootersResponse
    {
        public EditDocumentDocxGetHeadersAndFootersDocxFooterResponse[] Footers { get; set; }
        public EditDocumentDocxGetHeadersAndFootersDocxHeaderResponse[] Headers { get; set; }
        public bool Successful { get; set; }
    }

    public class EditDocumentDocxGetHeadersAndFootersDocxFooterResponse
    {
        public EditDocumentDocxBodyDocxParagraphResponse[] Paragraphs { get; set; }
        public string Path { get; set; }
        public EditDocumentDocxGetHeadersAndFootersDocxSectionResponse[] SectionsWithFooter { get; set; }
    }

    public class EditDocumentDocxGetHeadersAndFootersDocxSectionResponse
    {
        public string Path { get; set; }
        public int[] StartingPageNumbers { get; set; }
    }

    public class EditDocumentDocxGetHeadersAndFootersDocxHeaderResponse
    {
        public EditDocumentDocxBodyDocxParagraphResponse[] Paragraphs { get; set; }
        public string Path { get; set; }
        public EditDocumentDocxGetHeadersAndFootersDocxSectionResponse[] SectionsWithHeader { get; set; }
    }

    public class GetDocxImagesResponse
    {
        public EditDocumentDocxGetImagesDocxImageResponse[] Images { get; set; }
        public bool Successful { get; set; }
    }

    public class EditDocumentDocxGetImagesDocxImageResponse
    {
        public string ImageContentsURL { get; set; }
        public string ImageDataContentType { get; set; }
        public string ImageDataEmbedId { get; set; }
        public string ImageDescription { get; set; }
        public int ImageHeight { get; set; }
        public int ImageId { get; set; }
        public string ImageInternalFileName { get; set; }
        public string ImageName { get; set; }
        public int ImageWidth { get; set; }
        public bool InlineWithText { get; set; }
        public string Path { get; set; }
        public int XOffset { get; set; }
        public int YOffset { get; set; }
    }

    public class GetDocxPagesResponse
    {
        public int PageCount { get; set; }
        public DocxPage[] Pages { get; set; }
        public bool Successful { get; set; }
    }

    public class DocxPage
    {
        public int PageNumber { get; set; }
        public EditDocumentDocxBodyDocxParagraphResponse[] Paragraphs { get; set; }
    }

    public class GetDocxSectionsResponse
    {
        public EditDocumentDocxGetHeadersAndFootersDocxSectionResponse[] Sections { get; set; }
        public bool Successful { get; set; }
    }

    public class GetDocxStylesResponse
    {
        public DocxStyle[] Styles { get; set; }
        public bool Successful { get; set; }
    }

    public class DocxStyle
    {
        public bool Bold { get; set; }
        public string FontFamily { get; set; }
        public string FontSize { get; set; }
        public bool Italic { get; set; }
        public string Path { get; set; }

        [JsonProperty("StyleID")]
        public string StyleId { get; set; }
        public bool Underline { get; set; }
    }

    public class GetDocxTableRowResponse
    {
        public EditDocumentDocxBodyDocxTableRowResponse RowResult { get; set; }
        public bool Successful { get; set; }
    }

    public class GetDocxTableByIndexResponse
    {
        public bool Successful { get; set; }
        public EditDocumentDocxBodyDocxTableResponse Table { get; set; }
    }

    public class EditDocumentDocxGetTableByIndexReqConfigInput
    {
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent InputFileBytes { get; set; }
        public string InputFileUrl { get; set; }
        public int? TableIndex { get; set; }
    }

    public class GetDocxTablesResponse
    {
        public bool Successful { get; set; }
        public EditDocumentDocxBodyDocxTableResponse[] Tables { get; set; }
    }

    public class InsertDocxCommentOnParagraphResponse
    {
        public string EditedDocumentURL { get; set; }
        public bool Successful { get; set; }
    }

    public class EditDocumentDocxInsertCommentOnParagraphReqConfigInput
    {
        public EditDocumentDocxInsertCommentOnParagraphDocxComment CommentToInsert { get; set; }
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent InputFileBytes { get; set; }
        public string InputFileUrl { get; set; }
        public string ParagraphPath { get; set; }
    }

    public class EditDocumentDocxInsertCommentOnParagraphDocxComment
    {
        public string Author { get; set; }
        public string AuthorInitials { get; set; }
        public string CommentDate { get; set; }
        public string CommentText { get; set; }
        public bool? Done { get; set; }
        public bool? IsReply { get; set; }
        public bool? IsTopLevel { get; set; }
        public string ParentCommentPath { get; set; }
        public string Path { get; set; }
    }

    public class DocxInsertImageResponse
    {
        public string EditedDocumentURL { get; set; }
        public bool Successful { get; set; }
    }

    public class EditDocumentDocxInsertImageReqConfigInput
    {
        public int? HeightInEMUs { get; set; }
        public EditDocumentDocxInsertImageDocxImage ImageToAdd { get; set; }
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent InputDocumentFileBytes { get; set; }
        public string InputDocumentFileUrl { get; set; }
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent InputImageFileBytes { get; set; }
        public string InputImageFileUrl { get; set; }
        public string InsertPath { get; set; }
        public string InsertPlacement { get; set; }
        public int? WidthInEMUs { get; set; }
    }

    public class EditDocumentDocxInsertImageDocxImage
    {
        public string ImageContentsURL { get; set; }
        public string ImageDataContentType { get; set; }
        public string ImageDataEmbedId { get; set; }
        public string ImageDescription { get; set; }
        public int? ImageHeight { get; set; }
        public int? ImageId { get; set; }
        public string ImageInternalFileName { get; set; }
        public string ImageName { get; set; }
        public int? ImageWidth { get; set; }
        public bool? InlineWithText { get; set; }
        public string Path { get; set; }
        public int? XOffset { get; set; }
        public int? YOffset { get; set; }
    }

    public class InsertDocxInsertParagraphResponse
    {
        public string EditedDocumentURL { get; set; }
        public bool Successful { get; set; }
    }

    public class EditDocumentDocxInsertParagraphReqConfigInput
    {
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent InputFileBytes { get; set; }
        public string InputFileUrl { get; set; }
        public string InsertPath { get; set; }
        public string InsertPlacement { get; set; }
        public EditDocumentDocxInsertParagraphDocxParagraph ParagraphToInsert { get; set; }
    }

    public class EditDocumentDocxInsertParagraphDocxParagraph
    {
        public EditDocumentDocxInsertParagraphDocxRun[] ContentRuns { get; set; }
        public int? ParagraphIndex { get; set; }
        public string Path { get; set; }

        [JsonProperty("StyleID")]
        public string StyleId { get; set; }
    }

    public class EditDocumentDocxInsertParagraphDocxRun
    {
        public bool? Bold { get; set; }
        public string FontFamily { get; set; }
        public string FontSize { get; set; }
        public bool? Italic { get; set; }
        public string Path { get; set; }
        public int? RunIndex { get; set; }
        public EditDocumentDocxInsertParagraphDocxText[] TextItems { get; set; }
        public string Underline { get; set; }
    }

    public class EditDocumentDocxInsertParagraphDocxText
    {
        public string Path { get; set; }
        public string TextContent { get; set; }
        public int? TextIndex { get; set; }
    }

    public class InsertDocxTablesResponse
    {
        public string EditedDocumentURL { get; set; }
        public bool Successful { get; set; }
    }

    public class EditDocumentDocxInsertTableReqConfigInput
    {
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent InputFileBytes { get; set; }
        public string InputFileUrl { get; set; }
        public string InsertPath { get; set; }
        public string InsertPlacement { get; set; }
        public EditDocumentDocxInsertTableDocxTable TableToInsert { get; set; }
    }

    public class EditDocumentDocxInsertTableDocxTable
    {
        public string BottomBorderColor { get; set; }
        public int? BottomBorderSize { get; set; }
        public int? BottomBorderSpace { get; set; }
        public string BottomBorderType { get; set; }
        public string CellHorizontalBorderColor { get; set; }
        public int? CellHorizontalBorderSize { get; set; }
        public int? CellHorizontalBorderSpace { get; set; }
        public string CellHorizontalBorderType { get; set; }
        public string CellVerticalBorderColor { get; set; }
        public int? CellVerticalBorderSize { get; set; }
        public int? CellVerticalBorderSpace { get; set; }
        public string CellVerticalBorderType { get; set; }
        public string EndBorderColor { get; set; }
        public int? EndBorderSize { get; set; }
        public int? EndBorderSpace { get; set; }
        public string EndBorderType { get; set; }
        public string LeftBorderColor { get; set; }
        public int? LeftBorderSize { get; set; }
        public int? LeftBorderSpace { get; set; }
        public string LeftBorderType { get; set; }
        public string Path { get; set; }
        public string RightBorderColor { get; set; }
        public int? RightBorderSize { get; set; }
        public int? RightBorderSpace { get; set; }
        public string RightBorderType { get; set; }
        public string StartBorderColor { get; set; }
        public int? StartBorderSize { get; set; }
        public int? StartBorderSpace { get; set; }
        public string StartBorderType { get; set; }

        [JsonProperty("TableID")]
        public string TableId { get; set; }
        public string TableIndentationMode { get; set; }
        public int? TableIndentationWidth { get; set; }
        public EditDocumentDocxInsertTableDocxTableRow[] TableRows { get; set; }
        public string TopBorderColor { get; set; }
        public int? TopBorderSize { get; set; }
        public int? TopBorderSpace { get; set; }
        public string TopBorderType { get; set; }
        public string Width { get; set; }
        public string WidthType { get; set; }
    }

    public class EditDocumentDocxInsertTableDocxTableRow
    {
        public string Path { get; set; }
        public EditDocumentDocxInsertTableDocxTableCell[] RowCells { get; set; }
        public int? RowIndex { get; set; }
    }

    public class EditDocumentDocxInsertTableDocxTableCell
    {
        public int? CellIndex { get; set; }
        public string CellShadingColor { get; set; }
        public string CellShadingFill { get; set; }
        public string CellShadingPattern { get; set; }
        public string CellWidth { get; set; }
        public string CellWidthMode { get; set; }
        public EditDocumentDocxInsertParagraphDocxParagraph[] Paragraphs { get; set; }
        public string Path { get; set; }
    }

    public class InsertDocxTableRowResponse
    {
        public string EditedDocumentURL { get; set; }
        public bool Successful { get; set; }
    }

    public class EditDocumentDocxInsertTableRowReqConfigInput
    {
        public string ExistingTablePath { get; set; }
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent InputFileBytes { get; set; }
        public string InputFileUrl { get; set; }
        public string InsertPlacement { get; set; }
        public EditDocumentDocxInsertTableDocxTableRow RowToInsert { get; set; }
    }

    public class RemoveDocxHeadersAndFootersResponse
    {
        public string EditedDocumentURL { get; set; }
        public bool Successful { get; set; }
    }

    public class EditDocumentDocxRemoveHeadersAndFootersReqConfigInput
    {
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent InputFileBytes { get; set; }
        public string InputFileUrl { get; set; }
        public bool? RemoveFooters { get; set; }
        public bool? RemoveHeaders { get; set; }
    }

    public class DocxRemoveObjectResponse
    {
        public string EditedDocumentURL { get; set; }
        public bool Successful { get; set; }
    }

    public class EditDocumentDocxRemoveObjectReqConfigInput
    {
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent InputFileBytes { get; set; }
        public string InputFileUrl { get; set; }
        public string PathToObjectToRemove { get; set; }
    }

    public class EditDocumentDocxReplaceReqConfigInput
    {
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent InputFileBytes { get; set; }
        public string InputFileUrl { get; set; }
        public bool? MatchCase { get; set; }
        public string MatchString { get; set; }
        public string ReplaceString { get; set; }
    }

    public class DocxSetFooterResponse
    {
        public string EditedDocumentURL { get; set; }
        public bool Successful { get; set; }
    }

    public class EditDocumentDocxSetFooterReqConfigInput
    {
        public EditDocumentDocxSetFooterDocxFooter FooterToApply { get; set; }
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent InputFileBytes { get; set; }
        public string InputFileUrl { get; set; }
    }

    public class EditDocumentDocxSetFooterDocxFooter
    {
        public EditDocumentDocxInsertParagraphDocxParagraph[] Paragraphs { get; set; }
        public string Path { get; set; }
        public EditDocumentDocxSetFooterDocxSection[] SectionsWithFooter { get; set; }
    }

    public class EditDocumentDocxSetFooterDocxSection
    {
        public string Path { get; set; }
        public int[] StartingPageNumbers { get; set; }
    }

    public class EditDocumentDocxSetFooterAddPageNumberReqConfigInput
    {
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent InputFileBytes { get; set; }
        public string InputFileUrl { get; set; }
        public string PrependText { get; set; }
    }

    public class DocxSetHeaderResponse
    {
        public string EditedDocumentURL { get; set; }
        public bool Successful { get; set; }
    }

    public class EditDocumentDocxSetHeaderReqConfigInput
    {
        public EditDocumentDocxSetHeaderDocxHeader HeaderToApply { get; set; }
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent InputFileBytes { get; set; }
        public string InputFileUrl { get; set; }
    }

    public class EditDocumentDocxSetHeaderDocxHeader
    {
        public EditDocumentDocxInsertParagraphDocxParagraph[] Paragraphs { get; set; }
        public string Path { get; set; }
        public EditDocumentDocxSetFooterDocxSection[] SectionsWithHeader { get; set; }
    }

    public class UpdateDocxTableCellResponse
    {
        public string EditedDocumentURL { get; set; }
        public bool Successful { get; set; }
    }

    public class EditDocumentDocxUpdateTableCellReqConfigInput
    {
        public EditDocumentDocxInsertTableDocxTableCell CellToUpdate { get; set; }
        public string ExistingTablePath { get; set; }
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent InputFileBytes { get; set; }
        public string InputFileUrl { get; set; }
        public int? TableCellIndex { get; set; }
        public int? TableRowIndex { get; set; }
    }

    public class UpdateDocxTableRowResponse
    {
        public string EditedDocumentURL { get; set; }
        public bool Successful { get; set; }
    }

    public class EditDocumentDocxUpdateTableRowReqConfigInput
    {
        public string ExistingTablePath { get; set; }
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent InputFileBytes { get; set; }
        public string InputFileUrl { get; set; }
        public EditDocumentDocxInsertTableDocxTableRow RowToUpdate { get; set; }
        public int? TableRowIndex { get; set; }
    }

    public class EditDocumentFinishEditingReqConfigInput
    {
        public string InputFileUrl { get; set; }
    }

    public class EditDocumentPptxDeleteSlidesReqConfigInput
    {
        public int? EndDeleteSlideNumber { get; set; }
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent InputFileBytes { get; set; }
        public string InputFileUrl { get; set; }
        public int? StartDeleteSlideNumber { get; set; }
    }

    public class ClearXlsxCellResponse
    {
        public string EditedDocumentURL { get; set; }
        public bool Successful { get; set; }
    }

    public class EditDocumentXlsxClearCellByIndexInputInput
    {
        public int? CellIndex { get; set; }
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent InputFileBytes { get; set; }
        public string InputFileUrl { get; set; }
        public int? RowIndex { get; set; }
        public EditDocumentXlsxClearCellByIndexXlsxWorksheet WorksheetToUpdate { get; set; }
    }

    public class EditDocumentXlsxClearCellByIndexXlsxWorksheet
    {
        public string Path { get; set; }
        public string WorksheetName { get; set; }
    }

    public class CreateBlankSpreadsheetResponse
    {
        public string EditedDocumentURL { get; set; }
        public bool Successful { get; set; }
    }

    public class EditDocumentXlsxCreateBlankSpreadsheetInputInput
    {
        public string WorksheetName { get; set; }
    }

    public class CreateSpreadsheetFromDataResponse
    {
        public string EditedDocumentURL { get; set; }
        public bool Successful { get; set; }
    }

    public class EditDocumentXlsxCreateSpreadsheetFromDataInputInput
    {
        public EditDocumentXlsxCreateSpreadsheetFromDataXlsxSpreadsheetRow[] Rows { get; set; }
        public string WorksheetName { get; set; }
    }

    public class EditDocumentXlsxCreateSpreadsheetFromDataXlsxSpreadsheetRow
    {
        public EditDocumentXlsxCreateSpreadsheetFromDataXlsxSpreadsheetCell[] Cells { get; set; }
        public string Path { get; set; }
    }

    public class EditDocumentXlsxCreateSpreadsheetFromDataXlsxSpreadsheetCell
    {
        public string CellIdentifier { get; set; }
        public string Formula { get; set; }
        public string Path { get; set; }
        public int? StyleIndex { get; set; }
        public string TextValue { get; set; }
    }

    public class EditDocumentXlsxDeleteWorksheetReqConfigInput
    {
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent InputFileBytes { get; set; }
        public string InputFileUrl { get; set; }
        public EditDocumentXlsxClearCellByIndexXlsxWorksheet WorksheetToRemove { get; set; }
    }

    public class GetXlsxCellByIdentifierResponse
    {
        public EditDocumentXlsxGetCellByIdentifierXlsxSpreadsheetCellResponse Cell { get; set; }
        public bool Successful { get; set; }
    }

    public class EditDocumentXlsxGetCellByIdentifierXlsxSpreadsheetCellResponse
    {
        public string CellIdentifier { get; set; }
        public string Formula { get; set; }
        public string Path { get; set; }
        public int StyleIndex { get; set; }
        public string TextValue { get; set; }
    }

    public class EditDocumentXlsxGetCellByIdentifierInputInput
    {
        public string CellIdentifier { get; set; }
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent InputFileBytes { get; set; }
        public string InputFileUrl { get; set; }
        public EditDocumentXlsxClearCellByIndexXlsxWorksheet WorksheetToQuery { get; set; }
    }

    public class GetXlsxCellResponse
    {
        public EditDocumentXlsxGetCellByIdentifierXlsxSpreadsheetCellResponse Cell { get; set; }
        public bool Successful { get; set; }
    }

    public class EditDocumentXlsxGetCellByIndexInputInput
    {
        public int? CellIndex { get; set; }
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent InputFileBytes { get; set; }
        public string InputFileUrl { get; set; }
        public int? RowIndex { get; set; }
        public EditDocumentXlsxClearCellByIndexXlsxWorksheet WorksheetToQuery { get; set; }
    }

    public class GetXlsxColumnsResponse
    {
        public XlsxSpreadsheetColumn[] Columns { get; set; }
        public bool Successful { get; set; }
    }

    public class XlsxSpreadsheetColumn
    {
        public EditDocumentXlsxGetCellByIdentifierXlsxSpreadsheetCellResponse HeadingCell { get; set; }
        public string Path { get; set; }
    }

    public class EditDocumentXlsxGetColumnsInputInput
    {
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent InputFileBytes { get; set; }
        public string InputFileUrl { get; set; }
        public EditDocumentXlsxClearCellByIndexXlsxWorksheet WorksheetToQuery { get; set; }
    }

    public class GetXlsxImagesResponse
    {
        public XlsxImage[] Images { get; set; }
        public bool Successful { get; set; }
    }

    public class XlsxImage
    {
        public string ImageContentsURL { get; set; }
        public string ImageDataContentType { get; set; }
        public string ImageDataEmbedId { get; set; }
        public string ImageInternalFileName { get; set; }
        public string Path { get; set; }
    }

    public class GetXlsxRowsAndCellsResponse
    {
        public EditDocumentXlsxGetRowsAndCellsXlsxSpreadsheetRowResponse[] Rows { get; set; }
        public bool Successful { get; set; }
    }

    public class EditDocumentXlsxGetRowsAndCellsXlsxSpreadsheetRowResponse
    {
        public EditDocumentXlsxGetCellByIdentifierXlsxSpreadsheetCellResponse[] Cells { get; set; }
        public string Path { get; set; }
    }

    public class GetXlsxStylesResponse
    {
        public DocxCellStyle[] CellStyles { get; set; }
        public bool Successful { get; set; }
    }

    public class DocxCellStyle
    {
        [JsonProperty("BuiltInID")]
        public int BuiltInId { get; set; }

        [JsonProperty("FormatID")]
        public int FormatId { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
    }

    public class EditDocumentXlsxGetStylesInputInput
    {
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent InputFileBytes { get; set; }
        public string InputFileUrl { get; set; }
    }

    public class GetXlsxWorksheetsResponse
    {
        public bool Successful { get; set; }
        public EditDocumentXlsxGetWorksheetsXlsxWorksheetResponse[] Worksheets { get; set; }
    }

    public class EditDocumentXlsxGetWorksheetsXlsxWorksheetResponse
    {
        public string Path { get; set; }
        public string WorksheetName { get; set; }
    }

    public class InsertXlsxWorksheetResponse
    {
        public string EditedDocumentURL { get; set; }
        public bool Successful { get; set; }
    }

    public class EditDocumentXlsxInsertWorksheetInputInput
    {
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent InputFileBytes { get; set; }
        public string InputFileUrl { get; set; }
        public EditDocumentXlsxClearCellByIndexXlsxWorksheet WorksheetToInsert { get; set; }
    }

    public class SetXlsxCellByIdentifierResponse
    {
        public string EditedDocumentURL { get; set; }
        public bool Successful { get; set; }
    }

    public class EditDocumentXlsxSetCellByIdentifierInputInput
    {
        public string CellIdentifier { get; set; }
        public EditDocumentXlsxCreateSpreadsheetFromDataXlsxSpreadsheetCell CellValue { get; set; }
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent InputFileBytes { get; set; }
        public string InputFileUrl { get; set; }
        public EditDocumentXlsxClearCellByIndexXlsxWorksheet WorksheetToUpdate { get; set; }
    }

    public class SetXlsxCellResponse
    {
        public string EditedDocumentURL { get; set; }
        public bool Successful { get; set; }
    }

    public class EditDocumentXlsxSetCellByIndexInputInput
    {
        public int? CellIndex { get; set; }
        public EditDocumentXlsxCreateSpreadsheetFromDataXlsxSpreadsheetCell CellValue { get; set; }
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent InputFileBytes { get; set; }
        public string InputFileUrl { get; set; }
        public int? RowIndex { get; set; }
        public EditDocumentXlsxClearCellByIndexXlsxWorksheet WorksheetToUpdate { get; set; }
    }

    public class InputRequestInput
    {
        public string Html { get; set; }
    }

    public class HtmlTemplateApplicationResponse
    {
        public string FinalHtml { get; set; }
        public bool Successful { get; set; }
    }

    public class ValueInput
    {
        public string HtmlTemplate { get; set; }
        public string HtmlTemplateUrl { get; set; }
        public HtmlTemplateOperation[] Operations { get; set; }
    }

    public class HtmlTemplateOperation
    {
        public HtmlTemplateOperationActionType? Action { get; set; }
        public string MatchAgsint { get; set; }
        public string ReplaceWith { get; set; }
    }

    public enum HtmlTemplateOperationActionType
    {
        _1 = 1
    }

    public class ConvertWebHtmlToPdfInputInput
    {
        public int? ExtraLoadingWait { get; set; }
        public string Html { get; set; }
    }

    public class ConvertWebHtmlToPngInputInput
    {
        public int? ExtraLoadingWait { get; set; }
        public string Html { get; set; }
        public int? ScreenshotHeight { get; set; }
        public int? ScreenshotWidth { get; set; }
    }

    public class HtmlToTextResponse
    {
        public bool Successful { get; set; }
        public string TextContentResult { get; set; }
    }

    public class ConvertWebHtmlToTxtInputInput
    {
        public string Html { get; set; }
    }

    public class ConvertWebUrlToPdfInputInput
    {
        public int? ExtraLoadingWait { get; set; }
        public int? ScreenshotHeight { get; set; }
        public int? ScreenshotWidth { get; set; }
        public string Url { get; set; }
    }

    public class UrlToTextResponse
    {
        public bool Successful { get; set; }
        public string TextContentResult { get; set; }
    }

    public class ConvertWebUrlToTxtInputInput
    {
        public string Url { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Cloudmersiveconvert;

    public partial class WorkflowManagedActions
    {
        public CloudmersiveconvertActions Cloudmersiveconvert(string connectionId) => new CloudmersiveconvertActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CloudmersiveconvertTriggers Cloudmersiveconvert(string connectionId) => new CloudmersiveconvertTriggers(connectionId);
    }
}