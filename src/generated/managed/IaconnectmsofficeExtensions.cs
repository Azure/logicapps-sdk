//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectmsoffice
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IaconnectmsofficeActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordCreateInstanceResponse, ApiConnectionActionConfiguration> MSWordCreateInstance(Expression<Func<MsWordCreateInstanceInput>> msWordCreateInstance)
        {
            var __workflow_msWordCreateInstance = WorkflowExpression.Compile(msWordCreateInstance, nameof(msWordCreateInstance), required: true);
            return new DeferredBodyAction<MSWordCreateInstanceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSWord/CreateInstance";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msWordCreateInstance);
                return new ApiConnectionAction<MSWordCreateInstanceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSWordCloseInstance(Expression<Func<MsWordCloseInstanceInput>> msWordCloseInstance)
        {
            var __workflow_msWordCloseInstance = WorkflowExpression.Compile(msWordCloseInstance, nameof(msWordCloseInstance), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSWord/CloseInstance";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msWordCloseInstance);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSWordDetachFromInstance(Expression<Func<MsWordDetachFromInstanceInput>> msWordDetachFromInstance)
        {
            var __workflow_msWordDetachFromInstance = WorkflowExpression.Compile(msWordDetachFromInstance, nameof(msWordDetachFromInstance), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSWord/DetachFromInstance";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msWordDetachFromInstance);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordAttachToExistingInstanceResponse, ApiConnectionActionConfiguration> MSWordAttachToExistingInstance(Expression<Func<MsWordAttachToExistingInstanceInput>> msWordAttachToExistingInstance)
        {
            var __workflow_msWordAttachToExistingInstance = WorkflowExpression.Compile(msWordAttachToExistingInstance, nameof(msWordAttachToExistingInstance), required: true);
            return new DeferredBodyAction<MSWordAttachToExistingInstanceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSWord/AttachToExistingInstance";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msWordAttachToExistingInstance);
                return new ApiConnectionAction<MSWordAttachToExistingInstanceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSWordShowWord(Expression<Func<MsWordShowWordInput>> msWordShowWord)
        {
            var __workflow_msWordShowWord = WorkflowExpression.Compile(msWordShowWord, nameof(msWordShowWord), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSWord/ShowWord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msWordShowWord);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSWordHideWord(Expression<Func<MsWordHideWordInput>> msWordHideWord)
        {
            var __workflow_msWordHideWord = WorkflowExpression.Compile(msWordHideWord, nameof(msWordHideWord), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSWord/HideWord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msWordHideWord);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordCreateDocumentResponse, ApiConnectionActionConfiguration> MSWordCreateDocument(Expression<Func<MsWordCreateDocumentInput>> msWordCreateDocument)
        {
            var __workflow_msWordCreateDocument = WorkflowExpression.Compile(msWordCreateDocument, nameof(msWordCreateDocument), required: true);
            return new DeferredBodyAction<MSWordCreateDocumentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSWord/CreateDocument";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msWordCreateDocument);
                return new ApiConnectionAction<MSWordCreateDocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordOpenDocumentResponse, ApiConnectionActionConfiguration> MSWordOpenDocument(Expression<Func<MsWordOpenDocumentInput>> msWordOpenDocument)
        {
            var __workflow_msWordOpenDocument = WorkflowExpression.Compile(msWordOpenDocument, nameof(msWordOpenDocument), required: true);
            return new DeferredBodyAction<MSWordOpenDocumentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSWord/OpenDocument";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msWordOpenDocument);
                return new ApiConnectionAction<MSWordOpenDocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSWordSaveDocument(Expression<Func<MsWordSaveDocumentInput>> msWordSaveDocument)
        {
            var __workflow_msWordSaveDocument = WorkflowExpression.Compile(msWordSaveDocument, nameof(msWordSaveDocument), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSWord/Save";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msWordSaveDocument);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordSaveAsDocumentResponse, ApiConnectionActionConfiguration> MSWordSaveAsDocument(Expression<Func<MsWordSaveAsDocumentInput>> msWordSaveAsDocument)
        {
            var __workflow_msWordSaveAsDocument = WorkflowExpression.Compile(msWordSaveAsDocument, nameof(msWordSaveAsDocument), required: true);
            return new DeferredBodyAction<MSWordSaveAsDocumentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSWord/SaveAs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msWordSaveAsDocument);
                return new ApiConnectionAction<MSWordSaveAsDocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSWordCloseDocument(Expression<Func<MsWordCloseDocumentInput>> msWordCloseDocument)
        {
            var __workflow_msWordCloseDocument = WorkflowExpression.Compile(msWordCloseDocument, nameof(msWordCloseDocument), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSWord/CloseDocument";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msWordCloseDocument);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSWordTypeText(Expression<Func<MsWordTypeTextInput>> msWordTypeText)
        {
            var __workflow_msWordTypeText = WorkflowExpression.Compile(msWordTypeText, nameof(msWordTypeText), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSWord/TypeText";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msWordTypeText);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSWordSelectAll(Expression<Func<MsWordSelectAllInput>> msWordSelectAll)
        {
            var __workflow_msWordSelectAll = WorkflowExpression.Compile(msWordSelectAll, nameof(msWordSelectAll), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSWord/SelectAll";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msWordSelectAll);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSWordSelectRange(Expression<Func<MsWordSelectRangeInput>> msWordSelectRange)
        {
            var __workflow_msWordSelectRange = WorkflowExpression.Compile(msWordSelectRange, nameof(msWordSelectRange), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSWord/SelectRange";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msWordSelectRange);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSWordCopyToClipboard(Expression<Func<MsWordCopyToClipboardInput>> msWordCopyToClipboard)
        {
            var __workflow_msWordCopyToClipboard = WorkflowExpression.Compile(msWordCopyToClipboard, nameof(msWordCopyToClipboard), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSWord/CopyToClipboard";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msWordCopyToClipboard);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSWordPasteFromClipboard(Expression<Func<MsWordPasteFromClipboardInput>> msWordPasteFromClipboard)
        {
            var __workflow_msWordPasteFromClipboard = WorkflowExpression.Compile(msWordPasteFromClipboard, nameof(msWordPasteFromClipboard), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSWord/PasteFromClipboard";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msWordPasteFromClipboard);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSWordClearClipboard(Expression<Func<MsWordClearClipboardInput>> msWordClearClipboard)
        {
            var __workflow_msWordClearClipboard = WorkflowExpression.Compile(msWordClearClipboard, nameof(msWordClearClipboard), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSWord/ClearClipboard";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msWordClearClipboard);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordGetDocumentBodyTextResponse, ApiConnectionActionConfiguration> MSWordGetDocumentBodyText(Expression<Func<MsWordGetDocumentBodyTextInput>> msWordGetDocumentBodyText)
        {
            var __workflow_msWordGetDocumentBodyText = WorkflowExpression.Compile(msWordGetDocumentBodyText, nameof(msWordGetDocumentBodyText), required: true);
            return new DeferredBodyAction<MSWordGetDocumentBodyTextResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSWord/GetDocumentBodyText";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msWordGetDocumentBodyText);
                return new ApiConnectionAction<MSWordGetDocumentBodyTextResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordGetNumberOfTablesInDocumentResponse, ApiConnectionActionConfiguration> MSWordGetNumberOfTablesInDocument(Expression<Func<MsWordGetNumberOfTablesInDocumentInput>> msWordGetNumberOfTablesInDocument)
        {
            var __workflow_msWordGetNumberOfTablesInDocument = WorkflowExpression.Compile(msWordGetNumberOfTablesInDocument, nameof(msWordGetNumberOfTablesInDocument), required: true);
            return new DeferredBodyAction<MSWordGetNumberOfTablesInDocumentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSWord/GetNumberOfTablesInDocument";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msWordGetNumberOfTablesInDocument);
                return new ApiConnectionAction<MSWordGetNumberOfTablesInDocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSWordUpdateBookmark(Expression<Func<MsWordUpdateBookmarkInput>> msWordUpdateBookmark)
        {
            var __workflow_msWordUpdateBookmark = WorkflowExpression.Compile(msWordUpdateBookmark, nameof(msWordUpdateBookmark), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSWord/UpdateBookmark";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msWordUpdateBookmark);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSWordSelectTable(Expression<Func<MsWordSelectTableInput>> msWordSelectTable)
        {
            var __workflow_msWordSelectTable = WorkflowExpression.Compile(msWordSelectTable, nameof(msWordSelectTable), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSWord/SelectTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msWordSelectTable);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordGetTableBoundsResponse, ApiConnectionActionConfiguration> MSWordGetTableBounds(Expression<Func<MsWordGetTableBoundsInput>> msWordGetTableBounds)
        {
            var __workflow_msWordGetTableBounds = WorkflowExpression.Compile(msWordGetTableBounds, nameof(msWordGetTableBounds), required: true);
            return new DeferredBodyAction<MSWordGetTableBoundsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSWord/GetTableBounds";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msWordGetTableBounds);
                return new ApiConnectionAction<MSWordGetTableBoundsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSWordSelectTableCell(Expression<Func<MsWordSelectTableCellInput>> msWordSelectTableCell)
        {
            var __workflow_msWordSelectTableCell = WorkflowExpression.Compile(msWordSelectTableCell, nameof(msWordSelectTableCell), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSWord/SelectTableCell";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msWordSelectTableCell);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordGetTableCellTextValueResponse, ApiConnectionActionConfiguration> MSWordGetTableCellTextValue(Expression<Func<MsWordGetTableCellTextValueInput>> msWordGetTableCellTextValue)
        {
            var __workflow_msWordGetTableCellTextValue = WorkflowExpression.Compile(msWordGetTableCellTextValue, nameof(msWordGetTableCellTextValue), required: true);
            return new DeferredBodyAction<MSWordGetTableCellTextValueResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSWord/GetTableCellTextValue";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msWordGetTableCellTextValue);
                return new ApiConnectionAction<MSWordGetTableCellTextValueResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordGetTableCellTextValueTrimmedResponse, ApiConnectionActionConfiguration> MSWordGetTableCellTextValueTrimmed(Expression<Func<MsWordGetTableCellTextValueTrimmedInput>> msWordGetTableCellTextValueTrimmed)
        {
            var __workflow_msWordGetTableCellTextValueTrimmed = WorkflowExpression.Compile(msWordGetTableCellTextValueTrimmed, nameof(msWordGetTableCellTextValueTrimmed), required: true);
            return new DeferredBodyAction<MSWordGetTableCellTextValueTrimmedResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSWord/GetTableCellTextValueTrimmed";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msWordGetTableCellTextValueTrimmed);
                return new ApiConnectionAction<MSWordGetTableCellTextValueTrimmedResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSWordSetTableCellTextValue(Expression<Func<MsWordSetTableCellTextValueInput>> msWordSetTableCellTextValue)
        {
            var __workflow_msWordSetTableCellTextValue = WorkflowExpression.Compile(msWordSetTableCellTextValue, nameof(msWordSetTableCellTextValue), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSWord/SetTableCellTextValue";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msWordSetTableCellTextValue);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSWordExportDocumentAsPdf(Expression<Func<MsWordExportDocumentAsPdfInput>> msWordExportDocumentAsPdf)
        {
            var __workflow_msWordExportDocumentAsPdf = WorkflowExpression.Compile(msWordExportDocumentAsPdf, nameof(msWordExportDocumentAsPdf), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSWord/ExportDocumentAsPDF";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msWordExportDocumentAsPdf);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSWordAddTable(Expression<Func<MsWordAddTableInput>> msWordAddTable)
        {
            var __workflow_msWordAddTable = WorkflowExpression.Compile(msWordAddTable, nameof(msWordAddTable), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSWord/AddTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msWordAddTable);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSWordAddTableRow(Expression<Func<MsWordAddTableRowInput>> msWordAddTableRow)
        {
            var __workflow_msWordAddTableRow = WorkflowExpression.Compile(msWordAddTableRow, nameof(msWordAddTableRow), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSWord/AddTableRow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msWordAddTableRow);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSWordAddTableColumn(Expression<Func<MsWordAddTableColumnInput>> msWordAddTableColumn)
        {
            var __workflow_msWordAddTableColumn = WorkflowExpression.Compile(msWordAddTableColumn, nameof(msWordAddTableColumn), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSWord/AddTableColumn";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msWordAddTableColumn);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordGetHighlightedTextResponse, ApiConnectionActionConfiguration> MSWordGetHighlightedText(Expression<Func<MsWordGetHighlightedTextInput>> msWordGetHighlightedText)
        {
            var __workflow_msWordGetHighlightedText = WorkflowExpression.Compile(msWordGetHighlightedText, nameof(msWordGetHighlightedText), required: true);
            return new DeferredBodyAction<MSWordGetHighlightedTextResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSWord/GetHighlightedText";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msWordGetHighlightedText);
                return new ApiConnectionAction<MSWordGetHighlightedTextResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordExecuteCommandBarObjectResponse, ApiConnectionActionConfiguration> MSWordExecuteCommandBarObject(Expression<Func<MsWordExecuteCommandBarObjectInput>> msWordExecuteCommandBarObject)
        {
            var __workflow_msWordExecuteCommandBarObject = WorkflowExpression.Compile(msWordExecuteCommandBarObject, nameof(msWordExecuteCommandBarObject), required: true);
            return new DeferredBodyAction<MSWordExecuteCommandBarObjectResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSWord/ExecuteCommandBarObject";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msWordExecuteCommandBarObject);
                return new ApiConnectionAction<MSWordExecuteCommandBarObjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordSetDocumentSensitivityLabelResponse, ApiConnectionActionConfiguration> MSWordSetDocumentSensitivityLabel(Expression<Func<MsWordSetDocumentSensitivityLabelInput>> msWordSetDocumentSensitivityLabel)
        {
            var __workflow_msWordSetDocumentSensitivityLabel = WorkflowExpression.Compile(msWordSetDocumentSensitivityLabel, nameof(msWordSetDocumentSensitivityLabel), required: true);
            return new DeferredBodyAction<MSWordSetDocumentSensitivityLabelResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSWord/MSWordSetDocumentSensitivityLabel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msWordSetDocumentSensitivityLabel);
                return new ApiConnectionAction<MSWordSetDocumentSensitivityLabelResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordGetDocumentSensitivityLabelResponse, ApiConnectionActionConfiguration> MSWordGetDocumentSensitivityLabel(Expression<Func<MsWordGetDocumentSensitivityLabelInput>> msWordGetDocumentSensitivityLabel)
        {
            var __workflow_msWordGetDocumentSensitivityLabel = WorkflowExpression.Compile(msWordGetDocumentSensitivityLabel, nameof(msWordGetDocumentSensitivityLabel), required: true);
            return new DeferredBodyAction<MSWordGetDocumentSensitivityLabelResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSWord/MSWordGetDocumentSensitivityLabel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msWordGetDocumentSensitivityLabel);
                return new ApiConnectionAction<MSWordGetDocumentSensitivityLabelResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelCreateInstanceResponse, ApiConnectionActionConfiguration> MSExcelCreateInstance(Expression<Func<MsExcelCreateInstanceInput>> msExcelCreateInstance)
        {
            var __workflow_msExcelCreateInstance = WorkflowExpression.Compile(msExcelCreateInstance, nameof(msExcelCreateInstance), required: true);
            return new DeferredBodyAction<MSExcelCreateInstanceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/CreateInstance";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msExcelCreateInstance);
                return new ApiConnectionAction<MSExcelCreateInstanceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSExcelCloseInstance(Expression<Func<MsExcelCloseInstanceInput>> msExcelCloseInstance)
        {
            var __workflow_msExcelCloseInstance = WorkflowExpression.Compile(msExcelCloseInstance, nameof(msExcelCloseInstance), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/CloseInstance";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msExcelCloseInstance);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelAttachToExistingInstanceResponse, ApiConnectionActionConfiguration> MSExcelAttachToExistingInstance(Expression<Func<MsExcelAttachToExistingInstanceInput>> msExcelAttachToExistingInstance)
        {
            var __workflow_msExcelAttachToExistingInstance = WorkflowExpression.Compile(msExcelAttachToExistingInstance, nameof(msExcelAttachToExistingInstance), required: true);
            return new DeferredBodyAction<MSExcelAttachToExistingInstanceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/MSExcelAttachToExistingInstance";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msExcelAttachToExistingInstance);
                return new ApiConnectionAction<MSExcelAttachToExistingInstanceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSExcelShowExcel(Expression<Func<MsExcelShowExcelInput>> msExcelShowExcel)
        {
            var __workflow_msExcelShowExcel = WorkflowExpression.Compile(msExcelShowExcel, nameof(msExcelShowExcel), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/ShowExcel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msExcelShowExcel);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSExcelHideExcel(Expression<Func<MsExcelHideExcelInput>> msExcelHideExcel)
        {
            var __workflow_msExcelHideExcel = WorkflowExpression.Compile(msExcelHideExcel, nameof(msExcelHideExcel), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/HideExcel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msExcelHideExcel);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelOpenWorkbookResponse, ApiConnectionActionConfiguration> MSExcelOpenWorkbook(Expression<Func<MsExcelOpenWorkbookInput>> msExcelOpenWorkbook)
        {
            var __workflow_msExcelOpenWorkbook = WorkflowExpression.Compile(msExcelOpenWorkbook, nameof(msExcelOpenWorkbook), required: true);
            return new DeferredBodyAction<MSExcelOpenWorkbookResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/OpenWorkbook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msExcelOpenWorkbook);
                return new ApiConnectionAction<MSExcelOpenWorkbookResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelPutWorkbookInEditModeResponse, ApiConnectionActionConfiguration> MSExcelPutWorkbookInEditMode(Expression<Func<MsExcelPutWorkbookInEditModeInput>> msExcelPutWorkbookInEditMode)
        {
            var __workflow_msExcelPutWorkbookInEditMode = WorkflowExpression.Compile(msExcelPutWorkbookInEditMode, nameof(msExcelPutWorkbookInEditMode), required: true);
            return new DeferredBodyAction<MSExcelPutWorkbookInEditModeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/PutWorkbookInEditMode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msExcelPutWorkbookInEditMode);
                return new ApiConnectionAction<MSExcelPutWorkbookInEditModeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelCreateWorkbookResponse, ApiConnectionActionConfiguration> MSExcelCreateWorkbook(Expression<Func<MsExcelCreateWorkbookInput>> msExcelCreateWorkbook)
        {
            var __workflow_msExcelCreateWorkbook = WorkflowExpression.Compile(msExcelCreateWorkbook, nameof(msExcelCreateWorkbook), required: true);
            return new DeferredBodyAction<MSExcelCreateWorkbookResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/CreateWorkbook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msExcelCreateWorkbook);
                return new ApiConnectionAction<MSExcelCreateWorkbookResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSExcelCloseWorkbook(Expression<Func<MsExcelCloseWorkbookInput>> msExcelCloseWorkbook)
        {
            var __workflow_msExcelCloseWorkbook = WorkflowExpression.Compile(msExcelCloseWorkbook, nameof(msExcelCloseWorkbook), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/CloseWorkbook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msExcelCloseWorkbook);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSExcelCloseCurrentWorkbook(Expression<Func<MsExcelCloseCurrentWorkbookInput>> msExcelCloseCurrentWorkbook)
        {
            var __workflow_msExcelCloseCurrentWorkbook = WorkflowExpression.Compile(msExcelCloseCurrentWorkbook, nameof(msExcelCloseCurrentWorkbook), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/CloseCurrentWorkbook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msExcelCloseCurrentWorkbook);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSExcelGoToCell(Expression<Func<MsExcelGoToCellInput>> msExcelGoToCell)
        {
            var __workflow_msExcelGoToCell = WorkflowExpression.Compile(msExcelGoToCell, nameof(msExcelGoToCell), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/GoToCell";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msExcelGoToCell);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetCellValueResponse, ApiConnectionActionConfiguration> MSExcelGetCellValue(Expression<Func<MsExcelGetCellValueInput>> msExcelGetCellValue)
        {
            var __workflow_msExcelGetCellValue = WorkflowExpression.Compile(msExcelGetCellValue, nameof(msExcelGetCellValue), required: true);
            return new DeferredBodyAction<MSExcelGetCellValueResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/GetCellValue";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msExcelGetCellValue);
                return new ApiConnectionAction<MSExcelGetCellValueResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetCellValue2Response, ApiConnectionActionConfiguration> MSExcelGetCellValue2(Expression<Func<MsExcelGetCellValue2Input>> msExcelGetCellValue2)
        {
            var __workflow_msExcelGetCellValue2 = WorkflowExpression.Compile(msExcelGetCellValue2, nameof(msExcelGetCellValue2), required: true);
            return new DeferredBodyAction<MSExcelGetCellValue2Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/GetCellValue2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msExcelGetCellValue2);
                return new ApiConnectionAction<MSExcelGetCellValue2Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetCellTextResponse, ApiConnectionActionConfiguration> MSExcelGetCellText(Expression<Func<MsExcelGetCellTextInput>> msExcelGetCellText)
        {
            var __workflow_msExcelGetCellText = WorkflowExpression.Compile(msExcelGetCellText, nameof(msExcelGetCellText), required: true);
            return new DeferredBodyAction<MSExcelGetCellTextResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/GetCellText";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msExcelGetCellText);
                return new ApiConnectionAction<MSExcelGetCellTextResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSExcelSetCellValue(Expression<Func<MsExcelSetCellValueInput>> msExcelSetCellValue)
        {
            var __workflow_msExcelSetCellValue = WorkflowExpression.Compile(msExcelSetCellValue, nameof(msExcelSetCellValue), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/SetCellValue";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msExcelSetCellValue);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelFindNextCellWithValueResponse, ApiConnectionActionConfiguration> MSExcelFindNextCellWithValue(Expression<Func<MsExcelFindNextCellWithValueInput>> msExcelFindNextCellWithValue)
        {
            var __workflow_msExcelFindNextCellWithValue = WorkflowExpression.Compile(msExcelFindNextCellWithValue, nameof(msExcelFindNextCellWithValue), required: true);
            return new DeferredBodyAction<MSExcelFindNextCellWithValueResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/FindNextCellWithValue";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msExcelFindNextCellWithValue);
                return new ApiConnectionAction<MSExcelFindNextCellWithValueResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelFindNextEmptyCellResponse, ApiConnectionActionConfiguration> MSExcelFindNextEmptyCell(Expression<Func<MsExcelFindNextEmptyCellInput>> msExcelFindNextEmptyCell)
        {
            var __workflow_msExcelFindNextEmptyCell = WorkflowExpression.Compile(msExcelFindNextEmptyCell, nameof(msExcelFindNextEmptyCell), required: true);
            return new DeferredBodyAction<MSExcelFindNextEmptyCellResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/FindNextEmptyCell";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msExcelFindNextEmptyCell);
                return new ApiConnectionAction<MSExcelFindNextEmptyCellResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGotoNextEmptyCellLeftResponse, ApiConnectionActionConfiguration> MSExcelGotoNextEmptyCellLeft(Expression<Func<MsExcelGotoNextEmptyCellLeftInput>> msExcelGotoNextEmptyCellLeft)
        {
            var __workflow_msExcelGotoNextEmptyCellLeft = WorkflowExpression.Compile(msExcelGotoNextEmptyCellLeft, nameof(msExcelGotoNextEmptyCellLeft), required: true);
            return new DeferredBodyAction<MSExcelGotoNextEmptyCellLeftResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/GotoNextEmptyCellLeft";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msExcelGotoNextEmptyCellLeft);
                return new ApiConnectionAction<MSExcelGotoNextEmptyCellLeftResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGotoNextEmptyCellRightResponse, ApiConnectionActionConfiguration> MSExcelGotoNextEmptyCellRight(Expression<Func<MsExcelGotoNextEmptyCellRightInput>> msExcelGotoNextEmptyCellRight)
        {
            var __workflow_msExcelGotoNextEmptyCellRight = WorkflowExpression.Compile(msExcelGotoNextEmptyCellRight, nameof(msExcelGotoNextEmptyCellRight), required: true);
            return new DeferredBodyAction<MSExcelGotoNextEmptyCellRightResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/GotoNextEmptyCellRight";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msExcelGotoNextEmptyCellRight);
                return new ApiConnectionAction<MSExcelGotoNextEmptyCellRightResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGotoNextEmptyCellUpResponse, ApiConnectionActionConfiguration> MSExcelGotoNextEmptyCellUp(Expression<Func<MsExcelGotoNextEmptyCellUpInput>> msExcelGotoNextEmptyCellUp)
        {
            var __workflow_msExcelGotoNextEmptyCellUp = WorkflowExpression.Compile(msExcelGotoNextEmptyCellUp, nameof(msExcelGotoNextEmptyCellUp), required: true);
            return new DeferredBodyAction<MSExcelGotoNextEmptyCellUpResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/GotoNextEmptyCellUp";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msExcelGotoNextEmptyCellUp);
                return new ApiConnectionAction<MSExcelGotoNextEmptyCellUpResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGotoNextEmptyCellDownResponse, ApiConnectionActionConfiguration> MSExcelGotoNextEmptyCellDown(Expression<Func<MsExcelGotoNextEmptyCellDownInput>> msExcelGotoNextEmptyCellDown)
        {
            var __workflow_msExcelGotoNextEmptyCellDown = WorkflowExpression.Compile(msExcelGotoNextEmptyCellDown, nameof(msExcelGotoNextEmptyCellDown), required: true);
            return new DeferredBodyAction<MSExcelGotoNextEmptyCellDownResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/GotoNextEmptyCellDown";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msExcelGotoNextEmptyCellDown);
                return new ApiConnectionAction<MSExcelGotoNextEmptyCellDownResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelSaveWorkbookResponse, ApiConnectionActionConfiguration> MSExcelSaveWorkbook(Expression<Func<MsExcelSaveWorkbookInput>> msExcelSaveWorkbook)
        {
            var __workflow_msExcelSaveWorkbook = WorkflowExpression.Compile(msExcelSaveWorkbook, nameof(msExcelSaveWorkbook), required: true);
            return new DeferredBodyAction<MSExcelSaveWorkbookResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/SaveWorkbook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msExcelSaveWorkbook);
                return new ApiConnectionAction<MSExcelSaveWorkbookResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelSaveWorkbookAsResponse, ApiConnectionActionConfiguration> MSExcelSaveWorkbookAs(Expression<Func<MsExcelSaveWorkbookAsInput>> msExcelSaveWorkbookAs)
        {
            var __workflow_msExcelSaveWorkbookAs = WorkflowExpression.Compile(msExcelSaveWorkbookAs, nameof(msExcelSaveWorkbookAs), required: true);
            return new DeferredBodyAction<MSExcelSaveWorkbookAsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/SaveWorkbookAs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msExcelSaveWorkbookAs);
                return new ApiConnectionAction<MSExcelSaveWorkbookAsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelSaveWorkbookAsCsvResponse, ApiConnectionActionConfiguration> MSExcelSaveWorkbookAsCsv(Expression<Func<MsExcelSaveWorkbookAsCsvInput>> msExcelSaveWorkbookAsCsv)
        {
            var __workflow_msExcelSaveWorkbookAsCsv = WorkflowExpression.Compile(msExcelSaveWorkbookAsCsv, nameof(msExcelSaveWorkbookAsCsv), required: true);
            return new DeferredBodyAction<MSExcelSaveWorkbookAsCsvResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/SaveWorkbookAsCSV";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msExcelSaveWorkbookAsCsv);
                return new ApiConnectionAction<MSExcelSaveWorkbookAsCsvResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelSaveWorkbookAsWithPasswordResponse, ApiConnectionActionConfiguration> MSExcelSaveWorkbookAsWithPassword(Expression<Func<MsExcelSaveWorkbookAsWithPasswordInput>> msExcelSaveWorkbookAsWithPassword)
        {
            var __workflow_msExcelSaveWorkbookAsWithPassword = WorkflowExpression.Compile(msExcelSaveWorkbookAsWithPassword, nameof(msExcelSaveWorkbookAsWithPassword), required: true);
            return new DeferredBodyAction<MSExcelSaveWorkbookAsWithPasswordResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/SaveWorkbookAsWithPassword";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msExcelSaveWorkbookAsWithPassword);
                return new ApiConnectionAction<MSExcelSaveWorkbookAsWithPasswordResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelSaveCurrentWorkbookResponse, ApiConnectionActionConfiguration> MSExcelSaveCurrentWorkbook(Expression<Func<MsExcelSaveCurrentWorkbookInput>> msExcelSaveCurrentWorkbook)
        {
            var __workflow_msExcelSaveCurrentWorkbook = WorkflowExpression.Compile(msExcelSaveCurrentWorkbook, nameof(msExcelSaveCurrentWorkbook), required: true);
            return new DeferredBodyAction<MSExcelSaveCurrentWorkbookResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/SaveCurrentWorkbook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msExcelSaveCurrentWorkbook);
                return new ApiConnectionAction<MSExcelSaveCurrentWorkbookResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelSaveCurrentWorkbookAsResponse, ApiConnectionActionConfiguration> MSExcelSaveCurrentWorkbookAs(Expression<Func<MsExcelSaveCurrentWorkbookAsInput>> msExcelSaveCurrentWorkbookAs)
        {
            var __workflow_msExcelSaveCurrentWorkbookAs = WorkflowExpression.Compile(msExcelSaveCurrentWorkbookAs, nameof(msExcelSaveCurrentWorkbookAs), required: true);
            return new DeferredBodyAction<MSExcelSaveCurrentWorkbookAsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/SaveCurrentWorkbookAs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msExcelSaveCurrentWorkbookAs);
                return new ApiConnectionAction<MSExcelSaveCurrentWorkbookAsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelSaveCurrentWorkbookAsCsvResponse, ApiConnectionActionConfiguration> MSExcelSaveCurrentWorkbookAsCsv(Expression<Func<MsExcelSaveCurrentWorkbookAsCsvInput>> msExcelSaveCurrentWorkbookAsCsv)
        {
            var __workflow_msExcelSaveCurrentWorkbookAsCsv = WorkflowExpression.Compile(msExcelSaveCurrentWorkbookAsCsv, nameof(msExcelSaveCurrentWorkbookAsCsv), required: true);
            return new DeferredBodyAction<MSExcelSaveCurrentWorkbookAsCsvResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/SaveCurrentWorkbookAsCSV";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msExcelSaveCurrentWorkbookAsCsv);
                return new ApiConnectionAction<MSExcelSaveCurrentWorkbookAsCsvResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetWorksheetNamesResponse, ApiConnectionActionConfiguration> MSExcelGetWorksheetNames(Expression<Func<MsExcelGetWorksheetNamesInput>> msExcelGetWorksheetNames)
        {
            var __workflow_msExcelGetWorksheetNames = WorkflowExpression.Compile(msExcelGetWorksheetNames, nameof(msExcelGetWorksheetNames), required: true);
            return new DeferredBodyAction<MSExcelGetWorksheetNamesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/GetWorksheetNames";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msExcelGetWorksheetNames);
                return new ApiConnectionAction<MSExcelGetWorksheetNamesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetWorksheetNameResponse, ApiConnectionActionConfiguration> MSExcelGetWorksheetName(Expression<Func<MsExcelGetWorksheetNameInput>> msExcelGetWorksheetName)
        {
            var __workflow_msExcelGetWorksheetName = WorkflowExpression.Compile(msExcelGetWorksheetName, nameof(msExcelGetWorksheetName), required: true);
            return new DeferredBodyAction<MSExcelGetWorksheetNameResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/GetWorksheetName";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msExcelGetWorksheetName);
                return new ApiConnectionAction<MSExcelGetWorksheetNameResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSExcelActivateWorksheet(Expression<Func<MsExcelActivateWorksheetInput>> msExcelActivateWorksheet)
        {
            var __workflow_msExcelActivateWorksheet = WorkflowExpression.Compile(msExcelActivateWorksheet, nameof(msExcelActivateWorksheet), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/ActivateWorksheet";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msExcelActivateWorksheet);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSExcelCreateWorksheet(Expression<Func<MsExcelCreateWorksheetInput>> msExcelCreateWorksheet)
        {
            var __workflow_msExcelCreateWorksheet = WorkflowExpression.Compile(msExcelCreateWorksheet, nameof(msExcelCreateWorksheet), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/CreateWorksheet";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msExcelCreateWorksheet);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSExcelDeleteWorksheet(Expression<Func<MsExcelDeleteWorksheetInput>> msExcelDeleteWorksheet)
        {
            var __workflow_msExcelDeleteWorksheet = WorkflowExpression.Compile(msExcelDeleteWorksheet, nameof(msExcelDeleteWorksheet), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/DeleteWorksheet";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msExcelDeleteWorksheet);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetWorksheetAsCollectionEnhancedResponse, ApiConnectionActionConfiguration> MSExcelGetWorksheetAsCollectionEnhanced(Expression<Func<MsExcelGetWorksheetAsCollectionEnhancedInput>> msExcelGetWorksheetAsCollectionEnhanced)
        {
            var __workflow_msExcelGetWorksheetAsCollectionEnhanced = WorkflowExpression.Compile(msExcelGetWorksheetAsCollectionEnhanced, nameof(msExcelGetWorksheetAsCollectionEnhanced), required: true);
            return new DeferredBodyAction<MSExcelGetWorksheetAsCollectionEnhancedResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/GetWorksheetAsCollectionEnhanced";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msExcelGetWorksheetAsCollectionEnhanced);
                return new ApiConnectionAction<MSExcelGetWorksheetAsCollectionEnhancedResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetNumberOfRowsResponse, ApiConnectionActionConfiguration> MSExcelGetNumberOfRows(Expression<Func<MsExcelGetNumberOfRowsInput>> msExcelGetNumberOfRows)
        {
            var __workflow_msExcelGetNumberOfRows = WorkflowExpression.Compile(msExcelGetNumberOfRows, nameof(msExcelGetNumberOfRows), required: true);
            return new DeferredBodyAction<MSExcelGetNumberOfRowsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/GetNumberOfRows";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msExcelGetNumberOfRows);
                return new ApiConnectionAction<MSExcelGetNumberOfRowsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelEvaluateExpressionResponse, ApiConnectionActionConfiguration> MSExcelEvaluateExpression(Expression<Func<MsExcelEvaluateExpressionInput>> msExcelEvaluateExpression)
        {
            var __workflow_msExcelEvaluateExpression = WorkflowExpression.Compile(msExcelEvaluateExpression, nameof(msExcelEvaluateExpression), required: true);
            return new DeferredBodyAction<MSExcelEvaluateExpressionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/EvaluateExpression";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msExcelEvaluateExpression);
                return new ApiConnectionAction<MSExcelEvaluateExpressionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetWorksheetUsedRangeResponse, ApiConnectionActionConfiguration> MSExcelGetWorksheetUsedRange(Expression<Func<MsExcelGetWorksheetUsedRangeInput>> msExcelGetWorksheetUsedRange)
        {
            var __workflow_msExcelGetWorksheetUsedRange = WorkflowExpression.Compile(msExcelGetWorksheetUsedRange, nameof(msExcelGetWorksheetUsedRange), required: true);
            return new DeferredBodyAction<MSExcelGetWorksheetUsedRangeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/GetWorksheetUsedRange";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msExcelGetWorksheetUsedRange);
                return new ApiConnectionAction<MSExcelGetWorksheetUsedRangeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetCountrySettingResponse, ApiConnectionActionConfiguration> MSExcelGetCountrySetting(Expression<Func<MsExcelGetCountrySettingInput>> msExcelGetCountrySetting)
        {
            var __workflow_msExcelGetCountrySetting = WorkflowExpression.Compile(msExcelGetCountrySetting, nameof(msExcelGetCountrySetting), required: true);
            return new DeferredBodyAction<MSExcelGetCountrySettingResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/GetCountrySetting";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msExcelGetCountrySetting);
                return new ApiConnectionAction<MSExcelGetCountrySettingResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSExcelWriteCollection(Expression<Func<MsExcelWriteCollectionInput>> msExcelWriteCollection)
        {
            var __workflow_msExcelWriteCollection = WorkflowExpression.Compile(msExcelWriteCollection, nameof(msExcelWriteCollection), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/WriteCollection";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msExcelWriteCollection);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSExcelWriteCollectionWithDates(Expression<Func<MsExcelWriteCollectionWithDatesInput>> msExcelWriteCollectionWithDates)
        {
            var __workflow_msExcelWriteCollectionWithDates = WorkflowExpression.Compile(msExcelWriteCollectionWithDates, nameof(msExcelWriteCollectionWithDates), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/WriteCollectionWithDates";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msExcelWriteCollectionWithDates);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetActiveCellResponse, ApiConnectionActionConfiguration> MSExcelGetActiveCell(Expression<Func<MsExcelGetActiveCellInput>> msExcelGetActiveCell)
        {
            var __workflow_msExcelGetActiveCell = WorkflowExpression.Compile(msExcelGetActiveCell, nameof(msExcelGetActiveCell), required: true);
            return new DeferredBodyAction<MSExcelGetActiveCellResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/GetActiveCell";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msExcelGetActiveCell);
                return new ApiConnectionAction<MSExcelGetActiveCellResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSExcelFormatCell(Expression<Func<MsExcelFormatCellInput>> msExcelFormatCell)
        {
            var __workflow_msExcelFormatCell = WorkflowExpression.Compile(msExcelFormatCell, nameof(msExcelFormatCell), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/FormatCell";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msExcelFormatCell);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSExcelFormatCurrentCell(Expression<Func<MsExcelFormatCurrentCellInput>> msExcelFormatCurrentCell)
        {
            var __workflow_msExcelFormatCurrentCell = WorkflowExpression.Compile(msExcelFormatCurrentCell, nameof(msExcelFormatCurrentCell), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/FormatCurrentCell";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msExcelFormatCurrentCell);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSExcelSelectCellRange(Expression<Func<MsExcelSelectCellRangeInput>> msExcelSelectCellRange)
        {
            var __workflow_msExcelSelectCellRange = WorkflowExpression.Compile(msExcelSelectCellRange, nameof(msExcelSelectCellRange), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/SelectCellRange";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msExcelSelectCellRange);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSExcelCopySelection(Expression<Func<MsExcelCopySelectionInput>> msExcelCopySelection)
        {
            var __workflow_msExcelCopySelection = WorkflowExpression.Compile(msExcelCopySelection, nameof(msExcelCopySelection), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/CopySelection";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msExcelCopySelection);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSExcelCutSelection(Expression<Func<MsExcelCutSelectionInput>> msExcelCutSelection)
        {
            var __workflow_msExcelCutSelection = WorkflowExpression.Compile(msExcelCutSelection, nameof(msExcelCutSelection), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/CutSelection";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msExcelCutSelection);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSExcelPasteIntoSelection(Expression<Func<MsExcelPasteIntoSelectionInput>> msExcelPasteIntoSelection)
        {
            var __workflow_msExcelPasteIntoSelection = WorkflowExpression.Compile(msExcelPasteIntoSelection, nameof(msExcelPasteIntoSelection), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/PasteIntoSelection";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msExcelPasteIntoSelection);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSExcelInsertOnSelection(Expression<Func<MsExcelInsertOnSelectionInput>> msExcelInsertOnSelection)
        {
            var __workflow_msExcelInsertOnSelection = WorkflowExpression.Compile(msExcelInsertOnSelection, nameof(msExcelInsertOnSelection), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/InsertOnSelection";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msExcelInsertOnSelection);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSExcelDeleteSelection(Expression<Func<MsExcelDeleteSelectionInput>> msExcelDeleteSelection)
        {
            var __workflow_msExcelDeleteSelection = WorkflowExpression.Compile(msExcelDeleteSelection, nameof(msExcelDeleteSelection), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/DeleteSelection";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msExcelDeleteSelection);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSExcelClearExcelClipboard(Expression<Func<MsExcelClearExcelClipboardInput>> msExcelClearExcelClipboard)
        {
            var __workflow_msExcelClearExcelClipboard = WorkflowExpression.Compile(msExcelClearExcelClipboard, nameof(msExcelClearExcelClipboard), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/ClearExcelClipboard";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msExcelClearExcelClipboard);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelRunMacroResponse, ApiConnectionActionConfiguration> MSExcelRunMacro(Expression<Func<MsExcelRunMacroInput>> msExcelRunMacro)
        {
            var __workflow_msExcelRunMacro = WorkflowExpression.Compile(msExcelRunMacro, nameof(msExcelRunMacro), required: true);
            return new DeferredBodyAction<MSExcelRunMacroResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/RunMacro";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msExcelRunMacro);
                return new ApiConnectionAction<MSExcelRunMacroResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSExcelAddMacroToWorkbook(Expression<Func<MsExcelAddMacroToWorkbookInput>> msExcelAddMacroToWorkbook)
        {
            var __workflow_msExcelAddMacroToWorkbook = WorkflowExpression.Compile(msExcelAddMacroToWorkbook, nameof(msExcelAddMacroToWorkbook), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/AddMacroToWorkbook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msExcelAddMacroToWorkbook);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSExcelTrustVbomInRegistry(Expression<Func<MsExcelTrustVbomInRegistryInput>> msExcelTrustVbomInRegistry)
        {
            var __workflow_msExcelTrustVbomInRegistry = WorkflowExpression.Compile(msExcelTrustVbomInRegistry, nameof(msExcelTrustVbomInRegistry), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/TrustVBOMInRegistry";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msExcelTrustVbomInRegistry);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSExcelSetCalculationMode(Expression<Func<MsExcelSetCalculationModeInput>> msExcelSetCalculationMode)
        {
            var __workflow_msExcelSetCalculationMode = WorkflowExpression.Compile(msExcelSetCalculationMode, nameof(msExcelSetCalculationMode), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/SetCalculationMode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msExcelSetCalculationMode);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSExcelExecuteCommandBarObject(Expression<Func<MsExcelExecuteCommandBarObjectInput>> msExcelExecuteCommandBarObject)
        {
            var __workflow_msExcelExecuteCommandBarObject = WorkflowExpression.Compile(msExcelExecuteCommandBarObject, nameof(msExcelExecuteCommandBarObject), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/ExecuteCommandBarObject";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msExcelExecuteCommandBarObject);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelCopyBetweenCellsResponse, ApiConnectionActionConfiguration> MSExcelCopyBetweenCells(Expression<Func<MsExcelCopyBetweenCellsInput>> msExcelCopyBetweenCells)
        {
            var __workflow_msExcelCopyBetweenCells = WorkflowExpression.Compile(msExcelCopyBetweenCells, nameof(msExcelCopyBetweenCells), required: true);
            return new DeferredBodyAction<MSExcelCopyBetweenCellsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/CopyBetweenCells";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msExcelCopyBetweenCells);
                return new ApiConnectionAction<MSExcelCopyBetweenCellsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelCutBetweenCellsResponse, ApiConnectionActionConfiguration> MSExcelCutBetweenCells(Expression<Func<MsExcelCutBetweenCellsInput>> msExcelCutBetweenCells)
        {
            var __workflow_msExcelCutBetweenCells = WorkflowExpression.Compile(msExcelCutBetweenCells, nameof(msExcelCutBetweenCells), required: true);
            return new DeferredBodyAction<MSExcelCutBetweenCellsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/CutBetweenCells";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msExcelCutBetweenCells);
                return new ApiConnectionAction<MSExcelCutBetweenCellsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelMinimiseWindowResponse, ApiConnectionActionConfiguration> MSExcelMinimiseWindow(Expression<Func<MsExcelMinimiseWindowInput>> msExcelMinimiseWindow)
        {
            var __workflow_msExcelMinimiseWindow = WorkflowExpression.Compile(msExcelMinimiseWindow, nameof(msExcelMinimiseWindow), required: true);
            return new DeferredBodyAction<MSExcelMinimiseWindowResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/MinimiseWindow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msExcelMinimiseWindow);
                return new ApiConnectionAction<MSExcelMinimiseWindowResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelMaximiseWindowResponse, ApiConnectionActionConfiguration> MSExcelMaximiseWindow(Expression<Func<MsExcelMaximiseWindowInput>> msExcelMaximiseWindow)
        {
            var __workflow_msExcelMaximiseWindow = WorkflowExpression.Compile(msExcelMaximiseWindow, nameof(msExcelMaximiseWindow), required: true);
            return new DeferredBodyAction<MSExcelMaximiseWindowResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/MaximiseWindow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msExcelMaximiseWindow);
                return new ApiConnectionAction<MSExcelMaximiseWindowResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelNormaliseWindowResponse, ApiConnectionActionConfiguration> MSExcelNormaliseWindow(Expression<Func<MsExcelNormaliseWindowInput>> msExcelNormaliseWindow)
        {
            var __workflow_msExcelNormaliseWindow = WorkflowExpression.Compile(msExcelNormaliseWindow, nameof(msExcelNormaliseWindow), required: true);
            return new DeferredBodyAction<MSExcelNormaliseWindowResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/NormaliseWindow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msExcelNormaliseWindow);
                return new ApiConnectionAction<MSExcelNormaliseWindowResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetAndSetCellValueResponse, ApiConnectionActionConfiguration> MSExcelGetAndSetCellValue(Expression<Func<MsExcelGetAndSetCellValueInput>> msExcelGetAndSetCellValue)
        {
            var __workflow_msExcelGetAndSetCellValue = WorkflowExpression.Compile(msExcelGetAndSetCellValue, nameof(msExcelGetAndSetCellValue), required: true);
            return new DeferredBodyAction<MSExcelGetAndSetCellValueResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/GetAndSetCellValue";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msExcelGetAndSetCellValue);
                return new ApiConnectionAction<MSExcelGetAndSetCellValueResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetAndSetCellValue2Response, ApiConnectionActionConfiguration> MSExcelGetAndSetCellValue2(Expression<Func<MsExcelGetAndSetCellValue2Input>> msExcelGetAndSetCellValue2)
        {
            var __workflow_msExcelGetAndSetCellValue2 = WorkflowExpression.Compile(msExcelGetAndSetCellValue2, nameof(msExcelGetAndSetCellValue2), required: true);
            return new DeferredBodyAction<MSExcelGetAndSetCellValue2Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/GetAndSetCellValue2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msExcelGetAndSetCellValue2);
                return new ApiConnectionAction<MSExcelGetAndSetCellValue2Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetAndSetCellTextResponse, ApiConnectionActionConfiguration> MSExcelGetAndSetCellText(Expression<Func<MsExcelGetAndSetCellTextInput>> msExcelGetAndSetCellText)
        {
            var __workflow_msExcelGetAndSetCellText = WorkflowExpression.Compile(msExcelGetAndSetCellText, nameof(msExcelGetAndSetCellText), required: true);
            return new DeferredBodyAction<MSExcelGetAndSetCellTextResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/GetAndSetCellText";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msExcelGetAndSetCellText);
                return new ApiConnectionAction<MSExcelGetAndSetCellTextResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelCheckOleObjectResponse, ApiConnectionActionConfiguration> MSExcelCheckOleObject(Expression<Func<MsExcelCheckOleObjectInput>> msExcelCheckOleObject)
        {
            var __workflow_msExcelCheckOleObject = WorkflowExpression.Compile(msExcelCheckOleObject, nameof(msExcelCheckOleObject), required: true);
            return new DeferredBodyAction<MSExcelCheckOleObjectResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/CheckOLEObject";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msExcelCheckOleObject);
                return new ApiConnectionAction<MSExcelCheckOleObjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelInputTextIntoOleObjectResponse, ApiConnectionActionConfiguration> MSExcelInputTextIntoOleObject(Expression<Func<MsExcelInputTextIntoOleObjectInput>> msExcelInputTextIntoOleObject)
        {
            var __workflow_msExcelInputTextIntoOleObject = WorkflowExpression.Compile(msExcelInputTextIntoOleObject, nameof(msExcelInputTextIntoOleObject), required: true);
            return new DeferredBodyAction<MSExcelInputTextIntoOleObjectResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/InputTextIntoOLEObject";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msExcelInputTextIntoOleObject);
                return new ApiConnectionAction<MSExcelInputTextIntoOleObjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelSetCellBackgroundColourResponse, ApiConnectionActionConfiguration> MSExcelSetCellBackgroundColour(Expression<Func<MsExcelSetCellBackgroundColourInput>> msExcelSetCellBackgroundColour)
        {
            var __workflow_msExcelSetCellBackgroundColour = WorkflowExpression.Compile(msExcelSetCellBackgroundColour, nameof(msExcelSetCellBackgroundColour), required: true);
            return new DeferredBodyAction<MSExcelSetCellBackgroundColourResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/SetCellBackgroundColour";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msExcelSetCellBackgroundColour);
                return new ApiConnectionAction<MSExcelSetCellBackgroundColourResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetCellBackgroundColourResponse, ApiConnectionActionConfiguration> MSExcelGetCellBackgroundColour(Expression<Func<MsExcelGetCellBackgroundColourInput>> msExcelGetCellBackgroundColour)
        {
            var __workflow_msExcelGetCellBackgroundColour = WorkflowExpression.Compile(msExcelGetCellBackgroundColour, nameof(msExcelGetCellBackgroundColour), required: true);
            return new DeferredBodyAction<MSExcelGetCellBackgroundColourResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/GetCellBackgroundColour";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msExcelGetCellBackgroundColour);
                return new ApiConnectionAction<MSExcelGetCellBackgroundColourResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetOleObjectValueResponse, ApiConnectionActionConfiguration> MSExcelGetOleObjectValue(Expression<Func<MsExcelGetOleObjectValueInput>> msExcelGetOleObjectValue)
        {
            var __workflow_msExcelGetOleObjectValue = WorkflowExpression.Compile(msExcelGetOleObjectValue, nameof(msExcelGetOleObjectValue), required: true);
            return new DeferredBodyAction<MSExcelGetOleObjectValueResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/GetOLEObjectValue";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msExcelGetOleObjectValue);
                return new ApiConnectionAction<MSExcelGetOleObjectValueResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelDoesOleObjectExistResponse, ApiConnectionActionConfiguration> MSExcelDoesOleObjectExist(Expression<Func<MsExcelDoesOleObjectExistInput>> msExcelDoesOleObjectExist)
        {
            var __workflow_msExcelDoesOleObjectExist = WorkflowExpression.Compile(msExcelDoesOleObjectExist, nameof(msExcelDoesOleObjectExist), required: true);
            return new DeferredBodyAction<MSExcelDoesOleObjectExistResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/DoesOLEObjectExist";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msExcelDoesOleObjectExist);
                return new ApiConnectionAction<MSExcelDoesOleObjectExistResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelPressOleObjectResponse, ApiConnectionActionConfiguration> MSExcelPressOleObject(Expression<Func<MsExcelPressOleObjectInput>> msExcelPressOleObject)
        {
            var __workflow_msExcelPressOleObject = WorkflowExpression.Compile(msExcelPressOleObject, nameof(msExcelPressOleObject), required: true);
            return new DeferredBodyAction<MSExcelPressOleObjectResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/PressOLEObject";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msExcelPressOleObject);
                return new ApiConnectionAction<MSExcelPressOleObjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelSetWorksheetSensitivityLabelResponse, ApiConnectionActionConfiguration> MSExcelSetWorksheetSensitivityLabel(Expression<Func<MsExcelSetWorksheetSensitivityLabelInput>> msExcelSetWorksheetSensitivityLabel)
        {
            var __workflow_msExcelSetWorksheetSensitivityLabel = WorkflowExpression.Compile(msExcelSetWorksheetSensitivityLabel, nameof(msExcelSetWorksheetSensitivityLabel), required: true);
            return new DeferredBodyAction<MSExcelSetWorksheetSensitivityLabelResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/SetWorksheetSensitivityLabel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msExcelSetWorksheetSensitivityLabel);
                return new ApiConnectionAction<MSExcelSetWorksheetSensitivityLabelResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetWorksheetSensitivityLabelResponse, ApiConnectionActionConfiguration> MSExcelGetWorksheetSensitivityLabel(Expression<Func<MsExcelGetWorksheetSensitivityLabelInput>> msExcelGetWorksheetSensitivityLabel)
        {
            var __workflow_msExcelGetWorksheetSensitivityLabel = WorkflowExpression.Compile(msExcelGetWorksheetSensitivityLabel, nameof(msExcelGetWorksheetSensitivityLabel), required: true);
            return new DeferredBodyAction<MSExcelGetWorksheetSensitivityLabelResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/GetWorksheetSensitivityLabel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msExcelGetWorksheetSensitivityLabel);
                return new ApiConnectionAction<MSExcelGetWorksheetSensitivityLabelResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelWriteArrayResponse, ApiConnectionActionConfiguration> MSExcelWriteArray(Expression<Func<MsExcelWriteArrayInput>> msExcelWriteArray)
        {
            var __workflow_msExcelWriteArray = WorkflowExpression.Compile(msExcelWriteArray, nameof(msExcelWriteArray), required: true);
            return new DeferredBodyAction<MSExcelWriteArrayResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/WriteArray";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msExcelWriteArray);
                return new ApiConnectionAction<MSExcelWriteArrayResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookCreateInstanceResponse, ApiConnectionActionConfiguration> MSOutlookCreateInstance(Expression<Func<MsOutlookCreateInstanceInput>> msOutlookCreateInstance)
        {
            var __workflow_msOutlookCreateInstance = WorkflowExpression.Compile(msOutlookCreateInstance, nameof(msOutlookCreateInstance), required: true);
            return new DeferredBodyAction<MSOutlookCreateInstanceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSOutlook/CreateInstance";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msOutlookCreateInstance);
                return new ApiConnectionAction<MSOutlookCreateInstanceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSOutlookCloseInstance(Expression<Func<MsOutlookCloseInstanceInput>> msOutlookCloseInstance)
        {
            var __workflow_msOutlookCloseInstance = WorkflowExpression.Compile(msOutlookCloseInstance, nameof(msOutlookCloseInstance), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSOutlook/CloseInstance";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msOutlookCloseInstance);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSOutlookCloseInstanceUsingWindow(Expression<Func<MsOutlookCloseInstanceUsingWindowInput>> msOutlookCloseInstanceUsingWindow)
        {
            var __workflow_msOutlookCloseInstanceUsingWindow = WorkflowExpression.Compile(msOutlookCloseInstanceUsingWindow, nameof(msOutlookCloseInstanceUsingWindow), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSOutlook/CloseInstanceUsingWindow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msOutlookCloseInstanceUsingWindow);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookAttachToExistingInstanceResponse, ApiConnectionActionConfiguration> MSOutlookAttachToExistingInstance(Expression<Func<MsOutlookAttachToExistingInstanceInput>> msOutlookAttachToExistingInstance)
        {
            var __workflow_msOutlookAttachToExistingInstance = WorkflowExpression.Compile(msOutlookAttachToExistingInstance, nameof(msOutlookAttachToExistingInstance), required: true);
            return new DeferredBodyAction<MSOutlookAttachToExistingInstanceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSOutlook/MSOutlookAttachToExistingInstance";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msOutlookAttachToExistingInstance);
                return new ApiConnectionAction<MSOutlookAttachToExistingInstanceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookIsConnectedResponse, ApiConnectionActionConfiguration> MSOutlookIsConnected(Expression<Func<MsOutlookIsConnectedInput>> msOutlookIsConnected)
        {
            var __workflow_msOutlookIsConnected = WorkflowExpression.Compile(msOutlookIsConnected, nameof(msOutlookIsConnected), required: true);
            return new DeferredBodyAction<MSOutlookIsConnectedResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSOutlook/IsOutlookConnected";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msOutlookIsConnected);
                return new ApiConnectionAction<MSOutlookIsConnectedResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSOutlookShow(Expression<Func<MsOutlookShowInput>> msOutlookShow)
        {
            var __workflow_msOutlookShow = WorkflowExpression.Compile(msOutlookShow, nameof(msOutlookShow), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSOutlook/ShowOutlook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msOutlookShow);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookGetNamespaceInformationResponse, ApiConnectionActionConfiguration> MSOutlookGetNamespaceInformation(Expression<Func<MsOutlookGetNamespaceInformationInput>> msOutlookGetNamespaceInformation)
        {
            var __workflow_msOutlookGetNamespaceInformation = WorkflowExpression.Compile(msOutlookGetNamespaceInformation, nameof(msOutlookGetNamespaceInformation), required: true);
            return new DeferredBodyAction<MSOutlookGetNamespaceInformationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSOutlook/GetNameSpaceInformation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msOutlookGetNamespaceInformation);
                return new ApiConnectionAction<MSOutlookGetNamespaceInformationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookGetMailFoldersResponse, ApiConnectionActionConfiguration> MSOutlookGetMailFolders(Expression<Func<MsOutlookGetMailFoldersInput>> msOutlookGetMailFolders)
        {
            var __workflow_msOutlookGetMailFolders = WorkflowExpression.Compile(msOutlookGetMailFolders, nameof(msOutlookGetMailFolders), required: true);
            return new DeferredBodyAction<MSOutlookGetMailFoldersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSOutlook/GetMailFolders";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msOutlookGetMailFolders);
                return new ApiConnectionAction<MSOutlookGetMailFoldersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSOutlookMarkEmailAsRead(Expression<Func<MsOutlookMarkEmailAsReadInput>> msOutlookMarkEmailAsRead)
        {
            var __workflow_msOutlookMarkEmailAsRead = WorkflowExpression.Compile(msOutlookMarkEmailAsRead, nameof(msOutlookMarkEmailAsRead), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSOutlook/MarkEmailAsRead";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msOutlookMarkEmailAsRead);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookGetEmailBodyResponse, ApiConnectionActionConfiguration> MSOutlookGetEmailBody(Expression<Func<MsOutlookGetEmailBodyInput>> msOutlookGetEmailBody)
        {
            var __workflow_msOutlookGetEmailBody = WorkflowExpression.Compile(msOutlookGetEmailBody, nameof(msOutlookGetEmailBody), required: true);
            return new DeferredBodyAction<MSOutlookGetEmailBodyResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSOutlook/GetEmailBody";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msOutlookGetEmailBody);
                return new ApiConnectionAction<MSOutlookGetEmailBodyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookGetEmailAttachmentFilenamesResponse, ApiConnectionActionConfiguration> MSOutlookGetEmailAttachmentFilenames(Expression<Func<MsOutlookGetEmailAttachmentFilenamesInput>> msOutlookGetEmailAttachmentFilenames)
        {
            var __workflow_msOutlookGetEmailAttachmentFilenames = WorkflowExpression.Compile(msOutlookGetEmailAttachmentFilenames, nameof(msOutlookGetEmailAttachmentFilenames), required: true);
            return new DeferredBodyAction<MSOutlookGetEmailAttachmentFilenamesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSOutlook/GetEmailAttachmentFilenames";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msOutlookGetEmailAttachmentFilenames);
                return new ApiConnectionAction<MSOutlookGetEmailAttachmentFilenamesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookSaveEmailAttachmentsAsFileResponse, ApiConnectionActionConfiguration> MSOutlookSaveEmailAttachmentsAsFile(Expression<Func<MsOutlookSaveEmailAttachmentsAsFileInput>> msOutlookSaveEmailAttachmentsAsFile)
        {
            var __workflow_msOutlookSaveEmailAttachmentsAsFile = WorkflowExpression.Compile(msOutlookSaveEmailAttachmentsAsFile, nameof(msOutlookSaveEmailAttachmentsAsFile), required: true);
            return new DeferredBodyAction<MSOutlookSaveEmailAttachmentsAsFileResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSOutlook/SaveEmailAttachmentsAsFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msOutlookSaveEmailAttachmentsAsFile);
                return new ApiConnectionAction<MSOutlookSaveEmailAttachmentsAsFileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSOutlookDeleteEmail(Expression<Func<MsOutlookDeleteEmailInput>> msOutlookDeleteEmail)
        {
            var __workflow_msOutlookDeleteEmail = WorkflowExpression.Compile(msOutlookDeleteEmail, nameof(msOutlookDeleteEmail), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSOutlook/DeleteEmail";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msOutlookDeleteEmail);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSOutlookMoveEmail(Expression<Func<MsOutlookMoveEmailInput>> msOutlookMoveEmail)
        {
            var __workflow_msOutlookMoveEmail = WorkflowExpression.Compile(msOutlookMoveEmail, nameof(msOutlookMoveEmail), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSOutlook/MoveEmail";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msOutlookMoveEmail);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSOutlookSendEmail(Expression<Func<MsOutlookSendEmailInput>> msOutlookSendEmail)
        {
            var __workflow_msOutlookSendEmail = WorkflowExpression.Compile(msOutlookSendEmail, nameof(msOutlookSendEmail), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSOutlook/SendEmail";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msOutlookSendEmail);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSOutlookCreateMailFolder(Expression<Func<MsOutlookCreateMailFolderInput>> msOutlookCreateMailFolder)
        {
            var __workflow_msOutlookCreateMailFolder = WorkflowExpression.Compile(msOutlookCreateMailFolder, nameof(msOutlookCreateMailFolder), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSOutlook/CreateMailFolder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msOutlookCreateMailFolder);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSOutlookReplyToEmail(Expression<Func<MsOutlookReplyToEmailInput>> msOutlookReplyToEmail)
        {
            var __workflow_msOutlookReplyToEmail = WorkflowExpression.Compile(msOutlookReplyToEmail, nameof(msOutlookReplyToEmail), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSOutlook/ReplyToEmail";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msOutlookReplyToEmail);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSOutlookForwardEmail(Expression<Func<MsOutlookForwardEmailInput>> msOutlookForwardEmail)
        {
            var __workflow_msOutlookForwardEmail = WorkflowExpression.Compile(msOutlookForwardEmail, nameof(msOutlookForwardEmail), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSOutlook/MSOutlookForwardEmail";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msOutlookForwardEmail);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookGetMapiProfilesResponse, ApiConnectionActionConfiguration> MSOutlookGetMapiProfiles(Expression<Func<MsOutlookGetMapiProfilesInput>> msOutlookGetMapiProfiles)
        {
            var __workflow_msOutlookGetMapiProfiles = WorkflowExpression.Compile(msOutlookGetMapiProfiles, nameof(msOutlookGetMapiProfiles), required: true);
            return new DeferredBodyAction<MSOutlookGetMapiProfilesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSOutlook/GetMAPIProfiles";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msOutlookGetMapiProfiles);
                return new ApiConnectionAction<MSOutlookGetMapiProfilesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookGetOutlookProcessIdResponse, ApiConnectionActionConfiguration> MSOutlookGetOutlookProcessId(Expression<Func<MsOutlookGetOutlookProcessIdInput>> msOutlookGetOutlookProcessId)
        {
            var __workflow_msOutlookGetOutlookProcessId = WorkflowExpression.Compile(msOutlookGetOutlookProcessId, nameof(msOutlookGetOutlookProcessId), required: true);
            return new DeferredBodyAction<MSOutlookGetOutlookProcessIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSOutlook/GetOutlookProcessId";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msOutlookGetOutlookProcessId);
                return new ApiConnectionAction<MSOutlookGetOutlookProcessIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSOutlookBackgroundMonitorForAllowPopup(Expression<Func<MsOutlookBackgroundMonitorForAllowPopupInput>> msOutlookBackgroundMonitorForAllowPopup)
        {
            var __workflow_msOutlookBackgroundMonitorForAllowPopup = WorkflowExpression.Compile(msOutlookBackgroundMonitorForAllowPopup, nameof(msOutlookBackgroundMonitorForAllowPopup), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSOutlook/BackgroundMonitorForAllowPopup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msOutlookBackgroundMonitorForAllowPopup);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSOutlookSetAllowPopupDetails(Expression<Func<MsOutlookSetAllowPopupDetailsInput>> msOutlookSetAllowPopupDetails)
        {
            var __workflow_msOutlookSetAllowPopupDetails = WorkflowExpression.Compile(msOutlookSetAllowPopupDetails, nameof(msOutlookSetAllowPopupDetails), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSOutlook/MSOutlookSetAllowPopupDetails";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msOutlookSetAllowPopupDetails);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookExecuteCommandBarObjectResponse, ApiConnectionActionConfiguration> MSOutlookExecuteCommandBarObject(Expression<Func<MsOutlookExecuteCommandBarObjectInput>> msOutlookExecuteCommandBarObject)
        {
            var __workflow_msOutlookExecuteCommandBarObject = WorkflowExpression.Compile(msOutlookExecuteCommandBarObject, nameof(msOutlookExecuteCommandBarObject), required: true);
            return new DeferredBodyAction<MSOutlookExecuteCommandBarObjectResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSOutlook/MSOutlookExecuteCommandBarObject";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msOutlookExecuteCommandBarObject);
                return new ApiConnectionAction<MSOutlookExecuteCommandBarObjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookGetEmailsResponse, ApiConnectionActionConfiguration> MSOutlookGetEmails(Expression<Func<MsOutlookGetEmailsInput>> msOutlookGetEmails)
        {
            var __workflow_msOutlookGetEmails = WorkflowExpression.Compile(msOutlookGetEmails, nameof(msOutlookGetEmails), required: true);
            return new DeferredBodyAction<MSOutlookGetEmailsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSOutlook/GetEmails";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msOutlookGetEmails);
                return new ApiConnectionAction<MSOutlookGetEmailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookGetFirstEmailResponse, ApiConnectionActionConfiguration> MSOutlookGetFirstEmail(Expression<Func<MsOutlookGetFirstEmailInput>> msOutlookGetFirstEmail)
        {
            var __workflow_msOutlookGetFirstEmail = WorkflowExpression.Compile(msOutlookGetFirstEmail, nameof(msOutlookGetFirstEmail), required: true);
            return new DeferredBodyAction<MSOutlookGetFirstEmailResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSOutlook/GetFirstEmail";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msOutlookGetFirstEmail);
                return new ApiConnectionAction<MSOutlookGetFirstEmailResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookGetNumberOfEmailsResponse, ApiConnectionActionConfiguration> MSOutlookGetNumberOfEmails(Expression<Func<MsOutlookGetNumberOfEmailsInput>> msOutlookGetNumberOfEmails)
        {
            var __workflow_msOutlookGetNumberOfEmails = WorkflowExpression.Compile(msOutlookGetNumberOfEmails, nameof(msOutlookGetNumberOfEmails), required: true);
            return new DeferredBodyAction<MSOutlookGetNumberOfEmailsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSOutlook/GetNumberOfEmails";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msOutlookGetNumberOfEmails);
                return new ApiConnectionAction<MSOutlookGetNumberOfEmailsResponse>(callPayload);
            });
        }
    }

    public class IaconnectmsofficeTriggers([ConnectionName] string connectionId)
    {
    }

    public class MSWordCreateInstanceResponse
    {
        public int Handle { get; set; }
    }

    public class MsWordCreateInstanceInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ShowWord { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MsWordCloseInstanceInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MsWordDetachFromInstanceInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSWordAttachToExistingInstanceResponse
    {
        public int Handle { get; set; }
    }

    public class MsWordAttachToExistingInstanceInput
    {
        [JsonProperty("Filename")]
        public string FileName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ToggleWindow { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ToggleUsesGlobalLeftMouseClickAgent { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? ToggleDelay { get; set; } = 0.5;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MsWordShowWordInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MsWordHideWordInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSWordCreateDocumentResponse
    {
        public string DocumentName { get; set; }
    }

    public class MsWordCreateDocumentInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSWordOpenDocumentResponse
    {
        public string DocumentName { get; set; }
    }

    public class MsWordOpenDocumentInput
    {
        public MsWordOpenDocumentInput(string fileName)
        {
            this.FileName = fileName;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;

        [JsonProperty("Filename", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FileName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OpenReadOnly { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AddToRecentFiles { get; set; } = false;
        public string Password { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OpenAndRepair { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MsWordSaveDocumentInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string DocumentName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSWordSaveAsDocumentResponse
    {
        public string NewDocumentName { get; set; }
    }

    public class MsWordSaveAsDocumentInput
    {
        public MsWordSaveAsDocumentInput(string saveFileName)
        {
            this.SaveFileName = saveFileName;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string DocumentName { get; set; }

        [JsonProperty("SaveFilename", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SaveFileName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MsWordCloseDocumentInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string DocumentName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MsWordTypeTextInput
    {
        public MsWordTypeTextInput(string text)
        {
            this.Text = text;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Text { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MsWordSelectAllInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string DocumentName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MsWordSelectRangeInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string DocumentName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int Start { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int Finish { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MsWordCopyToClipboardInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MsWordPasteFromClipboardInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MsWordClearClipboardInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSWordGetDocumentBodyTextResponse
    {
        public string BodyText { get; set; }
    }

    public class MsWordGetDocumentBodyTextInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string DocumentName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int Start { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int Finish { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSWordGetNumberOfTablesInDocumentResponse
    {
        public int NumberOfTables { get; set; }
    }

    public class MsWordGetNumberOfTablesInDocumentInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string DocumentName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MsWordUpdateBookmarkInput
    {
        public MsWordUpdateBookmarkInput(string bookmarkName)
        {
            this.BookmarkName = bookmarkName;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string DocumentName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string BookmarkName { get; set; }
        public string NewValue { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MsWordSelectTableInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string DocumentName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int TableIndex { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSWordGetTableBoundsResponse
    {
        public int NumberOfRows { get; set; }
        public int NumberOfColumns { get; set; }
    }

    public class MsWordGetTableBoundsInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string DocumentName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int TableIndex { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MsWordSelectTableCellInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string DocumentName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int TableIndex { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int RowIndex { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ColumnIndex { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSWordGetTableCellTextValueResponse
    {
        public string CellText { get; set; }
    }

    public class MsWordGetTableCellTextValueInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string DocumentName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int TableIndex { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int RowIndex { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ColumnIndex { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSWordGetTableCellTextValueTrimmedResponse
    {
        public string CellText { get; set; }
    }

    public class MsWordGetTableCellTextValueTrimmedInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string DocumentName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int TableIndex { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int RowIndex { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ColumnIndex { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MsWordSetTableCellTextValueInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string DocumentName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int TableIndex { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int RowIndex { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ColumnIndex { get; set; } = 1;
        public string NewCellText { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MsWordExportDocumentAsPdfInput
    {
        public MsWordExportDocumentAsPdfInput(string saveFileName)
        {
            this.SaveFileName = saveFileName;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string DocumentName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SaveFileName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MsWordAddTableInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string DocumentName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int NumberOfRows { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int NumberOfColumns { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? AutoFitBehaviour { get; set; } = 2;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MsWordAddTableRowInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string DocumentName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int TableIndex { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MsWordAddTableColumnInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string DocumentName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int TableIndex { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSWordGetHighlightedTextResponse
    {
        [JsonProperty("HighlightedTextJSON")]
        public string HighlightedTextJson { get; set; }
    }

    public class MsWordGetHighlightedTextInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string DocumentName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSWordExecuteCommandBarObjectResponse
    {
        public bool MSWordExecuteCommandBarObjectResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class MsWordExecuteCommandBarObjectInput
    {
        public MsWordExecuteCommandBarObjectInput(string objectId)
        {
            this.ObjectId = objectId;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ObjectId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RunInBackground { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSWordSetDocumentSensitivityLabelResponse
    {
        public bool MSWordSetDocumentSensitivityLabelResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class MsWordSetDocumentSensitivityLabelInput
    {
        public MsWordSetDocumentSensitivityLabelInput(string labelId)
        {
            this.LabelId = labelId;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string DocumentName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public MsWordSetDocumentSensitivityLabelInputAssignmentMethodType AssignmentMethod { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectmsoffice.MsWordSetDocumentSensitivityLabelInputAssignmentMethodType.NotSet;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string LabelId { get; set; }
        public string LabelName { get; set; }
        public string SiteId { get; set; }
        public string Justification { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MsWordSetDocumentSensitivityLabelInputAssignmentMethodType
    {
        [EnumMember(Value = "NOT_SET")]
        NotSet,
        [EnumMember(Value = "STANDARD")]
        Standard,
        [EnumMember(Value = "PRIVILEGED")]
        Priviledged,
        [EnumMember(Value = "AUTO")]
        Auto
    }

    public class MSWordGetDocumentSensitivityLabelResponse
    {
        public string AssignmentMethod { get; set; }
        public string LabelId { get; set; }
        public string LabelName { get; set; }
        public string SiteId { get; set; }
        public string Justification { get; set; }
        public string SetDate { get; set; }
    }

    public class MsWordGetDocumentSensitivityLabelInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string DocumentName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSExcelCreateInstanceResponse
    {
        public int Handle { get; set; }
    }

    public class MsExcelCreateInstanceInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? EnableEvents { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ShowExcel { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MsExcelCloseInstanceInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSExcelAttachToExistingInstanceResponse
    {
        public int Handle { get; set; }
    }

    public class MsExcelAttachToExistingInstanceInput
    {
        [JsonProperty("Filename")]
        public string FileName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ToggleWindow { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ToggleUsesGlobalLeftMouseClickAgent { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? ToggleDelay { get; set; } = 0.5;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MsExcelShowExcelInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MsExcelHideExcelInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSExcelOpenWorkbookResponse
    {
        public string WorkbookName { get; set; }
    }

    public class MsExcelOpenWorkbookInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;

        [JsonProperty("Filename")]
        public string FileName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReadOnly { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? UpdateLinks { get; set; } = false;
        public string Password { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? EnableEvents { get; set; } = true;

        [JsonProperty("PutHTTPWorkbooksIntoEditMode", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? PutHttpWorkbooksIntoEditMode { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? PutFilePathWorkbooksIntoEditMode { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSExcelPutWorkbookInEditModeResponse
    {
        public bool MSExcelPutWorkbookInEditModeResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class MsExcelPutWorkbookInEditModeInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string WorkbookName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Force { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSExcelCreateWorkbookResponse
    {
        public string WorkbookName { get; set; }
    }

    public class MsExcelCreateWorkbookInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MsExcelCloseWorkbookInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string WorkbookName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SaveData { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MsExcelCloseCurrentWorkbookInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MsExcelGoToCellInput
    {
        public MsExcelGoToCellInput(string cellReference)
        {
            this.CellReference = cellReference;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string WorkbookName { get; set; }
        public string WorksheetName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string CellReference { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSExcelGetCellValueResponse
    {
        public string CellValue { get; set; }
    }

    public class MsExcelGetCellValueInput
    {
        public MsExcelGetCellValueInput(string cellReference)
        {
            this.CellReference = cellReference;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string WorkbookName { get; set; }
        public string WorksheetName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string CellReference { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSExcelGetCellValue2Response
    {
        public string CellValue { get; set; }
    }

    public class MsExcelGetCellValue2Input
    {
        public MsExcelGetCellValue2Input(string cellReference)
        {
            this.CellReference = cellReference;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string WorkbookName { get; set; }
        public string WorksheetName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string CellReference { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSExcelGetCellTextResponse
    {
        public string CellValue { get; set; }
    }

    public class MsExcelGetCellTextInput
    {
        public MsExcelGetCellTextInput(string cellReference)
        {
            this.CellReference = cellReference;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string WorkbookName { get; set; }
        public string WorksheetName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string CellReference { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MsExcelSetCellValueInput
    {
        public MsExcelSetCellValueInput(string cellReference)
        {
            this.CellReference = cellReference;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string WorkbookName { get; set; }
        public string WorksheetName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string CellReference { get; set; }
        public string CellValue { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CellValueContainsStoredPassword { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSExcelFindNextCellWithValueResponse
    {
        public string CellReference { get; set; }
        public int RowIndex { get; set; }
        public int ColumnIndex { get; set; }
    }

    public class MsExcelFindNextCellWithValueInput
    {
        public MsExcelFindNextCellWithValueInput(MsExcelFindNextCellWithValueInputDirectionType direction, string searchValue)
        {
            this.Direction = direction;
            this.SearchValue = searchValue;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string WorkbookName { get; set; }
        public string WorksheetName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public MsExcelFindNextCellWithValueInputDirectionType Direction { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchValue { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CaseSensitive { get; set; } = false;
        public MsExcelFindNextCellWithValueInputComparisonTypeType? ComparisonType { get; set; }
        public int? MaxCellsToSearch { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ActivateCell { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MsExcelFindNextCellWithValueInputDirectionType
    {
        U,
        D,
        L,
        R
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MsExcelFindNextCellWithValueInputComparisonTypeType
    {
        Equals,
        Contains,
        StartsWith,
        EndsWith
    }

    public class MSExcelFindNextEmptyCellResponse
    {
        public string CellReference { get; set; }
        public int RowIndex { get; set; }
        public int ColumnIndex { get; set; }
    }

    public class MsExcelFindNextEmptyCellInput
    {
        public MsExcelFindNextEmptyCellInput(MsExcelFindNextEmptyCellInputDirectionType direction)
        {
            this.Direction = direction;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string WorkbookName { get; set; }
        public string WorksheetName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public MsExcelFindNextEmptyCellInputDirectionType Direction { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ActivateCell { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MsExcelFindNextEmptyCellInputDirectionType
    {
        U,
        D,
        L,
        R
    }

    public class MSExcelGotoNextEmptyCellLeftResponse
    {
        public string CellReference { get; set; }
        public int RowIndex { get; set; }
        public int ColumnIndex { get; set; }
    }

    public class MsExcelGotoNextEmptyCellLeftInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string WorkbookName { get; set; }
        public string WorksheetName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSExcelGotoNextEmptyCellRightResponse
    {
        public string CellReference { get; set; }
        public int RowIndex { get; set; }
        public int ColumnIndex { get; set; }
    }

    public class MsExcelGotoNextEmptyCellRightInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string WorkbookName { get; set; }
        public string WorksheetName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSExcelGotoNextEmptyCellUpResponse
    {
        public string CellReference { get; set; }
        public int RowIndex { get; set; }
        public int ColumnIndex { get; set; }
    }

    public class MsExcelGotoNextEmptyCellUpInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string WorkbookName { get; set; }
        public string WorksheetName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSExcelGotoNextEmptyCellDownResponse
    {
        public string CellReference { get; set; }
        public int RowIndex { get; set; }
        public int ColumnIndex { get; set; }
    }

    public class MsExcelGotoNextEmptyCellDownInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string WorkbookName { get; set; }
        public string WorksheetName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSExcelSaveWorkbookResponse
    {
        public string NewWorkbookName { get; set; }
    }

    public class MsExcelSaveWorkbookInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string WorkbookName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSExcelSaveWorkbookAsResponse
    {
        public string NewWorkbookName { get; set; }
    }

    public class MsExcelSaveWorkbookAsInput
    {
        public MsExcelSaveWorkbookAsInput(string saveFileName)
        {
            this.SaveFileName = saveFileName;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string WorkbookName { get; set; }

        [JsonProperty("SaveFilename", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SaveFileName { get; set; }

        [JsonProperty("DeleteExistingSaveFilename", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? DeleteExistingSaveFileName { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public MsExcelSaveWorkbookAsInputExcelFileFormatType? ExcelFileFormat { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectmsoffice.MsExcelSaveWorkbookAsInputExcelFileFormatType.AutomaticFromFileExtension;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MsExcelSaveWorkbookAsInputExcelFileFormatType
    {
        [EnumMember(Value = "AutomaticByExtension")]
        AutomaticFromFileExtension,
        NotSpecified,
        ExcelWorkbook,
        [EnumMember(Value = "ExcelWorkbookMacroEnabled")]
        ExcelMacroEnabledWorkbook,
        [EnumMember(Value = "ExcelTemplateMacroEnabled")]
        ExcelMacroEnabledTemplate,
        OpenDocumentSpreadsheet,
        ExcelTemplate,
        ExcelBinaryWorkbook,
        [EnumMember(Value = "Excel97to2003Workbook")]
        Excel972003Workbook,
        [EnumMember(Value = "Excel95to97Workbook")]
        Excel9597Workbook,
        [EnumMember(Value = "Excel97to2003Template")]
        Excel972003Template,
        [EnumMember(Value = "CSVUTF8")]
        CsvUtf8CommaDelimited,
        [EnumMember(Value = "CSVWindows")]
        CsvCommaDelimited
    }

    public class MSExcelSaveWorkbookAsCsvResponse
    {
        public string NewWorkbookName { get; set; }
    }

    public class MsExcelSaveWorkbookAsCsvInput
    {
        public MsExcelSaveWorkbookAsCsvInput(string saveFileName)
        {
            this.SaveFileName = saveFileName;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string WorkbookName { get; set; }

        [JsonProperty("SaveFilename", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SaveFileName { get; set; }

        [JsonProperty("DeleteExistingSaveFilename", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? DeleteExistingSaveFileName { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSExcelSaveWorkbookAsWithPasswordResponse
    {
        public string NewWorkbookName { get; set; }
    }

    public class MsExcelSaveWorkbookAsWithPasswordInput
    {
        public MsExcelSaveWorkbookAsWithPasswordInput(string saveFileName, string password)
        {
            this.SaveFileName = saveFileName;
            this.Password = password;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string WorkbookName { get; set; }

        [JsonProperty("SaveFilename", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SaveFileName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Password { get; set; }

        [JsonProperty("DeleteExistingSaveFilename", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? DeleteExistingSaveFileName { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public MsExcelSaveWorkbookAsWithPasswordInputExcelFileFormatType? ExcelFileFormat { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectmsoffice.MsExcelSaveWorkbookAsWithPasswordInputExcelFileFormatType.AutomaticFromFileExtension;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MsExcelSaveWorkbookAsWithPasswordInputExcelFileFormatType
    {
        [EnumMember(Value = "AutomaticByExtension")]
        AutomaticFromFileExtension,
        NotSpecified,
        ExcelWorkbook,
        [EnumMember(Value = "ExcelWorkbookMacroEnabled")]
        ExcelMacroEnabledWorkbook,
        [EnumMember(Value = "ExcelTemplateMacroEnabled")]
        ExcelMacroEnabledTemplate,
        ExcelTemplate,
        ExcelBinaryWorkbook,
        [EnumMember(Value = "Excel97to2003Workbook")]
        Excel972003Workbook,
        [EnumMember(Value = "Excel95to97Workbook")]
        Excel9597Workbook,
        [EnumMember(Value = "Excel97to2003Template")]
        Excel972003Template
    }

    public class MSExcelSaveCurrentWorkbookResponse
    {
        public string NewWorkbookName { get; set; }
    }

    public class MsExcelSaveCurrentWorkbookInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSExcelSaveCurrentWorkbookAsResponse
    {
        public string NewWorkbookName { get; set; }
    }

    public class MsExcelSaveCurrentWorkbookAsInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;

        [JsonProperty("SaveFilename")]
        public string SaveFileName { get; set; }

        [JsonProperty("DeleteExistingSaveFilename", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? DeleteExistingSaveFileName { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public MsExcelSaveCurrentWorkbookAsInputExcelFileFormatType? ExcelFileFormat { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectmsoffice.MsExcelSaveCurrentWorkbookAsInputExcelFileFormatType.AutomaticFromFileExtension;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MsExcelSaveCurrentWorkbookAsInputExcelFileFormatType
    {
        [EnumMember(Value = "AutomaticByExtension")]
        AutomaticFromFileExtension,
        NotSpecified,
        ExcelWorkbook,
        [EnumMember(Value = "ExcelWorkbookMacroEnabled")]
        ExcelMacroEnabledWorkbook,
        [EnumMember(Value = "ExcelTemplateMacroEnabled")]
        ExcelMacroEnabledTemplate,
        OpenDocumentSpreadsheet,
        ExcelTemplate,
        ExcelBinaryWorkbook,
        [EnumMember(Value = "Excel97to2003Workbook")]
        Excel972003Workbook,
        [EnumMember(Value = "Excel95to97Workbook")]
        Excel9597Workbook,
        [EnumMember(Value = "Excel97to2003Template")]
        Excel972003Template,
        [EnumMember(Value = "CSVUTF8")]
        CsvUtf8CommaDelimited,
        [EnumMember(Value = "CSVWindows")]
        CsvCommaDelimited
    }

    public class MSExcelSaveCurrentWorkbookAsCsvResponse
    {
        public string NewWorkbookName { get; set; }
    }

    public class MsExcelSaveCurrentWorkbookAsCsvInput
    {
        public MsExcelSaveCurrentWorkbookAsCsvInput(string saveFileName)
        {
            this.SaveFileName = saveFileName;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;

        [JsonProperty("SaveFilename", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SaveFileName { get; set; }

        [JsonProperty("DeleteExistingSaveFilename", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? DeleteExistingSaveFileName { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSExcelGetWorksheetNamesResponse
    {
        public JToken[] WorksheetNames { get; set; }
    }

    public class MsExcelGetWorksheetNamesInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string WorkbookName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSExcelGetWorksheetNameResponse
    {
        public string WorksheetName { get; set; }
    }

    public class MsExcelGetWorksheetNameInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string WorkbookName { get; set; }
        public int? Position { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MsExcelActivateWorksheetInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string WorkbookName { get; set; }
        public string WorksheetName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CreateIfMissing { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MsExcelCreateWorksheetInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string WorkbookName { get; set; }
        public string WorksheetName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MsExcelDeleteWorksheetInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string WorkbookName { get; set; }
        public string WorksheetName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSExcelGetWorksheetAsCollectionEnhancedResponse
    {
        public bool SheetExists { get; set; }
        public bool AnyMoreRowsToReturn { get; set; }
        public int FirstDataRowInReturnedCollection { get; set; }
        public int LastDataRowInReturnedCollection { get; set; }
        public int TotalNumberOfRowsInWorksheet { get; set; }

        [JsonProperty("WorksheetCollectionJSON")]
        public string WorksheetCollectionJson { get; set; }
    }

    public class MsExcelGetWorksheetAsCollectionEnhancedInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string WorkbookName { get; set; }
        public string WorksheetName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? UseHeader { get; set; } = true;
        public string StartCell { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaximumColumnNumber { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SkipBlankRows { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SkipColumnsWithNoHeader { get; set; } = false;
        public string KeyColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? GetRawData { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? IgnoreRowsWithLowCellCount { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxConcurrentBlankRows { get; set; } = -1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? FirstDataRowToReturn { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxNumberOfDataRowsToReturn { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSExcelGetNumberOfRowsResponse
    {
        public int NumberOfRows { get; set; }
    }

    public class MsExcelGetNumberOfRowsInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string WorkbookName { get; set; }
        public string WorksheetName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSExcelEvaluateExpressionResponse
    {
        public string ExpressionResult { get; set; }
    }

    public class MsExcelEvaluateExpressionInput
    {
        public MsExcelEvaluateExpressionInput(string expression)
        {
            this.Expression = expression;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Expression { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSExcelGetWorksheetUsedRangeResponse
    {
        public int Left { get; set; }
        public int Right { get; set; }
        public int Top { get; set; }
        public int Bottom { get; set; }
    }

    public class MsExcelGetWorksheetUsedRangeInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string WorkbookName { get; set; }
        public string WorksheetName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSExcelGetCountrySettingResponse
    {
        public int CountrySetting { get; set; }
    }

    public class MsExcelGetCountrySettingInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MsExcelWriteCollectionInput
    {
        public MsExcelWriteCollectionInput(string cellReference, string collectionToWriteJson)
        {
            this.CellReference = cellReference;
            this.CollectionToWriteJson = collectionToWriteJson;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string WorkbookName { get; set; }
        public string WorksheetName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string CellReference { get; set; }

        [JsonProperty("CollectionToWriteJSON", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CollectionToWriteJson { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IncludeColumnNames { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MsExcelWriteCollectionWithDatesInput
    {
        public MsExcelWriteCollectionWithDatesInput(string cellReference, string collectionToWriteJson)
        {
            this.CellReference = cellReference;
            this.CollectionToWriteJson = collectionToWriteJson;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string WorkbookName { get; set; }
        public string WorksheetName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string CellReference { get; set; }

        [JsonProperty("CollectionToWriteJSON", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CollectionToWriteJson { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IncludeColumnNames { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? TryToConvertAllFieldsToDate { get; set; } = false;

        [JsonProperty("ColumnsToConvertToDateJSON")]
        public string ColumnsToConvertToDateJson { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSExcelGetActiveCellResponse
    {
        public string CellReference { get; set; }
        public int RowIndex { get; set; }
        public int ColumnIndex { get; set; }
    }

    public class MsExcelGetActiveCellInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MsExcelFormatCellInput
    {
        public MsExcelFormatCellInput(string cellReference, string cellFormat)
        {
            this.CellReference = cellReference;
            this.CellFormat = cellFormat;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string WorkbookName { get; set; }
        public string WorksheetName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string CellReference { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string CellFormat { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MsExcelFormatCurrentCellInput
    {
        public MsExcelFormatCurrentCellInput(string cellFormat)
        {
            this.CellFormat = cellFormat;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string CellFormat { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MsExcelSelectCellRangeInput
    {
        public MsExcelSelectCellRangeInput(string cellReference)
        {
            this.CellReference = cellReference;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string WorkbookName { get; set; }
        public string WorksheetName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string CellReference { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? EntireRow { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? EntireColumn { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MsExcelCopySelectionInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string WorkbookName { get; set; }
        public string WorksheetName { get; set; }
        public string CellReference { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? EntireRow { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? EntireColumn { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MsExcelCutSelectionInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string WorkbookName { get; set; }
        public string WorksheetName { get; set; }
        public string CellReference { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? EntireRow { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? EntireColumn { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MsExcelPasteIntoSelectionInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string WorkbookName { get; set; }
        public string WorksheetName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ValuesOnly { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SimplePasteOnly { get; set; } = false;
        public string CellReference { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? EntireRow { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? EntireColumn { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MsExcelInsertOnSelectionInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string WorkbookName { get; set; }
        public string WorksheetName { get; set; }
        public string CellReference { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? EntireRow { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? EntireColumn { get; set; } = false;
        public MsExcelInsertOnSelectionInputShiftType? Shift { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MsExcelInsertOnSelectionInputShiftType
    {
        R,
        D
    }

    public class MsExcelDeleteSelectionInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string WorkbookName { get; set; }
        public string WorksheetName { get; set; }
        public string CellReference { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? EntireRow { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? EntireColumn { get; set; } = false;
        public MsExcelDeleteSelectionInputShiftType? Shift { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MsExcelDeleteSelectionInputShiftType
    {
        L,
        U
    }

    public class MsExcelClearExcelClipboardInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSExcelRunMacroResponse
    {
        public string Result { get; set; }
    }

    public class MsExcelRunMacroInput
    {
        public MsExcelRunMacroInput(string macroName)
        {
            this.MacroName = macroName;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string MacroName { get; set; }
        public int? NumberOfArguments { get; set; }
        public string Argument1 { get; set; }
        public string Argument2 { get; set; }
        public string Argument3 { get; set; }
        public string Argument4 { get; set; }
        public string Argument5 { get; set; }
        public string Argument6 { get; set; }
        public string Argument7 { get; set; }
        public string Argument8 { get; set; }
        public string Argument9 { get; set; }
        public string Argument10 { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RunInBackground { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MsExcelAddMacroToWorkbookInput
    {
        public MsExcelAddMacroToWorkbookInput(string macroCode)
        {
            this.MacroCode = macroCode;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string WorkbookName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string MacroCode { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MsExcelTrustVbomInRegistryInput
    {
        public int? ExcelVersion { get; set; }

        [JsonProperty("TrustVBOM", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? TrustVbom { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MsExcelSetCalculationModeInput
    {
        public MsExcelSetCalculationModeInput(int calculationMode)
        {
            this.CalculationMode = calculationMode;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int CalculationMode { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MsExcelExecuteCommandBarObjectInput
    {
        public MsExcelExecuteCommandBarObjectInput(string objectId)
        {
            this.ObjectId = objectId;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ObjectId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RunInBackground { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSExcelCopyBetweenCellsResponse
    {
        public bool MSExcelCopyBetweenCellsResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class MsExcelCopyBetweenCellsInput
    {
        public MsExcelCopyBetweenCellsInput(string sourceCellReference, string targetCellReference)
        {
            this.SourceCellReference = sourceCellReference;
            this.TargetCellReference = targetCellReference;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? SourceHandle { get; set; } = 0;
        public string SourceWorkbookName { get; set; }
        public string SourceWorksheetName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceCellReference { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SourceEntireRow { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SourceEntireColumn { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? TargetHandle { get; set; } = 0;
        public string TargetWorkbookName { get; set; }
        public string TargetWorksheetName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string TargetCellReference { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? TargetEntireRow { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? TargetEntireColumn { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ValuesOnly { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SimplePasteOnly { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSExcelCutBetweenCellsResponse
    {
        public bool MSExcelCutBetweenCellsResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class MsExcelCutBetweenCellsInput
    {
        public MsExcelCutBetweenCellsInput(string sourceCellReference, string targetCellReference)
        {
            this.SourceCellReference = sourceCellReference;
            this.TargetCellReference = targetCellReference;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? SourceHandle { get; set; } = 0;
        public string SourceWorkbookName { get; set; }
        public string SourceWorksheetName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceCellReference { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SourceEntireRow { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SourceEntireColumn { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? TargetHandle { get; set; } = 0;
        public string TargetWorkbookName { get; set; }
        public string TargetWorksheetName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string TargetCellReference { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? TargetEntireRow { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? TargetEntireColumn { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ValuesOnly { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSExcelMinimiseWindowResponse
    {
        public bool MSExcelMinimiseWindowResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class MsExcelMinimiseWindowInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSExcelMaximiseWindowResponse
    {
        public bool MSExcelMaximiseWindowResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class MsExcelMaximiseWindowInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSExcelNormaliseWindowResponse
    {
        public bool MSExcelNormaliseWindowResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class MsExcelNormaliseWindowInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSExcelGetAndSetCellValueResponse
    {
        public bool MSExcelGetAndSetCellValueResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class MsExcelGetAndSetCellValueInput
    {
        public MsExcelGetAndSetCellValueInput(string sourceCellReference, string targetCellReference)
        {
            this.SourceCellReference = sourceCellReference;
            this.TargetCellReference = targetCellReference;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? SourceHandle { get; set; } = 0;
        public string SourceWorkbookName { get; set; }
        public string SourceWorksheetName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceCellReference { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? TargetHandle { get; set; } = 0;
        public string TargetWorkbookName { get; set; }
        public string TargetWorksheetName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string TargetCellReference { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSExcelGetAndSetCellValue2Response
    {
        public bool MSExcelGetAndSetCellValue2Result { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class MsExcelGetAndSetCellValue2Input
    {
        public MsExcelGetAndSetCellValue2Input(string sourceCellReference, string targetCellReference)
        {
            this.SourceCellReference = sourceCellReference;
            this.TargetCellReference = targetCellReference;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? SourceHandle { get; set; } = 0;
        public string SourceWorkbookName { get; set; }
        public string SourceWorksheetName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceCellReference { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? TargetHandle { get; set; } = 0;
        public string TargetWorkbookName { get; set; }
        public string TargetWorksheetName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string TargetCellReference { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSExcelGetAndSetCellTextResponse
    {
        public bool MSExcelGetAndSetCellTextResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class MsExcelGetAndSetCellTextInput
    {
        public MsExcelGetAndSetCellTextInput(string sourceCellReference, string targetCellReference)
        {
            this.SourceCellReference = sourceCellReference;
            this.TargetCellReference = targetCellReference;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? SourceHandle { get; set; } = 0;
        public string SourceWorkbookName { get; set; }
        public string SourceWorksheetName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceCellReference { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? TargetHandle { get; set; } = 0;
        public string TargetWorkbookName { get; set; }
        public string TargetWorksheetName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string TargetCellReference { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSExcelCheckOleObjectResponse
    {
        [JsonProperty("MSExcelCheckOLEObjectResult")]
        public bool MSExcelCheckOleObjectResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class MsExcelCheckOleObjectInput
    {
        public MsExcelCheckOleObjectInput(string oleObjectName)
        {
            this.OleObjectName = oleObjectName;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string WorkbookName { get; set; }
        public string WorksheetName { get; set; }

        [JsonProperty("OLEObjectName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string OleObjectName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Checked { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RunInBackground { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSExcelInputTextIntoOleObjectResponse
    {
        [JsonProperty("MSExcelInputTextIntoOLEObjectResult")]
        public bool MSExcelInputTextIntoOleObjectResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class MsExcelInputTextIntoOleObjectInput
    {
        public MsExcelInputTextIntoOleObjectInput(string oleObjectName)
        {
            this.OleObjectName = oleObjectName;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string WorkbookName { get; set; }
        public string WorksheetName { get; set; }

        [JsonProperty("OLEObjectName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string OleObjectName { get; set; }
        public string TextToInput { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RunInBackground { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSExcelSetCellBackgroundColourResponse
    {
        public bool MSExcelSetCellBackgroundColourResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class MsExcelSetCellBackgroundColourInput
    {
        public MsExcelSetCellBackgroundColourInput(string cellReference, int colourIndex)
        {
            this.CellReference = cellReference;
            this.ColourIndex = colourIndex;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string WorkbookName { get; set; }
        public string WorksheetName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string CellReference { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ColourIndex { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSExcelGetCellBackgroundColourResponse
    {
        public int ColourIndex { get; set; }
    }

    public class MsExcelGetCellBackgroundColourInput
    {
        public MsExcelGetCellBackgroundColourInput(string cellReference)
        {
            this.CellReference = cellReference;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string WorkbookName { get; set; }
        public string WorksheetName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string CellReference { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSExcelGetOleObjectValueResponse
    {
        [JsonProperty("OLEObjectValue")]
        public string OleObjectValue { get; set; }
    }

    public class MsExcelGetOleObjectValueInput
    {
        public MsExcelGetOleObjectValueInput(string oleObjectName)
        {
            this.OleObjectName = oleObjectName;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string WorkbookName { get; set; }
        public string WorksheetName { get; set; }

        [JsonProperty("OLEObjectName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string OleObjectName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSExcelDoesOleObjectExistResponse
    {
        [JsonProperty("OLEObjectExists")]
        public bool OleObjectExists { get; set; }
    }

    public class MsExcelDoesOleObjectExistInput
    {
        public MsExcelDoesOleObjectExistInput(string oleObjectName)
        {
            this.OleObjectName = oleObjectName;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string WorkbookName { get; set; }
        public string WorksheetName { get; set; }

        [JsonProperty("OLEObjectName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string OleObjectName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSExcelPressOleObjectResponse
    {
        [JsonProperty("MSExcelPressOLEObjectResult")]
        public bool MSExcelPressOleObjectResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class MsExcelPressOleObjectInput
    {
        public MsExcelPressOleObjectInput(string oleObjectName)
        {
            this.OleObjectName = oleObjectName;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string WorkbookName { get; set; }
        public string WorksheetName { get; set; }

        [JsonProperty("OLEObjectName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string OleObjectName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RunInBackground { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSExcelSetWorksheetSensitivityLabelResponse
    {
        public bool MSExcelSetWorksheetSensitivityLabelResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class MsExcelSetWorksheetSensitivityLabelInput
    {
        public MsExcelSetWorksheetSensitivityLabelInput(string labelId)
        {
            this.LabelId = labelId;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string WorkbookName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public MsExcelSetWorksheetSensitivityLabelInputAssignmentMethodType AssignmentMethod { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectmsoffice.MsExcelSetWorksheetSensitivityLabelInputAssignmentMethodType.NotSet;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string LabelId { get; set; }
        public string LabelName { get; set; }
        public string SiteId { get; set; }
        public string Justification { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MsExcelSetWorksheetSensitivityLabelInputAssignmentMethodType
    {
        [EnumMember(Value = "NOT_SET")]
        NotSet,
        [EnumMember(Value = "STANDARD")]
        Standard,
        [EnumMember(Value = "PRIVILEGED")]
        Priviledged,
        [EnumMember(Value = "AUTO")]
        Auto
    }

    public class MSExcelGetWorksheetSensitivityLabelResponse
    {
        public string AssignmentMethod { get; set; }
        public string LabelId { get; set; }
        public string LabelName { get; set; }
        public string SiteId { get; set; }
        public string Justification { get; set; }
        public string SetDate { get; set; }
    }

    public class MsExcelGetWorksheetSensitivityLabelInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string WorkbookName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSExcelWriteArrayResponse
    {
        public bool MSExcelWriteArrayResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class MsExcelWriteArrayInput
    {
        public MsExcelWriteArrayInput(string cellReference, string arrayToWriteJson)
        {
            this.CellReference = cellReference;
            this.ArrayToWriteJson = arrayToWriteJson;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string WorkbookName { get; set; }
        public string WorksheetName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string CellReference { get; set; }

        [JsonProperty("ArrayToWriteJSON", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ArrayToWriteJson { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public MsExcelWriteArrayInputDirectionType Direction { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectmsoffice.MsExcelWriteArrayInputDirectionType.R;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MsExcelWriteArrayInputDirectionType
    {
        U,
        D,
        L,
        R
    }

    public class MSOutlookCreateInstanceResponse
    {
        public string CurrentProfileName { get; set; }
    }

    public class MsOutlookCreateInstanceInput
    {
        public string ProfileName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ShowOutlook { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MsOutlookCloseInstanceInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? SecondsToWaitForProcessToClose { get; set; } = 10;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MsOutlookCloseInstanceUsingWindowInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? UseNativeWindow { get; set; } = true;

        [JsonProperty("UseUIA", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? UseUia { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? SecondsToWaitForProcessToClose { get; set; } = 10;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSOutlookAttachToExistingInstanceResponse
    {
        public string CurrentProfileName { get; set; }
    }

    public class MsOutlookAttachToExistingInstanceInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ToggleWindow { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ToggleUsesGlobalLeftMouseClickAgent { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? ToggleDelay { get; set; } = 0.5;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSOutlookIsConnectedResponse
    {
        public bool IsOutlookConnected { get; set; }
    }

    public class MsOutlookIsConnectedInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MsOutlookShowInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSOutlookGetNamespaceInformationResponse
    {
        public string CurrentProfileName { get; set; }
        public string ExchangeMailBoxServerName { get; set; }
        public string ExchangeMailBoxServerVersion { get; set; }
        public bool Offline { get; set; }
        public string CurrentUserAddress { get; set; }
        public string CurrentUserName { get; set; }
        public string ApplicationName { get; set; }
        public string ApplicationVersion { get; set; }
    }

    public class MsOutlookGetNamespaceInformationInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSOutlookGetMailFoldersResponse
    {
        [JsonProperty("MailFoldersJSON")]
        public string MailFoldersJson { get; set; }
    }

    public class MsOutlookGetMailFoldersInput
    {
        public string FolderPath { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SubFolders { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MsOutlookMarkEmailAsReadInput
    {
        public MsOutlookMarkEmailAsReadInput(string entryId)
        {
            this.EntryId = entryId;
        }

        [JsonProperty("EntryID", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EntryId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Read { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSOutlookGetEmailBodyResponse
    {
        public string BodyFormat { get; set; }
        public string PlainBody { get; set; }
        public string FormattedBody { get; set; }
    }

    public class MsOutlookGetEmailBodyInput
    {
        public MsOutlookGetEmailBodyInput(string entryId)
        {
            this.EntryId = entryId;
        }

        [JsonProperty("EntryID", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EntryId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ClickAllowButtonIfRequired { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSOutlookGetEmailAttachmentFilenamesResponse
    {
        public int NumberOfAttachments { get; set; }

        [JsonProperty("EmailAttachmentFilenamesJSON")]
        public string EmailAttachmentFilenamesJson { get; set; }
    }

    public class MsOutlookGetEmailAttachmentFilenamesInput
    {
        public MsOutlookGetEmailAttachmentFilenamesInput(string entryId)
        {
            this.EntryId = entryId;
        }

        [JsonProperty("EntryID", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EntryId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ClickAllowButtonIfRequired { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSOutlookSaveEmailAttachmentsAsFileResponse
    {
        public int NumberOfSavedAttachments { get; set; }
        public int NumberOfAttachmentsFailedToSave { get; set; }
        public int NumberOfAttachmentsNotMatchingWildcard { get; set; }
        public int NumberOfAttachmentsSkipped { get; set; }

        [JsonProperty("EmailAttachmentSaveAsFilenamesJSON")]
        public string EmailAttachmentSaveAsFilenamesJson { get; set; }
    }

    public class MsOutlookSaveEmailAttachmentsAsFileInput
    {
        public MsOutlookSaveEmailAttachmentsAsFileInput(string entryId)
        {
            this.EntryId = entryId;
        }

        [JsonProperty("EntryID", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EntryId { get; set; }
        public string SaveFolderPath { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CreateFolder { get; set; } = true;
        public string OnlySaveAttachmentsMatchingWildcard { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SaveHiddenAttachments { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ClickAllowButtonIfRequired { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MsOutlookDeleteEmailInput
    {
        public MsOutlookDeleteEmailInput(string entryId)
        {
            this.EntryId = entryId;
        }

        [JsonProperty("EntryID", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EntryId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MsOutlookMoveEmailInput
    {
        public MsOutlookMoveEmailInput(string entryId)
        {
            this.EntryId = entryId;
        }

        [JsonProperty("EntryID", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EntryId { get; set; }
        public string DestinationFolder { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MsOutlookSendEmailInput
    {
        public string To { get; set; }
        public string CC { get; set; }

        [JsonProperty("BCC")]
        public string Bcc { get; set; }
        public string Subject { get; set; }
        public MsOutlookSendEmailInputBodyFormatType? BodyFormat { get; set; }
        public string Body { get; set; }

        [JsonProperty("HTMLBody")]
        public string HtmlBody { get; set; }

        [JsonProperty("RTFBody")]
        public string RtfBody { get; set; }

        [JsonProperty("AttachmentFilenamesJSON")]
        public string AttachmentFilenamesJson { get; set; }

        [JsonProperty("DontSendIfAttachmentFilenameMissing", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? DontSendIfAttachmentFileNameMissing { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ClickAllowButtonIfRequired { get; set; } = true;
        public string VotingOptions { get; set; }

        [JsonProperty("SendAsSMTPAddress")]
        public string SendAsSmtpAddress { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? BodyContainsStoredPassword { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MsOutlookSendEmailInputBodyFormatType
    {
        [EnumMember(Value = "HTML")]
        Html,
        Plain,
        [EnumMember(Value = "RTF")]
        Rtf
    }

    public class MsOutlookCreateMailFolderInput
    {
        public string ParentFolderPath { get; set; }
        public string NewFolderName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MsOutlookReplyToEmailInput
    {
        public MsOutlookReplyToEmailInput(string entryId)
        {
            this.EntryId = entryId;
        }

        [JsonProperty("EntryID", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EntryId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReplyToAll { get; set; } = false;
        public MsOutlookReplyToEmailInputBodyFormatType? BodyFormat { get; set; }
        public string Body { get; set; }

        [JsonProperty("HTMLBody")]
        public string HtmlBody { get; set; }

        [JsonProperty("RTFBody")]
        public string RtfBody { get; set; }

        [JsonProperty("AttachmentFilenamesJSON")]
        public string AttachmentFilenamesJson { get; set; }

        [JsonProperty("DontSendIfAttachmentFilenameMissing", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? DontSendIfAttachmentFileNameMissing { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ClickAllowButtonIfRequired { get; set; } = true;
        public string VotingOptions { get; set; }

        [JsonProperty("SendAsSMTPAddress")]
        public string SendAsSmtpAddress { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? BodyContainsStoredPassword { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MsOutlookReplyToEmailInputBodyFormatType
    {
        [EnumMember(Value = "HTML")]
        Html,
        Plain,
        [EnumMember(Value = "RTF")]
        Rtf
    }

    public class MsOutlookForwardEmailInput
    {
        public MsOutlookForwardEmailInput(string entryId)
        {
            this.EntryId = entryId;
        }

        [JsonProperty("EntryID", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EntryId { get; set; }
        public string To { get; set; }
        public string CC { get; set; }

        [JsonProperty("BCC")]
        public string Bcc { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OverrideSubject { get; set; } = false;
        public string Subject { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OverrideBody { get; set; } = false;
        public MsOutlookForwardEmailInputBodyFormatType? BodyFormat { get; set; }
        public string Body { get; set; }

        [JsonProperty("HTMLBody")]
        public string HtmlBody { get; set; }

        [JsonProperty("RTFBody")]
        public string RtfBody { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ClickAllowButtonIfRequired { get; set; } = true;
        public string VotingOptions { get; set; }

        [JsonProperty("SendAsSMTPAddress")]
        public string SendAsSmtpAddress { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IncludeExistingHiddenAttachments { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IncludeExistingVisibleAttachments { get; set; } = false;

        [JsonProperty("AttachmentFilenamesJSON")]
        public string AttachmentFilenamesJson { get; set; }

        [JsonProperty("DontSendIfAttachmentFilenameMissing", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? DontSendIfAttachmentFileNameMissing { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? BodyContainsStoredPassword { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MsOutlookForwardEmailInputBodyFormatType
    {
        [EnumMember(Value = "HTML")]
        Html,
        Plain,
        [EnumMember(Value = "RTF")]
        Rtf
    }

    public class MSOutlookGetMapiProfilesResponse
    {
        [JsonProperty("NumberOfMAPIProfiles")]
        public int NumberOfMapiProfiles { get; set; }

        [JsonProperty("MAPIProfilesJSON")]
        public string MapiProfilesJson { get; set; }

        [JsonProperty("DefaultMAPIProfile")]
        public string DefaultMapiProfile { get; set; }
    }

    public class MsOutlookGetMapiProfilesInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSOutlookGetOutlookProcessIdResponse
    {
        public int ProcessId { get; set; }
    }

    public class MsOutlookGetOutlookProcessIdInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MsOutlookBackgroundMonitorForAllowPopupInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? SecondsToWaitForDialog { get; set; } = 10;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? SecondsToWaitForAllowButton { get; set; } = 10;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? SecondsToWaitForAllowButtonToBeEnabled { get; set; } = 10;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string OutlookAllowButtonName { get; set; } = "Allow";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MsOutlookSetAllowPopupDetailsInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string OutlookAllowButtonName { get; set; } = "Allow";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string OutlookAllowButtonAutomationId { get; set; } = "4774";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string OutlookAllowCheckboxAutomationId { get; set; } = "4771";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSOutlookExecuteCommandBarObjectResponse
    {
        public bool MSOutlookExecuteCommandBarObjectResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class MsOutlookExecuteCommandBarObjectInput
    {
        public MsOutlookExecuteCommandBarObjectInput(string objectId)
        {
            this.ObjectId = objectId;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ObjectId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RunInBackground { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSOutlookGetEmailsResponse
    {
        public int NumberOfEmailsMatchFilter { get; set; }
        public int NumberOfEmailsReturned { get; set; }

        [JsonProperty("EmailsJSON")]
        public string EmailsJson { get; set; }
    }

    public class MsOutlookGetEmailsInput
    {
        public string FolderPath { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchRead { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchUnread { get; set; } = true;
        public string SearchSubject { get; set; }

        [JsonProperty("SearchFromSMTP")]
        public string SearchFromSmtp { get; set; }
        public string SearchFromName { get; set; }
        public string SearchQuery { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? SearchMaxAgeInDays { get; set; } = -1;
        public string SearchStartDateTimeAsString { get; set; }
        public string SearchEndDateTimeAsString { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxResultsToReturn { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ClickAllowButtonIfRequired { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSOutlookGetFirstEmailResponse
    {
        public int NumberOfEmailsMatchFilter { get; set; }

        [JsonProperty("EmailEntryID")]
        public string EmailEntryId { get; set; }
        public string SenderEmailType { get; set; }
        public string SenderEmailAddress { get; set; }
        public string ReceivedByName { get; set; }
        public string To { get; set; }
        public string EmailSubject { get; set; }
        public bool EmailRead { get; set; }
        public string SentOnAsString { get; set; }
        public int NumberOfAttachments { get; set; }
    }

    public class MsOutlookGetFirstEmailInput
    {
        public string FolderPath { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchRead { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchUnread { get; set; } = true;
        public string SearchSubject { get; set; }

        [JsonProperty("SearchFromSMTP")]
        public string SearchFromSmtp { get; set; }
        public string SearchFromName { get; set; }
        public string SearchQuery { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? SearchMaxAgeInDays { get; set; } = -1;
        public string SearchStartDateTimeAsString { get; set; }
        public string SearchEndDateTimeAsString { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ClickAllowButtonIfRequired { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSOutlookGetNumberOfEmailsResponse
    {
        public int NumberOfEmailsMatchFilter { get; set; }
    }

    public class MsOutlookGetNumberOfEmailsInput
    {
        public string FolderPath { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchRead { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchUnread { get; set; } = true;
        public string SearchSubject { get; set; }

        [JsonProperty("SearchFromSMTP")]
        public string SearchFromSmtp { get; set; }
        public string SearchFromName { get; set; }
        public string SearchQuery { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? SearchMaxAgeInDays { get; set; } = -1;
        public string SearchStartDateTimeAsString { get; set; }
        public string SearchEndDateTimeAsString { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectmsoffice;

    public partial class WorkflowManagedActions
    {
        public IaconnectmsofficeActions Iaconnectmsoffice(string connectionId) => new IaconnectmsofficeActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public IaconnectmsofficeTriggers Iaconnectmsoffice(string connectionId) => new IaconnectmsofficeTriggers(connectionId);
    }
}