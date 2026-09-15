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
                if (mSWordCreateInstanceshowWord != null)
                {
                    mSWordCreateInstance["ShowWord"] = CSharpExpressionConverter.ConvertToken(mSWordCreateInstanceshowWord);
                    mSWordCreateInstancepropCount++;
                }

                mSWordCreateInstancepropCount++;
            }
            else
            {
                mSWordCreateInstance["ShowWord"] = false;
                mSWordCreateInstancepropCount++;
            }

            mSWordCreateInstancepropCount++;
            mSWordCreateInstance["Workflow"] = CSharpExpressionConverter.ConvertToken(mSWordCreateInstanceworkflow);
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
                if (mSWordCloseInstancehandle != null)
                {
                    mSWordCloseInstance["Handle"] = CSharpExpressionConverter.ConvertToken(mSWordCloseInstancehandle);
                    mSWordCloseInstancepropCount++;
                }

                mSWordCloseInstancepropCount++;
            }
            else
            {
                mSWordCloseInstance["Handle"] = 0;
                mSWordCloseInstancepropCount++;
            }

            mSWordCloseInstancepropCount++;
            mSWordCloseInstance["Workflow"] = CSharpExpressionConverter.ConvertToken(mSWordCloseInstanceworkflow);
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
                if (mSWordDetachFromInstancehandle != null)
                {
                    mSWordDetachFromInstance["Handle"] = CSharpExpressionConverter.ConvertToken(mSWordDetachFromInstancehandle);
                    mSWordDetachFromInstancepropCount++;
                }

                mSWordDetachFromInstancepropCount++;
            }
            else
            {
                mSWordDetachFromInstance["Handle"] = 0;
                mSWordDetachFromInstancepropCount++;
            }

            mSWordDetachFromInstancepropCount++;
            mSWordDetachFromInstance["Workflow"] = CSharpExpressionConverter.ConvertToken(mSWordDetachFromInstanceworkflow);
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
                mSWordAttachToExistingInstance["Filename"] = CSharpExpressionConverter.ConvertToken(mSWordAttachToExistingInstancefilename);
                mSWordAttachToExistingInstancepropCount++;
            }

            if (mSWordAttachToExistingInstancetoggleWindow != null)
            {
                if (mSWordAttachToExistingInstancetoggleWindow != null)
                {
                    mSWordAttachToExistingInstance["ToggleWindow"] = CSharpExpressionConverter.ConvertToken(mSWordAttachToExistingInstancetoggleWindow);
                    mSWordAttachToExistingInstancepropCount++;
                }

                mSWordAttachToExistingInstancepropCount++;
            }
            else
            {
                mSWordAttachToExistingInstance["ToggleWindow"] = true;
                mSWordAttachToExistingInstancepropCount++;
            }

            if (mSWordAttachToExistingInstancetoggleUsesGlobalLeftMouseClickAgent != null)
            {
                if (mSWordAttachToExistingInstancetoggleUsesGlobalLeftMouseClickAgent != null)
                {
                    mSWordAttachToExistingInstance["ToggleUsesGlobalLeftMouseClickAgent"] = CSharpExpressionConverter.ConvertToken(mSWordAttachToExistingInstancetoggleUsesGlobalLeftMouseClickAgent);
                    mSWordAttachToExistingInstancepropCount++;
                }

                mSWordAttachToExistingInstancepropCount++;
            }
            else
            {
                mSWordAttachToExistingInstance["ToggleUsesGlobalLeftMouseClickAgent"] = true;
                mSWordAttachToExistingInstancepropCount++;
            }

            if (mSWordAttachToExistingInstancetoggleDelay != null)
            {
                if (mSWordAttachToExistingInstancetoggleDelay != null)
                {
                    mSWordAttachToExistingInstance["ToggleDelay"] = CSharpExpressionConverter.ConvertToken(mSWordAttachToExistingInstancetoggleDelay);
                    mSWordAttachToExistingInstancepropCount++;
                }

                mSWordAttachToExistingInstancepropCount++;
            }
            else
            {
                mSWordAttachToExistingInstance["ToggleDelay"] = 0.5;
                mSWordAttachToExistingInstancepropCount++;
            }

            mSWordAttachToExistingInstancepropCount++;
            mSWordAttachToExistingInstance["Workflow"] = CSharpExpressionConverter.ConvertToken(mSWordAttachToExistingInstanceworkflow);
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
                if (mSWordShowWordhandle != null)
                {
                    mSWordShowWord["Handle"] = CSharpExpressionConverter.ConvertToken(mSWordShowWordhandle);
                    mSWordShowWordpropCount++;
                }

                mSWordShowWordpropCount++;
            }
            else
            {
                mSWordShowWord["Handle"] = 0;
                mSWordShowWordpropCount++;
            }

            mSWordShowWordpropCount++;
            mSWordShowWord["Workflow"] = CSharpExpressionConverter.ConvertToken(mSWordShowWordworkflow);
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
                if (mSWordHideWordhandle != null)
                {
                    mSWordHideWord["Handle"] = CSharpExpressionConverter.ConvertToken(mSWordHideWordhandle);
                    mSWordHideWordpropCount++;
                }

                mSWordHideWordpropCount++;
            }
            else
            {
                mSWordHideWord["Handle"] = 0;
                mSWordHideWordpropCount++;
            }

            mSWordHideWordpropCount++;
            mSWordHideWord["Workflow"] = CSharpExpressionConverter.ConvertToken(mSWordHideWordworkflow);
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
                if (mSWordCreateDocumenthandle != null)
                {
                    mSWordCreateDocument["Handle"] = CSharpExpressionConverter.ConvertToken(mSWordCreateDocumenthandle);
                    mSWordCreateDocumentpropCount++;
                }

                mSWordCreateDocumentpropCount++;
            }
            else
            {
                mSWordCreateDocument["Handle"] = 0;
                mSWordCreateDocumentpropCount++;
            }

            mSWordCreateDocumentpropCount++;
            mSWordCreateDocument["Workflow"] = CSharpExpressionConverter.ConvertToken(mSWordCreateDocumentworkflow);
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
                if (mSWordOpenDocumenthandle != null)
                {
                    mSWordOpenDocument["Handle"] = CSharpExpressionConverter.ConvertToken(mSWordOpenDocumenthandle);
                    mSWordOpenDocumentpropCount++;
                }

                mSWordOpenDocumentpropCount++;
            }
            else
            {
                mSWordOpenDocument["Handle"] = 0;
                mSWordOpenDocumentpropCount++;
            }

            mSWordOpenDocumentpropCount++;
            mSWordOpenDocument["Filename"] = CSharpExpressionConverter.ConvertToken(mSWordOpenDocumentfilename);
            if (mSWordOpenDocumentopenReadOnly != null)
            {
                if (mSWordOpenDocumentopenReadOnly != null)
                {
                    mSWordOpenDocument["OpenReadOnly"] = CSharpExpressionConverter.ConvertToken(mSWordOpenDocumentopenReadOnly);
                    mSWordOpenDocumentpropCount++;
                }

                mSWordOpenDocumentpropCount++;
            }
            else
            {
                mSWordOpenDocument["OpenReadOnly"] = false;
                mSWordOpenDocumentpropCount++;
            }

            if (mSWordOpenDocumentaddToRecentFiles != null)
            {
                if (mSWordOpenDocumentaddToRecentFiles != null)
                {
                    mSWordOpenDocument["AddToRecentFiles"] = CSharpExpressionConverter.ConvertToken(mSWordOpenDocumentaddToRecentFiles);
                    mSWordOpenDocumentpropCount++;
                }

                mSWordOpenDocumentpropCount++;
            }
            else
            {
                mSWordOpenDocument["AddToRecentFiles"] = false;
                mSWordOpenDocumentpropCount++;
            }

            if (mSWordOpenDocumentpassword != null)
            {
                mSWordOpenDocument["Password"] = CSharpExpressionConverter.ConvertToken(mSWordOpenDocumentpassword);
                mSWordOpenDocumentpropCount++;
            }

            if (mSWordOpenDocumentopenAndRepair != null)
            {
                if (mSWordOpenDocumentopenAndRepair != null)
                {
                    mSWordOpenDocument["OpenAndRepair"] = CSharpExpressionConverter.ConvertToken(mSWordOpenDocumentopenAndRepair);
                    mSWordOpenDocumentpropCount++;
                }

                mSWordOpenDocumentpropCount++;
            }
            else
            {
                mSWordOpenDocument["OpenAndRepair"] = false;
                mSWordOpenDocumentpropCount++;
            }

            mSWordOpenDocumentpropCount++;
            mSWordOpenDocument["Workflow"] = CSharpExpressionConverter.ConvertToken(mSWordOpenDocumentworkflow);
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
                if (mSWordSaveDocumenthandle != null)
                {
                    mSWordSaveDocument["Handle"] = CSharpExpressionConverter.ConvertToken(mSWordSaveDocumenthandle);
                    mSWordSaveDocumentpropCount++;
                }

                mSWordSaveDocumentpropCount++;
            }
            else
            {
                mSWordSaveDocument["Handle"] = 0;
                mSWordSaveDocumentpropCount++;
            }

            if (mSWordSaveDocumentdocumentName != null)
            {
                mSWordSaveDocument["DocumentName"] = CSharpExpressionConverter.ConvertToken(mSWordSaveDocumentdocumentName);
                mSWordSaveDocumentpropCount++;
            }

            mSWordSaveDocumentpropCount++;
            mSWordSaveDocument["Workflow"] = CSharpExpressionConverter.ConvertToken(mSWordSaveDocumentworkflow);
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
                if (mSWordSaveAsDocumenthandle != null)
                {
                    mSWordSaveAsDocument["Handle"] = CSharpExpressionConverter.ConvertToken(mSWordSaveAsDocumenthandle);
                    mSWordSaveAsDocumentpropCount++;
                }

                mSWordSaveAsDocumentpropCount++;
            }
            else
            {
                mSWordSaveAsDocument["Handle"] = 0;
                mSWordSaveAsDocumentpropCount++;
            }

            if (mSWordSaveAsDocumentdocumentName != null)
            {
                mSWordSaveAsDocument["DocumentName"] = CSharpExpressionConverter.ConvertToken(mSWordSaveAsDocumentdocumentName);
                mSWordSaveAsDocumentpropCount++;
            }

            mSWordSaveAsDocumentpropCount++;
            mSWordSaveAsDocument["SaveFilename"] = CSharpExpressionConverter.ConvertToken(mSWordSaveAsDocumentsaveFilename);
            mSWordSaveAsDocumentpropCount++;
            mSWordSaveAsDocument["Workflow"] = CSharpExpressionConverter.ConvertToken(mSWordSaveAsDocumentworkflow);
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
                if (mSWordCloseDocumenthandle != null)
                {
                    mSWordCloseDocument["Handle"] = CSharpExpressionConverter.ConvertToken(mSWordCloseDocumenthandle);
                    mSWordCloseDocumentpropCount++;
                }

                mSWordCloseDocumentpropCount++;
            }
            else
            {
                mSWordCloseDocument["Handle"] = 0;
                mSWordCloseDocumentpropCount++;
            }

            if (mSWordCloseDocumentdocumentName != null)
            {
                mSWordCloseDocument["DocumentName"] = CSharpExpressionConverter.ConvertToken(mSWordCloseDocumentdocumentName);
                mSWordCloseDocumentpropCount++;
            }

            mSWordCloseDocumentpropCount++;
            mSWordCloseDocument["Workflow"] = CSharpExpressionConverter.ConvertToken(mSWordCloseDocumentworkflow);
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
                if (mSWordTypeTexthandle != null)
                {
                    mSWordTypeText["Handle"] = CSharpExpressionConverter.ConvertToken(mSWordTypeTexthandle);
                    mSWordTypeTextpropCount++;
                }

                mSWordTypeTextpropCount++;
            }
            else
            {
                mSWordTypeText["Handle"] = 0;
                mSWordTypeTextpropCount++;
            }

            mSWordTypeTextpropCount++;
            mSWordTypeText["Text"] = CSharpExpressionConverter.ConvertToken(mSWordTypeTexttext);
            mSWordTypeTextpropCount++;
            mSWordTypeText["Workflow"] = CSharpExpressionConverter.ConvertToken(mSWordTypeTextworkflow);
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
                if (mSWordSelectAllhandle != null)
                {
                    mSWordSelectAll["Handle"] = CSharpExpressionConverter.ConvertToken(mSWordSelectAllhandle);
                    mSWordSelectAllpropCount++;
                }

                mSWordSelectAllpropCount++;
            }
            else
            {
                mSWordSelectAll["Handle"] = 0;
                mSWordSelectAllpropCount++;
            }

            if (mSWordSelectAlldocumentName != null)
            {
                mSWordSelectAll["DocumentName"] = CSharpExpressionConverter.ConvertToken(mSWordSelectAlldocumentName);
                mSWordSelectAllpropCount++;
            }

            mSWordSelectAllpropCount++;
            mSWordSelectAll["Workflow"] = CSharpExpressionConverter.ConvertToken(mSWordSelectAllworkflow);
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
                if (mSWordSelectRangehandle != null)
                {
                    mSWordSelectRange["Handle"] = CSharpExpressionConverter.ConvertToken(mSWordSelectRangehandle);
                    mSWordSelectRangepropCount++;
                }

                mSWordSelectRangepropCount++;
            }
            else
            {
                mSWordSelectRange["Handle"] = 0;
                mSWordSelectRangepropCount++;
            }

            if (mSWordSelectRangedocumentName != null)
            {
                mSWordSelectRange["DocumentName"] = CSharpExpressionConverter.ConvertToken(mSWordSelectRangedocumentName);
                mSWordSelectRangepropCount++;
            }

            mSWordSelectRangepropCount++;
            mSWordSelectRange["Start"] = CSharpExpressionConverter.ConvertToken(mSWordSelectRangestart);
            mSWordSelectRangepropCount++;
            mSWordSelectRange["Finish"] = CSharpExpressionConverter.ConvertToken(mSWordSelectRangefinish);
            mSWordSelectRangepropCount++;
            mSWordSelectRange["Workflow"] = CSharpExpressionConverter.ConvertToken(mSWordSelectRangeworkflow);
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
                if (mSWordCopyToClipboardhandle != null)
                {
                    mSWordCopyToClipboard["Handle"] = CSharpExpressionConverter.ConvertToken(mSWordCopyToClipboardhandle);
                    mSWordCopyToClipboardpropCount++;
                }

                mSWordCopyToClipboardpropCount++;
            }
            else
            {
                mSWordCopyToClipboard["Handle"] = 0;
                mSWordCopyToClipboardpropCount++;
            }

            mSWordCopyToClipboardpropCount++;
            mSWordCopyToClipboard["Workflow"] = CSharpExpressionConverter.ConvertToken(mSWordCopyToClipboardworkflow);
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
                if (mSWordPasteFromClipboardhandle != null)
                {
                    mSWordPasteFromClipboard["Handle"] = CSharpExpressionConverter.ConvertToken(mSWordPasteFromClipboardhandle);
                    mSWordPasteFromClipboardpropCount++;
                }

                mSWordPasteFromClipboardpropCount++;
            }
            else
            {
                mSWordPasteFromClipboard["Handle"] = 0;
                mSWordPasteFromClipboardpropCount++;
            }

            mSWordPasteFromClipboardpropCount++;
            mSWordPasteFromClipboard["Workflow"] = CSharpExpressionConverter.ConvertToken(mSWordPasteFromClipboardworkflow);
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
            mSWordClearClipboard["Workflow"] = CSharpExpressionConverter.ConvertToken(mSWordClearClipboardworkflow);
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
                if (mSWordGetDocumentBodyTexthandle != null)
                {
                    mSWordGetDocumentBodyText["Handle"] = CSharpExpressionConverter.ConvertToken(mSWordGetDocumentBodyTexthandle);
                    mSWordGetDocumentBodyTextpropCount++;
                }

                mSWordGetDocumentBodyTextpropCount++;
            }
            else
            {
                mSWordGetDocumentBodyText["Handle"] = 0;
                mSWordGetDocumentBodyTextpropCount++;
            }

            if (mSWordGetDocumentBodyTextdocumentName != null)
            {
                mSWordGetDocumentBodyText["DocumentName"] = CSharpExpressionConverter.ConvertToken(mSWordGetDocumentBodyTextdocumentName);
                mSWordGetDocumentBodyTextpropCount++;
            }

            mSWordGetDocumentBodyTextpropCount++;
            mSWordGetDocumentBodyText["Start"] = CSharpExpressionConverter.ConvertToken(mSWordGetDocumentBodyTextstart);
            mSWordGetDocumentBodyTextpropCount++;
            mSWordGetDocumentBodyText["Finish"] = CSharpExpressionConverter.ConvertToken(mSWordGetDocumentBodyTextfinish);
            mSWordGetDocumentBodyTextpropCount++;
            mSWordGetDocumentBodyText["Workflow"] = CSharpExpressionConverter.ConvertToken(mSWordGetDocumentBodyTextworkflow);
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
                if (mSWordGetNumberOfTablesInDocumenthandle != null)
                {
                    mSWordGetNumberOfTablesInDocument["Handle"] = CSharpExpressionConverter.ConvertToken(mSWordGetNumberOfTablesInDocumenthandle);
                    mSWordGetNumberOfTablesInDocumentpropCount++;
                }

                mSWordGetNumberOfTablesInDocumentpropCount++;
            }
            else
            {
                mSWordGetNumberOfTablesInDocument["Handle"] = 0;
                mSWordGetNumberOfTablesInDocumentpropCount++;
            }

            if (mSWordGetNumberOfTablesInDocumentdocumentName != null)
            {
                mSWordGetNumberOfTablesInDocument["DocumentName"] = CSharpExpressionConverter.ConvertToken(mSWordGetNumberOfTablesInDocumentdocumentName);
                mSWordGetNumberOfTablesInDocumentpropCount++;
            }

            mSWordGetNumberOfTablesInDocumentpropCount++;
            mSWordGetNumberOfTablesInDocument["Workflow"] = CSharpExpressionConverter.ConvertToken(mSWordGetNumberOfTablesInDocumentworkflow);
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
                if (mSWordUpdateBookmarkhandle != null)
                {
                    mSWordUpdateBookmark["Handle"] = CSharpExpressionConverter.ConvertToken(mSWordUpdateBookmarkhandle);
                    mSWordUpdateBookmarkpropCount++;
                }

                mSWordUpdateBookmarkpropCount++;
            }
            else
            {
                mSWordUpdateBookmark["Handle"] = 0;
                mSWordUpdateBookmarkpropCount++;
            }

            if (mSWordUpdateBookmarkdocumentName != null)
            {
                mSWordUpdateBookmark["DocumentName"] = CSharpExpressionConverter.ConvertToken(mSWordUpdateBookmarkdocumentName);
                mSWordUpdateBookmarkpropCount++;
            }

            mSWordUpdateBookmarkpropCount++;
            mSWordUpdateBookmark["BookmarkName"] = CSharpExpressionConverter.ConvertToken(mSWordUpdateBookmarkbookmarkName);
            if (mSWordUpdateBookmarknewValue != null)
            {
                mSWordUpdateBookmark["NewValue"] = CSharpExpressionConverter.ConvertToken(mSWordUpdateBookmarknewValue);
                mSWordUpdateBookmarkpropCount++;
            }

            mSWordUpdateBookmarkpropCount++;
            mSWordUpdateBookmark["Workflow"] = CSharpExpressionConverter.ConvertToken(mSWordUpdateBookmarkworkflow);
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
                if (mSWordSelectTablehandle != null)
                {
                    mSWordSelectTable["Handle"] = CSharpExpressionConverter.ConvertToken(mSWordSelectTablehandle);
                    mSWordSelectTablepropCount++;
                }

                mSWordSelectTablepropCount++;
            }
            else
            {
                mSWordSelectTable["Handle"] = 0;
                mSWordSelectTablepropCount++;
            }

            if (mSWordSelectTabledocumentName != null)
            {
                mSWordSelectTable["DocumentName"] = CSharpExpressionConverter.ConvertToken(mSWordSelectTabledocumentName);
                mSWordSelectTablepropCount++;
            }

            mSWordSelectTablepropCount++;
            mSWordSelectTable["TableIndex"] = CSharpExpressionConverter.ConvertToken(mSWordSelectTabletableIndex);
            mSWordSelectTablepropCount++;
            mSWordSelectTable["Workflow"] = CSharpExpressionConverter.ConvertToken(mSWordSelectTableworkflow);
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
                if (mSWordGetTableBoundshandle != null)
                {
                    mSWordGetTableBounds["Handle"] = CSharpExpressionConverter.ConvertToken(mSWordGetTableBoundshandle);
                    mSWordGetTableBoundspropCount++;
                }

                mSWordGetTableBoundspropCount++;
            }
            else
            {
                mSWordGetTableBounds["Handle"] = 0;
                mSWordGetTableBoundspropCount++;
            }

            if (mSWordGetTableBoundsdocumentName != null)
            {
                mSWordGetTableBounds["DocumentName"] = CSharpExpressionConverter.ConvertToken(mSWordGetTableBoundsdocumentName);
                mSWordGetTableBoundspropCount++;
            }

            mSWordGetTableBoundspropCount++;
            mSWordGetTableBounds["TableIndex"] = CSharpExpressionConverter.ConvertToken(mSWordGetTableBoundstableIndex);
            mSWordGetTableBoundspropCount++;
            mSWordGetTableBounds["Workflow"] = CSharpExpressionConverter.ConvertToken(mSWordGetTableBoundsworkflow);
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
                if (mSWordSelectTableCellhandle != null)
                {
                    mSWordSelectTableCell["Handle"] = CSharpExpressionConverter.ConvertToken(mSWordSelectTableCellhandle);
                    mSWordSelectTableCellpropCount++;
                }

                mSWordSelectTableCellpropCount++;
            }
            else
            {
                mSWordSelectTableCell["Handle"] = 0;
                mSWordSelectTableCellpropCount++;
            }

            if (mSWordSelectTableCelldocumentName != null)
            {
                mSWordSelectTableCell["DocumentName"] = CSharpExpressionConverter.ConvertToken(mSWordSelectTableCelldocumentName);
                mSWordSelectTableCellpropCount++;
            }

            mSWordSelectTableCellpropCount++;
            mSWordSelectTableCell["TableIndex"] = CSharpExpressionConverter.ConvertToken(mSWordSelectTableCelltableIndex);
            mSWordSelectTableCellpropCount++;
            mSWordSelectTableCell["RowIndex"] = CSharpExpressionConverter.ConvertToken(mSWordSelectTableCellrowIndex);
            mSWordSelectTableCellpropCount++;
            mSWordSelectTableCell["ColumnIndex"] = CSharpExpressionConverter.ConvertToken(mSWordSelectTableCellcolumnIndex);
            mSWordSelectTableCellpropCount++;
            mSWordSelectTableCell["Workflow"] = CSharpExpressionConverter.ConvertToken(mSWordSelectTableCellworkflow);
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
                if (mSWordGetTableCellTextValuehandle != null)
                {
                    mSWordGetTableCellTextValue["Handle"] = CSharpExpressionConverter.ConvertToken(mSWordGetTableCellTextValuehandle);
                    mSWordGetTableCellTextValuepropCount++;
                }

                mSWordGetTableCellTextValuepropCount++;
            }
            else
            {
                mSWordGetTableCellTextValue["Handle"] = 0;
                mSWordGetTableCellTextValuepropCount++;
            }

            if (mSWordGetTableCellTextValuedocumentName != null)
            {
                mSWordGetTableCellTextValue["DocumentName"] = CSharpExpressionConverter.ConvertToken(mSWordGetTableCellTextValuedocumentName);
                mSWordGetTableCellTextValuepropCount++;
            }

            mSWordGetTableCellTextValuepropCount++;
            mSWordGetTableCellTextValue["TableIndex"] = CSharpExpressionConverter.ConvertToken(mSWordGetTableCellTextValuetableIndex);
            mSWordGetTableCellTextValuepropCount++;
            mSWordGetTableCellTextValue["RowIndex"] = CSharpExpressionConverter.ConvertToken(mSWordGetTableCellTextValuerowIndex);
            mSWordGetTableCellTextValuepropCount++;
            mSWordGetTableCellTextValue["ColumnIndex"] = CSharpExpressionConverter.ConvertToken(mSWordGetTableCellTextValuecolumnIndex);
            mSWordGetTableCellTextValuepropCount++;
            mSWordGetTableCellTextValue["Workflow"] = CSharpExpressionConverter.ConvertToken(mSWordGetTableCellTextValueworkflow);
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
                if (mSWordGetTableCellTextValueTrimmedhandle != null)
                {
                    mSWordGetTableCellTextValueTrimmed["Handle"] = CSharpExpressionConverter.ConvertToken(mSWordGetTableCellTextValueTrimmedhandle);
                    mSWordGetTableCellTextValueTrimmedpropCount++;
                }

                mSWordGetTableCellTextValueTrimmedpropCount++;
            }
            else
            {
                mSWordGetTableCellTextValueTrimmed["Handle"] = 0;
                mSWordGetTableCellTextValueTrimmedpropCount++;
            }

            if (mSWordGetTableCellTextValueTrimmeddocumentName != null)
            {
                mSWordGetTableCellTextValueTrimmed["DocumentName"] = CSharpExpressionConverter.ConvertToken(mSWordGetTableCellTextValueTrimmeddocumentName);
                mSWordGetTableCellTextValueTrimmedpropCount++;
            }

            mSWordGetTableCellTextValueTrimmedpropCount++;
            mSWordGetTableCellTextValueTrimmed["TableIndex"] = CSharpExpressionConverter.ConvertToken(mSWordGetTableCellTextValueTrimmedtableIndex);
            mSWordGetTableCellTextValueTrimmedpropCount++;
            mSWordGetTableCellTextValueTrimmed["RowIndex"] = CSharpExpressionConverter.ConvertToken(mSWordGetTableCellTextValueTrimmedrowIndex);
            mSWordGetTableCellTextValueTrimmedpropCount++;
            mSWordGetTableCellTextValueTrimmed["ColumnIndex"] = CSharpExpressionConverter.ConvertToken(mSWordGetTableCellTextValueTrimmedcolumnIndex);
            mSWordGetTableCellTextValueTrimmedpropCount++;
            mSWordGetTableCellTextValueTrimmed["Workflow"] = CSharpExpressionConverter.ConvertToken(mSWordGetTableCellTextValueTrimmedworkflow);
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
                if (mSWordSetTableCellTextValuehandle != null)
                {
                    mSWordSetTableCellTextValue["Handle"] = CSharpExpressionConverter.ConvertToken(mSWordSetTableCellTextValuehandle);
                    mSWordSetTableCellTextValuepropCount++;
                }

                mSWordSetTableCellTextValuepropCount++;
            }
            else
            {
                mSWordSetTableCellTextValue["Handle"] = 0;
                mSWordSetTableCellTextValuepropCount++;
            }

            if (mSWordSetTableCellTextValuedocumentName != null)
            {
                mSWordSetTableCellTextValue["DocumentName"] = CSharpExpressionConverter.ConvertToken(mSWordSetTableCellTextValuedocumentName);
                mSWordSetTableCellTextValuepropCount++;
            }

            mSWordSetTableCellTextValuepropCount++;
            mSWordSetTableCellTextValue["TableIndex"] = CSharpExpressionConverter.ConvertToken(mSWordSetTableCellTextValuetableIndex);
            mSWordSetTableCellTextValuepropCount++;
            mSWordSetTableCellTextValue["RowIndex"] = CSharpExpressionConverter.ConvertToken(mSWordSetTableCellTextValuerowIndex);
            mSWordSetTableCellTextValuepropCount++;
            mSWordSetTableCellTextValue["ColumnIndex"] = CSharpExpressionConverter.ConvertToken(mSWordSetTableCellTextValuecolumnIndex);
            if (mSWordSetTableCellTextValuenewCellText != null)
            {
                mSWordSetTableCellTextValue["NewCellText"] = CSharpExpressionConverter.ConvertToken(mSWordSetTableCellTextValuenewCellText);
                mSWordSetTableCellTextValuepropCount++;
            }

            mSWordSetTableCellTextValuepropCount++;
            mSWordSetTableCellTextValue["Workflow"] = CSharpExpressionConverter.ConvertToken(mSWordSetTableCellTextValueworkflow);
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
                if (mSWordExportDocumentAsPDFhandle != null)
                {
                    mSWordExportDocumentAsPDF["Handle"] = CSharpExpressionConverter.ConvertToken(mSWordExportDocumentAsPDFhandle);
                    mSWordExportDocumentAsPDFpropCount++;
                }

                mSWordExportDocumentAsPDFpropCount++;
            }
            else
            {
                mSWordExportDocumentAsPDF["Handle"] = 0;
                mSWordExportDocumentAsPDFpropCount++;
            }

            if (mSWordExportDocumentAsPDFdocumentName != null)
            {
                mSWordExportDocumentAsPDF["DocumentName"] = CSharpExpressionConverter.ConvertToken(mSWordExportDocumentAsPDFdocumentName);
                mSWordExportDocumentAsPDFpropCount++;
            }

            mSWordExportDocumentAsPDFpropCount++;
            mSWordExportDocumentAsPDF["SaveFileName"] = CSharpExpressionConverter.ConvertToken(mSWordExportDocumentAsPDFsaveFileName);
            mSWordExportDocumentAsPDFpropCount++;
            mSWordExportDocumentAsPDF["Workflow"] = CSharpExpressionConverter.ConvertToken(mSWordExportDocumentAsPDFworkflow);
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
                if (mSWordAddTablehandle != null)
                {
                    mSWordAddTable["Handle"] = CSharpExpressionConverter.ConvertToken(mSWordAddTablehandle);
                    mSWordAddTablepropCount++;
                }

                mSWordAddTablepropCount++;
            }
            else
            {
                mSWordAddTable["Handle"] = 0;
                mSWordAddTablepropCount++;
            }

            if (mSWordAddTabledocumentName != null)
            {
                mSWordAddTable["DocumentName"] = CSharpExpressionConverter.ConvertToken(mSWordAddTabledocumentName);
                mSWordAddTablepropCount++;
            }

            mSWordAddTablepropCount++;
            mSWordAddTable["NumberOfRows"] = CSharpExpressionConverter.ConvertToken(mSWordAddTablenumberOfRows);
            mSWordAddTablepropCount++;
            mSWordAddTable["NumberOfColumns"] = CSharpExpressionConverter.ConvertToken(mSWordAddTablenumberOfColumns);
            if (mSWordAddTableautoFitBehaviour != null)
            {
                if (mSWordAddTableautoFitBehaviour != null)
                {
                    mSWordAddTable["AutoFitBehaviour"] = CSharpExpressionConverter.ConvertToken(mSWordAddTableautoFitBehaviour);
                    mSWordAddTablepropCount++;
                }

                mSWordAddTablepropCount++;
            }
            else
            {
                mSWordAddTable["AutoFitBehaviour"] = 2;
                mSWordAddTablepropCount++;
            }

            mSWordAddTablepropCount++;
            mSWordAddTable["Workflow"] = CSharpExpressionConverter.ConvertToken(mSWordAddTableworkflow);
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
                if (mSWordAddTableRowhandle != null)
                {
                    mSWordAddTableRow["Handle"] = CSharpExpressionConverter.ConvertToken(mSWordAddTableRowhandle);
                    mSWordAddTableRowpropCount++;
                }

                mSWordAddTableRowpropCount++;
            }
            else
            {
                mSWordAddTableRow["Handle"] = 0;
                mSWordAddTableRowpropCount++;
            }

            if (mSWordAddTableRowdocumentName != null)
            {
                mSWordAddTableRow["DocumentName"] = CSharpExpressionConverter.ConvertToken(mSWordAddTableRowdocumentName);
                mSWordAddTableRowpropCount++;
            }

            mSWordAddTableRowpropCount++;
            mSWordAddTableRow["TableIndex"] = CSharpExpressionConverter.ConvertToken(mSWordAddTableRowtableIndex);
            mSWordAddTableRowpropCount++;
            mSWordAddTableRow["Workflow"] = CSharpExpressionConverter.ConvertToken(mSWordAddTableRowworkflow);
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
                if (mSWordAddTableColumnhandle != null)
                {
                    mSWordAddTableColumn["Handle"] = CSharpExpressionConverter.ConvertToken(mSWordAddTableColumnhandle);
                    mSWordAddTableColumnpropCount++;
                }

                mSWordAddTableColumnpropCount++;
            }
            else
            {
                mSWordAddTableColumn["Handle"] = 0;
                mSWordAddTableColumnpropCount++;
            }

            if (mSWordAddTableColumndocumentName != null)
            {
                mSWordAddTableColumn["DocumentName"] = CSharpExpressionConverter.ConvertToken(mSWordAddTableColumndocumentName);
                mSWordAddTableColumnpropCount++;
            }

            mSWordAddTableColumnpropCount++;
            mSWordAddTableColumn["TableIndex"] = CSharpExpressionConverter.ConvertToken(mSWordAddTableColumntableIndex);
            mSWordAddTableColumnpropCount++;
            mSWordAddTableColumn["Workflow"] = CSharpExpressionConverter.ConvertToken(mSWordAddTableColumnworkflow);
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
                if (mSWordGetHighlightedTexthandle != null)
                {
                    mSWordGetHighlightedText["Handle"] = CSharpExpressionConverter.ConvertToken(mSWordGetHighlightedTexthandle);
                    mSWordGetHighlightedTextpropCount++;
                }

                mSWordGetHighlightedTextpropCount++;
            }
            else
            {
                mSWordGetHighlightedText["Handle"] = 0;
                mSWordGetHighlightedTextpropCount++;
            }

            if (mSWordGetHighlightedTextdocumentName != null)
            {
                mSWordGetHighlightedText["DocumentName"] = CSharpExpressionConverter.ConvertToken(mSWordGetHighlightedTextdocumentName);
                mSWordGetHighlightedTextpropCount++;
            }

            mSWordGetHighlightedTextpropCount++;
            mSWordGetHighlightedText["Workflow"] = CSharpExpressionConverter.ConvertToken(mSWordGetHighlightedTextworkflow);
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
                if (mSWordExecuteCommandBarObjecthandle != null)
                {
                    mSWordExecuteCommandBarObject["Handle"] = CSharpExpressionConverter.ConvertToken(mSWordExecuteCommandBarObjecthandle);
                    mSWordExecuteCommandBarObjectpropCount++;
                }

                mSWordExecuteCommandBarObjectpropCount++;
            }
            else
            {
                mSWordExecuteCommandBarObject["Handle"] = 0;
                mSWordExecuteCommandBarObjectpropCount++;
            }

            mSWordExecuteCommandBarObjectpropCount++;
            mSWordExecuteCommandBarObject["ObjectId"] = CSharpExpressionConverter.ConvertToken(mSWordExecuteCommandBarObjectobjectId);
            if (mSWordExecuteCommandBarObjectrunInBackground != null)
            {
                if (mSWordExecuteCommandBarObjectrunInBackground != null)
                {
                    mSWordExecuteCommandBarObject["RunInBackground"] = CSharpExpressionConverter.ConvertToken(mSWordExecuteCommandBarObjectrunInBackground);
                    mSWordExecuteCommandBarObjectpropCount++;
                }

                mSWordExecuteCommandBarObjectpropCount++;
            }
            else
            {
                mSWordExecuteCommandBarObject["RunInBackground"] = false;
                mSWordExecuteCommandBarObjectpropCount++;
            }

            mSWordExecuteCommandBarObjectpropCount++;
            mSWordExecuteCommandBarObject["Workflow"] = CSharpExpressionConverter.ConvertToken(mSWordExecuteCommandBarObjectworkflow);
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
                if (mSWordSetDocumentSensitivityLabelhandle != null)
                {
                    mSWordSetDocumentSensitivityLabel["Handle"] = CSharpExpressionConverter.ConvertToken(mSWordSetDocumentSensitivityLabelhandle);
                    mSWordSetDocumentSensitivityLabelpropCount++;
                }

                mSWordSetDocumentSensitivityLabelpropCount++;
            }
            else
            {
                mSWordSetDocumentSensitivityLabel["Handle"] = 0;
                mSWordSetDocumentSensitivityLabelpropCount++;
            }

            if (mSWordSetDocumentSensitivityLabeldocumentName != null)
            {
                mSWordSetDocumentSensitivityLabel["DocumentName"] = CSharpExpressionConverter.ConvertToken(mSWordSetDocumentSensitivityLabeldocumentName);
                mSWordSetDocumentSensitivityLabelpropCount++;
            }

            mSWordSetDocumentSensitivityLabelpropCount++;
            mSWordSetDocumentSensitivityLabel["AssignmentMethod"] = CSharpExpressionConverter.Convert(mSWordSetDocumentSensitivityLabelassignmentMethod);
            mSWordSetDocumentSensitivityLabelpropCount++;
            mSWordSetDocumentSensitivityLabel["LabelId"] = CSharpExpressionConverter.ConvertToken(mSWordSetDocumentSensitivityLabellabelId);
            if (mSWordSetDocumentSensitivityLabellabelName != null)
            {
                mSWordSetDocumentSensitivityLabel["LabelName"] = CSharpExpressionConverter.ConvertToken(mSWordSetDocumentSensitivityLabellabelName);
                mSWordSetDocumentSensitivityLabelpropCount++;
            }

            if (mSWordSetDocumentSensitivityLabelsiteId != null)
            {
                mSWordSetDocumentSensitivityLabel["SiteId"] = CSharpExpressionConverter.ConvertToken(mSWordSetDocumentSensitivityLabelsiteId);
                mSWordSetDocumentSensitivityLabelpropCount++;
            }

            if (mSWordSetDocumentSensitivityLabeljustification != null)
            {
                mSWordSetDocumentSensitivityLabel["Justification"] = CSharpExpressionConverter.ConvertToken(mSWordSetDocumentSensitivityLabeljustification);
                mSWordSetDocumentSensitivityLabelpropCount++;
            }

            mSWordSetDocumentSensitivityLabelpropCount++;
            mSWordSetDocumentSensitivityLabel["Workflow"] = CSharpExpressionConverter.ConvertToken(mSWordSetDocumentSensitivityLabelworkflow);
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
                if (mSWordGetDocumentSensitivityLabelhandle != null)
                {
                    mSWordGetDocumentSensitivityLabel["Handle"] = CSharpExpressionConverter.ConvertToken(mSWordGetDocumentSensitivityLabelhandle);
                    mSWordGetDocumentSensitivityLabelpropCount++;
                }

                mSWordGetDocumentSensitivityLabelpropCount++;
            }
            else
            {
                mSWordGetDocumentSensitivityLabel["Handle"] = 0;
                mSWordGetDocumentSensitivityLabelpropCount++;
            }

            if (mSWordGetDocumentSensitivityLabeldocumentName != null)
            {
                mSWordGetDocumentSensitivityLabel["DocumentName"] = CSharpExpressionConverter.ConvertToken(mSWordGetDocumentSensitivityLabeldocumentName);
                mSWordGetDocumentSensitivityLabelpropCount++;
            }

            mSWordGetDocumentSensitivityLabelpropCount++;
            mSWordGetDocumentSensitivityLabel["Workflow"] = CSharpExpressionConverter.ConvertToken(mSWordGetDocumentSensitivityLabelworkflow);
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
                if (mSExcelCreateInstanceenableEvents != null)
                {
                    mSExcelCreateInstance["EnableEvents"] = CSharpExpressionConverter.ConvertToken(mSExcelCreateInstanceenableEvents);
                    mSExcelCreateInstancepropCount++;
                }

                mSExcelCreateInstancepropCount++;
            }
            else
            {
                mSExcelCreateInstance["EnableEvents"] = true;
                mSExcelCreateInstancepropCount++;
            }

            if (mSExcelCreateInstanceshowExcel != null)
            {
                if (mSExcelCreateInstanceshowExcel != null)
                {
                    mSExcelCreateInstance["ShowExcel"] = CSharpExpressionConverter.ConvertToken(mSExcelCreateInstanceshowExcel);
                    mSExcelCreateInstancepropCount++;
                }

                mSExcelCreateInstancepropCount++;
            }
            else
            {
                mSExcelCreateInstance["ShowExcel"] = false;
                mSExcelCreateInstancepropCount++;
            }

            mSExcelCreateInstancepropCount++;
            mSExcelCreateInstance["Workflow"] = CSharpExpressionConverter.ConvertToken(mSExcelCreateInstanceworkflow);
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
                if (mSExcelCloseInstancehandle != null)
                {
                    mSExcelCloseInstance["Handle"] = CSharpExpressionConverter.ConvertToken(mSExcelCloseInstancehandle);
                    mSExcelCloseInstancepropCount++;
                }

                mSExcelCloseInstancepropCount++;
            }
            else
            {
                mSExcelCloseInstance["Handle"] = 0;
                mSExcelCloseInstancepropCount++;
            }

            mSExcelCloseInstancepropCount++;
            mSExcelCloseInstance["Workflow"] = CSharpExpressionConverter.ConvertToken(mSExcelCloseInstanceworkflow);
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
                mSExcelAttachToExistingInstance["Filename"] = CSharpExpressionConverter.ConvertToken(mSExcelAttachToExistingInstancefilename);
                mSExcelAttachToExistingInstancepropCount++;
            }

            if (mSExcelAttachToExistingInstancetoggleWindow != null)
            {
                if (mSExcelAttachToExistingInstancetoggleWindow != null)
                {
                    mSExcelAttachToExistingInstance["ToggleWindow"] = CSharpExpressionConverter.ConvertToken(mSExcelAttachToExistingInstancetoggleWindow);
                    mSExcelAttachToExistingInstancepropCount++;
                }

                mSExcelAttachToExistingInstancepropCount++;
            }
            else
            {
                mSExcelAttachToExistingInstance["ToggleWindow"] = true;
                mSExcelAttachToExistingInstancepropCount++;
            }

            if (mSExcelAttachToExistingInstancetoggleUsesGlobalLeftMouseClickAgent != null)
            {
                if (mSExcelAttachToExistingInstancetoggleUsesGlobalLeftMouseClickAgent != null)
                {
                    mSExcelAttachToExistingInstance["ToggleUsesGlobalLeftMouseClickAgent"] = CSharpExpressionConverter.ConvertToken(mSExcelAttachToExistingInstancetoggleUsesGlobalLeftMouseClickAgent);
                    mSExcelAttachToExistingInstancepropCount++;
                }

                mSExcelAttachToExistingInstancepropCount++;
            }
            else
            {
                mSExcelAttachToExistingInstance["ToggleUsesGlobalLeftMouseClickAgent"] = true;
                mSExcelAttachToExistingInstancepropCount++;
            }

            if (mSExcelAttachToExistingInstancetoggleDelay != null)
            {
                if (mSExcelAttachToExistingInstancetoggleDelay != null)
                {
                    mSExcelAttachToExistingInstance["ToggleDelay"] = CSharpExpressionConverter.ConvertToken(mSExcelAttachToExistingInstancetoggleDelay);
                    mSExcelAttachToExistingInstancepropCount++;
                }

                mSExcelAttachToExistingInstancepropCount++;
            }
            else
            {
                mSExcelAttachToExistingInstance["ToggleDelay"] = 0.5;
                mSExcelAttachToExistingInstancepropCount++;
            }

            mSExcelAttachToExistingInstancepropCount++;
            mSExcelAttachToExistingInstance["Workflow"] = CSharpExpressionConverter.ConvertToken(mSExcelAttachToExistingInstanceworkflow);
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
                if (mSExcelShowExcelhandle != null)
                {
                    mSExcelShowExcel["Handle"] = CSharpExpressionConverter.ConvertToken(mSExcelShowExcelhandle);
                    mSExcelShowExcelpropCount++;
                }

                mSExcelShowExcelpropCount++;
            }
            else
            {
                mSExcelShowExcel["Handle"] = 0;
                mSExcelShowExcelpropCount++;
            }

            mSExcelShowExcelpropCount++;
            mSExcelShowExcel["Workflow"] = CSharpExpressionConverter.ConvertToken(mSExcelShowExcelworkflow);
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
                if (mSExcelHideExcelhandle != null)
                {
                    mSExcelHideExcel["Handle"] = CSharpExpressionConverter.ConvertToken(mSExcelHideExcelhandle);
                    mSExcelHideExcelpropCount++;
                }

                mSExcelHideExcelpropCount++;
            }
            else
            {
                mSExcelHideExcel["Handle"] = 0;
                mSExcelHideExcelpropCount++;
            }

            mSExcelHideExcelpropCount++;
            mSExcelHideExcel["Workflow"] = CSharpExpressionConverter.ConvertToken(mSExcelHideExcelworkflow);
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
                if (mSExcelOpenWorkbookhandle != null)
                {
                    mSExcelOpenWorkbook["Handle"] = CSharpExpressionConverter.ConvertToken(mSExcelOpenWorkbookhandle);
                    mSExcelOpenWorkbookpropCount++;
                }

                mSExcelOpenWorkbookpropCount++;
            }
            else
            {
                mSExcelOpenWorkbook["Handle"] = 0;
                mSExcelOpenWorkbookpropCount++;
            }

            if (mSExcelOpenWorkbookfilename != null)
            {
                mSExcelOpenWorkbook["Filename"] = CSharpExpressionConverter.ConvertToken(mSExcelOpenWorkbookfilename);
                mSExcelOpenWorkbookpropCount++;
            }

            if (mSExcelOpenWorkbookreadOnly != null)
            {
                if (mSExcelOpenWorkbookreadOnly != null)
                {
                    mSExcelOpenWorkbook["ReadOnly"] = CSharpExpressionConverter.ConvertToken(mSExcelOpenWorkbookreadOnly);
                    mSExcelOpenWorkbookpropCount++;
                }

                mSExcelOpenWorkbookpropCount++;
            }
            else
            {
                mSExcelOpenWorkbook["ReadOnly"] = false;
                mSExcelOpenWorkbookpropCount++;
            }

            if (mSExcelOpenWorkbookupdateLinks != null)
            {
                if (mSExcelOpenWorkbookupdateLinks != null)
                {
                    mSExcelOpenWorkbook["UpdateLinks"] = CSharpExpressionConverter.ConvertToken(mSExcelOpenWorkbookupdateLinks);
                    mSExcelOpenWorkbookpropCount++;
                }

                mSExcelOpenWorkbookpropCount++;
            }
            else
            {
                mSExcelOpenWorkbook["UpdateLinks"] = false;
                mSExcelOpenWorkbookpropCount++;
            }

            if (mSExcelOpenWorkbookpassword != null)
            {
                mSExcelOpenWorkbook["Password"] = CSharpExpressionConverter.ConvertToken(mSExcelOpenWorkbookpassword);
                mSExcelOpenWorkbookpropCount++;
            }

            if (mSExcelOpenWorkbookenableEvents != null)
            {
                if (mSExcelOpenWorkbookenableEvents != null)
                {
                    mSExcelOpenWorkbook["EnableEvents"] = CSharpExpressionConverter.ConvertToken(mSExcelOpenWorkbookenableEvents);
                    mSExcelOpenWorkbookpropCount++;
                }

                mSExcelOpenWorkbookpropCount++;
            }
            else
            {
                mSExcelOpenWorkbook["EnableEvents"] = true;
                mSExcelOpenWorkbookpropCount++;
            }

            if (mSExcelOpenWorkbookputHTTPWorkbooksIntoEditMode != null)
            {
                if (mSExcelOpenWorkbookputHTTPWorkbooksIntoEditMode != null)
                {
                    mSExcelOpenWorkbook["PutHTTPWorkbooksIntoEditMode"] = CSharpExpressionConverter.ConvertToken(mSExcelOpenWorkbookputHTTPWorkbooksIntoEditMode);
                    mSExcelOpenWorkbookpropCount++;
                }

                mSExcelOpenWorkbookpropCount++;
            }
            else
            {
                mSExcelOpenWorkbook["PutHTTPWorkbooksIntoEditMode"] = true;
                mSExcelOpenWorkbookpropCount++;
            }

            if (mSExcelOpenWorkbookputFilePathWorkbooksIntoEditMode != null)
            {
                if (mSExcelOpenWorkbookputFilePathWorkbooksIntoEditMode != null)
                {
                    mSExcelOpenWorkbook["PutFilePathWorkbooksIntoEditMode"] = CSharpExpressionConverter.ConvertToken(mSExcelOpenWorkbookputFilePathWorkbooksIntoEditMode);
                    mSExcelOpenWorkbookpropCount++;
                }

                mSExcelOpenWorkbookpropCount++;
            }
            else
            {
                mSExcelOpenWorkbook["PutFilePathWorkbooksIntoEditMode"] = false;
                mSExcelOpenWorkbookpropCount++;
            }

            mSExcelOpenWorkbookpropCount++;
            mSExcelOpenWorkbook["Workflow"] = CSharpExpressionConverter.ConvertToken(mSExcelOpenWorkbookworkflow);
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
                if (mSExcelPutWorkbookInEditModehandle != null)
                {
                    mSExcelPutWorkbookInEditMode["Handle"] = CSharpExpressionConverter.ConvertToken(mSExcelPutWorkbookInEditModehandle);
                    mSExcelPutWorkbookInEditModepropCount++;
                }

                mSExcelPutWorkbookInEditModepropCount++;
            }
            else
            {
                mSExcelPutWorkbookInEditMode["Handle"] = 0;
                mSExcelPutWorkbookInEditModepropCount++;
            }

            if (mSExcelPutWorkbookInEditModeworkbookName != null)
            {
                mSExcelPutWorkbookInEditMode["WorkbookName"] = CSharpExpressionConverter.ConvertToken(mSExcelPutWorkbookInEditModeworkbookName);
                mSExcelPutWorkbookInEditModepropCount++;
            }

            if (mSExcelPutWorkbookInEditModeforce != null)
            {
                if (mSExcelPutWorkbookInEditModeforce != null)
                {
                    mSExcelPutWorkbookInEditMode["Force"] = CSharpExpressionConverter.ConvertToken(mSExcelPutWorkbookInEditModeforce);
                    mSExcelPutWorkbookInEditModepropCount++;
                }

                mSExcelPutWorkbookInEditModepropCount++;
            }
            else
            {
                mSExcelPutWorkbookInEditMode["Force"] = false;
                mSExcelPutWorkbookInEditModepropCount++;
            }

            mSExcelPutWorkbookInEditModepropCount++;
            mSExcelPutWorkbookInEditMode["Workflow"] = CSharpExpressionConverter.ConvertToken(mSExcelPutWorkbookInEditModeworkflow);
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
                if (mSExcelCreateWorkbookhandle != null)
                {
                    mSExcelCreateWorkbook["Handle"] = CSharpExpressionConverter.ConvertToken(mSExcelCreateWorkbookhandle);
                    mSExcelCreateWorkbookpropCount++;
                }

                mSExcelCreateWorkbookpropCount++;
            }
            else
            {
                mSExcelCreateWorkbook["Handle"] = 0;
                mSExcelCreateWorkbookpropCount++;
            }

            mSExcelCreateWorkbookpropCount++;
            mSExcelCreateWorkbook["Workflow"] = CSharpExpressionConverter.ConvertToken(mSExcelCreateWorkbookworkflow);
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
                if (mSExcelCloseWorkbookhandle != null)
                {
                    mSExcelCloseWorkbook["Handle"] = CSharpExpressionConverter.ConvertToken(mSExcelCloseWorkbookhandle);
                    mSExcelCloseWorkbookpropCount++;
                }

                mSExcelCloseWorkbookpropCount++;
            }
            else
            {
                mSExcelCloseWorkbook["Handle"] = 0;
                mSExcelCloseWorkbookpropCount++;
            }

            if (mSExcelCloseWorkbookworkbookName != null)
            {
                mSExcelCloseWorkbook["WorkbookName"] = CSharpExpressionConverter.ConvertToken(mSExcelCloseWorkbookworkbookName);
                mSExcelCloseWorkbookpropCount++;
            }

            if (mSExcelCloseWorkbooksaveData != null)
            {
                if (mSExcelCloseWorkbooksaveData != null)
                {
                    mSExcelCloseWorkbook["SaveData"] = CSharpExpressionConverter.ConvertToken(mSExcelCloseWorkbooksaveData);
                    mSExcelCloseWorkbookpropCount++;
                }

                mSExcelCloseWorkbookpropCount++;
            }
            else
            {
                mSExcelCloseWorkbook["SaveData"] = false;
                mSExcelCloseWorkbookpropCount++;
            }

            mSExcelCloseWorkbookpropCount++;
            mSExcelCloseWorkbook["Workflow"] = CSharpExpressionConverter.ConvertToken(mSExcelCloseWorkbookworkflow);
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
                if (mSExcelCloseCurrentWorkbookhandle != null)
                {
                    mSExcelCloseCurrentWorkbook["Handle"] = CSharpExpressionConverter.ConvertToken(mSExcelCloseCurrentWorkbookhandle);
                    mSExcelCloseCurrentWorkbookpropCount++;
                }

                mSExcelCloseCurrentWorkbookpropCount++;
            }
            else
            {
                mSExcelCloseCurrentWorkbook["Handle"] = 0;
                mSExcelCloseCurrentWorkbookpropCount++;
            }

            mSExcelCloseCurrentWorkbookpropCount++;
            mSExcelCloseCurrentWorkbook["Workflow"] = CSharpExpressionConverter.ConvertToken(mSExcelCloseCurrentWorkbookworkflow);
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
                if (mSExcelGoToCellhandle != null)
                {
                    mSExcelGoToCell["Handle"] = CSharpExpressionConverter.ConvertToken(mSExcelGoToCellhandle);
                    mSExcelGoToCellpropCount++;
                }

                mSExcelGoToCellpropCount++;
            }
            else
            {
                mSExcelGoToCell["Handle"] = 0;
                mSExcelGoToCellpropCount++;
            }

            if (mSExcelGoToCellworkbookName != null)
            {
                mSExcelGoToCell["WorkbookName"] = CSharpExpressionConverter.ConvertToken(mSExcelGoToCellworkbookName);
                mSExcelGoToCellpropCount++;
            }

            if (mSExcelGoToCellworksheetName != null)
            {
                mSExcelGoToCell["WorksheetName"] = CSharpExpressionConverter.ConvertToken(mSExcelGoToCellworksheetName);
                mSExcelGoToCellpropCount++;
            }

            mSExcelGoToCellpropCount++;
            mSExcelGoToCell["CellReference"] = CSharpExpressionConverter.ConvertToken(mSExcelGoToCellcellReference);
            mSExcelGoToCellpropCount++;
            mSExcelGoToCell["Workflow"] = CSharpExpressionConverter.ConvertToken(mSExcelGoToCellworkflow);
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
                if (mSExcelGetCellValuehandle != null)
                {
                    mSExcelGetCellValue["Handle"] = CSharpExpressionConverter.ConvertToken(mSExcelGetCellValuehandle);
                    mSExcelGetCellValuepropCount++;
                }

                mSExcelGetCellValuepropCount++;
            }
            else
            {
                mSExcelGetCellValue["Handle"] = 0;
                mSExcelGetCellValuepropCount++;
            }

            if (mSExcelGetCellValueworkbookName != null)
            {
                mSExcelGetCellValue["WorkbookName"] = CSharpExpressionConverter.ConvertToken(mSExcelGetCellValueworkbookName);
                mSExcelGetCellValuepropCount++;
            }

            if (mSExcelGetCellValueworksheetName != null)
            {
                mSExcelGetCellValue["WorksheetName"] = CSharpExpressionConverter.ConvertToken(mSExcelGetCellValueworksheetName);
                mSExcelGetCellValuepropCount++;
            }

            mSExcelGetCellValuepropCount++;
            mSExcelGetCellValue["CellReference"] = CSharpExpressionConverter.ConvertToken(mSExcelGetCellValuecellReference);
            mSExcelGetCellValuepropCount++;
            mSExcelGetCellValue["Workflow"] = CSharpExpressionConverter.ConvertToken(mSExcelGetCellValueworkflow);
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
                if (mSExcelGetCellValue2handle != null)
                {
                    mSExcelGetCellValue2["Handle"] = CSharpExpressionConverter.ConvertToken(mSExcelGetCellValue2handle);
                    mSExcelGetCellValue2propCount++;
                }

                mSExcelGetCellValue2propCount++;
            }
            else
            {
                mSExcelGetCellValue2["Handle"] = 0;
                mSExcelGetCellValue2propCount++;
            }

            if (mSExcelGetCellValue2workbookName != null)
            {
                mSExcelGetCellValue2["WorkbookName"] = CSharpExpressionConverter.ConvertToken(mSExcelGetCellValue2workbookName);
                mSExcelGetCellValue2propCount++;
            }

            if (mSExcelGetCellValue2worksheetName != null)
            {
                mSExcelGetCellValue2["WorksheetName"] = CSharpExpressionConverter.ConvertToken(mSExcelGetCellValue2worksheetName);
                mSExcelGetCellValue2propCount++;
            }

            mSExcelGetCellValue2propCount++;
            mSExcelGetCellValue2["CellReference"] = CSharpExpressionConverter.ConvertToken(mSExcelGetCellValue2cellReference);
            mSExcelGetCellValue2propCount++;
            mSExcelGetCellValue2["Workflow"] = CSharpExpressionConverter.ConvertToken(mSExcelGetCellValue2workflow);
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
                if (mSExcelGetCellTexthandle != null)
                {
                    mSExcelGetCellText["Handle"] = CSharpExpressionConverter.ConvertToken(mSExcelGetCellTexthandle);
                    mSExcelGetCellTextpropCount++;
                }

                mSExcelGetCellTextpropCount++;
            }
            else
            {
                mSExcelGetCellText["Handle"] = 0;
                mSExcelGetCellTextpropCount++;
            }

            if (mSExcelGetCellTextworkbookName != null)
            {
                mSExcelGetCellText["WorkbookName"] = CSharpExpressionConverter.ConvertToken(mSExcelGetCellTextworkbookName);
                mSExcelGetCellTextpropCount++;
            }

            if (mSExcelGetCellTextworksheetName != null)
            {
                mSExcelGetCellText["WorksheetName"] = CSharpExpressionConverter.ConvertToken(mSExcelGetCellTextworksheetName);
                mSExcelGetCellTextpropCount++;
            }

            mSExcelGetCellTextpropCount++;
            mSExcelGetCellText["CellReference"] = CSharpExpressionConverter.ConvertToken(mSExcelGetCellTextcellReference);
            mSExcelGetCellTextpropCount++;
            mSExcelGetCellText["Workflow"] = CSharpExpressionConverter.ConvertToken(mSExcelGetCellTextworkflow);
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
                if (mSExcelSetCellValuehandle != null)
                {
                    mSExcelSetCellValue["Handle"] = CSharpExpressionConverter.ConvertToken(mSExcelSetCellValuehandle);
                    mSExcelSetCellValuepropCount++;
                }

                mSExcelSetCellValuepropCount++;
            }
            else
            {
                mSExcelSetCellValue["Handle"] = 0;
                mSExcelSetCellValuepropCount++;
            }

            if (mSExcelSetCellValueworkbookName != null)
            {
                mSExcelSetCellValue["WorkbookName"] = CSharpExpressionConverter.ConvertToken(mSExcelSetCellValueworkbookName);
                mSExcelSetCellValuepropCount++;
            }

            if (mSExcelSetCellValueworksheetName != null)
            {
                mSExcelSetCellValue["WorksheetName"] = CSharpExpressionConverter.ConvertToken(mSExcelSetCellValueworksheetName);
                mSExcelSetCellValuepropCount++;
            }

            mSExcelSetCellValuepropCount++;
            mSExcelSetCellValue["CellReference"] = CSharpExpressionConverter.ConvertToken(mSExcelSetCellValuecellReference);
            if (mSExcelSetCellValuecellValue != null)
            {
                mSExcelSetCellValue["CellValue"] = CSharpExpressionConverter.ConvertToken(mSExcelSetCellValuecellValue);
                mSExcelSetCellValuepropCount++;
            }

            if (mSExcelSetCellValuecellValueContainsStoredPassword != null)
            {
                if (mSExcelSetCellValuecellValueContainsStoredPassword != null)
                {
                    mSExcelSetCellValue["CellValueContainsStoredPassword"] = CSharpExpressionConverter.ConvertToken(mSExcelSetCellValuecellValueContainsStoredPassword);
                    mSExcelSetCellValuepropCount++;
                }

                mSExcelSetCellValuepropCount++;
            }
            else
            {
                mSExcelSetCellValue["CellValueContainsStoredPassword"] = false;
                mSExcelSetCellValuepropCount++;
            }

            mSExcelSetCellValuepropCount++;
            mSExcelSetCellValue["Workflow"] = CSharpExpressionConverter.ConvertToken(mSExcelSetCellValueworkflow);
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
                if (mSExcelFindNextCellWithValuehandle != null)
                {
                    mSExcelFindNextCellWithValue["Handle"] = CSharpExpressionConverter.ConvertToken(mSExcelFindNextCellWithValuehandle);
                    mSExcelFindNextCellWithValuepropCount++;
                }

                mSExcelFindNextCellWithValuepropCount++;
            }
            else
            {
                mSExcelFindNextCellWithValue["Handle"] = 0;
                mSExcelFindNextCellWithValuepropCount++;
            }

            if (mSExcelFindNextCellWithValueworkbookName != null)
            {
                mSExcelFindNextCellWithValue["WorkbookName"] = CSharpExpressionConverter.ConvertToken(mSExcelFindNextCellWithValueworkbookName);
                mSExcelFindNextCellWithValuepropCount++;
            }

            if (mSExcelFindNextCellWithValueworksheetName != null)
            {
                mSExcelFindNextCellWithValue["WorksheetName"] = CSharpExpressionConverter.ConvertToken(mSExcelFindNextCellWithValueworksheetName);
                mSExcelFindNextCellWithValuepropCount++;
            }

            mSExcelFindNextCellWithValuepropCount++;
            mSExcelFindNextCellWithValue["Direction"] = CSharpExpressionConverter.Convert(mSExcelFindNextCellWithValuedirection);
            mSExcelFindNextCellWithValuepropCount++;
            mSExcelFindNextCellWithValue["SearchValue"] = CSharpExpressionConverter.ConvertToken(mSExcelFindNextCellWithValuesearchValue);
            if (mSExcelFindNextCellWithValuecaseSensitive != null)
            {
                if (mSExcelFindNextCellWithValuecaseSensitive != null)
                {
                    mSExcelFindNextCellWithValue["CaseSensitive"] = CSharpExpressionConverter.ConvertToken(mSExcelFindNextCellWithValuecaseSensitive);
                    mSExcelFindNextCellWithValuepropCount++;
                }

                mSExcelFindNextCellWithValuepropCount++;
            }
            else
            {
                mSExcelFindNextCellWithValue["CaseSensitive"] = false;
                mSExcelFindNextCellWithValuepropCount++;
            }

            if (mSExcelFindNextCellWithValuecomparisonType != null)
            {
                mSExcelFindNextCellWithValue["ComparisonType"] = CSharpExpressionConverter.Convert(mSExcelFindNextCellWithValuecomparisonType);
                mSExcelFindNextCellWithValuepropCount++;
            }

            if (mSExcelFindNextCellWithValuemaxCellsToSearch != null)
            {
                mSExcelFindNextCellWithValue["MaxCellsToSearch"] = CSharpExpressionConverter.ConvertToken(mSExcelFindNextCellWithValuemaxCellsToSearch);
                mSExcelFindNextCellWithValuepropCount++;
            }

            if (mSExcelFindNextCellWithValueactivateCell != null)
            {
                if (mSExcelFindNextCellWithValueactivateCell != null)
                {
                    mSExcelFindNextCellWithValue["ActivateCell"] = CSharpExpressionConverter.ConvertToken(mSExcelFindNextCellWithValueactivateCell);
                    mSExcelFindNextCellWithValuepropCount++;
                }

                mSExcelFindNextCellWithValuepropCount++;
            }
            else
            {
                mSExcelFindNextCellWithValue["ActivateCell"] = false;
                mSExcelFindNextCellWithValuepropCount++;
            }

            mSExcelFindNextCellWithValuepropCount++;
            mSExcelFindNextCellWithValue["Workflow"] = CSharpExpressionConverter.ConvertToken(mSExcelFindNextCellWithValueworkflow);
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
                if (mSExcelFindNextEmptyCellhandle != null)
                {
                    mSExcelFindNextEmptyCell["Handle"] = CSharpExpressionConverter.ConvertToken(mSExcelFindNextEmptyCellhandle);
                    mSExcelFindNextEmptyCellpropCount++;
                }

                mSExcelFindNextEmptyCellpropCount++;
            }
            else
            {
                mSExcelFindNextEmptyCell["Handle"] = 0;
                mSExcelFindNextEmptyCellpropCount++;
            }

            if (mSExcelFindNextEmptyCellworkbookName != null)
            {
                mSExcelFindNextEmptyCell["WorkbookName"] = CSharpExpressionConverter.ConvertToken(mSExcelFindNextEmptyCellworkbookName);
                mSExcelFindNextEmptyCellpropCount++;
            }

            if (mSExcelFindNextEmptyCellworksheetName != null)
            {
                mSExcelFindNextEmptyCell["WorksheetName"] = CSharpExpressionConverter.ConvertToken(mSExcelFindNextEmptyCellworksheetName);
                mSExcelFindNextEmptyCellpropCount++;
            }

            mSExcelFindNextEmptyCellpropCount++;
            mSExcelFindNextEmptyCell["Direction"] = CSharpExpressionConverter.Convert(mSExcelFindNextEmptyCelldirection);
            if (mSExcelFindNextEmptyCellactivateCell != null)
            {
                if (mSExcelFindNextEmptyCellactivateCell != null)
                {
                    mSExcelFindNextEmptyCell["ActivateCell"] = CSharpExpressionConverter.ConvertToken(mSExcelFindNextEmptyCellactivateCell);
                    mSExcelFindNextEmptyCellpropCount++;
                }

                mSExcelFindNextEmptyCellpropCount++;
            }
            else
            {
                mSExcelFindNextEmptyCell["ActivateCell"] = false;
                mSExcelFindNextEmptyCellpropCount++;
            }

            mSExcelFindNextEmptyCellpropCount++;
            mSExcelFindNextEmptyCell["Workflow"] = CSharpExpressionConverter.ConvertToken(mSExcelFindNextEmptyCellworkflow);
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
                if (mSExcelGotoNextEmptyCellLefthandle != null)
                {
                    mSExcelGotoNextEmptyCellLeft["Handle"] = CSharpExpressionConverter.ConvertToken(mSExcelGotoNextEmptyCellLefthandle);
                    mSExcelGotoNextEmptyCellLeftpropCount++;
                }

                mSExcelGotoNextEmptyCellLeftpropCount++;
            }
            else
            {
                mSExcelGotoNextEmptyCellLeft["Handle"] = 0;
                mSExcelGotoNextEmptyCellLeftpropCount++;
            }

            if (mSExcelGotoNextEmptyCellLeftworkbookName != null)
            {
                mSExcelGotoNextEmptyCellLeft["WorkbookName"] = CSharpExpressionConverter.ConvertToken(mSExcelGotoNextEmptyCellLeftworkbookName);
                mSExcelGotoNextEmptyCellLeftpropCount++;
            }

            if (mSExcelGotoNextEmptyCellLeftworksheetName != null)
            {
                mSExcelGotoNextEmptyCellLeft["WorksheetName"] = CSharpExpressionConverter.ConvertToken(mSExcelGotoNextEmptyCellLeftworksheetName);
                mSExcelGotoNextEmptyCellLeftpropCount++;
            }

            mSExcelGotoNextEmptyCellLeftpropCount++;
            mSExcelGotoNextEmptyCellLeft["Workflow"] = CSharpExpressionConverter.ConvertToken(mSExcelGotoNextEmptyCellLeftworkflow);
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
                if (mSExcelGotoNextEmptyCellRighthandle != null)
                {
                    mSExcelGotoNextEmptyCellRight["Handle"] = CSharpExpressionConverter.ConvertToken(mSExcelGotoNextEmptyCellRighthandle);
                    mSExcelGotoNextEmptyCellRightpropCount++;
                }

                mSExcelGotoNextEmptyCellRightpropCount++;
            }
            else
            {
                mSExcelGotoNextEmptyCellRight["Handle"] = 0;
                mSExcelGotoNextEmptyCellRightpropCount++;
            }

            if (mSExcelGotoNextEmptyCellRightworkbookName != null)
            {
                mSExcelGotoNextEmptyCellRight["WorkbookName"] = CSharpExpressionConverter.ConvertToken(mSExcelGotoNextEmptyCellRightworkbookName);
                mSExcelGotoNextEmptyCellRightpropCount++;
            }

            if (mSExcelGotoNextEmptyCellRightworksheetName != null)
            {
                mSExcelGotoNextEmptyCellRight["WorksheetName"] = CSharpExpressionConverter.ConvertToken(mSExcelGotoNextEmptyCellRightworksheetName);
                mSExcelGotoNextEmptyCellRightpropCount++;
            }

            mSExcelGotoNextEmptyCellRightpropCount++;
            mSExcelGotoNextEmptyCellRight["Workflow"] = CSharpExpressionConverter.ConvertToken(mSExcelGotoNextEmptyCellRightworkflow);
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
                if (mSExcelGotoNextEmptyCellUphandle != null)
                {
                    mSExcelGotoNextEmptyCellUp["Handle"] = CSharpExpressionConverter.ConvertToken(mSExcelGotoNextEmptyCellUphandle);
                    mSExcelGotoNextEmptyCellUppropCount++;
                }

                mSExcelGotoNextEmptyCellUppropCount++;
            }
            else
            {
                mSExcelGotoNextEmptyCellUp["Handle"] = 0;
                mSExcelGotoNextEmptyCellUppropCount++;
            }

            if (mSExcelGotoNextEmptyCellUpworkbookName != null)
            {
                mSExcelGotoNextEmptyCellUp["WorkbookName"] = CSharpExpressionConverter.ConvertToken(mSExcelGotoNextEmptyCellUpworkbookName);
                mSExcelGotoNextEmptyCellUppropCount++;
            }

            if (mSExcelGotoNextEmptyCellUpworksheetName != null)
            {
                mSExcelGotoNextEmptyCellUp["WorksheetName"] = CSharpExpressionConverter.ConvertToken(mSExcelGotoNextEmptyCellUpworksheetName);
                mSExcelGotoNextEmptyCellUppropCount++;
            }

            mSExcelGotoNextEmptyCellUppropCount++;
            mSExcelGotoNextEmptyCellUp["Workflow"] = CSharpExpressionConverter.ConvertToken(mSExcelGotoNextEmptyCellUpworkflow);
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
                if (mSExcelGotoNextEmptyCellDownhandle != null)
                {
                    mSExcelGotoNextEmptyCellDown["Handle"] = CSharpExpressionConverter.ConvertToken(mSExcelGotoNextEmptyCellDownhandle);
                    mSExcelGotoNextEmptyCellDownpropCount++;
                }

                mSExcelGotoNextEmptyCellDownpropCount++;
            }
            else
            {
                mSExcelGotoNextEmptyCellDown["Handle"] = 0;
                mSExcelGotoNextEmptyCellDownpropCount++;
            }

            if (mSExcelGotoNextEmptyCellDownworkbookName != null)
            {
                mSExcelGotoNextEmptyCellDown["WorkbookName"] = CSharpExpressionConverter.ConvertToken(mSExcelGotoNextEmptyCellDownworkbookName);
                mSExcelGotoNextEmptyCellDownpropCount++;
            }

            if (mSExcelGotoNextEmptyCellDownworksheetName != null)
            {
                mSExcelGotoNextEmptyCellDown["WorksheetName"] = CSharpExpressionConverter.ConvertToken(mSExcelGotoNextEmptyCellDownworksheetName);
                mSExcelGotoNextEmptyCellDownpropCount++;
            }

            mSExcelGotoNextEmptyCellDownpropCount++;
            mSExcelGotoNextEmptyCellDown["Workflow"] = CSharpExpressionConverter.ConvertToken(mSExcelGotoNextEmptyCellDownworkflow);
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
                if (mSExcelSaveWorkbookhandle != null)
                {
                    mSExcelSaveWorkbook["Handle"] = CSharpExpressionConverter.ConvertToken(mSExcelSaveWorkbookhandle);
                    mSExcelSaveWorkbookpropCount++;
                }

                mSExcelSaveWorkbookpropCount++;
            }
            else
            {
                mSExcelSaveWorkbook["Handle"] = 0;
                mSExcelSaveWorkbookpropCount++;
            }

            if (mSExcelSaveWorkbookworkbookName != null)
            {
                mSExcelSaveWorkbook["WorkbookName"] = CSharpExpressionConverter.ConvertToken(mSExcelSaveWorkbookworkbookName);
                mSExcelSaveWorkbookpropCount++;
            }

            mSExcelSaveWorkbookpropCount++;
            mSExcelSaveWorkbook["Workflow"] = CSharpExpressionConverter.ConvertToken(mSExcelSaveWorkbookworkflow);
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
                if (mSExcelSaveWorkbookAshandle != null)
                {
                    mSExcelSaveWorkbookAs["Handle"] = CSharpExpressionConverter.ConvertToken(mSExcelSaveWorkbookAshandle);
                    mSExcelSaveWorkbookAspropCount++;
                }

                mSExcelSaveWorkbookAspropCount++;
            }
            else
            {
                mSExcelSaveWorkbookAs["Handle"] = 0;
                mSExcelSaveWorkbookAspropCount++;
            }

            if (mSExcelSaveWorkbookAsworkbookName != null)
            {
                mSExcelSaveWorkbookAs["WorkbookName"] = CSharpExpressionConverter.ConvertToken(mSExcelSaveWorkbookAsworkbookName);
                mSExcelSaveWorkbookAspropCount++;
            }

            mSExcelSaveWorkbookAspropCount++;
            mSExcelSaveWorkbookAs["SaveFilename"] = CSharpExpressionConverter.ConvertToken(mSExcelSaveWorkbookAssaveFilename);
            if (mSExcelSaveWorkbookAsdeleteExistingSaveFilename != null)
            {
                if (mSExcelSaveWorkbookAsdeleteExistingSaveFilename != null)
                {
                    mSExcelSaveWorkbookAs["DeleteExistingSaveFilename"] = CSharpExpressionConverter.ConvertToken(mSExcelSaveWorkbookAsdeleteExistingSaveFilename);
                    mSExcelSaveWorkbookAspropCount++;
                }

                mSExcelSaveWorkbookAspropCount++;
            }
            else
            {
                mSExcelSaveWorkbookAs["DeleteExistingSaveFilename"] = false;
                mSExcelSaveWorkbookAspropCount++;
            }

            if (mSExcelSaveWorkbookAsexcelFileFormat != null)
            {
                if (mSExcelSaveWorkbookAsexcelFileFormat != null)
                {
                    mSExcelSaveWorkbookAs["ExcelFileFormat"] = CSharpExpressionConverter.Convert(mSExcelSaveWorkbookAsexcelFileFormat);
                    mSExcelSaveWorkbookAspropCount++;
                }

                mSExcelSaveWorkbookAspropCount++;
            }
            else
            {
                mSExcelSaveWorkbookAs["ExcelFileFormat"] = "AutomaticByExtension";
                mSExcelSaveWorkbookAspropCount++;
            }

            mSExcelSaveWorkbookAspropCount++;
            mSExcelSaveWorkbookAs["Workflow"] = CSharpExpressionConverter.ConvertToken(mSExcelSaveWorkbookAsworkflow);
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
                if (mSExcelSaveWorkbookAsCSVhandle != null)
                {
                    mSExcelSaveWorkbookAsCSV["Handle"] = CSharpExpressionConverter.ConvertToken(mSExcelSaveWorkbookAsCSVhandle);
                    mSExcelSaveWorkbookAsCSVpropCount++;
                }

                mSExcelSaveWorkbookAsCSVpropCount++;
            }
            else
            {
                mSExcelSaveWorkbookAsCSV["Handle"] = 0;
                mSExcelSaveWorkbookAsCSVpropCount++;
            }

            if (mSExcelSaveWorkbookAsCSVworkbookName != null)
            {
                mSExcelSaveWorkbookAsCSV["WorkbookName"] = CSharpExpressionConverter.ConvertToken(mSExcelSaveWorkbookAsCSVworkbookName);
                mSExcelSaveWorkbookAsCSVpropCount++;
            }

            mSExcelSaveWorkbookAsCSVpropCount++;
            mSExcelSaveWorkbookAsCSV["SaveFilename"] = CSharpExpressionConverter.ConvertToken(mSExcelSaveWorkbookAsCSVsaveFilename);
            if (mSExcelSaveWorkbookAsCSVdeleteExistingSaveFilename != null)
            {
                if (mSExcelSaveWorkbookAsCSVdeleteExistingSaveFilename != null)
                {
                    mSExcelSaveWorkbookAsCSV["DeleteExistingSaveFilename"] = CSharpExpressionConverter.ConvertToken(mSExcelSaveWorkbookAsCSVdeleteExistingSaveFilename);
                    mSExcelSaveWorkbookAsCSVpropCount++;
                }

                mSExcelSaveWorkbookAsCSVpropCount++;
            }
            else
            {
                mSExcelSaveWorkbookAsCSV["DeleteExistingSaveFilename"] = false;
                mSExcelSaveWorkbookAsCSVpropCount++;
            }

            mSExcelSaveWorkbookAsCSVpropCount++;
            mSExcelSaveWorkbookAsCSV["Workflow"] = CSharpExpressionConverter.ConvertToken(mSExcelSaveWorkbookAsCSVworkflow);
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
                if (mSExcelSaveWorkbookAsWithPasswordhandle != null)
                {
                    mSExcelSaveWorkbookAsWithPassword["Handle"] = CSharpExpressionConverter.ConvertToken(mSExcelSaveWorkbookAsWithPasswordhandle);
                    mSExcelSaveWorkbookAsWithPasswordpropCount++;
                }

                mSExcelSaveWorkbookAsWithPasswordpropCount++;
            }
            else
            {
                mSExcelSaveWorkbookAsWithPassword["Handle"] = 0;
                mSExcelSaveWorkbookAsWithPasswordpropCount++;
            }

            if (mSExcelSaveWorkbookAsWithPasswordworkbookName != null)
            {
                mSExcelSaveWorkbookAsWithPassword["WorkbookName"] = CSharpExpressionConverter.ConvertToken(mSExcelSaveWorkbookAsWithPasswordworkbookName);
                mSExcelSaveWorkbookAsWithPasswordpropCount++;
            }

            mSExcelSaveWorkbookAsWithPasswordpropCount++;
            mSExcelSaveWorkbookAsWithPassword["SaveFilename"] = CSharpExpressionConverter.ConvertToken(mSExcelSaveWorkbookAsWithPasswordsaveFilename);
            mSExcelSaveWorkbookAsWithPasswordpropCount++;
            mSExcelSaveWorkbookAsWithPassword["Password"] = CSharpExpressionConverter.ConvertToken(mSExcelSaveWorkbookAsWithPasswordpassword);
            if (mSExcelSaveWorkbookAsWithPassworddeleteExistingSaveFilename != null)
            {
                if (mSExcelSaveWorkbookAsWithPassworddeleteExistingSaveFilename != null)
                {
                    mSExcelSaveWorkbookAsWithPassword["DeleteExistingSaveFilename"] = CSharpExpressionConverter.ConvertToken(mSExcelSaveWorkbookAsWithPassworddeleteExistingSaveFilename);
                    mSExcelSaveWorkbookAsWithPasswordpropCount++;
                }

                mSExcelSaveWorkbookAsWithPasswordpropCount++;
            }
            else
            {
                mSExcelSaveWorkbookAsWithPassword["DeleteExistingSaveFilename"] = false;
                mSExcelSaveWorkbookAsWithPasswordpropCount++;
            }

            if (mSExcelSaveWorkbookAsWithPasswordexcelFileFormat != null)
            {
                if (mSExcelSaveWorkbookAsWithPasswordexcelFileFormat != null)
                {
                    mSExcelSaveWorkbookAsWithPassword["ExcelFileFormat"] = CSharpExpressionConverter.Convert(mSExcelSaveWorkbookAsWithPasswordexcelFileFormat);
                    mSExcelSaveWorkbookAsWithPasswordpropCount++;
                }

                mSExcelSaveWorkbookAsWithPasswordpropCount++;
            }
            else
            {
                mSExcelSaveWorkbookAsWithPassword["ExcelFileFormat"] = "AutomaticByExtension";
                mSExcelSaveWorkbookAsWithPasswordpropCount++;
            }

            mSExcelSaveWorkbookAsWithPasswordpropCount++;
            mSExcelSaveWorkbookAsWithPassword["Workflow"] = CSharpExpressionConverter.ConvertToken(mSExcelSaveWorkbookAsWithPasswordworkflow);
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
                if (mSExcelSaveCurrentWorkbookhandle != null)
                {
                    mSExcelSaveCurrentWorkbook["Handle"] = CSharpExpressionConverter.ConvertToken(mSExcelSaveCurrentWorkbookhandle);
                    mSExcelSaveCurrentWorkbookpropCount++;
                }

                mSExcelSaveCurrentWorkbookpropCount++;
            }
            else
            {
                mSExcelSaveCurrentWorkbook["Handle"] = 0;
                mSExcelSaveCurrentWorkbookpropCount++;
            }

            mSExcelSaveCurrentWorkbookpropCount++;
            mSExcelSaveCurrentWorkbook["Workflow"] = CSharpExpressionConverter.ConvertToken(mSExcelSaveCurrentWorkbookworkflow);
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
                if (mSExcelSaveCurrentWorkbookAshandle != null)
                {
                    mSExcelSaveCurrentWorkbookAs["Handle"] = CSharpExpressionConverter.ConvertToken(mSExcelSaveCurrentWorkbookAshandle);
                    mSExcelSaveCurrentWorkbookAspropCount++;
                }

                mSExcelSaveCurrentWorkbookAspropCount++;
            }
            else
            {
                mSExcelSaveCurrentWorkbookAs["Handle"] = 0;
                mSExcelSaveCurrentWorkbookAspropCount++;
            }

            if (mSExcelSaveCurrentWorkbookAssaveFilename != null)
            {
                mSExcelSaveCurrentWorkbookAs["SaveFilename"] = CSharpExpressionConverter.ConvertToken(mSExcelSaveCurrentWorkbookAssaveFilename);
                mSExcelSaveCurrentWorkbookAspropCount++;
            }

            if (mSExcelSaveCurrentWorkbookAsdeleteExistingSaveFilename != null)
            {
                if (mSExcelSaveCurrentWorkbookAsdeleteExistingSaveFilename != null)
                {
                    mSExcelSaveCurrentWorkbookAs["DeleteExistingSaveFilename"] = CSharpExpressionConverter.ConvertToken(mSExcelSaveCurrentWorkbookAsdeleteExistingSaveFilename);
                    mSExcelSaveCurrentWorkbookAspropCount++;
                }

                mSExcelSaveCurrentWorkbookAspropCount++;
            }
            else
            {
                mSExcelSaveCurrentWorkbookAs["DeleteExistingSaveFilename"] = false;
                mSExcelSaveCurrentWorkbookAspropCount++;
            }

            if (mSExcelSaveCurrentWorkbookAsexcelFileFormat != null)
            {
                if (mSExcelSaveCurrentWorkbookAsexcelFileFormat != null)
                {
                    mSExcelSaveCurrentWorkbookAs["ExcelFileFormat"] = CSharpExpressionConverter.Convert(mSExcelSaveCurrentWorkbookAsexcelFileFormat);
                    mSExcelSaveCurrentWorkbookAspropCount++;
                }

                mSExcelSaveCurrentWorkbookAspropCount++;
            }
            else
            {
                mSExcelSaveCurrentWorkbookAs["ExcelFileFormat"] = "AutomaticByExtension";
                mSExcelSaveCurrentWorkbookAspropCount++;
            }

            mSExcelSaveCurrentWorkbookAspropCount++;
            mSExcelSaveCurrentWorkbookAs["Workflow"] = CSharpExpressionConverter.ConvertToken(mSExcelSaveCurrentWorkbookAsworkflow);
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
                if (mSExcelSaveCurrentWorkbookAsCSVhandle != null)
                {
                    mSExcelSaveCurrentWorkbookAsCSV["Handle"] = CSharpExpressionConverter.ConvertToken(mSExcelSaveCurrentWorkbookAsCSVhandle);
                    mSExcelSaveCurrentWorkbookAsCSVpropCount++;
                }

                mSExcelSaveCurrentWorkbookAsCSVpropCount++;
            }
            else
            {
                mSExcelSaveCurrentWorkbookAsCSV["Handle"] = 0;
                mSExcelSaveCurrentWorkbookAsCSVpropCount++;
            }

            mSExcelSaveCurrentWorkbookAsCSVpropCount++;
            mSExcelSaveCurrentWorkbookAsCSV["SaveFilename"] = CSharpExpressionConverter.ConvertToken(mSExcelSaveCurrentWorkbookAsCSVsaveFilename);
            if (mSExcelSaveCurrentWorkbookAsCSVdeleteExistingSaveFilename != null)
            {
                if (mSExcelSaveCurrentWorkbookAsCSVdeleteExistingSaveFilename != null)
                {
                    mSExcelSaveCurrentWorkbookAsCSV["DeleteExistingSaveFilename"] = CSharpExpressionConverter.ConvertToken(mSExcelSaveCurrentWorkbookAsCSVdeleteExistingSaveFilename);
                    mSExcelSaveCurrentWorkbookAsCSVpropCount++;
                }

                mSExcelSaveCurrentWorkbookAsCSVpropCount++;
            }
            else
            {
                mSExcelSaveCurrentWorkbookAsCSV["DeleteExistingSaveFilename"] = false;
                mSExcelSaveCurrentWorkbookAsCSVpropCount++;
            }

            mSExcelSaveCurrentWorkbookAsCSVpropCount++;
            mSExcelSaveCurrentWorkbookAsCSV["Workflow"] = CSharpExpressionConverter.ConvertToken(mSExcelSaveCurrentWorkbookAsCSVworkflow);
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
                if (mSExcelGetWorksheetNameshandle != null)
                {
                    mSExcelGetWorksheetNames["Handle"] = CSharpExpressionConverter.ConvertToken(mSExcelGetWorksheetNameshandle);
                    mSExcelGetWorksheetNamespropCount++;
                }

                mSExcelGetWorksheetNamespropCount++;
            }
            else
            {
                mSExcelGetWorksheetNames["Handle"] = 0;
                mSExcelGetWorksheetNamespropCount++;
            }

            if (mSExcelGetWorksheetNamesworkbookName != null)
            {
                mSExcelGetWorksheetNames["WorkbookName"] = CSharpExpressionConverter.ConvertToken(mSExcelGetWorksheetNamesworkbookName);
                mSExcelGetWorksheetNamespropCount++;
            }

            mSExcelGetWorksheetNamespropCount++;
            mSExcelGetWorksheetNames["Workflow"] = CSharpExpressionConverter.ConvertToken(mSExcelGetWorksheetNamesworkflow);
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
                if (mSExcelGetWorksheetNamehandle != null)
                {
                    mSExcelGetWorksheetName["Handle"] = CSharpExpressionConverter.ConvertToken(mSExcelGetWorksheetNamehandle);
                    mSExcelGetWorksheetNamepropCount++;
                }

                mSExcelGetWorksheetNamepropCount++;
            }
            else
            {
                mSExcelGetWorksheetName["Handle"] = 0;
                mSExcelGetWorksheetNamepropCount++;
            }

            if (mSExcelGetWorksheetNameworkbookName != null)
            {
                mSExcelGetWorksheetName["WorkbookName"] = CSharpExpressionConverter.ConvertToken(mSExcelGetWorksheetNameworkbookName);
                mSExcelGetWorksheetNamepropCount++;
            }

            if (mSExcelGetWorksheetNameposition != null)
            {
                mSExcelGetWorksheetName["Position"] = CSharpExpressionConverter.ConvertToken(mSExcelGetWorksheetNameposition);
                mSExcelGetWorksheetNamepropCount++;
            }

            mSExcelGetWorksheetNamepropCount++;
            mSExcelGetWorksheetName["Workflow"] = CSharpExpressionConverter.ConvertToken(mSExcelGetWorksheetNameworkflow);
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
                if (mSExcelActivateWorksheethandle != null)
                {
                    mSExcelActivateWorksheet["Handle"] = CSharpExpressionConverter.ConvertToken(mSExcelActivateWorksheethandle);
                    mSExcelActivateWorksheetpropCount++;
                }

                mSExcelActivateWorksheetpropCount++;
            }
            else
            {
                mSExcelActivateWorksheet["Handle"] = 0;
                mSExcelActivateWorksheetpropCount++;
            }

            if (mSExcelActivateWorksheetworkbookName != null)
            {
                mSExcelActivateWorksheet["WorkbookName"] = CSharpExpressionConverter.ConvertToken(mSExcelActivateWorksheetworkbookName);
                mSExcelActivateWorksheetpropCount++;
            }

            if (mSExcelActivateWorksheetworksheetName != null)
            {
                mSExcelActivateWorksheet["WorksheetName"] = CSharpExpressionConverter.ConvertToken(mSExcelActivateWorksheetworksheetName);
                mSExcelActivateWorksheetpropCount++;
            }

            if (mSExcelActivateWorksheetcreateIfMissing != null)
            {
                if (mSExcelActivateWorksheetcreateIfMissing != null)
                {
                    mSExcelActivateWorksheet["CreateIfMissing"] = CSharpExpressionConverter.ConvertToken(mSExcelActivateWorksheetcreateIfMissing);
                    mSExcelActivateWorksheetpropCount++;
                }

                mSExcelActivateWorksheetpropCount++;
            }
            else
            {
                mSExcelActivateWorksheet["CreateIfMissing"] = false;
                mSExcelActivateWorksheetpropCount++;
            }

            mSExcelActivateWorksheetpropCount++;
            mSExcelActivateWorksheet["Workflow"] = CSharpExpressionConverter.ConvertToken(mSExcelActivateWorksheetworkflow);
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
                if (mSExcelCreateWorksheethandle != null)
                {
                    mSExcelCreateWorksheet["Handle"] = CSharpExpressionConverter.ConvertToken(mSExcelCreateWorksheethandle);
                    mSExcelCreateWorksheetpropCount++;
                }

                mSExcelCreateWorksheetpropCount++;
            }
            else
            {
                mSExcelCreateWorksheet["Handle"] = 0;
                mSExcelCreateWorksheetpropCount++;
            }

            if (mSExcelCreateWorksheetworkbookName != null)
            {
                mSExcelCreateWorksheet["WorkbookName"] = CSharpExpressionConverter.ConvertToken(mSExcelCreateWorksheetworkbookName);
                mSExcelCreateWorksheetpropCount++;
            }

            if (mSExcelCreateWorksheetworksheetName != null)
            {
                mSExcelCreateWorksheet["WorksheetName"] = CSharpExpressionConverter.ConvertToken(mSExcelCreateWorksheetworksheetName);
                mSExcelCreateWorksheetpropCount++;
            }

            mSExcelCreateWorksheetpropCount++;
            mSExcelCreateWorksheet["Workflow"] = CSharpExpressionConverter.ConvertToken(mSExcelCreateWorksheetworkflow);
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
                if (mSExcelDeleteWorksheethandle != null)
                {
                    mSExcelDeleteWorksheet["Handle"] = CSharpExpressionConverter.ConvertToken(mSExcelDeleteWorksheethandle);
                    mSExcelDeleteWorksheetpropCount++;
                }

                mSExcelDeleteWorksheetpropCount++;
            }
            else
            {
                mSExcelDeleteWorksheet["Handle"] = 0;
                mSExcelDeleteWorksheetpropCount++;
            }

            if (mSExcelDeleteWorksheetworkbookName != null)
            {
                mSExcelDeleteWorksheet["WorkbookName"] = CSharpExpressionConverter.ConvertToken(mSExcelDeleteWorksheetworkbookName);
                mSExcelDeleteWorksheetpropCount++;
            }

            if (mSExcelDeleteWorksheetworksheetName != null)
            {
                mSExcelDeleteWorksheet["WorksheetName"] = CSharpExpressionConverter.ConvertToken(mSExcelDeleteWorksheetworksheetName);
                mSExcelDeleteWorksheetpropCount++;
            }

            mSExcelDeleteWorksheetpropCount++;
            mSExcelDeleteWorksheet["Workflow"] = CSharpExpressionConverter.ConvertToken(mSExcelDeleteWorksheetworkflow);
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
                if (mSExcelGetWorksheetAsCollectionEnhancedhandle != null)
                {
                    mSExcelGetWorksheetAsCollectionEnhanced["Handle"] = CSharpExpressionConverter.ConvertToken(mSExcelGetWorksheetAsCollectionEnhancedhandle);
                    mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
                }

                mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
            }
            else
            {
                mSExcelGetWorksheetAsCollectionEnhanced["Handle"] = 0;
                mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
            }

            if (mSExcelGetWorksheetAsCollectionEnhancedworkbookName != null)
            {
                mSExcelGetWorksheetAsCollectionEnhanced["WorkbookName"] = CSharpExpressionConverter.ConvertToken(mSExcelGetWorksheetAsCollectionEnhancedworkbookName);
                mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
            }

            if (mSExcelGetWorksheetAsCollectionEnhancedworksheetName != null)
            {
                mSExcelGetWorksheetAsCollectionEnhanced["WorksheetName"] = CSharpExpressionConverter.ConvertToken(mSExcelGetWorksheetAsCollectionEnhancedworksheetName);
                mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
            }

            if (mSExcelGetWorksheetAsCollectionEnhanceduseHeader != null)
            {
                if (mSExcelGetWorksheetAsCollectionEnhanceduseHeader != null)
                {
                    mSExcelGetWorksheetAsCollectionEnhanced["UseHeader"] = CSharpExpressionConverter.ConvertToken(mSExcelGetWorksheetAsCollectionEnhanceduseHeader);
                    mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
                }

                mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
            }
            else
            {
                mSExcelGetWorksheetAsCollectionEnhanced["UseHeader"] = true;
                mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
            }

            if (mSExcelGetWorksheetAsCollectionEnhancedstartCell != null)
            {
                mSExcelGetWorksheetAsCollectionEnhanced["StartCell"] = CSharpExpressionConverter.ConvertToken(mSExcelGetWorksheetAsCollectionEnhancedstartCell);
                mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
            }

            if (mSExcelGetWorksheetAsCollectionEnhancedmaximumColumnNumber != null)
            {
                if (mSExcelGetWorksheetAsCollectionEnhancedmaximumColumnNumber != null)
                {
                    mSExcelGetWorksheetAsCollectionEnhanced["MaximumColumnNumber"] = CSharpExpressionConverter.ConvertToken(mSExcelGetWorksheetAsCollectionEnhancedmaximumColumnNumber);
                    mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
                }

                mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
            }
            else
            {
                mSExcelGetWorksheetAsCollectionEnhanced["MaximumColumnNumber"] = 0;
                mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
            }

            if (mSExcelGetWorksheetAsCollectionEnhancedskipBlankRows != null)
            {
                if (mSExcelGetWorksheetAsCollectionEnhancedskipBlankRows != null)
                {
                    mSExcelGetWorksheetAsCollectionEnhanced["SkipBlankRows"] = CSharpExpressionConverter.ConvertToken(mSExcelGetWorksheetAsCollectionEnhancedskipBlankRows);
                    mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
                }

                mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
            }
            else
            {
                mSExcelGetWorksheetAsCollectionEnhanced["SkipBlankRows"] = true;
                mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
            }

            if (mSExcelGetWorksheetAsCollectionEnhancedskipColumnsWithNoHeader != null)
            {
                if (mSExcelGetWorksheetAsCollectionEnhancedskipColumnsWithNoHeader != null)
                {
                    mSExcelGetWorksheetAsCollectionEnhanced["SkipColumnsWithNoHeader"] = CSharpExpressionConverter.ConvertToken(mSExcelGetWorksheetAsCollectionEnhancedskipColumnsWithNoHeader);
                    mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
                }

                mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
            }
            else
            {
                mSExcelGetWorksheetAsCollectionEnhanced["SkipColumnsWithNoHeader"] = false;
                mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
            }

            if (mSExcelGetWorksheetAsCollectionEnhancedkeyColumn != null)
            {
                mSExcelGetWorksheetAsCollectionEnhanced["KeyColumn"] = CSharpExpressionConverter.ConvertToken(mSExcelGetWorksheetAsCollectionEnhancedkeyColumn);
                mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
            }

            if (mSExcelGetWorksheetAsCollectionEnhancedgetRawData != null)
            {
                if (mSExcelGetWorksheetAsCollectionEnhancedgetRawData != null)
                {
                    mSExcelGetWorksheetAsCollectionEnhanced["GetRawData"] = CSharpExpressionConverter.ConvertToken(mSExcelGetWorksheetAsCollectionEnhancedgetRawData);
                    mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
                }

                mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
            }
            else
            {
                mSExcelGetWorksheetAsCollectionEnhanced["GetRawData"] = true;
                mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
            }

            if (mSExcelGetWorksheetAsCollectionEnhancedignoreRowsWithLowCellCount != null)
            {
                if (mSExcelGetWorksheetAsCollectionEnhancedignoreRowsWithLowCellCount != null)
                {
                    mSExcelGetWorksheetAsCollectionEnhanced["IgnoreRowsWithLowCellCount"] = CSharpExpressionConverter.ConvertToken(mSExcelGetWorksheetAsCollectionEnhancedignoreRowsWithLowCellCount);
                    mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
                }

                mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
            }
            else
            {
                mSExcelGetWorksheetAsCollectionEnhanced["IgnoreRowsWithLowCellCount"] = 0;
                mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
            }

            if (mSExcelGetWorksheetAsCollectionEnhancedmaxConcurrentBlankRows != null)
            {
                if (mSExcelGetWorksheetAsCollectionEnhancedmaxConcurrentBlankRows != null)
                {
                    mSExcelGetWorksheetAsCollectionEnhanced["MaxConcurrentBlankRows"] = CSharpExpressionConverter.ConvertToken(mSExcelGetWorksheetAsCollectionEnhancedmaxConcurrentBlankRows);
                    mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
                }

                mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
            }
            else
            {
                mSExcelGetWorksheetAsCollectionEnhanced["MaxConcurrentBlankRows"] = -1;
                mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
            }

            if (mSExcelGetWorksheetAsCollectionEnhancedfirstDataRowToReturn != null)
            {
                if (mSExcelGetWorksheetAsCollectionEnhancedfirstDataRowToReturn != null)
                {
                    mSExcelGetWorksheetAsCollectionEnhanced["FirstDataRowToReturn"] = CSharpExpressionConverter.ConvertToken(mSExcelGetWorksheetAsCollectionEnhancedfirstDataRowToReturn);
                    mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
                }

                mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
            }
            else
            {
                mSExcelGetWorksheetAsCollectionEnhanced["FirstDataRowToReturn"] = 0;
                mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
            }

            if (mSExcelGetWorksheetAsCollectionEnhancedmaxNumberOfDataRowsToReturn != null)
            {
                if (mSExcelGetWorksheetAsCollectionEnhancedmaxNumberOfDataRowsToReturn != null)
                {
                    mSExcelGetWorksheetAsCollectionEnhanced["MaxNumberOfDataRowsToReturn"] = CSharpExpressionConverter.ConvertToken(mSExcelGetWorksheetAsCollectionEnhancedmaxNumberOfDataRowsToReturn);
                    mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
                }

                mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
            }
            else
            {
                mSExcelGetWorksheetAsCollectionEnhanced["MaxNumberOfDataRowsToReturn"] = 0;
                mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
            }

            mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
            mSExcelGetWorksheetAsCollectionEnhanced["Workflow"] = CSharpExpressionConverter.ConvertToken(mSExcelGetWorksheetAsCollectionEnhancedworkflow);
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
                if (mSExcelGetNumberOfRowshandle != null)
                {
                    mSExcelGetNumberOfRows["Handle"] = CSharpExpressionConverter.ConvertToken(mSExcelGetNumberOfRowshandle);
                    mSExcelGetNumberOfRowspropCount++;
                }

                mSExcelGetNumberOfRowspropCount++;
            }
            else
            {
                mSExcelGetNumberOfRows["Handle"] = 0;
                mSExcelGetNumberOfRowspropCount++;
            }

            if (mSExcelGetNumberOfRowsworkbookName != null)
            {
                mSExcelGetNumberOfRows["WorkbookName"] = CSharpExpressionConverter.ConvertToken(mSExcelGetNumberOfRowsworkbookName);
                mSExcelGetNumberOfRowspropCount++;
            }

            if (mSExcelGetNumberOfRowsworksheetName != null)
            {
                mSExcelGetNumberOfRows["WorksheetName"] = CSharpExpressionConverter.ConvertToken(mSExcelGetNumberOfRowsworksheetName);
                mSExcelGetNumberOfRowspropCount++;
            }

            mSExcelGetNumberOfRowspropCount++;
            mSExcelGetNumberOfRows["Workflow"] = CSharpExpressionConverter.ConvertToken(mSExcelGetNumberOfRowsworkflow);
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
                if (mSExcelEvaluateExpressionhandle != null)
                {
                    mSExcelEvaluateExpression["Handle"] = CSharpExpressionConverter.ConvertToken(mSExcelEvaluateExpressionhandle);
                    mSExcelEvaluateExpressionpropCount++;
                }

                mSExcelEvaluateExpressionpropCount++;
            }
            else
            {
                mSExcelEvaluateExpression["Handle"] = 0;
                mSExcelEvaluateExpressionpropCount++;
            }

            mSExcelEvaluateExpressionpropCount++;
            mSExcelEvaluateExpression["Expression"] = CSharpExpressionConverter.ConvertToken(mSExcelEvaluateExpressionexpression);
            mSExcelEvaluateExpressionpropCount++;
            mSExcelEvaluateExpression["Workflow"] = CSharpExpressionConverter.ConvertToken(mSExcelEvaluateExpressionworkflow);
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
                if (mSExcelGetWorksheetUsedRangehandle != null)
                {
                    mSExcelGetWorksheetUsedRange["Handle"] = CSharpExpressionConverter.ConvertToken(mSExcelGetWorksheetUsedRangehandle);
                    mSExcelGetWorksheetUsedRangepropCount++;
                }

                mSExcelGetWorksheetUsedRangepropCount++;
            }
            else
            {
                mSExcelGetWorksheetUsedRange["Handle"] = 0;
                mSExcelGetWorksheetUsedRangepropCount++;
            }

            if (mSExcelGetWorksheetUsedRangeworkbookName != null)
            {
                mSExcelGetWorksheetUsedRange["WorkbookName"] = CSharpExpressionConverter.ConvertToken(mSExcelGetWorksheetUsedRangeworkbookName);
                mSExcelGetWorksheetUsedRangepropCount++;
            }

            if (mSExcelGetWorksheetUsedRangeworksheetName != null)
            {
                mSExcelGetWorksheetUsedRange["WorksheetName"] = CSharpExpressionConverter.ConvertToken(mSExcelGetWorksheetUsedRangeworksheetName);
                mSExcelGetWorksheetUsedRangepropCount++;
            }

            mSExcelGetWorksheetUsedRangepropCount++;
            mSExcelGetWorksheetUsedRange["Workflow"] = CSharpExpressionConverter.ConvertToken(mSExcelGetWorksheetUsedRangeworkflow);
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
                if (mSExcelGetCountrySettinghandle != null)
                {
                    mSExcelGetCountrySetting["Handle"] = CSharpExpressionConverter.ConvertToken(mSExcelGetCountrySettinghandle);
                    mSExcelGetCountrySettingpropCount++;
                }

                mSExcelGetCountrySettingpropCount++;
            }
            else
            {
                mSExcelGetCountrySetting["Handle"] = 0;
                mSExcelGetCountrySettingpropCount++;
            }

            mSExcelGetCountrySettingpropCount++;
            mSExcelGetCountrySetting["Workflow"] = CSharpExpressionConverter.ConvertToken(mSExcelGetCountrySettingworkflow);
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
                if (mSExcelWriteCollectionhandle != null)
                {
                    mSExcelWriteCollection["Handle"] = CSharpExpressionConverter.ConvertToken(mSExcelWriteCollectionhandle);
                    mSExcelWriteCollectionpropCount++;
                }

                mSExcelWriteCollectionpropCount++;
            }
            else
            {
                mSExcelWriteCollection["Handle"] = 0;
                mSExcelWriteCollectionpropCount++;
            }

            if (mSExcelWriteCollectionworkbookName != null)
            {
                mSExcelWriteCollection["WorkbookName"] = CSharpExpressionConverter.ConvertToken(mSExcelWriteCollectionworkbookName);
                mSExcelWriteCollectionpropCount++;
            }

            if (mSExcelWriteCollectionworksheetName != null)
            {
                mSExcelWriteCollection["WorksheetName"] = CSharpExpressionConverter.ConvertToken(mSExcelWriteCollectionworksheetName);
                mSExcelWriteCollectionpropCount++;
            }

            mSExcelWriteCollectionpropCount++;
            mSExcelWriteCollection["CellReference"] = CSharpExpressionConverter.ConvertToken(mSExcelWriteCollectioncellReference);
            mSExcelWriteCollectionpropCount++;
            mSExcelWriteCollection["CollectionToWriteJSON"] = CSharpExpressionConverter.ConvertToken(mSExcelWriteCollectioncollectionToWriteJSON);
            if (mSExcelWriteCollectionincludeColumnNames != null)
            {
                if (mSExcelWriteCollectionincludeColumnNames != null)
                {
                    mSExcelWriteCollection["IncludeColumnNames"] = CSharpExpressionConverter.ConvertToken(mSExcelWriteCollectionincludeColumnNames);
                    mSExcelWriteCollectionpropCount++;
                }

                mSExcelWriteCollectionpropCount++;
            }
            else
            {
                mSExcelWriteCollection["IncludeColumnNames"] = false;
                mSExcelWriteCollectionpropCount++;
            }

            mSExcelWriteCollectionpropCount++;
            mSExcelWriteCollection["Workflow"] = CSharpExpressionConverter.ConvertToken(mSExcelWriteCollectionworkflow);
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
                if (mSExcelWriteCollectionWithDateshandle != null)
                {
                    mSExcelWriteCollectionWithDates["Handle"] = CSharpExpressionConverter.ConvertToken(mSExcelWriteCollectionWithDateshandle);
                    mSExcelWriteCollectionWithDatespropCount++;
                }

                mSExcelWriteCollectionWithDatespropCount++;
            }
            else
            {
                mSExcelWriteCollectionWithDates["Handle"] = 0;
                mSExcelWriteCollectionWithDatespropCount++;
            }

            if (mSExcelWriteCollectionWithDatesworkbookName != null)
            {
                mSExcelWriteCollectionWithDates["WorkbookName"] = CSharpExpressionConverter.ConvertToken(mSExcelWriteCollectionWithDatesworkbookName);
                mSExcelWriteCollectionWithDatespropCount++;
            }

            if (mSExcelWriteCollectionWithDatesworksheetName != null)
            {
                mSExcelWriteCollectionWithDates["WorksheetName"] = CSharpExpressionConverter.ConvertToken(mSExcelWriteCollectionWithDatesworksheetName);
                mSExcelWriteCollectionWithDatespropCount++;
            }

            mSExcelWriteCollectionWithDatespropCount++;
            mSExcelWriteCollectionWithDates["CellReference"] = CSharpExpressionConverter.ConvertToken(mSExcelWriteCollectionWithDatescellReference);
            mSExcelWriteCollectionWithDatespropCount++;
            mSExcelWriteCollectionWithDates["CollectionToWriteJSON"] = CSharpExpressionConverter.ConvertToken(mSExcelWriteCollectionWithDatescollectionToWriteJSON);
            if (mSExcelWriteCollectionWithDatesincludeColumnNames != null)
            {
                if (mSExcelWriteCollectionWithDatesincludeColumnNames != null)
                {
                    mSExcelWriteCollectionWithDates["IncludeColumnNames"] = CSharpExpressionConverter.ConvertToken(mSExcelWriteCollectionWithDatesincludeColumnNames);
                    mSExcelWriteCollectionWithDatespropCount++;
                }

                mSExcelWriteCollectionWithDatespropCount++;
            }
            else
            {
                mSExcelWriteCollectionWithDates["IncludeColumnNames"] = false;
                mSExcelWriteCollectionWithDatespropCount++;
            }

            if (mSExcelWriteCollectionWithDatestryToConvertAllFieldsToDate != null)
            {
                if (mSExcelWriteCollectionWithDatestryToConvertAllFieldsToDate != null)
                {
                    mSExcelWriteCollectionWithDates["TryToConvertAllFieldsToDate"] = CSharpExpressionConverter.ConvertToken(mSExcelWriteCollectionWithDatestryToConvertAllFieldsToDate);
                    mSExcelWriteCollectionWithDatespropCount++;
                }

                mSExcelWriteCollectionWithDatespropCount++;
            }
            else
            {
                mSExcelWriteCollectionWithDates["TryToConvertAllFieldsToDate"] = false;
                mSExcelWriteCollectionWithDatespropCount++;
            }

            if (mSExcelWriteCollectionWithDatescolumnsToConvertToDateJSON != null)
            {
                mSExcelWriteCollectionWithDates["ColumnsToConvertToDateJSON"] = CSharpExpressionConverter.ConvertToken(mSExcelWriteCollectionWithDatescolumnsToConvertToDateJSON);
                mSExcelWriteCollectionWithDatespropCount++;
            }

            mSExcelWriteCollectionWithDatespropCount++;
            mSExcelWriteCollectionWithDates["Workflow"] = CSharpExpressionConverter.ConvertToken(mSExcelWriteCollectionWithDatesworkflow);
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
                if (mSExcelGetActiveCellhandle != null)
                {
                    mSExcelGetActiveCell["Handle"] = CSharpExpressionConverter.ConvertToken(mSExcelGetActiveCellhandle);
                    mSExcelGetActiveCellpropCount++;
                }

                mSExcelGetActiveCellpropCount++;
            }
            else
            {
                mSExcelGetActiveCell["Handle"] = 0;
                mSExcelGetActiveCellpropCount++;
            }

            mSExcelGetActiveCellpropCount++;
            mSExcelGetActiveCell["Workflow"] = CSharpExpressionConverter.ConvertToken(mSExcelGetActiveCellworkflow);
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
                if (mSExcelFormatCellhandle != null)
                {
                    mSExcelFormatCell["Handle"] = CSharpExpressionConverter.ConvertToken(mSExcelFormatCellhandle);
                    mSExcelFormatCellpropCount++;
                }

                mSExcelFormatCellpropCount++;
            }
            else
            {
                mSExcelFormatCell["Handle"] = 0;
                mSExcelFormatCellpropCount++;
            }

            if (mSExcelFormatCellworkbookName != null)
            {
                mSExcelFormatCell["WorkbookName"] = CSharpExpressionConverter.ConvertToken(mSExcelFormatCellworkbookName);
                mSExcelFormatCellpropCount++;
            }

            if (mSExcelFormatCellworksheetName != null)
            {
                mSExcelFormatCell["WorksheetName"] = CSharpExpressionConverter.ConvertToken(mSExcelFormatCellworksheetName);
                mSExcelFormatCellpropCount++;
            }

            mSExcelFormatCellpropCount++;
            mSExcelFormatCell["CellReference"] = CSharpExpressionConverter.ConvertToken(mSExcelFormatCellcellReference);
            mSExcelFormatCellpropCount++;
            mSExcelFormatCell["CellFormat"] = CSharpExpressionConverter.ConvertToken(mSExcelFormatCellcellFormat);
            mSExcelFormatCellpropCount++;
            mSExcelFormatCell["Workflow"] = CSharpExpressionConverter.ConvertToken(mSExcelFormatCellworkflow);
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
                if (mSExcelFormatCurrentCellhandle != null)
                {
                    mSExcelFormatCurrentCell["Handle"] = CSharpExpressionConverter.ConvertToken(mSExcelFormatCurrentCellhandle);
                    mSExcelFormatCurrentCellpropCount++;
                }

                mSExcelFormatCurrentCellpropCount++;
            }
            else
            {
                mSExcelFormatCurrentCell["Handle"] = 0;
                mSExcelFormatCurrentCellpropCount++;
            }

            mSExcelFormatCurrentCellpropCount++;
            mSExcelFormatCurrentCell["CellFormat"] = CSharpExpressionConverter.ConvertToken(mSExcelFormatCurrentCellcellFormat);
            mSExcelFormatCurrentCellpropCount++;
            mSExcelFormatCurrentCell["Workflow"] = CSharpExpressionConverter.ConvertToken(mSExcelFormatCurrentCellworkflow);
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
                if (mSExcelSelectCellRangehandle != null)
                {
                    mSExcelSelectCellRange["Handle"] = CSharpExpressionConverter.ConvertToken(mSExcelSelectCellRangehandle);
                    mSExcelSelectCellRangepropCount++;
                }

                mSExcelSelectCellRangepropCount++;
            }
            else
            {
                mSExcelSelectCellRange["Handle"] = 0;
                mSExcelSelectCellRangepropCount++;
            }

            if (mSExcelSelectCellRangeworkbookName != null)
            {
                mSExcelSelectCellRange["WorkbookName"] = CSharpExpressionConverter.ConvertToken(mSExcelSelectCellRangeworkbookName);
                mSExcelSelectCellRangepropCount++;
            }

            if (mSExcelSelectCellRangeworksheetName != null)
            {
                mSExcelSelectCellRange["WorksheetName"] = CSharpExpressionConverter.ConvertToken(mSExcelSelectCellRangeworksheetName);
                mSExcelSelectCellRangepropCount++;
            }

            mSExcelSelectCellRangepropCount++;
            mSExcelSelectCellRange["CellReference"] = CSharpExpressionConverter.ConvertToken(mSExcelSelectCellRangecellReference);
            if (mSExcelSelectCellRangeentireRow != null)
            {
                if (mSExcelSelectCellRangeentireRow != null)
                {
                    mSExcelSelectCellRange["EntireRow"] = CSharpExpressionConverter.ConvertToken(mSExcelSelectCellRangeentireRow);
                    mSExcelSelectCellRangepropCount++;
                }

                mSExcelSelectCellRangepropCount++;
            }
            else
            {
                mSExcelSelectCellRange["EntireRow"] = false;
                mSExcelSelectCellRangepropCount++;
            }

            if (mSExcelSelectCellRangeentireColumn != null)
            {
                if (mSExcelSelectCellRangeentireColumn != null)
                {
                    mSExcelSelectCellRange["EntireColumn"] = CSharpExpressionConverter.ConvertToken(mSExcelSelectCellRangeentireColumn);
                    mSExcelSelectCellRangepropCount++;
                }

                mSExcelSelectCellRangepropCount++;
            }
            else
            {
                mSExcelSelectCellRange["EntireColumn"] = false;
                mSExcelSelectCellRangepropCount++;
            }

            mSExcelSelectCellRangepropCount++;
            mSExcelSelectCellRange["Workflow"] = CSharpExpressionConverter.ConvertToken(mSExcelSelectCellRangeworkflow);
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
                if (mSExcelCopySelectionhandle != null)
                {
                    mSExcelCopySelection["Handle"] = CSharpExpressionConverter.ConvertToken(mSExcelCopySelectionhandle);
                    mSExcelCopySelectionpropCount++;
                }

                mSExcelCopySelectionpropCount++;
            }
            else
            {
                mSExcelCopySelection["Handle"] = 0;
                mSExcelCopySelectionpropCount++;
            }

            if (mSExcelCopySelectionworkbookName != null)
            {
                mSExcelCopySelection["WorkbookName"] = CSharpExpressionConverter.ConvertToken(mSExcelCopySelectionworkbookName);
                mSExcelCopySelectionpropCount++;
            }

            if (mSExcelCopySelectionworksheetName != null)
            {
                mSExcelCopySelection["WorksheetName"] = CSharpExpressionConverter.ConvertToken(mSExcelCopySelectionworksheetName);
                mSExcelCopySelectionpropCount++;
            }

            if (mSExcelCopySelectioncellReference != null)
            {
                mSExcelCopySelection["CellReference"] = CSharpExpressionConverter.ConvertToken(mSExcelCopySelectioncellReference);
                mSExcelCopySelectionpropCount++;
            }

            if (mSExcelCopySelectionentireRow != null)
            {
                if (mSExcelCopySelectionentireRow != null)
                {
                    mSExcelCopySelection["EntireRow"] = CSharpExpressionConverter.ConvertToken(mSExcelCopySelectionentireRow);
                    mSExcelCopySelectionpropCount++;
                }

                mSExcelCopySelectionpropCount++;
            }
            else
            {
                mSExcelCopySelection["EntireRow"] = false;
                mSExcelCopySelectionpropCount++;
            }

            if (mSExcelCopySelectionentireColumn != null)
            {
                if (mSExcelCopySelectionentireColumn != null)
                {
                    mSExcelCopySelection["EntireColumn"] = CSharpExpressionConverter.ConvertToken(mSExcelCopySelectionentireColumn);
                    mSExcelCopySelectionpropCount++;
                }

                mSExcelCopySelectionpropCount++;
            }
            else
            {
                mSExcelCopySelection["EntireColumn"] = false;
                mSExcelCopySelectionpropCount++;
            }

            mSExcelCopySelectionpropCount++;
            mSExcelCopySelection["Workflow"] = CSharpExpressionConverter.ConvertToken(mSExcelCopySelectionworkflow);
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
                if (mSExcelCutSelectionhandle != null)
                {
                    mSExcelCutSelection["Handle"] = CSharpExpressionConverter.ConvertToken(mSExcelCutSelectionhandle);
                    mSExcelCutSelectionpropCount++;
                }

                mSExcelCutSelectionpropCount++;
            }
            else
            {
                mSExcelCutSelection["Handle"] = 0;
                mSExcelCutSelectionpropCount++;
            }

            if (mSExcelCutSelectionworkbookName != null)
            {
                mSExcelCutSelection["WorkbookName"] = CSharpExpressionConverter.ConvertToken(mSExcelCutSelectionworkbookName);
                mSExcelCutSelectionpropCount++;
            }

            if (mSExcelCutSelectionworksheetName != null)
            {
                mSExcelCutSelection["WorksheetName"] = CSharpExpressionConverter.ConvertToken(mSExcelCutSelectionworksheetName);
                mSExcelCutSelectionpropCount++;
            }

            if (mSExcelCutSelectioncellReference != null)
            {
                mSExcelCutSelection["CellReference"] = CSharpExpressionConverter.ConvertToken(mSExcelCutSelectioncellReference);
                mSExcelCutSelectionpropCount++;
            }

            if (mSExcelCutSelectionentireRow != null)
            {
                if (mSExcelCutSelectionentireRow != null)
                {
                    mSExcelCutSelection["EntireRow"] = CSharpExpressionConverter.ConvertToken(mSExcelCutSelectionentireRow);
                    mSExcelCutSelectionpropCount++;
                }

                mSExcelCutSelectionpropCount++;
            }
            else
            {
                mSExcelCutSelection["EntireRow"] = false;
                mSExcelCutSelectionpropCount++;
            }

            if (mSExcelCutSelectionentireColumn != null)
            {
                if (mSExcelCutSelectionentireColumn != null)
                {
                    mSExcelCutSelection["EntireColumn"] = CSharpExpressionConverter.ConvertToken(mSExcelCutSelectionentireColumn);
                    mSExcelCutSelectionpropCount++;
                }

                mSExcelCutSelectionpropCount++;
            }
            else
            {
                mSExcelCutSelection["EntireColumn"] = false;
                mSExcelCutSelectionpropCount++;
            }

            mSExcelCutSelectionpropCount++;
            mSExcelCutSelection["Workflow"] = CSharpExpressionConverter.ConvertToken(mSExcelCutSelectionworkflow);
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
                if (mSExcelPasteIntoSelectionhandle != null)
                {
                    mSExcelPasteIntoSelection["Handle"] = CSharpExpressionConverter.ConvertToken(mSExcelPasteIntoSelectionhandle);
                    mSExcelPasteIntoSelectionpropCount++;
                }

                mSExcelPasteIntoSelectionpropCount++;
            }
            else
            {
                mSExcelPasteIntoSelection["Handle"] = 0;
                mSExcelPasteIntoSelectionpropCount++;
            }

            if (mSExcelPasteIntoSelectionworkbookName != null)
            {
                mSExcelPasteIntoSelection["WorkbookName"] = CSharpExpressionConverter.ConvertToken(mSExcelPasteIntoSelectionworkbookName);
                mSExcelPasteIntoSelectionpropCount++;
            }

            if (mSExcelPasteIntoSelectionworksheetName != null)
            {
                mSExcelPasteIntoSelection["WorksheetName"] = CSharpExpressionConverter.ConvertToken(mSExcelPasteIntoSelectionworksheetName);
                mSExcelPasteIntoSelectionpropCount++;
            }

            if (mSExcelPasteIntoSelectionvaluesOnly != null)
            {
                if (mSExcelPasteIntoSelectionvaluesOnly != null)
                {
                    mSExcelPasteIntoSelection["ValuesOnly"] = CSharpExpressionConverter.ConvertToken(mSExcelPasteIntoSelectionvaluesOnly);
                    mSExcelPasteIntoSelectionpropCount++;
                }

                mSExcelPasteIntoSelectionpropCount++;
            }
            else
            {
                mSExcelPasteIntoSelection["ValuesOnly"] = false;
                mSExcelPasteIntoSelectionpropCount++;
            }

            if (mSExcelPasteIntoSelectionsimplePasteOnly != null)
            {
                if (mSExcelPasteIntoSelectionsimplePasteOnly != null)
                {
                    mSExcelPasteIntoSelection["SimplePasteOnly"] = CSharpExpressionConverter.ConvertToken(mSExcelPasteIntoSelectionsimplePasteOnly);
                    mSExcelPasteIntoSelectionpropCount++;
                }

                mSExcelPasteIntoSelectionpropCount++;
            }
            else
            {
                mSExcelPasteIntoSelection["SimplePasteOnly"] = false;
                mSExcelPasteIntoSelectionpropCount++;
            }

            if (mSExcelPasteIntoSelectioncellReference != null)
            {
                mSExcelPasteIntoSelection["CellReference"] = CSharpExpressionConverter.ConvertToken(mSExcelPasteIntoSelectioncellReference);
                mSExcelPasteIntoSelectionpropCount++;
            }

            if (mSExcelPasteIntoSelectionentireRow != null)
            {
                if (mSExcelPasteIntoSelectionentireRow != null)
                {
                    mSExcelPasteIntoSelection["EntireRow"] = CSharpExpressionConverter.ConvertToken(mSExcelPasteIntoSelectionentireRow);
                    mSExcelPasteIntoSelectionpropCount++;
                }

                mSExcelPasteIntoSelectionpropCount++;
            }
            else
            {
                mSExcelPasteIntoSelection["EntireRow"] = false;
                mSExcelPasteIntoSelectionpropCount++;
            }

            if (mSExcelPasteIntoSelectionentireColumn != null)
            {
                if (mSExcelPasteIntoSelectionentireColumn != null)
                {
                    mSExcelPasteIntoSelection["EntireColumn"] = CSharpExpressionConverter.ConvertToken(mSExcelPasteIntoSelectionentireColumn);
                    mSExcelPasteIntoSelectionpropCount++;
                }

                mSExcelPasteIntoSelectionpropCount++;
            }
            else
            {
                mSExcelPasteIntoSelection["EntireColumn"] = false;
                mSExcelPasteIntoSelectionpropCount++;
            }

            mSExcelPasteIntoSelectionpropCount++;
            mSExcelPasteIntoSelection["Workflow"] = CSharpExpressionConverter.ConvertToken(mSExcelPasteIntoSelectionworkflow);
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
                if (mSExcelInsertOnSelectionhandle != null)
                {
                    mSExcelInsertOnSelection["Handle"] = CSharpExpressionConverter.ConvertToken(mSExcelInsertOnSelectionhandle);
                    mSExcelInsertOnSelectionpropCount++;
                }

                mSExcelInsertOnSelectionpropCount++;
            }
            else
            {
                mSExcelInsertOnSelection["Handle"] = 0;
                mSExcelInsertOnSelectionpropCount++;
            }

            if (mSExcelInsertOnSelectionworkbookName != null)
            {
                mSExcelInsertOnSelection["WorkbookName"] = CSharpExpressionConverter.ConvertToken(mSExcelInsertOnSelectionworkbookName);
                mSExcelInsertOnSelectionpropCount++;
            }

            if (mSExcelInsertOnSelectionworksheetName != null)
            {
                mSExcelInsertOnSelection["WorksheetName"] = CSharpExpressionConverter.ConvertToken(mSExcelInsertOnSelectionworksheetName);
                mSExcelInsertOnSelectionpropCount++;
            }

            if (mSExcelInsertOnSelectioncellReference != null)
            {
                mSExcelInsertOnSelection["CellReference"] = CSharpExpressionConverter.ConvertToken(mSExcelInsertOnSelectioncellReference);
                mSExcelInsertOnSelectionpropCount++;
            }

            if (mSExcelInsertOnSelectionentireRow != null)
            {
                if (mSExcelInsertOnSelectionentireRow != null)
                {
                    mSExcelInsertOnSelection["EntireRow"] = CSharpExpressionConverter.ConvertToken(mSExcelInsertOnSelectionentireRow);
                    mSExcelInsertOnSelectionpropCount++;
                }

                mSExcelInsertOnSelectionpropCount++;
            }
            else
            {
                mSExcelInsertOnSelection["EntireRow"] = false;
                mSExcelInsertOnSelectionpropCount++;
            }

            if (mSExcelInsertOnSelectionentireColumn != null)
            {
                if (mSExcelInsertOnSelectionentireColumn != null)
                {
                    mSExcelInsertOnSelection["EntireColumn"] = CSharpExpressionConverter.ConvertToken(mSExcelInsertOnSelectionentireColumn);
                    mSExcelInsertOnSelectionpropCount++;
                }

                mSExcelInsertOnSelectionpropCount++;
            }
            else
            {
                mSExcelInsertOnSelection["EntireColumn"] = false;
                mSExcelInsertOnSelectionpropCount++;
            }

            if (mSExcelInsertOnSelectionshift != null)
            {
                mSExcelInsertOnSelection["Shift"] = CSharpExpressionConverter.Convert(mSExcelInsertOnSelectionshift);
                mSExcelInsertOnSelectionpropCount++;
            }

            mSExcelInsertOnSelectionpropCount++;
            mSExcelInsertOnSelection["Workflow"] = CSharpExpressionConverter.ConvertToken(mSExcelInsertOnSelectionworkflow);
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
                if (mSExcelDeleteSelectionhandle != null)
                {
                    mSExcelDeleteSelection["Handle"] = CSharpExpressionConverter.ConvertToken(mSExcelDeleteSelectionhandle);
                    mSExcelDeleteSelectionpropCount++;
                }

                mSExcelDeleteSelectionpropCount++;
            }
            else
            {
                mSExcelDeleteSelection["Handle"] = 0;
                mSExcelDeleteSelectionpropCount++;
            }

            if (mSExcelDeleteSelectionworkbookName != null)
            {
                mSExcelDeleteSelection["WorkbookName"] = CSharpExpressionConverter.ConvertToken(mSExcelDeleteSelectionworkbookName);
                mSExcelDeleteSelectionpropCount++;
            }

            if (mSExcelDeleteSelectionworksheetName != null)
            {
                mSExcelDeleteSelection["WorksheetName"] = CSharpExpressionConverter.ConvertToken(mSExcelDeleteSelectionworksheetName);
                mSExcelDeleteSelectionpropCount++;
            }

            if (mSExcelDeleteSelectioncellReference != null)
            {
                mSExcelDeleteSelection["CellReference"] = CSharpExpressionConverter.ConvertToken(mSExcelDeleteSelectioncellReference);
                mSExcelDeleteSelectionpropCount++;
            }

            if (mSExcelDeleteSelectionentireRow != null)
            {
                if (mSExcelDeleteSelectionentireRow != null)
                {
                    mSExcelDeleteSelection["EntireRow"] = CSharpExpressionConverter.ConvertToken(mSExcelDeleteSelectionentireRow);
                    mSExcelDeleteSelectionpropCount++;
                }

                mSExcelDeleteSelectionpropCount++;
            }
            else
            {
                mSExcelDeleteSelection["EntireRow"] = false;
                mSExcelDeleteSelectionpropCount++;
            }

            if (mSExcelDeleteSelectionentireColumn != null)
            {
                if (mSExcelDeleteSelectionentireColumn != null)
                {
                    mSExcelDeleteSelection["EntireColumn"] = CSharpExpressionConverter.ConvertToken(mSExcelDeleteSelectionentireColumn);
                    mSExcelDeleteSelectionpropCount++;
                }

                mSExcelDeleteSelectionpropCount++;
            }
            else
            {
                mSExcelDeleteSelection["EntireColumn"] = false;
                mSExcelDeleteSelectionpropCount++;
            }

            if (mSExcelDeleteSelectionshift != null)
            {
                mSExcelDeleteSelection["Shift"] = CSharpExpressionConverter.Convert(mSExcelDeleteSelectionshift);
                mSExcelDeleteSelectionpropCount++;
            }

            mSExcelDeleteSelectionpropCount++;
            mSExcelDeleteSelection["Workflow"] = CSharpExpressionConverter.ConvertToken(mSExcelDeleteSelectionworkflow);
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
                if (mSExcelClearExcelClipboardhandle != null)
                {
                    mSExcelClearExcelClipboard["Handle"] = CSharpExpressionConverter.ConvertToken(mSExcelClearExcelClipboardhandle);
                    mSExcelClearExcelClipboardpropCount++;
                }

                mSExcelClearExcelClipboardpropCount++;
            }
            else
            {
                mSExcelClearExcelClipboard["Handle"] = 0;
                mSExcelClearExcelClipboardpropCount++;
            }

            mSExcelClearExcelClipboardpropCount++;
            mSExcelClearExcelClipboard["Workflow"] = CSharpExpressionConverter.ConvertToken(mSExcelClearExcelClipboardworkflow);
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
                if (mSExcelRunMacrohandle != null)
                {
                    mSExcelRunMacro["Handle"] = CSharpExpressionConverter.ConvertToken(mSExcelRunMacrohandle);
                    mSExcelRunMacropropCount++;
                }

                mSExcelRunMacropropCount++;
            }
            else
            {
                mSExcelRunMacro["Handle"] = 0;
                mSExcelRunMacropropCount++;
            }

            mSExcelRunMacropropCount++;
            mSExcelRunMacro["MacroName"] = CSharpExpressionConverter.ConvertToken(mSExcelRunMacromacroName);
            if (mSExcelRunMacronumberOfArguments != null)
            {
                mSExcelRunMacro["NumberOfArguments"] = CSharpExpressionConverter.ConvertToken(mSExcelRunMacronumberOfArguments);
                mSExcelRunMacropropCount++;
            }

            if (mSExcelRunMacroargument1 != null)
            {
                mSExcelRunMacro["Argument1"] = CSharpExpressionConverter.ConvertToken(mSExcelRunMacroargument1);
                mSExcelRunMacropropCount++;
            }

            if (mSExcelRunMacroargument2 != null)
            {
                mSExcelRunMacro["Argument2"] = CSharpExpressionConverter.ConvertToken(mSExcelRunMacroargument2);
                mSExcelRunMacropropCount++;
            }

            if (mSExcelRunMacroargument3 != null)
            {
                mSExcelRunMacro["Argument3"] = CSharpExpressionConverter.ConvertToken(mSExcelRunMacroargument3);
                mSExcelRunMacropropCount++;
            }

            if (mSExcelRunMacroargument4 != null)
            {
                mSExcelRunMacro["Argument4"] = CSharpExpressionConverter.ConvertToken(mSExcelRunMacroargument4);
                mSExcelRunMacropropCount++;
            }

            if (mSExcelRunMacroargument5 != null)
            {
                mSExcelRunMacro["Argument5"] = CSharpExpressionConverter.ConvertToken(mSExcelRunMacroargument5);
                mSExcelRunMacropropCount++;
            }

            if (mSExcelRunMacroargument6 != null)
            {
                mSExcelRunMacro["Argument6"] = CSharpExpressionConverter.ConvertToken(mSExcelRunMacroargument6);
                mSExcelRunMacropropCount++;
            }

            if (mSExcelRunMacroargument7 != null)
            {
                mSExcelRunMacro["Argument7"] = CSharpExpressionConverter.ConvertToken(mSExcelRunMacroargument7);
                mSExcelRunMacropropCount++;
            }

            if (mSExcelRunMacroargument8 != null)
            {
                mSExcelRunMacro["Argument8"] = CSharpExpressionConverter.ConvertToken(mSExcelRunMacroargument8);
                mSExcelRunMacropropCount++;
            }

            if (mSExcelRunMacroargument9 != null)
            {
                mSExcelRunMacro["Argument9"] = CSharpExpressionConverter.ConvertToken(mSExcelRunMacroargument9);
                mSExcelRunMacropropCount++;
            }

            if (mSExcelRunMacroargument10 != null)
            {
                mSExcelRunMacro["Argument10"] = CSharpExpressionConverter.ConvertToken(mSExcelRunMacroargument10);
                mSExcelRunMacropropCount++;
            }

            if (mSExcelRunMacrorunInBackground != null)
            {
                if (mSExcelRunMacrorunInBackground != null)
                {
                    mSExcelRunMacro["RunInBackground"] = CSharpExpressionConverter.ConvertToken(mSExcelRunMacrorunInBackground);
                    mSExcelRunMacropropCount++;
                }

                mSExcelRunMacropropCount++;
            }
            else
            {
                mSExcelRunMacro["RunInBackground"] = false;
                mSExcelRunMacropropCount++;
            }

            mSExcelRunMacropropCount++;
            mSExcelRunMacro["Workflow"] = CSharpExpressionConverter.ConvertToken(mSExcelRunMacroworkflow);
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
                if (mSExcelAddMacroToWorkbookhandle != null)
                {
                    mSExcelAddMacroToWorkbook["Handle"] = CSharpExpressionConverter.ConvertToken(mSExcelAddMacroToWorkbookhandle);
                    mSExcelAddMacroToWorkbookpropCount++;
                }

                mSExcelAddMacroToWorkbookpropCount++;
            }
            else
            {
                mSExcelAddMacroToWorkbook["Handle"] = 0;
                mSExcelAddMacroToWorkbookpropCount++;
            }

            if (mSExcelAddMacroToWorkbookworkbookName != null)
            {
                mSExcelAddMacroToWorkbook["WorkbookName"] = CSharpExpressionConverter.ConvertToken(mSExcelAddMacroToWorkbookworkbookName);
                mSExcelAddMacroToWorkbookpropCount++;
            }

            mSExcelAddMacroToWorkbookpropCount++;
            mSExcelAddMacroToWorkbook["MacroCode"] = CSharpExpressionConverter.ConvertToken(mSExcelAddMacroToWorkbookmacroCode);
            mSExcelAddMacroToWorkbookpropCount++;
            mSExcelAddMacroToWorkbook["Workflow"] = CSharpExpressionConverter.ConvertToken(mSExcelAddMacroToWorkbookworkflow);
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
                mSExcelTrustVBOMInRegistry["ExcelVersion"] = CSharpExpressionConverter.ConvertToken(mSExcelTrustVBOMInRegistryexcelVersion);
                mSExcelTrustVBOMInRegistrypropCount++;
            }

            if (mSExcelTrustVBOMInRegistrytrustVBOM != null)
            {
                if (mSExcelTrustVBOMInRegistrytrustVBOM != null)
                {
                    mSExcelTrustVBOMInRegistry["TrustVBOM"] = CSharpExpressionConverter.ConvertToken(mSExcelTrustVBOMInRegistrytrustVBOM);
                    mSExcelTrustVBOMInRegistrypropCount++;
                }

                mSExcelTrustVBOMInRegistrypropCount++;
            }
            else
            {
                mSExcelTrustVBOMInRegistry["TrustVBOM"] = true;
                mSExcelTrustVBOMInRegistrypropCount++;
            }

            mSExcelTrustVBOMInRegistrypropCount++;
            mSExcelTrustVBOMInRegistry["Workflow"] = CSharpExpressionConverter.ConvertToken(mSExcelTrustVBOMInRegistryworkflow);
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
                if (mSExcelSetCalculationModehandle != null)
                {
                    mSExcelSetCalculationMode["Handle"] = CSharpExpressionConverter.ConvertToken(mSExcelSetCalculationModehandle);
                    mSExcelSetCalculationModepropCount++;
                }

                mSExcelSetCalculationModepropCount++;
            }
            else
            {
                mSExcelSetCalculationMode["Handle"] = 0;
                mSExcelSetCalculationModepropCount++;
            }

            mSExcelSetCalculationModepropCount++;
            mSExcelSetCalculationMode["CalculationMode"] = CSharpExpressionConverter.ConvertToken(mSExcelSetCalculationModecalculationMode);
            mSExcelSetCalculationModepropCount++;
            mSExcelSetCalculationMode["Workflow"] = CSharpExpressionConverter.ConvertToken(mSExcelSetCalculationModeworkflow);
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
                if (mSExcelExecuteCommandBarObjecthandle != null)
                {
                    mSExcelExecuteCommandBarObject["Handle"] = CSharpExpressionConverter.ConvertToken(mSExcelExecuteCommandBarObjecthandle);
                    mSExcelExecuteCommandBarObjectpropCount++;
                }

                mSExcelExecuteCommandBarObjectpropCount++;
            }
            else
            {
                mSExcelExecuteCommandBarObject["Handle"] = 0;
                mSExcelExecuteCommandBarObjectpropCount++;
            }

            mSExcelExecuteCommandBarObjectpropCount++;
            mSExcelExecuteCommandBarObject["ObjectId"] = CSharpExpressionConverter.ConvertToken(mSExcelExecuteCommandBarObjectobjectId);
            if (mSExcelExecuteCommandBarObjectrunInBackground != null)
            {
                if (mSExcelExecuteCommandBarObjectrunInBackground != null)
                {
                    mSExcelExecuteCommandBarObject["RunInBackground"] = CSharpExpressionConverter.ConvertToken(mSExcelExecuteCommandBarObjectrunInBackground);
                    mSExcelExecuteCommandBarObjectpropCount++;
                }

                mSExcelExecuteCommandBarObjectpropCount++;
            }
            else
            {
                mSExcelExecuteCommandBarObject["RunInBackground"] = false;
                mSExcelExecuteCommandBarObjectpropCount++;
            }

            mSExcelExecuteCommandBarObjectpropCount++;
            mSExcelExecuteCommandBarObject["Workflow"] = CSharpExpressionConverter.ConvertToken(mSExcelExecuteCommandBarObjectworkflow);
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
                if (mSExcelCopyBetweenCellssourceHandle != null)
                {
                    mSExcelCopyBetweenCells["SourceHandle"] = CSharpExpressionConverter.ConvertToken(mSExcelCopyBetweenCellssourceHandle);
                    mSExcelCopyBetweenCellspropCount++;
                }

                mSExcelCopyBetweenCellspropCount++;
            }
            else
            {
                mSExcelCopyBetweenCells["SourceHandle"] = 0;
                mSExcelCopyBetweenCellspropCount++;
            }

            if (mSExcelCopyBetweenCellssourceWorkbookName != null)
            {
                mSExcelCopyBetweenCells["SourceWorkbookName"] = CSharpExpressionConverter.ConvertToken(mSExcelCopyBetweenCellssourceWorkbookName);
                mSExcelCopyBetweenCellspropCount++;
            }

            if (mSExcelCopyBetweenCellssourceWorksheetName != null)
            {
                mSExcelCopyBetweenCells["SourceWorksheetName"] = CSharpExpressionConverter.ConvertToken(mSExcelCopyBetweenCellssourceWorksheetName);
                mSExcelCopyBetweenCellspropCount++;
            }

            mSExcelCopyBetweenCellspropCount++;
            mSExcelCopyBetweenCells["SourceCellReference"] = CSharpExpressionConverter.ConvertToken(mSExcelCopyBetweenCellssourceCellReference);
            if (mSExcelCopyBetweenCellssourceEntireRow != null)
            {
                if (mSExcelCopyBetweenCellssourceEntireRow != null)
                {
                    mSExcelCopyBetweenCells["SourceEntireRow"] = CSharpExpressionConverter.ConvertToken(mSExcelCopyBetweenCellssourceEntireRow);
                    mSExcelCopyBetweenCellspropCount++;
                }

                mSExcelCopyBetweenCellspropCount++;
            }
            else
            {
                mSExcelCopyBetweenCells["SourceEntireRow"] = false;
                mSExcelCopyBetweenCellspropCount++;
            }

            if (mSExcelCopyBetweenCellssourceEntireColumn != null)
            {
                if (mSExcelCopyBetweenCellssourceEntireColumn != null)
                {
                    mSExcelCopyBetweenCells["SourceEntireColumn"] = CSharpExpressionConverter.ConvertToken(mSExcelCopyBetweenCellssourceEntireColumn);
                    mSExcelCopyBetweenCellspropCount++;
                }

                mSExcelCopyBetweenCellspropCount++;
            }
            else
            {
                mSExcelCopyBetweenCells["SourceEntireColumn"] = false;
                mSExcelCopyBetweenCellspropCount++;
            }

            if (mSExcelCopyBetweenCellstargetHandle != null)
            {
                if (mSExcelCopyBetweenCellstargetHandle != null)
                {
                    mSExcelCopyBetweenCells["TargetHandle"] = CSharpExpressionConverter.ConvertToken(mSExcelCopyBetweenCellstargetHandle);
                    mSExcelCopyBetweenCellspropCount++;
                }

                mSExcelCopyBetweenCellspropCount++;
            }
            else
            {
                mSExcelCopyBetweenCells["TargetHandle"] = 0;
                mSExcelCopyBetweenCellspropCount++;
            }

            if (mSExcelCopyBetweenCellstargetWorkbookName != null)
            {
                mSExcelCopyBetweenCells["TargetWorkbookName"] = CSharpExpressionConverter.ConvertToken(mSExcelCopyBetweenCellstargetWorkbookName);
                mSExcelCopyBetweenCellspropCount++;
            }

            if (mSExcelCopyBetweenCellstargetWorksheetName != null)
            {
                mSExcelCopyBetweenCells["TargetWorksheetName"] = CSharpExpressionConverter.ConvertToken(mSExcelCopyBetweenCellstargetWorksheetName);
                mSExcelCopyBetweenCellspropCount++;
            }

            mSExcelCopyBetweenCellspropCount++;
            mSExcelCopyBetweenCells["TargetCellReference"] = CSharpExpressionConverter.ConvertToken(mSExcelCopyBetweenCellstargetCellReference);
            if (mSExcelCopyBetweenCellstargetEntireRow != null)
            {
                if (mSExcelCopyBetweenCellstargetEntireRow != null)
                {
                    mSExcelCopyBetweenCells["TargetEntireRow"] = CSharpExpressionConverter.ConvertToken(mSExcelCopyBetweenCellstargetEntireRow);
                    mSExcelCopyBetweenCellspropCount++;
                }

                mSExcelCopyBetweenCellspropCount++;
            }
            else
            {
                mSExcelCopyBetweenCells["TargetEntireRow"] = false;
                mSExcelCopyBetweenCellspropCount++;
            }

            if (mSExcelCopyBetweenCellstargetEntireColumn != null)
            {
                if (mSExcelCopyBetweenCellstargetEntireColumn != null)
                {
                    mSExcelCopyBetweenCells["TargetEntireColumn"] = CSharpExpressionConverter.ConvertToken(mSExcelCopyBetweenCellstargetEntireColumn);
                    mSExcelCopyBetweenCellspropCount++;
                }

                mSExcelCopyBetweenCellspropCount++;
            }
            else
            {
                mSExcelCopyBetweenCells["TargetEntireColumn"] = false;
                mSExcelCopyBetweenCellspropCount++;
            }

            if (mSExcelCopyBetweenCellsvaluesOnly != null)
            {
                if (mSExcelCopyBetweenCellsvaluesOnly != null)
                {
                    mSExcelCopyBetweenCells["ValuesOnly"] = CSharpExpressionConverter.ConvertToken(mSExcelCopyBetweenCellsvaluesOnly);
                    mSExcelCopyBetweenCellspropCount++;
                }

                mSExcelCopyBetweenCellspropCount++;
            }
            else
            {
                mSExcelCopyBetweenCells["ValuesOnly"] = false;
                mSExcelCopyBetweenCellspropCount++;
            }

            if (mSExcelCopyBetweenCellssimplePasteOnly != null)
            {
                if (mSExcelCopyBetweenCellssimplePasteOnly != null)
                {
                    mSExcelCopyBetweenCells["SimplePasteOnly"] = CSharpExpressionConverter.ConvertToken(mSExcelCopyBetweenCellssimplePasteOnly);
                    mSExcelCopyBetweenCellspropCount++;
                }

                mSExcelCopyBetweenCellspropCount++;
            }
            else
            {
                mSExcelCopyBetweenCells["SimplePasteOnly"] = false;
                mSExcelCopyBetweenCellspropCount++;
            }

            mSExcelCopyBetweenCellspropCount++;
            mSExcelCopyBetweenCells["Workflow"] = CSharpExpressionConverter.ConvertToken(mSExcelCopyBetweenCellsworkflow);
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
                if (mSExcelCutBetweenCellssourceHandle != null)
                {
                    mSExcelCutBetweenCells["SourceHandle"] = CSharpExpressionConverter.ConvertToken(mSExcelCutBetweenCellssourceHandle);
                    mSExcelCutBetweenCellspropCount++;
                }

                mSExcelCutBetweenCellspropCount++;
            }
            else
            {
                mSExcelCutBetweenCells["SourceHandle"] = 0;
                mSExcelCutBetweenCellspropCount++;
            }

            if (mSExcelCutBetweenCellssourceWorkbookName != null)
            {
                mSExcelCutBetweenCells["SourceWorkbookName"] = CSharpExpressionConverter.ConvertToken(mSExcelCutBetweenCellssourceWorkbookName);
                mSExcelCutBetweenCellspropCount++;
            }

            if (mSExcelCutBetweenCellssourceWorksheetName != null)
            {
                mSExcelCutBetweenCells["SourceWorksheetName"] = CSharpExpressionConverter.ConvertToken(mSExcelCutBetweenCellssourceWorksheetName);
                mSExcelCutBetweenCellspropCount++;
            }

            mSExcelCutBetweenCellspropCount++;
            mSExcelCutBetweenCells["SourceCellReference"] = CSharpExpressionConverter.ConvertToken(mSExcelCutBetweenCellssourceCellReference);
            if (mSExcelCutBetweenCellssourceEntireRow != null)
            {
                if (mSExcelCutBetweenCellssourceEntireRow != null)
                {
                    mSExcelCutBetweenCells["SourceEntireRow"] = CSharpExpressionConverter.ConvertToken(mSExcelCutBetweenCellssourceEntireRow);
                    mSExcelCutBetweenCellspropCount++;
                }

                mSExcelCutBetweenCellspropCount++;
            }
            else
            {
                mSExcelCutBetweenCells["SourceEntireRow"] = false;
                mSExcelCutBetweenCellspropCount++;
            }

            if (mSExcelCutBetweenCellssourceEntireColumn != null)
            {
                if (mSExcelCutBetweenCellssourceEntireColumn != null)
                {
                    mSExcelCutBetweenCells["SourceEntireColumn"] = CSharpExpressionConverter.ConvertToken(mSExcelCutBetweenCellssourceEntireColumn);
                    mSExcelCutBetweenCellspropCount++;
                }

                mSExcelCutBetweenCellspropCount++;
            }
            else
            {
                mSExcelCutBetweenCells["SourceEntireColumn"] = false;
                mSExcelCutBetweenCellspropCount++;
            }

            if (mSExcelCutBetweenCellstargetHandle != null)
            {
                if (mSExcelCutBetweenCellstargetHandle != null)
                {
                    mSExcelCutBetweenCells["TargetHandle"] = CSharpExpressionConverter.ConvertToken(mSExcelCutBetweenCellstargetHandle);
                    mSExcelCutBetweenCellspropCount++;
                }

                mSExcelCutBetweenCellspropCount++;
            }
            else
            {
                mSExcelCutBetweenCells["TargetHandle"] = 0;
                mSExcelCutBetweenCellspropCount++;
            }

            if (mSExcelCutBetweenCellstargetWorkbookName != null)
            {
                mSExcelCutBetweenCells["TargetWorkbookName"] = CSharpExpressionConverter.ConvertToken(mSExcelCutBetweenCellstargetWorkbookName);
                mSExcelCutBetweenCellspropCount++;
            }

            if (mSExcelCutBetweenCellstargetWorksheetName != null)
            {
                mSExcelCutBetweenCells["TargetWorksheetName"] = CSharpExpressionConverter.ConvertToken(mSExcelCutBetweenCellstargetWorksheetName);
                mSExcelCutBetweenCellspropCount++;
            }

            mSExcelCutBetweenCellspropCount++;
            mSExcelCutBetweenCells["TargetCellReference"] = CSharpExpressionConverter.ConvertToken(mSExcelCutBetweenCellstargetCellReference);
            if (mSExcelCutBetweenCellstargetEntireRow != null)
            {
                if (mSExcelCutBetweenCellstargetEntireRow != null)
                {
                    mSExcelCutBetweenCells["TargetEntireRow"] = CSharpExpressionConverter.ConvertToken(mSExcelCutBetweenCellstargetEntireRow);
                    mSExcelCutBetweenCellspropCount++;
                }

                mSExcelCutBetweenCellspropCount++;
            }
            else
            {
                mSExcelCutBetweenCells["TargetEntireRow"] = false;
                mSExcelCutBetweenCellspropCount++;
            }

            if (mSExcelCutBetweenCellstargetEntireColumn != null)
            {
                if (mSExcelCutBetweenCellstargetEntireColumn != null)
                {
                    mSExcelCutBetweenCells["TargetEntireColumn"] = CSharpExpressionConverter.ConvertToken(mSExcelCutBetweenCellstargetEntireColumn);
                    mSExcelCutBetweenCellspropCount++;
                }

                mSExcelCutBetweenCellspropCount++;
            }
            else
            {
                mSExcelCutBetweenCells["TargetEntireColumn"] = false;
                mSExcelCutBetweenCellspropCount++;
            }

            if (mSExcelCutBetweenCellsvaluesOnly != null)
            {
                if (mSExcelCutBetweenCellsvaluesOnly != null)
                {
                    mSExcelCutBetweenCells["ValuesOnly"] = CSharpExpressionConverter.ConvertToken(mSExcelCutBetweenCellsvaluesOnly);
                    mSExcelCutBetweenCellspropCount++;
                }

                mSExcelCutBetweenCellspropCount++;
            }
            else
            {
                mSExcelCutBetweenCells["ValuesOnly"] = false;
                mSExcelCutBetweenCellspropCount++;
            }

            mSExcelCutBetweenCellspropCount++;
            mSExcelCutBetweenCells["Workflow"] = CSharpExpressionConverter.ConvertToken(mSExcelCutBetweenCellsworkflow);
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
                if (mSExcelMinimiseWindowhandle != null)
                {
                    mSExcelMinimiseWindow["Handle"] = CSharpExpressionConverter.ConvertToken(mSExcelMinimiseWindowhandle);
                    mSExcelMinimiseWindowpropCount++;
                }

                mSExcelMinimiseWindowpropCount++;
            }
            else
            {
                mSExcelMinimiseWindow["Handle"] = 0;
                mSExcelMinimiseWindowpropCount++;
            }

            mSExcelMinimiseWindowpropCount++;
            mSExcelMinimiseWindow["Workflow"] = CSharpExpressionConverter.ConvertToken(mSExcelMinimiseWindowworkflow);
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
                if (mSExcelMaximiseWindowhandle != null)
                {
                    mSExcelMaximiseWindow["Handle"] = CSharpExpressionConverter.ConvertToken(mSExcelMaximiseWindowhandle);
                    mSExcelMaximiseWindowpropCount++;
                }

                mSExcelMaximiseWindowpropCount++;
            }
            else
            {
                mSExcelMaximiseWindow["Handle"] = 0;
                mSExcelMaximiseWindowpropCount++;
            }

            mSExcelMaximiseWindowpropCount++;
            mSExcelMaximiseWindow["Workflow"] = CSharpExpressionConverter.ConvertToken(mSExcelMaximiseWindowworkflow);
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
                if (mSExcelNormaliseWindowhandle != null)
                {
                    mSExcelNormaliseWindow["Handle"] = CSharpExpressionConverter.ConvertToken(mSExcelNormaliseWindowhandle);
                    mSExcelNormaliseWindowpropCount++;
                }

                mSExcelNormaliseWindowpropCount++;
            }
            else
            {
                mSExcelNormaliseWindow["Handle"] = 0;
                mSExcelNormaliseWindowpropCount++;
            }

            mSExcelNormaliseWindowpropCount++;
            mSExcelNormaliseWindow["Workflow"] = CSharpExpressionConverter.ConvertToken(mSExcelNormaliseWindowworkflow);
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
                if (mSExcelGetAndSetCellValuesourceHandle != null)
                {
                    mSExcelGetAndSetCellValue["SourceHandle"] = CSharpExpressionConverter.ConvertToken(mSExcelGetAndSetCellValuesourceHandle);
                    mSExcelGetAndSetCellValuepropCount++;
                }

                mSExcelGetAndSetCellValuepropCount++;
            }
            else
            {
                mSExcelGetAndSetCellValue["SourceHandle"] = 0;
                mSExcelGetAndSetCellValuepropCount++;
            }

            if (mSExcelGetAndSetCellValuesourceWorkbookName != null)
            {
                mSExcelGetAndSetCellValue["SourceWorkbookName"] = CSharpExpressionConverter.ConvertToken(mSExcelGetAndSetCellValuesourceWorkbookName);
                mSExcelGetAndSetCellValuepropCount++;
            }

            if (mSExcelGetAndSetCellValuesourceWorksheetName != null)
            {
                mSExcelGetAndSetCellValue["SourceWorksheetName"] = CSharpExpressionConverter.ConvertToken(mSExcelGetAndSetCellValuesourceWorksheetName);
                mSExcelGetAndSetCellValuepropCount++;
            }

            mSExcelGetAndSetCellValuepropCount++;
            mSExcelGetAndSetCellValue["SourceCellReference"] = CSharpExpressionConverter.ConvertToken(mSExcelGetAndSetCellValuesourceCellReference);
            if (mSExcelGetAndSetCellValuetargetHandle != null)
            {
                if (mSExcelGetAndSetCellValuetargetHandle != null)
                {
                    mSExcelGetAndSetCellValue["TargetHandle"] = CSharpExpressionConverter.ConvertToken(mSExcelGetAndSetCellValuetargetHandle);
                    mSExcelGetAndSetCellValuepropCount++;
                }

                mSExcelGetAndSetCellValuepropCount++;
            }
            else
            {
                mSExcelGetAndSetCellValue["TargetHandle"] = 0;
                mSExcelGetAndSetCellValuepropCount++;
            }

            if (mSExcelGetAndSetCellValuetargetWorkbookName != null)
            {
                mSExcelGetAndSetCellValue["TargetWorkbookName"] = CSharpExpressionConverter.ConvertToken(mSExcelGetAndSetCellValuetargetWorkbookName);
                mSExcelGetAndSetCellValuepropCount++;
            }

            if (mSExcelGetAndSetCellValuetargetWorksheetName != null)
            {
                mSExcelGetAndSetCellValue["TargetWorksheetName"] = CSharpExpressionConverter.ConvertToken(mSExcelGetAndSetCellValuetargetWorksheetName);
                mSExcelGetAndSetCellValuepropCount++;
            }

            mSExcelGetAndSetCellValuepropCount++;
            mSExcelGetAndSetCellValue["TargetCellReference"] = CSharpExpressionConverter.ConvertToken(mSExcelGetAndSetCellValuetargetCellReference);
            mSExcelGetAndSetCellValuepropCount++;
            mSExcelGetAndSetCellValue["Workflow"] = CSharpExpressionConverter.ConvertToken(mSExcelGetAndSetCellValueworkflow);
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
                if (mSExcelGetAndSetCellValue2sourceHandle != null)
                {
                    mSExcelGetAndSetCellValue2["SourceHandle"] = CSharpExpressionConverter.ConvertToken(mSExcelGetAndSetCellValue2sourceHandle);
                    mSExcelGetAndSetCellValue2propCount++;
                }

                mSExcelGetAndSetCellValue2propCount++;
            }
            else
            {
                mSExcelGetAndSetCellValue2["SourceHandle"] = 0;
                mSExcelGetAndSetCellValue2propCount++;
            }

            if (mSExcelGetAndSetCellValue2sourceWorkbookName != null)
            {
                mSExcelGetAndSetCellValue2["SourceWorkbookName"] = CSharpExpressionConverter.ConvertToken(mSExcelGetAndSetCellValue2sourceWorkbookName);
                mSExcelGetAndSetCellValue2propCount++;
            }

            if (mSExcelGetAndSetCellValue2sourceWorksheetName != null)
            {
                mSExcelGetAndSetCellValue2["SourceWorksheetName"] = CSharpExpressionConverter.ConvertToken(mSExcelGetAndSetCellValue2sourceWorksheetName);
                mSExcelGetAndSetCellValue2propCount++;
            }

            mSExcelGetAndSetCellValue2propCount++;
            mSExcelGetAndSetCellValue2["SourceCellReference"] = CSharpExpressionConverter.ConvertToken(mSExcelGetAndSetCellValue2sourceCellReference);
            if (mSExcelGetAndSetCellValue2targetHandle != null)
            {
                if (mSExcelGetAndSetCellValue2targetHandle != null)
                {
                    mSExcelGetAndSetCellValue2["TargetHandle"] = CSharpExpressionConverter.ConvertToken(mSExcelGetAndSetCellValue2targetHandle);
                    mSExcelGetAndSetCellValue2propCount++;
                }

                mSExcelGetAndSetCellValue2propCount++;
            }
            else
            {
                mSExcelGetAndSetCellValue2["TargetHandle"] = 0;
                mSExcelGetAndSetCellValue2propCount++;
            }

            if (mSExcelGetAndSetCellValue2targetWorkbookName != null)
            {
                mSExcelGetAndSetCellValue2["TargetWorkbookName"] = CSharpExpressionConverter.ConvertToken(mSExcelGetAndSetCellValue2targetWorkbookName);
                mSExcelGetAndSetCellValue2propCount++;
            }

            if (mSExcelGetAndSetCellValue2targetWorksheetName != null)
            {
                mSExcelGetAndSetCellValue2["TargetWorksheetName"] = CSharpExpressionConverter.ConvertToken(mSExcelGetAndSetCellValue2targetWorksheetName);
                mSExcelGetAndSetCellValue2propCount++;
            }

            mSExcelGetAndSetCellValue2propCount++;
            mSExcelGetAndSetCellValue2["TargetCellReference"] = CSharpExpressionConverter.ConvertToken(mSExcelGetAndSetCellValue2targetCellReference);
            mSExcelGetAndSetCellValue2propCount++;
            mSExcelGetAndSetCellValue2["Workflow"] = CSharpExpressionConverter.ConvertToken(mSExcelGetAndSetCellValue2workflow);
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
                if (mSExcelGetAndSetCellTextsourceHandle != null)
                {
                    mSExcelGetAndSetCellText["SourceHandle"] = CSharpExpressionConverter.ConvertToken(mSExcelGetAndSetCellTextsourceHandle);
                    mSExcelGetAndSetCellTextpropCount++;
                }

                mSExcelGetAndSetCellTextpropCount++;
            }
            else
            {
                mSExcelGetAndSetCellText["SourceHandle"] = 0;
                mSExcelGetAndSetCellTextpropCount++;
            }

            if (mSExcelGetAndSetCellTextsourceWorkbookName != null)
            {
                mSExcelGetAndSetCellText["SourceWorkbookName"] = CSharpExpressionConverter.ConvertToken(mSExcelGetAndSetCellTextsourceWorkbookName);
                mSExcelGetAndSetCellTextpropCount++;
            }

            if (mSExcelGetAndSetCellTextsourceWorksheetName != null)
            {
                mSExcelGetAndSetCellText["SourceWorksheetName"] = CSharpExpressionConverter.ConvertToken(mSExcelGetAndSetCellTextsourceWorksheetName);
                mSExcelGetAndSetCellTextpropCount++;
            }

            mSExcelGetAndSetCellTextpropCount++;
            mSExcelGetAndSetCellText["SourceCellReference"] = CSharpExpressionConverter.ConvertToken(mSExcelGetAndSetCellTextsourceCellReference);
            if (mSExcelGetAndSetCellTexttargetHandle != null)
            {
                if (mSExcelGetAndSetCellTexttargetHandle != null)
                {
                    mSExcelGetAndSetCellText["TargetHandle"] = CSharpExpressionConverter.ConvertToken(mSExcelGetAndSetCellTexttargetHandle);
                    mSExcelGetAndSetCellTextpropCount++;
                }

                mSExcelGetAndSetCellTextpropCount++;
            }
            else
            {
                mSExcelGetAndSetCellText["TargetHandle"] = 0;
                mSExcelGetAndSetCellTextpropCount++;
            }

            if (mSExcelGetAndSetCellTexttargetWorkbookName != null)
            {
                mSExcelGetAndSetCellText["TargetWorkbookName"] = CSharpExpressionConverter.ConvertToken(mSExcelGetAndSetCellTexttargetWorkbookName);
                mSExcelGetAndSetCellTextpropCount++;
            }

            if (mSExcelGetAndSetCellTexttargetWorksheetName != null)
            {
                mSExcelGetAndSetCellText["TargetWorksheetName"] = CSharpExpressionConverter.ConvertToken(mSExcelGetAndSetCellTexttargetWorksheetName);
                mSExcelGetAndSetCellTextpropCount++;
            }

            mSExcelGetAndSetCellTextpropCount++;
            mSExcelGetAndSetCellText["TargetCellReference"] = CSharpExpressionConverter.ConvertToken(mSExcelGetAndSetCellTexttargetCellReference);
            mSExcelGetAndSetCellTextpropCount++;
            mSExcelGetAndSetCellText["Workflow"] = CSharpExpressionConverter.ConvertToken(mSExcelGetAndSetCellTextworkflow);
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
                if (mSExcelCheckOLEObjecthandle != null)
                {
                    mSExcelCheckOLEObject["Handle"] = CSharpExpressionConverter.ConvertToken(mSExcelCheckOLEObjecthandle);
                    mSExcelCheckOLEObjectpropCount++;
                }

                mSExcelCheckOLEObjectpropCount++;
            }
            else
            {
                mSExcelCheckOLEObject["Handle"] = 0;
                mSExcelCheckOLEObjectpropCount++;
            }

            if (mSExcelCheckOLEObjectworkbookName != null)
            {
                mSExcelCheckOLEObject["WorkbookName"] = CSharpExpressionConverter.ConvertToken(mSExcelCheckOLEObjectworkbookName);
                mSExcelCheckOLEObjectpropCount++;
            }

            if (mSExcelCheckOLEObjectworksheetName != null)
            {
                mSExcelCheckOLEObject["WorksheetName"] = CSharpExpressionConverter.ConvertToken(mSExcelCheckOLEObjectworksheetName);
                mSExcelCheckOLEObjectpropCount++;
            }

            mSExcelCheckOLEObjectpropCount++;
            mSExcelCheckOLEObject["OLEObjectName"] = CSharpExpressionConverter.ConvertToken(mSExcelCheckOLEObjectoLEObjectName);
            if (mSExcelCheckOLEObjectchecked != null)
            {
                if (mSExcelCheckOLEObjectchecked != null)
                {
                    mSExcelCheckOLEObject["Checked"] = CSharpExpressionConverter.ConvertToken(mSExcelCheckOLEObjectchecked);
                    mSExcelCheckOLEObjectpropCount++;
                }

                mSExcelCheckOLEObjectpropCount++;
            }
            else
            {
                mSExcelCheckOLEObject["Checked"] = false;
                mSExcelCheckOLEObjectpropCount++;
            }

            if (mSExcelCheckOLEObjectrunInBackground != null)
            {
                if (mSExcelCheckOLEObjectrunInBackground != null)
                {
                    mSExcelCheckOLEObject["RunInBackground"] = CSharpExpressionConverter.ConvertToken(mSExcelCheckOLEObjectrunInBackground);
                    mSExcelCheckOLEObjectpropCount++;
                }

                mSExcelCheckOLEObjectpropCount++;
            }
            else
            {
                mSExcelCheckOLEObject["RunInBackground"] = false;
                mSExcelCheckOLEObjectpropCount++;
            }

            mSExcelCheckOLEObjectpropCount++;
            mSExcelCheckOLEObject["Workflow"] = CSharpExpressionConverter.ConvertToken(mSExcelCheckOLEObjectworkflow);
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
                if (mSExcelInputTextIntoOLEObjecthandle != null)
                {
                    mSExcelInputTextIntoOLEObject["Handle"] = CSharpExpressionConverter.ConvertToken(mSExcelInputTextIntoOLEObjecthandle);
                    mSExcelInputTextIntoOLEObjectpropCount++;
                }

                mSExcelInputTextIntoOLEObjectpropCount++;
            }
            else
            {
                mSExcelInputTextIntoOLEObject["Handle"] = 0;
                mSExcelInputTextIntoOLEObjectpropCount++;
            }

            if (mSExcelInputTextIntoOLEObjectworkbookName != null)
            {
                mSExcelInputTextIntoOLEObject["WorkbookName"] = CSharpExpressionConverter.ConvertToken(mSExcelInputTextIntoOLEObjectworkbookName);
                mSExcelInputTextIntoOLEObjectpropCount++;
            }

            if (mSExcelInputTextIntoOLEObjectworksheetName != null)
            {
                mSExcelInputTextIntoOLEObject["WorksheetName"] = CSharpExpressionConverter.ConvertToken(mSExcelInputTextIntoOLEObjectworksheetName);
                mSExcelInputTextIntoOLEObjectpropCount++;
            }

            mSExcelInputTextIntoOLEObjectpropCount++;
            mSExcelInputTextIntoOLEObject["OLEObjectName"] = CSharpExpressionConverter.ConvertToken(mSExcelInputTextIntoOLEObjectoLEObjectName);
            if (mSExcelInputTextIntoOLEObjecttextToInput != null)
            {
                mSExcelInputTextIntoOLEObject["TextToInput"] = CSharpExpressionConverter.ConvertToken(mSExcelInputTextIntoOLEObjecttextToInput);
                mSExcelInputTextIntoOLEObjectpropCount++;
            }

            if (mSExcelInputTextIntoOLEObjectrunInBackground != null)
            {
                if (mSExcelInputTextIntoOLEObjectrunInBackground != null)
                {
                    mSExcelInputTextIntoOLEObject["RunInBackground"] = CSharpExpressionConverter.ConvertToken(mSExcelInputTextIntoOLEObjectrunInBackground);
                    mSExcelInputTextIntoOLEObjectpropCount++;
                }

                mSExcelInputTextIntoOLEObjectpropCount++;
            }
            else
            {
                mSExcelInputTextIntoOLEObject["RunInBackground"] = false;
                mSExcelInputTextIntoOLEObjectpropCount++;
            }

            mSExcelInputTextIntoOLEObjectpropCount++;
            mSExcelInputTextIntoOLEObject["Workflow"] = CSharpExpressionConverter.ConvertToken(mSExcelInputTextIntoOLEObjectworkflow);
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
                if (mSExcelSetCellBackgroundColourhandle != null)
                {
                    mSExcelSetCellBackgroundColour["Handle"] = CSharpExpressionConverter.ConvertToken(mSExcelSetCellBackgroundColourhandle);
                    mSExcelSetCellBackgroundColourpropCount++;
                }

                mSExcelSetCellBackgroundColourpropCount++;
            }
            else
            {
                mSExcelSetCellBackgroundColour["Handle"] = 0;
                mSExcelSetCellBackgroundColourpropCount++;
            }

            if (mSExcelSetCellBackgroundColourworkbookName != null)
            {
                mSExcelSetCellBackgroundColour["WorkbookName"] = CSharpExpressionConverter.ConvertToken(mSExcelSetCellBackgroundColourworkbookName);
                mSExcelSetCellBackgroundColourpropCount++;
            }

            if (mSExcelSetCellBackgroundColourworksheetName != null)
            {
                mSExcelSetCellBackgroundColour["WorksheetName"] = CSharpExpressionConverter.ConvertToken(mSExcelSetCellBackgroundColourworksheetName);
                mSExcelSetCellBackgroundColourpropCount++;
            }

            mSExcelSetCellBackgroundColourpropCount++;
            mSExcelSetCellBackgroundColour["CellReference"] = CSharpExpressionConverter.ConvertToken(mSExcelSetCellBackgroundColourcellReference);
            mSExcelSetCellBackgroundColourpropCount++;
            mSExcelSetCellBackgroundColour["ColourIndex"] = CSharpExpressionConverter.ConvertToken(mSExcelSetCellBackgroundColourcolourIndex);
            mSExcelSetCellBackgroundColourpropCount++;
            mSExcelSetCellBackgroundColour["Workflow"] = CSharpExpressionConverter.ConvertToken(mSExcelSetCellBackgroundColourworkflow);
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
                if (mSExcelGetCellBackgroundColourhandle != null)
                {
                    mSExcelGetCellBackgroundColour["Handle"] = CSharpExpressionConverter.ConvertToken(mSExcelGetCellBackgroundColourhandle);
                    mSExcelGetCellBackgroundColourpropCount++;
                }

                mSExcelGetCellBackgroundColourpropCount++;
            }
            else
            {
                mSExcelGetCellBackgroundColour["Handle"] = 0;
                mSExcelGetCellBackgroundColourpropCount++;
            }

            if (mSExcelGetCellBackgroundColourworkbookName != null)
            {
                mSExcelGetCellBackgroundColour["WorkbookName"] = CSharpExpressionConverter.ConvertToken(mSExcelGetCellBackgroundColourworkbookName);
                mSExcelGetCellBackgroundColourpropCount++;
            }

            if (mSExcelGetCellBackgroundColourworksheetName != null)
            {
                mSExcelGetCellBackgroundColour["WorksheetName"] = CSharpExpressionConverter.ConvertToken(mSExcelGetCellBackgroundColourworksheetName);
                mSExcelGetCellBackgroundColourpropCount++;
            }

            mSExcelGetCellBackgroundColourpropCount++;
            mSExcelGetCellBackgroundColour["CellReference"] = CSharpExpressionConverter.ConvertToken(mSExcelGetCellBackgroundColourcellReference);
            mSExcelGetCellBackgroundColourpropCount++;
            mSExcelGetCellBackgroundColour["Workflow"] = CSharpExpressionConverter.ConvertToken(mSExcelGetCellBackgroundColourworkflow);
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
                if (mSExcelGetOLEObjectValuehandle != null)
                {
                    mSExcelGetOLEObjectValue["Handle"] = CSharpExpressionConverter.ConvertToken(mSExcelGetOLEObjectValuehandle);
                    mSExcelGetOLEObjectValuepropCount++;
                }

                mSExcelGetOLEObjectValuepropCount++;
            }
            else
            {
                mSExcelGetOLEObjectValue["Handle"] = 0;
                mSExcelGetOLEObjectValuepropCount++;
            }

            if (mSExcelGetOLEObjectValueworkbookName != null)
            {
                mSExcelGetOLEObjectValue["WorkbookName"] = CSharpExpressionConverter.ConvertToken(mSExcelGetOLEObjectValueworkbookName);
                mSExcelGetOLEObjectValuepropCount++;
            }

            if (mSExcelGetOLEObjectValueworksheetName != null)
            {
                mSExcelGetOLEObjectValue["WorksheetName"] = CSharpExpressionConverter.ConvertToken(mSExcelGetOLEObjectValueworksheetName);
                mSExcelGetOLEObjectValuepropCount++;
            }

            mSExcelGetOLEObjectValuepropCount++;
            mSExcelGetOLEObjectValue["OLEObjectName"] = CSharpExpressionConverter.ConvertToken(mSExcelGetOLEObjectValueoLEObjectName);
            mSExcelGetOLEObjectValuepropCount++;
            mSExcelGetOLEObjectValue["Workflow"] = CSharpExpressionConverter.ConvertToken(mSExcelGetOLEObjectValueworkflow);
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
                if (mSExcelDoesOLEObjectExisthandle != null)
                {
                    mSExcelDoesOLEObjectExist["Handle"] = CSharpExpressionConverter.ConvertToken(mSExcelDoesOLEObjectExisthandle);
                    mSExcelDoesOLEObjectExistpropCount++;
                }

                mSExcelDoesOLEObjectExistpropCount++;
            }
            else
            {
                mSExcelDoesOLEObjectExist["Handle"] = 0;
                mSExcelDoesOLEObjectExistpropCount++;
            }

            if (mSExcelDoesOLEObjectExistworkbookName != null)
            {
                mSExcelDoesOLEObjectExist["WorkbookName"] = CSharpExpressionConverter.ConvertToken(mSExcelDoesOLEObjectExistworkbookName);
                mSExcelDoesOLEObjectExistpropCount++;
            }

            if (mSExcelDoesOLEObjectExistworksheetName != null)
            {
                mSExcelDoesOLEObjectExist["WorksheetName"] = CSharpExpressionConverter.ConvertToken(mSExcelDoesOLEObjectExistworksheetName);
                mSExcelDoesOLEObjectExistpropCount++;
            }

            mSExcelDoesOLEObjectExistpropCount++;
            mSExcelDoesOLEObjectExist["OLEObjectName"] = CSharpExpressionConverter.ConvertToken(mSExcelDoesOLEObjectExistoLEObjectName);
            mSExcelDoesOLEObjectExistpropCount++;
            mSExcelDoesOLEObjectExist["Workflow"] = CSharpExpressionConverter.ConvertToken(mSExcelDoesOLEObjectExistworkflow);
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
                if (mSExcelPressOLEObjecthandle != null)
                {
                    mSExcelPressOLEObject["Handle"] = CSharpExpressionConverter.ConvertToken(mSExcelPressOLEObjecthandle);
                    mSExcelPressOLEObjectpropCount++;
                }

                mSExcelPressOLEObjectpropCount++;
            }
            else
            {
                mSExcelPressOLEObject["Handle"] = 0;
                mSExcelPressOLEObjectpropCount++;
            }

            if (mSExcelPressOLEObjectworkbookName != null)
            {
                mSExcelPressOLEObject["WorkbookName"] = CSharpExpressionConverter.ConvertToken(mSExcelPressOLEObjectworkbookName);
                mSExcelPressOLEObjectpropCount++;
            }

            if (mSExcelPressOLEObjectworksheetName != null)
            {
                mSExcelPressOLEObject["WorksheetName"] = CSharpExpressionConverter.ConvertToken(mSExcelPressOLEObjectworksheetName);
                mSExcelPressOLEObjectpropCount++;
            }

            mSExcelPressOLEObjectpropCount++;
            mSExcelPressOLEObject["OLEObjectName"] = CSharpExpressionConverter.ConvertToken(mSExcelPressOLEObjectoLEObjectName);
            if (mSExcelPressOLEObjectrunInBackground != null)
            {
                if (mSExcelPressOLEObjectrunInBackground != null)
                {
                    mSExcelPressOLEObject["RunInBackground"] = CSharpExpressionConverter.ConvertToken(mSExcelPressOLEObjectrunInBackground);
                    mSExcelPressOLEObjectpropCount++;
                }

                mSExcelPressOLEObjectpropCount++;
            }
            else
            {
                mSExcelPressOLEObject["RunInBackground"] = false;
                mSExcelPressOLEObjectpropCount++;
            }

            mSExcelPressOLEObjectpropCount++;
            mSExcelPressOLEObject["Workflow"] = CSharpExpressionConverter.ConvertToken(mSExcelPressOLEObjectworkflow);
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
                if (mSExcelSetWorksheetSensitivityLabelhandle != null)
                {
                    mSExcelSetWorksheetSensitivityLabel["Handle"] = CSharpExpressionConverter.ConvertToken(mSExcelSetWorksheetSensitivityLabelhandle);
                    mSExcelSetWorksheetSensitivityLabelpropCount++;
                }

                mSExcelSetWorksheetSensitivityLabelpropCount++;
            }
            else
            {
                mSExcelSetWorksheetSensitivityLabel["Handle"] = 0;
                mSExcelSetWorksheetSensitivityLabelpropCount++;
            }

            if (mSExcelSetWorksheetSensitivityLabelworkbookName != null)
            {
                mSExcelSetWorksheetSensitivityLabel["WorkbookName"] = CSharpExpressionConverter.ConvertToken(mSExcelSetWorksheetSensitivityLabelworkbookName);
                mSExcelSetWorksheetSensitivityLabelpropCount++;
            }

            mSExcelSetWorksheetSensitivityLabelpropCount++;
            mSExcelSetWorksheetSensitivityLabel["AssignmentMethod"] = CSharpExpressionConverter.Convert(mSExcelSetWorksheetSensitivityLabelassignmentMethod);
            mSExcelSetWorksheetSensitivityLabelpropCount++;
            mSExcelSetWorksheetSensitivityLabel["LabelId"] = CSharpExpressionConverter.ConvertToken(mSExcelSetWorksheetSensitivityLabellabelId);
            if (mSExcelSetWorksheetSensitivityLabellabelName != null)
            {
                mSExcelSetWorksheetSensitivityLabel["LabelName"] = CSharpExpressionConverter.ConvertToken(mSExcelSetWorksheetSensitivityLabellabelName);
                mSExcelSetWorksheetSensitivityLabelpropCount++;
            }

            if (mSExcelSetWorksheetSensitivityLabelsiteId != null)
            {
                mSExcelSetWorksheetSensitivityLabel["SiteId"] = CSharpExpressionConverter.ConvertToken(mSExcelSetWorksheetSensitivityLabelsiteId);
                mSExcelSetWorksheetSensitivityLabelpropCount++;
            }

            if (mSExcelSetWorksheetSensitivityLabeljustification != null)
            {
                mSExcelSetWorksheetSensitivityLabel["Justification"] = CSharpExpressionConverter.ConvertToken(mSExcelSetWorksheetSensitivityLabeljustification);
                mSExcelSetWorksheetSensitivityLabelpropCount++;
            }

            mSExcelSetWorksheetSensitivityLabelpropCount++;
            mSExcelSetWorksheetSensitivityLabel["Workflow"] = CSharpExpressionConverter.ConvertToken(mSExcelSetWorksheetSensitivityLabelworkflow);
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
                if (mSExcelGetWorksheetSensitivityLabelhandle != null)
                {
                    mSExcelGetWorksheetSensitivityLabel["Handle"] = CSharpExpressionConverter.ConvertToken(mSExcelGetWorksheetSensitivityLabelhandle);
                    mSExcelGetWorksheetSensitivityLabelpropCount++;
                }

                mSExcelGetWorksheetSensitivityLabelpropCount++;
            }
            else
            {
                mSExcelGetWorksheetSensitivityLabel["Handle"] = 0;
                mSExcelGetWorksheetSensitivityLabelpropCount++;
            }

            if (mSExcelGetWorksheetSensitivityLabelworkbookName != null)
            {
                mSExcelGetWorksheetSensitivityLabel["WorkbookName"] = CSharpExpressionConverter.ConvertToken(mSExcelGetWorksheetSensitivityLabelworkbookName);
                mSExcelGetWorksheetSensitivityLabelpropCount++;
            }

            mSExcelGetWorksheetSensitivityLabelpropCount++;
            mSExcelGetWorksheetSensitivityLabel["Workflow"] = CSharpExpressionConverter.ConvertToken(mSExcelGetWorksheetSensitivityLabelworkflow);
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
                if (mSExcelWriteArrayhandle != null)
                {
                    mSExcelWriteArray["Handle"] = CSharpExpressionConverter.ConvertToken(mSExcelWriteArrayhandle);
                    mSExcelWriteArraypropCount++;
                }

                mSExcelWriteArraypropCount++;
            }
            else
            {
                mSExcelWriteArray["Handle"] = 0;
                mSExcelWriteArraypropCount++;
            }

            if (mSExcelWriteArrayworkbookName != null)
            {
                mSExcelWriteArray["WorkbookName"] = CSharpExpressionConverter.ConvertToken(mSExcelWriteArrayworkbookName);
                mSExcelWriteArraypropCount++;
            }

            if (mSExcelWriteArrayworksheetName != null)
            {
                mSExcelWriteArray["WorksheetName"] = CSharpExpressionConverter.ConvertToken(mSExcelWriteArrayworksheetName);
                mSExcelWriteArraypropCount++;
            }

            mSExcelWriteArraypropCount++;
            mSExcelWriteArray["CellReference"] = CSharpExpressionConverter.ConvertToken(mSExcelWriteArraycellReference);
            mSExcelWriteArraypropCount++;
            mSExcelWriteArray["ArrayToWriteJSON"] = CSharpExpressionConverter.ConvertToken(mSExcelWriteArrayarrayToWriteJSON);
            mSExcelWriteArraypropCount++;
            mSExcelWriteArray["Direction"] = CSharpExpressionConverter.Convert(mSExcelWriteArraydirection);
            mSExcelWriteArraypropCount++;
            mSExcelWriteArray["Workflow"] = CSharpExpressionConverter.ConvertToken(mSExcelWriteArrayworkflow);
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
                mSOutlookCreateInstance["ProfileName"] = CSharpExpressionConverter.ConvertToken(mSOutlookCreateInstanceprofileName);
                mSOutlookCreateInstancepropCount++;
            }

            if (mSOutlookCreateInstanceshowOutlook != null)
            {
                if (mSOutlookCreateInstanceshowOutlook != null)
                {
                    mSOutlookCreateInstance["ShowOutlook"] = CSharpExpressionConverter.ConvertToken(mSOutlookCreateInstanceshowOutlook);
                    mSOutlookCreateInstancepropCount++;
                }

                mSOutlookCreateInstancepropCount++;
            }
            else
            {
                mSOutlookCreateInstance["ShowOutlook"] = false;
                mSOutlookCreateInstancepropCount++;
            }

            mSOutlookCreateInstancepropCount++;
            mSOutlookCreateInstance["Workflow"] = CSharpExpressionConverter.ConvertToken(mSOutlookCreateInstanceworkflow);
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
                if (mSOutlookCloseInstancesecondsToWaitForProcessToClose != null)
                {
                    mSOutlookCloseInstance["SecondsToWaitForProcessToClose"] = CSharpExpressionConverter.ConvertToken(mSOutlookCloseInstancesecondsToWaitForProcessToClose);
                    mSOutlookCloseInstancepropCount++;
                }

                mSOutlookCloseInstancepropCount++;
            }
            else
            {
                mSOutlookCloseInstance["SecondsToWaitForProcessToClose"] = 10;
                mSOutlookCloseInstancepropCount++;
            }

            mSOutlookCloseInstancepropCount++;
            mSOutlookCloseInstance["Workflow"] = CSharpExpressionConverter.ConvertToken(mSOutlookCloseInstanceworkflow);
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
                if (mSOutlookCloseInstanceUsingWindowuseNativeWindow != null)
                {
                    mSOutlookCloseInstanceUsingWindow["UseNativeWindow"] = CSharpExpressionConverter.ConvertToken(mSOutlookCloseInstanceUsingWindowuseNativeWindow);
                    mSOutlookCloseInstanceUsingWindowpropCount++;
                }

                mSOutlookCloseInstanceUsingWindowpropCount++;
            }
            else
            {
                mSOutlookCloseInstanceUsingWindow["UseNativeWindow"] = true;
                mSOutlookCloseInstanceUsingWindowpropCount++;
            }

            if (mSOutlookCloseInstanceUsingWindowuseUIA != null)
            {
                if (mSOutlookCloseInstanceUsingWindowuseUIA != null)
                {
                    mSOutlookCloseInstanceUsingWindow["UseUIA"] = CSharpExpressionConverter.ConvertToken(mSOutlookCloseInstanceUsingWindowuseUIA);
                    mSOutlookCloseInstanceUsingWindowpropCount++;
                }

                mSOutlookCloseInstanceUsingWindowpropCount++;
            }
            else
            {
                mSOutlookCloseInstanceUsingWindow["UseUIA"] = true;
                mSOutlookCloseInstanceUsingWindowpropCount++;
            }

            if (mSOutlookCloseInstanceUsingWindowsecondsToWaitForProcessToClose != null)
            {
                if (mSOutlookCloseInstanceUsingWindowsecondsToWaitForProcessToClose != null)
                {
                    mSOutlookCloseInstanceUsingWindow["SecondsToWaitForProcessToClose"] = CSharpExpressionConverter.ConvertToken(mSOutlookCloseInstanceUsingWindowsecondsToWaitForProcessToClose);
                    mSOutlookCloseInstanceUsingWindowpropCount++;
                }

                mSOutlookCloseInstanceUsingWindowpropCount++;
            }
            else
            {
                mSOutlookCloseInstanceUsingWindow["SecondsToWaitForProcessToClose"] = 10;
                mSOutlookCloseInstanceUsingWindowpropCount++;
            }

            mSOutlookCloseInstanceUsingWindowpropCount++;
            mSOutlookCloseInstanceUsingWindow["Workflow"] = CSharpExpressionConverter.ConvertToken(mSOutlookCloseInstanceUsingWindowworkflow);
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
                if (mSOutlookAttachToExistingInstancetoggleWindow != null)
                {
                    mSOutlookAttachToExistingInstance["ToggleWindow"] = CSharpExpressionConverter.ConvertToken(mSOutlookAttachToExistingInstancetoggleWindow);
                    mSOutlookAttachToExistingInstancepropCount++;
                }

                mSOutlookAttachToExistingInstancepropCount++;
            }
            else
            {
                mSOutlookAttachToExistingInstance["ToggleWindow"] = true;
                mSOutlookAttachToExistingInstancepropCount++;
            }

            if (mSOutlookAttachToExistingInstancetoggleUsesGlobalLeftMouseClickAgent != null)
            {
                if (mSOutlookAttachToExistingInstancetoggleUsesGlobalLeftMouseClickAgent != null)
                {
                    mSOutlookAttachToExistingInstance["ToggleUsesGlobalLeftMouseClickAgent"] = CSharpExpressionConverter.ConvertToken(mSOutlookAttachToExistingInstancetoggleUsesGlobalLeftMouseClickAgent);
                    mSOutlookAttachToExistingInstancepropCount++;
                }

                mSOutlookAttachToExistingInstancepropCount++;
            }
            else
            {
                mSOutlookAttachToExistingInstance["ToggleUsesGlobalLeftMouseClickAgent"] = true;
                mSOutlookAttachToExistingInstancepropCount++;
            }

            if (mSOutlookAttachToExistingInstancetoggleDelay != null)
            {
                if (mSOutlookAttachToExistingInstancetoggleDelay != null)
                {
                    mSOutlookAttachToExistingInstance["ToggleDelay"] = CSharpExpressionConverter.ConvertToken(mSOutlookAttachToExistingInstancetoggleDelay);
                    mSOutlookAttachToExistingInstancepropCount++;
                }

                mSOutlookAttachToExistingInstancepropCount++;
            }
            else
            {
                mSOutlookAttachToExistingInstance["ToggleDelay"] = 0.5;
                mSOutlookAttachToExistingInstancepropCount++;
            }

            mSOutlookAttachToExistingInstancepropCount++;
            mSOutlookAttachToExistingInstance["Workflow"] = CSharpExpressionConverter.ConvertToken(mSOutlookAttachToExistingInstanceworkflow);
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
            mSOutlookIsConnected["Workflow"] = CSharpExpressionConverter.ConvertToken(mSOutlookIsConnectedworkflow);
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
            mSOutlookShow["Workflow"] = CSharpExpressionConverter.ConvertToken(mSOutlookShowworkflow);
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
            mSOutlookGetNameSpaceInformation["Workflow"] = CSharpExpressionConverter.ConvertToken(mSOutlookGetNameSpaceInformationworkflow);
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
                mSOutlookGetMailFolders["FolderPath"] = CSharpExpressionConverter.ConvertToken(mSOutlookGetMailFoldersfolderPath);
                mSOutlookGetMailFolderspropCount++;
            }

            if (mSOutlookGetMailFolderssubFolders != null)
            {
                if (mSOutlookGetMailFolderssubFolders != null)
                {
                    mSOutlookGetMailFolders["SubFolders"] = CSharpExpressionConverter.ConvertToken(mSOutlookGetMailFolderssubFolders);
                    mSOutlookGetMailFolderspropCount++;
                }

                mSOutlookGetMailFolderspropCount++;
            }
            else
            {
                mSOutlookGetMailFolders["SubFolders"] = false;
                mSOutlookGetMailFolderspropCount++;
            }

            mSOutlookGetMailFolderspropCount++;
            mSOutlookGetMailFolders["Workflow"] = CSharpExpressionConverter.ConvertToken(mSOutlookGetMailFoldersworkflow);
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
            mSOutlookMarkEmailAsRead["EntryID"] = CSharpExpressionConverter.ConvertToken(mSOutlookMarkEmailAsReadentryID);
            if (mSOutlookMarkEmailAsReadread != null)
            {
                if (mSOutlookMarkEmailAsReadread != null)
                {
                    mSOutlookMarkEmailAsRead["Read"] = CSharpExpressionConverter.ConvertToken(mSOutlookMarkEmailAsReadread);
                    mSOutlookMarkEmailAsReadpropCount++;
                }

                mSOutlookMarkEmailAsReadpropCount++;
            }
            else
            {
                mSOutlookMarkEmailAsRead["Read"] = true;
                mSOutlookMarkEmailAsReadpropCount++;
            }

            mSOutlookMarkEmailAsReadpropCount++;
            mSOutlookMarkEmailAsRead["Workflow"] = CSharpExpressionConverter.ConvertToken(mSOutlookMarkEmailAsReadworkflow);
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
            mSOutlookGetEmailBody["EntryID"] = CSharpExpressionConverter.ConvertToken(mSOutlookGetEmailBodyentryID);
            if (mSOutlookGetEmailBodyclickAllowButtonIfRequired != null)
            {
                if (mSOutlookGetEmailBodyclickAllowButtonIfRequired != null)
                {
                    mSOutlookGetEmailBody["ClickAllowButtonIfRequired"] = CSharpExpressionConverter.ConvertToken(mSOutlookGetEmailBodyclickAllowButtonIfRequired);
                    mSOutlookGetEmailBodypropCount++;
                }

                mSOutlookGetEmailBodypropCount++;
            }
            else
            {
                mSOutlookGetEmailBody["ClickAllowButtonIfRequired"] = true;
                mSOutlookGetEmailBodypropCount++;
            }

            mSOutlookGetEmailBodypropCount++;
            mSOutlookGetEmailBody["Workflow"] = CSharpExpressionConverter.ConvertToken(mSOutlookGetEmailBodyworkflow);
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
            mSOutlookGetEmailAttachmentFilenames["EntryID"] = CSharpExpressionConverter.ConvertToken(mSOutlookGetEmailAttachmentFilenamesentryID);
            if (mSOutlookGetEmailAttachmentFilenamesclickAllowButtonIfRequired != null)
            {
                if (mSOutlookGetEmailAttachmentFilenamesclickAllowButtonIfRequired != null)
                {
                    mSOutlookGetEmailAttachmentFilenames["ClickAllowButtonIfRequired"] = CSharpExpressionConverter.ConvertToken(mSOutlookGetEmailAttachmentFilenamesclickAllowButtonIfRequired);
                    mSOutlookGetEmailAttachmentFilenamespropCount++;
                }

                mSOutlookGetEmailAttachmentFilenamespropCount++;
            }
            else
            {
                mSOutlookGetEmailAttachmentFilenames["ClickAllowButtonIfRequired"] = true;
                mSOutlookGetEmailAttachmentFilenamespropCount++;
            }

            mSOutlookGetEmailAttachmentFilenamespropCount++;
            mSOutlookGetEmailAttachmentFilenames["Workflow"] = CSharpExpressionConverter.ConvertToken(mSOutlookGetEmailAttachmentFilenamesworkflow);
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
            mSOutlookSaveEmailAttachmentsAsFile["EntryID"] = CSharpExpressionConverter.ConvertToken(mSOutlookSaveEmailAttachmentsAsFileentryID);
            if (mSOutlookSaveEmailAttachmentsAsFilesaveFolderPath != null)
            {
                mSOutlookSaveEmailAttachmentsAsFile["SaveFolderPath"] = CSharpExpressionConverter.ConvertToken(mSOutlookSaveEmailAttachmentsAsFilesaveFolderPath);
                mSOutlookSaveEmailAttachmentsAsFilepropCount++;
            }

            if (mSOutlookSaveEmailAttachmentsAsFilecreateFolder != null)
            {
                if (mSOutlookSaveEmailAttachmentsAsFilecreateFolder != null)
                {
                    mSOutlookSaveEmailAttachmentsAsFile["CreateFolder"] = CSharpExpressionConverter.ConvertToken(mSOutlookSaveEmailAttachmentsAsFilecreateFolder);
                    mSOutlookSaveEmailAttachmentsAsFilepropCount++;
                }

                mSOutlookSaveEmailAttachmentsAsFilepropCount++;
            }
            else
            {
                mSOutlookSaveEmailAttachmentsAsFile["CreateFolder"] = true;
                mSOutlookSaveEmailAttachmentsAsFilepropCount++;
            }

            if (mSOutlookSaveEmailAttachmentsAsFileonlySaveAttachmentsMatchingWildcard != null)
            {
                mSOutlookSaveEmailAttachmentsAsFile["OnlySaveAttachmentsMatchingWildcard"] = CSharpExpressionConverter.ConvertToken(mSOutlookSaveEmailAttachmentsAsFileonlySaveAttachmentsMatchingWildcard);
                mSOutlookSaveEmailAttachmentsAsFilepropCount++;
            }

            if (mSOutlookSaveEmailAttachmentsAsFilesaveHiddenAttachments != null)
            {
                if (mSOutlookSaveEmailAttachmentsAsFilesaveHiddenAttachments != null)
                {
                    mSOutlookSaveEmailAttachmentsAsFile["SaveHiddenAttachments"] = CSharpExpressionConverter.ConvertToken(mSOutlookSaveEmailAttachmentsAsFilesaveHiddenAttachments);
                    mSOutlookSaveEmailAttachmentsAsFilepropCount++;
                }

                mSOutlookSaveEmailAttachmentsAsFilepropCount++;
            }
            else
            {
                mSOutlookSaveEmailAttachmentsAsFile["SaveHiddenAttachments"] = false;
                mSOutlookSaveEmailAttachmentsAsFilepropCount++;
            }

            if (mSOutlookSaveEmailAttachmentsAsFileclickAllowButtonIfRequired != null)
            {
                if (mSOutlookSaveEmailAttachmentsAsFileclickAllowButtonIfRequired != null)
                {
                    mSOutlookSaveEmailAttachmentsAsFile["ClickAllowButtonIfRequired"] = CSharpExpressionConverter.ConvertToken(mSOutlookSaveEmailAttachmentsAsFileclickAllowButtonIfRequired);
                    mSOutlookSaveEmailAttachmentsAsFilepropCount++;
                }

                mSOutlookSaveEmailAttachmentsAsFilepropCount++;
            }
            else
            {
                mSOutlookSaveEmailAttachmentsAsFile["ClickAllowButtonIfRequired"] = true;
                mSOutlookSaveEmailAttachmentsAsFilepropCount++;
            }

            mSOutlookSaveEmailAttachmentsAsFilepropCount++;
            mSOutlookSaveEmailAttachmentsAsFile["Workflow"] = CSharpExpressionConverter.ConvertToken(mSOutlookSaveEmailAttachmentsAsFileworkflow);
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
            mSOutlookDeleteEmail["EntryID"] = CSharpExpressionConverter.ConvertToken(mSOutlookDeleteEmailentryID);
            mSOutlookDeleteEmailpropCount++;
            mSOutlookDeleteEmail["Workflow"] = CSharpExpressionConverter.ConvertToken(mSOutlookDeleteEmailworkflow);
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
            mSOutlookMoveEmail["EntryID"] = CSharpExpressionConverter.ConvertToken(mSOutlookMoveEmailentryID);
            if (mSOutlookMoveEmaildestinationFolder != null)
            {
                mSOutlookMoveEmail["DestinationFolder"] = CSharpExpressionConverter.ConvertToken(mSOutlookMoveEmaildestinationFolder);
                mSOutlookMoveEmailpropCount++;
            }

            mSOutlookMoveEmailpropCount++;
            mSOutlookMoveEmail["Workflow"] = CSharpExpressionConverter.ConvertToken(mSOutlookMoveEmailworkflow);
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
                mSOutlookSendEmail["To"] = CSharpExpressionConverter.ConvertToken(mSOutlookSendEmailto);
                mSOutlookSendEmailpropCount++;
            }

            if (mSOutlookSendEmailcC != null)
            {
                mSOutlookSendEmail["CC"] = CSharpExpressionConverter.ConvertToken(mSOutlookSendEmailcC);
                mSOutlookSendEmailpropCount++;
            }

            if (mSOutlookSendEmailbCC != null)
            {
                mSOutlookSendEmail["BCC"] = CSharpExpressionConverter.ConvertToken(mSOutlookSendEmailbCC);
                mSOutlookSendEmailpropCount++;
            }

            if (mSOutlookSendEmailsubject != null)
            {
                mSOutlookSendEmail["Subject"] = CSharpExpressionConverter.ConvertToken(mSOutlookSendEmailsubject);
                mSOutlookSendEmailpropCount++;
            }

            if (mSOutlookSendEmailbodyFormat != null)
            {
                mSOutlookSendEmail["BodyFormat"] = CSharpExpressionConverter.Convert(mSOutlookSendEmailbodyFormat);
                mSOutlookSendEmailpropCount++;
            }

            if (mSOutlookSendEmailbody != null)
            {
                mSOutlookSendEmail["Body"] = CSharpExpressionConverter.ConvertToken(mSOutlookSendEmailbody);
                mSOutlookSendEmailpropCount++;
            }

            if (mSOutlookSendEmailhTMLBody != null)
            {
                mSOutlookSendEmail["HTMLBody"] = CSharpExpressionConverter.ConvertToken(mSOutlookSendEmailhTMLBody);
                mSOutlookSendEmailpropCount++;
            }

            if (mSOutlookSendEmailrTFBody != null)
            {
                mSOutlookSendEmail["RTFBody"] = CSharpExpressionConverter.ConvertToken(mSOutlookSendEmailrTFBody);
                mSOutlookSendEmailpropCount++;
            }

            if (mSOutlookSendEmailattachmentFilenamesJSON != null)
            {
                mSOutlookSendEmail["AttachmentFilenamesJSON"] = CSharpExpressionConverter.ConvertToken(mSOutlookSendEmailattachmentFilenamesJSON);
                mSOutlookSendEmailpropCount++;
            }

            if (mSOutlookSendEmaildontSendIfAttachmentFilenameMissing != null)
            {
                if (mSOutlookSendEmaildontSendIfAttachmentFilenameMissing != null)
                {
                    mSOutlookSendEmail["DontSendIfAttachmentFilenameMissing"] = CSharpExpressionConverter.ConvertToken(mSOutlookSendEmaildontSendIfAttachmentFilenameMissing);
                    mSOutlookSendEmailpropCount++;
                }

                mSOutlookSendEmailpropCount++;
            }
            else
            {
                mSOutlookSendEmail["DontSendIfAttachmentFilenameMissing"] = false;
                mSOutlookSendEmailpropCount++;
            }

            if (mSOutlookSendEmailclickAllowButtonIfRequired != null)
            {
                if (mSOutlookSendEmailclickAllowButtonIfRequired != null)
                {
                    mSOutlookSendEmail["ClickAllowButtonIfRequired"] = CSharpExpressionConverter.ConvertToken(mSOutlookSendEmailclickAllowButtonIfRequired);
                    mSOutlookSendEmailpropCount++;
                }

                mSOutlookSendEmailpropCount++;
            }
            else
            {
                mSOutlookSendEmail["ClickAllowButtonIfRequired"] = true;
                mSOutlookSendEmailpropCount++;
            }

            if (mSOutlookSendEmailvotingOptions != null)
            {
                mSOutlookSendEmail["VotingOptions"] = CSharpExpressionConverter.ConvertToken(mSOutlookSendEmailvotingOptions);
                mSOutlookSendEmailpropCount++;
            }

            if (mSOutlookSendEmailsendAsSMTPAddress != null)
            {
                mSOutlookSendEmail["SendAsSMTPAddress"] = CSharpExpressionConverter.ConvertToken(mSOutlookSendEmailsendAsSMTPAddress);
                mSOutlookSendEmailpropCount++;
            }

            if (mSOutlookSendEmailbodyContainsStoredPassword != null)
            {
                if (mSOutlookSendEmailbodyContainsStoredPassword != null)
                {
                    mSOutlookSendEmail["BodyContainsStoredPassword"] = CSharpExpressionConverter.ConvertToken(mSOutlookSendEmailbodyContainsStoredPassword);
                    mSOutlookSendEmailpropCount++;
                }

                mSOutlookSendEmailpropCount++;
            }
            else
            {
                mSOutlookSendEmail["BodyContainsStoredPassword"] = false;
                mSOutlookSendEmailpropCount++;
            }

            mSOutlookSendEmailpropCount++;
            mSOutlookSendEmail["Workflow"] = CSharpExpressionConverter.ConvertToken(mSOutlookSendEmailworkflow);
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
                mSOutlookCreateMailFolder["ParentFolderPath"] = CSharpExpressionConverter.ConvertToken(mSOutlookCreateMailFolderparentFolderPath);
                mSOutlookCreateMailFolderpropCount++;
            }

            if (mSOutlookCreateMailFoldernewFolderName != null)
            {
                mSOutlookCreateMailFolder["NewFolderName"] = CSharpExpressionConverter.ConvertToken(mSOutlookCreateMailFoldernewFolderName);
                mSOutlookCreateMailFolderpropCount++;
            }

            mSOutlookCreateMailFolderpropCount++;
            mSOutlookCreateMailFolder["Workflow"] = CSharpExpressionConverter.ConvertToken(mSOutlookCreateMailFolderworkflow);
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
            mSOutlookReplyToEmail["EntryID"] = CSharpExpressionConverter.ConvertToken(mSOutlookReplyToEmailentryID);
            if (mSOutlookReplyToEmailreplyToAll != null)
            {
                if (mSOutlookReplyToEmailreplyToAll != null)
                {
                    mSOutlookReplyToEmail["ReplyToAll"] = CSharpExpressionConverter.ConvertToken(mSOutlookReplyToEmailreplyToAll);
                    mSOutlookReplyToEmailpropCount++;
                }

                mSOutlookReplyToEmailpropCount++;
            }
            else
            {
                mSOutlookReplyToEmail["ReplyToAll"] = false;
                mSOutlookReplyToEmailpropCount++;
            }

            if (mSOutlookReplyToEmailbodyFormat != null)
            {
                mSOutlookReplyToEmail["BodyFormat"] = CSharpExpressionConverter.Convert(mSOutlookReplyToEmailbodyFormat);
                mSOutlookReplyToEmailpropCount++;
            }

            if (mSOutlookReplyToEmailbody != null)
            {
                mSOutlookReplyToEmail["Body"] = CSharpExpressionConverter.ConvertToken(mSOutlookReplyToEmailbody);
                mSOutlookReplyToEmailpropCount++;
            }

            if (mSOutlookReplyToEmailhTMLBody != null)
            {
                mSOutlookReplyToEmail["HTMLBody"] = CSharpExpressionConverter.ConvertToken(mSOutlookReplyToEmailhTMLBody);
                mSOutlookReplyToEmailpropCount++;
            }

            if (mSOutlookReplyToEmailrTFBody != null)
            {
                mSOutlookReplyToEmail["RTFBody"] = CSharpExpressionConverter.ConvertToken(mSOutlookReplyToEmailrTFBody);
                mSOutlookReplyToEmailpropCount++;
            }

            if (mSOutlookReplyToEmailattachmentFilenamesJSON != null)
            {
                mSOutlookReplyToEmail["AttachmentFilenamesJSON"] = CSharpExpressionConverter.ConvertToken(mSOutlookReplyToEmailattachmentFilenamesJSON);
                mSOutlookReplyToEmailpropCount++;
            }

            if (mSOutlookReplyToEmaildontSendIfAttachmentFilenameMissing != null)
            {
                if (mSOutlookReplyToEmaildontSendIfAttachmentFilenameMissing != null)
                {
                    mSOutlookReplyToEmail["DontSendIfAttachmentFilenameMissing"] = CSharpExpressionConverter.ConvertToken(mSOutlookReplyToEmaildontSendIfAttachmentFilenameMissing);
                    mSOutlookReplyToEmailpropCount++;
                }

                mSOutlookReplyToEmailpropCount++;
            }
            else
            {
                mSOutlookReplyToEmail["DontSendIfAttachmentFilenameMissing"] = false;
                mSOutlookReplyToEmailpropCount++;
            }

            if (mSOutlookReplyToEmailclickAllowButtonIfRequired != null)
            {
                if (mSOutlookReplyToEmailclickAllowButtonIfRequired != null)
                {
                    mSOutlookReplyToEmail["ClickAllowButtonIfRequired"] = CSharpExpressionConverter.ConvertToken(mSOutlookReplyToEmailclickAllowButtonIfRequired);
                    mSOutlookReplyToEmailpropCount++;
                }

                mSOutlookReplyToEmailpropCount++;
            }
            else
            {
                mSOutlookReplyToEmail["ClickAllowButtonIfRequired"] = true;
                mSOutlookReplyToEmailpropCount++;
            }

            if (mSOutlookReplyToEmailvotingOptions != null)
            {
                mSOutlookReplyToEmail["VotingOptions"] = CSharpExpressionConverter.ConvertToken(mSOutlookReplyToEmailvotingOptions);
                mSOutlookReplyToEmailpropCount++;
            }

            if (mSOutlookReplyToEmailsendAsSMTPAddress != null)
            {
                mSOutlookReplyToEmail["SendAsSMTPAddress"] = CSharpExpressionConverter.ConvertToken(mSOutlookReplyToEmailsendAsSMTPAddress);
                mSOutlookReplyToEmailpropCount++;
            }

            if (mSOutlookReplyToEmailbodyContainsStoredPassword != null)
            {
                if (mSOutlookReplyToEmailbodyContainsStoredPassword != null)
                {
                    mSOutlookReplyToEmail["BodyContainsStoredPassword"] = CSharpExpressionConverter.ConvertToken(mSOutlookReplyToEmailbodyContainsStoredPassword);
                    mSOutlookReplyToEmailpropCount++;
                }

                mSOutlookReplyToEmailpropCount++;
            }
            else
            {
                mSOutlookReplyToEmail["BodyContainsStoredPassword"] = false;
                mSOutlookReplyToEmailpropCount++;
            }

            mSOutlookReplyToEmailpropCount++;
            mSOutlookReplyToEmail["Workflow"] = CSharpExpressionConverter.ConvertToken(mSOutlookReplyToEmailworkflow);
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
            mSOutlookForwardEmail["EntryID"] = CSharpExpressionConverter.ConvertToken(mSOutlookForwardEmailentryID);
            if (mSOutlookForwardEmailto != null)
            {
                mSOutlookForwardEmail["To"] = CSharpExpressionConverter.ConvertToken(mSOutlookForwardEmailto);
                mSOutlookForwardEmailpropCount++;
            }

            if (mSOutlookForwardEmailcC != null)
            {
                mSOutlookForwardEmail["CC"] = CSharpExpressionConverter.ConvertToken(mSOutlookForwardEmailcC);
                mSOutlookForwardEmailpropCount++;
            }

            if (mSOutlookForwardEmailbCC != null)
            {
                mSOutlookForwardEmail["BCC"] = CSharpExpressionConverter.ConvertToken(mSOutlookForwardEmailbCC);
                mSOutlookForwardEmailpropCount++;
            }

            if (mSOutlookForwardEmailoverrideSubject != null)
            {
                if (mSOutlookForwardEmailoverrideSubject != null)
                {
                    mSOutlookForwardEmail["OverrideSubject"] = CSharpExpressionConverter.ConvertToken(mSOutlookForwardEmailoverrideSubject);
                    mSOutlookForwardEmailpropCount++;
                }

                mSOutlookForwardEmailpropCount++;
            }
            else
            {
                mSOutlookForwardEmail["OverrideSubject"] = false;
                mSOutlookForwardEmailpropCount++;
            }

            if (mSOutlookForwardEmailsubject != null)
            {
                mSOutlookForwardEmail["Subject"] = CSharpExpressionConverter.ConvertToken(mSOutlookForwardEmailsubject);
                mSOutlookForwardEmailpropCount++;
            }

            if (mSOutlookForwardEmailoverrideBody != null)
            {
                if (mSOutlookForwardEmailoverrideBody != null)
                {
                    mSOutlookForwardEmail["OverrideBody"] = CSharpExpressionConverter.ConvertToken(mSOutlookForwardEmailoverrideBody);
                    mSOutlookForwardEmailpropCount++;
                }

                mSOutlookForwardEmailpropCount++;
            }
            else
            {
                mSOutlookForwardEmail["OverrideBody"] = false;
                mSOutlookForwardEmailpropCount++;
            }

            if (mSOutlookForwardEmailbodyFormat != null)
            {
                mSOutlookForwardEmail["BodyFormat"] = CSharpExpressionConverter.Convert(mSOutlookForwardEmailbodyFormat);
                mSOutlookForwardEmailpropCount++;
            }

            if (mSOutlookForwardEmailbody != null)
            {
                mSOutlookForwardEmail["Body"] = CSharpExpressionConverter.ConvertToken(mSOutlookForwardEmailbody);
                mSOutlookForwardEmailpropCount++;
            }

            if (mSOutlookForwardEmailhTMLBody != null)
            {
                mSOutlookForwardEmail["HTMLBody"] = CSharpExpressionConverter.ConvertToken(mSOutlookForwardEmailhTMLBody);
                mSOutlookForwardEmailpropCount++;
            }

            if (mSOutlookForwardEmailrTFBody != null)
            {
                mSOutlookForwardEmail["RTFBody"] = CSharpExpressionConverter.ConvertToken(mSOutlookForwardEmailrTFBody);
                mSOutlookForwardEmailpropCount++;
            }

            if (mSOutlookForwardEmailclickAllowButtonIfRequired != null)
            {
                if (mSOutlookForwardEmailclickAllowButtonIfRequired != null)
                {
                    mSOutlookForwardEmail["ClickAllowButtonIfRequired"] = CSharpExpressionConverter.ConvertToken(mSOutlookForwardEmailclickAllowButtonIfRequired);
                    mSOutlookForwardEmailpropCount++;
                }

                mSOutlookForwardEmailpropCount++;
            }
            else
            {
                mSOutlookForwardEmail["ClickAllowButtonIfRequired"] = true;
                mSOutlookForwardEmailpropCount++;
            }

            if (mSOutlookForwardEmailvotingOptions != null)
            {
                mSOutlookForwardEmail["VotingOptions"] = CSharpExpressionConverter.ConvertToken(mSOutlookForwardEmailvotingOptions);
                mSOutlookForwardEmailpropCount++;
            }

            if (mSOutlookForwardEmailsendAsSMTPAddress != null)
            {
                mSOutlookForwardEmail["SendAsSMTPAddress"] = CSharpExpressionConverter.ConvertToken(mSOutlookForwardEmailsendAsSMTPAddress);
                mSOutlookForwardEmailpropCount++;
            }

            if (mSOutlookForwardEmailincludeExistingHiddenAttachments != null)
            {
                if (mSOutlookForwardEmailincludeExistingHiddenAttachments != null)
                {
                    mSOutlookForwardEmail["IncludeExistingHiddenAttachments"] = CSharpExpressionConverter.ConvertToken(mSOutlookForwardEmailincludeExistingHiddenAttachments);
                    mSOutlookForwardEmailpropCount++;
                }

                mSOutlookForwardEmailpropCount++;
            }
            else
            {
                mSOutlookForwardEmail["IncludeExistingHiddenAttachments"] = false;
                mSOutlookForwardEmailpropCount++;
            }

            if (mSOutlookForwardEmailincludeExistingVisibleAttachments != null)
            {
                if (mSOutlookForwardEmailincludeExistingVisibleAttachments != null)
                {
                    mSOutlookForwardEmail["IncludeExistingVisibleAttachments"] = CSharpExpressionConverter.ConvertToken(mSOutlookForwardEmailincludeExistingVisibleAttachments);
                    mSOutlookForwardEmailpropCount++;
                }

                mSOutlookForwardEmailpropCount++;
            }
            else
            {
                mSOutlookForwardEmail["IncludeExistingVisibleAttachments"] = false;
                mSOutlookForwardEmailpropCount++;
            }

            if (mSOutlookForwardEmailattachmentFilenamesJSON != null)
            {
                mSOutlookForwardEmail["AttachmentFilenamesJSON"] = CSharpExpressionConverter.ConvertToken(mSOutlookForwardEmailattachmentFilenamesJSON);
                mSOutlookForwardEmailpropCount++;
            }

            if (mSOutlookForwardEmaildontSendIfAttachmentFilenameMissing != null)
            {
                if (mSOutlookForwardEmaildontSendIfAttachmentFilenameMissing != null)
                {
                    mSOutlookForwardEmail["DontSendIfAttachmentFilenameMissing"] = CSharpExpressionConverter.ConvertToken(mSOutlookForwardEmaildontSendIfAttachmentFilenameMissing);
                    mSOutlookForwardEmailpropCount++;
                }

                mSOutlookForwardEmailpropCount++;
            }
            else
            {
                mSOutlookForwardEmail["DontSendIfAttachmentFilenameMissing"] = false;
                mSOutlookForwardEmailpropCount++;
            }

            if (mSOutlookForwardEmailbodyContainsStoredPassword != null)
            {
                if (mSOutlookForwardEmailbodyContainsStoredPassword != null)
                {
                    mSOutlookForwardEmail["BodyContainsStoredPassword"] = CSharpExpressionConverter.ConvertToken(mSOutlookForwardEmailbodyContainsStoredPassword);
                    mSOutlookForwardEmailpropCount++;
                }

                mSOutlookForwardEmailpropCount++;
            }
            else
            {
                mSOutlookForwardEmail["BodyContainsStoredPassword"] = false;
                mSOutlookForwardEmailpropCount++;
            }

            mSOutlookForwardEmailpropCount++;
            mSOutlookForwardEmail["Workflow"] = CSharpExpressionConverter.ConvertToken(mSOutlookForwardEmailworkflow);
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
            mSOutlookGetMAPIProfiles["Workflow"] = CSharpExpressionConverter.ConvertToken(mSOutlookGetMAPIProfilesworkflow);
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
            mSOutlookGetOutlookProcessId["Workflow"] = CSharpExpressionConverter.ConvertToken(mSOutlookGetOutlookProcessIdworkflow);
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
                if (mSOutlookBackgroundMonitorForAllowPopupsecondsToWaitForDialog != null)
                {
                    mSOutlookBackgroundMonitorForAllowPopup["SecondsToWaitForDialog"] = CSharpExpressionConverter.ConvertToken(mSOutlookBackgroundMonitorForAllowPopupsecondsToWaitForDialog);
                    mSOutlookBackgroundMonitorForAllowPopuppropCount++;
                }

                mSOutlookBackgroundMonitorForAllowPopuppropCount++;
            }
            else
            {
                mSOutlookBackgroundMonitorForAllowPopup["SecondsToWaitForDialog"] = 10;
                mSOutlookBackgroundMonitorForAllowPopuppropCount++;
            }

            if (mSOutlookBackgroundMonitorForAllowPopupsecondsToWaitForAllowButton != null)
            {
                if (mSOutlookBackgroundMonitorForAllowPopupsecondsToWaitForAllowButton != null)
                {
                    mSOutlookBackgroundMonitorForAllowPopup["SecondsToWaitForAllowButton"] = CSharpExpressionConverter.ConvertToken(mSOutlookBackgroundMonitorForAllowPopupsecondsToWaitForAllowButton);
                    mSOutlookBackgroundMonitorForAllowPopuppropCount++;
                }

                mSOutlookBackgroundMonitorForAllowPopuppropCount++;
            }
            else
            {
                mSOutlookBackgroundMonitorForAllowPopup["SecondsToWaitForAllowButton"] = 10;
                mSOutlookBackgroundMonitorForAllowPopuppropCount++;
            }

            if (mSOutlookBackgroundMonitorForAllowPopupsecondsToWaitForAllowButtonToBeEnabled != null)
            {
                if (mSOutlookBackgroundMonitorForAllowPopupsecondsToWaitForAllowButtonToBeEnabled != null)
                {
                    mSOutlookBackgroundMonitorForAllowPopup["SecondsToWaitForAllowButtonToBeEnabled"] = CSharpExpressionConverter.ConvertToken(mSOutlookBackgroundMonitorForAllowPopupsecondsToWaitForAllowButtonToBeEnabled);
                    mSOutlookBackgroundMonitorForAllowPopuppropCount++;
                }

                mSOutlookBackgroundMonitorForAllowPopuppropCount++;
            }
            else
            {
                mSOutlookBackgroundMonitorForAllowPopup["SecondsToWaitForAllowButtonToBeEnabled"] = 10;
                mSOutlookBackgroundMonitorForAllowPopuppropCount++;
            }

            if (mSOutlookBackgroundMonitorForAllowPopupoutlookAllowButtonName != null)
            {
                if (mSOutlookBackgroundMonitorForAllowPopupoutlookAllowButtonName != null)
                {
                    mSOutlookBackgroundMonitorForAllowPopup["OutlookAllowButtonName"] = CSharpExpressionConverter.ConvertToken(mSOutlookBackgroundMonitorForAllowPopupoutlookAllowButtonName);
                    mSOutlookBackgroundMonitorForAllowPopuppropCount++;
                }

                mSOutlookBackgroundMonitorForAllowPopuppropCount++;
            }
            else
            {
                mSOutlookBackgroundMonitorForAllowPopup["OutlookAllowButtonName"] = "Allow";
                mSOutlookBackgroundMonitorForAllowPopuppropCount++;
            }

            mSOutlookBackgroundMonitorForAllowPopuppropCount++;
            mSOutlookBackgroundMonitorForAllowPopup["Workflow"] = CSharpExpressionConverter.ConvertToken(mSOutlookBackgroundMonitorForAllowPopupworkflow);
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
                if (mSOutlookSetAllowPopupDetailsoutlookAllowButtonName != null)
                {
                    mSOutlookSetAllowPopupDetails["OutlookAllowButtonName"] = CSharpExpressionConverter.ConvertToken(mSOutlookSetAllowPopupDetailsoutlookAllowButtonName);
                    mSOutlookSetAllowPopupDetailspropCount++;
                }

                mSOutlookSetAllowPopupDetailspropCount++;
            }
            else
            {
                mSOutlookSetAllowPopupDetails["OutlookAllowButtonName"] = "Allow";
                mSOutlookSetAllowPopupDetailspropCount++;
            }

            if (mSOutlookSetAllowPopupDetailsoutlookAllowButtonAutomationId != null)
            {
                if (mSOutlookSetAllowPopupDetailsoutlookAllowButtonAutomationId != null)
                {
                    mSOutlookSetAllowPopupDetails["OutlookAllowButtonAutomationId"] = CSharpExpressionConverter.ConvertToken(mSOutlookSetAllowPopupDetailsoutlookAllowButtonAutomationId);
                    mSOutlookSetAllowPopupDetailspropCount++;
                }

                mSOutlookSetAllowPopupDetailspropCount++;
            }
            else
            {
                mSOutlookSetAllowPopupDetails["OutlookAllowButtonAutomationId"] = "4774";
                mSOutlookSetAllowPopupDetailspropCount++;
            }

            if (mSOutlookSetAllowPopupDetailsoutlookAllowCheckboxAutomationId != null)
            {
                if (mSOutlookSetAllowPopupDetailsoutlookAllowCheckboxAutomationId != null)
                {
                    mSOutlookSetAllowPopupDetails["OutlookAllowCheckboxAutomationId"] = CSharpExpressionConverter.ConvertToken(mSOutlookSetAllowPopupDetailsoutlookAllowCheckboxAutomationId);
                    mSOutlookSetAllowPopupDetailspropCount++;
                }

                mSOutlookSetAllowPopupDetailspropCount++;
            }
            else
            {
                mSOutlookSetAllowPopupDetails["OutlookAllowCheckboxAutomationId"] = "4771";
                mSOutlookSetAllowPopupDetailspropCount++;
            }

            mSOutlookSetAllowPopupDetailspropCount++;
            mSOutlookSetAllowPopupDetails["Workflow"] = CSharpExpressionConverter.ConvertToken(mSOutlookSetAllowPopupDetailsworkflow);
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
            mSOutlookExecuteCommandBarObject["ObjectId"] = CSharpExpressionConverter.ConvertToken(mSOutlookExecuteCommandBarObjectobjectId);
            if (mSOutlookExecuteCommandBarObjectrunInBackground != null)
            {
                if (mSOutlookExecuteCommandBarObjectrunInBackground != null)
                {
                    mSOutlookExecuteCommandBarObject["RunInBackground"] = CSharpExpressionConverter.ConvertToken(mSOutlookExecuteCommandBarObjectrunInBackground);
                    mSOutlookExecuteCommandBarObjectpropCount++;
                }

                mSOutlookExecuteCommandBarObjectpropCount++;
            }
            else
            {
                mSOutlookExecuteCommandBarObject["RunInBackground"] = false;
                mSOutlookExecuteCommandBarObjectpropCount++;
            }

            mSOutlookExecuteCommandBarObjectpropCount++;
            mSOutlookExecuteCommandBarObject["Workflow"] = CSharpExpressionConverter.ConvertToken(mSOutlookExecuteCommandBarObjectworkflow);
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
                mSOutlookGetEmails["FolderPath"] = CSharpExpressionConverter.ConvertToken(mSOutlookGetEmailsfolderPath);
                mSOutlookGetEmailspropCount++;
            }

            if (mSOutlookGetEmailssearchRead != null)
            {
                if (mSOutlookGetEmailssearchRead != null)
                {
                    mSOutlookGetEmails["SearchRead"] = CSharpExpressionConverter.ConvertToken(mSOutlookGetEmailssearchRead);
                    mSOutlookGetEmailspropCount++;
                }

                mSOutlookGetEmailspropCount++;
            }
            else
            {
                mSOutlookGetEmails["SearchRead"] = false;
                mSOutlookGetEmailspropCount++;
            }

            if (mSOutlookGetEmailssearchUnread != null)
            {
                if (mSOutlookGetEmailssearchUnread != null)
                {
                    mSOutlookGetEmails["SearchUnread"] = CSharpExpressionConverter.ConvertToken(mSOutlookGetEmailssearchUnread);
                    mSOutlookGetEmailspropCount++;
                }

                mSOutlookGetEmailspropCount++;
            }
            else
            {
                mSOutlookGetEmails["SearchUnread"] = true;
                mSOutlookGetEmailspropCount++;
            }

            if (mSOutlookGetEmailssearchSubject != null)
            {
                mSOutlookGetEmails["SearchSubject"] = CSharpExpressionConverter.ConvertToken(mSOutlookGetEmailssearchSubject);
                mSOutlookGetEmailspropCount++;
            }

            if (mSOutlookGetEmailssearchFromSMTP != null)
            {
                mSOutlookGetEmails["SearchFromSMTP"] = CSharpExpressionConverter.ConvertToken(mSOutlookGetEmailssearchFromSMTP);
                mSOutlookGetEmailspropCount++;
            }

            if (mSOutlookGetEmailssearchFromName != null)
            {
                mSOutlookGetEmails["SearchFromName"] = CSharpExpressionConverter.ConvertToken(mSOutlookGetEmailssearchFromName);
                mSOutlookGetEmailspropCount++;
            }

            if (mSOutlookGetEmailssearchQuery != null)
            {
                mSOutlookGetEmails["SearchQuery"] = CSharpExpressionConverter.ConvertToken(mSOutlookGetEmailssearchQuery);
                mSOutlookGetEmailspropCount++;
            }

            if (mSOutlookGetEmailssearchMaxAgeInDays != null)
            {
                if (mSOutlookGetEmailssearchMaxAgeInDays != null)
                {
                    mSOutlookGetEmails["SearchMaxAgeInDays"] = CSharpExpressionConverter.ConvertToken(mSOutlookGetEmailssearchMaxAgeInDays);
                    mSOutlookGetEmailspropCount++;
                }

                mSOutlookGetEmailspropCount++;
            }
            else
            {
                mSOutlookGetEmails["SearchMaxAgeInDays"] = -1;
                mSOutlookGetEmailspropCount++;
            }

            if (mSOutlookGetEmailssearchStartDateTimeAsString != null)
            {
                mSOutlookGetEmails["SearchStartDateTimeAsString"] = CSharpExpressionConverter.ConvertToken(mSOutlookGetEmailssearchStartDateTimeAsString);
                mSOutlookGetEmailspropCount++;
            }

            if (mSOutlookGetEmailssearchEndDateTimeAsString != null)
            {
                mSOutlookGetEmails["SearchEndDateTimeAsString"] = CSharpExpressionConverter.ConvertToken(mSOutlookGetEmailssearchEndDateTimeAsString);
                mSOutlookGetEmailspropCount++;
            }

            if (mSOutlookGetEmailsmaxResultsToReturn != null)
            {
                if (mSOutlookGetEmailsmaxResultsToReturn != null)
                {
                    mSOutlookGetEmails["MaxResultsToReturn"] = CSharpExpressionConverter.ConvertToken(mSOutlookGetEmailsmaxResultsToReturn);
                    mSOutlookGetEmailspropCount++;
                }

                mSOutlookGetEmailspropCount++;
            }
            else
            {
                mSOutlookGetEmails["MaxResultsToReturn"] = 0;
                mSOutlookGetEmailspropCount++;
            }

            if (mSOutlookGetEmailsclickAllowButtonIfRequired != null)
            {
                if (mSOutlookGetEmailsclickAllowButtonIfRequired != null)
                {
                    mSOutlookGetEmails["ClickAllowButtonIfRequired"] = CSharpExpressionConverter.ConvertToken(mSOutlookGetEmailsclickAllowButtonIfRequired);
                    mSOutlookGetEmailspropCount++;
                }

                mSOutlookGetEmailspropCount++;
            }
            else
            {
                mSOutlookGetEmails["ClickAllowButtonIfRequired"] = true;
                mSOutlookGetEmailspropCount++;
            }

            mSOutlookGetEmailspropCount++;
            mSOutlookGetEmails["Workflow"] = CSharpExpressionConverter.ConvertToken(mSOutlookGetEmailsworkflow);
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
                mSOutlookGetFirstEmail["FolderPath"] = CSharpExpressionConverter.ConvertToken(mSOutlookGetFirstEmailfolderPath);
                mSOutlookGetFirstEmailpropCount++;
            }

            if (mSOutlookGetFirstEmailsearchRead != null)
            {
                if (mSOutlookGetFirstEmailsearchRead != null)
                {
                    mSOutlookGetFirstEmail["SearchRead"] = CSharpExpressionConverter.ConvertToken(mSOutlookGetFirstEmailsearchRead);
                    mSOutlookGetFirstEmailpropCount++;
                }

                mSOutlookGetFirstEmailpropCount++;
            }
            else
            {
                mSOutlookGetFirstEmail["SearchRead"] = false;
                mSOutlookGetFirstEmailpropCount++;
            }

            if (mSOutlookGetFirstEmailsearchUnread != null)
            {
                if (mSOutlookGetFirstEmailsearchUnread != null)
                {
                    mSOutlookGetFirstEmail["SearchUnread"] = CSharpExpressionConverter.ConvertToken(mSOutlookGetFirstEmailsearchUnread);
                    mSOutlookGetFirstEmailpropCount++;
                }

                mSOutlookGetFirstEmailpropCount++;
            }
            else
            {
                mSOutlookGetFirstEmail["SearchUnread"] = true;
                mSOutlookGetFirstEmailpropCount++;
            }

            if (mSOutlookGetFirstEmailsearchSubject != null)
            {
                mSOutlookGetFirstEmail["SearchSubject"] = CSharpExpressionConverter.ConvertToken(mSOutlookGetFirstEmailsearchSubject);
                mSOutlookGetFirstEmailpropCount++;
            }

            if (mSOutlookGetFirstEmailsearchFromSMTP != null)
            {
                mSOutlookGetFirstEmail["SearchFromSMTP"] = CSharpExpressionConverter.ConvertToken(mSOutlookGetFirstEmailsearchFromSMTP);
                mSOutlookGetFirstEmailpropCount++;
            }

            if (mSOutlookGetFirstEmailsearchFromName != null)
            {
                mSOutlookGetFirstEmail["SearchFromName"] = CSharpExpressionConverter.ConvertToken(mSOutlookGetFirstEmailsearchFromName);
                mSOutlookGetFirstEmailpropCount++;
            }

            if (mSOutlookGetFirstEmailsearchQuery != null)
            {
                mSOutlookGetFirstEmail["SearchQuery"] = CSharpExpressionConverter.ConvertToken(mSOutlookGetFirstEmailsearchQuery);
                mSOutlookGetFirstEmailpropCount++;
            }

            if (mSOutlookGetFirstEmailsearchMaxAgeInDays != null)
            {
                if (mSOutlookGetFirstEmailsearchMaxAgeInDays != null)
                {
                    mSOutlookGetFirstEmail["SearchMaxAgeInDays"] = CSharpExpressionConverter.ConvertToken(mSOutlookGetFirstEmailsearchMaxAgeInDays);
                    mSOutlookGetFirstEmailpropCount++;
                }

                mSOutlookGetFirstEmailpropCount++;
            }
            else
            {
                mSOutlookGetFirstEmail["SearchMaxAgeInDays"] = -1;
                mSOutlookGetFirstEmailpropCount++;
            }

            if (mSOutlookGetFirstEmailsearchStartDateTimeAsString != null)
            {
                mSOutlookGetFirstEmail["SearchStartDateTimeAsString"] = CSharpExpressionConverter.ConvertToken(mSOutlookGetFirstEmailsearchStartDateTimeAsString);
                mSOutlookGetFirstEmailpropCount++;
            }

            if (mSOutlookGetFirstEmailsearchEndDateTimeAsString != null)
            {
                mSOutlookGetFirstEmail["SearchEndDateTimeAsString"] = CSharpExpressionConverter.ConvertToken(mSOutlookGetFirstEmailsearchEndDateTimeAsString);
                mSOutlookGetFirstEmailpropCount++;
            }

            if (mSOutlookGetFirstEmailclickAllowButtonIfRequired != null)
            {
                if (mSOutlookGetFirstEmailclickAllowButtonIfRequired != null)
                {
                    mSOutlookGetFirstEmail["ClickAllowButtonIfRequired"] = CSharpExpressionConverter.ConvertToken(mSOutlookGetFirstEmailclickAllowButtonIfRequired);
                    mSOutlookGetFirstEmailpropCount++;
                }

                mSOutlookGetFirstEmailpropCount++;
            }
            else
            {
                mSOutlookGetFirstEmail["ClickAllowButtonIfRequired"] = true;
                mSOutlookGetFirstEmailpropCount++;
            }

            mSOutlookGetFirstEmailpropCount++;
            mSOutlookGetFirstEmail["Workflow"] = CSharpExpressionConverter.ConvertToken(mSOutlookGetFirstEmailworkflow);
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
                mSOutlookGetNumberOfEmails["FolderPath"] = CSharpExpressionConverter.ConvertToken(mSOutlookGetNumberOfEmailsfolderPath);
                mSOutlookGetNumberOfEmailspropCount++;
            }

            if (mSOutlookGetNumberOfEmailssearchRead != null)
            {
                if (mSOutlookGetNumberOfEmailssearchRead != null)
                {
                    mSOutlookGetNumberOfEmails["SearchRead"] = CSharpExpressionConverter.ConvertToken(mSOutlookGetNumberOfEmailssearchRead);
                    mSOutlookGetNumberOfEmailspropCount++;
                }

                mSOutlookGetNumberOfEmailspropCount++;
            }
            else
            {
                mSOutlookGetNumberOfEmails["SearchRead"] = false;
                mSOutlookGetNumberOfEmailspropCount++;
            }

            if (mSOutlookGetNumberOfEmailssearchUnread != null)
            {
                if (mSOutlookGetNumberOfEmailssearchUnread != null)
                {
                    mSOutlookGetNumberOfEmails["SearchUnread"] = CSharpExpressionConverter.ConvertToken(mSOutlookGetNumberOfEmailssearchUnread);
                    mSOutlookGetNumberOfEmailspropCount++;
                }

                mSOutlookGetNumberOfEmailspropCount++;
            }
            else
            {
                mSOutlookGetNumberOfEmails["SearchUnread"] = true;
                mSOutlookGetNumberOfEmailspropCount++;
            }

            if (mSOutlookGetNumberOfEmailssearchSubject != null)
            {
                mSOutlookGetNumberOfEmails["SearchSubject"] = CSharpExpressionConverter.ConvertToken(mSOutlookGetNumberOfEmailssearchSubject);
                mSOutlookGetNumberOfEmailspropCount++;
            }

            if (mSOutlookGetNumberOfEmailssearchFromSMTP != null)
            {
                mSOutlookGetNumberOfEmails["SearchFromSMTP"] = CSharpExpressionConverter.ConvertToken(mSOutlookGetNumberOfEmailssearchFromSMTP);
                mSOutlookGetNumberOfEmailspropCount++;
            }

            if (mSOutlookGetNumberOfEmailssearchFromName != null)
            {
                mSOutlookGetNumberOfEmails["SearchFromName"] = CSharpExpressionConverter.ConvertToken(mSOutlookGetNumberOfEmailssearchFromName);
                mSOutlookGetNumberOfEmailspropCount++;
            }

            if (mSOutlookGetNumberOfEmailssearchQuery != null)
            {
                mSOutlookGetNumberOfEmails["SearchQuery"] = CSharpExpressionConverter.ConvertToken(mSOutlookGetNumberOfEmailssearchQuery);
                mSOutlookGetNumberOfEmailspropCount++;
            }

            if (mSOutlookGetNumberOfEmailssearchMaxAgeInDays != null)
            {
                if (mSOutlookGetNumberOfEmailssearchMaxAgeInDays != null)
                {
                    mSOutlookGetNumberOfEmails["SearchMaxAgeInDays"] = CSharpExpressionConverter.ConvertToken(mSOutlookGetNumberOfEmailssearchMaxAgeInDays);
                    mSOutlookGetNumberOfEmailspropCount++;
                }

                mSOutlookGetNumberOfEmailspropCount++;
            }
            else
            {
                mSOutlookGetNumberOfEmails["SearchMaxAgeInDays"] = -1;
                mSOutlookGetNumberOfEmailspropCount++;
            }

            if (mSOutlookGetNumberOfEmailssearchStartDateTimeAsString != null)
            {
                mSOutlookGetNumberOfEmails["SearchStartDateTimeAsString"] = CSharpExpressionConverter.ConvertToken(mSOutlookGetNumberOfEmailssearchStartDateTimeAsString);
                mSOutlookGetNumberOfEmailspropCount++;
            }

            if (mSOutlookGetNumberOfEmailssearchEndDateTimeAsString != null)
            {
                mSOutlookGetNumberOfEmails["SearchEndDateTimeAsString"] = CSharpExpressionConverter.ConvertToken(mSOutlookGetNumberOfEmailssearchEndDateTimeAsString);
                mSOutlookGetNumberOfEmailspropCount++;
            }

            mSOutlookGetNumberOfEmailspropCount++;
            mSOutlookGetNumberOfEmails["Workflow"] = CSharpExpressionConverter.ConvertToken(mSOutlookGetNumberOfEmailsworkflow);
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