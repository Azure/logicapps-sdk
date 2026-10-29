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
        public IBodyWorkflowAction<MSWordCreateInstanceResponse, ApiConnectionActionConfiguration> MSWordCreateInstance(Expression<Func<MSWordCreateInstanceInput>> mSWordCreateInstance)
        {
            var __workflow_mSWordCreateInstance = WorkflowExpression.Compile(mSWordCreateInstance, nameof(mSWordCreateInstance), required: true);
            return new DeferredBodyAction<MSWordCreateInstanceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSWord/CreateInstance";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSWordCreateInstance);
                return new ApiConnectionAction<MSWordCreateInstanceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSWordCloseInstance(Expression<Func<MSWordCloseInstanceInput>> mSWordCloseInstance)
        {
            var __workflow_mSWordCloseInstance = WorkflowExpression.Compile(mSWordCloseInstance, nameof(mSWordCloseInstance), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSWord/CloseInstance";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSWordCloseInstance);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSWordDetachFromInstance(Expression<Func<MSWordDetachFromInstanceInput>> mSWordDetachFromInstance)
        {
            var __workflow_mSWordDetachFromInstance = WorkflowExpression.Compile(mSWordDetachFromInstance, nameof(mSWordDetachFromInstance), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSWord/DetachFromInstance";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSWordDetachFromInstance);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordAttachToExistingInstanceResponse, ApiConnectionActionConfiguration> MSWordAttachToExistingInstance(Expression<Func<MSWordAttachToExistingInstanceInput>> mSWordAttachToExistingInstance)
        {
            var __workflow_mSWordAttachToExistingInstance = WorkflowExpression.Compile(mSWordAttachToExistingInstance, nameof(mSWordAttachToExistingInstance), required: true);
            return new DeferredBodyAction<MSWordAttachToExistingInstanceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSWord/AttachToExistingInstance";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSWordAttachToExistingInstance);
                return new ApiConnectionAction<MSWordAttachToExistingInstanceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSWordShowWord(Expression<Func<MSWordShowWordInput>> mSWordShowWord)
        {
            var __workflow_mSWordShowWord = WorkflowExpression.Compile(mSWordShowWord, nameof(mSWordShowWord), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSWord/ShowWord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSWordShowWord);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSWordHideWord(Expression<Func<MSWordHideWordInput>> mSWordHideWord)
        {
            var __workflow_mSWordHideWord = WorkflowExpression.Compile(mSWordHideWord, nameof(mSWordHideWord), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSWord/HideWord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSWordHideWord);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordCreateDocumentResponse, ApiConnectionActionConfiguration> MSWordCreateDocument(Expression<Func<MSWordCreateDocumentInput>> mSWordCreateDocument)
        {
            var __workflow_mSWordCreateDocument = WorkflowExpression.Compile(mSWordCreateDocument, nameof(mSWordCreateDocument), required: true);
            return new DeferredBodyAction<MSWordCreateDocumentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSWord/CreateDocument";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSWordCreateDocument);
                return new ApiConnectionAction<MSWordCreateDocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordOpenDocumentResponse, ApiConnectionActionConfiguration> MSWordOpenDocument(Expression<Func<MSWordOpenDocumentInput>> mSWordOpenDocument)
        {
            var __workflow_mSWordOpenDocument = WorkflowExpression.Compile(mSWordOpenDocument, nameof(mSWordOpenDocument), required: true);
            return new DeferredBodyAction<MSWordOpenDocumentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSWord/OpenDocument";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSWordOpenDocument);
                return new ApiConnectionAction<MSWordOpenDocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSWordSaveDocument(Expression<Func<MSWordSaveDocumentInput>> mSWordSaveDocument)
        {
            var __workflow_mSWordSaveDocument = WorkflowExpression.Compile(mSWordSaveDocument, nameof(mSWordSaveDocument), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSWord/Save";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSWordSaveDocument);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordSaveAsDocumentResponse, ApiConnectionActionConfiguration> MSWordSaveAsDocument(Expression<Func<MSWordSaveAsDocumentInput>> mSWordSaveAsDocument)
        {
            var __workflow_mSWordSaveAsDocument = WorkflowExpression.Compile(mSWordSaveAsDocument, nameof(mSWordSaveAsDocument), required: true);
            return new DeferredBodyAction<MSWordSaveAsDocumentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSWord/SaveAs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSWordSaveAsDocument);
                return new ApiConnectionAction<MSWordSaveAsDocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSWordCloseDocument(Expression<Func<MSWordCloseDocumentInput>> mSWordCloseDocument)
        {
            var __workflow_mSWordCloseDocument = WorkflowExpression.Compile(mSWordCloseDocument, nameof(mSWordCloseDocument), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSWord/CloseDocument";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSWordCloseDocument);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSWordTypeText(Expression<Func<MSWordTypeTextInput>> mSWordTypeText)
        {
            var __workflow_mSWordTypeText = WorkflowExpression.Compile(mSWordTypeText, nameof(mSWordTypeText), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSWord/TypeText";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSWordTypeText);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSWordSelectAll(Expression<Func<MSWordSelectAllInput>> mSWordSelectAll)
        {
            var __workflow_mSWordSelectAll = WorkflowExpression.Compile(mSWordSelectAll, nameof(mSWordSelectAll), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSWord/SelectAll";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSWordSelectAll);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSWordSelectRange(Expression<Func<MSWordSelectRangeInput>> mSWordSelectRange)
        {
            var __workflow_mSWordSelectRange = WorkflowExpression.Compile(mSWordSelectRange, nameof(mSWordSelectRange), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSWord/SelectRange";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSWordSelectRange);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSWordCopyToClipboard(Expression<Func<MSWordCopyToClipboardInput>> mSWordCopyToClipboard)
        {
            var __workflow_mSWordCopyToClipboard = WorkflowExpression.Compile(mSWordCopyToClipboard, nameof(mSWordCopyToClipboard), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSWord/CopyToClipboard";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSWordCopyToClipboard);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSWordPasteFromClipboard(Expression<Func<MSWordPasteFromClipboardInput>> mSWordPasteFromClipboard)
        {
            var __workflow_mSWordPasteFromClipboard = WorkflowExpression.Compile(mSWordPasteFromClipboard, nameof(mSWordPasteFromClipboard), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSWord/PasteFromClipboard";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSWordPasteFromClipboard);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSWordClearClipboard(Expression<Func<MSWordClearClipboardInput>> mSWordClearClipboard)
        {
            var __workflow_mSWordClearClipboard = WorkflowExpression.Compile(mSWordClearClipboard, nameof(mSWordClearClipboard), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSWord/ClearClipboard";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSWordClearClipboard);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordGetDocumentBodyTextResponse, ApiConnectionActionConfiguration> MSWordGetDocumentBodyText(Expression<Func<MSWordGetDocumentBodyTextInput>> mSWordGetDocumentBodyText)
        {
            var __workflow_mSWordGetDocumentBodyText = WorkflowExpression.Compile(mSWordGetDocumentBodyText, nameof(mSWordGetDocumentBodyText), required: true);
            return new DeferredBodyAction<MSWordGetDocumentBodyTextResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSWord/GetDocumentBodyText";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSWordGetDocumentBodyText);
                return new ApiConnectionAction<MSWordGetDocumentBodyTextResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordGetNumberOfTablesInDocumentResponse, ApiConnectionActionConfiguration> MSWordGetNumberOfTablesInDocument(Expression<Func<MSWordGetNumberOfTablesInDocumentInput>> mSWordGetNumberOfTablesInDocument)
        {
            var __workflow_mSWordGetNumberOfTablesInDocument = WorkflowExpression.Compile(mSWordGetNumberOfTablesInDocument, nameof(mSWordGetNumberOfTablesInDocument), required: true);
            return new DeferredBodyAction<MSWordGetNumberOfTablesInDocumentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSWord/GetNumberOfTablesInDocument";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSWordGetNumberOfTablesInDocument);
                return new ApiConnectionAction<MSWordGetNumberOfTablesInDocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSWordUpdateBookmark(Expression<Func<MSWordUpdateBookmarkInput>> mSWordUpdateBookmark)
        {
            var __workflow_mSWordUpdateBookmark = WorkflowExpression.Compile(mSWordUpdateBookmark, nameof(mSWordUpdateBookmark), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSWord/UpdateBookmark";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSWordUpdateBookmark);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSWordSelectTable(Expression<Func<MSWordSelectTableInput>> mSWordSelectTable)
        {
            var __workflow_mSWordSelectTable = WorkflowExpression.Compile(mSWordSelectTable, nameof(mSWordSelectTable), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSWord/SelectTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSWordSelectTable);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordGetTableBoundsResponse, ApiConnectionActionConfiguration> MSWordGetTableBounds(Expression<Func<MSWordGetTableBoundsInput>> mSWordGetTableBounds)
        {
            var __workflow_mSWordGetTableBounds = WorkflowExpression.Compile(mSWordGetTableBounds, nameof(mSWordGetTableBounds), required: true);
            return new DeferredBodyAction<MSWordGetTableBoundsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSWord/GetTableBounds";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSWordGetTableBounds);
                return new ApiConnectionAction<MSWordGetTableBoundsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSWordSelectTableCell(Expression<Func<MSWordSelectTableCellInput>> mSWordSelectTableCell)
        {
            var __workflow_mSWordSelectTableCell = WorkflowExpression.Compile(mSWordSelectTableCell, nameof(mSWordSelectTableCell), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSWord/SelectTableCell";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSWordSelectTableCell);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordGetTableCellTextValueResponse, ApiConnectionActionConfiguration> MSWordGetTableCellTextValue(Expression<Func<MSWordGetTableCellTextValueInput>> mSWordGetTableCellTextValue)
        {
            var __workflow_mSWordGetTableCellTextValue = WorkflowExpression.Compile(mSWordGetTableCellTextValue, nameof(mSWordGetTableCellTextValue), required: true);
            return new DeferredBodyAction<MSWordGetTableCellTextValueResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSWord/GetTableCellTextValue";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSWordGetTableCellTextValue);
                return new ApiConnectionAction<MSWordGetTableCellTextValueResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordGetTableCellTextValueTrimmedResponse, ApiConnectionActionConfiguration> MSWordGetTableCellTextValueTrimmed(Expression<Func<MSWordGetTableCellTextValueTrimmedInput>> mSWordGetTableCellTextValueTrimmed)
        {
            var __workflow_mSWordGetTableCellTextValueTrimmed = WorkflowExpression.Compile(mSWordGetTableCellTextValueTrimmed, nameof(mSWordGetTableCellTextValueTrimmed), required: true);
            return new DeferredBodyAction<MSWordGetTableCellTextValueTrimmedResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSWord/GetTableCellTextValueTrimmed";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSWordGetTableCellTextValueTrimmed);
                return new ApiConnectionAction<MSWordGetTableCellTextValueTrimmedResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSWordSetTableCellTextValue(Expression<Func<MSWordSetTableCellTextValueInput>> mSWordSetTableCellTextValue)
        {
            var __workflow_mSWordSetTableCellTextValue = WorkflowExpression.Compile(mSWordSetTableCellTextValue, nameof(mSWordSetTableCellTextValue), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSWord/SetTableCellTextValue";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSWordSetTableCellTextValue);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSWordExportDocumentAsPDF(Expression<Func<MSWordExportDocumentAsPDFInput>> mSWordExportDocumentAsPDF)
        {
            var __workflow_mSWordExportDocumentAsPDF = WorkflowExpression.Compile(mSWordExportDocumentAsPDF, nameof(mSWordExportDocumentAsPDF), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSWord/ExportDocumentAsPDF";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSWordExportDocumentAsPDF);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSWordAddTable(Expression<Func<MSWordAddTableInput>> mSWordAddTable)
        {
            var __workflow_mSWordAddTable = WorkflowExpression.Compile(mSWordAddTable, nameof(mSWordAddTable), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSWord/AddTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSWordAddTable);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSWordAddTableRow(Expression<Func<MSWordAddTableRowInput>> mSWordAddTableRow)
        {
            var __workflow_mSWordAddTableRow = WorkflowExpression.Compile(mSWordAddTableRow, nameof(mSWordAddTableRow), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSWord/AddTableRow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSWordAddTableRow);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSWordAddTableColumn(Expression<Func<MSWordAddTableColumnInput>> mSWordAddTableColumn)
        {
            var __workflow_mSWordAddTableColumn = WorkflowExpression.Compile(mSWordAddTableColumn, nameof(mSWordAddTableColumn), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSWord/AddTableColumn";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSWordAddTableColumn);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordGetHighlightedTextResponse, ApiConnectionActionConfiguration> MSWordGetHighlightedText(Expression<Func<MSWordGetHighlightedTextInput>> mSWordGetHighlightedText)
        {
            var __workflow_mSWordGetHighlightedText = WorkflowExpression.Compile(mSWordGetHighlightedText, nameof(mSWordGetHighlightedText), required: true);
            return new DeferredBodyAction<MSWordGetHighlightedTextResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSWord/GetHighlightedText";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSWordGetHighlightedText);
                return new ApiConnectionAction<MSWordGetHighlightedTextResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordExecuteCommandBarObjectResponse, ApiConnectionActionConfiguration> MSWordExecuteCommandBarObject(Expression<Func<MSWordExecuteCommandBarObjectInput>> mSWordExecuteCommandBarObject)
        {
            var __workflow_mSWordExecuteCommandBarObject = WorkflowExpression.Compile(mSWordExecuteCommandBarObject, nameof(mSWordExecuteCommandBarObject), required: true);
            return new DeferredBodyAction<MSWordExecuteCommandBarObjectResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSWord/ExecuteCommandBarObject";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSWordExecuteCommandBarObject);
                return new ApiConnectionAction<MSWordExecuteCommandBarObjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordSetDocumentSensitivityLabelResponse, ApiConnectionActionConfiguration> MSWordSetDocumentSensitivityLabel(Expression<Func<MSWordSetDocumentSensitivityLabelInput>> mSWordSetDocumentSensitivityLabel)
        {
            var __workflow_mSWordSetDocumentSensitivityLabel = WorkflowExpression.Compile(mSWordSetDocumentSensitivityLabel, nameof(mSWordSetDocumentSensitivityLabel), required: true);
            return new DeferredBodyAction<MSWordSetDocumentSensitivityLabelResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSWord/MSWordSetDocumentSensitivityLabel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSWordSetDocumentSensitivityLabel);
                return new ApiConnectionAction<MSWordSetDocumentSensitivityLabelResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordGetDocumentSensitivityLabelResponse, ApiConnectionActionConfiguration> MSWordGetDocumentSensitivityLabel(Expression<Func<MSWordGetDocumentSensitivityLabelInput>> mSWordGetDocumentSensitivityLabel)
        {
            var __workflow_mSWordGetDocumentSensitivityLabel = WorkflowExpression.Compile(mSWordGetDocumentSensitivityLabel, nameof(mSWordGetDocumentSensitivityLabel), required: true);
            return new DeferredBodyAction<MSWordGetDocumentSensitivityLabelResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSWord/MSWordGetDocumentSensitivityLabel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSWordGetDocumentSensitivityLabel);
                return new ApiConnectionAction<MSWordGetDocumentSensitivityLabelResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelCreateInstanceResponse, ApiConnectionActionConfiguration> MSExcelCreateInstance(Expression<Func<MSExcelCreateInstanceInput>> mSExcelCreateInstance)
        {
            var __workflow_mSExcelCreateInstance = WorkflowExpression.Compile(mSExcelCreateInstance, nameof(mSExcelCreateInstance), required: true);
            return new DeferredBodyAction<MSExcelCreateInstanceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/CreateInstance";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSExcelCreateInstance);
                return new ApiConnectionAction<MSExcelCreateInstanceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSExcelCloseInstance(Expression<Func<MSExcelCloseInstanceInput>> mSExcelCloseInstance)
        {
            var __workflow_mSExcelCloseInstance = WorkflowExpression.Compile(mSExcelCloseInstance, nameof(mSExcelCloseInstance), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/CloseInstance";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSExcelCloseInstance);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelAttachToExistingInstanceResponse, ApiConnectionActionConfiguration> MSExcelAttachToExistingInstance(Expression<Func<MSExcelAttachToExistingInstanceInput>> mSExcelAttachToExistingInstance)
        {
            var __workflow_mSExcelAttachToExistingInstance = WorkflowExpression.Compile(mSExcelAttachToExistingInstance, nameof(mSExcelAttachToExistingInstance), required: true);
            return new DeferredBodyAction<MSExcelAttachToExistingInstanceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/MSExcelAttachToExistingInstance";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSExcelAttachToExistingInstance);
                return new ApiConnectionAction<MSExcelAttachToExistingInstanceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSExcelShowExcel(Expression<Func<MSExcelShowExcelInput>> mSExcelShowExcel)
        {
            var __workflow_mSExcelShowExcel = WorkflowExpression.Compile(mSExcelShowExcel, nameof(mSExcelShowExcel), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/ShowExcel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSExcelShowExcel);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSExcelHideExcel(Expression<Func<MSExcelHideExcelInput>> mSExcelHideExcel)
        {
            var __workflow_mSExcelHideExcel = WorkflowExpression.Compile(mSExcelHideExcel, nameof(mSExcelHideExcel), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/HideExcel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSExcelHideExcel);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelOpenWorkbookResponse, ApiConnectionActionConfiguration> MSExcelOpenWorkbook(Expression<Func<MSExcelOpenWorkbookInput>> mSExcelOpenWorkbook)
        {
            var __workflow_mSExcelOpenWorkbook = WorkflowExpression.Compile(mSExcelOpenWorkbook, nameof(mSExcelOpenWorkbook), required: true);
            return new DeferredBodyAction<MSExcelOpenWorkbookResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/OpenWorkbook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSExcelOpenWorkbook);
                return new ApiConnectionAction<MSExcelOpenWorkbookResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelPutWorkbookInEditModeResponse, ApiConnectionActionConfiguration> MSExcelPutWorkbookInEditMode(Expression<Func<MSExcelPutWorkbookInEditModeInput>> mSExcelPutWorkbookInEditMode)
        {
            var __workflow_mSExcelPutWorkbookInEditMode = WorkflowExpression.Compile(mSExcelPutWorkbookInEditMode, nameof(mSExcelPutWorkbookInEditMode), required: true);
            return new DeferredBodyAction<MSExcelPutWorkbookInEditModeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/PutWorkbookInEditMode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSExcelPutWorkbookInEditMode);
                return new ApiConnectionAction<MSExcelPutWorkbookInEditModeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelCreateWorkbookResponse, ApiConnectionActionConfiguration> MSExcelCreateWorkbook(Expression<Func<MSExcelCreateWorkbookInput>> mSExcelCreateWorkbook)
        {
            var __workflow_mSExcelCreateWorkbook = WorkflowExpression.Compile(mSExcelCreateWorkbook, nameof(mSExcelCreateWorkbook), required: true);
            return new DeferredBodyAction<MSExcelCreateWorkbookResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/CreateWorkbook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSExcelCreateWorkbook);
                return new ApiConnectionAction<MSExcelCreateWorkbookResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSExcelCloseWorkbook(Expression<Func<MSExcelCloseWorkbookInput>> mSExcelCloseWorkbook)
        {
            var __workflow_mSExcelCloseWorkbook = WorkflowExpression.Compile(mSExcelCloseWorkbook, nameof(mSExcelCloseWorkbook), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/CloseWorkbook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSExcelCloseWorkbook);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSExcelCloseCurrentWorkbook(Expression<Func<MSExcelCloseCurrentWorkbookInput>> mSExcelCloseCurrentWorkbook)
        {
            var __workflow_mSExcelCloseCurrentWorkbook = WorkflowExpression.Compile(mSExcelCloseCurrentWorkbook, nameof(mSExcelCloseCurrentWorkbook), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/CloseCurrentWorkbook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSExcelCloseCurrentWorkbook);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSExcelGoToCell(Expression<Func<MSExcelGoToCellInput>> mSExcelGoToCell)
        {
            var __workflow_mSExcelGoToCell = WorkflowExpression.Compile(mSExcelGoToCell, nameof(mSExcelGoToCell), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/GoToCell";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSExcelGoToCell);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetCellValueResponse, ApiConnectionActionConfiguration> MSExcelGetCellValue(Expression<Func<MSExcelGetCellValueInput>> mSExcelGetCellValue)
        {
            var __workflow_mSExcelGetCellValue = WorkflowExpression.Compile(mSExcelGetCellValue, nameof(mSExcelGetCellValue), required: true);
            return new DeferredBodyAction<MSExcelGetCellValueResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/GetCellValue";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSExcelGetCellValue);
                return new ApiConnectionAction<MSExcelGetCellValueResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetCellValue2Response, ApiConnectionActionConfiguration> MSExcelGetCellValue2(Expression<Func<MSExcelGetCellValue2Input>> mSExcelGetCellValue2)
        {
            var __workflow_mSExcelGetCellValue2 = WorkflowExpression.Compile(mSExcelGetCellValue2, nameof(mSExcelGetCellValue2), required: true);
            return new DeferredBodyAction<MSExcelGetCellValue2Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/GetCellValue2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSExcelGetCellValue2);
                return new ApiConnectionAction<MSExcelGetCellValue2Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetCellTextResponse, ApiConnectionActionConfiguration> MSExcelGetCellText(Expression<Func<MSExcelGetCellTextInput>> mSExcelGetCellText)
        {
            var __workflow_mSExcelGetCellText = WorkflowExpression.Compile(mSExcelGetCellText, nameof(mSExcelGetCellText), required: true);
            return new DeferredBodyAction<MSExcelGetCellTextResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/GetCellText";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSExcelGetCellText);
                return new ApiConnectionAction<MSExcelGetCellTextResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSExcelSetCellValue(Expression<Func<MSExcelSetCellValueInput>> mSExcelSetCellValue)
        {
            var __workflow_mSExcelSetCellValue = WorkflowExpression.Compile(mSExcelSetCellValue, nameof(mSExcelSetCellValue), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/SetCellValue";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSExcelSetCellValue);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelFindNextCellWithValueResponse, ApiConnectionActionConfiguration> MSExcelFindNextCellWithValue(Expression<Func<MSExcelFindNextCellWithValueInput>> mSExcelFindNextCellWithValue)
        {
            var __workflow_mSExcelFindNextCellWithValue = WorkflowExpression.Compile(mSExcelFindNextCellWithValue, nameof(mSExcelFindNextCellWithValue), required: true);
            return new DeferredBodyAction<MSExcelFindNextCellWithValueResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/FindNextCellWithValue";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSExcelFindNextCellWithValue);
                return new ApiConnectionAction<MSExcelFindNextCellWithValueResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelFindNextEmptyCellResponse, ApiConnectionActionConfiguration> MSExcelFindNextEmptyCell(Expression<Func<MSExcelFindNextEmptyCellInput>> mSExcelFindNextEmptyCell)
        {
            var __workflow_mSExcelFindNextEmptyCell = WorkflowExpression.Compile(mSExcelFindNextEmptyCell, nameof(mSExcelFindNextEmptyCell), required: true);
            return new DeferredBodyAction<MSExcelFindNextEmptyCellResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/FindNextEmptyCell";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSExcelFindNextEmptyCell);
                return new ApiConnectionAction<MSExcelFindNextEmptyCellResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGotoNextEmptyCellLeftResponse, ApiConnectionActionConfiguration> MSExcelGotoNextEmptyCellLeft(Expression<Func<MSExcelGotoNextEmptyCellLeftInput>> mSExcelGotoNextEmptyCellLeft)
        {
            var __workflow_mSExcelGotoNextEmptyCellLeft = WorkflowExpression.Compile(mSExcelGotoNextEmptyCellLeft, nameof(mSExcelGotoNextEmptyCellLeft), required: true);
            return new DeferredBodyAction<MSExcelGotoNextEmptyCellLeftResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/GotoNextEmptyCellLeft";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSExcelGotoNextEmptyCellLeft);
                return new ApiConnectionAction<MSExcelGotoNextEmptyCellLeftResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGotoNextEmptyCellRightResponse, ApiConnectionActionConfiguration> MSExcelGotoNextEmptyCellRight(Expression<Func<MSExcelGotoNextEmptyCellRightInput>> mSExcelGotoNextEmptyCellRight)
        {
            var __workflow_mSExcelGotoNextEmptyCellRight = WorkflowExpression.Compile(mSExcelGotoNextEmptyCellRight, nameof(mSExcelGotoNextEmptyCellRight), required: true);
            return new DeferredBodyAction<MSExcelGotoNextEmptyCellRightResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/GotoNextEmptyCellRight";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSExcelGotoNextEmptyCellRight);
                return new ApiConnectionAction<MSExcelGotoNextEmptyCellRightResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGotoNextEmptyCellUpResponse, ApiConnectionActionConfiguration> MSExcelGotoNextEmptyCellUp(Expression<Func<MSExcelGotoNextEmptyCellUpInput>> mSExcelGotoNextEmptyCellUp)
        {
            var __workflow_mSExcelGotoNextEmptyCellUp = WorkflowExpression.Compile(mSExcelGotoNextEmptyCellUp, nameof(mSExcelGotoNextEmptyCellUp), required: true);
            return new DeferredBodyAction<MSExcelGotoNextEmptyCellUpResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/GotoNextEmptyCellUp";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSExcelGotoNextEmptyCellUp);
                return new ApiConnectionAction<MSExcelGotoNextEmptyCellUpResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGotoNextEmptyCellDownResponse, ApiConnectionActionConfiguration> MSExcelGotoNextEmptyCellDown(Expression<Func<MSExcelGotoNextEmptyCellDownInput>> mSExcelGotoNextEmptyCellDown)
        {
            var __workflow_mSExcelGotoNextEmptyCellDown = WorkflowExpression.Compile(mSExcelGotoNextEmptyCellDown, nameof(mSExcelGotoNextEmptyCellDown), required: true);
            return new DeferredBodyAction<MSExcelGotoNextEmptyCellDownResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/GotoNextEmptyCellDown";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSExcelGotoNextEmptyCellDown);
                return new ApiConnectionAction<MSExcelGotoNextEmptyCellDownResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelSaveWorkbookResponse, ApiConnectionActionConfiguration> MSExcelSaveWorkbook(Expression<Func<MSExcelSaveWorkbookInput>> mSExcelSaveWorkbook)
        {
            var __workflow_mSExcelSaveWorkbook = WorkflowExpression.Compile(mSExcelSaveWorkbook, nameof(mSExcelSaveWorkbook), required: true);
            return new DeferredBodyAction<MSExcelSaveWorkbookResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/SaveWorkbook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSExcelSaveWorkbook);
                return new ApiConnectionAction<MSExcelSaveWorkbookResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelSaveWorkbookAsResponse, ApiConnectionActionConfiguration> MSExcelSaveWorkbookAs(Expression<Func<MSExcelSaveWorkbookAsInput>> mSExcelSaveWorkbookAs)
        {
            var __workflow_mSExcelSaveWorkbookAs = WorkflowExpression.Compile(mSExcelSaveWorkbookAs, nameof(mSExcelSaveWorkbookAs), required: true);
            return new DeferredBodyAction<MSExcelSaveWorkbookAsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/SaveWorkbookAs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSExcelSaveWorkbookAs);
                return new ApiConnectionAction<MSExcelSaveWorkbookAsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelSaveWorkbookAsCSVResponse, ApiConnectionActionConfiguration> MSExcelSaveWorkbookAsCSV(Expression<Func<MSExcelSaveWorkbookAsCSVInput>> mSExcelSaveWorkbookAsCSV)
        {
            var __workflow_mSExcelSaveWorkbookAsCSV = WorkflowExpression.Compile(mSExcelSaveWorkbookAsCSV, nameof(mSExcelSaveWorkbookAsCSV), required: true);
            return new DeferredBodyAction<MSExcelSaveWorkbookAsCSVResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/SaveWorkbookAsCSV";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSExcelSaveWorkbookAsCSV);
                return new ApiConnectionAction<MSExcelSaveWorkbookAsCSVResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelSaveWorkbookAsWithPasswordResponse, ApiConnectionActionConfiguration> MSExcelSaveWorkbookAsWithPassword(Expression<Func<MSExcelSaveWorkbookAsWithPasswordInput>> mSExcelSaveWorkbookAsWithPassword)
        {
            var __workflow_mSExcelSaveWorkbookAsWithPassword = WorkflowExpression.Compile(mSExcelSaveWorkbookAsWithPassword, nameof(mSExcelSaveWorkbookAsWithPassword), required: true);
            return new DeferredBodyAction<MSExcelSaveWorkbookAsWithPasswordResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/SaveWorkbookAsWithPassword";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSExcelSaveWorkbookAsWithPassword);
                return new ApiConnectionAction<MSExcelSaveWorkbookAsWithPasswordResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelSaveCurrentWorkbookResponse, ApiConnectionActionConfiguration> MSExcelSaveCurrentWorkbook(Expression<Func<MSExcelSaveCurrentWorkbookInput>> mSExcelSaveCurrentWorkbook)
        {
            var __workflow_mSExcelSaveCurrentWorkbook = WorkflowExpression.Compile(mSExcelSaveCurrentWorkbook, nameof(mSExcelSaveCurrentWorkbook), required: true);
            return new DeferredBodyAction<MSExcelSaveCurrentWorkbookResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/SaveCurrentWorkbook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSExcelSaveCurrentWorkbook);
                return new ApiConnectionAction<MSExcelSaveCurrentWorkbookResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelSaveCurrentWorkbookAsResponse, ApiConnectionActionConfiguration> MSExcelSaveCurrentWorkbookAs(Expression<Func<MSExcelSaveCurrentWorkbookAsInput>> mSExcelSaveCurrentWorkbookAs)
        {
            var __workflow_mSExcelSaveCurrentWorkbookAs = WorkflowExpression.Compile(mSExcelSaveCurrentWorkbookAs, nameof(mSExcelSaveCurrentWorkbookAs), required: true);
            return new DeferredBodyAction<MSExcelSaveCurrentWorkbookAsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/SaveCurrentWorkbookAs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSExcelSaveCurrentWorkbookAs);
                return new ApiConnectionAction<MSExcelSaveCurrentWorkbookAsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelSaveCurrentWorkbookAsCSVResponse, ApiConnectionActionConfiguration> MSExcelSaveCurrentWorkbookAsCSV(Expression<Func<MSExcelSaveCurrentWorkbookAsCSVInput>> mSExcelSaveCurrentWorkbookAsCSV)
        {
            var __workflow_mSExcelSaveCurrentWorkbookAsCSV = WorkflowExpression.Compile(mSExcelSaveCurrentWorkbookAsCSV, nameof(mSExcelSaveCurrentWorkbookAsCSV), required: true);
            return new DeferredBodyAction<MSExcelSaveCurrentWorkbookAsCSVResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/SaveCurrentWorkbookAsCSV";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSExcelSaveCurrentWorkbookAsCSV);
                return new ApiConnectionAction<MSExcelSaveCurrentWorkbookAsCSVResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetWorksheetNamesResponse, ApiConnectionActionConfiguration> MSExcelGetWorksheetNames(Expression<Func<MSExcelGetWorksheetNamesInput>> mSExcelGetWorksheetNames)
        {
            var __workflow_mSExcelGetWorksheetNames = WorkflowExpression.Compile(mSExcelGetWorksheetNames, nameof(mSExcelGetWorksheetNames), required: true);
            return new DeferredBodyAction<MSExcelGetWorksheetNamesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/GetWorksheetNames";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSExcelGetWorksheetNames);
                return new ApiConnectionAction<MSExcelGetWorksheetNamesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetWorksheetNameResponse, ApiConnectionActionConfiguration> MSExcelGetWorksheetName(Expression<Func<MSExcelGetWorksheetNameInput>> mSExcelGetWorksheetName)
        {
            var __workflow_mSExcelGetWorksheetName = WorkflowExpression.Compile(mSExcelGetWorksheetName, nameof(mSExcelGetWorksheetName), required: true);
            return new DeferredBodyAction<MSExcelGetWorksheetNameResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/GetWorksheetName";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSExcelGetWorksheetName);
                return new ApiConnectionAction<MSExcelGetWorksheetNameResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSExcelActivateWorksheet(Expression<Func<MSExcelActivateWorksheetInput>> mSExcelActivateWorksheet)
        {
            var __workflow_mSExcelActivateWorksheet = WorkflowExpression.Compile(mSExcelActivateWorksheet, nameof(mSExcelActivateWorksheet), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/ActivateWorksheet";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSExcelActivateWorksheet);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSExcelCreateWorksheet(Expression<Func<MSExcelCreateWorksheetInput>> mSExcelCreateWorksheet)
        {
            var __workflow_mSExcelCreateWorksheet = WorkflowExpression.Compile(mSExcelCreateWorksheet, nameof(mSExcelCreateWorksheet), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/CreateWorksheet";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSExcelCreateWorksheet);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSExcelDeleteWorksheet(Expression<Func<MSExcelDeleteWorksheetInput>> mSExcelDeleteWorksheet)
        {
            var __workflow_mSExcelDeleteWorksheet = WorkflowExpression.Compile(mSExcelDeleteWorksheet, nameof(mSExcelDeleteWorksheet), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/DeleteWorksheet";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSExcelDeleteWorksheet);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetWorksheetAsCollectionEnhancedResponse, ApiConnectionActionConfiguration> MSExcelGetWorksheetAsCollectionEnhanced(Expression<Func<MSExcelGetWorksheetAsCollectionEnhancedInput>> mSExcelGetWorksheetAsCollectionEnhanced)
        {
            var __workflow_mSExcelGetWorksheetAsCollectionEnhanced = WorkflowExpression.Compile(mSExcelGetWorksheetAsCollectionEnhanced, nameof(mSExcelGetWorksheetAsCollectionEnhanced), required: true);
            return new DeferredBodyAction<MSExcelGetWorksheetAsCollectionEnhancedResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/GetWorksheetAsCollectionEnhanced";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSExcelGetWorksheetAsCollectionEnhanced);
                return new ApiConnectionAction<MSExcelGetWorksheetAsCollectionEnhancedResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetNumberOfRowsResponse, ApiConnectionActionConfiguration> MSExcelGetNumberOfRows(Expression<Func<MSExcelGetNumberOfRowsInput>> mSExcelGetNumberOfRows)
        {
            var __workflow_mSExcelGetNumberOfRows = WorkflowExpression.Compile(mSExcelGetNumberOfRows, nameof(mSExcelGetNumberOfRows), required: true);
            return new DeferredBodyAction<MSExcelGetNumberOfRowsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/GetNumberOfRows";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSExcelGetNumberOfRows);
                return new ApiConnectionAction<MSExcelGetNumberOfRowsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelEvaluateExpressionResponse, ApiConnectionActionConfiguration> MSExcelEvaluateExpression(Expression<Func<MSExcelEvaluateExpressionInput>> mSExcelEvaluateExpression)
        {
            var __workflow_mSExcelEvaluateExpression = WorkflowExpression.Compile(mSExcelEvaluateExpression, nameof(mSExcelEvaluateExpression), required: true);
            return new DeferredBodyAction<MSExcelEvaluateExpressionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/EvaluateExpression";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSExcelEvaluateExpression);
                return new ApiConnectionAction<MSExcelEvaluateExpressionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetWorksheetUsedRangeResponse, ApiConnectionActionConfiguration> MSExcelGetWorksheetUsedRange(Expression<Func<MSExcelGetWorksheetUsedRangeInput>> mSExcelGetWorksheetUsedRange)
        {
            var __workflow_mSExcelGetWorksheetUsedRange = WorkflowExpression.Compile(mSExcelGetWorksheetUsedRange, nameof(mSExcelGetWorksheetUsedRange), required: true);
            return new DeferredBodyAction<MSExcelGetWorksheetUsedRangeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/GetWorksheetUsedRange";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSExcelGetWorksheetUsedRange);
                return new ApiConnectionAction<MSExcelGetWorksheetUsedRangeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetCountrySettingResponse, ApiConnectionActionConfiguration> MSExcelGetCountrySetting(Expression<Func<MSExcelGetCountrySettingInput>> mSExcelGetCountrySetting)
        {
            var __workflow_mSExcelGetCountrySetting = WorkflowExpression.Compile(mSExcelGetCountrySetting, nameof(mSExcelGetCountrySetting), required: true);
            return new DeferredBodyAction<MSExcelGetCountrySettingResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/GetCountrySetting";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSExcelGetCountrySetting);
                return new ApiConnectionAction<MSExcelGetCountrySettingResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSExcelWriteCollection(Expression<Func<MSExcelWriteCollectionInput>> mSExcelWriteCollection)
        {
            var __workflow_mSExcelWriteCollection = WorkflowExpression.Compile(mSExcelWriteCollection, nameof(mSExcelWriteCollection), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/WriteCollection";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSExcelWriteCollection);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSExcelWriteCollectionWithDates(Expression<Func<MSExcelWriteCollectionWithDatesInput>> mSExcelWriteCollectionWithDates)
        {
            var __workflow_mSExcelWriteCollectionWithDates = WorkflowExpression.Compile(mSExcelWriteCollectionWithDates, nameof(mSExcelWriteCollectionWithDates), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/WriteCollectionWithDates";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSExcelWriteCollectionWithDates);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetActiveCellResponse, ApiConnectionActionConfiguration> MSExcelGetActiveCell(Expression<Func<MSExcelGetActiveCellInput>> mSExcelGetActiveCell)
        {
            var __workflow_mSExcelGetActiveCell = WorkflowExpression.Compile(mSExcelGetActiveCell, nameof(mSExcelGetActiveCell), required: true);
            return new DeferredBodyAction<MSExcelGetActiveCellResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/GetActiveCell";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSExcelGetActiveCell);
                return new ApiConnectionAction<MSExcelGetActiveCellResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSExcelFormatCell(Expression<Func<MSExcelFormatCellInput>> mSExcelFormatCell)
        {
            var __workflow_mSExcelFormatCell = WorkflowExpression.Compile(mSExcelFormatCell, nameof(mSExcelFormatCell), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/FormatCell";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSExcelFormatCell);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSExcelFormatCurrentCell(Expression<Func<MSExcelFormatCurrentCellInput>> mSExcelFormatCurrentCell)
        {
            var __workflow_mSExcelFormatCurrentCell = WorkflowExpression.Compile(mSExcelFormatCurrentCell, nameof(mSExcelFormatCurrentCell), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/FormatCurrentCell";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSExcelFormatCurrentCell);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSExcelSelectCellRange(Expression<Func<MSExcelSelectCellRangeInput>> mSExcelSelectCellRange)
        {
            var __workflow_mSExcelSelectCellRange = WorkflowExpression.Compile(mSExcelSelectCellRange, nameof(mSExcelSelectCellRange), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/SelectCellRange";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSExcelSelectCellRange);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSExcelCopySelection(Expression<Func<MSExcelCopySelectionInput>> mSExcelCopySelection)
        {
            var __workflow_mSExcelCopySelection = WorkflowExpression.Compile(mSExcelCopySelection, nameof(mSExcelCopySelection), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/CopySelection";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSExcelCopySelection);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSExcelCutSelection(Expression<Func<MSExcelCutSelectionInput>> mSExcelCutSelection)
        {
            var __workflow_mSExcelCutSelection = WorkflowExpression.Compile(mSExcelCutSelection, nameof(mSExcelCutSelection), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/CutSelection";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSExcelCutSelection);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSExcelPasteIntoSelection(Expression<Func<MSExcelPasteIntoSelectionInput>> mSExcelPasteIntoSelection)
        {
            var __workflow_mSExcelPasteIntoSelection = WorkflowExpression.Compile(mSExcelPasteIntoSelection, nameof(mSExcelPasteIntoSelection), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/PasteIntoSelection";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSExcelPasteIntoSelection);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSExcelInsertOnSelection(Expression<Func<MSExcelInsertOnSelectionInput>> mSExcelInsertOnSelection)
        {
            var __workflow_mSExcelInsertOnSelection = WorkflowExpression.Compile(mSExcelInsertOnSelection, nameof(mSExcelInsertOnSelection), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/InsertOnSelection";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSExcelInsertOnSelection);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSExcelDeleteSelection(Expression<Func<MSExcelDeleteSelectionInput>> mSExcelDeleteSelection)
        {
            var __workflow_mSExcelDeleteSelection = WorkflowExpression.Compile(mSExcelDeleteSelection, nameof(mSExcelDeleteSelection), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/DeleteSelection";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSExcelDeleteSelection);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSExcelClearExcelClipboard(Expression<Func<MSExcelClearExcelClipboardInput>> mSExcelClearExcelClipboard)
        {
            var __workflow_mSExcelClearExcelClipboard = WorkflowExpression.Compile(mSExcelClearExcelClipboard, nameof(mSExcelClearExcelClipboard), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/ClearExcelClipboard";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSExcelClearExcelClipboard);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelRunMacroResponse, ApiConnectionActionConfiguration> MSExcelRunMacro(Expression<Func<MSExcelRunMacroInput>> mSExcelRunMacro)
        {
            var __workflow_mSExcelRunMacro = WorkflowExpression.Compile(mSExcelRunMacro, nameof(mSExcelRunMacro), required: true);
            return new DeferredBodyAction<MSExcelRunMacroResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/RunMacro";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSExcelRunMacro);
                return new ApiConnectionAction<MSExcelRunMacroResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSExcelAddMacroToWorkbook(Expression<Func<MSExcelAddMacroToWorkbookInput>> mSExcelAddMacroToWorkbook)
        {
            var __workflow_mSExcelAddMacroToWorkbook = WorkflowExpression.Compile(mSExcelAddMacroToWorkbook, nameof(mSExcelAddMacroToWorkbook), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/AddMacroToWorkbook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSExcelAddMacroToWorkbook);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSExcelTrustVBOMInRegistry(Expression<Func<MSExcelTrustVBOMInRegistryInput>> mSExcelTrustVBOMInRegistry)
        {
            var __workflow_mSExcelTrustVBOMInRegistry = WorkflowExpression.Compile(mSExcelTrustVBOMInRegistry, nameof(mSExcelTrustVBOMInRegistry), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/TrustVBOMInRegistry";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSExcelTrustVBOMInRegistry);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSExcelSetCalculationMode(Expression<Func<MSExcelSetCalculationModeInput>> mSExcelSetCalculationMode)
        {
            var __workflow_mSExcelSetCalculationMode = WorkflowExpression.Compile(mSExcelSetCalculationMode, nameof(mSExcelSetCalculationMode), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/SetCalculationMode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSExcelSetCalculationMode);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSExcelExecuteCommandBarObject(Expression<Func<MSExcelExecuteCommandBarObjectInput>> mSExcelExecuteCommandBarObject)
        {
            var __workflow_mSExcelExecuteCommandBarObject = WorkflowExpression.Compile(mSExcelExecuteCommandBarObject, nameof(mSExcelExecuteCommandBarObject), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/ExecuteCommandBarObject";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSExcelExecuteCommandBarObject);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelCopyBetweenCellsResponse, ApiConnectionActionConfiguration> MSExcelCopyBetweenCells(Expression<Func<MSExcelCopyBetweenCellsInput>> mSExcelCopyBetweenCells)
        {
            var __workflow_mSExcelCopyBetweenCells = WorkflowExpression.Compile(mSExcelCopyBetweenCells, nameof(mSExcelCopyBetweenCells), required: true);
            return new DeferredBodyAction<MSExcelCopyBetweenCellsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/CopyBetweenCells";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSExcelCopyBetweenCells);
                return new ApiConnectionAction<MSExcelCopyBetweenCellsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelCutBetweenCellsResponse, ApiConnectionActionConfiguration> MSExcelCutBetweenCells(Expression<Func<MSExcelCutBetweenCellsInput>> mSExcelCutBetweenCells)
        {
            var __workflow_mSExcelCutBetweenCells = WorkflowExpression.Compile(mSExcelCutBetweenCells, nameof(mSExcelCutBetweenCells), required: true);
            return new DeferredBodyAction<MSExcelCutBetweenCellsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/CutBetweenCells";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSExcelCutBetweenCells);
                return new ApiConnectionAction<MSExcelCutBetweenCellsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelMinimiseWindowResponse, ApiConnectionActionConfiguration> MSExcelMinimiseWindow(Expression<Func<MSExcelMinimiseWindowInput>> mSExcelMinimiseWindow)
        {
            var __workflow_mSExcelMinimiseWindow = WorkflowExpression.Compile(mSExcelMinimiseWindow, nameof(mSExcelMinimiseWindow), required: true);
            return new DeferredBodyAction<MSExcelMinimiseWindowResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/MinimiseWindow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSExcelMinimiseWindow);
                return new ApiConnectionAction<MSExcelMinimiseWindowResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelMaximiseWindowResponse, ApiConnectionActionConfiguration> MSExcelMaximiseWindow(Expression<Func<MSExcelMaximiseWindowInput>> mSExcelMaximiseWindow)
        {
            var __workflow_mSExcelMaximiseWindow = WorkflowExpression.Compile(mSExcelMaximiseWindow, nameof(mSExcelMaximiseWindow), required: true);
            return new DeferredBodyAction<MSExcelMaximiseWindowResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/MaximiseWindow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSExcelMaximiseWindow);
                return new ApiConnectionAction<MSExcelMaximiseWindowResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelNormaliseWindowResponse, ApiConnectionActionConfiguration> MSExcelNormaliseWindow(Expression<Func<MSExcelNormaliseWindowInput>> mSExcelNormaliseWindow)
        {
            var __workflow_mSExcelNormaliseWindow = WorkflowExpression.Compile(mSExcelNormaliseWindow, nameof(mSExcelNormaliseWindow), required: true);
            return new DeferredBodyAction<MSExcelNormaliseWindowResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/NormaliseWindow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSExcelNormaliseWindow);
                return new ApiConnectionAction<MSExcelNormaliseWindowResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetAndSetCellValueResponse, ApiConnectionActionConfiguration> MSExcelGetAndSetCellValue(Expression<Func<MSExcelGetAndSetCellValueInput>> mSExcelGetAndSetCellValue)
        {
            var __workflow_mSExcelGetAndSetCellValue = WorkflowExpression.Compile(mSExcelGetAndSetCellValue, nameof(mSExcelGetAndSetCellValue), required: true);
            return new DeferredBodyAction<MSExcelGetAndSetCellValueResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/GetAndSetCellValue";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSExcelGetAndSetCellValue);
                return new ApiConnectionAction<MSExcelGetAndSetCellValueResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetAndSetCellValue2Response, ApiConnectionActionConfiguration> MSExcelGetAndSetCellValue2(Expression<Func<MSExcelGetAndSetCellValue2Input>> mSExcelGetAndSetCellValue2)
        {
            var __workflow_mSExcelGetAndSetCellValue2 = WorkflowExpression.Compile(mSExcelGetAndSetCellValue2, nameof(mSExcelGetAndSetCellValue2), required: true);
            return new DeferredBodyAction<MSExcelGetAndSetCellValue2Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/GetAndSetCellValue2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSExcelGetAndSetCellValue2);
                return new ApiConnectionAction<MSExcelGetAndSetCellValue2Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetAndSetCellTextResponse, ApiConnectionActionConfiguration> MSExcelGetAndSetCellText(Expression<Func<MSExcelGetAndSetCellTextInput>> mSExcelGetAndSetCellText)
        {
            var __workflow_mSExcelGetAndSetCellText = WorkflowExpression.Compile(mSExcelGetAndSetCellText, nameof(mSExcelGetAndSetCellText), required: true);
            return new DeferredBodyAction<MSExcelGetAndSetCellTextResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/GetAndSetCellText";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSExcelGetAndSetCellText);
                return new ApiConnectionAction<MSExcelGetAndSetCellTextResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelCheckOLEObjectResponse, ApiConnectionActionConfiguration> MSExcelCheckOLEObject(Expression<Func<MSExcelCheckOLEObjectInput>> mSExcelCheckOLEObject)
        {
            var __workflow_mSExcelCheckOLEObject = WorkflowExpression.Compile(mSExcelCheckOLEObject, nameof(mSExcelCheckOLEObject), required: true);
            return new DeferredBodyAction<MSExcelCheckOLEObjectResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/CheckOLEObject";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSExcelCheckOLEObject);
                return new ApiConnectionAction<MSExcelCheckOLEObjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelInputTextIntoOLEObjectResponse, ApiConnectionActionConfiguration> MSExcelInputTextIntoOLEObject(Expression<Func<MSExcelInputTextIntoOLEObjectInput>> mSExcelInputTextIntoOLEObject)
        {
            var __workflow_mSExcelInputTextIntoOLEObject = WorkflowExpression.Compile(mSExcelInputTextIntoOLEObject, nameof(mSExcelInputTextIntoOLEObject), required: true);
            return new DeferredBodyAction<MSExcelInputTextIntoOLEObjectResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/InputTextIntoOLEObject";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSExcelInputTextIntoOLEObject);
                return new ApiConnectionAction<MSExcelInputTextIntoOLEObjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelSetCellBackgroundColourResponse, ApiConnectionActionConfiguration> MSExcelSetCellBackgroundColour(Expression<Func<MSExcelSetCellBackgroundColourInput>> mSExcelSetCellBackgroundColour)
        {
            var __workflow_mSExcelSetCellBackgroundColour = WorkflowExpression.Compile(mSExcelSetCellBackgroundColour, nameof(mSExcelSetCellBackgroundColour), required: true);
            return new DeferredBodyAction<MSExcelSetCellBackgroundColourResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/SetCellBackgroundColour";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSExcelSetCellBackgroundColour);
                return new ApiConnectionAction<MSExcelSetCellBackgroundColourResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetCellBackgroundColourResponse, ApiConnectionActionConfiguration> MSExcelGetCellBackgroundColour(Expression<Func<MSExcelGetCellBackgroundColourInput>> mSExcelGetCellBackgroundColour)
        {
            var __workflow_mSExcelGetCellBackgroundColour = WorkflowExpression.Compile(mSExcelGetCellBackgroundColour, nameof(mSExcelGetCellBackgroundColour), required: true);
            return new DeferredBodyAction<MSExcelGetCellBackgroundColourResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/GetCellBackgroundColour";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSExcelGetCellBackgroundColour);
                return new ApiConnectionAction<MSExcelGetCellBackgroundColourResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetOLEObjectValueResponse, ApiConnectionActionConfiguration> MSExcelGetOLEObjectValue(Expression<Func<MSExcelGetOLEObjectValueInput>> mSExcelGetOLEObjectValue)
        {
            var __workflow_mSExcelGetOLEObjectValue = WorkflowExpression.Compile(mSExcelGetOLEObjectValue, nameof(mSExcelGetOLEObjectValue), required: true);
            return new DeferredBodyAction<MSExcelGetOLEObjectValueResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/GetOLEObjectValue";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSExcelGetOLEObjectValue);
                return new ApiConnectionAction<MSExcelGetOLEObjectValueResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelDoesOLEObjectExistResponse, ApiConnectionActionConfiguration> MSExcelDoesOLEObjectExist(Expression<Func<MSExcelDoesOLEObjectExistInput>> mSExcelDoesOLEObjectExist)
        {
            var __workflow_mSExcelDoesOLEObjectExist = WorkflowExpression.Compile(mSExcelDoesOLEObjectExist, nameof(mSExcelDoesOLEObjectExist), required: true);
            return new DeferredBodyAction<MSExcelDoesOLEObjectExistResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/DoesOLEObjectExist";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSExcelDoesOLEObjectExist);
                return new ApiConnectionAction<MSExcelDoesOLEObjectExistResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelPressOLEObjectResponse, ApiConnectionActionConfiguration> MSExcelPressOLEObject(Expression<Func<MSExcelPressOLEObjectInput>> mSExcelPressOLEObject)
        {
            var __workflow_mSExcelPressOLEObject = WorkflowExpression.Compile(mSExcelPressOLEObject, nameof(mSExcelPressOLEObject), required: true);
            return new DeferredBodyAction<MSExcelPressOLEObjectResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/PressOLEObject";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSExcelPressOLEObject);
                return new ApiConnectionAction<MSExcelPressOLEObjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelSetWorksheetSensitivityLabelResponse, ApiConnectionActionConfiguration> MSExcelSetWorksheetSensitivityLabel(Expression<Func<MSExcelSetWorksheetSensitivityLabelInput>> mSExcelSetWorksheetSensitivityLabel)
        {
            var __workflow_mSExcelSetWorksheetSensitivityLabel = WorkflowExpression.Compile(mSExcelSetWorksheetSensitivityLabel, nameof(mSExcelSetWorksheetSensitivityLabel), required: true);
            return new DeferredBodyAction<MSExcelSetWorksheetSensitivityLabelResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/SetWorksheetSensitivityLabel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSExcelSetWorksheetSensitivityLabel);
                return new ApiConnectionAction<MSExcelSetWorksheetSensitivityLabelResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetWorksheetSensitivityLabelResponse, ApiConnectionActionConfiguration> MSExcelGetWorksheetSensitivityLabel(Expression<Func<MSExcelGetWorksheetSensitivityLabelInput>> mSExcelGetWorksheetSensitivityLabel)
        {
            var __workflow_mSExcelGetWorksheetSensitivityLabel = WorkflowExpression.Compile(mSExcelGetWorksheetSensitivityLabel, nameof(mSExcelGetWorksheetSensitivityLabel), required: true);
            return new DeferredBodyAction<MSExcelGetWorksheetSensitivityLabelResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/GetWorksheetSensitivityLabel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSExcelGetWorksheetSensitivityLabel);
                return new ApiConnectionAction<MSExcelGetWorksheetSensitivityLabelResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelWriteArrayResponse, ApiConnectionActionConfiguration> MSExcelWriteArray(Expression<Func<MSExcelWriteArrayInput>> mSExcelWriteArray)
        {
            var __workflow_mSExcelWriteArray = WorkflowExpression.Compile(mSExcelWriteArray, nameof(mSExcelWriteArray), required: true);
            return new DeferredBodyAction<MSExcelWriteArrayResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSExcel/WriteArray";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSExcelWriteArray);
                return new ApiConnectionAction<MSExcelWriteArrayResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookCreateInstanceResponse, ApiConnectionActionConfiguration> MSOutlookCreateInstance(Expression<Func<MSOutlookCreateInstanceInput>> mSOutlookCreateInstance)
        {
            var __workflow_mSOutlookCreateInstance = WorkflowExpression.Compile(mSOutlookCreateInstance, nameof(mSOutlookCreateInstance), required: true);
            return new DeferredBodyAction<MSOutlookCreateInstanceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSOutlook/CreateInstance";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSOutlookCreateInstance);
                return new ApiConnectionAction<MSOutlookCreateInstanceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSOutlookCloseInstance(Expression<Func<MSOutlookCloseInstanceInput>> mSOutlookCloseInstance)
        {
            var __workflow_mSOutlookCloseInstance = WorkflowExpression.Compile(mSOutlookCloseInstance, nameof(mSOutlookCloseInstance), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSOutlook/CloseInstance";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSOutlookCloseInstance);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSOutlookCloseInstanceUsingWindow(Expression<Func<MSOutlookCloseInstanceUsingWindowInput>> mSOutlookCloseInstanceUsingWindow)
        {
            var __workflow_mSOutlookCloseInstanceUsingWindow = WorkflowExpression.Compile(mSOutlookCloseInstanceUsingWindow, nameof(mSOutlookCloseInstanceUsingWindow), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSOutlook/CloseInstanceUsingWindow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSOutlookCloseInstanceUsingWindow);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookAttachToExistingInstanceResponse, ApiConnectionActionConfiguration> MSOutlookAttachToExistingInstance(Expression<Func<MSOutlookAttachToExistingInstanceInput>> mSOutlookAttachToExistingInstance)
        {
            var __workflow_mSOutlookAttachToExistingInstance = WorkflowExpression.Compile(mSOutlookAttachToExistingInstance, nameof(mSOutlookAttachToExistingInstance), required: true);
            return new DeferredBodyAction<MSOutlookAttachToExistingInstanceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSOutlook/MSOutlookAttachToExistingInstance";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSOutlookAttachToExistingInstance);
                return new ApiConnectionAction<MSOutlookAttachToExistingInstanceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookIsConnectedResponse, ApiConnectionActionConfiguration> MSOutlookIsConnected(Expression<Func<MSOutlookIsConnectedInput>> mSOutlookIsConnected)
        {
            var __workflow_mSOutlookIsConnected = WorkflowExpression.Compile(mSOutlookIsConnected, nameof(mSOutlookIsConnected), required: true);
            return new DeferredBodyAction<MSOutlookIsConnectedResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSOutlook/IsOutlookConnected";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSOutlookIsConnected);
                return new ApiConnectionAction<MSOutlookIsConnectedResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSOutlookShow(Expression<Func<MSOutlookShowInput>> mSOutlookShow)
        {
            var __workflow_mSOutlookShow = WorkflowExpression.Compile(mSOutlookShow, nameof(mSOutlookShow), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSOutlook/ShowOutlook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSOutlookShow);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookGetNameSpaceInformationResponse, ApiConnectionActionConfiguration> MSOutlookGetNameSpaceInformation(Expression<Func<MSOutlookGetNameSpaceInformationInput>> mSOutlookGetNameSpaceInformation)
        {
            var __workflow_mSOutlookGetNameSpaceInformation = WorkflowExpression.Compile(mSOutlookGetNameSpaceInformation, nameof(mSOutlookGetNameSpaceInformation), required: true);
            return new DeferredBodyAction<MSOutlookGetNameSpaceInformationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSOutlook/GetNameSpaceInformation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSOutlookGetNameSpaceInformation);
                return new ApiConnectionAction<MSOutlookGetNameSpaceInformationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookGetMailFoldersResponse, ApiConnectionActionConfiguration> MSOutlookGetMailFolders(Expression<Func<MSOutlookGetMailFoldersInput>> mSOutlookGetMailFolders)
        {
            var __workflow_mSOutlookGetMailFolders = WorkflowExpression.Compile(mSOutlookGetMailFolders, nameof(mSOutlookGetMailFolders), required: true);
            return new DeferredBodyAction<MSOutlookGetMailFoldersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSOutlook/GetMailFolders";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSOutlookGetMailFolders);
                return new ApiConnectionAction<MSOutlookGetMailFoldersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSOutlookMarkEmailAsRead(Expression<Func<MSOutlookMarkEmailAsReadInput>> mSOutlookMarkEmailAsRead)
        {
            var __workflow_mSOutlookMarkEmailAsRead = WorkflowExpression.Compile(mSOutlookMarkEmailAsRead, nameof(mSOutlookMarkEmailAsRead), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSOutlook/MarkEmailAsRead";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSOutlookMarkEmailAsRead);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookGetEmailBodyResponse, ApiConnectionActionConfiguration> MSOutlookGetEmailBody(Expression<Func<MSOutlookGetEmailBodyInput>> mSOutlookGetEmailBody)
        {
            var __workflow_mSOutlookGetEmailBody = WorkflowExpression.Compile(mSOutlookGetEmailBody, nameof(mSOutlookGetEmailBody), required: true);
            return new DeferredBodyAction<MSOutlookGetEmailBodyResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSOutlook/GetEmailBody";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSOutlookGetEmailBody);
                return new ApiConnectionAction<MSOutlookGetEmailBodyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookGetEmailAttachmentFilenamesResponse, ApiConnectionActionConfiguration> MSOutlookGetEmailAttachmentFilenames(Expression<Func<MSOutlookGetEmailAttachmentFilenamesInput>> mSOutlookGetEmailAttachmentFilenames)
        {
            var __workflow_mSOutlookGetEmailAttachmentFilenames = WorkflowExpression.Compile(mSOutlookGetEmailAttachmentFilenames, nameof(mSOutlookGetEmailAttachmentFilenames), required: true);
            return new DeferredBodyAction<MSOutlookGetEmailAttachmentFilenamesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSOutlook/GetEmailAttachmentFilenames";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSOutlookGetEmailAttachmentFilenames);
                return new ApiConnectionAction<MSOutlookGetEmailAttachmentFilenamesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookSaveEmailAttachmentsAsFileResponse, ApiConnectionActionConfiguration> MSOutlookSaveEmailAttachmentsAsFile(Expression<Func<MSOutlookSaveEmailAttachmentsAsFileInput>> mSOutlookSaveEmailAttachmentsAsFile)
        {
            var __workflow_mSOutlookSaveEmailAttachmentsAsFile = WorkflowExpression.Compile(mSOutlookSaveEmailAttachmentsAsFile, nameof(mSOutlookSaveEmailAttachmentsAsFile), required: true);
            return new DeferredBodyAction<MSOutlookSaveEmailAttachmentsAsFileResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSOutlook/SaveEmailAttachmentsAsFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSOutlookSaveEmailAttachmentsAsFile);
                return new ApiConnectionAction<MSOutlookSaveEmailAttachmentsAsFileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSOutlookDeleteEmail(Expression<Func<MSOutlookDeleteEmailInput>> mSOutlookDeleteEmail)
        {
            var __workflow_mSOutlookDeleteEmail = WorkflowExpression.Compile(mSOutlookDeleteEmail, nameof(mSOutlookDeleteEmail), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSOutlook/DeleteEmail";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSOutlookDeleteEmail);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSOutlookMoveEmail(Expression<Func<MSOutlookMoveEmailInput>> mSOutlookMoveEmail)
        {
            var __workflow_mSOutlookMoveEmail = WorkflowExpression.Compile(mSOutlookMoveEmail, nameof(mSOutlookMoveEmail), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSOutlook/MoveEmail";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSOutlookMoveEmail);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSOutlookSendEmail(Expression<Func<MSOutlookSendEmailInput>> mSOutlookSendEmail)
        {
            var __workflow_mSOutlookSendEmail = WorkflowExpression.Compile(mSOutlookSendEmail, nameof(mSOutlookSendEmail), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSOutlook/SendEmail";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSOutlookSendEmail);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSOutlookCreateMailFolder(Expression<Func<MSOutlookCreateMailFolderInput>> mSOutlookCreateMailFolder)
        {
            var __workflow_mSOutlookCreateMailFolder = WorkflowExpression.Compile(mSOutlookCreateMailFolder, nameof(mSOutlookCreateMailFolder), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSOutlook/CreateMailFolder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSOutlookCreateMailFolder);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSOutlookReplyToEmail(Expression<Func<MSOutlookReplyToEmailInput>> mSOutlookReplyToEmail)
        {
            var __workflow_mSOutlookReplyToEmail = WorkflowExpression.Compile(mSOutlookReplyToEmail, nameof(mSOutlookReplyToEmail), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSOutlook/ReplyToEmail";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSOutlookReplyToEmail);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSOutlookForwardEmail(Expression<Func<MSOutlookForwardEmailInput>> mSOutlookForwardEmail)
        {
            var __workflow_mSOutlookForwardEmail = WorkflowExpression.Compile(mSOutlookForwardEmail, nameof(mSOutlookForwardEmail), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSOutlook/MSOutlookForwardEmail";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSOutlookForwardEmail);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookGetMAPIProfilesResponse, ApiConnectionActionConfiguration> MSOutlookGetMAPIProfiles(Expression<Func<MSOutlookGetMAPIProfilesInput>> mSOutlookGetMAPIProfiles)
        {
            var __workflow_mSOutlookGetMAPIProfiles = WorkflowExpression.Compile(mSOutlookGetMAPIProfiles, nameof(mSOutlookGetMAPIProfiles), required: true);
            return new DeferredBodyAction<MSOutlookGetMAPIProfilesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSOutlook/GetMAPIProfiles";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSOutlookGetMAPIProfiles);
                return new ApiConnectionAction<MSOutlookGetMAPIProfilesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookGetOutlookProcessIdResponse, ApiConnectionActionConfiguration> MSOutlookGetOutlookProcessId(Expression<Func<MSOutlookGetOutlookProcessIdInput>> mSOutlookGetOutlookProcessId)
        {
            var __workflow_mSOutlookGetOutlookProcessId = WorkflowExpression.Compile(mSOutlookGetOutlookProcessId, nameof(mSOutlookGetOutlookProcessId), required: true);
            return new DeferredBodyAction<MSOutlookGetOutlookProcessIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSOutlook/GetOutlookProcessId";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSOutlookGetOutlookProcessId);
                return new ApiConnectionAction<MSOutlookGetOutlookProcessIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSOutlookBackgroundMonitorForAllowPopup(Expression<Func<MSOutlookBackgroundMonitorForAllowPopupInput>> mSOutlookBackgroundMonitorForAllowPopup)
        {
            var __workflow_mSOutlookBackgroundMonitorForAllowPopup = WorkflowExpression.Compile(mSOutlookBackgroundMonitorForAllowPopup, nameof(mSOutlookBackgroundMonitorForAllowPopup), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSOutlook/BackgroundMonitorForAllowPopup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSOutlookBackgroundMonitorForAllowPopup);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MSOutlookSetAllowPopupDetails(Expression<Func<MSOutlookSetAllowPopupDetailsInput>> mSOutlookSetAllowPopupDetails)
        {
            var __workflow_mSOutlookSetAllowPopupDetails = WorkflowExpression.Compile(mSOutlookSetAllowPopupDetails, nameof(mSOutlookSetAllowPopupDetails), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSOutlook/MSOutlookSetAllowPopupDetails";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSOutlookSetAllowPopupDetails);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookExecuteCommandBarObjectResponse, ApiConnectionActionConfiguration> MSOutlookExecuteCommandBarObject(Expression<Func<MSOutlookExecuteCommandBarObjectInput>> mSOutlookExecuteCommandBarObject)
        {
            var __workflow_mSOutlookExecuteCommandBarObject = WorkflowExpression.Compile(mSOutlookExecuteCommandBarObject, nameof(mSOutlookExecuteCommandBarObject), required: true);
            return new DeferredBodyAction<MSOutlookExecuteCommandBarObjectResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSOutlook/MSOutlookExecuteCommandBarObject";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSOutlookExecuteCommandBarObject);
                return new ApiConnectionAction<MSOutlookExecuteCommandBarObjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookGetEmailsResponse, ApiConnectionActionConfiguration> MSOutlookGetEmails(Expression<Func<MSOutlookGetEmailsInput>> mSOutlookGetEmails)
        {
            var __workflow_mSOutlookGetEmails = WorkflowExpression.Compile(mSOutlookGetEmails, nameof(mSOutlookGetEmails), required: true);
            return new DeferredBodyAction<MSOutlookGetEmailsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSOutlook/GetEmails";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSOutlookGetEmails);
                return new ApiConnectionAction<MSOutlookGetEmailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookGetFirstEmailResponse, ApiConnectionActionConfiguration> MSOutlookGetFirstEmail(Expression<Func<MSOutlookGetFirstEmailInput>> mSOutlookGetFirstEmail)
        {
            var __workflow_mSOutlookGetFirstEmail = WorkflowExpression.Compile(mSOutlookGetFirstEmail, nameof(mSOutlookGetFirstEmail), required: true);
            return new DeferredBodyAction<MSOutlookGetFirstEmailResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSOutlook/GetFirstEmail";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSOutlookGetFirstEmail);
                return new ApiConnectionAction<MSOutlookGetFirstEmailResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookGetNumberOfEmailsResponse, ApiConnectionActionConfiguration> MSOutlookGetNumberOfEmails(Expression<Func<MSOutlookGetNumberOfEmailsInput>> mSOutlookGetNumberOfEmails)
        {
            var __workflow_mSOutlookGetNumberOfEmails = WorkflowExpression.Compile(mSOutlookGetNumberOfEmails, nameof(mSOutlookGetNumberOfEmails), required: true);
            return new DeferredBodyAction<MSOutlookGetNumberOfEmailsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MSOutlook/GetNumberOfEmails";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mSOutlookGetNumberOfEmails);
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

    public class MSWordCreateInstanceInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ShowWord { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSWordCloseInstanceInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSWordDetachFromInstanceInput
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

    public class MSWordAttachToExistingInstanceInput
    {
        public string Filename { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ToggleWindow { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ToggleUsesGlobalLeftMouseClickAgent { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? ToggleDelay { get; set; } = 0.5;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSWordShowWordInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSWordHideWordInput
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

    public class MSWordCreateDocumentInput
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

    public class MSWordOpenDocumentInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Filename { get; set; }

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

    public class MSWordSaveDocumentInput
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

    public class MSWordSaveAsDocumentInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string DocumentName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SaveFilename { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSWordCloseDocumentInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string DocumentName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSWordTypeTextInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Text { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSWordSelectAllInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string DocumentName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSWordSelectRangeInput
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

    public class MSWordCopyToClipboardInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSWordPasteFromClipboardInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSWordClearClipboardInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSWordGetDocumentBodyTextResponse
    {
        public string BodyText { get; set; }
    }

    public class MSWordGetDocumentBodyTextInput
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

    public class MSWordGetNumberOfTablesInDocumentInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string DocumentName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSWordUpdateBookmarkInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string DocumentName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string BookmarkName { get; set; }
        public string NewValue { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSWordSelectTableInput
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

    public class MSWordGetTableBoundsInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string DocumentName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int TableIndex { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSWordSelectTableCellInput
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

    public class MSWordGetTableCellTextValueInput
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

    public class MSWordGetTableCellTextValueTrimmedInput
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

    public class MSWordSetTableCellTextValueInput
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

    public class MSWordExportDocumentAsPDFInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string DocumentName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SaveFileName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSWordAddTableInput
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

    public class MSWordAddTableRowInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string DocumentName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int TableIndex { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSWordAddTableColumnInput
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
        public string HighlightedTextJSON { get; set; }
    }

    public class MSWordGetHighlightedTextInput
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

    public class MSWordExecuteCommandBarObjectInput
    {
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

    public class MSWordSetDocumentSensitivityLabelInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string DocumentName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public MSWordSetDocumentSensitivityLabelInputAssignmentMethodType AssignmentMethod { get; set; } = MSWordSetDocumentSensitivityLabelInputAssignmentMethodType.NotSet;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string LabelId { get; set; }
        public string LabelName { get; set; }
        public string SiteId { get; set; }
        public string Justification { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MSWordSetDocumentSensitivityLabelInputAssignmentMethodType
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

    public class MSWordGetDocumentSensitivityLabelInput
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

    public class MSExcelCreateInstanceInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? EnableEvents { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ShowExcel { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSExcelCloseInstanceInput
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

    public class MSExcelAttachToExistingInstanceInput
    {
        public string Filename { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ToggleWindow { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ToggleUsesGlobalLeftMouseClickAgent { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? ToggleDelay { get; set; } = 0.5;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSExcelShowExcelInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSExcelHideExcelInput
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

    public class MSExcelOpenWorkbookInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string Filename { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReadOnly { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? UpdateLinks { get; set; } = false;
        public string Password { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? EnableEvents { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? PutHTTPWorkbooksIntoEditMode { get; set; } = true;

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

    public class MSExcelPutWorkbookInEditModeInput
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

    public class MSExcelCreateWorkbookInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSExcelCloseWorkbookInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string WorkbookName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SaveData { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSExcelCloseCurrentWorkbookInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSExcelGoToCellInput
    {
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

    public class MSExcelGetCellValueInput
    {
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

    public class MSExcelGetCellValue2Input
    {
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

    public class MSExcelGetCellTextInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string WorkbookName { get; set; }
        public string WorksheetName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string CellReference { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSExcelSetCellValueInput
    {
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

    public class MSExcelFindNextCellWithValueInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string WorkbookName { get; set; }
        public string WorksheetName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public MSExcelFindNextCellWithValueInputDirectionType Direction { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchValue { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CaseSensitive { get; set; } = false;
        public MSExcelFindNextCellWithValueInputComparisonTypeType? ComparisonType { get; set; }
        public int? MaxCellsToSearch { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ActivateCell { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MSExcelFindNextCellWithValueInputDirectionType
    {
        U,
        D,
        L,
        R
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MSExcelFindNextCellWithValueInputComparisonTypeType
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

    public class MSExcelFindNextEmptyCellInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string WorkbookName { get; set; }
        public string WorksheetName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public MSExcelFindNextEmptyCellInputDirectionType Direction { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ActivateCell { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MSExcelFindNextEmptyCellInputDirectionType
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

    public class MSExcelGotoNextEmptyCellLeftInput
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

    public class MSExcelGotoNextEmptyCellRightInput
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

    public class MSExcelGotoNextEmptyCellUpInput
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

    public class MSExcelGotoNextEmptyCellDownInput
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

    public class MSExcelSaveWorkbookInput
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

    public class MSExcelSaveWorkbookAsInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string WorkbookName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SaveFilename { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? DeleteExistingSaveFilename { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public MSExcelSaveWorkbookAsInputExcelFileFormatType? ExcelFileFormat { get; set; } = MSExcelSaveWorkbookAsInputExcelFileFormatType.AutomaticFromFileExtension;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MSExcelSaveWorkbookAsInputExcelFileFormatType
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
        CSVUTF8CommaDelimited,
        [EnumMember(Value = "CSVWindows")]
        CSVCommaDelimited
    }

    public class MSExcelSaveWorkbookAsCSVResponse
    {
        public string NewWorkbookName { get; set; }
    }

    public class MSExcelSaveWorkbookAsCSVInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string WorkbookName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SaveFilename { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? DeleteExistingSaveFilename { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSExcelSaveWorkbookAsWithPasswordResponse
    {
        public string NewWorkbookName { get; set; }
    }

    public class MSExcelSaveWorkbookAsWithPasswordInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string WorkbookName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SaveFilename { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Password { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? DeleteExistingSaveFilename { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public MSExcelSaveWorkbookAsWithPasswordInputExcelFileFormatType? ExcelFileFormat { get; set; } = MSExcelSaveWorkbookAsWithPasswordInputExcelFileFormatType.AutomaticFromFileExtension;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MSExcelSaveWorkbookAsWithPasswordInputExcelFileFormatType
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

    public class MSExcelSaveCurrentWorkbookInput
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

    public class MSExcelSaveCurrentWorkbookAsInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string SaveFilename { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? DeleteExistingSaveFilename { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public MSExcelSaveCurrentWorkbookAsInputExcelFileFormatType? ExcelFileFormat { get; set; } = MSExcelSaveCurrentWorkbookAsInputExcelFileFormatType.AutomaticFromFileExtension;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MSExcelSaveCurrentWorkbookAsInputExcelFileFormatType
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
        CSVUTF8CommaDelimited,
        [EnumMember(Value = "CSVWindows")]
        CSVCommaDelimited
    }

    public class MSExcelSaveCurrentWorkbookAsCSVResponse
    {
        public string NewWorkbookName { get; set; }
    }

    public class MSExcelSaveCurrentWorkbookAsCSVInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SaveFilename { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? DeleteExistingSaveFilename { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSExcelGetWorksheetNamesResponse
    {
        public JToken[] WorksheetNames { get; set; }
    }

    public class MSExcelGetWorksheetNamesInput
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

    public class MSExcelGetWorksheetNameInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string WorkbookName { get; set; }
        public int? Position { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSExcelActivateWorksheetInput
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

    public class MSExcelCreateWorksheetInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string WorkbookName { get; set; }
        public string WorksheetName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSExcelDeleteWorksheetInput
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
        public string WorksheetCollectionJSON { get; set; }
    }

    public class MSExcelGetWorksheetAsCollectionEnhancedInput
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

    public class MSExcelGetNumberOfRowsInput
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

    public class MSExcelEvaluateExpressionInput
    {
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

    public class MSExcelGetWorksheetUsedRangeInput
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

    public class MSExcelGetCountrySettingInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSExcelWriteCollectionInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string WorkbookName { get; set; }
        public string WorksheetName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string CellReference { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string CollectionToWriteJSON { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IncludeColumnNames { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSExcelWriteCollectionWithDatesInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string WorkbookName { get; set; }
        public string WorksheetName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string CellReference { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string CollectionToWriteJSON { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IncludeColumnNames { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? TryToConvertAllFieldsToDate { get; set; } = false;
        public string ColumnsToConvertToDateJSON { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSExcelGetActiveCellResponse
    {
        public string CellReference { get; set; }
        public int RowIndex { get; set; }
        public int ColumnIndex { get; set; }
    }

    public class MSExcelGetActiveCellInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSExcelFormatCellInput
    {
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

    public class MSExcelFormatCurrentCellInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string CellFormat { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSExcelSelectCellRangeInput
    {
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

    public class MSExcelCopySelectionInput
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

    public class MSExcelCutSelectionInput
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

    public class MSExcelPasteIntoSelectionInput
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

    public class MSExcelInsertOnSelectionInput
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
        public MSExcelInsertOnSelectionInputShiftType? Shift { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MSExcelInsertOnSelectionInputShiftType
    {
        R,
        D
    }

    public class MSExcelDeleteSelectionInput
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
        public MSExcelDeleteSelectionInputShiftType? Shift { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MSExcelDeleteSelectionInputShiftType
    {
        L,
        U
    }

    public class MSExcelClearExcelClipboardInput
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

    public class MSExcelRunMacroInput
    {
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

    public class MSExcelAddMacroToWorkbookInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string WorkbookName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string MacroCode { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSExcelTrustVBOMInRegistryInput
    {
        public int? ExcelVersion { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? TrustVBOM { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSExcelSetCalculationModeInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int CalculationMode { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSExcelExecuteCommandBarObjectInput
    {
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

    public class MSExcelCopyBetweenCellsInput
    {
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

    public class MSExcelCutBetweenCellsInput
    {
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

    public class MSExcelMinimiseWindowInput
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

    public class MSExcelMaximiseWindowInput
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

    public class MSExcelNormaliseWindowInput
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

    public class MSExcelGetAndSetCellValueInput
    {
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

    public class MSExcelGetAndSetCellValue2Input
    {
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

    public class MSExcelGetAndSetCellTextInput
    {
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

    public class MSExcelCheckOLEObjectResponse
    {
        public bool MSExcelCheckOLEObjectResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class MSExcelCheckOLEObjectInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string WorkbookName { get; set; }
        public string WorksheetName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string OLEObjectName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Checked { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RunInBackground { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSExcelInputTextIntoOLEObjectResponse
    {
        public bool MSExcelInputTextIntoOLEObjectResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class MSExcelInputTextIntoOLEObjectInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string WorkbookName { get; set; }
        public string WorksheetName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string OLEObjectName { get; set; }
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

    public class MSExcelSetCellBackgroundColourInput
    {
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

    public class MSExcelGetCellBackgroundColourInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string WorkbookName { get; set; }
        public string WorksheetName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string CellReference { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSExcelGetOLEObjectValueResponse
    {
        public string OLEObjectValue { get; set; }
    }

    public class MSExcelGetOLEObjectValueInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string WorkbookName { get; set; }
        public string WorksheetName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string OLEObjectName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSExcelDoesOLEObjectExistResponse
    {
        public bool OLEObjectExists { get; set; }
    }

    public class MSExcelDoesOLEObjectExistInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string WorkbookName { get; set; }
        public string WorksheetName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string OLEObjectName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSExcelPressOLEObjectResponse
    {
        public bool MSExcelPressOLEObjectResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class MSExcelPressOLEObjectInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string WorkbookName { get; set; }
        public string WorksheetName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string OLEObjectName { get; set; }

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

    public class MSExcelSetWorksheetSensitivityLabelInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string WorkbookName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public MSExcelSetWorksheetSensitivityLabelInputAssignmentMethodType AssignmentMethod { get; set; } = MSExcelSetWorksheetSensitivityLabelInputAssignmentMethodType.NotSet;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string LabelId { get; set; }
        public string LabelName { get; set; }
        public string SiteId { get; set; }
        public string Justification { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MSExcelSetWorksheetSensitivityLabelInputAssignmentMethodType
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

    public class MSExcelGetWorksheetSensitivityLabelInput
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

    public class MSExcelWriteArrayInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Handle { get; set; } = 0;
        public string WorkbookName { get; set; }
        public string WorksheetName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string CellReference { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ArrayToWriteJSON { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public MSExcelWriteArrayInputDirectionType Direction { get; set; } = MSExcelWriteArrayInputDirectionType.R;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MSExcelWriteArrayInputDirectionType
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

    public class MSOutlookCreateInstanceInput
    {
        public string ProfileName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ShowOutlook { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSOutlookCloseInstanceInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? SecondsToWaitForProcessToClose { get; set; } = 10;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSOutlookCloseInstanceUsingWindowInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? UseNativeWindow { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? UseUIA { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? SecondsToWaitForProcessToClose { get; set; } = 10;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSOutlookAttachToExistingInstanceResponse
    {
        public string CurrentProfileName { get; set; }
    }

    public class MSOutlookAttachToExistingInstanceInput
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

    public class MSOutlookIsConnectedInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSOutlookShowInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSOutlookGetNameSpaceInformationResponse
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

    public class MSOutlookGetNameSpaceInformationInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSOutlookGetMailFoldersResponse
    {
        public string MailFoldersJSON { get; set; }
    }

    public class MSOutlookGetMailFoldersInput
    {
        public string FolderPath { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SubFolders { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSOutlookMarkEmailAsReadInput
    {
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

    public class MSOutlookGetEmailBodyInput
    {
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
        public string EmailAttachmentFilenamesJSON { get; set; }
    }

    public class MSOutlookGetEmailAttachmentFilenamesInput
    {
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
        public string EmailAttachmentSaveAsFilenamesJSON { get; set; }
    }

    public class MSOutlookSaveEmailAttachmentsAsFileInput
    {
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

    public class MSOutlookDeleteEmailInput
    {
        [JsonProperty("EntryID", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EntryId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSOutlookMoveEmailInput
    {
        [JsonProperty("EntryID", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EntryId { get; set; }
        public string DestinationFolder { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSOutlookSendEmailInput
    {
        public string To { get; set; }
        public string CC { get; set; }
        public string BCC { get; set; }
        public string Subject { get; set; }
        public MSOutlookSendEmailInputBodyFormatType? BodyFormat { get; set; }
        public string Body { get; set; }
        public string HTMLBody { get; set; }
        public string RTFBody { get; set; }
        public string AttachmentFilenamesJSON { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? DontSendIfAttachmentFilenameMissing { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ClickAllowButtonIfRequired { get; set; } = true;
        public string VotingOptions { get; set; }
        public string SendAsSMTPAddress { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? BodyContainsStoredPassword { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MSOutlookSendEmailInputBodyFormatType
    {
        HTML,
        Plain,
        RTF
    }

    public class MSOutlookCreateMailFolderInput
    {
        public string ParentFolderPath { get; set; }
        public string NewFolderName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSOutlookReplyToEmailInput
    {
        [JsonProperty("EntryID", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EntryId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReplyToAll { get; set; } = false;
        public MSOutlookReplyToEmailInputBodyFormatType? BodyFormat { get; set; }
        public string Body { get; set; }
        public string HTMLBody { get; set; }
        public string RTFBody { get; set; }
        public string AttachmentFilenamesJSON { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? DontSendIfAttachmentFilenameMissing { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ClickAllowButtonIfRequired { get; set; } = true;
        public string VotingOptions { get; set; }
        public string SendAsSMTPAddress { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? BodyContainsStoredPassword { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MSOutlookReplyToEmailInputBodyFormatType
    {
        HTML,
        Plain,
        RTF
    }

    public class MSOutlookForwardEmailInput
    {
        [JsonProperty("EntryID", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EntryId { get; set; }
        public string To { get; set; }
        public string CC { get; set; }
        public string BCC { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OverrideSubject { get; set; } = false;
        public string Subject { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OverrideBody { get; set; } = false;
        public MSOutlookForwardEmailInputBodyFormatType? BodyFormat { get; set; }
        public string Body { get; set; }
        public string HTMLBody { get; set; }
        public string RTFBody { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ClickAllowButtonIfRequired { get; set; } = true;
        public string VotingOptions { get; set; }
        public string SendAsSMTPAddress { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IncludeExistingHiddenAttachments { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IncludeExistingVisibleAttachments { get; set; } = false;
        public string AttachmentFilenamesJSON { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? DontSendIfAttachmentFilenameMissing { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? BodyContainsStoredPassword { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MSOutlookForwardEmailInputBodyFormatType
    {
        HTML,
        Plain,
        RTF
    }

    public class MSOutlookGetMAPIProfilesResponse
    {
        public int NumberOfMAPIProfiles { get; set; }
        public string MAPIProfilesJSON { get; set; }
        public string DefaultMAPIProfile { get; set; }
    }

    public class MSOutlookGetMAPIProfilesInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSOutlookGetOutlookProcessIdResponse
    {
        public int ProcessId { get; set; }
    }

    public class MSOutlookGetOutlookProcessIdInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MSOutlookBackgroundMonitorForAllowPopupInput
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

    public class MSOutlookSetAllowPopupDetailsInput
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

    public class MSOutlookExecuteCommandBarObjectInput
    {
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
        public string EmailsJSON { get; set; }
    }

    public class MSOutlookGetEmailsInput
    {
        public string FolderPath { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchRead { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchUnread { get; set; } = true;
        public string SearchSubject { get; set; }
        public string SearchFromSMTP { get; set; }
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

    public class MSOutlookGetFirstEmailInput
    {
        public string FolderPath { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchRead { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchUnread { get; set; } = true;
        public string SearchSubject { get; set; }
        public string SearchFromSMTP { get; set; }
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

    public class MSOutlookGetNumberOfEmailsInput
    {
        public string FolderPath { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchRead { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchUnread { get; set; } = true;
        public string SearchSubject { get; set; }
        public string SearchFromSMTP { get; set; }
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