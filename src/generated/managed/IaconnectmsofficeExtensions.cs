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
        public IBodyWorkflowAction<MSWordCreateInstanceResponse> MSWordCreateInstance(Expression<Func<string>> mSWordCreateInstanceworkflow, Expression<Func<bool>> mSWordCreateInstanceshowWord = null)
        {
            var apiCallPath = "/MSWord/CreateInstance";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSWordCreateInstance = new JObject();
            var mSWordCreateInstancepropCount = 0;
            if (mSWordCreateInstanceshowWord != null)
            {
                mSWordCreateInstance["ShowWord"] = ExpressionConverter.ConvertO(mSWordCreateInstanceshowWord);
                mSWordCreateInstancepropCount++;
            }

            mSWordCreateInstancepropCount++;
            mSWordCreateInstance["Workflow"] = ExpressionConverter.ConvertO(mSWordCreateInstanceworkflow);
            if (mSWordCreateInstancepropCount > 0)
            {
                callPayload.Body = mSWordCreateInstance;
            }

            return new ApiConnectionAction<MSWordCreateInstanceResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordCloseInstance(Expression<Func<string>> mSWordCloseInstanceworkflow, Expression<Func<int>> mSWordCloseInstancehandle = null)
        {
            var apiCallPath = "/MSWord/CloseInstance";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSWordCloseInstance = new JObject();
            var mSWordCloseInstancepropCount = 0;
            if (mSWordCloseInstancehandle != null)
            {
                mSWordCloseInstance["Handle"] = ExpressionConverter.ConvertO(mSWordCloseInstancehandle);
                mSWordCloseInstancepropCount++;
            }

            mSWordCloseInstancepropCount++;
            mSWordCloseInstance["Workflow"] = ExpressionConverter.ConvertO(mSWordCloseInstanceworkflow);
            if (mSWordCloseInstancepropCount > 0)
            {
                callPayload.Body = mSWordCloseInstance;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordDetachFromInstance(Expression<Func<string>> mSWordDetachFromInstanceworkflow, Expression<Func<int>> mSWordDetachFromInstancehandle = null)
        {
            var apiCallPath = "/MSWord/DetachFromInstance";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSWordDetachFromInstance = new JObject();
            var mSWordDetachFromInstancepropCount = 0;
            if (mSWordDetachFromInstancehandle != null)
            {
                mSWordDetachFromInstance["Handle"] = ExpressionConverter.ConvertO(mSWordDetachFromInstancehandle);
                mSWordDetachFromInstancepropCount++;
            }

            mSWordDetachFromInstancepropCount++;
            mSWordDetachFromInstance["Workflow"] = ExpressionConverter.ConvertO(mSWordDetachFromInstanceworkflow);
            if (mSWordDetachFromInstancepropCount > 0)
            {
                callPayload.Body = mSWordDetachFromInstance;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordAttachToExistingInstanceResponse> MSWordAttachToExistingInstance(Expression<Func<string>> mSWordAttachToExistingInstanceworkflow, Expression<Func<string>> mSWordAttachToExistingInstancefilename = null, Expression<Func<bool>> mSWordAttachToExistingInstancetoggleWindow = null, Expression<Func<bool>> mSWordAttachToExistingInstancetoggleUsesGlobalLeftMouseClickAgent = null, Expression<Func<double>> mSWordAttachToExistingInstancetoggleDelay = null)
        {
            var apiCallPath = "/MSWord/AttachToExistingInstance";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSWordAttachToExistingInstance = new JObject();
            var mSWordAttachToExistingInstancepropCount = 0;
            if (mSWordAttachToExistingInstancefilename != null)
            {
                mSWordAttachToExistingInstance["Filename"] = ExpressionConverter.ConvertO(mSWordAttachToExistingInstancefilename);
                mSWordAttachToExistingInstancepropCount++;
            }

            if (mSWordAttachToExistingInstancetoggleWindow != null)
            {
                mSWordAttachToExistingInstance["ToggleWindow"] = ExpressionConverter.ConvertO(mSWordAttachToExistingInstancetoggleWindow);
                mSWordAttachToExistingInstancepropCount++;
            }

            if (mSWordAttachToExistingInstancetoggleUsesGlobalLeftMouseClickAgent != null)
            {
                mSWordAttachToExistingInstance["ToggleUsesGlobalLeftMouseClickAgent"] = ExpressionConverter.ConvertO(mSWordAttachToExistingInstancetoggleUsesGlobalLeftMouseClickAgent);
                mSWordAttachToExistingInstancepropCount++;
            }

            if (mSWordAttachToExistingInstancetoggleDelay != null)
            {
                mSWordAttachToExistingInstance["ToggleDelay"] = ExpressionConverter.ConvertO(mSWordAttachToExistingInstancetoggleDelay);
                mSWordAttachToExistingInstancepropCount++;
            }

            mSWordAttachToExistingInstancepropCount++;
            mSWordAttachToExistingInstance["Workflow"] = ExpressionConverter.ConvertO(mSWordAttachToExistingInstanceworkflow);
            if (mSWordAttachToExistingInstancepropCount > 0)
            {
                callPayload.Body = mSWordAttachToExistingInstance;
            }

            return new ApiConnectionAction<MSWordAttachToExistingInstanceResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordShowWord(Expression<Func<string>> mSWordShowWordworkflow, Expression<Func<int>> mSWordShowWordhandle = null)
        {
            var apiCallPath = "/MSWord/ShowWord";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSWordShowWord = new JObject();
            var mSWordShowWordpropCount = 0;
            if (mSWordShowWordhandle != null)
            {
                mSWordShowWord["Handle"] = ExpressionConverter.ConvertO(mSWordShowWordhandle);
                mSWordShowWordpropCount++;
            }

            mSWordShowWordpropCount++;
            mSWordShowWord["Workflow"] = ExpressionConverter.ConvertO(mSWordShowWordworkflow);
            if (mSWordShowWordpropCount > 0)
            {
                callPayload.Body = mSWordShowWord;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordHideWord(Expression<Func<string>> mSWordHideWordworkflow, Expression<Func<int>> mSWordHideWordhandle = null)
        {
            var apiCallPath = "/MSWord/HideWord";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSWordHideWord = new JObject();
            var mSWordHideWordpropCount = 0;
            if (mSWordHideWordhandle != null)
            {
                mSWordHideWord["Handle"] = ExpressionConverter.ConvertO(mSWordHideWordhandle);
                mSWordHideWordpropCount++;
            }

            mSWordHideWordpropCount++;
            mSWordHideWord["Workflow"] = ExpressionConverter.ConvertO(mSWordHideWordworkflow);
            if (mSWordHideWordpropCount > 0)
            {
                callPayload.Body = mSWordHideWord;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordCreateDocumentResponse> MSWordCreateDocument(Expression<Func<string>> mSWordCreateDocumentworkflow, Expression<Func<int>> mSWordCreateDocumenthandle = null)
        {
            var apiCallPath = "/MSWord/CreateDocument";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSWordCreateDocument = new JObject();
            var mSWordCreateDocumentpropCount = 0;
            if (mSWordCreateDocumenthandle != null)
            {
                mSWordCreateDocument["Handle"] = ExpressionConverter.ConvertO(mSWordCreateDocumenthandle);
                mSWordCreateDocumentpropCount++;
            }

            mSWordCreateDocumentpropCount++;
            mSWordCreateDocument["Workflow"] = ExpressionConverter.ConvertO(mSWordCreateDocumentworkflow);
            if (mSWordCreateDocumentpropCount > 0)
            {
                callPayload.Body = mSWordCreateDocument;
            }

            return new ApiConnectionAction<MSWordCreateDocumentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordOpenDocumentResponse> MSWordOpenDocument(Expression<Func<string>> mSWordOpenDocumentfilename, Expression<Func<string>> mSWordOpenDocumentworkflow, Expression<Func<int>> mSWordOpenDocumenthandle = null, Expression<Func<bool>> mSWordOpenDocumentopenReadOnly = null, Expression<Func<bool>> mSWordOpenDocumentaddToRecentFiles = null, Expression<Func<string>> mSWordOpenDocumentpassword = null, Expression<Func<bool>> mSWordOpenDocumentopenAndRepair = null)
        {
            var apiCallPath = "/MSWord/OpenDocument";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSWordOpenDocument = new JObject();
            var mSWordOpenDocumentpropCount = 0;
            if (mSWordOpenDocumenthandle != null)
            {
                mSWordOpenDocument["Handle"] = ExpressionConverter.ConvertO(mSWordOpenDocumenthandle);
                mSWordOpenDocumentpropCount++;
            }

            mSWordOpenDocumentpropCount++;
            mSWordOpenDocument["Filename"] = ExpressionConverter.ConvertO(mSWordOpenDocumentfilename);
            if (mSWordOpenDocumentopenReadOnly != null)
            {
                mSWordOpenDocument["OpenReadOnly"] = ExpressionConverter.ConvertO(mSWordOpenDocumentopenReadOnly);
                mSWordOpenDocumentpropCount++;
            }

            if (mSWordOpenDocumentaddToRecentFiles != null)
            {
                mSWordOpenDocument["AddToRecentFiles"] = ExpressionConverter.ConvertO(mSWordOpenDocumentaddToRecentFiles);
                mSWordOpenDocumentpropCount++;
            }

            if (mSWordOpenDocumentpassword != null)
            {
                mSWordOpenDocument["Password"] = ExpressionConverter.ConvertO(mSWordOpenDocumentpassword);
                mSWordOpenDocumentpropCount++;
            }

            if (mSWordOpenDocumentopenAndRepair != null)
            {
                mSWordOpenDocument["OpenAndRepair"] = ExpressionConverter.ConvertO(mSWordOpenDocumentopenAndRepair);
                mSWordOpenDocumentpropCount++;
            }

            mSWordOpenDocumentpropCount++;
            mSWordOpenDocument["Workflow"] = ExpressionConverter.ConvertO(mSWordOpenDocumentworkflow);
            if (mSWordOpenDocumentpropCount > 0)
            {
                callPayload.Body = mSWordOpenDocument;
            }

            return new ApiConnectionAction<MSWordOpenDocumentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordSaveDocument(Expression<Func<string>> mSWordSaveDocumentworkflow, Expression<Func<int>> mSWordSaveDocumenthandle = null, Expression<Func<string>> mSWordSaveDocumentdocumentName = null)
        {
            var apiCallPath = "/MSWord/Save";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSWordSaveDocument = new JObject();
            var mSWordSaveDocumentpropCount = 0;
            if (mSWordSaveDocumenthandle != null)
            {
                mSWordSaveDocument["Handle"] = ExpressionConverter.ConvertO(mSWordSaveDocumenthandle);
                mSWordSaveDocumentpropCount++;
            }

            if (mSWordSaveDocumentdocumentName != null)
            {
                mSWordSaveDocument["DocumentName"] = ExpressionConverter.ConvertO(mSWordSaveDocumentdocumentName);
                mSWordSaveDocumentpropCount++;
            }

            mSWordSaveDocumentpropCount++;
            mSWordSaveDocument["Workflow"] = ExpressionConverter.ConvertO(mSWordSaveDocumentworkflow);
            if (mSWordSaveDocumentpropCount > 0)
            {
                callPayload.Body = mSWordSaveDocument;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordSaveAsDocumentResponse> MSWordSaveAsDocument(Expression<Func<string>> mSWordSaveAsDocumentsaveFilename, Expression<Func<string>> mSWordSaveAsDocumentworkflow, Expression<Func<int>> mSWordSaveAsDocumenthandle = null, Expression<Func<string>> mSWordSaveAsDocumentdocumentName = null)
        {
            var apiCallPath = "/MSWord/SaveAs";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSWordSaveAsDocument = new JObject();
            var mSWordSaveAsDocumentpropCount = 0;
            if (mSWordSaveAsDocumenthandle != null)
            {
                mSWordSaveAsDocument["Handle"] = ExpressionConverter.ConvertO(mSWordSaveAsDocumenthandle);
                mSWordSaveAsDocumentpropCount++;
            }

            if (mSWordSaveAsDocumentdocumentName != null)
            {
                mSWordSaveAsDocument["DocumentName"] = ExpressionConverter.ConvertO(mSWordSaveAsDocumentdocumentName);
                mSWordSaveAsDocumentpropCount++;
            }

            mSWordSaveAsDocumentpropCount++;
            mSWordSaveAsDocument["SaveFilename"] = ExpressionConverter.ConvertO(mSWordSaveAsDocumentsaveFilename);
            mSWordSaveAsDocumentpropCount++;
            mSWordSaveAsDocument["Workflow"] = ExpressionConverter.ConvertO(mSWordSaveAsDocumentworkflow);
            if (mSWordSaveAsDocumentpropCount > 0)
            {
                callPayload.Body = mSWordSaveAsDocument;
            }

            return new ApiConnectionAction<MSWordSaveAsDocumentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordCloseDocument(Expression<Func<string>> mSWordCloseDocumentworkflow, Expression<Func<int>> mSWordCloseDocumenthandle = null, Expression<Func<string>> mSWordCloseDocumentdocumentName = null)
        {
            var apiCallPath = "/MSWord/CloseDocument";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSWordCloseDocument = new JObject();
            var mSWordCloseDocumentpropCount = 0;
            if (mSWordCloseDocumenthandle != null)
            {
                mSWordCloseDocument["Handle"] = ExpressionConverter.ConvertO(mSWordCloseDocumenthandle);
                mSWordCloseDocumentpropCount++;
            }

            if (mSWordCloseDocumentdocumentName != null)
            {
                mSWordCloseDocument["DocumentName"] = ExpressionConverter.ConvertO(mSWordCloseDocumentdocumentName);
                mSWordCloseDocumentpropCount++;
            }

            mSWordCloseDocumentpropCount++;
            mSWordCloseDocument["Workflow"] = ExpressionConverter.ConvertO(mSWordCloseDocumentworkflow);
            if (mSWordCloseDocumentpropCount > 0)
            {
                callPayload.Body = mSWordCloseDocument;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordTypeText(Expression<Func<string>> mSWordTypeTexttext, Expression<Func<string>> mSWordTypeTextworkflow, Expression<Func<int>> mSWordTypeTexthandle = null)
        {
            var apiCallPath = "/MSWord/TypeText";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSWordTypeText = new JObject();
            var mSWordTypeTextpropCount = 0;
            if (mSWordTypeTexthandle != null)
            {
                mSWordTypeText["Handle"] = ExpressionConverter.ConvertO(mSWordTypeTexthandle);
                mSWordTypeTextpropCount++;
            }

            mSWordTypeTextpropCount++;
            mSWordTypeText["Text"] = ExpressionConverter.ConvertO(mSWordTypeTexttext);
            mSWordTypeTextpropCount++;
            mSWordTypeText["Workflow"] = ExpressionConverter.ConvertO(mSWordTypeTextworkflow);
            if (mSWordTypeTextpropCount > 0)
            {
                callPayload.Body = mSWordTypeText;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordSelectAll(Expression<Func<string>> mSWordSelectAllworkflow, Expression<Func<int>> mSWordSelectAllhandle = null, Expression<Func<string>> mSWordSelectAlldocumentName = null)
        {
            var apiCallPath = "/MSWord/SelectAll";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSWordSelectAll = new JObject();
            var mSWordSelectAllpropCount = 0;
            if (mSWordSelectAllhandle != null)
            {
                mSWordSelectAll["Handle"] = ExpressionConverter.ConvertO(mSWordSelectAllhandle);
                mSWordSelectAllpropCount++;
            }

            if (mSWordSelectAlldocumentName != null)
            {
                mSWordSelectAll["DocumentName"] = ExpressionConverter.ConvertO(mSWordSelectAlldocumentName);
                mSWordSelectAllpropCount++;
            }

            mSWordSelectAllpropCount++;
            mSWordSelectAll["Workflow"] = ExpressionConverter.ConvertO(mSWordSelectAllworkflow);
            if (mSWordSelectAllpropCount > 0)
            {
                callPayload.Body = mSWordSelectAll;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordSelectRange(Expression<Func<int>> mSWordSelectRangestart, Expression<Func<int>> mSWordSelectRangefinish, Expression<Func<string>> mSWordSelectRangeworkflow, Expression<Func<int>> mSWordSelectRangehandle = null, Expression<Func<string>> mSWordSelectRangedocumentName = null)
        {
            var apiCallPath = "/MSWord/SelectRange";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSWordSelectRange = new JObject();
            var mSWordSelectRangepropCount = 0;
            if (mSWordSelectRangehandle != null)
            {
                mSWordSelectRange["Handle"] = ExpressionConverter.ConvertO(mSWordSelectRangehandle);
                mSWordSelectRangepropCount++;
            }

            if (mSWordSelectRangedocumentName != null)
            {
                mSWordSelectRange["DocumentName"] = ExpressionConverter.ConvertO(mSWordSelectRangedocumentName);
                mSWordSelectRangepropCount++;
            }

            mSWordSelectRangepropCount++;
            mSWordSelectRange["Start"] = ExpressionConverter.ConvertO(mSWordSelectRangestart);
            mSWordSelectRangepropCount++;
            mSWordSelectRange["Finish"] = ExpressionConverter.ConvertO(mSWordSelectRangefinish);
            mSWordSelectRangepropCount++;
            mSWordSelectRange["Workflow"] = ExpressionConverter.ConvertO(mSWordSelectRangeworkflow);
            if (mSWordSelectRangepropCount > 0)
            {
                callPayload.Body = mSWordSelectRange;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordCopyToClipboard(Expression<Func<string>> mSWordCopyToClipboardworkflow, Expression<Func<int>> mSWordCopyToClipboardhandle = null)
        {
            var apiCallPath = "/MSWord/CopyToClipboard";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSWordCopyToClipboard = new JObject();
            var mSWordCopyToClipboardpropCount = 0;
            if (mSWordCopyToClipboardhandle != null)
            {
                mSWordCopyToClipboard["Handle"] = ExpressionConverter.ConvertO(mSWordCopyToClipboardhandle);
                mSWordCopyToClipboardpropCount++;
            }

            mSWordCopyToClipboardpropCount++;
            mSWordCopyToClipboard["Workflow"] = ExpressionConverter.ConvertO(mSWordCopyToClipboardworkflow);
            if (mSWordCopyToClipboardpropCount > 0)
            {
                callPayload.Body = mSWordCopyToClipboard;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordPasteFromClipboard(Expression<Func<string>> mSWordPasteFromClipboardworkflow, Expression<Func<int>> mSWordPasteFromClipboardhandle = null)
        {
            var apiCallPath = "/MSWord/PasteFromClipboard";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSWordPasteFromClipboard = new JObject();
            var mSWordPasteFromClipboardpropCount = 0;
            if (mSWordPasteFromClipboardhandle != null)
            {
                mSWordPasteFromClipboard["Handle"] = ExpressionConverter.ConvertO(mSWordPasteFromClipboardhandle);
                mSWordPasteFromClipboardpropCount++;
            }

            mSWordPasteFromClipboardpropCount++;
            mSWordPasteFromClipboard["Workflow"] = ExpressionConverter.ConvertO(mSWordPasteFromClipboardworkflow);
            if (mSWordPasteFromClipboardpropCount > 0)
            {
                callPayload.Body = mSWordPasteFromClipboard;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordClearClipboard(Expression<Func<string>> mSWordClearClipboardworkflow)
        {
            var apiCallPath = "/MSWord/ClearClipboard";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSWordClearClipboard = new JObject();
            var mSWordClearClipboardpropCount = 0;
            mSWordClearClipboardpropCount++;
            mSWordClearClipboard["Workflow"] = ExpressionConverter.ConvertO(mSWordClearClipboardworkflow);
            if (mSWordClearClipboardpropCount > 0)
            {
                callPayload.Body = mSWordClearClipboard;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordGetDocumentBodyTextResponse> MSWordGetDocumentBodyText(Expression<Func<int>> mSWordGetDocumentBodyTextstart, Expression<Func<int>> mSWordGetDocumentBodyTextfinish, Expression<Func<string>> mSWordGetDocumentBodyTextworkflow, Expression<Func<int>> mSWordGetDocumentBodyTexthandle = null, Expression<Func<string>> mSWordGetDocumentBodyTextdocumentName = null)
        {
            var apiCallPath = "/MSWord/GetDocumentBodyText";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSWordGetDocumentBodyText = new JObject();
            var mSWordGetDocumentBodyTextpropCount = 0;
            if (mSWordGetDocumentBodyTexthandle != null)
            {
                mSWordGetDocumentBodyText["Handle"] = ExpressionConverter.ConvertO(mSWordGetDocumentBodyTexthandle);
                mSWordGetDocumentBodyTextpropCount++;
            }

            if (mSWordGetDocumentBodyTextdocumentName != null)
            {
                mSWordGetDocumentBodyText["DocumentName"] = ExpressionConverter.ConvertO(mSWordGetDocumentBodyTextdocumentName);
                mSWordGetDocumentBodyTextpropCount++;
            }

            mSWordGetDocumentBodyTextpropCount++;
            mSWordGetDocumentBodyText["Start"] = ExpressionConverter.ConvertO(mSWordGetDocumentBodyTextstart);
            mSWordGetDocumentBodyTextpropCount++;
            mSWordGetDocumentBodyText["Finish"] = ExpressionConverter.ConvertO(mSWordGetDocumentBodyTextfinish);
            mSWordGetDocumentBodyTextpropCount++;
            mSWordGetDocumentBodyText["Workflow"] = ExpressionConverter.ConvertO(mSWordGetDocumentBodyTextworkflow);
            if (mSWordGetDocumentBodyTextpropCount > 0)
            {
                callPayload.Body = mSWordGetDocumentBodyText;
            }

            return new ApiConnectionAction<MSWordGetDocumentBodyTextResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordGetNumberOfTablesInDocumentResponse> MSWordGetNumberOfTablesInDocument(Expression<Func<string>> mSWordGetNumberOfTablesInDocumentworkflow, Expression<Func<int>> mSWordGetNumberOfTablesInDocumenthandle = null, Expression<Func<string>> mSWordGetNumberOfTablesInDocumentdocumentName = null)
        {
            var apiCallPath = "/MSWord/GetNumberOfTablesInDocument";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSWordGetNumberOfTablesInDocument = new JObject();
            var mSWordGetNumberOfTablesInDocumentpropCount = 0;
            if (mSWordGetNumberOfTablesInDocumenthandle != null)
            {
                mSWordGetNumberOfTablesInDocument["Handle"] = ExpressionConverter.ConvertO(mSWordGetNumberOfTablesInDocumenthandle);
                mSWordGetNumberOfTablesInDocumentpropCount++;
            }

            if (mSWordGetNumberOfTablesInDocumentdocumentName != null)
            {
                mSWordGetNumberOfTablesInDocument["DocumentName"] = ExpressionConverter.ConvertO(mSWordGetNumberOfTablesInDocumentdocumentName);
                mSWordGetNumberOfTablesInDocumentpropCount++;
            }

            mSWordGetNumberOfTablesInDocumentpropCount++;
            mSWordGetNumberOfTablesInDocument["Workflow"] = ExpressionConverter.ConvertO(mSWordGetNumberOfTablesInDocumentworkflow);
            if (mSWordGetNumberOfTablesInDocumentpropCount > 0)
            {
                callPayload.Body = mSWordGetNumberOfTablesInDocument;
            }

            return new ApiConnectionAction<MSWordGetNumberOfTablesInDocumentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordUpdateBookmark(Expression<Func<string>> mSWordUpdateBookmarkbookmarkName, Expression<Func<string>> mSWordUpdateBookmarkworkflow, Expression<Func<int>> mSWordUpdateBookmarkhandle = null, Expression<Func<string>> mSWordUpdateBookmarkdocumentName = null, Expression<Func<string>> mSWordUpdateBookmarknewValue = null)
        {
            var apiCallPath = "/MSWord/UpdateBookmark";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSWordUpdateBookmark = new JObject();
            var mSWordUpdateBookmarkpropCount = 0;
            if (mSWordUpdateBookmarkhandle != null)
            {
                mSWordUpdateBookmark["Handle"] = ExpressionConverter.ConvertO(mSWordUpdateBookmarkhandle);
                mSWordUpdateBookmarkpropCount++;
            }

            if (mSWordUpdateBookmarkdocumentName != null)
            {
                mSWordUpdateBookmark["DocumentName"] = ExpressionConverter.ConvertO(mSWordUpdateBookmarkdocumentName);
                mSWordUpdateBookmarkpropCount++;
            }

            mSWordUpdateBookmarkpropCount++;
            mSWordUpdateBookmark["BookmarkName"] = ExpressionConverter.ConvertO(mSWordUpdateBookmarkbookmarkName);
            if (mSWordUpdateBookmarknewValue != null)
            {
                mSWordUpdateBookmark["NewValue"] = ExpressionConverter.ConvertO(mSWordUpdateBookmarknewValue);
                mSWordUpdateBookmarkpropCount++;
            }

            mSWordUpdateBookmarkpropCount++;
            mSWordUpdateBookmark["Workflow"] = ExpressionConverter.ConvertO(mSWordUpdateBookmarkworkflow);
            if (mSWordUpdateBookmarkpropCount > 0)
            {
                callPayload.Body = mSWordUpdateBookmark;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordSelectTable(Expression<Func<int>> mSWordSelectTabletableIndex, Expression<Func<string>> mSWordSelectTableworkflow, Expression<Func<int>> mSWordSelectTablehandle = null, Expression<Func<string>> mSWordSelectTabledocumentName = null)
        {
            var apiCallPath = "/MSWord/SelectTable";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSWordSelectTable = new JObject();
            var mSWordSelectTablepropCount = 0;
            if (mSWordSelectTablehandle != null)
            {
                mSWordSelectTable["Handle"] = ExpressionConverter.ConvertO(mSWordSelectTablehandle);
                mSWordSelectTablepropCount++;
            }

            if (mSWordSelectTabledocumentName != null)
            {
                mSWordSelectTable["DocumentName"] = ExpressionConverter.ConvertO(mSWordSelectTabledocumentName);
                mSWordSelectTablepropCount++;
            }

            mSWordSelectTablepropCount++;
            mSWordSelectTable["TableIndex"] = ExpressionConverter.ConvertO(mSWordSelectTabletableIndex);
            mSWordSelectTablepropCount++;
            mSWordSelectTable["Workflow"] = ExpressionConverter.ConvertO(mSWordSelectTableworkflow);
            if (mSWordSelectTablepropCount > 0)
            {
                callPayload.Body = mSWordSelectTable;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordGetTableBoundsResponse> MSWordGetTableBounds(Expression<Func<int>> mSWordGetTableBoundstableIndex, Expression<Func<string>> mSWordGetTableBoundsworkflow, Expression<Func<int>> mSWordGetTableBoundshandle = null, Expression<Func<string>> mSWordGetTableBoundsdocumentName = null)
        {
            var apiCallPath = "/MSWord/GetTableBounds";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSWordGetTableBounds = new JObject();
            var mSWordGetTableBoundspropCount = 0;
            if (mSWordGetTableBoundshandle != null)
            {
                mSWordGetTableBounds["Handle"] = ExpressionConverter.ConvertO(mSWordGetTableBoundshandle);
                mSWordGetTableBoundspropCount++;
            }

            if (mSWordGetTableBoundsdocumentName != null)
            {
                mSWordGetTableBounds["DocumentName"] = ExpressionConverter.ConvertO(mSWordGetTableBoundsdocumentName);
                mSWordGetTableBoundspropCount++;
            }

            mSWordGetTableBoundspropCount++;
            mSWordGetTableBounds["TableIndex"] = ExpressionConverter.ConvertO(mSWordGetTableBoundstableIndex);
            mSWordGetTableBoundspropCount++;
            mSWordGetTableBounds["Workflow"] = ExpressionConverter.ConvertO(mSWordGetTableBoundsworkflow);
            if (mSWordGetTableBoundspropCount > 0)
            {
                callPayload.Body = mSWordGetTableBounds;
            }

            return new ApiConnectionAction<MSWordGetTableBoundsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordSelectTableCell(Expression<Func<int>> mSWordSelectTableCelltableIndex, Expression<Func<int>> mSWordSelectTableCellrowIndex, Expression<Func<int>> mSWordSelectTableCellcolumnIndex, Expression<Func<string>> mSWordSelectTableCellworkflow, Expression<Func<int>> mSWordSelectTableCellhandle = null, Expression<Func<string>> mSWordSelectTableCelldocumentName = null)
        {
            var apiCallPath = "/MSWord/SelectTableCell";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSWordSelectTableCell = new JObject();
            var mSWordSelectTableCellpropCount = 0;
            if (mSWordSelectTableCellhandle != null)
            {
                mSWordSelectTableCell["Handle"] = ExpressionConverter.ConvertO(mSWordSelectTableCellhandle);
                mSWordSelectTableCellpropCount++;
            }

            if (mSWordSelectTableCelldocumentName != null)
            {
                mSWordSelectTableCell["DocumentName"] = ExpressionConverter.ConvertO(mSWordSelectTableCelldocumentName);
                mSWordSelectTableCellpropCount++;
            }

            mSWordSelectTableCellpropCount++;
            mSWordSelectTableCell["TableIndex"] = ExpressionConverter.ConvertO(mSWordSelectTableCelltableIndex);
            mSWordSelectTableCellpropCount++;
            mSWordSelectTableCell["RowIndex"] = ExpressionConverter.ConvertO(mSWordSelectTableCellrowIndex);
            mSWordSelectTableCellpropCount++;
            mSWordSelectTableCell["ColumnIndex"] = ExpressionConverter.ConvertO(mSWordSelectTableCellcolumnIndex);
            mSWordSelectTableCellpropCount++;
            mSWordSelectTableCell["Workflow"] = ExpressionConverter.ConvertO(mSWordSelectTableCellworkflow);
            if (mSWordSelectTableCellpropCount > 0)
            {
                callPayload.Body = mSWordSelectTableCell;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordGetTableCellTextValueResponse> MSWordGetTableCellTextValue(Expression<Func<int>> mSWordGetTableCellTextValuetableIndex, Expression<Func<int>> mSWordGetTableCellTextValuerowIndex, Expression<Func<int>> mSWordGetTableCellTextValuecolumnIndex, Expression<Func<string>> mSWordGetTableCellTextValueworkflow, Expression<Func<int>> mSWordGetTableCellTextValuehandle = null, Expression<Func<string>> mSWordGetTableCellTextValuedocumentName = null)
        {
            var apiCallPath = "/MSWord/GetTableCellTextValue";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSWordGetTableCellTextValue = new JObject();
            var mSWordGetTableCellTextValuepropCount = 0;
            if (mSWordGetTableCellTextValuehandle != null)
            {
                mSWordGetTableCellTextValue["Handle"] = ExpressionConverter.ConvertO(mSWordGetTableCellTextValuehandle);
                mSWordGetTableCellTextValuepropCount++;
            }

            if (mSWordGetTableCellTextValuedocumentName != null)
            {
                mSWordGetTableCellTextValue["DocumentName"] = ExpressionConverter.ConvertO(mSWordGetTableCellTextValuedocumentName);
                mSWordGetTableCellTextValuepropCount++;
            }

            mSWordGetTableCellTextValuepropCount++;
            mSWordGetTableCellTextValue["TableIndex"] = ExpressionConverter.ConvertO(mSWordGetTableCellTextValuetableIndex);
            mSWordGetTableCellTextValuepropCount++;
            mSWordGetTableCellTextValue["RowIndex"] = ExpressionConverter.ConvertO(mSWordGetTableCellTextValuerowIndex);
            mSWordGetTableCellTextValuepropCount++;
            mSWordGetTableCellTextValue["ColumnIndex"] = ExpressionConverter.ConvertO(mSWordGetTableCellTextValuecolumnIndex);
            mSWordGetTableCellTextValuepropCount++;
            mSWordGetTableCellTextValue["Workflow"] = ExpressionConverter.ConvertO(mSWordGetTableCellTextValueworkflow);
            if (mSWordGetTableCellTextValuepropCount > 0)
            {
                callPayload.Body = mSWordGetTableCellTextValue;
            }

            return new ApiConnectionAction<MSWordGetTableCellTextValueResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordGetTableCellTextValueTrimmedResponse> MSWordGetTableCellTextValueTrimmed(Expression<Func<int>> mSWordGetTableCellTextValueTrimmedtableIndex, Expression<Func<int>> mSWordGetTableCellTextValueTrimmedrowIndex, Expression<Func<int>> mSWordGetTableCellTextValueTrimmedcolumnIndex, Expression<Func<string>> mSWordGetTableCellTextValueTrimmedworkflow, Expression<Func<int>> mSWordGetTableCellTextValueTrimmedhandle = null, Expression<Func<string>> mSWordGetTableCellTextValueTrimmeddocumentName = null)
        {
            var apiCallPath = "/MSWord/GetTableCellTextValueTrimmed";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSWordGetTableCellTextValueTrimmed = new JObject();
            var mSWordGetTableCellTextValueTrimmedpropCount = 0;
            if (mSWordGetTableCellTextValueTrimmedhandle != null)
            {
                mSWordGetTableCellTextValueTrimmed["Handle"] = ExpressionConverter.ConvertO(mSWordGetTableCellTextValueTrimmedhandle);
                mSWordGetTableCellTextValueTrimmedpropCount++;
            }

            if (mSWordGetTableCellTextValueTrimmeddocumentName != null)
            {
                mSWordGetTableCellTextValueTrimmed["DocumentName"] = ExpressionConverter.ConvertO(mSWordGetTableCellTextValueTrimmeddocumentName);
                mSWordGetTableCellTextValueTrimmedpropCount++;
            }

            mSWordGetTableCellTextValueTrimmedpropCount++;
            mSWordGetTableCellTextValueTrimmed["TableIndex"] = ExpressionConverter.ConvertO(mSWordGetTableCellTextValueTrimmedtableIndex);
            mSWordGetTableCellTextValueTrimmedpropCount++;
            mSWordGetTableCellTextValueTrimmed["RowIndex"] = ExpressionConverter.ConvertO(mSWordGetTableCellTextValueTrimmedrowIndex);
            mSWordGetTableCellTextValueTrimmedpropCount++;
            mSWordGetTableCellTextValueTrimmed["ColumnIndex"] = ExpressionConverter.ConvertO(mSWordGetTableCellTextValueTrimmedcolumnIndex);
            mSWordGetTableCellTextValueTrimmedpropCount++;
            mSWordGetTableCellTextValueTrimmed["Workflow"] = ExpressionConverter.ConvertO(mSWordGetTableCellTextValueTrimmedworkflow);
            if (mSWordGetTableCellTextValueTrimmedpropCount > 0)
            {
                callPayload.Body = mSWordGetTableCellTextValueTrimmed;
            }

            return new ApiConnectionAction<MSWordGetTableCellTextValueTrimmedResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordSetTableCellTextValue(Expression<Func<int>> mSWordSetTableCellTextValuetableIndex, Expression<Func<int>> mSWordSetTableCellTextValuerowIndex, Expression<Func<int>> mSWordSetTableCellTextValuecolumnIndex, Expression<Func<string>> mSWordSetTableCellTextValueworkflow, Expression<Func<int>> mSWordSetTableCellTextValuehandle = null, Expression<Func<string>> mSWordSetTableCellTextValuedocumentName = null, Expression<Func<string>> mSWordSetTableCellTextValuenewCellText = null)
        {
            var apiCallPath = "/MSWord/SetTableCellTextValue";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSWordSetTableCellTextValue = new JObject();
            var mSWordSetTableCellTextValuepropCount = 0;
            if (mSWordSetTableCellTextValuehandle != null)
            {
                mSWordSetTableCellTextValue["Handle"] = ExpressionConverter.ConvertO(mSWordSetTableCellTextValuehandle);
                mSWordSetTableCellTextValuepropCount++;
            }

            if (mSWordSetTableCellTextValuedocumentName != null)
            {
                mSWordSetTableCellTextValue["DocumentName"] = ExpressionConverter.ConvertO(mSWordSetTableCellTextValuedocumentName);
                mSWordSetTableCellTextValuepropCount++;
            }

            mSWordSetTableCellTextValuepropCount++;
            mSWordSetTableCellTextValue["TableIndex"] = ExpressionConverter.ConvertO(mSWordSetTableCellTextValuetableIndex);
            mSWordSetTableCellTextValuepropCount++;
            mSWordSetTableCellTextValue["RowIndex"] = ExpressionConverter.ConvertO(mSWordSetTableCellTextValuerowIndex);
            mSWordSetTableCellTextValuepropCount++;
            mSWordSetTableCellTextValue["ColumnIndex"] = ExpressionConverter.ConvertO(mSWordSetTableCellTextValuecolumnIndex);
            if (mSWordSetTableCellTextValuenewCellText != null)
            {
                mSWordSetTableCellTextValue["NewCellText"] = ExpressionConverter.ConvertO(mSWordSetTableCellTextValuenewCellText);
                mSWordSetTableCellTextValuepropCount++;
            }

            mSWordSetTableCellTextValuepropCount++;
            mSWordSetTableCellTextValue["Workflow"] = ExpressionConverter.ConvertO(mSWordSetTableCellTextValueworkflow);
            if (mSWordSetTableCellTextValuepropCount > 0)
            {
                callPayload.Body = mSWordSetTableCellTextValue;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordExportDocumentAsPDF(Expression<Func<string>> mSWordExportDocumentAsPDFsaveFileName, Expression<Func<string>> mSWordExportDocumentAsPDFworkflow, Expression<Func<int>> mSWordExportDocumentAsPDFhandle = null, Expression<Func<string>> mSWordExportDocumentAsPDFdocumentName = null)
        {
            var apiCallPath = "/MSWord/ExportDocumentAsPDF";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSWordExportDocumentAsPDF = new JObject();
            var mSWordExportDocumentAsPDFpropCount = 0;
            if (mSWordExportDocumentAsPDFhandle != null)
            {
                mSWordExportDocumentAsPDF["Handle"] = ExpressionConverter.ConvertO(mSWordExportDocumentAsPDFhandle);
                mSWordExportDocumentAsPDFpropCount++;
            }

            if (mSWordExportDocumentAsPDFdocumentName != null)
            {
                mSWordExportDocumentAsPDF["DocumentName"] = ExpressionConverter.ConvertO(mSWordExportDocumentAsPDFdocumentName);
                mSWordExportDocumentAsPDFpropCount++;
            }

            mSWordExportDocumentAsPDFpropCount++;
            mSWordExportDocumentAsPDF["SaveFileName"] = ExpressionConverter.ConvertO(mSWordExportDocumentAsPDFsaveFileName);
            mSWordExportDocumentAsPDFpropCount++;
            mSWordExportDocumentAsPDF["Workflow"] = ExpressionConverter.ConvertO(mSWordExportDocumentAsPDFworkflow);
            if (mSWordExportDocumentAsPDFpropCount > 0)
            {
                callPayload.Body = mSWordExportDocumentAsPDF;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordAddTable(Expression<Func<int>> mSWordAddTablenumberOfRows, Expression<Func<int>> mSWordAddTablenumberOfColumns, Expression<Func<string>> mSWordAddTableworkflow, Expression<Func<int>> mSWordAddTablehandle = null, Expression<Func<string>> mSWordAddTabledocumentName = null, Expression<Func<int>> mSWordAddTableautoFitBehaviour = null)
        {
            var apiCallPath = "/MSWord/AddTable";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSWordAddTable = new JObject();
            var mSWordAddTablepropCount = 0;
            if (mSWordAddTablehandle != null)
            {
                mSWordAddTable["Handle"] = ExpressionConverter.ConvertO(mSWordAddTablehandle);
                mSWordAddTablepropCount++;
            }

            if (mSWordAddTabledocumentName != null)
            {
                mSWordAddTable["DocumentName"] = ExpressionConverter.ConvertO(mSWordAddTabledocumentName);
                mSWordAddTablepropCount++;
            }

            mSWordAddTablepropCount++;
            mSWordAddTable["NumberOfRows"] = ExpressionConverter.ConvertO(mSWordAddTablenumberOfRows);
            mSWordAddTablepropCount++;
            mSWordAddTable["NumberOfColumns"] = ExpressionConverter.ConvertO(mSWordAddTablenumberOfColumns);
            if (mSWordAddTableautoFitBehaviour != null)
            {
                mSWordAddTable["AutoFitBehaviour"] = ExpressionConverter.ConvertO(mSWordAddTableautoFitBehaviour);
                mSWordAddTablepropCount++;
            }

            mSWordAddTablepropCount++;
            mSWordAddTable["Workflow"] = ExpressionConverter.ConvertO(mSWordAddTableworkflow);
            if (mSWordAddTablepropCount > 0)
            {
                callPayload.Body = mSWordAddTable;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordAddTableRow(Expression<Func<int>> mSWordAddTableRowtableIndex, Expression<Func<string>> mSWordAddTableRowworkflow, Expression<Func<int>> mSWordAddTableRowhandle = null, Expression<Func<string>> mSWordAddTableRowdocumentName = null)
        {
            var apiCallPath = "/MSWord/AddTableRow";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSWordAddTableRow = new JObject();
            var mSWordAddTableRowpropCount = 0;
            if (mSWordAddTableRowhandle != null)
            {
                mSWordAddTableRow["Handle"] = ExpressionConverter.ConvertO(mSWordAddTableRowhandle);
                mSWordAddTableRowpropCount++;
            }

            if (mSWordAddTableRowdocumentName != null)
            {
                mSWordAddTableRow["DocumentName"] = ExpressionConverter.ConvertO(mSWordAddTableRowdocumentName);
                mSWordAddTableRowpropCount++;
            }

            mSWordAddTableRowpropCount++;
            mSWordAddTableRow["TableIndex"] = ExpressionConverter.ConvertO(mSWordAddTableRowtableIndex);
            mSWordAddTableRowpropCount++;
            mSWordAddTableRow["Workflow"] = ExpressionConverter.ConvertO(mSWordAddTableRowworkflow);
            if (mSWordAddTableRowpropCount > 0)
            {
                callPayload.Body = mSWordAddTableRow;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordAddTableColumn(Expression<Func<int>> mSWordAddTableColumntableIndex, Expression<Func<string>> mSWordAddTableColumnworkflow, Expression<Func<int>> mSWordAddTableColumnhandle = null, Expression<Func<string>> mSWordAddTableColumndocumentName = null)
        {
            var apiCallPath = "/MSWord/AddTableColumn";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSWordAddTableColumn = new JObject();
            var mSWordAddTableColumnpropCount = 0;
            if (mSWordAddTableColumnhandle != null)
            {
                mSWordAddTableColumn["Handle"] = ExpressionConverter.ConvertO(mSWordAddTableColumnhandle);
                mSWordAddTableColumnpropCount++;
            }

            if (mSWordAddTableColumndocumentName != null)
            {
                mSWordAddTableColumn["DocumentName"] = ExpressionConverter.ConvertO(mSWordAddTableColumndocumentName);
                mSWordAddTableColumnpropCount++;
            }

            mSWordAddTableColumnpropCount++;
            mSWordAddTableColumn["TableIndex"] = ExpressionConverter.ConvertO(mSWordAddTableColumntableIndex);
            mSWordAddTableColumnpropCount++;
            mSWordAddTableColumn["Workflow"] = ExpressionConverter.ConvertO(mSWordAddTableColumnworkflow);
            if (mSWordAddTableColumnpropCount > 0)
            {
                callPayload.Body = mSWordAddTableColumn;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordGetHighlightedTextResponse> MSWordGetHighlightedText(Expression<Func<string>> mSWordGetHighlightedTextworkflow, Expression<Func<int>> mSWordGetHighlightedTexthandle = null, Expression<Func<string>> mSWordGetHighlightedTextdocumentName = null)
        {
            var apiCallPath = "/MSWord/GetHighlightedText";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSWordGetHighlightedText = new JObject();
            var mSWordGetHighlightedTextpropCount = 0;
            if (mSWordGetHighlightedTexthandle != null)
            {
                mSWordGetHighlightedText["Handle"] = ExpressionConverter.ConvertO(mSWordGetHighlightedTexthandle);
                mSWordGetHighlightedTextpropCount++;
            }

            if (mSWordGetHighlightedTextdocumentName != null)
            {
                mSWordGetHighlightedText["DocumentName"] = ExpressionConverter.ConvertO(mSWordGetHighlightedTextdocumentName);
                mSWordGetHighlightedTextpropCount++;
            }

            mSWordGetHighlightedTextpropCount++;
            mSWordGetHighlightedText["Workflow"] = ExpressionConverter.ConvertO(mSWordGetHighlightedTextworkflow);
            if (mSWordGetHighlightedTextpropCount > 0)
            {
                callPayload.Body = mSWordGetHighlightedText;
            }

            return new ApiConnectionAction<MSWordGetHighlightedTextResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordExecuteCommandBarObjectResponse> MSWordExecuteCommandBarObject(Expression<Func<string>> mSWordExecuteCommandBarObjectobjectId, Expression<Func<string>> mSWordExecuteCommandBarObjectworkflow, Expression<Func<int>> mSWordExecuteCommandBarObjecthandle = null, Expression<Func<bool>> mSWordExecuteCommandBarObjectrunInBackground = null)
        {
            var apiCallPath = "/MSWord/ExecuteCommandBarObject";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSWordExecuteCommandBarObject = new JObject();
            var mSWordExecuteCommandBarObjectpropCount = 0;
            if (mSWordExecuteCommandBarObjecthandle != null)
            {
                mSWordExecuteCommandBarObject["Handle"] = ExpressionConverter.ConvertO(mSWordExecuteCommandBarObjecthandle);
                mSWordExecuteCommandBarObjectpropCount++;
            }

            mSWordExecuteCommandBarObjectpropCount++;
            mSWordExecuteCommandBarObject["ObjectId"] = ExpressionConverter.ConvertO(mSWordExecuteCommandBarObjectobjectId);
            if (mSWordExecuteCommandBarObjectrunInBackground != null)
            {
                mSWordExecuteCommandBarObject["RunInBackground"] = ExpressionConverter.ConvertO(mSWordExecuteCommandBarObjectrunInBackground);
                mSWordExecuteCommandBarObjectpropCount++;
            }

            mSWordExecuteCommandBarObjectpropCount++;
            mSWordExecuteCommandBarObject["Workflow"] = ExpressionConverter.ConvertO(mSWordExecuteCommandBarObjectworkflow);
            if (mSWordExecuteCommandBarObjectpropCount > 0)
            {
                callPayload.Body = mSWordExecuteCommandBarObject;
            }

            return new ApiConnectionAction<MSWordExecuteCommandBarObjectResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordSetDocumentSensitivityLabelResponse> MSWordSetDocumentSensitivityLabel(Expression<Func<mSWordSetDocumentSensitivityLabelassignmentMethodInput>> mSWordSetDocumentSensitivityLabelassignmentMethod, Expression<Func<string>> mSWordSetDocumentSensitivityLabellabelId, Expression<Func<string>> mSWordSetDocumentSensitivityLabelworkflow, Expression<Func<int>> mSWordSetDocumentSensitivityLabelhandle = null, Expression<Func<string>> mSWordSetDocumentSensitivityLabeldocumentName = null, Expression<Func<string>> mSWordSetDocumentSensitivityLabellabelName = null, Expression<Func<string>> mSWordSetDocumentSensitivityLabelsiteId = null, Expression<Func<string>> mSWordSetDocumentSensitivityLabeljustification = null)
        {
            var apiCallPath = "/MSWord/MSWordSetDocumentSensitivityLabel";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSWordSetDocumentSensitivityLabel = new JObject();
            var mSWordSetDocumentSensitivityLabelpropCount = 0;
            if (mSWordSetDocumentSensitivityLabelhandle != null)
            {
                mSWordSetDocumentSensitivityLabel["Handle"] = ExpressionConverter.ConvertO(mSWordSetDocumentSensitivityLabelhandle);
                mSWordSetDocumentSensitivityLabelpropCount++;
            }

            if (mSWordSetDocumentSensitivityLabeldocumentName != null)
            {
                mSWordSetDocumentSensitivityLabel["DocumentName"] = ExpressionConverter.ConvertO(mSWordSetDocumentSensitivityLabeldocumentName);
                mSWordSetDocumentSensitivityLabelpropCount++;
            }

            mSWordSetDocumentSensitivityLabelpropCount++;
            mSWordSetDocumentSensitivityLabel["AssignmentMethod"] = ExpressionConverter.ConvertO(mSWordSetDocumentSensitivityLabelassignmentMethod);
            mSWordSetDocumentSensitivityLabelpropCount++;
            mSWordSetDocumentSensitivityLabel["LabelId"] = ExpressionConverter.ConvertO(mSWordSetDocumentSensitivityLabellabelId);
            if (mSWordSetDocumentSensitivityLabellabelName != null)
            {
                mSWordSetDocumentSensitivityLabel["LabelName"] = ExpressionConverter.ConvertO(mSWordSetDocumentSensitivityLabellabelName);
                mSWordSetDocumentSensitivityLabelpropCount++;
            }

            if (mSWordSetDocumentSensitivityLabelsiteId != null)
            {
                mSWordSetDocumentSensitivityLabel["SiteId"] = ExpressionConverter.ConvertO(mSWordSetDocumentSensitivityLabelsiteId);
                mSWordSetDocumentSensitivityLabelpropCount++;
            }

            if (mSWordSetDocumentSensitivityLabeljustification != null)
            {
                mSWordSetDocumentSensitivityLabel["Justification"] = ExpressionConverter.ConvertO(mSWordSetDocumentSensitivityLabeljustification);
                mSWordSetDocumentSensitivityLabelpropCount++;
            }

            mSWordSetDocumentSensitivityLabelpropCount++;
            mSWordSetDocumentSensitivityLabel["Workflow"] = ExpressionConverter.ConvertO(mSWordSetDocumentSensitivityLabelworkflow);
            if (mSWordSetDocumentSensitivityLabelpropCount > 0)
            {
                callPayload.Body = mSWordSetDocumentSensitivityLabel;
            }

            return new ApiConnectionAction<MSWordSetDocumentSensitivityLabelResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordGetDocumentSensitivityLabelResponse> MSWordGetDocumentSensitivityLabel(Expression<Func<string>> mSWordGetDocumentSensitivityLabelworkflow, Expression<Func<int>> mSWordGetDocumentSensitivityLabelhandle = null, Expression<Func<string>> mSWordGetDocumentSensitivityLabeldocumentName = null)
        {
            var apiCallPath = "/MSWord/MSWordGetDocumentSensitivityLabel";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSWordGetDocumentSensitivityLabel = new JObject();
            var mSWordGetDocumentSensitivityLabelpropCount = 0;
            if (mSWordGetDocumentSensitivityLabelhandle != null)
            {
                mSWordGetDocumentSensitivityLabel["Handle"] = ExpressionConverter.ConvertO(mSWordGetDocumentSensitivityLabelhandle);
                mSWordGetDocumentSensitivityLabelpropCount++;
            }

            if (mSWordGetDocumentSensitivityLabeldocumentName != null)
            {
                mSWordGetDocumentSensitivityLabel["DocumentName"] = ExpressionConverter.ConvertO(mSWordGetDocumentSensitivityLabeldocumentName);
                mSWordGetDocumentSensitivityLabelpropCount++;
            }

            mSWordGetDocumentSensitivityLabelpropCount++;
            mSWordGetDocumentSensitivityLabel["Workflow"] = ExpressionConverter.ConvertO(mSWordGetDocumentSensitivityLabelworkflow);
            if (mSWordGetDocumentSensitivityLabelpropCount > 0)
            {
                callPayload.Body = mSWordGetDocumentSensitivityLabel;
            }

            return new ApiConnectionAction<MSWordGetDocumentSensitivityLabelResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelCreateInstanceResponse> MSExcelCreateInstance(Expression<Func<string>> mSExcelCreateInstanceworkflow, Expression<Func<bool>> mSExcelCreateInstanceenableEvents = null, Expression<Func<bool>> mSExcelCreateInstanceshowExcel = null)
        {
            var apiCallPath = "/MSExcel/CreateInstance";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelCreateInstance = new JObject();
            var mSExcelCreateInstancepropCount = 0;
            if (mSExcelCreateInstanceenableEvents != null)
            {
                mSExcelCreateInstance["EnableEvents"] = ExpressionConverter.ConvertO(mSExcelCreateInstanceenableEvents);
                mSExcelCreateInstancepropCount++;
            }

            if (mSExcelCreateInstanceshowExcel != null)
            {
                mSExcelCreateInstance["ShowExcel"] = ExpressionConverter.ConvertO(mSExcelCreateInstanceshowExcel);
                mSExcelCreateInstancepropCount++;
            }

            mSExcelCreateInstancepropCount++;
            mSExcelCreateInstance["Workflow"] = ExpressionConverter.ConvertO(mSExcelCreateInstanceworkflow);
            if (mSExcelCreateInstancepropCount > 0)
            {
                callPayload.Body = mSExcelCreateInstance;
            }

            return new ApiConnectionAction<MSExcelCreateInstanceResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelCloseInstance(Expression<Func<string>> mSExcelCloseInstanceworkflow, Expression<Func<int>> mSExcelCloseInstancehandle = null)
        {
            var apiCallPath = "/MSExcel/CloseInstance";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelCloseInstance = new JObject();
            var mSExcelCloseInstancepropCount = 0;
            if (mSExcelCloseInstancehandle != null)
            {
                mSExcelCloseInstance["Handle"] = ExpressionConverter.ConvertO(mSExcelCloseInstancehandle);
                mSExcelCloseInstancepropCount++;
            }

            mSExcelCloseInstancepropCount++;
            mSExcelCloseInstance["Workflow"] = ExpressionConverter.ConvertO(mSExcelCloseInstanceworkflow);
            if (mSExcelCloseInstancepropCount > 0)
            {
                callPayload.Body = mSExcelCloseInstance;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelAttachToExistingInstanceResponse> MSExcelAttachToExistingInstance(Expression<Func<string>> mSExcelAttachToExistingInstanceworkflow, Expression<Func<string>> mSExcelAttachToExistingInstancefilename = null, Expression<Func<bool>> mSExcelAttachToExistingInstancetoggleWindow = null, Expression<Func<bool>> mSExcelAttachToExistingInstancetoggleUsesGlobalLeftMouseClickAgent = null, Expression<Func<double>> mSExcelAttachToExistingInstancetoggleDelay = null)
        {
            var apiCallPath = "/MSExcel/MSExcelAttachToExistingInstance";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelAttachToExistingInstance = new JObject();
            var mSExcelAttachToExistingInstancepropCount = 0;
            if (mSExcelAttachToExistingInstancefilename != null)
            {
                mSExcelAttachToExistingInstance["Filename"] = ExpressionConverter.ConvertO(mSExcelAttachToExistingInstancefilename);
                mSExcelAttachToExistingInstancepropCount++;
            }

            if (mSExcelAttachToExistingInstancetoggleWindow != null)
            {
                mSExcelAttachToExistingInstance["ToggleWindow"] = ExpressionConverter.ConvertO(mSExcelAttachToExistingInstancetoggleWindow);
                mSExcelAttachToExistingInstancepropCount++;
            }

            if (mSExcelAttachToExistingInstancetoggleUsesGlobalLeftMouseClickAgent != null)
            {
                mSExcelAttachToExistingInstance["ToggleUsesGlobalLeftMouseClickAgent"] = ExpressionConverter.ConvertO(mSExcelAttachToExistingInstancetoggleUsesGlobalLeftMouseClickAgent);
                mSExcelAttachToExistingInstancepropCount++;
            }

            if (mSExcelAttachToExistingInstancetoggleDelay != null)
            {
                mSExcelAttachToExistingInstance["ToggleDelay"] = ExpressionConverter.ConvertO(mSExcelAttachToExistingInstancetoggleDelay);
                mSExcelAttachToExistingInstancepropCount++;
            }

            mSExcelAttachToExistingInstancepropCount++;
            mSExcelAttachToExistingInstance["Workflow"] = ExpressionConverter.ConvertO(mSExcelAttachToExistingInstanceworkflow);
            if (mSExcelAttachToExistingInstancepropCount > 0)
            {
                callPayload.Body = mSExcelAttachToExistingInstance;
            }

            return new ApiConnectionAction<MSExcelAttachToExistingInstanceResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelShowExcel(Expression<Func<string>> mSExcelShowExcelworkflow, Expression<Func<int>> mSExcelShowExcelhandle = null)
        {
            var apiCallPath = "/MSExcel/ShowExcel";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelShowExcel = new JObject();
            var mSExcelShowExcelpropCount = 0;
            if (mSExcelShowExcelhandle != null)
            {
                mSExcelShowExcel["Handle"] = ExpressionConverter.ConvertO(mSExcelShowExcelhandle);
                mSExcelShowExcelpropCount++;
            }

            mSExcelShowExcelpropCount++;
            mSExcelShowExcel["Workflow"] = ExpressionConverter.ConvertO(mSExcelShowExcelworkflow);
            if (mSExcelShowExcelpropCount > 0)
            {
                callPayload.Body = mSExcelShowExcel;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelHideExcel(Expression<Func<string>> mSExcelHideExcelworkflow, Expression<Func<int>> mSExcelHideExcelhandle = null)
        {
            var apiCallPath = "/MSExcel/HideExcel";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelHideExcel = new JObject();
            var mSExcelHideExcelpropCount = 0;
            if (mSExcelHideExcelhandle != null)
            {
                mSExcelHideExcel["Handle"] = ExpressionConverter.ConvertO(mSExcelHideExcelhandle);
                mSExcelHideExcelpropCount++;
            }

            mSExcelHideExcelpropCount++;
            mSExcelHideExcel["Workflow"] = ExpressionConverter.ConvertO(mSExcelHideExcelworkflow);
            if (mSExcelHideExcelpropCount > 0)
            {
                callPayload.Body = mSExcelHideExcel;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelOpenWorkbookResponse> MSExcelOpenWorkbook(Expression<Func<string>> mSExcelOpenWorkbookworkflow, Expression<Func<int>> mSExcelOpenWorkbookhandle = null, Expression<Func<string>> mSExcelOpenWorkbookfilename = null, Expression<Func<bool>> mSExcelOpenWorkbookreadOnly = null, Expression<Func<bool>> mSExcelOpenWorkbookupdateLinks = null, Expression<Func<string>> mSExcelOpenWorkbookpassword = null, Expression<Func<bool>> mSExcelOpenWorkbookenableEvents = null, Expression<Func<bool>> mSExcelOpenWorkbookputHTTPWorkbooksIntoEditMode = null, Expression<Func<bool>> mSExcelOpenWorkbookputFilePathWorkbooksIntoEditMode = null)
        {
            var apiCallPath = "/MSExcel/OpenWorkbook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelOpenWorkbook = new JObject();
            var mSExcelOpenWorkbookpropCount = 0;
            if (mSExcelOpenWorkbookhandle != null)
            {
                mSExcelOpenWorkbook["Handle"] = ExpressionConverter.ConvertO(mSExcelOpenWorkbookhandle);
                mSExcelOpenWorkbookpropCount++;
            }

            if (mSExcelOpenWorkbookfilename != null)
            {
                mSExcelOpenWorkbook["Filename"] = ExpressionConverter.ConvertO(mSExcelOpenWorkbookfilename);
                mSExcelOpenWorkbookpropCount++;
            }

            if (mSExcelOpenWorkbookreadOnly != null)
            {
                mSExcelOpenWorkbook["ReadOnly"] = ExpressionConverter.ConvertO(mSExcelOpenWorkbookreadOnly);
                mSExcelOpenWorkbookpropCount++;
            }

            if (mSExcelOpenWorkbookupdateLinks != null)
            {
                mSExcelOpenWorkbook["UpdateLinks"] = ExpressionConverter.ConvertO(mSExcelOpenWorkbookupdateLinks);
                mSExcelOpenWorkbookpropCount++;
            }

            if (mSExcelOpenWorkbookpassword != null)
            {
                mSExcelOpenWorkbook["Password"] = ExpressionConverter.ConvertO(mSExcelOpenWorkbookpassword);
                mSExcelOpenWorkbookpropCount++;
            }

            if (mSExcelOpenWorkbookenableEvents != null)
            {
                mSExcelOpenWorkbook["EnableEvents"] = ExpressionConverter.ConvertO(mSExcelOpenWorkbookenableEvents);
                mSExcelOpenWorkbookpropCount++;
            }

            if (mSExcelOpenWorkbookputHTTPWorkbooksIntoEditMode != null)
            {
                mSExcelOpenWorkbook["PutHTTPWorkbooksIntoEditMode"] = ExpressionConverter.ConvertO(mSExcelOpenWorkbookputHTTPWorkbooksIntoEditMode);
                mSExcelOpenWorkbookpropCount++;
            }

            if (mSExcelOpenWorkbookputFilePathWorkbooksIntoEditMode != null)
            {
                mSExcelOpenWorkbook["PutFilePathWorkbooksIntoEditMode"] = ExpressionConverter.ConvertO(mSExcelOpenWorkbookputFilePathWorkbooksIntoEditMode);
                mSExcelOpenWorkbookpropCount++;
            }

            mSExcelOpenWorkbookpropCount++;
            mSExcelOpenWorkbook["Workflow"] = ExpressionConverter.ConvertO(mSExcelOpenWorkbookworkflow);
            if (mSExcelOpenWorkbookpropCount > 0)
            {
                callPayload.Body = mSExcelOpenWorkbook;
            }

            return new ApiConnectionAction<MSExcelOpenWorkbookResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelPutWorkbookInEditModeResponse> MSExcelPutWorkbookInEditMode(Expression<Func<string>> mSExcelPutWorkbookInEditModeworkflow, Expression<Func<int>> mSExcelPutWorkbookInEditModehandle = null, Expression<Func<string>> mSExcelPutWorkbookInEditModeworkbookName = null, Expression<Func<bool>> mSExcelPutWorkbookInEditModeforce = null)
        {
            var apiCallPath = "/MSExcel/PutWorkbookInEditMode";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelPutWorkbookInEditMode = new JObject();
            var mSExcelPutWorkbookInEditModepropCount = 0;
            if (mSExcelPutWorkbookInEditModehandle != null)
            {
                mSExcelPutWorkbookInEditMode["Handle"] = ExpressionConverter.ConvertO(mSExcelPutWorkbookInEditModehandle);
                mSExcelPutWorkbookInEditModepropCount++;
            }

            if (mSExcelPutWorkbookInEditModeworkbookName != null)
            {
                mSExcelPutWorkbookInEditMode["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelPutWorkbookInEditModeworkbookName);
                mSExcelPutWorkbookInEditModepropCount++;
            }

            if (mSExcelPutWorkbookInEditModeforce != null)
            {
                mSExcelPutWorkbookInEditMode["Force"] = ExpressionConverter.ConvertO(mSExcelPutWorkbookInEditModeforce);
                mSExcelPutWorkbookInEditModepropCount++;
            }

            mSExcelPutWorkbookInEditModepropCount++;
            mSExcelPutWorkbookInEditMode["Workflow"] = ExpressionConverter.ConvertO(mSExcelPutWorkbookInEditModeworkflow);
            if (mSExcelPutWorkbookInEditModepropCount > 0)
            {
                callPayload.Body = mSExcelPutWorkbookInEditMode;
            }

            return new ApiConnectionAction<MSExcelPutWorkbookInEditModeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelCreateWorkbookResponse> MSExcelCreateWorkbook(Expression<Func<string>> mSExcelCreateWorkbookworkflow, Expression<Func<int>> mSExcelCreateWorkbookhandle = null)
        {
            var apiCallPath = "/MSExcel/CreateWorkbook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelCreateWorkbook = new JObject();
            var mSExcelCreateWorkbookpropCount = 0;
            if (mSExcelCreateWorkbookhandle != null)
            {
                mSExcelCreateWorkbook["Handle"] = ExpressionConverter.ConvertO(mSExcelCreateWorkbookhandle);
                mSExcelCreateWorkbookpropCount++;
            }

            mSExcelCreateWorkbookpropCount++;
            mSExcelCreateWorkbook["Workflow"] = ExpressionConverter.ConvertO(mSExcelCreateWorkbookworkflow);
            if (mSExcelCreateWorkbookpropCount > 0)
            {
                callPayload.Body = mSExcelCreateWorkbook;
            }

            return new ApiConnectionAction<MSExcelCreateWorkbookResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelCloseWorkbook(Expression<Func<string>> mSExcelCloseWorkbookworkflow, Expression<Func<int>> mSExcelCloseWorkbookhandle = null, Expression<Func<string>> mSExcelCloseWorkbookworkbookName = null, Expression<Func<bool>> mSExcelCloseWorkbooksaveData = null)
        {
            var apiCallPath = "/MSExcel/CloseWorkbook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelCloseWorkbook = new JObject();
            var mSExcelCloseWorkbookpropCount = 0;
            if (mSExcelCloseWorkbookhandle != null)
            {
                mSExcelCloseWorkbook["Handle"] = ExpressionConverter.ConvertO(mSExcelCloseWorkbookhandle);
                mSExcelCloseWorkbookpropCount++;
            }

            if (mSExcelCloseWorkbookworkbookName != null)
            {
                mSExcelCloseWorkbook["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelCloseWorkbookworkbookName);
                mSExcelCloseWorkbookpropCount++;
            }

            if (mSExcelCloseWorkbooksaveData != null)
            {
                mSExcelCloseWorkbook["SaveData"] = ExpressionConverter.ConvertO(mSExcelCloseWorkbooksaveData);
                mSExcelCloseWorkbookpropCount++;
            }

            mSExcelCloseWorkbookpropCount++;
            mSExcelCloseWorkbook["Workflow"] = ExpressionConverter.ConvertO(mSExcelCloseWorkbookworkflow);
            if (mSExcelCloseWorkbookpropCount > 0)
            {
                callPayload.Body = mSExcelCloseWorkbook;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelCloseCurrentWorkbook(Expression<Func<string>> mSExcelCloseCurrentWorkbookworkflow, Expression<Func<int>> mSExcelCloseCurrentWorkbookhandle = null)
        {
            var apiCallPath = "/MSExcel/CloseCurrentWorkbook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelCloseCurrentWorkbook = new JObject();
            var mSExcelCloseCurrentWorkbookpropCount = 0;
            if (mSExcelCloseCurrentWorkbookhandle != null)
            {
                mSExcelCloseCurrentWorkbook["Handle"] = ExpressionConverter.ConvertO(mSExcelCloseCurrentWorkbookhandle);
                mSExcelCloseCurrentWorkbookpropCount++;
            }

            mSExcelCloseCurrentWorkbookpropCount++;
            mSExcelCloseCurrentWorkbook["Workflow"] = ExpressionConverter.ConvertO(mSExcelCloseCurrentWorkbookworkflow);
            if (mSExcelCloseCurrentWorkbookpropCount > 0)
            {
                callPayload.Body = mSExcelCloseCurrentWorkbook;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelGoToCell(Expression<Func<string>> mSExcelGoToCellcellReference, Expression<Func<string>> mSExcelGoToCellworkflow, Expression<Func<int>> mSExcelGoToCellhandle = null, Expression<Func<string>> mSExcelGoToCellworkbookName = null, Expression<Func<string>> mSExcelGoToCellworksheetName = null)
        {
            var apiCallPath = "/MSExcel/GoToCell";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelGoToCell = new JObject();
            var mSExcelGoToCellpropCount = 0;
            if (mSExcelGoToCellhandle != null)
            {
                mSExcelGoToCell["Handle"] = ExpressionConverter.ConvertO(mSExcelGoToCellhandle);
                mSExcelGoToCellpropCount++;
            }

            if (mSExcelGoToCellworkbookName != null)
            {
                mSExcelGoToCell["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelGoToCellworkbookName);
                mSExcelGoToCellpropCount++;
            }

            if (mSExcelGoToCellworksheetName != null)
            {
                mSExcelGoToCell["WorksheetName"] = ExpressionConverter.ConvertO(mSExcelGoToCellworksheetName);
                mSExcelGoToCellpropCount++;
            }

            mSExcelGoToCellpropCount++;
            mSExcelGoToCell["CellReference"] = ExpressionConverter.ConvertO(mSExcelGoToCellcellReference);
            mSExcelGoToCellpropCount++;
            mSExcelGoToCell["Workflow"] = ExpressionConverter.ConvertO(mSExcelGoToCellworkflow);
            if (mSExcelGoToCellpropCount > 0)
            {
                callPayload.Body = mSExcelGoToCell;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetCellValueResponse> MSExcelGetCellValue(Expression<Func<string>> mSExcelGetCellValuecellReference, Expression<Func<string>> mSExcelGetCellValueworkflow, Expression<Func<int>> mSExcelGetCellValuehandle = null, Expression<Func<string>> mSExcelGetCellValueworkbookName = null, Expression<Func<string>> mSExcelGetCellValueworksheetName = null)
        {
            var apiCallPath = "/MSExcel/GetCellValue";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelGetCellValue = new JObject();
            var mSExcelGetCellValuepropCount = 0;
            if (mSExcelGetCellValuehandle != null)
            {
                mSExcelGetCellValue["Handle"] = ExpressionConverter.ConvertO(mSExcelGetCellValuehandle);
                mSExcelGetCellValuepropCount++;
            }

            if (mSExcelGetCellValueworkbookName != null)
            {
                mSExcelGetCellValue["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelGetCellValueworkbookName);
                mSExcelGetCellValuepropCount++;
            }

            if (mSExcelGetCellValueworksheetName != null)
            {
                mSExcelGetCellValue["WorksheetName"] = ExpressionConverter.ConvertO(mSExcelGetCellValueworksheetName);
                mSExcelGetCellValuepropCount++;
            }

            mSExcelGetCellValuepropCount++;
            mSExcelGetCellValue["CellReference"] = ExpressionConverter.ConvertO(mSExcelGetCellValuecellReference);
            mSExcelGetCellValuepropCount++;
            mSExcelGetCellValue["Workflow"] = ExpressionConverter.ConvertO(mSExcelGetCellValueworkflow);
            if (mSExcelGetCellValuepropCount > 0)
            {
                callPayload.Body = mSExcelGetCellValue;
            }

            return new ApiConnectionAction<MSExcelGetCellValueResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetCellValue2Response> MSExcelGetCellValue2(Expression<Func<string>> mSExcelGetCellValue2cellReference, Expression<Func<string>> mSExcelGetCellValue2workflow, Expression<Func<int>> mSExcelGetCellValue2handle = null, Expression<Func<string>> mSExcelGetCellValue2workbookName = null, Expression<Func<string>> mSExcelGetCellValue2worksheetName = null)
        {
            var apiCallPath = "/MSExcel/GetCellValue2";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelGetCellValue2 = new JObject();
            var mSExcelGetCellValue2propCount = 0;
            if (mSExcelGetCellValue2handle != null)
            {
                mSExcelGetCellValue2["Handle"] = ExpressionConverter.ConvertO(mSExcelGetCellValue2handle);
                mSExcelGetCellValue2propCount++;
            }

            if (mSExcelGetCellValue2workbookName != null)
            {
                mSExcelGetCellValue2["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelGetCellValue2workbookName);
                mSExcelGetCellValue2propCount++;
            }

            if (mSExcelGetCellValue2worksheetName != null)
            {
                mSExcelGetCellValue2["WorksheetName"] = ExpressionConverter.ConvertO(mSExcelGetCellValue2worksheetName);
                mSExcelGetCellValue2propCount++;
            }

            mSExcelGetCellValue2propCount++;
            mSExcelGetCellValue2["CellReference"] = ExpressionConverter.ConvertO(mSExcelGetCellValue2cellReference);
            mSExcelGetCellValue2propCount++;
            mSExcelGetCellValue2["Workflow"] = ExpressionConverter.ConvertO(mSExcelGetCellValue2workflow);
            if (mSExcelGetCellValue2propCount > 0)
            {
                callPayload.Body = mSExcelGetCellValue2;
            }

            return new ApiConnectionAction<MSExcelGetCellValue2Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetCellTextResponse> MSExcelGetCellText(Expression<Func<string>> mSExcelGetCellTextcellReference, Expression<Func<string>> mSExcelGetCellTextworkflow, Expression<Func<int>> mSExcelGetCellTexthandle = null, Expression<Func<string>> mSExcelGetCellTextworkbookName = null, Expression<Func<string>> mSExcelGetCellTextworksheetName = null)
        {
            var apiCallPath = "/MSExcel/GetCellText";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelGetCellText = new JObject();
            var mSExcelGetCellTextpropCount = 0;
            if (mSExcelGetCellTexthandle != null)
            {
                mSExcelGetCellText["Handle"] = ExpressionConverter.ConvertO(mSExcelGetCellTexthandle);
                mSExcelGetCellTextpropCount++;
            }

            if (mSExcelGetCellTextworkbookName != null)
            {
                mSExcelGetCellText["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelGetCellTextworkbookName);
                mSExcelGetCellTextpropCount++;
            }

            if (mSExcelGetCellTextworksheetName != null)
            {
                mSExcelGetCellText["WorksheetName"] = ExpressionConverter.ConvertO(mSExcelGetCellTextworksheetName);
                mSExcelGetCellTextpropCount++;
            }

            mSExcelGetCellTextpropCount++;
            mSExcelGetCellText["CellReference"] = ExpressionConverter.ConvertO(mSExcelGetCellTextcellReference);
            mSExcelGetCellTextpropCount++;
            mSExcelGetCellText["Workflow"] = ExpressionConverter.ConvertO(mSExcelGetCellTextworkflow);
            if (mSExcelGetCellTextpropCount > 0)
            {
                callPayload.Body = mSExcelGetCellText;
            }

            return new ApiConnectionAction<MSExcelGetCellTextResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelSetCellValue(Expression<Func<string>> mSExcelSetCellValuecellReference, Expression<Func<string>> mSExcelSetCellValueworkflow, Expression<Func<int>> mSExcelSetCellValuehandle = null, Expression<Func<string>> mSExcelSetCellValueworkbookName = null, Expression<Func<string>> mSExcelSetCellValueworksheetName = null, Expression<Func<string>> mSExcelSetCellValuecellValue = null, Expression<Func<bool>> mSExcelSetCellValuecellValueContainsStoredPassword = null)
        {
            var apiCallPath = "/MSExcel/SetCellValue";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelSetCellValue = new JObject();
            var mSExcelSetCellValuepropCount = 0;
            if (mSExcelSetCellValuehandle != null)
            {
                mSExcelSetCellValue["Handle"] = ExpressionConverter.ConvertO(mSExcelSetCellValuehandle);
                mSExcelSetCellValuepropCount++;
            }

            if (mSExcelSetCellValueworkbookName != null)
            {
                mSExcelSetCellValue["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelSetCellValueworkbookName);
                mSExcelSetCellValuepropCount++;
            }

            if (mSExcelSetCellValueworksheetName != null)
            {
                mSExcelSetCellValue["WorksheetName"] = ExpressionConverter.ConvertO(mSExcelSetCellValueworksheetName);
                mSExcelSetCellValuepropCount++;
            }

            mSExcelSetCellValuepropCount++;
            mSExcelSetCellValue["CellReference"] = ExpressionConverter.ConvertO(mSExcelSetCellValuecellReference);
            if (mSExcelSetCellValuecellValue != null)
            {
                mSExcelSetCellValue["CellValue"] = ExpressionConverter.ConvertO(mSExcelSetCellValuecellValue);
                mSExcelSetCellValuepropCount++;
            }

            if (mSExcelSetCellValuecellValueContainsStoredPassword != null)
            {
                mSExcelSetCellValue["CellValueContainsStoredPassword"] = ExpressionConverter.ConvertO(mSExcelSetCellValuecellValueContainsStoredPassword);
                mSExcelSetCellValuepropCount++;
            }

            mSExcelSetCellValuepropCount++;
            mSExcelSetCellValue["Workflow"] = ExpressionConverter.ConvertO(mSExcelSetCellValueworkflow);
            if (mSExcelSetCellValuepropCount > 0)
            {
                callPayload.Body = mSExcelSetCellValue;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelFindNextCellWithValueResponse> MSExcelFindNextCellWithValue(Expression<Func<mSExcelFindNextCellWithValuedirectionInput>> mSExcelFindNextCellWithValuedirection, Expression<Func<string>> mSExcelFindNextCellWithValuesearchValue, Expression<Func<string>> mSExcelFindNextCellWithValueworkflow, Expression<Func<int>> mSExcelFindNextCellWithValuehandle = null, Expression<Func<string>> mSExcelFindNextCellWithValueworkbookName = null, Expression<Func<string>> mSExcelFindNextCellWithValueworksheetName = null, Expression<Func<bool>> mSExcelFindNextCellWithValuecaseSensitive = null, Expression<Func<mSExcelFindNextCellWithValuecomparisonTypeInput>> mSExcelFindNextCellWithValuecomparisonType = null, Expression<Func<int>> mSExcelFindNextCellWithValuemaxCellsToSearch = null, Expression<Func<bool>> mSExcelFindNextCellWithValueactivateCell = null)
        {
            var apiCallPath = "/MSExcel/FindNextCellWithValue";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelFindNextCellWithValue = new JObject();
            var mSExcelFindNextCellWithValuepropCount = 0;
            if (mSExcelFindNextCellWithValuehandle != null)
            {
                mSExcelFindNextCellWithValue["Handle"] = ExpressionConverter.ConvertO(mSExcelFindNextCellWithValuehandle);
                mSExcelFindNextCellWithValuepropCount++;
            }

            if (mSExcelFindNextCellWithValueworkbookName != null)
            {
                mSExcelFindNextCellWithValue["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelFindNextCellWithValueworkbookName);
                mSExcelFindNextCellWithValuepropCount++;
            }

            if (mSExcelFindNextCellWithValueworksheetName != null)
            {
                mSExcelFindNextCellWithValue["WorksheetName"] = ExpressionConverter.ConvertO(mSExcelFindNextCellWithValueworksheetName);
                mSExcelFindNextCellWithValuepropCount++;
            }

            mSExcelFindNextCellWithValuepropCount++;
            mSExcelFindNextCellWithValue["Direction"] = ExpressionConverter.ConvertO(mSExcelFindNextCellWithValuedirection);
            mSExcelFindNextCellWithValuepropCount++;
            mSExcelFindNextCellWithValue["SearchValue"] = ExpressionConverter.ConvertO(mSExcelFindNextCellWithValuesearchValue);
            if (mSExcelFindNextCellWithValuecaseSensitive != null)
            {
                mSExcelFindNextCellWithValue["CaseSensitive"] = ExpressionConverter.ConvertO(mSExcelFindNextCellWithValuecaseSensitive);
                mSExcelFindNextCellWithValuepropCount++;
            }

            if (mSExcelFindNextCellWithValuecomparisonType != null)
            {
                mSExcelFindNextCellWithValue["ComparisonType"] = ExpressionConverter.ConvertO(mSExcelFindNextCellWithValuecomparisonType);
                mSExcelFindNextCellWithValuepropCount++;
            }

            if (mSExcelFindNextCellWithValuemaxCellsToSearch != null)
            {
                mSExcelFindNextCellWithValue["MaxCellsToSearch"] = ExpressionConverter.ConvertO(mSExcelFindNextCellWithValuemaxCellsToSearch);
                mSExcelFindNextCellWithValuepropCount++;
            }

            if (mSExcelFindNextCellWithValueactivateCell != null)
            {
                mSExcelFindNextCellWithValue["ActivateCell"] = ExpressionConverter.ConvertO(mSExcelFindNextCellWithValueactivateCell);
                mSExcelFindNextCellWithValuepropCount++;
            }

            mSExcelFindNextCellWithValuepropCount++;
            mSExcelFindNextCellWithValue["Workflow"] = ExpressionConverter.ConvertO(mSExcelFindNextCellWithValueworkflow);
            if (mSExcelFindNextCellWithValuepropCount > 0)
            {
                callPayload.Body = mSExcelFindNextCellWithValue;
            }

            return new ApiConnectionAction<MSExcelFindNextCellWithValueResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelFindNextEmptyCellResponse> MSExcelFindNextEmptyCell(Expression<Func<mSExcelFindNextEmptyCelldirectionInput>> mSExcelFindNextEmptyCelldirection, Expression<Func<string>> mSExcelFindNextEmptyCellworkflow, Expression<Func<int>> mSExcelFindNextEmptyCellhandle = null, Expression<Func<string>> mSExcelFindNextEmptyCellworkbookName = null, Expression<Func<string>> mSExcelFindNextEmptyCellworksheetName = null, Expression<Func<bool>> mSExcelFindNextEmptyCellactivateCell = null)
        {
            var apiCallPath = "/MSExcel/FindNextEmptyCell";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelFindNextEmptyCell = new JObject();
            var mSExcelFindNextEmptyCellpropCount = 0;
            if (mSExcelFindNextEmptyCellhandle != null)
            {
                mSExcelFindNextEmptyCell["Handle"] = ExpressionConverter.ConvertO(mSExcelFindNextEmptyCellhandle);
                mSExcelFindNextEmptyCellpropCount++;
            }

            if (mSExcelFindNextEmptyCellworkbookName != null)
            {
                mSExcelFindNextEmptyCell["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelFindNextEmptyCellworkbookName);
                mSExcelFindNextEmptyCellpropCount++;
            }

            if (mSExcelFindNextEmptyCellworksheetName != null)
            {
                mSExcelFindNextEmptyCell["WorksheetName"] = ExpressionConverter.ConvertO(mSExcelFindNextEmptyCellworksheetName);
                mSExcelFindNextEmptyCellpropCount++;
            }

            mSExcelFindNextEmptyCellpropCount++;
            mSExcelFindNextEmptyCell["Direction"] = ExpressionConverter.ConvertO(mSExcelFindNextEmptyCelldirection);
            if (mSExcelFindNextEmptyCellactivateCell != null)
            {
                mSExcelFindNextEmptyCell["ActivateCell"] = ExpressionConverter.ConvertO(mSExcelFindNextEmptyCellactivateCell);
                mSExcelFindNextEmptyCellpropCount++;
            }

            mSExcelFindNextEmptyCellpropCount++;
            mSExcelFindNextEmptyCell["Workflow"] = ExpressionConverter.ConvertO(mSExcelFindNextEmptyCellworkflow);
            if (mSExcelFindNextEmptyCellpropCount > 0)
            {
                callPayload.Body = mSExcelFindNextEmptyCell;
            }

            return new ApiConnectionAction<MSExcelFindNextEmptyCellResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGotoNextEmptyCellLeftResponse> MSExcelGotoNextEmptyCellLeft(Expression<Func<string>> mSExcelGotoNextEmptyCellLeftworkflow, Expression<Func<int>> mSExcelGotoNextEmptyCellLefthandle = null, Expression<Func<string>> mSExcelGotoNextEmptyCellLeftworkbookName = null, Expression<Func<string>> mSExcelGotoNextEmptyCellLeftworksheetName = null)
        {
            var apiCallPath = "/MSExcel/GotoNextEmptyCellLeft";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelGotoNextEmptyCellLeft = new JObject();
            var mSExcelGotoNextEmptyCellLeftpropCount = 0;
            if (mSExcelGotoNextEmptyCellLefthandle != null)
            {
                mSExcelGotoNextEmptyCellLeft["Handle"] = ExpressionConverter.ConvertO(mSExcelGotoNextEmptyCellLefthandle);
                mSExcelGotoNextEmptyCellLeftpropCount++;
            }

            if (mSExcelGotoNextEmptyCellLeftworkbookName != null)
            {
                mSExcelGotoNextEmptyCellLeft["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelGotoNextEmptyCellLeftworkbookName);
                mSExcelGotoNextEmptyCellLeftpropCount++;
            }

            if (mSExcelGotoNextEmptyCellLeftworksheetName != null)
            {
                mSExcelGotoNextEmptyCellLeft["WorksheetName"] = ExpressionConverter.ConvertO(mSExcelGotoNextEmptyCellLeftworksheetName);
                mSExcelGotoNextEmptyCellLeftpropCount++;
            }

            mSExcelGotoNextEmptyCellLeftpropCount++;
            mSExcelGotoNextEmptyCellLeft["Workflow"] = ExpressionConverter.ConvertO(mSExcelGotoNextEmptyCellLeftworkflow);
            if (mSExcelGotoNextEmptyCellLeftpropCount > 0)
            {
                callPayload.Body = mSExcelGotoNextEmptyCellLeft;
            }

            return new ApiConnectionAction<MSExcelGotoNextEmptyCellLeftResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGotoNextEmptyCellRightResponse> MSExcelGotoNextEmptyCellRight(Expression<Func<string>> mSExcelGotoNextEmptyCellRightworkflow, Expression<Func<int>> mSExcelGotoNextEmptyCellRighthandle = null, Expression<Func<string>> mSExcelGotoNextEmptyCellRightworkbookName = null, Expression<Func<string>> mSExcelGotoNextEmptyCellRightworksheetName = null)
        {
            var apiCallPath = "/MSExcel/GotoNextEmptyCellRight";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelGotoNextEmptyCellRight = new JObject();
            var mSExcelGotoNextEmptyCellRightpropCount = 0;
            if (mSExcelGotoNextEmptyCellRighthandle != null)
            {
                mSExcelGotoNextEmptyCellRight["Handle"] = ExpressionConverter.ConvertO(mSExcelGotoNextEmptyCellRighthandle);
                mSExcelGotoNextEmptyCellRightpropCount++;
            }

            if (mSExcelGotoNextEmptyCellRightworkbookName != null)
            {
                mSExcelGotoNextEmptyCellRight["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelGotoNextEmptyCellRightworkbookName);
                mSExcelGotoNextEmptyCellRightpropCount++;
            }

            if (mSExcelGotoNextEmptyCellRightworksheetName != null)
            {
                mSExcelGotoNextEmptyCellRight["WorksheetName"] = ExpressionConverter.ConvertO(mSExcelGotoNextEmptyCellRightworksheetName);
                mSExcelGotoNextEmptyCellRightpropCount++;
            }

            mSExcelGotoNextEmptyCellRightpropCount++;
            mSExcelGotoNextEmptyCellRight["Workflow"] = ExpressionConverter.ConvertO(mSExcelGotoNextEmptyCellRightworkflow);
            if (mSExcelGotoNextEmptyCellRightpropCount > 0)
            {
                callPayload.Body = mSExcelGotoNextEmptyCellRight;
            }

            return new ApiConnectionAction<MSExcelGotoNextEmptyCellRightResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGotoNextEmptyCellUpResponse> MSExcelGotoNextEmptyCellUp(Expression<Func<string>> mSExcelGotoNextEmptyCellUpworkflow, Expression<Func<int>> mSExcelGotoNextEmptyCellUphandle = null, Expression<Func<string>> mSExcelGotoNextEmptyCellUpworkbookName = null, Expression<Func<string>> mSExcelGotoNextEmptyCellUpworksheetName = null)
        {
            var apiCallPath = "/MSExcel/GotoNextEmptyCellUp";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelGotoNextEmptyCellUp = new JObject();
            var mSExcelGotoNextEmptyCellUppropCount = 0;
            if (mSExcelGotoNextEmptyCellUphandle != null)
            {
                mSExcelGotoNextEmptyCellUp["Handle"] = ExpressionConverter.ConvertO(mSExcelGotoNextEmptyCellUphandle);
                mSExcelGotoNextEmptyCellUppropCount++;
            }

            if (mSExcelGotoNextEmptyCellUpworkbookName != null)
            {
                mSExcelGotoNextEmptyCellUp["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelGotoNextEmptyCellUpworkbookName);
                mSExcelGotoNextEmptyCellUppropCount++;
            }

            if (mSExcelGotoNextEmptyCellUpworksheetName != null)
            {
                mSExcelGotoNextEmptyCellUp["WorksheetName"] = ExpressionConverter.ConvertO(mSExcelGotoNextEmptyCellUpworksheetName);
                mSExcelGotoNextEmptyCellUppropCount++;
            }

            mSExcelGotoNextEmptyCellUppropCount++;
            mSExcelGotoNextEmptyCellUp["Workflow"] = ExpressionConverter.ConvertO(mSExcelGotoNextEmptyCellUpworkflow);
            if (mSExcelGotoNextEmptyCellUppropCount > 0)
            {
                callPayload.Body = mSExcelGotoNextEmptyCellUp;
            }

            return new ApiConnectionAction<MSExcelGotoNextEmptyCellUpResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGotoNextEmptyCellDownResponse> MSExcelGotoNextEmptyCellDown(Expression<Func<string>> mSExcelGotoNextEmptyCellDownworkflow, Expression<Func<int>> mSExcelGotoNextEmptyCellDownhandle = null, Expression<Func<string>> mSExcelGotoNextEmptyCellDownworkbookName = null, Expression<Func<string>> mSExcelGotoNextEmptyCellDownworksheetName = null)
        {
            var apiCallPath = "/MSExcel/GotoNextEmptyCellDown";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelGotoNextEmptyCellDown = new JObject();
            var mSExcelGotoNextEmptyCellDownpropCount = 0;
            if (mSExcelGotoNextEmptyCellDownhandle != null)
            {
                mSExcelGotoNextEmptyCellDown["Handle"] = ExpressionConverter.ConvertO(mSExcelGotoNextEmptyCellDownhandle);
                mSExcelGotoNextEmptyCellDownpropCount++;
            }

            if (mSExcelGotoNextEmptyCellDownworkbookName != null)
            {
                mSExcelGotoNextEmptyCellDown["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelGotoNextEmptyCellDownworkbookName);
                mSExcelGotoNextEmptyCellDownpropCount++;
            }

            if (mSExcelGotoNextEmptyCellDownworksheetName != null)
            {
                mSExcelGotoNextEmptyCellDown["WorksheetName"] = ExpressionConverter.ConvertO(mSExcelGotoNextEmptyCellDownworksheetName);
                mSExcelGotoNextEmptyCellDownpropCount++;
            }

            mSExcelGotoNextEmptyCellDownpropCount++;
            mSExcelGotoNextEmptyCellDown["Workflow"] = ExpressionConverter.ConvertO(mSExcelGotoNextEmptyCellDownworkflow);
            if (mSExcelGotoNextEmptyCellDownpropCount > 0)
            {
                callPayload.Body = mSExcelGotoNextEmptyCellDown;
            }

            return new ApiConnectionAction<MSExcelGotoNextEmptyCellDownResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelSaveWorkbookResponse> MSExcelSaveWorkbook(Expression<Func<string>> mSExcelSaveWorkbookworkflow, Expression<Func<int>> mSExcelSaveWorkbookhandle = null, Expression<Func<string>> mSExcelSaveWorkbookworkbookName = null)
        {
            var apiCallPath = "/MSExcel/SaveWorkbook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelSaveWorkbook = new JObject();
            var mSExcelSaveWorkbookpropCount = 0;
            if (mSExcelSaveWorkbookhandle != null)
            {
                mSExcelSaveWorkbook["Handle"] = ExpressionConverter.ConvertO(mSExcelSaveWorkbookhandle);
                mSExcelSaveWorkbookpropCount++;
            }

            if (mSExcelSaveWorkbookworkbookName != null)
            {
                mSExcelSaveWorkbook["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelSaveWorkbookworkbookName);
                mSExcelSaveWorkbookpropCount++;
            }

            mSExcelSaveWorkbookpropCount++;
            mSExcelSaveWorkbook["Workflow"] = ExpressionConverter.ConvertO(mSExcelSaveWorkbookworkflow);
            if (mSExcelSaveWorkbookpropCount > 0)
            {
                callPayload.Body = mSExcelSaveWorkbook;
            }

            return new ApiConnectionAction<MSExcelSaveWorkbookResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelSaveWorkbookAsResponse> MSExcelSaveWorkbookAs(Expression<Func<string>> mSExcelSaveWorkbookAssaveFilename, Expression<Func<string>> mSExcelSaveWorkbookAsworkflow, Expression<Func<int>> mSExcelSaveWorkbookAshandle = null, Expression<Func<string>> mSExcelSaveWorkbookAsworkbookName = null, Expression<Func<bool>> mSExcelSaveWorkbookAsdeleteExistingSaveFilename = null, Expression<Func<mSExcelSaveWorkbookAsexcelFileFormatInput>> mSExcelSaveWorkbookAsexcelFileFormat = null)
        {
            var apiCallPath = "/MSExcel/SaveWorkbookAs";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelSaveWorkbookAs = new JObject();
            var mSExcelSaveWorkbookAspropCount = 0;
            if (mSExcelSaveWorkbookAshandle != null)
            {
                mSExcelSaveWorkbookAs["Handle"] = ExpressionConverter.ConvertO(mSExcelSaveWorkbookAshandle);
                mSExcelSaveWorkbookAspropCount++;
            }

            if (mSExcelSaveWorkbookAsworkbookName != null)
            {
                mSExcelSaveWorkbookAs["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelSaveWorkbookAsworkbookName);
                mSExcelSaveWorkbookAspropCount++;
            }

            mSExcelSaveWorkbookAspropCount++;
            mSExcelSaveWorkbookAs["SaveFilename"] = ExpressionConverter.ConvertO(mSExcelSaveWorkbookAssaveFilename);
            if (mSExcelSaveWorkbookAsdeleteExistingSaveFilename != null)
            {
                mSExcelSaveWorkbookAs["DeleteExistingSaveFilename"] = ExpressionConverter.ConvertO(mSExcelSaveWorkbookAsdeleteExistingSaveFilename);
                mSExcelSaveWorkbookAspropCount++;
            }

            if (mSExcelSaveWorkbookAsexcelFileFormat != null)
            {
                mSExcelSaveWorkbookAs["ExcelFileFormat"] = ExpressionConverter.ConvertO(mSExcelSaveWorkbookAsexcelFileFormat);
                mSExcelSaveWorkbookAspropCount++;
            }

            mSExcelSaveWorkbookAspropCount++;
            mSExcelSaveWorkbookAs["Workflow"] = ExpressionConverter.ConvertO(mSExcelSaveWorkbookAsworkflow);
            if (mSExcelSaveWorkbookAspropCount > 0)
            {
                callPayload.Body = mSExcelSaveWorkbookAs;
            }

            return new ApiConnectionAction<MSExcelSaveWorkbookAsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelSaveWorkbookAsCSVResponse> MSExcelSaveWorkbookAsCSV(Expression<Func<string>> mSExcelSaveWorkbookAsCSVsaveFilename, Expression<Func<string>> mSExcelSaveWorkbookAsCSVworkflow, Expression<Func<int>> mSExcelSaveWorkbookAsCSVhandle = null, Expression<Func<string>> mSExcelSaveWorkbookAsCSVworkbookName = null, Expression<Func<bool>> mSExcelSaveWorkbookAsCSVdeleteExistingSaveFilename = null)
        {
            var apiCallPath = "/MSExcel/SaveWorkbookAsCSV";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelSaveWorkbookAsCSV = new JObject();
            var mSExcelSaveWorkbookAsCSVpropCount = 0;
            if (mSExcelSaveWorkbookAsCSVhandle != null)
            {
                mSExcelSaveWorkbookAsCSV["Handle"] = ExpressionConverter.ConvertO(mSExcelSaveWorkbookAsCSVhandle);
                mSExcelSaveWorkbookAsCSVpropCount++;
            }

            if (mSExcelSaveWorkbookAsCSVworkbookName != null)
            {
                mSExcelSaveWorkbookAsCSV["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelSaveWorkbookAsCSVworkbookName);
                mSExcelSaveWorkbookAsCSVpropCount++;
            }

            mSExcelSaveWorkbookAsCSVpropCount++;
            mSExcelSaveWorkbookAsCSV["SaveFilename"] = ExpressionConverter.ConvertO(mSExcelSaveWorkbookAsCSVsaveFilename);
            if (mSExcelSaveWorkbookAsCSVdeleteExistingSaveFilename != null)
            {
                mSExcelSaveWorkbookAsCSV["DeleteExistingSaveFilename"] = ExpressionConverter.ConvertO(mSExcelSaveWorkbookAsCSVdeleteExistingSaveFilename);
                mSExcelSaveWorkbookAsCSVpropCount++;
            }

            mSExcelSaveWorkbookAsCSVpropCount++;
            mSExcelSaveWorkbookAsCSV["Workflow"] = ExpressionConverter.ConvertO(mSExcelSaveWorkbookAsCSVworkflow);
            if (mSExcelSaveWorkbookAsCSVpropCount > 0)
            {
                callPayload.Body = mSExcelSaveWorkbookAsCSV;
            }

            return new ApiConnectionAction<MSExcelSaveWorkbookAsCSVResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelSaveWorkbookAsWithPasswordResponse> MSExcelSaveWorkbookAsWithPassword(Expression<Func<string>> mSExcelSaveWorkbookAsWithPasswordsaveFilename, Expression<Func<string>> mSExcelSaveWorkbookAsWithPasswordpassword, Expression<Func<string>> mSExcelSaveWorkbookAsWithPasswordworkflow, Expression<Func<int>> mSExcelSaveWorkbookAsWithPasswordhandle = null, Expression<Func<string>> mSExcelSaveWorkbookAsWithPasswordworkbookName = null, Expression<Func<bool>> mSExcelSaveWorkbookAsWithPassworddeleteExistingSaveFilename = null, Expression<Func<mSExcelSaveWorkbookAsWithPasswordexcelFileFormatInput>> mSExcelSaveWorkbookAsWithPasswordexcelFileFormat = null)
        {
            var apiCallPath = "/MSExcel/SaveWorkbookAsWithPassword";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelSaveWorkbookAsWithPassword = new JObject();
            var mSExcelSaveWorkbookAsWithPasswordpropCount = 0;
            if (mSExcelSaveWorkbookAsWithPasswordhandle != null)
            {
                mSExcelSaveWorkbookAsWithPassword["Handle"] = ExpressionConverter.ConvertO(mSExcelSaveWorkbookAsWithPasswordhandle);
                mSExcelSaveWorkbookAsWithPasswordpropCount++;
            }

            if (mSExcelSaveWorkbookAsWithPasswordworkbookName != null)
            {
                mSExcelSaveWorkbookAsWithPassword["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelSaveWorkbookAsWithPasswordworkbookName);
                mSExcelSaveWorkbookAsWithPasswordpropCount++;
            }

            mSExcelSaveWorkbookAsWithPasswordpropCount++;
            mSExcelSaveWorkbookAsWithPassword["SaveFilename"] = ExpressionConverter.ConvertO(mSExcelSaveWorkbookAsWithPasswordsaveFilename);
            mSExcelSaveWorkbookAsWithPasswordpropCount++;
            mSExcelSaveWorkbookAsWithPassword["Password"] = ExpressionConverter.ConvertO(mSExcelSaveWorkbookAsWithPasswordpassword);
            if (mSExcelSaveWorkbookAsWithPassworddeleteExistingSaveFilename != null)
            {
                mSExcelSaveWorkbookAsWithPassword["DeleteExistingSaveFilename"] = ExpressionConverter.ConvertO(mSExcelSaveWorkbookAsWithPassworddeleteExistingSaveFilename);
                mSExcelSaveWorkbookAsWithPasswordpropCount++;
            }

            if (mSExcelSaveWorkbookAsWithPasswordexcelFileFormat != null)
            {
                mSExcelSaveWorkbookAsWithPassword["ExcelFileFormat"] = ExpressionConverter.ConvertO(mSExcelSaveWorkbookAsWithPasswordexcelFileFormat);
                mSExcelSaveWorkbookAsWithPasswordpropCount++;
            }

            mSExcelSaveWorkbookAsWithPasswordpropCount++;
            mSExcelSaveWorkbookAsWithPassword["Workflow"] = ExpressionConverter.ConvertO(mSExcelSaveWorkbookAsWithPasswordworkflow);
            if (mSExcelSaveWorkbookAsWithPasswordpropCount > 0)
            {
                callPayload.Body = mSExcelSaveWorkbookAsWithPassword;
            }

            return new ApiConnectionAction<MSExcelSaveWorkbookAsWithPasswordResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelSaveCurrentWorkbookResponse> MSExcelSaveCurrentWorkbook(Expression<Func<string>> mSExcelSaveCurrentWorkbookworkflow, Expression<Func<int>> mSExcelSaveCurrentWorkbookhandle = null)
        {
            var apiCallPath = "/MSExcel/SaveCurrentWorkbook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelSaveCurrentWorkbook = new JObject();
            var mSExcelSaveCurrentWorkbookpropCount = 0;
            if (mSExcelSaveCurrentWorkbookhandle != null)
            {
                mSExcelSaveCurrentWorkbook["Handle"] = ExpressionConverter.ConvertO(mSExcelSaveCurrentWorkbookhandle);
                mSExcelSaveCurrentWorkbookpropCount++;
            }

            mSExcelSaveCurrentWorkbookpropCount++;
            mSExcelSaveCurrentWorkbook["Workflow"] = ExpressionConverter.ConvertO(mSExcelSaveCurrentWorkbookworkflow);
            if (mSExcelSaveCurrentWorkbookpropCount > 0)
            {
                callPayload.Body = mSExcelSaveCurrentWorkbook;
            }

            return new ApiConnectionAction<MSExcelSaveCurrentWorkbookResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelSaveCurrentWorkbookAsResponse> MSExcelSaveCurrentWorkbookAs(Expression<Func<string>> mSExcelSaveCurrentWorkbookAsworkflow, Expression<Func<int>> mSExcelSaveCurrentWorkbookAshandle = null, Expression<Func<string>> mSExcelSaveCurrentWorkbookAssaveFilename = null, Expression<Func<bool>> mSExcelSaveCurrentWorkbookAsdeleteExistingSaveFilename = null, Expression<Func<mSExcelSaveCurrentWorkbookAsexcelFileFormatInput>> mSExcelSaveCurrentWorkbookAsexcelFileFormat = null)
        {
            var apiCallPath = "/MSExcel/SaveCurrentWorkbookAs";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelSaveCurrentWorkbookAs = new JObject();
            var mSExcelSaveCurrentWorkbookAspropCount = 0;
            if (mSExcelSaveCurrentWorkbookAshandle != null)
            {
                mSExcelSaveCurrentWorkbookAs["Handle"] = ExpressionConverter.ConvertO(mSExcelSaveCurrentWorkbookAshandle);
                mSExcelSaveCurrentWorkbookAspropCount++;
            }

            if (mSExcelSaveCurrentWorkbookAssaveFilename != null)
            {
                mSExcelSaveCurrentWorkbookAs["SaveFilename"] = ExpressionConverter.ConvertO(mSExcelSaveCurrentWorkbookAssaveFilename);
                mSExcelSaveCurrentWorkbookAspropCount++;
            }

            if (mSExcelSaveCurrentWorkbookAsdeleteExistingSaveFilename != null)
            {
                mSExcelSaveCurrentWorkbookAs["DeleteExistingSaveFilename"] = ExpressionConverter.ConvertO(mSExcelSaveCurrentWorkbookAsdeleteExistingSaveFilename);
                mSExcelSaveCurrentWorkbookAspropCount++;
            }

            if (mSExcelSaveCurrentWorkbookAsexcelFileFormat != null)
            {
                mSExcelSaveCurrentWorkbookAs["ExcelFileFormat"] = ExpressionConverter.ConvertO(mSExcelSaveCurrentWorkbookAsexcelFileFormat);
                mSExcelSaveCurrentWorkbookAspropCount++;
            }

            mSExcelSaveCurrentWorkbookAspropCount++;
            mSExcelSaveCurrentWorkbookAs["Workflow"] = ExpressionConverter.ConvertO(mSExcelSaveCurrentWorkbookAsworkflow);
            if (mSExcelSaveCurrentWorkbookAspropCount > 0)
            {
                callPayload.Body = mSExcelSaveCurrentWorkbookAs;
            }

            return new ApiConnectionAction<MSExcelSaveCurrentWorkbookAsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelSaveCurrentWorkbookAsCSVResponse> MSExcelSaveCurrentWorkbookAsCSV(Expression<Func<string>> mSExcelSaveCurrentWorkbookAsCSVsaveFilename, Expression<Func<string>> mSExcelSaveCurrentWorkbookAsCSVworkflow, Expression<Func<int>> mSExcelSaveCurrentWorkbookAsCSVhandle = null, Expression<Func<bool>> mSExcelSaveCurrentWorkbookAsCSVdeleteExistingSaveFilename = null)
        {
            var apiCallPath = "/MSExcel/SaveCurrentWorkbookAsCSV";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelSaveCurrentWorkbookAsCSV = new JObject();
            var mSExcelSaveCurrentWorkbookAsCSVpropCount = 0;
            if (mSExcelSaveCurrentWorkbookAsCSVhandle != null)
            {
                mSExcelSaveCurrentWorkbookAsCSV["Handle"] = ExpressionConverter.ConvertO(mSExcelSaveCurrentWorkbookAsCSVhandle);
                mSExcelSaveCurrentWorkbookAsCSVpropCount++;
            }

            mSExcelSaveCurrentWorkbookAsCSVpropCount++;
            mSExcelSaveCurrentWorkbookAsCSV["SaveFilename"] = ExpressionConverter.ConvertO(mSExcelSaveCurrentWorkbookAsCSVsaveFilename);
            if (mSExcelSaveCurrentWorkbookAsCSVdeleteExistingSaveFilename != null)
            {
                mSExcelSaveCurrentWorkbookAsCSV["DeleteExistingSaveFilename"] = ExpressionConverter.ConvertO(mSExcelSaveCurrentWorkbookAsCSVdeleteExistingSaveFilename);
                mSExcelSaveCurrentWorkbookAsCSVpropCount++;
            }

            mSExcelSaveCurrentWorkbookAsCSVpropCount++;
            mSExcelSaveCurrentWorkbookAsCSV["Workflow"] = ExpressionConverter.ConvertO(mSExcelSaveCurrentWorkbookAsCSVworkflow);
            if (mSExcelSaveCurrentWorkbookAsCSVpropCount > 0)
            {
                callPayload.Body = mSExcelSaveCurrentWorkbookAsCSV;
            }

            return new ApiConnectionAction<MSExcelSaveCurrentWorkbookAsCSVResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetWorksheetNamesResponse> MSExcelGetWorksheetNames(Expression<Func<string>> mSExcelGetWorksheetNamesworkflow, Expression<Func<int>> mSExcelGetWorksheetNameshandle = null, Expression<Func<string>> mSExcelGetWorksheetNamesworkbookName = null)
        {
            var apiCallPath = "/MSExcel/GetWorksheetNames";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelGetWorksheetNames = new JObject();
            var mSExcelGetWorksheetNamespropCount = 0;
            if (mSExcelGetWorksheetNameshandle != null)
            {
                mSExcelGetWorksheetNames["Handle"] = ExpressionConverter.ConvertO(mSExcelGetWorksheetNameshandle);
                mSExcelGetWorksheetNamespropCount++;
            }

            if (mSExcelGetWorksheetNamesworkbookName != null)
            {
                mSExcelGetWorksheetNames["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelGetWorksheetNamesworkbookName);
                mSExcelGetWorksheetNamespropCount++;
            }

            mSExcelGetWorksheetNamespropCount++;
            mSExcelGetWorksheetNames["Workflow"] = ExpressionConverter.ConvertO(mSExcelGetWorksheetNamesworkflow);
            if (mSExcelGetWorksheetNamespropCount > 0)
            {
                callPayload.Body = mSExcelGetWorksheetNames;
            }

            return new ApiConnectionAction<MSExcelGetWorksheetNamesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetWorksheetNameResponse> MSExcelGetWorksheetName(Expression<Func<string>> mSExcelGetWorksheetNameworkflow, Expression<Func<int>> mSExcelGetWorksheetNamehandle = null, Expression<Func<string>> mSExcelGetWorksheetNameworkbookName = null, Expression<Func<int>> mSExcelGetWorksheetNameposition = null)
        {
            var apiCallPath = "/MSExcel/GetWorksheetName";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelGetWorksheetName = new JObject();
            var mSExcelGetWorksheetNamepropCount = 0;
            if (mSExcelGetWorksheetNamehandle != null)
            {
                mSExcelGetWorksheetName["Handle"] = ExpressionConverter.ConvertO(mSExcelGetWorksheetNamehandle);
                mSExcelGetWorksheetNamepropCount++;
            }

            if (mSExcelGetWorksheetNameworkbookName != null)
            {
                mSExcelGetWorksheetName["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelGetWorksheetNameworkbookName);
                mSExcelGetWorksheetNamepropCount++;
            }

            if (mSExcelGetWorksheetNameposition != null)
            {
                mSExcelGetWorksheetName["Position"] = ExpressionConverter.ConvertO(mSExcelGetWorksheetNameposition);
                mSExcelGetWorksheetNamepropCount++;
            }

            mSExcelGetWorksheetNamepropCount++;
            mSExcelGetWorksheetName["Workflow"] = ExpressionConverter.ConvertO(mSExcelGetWorksheetNameworkflow);
            if (mSExcelGetWorksheetNamepropCount > 0)
            {
                callPayload.Body = mSExcelGetWorksheetName;
            }

            return new ApiConnectionAction<MSExcelGetWorksheetNameResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelActivateWorksheet(Expression<Func<string>> mSExcelActivateWorksheetworkflow, Expression<Func<int>> mSExcelActivateWorksheethandle = null, Expression<Func<string>> mSExcelActivateWorksheetworkbookName = null, Expression<Func<string>> mSExcelActivateWorksheetworksheetName = null, Expression<Func<bool>> mSExcelActivateWorksheetcreateIfMissing = null)
        {
            var apiCallPath = "/MSExcel/ActivateWorksheet";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelActivateWorksheet = new JObject();
            var mSExcelActivateWorksheetpropCount = 0;
            if (mSExcelActivateWorksheethandle != null)
            {
                mSExcelActivateWorksheet["Handle"] = ExpressionConverter.ConvertO(mSExcelActivateWorksheethandle);
                mSExcelActivateWorksheetpropCount++;
            }

            if (mSExcelActivateWorksheetworkbookName != null)
            {
                mSExcelActivateWorksheet["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelActivateWorksheetworkbookName);
                mSExcelActivateWorksheetpropCount++;
            }

            if (mSExcelActivateWorksheetworksheetName != null)
            {
                mSExcelActivateWorksheet["WorksheetName"] = ExpressionConverter.ConvertO(mSExcelActivateWorksheetworksheetName);
                mSExcelActivateWorksheetpropCount++;
            }

            if (mSExcelActivateWorksheetcreateIfMissing != null)
            {
                mSExcelActivateWorksheet["CreateIfMissing"] = ExpressionConverter.ConvertO(mSExcelActivateWorksheetcreateIfMissing);
                mSExcelActivateWorksheetpropCount++;
            }

            mSExcelActivateWorksheetpropCount++;
            mSExcelActivateWorksheet["Workflow"] = ExpressionConverter.ConvertO(mSExcelActivateWorksheetworkflow);
            if (mSExcelActivateWorksheetpropCount > 0)
            {
                callPayload.Body = mSExcelActivateWorksheet;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelCreateWorksheet(Expression<Func<string>> mSExcelCreateWorksheetworkflow, Expression<Func<int>> mSExcelCreateWorksheethandle = null, Expression<Func<string>> mSExcelCreateWorksheetworkbookName = null, Expression<Func<string>> mSExcelCreateWorksheetworksheetName = null)
        {
            var apiCallPath = "/MSExcel/CreateWorksheet";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelCreateWorksheet = new JObject();
            var mSExcelCreateWorksheetpropCount = 0;
            if (mSExcelCreateWorksheethandle != null)
            {
                mSExcelCreateWorksheet["Handle"] = ExpressionConverter.ConvertO(mSExcelCreateWorksheethandle);
                mSExcelCreateWorksheetpropCount++;
            }

            if (mSExcelCreateWorksheetworkbookName != null)
            {
                mSExcelCreateWorksheet["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelCreateWorksheetworkbookName);
                mSExcelCreateWorksheetpropCount++;
            }

            if (mSExcelCreateWorksheetworksheetName != null)
            {
                mSExcelCreateWorksheet["WorksheetName"] = ExpressionConverter.ConvertO(mSExcelCreateWorksheetworksheetName);
                mSExcelCreateWorksheetpropCount++;
            }

            mSExcelCreateWorksheetpropCount++;
            mSExcelCreateWorksheet["Workflow"] = ExpressionConverter.ConvertO(mSExcelCreateWorksheetworkflow);
            if (mSExcelCreateWorksheetpropCount > 0)
            {
                callPayload.Body = mSExcelCreateWorksheet;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelDeleteWorksheet(Expression<Func<string>> mSExcelDeleteWorksheetworkflow, Expression<Func<int>> mSExcelDeleteWorksheethandle = null, Expression<Func<string>> mSExcelDeleteWorksheetworkbookName = null, Expression<Func<string>> mSExcelDeleteWorksheetworksheetName = null)
        {
            var apiCallPath = "/MSExcel/DeleteWorksheet";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelDeleteWorksheet = new JObject();
            var mSExcelDeleteWorksheetpropCount = 0;
            if (mSExcelDeleteWorksheethandle != null)
            {
                mSExcelDeleteWorksheet["Handle"] = ExpressionConverter.ConvertO(mSExcelDeleteWorksheethandle);
                mSExcelDeleteWorksheetpropCount++;
            }

            if (mSExcelDeleteWorksheetworkbookName != null)
            {
                mSExcelDeleteWorksheet["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelDeleteWorksheetworkbookName);
                mSExcelDeleteWorksheetpropCount++;
            }

            if (mSExcelDeleteWorksheetworksheetName != null)
            {
                mSExcelDeleteWorksheet["WorksheetName"] = ExpressionConverter.ConvertO(mSExcelDeleteWorksheetworksheetName);
                mSExcelDeleteWorksheetpropCount++;
            }

            mSExcelDeleteWorksheetpropCount++;
            mSExcelDeleteWorksheet["Workflow"] = ExpressionConverter.ConvertO(mSExcelDeleteWorksheetworkflow);
            if (mSExcelDeleteWorksheetpropCount > 0)
            {
                callPayload.Body = mSExcelDeleteWorksheet;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetWorksheetAsCollectionEnhancedResponse> MSExcelGetWorksheetAsCollectionEnhanced(Expression<Func<string>> mSExcelGetWorksheetAsCollectionEnhancedworkflow, Expression<Func<int>> mSExcelGetWorksheetAsCollectionEnhancedhandle = null, Expression<Func<string>> mSExcelGetWorksheetAsCollectionEnhancedworkbookName = null, Expression<Func<string>> mSExcelGetWorksheetAsCollectionEnhancedworksheetName = null, Expression<Func<bool>> mSExcelGetWorksheetAsCollectionEnhanceduseHeader = null, Expression<Func<string>> mSExcelGetWorksheetAsCollectionEnhancedstartCell = null, Expression<Func<int>> mSExcelGetWorksheetAsCollectionEnhancedmaximumColumnNumber = null, Expression<Func<bool>> mSExcelGetWorksheetAsCollectionEnhancedskipBlankRows = null, Expression<Func<bool>> mSExcelGetWorksheetAsCollectionEnhancedskipColumnsWithNoHeader = null, Expression<Func<string>> mSExcelGetWorksheetAsCollectionEnhancedkeyColumn = null, Expression<Func<bool>> mSExcelGetWorksheetAsCollectionEnhancedgetRawData = null, Expression<Func<int>> mSExcelGetWorksheetAsCollectionEnhancedignoreRowsWithLowCellCount = null, Expression<Func<int>> mSExcelGetWorksheetAsCollectionEnhancedmaxConcurrentBlankRows = null, Expression<Func<int>> mSExcelGetWorksheetAsCollectionEnhancedfirstDataRowToReturn = null, Expression<Func<int>> mSExcelGetWorksheetAsCollectionEnhancedmaxNumberOfDataRowsToReturn = null)
        {
            var apiCallPath = "/MSExcel/GetWorksheetAsCollectionEnhanced";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelGetWorksheetAsCollectionEnhanced = new JObject();
            var mSExcelGetWorksheetAsCollectionEnhancedpropCount = 0;
            if (mSExcelGetWorksheetAsCollectionEnhancedhandle != null)
            {
                mSExcelGetWorksheetAsCollectionEnhanced["Handle"] = ExpressionConverter.ConvertO(mSExcelGetWorksheetAsCollectionEnhancedhandle);
                mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
            }

            if (mSExcelGetWorksheetAsCollectionEnhancedworkbookName != null)
            {
                mSExcelGetWorksheetAsCollectionEnhanced["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelGetWorksheetAsCollectionEnhancedworkbookName);
                mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
            }

            if (mSExcelGetWorksheetAsCollectionEnhancedworksheetName != null)
            {
                mSExcelGetWorksheetAsCollectionEnhanced["WorksheetName"] = ExpressionConverter.ConvertO(mSExcelGetWorksheetAsCollectionEnhancedworksheetName);
                mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
            }

            if (mSExcelGetWorksheetAsCollectionEnhanceduseHeader != null)
            {
                mSExcelGetWorksheetAsCollectionEnhanced["UseHeader"] = ExpressionConverter.ConvertO(mSExcelGetWorksheetAsCollectionEnhanceduseHeader);
                mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
            }

            if (mSExcelGetWorksheetAsCollectionEnhancedstartCell != null)
            {
                mSExcelGetWorksheetAsCollectionEnhanced["StartCell"] = ExpressionConverter.ConvertO(mSExcelGetWorksheetAsCollectionEnhancedstartCell);
                mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
            }

            if (mSExcelGetWorksheetAsCollectionEnhancedmaximumColumnNumber != null)
            {
                mSExcelGetWorksheetAsCollectionEnhanced["MaximumColumnNumber"] = ExpressionConverter.ConvertO(mSExcelGetWorksheetAsCollectionEnhancedmaximumColumnNumber);
                mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
            }

            if (mSExcelGetWorksheetAsCollectionEnhancedskipBlankRows != null)
            {
                mSExcelGetWorksheetAsCollectionEnhanced["SkipBlankRows"] = ExpressionConverter.ConvertO(mSExcelGetWorksheetAsCollectionEnhancedskipBlankRows);
                mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
            }

            if (mSExcelGetWorksheetAsCollectionEnhancedskipColumnsWithNoHeader != null)
            {
                mSExcelGetWorksheetAsCollectionEnhanced["SkipColumnsWithNoHeader"] = ExpressionConverter.ConvertO(mSExcelGetWorksheetAsCollectionEnhancedskipColumnsWithNoHeader);
                mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
            }

            if (mSExcelGetWorksheetAsCollectionEnhancedkeyColumn != null)
            {
                mSExcelGetWorksheetAsCollectionEnhanced["KeyColumn"] = ExpressionConverter.ConvertO(mSExcelGetWorksheetAsCollectionEnhancedkeyColumn);
                mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
            }

            if (mSExcelGetWorksheetAsCollectionEnhancedgetRawData != null)
            {
                mSExcelGetWorksheetAsCollectionEnhanced["GetRawData"] = ExpressionConverter.ConvertO(mSExcelGetWorksheetAsCollectionEnhancedgetRawData);
                mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
            }

            if (mSExcelGetWorksheetAsCollectionEnhancedignoreRowsWithLowCellCount != null)
            {
                mSExcelGetWorksheetAsCollectionEnhanced["IgnoreRowsWithLowCellCount"] = ExpressionConverter.ConvertO(mSExcelGetWorksheetAsCollectionEnhancedignoreRowsWithLowCellCount);
                mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
            }

            if (mSExcelGetWorksheetAsCollectionEnhancedmaxConcurrentBlankRows != null)
            {
                mSExcelGetWorksheetAsCollectionEnhanced["MaxConcurrentBlankRows"] = ExpressionConverter.ConvertO(mSExcelGetWorksheetAsCollectionEnhancedmaxConcurrentBlankRows);
                mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
            }

            if (mSExcelGetWorksheetAsCollectionEnhancedfirstDataRowToReturn != null)
            {
                mSExcelGetWorksheetAsCollectionEnhanced["FirstDataRowToReturn"] = ExpressionConverter.ConvertO(mSExcelGetWorksheetAsCollectionEnhancedfirstDataRowToReturn);
                mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
            }

            if (mSExcelGetWorksheetAsCollectionEnhancedmaxNumberOfDataRowsToReturn != null)
            {
                mSExcelGetWorksheetAsCollectionEnhanced["MaxNumberOfDataRowsToReturn"] = ExpressionConverter.ConvertO(mSExcelGetWorksheetAsCollectionEnhancedmaxNumberOfDataRowsToReturn);
                mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
            }

            mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
            mSExcelGetWorksheetAsCollectionEnhanced["Workflow"] = ExpressionConverter.ConvertO(mSExcelGetWorksheetAsCollectionEnhancedworkflow);
            if (mSExcelGetWorksheetAsCollectionEnhancedpropCount > 0)
            {
                callPayload.Body = mSExcelGetWorksheetAsCollectionEnhanced;
            }

            return new ApiConnectionAction<MSExcelGetWorksheetAsCollectionEnhancedResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetNumberOfRowsResponse> MSExcelGetNumberOfRows(Expression<Func<string>> mSExcelGetNumberOfRowsworkflow, Expression<Func<int>> mSExcelGetNumberOfRowshandle = null, Expression<Func<string>> mSExcelGetNumberOfRowsworkbookName = null, Expression<Func<string>> mSExcelGetNumberOfRowsworksheetName = null)
        {
            var apiCallPath = "/MSExcel/GetNumberOfRows";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelGetNumberOfRows = new JObject();
            var mSExcelGetNumberOfRowspropCount = 0;
            if (mSExcelGetNumberOfRowshandle != null)
            {
                mSExcelGetNumberOfRows["Handle"] = ExpressionConverter.ConvertO(mSExcelGetNumberOfRowshandle);
                mSExcelGetNumberOfRowspropCount++;
            }

            if (mSExcelGetNumberOfRowsworkbookName != null)
            {
                mSExcelGetNumberOfRows["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelGetNumberOfRowsworkbookName);
                mSExcelGetNumberOfRowspropCount++;
            }

            if (mSExcelGetNumberOfRowsworksheetName != null)
            {
                mSExcelGetNumberOfRows["WorksheetName"] = ExpressionConverter.ConvertO(mSExcelGetNumberOfRowsworksheetName);
                mSExcelGetNumberOfRowspropCount++;
            }

            mSExcelGetNumberOfRowspropCount++;
            mSExcelGetNumberOfRows["Workflow"] = ExpressionConverter.ConvertO(mSExcelGetNumberOfRowsworkflow);
            if (mSExcelGetNumberOfRowspropCount > 0)
            {
                callPayload.Body = mSExcelGetNumberOfRows;
            }

            return new ApiConnectionAction<MSExcelGetNumberOfRowsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelEvaluateExpressionResponse> MSExcelEvaluateExpression(Expression<Func<string>> mSExcelEvaluateExpressionexpression, Expression<Func<string>> mSExcelEvaluateExpressionworkflow, Expression<Func<int>> mSExcelEvaluateExpressionhandle = null)
        {
            var apiCallPath = "/MSExcel/EvaluateExpression";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelEvaluateExpression = new JObject();
            var mSExcelEvaluateExpressionpropCount = 0;
            if (mSExcelEvaluateExpressionhandle != null)
            {
                mSExcelEvaluateExpression["Handle"] = ExpressionConverter.ConvertO(mSExcelEvaluateExpressionhandle);
                mSExcelEvaluateExpressionpropCount++;
            }

            mSExcelEvaluateExpressionpropCount++;
            mSExcelEvaluateExpression["Expression"] = ExpressionConverter.ConvertO(mSExcelEvaluateExpressionexpression);
            mSExcelEvaluateExpressionpropCount++;
            mSExcelEvaluateExpression["Workflow"] = ExpressionConverter.ConvertO(mSExcelEvaluateExpressionworkflow);
            if (mSExcelEvaluateExpressionpropCount > 0)
            {
                callPayload.Body = mSExcelEvaluateExpression;
            }

            return new ApiConnectionAction<MSExcelEvaluateExpressionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetWorksheetUsedRangeResponse> MSExcelGetWorksheetUsedRange(Expression<Func<string>> mSExcelGetWorksheetUsedRangeworkflow, Expression<Func<int>> mSExcelGetWorksheetUsedRangehandle = null, Expression<Func<string>> mSExcelGetWorksheetUsedRangeworkbookName = null, Expression<Func<string>> mSExcelGetWorksheetUsedRangeworksheetName = null)
        {
            var apiCallPath = "/MSExcel/GetWorksheetUsedRange";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelGetWorksheetUsedRange = new JObject();
            var mSExcelGetWorksheetUsedRangepropCount = 0;
            if (mSExcelGetWorksheetUsedRangehandle != null)
            {
                mSExcelGetWorksheetUsedRange["Handle"] = ExpressionConverter.ConvertO(mSExcelGetWorksheetUsedRangehandle);
                mSExcelGetWorksheetUsedRangepropCount++;
            }

            if (mSExcelGetWorksheetUsedRangeworkbookName != null)
            {
                mSExcelGetWorksheetUsedRange["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelGetWorksheetUsedRangeworkbookName);
                mSExcelGetWorksheetUsedRangepropCount++;
            }

            if (mSExcelGetWorksheetUsedRangeworksheetName != null)
            {
                mSExcelGetWorksheetUsedRange["WorksheetName"] = ExpressionConverter.ConvertO(mSExcelGetWorksheetUsedRangeworksheetName);
                mSExcelGetWorksheetUsedRangepropCount++;
            }

            mSExcelGetWorksheetUsedRangepropCount++;
            mSExcelGetWorksheetUsedRange["Workflow"] = ExpressionConverter.ConvertO(mSExcelGetWorksheetUsedRangeworkflow);
            if (mSExcelGetWorksheetUsedRangepropCount > 0)
            {
                callPayload.Body = mSExcelGetWorksheetUsedRange;
            }

            return new ApiConnectionAction<MSExcelGetWorksheetUsedRangeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetCountrySettingResponse> MSExcelGetCountrySetting(Expression<Func<string>> mSExcelGetCountrySettingworkflow, Expression<Func<int>> mSExcelGetCountrySettinghandle = null)
        {
            var apiCallPath = "/MSExcel/GetCountrySetting";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelGetCountrySetting = new JObject();
            var mSExcelGetCountrySettingpropCount = 0;
            if (mSExcelGetCountrySettinghandle != null)
            {
                mSExcelGetCountrySetting["Handle"] = ExpressionConverter.ConvertO(mSExcelGetCountrySettinghandle);
                mSExcelGetCountrySettingpropCount++;
            }

            mSExcelGetCountrySettingpropCount++;
            mSExcelGetCountrySetting["Workflow"] = ExpressionConverter.ConvertO(mSExcelGetCountrySettingworkflow);
            if (mSExcelGetCountrySettingpropCount > 0)
            {
                callPayload.Body = mSExcelGetCountrySetting;
            }

            return new ApiConnectionAction<MSExcelGetCountrySettingResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelWriteCollection(Expression<Func<string>> mSExcelWriteCollectioncellReference, Expression<Func<string>> mSExcelWriteCollectioncollectionToWriteJSON, Expression<Func<string>> mSExcelWriteCollectionworkflow, Expression<Func<int>> mSExcelWriteCollectionhandle = null, Expression<Func<string>> mSExcelWriteCollectionworkbookName = null, Expression<Func<string>> mSExcelWriteCollectionworksheetName = null, Expression<Func<bool>> mSExcelWriteCollectionincludeColumnNames = null)
        {
            var apiCallPath = "/MSExcel/WriteCollection";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelWriteCollection = new JObject();
            var mSExcelWriteCollectionpropCount = 0;
            if (mSExcelWriteCollectionhandle != null)
            {
                mSExcelWriteCollection["Handle"] = ExpressionConverter.ConvertO(mSExcelWriteCollectionhandle);
                mSExcelWriteCollectionpropCount++;
            }

            if (mSExcelWriteCollectionworkbookName != null)
            {
                mSExcelWriteCollection["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelWriteCollectionworkbookName);
                mSExcelWriteCollectionpropCount++;
            }

            if (mSExcelWriteCollectionworksheetName != null)
            {
                mSExcelWriteCollection["WorksheetName"] = ExpressionConverter.ConvertO(mSExcelWriteCollectionworksheetName);
                mSExcelWriteCollectionpropCount++;
            }

            mSExcelWriteCollectionpropCount++;
            mSExcelWriteCollection["CellReference"] = ExpressionConverter.ConvertO(mSExcelWriteCollectioncellReference);
            mSExcelWriteCollectionpropCount++;
            mSExcelWriteCollection["CollectionToWriteJSON"] = ExpressionConverter.ConvertO(mSExcelWriteCollectioncollectionToWriteJSON);
            if (mSExcelWriteCollectionincludeColumnNames != null)
            {
                mSExcelWriteCollection["IncludeColumnNames"] = ExpressionConverter.ConvertO(mSExcelWriteCollectionincludeColumnNames);
                mSExcelWriteCollectionpropCount++;
            }

            mSExcelWriteCollectionpropCount++;
            mSExcelWriteCollection["Workflow"] = ExpressionConverter.ConvertO(mSExcelWriteCollectionworkflow);
            if (mSExcelWriteCollectionpropCount > 0)
            {
                callPayload.Body = mSExcelWriteCollection;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelWriteCollectionWithDates(Expression<Func<string>> mSExcelWriteCollectionWithDatescellReference, Expression<Func<string>> mSExcelWriteCollectionWithDatescollectionToWriteJSON, Expression<Func<string>> mSExcelWriteCollectionWithDatesworkflow, Expression<Func<int>> mSExcelWriteCollectionWithDateshandle = null, Expression<Func<string>> mSExcelWriteCollectionWithDatesworkbookName = null, Expression<Func<string>> mSExcelWriteCollectionWithDatesworksheetName = null, Expression<Func<bool>> mSExcelWriteCollectionWithDatesincludeColumnNames = null, Expression<Func<bool>> mSExcelWriteCollectionWithDatestryToConvertAllFieldsToDate = null, Expression<Func<string>> mSExcelWriteCollectionWithDatescolumnsToConvertToDateJSON = null)
        {
            var apiCallPath = "/MSExcel/WriteCollectionWithDates";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelWriteCollectionWithDates = new JObject();
            var mSExcelWriteCollectionWithDatespropCount = 0;
            if (mSExcelWriteCollectionWithDateshandle != null)
            {
                mSExcelWriteCollectionWithDates["Handle"] = ExpressionConverter.ConvertO(mSExcelWriteCollectionWithDateshandle);
                mSExcelWriteCollectionWithDatespropCount++;
            }

            if (mSExcelWriteCollectionWithDatesworkbookName != null)
            {
                mSExcelWriteCollectionWithDates["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelWriteCollectionWithDatesworkbookName);
                mSExcelWriteCollectionWithDatespropCount++;
            }

            if (mSExcelWriteCollectionWithDatesworksheetName != null)
            {
                mSExcelWriteCollectionWithDates["WorksheetName"] = ExpressionConverter.ConvertO(mSExcelWriteCollectionWithDatesworksheetName);
                mSExcelWriteCollectionWithDatespropCount++;
            }

            mSExcelWriteCollectionWithDatespropCount++;
            mSExcelWriteCollectionWithDates["CellReference"] = ExpressionConverter.ConvertO(mSExcelWriteCollectionWithDatescellReference);
            mSExcelWriteCollectionWithDatespropCount++;
            mSExcelWriteCollectionWithDates["CollectionToWriteJSON"] = ExpressionConverter.ConvertO(mSExcelWriteCollectionWithDatescollectionToWriteJSON);
            if (mSExcelWriteCollectionWithDatesincludeColumnNames != null)
            {
                mSExcelWriteCollectionWithDates["IncludeColumnNames"] = ExpressionConverter.ConvertO(mSExcelWriteCollectionWithDatesincludeColumnNames);
                mSExcelWriteCollectionWithDatespropCount++;
            }

            if (mSExcelWriteCollectionWithDatestryToConvertAllFieldsToDate != null)
            {
                mSExcelWriteCollectionWithDates["TryToConvertAllFieldsToDate"] = ExpressionConverter.ConvertO(mSExcelWriteCollectionWithDatestryToConvertAllFieldsToDate);
                mSExcelWriteCollectionWithDatespropCount++;
            }

            if (mSExcelWriteCollectionWithDatescolumnsToConvertToDateJSON != null)
            {
                mSExcelWriteCollectionWithDates["ColumnsToConvertToDateJSON"] = ExpressionConverter.ConvertO(mSExcelWriteCollectionWithDatescolumnsToConvertToDateJSON);
                mSExcelWriteCollectionWithDatespropCount++;
            }

            mSExcelWriteCollectionWithDatespropCount++;
            mSExcelWriteCollectionWithDates["Workflow"] = ExpressionConverter.ConvertO(mSExcelWriteCollectionWithDatesworkflow);
            if (mSExcelWriteCollectionWithDatespropCount > 0)
            {
                callPayload.Body = mSExcelWriteCollectionWithDates;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetActiveCellResponse> MSExcelGetActiveCell(Expression<Func<string>> mSExcelGetActiveCellworkflow, Expression<Func<int>> mSExcelGetActiveCellhandle = null)
        {
            var apiCallPath = "/MSExcel/GetActiveCell";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelGetActiveCell = new JObject();
            var mSExcelGetActiveCellpropCount = 0;
            if (mSExcelGetActiveCellhandle != null)
            {
                mSExcelGetActiveCell["Handle"] = ExpressionConverter.ConvertO(mSExcelGetActiveCellhandle);
                mSExcelGetActiveCellpropCount++;
            }

            mSExcelGetActiveCellpropCount++;
            mSExcelGetActiveCell["Workflow"] = ExpressionConverter.ConvertO(mSExcelGetActiveCellworkflow);
            if (mSExcelGetActiveCellpropCount > 0)
            {
                callPayload.Body = mSExcelGetActiveCell;
            }

            return new ApiConnectionAction<MSExcelGetActiveCellResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelFormatCell(Expression<Func<string>> mSExcelFormatCellcellReference, Expression<Func<string>> mSExcelFormatCellcellFormat, Expression<Func<string>> mSExcelFormatCellworkflow, Expression<Func<int>> mSExcelFormatCellhandle = null, Expression<Func<string>> mSExcelFormatCellworkbookName = null, Expression<Func<string>> mSExcelFormatCellworksheetName = null)
        {
            var apiCallPath = "/MSExcel/FormatCell";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelFormatCell = new JObject();
            var mSExcelFormatCellpropCount = 0;
            if (mSExcelFormatCellhandle != null)
            {
                mSExcelFormatCell["Handle"] = ExpressionConverter.ConvertO(mSExcelFormatCellhandle);
                mSExcelFormatCellpropCount++;
            }

            if (mSExcelFormatCellworkbookName != null)
            {
                mSExcelFormatCell["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelFormatCellworkbookName);
                mSExcelFormatCellpropCount++;
            }

            if (mSExcelFormatCellworksheetName != null)
            {
                mSExcelFormatCell["WorksheetName"] = ExpressionConverter.ConvertO(mSExcelFormatCellworksheetName);
                mSExcelFormatCellpropCount++;
            }

            mSExcelFormatCellpropCount++;
            mSExcelFormatCell["CellReference"] = ExpressionConverter.ConvertO(mSExcelFormatCellcellReference);
            mSExcelFormatCellpropCount++;
            mSExcelFormatCell["CellFormat"] = ExpressionConverter.ConvertO(mSExcelFormatCellcellFormat);
            mSExcelFormatCellpropCount++;
            mSExcelFormatCell["Workflow"] = ExpressionConverter.ConvertO(mSExcelFormatCellworkflow);
            if (mSExcelFormatCellpropCount > 0)
            {
                callPayload.Body = mSExcelFormatCell;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelFormatCurrentCell(Expression<Func<string>> mSExcelFormatCurrentCellcellFormat, Expression<Func<string>> mSExcelFormatCurrentCellworkflow, Expression<Func<int>> mSExcelFormatCurrentCellhandle = null)
        {
            var apiCallPath = "/MSExcel/FormatCurrentCell";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelFormatCurrentCell = new JObject();
            var mSExcelFormatCurrentCellpropCount = 0;
            if (mSExcelFormatCurrentCellhandle != null)
            {
                mSExcelFormatCurrentCell["Handle"] = ExpressionConverter.ConvertO(mSExcelFormatCurrentCellhandle);
                mSExcelFormatCurrentCellpropCount++;
            }

            mSExcelFormatCurrentCellpropCount++;
            mSExcelFormatCurrentCell["CellFormat"] = ExpressionConverter.ConvertO(mSExcelFormatCurrentCellcellFormat);
            mSExcelFormatCurrentCellpropCount++;
            mSExcelFormatCurrentCell["Workflow"] = ExpressionConverter.ConvertO(mSExcelFormatCurrentCellworkflow);
            if (mSExcelFormatCurrentCellpropCount > 0)
            {
                callPayload.Body = mSExcelFormatCurrentCell;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelSelectCellRange(Expression<Func<string>> mSExcelSelectCellRangecellReference, Expression<Func<string>> mSExcelSelectCellRangeworkflow, Expression<Func<int>> mSExcelSelectCellRangehandle = null, Expression<Func<string>> mSExcelSelectCellRangeworkbookName = null, Expression<Func<string>> mSExcelSelectCellRangeworksheetName = null, Expression<Func<bool>> mSExcelSelectCellRangeentireRow = null, Expression<Func<bool>> mSExcelSelectCellRangeentireColumn = null)
        {
            var apiCallPath = "/MSExcel/SelectCellRange";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelSelectCellRange = new JObject();
            var mSExcelSelectCellRangepropCount = 0;
            if (mSExcelSelectCellRangehandle != null)
            {
                mSExcelSelectCellRange["Handle"] = ExpressionConverter.ConvertO(mSExcelSelectCellRangehandle);
                mSExcelSelectCellRangepropCount++;
            }

            if (mSExcelSelectCellRangeworkbookName != null)
            {
                mSExcelSelectCellRange["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelSelectCellRangeworkbookName);
                mSExcelSelectCellRangepropCount++;
            }

            if (mSExcelSelectCellRangeworksheetName != null)
            {
                mSExcelSelectCellRange["WorksheetName"] = ExpressionConverter.ConvertO(mSExcelSelectCellRangeworksheetName);
                mSExcelSelectCellRangepropCount++;
            }

            mSExcelSelectCellRangepropCount++;
            mSExcelSelectCellRange["CellReference"] = ExpressionConverter.ConvertO(mSExcelSelectCellRangecellReference);
            if (mSExcelSelectCellRangeentireRow != null)
            {
                mSExcelSelectCellRange["EntireRow"] = ExpressionConverter.ConvertO(mSExcelSelectCellRangeentireRow);
                mSExcelSelectCellRangepropCount++;
            }

            if (mSExcelSelectCellRangeentireColumn != null)
            {
                mSExcelSelectCellRange["EntireColumn"] = ExpressionConverter.ConvertO(mSExcelSelectCellRangeentireColumn);
                mSExcelSelectCellRangepropCount++;
            }

            mSExcelSelectCellRangepropCount++;
            mSExcelSelectCellRange["Workflow"] = ExpressionConverter.ConvertO(mSExcelSelectCellRangeworkflow);
            if (mSExcelSelectCellRangepropCount > 0)
            {
                callPayload.Body = mSExcelSelectCellRange;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelCopySelection(Expression<Func<string>> mSExcelCopySelectionworkflow, Expression<Func<int>> mSExcelCopySelectionhandle = null, Expression<Func<string>> mSExcelCopySelectionworkbookName = null, Expression<Func<string>> mSExcelCopySelectionworksheetName = null, Expression<Func<string>> mSExcelCopySelectioncellReference = null, Expression<Func<bool>> mSExcelCopySelectionentireRow = null, Expression<Func<bool>> mSExcelCopySelectionentireColumn = null)
        {
            var apiCallPath = "/MSExcel/CopySelection";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelCopySelection = new JObject();
            var mSExcelCopySelectionpropCount = 0;
            if (mSExcelCopySelectionhandle != null)
            {
                mSExcelCopySelection["Handle"] = ExpressionConverter.ConvertO(mSExcelCopySelectionhandle);
                mSExcelCopySelectionpropCount++;
            }

            if (mSExcelCopySelectionworkbookName != null)
            {
                mSExcelCopySelection["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelCopySelectionworkbookName);
                mSExcelCopySelectionpropCount++;
            }

            if (mSExcelCopySelectionworksheetName != null)
            {
                mSExcelCopySelection["WorksheetName"] = ExpressionConverter.ConvertO(mSExcelCopySelectionworksheetName);
                mSExcelCopySelectionpropCount++;
            }

            if (mSExcelCopySelectioncellReference != null)
            {
                mSExcelCopySelection["CellReference"] = ExpressionConverter.ConvertO(mSExcelCopySelectioncellReference);
                mSExcelCopySelectionpropCount++;
            }

            if (mSExcelCopySelectionentireRow != null)
            {
                mSExcelCopySelection["EntireRow"] = ExpressionConverter.ConvertO(mSExcelCopySelectionentireRow);
                mSExcelCopySelectionpropCount++;
            }

            if (mSExcelCopySelectionentireColumn != null)
            {
                mSExcelCopySelection["EntireColumn"] = ExpressionConverter.ConvertO(mSExcelCopySelectionentireColumn);
                mSExcelCopySelectionpropCount++;
            }

            mSExcelCopySelectionpropCount++;
            mSExcelCopySelection["Workflow"] = ExpressionConverter.ConvertO(mSExcelCopySelectionworkflow);
            if (mSExcelCopySelectionpropCount > 0)
            {
                callPayload.Body = mSExcelCopySelection;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelCutSelection(Expression<Func<string>> mSExcelCutSelectionworkflow, Expression<Func<int>> mSExcelCutSelectionhandle = null, Expression<Func<string>> mSExcelCutSelectionworkbookName = null, Expression<Func<string>> mSExcelCutSelectionworksheetName = null, Expression<Func<string>> mSExcelCutSelectioncellReference = null, Expression<Func<bool>> mSExcelCutSelectionentireRow = null, Expression<Func<bool>> mSExcelCutSelectionentireColumn = null)
        {
            var apiCallPath = "/MSExcel/CutSelection";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelCutSelection = new JObject();
            var mSExcelCutSelectionpropCount = 0;
            if (mSExcelCutSelectionhandle != null)
            {
                mSExcelCutSelection["Handle"] = ExpressionConverter.ConvertO(mSExcelCutSelectionhandle);
                mSExcelCutSelectionpropCount++;
            }

            if (mSExcelCutSelectionworkbookName != null)
            {
                mSExcelCutSelection["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelCutSelectionworkbookName);
                mSExcelCutSelectionpropCount++;
            }

            if (mSExcelCutSelectionworksheetName != null)
            {
                mSExcelCutSelection["WorksheetName"] = ExpressionConverter.ConvertO(mSExcelCutSelectionworksheetName);
                mSExcelCutSelectionpropCount++;
            }

            if (mSExcelCutSelectioncellReference != null)
            {
                mSExcelCutSelection["CellReference"] = ExpressionConverter.ConvertO(mSExcelCutSelectioncellReference);
                mSExcelCutSelectionpropCount++;
            }

            if (mSExcelCutSelectionentireRow != null)
            {
                mSExcelCutSelection["EntireRow"] = ExpressionConverter.ConvertO(mSExcelCutSelectionentireRow);
                mSExcelCutSelectionpropCount++;
            }

            if (mSExcelCutSelectionentireColumn != null)
            {
                mSExcelCutSelection["EntireColumn"] = ExpressionConverter.ConvertO(mSExcelCutSelectionentireColumn);
                mSExcelCutSelectionpropCount++;
            }

            mSExcelCutSelectionpropCount++;
            mSExcelCutSelection["Workflow"] = ExpressionConverter.ConvertO(mSExcelCutSelectionworkflow);
            if (mSExcelCutSelectionpropCount > 0)
            {
                callPayload.Body = mSExcelCutSelection;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelPasteIntoSelection(Expression<Func<string>> mSExcelPasteIntoSelectionworkflow, Expression<Func<int>> mSExcelPasteIntoSelectionhandle = null, Expression<Func<string>> mSExcelPasteIntoSelectionworkbookName = null, Expression<Func<string>> mSExcelPasteIntoSelectionworksheetName = null, Expression<Func<bool>> mSExcelPasteIntoSelectionvaluesOnly = null, Expression<Func<bool>> mSExcelPasteIntoSelectionsimplePasteOnly = null, Expression<Func<string>> mSExcelPasteIntoSelectioncellReference = null, Expression<Func<bool>> mSExcelPasteIntoSelectionentireRow = null, Expression<Func<bool>> mSExcelPasteIntoSelectionentireColumn = null)
        {
            var apiCallPath = "/MSExcel/PasteIntoSelection";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelPasteIntoSelection = new JObject();
            var mSExcelPasteIntoSelectionpropCount = 0;
            if (mSExcelPasteIntoSelectionhandle != null)
            {
                mSExcelPasteIntoSelection["Handle"] = ExpressionConverter.ConvertO(mSExcelPasteIntoSelectionhandle);
                mSExcelPasteIntoSelectionpropCount++;
            }

            if (mSExcelPasteIntoSelectionworkbookName != null)
            {
                mSExcelPasteIntoSelection["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelPasteIntoSelectionworkbookName);
                mSExcelPasteIntoSelectionpropCount++;
            }

            if (mSExcelPasteIntoSelectionworksheetName != null)
            {
                mSExcelPasteIntoSelection["WorksheetName"] = ExpressionConverter.ConvertO(mSExcelPasteIntoSelectionworksheetName);
                mSExcelPasteIntoSelectionpropCount++;
            }

            if (mSExcelPasteIntoSelectionvaluesOnly != null)
            {
                mSExcelPasteIntoSelection["ValuesOnly"] = ExpressionConverter.ConvertO(mSExcelPasteIntoSelectionvaluesOnly);
                mSExcelPasteIntoSelectionpropCount++;
            }

            if (mSExcelPasteIntoSelectionsimplePasteOnly != null)
            {
                mSExcelPasteIntoSelection["SimplePasteOnly"] = ExpressionConverter.ConvertO(mSExcelPasteIntoSelectionsimplePasteOnly);
                mSExcelPasteIntoSelectionpropCount++;
            }

            if (mSExcelPasteIntoSelectioncellReference != null)
            {
                mSExcelPasteIntoSelection["CellReference"] = ExpressionConverter.ConvertO(mSExcelPasteIntoSelectioncellReference);
                mSExcelPasteIntoSelectionpropCount++;
            }

            if (mSExcelPasteIntoSelectionentireRow != null)
            {
                mSExcelPasteIntoSelection["EntireRow"] = ExpressionConverter.ConvertO(mSExcelPasteIntoSelectionentireRow);
                mSExcelPasteIntoSelectionpropCount++;
            }

            if (mSExcelPasteIntoSelectionentireColumn != null)
            {
                mSExcelPasteIntoSelection["EntireColumn"] = ExpressionConverter.ConvertO(mSExcelPasteIntoSelectionentireColumn);
                mSExcelPasteIntoSelectionpropCount++;
            }

            mSExcelPasteIntoSelectionpropCount++;
            mSExcelPasteIntoSelection["Workflow"] = ExpressionConverter.ConvertO(mSExcelPasteIntoSelectionworkflow);
            if (mSExcelPasteIntoSelectionpropCount > 0)
            {
                callPayload.Body = mSExcelPasteIntoSelection;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelInsertOnSelection(Expression<Func<string>> mSExcelInsertOnSelectionworkflow, Expression<Func<int>> mSExcelInsertOnSelectionhandle = null, Expression<Func<string>> mSExcelInsertOnSelectionworkbookName = null, Expression<Func<string>> mSExcelInsertOnSelectionworksheetName = null, Expression<Func<string>> mSExcelInsertOnSelectioncellReference = null, Expression<Func<bool>> mSExcelInsertOnSelectionentireRow = null, Expression<Func<bool>> mSExcelInsertOnSelectionentireColumn = null, Expression<Func<mSExcelInsertOnSelectionshiftInput>> mSExcelInsertOnSelectionshift = null)
        {
            var apiCallPath = "/MSExcel/InsertOnSelection";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelInsertOnSelection = new JObject();
            var mSExcelInsertOnSelectionpropCount = 0;
            if (mSExcelInsertOnSelectionhandle != null)
            {
                mSExcelInsertOnSelection["Handle"] = ExpressionConverter.ConvertO(mSExcelInsertOnSelectionhandle);
                mSExcelInsertOnSelectionpropCount++;
            }

            if (mSExcelInsertOnSelectionworkbookName != null)
            {
                mSExcelInsertOnSelection["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelInsertOnSelectionworkbookName);
                mSExcelInsertOnSelectionpropCount++;
            }

            if (mSExcelInsertOnSelectionworksheetName != null)
            {
                mSExcelInsertOnSelection["WorksheetName"] = ExpressionConverter.ConvertO(mSExcelInsertOnSelectionworksheetName);
                mSExcelInsertOnSelectionpropCount++;
            }

            if (mSExcelInsertOnSelectioncellReference != null)
            {
                mSExcelInsertOnSelection["CellReference"] = ExpressionConverter.ConvertO(mSExcelInsertOnSelectioncellReference);
                mSExcelInsertOnSelectionpropCount++;
            }

            if (mSExcelInsertOnSelectionentireRow != null)
            {
                mSExcelInsertOnSelection["EntireRow"] = ExpressionConverter.ConvertO(mSExcelInsertOnSelectionentireRow);
                mSExcelInsertOnSelectionpropCount++;
            }

            if (mSExcelInsertOnSelectionentireColumn != null)
            {
                mSExcelInsertOnSelection["EntireColumn"] = ExpressionConverter.ConvertO(mSExcelInsertOnSelectionentireColumn);
                mSExcelInsertOnSelectionpropCount++;
            }

            if (mSExcelInsertOnSelectionshift != null)
            {
                mSExcelInsertOnSelection["Shift"] = ExpressionConverter.ConvertO(mSExcelInsertOnSelectionshift);
                mSExcelInsertOnSelectionpropCount++;
            }

            mSExcelInsertOnSelectionpropCount++;
            mSExcelInsertOnSelection["Workflow"] = ExpressionConverter.ConvertO(mSExcelInsertOnSelectionworkflow);
            if (mSExcelInsertOnSelectionpropCount > 0)
            {
                callPayload.Body = mSExcelInsertOnSelection;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelDeleteSelection(Expression<Func<string>> mSExcelDeleteSelectionworkflow, Expression<Func<int>> mSExcelDeleteSelectionhandle = null, Expression<Func<string>> mSExcelDeleteSelectionworkbookName = null, Expression<Func<string>> mSExcelDeleteSelectionworksheetName = null, Expression<Func<string>> mSExcelDeleteSelectioncellReference = null, Expression<Func<bool>> mSExcelDeleteSelectionentireRow = null, Expression<Func<bool>> mSExcelDeleteSelectionentireColumn = null, Expression<Func<mSExcelDeleteSelectionshiftInput>> mSExcelDeleteSelectionshift = null)
        {
            var apiCallPath = "/MSExcel/DeleteSelection";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelDeleteSelection = new JObject();
            var mSExcelDeleteSelectionpropCount = 0;
            if (mSExcelDeleteSelectionhandle != null)
            {
                mSExcelDeleteSelection["Handle"] = ExpressionConverter.ConvertO(mSExcelDeleteSelectionhandle);
                mSExcelDeleteSelectionpropCount++;
            }

            if (mSExcelDeleteSelectionworkbookName != null)
            {
                mSExcelDeleteSelection["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelDeleteSelectionworkbookName);
                mSExcelDeleteSelectionpropCount++;
            }

            if (mSExcelDeleteSelectionworksheetName != null)
            {
                mSExcelDeleteSelection["WorksheetName"] = ExpressionConverter.ConvertO(mSExcelDeleteSelectionworksheetName);
                mSExcelDeleteSelectionpropCount++;
            }

            if (mSExcelDeleteSelectioncellReference != null)
            {
                mSExcelDeleteSelection["CellReference"] = ExpressionConverter.ConvertO(mSExcelDeleteSelectioncellReference);
                mSExcelDeleteSelectionpropCount++;
            }

            if (mSExcelDeleteSelectionentireRow != null)
            {
                mSExcelDeleteSelection["EntireRow"] = ExpressionConverter.ConvertO(mSExcelDeleteSelectionentireRow);
                mSExcelDeleteSelectionpropCount++;
            }

            if (mSExcelDeleteSelectionentireColumn != null)
            {
                mSExcelDeleteSelection["EntireColumn"] = ExpressionConverter.ConvertO(mSExcelDeleteSelectionentireColumn);
                mSExcelDeleteSelectionpropCount++;
            }

            if (mSExcelDeleteSelectionshift != null)
            {
                mSExcelDeleteSelection["Shift"] = ExpressionConverter.ConvertO(mSExcelDeleteSelectionshift);
                mSExcelDeleteSelectionpropCount++;
            }

            mSExcelDeleteSelectionpropCount++;
            mSExcelDeleteSelection["Workflow"] = ExpressionConverter.ConvertO(mSExcelDeleteSelectionworkflow);
            if (mSExcelDeleteSelectionpropCount > 0)
            {
                callPayload.Body = mSExcelDeleteSelection;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelClearExcelClipboard(Expression<Func<string>> mSExcelClearExcelClipboardworkflow, Expression<Func<int>> mSExcelClearExcelClipboardhandle = null)
        {
            var apiCallPath = "/MSExcel/ClearExcelClipboard";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelClearExcelClipboard = new JObject();
            var mSExcelClearExcelClipboardpropCount = 0;
            if (mSExcelClearExcelClipboardhandle != null)
            {
                mSExcelClearExcelClipboard["Handle"] = ExpressionConverter.ConvertO(mSExcelClearExcelClipboardhandle);
                mSExcelClearExcelClipboardpropCount++;
            }

            mSExcelClearExcelClipboardpropCount++;
            mSExcelClearExcelClipboard["Workflow"] = ExpressionConverter.ConvertO(mSExcelClearExcelClipboardworkflow);
            if (mSExcelClearExcelClipboardpropCount > 0)
            {
                callPayload.Body = mSExcelClearExcelClipboard;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelRunMacroResponse> MSExcelRunMacro(Expression<Func<string>> mSExcelRunMacromacroName, Expression<Func<string>> mSExcelRunMacroworkflow, Expression<Func<int>> mSExcelRunMacrohandle = null, Expression<Func<int>> mSExcelRunMacronumberOfArguments = null, Expression<Func<string>> mSExcelRunMacroargument1 = null, Expression<Func<string>> mSExcelRunMacroargument2 = null, Expression<Func<string>> mSExcelRunMacroargument3 = null, Expression<Func<string>> mSExcelRunMacroargument4 = null, Expression<Func<string>> mSExcelRunMacroargument5 = null, Expression<Func<string>> mSExcelRunMacroargument6 = null, Expression<Func<string>> mSExcelRunMacroargument7 = null, Expression<Func<string>> mSExcelRunMacroargument8 = null, Expression<Func<string>> mSExcelRunMacroargument9 = null, Expression<Func<string>> mSExcelRunMacroargument10 = null, Expression<Func<bool>> mSExcelRunMacrorunInBackground = null)
        {
            var apiCallPath = "/MSExcel/RunMacro";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelRunMacro = new JObject();
            var mSExcelRunMacropropCount = 0;
            if (mSExcelRunMacrohandle != null)
            {
                mSExcelRunMacro["Handle"] = ExpressionConverter.ConvertO(mSExcelRunMacrohandle);
                mSExcelRunMacropropCount++;
            }

            mSExcelRunMacropropCount++;
            mSExcelRunMacro["MacroName"] = ExpressionConverter.ConvertO(mSExcelRunMacromacroName);
            if (mSExcelRunMacronumberOfArguments != null)
            {
                mSExcelRunMacro["NumberOfArguments"] = ExpressionConverter.ConvertO(mSExcelRunMacronumberOfArguments);
                mSExcelRunMacropropCount++;
            }

            if (mSExcelRunMacroargument1 != null)
            {
                mSExcelRunMacro["Argument1"] = ExpressionConverter.ConvertO(mSExcelRunMacroargument1);
                mSExcelRunMacropropCount++;
            }

            if (mSExcelRunMacroargument2 != null)
            {
                mSExcelRunMacro["Argument2"] = ExpressionConverter.ConvertO(mSExcelRunMacroargument2);
                mSExcelRunMacropropCount++;
            }

            if (mSExcelRunMacroargument3 != null)
            {
                mSExcelRunMacro["Argument3"] = ExpressionConverter.ConvertO(mSExcelRunMacroargument3);
                mSExcelRunMacropropCount++;
            }

            if (mSExcelRunMacroargument4 != null)
            {
                mSExcelRunMacro["Argument4"] = ExpressionConverter.ConvertO(mSExcelRunMacroargument4);
                mSExcelRunMacropropCount++;
            }

            if (mSExcelRunMacroargument5 != null)
            {
                mSExcelRunMacro["Argument5"] = ExpressionConverter.ConvertO(mSExcelRunMacroargument5);
                mSExcelRunMacropropCount++;
            }

            if (mSExcelRunMacroargument6 != null)
            {
                mSExcelRunMacro["Argument6"] = ExpressionConverter.ConvertO(mSExcelRunMacroargument6);
                mSExcelRunMacropropCount++;
            }

            if (mSExcelRunMacroargument7 != null)
            {
                mSExcelRunMacro["Argument7"] = ExpressionConverter.ConvertO(mSExcelRunMacroargument7);
                mSExcelRunMacropropCount++;
            }

            if (mSExcelRunMacroargument8 != null)
            {
                mSExcelRunMacro["Argument8"] = ExpressionConverter.ConvertO(mSExcelRunMacroargument8);
                mSExcelRunMacropropCount++;
            }

            if (mSExcelRunMacroargument9 != null)
            {
                mSExcelRunMacro["Argument9"] = ExpressionConverter.ConvertO(mSExcelRunMacroargument9);
                mSExcelRunMacropropCount++;
            }

            if (mSExcelRunMacroargument10 != null)
            {
                mSExcelRunMacro["Argument10"] = ExpressionConverter.ConvertO(mSExcelRunMacroargument10);
                mSExcelRunMacropropCount++;
            }

            if (mSExcelRunMacrorunInBackground != null)
            {
                mSExcelRunMacro["RunInBackground"] = ExpressionConverter.ConvertO(mSExcelRunMacrorunInBackground);
                mSExcelRunMacropropCount++;
            }

            mSExcelRunMacropropCount++;
            mSExcelRunMacro["Workflow"] = ExpressionConverter.ConvertO(mSExcelRunMacroworkflow);
            if (mSExcelRunMacropropCount > 0)
            {
                callPayload.Body = mSExcelRunMacro;
            }

            return new ApiConnectionAction<MSExcelRunMacroResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelAddMacroToWorkbook(Expression<Func<string>> mSExcelAddMacroToWorkbookmacroCode, Expression<Func<string>> mSExcelAddMacroToWorkbookworkflow, Expression<Func<int>> mSExcelAddMacroToWorkbookhandle = null, Expression<Func<string>> mSExcelAddMacroToWorkbookworkbookName = null)
        {
            var apiCallPath = "/MSExcel/AddMacroToWorkbook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelAddMacroToWorkbook = new JObject();
            var mSExcelAddMacroToWorkbookpropCount = 0;
            if (mSExcelAddMacroToWorkbookhandle != null)
            {
                mSExcelAddMacroToWorkbook["Handle"] = ExpressionConverter.ConvertO(mSExcelAddMacroToWorkbookhandle);
                mSExcelAddMacroToWorkbookpropCount++;
            }

            if (mSExcelAddMacroToWorkbookworkbookName != null)
            {
                mSExcelAddMacroToWorkbook["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelAddMacroToWorkbookworkbookName);
                mSExcelAddMacroToWorkbookpropCount++;
            }

            mSExcelAddMacroToWorkbookpropCount++;
            mSExcelAddMacroToWorkbook["MacroCode"] = ExpressionConverter.ConvertO(mSExcelAddMacroToWorkbookmacroCode);
            mSExcelAddMacroToWorkbookpropCount++;
            mSExcelAddMacroToWorkbook["Workflow"] = ExpressionConverter.ConvertO(mSExcelAddMacroToWorkbookworkflow);
            if (mSExcelAddMacroToWorkbookpropCount > 0)
            {
                callPayload.Body = mSExcelAddMacroToWorkbook;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelTrustVBOMInRegistry(Expression<Func<string>> mSExcelTrustVBOMInRegistryworkflow, Expression<Func<int>> mSExcelTrustVBOMInRegistryexcelVersion = null, Expression<Func<bool>> mSExcelTrustVBOMInRegistrytrustVBOM = null)
        {
            var apiCallPath = "/MSExcel/TrustVBOMInRegistry";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelTrustVBOMInRegistry = new JObject();
            var mSExcelTrustVBOMInRegistrypropCount = 0;
            if (mSExcelTrustVBOMInRegistryexcelVersion != null)
            {
                mSExcelTrustVBOMInRegistry["ExcelVersion"] = ExpressionConverter.ConvertO(mSExcelTrustVBOMInRegistryexcelVersion);
                mSExcelTrustVBOMInRegistrypropCount++;
            }

            if (mSExcelTrustVBOMInRegistrytrustVBOM != null)
            {
                mSExcelTrustVBOMInRegistry["TrustVBOM"] = ExpressionConverter.ConvertO(mSExcelTrustVBOMInRegistrytrustVBOM);
                mSExcelTrustVBOMInRegistrypropCount++;
            }

            mSExcelTrustVBOMInRegistrypropCount++;
            mSExcelTrustVBOMInRegistry["Workflow"] = ExpressionConverter.ConvertO(mSExcelTrustVBOMInRegistryworkflow);
            if (mSExcelTrustVBOMInRegistrypropCount > 0)
            {
                callPayload.Body = mSExcelTrustVBOMInRegistry;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelSetCalculationMode(Expression<Func<int>> mSExcelSetCalculationModecalculationMode, Expression<Func<string>> mSExcelSetCalculationModeworkflow, Expression<Func<int>> mSExcelSetCalculationModehandle = null)
        {
            var apiCallPath = "/MSExcel/SetCalculationMode";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelSetCalculationMode = new JObject();
            var mSExcelSetCalculationModepropCount = 0;
            if (mSExcelSetCalculationModehandle != null)
            {
                mSExcelSetCalculationMode["Handle"] = ExpressionConverter.ConvertO(mSExcelSetCalculationModehandle);
                mSExcelSetCalculationModepropCount++;
            }

            mSExcelSetCalculationModepropCount++;
            mSExcelSetCalculationMode["CalculationMode"] = ExpressionConverter.ConvertO(mSExcelSetCalculationModecalculationMode);
            mSExcelSetCalculationModepropCount++;
            mSExcelSetCalculationMode["Workflow"] = ExpressionConverter.ConvertO(mSExcelSetCalculationModeworkflow);
            if (mSExcelSetCalculationModepropCount > 0)
            {
                callPayload.Body = mSExcelSetCalculationMode;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelExecuteCommandBarObject(Expression<Func<string>> mSExcelExecuteCommandBarObjectobjectId, Expression<Func<string>> mSExcelExecuteCommandBarObjectworkflow, Expression<Func<int>> mSExcelExecuteCommandBarObjecthandle = null, Expression<Func<bool>> mSExcelExecuteCommandBarObjectrunInBackground = null)
        {
            var apiCallPath = "/MSExcel/ExecuteCommandBarObject";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelExecuteCommandBarObject = new JObject();
            var mSExcelExecuteCommandBarObjectpropCount = 0;
            if (mSExcelExecuteCommandBarObjecthandle != null)
            {
                mSExcelExecuteCommandBarObject["Handle"] = ExpressionConverter.ConvertO(mSExcelExecuteCommandBarObjecthandle);
                mSExcelExecuteCommandBarObjectpropCount++;
            }

            mSExcelExecuteCommandBarObjectpropCount++;
            mSExcelExecuteCommandBarObject["ObjectId"] = ExpressionConverter.ConvertO(mSExcelExecuteCommandBarObjectobjectId);
            if (mSExcelExecuteCommandBarObjectrunInBackground != null)
            {
                mSExcelExecuteCommandBarObject["RunInBackground"] = ExpressionConverter.ConvertO(mSExcelExecuteCommandBarObjectrunInBackground);
                mSExcelExecuteCommandBarObjectpropCount++;
            }

            mSExcelExecuteCommandBarObjectpropCount++;
            mSExcelExecuteCommandBarObject["Workflow"] = ExpressionConverter.ConvertO(mSExcelExecuteCommandBarObjectworkflow);
            if (mSExcelExecuteCommandBarObjectpropCount > 0)
            {
                callPayload.Body = mSExcelExecuteCommandBarObject;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelCopyBetweenCellsResponse> MSExcelCopyBetweenCells(Expression<Func<string>> mSExcelCopyBetweenCellssourceCellReference, Expression<Func<string>> mSExcelCopyBetweenCellstargetCellReference, Expression<Func<string>> mSExcelCopyBetweenCellsworkflow, Expression<Func<int>> mSExcelCopyBetweenCellssourceHandle = null, Expression<Func<string>> mSExcelCopyBetweenCellssourceWorkbookName = null, Expression<Func<string>> mSExcelCopyBetweenCellssourceWorksheetName = null, Expression<Func<bool>> mSExcelCopyBetweenCellssourceEntireRow = null, Expression<Func<bool>> mSExcelCopyBetweenCellssourceEntireColumn = null, Expression<Func<int>> mSExcelCopyBetweenCellstargetHandle = null, Expression<Func<string>> mSExcelCopyBetweenCellstargetWorkbookName = null, Expression<Func<string>> mSExcelCopyBetweenCellstargetWorksheetName = null, Expression<Func<bool>> mSExcelCopyBetweenCellstargetEntireRow = null, Expression<Func<bool>> mSExcelCopyBetweenCellstargetEntireColumn = null, Expression<Func<bool>> mSExcelCopyBetweenCellsvaluesOnly = null, Expression<Func<bool>> mSExcelCopyBetweenCellssimplePasteOnly = null)
        {
            var apiCallPath = "/MSExcel/CopyBetweenCells";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelCopyBetweenCells = new JObject();
            var mSExcelCopyBetweenCellspropCount = 0;
            if (mSExcelCopyBetweenCellssourceHandle != null)
            {
                mSExcelCopyBetweenCells["SourceHandle"] = ExpressionConverter.ConvertO(mSExcelCopyBetweenCellssourceHandle);
                mSExcelCopyBetweenCellspropCount++;
            }

            if (mSExcelCopyBetweenCellssourceWorkbookName != null)
            {
                mSExcelCopyBetweenCells["SourceWorkbookName"] = ExpressionConverter.ConvertO(mSExcelCopyBetweenCellssourceWorkbookName);
                mSExcelCopyBetweenCellspropCount++;
            }

            if (mSExcelCopyBetweenCellssourceWorksheetName != null)
            {
                mSExcelCopyBetweenCells["SourceWorksheetName"] = ExpressionConverter.ConvertO(mSExcelCopyBetweenCellssourceWorksheetName);
                mSExcelCopyBetweenCellspropCount++;
            }

            mSExcelCopyBetweenCellspropCount++;
            mSExcelCopyBetweenCells["SourceCellReference"] = ExpressionConverter.ConvertO(mSExcelCopyBetweenCellssourceCellReference);
            if (mSExcelCopyBetweenCellssourceEntireRow != null)
            {
                mSExcelCopyBetweenCells["SourceEntireRow"] = ExpressionConverter.ConvertO(mSExcelCopyBetweenCellssourceEntireRow);
                mSExcelCopyBetweenCellspropCount++;
            }

            if (mSExcelCopyBetweenCellssourceEntireColumn != null)
            {
                mSExcelCopyBetweenCells["SourceEntireColumn"] = ExpressionConverter.ConvertO(mSExcelCopyBetweenCellssourceEntireColumn);
                mSExcelCopyBetweenCellspropCount++;
            }

            if (mSExcelCopyBetweenCellstargetHandle != null)
            {
                mSExcelCopyBetweenCells["TargetHandle"] = ExpressionConverter.ConvertO(mSExcelCopyBetweenCellstargetHandle);
                mSExcelCopyBetweenCellspropCount++;
            }

            if (mSExcelCopyBetweenCellstargetWorkbookName != null)
            {
                mSExcelCopyBetweenCells["TargetWorkbookName"] = ExpressionConverter.ConvertO(mSExcelCopyBetweenCellstargetWorkbookName);
                mSExcelCopyBetweenCellspropCount++;
            }

            if (mSExcelCopyBetweenCellstargetWorksheetName != null)
            {
                mSExcelCopyBetweenCells["TargetWorksheetName"] = ExpressionConverter.ConvertO(mSExcelCopyBetweenCellstargetWorksheetName);
                mSExcelCopyBetweenCellspropCount++;
            }

            mSExcelCopyBetweenCellspropCount++;
            mSExcelCopyBetweenCells["TargetCellReference"] = ExpressionConverter.ConvertO(mSExcelCopyBetweenCellstargetCellReference);
            if (mSExcelCopyBetweenCellstargetEntireRow != null)
            {
                mSExcelCopyBetweenCells["TargetEntireRow"] = ExpressionConverter.ConvertO(mSExcelCopyBetweenCellstargetEntireRow);
                mSExcelCopyBetweenCellspropCount++;
            }

            if (mSExcelCopyBetweenCellstargetEntireColumn != null)
            {
                mSExcelCopyBetweenCells["TargetEntireColumn"] = ExpressionConverter.ConvertO(mSExcelCopyBetweenCellstargetEntireColumn);
                mSExcelCopyBetweenCellspropCount++;
            }

            if (mSExcelCopyBetweenCellsvaluesOnly != null)
            {
                mSExcelCopyBetweenCells["ValuesOnly"] = ExpressionConverter.ConvertO(mSExcelCopyBetweenCellsvaluesOnly);
                mSExcelCopyBetweenCellspropCount++;
            }

            if (mSExcelCopyBetweenCellssimplePasteOnly != null)
            {
                mSExcelCopyBetweenCells["SimplePasteOnly"] = ExpressionConverter.ConvertO(mSExcelCopyBetweenCellssimplePasteOnly);
                mSExcelCopyBetweenCellspropCount++;
            }

            mSExcelCopyBetweenCellspropCount++;
            mSExcelCopyBetweenCells["Workflow"] = ExpressionConverter.ConvertO(mSExcelCopyBetweenCellsworkflow);
            if (mSExcelCopyBetweenCellspropCount > 0)
            {
                callPayload.Body = mSExcelCopyBetweenCells;
            }

            return new ApiConnectionAction<MSExcelCopyBetweenCellsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelCutBetweenCellsResponse> MSExcelCutBetweenCells(Expression<Func<string>> mSExcelCutBetweenCellssourceCellReference, Expression<Func<string>> mSExcelCutBetweenCellstargetCellReference, Expression<Func<string>> mSExcelCutBetweenCellsworkflow, Expression<Func<int>> mSExcelCutBetweenCellssourceHandle = null, Expression<Func<string>> mSExcelCutBetweenCellssourceWorkbookName = null, Expression<Func<string>> mSExcelCutBetweenCellssourceWorksheetName = null, Expression<Func<bool>> mSExcelCutBetweenCellssourceEntireRow = null, Expression<Func<bool>> mSExcelCutBetweenCellssourceEntireColumn = null, Expression<Func<int>> mSExcelCutBetweenCellstargetHandle = null, Expression<Func<string>> mSExcelCutBetweenCellstargetWorkbookName = null, Expression<Func<string>> mSExcelCutBetweenCellstargetWorksheetName = null, Expression<Func<bool>> mSExcelCutBetweenCellstargetEntireRow = null, Expression<Func<bool>> mSExcelCutBetweenCellstargetEntireColumn = null, Expression<Func<bool>> mSExcelCutBetweenCellsvaluesOnly = null)
        {
            var apiCallPath = "/MSExcel/CutBetweenCells";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelCutBetweenCells = new JObject();
            var mSExcelCutBetweenCellspropCount = 0;
            if (mSExcelCutBetweenCellssourceHandle != null)
            {
                mSExcelCutBetweenCells["SourceHandle"] = ExpressionConverter.ConvertO(mSExcelCutBetweenCellssourceHandle);
                mSExcelCutBetweenCellspropCount++;
            }

            if (mSExcelCutBetweenCellssourceWorkbookName != null)
            {
                mSExcelCutBetweenCells["SourceWorkbookName"] = ExpressionConverter.ConvertO(mSExcelCutBetweenCellssourceWorkbookName);
                mSExcelCutBetweenCellspropCount++;
            }

            if (mSExcelCutBetweenCellssourceWorksheetName != null)
            {
                mSExcelCutBetweenCells["SourceWorksheetName"] = ExpressionConverter.ConvertO(mSExcelCutBetweenCellssourceWorksheetName);
                mSExcelCutBetweenCellspropCount++;
            }

            mSExcelCutBetweenCellspropCount++;
            mSExcelCutBetweenCells["SourceCellReference"] = ExpressionConverter.ConvertO(mSExcelCutBetweenCellssourceCellReference);
            if (mSExcelCutBetweenCellssourceEntireRow != null)
            {
                mSExcelCutBetweenCells["SourceEntireRow"] = ExpressionConverter.ConvertO(mSExcelCutBetweenCellssourceEntireRow);
                mSExcelCutBetweenCellspropCount++;
            }

            if (mSExcelCutBetweenCellssourceEntireColumn != null)
            {
                mSExcelCutBetweenCells["SourceEntireColumn"] = ExpressionConverter.ConvertO(mSExcelCutBetweenCellssourceEntireColumn);
                mSExcelCutBetweenCellspropCount++;
            }

            if (mSExcelCutBetweenCellstargetHandle != null)
            {
                mSExcelCutBetweenCells["TargetHandle"] = ExpressionConverter.ConvertO(mSExcelCutBetweenCellstargetHandle);
                mSExcelCutBetweenCellspropCount++;
            }

            if (mSExcelCutBetweenCellstargetWorkbookName != null)
            {
                mSExcelCutBetweenCells["TargetWorkbookName"] = ExpressionConverter.ConvertO(mSExcelCutBetweenCellstargetWorkbookName);
                mSExcelCutBetweenCellspropCount++;
            }

            if (mSExcelCutBetweenCellstargetWorksheetName != null)
            {
                mSExcelCutBetweenCells["TargetWorksheetName"] = ExpressionConverter.ConvertO(mSExcelCutBetweenCellstargetWorksheetName);
                mSExcelCutBetweenCellspropCount++;
            }

            mSExcelCutBetweenCellspropCount++;
            mSExcelCutBetweenCells["TargetCellReference"] = ExpressionConverter.ConvertO(mSExcelCutBetweenCellstargetCellReference);
            if (mSExcelCutBetweenCellstargetEntireRow != null)
            {
                mSExcelCutBetweenCells["TargetEntireRow"] = ExpressionConverter.ConvertO(mSExcelCutBetweenCellstargetEntireRow);
                mSExcelCutBetweenCellspropCount++;
            }

            if (mSExcelCutBetweenCellstargetEntireColumn != null)
            {
                mSExcelCutBetweenCells["TargetEntireColumn"] = ExpressionConverter.ConvertO(mSExcelCutBetweenCellstargetEntireColumn);
                mSExcelCutBetweenCellspropCount++;
            }

            if (mSExcelCutBetweenCellsvaluesOnly != null)
            {
                mSExcelCutBetweenCells["ValuesOnly"] = ExpressionConverter.ConvertO(mSExcelCutBetweenCellsvaluesOnly);
                mSExcelCutBetweenCellspropCount++;
            }

            mSExcelCutBetweenCellspropCount++;
            mSExcelCutBetweenCells["Workflow"] = ExpressionConverter.ConvertO(mSExcelCutBetweenCellsworkflow);
            if (mSExcelCutBetweenCellspropCount > 0)
            {
                callPayload.Body = mSExcelCutBetweenCells;
            }

            return new ApiConnectionAction<MSExcelCutBetweenCellsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelMinimiseWindowResponse> MSExcelMinimiseWindow(Expression<Func<string>> mSExcelMinimiseWindowworkflow, Expression<Func<int>> mSExcelMinimiseWindowhandle = null)
        {
            var apiCallPath = "/MSExcel/MinimiseWindow";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelMinimiseWindow = new JObject();
            var mSExcelMinimiseWindowpropCount = 0;
            if (mSExcelMinimiseWindowhandle != null)
            {
                mSExcelMinimiseWindow["Handle"] = ExpressionConverter.ConvertO(mSExcelMinimiseWindowhandle);
                mSExcelMinimiseWindowpropCount++;
            }

            mSExcelMinimiseWindowpropCount++;
            mSExcelMinimiseWindow["Workflow"] = ExpressionConverter.ConvertO(mSExcelMinimiseWindowworkflow);
            if (mSExcelMinimiseWindowpropCount > 0)
            {
                callPayload.Body = mSExcelMinimiseWindow;
            }

            return new ApiConnectionAction<MSExcelMinimiseWindowResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelMaximiseWindowResponse> MSExcelMaximiseWindow(Expression<Func<string>> mSExcelMaximiseWindowworkflow, Expression<Func<int>> mSExcelMaximiseWindowhandle = null)
        {
            var apiCallPath = "/MSExcel/MaximiseWindow";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelMaximiseWindow = new JObject();
            var mSExcelMaximiseWindowpropCount = 0;
            if (mSExcelMaximiseWindowhandle != null)
            {
                mSExcelMaximiseWindow["Handle"] = ExpressionConverter.ConvertO(mSExcelMaximiseWindowhandle);
                mSExcelMaximiseWindowpropCount++;
            }

            mSExcelMaximiseWindowpropCount++;
            mSExcelMaximiseWindow["Workflow"] = ExpressionConverter.ConvertO(mSExcelMaximiseWindowworkflow);
            if (mSExcelMaximiseWindowpropCount > 0)
            {
                callPayload.Body = mSExcelMaximiseWindow;
            }

            return new ApiConnectionAction<MSExcelMaximiseWindowResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelNormaliseWindowResponse> MSExcelNormaliseWindow(Expression<Func<string>> mSExcelNormaliseWindowworkflow, Expression<Func<int>> mSExcelNormaliseWindowhandle = null)
        {
            var apiCallPath = "/MSExcel/NormaliseWindow";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelNormaliseWindow = new JObject();
            var mSExcelNormaliseWindowpropCount = 0;
            if (mSExcelNormaliseWindowhandle != null)
            {
                mSExcelNormaliseWindow["Handle"] = ExpressionConverter.ConvertO(mSExcelNormaliseWindowhandle);
                mSExcelNormaliseWindowpropCount++;
            }

            mSExcelNormaliseWindowpropCount++;
            mSExcelNormaliseWindow["Workflow"] = ExpressionConverter.ConvertO(mSExcelNormaliseWindowworkflow);
            if (mSExcelNormaliseWindowpropCount > 0)
            {
                callPayload.Body = mSExcelNormaliseWindow;
            }

            return new ApiConnectionAction<MSExcelNormaliseWindowResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetAndSetCellValueResponse> MSExcelGetAndSetCellValue(Expression<Func<string>> mSExcelGetAndSetCellValuesourceCellReference, Expression<Func<string>> mSExcelGetAndSetCellValuetargetCellReference, Expression<Func<string>> mSExcelGetAndSetCellValueworkflow, Expression<Func<int>> mSExcelGetAndSetCellValuesourceHandle = null, Expression<Func<string>> mSExcelGetAndSetCellValuesourceWorkbookName = null, Expression<Func<string>> mSExcelGetAndSetCellValuesourceWorksheetName = null, Expression<Func<int>> mSExcelGetAndSetCellValuetargetHandle = null, Expression<Func<string>> mSExcelGetAndSetCellValuetargetWorkbookName = null, Expression<Func<string>> mSExcelGetAndSetCellValuetargetWorksheetName = null)
        {
            var apiCallPath = "/MSExcel/GetAndSetCellValue";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelGetAndSetCellValue = new JObject();
            var mSExcelGetAndSetCellValuepropCount = 0;
            if (mSExcelGetAndSetCellValuesourceHandle != null)
            {
                mSExcelGetAndSetCellValue["SourceHandle"] = ExpressionConverter.ConvertO(mSExcelGetAndSetCellValuesourceHandle);
                mSExcelGetAndSetCellValuepropCount++;
            }

            if (mSExcelGetAndSetCellValuesourceWorkbookName != null)
            {
                mSExcelGetAndSetCellValue["SourceWorkbookName"] = ExpressionConverter.ConvertO(mSExcelGetAndSetCellValuesourceWorkbookName);
                mSExcelGetAndSetCellValuepropCount++;
            }

            if (mSExcelGetAndSetCellValuesourceWorksheetName != null)
            {
                mSExcelGetAndSetCellValue["SourceWorksheetName"] = ExpressionConverter.ConvertO(mSExcelGetAndSetCellValuesourceWorksheetName);
                mSExcelGetAndSetCellValuepropCount++;
            }

            mSExcelGetAndSetCellValuepropCount++;
            mSExcelGetAndSetCellValue["SourceCellReference"] = ExpressionConverter.ConvertO(mSExcelGetAndSetCellValuesourceCellReference);
            if (mSExcelGetAndSetCellValuetargetHandle != null)
            {
                mSExcelGetAndSetCellValue["TargetHandle"] = ExpressionConverter.ConvertO(mSExcelGetAndSetCellValuetargetHandle);
                mSExcelGetAndSetCellValuepropCount++;
            }

            if (mSExcelGetAndSetCellValuetargetWorkbookName != null)
            {
                mSExcelGetAndSetCellValue["TargetWorkbookName"] = ExpressionConverter.ConvertO(mSExcelGetAndSetCellValuetargetWorkbookName);
                mSExcelGetAndSetCellValuepropCount++;
            }

            if (mSExcelGetAndSetCellValuetargetWorksheetName != null)
            {
                mSExcelGetAndSetCellValue["TargetWorksheetName"] = ExpressionConverter.ConvertO(mSExcelGetAndSetCellValuetargetWorksheetName);
                mSExcelGetAndSetCellValuepropCount++;
            }

            mSExcelGetAndSetCellValuepropCount++;
            mSExcelGetAndSetCellValue["TargetCellReference"] = ExpressionConverter.ConvertO(mSExcelGetAndSetCellValuetargetCellReference);
            mSExcelGetAndSetCellValuepropCount++;
            mSExcelGetAndSetCellValue["Workflow"] = ExpressionConverter.ConvertO(mSExcelGetAndSetCellValueworkflow);
            if (mSExcelGetAndSetCellValuepropCount > 0)
            {
                callPayload.Body = mSExcelGetAndSetCellValue;
            }

            return new ApiConnectionAction<MSExcelGetAndSetCellValueResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetAndSetCellValue2Response> MSExcelGetAndSetCellValue2(Expression<Func<string>> mSExcelGetAndSetCellValue2sourceCellReference, Expression<Func<string>> mSExcelGetAndSetCellValue2targetCellReference, Expression<Func<string>> mSExcelGetAndSetCellValue2workflow, Expression<Func<int>> mSExcelGetAndSetCellValue2sourceHandle = null, Expression<Func<string>> mSExcelGetAndSetCellValue2sourceWorkbookName = null, Expression<Func<string>> mSExcelGetAndSetCellValue2sourceWorksheetName = null, Expression<Func<int>> mSExcelGetAndSetCellValue2targetHandle = null, Expression<Func<string>> mSExcelGetAndSetCellValue2targetWorkbookName = null, Expression<Func<string>> mSExcelGetAndSetCellValue2targetWorksheetName = null)
        {
            var apiCallPath = "/MSExcel/GetAndSetCellValue2";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelGetAndSetCellValue2 = new JObject();
            var mSExcelGetAndSetCellValue2propCount = 0;
            if (mSExcelGetAndSetCellValue2sourceHandle != null)
            {
                mSExcelGetAndSetCellValue2["SourceHandle"] = ExpressionConverter.ConvertO(mSExcelGetAndSetCellValue2sourceHandle);
                mSExcelGetAndSetCellValue2propCount++;
            }

            if (mSExcelGetAndSetCellValue2sourceWorkbookName != null)
            {
                mSExcelGetAndSetCellValue2["SourceWorkbookName"] = ExpressionConverter.ConvertO(mSExcelGetAndSetCellValue2sourceWorkbookName);
                mSExcelGetAndSetCellValue2propCount++;
            }

            if (mSExcelGetAndSetCellValue2sourceWorksheetName != null)
            {
                mSExcelGetAndSetCellValue2["SourceWorksheetName"] = ExpressionConverter.ConvertO(mSExcelGetAndSetCellValue2sourceWorksheetName);
                mSExcelGetAndSetCellValue2propCount++;
            }

            mSExcelGetAndSetCellValue2propCount++;
            mSExcelGetAndSetCellValue2["SourceCellReference"] = ExpressionConverter.ConvertO(mSExcelGetAndSetCellValue2sourceCellReference);
            if (mSExcelGetAndSetCellValue2targetHandle != null)
            {
                mSExcelGetAndSetCellValue2["TargetHandle"] = ExpressionConverter.ConvertO(mSExcelGetAndSetCellValue2targetHandle);
                mSExcelGetAndSetCellValue2propCount++;
            }

            if (mSExcelGetAndSetCellValue2targetWorkbookName != null)
            {
                mSExcelGetAndSetCellValue2["TargetWorkbookName"] = ExpressionConverter.ConvertO(mSExcelGetAndSetCellValue2targetWorkbookName);
                mSExcelGetAndSetCellValue2propCount++;
            }

            if (mSExcelGetAndSetCellValue2targetWorksheetName != null)
            {
                mSExcelGetAndSetCellValue2["TargetWorksheetName"] = ExpressionConverter.ConvertO(mSExcelGetAndSetCellValue2targetWorksheetName);
                mSExcelGetAndSetCellValue2propCount++;
            }

            mSExcelGetAndSetCellValue2propCount++;
            mSExcelGetAndSetCellValue2["TargetCellReference"] = ExpressionConverter.ConvertO(mSExcelGetAndSetCellValue2targetCellReference);
            mSExcelGetAndSetCellValue2propCount++;
            mSExcelGetAndSetCellValue2["Workflow"] = ExpressionConverter.ConvertO(mSExcelGetAndSetCellValue2workflow);
            if (mSExcelGetAndSetCellValue2propCount > 0)
            {
                callPayload.Body = mSExcelGetAndSetCellValue2;
            }

            return new ApiConnectionAction<MSExcelGetAndSetCellValue2Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetAndSetCellTextResponse> MSExcelGetAndSetCellText(Expression<Func<string>> mSExcelGetAndSetCellTextsourceCellReference, Expression<Func<string>> mSExcelGetAndSetCellTexttargetCellReference, Expression<Func<string>> mSExcelGetAndSetCellTextworkflow, Expression<Func<int>> mSExcelGetAndSetCellTextsourceHandle = null, Expression<Func<string>> mSExcelGetAndSetCellTextsourceWorkbookName = null, Expression<Func<string>> mSExcelGetAndSetCellTextsourceWorksheetName = null, Expression<Func<int>> mSExcelGetAndSetCellTexttargetHandle = null, Expression<Func<string>> mSExcelGetAndSetCellTexttargetWorkbookName = null, Expression<Func<string>> mSExcelGetAndSetCellTexttargetWorksheetName = null)
        {
            var apiCallPath = "/MSExcel/GetAndSetCellText";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelGetAndSetCellText = new JObject();
            var mSExcelGetAndSetCellTextpropCount = 0;
            if (mSExcelGetAndSetCellTextsourceHandle != null)
            {
                mSExcelGetAndSetCellText["SourceHandle"] = ExpressionConverter.ConvertO(mSExcelGetAndSetCellTextsourceHandle);
                mSExcelGetAndSetCellTextpropCount++;
            }

            if (mSExcelGetAndSetCellTextsourceWorkbookName != null)
            {
                mSExcelGetAndSetCellText["SourceWorkbookName"] = ExpressionConverter.ConvertO(mSExcelGetAndSetCellTextsourceWorkbookName);
                mSExcelGetAndSetCellTextpropCount++;
            }

            if (mSExcelGetAndSetCellTextsourceWorksheetName != null)
            {
                mSExcelGetAndSetCellText["SourceWorksheetName"] = ExpressionConverter.ConvertO(mSExcelGetAndSetCellTextsourceWorksheetName);
                mSExcelGetAndSetCellTextpropCount++;
            }

            mSExcelGetAndSetCellTextpropCount++;
            mSExcelGetAndSetCellText["SourceCellReference"] = ExpressionConverter.ConvertO(mSExcelGetAndSetCellTextsourceCellReference);
            if (mSExcelGetAndSetCellTexttargetHandle != null)
            {
                mSExcelGetAndSetCellText["TargetHandle"] = ExpressionConverter.ConvertO(mSExcelGetAndSetCellTexttargetHandle);
                mSExcelGetAndSetCellTextpropCount++;
            }

            if (mSExcelGetAndSetCellTexttargetWorkbookName != null)
            {
                mSExcelGetAndSetCellText["TargetWorkbookName"] = ExpressionConverter.ConvertO(mSExcelGetAndSetCellTexttargetWorkbookName);
                mSExcelGetAndSetCellTextpropCount++;
            }

            if (mSExcelGetAndSetCellTexttargetWorksheetName != null)
            {
                mSExcelGetAndSetCellText["TargetWorksheetName"] = ExpressionConverter.ConvertO(mSExcelGetAndSetCellTexttargetWorksheetName);
                mSExcelGetAndSetCellTextpropCount++;
            }

            mSExcelGetAndSetCellTextpropCount++;
            mSExcelGetAndSetCellText["TargetCellReference"] = ExpressionConverter.ConvertO(mSExcelGetAndSetCellTexttargetCellReference);
            mSExcelGetAndSetCellTextpropCount++;
            mSExcelGetAndSetCellText["Workflow"] = ExpressionConverter.ConvertO(mSExcelGetAndSetCellTextworkflow);
            if (mSExcelGetAndSetCellTextpropCount > 0)
            {
                callPayload.Body = mSExcelGetAndSetCellText;
            }

            return new ApiConnectionAction<MSExcelGetAndSetCellTextResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelCheckOLEObjectResponse> MSExcelCheckOLEObject(Expression<Func<string>> mSExcelCheckOLEObjectoLEObjectName, Expression<Func<string>> mSExcelCheckOLEObjectworkflow, Expression<Func<int>> mSExcelCheckOLEObjecthandle = null, Expression<Func<string>> mSExcelCheckOLEObjectworkbookName = null, Expression<Func<string>> mSExcelCheckOLEObjectworksheetName = null, Expression<Func<bool>> mSExcelCheckOLEObjectchecked = null, Expression<Func<bool>> mSExcelCheckOLEObjectrunInBackground = null)
        {
            var apiCallPath = "/MSExcel/CheckOLEObject";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelCheckOLEObject = new JObject();
            var mSExcelCheckOLEObjectpropCount = 0;
            if (mSExcelCheckOLEObjecthandle != null)
            {
                mSExcelCheckOLEObject["Handle"] = ExpressionConverter.ConvertO(mSExcelCheckOLEObjecthandle);
                mSExcelCheckOLEObjectpropCount++;
            }

            if (mSExcelCheckOLEObjectworkbookName != null)
            {
                mSExcelCheckOLEObject["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelCheckOLEObjectworkbookName);
                mSExcelCheckOLEObjectpropCount++;
            }

            if (mSExcelCheckOLEObjectworksheetName != null)
            {
                mSExcelCheckOLEObject["WorksheetName"] = ExpressionConverter.ConvertO(mSExcelCheckOLEObjectworksheetName);
                mSExcelCheckOLEObjectpropCount++;
            }

            mSExcelCheckOLEObjectpropCount++;
            mSExcelCheckOLEObject["OLEObjectName"] = ExpressionConverter.ConvertO(mSExcelCheckOLEObjectoLEObjectName);
            if (mSExcelCheckOLEObjectchecked != null)
            {
                mSExcelCheckOLEObject["Checked"] = ExpressionConverter.ConvertO(mSExcelCheckOLEObjectchecked);
                mSExcelCheckOLEObjectpropCount++;
            }

            if (mSExcelCheckOLEObjectrunInBackground != null)
            {
                mSExcelCheckOLEObject["RunInBackground"] = ExpressionConverter.ConvertO(mSExcelCheckOLEObjectrunInBackground);
                mSExcelCheckOLEObjectpropCount++;
            }

            mSExcelCheckOLEObjectpropCount++;
            mSExcelCheckOLEObject["Workflow"] = ExpressionConverter.ConvertO(mSExcelCheckOLEObjectworkflow);
            if (mSExcelCheckOLEObjectpropCount > 0)
            {
                callPayload.Body = mSExcelCheckOLEObject;
            }

            return new ApiConnectionAction<MSExcelCheckOLEObjectResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelInputTextIntoOLEObjectResponse> MSExcelInputTextIntoOLEObject(Expression<Func<string>> mSExcelInputTextIntoOLEObjectoLEObjectName, Expression<Func<string>> mSExcelInputTextIntoOLEObjectworkflow, Expression<Func<int>> mSExcelInputTextIntoOLEObjecthandle = null, Expression<Func<string>> mSExcelInputTextIntoOLEObjectworkbookName = null, Expression<Func<string>> mSExcelInputTextIntoOLEObjectworksheetName = null, Expression<Func<string>> mSExcelInputTextIntoOLEObjecttextToInput = null, Expression<Func<bool>> mSExcelInputTextIntoOLEObjectrunInBackground = null)
        {
            var apiCallPath = "/MSExcel/InputTextIntoOLEObject";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelInputTextIntoOLEObject = new JObject();
            var mSExcelInputTextIntoOLEObjectpropCount = 0;
            if (mSExcelInputTextIntoOLEObjecthandle != null)
            {
                mSExcelInputTextIntoOLEObject["Handle"] = ExpressionConverter.ConvertO(mSExcelInputTextIntoOLEObjecthandle);
                mSExcelInputTextIntoOLEObjectpropCount++;
            }

            if (mSExcelInputTextIntoOLEObjectworkbookName != null)
            {
                mSExcelInputTextIntoOLEObject["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelInputTextIntoOLEObjectworkbookName);
                mSExcelInputTextIntoOLEObjectpropCount++;
            }

            if (mSExcelInputTextIntoOLEObjectworksheetName != null)
            {
                mSExcelInputTextIntoOLEObject["WorksheetName"] = ExpressionConverter.ConvertO(mSExcelInputTextIntoOLEObjectworksheetName);
                mSExcelInputTextIntoOLEObjectpropCount++;
            }

            mSExcelInputTextIntoOLEObjectpropCount++;
            mSExcelInputTextIntoOLEObject["OLEObjectName"] = ExpressionConverter.ConvertO(mSExcelInputTextIntoOLEObjectoLEObjectName);
            if (mSExcelInputTextIntoOLEObjecttextToInput != null)
            {
                mSExcelInputTextIntoOLEObject["TextToInput"] = ExpressionConverter.ConvertO(mSExcelInputTextIntoOLEObjecttextToInput);
                mSExcelInputTextIntoOLEObjectpropCount++;
            }

            if (mSExcelInputTextIntoOLEObjectrunInBackground != null)
            {
                mSExcelInputTextIntoOLEObject["RunInBackground"] = ExpressionConverter.ConvertO(mSExcelInputTextIntoOLEObjectrunInBackground);
                mSExcelInputTextIntoOLEObjectpropCount++;
            }

            mSExcelInputTextIntoOLEObjectpropCount++;
            mSExcelInputTextIntoOLEObject["Workflow"] = ExpressionConverter.ConvertO(mSExcelInputTextIntoOLEObjectworkflow);
            if (mSExcelInputTextIntoOLEObjectpropCount > 0)
            {
                callPayload.Body = mSExcelInputTextIntoOLEObject;
            }

            return new ApiConnectionAction<MSExcelInputTextIntoOLEObjectResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelSetCellBackgroundColourResponse> MSExcelSetCellBackgroundColour(Expression<Func<string>> mSExcelSetCellBackgroundColourcellReference, Expression<Func<int>> mSExcelSetCellBackgroundColourcolourIndex, Expression<Func<string>> mSExcelSetCellBackgroundColourworkflow, Expression<Func<int>> mSExcelSetCellBackgroundColourhandle = null, Expression<Func<string>> mSExcelSetCellBackgroundColourworkbookName = null, Expression<Func<string>> mSExcelSetCellBackgroundColourworksheetName = null)
        {
            var apiCallPath = "/MSExcel/SetCellBackgroundColour";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelSetCellBackgroundColour = new JObject();
            var mSExcelSetCellBackgroundColourpropCount = 0;
            if (mSExcelSetCellBackgroundColourhandle != null)
            {
                mSExcelSetCellBackgroundColour["Handle"] = ExpressionConverter.ConvertO(mSExcelSetCellBackgroundColourhandle);
                mSExcelSetCellBackgroundColourpropCount++;
            }

            if (mSExcelSetCellBackgroundColourworkbookName != null)
            {
                mSExcelSetCellBackgroundColour["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelSetCellBackgroundColourworkbookName);
                mSExcelSetCellBackgroundColourpropCount++;
            }

            if (mSExcelSetCellBackgroundColourworksheetName != null)
            {
                mSExcelSetCellBackgroundColour["WorksheetName"] = ExpressionConverter.ConvertO(mSExcelSetCellBackgroundColourworksheetName);
                mSExcelSetCellBackgroundColourpropCount++;
            }

            mSExcelSetCellBackgroundColourpropCount++;
            mSExcelSetCellBackgroundColour["CellReference"] = ExpressionConverter.ConvertO(mSExcelSetCellBackgroundColourcellReference);
            mSExcelSetCellBackgroundColourpropCount++;
            mSExcelSetCellBackgroundColour["ColourIndex"] = ExpressionConverter.ConvertO(mSExcelSetCellBackgroundColourcolourIndex);
            mSExcelSetCellBackgroundColourpropCount++;
            mSExcelSetCellBackgroundColour["Workflow"] = ExpressionConverter.ConvertO(mSExcelSetCellBackgroundColourworkflow);
            if (mSExcelSetCellBackgroundColourpropCount > 0)
            {
                callPayload.Body = mSExcelSetCellBackgroundColour;
            }

            return new ApiConnectionAction<MSExcelSetCellBackgroundColourResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetCellBackgroundColourResponse> MSExcelGetCellBackgroundColour(Expression<Func<string>> mSExcelGetCellBackgroundColourcellReference, Expression<Func<string>> mSExcelGetCellBackgroundColourworkflow, Expression<Func<int>> mSExcelGetCellBackgroundColourhandle = null, Expression<Func<string>> mSExcelGetCellBackgroundColourworkbookName = null, Expression<Func<string>> mSExcelGetCellBackgroundColourworksheetName = null)
        {
            var apiCallPath = "/MSExcel/GetCellBackgroundColour";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelGetCellBackgroundColour = new JObject();
            var mSExcelGetCellBackgroundColourpropCount = 0;
            if (mSExcelGetCellBackgroundColourhandle != null)
            {
                mSExcelGetCellBackgroundColour["Handle"] = ExpressionConverter.ConvertO(mSExcelGetCellBackgroundColourhandle);
                mSExcelGetCellBackgroundColourpropCount++;
            }

            if (mSExcelGetCellBackgroundColourworkbookName != null)
            {
                mSExcelGetCellBackgroundColour["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelGetCellBackgroundColourworkbookName);
                mSExcelGetCellBackgroundColourpropCount++;
            }

            if (mSExcelGetCellBackgroundColourworksheetName != null)
            {
                mSExcelGetCellBackgroundColour["WorksheetName"] = ExpressionConverter.ConvertO(mSExcelGetCellBackgroundColourworksheetName);
                mSExcelGetCellBackgroundColourpropCount++;
            }

            mSExcelGetCellBackgroundColourpropCount++;
            mSExcelGetCellBackgroundColour["CellReference"] = ExpressionConverter.ConvertO(mSExcelGetCellBackgroundColourcellReference);
            mSExcelGetCellBackgroundColourpropCount++;
            mSExcelGetCellBackgroundColour["Workflow"] = ExpressionConverter.ConvertO(mSExcelGetCellBackgroundColourworkflow);
            if (mSExcelGetCellBackgroundColourpropCount > 0)
            {
                callPayload.Body = mSExcelGetCellBackgroundColour;
            }

            return new ApiConnectionAction<MSExcelGetCellBackgroundColourResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetOLEObjectValueResponse> MSExcelGetOLEObjectValue(Expression<Func<string>> mSExcelGetOLEObjectValueoLEObjectName, Expression<Func<string>> mSExcelGetOLEObjectValueworkflow, Expression<Func<int>> mSExcelGetOLEObjectValuehandle = null, Expression<Func<string>> mSExcelGetOLEObjectValueworkbookName = null, Expression<Func<string>> mSExcelGetOLEObjectValueworksheetName = null)
        {
            var apiCallPath = "/MSExcel/GetOLEObjectValue";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelGetOLEObjectValue = new JObject();
            var mSExcelGetOLEObjectValuepropCount = 0;
            if (mSExcelGetOLEObjectValuehandle != null)
            {
                mSExcelGetOLEObjectValue["Handle"] = ExpressionConverter.ConvertO(mSExcelGetOLEObjectValuehandle);
                mSExcelGetOLEObjectValuepropCount++;
            }

            if (mSExcelGetOLEObjectValueworkbookName != null)
            {
                mSExcelGetOLEObjectValue["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelGetOLEObjectValueworkbookName);
                mSExcelGetOLEObjectValuepropCount++;
            }

            if (mSExcelGetOLEObjectValueworksheetName != null)
            {
                mSExcelGetOLEObjectValue["WorksheetName"] = ExpressionConverter.ConvertO(mSExcelGetOLEObjectValueworksheetName);
                mSExcelGetOLEObjectValuepropCount++;
            }

            mSExcelGetOLEObjectValuepropCount++;
            mSExcelGetOLEObjectValue["OLEObjectName"] = ExpressionConverter.ConvertO(mSExcelGetOLEObjectValueoLEObjectName);
            mSExcelGetOLEObjectValuepropCount++;
            mSExcelGetOLEObjectValue["Workflow"] = ExpressionConverter.ConvertO(mSExcelGetOLEObjectValueworkflow);
            if (mSExcelGetOLEObjectValuepropCount > 0)
            {
                callPayload.Body = mSExcelGetOLEObjectValue;
            }

            return new ApiConnectionAction<MSExcelGetOLEObjectValueResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelDoesOLEObjectExistResponse> MSExcelDoesOLEObjectExist(Expression<Func<string>> mSExcelDoesOLEObjectExistoLEObjectName, Expression<Func<string>> mSExcelDoesOLEObjectExistworkflow, Expression<Func<int>> mSExcelDoesOLEObjectExisthandle = null, Expression<Func<string>> mSExcelDoesOLEObjectExistworkbookName = null, Expression<Func<string>> mSExcelDoesOLEObjectExistworksheetName = null)
        {
            var apiCallPath = "/MSExcel/DoesOLEObjectExist";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelDoesOLEObjectExist = new JObject();
            var mSExcelDoesOLEObjectExistpropCount = 0;
            if (mSExcelDoesOLEObjectExisthandle != null)
            {
                mSExcelDoesOLEObjectExist["Handle"] = ExpressionConverter.ConvertO(mSExcelDoesOLEObjectExisthandle);
                mSExcelDoesOLEObjectExistpropCount++;
            }

            if (mSExcelDoesOLEObjectExistworkbookName != null)
            {
                mSExcelDoesOLEObjectExist["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelDoesOLEObjectExistworkbookName);
                mSExcelDoesOLEObjectExistpropCount++;
            }

            if (mSExcelDoesOLEObjectExistworksheetName != null)
            {
                mSExcelDoesOLEObjectExist["WorksheetName"] = ExpressionConverter.ConvertO(mSExcelDoesOLEObjectExistworksheetName);
                mSExcelDoesOLEObjectExistpropCount++;
            }

            mSExcelDoesOLEObjectExistpropCount++;
            mSExcelDoesOLEObjectExist["OLEObjectName"] = ExpressionConverter.ConvertO(mSExcelDoesOLEObjectExistoLEObjectName);
            mSExcelDoesOLEObjectExistpropCount++;
            mSExcelDoesOLEObjectExist["Workflow"] = ExpressionConverter.ConvertO(mSExcelDoesOLEObjectExistworkflow);
            if (mSExcelDoesOLEObjectExistpropCount > 0)
            {
                callPayload.Body = mSExcelDoesOLEObjectExist;
            }

            return new ApiConnectionAction<MSExcelDoesOLEObjectExistResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelPressOLEObjectResponse> MSExcelPressOLEObject(Expression<Func<string>> mSExcelPressOLEObjectoLEObjectName, Expression<Func<string>> mSExcelPressOLEObjectworkflow, Expression<Func<int>> mSExcelPressOLEObjecthandle = null, Expression<Func<string>> mSExcelPressOLEObjectworkbookName = null, Expression<Func<string>> mSExcelPressOLEObjectworksheetName = null, Expression<Func<bool>> mSExcelPressOLEObjectrunInBackground = null)
        {
            var apiCallPath = "/MSExcel/PressOLEObject";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelPressOLEObject = new JObject();
            var mSExcelPressOLEObjectpropCount = 0;
            if (mSExcelPressOLEObjecthandle != null)
            {
                mSExcelPressOLEObject["Handle"] = ExpressionConverter.ConvertO(mSExcelPressOLEObjecthandle);
                mSExcelPressOLEObjectpropCount++;
            }

            if (mSExcelPressOLEObjectworkbookName != null)
            {
                mSExcelPressOLEObject["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelPressOLEObjectworkbookName);
                mSExcelPressOLEObjectpropCount++;
            }

            if (mSExcelPressOLEObjectworksheetName != null)
            {
                mSExcelPressOLEObject["WorksheetName"] = ExpressionConverter.ConvertO(mSExcelPressOLEObjectworksheetName);
                mSExcelPressOLEObjectpropCount++;
            }

            mSExcelPressOLEObjectpropCount++;
            mSExcelPressOLEObject["OLEObjectName"] = ExpressionConverter.ConvertO(mSExcelPressOLEObjectoLEObjectName);
            if (mSExcelPressOLEObjectrunInBackground != null)
            {
                mSExcelPressOLEObject["RunInBackground"] = ExpressionConverter.ConvertO(mSExcelPressOLEObjectrunInBackground);
                mSExcelPressOLEObjectpropCount++;
            }

            mSExcelPressOLEObjectpropCount++;
            mSExcelPressOLEObject["Workflow"] = ExpressionConverter.ConvertO(mSExcelPressOLEObjectworkflow);
            if (mSExcelPressOLEObjectpropCount > 0)
            {
                callPayload.Body = mSExcelPressOLEObject;
            }

            return new ApiConnectionAction<MSExcelPressOLEObjectResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelSetWorksheetSensitivityLabelResponse> MSExcelSetWorksheetSensitivityLabel(Expression<Func<mSExcelSetWorksheetSensitivityLabelassignmentMethodInput>> mSExcelSetWorksheetSensitivityLabelassignmentMethod, Expression<Func<string>> mSExcelSetWorksheetSensitivityLabellabelId, Expression<Func<string>> mSExcelSetWorksheetSensitivityLabelworkflow, Expression<Func<int>> mSExcelSetWorksheetSensitivityLabelhandle = null, Expression<Func<string>> mSExcelSetWorksheetSensitivityLabelworkbookName = null, Expression<Func<string>> mSExcelSetWorksheetSensitivityLabellabelName = null, Expression<Func<string>> mSExcelSetWorksheetSensitivityLabelsiteId = null, Expression<Func<string>> mSExcelSetWorksheetSensitivityLabeljustification = null)
        {
            var apiCallPath = "/MSExcel/SetWorksheetSensitivityLabel";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelSetWorksheetSensitivityLabel = new JObject();
            var mSExcelSetWorksheetSensitivityLabelpropCount = 0;
            if (mSExcelSetWorksheetSensitivityLabelhandle != null)
            {
                mSExcelSetWorksheetSensitivityLabel["Handle"] = ExpressionConverter.ConvertO(mSExcelSetWorksheetSensitivityLabelhandle);
                mSExcelSetWorksheetSensitivityLabelpropCount++;
            }

            if (mSExcelSetWorksheetSensitivityLabelworkbookName != null)
            {
                mSExcelSetWorksheetSensitivityLabel["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelSetWorksheetSensitivityLabelworkbookName);
                mSExcelSetWorksheetSensitivityLabelpropCount++;
            }

            mSExcelSetWorksheetSensitivityLabelpropCount++;
            mSExcelSetWorksheetSensitivityLabel["AssignmentMethod"] = ExpressionConverter.ConvertO(mSExcelSetWorksheetSensitivityLabelassignmentMethod);
            mSExcelSetWorksheetSensitivityLabelpropCount++;
            mSExcelSetWorksheetSensitivityLabel["LabelId"] = ExpressionConverter.ConvertO(mSExcelSetWorksheetSensitivityLabellabelId);
            if (mSExcelSetWorksheetSensitivityLabellabelName != null)
            {
                mSExcelSetWorksheetSensitivityLabel["LabelName"] = ExpressionConverter.ConvertO(mSExcelSetWorksheetSensitivityLabellabelName);
                mSExcelSetWorksheetSensitivityLabelpropCount++;
            }

            if (mSExcelSetWorksheetSensitivityLabelsiteId != null)
            {
                mSExcelSetWorksheetSensitivityLabel["SiteId"] = ExpressionConverter.ConvertO(mSExcelSetWorksheetSensitivityLabelsiteId);
                mSExcelSetWorksheetSensitivityLabelpropCount++;
            }

            if (mSExcelSetWorksheetSensitivityLabeljustification != null)
            {
                mSExcelSetWorksheetSensitivityLabel["Justification"] = ExpressionConverter.ConvertO(mSExcelSetWorksheetSensitivityLabeljustification);
                mSExcelSetWorksheetSensitivityLabelpropCount++;
            }

            mSExcelSetWorksheetSensitivityLabelpropCount++;
            mSExcelSetWorksheetSensitivityLabel["Workflow"] = ExpressionConverter.ConvertO(mSExcelSetWorksheetSensitivityLabelworkflow);
            if (mSExcelSetWorksheetSensitivityLabelpropCount > 0)
            {
                callPayload.Body = mSExcelSetWorksheetSensitivityLabel;
            }

            return new ApiConnectionAction<MSExcelSetWorksheetSensitivityLabelResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetWorksheetSensitivityLabelResponse> MSExcelGetWorksheetSensitivityLabel(Expression<Func<string>> mSExcelGetWorksheetSensitivityLabelworkflow, Expression<Func<int>> mSExcelGetWorksheetSensitivityLabelhandle = null, Expression<Func<string>> mSExcelGetWorksheetSensitivityLabelworkbookName = null)
        {
            var apiCallPath = "/MSExcel/GetWorksheetSensitivityLabel";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelGetWorksheetSensitivityLabel = new JObject();
            var mSExcelGetWorksheetSensitivityLabelpropCount = 0;
            if (mSExcelGetWorksheetSensitivityLabelhandle != null)
            {
                mSExcelGetWorksheetSensitivityLabel["Handle"] = ExpressionConverter.ConvertO(mSExcelGetWorksheetSensitivityLabelhandle);
                mSExcelGetWorksheetSensitivityLabelpropCount++;
            }

            if (mSExcelGetWorksheetSensitivityLabelworkbookName != null)
            {
                mSExcelGetWorksheetSensitivityLabel["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelGetWorksheetSensitivityLabelworkbookName);
                mSExcelGetWorksheetSensitivityLabelpropCount++;
            }

            mSExcelGetWorksheetSensitivityLabelpropCount++;
            mSExcelGetWorksheetSensitivityLabel["Workflow"] = ExpressionConverter.ConvertO(mSExcelGetWorksheetSensitivityLabelworkflow);
            if (mSExcelGetWorksheetSensitivityLabelpropCount > 0)
            {
                callPayload.Body = mSExcelGetWorksheetSensitivityLabel;
            }

            return new ApiConnectionAction<MSExcelGetWorksheetSensitivityLabelResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelWriteArrayResponse> MSExcelWriteArray(Expression<Func<string>> mSExcelWriteArraycellReference, Expression<Func<string>> mSExcelWriteArrayarrayToWriteJSON, Expression<Func<mSExcelWriteArraydirectionInput>> mSExcelWriteArraydirection, Expression<Func<string>> mSExcelWriteArrayworkflow, Expression<Func<int>> mSExcelWriteArrayhandle = null, Expression<Func<string>> mSExcelWriteArrayworkbookName = null, Expression<Func<string>> mSExcelWriteArrayworksheetName = null)
        {
            var apiCallPath = "/MSExcel/WriteArray";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSExcelWriteArray = new JObject();
            var mSExcelWriteArraypropCount = 0;
            if (mSExcelWriteArrayhandle != null)
            {
                mSExcelWriteArray["Handle"] = ExpressionConverter.ConvertO(mSExcelWriteArrayhandle);
                mSExcelWriteArraypropCount++;
            }

            if (mSExcelWriteArrayworkbookName != null)
            {
                mSExcelWriteArray["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelWriteArrayworkbookName);
                mSExcelWriteArraypropCount++;
            }

            if (mSExcelWriteArrayworksheetName != null)
            {
                mSExcelWriteArray["WorksheetName"] = ExpressionConverter.ConvertO(mSExcelWriteArrayworksheetName);
                mSExcelWriteArraypropCount++;
            }

            mSExcelWriteArraypropCount++;
            mSExcelWriteArray["CellReference"] = ExpressionConverter.ConvertO(mSExcelWriteArraycellReference);
            mSExcelWriteArraypropCount++;
            mSExcelWriteArray["ArrayToWriteJSON"] = ExpressionConverter.ConvertO(mSExcelWriteArrayarrayToWriteJSON);
            mSExcelWriteArraypropCount++;
            mSExcelWriteArray["Direction"] = ExpressionConverter.ConvertO(mSExcelWriteArraydirection);
            mSExcelWriteArraypropCount++;
            mSExcelWriteArray["Workflow"] = ExpressionConverter.ConvertO(mSExcelWriteArrayworkflow);
            if (mSExcelWriteArraypropCount > 0)
            {
                callPayload.Body = mSExcelWriteArray;
            }

            return new ApiConnectionAction<MSExcelWriteArrayResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookCreateInstanceResponse> MSOutlookCreateInstance(Expression<Func<string>> mSOutlookCreateInstanceworkflow, Expression<Func<string>> mSOutlookCreateInstanceprofileName = null, Expression<Func<bool>> mSOutlookCreateInstanceshowOutlook = null)
        {
            var apiCallPath = "/MSOutlook/CreateInstance";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSOutlookCreateInstance = new JObject();
            var mSOutlookCreateInstancepropCount = 0;
            if (mSOutlookCreateInstanceprofileName != null)
            {
                mSOutlookCreateInstance["ProfileName"] = ExpressionConverter.ConvertO(mSOutlookCreateInstanceprofileName);
                mSOutlookCreateInstancepropCount++;
            }

            if (mSOutlookCreateInstanceshowOutlook != null)
            {
                mSOutlookCreateInstance["ShowOutlook"] = ExpressionConverter.ConvertO(mSOutlookCreateInstanceshowOutlook);
                mSOutlookCreateInstancepropCount++;
            }

            mSOutlookCreateInstancepropCount++;
            mSOutlookCreateInstance["Workflow"] = ExpressionConverter.ConvertO(mSOutlookCreateInstanceworkflow);
            if (mSOutlookCreateInstancepropCount > 0)
            {
                callPayload.Body = mSOutlookCreateInstance;
            }

            return new ApiConnectionAction<MSOutlookCreateInstanceResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSOutlookCloseInstance(Expression<Func<string>> mSOutlookCloseInstanceworkflow, Expression<Func<int>> mSOutlookCloseInstancesecondsToWaitForProcessToClose = null)
        {
            var apiCallPath = "/MSOutlook/CloseInstance";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSOutlookCloseInstance = new JObject();
            var mSOutlookCloseInstancepropCount = 0;
            if (mSOutlookCloseInstancesecondsToWaitForProcessToClose != null)
            {
                mSOutlookCloseInstance["SecondsToWaitForProcessToClose"] = ExpressionConverter.ConvertO(mSOutlookCloseInstancesecondsToWaitForProcessToClose);
                mSOutlookCloseInstancepropCount++;
            }

            mSOutlookCloseInstancepropCount++;
            mSOutlookCloseInstance["Workflow"] = ExpressionConverter.ConvertO(mSOutlookCloseInstanceworkflow);
            if (mSOutlookCloseInstancepropCount > 0)
            {
                callPayload.Body = mSOutlookCloseInstance;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSOutlookCloseInstanceUsingWindow(Expression<Func<string>> mSOutlookCloseInstanceUsingWindowworkflow, Expression<Func<bool>> mSOutlookCloseInstanceUsingWindowuseNativeWindow = null, Expression<Func<bool>> mSOutlookCloseInstanceUsingWindowuseUIA = null, Expression<Func<int>> mSOutlookCloseInstanceUsingWindowsecondsToWaitForProcessToClose = null)
        {
            var apiCallPath = "/MSOutlook/CloseInstanceUsingWindow";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSOutlookCloseInstanceUsingWindow = new JObject();
            var mSOutlookCloseInstanceUsingWindowpropCount = 0;
            if (mSOutlookCloseInstanceUsingWindowuseNativeWindow != null)
            {
                mSOutlookCloseInstanceUsingWindow["UseNativeWindow"] = ExpressionConverter.ConvertO(mSOutlookCloseInstanceUsingWindowuseNativeWindow);
                mSOutlookCloseInstanceUsingWindowpropCount++;
            }

            if (mSOutlookCloseInstanceUsingWindowuseUIA != null)
            {
                mSOutlookCloseInstanceUsingWindow["UseUIA"] = ExpressionConverter.ConvertO(mSOutlookCloseInstanceUsingWindowuseUIA);
                mSOutlookCloseInstanceUsingWindowpropCount++;
            }

            if (mSOutlookCloseInstanceUsingWindowsecondsToWaitForProcessToClose != null)
            {
                mSOutlookCloseInstanceUsingWindow["SecondsToWaitForProcessToClose"] = ExpressionConverter.ConvertO(mSOutlookCloseInstanceUsingWindowsecondsToWaitForProcessToClose);
                mSOutlookCloseInstanceUsingWindowpropCount++;
            }

            mSOutlookCloseInstanceUsingWindowpropCount++;
            mSOutlookCloseInstanceUsingWindow["Workflow"] = ExpressionConverter.ConvertO(mSOutlookCloseInstanceUsingWindowworkflow);
            if (mSOutlookCloseInstanceUsingWindowpropCount > 0)
            {
                callPayload.Body = mSOutlookCloseInstanceUsingWindow;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookAttachToExistingInstanceResponse> MSOutlookAttachToExistingInstance(Expression<Func<string>> mSOutlookAttachToExistingInstanceworkflow, Expression<Func<bool>> mSOutlookAttachToExistingInstancetoggleWindow = null, Expression<Func<bool>> mSOutlookAttachToExistingInstancetoggleUsesGlobalLeftMouseClickAgent = null, Expression<Func<double>> mSOutlookAttachToExistingInstancetoggleDelay = null)
        {
            var apiCallPath = "/MSOutlook/MSOutlookAttachToExistingInstance";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSOutlookAttachToExistingInstance = new JObject();
            var mSOutlookAttachToExistingInstancepropCount = 0;
            if (mSOutlookAttachToExistingInstancetoggleWindow != null)
            {
                mSOutlookAttachToExistingInstance["ToggleWindow"] = ExpressionConverter.ConvertO(mSOutlookAttachToExistingInstancetoggleWindow);
                mSOutlookAttachToExistingInstancepropCount++;
            }

            if (mSOutlookAttachToExistingInstancetoggleUsesGlobalLeftMouseClickAgent != null)
            {
                mSOutlookAttachToExistingInstance["ToggleUsesGlobalLeftMouseClickAgent"] = ExpressionConverter.ConvertO(mSOutlookAttachToExistingInstancetoggleUsesGlobalLeftMouseClickAgent);
                mSOutlookAttachToExistingInstancepropCount++;
            }

            if (mSOutlookAttachToExistingInstancetoggleDelay != null)
            {
                mSOutlookAttachToExistingInstance["ToggleDelay"] = ExpressionConverter.ConvertO(mSOutlookAttachToExistingInstancetoggleDelay);
                mSOutlookAttachToExistingInstancepropCount++;
            }

            mSOutlookAttachToExistingInstancepropCount++;
            mSOutlookAttachToExistingInstance["Workflow"] = ExpressionConverter.ConvertO(mSOutlookAttachToExistingInstanceworkflow);
            if (mSOutlookAttachToExistingInstancepropCount > 0)
            {
                callPayload.Body = mSOutlookAttachToExistingInstance;
            }

            return new ApiConnectionAction<MSOutlookAttachToExistingInstanceResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookIsConnectedResponse> MSOutlookIsConnected(Expression<Func<string>> mSOutlookIsConnectedworkflow)
        {
            var apiCallPath = "/MSOutlook/IsOutlookConnected";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSOutlookIsConnected = new JObject();
            var mSOutlookIsConnectedpropCount = 0;
            mSOutlookIsConnectedpropCount++;
            mSOutlookIsConnected["Workflow"] = ExpressionConverter.ConvertO(mSOutlookIsConnectedworkflow);
            if (mSOutlookIsConnectedpropCount > 0)
            {
                callPayload.Body = mSOutlookIsConnected;
            }

            return new ApiConnectionAction<MSOutlookIsConnectedResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSOutlookShow(Expression<Func<string>> mSOutlookShowworkflow)
        {
            var apiCallPath = "/MSOutlook/ShowOutlook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSOutlookShow = new JObject();
            var mSOutlookShowpropCount = 0;
            mSOutlookShowpropCount++;
            mSOutlookShow["Workflow"] = ExpressionConverter.ConvertO(mSOutlookShowworkflow);
            if (mSOutlookShowpropCount > 0)
            {
                callPayload.Body = mSOutlookShow;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookGetNameSpaceInformationResponse> MSOutlookGetNameSpaceInformation(Expression<Func<string>> mSOutlookGetNameSpaceInformationworkflow)
        {
            var apiCallPath = "/MSOutlook/GetNameSpaceInformation";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSOutlookGetNameSpaceInformation = new JObject();
            var mSOutlookGetNameSpaceInformationpropCount = 0;
            mSOutlookGetNameSpaceInformationpropCount++;
            mSOutlookGetNameSpaceInformation["Workflow"] = ExpressionConverter.ConvertO(mSOutlookGetNameSpaceInformationworkflow);
            if (mSOutlookGetNameSpaceInformationpropCount > 0)
            {
                callPayload.Body = mSOutlookGetNameSpaceInformation;
            }

            return new ApiConnectionAction<MSOutlookGetNameSpaceInformationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookGetMailFoldersResponse> MSOutlookGetMailFolders(Expression<Func<string>> mSOutlookGetMailFoldersworkflow, Expression<Func<string>> mSOutlookGetMailFoldersfolderPath = null, Expression<Func<bool>> mSOutlookGetMailFolderssubFolders = null)
        {
            var apiCallPath = "/MSOutlook/GetMailFolders";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSOutlookGetMailFolders = new JObject();
            var mSOutlookGetMailFolderspropCount = 0;
            if (mSOutlookGetMailFoldersfolderPath != null)
            {
                mSOutlookGetMailFolders["FolderPath"] = ExpressionConverter.ConvertO(mSOutlookGetMailFoldersfolderPath);
                mSOutlookGetMailFolderspropCount++;
            }

            if (mSOutlookGetMailFolderssubFolders != null)
            {
                mSOutlookGetMailFolders["SubFolders"] = ExpressionConverter.ConvertO(mSOutlookGetMailFolderssubFolders);
                mSOutlookGetMailFolderspropCount++;
            }

            mSOutlookGetMailFolderspropCount++;
            mSOutlookGetMailFolders["Workflow"] = ExpressionConverter.ConvertO(mSOutlookGetMailFoldersworkflow);
            if (mSOutlookGetMailFolderspropCount > 0)
            {
                callPayload.Body = mSOutlookGetMailFolders;
            }

            return new ApiConnectionAction<MSOutlookGetMailFoldersResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSOutlookMarkEmailAsRead(Expression<Func<string>> mSOutlookMarkEmailAsReadentryID, Expression<Func<string>> mSOutlookMarkEmailAsReadworkflow, Expression<Func<bool>> mSOutlookMarkEmailAsReadread = null)
        {
            var apiCallPath = "/MSOutlook/MarkEmailAsRead";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSOutlookMarkEmailAsRead = new JObject();
            var mSOutlookMarkEmailAsReadpropCount = 0;
            mSOutlookMarkEmailAsReadpropCount++;
            mSOutlookMarkEmailAsRead["EntryID"] = ExpressionConverter.ConvertO(mSOutlookMarkEmailAsReadentryID);
            if (mSOutlookMarkEmailAsReadread != null)
            {
                mSOutlookMarkEmailAsRead["Read"] = ExpressionConverter.ConvertO(mSOutlookMarkEmailAsReadread);
                mSOutlookMarkEmailAsReadpropCount++;
            }

            mSOutlookMarkEmailAsReadpropCount++;
            mSOutlookMarkEmailAsRead["Workflow"] = ExpressionConverter.ConvertO(mSOutlookMarkEmailAsReadworkflow);
            if (mSOutlookMarkEmailAsReadpropCount > 0)
            {
                callPayload.Body = mSOutlookMarkEmailAsRead;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookGetEmailBodyResponse> MSOutlookGetEmailBody(Expression<Func<string>> mSOutlookGetEmailBodyentryID, Expression<Func<string>> mSOutlookGetEmailBodyworkflow, Expression<Func<bool>> mSOutlookGetEmailBodyclickAllowButtonIfRequired = null)
        {
            var apiCallPath = "/MSOutlook/GetEmailBody";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSOutlookGetEmailBody = new JObject();
            var mSOutlookGetEmailBodypropCount = 0;
            mSOutlookGetEmailBodypropCount++;
            mSOutlookGetEmailBody["EntryID"] = ExpressionConverter.ConvertO(mSOutlookGetEmailBodyentryID);
            if (mSOutlookGetEmailBodyclickAllowButtonIfRequired != null)
            {
                mSOutlookGetEmailBody["ClickAllowButtonIfRequired"] = ExpressionConverter.ConvertO(mSOutlookGetEmailBodyclickAllowButtonIfRequired);
                mSOutlookGetEmailBodypropCount++;
            }

            mSOutlookGetEmailBodypropCount++;
            mSOutlookGetEmailBody["Workflow"] = ExpressionConverter.ConvertO(mSOutlookGetEmailBodyworkflow);
            if (mSOutlookGetEmailBodypropCount > 0)
            {
                callPayload.Body = mSOutlookGetEmailBody;
            }

            return new ApiConnectionAction<MSOutlookGetEmailBodyResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookGetEmailAttachmentFilenamesResponse> MSOutlookGetEmailAttachmentFilenames(Expression<Func<string>> mSOutlookGetEmailAttachmentFilenamesentryID, Expression<Func<string>> mSOutlookGetEmailAttachmentFilenamesworkflow, Expression<Func<bool>> mSOutlookGetEmailAttachmentFilenamesclickAllowButtonIfRequired = null)
        {
            var apiCallPath = "/MSOutlook/GetEmailAttachmentFilenames";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSOutlookGetEmailAttachmentFilenames = new JObject();
            var mSOutlookGetEmailAttachmentFilenamespropCount = 0;
            mSOutlookGetEmailAttachmentFilenamespropCount++;
            mSOutlookGetEmailAttachmentFilenames["EntryID"] = ExpressionConverter.ConvertO(mSOutlookGetEmailAttachmentFilenamesentryID);
            if (mSOutlookGetEmailAttachmentFilenamesclickAllowButtonIfRequired != null)
            {
                mSOutlookGetEmailAttachmentFilenames["ClickAllowButtonIfRequired"] = ExpressionConverter.ConvertO(mSOutlookGetEmailAttachmentFilenamesclickAllowButtonIfRequired);
                mSOutlookGetEmailAttachmentFilenamespropCount++;
            }

            mSOutlookGetEmailAttachmentFilenamespropCount++;
            mSOutlookGetEmailAttachmentFilenames["Workflow"] = ExpressionConverter.ConvertO(mSOutlookGetEmailAttachmentFilenamesworkflow);
            if (mSOutlookGetEmailAttachmentFilenamespropCount > 0)
            {
                callPayload.Body = mSOutlookGetEmailAttachmentFilenames;
            }

            return new ApiConnectionAction<MSOutlookGetEmailAttachmentFilenamesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookSaveEmailAttachmentsAsFileResponse> MSOutlookSaveEmailAttachmentsAsFile(Expression<Func<string>> mSOutlookSaveEmailAttachmentsAsFileentryID, Expression<Func<string>> mSOutlookSaveEmailAttachmentsAsFileworkflow, Expression<Func<string>> mSOutlookSaveEmailAttachmentsAsFilesaveFolderPath = null, Expression<Func<bool>> mSOutlookSaveEmailAttachmentsAsFilecreateFolder = null, Expression<Func<string>> mSOutlookSaveEmailAttachmentsAsFileonlySaveAttachmentsMatchingWildcard = null, Expression<Func<bool>> mSOutlookSaveEmailAttachmentsAsFilesaveHiddenAttachments = null, Expression<Func<bool>> mSOutlookSaveEmailAttachmentsAsFileclickAllowButtonIfRequired = null)
        {
            var apiCallPath = "/MSOutlook/SaveEmailAttachmentsAsFile";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSOutlookSaveEmailAttachmentsAsFile = new JObject();
            var mSOutlookSaveEmailAttachmentsAsFilepropCount = 0;
            mSOutlookSaveEmailAttachmentsAsFilepropCount++;
            mSOutlookSaveEmailAttachmentsAsFile["EntryID"] = ExpressionConverter.ConvertO(mSOutlookSaveEmailAttachmentsAsFileentryID);
            if (mSOutlookSaveEmailAttachmentsAsFilesaveFolderPath != null)
            {
                mSOutlookSaveEmailAttachmentsAsFile["SaveFolderPath"] = ExpressionConverter.ConvertO(mSOutlookSaveEmailAttachmentsAsFilesaveFolderPath);
                mSOutlookSaveEmailAttachmentsAsFilepropCount++;
            }

            if (mSOutlookSaveEmailAttachmentsAsFilecreateFolder != null)
            {
                mSOutlookSaveEmailAttachmentsAsFile["CreateFolder"] = ExpressionConverter.ConvertO(mSOutlookSaveEmailAttachmentsAsFilecreateFolder);
                mSOutlookSaveEmailAttachmentsAsFilepropCount++;
            }

            if (mSOutlookSaveEmailAttachmentsAsFileonlySaveAttachmentsMatchingWildcard != null)
            {
                mSOutlookSaveEmailAttachmentsAsFile["OnlySaveAttachmentsMatchingWildcard"] = ExpressionConverter.ConvertO(mSOutlookSaveEmailAttachmentsAsFileonlySaveAttachmentsMatchingWildcard);
                mSOutlookSaveEmailAttachmentsAsFilepropCount++;
            }

            if (mSOutlookSaveEmailAttachmentsAsFilesaveHiddenAttachments != null)
            {
                mSOutlookSaveEmailAttachmentsAsFile["SaveHiddenAttachments"] = ExpressionConverter.ConvertO(mSOutlookSaveEmailAttachmentsAsFilesaveHiddenAttachments);
                mSOutlookSaveEmailAttachmentsAsFilepropCount++;
            }

            if (mSOutlookSaveEmailAttachmentsAsFileclickAllowButtonIfRequired != null)
            {
                mSOutlookSaveEmailAttachmentsAsFile["ClickAllowButtonIfRequired"] = ExpressionConverter.ConvertO(mSOutlookSaveEmailAttachmentsAsFileclickAllowButtonIfRequired);
                mSOutlookSaveEmailAttachmentsAsFilepropCount++;
            }

            mSOutlookSaveEmailAttachmentsAsFilepropCount++;
            mSOutlookSaveEmailAttachmentsAsFile["Workflow"] = ExpressionConverter.ConvertO(mSOutlookSaveEmailAttachmentsAsFileworkflow);
            if (mSOutlookSaveEmailAttachmentsAsFilepropCount > 0)
            {
                callPayload.Body = mSOutlookSaveEmailAttachmentsAsFile;
            }

            return new ApiConnectionAction<MSOutlookSaveEmailAttachmentsAsFileResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSOutlookDeleteEmail(Expression<Func<string>> mSOutlookDeleteEmailentryID, Expression<Func<string>> mSOutlookDeleteEmailworkflow)
        {
            var apiCallPath = "/MSOutlook/DeleteEmail";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSOutlookDeleteEmail = new JObject();
            var mSOutlookDeleteEmailpropCount = 0;
            mSOutlookDeleteEmailpropCount++;
            mSOutlookDeleteEmail["EntryID"] = ExpressionConverter.ConvertO(mSOutlookDeleteEmailentryID);
            mSOutlookDeleteEmailpropCount++;
            mSOutlookDeleteEmail["Workflow"] = ExpressionConverter.ConvertO(mSOutlookDeleteEmailworkflow);
            if (mSOutlookDeleteEmailpropCount > 0)
            {
                callPayload.Body = mSOutlookDeleteEmail;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSOutlookMoveEmail(Expression<Func<string>> mSOutlookMoveEmailentryID, Expression<Func<string>> mSOutlookMoveEmailworkflow, Expression<Func<string>> mSOutlookMoveEmaildestinationFolder = null)
        {
            var apiCallPath = "/MSOutlook/MoveEmail";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSOutlookMoveEmail = new JObject();
            var mSOutlookMoveEmailpropCount = 0;
            mSOutlookMoveEmailpropCount++;
            mSOutlookMoveEmail["EntryID"] = ExpressionConverter.ConvertO(mSOutlookMoveEmailentryID);
            if (mSOutlookMoveEmaildestinationFolder != null)
            {
                mSOutlookMoveEmail["DestinationFolder"] = ExpressionConverter.ConvertO(mSOutlookMoveEmaildestinationFolder);
                mSOutlookMoveEmailpropCount++;
            }

            mSOutlookMoveEmailpropCount++;
            mSOutlookMoveEmail["Workflow"] = ExpressionConverter.ConvertO(mSOutlookMoveEmailworkflow);
            if (mSOutlookMoveEmailpropCount > 0)
            {
                callPayload.Body = mSOutlookMoveEmail;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSOutlookSendEmail(Expression<Func<string>> mSOutlookSendEmailworkflow, Expression<Func<string>> mSOutlookSendEmailto = null, Expression<Func<string>> mSOutlookSendEmailcC = null, Expression<Func<string>> mSOutlookSendEmailbCC = null, Expression<Func<string>> mSOutlookSendEmailsubject = null, Expression<Func<mSOutlookSendEmailbodyFormatInput>> mSOutlookSendEmailbodyFormat = null, Expression<Func<string>> mSOutlookSendEmailbody = null, Expression<Func<string>> mSOutlookSendEmailhTMLBody = null, Expression<Func<string>> mSOutlookSendEmailrTFBody = null, Expression<Func<string>> mSOutlookSendEmailattachmentFilenamesJSON = null, Expression<Func<bool>> mSOutlookSendEmaildontSendIfAttachmentFilenameMissing = null, Expression<Func<bool>> mSOutlookSendEmailclickAllowButtonIfRequired = null, Expression<Func<string>> mSOutlookSendEmailvotingOptions = null, Expression<Func<string>> mSOutlookSendEmailsendAsSMTPAddress = null, Expression<Func<bool>> mSOutlookSendEmailbodyContainsStoredPassword = null)
        {
            var apiCallPath = "/MSOutlook/SendEmail";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSOutlookSendEmail = new JObject();
            var mSOutlookSendEmailpropCount = 0;
            if (mSOutlookSendEmailto != null)
            {
                mSOutlookSendEmail["To"] = ExpressionConverter.ConvertO(mSOutlookSendEmailto);
                mSOutlookSendEmailpropCount++;
            }

            if (mSOutlookSendEmailcC != null)
            {
                mSOutlookSendEmail["CC"] = ExpressionConverter.ConvertO(mSOutlookSendEmailcC);
                mSOutlookSendEmailpropCount++;
            }

            if (mSOutlookSendEmailbCC != null)
            {
                mSOutlookSendEmail["BCC"] = ExpressionConverter.ConvertO(mSOutlookSendEmailbCC);
                mSOutlookSendEmailpropCount++;
            }

            if (mSOutlookSendEmailsubject != null)
            {
                mSOutlookSendEmail["Subject"] = ExpressionConverter.ConvertO(mSOutlookSendEmailsubject);
                mSOutlookSendEmailpropCount++;
            }

            if (mSOutlookSendEmailbodyFormat != null)
            {
                mSOutlookSendEmail["BodyFormat"] = ExpressionConverter.ConvertO(mSOutlookSendEmailbodyFormat);
                mSOutlookSendEmailpropCount++;
            }

            if (mSOutlookSendEmailbody != null)
            {
                mSOutlookSendEmail["Body"] = ExpressionConverter.ConvertO(mSOutlookSendEmailbody);
                mSOutlookSendEmailpropCount++;
            }

            if (mSOutlookSendEmailhTMLBody != null)
            {
                mSOutlookSendEmail["HTMLBody"] = ExpressionConverter.ConvertO(mSOutlookSendEmailhTMLBody);
                mSOutlookSendEmailpropCount++;
            }

            if (mSOutlookSendEmailrTFBody != null)
            {
                mSOutlookSendEmail["RTFBody"] = ExpressionConverter.ConvertO(mSOutlookSendEmailrTFBody);
                mSOutlookSendEmailpropCount++;
            }

            if (mSOutlookSendEmailattachmentFilenamesJSON != null)
            {
                mSOutlookSendEmail["AttachmentFilenamesJSON"] = ExpressionConverter.ConvertO(mSOutlookSendEmailattachmentFilenamesJSON);
                mSOutlookSendEmailpropCount++;
            }

            if (mSOutlookSendEmaildontSendIfAttachmentFilenameMissing != null)
            {
                mSOutlookSendEmail["DontSendIfAttachmentFilenameMissing"] = ExpressionConverter.ConvertO(mSOutlookSendEmaildontSendIfAttachmentFilenameMissing);
                mSOutlookSendEmailpropCount++;
            }

            if (mSOutlookSendEmailclickAllowButtonIfRequired != null)
            {
                mSOutlookSendEmail["ClickAllowButtonIfRequired"] = ExpressionConverter.ConvertO(mSOutlookSendEmailclickAllowButtonIfRequired);
                mSOutlookSendEmailpropCount++;
            }

            if (mSOutlookSendEmailvotingOptions != null)
            {
                mSOutlookSendEmail["VotingOptions"] = ExpressionConverter.ConvertO(mSOutlookSendEmailvotingOptions);
                mSOutlookSendEmailpropCount++;
            }

            if (mSOutlookSendEmailsendAsSMTPAddress != null)
            {
                mSOutlookSendEmail["SendAsSMTPAddress"] = ExpressionConverter.ConvertO(mSOutlookSendEmailsendAsSMTPAddress);
                mSOutlookSendEmailpropCount++;
            }

            if (mSOutlookSendEmailbodyContainsStoredPassword != null)
            {
                mSOutlookSendEmail["BodyContainsStoredPassword"] = ExpressionConverter.ConvertO(mSOutlookSendEmailbodyContainsStoredPassword);
                mSOutlookSendEmailpropCount++;
            }

            mSOutlookSendEmailpropCount++;
            mSOutlookSendEmail["Workflow"] = ExpressionConverter.ConvertO(mSOutlookSendEmailworkflow);
            if (mSOutlookSendEmailpropCount > 0)
            {
                callPayload.Body = mSOutlookSendEmail;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSOutlookCreateMailFolder(Expression<Func<string>> mSOutlookCreateMailFolderworkflow, Expression<Func<string>> mSOutlookCreateMailFolderparentFolderPath = null, Expression<Func<string>> mSOutlookCreateMailFoldernewFolderName = null)
        {
            var apiCallPath = "/MSOutlook/CreateMailFolder";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSOutlookCreateMailFolder = new JObject();
            var mSOutlookCreateMailFolderpropCount = 0;
            if (mSOutlookCreateMailFolderparentFolderPath != null)
            {
                mSOutlookCreateMailFolder["ParentFolderPath"] = ExpressionConverter.ConvertO(mSOutlookCreateMailFolderparentFolderPath);
                mSOutlookCreateMailFolderpropCount++;
            }

            if (mSOutlookCreateMailFoldernewFolderName != null)
            {
                mSOutlookCreateMailFolder["NewFolderName"] = ExpressionConverter.ConvertO(mSOutlookCreateMailFoldernewFolderName);
                mSOutlookCreateMailFolderpropCount++;
            }

            mSOutlookCreateMailFolderpropCount++;
            mSOutlookCreateMailFolder["Workflow"] = ExpressionConverter.ConvertO(mSOutlookCreateMailFolderworkflow);
            if (mSOutlookCreateMailFolderpropCount > 0)
            {
                callPayload.Body = mSOutlookCreateMailFolder;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSOutlookReplyToEmail(Expression<Func<string>> mSOutlookReplyToEmailentryID, Expression<Func<string>> mSOutlookReplyToEmailworkflow, Expression<Func<bool>> mSOutlookReplyToEmailreplyToAll = null, Expression<Func<mSOutlookReplyToEmailbodyFormatInput>> mSOutlookReplyToEmailbodyFormat = null, Expression<Func<string>> mSOutlookReplyToEmailbody = null, Expression<Func<string>> mSOutlookReplyToEmailhTMLBody = null, Expression<Func<string>> mSOutlookReplyToEmailrTFBody = null, Expression<Func<string>> mSOutlookReplyToEmailattachmentFilenamesJSON = null, Expression<Func<bool>> mSOutlookReplyToEmaildontSendIfAttachmentFilenameMissing = null, Expression<Func<bool>> mSOutlookReplyToEmailclickAllowButtonIfRequired = null, Expression<Func<string>> mSOutlookReplyToEmailvotingOptions = null, Expression<Func<string>> mSOutlookReplyToEmailsendAsSMTPAddress = null, Expression<Func<bool>> mSOutlookReplyToEmailbodyContainsStoredPassword = null)
        {
            var apiCallPath = "/MSOutlook/ReplyToEmail";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSOutlookReplyToEmail = new JObject();
            var mSOutlookReplyToEmailpropCount = 0;
            mSOutlookReplyToEmailpropCount++;
            mSOutlookReplyToEmail["EntryID"] = ExpressionConverter.ConvertO(mSOutlookReplyToEmailentryID);
            if (mSOutlookReplyToEmailreplyToAll != null)
            {
                mSOutlookReplyToEmail["ReplyToAll"] = ExpressionConverter.ConvertO(mSOutlookReplyToEmailreplyToAll);
                mSOutlookReplyToEmailpropCount++;
            }

            if (mSOutlookReplyToEmailbodyFormat != null)
            {
                mSOutlookReplyToEmail["BodyFormat"] = ExpressionConverter.ConvertO(mSOutlookReplyToEmailbodyFormat);
                mSOutlookReplyToEmailpropCount++;
            }

            if (mSOutlookReplyToEmailbody != null)
            {
                mSOutlookReplyToEmail["Body"] = ExpressionConverter.ConvertO(mSOutlookReplyToEmailbody);
                mSOutlookReplyToEmailpropCount++;
            }

            if (mSOutlookReplyToEmailhTMLBody != null)
            {
                mSOutlookReplyToEmail["HTMLBody"] = ExpressionConverter.ConvertO(mSOutlookReplyToEmailhTMLBody);
                mSOutlookReplyToEmailpropCount++;
            }

            if (mSOutlookReplyToEmailrTFBody != null)
            {
                mSOutlookReplyToEmail["RTFBody"] = ExpressionConverter.ConvertO(mSOutlookReplyToEmailrTFBody);
                mSOutlookReplyToEmailpropCount++;
            }

            if (mSOutlookReplyToEmailattachmentFilenamesJSON != null)
            {
                mSOutlookReplyToEmail["AttachmentFilenamesJSON"] = ExpressionConverter.ConvertO(mSOutlookReplyToEmailattachmentFilenamesJSON);
                mSOutlookReplyToEmailpropCount++;
            }

            if (mSOutlookReplyToEmaildontSendIfAttachmentFilenameMissing != null)
            {
                mSOutlookReplyToEmail["DontSendIfAttachmentFilenameMissing"] = ExpressionConverter.ConvertO(mSOutlookReplyToEmaildontSendIfAttachmentFilenameMissing);
                mSOutlookReplyToEmailpropCount++;
            }

            if (mSOutlookReplyToEmailclickAllowButtonIfRequired != null)
            {
                mSOutlookReplyToEmail["ClickAllowButtonIfRequired"] = ExpressionConverter.ConvertO(mSOutlookReplyToEmailclickAllowButtonIfRequired);
                mSOutlookReplyToEmailpropCount++;
            }

            if (mSOutlookReplyToEmailvotingOptions != null)
            {
                mSOutlookReplyToEmail["VotingOptions"] = ExpressionConverter.ConvertO(mSOutlookReplyToEmailvotingOptions);
                mSOutlookReplyToEmailpropCount++;
            }

            if (mSOutlookReplyToEmailsendAsSMTPAddress != null)
            {
                mSOutlookReplyToEmail["SendAsSMTPAddress"] = ExpressionConverter.ConvertO(mSOutlookReplyToEmailsendAsSMTPAddress);
                mSOutlookReplyToEmailpropCount++;
            }

            if (mSOutlookReplyToEmailbodyContainsStoredPassword != null)
            {
                mSOutlookReplyToEmail["BodyContainsStoredPassword"] = ExpressionConverter.ConvertO(mSOutlookReplyToEmailbodyContainsStoredPassword);
                mSOutlookReplyToEmailpropCount++;
            }

            mSOutlookReplyToEmailpropCount++;
            mSOutlookReplyToEmail["Workflow"] = ExpressionConverter.ConvertO(mSOutlookReplyToEmailworkflow);
            if (mSOutlookReplyToEmailpropCount > 0)
            {
                callPayload.Body = mSOutlookReplyToEmail;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSOutlookForwardEmail(Expression<Func<string>> mSOutlookForwardEmailentryID, Expression<Func<string>> mSOutlookForwardEmailworkflow, Expression<Func<string>> mSOutlookForwardEmailto = null, Expression<Func<string>> mSOutlookForwardEmailcC = null, Expression<Func<string>> mSOutlookForwardEmailbCC = null, Expression<Func<bool>> mSOutlookForwardEmailoverrideSubject = null, Expression<Func<string>> mSOutlookForwardEmailsubject = null, Expression<Func<bool>> mSOutlookForwardEmailoverrideBody = null, Expression<Func<mSOutlookForwardEmailbodyFormatInput>> mSOutlookForwardEmailbodyFormat = null, Expression<Func<string>> mSOutlookForwardEmailbody = null, Expression<Func<string>> mSOutlookForwardEmailhTMLBody = null, Expression<Func<string>> mSOutlookForwardEmailrTFBody = null, Expression<Func<bool>> mSOutlookForwardEmailclickAllowButtonIfRequired = null, Expression<Func<string>> mSOutlookForwardEmailvotingOptions = null, Expression<Func<string>> mSOutlookForwardEmailsendAsSMTPAddress = null, Expression<Func<bool>> mSOutlookForwardEmailincludeExistingHiddenAttachments = null, Expression<Func<bool>> mSOutlookForwardEmailincludeExistingVisibleAttachments = null, Expression<Func<string>> mSOutlookForwardEmailattachmentFilenamesJSON = null, Expression<Func<bool>> mSOutlookForwardEmaildontSendIfAttachmentFilenameMissing = null, Expression<Func<bool>> mSOutlookForwardEmailbodyContainsStoredPassword = null)
        {
            var apiCallPath = "/MSOutlook/MSOutlookForwardEmail";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSOutlookForwardEmail = new JObject();
            var mSOutlookForwardEmailpropCount = 0;
            mSOutlookForwardEmailpropCount++;
            mSOutlookForwardEmail["EntryID"] = ExpressionConverter.ConvertO(mSOutlookForwardEmailentryID);
            if (mSOutlookForwardEmailto != null)
            {
                mSOutlookForwardEmail["To"] = ExpressionConverter.ConvertO(mSOutlookForwardEmailto);
                mSOutlookForwardEmailpropCount++;
            }

            if (mSOutlookForwardEmailcC != null)
            {
                mSOutlookForwardEmail["CC"] = ExpressionConverter.ConvertO(mSOutlookForwardEmailcC);
                mSOutlookForwardEmailpropCount++;
            }

            if (mSOutlookForwardEmailbCC != null)
            {
                mSOutlookForwardEmail["BCC"] = ExpressionConverter.ConvertO(mSOutlookForwardEmailbCC);
                mSOutlookForwardEmailpropCount++;
            }

            if (mSOutlookForwardEmailoverrideSubject != null)
            {
                mSOutlookForwardEmail["OverrideSubject"] = ExpressionConverter.ConvertO(mSOutlookForwardEmailoverrideSubject);
                mSOutlookForwardEmailpropCount++;
            }

            if (mSOutlookForwardEmailsubject != null)
            {
                mSOutlookForwardEmail["Subject"] = ExpressionConverter.ConvertO(mSOutlookForwardEmailsubject);
                mSOutlookForwardEmailpropCount++;
            }

            if (mSOutlookForwardEmailoverrideBody != null)
            {
                mSOutlookForwardEmail["OverrideBody"] = ExpressionConverter.ConvertO(mSOutlookForwardEmailoverrideBody);
                mSOutlookForwardEmailpropCount++;
            }

            if (mSOutlookForwardEmailbodyFormat != null)
            {
                mSOutlookForwardEmail["BodyFormat"] = ExpressionConverter.ConvertO(mSOutlookForwardEmailbodyFormat);
                mSOutlookForwardEmailpropCount++;
            }

            if (mSOutlookForwardEmailbody != null)
            {
                mSOutlookForwardEmail["Body"] = ExpressionConverter.ConvertO(mSOutlookForwardEmailbody);
                mSOutlookForwardEmailpropCount++;
            }

            if (mSOutlookForwardEmailhTMLBody != null)
            {
                mSOutlookForwardEmail["HTMLBody"] = ExpressionConverter.ConvertO(mSOutlookForwardEmailhTMLBody);
                mSOutlookForwardEmailpropCount++;
            }

            if (mSOutlookForwardEmailrTFBody != null)
            {
                mSOutlookForwardEmail["RTFBody"] = ExpressionConverter.ConvertO(mSOutlookForwardEmailrTFBody);
                mSOutlookForwardEmailpropCount++;
            }

            if (mSOutlookForwardEmailclickAllowButtonIfRequired != null)
            {
                mSOutlookForwardEmail["ClickAllowButtonIfRequired"] = ExpressionConverter.ConvertO(mSOutlookForwardEmailclickAllowButtonIfRequired);
                mSOutlookForwardEmailpropCount++;
            }

            if (mSOutlookForwardEmailvotingOptions != null)
            {
                mSOutlookForwardEmail["VotingOptions"] = ExpressionConverter.ConvertO(mSOutlookForwardEmailvotingOptions);
                mSOutlookForwardEmailpropCount++;
            }

            if (mSOutlookForwardEmailsendAsSMTPAddress != null)
            {
                mSOutlookForwardEmail["SendAsSMTPAddress"] = ExpressionConverter.ConvertO(mSOutlookForwardEmailsendAsSMTPAddress);
                mSOutlookForwardEmailpropCount++;
            }

            if (mSOutlookForwardEmailincludeExistingHiddenAttachments != null)
            {
                mSOutlookForwardEmail["IncludeExistingHiddenAttachments"] = ExpressionConverter.ConvertO(mSOutlookForwardEmailincludeExistingHiddenAttachments);
                mSOutlookForwardEmailpropCount++;
            }

            if (mSOutlookForwardEmailincludeExistingVisibleAttachments != null)
            {
                mSOutlookForwardEmail["IncludeExistingVisibleAttachments"] = ExpressionConverter.ConvertO(mSOutlookForwardEmailincludeExistingVisibleAttachments);
                mSOutlookForwardEmailpropCount++;
            }

            if (mSOutlookForwardEmailattachmentFilenamesJSON != null)
            {
                mSOutlookForwardEmail["AttachmentFilenamesJSON"] = ExpressionConverter.ConvertO(mSOutlookForwardEmailattachmentFilenamesJSON);
                mSOutlookForwardEmailpropCount++;
            }

            if (mSOutlookForwardEmaildontSendIfAttachmentFilenameMissing != null)
            {
                mSOutlookForwardEmail["DontSendIfAttachmentFilenameMissing"] = ExpressionConverter.ConvertO(mSOutlookForwardEmaildontSendIfAttachmentFilenameMissing);
                mSOutlookForwardEmailpropCount++;
            }

            if (mSOutlookForwardEmailbodyContainsStoredPassword != null)
            {
                mSOutlookForwardEmail["BodyContainsStoredPassword"] = ExpressionConverter.ConvertO(mSOutlookForwardEmailbodyContainsStoredPassword);
                mSOutlookForwardEmailpropCount++;
            }

            mSOutlookForwardEmailpropCount++;
            mSOutlookForwardEmail["Workflow"] = ExpressionConverter.ConvertO(mSOutlookForwardEmailworkflow);
            if (mSOutlookForwardEmailpropCount > 0)
            {
                callPayload.Body = mSOutlookForwardEmail;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookGetMAPIProfilesResponse> MSOutlookGetMAPIProfiles(Expression<Func<string>> mSOutlookGetMAPIProfilesworkflow)
        {
            var apiCallPath = "/MSOutlook/GetMAPIProfiles";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSOutlookGetMAPIProfiles = new JObject();
            var mSOutlookGetMAPIProfilespropCount = 0;
            mSOutlookGetMAPIProfilespropCount++;
            mSOutlookGetMAPIProfiles["Workflow"] = ExpressionConverter.ConvertO(mSOutlookGetMAPIProfilesworkflow);
            if (mSOutlookGetMAPIProfilespropCount > 0)
            {
                callPayload.Body = mSOutlookGetMAPIProfiles;
            }

            return new ApiConnectionAction<MSOutlookGetMAPIProfilesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookGetOutlookProcessIdResponse> MSOutlookGetOutlookProcessId(Expression<Func<string>> mSOutlookGetOutlookProcessIdworkflow)
        {
            var apiCallPath = "/MSOutlook/GetOutlookProcessId";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSOutlookGetOutlookProcessId = new JObject();
            var mSOutlookGetOutlookProcessIdpropCount = 0;
            mSOutlookGetOutlookProcessIdpropCount++;
            mSOutlookGetOutlookProcessId["Workflow"] = ExpressionConverter.ConvertO(mSOutlookGetOutlookProcessIdworkflow);
            if (mSOutlookGetOutlookProcessIdpropCount > 0)
            {
                callPayload.Body = mSOutlookGetOutlookProcessId;
            }

            return new ApiConnectionAction<MSOutlookGetOutlookProcessIdResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSOutlookBackgroundMonitorForAllowPopup(Expression<Func<string>> mSOutlookBackgroundMonitorForAllowPopupworkflow, Expression<Func<int>> mSOutlookBackgroundMonitorForAllowPopupsecondsToWaitForDialog = null, Expression<Func<int>> mSOutlookBackgroundMonitorForAllowPopupsecondsToWaitForAllowButton = null, Expression<Func<int>> mSOutlookBackgroundMonitorForAllowPopupsecondsToWaitForAllowButtonToBeEnabled = null, Expression<Func<string>> mSOutlookBackgroundMonitorForAllowPopupoutlookAllowButtonName = null)
        {
            var apiCallPath = "/MSOutlook/BackgroundMonitorForAllowPopup";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSOutlookBackgroundMonitorForAllowPopup = new JObject();
            var mSOutlookBackgroundMonitorForAllowPopuppropCount = 0;
            if (mSOutlookBackgroundMonitorForAllowPopupsecondsToWaitForDialog != null)
            {
                mSOutlookBackgroundMonitorForAllowPopup["SecondsToWaitForDialog"] = ExpressionConverter.ConvertO(mSOutlookBackgroundMonitorForAllowPopupsecondsToWaitForDialog);
                mSOutlookBackgroundMonitorForAllowPopuppropCount++;
            }

            if (mSOutlookBackgroundMonitorForAllowPopupsecondsToWaitForAllowButton != null)
            {
                mSOutlookBackgroundMonitorForAllowPopup["SecondsToWaitForAllowButton"] = ExpressionConverter.ConvertO(mSOutlookBackgroundMonitorForAllowPopupsecondsToWaitForAllowButton);
                mSOutlookBackgroundMonitorForAllowPopuppropCount++;
            }

            if (mSOutlookBackgroundMonitorForAllowPopupsecondsToWaitForAllowButtonToBeEnabled != null)
            {
                mSOutlookBackgroundMonitorForAllowPopup["SecondsToWaitForAllowButtonToBeEnabled"] = ExpressionConverter.ConvertO(mSOutlookBackgroundMonitorForAllowPopupsecondsToWaitForAllowButtonToBeEnabled);
                mSOutlookBackgroundMonitorForAllowPopuppropCount++;
            }

            if (mSOutlookBackgroundMonitorForAllowPopupoutlookAllowButtonName != null)
            {
                mSOutlookBackgroundMonitorForAllowPopup["OutlookAllowButtonName"] = ExpressionConverter.ConvertO(mSOutlookBackgroundMonitorForAllowPopupoutlookAllowButtonName);
                mSOutlookBackgroundMonitorForAllowPopuppropCount++;
            }

            mSOutlookBackgroundMonitorForAllowPopuppropCount++;
            mSOutlookBackgroundMonitorForAllowPopup["Workflow"] = ExpressionConverter.ConvertO(mSOutlookBackgroundMonitorForAllowPopupworkflow);
            if (mSOutlookBackgroundMonitorForAllowPopuppropCount > 0)
            {
                callPayload.Body = mSOutlookBackgroundMonitorForAllowPopup;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSOutlookSetAllowPopupDetails(Expression<Func<string>> mSOutlookSetAllowPopupDetailsworkflow, Expression<Func<string>> mSOutlookSetAllowPopupDetailsoutlookAllowButtonName = null, Expression<Func<string>> mSOutlookSetAllowPopupDetailsoutlookAllowButtonAutomationId = null, Expression<Func<string>> mSOutlookSetAllowPopupDetailsoutlookAllowCheckboxAutomationId = null)
        {
            var apiCallPath = "/MSOutlook/MSOutlookSetAllowPopupDetails";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSOutlookSetAllowPopupDetails = new JObject();
            var mSOutlookSetAllowPopupDetailspropCount = 0;
            if (mSOutlookSetAllowPopupDetailsoutlookAllowButtonName != null)
            {
                mSOutlookSetAllowPopupDetails["OutlookAllowButtonName"] = ExpressionConverter.ConvertO(mSOutlookSetAllowPopupDetailsoutlookAllowButtonName);
                mSOutlookSetAllowPopupDetailspropCount++;
            }

            if (mSOutlookSetAllowPopupDetailsoutlookAllowButtonAutomationId != null)
            {
                mSOutlookSetAllowPopupDetails["OutlookAllowButtonAutomationId"] = ExpressionConverter.ConvertO(mSOutlookSetAllowPopupDetailsoutlookAllowButtonAutomationId);
                mSOutlookSetAllowPopupDetailspropCount++;
            }

            if (mSOutlookSetAllowPopupDetailsoutlookAllowCheckboxAutomationId != null)
            {
                mSOutlookSetAllowPopupDetails["OutlookAllowCheckboxAutomationId"] = ExpressionConverter.ConvertO(mSOutlookSetAllowPopupDetailsoutlookAllowCheckboxAutomationId);
                mSOutlookSetAllowPopupDetailspropCount++;
            }

            mSOutlookSetAllowPopupDetailspropCount++;
            mSOutlookSetAllowPopupDetails["Workflow"] = ExpressionConverter.ConvertO(mSOutlookSetAllowPopupDetailsworkflow);
            if (mSOutlookSetAllowPopupDetailspropCount > 0)
            {
                callPayload.Body = mSOutlookSetAllowPopupDetails;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookExecuteCommandBarObjectResponse> MSOutlookExecuteCommandBarObject(Expression<Func<string>> mSOutlookExecuteCommandBarObjectobjectId, Expression<Func<string>> mSOutlookExecuteCommandBarObjectworkflow, Expression<Func<bool>> mSOutlookExecuteCommandBarObjectrunInBackground = null)
        {
            var apiCallPath = "/MSOutlook/MSOutlookExecuteCommandBarObject";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSOutlookExecuteCommandBarObject = new JObject();
            var mSOutlookExecuteCommandBarObjectpropCount = 0;
            mSOutlookExecuteCommandBarObjectpropCount++;
            mSOutlookExecuteCommandBarObject["ObjectId"] = ExpressionConverter.ConvertO(mSOutlookExecuteCommandBarObjectobjectId);
            if (mSOutlookExecuteCommandBarObjectrunInBackground != null)
            {
                mSOutlookExecuteCommandBarObject["RunInBackground"] = ExpressionConverter.ConvertO(mSOutlookExecuteCommandBarObjectrunInBackground);
                mSOutlookExecuteCommandBarObjectpropCount++;
            }

            mSOutlookExecuteCommandBarObjectpropCount++;
            mSOutlookExecuteCommandBarObject["Workflow"] = ExpressionConverter.ConvertO(mSOutlookExecuteCommandBarObjectworkflow);
            if (mSOutlookExecuteCommandBarObjectpropCount > 0)
            {
                callPayload.Body = mSOutlookExecuteCommandBarObject;
            }

            return new ApiConnectionAction<MSOutlookExecuteCommandBarObjectResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookGetEmailsResponse> MSOutlookGetEmails(Expression<Func<string>> mSOutlookGetEmailsworkflow, Expression<Func<string>> mSOutlookGetEmailsfolderPath = null, Expression<Func<bool>> mSOutlookGetEmailssearchRead = null, Expression<Func<bool>> mSOutlookGetEmailssearchUnread = null, Expression<Func<string>> mSOutlookGetEmailssearchSubject = null, Expression<Func<string>> mSOutlookGetEmailssearchFromSMTP = null, Expression<Func<string>> mSOutlookGetEmailssearchFromName = null, Expression<Func<string>> mSOutlookGetEmailssearchQuery = null, Expression<Func<int>> mSOutlookGetEmailssearchMaxAgeInDays = null, Expression<Func<string>> mSOutlookGetEmailssearchStartDateTimeAsString = null, Expression<Func<string>> mSOutlookGetEmailssearchEndDateTimeAsString = null, Expression<Func<int>> mSOutlookGetEmailsmaxResultsToReturn = null, Expression<Func<bool>> mSOutlookGetEmailsclickAllowButtonIfRequired = null)
        {
            var apiCallPath = "/MSOutlook/GetEmails";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSOutlookGetEmails = new JObject();
            var mSOutlookGetEmailspropCount = 0;
            if (mSOutlookGetEmailsfolderPath != null)
            {
                mSOutlookGetEmails["FolderPath"] = ExpressionConverter.ConvertO(mSOutlookGetEmailsfolderPath);
                mSOutlookGetEmailspropCount++;
            }

            if (mSOutlookGetEmailssearchRead != null)
            {
                mSOutlookGetEmails["SearchRead"] = ExpressionConverter.ConvertO(mSOutlookGetEmailssearchRead);
                mSOutlookGetEmailspropCount++;
            }

            if (mSOutlookGetEmailssearchUnread != null)
            {
                mSOutlookGetEmails["SearchUnread"] = ExpressionConverter.ConvertO(mSOutlookGetEmailssearchUnread);
                mSOutlookGetEmailspropCount++;
            }

            if (mSOutlookGetEmailssearchSubject != null)
            {
                mSOutlookGetEmails["SearchSubject"] = ExpressionConverter.ConvertO(mSOutlookGetEmailssearchSubject);
                mSOutlookGetEmailspropCount++;
            }

            if (mSOutlookGetEmailssearchFromSMTP != null)
            {
                mSOutlookGetEmails["SearchFromSMTP"] = ExpressionConverter.ConvertO(mSOutlookGetEmailssearchFromSMTP);
                mSOutlookGetEmailspropCount++;
            }

            if (mSOutlookGetEmailssearchFromName != null)
            {
                mSOutlookGetEmails["SearchFromName"] = ExpressionConverter.ConvertO(mSOutlookGetEmailssearchFromName);
                mSOutlookGetEmailspropCount++;
            }

            if (mSOutlookGetEmailssearchQuery != null)
            {
                mSOutlookGetEmails["SearchQuery"] = ExpressionConverter.ConvertO(mSOutlookGetEmailssearchQuery);
                mSOutlookGetEmailspropCount++;
            }

            if (mSOutlookGetEmailssearchMaxAgeInDays != null)
            {
                mSOutlookGetEmails["SearchMaxAgeInDays"] = ExpressionConverter.ConvertO(mSOutlookGetEmailssearchMaxAgeInDays);
                mSOutlookGetEmailspropCount++;
            }

            if (mSOutlookGetEmailssearchStartDateTimeAsString != null)
            {
                mSOutlookGetEmails["SearchStartDateTimeAsString"] = ExpressionConverter.ConvertO(mSOutlookGetEmailssearchStartDateTimeAsString);
                mSOutlookGetEmailspropCount++;
            }

            if (mSOutlookGetEmailssearchEndDateTimeAsString != null)
            {
                mSOutlookGetEmails["SearchEndDateTimeAsString"] = ExpressionConverter.ConvertO(mSOutlookGetEmailssearchEndDateTimeAsString);
                mSOutlookGetEmailspropCount++;
            }

            if (mSOutlookGetEmailsmaxResultsToReturn != null)
            {
                mSOutlookGetEmails["MaxResultsToReturn"] = ExpressionConverter.ConvertO(mSOutlookGetEmailsmaxResultsToReturn);
                mSOutlookGetEmailspropCount++;
            }

            if (mSOutlookGetEmailsclickAllowButtonIfRequired != null)
            {
                mSOutlookGetEmails["ClickAllowButtonIfRequired"] = ExpressionConverter.ConvertO(mSOutlookGetEmailsclickAllowButtonIfRequired);
                mSOutlookGetEmailspropCount++;
            }

            mSOutlookGetEmailspropCount++;
            mSOutlookGetEmails["Workflow"] = ExpressionConverter.ConvertO(mSOutlookGetEmailsworkflow);
            if (mSOutlookGetEmailspropCount > 0)
            {
                callPayload.Body = mSOutlookGetEmails;
            }

            return new ApiConnectionAction<MSOutlookGetEmailsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookGetFirstEmailResponse> MSOutlookGetFirstEmail(Expression<Func<string>> mSOutlookGetFirstEmailworkflow, Expression<Func<string>> mSOutlookGetFirstEmailfolderPath = null, Expression<Func<bool>> mSOutlookGetFirstEmailsearchRead = null, Expression<Func<bool>> mSOutlookGetFirstEmailsearchUnread = null, Expression<Func<string>> mSOutlookGetFirstEmailsearchSubject = null, Expression<Func<string>> mSOutlookGetFirstEmailsearchFromSMTP = null, Expression<Func<string>> mSOutlookGetFirstEmailsearchFromName = null, Expression<Func<string>> mSOutlookGetFirstEmailsearchQuery = null, Expression<Func<int>> mSOutlookGetFirstEmailsearchMaxAgeInDays = null, Expression<Func<string>> mSOutlookGetFirstEmailsearchStartDateTimeAsString = null, Expression<Func<string>> mSOutlookGetFirstEmailsearchEndDateTimeAsString = null, Expression<Func<bool>> mSOutlookGetFirstEmailclickAllowButtonIfRequired = null)
        {
            var apiCallPath = "/MSOutlook/GetFirstEmail";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSOutlookGetFirstEmail = new JObject();
            var mSOutlookGetFirstEmailpropCount = 0;
            if (mSOutlookGetFirstEmailfolderPath != null)
            {
                mSOutlookGetFirstEmail["FolderPath"] = ExpressionConverter.ConvertO(mSOutlookGetFirstEmailfolderPath);
                mSOutlookGetFirstEmailpropCount++;
            }

            if (mSOutlookGetFirstEmailsearchRead != null)
            {
                mSOutlookGetFirstEmail["SearchRead"] = ExpressionConverter.ConvertO(mSOutlookGetFirstEmailsearchRead);
                mSOutlookGetFirstEmailpropCount++;
            }

            if (mSOutlookGetFirstEmailsearchUnread != null)
            {
                mSOutlookGetFirstEmail["SearchUnread"] = ExpressionConverter.ConvertO(mSOutlookGetFirstEmailsearchUnread);
                mSOutlookGetFirstEmailpropCount++;
            }

            if (mSOutlookGetFirstEmailsearchSubject != null)
            {
                mSOutlookGetFirstEmail["SearchSubject"] = ExpressionConverter.ConvertO(mSOutlookGetFirstEmailsearchSubject);
                mSOutlookGetFirstEmailpropCount++;
            }

            if (mSOutlookGetFirstEmailsearchFromSMTP != null)
            {
                mSOutlookGetFirstEmail["SearchFromSMTP"] = ExpressionConverter.ConvertO(mSOutlookGetFirstEmailsearchFromSMTP);
                mSOutlookGetFirstEmailpropCount++;
            }

            if (mSOutlookGetFirstEmailsearchFromName != null)
            {
                mSOutlookGetFirstEmail["SearchFromName"] = ExpressionConverter.ConvertO(mSOutlookGetFirstEmailsearchFromName);
                mSOutlookGetFirstEmailpropCount++;
            }

            if (mSOutlookGetFirstEmailsearchQuery != null)
            {
                mSOutlookGetFirstEmail["SearchQuery"] = ExpressionConverter.ConvertO(mSOutlookGetFirstEmailsearchQuery);
                mSOutlookGetFirstEmailpropCount++;
            }

            if (mSOutlookGetFirstEmailsearchMaxAgeInDays != null)
            {
                mSOutlookGetFirstEmail["SearchMaxAgeInDays"] = ExpressionConverter.ConvertO(mSOutlookGetFirstEmailsearchMaxAgeInDays);
                mSOutlookGetFirstEmailpropCount++;
            }

            if (mSOutlookGetFirstEmailsearchStartDateTimeAsString != null)
            {
                mSOutlookGetFirstEmail["SearchStartDateTimeAsString"] = ExpressionConverter.ConvertO(mSOutlookGetFirstEmailsearchStartDateTimeAsString);
                mSOutlookGetFirstEmailpropCount++;
            }

            if (mSOutlookGetFirstEmailsearchEndDateTimeAsString != null)
            {
                mSOutlookGetFirstEmail["SearchEndDateTimeAsString"] = ExpressionConverter.ConvertO(mSOutlookGetFirstEmailsearchEndDateTimeAsString);
                mSOutlookGetFirstEmailpropCount++;
            }

            if (mSOutlookGetFirstEmailclickAllowButtonIfRequired != null)
            {
                mSOutlookGetFirstEmail["ClickAllowButtonIfRequired"] = ExpressionConverter.ConvertO(mSOutlookGetFirstEmailclickAllowButtonIfRequired);
                mSOutlookGetFirstEmailpropCount++;
            }

            mSOutlookGetFirstEmailpropCount++;
            mSOutlookGetFirstEmail["Workflow"] = ExpressionConverter.ConvertO(mSOutlookGetFirstEmailworkflow);
            if (mSOutlookGetFirstEmailpropCount > 0)
            {
                callPayload.Body = mSOutlookGetFirstEmail;
            }

            return new ApiConnectionAction<MSOutlookGetFirstEmailResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookGetNumberOfEmailsResponse> MSOutlookGetNumberOfEmails(Expression<Func<string>> mSOutlookGetNumberOfEmailsworkflow, Expression<Func<string>> mSOutlookGetNumberOfEmailsfolderPath = null, Expression<Func<bool>> mSOutlookGetNumberOfEmailssearchRead = null, Expression<Func<bool>> mSOutlookGetNumberOfEmailssearchUnread = null, Expression<Func<string>> mSOutlookGetNumberOfEmailssearchSubject = null, Expression<Func<string>> mSOutlookGetNumberOfEmailssearchFromSMTP = null, Expression<Func<string>> mSOutlookGetNumberOfEmailssearchFromName = null, Expression<Func<string>> mSOutlookGetNumberOfEmailssearchQuery = null, Expression<Func<int>> mSOutlookGetNumberOfEmailssearchMaxAgeInDays = null, Expression<Func<string>> mSOutlookGetNumberOfEmailssearchStartDateTimeAsString = null, Expression<Func<string>> mSOutlookGetNumberOfEmailssearchEndDateTimeAsString = null)
        {
            var apiCallPath = "/MSOutlook/GetNumberOfEmails";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var mSOutlookGetNumberOfEmails = new JObject();
            var mSOutlookGetNumberOfEmailspropCount = 0;
            if (mSOutlookGetNumberOfEmailsfolderPath != null)
            {
                mSOutlookGetNumberOfEmails["FolderPath"] = ExpressionConverter.ConvertO(mSOutlookGetNumberOfEmailsfolderPath);
                mSOutlookGetNumberOfEmailspropCount++;
            }

            if (mSOutlookGetNumberOfEmailssearchRead != null)
            {
                mSOutlookGetNumberOfEmails["SearchRead"] = ExpressionConverter.ConvertO(mSOutlookGetNumberOfEmailssearchRead);
                mSOutlookGetNumberOfEmailspropCount++;
            }

            if (mSOutlookGetNumberOfEmailssearchUnread != null)
            {
                mSOutlookGetNumberOfEmails["SearchUnread"] = ExpressionConverter.ConvertO(mSOutlookGetNumberOfEmailssearchUnread);
                mSOutlookGetNumberOfEmailspropCount++;
            }

            if (mSOutlookGetNumberOfEmailssearchSubject != null)
            {
                mSOutlookGetNumberOfEmails["SearchSubject"] = ExpressionConverter.ConvertO(mSOutlookGetNumberOfEmailssearchSubject);
                mSOutlookGetNumberOfEmailspropCount++;
            }

            if (mSOutlookGetNumberOfEmailssearchFromSMTP != null)
            {
                mSOutlookGetNumberOfEmails["SearchFromSMTP"] = ExpressionConverter.ConvertO(mSOutlookGetNumberOfEmailssearchFromSMTP);
                mSOutlookGetNumberOfEmailspropCount++;
            }

            if (mSOutlookGetNumberOfEmailssearchFromName != null)
            {
                mSOutlookGetNumberOfEmails["SearchFromName"] = ExpressionConverter.ConvertO(mSOutlookGetNumberOfEmailssearchFromName);
                mSOutlookGetNumberOfEmailspropCount++;
            }

            if (mSOutlookGetNumberOfEmailssearchQuery != null)
            {
                mSOutlookGetNumberOfEmails["SearchQuery"] = ExpressionConverter.ConvertO(mSOutlookGetNumberOfEmailssearchQuery);
                mSOutlookGetNumberOfEmailspropCount++;
            }

            if (mSOutlookGetNumberOfEmailssearchMaxAgeInDays != null)
            {
                mSOutlookGetNumberOfEmails["SearchMaxAgeInDays"] = ExpressionConverter.ConvertO(mSOutlookGetNumberOfEmailssearchMaxAgeInDays);
                mSOutlookGetNumberOfEmailspropCount++;
            }

            if (mSOutlookGetNumberOfEmailssearchStartDateTimeAsString != null)
            {
                mSOutlookGetNumberOfEmails["SearchStartDateTimeAsString"] = ExpressionConverter.ConvertO(mSOutlookGetNumberOfEmailssearchStartDateTimeAsString);
                mSOutlookGetNumberOfEmailspropCount++;
            }

            if (mSOutlookGetNumberOfEmailssearchEndDateTimeAsString != null)
            {
                mSOutlookGetNumberOfEmails["SearchEndDateTimeAsString"] = ExpressionConverter.ConvertO(mSOutlookGetNumberOfEmailssearchEndDateTimeAsString);
                mSOutlookGetNumberOfEmailspropCount++;
            }

            mSOutlookGetNumberOfEmailspropCount++;
            mSOutlookGetNumberOfEmails["Workflow"] = ExpressionConverter.ConvertO(mSOutlookGetNumberOfEmailsworkflow);
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

    public enum mSWordSetDocumentSensitivityLabelassignmentMethodInput
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

    public enum mSExcelFindNextCellWithValuedirectionInput
    {
        U,
        D,
        L,
        R
    }

    public enum mSExcelFindNextCellWithValuecomparisonTypeInput
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

    public enum mSExcelFindNextEmptyCelldirectionInput
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

    public enum mSExcelSaveWorkbookAsexcelFileFormatInput
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

    public enum mSExcelSaveWorkbookAsWithPasswordexcelFileFormatInput
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

    public enum mSExcelSaveCurrentWorkbookAsexcelFileFormatInput
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

    public enum mSExcelInsertOnSelectionshiftInput
    {
        R,
        D
    }

    public enum mSExcelDeleteSelectionshiftInput
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

    public enum mSExcelSetWorksheetSensitivityLabelassignmentMethodInput
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

    public enum mSExcelWriteArraydirectionInput
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

    public enum mSOutlookSendEmailbodyFormatInput
    {
        HTML,
        Plain,
        RTF
    }

    public enum mSOutlookReplyToEmailbodyFormatInput
    {
        HTML,
        Plain,
        RTF
    }

    public enum mSOutlookForwardEmailbodyFormatInput
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