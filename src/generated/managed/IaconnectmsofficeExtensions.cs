//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectmsoffice
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IaconnectmsofficeActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordCreateInstanceResponse> MSWordCreateInstance([WorkflowExpression] Func<string> mSWordCreateInstanceworkflow, [WorkflowExpression] Func<bool> mSWordCreateInstanceshowWord = null)
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
                    mSWordCreateInstance["ShowWord"] = ExpressionConverter.ConvertO(mSWordCreateInstanceshowWord);
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
            mSWordCreateInstance["Workflow"] = ExpressionConverter.ConvertO(mSWordCreateInstanceworkflow);
            if (mSWordCreateInstancepropCount > 0)
            {
                callPayload.Body = mSWordCreateInstance;
            }

            return new ApiConnectionAction<MSWordCreateInstanceResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordCloseInstance([WorkflowExpression] Func<string> mSWordCloseInstanceworkflow, [WorkflowExpression] Func<int> mSWordCloseInstancehandle = null)
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
                    mSWordCloseInstance["Handle"] = ExpressionConverter.ConvertO(mSWordCloseInstancehandle);
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
            mSWordCloseInstance["Workflow"] = ExpressionConverter.ConvertO(mSWordCloseInstanceworkflow);
            if (mSWordCloseInstancepropCount > 0)
            {
                callPayload.Body = mSWordCloseInstance;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordDetachFromInstance([WorkflowExpression] Func<string> mSWordDetachFromInstanceworkflow, [WorkflowExpression] Func<int> mSWordDetachFromInstancehandle = null)
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
                    mSWordDetachFromInstance["Handle"] = ExpressionConverter.ConvertO(mSWordDetachFromInstancehandle);
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
            mSWordDetachFromInstance["Workflow"] = ExpressionConverter.ConvertO(mSWordDetachFromInstanceworkflow);
            if (mSWordDetachFromInstancepropCount > 0)
            {
                callPayload.Body = mSWordDetachFromInstance;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordAttachToExistingInstanceResponse> MSWordAttachToExistingInstance([WorkflowExpression] Func<string> mSWordAttachToExistingInstanceworkflow, [WorkflowExpression] Func<string> mSWordAttachToExistingInstancefilename = null, [WorkflowExpression] Func<bool> mSWordAttachToExistingInstancetoggleWindow = null, [WorkflowExpression] Func<bool> mSWordAttachToExistingInstancetoggleUsesGlobalLeftMouseClickAgent = null, [WorkflowExpression] Func<double> mSWordAttachToExistingInstancetoggleDelay = null)
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
                if (mSWordAttachToExistingInstancetoggleWindow != null)
                {
                    mSWordAttachToExistingInstance["ToggleWindow"] = ExpressionConverter.ConvertO(mSWordAttachToExistingInstancetoggleWindow);
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
                    mSWordAttachToExistingInstance["ToggleUsesGlobalLeftMouseClickAgent"] = ExpressionConverter.ConvertO(mSWordAttachToExistingInstancetoggleUsesGlobalLeftMouseClickAgent);
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
                    mSWordAttachToExistingInstance["ToggleDelay"] = ExpressionConverter.ConvertO(mSWordAttachToExistingInstancetoggleDelay);
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
            mSWordAttachToExistingInstance["Workflow"] = ExpressionConverter.ConvertO(mSWordAttachToExistingInstanceworkflow);
            if (mSWordAttachToExistingInstancepropCount > 0)
            {
                callPayload.Body = mSWordAttachToExistingInstance;
            }

            return new ApiConnectionAction<MSWordAttachToExistingInstanceResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordShowWord([WorkflowExpression] Func<string> mSWordShowWordworkflow, [WorkflowExpression] Func<int> mSWordShowWordhandle = null)
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
                    mSWordShowWord["Handle"] = ExpressionConverter.ConvertO(mSWordShowWordhandle);
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
            mSWordShowWord["Workflow"] = ExpressionConverter.ConvertO(mSWordShowWordworkflow);
            if (mSWordShowWordpropCount > 0)
            {
                callPayload.Body = mSWordShowWord;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordHideWord([WorkflowExpression] Func<string> mSWordHideWordworkflow, [WorkflowExpression] Func<int> mSWordHideWordhandle = null)
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
                    mSWordHideWord["Handle"] = ExpressionConverter.ConvertO(mSWordHideWordhandle);
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
            mSWordHideWord["Workflow"] = ExpressionConverter.ConvertO(mSWordHideWordworkflow);
            if (mSWordHideWordpropCount > 0)
            {
                callPayload.Body = mSWordHideWord;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordCreateDocumentResponse> MSWordCreateDocument([WorkflowExpression] Func<string> mSWordCreateDocumentworkflow, [WorkflowExpression] Func<int> mSWordCreateDocumenthandle = null)
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
                    mSWordCreateDocument["Handle"] = ExpressionConverter.ConvertO(mSWordCreateDocumenthandle);
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
            mSWordCreateDocument["Workflow"] = ExpressionConverter.ConvertO(mSWordCreateDocumentworkflow);
            if (mSWordCreateDocumentpropCount > 0)
            {
                callPayload.Body = mSWordCreateDocument;
            }

            return new ApiConnectionAction<MSWordCreateDocumentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordOpenDocumentResponse> MSWordOpenDocument([WorkflowExpression] Func<string> mSWordOpenDocumentfilename, [WorkflowExpression] Func<string> mSWordOpenDocumentworkflow, [WorkflowExpression] Func<int> mSWordOpenDocumenthandle = null, [WorkflowExpression] Func<bool> mSWordOpenDocumentopenReadOnly = null, [WorkflowExpression] Func<bool> mSWordOpenDocumentaddToRecentFiles = null, [WorkflowExpression] Func<string> mSWordOpenDocumentpassword = null, [WorkflowExpression] Func<bool> mSWordOpenDocumentopenAndRepair = null)
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
                    mSWordOpenDocument["Handle"] = ExpressionConverter.ConvertO(mSWordOpenDocumenthandle);
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
            mSWordOpenDocument["Filename"] = ExpressionConverter.ConvertO(mSWordOpenDocumentfilename);
            if (mSWordOpenDocumentopenReadOnly != null)
            {
                if (mSWordOpenDocumentopenReadOnly != null)
                {
                    mSWordOpenDocument["OpenReadOnly"] = ExpressionConverter.ConvertO(mSWordOpenDocumentopenReadOnly);
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
                    mSWordOpenDocument["AddToRecentFiles"] = ExpressionConverter.ConvertO(mSWordOpenDocumentaddToRecentFiles);
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
                mSWordOpenDocument["Password"] = ExpressionConverter.ConvertO(mSWordOpenDocumentpassword);
                mSWordOpenDocumentpropCount++;
            }

            if (mSWordOpenDocumentopenAndRepair != null)
            {
                if (mSWordOpenDocumentopenAndRepair != null)
                {
                    mSWordOpenDocument["OpenAndRepair"] = ExpressionConverter.ConvertO(mSWordOpenDocumentopenAndRepair);
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
            mSWordOpenDocument["Workflow"] = ExpressionConverter.ConvertO(mSWordOpenDocumentworkflow);
            if (mSWordOpenDocumentpropCount > 0)
            {
                callPayload.Body = mSWordOpenDocument;
            }

            return new ApiConnectionAction<MSWordOpenDocumentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordSaveDocument([WorkflowExpression] Func<string> mSWordSaveDocumentworkflow, [WorkflowExpression] Func<int> mSWordSaveDocumenthandle = null, [WorkflowExpression] Func<string> mSWordSaveDocumentdocumentName = null)
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
                    mSWordSaveDocument["Handle"] = ExpressionConverter.ConvertO(mSWordSaveDocumenthandle);
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
        public IBodyWorkflowAction<MSWordSaveAsDocumentResponse> MSWordSaveAsDocument([WorkflowExpression] Func<string> mSWordSaveAsDocumentsaveFilename, [WorkflowExpression] Func<string> mSWordSaveAsDocumentworkflow, [WorkflowExpression] Func<int> mSWordSaveAsDocumenthandle = null, [WorkflowExpression] Func<string> mSWordSaveAsDocumentdocumentName = null)
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
                    mSWordSaveAsDocument["Handle"] = ExpressionConverter.ConvertO(mSWordSaveAsDocumenthandle);
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
        public IWorkflowAction MSWordCloseDocument([WorkflowExpression] Func<string> mSWordCloseDocumentworkflow, [WorkflowExpression] Func<int> mSWordCloseDocumenthandle = null, [WorkflowExpression] Func<string> mSWordCloseDocumentdocumentName = null)
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
                    mSWordCloseDocument["Handle"] = ExpressionConverter.ConvertO(mSWordCloseDocumenthandle);
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
        public IWorkflowAction MSWordTypeText([WorkflowExpression] Func<string> mSWordTypeTexttext, [WorkflowExpression] Func<string> mSWordTypeTextworkflow, [WorkflowExpression] Func<int> mSWordTypeTexthandle = null)
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
                    mSWordTypeText["Handle"] = ExpressionConverter.ConvertO(mSWordTypeTexthandle);
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
        public IWorkflowAction MSWordSelectAll([WorkflowExpression] Func<string> mSWordSelectAllworkflow, [WorkflowExpression] Func<int> mSWordSelectAllhandle = null, [WorkflowExpression] Func<string> mSWordSelectAlldocumentName = null)
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
                    mSWordSelectAll["Handle"] = ExpressionConverter.ConvertO(mSWordSelectAllhandle);
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
        public IWorkflowAction MSWordSelectRange([WorkflowExpression] Func<int> mSWordSelectRangestart, [WorkflowExpression] Func<int> mSWordSelectRangefinish, [WorkflowExpression] Func<string> mSWordSelectRangeworkflow, [WorkflowExpression] Func<int> mSWordSelectRangehandle = null, [WorkflowExpression] Func<string> mSWordSelectRangedocumentName = null)
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
                    mSWordSelectRange["Handle"] = ExpressionConverter.ConvertO(mSWordSelectRangehandle);
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
        public IWorkflowAction MSWordCopyToClipboard([WorkflowExpression] Func<string> mSWordCopyToClipboardworkflow, [WorkflowExpression] Func<int> mSWordCopyToClipboardhandle = null)
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
                    mSWordCopyToClipboard["Handle"] = ExpressionConverter.ConvertO(mSWordCopyToClipboardhandle);
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
            mSWordCopyToClipboard["Workflow"] = ExpressionConverter.ConvertO(mSWordCopyToClipboardworkflow);
            if (mSWordCopyToClipboardpropCount > 0)
            {
                callPayload.Body = mSWordCopyToClipboard;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordPasteFromClipboard([WorkflowExpression] Func<string> mSWordPasteFromClipboardworkflow, [WorkflowExpression] Func<int> mSWordPasteFromClipboardhandle = null)
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
                    mSWordPasteFromClipboard["Handle"] = ExpressionConverter.ConvertO(mSWordPasteFromClipboardhandle);
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
            mSWordPasteFromClipboard["Workflow"] = ExpressionConverter.ConvertO(mSWordPasteFromClipboardworkflow);
            if (mSWordPasteFromClipboardpropCount > 0)
            {
                callPayload.Body = mSWordPasteFromClipboard;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordClearClipboard([WorkflowExpression] Func<string> mSWordClearClipboardworkflow)
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
        public IBodyWorkflowAction<MSWordGetDocumentBodyTextResponse> MSWordGetDocumentBodyText([WorkflowExpression] Func<int> mSWordGetDocumentBodyTextstart, [WorkflowExpression] Func<int> mSWordGetDocumentBodyTextfinish, [WorkflowExpression] Func<string> mSWordGetDocumentBodyTextworkflow, [WorkflowExpression] Func<int> mSWordGetDocumentBodyTexthandle = null, [WorkflowExpression] Func<string> mSWordGetDocumentBodyTextdocumentName = null)
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
                    mSWordGetDocumentBodyText["Handle"] = ExpressionConverter.ConvertO(mSWordGetDocumentBodyTexthandle);
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
        public IBodyWorkflowAction<MSWordGetNumberOfTablesInDocumentResponse> MSWordGetNumberOfTablesInDocument([WorkflowExpression] Func<string> mSWordGetNumberOfTablesInDocumentworkflow, [WorkflowExpression] Func<int> mSWordGetNumberOfTablesInDocumenthandle = null, [WorkflowExpression] Func<string> mSWordGetNumberOfTablesInDocumentdocumentName = null)
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
                    mSWordGetNumberOfTablesInDocument["Handle"] = ExpressionConverter.ConvertO(mSWordGetNumberOfTablesInDocumenthandle);
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
        public IWorkflowAction MSWordUpdateBookmark([WorkflowExpression] Func<string> mSWordUpdateBookmarkbookmarkName, [WorkflowExpression] Func<string> mSWordUpdateBookmarkworkflow, [WorkflowExpression] Func<int> mSWordUpdateBookmarkhandle = null, [WorkflowExpression] Func<string> mSWordUpdateBookmarkdocumentName = null, [WorkflowExpression] Func<string> mSWordUpdateBookmarknewValue = null)
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
                    mSWordUpdateBookmark["Handle"] = ExpressionConverter.ConvertO(mSWordUpdateBookmarkhandle);
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
        public IWorkflowAction MSWordSelectTable([WorkflowExpression] Func<int> mSWordSelectTabletableIndex, [WorkflowExpression] Func<string> mSWordSelectTableworkflow, [WorkflowExpression] Func<int> mSWordSelectTablehandle = null, [WorkflowExpression] Func<string> mSWordSelectTabledocumentName = null)
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
                    mSWordSelectTable["Handle"] = ExpressionConverter.ConvertO(mSWordSelectTablehandle);
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
        public IBodyWorkflowAction<MSWordGetTableBoundsResponse> MSWordGetTableBounds([WorkflowExpression] Func<int> mSWordGetTableBoundstableIndex, [WorkflowExpression] Func<string> mSWordGetTableBoundsworkflow, [WorkflowExpression] Func<int> mSWordGetTableBoundshandle = null, [WorkflowExpression] Func<string> mSWordGetTableBoundsdocumentName = null)
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
                    mSWordGetTableBounds["Handle"] = ExpressionConverter.ConvertO(mSWordGetTableBoundshandle);
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
        public IWorkflowAction MSWordSelectTableCell([WorkflowExpression] Func<int> mSWordSelectTableCelltableIndex, [WorkflowExpression] Func<int> mSWordSelectTableCellrowIndex, [WorkflowExpression] Func<int> mSWordSelectTableCellcolumnIndex, [WorkflowExpression] Func<string> mSWordSelectTableCellworkflow, [WorkflowExpression] Func<int> mSWordSelectTableCellhandle = null, [WorkflowExpression] Func<string> mSWordSelectTableCelldocumentName = null)
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
                    mSWordSelectTableCell["Handle"] = ExpressionConverter.ConvertO(mSWordSelectTableCellhandle);
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
        public IBodyWorkflowAction<MSWordGetTableCellTextValueResponse> MSWordGetTableCellTextValue([WorkflowExpression] Func<int> mSWordGetTableCellTextValuetableIndex, [WorkflowExpression] Func<int> mSWordGetTableCellTextValuerowIndex, [WorkflowExpression] Func<int> mSWordGetTableCellTextValuecolumnIndex, [WorkflowExpression] Func<string> mSWordGetTableCellTextValueworkflow, [WorkflowExpression] Func<int> mSWordGetTableCellTextValuehandle = null, [WorkflowExpression] Func<string> mSWordGetTableCellTextValuedocumentName = null)
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
                    mSWordGetTableCellTextValue["Handle"] = ExpressionConverter.ConvertO(mSWordGetTableCellTextValuehandle);
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
        public IBodyWorkflowAction<MSWordGetTableCellTextValueTrimmedResponse> MSWordGetTableCellTextValueTrimmed([WorkflowExpression] Func<int> mSWordGetTableCellTextValueTrimmedtableIndex, [WorkflowExpression] Func<int> mSWordGetTableCellTextValueTrimmedrowIndex, [WorkflowExpression] Func<int> mSWordGetTableCellTextValueTrimmedcolumnIndex, [WorkflowExpression] Func<string> mSWordGetTableCellTextValueTrimmedworkflow, [WorkflowExpression] Func<int> mSWordGetTableCellTextValueTrimmedhandle = null, [WorkflowExpression] Func<string> mSWordGetTableCellTextValueTrimmeddocumentName = null)
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
                    mSWordGetTableCellTextValueTrimmed["Handle"] = ExpressionConverter.ConvertO(mSWordGetTableCellTextValueTrimmedhandle);
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
        public IWorkflowAction MSWordSetTableCellTextValue([WorkflowExpression] Func<int> mSWordSetTableCellTextValuetableIndex, [WorkflowExpression] Func<int> mSWordSetTableCellTextValuerowIndex, [WorkflowExpression] Func<int> mSWordSetTableCellTextValuecolumnIndex, [WorkflowExpression] Func<string> mSWordSetTableCellTextValueworkflow, [WorkflowExpression] Func<int> mSWordSetTableCellTextValuehandle = null, [WorkflowExpression] Func<string> mSWordSetTableCellTextValuedocumentName = null, [WorkflowExpression] Func<string> mSWordSetTableCellTextValuenewCellText = null)
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
                    mSWordSetTableCellTextValue["Handle"] = ExpressionConverter.ConvertO(mSWordSetTableCellTextValuehandle);
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
        public IWorkflowAction MSWordExportDocumentAsPDF([WorkflowExpression] Func<string> mSWordExportDocumentAsPDFsaveFileName, [WorkflowExpression] Func<string> mSWordExportDocumentAsPDFworkflow, [WorkflowExpression] Func<int> mSWordExportDocumentAsPDFhandle = null, [WorkflowExpression] Func<string> mSWordExportDocumentAsPDFdocumentName = null)
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
                    mSWordExportDocumentAsPDF["Handle"] = ExpressionConverter.ConvertO(mSWordExportDocumentAsPDFhandle);
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
        public IWorkflowAction MSWordAddTable([WorkflowExpression] Func<int> mSWordAddTablenumberOfRows, [WorkflowExpression] Func<int> mSWordAddTablenumberOfColumns, [WorkflowExpression] Func<string> mSWordAddTableworkflow, [WorkflowExpression] Func<int> mSWordAddTablehandle = null, [WorkflowExpression] Func<string> mSWordAddTabledocumentName = null, [WorkflowExpression] Func<int> mSWordAddTableautoFitBehaviour = null)
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
                    mSWordAddTable["Handle"] = ExpressionConverter.ConvertO(mSWordAddTablehandle);
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
                mSWordAddTable["DocumentName"] = ExpressionConverter.ConvertO(mSWordAddTabledocumentName);
                mSWordAddTablepropCount++;
            }

            mSWordAddTablepropCount++;
            mSWordAddTable["NumberOfRows"] = ExpressionConverter.ConvertO(mSWordAddTablenumberOfRows);
            mSWordAddTablepropCount++;
            mSWordAddTable["NumberOfColumns"] = ExpressionConverter.ConvertO(mSWordAddTablenumberOfColumns);
            if (mSWordAddTableautoFitBehaviour != null)
            {
                if (mSWordAddTableautoFitBehaviour != null)
                {
                    mSWordAddTable["AutoFitBehaviour"] = ExpressionConverter.ConvertO(mSWordAddTableautoFitBehaviour);
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
            mSWordAddTable["Workflow"] = ExpressionConverter.ConvertO(mSWordAddTableworkflow);
            if (mSWordAddTablepropCount > 0)
            {
                callPayload.Body = mSWordAddTable;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordAddTableRow([WorkflowExpression] Func<int> mSWordAddTableRowtableIndex, [WorkflowExpression] Func<string> mSWordAddTableRowworkflow, [WorkflowExpression] Func<int> mSWordAddTableRowhandle = null, [WorkflowExpression] Func<string> mSWordAddTableRowdocumentName = null)
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
                    mSWordAddTableRow["Handle"] = ExpressionConverter.ConvertO(mSWordAddTableRowhandle);
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
        public IWorkflowAction MSWordAddTableColumn([WorkflowExpression] Func<int> mSWordAddTableColumntableIndex, [WorkflowExpression] Func<string> mSWordAddTableColumnworkflow, [WorkflowExpression] Func<int> mSWordAddTableColumnhandle = null, [WorkflowExpression] Func<string> mSWordAddTableColumndocumentName = null)
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
                    mSWordAddTableColumn["Handle"] = ExpressionConverter.ConvertO(mSWordAddTableColumnhandle);
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
        public IBodyWorkflowAction<MSWordGetHighlightedTextResponse> MSWordGetHighlightedText([WorkflowExpression] Func<string> mSWordGetHighlightedTextworkflow, [WorkflowExpression] Func<int> mSWordGetHighlightedTexthandle = null, [WorkflowExpression] Func<string> mSWordGetHighlightedTextdocumentName = null)
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
                    mSWordGetHighlightedText["Handle"] = ExpressionConverter.ConvertO(mSWordGetHighlightedTexthandle);
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
        public IBodyWorkflowAction<MSWordExecuteCommandBarObjectResponse> MSWordExecuteCommandBarObject([WorkflowExpression] Func<string> mSWordExecuteCommandBarObjectobjectId, [WorkflowExpression] Func<string> mSWordExecuteCommandBarObjectworkflow, [WorkflowExpression] Func<int> mSWordExecuteCommandBarObjecthandle = null, [WorkflowExpression] Func<bool> mSWordExecuteCommandBarObjectrunInBackground = null)
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
                    mSWordExecuteCommandBarObject["Handle"] = ExpressionConverter.ConvertO(mSWordExecuteCommandBarObjecthandle);
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
            mSWordExecuteCommandBarObject["ObjectId"] = ExpressionConverter.ConvertO(mSWordExecuteCommandBarObjectobjectId);
            if (mSWordExecuteCommandBarObjectrunInBackground != null)
            {
                if (mSWordExecuteCommandBarObjectrunInBackground != null)
                {
                    mSWordExecuteCommandBarObject["RunInBackground"] = ExpressionConverter.ConvertO(mSWordExecuteCommandBarObjectrunInBackground);
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
            mSWordExecuteCommandBarObject["Workflow"] = ExpressionConverter.ConvertO(mSWordExecuteCommandBarObjectworkflow);
            if (mSWordExecuteCommandBarObjectpropCount > 0)
            {
                callPayload.Body = mSWordExecuteCommandBarObject;
            }

            return new ApiConnectionAction<MSWordExecuteCommandBarObjectResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordSetDocumentSensitivityLabelResponse> MSWordSetDocumentSensitivityLabel([WorkflowExpression] Func<mSWordSetDocumentSensitivityLabelassignmentMethodInput> mSWordSetDocumentSensitivityLabelassignmentMethod, [WorkflowExpression] Func<string> mSWordSetDocumentSensitivityLabellabelId, [WorkflowExpression] Func<string> mSWordSetDocumentSensitivityLabelworkflow, [WorkflowExpression] Func<int> mSWordSetDocumentSensitivityLabelhandle = null, [WorkflowExpression] Func<string> mSWordSetDocumentSensitivityLabeldocumentName = null, [WorkflowExpression] Func<string> mSWordSetDocumentSensitivityLabellabelName = null, [WorkflowExpression] Func<string> mSWordSetDocumentSensitivityLabelsiteId = null, [WorkflowExpression] Func<string> mSWordSetDocumentSensitivityLabeljustification = null)
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
                    mSWordSetDocumentSensitivityLabel["Handle"] = ExpressionConverter.ConvertO(mSWordSetDocumentSensitivityLabelhandle);
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
        public IBodyWorkflowAction<MSWordGetDocumentSensitivityLabelResponse> MSWordGetDocumentSensitivityLabel([WorkflowExpression] Func<string> mSWordGetDocumentSensitivityLabelworkflow, [WorkflowExpression] Func<int> mSWordGetDocumentSensitivityLabelhandle = null, [WorkflowExpression] Func<string> mSWordGetDocumentSensitivityLabeldocumentName = null)
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
                    mSWordGetDocumentSensitivityLabel["Handle"] = ExpressionConverter.ConvertO(mSWordGetDocumentSensitivityLabelhandle);
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
        public IBodyWorkflowAction<MSExcelCreateInstanceResponse> MSExcelCreateInstance([WorkflowExpression] Func<string> mSExcelCreateInstanceworkflow, [WorkflowExpression] Func<bool> mSExcelCreateInstanceenableEvents = null, [WorkflowExpression] Func<bool> mSExcelCreateInstanceshowExcel = null)
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
                    mSExcelCreateInstance["EnableEvents"] = ExpressionConverter.ConvertO(mSExcelCreateInstanceenableEvents);
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
                    mSExcelCreateInstance["ShowExcel"] = ExpressionConverter.ConvertO(mSExcelCreateInstanceshowExcel);
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
            mSExcelCreateInstance["Workflow"] = ExpressionConverter.ConvertO(mSExcelCreateInstanceworkflow);
            if (mSExcelCreateInstancepropCount > 0)
            {
                callPayload.Body = mSExcelCreateInstance;
            }

            return new ApiConnectionAction<MSExcelCreateInstanceResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelCloseInstance([WorkflowExpression] Func<string> mSExcelCloseInstanceworkflow, [WorkflowExpression] Func<int> mSExcelCloseInstancehandle = null)
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
                    mSExcelCloseInstance["Handle"] = ExpressionConverter.ConvertO(mSExcelCloseInstancehandle);
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
            mSExcelCloseInstance["Workflow"] = ExpressionConverter.ConvertO(mSExcelCloseInstanceworkflow);
            if (mSExcelCloseInstancepropCount > 0)
            {
                callPayload.Body = mSExcelCloseInstance;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelAttachToExistingInstanceResponse> MSExcelAttachToExistingInstance([WorkflowExpression] Func<string> mSExcelAttachToExistingInstanceworkflow, [WorkflowExpression] Func<string> mSExcelAttachToExistingInstancefilename = null, [WorkflowExpression] Func<bool> mSExcelAttachToExistingInstancetoggleWindow = null, [WorkflowExpression] Func<bool> mSExcelAttachToExistingInstancetoggleUsesGlobalLeftMouseClickAgent = null, [WorkflowExpression] Func<double> mSExcelAttachToExistingInstancetoggleDelay = null)
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
                if (mSExcelAttachToExistingInstancetoggleWindow != null)
                {
                    mSExcelAttachToExistingInstance["ToggleWindow"] = ExpressionConverter.ConvertO(mSExcelAttachToExistingInstancetoggleWindow);
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
                    mSExcelAttachToExistingInstance["ToggleUsesGlobalLeftMouseClickAgent"] = ExpressionConverter.ConvertO(mSExcelAttachToExistingInstancetoggleUsesGlobalLeftMouseClickAgent);
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
                    mSExcelAttachToExistingInstance["ToggleDelay"] = ExpressionConverter.ConvertO(mSExcelAttachToExistingInstancetoggleDelay);
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
            mSExcelAttachToExistingInstance["Workflow"] = ExpressionConverter.ConvertO(mSExcelAttachToExistingInstanceworkflow);
            if (mSExcelAttachToExistingInstancepropCount > 0)
            {
                callPayload.Body = mSExcelAttachToExistingInstance;
            }

            return new ApiConnectionAction<MSExcelAttachToExistingInstanceResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelShowExcel([WorkflowExpression] Func<string> mSExcelShowExcelworkflow, [WorkflowExpression] Func<int> mSExcelShowExcelhandle = null)
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
                    mSExcelShowExcel["Handle"] = ExpressionConverter.ConvertO(mSExcelShowExcelhandle);
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
            mSExcelShowExcel["Workflow"] = ExpressionConverter.ConvertO(mSExcelShowExcelworkflow);
            if (mSExcelShowExcelpropCount > 0)
            {
                callPayload.Body = mSExcelShowExcel;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelHideExcel([WorkflowExpression] Func<string> mSExcelHideExcelworkflow, [WorkflowExpression] Func<int> mSExcelHideExcelhandle = null)
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
                    mSExcelHideExcel["Handle"] = ExpressionConverter.ConvertO(mSExcelHideExcelhandle);
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
            mSExcelHideExcel["Workflow"] = ExpressionConverter.ConvertO(mSExcelHideExcelworkflow);
            if (mSExcelHideExcelpropCount > 0)
            {
                callPayload.Body = mSExcelHideExcel;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelOpenWorkbookResponse> MSExcelOpenWorkbook([WorkflowExpression] Func<string> mSExcelOpenWorkbookworkflow, [WorkflowExpression] Func<int> mSExcelOpenWorkbookhandle = null, [WorkflowExpression] Func<string> mSExcelOpenWorkbookfilename = null, [WorkflowExpression] Func<bool> mSExcelOpenWorkbookreadOnly = null, [WorkflowExpression] Func<bool> mSExcelOpenWorkbookupdateLinks = null, [WorkflowExpression] Func<string> mSExcelOpenWorkbookpassword = null, [WorkflowExpression] Func<bool> mSExcelOpenWorkbookenableEvents = null, [WorkflowExpression] Func<bool> mSExcelOpenWorkbookputHTTPWorkbooksIntoEditMode = null, [WorkflowExpression] Func<bool> mSExcelOpenWorkbookputFilePathWorkbooksIntoEditMode = null)
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
                    mSExcelOpenWorkbook["Handle"] = ExpressionConverter.ConvertO(mSExcelOpenWorkbookhandle);
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
                mSExcelOpenWorkbook["Filename"] = ExpressionConverter.ConvertO(mSExcelOpenWorkbookfilename);
                mSExcelOpenWorkbookpropCount++;
            }

            if (mSExcelOpenWorkbookreadOnly != null)
            {
                if (mSExcelOpenWorkbookreadOnly != null)
                {
                    mSExcelOpenWorkbook["ReadOnly"] = ExpressionConverter.ConvertO(mSExcelOpenWorkbookreadOnly);
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
                    mSExcelOpenWorkbook["UpdateLinks"] = ExpressionConverter.ConvertO(mSExcelOpenWorkbookupdateLinks);
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
                mSExcelOpenWorkbook["Password"] = ExpressionConverter.ConvertO(mSExcelOpenWorkbookpassword);
                mSExcelOpenWorkbookpropCount++;
            }

            if (mSExcelOpenWorkbookenableEvents != null)
            {
                if (mSExcelOpenWorkbookenableEvents != null)
                {
                    mSExcelOpenWorkbook["EnableEvents"] = ExpressionConverter.ConvertO(mSExcelOpenWorkbookenableEvents);
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
                    mSExcelOpenWorkbook["PutHTTPWorkbooksIntoEditMode"] = ExpressionConverter.ConvertO(mSExcelOpenWorkbookputHTTPWorkbooksIntoEditMode);
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
                    mSExcelOpenWorkbook["PutFilePathWorkbooksIntoEditMode"] = ExpressionConverter.ConvertO(mSExcelOpenWorkbookputFilePathWorkbooksIntoEditMode);
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
            mSExcelOpenWorkbook["Workflow"] = ExpressionConverter.ConvertO(mSExcelOpenWorkbookworkflow);
            if (mSExcelOpenWorkbookpropCount > 0)
            {
                callPayload.Body = mSExcelOpenWorkbook;
            }

            return new ApiConnectionAction<MSExcelOpenWorkbookResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelPutWorkbookInEditModeResponse> MSExcelPutWorkbookInEditMode([WorkflowExpression] Func<string> mSExcelPutWorkbookInEditModeworkflow, [WorkflowExpression] Func<int> mSExcelPutWorkbookInEditModehandle = null, [WorkflowExpression] Func<string> mSExcelPutWorkbookInEditModeworkbookName = null, [WorkflowExpression] Func<bool> mSExcelPutWorkbookInEditModeforce = null)
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
                    mSExcelPutWorkbookInEditMode["Handle"] = ExpressionConverter.ConvertO(mSExcelPutWorkbookInEditModehandle);
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
                mSExcelPutWorkbookInEditMode["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelPutWorkbookInEditModeworkbookName);
                mSExcelPutWorkbookInEditModepropCount++;
            }

            if (mSExcelPutWorkbookInEditModeforce != null)
            {
                if (mSExcelPutWorkbookInEditModeforce != null)
                {
                    mSExcelPutWorkbookInEditMode["Force"] = ExpressionConverter.ConvertO(mSExcelPutWorkbookInEditModeforce);
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
            mSExcelPutWorkbookInEditMode["Workflow"] = ExpressionConverter.ConvertO(mSExcelPutWorkbookInEditModeworkflow);
            if (mSExcelPutWorkbookInEditModepropCount > 0)
            {
                callPayload.Body = mSExcelPutWorkbookInEditMode;
            }

            return new ApiConnectionAction<MSExcelPutWorkbookInEditModeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelCreateWorkbookResponse> MSExcelCreateWorkbook([WorkflowExpression] Func<string> mSExcelCreateWorkbookworkflow, [WorkflowExpression] Func<int> mSExcelCreateWorkbookhandle = null)
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
                    mSExcelCreateWorkbook["Handle"] = ExpressionConverter.ConvertO(mSExcelCreateWorkbookhandle);
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
            mSExcelCreateWorkbook["Workflow"] = ExpressionConverter.ConvertO(mSExcelCreateWorkbookworkflow);
            if (mSExcelCreateWorkbookpropCount > 0)
            {
                callPayload.Body = mSExcelCreateWorkbook;
            }

            return new ApiConnectionAction<MSExcelCreateWorkbookResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelCloseWorkbook([WorkflowExpression] Func<string> mSExcelCloseWorkbookworkflow, [WorkflowExpression] Func<int> mSExcelCloseWorkbookhandle = null, [WorkflowExpression] Func<string> mSExcelCloseWorkbookworkbookName = null, [WorkflowExpression] Func<bool> mSExcelCloseWorkbooksaveData = null)
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
                    mSExcelCloseWorkbook["Handle"] = ExpressionConverter.ConvertO(mSExcelCloseWorkbookhandle);
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
                mSExcelCloseWorkbook["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelCloseWorkbookworkbookName);
                mSExcelCloseWorkbookpropCount++;
            }

            if (mSExcelCloseWorkbooksaveData != null)
            {
                if (mSExcelCloseWorkbooksaveData != null)
                {
                    mSExcelCloseWorkbook["SaveData"] = ExpressionConverter.ConvertO(mSExcelCloseWorkbooksaveData);
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
            mSExcelCloseWorkbook["Workflow"] = ExpressionConverter.ConvertO(mSExcelCloseWorkbookworkflow);
            if (mSExcelCloseWorkbookpropCount > 0)
            {
                callPayload.Body = mSExcelCloseWorkbook;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelCloseCurrentWorkbook([WorkflowExpression] Func<string> mSExcelCloseCurrentWorkbookworkflow, [WorkflowExpression] Func<int> mSExcelCloseCurrentWorkbookhandle = null)
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
                    mSExcelCloseCurrentWorkbook["Handle"] = ExpressionConverter.ConvertO(mSExcelCloseCurrentWorkbookhandle);
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
            mSExcelCloseCurrentWorkbook["Workflow"] = ExpressionConverter.ConvertO(mSExcelCloseCurrentWorkbookworkflow);
            if (mSExcelCloseCurrentWorkbookpropCount > 0)
            {
                callPayload.Body = mSExcelCloseCurrentWorkbook;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelGoToCell([WorkflowExpression] Func<string> mSExcelGoToCellcellReference, [WorkflowExpression] Func<string> mSExcelGoToCellworkflow, [WorkflowExpression] Func<int> mSExcelGoToCellhandle = null, [WorkflowExpression] Func<string> mSExcelGoToCellworkbookName = null, [WorkflowExpression] Func<string> mSExcelGoToCellworksheetName = null)
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
                    mSExcelGoToCell["Handle"] = ExpressionConverter.ConvertO(mSExcelGoToCellhandle);
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
        public IBodyWorkflowAction<MSExcelGetCellValueResponse> MSExcelGetCellValue([WorkflowExpression] Func<string> mSExcelGetCellValuecellReference, [WorkflowExpression] Func<string> mSExcelGetCellValueworkflow, [WorkflowExpression] Func<int> mSExcelGetCellValuehandle = null, [WorkflowExpression] Func<string> mSExcelGetCellValueworkbookName = null, [WorkflowExpression] Func<string> mSExcelGetCellValueworksheetName = null)
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
                    mSExcelGetCellValue["Handle"] = ExpressionConverter.ConvertO(mSExcelGetCellValuehandle);
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
        public IBodyWorkflowAction<MSExcelGetCellValue2Response> MSExcelGetCellValue2([WorkflowExpression] Func<string> mSExcelGetCellValue2cellReference, [WorkflowExpression] Func<string> mSExcelGetCellValue2workflow, [WorkflowExpression] Func<int> mSExcelGetCellValue2handle = null, [WorkflowExpression] Func<string> mSExcelGetCellValue2workbookName = null, [WorkflowExpression] Func<string> mSExcelGetCellValue2worksheetName = null)
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
                    mSExcelGetCellValue2["Handle"] = ExpressionConverter.ConvertO(mSExcelGetCellValue2handle);
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
        public IBodyWorkflowAction<MSExcelGetCellTextResponse> MSExcelGetCellText([WorkflowExpression] Func<string> mSExcelGetCellTextcellReference, [WorkflowExpression] Func<string> mSExcelGetCellTextworkflow, [WorkflowExpression] Func<int> mSExcelGetCellTexthandle = null, [WorkflowExpression] Func<string> mSExcelGetCellTextworkbookName = null, [WorkflowExpression] Func<string> mSExcelGetCellTextworksheetName = null)
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
                    mSExcelGetCellText["Handle"] = ExpressionConverter.ConvertO(mSExcelGetCellTexthandle);
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
        public IWorkflowAction MSExcelSetCellValue([WorkflowExpression] Func<string> mSExcelSetCellValuecellReference, [WorkflowExpression] Func<string> mSExcelSetCellValueworkflow, [WorkflowExpression] Func<int> mSExcelSetCellValuehandle = null, [WorkflowExpression] Func<string> mSExcelSetCellValueworkbookName = null, [WorkflowExpression] Func<string> mSExcelSetCellValueworksheetName = null, [WorkflowExpression] Func<string> mSExcelSetCellValuecellValue = null, [WorkflowExpression] Func<bool> mSExcelSetCellValuecellValueContainsStoredPassword = null)
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
                    mSExcelSetCellValue["Handle"] = ExpressionConverter.ConvertO(mSExcelSetCellValuehandle);
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
                if (mSExcelSetCellValuecellValueContainsStoredPassword != null)
                {
                    mSExcelSetCellValue["CellValueContainsStoredPassword"] = ExpressionConverter.ConvertO(mSExcelSetCellValuecellValueContainsStoredPassword);
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
            mSExcelSetCellValue["Workflow"] = ExpressionConverter.ConvertO(mSExcelSetCellValueworkflow);
            if (mSExcelSetCellValuepropCount > 0)
            {
                callPayload.Body = mSExcelSetCellValue;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelFindNextCellWithValueResponse> MSExcelFindNextCellWithValue([WorkflowExpression] Func<mSExcelFindNextCellWithValuedirectionInput> mSExcelFindNextCellWithValuedirection, [WorkflowExpression] Func<string> mSExcelFindNextCellWithValuesearchValue, [WorkflowExpression] Func<string> mSExcelFindNextCellWithValueworkflow, [WorkflowExpression] Func<int> mSExcelFindNextCellWithValuehandle = null, [WorkflowExpression] Func<string> mSExcelFindNextCellWithValueworkbookName = null, [WorkflowExpression] Func<string> mSExcelFindNextCellWithValueworksheetName = null, [WorkflowExpression] Func<bool> mSExcelFindNextCellWithValuecaseSensitive = null, [WorkflowExpression] Func<mSExcelFindNextCellWithValuecomparisonTypeInput> mSExcelFindNextCellWithValuecomparisonType = null, [WorkflowExpression] Func<int> mSExcelFindNextCellWithValuemaxCellsToSearch = null, [WorkflowExpression] Func<bool> mSExcelFindNextCellWithValueactivateCell = null)
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
                    mSExcelFindNextCellWithValue["Handle"] = ExpressionConverter.ConvertO(mSExcelFindNextCellWithValuehandle);
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
                if (mSExcelFindNextCellWithValuecaseSensitive != null)
                {
                    mSExcelFindNextCellWithValue["CaseSensitive"] = ExpressionConverter.ConvertO(mSExcelFindNextCellWithValuecaseSensitive);
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
                if (mSExcelFindNextCellWithValueactivateCell != null)
                {
                    mSExcelFindNextCellWithValue["ActivateCell"] = ExpressionConverter.ConvertO(mSExcelFindNextCellWithValueactivateCell);
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
            mSExcelFindNextCellWithValue["Workflow"] = ExpressionConverter.ConvertO(mSExcelFindNextCellWithValueworkflow);
            if (mSExcelFindNextCellWithValuepropCount > 0)
            {
                callPayload.Body = mSExcelFindNextCellWithValue;
            }

            return new ApiConnectionAction<MSExcelFindNextCellWithValueResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelFindNextEmptyCellResponse> MSExcelFindNextEmptyCell([WorkflowExpression] Func<mSExcelFindNextEmptyCelldirectionInput> mSExcelFindNextEmptyCelldirection, [WorkflowExpression] Func<string> mSExcelFindNextEmptyCellworkflow, [WorkflowExpression] Func<int> mSExcelFindNextEmptyCellhandle = null, [WorkflowExpression] Func<string> mSExcelFindNextEmptyCellworkbookName = null, [WorkflowExpression] Func<string> mSExcelFindNextEmptyCellworksheetName = null, [WorkflowExpression] Func<bool> mSExcelFindNextEmptyCellactivateCell = null)
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
                    mSExcelFindNextEmptyCell["Handle"] = ExpressionConverter.ConvertO(mSExcelFindNextEmptyCellhandle);
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
                if (mSExcelFindNextEmptyCellactivateCell != null)
                {
                    mSExcelFindNextEmptyCell["ActivateCell"] = ExpressionConverter.ConvertO(mSExcelFindNextEmptyCellactivateCell);
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
            mSExcelFindNextEmptyCell["Workflow"] = ExpressionConverter.ConvertO(mSExcelFindNextEmptyCellworkflow);
            if (mSExcelFindNextEmptyCellpropCount > 0)
            {
                callPayload.Body = mSExcelFindNextEmptyCell;
            }

            return new ApiConnectionAction<MSExcelFindNextEmptyCellResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGotoNextEmptyCellLeftResponse> MSExcelGotoNextEmptyCellLeft([WorkflowExpression] Func<string> mSExcelGotoNextEmptyCellLeftworkflow, [WorkflowExpression] Func<int> mSExcelGotoNextEmptyCellLefthandle = null, [WorkflowExpression] Func<string> mSExcelGotoNextEmptyCellLeftworkbookName = null, [WorkflowExpression] Func<string> mSExcelGotoNextEmptyCellLeftworksheetName = null)
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
                    mSExcelGotoNextEmptyCellLeft["Handle"] = ExpressionConverter.ConvertO(mSExcelGotoNextEmptyCellLefthandle);
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
        public IBodyWorkflowAction<MSExcelGotoNextEmptyCellRightResponse> MSExcelGotoNextEmptyCellRight([WorkflowExpression] Func<string> mSExcelGotoNextEmptyCellRightworkflow, [WorkflowExpression] Func<int> mSExcelGotoNextEmptyCellRighthandle = null, [WorkflowExpression] Func<string> mSExcelGotoNextEmptyCellRightworkbookName = null, [WorkflowExpression] Func<string> mSExcelGotoNextEmptyCellRightworksheetName = null)
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
                    mSExcelGotoNextEmptyCellRight["Handle"] = ExpressionConverter.ConvertO(mSExcelGotoNextEmptyCellRighthandle);
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
        public IBodyWorkflowAction<MSExcelGotoNextEmptyCellUpResponse> MSExcelGotoNextEmptyCellUp([WorkflowExpression] Func<string> mSExcelGotoNextEmptyCellUpworkflow, [WorkflowExpression] Func<int> mSExcelGotoNextEmptyCellUphandle = null, [WorkflowExpression] Func<string> mSExcelGotoNextEmptyCellUpworkbookName = null, [WorkflowExpression] Func<string> mSExcelGotoNextEmptyCellUpworksheetName = null)
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
                    mSExcelGotoNextEmptyCellUp["Handle"] = ExpressionConverter.ConvertO(mSExcelGotoNextEmptyCellUphandle);
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
        public IBodyWorkflowAction<MSExcelGotoNextEmptyCellDownResponse> MSExcelGotoNextEmptyCellDown([WorkflowExpression] Func<string> mSExcelGotoNextEmptyCellDownworkflow, [WorkflowExpression] Func<int> mSExcelGotoNextEmptyCellDownhandle = null, [WorkflowExpression] Func<string> mSExcelGotoNextEmptyCellDownworkbookName = null, [WorkflowExpression] Func<string> mSExcelGotoNextEmptyCellDownworksheetName = null)
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
                    mSExcelGotoNextEmptyCellDown["Handle"] = ExpressionConverter.ConvertO(mSExcelGotoNextEmptyCellDownhandle);
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
        public IBodyWorkflowAction<MSExcelSaveWorkbookResponse> MSExcelSaveWorkbook([WorkflowExpression] Func<string> mSExcelSaveWorkbookworkflow, [WorkflowExpression] Func<int> mSExcelSaveWorkbookhandle = null, [WorkflowExpression] Func<string> mSExcelSaveWorkbookworkbookName = null)
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
                    mSExcelSaveWorkbook["Handle"] = ExpressionConverter.ConvertO(mSExcelSaveWorkbookhandle);
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
        public IBodyWorkflowAction<MSExcelSaveWorkbookAsResponse> MSExcelSaveWorkbookAs([WorkflowExpression] Func<string> mSExcelSaveWorkbookAssaveFilename, [WorkflowExpression] Func<string> mSExcelSaveWorkbookAsworkflow, [WorkflowExpression] Func<int> mSExcelSaveWorkbookAshandle = null, [WorkflowExpression] Func<string> mSExcelSaveWorkbookAsworkbookName = null, [WorkflowExpression] Func<bool> mSExcelSaveWorkbookAsdeleteExistingSaveFilename = null, [WorkflowExpression] Func<mSExcelSaveWorkbookAsexcelFileFormatInput> mSExcelSaveWorkbookAsexcelFileFormat = null)
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
                    mSExcelSaveWorkbookAs["Handle"] = ExpressionConverter.ConvertO(mSExcelSaveWorkbookAshandle);
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
                mSExcelSaveWorkbookAs["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelSaveWorkbookAsworkbookName);
                mSExcelSaveWorkbookAspropCount++;
            }

            mSExcelSaveWorkbookAspropCount++;
            mSExcelSaveWorkbookAs["SaveFilename"] = ExpressionConverter.ConvertO(mSExcelSaveWorkbookAssaveFilename);
            if (mSExcelSaveWorkbookAsdeleteExistingSaveFilename != null)
            {
                if (mSExcelSaveWorkbookAsdeleteExistingSaveFilename != null)
                {
                    mSExcelSaveWorkbookAs["DeleteExistingSaveFilename"] = ExpressionConverter.ConvertO(mSExcelSaveWorkbookAsdeleteExistingSaveFilename);
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
                    mSExcelSaveWorkbookAs["ExcelFileFormat"] = ExpressionConverter.ConvertO(mSExcelSaveWorkbookAsexcelFileFormat);
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
            mSExcelSaveWorkbookAs["Workflow"] = ExpressionConverter.ConvertO(mSExcelSaveWorkbookAsworkflow);
            if (mSExcelSaveWorkbookAspropCount > 0)
            {
                callPayload.Body = mSExcelSaveWorkbookAs;
            }

            return new ApiConnectionAction<MSExcelSaveWorkbookAsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelSaveWorkbookAsCSVResponse> MSExcelSaveWorkbookAsCSV([WorkflowExpression] Func<string> mSExcelSaveWorkbookAsCSVsaveFilename, [WorkflowExpression] Func<string> mSExcelSaveWorkbookAsCSVworkflow, [WorkflowExpression] Func<int> mSExcelSaveWorkbookAsCSVhandle = null, [WorkflowExpression] Func<string> mSExcelSaveWorkbookAsCSVworkbookName = null, [WorkflowExpression] Func<bool> mSExcelSaveWorkbookAsCSVdeleteExistingSaveFilename = null)
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
                    mSExcelSaveWorkbookAsCSV["Handle"] = ExpressionConverter.ConvertO(mSExcelSaveWorkbookAsCSVhandle);
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
                mSExcelSaveWorkbookAsCSV["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelSaveWorkbookAsCSVworkbookName);
                mSExcelSaveWorkbookAsCSVpropCount++;
            }

            mSExcelSaveWorkbookAsCSVpropCount++;
            mSExcelSaveWorkbookAsCSV["SaveFilename"] = ExpressionConverter.ConvertO(mSExcelSaveWorkbookAsCSVsaveFilename);
            if (mSExcelSaveWorkbookAsCSVdeleteExistingSaveFilename != null)
            {
                if (mSExcelSaveWorkbookAsCSVdeleteExistingSaveFilename != null)
                {
                    mSExcelSaveWorkbookAsCSV["DeleteExistingSaveFilename"] = ExpressionConverter.ConvertO(mSExcelSaveWorkbookAsCSVdeleteExistingSaveFilename);
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
            mSExcelSaveWorkbookAsCSV["Workflow"] = ExpressionConverter.ConvertO(mSExcelSaveWorkbookAsCSVworkflow);
            if (mSExcelSaveWorkbookAsCSVpropCount > 0)
            {
                callPayload.Body = mSExcelSaveWorkbookAsCSV;
            }

            return new ApiConnectionAction<MSExcelSaveWorkbookAsCSVResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelSaveWorkbookAsWithPasswordResponse> MSExcelSaveWorkbookAsWithPassword([WorkflowExpression] Func<string> mSExcelSaveWorkbookAsWithPasswordsaveFilename, [WorkflowExpression] Func<string> mSExcelSaveWorkbookAsWithPasswordpassword, [WorkflowExpression] Func<string> mSExcelSaveWorkbookAsWithPasswordworkflow, [WorkflowExpression] Func<int> mSExcelSaveWorkbookAsWithPasswordhandle = null, [WorkflowExpression] Func<string> mSExcelSaveWorkbookAsWithPasswordworkbookName = null, [WorkflowExpression] Func<bool> mSExcelSaveWorkbookAsWithPassworddeleteExistingSaveFilename = null, [WorkflowExpression] Func<mSExcelSaveWorkbookAsWithPasswordexcelFileFormatInput> mSExcelSaveWorkbookAsWithPasswordexcelFileFormat = null)
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
                    mSExcelSaveWorkbookAsWithPassword["Handle"] = ExpressionConverter.ConvertO(mSExcelSaveWorkbookAsWithPasswordhandle);
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
                mSExcelSaveWorkbookAsWithPassword["WorkbookName"] = ExpressionConverter.ConvertO(mSExcelSaveWorkbookAsWithPasswordworkbookName);
                mSExcelSaveWorkbookAsWithPasswordpropCount++;
            }

            mSExcelSaveWorkbookAsWithPasswordpropCount++;
            mSExcelSaveWorkbookAsWithPassword["SaveFilename"] = ExpressionConverter.ConvertO(mSExcelSaveWorkbookAsWithPasswordsaveFilename);
            mSExcelSaveWorkbookAsWithPasswordpropCount++;
            mSExcelSaveWorkbookAsWithPassword["Password"] = ExpressionConverter.ConvertO(mSExcelSaveWorkbookAsWithPasswordpassword);
            if (mSExcelSaveWorkbookAsWithPassworddeleteExistingSaveFilename != null)
            {
                if (mSExcelSaveWorkbookAsWithPassworddeleteExistingSaveFilename != null)
                {
                    mSExcelSaveWorkbookAsWithPassword["DeleteExistingSaveFilename"] = ExpressionConverter.ConvertO(mSExcelSaveWorkbookAsWithPassworddeleteExistingSaveFilename);
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
                    mSExcelSaveWorkbookAsWithPassword["ExcelFileFormat"] = ExpressionConverter.ConvertO(mSExcelSaveWorkbookAsWithPasswordexcelFileFormat);
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
            mSExcelSaveWorkbookAsWithPassword["Workflow"] = ExpressionConverter.ConvertO(mSExcelSaveWorkbookAsWithPasswordworkflow);
            if (mSExcelSaveWorkbookAsWithPasswordpropCount > 0)
            {
                callPayload.Body = mSExcelSaveWorkbookAsWithPassword;
            }

            return new ApiConnectionAction<MSExcelSaveWorkbookAsWithPasswordResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelSaveCurrentWorkbookResponse> MSExcelSaveCurrentWorkbook([WorkflowExpression] Func<string> mSExcelSaveCurrentWorkbookworkflow, [WorkflowExpression] Func<int> mSExcelSaveCurrentWorkbookhandle = null)
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
                    mSExcelSaveCurrentWorkbook["Handle"] = ExpressionConverter.ConvertO(mSExcelSaveCurrentWorkbookhandle);
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
            mSExcelSaveCurrentWorkbook["Workflow"] = ExpressionConverter.ConvertO(mSExcelSaveCurrentWorkbookworkflow);
            if (mSExcelSaveCurrentWorkbookpropCount > 0)
            {
                callPayload.Body = mSExcelSaveCurrentWorkbook;
            }

            return new ApiConnectionAction<MSExcelSaveCurrentWorkbookResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelSaveCurrentWorkbookAsResponse> MSExcelSaveCurrentWorkbookAs([WorkflowExpression] Func<string> mSExcelSaveCurrentWorkbookAsworkflow, [WorkflowExpression] Func<int> mSExcelSaveCurrentWorkbookAshandle = null, [WorkflowExpression] Func<string> mSExcelSaveCurrentWorkbookAssaveFilename = null, [WorkflowExpression] Func<bool> mSExcelSaveCurrentWorkbookAsdeleteExistingSaveFilename = null, [WorkflowExpression] Func<mSExcelSaveCurrentWorkbookAsexcelFileFormatInput> mSExcelSaveCurrentWorkbookAsexcelFileFormat = null)
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
                    mSExcelSaveCurrentWorkbookAs["Handle"] = ExpressionConverter.ConvertO(mSExcelSaveCurrentWorkbookAshandle);
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
                mSExcelSaveCurrentWorkbookAs["SaveFilename"] = ExpressionConverter.ConvertO(mSExcelSaveCurrentWorkbookAssaveFilename);
                mSExcelSaveCurrentWorkbookAspropCount++;
            }

            if (mSExcelSaveCurrentWorkbookAsdeleteExistingSaveFilename != null)
            {
                if (mSExcelSaveCurrentWorkbookAsdeleteExistingSaveFilename != null)
                {
                    mSExcelSaveCurrentWorkbookAs["DeleteExistingSaveFilename"] = ExpressionConverter.ConvertO(mSExcelSaveCurrentWorkbookAsdeleteExistingSaveFilename);
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
                    mSExcelSaveCurrentWorkbookAs["ExcelFileFormat"] = ExpressionConverter.ConvertO(mSExcelSaveCurrentWorkbookAsexcelFileFormat);
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
            mSExcelSaveCurrentWorkbookAs["Workflow"] = ExpressionConverter.ConvertO(mSExcelSaveCurrentWorkbookAsworkflow);
            if (mSExcelSaveCurrentWorkbookAspropCount > 0)
            {
                callPayload.Body = mSExcelSaveCurrentWorkbookAs;
            }

            return new ApiConnectionAction<MSExcelSaveCurrentWorkbookAsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelSaveCurrentWorkbookAsCSVResponse> MSExcelSaveCurrentWorkbookAsCSV([WorkflowExpression] Func<string> mSExcelSaveCurrentWorkbookAsCSVsaveFilename, [WorkflowExpression] Func<string> mSExcelSaveCurrentWorkbookAsCSVworkflow, [WorkflowExpression] Func<int> mSExcelSaveCurrentWorkbookAsCSVhandle = null, [WorkflowExpression] Func<bool> mSExcelSaveCurrentWorkbookAsCSVdeleteExistingSaveFilename = null)
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
                    mSExcelSaveCurrentWorkbookAsCSV["Handle"] = ExpressionConverter.ConvertO(mSExcelSaveCurrentWorkbookAsCSVhandle);
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
            mSExcelSaveCurrentWorkbookAsCSV["SaveFilename"] = ExpressionConverter.ConvertO(mSExcelSaveCurrentWorkbookAsCSVsaveFilename);
            if (mSExcelSaveCurrentWorkbookAsCSVdeleteExistingSaveFilename != null)
            {
                if (mSExcelSaveCurrentWorkbookAsCSVdeleteExistingSaveFilename != null)
                {
                    mSExcelSaveCurrentWorkbookAsCSV["DeleteExistingSaveFilename"] = ExpressionConverter.ConvertO(mSExcelSaveCurrentWorkbookAsCSVdeleteExistingSaveFilename);
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
            mSExcelSaveCurrentWorkbookAsCSV["Workflow"] = ExpressionConverter.ConvertO(mSExcelSaveCurrentWorkbookAsCSVworkflow);
            if (mSExcelSaveCurrentWorkbookAsCSVpropCount > 0)
            {
                callPayload.Body = mSExcelSaveCurrentWorkbookAsCSV;
            }

            return new ApiConnectionAction<MSExcelSaveCurrentWorkbookAsCSVResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetWorksheetNamesResponse> MSExcelGetWorksheetNames([WorkflowExpression] Func<string> mSExcelGetWorksheetNamesworkflow, [WorkflowExpression] Func<int> mSExcelGetWorksheetNameshandle = null, [WorkflowExpression] Func<string> mSExcelGetWorksheetNamesworkbookName = null)
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
                    mSExcelGetWorksheetNames["Handle"] = ExpressionConverter.ConvertO(mSExcelGetWorksheetNameshandle);
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
        public IBodyWorkflowAction<MSExcelGetWorksheetNameResponse> MSExcelGetWorksheetName([WorkflowExpression] Func<string> mSExcelGetWorksheetNameworkflow, [WorkflowExpression] Func<int> mSExcelGetWorksheetNamehandle = null, [WorkflowExpression] Func<string> mSExcelGetWorksheetNameworkbookName = null, [WorkflowExpression] Func<int> mSExcelGetWorksheetNameposition = null)
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
                    mSExcelGetWorksheetName["Handle"] = ExpressionConverter.ConvertO(mSExcelGetWorksheetNamehandle);
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
        public IWorkflowAction MSExcelActivateWorksheet([WorkflowExpression] Func<string> mSExcelActivateWorksheetworkflow, [WorkflowExpression] Func<int> mSExcelActivateWorksheethandle = null, [WorkflowExpression] Func<string> mSExcelActivateWorksheetworkbookName = null, [WorkflowExpression] Func<string> mSExcelActivateWorksheetworksheetName = null, [WorkflowExpression] Func<bool> mSExcelActivateWorksheetcreateIfMissing = null)
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
                    mSExcelActivateWorksheet["Handle"] = ExpressionConverter.ConvertO(mSExcelActivateWorksheethandle);
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
                if (mSExcelActivateWorksheetcreateIfMissing != null)
                {
                    mSExcelActivateWorksheet["CreateIfMissing"] = ExpressionConverter.ConvertO(mSExcelActivateWorksheetcreateIfMissing);
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
            mSExcelActivateWorksheet["Workflow"] = ExpressionConverter.ConvertO(mSExcelActivateWorksheetworkflow);
            if (mSExcelActivateWorksheetpropCount > 0)
            {
                callPayload.Body = mSExcelActivateWorksheet;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelCreateWorksheet([WorkflowExpression] Func<string> mSExcelCreateWorksheetworkflow, [WorkflowExpression] Func<int> mSExcelCreateWorksheethandle = null, [WorkflowExpression] Func<string> mSExcelCreateWorksheetworkbookName = null, [WorkflowExpression] Func<string> mSExcelCreateWorksheetworksheetName = null)
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
                    mSExcelCreateWorksheet["Handle"] = ExpressionConverter.ConvertO(mSExcelCreateWorksheethandle);
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
        public IWorkflowAction MSExcelDeleteWorksheet([WorkflowExpression] Func<string> mSExcelDeleteWorksheetworkflow, [WorkflowExpression] Func<int> mSExcelDeleteWorksheethandle = null, [WorkflowExpression] Func<string> mSExcelDeleteWorksheetworkbookName = null, [WorkflowExpression] Func<string> mSExcelDeleteWorksheetworksheetName = null)
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
                    mSExcelDeleteWorksheet["Handle"] = ExpressionConverter.ConvertO(mSExcelDeleteWorksheethandle);
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
        public IBodyWorkflowAction<MSExcelGetWorksheetAsCollectionEnhancedResponse> MSExcelGetWorksheetAsCollectionEnhanced([WorkflowExpression] Func<string> mSExcelGetWorksheetAsCollectionEnhancedworkflow, [WorkflowExpression] Func<int> mSExcelGetWorksheetAsCollectionEnhancedhandle = null, [WorkflowExpression] Func<string> mSExcelGetWorksheetAsCollectionEnhancedworkbookName = null, [WorkflowExpression] Func<string> mSExcelGetWorksheetAsCollectionEnhancedworksheetName = null, [WorkflowExpression] Func<bool> mSExcelGetWorksheetAsCollectionEnhanceduseHeader = null, [WorkflowExpression] Func<string> mSExcelGetWorksheetAsCollectionEnhancedstartCell = null, [WorkflowExpression] Func<int> mSExcelGetWorksheetAsCollectionEnhancedmaximumColumnNumber = null, [WorkflowExpression] Func<bool> mSExcelGetWorksheetAsCollectionEnhancedskipBlankRows = null, [WorkflowExpression] Func<bool> mSExcelGetWorksheetAsCollectionEnhancedskipColumnsWithNoHeader = null, [WorkflowExpression] Func<string> mSExcelGetWorksheetAsCollectionEnhancedkeyColumn = null, [WorkflowExpression] Func<bool> mSExcelGetWorksheetAsCollectionEnhancedgetRawData = null, [WorkflowExpression] Func<int> mSExcelGetWorksheetAsCollectionEnhancedignoreRowsWithLowCellCount = null, [WorkflowExpression] Func<int> mSExcelGetWorksheetAsCollectionEnhancedmaxConcurrentBlankRows = null, [WorkflowExpression] Func<int> mSExcelGetWorksheetAsCollectionEnhancedfirstDataRowToReturn = null, [WorkflowExpression] Func<int> mSExcelGetWorksheetAsCollectionEnhancedmaxNumberOfDataRowsToReturn = null)
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
                    mSExcelGetWorksheetAsCollectionEnhanced["Handle"] = ExpressionConverter.ConvertO(mSExcelGetWorksheetAsCollectionEnhancedhandle);
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
                if (mSExcelGetWorksheetAsCollectionEnhanceduseHeader != null)
                {
                    mSExcelGetWorksheetAsCollectionEnhanced["UseHeader"] = ExpressionConverter.ConvertO(mSExcelGetWorksheetAsCollectionEnhanceduseHeader);
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
                mSExcelGetWorksheetAsCollectionEnhanced["StartCell"] = ExpressionConverter.ConvertO(mSExcelGetWorksheetAsCollectionEnhancedstartCell);
                mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
            }

            if (mSExcelGetWorksheetAsCollectionEnhancedmaximumColumnNumber != null)
            {
                if (mSExcelGetWorksheetAsCollectionEnhancedmaximumColumnNumber != null)
                {
                    mSExcelGetWorksheetAsCollectionEnhanced["MaximumColumnNumber"] = ExpressionConverter.ConvertO(mSExcelGetWorksheetAsCollectionEnhancedmaximumColumnNumber);
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
                    mSExcelGetWorksheetAsCollectionEnhanced["SkipBlankRows"] = ExpressionConverter.ConvertO(mSExcelGetWorksheetAsCollectionEnhancedskipBlankRows);
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
                    mSExcelGetWorksheetAsCollectionEnhanced["SkipColumnsWithNoHeader"] = ExpressionConverter.ConvertO(mSExcelGetWorksheetAsCollectionEnhancedskipColumnsWithNoHeader);
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
                mSExcelGetWorksheetAsCollectionEnhanced["KeyColumn"] = ExpressionConverter.ConvertO(mSExcelGetWorksheetAsCollectionEnhancedkeyColumn);
                mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
            }

            if (mSExcelGetWorksheetAsCollectionEnhancedgetRawData != null)
            {
                if (mSExcelGetWorksheetAsCollectionEnhancedgetRawData != null)
                {
                    mSExcelGetWorksheetAsCollectionEnhanced["GetRawData"] = ExpressionConverter.ConvertO(mSExcelGetWorksheetAsCollectionEnhancedgetRawData);
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
                    mSExcelGetWorksheetAsCollectionEnhanced["IgnoreRowsWithLowCellCount"] = ExpressionConverter.ConvertO(mSExcelGetWorksheetAsCollectionEnhancedignoreRowsWithLowCellCount);
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
                    mSExcelGetWorksheetAsCollectionEnhanced["MaxConcurrentBlankRows"] = ExpressionConverter.ConvertO(mSExcelGetWorksheetAsCollectionEnhancedmaxConcurrentBlankRows);
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
                    mSExcelGetWorksheetAsCollectionEnhanced["FirstDataRowToReturn"] = ExpressionConverter.ConvertO(mSExcelGetWorksheetAsCollectionEnhancedfirstDataRowToReturn);
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
                    mSExcelGetWorksheetAsCollectionEnhanced["MaxNumberOfDataRowsToReturn"] = ExpressionConverter.ConvertO(mSExcelGetWorksheetAsCollectionEnhancedmaxNumberOfDataRowsToReturn);
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
            mSExcelGetWorksheetAsCollectionEnhanced["Workflow"] = ExpressionConverter.ConvertO(mSExcelGetWorksheetAsCollectionEnhancedworkflow);
            if (mSExcelGetWorksheetAsCollectionEnhancedpropCount > 0)
            {
                callPayload.Body = mSExcelGetWorksheetAsCollectionEnhanced;
            }

            return new ApiConnectionAction<MSExcelGetWorksheetAsCollectionEnhancedResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetNumberOfRowsResponse> MSExcelGetNumberOfRows([WorkflowExpression] Func<string> mSExcelGetNumberOfRowsworkflow, [WorkflowExpression] Func<int> mSExcelGetNumberOfRowshandle = null, [WorkflowExpression] Func<string> mSExcelGetNumberOfRowsworkbookName = null, [WorkflowExpression] Func<string> mSExcelGetNumberOfRowsworksheetName = null)
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
                    mSExcelGetNumberOfRows["Handle"] = ExpressionConverter.ConvertO(mSExcelGetNumberOfRowshandle);
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
        public IBodyWorkflowAction<MSExcelEvaluateExpressionResponse> MSExcelEvaluateExpression([WorkflowExpression] Func<string> mSExcelEvaluateExpressionexpression, [WorkflowExpression] Func<string> mSExcelEvaluateExpressionworkflow, [WorkflowExpression] Func<int> mSExcelEvaluateExpressionhandle = null)
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
                    mSExcelEvaluateExpression["Handle"] = ExpressionConverter.ConvertO(mSExcelEvaluateExpressionhandle);
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
        public IBodyWorkflowAction<MSExcelGetWorksheetUsedRangeResponse> MSExcelGetWorksheetUsedRange([WorkflowExpression] Func<string> mSExcelGetWorksheetUsedRangeworkflow, [WorkflowExpression] Func<int> mSExcelGetWorksheetUsedRangehandle = null, [WorkflowExpression] Func<string> mSExcelGetWorksheetUsedRangeworkbookName = null, [WorkflowExpression] Func<string> mSExcelGetWorksheetUsedRangeworksheetName = null)
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
                    mSExcelGetWorksheetUsedRange["Handle"] = ExpressionConverter.ConvertO(mSExcelGetWorksheetUsedRangehandle);
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
        public IBodyWorkflowAction<MSExcelGetCountrySettingResponse> MSExcelGetCountrySetting([WorkflowExpression] Func<string> mSExcelGetCountrySettingworkflow, [WorkflowExpression] Func<int> mSExcelGetCountrySettinghandle = null)
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
                    mSExcelGetCountrySetting["Handle"] = ExpressionConverter.ConvertO(mSExcelGetCountrySettinghandle);
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
            mSExcelGetCountrySetting["Workflow"] = ExpressionConverter.ConvertO(mSExcelGetCountrySettingworkflow);
            if (mSExcelGetCountrySettingpropCount > 0)
            {
                callPayload.Body = mSExcelGetCountrySetting;
            }

            return new ApiConnectionAction<MSExcelGetCountrySettingResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelWriteCollection([WorkflowExpression] Func<string> mSExcelWriteCollectioncellReference, [WorkflowExpression] Func<string> mSExcelWriteCollectioncollectionToWriteJSON, [WorkflowExpression] Func<string> mSExcelWriteCollectionworkflow, [WorkflowExpression] Func<int> mSExcelWriteCollectionhandle = null, [WorkflowExpression] Func<string> mSExcelWriteCollectionworkbookName = null, [WorkflowExpression] Func<string> mSExcelWriteCollectionworksheetName = null, [WorkflowExpression] Func<bool> mSExcelWriteCollectionincludeColumnNames = null)
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
                    mSExcelWriteCollection["Handle"] = ExpressionConverter.ConvertO(mSExcelWriteCollectionhandle);
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
                if (mSExcelWriteCollectionincludeColumnNames != null)
                {
                    mSExcelWriteCollection["IncludeColumnNames"] = ExpressionConverter.ConvertO(mSExcelWriteCollectionincludeColumnNames);
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
            mSExcelWriteCollection["Workflow"] = ExpressionConverter.ConvertO(mSExcelWriteCollectionworkflow);
            if (mSExcelWriteCollectionpropCount > 0)
            {
                callPayload.Body = mSExcelWriteCollection;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelWriteCollectionWithDates([WorkflowExpression] Func<string> mSExcelWriteCollectionWithDatescellReference, [WorkflowExpression] Func<string> mSExcelWriteCollectionWithDatescollectionToWriteJSON, [WorkflowExpression] Func<string> mSExcelWriteCollectionWithDatesworkflow, [WorkflowExpression] Func<int> mSExcelWriteCollectionWithDateshandle = null, [WorkflowExpression] Func<string> mSExcelWriteCollectionWithDatesworkbookName = null, [WorkflowExpression] Func<string> mSExcelWriteCollectionWithDatesworksheetName = null, [WorkflowExpression] Func<bool> mSExcelWriteCollectionWithDatesincludeColumnNames = null, [WorkflowExpression] Func<bool> mSExcelWriteCollectionWithDatestryToConvertAllFieldsToDate = null, [WorkflowExpression] Func<string> mSExcelWriteCollectionWithDatescolumnsToConvertToDateJSON = null)
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
                    mSExcelWriteCollectionWithDates["Handle"] = ExpressionConverter.ConvertO(mSExcelWriteCollectionWithDateshandle);
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
                if (mSExcelWriteCollectionWithDatesincludeColumnNames != null)
                {
                    mSExcelWriteCollectionWithDates["IncludeColumnNames"] = ExpressionConverter.ConvertO(mSExcelWriteCollectionWithDatesincludeColumnNames);
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
                    mSExcelWriteCollectionWithDates["TryToConvertAllFieldsToDate"] = ExpressionConverter.ConvertO(mSExcelWriteCollectionWithDatestryToConvertAllFieldsToDate);
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
        public IBodyWorkflowAction<MSExcelGetActiveCellResponse> MSExcelGetActiveCell([WorkflowExpression] Func<string> mSExcelGetActiveCellworkflow, [WorkflowExpression] Func<int> mSExcelGetActiveCellhandle = null)
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
                    mSExcelGetActiveCell["Handle"] = ExpressionConverter.ConvertO(mSExcelGetActiveCellhandle);
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
            mSExcelGetActiveCell["Workflow"] = ExpressionConverter.ConvertO(mSExcelGetActiveCellworkflow);
            if (mSExcelGetActiveCellpropCount > 0)
            {
                callPayload.Body = mSExcelGetActiveCell;
            }

            return new ApiConnectionAction<MSExcelGetActiveCellResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelFormatCell([WorkflowExpression] Func<string> mSExcelFormatCellcellReference, [WorkflowExpression] Func<string> mSExcelFormatCellcellFormat, [WorkflowExpression] Func<string> mSExcelFormatCellworkflow, [WorkflowExpression] Func<int> mSExcelFormatCellhandle = null, [WorkflowExpression] Func<string> mSExcelFormatCellworkbookName = null, [WorkflowExpression] Func<string> mSExcelFormatCellworksheetName = null)
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
                    mSExcelFormatCell["Handle"] = ExpressionConverter.ConvertO(mSExcelFormatCellhandle);
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
        public IWorkflowAction MSExcelFormatCurrentCell([WorkflowExpression] Func<string> mSExcelFormatCurrentCellcellFormat, [WorkflowExpression] Func<string> mSExcelFormatCurrentCellworkflow, [WorkflowExpression] Func<int> mSExcelFormatCurrentCellhandle = null)
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
                    mSExcelFormatCurrentCell["Handle"] = ExpressionConverter.ConvertO(mSExcelFormatCurrentCellhandle);
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
        public IWorkflowAction MSExcelSelectCellRange([WorkflowExpression] Func<string> mSExcelSelectCellRangecellReference, [WorkflowExpression] Func<string> mSExcelSelectCellRangeworkflow, [WorkflowExpression] Func<int> mSExcelSelectCellRangehandle = null, [WorkflowExpression] Func<string> mSExcelSelectCellRangeworkbookName = null, [WorkflowExpression] Func<string> mSExcelSelectCellRangeworksheetName = null, [WorkflowExpression] Func<bool> mSExcelSelectCellRangeentireRow = null, [WorkflowExpression] Func<bool> mSExcelSelectCellRangeentireColumn = null)
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
                    mSExcelSelectCellRange["Handle"] = ExpressionConverter.ConvertO(mSExcelSelectCellRangehandle);
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
                if (mSExcelSelectCellRangeentireRow != null)
                {
                    mSExcelSelectCellRange["EntireRow"] = ExpressionConverter.ConvertO(mSExcelSelectCellRangeentireRow);
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
                    mSExcelSelectCellRange["EntireColumn"] = ExpressionConverter.ConvertO(mSExcelSelectCellRangeentireColumn);
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
            mSExcelSelectCellRange["Workflow"] = ExpressionConverter.ConvertO(mSExcelSelectCellRangeworkflow);
            if (mSExcelSelectCellRangepropCount > 0)
            {
                callPayload.Body = mSExcelSelectCellRange;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelCopySelection([WorkflowExpression] Func<string> mSExcelCopySelectionworkflow, [WorkflowExpression] Func<int> mSExcelCopySelectionhandle = null, [WorkflowExpression] Func<string> mSExcelCopySelectionworkbookName = null, [WorkflowExpression] Func<string> mSExcelCopySelectionworksheetName = null, [WorkflowExpression] Func<string> mSExcelCopySelectioncellReference = null, [WorkflowExpression] Func<bool> mSExcelCopySelectionentireRow = null, [WorkflowExpression] Func<bool> mSExcelCopySelectionentireColumn = null)
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
                    mSExcelCopySelection["Handle"] = ExpressionConverter.ConvertO(mSExcelCopySelectionhandle);
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
                if (mSExcelCopySelectionentireRow != null)
                {
                    mSExcelCopySelection["EntireRow"] = ExpressionConverter.ConvertO(mSExcelCopySelectionentireRow);
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
                    mSExcelCopySelection["EntireColumn"] = ExpressionConverter.ConvertO(mSExcelCopySelectionentireColumn);
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
            mSExcelCopySelection["Workflow"] = ExpressionConverter.ConvertO(mSExcelCopySelectionworkflow);
            if (mSExcelCopySelectionpropCount > 0)
            {
                callPayload.Body = mSExcelCopySelection;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelCutSelection([WorkflowExpression] Func<string> mSExcelCutSelectionworkflow, [WorkflowExpression] Func<int> mSExcelCutSelectionhandle = null, [WorkflowExpression] Func<string> mSExcelCutSelectionworkbookName = null, [WorkflowExpression] Func<string> mSExcelCutSelectionworksheetName = null, [WorkflowExpression] Func<string> mSExcelCutSelectioncellReference = null, [WorkflowExpression] Func<bool> mSExcelCutSelectionentireRow = null, [WorkflowExpression] Func<bool> mSExcelCutSelectionentireColumn = null)
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
                    mSExcelCutSelection["Handle"] = ExpressionConverter.ConvertO(mSExcelCutSelectionhandle);
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
                if (mSExcelCutSelectionentireRow != null)
                {
                    mSExcelCutSelection["EntireRow"] = ExpressionConverter.ConvertO(mSExcelCutSelectionentireRow);
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
                    mSExcelCutSelection["EntireColumn"] = ExpressionConverter.ConvertO(mSExcelCutSelectionentireColumn);
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
            mSExcelCutSelection["Workflow"] = ExpressionConverter.ConvertO(mSExcelCutSelectionworkflow);
            if (mSExcelCutSelectionpropCount > 0)
            {
                callPayload.Body = mSExcelCutSelection;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelPasteIntoSelection([WorkflowExpression] Func<string> mSExcelPasteIntoSelectionworkflow, [WorkflowExpression] Func<int> mSExcelPasteIntoSelectionhandle = null, [WorkflowExpression] Func<string> mSExcelPasteIntoSelectionworkbookName = null, [WorkflowExpression] Func<string> mSExcelPasteIntoSelectionworksheetName = null, [WorkflowExpression] Func<bool> mSExcelPasteIntoSelectionvaluesOnly = null, [WorkflowExpression] Func<bool> mSExcelPasteIntoSelectionsimplePasteOnly = null, [WorkflowExpression] Func<string> mSExcelPasteIntoSelectioncellReference = null, [WorkflowExpression] Func<bool> mSExcelPasteIntoSelectionentireRow = null, [WorkflowExpression] Func<bool> mSExcelPasteIntoSelectionentireColumn = null)
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
                    mSExcelPasteIntoSelection["Handle"] = ExpressionConverter.ConvertO(mSExcelPasteIntoSelectionhandle);
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
                if (mSExcelPasteIntoSelectionvaluesOnly != null)
                {
                    mSExcelPasteIntoSelection["ValuesOnly"] = ExpressionConverter.ConvertO(mSExcelPasteIntoSelectionvaluesOnly);
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
                    mSExcelPasteIntoSelection["SimplePasteOnly"] = ExpressionConverter.ConvertO(mSExcelPasteIntoSelectionsimplePasteOnly);
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
                mSExcelPasteIntoSelection["CellReference"] = ExpressionConverter.ConvertO(mSExcelPasteIntoSelectioncellReference);
                mSExcelPasteIntoSelectionpropCount++;
            }

            if (mSExcelPasteIntoSelectionentireRow != null)
            {
                if (mSExcelPasteIntoSelectionentireRow != null)
                {
                    mSExcelPasteIntoSelection["EntireRow"] = ExpressionConverter.ConvertO(mSExcelPasteIntoSelectionentireRow);
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
                    mSExcelPasteIntoSelection["EntireColumn"] = ExpressionConverter.ConvertO(mSExcelPasteIntoSelectionentireColumn);
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
            mSExcelPasteIntoSelection["Workflow"] = ExpressionConverter.ConvertO(mSExcelPasteIntoSelectionworkflow);
            if (mSExcelPasteIntoSelectionpropCount > 0)
            {
                callPayload.Body = mSExcelPasteIntoSelection;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelInsertOnSelection([WorkflowExpression] Func<string> mSExcelInsertOnSelectionworkflow, [WorkflowExpression] Func<int> mSExcelInsertOnSelectionhandle = null, [WorkflowExpression] Func<string> mSExcelInsertOnSelectionworkbookName = null, [WorkflowExpression] Func<string> mSExcelInsertOnSelectionworksheetName = null, [WorkflowExpression] Func<string> mSExcelInsertOnSelectioncellReference = null, [WorkflowExpression] Func<bool> mSExcelInsertOnSelectionentireRow = null, [WorkflowExpression] Func<bool> mSExcelInsertOnSelectionentireColumn = null, [WorkflowExpression] Func<mSExcelInsertOnSelectionshiftInput> mSExcelInsertOnSelectionshift = null)
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
                    mSExcelInsertOnSelection["Handle"] = ExpressionConverter.ConvertO(mSExcelInsertOnSelectionhandle);
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
                if (mSExcelInsertOnSelectionentireRow != null)
                {
                    mSExcelInsertOnSelection["EntireRow"] = ExpressionConverter.ConvertO(mSExcelInsertOnSelectionentireRow);
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
                    mSExcelInsertOnSelection["EntireColumn"] = ExpressionConverter.ConvertO(mSExcelInsertOnSelectionentireColumn);
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
        public IWorkflowAction MSExcelDeleteSelection([WorkflowExpression] Func<string> mSExcelDeleteSelectionworkflow, [WorkflowExpression] Func<int> mSExcelDeleteSelectionhandle = null, [WorkflowExpression] Func<string> mSExcelDeleteSelectionworkbookName = null, [WorkflowExpression] Func<string> mSExcelDeleteSelectionworksheetName = null, [WorkflowExpression] Func<string> mSExcelDeleteSelectioncellReference = null, [WorkflowExpression] Func<bool> mSExcelDeleteSelectionentireRow = null, [WorkflowExpression] Func<bool> mSExcelDeleteSelectionentireColumn = null, [WorkflowExpression] Func<mSExcelDeleteSelectionshiftInput> mSExcelDeleteSelectionshift = null)
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
                    mSExcelDeleteSelection["Handle"] = ExpressionConverter.ConvertO(mSExcelDeleteSelectionhandle);
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
                if (mSExcelDeleteSelectionentireRow != null)
                {
                    mSExcelDeleteSelection["EntireRow"] = ExpressionConverter.ConvertO(mSExcelDeleteSelectionentireRow);
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
                    mSExcelDeleteSelection["EntireColumn"] = ExpressionConverter.ConvertO(mSExcelDeleteSelectionentireColumn);
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
        public IWorkflowAction MSExcelClearExcelClipboard([WorkflowExpression] Func<string> mSExcelClearExcelClipboardworkflow, [WorkflowExpression] Func<int> mSExcelClearExcelClipboardhandle = null)
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
                    mSExcelClearExcelClipboard["Handle"] = ExpressionConverter.ConvertO(mSExcelClearExcelClipboardhandle);
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
            mSExcelClearExcelClipboard["Workflow"] = ExpressionConverter.ConvertO(mSExcelClearExcelClipboardworkflow);
            if (mSExcelClearExcelClipboardpropCount > 0)
            {
                callPayload.Body = mSExcelClearExcelClipboard;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelRunMacroResponse> MSExcelRunMacro([WorkflowExpression] Func<string> mSExcelRunMacromacroName, [WorkflowExpression] Func<string> mSExcelRunMacroworkflow, [WorkflowExpression] Func<int> mSExcelRunMacrohandle = null, [WorkflowExpression] Func<int> mSExcelRunMacronumberOfArguments = null, [WorkflowExpression] Func<string> mSExcelRunMacroargument1 = null, [WorkflowExpression] Func<string> mSExcelRunMacroargument2 = null, [WorkflowExpression] Func<string> mSExcelRunMacroargument3 = null, [WorkflowExpression] Func<string> mSExcelRunMacroargument4 = null, [WorkflowExpression] Func<string> mSExcelRunMacroargument5 = null, [WorkflowExpression] Func<string> mSExcelRunMacroargument6 = null, [WorkflowExpression] Func<string> mSExcelRunMacroargument7 = null, [WorkflowExpression] Func<string> mSExcelRunMacroargument8 = null, [WorkflowExpression] Func<string> mSExcelRunMacroargument9 = null, [WorkflowExpression] Func<string> mSExcelRunMacroargument10 = null, [WorkflowExpression] Func<bool> mSExcelRunMacrorunInBackground = null)
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
                    mSExcelRunMacro["Handle"] = ExpressionConverter.ConvertO(mSExcelRunMacrohandle);
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
                if (mSExcelRunMacrorunInBackground != null)
                {
                    mSExcelRunMacro["RunInBackground"] = ExpressionConverter.ConvertO(mSExcelRunMacrorunInBackground);
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
            mSExcelRunMacro["Workflow"] = ExpressionConverter.ConvertO(mSExcelRunMacroworkflow);
            if (mSExcelRunMacropropCount > 0)
            {
                callPayload.Body = mSExcelRunMacro;
            }

            return new ApiConnectionAction<MSExcelRunMacroResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelAddMacroToWorkbook([WorkflowExpression] Func<string> mSExcelAddMacroToWorkbookmacroCode, [WorkflowExpression] Func<string> mSExcelAddMacroToWorkbookworkflow, [WorkflowExpression] Func<int> mSExcelAddMacroToWorkbookhandle = null, [WorkflowExpression] Func<string> mSExcelAddMacroToWorkbookworkbookName = null)
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
                    mSExcelAddMacroToWorkbook["Handle"] = ExpressionConverter.ConvertO(mSExcelAddMacroToWorkbookhandle);
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
        public IWorkflowAction MSExcelTrustVBOMInRegistry([WorkflowExpression] Func<string> mSExcelTrustVBOMInRegistryworkflow, [WorkflowExpression] Func<int> mSExcelTrustVBOMInRegistryexcelVersion = null, [WorkflowExpression] Func<bool> mSExcelTrustVBOMInRegistrytrustVBOM = null)
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
                if (mSExcelTrustVBOMInRegistrytrustVBOM != null)
                {
                    mSExcelTrustVBOMInRegistry["TrustVBOM"] = ExpressionConverter.ConvertO(mSExcelTrustVBOMInRegistrytrustVBOM);
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
            mSExcelTrustVBOMInRegistry["Workflow"] = ExpressionConverter.ConvertO(mSExcelTrustVBOMInRegistryworkflow);
            if (mSExcelTrustVBOMInRegistrypropCount > 0)
            {
                callPayload.Body = mSExcelTrustVBOMInRegistry;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelSetCalculationMode([WorkflowExpression] Func<int> mSExcelSetCalculationModecalculationMode, [WorkflowExpression] Func<string> mSExcelSetCalculationModeworkflow, [WorkflowExpression] Func<int> mSExcelSetCalculationModehandle = null)
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
                    mSExcelSetCalculationMode["Handle"] = ExpressionConverter.ConvertO(mSExcelSetCalculationModehandle);
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
        public IWorkflowAction MSExcelExecuteCommandBarObject([WorkflowExpression] Func<string> mSExcelExecuteCommandBarObjectobjectId, [WorkflowExpression] Func<string> mSExcelExecuteCommandBarObjectworkflow, [WorkflowExpression] Func<int> mSExcelExecuteCommandBarObjecthandle = null, [WorkflowExpression] Func<bool> mSExcelExecuteCommandBarObjectrunInBackground = null)
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
                    mSExcelExecuteCommandBarObject["Handle"] = ExpressionConverter.ConvertO(mSExcelExecuteCommandBarObjecthandle);
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
            mSExcelExecuteCommandBarObject["ObjectId"] = ExpressionConverter.ConvertO(mSExcelExecuteCommandBarObjectobjectId);
            if (mSExcelExecuteCommandBarObjectrunInBackground != null)
            {
                if (mSExcelExecuteCommandBarObjectrunInBackground != null)
                {
                    mSExcelExecuteCommandBarObject["RunInBackground"] = ExpressionConverter.ConvertO(mSExcelExecuteCommandBarObjectrunInBackground);
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
            mSExcelExecuteCommandBarObject["Workflow"] = ExpressionConverter.ConvertO(mSExcelExecuteCommandBarObjectworkflow);
            if (mSExcelExecuteCommandBarObjectpropCount > 0)
            {
                callPayload.Body = mSExcelExecuteCommandBarObject;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelCopyBetweenCellsResponse> MSExcelCopyBetweenCells([WorkflowExpression] Func<string> mSExcelCopyBetweenCellssourceCellReference, [WorkflowExpression] Func<string> mSExcelCopyBetweenCellstargetCellReference, [WorkflowExpression] Func<string> mSExcelCopyBetweenCellsworkflow, [WorkflowExpression] Func<int> mSExcelCopyBetweenCellssourceHandle = null, [WorkflowExpression] Func<string> mSExcelCopyBetweenCellssourceWorkbookName = null, [WorkflowExpression] Func<string> mSExcelCopyBetweenCellssourceWorksheetName = null, [WorkflowExpression] Func<bool> mSExcelCopyBetweenCellssourceEntireRow = null, [WorkflowExpression] Func<bool> mSExcelCopyBetweenCellssourceEntireColumn = null, [WorkflowExpression] Func<int> mSExcelCopyBetweenCellstargetHandle = null, [WorkflowExpression] Func<string> mSExcelCopyBetweenCellstargetWorkbookName = null, [WorkflowExpression] Func<string> mSExcelCopyBetweenCellstargetWorksheetName = null, [WorkflowExpression] Func<bool> mSExcelCopyBetweenCellstargetEntireRow = null, [WorkflowExpression] Func<bool> mSExcelCopyBetweenCellstargetEntireColumn = null, [WorkflowExpression] Func<bool> mSExcelCopyBetweenCellsvaluesOnly = null, [WorkflowExpression] Func<bool> mSExcelCopyBetweenCellssimplePasteOnly = null)
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
                    mSExcelCopyBetweenCells["SourceHandle"] = ExpressionConverter.ConvertO(mSExcelCopyBetweenCellssourceHandle);
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
                if (mSExcelCopyBetweenCellssourceEntireRow != null)
                {
                    mSExcelCopyBetweenCells["SourceEntireRow"] = ExpressionConverter.ConvertO(mSExcelCopyBetweenCellssourceEntireRow);
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
                    mSExcelCopyBetweenCells["SourceEntireColumn"] = ExpressionConverter.ConvertO(mSExcelCopyBetweenCellssourceEntireColumn);
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
                    mSExcelCopyBetweenCells["TargetHandle"] = ExpressionConverter.ConvertO(mSExcelCopyBetweenCellstargetHandle);
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
                if (mSExcelCopyBetweenCellstargetEntireRow != null)
                {
                    mSExcelCopyBetweenCells["TargetEntireRow"] = ExpressionConverter.ConvertO(mSExcelCopyBetweenCellstargetEntireRow);
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
                    mSExcelCopyBetweenCells["TargetEntireColumn"] = ExpressionConverter.ConvertO(mSExcelCopyBetweenCellstargetEntireColumn);
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
                    mSExcelCopyBetweenCells["ValuesOnly"] = ExpressionConverter.ConvertO(mSExcelCopyBetweenCellsvaluesOnly);
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
                    mSExcelCopyBetweenCells["SimplePasteOnly"] = ExpressionConverter.ConvertO(mSExcelCopyBetweenCellssimplePasteOnly);
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
            mSExcelCopyBetweenCells["Workflow"] = ExpressionConverter.ConvertO(mSExcelCopyBetweenCellsworkflow);
            if (mSExcelCopyBetweenCellspropCount > 0)
            {
                callPayload.Body = mSExcelCopyBetweenCells;
            }

            return new ApiConnectionAction<MSExcelCopyBetweenCellsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelCutBetweenCellsResponse> MSExcelCutBetweenCells([WorkflowExpression] Func<string> mSExcelCutBetweenCellssourceCellReference, [WorkflowExpression] Func<string> mSExcelCutBetweenCellstargetCellReference, [WorkflowExpression] Func<string> mSExcelCutBetweenCellsworkflow, [WorkflowExpression] Func<int> mSExcelCutBetweenCellssourceHandle = null, [WorkflowExpression] Func<string> mSExcelCutBetweenCellssourceWorkbookName = null, [WorkflowExpression] Func<string> mSExcelCutBetweenCellssourceWorksheetName = null, [WorkflowExpression] Func<bool> mSExcelCutBetweenCellssourceEntireRow = null, [WorkflowExpression] Func<bool> mSExcelCutBetweenCellssourceEntireColumn = null, [WorkflowExpression] Func<int> mSExcelCutBetweenCellstargetHandle = null, [WorkflowExpression] Func<string> mSExcelCutBetweenCellstargetWorkbookName = null, [WorkflowExpression] Func<string> mSExcelCutBetweenCellstargetWorksheetName = null, [WorkflowExpression] Func<bool> mSExcelCutBetweenCellstargetEntireRow = null, [WorkflowExpression] Func<bool> mSExcelCutBetweenCellstargetEntireColumn = null, [WorkflowExpression] Func<bool> mSExcelCutBetweenCellsvaluesOnly = null)
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
                    mSExcelCutBetweenCells["SourceHandle"] = ExpressionConverter.ConvertO(mSExcelCutBetweenCellssourceHandle);
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
                if (mSExcelCutBetweenCellssourceEntireRow != null)
                {
                    mSExcelCutBetweenCells["SourceEntireRow"] = ExpressionConverter.ConvertO(mSExcelCutBetweenCellssourceEntireRow);
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
                    mSExcelCutBetweenCells["SourceEntireColumn"] = ExpressionConverter.ConvertO(mSExcelCutBetweenCellssourceEntireColumn);
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
                    mSExcelCutBetweenCells["TargetHandle"] = ExpressionConverter.ConvertO(mSExcelCutBetweenCellstargetHandle);
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
                if (mSExcelCutBetweenCellstargetEntireRow != null)
                {
                    mSExcelCutBetweenCells["TargetEntireRow"] = ExpressionConverter.ConvertO(mSExcelCutBetweenCellstargetEntireRow);
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
                    mSExcelCutBetweenCells["TargetEntireColumn"] = ExpressionConverter.ConvertO(mSExcelCutBetweenCellstargetEntireColumn);
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
                    mSExcelCutBetweenCells["ValuesOnly"] = ExpressionConverter.ConvertO(mSExcelCutBetweenCellsvaluesOnly);
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
            mSExcelCutBetweenCells["Workflow"] = ExpressionConverter.ConvertO(mSExcelCutBetweenCellsworkflow);
            if (mSExcelCutBetweenCellspropCount > 0)
            {
                callPayload.Body = mSExcelCutBetweenCells;
            }

            return new ApiConnectionAction<MSExcelCutBetweenCellsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelMinimiseWindowResponse> MSExcelMinimiseWindow([WorkflowExpression] Func<string> mSExcelMinimiseWindowworkflow, [WorkflowExpression] Func<int> mSExcelMinimiseWindowhandle = null)
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
                    mSExcelMinimiseWindow["Handle"] = ExpressionConverter.ConvertO(mSExcelMinimiseWindowhandle);
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
            mSExcelMinimiseWindow["Workflow"] = ExpressionConverter.ConvertO(mSExcelMinimiseWindowworkflow);
            if (mSExcelMinimiseWindowpropCount > 0)
            {
                callPayload.Body = mSExcelMinimiseWindow;
            }

            return new ApiConnectionAction<MSExcelMinimiseWindowResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelMaximiseWindowResponse> MSExcelMaximiseWindow([WorkflowExpression] Func<string> mSExcelMaximiseWindowworkflow, [WorkflowExpression] Func<int> mSExcelMaximiseWindowhandle = null)
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
                    mSExcelMaximiseWindow["Handle"] = ExpressionConverter.ConvertO(mSExcelMaximiseWindowhandle);
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
            mSExcelMaximiseWindow["Workflow"] = ExpressionConverter.ConvertO(mSExcelMaximiseWindowworkflow);
            if (mSExcelMaximiseWindowpropCount > 0)
            {
                callPayload.Body = mSExcelMaximiseWindow;
            }

            return new ApiConnectionAction<MSExcelMaximiseWindowResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelNormaliseWindowResponse> MSExcelNormaliseWindow([WorkflowExpression] Func<string> mSExcelNormaliseWindowworkflow, [WorkflowExpression] Func<int> mSExcelNormaliseWindowhandle = null)
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
                    mSExcelNormaliseWindow["Handle"] = ExpressionConverter.ConvertO(mSExcelNormaliseWindowhandle);
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
            mSExcelNormaliseWindow["Workflow"] = ExpressionConverter.ConvertO(mSExcelNormaliseWindowworkflow);
            if (mSExcelNormaliseWindowpropCount > 0)
            {
                callPayload.Body = mSExcelNormaliseWindow;
            }

            return new ApiConnectionAction<MSExcelNormaliseWindowResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetAndSetCellValueResponse> MSExcelGetAndSetCellValue([WorkflowExpression] Func<string> mSExcelGetAndSetCellValuesourceCellReference, [WorkflowExpression] Func<string> mSExcelGetAndSetCellValuetargetCellReference, [WorkflowExpression] Func<string> mSExcelGetAndSetCellValueworkflow, [WorkflowExpression] Func<int> mSExcelGetAndSetCellValuesourceHandle = null, [WorkflowExpression] Func<string> mSExcelGetAndSetCellValuesourceWorkbookName = null, [WorkflowExpression] Func<string> mSExcelGetAndSetCellValuesourceWorksheetName = null, [WorkflowExpression] Func<int> mSExcelGetAndSetCellValuetargetHandle = null, [WorkflowExpression] Func<string> mSExcelGetAndSetCellValuetargetWorkbookName = null, [WorkflowExpression] Func<string> mSExcelGetAndSetCellValuetargetWorksheetName = null)
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
                    mSExcelGetAndSetCellValue["SourceHandle"] = ExpressionConverter.ConvertO(mSExcelGetAndSetCellValuesourceHandle);
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
                if (mSExcelGetAndSetCellValuetargetHandle != null)
                {
                    mSExcelGetAndSetCellValue["TargetHandle"] = ExpressionConverter.ConvertO(mSExcelGetAndSetCellValuetargetHandle);
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
        public IBodyWorkflowAction<MSExcelGetAndSetCellValue2Response> MSExcelGetAndSetCellValue2([WorkflowExpression] Func<string> mSExcelGetAndSetCellValue2sourceCellReference, [WorkflowExpression] Func<string> mSExcelGetAndSetCellValue2targetCellReference, [WorkflowExpression] Func<string> mSExcelGetAndSetCellValue2workflow, [WorkflowExpression] Func<int> mSExcelGetAndSetCellValue2sourceHandle = null, [WorkflowExpression] Func<string> mSExcelGetAndSetCellValue2sourceWorkbookName = null, [WorkflowExpression] Func<string> mSExcelGetAndSetCellValue2sourceWorksheetName = null, [WorkflowExpression] Func<int> mSExcelGetAndSetCellValue2targetHandle = null, [WorkflowExpression] Func<string> mSExcelGetAndSetCellValue2targetWorkbookName = null, [WorkflowExpression] Func<string> mSExcelGetAndSetCellValue2targetWorksheetName = null)
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
                    mSExcelGetAndSetCellValue2["SourceHandle"] = ExpressionConverter.ConvertO(mSExcelGetAndSetCellValue2sourceHandle);
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
                if (mSExcelGetAndSetCellValue2targetHandle != null)
                {
                    mSExcelGetAndSetCellValue2["TargetHandle"] = ExpressionConverter.ConvertO(mSExcelGetAndSetCellValue2targetHandle);
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
        public IBodyWorkflowAction<MSExcelGetAndSetCellTextResponse> MSExcelGetAndSetCellText([WorkflowExpression] Func<string> mSExcelGetAndSetCellTextsourceCellReference, [WorkflowExpression] Func<string> mSExcelGetAndSetCellTexttargetCellReference, [WorkflowExpression] Func<string> mSExcelGetAndSetCellTextworkflow, [WorkflowExpression] Func<int> mSExcelGetAndSetCellTextsourceHandle = null, [WorkflowExpression] Func<string> mSExcelGetAndSetCellTextsourceWorkbookName = null, [WorkflowExpression] Func<string> mSExcelGetAndSetCellTextsourceWorksheetName = null, [WorkflowExpression] Func<int> mSExcelGetAndSetCellTexttargetHandle = null, [WorkflowExpression] Func<string> mSExcelGetAndSetCellTexttargetWorkbookName = null, [WorkflowExpression] Func<string> mSExcelGetAndSetCellTexttargetWorksheetName = null)
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
                    mSExcelGetAndSetCellText["SourceHandle"] = ExpressionConverter.ConvertO(mSExcelGetAndSetCellTextsourceHandle);
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
                if (mSExcelGetAndSetCellTexttargetHandle != null)
                {
                    mSExcelGetAndSetCellText["TargetHandle"] = ExpressionConverter.ConvertO(mSExcelGetAndSetCellTexttargetHandle);
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
        public IBodyWorkflowAction<MSExcelCheckOLEObjectResponse> MSExcelCheckOLEObject([WorkflowExpression] Func<string> mSExcelCheckOLEObjectoLEObjectName, [WorkflowExpression] Func<string> mSExcelCheckOLEObjectworkflow, [WorkflowExpression] Func<int> mSExcelCheckOLEObjecthandle = null, [WorkflowExpression] Func<string> mSExcelCheckOLEObjectworkbookName = null, [WorkflowExpression] Func<string> mSExcelCheckOLEObjectworksheetName = null, [WorkflowExpression] Func<bool> mSExcelCheckOLEObjectchecked = null, [WorkflowExpression] Func<bool> mSExcelCheckOLEObjectrunInBackground = null)
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
                    mSExcelCheckOLEObject["Handle"] = ExpressionConverter.ConvertO(mSExcelCheckOLEObjecthandle);
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
                if (mSExcelCheckOLEObjectchecked != null)
                {
                    mSExcelCheckOLEObject["Checked"] = ExpressionConverter.ConvertO(mSExcelCheckOLEObjectchecked);
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
                    mSExcelCheckOLEObject["RunInBackground"] = ExpressionConverter.ConvertO(mSExcelCheckOLEObjectrunInBackground);
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
            mSExcelCheckOLEObject["Workflow"] = ExpressionConverter.ConvertO(mSExcelCheckOLEObjectworkflow);
            if (mSExcelCheckOLEObjectpropCount > 0)
            {
                callPayload.Body = mSExcelCheckOLEObject;
            }

            return new ApiConnectionAction<MSExcelCheckOLEObjectResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelInputTextIntoOLEObjectResponse> MSExcelInputTextIntoOLEObject([WorkflowExpression] Func<string> mSExcelInputTextIntoOLEObjectoLEObjectName, [WorkflowExpression] Func<string> mSExcelInputTextIntoOLEObjectworkflow, [WorkflowExpression] Func<int> mSExcelInputTextIntoOLEObjecthandle = null, [WorkflowExpression] Func<string> mSExcelInputTextIntoOLEObjectworkbookName = null, [WorkflowExpression] Func<string> mSExcelInputTextIntoOLEObjectworksheetName = null, [WorkflowExpression] Func<string> mSExcelInputTextIntoOLEObjecttextToInput = null, [WorkflowExpression] Func<bool> mSExcelInputTextIntoOLEObjectrunInBackground = null)
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
                    mSExcelInputTextIntoOLEObject["Handle"] = ExpressionConverter.ConvertO(mSExcelInputTextIntoOLEObjecthandle);
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
                if (mSExcelInputTextIntoOLEObjectrunInBackground != null)
                {
                    mSExcelInputTextIntoOLEObject["RunInBackground"] = ExpressionConverter.ConvertO(mSExcelInputTextIntoOLEObjectrunInBackground);
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
            mSExcelInputTextIntoOLEObject["Workflow"] = ExpressionConverter.ConvertO(mSExcelInputTextIntoOLEObjectworkflow);
            if (mSExcelInputTextIntoOLEObjectpropCount > 0)
            {
                callPayload.Body = mSExcelInputTextIntoOLEObject;
            }

            return new ApiConnectionAction<MSExcelInputTextIntoOLEObjectResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelSetCellBackgroundColourResponse> MSExcelSetCellBackgroundColour([WorkflowExpression] Func<string> mSExcelSetCellBackgroundColourcellReference, [WorkflowExpression] Func<int> mSExcelSetCellBackgroundColourcolourIndex, [WorkflowExpression] Func<string> mSExcelSetCellBackgroundColourworkflow, [WorkflowExpression] Func<int> mSExcelSetCellBackgroundColourhandle = null, [WorkflowExpression] Func<string> mSExcelSetCellBackgroundColourworkbookName = null, [WorkflowExpression] Func<string> mSExcelSetCellBackgroundColourworksheetName = null)
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
                    mSExcelSetCellBackgroundColour["Handle"] = ExpressionConverter.ConvertO(mSExcelSetCellBackgroundColourhandle);
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
        public IBodyWorkflowAction<MSExcelGetCellBackgroundColourResponse> MSExcelGetCellBackgroundColour([WorkflowExpression] Func<string> mSExcelGetCellBackgroundColourcellReference, [WorkflowExpression] Func<string> mSExcelGetCellBackgroundColourworkflow, [WorkflowExpression] Func<int> mSExcelGetCellBackgroundColourhandle = null, [WorkflowExpression] Func<string> mSExcelGetCellBackgroundColourworkbookName = null, [WorkflowExpression] Func<string> mSExcelGetCellBackgroundColourworksheetName = null)
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
                    mSExcelGetCellBackgroundColour["Handle"] = ExpressionConverter.ConvertO(mSExcelGetCellBackgroundColourhandle);
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
        public IBodyWorkflowAction<MSExcelGetOLEObjectValueResponse> MSExcelGetOLEObjectValue([WorkflowExpression] Func<string> mSExcelGetOLEObjectValueoLEObjectName, [WorkflowExpression] Func<string> mSExcelGetOLEObjectValueworkflow, [WorkflowExpression] Func<int> mSExcelGetOLEObjectValuehandle = null, [WorkflowExpression] Func<string> mSExcelGetOLEObjectValueworkbookName = null, [WorkflowExpression] Func<string> mSExcelGetOLEObjectValueworksheetName = null)
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
                    mSExcelGetOLEObjectValue["Handle"] = ExpressionConverter.ConvertO(mSExcelGetOLEObjectValuehandle);
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
        public IBodyWorkflowAction<MSExcelDoesOLEObjectExistResponse> MSExcelDoesOLEObjectExist([WorkflowExpression] Func<string> mSExcelDoesOLEObjectExistoLEObjectName, [WorkflowExpression] Func<string> mSExcelDoesOLEObjectExistworkflow, [WorkflowExpression] Func<int> mSExcelDoesOLEObjectExisthandle = null, [WorkflowExpression] Func<string> mSExcelDoesOLEObjectExistworkbookName = null, [WorkflowExpression] Func<string> mSExcelDoesOLEObjectExistworksheetName = null)
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
                    mSExcelDoesOLEObjectExist["Handle"] = ExpressionConverter.ConvertO(mSExcelDoesOLEObjectExisthandle);
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
        public IBodyWorkflowAction<MSExcelPressOLEObjectResponse> MSExcelPressOLEObject([WorkflowExpression] Func<string> mSExcelPressOLEObjectoLEObjectName, [WorkflowExpression] Func<string> mSExcelPressOLEObjectworkflow, [WorkflowExpression] Func<int> mSExcelPressOLEObjecthandle = null, [WorkflowExpression] Func<string> mSExcelPressOLEObjectworkbookName = null, [WorkflowExpression] Func<string> mSExcelPressOLEObjectworksheetName = null, [WorkflowExpression] Func<bool> mSExcelPressOLEObjectrunInBackground = null)
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
                    mSExcelPressOLEObject["Handle"] = ExpressionConverter.ConvertO(mSExcelPressOLEObjecthandle);
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
                if (mSExcelPressOLEObjectrunInBackground != null)
                {
                    mSExcelPressOLEObject["RunInBackground"] = ExpressionConverter.ConvertO(mSExcelPressOLEObjectrunInBackground);
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
            mSExcelPressOLEObject["Workflow"] = ExpressionConverter.ConvertO(mSExcelPressOLEObjectworkflow);
            if (mSExcelPressOLEObjectpropCount > 0)
            {
                callPayload.Body = mSExcelPressOLEObject;
            }

            return new ApiConnectionAction<MSExcelPressOLEObjectResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelSetWorksheetSensitivityLabelResponse> MSExcelSetWorksheetSensitivityLabel([WorkflowExpression] Func<mSExcelSetWorksheetSensitivityLabelassignmentMethodInput> mSExcelSetWorksheetSensitivityLabelassignmentMethod, [WorkflowExpression] Func<string> mSExcelSetWorksheetSensitivityLabellabelId, [WorkflowExpression] Func<string> mSExcelSetWorksheetSensitivityLabelworkflow, [WorkflowExpression] Func<int> mSExcelSetWorksheetSensitivityLabelhandle = null, [WorkflowExpression] Func<string> mSExcelSetWorksheetSensitivityLabelworkbookName = null, [WorkflowExpression] Func<string> mSExcelSetWorksheetSensitivityLabellabelName = null, [WorkflowExpression] Func<string> mSExcelSetWorksheetSensitivityLabelsiteId = null, [WorkflowExpression] Func<string> mSExcelSetWorksheetSensitivityLabeljustification = null)
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
                    mSExcelSetWorksheetSensitivityLabel["Handle"] = ExpressionConverter.ConvertO(mSExcelSetWorksheetSensitivityLabelhandle);
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
        public IBodyWorkflowAction<MSExcelGetWorksheetSensitivityLabelResponse> MSExcelGetWorksheetSensitivityLabel([WorkflowExpression] Func<string> mSExcelGetWorksheetSensitivityLabelworkflow, [WorkflowExpression] Func<int> mSExcelGetWorksheetSensitivityLabelhandle = null, [WorkflowExpression] Func<string> mSExcelGetWorksheetSensitivityLabelworkbookName = null)
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
                    mSExcelGetWorksheetSensitivityLabel["Handle"] = ExpressionConverter.ConvertO(mSExcelGetWorksheetSensitivityLabelhandle);
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
        public IBodyWorkflowAction<MSExcelWriteArrayResponse> MSExcelWriteArray([WorkflowExpression] Func<string> mSExcelWriteArraycellReference, [WorkflowExpression] Func<string> mSExcelWriteArrayarrayToWriteJSON, [WorkflowExpression] Func<mSExcelWriteArraydirectionInput> mSExcelWriteArraydirection, [WorkflowExpression] Func<string> mSExcelWriteArrayworkflow, [WorkflowExpression] Func<int> mSExcelWriteArrayhandle = null, [WorkflowExpression] Func<string> mSExcelWriteArrayworkbookName = null, [WorkflowExpression] Func<string> mSExcelWriteArrayworksheetName = null)
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
                    mSExcelWriteArray["Handle"] = ExpressionConverter.ConvertO(mSExcelWriteArrayhandle);
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
        public IBodyWorkflowAction<MSOutlookCreateInstanceResponse> MSOutlookCreateInstance([WorkflowExpression] Func<string> mSOutlookCreateInstanceworkflow, [WorkflowExpression] Func<string> mSOutlookCreateInstanceprofileName = null, [WorkflowExpression] Func<bool> mSOutlookCreateInstanceshowOutlook = null)
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
                if (mSOutlookCreateInstanceshowOutlook != null)
                {
                    mSOutlookCreateInstance["ShowOutlook"] = ExpressionConverter.ConvertO(mSOutlookCreateInstanceshowOutlook);
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
            mSOutlookCreateInstance["Workflow"] = ExpressionConverter.ConvertO(mSOutlookCreateInstanceworkflow);
            if (mSOutlookCreateInstancepropCount > 0)
            {
                callPayload.Body = mSOutlookCreateInstance;
            }

            return new ApiConnectionAction<MSOutlookCreateInstanceResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSOutlookCloseInstance([WorkflowExpression] Func<string> mSOutlookCloseInstanceworkflow, [WorkflowExpression] Func<int> mSOutlookCloseInstancesecondsToWaitForProcessToClose = null)
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
                    mSOutlookCloseInstance["SecondsToWaitForProcessToClose"] = ExpressionConverter.ConvertO(mSOutlookCloseInstancesecondsToWaitForProcessToClose);
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
            mSOutlookCloseInstance["Workflow"] = ExpressionConverter.ConvertO(mSOutlookCloseInstanceworkflow);
            if (mSOutlookCloseInstancepropCount > 0)
            {
                callPayload.Body = mSOutlookCloseInstance;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSOutlookCloseInstanceUsingWindow([WorkflowExpression] Func<string> mSOutlookCloseInstanceUsingWindowworkflow, [WorkflowExpression] Func<bool> mSOutlookCloseInstanceUsingWindowuseNativeWindow = null, [WorkflowExpression] Func<bool> mSOutlookCloseInstanceUsingWindowuseUIA = null, [WorkflowExpression] Func<int> mSOutlookCloseInstanceUsingWindowsecondsToWaitForProcessToClose = null)
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
                    mSOutlookCloseInstanceUsingWindow["UseNativeWindow"] = ExpressionConverter.ConvertO(mSOutlookCloseInstanceUsingWindowuseNativeWindow);
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
                    mSOutlookCloseInstanceUsingWindow["UseUIA"] = ExpressionConverter.ConvertO(mSOutlookCloseInstanceUsingWindowuseUIA);
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
                    mSOutlookCloseInstanceUsingWindow["SecondsToWaitForProcessToClose"] = ExpressionConverter.ConvertO(mSOutlookCloseInstanceUsingWindowsecondsToWaitForProcessToClose);
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
            mSOutlookCloseInstanceUsingWindow["Workflow"] = ExpressionConverter.ConvertO(mSOutlookCloseInstanceUsingWindowworkflow);
            if (mSOutlookCloseInstanceUsingWindowpropCount > 0)
            {
                callPayload.Body = mSOutlookCloseInstanceUsingWindow;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookAttachToExistingInstanceResponse> MSOutlookAttachToExistingInstance([WorkflowExpression] Func<string> mSOutlookAttachToExistingInstanceworkflow, [WorkflowExpression] Func<bool> mSOutlookAttachToExistingInstancetoggleWindow = null, [WorkflowExpression] Func<bool> mSOutlookAttachToExistingInstancetoggleUsesGlobalLeftMouseClickAgent = null, [WorkflowExpression] Func<double> mSOutlookAttachToExistingInstancetoggleDelay = null)
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
                    mSOutlookAttachToExistingInstance["ToggleWindow"] = ExpressionConverter.ConvertO(mSOutlookAttachToExistingInstancetoggleWindow);
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
                    mSOutlookAttachToExistingInstance["ToggleUsesGlobalLeftMouseClickAgent"] = ExpressionConverter.ConvertO(mSOutlookAttachToExistingInstancetoggleUsesGlobalLeftMouseClickAgent);
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
                    mSOutlookAttachToExistingInstance["ToggleDelay"] = ExpressionConverter.ConvertO(mSOutlookAttachToExistingInstancetoggleDelay);
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
            mSOutlookAttachToExistingInstance["Workflow"] = ExpressionConverter.ConvertO(mSOutlookAttachToExistingInstanceworkflow);
            if (mSOutlookAttachToExistingInstancepropCount > 0)
            {
                callPayload.Body = mSOutlookAttachToExistingInstance;
            }

            return new ApiConnectionAction<MSOutlookAttachToExistingInstanceResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookIsConnectedResponse> MSOutlookIsConnected([WorkflowExpression] Func<string> mSOutlookIsConnectedworkflow)
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
        public IWorkflowAction MSOutlookShow([WorkflowExpression] Func<string> mSOutlookShowworkflow)
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
        public IBodyWorkflowAction<MSOutlookGetNameSpaceInformationResponse> MSOutlookGetNameSpaceInformation([WorkflowExpression] Func<string> mSOutlookGetNameSpaceInformationworkflow)
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
        public IBodyWorkflowAction<MSOutlookGetMailFoldersResponse> MSOutlookGetMailFolders([WorkflowExpression] Func<string> mSOutlookGetMailFoldersworkflow, [WorkflowExpression] Func<string> mSOutlookGetMailFoldersfolderPath = null, [WorkflowExpression] Func<bool> mSOutlookGetMailFolderssubFolders = null)
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
                if (mSOutlookGetMailFolderssubFolders != null)
                {
                    mSOutlookGetMailFolders["SubFolders"] = ExpressionConverter.ConvertO(mSOutlookGetMailFolderssubFolders);
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
            mSOutlookGetMailFolders["Workflow"] = ExpressionConverter.ConvertO(mSOutlookGetMailFoldersworkflow);
            if (mSOutlookGetMailFolderspropCount > 0)
            {
                callPayload.Body = mSOutlookGetMailFolders;
            }

            return new ApiConnectionAction<MSOutlookGetMailFoldersResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSOutlookMarkEmailAsRead([WorkflowExpression] Func<string> mSOutlookMarkEmailAsReadentryID, [WorkflowExpression] Func<string> mSOutlookMarkEmailAsReadworkflow, [WorkflowExpression] Func<bool> mSOutlookMarkEmailAsReadread = null)
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
                if (mSOutlookMarkEmailAsReadread != null)
                {
                    mSOutlookMarkEmailAsRead["Read"] = ExpressionConverter.ConvertO(mSOutlookMarkEmailAsReadread);
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
            mSOutlookMarkEmailAsRead["Workflow"] = ExpressionConverter.ConvertO(mSOutlookMarkEmailAsReadworkflow);
            if (mSOutlookMarkEmailAsReadpropCount > 0)
            {
                callPayload.Body = mSOutlookMarkEmailAsRead;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookGetEmailBodyResponse> MSOutlookGetEmailBody([WorkflowExpression] Func<string> mSOutlookGetEmailBodyentryID, [WorkflowExpression] Func<string> mSOutlookGetEmailBodyworkflow, [WorkflowExpression] Func<bool> mSOutlookGetEmailBodyclickAllowButtonIfRequired = null)
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
                if (mSOutlookGetEmailBodyclickAllowButtonIfRequired != null)
                {
                    mSOutlookGetEmailBody["ClickAllowButtonIfRequired"] = ExpressionConverter.ConvertO(mSOutlookGetEmailBodyclickAllowButtonIfRequired);
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
            mSOutlookGetEmailBody["Workflow"] = ExpressionConverter.ConvertO(mSOutlookGetEmailBodyworkflow);
            if (mSOutlookGetEmailBodypropCount > 0)
            {
                callPayload.Body = mSOutlookGetEmailBody;
            }

            return new ApiConnectionAction<MSOutlookGetEmailBodyResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookGetEmailAttachmentFilenamesResponse> MSOutlookGetEmailAttachmentFilenames([WorkflowExpression] Func<string> mSOutlookGetEmailAttachmentFilenamesentryID, [WorkflowExpression] Func<string> mSOutlookGetEmailAttachmentFilenamesworkflow, [WorkflowExpression] Func<bool> mSOutlookGetEmailAttachmentFilenamesclickAllowButtonIfRequired = null)
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
                if (mSOutlookGetEmailAttachmentFilenamesclickAllowButtonIfRequired != null)
                {
                    mSOutlookGetEmailAttachmentFilenames["ClickAllowButtonIfRequired"] = ExpressionConverter.ConvertO(mSOutlookGetEmailAttachmentFilenamesclickAllowButtonIfRequired);
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
            mSOutlookGetEmailAttachmentFilenames["Workflow"] = ExpressionConverter.ConvertO(mSOutlookGetEmailAttachmentFilenamesworkflow);
            if (mSOutlookGetEmailAttachmentFilenamespropCount > 0)
            {
                callPayload.Body = mSOutlookGetEmailAttachmentFilenames;
            }

            return new ApiConnectionAction<MSOutlookGetEmailAttachmentFilenamesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookSaveEmailAttachmentsAsFileResponse> MSOutlookSaveEmailAttachmentsAsFile([WorkflowExpression] Func<string> mSOutlookSaveEmailAttachmentsAsFileentryID, [WorkflowExpression] Func<string> mSOutlookSaveEmailAttachmentsAsFileworkflow, [WorkflowExpression] Func<string> mSOutlookSaveEmailAttachmentsAsFilesaveFolderPath = null, [WorkflowExpression] Func<bool> mSOutlookSaveEmailAttachmentsAsFilecreateFolder = null, [WorkflowExpression] Func<string> mSOutlookSaveEmailAttachmentsAsFileonlySaveAttachmentsMatchingWildcard = null, [WorkflowExpression] Func<bool> mSOutlookSaveEmailAttachmentsAsFilesaveHiddenAttachments = null, [WorkflowExpression] Func<bool> mSOutlookSaveEmailAttachmentsAsFileclickAllowButtonIfRequired = null)
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
                if (mSOutlookSaveEmailAttachmentsAsFilecreateFolder != null)
                {
                    mSOutlookSaveEmailAttachmentsAsFile["CreateFolder"] = ExpressionConverter.ConvertO(mSOutlookSaveEmailAttachmentsAsFilecreateFolder);
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
                mSOutlookSaveEmailAttachmentsAsFile["OnlySaveAttachmentsMatchingWildcard"] = ExpressionConverter.ConvertO(mSOutlookSaveEmailAttachmentsAsFileonlySaveAttachmentsMatchingWildcard);
                mSOutlookSaveEmailAttachmentsAsFilepropCount++;
            }

            if (mSOutlookSaveEmailAttachmentsAsFilesaveHiddenAttachments != null)
            {
                if (mSOutlookSaveEmailAttachmentsAsFilesaveHiddenAttachments != null)
                {
                    mSOutlookSaveEmailAttachmentsAsFile["SaveHiddenAttachments"] = ExpressionConverter.ConvertO(mSOutlookSaveEmailAttachmentsAsFilesaveHiddenAttachments);
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
                    mSOutlookSaveEmailAttachmentsAsFile["ClickAllowButtonIfRequired"] = ExpressionConverter.ConvertO(mSOutlookSaveEmailAttachmentsAsFileclickAllowButtonIfRequired);
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
            mSOutlookSaveEmailAttachmentsAsFile["Workflow"] = ExpressionConverter.ConvertO(mSOutlookSaveEmailAttachmentsAsFileworkflow);
            if (mSOutlookSaveEmailAttachmentsAsFilepropCount > 0)
            {
                callPayload.Body = mSOutlookSaveEmailAttachmentsAsFile;
            }

            return new ApiConnectionAction<MSOutlookSaveEmailAttachmentsAsFileResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSOutlookDeleteEmail([WorkflowExpression] Func<string> mSOutlookDeleteEmailentryID, [WorkflowExpression] Func<string> mSOutlookDeleteEmailworkflow)
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
        public IWorkflowAction MSOutlookMoveEmail([WorkflowExpression] Func<string> mSOutlookMoveEmailentryID, [WorkflowExpression] Func<string> mSOutlookMoveEmailworkflow, [WorkflowExpression] Func<string> mSOutlookMoveEmaildestinationFolder = null)
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
        public IWorkflowAction MSOutlookSendEmail([WorkflowExpression] Func<string> mSOutlookSendEmailworkflow, [WorkflowExpression] Func<string> mSOutlookSendEmailto = null, [WorkflowExpression] Func<string> mSOutlookSendEmailcC = null, [WorkflowExpression] Func<string> mSOutlookSendEmailbCC = null, [WorkflowExpression] Func<string> mSOutlookSendEmailsubject = null, [WorkflowExpression] Func<mSOutlookSendEmailbodyFormatInput> mSOutlookSendEmailbodyFormat = null, [WorkflowExpression] Func<string> mSOutlookSendEmailbody = null, [WorkflowExpression] Func<string> mSOutlookSendEmailhTMLBody = null, [WorkflowExpression] Func<string> mSOutlookSendEmailrTFBody = null, [WorkflowExpression] Func<string> mSOutlookSendEmailattachmentFilenamesJSON = null, [WorkflowExpression] Func<bool> mSOutlookSendEmaildontSendIfAttachmentFilenameMissing = null, [WorkflowExpression] Func<bool> mSOutlookSendEmailclickAllowButtonIfRequired = null, [WorkflowExpression] Func<string> mSOutlookSendEmailvotingOptions = null, [WorkflowExpression] Func<string> mSOutlookSendEmailsendAsSMTPAddress = null, [WorkflowExpression] Func<bool> mSOutlookSendEmailbodyContainsStoredPassword = null)
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
                if (mSOutlookSendEmaildontSendIfAttachmentFilenameMissing != null)
                {
                    mSOutlookSendEmail["DontSendIfAttachmentFilenameMissing"] = ExpressionConverter.ConvertO(mSOutlookSendEmaildontSendIfAttachmentFilenameMissing);
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
                    mSOutlookSendEmail["ClickAllowButtonIfRequired"] = ExpressionConverter.ConvertO(mSOutlookSendEmailclickAllowButtonIfRequired);
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
                if (mSOutlookSendEmailbodyContainsStoredPassword != null)
                {
                    mSOutlookSendEmail["BodyContainsStoredPassword"] = ExpressionConverter.ConvertO(mSOutlookSendEmailbodyContainsStoredPassword);
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
            mSOutlookSendEmail["Workflow"] = ExpressionConverter.ConvertO(mSOutlookSendEmailworkflow);
            if (mSOutlookSendEmailpropCount > 0)
            {
                callPayload.Body = mSOutlookSendEmail;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSOutlookCreateMailFolder([WorkflowExpression] Func<string> mSOutlookCreateMailFolderworkflow, [WorkflowExpression] Func<string> mSOutlookCreateMailFolderparentFolderPath = null, [WorkflowExpression] Func<string> mSOutlookCreateMailFoldernewFolderName = null)
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
        public IWorkflowAction MSOutlookReplyToEmail([WorkflowExpression] Func<string> mSOutlookReplyToEmailentryID, [WorkflowExpression] Func<string> mSOutlookReplyToEmailworkflow, [WorkflowExpression] Func<bool> mSOutlookReplyToEmailreplyToAll = null, [WorkflowExpression] Func<mSOutlookReplyToEmailbodyFormatInput> mSOutlookReplyToEmailbodyFormat = null, [WorkflowExpression] Func<string> mSOutlookReplyToEmailbody = null, [WorkflowExpression] Func<string> mSOutlookReplyToEmailhTMLBody = null, [WorkflowExpression] Func<string> mSOutlookReplyToEmailrTFBody = null, [WorkflowExpression] Func<string> mSOutlookReplyToEmailattachmentFilenamesJSON = null, [WorkflowExpression] Func<bool> mSOutlookReplyToEmaildontSendIfAttachmentFilenameMissing = null, [WorkflowExpression] Func<bool> mSOutlookReplyToEmailclickAllowButtonIfRequired = null, [WorkflowExpression] Func<string> mSOutlookReplyToEmailvotingOptions = null, [WorkflowExpression] Func<string> mSOutlookReplyToEmailsendAsSMTPAddress = null, [WorkflowExpression] Func<bool> mSOutlookReplyToEmailbodyContainsStoredPassword = null)
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
                if (mSOutlookReplyToEmailreplyToAll != null)
                {
                    mSOutlookReplyToEmail["ReplyToAll"] = ExpressionConverter.ConvertO(mSOutlookReplyToEmailreplyToAll);
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
                if (mSOutlookReplyToEmaildontSendIfAttachmentFilenameMissing != null)
                {
                    mSOutlookReplyToEmail["DontSendIfAttachmentFilenameMissing"] = ExpressionConverter.ConvertO(mSOutlookReplyToEmaildontSendIfAttachmentFilenameMissing);
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
                    mSOutlookReplyToEmail["ClickAllowButtonIfRequired"] = ExpressionConverter.ConvertO(mSOutlookReplyToEmailclickAllowButtonIfRequired);
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
                if (mSOutlookReplyToEmailbodyContainsStoredPassword != null)
                {
                    mSOutlookReplyToEmail["BodyContainsStoredPassword"] = ExpressionConverter.ConvertO(mSOutlookReplyToEmailbodyContainsStoredPassword);
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
            mSOutlookReplyToEmail["Workflow"] = ExpressionConverter.ConvertO(mSOutlookReplyToEmailworkflow);
            if (mSOutlookReplyToEmailpropCount > 0)
            {
                callPayload.Body = mSOutlookReplyToEmail;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSOutlookForwardEmail([WorkflowExpression] Func<string> mSOutlookForwardEmailentryID, [WorkflowExpression] Func<string> mSOutlookForwardEmailworkflow, [WorkflowExpression] Func<string> mSOutlookForwardEmailto = null, [WorkflowExpression] Func<string> mSOutlookForwardEmailcC = null, [WorkflowExpression] Func<string> mSOutlookForwardEmailbCC = null, [WorkflowExpression] Func<bool> mSOutlookForwardEmailoverrideSubject = null, [WorkflowExpression] Func<string> mSOutlookForwardEmailsubject = null, [WorkflowExpression] Func<bool> mSOutlookForwardEmailoverrideBody = null, [WorkflowExpression] Func<mSOutlookForwardEmailbodyFormatInput> mSOutlookForwardEmailbodyFormat = null, [WorkflowExpression] Func<string> mSOutlookForwardEmailbody = null, [WorkflowExpression] Func<string> mSOutlookForwardEmailhTMLBody = null, [WorkflowExpression] Func<string> mSOutlookForwardEmailrTFBody = null, [WorkflowExpression] Func<bool> mSOutlookForwardEmailclickAllowButtonIfRequired = null, [WorkflowExpression] Func<string> mSOutlookForwardEmailvotingOptions = null, [WorkflowExpression] Func<string> mSOutlookForwardEmailsendAsSMTPAddress = null, [WorkflowExpression] Func<bool> mSOutlookForwardEmailincludeExistingHiddenAttachments = null, [WorkflowExpression] Func<bool> mSOutlookForwardEmailincludeExistingVisibleAttachments = null, [WorkflowExpression] Func<string> mSOutlookForwardEmailattachmentFilenamesJSON = null, [WorkflowExpression] Func<bool> mSOutlookForwardEmaildontSendIfAttachmentFilenameMissing = null, [WorkflowExpression] Func<bool> mSOutlookForwardEmailbodyContainsStoredPassword = null)
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
                if (mSOutlookForwardEmailoverrideSubject != null)
                {
                    mSOutlookForwardEmail["OverrideSubject"] = ExpressionConverter.ConvertO(mSOutlookForwardEmailoverrideSubject);
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
                mSOutlookForwardEmail["Subject"] = ExpressionConverter.ConvertO(mSOutlookForwardEmailsubject);
                mSOutlookForwardEmailpropCount++;
            }

            if (mSOutlookForwardEmailoverrideBody != null)
            {
                if (mSOutlookForwardEmailoverrideBody != null)
                {
                    mSOutlookForwardEmail["OverrideBody"] = ExpressionConverter.ConvertO(mSOutlookForwardEmailoverrideBody);
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
                if (mSOutlookForwardEmailclickAllowButtonIfRequired != null)
                {
                    mSOutlookForwardEmail["ClickAllowButtonIfRequired"] = ExpressionConverter.ConvertO(mSOutlookForwardEmailclickAllowButtonIfRequired);
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
                if (mSOutlookForwardEmailincludeExistingHiddenAttachments != null)
                {
                    mSOutlookForwardEmail["IncludeExistingHiddenAttachments"] = ExpressionConverter.ConvertO(mSOutlookForwardEmailincludeExistingHiddenAttachments);
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
                    mSOutlookForwardEmail["IncludeExistingVisibleAttachments"] = ExpressionConverter.ConvertO(mSOutlookForwardEmailincludeExistingVisibleAttachments);
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
                mSOutlookForwardEmail["AttachmentFilenamesJSON"] = ExpressionConverter.ConvertO(mSOutlookForwardEmailattachmentFilenamesJSON);
                mSOutlookForwardEmailpropCount++;
            }

            if (mSOutlookForwardEmaildontSendIfAttachmentFilenameMissing != null)
            {
                if (mSOutlookForwardEmaildontSendIfAttachmentFilenameMissing != null)
                {
                    mSOutlookForwardEmail["DontSendIfAttachmentFilenameMissing"] = ExpressionConverter.ConvertO(mSOutlookForwardEmaildontSendIfAttachmentFilenameMissing);
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
                    mSOutlookForwardEmail["BodyContainsStoredPassword"] = ExpressionConverter.ConvertO(mSOutlookForwardEmailbodyContainsStoredPassword);
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
            mSOutlookForwardEmail["Workflow"] = ExpressionConverter.ConvertO(mSOutlookForwardEmailworkflow);
            if (mSOutlookForwardEmailpropCount > 0)
            {
                callPayload.Body = mSOutlookForwardEmail;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookGetMAPIProfilesResponse> MSOutlookGetMAPIProfiles([WorkflowExpression] Func<string> mSOutlookGetMAPIProfilesworkflow)
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
        public IBodyWorkflowAction<MSOutlookGetOutlookProcessIdResponse> MSOutlookGetOutlookProcessId([WorkflowExpression] Func<string> mSOutlookGetOutlookProcessIdworkflow)
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
        public IWorkflowAction MSOutlookBackgroundMonitorForAllowPopup([WorkflowExpression] Func<string> mSOutlookBackgroundMonitorForAllowPopupworkflow, [WorkflowExpression] Func<int> mSOutlookBackgroundMonitorForAllowPopupsecondsToWaitForDialog = null, [WorkflowExpression] Func<int> mSOutlookBackgroundMonitorForAllowPopupsecondsToWaitForAllowButton = null, [WorkflowExpression] Func<int> mSOutlookBackgroundMonitorForAllowPopupsecondsToWaitForAllowButtonToBeEnabled = null, [WorkflowExpression] Func<string> mSOutlookBackgroundMonitorForAllowPopupoutlookAllowButtonName = null)
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
                    mSOutlookBackgroundMonitorForAllowPopup["SecondsToWaitForDialog"] = ExpressionConverter.ConvertO(mSOutlookBackgroundMonitorForAllowPopupsecondsToWaitForDialog);
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
                    mSOutlookBackgroundMonitorForAllowPopup["SecondsToWaitForAllowButton"] = ExpressionConverter.ConvertO(mSOutlookBackgroundMonitorForAllowPopupsecondsToWaitForAllowButton);
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
                    mSOutlookBackgroundMonitorForAllowPopup["SecondsToWaitForAllowButtonToBeEnabled"] = ExpressionConverter.ConvertO(mSOutlookBackgroundMonitorForAllowPopupsecondsToWaitForAllowButtonToBeEnabled);
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
                    mSOutlookBackgroundMonitorForAllowPopup["OutlookAllowButtonName"] = ExpressionConverter.ConvertO(mSOutlookBackgroundMonitorForAllowPopupoutlookAllowButtonName);
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
            mSOutlookBackgroundMonitorForAllowPopup["Workflow"] = ExpressionConverter.ConvertO(mSOutlookBackgroundMonitorForAllowPopupworkflow);
            if (mSOutlookBackgroundMonitorForAllowPopuppropCount > 0)
            {
                callPayload.Body = mSOutlookBackgroundMonitorForAllowPopup;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSOutlookSetAllowPopupDetails([WorkflowExpression] Func<string> mSOutlookSetAllowPopupDetailsworkflow, [WorkflowExpression] Func<string> mSOutlookSetAllowPopupDetailsoutlookAllowButtonName = null, [WorkflowExpression] Func<string> mSOutlookSetAllowPopupDetailsoutlookAllowButtonAutomationId = null, [WorkflowExpression] Func<string> mSOutlookSetAllowPopupDetailsoutlookAllowCheckboxAutomationId = null)
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
                    mSOutlookSetAllowPopupDetails["OutlookAllowButtonName"] = ExpressionConverter.ConvertO(mSOutlookSetAllowPopupDetailsoutlookAllowButtonName);
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
                    mSOutlookSetAllowPopupDetails["OutlookAllowButtonAutomationId"] = ExpressionConverter.ConvertO(mSOutlookSetAllowPopupDetailsoutlookAllowButtonAutomationId);
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
                    mSOutlookSetAllowPopupDetails["OutlookAllowCheckboxAutomationId"] = ExpressionConverter.ConvertO(mSOutlookSetAllowPopupDetailsoutlookAllowCheckboxAutomationId);
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
            mSOutlookSetAllowPopupDetails["Workflow"] = ExpressionConverter.ConvertO(mSOutlookSetAllowPopupDetailsworkflow);
            if (mSOutlookSetAllowPopupDetailspropCount > 0)
            {
                callPayload.Body = mSOutlookSetAllowPopupDetails;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookExecuteCommandBarObjectResponse> MSOutlookExecuteCommandBarObject([WorkflowExpression] Func<string> mSOutlookExecuteCommandBarObjectobjectId, [WorkflowExpression] Func<string> mSOutlookExecuteCommandBarObjectworkflow, [WorkflowExpression] Func<bool> mSOutlookExecuteCommandBarObjectrunInBackground = null)
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
                if (mSOutlookExecuteCommandBarObjectrunInBackground != null)
                {
                    mSOutlookExecuteCommandBarObject["RunInBackground"] = ExpressionConverter.ConvertO(mSOutlookExecuteCommandBarObjectrunInBackground);
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
            mSOutlookExecuteCommandBarObject["Workflow"] = ExpressionConverter.ConvertO(mSOutlookExecuteCommandBarObjectworkflow);
            if (mSOutlookExecuteCommandBarObjectpropCount > 0)
            {
                callPayload.Body = mSOutlookExecuteCommandBarObject;
            }

            return new ApiConnectionAction<MSOutlookExecuteCommandBarObjectResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookGetEmailsResponse> MSOutlookGetEmails([WorkflowExpression] Func<string> mSOutlookGetEmailsworkflow, [WorkflowExpression] Func<string> mSOutlookGetEmailsfolderPath = null, [WorkflowExpression] Func<bool> mSOutlookGetEmailssearchRead = null, [WorkflowExpression] Func<bool> mSOutlookGetEmailssearchUnread = null, [WorkflowExpression] Func<string> mSOutlookGetEmailssearchSubject = null, [WorkflowExpression] Func<string> mSOutlookGetEmailssearchFromSMTP = null, [WorkflowExpression] Func<string> mSOutlookGetEmailssearchFromName = null, [WorkflowExpression] Func<string> mSOutlookGetEmailssearchQuery = null, [WorkflowExpression] Func<int> mSOutlookGetEmailssearchMaxAgeInDays = null, [WorkflowExpression] Func<string> mSOutlookGetEmailssearchStartDateTimeAsString = null, [WorkflowExpression] Func<string> mSOutlookGetEmailssearchEndDateTimeAsString = null, [WorkflowExpression] Func<int> mSOutlookGetEmailsmaxResultsToReturn = null, [WorkflowExpression] Func<bool> mSOutlookGetEmailsclickAllowButtonIfRequired = null)
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
                if (mSOutlookGetEmailssearchRead != null)
                {
                    mSOutlookGetEmails["SearchRead"] = ExpressionConverter.ConvertO(mSOutlookGetEmailssearchRead);
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
                    mSOutlookGetEmails["SearchUnread"] = ExpressionConverter.ConvertO(mSOutlookGetEmailssearchUnread);
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
                if (mSOutlookGetEmailssearchMaxAgeInDays != null)
                {
                    mSOutlookGetEmails["SearchMaxAgeInDays"] = ExpressionConverter.ConvertO(mSOutlookGetEmailssearchMaxAgeInDays);
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
                if (mSOutlookGetEmailsmaxResultsToReturn != null)
                {
                    mSOutlookGetEmails["MaxResultsToReturn"] = ExpressionConverter.ConvertO(mSOutlookGetEmailsmaxResultsToReturn);
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
                    mSOutlookGetEmails["ClickAllowButtonIfRequired"] = ExpressionConverter.ConvertO(mSOutlookGetEmailsclickAllowButtonIfRequired);
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
            mSOutlookGetEmails["Workflow"] = ExpressionConverter.ConvertO(mSOutlookGetEmailsworkflow);
            if (mSOutlookGetEmailspropCount > 0)
            {
                callPayload.Body = mSOutlookGetEmails;
            }

            return new ApiConnectionAction<MSOutlookGetEmailsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookGetFirstEmailResponse> MSOutlookGetFirstEmail([WorkflowExpression] Func<string> mSOutlookGetFirstEmailworkflow, [WorkflowExpression] Func<string> mSOutlookGetFirstEmailfolderPath = null, [WorkflowExpression] Func<bool> mSOutlookGetFirstEmailsearchRead = null, [WorkflowExpression] Func<bool> mSOutlookGetFirstEmailsearchUnread = null, [WorkflowExpression] Func<string> mSOutlookGetFirstEmailsearchSubject = null, [WorkflowExpression] Func<string> mSOutlookGetFirstEmailsearchFromSMTP = null, [WorkflowExpression] Func<string> mSOutlookGetFirstEmailsearchFromName = null, [WorkflowExpression] Func<string> mSOutlookGetFirstEmailsearchQuery = null, [WorkflowExpression] Func<int> mSOutlookGetFirstEmailsearchMaxAgeInDays = null, [WorkflowExpression] Func<string> mSOutlookGetFirstEmailsearchStartDateTimeAsString = null, [WorkflowExpression] Func<string> mSOutlookGetFirstEmailsearchEndDateTimeAsString = null, [WorkflowExpression] Func<bool> mSOutlookGetFirstEmailclickAllowButtonIfRequired = null)
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
                if (mSOutlookGetFirstEmailsearchRead != null)
                {
                    mSOutlookGetFirstEmail["SearchRead"] = ExpressionConverter.ConvertO(mSOutlookGetFirstEmailsearchRead);
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
                    mSOutlookGetFirstEmail["SearchUnread"] = ExpressionConverter.ConvertO(mSOutlookGetFirstEmailsearchUnread);
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
                if (mSOutlookGetFirstEmailsearchMaxAgeInDays != null)
                {
                    mSOutlookGetFirstEmail["SearchMaxAgeInDays"] = ExpressionConverter.ConvertO(mSOutlookGetFirstEmailsearchMaxAgeInDays);
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
                if (mSOutlookGetFirstEmailclickAllowButtonIfRequired != null)
                {
                    mSOutlookGetFirstEmail["ClickAllowButtonIfRequired"] = ExpressionConverter.ConvertO(mSOutlookGetFirstEmailclickAllowButtonIfRequired);
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
            mSOutlookGetFirstEmail["Workflow"] = ExpressionConverter.ConvertO(mSOutlookGetFirstEmailworkflow);
            if (mSOutlookGetFirstEmailpropCount > 0)
            {
                callPayload.Body = mSOutlookGetFirstEmail;
            }

            return new ApiConnectionAction<MSOutlookGetFirstEmailResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookGetNumberOfEmailsResponse> MSOutlookGetNumberOfEmails([WorkflowExpression] Func<string> mSOutlookGetNumberOfEmailsworkflow, [WorkflowExpression] Func<string> mSOutlookGetNumberOfEmailsfolderPath = null, [WorkflowExpression] Func<bool> mSOutlookGetNumberOfEmailssearchRead = null, [WorkflowExpression] Func<bool> mSOutlookGetNumberOfEmailssearchUnread = null, [WorkflowExpression] Func<string> mSOutlookGetNumberOfEmailssearchSubject = null, [WorkflowExpression] Func<string> mSOutlookGetNumberOfEmailssearchFromSMTP = null, [WorkflowExpression] Func<string> mSOutlookGetNumberOfEmailssearchFromName = null, [WorkflowExpression] Func<string> mSOutlookGetNumberOfEmailssearchQuery = null, [WorkflowExpression] Func<int> mSOutlookGetNumberOfEmailssearchMaxAgeInDays = null, [WorkflowExpression] Func<string> mSOutlookGetNumberOfEmailssearchStartDateTimeAsString = null, [WorkflowExpression] Func<string> mSOutlookGetNumberOfEmailssearchEndDateTimeAsString = null)
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
                if (mSOutlookGetNumberOfEmailssearchRead != null)
                {
                    mSOutlookGetNumberOfEmails["SearchRead"] = ExpressionConverter.ConvertO(mSOutlookGetNumberOfEmailssearchRead);
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
                    mSOutlookGetNumberOfEmails["SearchUnread"] = ExpressionConverter.ConvertO(mSOutlookGetNumberOfEmailssearchUnread);
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
                if (mSOutlookGetNumberOfEmailssearchMaxAgeInDays != null)
                {
                    mSOutlookGetNumberOfEmails["SearchMaxAgeInDays"] = ExpressionConverter.ConvertO(mSOutlookGetNumberOfEmailssearchMaxAgeInDays);
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