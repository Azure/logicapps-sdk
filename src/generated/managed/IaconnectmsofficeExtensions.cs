//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectmsoffice
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IaconnectmsofficeActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordCreateInstanceResponse> MSWordCreateInstance(Expression<Func<string>> mSWordCreateInstanceWorkflow, Expression<Func<bool>> mSWordCreateInstanceShowWord = null)
        {
            var apiCallPath = "/MSWord/CreateInstance";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSWordCreateInstance = new JObject();
            var mSWordCreateInstancepropCount = 0;
            if (mSWordCreateInstanceShowWord != null)
            {
                mSWordCreateInstance["ShowWord"] = ExpressionConverter.ConvertO(mSWordCreateInstanceShowWord);
                mSWordCreateInstancepropCount++;
            }

            mSWordCreateInstancepropCount++;
            mSWordCreateInstance["Workflow"] = ExpressionConverter.ConvertO(mSWordCreateInstanceWorkflow);
            if (mSWordCreateInstancepropCount > 0)
            {
                callPayload.Body = mSWordCreateInstance;
            }

            return new ApiConnectionAction<MSWordCreateInstanceResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordCloseInstance(Expression<Func<string>> mSWordCloseInstanceWorkflow, Expression<Func<int>> mSWordCloseInstanceHandle = null)
        {
            var apiCallPath = "/MSWord/CloseInstance";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSWordCloseInstance = new JObject();
            var mSWordCloseInstancepropCount = 0;
            if (mSWordCloseInstanceHandle != null)
            {
                mSWordCloseInstance["Handle"] = ExpressionConverter.ConvertO(mSWordCloseInstanceHandle);
                mSWordCloseInstancepropCount++;
            }

            mSWordCloseInstancepropCount++;
            mSWordCloseInstance["Workflow"] = ExpressionConverter.ConvertO(mSWordCloseInstanceWorkflow);
            if (mSWordCloseInstancepropCount > 0)
            {
                callPayload.Body = mSWordCloseInstance;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordDetachFromInstance(Expression<Func<string>> mSWordDetachFromInstanceWorkflow, Expression<Func<int>> mSWordDetachFromInstanceHandle = null)
        {
            var apiCallPath = "/MSWord/DetachFromInstance";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSWordDetachFromInstance = new JObject();
            var mSWordDetachFromInstancepropCount = 0;
            if (mSWordDetachFromInstanceHandle != null)
            {
                mSWordDetachFromInstance["Handle"] = ExpressionConverter.ConvertO(mSWordDetachFromInstanceHandle);
                mSWordDetachFromInstancepropCount++;
            }

            mSWordDetachFromInstancepropCount++;
            mSWordDetachFromInstance["Workflow"] = ExpressionConverter.ConvertO(mSWordDetachFromInstanceWorkflow);
            if (mSWordDetachFromInstancepropCount > 0)
            {
                callPayload.Body = mSWordDetachFromInstance;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordAttachToExistingInstanceResponse> MSWordAttachToExistingInstance(Expression<Func<string>> mSWordAttachToExistingInstanceWorkflow, Expression<Func<string>> mSWordAttachToExistingInstanceFilename = null, Expression<Func<bool>> mSWordAttachToExistingInstanceToggleWindow = null, Expression<Func<bool>> mSWordAttachToExistingInstanceToggleUsesGlobalLeftMouseClickAgent = null, Expression<Func<double>> mSWordAttachToExistingInstanceToggleDelay = null)
        {
            var apiCallPath = "/MSWord/AttachToExistingInstance";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSWordAttachToExistingInstance = new JObject();
            var mSWordAttachToExistingInstancepropCount = 0;
            if (mSWordAttachToExistingInstanceFilename != null)
            {
                mSWordAttachToExistingInstance["Filename"] = ExpressionConverter.ConvertO(mSWordAttachToExistingInstanceFilename);
                mSWordAttachToExistingInstancepropCount++;
            }

            if (mSWordAttachToExistingInstanceToggleWindow != null)
            {
                mSWordAttachToExistingInstance["ToggleWindow"] = ExpressionConverter.ConvertO(mSWordAttachToExistingInstanceToggleWindow);
                mSWordAttachToExistingInstancepropCount++;
            }

            if (mSWordAttachToExistingInstanceToggleUsesGlobalLeftMouseClickAgent != null)
            {
                mSWordAttachToExistingInstance["ToggleUsesGlobalLeftMouseClickAgent"] = ExpressionConverter.ConvertO(mSWordAttachToExistingInstanceToggleUsesGlobalLeftMouseClickAgent);
                mSWordAttachToExistingInstancepropCount++;
            }

            if (mSWordAttachToExistingInstanceToggleDelay != null)
            {
                mSWordAttachToExistingInstance["ToggleDelay"] = ExpressionConverter.ConvertO(mSWordAttachToExistingInstanceToggleDelay);
                mSWordAttachToExistingInstancepropCount++;
            }

            mSWordAttachToExistingInstancepropCount++;
            mSWordAttachToExistingInstance["Workflow"] = ExpressionConverter.ConvertO(mSWordAttachToExistingInstanceWorkflow);
            if (mSWordAttachToExistingInstancepropCount > 0)
            {
                callPayload.Body = mSWordAttachToExistingInstance;
            }

            return new ApiConnectionAction<MSWordAttachToExistingInstanceResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordShowWord(Expression<Func<string>> mSWordShowWordWorkflow, Expression<Func<int>> mSWordShowWordHandle = null)
        {
            var apiCallPath = "/MSWord/ShowWord";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSWordShowWord = new JObject();
            var mSWordShowWordpropCount = 0;
            if (mSWordShowWordHandle != null)
            {
                mSWordShowWord["Handle"] = ExpressionConverter.ConvertO(mSWordShowWordHandle);
                mSWordShowWordpropCount++;
            }

            mSWordShowWordpropCount++;
            mSWordShowWord["Workflow"] = ExpressionConverter.ConvertO(mSWordShowWordWorkflow);
            if (mSWordShowWordpropCount > 0)
            {
                callPayload.Body = mSWordShowWord;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordHideWord(Expression<Func<string>> mSWordHideWordWorkflow, Expression<Func<int>> mSWordHideWordHandle = null)
        {
            var apiCallPath = "/MSWord/HideWord";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSWordHideWord = new JObject();
            var mSWordHideWordpropCount = 0;
            if (mSWordHideWordHandle != null)
            {
                mSWordHideWord["Handle"] = ExpressionConverter.ConvertO(mSWordHideWordHandle);
                mSWordHideWordpropCount++;
            }

            mSWordHideWordpropCount++;
            mSWordHideWord["Workflow"] = ExpressionConverter.ConvertO(mSWordHideWordWorkflow);
            if (mSWordHideWordpropCount > 0)
            {
                callPayload.Body = mSWordHideWord;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordCreateDocumentResponse> MSWordCreateDocument(Expression<Func<string>> mSWordCreateDocumentWorkflow, Expression<Func<int>> mSWordCreateDocumentHandle = null)
        {
            var apiCallPath = "/MSWord/CreateDocument";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSWordCreateDocument = new JObject();
            var mSWordCreateDocumentpropCount = 0;
            if (mSWordCreateDocumentHandle != null)
            {
                mSWordCreateDocument["Handle"] = ExpressionConverter.ConvertO(mSWordCreateDocumentHandle);
                mSWordCreateDocumentpropCount++;
            }

            mSWordCreateDocumentpropCount++;
            mSWordCreateDocument["Workflow"] = ExpressionConverter.ConvertO(mSWordCreateDocumentWorkflow);
            if (mSWordCreateDocumentpropCount > 0)
            {
                callPayload.Body = mSWordCreateDocument;
            }

            return new ApiConnectionAction<MSWordCreateDocumentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordOpenDocumentResponse> MSWordOpenDocument(Expression<Func<string>> mSWordOpenDocumentFilename, Expression<Func<string>> mSWordOpenDocumentWorkflow, Expression<Func<int>> mSWordOpenDocumentHandle = null, Expression<Func<bool>> mSWordOpenDocumentOpenReadOnly = null, Expression<Func<bool>> mSWordOpenDocumentAddToRecentFiles = null, Expression<Func<string>> mSWordOpenDocumentPassword = null, Expression<Func<bool>> mSWordOpenDocumentOpenAndRepair = null)
        {
            var apiCallPath = "/MSWord/OpenDocument";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSWordOpenDocument = new JObject();
            var mSWordOpenDocumentpropCount = 0;
            if (mSWordOpenDocumentHandle != null)
            {
                mSWordOpenDocument["Handle"] = ExpressionConverter.ConvertO(mSWordOpenDocumentHandle);
                mSWordOpenDocumentpropCount++;
            }

            mSWordOpenDocumentpropCount++;
            mSWordOpenDocument["Filename"] = ExpressionConverter.ConvertO(mSWordOpenDocumentFilename);
            if (mSWordOpenDocumentOpenReadOnly != null)
            {
                mSWordOpenDocument["OpenReadOnly"] = ExpressionConverter.ConvertO(mSWordOpenDocumentOpenReadOnly);
                mSWordOpenDocumentpropCount++;
            }

            if (mSWordOpenDocumentAddToRecentFiles != null)
            {
                mSWordOpenDocument["AddToRecentFiles"] = ExpressionConverter.ConvertO(mSWordOpenDocumentAddToRecentFiles);
                mSWordOpenDocumentpropCount++;
            }

            if (mSWordOpenDocumentPassword != null)
            {
                mSWordOpenDocument["Password"] = ExpressionConverter.ConvertO(mSWordOpenDocumentPassword);
                mSWordOpenDocumentpropCount++;
            }

            if (mSWordOpenDocumentOpenAndRepair != null)
            {
                mSWordOpenDocument["OpenAndRepair"] = ExpressionConverter.ConvertO(mSWordOpenDocumentOpenAndRepair);
                mSWordOpenDocumentpropCount++;
            }

            mSWordOpenDocumentpropCount++;
            mSWordOpenDocument["Workflow"] = ExpressionConverter.ConvertO(mSWordOpenDocumentWorkflow);
            if (mSWordOpenDocumentpropCount > 0)
            {
                callPayload.Body = mSWordOpenDocument;
            }

            return new ApiConnectionAction<MSWordOpenDocumentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordSaveDocument(Expression<Func<string>> mSWordSaveDocumentWorkflow, Expression<Func<int>> mSWordSaveDocumentHandle = null, Expression<Func<string>> mSWordSaveDocumentDocumentName = null)
        {
            var apiCallPath = "/MSWord/Save";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSWordSaveDocument = new JObject();
            var mSWordSaveDocumentpropCount = 0;
            if (mSWordSaveDocumentHandle != null)
            {
                mSWordSaveDocument["Handle"] = ExpressionConverter.ConvertO(mSWordSaveDocumentHandle);
                mSWordSaveDocumentpropCount++;
            }

            if (mSWordSaveDocumentDocumentName != null)
            {
                mSWordSaveDocument["DocumentName"] = ExpressionConverter.ConvertO(mSWordSaveDocumentDocumentName);
                mSWordSaveDocumentpropCount++;
            }

            mSWordSaveDocumentpropCount++;
            mSWordSaveDocument["Workflow"] = ExpressionConverter.ConvertO(mSWordSaveDocumentWorkflow);
            if (mSWordSaveDocumentpropCount > 0)
            {
                callPayload.Body = mSWordSaveDocument;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordSaveAsDocumentResponse> MSWordSaveAsDocument(Expression<Func<string>> mSWordSaveAsDocumentSaveFilename, Expression<Func<string>> mSWordSaveAsDocumentWorkflow, Expression<Func<int>> mSWordSaveAsDocumentHandle = null, Expression<Func<string>> mSWordSaveAsDocumentDocumentName = null)
        {
            var apiCallPath = "/MSWord/SaveAs";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSWordSaveAsDocument = new JObject();
            var mSWordSaveAsDocumentpropCount = 0;
            if (mSWordSaveAsDocumentHandle != null)
            {
                mSWordSaveAsDocument["Handle"] = ExpressionConverter.ConvertO(mSWordSaveAsDocumentHandle);
                mSWordSaveAsDocumentpropCount++;
            }

            if (mSWordSaveAsDocumentDocumentName != null)
            {
                mSWordSaveAsDocument["DocumentName"] = ExpressionConverter.ConvertO(mSWordSaveAsDocumentDocumentName);
                mSWordSaveAsDocumentpropCount++;
            }

            mSWordSaveAsDocumentpropCount++;
            mSWordSaveAsDocument["SaveFilename"] = ExpressionConverter.ConvertO(mSWordSaveAsDocumentSaveFilename);
            mSWordSaveAsDocumentpropCount++;
            mSWordSaveAsDocument["Workflow"] = ExpressionConverter.ConvertO(mSWordSaveAsDocumentWorkflow);
            if (mSWordSaveAsDocumentpropCount > 0)
            {
                callPayload.Body = mSWordSaveAsDocument;
            }

            return new ApiConnectionAction<MSWordSaveAsDocumentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordCloseDocument(Expression<Func<string>> mSWordCloseDocumentWorkflow, Expression<Func<int>> mSWordCloseDocumentHandle = null, Expression<Func<string>> mSWordCloseDocumentDocumentName = null)
        {
            var apiCallPath = "/MSWord/CloseDocument";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSWordCloseDocument = new JObject();
            var mSWordCloseDocumentpropCount = 0;
            if (mSWordCloseDocumentHandle != null)
            {
                mSWordCloseDocument["Handle"] = ExpressionConverter.ConvertO(mSWordCloseDocumentHandle);
                mSWordCloseDocumentpropCount++;
            }

            if (mSWordCloseDocumentDocumentName != null)
            {
                mSWordCloseDocument["DocumentName"] = ExpressionConverter.ConvertO(mSWordCloseDocumentDocumentName);
                mSWordCloseDocumentpropCount++;
            }

            mSWordCloseDocumentpropCount++;
            mSWordCloseDocument["Workflow"] = ExpressionConverter.ConvertO(mSWordCloseDocumentWorkflow);
            if (mSWordCloseDocumentpropCount > 0)
            {
                callPayload.Body = mSWordCloseDocument;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordTypeText(Expression<Func<string>> mSWordTypeTextText, Expression<Func<string>> mSWordTypeTextWorkflow, Expression<Func<int>> mSWordTypeTextHandle = null)
        {
            var apiCallPath = "/MSWord/TypeText";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSWordTypeText = new JObject();
            var mSWordTypeTextpropCount = 0;
            if (mSWordTypeTextHandle != null)
            {
                mSWordTypeText["Handle"] = ExpressionConverter.ConvertO(mSWordTypeTextHandle);
                mSWordTypeTextpropCount++;
            }

            mSWordTypeTextpropCount++;
            mSWordTypeText["Text"] = ExpressionConverter.ConvertO(mSWordTypeTextText);
            mSWordTypeTextpropCount++;
            mSWordTypeText["Workflow"] = ExpressionConverter.ConvertO(mSWordTypeTextWorkflow);
            if (mSWordTypeTextpropCount > 0)
            {
                callPayload.Body = mSWordTypeText;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordSelectAll(Expression<Func<string>> mSWordSelectAllWorkflow, Expression<Func<int>> mSWordSelectAllHandle = null, Expression<Func<string>> mSWordSelectAllDocumentName = null)
        {
            var apiCallPath = "/MSWord/SelectAll";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSWordSelectAll = new JObject();
            var mSWordSelectAllpropCount = 0;
            if (mSWordSelectAllHandle != null)
            {
                mSWordSelectAll["Handle"] = ExpressionConverter.ConvertO(mSWordSelectAllHandle);
                mSWordSelectAllpropCount++;
            }

            if (mSWordSelectAllDocumentName != null)
            {
                mSWordSelectAll["DocumentName"] = ExpressionConverter.ConvertO(mSWordSelectAllDocumentName);
                mSWordSelectAllpropCount++;
            }

            mSWordSelectAllpropCount++;
            mSWordSelectAll["Workflow"] = ExpressionConverter.ConvertO(mSWordSelectAllWorkflow);
            if (mSWordSelectAllpropCount > 0)
            {
                callPayload.Body = mSWordSelectAll;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordSelectRange(Expression<Func<int>> mSWordSelectRangeStart, Expression<Func<int>> mSWordSelectRangeFinish, Expression<Func<string>> mSWordSelectRangeWorkflow, Expression<Func<int>> mSWordSelectRangeHandle = null, Expression<Func<string>> mSWordSelectRangeDocumentName = null)
        {
            var apiCallPath = "/MSWord/SelectRange";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSWordSelectRange = new JObject();
            var mSWordSelectRangepropCount = 0;
            if (mSWordSelectRangeHandle != null)
            {
                mSWordSelectRange["Handle"] = ExpressionConverter.ConvertO(mSWordSelectRangeHandle);
                mSWordSelectRangepropCount++;
            }

            if (mSWordSelectRangeDocumentName != null)
            {
                mSWordSelectRange["DocumentName"] = ExpressionConverter.ConvertO(mSWordSelectRangeDocumentName);
                mSWordSelectRangepropCount++;
            }

            mSWordSelectRangepropCount++;
            mSWordSelectRange["Start"] = ExpressionConverter.ConvertO(mSWordSelectRangeStart);
            mSWordSelectRangepropCount++;
            mSWordSelectRange["Finish"] = ExpressionConverter.ConvertO(mSWordSelectRangeFinish);
            mSWordSelectRangepropCount++;
            mSWordSelectRange["Workflow"] = ExpressionConverter.ConvertO(mSWordSelectRangeWorkflow);
            if (mSWordSelectRangepropCount > 0)
            {
                callPayload.Body = mSWordSelectRange;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordCopyToClipboard(Expression<Func<string>> mSWordCopyToClipboardWorkflow, Expression<Func<int>> mSWordCopyToClipboardHandle = null)
        {
            var apiCallPath = "/MSWord/CopyToClipboard";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSWordCopyToClipboard = new JObject();
            var mSWordCopyToClipboardpropCount = 0;
            if (mSWordCopyToClipboardHandle != null)
            {
                mSWordCopyToClipboard["Handle"] = ExpressionConverter.ConvertO(mSWordCopyToClipboardHandle);
                mSWordCopyToClipboardpropCount++;
            }

            mSWordCopyToClipboardpropCount++;
            mSWordCopyToClipboard["Workflow"] = ExpressionConverter.ConvertO(mSWordCopyToClipboardWorkflow);
            if (mSWordCopyToClipboardpropCount > 0)
            {
                callPayload.Body = mSWordCopyToClipboard;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordPasteFromClipboard(Expression<Func<string>> mSWordPasteFromClipboardWorkflow, Expression<Func<int>> mSWordPasteFromClipboardHandle = null)
        {
            var apiCallPath = "/MSWord/PasteFromClipboard";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSWordPasteFromClipboard = new JObject();
            var mSWordPasteFromClipboardpropCount = 0;
            if (mSWordPasteFromClipboardHandle != null)
            {
                mSWordPasteFromClipboard["Handle"] = ExpressionConverter.ConvertO(mSWordPasteFromClipboardHandle);
                mSWordPasteFromClipboardpropCount++;
            }

            mSWordPasteFromClipboardpropCount++;
            mSWordPasteFromClipboard["Workflow"] = ExpressionConverter.ConvertO(mSWordPasteFromClipboardWorkflow);
            if (mSWordPasteFromClipboardpropCount > 0)
            {
                callPayload.Body = mSWordPasteFromClipboard;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordClearClipboard(Expression<Func<string>> mSWordClearClipboardWorkflow)
        {
            var apiCallPath = "/MSWord/ClearClipboard";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSWordClearClipboard = new JObject();
            var mSWordClearClipboardpropCount = 0;
            mSWordClearClipboardpropCount++;
            mSWordClearClipboard["Workflow"] = ExpressionConverter.ConvertO(mSWordClearClipboardWorkflow);
            if (mSWordClearClipboardpropCount > 0)
            {
                callPayload.Body = mSWordClearClipboard;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordGetDocumentBodyTextResponse> MSWordGetDocumentBodyText(Expression<Func<int>> mSWordGetDocumentBodyTextStart, Expression<Func<int>> mSWordGetDocumentBodyTextFinish, Expression<Func<string>> mSWordGetDocumentBodyTextWorkflow, Expression<Func<int>> mSWordGetDocumentBodyTextHandle = null, Expression<Func<string>> mSWordGetDocumentBodyTextDocumentName = null)
        {
            var apiCallPath = "/MSWord/GetDocumentBodyText";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSWordGetDocumentBodyText = new JObject();
            var mSWordGetDocumentBodyTextpropCount = 0;
            if (mSWordGetDocumentBodyTextHandle != null)
            {
                mSWordGetDocumentBodyText["Handle"] = ExpressionConverter.ConvertO(mSWordGetDocumentBodyTextHandle);
                mSWordGetDocumentBodyTextpropCount++;
            }

            if (mSWordGetDocumentBodyTextDocumentName != null)
            {
                mSWordGetDocumentBodyText["DocumentName"] = ExpressionConverter.ConvertO(mSWordGetDocumentBodyTextDocumentName);
                mSWordGetDocumentBodyTextpropCount++;
            }

            mSWordGetDocumentBodyTextpropCount++;
            mSWordGetDocumentBodyText["Start"] = ExpressionConverter.ConvertO(mSWordGetDocumentBodyTextStart);
            mSWordGetDocumentBodyTextpropCount++;
            mSWordGetDocumentBodyText["Finish"] = ExpressionConverter.ConvertO(mSWordGetDocumentBodyTextFinish);
            mSWordGetDocumentBodyTextpropCount++;
            mSWordGetDocumentBodyText["Workflow"] = ExpressionConverter.ConvertO(mSWordGetDocumentBodyTextWorkflow);
            if (mSWordGetDocumentBodyTextpropCount > 0)
            {
                callPayload.Body = mSWordGetDocumentBodyText;
            }

            return new ApiConnectionAction<MSWordGetDocumentBodyTextResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordGetNumberOfTablesInDocumentResponse> MSWordGetNumberOfTablesInDocument(Expression<Func<string>> mSWordGetNumberOfTablesInDocumentWorkflow, Expression<Func<int>> mSWordGetNumberOfTablesInDocumentHandle = null, Expression<Func<string>> mSWordGetNumberOfTablesInDocumentDocumentName = null)
        {
            var apiCallPath = "/MSWord/GetNumberOfTablesInDocument";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSWordGetNumberOfTablesInDocument = new JObject();
            var mSWordGetNumberOfTablesInDocumentpropCount = 0;
            if (mSWordGetNumberOfTablesInDocumentHandle != null)
            {
                mSWordGetNumberOfTablesInDocument["Handle"] = ExpressionConverter.ConvertO(mSWordGetNumberOfTablesInDocumentHandle);
                mSWordGetNumberOfTablesInDocumentpropCount++;
            }

            if (mSWordGetNumberOfTablesInDocumentDocumentName != null)
            {
                mSWordGetNumberOfTablesInDocument["DocumentName"] = ExpressionConverter.ConvertO(mSWordGetNumberOfTablesInDocumentDocumentName);
                mSWordGetNumberOfTablesInDocumentpropCount++;
            }

            mSWordGetNumberOfTablesInDocumentpropCount++;
            mSWordGetNumberOfTablesInDocument["Workflow"] = ExpressionConverter.ConvertO(mSWordGetNumberOfTablesInDocumentWorkflow);
            if (mSWordGetNumberOfTablesInDocumentpropCount > 0)
            {
                callPayload.Body = mSWordGetNumberOfTablesInDocument;
            }

            return new ApiConnectionAction<MSWordGetNumberOfTablesInDocumentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordUpdateBookmark(Expression<Func<string>> mSWordUpdateBookmarkBookmarkName, Expression<Func<string>> mSWordUpdateBookmarkWorkflow, Expression<Func<int>> mSWordUpdateBookmarkHandle = null, Expression<Func<string>> mSWordUpdateBookmarkDocumentName = null, Expression<Func<string>> mSWordUpdateBookmarkNewValue = null)
        {
            var apiCallPath = "/MSWord/UpdateBookmark";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSWordUpdateBookmark = new JObject();
            var mSWordUpdateBookmarkpropCount = 0;
            if (mSWordUpdateBookmarkHandle != null)
            {
                mSWordUpdateBookmark["Handle"] = ExpressionConverter.ConvertO(mSWordUpdateBookmarkHandle);
                mSWordUpdateBookmarkpropCount++;
            }

            if (mSWordUpdateBookmarkDocumentName != null)
            {
                mSWordUpdateBookmark["DocumentName"] = ExpressionConverter.ConvertO(mSWordUpdateBookmarkDocumentName);
                mSWordUpdateBookmarkpropCount++;
            }

            mSWordUpdateBookmarkpropCount++;
            mSWordUpdateBookmark["BookmarkName"] = ExpressionConverter.ConvertO(mSWordUpdateBookmarkBookmarkName);
            if (mSWordUpdateBookmarkNewValue != null)
            {
                mSWordUpdateBookmark["NewValue"] = ExpressionConverter.ConvertO(mSWordUpdateBookmarkNewValue);
                mSWordUpdateBookmarkpropCount++;
            }

            mSWordUpdateBookmarkpropCount++;
            mSWordUpdateBookmark["Workflow"] = ExpressionConverter.ConvertO(mSWordUpdateBookmarkWorkflow);
            if (mSWordUpdateBookmarkpropCount > 0)
            {
                callPayload.Body = mSWordUpdateBookmark;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordSelectTable(Expression<Func<int>> mSWordSelectTableTableIndex, Expression<Func<string>> mSWordSelectTableWorkflow, Expression<Func<int>> mSWordSelectTableHandle = null, Expression<Func<string>> mSWordSelectTableDocumentName = null)
        {
            var apiCallPath = "/MSWord/SelectTable";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSWordSelectTable = new JObject();
            var mSWordSelectTablepropCount = 0;
            if (mSWordSelectTableHandle != null)
            {
                mSWordSelectTable["Handle"] = ExpressionConverter.ConvertO(mSWordSelectTableHandle);
                mSWordSelectTablepropCount++;
            }

            if (mSWordSelectTableDocumentName != null)
            {
                mSWordSelectTable["DocumentName"] = ExpressionConverter.ConvertO(mSWordSelectTableDocumentName);
                mSWordSelectTablepropCount++;
            }

            mSWordSelectTablepropCount++;
            mSWordSelectTable["TableIndex"] = ExpressionConverter.ConvertO(mSWordSelectTableTableIndex);
            mSWordSelectTablepropCount++;
            mSWordSelectTable["Workflow"] = ExpressionConverter.ConvertO(mSWordSelectTableWorkflow);
            if (mSWordSelectTablepropCount > 0)
            {
                callPayload.Body = mSWordSelectTable;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordGetTableBoundsResponse> MSWordGetTableBounds(Expression<Func<int>> mSWordGetTableBoundsTableIndex, Expression<Func<string>> mSWordGetTableBoundsWorkflow, Expression<Func<int>> mSWordGetTableBoundsHandle = null, Expression<Func<string>> mSWordGetTableBoundsDocumentName = null)
        {
            var apiCallPath = "/MSWord/GetTableBounds";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSWordGetTableBounds = new JObject();
            var mSWordGetTableBoundspropCount = 0;
            if (mSWordGetTableBoundsHandle != null)
            {
                mSWordGetTableBounds["Handle"] = ExpressionConverter.ConvertO(mSWordGetTableBoundsHandle);
                mSWordGetTableBoundspropCount++;
            }

            if (mSWordGetTableBoundsDocumentName != null)
            {
                mSWordGetTableBounds["DocumentName"] = ExpressionConverter.ConvertO(mSWordGetTableBoundsDocumentName);
                mSWordGetTableBoundspropCount++;
            }

            mSWordGetTableBoundspropCount++;
            mSWordGetTableBounds["TableIndex"] = ExpressionConverter.ConvertO(mSWordGetTableBoundsTableIndex);
            mSWordGetTableBoundspropCount++;
            mSWordGetTableBounds["Workflow"] = ExpressionConverter.ConvertO(mSWordGetTableBoundsWorkflow);
            if (mSWordGetTableBoundspropCount > 0)
            {
                callPayload.Body = mSWordGetTableBounds;
            }

            return new ApiConnectionAction<MSWordGetTableBoundsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordSelectTableCell(Expression<Func<int>> mSWordSelectTableCellTableIndex, Expression<Func<int>> mSWordSelectTableCellRowIndex, Expression<Func<int>> mSWordSelectTableCellColumnIndex, Expression<Func<string>> mSWordSelectTableCellWorkflow, Expression<Func<int>> mSWordSelectTableCellHandle = null, Expression<Func<string>> mSWordSelectTableCellDocumentName = null)
        {
            var apiCallPath = "/MSWord/SelectTableCell";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSWordSelectTableCell = new JObject();
            var mSWordSelectTableCellpropCount = 0;
            if (mSWordSelectTableCellHandle != null)
            {
                mSWordSelectTableCell["Handle"] = ExpressionConverter.ConvertO(mSWordSelectTableCellHandle);
                mSWordSelectTableCellpropCount++;
            }

            if (mSWordSelectTableCellDocumentName != null)
            {
                mSWordSelectTableCell["DocumentName"] = ExpressionConverter.ConvertO(mSWordSelectTableCellDocumentName);
                mSWordSelectTableCellpropCount++;
            }

            mSWordSelectTableCellpropCount++;
            mSWordSelectTableCell["TableIndex"] = ExpressionConverter.ConvertO(mSWordSelectTableCellTableIndex);
            mSWordSelectTableCellpropCount++;
            mSWordSelectTableCell["RowIndex"] = ExpressionConverter.ConvertO(mSWordSelectTableCellRowIndex);
            mSWordSelectTableCellpropCount++;
            mSWordSelectTableCell["ColumnIndex"] = ExpressionConverter.ConvertO(mSWordSelectTableCellColumnIndex);
            mSWordSelectTableCellpropCount++;
            mSWordSelectTableCell["Workflow"] = ExpressionConverter.ConvertO(mSWordSelectTableCellWorkflow);
            if (mSWordSelectTableCellpropCount > 0)
            {
                callPayload.Body = mSWordSelectTableCell;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordGetTableCellTextValueResponse> MSWordGetTableCellTextValue(Expression<Func<int>> mSWordGetTableCellTextValueTableIndex, Expression<Func<int>> mSWordGetTableCellTextValueRowIndex, Expression<Func<int>> mSWordGetTableCellTextValueColumnIndex, Expression<Func<string>> mSWordGetTableCellTextValueWorkflow, Expression<Func<int>> mSWordGetTableCellTextValueHandle = null, Expression<Func<string>> mSWordGetTableCellTextValueDocumentName = null)
        {
            var apiCallPath = "/MSWord/GetTableCellTextValue";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSWordGetTableCellTextValue = new JObject();
            var mSWordGetTableCellTextValuepropCount = 0;
            if (mSWordGetTableCellTextValueHandle != null)
            {
                mSWordGetTableCellTextValue["Handle"] = ExpressionConverter.ConvertO(mSWordGetTableCellTextValueHandle);
                mSWordGetTableCellTextValuepropCount++;
            }

            if (mSWordGetTableCellTextValueDocumentName != null)
            {
                mSWordGetTableCellTextValue["DocumentName"] = ExpressionConverter.ConvertO(mSWordGetTableCellTextValueDocumentName);
                mSWordGetTableCellTextValuepropCount++;
            }

            mSWordGetTableCellTextValuepropCount++;
            mSWordGetTableCellTextValue["TableIndex"] = ExpressionConverter.ConvertO(mSWordGetTableCellTextValueTableIndex);
            mSWordGetTableCellTextValuepropCount++;
            mSWordGetTableCellTextValue["RowIndex"] = ExpressionConverter.ConvertO(mSWordGetTableCellTextValueRowIndex);
            mSWordGetTableCellTextValuepropCount++;
            mSWordGetTableCellTextValue["ColumnIndex"] = ExpressionConverter.ConvertO(mSWordGetTableCellTextValueColumnIndex);
            mSWordGetTableCellTextValuepropCount++;
            mSWordGetTableCellTextValue["Workflow"] = ExpressionConverter.ConvertO(mSWordGetTableCellTextValueWorkflow);
            if (mSWordGetTableCellTextValuepropCount > 0)
            {
                callPayload.Body = mSWordGetTableCellTextValue;
            }

            return new ApiConnectionAction<MSWordGetTableCellTextValueResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordGetTableCellTextValueTrimmedResponse> MSWordGetTableCellTextValueTrimmed(Expression<Func<int>> mSWordGetTableCellTextValueTrimmedTableIndex, Expression<Func<int>> mSWordGetTableCellTextValueTrimmedRowIndex, Expression<Func<int>> mSWordGetTableCellTextValueTrimmedColumnIndex, Expression<Func<string>> mSWordGetTableCellTextValueTrimmedWorkflow, Expression<Func<int>> mSWordGetTableCellTextValueTrimmedHandle = null, Expression<Func<string>> mSWordGetTableCellTextValueTrimmedDocumentName = null)
        {
            var apiCallPath = "/MSWord/GetTableCellTextValueTrimmed";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSWordGetTableCellTextValueTrimmed = new JObject();
            var mSWordGetTableCellTextValueTrimmedpropCount = 0;
            if (mSWordGetTableCellTextValueTrimmedHandle != null)
            {
                mSWordGetTableCellTextValueTrimmed["Handle"] = ExpressionConverter.ConvertO(mSWordGetTableCellTextValueTrimmedHandle);
                mSWordGetTableCellTextValueTrimmedpropCount++;
            }

            if (mSWordGetTableCellTextValueTrimmedDocumentName != null)
            {
                mSWordGetTableCellTextValueTrimmed["DocumentName"] = ExpressionConverter.ConvertO(mSWordGetTableCellTextValueTrimmedDocumentName);
                mSWordGetTableCellTextValueTrimmedpropCount++;
            }

            mSWordGetTableCellTextValueTrimmedpropCount++;
            mSWordGetTableCellTextValueTrimmed["TableIndex"] = ExpressionConverter.ConvertO(mSWordGetTableCellTextValueTrimmedTableIndex);
            mSWordGetTableCellTextValueTrimmedpropCount++;
            mSWordGetTableCellTextValueTrimmed["RowIndex"] = ExpressionConverter.ConvertO(mSWordGetTableCellTextValueTrimmedRowIndex);
            mSWordGetTableCellTextValueTrimmedpropCount++;
            mSWordGetTableCellTextValueTrimmed["ColumnIndex"] = ExpressionConverter.ConvertO(mSWordGetTableCellTextValueTrimmedColumnIndex);
            mSWordGetTableCellTextValueTrimmedpropCount++;
            mSWordGetTableCellTextValueTrimmed["Workflow"] = ExpressionConverter.ConvertO(mSWordGetTableCellTextValueTrimmedWorkflow);
            if (mSWordGetTableCellTextValueTrimmedpropCount > 0)
            {
                callPayload.Body = mSWordGetTableCellTextValueTrimmed;
            }

            return new ApiConnectionAction<MSWordGetTableCellTextValueTrimmedResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordSetTableCellTextValue(Expression<Func<int>> mSWordSetTableCellTextValueTableIndex, Expression<Func<int>> mSWordSetTableCellTextValueRowIndex, Expression<Func<int>> mSWordSetTableCellTextValueColumnIndex, Expression<Func<string>> mSWordSetTableCellTextValueWorkflow, Expression<Func<int>> mSWordSetTableCellTextValueHandle = null, Expression<Func<string>> mSWordSetTableCellTextValueDocumentName = null, Expression<Func<string>> mSWordSetTableCellTextValueNewCellText = null)
        {
            var apiCallPath = "/MSWord/SetTableCellTextValue";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSWordSetTableCellTextValue = new JObject();
            var mSWordSetTableCellTextValuepropCount = 0;
            if (mSWordSetTableCellTextValueHandle != null)
            {
                mSWordSetTableCellTextValue["Handle"] = ExpressionConverter.ConvertO(mSWordSetTableCellTextValueHandle);
                mSWordSetTableCellTextValuepropCount++;
            }

            if (mSWordSetTableCellTextValueDocumentName != null)
            {
                mSWordSetTableCellTextValue["DocumentName"] = ExpressionConverter.ConvertO(mSWordSetTableCellTextValueDocumentName);
                mSWordSetTableCellTextValuepropCount++;
            }

            mSWordSetTableCellTextValuepropCount++;
            mSWordSetTableCellTextValue["TableIndex"] = ExpressionConverter.ConvertO(mSWordSetTableCellTextValueTableIndex);
            mSWordSetTableCellTextValuepropCount++;
            mSWordSetTableCellTextValue["RowIndex"] = ExpressionConverter.ConvertO(mSWordSetTableCellTextValueRowIndex);
            mSWordSetTableCellTextValuepropCount++;
            mSWordSetTableCellTextValue["ColumnIndex"] = ExpressionConverter.ConvertO(mSWordSetTableCellTextValueColumnIndex);
            if (mSWordSetTableCellTextValueNewCellText != null)
            {
                mSWordSetTableCellTextValue["NewCellText"] = ExpressionConverter.ConvertO(mSWordSetTableCellTextValueNewCellText);
                mSWordSetTableCellTextValuepropCount++;
            }

            mSWordSetTableCellTextValuepropCount++;
            mSWordSetTableCellTextValue["Workflow"] = ExpressionConverter.ConvertO(mSWordSetTableCellTextValueWorkflow);
            if (mSWordSetTableCellTextValuepropCount > 0)
            {
                callPayload.Body = mSWordSetTableCellTextValue;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordExportDocumentAsPDF(Expression<Func<string>> mSWordExportDocumentAsPDFSaveFileName, Expression<Func<string>> mSWordExportDocumentAsPDFWorkflow, Expression<Func<int>> mSWordExportDocumentAsPDFHandle = null, Expression<Func<string>> mSWordExportDocumentAsPDFDocumentName = null)
        {
            var apiCallPath = "/MSWord/ExportDocumentAsPDF";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSWordExportDocumentAsPDF = new JObject();
            var mSWordExportDocumentAsPDFpropCount = 0;
            if (mSWordExportDocumentAsPDFHandle != null)
            {
                mSWordExportDocumentAsPDF["Handle"] = ExpressionConverter.ConvertO(mSWordExportDocumentAsPDFHandle);
                mSWordExportDocumentAsPDFpropCount++;
            }

            if (mSWordExportDocumentAsPDFDocumentName != null)
            {
                mSWordExportDocumentAsPDF["DocumentName"] = ExpressionConverter.ConvertO(mSWordExportDocumentAsPDFDocumentName);
                mSWordExportDocumentAsPDFpropCount++;
            }

            mSWordExportDocumentAsPDFpropCount++;
            mSWordExportDocumentAsPDF["SaveFileName"] = ExpressionConverter.ConvertO(mSWordExportDocumentAsPDFSaveFileName);
            mSWordExportDocumentAsPDFpropCount++;
            mSWordExportDocumentAsPDF["Workflow"] = ExpressionConverter.ConvertO(mSWordExportDocumentAsPDFWorkflow);
            if (mSWordExportDocumentAsPDFpropCount > 0)
            {
                callPayload.Body = mSWordExportDocumentAsPDF;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordAddTable(Expression<Func<int>> mSWordAddTableNumberOfRows, Expression<Func<int>> mSWordAddTableNumberOfColumns, Expression<Func<string>> mSWordAddTableWorkflow, Expression<Func<int>> mSWordAddTableHandle = null, Expression<Func<string>> mSWordAddTableDocumentName = null, Expression<Func<int>> mSWordAddTableAutoFitBehaviour = null)
        {
            var apiCallPath = "/MSWord/AddTable";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSWordAddTable = new JObject();
            var mSWordAddTablepropCount = 0;
            if (mSWordAddTableHandle != null)
            {
                mSWordAddTable["Handle"] = ExpressionConverter.ConvertO(mSWordAddTableHandle);
                mSWordAddTablepropCount++;
            }

            if (mSWordAddTableDocumentName != null)
            {
                mSWordAddTable["DocumentName"] = ExpressionConverter.ConvertO(mSWordAddTableDocumentName);
                mSWordAddTablepropCount++;
            }

            mSWordAddTablepropCount++;
            mSWordAddTable["NumberOfRows"] = ExpressionConverter.ConvertO(mSWordAddTableNumberOfRows);
            mSWordAddTablepropCount++;
            mSWordAddTable["NumberOfColumns"] = ExpressionConverter.ConvertO(mSWordAddTableNumberOfColumns);
            if (mSWordAddTableAutoFitBehaviour != null)
            {
                mSWordAddTable["AutoFitBehaviour"] = ExpressionConverter.ConvertO(mSWordAddTableAutoFitBehaviour);
                mSWordAddTablepropCount++;
            }

            mSWordAddTablepropCount++;
            mSWordAddTable["Workflow"] = ExpressionConverter.ConvertO(mSWordAddTableWorkflow);
            if (mSWordAddTablepropCount > 0)
            {
                callPayload.Body = mSWordAddTable;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordAddTableRow(Expression<Func<int>> mSWordAddTableRowTableIndex, Expression<Func<string>> mSWordAddTableRowWorkflow, Expression<Func<int>> mSWordAddTableRowHandle = null, Expression<Func<string>> mSWordAddTableRowDocumentName = null)
        {
            var apiCallPath = "/MSWord/AddTableRow";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSWordAddTableRow = new JObject();
            var mSWordAddTableRowpropCount = 0;
            if (mSWordAddTableRowHandle != null)
            {
                mSWordAddTableRow["Handle"] = ExpressionConverter.ConvertO(mSWordAddTableRowHandle);
                mSWordAddTableRowpropCount++;
            }

            if (mSWordAddTableRowDocumentName != null)
            {
                mSWordAddTableRow["DocumentName"] = ExpressionConverter.ConvertO(mSWordAddTableRowDocumentName);
                mSWordAddTableRowpropCount++;
            }

            mSWordAddTableRowpropCount++;
            mSWordAddTableRow["TableIndex"] = ExpressionConverter.ConvertO(mSWordAddTableRowTableIndex);
            mSWordAddTableRowpropCount++;
            mSWordAddTableRow["Workflow"] = ExpressionConverter.ConvertO(mSWordAddTableRowWorkflow);
            if (mSWordAddTableRowpropCount > 0)
            {
                callPayload.Body = mSWordAddTableRow;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordAddTableColumn(Expression<Func<int>> mSWordAddTableColumnTableIndex, Expression<Func<string>> mSWordAddTableColumnWorkflow, Expression<Func<int>> mSWordAddTableColumnHandle = null, Expression<Func<string>> mSWordAddTableColumnDocumentName = null)
        {
            var apiCallPath = "/MSWord/AddTableColumn";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSWordAddTableColumn = new JObject();
            var mSWordAddTableColumnpropCount = 0;
            if (mSWordAddTableColumnHandle != null)
            {
                mSWordAddTableColumn["Handle"] = ExpressionConverter.ConvertO(mSWordAddTableColumnHandle);
                mSWordAddTableColumnpropCount++;
            }

            if (mSWordAddTableColumnDocumentName != null)
            {
                mSWordAddTableColumn["DocumentName"] = ExpressionConverter.ConvertO(mSWordAddTableColumnDocumentName);
                mSWordAddTableColumnpropCount++;
            }

            mSWordAddTableColumnpropCount++;
            mSWordAddTableColumn["TableIndex"] = ExpressionConverter.ConvertO(mSWordAddTableColumnTableIndex);
            mSWordAddTableColumnpropCount++;
            mSWordAddTableColumn["Workflow"] = ExpressionConverter.ConvertO(mSWordAddTableColumnWorkflow);
            if (mSWordAddTableColumnpropCount > 0)
            {
                callPayload.Body = mSWordAddTableColumn;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordGetHighlightedTextResponse> MSWordGetHighlightedText(Expression<Func<string>> mSWordGetHighlightedTextWorkflow, Expression<Func<int>> mSWordGetHighlightedTextHandle = null, Expression<Func<string>> mSWordGetHighlightedTextDocumentName = null)
        {
            var apiCallPath = "/MSWord/GetHighlightedText";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSWordGetHighlightedText = new JObject();
            var mSWordGetHighlightedTextpropCount = 0;
            if (mSWordGetHighlightedTextHandle != null)
            {
                mSWordGetHighlightedText["Handle"] = ExpressionConverter.ConvertO(mSWordGetHighlightedTextHandle);
                mSWordGetHighlightedTextpropCount++;
            }

            if (mSWordGetHighlightedTextDocumentName != null)
            {
                mSWordGetHighlightedText["DocumentName"] = ExpressionConverter.ConvertO(mSWordGetHighlightedTextDocumentName);
                mSWordGetHighlightedTextpropCount++;
            }

            mSWordGetHighlightedTextpropCount++;
            mSWordGetHighlightedText["Workflow"] = ExpressionConverter.ConvertO(mSWordGetHighlightedTextWorkflow);
            if (mSWordGetHighlightedTextpropCount > 0)
            {
                callPayload.Body = mSWordGetHighlightedText;
            }

            return new ApiConnectionAction<MSWordGetHighlightedTextResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordExecuteCommandBarObjectResponse> MSWordExecuteCommandBarObject(Expression<Func<string>> mSWordExecuteCommandBarObjectObjectId, Expression<Func<string>> mSWordExecuteCommandBarObjectWorkflow, Expression<Func<int>> mSWordExecuteCommandBarObjectHandle = null, Expression<Func<bool>> mSWordExecuteCommandBarObjectRunInBackground = null)
        {
            var apiCallPath = "/MSWord/ExecuteCommandBarObject";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSWordExecuteCommandBarObject = new JObject();
            var mSWordExecuteCommandBarObjectpropCount = 0;
            if (mSWordExecuteCommandBarObjectHandle != null)
            {
                mSWordExecuteCommandBarObject["Handle"] = ExpressionConverter.ConvertO(mSWordExecuteCommandBarObjectHandle);
                mSWordExecuteCommandBarObjectpropCount++;
            }

            mSWordExecuteCommandBarObjectpropCount++;
            mSWordExecuteCommandBarObject["ObjectId"] = ExpressionConverter.ConvertO(mSWordExecuteCommandBarObjectObjectId);
            if (mSWordExecuteCommandBarObjectRunInBackground != null)
            {
                mSWordExecuteCommandBarObject["RunInBackground"] = ExpressionConverter.ConvertO(mSWordExecuteCommandBarObjectRunInBackground);
                mSWordExecuteCommandBarObjectpropCount++;
            }

            mSWordExecuteCommandBarObjectpropCount++;
            mSWordExecuteCommandBarObject["Workflow"] = ExpressionConverter.ConvertO(mSWordExecuteCommandBarObjectWorkflow);
            if (mSWordExecuteCommandBarObjectpropCount > 0)
            {
                callPayload.Body = mSWordExecuteCommandBarObject;
            }

            return new ApiConnectionAction<MSWordExecuteCommandBarObjectResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordSetDocumentSensitivityLabelResponse> MSWordSetDocumentSensitivityLabel(Expression<Func<mSWordSetDocumentSensitivityLabelAssignmentMethodInput>> mSWordSetDocumentSensitivityLabelAssignmentMethod, Expression<Func<string>> mSWordSetDocumentSensitivityLabelLabelId, Expression<Func<string>> mSWordSetDocumentSensitivityLabelWorkflow, Expression<Func<int>> mSWordSetDocumentSensitivityLabelHandle = null, Expression<Func<string>> mSWordSetDocumentSensitivityLabelDocumentName = null, Expression<Func<string>> mSWordSetDocumentSensitivityLabelLabelName = null, Expression<Func<string>> mSWordSetDocumentSensitivityLabelSiteId = null, Expression<Func<string>> mSWordSetDocumentSensitivityLabelJustification = null)
        {
            var apiCallPath = "/MSWord/MSWordSetDocumentSensitivityLabel";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSWordSetDocumentSensitivityLabel = new JObject();
            var mSWordSetDocumentSensitivityLabelpropCount = 0;
            if (mSWordSetDocumentSensitivityLabelHandle != null)
            {
                mSWordSetDocumentSensitivityLabel["Handle"] = ExpressionConverter.ConvertO(mSWordSetDocumentSensitivityLabelHandle);
                mSWordSetDocumentSensitivityLabelpropCount++;
            }

            if (mSWordSetDocumentSensitivityLabelDocumentName != null)
            {
                mSWordSetDocumentSensitivityLabel["DocumentName"] = ExpressionConverter.ConvertO(mSWordSetDocumentSensitivityLabelDocumentName);
                mSWordSetDocumentSensitivityLabelpropCount++;
            }

            mSWordSetDocumentSensitivityLabelpropCount++;
            mSWordSetDocumentSensitivityLabel["AssignmentMethod"] = ExpressionConverter.ConvertO(mSWordSetDocumentSensitivityLabelAssignmentMethod);
            mSWordSetDocumentSensitivityLabelpropCount++;
            mSWordSetDocumentSensitivityLabel["LabelId"] = ExpressionConverter.ConvertO(mSWordSetDocumentSensitivityLabelLabelId);
            if (mSWordSetDocumentSensitivityLabelLabelName != null)
            {
                mSWordSetDocumentSensitivityLabel["LabelName"] = ExpressionConverter.ConvertO(mSWordSetDocumentSensitivityLabelLabelName);
                mSWordSetDocumentSensitivityLabelpropCount++;
            }

            if (mSWordSetDocumentSensitivityLabelSiteId != null)
            {
                mSWordSetDocumentSensitivityLabel["SiteId"] = ExpressionConverter.ConvertO(mSWordSetDocumentSensitivityLabelSiteId);
                mSWordSetDocumentSensitivityLabelpropCount++;
            }

            if (mSWordSetDocumentSensitivityLabelJustification != null)
            {
                mSWordSetDocumentSensitivityLabel["Justification"] = ExpressionConverter.ConvertO(mSWordSetDocumentSensitivityLabelJustification);
                mSWordSetDocumentSensitivityLabelpropCount++;
            }

            mSWordSetDocumentSensitivityLabelpropCount++;
            mSWordSetDocumentSensitivityLabel["Workflow"] = ExpressionConverter.ConvertO(mSWordSetDocumentSensitivityLabelWorkflow);
            if (mSWordSetDocumentSensitivityLabelpropCount > 0)
            {
                callPayload.Body = mSWordSetDocumentSensitivityLabel;
            }

            return new ApiConnectionAction<MSWordSetDocumentSensitivityLabelResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordGetDocumentSensitivityLabelResponse> MSWordGetDocumentSensitivityLabel(Expression<Func<string>> mSWordGetDocumentSensitivityLabelWorkflow, Expression<Func<int>> mSWordGetDocumentSensitivityLabelHandle = null, Expression<Func<string>> mSWordGetDocumentSensitivityLabelDocumentName = null)
        {
            var apiCallPath = "/MSWord/MSWordGetDocumentSensitivityLabel";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSWordGetDocumentSensitivityLabel = new JObject();
            var mSWordGetDocumentSensitivityLabelpropCount = 0;
            if (mSWordGetDocumentSensitivityLabelHandle != null)
            {
                mSWordGetDocumentSensitivityLabel["Handle"] = ExpressionConverter.ConvertO(mSWordGetDocumentSensitivityLabelHandle);
                mSWordGetDocumentSensitivityLabelpropCount++;
            }

            if (mSWordGetDocumentSensitivityLabelDocumentName != null)
            {
                mSWordGetDocumentSensitivityLabel["DocumentName"] = ExpressionConverter.ConvertO(mSWordGetDocumentSensitivityLabelDocumentName);
                mSWordGetDocumentSensitivityLabelpropCount++;
            }

            mSWordGetDocumentSensitivityLabelpropCount++;
            mSWordGetDocumentSensitivityLabel["Workflow"] = ExpressionConverter.ConvertO(mSWordGetDocumentSensitivityLabelWorkflow);
            if (mSWordGetDocumentSensitivityLabelpropCount > 0)
            {
                callPayload.Body = mSWordGetDocumentSensitivityLabel;
            }

            return new ApiConnectionAction<MSWordGetDocumentSensitivityLabelResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelCreateInstanceResponse> MSExcelCreateInstance(Expression<Func<string>> mSExcelCreateInstanceWorkflow, Expression<Func<bool>> mSExcelCreateInstanceEnableEvents = null, Expression<Func<bool>> mSExcelCreateInstanceShowExcel = null)
        {
            var apiCallPath = "/MSExcel/CreateInstance";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelCreateInstance = new JObject();
            var mSExcelCreateInstancepropCount = 0;
            if (mSExcelCreateInstanceEnableEvents != null)
            {
                mSExcelCreateInstance["EnableEvents"] = ExpressionConverter.ConvertO(mSExcelCreateInstanceEnableEvents);
                mSExcelCreateInstancepropCount++;
            }

            if (mSExcelCreateInstanceShowExcel != null)
            {
                mSExcelCreateInstance["ShowExcel"] = ExpressionConverter.ConvertO(mSExcelCreateInstanceShowExcel);
                mSExcelCreateInstancepropCount++;
            }

            mSExcelCreateInstancepropCount++;
            mSExcelCreateInstance["Workflow"] = ExpressionConverter.ConvertO(mSExcelCreateInstanceWorkflow);
            if (mSExcelCreateInstancepropCount > 0)
            {
                callPayload.Body = mSExcelCreateInstance;
            }

            return new ApiConnectionAction<MSExcelCreateInstanceResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelCloseInstance(Expression<Func<string>> mSExcelCloseInstanceWorkflow, Expression<Func<int>> mSExcelCloseInstanceHandle = null)
        {
            var apiCallPath = "/MSExcel/CloseInstance";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelCloseInstance = new JObject();
            var mSExcelCloseInstancepropCount = 0;
            if (mSExcelCloseInstanceHandle != null)
            {
                mSExcelCloseInstance["Handle"] = ExpressionConverter.ConvertO(mSExcelCloseInstanceHandle);
                mSExcelCloseInstancepropCount++;
            }

            mSExcelCloseInstancepropCount++;
            mSExcelCloseInstance["Workflow"] = ExpressionConverter.ConvertO(mSExcelCloseInstanceWorkflow);
            if (mSExcelCloseInstancepropCount > 0)
            {
                callPayload.Body = mSExcelCloseInstance;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelAttachToExistingInstanceResponse> MSExcelAttachToExistingInstance(Expression<Func<string>> mSExcelAttachToExistingInstanceWorkflow, Expression<Func<string>> mSExcelAttachToExistingInstanceFilename = null, Expression<Func<bool>> mSExcelAttachToExistingInstanceToggleWindow = null, Expression<Func<bool>> mSExcelAttachToExistingInstanceToggleUsesGlobalLeftMouseClickAgent = null, Expression<Func<double>> mSExcelAttachToExistingInstanceToggleDelay = null)
        {
            var apiCallPath = "/MSExcel/MSExcelAttachToExistingInstance";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelAttachToExistingInstance = new JObject();
            var mSExcelAttachToExistingInstancepropCount = 0;
            if (mSExcelAttachToExistingInstanceFilename != null)
            {
                mSExcelAttachToExistingInstance["Filename"] = ExpressionConverter.ConvertO(mSExcelAttachToExistingInstanceFilename);
                mSExcelAttachToExistingInstancepropCount++;
            }

            if (mSExcelAttachToExistingInstanceToggleWindow != null)
            {
                mSExcelAttachToExistingInstance["ToggleWindow"] = ExpressionConverter.ConvertO(mSExcelAttachToExistingInstanceToggleWindow);
                mSExcelAttachToExistingInstancepropCount++;
            }

            if (mSExcelAttachToExistingInstanceToggleUsesGlobalLeftMouseClickAgent != null)
            {
                mSExcelAttachToExistingInstance["ToggleUsesGlobalLeftMouseClickAgent"] = ExpressionConverter.ConvertO(mSExcelAttachToExistingInstanceToggleUsesGlobalLeftMouseClickAgent);
                mSExcelAttachToExistingInstancepropCount++;
            }

            if (mSExcelAttachToExistingInstanceToggleDelay != null)
            {
                mSExcelAttachToExistingInstance["ToggleDelay"] = ExpressionConverter.ConvertO(mSExcelAttachToExistingInstanceToggleDelay);
                mSExcelAttachToExistingInstancepropCount++;
            }

            mSExcelAttachToExistingInstancepropCount++;
            mSExcelAttachToExistingInstance["Workflow"] = ExpressionConverter.ConvertO(mSExcelAttachToExistingInstanceWorkflow);
            if (mSExcelAttachToExistingInstancepropCount > 0)
            {
                callPayload.Body = mSExcelAttachToExistingInstance;
            }

            return new ApiConnectionAction<MSExcelAttachToExistingInstanceResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelShowExcel(Expression<Func<string>> mSExcelShowExcelWorkflow, Expression<Func<int>> mSExcelShowExcelHandle = null)
        {
            var apiCallPath = "/MSExcel/ShowExcel";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelShowExcel = new JObject();
            var mSExcelShowExcelpropCount = 0;
            if (mSExcelShowExcelHandle != null)
            {
                mSExcelShowExcel["Handle"] = ExpressionConverter.ConvertO(mSExcelShowExcelHandle);
                mSExcelShowExcelpropCount++;
            }

            mSExcelShowExcelpropCount++;
            mSExcelShowExcel["Workflow"] = ExpressionConverter.ConvertO(mSExcelShowExcelWorkflow);
            if (mSExcelShowExcelpropCount > 0)
            {
                callPayload.Body = mSExcelShowExcel;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelHideExcel(Expression<Func<string>> mSExcelHideExcelWorkflow, Expression<Func<int>> mSExcelHideExcelHandle = null)
        {
            var apiCallPath = "/MSExcel/HideExcel";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelHideExcel = new JObject();
            var mSExcelHideExcelpropCount = 0;
            if (mSExcelHideExcelHandle != null)
            {
                mSExcelHideExcel["Handle"] = ExpressionConverter.ConvertO(mSExcelHideExcelHandle);
                mSExcelHideExcelpropCount++;
            }

            mSExcelHideExcelpropCount++;
            mSExcelHideExcel["Workflow"] = ExpressionConverter.ConvertO(mSExcelHideExcelWorkflow);
            if (mSExcelHideExcelpropCount > 0)
            {
                callPayload.Body = mSExcelHideExcel;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelOpenWorkbookResponse> MSExcelOpenWorkbook(Expression<Func<string>> mSExcelOpenWorkbookWorkflow, Expression<Func<int>> mSExcelOpenWorkbookHandle = null, Expression<Func<string>> mSExcelOpenWorkbookFilename = null, Expression<Func<bool>> mSExcelOpenWorkbookReadOnly = null, Expression<Func<bool>> mSExcelOpenWorkbookUpdateLinks = null, Expression<Func<string>> mSExcelOpenWorkbookPassword = null, Expression<Func<bool>> mSExcelOpenWorkbookEnableEvents = null, Expression<Func<bool>> mSExcelOpenWorkbookPutHTTPWorkbooksIntoEditMode = null, Expression<Func<bool>> mSExcelOpenWorkbookPutFilePathWorkbooksIntoEditMode = null)
        {
            var apiCallPath = "/MSExcel/OpenWorkbook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelOpenWorkbook = new JObject();
            var mSExcelOpenWorkbookpropCount = 0;
            if (mSExcelOpenWorkbookHandle != null)
            {
                mSExcelOpenWorkbook["Handle"] = ExpressionConverter.ConvertO(mSExcelOpenWorkbookHandle);
                mSExcelOpenWorkbookpropCount++;
            }

            if (mSExcelOpenWorkbookFilename != null)
            {
                mSExcelOpenWorkbook["Filename"] = ExpressionConverter.ConvertO(mSExcelOpenWorkbookFilename);
                mSExcelOpenWorkbookpropCount++;
            }

            if (mSExcelOpenWorkbookReadOnly != null)
            {
                mSExcelOpenWorkbook["ReadOnly"] = ExpressionConverter.ConvertO(mSExcelOpenWorkbookReadOnly);
                mSExcelOpenWorkbookpropCount++;
            }

            if (mSExcelOpenWorkbookUpdateLinks != null)
            {
                mSExcelOpenWorkbook["UpdateLinks"] = ExpressionConverter.ConvertO(mSExcelOpenWorkbookUpdateLinks);
                mSExcelOpenWorkbookpropCount++;
            }

            if (mSExcelOpenWorkbookPassword != null)
            {
                mSExcelOpenWorkbook["Password"] = ExpressionConverter.ConvertO(mSExcelOpenWorkbookPassword);
                mSExcelOpenWorkbookpropCount++;
            }

            if (mSExcelOpenWorkbookEnableEvents != null)
            {
                mSExcelOpenWorkbook["EnableEvents"] = ExpressionConverter.ConvertO(mSExcelOpenWorkbookEnableEvents);
                mSExcelOpenWorkbookpropCount++;
            }

            if (mSExcelOpenWorkbookPutHTTPWorkbooksIntoEditMode != null)
            {
                mSExcelOpenWorkbook["PutHTTPWorkbooksIntoEditMode"] = ExpressionConverter.ConvertO(mSExcelOpenWorkbookPutHTTPWorkbooksIntoEditMode);
                mSExcelOpenWorkbookpropCount++;
            }

            if (mSExcelOpenWorkbookPutFilePathWorkbooksIntoEditMode != null)
            {
                mSExcelOpenWorkbook["PutFilePathWorkbooksIntoEditMode"] = ExpressionConverter.ConvertO(mSExcelOpenWorkbookPutFilePathWorkbooksIntoEditMode);
                mSExcelOpenWorkbookpropCount++;
            }

            mSExcelOpenWorkbookpropCount++;
            mSExcelOpenWorkbook["Workflow"] = ExpressionConverter.ConvertO(mSExcelOpenWorkbookWorkflow);
            if (mSExcelOpenWorkbookpropCount > 0)
            {
                callPayload.Body = mSExcelOpenWorkbook;
            }

            return new ApiConnectionAction<MSExcelOpenWorkbookResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelPutWorkbookInEditModeResponse> MSExcelPutWorkbookInEditMode(Expression<Func<string>> mSExcelPutWorkbookInEditModeWorkflow, Expression<Func<int>> mSExcelPutWorkbookInEditModeHandle = null, Expression<Func<string>> mSExcelPutWorkbookInEditModeWorkbookName = null, Expression<Func<bool>> mSExcelPutWorkbookInEditModeForce = null)
        {
            var apiCallPath = "/MSExcel/PutWorkbookInEditMode";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelPutWorkbookInEditMode = new JObject();
            var mSExcelPutWorkbookInEditModepropCount = 0;
            if (mSExcelPutWorkbookInEditModeHandle != null)
            {
                mSExcelPutWorkbookInEditMode["Handle"] = ExpressionConverter.ConvertO(mSExcelPutWorkbookInEditModeHandle);
                mSExcelPutWorkbookInEditModepropCount++;
            }

            if (mSExcelPutWorkbookInEditModeWorkbookName != null)
            {
                mSExcelPutWorkbookInEditMode["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelPutWorkbookInEditModeWorkbookName);
                mSExcelPutWorkbookInEditModepropCount++;
            }

            if (mSExcelPutWorkbookInEditModeForce != null)
            {
                mSExcelPutWorkbookInEditMode["Force"] = ExpressionConverter.ConvertO(mSExcelPutWorkbookInEditModeForce);
                mSExcelPutWorkbookInEditModepropCount++;
            }

            mSExcelPutWorkbookInEditModepropCount++;
            mSExcelPutWorkbookInEditMode["Workflow"] = ExpressionConverter.ConvertO(mSExcelPutWorkbookInEditModeWorkflow);
            if (mSExcelPutWorkbookInEditModepropCount > 0)
            {
                callPayload.Body = mSExcelPutWorkbookInEditMode;
            }

            return new ApiConnectionAction<MSExcelPutWorkbookInEditModeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelCreateWorkbookResponse> MSExcelCreateWorkbook(Expression<Func<string>> mSExcelCreateWorkbookWorkflow, Expression<Func<int>> mSExcelCreateWorkbookHandle = null)
        {
            var apiCallPath = "/MSExcel/CreateWorkbook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelCreateWorkbook = new JObject();
            var mSExcelCreateWorkbookpropCount = 0;
            if (mSExcelCreateWorkbookHandle != null)
            {
                mSExcelCreateWorkbook["Handle"] = ExpressionConverter.ConvertO(mSExcelCreateWorkbookHandle);
                mSExcelCreateWorkbookpropCount++;
            }

            mSExcelCreateWorkbookpropCount++;
            mSExcelCreateWorkbook["Workflow"] = ExpressionConverter.ConvertO(mSExcelCreateWorkbookWorkflow);
            if (mSExcelCreateWorkbookpropCount > 0)
            {
                callPayload.Body = mSExcelCreateWorkbook;
            }

            return new ApiConnectionAction<MSExcelCreateWorkbookResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelCloseWorkbook(Expression<Func<string>> mSExcelCloseWorkbookWorkflow, Expression<Func<int>> mSExcelCloseWorkbookHandle = null, Expression<Func<string>> mSExcelCloseWorkbookWorkbookName = null, Expression<Func<bool>> mSExcelCloseWorkbookSaveData = null)
        {
            var apiCallPath = "/MSExcel/CloseWorkbook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelCloseWorkbook = new JObject();
            var mSExcelCloseWorkbookpropCount = 0;
            if (mSExcelCloseWorkbookHandle != null)
            {
                mSExcelCloseWorkbook["Handle"] = ExpressionConverter.ConvertO(mSExcelCloseWorkbookHandle);
                mSExcelCloseWorkbookpropCount++;
            }

            if (mSExcelCloseWorkbookWorkbookName != null)
            {
                mSExcelCloseWorkbook["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelCloseWorkbookWorkbookName);
                mSExcelCloseWorkbookpropCount++;
            }

            if (mSExcelCloseWorkbookSaveData != null)
            {
                mSExcelCloseWorkbook["SaveData"] = ExpressionConverter.ConvertO(mSExcelCloseWorkbookSaveData);
                mSExcelCloseWorkbookpropCount++;
            }

            mSExcelCloseWorkbookpropCount++;
            mSExcelCloseWorkbook["Workflow"] = ExpressionConverter.ConvertO(mSExcelCloseWorkbookWorkflow);
            if (mSExcelCloseWorkbookpropCount > 0)
            {
                callPayload.Body = mSExcelCloseWorkbook;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelCloseCurrentWorkbook(Expression<Func<string>> mSExcelCloseCurrentWorkbookWorkflow, Expression<Func<int>> mSExcelCloseCurrentWorkbookHandle = null)
        {
            var apiCallPath = "/MSExcel/CloseCurrentWorkbook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelCloseCurrentWorkbook = new JObject();
            var mSExcelCloseCurrentWorkbookpropCount = 0;
            if (mSExcelCloseCurrentWorkbookHandle != null)
            {
                mSExcelCloseCurrentWorkbook["Handle"] = ExpressionConverter.ConvertO(mSExcelCloseCurrentWorkbookHandle);
                mSExcelCloseCurrentWorkbookpropCount++;
            }

            mSExcelCloseCurrentWorkbookpropCount++;
            mSExcelCloseCurrentWorkbook["Workflow"] = ExpressionConverter.ConvertO(mSExcelCloseCurrentWorkbookWorkflow);
            if (mSExcelCloseCurrentWorkbookpropCount > 0)
            {
                callPayload.Body = mSExcelCloseCurrentWorkbook;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelGoToCell(Expression<Func<string>> mSExcelGoToCellCellReference, Expression<Func<string>> mSExcelGoToCellWorkflow, Expression<Func<int>> mSExcelGoToCellHandle = null, Expression<Func<string>> mSExcelGoToCellWorkbookName = null, Expression<Func<string>> mSExcelGoToCellWorksheetName = null)
        {
            var apiCallPath = "/MSExcel/GoToCell";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelGoToCell = new JObject();
            var mSExcelGoToCellpropCount = 0;
            if (mSExcelGoToCellHandle != null)
            {
                mSExcelGoToCell["Handle"] = ExpressionConverter.ConvertO(mSExcelGoToCellHandle);
                mSExcelGoToCellpropCount++;
            }

            if (mSExcelGoToCellWorkbookName != null)
            {
                mSExcelGoToCell["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelGoToCellWorkbookName);
                mSExcelGoToCellpropCount++;
            }

            if (mSExcelGoToCellWorksheetName != null)
            {
                mSExcelGoToCell["WorksheetName"] = ExpressionConverter.ConvertO(mSExcelGoToCellWorksheetName);
                mSExcelGoToCellpropCount++;
            }

            mSExcelGoToCellpropCount++;
            mSExcelGoToCell["CellReference"] = ExpressionConverter.ConvertO(mSExcelGoToCellCellReference);
            mSExcelGoToCellpropCount++;
            mSExcelGoToCell["Workflow"] = ExpressionConverter.ConvertO(mSExcelGoToCellWorkflow);
            if (mSExcelGoToCellpropCount > 0)
            {
                callPayload.Body = mSExcelGoToCell;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetCellValueResponse> MSExcelGetCellValue(Expression<Func<string>> mSExcelGetCellValueCellReference, Expression<Func<string>> mSExcelGetCellValueWorkflow, Expression<Func<int>> mSExcelGetCellValueHandle = null, Expression<Func<string>> mSExcelGetCellValueWorkbookName = null, Expression<Func<string>> mSExcelGetCellValueWorksheetName = null)
        {
            var apiCallPath = "/MSExcel/GetCellValue";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelGetCellValue = new JObject();
            var mSExcelGetCellValuepropCount = 0;
            if (mSExcelGetCellValueHandle != null)
            {
                mSExcelGetCellValue["Handle"] = ExpressionConverter.ConvertO(mSExcelGetCellValueHandle);
                mSExcelGetCellValuepropCount++;
            }

            if (mSExcelGetCellValueWorkbookName != null)
            {
                mSExcelGetCellValue["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelGetCellValueWorkbookName);
                mSExcelGetCellValuepropCount++;
            }

            if (mSExcelGetCellValueWorksheetName != null)
            {
                mSExcelGetCellValue["WorksheetName"] = ExpressionConverter.ConvertO(mSExcelGetCellValueWorksheetName);
                mSExcelGetCellValuepropCount++;
            }

            mSExcelGetCellValuepropCount++;
            mSExcelGetCellValue["CellReference"] = ExpressionConverter.ConvertO(mSExcelGetCellValueCellReference);
            mSExcelGetCellValuepropCount++;
            mSExcelGetCellValue["Workflow"] = ExpressionConverter.ConvertO(mSExcelGetCellValueWorkflow);
            if (mSExcelGetCellValuepropCount > 0)
            {
                callPayload.Body = mSExcelGetCellValue;
            }

            return new ApiConnectionAction<MSExcelGetCellValueResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetCellValue2Response> MSExcelGetCellValue2(Expression<Func<string>> mSExcelGetCellValue2CellReference, Expression<Func<string>> mSExcelGetCellValue2Workflow, Expression<Func<int>> mSExcelGetCellValue2Handle = null, Expression<Func<string>> mSExcelGetCellValue2WorkbookName = null, Expression<Func<string>> mSExcelGetCellValue2WorksheetName = null)
        {
            var apiCallPath = "/MSExcel/GetCellValue2";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelGetCellValue2 = new JObject();
            var mSExcelGetCellValue2propCount = 0;
            if (mSExcelGetCellValue2Handle != null)
            {
                mSExcelGetCellValue2["Handle"] = ExpressionConverter.ConvertO(mSExcelGetCellValue2Handle);
                mSExcelGetCellValue2propCount++;
            }

            if (mSExcelGetCellValue2WorkbookName != null)
            {
                mSExcelGetCellValue2["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelGetCellValue2WorkbookName);
                mSExcelGetCellValue2propCount++;
            }

            if (mSExcelGetCellValue2WorksheetName != null)
            {
                mSExcelGetCellValue2["WorksheetName"] = ExpressionConverter.ConvertO(mSExcelGetCellValue2WorksheetName);
                mSExcelGetCellValue2propCount++;
            }

            mSExcelGetCellValue2propCount++;
            mSExcelGetCellValue2["CellReference"] = ExpressionConverter.ConvertO(mSExcelGetCellValue2CellReference);
            mSExcelGetCellValue2propCount++;
            mSExcelGetCellValue2["Workflow"] = ExpressionConverter.ConvertO(mSExcelGetCellValue2Workflow);
            if (mSExcelGetCellValue2propCount > 0)
            {
                callPayload.Body = mSExcelGetCellValue2;
            }

            return new ApiConnectionAction<MSExcelGetCellValue2Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetCellTextResponse> MSExcelGetCellText(Expression<Func<string>> mSExcelGetCellTextCellReference, Expression<Func<string>> mSExcelGetCellTextWorkflow, Expression<Func<int>> mSExcelGetCellTextHandle = null, Expression<Func<string>> mSExcelGetCellTextWorkbookName = null, Expression<Func<string>> mSExcelGetCellTextWorksheetName = null)
        {
            var apiCallPath = "/MSExcel/GetCellText";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelGetCellText = new JObject();
            var mSExcelGetCellTextpropCount = 0;
            if (mSExcelGetCellTextHandle != null)
            {
                mSExcelGetCellText["Handle"] = ExpressionConverter.ConvertO(mSExcelGetCellTextHandle);
                mSExcelGetCellTextpropCount++;
            }

            if (mSExcelGetCellTextWorkbookName != null)
            {
                mSExcelGetCellText["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelGetCellTextWorkbookName);
                mSExcelGetCellTextpropCount++;
            }

            if (mSExcelGetCellTextWorksheetName != null)
            {
                mSExcelGetCellText["WorksheetName"] = ExpressionConverter.ConvertO(mSExcelGetCellTextWorksheetName);
                mSExcelGetCellTextpropCount++;
            }

            mSExcelGetCellTextpropCount++;
            mSExcelGetCellText["CellReference"] = ExpressionConverter.ConvertO(mSExcelGetCellTextCellReference);
            mSExcelGetCellTextpropCount++;
            mSExcelGetCellText["Workflow"] = ExpressionConverter.ConvertO(mSExcelGetCellTextWorkflow);
            if (mSExcelGetCellTextpropCount > 0)
            {
                callPayload.Body = mSExcelGetCellText;
            }

            return new ApiConnectionAction<MSExcelGetCellTextResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelSetCellValue(Expression<Func<string>> mSExcelSetCellValueCellReference, Expression<Func<string>> mSExcelSetCellValueWorkflow, Expression<Func<int>> mSExcelSetCellValueHandle = null, Expression<Func<string>> mSExcelSetCellValueWorkbookName = null, Expression<Func<string>> mSExcelSetCellValueWorksheetName = null, Expression<Func<string>> mSExcelSetCellValueCellValue = null, Expression<Func<bool>> mSExcelSetCellValueCellValueContainsStoredPassword = null)
        {
            var apiCallPath = "/MSExcel/SetCellValue";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelSetCellValue = new JObject();
            var mSExcelSetCellValuepropCount = 0;
            if (mSExcelSetCellValueHandle != null)
            {
                mSExcelSetCellValue["Handle"] = ExpressionConverter.ConvertO(mSExcelSetCellValueHandle);
                mSExcelSetCellValuepropCount++;
            }

            if (mSExcelSetCellValueWorkbookName != null)
            {
                mSExcelSetCellValue["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelSetCellValueWorkbookName);
                mSExcelSetCellValuepropCount++;
            }

            if (mSExcelSetCellValueWorksheetName != null)
            {
                mSExcelSetCellValue["WorksheetName"] = ExpressionConverter.ConvertO(mSExcelSetCellValueWorksheetName);
                mSExcelSetCellValuepropCount++;
            }

            mSExcelSetCellValuepropCount++;
            mSExcelSetCellValue["CellReference"] = ExpressionConverter.ConvertO(mSExcelSetCellValueCellReference);
            if (mSExcelSetCellValueCellValue != null)
            {
                mSExcelSetCellValue["CellValue"] = ExpressionConverter.ConvertO(mSExcelSetCellValueCellValue);
                mSExcelSetCellValuepropCount++;
            }

            if (mSExcelSetCellValueCellValueContainsStoredPassword != null)
            {
                mSExcelSetCellValue["CellValueContainsStoredPassword"] = ExpressionConverter.ConvertO(mSExcelSetCellValueCellValueContainsStoredPassword);
                mSExcelSetCellValuepropCount++;
            }

            mSExcelSetCellValuepropCount++;
            mSExcelSetCellValue["Workflow"] = ExpressionConverter.ConvertO(mSExcelSetCellValueWorkflow);
            if (mSExcelSetCellValuepropCount > 0)
            {
                callPayload.Body = mSExcelSetCellValue;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelFindNextCellWithValueResponse> MSExcelFindNextCellWithValue(Expression<Func<mSExcelFindNextCellWithValueDirectionInput>> mSExcelFindNextCellWithValueDirection, Expression<Func<string>> mSExcelFindNextCellWithValueSearchValue, Expression<Func<string>> mSExcelFindNextCellWithValueWorkflow, Expression<Func<int>> mSExcelFindNextCellWithValueHandle = null, Expression<Func<string>> mSExcelFindNextCellWithValueWorkbookName = null, Expression<Func<string>> mSExcelFindNextCellWithValueWorksheetName = null, Expression<Func<bool>> mSExcelFindNextCellWithValueCaseSensitive = null, Expression<Func<mSExcelFindNextCellWithValueComparisonTypeInput>> mSExcelFindNextCellWithValueComparisonType = null, Expression<Func<int>> mSExcelFindNextCellWithValueMaxCellsToSearch = null, Expression<Func<bool>> mSExcelFindNextCellWithValueActivateCell = null)
        {
            var apiCallPath = "/MSExcel/FindNextCellWithValue";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelFindNextCellWithValue = new JObject();
            var mSExcelFindNextCellWithValuepropCount = 0;
            if (mSExcelFindNextCellWithValueHandle != null)
            {
                mSExcelFindNextCellWithValue["Handle"] = ExpressionConverter.ConvertO(mSExcelFindNextCellWithValueHandle);
                mSExcelFindNextCellWithValuepropCount++;
            }

            if (mSExcelFindNextCellWithValueWorkbookName != null)
            {
                mSExcelFindNextCellWithValue["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelFindNextCellWithValueWorkbookName);
                mSExcelFindNextCellWithValuepropCount++;
            }

            if (mSExcelFindNextCellWithValueWorksheetName != null)
            {
                mSExcelFindNextCellWithValue["WorksheetName"] = ExpressionConverter.ConvertO(mSExcelFindNextCellWithValueWorksheetName);
                mSExcelFindNextCellWithValuepropCount++;
            }

            mSExcelFindNextCellWithValuepropCount++;
            mSExcelFindNextCellWithValue["Direction"] = ExpressionConverter.ConvertO(mSExcelFindNextCellWithValueDirection);
            mSExcelFindNextCellWithValuepropCount++;
            mSExcelFindNextCellWithValue["SearchValue"] = ExpressionConverter.ConvertO(mSExcelFindNextCellWithValueSearchValue);
            if (mSExcelFindNextCellWithValueCaseSensitive != null)
            {
                mSExcelFindNextCellWithValue["CaseSensitive"] = ExpressionConverter.ConvertO(mSExcelFindNextCellWithValueCaseSensitive);
                mSExcelFindNextCellWithValuepropCount++;
            }

            if (mSExcelFindNextCellWithValueComparisonType != null)
            {
                mSExcelFindNextCellWithValue["ComparisonType"] = ExpressionConverter.ConvertO(mSExcelFindNextCellWithValueComparisonType);
                mSExcelFindNextCellWithValuepropCount++;
            }

            if (mSExcelFindNextCellWithValueMaxCellsToSearch != null)
            {
                mSExcelFindNextCellWithValue["MaxCellsToSearch"] = ExpressionConverter.ConvertO(mSExcelFindNextCellWithValueMaxCellsToSearch);
                mSExcelFindNextCellWithValuepropCount++;
            }

            if (mSExcelFindNextCellWithValueActivateCell != null)
            {
                mSExcelFindNextCellWithValue["ActivateCell"] = ExpressionConverter.ConvertO(mSExcelFindNextCellWithValueActivateCell);
                mSExcelFindNextCellWithValuepropCount++;
            }

            mSExcelFindNextCellWithValuepropCount++;
            mSExcelFindNextCellWithValue["Workflow"] = ExpressionConverter.ConvertO(mSExcelFindNextCellWithValueWorkflow);
            if (mSExcelFindNextCellWithValuepropCount > 0)
            {
                callPayload.Body = mSExcelFindNextCellWithValue;
            }

            return new ApiConnectionAction<MSExcelFindNextCellWithValueResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelFindNextEmptyCellResponse> MSExcelFindNextEmptyCell(Expression<Func<mSExcelFindNextEmptyCellDirectionInput>> mSExcelFindNextEmptyCellDirection, Expression<Func<string>> mSExcelFindNextEmptyCellWorkflow, Expression<Func<int>> mSExcelFindNextEmptyCellHandle = null, Expression<Func<string>> mSExcelFindNextEmptyCellWorkbookName = null, Expression<Func<string>> mSExcelFindNextEmptyCellWorksheetName = null, Expression<Func<bool>> mSExcelFindNextEmptyCellActivateCell = null)
        {
            var apiCallPath = "/MSExcel/FindNextEmptyCell";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelFindNextEmptyCell = new JObject();
            var mSExcelFindNextEmptyCellpropCount = 0;
            if (mSExcelFindNextEmptyCellHandle != null)
            {
                mSExcelFindNextEmptyCell["Handle"] = ExpressionConverter.ConvertO(mSExcelFindNextEmptyCellHandle);
                mSExcelFindNextEmptyCellpropCount++;
            }

            if (mSExcelFindNextEmptyCellWorkbookName != null)
            {
                mSExcelFindNextEmptyCell["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelFindNextEmptyCellWorkbookName);
                mSExcelFindNextEmptyCellpropCount++;
            }

            if (mSExcelFindNextEmptyCellWorksheetName != null)
            {
                mSExcelFindNextEmptyCell["WorksheetName"] = ExpressionConverter.ConvertO(mSExcelFindNextEmptyCellWorksheetName);
                mSExcelFindNextEmptyCellpropCount++;
            }

            mSExcelFindNextEmptyCellpropCount++;
            mSExcelFindNextEmptyCell["Direction"] = ExpressionConverter.ConvertO(mSExcelFindNextEmptyCellDirection);
            if (mSExcelFindNextEmptyCellActivateCell != null)
            {
                mSExcelFindNextEmptyCell["ActivateCell"] = ExpressionConverter.ConvertO(mSExcelFindNextEmptyCellActivateCell);
                mSExcelFindNextEmptyCellpropCount++;
            }

            mSExcelFindNextEmptyCellpropCount++;
            mSExcelFindNextEmptyCell["Workflow"] = ExpressionConverter.ConvertO(mSExcelFindNextEmptyCellWorkflow);
            if (mSExcelFindNextEmptyCellpropCount > 0)
            {
                callPayload.Body = mSExcelFindNextEmptyCell;
            }

            return new ApiConnectionAction<MSExcelFindNextEmptyCellResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGotoNextEmptyCellLeftResponse> MSExcelGotoNextEmptyCellLeft(Expression<Func<string>> mSExcelGotoNextEmptyCellLeftWorkflow, Expression<Func<int>> mSExcelGotoNextEmptyCellLeftHandle = null, Expression<Func<string>> mSExcelGotoNextEmptyCellLeftWorkbookName = null, Expression<Func<string>> mSExcelGotoNextEmptyCellLeftWorksheetName = null)
        {
            var apiCallPath = "/MSExcel/GotoNextEmptyCellLeft";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelGotoNextEmptyCellLeft = new JObject();
            var mSExcelGotoNextEmptyCellLeftpropCount = 0;
            if (mSExcelGotoNextEmptyCellLeftHandle != null)
            {
                mSExcelGotoNextEmptyCellLeft["Handle"] = ExpressionConverter.ConvertO(mSExcelGotoNextEmptyCellLeftHandle);
                mSExcelGotoNextEmptyCellLeftpropCount++;
            }

            if (mSExcelGotoNextEmptyCellLeftWorkbookName != null)
            {
                mSExcelGotoNextEmptyCellLeft["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelGotoNextEmptyCellLeftWorkbookName);
                mSExcelGotoNextEmptyCellLeftpropCount++;
            }

            if (mSExcelGotoNextEmptyCellLeftWorksheetName != null)
            {
                mSExcelGotoNextEmptyCellLeft["WorksheetName"] = ExpressionConverter.ConvertO(mSExcelGotoNextEmptyCellLeftWorksheetName);
                mSExcelGotoNextEmptyCellLeftpropCount++;
            }

            mSExcelGotoNextEmptyCellLeftpropCount++;
            mSExcelGotoNextEmptyCellLeft["Workflow"] = ExpressionConverter.ConvertO(mSExcelGotoNextEmptyCellLeftWorkflow);
            if (mSExcelGotoNextEmptyCellLeftpropCount > 0)
            {
                callPayload.Body = mSExcelGotoNextEmptyCellLeft;
            }

            return new ApiConnectionAction<MSExcelGotoNextEmptyCellLeftResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGotoNextEmptyCellRightResponse> MSExcelGotoNextEmptyCellRight(Expression<Func<string>> mSExcelGotoNextEmptyCellRightWorkflow, Expression<Func<int>> mSExcelGotoNextEmptyCellRightHandle = null, Expression<Func<string>> mSExcelGotoNextEmptyCellRightWorkbookName = null, Expression<Func<string>> mSExcelGotoNextEmptyCellRightWorksheetName = null)
        {
            var apiCallPath = "/MSExcel/GotoNextEmptyCellRight";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelGotoNextEmptyCellRight = new JObject();
            var mSExcelGotoNextEmptyCellRightpropCount = 0;
            if (mSExcelGotoNextEmptyCellRightHandle != null)
            {
                mSExcelGotoNextEmptyCellRight["Handle"] = ExpressionConverter.ConvertO(mSExcelGotoNextEmptyCellRightHandle);
                mSExcelGotoNextEmptyCellRightpropCount++;
            }

            if (mSExcelGotoNextEmptyCellRightWorkbookName != null)
            {
                mSExcelGotoNextEmptyCellRight["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelGotoNextEmptyCellRightWorkbookName);
                mSExcelGotoNextEmptyCellRightpropCount++;
            }

            if (mSExcelGotoNextEmptyCellRightWorksheetName != null)
            {
                mSExcelGotoNextEmptyCellRight["WorksheetName"] = ExpressionConverter.ConvertO(mSExcelGotoNextEmptyCellRightWorksheetName);
                mSExcelGotoNextEmptyCellRightpropCount++;
            }

            mSExcelGotoNextEmptyCellRightpropCount++;
            mSExcelGotoNextEmptyCellRight["Workflow"] = ExpressionConverter.ConvertO(mSExcelGotoNextEmptyCellRightWorkflow);
            if (mSExcelGotoNextEmptyCellRightpropCount > 0)
            {
                callPayload.Body = mSExcelGotoNextEmptyCellRight;
            }

            return new ApiConnectionAction<MSExcelGotoNextEmptyCellRightResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGotoNextEmptyCellUpResponse> MSExcelGotoNextEmptyCellUp(Expression<Func<string>> mSExcelGotoNextEmptyCellUpWorkflow, Expression<Func<int>> mSExcelGotoNextEmptyCellUpHandle = null, Expression<Func<string>> mSExcelGotoNextEmptyCellUpWorkbookName = null, Expression<Func<string>> mSExcelGotoNextEmptyCellUpWorksheetName = null)
        {
            var apiCallPath = "/MSExcel/GotoNextEmptyCellUp";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelGotoNextEmptyCellUp = new JObject();
            var mSExcelGotoNextEmptyCellUppropCount = 0;
            if (mSExcelGotoNextEmptyCellUpHandle != null)
            {
                mSExcelGotoNextEmptyCellUp["Handle"] = ExpressionConverter.ConvertO(mSExcelGotoNextEmptyCellUpHandle);
                mSExcelGotoNextEmptyCellUppropCount++;
            }

            if (mSExcelGotoNextEmptyCellUpWorkbookName != null)
            {
                mSExcelGotoNextEmptyCellUp["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelGotoNextEmptyCellUpWorkbookName);
                mSExcelGotoNextEmptyCellUppropCount++;
            }

            if (mSExcelGotoNextEmptyCellUpWorksheetName != null)
            {
                mSExcelGotoNextEmptyCellUp["WorksheetName"] = ExpressionConverter.ConvertO(mSExcelGotoNextEmptyCellUpWorksheetName);
                mSExcelGotoNextEmptyCellUppropCount++;
            }

            mSExcelGotoNextEmptyCellUppropCount++;
            mSExcelGotoNextEmptyCellUp["Workflow"] = ExpressionConverter.ConvertO(mSExcelGotoNextEmptyCellUpWorkflow);
            if (mSExcelGotoNextEmptyCellUppropCount > 0)
            {
                callPayload.Body = mSExcelGotoNextEmptyCellUp;
            }

            return new ApiConnectionAction<MSExcelGotoNextEmptyCellUpResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGotoNextEmptyCellDownResponse> MSExcelGotoNextEmptyCellDown(Expression<Func<string>> mSExcelGotoNextEmptyCellDownWorkflow, Expression<Func<int>> mSExcelGotoNextEmptyCellDownHandle = null, Expression<Func<string>> mSExcelGotoNextEmptyCellDownWorkbookName = null, Expression<Func<string>> mSExcelGotoNextEmptyCellDownWorksheetName = null)
        {
            var apiCallPath = "/MSExcel/GotoNextEmptyCellDown";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelGotoNextEmptyCellDown = new JObject();
            var mSExcelGotoNextEmptyCellDownpropCount = 0;
            if (mSExcelGotoNextEmptyCellDownHandle != null)
            {
                mSExcelGotoNextEmptyCellDown["Handle"] = ExpressionConverter.ConvertO(mSExcelGotoNextEmptyCellDownHandle);
                mSExcelGotoNextEmptyCellDownpropCount++;
            }

            if (mSExcelGotoNextEmptyCellDownWorkbookName != null)
            {
                mSExcelGotoNextEmptyCellDown["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelGotoNextEmptyCellDownWorkbookName);
                mSExcelGotoNextEmptyCellDownpropCount++;
            }

            if (mSExcelGotoNextEmptyCellDownWorksheetName != null)
            {
                mSExcelGotoNextEmptyCellDown["WorksheetName"] = ExpressionConverter.ConvertO(mSExcelGotoNextEmptyCellDownWorksheetName);
                mSExcelGotoNextEmptyCellDownpropCount++;
            }

            mSExcelGotoNextEmptyCellDownpropCount++;
            mSExcelGotoNextEmptyCellDown["Workflow"] = ExpressionConverter.ConvertO(mSExcelGotoNextEmptyCellDownWorkflow);
            if (mSExcelGotoNextEmptyCellDownpropCount > 0)
            {
                callPayload.Body = mSExcelGotoNextEmptyCellDown;
            }

            return new ApiConnectionAction<MSExcelGotoNextEmptyCellDownResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelSaveWorkbookResponse> MSExcelSaveWorkbook(Expression<Func<string>> mSExcelSaveWorkbookWorkflow, Expression<Func<int>> mSExcelSaveWorkbookHandle = null, Expression<Func<string>> mSExcelSaveWorkbookWorkbookName = null)
        {
            var apiCallPath = "/MSExcel/SaveWorkbook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelSaveWorkbook = new JObject();
            var mSExcelSaveWorkbookpropCount = 0;
            if (mSExcelSaveWorkbookHandle != null)
            {
                mSExcelSaveWorkbook["Handle"] = ExpressionConverter.ConvertO(mSExcelSaveWorkbookHandle);
                mSExcelSaveWorkbookpropCount++;
            }

            if (mSExcelSaveWorkbookWorkbookName != null)
            {
                mSExcelSaveWorkbook["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelSaveWorkbookWorkbookName);
                mSExcelSaveWorkbookpropCount++;
            }

            mSExcelSaveWorkbookpropCount++;
            mSExcelSaveWorkbook["Workflow"] = ExpressionConverter.ConvertO(mSExcelSaveWorkbookWorkflow);
            if (mSExcelSaveWorkbookpropCount > 0)
            {
                callPayload.Body = mSExcelSaveWorkbook;
            }

            return new ApiConnectionAction<MSExcelSaveWorkbookResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelSaveWorkbookAsResponse> MSExcelSaveWorkbookAs(Expression<Func<string>> mSExcelSaveWorkbookAsSaveFilename, Expression<Func<string>> mSExcelSaveWorkbookAsWorkflow, Expression<Func<int>> mSExcelSaveWorkbookAsHandle = null, Expression<Func<string>> mSExcelSaveWorkbookAsWorkbookName = null, Expression<Func<bool>> mSExcelSaveWorkbookAsDeleteExistingSaveFilename = null, Expression<Func<mSExcelSaveWorkbookAsExcelFileFormatInput>> mSExcelSaveWorkbookAsExcelFileFormat = null)
        {
            var apiCallPath = "/MSExcel/SaveWorkbookAs";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelSaveWorkbookAs = new JObject();
            var mSExcelSaveWorkbookAspropCount = 0;
            if (mSExcelSaveWorkbookAsHandle != null)
            {
                mSExcelSaveWorkbookAs["Handle"] = ExpressionConverter.ConvertO(mSExcelSaveWorkbookAsHandle);
                mSExcelSaveWorkbookAspropCount++;
            }

            if (mSExcelSaveWorkbookAsWorkbookName != null)
            {
                mSExcelSaveWorkbookAs["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelSaveWorkbookAsWorkbookName);
                mSExcelSaveWorkbookAspropCount++;
            }

            mSExcelSaveWorkbookAspropCount++;
            mSExcelSaveWorkbookAs["SaveFilename"] = ExpressionConverter.ConvertO(mSExcelSaveWorkbookAsSaveFilename);
            if (mSExcelSaveWorkbookAsDeleteExistingSaveFilename != null)
            {
                mSExcelSaveWorkbookAs["DeleteExistingSaveFilename"] = ExpressionConverter.ConvertO(mSExcelSaveWorkbookAsDeleteExistingSaveFilename);
                mSExcelSaveWorkbookAspropCount++;
            }

            if (mSExcelSaveWorkbookAsExcelFileFormat != null)
            {
                mSExcelSaveWorkbookAs["ExcelFileFormat"] = ExpressionConverter.ConvertO(mSExcelSaveWorkbookAsExcelFileFormat);
                mSExcelSaveWorkbookAspropCount++;
            }

            mSExcelSaveWorkbookAspropCount++;
            mSExcelSaveWorkbookAs["Workflow"] = ExpressionConverter.ConvertO(mSExcelSaveWorkbookAsWorkflow);
            if (mSExcelSaveWorkbookAspropCount > 0)
            {
                callPayload.Body = mSExcelSaveWorkbookAs;
            }

            return new ApiConnectionAction<MSExcelSaveWorkbookAsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelSaveWorkbookAsCSVResponse> MSExcelSaveWorkbookAsCSV(Expression<Func<string>> mSExcelSaveWorkbookAsCSVSaveFilename, Expression<Func<string>> mSExcelSaveWorkbookAsCSVWorkflow, Expression<Func<int>> mSExcelSaveWorkbookAsCSVHandle = null, Expression<Func<string>> mSExcelSaveWorkbookAsCSVWorkbookName = null, Expression<Func<bool>> mSExcelSaveWorkbookAsCSVDeleteExistingSaveFilename = null)
        {
            var apiCallPath = "/MSExcel/SaveWorkbookAsCSV";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelSaveWorkbookAsCSV = new JObject();
            var mSExcelSaveWorkbookAsCSVpropCount = 0;
            if (mSExcelSaveWorkbookAsCSVHandle != null)
            {
                mSExcelSaveWorkbookAsCSV["Handle"] = ExpressionConverter.ConvertO(mSExcelSaveWorkbookAsCSVHandle);
                mSExcelSaveWorkbookAsCSVpropCount++;
            }

            if (mSExcelSaveWorkbookAsCSVWorkbookName != null)
            {
                mSExcelSaveWorkbookAsCSV["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelSaveWorkbookAsCSVWorkbookName);
                mSExcelSaveWorkbookAsCSVpropCount++;
            }

            mSExcelSaveWorkbookAsCSVpropCount++;
            mSExcelSaveWorkbookAsCSV["SaveFilename"] = ExpressionConverter.ConvertO(mSExcelSaveWorkbookAsCSVSaveFilename);
            if (mSExcelSaveWorkbookAsCSVDeleteExistingSaveFilename != null)
            {
                mSExcelSaveWorkbookAsCSV["DeleteExistingSaveFilename"] = ExpressionConverter.ConvertO(mSExcelSaveWorkbookAsCSVDeleteExistingSaveFilename);
                mSExcelSaveWorkbookAsCSVpropCount++;
            }

            mSExcelSaveWorkbookAsCSVpropCount++;
            mSExcelSaveWorkbookAsCSV["Workflow"] = ExpressionConverter.ConvertO(mSExcelSaveWorkbookAsCSVWorkflow);
            if (mSExcelSaveWorkbookAsCSVpropCount > 0)
            {
                callPayload.Body = mSExcelSaveWorkbookAsCSV;
            }

            return new ApiConnectionAction<MSExcelSaveWorkbookAsCSVResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelSaveWorkbookAsWithPasswordResponse> MSExcelSaveWorkbookAsWithPassword(Expression<Func<string>> mSExcelSaveWorkbookAsWithPasswordSaveFilename, Expression<Func<string>> mSExcelSaveWorkbookAsWithPasswordPassword, Expression<Func<string>> mSExcelSaveWorkbookAsWithPasswordWorkflow, Expression<Func<int>> mSExcelSaveWorkbookAsWithPasswordHandle = null, Expression<Func<string>> mSExcelSaveWorkbookAsWithPasswordWorkbookName = null, Expression<Func<bool>> mSExcelSaveWorkbookAsWithPasswordDeleteExistingSaveFilename = null, Expression<Func<mSExcelSaveWorkbookAsWithPasswordExcelFileFormatInput>> mSExcelSaveWorkbookAsWithPasswordExcelFileFormat = null)
        {
            var apiCallPath = "/MSExcel/SaveWorkbookAsWithPassword";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelSaveWorkbookAsWithPassword = new JObject();
            var mSExcelSaveWorkbookAsWithPasswordpropCount = 0;
            if (mSExcelSaveWorkbookAsWithPasswordHandle != null)
            {
                mSExcelSaveWorkbookAsWithPassword["Handle"] = ExpressionConverter.ConvertO(mSExcelSaveWorkbookAsWithPasswordHandle);
                mSExcelSaveWorkbookAsWithPasswordpropCount++;
            }

            if (mSExcelSaveWorkbookAsWithPasswordWorkbookName != null)
            {
                mSExcelSaveWorkbookAsWithPassword["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelSaveWorkbookAsWithPasswordWorkbookName);
                mSExcelSaveWorkbookAsWithPasswordpropCount++;
            }

            mSExcelSaveWorkbookAsWithPasswordpropCount++;
            mSExcelSaveWorkbookAsWithPassword["SaveFilename"] = ExpressionConverter.ConvertO(mSExcelSaveWorkbookAsWithPasswordSaveFilename);
            mSExcelSaveWorkbookAsWithPasswordpropCount++;
            mSExcelSaveWorkbookAsWithPassword["Password"] = ExpressionConverter.ConvertO(mSExcelSaveWorkbookAsWithPasswordPassword);
            if (mSExcelSaveWorkbookAsWithPasswordDeleteExistingSaveFilename != null)
            {
                mSExcelSaveWorkbookAsWithPassword["DeleteExistingSaveFilename"] = ExpressionConverter.ConvertO(mSExcelSaveWorkbookAsWithPasswordDeleteExistingSaveFilename);
                mSExcelSaveWorkbookAsWithPasswordpropCount++;
            }

            if (mSExcelSaveWorkbookAsWithPasswordExcelFileFormat != null)
            {
                mSExcelSaveWorkbookAsWithPassword["ExcelFileFormat"] = ExpressionConverter.ConvertO(mSExcelSaveWorkbookAsWithPasswordExcelFileFormat);
                mSExcelSaveWorkbookAsWithPasswordpropCount++;
            }

            mSExcelSaveWorkbookAsWithPasswordpropCount++;
            mSExcelSaveWorkbookAsWithPassword["Workflow"] = ExpressionConverter.ConvertO(mSExcelSaveWorkbookAsWithPasswordWorkflow);
            if (mSExcelSaveWorkbookAsWithPasswordpropCount > 0)
            {
                callPayload.Body = mSExcelSaveWorkbookAsWithPassword;
            }

            return new ApiConnectionAction<MSExcelSaveWorkbookAsWithPasswordResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelSaveCurrentWorkbookResponse> MSExcelSaveCurrentWorkbook(Expression<Func<string>> mSExcelSaveCurrentWorkbookWorkflow, Expression<Func<int>> mSExcelSaveCurrentWorkbookHandle = null)
        {
            var apiCallPath = "/MSExcel/SaveCurrentWorkbook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelSaveCurrentWorkbook = new JObject();
            var mSExcelSaveCurrentWorkbookpropCount = 0;
            if (mSExcelSaveCurrentWorkbookHandle != null)
            {
                mSExcelSaveCurrentWorkbook["Handle"] = ExpressionConverter.ConvertO(mSExcelSaveCurrentWorkbookHandle);
                mSExcelSaveCurrentWorkbookpropCount++;
            }

            mSExcelSaveCurrentWorkbookpropCount++;
            mSExcelSaveCurrentWorkbook["Workflow"] = ExpressionConverter.ConvertO(mSExcelSaveCurrentWorkbookWorkflow);
            if (mSExcelSaveCurrentWorkbookpropCount > 0)
            {
                callPayload.Body = mSExcelSaveCurrentWorkbook;
            }

            return new ApiConnectionAction<MSExcelSaveCurrentWorkbookResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelSaveCurrentWorkbookAsResponse> MSExcelSaveCurrentWorkbookAs(Expression<Func<string>> mSExcelSaveCurrentWorkbookAsWorkflow, Expression<Func<int>> mSExcelSaveCurrentWorkbookAsHandle = null, Expression<Func<string>> mSExcelSaveCurrentWorkbookAsSaveFilename = null, Expression<Func<bool>> mSExcelSaveCurrentWorkbookAsDeleteExistingSaveFilename = null, Expression<Func<mSExcelSaveCurrentWorkbookAsExcelFileFormatInput>> mSExcelSaveCurrentWorkbookAsExcelFileFormat = null)
        {
            var apiCallPath = "/MSExcel/SaveCurrentWorkbookAs";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelSaveCurrentWorkbookAs = new JObject();
            var mSExcelSaveCurrentWorkbookAspropCount = 0;
            if (mSExcelSaveCurrentWorkbookAsHandle != null)
            {
                mSExcelSaveCurrentWorkbookAs["Handle"] = ExpressionConverter.ConvertO(mSExcelSaveCurrentWorkbookAsHandle);
                mSExcelSaveCurrentWorkbookAspropCount++;
            }

            if (mSExcelSaveCurrentWorkbookAsSaveFilename != null)
            {
                mSExcelSaveCurrentWorkbookAs["SaveFilename"] = ExpressionConverter.ConvertO(mSExcelSaveCurrentWorkbookAsSaveFilename);
                mSExcelSaveCurrentWorkbookAspropCount++;
            }

            if (mSExcelSaveCurrentWorkbookAsDeleteExistingSaveFilename != null)
            {
                mSExcelSaveCurrentWorkbookAs["DeleteExistingSaveFilename"] = ExpressionConverter.ConvertO(mSExcelSaveCurrentWorkbookAsDeleteExistingSaveFilename);
                mSExcelSaveCurrentWorkbookAspropCount++;
            }

            if (mSExcelSaveCurrentWorkbookAsExcelFileFormat != null)
            {
                mSExcelSaveCurrentWorkbookAs["ExcelFileFormat"] = ExpressionConverter.ConvertO(mSExcelSaveCurrentWorkbookAsExcelFileFormat);
                mSExcelSaveCurrentWorkbookAspropCount++;
            }

            mSExcelSaveCurrentWorkbookAspropCount++;
            mSExcelSaveCurrentWorkbookAs["Workflow"] = ExpressionConverter.ConvertO(mSExcelSaveCurrentWorkbookAsWorkflow);
            if (mSExcelSaveCurrentWorkbookAspropCount > 0)
            {
                callPayload.Body = mSExcelSaveCurrentWorkbookAs;
            }

            return new ApiConnectionAction<MSExcelSaveCurrentWorkbookAsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelSaveCurrentWorkbookAsCSVResponse> MSExcelSaveCurrentWorkbookAsCSV(Expression<Func<string>> mSExcelSaveCurrentWorkbookAsCSVSaveFilename, Expression<Func<string>> mSExcelSaveCurrentWorkbookAsCSVWorkflow, Expression<Func<int>> mSExcelSaveCurrentWorkbookAsCSVHandle = null, Expression<Func<bool>> mSExcelSaveCurrentWorkbookAsCSVDeleteExistingSaveFilename = null)
        {
            var apiCallPath = "/MSExcel/SaveCurrentWorkbookAsCSV";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelSaveCurrentWorkbookAsCSV = new JObject();
            var mSExcelSaveCurrentWorkbookAsCSVpropCount = 0;
            if (mSExcelSaveCurrentWorkbookAsCSVHandle != null)
            {
                mSExcelSaveCurrentWorkbookAsCSV["Handle"] = ExpressionConverter.ConvertO(mSExcelSaveCurrentWorkbookAsCSVHandle);
                mSExcelSaveCurrentWorkbookAsCSVpropCount++;
            }

            mSExcelSaveCurrentWorkbookAsCSVpropCount++;
            mSExcelSaveCurrentWorkbookAsCSV["SaveFilename"] = ExpressionConverter.ConvertO(mSExcelSaveCurrentWorkbookAsCSVSaveFilename);
            if (mSExcelSaveCurrentWorkbookAsCSVDeleteExistingSaveFilename != null)
            {
                mSExcelSaveCurrentWorkbookAsCSV["DeleteExistingSaveFilename"] = ExpressionConverter.ConvertO(mSExcelSaveCurrentWorkbookAsCSVDeleteExistingSaveFilename);
                mSExcelSaveCurrentWorkbookAsCSVpropCount++;
            }

            mSExcelSaveCurrentWorkbookAsCSVpropCount++;
            mSExcelSaveCurrentWorkbookAsCSV["Workflow"] = ExpressionConverter.ConvertO(mSExcelSaveCurrentWorkbookAsCSVWorkflow);
            if (mSExcelSaveCurrentWorkbookAsCSVpropCount > 0)
            {
                callPayload.Body = mSExcelSaveCurrentWorkbookAsCSV;
            }

            return new ApiConnectionAction<MSExcelSaveCurrentWorkbookAsCSVResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetWorksheetNamesResponse> MSExcelGetWorksheetNames(Expression<Func<string>> mSExcelGetWorksheetNamesWorkflow, Expression<Func<int>> mSExcelGetWorksheetNamesHandle = null, Expression<Func<string>> mSExcelGetWorksheetNamesWorkbookName = null)
        {
            var apiCallPath = "/MSExcel/GetWorksheetNames";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelGetWorksheetNames = new JObject();
            var mSExcelGetWorksheetNamespropCount = 0;
            if (mSExcelGetWorksheetNamesHandle != null)
            {
                mSExcelGetWorksheetNames["Handle"] = ExpressionConverter.ConvertO(mSExcelGetWorksheetNamesHandle);
                mSExcelGetWorksheetNamespropCount++;
            }

            if (mSExcelGetWorksheetNamesWorkbookName != null)
            {
                mSExcelGetWorksheetNames["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelGetWorksheetNamesWorkbookName);
                mSExcelGetWorksheetNamespropCount++;
            }

            mSExcelGetWorksheetNamespropCount++;
            mSExcelGetWorksheetNames["Workflow"] = ExpressionConverter.ConvertO(mSExcelGetWorksheetNamesWorkflow);
            if (mSExcelGetWorksheetNamespropCount > 0)
            {
                callPayload.Body = mSExcelGetWorksheetNames;
            }

            return new ApiConnectionAction<MSExcelGetWorksheetNamesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetWorksheetNameResponse> MSExcelGetWorksheetName(Expression<Func<string>> mSExcelGetWorksheetNameWorkflow, Expression<Func<int>> mSExcelGetWorksheetNameHandle = null, Expression<Func<string>> mSExcelGetWorksheetNameWorkbookName = null, Expression<Func<int>> mSExcelGetWorksheetNamePosition = null)
        {
            var apiCallPath = "/MSExcel/GetWorksheetName";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelGetWorksheetName = new JObject();
            var mSExcelGetWorksheetNamepropCount = 0;
            if (mSExcelGetWorksheetNameHandle != null)
            {
                mSExcelGetWorksheetName["Handle"] = ExpressionConverter.ConvertO(mSExcelGetWorksheetNameHandle);
                mSExcelGetWorksheetNamepropCount++;
            }

            if (mSExcelGetWorksheetNameWorkbookName != null)
            {
                mSExcelGetWorksheetName["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelGetWorksheetNameWorkbookName);
                mSExcelGetWorksheetNamepropCount++;
            }

            if (mSExcelGetWorksheetNamePosition != null)
            {
                mSExcelGetWorksheetName["Position"] = ExpressionConverter.ConvertO(mSExcelGetWorksheetNamePosition);
                mSExcelGetWorksheetNamepropCount++;
            }

            mSExcelGetWorksheetNamepropCount++;
            mSExcelGetWorksheetName["Workflow"] = ExpressionConverter.ConvertO(mSExcelGetWorksheetNameWorkflow);
            if (mSExcelGetWorksheetNamepropCount > 0)
            {
                callPayload.Body = mSExcelGetWorksheetName;
            }

            return new ApiConnectionAction<MSExcelGetWorksheetNameResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelActivateWorksheet(Expression<Func<string>> mSExcelActivateWorksheetWorkflow, Expression<Func<int>> mSExcelActivateWorksheetHandle = null, Expression<Func<string>> mSExcelActivateWorksheetWorkbookName = null, Expression<Func<string>> mSExcelActivateWorksheetWorksheetName = null, Expression<Func<bool>> mSExcelActivateWorksheetCreateIfMissing = null)
        {
            var apiCallPath = "/MSExcel/ActivateWorksheet";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelActivateWorksheet = new JObject();
            var mSExcelActivateWorksheetpropCount = 0;
            if (mSExcelActivateWorksheetHandle != null)
            {
                mSExcelActivateWorksheet["Handle"] = ExpressionConverter.ConvertO(mSExcelActivateWorksheetHandle);
                mSExcelActivateWorksheetpropCount++;
            }

            if (mSExcelActivateWorksheetWorkbookName != null)
            {
                mSExcelActivateWorksheet["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelActivateWorksheetWorkbookName);
                mSExcelActivateWorksheetpropCount++;
            }

            if (mSExcelActivateWorksheetWorksheetName != null)
            {
                mSExcelActivateWorksheet["WorksheetName"] = ExpressionConverter.ConvertO(mSExcelActivateWorksheetWorksheetName);
                mSExcelActivateWorksheetpropCount++;
            }

            if (mSExcelActivateWorksheetCreateIfMissing != null)
            {
                mSExcelActivateWorksheet["CreateIfMissing"] = ExpressionConverter.ConvertO(mSExcelActivateWorksheetCreateIfMissing);
                mSExcelActivateWorksheetpropCount++;
            }

            mSExcelActivateWorksheetpropCount++;
            mSExcelActivateWorksheet["Workflow"] = ExpressionConverter.ConvertO(mSExcelActivateWorksheetWorkflow);
            if (mSExcelActivateWorksheetpropCount > 0)
            {
                callPayload.Body = mSExcelActivateWorksheet;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelCreateWorksheet(Expression<Func<string>> mSExcelCreateWorksheetWorkflow, Expression<Func<int>> mSExcelCreateWorksheetHandle = null, Expression<Func<string>> mSExcelCreateWorksheetWorkbookName = null, Expression<Func<string>> mSExcelCreateWorksheetWorksheetName = null)
        {
            var apiCallPath = "/MSExcel/CreateWorksheet";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelCreateWorksheet = new JObject();
            var mSExcelCreateWorksheetpropCount = 0;
            if (mSExcelCreateWorksheetHandle != null)
            {
                mSExcelCreateWorksheet["Handle"] = ExpressionConverter.ConvertO(mSExcelCreateWorksheetHandle);
                mSExcelCreateWorksheetpropCount++;
            }

            if (mSExcelCreateWorksheetWorkbookName != null)
            {
                mSExcelCreateWorksheet["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelCreateWorksheetWorkbookName);
                mSExcelCreateWorksheetpropCount++;
            }

            if (mSExcelCreateWorksheetWorksheetName != null)
            {
                mSExcelCreateWorksheet["WorksheetName"] = ExpressionConverter.ConvertO(mSExcelCreateWorksheetWorksheetName);
                mSExcelCreateWorksheetpropCount++;
            }

            mSExcelCreateWorksheetpropCount++;
            mSExcelCreateWorksheet["Workflow"] = ExpressionConverter.ConvertO(mSExcelCreateWorksheetWorkflow);
            if (mSExcelCreateWorksheetpropCount > 0)
            {
                callPayload.Body = mSExcelCreateWorksheet;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelDeleteWorksheet(Expression<Func<string>> mSExcelDeleteWorksheetWorkflow, Expression<Func<int>> mSExcelDeleteWorksheetHandle = null, Expression<Func<string>> mSExcelDeleteWorksheetWorkbookName = null, Expression<Func<string>> mSExcelDeleteWorksheetWorksheetName = null)
        {
            var apiCallPath = "/MSExcel/DeleteWorksheet";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelDeleteWorksheet = new JObject();
            var mSExcelDeleteWorksheetpropCount = 0;
            if (mSExcelDeleteWorksheetHandle != null)
            {
                mSExcelDeleteWorksheet["Handle"] = ExpressionConverter.ConvertO(mSExcelDeleteWorksheetHandle);
                mSExcelDeleteWorksheetpropCount++;
            }

            if (mSExcelDeleteWorksheetWorkbookName != null)
            {
                mSExcelDeleteWorksheet["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelDeleteWorksheetWorkbookName);
                mSExcelDeleteWorksheetpropCount++;
            }

            if (mSExcelDeleteWorksheetWorksheetName != null)
            {
                mSExcelDeleteWorksheet["WorksheetName"] = ExpressionConverter.ConvertO(mSExcelDeleteWorksheetWorksheetName);
                mSExcelDeleteWorksheetpropCount++;
            }

            mSExcelDeleteWorksheetpropCount++;
            mSExcelDeleteWorksheet["Workflow"] = ExpressionConverter.ConvertO(mSExcelDeleteWorksheetWorkflow);
            if (mSExcelDeleteWorksheetpropCount > 0)
            {
                callPayload.Body = mSExcelDeleteWorksheet;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetWorksheetAsCollectionEnhancedResponse> MSExcelGetWorksheetAsCollectionEnhanced(Expression<Func<string>> mSExcelGetWorksheetAsCollectionEnhancedWorkflow, Expression<Func<int>> mSExcelGetWorksheetAsCollectionEnhancedHandle = null, Expression<Func<string>> mSExcelGetWorksheetAsCollectionEnhancedWorkbookName = null, Expression<Func<string>> mSExcelGetWorksheetAsCollectionEnhancedWorksheetName = null, Expression<Func<bool>> mSExcelGetWorksheetAsCollectionEnhancedUseHeader = null, Expression<Func<string>> mSExcelGetWorksheetAsCollectionEnhancedStartCell = null, Expression<Func<int>> mSExcelGetWorksheetAsCollectionEnhancedMaximumColumnNumber = null, Expression<Func<bool>> mSExcelGetWorksheetAsCollectionEnhancedSkipBlankRows = null, Expression<Func<bool>> mSExcelGetWorksheetAsCollectionEnhancedSkipColumnsWithNoHeader = null, Expression<Func<string>> mSExcelGetWorksheetAsCollectionEnhancedKeyColumn = null, Expression<Func<bool>> mSExcelGetWorksheetAsCollectionEnhancedGetRawData = null, Expression<Func<int>> mSExcelGetWorksheetAsCollectionEnhancedIgnoreRowsWithLowCellCount = null, Expression<Func<int>> mSExcelGetWorksheetAsCollectionEnhancedMaxConcurrentBlankRows = null, Expression<Func<int>> mSExcelGetWorksheetAsCollectionEnhancedFirstDataRowToReturn = null, Expression<Func<int>> mSExcelGetWorksheetAsCollectionEnhancedMaxNumberOfDataRowsToReturn = null)
        {
            var apiCallPath = "/MSExcel/GetWorksheetAsCollectionEnhanced";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelGetWorksheetAsCollectionEnhanced = new JObject();
            var mSExcelGetWorksheetAsCollectionEnhancedpropCount = 0;
            if (mSExcelGetWorksheetAsCollectionEnhancedHandle != null)
            {
                mSExcelGetWorksheetAsCollectionEnhanced["Handle"] = ExpressionConverter.ConvertO(mSExcelGetWorksheetAsCollectionEnhancedHandle);
                mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
            }

            if (mSExcelGetWorksheetAsCollectionEnhancedWorkbookName != null)
            {
                mSExcelGetWorksheetAsCollectionEnhanced["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelGetWorksheetAsCollectionEnhancedWorkbookName);
                mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
            }

            if (mSExcelGetWorksheetAsCollectionEnhancedWorksheetName != null)
            {
                mSExcelGetWorksheetAsCollectionEnhanced["WorksheetName"] = ExpressionConverter.ConvertO(mSExcelGetWorksheetAsCollectionEnhancedWorksheetName);
                mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
            }

            if (mSExcelGetWorksheetAsCollectionEnhancedUseHeader != null)
            {
                mSExcelGetWorksheetAsCollectionEnhanced["UseHeader"] = ExpressionConverter.ConvertO(mSExcelGetWorksheetAsCollectionEnhancedUseHeader);
                mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
            }

            if (mSExcelGetWorksheetAsCollectionEnhancedStartCell != null)
            {
                mSExcelGetWorksheetAsCollectionEnhanced["StartCell"] = ExpressionConverter.ConvertO(mSExcelGetWorksheetAsCollectionEnhancedStartCell);
                mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
            }

            if (mSExcelGetWorksheetAsCollectionEnhancedMaximumColumnNumber != null)
            {
                mSExcelGetWorksheetAsCollectionEnhanced["MaximumColumnNumber"] = ExpressionConverter.ConvertO(mSExcelGetWorksheetAsCollectionEnhancedMaximumColumnNumber);
                mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
            }

            if (mSExcelGetWorksheetAsCollectionEnhancedSkipBlankRows != null)
            {
                mSExcelGetWorksheetAsCollectionEnhanced["SkipBlankRows"] = ExpressionConverter.ConvertO(mSExcelGetWorksheetAsCollectionEnhancedSkipBlankRows);
                mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
            }

            if (mSExcelGetWorksheetAsCollectionEnhancedSkipColumnsWithNoHeader != null)
            {
                mSExcelGetWorksheetAsCollectionEnhanced["SkipColumnsWithNoHeader"] = ExpressionConverter.ConvertO(mSExcelGetWorksheetAsCollectionEnhancedSkipColumnsWithNoHeader);
                mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
            }

            if (mSExcelGetWorksheetAsCollectionEnhancedKeyColumn != null)
            {
                mSExcelGetWorksheetAsCollectionEnhanced["KeyColumn"] = ExpressionConverter.ConvertO(mSExcelGetWorksheetAsCollectionEnhancedKeyColumn);
                mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
            }

            if (mSExcelGetWorksheetAsCollectionEnhancedGetRawData != null)
            {
                mSExcelGetWorksheetAsCollectionEnhanced["GetRawData"] = ExpressionConverter.ConvertO(mSExcelGetWorksheetAsCollectionEnhancedGetRawData);
                mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
            }

            if (mSExcelGetWorksheetAsCollectionEnhancedIgnoreRowsWithLowCellCount != null)
            {
                mSExcelGetWorksheetAsCollectionEnhanced["IgnoreRowsWithLowCellCount"] = ExpressionConverter.ConvertO(mSExcelGetWorksheetAsCollectionEnhancedIgnoreRowsWithLowCellCount);
                mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
            }

            if (mSExcelGetWorksheetAsCollectionEnhancedMaxConcurrentBlankRows != null)
            {
                mSExcelGetWorksheetAsCollectionEnhanced["MaxConcurrentBlankRows"] = ExpressionConverter.ConvertO(mSExcelGetWorksheetAsCollectionEnhancedMaxConcurrentBlankRows);
                mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
            }

            if (mSExcelGetWorksheetAsCollectionEnhancedFirstDataRowToReturn != null)
            {
                mSExcelGetWorksheetAsCollectionEnhanced["FirstDataRowToReturn"] = ExpressionConverter.ConvertO(mSExcelGetWorksheetAsCollectionEnhancedFirstDataRowToReturn);
                mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
            }

            if (mSExcelGetWorksheetAsCollectionEnhancedMaxNumberOfDataRowsToReturn != null)
            {
                mSExcelGetWorksheetAsCollectionEnhanced["MaxNumberOfDataRowsToReturn"] = ExpressionConverter.ConvertO(mSExcelGetWorksheetAsCollectionEnhancedMaxNumberOfDataRowsToReturn);
                mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
            }

            mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
            mSExcelGetWorksheetAsCollectionEnhanced["Workflow"] = ExpressionConverter.ConvertO(mSExcelGetWorksheetAsCollectionEnhancedWorkflow);
            if (mSExcelGetWorksheetAsCollectionEnhancedpropCount > 0)
            {
                callPayload.Body = mSExcelGetWorksheetAsCollectionEnhanced;
            }

            return new ApiConnectionAction<MSExcelGetWorksheetAsCollectionEnhancedResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetNumberOfRowsResponse> MSExcelGetNumberOfRows(Expression<Func<string>> mSExcelGetNumberOfRowsWorkflow, Expression<Func<int>> mSExcelGetNumberOfRowsHandle = null, Expression<Func<string>> mSExcelGetNumberOfRowsWorkbookName = null, Expression<Func<string>> mSExcelGetNumberOfRowsWorksheetName = null)
        {
            var apiCallPath = "/MSExcel/GetNumberOfRows";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelGetNumberOfRows = new JObject();
            var mSExcelGetNumberOfRowspropCount = 0;
            if (mSExcelGetNumberOfRowsHandle != null)
            {
                mSExcelGetNumberOfRows["Handle"] = ExpressionConverter.ConvertO(mSExcelGetNumberOfRowsHandle);
                mSExcelGetNumberOfRowspropCount++;
            }

            if (mSExcelGetNumberOfRowsWorkbookName != null)
            {
                mSExcelGetNumberOfRows["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelGetNumberOfRowsWorkbookName);
                mSExcelGetNumberOfRowspropCount++;
            }

            if (mSExcelGetNumberOfRowsWorksheetName != null)
            {
                mSExcelGetNumberOfRows["WorksheetName"] = ExpressionConverter.ConvertO(mSExcelGetNumberOfRowsWorksheetName);
                mSExcelGetNumberOfRowspropCount++;
            }

            mSExcelGetNumberOfRowspropCount++;
            mSExcelGetNumberOfRows["Workflow"] = ExpressionConverter.ConvertO(mSExcelGetNumberOfRowsWorkflow);
            if (mSExcelGetNumberOfRowspropCount > 0)
            {
                callPayload.Body = mSExcelGetNumberOfRows;
            }

            return new ApiConnectionAction<MSExcelGetNumberOfRowsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelEvaluateExpressionResponse> MSExcelEvaluateExpression(Expression<Func<string>> mSExcelEvaluateExpressionExpression, Expression<Func<string>> mSExcelEvaluateExpressionWorkflow, Expression<Func<int>> mSExcelEvaluateExpressionHandle = null)
        {
            var apiCallPath = "/MSExcel/EvaluateExpression";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelEvaluateExpression = new JObject();
            var mSExcelEvaluateExpressionpropCount = 0;
            if (mSExcelEvaluateExpressionHandle != null)
            {
                mSExcelEvaluateExpression["Handle"] = ExpressionConverter.ConvertO(mSExcelEvaluateExpressionHandle);
                mSExcelEvaluateExpressionpropCount++;
            }

            mSExcelEvaluateExpressionpropCount++;
            mSExcelEvaluateExpression["Expression"] = ExpressionConverter.ConvertO(mSExcelEvaluateExpressionExpression);
            mSExcelEvaluateExpressionpropCount++;
            mSExcelEvaluateExpression["Workflow"] = ExpressionConverter.ConvertO(mSExcelEvaluateExpressionWorkflow);
            if (mSExcelEvaluateExpressionpropCount > 0)
            {
                callPayload.Body = mSExcelEvaluateExpression;
            }

            return new ApiConnectionAction<MSExcelEvaluateExpressionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetWorksheetUsedRangeResponse> MSExcelGetWorksheetUsedRange(Expression<Func<string>> mSExcelGetWorksheetUsedRangeWorkflow, Expression<Func<int>> mSExcelGetWorksheetUsedRangeHandle = null, Expression<Func<string>> mSExcelGetWorksheetUsedRangeWorkbookName = null, Expression<Func<string>> mSExcelGetWorksheetUsedRangeWorksheetName = null)
        {
            var apiCallPath = "/MSExcel/GetWorksheetUsedRange";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelGetWorksheetUsedRange = new JObject();
            var mSExcelGetWorksheetUsedRangepropCount = 0;
            if (mSExcelGetWorksheetUsedRangeHandle != null)
            {
                mSExcelGetWorksheetUsedRange["Handle"] = ExpressionConverter.ConvertO(mSExcelGetWorksheetUsedRangeHandle);
                mSExcelGetWorksheetUsedRangepropCount++;
            }

            if (mSExcelGetWorksheetUsedRangeWorkbookName != null)
            {
                mSExcelGetWorksheetUsedRange["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelGetWorksheetUsedRangeWorkbookName);
                mSExcelGetWorksheetUsedRangepropCount++;
            }

            if (mSExcelGetWorksheetUsedRangeWorksheetName != null)
            {
                mSExcelGetWorksheetUsedRange["WorksheetName"] = ExpressionConverter.ConvertO(mSExcelGetWorksheetUsedRangeWorksheetName);
                mSExcelGetWorksheetUsedRangepropCount++;
            }

            mSExcelGetWorksheetUsedRangepropCount++;
            mSExcelGetWorksheetUsedRange["Workflow"] = ExpressionConverter.ConvertO(mSExcelGetWorksheetUsedRangeWorkflow);
            if (mSExcelGetWorksheetUsedRangepropCount > 0)
            {
                callPayload.Body = mSExcelGetWorksheetUsedRange;
            }

            return new ApiConnectionAction<MSExcelGetWorksheetUsedRangeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetCountrySettingResponse> MSExcelGetCountrySetting(Expression<Func<string>> mSExcelGetCountrySettingWorkflow, Expression<Func<int>> mSExcelGetCountrySettingHandle = null)
        {
            var apiCallPath = "/MSExcel/GetCountrySetting";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelGetCountrySetting = new JObject();
            var mSExcelGetCountrySettingpropCount = 0;
            if (mSExcelGetCountrySettingHandle != null)
            {
                mSExcelGetCountrySetting["Handle"] = ExpressionConverter.ConvertO(mSExcelGetCountrySettingHandle);
                mSExcelGetCountrySettingpropCount++;
            }

            mSExcelGetCountrySettingpropCount++;
            mSExcelGetCountrySetting["Workflow"] = ExpressionConverter.ConvertO(mSExcelGetCountrySettingWorkflow);
            if (mSExcelGetCountrySettingpropCount > 0)
            {
                callPayload.Body = mSExcelGetCountrySetting;
            }

            return new ApiConnectionAction<MSExcelGetCountrySettingResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelWriteCollection(Expression<Func<string>> mSExcelWriteCollectionCellReference, Expression<Func<string>> mSExcelWriteCollectionCollectionToWriteJSON, Expression<Func<string>> mSExcelWriteCollectionWorkflow, Expression<Func<int>> mSExcelWriteCollectionHandle = null, Expression<Func<string>> mSExcelWriteCollectionWorkbookName = null, Expression<Func<string>> mSExcelWriteCollectionWorksheetName = null, Expression<Func<bool>> mSExcelWriteCollectionIncludeColumnNames = null)
        {
            var apiCallPath = "/MSExcel/WriteCollection";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelWriteCollection = new JObject();
            var mSExcelWriteCollectionpropCount = 0;
            if (mSExcelWriteCollectionHandle != null)
            {
                mSExcelWriteCollection["Handle"] = ExpressionConverter.ConvertO(mSExcelWriteCollectionHandle);
                mSExcelWriteCollectionpropCount++;
            }

            if (mSExcelWriteCollectionWorkbookName != null)
            {
                mSExcelWriteCollection["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelWriteCollectionWorkbookName);
                mSExcelWriteCollectionpropCount++;
            }

            if (mSExcelWriteCollectionWorksheetName != null)
            {
                mSExcelWriteCollection["WorksheetName"] = ExpressionConverter.ConvertO(mSExcelWriteCollectionWorksheetName);
                mSExcelWriteCollectionpropCount++;
            }

            mSExcelWriteCollectionpropCount++;
            mSExcelWriteCollection["CellReference"] = ExpressionConverter.ConvertO(mSExcelWriteCollectionCellReference);
            mSExcelWriteCollectionpropCount++;
            mSExcelWriteCollection["CollectionToWriteJSON"] = ExpressionConverter.ConvertO(mSExcelWriteCollectionCollectionToWriteJSON);
            if (mSExcelWriteCollectionIncludeColumnNames != null)
            {
                mSExcelWriteCollection["IncludeColumnNames"] = ExpressionConverter.ConvertO(mSExcelWriteCollectionIncludeColumnNames);
                mSExcelWriteCollectionpropCount++;
            }

            mSExcelWriteCollectionpropCount++;
            mSExcelWriteCollection["Workflow"] = ExpressionConverter.ConvertO(mSExcelWriteCollectionWorkflow);
            if (mSExcelWriteCollectionpropCount > 0)
            {
                callPayload.Body = mSExcelWriteCollection;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelWriteCollectionWithDates(Expression<Func<string>> mSExcelWriteCollectionWithDatesCellReference, Expression<Func<string>> mSExcelWriteCollectionWithDatesCollectionToWriteJSON, Expression<Func<string>> mSExcelWriteCollectionWithDatesWorkflow, Expression<Func<int>> mSExcelWriteCollectionWithDatesHandle = null, Expression<Func<string>> mSExcelWriteCollectionWithDatesWorkbookName = null, Expression<Func<string>> mSExcelWriteCollectionWithDatesWorksheetName = null, Expression<Func<bool>> mSExcelWriteCollectionWithDatesIncludeColumnNames = null, Expression<Func<bool>> mSExcelWriteCollectionWithDatesTryToConvertAllFieldsToDate = null, Expression<Func<string>> mSExcelWriteCollectionWithDatesColumnsToConvertToDateJSON = null)
        {
            var apiCallPath = "/MSExcel/WriteCollectionWithDates";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelWriteCollectionWithDates = new JObject();
            var mSExcelWriteCollectionWithDatespropCount = 0;
            if (mSExcelWriteCollectionWithDatesHandle != null)
            {
                mSExcelWriteCollectionWithDates["Handle"] = ExpressionConverter.ConvertO(mSExcelWriteCollectionWithDatesHandle);
                mSExcelWriteCollectionWithDatespropCount++;
            }

            if (mSExcelWriteCollectionWithDatesWorkbookName != null)
            {
                mSExcelWriteCollectionWithDates["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelWriteCollectionWithDatesWorkbookName);
                mSExcelWriteCollectionWithDatespropCount++;
            }

            if (mSExcelWriteCollectionWithDatesWorksheetName != null)
            {
                mSExcelWriteCollectionWithDates["WorksheetName"] = ExpressionConverter.ConvertO(mSExcelWriteCollectionWithDatesWorksheetName);
                mSExcelWriteCollectionWithDatespropCount++;
            }

            mSExcelWriteCollectionWithDatespropCount++;
            mSExcelWriteCollectionWithDates["CellReference"] = ExpressionConverter.ConvertO(mSExcelWriteCollectionWithDatesCellReference);
            mSExcelWriteCollectionWithDatespropCount++;
            mSExcelWriteCollectionWithDates["CollectionToWriteJSON"] = ExpressionConverter.ConvertO(mSExcelWriteCollectionWithDatesCollectionToWriteJSON);
            if (mSExcelWriteCollectionWithDatesIncludeColumnNames != null)
            {
                mSExcelWriteCollectionWithDates["IncludeColumnNames"] = ExpressionConverter.ConvertO(mSExcelWriteCollectionWithDatesIncludeColumnNames);
                mSExcelWriteCollectionWithDatespropCount++;
            }

            if (mSExcelWriteCollectionWithDatesTryToConvertAllFieldsToDate != null)
            {
                mSExcelWriteCollectionWithDates["TryToConvertAllFieldsToDate"] = ExpressionConverter.ConvertO(mSExcelWriteCollectionWithDatesTryToConvertAllFieldsToDate);
                mSExcelWriteCollectionWithDatespropCount++;
            }

            if (mSExcelWriteCollectionWithDatesColumnsToConvertToDateJSON != null)
            {
                mSExcelWriteCollectionWithDates["ColumnsToConvertToDateJSON"] = ExpressionConverter.ConvertO(mSExcelWriteCollectionWithDatesColumnsToConvertToDateJSON);
                mSExcelWriteCollectionWithDatespropCount++;
            }

            mSExcelWriteCollectionWithDatespropCount++;
            mSExcelWriteCollectionWithDates["Workflow"] = ExpressionConverter.ConvertO(mSExcelWriteCollectionWithDatesWorkflow);
            if (mSExcelWriteCollectionWithDatespropCount > 0)
            {
                callPayload.Body = mSExcelWriteCollectionWithDates;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetActiveCellResponse> MSExcelGetActiveCell(Expression<Func<string>> mSExcelGetActiveCellWorkflow, Expression<Func<int>> mSExcelGetActiveCellHandle = null)
        {
            var apiCallPath = "/MSExcel/GetActiveCell";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelGetActiveCell = new JObject();
            var mSExcelGetActiveCellpropCount = 0;
            if (mSExcelGetActiveCellHandle != null)
            {
                mSExcelGetActiveCell["Handle"] = ExpressionConverter.ConvertO(mSExcelGetActiveCellHandle);
                mSExcelGetActiveCellpropCount++;
            }

            mSExcelGetActiveCellpropCount++;
            mSExcelGetActiveCell["Workflow"] = ExpressionConverter.ConvertO(mSExcelGetActiveCellWorkflow);
            if (mSExcelGetActiveCellpropCount > 0)
            {
                callPayload.Body = mSExcelGetActiveCell;
            }

            return new ApiConnectionAction<MSExcelGetActiveCellResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelFormatCell(Expression<Func<string>> mSExcelFormatCellCellReference, Expression<Func<string>> mSExcelFormatCellCellFormat, Expression<Func<string>> mSExcelFormatCellWorkflow, Expression<Func<int>> mSExcelFormatCellHandle = null, Expression<Func<string>> mSExcelFormatCellWorkbookName = null, Expression<Func<string>> mSExcelFormatCellWorksheetName = null)
        {
            var apiCallPath = "/MSExcel/FormatCell";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelFormatCell = new JObject();
            var mSExcelFormatCellpropCount = 0;
            if (mSExcelFormatCellHandle != null)
            {
                mSExcelFormatCell["Handle"] = ExpressionConverter.ConvertO(mSExcelFormatCellHandle);
                mSExcelFormatCellpropCount++;
            }

            if (mSExcelFormatCellWorkbookName != null)
            {
                mSExcelFormatCell["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelFormatCellWorkbookName);
                mSExcelFormatCellpropCount++;
            }

            if (mSExcelFormatCellWorksheetName != null)
            {
                mSExcelFormatCell["WorksheetName"] = ExpressionConverter.ConvertO(mSExcelFormatCellWorksheetName);
                mSExcelFormatCellpropCount++;
            }

            mSExcelFormatCellpropCount++;
            mSExcelFormatCell["CellReference"] = ExpressionConverter.ConvertO(mSExcelFormatCellCellReference);
            mSExcelFormatCellpropCount++;
            mSExcelFormatCell["CellFormat"] = ExpressionConverter.ConvertO(mSExcelFormatCellCellFormat);
            mSExcelFormatCellpropCount++;
            mSExcelFormatCell["Workflow"] = ExpressionConverter.ConvertO(mSExcelFormatCellWorkflow);
            if (mSExcelFormatCellpropCount > 0)
            {
                callPayload.Body = mSExcelFormatCell;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelFormatCurrentCell(Expression<Func<string>> mSExcelFormatCurrentCellCellFormat, Expression<Func<string>> mSExcelFormatCurrentCellWorkflow, Expression<Func<int>> mSExcelFormatCurrentCellHandle = null)
        {
            var apiCallPath = "/MSExcel/FormatCurrentCell";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelFormatCurrentCell = new JObject();
            var mSExcelFormatCurrentCellpropCount = 0;
            if (mSExcelFormatCurrentCellHandle != null)
            {
                mSExcelFormatCurrentCell["Handle"] = ExpressionConverter.ConvertO(mSExcelFormatCurrentCellHandle);
                mSExcelFormatCurrentCellpropCount++;
            }

            mSExcelFormatCurrentCellpropCount++;
            mSExcelFormatCurrentCell["CellFormat"] = ExpressionConverter.ConvertO(mSExcelFormatCurrentCellCellFormat);
            mSExcelFormatCurrentCellpropCount++;
            mSExcelFormatCurrentCell["Workflow"] = ExpressionConverter.ConvertO(mSExcelFormatCurrentCellWorkflow);
            if (mSExcelFormatCurrentCellpropCount > 0)
            {
                callPayload.Body = mSExcelFormatCurrentCell;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelSelectCellRange(Expression<Func<string>> mSExcelSelectCellRangeCellReference, Expression<Func<string>> mSExcelSelectCellRangeWorkflow, Expression<Func<int>> mSExcelSelectCellRangeHandle = null, Expression<Func<string>> mSExcelSelectCellRangeWorkbookName = null, Expression<Func<string>> mSExcelSelectCellRangeWorksheetName = null, Expression<Func<bool>> mSExcelSelectCellRangeEntireRow = null, Expression<Func<bool>> mSExcelSelectCellRangeEntireColumn = null)
        {
            var apiCallPath = "/MSExcel/SelectCellRange";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelSelectCellRange = new JObject();
            var mSExcelSelectCellRangepropCount = 0;
            if (mSExcelSelectCellRangeHandle != null)
            {
                mSExcelSelectCellRange["Handle"] = ExpressionConverter.ConvertO(mSExcelSelectCellRangeHandle);
                mSExcelSelectCellRangepropCount++;
            }

            if (mSExcelSelectCellRangeWorkbookName != null)
            {
                mSExcelSelectCellRange["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelSelectCellRangeWorkbookName);
                mSExcelSelectCellRangepropCount++;
            }

            if (mSExcelSelectCellRangeWorksheetName != null)
            {
                mSExcelSelectCellRange["WorksheetName"] = ExpressionConverter.ConvertO(mSExcelSelectCellRangeWorksheetName);
                mSExcelSelectCellRangepropCount++;
            }

            mSExcelSelectCellRangepropCount++;
            mSExcelSelectCellRange["CellReference"] = ExpressionConverter.ConvertO(mSExcelSelectCellRangeCellReference);
            if (mSExcelSelectCellRangeEntireRow != null)
            {
                mSExcelSelectCellRange["EntireRow"] = ExpressionConverter.ConvertO(mSExcelSelectCellRangeEntireRow);
                mSExcelSelectCellRangepropCount++;
            }

            if (mSExcelSelectCellRangeEntireColumn != null)
            {
                mSExcelSelectCellRange["EntireColumn"] = ExpressionConverter.ConvertO(mSExcelSelectCellRangeEntireColumn);
                mSExcelSelectCellRangepropCount++;
            }

            mSExcelSelectCellRangepropCount++;
            mSExcelSelectCellRange["Workflow"] = ExpressionConverter.ConvertO(mSExcelSelectCellRangeWorkflow);
            if (mSExcelSelectCellRangepropCount > 0)
            {
                callPayload.Body = mSExcelSelectCellRange;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelCopySelection(Expression<Func<string>> mSExcelCopySelectionWorkflow, Expression<Func<int>> mSExcelCopySelectionHandle = null, Expression<Func<string>> mSExcelCopySelectionWorkbookName = null, Expression<Func<string>> mSExcelCopySelectionWorksheetName = null, Expression<Func<string>> mSExcelCopySelectionCellReference = null, Expression<Func<bool>> mSExcelCopySelectionEntireRow = null, Expression<Func<bool>> mSExcelCopySelectionEntireColumn = null)
        {
            var apiCallPath = "/MSExcel/CopySelection";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelCopySelection = new JObject();
            var mSExcelCopySelectionpropCount = 0;
            if (mSExcelCopySelectionHandle != null)
            {
                mSExcelCopySelection["Handle"] = ExpressionConverter.ConvertO(mSExcelCopySelectionHandle);
                mSExcelCopySelectionpropCount++;
            }

            if (mSExcelCopySelectionWorkbookName != null)
            {
                mSExcelCopySelection["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelCopySelectionWorkbookName);
                mSExcelCopySelectionpropCount++;
            }

            if (mSExcelCopySelectionWorksheetName != null)
            {
                mSExcelCopySelection["WorksheetName"] = ExpressionConverter.ConvertO(mSExcelCopySelectionWorksheetName);
                mSExcelCopySelectionpropCount++;
            }

            if (mSExcelCopySelectionCellReference != null)
            {
                mSExcelCopySelection["CellReference"] = ExpressionConverter.ConvertO(mSExcelCopySelectionCellReference);
                mSExcelCopySelectionpropCount++;
            }

            if (mSExcelCopySelectionEntireRow != null)
            {
                mSExcelCopySelection["EntireRow"] = ExpressionConverter.ConvertO(mSExcelCopySelectionEntireRow);
                mSExcelCopySelectionpropCount++;
            }

            if (mSExcelCopySelectionEntireColumn != null)
            {
                mSExcelCopySelection["EntireColumn"] = ExpressionConverter.ConvertO(mSExcelCopySelectionEntireColumn);
                mSExcelCopySelectionpropCount++;
            }

            mSExcelCopySelectionpropCount++;
            mSExcelCopySelection["Workflow"] = ExpressionConverter.ConvertO(mSExcelCopySelectionWorkflow);
            if (mSExcelCopySelectionpropCount > 0)
            {
                callPayload.Body = mSExcelCopySelection;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelCutSelection(Expression<Func<string>> mSExcelCutSelectionWorkflow, Expression<Func<int>> mSExcelCutSelectionHandle = null, Expression<Func<string>> mSExcelCutSelectionWorkbookName = null, Expression<Func<string>> mSExcelCutSelectionWorksheetName = null, Expression<Func<string>> mSExcelCutSelectionCellReference = null, Expression<Func<bool>> mSExcelCutSelectionEntireRow = null, Expression<Func<bool>> mSExcelCutSelectionEntireColumn = null)
        {
            var apiCallPath = "/MSExcel/CutSelection";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelCutSelection = new JObject();
            var mSExcelCutSelectionpropCount = 0;
            if (mSExcelCutSelectionHandle != null)
            {
                mSExcelCutSelection["Handle"] = ExpressionConverter.ConvertO(mSExcelCutSelectionHandle);
                mSExcelCutSelectionpropCount++;
            }

            if (mSExcelCutSelectionWorkbookName != null)
            {
                mSExcelCutSelection["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelCutSelectionWorkbookName);
                mSExcelCutSelectionpropCount++;
            }

            if (mSExcelCutSelectionWorksheetName != null)
            {
                mSExcelCutSelection["WorksheetName"] = ExpressionConverter.ConvertO(mSExcelCutSelectionWorksheetName);
                mSExcelCutSelectionpropCount++;
            }

            if (mSExcelCutSelectionCellReference != null)
            {
                mSExcelCutSelection["CellReference"] = ExpressionConverter.ConvertO(mSExcelCutSelectionCellReference);
                mSExcelCutSelectionpropCount++;
            }

            if (mSExcelCutSelectionEntireRow != null)
            {
                mSExcelCutSelection["EntireRow"] = ExpressionConverter.ConvertO(mSExcelCutSelectionEntireRow);
                mSExcelCutSelectionpropCount++;
            }

            if (mSExcelCutSelectionEntireColumn != null)
            {
                mSExcelCutSelection["EntireColumn"] = ExpressionConverter.ConvertO(mSExcelCutSelectionEntireColumn);
                mSExcelCutSelectionpropCount++;
            }

            mSExcelCutSelectionpropCount++;
            mSExcelCutSelection["Workflow"] = ExpressionConverter.ConvertO(mSExcelCutSelectionWorkflow);
            if (mSExcelCutSelectionpropCount > 0)
            {
                callPayload.Body = mSExcelCutSelection;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelPasteIntoSelection(Expression<Func<string>> mSExcelPasteIntoSelectionWorkflow, Expression<Func<int>> mSExcelPasteIntoSelectionHandle = null, Expression<Func<string>> mSExcelPasteIntoSelectionWorkbookName = null, Expression<Func<string>> mSExcelPasteIntoSelectionWorksheetName = null, Expression<Func<bool>> mSExcelPasteIntoSelectionValuesOnly = null, Expression<Func<bool>> mSExcelPasteIntoSelectionSimplePasteOnly = null, Expression<Func<string>> mSExcelPasteIntoSelectionCellReference = null, Expression<Func<bool>> mSExcelPasteIntoSelectionEntireRow = null, Expression<Func<bool>> mSExcelPasteIntoSelectionEntireColumn = null)
        {
            var apiCallPath = "/MSExcel/PasteIntoSelection";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelPasteIntoSelection = new JObject();
            var mSExcelPasteIntoSelectionpropCount = 0;
            if (mSExcelPasteIntoSelectionHandle != null)
            {
                mSExcelPasteIntoSelection["Handle"] = ExpressionConverter.ConvertO(mSExcelPasteIntoSelectionHandle);
                mSExcelPasteIntoSelectionpropCount++;
            }

            if (mSExcelPasteIntoSelectionWorkbookName != null)
            {
                mSExcelPasteIntoSelection["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelPasteIntoSelectionWorkbookName);
                mSExcelPasteIntoSelectionpropCount++;
            }

            if (mSExcelPasteIntoSelectionWorksheetName != null)
            {
                mSExcelPasteIntoSelection["WorksheetName"] = ExpressionConverter.ConvertO(mSExcelPasteIntoSelectionWorksheetName);
                mSExcelPasteIntoSelectionpropCount++;
            }

            if (mSExcelPasteIntoSelectionValuesOnly != null)
            {
                mSExcelPasteIntoSelection["ValuesOnly"] = ExpressionConverter.ConvertO(mSExcelPasteIntoSelectionValuesOnly);
                mSExcelPasteIntoSelectionpropCount++;
            }

            if (mSExcelPasteIntoSelectionSimplePasteOnly != null)
            {
                mSExcelPasteIntoSelection["SimplePasteOnly"] = ExpressionConverter.ConvertO(mSExcelPasteIntoSelectionSimplePasteOnly);
                mSExcelPasteIntoSelectionpropCount++;
            }

            if (mSExcelPasteIntoSelectionCellReference != null)
            {
                mSExcelPasteIntoSelection["CellReference"] = ExpressionConverter.ConvertO(mSExcelPasteIntoSelectionCellReference);
                mSExcelPasteIntoSelectionpropCount++;
            }

            if (mSExcelPasteIntoSelectionEntireRow != null)
            {
                mSExcelPasteIntoSelection["EntireRow"] = ExpressionConverter.ConvertO(mSExcelPasteIntoSelectionEntireRow);
                mSExcelPasteIntoSelectionpropCount++;
            }

            if (mSExcelPasteIntoSelectionEntireColumn != null)
            {
                mSExcelPasteIntoSelection["EntireColumn"] = ExpressionConverter.ConvertO(mSExcelPasteIntoSelectionEntireColumn);
                mSExcelPasteIntoSelectionpropCount++;
            }

            mSExcelPasteIntoSelectionpropCount++;
            mSExcelPasteIntoSelection["Workflow"] = ExpressionConverter.ConvertO(mSExcelPasteIntoSelectionWorkflow);
            if (mSExcelPasteIntoSelectionpropCount > 0)
            {
                callPayload.Body = mSExcelPasteIntoSelection;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelInsertOnSelection(Expression<Func<string>> mSExcelInsertOnSelectionWorkflow, Expression<Func<int>> mSExcelInsertOnSelectionHandle = null, Expression<Func<string>> mSExcelInsertOnSelectionWorkbookName = null, Expression<Func<string>> mSExcelInsertOnSelectionWorksheetName = null, Expression<Func<string>> mSExcelInsertOnSelectionCellReference = null, Expression<Func<bool>> mSExcelInsertOnSelectionEntireRow = null, Expression<Func<bool>> mSExcelInsertOnSelectionEntireColumn = null, Expression<Func<mSExcelInsertOnSelectionShiftInput>> mSExcelInsertOnSelectionShift = null)
        {
            var apiCallPath = "/MSExcel/InsertOnSelection";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelInsertOnSelection = new JObject();
            var mSExcelInsertOnSelectionpropCount = 0;
            if (mSExcelInsertOnSelectionHandle != null)
            {
                mSExcelInsertOnSelection["Handle"] = ExpressionConverter.ConvertO(mSExcelInsertOnSelectionHandle);
                mSExcelInsertOnSelectionpropCount++;
            }

            if (mSExcelInsertOnSelectionWorkbookName != null)
            {
                mSExcelInsertOnSelection["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelInsertOnSelectionWorkbookName);
                mSExcelInsertOnSelectionpropCount++;
            }

            if (mSExcelInsertOnSelectionWorksheetName != null)
            {
                mSExcelInsertOnSelection["WorksheetName"] = ExpressionConverter.ConvertO(mSExcelInsertOnSelectionWorksheetName);
                mSExcelInsertOnSelectionpropCount++;
            }

            if (mSExcelInsertOnSelectionCellReference != null)
            {
                mSExcelInsertOnSelection["CellReference"] = ExpressionConverter.ConvertO(mSExcelInsertOnSelectionCellReference);
                mSExcelInsertOnSelectionpropCount++;
            }

            if (mSExcelInsertOnSelectionEntireRow != null)
            {
                mSExcelInsertOnSelection["EntireRow"] = ExpressionConverter.ConvertO(mSExcelInsertOnSelectionEntireRow);
                mSExcelInsertOnSelectionpropCount++;
            }

            if (mSExcelInsertOnSelectionEntireColumn != null)
            {
                mSExcelInsertOnSelection["EntireColumn"] = ExpressionConverter.ConvertO(mSExcelInsertOnSelectionEntireColumn);
                mSExcelInsertOnSelectionpropCount++;
            }

            if (mSExcelInsertOnSelectionShift != null)
            {
                mSExcelInsertOnSelection["Shift"] = ExpressionConverter.ConvertO(mSExcelInsertOnSelectionShift);
                mSExcelInsertOnSelectionpropCount++;
            }

            mSExcelInsertOnSelectionpropCount++;
            mSExcelInsertOnSelection["Workflow"] = ExpressionConverter.ConvertO(mSExcelInsertOnSelectionWorkflow);
            if (mSExcelInsertOnSelectionpropCount > 0)
            {
                callPayload.Body = mSExcelInsertOnSelection;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelDeleteSelection(Expression<Func<string>> mSExcelDeleteSelectionWorkflow, Expression<Func<int>> mSExcelDeleteSelectionHandle = null, Expression<Func<string>> mSExcelDeleteSelectionWorkbookName = null, Expression<Func<string>> mSExcelDeleteSelectionWorksheetName = null, Expression<Func<string>> mSExcelDeleteSelectionCellReference = null, Expression<Func<bool>> mSExcelDeleteSelectionEntireRow = null, Expression<Func<bool>> mSExcelDeleteSelectionEntireColumn = null, Expression<Func<mSExcelDeleteSelectionShiftInput>> mSExcelDeleteSelectionShift = null)
        {
            var apiCallPath = "/MSExcel/DeleteSelection";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelDeleteSelection = new JObject();
            var mSExcelDeleteSelectionpropCount = 0;
            if (mSExcelDeleteSelectionHandle != null)
            {
                mSExcelDeleteSelection["Handle"] = ExpressionConverter.ConvertO(mSExcelDeleteSelectionHandle);
                mSExcelDeleteSelectionpropCount++;
            }

            if (mSExcelDeleteSelectionWorkbookName != null)
            {
                mSExcelDeleteSelection["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelDeleteSelectionWorkbookName);
                mSExcelDeleteSelectionpropCount++;
            }

            if (mSExcelDeleteSelectionWorksheetName != null)
            {
                mSExcelDeleteSelection["WorksheetName"] = ExpressionConverter.ConvertO(mSExcelDeleteSelectionWorksheetName);
                mSExcelDeleteSelectionpropCount++;
            }

            if (mSExcelDeleteSelectionCellReference != null)
            {
                mSExcelDeleteSelection["CellReference"] = ExpressionConverter.ConvertO(mSExcelDeleteSelectionCellReference);
                mSExcelDeleteSelectionpropCount++;
            }

            if (mSExcelDeleteSelectionEntireRow != null)
            {
                mSExcelDeleteSelection["EntireRow"] = ExpressionConverter.ConvertO(mSExcelDeleteSelectionEntireRow);
                mSExcelDeleteSelectionpropCount++;
            }

            if (mSExcelDeleteSelectionEntireColumn != null)
            {
                mSExcelDeleteSelection["EntireColumn"] = ExpressionConverter.ConvertO(mSExcelDeleteSelectionEntireColumn);
                mSExcelDeleteSelectionpropCount++;
            }

            if (mSExcelDeleteSelectionShift != null)
            {
                mSExcelDeleteSelection["Shift"] = ExpressionConverter.ConvertO(mSExcelDeleteSelectionShift);
                mSExcelDeleteSelectionpropCount++;
            }

            mSExcelDeleteSelectionpropCount++;
            mSExcelDeleteSelection["Workflow"] = ExpressionConverter.ConvertO(mSExcelDeleteSelectionWorkflow);
            if (mSExcelDeleteSelectionpropCount > 0)
            {
                callPayload.Body = mSExcelDeleteSelection;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelClearExcelClipboard(Expression<Func<string>> mSExcelClearExcelClipboardWorkflow, Expression<Func<int>> mSExcelClearExcelClipboardHandle = null)
        {
            var apiCallPath = "/MSExcel/ClearExcelClipboard";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelClearExcelClipboard = new JObject();
            var mSExcelClearExcelClipboardpropCount = 0;
            if (mSExcelClearExcelClipboardHandle != null)
            {
                mSExcelClearExcelClipboard["Handle"] = ExpressionConverter.ConvertO(mSExcelClearExcelClipboardHandle);
                mSExcelClearExcelClipboardpropCount++;
            }

            mSExcelClearExcelClipboardpropCount++;
            mSExcelClearExcelClipboard["Workflow"] = ExpressionConverter.ConvertO(mSExcelClearExcelClipboardWorkflow);
            if (mSExcelClearExcelClipboardpropCount > 0)
            {
                callPayload.Body = mSExcelClearExcelClipboard;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelRunMacroResponse> MSExcelRunMacro(Expression<Func<string>> mSExcelRunMacroMacroName, Expression<Func<string>> mSExcelRunMacroWorkflow, Expression<Func<int>> mSExcelRunMacroHandle = null, Expression<Func<int>> mSExcelRunMacroNumberOfArguments = null, Expression<Func<string>> mSExcelRunMacroArgument1 = null, Expression<Func<string>> mSExcelRunMacroArgument2 = null, Expression<Func<string>> mSExcelRunMacroArgument3 = null, Expression<Func<string>> mSExcelRunMacroArgument4 = null, Expression<Func<string>> mSExcelRunMacroArgument5 = null, Expression<Func<string>> mSExcelRunMacroArgument6 = null, Expression<Func<string>> mSExcelRunMacroArgument7 = null, Expression<Func<string>> mSExcelRunMacroArgument8 = null, Expression<Func<string>> mSExcelRunMacroArgument9 = null, Expression<Func<string>> mSExcelRunMacroArgument10 = null, Expression<Func<bool>> mSExcelRunMacroRunInBackground = null)
        {
            var apiCallPath = "/MSExcel/RunMacro";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelRunMacro = new JObject();
            var mSExcelRunMacropropCount = 0;
            if (mSExcelRunMacroHandle != null)
            {
                mSExcelRunMacro["Handle"] = ExpressionConverter.ConvertO(mSExcelRunMacroHandle);
                mSExcelRunMacropropCount++;
            }

            mSExcelRunMacropropCount++;
            mSExcelRunMacro["MacroName"] = ExpressionConverter.ConvertO(mSExcelRunMacroMacroName);
            if (mSExcelRunMacroNumberOfArguments != null)
            {
                mSExcelRunMacro["NumberOfArguments"] = ExpressionConverter.ConvertO(mSExcelRunMacroNumberOfArguments);
                mSExcelRunMacropropCount++;
            }

            if (mSExcelRunMacroArgument1 != null)
            {
                mSExcelRunMacro["Argument1"] = ExpressionConverter.ConvertO(mSExcelRunMacroArgument1);
                mSExcelRunMacropropCount++;
            }

            if (mSExcelRunMacroArgument2 != null)
            {
                mSExcelRunMacro["Argument2"] = ExpressionConverter.ConvertO(mSExcelRunMacroArgument2);
                mSExcelRunMacropropCount++;
            }

            if (mSExcelRunMacroArgument3 != null)
            {
                mSExcelRunMacro["Argument3"] = ExpressionConverter.ConvertO(mSExcelRunMacroArgument3);
                mSExcelRunMacropropCount++;
            }

            if (mSExcelRunMacroArgument4 != null)
            {
                mSExcelRunMacro["Argument4"] = ExpressionConverter.ConvertO(mSExcelRunMacroArgument4);
                mSExcelRunMacropropCount++;
            }

            if (mSExcelRunMacroArgument5 != null)
            {
                mSExcelRunMacro["Argument5"] = ExpressionConverter.ConvertO(mSExcelRunMacroArgument5);
                mSExcelRunMacropropCount++;
            }

            if (mSExcelRunMacroArgument6 != null)
            {
                mSExcelRunMacro["Argument6"] = ExpressionConverter.ConvertO(mSExcelRunMacroArgument6);
                mSExcelRunMacropropCount++;
            }

            if (mSExcelRunMacroArgument7 != null)
            {
                mSExcelRunMacro["Argument7"] = ExpressionConverter.ConvertO(mSExcelRunMacroArgument7);
                mSExcelRunMacropropCount++;
            }

            if (mSExcelRunMacroArgument8 != null)
            {
                mSExcelRunMacro["Argument8"] = ExpressionConverter.ConvertO(mSExcelRunMacroArgument8);
                mSExcelRunMacropropCount++;
            }

            if (mSExcelRunMacroArgument9 != null)
            {
                mSExcelRunMacro["Argument9"] = ExpressionConverter.ConvertO(mSExcelRunMacroArgument9);
                mSExcelRunMacropropCount++;
            }

            if (mSExcelRunMacroArgument10 != null)
            {
                mSExcelRunMacro["Argument10"] = ExpressionConverter.ConvertO(mSExcelRunMacroArgument10);
                mSExcelRunMacropropCount++;
            }

            if (mSExcelRunMacroRunInBackground != null)
            {
                mSExcelRunMacro["RunInBackground"] = ExpressionConverter.ConvertO(mSExcelRunMacroRunInBackground);
                mSExcelRunMacropropCount++;
            }

            mSExcelRunMacropropCount++;
            mSExcelRunMacro["Workflow"] = ExpressionConverter.ConvertO(mSExcelRunMacroWorkflow);
            if (mSExcelRunMacropropCount > 0)
            {
                callPayload.Body = mSExcelRunMacro;
            }

            return new ApiConnectionAction<MSExcelRunMacroResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelAddMacroToWorkbook(Expression<Func<string>> mSExcelAddMacroToWorkbookMacroCode, Expression<Func<string>> mSExcelAddMacroToWorkbookWorkflow, Expression<Func<int>> mSExcelAddMacroToWorkbookHandle = null, Expression<Func<string>> mSExcelAddMacroToWorkbookWorkbookName = null)
        {
            var apiCallPath = "/MSExcel/AddMacroToWorkbook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelAddMacroToWorkbook = new JObject();
            var mSExcelAddMacroToWorkbookpropCount = 0;
            if (mSExcelAddMacroToWorkbookHandle != null)
            {
                mSExcelAddMacroToWorkbook["Handle"] = ExpressionConverter.ConvertO(mSExcelAddMacroToWorkbookHandle);
                mSExcelAddMacroToWorkbookpropCount++;
            }

            if (mSExcelAddMacroToWorkbookWorkbookName != null)
            {
                mSExcelAddMacroToWorkbook["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelAddMacroToWorkbookWorkbookName);
                mSExcelAddMacroToWorkbookpropCount++;
            }

            mSExcelAddMacroToWorkbookpropCount++;
            mSExcelAddMacroToWorkbook["MacroCode"] = ExpressionConverter.ConvertO(mSExcelAddMacroToWorkbookMacroCode);
            mSExcelAddMacroToWorkbookpropCount++;
            mSExcelAddMacroToWorkbook["Workflow"] = ExpressionConverter.ConvertO(mSExcelAddMacroToWorkbookWorkflow);
            if (mSExcelAddMacroToWorkbookpropCount > 0)
            {
                callPayload.Body = mSExcelAddMacroToWorkbook;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelTrustVBOMInRegistry(Expression<Func<string>> mSExcelTrustVBOMInRegistryWorkflow, Expression<Func<int>> mSExcelTrustVBOMInRegistryExcelVersion = null, Expression<Func<bool>> mSExcelTrustVBOMInRegistryTrustVBOM = null)
        {
            var apiCallPath = "/MSExcel/TrustVBOMInRegistry";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelTrustVBOMInRegistry = new JObject();
            var mSExcelTrustVBOMInRegistrypropCount = 0;
            if (mSExcelTrustVBOMInRegistryExcelVersion != null)
            {
                mSExcelTrustVBOMInRegistry["ExcelVersion"] = ExpressionConverter.ConvertO(mSExcelTrustVBOMInRegistryExcelVersion);
                mSExcelTrustVBOMInRegistrypropCount++;
            }

            if (mSExcelTrustVBOMInRegistryTrustVBOM != null)
            {
                mSExcelTrustVBOMInRegistry["TrustVBOM"] = ExpressionConverter.ConvertO(mSExcelTrustVBOMInRegistryTrustVBOM);
                mSExcelTrustVBOMInRegistrypropCount++;
            }

            mSExcelTrustVBOMInRegistrypropCount++;
            mSExcelTrustVBOMInRegistry["Workflow"] = ExpressionConverter.ConvertO(mSExcelTrustVBOMInRegistryWorkflow);
            if (mSExcelTrustVBOMInRegistrypropCount > 0)
            {
                callPayload.Body = mSExcelTrustVBOMInRegistry;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelSetCalculationMode(Expression<Func<int>> mSExcelSetCalculationModeCalculationMode, Expression<Func<string>> mSExcelSetCalculationModeWorkflow, Expression<Func<int>> mSExcelSetCalculationModeHandle = null)
        {
            var apiCallPath = "/MSExcel/SetCalculationMode";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelSetCalculationMode = new JObject();
            var mSExcelSetCalculationModepropCount = 0;
            if (mSExcelSetCalculationModeHandle != null)
            {
                mSExcelSetCalculationMode["Handle"] = ExpressionConverter.ConvertO(mSExcelSetCalculationModeHandle);
                mSExcelSetCalculationModepropCount++;
            }

            mSExcelSetCalculationModepropCount++;
            mSExcelSetCalculationMode["CalculationMode"] = ExpressionConverter.ConvertO(mSExcelSetCalculationModeCalculationMode);
            mSExcelSetCalculationModepropCount++;
            mSExcelSetCalculationMode["Workflow"] = ExpressionConverter.ConvertO(mSExcelSetCalculationModeWorkflow);
            if (mSExcelSetCalculationModepropCount > 0)
            {
                callPayload.Body = mSExcelSetCalculationMode;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelExecuteCommandBarObject(Expression<Func<string>> mSExcelExecuteCommandBarObjectObjectId, Expression<Func<string>> mSExcelExecuteCommandBarObjectWorkflow, Expression<Func<int>> mSExcelExecuteCommandBarObjectHandle = null, Expression<Func<bool>> mSExcelExecuteCommandBarObjectRunInBackground = null)
        {
            var apiCallPath = "/MSExcel/ExecuteCommandBarObject";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelExecuteCommandBarObject = new JObject();
            var mSExcelExecuteCommandBarObjectpropCount = 0;
            if (mSExcelExecuteCommandBarObjectHandle != null)
            {
                mSExcelExecuteCommandBarObject["Handle"] = ExpressionConverter.ConvertO(mSExcelExecuteCommandBarObjectHandle);
                mSExcelExecuteCommandBarObjectpropCount++;
            }

            mSExcelExecuteCommandBarObjectpropCount++;
            mSExcelExecuteCommandBarObject["ObjectId"] = ExpressionConverter.ConvertO(mSExcelExecuteCommandBarObjectObjectId);
            if (mSExcelExecuteCommandBarObjectRunInBackground != null)
            {
                mSExcelExecuteCommandBarObject["RunInBackground"] = ExpressionConverter.ConvertO(mSExcelExecuteCommandBarObjectRunInBackground);
                mSExcelExecuteCommandBarObjectpropCount++;
            }

            mSExcelExecuteCommandBarObjectpropCount++;
            mSExcelExecuteCommandBarObject["Workflow"] = ExpressionConverter.ConvertO(mSExcelExecuteCommandBarObjectWorkflow);
            if (mSExcelExecuteCommandBarObjectpropCount > 0)
            {
                callPayload.Body = mSExcelExecuteCommandBarObject;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelCopyBetweenCellsResponse> MSExcelCopyBetweenCells(Expression<Func<string>> mSExcelCopyBetweenCellsSourceCellReference, Expression<Func<string>> mSExcelCopyBetweenCellsTargetCellReference, Expression<Func<string>> mSExcelCopyBetweenCellsWorkflow, Expression<Func<int>> mSExcelCopyBetweenCellsSourceHandle = null, Expression<Func<string>> mSExcelCopyBetweenCellsSourceWorkbookName = null, Expression<Func<string>> mSExcelCopyBetweenCellsSourceWorksheetName = null, Expression<Func<bool>> mSExcelCopyBetweenCellsSourceEntireRow = null, Expression<Func<bool>> mSExcelCopyBetweenCellsSourceEntireColumn = null, Expression<Func<int>> mSExcelCopyBetweenCellsTargetHandle = null, Expression<Func<string>> mSExcelCopyBetweenCellsTargetWorkbookName = null, Expression<Func<string>> mSExcelCopyBetweenCellsTargetWorksheetName = null, Expression<Func<bool>> mSExcelCopyBetweenCellsTargetEntireRow = null, Expression<Func<bool>> mSExcelCopyBetweenCellsTargetEntireColumn = null, Expression<Func<bool>> mSExcelCopyBetweenCellsValuesOnly = null, Expression<Func<bool>> mSExcelCopyBetweenCellsSimplePasteOnly = null)
        {
            var apiCallPath = "/MSExcel/CopyBetweenCells";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelCopyBetweenCells = new JObject();
            var mSExcelCopyBetweenCellspropCount = 0;
            if (mSExcelCopyBetweenCellsSourceHandle != null)
            {
                mSExcelCopyBetweenCells["SourceHandle"] = ExpressionConverter.ConvertO(mSExcelCopyBetweenCellsSourceHandle);
                mSExcelCopyBetweenCellspropCount++;
            }

            if (mSExcelCopyBetweenCellsSourceWorkbookName != null)
            {
                mSExcelCopyBetweenCells["SourceWorkbookName"] = ExpressionConverter.ConvertO(mSExcelCopyBetweenCellsSourceWorkbookName);
                mSExcelCopyBetweenCellspropCount++;
            }

            if (mSExcelCopyBetweenCellsSourceWorksheetName != null)
            {
                mSExcelCopyBetweenCells["SourceWorksheetName"] = ExpressionConverter.ConvertO(mSExcelCopyBetweenCellsSourceWorksheetName);
                mSExcelCopyBetweenCellspropCount++;
            }

            mSExcelCopyBetweenCellspropCount++;
            mSExcelCopyBetweenCells["SourceCellReference"] = ExpressionConverter.ConvertO(mSExcelCopyBetweenCellsSourceCellReference);
            if (mSExcelCopyBetweenCellsSourceEntireRow != null)
            {
                mSExcelCopyBetweenCells["SourceEntireRow"] = ExpressionConverter.ConvertO(mSExcelCopyBetweenCellsSourceEntireRow);
                mSExcelCopyBetweenCellspropCount++;
            }

            if (mSExcelCopyBetweenCellsSourceEntireColumn != null)
            {
                mSExcelCopyBetweenCells["SourceEntireColumn"] = ExpressionConverter.ConvertO(mSExcelCopyBetweenCellsSourceEntireColumn);
                mSExcelCopyBetweenCellspropCount++;
            }

            if (mSExcelCopyBetweenCellsTargetHandle != null)
            {
                mSExcelCopyBetweenCells["TargetHandle"] = ExpressionConverter.ConvertO(mSExcelCopyBetweenCellsTargetHandle);
                mSExcelCopyBetweenCellspropCount++;
            }

            if (mSExcelCopyBetweenCellsTargetWorkbookName != null)
            {
                mSExcelCopyBetweenCells["TargetWorkbookName"] = ExpressionConverter.ConvertO(mSExcelCopyBetweenCellsTargetWorkbookName);
                mSExcelCopyBetweenCellspropCount++;
            }

            if (mSExcelCopyBetweenCellsTargetWorksheetName != null)
            {
                mSExcelCopyBetweenCells["TargetWorksheetName"] = ExpressionConverter.ConvertO(mSExcelCopyBetweenCellsTargetWorksheetName);
                mSExcelCopyBetweenCellspropCount++;
            }

            mSExcelCopyBetweenCellspropCount++;
            mSExcelCopyBetweenCells["TargetCellReference"] = ExpressionConverter.ConvertO(mSExcelCopyBetweenCellsTargetCellReference);
            if (mSExcelCopyBetweenCellsTargetEntireRow != null)
            {
                mSExcelCopyBetweenCells["TargetEntireRow"] = ExpressionConverter.ConvertO(mSExcelCopyBetweenCellsTargetEntireRow);
                mSExcelCopyBetweenCellspropCount++;
            }

            if (mSExcelCopyBetweenCellsTargetEntireColumn != null)
            {
                mSExcelCopyBetweenCells["TargetEntireColumn"] = ExpressionConverter.ConvertO(mSExcelCopyBetweenCellsTargetEntireColumn);
                mSExcelCopyBetweenCellspropCount++;
            }

            if (mSExcelCopyBetweenCellsValuesOnly != null)
            {
                mSExcelCopyBetweenCells["ValuesOnly"] = ExpressionConverter.ConvertO(mSExcelCopyBetweenCellsValuesOnly);
                mSExcelCopyBetweenCellspropCount++;
            }

            if (mSExcelCopyBetweenCellsSimplePasteOnly != null)
            {
                mSExcelCopyBetweenCells["SimplePasteOnly"] = ExpressionConverter.ConvertO(mSExcelCopyBetweenCellsSimplePasteOnly);
                mSExcelCopyBetweenCellspropCount++;
            }

            mSExcelCopyBetweenCellspropCount++;
            mSExcelCopyBetweenCells["Workflow"] = ExpressionConverter.ConvertO(mSExcelCopyBetweenCellsWorkflow);
            if (mSExcelCopyBetweenCellspropCount > 0)
            {
                callPayload.Body = mSExcelCopyBetweenCells;
            }

            return new ApiConnectionAction<MSExcelCopyBetweenCellsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelCutBetweenCellsResponse> MSExcelCutBetweenCells(Expression<Func<string>> mSExcelCutBetweenCellsSourceCellReference, Expression<Func<string>> mSExcelCutBetweenCellsTargetCellReference, Expression<Func<string>> mSExcelCutBetweenCellsWorkflow, Expression<Func<int>> mSExcelCutBetweenCellsSourceHandle = null, Expression<Func<string>> mSExcelCutBetweenCellsSourceWorkbookName = null, Expression<Func<string>> mSExcelCutBetweenCellsSourceWorksheetName = null, Expression<Func<bool>> mSExcelCutBetweenCellsSourceEntireRow = null, Expression<Func<bool>> mSExcelCutBetweenCellsSourceEntireColumn = null, Expression<Func<int>> mSExcelCutBetweenCellsTargetHandle = null, Expression<Func<string>> mSExcelCutBetweenCellsTargetWorkbookName = null, Expression<Func<string>> mSExcelCutBetweenCellsTargetWorksheetName = null, Expression<Func<bool>> mSExcelCutBetweenCellsTargetEntireRow = null, Expression<Func<bool>> mSExcelCutBetweenCellsTargetEntireColumn = null, Expression<Func<bool>> mSExcelCutBetweenCellsValuesOnly = null)
        {
            var apiCallPath = "/MSExcel/CutBetweenCells";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelCutBetweenCells = new JObject();
            var mSExcelCutBetweenCellspropCount = 0;
            if (mSExcelCutBetweenCellsSourceHandle != null)
            {
                mSExcelCutBetweenCells["SourceHandle"] = ExpressionConverter.ConvertO(mSExcelCutBetweenCellsSourceHandle);
                mSExcelCutBetweenCellspropCount++;
            }

            if (mSExcelCutBetweenCellsSourceWorkbookName != null)
            {
                mSExcelCutBetweenCells["SourceWorkbookName"] = ExpressionConverter.ConvertO(mSExcelCutBetweenCellsSourceWorkbookName);
                mSExcelCutBetweenCellspropCount++;
            }

            if (mSExcelCutBetweenCellsSourceWorksheetName != null)
            {
                mSExcelCutBetweenCells["SourceWorksheetName"] = ExpressionConverter.ConvertO(mSExcelCutBetweenCellsSourceWorksheetName);
                mSExcelCutBetweenCellspropCount++;
            }

            mSExcelCutBetweenCellspropCount++;
            mSExcelCutBetweenCells["SourceCellReference"] = ExpressionConverter.ConvertO(mSExcelCutBetweenCellsSourceCellReference);
            if (mSExcelCutBetweenCellsSourceEntireRow != null)
            {
                mSExcelCutBetweenCells["SourceEntireRow"] = ExpressionConverter.ConvertO(mSExcelCutBetweenCellsSourceEntireRow);
                mSExcelCutBetweenCellspropCount++;
            }

            if (mSExcelCutBetweenCellsSourceEntireColumn != null)
            {
                mSExcelCutBetweenCells["SourceEntireColumn"] = ExpressionConverter.ConvertO(mSExcelCutBetweenCellsSourceEntireColumn);
                mSExcelCutBetweenCellspropCount++;
            }

            if (mSExcelCutBetweenCellsTargetHandle != null)
            {
                mSExcelCutBetweenCells["TargetHandle"] = ExpressionConverter.ConvertO(mSExcelCutBetweenCellsTargetHandle);
                mSExcelCutBetweenCellspropCount++;
            }

            if (mSExcelCutBetweenCellsTargetWorkbookName != null)
            {
                mSExcelCutBetweenCells["TargetWorkbookName"] = ExpressionConverter.ConvertO(mSExcelCutBetweenCellsTargetWorkbookName);
                mSExcelCutBetweenCellspropCount++;
            }

            if (mSExcelCutBetweenCellsTargetWorksheetName != null)
            {
                mSExcelCutBetweenCells["TargetWorksheetName"] = ExpressionConverter.ConvertO(mSExcelCutBetweenCellsTargetWorksheetName);
                mSExcelCutBetweenCellspropCount++;
            }

            mSExcelCutBetweenCellspropCount++;
            mSExcelCutBetweenCells["TargetCellReference"] = ExpressionConverter.ConvertO(mSExcelCutBetweenCellsTargetCellReference);
            if (mSExcelCutBetweenCellsTargetEntireRow != null)
            {
                mSExcelCutBetweenCells["TargetEntireRow"] = ExpressionConverter.ConvertO(mSExcelCutBetweenCellsTargetEntireRow);
                mSExcelCutBetweenCellspropCount++;
            }

            if (mSExcelCutBetweenCellsTargetEntireColumn != null)
            {
                mSExcelCutBetweenCells["TargetEntireColumn"] = ExpressionConverter.ConvertO(mSExcelCutBetweenCellsTargetEntireColumn);
                mSExcelCutBetweenCellspropCount++;
            }

            if (mSExcelCutBetweenCellsValuesOnly != null)
            {
                mSExcelCutBetweenCells["ValuesOnly"] = ExpressionConverter.ConvertO(mSExcelCutBetweenCellsValuesOnly);
                mSExcelCutBetweenCellspropCount++;
            }

            mSExcelCutBetweenCellspropCount++;
            mSExcelCutBetweenCells["Workflow"] = ExpressionConverter.ConvertO(mSExcelCutBetweenCellsWorkflow);
            if (mSExcelCutBetweenCellspropCount > 0)
            {
                callPayload.Body = mSExcelCutBetweenCells;
            }

            return new ApiConnectionAction<MSExcelCutBetweenCellsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelMinimiseWindowResponse> MSExcelMinimiseWindow(Expression<Func<string>> mSExcelMinimiseWindowWorkflow, Expression<Func<int>> mSExcelMinimiseWindowHandle = null)
        {
            var apiCallPath = "/MSExcel/MinimiseWindow";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelMinimiseWindow = new JObject();
            var mSExcelMinimiseWindowpropCount = 0;
            if (mSExcelMinimiseWindowHandle != null)
            {
                mSExcelMinimiseWindow["Handle"] = ExpressionConverter.ConvertO(mSExcelMinimiseWindowHandle);
                mSExcelMinimiseWindowpropCount++;
            }

            mSExcelMinimiseWindowpropCount++;
            mSExcelMinimiseWindow["Workflow"] = ExpressionConverter.ConvertO(mSExcelMinimiseWindowWorkflow);
            if (mSExcelMinimiseWindowpropCount > 0)
            {
                callPayload.Body = mSExcelMinimiseWindow;
            }

            return new ApiConnectionAction<MSExcelMinimiseWindowResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelMaximiseWindowResponse> MSExcelMaximiseWindow(Expression<Func<string>> mSExcelMaximiseWindowWorkflow, Expression<Func<int>> mSExcelMaximiseWindowHandle = null)
        {
            var apiCallPath = "/MSExcel/MaximiseWindow";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelMaximiseWindow = new JObject();
            var mSExcelMaximiseWindowpropCount = 0;
            if (mSExcelMaximiseWindowHandle != null)
            {
                mSExcelMaximiseWindow["Handle"] = ExpressionConverter.ConvertO(mSExcelMaximiseWindowHandle);
                mSExcelMaximiseWindowpropCount++;
            }

            mSExcelMaximiseWindowpropCount++;
            mSExcelMaximiseWindow["Workflow"] = ExpressionConverter.ConvertO(mSExcelMaximiseWindowWorkflow);
            if (mSExcelMaximiseWindowpropCount > 0)
            {
                callPayload.Body = mSExcelMaximiseWindow;
            }

            return new ApiConnectionAction<MSExcelMaximiseWindowResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelNormaliseWindowResponse> MSExcelNormaliseWindow(Expression<Func<string>> mSExcelNormaliseWindowWorkflow, Expression<Func<int>> mSExcelNormaliseWindowHandle = null)
        {
            var apiCallPath = "/MSExcel/NormaliseWindow";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelNormaliseWindow = new JObject();
            var mSExcelNormaliseWindowpropCount = 0;
            if (mSExcelNormaliseWindowHandle != null)
            {
                mSExcelNormaliseWindow["Handle"] = ExpressionConverter.ConvertO(mSExcelNormaliseWindowHandle);
                mSExcelNormaliseWindowpropCount++;
            }

            mSExcelNormaliseWindowpropCount++;
            mSExcelNormaliseWindow["Workflow"] = ExpressionConverter.ConvertO(mSExcelNormaliseWindowWorkflow);
            if (mSExcelNormaliseWindowpropCount > 0)
            {
                callPayload.Body = mSExcelNormaliseWindow;
            }

            return new ApiConnectionAction<MSExcelNormaliseWindowResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetAndSetCellValueResponse> MSExcelGetAndSetCellValue(Expression<Func<string>> mSExcelGetAndSetCellValueSourceCellReference, Expression<Func<string>> mSExcelGetAndSetCellValueTargetCellReference, Expression<Func<string>> mSExcelGetAndSetCellValueWorkflow, Expression<Func<int>> mSExcelGetAndSetCellValueSourceHandle = null, Expression<Func<string>> mSExcelGetAndSetCellValueSourceWorkbookName = null, Expression<Func<string>> mSExcelGetAndSetCellValueSourceWorksheetName = null, Expression<Func<int>> mSExcelGetAndSetCellValueTargetHandle = null, Expression<Func<string>> mSExcelGetAndSetCellValueTargetWorkbookName = null, Expression<Func<string>> mSExcelGetAndSetCellValueTargetWorksheetName = null)
        {
            var apiCallPath = "/MSExcel/GetAndSetCellValue";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelGetAndSetCellValue = new JObject();
            var mSExcelGetAndSetCellValuepropCount = 0;
            if (mSExcelGetAndSetCellValueSourceHandle != null)
            {
                mSExcelGetAndSetCellValue["SourceHandle"] = ExpressionConverter.ConvertO(mSExcelGetAndSetCellValueSourceHandle);
                mSExcelGetAndSetCellValuepropCount++;
            }

            if (mSExcelGetAndSetCellValueSourceWorkbookName != null)
            {
                mSExcelGetAndSetCellValue["SourceWorkbookName"] = ExpressionConverter.ConvertO(mSExcelGetAndSetCellValueSourceWorkbookName);
                mSExcelGetAndSetCellValuepropCount++;
            }

            if (mSExcelGetAndSetCellValueSourceWorksheetName != null)
            {
                mSExcelGetAndSetCellValue["SourceWorksheetName"] = ExpressionConverter.ConvertO(mSExcelGetAndSetCellValueSourceWorksheetName);
                mSExcelGetAndSetCellValuepropCount++;
            }

            mSExcelGetAndSetCellValuepropCount++;
            mSExcelGetAndSetCellValue["SourceCellReference"] = ExpressionConverter.ConvertO(mSExcelGetAndSetCellValueSourceCellReference);
            if (mSExcelGetAndSetCellValueTargetHandle != null)
            {
                mSExcelGetAndSetCellValue["TargetHandle"] = ExpressionConverter.ConvertO(mSExcelGetAndSetCellValueTargetHandle);
                mSExcelGetAndSetCellValuepropCount++;
            }

            if (mSExcelGetAndSetCellValueTargetWorkbookName != null)
            {
                mSExcelGetAndSetCellValue["TargetWorkbookName"] = ExpressionConverter.ConvertO(mSExcelGetAndSetCellValueTargetWorkbookName);
                mSExcelGetAndSetCellValuepropCount++;
            }

            if (mSExcelGetAndSetCellValueTargetWorksheetName != null)
            {
                mSExcelGetAndSetCellValue["TargetWorksheetName"] = ExpressionConverter.ConvertO(mSExcelGetAndSetCellValueTargetWorksheetName);
                mSExcelGetAndSetCellValuepropCount++;
            }

            mSExcelGetAndSetCellValuepropCount++;
            mSExcelGetAndSetCellValue["TargetCellReference"] = ExpressionConverter.ConvertO(mSExcelGetAndSetCellValueTargetCellReference);
            mSExcelGetAndSetCellValuepropCount++;
            mSExcelGetAndSetCellValue["Workflow"] = ExpressionConverter.ConvertO(mSExcelGetAndSetCellValueWorkflow);
            if (mSExcelGetAndSetCellValuepropCount > 0)
            {
                callPayload.Body = mSExcelGetAndSetCellValue;
            }

            return new ApiConnectionAction<MSExcelGetAndSetCellValueResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetAndSetCellValue2Response> MSExcelGetAndSetCellValue2(Expression<Func<string>> mSExcelGetAndSetCellValue2SourceCellReference, Expression<Func<string>> mSExcelGetAndSetCellValue2TargetCellReference, Expression<Func<string>> mSExcelGetAndSetCellValue2Workflow, Expression<Func<int>> mSExcelGetAndSetCellValue2SourceHandle = null, Expression<Func<string>> mSExcelGetAndSetCellValue2SourceWorkbookName = null, Expression<Func<string>> mSExcelGetAndSetCellValue2SourceWorksheetName = null, Expression<Func<int>> mSExcelGetAndSetCellValue2TargetHandle = null, Expression<Func<string>> mSExcelGetAndSetCellValue2TargetWorkbookName = null, Expression<Func<string>> mSExcelGetAndSetCellValue2TargetWorksheetName = null)
        {
            var apiCallPath = "/MSExcel/GetAndSetCellValue2";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelGetAndSetCellValue2 = new JObject();
            var mSExcelGetAndSetCellValue2propCount = 0;
            if (mSExcelGetAndSetCellValue2SourceHandle != null)
            {
                mSExcelGetAndSetCellValue2["SourceHandle"] = ExpressionConverter.ConvertO(mSExcelGetAndSetCellValue2SourceHandle);
                mSExcelGetAndSetCellValue2propCount++;
            }

            if (mSExcelGetAndSetCellValue2SourceWorkbookName != null)
            {
                mSExcelGetAndSetCellValue2["SourceWorkbookName"] = ExpressionConverter.ConvertO(mSExcelGetAndSetCellValue2SourceWorkbookName);
                mSExcelGetAndSetCellValue2propCount++;
            }

            if (mSExcelGetAndSetCellValue2SourceWorksheetName != null)
            {
                mSExcelGetAndSetCellValue2["SourceWorksheetName"] = ExpressionConverter.ConvertO(mSExcelGetAndSetCellValue2SourceWorksheetName);
                mSExcelGetAndSetCellValue2propCount++;
            }

            mSExcelGetAndSetCellValue2propCount++;
            mSExcelGetAndSetCellValue2["SourceCellReference"] = ExpressionConverter.ConvertO(mSExcelGetAndSetCellValue2SourceCellReference);
            if (mSExcelGetAndSetCellValue2TargetHandle != null)
            {
                mSExcelGetAndSetCellValue2["TargetHandle"] = ExpressionConverter.ConvertO(mSExcelGetAndSetCellValue2TargetHandle);
                mSExcelGetAndSetCellValue2propCount++;
            }

            if (mSExcelGetAndSetCellValue2TargetWorkbookName != null)
            {
                mSExcelGetAndSetCellValue2["TargetWorkbookName"] = ExpressionConverter.ConvertO(mSExcelGetAndSetCellValue2TargetWorkbookName);
                mSExcelGetAndSetCellValue2propCount++;
            }

            if (mSExcelGetAndSetCellValue2TargetWorksheetName != null)
            {
                mSExcelGetAndSetCellValue2["TargetWorksheetName"] = ExpressionConverter.ConvertO(mSExcelGetAndSetCellValue2TargetWorksheetName);
                mSExcelGetAndSetCellValue2propCount++;
            }

            mSExcelGetAndSetCellValue2propCount++;
            mSExcelGetAndSetCellValue2["TargetCellReference"] = ExpressionConverter.ConvertO(mSExcelGetAndSetCellValue2TargetCellReference);
            mSExcelGetAndSetCellValue2propCount++;
            mSExcelGetAndSetCellValue2["Workflow"] = ExpressionConverter.ConvertO(mSExcelGetAndSetCellValue2Workflow);
            if (mSExcelGetAndSetCellValue2propCount > 0)
            {
                callPayload.Body = mSExcelGetAndSetCellValue2;
            }

            return new ApiConnectionAction<MSExcelGetAndSetCellValue2Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetAndSetCellTextResponse> MSExcelGetAndSetCellText(Expression<Func<string>> mSExcelGetAndSetCellTextSourceCellReference, Expression<Func<string>> mSExcelGetAndSetCellTextTargetCellReference, Expression<Func<string>> mSExcelGetAndSetCellTextWorkflow, Expression<Func<int>> mSExcelGetAndSetCellTextSourceHandle = null, Expression<Func<string>> mSExcelGetAndSetCellTextSourceWorkbookName = null, Expression<Func<string>> mSExcelGetAndSetCellTextSourceWorksheetName = null, Expression<Func<int>> mSExcelGetAndSetCellTextTargetHandle = null, Expression<Func<string>> mSExcelGetAndSetCellTextTargetWorkbookName = null, Expression<Func<string>> mSExcelGetAndSetCellTextTargetWorksheetName = null)
        {
            var apiCallPath = "/MSExcel/GetAndSetCellText";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelGetAndSetCellText = new JObject();
            var mSExcelGetAndSetCellTextpropCount = 0;
            if (mSExcelGetAndSetCellTextSourceHandle != null)
            {
                mSExcelGetAndSetCellText["SourceHandle"] = ExpressionConverter.ConvertO(mSExcelGetAndSetCellTextSourceHandle);
                mSExcelGetAndSetCellTextpropCount++;
            }

            if (mSExcelGetAndSetCellTextSourceWorkbookName != null)
            {
                mSExcelGetAndSetCellText["SourceWorkbookName"] = ExpressionConverter.ConvertO(mSExcelGetAndSetCellTextSourceWorkbookName);
                mSExcelGetAndSetCellTextpropCount++;
            }

            if (mSExcelGetAndSetCellTextSourceWorksheetName != null)
            {
                mSExcelGetAndSetCellText["SourceWorksheetName"] = ExpressionConverter.ConvertO(mSExcelGetAndSetCellTextSourceWorksheetName);
                mSExcelGetAndSetCellTextpropCount++;
            }

            mSExcelGetAndSetCellTextpropCount++;
            mSExcelGetAndSetCellText["SourceCellReference"] = ExpressionConverter.ConvertO(mSExcelGetAndSetCellTextSourceCellReference);
            if (mSExcelGetAndSetCellTextTargetHandle != null)
            {
                mSExcelGetAndSetCellText["TargetHandle"] = ExpressionConverter.ConvertO(mSExcelGetAndSetCellTextTargetHandle);
                mSExcelGetAndSetCellTextpropCount++;
            }

            if (mSExcelGetAndSetCellTextTargetWorkbookName != null)
            {
                mSExcelGetAndSetCellText["TargetWorkbookName"] = ExpressionConverter.ConvertO(mSExcelGetAndSetCellTextTargetWorkbookName);
                mSExcelGetAndSetCellTextpropCount++;
            }

            if (mSExcelGetAndSetCellTextTargetWorksheetName != null)
            {
                mSExcelGetAndSetCellText["TargetWorksheetName"] = ExpressionConverter.ConvertO(mSExcelGetAndSetCellTextTargetWorksheetName);
                mSExcelGetAndSetCellTextpropCount++;
            }

            mSExcelGetAndSetCellTextpropCount++;
            mSExcelGetAndSetCellText["TargetCellReference"] = ExpressionConverter.ConvertO(mSExcelGetAndSetCellTextTargetCellReference);
            mSExcelGetAndSetCellTextpropCount++;
            mSExcelGetAndSetCellText["Workflow"] = ExpressionConverter.ConvertO(mSExcelGetAndSetCellTextWorkflow);
            if (mSExcelGetAndSetCellTextpropCount > 0)
            {
                callPayload.Body = mSExcelGetAndSetCellText;
            }

            return new ApiConnectionAction<MSExcelGetAndSetCellTextResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelCheckOLEObjectResponse> MSExcelCheckOLEObject(Expression<Func<string>> mSExcelCheckOLEObjectOLEObjectName, Expression<Func<string>> mSExcelCheckOLEObjectWorkflow, Expression<Func<int>> mSExcelCheckOLEObjectHandle = null, Expression<Func<string>> mSExcelCheckOLEObjectWorkbookName = null, Expression<Func<string>> mSExcelCheckOLEObjectWorksheetName = null, Expression<Func<bool>> mSExcelCheckOLEObjectChecked = null, Expression<Func<bool>> mSExcelCheckOLEObjectRunInBackground = null)
        {
            var apiCallPath = "/MSExcel/CheckOLEObject";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelCheckOLEObject = new JObject();
            var mSExcelCheckOLEObjectpropCount = 0;
            if (mSExcelCheckOLEObjectHandle != null)
            {
                mSExcelCheckOLEObject["Handle"] = ExpressionConverter.ConvertO(mSExcelCheckOLEObjectHandle);
                mSExcelCheckOLEObjectpropCount++;
            }

            if (mSExcelCheckOLEObjectWorkbookName != null)
            {
                mSExcelCheckOLEObject["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelCheckOLEObjectWorkbookName);
                mSExcelCheckOLEObjectpropCount++;
            }

            if (mSExcelCheckOLEObjectWorksheetName != null)
            {
                mSExcelCheckOLEObject["WorksheetName"] = ExpressionConverter.ConvertO(mSExcelCheckOLEObjectWorksheetName);
                mSExcelCheckOLEObjectpropCount++;
            }

            mSExcelCheckOLEObjectpropCount++;
            mSExcelCheckOLEObject["OLEObjectName"] = ExpressionConverter.ConvertO(mSExcelCheckOLEObjectOLEObjectName);
            if (mSExcelCheckOLEObjectChecked != null)
            {
                mSExcelCheckOLEObject["Checked"] = ExpressionConverter.ConvertO(mSExcelCheckOLEObjectChecked);
                mSExcelCheckOLEObjectpropCount++;
            }

            if (mSExcelCheckOLEObjectRunInBackground != null)
            {
                mSExcelCheckOLEObject["RunInBackground"] = ExpressionConverter.ConvertO(mSExcelCheckOLEObjectRunInBackground);
                mSExcelCheckOLEObjectpropCount++;
            }

            mSExcelCheckOLEObjectpropCount++;
            mSExcelCheckOLEObject["Workflow"] = ExpressionConverter.ConvertO(mSExcelCheckOLEObjectWorkflow);
            if (mSExcelCheckOLEObjectpropCount > 0)
            {
                callPayload.Body = mSExcelCheckOLEObject;
            }

            return new ApiConnectionAction<MSExcelCheckOLEObjectResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelInputTextIntoOLEObjectResponse> MSExcelInputTextIntoOLEObject(Expression<Func<string>> mSExcelInputTextIntoOLEObjectOLEObjectName, Expression<Func<string>> mSExcelInputTextIntoOLEObjectWorkflow, Expression<Func<int>> mSExcelInputTextIntoOLEObjectHandle = null, Expression<Func<string>> mSExcelInputTextIntoOLEObjectWorkbookName = null, Expression<Func<string>> mSExcelInputTextIntoOLEObjectWorksheetName = null, Expression<Func<string>> mSExcelInputTextIntoOLEObjectTextToInput = null, Expression<Func<bool>> mSExcelInputTextIntoOLEObjectRunInBackground = null)
        {
            var apiCallPath = "/MSExcel/InputTextIntoOLEObject";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelInputTextIntoOLEObject = new JObject();
            var mSExcelInputTextIntoOLEObjectpropCount = 0;
            if (mSExcelInputTextIntoOLEObjectHandle != null)
            {
                mSExcelInputTextIntoOLEObject["Handle"] = ExpressionConverter.ConvertO(mSExcelInputTextIntoOLEObjectHandle);
                mSExcelInputTextIntoOLEObjectpropCount++;
            }

            if (mSExcelInputTextIntoOLEObjectWorkbookName != null)
            {
                mSExcelInputTextIntoOLEObject["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelInputTextIntoOLEObjectWorkbookName);
                mSExcelInputTextIntoOLEObjectpropCount++;
            }

            if (mSExcelInputTextIntoOLEObjectWorksheetName != null)
            {
                mSExcelInputTextIntoOLEObject["WorksheetName"] = ExpressionConverter.ConvertO(mSExcelInputTextIntoOLEObjectWorksheetName);
                mSExcelInputTextIntoOLEObjectpropCount++;
            }

            mSExcelInputTextIntoOLEObjectpropCount++;
            mSExcelInputTextIntoOLEObject["OLEObjectName"] = ExpressionConverter.ConvertO(mSExcelInputTextIntoOLEObjectOLEObjectName);
            if (mSExcelInputTextIntoOLEObjectTextToInput != null)
            {
                mSExcelInputTextIntoOLEObject["TextToInput"] = ExpressionConverter.ConvertO(mSExcelInputTextIntoOLEObjectTextToInput);
                mSExcelInputTextIntoOLEObjectpropCount++;
            }

            if (mSExcelInputTextIntoOLEObjectRunInBackground != null)
            {
                mSExcelInputTextIntoOLEObject["RunInBackground"] = ExpressionConverter.ConvertO(mSExcelInputTextIntoOLEObjectRunInBackground);
                mSExcelInputTextIntoOLEObjectpropCount++;
            }

            mSExcelInputTextIntoOLEObjectpropCount++;
            mSExcelInputTextIntoOLEObject["Workflow"] = ExpressionConverter.ConvertO(mSExcelInputTextIntoOLEObjectWorkflow);
            if (mSExcelInputTextIntoOLEObjectpropCount > 0)
            {
                callPayload.Body = mSExcelInputTextIntoOLEObject;
            }

            return new ApiConnectionAction<MSExcelInputTextIntoOLEObjectResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelSetCellBackgroundColourResponse> MSExcelSetCellBackgroundColour(Expression<Func<string>> mSExcelSetCellBackgroundColourCellReference, Expression<Func<int>> mSExcelSetCellBackgroundColourColourIndex, Expression<Func<string>> mSExcelSetCellBackgroundColourWorkflow, Expression<Func<int>> mSExcelSetCellBackgroundColourHandle = null, Expression<Func<string>> mSExcelSetCellBackgroundColourWorkbookName = null, Expression<Func<string>> mSExcelSetCellBackgroundColourWorksheetName = null)
        {
            var apiCallPath = "/MSExcel/SetCellBackgroundColour";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelSetCellBackgroundColour = new JObject();
            var mSExcelSetCellBackgroundColourpropCount = 0;
            if (mSExcelSetCellBackgroundColourHandle != null)
            {
                mSExcelSetCellBackgroundColour["Handle"] = ExpressionConverter.ConvertO(mSExcelSetCellBackgroundColourHandle);
                mSExcelSetCellBackgroundColourpropCount++;
            }

            if (mSExcelSetCellBackgroundColourWorkbookName != null)
            {
                mSExcelSetCellBackgroundColour["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelSetCellBackgroundColourWorkbookName);
                mSExcelSetCellBackgroundColourpropCount++;
            }

            if (mSExcelSetCellBackgroundColourWorksheetName != null)
            {
                mSExcelSetCellBackgroundColour["WorksheetName"] = ExpressionConverter.ConvertO(mSExcelSetCellBackgroundColourWorksheetName);
                mSExcelSetCellBackgroundColourpropCount++;
            }

            mSExcelSetCellBackgroundColourpropCount++;
            mSExcelSetCellBackgroundColour["CellReference"] = ExpressionConverter.ConvertO(mSExcelSetCellBackgroundColourCellReference);
            mSExcelSetCellBackgroundColourpropCount++;
            mSExcelSetCellBackgroundColour["ColourIndex"] = ExpressionConverter.ConvertO(mSExcelSetCellBackgroundColourColourIndex);
            mSExcelSetCellBackgroundColourpropCount++;
            mSExcelSetCellBackgroundColour["Workflow"] = ExpressionConverter.ConvertO(mSExcelSetCellBackgroundColourWorkflow);
            if (mSExcelSetCellBackgroundColourpropCount > 0)
            {
                callPayload.Body = mSExcelSetCellBackgroundColour;
            }

            return new ApiConnectionAction<MSExcelSetCellBackgroundColourResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetCellBackgroundColourResponse> MSExcelGetCellBackgroundColour(Expression<Func<string>> mSExcelGetCellBackgroundColourCellReference, Expression<Func<string>> mSExcelGetCellBackgroundColourWorkflow, Expression<Func<int>> mSExcelGetCellBackgroundColourHandle = null, Expression<Func<string>> mSExcelGetCellBackgroundColourWorkbookName = null, Expression<Func<string>> mSExcelGetCellBackgroundColourWorksheetName = null)
        {
            var apiCallPath = "/MSExcel/GetCellBackgroundColour";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelGetCellBackgroundColour = new JObject();
            var mSExcelGetCellBackgroundColourpropCount = 0;
            if (mSExcelGetCellBackgroundColourHandle != null)
            {
                mSExcelGetCellBackgroundColour["Handle"] = ExpressionConverter.ConvertO(mSExcelGetCellBackgroundColourHandle);
                mSExcelGetCellBackgroundColourpropCount++;
            }

            if (mSExcelGetCellBackgroundColourWorkbookName != null)
            {
                mSExcelGetCellBackgroundColour["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelGetCellBackgroundColourWorkbookName);
                mSExcelGetCellBackgroundColourpropCount++;
            }

            if (mSExcelGetCellBackgroundColourWorksheetName != null)
            {
                mSExcelGetCellBackgroundColour["WorksheetName"] = ExpressionConverter.ConvertO(mSExcelGetCellBackgroundColourWorksheetName);
                mSExcelGetCellBackgroundColourpropCount++;
            }

            mSExcelGetCellBackgroundColourpropCount++;
            mSExcelGetCellBackgroundColour["CellReference"] = ExpressionConverter.ConvertO(mSExcelGetCellBackgroundColourCellReference);
            mSExcelGetCellBackgroundColourpropCount++;
            mSExcelGetCellBackgroundColour["Workflow"] = ExpressionConverter.ConvertO(mSExcelGetCellBackgroundColourWorkflow);
            if (mSExcelGetCellBackgroundColourpropCount > 0)
            {
                callPayload.Body = mSExcelGetCellBackgroundColour;
            }

            return new ApiConnectionAction<MSExcelGetCellBackgroundColourResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetOLEObjectValueResponse> MSExcelGetOLEObjectValue(Expression<Func<string>> mSExcelGetOLEObjectValueOLEObjectName, Expression<Func<string>> mSExcelGetOLEObjectValueWorkflow, Expression<Func<int>> mSExcelGetOLEObjectValueHandle = null, Expression<Func<string>> mSExcelGetOLEObjectValueWorkbookName = null, Expression<Func<string>> mSExcelGetOLEObjectValueWorksheetName = null)
        {
            var apiCallPath = "/MSExcel/GetOLEObjectValue";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelGetOLEObjectValue = new JObject();
            var mSExcelGetOLEObjectValuepropCount = 0;
            if (mSExcelGetOLEObjectValueHandle != null)
            {
                mSExcelGetOLEObjectValue["Handle"] = ExpressionConverter.ConvertO(mSExcelGetOLEObjectValueHandle);
                mSExcelGetOLEObjectValuepropCount++;
            }

            if (mSExcelGetOLEObjectValueWorkbookName != null)
            {
                mSExcelGetOLEObjectValue["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelGetOLEObjectValueWorkbookName);
                mSExcelGetOLEObjectValuepropCount++;
            }

            if (mSExcelGetOLEObjectValueWorksheetName != null)
            {
                mSExcelGetOLEObjectValue["WorksheetName"] = ExpressionConverter.ConvertO(mSExcelGetOLEObjectValueWorksheetName);
                mSExcelGetOLEObjectValuepropCount++;
            }

            mSExcelGetOLEObjectValuepropCount++;
            mSExcelGetOLEObjectValue["OLEObjectName"] = ExpressionConverter.ConvertO(mSExcelGetOLEObjectValueOLEObjectName);
            mSExcelGetOLEObjectValuepropCount++;
            mSExcelGetOLEObjectValue["Workflow"] = ExpressionConverter.ConvertO(mSExcelGetOLEObjectValueWorkflow);
            if (mSExcelGetOLEObjectValuepropCount > 0)
            {
                callPayload.Body = mSExcelGetOLEObjectValue;
            }

            return new ApiConnectionAction<MSExcelGetOLEObjectValueResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelDoesOLEObjectExistResponse> MSExcelDoesOLEObjectExist(Expression<Func<string>> mSExcelDoesOLEObjectExistOLEObjectName, Expression<Func<string>> mSExcelDoesOLEObjectExistWorkflow, Expression<Func<int>> mSExcelDoesOLEObjectExistHandle = null, Expression<Func<string>> mSExcelDoesOLEObjectExistWorkbookName = null, Expression<Func<string>> mSExcelDoesOLEObjectExistWorksheetName = null)
        {
            var apiCallPath = "/MSExcel/DoesOLEObjectExist";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelDoesOLEObjectExist = new JObject();
            var mSExcelDoesOLEObjectExistpropCount = 0;
            if (mSExcelDoesOLEObjectExistHandle != null)
            {
                mSExcelDoesOLEObjectExist["Handle"] = ExpressionConverter.ConvertO(mSExcelDoesOLEObjectExistHandle);
                mSExcelDoesOLEObjectExistpropCount++;
            }

            if (mSExcelDoesOLEObjectExistWorkbookName != null)
            {
                mSExcelDoesOLEObjectExist["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelDoesOLEObjectExistWorkbookName);
                mSExcelDoesOLEObjectExistpropCount++;
            }

            if (mSExcelDoesOLEObjectExistWorksheetName != null)
            {
                mSExcelDoesOLEObjectExist["WorksheetName"] = ExpressionConverter.ConvertO(mSExcelDoesOLEObjectExistWorksheetName);
                mSExcelDoesOLEObjectExistpropCount++;
            }

            mSExcelDoesOLEObjectExistpropCount++;
            mSExcelDoesOLEObjectExist["OLEObjectName"] = ExpressionConverter.ConvertO(mSExcelDoesOLEObjectExistOLEObjectName);
            mSExcelDoesOLEObjectExistpropCount++;
            mSExcelDoesOLEObjectExist["Workflow"] = ExpressionConverter.ConvertO(mSExcelDoesOLEObjectExistWorkflow);
            if (mSExcelDoesOLEObjectExistpropCount > 0)
            {
                callPayload.Body = mSExcelDoesOLEObjectExist;
            }

            return new ApiConnectionAction<MSExcelDoesOLEObjectExistResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelPressOLEObjectResponse> MSExcelPressOLEObject(Expression<Func<string>> mSExcelPressOLEObjectOLEObjectName, Expression<Func<string>> mSExcelPressOLEObjectWorkflow, Expression<Func<int>> mSExcelPressOLEObjectHandle = null, Expression<Func<string>> mSExcelPressOLEObjectWorkbookName = null, Expression<Func<string>> mSExcelPressOLEObjectWorksheetName = null, Expression<Func<bool>> mSExcelPressOLEObjectRunInBackground = null)
        {
            var apiCallPath = "/MSExcel/PressOLEObject";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelPressOLEObject = new JObject();
            var mSExcelPressOLEObjectpropCount = 0;
            if (mSExcelPressOLEObjectHandle != null)
            {
                mSExcelPressOLEObject["Handle"] = ExpressionConverter.ConvertO(mSExcelPressOLEObjectHandle);
                mSExcelPressOLEObjectpropCount++;
            }

            if (mSExcelPressOLEObjectWorkbookName != null)
            {
                mSExcelPressOLEObject["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelPressOLEObjectWorkbookName);
                mSExcelPressOLEObjectpropCount++;
            }

            if (mSExcelPressOLEObjectWorksheetName != null)
            {
                mSExcelPressOLEObject["WorksheetName"] = ExpressionConverter.ConvertO(mSExcelPressOLEObjectWorksheetName);
                mSExcelPressOLEObjectpropCount++;
            }

            mSExcelPressOLEObjectpropCount++;
            mSExcelPressOLEObject["OLEObjectName"] = ExpressionConverter.ConvertO(mSExcelPressOLEObjectOLEObjectName);
            if (mSExcelPressOLEObjectRunInBackground != null)
            {
                mSExcelPressOLEObject["RunInBackground"] = ExpressionConverter.ConvertO(mSExcelPressOLEObjectRunInBackground);
                mSExcelPressOLEObjectpropCount++;
            }

            mSExcelPressOLEObjectpropCount++;
            mSExcelPressOLEObject["Workflow"] = ExpressionConverter.ConvertO(mSExcelPressOLEObjectWorkflow);
            if (mSExcelPressOLEObjectpropCount > 0)
            {
                callPayload.Body = mSExcelPressOLEObject;
            }

            return new ApiConnectionAction<MSExcelPressOLEObjectResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelSetWorksheetSensitivityLabelResponse> MSExcelSetWorksheetSensitivityLabel(Expression<Func<mSExcelSetWorksheetSensitivityLabelAssignmentMethodInput>> mSExcelSetWorksheetSensitivityLabelAssignmentMethod, Expression<Func<string>> mSExcelSetWorksheetSensitivityLabelLabelId, Expression<Func<string>> mSExcelSetWorksheetSensitivityLabelWorkflow, Expression<Func<int>> mSExcelSetWorksheetSensitivityLabelHandle = null, Expression<Func<string>> mSExcelSetWorksheetSensitivityLabelWorkbookName = null, Expression<Func<string>> mSExcelSetWorksheetSensitivityLabelLabelName = null, Expression<Func<string>> mSExcelSetWorksheetSensitivityLabelSiteId = null, Expression<Func<string>> mSExcelSetWorksheetSensitivityLabelJustification = null)
        {
            var apiCallPath = "/MSExcel/SetWorksheetSensitivityLabel";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelSetWorksheetSensitivityLabel = new JObject();
            var mSExcelSetWorksheetSensitivityLabelpropCount = 0;
            if (mSExcelSetWorksheetSensitivityLabelHandle != null)
            {
                mSExcelSetWorksheetSensitivityLabel["Handle"] = ExpressionConverter.ConvertO(mSExcelSetWorksheetSensitivityLabelHandle);
                mSExcelSetWorksheetSensitivityLabelpropCount++;
            }

            if (mSExcelSetWorksheetSensitivityLabelWorkbookName != null)
            {
                mSExcelSetWorksheetSensitivityLabel["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelSetWorksheetSensitivityLabelWorkbookName);
                mSExcelSetWorksheetSensitivityLabelpropCount++;
            }

            mSExcelSetWorksheetSensitivityLabelpropCount++;
            mSExcelSetWorksheetSensitivityLabel["AssignmentMethod"] = ExpressionConverter.ConvertO(mSExcelSetWorksheetSensitivityLabelAssignmentMethod);
            mSExcelSetWorksheetSensitivityLabelpropCount++;
            mSExcelSetWorksheetSensitivityLabel["LabelId"] = ExpressionConverter.ConvertO(mSExcelSetWorksheetSensitivityLabelLabelId);
            if (mSExcelSetWorksheetSensitivityLabelLabelName != null)
            {
                mSExcelSetWorksheetSensitivityLabel["LabelName"] = ExpressionConverter.ConvertO(mSExcelSetWorksheetSensitivityLabelLabelName);
                mSExcelSetWorksheetSensitivityLabelpropCount++;
            }

            if (mSExcelSetWorksheetSensitivityLabelSiteId != null)
            {
                mSExcelSetWorksheetSensitivityLabel["SiteId"] = ExpressionConverter.ConvertO(mSExcelSetWorksheetSensitivityLabelSiteId);
                mSExcelSetWorksheetSensitivityLabelpropCount++;
            }

            if (mSExcelSetWorksheetSensitivityLabelJustification != null)
            {
                mSExcelSetWorksheetSensitivityLabel["Justification"] = ExpressionConverter.ConvertO(mSExcelSetWorksheetSensitivityLabelJustification);
                mSExcelSetWorksheetSensitivityLabelpropCount++;
            }

            mSExcelSetWorksheetSensitivityLabelpropCount++;
            mSExcelSetWorksheetSensitivityLabel["Workflow"] = ExpressionConverter.ConvertO(mSExcelSetWorksheetSensitivityLabelWorkflow);
            if (mSExcelSetWorksheetSensitivityLabelpropCount > 0)
            {
                callPayload.Body = mSExcelSetWorksheetSensitivityLabel;
            }

            return new ApiConnectionAction<MSExcelSetWorksheetSensitivityLabelResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetWorksheetSensitivityLabelResponse> MSExcelGetWorksheetSensitivityLabel(Expression<Func<string>> mSExcelGetWorksheetSensitivityLabelWorkflow, Expression<Func<int>> mSExcelGetWorksheetSensitivityLabelHandle = null, Expression<Func<string>> mSExcelGetWorksheetSensitivityLabelWorkbookName = null)
        {
            var apiCallPath = "/MSExcel/GetWorksheetSensitivityLabel";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelGetWorksheetSensitivityLabel = new JObject();
            var mSExcelGetWorksheetSensitivityLabelpropCount = 0;
            if (mSExcelGetWorksheetSensitivityLabelHandle != null)
            {
                mSExcelGetWorksheetSensitivityLabel["Handle"] = ExpressionConverter.ConvertO(mSExcelGetWorksheetSensitivityLabelHandle);
                mSExcelGetWorksheetSensitivityLabelpropCount++;
            }

            if (mSExcelGetWorksheetSensitivityLabelWorkbookName != null)
            {
                mSExcelGetWorksheetSensitivityLabel["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelGetWorksheetSensitivityLabelWorkbookName);
                mSExcelGetWorksheetSensitivityLabelpropCount++;
            }

            mSExcelGetWorksheetSensitivityLabelpropCount++;
            mSExcelGetWorksheetSensitivityLabel["Workflow"] = ExpressionConverter.ConvertO(mSExcelGetWorksheetSensitivityLabelWorkflow);
            if (mSExcelGetWorksheetSensitivityLabelpropCount > 0)
            {
                callPayload.Body = mSExcelGetWorksheetSensitivityLabel;
            }

            return new ApiConnectionAction<MSExcelGetWorksheetSensitivityLabelResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelWriteArrayResponse> MSExcelWriteArray(Expression<Func<string>> mSExcelWriteArrayCellReference, Expression<Func<string>> mSExcelWriteArrayArrayToWriteJSON, Expression<Func<mSExcelWriteArrayDirectionInput>> mSExcelWriteArrayDirection, Expression<Func<string>> mSExcelWriteArrayWorkflow, Expression<Func<int>> mSExcelWriteArrayHandle = null, Expression<Func<string>> mSExcelWriteArrayWorkbookName = null, Expression<Func<string>> mSExcelWriteArrayWorksheetName = null)
        {
            var apiCallPath = "/MSExcel/WriteArray";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelWriteArray = new JObject();
            var mSExcelWriteArraypropCount = 0;
            if (mSExcelWriteArrayHandle != null)
            {
                mSExcelWriteArray["Handle"] = ExpressionConverter.ConvertO(mSExcelWriteArrayHandle);
                mSExcelWriteArraypropCount++;
            }

            if (mSExcelWriteArrayWorkbookName != null)
            {
                mSExcelWriteArray["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelWriteArrayWorkbookName);
                mSExcelWriteArraypropCount++;
            }

            if (mSExcelWriteArrayWorksheetName != null)
            {
                mSExcelWriteArray["WorksheetName"] = ExpressionConverter.ConvertO(mSExcelWriteArrayWorksheetName);
                mSExcelWriteArraypropCount++;
            }

            mSExcelWriteArraypropCount++;
            mSExcelWriteArray["CellReference"] = ExpressionConverter.ConvertO(mSExcelWriteArrayCellReference);
            mSExcelWriteArraypropCount++;
            mSExcelWriteArray["ArrayToWriteJSON"] = ExpressionConverter.ConvertO(mSExcelWriteArrayArrayToWriteJSON);
            mSExcelWriteArraypropCount++;
            mSExcelWriteArray["Direction"] = ExpressionConverter.ConvertO(mSExcelWriteArrayDirection);
            mSExcelWriteArraypropCount++;
            mSExcelWriteArray["Workflow"] = ExpressionConverter.ConvertO(mSExcelWriteArrayWorkflow);
            if (mSExcelWriteArraypropCount > 0)
            {
                callPayload.Body = mSExcelWriteArray;
            }

            return new ApiConnectionAction<MSExcelWriteArrayResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookCreateInstanceResponse> MSOutlookCreateInstance(Expression<Func<string>> mSOutlookCreateInstanceWorkflow, Expression<Func<string>> mSOutlookCreateInstanceProfileName = null, Expression<Func<bool>> mSOutlookCreateInstanceShowOutlook = null)
        {
            var apiCallPath = "/MSOutlook/CreateInstance";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSOutlookCreateInstance = new JObject();
            var mSOutlookCreateInstancepropCount = 0;
            if (mSOutlookCreateInstanceProfileName != null)
            {
                mSOutlookCreateInstance["ProfileName"] = ExpressionConverter.ConvertO(mSOutlookCreateInstanceProfileName);
                mSOutlookCreateInstancepropCount++;
            }

            if (mSOutlookCreateInstanceShowOutlook != null)
            {
                mSOutlookCreateInstance["ShowOutlook"] = ExpressionConverter.ConvertO(mSOutlookCreateInstanceShowOutlook);
                mSOutlookCreateInstancepropCount++;
            }

            mSOutlookCreateInstancepropCount++;
            mSOutlookCreateInstance["Workflow"] = ExpressionConverter.ConvertO(mSOutlookCreateInstanceWorkflow);
            if (mSOutlookCreateInstancepropCount > 0)
            {
                callPayload.Body = mSOutlookCreateInstance;
            }

            return new ApiConnectionAction<MSOutlookCreateInstanceResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSOutlookCloseInstance(Expression<Func<string>> mSOutlookCloseInstanceWorkflow, Expression<Func<int>> mSOutlookCloseInstanceSecondsToWaitForProcessToClose = null)
        {
            var apiCallPath = "/MSOutlook/CloseInstance";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSOutlookCloseInstance = new JObject();
            var mSOutlookCloseInstancepropCount = 0;
            if (mSOutlookCloseInstanceSecondsToWaitForProcessToClose != null)
            {
                mSOutlookCloseInstance["SecondsToWaitForProcessToClose"] = ExpressionConverter.ConvertO(mSOutlookCloseInstanceSecondsToWaitForProcessToClose);
                mSOutlookCloseInstancepropCount++;
            }

            mSOutlookCloseInstancepropCount++;
            mSOutlookCloseInstance["Workflow"] = ExpressionConverter.ConvertO(mSOutlookCloseInstanceWorkflow);
            if (mSOutlookCloseInstancepropCount > 0)
            {
                callPayload.Body = mSOutlookCloseInstance;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSOutlookCloseInstanceUsingWindow(Expression<Func<string>> mSOutlookCloseInstanceUsingWindowWorkflow, Expression<Func<bool>> mSOutlookCloseInstanceUsingWindowUseNativeWindow = null, Expression<Func<bool>> mSOutlookCloseInstanceUsingWindowUseUIA = null, Expression<Func<int>> mSOutlookCloseInstanceUsingWindowSecondsToWaitForProcessToClose = null)
        {
            var apiCallPath = "/MSOutlook/CloseInstanceUsingWindow";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSOutlookCloseInstanceUsingWindow = new JObject();
            var mSOutlookCloseInstanceUsingWindowpropCount = 0;
            if (mSOutlookCloseInstanceUsingWindowUseNativeWindow != null)
            {
                mSOutlookCloseInstanceUsingWindow["UseNativeWindow"] = ExpressionConverter.ConvertO(mSOutlookCloseInstanceUsingWindowUseNativeWindow);
                mSOutlookCloseInstanceUsingWindowpropCount++;
            }

            if (mSOutlookCloseInstanceUsingWindowUseUIA != null)
            {
                mSOutlookCloseInstanceUsingWindow["UseUIA"] = ExpressionConverter.ConvertO(mSOutlookCloseInstanceUsingWindowUseUIA);
                mSOutlookCloseInstanceUsingWindowpropCount++;
            }

            if (mSOutlookCloseInstanceUsingWindowSecondsToWaitForProcessToClose != null)
            {
                mSOutlookCloseInstanceUsingWindow["SecondsToWaitForProcessToClose"] = ExpressionConverter.ConvertO(mSOutlookCloseInstanceUsingWindowSecondsToWaitForProcessToClose);
                mSOutlookCloseInstanceUsingWindowpropCount++;
            }

            mSOutlookCloseInstanceUsingWindowpropCount++;
            mSOutlookCloseInstanceUsingWindow["Workflow"] = ExpressionConverter.ConvertO(mSOutlookCloseInstanceUsingWindowWorkflow);
            if (mSOutlookCloseInstanceUsingWindowpropCount > 0)
            {
                callPayload.Body = mSOutlookCloseInstanceUsingWindow;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookAttachToExistingInstanceResponse> MSOutlookAttachToExistingInstance(Expression<Func<string>> mSOutlookAttachToExistingInstanceWorkflow, Expression<Func<bool>> mSOutlookAttachToExistingInstanceToggleWindow = null, Expression<Func<bool>> mSOutlookAttachToExistingInstanceToggleUsesGlobalLeftMouseClickAgent = null, Expression<Func<double>> mSOutlookAttachToExistingInstanceToggleDelay = null)
        {
            var apiCallPath = "/MSOutlook/MSOutlookAttachToExistingInstance";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSOutlookAttachToExistingInstance = new JObject();
            var mSOutlookAttachToExistingInstancepropCount = 0;
            if (mSOutlookAttachToExistingInstanceToggleWindow != null)
            {
                mSOutlookAttachToExistingInstance["ToggleWindow"] = ExpressionConverter.ConvertO(mSOutlookAttachToExistingInstanceToggleWindow);
                mSOutlookAttachToExistingInstancepropCount++;
            }

            if (mSOutlookAttachToExistingInstanceToggleUsesGlobalLeftMouseClickAgent != null)
            {
                mSOutlookAttachToExistingInstance["ToggleUsesGlobalLeftMouseClickAgent"] = ExpressionConverter.ConvertO(mSOutlookAttachToExistingInstanceToggleUsesGlobalLeftMouseClickAgent);
                mSOutlookAttachToExistingInstancepropCount++;
            }

            if (mSOutlookAttachToExistingInstanceToggleDelay != null)
            {
                mSOutlookAttachToExistingInstance["ToggleDelay"] = ExpressionConverter.ConvertO(mSOutlookAttachToExistingInstanceToggleDelay);
                mSOutlookAttachToExistingInstancepropCount++;
            }

            mSOutlookAttachToExistingInstancepropCount++;
            mSOutlookAttachToExistingInstance["Workflow"] = ExpressionConverter.ConvertO(mSOutlookAttachToExistingInstanceWorkflow);
            if (mSOutlookAttachToExistingInstancepropCount > 0)
            {
                callPayload.Body = mSOutlookAttachToExistingInstance;
            }

            return new ApiConnectionAction<MSOutlookAttachToExistingInstanceResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookIsConnectedResponse> MSOutlookIsConnected(Expression<Func<string>> mSOutlookIsConnectedWorkflow)
        {
            var apiCallPath = "/MSOutlook/IsOutlookConnected";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSOutlookIsConnected = new JObject();
            var mSOutlookIsConnectedpropCount = 0;
            mSOutlookIsConnectedpropCount++;
            mSOutlookIsConnected["Workflow"] = ExpressionConverter.ConvertO(mSOutlookIsConnectedWorkflow);
            if (mSOutlookIsConnectedpropCount > 0)
            {
                callPayload.Body = mSOutlookIsConnected;
            }

            return new ApiConnectionAction<MSOutlookIsConnectedResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSOutlookShow(Expression<Func<string>> mSOutlookShowWorkflow)
        {
            var apiCallPath = "/MSOutlook/ShowOutlook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSOutlookShow = new JObject();
            var mSOutlookShowpropCount = 0;
            mSOutlookShowpropCount++;
            mSOutlookShow["Workflow"] = ExpressionConverter.ConvertO(mSOutlookShowWorkflow);
            if (mSOutlookShowpropCount > 0)
            {
                callPayload.Body = mSOutlookShow;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookGetNameSpaceInformationResponse> MSOutlookGetNameSpaceInformation(Expression<Func<string>> mSOutlookGetNameSpaceInformationWorkflow)
        {
            var apiCallPath = "/MSOutlook/GetNameSpaceInformation";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSOutlookGetNameSpaceInformation = new JObject();
            var mSOutlookGetNameSpaceInformationpropCount = 0;
            mSOutlookGetNameSpaceInformationpropCount++;
            mSOutlookGetNameSpaceInformation["Workflow"] = ExpressionConverter.ConvertO(mSOutlookGetNameSpaceInformationWorkflow);
            if (mSOutlookGetNameSpaceInformationpropCount > 0)
            {
                callPayload.Body = mSOutlookGetNameSpaceInformation;
            }

            return new ApiConnectionAction<MSOutlookGetNameSpaceInformationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookGetMailFoldersResponse> MSOutlookGetMailFolders(Expression<Func<string>> mSOutlookGetMailFoldersWorkflow, Expression<Func<string>> mSOutlookGetMailFoldersFolderPath = null, Expression<Func<bool>> mSOutlookGetMailFoldersSubFolders = null)
        {
            var apiCallPath = "/MSOutlook/GetMailFolders";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSOutlookGetMailFolders = new JObject();
            var mSOutlookGetMailFolderspropCount = 0;
            if (mSOutlookGetMailFoldersFolderPath != null)
            {
                mSOutlookGetMailFolders["FolderPath"] = ExpressionConverter.ConvertO(mSOutlookGetMailFoldersFolderPath);
                mSOutlookGetMailFolderspropCount++;
            }

            if (mSOutlookGetMailFoldersSubFolders != null)
            {
                mSOutlookGetMailFolders["SubFolders"] = ExpressionConverter.ConvertO(mSOutlookGetMailFoldersSubFolders);
                mSOutlookGetMailFolderspropCount++;
            }

            mSOutlookGetMailFolderspropCount++;
            mSOutlookGetMailFolders["Workflow"] = ExpressionConverter.ConvertO(mSOutlookGetMailFoldersWorkflow);
            if (mSOutlookGetMailFolderspropCount > 0)
            {
                callPayload.Body = mSOutlookGetMailFolders;
            }

            return new ApiConnectionAction<MSOutlookGetMailFoldersResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSOutlookMarkEmailAsRead(Expression<Func<string>> mSOutlookMarkEmailAsReadEntryID, Expression<Func<string>> mSOutlookMarkEmailAsReadWorkflow, Expression<Func<bool>> mSOutlookMarkEmailAsReadRead = null)
        {
            var apiCallPath = "/MSOutlook/MarkEmailAsRead";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSOutlookMarkEmailAsRead = new JObject();
            var mSOutlookMarkEmailAsReadpropCount = 0;
            mSOutlookMarkEmailAsReadpropCount++;
            mSOutlookMarkEmailAsRead["EntryID"] = ExpressionConverter.ConvertO(mSOutlookMarkEmailAsReadEntryID);
            if (mSOutlookMarkEmailAsReadRead != null)
            {
                mSOutlookMarkEmailAsRead["Read"] = ExpressionConverter.ConvertO(mSOutlookMarkEmailAsReadRead);
                mSOutlookMarkEmailAsReadpropCount++;
            }

            mSOutlookMarkEmailAsReadpropCount++;
            mSOutlookMarkEmailAsRead["Workflow"] = ExpressionConverter.ConvertO(mSOutlookMarkEmailAsReadWorkflow);
            if (mSOutlookMarkEmailAsReadpropCount > 0)
            {
                callPayload.Body = mSOutlookMarkEmailAsRead;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookGetEmailBodyResponse> MSOutlookGetEmailBody(Expression<Func<string>> mSOutlookGetEmailBodyEntryID, Expression<Func<string>> mSOutlookGetEmailBodyWorkflow, Expression<Func<bool>> mSOutlookGetEmailBodyClickAllowButtonIfRequired = null)
        {
            var apiCallPath = "/MSOutlook/GetEmailBody";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSOutlookGetEmailBody = new JObject();
            var mSOutlookGetEmailBodypropCount = 0;
            mSOutlookGetEmailBodypropCount++;
            mSOutlookGetEmailBody["EntryID"] = ExpressionConverter.ConvertO(mSOutlookGetEmailBodyEntryID);
            if (mSOutlookGetEmailBodyClickAllowButtonIfRequired != null)
            {
                mSOutlookGetEmailBody["ClickAllowButtonIfRequired"] = ExpressionConverter.ConvertO(mSOutlookGetEmailBodyClickAllowButtonIfRequired);
                mSOutlookGetEmailBodypropCount++;
            }

            mSOutlookGetEmailBodypropCount++;
            mSOutlookGetEmailBody["Workflow"] = ExpressionConverter.ConvertO(mSOutlookGetEmailBodyWorkflow);
            if (mSOutlookGetEmailBodypropCount > 0)
            {
                callPayload.Body = mSOutlookGetEmailBody;
            }

            return new ApiConnectionAction<MSOutlookGetEmailBodyResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookGetEmailAttachmentFilenamesResponse> MSOutlookGetEmailAttachmentFilenames(Expression<Func<string>> mSOutlookGetEmailAttachmentFilenamesEntryID, Expression<Func<string>> mSOutlookGetEmailAttachmentFilenamesWorkflow, Expression<Func<bool>> mSOutlookGetEmailAttachmentFilenamesClickAllowButtonIfRequired = null)
        {
            var apiCallPath = "/MSOutlook/GetEmailAttachmentFilenames";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSOutlookGetEmailAttachmentFilenames = new JObject();
            var mSOutlookGetEmailAttachmentFilenamespropCount = 0;
            mSOutlookGetEmailAttachmentFilenamespropCount++;
            mSOutlookGetEmailAttachmentFilenames["EntryID"] = ExpressionConverter.ConvertO(mSOutlookGetEmailAttachmentFilenamesEntryID);
            if (mSOutlookGetEmailAttachmentFilenamesClickAllowButtonIfRequired != null)
            {
                mSOutlookGetEmailAttachmentFilenames["ClickAllowButtonIfRequired"] = ExpressionConverter.ConvertO(mSOutlookGetEmailAttachmentFilenamesClickAllowButtonIfRequired);
                mSOutlookGetEmailAttachmentFilenamespropCount++;
            }

            mSOutlookGetEmailAttachmentFilenamespropCount++;
            mSOutlookGetEmailAttachmentFilenames["Workflow"] = ExpressionConverter.ConvertO(mSOutlookGetEmailAttachmentFilenamesWorkflow);
            if (mSOutlookGetEmailAttachmentFilenamespropCount > 0)
            {
                callPayload.Body = mSOutlookGetEmailAttachmentFilenames;
            }

            return new ApiConnectionAction<MSOutlookGetEmailAttachmentFilenamesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookSaveEmailAttachmentsAsFileResponse> MSOutlookSaveEmailAttachmentsAsFile(Expression<Func<string>> mSOutlookSaveEmailAttachmentsAsFileEntryID, Expression<Func<string>> mSOutlookSaveEmailAttachmentsAsFileWorkflow, Expression<Func<string>> mSOutlookSaveEmailAttachmentsAsFileSaveFolderPath = null, Expression<Func<bool>> mSOutlookSaveEmailAttachmentsAsFileCreateFolder = null, Expression<Func<string>> mSOutlookSaveEmailAttachmentsAsFileOnlySaveAttachmentsMatchingWildcard = null, Expression<Func<bool>> mSOutlookSaveEmailAttachmentsAsFileSaveHiddenAttachments = null, Expression<Func<bool>> mSOutlookSaveEmailAttachmentsAsFileClickAllowButtonIfRequired = null)
        {
            var apiCallPath = "/MSOutlook/SaveEmailAttachmentsAsFile";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSOutlookSaveEmailAttachmentsAsFile = new JObject();
            var mSOutlookSaveEmailAttachmentsAsFilepropCount = 0;
            mSOutlookSaveEmailAttachmentsAsFilepropCount++;
            mSOutlookSaveEmailAttachmentsAsFile["EntryID"] = ExpressionConverter.ConvertO(mSOutlookSaveEmailAttachmentsAsFileEntryID);
            if (mSOutlookSaveEmailAttachmentsAsFileSaveFolderPath != null)
            {
                mSOutlookSaveEmailAttachmentsAsFile["SaveFolderPath"] = ExpressionConverter.ConvertO(mSOutlookSaveEmailAttachmentsAsFileSaveFolderPath);
                mSOutlookSaveEmailAttachmentsAsFilepropCount++;
            }

            if (mSOutlookSaveEmailAttachmentsAsFileCreateFolder != null)
            {
                mSOutlookSaveEmailAttachmentsAsFile["CreateFolder"] = ExpressionConverter.ConvertO(mSOutlookSaveEmailAttachmentsAsFileCreateFolder);
                mSOutlookSaveEmailAttachmentsAsFilepropCount++;
            }

            if (mSOutlookSaveEmailAttachmentsAsFileOnlySaveAttachmentsMatchingWildcard != null)
            {
                mSOutlookSaveEmailAttachmentsAsFile["OnlySaveAttachmentsMatchingWildcard"] = ExpressionConverter.ConvertO(mSOutlookSaveEmailAttachmentsAsFileOnlySaveAttachmentsMatchingWildcard);
                mSOutlookSaveEmailAttachmentsAsFilepropCount++;
            }

            if (mSOutlookSaveEmailAttachmentsAsFileSaveHiddenAttachments != null)
            {
                mSOutlookSaveEmailAttachmentsAsFile["SaveHiddenAttachments"] = ExpressionConverter.ConvertO(mSOutlookSaveEmailAttachmentsAsFileSaveHiddenAttachments);
                mSOutlookSaveEmailAttachmentsAsFilepropCount++;
            }

            if (mSOutlookSaveEmailAttachmentsAsFileClickAllowButtonIfRequired != null)
            {
                mSOutlookSaveEmailAttachmentsAsFile["ClickAllowButtonIfRequired"] = ExpressionConverter.ConvertO(mSOutlookSaveEmailAttachmentsAsFileClickAllowButtonIfRequired);
                mSOutlookSaveEmailAttachmentsAsFilepropCount++;
            }

            mSOutlookSaveEmailAttachmentsAsFilepropCount++;
            mSOutlookSaveEmailAttachmentsAsFile["Workflow"] = ExpressionConverter.ConvertO(mSOutlookSaveEmailAttachmentsAsFileWorkflow);
            if (mSOutlookSaveEmailAttachmentsAsFilepropCount > 0)
            {
                callPayload.Body = mSOutlookSaveEmailAttachmentsAsFile;
            }

            return new ApiConnectionAction<MSOutlookSaveEmailAttachmentsAsFileResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSOutlookDeleteEmail(Expression<Func<string>> mSOutlookDeleteEmailEntryID, Expression<Func<string>> mSOutlookDeleteEmailWorkflow)
        {
            var apiCallPath = "/MSOutlook/DeleteEmail";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSOutlookDeleteEmail = new JObject();
            var mSOutlookDeleteEmailpropCount = 0;
            mSOutlookDeleteEmailpropCount++;
            mSOutlookDeleteEmail["EntryID"] = ExpressionConverter.ConvertO(mSOutlookDeleteEmailEntryID);
            mSOutlookDeleteEmailpropCount++;
            mSOutlookDeleteEmail["Workflow"] = ExpressionConverter.ConvertO(mSOutlookDeleteEmailWorkflow);
            if (mSOutlookDeleteEmailpropCount > 0)
            {
                callPayload.Body = mSOutlookDeleteEmail;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSOutlookMoveEmail(Expression<Func<string>> mSOutlookMoveEmailEntryID, Expression<Func<string>> mSOutlookMoveEmailWorkflow, Expression<Func<string>> mSOutlookMoveEmailDestinationFolder = null)
        {
            var apiCallPath = "/MSOutlook/MoveEmail";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSOutlookMoveEmail = new JObject();
            var mSOutlookMoveEmailpropCount = 0;
            mSOutlookMoveEmailpropCount++;
            mSOutlookMoveEmail["EntryID"] = ExpressionConverter.ConvertO(mSOutlookMoveEmailEntryID);
            if (mSOutlookMoveEmailDestinationFolder != null)
            {
                mSOutlookMoveEmail["DestinationFolder"] = ExpressionConverter.ConvertO(mSOutlookMoveEmailDestinationFolder);
                mSOutlookMoveEmailpropCount++;
            }

            mSOutlookMoveEmailpropCount++;
            mSOutlookMoveEmail["Workflow"] = ExpressionConverter.ConvertO(mSOutlookMoveEmailWorkflow);
            if (mSOutlookMoveEmailpropCount > 0)
            {
                callPayload.Body = mSOutlookMoveEmail;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSOutlookSendEmail(Expression<Func<string>> mSOutlookSendEmailWorkflow, Expression<Func<string>> mSOutlookSendEmailTo = null, Expression<Func<string>> mSOutlookSendEmailCC = null, Expression<Func<string>> mSOutlookSendEmailBCC = null, Expression<Func<string>> mSOutlookSendEmailSubject = null, Expression<Func<mSOutlookSendEmailBodyFormatInput>> mSOutlookSendEmailBodyFormat = null, Expression<Func<string>> mSOutlookSendEmailBody = null, Expression<Func<string>> mSOutlookSendEmailHTMLBody = null, Expression<Func<string>> mSOutlookSendEmailRTFBody = null, Expression<Func<string>> mSOutlookSendEmailAttachmentFilenamesJSON = null, Expression<Func<bool>> mSOutlookSendEmailDontSendIfAttachmentFilenameMissing = null, Expression<Func<bool>> mSOutlookSendEmailClickAllowButtonIfRequired = null, Expression<Func<string>> mSOutlookSendEmailVotingOptions = null, Expression<Func<string>> mSOutlookSendEmailSendAsSMTPAddress = null, Expression<Func<bool>> mSOutlookSendEmailBodyContainsStoredPassword = null)
        {
            var apiCallPath = "/MSOutlook/SendEmail";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSOutlookSendEmail = new JObject();
            var mSOutlookSendEmailpropCount = 0;
            if (mSOutlookSendEmailTo != null)
            {
                mSOutlookSendEmail["To"] = ExpressionConverter.ConvertO(mSOutlookSendEmailTo);
                mSOutlookSendEmailpropCount++;
            }

            if (mSOutlookSendEmailCC != null)
            {
                mSOutlookSendEmail["CC"] = ExpressionConverter.ConvertO(mSOutlookSendEmailCC);
                mSOutlookSendEmailpropCount++;
            }

            if (mSOutlookSendEmailBCC != null)
            {
                mSOutlookSendEmail["BCC"] = ExpressionConverter.ConvertO(mSOutlookSendEmailBCC);
                mSOutlookSendEmailpropCount++;
            }

            if (mSOutlookSendEmailSubject != null)
            {
                mSOutlookSendEmail["Subject"] = ExpressionConverter.ConvertO(mSOutlookSendEmailSubject);
                mSOutlookSendEmailpropCount++;
            }

            if (mSOutlookSendEmailBodyFormat != null)
            {
                mSOutlookSendEmail["BodyFormat"] = ExpressionConverter.ConvertO(mSOutlookSendEmailBodyFormat);
                mSOutlookSendEmailpropCount++;
            }

            if (mSOutlookSendEmailBody != null)
            {
                mSOutlookSendEmail["Body"] = ExpressionConverter.ConvertO(mSOutlookSendEmailBody);
                mSOutlookSendEmailpropCount++;
            }

            if (mSOutlookSendEmailHTMLBody != null)
            {
                mSOutlookSendEmail["HTMLBody"] = ExpressionConverter.ConvertO(mSOutlookSendEmailHTMLBody);
                mSOutlookSendEmailpropCount++;
            }

            if (mSOutlookSendEmailRTFBody != null)
            {
                mSOutlookSendEmail["RTFBody"] = ExpressionConverter.ConvertO(mSOutlookSendEmailRTFBody);
                mSOutlookSendEmailpropCount++;
            }

            if (mSOutlookSendEmailAttachmentFilenamesJSON != null)
            {
                mSOutlookSendEmail["AttachmentFilenamesJSON"] = ExpressionConverter.ConvertO(mSOutlookSendEmailAttachmentFilenamesJSON);
                mSOutlookSendEmailpropCount++;
            }

            if (mSOutlookSendEmailDontSendIfAttachmentFilenameMissing != null)
            {
                mSOutlookSendEmail["DontSendIfAttachmentFilenameMissing"] = ExpressionConverter.ConvertO(mSOutlookSendEmailDontSendIfAttachmentFilenameMissing);
                mSOutlookSendEmailpropCount++;
            }

            if (mSOutlookSendEmailClickAllowButtonIfRequired != null)
            {
                mSOutlookSendEmail["ClickAllowButtonIfRequired"] = ExpressionConverter.ConvertO(mSOutlookSendEmailClickAllowButtonIfRequired);
                mSOutlookSendEmailpropCount++;
            }

            if (mSOutlookSendEmailVotingOptions != null)
            {
                mSOutlookSendEmail["VotingOptions"] = ExpressionConverter.ConvertO(mSOutlookSendEmailVotingOptions);
                mSOutlookSendEmailpropCount++;
            }

            if (mSOutlookSendEmailSendAsSMTPAddress != null)
            {
                mSOutlookSendEmail["SendAsSMTPAddress"] = ExpressionConverter.ConvertO(mSOutlookSendEmailSendAsSMTPAddress);
                mSOutlookSendEmailpropCount++;
            }

            if (mSOutlookSendEmailBodyContainsStoredPassword != null)
            {
                mSOutlookSendEmail["BodyContainsStoredPassword"] = ExpressionConverter.ConvertO(mSOutlookSendEmailBodyContainsStoredPassword);
                mSOutlookSendEmailpropCount++;
            }

            mSOutlookSendEmailpropCount++;
            mSOutlookSendEmail["Workflow"] = ExpressionConverter.ConvertO(mSOutlookSendEmailWorkflow);
            if (mSOutlookSendEmailpropCount > 0)
            {
                callPayload.Body = mSOutlookSendEmail;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSOutlookCreateMailFolder(Expression<Func<string>> mSOutlookCreateMailFolderWorkflow, Expression<Func<string>> mSOutlookCreateMailFolderParentFolderPath = null, Expression<Func<string>> mSOutlookCreateMailFolderNewFolderName = null)
        {
            var apiCallPath = "/MSOutlook/CreateMailFolder";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSOutlookCreateMailFolder = new JObject();
            var mSOutlookCreateMailFolderpropCount = 0;
            if (mSOutlookCreateMailFolderParentFolderPath != null)
            {
                mSOutlookCreateMailFolder["ParentFolderPath"] = ExpressionConverter.ConvertO(mSOutlookCreateMailFolderParentFolderPath);
                mSOutlookCreateMailFolderpropCount++;
            }

            if (mSOutlookCreateMailFolderNewFolderName != null)
            {
                mSOutlookCreateMailFolder["NewFolderName"] = ExpressionConverter.ConvertO(mSOutlookCreateMailFolderNewFolderName);
                mSOutlookCreateMailFolderpropCount++;
            }

            mSOutlookCreateMailFolderpropCount++;
            mSOutlookCreateMailFolder["Workflow"] = ExpressionConverter.ConvertO(mSOutlookCreateMailFolderWorkflow);
            if (mSOutlookCreateMailFolderpropCount > 0)
            {
                callPayload.Body = mSOutlookCreateMailFolder;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSOutlookReplyToEmail(Expression<Func<string>> mSOutlookReplyToEmailEntryID, Expression<Func<string>> mSOutlookReplyToEmailWorkflow, Expression<Func<bool>> mSOutlookReplyToEmailReplyToAll = null, Expression<Func<mSOutlookReplyToEmailBodyFormatInput>> mSOutlookReplyToEmailBodyFormat = null, Expression<Func<string>> mSOutlookReplyToEmailBody = null, Expression<Func<string>> mSOutlookReplyToEmailHTMLBody = null, Expression<Func<string>> mSOutlookReplyToEmailRTFBody = null, Expression<Func<string>> mSOutlookReplyToEmailAttachmentFilenamesJSON = null, Expression<Func<bool>> mSOutlookReplyToEmailDontSendIfAttachmentFilenameMissing = null, Expression<Func<bool>> mSOutlookReplyToEmailClickAllowButtonIfRequired = null, Expression<Func<string>> mSOutlookReplyToEmailVotingOptions = null, Expression<Func<string>> mSOutlookReplyToEmailSendAsSMTPAddress = null, Expression<Func<bool>> mSOutlookReplyToEmailBodyContainsStoredPassword = null)
        {
            var apiCallPath = "/MSOutlook/ReplyToEmail";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSOutlookReplyToEmail = new JObject();
            var mSOutlookReplyToEmailpropCount = 0;
            mSOutlookReplyToEmailpropCount++;
            mSOutlookReplyToEmail["EntryID"] = ExpressionConverter.ConvertO(mSOutlookReplyToEmailEntryID);
            if (mSOutlookReplyToEmailReplyToAll != null)
            {
                mSOutlookReplyToEmail["ReplyToAll"] = ExpressionConverter.ConvertO(mSOutlookReplyToEmailReplyToAll);
                mSOutlookReplyToEmailpropCount++;
            }

            if (mSOutlookReplyToEmailBodyFormat != null)
            {
                mSOutlookReplyToEmail["BodyFormat"] = ExpressionConverter.ConvertO(mSOutlookReplyToEmailBodyFormat);
                mSOutlookReplyToEmailpropCount++;
            }

            if (mSOutlookReplyToEmailBody != null)
            {
                mSOutlookReplyToEmail["Body"] = ExpressionConverter.ConvertO(mSOutlookReplyToEmailBody);
                mSOutlookReplyToEmailpropCount++;
            }

            if (mSOutlookReplyToEmailHTMLBody != null)
            {
                mSOutlookReplyToEmail["HTMLBody"] = ExpressionConverter.ConvertO(mSOutlookReplyToEmailHTMLBody);
                mSOutlookReplyToEmailpropCount++;
            }

            if (mSOutlookReplyToEmailRTFBody != null)
            {
                mSOutlookReplyToEmail["RTFBody"] = ExpressionConverter.ConvertO(mSOutlookReplyToEmailRTFBody);
                mSOutlookReplyToEmailpropCount++;
            }

            if (mSOutlookReplyToEmailAttachmentFilenamesJSON != null)
            {
                mSOutlookReplyToEmail["AttachmentFilenamesJSON"] = ExpressionConverter.ConvertO(mSOutlookReplyToEmailAttachmentFilenamesJSON);
                mSOutlookReplyToEmailpropCount++;
            }

            if (mSOutlookReplyToEmailDontSendIfAttachmentFilenameMissing != null)
            {
                mSOutlookReplyToEmail["DontSendIfAttachmentFilenameMissing"] = ExpressionConverter.ConvertO(mSOutlookReplyToEmailDontSendIfAttachmentFilenameMissing);
                mSOutlookReplyToEmailpropCount++;
            }

            if (mSOutlookReplyToEmailClickAllowButtonIfRequired != null)
            {
                mSOutlookReplyToEmail["ClickAllowButtonIfRequired"] = ExpressionConverter.ConvertO(mSOutlookReplyToEmailClickAllowButtonIfRequired);
                mSOutlookReplyToEmailpropCount++;
            }

            if (mSOutlookReplyToEmailVotingOptions != null)
            {
                mSOutlookReplyToEmail["VotingOptions"] = ExpressionConverter.ConvertO(mSOutlookReplyToEmailVotingOptions);
                mSOutlookReplyToEmailpropCount++;
            }

            if (mSOutlookReplyToEmailSendAsSMTPAddress != null)
            {
                mSOutlookReplyToEmail["SendAsSMTPAddress"] = ExpressionConverter.ConvertO(mSOutlookReplyToEmailSendAsSMTPAddress);
                mSOutlookReplyToEmailpropCount++;
            }

            if (mSOutlookReplyToEmailBodyContainsStoredPassword != null)
            {
                mSOutlookReplyToEmail["BodyContainsStoredPassword"] = ExpressionConverter.ConvertO(mSOutlookReplyToEmailBodyContainsStoredPassword);
                mSOutlookReplyToEmailpropCount++;
            }

            mSOutlookReplyToEmailpropCount++;
            mSOutlookReplyToEmail["Workflow"] = ExpressionConverter.ConvertO(mSOutlookReplyToEmailWorkflow);
            if (mSOutlookReplyToEmailpropCount > 0)
            {
                callPayload.Body = mSOutlookReplyToEmail;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSOutlookForwardEmail(Expression<Func<string>> mSOutlookForwardEmailEntryID, Expression<Func<string>> mSOutlookForwardEmailWorkflow, Expression<Func<string>> mSOutlookForwardEmailTo = null, Expression<Func<string>> mSOutlookForwardEmailCC = null, Expression<Func<string>> mSOutlookForwardEmailBCC = null, Expression<Func<bool>> mSOutlookForwardEmailOverrideSubject = null, Expression<Func<string>> mSOutlookForwardEmailSubject = null, Expression<Func<bool>> mSOutlookForwardEmailOverrideBody = null, Expression<Func<mSOutlookForwardEmailBodyFormatInput>> mSOutlookForwardEmailBodyFormat = null, Expression<Func<string>> mSOutlookForwardEmailBody = null, Expression<Func<string>> mSOutlookForwardEmailHTMLBody = null, Expression<Func<string>> mSOutlookForwardEmailRTFBody = null, Expression<Func<bool>> mSOutlookForwardEmailClickAllowButtonIfRequired = null, Expression<Func<string>> mSOutlookForwardEmailVotingOptions = null, Expression<Func<string>> mSOutlookForwardEmailSendAsSMTPAddress = null, Expression<Func<bool>> mSOutlookForwardEmailIncludeExistingHiddenAttachments = null, Expression<Func<bool>> mSOutlookForwardEmailIncludeExistingVisibleAttachments = null, Expression<Func<string>> mSOutlookForwardEmailAttachmentFilenamesJSON = null, Expression<Func<bool>> mSOutlookForwardEmailDontSendIfAttachmentFilenameMissing = null, Expression<Func<bool>> mSOutlookForwardEmailBodyContainsStoredPassword = null)
        {
            var apiCallPath = "/MSOutlook/MSOutlookForwardEmail";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSOutlookForwardEmail = new JObject();
            var mSOutlookForwardEmailpropCount = 0;
            mSOutlookForwardEmailpropCount++;
            mSOutlookForwardEmail["EntryID"] = ExpressionConverter.ConvertO(mSOutlookForwardEmailEntryID);
            if (mSOutlookForwardEmailTo != null)
            {
                mSOutlookForwardEmail["To"] = ExpressionConverter.ConvertO(mSOutlookForwardEmailTo);
                mSOutlookForwardEmailpropCount++;
            }

            if (mSOutlookForwardEmailCC != null)
            {
                mSOutlookForwardEmail["CC"] = ExpressionConverter.ConvertO(mSOutlookForwardEmailCC);
                mSOutlookForwardEmailpropCount++;
            }

            if (mSOutlookForwardEmailBCC != null)
            {
                mSOutlookForwardEmail["BCC"] = ExpressionConverter.ConvertO(mSOutlookForwardEmailBCC);
                mSOutlookForwardEmailpropCount++;
            }

            if (mSOutlookForwardEmailOverrideSubject != null)
            {
                mSOutlookForwardEmail["OverrideSubject"] = ExpressionConverter.ConvertO(mSOutlookForwardEmailOverrideSubject);
                mSOutlookForwardEmailpropCount++;
            }

            if (mSOutlookForwardEmailSubject != null)
            {
                mSOutlookForwardEmail["Subject"] = ExpressionConverter.ConvertO(mSOutlookForwardEmailSubject);
                mSOutlookForwardEmailpropCount++;
            }

            if (mSOutlookForwardEmailOverrideBody != null)
            {
                mSOutlookForwardEmail["OverrideBody"] = ExpressionConverter.ConvertO(mSOutlookForwardEmailOverrideBody);
                mSOutlookForwardEmailpropCount++;
            }

            if (mSOutlookForwardEmailBodyFormat != null)
            {
                mSOutlookForwardEmail["BodyFormat"] = ExpressionConverter.ConvertO(mSOutlookForwardEmailBodyFormat);
                mSOutlookForwardEmailpropCount++;
            }

            if (mSOutlookForwardEmailBody != null)
            {
                mSOutlookForwardEmail["Body"] = ExpressionConverter.ConvertO(mSOutlookForwardEmailBody);
                mSOutlookForwardEmailpropCount++;
            }

            if (mSOutlookForwardEmailHTMLBody != null)
            {
                mSOutlookForwardEmail["HTMLBody"] = ExpressionConverter.ConvertO(mSOutlookForwardEmailHTMLBody);
                mSOutlookForwardEmailpropCount++;
            }

            if (mSOutlookForwardEmailRTFBody != null)
            {
                mSOutlookForwardEmail["RTFBody"] = ExpressionConverter.ConvertO(mSOutlookForwardEmailRTFBody);
                mSOutlookForwardEmailpropCount++;
            }

            if (mSOutlookForwardEmailClickAllowButtonIfRequired != null)
            {
                mSOutlookForwardEmail["ClickAllowButtonIfRequired"] = ExpressionConverter.ConvertO(mSOutlookForwardEmailClickAllowButtonIfRequired);
                mSOutlookForwardEmailpropCount++;
            }

            if (mSOutlookForwardEmailVotingOptions != null)
            {
                mSOutlookForwardEmail["VotingOptions"] = ExpressionConverter.ConvertO(mSOutlookForwardEmailVotingOptions);
                mSOutlookForwardEmailpropCount++;
            }

            if (mSOutlookForwardEmailSendAsSMTPAddress != null)
            {
                mSOutlookForwardEmail["SendAsSMTPAddress"] = ExpressionConverter.ConvertO(mSOutlookForwardEmailSendAsSMTPAddress);
                mSOutlookForwardEmailpropCount++;
            }

            if (mSOutlookForwardEmailIncludeExistingHiddenAttachments != null)
            {
                mSOutlookForwardEmail["IncludeExistingHiddenAttachments"] = ExpressionConverter.ConvertO(mSOutlookForwardEmailIncludeExistingHiddenAttachments);
                mSOutlookForwardEmailpropCount++;
            }

            if (mSOutlookForwardEmailIncludeExistingVisibleAttachments != null)
            {
                mSOutlookForwardEmail["IncludeExistingVisibleAttachments"] = ExpressionConverter.ConvertO(mSOutlookForwardEmailIncludeExistingVisibleAttachments);
                mSOutlookForwardEmailpropCount++;
            }

            if (mSOutlookForwardEmailAttachmentFilenamesJSON != null)
            {
                mSOutlookForwardEmail["AttachmentFilenamesJSON"] = ExpressionConverter.ConvertO(mSOutlookForwardEmailAttachmentFilenamesJSON);
                mSOutlookForwardEmailpropCount++;
            }

            if (mSOutlookForwardEmailDontSendIfAttachmentFilenameMissing != null)
            {
                mSOutlookForwardEmail["DontSendIfAttachmentFilenameMissing"] = ExpressionConverter.ConvertO(mSOutlookForwardEmailDontSendIfAttachmentFilenameMissing);
                mSOutlookForwardEmailpropCount++;
            }

            if (mSOutlookForwardEmailBodyContainsStoredPassword != null)
            {
                mSOutlookForwardEmail["BodyContainsStoredPassword"] = ExpressionConverter.ConvertO(mSOutlookForwardEmailBodyContainsStoredPassword);
                mSOutlookForwardEmailpropCount++;
            }

            mSOutlookForwardEmailpropCount++;
            mSOutlookForwardEmail["Workflow"] = ExpressionConverter.ConvertO(mSOutlookForwardEmailWorkflow);
            if (mSOutlookForwardEmailpropCount > 0)
            {
                callPayload.Body = mSOutlookForwardEmail;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookGetMAPIProfilesResponse> MSOutlookGetMAPIProfiles(Expression<Func<string>> mSOutlookGetMAPIProfilesWorkflow)
        {
            var apiCallPath = "/MSOutlook/GetMAPIProfiles";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSOutlookGetMAPIProfiles = new JObject();
            var mSOutlookGetMAPIProfilespropCount = 0;
            mSOutlookGetMAPIProfilespropCount++;
            mSOutlookGetMAPIProfiles["Workflow"] = ExpressionConverter.ConvertO(mSOutlookGetMAPIProfilesWorkflow);
            if (mSOutlookGetMAPIProfilespropCount > 0)
            {
                callPayload.Body = mSOutlookGetMAPIProfiles;
            }

            return new ApiConnectionAction<MSOutlookGetMAPIProfilesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookGetOutlookProcessIdResponse> MSOutlookGetOutlookProcessId(Expression<Func<string>> mSOutlookGetOutlookProcessIdWorkflow)
        {
            var apiCallPath = "/MSOutlook/GetOutlookProcessId";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSOutlookGetOutlookProcessId = new JObject();
            var mSOutlookGetOutlookProcessIdpropCount = 0;
            mSOutlookGetOutlookProcessIdpropCount++;
            mSOutlookGetOutlookProcessId["Workflow"] = ExpressionConverter.ConvertO(mSOutlookGetOutlookProcessIdWorkflow);
            if (mSOutlookGetOutlookProcessIdpropCount > 0)
            {
                callPayload.Body = mSOutlookGetOutlookProcessId;
            }

            return new ApiConnectionAction<MSOutlookGetOutlookProcessIdResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSOutlookBackgroundMonitorForAllowPopup(Expression<Func<string>> mSOutlookBackgroundMonitorForAllowPopupWorkflow, Expression<Func<int>> mSOutlookBackgroundMonitorForAllowPopupSecondsToWaitForDialog = null, Expression<Func<int>> mSOutlookBackgroundMonitorForAllowPopupSecondsToWaitForAllowButton = null, Expression<Func<int>> mSOutlookBackgroundMonitorForAllowPopupSecondsToWaitForAllowButtonToBeEnabled = null, Expression<Func<string>> mSOutlookBackgroundMonitorForAllowPopupOutlookAllowButtonName = null)
        {
            var apiCallPath = "/MSOutlook/BackgroundMonitorForAllowPopup";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSOutlookBackgroundMonitorForAllowPopup = new JObject();
            var mSOutlookBackgroundMonitorForAllowPopuppropCount = 0;
            if (mSOutlookBackgroundMonitorForAllowPopupSecondsToWaitForDialog != null)
            {
                mSOutlookBackgroundMonitorForAllowPopup["SecondsToWaitForDialog"] = ExpressionConverter.ConvertO(mSOutlookBackgroundMonitorForAllowPopupSecondsToWaitForDialog);
                mSOutlookBackgroundMonitorForAllowPopuppropCount++;
            }

            if (mSOutlookBackgroundMonitorForAllowPopupSecondsToWaitForAllowButton != null)
            {
                mSOutlookBackgroundMonitorForAllowPopup["SecondsToWaitForAllowButton"] = ExpressionConverter.ConvertO(mSOutlookBackgroundMonitorForAllowPopupSecondsToWaitForAllowButton);
                mSOutlookBackgroundMonitorForAllowPopuppropCount++;
            }

            if (mSOutlookBackgroundMonitorForAllowPopupSecondsToWaitForAllowButtonToBeEnabled != null)
            {
                mSOutlookBackgroundMonitorForAllowPopup["SecondsToWaitForAllowButtonToBeEnabled"] = ExpressionConverter.ConvertO(mSOutlookBackgroundMonitorForAllowPopupSecondsToWaitForAllowButtonToBeEnabled);
                mSOutlookBackgroundMonitorForAllowPopuppropCount++;
            }

            if (mSOutlookBackgroundMonitorForAllowPopupOutlookAllowButtonName != null)
            {
                mSOutlookBackgroundMonitorForAllowPopup["OutlookAllowButtonName"] = ExpressionConverter.ConvertO(mSOutlookBackgroundMonitorForAllowPopupOutlookAllowButtonName);
                mSOutlookBackgroundMonitorForAllowPopuppropCount++;
            }

            mSOutlookBackgroundMonitorForAllowPopuppropCount++;
            mSOutlookBackgroundMonitorForAllowPopup["Workflow"] = ExpressionConverter.ConvertO(mSOutlookBackgroundMonitorForAllowPopupWorkflow);
            if (mSOutlookBackgroundMonitorForAllowPopuppropCount > 0)
            {
                callPayload.Body = mSOutlookBackgroundMonitorForAllowPopup;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSOutlookSetAllowPopupDetails(Expression<Func<string>> mSOutlookSetAllowPopupDetailsWorkflow, Expression<Func<string>> mSOutlookSetAllowPopupDetailsOutlookAllowButtonName = null, Expression<Func<string>> mSOutlookSetAllowPopupDetailsOutlookAllowButtonAutomationId = null, Expression<Func<string>> mSOutlookSetAllowPopupDetailsOutlookAllowCheckboxAutomationId = null)
        {
            var apiCallPath = "/MSOutlook/MSOutlookSetAllowPopupDetails";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSOutlookSetAllowPopupDetails = new JObject();
            var mSOutlookSetAllowPopupDetailspropCount = 0;
            if (mSOutlookSetAllowPopupDetailsOutlookAllowButtonName != null)
            {
                mSOutlookSetAllowPopupDetails["OutlookAllowButtonName"] = ExpressionConverter.ConvertO(mSOutlookSetAllowPopupDetailsOutlookAllowButtonName);
                mSOutlookSetAllowPopupDetailspropCount++;
            }

            if (mSOutlookSetAllowPopupDetailsOutlookAllowButtonAutomationId != null)
            {
                mSOutlookSetAllowPopupDetails["OutlookAllowButtonAutomationId"] = ExpressionConverter.ConvertO(mSOutlookSetAllowPopupDetailsOutlookAllowButtonAutomationId);
                mSOutlookSetAllowPopupDetailspropCount++;
            }

            if (mSOutlookSetAllowPopupDetailsOutlookAllowCheckboxAutomationId != null)
            {
                mSOutlookSetAllowPopupDetails["OutlookAllowCheckboxAutomationId"] = ExpressionConverter.ConvertO(mSOutlookSetAllowPopupDetailsOutlookAllowCheckboxAutomationId);
                mSOutlookSetAllowPopupDetailspropCount++;
            }

            mSOutlookSetAllowPopupDetailspropCount++;
            mSOutlookSetAllowPopupDetails["Workflow"] = ExpressionConverter.ConvertO(mSOutlookSetAllowPopupDetailsWorkflow);
            if (mSOutlookSetAllowPopupDetailspropCount > 0)
            {
                callPayload.Body = mSOutlookSetAllowPopupDetails;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookExecuteCommandBarObjectResponse> MSOutlookExecuteCommandBarObject(Expression<Func<string>> mSOutlookExecuteCommandBarObjectObjectId, Expression<Func<string>> mSOutlookExecuteCommandBarObjectWorkflow, Expression<Func<bool>> mSOutlookExecuteCommandBarObjectRunInBackground = null)
        {
            var apiCallPath = "/MSOutlook/MSOutlookExecuteCommandBarObject";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSOutlookExecuteCommandBarObject = new JObject();
            var mSOutlookExecuteCommandBarObjectpropCount = 0;
            mSOutlookExecuteCommandBarObjectpropCount++;
            mSOutlookExecuteCommandBarObject["ObjectId"] = ExpressionConverter.ConvertO(mSOutlookExecuteCommandBarObjectObjectId);
            if (mSOutlookExecuteCommandBarObjectRunInBackground != null)
            {
                mSOutlookExecuteCommandBarObject["RunInBackground"] = ExpressionConverter.ConvertO(mSOutlookExecuteCommandBarObjectRunInBackground);
                mSOutlookExecuteCommandBarObjectpropCount++;
            }

            mSOutlookExecuteCommandBarObjectpropCount++;
            mSOutlookExecuteCommandBarObject["Workflow"] = ExpressionConverter.ConvertO(mSOutlookExecuteCommandBarObjectWorkflow);
            if (mSOutlookExecuteCommandBarObjectpropCount > 0)
            {
                callPayload.Body = mSOutlookExecuteCommandBarObject;
            }

            return new ApiConnectionAction<MSOutlookExecuteCommandBarObjectResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookGetEmailsResponse> MSOutlookGetEmails(Expression<Func<string>> mSOutlookGetEmailsWorkflow, Expression<Func<string>> mSOutlookGetEmailsFolderPath = null, Expression<Func<bool>> mSOutlookGetEmailsSearchRead = null, Expression<Func<bool>> mSOutlookGetEmailsSearchUnread = null, Expression<Func<string>> mSOutlookGetEmailsSearchSubject = null, Expression<Func<string>> mSOutlookGetEmailsSearchFromSMTP = null, Expression<Func<string>> mSOutlookGetEmailsSearchFromName = null, Expression<Func<string>> mSOutlookGetEmailsSearchQuery = null, Expression<Func<int>> mSOutlookGetEmailsSearchMaxAgeInDays = null, Expression<Func<string>> mSOutlookGetEmailsSearchStartDateTimeAsString = null, Expression<Func<string>> mSOutlookGetEmailsSearchEndDateTimeAsString = null, Expression<Func<int>> mSOutlookGetEmailsMaxResultsToReturn = null, Expression<Func<bool>> mSOutlookGetEmailsClickAllowButtonIfRequired = null)
        {
            var apiCallPath = "/MSOutlook/GetEmails";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSOutlookGetEmails = new JObject();
            var mSOutlookGetEmailspropCount = 0;
            if (mSOutlookGetEmailsFolderPath != null)
            {
                mSOutlookGetEmails["FolderPath"] = ExpressionConverter.ConvertO(mSOutlookGetEmailsFolderPath);
                mSOutlookGetEmailspropCount++;
            }

            if (mSOutlookGetEmailsSearchRead != null)
            {
                mSOutlookGetEmails["SearchRead"] = ExpressionConverter.ConvertO(mSOutlookGetEmailsSearchRead);
                mSOutlookGetEmailspropCount++;
            }

            if (mSOutlookGetEmailsSearchUnread != null)
            {
                mSOutlookGetEmails["SearchUnread"] = ExpressionConverter.ConvertO(mSOutlookGetEmailsSearchUnread);
                mSOutlookGetEmailspropCount++;
            }

            if (mSOutlookGetEmailsSearchSubject != null)
            {
                mSOutlookGetEmails["SearchSubject"] = ExpressionConverter.ConvertO(mSOutlookGetEmailsSearchSubject);
                mSOutlookGetEmailspropCount++;
            }

            if (mSOutlookGetEmailsSearchFromSMTP != null)
            {
                mSOutlookGetEmails["SearchFromSMTP"] = ExpressionConverter.ConvertO(mSOutlookGetEmailsSearchFromSMTP);
                mSOutlookGetEmailspropCount++;
            }

            if (mSOutlookGetEmailsSearchFromName != null)
            {
                mSOutlookGetEmails["SearchFromName"] = ExpressionConverter.ConvertO(mSOutlookGetEmailsSearchFromName);
                mSOutlookGetEmailspropCount++;
            }

            if (mSOutlookGetEmailsSearchQuery != null)
            {
                mSOutlookGetEmails["SearchQuery"] = ExpressionConverter.ConvertO(mSOutlookGetEmailsSearchQuery);
                mSOutlookGetEmailspropCount++;
            }

            if (mSOutlookGetEmailsSearchMaxAgeInDays != null)
            {
                mSOutlookGetEmails["SearchMaxAgeInDays"] = ExpressionConverter.ConvertO(mSOutlookGetEmailsSearchMaxAgeInDays);
                mSOutlookGetEmailspropCount++;
            }

            if (mSOutlookGetEmailsSearchStartDateTimeAsString != null)
            {
                mSOutlookGetEmails["SearchStartDateTimeAsString"] = ExpressionConverter.ConvertO(mSOutlookGetEmailsSearchStartDateTimeAsString);
                mSOutlookGetEmailspropCount++;
            }

            if (mSOutlookGetEmailsSearchEndDateTimeAsString != null)
            {
                mSOutlookGetEmails["SearchEndDateTimeAsString"] = ExpressionConverter.ConvertO(mSOutlookGetEmailsSearchEndDateTimeAsString);
                mSOutlookGetEmailspropCount++;
            }

            if (mSOutlookGetEmailsMaxResultsToReturn != null)
            {
                mSOutlookGetEmails["MaxResultsToReturn"] = ExpressionConverter.ConvertO(mSOutlookGetEmailsMaxResultsToReturn);
                mSOutlookGetEmailspropCount++;
            }

            if (mSOutlookGetEmailsClickAllowButtonIfRequired != null)
            {
                mSOutlookGetEmails["ClickAllowButtonIfRequired"] = ExpressionConverter.ConvertO(mSOutlookGetEmailsClickAllowButtonIfRequired);
                mSOutlookGetEmailspropCount++;
            }

            mSOutlookGetEmailspropCount++;
            mSOutlookGetEmails["Workflow"] = ExpressionConverter.ConvertO(mSOutlookGetEmailsWorkflow);
            if (mSOutlookGetEmailspropCount > 0)
            {
                callPayload.Body = mSOutlookGetEmails;
            }

            return new ApiConnectionAction<MSOutlookGetEmailsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookGetFirstEmailResponse> MSOutlookGetFirstEmail(Expression<Func<string>> mSOutlookGetFirstEmailWorkflow, Expression<Func<string>> mSOutlookGetFirstEmailFolderPath = null, Expression<Func<bool>> mSOutlookGetFirstEmailSearchRead = null, Expression<Func<bool>> mSOutlookGetFirstEmailSearchUnread = null, Expression<Func<string>> mSOutlookGetFirstEmailSearchSubject = null, Expression<Func<string>> mSOutlookGetFirstEmailSearchFromSMTP = null, Expression<Func<string>> mSOutlookGetFirstEmailSearchFromName = null, Expression<Func<string>> mSOutlookGetFirstEmailSearchQuery = null, Expression<Func<int>> mSOutlookGetFirstEmailSearchMaxAgeInDays = null, Expression<Func<string>> mSOutlookGetFirstEmailSearchStartDateTimeAsString = null, Expression<Func<string>> mSOutlookGetFirstEmailSearchEndDateTimeAsString = null, Expression<Func<bool>> mSOutlookGetFirstEmailClickAllowButtonIfRequired = null)
        {
            var apiCallPath = "/MSOutlook/GetFirstEmail";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSOutlookGetFirstEmail = new JObject();
            var mSOutlookGetFirstEmailpropCount = 0;
            if (mSOutlookGetFirstEmailFolderPath != null)
            {
                mSOutlookGetFirstEmail["FolderPath"] = ExpressionConverter.ConvertO(mSOutlookGetFirstEmailFolderPath);
                mSOutlookGetFirstEmailpropCount++;
            }

            if (mSOutlookGetFirstEmailSearchRead != null)
            {
                mSOutlookGetFirstEmail["SearchRead"] = ExpressionConverter.ConvertO(mSOutlookGetFirstEmailSearchRead);
                mSOutlookGetFirstEmailpropCount++;
            }

            if (mSOutlookGetFirstEmailSearchUnread != null)
            {
                mSOutlookGetFirstEmail["SearchUnread"] = ExpressionConverter.ConvertO(mSOutlookGetFirstEmailSearchUnread);
                mSOutlookGetFirstEmailpropCount++;
            }

            if (mSOutlookGetFirstEmailSearchSubject != null)
            {
                mSOutlookGetFirstEmail["SearchSubject"] = ExpressionConverter.ConvertO(mSOutlookGetFirstEmailSearchSubject);
                mSOutlookGetFirstEmailpropCount++;
            }

            if (mSOutlookGetFirstEmailSearchFromSMTP != null)
            {
                mSOutlookGetFirstEmail["SearchFromSMTP"] = ExpressionConverter.ConvertO(mSOutlookGetFirstEmailSearchFromSMTP);
                mSOutlookGetFirstEmailpropCount++;
            }

            if (mSOutlookGetFirstEmailSearchFromName != null)
            {
                mSOutlookGetFirstEmail["SearchFromName"] = ExpressionConverter.ConvertO(mSOutlookGetFirstEmailSearchFromName);
                mSOutlookGetFirstEmailpropCount++;
            }

            if (mSOutlookGetFirstEmailSearchQuery != null)
            {
                mSOutlookGetFirstEmail["SearchQuery"] = ExpressionConverter.ConvertO(mSOutlookGetFirstEmailSearchQuery);
                mSOutlookGetFirstEmailpropCount++;
            }

            if (mSOutlookGetFirstEmailSearchMaxAgeInDays != null)
            {
                mSOutlookGetFirstEmail["SearchMaxAgeInDays"] = ExpressionConverter.ConvertO(mSOutlookGetFirstEmailSearchMaxAgeInDays);
                mSOutlookGetFirstEmailpropCount++;
            }

            if (mSOutlookGetFirstEmailSearchStartDateTimeAsString != null)
            {
                mSOutlookGetFirstEmail["SearchStartDateTimeAsString"] = ExpressionConverter.ConvertO(mSOutlookGetFirstEmailSearchStartDateTimeAsString);
                mSOutlookGetFirstEmailpropCount++;
            }

            if (mSOutlookGetFirstEmailSearchEndDateTimeAsString != null)
            {
                mSOutlookGetFirstEmail["SearchEndDateTimeAsString"] = ExpressionConverter.ConvertO(mSOutlookGetFirstEmailSearchEndDateTimeAsString);
                mSOutlookGetFirstEmailpropCount++;
            }

            if (mSOutlookGetFirstEmailClickAllowButtonIfRequired != null)
            {
                mSOutlookGetFirstEmail["ClickAllowButtonIfRequired"] = ExpressionConverter.ConvertO(mSOutlookGetFirstEmailClickAllowButtonIfRequired);
                mSOutlookGetFirstEmailpropCount++;
            }

            mSOutlookGetFirstEmailpropCount++;
            mSOutlookGetFirstEmail["Workflow"] = ExpressionConverter.ConvertO(mSOutlookGetFirstEmailWorkflow);
            if (mSOutlookGetFirstEmailpropCount > 0)
            {
                callPayload.Body = mSOutlookGetFirstEmail;
            }

            return new ApiConnectionAction<MSOutlookGetFirstEmailResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookGetNumberOfEmailsResponse> MSOutlookGetNumberOfEmails(Expression<Func<string>> mSOutlookGetNumberOfEmailsWorkflow, Expression<Func<string>> mSOutlookGetNumberOfEmailsFolderPath = null, Expression<Func<bool>> mSOutlookGetNumberOfEmailsSearchRead = null, Expression<Func<bool>> mSOutlookGetNumberOfEmailsSearchUnread = null, Expression<Func<string>> mSOutlookGetNumberOfEmailsSearchSubject = null, Expression<Func<string>> mSOutlookGetNumberOfEmailsSearchFromSMTP = null, Expression<Func<string>> mSOutlookGetNumberOfEmailsSearchFromName = null, Expression<Func<string>> mSOutlookGetNumberOfEmailsSearchQuery = null, Expression<Func<int>> mSOutlookGetNumberOfEmailsSearchMaxAgeInDays = null, Expression<Func<string>> mSOutlookGetNumberOfEmailsSearchStartDateTimeAsString = null, Expression<Func<string>> mSOutlookGetNumberOfEmailsSearchEndDateTimeAsString = null)
        {
            var apiCallPath = "/MSOutlook/GetNumberOfEmails";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSOutlookGetNumberOfEmails = new JObject();
            var mSOutlookGetNumberOfEmailspropCount = 0;
            if (mSOutlookGetNumberOfEmailsFolderPath != null)
            {
                mSOutlookGetNumberOfEmails["FolderPath"] = ExpressionConverter.ConvertO(mSOutlookGetNumberOfEmailsFolderPath);
                mSOutlookGetNumberOfEmailspropCount++;
            }

            if (mSOutlookGetNumberOfEmailsSearchRead != null)
            {
                mSOutlookGetNumberOfEmails["SearchRead"] = ExpressionConverter.ConvertO(mSOutlookGetNumberOfEmailsSearchRead);
                mSOutlookGetNumberOfEmailspropCount++;
            }

            if (mSOutlookGetNumberOfEmailsSearchUnread != null)
            {
                mSOutlookGetNumberOfEmails["SearchUnread"] = ExpressionConverter.ConvertO(mSOutlookGetNumberOfEmailsSearchUnread);
                mSOutlookGetNumberOfEmailspropCount++;
            }

            if (mSOutlookGetNumberOfEmailsSearchSubject != null)
            {
                mSOutlookGetNumberOfEmails["SearchSubject"] = ExpressionConverter.ConvertO(mSOutlookGetNumberOfEmailsSearchSubject);
                mSOutlookGetNumberOfEmailspropCount++;
            }

            if (mSOutlookGetNumberOfEmailsSearchFromSMTP != null)
            {
                mSOutlookGetNumberOfEmails["SearchFromSMTP"] = ExpressionConverter.ConvertO(mSOutlookGetNumberOfEmailsSearchFromSMTP);
                mSOutlookGetNumberOfEmailspropCount++;
            }

            if (mSOutlookGetNumberOfEmailsSearchFromName != null)
            {
                mSOutlookGetNumberOfEmails["SearchFromName"] = ExpressionConverter.ConvertO(mSOutlookGetNumberOfEmailsSearchFromName);
                mSOutlookGetNumberOfEmailspropCount++;
            }

            if (mSOutlookGetNumberOfEmailsSearchQuery != null)
            {
                mSOutlookGetNumberOfEmails["SearchQuery"] = ExpressionConverter.ConvertO(mSOutlookGetNumberOfEmailsSearchQuery);
                mSOutlookGetNumberOfEmailspropCount++;
            }

            if (mSOutlookGetNumberOfEmailsSearchMaxAgeInDays != null)
            {
                mSOutlookGetNumberOfEmails["SearchMaxAgeInDays"] = ExpressionConverter.ConvertO(mSOutlookGetNumberOfEmailsSearchMaxAgeInDays);
                mSOutlookGetNumberOfEmailspropCount++;
            }

            if (mSOutlookGetNumberOfEmailsSearchStartDateTimeAsString != null)
            {
                mSOutlookGetNumberOfEmails["SearchStartDateTimeAsString"] = ExpressionConverter.ConvertO(mSOutlookGetNumberOfEmailsSearchStartDateTimeAsString);
                mSOutlookGetNumberOfEmailspropCount++;
            }

            if (mSOutlookGetNumberOfEmailsSearchEndDateTimeAsString != null)
            {
                mSOutlookGetNumberOfEmails["SearchEndDateTimeAsString"] = ExpressionConverter.ConvertO(mSOutlookGetNumberOfEmailsSearchEndDateTimeAsString);
                mSOutlookGetNumberOfEmailspropCount++;
            }

            mSOutlookGetNumberOfEmailspropCount++;
            mSOutlookGetNumberOfEmails["Workflow"] = ExpressionConverter.ConvertO(mSOutlookGetNumberOfEmailsWorkflow);
            if (mSOutlookGetNumberOfEmailspropCount > 0)
            {
                callPayload.Body = mSOutlookGetNumberOfEmails;
            }

            return new ApiConnectionAction<MSOutlookGetNumberOfEmailsResponse>(callPayload);
        }
    }

    public class IaconnectmsofficeTriggers([ConnectionName] string connectionId)
    {
    }

    public class MSWordCreateInstanceResponse
    {
        public int Handle { get; set; }
    }

    public class MSWordAttachToExistingInstanceResponse
    {
        public int Handle { get; set; }
    }

    public class MSWordCreateDocumentResponse
    {
        public string DocumentName { get; set; }
    }

    public class MSWordOpenDocumentResponse
    {
        public string DocumentName { get; set; }
    }

    public class MSWordSaveAsDocumentResponse
    {
        public string NewDocumentName { get; set; }
    }

    public class MSWordGetDocumentBodyTextResponse
    {
        public string BodyText { get; set; }
    }

    public class MSWordGetNumberOfTablesInDocumentResponse
    {
        public int NumberOfTables { get; set; }
    }

    public class MSWordGetTableBoundsResponse
    {
        public int NumberOfRows { get; set; }
        public int NumberOfColumns { get; set; }
    }

    public class MSWordGetTableCellTextValueResponse
    {
        public string CellText { get; set; }
    }

    public class MSWordGetTableCellTextValueTrimmedResponse
    {
        public string CellText { get; set; }
    }

    public class MSWordGetHighlightedTextResponse
    {
        public string HighlightedTextJSON { get; set; }
    }

    public class MSWordExecuteCommandBarObjectResponse
    {
        public bool MSWordExecuteCommandBarObjectResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class MSWordSetDocumentSensitivityLabelResponse
    {
        public bool MSWordSetDocumentSensitivityLabelResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public enum mSWordSetDocumentSensitivityLabelAssignmentMethodInput
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

    public class MSExcelCreateInstanceResponse
    {
        public int Handle { get; set; }
    }

    public class MSExcelAttachToExistingInstanceResponse
    {
        public int Handle { get; set; }
    }

    public class MSExcelOpenWorkbookResponse
    {
        public string WorkbookName { get; set; }
    }

    public class MSExcelPutWorkbookInEditModeResponse
    {
        public bool MSExcelPutWorkbookInEditModeResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class MSExcelCreateWorkbookResponse
    {
        public string WorkbookName { get; set; }
    }

    public class MSExcelGetCellValueResponse
    {
        public string CellValue { get; set; }
    }

    public class MSExcelGetCellValue2Response
    {
        public string CellValue { get; set; }
    }

    public class MSExcelGetCellTextResponse
    {
        public string CellValue { get; set; }
    }

    public class MSExcelFindNextCellWithValueResponse
    {
        public string CellReference { get; set; }
        public int RowIndex { get; set; }
        public int ColumnIndex { get; set; }
    }

    public enum mSExcelFindNextCellWithValueDirectionInput
    {
        U,
        D,
        L,
        R
    }

    public enum mSExcelFindNextCellWithValueComparisonTypeInput
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

    public enum mSExcelFindNextEmptyCellDirectionInput
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

    public class MSExcelGotoNextEmptyCellRightResponse
    {
        public string CellReference { get; set; }
        public int RowIndex { get; set; }
        public int ColumnIndex { get; set; }
    }

    public class MSExcelGotoNextEmptyCellUpResponse
    {
        public string CellReference { get; set; }
        public int RowIndex { get; set; }
        public int ColumnIndex { get; set; }
    }

    public class MSExcelGotoNextEmptyCellDownResponse
    {
        public string CellReference { get; set; }
        public int RowIndex { get; set; }
        public int ColumnIndex { get; set; }
    }

    public class MSExcelSaveWorkbookResponse
    {
        public string NewWorkbookName { get; set; }
    }

    public class MSExcelSaveWorkbookAsResponse
    {
        public string NewWorkbookName { get; set; }
    }

    public enum mSExcelSaveWorkbookAsExcelFileFormatInput
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

    public class MSExcelSaveWorkbookAsWithPasswordResponse
    {
        public string NewWorkbookName { get; set; }
    }

    public enum mSExcelSaveWorkbookAsWithPasswordExcelFileFormatInput
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

    public class MSExcelSaveCurrentWorkbookAsResponse
    {
        public string NewWorkbookName { get; set; }
    }

    public enum mSExcelSaveCurrentWorkbookAsExcelFileFormatInput
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

    public class MSExcelGetWorksheetNamesResponse
    {
        public JToken[] WorksheetNames { get; set; }
    }

    public class MSExcelGetWorksheetNameResponse
    {
        public string WorksheetName { get; set; }
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

    public class MSExcelGetNumberOfRowsResponse
    {
        public int NumberOfRows { get; set; }
    }

    public class MSExcelEvaluateExpressionResponse
    {
        public string ExpressionResult { get; set; }
    }

    public class MSExcelGetWorksheetUsedRangeResponse
    {
        public int Left { get; set; }
        public int Right { get; set; }
        public int Top { get; set; }
        public int Bottom { get; set; }
    }

    public class MSExcelGetCountrySettingResponse
    {
        public int CountrySetting { get; set; }
    }

    public class MSExcelGetActiveCellResponse
    {
        public string CellReference { get; set; }
        public int RowIndex { get; set; }
        public int ColumnIndex { get; set; }
    }

    public enum mSExcelInsertOnSelectionShiftInput
    {
        R,
        D
    }

    public enum mSExcelDeleteSelectionShiftInput
    {
        L,
        U
    }

    public class MSExcelRunMacroResponse
    {
        public string Result { get; set; }
    }

    public class MSExcelCopyBetweenCellsResponse
    {
        public bool MSExcelCopyBetweenCellsResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class MSExcelCutBetweenCellsResponse
    {
        public bool MSExcelCutBetweenCellsResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class MSExcelMinimiseWindowResponse
    {
        public bool MSExcelMinimiseWindowResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class MSExcelMaximiseWindowResponse
    {
        public bool MSExcelMaximiseWindowResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class MSExcelNormaliseWindowResponse
    {
        public bool MSExcelNormaliseWindowResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class MSExcelGetAndSetCellValueResponse
    {
        public bool MSExcelGetAndSetCellValueResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class MSExcelGetAndSetCellValue2Response
    {
        public bool MSExcelGetAndSetCellValue2Result { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class MSExcelGetAndSetCellTextResponse
    {
        public bool MSExcelGetAndSetCellTextResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class MSExcelCheckOLEObjectResponse
    {
        public bool MSExcelCheckOLEObjectResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class MSExcelInputTextIntoOLEObjectResponse
    {
        public bool MSExcelInputTextIntoOLEObjectResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class MSExcelSetCellBackgroundColourResponse
    {
        public bool MSExcelSetCellBackgroundColourResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class MSExcelGetCellBackgroundColourResponse
    {
        public int ColourIndex { get; set; }
    }

    public class MSExcelGetOLEObjectValueResponse
    {
        public string OLEObjectValue { get; set; }
    }

    public class MSExcelDoesOLEObjectExistResponse
    {
        public bool OLEObjectExists { get; set; }
    }

    public class MSExcelPressOLEObjectResponse
    {
        public bool MSExcelPressOLEObjectResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class MSExcelSetWorksheetSensitivityLabelResponse
    {
        public bool MSExcelSetWorksheetSensitivityLabelResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public enum mSExcelSetWorksheetSensitivityLabelAssignmentMethodInput
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

    public class MSExcelWriteArrayResponse
    {
        public bool MSExcelWriteArrayResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public enum mSExcelWriteArrayDirectionInput
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

    public class MSOutlookAttachToExistingInstanceResponse
    {
        public string CurrentProfileName { get; set; }
    }

    public class MSOutlookIsConnectedResponse
    {
        public bool IsOutlookConnected { get; set; }
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

    public class MSOutlookGetMailFoldersResponse
    {
        public string MailFoldersJSON { get; set; }
    }

    public class MSOutlookGetEmailBodyResponse
    {
        public string BodyFormat { get; set; }
        public string PlainBody { get; set; }
        public string FormattedBody { get; set; }
    }

    public class MSOutlookGetEmailAttachmentFilenamesResponse
    {
        public int NumberOfAttachments { get; set; }
        public string EmailAttachmentFilenamesJSON { get; set; }
    }

    public class MSOutlookSaveEmailAttachmentsAsFileResponse
    {
        public int NumberOfSavedAttachments { get; set; }
        public int NumberOfAttachmentsFailedToSave { get; set; }
        public int NumberOfAttachmentsNotMatchingWildcard { get; set; }
        public int NumberOfAttachmentsSkipped { get; set; }
        public string EmailAttachmentSaveAsFilenamesJSON { get; set; }
    }

    public enum mSOutlookSendEmailBodyFormatInput
    {
        HTML,
        Plain,
        RTF
    }

    public enum mSOutlookReplyToEmailBodyFormatInput
    {
        HTML,
        Plain,
        RTF
    }

    public enum mSOutlookForwardEmailBodyFormatInput
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

    public class MSOutlookGetOutlookProcessIdResponse
    {
        public int ProcessId { get; set; }
    }

    public class MSOutlookExecuteCommandBarObjectResponse
    {
        public bool MSOutlookExecuteCommandBarObjectResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class MSOutlookGetEmailsResponse
    {
        public int NumberOfEmailsMatchFilter { get; set; }
        public int NumberOfEmailsReturned { get; set; }
        public string EmailsJSON { get; set; }
    }

    public class MSOutlookGetFirstEmailResponse
    {
        public int NumberOfEmailsMatchFilter { get; set; }
        public string EmailEntryID { get; set; }
        public string SenderEmailType { get; set; }
        public string SenderEmailAddress { get; set; }
        public string ReceivedByName { get; set; }
        public string To { get; set; }
        public string EmailSubject { get; set; }
        public bool EmailRead { get; set; }
        public string SentOnAsString { get; set; }
        public int NumberOfAttachments { get; set; }
    }

    public class MSOutlookGetNumberOfEmailsResponse
    {
        public int NumberOfEmailsMatchFilter { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
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