//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectmsoffice
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class IaconnectmsofficeActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordCreateInstanceResponse> MSWordCreateInstance(Expression<Func<string>> mSWordCreateInstanceworkflow, Expression<Func<bool>> mSWordCreateInstanceshowWord = null)
        {
            var __workflow_mSWordCreateInstanceworkflow = mSWordCreateInstanceworkflow == null ? null : WorkflowExpression.Compile(mSWordCreateInstanceworkflow);
            WorkflowExpression.Validate(__workflow_mSWordCreateInstanceworkflow, nameof(mSWordCreateInstanceworkflow), required: true);
            var __workflow_mSWordCreateInstanceshowWord = mSWordCreateInstanceshowWord == null ? null : WorkflowExpression.Compile(mSWordCreateInstanceshowWord);
            WorkflowExpression.Validate(__workflow_mSWordCreateInstanceshowWord, nameof(mSWordCreateInstanceshowWord), required: false);
            return new DeferredBodyAction<MSWordCreateInstanceResponse>(() =>
            {
                var apiCallPath = "/MSWord/CreateInstance";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSWordCreateInstance = new JObject();
                var mSWordCreateInstancepropCount = 0;
                if (__workflow_mSWordCreateInstanceshowWord != null)
                {
                    if (__workflow_mSWordCreateInstanceshowWord != null)
                    {
                        mSWordCreateInstance["ShowWord"] = ExpressionConverter.ConvertO(__workflow_mSWordCreateInstanceshowWord);
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
                mSWordCreateInstance["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSWordCreateInstanceworkflow);
                if (mSWordCreateInstancepropCount > 0)
                {
                    callPayload.Body = mSWordCreateInstance;
                }

                return new ApiConnectionAction<MSWordCreateInstanceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordCloseInstance(Expression<Func<string>> mSWordCloseInstanceworkflow, Expression<Func<int>> mSWordCloseInstancehandle = null)
        {
            var __workflow_mSWordCloseInstanceworkflow = mSWordCloseInstanceworkflow == null ? null : WorkflowExpression.Compile(mSWordCloseInstanceworkflow);
            WorkflowExpression.Validate(__workflow_mSWordCloseInstanceworkflow, nameof(mSWordCloseInstanceworkflow), required: true);
            var __workflow_mSWordCloseInstancehandle = mSWordCloseInstancehandle == null ? null : WorkflowExpression.Compile(mSWordCloseInstancehandle);
            WorkflowExpression.Validate(__workflow_mSWordCloseInstancehandle, nameof(mSWordCloseInstancehandle), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/MSWord/CloseInstance";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSWordCloseInstance = new JObject();
                var mSWordCloseInstancepropCount = 0;
                if (__workflow_mSWordCloseInstancehandle != null)
                {
                    if (__workflow_mSWordCloseInstancehandle != null)
                    {
                        mSWordCloseInstance["Handle"] = ExpressionConverter.ConvertO(__workflow_mSWordCloseInstancehandle);
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
                mSWordCloseInstance["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSWordCloseInstanceworkflow);
                if (mSWordCloseInstancepropCount > 0)
                {
                    callPayload.Body = mSWordCloseInstance;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordDetachFromInstance(Expression<Func<string>> mSWordDetachFromInstanceworkflow, Expression<Func<int>> mSWordDetachFromInstancehandle = null)
        {
            var __workflow_mSWordDetachFromInstanceworkflow = mSWordDetachFromInstanceworkflow == null ? null : WorkflowExpression.Compile(mSWordDetachFromInstanceworkflow);
            WorkflowExpression.Validate(__workflow_mSWordDetachFromInstanceworkflow, nameof(mSWordDetachFromInstanceworkflow), required: true);
            var __workflow_mSWordDetachFromInstancehandle = mSWordDetachFromInstancehandle == null ? null : WorkflowExpression.Compile(mSWordDetachFromInstancehandle);
            WorkflowExpression.Validate(__workflow_mSWordDetachFromInstancehandle, nameof(mSWordDetachFromInstancehandle), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/MSWord/DetachFromInstance";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSWordDetachFromInstance = new JObject();
                var mSWordDetachFromInstancepropCount = 0;
                if (__workflow_mSWordDetachFromInstancehandle != null)
                {
                    if (__workflow_mSWordDetachFromInstancehandle != null)
                    {
                        mSWordDetachFromInstance["Handle"] = ExpressionConverter.ConvertO(__workflow_mSWordDetachFromInstancehandle);
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
                mSWordDetachFromInstance["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSWordDetachFromInstanceworkflow);
                if (mSWordDetachFromInstancepropCount > 0)
                {
                    callPayload.Body = mSWordDetachFromInstance;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordAttachToExistingInstanceResponse> MSWordAttachToExistingInstance(Expression<Func<string>> mSWordAttachToExistingInstanceworkflow, Expression<Func<string>> mSWordAttachToExistingInstancefilename = null, Expression<Func<bool>> mSWordAttachToExistingInstancetoggleWindow = null, Expression<Func<bool>> mSWordAttachToExistingInstancetoggleUsesGlobalLeftMouseClickAgent = null, Expression<Func<double>> mSWordAttachToExistingInstancetoggleDelay = null)
        {
            var __workflow_mSWordAttachToExistingInstanceworkflow = mSWordAttachToExistingInstanceworkflow == null ? null : WorkflowExpression.Compile(mSWordAttachToExistingInstanceworkflow);
            WorkflowExpression.Validate(__workflow_mSWordAttachToExistingInstanceworkflow, nameof(mSWordAttachToExistingInstanceworkflow), required: true);
            var __workflow_mSWordAttachToExistingInstancefilename = mSWordAttachToExistingInstancefilename == null ? null : WorkflowExpression.Compile(mSWordAttachToExistingInstancefilename);
            WorkflowExpression.Validate(__workflow_mSWordAttachToExistingInstancefilename, nameof(mSWordAttachToExistingInstancefilename), required: false);
            var __workflow_mSWordAttachToExistingInstancetoggleWindow = mSWordAttachToExistingInstancetoggleWindow == null ? null : WorkflowExpression.Compile(mSWordAttachToExistingInstancetoggleWindow);
            WorkflowExpression.Validate(__workflow_mSWordAttachToExistingInstancetoggleWindow, nameof(mSWordAttachToExistingInstancetoggleWindow), required: false);
            var __workflow_mSWordAttachToExistingInstancetoggleUsesGlobalLeftMouseClickAgent = mSWordAttachToExistingInstancetoggleUsesGlobalLeftMouseClickAgent == null ? null : WorkflowExpression.Compile(mSWordAttachToExistingInstancetoggleUsesGlobalLeftMouseClickAgent);
            WorkflowExpression.Validate(__workflow_mSWordAttachToExistingInstancetoggleUsesGlobalLeftMouseClickAgent, nameof(mSWordAttachToExistingInstancetoggleUsesGlobalLeftMouseClickAgent), required: false);
            var __workflow_mSWordAttachToExistingInstancetoggleDelay = mSWordAttachToExistingInstancetoggleDelay == null ? null : WorkflowExpression.Compile(mSWordAttachToExistingInstancetoggleDelay);
            WorkflowExpression.Validate(__workflow_mSWordAttachToExistingInstancetoggleDelay, nameof(mSWordAttachToExistingInstancetoggleDelay), required: false);
            return new DeferredBodyAction<MSWordAttachToExistingInstanceResponse>(() =>
            {
                var apiCallPath = "/MSWord/AttachToExistingInstance";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSWordAttachToExistingInstance = new JObject();
                var mSWordAttachToExistingInstancepropCount = 0;
                if (__workflow_mSWordAttachToExistingInstancefilename != null)
                {
                    mSWordAttachToExistingInstance["Filename"] = ExpressionConverter.ConvertO(__workflow_mSWordAttachToExistingInstancefilename);
                    mSWordAttachToExistingInstancepropCount++;
                }

                if (__workflow_mSWordAttachToExistingInstancetoggleWindow != null)
                {
                    if (__workflow_mSWordAttachToExistingInstancetoggleWindow != null)
                    {
                        mSWordAttachToExistingInstance["ToggleWindow"] = ExpressionConverter.ConvertO(__workflow_mSWordAttachToExistingInstancetoggleWindow);
                        mSWordAttachToExistingInstancepropCount++;
                    }

                    mSWordAttachToExistingInstancepropCount++;
                }
                else
                {
                    mSWordAttachToExistingInstance["ToggleWindow"] = true;
                    mSWordAttachToExistingInstancepropCount++;
                }

                if (__workflow_mSWordAttachToExistingInstancetoggleUsesGlobalLeftMouseClickAgent != null)
                {
                    if (__workflow_mSWordAttachToExistingInstancetoggleUsesGlobalLeftMouseClickAgent != null)
                    {
                        mSWordAttachToExistingInstance["ToggleUsesGlobalLeftMouseClickAgent"] = ExpressionConverter.ConvertO(__workflow_mSWordAttachToExistingInstancetoggleUsesGlobalLeftMouseClickAgent);
                        mSWordAttachToExistingInstancepropCount++;
                    }

                    mSWordAttachToExistingInstancepropCount++;
                }
                else
                {
                    mSWordAttachToExistingInstance["ToggleUsesGlobalLeftMouseClickAgent"] = true;
                    mSWordAttachToExistingInstancepropCount++;
                }

                if (__workflow_mSWordAttachToExistingInstancetoggleDelay != null)
                {
                    if (__workflow_mSWordAttachToExistingInstancetoggleDelay != null)
                    {
                        mSWordAttachToExistingInstance["ToggleDelay"] = ExpressionConverter.ConvertO(__workflow_mSWordAttachToExistingInstancetoggleDelay);
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
                mSWordAttachToExistingInstance["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSWordAttachToExistingInstanceworkflow);
                if (mSWordAttachToExistingInstancepropCount > 0)
                {
                    callPayload.Body = mSWordAttachToExistingInstance;
                }

                return new ApiConnectionAction<MSWordAttachToExistingInstanceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordShowWord(Expression<Func<string>> mSWordShowWordworkflow, Expression<Func<int>> mSWordShowWordhandle = null)
        {
            var __workflow_mSWordShowWordworkflow = mSWordShowWordworkflow == null ? null : WorkflowExpression.Compile(mSWordShowWordworkflow);
            WorkflowExpression.Validate(__workflow_mSWordShowWordworkflow, nameof(mSWordShowWordworkflow), required: true);
            var __workflow_mSWordShowWordhandle = mSWordShowWordhandle == null ? null : WorkflowExpression.Compile(mSWordShowWordhandle);
            WorkflowExpression.Validate(__workflow_mSWordShowWordhandle, nameof(mSWordShowWordhandle), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/MSWord/ShowWord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSWordShowWord = new JObject();
                var mSWordShowWordpropCount = 0;
                if (__workflow_mSWordShowWordhandle != null)
                {
                    if (__workflow_mSWordShowWordhandle != null)
                    {
                        mSWordShowWord["Handle"] = ExpressionConverter.ConvertO(__workflow_mSWordShowWordhandle);
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
                mSWordShowWord["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSWordShowWordworkflow);
                if (mSWordShowWordpropCount > 0)
                {
                    callPayload.Body = mSWordShowWord;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordHideWord(Expression<Func<string>> mSWordHideWordworkflow, Expression<Func<int>> mSWordHideWordhandle = null)
        {
            var __workflow_mSWordHideWordworkflow = mSWordHideWordworkflow == null ? null : WorkflowExpression.Compile(mSWordHideWordworkflow);
            WorkflowExpression.Validate(__workflow_mSWordHideWordworkflow, nameof(mSWordHideWordworkflow), required: true);
            var __workflow_mSWordHideWordhandle = mSWordHideWordhandle == null ? null : WorkflowExpression.Compile(mSWordHideWordhandle);
            WorkflowExpression.Validate(__workflow_mSWordHideWordhandle, nameof(mSWordHideWordhandle), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/MSWord/HideWord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSWordHideWord = new JObject();
                var mSWordHideWordpropCount = 0;
                if (__workflow_mSWordHideWordhandle != null)
                {
                    if (__workflow_mSWordHideWordhandle != null)
                    {
                        mSWordHideWord["Handle"] = ExpressionConverter.ConvertO(__workflow_mSWordHideWordhandle);
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
                mSWordHideWord["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSWordHideWordworkflow);
                if (mSWordHideWordpropCount > 0)
                {
                    callPayload.Body = mSWordHideWord;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordCreateDocumentResponse> MSWordCreateDocument(Expression<Func<string>> mSWordCreateDocumentworkflow, Expression<Func<int>> mSWordCreateDocumenthandle = null)
        {
            var __workflow_mSWordCreateDocumentworkflow = mSWordCreateDocumentworkflow == null ? null : WorkflowExpression.Compile(mSWordCreateDocumentworkflow);
            WorkflowExpression.Validate(__workflow_mSWordCreateDocumentworkflow, nameof(mSWordCreateDocumentworkflow), required: true);
            var __workflow_mSWordCreateDocumenthandle = mSWordCreateDocumenthandle == null ? null : WorkflowExpression.Compile(mSWordCreateDocumenthandle);
            WorkflowExpression.Validate(__workflow_mSWordCreateDocumenthandle, nameof(mSWordCreateDocumenthandle), required: false);
            return new DeferredBodyAction<MSWordCreateDocumentResponse>(() =>
            {
                var apiCallPath = "/MSWord/CreateDocument";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSWordCreateDocument = new JObject();
                var mSWordCreateDocumentpropCount = 0;
                if (__workflow_mSWordCreateDocumenthandle != null)
                {
                    if (__workflow_mSWordCreateDocumenthandle != null)
                    {
                        mSWordCreateDocument["Handle"] = ExpressionConverter.ConvertO(__workflow_mSWordCreateDocumenthandle);
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
                mSWordCreateDocument["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSWordCreateDocumentworkflow);
                if (mSWordCreateDocumentpropCount > 0)
                {
                    callPayload.Body = mSWordCreateDocument;
                }

                return new ApiConnectionAction<MSWordCreateDocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordOpenDocumentResponse> MSWordOpenDocument(Expression<Func<string>> mSWordOpenDocumentfilename, Expression<Func<string>> mSWordOpenDocumentworkflow, Expression<Func<int>> mSWordOpenDocumenthandle = null, Expression<Func<bool>> mSWordOpenDocumentopenReadOnly = null, Expression<Func<bool>> mSWordOpenDocumentaddToRecentFiles = null, Expression<Func<string>> mSWordOpenDocumentpassword = null, Expression<Func<bool>> mSWordOpenDocumentopenAndRepair = null)
        {
            var __workflow_mSWordOpenDocumentfilename = mSWordOpenDocumentfilename == null ? null : WorkflowExpression.Compile(mSWordOpenDocumentfilename);
            WorkflowExpression.Validate(__workflow_mSWordOpenDocumentfilename, nameof(mSWordOpenDocumentfilename), required: true);
            var __workflow_mSWordOpenDocumentworkflow = mSWordOpenDocumentworkflow == null ? null : WorkflowExpression.Compile(mSWordOpenDocumentworkflow);
            WorkflowExpression.Validate(__workflow_mSWordOpenDocumentworkflow, nameof(mSWordOpenDocumentworkflow), required: true);
            var __workflow_mSWordOpenDocumenthandle = mSWordOpenDocumenthandle == null ? null : WorkflowExpression.Compile(mSWordOpenDocumenthandle);
            WorkflowExpression.Validate(__workflow_mSWordOpenDocumenthandle, nameof(mSWordOpenDocumenthandle), required: false);
            var __workflow_mSWordOpenDocumentopenReadOnly = mSWordOpenDocumentopenReadOnly == null ? null : WorkflowExpression.Compile(mSWordOpenDocumentopenReadOnly);
            WorkflowExpression.Validate(__workflow_mSWordOpenDocumentopenReadOnly, nameof(mSWordOpenDocumentopenReadOnly), required: false);
            var __workflow_mSWordOpenDocumentaddToRecentFiles = mSWordOpenDocumentaddToRecentFiles == null ? null : WorkflowExpression.Compile(mSWordOpenDocumentaddToRecentFiles);
            WorkflowExpression.Validate(__workflow_mSWordOpenDocumentaddToRecentFiles, nameof(mSWordOpenDocumentaddToRecentFiles), required: false);
            var __workflow_mSWordOpenDocumentpassword = mSWordOpenDocumentpassword == null ? null : WorkflowExpression.Compile(mSWordOpenDocumentpassword);
            WorkflowExpression.Validate(__workflow_mSWordOpenDocumentpassword, nameof(mSWordOpenDocumentpassword), required: false);
            var __workflow_mSWordOpenDocumentopenAndRepair = mSWordOpenDocumentopenAndRepair == null ? null : WorkflowExpression.Compile(mSWordOpenDocumentopenAndRepair);
            WorkflowExpression.Validate(__workflow_mSWordOpenDocumentopenAndRepair, nameof(mSWordOpenDocumentopenAndRepair), required: false);
            return new DeferredBodyAction<MSWordOpenDocumentResponse>(() =>
            {
                var apiCallPath = "/MSWord/OpenDocument";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSWordOpenDocument = new JObject();
                var mSWordOpenDocumentpropCount = 0;
                if (__workflow_mSWordOpenDocumenthandle != null)
                {
                    if (__workflow_mSWordOpenDocumenthandle != null)
                    {
                        mSWordOpenDocument["Handle"] = ExpressionConverter.ConvertO(__workflow_mSWordOpenDocumenthandle);
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
                mSWordOpenDocument["Filename"] = ExpressionConverter.ConvertO(__workflow_mSWordOpenDocumentfilename);
                if (__workflow_mSWordOpenDocumentopenReadOnly != null)
                {
                    if (__workflow_mSWordOpenDocumentopenReadOnly != null)
                    {
                        mSWordOpenDocument["OpenReadOnly"] = ExpressionConverter.ConvertO(__workflow_mSWordOpenDocumentopenReadOnly);
                        mSWordOpenDocumentpropCount++;
                    }

                    mSWordOpenDocumentpropCount++;
                }
                else
                {
                    mSWordOpenDocument["OpenReadOnly"] = false;
                    mSWordOpenDocumentpropCount++;
                }

                if (__workflow_mSWordOpenDocumentaddToRecentFiles != null)
                {
                    if (__workflow_mSWordOpenDocumentaddToRecentFiles != null)
                    {
                        mSWordOpenDocument["AddToRecentFiles"] = ExpressionConverter.ConvertO(__workflow_mSWordOpenDocumentaddToRecentFiles);
                        mSWordOpenDocumentpropCount++;
                    }

                    mSWordOpenDocumentpropCount++;
                }
                else
                {
                    mSWordOpenDocument["AddToRecentFiles"] = false;
                    mSWordOpenDocumentpropCount++;
                }

                if (__workflow_mSWordOpenDocumentpassword != null)
                {
                    mSWordOpenDocument["Password"] = ExpressionConverter.ConvertO(__workflow_mSWordOpenDocumentpassword);
                    mSWordOpenDocumentpropCount++;
                }

                if (__workflow_mSWordOpenDocumentopenAndRepair != null)
                {
                    if (__workflow_mSWordOpenDocumentopenAndRepair != null)
                    {
                        mSWordOpenDocument["OpenAndRepair"] = ExpressionConverter.ConvertO(__workflow_mSWordOpenDocumentopenAndRepair);
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
                mSWordOpenDocument["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSWordOpenDocumentworkflow);
                if (mSWordOpenDocumentpropCount > 0)
                {
                    callPayload.Body = mSWordOpenDocument;
                }

                return new ApiConnectionAction<MSWordOpenDocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordSaveDocument(Expression<Func<string>> mSWordSaveDocumentworkflow, Expression<Func<int>> mSWordSaveDocumenthandle = null, Expression<Func<string>> mSWordSaveDocumentdocumentName = null)
        {
            var __workflow_mSWordSaveDocumentworkflow = mSWordSaveDocumentworkflow == null ? null : WorkflowExpression.Compile(mSWordSaveDocumentworkflow);
            WorkflowExpression.Validate(__workflow_mSWordSaveDocumentworkflow, nameof(mSWordSaveDocumentworkflow), required: true);
            var __workflow_mSWordSaveDocumenthandle = mSWordSaveDocumenthandle == null ? null : WorkflowExpression.Compile(mSWordSaveDocumenthandle);
            WorkflowExpression.Validate(__workflow_mSWordSaveDocumenthandle, nameof(mSWordSaveDocumenthandle), required: false);
            var __workflow_mSWordSaveDocumentdocumentName = mSWordSaveDocumentdocumentName == null ? null : WorkflowExpression.Compile(mSWordSaveDocumentdocumentName);
            WorkflowExpression.Validate(__workflow_mSWordSaveDocumentdocumentName, nameof(mSWordSaveDocumentdocumentName), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/MSWord/Save";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSWordSaveDocument = new JObject();
                var mSWordSaveDocumentpropCount = 0;
                if (__workflow_mSWordSaveDocumenthandle != null)
                {
                    if (__workflow_mSWordSaveDocumenthandle != null)
                    {
                        mSWordSaveDocument["Handle"] = ExpressionConverter.ConvertO(__workflow_mSWordSaveDocumenthandle);
                        mSWordSaveDocumentpropCount++;
                    }

                    mSWordSaveDocumentpropCount++;
                }
                else
                {
                    mSWordSaveDocument["Handle"] = 0;
                    mSWordSaveDocumentpropCount++;
                }

                if (__workflow_mSWordSaveDocumentdocumentName != null)
                {
                    mSWordSaveDocument["DocumentName"] = ExpressionConverter.ConvertO(__workflow_mSWordSaveDocumentdocumentName);
                    mSWordSaveDocumentpropCount++;
                }

                mSWordSaveDocumentpropCount++;
                mSWordSaveDocument["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSWordSaveDocumentworkflow);
                if (mSWordSaveDocumentpropCount > 0)
                {
                    callPayload.Body = mSWordSaveDocument;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordSaveAsDocumentResponse> MSWordSaveAsDocument(Expression<Func<string>> mSWordSaveAsDocumentsaveFilename, Expression<Func<string>> mSWordSaveAsDocumentworkflow, Expression<Func<int>> mSWordSaveAsDocumenthandle = null, Expression<Func<string>> mSWordSaveAsDocumentdocumentName = null)
        {
            var __workflow_mSWordSaveAsDocumentsaveFilename = mSWordSaveAsDocumentsaveFilename == null ? null : WorkflowExpression.Compile(mSWordSaveAsDocumentsaveFilename);
            WorkflowExpression.Validate(__workflow_mSWordSaveAsDocumentsaveFilename, nameof(mSWordSaveAsDocumentsaveFilename), required: true);
            var __workflow_mSWordSaveAsDocumentworkflow = mSWordSaveAsDocumentworkflow == null ? null : WorkflowExpression.Compile(mSWordSaveAsDocumentworkflow);
            WorkflowExpression.Validate(__workflow_mSWordSaveAsDocumentworkflow, nameof(mSWordSaveAsDocumentworkflow), required: true);
            var __workflow_mSWordSaveAsDocumenthandle = mSWordSaveAsDocumenthandle == null ? null : WorkflowExpression.Compile(mSWordSaveAsDocumenthandle);
            WorkflowExpression.Validate(__workflow_mSWordSaveAsDocumenthandle, nameof(mSWordSaveAsDocumenthandle), required: false);
            var __workflow_mSWordSaveAsDocumentdocumentName = mSWordSaveAsDocumentdocumentName == null ? null : WorkflowExpression.Compile(mSWordSaveAsDocumentdocumentName);
            WorkflowExpression.Validate(__workflow_mSWordSaveAsDocumentdocumentName, nameof(mSWordSaveAsDocumentdocumentName), required: false);
            return new DeferredBodyAction<MSWordSaveAsDocumentResponse>(() =>
            {
                var apiCallPath = "/MSWord/SaveAs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSWordSaveAsDocument = new JObject();
                var mSWordSaveAsDocumentpropCount = 0;
                if (__workflow_mSWordSaveAsDocumenthandle != null)
                {
                    if (__workflow_mSWordSaveAsDocumenthandle != null)
                    {
                        mSWordSaveAsDocument["Handle"] = ExpressionConverter.ConvertO(__workflow_mSWordSaveAsDocumenthandle);
                        mSWordSaveAsDocumentpropCount++;
                    }

                    mSWordSaveAsDocumentpropCount++;
                }
                else
                {
                    mSWordSaveAsDocument["Handle"] = 0;
                    mSWordSaveAsDocumentpropCount++;
                }

                if (__workflow_mSWordSaveAsDocumentdocumentName != null)
                {
                    mSWordSaveAsDocument["DocumentName"] = ExpressionConverter.ConvertO(__workflow_mSWordSaveAsDocumentdocumentName);
                    mSWordSaveAsDocumentpropCount++;
                }

                mSWordSaveAsDocumentpropCount++;
                mSWordSaveAsDocument["SaveFilename"] = ExpressionConverter.ConvertO(__workflow_mSWordSaveAsDocumentsaveFilename);
                mSWordSaveAsDocumentpropCount++;
                mSWordSaveAsDocument["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSWordSaveAsDocumentworkflow);
                if (mSWordSaveAsDocumentpropCount > 0)
                {
                    callPayload.Body = mSWordSaveAsDocument;
                }

                return new ApiConnectionAction<MSWordSaveAsDocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordCloseDocument(Expression<Func<string>> mSWordCloseDocumentworkflow, Expression<Func<int>> mSWordCloseDocumenthandle = null, Expression<Func<string>> mSWordCloseDocumentdocumentName = null)
        {
            var __workflow_mSWordCloseDocumentworkflow = mSWordCloseDocumentworkflow == null ? null : WorkflowExpression.Compile(mSWordCloseDocumentworkflow);
            WorkflowExpression.Validate(__workflow_mSWordCloseDocumentworkflow, nameof(mSWordCloseDocumentworkflow), required: true);
            var __workflow_mSWordCloseDocumenthandle = mSWordCloseDocumenthandle == null ? null : WorkflowExpression.Compile(mSWordCloseDocumenthandle);
            WorkflowExpression.Validate(__workflow_mSWordCloseDocumenthandle, nameof(mSWordCloseDocumenthandle), required: false);
            var __workflow_mSWordCloseDocumentdocumentName = mSWordCloseDocumentdocumentName == null ? null : WorkflowExpression.Compile(mSWordCloseDocumentdocumentName);
            WorkflowExpression.Validate(__workflow_mSWordCloseDocumentdocumentName, nameof(mSWordCloseDocumentdocumentName), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/MSWord/CloseDocument";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSWordCloseDocument = new JObject();
                var mSWordCloseDocumentpropCount = 0;
                if (__workflow_mSWordCloseDocumenthandle != null)
                {
                    if (__workflow_mSWordCloseDocumenthandle != null)
                    {
                        mSWordCloseDocument["Handle"] = ExpressionConverter.ConvertO(__workflow_mSWordCloseDocumenthandle);
                        mSWordCloseDocumentpropCount++;
                    }

                    mSWordCloseDocumentpropCount++;
                }
                else
                {
                    mSWordCloseDocument["Handle"] = 0;
                    mSWordCloseDocumentpropCount++;
                }

                if (__workflow_mSWordCloseDocumentdocumentName != null)
                {
                    mSWordCloseDocument["DocumentName"] = ExpressionConverter.ConvertO(__workflow_mSWordCloseDocumentdocumentName);
                    mSWordCloseDocumentpropCount++;
                }

                mSWordCloseDocumentpropCount++;
                mSWordCloseDocument["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSWordCloseDocumentworkflow);
                if (mSWordCloseDocumentpropCount > 0)
                {
                    callPayload.Body = mSWordCloseDocument;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordTypeText(Expression<Func<string>> mSWordTypeTexttext, Expression<Func<string>> mSWordTypeTextworkflow, Expression<Func<int>> mSWordTypeTexthandle = null)
        {
            var __workflow_mSWordTypeTexttext = mSWordTypeTexttext == null ? null : WorkflowExpression.Compile(mSWordTypeTexttext);
            WorkflowExpression.Validate(__workflow_mSWordTypeTexttext, nameof(mSWordTypeTexttext), required: true);
            var __workflow_mSWordTypeTextworkflow = mSWordTypeTextworkflow == null ? null : WorkflowExpression.Compile(mSWordTypeTextworkflow);
            WorkflowExpression.Validate(__workflow_mSWordTypeTextworkflow, nameof(mSWordTypeTextworkflow), required: true);
            var __workflow_mSWordTypeTexthandle = mSWordTypeTexthandle == null ? null : WorkflowExpression.Compile(mSWordTypeTexthandle);
            WorkflowExpression.Validate(__workflow_mSWordTypeTexthandle, nameof(mSWordTypeTexthandle), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/MSWord/TypeText";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSWordTypeText = new JObject();
                var mSWordTypeTextpropCount = 0;
                if (__workflow_mSWordTypeTexthandle != null)
                {
                    if (__workflow_mSWordTypeTexthandle != null)
                    {
                        mSWordTypeText["Handle"] = ExpressionConverter.ConvertO(__workflow_mSWordTypeTexthandle);
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
                mSWordTypeText["Text"] = ExpressionConverter.ConvertO(__workflow_mSWordTypeTexttext);
                mSWordTypeTextpropCount++;
                mSWordTypeText["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSWordTypeTextworkflow);
                if (mSWordTypeTextpropCount > 0)
                {
                    callPayload.Body = mSWordTypeText;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordSelectAll(Expression<Func<string>> mSWordSelectAllworkflow, Expression<Func<int>> mSWordSelectAllhandle = null, Expression<Func<string>> mSWordSelectAlldocumentName = null)
        {
            var __workflow_mSWordSelectAllworkflow = mSWordSelectAllworkflow == null ? null : WorkflowExpression.Compile(mSWordSelectAllworkflow);
            WorkflowExpression.Validate(__workflow_mSWordSelectAllworkflow, nameof(mSWordSelectAllworkflow), required: true);
            var __workflow_mSWordSelectAllhandle = mSWordSelectAllhandle == null ? null : WorkflowExpression.Compile(mSWordSelectAllhandle);
            WorkflowExpression.Validate(__workflow_mSWordSelectAllhandle, nameof(mSWordSelectAllhandle), required: false);
            var __workflow_mSWordSelectAlldocumentName = mSWordSelectAlldocumentName == null ? null : WorkflowExpression.Compile(mSWordSelectAlldocumentName);
            WorkflowExpression.Validate(__workflow_mSWordSelectAlldocumentName, nameof(mSWordSelectAlldocumentName), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/MSWord/SelectAll";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSWordSelectAll = new JObject();
                var mSWordSelectAllpropCount = 0;
                if (__workflow_mSWordSelectAllhandle != null)
                {
                    if (__workflow_mSWordSelectAllhandle != null)
                    {
                        mSWordSelectAll["Handle"] = ExpressionConverter.ConvertO(__workflow_mSWordSelectAllhandle);
                        mSWordSelectAllpropCount++;
                    }

                    mSWordSelectAllpropCount++;
                }
                else
                {
                    mSWordSelectAll["Handle"] = 0;
                    mSWordSelectAllpropCount++;
                }

                if (__workflow_mSWordSelectAlldocumentName != null)
                {
                    mSWordSelectAll["DocumentName"] = ExpressionConverter.ConvertO(__workflow_mSWordSelectAlldocumentName);
                    mSWordSelectAllpropCount++;
                }

                mSWordSelectAllpropCount++;
                mSWordSelectAll["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSWordSelectAllworkflow);
                if (mSWordSelectAllpropCount > 0)
                {
                    callPayload.Body = mSWordSelectAll;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordSelectRange(Expression<Func<int>> mSWordSelectRangestart, Expression<Func<int>> mSWordSelectRangefinish, Expression<Func<string>> mSWordSelectRangeworkflow, Expression<Func<int>> mSWordSelectRangehandle = null, Expression<Func<string>> mSWordSelectRangedocumentName = null)
        {
            var __workflow_mSWordSelectRangestart = mSWordSelectRangestart == null ? null : WorkflowExpression.Compile(mSWordSelectRangestart);
            WorkflowExpression.Validate(__workflow_mSWordSelectRangestart, nameof(mSWordSelectRangestart), required: true);
            var __workflow_mSWordSelectRangefinish = mSWordSelectRangefinish == null ? null : WorkflowExpression.Compile(mSWordSelectRangefinish);
            WorkflowExpression.Validate(__workflow_mSWordSelectRangefinish, nameof(mSWordSelectRangefinish), required: true);
            var __workflow_mSWordSelectRangeworkflow = mSWordSelectRangeworkflow == null ? null : WorkflowExpression.Compile(mSWordSelectRangeworkflow);
            WorkflowExpression.Validate(__workflow_mSWordSelectRangeworkflow, nameof(mSWordSelectRangeworkflow), required: true);
            var __workflow_mSWordSelectRangehandle = mSWordSelectRangehandle == null ? null : WorkflowExpression.Compile(mSWordSelectRangehandle);
            WorkflowExpression.Validate(__workflow_mSWordSelectRangehandle, nameof(mSWordSelectRangehandle), required: false);
            var __workflow_mSWordSelectRangedocumentName = mSWordSelectRangedocumentName == null ? null : WorkflowExpression.Compile(mSWordSelectRangedocumentName);
            WorkflowExpression.Validate(__workflow_mSWordSelectRangedocumentName, nameof(mSWordSelectRangedocumentName), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/MSWord/SelectRange";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSWordSelectRange = new JObject();
                var mSWordSelectRangepropCount = 0;
                if (__workflow_mSWordSelectRangehandle != null)
                {
                    if (__workflow_mSWordSelectRangehandle != null)
                    {
                        mSWordSelectRange["Handle"] = ExpressionConverter.ConvertO(__workflow_mSWordSelectRangehandle);
                        mSWordSelectRangepropCount++;
                    }

                    mSWordSelectRangepropCount++;
                }
                else
                {
                    mSWordSelectRange["Handle"] = 0;
                    mSWordSelectRangepropCount++;
                }

                if (__workflow_mSWordSelectRangedocumentName != null)
                {
                    mSWordSelectRange["DocumentName"] = ExpressionConverter.ConvertO(__workflow_mSWordSelectRangedocumentName);
                    mSWordSelectRangepropCount++;
                }

                mSWordSelectRangepropCount++;
                mSWordSelectRange["Start"] = ExpressionConverter.ConvertO(__workflow_mSWordSelectRangestart);
                mSWordSelectRangepropCount++;
                mSWordSelectRange["Finish"] = ExpressionConverter.ConvertO(__workflow_mSWordSelectRangefinish);
                mSWordSelectRangepropCount++;
                mSWordSelectRange["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSWordSelectRangeworkflow);
                if (mSWordSelectRangepropCount > 0)
                {
                    callPayload.Body = mSWordSelectRange;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordCopyToClipboard(Expression<Func<string>> mSWordCopyToClipboardworkflow, Expression<Func<int>> mSWordCopyToClipboardhandle = null)
        {
            var __workflow_mSWordCopyToClipboardworkflow = mSWordCopyToClipboardworkflow == null ? null : WorkflowExpression.Compile(mSWordCopyToClipboardworkflow);
            WorkflowExpression.Validate(__workflow_mSWordCopyToClipboardworkflow, nameof(mSWordCopyToClipboardworkflow), required: true);
            var __workflow_mSWordCopyToClipboardhandle = mSWordCopyToClipboardhandle == null ? null : WorkflowExpression.Compile(mSWordCopyToClipboardhandle);
            WorkflowExpression.Validate(__workflow_mSWordCopyToClipboardhandle, nameof(mSWordCopyToClipboardhandle), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/MSWord/CopyToClipboard";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSWordCopyToClipboard = new JObject();
                var mSWordCopyToClipboardpropCount = 0;
                if (__workflow_mSWordCopyToClipboardhandle != null)
                {
                    if (__workflow_mSWordCopyToClipboardhandle != null)
                    {
                        mSWordCopyToClipboard["Handle"] = ExpressionConverter.ConvertO(__workflow_mSWordCopyToClipboardhandle);
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
                mSWordCopyToClipboard["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSWordCopyToClipboardworkflow);
                if (mSWordCopyToClipboardpropCount > 0)
                {
                    callPayload.Body = mSWordCopyToClipboard;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordPasteFromClipboard(Expression<Func<string>> mSWordPasteFromClipboardworkflow, Expression<Func<int>> mSWordPasteFromClipboardhandle = null)
        {
            var __workflow_mSWordPasteFromClipboardworkflow = mSWordPasteFromClipboardworkflow == null ? null : WorkflowExpression.Compile(mSWordPasteFromClipboardworkflow);
            WorkflowExpression.Validate(__workflow_mSWordPasteFromClipboardworkflow, nameof(mSWordPasteFromClipboardworkflow), required: true);
            var __workflow_mSWordPasteFromClipboardhandle = mSWordPasteFromClipboardhandle == null ? null : WorkflowExpression.Compile(mSWordPasteFromClipboardhandle);
            WorkflowExpression.Validate(__workflow_mSWordPasteFromClipboardhandle, nameof(mSWordPasteFromClipboardhandle), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/MSWord/PasteFromClipboard";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSWordPasteFromClipboard = new JObject();
                var mSWordPasteFromClipboardpropCount = 0;
                if (__workflow_mSWordPasteFromClipboardhandle != null)
                {
                    if (__workflow_mSWordPasteFromClipboardhandle != null)
                    {
                        mSWordPasteFromClipboard["Handle"] = ExpressionConverter.ConvertO(__workflow_mSWordPasteFromClipboardhandle);
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
                mSWordPasteFromClipboard["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSWordPasteFromClipboardworkflow);
                if (mSWordPasteFromClipboardpropCount > 0)
                {
                    callPayload.Body = mSWordPasteFromClipboard;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordClearClipboard(Expression<Func<string>> mSWordClearClipboardworkflow)
        {
            var __workflow_mSWordClearClipboardworkflow = mSWordClearClipboardworkflow == null ? null : WorkflowExpression.Compile(mSWordClearClipboardworkflow);
            WorkflowExpression.Validate(__workflow_mSWordClearClipboardworkflow, nameof(mSWordClearClipboardworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/MSWord/ClearClipboard";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSWordClearClipboard = new JObject();
                var mSWordClearClipboardpropCount = 0;
                mSWordClearClipboardpropCount++;
                mSWordClearClipboard["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSWordClearClipboardworkflow);
                if (mSWordClearClipboardpropCount > 0)
                {
                    callPayload.Body = mSWordClearClipboard;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordGetDocumentBodyTextResponse> MSWordGetDocumentBodyText(Expression<Func<int>> mSWordGetDocumentBodyTextstart, Expression<Func<int>> mSWordGetDocumentBodyTextfinish, Expression<Func<string>> mSWordGetDocumentBodyTextworkflow, Expression<Func<int>> mSWordGetDocumentBodyTexthandle = null, Expression<Func<string>> mSWordGetDocumentBodyTextdocumentName = null)
        {
            var __workflow_mSWordGetDocumentBodyTextstart = mSWordGetDocumentBodyTextstart == null ? null : WorkflowExpression.Compile(mSWordGetDocumentBodyTextstart);
            WorkflowExpression.Validate(__workflow_mSWordGetDocumentBodyTextstart, nameof(mSWordGetDocumentBodyTextstart), required: true);
            var __workflow_mSWordGetDocumentBodyTextfinish = mSWordGetDocumentBodyTextfinish == null ? null : WorkflowExpression.Compile(mSWordGetDocumentBodyTextfinish);
            WorkflowExpression.Validate(__workflow_mSWordGetDocumentBodyTextfinish, nameof(mSWordGetDocumentBodyTextfinish), required: true);
            var __workflow_mSWordGetDocumentBodyTextworkflow = mSWordGetDocumentBodyTextworkflow == null ? null : WorkflowExpression.Compile(mSWordGetDocumentBodyTextworkflow);
            WorkflowExpression.Validate(__workflow_mSWordGetDocumentBodyTextworkflow, nameof(mSWordGetDocumentBodyTextworkflow), required: true);
            var __workflow_mSWordGetDocumentBodyTexthandle = mSWordGetDocumentBodyTexthandle == null ? null : WorkflowExpression.Compile(mSWordGetDocumentBodyTexthandle);
            WorkflowExpression.Validate(__workflow_mSWordGetDocumentBodyTexthandle, nameof(mSWordGetDocumentBodyTexthandle), required: false);
            var __workflow_mSWordGetDocumentBodyTextdocumentName = mSWordGetDocumentBodyTextdocumentName == null ? null : WorkflowExpression.Compile(mSWordGetDocumentBodyTextdocumentName);
            WorkflowExpression.Validate(__workflow_mSWordGetDocumentBodyTextdocumentName, nameof(mSWordGetDocumentBodyTextdocumentName), required: false);
            return new DeferredBodyAction<MSWordGetDocumentBodyTextResponse>(() =>
            {
                var apiCallPath = "/MSWord/GetDocumentBodyText";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSWordGetDocumentBodyText = new JObject();
                var mSWordGetDocumentBodyTextpropCount = 0;
                if (__workflow_mSWordGetDocumentBodyTexthandle != null)
                {
                    if (__workflow_mSWordGetDocumentBodyTexthandle != null)
                    {
                        mSWordGetDocumentBodyText["Handle"] = ExpressionConverter.ConvertO(__workflow_mSWordGetDocumentBodyTexthandle);
                        mSWordGetDocumentBodyTextpropCount++;
                    }

                    mSWordGetDocumentBodyTextpropCount++;
                }
                else
                {
                    mSWordGetDocumentBodyText["Handle"] = 0;
                    mSWordGetDocumentBodyTextpropCount++;
                }

                if (__workflow_mSWordGetDocumentBodyTextdocumentName != null)
                {
                    mSWordGetDocumentBodyText["DocumentName"] = ExpressionConverter.ConvertO(__workflow_mSWordGetDocumentBodyTextdocumentName);
                    mSWordGetDocumentBodyTextpropCount++;
                }

                mSWordGetDocumentBodyTextpropCount++;
                mSWordGetDocumentBodyText["Start"] = ExpressionConverter.ConvertO(__workflow_mSWordGetDocumentBodyTextstart);
                mSWordGetDocumentBodyTextpropCount++;
                mSWordGetDocumentBodyText["Finish"] = ExpressionConverter.ConvertO(__workflow_mSWordGetDocumentBodyTextfinish);
                mSWordGetDocumentBodyTextpropCount++;
                mSWordGetDocumentBodyText["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSWordGetDocumentBodyTextworkflow);
                if (mSWordGetDocumentBodyTextpropCount > 0)
                {
                    callPayload.Body = mSWordGetDocumentBodyText;
                }

                return new ApiConnectionAction<MSWordGetDocumentBodyTextResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordGetNumberOfTablesInDocumentResponse> MSWordGetNumberOfTablesInDocument(Expression<Func<string>> mSWordGetNumberOfTablesInDocumentworkflow, Expression<Func<int>> mSWordGetNumberOfTablesInDocumenthandle = null, Expression<Func<string>> mSWordGetNumberOfTablesInDocumentdocumentName = null)
        {
            var __workflow_mSWordGetNumberOfTablesInDocumentworkflow = mSWordGetNumberOfTablesInDocumentworkflow == null ? null : WorkflowExpression.Compile(mSWordGetNumberOfTablesInDocumentworkflow);
            WorkflowExpression.Validate(__workflow_mSWordGetNumberOfTablesInDocumentworkflow, nameof(mSWordGetNumberOfTablesInDocumentworkflow), required: true);
            var __workflow_mSWordGetNumberOfTablesInDocumenthandle = mSWordGetNumberOfTablesInDocumenthandle == null ? null : WorkflowExpression.Compile(mSWordGetNumberOfTablesInDocumenthandle);
            WorkflowExpression.Validate(__workflow_mSWordGetNumberOfTablesInDocumenthandle, nameof(mSWordGetNumberOfTablesInDocumenthandle), required: false);
            var __workflow_mSWordGetNumberOfTablesInDocumentdocumentName = mSWordGetNumberOfTablesInDocumentdocumentName == null ? null : WorkflowExpression.Compile(mSWordGetNumberOfTablesInDocumentdocumentName);
            WorkflowExpression.Validate(__workflow_mSWordGetNumberOfTablesInDocumentdocumentName, nameof(mSWordGetNumberOfTablesInDocumentdocumentName), required: false);
            return new DeferredBodyAction<MSWordGetNumberOfTablesInDocumentResponse>(() =>
            {
                var apiCallPath = "/MSWord/GetNumberOfTablesInDocument";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSWordGetNumberOfTablesInDocument = new JObject();
                var mSWordGetNumberOfTablesInDocumentpropCount = 0;
                if (__workflow_mSWordGetNumberOfTablesInDocumenthandle != null)
                {
                    if (__workflow_mSWordGetNumberOfTablesInDocumenthandle != null)
                    {
                        mSWordGetNumberOfTablesInDocument["Handle"] = ExpressionConverter.ConvertO(__workflow_mSWordGetNumberOfTablesInDocumenthandle);
                        mSWordGetNumberOfTablesInDocumentpropCount++;
                    }

                    mSWordGetNumberOfTablesInDocumentpropCount++;
                }
                else
                {
                    mSWordGetNumberOfTablesInDocument["Handle"] = 0;
                    mSWordGetNumberOfTablesInDocumentpropCount++;
                }

                if (__workflow_mSWordGetNumberOfTablesInDocumentdocumentName != null)
                {
                    mSWordGetNumberOfTablesInDocument["DocumentName"] = ExpressionConverter.ConvertO(__workflow_mSWordGetNumberOfTablesInDocumentdocumentName);
                    mSWordGetNumberOfTablesInDocumentpropCount++;
                }

                mSWordGetNumberOfTablesInDocumentpropCount++;
                mSWordGetNumberOfTablesInDocument["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSWordGetNumberOfTablesInDocumentworkflow);
                if (mSWordGetNumberOfTablesInDocumentpropCount > 0)
                {
                    callPayload.Body = mSWordGetNumberOfTablesInDocument;
                }

                return new ApiConnectionAction<MSWordGetNumberOfTablesInDocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordUpdateBookmark(Expression<Func<string>> mSWordUpdateBookmarkbookmarkName, Expression<Func<string>> mSWordUpdateBookmarkworkflow, Expression<Func<int>> mSWordUpdateBookmarkhandle = null, Expression<Func<string>> mSWordUpdateBookmarkdocumentName = null, Expression<Func<string>> mSWordUpdateBookmarknewValue = null)
        {
            var __workflow_mSWordUpdateBookmarkbookmarkName = mSWordUpdateBookmarkbookmarkName == null ? null : WorkflowExpression.Compile(mSWordUpdateBookmarkbookmarkName);
            WorkflowExpression.Validate(__workflow_mSWordUpdateBookmarkbookmarkName, nameof(mSWordUpdateBookmarkbookmarkName), required: true);
            var __workflow_mSWordUpdateBookmarkworkflow = mSWordUpdateBookmarkworkflow == null ? null : WorkflowExpression.Compile(mSWordUpdateBookmarkworkflow);
            WorkflowExpression.Validate(__workflow_mSWordUpdateBookmarkworkflow, nameof(mSWordUpdateBookmarkworkflow), required: true);
            var __workflow_mSWordUpdateBookmarkhandle = mSWordUpdateBookmarkhandle == null ? null : WorkflowExpression.Compile(mSWordUpdateBookmarkhandle);
            WorkflowExpression.Validate(__workflow_mSWordUpdateBookmarkhandle, nameof(mSWordUpdateBookmarkhandle), required: false);
            var __workflow_mSWordUpdateBookmarkdocumentName = mSWordUpdateBookmarkdocumentName == null ? null : WorkflowExpression.Compile(mSWordUpdateBookmarkdocumentName);
            WorkflowExpression.Validate(__workflow_mSWordUpdateBookmarkdocumentName, nameof(mSWordUpdateBookmarkdocumentName), required: false);
            var __workflow_mSWordUpdateBookmarknewValue = mSWordUpdateBookmarknewValue == null ? null : WorkflowExpression.Compile(mSWordUpdateBookmarknewValue);
            WorkflowExpression.Validate(__workflow_mSWordUpdateBookmarknewValue, nameof(mSWordUpdateBookmarknewValue), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/MSWord/UpdateBookmark";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSWordUpdateBookmark = new JObject();
                var mSWordUpdateBookmarkpropCount = 0;
                if (__workflow_mSWordUpdateBookmarkhandle != null)
                {
                    if (__workflow_mSWordUpdateBookmarkhandle != null)
                    {
                        mSWordUpdateBookmark["Handle"] = ExpressionConverter.ConvertO(__workflow_mSWordUpdateBookmarkhandle);
                        mSWordUpdateBookmarkpropCount++;
                    }

                    mSWordUpdateBookmarkpropCount++;
                }
                else
                {
                    mSWordUpdateBookmark["Handle"] = 0;
                    mSWordUpdateBookmarkpropCount++;
                }

                if (__workflow_mSWordUpdateBookmarkdocumentName != null)
                {
                    mSWordUpdateBookmark["DocumentName"] = ExpressionConverter.ConvertO(__workflow_mSWordUpdateBookmarkdocumentName);
                    mSWordUpdateBookmarkpropCount++;
                }

                mSWordUpdateBookmarkpropCount++;
                mSWordUpdateBookmark["BookmarkName"] = ExpressionConverter.ConvertO(__workflow_mSWordUpdateBookmarkbookmarkName);
                if (__workflow_mSWordUpdateBookmarknewValue != null)
                {
                    mSWordUpdateBookmark["NewValue"] = ExpressionConverter.ConvertO(__workflow_mSWordUpdateBookmarknewValue);
                    mSWordUpdateBookmarkpropCount++;
                }

                mSWordUpdateBookmarkpropCount++;
                mSWordUpdateBookmark["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSWordUpdateBookmarkworkflow);
                if (mSWordUpdateBookmarkpropCount > 0)
                {
                    callPayload.Body = mSWordUpdateBookmark;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordSelectTable(Expression<Func<int>> mSWordSelectTabletableIndex, Expression<Func<string>> mSWordSelectTableworkflow, Expression<Func<int>> mSWordSelectTablehandle = null, Expression<Func<string>> mSWordSelectTabledocumentName = null)
        {
            var __workflow_mSWordSelectTabletableIndex = mSWordSelectTabletableIndex == null ? null : WorkflowExpression.Compile(mSWordSelectTabletableIndex);
            WorkflowExpression.Validate(__workflow_mSWordSelectTabletableIndex, nameof(mSWordSelectTabletableIndex), required: true);
            var __workflow_mSWordSelectTableworkflow = mSWordSelectTableworkflow == null ? null : WorkflowExpression.Compile(mSWordSelectTableworkflow);
            WorkflowExpression.Validate(__workflow_mSWordSelectTableworkflow, nameof(mSWordSelectTableworkflow), required: true);
            var __workflow_mSWordSelectTablehandle = mSWordSelectTablehandle == null ? null : WorkflowExpression.Compile(mSWordSelectTablehandle);
            WorkflowExpression.Validate(__workflow_mSWordSelectTablehandle, nameof(mSWordSelectTablehandle), required: false);
            var __workflow_mSWordSelectTabledocumentName = mSWordSelectTabledocumentName == null ? null : WorkflowExpression.Compile(mSWordSelectTabledocumentName);
            WorkflowExpression.Validate(__workflow_mSWordSelectTabledocumentName, nameof(mSWordSelectTabledocumentName), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/MSWord/SelectTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSWordSelectTable = new JObject();
                var mSWordSelectTablepropCount = 0;
                if (__workflow_mSWordSelectTablehandle != null)
                {
                    if (__workflow_mSWordSelectTablehandle != null)
                    {
                        mSWordSelectTable["Handle"] = ExpressionConverter.ConvertO(__workflow_mSWordSelectTablehandle);
                        mSWordSelectTablepropCount++;
                    }

                    mSWordSelectTablepropCount++;
                }
                else
                {
                    mSWordSelectTable["Handle"] = 0;
                    mSWordSelectTablepropCount++;
                }

                if (__workflow_mSWordSelectTabledocumentName != null)
                {
                    mSWordSelectTable["DocumentName"] = ExpressionConverter.ConvertO(__workflow_mSWordSelectTabledocumentName);
                    mSWordSelectTablepropCount++;
                }

                mSWordSelectTablepropCount++;
                mSWordSelectTable["TableIndex"] = ExpressionConverter.ConvertO(__workflow_mSWordSelectTabletableIndex);
                mSWordSelectTablepropCount++;
                mSWordSelectTable["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSWordSelectTableworkflow);
                if (mSWordSelectTablepropCount > 0)
                {
                    callPayload.Body = mSWordSelectTable;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordGetTableBoundsResponse> MSWordGetTableBounds(Expression<Func<int>> mSWordGetTableBoundstableIndex, Expression<Func<string>> mSWordGetTableBoundsworkflow, Expression<Func<int>> mSWordGetTableBoundshandle = null, Expression<Func<string>> mSWordGetTableBoundsdocumentName = null)
        {
            var __workflow_mSWordGetTableBoundstableIndex = mSWordGetTableBoundstableIndex == null ? null : WorkflowExpression.Compile(mSWordGetTableBoundstableIndex);
            WorkflowExpression.Validate(__workflow_mSWordGetTableBoundstableIndex, nameof(mSWordGetTableBoundstableIndex), required: true);
            var __workflow_mSWordGetTableBoundsworkflow = mSWordGetTableBoundsworkflow == null ? null : WorkflowExpression.Compile(mSWordGetTableBoundsworkflow);
            WorkflowExpression.Validate(__workflow_mSWordGetTableBoundsworkflow, nameof(mSWordGetTableBoundsworkflow), required: true);
            var __workflow_mSWordGetTableBoundshandle = mSWordGetTableBoundshandle == null ? null : WorkflowExpression.Compile(mSWordGetTableBoundshandle);
            WorkflowExpression.Validate(__workflow_mSWordGetTableBoundshandle, nameof(mSWordGetTableBoundshandle), required: false);
            var __workflow_mSWordGetTableBoundsdocumentName = mSWordGetTableBoundsdocumentName == null ? null : WorkflowExpression.Compile(mSWordGetTableBoundsdocumentName);
            WorkflowExpression.Validate(__workflow_mSWordGetTableBoundsdocumentName, nameof(mSWordGetTableBoundsdocumentName), required: false);
            return new DeferredBodyAction<MSWordGetTableBoundsResponse>(() =>
            {
                var apiCallPath = "/MSWord/GetTableBounds";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSWordGetTableBounds = new JObject();
                var mSWordGetTableBoundspropCount = 0;
                if (__workflow_mSWordGetTableBoundshandle != null)
                {
                    if (__workflow_mSWordGetTableBoundshandle != null)
                    {
                        mSWordGetTableBounds["Handle"] = ExpressionConverter.ConvertO(__workflow_mSWordGetTableBoundshandle);
                        mSWordGetTableBoundspropCount++;
                    }

                    mSWordGetTableBoundspropCount++;
                }
                else
                {
                    mSWordGetTableBounds["Handle"] = 0;
                    mSWordGetTableBoundspropCount++;
                }

                if (__workflow_mSWordGetTableBoundsdocumentName != null)
                {
                    mSWordGetTableBounds["DocumentName"] = ExpressionConverter.ConvertO(__workflow_mSWordGetTableBoundsdocumentName);
                    mSWordGetTableBoundspropCount++;
                }

                mSWordGetTableBoundspropCount++;
                mSWordGetTableBounds["TableIndex"] = ExpressionConverter.ConvertO(__workflow_mSWordGetTableBoundstableIndex);
                mSWordGetTableBoundspropCount++;
                mSWordGetTableBounds["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSWordGetTableBoundsworkflow);
                if (mSWordGetTableBoundspropCount > 0)
                {
                    callPayload.Body = mSWordGetTableBounds;
                }

                return new ApiConnectionAction<MSWordGetTableBoundsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordSelectTableCell(Expression<Func<int>> mSWordSelectTableCelltableIndex, Expression<Func<int>> mSWordSelectTableCellrowIndex, Expression<Func<int>> mSWordSelectTableCellcolumnIndex, Expression<Func<string>> mSWordSelectTableCellworkflow, Expression<Func<int>> mSWordSelectTableCellhandle = null, Expression<Func<string>> mSWordSelectTableCelldocumentName = null)
        {
            var __workflow_mSWordSelectTableCelltableIndex = mSWordSelectTableCelltableIndex == null ? null : WorkflowExpression.Compile(mSWordSelectTableCelltableIndex);
            WorkflowExpression.Validate(__workflow_mSWordSelectTableCelltableIndex, nameof(mSWordSelectTableCelltableIndex), required: true);
            var __workflow_mSWordSelectTableCellrowIndex = mSWordSelectTableCellrowIndex == null ? null : WorkflowExpression.Compile(mSWordSelectTableCellrowIndex);
            WorkflowExpression.Validate(__workflow_mSWordSelectTableCellrowIndex, nameof(mSWordSelectTableCellrowIndex), required: true);
            var __workflow_mSWordSelectTableCellcolumnIndex = mSWordSelectTableCellcolumnIndex == null ? null : WorkflowExpression.Compile(mSWordSelectTableCellcolumnIndex);
            WorkflowExpression.Validate(__workflow_mSWordSelectTableCellcolumnIndex, nameof(mSWordSelectTableCellcolumnIndex), required: true);
            var __workflow_mSWordSelectTableCellworkflow = mSWordSelectTableCellworkflow == null ? null : WorkflowExpression.Compile(mSWordSelectTableCellworkflow);
            WorkflowExpression.Validate(__workflow_mSWordSelectTableCellworkflow, nameof(mSWordSelectTableCellworkflow), required: true);
            var __workflow_mSWordSelectTableCellhandle = mSWordSelectTableCellhandle == null ? null : WorkflowExpression.Compile(mSWordSelectTableCellhandle);
            WorkflowExpression.Validate(__workflow_mSWordSelectTableCellhandle, nameof(mSWordSelectTableCellhandle), required: false);
            var __workflow_mSWordSelectTableCelldocumentName = mSWordSelectTableCelldocumentName == null ? null : WorkflowExpression.Compile(mSWordSelectTableCelldocumentName);
            WorkflowExpression.Validate(__workflow_mSWordSelectTableCelldocumentName, nameof(mSWordSelectTableCelldocumentName), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/MSWord/SelectTableCell";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSWordSelectTableCell = new JObject();
                var mSWordSelectTableCellpropCount = 0;
                if (__workflow_mSWordSelectTableCellhandle != null)
                {
                    if (__workflow_mSWordSelectTableCellhandle != null)
                    {
                        mSWordSelectTableCell["Handle"] = ExpressionConverter.ConvertO(__workflow_mSWordSelectTableCellhandle);
                        mSWordSelectTableCellpropCount++;
                    }

                    mSWordSelectTableCellpropCount++;
                }
                else
                {
                    mSWordSelectTableCell["Handle"] = 0;
                    mSWordSelectTableCellpropCount++;
                }

                if (__workflow_mSWordSelectTableCelldocumentName != null)
                {
                    mSWordSelectTableCell["DocumentName"] = ExpressionConverter.ConvertO(__workflow_mSWordSelectTableCelldocumentName);
                    mSWordSelectTableCellpropCount++;
                }

                mSWordSelectTableCellpropCount++;
                mSWordSelectTableCell["TableIndex"] = ExpressionConverter.ConvertO(__workflow_mSWordSelectTableCelltableIndex);
                mSWordSelectTableCellpropCount++;
                mSWordSelectTableCell["RowIndex"] = ExpressionConverter.ConvertO(__workflow_mSWordSelectTableCellrowIndex);
                mSWordSelectTableCellpropCount++;
                mSWordSelectTableCell["ColumnIndex"] = ExpressionConverter.ConvertO(__workflow_mSWordSelectTableCellcolumnIndex);
                mSWordSelectTableCellpropCount++;
                mSWordSelectTableCell["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSWordSelectTableCellworkflow);
                if (mSWordSelectTableCellpropCount > 0)
                {
                    callPayload.Body = mSWordSelectTableCell;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordGetTableCellTextValueResponse> MSWordGetTableCellTextValue(Expression<Func<int>> mSWordGetTableCellTextValuetableIndex, Expression<Func<int>> mSWordGetTableCellTextValuerowIndex, Expression<Func<int>> mSWordGetTableCellTextValuecolumnIndex, Expression<Func<string>> mSWordGetTableCellTextValueworkflow, Expression<Func<int>> mSWordGetTableCellTextValuehandle = null, Expression<Func<string>> mSWordGetTableCellTextValuedocumentName = null)
        {
            var __workflow_mSWordGetTableCellTextValuetableIndex = mSWordGetTableCellTextValuetableIndex == null ? null : WorkflowExpression.Compile(mSWordGetTableCellTextValuetableIndex);
            WorkflowExpression.Validate(__workflow_mSWordGetTableCellTextValuetableIndex, nameof(mSWordGetTableCellTextValuetableIndex), required: true);
            var __workflow_mSWordGetTableCellTextValuerowIndex = mSWordGetTableCellTextValuerowIndex == null ? null : WorkflowExpression.Compile(mSWordGetTableCellTextValuerowIndex);
            WorkflowExpression.Validate(__workflow_mSWordGetTableCellTextValuerowIndex, nameof(mSWordGetTableCellTextValuerowIndex), required: true);
            var __workflow_mSWordGetTableCellTextValuecolumnIndex = mSWordGetTableCellTextValuecolumnIndex == null ? null : WorkflowExpression.Compile(mSWordGetTableCellTextValuecolumnIndex);
            WorkflowExpression.Validate(__workflow_mSWordGetTableCellTextValuecolumnIndex, nameof(mSWordGetTableCellTextValuecolumnIndex), required: true);
            var __workflow_mSWordGetTableCellTextValueworkflow = mSWordGetTableCellTextValueworkflow == null ? null : WorkflowExpression.Compile(mSWordGetTableCellTextValueworkflow);
            WorkflowExpression.Validate(__workflow_mSWordGetTableCellTextValueworkflow, nameof(mSWordGetTableCellTextValueworkflow), required: true);
            var __workflow_mSWordGetTableCellTextValuehandle = mSWordGetTableCellTextValuehandle == null ? null : WorkflowExpression.Compile(mSWordGetTableCellTextValuehandle);
            WorkflowExpression.Validate(__workflow_mSWordGetTableCellTextValuehandle, nameof(mSWordGetTableCellTextValuehandle), required: false);
            var __workflow_mSWordGetTableCellTextValuedocumentName = mSWordGetTableCellTextValuedocumentName == null ? null : WorkflowExpression.Compile(mSWordGetTableCellTextValuedocumentName);
            WorkflowExpression.Validate(__workflow_mSWordGetTableCellTextValuedocumentName, nameof(mSWordGetTableCellTextValuedocumentName), required: false);
            return new DeferredBodyAction<MSWordGetTableCellTextValueResponse>(() =>
            {
                var apiCallPath = "/MSWord/GetTableCellTextValue";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSWordGetTableCellTextValue = new JObject();
                var mSWordGetTableCellTextValuepropCount = 0;
                if (__workflow_mSWordGetTableCellTextValuehandle != null)
                {
                    if (__workflow_mSWordGetTableCellTextValuehandle != null)
                    {
                        mSWordGetTableCellTextValue["Handle"] = ExpressionConverter.ConvertO(__workflow_mSWordGetTableCellTextValuehandle);
                        mSWordGetTableCellTextValuepropCount++;
                    }

                    mSWordGetTableCellTextValuepropCount++;
                }
                else
                {
                    mSWordGetTableCellTextValue["Handle"] = 0;
                    mSWordGetTableCellTextValuepropCount++;
                }

                if (__workflow_mSWordGetTableCellTextValuedocumentName != null)
                {
                    mSWordGetTableCellTextValue["DocumentName"] = ExpressionConverter.ConvertO(__workflow_mSWordGetTableCellTextValuedocumentName);
                    mSWordGetTableCellTextValuepropCount++;
                }

                mSWordGetTableCellTextValuepropCount++;
                mSWordGetTableCellTextValue["TableIndex"] = ExpressionConverter.ConvertO(__workflow_mSWordGetTableCellTextValuetableIndex);
                mSWordGetTableCellTextValuepropCount++;
                mSWordGetTableCellTextValue["RowIndex"] = ExpressionConverter.ConvertO(__workflow_mSWordGetTableCellTextValuerowIndex);
                mSWordGetTableCellTextValuepropCount++;
                mSWordGetTableCellTextValue["ColumnIndex"] = ExpressionConverter.ConvertO(__workflow_mSWordGetTableCellTextValuecolumnIndex);
                mSWordGetTableCellTextValuepropCount++;
                mSWordGetTableCellTextValue["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSWordGetTableCellTextValueworkflow);
                if (mSWordGetTableCellTextValuepropCount > 0)
                {
                    callPayload.Body = mSWordGetTableCellTextValue;
                }

                return new ApiConnectionAction<MSWordGetTableCellTextValueResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordGetTableCellTextValueTrimmedResponse> MSWordGetTableCellTextValueTrimmed(Expression<Func<int>> mSWordGetTableCellTextValueTrimmedtableIndex, Expression<Func<int>> mSWordGetTableCellTextValueTrimmedrowIndex, Expression<Func<int>> mSWordGetTableCellTextValueTrimmedcolumnIndex, Expression<Func<string>> mSWordGetTableCellTextValueTrimmedworkflow, Expression<Func<int>> mSWordGetTableCellTextValueTrimmedhandle = null, Expression<Func<string>> mSWordGetTableCellTextValueTrimmeddocumentName = null)
        {
            var __workflow_mSWordGetTableCellTextValueTrimmedtableIndex = mSWordGetTableCellTextValueTrimmedtableIndex == null ? null : WorkflowExpression.Compile(mSWordGetTableCellTextValueTrimmedtableIndex);
            WorkflowExpression.Validate(__workflow_mSWordGetTableCellTextValueTrimmedtableIndex, nameof(mSWordGetTableCellTextValueTrimmedtableIndex), required: true);
            var __workflow_mSWordGetTableCellTextValueTrimmedrowIndex = mSWordGetTableCellTextValueTrimmedrowIndex == null ? null : WorkflowExpression.Compile(mSWordGetTableCellTextValueTrimmedrowIndex);
            WorkflowExpression.Validate(__workflow_mSWordGetTableCellTextValueTrimmedrowIndex, nameof(mSWordGetTableCellTextValueTrimmedrowIndex), required: true);
            var __workflow_mSWordGetTableCellTextValueTrimmedcolumnIndex = mSWordGetTableCellTextValueTrimmedcolumnIndex == null ? null : WorkflowExpression.Compile(mSWordGetTableCellTextValueTrimmedcolumnIndex);
            WorkflowExpression.Validate(__workflow_mSWordGetTableCellTextValueTrimmedcolumnIndex, nameof(mSWordGetTableCellTextValueTrimmedcolumnIndex), required: true);
            var __workflow_mSWordGetTableCellTextValueTrimmedworkflow = mSWordGetTableCellTextValueTrimmedworkflow == null ? null : WorkflowExpression.Compile(mSWordGetTableCellTextValueTrimmedworkflow);
            WorkflowExpression.Validate(__workflow_mSWordGetTableCellTextValueTrimmedworkflow, nameof(mSWordGetTableCellTextValueTrimmedworkflow), required: true);
            var __workflow_mSWordGetTableCellTextValueTrimmedhandle = mSWordGetTableCellTextValueTrimmedhandle == null ? null : WorkflowExpression.Compile(mSWordGetTableCellTextValueTrimmedhandle);
            WorkflowExpression.Validate(__workflow_mSWordGetTableCellTextValueTrimmedhandle, nameof(mSWordGetTableCellTextValueTrimmedhandle), required: false);
            var __workflow_mSWordGetTableCellTextValueTrimmeddocumentName = mSWordGetTableCellTextValueTrimmeddocumentName == null ? null : WorkflowExpression.Compile(mSWordGetTableCellTextValueTrimmeddocumentName);
            WorkflowExpression.Validate(__workflow_mSWordGetTableCellTextValueTrimmeddocumentName, nameof(mSWordGetTableCellTextValueTrimmeddocumentName), required: false);
            return new DeferredBodyAction<MSWordGetTableCellTextValueTrimmedResponse>(() =>
            {
                var apiCallPath = "/MSWord/GetTableCellTextValueTrimmed";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSWordGetTableCellTextValueTrimmed = new JObject();
                var mSWordGetTableCellTextValueTrimmedpropCount = 0;
                if (__workflow_mSWordGetTableCellTextValueTrimmedhandle != null)
                {
                    if (__workflow_mSWordGetTableCellTextValueTrimmedhandle != null)
                    {
                        mSWordGetTableCellTextValueTrimmed["Handle"] = ExpressionConverter.ConvertO(__workflow_mSWordGetTableCellTextValueTrimmedhandle);
                        mSWordGetTableCellTextValueTrimmedpropCount++;
                    }

                    mSWordGetTableCellTextValueTrimmedpropCount++;
                }
                else
                {
                    mSWordGetTableCellTextValueTrimmed["Handle"] = 0;
                    mSWordGetTableCellTextValueTrimmedpropCount++;
                }

                if (__workflow_mSWordGetTableCellTextValueTrimmeddocumentName != null)
                {
                    mSWordGetTableCellTextValueTrimmed["DocumentName"] = ExpressionConverter.ConvertO(__workflow_mSWordGetTableCellTextValueTrimmeddocumentName);
                    mSWordGetTableCellTextValueTrimmedpropCount++;
                }

                mSWordGetTableCellTextValueTrimmedpropCount++;
                mSWordGetTableCellTextValueTrimmed["TableIndex"] = ExpressionConverter.ConvertO(__workflow_mSWordGetTableCellTextValueTrimmedtableIndex);
                mSWordGetTableCellTextValueTrimmedpropCount++;
                mSWordGetTableCellTextValueTrimmed["RowIndex"] = ExpressionConverter.ConvertO(__workflow_mSWordGetTableCellTextValueTrimmedrowIndex);
                mSWordGetTableCellTextValueTrimmedpropCount++;
                mSWordGetTableCellTextValueTrimmed["ColumnIndex"] = ExpressionConverter.ConvertO(__workflow_mSWordGetTableCellTextValueTrimmedcolumnIndex);
                mSWordGetTableCellTextValueTrimmedpropCount++;
                mSWordGetTableCellTextValueTrimmed["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSWordGetTableCellTextValueTrimmedworkflow);
                if (mSWordGetTableCellTextValueTrimmedpropCount > 0)
                {
                    callPayload.Body = mSWordGetTableCellTextValueTrimmed;
                }

                return new ApiConnectionAction<MSWordGetTableCellTextValueTrimmedResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordSetTableCellTextValue(Expression<Func<int>> mSWordSetTableCellTextValuetableIndex, Expression<Func<int>> mSWordSetTableCellTextValuerowIndex, Expression<Func<int>> mSWordSetTableCellTextValuecolumnIndex, Expression<Func<string>> mSWordSetTableCellTextValueworkflow, Expression<Func<int>> mSWordSetTableCellTextValuehandle = null, Expression<Func<string>> mSWordSetTableCellTextValuedocumentName = null, Expression<Func<string>> mSWordSetTableCellTextValuenewCellText = null)
        {
            var __workflow_mSWordSetTableCellTextValuetableIndex = mSWordSetTableCellTextValuetableIndex == null ? null : WorkflowExpression.Compile(mSWordSetTableCellTextValuetableIndex);
            WorkflowExpression.Validate(__workflow_mSWordSetTableCellTextValuetableIndex, nameof(mSWordSetTableCellTextValuetableIndex), required: true);
            var __workflow_mSWordSetTableCellTextValuerowIndex = mSWordSetTableCellTextValuerowIndex == null ? null : WorkflowExpression.Compile(mSWordSetTableCellTextValuerowIndex);
            WorkflowExpression.Validate(__workflow_mSWordSetTableCellTextValuerowIndex, nameof(mSWordSetTableCellTextValuerowIndex), required: true);
            var __workflow_mSWordSetTableCellTextValuecolumnIndex = mSWordSetTableCellTextValuecolumnIndex == null ? null : WorkflowExpression.Compile(mSWordSetTableCellTextValuecolumnIndex);
            WorkflowExpression.Validate(__workflow_mSWordSetTableCellTextValuecolumnIndex, nameof(mSWordSetTableCellTextValuecolumnIndex), required: true);
            var __workflow_mSWordSetTableCellTextValueworkflow = mSWordSetTableCellTextValueworkflow == null ? null : WorkflowExpression.Compile(mSWordSetTableCellTextValueworkflow);
            WorkflowExpression.Validate(__workflow_mSWordSetTableCellTextValueworkflow, nameof(mSWordSetTableCellTextValueworkflow), required: true);
            var __workflow_mSWordSetTableCellTextValuehandle = mSWordSetTableCellTextValuehandle == null ? null : WorkflowExpression.Compile(mSWordSetTableCellTextValuehandle);
            WorkflowExpression.Validate(__workflow_mSWordSetTableCellTextValuehandle, nameof(mSWordSetTableCellTextValuehandle), required: false);
            var __workflow_mSWordSetTableCellTextValuedocumentName = mSWordSetTableCellTextValuedocumentName == null ? null : WorkflowExpression.Compile(mSWordSetTableCellTextValuedocumentName);
            WorkflowExpression.Validate(__workflow_mSWordSetTableCellTextValuedocumentName, nameof(mSWordSetTableCellTextValuedocumentName), required: false);
            var __workflow_mSWordSetTableCellTextValuenewCellText = mSWordSetTableCellTextValuenewCellText == null ? null : WorkflowExpression.Compile(mSWordSetTableCellTextValuenewCellText);
            WorkflowExpression.Validate(__workflow_mSWordSetTableCellTextValuenewCellText, nameof(mSWordSetTableCellTextValuenewCellText), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/MSWord/SetTableCellTextValue";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSWordSetTableCellTextValue = new JObject();
                var mSWordSetTableCellTextValuepropCount = 0;
                if (__workflow_mSWordSetTableCellTextValuehandle != null)
                {
                    if (__workflow_mSWordSetTableCellTextValuehandle != null)
                    {
                        mSWordSetTableCellTextValue["Handle"] = ExpressionConverter.ConvertO(__workflow_mSWordSetTableCellTextValuehandle);
                        mSWordSetTableCellTextValuepropCount++;
                    }

                    mSWordSetTableCellTextValuepropCount++;
                }
                else
                {
                    mSWordSetTableCellTextValue["Handle"] = 0;
                    mSWordSetTableCellTextValuepropCount++;
                }

                if (__workflow_mSWordSetTableCellTextValuedocumentName != null)
                {
                    mSWordSetTableCellTextValue["DocumentName"] = ExpressionConverter.ConvertO(__workflow_mSWordSetTableCellTextValuedocumentName);
                    mSWordSetTableCellTextValuepropCount++;
                }

                mSWordSetTableCellTextValuepropCount++;
                mSWordSetTableCellTextValue["TableIndex"] = ExpressionConverter.ConvertO(__workflow_mSWordSetTableCellTextValuetableIndex);
                mSWordSetTableCellTextValuepropCount++;
                mSWordSetTableCellTextValue["RowIndex"] = ExpressionConverter.ConvertO(__workflow_mSWordSetTableCellTextValuerowIndex);
                mSWordSetTableCellTextValuepropCount++;
                mSWordSetTableCellTextValue["ColumnIndex"] = ExpressionConverter.ConvertO(__workflow_mSWordSetTableCellTextValuecolumnIndex);
                if (__workflow_mSWordSetTableCellTextValuenewCellText != null)
                {
                    mSWordSetTableCellTextValue["NewCellText"] = ExpressionConverter.ConvertO(__workflow_mSWordSetTableCellTextValuenewCellText);
                    mSWordSetTableCellTextValuepropCount++;
                }

                mSWordSetTableCellTextValuepropCount++;
                mSWordSetTableCellTextValue["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSWordSetTableCellTextValueworkflow);
                if (mSWordSetTableCellTextValuepropCount > 0)
                {
                    callPayload.Body = mSWordSetTableCellTextValue;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordExportDocumentAsPDF(Expression<Func<string>> mSWordExportDocumentAsPDFsaveFileName, Expression<Func<string>> mSWordExportDocumentAsPDFworkflow, Expression<Func<int>> mSWordExportDocumentAsPDFhandle = null, Expression<Func<string>> mSWordExportDocumentAsPDFdocumentName = null)
        {
            var __workflow_mSWordExportDocumentAsPDFsaveFileName = mSWordExportDocumentAsPDFsaveFileName == null ? null : WorkflowExpression.Compile(mSWordExportDocumentAsPDFsaveFileName);
            WorkflowExpression.Validate(__workflow_mSWordExportDocumentAsPDFsaveFileName, nameof(mSWordExportDocumentAsPDFsaveFileName), required: true);
            var __workflow_mSWordExportDocumentAsPDFworkflow = mSWordExportDocumentAsPDFworkflow == null ? null : WorkflowExpression.Compile(mSWordExportDocumentAsPDFworkflow);
            WorkflowExpression.Validate(__workflow_mSWordExportDocumentAsPDFworkflow, nameof(mSWordExportDocumentAsPDFworkflow), required: true);
            var __workflow_mSWordExportDocumentAsPDFhandle = mSWordExportDocumentAsPDFhandle == null ? null : WorkflowExpression.Compile(mSWordExportDocumentAsPDFhandle);
            WorkflowExpression.Validate(__workflow_mSWordExportDocumentAsPDFhandle, nameof(mSWordExportDocumentAsPDFhandle), required: false);
            var __workflow_mSWordExportDocumentAsPDFdocumentName = mSWordExportDocumentAsPDFdocumentName == null ? null : WorkflowExpression.Compile(mSWordExportDocumentAsPDFdocumentName);
            WorkflowExpression.Validate(__workflow_mSWordExportDocumentAsPDFdocumentName, nameof(mSWordExportDocumentAsPDFdocumentName), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/MSWord/ExportDocumentAsPDF";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSWordExportDocumentAsPDF = new JObject();
                var mSWordExportDocumentAsPDFpropCount = 0;
                if (__workflow_mSWordExportDocumentAsPDFhandle != null)
                {
                    if (__workflow_mSWordExportDocumentAsPDFhandle != null)
                    {
                        mSWordExportDocumentAsPDF["Handle"] = ExpressionConverter.ConvertO(__workflow_mSWordExportDocumentAsPDFhandle);
                        mSWordExportDocumentAsPDFpropCount++;
                    }

                    mSWordExportDocumentAsPDFpropCount++;
                }
                else
                {
                    mSWordExportDocumentAsPDF["Handle"] = 0;
                    mSWordExportDocumentAsPDFpropCount++;
                }

                if (__workflow_mSWordExportDocumentAsPDFdocumentName != null)
                {
                    mSWordExportDocumentAsPDF["DocumentName"] = ExpressionConverter.ConvertO(__workflow_mSWordExportDocumentAsPDFdocumentName);
                    mSWordExportDocumentAsPDFpropCount++;
                }

                mSWordExportDocumentAsPDFpropCount++;
                mSWordExportDocumentAsPDF["SaveFileName"] = ExpressionConverter.ConvertO(__workflow_mSWordExportDocumentAsPDFsaveFileName);
                mSWordExportDocumentAsPDFpropCount++;
                mSWordExportDocumentAsPDF["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSWordExportDocumentAsPDFworkflow);
                if (mSWordExportDocumentAsPDFpropCount > 0)
                {
                    callPayload.Body = mSWordExportDocumentAsPDF;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordAddTable(Expression<Func<int>> mSWordAddTablenumberOfRows, Expression<Func<int>> mSWordAddTablenumberOfColumns, Expression<Func<string>> mSWordAddTableworkflow, Expression<Func<int>> mSWordAddTablehandle = null, Expression<Func<string>> mSWordAddTabledocumentName = null, Expression<Func<int>> mSWordAddTableautoFitBehaviour = null)
        {
            var __workflow_mSWordAddTablenumberOfRows = mSWordAddTablenumberOfRows == null ? null : WorkflowExpression.Compile(mSWordAddTablenumberOfRows);
            WorkflowExpression.Validate(__workflow_mSWordAddTablenumberOfRows, nameof(mSWordAddTablenumberOfRows), required: true);
            var __workflow_mSWordAddTablenumberOfColumns = mSWordAddTablenumberOfColumns == null ? null : WorkflowExpression.Compile(mSWordAddTablenumberOfColumns);
            WorkflowExpression.Validate(__workflow_mSWordAddTablenumberOfColumns, nameof(mSWordAddTablenumberOfColumns), required: true);
            var __workflow_mSWordAddTableworkflow = mSWordAddTableworkflow == null ? null : WorkflowExpression.Compile(mSWordAddTableworkflow);
            WorkflowExpression.Validate(__workflow_mSWordAddTableworkflow, nameof(mSWordAddTableworkflow), required: true);
            var __workflow_mSWordAddTablehandle = mSWordAddTablehandle == null ? null : WorkflowExpression.Compile(mSWordAddTablehandle);
            WorkflowExpression.Validate(__workflow_mSWordAddTablehandle, nameof(mSWordAddTablehandle), required: false);
            var __workflow_mSWordAddTabledocumentName = mSWordAddTabledocumentName == null ? null : WorkflowExpression.Compile(mSWordAddTabledocumentName);
            WorkflowExpression.Validate(__workflow_mSWordAddTabledocumentName, nameof(mSWordAddTabledocumentName), required: false);
            var __workflow_mSWordAddTableautoFitBehaviour = mSWordAddTableautoFitBehaviour == null ? null : WorkflowExpression.Compile(mSWordAddTableautoFitBehaviour);
            WorkflowExpression.Validate(__workflow_mSWordAddTableautoFitBehaviour, nameof(mSWordAddTableautoFitBehaviour), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/MSWord/AddTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSWordAddTable = new JObject();
                var mSWordAddTablepropCount = 0;
                if (__workflow_mSWordAddTablehandle != null)
                {
                    if (__workflow_mSWordAddTablehandle != null)
                    {
                        mSWordAddTable["Handle"] = ExpressionConverter.ConvertO(__workflow_mSWordAddTablehandle);
                        mSWordAddTablepropCount++;
                    }

                    mSWordAddTablepropCount++;
                }
                else
                {
                    mSWordAddTable["Handle"] = 0;
                    mSWordAddTablepropCount++;
                }

                if (__workflow_mSWordAddTabledocumentName != null)
                {
                    mSWordAddTable["DocumentName"] = ExpressionConverter.ConvertO(__workflow_mSWordAddTabledocumentName);
                    mSWordAddTablepropCount++;
                }

                mSWordAddTablepropCount++;
                mSWordAddTable["NumberOfRows"] = ExpressionConverter.ConvertO(__workflow_mSWordAddTablenumberOfRows);
                mSWordAddTablepropCount++;
                mSWordAddTable["NumberOfColumns"] = ExpressionConverter.ConvertO(__workflow_mSWordAddTablenumberOfColumns);
                if (__workflow_mSWordAddTableautoFitBehaviour != null)
                {
                    if (__workflow_mSWordAddTableautoFitBehaviour != null)
                    {
                        mSWordAddTable["AutoFitBehaviour"] = ExpressionConverter.ConvertO(__workflow_mSWordAddTableautoFitBehaviour);
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
                mSWordAddTable["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSWordAddTableworkflow);
                if (mSWordAddTablepropCount > 0)
                {
                    callPayload.Body = mSWordAddTable;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordAddTableRow(Expression<Func<int>> mSWordAddTableRowtableIndex, Expression<Func<string>> mSWordAddTableRowworkflow, Expression<Func<int>> mSWordAddTableRowhandle = null, Expression<Func<string>> mSWordAddTableRowdocumentName = null)
        {
            var __workflow_mSWordAddTableRowtableIndex = mSWordAddTableRowtableIndex == null ? null : WorkflowExpression.Compile(mSWordAddTableRowtableIndex);
            WorkflowExpression.Validate(__workflow_mSWordAddTableRowtableIndex, nameof(mSWordAddTableRowtableIndex), required: true);
            var __workflow_mSWordAddTableRowworkflow = mSWordAddTableRowworkflow == null ? null : WorkflowExpression.Compile(mSWordAddTableRowworkflow);
            WorkflowExpression.Validate(__workflow_mSWordAddTableRowworkflow, nameof(mSWordAddTableRowworkflow), required: true);
            var __workflow_mSWordAddTableRowhandle = mSWordAddTableRowhandle == null ? null : WorkflowExpression.Compile(mSWordAddTableRowhandle);
            WorkflowExpression.Validate(__workflow_mSWordAddTableRowhandle, nameof(mSWordAddTableRowhandle), required: false);
            var __workflow_mSWordAddTableRowdocumentName = mSWordAddTableRowdocumentName == null ? null : WorkflowExpression.Compile(mSWordAddTableRowdocumentName);
            WorkflowExpression.Validate(__workflow_mSWordAddTableRowdocumentName, nameof(mSWordAddTableRowdocumentName), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/MSWord/AddTableRow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSWordAddTableRow = new JObject();
                var mSWordAddTableRowpropCount = 0;
                if (__workflow_mSWordAddTableRowhandle != null)
                {
                    if (__workflow_mSWordAddTableRowhandle != null)
                    {
                        mSWordAddTableRow["Handle"] = ExpressionConverter.ConvertO(__workflow_mSWordAddTableRowhandle);
                        mSWordAddTableRowpropCount++;
                    }

                    mSWordAddTableRowpropCount++;
                }
                else
                {
                    mSWordAddTableRow["Handle"] = 0;
                    mSWordAddTableRowpropCount++;
                }

                if (__workflow_mSWordAddTableRowdocumentName != null)
                {
                    mSWordAddTableRow["DocumentName"] = ExpressionConverter.ConvertO(__workflow_mSWordAddTableRowdocumentName);
                    mSWordAddTableRowpropCount++;
                }

                mSWordAddTableRowpropCount++;
                mSWordAddTableRow["TableIndex"] = ExpressionConverter.ConvertO(__workflow_mSWordAddTableRowtableIndex);
                mSWordAddTableRowpropCount++;
                mSWordAddTableRow["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSWordAddTableRowworkflow);
                if (mSWordAddTableRowpropCount > 0)
                {
                    callPayload.Body = mSWordAddTableRow;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordAddTableColumn(Expression<Func<int>> mSWordAddTableColumntableIndex, Expression<Func<string>> mSWordAddTableColumnworkflow, Expression<Func<int>> mSWordAddTableColumnhandle = null, Expression<Func<string>> mSWordAddTableColumndocumentName = null)
        {
            var __workflow_mSWordAddTableColumntableIndex = mSWordAddTableColumntableIndex == null ? null : WorkflowExpression.Compile(mSWordAddTableColumntableIndex);
            WorkflowExpression.Validate(__workflow_mSWordAddTableColumntableIndex, nameof(mSWordAddTableColumntableIndex), required: true);
            var __workflow_mSWordAddTableColumnworkflow = mSWordAddTableColumnworkflow == null ? null : WorkflowExpression.Compile(mSWordAddTableColumnworkflow);
            WorkflowExpression.Validate(__workflow_mSWordAddTableColumnworkflow, nameof(mSWordAddTableColumnworkflow), required: true);
            var __workflow_mSWordAddTableColumnhandle = mSWordAddTableColumnhandle == null ? null : WorkflowExpression.Compile(mSWordAddTableColumnhandle);
            WorkflowExpression.Validate(__workflow_mSWordAddTableColumnhandle, nameof(mSWordAddTableColumnhandle), required: false);
            var __workflow_mSWordAddTableColumndocumentName = mSWordAddTableColumndocumentName == null ? null : WorkflowExpression.Compile(mSWordAddTableColumndocumentName);
            WorkflowExpression.Validate(__workflow_mSWordAddTableColumndocumentName, nameof(mSWordAddTableColumndocumentName), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/MSWord/AddTableColumn";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSWordAddTableColumn = new JObject();
                var mSWordAddTableColumnpropCount = 0;
                if (__workflow_mSWordAddTableColumnhandle != null)
                {
                    if (__workflow_mSWordAddTableColumnhandle != null)
                    {
                        mSWordAddTableColumn["Handle"] = ExpressionConverter.ConvertO(__workflow_mSWordAddTableColumnhandle);
                        mSWordAddTableColumnpropCount++;
                    }

                    mSWordAddTableColumnpropCount++;
                }
                else
                {
                    mSWordAddTableColumn["Handle"] = 0;
                    mSWordAddTableColumnpropCount++;
                }

                if (__workflow_mSWordAddTableColumndocumentName != null)
                {
                    mSWordAddTableColumn["DocumentName"] = ExpressionConverter.ConvertO(__workflow_mSWordAddTableColumndocumentName);
                    mSWordAddTableColumnpropCount++;
                }

                mSWordAddTableColumnpropCount++;
                mSWordAddTableColumn["TableIndex"] = ExpressionConverter.ConvertO(__workflow_mSWordAddTableColumntableIndex);
                mSWordAddTableColumnpropCount++;
                mSWordAddTableColumn["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSWordAddTableColumnworkflow);
                if (mSWordAddTableColumnpropCount > 0)
                {
                    callPayload.Body = mSWordAddTableColumn;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordGetHighlightedTextResponse> MSWordGetHighlightedText(Expression<Func<string>> mSWordGetHighlightedTextworkflow, Expression<Func<int>> mSWordGetHighlightedTexthandle = null, Expression<Func<string>> mSWordGetHighlightedTextdocumentName = null)
        {
            var __workflow_mSWordGetHighlightedTextworkflow = mSWordGetHighlightedTextworkflow == null ? null : WorkflowExpression.Compile(mSWordGetHighlightedTextworkflow);
            WorkflowExpression.Validate(__workflow_mSWordGetHighlightedTextworkflow, nameof(mSWordGetHighlightedTextworkflow), required: true);
            var __workflow_mSWordGetHighlightedTexthandle = mSWordGetHighlightedTexthandle == null ? null : WorkflowExpression.Compile(mSWordGetHighlightedTexthandle);
            WorkflowExpression.Validate(__workflow_mSWordGetHighlightedTexthandle, nameof(mSWordGetHighlightedTexthandle), required: false);
            var __workflow_mSWordGetHighlightedTextdocumentName = mSWordGetHighlightedTextdocumentName == null ? null : WorkflowExpression.Compile(mSWordGetHighlightedTextdocumentName);
            WorkflowExpression.Validate(__workflow_mSWordGetHighlightedTextdocumentName, nameof(mSWordGetHighlightedTextdocumentName), required: false);
            return new DeferredBodyAction<MSWordGetHighlightedTextResponse>(() =>
            {
                var apiCallPath = "/MSWord/GetHighlightedText";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSWordGetHighlightedText = new JObject();
                var mSWordGetHighlightedTextpropCount = 0;
                if (__workflow_mSWordGetHighlightedTexthandle != null)
                {
                    if (__workflow_mSWordGetHighlightedTexthandle != null)
                    {
                        mSWordGetHighlightedText["Handle"] = ExpressionConverter.ConvertO(__workflow_mSWordGetHighlightedTexthandle);
                        mSWordGetHighlightedTextpropCount++;
                    }

                    mSWordGetHighlightedTextpropCount++;
                }
                else
                {
                    mSWordGetHighlightedText["Handle"] = 0;
                    mSWordGetHighlightedTextpropCount++;
                }

                if (__workflow_mSWordGetHighlightedTextdocumentName != null)
                {
                    mSWordGetHighlightedText["DocumentName"] = ExpressionConverter.ConvertO(__workflow_mSWordGetHighlightedTextdocumentName);
                    mSWordGetHighlightedTextpropCount++;
                }

                mSWordGetHighlightedTextpropCount++;
                mSWordGetHighlightedText["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSWordGetHighlightedTextworkflow);
                if (mSWordGetHighlightedTextpropCount > 0)
                {
                    callPayload.Body = mSWordGetHighlightedText;
                }

                return new ApiConnectionAction<MSWordGetHighlightedTextResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordExecuteCommandBarObjectResponse> MSWordExecuteCommandBarObject(Expression<Func<string>> mSWordExecuteCommandBarObjectobjectId, Expression<Func<string>> mSWordExecuteCommandBarObjectworkflow, Expression<Func<int>> mSWordExecuteCommandBarObjecthandle = null, Expression<Func<bool>> mSWordExecuteCommandBarObjectrunInBackground = null)
        {
            var __workflow_mSWordExecuteCommandBarObjectobjectId = mSWordExecuteCommandBarObjectobjectId == null ? null : WorkflowExpression.Compile(mSWordExecuteCommandBarObjectobjectId);
            WorkflowExpression.Validate(__workflow_mSWordExecuteCommandBarObjectobjectId, nameof(mSWordExecuteCommandBarObjectobjectId), required: true);
            var __workflow_mSWordExecuteCommandBarObjectworkflow = mSWordExecuteCommandBarObjectworkflow == null ? null : WorkflowExpression.Compile(mSWordExecuteCommandBarObjectworkflow);
            WorkflowExpression.Validate(__workflow_mSWordExecuteCommandBarObjectworkflow, nameof(mSWordExecuteCommandBarObjectworkflow), required: true);
            var __workflow_mSWordExecuteCommandBarObjecthandle = mSWordExecuteCommandBarObjecthandle == null ? null : WorkflowExpression.Compile(mSWordExecuteCommandBarObjecthandle);
            WorkflowExpression.Validate(__workflow_mSWordExecuteCommandBarObjecthandle, nameof(mSWordExecuteCommandBarObjecthandle), required: false);
            var __workflow_mSWordExecuteCommandBarObjectrunInBackground = mSWordExecuteCommandBarObjectrunInBackground == null ? null : WorkflowExpression.Compile(mSWordExecuteCommandBarObjectrunInBackground);
            WorkflowExpression.Validate(__workflow_mSWordExecuteCommandBarObjectrunInBackground, nameof(mSWordExecuteCommandBarObjectrunInBackground), required: false);
            return new DeferredBodyAction<MSWordExecuteCommandBarObjectResponse>(() =>
            {
                var apiCallPath = "/MSWord/ExecuteCommandBarObject";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSWordExecuteCommandBarObject = new JObject();
                var mSWordExecuteCommandBarObjectpropCount = 0;
                if (__workflow_mSWordExecuteCommandBarObjecthandle != null)
                {
                    if (__workflow_mSWordExecuteCommandBarObjecthandle != null)
                    {
                        mSWordExecuteCommandBarObject["Handle"] = ExpressionConverter.ConvertO(__workflow_mSWordExecuteCommandBarObjecthandle);
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
                mSWordExecuteCommandBarObject["ObjectId"] = ExpressionConverter.ConvertO(__workflow_mSWordExecuteCommandBarObjectobjectId);
                if (__workflow_mSWordExecuteCommandBarObjectrunInBackground != null)
                {
                    if (__workflow_mSWordExecuteCommandBarObjectrunInBackground != null)
                    {
                        mSWordExecuteCommandBarObject["RunInBackground"] = ExpressionConverter.ConvertO(__workflow_mSWordExecuteCommandBarObjectrunInBackground);
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
                mSWordExecuteCommandBarObject["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSWordExecuteCommandBarObjectworkflow);
                if (mSWordExecuteCommandBarObjectpropCount > 0)
                {
                    callPayload.Body = mSWordExecuteCommandBarObject;
                }

                return new ApiConnectionAction<MSWordExecuteCommandBarObjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordSetDocumentSensitivityLabelResponse> MSWordSetDocumentSensitivityLabel(Expression<Func<mSWordSetDocumentSensitivityLabelassignmentMethodInput>> mSWordSetDocumentSensitivityLabelassignmentMethod, Expression<Func<string>> mSWordSetDocumentSensitivityLabellabelId, Expression<Func<string>> mSWordSetDocumentSensitivityLabelworkflow, Expression<Func<int>> mSWordSetDocumentSensitivityLabelhandle = null, Expression<Func<string>> mSWordSetDocumentSensitivityLabeldocumentName = null, Expression<Func<string>> mSWordSetDocumentSensitivityLabellabelName = null, Expression<Func<string>> mSWordSetDocumentSensitivityLabelsiteId = null, Expression<Func<string>> mSWordSetDocumentSensitivityLabeljustification = null)
        {
            var __workflow_mSWordSetDocumentSensitivityLabelassignmentMethod = mSWordSetDocumentSensitivityLabelassignmentMethod == null ? null : WorkflowExpression.Compile(mSWordSetDocumentSensitivityLabelassignmentMethod);
            WorkflowExpression.Validate(__workflow_mSWordSetDocumentSensitivityLabelassignmentMethod, nameof(mSWordSetDocumentSensitivityLabelassignmentMethod), required: true);
            var __workflow_mSWordSetDocumentSensitivityLabellabelId = mSWordSetDocumentSensitivityLabellabelId == null ? null : WorkflowExpression.Compile(mSWordSetDocumentSensitivityLabellabelId);
            WorkflowExpression.Validate(__workflow_mSWordSetDocumentSensitivityLabellabelId, nameof(mSWordSetDocumentSensitivityLabellabelId), required: true);
            var __workflow_mSWordSetDocumentSensitivityLabelworkflow = mSWordSetDocumentSensitivityLabelworkflow == null ? null : WorkflowExpression.Compile(mSWordSetDocumentSensitivityLabelworkflow);
            WorkflowExpression.Validate(__workflow_mSWordSetDocumentSensitivityLabelworkflow, nameof(mSWordSetDocumentSensitivityLabelworkflow), required: true);
            var __workflow_mSWordSetDocumentSensitivityLabelhandle = mSWordSetDocumentSensitivityLabelhandle == null ? null : WorkflowExpression.Compile(mSWordSetDocumentSensitivityLabelhandle);
            WorkflowExpression.Validate(__workflow_mSWordSetDocumentSensitivityLabelhandle, nameof(mSWordSetDocumentSensitivityLabelhandle), required: false);
            var __workflow_mSWordSetDocumentSensitivityLabeldocumentName = mSWordSetDocumentSensitivityLabeldocumentName == null ? null : WorkflowExpression.Compile(mSWordSetDocumentSensitivityLabeldocumentName);
            WorkflowExpression.Validate(__workflow_mSWordSetDocumentSensitivityLabeldocumentName, nameof(mSWordSetDocumentSensitivityLabeldocumentName), required: false);
            var __workflow_mSWordSetDocumentSensitivityLabellabelName = mSWordSetDocumentSensitivityLabellabelName == null ? null : WorkflowExpression.Compile(mSWordSetDocumentSensitivityLabellabelName);
            WorkflowExpression.Validate(__workflow_mSWordSetDocumentSensitivityLabellabelName, nameof(mSWordSetDocumentSensitivityLabellabelName), required: false);
            var __workflow_mSWordSetDocumentSensitivityLabelsiteId = mSWordSetDocumentSensitivityLabelsiteId == null ? null : WorkflowExpression.Compile(mSWordSetDocumentSensitivityLabelsiteId);
            WorkflowExpression.Validate(__workflow_mSWordSetDocumentSensitivityLabelsiteId, nameof(mSWordSetDocumentSensitivityLabelsiteId), required: false);
            var __workflow_mSWordSetDocumentSensitivityLabeljustification = mSWordSetDocumentSensitivityLabeljustification == null ? null : WorkflowExpression.Compile(mSWordSetDocumentSensitivityLabeljustification);
            WorkflowExpression.Validate(__workflow_mSWordSetDocumentSensitivityLabeljustification, nameof(mSWordSetDocumentSensitivityLabeljustification), required: false);
            return new DeferredBodyAction<MSWordSetDocumentSensitivityLabelResponse>(() =>
            {
                var apiCallPath = "/MSWord/MSWordSetDocumentSensitivityLabel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSWordSetDocumentSensitivityLabel = new JObject();
                var mSWordSetDocumentSensitivityLabelpropCount = 0;
                if (__workflow_mSWordSetDocumentSensitivityLabelhandle != null)
                {
                    if (__workflow_mSWordSetDocumentSensitivityLabelhandle != null)
                    {
                        mSWordSetDocumentSensitivityLabel["Handle"] = ExpressionConverter.ConvertO(__workflow_mSWordSetDocumentSensitivityLabelhandle);
                        mSWordSetDocumentSensitivityLabelpropCount++;
                    }

                    mSWordSetDocumentSensitivityLabelpropCount++;
                }
                else
                {
                    mSWordSetDocumentSensitivityLabel["Handle"] = 0;
                    mSWordSetDocumentSensitivityLabelpropCount++;
                }

                if (__workflow_mSWordSetDocumentSensitivityLabeldocumentName != null)
                {
                    mSWordSetDocumentSensitivityLabel["DocumentName"] = ExpressionConverter.ConvertO(__workflow_mSWordSetDocumentSensitivityLabeldocumentName);
                    mSWordSetDocumentSensitivityLabelpropCount++;
                }

                mSWordSetDocumentSensitivityLabelpropCount++;
                mSWordSetDocumentSensitivityLabel["AssignmentMethod"] = ExpressionConverter.ConvertO(__workflow_mSWordSetDocumentSensitivityLabelassignmentMethod);
                mSWordSetDocumentSensitivityLabelpropCount++;
                mSWordSetDocumentSensitivityLabel["LabelId"] = ExpressionConverter.ConvertO(__workflow_mSWordSetDocumentSensitivityLabellabelId);
                if (__workflow_mSWordSetDocumentSensitivityLabellabelName != null)
                {
                    mSWordSetDocumentSensitivityLabel["LabelName"] = ExpressionConverter.ConvertO(__workflow_mSWordSetDocumentSensitivityLabellabelName);
                    mSWordSetDocumentSensitivityLabelpropCount++;
                }

                if (__workflow_mSWordSetDocumentSensitivityLabelsiteId != null)
                {
                    mSWordSetDocumentSensitivityLabel["SiteId"] = ExpressionConverter.ConvertO(__workflow_mSWordSetDocumentSensitivityLabelsiteId);
                    mSWordSetDocumentSensitivityLabelpropCount++;
                }

                if (__workflow_mSWordSetDocumentSensitivityLabeljustification != null)
                {
                    mSWordSetDocumentSensitivityLabel["Justification"] = ExpressionConverter.ConvertO(__workflow_mSWordSetDocumentSensitivityLabeljustification);
                    mSWordSetDocumentSensitivityLabelpropCount++;
                }

                mSWordSetDocumentSensitivityLabelpropCount++;
                mSWordSetDocumentSensitivityLabel["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSWordSetDocumentSensitivityLabelworkflow);
                if (mSWordSetDocumentSensitivityLabelpropCount > 0)
                {
                    callPayload.Body = mSWordSetDocumentSensitivityLabel;
                }

                return new ApiConnectionAction<MSWordSetDocumentSensitivityLabelResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordGetDocumentSensitivityLabelResponse> MSWordGetDocumentSensitivityLabel(Expression<Func<string>> mSWordGetDocumentSensitivityLabelworkflow, Expression<Func<int>> mSWordGetDocumentSensitivityLabelhandle = null, Expression<Func<string>> mSWordGetDocumentSensitivityLabeldocumentName = null)
        {
            var __workflow_mSWordGetDocumentSensitivityLabelworkflow = mSWordGetDocumentSensitivityLabelworkflow == null ? null : WorkflowExpression.Compile(mSWordGetDocumentSensitivityLabelworkflow);
            WorkflowExpression.Validate(__workflow_mSWordGetDocumentSensitivityLabelworkflow, nameof(mSWordGetDocumentSensitivityLabelworkflow), required: true);
            var __workflow_mSWordGetDocumentSensitivityLabelhandle = mSWordGetDocumentSensitivityLabelhandle == null ? null : WorkflowExpression.Compile(mSWordGetDocumentSensitivityLabelhandle);
            WorkflowExpression.Validate(__workflow_mSWordGetDocumentSensitivityLabelhandle, nameof(mSWordGetDocumentSensitivityLabelhandle), required: false);
            var __workflow_mSWordGetDocumentSensitivityLabeldocumentName = mSWordGetDocumentSensitivityLabeldocumentName == null ? null : WorkflowExpression.Compile(mSWordGetDocumentSensitivityLabeldocumentName);
            WorkflowExpression.Validate(__workflow_mSWordGetDocumentSensitivityLabeldocumentName, nameof(mSWordGetDocumentSensitivityLabeldocumentName), required: false);
            return new DeferredBodyAction<MSWordGetDocumentSensitivityLabelResponse>(() =>
            {
                var apiCallPath = "/MSWord/MSWordGetDocumentSensitivityLabel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSWordGetDocumentSensitivityLabel = new JObject();
                var mSWordGetDocumentSensitivityLabelpropCount = 0;
                if (__workflow_mSWordGetDocumentSensitivityLabelhandle != null)
                {
                    if (__workflow_mSWordGetDocumentSensitivityLabelhandle != null)
                    {
                        mSWordGetDocumentSensitivityLabel["Handle"] = ExpressionConverter.ConvertO(__workflow_mSWordGetDocumentSensitivityLabelhandle);
                        mSWordGetDocumentSensitivityLabelpropCount++;
                    }

                    mSWordGetDocumentSensitivityLabelpropCount++;
                }
                else
                {
                    mSWordGetDocumentSensitivityLabel["Handle"] = 0;
                    mSWordGetDocumentSensitivityLabelpropCount++;
                }

                if (__workflow_mSWordGetDocumentSensitivityLabeldocumentName != null)
                {
                    mSWordGetDocumentSensitivityLabel["DocumentName"] = ExpressionConverter.ConvertO(__workflow_mSWordGetDocumentSensitivityLabeldocumentName);
                    mSWordGetDocumentSensitivityLabelpropCount++;
                }

                mSWordGetDocumentSensitivityLabelpropCount++;
                mSWordGetDocumentSensitivityLabel["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSWordGetDocumentSensitivityLabelworkflow);
                if (mSWordGetDocumentSensitivityLabelpropCount > 0)
                {
                    callPayload.Body = mSWordGetDocumentSensitivityLabel;
                }

                return new ApiConnectionAction<MSWordGetDocumentSensitivityLabelResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelCreateInstanceResponse> MSExcelCreateInstance(Expression<Func<string>> mSExcelCreateInstanceworkflow, Expression<Func<bool>> mSExcelCreateInstanceenableEvents = null, Expression<Func<bool>> mSExcelCreateInstanceshowExcel = null)
        {
            var __workflow_mSExcelCreateInstanceworkflow = mSExcelCreateInstanceworkflow == null ? null : WorkflowExpression.Compile(mSExcelCreateInstanceworkflow);
            WorkflowExpression.Validate(__workflow_mSExcelCreateInstanceworkflow, nameof(mSExcelCreateInstanceworkflow), required: true);
            var __workflow_mSExcelCreateInstanceenableEvents = mSExcelCreateInstanceenableEvents == null ? null : WorkflowExpression.Compile(mSExcelCreateInstanceenableEvents);
            WorkflowExpression.Validate(__workflow_mSExcelCreateInstanceenableEvents, nameof(mSExcelCreateInstanceenableEvents), required: false);
            var __workflow_mSExcelCreateInstanceshowExcel = mSExcelCreateInstanceshowExcel == null ? null : WorkflowExpression.Compile(mSExcelCreateInstanceshowExcel);
            WorkflowExpression.Validate(__workflow_mSExcelCreateInstanceshowExcel, nameof(mSExcelCreateInstanceshowExcel), required: false);
            return new DeferredBodyAction<MSExcelCreateInstanceResponse>(() =>
            {
                var apiCallPath = "/MSExcel/CreateInstance";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSExcelCreateInstance = new JObject();
                var mSExcelCreateInstancepropCount = 0;
                if (__workflow_mSExcelCreateInstanceenableEvents != null)
                {
                    if (__workflow_mSExcelCreateInstanceenableEvents != null)
                    {
                        mSExcelCreateInstance["EnableEvents"] = ExpressionConverter.ConvertO(__workflow_mSExcelCreateInstanceenableEvents);
                        mSExcelCreateInstancepropCount++;
                    }

                    mSExcelCreateInstancepropCount++;
                }
                else
                {
                    mSExcelCreateInstance["EnableEvents"] = true;
                    mSExcelCreateInstancepropCount++;
                }

                if (__workflow_mSExcelCreateInstanceshowExcel != null)
                {
                    if (__workflow_mSExcelCreateInstanceshowExcel != null)
                    {
                        mSExcelCreateInstance["ShowExcel"] = ExpressionConverter.ConvertO(__workflow_mSExcelCreateInstanceshowExcel);
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
                mSExcelCreateInstance["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSExcelCreateInstanceworkflow);
                if (mSExcelCreateInstancepropCount > 0)
                {
                    callPayload.Body = mSExcelCreateInstance;
                }

                return new ApiConnectionAction<MSExcelCreateInstanceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelCloseInstance(Expression<Func<string>> mSExcelCloseInstanceworkflow, Expression<Func<int>> mSExcelCloseInstancehandle = null)
        {
            var __workflow_mSExcelCloseInstanceworkflow = mSExcelCloseInstanceworkflow == null ? null : WorkflowExpression.Compile(mSExcelCloseInstanceworkflow);
            WorkflowExpression.Validate(__workflow_mSExcelCloseInstanceworkflow, nameof(mSExcelCloseInstanceworkflow), required: true);
            var __workflow_mSExcelCloseInstancehandle = mSExcelCloseInstancehandle == null ? null : WorkflowExpression.Compile(mSExcelCloseInstancehandle);
            WorkflowExpression.Validate(__workflow_mSExcelCloseInstancehandle, nameof(mSExcelCloseInstancehandle), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/MSExcel/CloseInstance";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSExcelCloseInstance = new JObject();
                var mSExcelCloseInstancepropCount = 0;
                if (__workflow_mSExcelCloseInstancehandle != null)
                {
                    if (__workflow_mSExcelCloseInstancehandle != null)
                    {
                        mSExcelCloseInstance["Handle"] = ExpressionConverter.ConvertO(__workflow_mSExcelCloseInstancehandle);
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
                mSExcelCloseInstance["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSExcelCloseInstanceworkflow);
                if (mSExcelCloseInstancepropCount > 0)
                {
                    callPayload.Body = mSExcelCloseInstance;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelAttachToExistingInstanceResponse> MSExcelAttachToExistingInstance(Expression<Func<string>> mSExcelAttachToExistingInstanceworkflow, Expression<Func<string>> mSExcelAttachToExistingInstancefilename = null, Expression<Func<bool>> mSExcelAttachToExistingInstancetoggleWindow = null, Expression<Func<bool>> mSExcelAttachToExistingInstancetoggleUsesGlobalLeftMouseClickAgent = null, Expression<Func<double>> mSExcelAttachToExistingInstancetoggleDelay = null)
        {
            var __workflow_mSExcelAttachToExistingInstanceworkflow = mSExcelAttachToExistingInstanceworkflow == null ? null : WorkflowExpression.Compile(mSExcelAttachToExistingInstanceworkflow);
            WorkflowExpression.Validate(__workflow_mSExcelAttachToExistingInstanceworkflow, nameof(mSExcelAttachToExistingInstanceworkflow), required: true);
            var __workflow_mSExcelAttachToExistingInstancefilename = mSExcelAttachToExistingInstancefilename == null ? null : WorkflowExpression.Compile(mSExcelAttachToExistingInstancefilename);
            WorkflowExpression.Validate(__workflow_mSExcelAttachToExistingInstancefilename, nameof(mSExcelAttachToExistingInstancefilename), required: false);
            var __workflow_mSExcelAttachToExistingInstancetoggleWindow = mSExcelAttachToExistingInstancetoggleWindow == null ? null : WorkflowExpression.Compile(mSExcelAttachToExistingInstancetoggleWindow);
            WorkflowExpression.Validate(__workflow_mSExcelAttachToExistingInstancetoggleWindow, nameof(mSExcelAttachToExistingInstancetoggleWindow), required: false);
            var __workflow_mSExcelAttachToExistingInstancetoggleUsesGlobalLeftMouseClickAgent = mSExcelAttachToExistingInstancetoggleUsesGlobalLeftMouseClickAgent == null ? null : WorkflowExpression.Compile(mSExcelAttachToExistingInstancetoggleUsesGlobalLeftMouseClickAgent);
            WorkflowExpression.Validate(__workflow_mSExcelAttachToExistingInstancetoggleUsesGlobalLeftMouseClickAgent, nameof(mSExcelAttachToExistingInstancetoggleUsesGlobalLeftMouseClickAgent), required: false);
            var __workflow_mSExcelAttachToExistingInstancetoggleDelay = mSExcelAttachToExistingInstancetoggleDelay == null ? null : WorkflowExpression.Compile(mSExcelAttachToExistingInstancetoggleDelay);
            WorkflowExpression.Validate(__workflow_mSExcelAttachToExistingInstancetoggleDelay, nameof(mSExcelAttachToExistingInstancetoggleDelay), required: false);
            return new DeferredBodyAction<MSExcelAttachToExistingInstanceResponse>(() =>
            {
                var apiCallPath = "/MSExcel/MSExcelAttachToExistingInstance";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSExcelAttachToExistingInstance = new JObject();
                var mSExcelAttachToExistingInstancepropCount = 0;
                if (__workflow_mSExcelAttachToExistingInstancefilename != null)
                {
                    mSExcelAttachToExistingInstance["Filename"] = ExpressionConverter.ConvertO(__workflow_mSExcelAttachToExistingInstancefilename);
                    mSExcelAttachToExistingInstancepropCount++;
                }

                if (__workflow_mSExcelAttachToExistingInstancetoggleWindow != null)
                {
                    if (__workflow_mSExcelAttachToExistingInstancetoggleWindow != null)
                    {
                        mSExcelAttachToExistingInstance["ToggleWindow"] = ExpressionConverter.ConvertO(__workflow_mSExcelAttachToExistingInstancetoggleWindow);
                        mSExcelAttachToExistingInstancepropCount++;
                    }

                    mSExcelAttachToExistingInstancepropCount++;
                }
                else
                {
                    mSExcelAttachToExistingInstance["ToggleWindow"] = true;
                    mSExcelAttachToExistingInstancepropCount++;
                }

                if (__workflow_mSExcelAttachToExistingInstancetoggleUsesGlobalLeftMouseClickAgent != null)
                {
                    if (__workflow_mSExcelAttachToExistingInstancetoggleUsesGlobalLeftMouseClickAgent != null)
                    {
                        mSExcelAttachToExistingInstance["ToggleUsesGlobalLeftMouseClickAgent"] = ExpressionConverter.ConvertO(__workflow_mSExcelAttachToExistingInstancetoggleUsesGlobalLeftMouseClickAgent);
                        mSExcelAttachToExistingInstancepropCount++;
                    }

                    mSExcelAttachToExistingInstancepropCount++;
                }
                else
                {
                    mSExcelAttachToExistingInstance["ToggleUsesGlobalLeftMouseClickAgent"] = true;
                    mSExcelAttachToExistingInstancepropCount++;
                }

                if (__workflow_mSExcelAttachToExistingInstancetoggleDelay != null)
                {
                    if (__workflow_mSExcelAttachToExistingInstancetoggleDelay != null)
                    {
                        mSExcelAttachToExistingInstance["ToggleDelay"] = ExpressionConverter.ConvertO(__workflow_mSExcelAttachToExistingInstancetoggleDelay);
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
                mSExcelAttachToExistingInstance["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSExcelAttachToExistingInstanceworkflow);
                if (mSExcelAttachToExistingInstancepropCount > 0)
                {
                    callPayload.Body = mSExcelAttachToExistingInstance;
                }

                return new ApiConnectionAction<MSExcelAttachToExistingInstanceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelShowExcel(Expression<Func<string>> mSExcelShowExcelworkflow, Expression<Func<int>> mSExcelShowExcelhandle = null)
        {
            var __workflow_mSExcelShowExcelworkflow = mSExcelShowExcelworkflow == null ? null : WorkflowExpression.Compile(mSExcelShowExcelworkflow);
            WorkflowExpression.Validate(__workflow_mSExcelShowExcelworkflow, nameof(mSExcelShowExcelworkflow), required: true);
            var __workflow_mSExcelShowExcelhandle = mSExcelShowExcelhandle == null ? null : WorkflowExpression.Compile(mSExcelShowExcelhandle);
            WorkflowExpression.Validate(__workflow_mSExcelShowExcelhandle, nameof(mSExcelShowExcelhandle), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/MSExcel/ShowExcel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSExcelShowExcel = new JObject();
                var mSExcelShowExcelpropCount = 0;
                if (__workflow_mSExcelShowExcelhandle != null)
                {
                    if (__workflow_mSExcelShowExcelhandle != null)
                    {
                        mSExcelShowExcel["Handle"] = ExpressionConverter.ConvertO(__workflow_mSExcelShowExcelhandle);
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
                mSExcelShowExcel["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSExcelShowExcelworkflow);
                if (mSExcelShowExcelpropCount > 0)
                {
                    callPayload.Body = mSExcelShowExcel;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelHideExcel(Expression<Func<string>> mSExcelHideExcelworkflow, Expression<Func<int>> mSExcelHideExcelhandle = null)
        {
            var __workflow_mSExcelHideExcelworkflow = mSExcelHideExcelworkflow == null ? null : WorkflowExpression.Compile(mSExcelHideExcelworkflow);
            WorkflowExpression.Validate(__workflow_mSExcelHideExcelworkflow, nameof(mSExcelHideExcelworkflow), required: true);
            var __workflow_mSExcelHideExcelhandle = mSExcelHideExcelhandle == null ? null : WorkflowExpression.Compile(mSExcelHideExcelhandle);
            WorkflowExpression.Validate(__workflow_mSExcelHideExcelhandle, nameof(mSExcelHideExcelhandle), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/MSExcel/HideExcel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSExcelHideExcel = new JObject();
                var mSExcelHideExcelpropCount = 0;
                if (__workflow_mSExcelHideExcelhandle != null)
                {
                    if (__workflow_mSExcelHideExcelhandle != null)
                    {
                        mSExcelHideExcel["Handle"] = ExpressionConverter.ConvertO(__workflow_mSExcelHideExcelhandle);
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
                mSExcelHideExcel["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSExcelHideExcelworkflow);
                if (mSExcelHideExcelpropCount > 0)
                {
                    callPayload.Body = mSExcelHideExcel;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelOpenWorkbookResponse> MSExcelOpenWorkbook(Expression<Func<string>> mSExcelOpenWorkbookworkflow, Expression<Func<int>> mSExcelOpenWorkbookhandle = null, Expression<Func<string>> mSExcelOpenWorkbookfilename = null, Expression<Func<bool>> mSExcelOpenWorkbookreadOnly = null, Expression<Func<bool>> mSExcelOpenWorkbookupdateLinks = null, Expression<Func<string>> mSExcelOpenWorkbookpassword = null, Expression<Func<bool>> mSExcelOpenWorkbookenableEvents = null, Expression<Func<bool>> mSExcelOpenWorkbookputHTTPWorkbooksIntoEditMode = null, Expression<Func<bool>> mSExcelOpenWorkbookputFilePathWorkbooksIntoEditMode = null)
        {
            var __workflow_mSExcelOpenWorkbookworkflow = mSExcelOpenWorkbookworkflow == null ? null : WorkflowExpression.Compile(mSExcelOpenWorkbookworkflow);
            WorkflowExpression.Validate(__workflow_mSExcelOpenWorkbookworkflow, nameof(mSExcelOpenWorkbookworkflow), required: true);
            var __workflow_mSExcelOpenWorkbookhandle = mSExcelOpenWorkbookhandle == null ? null : WorkflowExpression.Compile(mSExcelOpenWorkbookhandle);
            WorkflowExpression.Validate(__workflow_mSExcelOpenWorkbookhandle, nameof(mSExcelOpenWorkbookhandle), required: false);
            var __workflow_mSExcelOpenWorkbookfilename = mSExcelOpenWorkbookfilename == null ? null : WorkflowExpression.Compile(mSExcelOpenWorkbookfilename);
            WorkflowExpression.Validate(__workflow_mSExcelOpenWorkbookfilename, nameof(mSExcelOpenWorkbookfilename), required: false);
            var __workflow_mSExcelOpenWorkbookreadOnly = mSExcelOpenWorkbookreadOnly == null ? null : WorkflowExpression.Compile(mSExcelOpenWorkbookreadOnly);
            WorkflowExpression.Validate(__workflow_mSExcelOpenWorkbookreadOnly, nameof(mSExcelOpenWorkbookreadOnly), required: false);
            var __workflow_mSExcelOpenWorkbookupdateLinks = mSExcelOpenWorkbookupdateLinks == null ? null : WorkflowExpression.Compile(mSExcelOpenWorkbookupdateLinks);
            WorkflowExpression.Validate(__workflow_mSExcelOpenWorkbookupdateLinks, nameof(mSExcelOpenWorkbookupdateLinks), required: false);
            var __workflow_mSExcelOpenWorkbookpassword = mSExcelOpenWorkbookpassword == null ? null : WorkflowExpression.Compile(mSExcelOpenWorkbookpassword);
            WorkflowExpression.Validate(__workflow_mSExcelOpenWorkbookpassword, nameof(mSExcelOpenWorkbookpassword), required: false);
            var __workflow_mSExcelOpenWorkbookenableEvents = mSExcelOpenWorkbookenableEvents == null ? null : WorkflowExpression.Compile(mSExcelOpenWorkbookenableEvents);
            WorkflowExpression.Validate(__workflow_mSExcelOpenWorkbookenableEvents, nameof(mSExcelOpenWorkbookenableEvents), required: false);
            var __workflow_mSExcelOpenWorkbookputHTTPWorkbooksIntoEditMode = mSExcelOpenWorkbookputHTTPWorkbooksIntoEditMode == null ? null : WorkflowExpression.Compile(mSExcelOpenWorkbookputHTTPWorkbooksIntoEditMode);
            WorkflowExpression.Validate(__workflow_mSExcelOpenWorkbookputHTTPWorkbooksIntoEditMode, nameof(mSExcelOpenWorkbookputHTTPWorkbooksIntoEditMode), required: false);
            var __workflow_mSExcelOpenWorkbookputFilePathWorkbooksIntoEditMode = mSExcelOpenWorkbookputFilePathWorkbooksIntoEditMode == null ? null : WorkflowExpression.Compile(mSExcelOpenWorkbookputFilePathWorkbooksIntoEditMode);
            WorkflowExpression.Validate(__workflow_mSExcelOpenWorkbookputFilePathWorkbooksIntoEditMode, nameof(mSExcelOpenWorkbookputFilePathWorkbooksIntoEditMode), required: false);
            return new DeferredBodyAction<MSExcelOpenWorkbookResponse>(() =>
            {
                var apiCallPath = "/MSExcel/OpenWorkbook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSExcelOpenWorkbook = new JObject();
                var mSExcelOpenWorkbookpropCount = 0;
                if (__workflow_mSExcelOpenWorkbookhandle != null)
                {
                    if (__workflow_mSExcelOpenWorkbookhandle != null)
                    {
                        mSExcelOpenWorkbook["Handle"] = ExpressionConverter.ConvertO(__workflow_mSExcelOpenWorkbookhandle);
                        mSExcelOpenWorkbookpropCount++;
                    }

                    mSExcelOpenWorkbookpropCount++;
                }
                else
                {
                    mSExcelOpenWorkbook["Handle"] = 0;
                    mSExcelOpenWorkbookpropCount++;
                }

                if (__workflow_mSExcelOpenWorkbookfilename != null)
                {
                    mSExcelOpenWorkbook["Filename"] = ExpressionConverter.ConvertO(__workflow_mSExcelOpenWorkbookfilename);
                    mSExcelOpenWorkbookpropCount++;
                }

                if (__workflow_mSExcelOpenWorkbookreadOnly != null)
                {
                    if (__workflow_mSExcelOpenWorkbookreadOnly != null)
                    {
                        mSExcelOpenWorkbook["ReadOnly"] = ExpressionConverter.ConvertO(__workflow_mSExcelOpenWorkbookreadOnly);
                        mSExcelOpenWorkbookpropCount++;
                    }

                    mSExcelOpenWorkbookpropCount++;
                }
                else
                {
                    mSExcelOpenWorkbook["ReadOnly"] = false;
                    mSExcelOpenWorkbookpropCount++;
                }

                if (__workflow_mSExcelOpenWorkbookupdateLinks != null)
                {
                    if (__workflow_mSExcelOpenWorkbookupdateLinks != null)
                    {
                        mSExcelOpenWorkbook["UpdateLinks"] = ExpressionConverter.ConvertO(__workflow_mSExcelOpenWorkbookupdateLinks);
                        mSExcelOpenWorkbookpropCount++;
                    }

                    mSExcelOpenWorkbookpropCount++;
                }
                else
                {
                    mSExcelOpenWorkbook["UpdateLinks"] = false;
                    mSExcelOpenWorkbookpropCount++;
                }

                if (__workflow_mSExcelOpenWorkbookpassword != null)
                {
                    mSExcelOpenWorkbook["Password"] = ExpressionConverter.ConvertO(__workflow_mSExcelOpenWorkbookpassword);
                    mSExcelOpenWorkbookpropCount++;
                }

                if (__workflow_mSExcelOpenWorkbookenableEvents != null)
                {
                    if (__workflow_mSExcelOpenWorkbookenableEvents != null)
                    {
                        mSExcelOpenWorkbook["EnableEvents"] = ExpressionConverter.ConvertO(__workflow_mSExcelOpenWorkbookenableEvents);
                        mSExcelOpenWorkbookpropCount++;
                    }

                    mSExcelOpenWorkbookpropCount++;
                }
                else
                {
                    mSExcelOpenWorkbook["EnableEvents"] = true;
                    mSExcelOpenWorkbookpropCount++;
                }

                if (__workflow_mSExcelOpenWorkbookputHTTPWorkbooksIntoEditMode != null)
                {
                    if (__workflow_mSExcelOpenWorkbookputHTTPWorkbooksIntoEditMode != null)
                    {
                        mSExcelOpenWorkbook["PutHTTPWorkbooksIntoEditMode"] = ExpressionConverter.ConvertO(__workflow_mSExcelOpenWorkbookputHTTPWorkbooksIntoEditMode);
                        mSExcelOpenWorkbookpropCount++;
                    }

                    mSExcelOpenWorkbookpropCount++;
                }
                else
                {
                    mSExcelOpenWorkbook["PutHTTPWorkbooksIntoEditMode"] = true;
                    mSExcelOpenWorkbookpropCount++;
                }

                if (__workflow_mSExcelOpenWorkbookputFilePathWorkbooksIntoEditMode != null)
                {
                    if (__workflow_mSExcelOpenWorkbookputFilePathWorkbooksIntoEditMode != null)
                    {
                        mSExcelOpenWorkbook["PutFilePathWorkbooksIntoEditMode"] = ExpressionConverter.ConvertO(__workflow_mSExcelOpenWorkbookputFilePathWorkbooksIntoEditMode);
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
                mSExcelOpenWorkbook["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSExcelOpenWorkbookworkflow);
                if (mSExcelOpenWorkbookpropCount > 0)
                {
                    callPayload.Body = mSExcelOpenWorkbook;
                }

                return new ApiConnectionAction<MSExcelOpenWorkbookResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelPutWorkbookInEditModeResponse> MSExcelPutWorkbookInEditMode(Expression<Func<string>> mSExcelPutWorkbookInEditModeworkflow, Expression<Func<int>> mSExcelPutWorkbookInEditModehandle = null, Expression<Func<string>> mSExcelPutWorkbookInEditModeworkbookName = null, Expression<Func<bool>> mSExcelPutWorkbookInEditModeforce = null)
        {
            var __workflow_mSExcelPutWorkbookInEditModeworkflow = mSExcelPutWorkbookInEditModeworkflow == null ? null : WorkflowExpression.Compile(mSExcelPutWorkbookInEditModeworkflow);
            WorkflowExpression.Validate(__workflow_mSExcelPutWorkbookInEditModeworkflow, nameof(mSExcelPutWorkbookInEditModeworkflow), required: true);
            var __workflow_mSExcelPutWorkbookInEditModehandle = mSExcelPutWorkbookInEditModehandle == null ? null : WorkflowExpression.Compile(mSExcelPutWorkbookInEditModehandle);
            WorkflowExpression.Validate(__workflow_mSExcelPutWorkbookInEditModehandle, nameof(mSExcelPutWorkbookInEditModehandle), required: false);
            var __workflow_mSExcelPutWorkbookInEditModeworkbookName = mSExcelPutWorkbookInEditModeworkbookName == null ? null : WorkflowExpression.Compile(mSExcelPutWorkbookInEditModeworkbookName);
            WorkflowExpression.Validate(__workflow_mSExcelPutWorkbookInEditModeworkbookName, nameof(mSExcelPutWorkbookInEditModeworkbookName), required: false);
            var __workflow_mSExcelPutWorkbookInEditModeforce = mSExcelPutWorkbookInEditModeforce == null ? null : WorkflowExpression.Compile(mSExcelPutWorkbookInEditModeforce);
            WorkflowExpression.Validate(__workflow_mSExcelPutWorkbookInEditModeforce, nameof(mSExcelPutWorkbookInEditModeforce), required: false);
            return new DeferredBodyAction<MSExcelPutWorkbookInEditModeResponse>(() =>
            {
                var apiCallPath = "/MSExcel/PutWorkbookInEditMode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSExcelPutWorkbookInEditMode = new JObject();
                var mSExcelPutWorkbookInEditModepropCount = 0;
                if (__workflow_mSExcelPutWorkbookInEditModehandle != null)
                {
                    if (__workflow_mSExcelPutWorkbookInEditModehandle != null)
                    {
                        mSExcelPutWorkbookInEditMode["Handle"] = ExpressionConverter.ConvertO(__workflow_mSExcelPutWorkbookInEditModehandle);
                        mSExcelPutWorkbookInEditModepropCount++;
                    }

                    mSExcelPutWorkbookInEditModepropCount++;
                }
                else
                {
                    mSExcelPutWorkbookInEditMode["Handle"] = 0;
                    mSExcelPutWorkbookInEditModepropCount++;
                }

                if (__workflow_mSExcelPutWorkbookInEditModeworkbookName != null)
                {
                    mSExcelPutWorkbookInEditMode["WorkbookName"] = ExpressionConverter.ConvertO(__workflow_mSExcelPutWorkbookInEditModeworkbookName);
                    mSExcelPutWorkbookInEditModepropCount++;
                }

                if (__workflow_mSExcelPutWorkbookInEditModeforce != null)
                {
                    if (__workflow_mSExcelPutWorkbookInEditModeforce != null)
                    {
                        mSExcelPutWorkbookInEditMode["Force"] = ExpressionConverter.ConvertO(__workflow_mSExcelPutWorkbookInEditModeforce);
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
                mSExcelPutWorkbookInEditMode["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSExcelPutWorkbookInEditModeworkflow);
                if (mSExcelPutWorkbookInEditModepropCount > 0)
                {
                    callPayload.Body = mSExcelPutWorkbookInEditMode;
                }

                return new ApiConnectionAction<MSExcelPutWorkbookInEditModeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelCreateWorkbookResponse> MSExcelCreateWorkbook(Expression<Func<string>> mSExcelCreateWorkbookworkflow, Expression<Func<int>> mSExcelCreateWorkbookhandle = null)
        {
            var __workflow_mSExcelCreateWorkbookworkflow = mSExcelCreateWorkbookworkflow == null ? null : WorkflowExpression.Compile(mSExcelCreateWorkbookworkflow);
            WorkflowExpression.Validate(__workflow_mSExcelCreateWorkbookworkflow, nameof(mSExcelCreateWorkbookworkflow), required: true);
            var __workflow_mSExcelCreateWorkbookhandle = mSExcelCreateWorkbookhandle == null ? null : WorkflowExpression.Compile(mSExcelCreateWorkbookhandle);
            WorkflowExpression.Validate(__workflow_mSExcelCreateWorkbookhandle, nameof(mSExcelCreateWorkbookhandle), required: false);
            return new DeferredBodyAction<MSExcelCreateWorkbookResponse>(() =>
            {
                var apiCallPath = "/MSExcel/CreateWorkbook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSExcelCreateWorkbook = new JObject();
                var mSExcelCreateWorkbookpropCount = 0;
                if (__workflow_mSExcelCreateWorkbookhandle != null)
                {
                    if (__workflow_mSExcelCreateWorkbookhandle != null)
                    {
                        mSExcelCreateWorkbook["Handle"] = ExpressionConverter.ConvertO(__workflow_mSExcelCreateWorkbookhandle);
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
                mSExcelCreateWorkbook["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSExcelCreateWorkbookworkflow);
                if (mSExcelCreateWorkbookpropCount > 0)
                {
                    callPayload.Body = mSExcelCreateWorkbook;
                }

                return new ApiConnectionAction<MSExcelCreateWorkbookResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelCloseWorkbook(Expression<Func<string>> mSExcelCloseWorkbookworkflow, Expression<Func<int>> mSExcelCloseWorkbookhandle = null, Expression<Func<string>> mSExcelCloseWorkbookworkbookName = null, Expression<Func<bool>> mSExcelCloseWorkbooksaveData = null)
        {
            var __workflow_mSExcelCloseWorkbookworkflow = mSExcelCloseWorkbookworkflow == null ? null : WorkflowExpression.Compile(mSExcelCloseWorkbookworkflow);
            WorkflowExpression.Validate(__workflow_mSExcelCloseWorkbookworkflow, nameof(mSExcelCloseWorkbookworkflow), required: true);
            var __workflow_mSExcelCloseWorkbookhandle = mSExcelCloseWorkbookhandle == null ? null : WorkflowExpression.Compile(mSExcelCloseWorkbookhandle);
            WorkflowExpression.Validate(__workflow_mSExcelCloseWorkbookhandle, nameof(mSExcelCloseWorkbookhandle), required: false);
            var __workflow_mSExcelCloseWorkbookworkbookName = mSExcelCloseWorkbookworkbookName == null ? null : WorkflowExpression.Compile(mSExcelCloseWorkbookworkbookName);
            WorkflowExpression.Validate(__workflow_mSExcelCloseWorkbookworkbookName, nameof(mSExcelCloseWorkbookworkbookName), required: false);
            var __workflow_mSExcelCloseWorkbooksaveData = mSExcelCloseWorkbooksaveData == null ? null : WorkflowExpression.Compile(mSExcelCloseWorkbooksaveData);
            WorkflowExpression.Validate(__workflow_mSExcelCloseWorkbooksaveData, nameof(mSExcelCloseWorkbooksaveData), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/MSExcel/CloseWorkbook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSExcelCloseWorkbook = new JObject();
                var mSExcelCloseWorkbookpropCount = 0;
                if (__workflow_mSExcelCloseWorkbookhandle != null)
                {
                    if (__workflow_mSExcelCloseWorkbookhandle != null)
                    {
                        mSExcelCloseWorkbook["Handle"] = ExpressionConverter.ConvertO(__workflow_mSExcelCloseWorkbookhandle);
                        mSExcelCloseWorkbookpropCount++;
                    }

                    mSExcelCloseWorkbookpropCount++;
                }
                else
                {
                    mSExcelCloseWorkbook["Handle"] = 0;
                    mSExcelCloseWorkbookpropCount++;
                }

                if (__workflow_mSExcelCloseWorkbookworkbookName != null)
                {
                    mSExcelCloseWorkbook["WorkbookName"] = ExpressionConverter.ConvertO(__workflow_mSExcelCloseWorkbookworkbookName);
                    mSExcelCloseWorkbookpropCount++;
                }

                if (__workflow_mSExcelCloseWorkbooksaveData != null)
                {
                    if (__workflow_mSExcelCloseWorkbooksaveData != null)
                    {
                        mSExcelCloseWorkbook["SaveData"] = ExpressionConverter.ConvertO(__workflow_mSExcelCloseWorkbooksaveData);
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
                mSExcelCloseWorkbook["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSExcelCloseWorkbookworkflow);
                if (mSExcelCloseWorkbookpropCount > 0)
                {
                    callPayload.Body = mSExcelCloseWorkbook;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelCloseCurrentWorkbook(Expression<Func<string>> mSExcelCloseCurrentWorkbookworkflow, Expression<Func<int>> mSExcelCloseCurrentWorkbookhandle = null)
        {
            var __workflow_mSExcelCloseCurrentWorkbookworkflow = mSExcelCloseCurrentWorkbookworkflow == null ? null : WorkflowExpression.Compile(mSExcelCloseCurrentWorkbookworkflow);
            WorkflowExpression.Validate(__workflow_mSExcelCloseCurrentWorkbookworkflow, nameof(mSExcelCloseCurrentWorkbookworkflow), required: true);
            var __workflow_mSExcelCloseCurrentWorkbookhandle = mSExcelCloseCurrentWorkbookhandle == null ? null : WorkflowExpression.Compile(mSExcelCloseCurrentWorkbookhandle);
            WorkflowExpression.Validate(__workflow_mSExcelCloseCurrentWorkbookhandle, nameof(mSExcelCloseCurrentWorkbookhandle), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/MSExcel/CloseCurrentWorkbook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSExcelCloseCurrentWorkbook = new JObject();
                var mSExcelCloseCurrentWorkbookpropCount = 0;
                if (__workflow_mSExcelCloseCurrentWorkbookhandle != null)
                {
                    if (__workflow_mSExcelCloseCurrentWorkbookhandle != null)
                    {
                        mSExcelCloseCurrentWorkbook["Handle"] = ExpressionConverter.ConvertO(__workflow_mSExcelCloseCurrentWorkbookhandle);
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
                mSExcelCloseCurrentWorkbook["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSExcelCloseCurrentWorkbookworkflow);
                if (mSExcelCloseCurrentWorkbookpropCount > 0)
                {
                    callPayload.Body = mSExcelCloseCurrentWorkbook;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelGoToCell(Expression<Func<string>> mSExcelGoToCellcellReference, Expression<Func<string>> mSExcelGoToCellworkflow, Expression<Func<int>> mSExcelGoToCellhandle = null, Expression<Func<string>> mSExcelGoToCellworkbookName = null, Expression<Func<string>> mSExcelGoToCellworksheetName = null)
        {
            var __workflow_mSExcelGoToCellcellReference = mSExcelGoToCellcellReference == null ? null : WorkflowExpression.Compile(mSExcelGoToCellcellReference);
            WorkflowExpression.Validate(__workflow_mSExcelGoToCellcellReference, nameof(mSExcelGoToCellcellReference), required: true);
            var __workflow_mSExcelGoToCellworkflow = mSExcelGoToCellworkflow == null ? null : WorkflowExpression.Compile(mSExcelGoToCellworkflow);
            WorkflowExpression.Validate(__workflow_mSExcelGoToCellworkflow, nameof(mSExcelGoToCellworkflow), required: true);
            var __workflow_mSExcelGoToCellhandle = mSExcelGoToCellhandle == null ? null : WorkflowExpression.Compile(mSExcelGoToCellhandle);
            WorkflowExpression.Validate(__workflow_mSExcelGoToCellhandle, nameof(mSExcelGoToCellhandle), required: false);
            var __workflow_mSExcelGoToCellworkbookName = mSExcelGoToCellworkbookName == null ? null : WorkflowExpression.Compile(mSExcelGoToCellworkbookName);
            WorkflowExpression.Validate(__workflow_mSExcelGoToCellworkbookName, nameof(mSExcelGoToCellworkbookName), required: false);
            var __workflow_mSExcelGoToCellworksheetName = mSExcelGoToCellworksheetName == null ? null : WorkflowExpression.Compile(mSExcelGoToCellworksheetName);
            WorkflowExpression.Validate(__workflow_mSExcelGoToCellworksheetName, nameof(mSExcelGoToCellworksheetName), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/MSExcel/GoToCell";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSExcelGoToCell = new JObject();
                var mSExcelGoToCellpropCount = 0;
                if (__workflow_mSExcelGoToCellhandle != null)
                {
                    if (__workflow_mSExcelGoToCellhandle != null)
                    {
                        mSExcelGoToCell["Handle"] = ExpressionConverter.ConvertO(__workflow_mSExcelGoToCellhandle);
                        mSExcelGoToCellpropCount++;
                    }

                    mSExcelGoToCellpropCount++;
                }
                else
                {
                    mSExcelGoToCell["Handle"] = 0;
                    mSExcelGoToCellpropCount++;
                }

                if (__workflow_mSExcelGoToCellworkbookName != null)
                {
                    mSExcelGoToCell["WorkbookName"] = ExpressionConverter.ConvertO(__workflow_mSExcelGoToCellworkbookName);
                    mSExcelGoToCellpropCount++;
                }

                if (__workflow_mSExcelGoToCellworksheetName != null)
                {
                    mSExcelGoToCell["WorksheetName"] = ExpressionConverter.ConvertO(__workflow_mSExcelGoToCellworksheetName);
                    mSExcelGoToCellpropCount++;
                }

                mSExcelGoToCellpropCount++;
                mSExcelGoToCell["CellReference"] = ExpressionConverter.ConvertO(__workflow_mSExcelGoToCellcellReference);
                mSExcelGoToCellpropCount++;
                mSExcelGoToCell["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSExcelGoToCellworkflow);
                if (mSExcelGoToCellpropCount > 0)
                {
                    callPayload.Body = mSExcelGoToCell;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetCellValueResponse> MSExcelGetCellValue(Expression<Func<string>> mSExcelGetCellValuecellReference, Expression<Func<string>> mSExcelGetCellValueworkflow, Expression<Func<int>> mSExcelGetCellValuehandle = null, Expression<Func<string>> mSExcelGetCellValueworkbookName = null, Expression<Func<string>> mSExcelGetCellValueworksheetName = null)
        {
            var __workflow_mSExcelGetCellValuecellReference = mSExcelGetCellValuecellReference == null ? null : WorkflowExpression.Compile(mSExcelGetCellValuecellReference);
            WorkflowExpression.Validate(__workflow_mSExcelGetCellValuecellReference, nameof(mSExcelGetCellValuecellReference), required: true);
            var __workflow_mSExcelGetCellValueworkflow = mSExcelGetCellValueworkflow == null ? null : WorkflowExpression.Compile(mSExcelGetCellValueworkflow);
            WorkflowExpression.Validate(__workflow_mSExcelGetCellValueworkflow, nameof(mSExcelGetCellValueworkflow), required: true);
            var __workflow_mSExcelGetCellValuehandle = mSExcelGetCellValuehandle == null ? null : WorkflowExpression.Compile(mSExcelGetCellValuehandle);
            WorkflowExpression.Validate(__workflow_mSExcelGetCellValuehandle, nameof(mSExcelGetCellValuehandle), required: false);
            var __workflow_mSExcelGetCellValueworkbookName = mSExcelGetCellValueworkbookName == null ? null : WorkflowExpression.Compile(mSExcelGetCellValueworkbookName);
            WorkflowExpression.Validate(__workflow_mSExcelGetCellValueworkbookName, nameof(mSExcelGetCellValueworkbookName), required: false);
            var __workflow_mSExcelGetCellValueworksheetName = mSExcelGetCellValueworksheetName == null ? null : WorkflowExpression.Compile(mSExcelGetCellValueworksheetName);
            WorkflowExpression.Validate(__workflow_mSExcelGetCellValueworksheetName, nameof(mSExcelGetCellValueworksheetName), required: false);
            return new DeferredBodyAction<MSExcelGetCellValueResponse>(() =>
            {
                var apiCallPath = "/MSExcel/GetCellValue";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSExcelGetCellValue = new JObject();
                var mSExcelGetCellValuepropCount = 0;
                if (__workflow_mSExcelGetCellValuehandle != null)
                {
                    if (__workflow_mSExcelGetCellValuehandle != null)
                    {
                        mSExcelGetCellValue["Handle"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetCellValuehandle);
                        mSExcelGetCellValuepropCount++;
                    }

                    mSExcelGetCellValuepropCount++;
                }
                else
                {
                    mSExcelGetCellValue["Handle"] = 0;
                    mSExcelGetCellValuepropCount++;
                }

                if (__workflow_mSExcelGetCellValueworkbookName != null)
                {
                    mSExcelGetCellValue["WorkbookName"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetCellValueworkbookName);
                    mSExcelGetCellValuepropCount++;
                }

                if (__workflow_mSExcelGetCellValueworksheetName != null)
                {
                    mSExcelGetCellValue["WorksheetName"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetCellValueworksheetName);
                    mSExcelGetCellValuepropCount++;
                }

                mSExcelGetCellValuepropCount++;
                mSExcelGetCellValue["CellReference"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetCellValuecellReference);
                mSExcelGetCellValuepropCount++;
                mSExcelGetCellValue["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetCellValueworkflow);
                if (mSExcelGetCellValuepropCount > 0)
                {
                    callPayload.Body = mSExcelGetCellValue;
                }

                return new ApiConnectionAction<MSExcelGetCellValueResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetCellValue2Response> MSExcelGetCellValue2(Expression<Func<string>> mSExcelGetCellValue2cellReference, Expression<Func<string>> mSExcelGetCellValue2workflow, Expression<Func<int>> mSExcelGetCellValue2handle = null, Expression<Func<string>> mSExcelGetCellValue2workbookName = null, Expression<Func<string>> mSExcelGetCellValue2worksheetName = null)
        {
            var __workflow_mSExcelGetCellValue2cellReference = mSExcelGetCellValue2cellReference == null ? null : WorkflowExpression.Compile(mSExcelGetCellValue2cellReference);
            WorkflowExpression.Validate(__workflow_mSExcelGetCellValue2cellReference, nameof(mSExcelGetCellValue2cellReference), required: true);
            var __workflow_mSExcelGetCellValue2workflow = mSExcelGetCellValue2workflow == null ? null : WorkflowExpression.Compile(mSExcelGetCellValue2workflow);
            WorkflowExpression.Validate(__workflow_mSExcelGetCellValue2workflow, nameof(mSExcelGetCellValue2workflow), required: true);
            var __workflow_mSExcelGetCellValue2handle = mSExcelGetCellValue2handle == null ? null : WorkflowExpression.Compile(mSExcelGetCellValue2handle);
            WorkflowExpression.Validate(__workflow_mSExcelGetCellValue2handle, nameof(mSExcelGetCellValue2handle), required: false);
            var __workflow_mSExcelGetCellValue2workbookName = mSExcelGetCellValue2workbookName == null ? null : WorkflowExpression.Compile(mSExcelGetCellValue2workbookName);
            WorkflowExpression.Validate(__workflow_mSExcelGetCellValue2workbookName, nameof(mSExcelGetCellValue2workbookName), required: false);
            var __workflow_mSExcelGetCellValue2worksheetName = mSExcelGetCellValue2worksheetName == null ? null : WorkflowExpression.Compile(mSExcelGetCellValue2worksheetName);
            WorkflowExpression.Validate(__workflow_mSExcelGetCellValue2worksheetName, nameof(mSExcelGetCellValue2worksheetName), required: false);
            return new DeferredBodyAction<MSExcelGetCellValue2Response>(() =>
            {
                var apiCallPath = "/MSExcel/GetCellValue2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSExcelGetCellValue2 = new JObject();
                var mSExcelGetCellValue2propCount = 0;
                if (__workflow_mSExcelGetCellValue2handle != null)
                {
                    if (__workflow_mSExcelGetCellValue2handle != null)
                    {
                        mSExcelGetCellValue2["Handle"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetCellValue2handle);
                        mSExcelGetCellValue2propCount++;
                    }

                    mSExcelGetCellValue2propCount++;
                }
                else
                {
                    mSExcelGetCellValue2["Handle"] = 0;
                    mSExcelGetCellValue2propCount++;
                }

                if (__workflow_mSExcelGetCellValue2workbookName != null)
                {
                    mSExcelGetCellValue2["WorkbookName"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetCellValue2workbookName);
                    mSExcelGetCellValue2propCount++;
                }

                if (__workflow_mSExcelGetCellValue2worksheetName != null)
                {
                    mSExcelGetCellValue2["WorksheetName"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetCellValue2worksheetName);
                    mSExcelGetCellValue2propCount++;
                }

                mSExcelGetCellValue2propCount++;
                mSExcelGetCellValue2["CellReference"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetCellValue2cellReference);
                mSExcelGetCellValue2propCount++;
                mSExcelGetCellValue2["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetCellValue2workflow);
                if (mSExcelGetCellValue2propCount > 0)
                {
                    callPayload.Body = mSExcelGetCellValue2;
                }

                return new ApiConnectionAction<MSExcelGetCellValue2Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetCellTextResponse> MSExcelGetCellText(Expression<Func<string>> mSExcelGetCellTextcellReference, Expression<Func<string>> mSExcelGetCellTextworkflow, Expression<Func<int>> mSExcelGetCellTexthandle = null, Expression<Func<string>> mSExcelGetCellTextworkbookName = null, Expression<Func<string>> mSExcelGetCellTextworksheetName = null)
        {
            var __workflow_mSExcelGetCellTextcellReference = mSExcelGetCellTextcellReference == null ? null : WorkflowExpression.Compile(mSExcelGetCellTextcellReference);
            WorkflowExpression.Validate(__workflow_mSExcelGetCellTextcellReference, nameof(mSExcelGetCellTextcellReference), required: true);
            var __workflow_mSExcelGetCellTextworkflow = mSExcelGetCellTextworkflow == null ? null : WorkflowExpression.Compile(mSExcelGetCellTextworkflow);
            WorkflowExpression.Validate(__workflow_mSExcelGetCellTextworkflow, nameof(mSExcelGetCellTextworkflow), required: true);
            var __workflow_mSExcelGetCellTexthandle = mSExcelGetCellTexthandle == null ? null : WorkflowExpression.Compile(mSExcelGetCellTexthandle);
            WorkflowExpression.Validate(__workflow_mSExcelGetCellTexthandle, nameof(mSExcelGetCellTexthandle), required: false);
            var __workflow_mSExcelGetCellTextworkbookName = mSExcelGetCellTextworkbookName == null ? null : WorkflowExpression.Compile(mSExcelGetCellTextworkbookName);
            WorkflowExpression.Validate(__workflow_mSExcelGetCellTextworkbookName, nameof(mSExcelGetCellTextworkbookName), required: false);
            var __workflow_mSExcelGetCellTextworksheetName = mSExcelGetCellTextworksheetName == null ? null : WorkflowExpression.Compile(mSExcelGetCellTextworksheetName);
            WorkflowExpression.Validate(__workflow_mSExcelGetCellTextworksheetName, nameof(mSExcelGetCellTextworksheetName), required: false);
            return new DeferredBodyAction<MSExcelGetCellTextResponse>(() =>
            {
                var apiCallPath = "/MSExcel/GetCellText";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSExcelGetCellText = new JObject();
                var mSExcelGetCellTextpropCount = 0;
                if (__workflow_mSExcelGetCellTexthandle != null)
                {
                    if (__workflow_mSExcelGetCellTexthandle != null)
                    {
                        mSExcelGetCellText["Handle"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetCellTexthandle);
                        mSExcelGetCellTextpropCount++;
                    }

                    mSExcelGetCellTextpropCount++;
                }
                else
                {
                    mSExcelGetCellText["Handle"] = 0;
                    mSExcelGetCellTextpropCount++;
                }

                if (__workflow_mSExcelGetCellTextworkbookName != null)
                {
                    mSExcelGetCellText["WorkbookName"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetCellTextworkbookName);
                    mSExcelGetCellTextpropCount++;
                }

                if (__workflow_mSExcelGetCellTextworksheetName != null)
                {
                    mSExcelGetCellText["WorksheetName"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetCellTextworksheetName);
                    mSExcelGetCellTextpropCount++;
                }

                mSExcelGetCellTextpropCount++;
                mSExcelGetCellText["CellReference"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetCellTextcellReference);
                mSExcelGetCellTextpropCount++;
                mSExcelGetCellText["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetCellTextworkflow);
                if (mSExcelGetCellTextpropCount > 0)
                {
                    callPayload.Body = mSExcelGetCellText;
                }

                return new ApiConnectionAction<MSExcelGetCellTextResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelSetCellValue(Expression<Func<string>> mSExcelSetCellValuecellReference, Expression<Func<string>> mSExcelSetCellValueworkflow, Expression<Func<int>> mSExcelSetCellValuehandle = null, Expression<Func<string>> mSExcelSetCellValueworkbookName = null, Expression<Func<string>> mSExcelSetCellValueworksheetName = null, Expression<Func<string>> mSExcelSetCellValuecellValue = null, Expression<Func<bool>> mSExcelSetCellValuecellValueContainsStoredPassword = null)
        {
            var __workflow_mSExcelSetCellValuecellReference = mSExcelSetCellValuecellReference == null ? null : WorkflowExpression.Compile(mSExcelSetCellValuecellReference);
            WorkflowExpression.Validate(__workflow_mSExcelSetCellValuecellReference, nameof(mSExcelSetCellValuecellReference), required: true);
            var __workflow_mSExcelSetCellValueworkflow = mSExcelSetCellValueworkflow == null ? null : WorkflowExpression.Compile(mSExcelSetCellValueworkflow);
            WorkflowExpression.Validate(__workflow_mSExcelSetCellValueworkflow, nameof(mSExcelSetCellValueworkflow), required: true);
            var __workflow_mSExcelSetCellValuehandle = mSExcelSetCellValuehandle == null ? null : WorkflowExpression.Compile(mSExcelSetCellValuehandle);
            WorkflowExpression.Validate(__workflow_mSExcelSetCellValuehandle, nameof(mSExcelSetCellValuehandle), required: false);
            var __workflow_mSExcelSetCellValueworkbookName = mSExcelSetCellValueworkbookName == null ? null : WorkflowExpression.Compile(mSExcelSetCellValueworkbookName);
            WorkflowExpression.Validate(__workflow_mSExcelSetCellValueworkbookName, nameof(mSExcelSetCellValueworkbookName), required: false);
            var __workflow_mSExcelSetCellValueworksheetName = mSExcelSetCellValueworksheetName == null ? null : WorkflowExpression.Compile(mSExcelSetCellValueworksheetName);
            WorkflowExpression.Validate(__workflow_mSExcelSetCellValueworksheetName, nameof(mSExcelSetCellValueworksheetName), required: false);
            var __workflow_mSExcelSetCellValuecellValue = mSExcelSetCellValuecellValue == null ? null : WorkflowExpression.Compile(mSExcelSetCellValuecellValue);
            WorkflowExpression.Validate(__workflow_mSExcelSetCellValuecellValue, nameof(mSExcelSetCellValuecellValue), required: false);
            var __workflow_mSExcelSetCellValuecellValueContainsStoredPassword = mSExcelSetCellValuecellValueContainsStoredPassword == null ? null : WorkflowExpression.Compile(mSExcelSetCellValuecellValueContainsStoredPassword);
            WorkflowExpression.Validate(__workflow_mSExcelSetCellValuecellValueContainsStoredPassword, nameof(mSExcelSetCellValuecellValueContainsStoredPassword), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/MSExcel/SetCellValue";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSExcelSetCellValue = new JObject();
                var mSExcelSetCellValuepropCount = 0;
                if (__workflow_mSExcelSetCellValuehandle != null)
                {
                    if (__workflow_mSExcelSetCellValuehandle != null)
                    {
                        mSExcelSetCellValue["Handle"] = ExpressionConverter.ConvertO(__workflow_mSExcelSetCellValuehandle);
                        mSExcelSetCellValuepropCount++;
                    }

                    mSExcelSetCellValuepropCount++;
                }
                else
                {
                    mSExcelSetCellValue["Handle"] = 0;
                    mSExcelSetCellValuepropCount++;
                }

                if (__workflow_mSExcelSetCellValueworkbookName != null)
                {
                    mSExcelSetCellValue["WorkbookName"] = ExpressionConverter.ConvertO(__workflow_mSExcelSetCellValueworkbookName);
                    mSExcelSetCellValuepropCount++;
                }

                if (__workflow_mSExcelSetCellValueworksheetName != null)
                {
                    mSExcelSetCellValue["WorksheetName"] = ExpressionConverter.ConvertO(__workflow_mSExcelSetCellValueworksheetName);
                    mSExcelSetCellValuepropCount++;
                }

                mSExcelSetCellValuepropCount++;
                mSExcelSetCellValue["CellReference"] = ExpressionConverter.ConvertO(__workflow_mSExcelSetCellValuecellReference);
                if (__workflow_mSExcelSetCellValuecellValue != null)
                {
                    mSExcelSetCellValue["CellValue"] = ExpressionConverter.ConvertO(__workflow_mSExcelSetCellValuecellValue);
                    mSExcelSetCellValuepropCount++;
                }

                if (__workflow_mSExcelSetCellValuecellValueContainsStoredPassword != null)
                {
                    if (__workflow_mSExcelSetCellValuecellValueContainsStoredPassword != null)
                    {
                        mSExcelSetCellValue["CellValueContainsStoredPassword"] = ExpressionConverter.ConvertO(__workflow_mSExcelSetCellValuecellValueContainsStoredPassword);
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
                mSExcelSetCellValue["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSExcelSetCellValueworkflow);
                if (mSExcelSetCellValuepropCount > 0)
                {
                    callPayload.Body = mSExcelSetCellValue;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelFindNextCellWithValueResponse> MSExcelFindNextCellWithValue(Expression<Func<mSExcelFindNextCellWithValuedirectionInput>> mSExcelFindNextCellWithValuedirection, Expression<Func<string>> mSExcelFindNextCellWithValuesearchValue, Expression<Func<string>> mSExcelFindNextCellWithValueworkflow, Expression<Func<int>> mSExcelFindNextCellWithValuehandle = null, Expression<Func<string>> mSExcelFindNextCellWithValueworkbookName = null, Expression<Func<string>> mSExcelFindNextCellWithValueworksheetName = null, Expression<Func<bool>> mSExcelFindNextCellWithValuecaseSensitive = null, Expression<Func<mSExcelFindNextCellWithValuecomparisonTypeInput>> mSExcelFindNextCellWithValuecomparisonType = null, Expression<Func<int>> mSExcelFindNextCellWithValuemaxCellsToSearch = null, Expression<Func<bool>> mSExcelFindNextCellWithValueactivateCell = null)
        {
            var __workflow_mSExcelFindNextCellWithValuedirection = mSExcelFindNextCellWithValuedirection == null ? null : WorkflowExpression.Compile(mSExcelFindNextCellWithValuedirection);
            WorkflowExpression.Validate(__workflow_mSExcelFindNextCellWithValuedirection, nameof(mSExcelFindNextCellWithValuedirection), required: true);
            var __workflow_mSExcelFindNextCellWithValuesearchValue = mSExcelFindNextCellWithValuesearchValue == null ? null : WorkflowExpression.Compile(mSExcelFindNextCellWithValuesearchValue);
            WorkflowExpression.Validate(__workflow_mSExcelFindNextCellWithValuesearchValue, nameof(mSExcelFindNextCellWithValuesearchValue), required: true);
            var __workflow_mSExcelFindNextCellWithValueworkflow = mSExcelFindNextCellWithValueworkflow == null ? null : WorkflowExpression.Compile(mSExcelFindNextCellWithValueworkflow);
            WorkflowExpression.Validate(__workflow_mSExcelFindNextCellWithValueworkflow, nameof(mSExcelFindNextCellWithValueworkflow), required: true);
            var __workflow_mSExcelFindNextCellWithValuehandle = mSExcelFindNextCellWithValuehandle == null ? null : WorkflowExpression.Compile(mSExcelFindNextCellWithValuehandle);
            WorkflowExpression.Validate(__workflow_mSExcelFindNextCellWithValuehandle, nameof(mSExcelFindNextCellWithValuehandle), required: false);
            var __workflow_mSExcelFindNextCellWithValueworkbookName = mSExcelFindNextCellWithValueworkbookName == null ? null : WorkflowExpression.Compile(mSExcelFindNextCellWithValueworkbookName);
            WorkflowExpression.Validate(__workflow_mSExcelFindNextCellWithValueworkbookName, nameof(mSExcelFindNextCellWithValueworkbookName), required: false);
            var __workflow_mSExcelFindNextCellWithValueworksheetName = mSExcelFindNextCellWithValueworksheetName == null ? null : WorkflowExpression.Compile(mSExcelFindNextCellWithValueworksheetName);
            WorkflowExpression.Validate(__workflow_mSExcelFindNextCellWithValueworksheetName, nameof(mSExcelFindNextCellWithValueworksheetName), required: false);
            var __workflow_mSExcelFindNextCellWithValuecaseSensitive = mSExcelFindNextCellWithValuecaseSensitive == null ? null : WorkflowExpression.Compile(mSExcelFindNextCellWithValuecaseSensitive);
            WorkflowExpression.Validate(__workflow_mSExcelFindNextCellWithValuecaseSensitive, nameof(mSExcelFindNextCellWithValuecaseSensitive), required: false);
            var __workflow_mSExcelFindNextCellWithValuecomparisonType = mSExcelFindNextCellWithValuecomparisonType == null ? null : WorkflowExpression.Compile(mSExcelFindNextCellWithValuecomparisonType);
            WorkflowExpression.Validate(__workflow_mSExcelFindNextCellWithValuecomparisonType, nameof(mSExcelFindNextCellWithValuecomparisonType), required: false);
            var __workflow_mSExcelFindNextCellWithValuemaxCellsToSearch = mSExcelFindNextCellWithValuemaxCellsToSearch == null ? null : WorkflowExpression.Compile(mSExcelFindNextCellWithValuemaxCellsToSearch);
            WorkflowExpression.Validate(__workflow_mSExcelFindNextCellWithValuemaxCellsToSearch, nameof(mSExcelFindNextCellWithValuemaxCellsToSearch), required: false);
            var __workflow_mSExcelFindNextCellWithValueactivateCell = mSExcelFindNextCellWithValueactivateCell == null ? null : WorkflowExpression.Compile(mSExcelFindNextCellWithValueactivateCell);
            WorkflowExpression.Validate(__workflow_mSExcelFindNextCellWithValueactivateCell, nameof(mSExcelFindNextCellWithValueactivateCell), required: false);
            return new DeferredBodyAction<MSExcelFindNextCellWithValueResponse>(() =>
            {
                var apiCallPath = "/MSExcel/FindNextCellWithValue";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSExcelFindNextCellWithValue = new JObject();
                var mSExcelFindNextCellWithValuepropCount = 0;
                if (__workflow_mSExcelFindNextCellWithValuehandle != null)
                {
                    if (__workflow_mSExcelFindNextCellWithValuehandle != null)
                    {
                        mSExcelFindNextCellWithValue["Handle"] = ExpressionConverter.ConvertO(__workflow_mSExcelFindNextCellWithValuehandle);
                        mSExcelFindNextCellWithValuepropCount++;
                    }

                    mSExcelFindNextCellWithValuepropCount++;
                }
                else
                {
                    mSExcelFindNextCellWithValue["Handle"] = 0;
                    mSExcelFindNextCellWithValuepropCount++;
                }

                if (__workflow_mSExcelFindNextCellWithValueworkbookName != null)
                {
                    mSExcelFindNextCellWithValue["WorkbookName"] = ExpressionConverter.ConvertO(__workflow_mSExcelFindNextCellWithValueworkbookName);
                    mSExcelFindNextCellWithValuepropCount++;
                }

                if (__workflow_mSExcelFindNextCellWithValueworksheetName != null)
                {
                    mSExcelFindNextCellWithValue["WorksheetName"] = ExpressionConverter.ConvertO(__workflow_mSExcelFindNextCellWithValueworksheetName);
                    mSExcelFindNextCellWithValuepropCount++;
                }

                mSExcelFindNextCellWithValuepropCount++;
                mSExcelFindNextCellWithValue["Direction"] = ExpressionConverter.ConvertO(__workflow_mSExcelFindNextCellWithValuedirection);
                mSExcelFindNextCellWithValuepropCount++;
                mSExcelFindNextCellWithValue["SearchValue"] = ExpressionConverter.ConvertO(__workflow_mSExcelFindNextCellWithValuesearchValue);
                if (__workflow_mSExcelFindNextCellWithValuecaseSensitive != null)
                {
                    if (__workflow_mSExcelFindNextCellWithValuecaseSensitive != null)
                    {
                        mSExcelFindNextCellWithValue["CaseSensitive"] = ExpressionConverter.ConvertO(__workflow_mSExcelFindNextCellWithValuecaseSensitive);
                        mSExcelFindNextCellWithValuepropCount++;
                    }

                    mSExcelFindNextCellWithValuepropCount++;
                }
                else
                {
                    mSExcelFindNextCellWithValue["CaseSensitive"] = false;
                    mSExcelFindNextCellWithValuepropCount++;
                }

                if (__workflow_mSExcelFindNextCellWithValuecomparisonType != null)
                {
                    mSExcelFindNextCellWithValue["ComparisonType"] = ExpressionConverter.ConvertO(__workflow_mSExcelFindNextCellWithValuecomparisonType);
                    mSExcelFindNextCellWithValuepropCount++;
                }

                if (__workflow_mSExcelFindNextCellWithValuemaxCellsToSearch != null)
                {
                    mSExcelFindNextCellWithValue["MaxCellsToSearch"] = ExpressionConverter.ConvertO(__workflow_mSExcelFindNextCellWithValuemaxCellsToSearch);
                    mSExcelFindNextCellWithValuepropCount++;
                }

                if (__workflow_mSExcelFindNextCellWithValueactivateCell != null)
                {
                    if (__workflow_mSExcelFindNextCellWithValueactivateCell != null)
                    {
                        mSExcelFindNextCellWithValue["ActivateCell"] = ExpressionConverter.ConvertO(__workflow_mSExcelFindNextCellWithValueactivateCell);
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
                mSExcelFindNextCellWithValue["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSExcelFindNextCellWithValueworkflow);
                if (mSExcelFindNextCellWithValuepropCount > 0)
                {
                    callPayload.Body = mSExcelFindNextCellWithValue;
                }

                return new ApiConnectionAction<MSExcelFindNextCellWithValueResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelFindNextEmptyCellResponse> MSExcelFindNextEmptyCell(Expression<Func<mSExcelFindNextEmptyCelldirectionInput>> mSExcelFindNextEmptyCelldirection, Expression<Func<string>> mSExcelFindNextEmptyCellworkflow, Expression<Func<int>> mSExcelFindNextEmptyCellhandle = null, Expression<Func<string>> mSExcelFindNextEmptyCellworkbookName = null, Expression<Func<string>> mSExcelFindNextEmptyCellworksheetName = null, Expression<Func<bool>> mSExcelFindNextEmptyCellactivateCell = null)
        {
            var __workflow_mSExcelFindNextEmptyCelldirection = mSExcelFindNextEmptyCelldirection == null ? null : WorkflowExpression.Compile(mSExcelFindNextEmptyCelldirection);
            WorkflowExpression.Validate(__workflow_mSExcelFindNextEmptyCelldirection, nameof(mSExcelFindNextEmptyCelldirection), required: true);
            var __workflow_mSExcelFindNextEmptyCellworkflow = mSExcelFindNextEmptyCellworkflow == null ? null : WorkflowExpression.Compile(mSExcelFindNextEmptyCellworkflow);
            WorkflowExpression.Validate(__workflow_mSExcelFindNextEmptyCellworkflow, nameof(mSExcelFindNextEmptyCellworkflow), required: true);
            var __workflow_mSExcelFindNextEmptyCellhandle = mSExcelFindNextEmptyCellhandle == null ? null : WorkflowExpression.Compile(mSExcelFindNextEmptyCellhandle);
            WorkflowExpression.Validate(__workflow_mSExcelFindNextEmptyCellhandle, nameof(mSExcelFindNextEmptyCellhandle), required: false);
            var __workflow_mSExcelFindNextEmptyCellworkbookName = mSExcelFindNextEmptyCellworkbookName == null ? null : WorkflowExpression.Compile(mSExcelFindNextEmptyCellworkbookName);
            WorkflowExpression.Validate(__workflow_mSExcelFindNextEmptyCellworkbookName, nameof(mSExcelFindNextEmptyCellworkbookName), required: false);
            var __workflow_mSExcelFindNextEmptyCellworksheetName = mSExcelFindNextEmptyCellworksheetName == null ? null : WorkflowExpression.Compile(mSExcelFindNextEmptyCellworksheetName);
            WorkflowExpression.Validate(__workflow_mSExcelFindNextEmptyCellworksheetName, nameof(mSExcelFindNextEmptyCellworksheetName), required: false);
            var __workflow_mSExcelFindNextEmptyCellactivateCell = mSExcelFindNextEmptyCellactivateCell == null ? null : WorkflowExpression.Compile(mSExcelFindNextEmptyCellactivateCell);
            WorkflowExpression.Validate(__workflow_mSExcelFindNextEmptyCellactivateCell, nameof(mSExcelFindNextEmptyCellactivateCell), required: false);
            return new DeferredBodyAction<MSExcelFindNextEmptyCellResponse>(() =>
            {
                var apiCallPath = "/MSExcel/FindNextEmptyCell";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSExcelFindNextEmptyCell = new JObject();
                var mSExcelFindNextEmptyCellpropCount = 0;
                if (__workflow_mSExcelFindNextEmptyCellhandle != null)
                {
                    if (__workflow_mSExcelFindNextEmptyCellhandle != null)
                    {
                        mSExcelFindNextEmptyCell["Handle"] = ExpressionConverter.ConvertO(__workflow_mSExcelFindNextEmptyCellhandle);
                        mSExcelFindNextEmptyCellpropCount++;
                    }

                    mSExcelFindNextEmptyCellpropCount++;
                }
                else
                {
                    mSExcelFindNextEmptyCell["Handle"] = 0;
                    mSExcelFindNextEmptyCellpropCount++;
                }

                if (__workflow_mSExcelFindNextEmptyCellworkbookName != null)
                {
                    mSExcelFindNextEmptyCell["WorkbookName"] = ExpressionConverter.ConvertO(__workflow_mSExcelFindNextEmptyCellworkbookName);
                    mSExcelFindNextEmptyCellpropCount++;
                }

                if (__workflow_mSExcelFindNextEmptyCellworksheetName != null)
                {
                    mSExcelFindNextEmptyCell["WorksheetName"] = ExpressionConverter.ConvertO(__workflow_mSExcelFindNextEmptyCellworksheetName);
                    mSExcelFindNextEmptyCellpropCount++;
                }

                mSExcelFindNextEmptyCellpropCount++;
                mSExcelFindNextEmptyCell["Direction"] = ExpressionConverter.ConvertO(__workflow_mSExcelFindNextEmptyCelldirection);
                if (__workflow_mSExcelFindNextEmptyCellactivateCell != null)
                {
                    if (__workflow_mSExcelFindNextEmptyCellactivateCell != null)
                    {
                        mSExcelFindNextEmptyCell["ActivateCell"] = ExpressionConverter.ConvertO(__workflow_mSExcelFindNextEmptyCellactivateCell);
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
                mSExcelFindNextEmptyCell["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSExcelFindNextEmptyCellworkflow);
                if (mSExcelFindNextEmptyCellpropCount > 0)
                {
                    callPayload.Body = mSExcelFindNextEmptyCell;
                }

                return new ApiConnectionAction<MSExcelFindNextEmptyCellResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGotoNextEmptyCellLeftResponse> MSExcelGotoNextEmptyCellLeft(Expression<Func<string>> mSExcelGotoNextEmptyCellLeftworkflow, Expression<Func<int>> mSExcelGotoNextEmptyCellLefthandle = null, Expression<Func<string>> mSExcelGotoNextEmptyCellLeftworkbookName = null, Expression<Func<string>> mSExcelGotoNextEmptyCellLeftworksheetName = null)
        {
            var __workflow_mSExcelGotoNextEmptyCellLeftworkflow = mSExcelGotoNextEmptyCellLeftworkflow == null ? null : WorkflowExpression.Compile(mSExcelGotoNextEmptyCellLeftworkflow);
            WorkflowExpression.Validate(__workflow_mSExcelGotoNextEmptyCellLeftworkflow, nameof(mSExcelGotoNextEmptyCellLeftworkflow), required: true);
            var __workflow_mSExcelGotoNextEmptyCellLefthandle = mSExcelGotoNextEmptyCellLefthandle == null ? null : WorkflowExpression.Compile(mSExcelGotoNextEmptyCellLefthandle);
            WorkflowExpression.Validate(__workflow_mSExcelGotoNextEmptyCellLefthandle, nameof(mSExcelGotoNextEmptyCellLefthandle), required: false);
            var __workflow_mSExcelGotoNextEmptyCellLeftworkbookName = mSExcelGotoNextEmptyCellLeftworkbookName == null ? null : WorkflowExpression.Compile(mSExcelGotoNextEmptyCellLeftworkbookName);
            WorkflowExpression.Validate(__workflow_mSExcelGotoNextEmptyCellLeftworkbookName, nameof(mSExcelGotoNextEmptyCellLeftworkbookName), required: false);
            var __workflow_mSExcelGotoNextEmptyCellLeftworksheetName = mSExcelGotoNextEmptyCellLeftworksheetName == null ? null : WorkflowExpression.Compile(mSExcelGotoNextEmptyCellLeftworksheetName);
            WorkflowExpression.Validate(__workflow_mSExcelGotoNextEmptyCellLeftworksheetName, nameof(mSExcelGotoNextEmptyCellLeftworksheetName), required: false);
            return new DeferredBodyAction<MSExcelGotoNextEmptyCellLeftResponse>(() =>
            {
                var apiCallPath = "/MSExcel/GotoNextEmptyCellLeft";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSExcelGotoNextEmptyCellLeft = new JObject();
                var mSExcelGotoNextEmptyCellLeftpropCount = 0;
                if (__workflow_mSExcelGotoNextEmptyCellLefthandle != null)
                {
                    if (__workflow_mSExcelGotoNextEmptyCellLefthandle != null)
                    {
                        mSExcelGotoNextEmptyCellLeft["Handle"] = ExpressionConverter.ConvertO(__workflow_mSExcelGotoNextEmptyCellLefthandle);
                        mSExcelGotoNextEmptyCellLeftpropCount++;
                    }

                    mSExcelGotoNextEmptyCellLeftpropCount++;
                }
                else
                {
                    mSExcelGotoNextEmptyCellLeft["Handle"] = 0;
                    mSExcelGotoNextEmptyCellLeftpropCount++;
                }

                if (__workflow_mSExcelGotoNextEmptyCellLeftworkbookName != null)
                {
                    mSExcelGotoNextEmptyCellLeft["WorkbookName"] = ExpressionConverter.ConvertO(__workflow_mSExcelGotoNextEmptyCellLeftworkbookName);
                    mSExcelGotoNextEmptyCellLeftpropCount++;
                }

                if (__workflow_mSExcelGotoNextEmptyCellLeftworksheetName != null)
                {
                    mSExcelGotoNextEmptyCellLeft["WorksheetName"] = ExpressionConverter.ConvertO(__workflow_mSExcelGotoNextEmptyCellLeftworksheetName);
                    mSExcelGotoNextEmptyCellLeftpropCount++;
                }

                mSExcelGotoNextEmptyCellLeftpropCount++;
                mSExcelGotoNextEmptyCellLeft["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSExcelGotoNextEmptyCellLeftworkflow);
                if (mSExcelGotoNextEmptyCellLeftpropCount > 0)
                {
                    callPayload.Body = mSExcelGotoNextEmptyCellLeft;
                }

                return new ApiConnectionAction<MSExcelGotoNextEmptyCellLeftResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGotoNextEmptyCellRightResponse> MSExcelGotoNextEmptyCellRight(Expression<Func<string>> mSExcelGotoNextEmptyCellRightworkflow, Expression<Func<int>> mSExcelGotoNextEmptyCellRighthandle = null, Expression<Func<string>> mSExcelGotoNextEmptyCellRightworkbookName = null, Expression<Func<string>> mSExcelGotoNextEmptyCellRightworksheetName = null)
        {
            var __workflow_mSExcelGotoNextEmptyCellRightworkflow = mSExcelGotoNextEmptyCellRightworkflow == null ? null : WorkflowExpression.Compile(mSExcelGotoNextEmptyCellRightworkflow);
            WorkflowExpression.Validate(__workflow_mSExcelGotoNextEmptyCellRightworkflow, nameof(mSExcelGotoNextEmptyCellRightworkflow), required: true);
            var __workflow_mSExcelGotoNextEmptyCellRighthandle = mSExcelGotoNextEmptyCellRighthandle == null ? null : WorkflowExpression.Compile(mSExcelGotoNextEmptyCellRighthandle);
            WorkflowExpression.Validate(__workflow_mSExcelGotoNextEmptyCellRighthandle, nameof(mSExcelGotoNextEmptyCellRighthandle), required: false);
            var __workflow_mSExcelGotoNextEmptyCellRightworkbookName = mSExcelGotoNextEmptyCellRightworkbookName == null ? null : WorkflowExpression.Compile(mSExcelGotoNextEmptyCellRightworkbookName);
            WorkflowExpression.Validate(__workflow_mSExcelGotoNextEmptyCellRightworkbookName, nameof(mSExcelGotoNextEmptyCellRightworkbookName), required: false);
            var __workflow_mSExcelGotoNextEmptyCellRightworksheetName = mSExcelGotoNextEmptyCellRightworksheetName == null ? null : WorkflowExpression.Compile(mSExcelGotoNextEmptyCellRightworksheetName);
            WorkflowExpression.Validate(__workflow_mSExcelGotoNextEmptyCellRightworksheetName, nameof(mSExcelGotoNextEmptyCellRightworksheetName), required: false);
            return new DeferredBodyAction<MSExcelGotoNextEmptyCellRightResponse>(() =>
            {
                var apiCallPath = "/MSExcel/GotoNextEmptyCellRight";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSExcelGotoNextEmptyCellRight = new JObject();
                var mSExcelGotoNextEmptyCellRightpropCount = 0;
                if (__workflow_mSExcelGotoNextEmptyCellRighthandle != null)
                {
                    if (__workflow_mSExcelGotoNextEmptyCellRighthandle != null)
                    {
                        mSExcelGotoNextEmptyCellRight["Handle"] = ExpressionConverter.ConvertO(__workflow_mSExcelGotoNextEmptyCellRighthandle);
                        mSExcelGotoNextEmptyCellRightpropCount++;
                    }

                    mSExcelGotoNextEmptyCellRightpropCount++;
                }
                else
                {
                    mSExcelGotoNextEmptyCellRight["Handle"] = 0;
                    mSExcelGotoNextEmptyCellRightpropCount++;
                }

                if (__workflow_mSExcelGotoNextEmptyCellRightworkbookName != null)
                {
                    mSExcelGotoNextEmptyCellRight["WorkbookName"] = ExpressionConverter.ConvertO(__workflow_mSExcelGotoNextEmptyCellRightworkbookName);
                    mSExcelGotoNextEmptyCellRightpropCount++;
                }

                if (__workflow_mSExcelGotoNextEmptyCellRightworksheetName != null)
                {
                    mSExcelGotoNextEmptyCellRight["WorksheetName"] = ExpressionConverter.ConvertO(__workflow_mSExcelGotoNextEmptyCellRightworksheetName);
                    mSExcelGotoNextEmptyCellRightpropCount++;
                }

                mSExcelGotoNextEmptyCellRightpropCount++;
                mSExcelGotoNextEmptyCellRight["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSExcelGotoNextEmptyCellRightworkflow);
                if (mSExcelGotoNextEmptyCellRightpropCount > 0)
                {
                    callPayload.Body = mSExcelGotoNextEmptyCellRight;
                }

                return new ApiConnectionAction<MSExcelGotoNextEmptyCellRightResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGotoNextEmptyCellUpResponse> MSExcelGotoNextEmptyCellUp(Expression<Func<string>> mSExcelGotoNextEmptyCellUpworkflow, Expression<Func<int>> mSExcelGotoNextEmptyCellUphandle = null, Expression<Func<string>> mSExcelGotoNextEmptyCellUpworkbookName = null, Expression<Func<string>> mSExcelGotoNextEmptyCellUpworksheetName = null)
        {
            var __workflow_mSExcelGotoNextEmptyCellUpworkflow = mSExcelGotoNextEmptyCellUpworkflow == null ? null : WorkflowExpression.Compile(mSExcelGotoNextEmptyCellUpworkflow);
            WorkflowExpression.Validate(__workflow_mSExcelGotoNextEmptyCellUpworkflow, nameof(mSExcelGotoNextEmptyCellUpworkflow), required: true);
            var __workflow_mSExcelGotoNextEmptyCellUphandle = mSExcelGotoNextEmptyCellUphandle == null ? null : WorkflowExpression.Compile(mSExcelGotoNextEmptyCellUphandle);
            WorkflowExpression.Validate(__workflow_mSExcelGotoNextEmptyCellUphandle, nameof(mSExcelGotoNextEmptyCellUphandle), required: false);
            var __workflow_mSExcelGotoNextEmptyCellUpworkbookName = mSExcelGotoNextEmptyCellUpworkbookName == null ? null : WorkflowExpression.Compile(mSExcelGotoNextEmptyCellUpworkbookName);
            WorkflowExpression.Validate(__workflow_mSExcelGotoNextEmptyCellUpworkbookName, nameof(mSExcelGotoNextEmptyCellUpworkbookName), required: false);
            var __workflow_mSExcelGotoNextEmptyCellUpworksheetName = mSExcelGotoNextEmptyCellUpworksheetName == null ? null : WorkflowExpression.Compile(mSExcelGotoNextEmptyCellUpworksheetName);
            WorkflowExpression.Validate(__workflow_mSExcelGotoNextEmptyCellUpworksheetName, nameof(mSExcelGotoNextEmptyCellUpworksheetName), required: false);
            return new DeferredBodyAction<MSExcelGotoNextEmptyCellUpResponse>(() =>
            {
                var apiCallPath = "/MSExcel/GotoNextEmptyCellUp";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSExcelGotoNextEmptyCellUp = new JObject();
                var mSExcelGotoNextEmptyCellUppropCount = 0;
                if (__workflow_mSExcelGotoNextEmptyCellUphandle != null)
                {
                    if (__workflow_mSExcelGotoNextEmptyCellUphandle != null)
                    {
                        mSExcelGotoNextEmptyCellUp["Handle"] = ExpressionConverter.ConvertO(__workflow_mSExcelGotoNextEmptyCellUphandle);
                        mSExcelGotoNextEmptyCellUppropCount++;
                    }

                    mSExcelGotoNextEmptyCellUppropCount++;
                }
                else
                {
                    mSExcelGotoNextEmptyCellUp["Handle"] = 0;
                    mSExcelGotoNextEmptyCellUppropCount++;
                }

                if (__workflow_mSExcelGotoNextEmptyCellUpworkbookName != null)
                {
                    mSExcelGotoNextEmptyCellUp["WorkbookName"] = ExpressionConverter.ConvertO(__workflow_mSExcelGotoNextEmptyCellUpworkbookName);
                    mSExcelGotoNextEmptyCellUppropCount++;
                }

                if (__workflow_mSExcelGotoNextEmptyCellUpworksheetName != null)
                {
                    mSExcelGotoNextEmptyCellUp["WorksheetName"] = ExpressionConverter.ConvertO(__workflow_mSExcelGotoNextEmptyCellUpworksheetName);
                    mSExcelGotoNextEmptyCellUppropCount++;
                }

                mSExcelGotoNextEmptyCellUppropCount++;
                mSExcelGotoNextEmptyCellUp["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSExcelGotoNextEmptyCellUpworkflow);
                if (mSExcelGotoNextEmptyCellUppropCount > 0)
                {
                    callPayload.Body = mSExcelGotoNextEmptyCellUp;
                }

                return new ApiConnectionAction<MSExcelGotoNextEmptyCellUpResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGotoNextEmptyCellDownResponse> MSExcelGotoNextEmptyCellDown(Expression<Func<string>> mSExcelGotoNextEmptyCellDownworkflow, Expression<Func<int>> mSExcelGotoNextEmptyCellDownhandle = null, Expression<Func<string>> mSExcelGotoNextEmptyCellDownworkbookName = null, Expression<Func<string>> mSExcelGotoNextEmptyCellDownworksheetName = null)
        {
            var __workflow_mSExcelGotoNextEmptyCellDownworkflow = mSExcelGotoNextEmptyCellDownworkflow == null ? null : WorkflowExpression.Compile(mSExcelGotoNextEmptyCellDownworkflow);
            WorkflowExpression.Validate(__workflow_mSExcelGotoNextEmptyCellDownworkflow, nameof(mSExcelGotoNextEmptyCellDownworkflow), required: true);
            var __workflow_mSExcelGotoNextEmptyCellDownhandle = mSExcelGotoNextEmptyCellDownhandle == null ? null : WorkflowExpression.Compile(mSExcelGotoNextEmptyCellDownhandle);
            WorkflowExpression.Validate(__workflow_mSExcelGotoNextEmptyCellDownhandle, nameof(mSExcelGotoNextEmptyCellDownhandle), required: false);
            var __workflow_mSExcelGotoNextEmptyCellDownworkbookName = mSExcelGotoNextEmptyCellDownworkbookName == null ? null : WorkflowExpression.Compile(mSExcelGotoNextEmptyCellDownworkbookName);
            WorkflowExpression.Validate(__workflow_mSExcelGotoNextEmptyCellDownworkbookName, nameof(mSExcelGotoNextEmptyCellDownworkbookName), required: false);
            var __workflow_mSExcelGotoNextEmptyCellDownworksheetName = mSExcelGotoNextEmptyCellDownworksheetName == null ? null : WorkflowExpression.Compile(mSExcelGotoNextEmptyCellDownworksheetName);
            WorkflowExpression.Validate(__workflow_mSExcelGotoNextEmptyCellDownworksheetName, nameof(mSExcelGotoNextEmptyCellDownworksheetName), required: false);
            return new DeferredBodyAction<MSExcelGotoNextEmptyCellDownResponse>(() =>
            {
                var apiCallPath = "/MSExcel/GotoNextEmptyCellDown";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSExcelGotoNextEmptyCellDown = new JObject();
                var mSExcelGotoNextEmptyCellDownpropCount = 0;
                if (__workflow_mSExcelGotoNextEmptyCellDownhandle != null)
                {
                    if (__workflow_mSExcelGotoNextEmptyCellDownhandle != null)
                    {
                        mSExcelGotoNextEmptyCellDown["Handle"] = ExpressionConverter.ConvertO(__workflow_mSExcelGotoNextEmptyCellDownhandle);
                        mSExcelGotoNextEmptyCellDownpropCount++;
                    }

                    mSExcelGotoNextEmptyCellDownpropCount++;
                }
                else
                {
                    mSExcelGotoNextEmptyCellDown["Handle"] = 0;
                    mSExcelGotoNextEmptyCellDownpropCount++;
                }

                if (__workflow_mSExcelGotoNextEmptyCellDownworkbookName != null)
                {
                    mSExcelGotoNextEmptyCellDown["WorkbookName"] = ExpressionConverter.ConvertO(__workflow_mSExcelGotoNextEmptyCellDownworkbookName);
                    mSExcelGotoNextEmptyCellDownpropCount++;
                }

                if (__workflow_mSExcelGotoNextEmptyCellDownworksheetName != null)
                {
                    mSExcelGotoNextEmptyCellDown["WorksheetName"] = ExpressionConverter.ConvertO(__workflow_mSExcelGotoNextEmptyCellDownworksheetName);
                    mSExcelGotoNextEmptyCellDownpropCount++;
                }

                mSExcelGotoNextEmptyCellDownpropCount++;
                mSExcelGotoNextEmptyCellDown["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSExcelGotoNextEmptyCellDownworkflow);
                if (mSExcelGotoNextEmptyCellDownpropCount > 0)
                {
                    callPayload.Body = mSExcelGotoNextEmptyCellDown;
                }

                return new ApiConnectionAction<MSExcelGotoNextEmptyCellDownResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelSaveWorkbookResponse> MSExcelSaveWorkbook(Expression<Func<string>> mSExcelSaveWorkbookworkflow, Expression<Func<int>> mSExcelSaveWorkbookhandle = null, Expression<Func<string>> mSExcelSaveWorkbookworkbookName = null)
        {
            var __workflow_mSExcelSaveWorkbookworkflow = mSExcelSaveWorkbookworkflow == null ? null : WorkflowExpression.Compile(mSExcelSaveWorkbookworkflow);
            WorkflowExpression.Validate(__workflow_mSExcelSaveWorkbookworkflow, nameof(mSExcelSaveWorkbookworkflow), required: true);
            var __workflow_mSExcelSaveWorkbookhandle = mSExcelSaveWorkbookhandle == null ? null : WorkflowExpression.Compile(mSExcelSaveWorkbookhandle);
            WorkflowExpression.Validate(__workflow_mSExcelSaveWorkbookhandle, nameof(mSExcelSaveWorkbookhandle), required: false);
            var __workflow_mSExcelSaveWorkbookworkbookName = mSExcelSaveWorkbookworkbookName == null ? null : WorkflowExpression.Compile(mSExcelSaveWorkbookworkbookName);
            WorkflowExpression.Validate(__workflow_mSExcelSaveWorkbookworkbookName, nameof(mSExcelSaveWorkbookworkbookName), required: false);
            return new DeferredBodyAction<MSExcelSaveWorkbookResponse>(() =>
            {
                var apiCallPath = "/MSExcel/SaveWorkbook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSExcelSaveWorkbook = new JObject();
                var mSExcelSaveWorkbookpropCount = 0;
                if (__workflow_mSExcelSaveWorkbookhandle != null)
                {
                    if (__workflow_mSExcelSaveWorkbookhandle != null)
                    {
                        mSExcelSaveWorkbook["Handle"] = ExpressionConverter.ConvertO(__workflow_mSExcelSaveWorkbookhandle);
                        mSExcelSaveWorkbookpropCount++;
                    }

                    mSExcelSaveWorkbookpropCount++;
                }
                else
                {
                    mSExcelSaveWorkbook["Handle"] = 0;
                    mSExcelSaveWorkbookpropCount++;
                }

                if (__workflow_mSExcelSaveWorkbookworkbookName != null)
                {
                    mSExcelSaveWorkbook["WorkbookName"] = ExpressionConverter.ConvertO(__workflow_mSExcelSaveWorkbookworkbookName);
                    mSExcelSaveWorkbookpropCount++;
                }

                mSExcelSaveWorkbookpropCount++;
                mSExcelSaveWorkbook["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSExcelSaveWorkbookworkflow);
                if (mSExcelSaveWorkbookpropCount > 0)
                {
                    callPayload.Body = mSExcelSaveWorkbook;
                }

                return new ApiConnectionAction<MSExcelSaveWorkbookResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelSaveWorkbookAsResponse> MSExcelSaveWorkbookAs(Expression<Func<string>> mSExcelSaveWorkbookAssaveFilename, Expression<Func<string>> mSExcelSaveWorkbookAsworkflow, Expression<Func<int>> mSExcelSaveWorkbookAshandle = null, Expression<Func<string>> mSExcelSaveWorkbookAsworkbookName = null, Expression<Func<bool>> mSExcelSaveWorkbookAsdeleteExistingSaveFilename = null, Expression<Func<mSExcelSaveWorkbookAsexcelFileFormatInput>> mSExcelSaveWorkbookAsexcelFileFormat = null)
        {
            var __workflow_mSExcelSaveWorkbookAssaveFilename = mSExcelSaveWorkbookAssaveFilename == null ? null : WorkflowExpression.Compile(mSExcelSaveWorkbookAssaveFilename);
            WorkflowExpression.Validate(__workflow_mSExcelSaveWorkbookAssaveFilename, nameof(mSExcelSaveWorkbookAssaveFilename), required: true);
            var __workflow_mSExcelSaveWorkbookAsworkflow = mSExcelSaveWorkbookAsworkflow == null ? null : WorkflowExpression.Compile(mSExcelSaveWorkbookAsworkflow);
            WorkflowExpression.Validate(__workflow_mSExcelSaveWorkbookAsworkflow, nameof(mSExcelSaveWorkbookAsworkflow), required: true);
            var __workflow_mSExcelSaveWorkbookAshandle = mSExcelSaveWorkbookAshandle == null ? null : WorkflowExpression.Compile(mSExcelSaveWorkbookAshandle);
            WorkflowExpression.Validate(__workflow_mSExcelSaveWorkbookAshandle, nameof(mSExcelSaveWorkbookAshandle), required: false);
            var __workflow_mSExcelSaveWorkbookAsworkbookName = mSExcelSaveWorkbookAsworkbookName == null ? null : WorkflowExpression.Compile(mSExcelSaveWorkbookAsworkbookName);
            WorkflowExpression.Validate(__workflow_mSExcelSaveWorkbookAsworkbookName, nameof(mSExcelSaveWorkbookAsworkbookName), required: false);
            var __workflow_mSExcelSaveWorkbookAsdeleteExistingSaveFilename = mSExcelSaveWorkbookAsdeleteExistingSaveFilename == null ? null : WorkflowExpression.Compile(mSExcelSaveWorkbookAsdeleteExistingSaveFilename);
            WorkflowExpression.Validate(__workflow_mSExcelSaveWorkbookAsdeleteExistingSaveFilename, nameof(mSExcelSaveWorkbookAsdeleteExistingSaveFilename), required: false);
            var __workflow_mSExcelSaveWorkbookAsexcelFileFormat = mSExcelSaveWorkbookAsexcelFileFormat == null ? null : WorkflowExpression.Compile(mSExcelSaveWorkbookAsexcelFileFormat);
            WorkflowExpression.Validate(__workflow_mSExcelSaveWorkbookAsexcelFileFormat, nameof(mSExcelSaveWorkbookAsexcelFileFormat), required: false);
            return new DeferredBodyAction<MSExcelSaveWorkbookAsResponse>(() =>
            {
                var apiCallPath = "/MSExcel/SaveWorkbookAs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSExcelSaveWorkbookAs = new JObject();
                var mSExcelSaveWorkbookAspropCount = 0;
                if (__workflow_mSExcelSaveWorkbookAshandle != null)
                {
                    if (__workflow_mSExcelSaveWorkbookAshandle != null)
                    {
                        mSExcelSaveWorkbookAs["Handle"] = ExpressionConverter.ConvertO(__workflow_mSExcelSaveWorkbookAshandle);
                        mSExcelSaveWorkbookAspropCount++;
                    }

                    mSExcelSaveWorkbookAspropCount++;
                }
                else
                {
                    mSExcelSaveWorkbookAs["Handle"] = 0;
                    mSExcelSaveWorkbookAspropCount++;
                }

                if (__workflow_mSExcelSaveWorkbookAsworkbookName != null)
                {
                    mSExcelSaveWorkbookAs["WorkbookName"] = ExpressionConverter.ConvertO(__workflow_mSExcelSaveWorkbookAsworkbookName);
                    mSExcelSaveWorkbookAspropCount++;
                }

                mSExcelSaveWorkbookAspropCount++;
                mSExcelSaveWorkbookAs["SaveFilename"] = ExpressionConverter.ConvertO(__workflow_mSExcelSaveWorkbookAssaveFilename);
                if (__workflow_mSExcelSaveWorkbookAsdeleteExistingSaveFilename != null)
                {
                    if (__workflow_mSExcelSaveWorkbookAsdeleteExistingSaveFilename != null)
                    {
                        mSExcelSaveWorkbookAs["DeleteExistingSaveFilename"] = ExpressionConverter.ConvertO(__workflow_mSExcelSaveWorkbookAsdeleteExistingSaveFilename);
                        mSExcelSaveWorkbookAspropCount++;
                    }

                    mSExcelSaveWorkbookAspropCount++;
                }
                else
                {
                    mSExcelSaveWorkbookAs["DeleteExistingSaveFilename"] = false;
                    mSExcelSaveWorkbookAspropCount++;
                }

                if (__workflow_mSExcelSaveWorkbookAsexcelFileFormat != null)
                {
                    if (__workflow_mSExcelSaveWorkbookAsexcelFileFormat != null)
                    {
                        mSExcelSaveWorkbookAs["ExcelFileFormat"] = ExpressionConverter.ConvertO(__workflow_mSExcelSaveWorkbookAsexcelFileFormat);
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
                mSExcelSaveWorkbookAs["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSExcelSaveWorkbookAsworkflow);
                if (mSExcelSaveWorkbookAspropCount > 0)
                {
                    callPayload.Body = mSExcelSaveWorkbookAs;
                }

                return new ApiConnectionAction<MSExcelSaveWorkbookAsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelSaveWorkbookAsCSVResponse> MSExcelSaveWorkbookAsCSV(Expression<Func<string>> mSExcelSaveWorkbookAsCSVsaveFilename, Expression<Func<string>> mSExcelSaveWorkbookAsCSVworkflow, Expression<Func<int>> mSExcelSaveWorkbookAsCSVhandle = null, Expression<Func<string>> mSExcelSaveWorkbookAsCSVworkbookName = null, Expression<Func<bool>> mSExcelSaveWorkbookAsCSVdeleteExistingSaveFilename = null)
        {
            var __workflow_mSExcelSaveWorkbookAsCSVsaveFilename = mSExcelSaveWorkbookAsCSVsaveFilename == null ? null : WorkflowExpression.Compile(mSExcelSaveWorkbookAsCSVsaveFilename);
            WorkflowExpression.Validate(__workflow_mSExcelSaveWorkbookAsCSVsaveFilename, nameof(mSExcelSaveWorkbookAsCSVsaveFilename), required: true);
            var __workflow_mSExcelSaveWorkbookAsCSVworkflow = mSExcelSaveWorkbookAsCSVworkflow == null ? null : WorkflowExpression.Compile(mSExcelSaveWorkbookAsCSVworkflow);
            WorkflowExpression.Validate(__workflow_mSExcelSaveWorkbookAsCSVworkflow, nameof(mSExcelSaveWorkbookAsCSVworkflow), required: true);
            var __workflow_mSExcelSaveWorkbookAsCSVhandle = mSExcelSaveWorkbookAsCSVhandle == null ? null : WorkflowExpression.Compile(mSExcelSaveWorkbookAsCSVhandle);
            WorkflowExpression.Validate(__workflow_mSExcelSaveWorkbookAsCSVhandle, nameof(mSExcelSaveWorkbookAsCSVhandle), required: false);
            var __workflow_mSExcelSaveWorkbookAsCSVworkbookName = mSExcelSaveWorkbookAsCSVworkbookName == null ? null : WorkflowExpression.Compile(mSExcelSaveWorkbookAsCSVworkbookName);
            WorkflowExpression.Validate(__workflow_mSExcelSaveWorkbookAsCSVworkbookName, nameof(mSExcelSaveWorkbookAsCSVworkbookName), required: false);
            var __workflow_mSExcelSaveWorkbookAsCSVdeleteExistingSaveFilename = mSExcelSaveWorkbookAsCSVdeleteExistingSaveFilename == null ? null : WorkflowExpression.Compile(mSExcelSaveWorkbookAsCSVdeleteExistingSaveFilename);
            WorkflowExpression.Validate(__workflow_mSExcelSaveWorkbookAsCSVdeleteExistingSaveFilename, nameof(mSExcelSaveWorkbookAsCSVdeleteExistingSaveFilename), required: false);
            return new DeferredBodyAction<MSExcelSaveWorkbookAsCSVResponse>(() =>
            {
                var apiCallPath = "/MSExcel/SaveWorkbookAsCSV";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSExcelSaveWorkbookAsCSV = new JObject();
                var mSExcelSaveWorkbookAsCSVpropCount = 0;
                if (__workflow_mSExcelSaveWorkbookAsCSVhandle != null)
                {
                    if (__workflow_mSExcelSaveWorkbookAsCSVhandle != null)
                    {
                        mSExcelSaveWorkbookAsCSV["Handle"] = ExpressionConverter.ConvertO(__workflow_mSExcelSaveWorkbookAsCSVhandle);
                        mSExcelSaveWorkbookAsCSVpropCount++;
                    }

                    mSExcelSaveWorkbookAsCSVpropCount++;
                }
                else
                {
                    mSExcelSaveWorkbookAsCSV["Handle"] = 0;
                    mSExcelSaveWorkbookAsCSVpropCount++;
                }

                if (__workflow_mSExcelSaveWorkbookAsCSVworkbookName != null)
                {
                    mSExcelSaveWorkbookAsCSV["WorkbookName"] = ExpressionConverter.ConvertO(__workflow_mSExcelSaveWorkbookAsCSVworkbookName);
                    mSExcelSaveWorkbookAsCSVpropCount++;
                }

                mSExcelSaveWorkbookAsCSVpropCount++;
                mSExcelSaveWorkbookAsCSV["SaveFilename"] = ExpressionConverter.ConvertO(__workflow_mSExcelSaveWorkbookAsCSVsaveFilename);
                if (__workflow_mSExcelSaveWorkbookAsCSVdeleteExistingSaveFilename != null)
                {
                    if (__workflow_mSExcelSaveWorkbookAsCSVdeleteExistingSaveFilename != null)
                    {
                        mSExcelSaveWorkbookAsCSV["DeleteExistingSaveFilename"] = ExpressionConverter.ConvertO(__workflow_mSExcelSaveWorkbookAsCSVdeleteExistingSaveFilename);
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
                mSExcelSaveWorkbookAsCSV["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSExcelSaveWorkbookAsCSVworkflow);
                if (mSExcelSaveWorkbookAsCSVpropCount > 0)
                {
                    callPayload.Body = mSExcelSaveWorkbookAsCSV;
                }

                return new ApiConnectionAction<MSExcelSaveWorkbookAsCSVResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelSaveWorkbookAsWithPasswordResponse> MSExcelSaveWorkbookAsWithPassword(Expression<Func<string>> mSExcelSaveWorkbookAsWithPasswordsaveFilename, Expression<Func<string>> mSExcelSaveWorkbookAsWithPasswordpassword, Expression<Func<string>> mSExcelSaveWorkbookAsWithPasswordworkflow, Expression<Func<int>> mSExcelSaveWorkbookAsWithPasswordhandle = null, Expression<Func<string>> mSExcelSaveWorkbookAsWithPasswordworkbookName = null, Expression<Func<bool>> mSExcelSaveWorkbookAsWithPassworddeleteExistingSaveFilename = null, Expression<Func<mSExcelSaveWorkbookAsWithPasswordexcelFileFormatInput>> mSExcelSaveWorkbookAsWithPasswordexcelFileFormat = null)
        {
            var __workflow_mSExcelSaveWorkbookAsWithPasswordsaveFilename = mSExcelSaveWorkbookAsWithPasswordsaveFilename == null ? null : WorkflowExpression.Compile(mSExcelSaveWorkbookAsWithPasswordsaveFilename);
            WorkflowExpression.Validate(__workflow_mSExcelSaveWorkbookAsWithPasswordsaveFilename, nameof(mSExcelSaveWorkbookAsWithPasswordsaveFilename), required: true);
            var __workflow_mSExcelSaveWorkbookAsWithPasswordpassword = mSExcelSaveWorkbookAsWithPasswordpassword == null ? null : WorkflowExpression.Compile(mSExcelSaveWorkbookAsWithPasswordpassword);
            WorkflowExpression.Validate(__workflow_mSExcelSaveWorkbookAsWithPasswordpassword, nameof(mSExcelSaveWorkbookAsWithPasswordpassword), required: true);
            var __workflow_mSExcelSaveWorkbookAsWithPasswordworkflow = mSExcelSaveWorkbookAsWithPasswordworkflow == null ? null : WorkflowExpression.Compile(mSExcelSaveWorkbookAsWithPasswordworkflow);
            WorkflowExpression.Validate(__workflow_mSExcelSaveWorkbookAsWithPasswordworkflow, nameof(mSExcelSaveWorkbookAsWithPasswordworkflow), required: true);
            var __workflow_mSExcelSaveWorkbookAsWithPasswordhandle = mSExcelSaveWorkbookAsWithPasswordhandle == null ? null : WorkflowExpression.Compile(mSExcelSaveWorkbookAsWithPasswordhandle);
            WorkflowExpression.Validate(__workflow_mSExcelSaveWorkbookAsWithPasswordhandle, nameof(mSExcelSaveWorkbookAsWithPasswordhandle), required: false);
            var __workflow_mSExcelSaveWorkbookAsWithPasswordworkbookName = mSExcelSaveWorkbookAsWithPasswordworkbookName == null ? null : WorkflowExpression.Compile(mSExcelSaveWorkbookAsWithPasswordworkbookName);
            WorkflowExpression.Validate(__workflow_mSExcelSaveWorkbookAsWithPasswordworkbookName, nameof(mSExcelSaveWorkbookAsWithPasswordworkbookName), required: false);
            var __workflow_mSExcelSaveWorkbookAsWithPassworddeleteExistingSaveFilename = mSExcelSaveWorkbookAsWithPassworddeleteExistingSaveFilename == null ? null : WorkflowExpression.Compile(mSExcelSaveWorkbookAsWithPassworddeleteExistingSaveFilename);
            WorkflowExpression.Validate(__workflow_mSExcelSaveWorkbookAsWithPassworddeleteExistingSaveFilename, nameof(mSExcelSaveWorkbookAsWithPassworddeleteExistingSaveFilename), required: false);
            var __workflow_mSExcelSaveWorkbookAsWithPasswordexcelFileFormat = mSExcelSaveWorkbookAsWithPasswordexcelFileFormat == null ? null : WorkflowExpression.Compile(mSExcelSaveWorkbookAsWithPasswordexcelFileFormat);
            WorkflowExpression.Validate(__workflow_mSExcelSaveWorkbookAsWithPasswordexcelFileFormat, nameof(mSExcelSaveWorkbookAsWithPasswordexcelFileFormat), required: false);
            return new DeferredBodyAction<MSExcelSaveWorkbookAsWithPasswordResponse>(() =>
            {
                var apiCallPath = "/MSExcel/SaveWorkbookAsWithPassword";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSExcelSaveWorkbookAsWithPassword = new JObject();
                var mSExcelSaveWorkbookAsWithPasswordpropCount = 0;
                if (__workflow_mSExcelSaveWorkbookAsWithPasswordhandle != null)
                {
                    if (__workflow_mSExcelSaveWorkbookAsWithPasswordhandle != null)
                    {
                        mSExcelSaveWorkbookAsWithPassword["Handle"] = ExpressionConverter.ConvertO(__workflow_mSExcelSaveWorkbookAsWithPasswordhandle);
                        mSExcelSaveWorkbookAsWithPasswordpropCount++;
                    }

                    mSExcelSaveWorkbookAsWithPasswordpropCount++;
                }
                else
                {
                    mSExcelSaveWorkbookAsWithPassword["Handle"] = 0;
                    mSExcelSaveWorkbookAsWithPasswordpropCount++;
                }

                if (__workflow_mSExcelSaveWorkbookAsWithPasswordworkbookName != null)
                {
                    mSExcelSaveWorkbookAsWithPassword["WorkbookName"] = ExpressionConverter.ConvertO(__workflow_mSExcelSaveWorkbookAsWithPasswordworkbookName);
                    mSExcelSaveWorkbookAsWithPasswordpropCount++;
                }

                mSExcelSaveWorkbookAsWithPasswordpropCount++;
                mSExcelSaveWorkbookAsWithPassword["SaveFilename"] = ExpressionConverter.ConvertO(__workflow_mSExcelSaveWorkbookAsWithPasswordsaveFilename);
                mSExcelSaveWorkbookAsWithPasswordpropCount++;
                mSExcelSaveWorkbookAsWithPassword["Password"] = ExpressionConverter.ConvertO(__workflow_mSExcelSaveWorkbookAsWithPasswordpassword);
                if (__workflow_mSExcelSaveWorkbookAsWithPassworddeleteExistingSaveFilename != null)
                {
                    if (__workflow_mSExcelSaveWorkbookAsWithPassworddeleteExistingSaveFilename != null)
                    {
                        mSExcelSaveWorkbookAsWithPassword["DeleteExistingSaveFilename"] = ExpressionConverter.ConvertO(__workflow_mSExcelSaveWorkbookAsWithPassworddeleteExistingSaveFilename);
                        mSExcelSaveWorkbookAsWithPasswordpropCount++;
                    }

                    mSExcelSaveWorkbookAsWithPasswordpropCount++;
                }
                else
                {
                    mSExcelSaveWorkbookAsWithPassword["DeleteExistingSaveFilename"] = false;
                    mSExcelSaveWorkbookAsWithPasswordpropCount++;
                }

                if (__workflow_mSExcelSaveWorkbookAsWithPasswordexcelFileFormat != null)
                {
                    if (__workflow_mSExcelSaveWorkbookAsWithPasswordexcelFileFormat != null)
                    {
                        mSExcelSaveWorkbookAsWithPassword["ExcelFileFormat"] = ExpressionConverter.ConvertO(__workflow_mSExcelSaveWorkbookAsWithPasswordexcelFileFormat);
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
                mSExcelSaveWorkbookAsWithPassword["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSExcelSaveWorkbookAsWithPasswordworkflow);
                if (mSExcelSaveWorkbookAsWithPasswordpropCount > 0)
                {
                    callPayload.Body = mSExcelSaveWorkbookAsWithPassword;
                }

                return new ApiConnectionAction<MSExcelSaveWorkbookAsWithPasswordResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelSaveCurrentWorkbookResponse> MSExcelSaveCurrentWorkbook(Expression<Func<string>> mSExcelSaveCurrentWorkbookworkflow, Expression<Func<int>> mSExcelSaveCurrentWorkbookhandle = null)
        {
            var __workflow_mSExcelSaveCurrentWorkbookworkflow = mSExcelSaveCurrentWorkbookworkflow == null ? null : WorkflowExpression.Compile(mSExcelSaveCurrentWorkbookworkflow);
            WorkflowExpression.Validate(__workflow_mSExcelSaveCurrentWorkbookworkflow, nameof(mSExcelSaveCurrentWorkbookworkflow), required: true);
            var __workflow_mSExcelSaveCurrentWorkbookhandle = mSExcelSaveCurrentWorkbookhandle == null ? null : WorkflowExpression.Compile(mSExcelSaveCurrentWorkbookhandle);
            WorkflowExpression.Validate(__workflow_mSExcelSaveCurrentWorkbookhandle, nameof(mSExcelSaveCurrentWorkbookhandle), required: false);
            return new DeferredBodyAction<MSExcelSaveCurrentWorkbookResponse>(() =>
            {
                var apiCallPath = "/MSExcel/SaveCurrentWorkbook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSExcelSaveCurrentWorkbook = new JObject();
                var mSExcelSaveCurrentWorkbookpropCount = 0;
                if (__workflow_mSExcelSaveCurrentWorkbookhandle != null)
                {
                    if (__workflow_mSExcelSaveCurrentWorkbookhandle != null)
                    {
                        mSExcelSaveCurrentWorkbook["Handle"] = ExpressionConverter.ConvertO(__workflow_mSExcelSaveCurrentWorkbookhandle);
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
                mSExcelSaveCurrentWorkbook["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSExcelSaveCurrentWorkbookworkflow);
                if (mSExcelSaveCurrentWorkbookpropCount > 0)
                {
                    callPayload.Body = mSExcelSaveCurrentWorkbook;
                }

                return new ApiConnectionAction<MSExcelSaveCurrentWorkbookResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelSaveCurrentWorkbookAsResponse> MSExcelSaveCurrentWorkbookAs(Expression<Func<string>> mSExcelSaveCurrentWorkbookAsworkflow, Expression<Func<int>> mSExcelSaveCurrentWorkbookAshandle = null, Expression<Func<string>> mSExcelSaveCurrentWorkbookAssaveFilename = null, Expression<Func<bool>> mSExcelSaveCurrentWorkbookAsdeleteExistingSaveFilename = null, Expression<Func<mSExcelSaveCurrentWorkbookAsexcelFileFormatInput>> mSExcelSaveCurrentWorkbookAsexcelFileFormat = null)
        {
            var __workflow_mSExcelSaveCurrentWorkbookAsworkflow = mSExcelSaveCurrentWorkbookAsworkflow == null ? null : WorkflowExpression.Compile(mSExcelSaveCurrentWorkbookAsworkflow);
            WorkflowExpression.Validate(__workflow_mSExcelSaveCurrentWorkbookAsworkflow, nameof(mSExcelSaveCurrentWorkbookAsworkflow), required: true);
            var __workflow_mSExcelSaveCurrentWorkbookAshandle = mSExcelSaveCurrentWorkbookAshandle == null ? null : WorkflowExpression.Compile(mSExcelSaveCurrentWorkbookAshandle);
            WorkflowExpression.Validate(__workflow_mSExcelSaveCurrentWorkbookAshandle, nameof(mSExcelSaveCurrentWorkbookAshandle), required: false);
            var __workflow_mSExcelSaveCurrentWorkbookAssaveFilename = mSExcelSaveCurrentWorkbookAssaveFilename == null ? null : WorkflowExpression.Compile(mSExcelSaveCurrentWorkbookAssaveFilename);
            WorkflowExpression.Validate(__workflow_mSExcelSaveCurrentWorkbookAssaveFilename, nameof(mSExcelSaveCurrentWorkbookAssaveFilename), required: false);
            var __workflow_mSExcelSaveCurrentWorkbookAsdeleteExistingSaveFilename = mSExcelSaveCurrentWorkbookAsdeleteExistingSaveFilename == null ? null : WorkflowExpression.Compile(mSExcelSaveCurrentWorkbookAsdeleteExistingSaveFilename);
            WorkflowExpression.Validate(__workflow_mSExcelSaveCurrentWorkbookAsdeleteExistingSaveFilename, nameof(mSExcelSaveCurrentWorkbookAsdeleteExistingSaveFilename), required: false);
            var __workflow_mSExcelSaveCurrentWorkbookAsexcelFileFormat = mSExcelSaveCurrentWorkbookAsexcelFileFormat == null ? null : WorkflowExpression.Compile(mSExcelSaveCurrentWorkbookAsexcelFileFormat);
            WorkflowExpression.Validate(__workflow_mSExcelSaveCurrentWorkbookAsexcelFileFormat, nameof(mSExcelSaveCurrentWorkbookAsexcelFileFormat), required: false);
            return new DeferredBodyAction<MSExcelSaveCurrentWorkbookAsResponse>(() =>
            {
                var apiCallPath = "/MSExcel/SaveCurrentWorkbookAs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSExcelSaveCurrentWorkbookAs = new JObject();
                var mSExcelSaveCurrentWorkbookAspropCount = 0;
                if (__workflow_mSExcelSaveCurrentWorkbookAshandle != null)
                {
                    if (__workflow_mSExcelSaveCurrentWorkbookAshandle != null)
                    {
                        mSExcelSaveCurrentWorkbookAs["Handle"] = ExpressionConverter.ConvertO(__workflow_mSExcelSaveCurrentWorkbookAshandle);
                        mSExcelSaveCurrentWorkbookAspropCount++;
                    }

                    mSExcelSaveCurrentWorkbookAspropCount++;
                }
                else
                {
                    mSExcelSaveCurrentWorkbookAs["Handle"] = 0;
                    mSExcelSaveCurrentWorkbookAspropCount++;
                }

                if (__workflow_mSExcelSaveCurrentWorkbookAssaveFilename != null)
                {
                    mSExcelSaveCurrentWorkbookAs["SaveFilename"] = ExpressionConverter.ConvertO(__workflow_mSExcelSaveCurrentWorkbookAssaveFilename);
                    mSExcelSaveCurrentWorkbookAspropCount++;
                }

                if (__workflow_mSExcelSaveCurrentWorkbookAsdeleteExistingSaveFilename != null)
                {
                    if (__workflow_mSExcelSaveCurrentWorkbookAsdeleteExistingSaveFilename != null)
                    {
                        mSExcelSaveCurrentWorkbookAs["DeleteExistingSaveFilename"] = ExpressionConverter.ConvertO(__workflow_mSExcelSaveCurrentWorkbookAsdeleteExistingSaveFilename);
                        mSExcelSaveCurrentWorkbookAspropCount++;
                    }

                    mSExcelSaveCurrentWorkbookAspropCount++;
                }
                else
                {
                    mSExcelSaveCurrentWorkbookAs["DeleteExistingSaveFilename"] = false;
                    mSExcelSaveCurrentWorkbookAspropCount++;
                }

                if (__workflow_mSExcelSaveCurrentWorkbookAsexcelFileFormat != null)
                {
                    if (__workflow_mSExcelSaveCurrentWorkbookAsexcelFileFormat != null)
                    {
                        mSExcelSaveCurrentWorkbookAs["ExcelFileFormat"] = ExpressionConverter.ConvertO(__workflow_mSExcelSaveCurrentWorkbookAsexcelFileFormat);
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
                mSExcelSaveCurrentWorkbookAs["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSExcelSaveCurrentWorkbookAsworkflow);
                if (mSExcelSaveCurrentWorkbookAspropCount > 0)
                {
                    callPayload.Body = mSExcelSaveCurrentWorkbookAs;
                }

                return new ApiConnectionAction<MSExcelSaveCurrentWorkbookAsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelSaveCurrentWorkbookAsCSVResponse> MSExcelSaveCurrentWorkbookAsCSV(Expression<Func<string>> mSExcelSaveCurrentWorkbookAsCSVsaveFilename, Expression<Func<string>> mSExcelSaveCurrentWorkbookAsCSVworkflow, Expression<Func<int>> mSExcelSaveCurrentWorkbookAsCSVhandle = null, Expression<Func<bool>> mSExcelSaveCurrentWorkbookAsCSVdeleteExistingSaveFilename = null)
        {
            var __workflow_mSExcelSaveCurrentWorkbookAsCSVsaveFilename = mSExcelSaveCurrentWorkbookAsCSVsaveFilename == null ? null : WorkflowExpression.Compile(mSExcelSaveCurrentWorkbookAsCSVsaveFilename);
            WorkflowExpression.Validate(__workflow_mSExcelSaveCurrentWorkbookAsCSVsaveFilename, nameof(mSExcelSaveCurrentWorkbookAsCSVsaveFilename), required: true);
            var __workflow_mSExcelSaveCurrentWorkbookAsCSVworkflow = mSExcelSaveCurrentWorkbookAsCSVworkflow == null ? null : WorkflowExpression.Compile(mSExcelSaveCurrentWorkbookAsCSVworkflow);
            WorkflowExpression.Validate(__workflow_mSExcelSaveCurrentWorkbookAsCSVworkflow, nameof(mSExcelSaveCurrentWorkbookAsCSVworkflow), required: true);
            var __workflow_mSExcelSaveCurrentWorkbookAsCSVhandle = mSExcelSaveCurrentWorkbookAsCSVhandle == null ? null : WorkflowExpression.Compile(mSExcelSaveCurrentWorkbookAsCSVhandle);
            WorkflowExpression.Validate(__workflow_mSExcelSaveCurrentWorkbookAsCSVhandle, nameof(mSExcelSaveCurrentWorkbookAsCSVhandle), required: false);
            var __workflow_mSExcelSaveCurrentWorkbookAsCSVdeleteExistingSaveFilename = mSExcelSaveCurrentWorkbookAsCSVdeleteExistingSaveFilename == null ? null : WorkflowExpression.Compile(mSExcelSaveCurrentWorkbookAsCSVdeleteExistingSaveFilename);
            WorkflowExpression.Validate(__workflow_mSExcelSaveCurrentWorkbookAsCSVdeleteExistingSaveFilename, nameof(mSExcelSaveCurrentWorkbookAsCSVdeleteExistingSaveFilename), required: false);
            return new DeferredBodyAction<MSExcelSaveCurrentWorkbookAsCSVResponse>(() =>
            {
                var apiCallPath = "/MSExcel/SaveCurrentWorkbookAsCSV";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSExcelSaveCurrentWorkbookAsCSV = new JObject();
                var mSExcelSaveCurrentWorkbookAsCSVpropCount = 0;
                if (__workflow_mSExcelSaveCurrentWorkbookAsCSVhandle != null)
                {
                    if (__workflow_mSExcelSaveCurrentWorkbookAsCSVhandle != null)
                    {
                        mSExcelSaveCurrentWorkbookAsCSV["Handle"] = ExpressionConverter.ConvertO(__workflow_mSExcelSaveCurrentWorkbookAsCSVhandle);
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
                mSExcelSaveCurrentWorkbookAsCSV["SaveFilename"] = ExpressionConverter.ConvertO(__workflow_mSExcelSaveCurrentWorkbookAsCSVsaveFilename);
                if (__workflow_mSExcelSaveCurrentWorkbookAsCSVdeleteExistingSaveFilename != null)
                {
                    if (__workflow_mSExcelSaveCurrentWorkbookAsCSVdeleteExistingSaveFilename != null)
                    {
                        mSExcelSaveCurrentWorkbookAsCSV["DeleteExistingSaveFilename"] = ExpressionConverter.ConvertO(__workflow_mSExcelSaveCurrentWorkbookAsCSVdeleteExistingSaveFilename);
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
                mSExcelSaveCurrentWorkbookAsCSV["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSExcelSaveCurrentWorkbookAsCSVworkflow);
                if (mSExcelSaveCurrentWorkbookAsCSVpropCount > 0)
                {
                    callPayload.Body = mSExcelSaveCurrentWorkbookAsCSV;
                }

                return new ApiConnectionAction<MSExcelSaveCurrentWorkbookAsCSVResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetWorksheetNamesResponse> MSExcelGetWorksheetNames(Expression<Func<string>> mSExcelGetWorksheetNamesworkflow, Expression<Func<int>> mSExcelGetWorksheetNameshandle = null, Expression<Func<string>> mSExcelGetWorksheetNamesworkbookName = null)
        {
            var __workflow_mSExcelGetWorksheetNamesworkflow = mSExcelGetWorksheetNamesworkflow == null ? null : WorkflowExpression.Compile(mSExcelGetWorksheetNamesworkflow);
            WorkflowExpression.Validate(__workflow_mSExcelGetWorksheetNamesworkflow, nameof(mSExcelGetWorksheetNamesworkflow), required: true);
            var __workflow_mSExcelGetWorksheetNameshandle = mSExcelGetWorksheetNameshandle == null ? null : WorkflowExpression.Compile(mSExcelGetWorksheetNameshandle);
            WorkflowExpression.Validate(__workflow_mSExcelGetWorksheetNameshandle, nameof(mSExcelGetWorksheetNameshandle), required: false);
            var __workflow_mSExcelGetWorksheetNamesworkbookName = mSExcelGetWorksheetNamesworkbookName == null ? null : WorkflowExpression.Compile(mSExcelGetWorksheetNamesworkbookName);
            WorkflowExpression.Validate(__workflow_mSExcelGetWorksheetNamesworkbookName, nameof(mSExcelGetWorksheetNamesworkbookName), required: false);
            return new DeferredBodyAction<MSExcelGetWorksheetNamesResponse>(() =>
            {
                var apiCallPath = "/MSExcel/GetWorksheetNames";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSExcelGetWorksheetNames = new JObject();
                var mSExcelGetWorksheetNamespropCount = 0;
                if (__workflow_mSExcelGetWorksheetNameshandle != null)
                {
                    if (__workflow_mSExcelGetWorksheetNameshandle != null)
                    {
                        mSExcelGetWorksheetNames["Handle"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetWorksheetNameshandle);
                        mSExcelGetWorksheetNamespropCount++;
                    }

                    mSExcelGetWorksheetNamespropCount++;
                }
                else
                {
                    mSExcelGetWorksheetNames["Handle"] = 0;
                    mSExcelGetWorksheetNamespropCount++;
                }

                if (__workflow_mSExcelGetWorksheetNamesworkbookName != null)
                {
                    mSExcelGetWorksheetNames["WorkbookName"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetWorksheetNamesworkbookName);
                    mSExcelGetWorksheetNamespropCount++;
                }

                mSExcelGetWorksheetNamespropCount++;
                mSExcelGetWorksheetNames["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetWorksheetNamesworkflow);
                if (mSExcelGetWorksheetNamespropCount > 0)
                {
                    callPayload.Body = mSExcelGetWorksheetNames;
                }

                return new ApiConnectionAction<MSExcelGetWorksheetNamesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetWorksheetNameResponse> MSExcelGetWorksheetName(Expression<Func<string>> mSExcelGetWorksheetNameworkflow, Expression<Func<int>> mSExcelGetWorksheetNamehandle = null, Expression<Func<string>> mSExcelGetWorksheetNameworkbookName = null, Expression<Func<int>> mSExcelGetWorksheetNameposition = null)
        {
            var __workflow_mSExcelGetWorksheetNameworkflow = mSExcelGetWorksheetNameworkflow == null ? null : WorkflowExpression.Compile(mSExcelGetWorksheetNameworkflow);
            WorkflowExpression.Validate(__workflow_mSExcelGetWorksheetNameworkflow, nameof(mSExcelGetWorksheetNameworkflow), required: true);
            var __workflow_mSExcelGetWorksheetNamehandle = mSExcelGetWorksheetNamehandle == null ? null : WorkflowExpression.Compile(mSExcelGetWorksheetNamehandle);
            WorkflowExpression.Validate(__workflow_mSExcelGetWorksheetNamehandle, nameof(mSExcelGetWorksheetNamehandle), required: false);
            var __workflow_mSExcelGetWorksheetNameworkbookName = mSExcelGetWorksheetNameworkbookName == null ? null : WorkflowExpression.Compile(mSExcelGetWorksheetNameworkbookName);
            WorkflowExpression.Validate(__workflow_mSExcelGetWorksheetNameworkbookName, nameof(mSExcelGetWorksheetNameworkbookName), required: false);
            var __workflow_mSExcelGetWorksheetNameposition = mSExcelGetWorksheetNameposition == null ? null : WorkflowExpression.Compile(mSExcelGetWorksheetNameposition);
            WorkflowExpression.Validate(__workflow_mSExcelGetWorksheetNameposition, nameof(mSExcelGetWorksheetNameposition), required: false);
            return new DeferredBodyAction<MSExcelGetWorksheetNameResponse>(() =>
            {
                var apiCallPath = "/MSExcel/GetWorksheetName";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSExcelGetWorksheetName = new JObject();
                var mSExcelGetWorksheetNamepropCount = 0;
                if (__workflow_mSExcelGetWorksheetNamehandle != null)
                {
                    if (__workflow_mSExcelGetWorksheetNamehandle != null)
                    {
                        mSExcelGetWorksheetName["Handle"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetWorksheetNamehandle);
                        mSExcelGetWorksheetNamepropCount++;
                    }

                    mSExcelGetWorksheetNamepropCount++;
                }
                else
                {
                    mSExcelGetWorksheetName["Handle"] = 0;
                    mSExcelGetWorksheetNamepropCount++;
                }

                if (__workflow_mSExcelGetWorksheetNameworkbookName != null)
                {
                    mSExcelGetWorksheetName["WorkbookName"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetWorksheetNameworkbookName);
                    mSExcelGetWorksheetNamepropCount++;
                }

                if (__workflow_mSExcelGetWorksheetNameposition != null)
                {
                    mSExcelGetWorksheetName["Position"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetWorksheetNameposition);
                    mSExcelGetWorksheetNamepropCount++;
                }

                mSExcelGetWorksheetNamepropCount++;
                mSExcelGetWorksheetName["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetWorksheetNameworkflow);
                if (mSExcelGetWorksheetNamepropCount > 0)
                {
                    callPayload.Body = mSExcelGetWorksheetName;
                }

                return new ApiConnectionAction<MSExcelGetWorksheetNameResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelActivateWorksheet(Expression<Func<string>> mSExcelActivateWorksheetworkflow, Expression<Func<int>> mSExcelActivateWorksheethandle = null, Expression<Func<string>> mSExcelActivateWorksheetworkbookName = null, Expression<Func<string>> mSExcelActivateWorksheetworksheetName = null, Expression<Func<bool>> mSExcelActivateWorksheetcreateIfMissing = null)
        {
            var __workflow_mSExcelActivateWorksheetworkflow = mSExcelActivateWorksheetworkflow == null ? null : WorkflowExpression.Compile(mSExcelActivateWorksheetworkflow);
            WorkflowExpression.Validate(__workflow_mSExcelActivateWorksheetworkflow, nameof(mSExcelActivateWorksheetworkflow), required: true);
            var __workflow_mSExcelActivateWorksheethandle = mSExcelActivateWorksheethandle == null ? null : WorkflowExpression.Compile(mSExcelActivateWorksheethandle);
            WorkflowExpression.Validate(__workflow_mSExcelActivateWorksheethandle, nameof(mSExcelActivateWorksheethandle), required: false);
            var __workflow_mSExcelActivateWorksheetworkbookName = mSExcelActivateWorksheetworkbookName == null ? null : WorkflowExpression.Compile(mSExcelActivateWorksheetworkbookName);
            WorkflowExpression.Validate(__workflow_mSExcelActivateWorksheetworkbookName, nameof(mSExcelActivateWorksheetworkbookName), required: false);
            var __workflow_mSExcelActivateWorksheetworksheetName = mSExcelActivateWorksheetworksheetName == null ? null : WorkflowExpression.Compile(mSExcelActivateWorksheetworksheetName);
            WorkflowExpression.Validate(__workflow_mSExcelActivateWorksheetworksheetName, nameof(mSExcelActivateWorksheetworksheetName), required: false);
            var __workflow_mSExcelActivateWorksheetcreateIfMissing = mSExcelActivateWorksheetcreateIfMissing == null ? null : WorkflowExpression.Compile(mSExcelActivateWorksheetcreateIfMissing);
            WorkflowExpression.Validate(__workflow_mSExcelActivateWorksheetcreateIfMissing, nameof(mSExcelActivateWorksheetcreateIfMissing), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/MSExcel/ActivateWorksheet";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSExcelActivateWorksheet = new JObject();
                var mSExcelActivateWorksheetpropCount = 0;
                if (__workflow_mSExcelActivateWorksheethandle != null)
                {
                    if (__workflow_mSExcelActivateWorksheethandle != null)
                    {
                        mSExcelActivateWorksheet["Handle"] = ExpressionConverter.ConvertO(__workflow_mSExcelActivateWorksheethandle);
                        mSExcelActivateWorksheetpropCount++;
                    }

                    mSExcelActivateWorksheetpropCount++;
                }
                else
                {
                    mSExcelActivateWorksheet["Handle"] = 0;
                    mSExcelActivateWorksheetpropCount++;
                }

                if (__workflow_mSExcelActivateWorksheetworkbookName != null)
                {
                    mSExcelActivateWorksheet["WorkbookName"] = ExpressionConverter.ConvertO(__workflow_mSExcelActivateWorksheetworkbookName);
                    mSExcelActivateWorksheetpropCount++;
                }

                if (__workflow_mSExcelActivateWorksheetworksheetName != null)
                {
                    mSExcelActivateWorksheet["WorksheetName"] = ExpressionConverter.ConvertO(__workflow_mSExcelActivateWorksheetworksheetName);
                    mSExcelActivateWorksheetpropCount++;
                }

                if (__workflow_mSExcelActivateWorksheetcreateIfMissing != null)
                {
                    if (__workflow_mSExcelActivateWorksheetcreateIfMissing != null)
                    {
                        mSExcelActivateWorksheet["CreateIfMissing"] = ExpressionConverter.ConvertO(__workflow_mSExcelActivateWorksheetcreateIfMissing);
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
                mSExcelActivateWorksheet["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSExcelActivateWorksheetworkflow);
                if (mSExcelActivateWorksheetpropCount > 0)
                {
                    callPayload.Body = mSExcelActivateWorksheet;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelCreateWorksheet(Expression<Func<string>> mSExcelCreateWorksheetworkflow, Expression<Func<int>> mSExcelCreateWorksheethandle = null, Expression<Func<string>> mSExcelCreateWorksheetworkbookName = null, Expression<Func<string>> mSExcelCreateWorksheetworksheetName = null)
        {
            var __workflow_mSExcelCreateWorksheetworkflow = mSExcelCreateWorksheetworkflow == null ? null : WorkflowExpression.Compile(mSExcelCreateWorksheetworkflow);
            WorkflowExpression.Validate(__workflow_mSExcelCreateWorksheetworkflow, nameof(mSExcelCreateWorksheetworkflow), required: true);
            var __workflow_mSExcelCreateWorksheethandle = mSExcelCreateWorksheethandle == null ? null : WorkflowExpression.Compile(mSExcelCreateWorksheethandle);
            WorkflowExpression.Validate(__workflow_mSExcelCreateWorksheethandle, nameof(mSExcelCreateWorksheethandle), required: false);
            var __workflow_mSExcelCreateWorksheetworkbookName = mSExcelCreateWorksheetworkbookName == null ? null : WorkflowExpression.Compile(mSExcelCreateWorksheetworkbookName);
            WorkflowExpression.Validate(__workflow_mSExcelCreateWorksheetworkbookName, nameof(mSExcelCreateWorksheetworkbookName), required: false);
            var __workflow_mSExcelCreateWorksheetworksheetName = mSExcelCreateWorksheetworksheetName == null ? null : WorkflowExpression.Compile(mSExcelCreateWorksheetworksheetName);
            WorkflowExpression.Validate(__workflow_mSExcelCreateWorksheetworksheetName, nameof(mSExcelCreateWorksheetworksheetName), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/MSExcel/CreateWorksheet";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSExcelCreateWorksheet = new JObject();
                var mSExcelCreateWorksheetpropCount = 0;
                if (__workflow_mSExcelCreateWorksheethandle != null)
                {
                    if (__workflow_mSExcelCreateWorksheethandle != null)
                    {
                        mSExcelCreateWorksheet["Handle"] = ExpressionConverter.ConvertO(__workflow_mSExcelCreateWorksheethandle);
                        mSExcelCreateWorksheetpropCount++;
                    }

                    mSExcelCreateWorksheetpropCount++;
                }
                else
                {
                    mSExcelCreateWorksheet["Handle"] = 0;
                    mSExcelCreateWorksheetpropCount++;
                }

                if (__workflow_mSExcelCreateWorksheetworkbookName != null)
                {
                    mSExcelCreateWorksheet["WorkbookName"] = ExpressionConverter.ConvertO(__workflow_mSExcelCreateWorksheetworkbookName);
                    mSExcelCreateWorksheetpropCount++;
                }

                if (__workflow_mSExcelCreateWorksheetworksheetName != null)
                {
                    mSExcelCreateWorksheet["WorksheetName"] = ExpressionConverter.ConvertO(__workflow_mSExcelCreateWorksheetworksheetName);
                    mSExcelCreateWorksheetpropCount++;
                }

                mSExcelCreateWorksheetpropCount++;
                mSExcelCreateWorksheet["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSExcelCreateWorksheetworkflow);
                if (mSExcelCreateWorksheetpropCount > 0)
                {
                    callPayload.Body = mSExcelCreateWorksheet;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelDeleteWorksheet(Expression<Func<string>> mSExcelDeleteWorksheetworkflow, Expression<Func<int>> mSExcelDeleteWorksheethandle = null, Expression<Func<string>> mSExcelDeleteWorksheetworkbookName = null, Expression<Func<string>> mSExcelDeleteWorksheetworksheetName = null)
        {
            var __workflow_mSExcelDeleteWorksheetworkflow = mSExcelDeleteWorksheetworkflow == null ? null : WorkflowExpression.Compile(mSExcelDeleteWorksheetworkflow);
            WorkflowExpression.Validate(__workflow_mSExcelDeleteWorksheetworkflow, nameof(mSExcelDeleteWorksheetworkflow), required: true);
            var __workflow_mSExcelDeleteWorksheethandle = mSExcelDeleteWorksheethandle == null ? null : WorkflowExpression.Compile(mSExcelDeleteWorksheethandle);
            WorkflowExpression.Validate(__workflow_mSExcelDeleteWorksheethandle, nameof(mSExcelDeleteWorksheethandle), required: false);
            var __workflow_mSExcelDeleteWorksheetworkbookName = mSExcelDeleteWorksheetworkbookName == null ? null : WorkflowExpression.Compile(mSExcelDeleteWorksheetworkbookName);
            WorkflowExpression.Validate(__workflow_mSExcelDeleteWorksheetworkbookName, nameof(mSExcelDeleteWorksheetworkbookName), required: false);
            var __workflow_mSExcelDeleteWorksheetworksheetName = mSExcelDeleteWorksheetworksheetName == null ? null : WorkflowExpression.Compile(mSExcelDeleteWorksheetworksheetName);
            WorkflowExpression.Validate(__workflow_mSExcelDeleteWorksheetworksheetName, nameof(mSExcelDeleteWorksheetworksheetName), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/MSExcel/DeleteWorksheet";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSExcelDeleteWorksheet = new JObject();
                var mSExcelDeleteWorksheetpropCount = 0;
                if (__workflow_mSExcelDeleteWorksheethandle != null)
                {
                    if (__workflow_mSExcelDeleteWorksheethandle != null)
                    {
                        mSExcelDeleteWorksheet["Handle"] = ExpressionConverter.ConvertO(__workflow_mSExcelDeleteWorksheethandle);
                        mSExcelDeleteWorksheetpropCount++;
                    }

                    mSExcelDeleteWorksheetpropCount++;
                }
                else
                {
                    mSExcelDeleteWorksheet["Handle"] = 0;
                    mSExcelDeleteWorksheetpropCount++;
                }

                if (__workflow_mSExcelDeleteWorksheetworkbookName != null)
                {
                    mSExcelDeleteWorksheet["WorkbookName"] = ExpressionConverter.ConvertO(__workflow_mSExcelDeleteWorksheetworkbookName);
                    mSExcelDeleteWorksheetpropCount++;
                }

                if (__workflow_mSExcelDeleteWorksheetworksheetName != null)
                {
                    mSExcelDeleteWorksheet["WorksheetName"] = ExpressionConverter.ConvertO(__workflow_mSExcelDeleteWorksheetworksheetName);
                    mSExcelDeleteWorksheetpropCount++;
                }

                mSExcelDeleteWorksheetpropCount++;
                mSExcelDeleteWorksheet["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSExcelDeleteWorksheetworkflow);
                if (mSExcelDeleteWorksheetpropCount > 0)
                {
                    callPayload.Body = mSExcelDeleteWorksheet;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetWorksheetAsCollectionEnhancedResponse> MSExcelGetWorksheetAsCollectionEnhanced(Expression<Func<string>> mSExcelGetWorksheetAsCollectionEnhancedworkflow, Expression<Func<int>> mSExcelGetWorksheetAsCollectionEnhancedhandle = null, Expression<Func<string>> mSExcelGetWorksheetAsCollectionEnhancedworkbookName = null, Expression<Func<string>> mSExcelGetWorksheetAsCollectionEnhancedworksheetName = null, Expression<Func<bool>> mSExcelGetWorksheetAsCollectionEnhanceduseHeader = null, Expression<Func<string>> mSExcelGetWorksheetAsCollectionEnhancedstartCell = null, Expression<Func<int>> mSExcelGetWorksheetAsCollectionEnhancedmaximumColumnNumber = null, Expression<Func<bool>> mSExcelGetWorksheetAsCollectionEnhancedskipBlankRows = null, Expression<Func<bool>> mSExcelGetWorksheetAsCollectionEnhancedskipColumnsWithNoHeader = null, Expression<Func<string>> mSExcelGetWorksheetAsCollectionEnhancedkeyColumn = null, Expression<Func<bool>> mSExcelGetWorksheetAsCollectionEnhancedgetRawData = null, Expression<Func<int>> mSExcelGetWorksheetAsCollectionEnhancedignoreRowsWithLowCellCount = null, Expression<Func<int>> mSExcelGetWorksheetAsCollectionEnhancedmaxConcurrentBlankRows = null, Expression<Func<int>> mSExcelGetWorksheetAsCollectionEnhancedfirstDataRowToReturn = null, Expression<Func<int>> mSExcelGetWorksheetAsCollectionEnhancedmaxNumberOfDataRowsToReturn = null)
        {
            var __workflow_mSExcelGetWorksheetAsCollectionEnhancedworkflow = mSExcelGetWorksheetAsCollectionEnhancedworkflow == null ? null : WorkflowExpression.Compile(mSExcelGetWorksheetAsCollectionEnhancedworkflow);
            WorkflowExpression.Validate(__workflow_mSExcelGetWorksheetAsCollectionEnhancedworkflow, nameof(mSExcelGetWorksheetAsCollectionEnhancedworkflow), required: true);
            var __workflow_mSExcelGetWorksheetAsCollectionEnhancedhandle = mSExcelGetWorksheetAsCollectionEnhancedhandle == null ? null : WorkflowExpression.Compile(mSExcelGetWorksheetAsCollectionEnhancedhandle);
            WorkflowExpression.Validate(__workflow_mSExcelGetWorksheetAsCollectionEnhancedhandle, nameof(mSExcelGetWorksheetAsCollectionEnhancedhandle), required: false);
            var __workflow_mSExcelGetWorksheetAsCollectionEnhancedworkbookName = mSExcelGetWorksheetAsCollectionEnhancedworkbookName == null ? null : WorkflowExpression.Compile(mSExcelGetWorksheetAsCollectionEnhancedworkbookName);
            WorkflowExpression.Validate(__workflow_mSExcelGetWorksheetAsCollectionEnhancedworkbookName, nameof(mSExcelGetWorksheetAsCollectionEnhancedworkbookName), required: false);
            var __workflow_mSExcelGetWorksheetAsCollectionEnhancedworksheetName = mSExcelGetWorksheetAsCollectionEnhancedworksheetName == null ? null : WorkflowExpression.Compile(mSExcelGetWorksheetAsCollectionEnhancedworksheetName);
            WorkflowExpression.Validate(__workflow_mSExcelGetWorksheetAsCollectionEnhancedworksheetName, nameof(mSExcelGetWorksheetAsCollectionEnhancedworksheetName), required: false);
            var __workflow_mSExcelGetWorksheetAsCollectionEnhanceduseHeader = mSExcelGetWorksheetAsCollectionEnhanceduseHeader == null ? null : WorkflowExpression.Compile(mSExcelGetWorksheetAsCollectionEnhanceduseHeader);
            WorkflowExpression.Validate(__workflow_mSExcelGetWorksheetAsCollectionEnhanceduseHeader, nameof(mSExcelGetWorksheetAsCollectionEnhanceduseHeader), required: false);
            var __workflow_mSExcelGetWorksheetAsCollectionEnhancedstartCell = mSExcelGetWorksheetAsCollectionEnhancedstartCell == null ? null : WorkflowExpression.Compile(mSExcelGetWorksheetAsCollectionEnhancedstartCell);
            WorkflowExpression.Validate(__workflow_mSExcelGetWorksheetAsCollectionEnhancedstartCell, nameof(mSExcelGetWorksheetAsCollectionEnhancedstartCell), required: false);
            var __workflow_mSExcelGetWorksheetAsCollectionEnhancedmaximumColumnNumber = mSExcelGetWorksheetAsCollectionEnhancedmaximumColumnNumber == null ? null : WorkflowExpression.Compile(mSExcelGetWorksheetAsCollectionEnhancedmaximumColumnNumber);
            WorkflowExpression.Validate(__workflow_mSExcelGetWorksheetAsCollectionEnhancedmaximumColumnNumber, nameof(mSExcelGetWorksheetAsCollectionEnhancedmaximumColumnNumber), required: false);
            var __workflow_mSExcelGetWorksheetAsCollectionEnhancedskipBlankRows = mSExcelGetWorksheetAsCollectionEnhancedskipBlankRows == null ? null : WorkflowExpression.Compile(mSExcelGetWorksheetAsCollectionEnhancedskipBlankRows);
            WorkflowExpression.Validate(__workflow_mSExcelGetWorksheetAsCollectionEnhancedskipBlankRows, nameof(mSExcelGetWorksheetAsCollectionEnhancedskipBlankRows), required: false);
            var __workflow_mSExcelGetWorksheetAsCollectionEnhancedskipColumnsWithNoHeader = mSExcelGetWorksheetAsCollectionEnhancedskipColumnsWithNoHeader == null ? null : WorkflowExpression.Compile(mSExcelGetWorksheetAsCollectionEnhancedskipColumnsWithNoHeader);
            WorkflowExpression.Validate(__workflow_mSExcelGetWorksheetAsCollectionEnhancedskipColumnsWithNoHeader, nameof(mSExcelGetWorksheetAsCollectionEnhancedskipColumnsWithNoHeader), required: false);
            var __workflow_mSExcelGetWorksheetAsCollectionEnhancedkeyColumn = mSExcelGetWorksheetAsCollectionEnhancedkeyColumn == null ? null : WorkflowExpression.Compile(mSExcelGetWorksheetAsCollectionEnhancedkeyColumn);
            WorkflowExpression.Validate(__workflow_mSExcelGetWorksheetAsCollectionEnhancedkeyColumn, nameof(mSExcelGetWorksheetAsCollectionEnhancedkeyColumn), required: false);
            var __workflow_mSExcelGetWorksheetAsCollectionEnhancedgetRawData = mSExcelGetWorksheetAsCollectionEnhancedgetRawData == null ? null : WorkflowExpression.Compile(mSExcelGetWorksheetAsCollectionEnhancedgetRawData);
            WorkflowExpression.Validate(__workflow_mSExcelGetWorksheetAsCollectionEnhancedgetRawData, nameof(mSExcelGetWorksheetAsCollectionEnhancedgetRawData), required: false);
            var __workflow_mSExcelGetWorksheetAsCollectionEnhancedignoreRowsWithLowCellCount = mSExcelGetWorksheetAsCollectionEnhancedignoreRowsWithLowCellCount == null ? null : WorkflowExpression.Compile(mSExcelGetWorksheetAsCollectionEnhancedignoreRowsWithLowCellCount);
            WorkflowExpression.Validate(__workflow_mSExcelGetWorksheetAsCollectionEnhancedignoreRowsWithLowCellCount, nameof(mSExcelGetWorksheetAsCollectionEnhancedignoreRowsWithLowCellCount), required: false);
            var __workflow_mSExcelGetWorksheetAsCollectionEnhancedmaxConcurrentBlankRows = mSExcelGetWorksheetAsCollectionEnhancedmaxConcurrentBlankRows == null ? null : WorkflowExpression.Compile(mSExcelGetWorksheetAsCollectionEnhancedmaxConcurrentBlankRows);
            WorkflowExpression.Validate(__workflow_mSExcelGetWorksheetAsCollectionEnhancedmaxConcurrentBlankRows, nameof(mSExcelGetWorksheetAsCollectionEnhancedmaxConcurrentBlankRows), required: false);
            var __workflow_mSExcelGetWorksheetAsCollectionEnhancedfirstDataRowToReturn = mSExcelGetWorksheetAsCollectionEnhancedfirstDataRowToReturn == null ? null : WorkflowExpression.Compile(mSExcelGetWorksheetAsCollectionEnhancedfirstDataRowToReturn);
            WorkflowExpression.Validate(__workflow_mSExcelGetWorksheetAsCollectionEnhancedfirstDataRowToReturn, nameof(mSExcelGetWorksheetAsCollectionEnhancedfirstDataRowToReturn), required: false);
            var __workflow_mSExcelGetWorksheetAsCollectionEnhancedmaxNumberOfDataRowsToReturn = mSExcelGetWorksheetAsCollectionEnhancedmaxNumberOfDataRowsToReturn == null ? null : WorkflowExpression.Compile(mSExcelGetWorksheetAsCollectionEnhancedmaxNumberOfDataRowsToReturn);
            WorkflowExpression.Validate(__workflow_mSExcelGetWorksheetAsCollectionEnhancedmaxNumberOfDataRowsToReturn, nameof(mSExcelGetWorksheetAsCollectionEnhancedmaxNumberOfDataRowsToReturn), required: false);
            return new DeferredBodyAction<MSExcelGetWorksheetAsCollectionEnhancedResponse>(() =>
            {
                var apiCallPath = "/MSExcel/GetWorksheetAsCollectionEnhanced";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSExcelGetWorksheetAsCollectionEnhanced = new JObject();
                var mSExcelGetWorksheetAsCollectionEnhancedpropCount = 0;
                if (__workflow_mSExcelGetWorksheetAsCollectionEnhancedhandle != null)
                {
                    if (__workflow_mSExcelGetWorksheetAsCollectionEnhancedhandle != null)
                    {
                        mSExcelGetWorksheetAsCollectionEnhanced["Handle"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetWorksheetAsCollectionEnhancedhandle);
                        mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
                    }

                    mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
                }
                else
                {
                    mSExcelGetWorksheetAsCollectionEnhanced["Handle"] = 0;
                    mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
                }

                if (__workflow_mSExcelGetWorksheetAsCollectionEnhancedworkbookName != null)
                {
                    mSExcelGetWorksheetAsCollectionEnhanced["WorkbookName"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetWorksheetAsCollectionEnhancedworkbookName);
                    mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
                }

                if (__workflow_mSExcelGetWorksheetAsCollectionEnhancedworksheetName != null)
                {
                    mSExcelGetWorksheetAsCollectionEnhanced["WorksheetName"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetWorksheetAsCollectionEnhancedworksheetName);
                    mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
                }

                if (__workflow_mSExcelGetWorksheetAsCollectionEnhanceduseHeader != null)
                {
                    if (__workflow_mSExcelGetWorksheetAsCollectionEnhanceduseHeader != null)
                    {
                        mSExcelGetWorksheetAsCollectionEnhanced["UseHeader"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetWorksheetAsCollectionEnhanceduseHeader);
                        mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
                    }

                    mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
                }
                else
                {
                    mSExcelGetWorksheetAsCollectionEnhanced["UseHeader"] = true;
                    mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
                }

                if (__workflow_mSExcelGetWorksheetAsCollectionEnhancedstartCell != null)
                {
                    mSExcelGetWorksheetAsCollectionEnhanced["StartCell"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetWorksheetAsCollectionEnhancedstartCell);
                    mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
                }

                if (__workflow_mSExcelGetWorksheetAsCollectionEnhancedmaximumColumnNumber != null)
                {
                    if (__workflow_mSExcelGetWorksheetAsCollectionEnhancedmaximumColumnNumber != null)
                    {
                        mSExcelGetWorksheetAsCollectionEnhanced["MaximumColumnNumber"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetWorksheetAsCollectionEnhancedmaximumColumnNumber);
                        mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
                    }

                    mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
                }
                else
                {
                    mSExcelGetWorksheetAsCollectionEnhanced["MaximumColumnNumber"] = 0;
                    mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
                }

                if (__workflow_mSExcelGetWorksheetAsCollectionEnhancedskipBlankRows != null)
                {
                    if (__workflow_mSExcelGetWorksheetAsCollectionEnhancedskipBlankRows != null)
                    {
                        mSExcelGetWorksheetAsCollectionEnhanced["SkipBlankRows"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetWorksheetAsCollectionEnhancedskipBlankRows);
                        mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
                    }

                    mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
                }
                else
                {
                    mSExcelGetWorksheetAsCollectionEnhanced["SkipBlankRows"] = true;
                    mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
                }

                if (__workflow_mSExcelGetWorksheetAsCollectionEnhancedskipColumnsWithNoHeader != null)
                {
                    if (__workflow_mSExcelGetWorksheetAsCollectionEnhancedskipColumnsWithNoHeader != null)
                    {
                        mSExcelGetWorksheetAsCollectionEnhanced["SkipColumnsWithNoHeader"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetWorksheetAsCollectionEnhancedskipColumnsWithNoHeader);
                        mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
                    }

                    mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
                }
                else
                {
                    mSExcelGetWorksheetAsCollectionEnhanced["SkipColumnsWithNoHeader"] = false;
                    mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
                }

                if (__workflow_mSExcelGetWorksheetAsCollectionEnhancedkeyColumn != null)
                {
                    mSExcelGetWorksheetAsCollectionEnhanced["KeyColumn"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetWorksheetAsCollectionEnhancedkeyColumn);
                    mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
                }

                if (__workflow_mSExcelGetWorksheetAsCollectionEnhancedgetRawData != null)
                {
                    if (__workflow_mSExcelGetWorksheetAsCollectionEnhancedgetRawData != null)
                    {
                        mSExcelGetWorksheetAsCollectionEnhanced["GetRawData"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetWorksheetAsCollectionEnhancedgetRawData);
                        mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
                    }

                    mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
                }
                else
                {
                    mSExcelGetWorksheetAsCollectionEnhanced["GetRawData"] = true;
                    mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
                }

                if (__workflow_mSExcelGetWorksheetAsCollectionEnhancedignoreRowsWithLowCellCount != null)
                {
                    if (__workflow_mSExcelGetWorksheetAsCollectionEnhancedignoreRowsWithLowCellCount != null)
                    {
                        mSExcelGetWorksheetAsCollectionEnhanced["IgnoreRowsWithLowCellCount"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetWorksheetAsCollectionEnhancedignoreRowsWithLowCellCount);
                        mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
                    }

                    mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
                }
                else
                {
                    mSExcelGetWorksheetAsCollectionEnhanced["IgnoreRowsWithLowCellCount"] = 0;
                    mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
                }

                if (__workflow_mSExcelGetWorksheetAsCollectionEnhancedmaxConcurrentBlankRows != null)
                {
                    if (__workflow_mSExcelGetWorksheetAsCollectionEnhancedmaxConcurrentBlankRows != null)
                    {
                        mSExcelGetWorksheetAsCollectionEnhanced["MaxConcurrentBlankRows"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetWorksheetAsCollectionEnhancedmaxConcurrentBlankRows);
                        mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
                    }

                    mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
                }
                else
                {
                    mSExcelGetWorksheetAsCollectionEnhanced["MaxConcurrentBlankRows"] = -1;
                    mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
                }

                if (__workflow_mSExcelGetWorksheetAsCollectionEnhancedfirstDataRowToReturn != null)
                {
                    if (__workflow_mSExcelGetWorksheetAsCollectionEnhancedfirstDataRowToReturn != null)
                    {
                        mSExcelGetWorksheetAsCollectionEnhanced["FirstDataRowToReturn"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetWorksheetAsCollectionEnhancedfirstDataRowToReturn);
                        mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
                    }

                    mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
                }
                else
                {
                    mSExcelGetWorksheetAsCollectionEnhanced["FirstDataRowToReturn"] = 0;
                    mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
                }

                if (__workflow_mSExcelGetWorksheetAsCollectionEnhancedmaxNumberOfDataRowsToReturn != null)
                {
                    if (__workflow_mSExcelGetWorksheetAsCollectionEnhancedmaxNumberOfDataRowsToReturn != null)
                    {
                        mSExcelGetWorksheetAsCollectionEnhanced["MaxNumberOfDataRowsToReturn"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetWorksheetAsCollectionEnhancedmaxNumberOfDataRowsToReturn);
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
                mSExcelGetWorksheetAsCollectionEnhanced["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetWorksheetAsCollectionEnhancedworkflow);
                if (mSExcelGetWorksheetAsCollectionEnhancedpropCount > 0)
                {
                    callPayload.Body = mSExcelGetWorksheetAsCollectionEnhanced;
                }

                return new ApiConnectionAction<MSExcelGetWorksheetAsCollectionEnhancedResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetNumberOfRowsResponse> MSExcelGetNumberOfRows(Expression<Func<string>> mSExcelGetNumberOfRowsworkflow, Expression<Func<int>> mSExcelGetNumberOfRowshandle = null, Expression<Func<string>> mSExcelGetNumberOfRowsworkbookName = null, Expression<Func<string>> mSExcelGetNumberOfRowsworksheetName = null)
        {
            var __workflow_mSExcelGetNumberOfRowsworkflow = mSExcelGetNumberOfRowsworkflow == null ? null : WorkflowExpression.Compile(mSExcelGetNumberOfRowsworkflow);
            WorkflowExpression.Validate(__workflow_mSExcelGetNumberOfRowsworkflow, nameof(mSExcelGetNumberOfRowsworkflow), required: true);
            var __workflow_mSExcelGetNumberOfRowshandle = mSExcelGetNumberOfRowshandle == null ? null : WorkflowExpression.Compile(mSExcelGetNumberOfRowshandle);
            WorkflowExpression.Validate(__workflow_mSExcelGetNumberOfRowshandle, nameof(mSExcelGetNumberOfRowshandle), required: false);
            var __workflow_mSExcelGetNumberOfRowsworkbookName = mSExcelGetNumberOfRowsworkbookName == null ? null : WorkflowExpression.Compile(mSExcelGetNumberOfRowsworkbookName);
            WorkflowExpression.Validate(__workflow_mSExcelGetNumberOfRowsworkbookName, nameof(mSExcelGetNumberOfRowsworkbookName), required: false);
            var __workflow_mSExcelGetNumberOfRowsworksheetName = mSExcelGetNumberOfRowsworksheetName == null ? null : WorkflowExpression.Compile(mSExcelGetNumberOfRowsworksheetName);
            WorkflowExpression.Validate(__workflow_mSExcelGetNumberOfRowsworksheetName, nameof(mSExcelGetNumberOfRowsworksheetName), required: false);
            return new DeferredBodyAction<MSExcelGetNumberOfRowsResponse>(() =>
            {
                var apiCallPath = "/MSExcel/GetNumberOfRows";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSExcelGetNumberOfRows = new JObject();
                var mSExcelGetNumberOfRowspropCount = 0;
                if (__workflow_mSExcelGetNumberOfRowshandle != null)
                {
                    if (__workflow_mSExcelGetNumberOfRowshandle != null)
                    {
                        mSExcelGetNumberOfRows["Handle"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetNumberOfRowshandle);
                        mSExcelGetNumberOfRowspropCount++;
                    }

                    mSExcelGetNumberOfRowspropCount++;
                }
                else
                {
                    mSExcelGetNumberOfRows["Handle"] = 0;
                    mSExcelGetNumberOfRowspropCount++;
                }

                if (__workflow_mSExcelGetNumberOfRowsworkbookName != null)
                {
                    mSExcelGetNumberOfRows["WorkbookName"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetNumberOfRowsworkbookName);
                    mSExcelGetNumberOfRowspropCount++;
                }

                if (__workflow_mSExcelGetNumberOfRowsworksheetName != null)
                {
                    mSExcelGetNumberOfRows["WorksheetName"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetNumberOfRowsworksheetName);
                    mSExcelGetNumberOfRowspropCount++;
                }

                mSExcelGetNumberOfRowspropCount++;
                mSExcelGetNumberOfRows["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetNumberOfRowsworkflow);
                if (mSExcelGetNumberOfRowspropCount > 0)
                {
                    callPayload.Body = mSExcelGetNumberOfRows;
                }

                return new ApiConnectionAction<MSExcelGetNumberOfRowsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelEvaluateExpressionResponse> MSExcelEvaluateExpression(Expression<Func<string>> mSExcelEvaluateExpressionexpression, Expression<Func<string>> mSExcelEvaluateExpressionworkflow, Expression<Func<int>> mSExcelEvaluateExpressionhandle = null)
        {
            var __workflow_mSExcelEvaluateExpressionexpression = mSExcelEvaluateExpressionexpression == null ? null : WorkflowExpression.Compile(mSExcelEvaluateExpressionexpression);
            WorkflowExpression.Validate(__workflow_mSExcelEvaluateExpressionexpression, nameof(mSExcelEvaluateExpressionexpression), required: true);
            var __workflow_mSExcelEvaluateExpressionworkflow = mSExcelEvaluateExpressionworkflow == null ? null : WorkflowExpression.Compile(mSExcelEvaluateExpressionworkflow);
            WorkflowExpression.Validate(__workflow_mSExcelEvaluateExpressionworkflow, nameof(mSExcelEvaluateExpressionworkflow), required: true);
            var __workflow_mSExcelEvaluateExpressionhandle = mSExcelEvaluateExpressionhandle == null ? null : WorkflowExpression.Compile(mSExcelEvaluateExpressionhandle);
            WorkflowExpression.Validate(__workflow_mSExcelEvaluateExpressionhandle, nameof(mSExcelEvaluateExpressionhandle), required: false);
            return new DeferredBodyAction<MSExcelEvaluateExpressionResponse>(() =>
            {
                var apiCallPath = "/MSExcel/EvaluateExpression";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSExcelEvaluateExpression = new JObject();
                var mSExcelEvaluateExpressionpropCount = 0;
                if (__workflow_mSExcelEvaluateExpressionhandle != null)
                {
                    if (__workflow_mSExcelEvaluateExpressionhandle != null)
                    {
                        mSExcelEvaluateExpression["Handle"] = ExpressionConverter.ConvertO(__workflow_mSExcelEvaluateExpressionhandle);
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
                mSExcelEvaluateExpression["Expression"] = ExpressionConverter.ConvertO(__workflow_mSExcelEvaluateExpressionexpression);
                mSExcelEvaluateExpressionpropCount++;
                mSExcelEvaluateExpression["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSExcelEvaluateExpressionworkflow);
                if (mSExcelEvaluateExpressionpropCount > 0)
                {
                    callPayload.Body = mSExcelEvaluateExpression;
                }

                return new ApiConnectionAction<MSExcelEvaluateExpressionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetWorksheetUsedRangeResponse> MSExcelGetWorksheetUsedRange(Expression<Func<string>> mSExcelGetWorksheetUsedRangeworkflow, Expression<Func<int>> mSExcelGetWorksheetUsedRangehandle = null, Expression<Func<string>> mSExcelGetWorksheetUsedRangeworkbookName = null, Expression<Func<string>> mSExcelGetWorksheetUsedRangeworksheetName = null)
        {
            var __workflow_mSExcelGetWorksheetUsedRangeworkflow = mSExcelGetWorksheetUsedRangeworkflow == null ? null : WorkflowExpression.Compile(mSExcelGetWorksheetUsedRangeworkflow);
            WorkflowExpression.Validate(__workflow_mSExcelGetWorksheetUsedRangeworkflow, nameof(mSExcelGetWorksheetUsedRangeworkflow), required: true);
            var __workflow_mSExcelGetWorksheetUsedRangehandle = mSExcelGetWorksheetUsedRangehandle == null ? null : WorkflowExpression.Compile(mSExcelGetWorksheetUsedRangehandle);
            WorkflowExpression.Validate(__workflow_mSExcelGetWorksheetUsedRangehandle, nameof(mSExcelGetWorksheetUsedRangehandle), required: false);
            var __workflow_mSExcelGetWorksheetUsedRangeworkbookName = mSExcelGetWorksheetUsedRangeworkbookName == null ? null : WorkflowExpression.Compile(mSExcelGetWorksheetUsedRangeworkbookName);
            WorkflowExpression.Validate(__workflow_mSExcelGetWorksheetUsedRangeworkbookName, nameof(mSExcelGetWorksheetUsedRangeworkbookName), required: false);
            var __workflow_mSExcelGetWorksheetUsedRangeworksheetName = mSExcelGetWorksheetUsedRangeworksheetName == null ? null : WorkflowExpression.Compile(mSExcelGetWorksheetUsedRangeworksheetName);
            WorkflowExpression.Validate(__workflow_mSExcelGetWorksheetUsedRangeworksheetName, nameof(mSExcelGetWorksheetUsedRangeworksheetName), required: false);
            return new DeferredBodyAction<MSExcelGetWorksheetUsedRangeResponse>(() =>
            {
                var apiCallPath = "/MSExcel/GetWorksheetUsedRange";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSExcelGetWorksheetUsedRange = new JObject();
                var mSExcelGetWorksheetUsedRangepropCount = 0;
                if (__workflow_mSExcelGetWorksheetUsedRangehandle != null)
                {
                    if (__workflow_mSExcelGetWorksheetUsedRangehandle != null)
                    {
                        mSExcelGetWorksheetUsedRange["Handle"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetWorksheetUsedRangehandle);
                        mSExcelGetWorksheetUsedRangepropCount++;
                    }

                    mSExcelGetWorksheetUsedRangepropCount++;
                }
                else
                {
                    mSExcelGetWorksheetUsedRange["Handle"] = 0;
                    mSExcelGetWorksheetUsedRangepropCount++;
                }

                if (__workflow_mSExcelGetWorksheetUsedRangeworkbookName != null)
                {
                    mSExcelGetWorksheetUsedRange["WorkbookName"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetWorksheetUsedRangeworkbookName);
                    mSExcelGetWorksheetUsedRangepropCount++;
                }

                if (__workflow_mSExcelGetWorksheetUsedRangeworksheetName != null)
                {
                    mSExcelGetWorksheetUsedRange["WorksheetName"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetWorksheetUsedRangeworksheetName);
                    mSExcelGetWorksheetUsedRangepropCount++;
                }

                mSExcelGetWorksheetUsedRangepropCount++;
                mSExcelGetWorksheetUsedRange["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetWorksheetUsedRangeworkflow);
                if (mSExcelGetWorksheetUsedRangepropCount > 0)
                {
                    callPayload.Body = mSExcelGetWorksheetUsedRange;
                }

                return new ApiConnectionAction<MSExcelGetWorksheetUsedRangeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetCountrySettingResponse> MSExcelGetCountrySetting(Expression<Func<string>> mSExcelGetCountrySettingworkflow, Expression<Func<int>> mSExcelGetCountrySettinghandle = null)
        {
            var __workflow_mSExcelGetCountrySettingworkflow = mSExcelGetCountrySettingworkflow == null ? null : WorkflowExpression.Compile(mSExcelGetCountrySettingworkflow);
            WorkflowExpression.Validate(__workflow_mSExcelGetCountrySettingworkflow, nameof(mSExcelGetCountrySettingworkflow), required: true);
            var __workflow_mSExcelGetCountrySettinghandle = mSExcelGetCountrySettinghandle == null ? null : WorkflowExpression.Compile(mSExcelGetCountrySettinghandle);
            WorkflowExpression.Validate(__workflow_mSExcelGetCountrySettinghandle, nameof(mSExcelGetCountrySettinghandle), required: false);
            return new DeferredBodyAction<MSExcelGetCountrySettingResponse>(() =>
            {
                var apiCallPath = "/MSExcel/GetCountrySetting";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSExcelGetCountrySetting = new JObject();
                var mSExcelGetCountrySettingpropCount = 0;
                if (__workflow_mSExcelGetCountrySettinghandle != null)
                {
                    if (__workflow_mSExcelGetCountrySettinghandle != null)
                    {
                        mSExcelGetCountrySetting["Handle"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetCountrySettinghandle);
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
                mSExcelGetCountrySetting["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetCountrySettingworkflow);
                if (mSExcelGetCountrySettingpropCount > 0)
                {
                    callPayload.Body = mSExcelGetCountrySetting;
                }

                return new ApiConnectionAction<MSExcelGetCountrySettingResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelWriteCollection(Expression<Func<string>> mSExcelWriteCollectioncellReference, Expression<Func<string>> mSExcelWriteCollectioncollectionToWriteJSON, Expression<Func<string>> mSExcelWriteCollectionworkflow, Expression<Func<int>> mSExcelWriteCollectionhandle = null, Expression<Func<string>> mSExcelWriteCollectionworkbookName = null, Expression<Func<string>> mSExcelWriteCollectionworksheetName = null, Expression<Func<bool>> mSExcelWriteCollectionincludeColumnNames = null)
        {
            var __workflow_mSExcelWriteCollectioncellReference = mSExcelWriteCollectioncellReference == null ? null : WorkflowExpression.Compile(mSExcelWriteCollectioncellReference);
            WorkflowExpression.Validate(__workflow_mSExcelWriteCollectioncellReference, nameof(mSExcelWriteCollectioncellReference), required: true);
            var __workflow_mSExcelWriteCollectioncollectionToWriteJSON = mSExcelWriteCollectioncollectionToWriteJSON == null ? null : WorkflowExpression.Compile(mSExcelWriteCollectioncollectionToWriteJSON);
            WorkflowExpression.Validate(__workflow_mSExcelWriteCollectioncollectionToWriteJSON, nameof(mSExcelWriteCollectioncollectionToWriteJSON), required: true);
            var __workflow_mSExcelWriteCollectionworkflow = mSExcelWriteCollectionworkflow == null ? null : WorkflowExpression.Compile(mSExcelWriteCollectionworkflow);
            WorkflowExpression.Validate(__workflow_mSExcelWriteCollectionworkflow, nameof(mSExcelWriteCollectionworkflow), required: true);
            var __workflow_mSExcelWriteCollectionhandle = mSExcelWriteCollectionhandle == null ? null : WorkflowExpression.Compile(mSExcelWriteCollectionhandle);
            WorkflowExpression.Validate(__workflow_mSExcelWriteCollectionhandle, nameof(mSExcelWriteCollectionhandle), required: false);
            var __workflow_mSExcelWriteCollectionworkbookName = mSExcelWriteCollectionworkbookName == null ? null : WorkflowExpression.Compile(mSExcelWriteCollectionworkbookName);
            WorkflowExpression.Validate(__workflow_mSExcelWriteCollectionworkbookName, nameof(mSExcelWriteCollectionworkbookName), required: false);
            var __workflow_mSExcelWriteCollectionworksheetName = mSExcelWriteCollectionworksheetName == null ? null : WorkflowExpression.Compile(mSExcelWriteCollectionworksheetName);
            WorkflowExpression.Validate(__workflow_mSExcelWriteCollectionworksheetName, nameof(mSExcelWriteCollectionworksheetName), required: false);
            var __workflow_mSExcelWriteCollectionincludeColumnNames = mSExcelWriteCollectionincludeColumnNames == null ? null : WorkflowExpression.Compile(mSExcelWriteCollectionincludeColumnNames);
            WorkflowExpression.Validate(__workflow_mSExcelWriteCollectionincludeColumnNames, nameof(mSExcelWriteCollectionincludeColumnNames), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/MSExcel/WriteCollection";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSExcelWriteCollection = new JObject();
                var mSExcelWriteCollectionpropCount = 0;
                if (__workflow_mSExcelWriteCollectionhandle != null)
                {
                    if (__workflow_mSExcelWriteCollectionhandle != null)
                    {
                        mSExcelWriteCollection["Handle"] = ExpressionConverter.ConvertO(__workflow_mSExcelWriteCollectionhandle);
                        mSExcelWriteCollectionpropCount++;
                    }

                    mSExcelWriteCollectionpropCount++;
                }
                else
                {
                    mSExcelWriteCollection["Handle"] = 0;
                    mSExcelWriteCollectionpropCount++;
                }

                if (__workflow_mSExcelWriteCollectionworkbookName != null)
                {
                    mSExcelWriteCollection["WorkbookName"] = ExpressionConverter.ConvertO(__workflow_mSExcelWriteCollectionworkbookName);
                    mSExcelWriteCollectionpropCount++;
                }

                if (__workflow_mSExcelWriteCollectionworksheetName != null)
                {
                    mSExcelWriteCollection["WorksheetName"] = ExpressionConverter.ConvertO(__workflow_mSExcelWriteCollectionworksheetName);
                    mSExcelWriteCollectionpropCount++;
                }

                mSExcelWriteCollectionpropCount++;
                mSExcelWriteCollection["CellReference"] = ExpressionConverter.ConvertO(__workflow_mSExcelWriteCollectioncellReference);
                mSExcelWriteCollectionpropCount++;
                mSExcelWriteCollection["CollectionToWriteJSON"] = ExpressionConverter.ConvertO(__workflow_mSExcelWriteCollectioncollectionToWriteJSON);
                if (__workflow_mSExcelWriteCollectionincludeColumnNames != null)
                {
                    if (__workflow_mSExcelWriteCollectionincludeColumnNames != null)
                    {
                        mSExcelWriteCollection["IncludeColumnNames"] = ExpressionConverter.ConvertO(__workflow_mSExcelWriteCollectionincludeColumnNames);
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
                mSExcelWriteCollection["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSExcelWriteCollectionworkflow);
                if (mSExcelWriteCollectionpropCount > 0)
                {
                    callPayload.Body = mSExcelWriteCollection;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelWriteCollectionWithDates(Expression<Func<string>> mSExcelWriteCollectionWithDatescellReference, Expression<Func<string>> mSExcelWriteCollectionWithDatescollectionToWriteJSON, Expression<Func<string>> mSExcelWriteCollectionWithDatesworkflow, Expression<Func<int>> mSExcelWriteCollectionWithDateshandle = null, Expression<Func<string>> mSExcelWriteCollectionWithDatesworkbookName = null, Expression<Func<string>> mSExcelWriteCollectionWithDatesworksheetName = null, Expression<Func<bool>> mSExcelWriteCollectionWithDatesincludeColumnNames = null, Expression<Func<bool>> mSExcelWriteCollectionWithDatestryToConvertAllFieldsToDate = null, Expression<Func<string>> mSExcelWriteCollectionWithDatescolumnsToConvertToDateJSON = null)
        {
            var __workflow_mSExcelWriteCollectionWithDatescellReference = mSExcelWriteCollectionWithDatescellReference == null ? null : WorkflowExpression.Compile(mSExcelWriteCollectionWithDatescellReference);
            WorkflowExpression.Validate(__workflow_mSExcelWriteCollectionWithDatescellReference, nameof(mSExcelWriteCollectionWithDatescellReference), required: true);
            var __workflow_mSExcelWriteCollectionWithDatescollectionToWriteJSON = mSExcelWriteCollectionWithDatescollectionToWriteJSON == null ? null : WorkflowExpression.Compile(mSExcelWriteCollectionWithDatescollectionToWriteJSON);
            WorkflowExpression.Validate(__workflow_mSExcelWriteCollectionWithDatescollectionToWriteJSON, nameof(mSExcelWriteCollectionWithDatescollectionToWriteJSON), required: true);
            var __workflow_mSExcelWriteCollectionWithDatesworkflow = mSExcelWriteCollectionWithDatesworkflow == null ? null : WorkflowExpression.Compile(mSExcelWriteCollectionWithDatesworkflow);
            WorkflowExpression.Validate(__workflow_mSExcelWriteCollectionWithDatesworkflow, nameof(mSExcelWriteCollectionWithDatesworkflow), required: true);
            var __workflow_mSExcelWriteCollectionWithDateshandle = mSExcelWriteCollectionWithDateshandle == null ? null : WorkflowExpression.Compile(mSExcelWriteCollectionWithDateshandle);
            WorkflowExpression.Validate(__workflow_mSExcelWriteCollectionWithDateshandle, nameof(mSExcelWriteCollectionWithDateshandle), required: false);
            var __workflow_mSExcelWriteCollectionWithDatesworkbookName = mSExcelWriteCollectionWithDatesworkbookName == null ? null : WorkflowExpression.Compile(mSExcelWriteCollectionWithDatesworkbookName);
            WorkflowExpression.Validate(__workflow_mSExcelWriteCollectionWithDatesworkbookName, nameof(mSExcelWriteCollectionWithDatesworkbookName), required: false);
            var __workflow_mSExcelWriteCollectionWithDatesworksheetName = mSExcelWriteCollectionWithDatesworksheetName == null ? null : WorkflowExpression.Compile(mSExcelWriteCollectionWithDatesworksheetName);
            WorkflowExpression.Validate(__workflow_mSExcelWriteCollectionWithDatesworksheetName, nameof(mSExcelWriteCollectionWithDatesworksheetName), required: false);
            var __workflow_mSExcelWriteCollectionWithDatesincludeColumnNames = mSExcelWriteCollectionWithDatesincludeColumnNames == null ? null : WorkflowExpression.Compile(mSExcelWriteCollectionWithDatesincludeColumnNames);
            WorkflowExpression.Validate(__workflow_mSExcelWriteCollectionWithDatesincludeColumnNames, nameof(mSExcelWriteCollectionWithDatesincludeColumnNames), required: false);
            var __workflow_mSExcelWriteCollectionWithDatestryToConvertAllFieldsToDate = mSExcelWriteCollectionWithDatestryToConvertAllFieldsToDate == null ? null : WorkflowExpression.Compile(mSExcelWriteCollectionWithDatestryToConvertAllFieldsToDate);
            WorkflowExpression.Validate(__workflow_mSExcelWriteCollectionWithDatestryToConvertAllFieldsToDate, nameof(mSExcelWriteCollectionWithDatestryToConvertAllFieldsToDate), required: false);
            var __workflow_mSExcelWriteCollectionWithDatescolumnsToConvertToDateJSON = mSExcelWriteCollectionWithDatescolumnsToConvertToDateJSON == null ? null : WorkflowExpression.Compile(mSExcelWriteCollectionWithDatescolumnsToConvertToDateJSON);
            WorkflowExpression.Validate(__workflow_mSExcelWriteCollectionWithDatescolumnsToConvertToDateJSON, nameof(mSExcelWriteCollectionWithDatescolumnsToConvertToDateJSON), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/MSExcel/WriteCollectionWithDates";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSExcelWriteCollectionWithDates = new JObject();
                var mSExcelWriteCollectionWithDatespropCount = 0;
                if (__workflow_mSExcelWriteCollectionWithDateshandle != null)
                {
                    if (__workflow_mSExcelWriteCollectionWithDateshandle != null)
                    {
                        mSExcelWriteCollectionWithDates["Handle"] = ExpressionConverter.ConvertO(__workflow_mSExcelWriteCollectionWithDateshandle);
                        mSExcelWriteCollectionWithDatespropCount++;
                    }

                    mSExcelWriteCollectionWithDatespropCount++;
                }
                else
                {
                    mSExcelWriteCollectionWithDates["Handle"] = 0;
                    mSExcelWriteCollectionWithDatespropCount++;
                }

                if (__workflow_mSExcelWriteCollectionWithDatesworkbookName != null)
                {
                    mSExcelWriteCollectionWithDates["WorkbookName"] = ExpressionConverter.ConvertO(__workflow_mSExcelWriteCollectionWithDatesworkbookName);
                    mSExcelWriteCollectionWithDatespropCount++;
                }

                if (__workflow_mSExcelWriteCollectionWithDatesworksheetName != null)
                {
                    mSExcelWriteCollectionWithDates["WorksheetName"] = ExpressionConverter.ConvertO(__workflow_mSExcelWriteCollectionWithDatesworksheetName);
                    mSExcelWriteCollectionWithDatespropCount++;
                }

                mSExcelWriteCollectionWithDatespropCount++;
                mSExcelWriteCollectionWithDates["CellReference"] = ExpressionConverter.ConvertO(__workflow_mSExcelWriteCollectionWithDatescellReference);
                mSExcelWriteCollectionWithDatespropCount++;
                mSExcelWriteCollectionWithDates["CollectionToWriteJSON"] = ExpressionConverter.ConvertO(__workflow_mSExcelWriteCollectionWithDatescollectionToWriteJSON);
                if (__workflow_mSExcelWriteCollectionWithDatesincludeColumnNames != null)
                {
                    if (__workflow_mSExcelWriteCollectionWithDatesincludeColumnNames != null)
                    {
                        mSExcelWriteCollectionWithDates["IncludeColumnNames"] = ExpressionConverter.ConvertO(__workflow_mSExcelWriteCollectionWithDatesincludeColumnNames);
                        mSExcelWriteCollectionWithDatespropCount++;
                    }

                    mSExcelWriteCollectionWithDatespropCount++;
                }
                else
                {
                    mSExcelWriteCollectionWithDates["IncludeColumnNames"] = false;
                    mSExcelWriteCollectionWithDatespropCount++;
                }

                if (__workflow_mSExcelWriteCollectionWithDatestryToConvertAllFieldsToDate != null)
                {
                    if (__workflow_mSExcelWriteCollectionWithDatestryToConvertAllFieldsToDate != null)
                    {
                        mSExcelWriteCollectionWithDates["TryToConvertAllFieldsToDate"] = ExpressionConverter.ConvertO(__workflow_mSExcelWriteCollectionWithDatestryToConvertAllFieldsToDate);
                        mSExcelWriteCollectionWithDatespropCount++;
                    }

                    mSExcelWriteCollectionWithDatespropCount++;
                }
                else
                {
                    mSExcelWriteCollectionWithDates["TryToConvertAllFieldsToDate"] = false;
                    mSExcelWriteCollectionWithDatespropCount++;
                }

                if (__workflow_mSExcelWriteCollectionWithDatescolumnsToConvertToDateJSON != null)
                {
                    mSExcelWriteCollectionWithDates["ColumnsToConvertToDateJSON"] = ExpressionConverter.ConvertO(__workflow_mSExcelWriteCollectionWithDatescolumnsToConvertToDateJSON);
                    mSExcelWriteCollectionWithDatespropCount++;
                }

                mSExcelWriteCollectionWithDatespropCount++;
                mSExcelWriteCollectionWithDates["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSExcelWriteCollectionWithDatesworkflow);
                if (mSExcelWriteCollectionWithDatespropCount > 0)
                {
                    callPayload.Body = mSExcelWriteCollectionWithDates;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetActiveCellResponse> MSExcelGetActiveCell(Expression<Func<string>> mSExcelGetActiveCellworkflow, Expression<Func<int>> mSExcelGetActiveCellhandle = null)
        {
            var __workflow_mSExcelGetActiveCellworkflow = mSExcelGetActiveCellworkflow == null ? null : WorkflowExpression.Compile(mSExcelGetActiveCellworkflow);
            WorkflowExpression.Validate(__workflow_mSExcelGetActiveCellworkflow, nameof(mSExcelGetActiveCellworkflow), required: true);
            var __workflow_mSExcelGetActiveCellhandle = mSExcelGetActiveCellhandle == null ? null : WorkflowExpression.Compile(mSExcelGetActiveCellhandle);
            WorkflowExpression.Validate(__workflow_mSExcelGetActiveCellhandle, nameof(mSExcelGetActiveCellhandle), required: false);
            return new DeferredBodyAction<MSExcelGetActiveCellResponse>(() =>
            {
                var apiCallPath = "/MSExcel/GetActiveCell";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSExcelGetActiveCell = new JObject();
                var mSExcelGetActiveCellpropCount = 0;
                if (__workflow_mSExcelGetActiveCellhandle != null)
                {
                    if (__workflow_mSExcelGetActiveCellhandle != null)
                    {
                        mSExcelGetActiveCell["Handle"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetActiveCellhandle);
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
                mSExcelGetActiveCell["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetActiveCellworkflow);
                if (mSExcelGetActiveCellpropCount > 0)
                {
                    callPayload.Body = mSExcelGetActiveCell;
                }

                return new ApiConnectionAction<MSExcelGetActiveCellResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelFormatCell(Expression<Func<string>> mSExcelFormatCellcellReference, Expression<Func<string>> mSExcelFormatCellcellFormat, Expression<Func<string>> mSExcelFormatCellworkflow, Expression<Func<int>> mSExcelFormatCellhandle = null, Expression<Func<string>> mSExcelFormatCellworkbookName = null, Expression<Func<string>> mSExcelFormatCellworksheetName = null)
        {
            var __workflow_mSExcelFormatCellcellReference = mSExcelFormatCellcellReference == null ? null : WorkflowExpression.Compile(mSExcelFormatCellcellReference);
            WorkflowExpression.Validate(__workflow_mSExcelFormatCellcellReference, nameof(mSExcelFormatCellcellReference), required: true);
            var __workflow_mSExcelFormatCellcellFormat = mSExcelFormatCellcellFormat == null ? null : WorkflowExpression.Compile(mSExcelFormatCellcellFormat);
            WorkflowExpression.Validate(__workflow_mSExcelFormatCellcellFormat, nameof(mSExcelFormatCellcellFormat), required: true);
            var __workflow_mSExcelFormatCellworkflow = mSExcelFormatCellworkflow == null ? null : WorkflowExpression.Compile(mSExcelFormatCellworkflow);
            WorkflowExpression.Validate(__workflow_mSExcelFormatCellworkflow, nameof(mSExcelFormatCellworkflow), required: true);
            var __workflow_mSExcelFormatCellhandle = mSExcelFormatCellhandle == null ? null : WorkflowExpression.Compile(mSExcelFormatCellhandle);
            WorkflowExpression.Validate(__workflow_mSExcelFormatCellhandle, nameof(mSExcelFormatCellhandle), required: false);
            var __workflow_mSExcelFormatCellworkbookName = mSExcelFormatCellworkbookName == null ? null : WorkflowExpression.Compile(mSExcelFormatCellworkbookName);
            WorkflowExpression.Validate(__workflow_mSExcelFormatCellworkbookName, nameof(mSExcelFormatCellworkbookName), required: false);
            var __workflow_mSExcelFormatCellworksheetName = mSExcelFormatCellworksheetName == null ? null : WorkflowExpression.Compile(mSExcelFormatCellworksheetName);
            WorkflowExpression.Validate(__workflow_mSExcelFormatCellworksheetName, nameof(mSExcelFormatCellworksheetName), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/MSExcel/FormatCell";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSExcelFormatCell = new JObject();
                var mSExcelFormatCellpropCount = 0;
                if (__workflow_mSExcelFormatCellhandle != null)
                {
                    if (__workflow_mSExcelFormatCellhandle != null)
                    {
                        mSExcelFormatCell["Handle"] = ExpressionConverter.ConvertO(__workflow_mSExcelFormatCellhandle);
                        mSExcelFormatCellpropCount++;
                    }

                    mSExcelFormatCellpropCount++;
                }
                else
                {
                    mSExcelFormatCell["Handle"] = 0;
                    mSExcelFormatCellpropCount++;
                }

                if (__workflow_mSExcelFormatCellworkbookName != null)
                {
                    mSExcelFormatCell["WorkbookName"] = ExpressionConverter.ConvertO(__workflow_mSExcelFormatCellworkbookName);
                    mSExcelFormatCellpropCount++;
                }

                if (__workflow_mSExcelFormatCellworksheetName != null)
                {
                    mSExcelFormatCell["WorksheetName"] = ExpressionConverter.ConvertO(__workflow_mSExcelFormatCellworksheetName);
                    mSExcelFormatCellpropCount++;
                }

                mSExcelFormatCellpropCount++;
                mSExcelFormatCell["CellReference"] = ExpressionConverter.ConvertO(__workflow_mSExcelFormatCellcellReference);
                mSExcelFormatCellpropCount++;
                mSExcelFormatCell["CellFormat"] = ExpressionConverter.ConvertO(__workflow_mSExcelFormatCellcellFormat);
                mSExcelFormatCellpropCount++;
                mSExcelFormatCell["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSExcelFormatCellworkflow);
                if (mSExcelFormatCellpropCount > 0)
                {
                    callPayload.Body = mSExcelFormatCell;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelFormatCurrentCell(Expression<Func<string>> mSExcelFormatCurrentCellcellFormat, Expression<Func<string>> mSExcelFormatCurrentCellworkflow, Expression<Func<int>> mSExcelFormatCurrentCellhandle = null)
        {
            var __workflow_mSExcelFormatCurrentCellcellFormat = mSExcelFormatCurrentCellcellFormat == null ? null : WorkflowExpression.Compile(mSExcelFormatCurrentCellcellFormat);
            WorkflowExpression.Validate(__workflow_mSExcelFormatCurrentCellcellFormat, nameof(mSExcelFormatCurrentCellcellFormat), required: true);
            var __workflow_mSExcelFormatCurrentCellworkflow = mSExcelFormatCurrentCellworkflow == null ? null : WorkflowExpression.Compile(mSExcelFormatCurrentCellworkflow);
            WorkflowExpression.Validate(__workflow_mSExcelFormatCurrentCellworkflow, nameof(mSExcelFormatCurrentCellworkflow), required: true);
            var __workflow_mSExcelFormatCurrentCellhandle = mSExcelFormatCurrentCellhandle == null ? null : WorkflowExpression.Compile(mSExcelFormatCurrentCellhandle);
            WorkflowExpression.Validate(__workflow_mSExcelFormatCurrentCellhandle, nameof(mSExcelFormatCurrentCellhandle), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/MSExcel/FormatCurrentCell";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSExcelFormatCurrentCell = new JObject();
                var mSExcelFormatCurrentCellpropCount = 0;
                if (__workflow_mSExcelFormatCurrentCellhandle != null)
                {
                    if (__workflow_mSExcelFormatCurrentCellhandle != null)
                    {
                        mSExcelFormatCurrentCell["Handle"] = ExpressionConverter.ConvertO(__workflow_mSExcelFormatCurrentCellhandle);
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
                mSExcelFormatCurrentCell["CellFormat"] = ExpressionConverter.ConvertO(__workflow_mSExcelFormatCurrentCellcellFormat);
                mSExcelFormatCurrentCellpropCount++;
                mSExcelFormatCurrentCell["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSExcelFormatCurrentCellworkflow);
                if (mSExcelFormatCurrentCellpropCount > 0)
                {
                    callPayload.Body = mSExcelFormatCurrentCell;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelSelectCellRange(Expression<Func<string>> mSExcelSelectCellRangecellReference, Expression<Func<string>> mSExcelSelectCellRangeworkflow, Expression<Func<int>> mSExcelSelectCellRangehandle = null, Expression<Func<string>> mSExcelSelectCellRangeworkbookName = null, Expression<Func<string>> mSExcelSelectCellRangeworksheetName = null, Expression<Func<bool>> mSExcelSelectCellRangeentireRow = null, Expression<Func<bool>> mSExcelSelectCellRangeentireColumn = null)
        {
            var __workflow_mSExcelSelectCellRangecellReference = mSExcelSelectCellRangecellReference == null ? null : WorkflowExpression.Compile(mSExcelSelectCellRangecellReference);
            WorkflowExpression.Validate(__workflow_mSExcelSelectCellRangecellReference, nameof(mSExcelSelectCellRangecellReference), required: true);
            var __workflow_mSExcelSelectCellRangeworkflow = mSExcelSelectCellRangeworkflow == null ? null : WorkflowExpression.Compile(mSExcelSelectCellRangeworkflow);
            WorkflowExpression.Validate(__workflow_mSExcelSelectCellRangeworkflow, nameof(mSExcelSelectCellRangeworkflow), required: true);
            var __workflow_mSExcelSelectCellRangehandle = mSExcelSelectCellRangehandle == null ? null : WorkflowExpression.Compile(mSExcelSelectCellRangehandle);
            WorkflowExpression.Validate(__workflow_mSExcelSelectCellRangehandle, nameof(mSExcelSelectCellRangehandle), required: false);
            var __workflow_mSExcelSelectCellRangeworkbookName = mSExcelSelectCellRangeworkbookName == null ? null : WorkflowExpression.Compile(mSExcelSelectCellRangeworkbookName);
            WorkflowExpression.Validate(__workflow_mSExcelSelectCellRangeworkbookName, nameof(mSExcelSelectCellRangeworkbookName), required: false);
            var __workflow_mSExcelSelectCellRangeworksheetName = mSExcelSelectCellRangeworksheetName == null ? null : WorkflowExpression.Compile(mSExcelSelectCellRangeworksheetName);
            WorkflowExpression.Validate(__workflow_mSExcelSelectCellRangeworksheetName, nameof(mSExcelSelectCellRangeworksheetName), required: false);
            var __workflow_mSExcelSelectCellRangeentireRow = mSExcelSelectCellRangeentireRow == null ? null : WorkflowExpression.Compile(mSExcelSelectCellRangeentireRow);
            WorkflowExpression.Validate(__workflow_mSExcelSelectCellRangeentireRow, nameof(mSExcelSelectCellRangeentireRow), required: false);
            var __workflow_mSExcelSelectCellRangeentireColumn = mSExcelSelectCellRangeentireColumn == null ? null : WorkflowExpression.Compile(mSExcelSelectCellRangeentireColumn);
            WorkflowExpression.Validate(__workflow_mSExcelSelectCellRangeentireColumn, nameof(mSExcelSelectCellRangeentireColumn), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/MSExcel/SelectCellRange";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSExcelSelectCellRange = new JObject();
                var mSExcelSelectCellRangepropCount = 0;
                if (__workflow_mSExcelSelectCellRangehandle != null)
                {
                    if (__workflow_mSExcelSelectCellRangehandle != null)
                    {
                        mSExcelSelectCellRange["Handle"] = ExpressionConverter.ConvertO(__workflow_mSExcelSelectCellRangehandle);
                        mSExcelSelectCellRangepropCount++;
                    }

                    mSExcelSelectCellRangepropCount++;
                }
                else
                {
                    mSExcelSelectCellRange["Handle"] = 0;
                    mSExcelSelectCellRangepropCount++;
                }

                if (__workflow_mSExcelSelectCellRangeworkbookName != null)
                {
                    mSExcelSelectCellRange["WorkbookName"] = ExpressionConverter.ConvertO(__workflow_mSExcelSelectCellRangeworkbookName);
                    mSExcelSelectCellRangepropCount++;
                }

                if (__workflow_mSExcelSelectCellRangeworksheetName != null)
                {
                    mSExcelSelectCellRange["WorksheetName"] = ExpressionConverter.ConvertO(__workflow_mSExcelSelectCellRangeworksheetName);
                    mSExcelSelectCellRangepropCount++;
                }

                mSExcelSelectCellRangepropCount++;
                mSExcelSelectCellRange["CellReference"] = ExpressionConverter.ConvertO(__workflow_mSExcelSelectCellRangecellReference);
                if (__workflow_mSExcelSelectCellRangeentireRow != null)
                {
                    if (__workflow_mSExcelSelectCellRangeentireRow != null)
                    {
                        mSExcelSelectCellRange["EntireRow"] = ExpressionConverter.ConvertO(__workflow_mSExcelSelectCellRangeentireRow);
                        mSExcelSelectCellRangepropCount++;
                    }

                    mSExcelSelectCellRangepropCount++;
                }
                else
                {
                    mSExcelSelectCellRange["EntireRow"] = false;
                    mSExcelSelectCellRangepropCount++;
                }

                if (__workflow_mSExcelSelectCellRangeentireColumn != null)
                {
                    if (__workflow_mSExcelSelectCellRangeentireColumn != null)
                    {
                        mSExcelSelectCellRange["EntireColumn"] = ExpressionConverter.ConvertO(__workflow_mSExcelSelectCellRangeentireColumn);
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
                mSExcelSelectCellRange["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSExcelSelectCellRangeworkflow);
                if (mSExcelSelectCellRangepropCount > 0)
                {
                    callPayload.Body = mSExcelSelectCellRange;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelCopySelection(Expression<Func<string>> mSExcelCopySelectionworkflow, Expression<Func<int>> mSExcelCopySelectionhandle = null, Expression<Func<string>> mSExcelCopySelectionworkbookName = null, Expression<Func<string>> mSExcelCopySelectionworksheetName = null, Expression<Func<string>> mSExcelCopySelectioncellReference = null, Expression<Func<bool>> mSExcelCopySelectionentireRow = null, Expression<Func<bool>> mSExcelCopySelectionentireColumn = null)
        {
            var __workflow_mSExcelCopySelectionworkflow = mSExcelCopySelectionworkflow == null ? null : WorkflowExpression.Compile(mSExcelCopySelectionworkflow);
            WorkflowExpression.Validate(__workflow_mSExcelCopySelectionworkflow, nameof(mSExcelCopySelectionworkflow), required: true);
            var __workflow_mSExcelCopySelectionhandle = mSExcelCopySelectionhandle == null ? null : WorkflowExpression.Compile(mSExcelCopySelectionhandle);
            WorkflowExpression.Validate(__workflow_mSExcelCopySelectionhandle, nameof(mSExcelCopySelectionhandle), required: false);
            var __workflow_mSExcelCopySelectionworkbookName = mSExcelCopySelectionworkbookName == null ? null : WorkflowExpression.Compile(mSExcelCopySelectionworkbookName);
            WorkflowExpression.Validate(__workflow_mSExcelCopySelectionworkbookName, nameof(mSExcelCopySelectionworkbookName), required: false);
            var __workflow_mSExcelCopySelectionworksheetName = mSExcelCopySelectionworksheetName == null ? null : WorkflowExpression.Compile(mSExcelCopySelectionworksheetName);
            WorkflowExpression.Validate(__workflow_mSExcelCopySelectionworksheetName, nameof(mSExcelCopySelectionworksheetName), required: false);
            var __workflow_mSExcelCopySelectioncellReference = mSExcelCopySelectioncellReference == null ? null : WorkflowExpression.Compile(mSExcelCopySelectioncellReference);
            WorkflowExpression.Validate(__workflow_mSExcelCopySelectioncellReference, nameof(mSExcelCopySelectioncellReference), required: false);
            var __workflow_mSExcelCopySelectionentireRow = mSExcelCopySelectionentireRow == null ? null : WorkflowExpression.Compile(mSExcelCopySelectionentireRow);
            WorkflowExpression.Validate(__workflow_mSExcelCopySelectionentireRow, nameof(mSExcelCopySelectionentireRow), required: false);
            var __workflow_mSExcelCopySelectionentireColumn = mSExcelCopySelectionentireColumn == null ? null : WorkflowExpression.Compile(mSExcelCopySelectionentireColumn);
            WorkflowExpression.Validate(__workflow_mSExcelCopySelectionentireColumn, nameof(mSExcelCopySelectionentireColumn), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/MSExcel/CopySelection";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSExcelCopySelection = new JObject();
                var mSExcelCopySelectionpropCount = 0;
                if (__workflow_mSExcelCopySelectionhandle != null)
                {
                    if (__workflow_mSExcelCopySelectionhandle != null)
                    {
                        mSExcelCopySelection["Handle"] = ExpressionConverter.ConvertO(__workflow_mSExcelCopySelectionhandle);
                        mSExcelCopySelectionpropCount++;
                    }

                    mSExcelCopySelectionpropCount++;
                }
                else
                {
                    mSExcelCopySelection["Handle"] = 0;
                    mSExcelCopySelectionpropCount++;
                }

                if (__workflow_mSExcelCopySelectionworkbookName != null)
                {
                    mSExcelCopySelection["WorkbookName"] = ExpressionConverter.ConvertO(__workflow_mSExcelCopySelectionworkbookName);
                    mSExcelCopySelectionpropCount++;
                }

                if (__workflow_mSExcelCopySelectionworksheetName != null)
                {
                    mSExcelCopySelection["WorksheetName"] = ExpressionConverter.ConvertO(__workflow_mSExcelCopySelectionworksheetName);
                    mSExcelCopySelectionpropCount++;
                }

                if (__workflow_mSExcelCopySelectioncellReference != null)
                {
                    mSExcelCopySelection["CellReference"] = ExpressionConverter.ConvertO(__workflow_mSExcelCopySelectioncellReference);
                    mSExcelCopySelectionpropCount++;
                }

                if (__workflow_mSExcelCopySelectionentireRow != null)
                {
                    if (__workflow_mSExcelCopySelectionentireRow != null)
                    {
                        mSExcelCopySelection["EntireRow"] = ExpressionConverter.ConvertO(__workflow_mSExcelCopySelectionentireRow);
                        mSExcelCopySelectionpropCount++;
                    }

                    mSExcelCopySelectionpropCount++;
                }
                else
                {
                    mSExcelCopySelection["EntireRow"] = false;
                    mSExcelCopySelectionpropCount++;
                }

                if (__workflow_mSExcelCopySelectionentireColumn != null)
                {
                    if (__workflow_mSExcelCopySelectionentireColumn != null)
                    {
                        mSExcelCopySelection["EntireColumn"] = ExpressionConverter.ConvertO(__workflow_mSExcelCopySelectionentireColumn);
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
                mSExcelCopySelection["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSExcelCopySelectionworkflow);
                if (mSExcelCopySelectionpropCount > 0)
                {
                    callPayload.Body = mSExcelCopySelection;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelCutSelection(Expression<Func<string>> mSExcelCutSelectionworkflow, Expression<Func<int>> mSExcelCutSelectionhandle = null, Expression<Func<string>> mSExcelCutSelectionworkbookName = null, Expression<Func<string>> mSExcelCutSelectionworksheetName = null, Expression<Func<string>> mSExcelCutSelectioncellReference = null, Expression<Func<bool>> mSExcelCutSelectionentireRow = null, Expression<Func<bool>> mSExcelCutSelectionentireColumn = null)
        {
            var __workflow_mSExcelCutSelectionworkflow = mSExcelCutSelectionworkflow == null ? null : WorkflowExpression.Compile(mSExcelCutSelectionworkflow);
            WorkflowExpression.Validate(__workflow_mSExcelCutSelectionworkflow, nameof(mSExcelCutSelectionworkflow), required: true);
            var __workflow_mSExcelCutSelectionhandle = mSExcelCutSelectionhandle == null ? null : WorkflowExpression.Compile(mSExcelCutSelectionhandle);
            WorkflowExpression.Validate(__workflow_mSExcelCutSelectionhandle, nameof(mSExcelCutSelectionhandle), required: false);
            var __workflow_mSExcelCutSelectionworkbookName = mSExcelCutSelectionworkbookName == null ? null : WorkflowExpression.Compile(mSExcelCutSelectionworkbookName);
            WorkflowExpression.Validate(__workflow_mSExcelCutSelectionworkbookName, nameof(mSExcelCutSelectionworkbookName), required: false);
            var __workflow_mSExcelCutSelectionworksheetName = mSExcelCutSelectionworksheetName == null ? null : WorkflowExpression.Compile(mSExcelCutSelectionworksheetName);
            WorkflowExpression.Validate(__workflow_mSExcelCutSelectionworksheetName, nameof(mSExcelCutSelectionworksheetName), required: false);
            var __workflow_mSExcelCutSelectioncellReference = mSExcelCutSelectioncellReference == null ? null : WorkflowExpression.Compile(mSExcelCutSelectioncellReference);
            WorkflowExpression.Validate(__workflow_mSExcelCutSelectioncellReference, nameof(mSExcelCutSelectioncellReference), required: false);
            var __workflow_mSExcelCutSelectionentireRow = mSExcelCutSelectionentireRow == null ? null : WorkflowExpression.Compile(mSExcelCutSelectionentireRow);
            WorkflowExpression.Validate(__workflow_mSExcelCutSelectionentireRow, nameof(mSExcelCutSelectionentireRow), required: false);
            var __workflow_mSExcelCutSelectionentireColumn = mSExcelCutSelectionentireColumn == null ? null : WorkflowExpression.Compile(mSExcelCutSelectionentireColumn);
            WorkflowExpression.Validate(__workflow_mSExcelCutSelectionentireColumn, nameof(mSExcelCutSelectionentireColumn), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/MSExcel/CutSelection";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSExcelCutSelection = new JObject();
                var mSExcelCutSelectionpropCount = 0;
                if (__workflow_mSExcelCutSelectionhandle != null)
                {
                    if (__workflow_mSExcelCutSelectionhandle != null)
                    {
                        mSExcelCutSelection["Handle"] = ExpressionConverter.ConvertO(__workflow_mSExcelCutSelectionhandle);
                        mSExcelCutSelectionpropCount++;
                    }

                    mSExcelCutSelectionpropCount++;
                }
                else
                {
                    mSExcelCutSelection["Handle"] = 0;
                    mSExcelCutSelectionpropCount++;
                }

                if (__workflow_mSExcelCutSelectionworkbookName != null)
                {
                    mSExcelCutSelection["WorkbookName"] = ExpressionConverter.ConvertO(__workflow_mSExcelCutSelectionworkbookName);
                    mSExcelCutSelectionpropCount++;
                }

                if (__workflow_mSExcelCutSelectionworksheetName != null)
                {
                    mSExcelCutSelection["WorksheetName"] = ExpressionConverter.ConvertO(__workflow_mSExcelCutSelectionworksheetName);
                    mSExcelCutSelectionpropCount++;
                }

                if (__workflow_mSExcelCutSelectioncellReference != null)
                {
                    mSExcelCutSelection["CellReference"] = ExpressionConverter.ConvertO(__workflow_mSExcelCutSelectioncellReference);
                    mSExcelCutSelectionpropCount++;
                }

                if (__workflow_mSExcelCutSelectionentireRow != null)
                {
                    if (__workflow_mSExcelCutSelectionentireRow != null)
                    {
                        mSExcelCutSelection["EntireRow"] = ExpressionConverter.ConvertO(__workflow_mSExcelCutSelectionentireRow);
                        mSExcelCutSelectionpropCount++;
                    }

                    mSExcelCutSelectionpropCount++;
                }
                else
                {
                    mSExcelCutSelection["EntireRow"] = false;
                    mSExcelCutSelectionpropCount++;
                }

                if (__workflow_mSExcelCutSelectionentireColumn != null)
                {
                    if (__workflow_mSExcelCutSelectionentireColumn != null)
                    {
                        mSExcelCutSelection["EntireColumn"] = ExpressionConverter.ConvertO(__workflow_mSExcelCutSelectionentireColumn);
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
                mSExcelCutSelection["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSExcelCutSelectionworkflow);
                if (mSExcelCutSelectionpropCount > 0)
                {
                    callPayload.Body = mSExcelCutSelection;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelPasteIntoSelection(Expression<Func<string>> mSExcelPasteIntoSelectionworkflow, Expression<Func<int>> mSExcelPasteIntoSelectionhandle = null, Expression<Func<string>> mSExcelPasteIntoSelectionworkbookName = null, Expression<Func<string>> mSExcelPasteIntoSelectionworksheetName = null, Expression<Func<bool>> mSExcelPasteIntoSelectionvaluesOnly = null, Expression<Func<bool>> mSExcelPasteIntoSelectionsimplePasteOnly = null, Expression<Func<string>> mSExcelPasteIntoSelectioncellReference = null, Expression<Func<bool>> mSExcelPasteIntoSelectionentireRow = null, Expression<Func<bool>> mSExcelPasteIntoSelectionentireColumn = null)
        {
            var __workflow_mSExcelPasteIntoSelectionworkflow = mSExcelPasteIntoSelectionworkflow == null ? null : WorkflowExpression.Compile(mSExcelPasteIntoSelectionworkflow);
            WorkflowExpression.Validate(__workflow_mSExcelPasteIntoSelectionworkflow, nameof(mSExcelPasteIntoSelectionworkflow), required: true);
            var __workflow_mSExcelPasteIntoSelectionhandle = mSExcelPasteIntoSelectionhandle == null ? null : WorkflowExpression.Compile(mSExcelPasteIntoSelectionhandle);
            WorkflowExpression.Validate(__workflow_mSExcelPasteIntoSelectionhandle, nameof(mSExcelPasteIntoSelectionhandle), required: false);
            var __workflow_mSExcelPasteIntoSelectionworkbookName = mSExcelPasteIntoSelectionworkbookName == null ? null : WorkflowExpression.Compile(mSExcelPasteIntoSelectionworkbookName);
            WorkflowExpression.Validate(__workflow_mSExcelPasteIntoSelectionworkbookName, nameof(mSExcelPasteIntoSelectionworkbookName), required: false);
            var __workflow_mSExcelPasteIntoSelectionworksheetName = mSExcelPasteIntoSelectionworksheetName == null ? null : WorkflowExpression.Compile(mSExcelPasteIntoSelectionworksheetName);
            WorkflowExpression.Validate(__workflow_mSExcelPasteIntoSelectionworksheetName, nameof(mSExcelPasteIntoSelectionworksheetName), required: false);
            var __workflow_mSExcelPasteIntoSelectionvaluesOnly = mSExcelPasteIntoSelectionvaluesOnly == null ? null : WorkflowExpression.Compile(mSExcelPasteIntoSelectionvaluesOnly);
            WorkflowExpression.Validate(__workflow_mSExcelPasteIntoSelectionvaluesOnly, nameof(mSExcelPasteIntoSelectionvaluesOnly), required: false);
            var __workflow_mSExcelPasteIntoSelectionsimplePasteOnly = mSExcelPasteIntoSelectionsimplePasteOnly == null ? null : WorkflowExpression.Compile(mSExcelPasteIntoSelectionsimplePasteOnly);
            WorkflowExpression.Validate(__workflow_mSExcelPasteIntoSelectionsimplePasteOnly, nameof(mSExcelPasteIntoSelectionsimplePasteOnly), required: false);
            var __workflow_mSExcelPasteIntoSelectioncellReference = mSExcelPasteIntoSelectioncellReference == null ? null : WorkflowExpression.Compile(mSExcelPasteIntoSelectioncellReference);
            WorkflowExpression.Validate(__workflow_mSExcelPasteIntoSelectioncellReference, nameof(mSExcelPasteIntoSelectioncellReference), required: false);
            var __workflow_mSExcelPasteIntoSelectionentireRow = mSExcelPasteIntoSelectionentireRow == null ? null : WorkflowExpression.Compile(mSExcelPasteIntoSelectionentireRow);
            WorkflowExpression.Validate(__workflow_mSExcelPasteIntoSelectionentireRow, nameof(mSExcelPasteIntoSelectionentireRow), required: false);
            var __workflow_mSExcelPasteIntoSelectionentireColumn = mSExcelPasteIntoSelectionentireColumn == null ? null : WorkflowExpression.Compile(mSExcelPasteIntoSelectionentireColumn);
            WorkflowExpression.Validate(__workflow_mSExcelPasteIntoSelectionentireColumn, nameof(mSExcelPasteIntoSelectionentireColumn), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/MSExcel/PasteIntoSelection";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSExcelPasteIntoSelection = new JObject();
                var mSExcelPasteIntoSelectionpropCount = 0;
                if (__workflow_mSExcelPasteIntoSelectionhandle != null)
                {
                    if (__workflow_mSExcelPasteIntoSelectionhandle != null)
                    {
                        mSExcelPasteIntoSelection["Handle"] = ExpressionConverter.ConvertO(__workflow_mSExcelPasteIntoSelectionhandle);
                        mSExcelPasteIntoSelectionpropCount++;
                    }

                    mSExcelPasteIntoSelectionpropCount++;
                }
                else
                {
                    mSExcelPasteIntoSelection["Handle"] = 0;
                    mSExcelPasteIntoSelectionpropCount++;
                }

                if (__workflow_mSExcelPasteIntoSelectionworkbookName != null)
                {
                    mSExcelPasteIntoSelection["WorkbookName"] = ExpressionConverter.ConvertO(__workflow_mSExcelPasteIntoSelectionworkbookName);
                    mSExcelPasteIntoSelectionpropCount++;
                }

                if (__workflow_mSExcelPasteIntoSelectionworksheetName != null)
                {
                    mSExcelPasteIntoSelection["WorksheetName"] = ExpressionConverter.ConvertO(__workflow_mSExcelPasteIntoSelectionworksheetName);
                    mSExcelPasteIntoSelectionpropCount++;
                }

                if (__workflow_mSExcelPasteIntoSelectionvaluesOnly != null)
                {
                    if (__workflow_mSExcelPasteIntoSelectionvaluesOnly != null)
                    {
                        mSExcelPasteIntoSelection["ValuesOnly"] = ExpressionConverter.ConvertO(__workflow_mSExcelPasteIntoSelectionvaluesOnly);
                        mSExcelPasteIntoSelectionpropCount++;
                    }

                    mSExcelPasteIntoSelectionpropCount++;
                }
                else
                {
                    mSExcelPasteIntoSelection["ValuesOnly"] = false;
                    mSExcelPasteIntoSelectionpropCount++;
                }

                if (__workflow_mSExcelPasteIntoSelectionsimplePasteOnly != null)
                {
                    if (__workflow_mSExcelPasteIntoSelectionsimplePasteOnly != null)
                    {
                        mSExcelPasteIntoSelection["SimplePasteOnly"] = ExpressionConverter.ConvertO(__workflow_mSExcelPasteIntoSelectionsimplePasteOnly);
                        mSExcelPasteIntoSelectionpropCount++;
                    }

                    mSExcelPasteIntoSelectionpropCount++;
                }
                else
                {
                    mSExcelPasteIntoSelection["SimplePasteOnly"] = false;
                    mSExcelPasteIntoSelectionpropCount++;
                }

                if (__workflow_mSExcelPasteIntoSelectioncellReference != null)
                {
                    mSExcelPasteIntoSelection["CellReference"] = ExpressionConverter.ConvertO(__workflow_mSExcelPasteIntoSelectioncellReference);
                    mSExcelPasteIntoSelectionpropCount++;
                }

                if (__workflow_mSExcelPasteIntoSelectionentireRow != null)
                {
                    if (__workflow_mSExcelPasteIntoSelectionentireRow != null)
                    {
                        mSExcelPasteIntoSelection["EntireRow"] = ExpressionConverter.ConvertO(__workflow_mSExcelPasteIntoSelectionentireRow);
                        mSExcelPasteIntoSelectionpropCount++;
                    }

                    mSExcelPasteIntoSelectionpropCount++;
                }
                else
                {
                    mSExcelPasteIntoSelection["EntireRow"] = false;
                    mSExcelPasteIntoSelectionpropCount++;
                }

                if (__workflow_mSExcelPasteIntoSelectionentireColumn != null)
                {
                    if (__workflow_mSExcelPasteIntoSelectionentireColumn != null)
                    {
                        mSExcelPasteIntoSelection["EntireColumn"] = ExpressionConverter.ConvertO(__workflow_mSExcelPasteIntoSelectionentireColumn);
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
                mSExcelPasteIntoSelection["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSExcelPasteIntoSelectionworkflow);
                if (mSExcelPasteIntoSelectionpropCount > 0)
                {
                    callPayload.Body = mSExcelPasteIntoSelection;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelInsertOnSelection(Expression<Func<string>> mSExcelInsertOnSelectionworkflow, Expression<Func<int>> mSExcelInsertOnSelectionhandle = null, Expression<Func<string>> mSExcelInsertOnSelectionworkbookName = null, Expression<Func<string>> mSExcelInsertOnSelectionworksheetName = null, Expression<Func<string>> mSExcelInsertOnSelectioncellReference = null, Expression<Func<bool>> mSExcelInsertOnSelectionentireRow = null, Expression<Func<bool>> mSExcelInsertOnSelectionentireColumn = null, Expression<Func<mSExcelInsertOnSelectionshiftInput>> mSExcelInsertOnSelectionshift = null)
        {
            var __workflow_mSExcelInsertOnSelectionworkflow = mSExcelInsertOnSelectionworkflow == null ? null : WorkflowExpression.Compile(mSExcelInsertOnSelectionworkflow);
            WorkflowExpression.Validate(__workflow_mSExcelInsertOnSelectionworkflow, nameof(mSExcelInsertOnSelectionworkflow), required: true);
            var __workflow_mSExcelInsertOnSelectionhandle = mSExcelInsertOnSelectionhandle == null ? null : WorkflowExpression.Compile(mSExcelInsertOnSelectionhandle);
            WorkflowExpression.Validate(__workflow_mSExcelInsertOnSelectionhandle, nameof(mSExcelInsertOnSelectionhandle), required: false);
            var __workflow_mSExcelInsertOnSelectionworkbookName = mSExcelInsertOnSelectionworkbookName == null ? null : WorkflowExpression.Compile(mSExcelInsertOnSelectionworkbookName);
            WorkflowExpression.Validate(__workflow_mSExcelInsertOnSelectionworkbookName, nameof(mSExcelInsertOnSelectionworkbookName), required: false);
            var __workflow_mSExcelInsertOnSelectionworksheetName = mSExcelInsertOnSelectionworksheetName == null ? null : WorkflowExpression.Compile(mSExcelInsertOnSelectionworksheetName);
            WorkflowExpression.Validate(__workflow_mSExcelInsertOnSelectionworksheetName, nameof(mSExcelInsertOnSelectionworksheetName), required: false);
            var __workflow_mSExcelInsertOnSelectioncellReference = mSExcelInsertOnSelectioncellReference == null ? null : WorkflowExpression.Compile(mSExcelInsertOnSelectioncellReference);
            WorkflowExpression.Validate(__workflow_mSExcelInsertOnSelectioncellReference, nameof(mSExcelInsertOnSelectioncellReference), required: false);
            var __workflow_mSExcelInsertOnSelectionentireRow = mSExcelInsertOnSelectionentireRow == null ? null : WorkflowExpression.Compile(mSExcelInsertOnSelectionentireRow);
            WorkflowExpression.Validate(__workflow_mSExcelInsertOnSelectionentireRow, nameof(mSExcelInsertOnSelectionentireRow), required: false);
            var __workflow_mSExcelInsertOnSelectionentireColumn = mSExcelInsertOnSelectionentireColumn == null ? null : WorkflowExpression.Compile(mSExcelInsertOnSelectionentireColumn);
            WorkflowExpression.Validate(__workflow_mSExcelInsertOnSelectionentireColumn, nameof(mSExcelInsertOnSelectionentireColumn), required: false);
            var __workflow_mSExcelInsertOnSelectionshift = mSExcelInsertOnSelectionshift == null ? null : WorkflowExpression.Compile(mSExcelInsertOnSelectionshift);
            WorkflowExpression.Validate(__workflow_mSExcelInsertOnSelectionshift, nameof(mSExcelInsertOnSelectionshift), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/MSExcel/InsertOnSelection";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSExcelInsertOnSelection = new JObject();
                var mSExcelInsertOnSelectionpropCount = 0;
                if (__workflow_mSExcelInsertOnSelectionhandle != null)
                {
                    if (__workflow_mSExcelInsertOnSelectionhandle != null)
                    {
                        mSExcelInsertOnSelection["Handle"] = ExpressionConverter.ConvertO(__workflow_mSExcelInsertOnSelectionhandle);
                        mSExcelInsertOnSelectionpropCount++;
                    }

                    mSExcelInsertOnSelectionpropCount++;
                }
                else
                {
                    mSExcelInsertOnSelection["Handle"] = 0;
                    mSExcelInsertOnSelectionpropCount++;
                }

                if (__workflow_mSExcelInsertOnSelectionworkbookName != null)
                {
                    mSExcelInsertOnSelection["WorkbookName"] = ExpressionConverter.ConvertO(__workflow_mSExcelInsertOnSelectionworkbookName);
                    mSExcelInsertOnSelectionpropCount++;
                }

                if (__workflow_mSExcelInsertOnSelectionworksheetName != null)
                {
                    mSExcelInsertOnSelection["WorksheetName"] = ExpressionConverter.ConvertO(__workflow_mSExcelInsertOnSelectionworksheetName);
                    mSExcelInsertOnSelectionpropCount++;
                }

                if (__workflow_mSExcelInsertOnSelectioncellReference != null)
                {
                    mSExcelInsertOnSelection["CellReference"] = ExpressionConverter.ConvertO(__workflow_mSExcelInsertOnSelectioncellReference);
                    mSExcelInsertOnSelectionpropCount++;
                }

                if (__workflow_mSExcelInsertOnSelectionentireRow != null)
                {
                    if (__workflow_mSExcelInsertOnSelectionentireRow != null)
                    {
                        mSExcelInsertOnSelection["EntireRow"] = ExpressionConverter.ConvertO(__workflow_mSExcelInsertOnSelectionentireRow);
                        mSExcelInsertOnSelectionpropCount++;
                    }

                    mSExcelInsertOnSelectionpropCount++;
                }
                else
                {
                    mSExcelInsertOnSelection["EntireRow"] = false;
                    mSExcelInsertOnSelectionpropCount++;
                }

                if (__workflow_mSExcelInsertOnSelectionentireColumn != null)
                {
                    if (__workflow_mSExcelInsertOnSelectionentireColumn != null)
                    {
                        mSExcelInsertOnSelection["EntireColumn"] = ExpressionConverter.ConvertO(__workflow_mSExcelInsertOnSelectionentireColumn);
                        mSExcelInsertOnSelectionpropCount++;
                    }

                    mSExcelInsertOnSelectionpropCount++;
                }
                else
                {
                    mSExcelInsertOnSelection["EntireColumn"] = false;
                    mSExcelInsertOnSelectionpropCount++;
                }

                if (__workflow_mSExcelInsertOnSelectionshift != null)
                {
                    mSExcelInsertOnSelection["Shift"] = ExpressionConverter.ConvertO(__workflow_mSExcelInsertOnSelectionshift);
                    mSExcelInsertOnSelectionpropCount++;
                }

                mSExcelInsertOnSelectionpropCount++;
                mSExcelInsertOnSelection["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSExcelInsertOnSelectionworkflow);
                if (mSExcelInsertOnSelectionpropCount > 0)
                {
                    callPayload.Body = mSExcelInsertOnSelection;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelDeleteSelection(Expression<Func<string>> mSExcelDeleteSelectionworkflow, Expression<Func<int>> mSExcelDeleteSelectionhandle = null, Expression<Func<string>> mSExcelDeleteSelectionworkbookName = null, Expression<Func<string>> mSExcelDeleteSelectionworksheetName = null, Expression<Func<string>> mSExcelDeleteSelectioncellReference = null, Expression<Func<bool>> mSExcelDeleteSelectionentireRow = null, Expression<Func<bool>> mSExcelDeleteSelectionentireColumn = null, Expression<Func<mSExcelDeleteSelectionshiftInput>> mSExcelDeleteSelectionshift = null)
        {
            var __workflow_mSExcelDeleteSelectionworkflow = mSExcelDeleteSelectionworkflow == null ? null : WorkflowExpression.Compile(mSExcelDeleteSelectionworkflow);
            WorkflowExpression.Validate(__workflow_mSExcelDeleteSelectionworkflow, nameof(mSExcelDeleteSelectionworkflow), required: true);
            var __workflow_mSExcelDeleteSelectionhandle = mSExcelDeleteSelectionhandle == null ? null : WorkflowExpression.Compile(mSExcelDeleteSelectionhandle);
            WorkflowExpression.Validate(__workflow_mSExcelDeleteSelectionhandle, nameof(mSExcelDeleteSelectionhandle), required: false);
            var __workflow_mSExcelDeleteSelectionworkbookName = mSExcelDeleteSelectionworkbookName == null ? null : WorkflowExpression.Compile(mSExcelDeleteSelectionworkbookName);
            WorkflowExpression.Validate(__workflow_mSExcelDeleteSelectionworkbookName, nameof(mSExcelDeleteSelectionworkbookName), required: false);
            var __workflow_mSExcelDeleteSelectionworksheetName = mSExcelDeleteSelectionworksheetName == null ? null : WorkflowExpression.Compile(mSExcelDeleteSelectionworksheetName);
            WorkflowExpression.Validate(__workflow_mSExcelDeleteSelectionworksheetName, nameof(mSExcelDeleteSelectionworksheetName), required: false);
            var __workflow_mSExcelDeleteSelectioncellReference = mSExcelDeleteSelectioncellReference == null ? null : WorkflowExpression.Compile(mSExcelDeleteSelectioncellReference);
            WorkflowExpression.Validate(__workflow_mSExcelDeleteSelectioncellReference, nameof(mSExcelDeleteSelectioncellReference), required: false);
            var __workflow_mSExcelDeleteSelectionentireRow = mSExcelDeleteSelectionentireRow == null ? null : WorkflowExpression.Compile(mSExcelDeleteSelectionentireRow);
            WorkflowExpression.Validate(__workflow_mSExcelDeleteSelectionentireRow, nameof(mSExcelDeleteSelectionentireRow), required: false);
            var __workflow_mSExcelDeleteSelectionentireColumn = mSExcelDeleteSelectionentireColumn == null ? null : WorkflowExpression.Compile(mSExcelDeleteSelectionentireColumn);
            WorkflowExpression.Validate(__workflow_mSExcelDeleteSelectionentireColumn, nameof(mSExcelDeleteSelectionentireColumn), required: false);
            var __workflow_mSExcelDeleteSelectionshift = mSExcelDeleteSelectionshift == null ? null : WorkflowExpression.Compile(mSExcelDeleteSelectionshift);
            WorkflowExpression.Validate(__workflow_mSExcelDeleteSelectionshift, nameof(mSExcelDeleteSelectionshift), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/MSExcel/DeleteSelection";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSExcelDeleteSelection = new JObject();
                var mSExcelDeleteSelectionpropCount = 0;
                if (__workflow_mSExcelDeleteSelectionhandle != null)
                {
                    if (__workflow_mSExcelDeleteSelectionhandle != null)
                    {
                        mSExcelDeleteSelection["Handle"] = ExpressionConverter.ConvertO(__workflow_mSExcelDeleteSelectionhandle);
                        mSExcelDeleteSelectionpropCount++;
                    }

                    mSExcelDeleteSelectionpropCount++;
                }
                else
                {
                    mSExcelDeleteSelection["Handle"] = 0;
                    mSExcelDeleteSelectionpropCount++;
                }

                if (__workflow_mSExcelDeleteSelectionworkbookName != null)
                {
                    mSExcelDeleteSelection["WorkbookName"] = ExpressionConverter.ConvertO(__workflow_mSExcelDeleteSelectionworkbookName);
                    mSExcelDeleteSelectionpropCount++;
                }

                if (__workflow_mSExcelDeleteSelectionworksheetName != null)
                {
                    mSExcelDeleteSelection["WorksheetName"] = ExpressionConverter.ConvertO(__workflow_mSExcelDeleteSelectionworksheetName);
                    mSExcelDeleteSelectionpropCount++;
                }

                if (__workflow_mSExcelDeleteSelectioncellReference != null)
                {
                    mSExcelDeleteSelection["CellReference"] = ExpressionConverter.ConvertO(__workflow_mSExcelDeleteSelectioncellReference);
                    mSExcelDeleteSelectionpropCount++;
                }

                if (__workflow_mSExcelDeleteSelectionentireRow != null)
                {
                    if (__workflow_mSExcelDeleteSelectionentireRow != null)
                    {
                        mSExcelDeleteSelection["EntireRow"] = ExpressionConverter.ConvertO(__workflow_mSExcelDeleteSelectionentireRow);
                        mSExcelDeleteSelectionpropCount++;
                    }

                    mSExcelDeleteSelectionpropCount++;
                }
                else
                {
                    mSExcelDeleteSelection["EntireRow"] = false;
                    mSExcelDeleteSelectionpropCount++;
                }

                if (__workflow_mSExcelDeleteSelectionentireColumn != null)
                {
                    if (__workflow_mSExcelDeleteSelectionentireColumn != null)
                    {
                        mSExcelDeleteSelection["EntireColumn"] = ExpressionConverter.ConvertO(__workflow_mSExcelDeleteSelectionentireColumn);
                        mSExcelDeleteSelectionpropCount++;
                    }

                    mSExcelDeleteSelectionpropCount++;
                }
                else
                {
                    mSExcelDeleteSelection["EntireColumn"] = false;
                    mSExcelDeleteSelectionpropCount++;
                }

                if (__workflow_mSExcelDeleteSelectionshift != null)
                {
                    mSExcelDeleteSelection["Shift"] = ExpressionConverter.ConvertO(__workflow_mSExcelDeleteSelectionshift);
                    mSExcelDeleteSelectionpropCount++;
                }

                mSExcelDeleteSelectionpropCount++;
                mSExcelDeleteSelection["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSExcelDeleteSelectionworkflow);
                if (mSExcelDeleteSelectionpropCount > 0)
                {
                    callPayload.Body = mSExcelDeleteSelection;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelClearExcelClipboard(Expression<Func<string>> mSExcelClearExcelClipboardworkflow, Expression<Func<int>> mSExcelClearExcelClipboardhandle = null)
        {
            var __workflow_mSExcelClearExcelClipboardworkflow = mSExcelClearExcelClipboardworkflow == null ? null : WorkflowExpression.Compile(mSExcelClearExcelClipboardworkflow);
            WorkflowExpression.Validate(__workflow_mSExcelClearExcelClipboardworkflow, nameof(mSExcelClearExcelClipboardworkflow), required: true);
            var __workflow_mSExcelClearExcelClipboardhandle = mSExcelClearExcelClipboardhandle == null ? null : WorkflowExpression.Compile(mSExcelClearExcelClipboardhandle);
            WorkflowExpression.Validate(__workflow_mSExcelClearExcelClipboardhandle, nameof(mSExcelClearExcelClipboardhandle), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/MSExcel/ClearExcelClipboard";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSExcelClearExcelClipboard = new JObject();
                var mSExcelClearExcelClipboardpropCount = 0;
                if (__workflow_mSExcelClearExcelClipboardhandle != null)
                {
                    if (__workflow_mSExcelClearExcelClipboardhandle != null)
                    {
                        mSExcelClearExcelClipboard["Handle"] = ExpressionConverter.ConvertO(__workflow_mSExcelClearExcelClipboardhandle);
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
                mSExcelClearExcelClipboard["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSExcelClearExcelClipboardworkflow);
                if (mSExcelClearExcelClipboardpropCount > 0)
                {
                    callPayload.Body = mSExcelClearExcelClipboard;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelRunMacroResponse> MSExcelRunMacro(Expression<Func<string>> mSExcelRunMacromacroName, Expression<Func<string>> mSExcelRunMacroworkflow, Expression<Func<int>> mSExcelRunMacrohandle = null, Expression<Func<int>> mSExcelRunMacronumberOfArguments = null, Expression<Func<string>> mSExcelRunMacroargument1 = null, Expression<Func<string>> mSExcelRunMacroargument2 = null, Expression<Func<string>> mSExcelRunMacroargument3 = null, Expression<Func<string>> mSExcelRunMacroargument4 = null, Expression<Func<string>> mSExcelRunMacroargument5 = null, Expression<Func<string>> mSExcelRunMacroargument6 = null, Expression<Func<string>> mSExcelRunMacroargument7 = null, Expression<Func<string>> mSExcelRunMacroargument8 = null, Expression<Func<string>> mSExcelRunMacroargument9 = null, Expression<Func<string>> mSExcelRunMacroargument10 = null, Expression<Func<bool>> mSExcelRunMacrorunInBackground = null)
        {
            var __workflow_mSExcelRunMacromacroName = mSExcelRunMacromacroName == null ? null : WorkflowExpression.Compile(mSExcelRunMacromacroName);
            WorkflowExpression.Validate(__workflow_mSExcelRunMacromacroName, nameof(mSExcelRunMacromacroName), required: true);
            var __workflow_mSExcelRunMacroworkflow = mSExcelRunMacroworkflow == null ? null : WorkflowExpression.Compile(mSExcelRunMacroworkflow);
            WorkflowExpression.Validate(__workflow_mSExcelRunMacroworkflow, nameof(mSExcelRunMacroworkflow), required: true);
            var __workflow_mSExcelRunMacrohandle = mSExcelRunMacrohandle == null ? null : WorkflowExpression.Compile(mSExcelRunMacrohandle);
            WorkflowExpression.Validate(__workflow_mSExcelRunMacrohandle, nameof(mSExcelRunMacrohandle), required: false);
            var __workflow_mSExcelRunMacronumberOfArguments = mSExcelRunMacronumberOfArguments == null ? null : WorkflowExpression.Compile(mSExcelRunMacronumberOfArguments);
            WorkflowExpression.Validate(__workflow_mSExcelRunMacronumberOfArguments, nameof(mSExcelRunMacronumberOfArguments), required: false);
            var __workflow_mSExcelRunMacroargument1 = mSExcelRunMacroargument1 == null ? null : WorkflowExpression.Compile(mSExcelRunMacroargument1);
            WorkflowExpression.Validate(__workflow_mSExcelRunMacroargument1, nameof(mSExcelRunMacroargument1), required: false);
            var __workflow_mSExcelRunMacroargument2 = mSExcelRunMacroargument2 == null ? null : WorkflowExpression.Compile(mSExcelRunMacroargument2);
            WorkflowExpression.Validate(__workflow_mSExcelRunMacroargument2, nameof(mSExcelRunMacroargument2), required: false);
            var __workflow_mSExcelRunMacroargument3 = mSExcelRunMacroargument3 == null ? null : WorkflowExpression.Compile(mSExcelRunMacroargument3);
            WorkflowExpression.Validate(__workflow_mSExcelRunMacroargument3, nameof(mSExcelRunMacroargument3), required: false);
            var __workflow_mSExcelRunMacroargument4 = mSExcelRunMacroargument4 == null ? null : WorkflowExpression.Compile(mSExcelRunMacroargument4);
            WorkflowExpression.Validate(__workflow_mSExcelRunMacroargument4, nameof(mSExcelRunMacroargument4), required: false);
            var __workflow_mSExcelRunMacroargument5 = mSExcelRunMacroargument5 == null ? null : WorkflowExpression.Compile(mSExcelRunMacroargument5);
            WorkflowExpression.Validate(__workflow_mSExcelRunMacroargument5, nameof(mSExcelRunMacroargument5), required: false);
            var __workflow_mSExcelRunMacroargument6 = mSExcelRunMacroargument6 == null ? null : WorkflowExpression.Compile(mSExcelRunMacroargument6);
            WorkflowExpression.Validate(__workflow_mSExcelRunMacroargument6, nameof(mSExcelRunMacroargument6), required: false);
            var __workflow_mSExcelRunMacroargument7 = mSExcelRunMacroargument7 == null ? null : WorkflowExpression.Compile(mSExcelRunMacroargument7);
            WorkflowExpression.Validate(__workflow_mSExcelRunMacroargument7, nameof(mSExcelRunMacroargument7), required: false);
            var __workflow_mSExcelRunMacroargument8 = mSExcelRunMacroargument8 == null ? null : WorkflowExpression.Compile(mSExcelRunMacroargument8);
            WorkflowExpression.Validate(__workflow_mSExcelRunMacroargument8, nameof(mSExcelRunMacroargument8), required: false);
            var __workflow_mSExcelRunMacroargument9 = mSExcelRunMacroargument9 == null ? null : WorkflowExpression.Compile(mSExcelRunMacroargument9);
            WorkflowExpression.Validate(__workflow_mSExcelRunMacroargument9, nameof(mSExcelRunMacroargument9), required: false);
            var __workflow_mSExcelRunMacroargument10 = mSExcelRunMacroargument10 == null ? null : WorkflowExpression.Compile(mSExcelRunMacroargument10);
            WorkflowExpression.Validate(__workflow_mSExcelRunMacroargument10, nameof(mSExcelRunMacroargument10), required: false);
            var __workflow_mSExcelRunMacrorunInBackground = mSExcelRunMacrorunInBackground == null ? null : WorkflowExpression.Compile(mSExcelRunMacrorunInBackground);
            WorkflowExpression.Validate(__workflow_mSExcelRunMacrorunInBackground, nameof(mSExcelRunMacrorunInBackground), required: false);
            return new DeferredBodyAction<MSExcelRunMacroResponse>(() =>
            {
                var apiCallPath = "/MSExcel/RunMacro";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSExcelRunMacro = new JObject();
                var mSExcelRunMacropropCount = 0;
                if (__workflow_mSExcelRunMacrohandle != null)
                {
                    if (__workflow_mSExcelRunMacrohandle != null)
                    {
                        mSExcelRunMacro["Handle"] = ExpressionConverter.ConvertO(__workflow_mSExcelRunMacrohandle);
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
                mSExcelRunMacro["MacroName"] = ExpressionConverter.ConvertO(__workflow_mSExcelRunMacromacroName);
                if (__workflow_mSExcelRunMacronumberOfArguments != null)
                {
                    mSExcelRunMacro["NumberOfArguments"] = ExpressionConverter.ConvertO(__workflow_mSExcelRunMacronumberOfArguments);
                    mSExcelRunMacropropCount++;
                }

                if (__workflow_mSExcelRunMacroargument1 != null)
                {
                    mSExcelRunMacro["Argument1"] = ExpressionConverter.ConvertO(__workflow_mSExcelRunMacroargument1);
                    mSExcelRunMacropropCount++;
                }

                if (__workflow_mSExcelRunMacroargument2 != null)
                {
                    mSExcelRunMacro["Argument2"] = ExpressionConverter.ConvertO(__workflow_mSExcelRunMacroargument2);
                    mSExcelRunMacropropCount++;
                }

                if (__workflow_mSExcelRunMacroargument3 != null)
                {
                    mSExcelRunMacro["Argument3"] = ExpressionConverter.ConvertO(__workflow_mSExcelRunMacroargument3);
                    mSExcelRunMacropropCount++;
                }

                if (__workflow_mSExcelRunMacroargument4 != null)
                {
                    mSExcelRunMacro["Argument4"] = ExpressionConverter.ConvertO(__workflow_mSExcelRunMacroargument4);
                    mSExcelRunMacropropCount++;
                }

                if (__workflow_mSExcelRunMacroargument5 != null)
                {
                    mSExcelRunMacro["Argument5"] = ExpressionConverter.ConvertO(__workflow_mSExcelRunMacroargument5);
                    mSExcelRunMacropropCount++;
                }

                if (__workflow_mSExcelRunMacroargument6 != null)
                {
                    mSExcelRunMacro["Argument6"] = ExpressionConverter.ConvertO(__workflow_mSExcelRunMacroargument6);
                    mSExcelRunMacropropCount++;
                }

                if (__workflow_mSExcelRunMacroargument7 != null)
                {
                    mSExcelRunMacro["Argument7"] = ExpressionConverter.ConvertO(__workflow_mSExcelRunMacroargument7);
                    mSExcelRunMacropropCount++;
                }

                if (__workflow_mSExcelRunMacroargument8 != null)
                {
                    mSExcelRunMacro["Argument8"] = ExpressionConverter.ConvertO(__workflow_mSExcelRunMacroargument8);
                    mSExcelRunMacropropCount++;
                }

                if (__workflow_mSExcelRunMacroargument9 != null)
                {
                    mSExcelRunMacro["Argument9"] = ExpressionConverter.ConvertO(__workflow_mSExcelRunMacroargument9);
                    mSExcelRunMacropropCount++;
                }

                if (__workflow_mSExcelRunMacroargument10 != null)
                {
                    mSExcelRunMacro["Argument10"] = ExpressionConverter.ConvertO(__workflow_mSExcelRunMacroargument10);
                    mSExcelRunMacropropCount++;
                }

                if (__workflow_mSExcelRunMacrorunInBackground != null)
                {
                    if (__workflow_mSExcelRunMacrorunInBackground != null)
                    {
                        mSExcelRunMacro["RunInBackground"] = ExpressionConverter.ConvertO(__workflow_mSExcelRunMacrorunInBackground);
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
                mSExcelRunMacro["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSExcelRunMacroworkflow);
                if (mSExcelRunMacropropCount > 0)
                {
                    callPayload.Body = mSExcelRunMacro;
                }

                return new ApiConnectionAction<MSExcelRunMacroResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelAddMacroToWorkbook(Expression<Func<string>> mSExcelAddMacroToWorkbookmacroCode, Expression<Func<string>> mSExcelAddMacroToWorkbookworkflow, Expression<Func<int>> mSExcelAddMacroToWorkbookhandle = null, Expression<Func<string>> mSExcelAddMacroToWorkbookworkbookName = null)
        {
            var __workflow_mSExcelAddMacroToWorkbookmacroCode = mSExcelAddMacroToWorkbookmacroCode == null ? null : WorkflowExpression.Compile(mSExcelAddMacroToWorkbookmacroCode);
            WorkflowExpression.Validate(__workflow_mSExcelAddMacroToWorkbookmacroCode, nameof(mSExcelAddMacroToWorkbookmacroCode), required: true);
            var __workflow_mSExcelAddMacroToWorkbookworkflow = mSExcelAddMacroToWorkbookworkflow == null ? null : WorkflowExpression.Compile(mSExcelAddMacroToWorkbookworkflow);
            WorkflowExpression.Validate(__workflow_mSExcelAddMacroToWorkbookworkflow, nameof(mSExcelAddMacroToWorkbookworkflow), required: true);
            var __workflow_mSExcelAddMacroToWorkbookhandle = mSExcelAddMacroToWorkbookhandle == null ? null : WorkflowExpression.Compile(mSExcelAddMacroToWorkbookhandle);
            WorkflowExpression.Validate(__workflow_mSExcelAddMacroToWorkbookhandle, nameof(mSExcelAddMacroToWorkbookhandle), required: false);
            var __workflow_mSExcelAddMacroToWorkbookworkbookName = mSExcelAddMacroToWorkbookworkbookName == null ? null : WorkflowExpression.Compile(mSExcelAddMacroToWorkbookworkbookName);
            WorkflowExpression.Validate(__workflow_mSExcelAddMacroToWorkbookworkbookName, nameof(mSExcelAddMacroToWorkbookworkbookName), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/MSExcel/AddMacroToWorkbook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSExcelAddMacroToWorkbook = new JObject();
                var mSExcelAddMacroToWorkbookpropCount = 0;
                if (__workflow_mSExcelAddMacroToWorkbookhandle != null)
                {
                    if (__workflow_mSExcelAddMacroToWorkbookhandle != null)
                    {
                        mSExcelAddMacroToWorkbook["Handle"] = ExpressionConverter.ConvertO(__workflow_mSExcelAddMacroToWorkbookhandle);
                        mSExcelAddMacroToWorkbookpropCount++;
                    }

                    mSExcelAddMacroToWorkbookpropCount++;
                }
                else
                {
                    mSExcelAddMacroToWorkbook["Handle"] = 0;
                    mSExcelAddMacroToWorkbookpropCount++;
                }

                if (__workflow_mSExcelAddMacroToWorkbookworkbookName != null)
                {
                    mSExcelAddMacroToWorkbook["WorkbookName"] = ExpressionConverter.ConvertO(__workflow_mSExcelAddMacroToWorkbookworkbookName);
                    mSExcelAddMacroToWorkbookpropCount++;
                }

                mSExcelAddMacroToWorkbookpropCount++;
                mSExcelAddMacroToWorkbook["MacroCode"] = ExpressionConverter.ConvertO(__workflow_mSExcelAddMacroToWorkbookmacroCode);
                mSExcelAddMacroToWorkbookpropCount++;
                mSExcelAddMacroToWorkbook["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSExcelAddMacroToWorkbookworkflow);
                if (mSExcelAddMacroToWorkbookpropCount > 0)
                {
                    callPayload.Body = mSExcelAddMacroToWorkbook;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelTrustVBOMInRegistry(Expression<Func<string>> mSExcelTrustVBOMInRegistryworkflow, Expression<Func<int>> mSExcelTrustVBOMInRegistryexcelVersion = null, Expression<Func<bool>> mSExcelTrustVBOMInRegistrytrustVBOM = null)
        {
            var __workflow_mSExcelTrustVBOMInRegistryworkflow = mSExcelTrustVBOMInRegistryworkflow == null ? null : WorkflowExpression.Compile(mSExcelTrustVBOMInRegistryworkflow);
            WorkflowExpression.Validate(__workflow_mSExcelTrustVBOMInRegistryworkflow, nameof(mSExcelTrustVBOMInRegistryworkflow), required: true);
            var __workflow_mSExcelTrustVBOMInRegistryexcelVersion = mSExcelTrustVBOMInRegistryexcelVersion == null ? null : WorkflowExpression.Compile(mSExcelTrustVBOMInRegistryexcelVersion);
            WorkflowExpression.Validate(__workflow_mSExcelTrustVBOMInRegistryexcelVersion, nameof(mSExcelTrustVBOMInRegistryexcelVersion), required: false);
            var __workflow_mSExcelTrustVBOMInRegistrytrustVBOM = mSExcelTrustVBOMInRegistrytrustVBOM == null ? null : WorkflowExpression.Compile(mSExcelTrustVBOMInRegistrytrustVBOM);
            WorkflowExpression.Validate(__workflow_mSExcelTrustVBOMInRegistrytrustVBOM, nameof(mSExcelTrustVBOMInRegistrytrustVBOM), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/MSExcel/TrustVBOMInRegistry";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSExcelTrustVBOMInRegistry = new JObject();
                var mSExcelTrustVBOMInRegistrypropCount = 0;
                if (__workflow_mSExcelTrustVBOMInRegistryexcelVersion != null)
                {
                    mSExcelTrustVBOMInRegistry["ExcelVersion"] = ExpressionConverter.ConvertO(__workflow_mSExcelTrustVBOMInRegistryexcelVersion);
                    mSExcelTrustVBOMInRegistrypropCount++;
                }

                if (__workflow_mSExcelTrustVBOMInRegistrytrustVBOM != null)
                {
                    if (__workflow_mSExcelTrustVBOMInRegistrytrustVBOM != null)
                    {
                        mSExcelTrustVBOMInRegistry["TrustVBOM"] = ExpressionConverter.ConvertO(__workflow_mSExcelTrustVBOMInRegistrytrustVBOM);
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
                mSExcelTrustVBOMInRegistry["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSExcelTrustVBOMInRegistryworkflow);
                if (mSExcelTrustVBOMInRegistrypropCount > 0)
                {
                    callPayload.Body = mSExcelTrustVBOMInRegistry;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelSetCalculationMode(Expression<Func<int>> mSExcelSetCalculationModecalculationMode, Expression<Func<string>> mSExcelSetCalculationModeworkflow, Expression<Func<int>> mSExcelSetCalculationModehandle = null)
        {
            var __workflow_mSExcelSetCalculationModecalculationMode = mSExcelSetCalculationModecalculationMode == null ? null : WorkflowExpression.Compile(mSExcelSetCalculationModecalculationMode);
            WorkflowExpression.Validate(__workflow_mSExcelSetCalculationModecalculationMode, nameof(mSExcelSetCalculationModecalculationMode), required: true);
            var __workflow_mSExcelSetCalculationModeworkflow = mSExcelSetCalculationModeworkflow == null ? null : WorkflowExpression.Compile(mSExcelSetCalculationModeworkflow);
            WorkflowExpression.Validate(__workflow_mSExcelSetCalculationModeworkflow, nameof(mSExcelSetCalculationModeworkflow), required: true);
            var __workflow_mSExcelSetCalculationModehandle = mSExcelSetCalculationModehandle == null ? null : WorkflowExpression.Compile(mSExcelSetCalculationModehandle);
            WorkflowExpression.Validate(__workflow_mSExcelSetCalculationModehandle, nameof(mSExcelSetCalculationModehandle), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/MSExcel/SetCalculationMode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSExcelSetCalculationMode = new JObject();
                var mSExcelSetCalculationModepropCount = 0;
                if (__workflow_mSExcelSetCalculationModehandle != null)
                {
                    if (__workflow_mSExcelSetCalculationModehandle != null)
                    {
                        mSExcelSetCalculationMode["Handle"] = ExpressionConverter.ConvertO(__workflow_mSExcelSetCalculationModehandle);
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
                mSExcelSetCalculationMode["CalculationMode"] = ExpressionConverter.ConvertO(__workflow_mSExcelSetCalculationModecalculationMode);
                mSExcelSetCalculationModepropCount++;
                mSExcelSetCalculationMode["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSExcelSetCalculationModeworkflow);
                if (mSExcelSetCalculationModepropCount > 0)
                {
                    callPayload.Body = mSExcelSetCalculationMode;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelExecuteCommandBarObject(Expression<Func<string>> mSExcelExecuteCommandBarObjectobjectId, Expression<Func<string>> mSExcelExecuteCommandBarObjectworkflow, Expression<Func<int>> mSExcelExecuteCommandBarObjecthandle = null, Expression<Func<bool>> mSExcelExecuteCommandBarObjectrunInBackground = null)
        {
            var __workflow_mSExcelExecuteCommandBarObjectobjectId = mSExcelExecuteCommandBarObjectobjectId == null ? null : WorkflowExpression.Compile(mSExcelExecuteCommandBarObjectobjectId);
            WorkflowExpression.Validate(__workflow_mSExcelExecuteCommandBarObjectobjectId, nameof(mSExcelExecuteCommandBarObjectobjectId), required: true);
            var __workflow_mSExcelExecuteCommandBarObjectworkflow = mSExcelExecuteCommandBarObjectworkflow == null ? null : WorkflowExpression.Compile(mSExcelExecuteCommandBarObjectworkflow);
            WorkflowExpression.Validate(__workflow_mSExcelExecuteCommandBarObjectworkflow, nameof(mSExcelExecuteCommandBarObjectworkflow), required: true);
            var __workflow_mSExcelExecuteCommandBarObjecthandle = mSExcelExecuteCommandBarObjecthandle == null ? null : WorkflowExpression.Compile(mSExcelExecuteCommandBarObjecthandle);
            WorkflowExpression.Validate(__workflow_mSExcelExecuteCommandBarObjecthandle, nameof(mSExcelExecuteCommandBarObjecthandle), required: false);
            var __workflow_mSExcelExecuteCommandBarObjectrunInBackground = mSExcelExecuteCommandBarObjectrunInBackground == null ? null : WorkflowExpression.Compile(mSExcelExecuteCommandBarObjectrunInBackground);
            WorkflowExpression.Validate(__workflow_mSExcelExecuteCommandBarObjectrunInBackground, nameof(mSExcelExecuteCommandBarObjectrunInBackground), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/MSExcel/ExecuteCommandBarObject";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSExcelExecuteCommandBarObject = new JObject();
                var mSExcelExecuteCommandBarObjectpropCount = 0;
                if (__workflow_mSExcelExecuteCommandBarObjecthandle != null)
                {
                    if (__workflow_mSExcelExecuteCommandBarObjecthandle != null)
                    {
                        mSExcelExecuteCommandBarObject["Handle"] = ExpressionConverter.ConvertO(__workflow_mSExcelExecuteCommandBarObjecthandle);
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
                mSExcelExecuteCommandBarObject["ObjectId"] = ExpressionConverter.ConvertO(__workflow_mSExcelExecuteCommandBarObjectobjectId);
                if (__workflow_mSExcelExecuteCommandBarObjectrunInBackground != null)
                {
                    if (__workflow_mSExcelExecuteCommandBarObjectrunInBackground != null)
                    {
                        mSExcelExecuteCommandBarObject["RunInBackground"] = ExpressionConverter.ConvertO(__workflow_mSExcelExecuteCommandBarObjectrunInBackground);
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
                mSExcelExecuteCommandBarObject["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSExcelExecuteCommandBarObjectworkflow);
                if (mSExcelExecuteCommandBarObjectpropCount > 0)
                {
                    callPayload.Body = mSExcelExecuteCommandBarObject;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelCopyBetweenCellsResponse> MSExcelCopyBetweenCells(Expression<Func<string>> mSExcelCopyBetweenCellssourceCellReference, Expression<Func<string>> mSExcelCopyBetweenCellstargetCellReference, Expression<Func<string>> mSExcelCopyBetweenCellsworkflow, Expression<Func<int>> mSExcelCopyBetweenCellssourceHandle = null, Expression<Func<string>> mSExcelCopyBetweenCellssourceWorkbookName = null, Expression<Func<string>> mSExcelCopyBetweenCellssourceWorksheetName = null, Expression<Func<bool>> mSExcelCopyBetweenCellssourceEntireRow = null, Expression<Func<bool>> mSExcelCopyBetweenCellssourceEntireColumn = null, Expression<Func<int>> mSExcelCopyBetweenCellstargetHandle = null, Expression<Func<string>> mSExcelCopyBetweenCellstargetWorkbookName = null, Expression<Func<string>> mSExcelCopyBetweenCellstargetWorksheetName = null, Expression<Func<bool>> mSExcelCopyBetweenCellstargetEntireRow = null, Expression<Func<bool>> mSExcelCopyBetweenCellstargetEntireColumn = null, Expression<Func<bool>> mSExcelCopyBetweenCellsvaluesOnly = null, Expression<Func<bool>> mSExcelCopyBetweenCellssimplePasteOnly = null)
        {
            var __workflow_mSExcelCopyBetweenCellssourceCellReference = mSExcelCopyBetweenCellssourceCellReference == null ? null : WorkflowExpression.Compile(mSExcelCopyBetweenCellssourceCellReference);
            WorkflowExpression.Validate(__workflow_mSExcelCopyBetweenCellssourceCellReference, nameof(mSExcelCopyBetweenCellssourceCellReference), required: true);
            var __workflow_mSExcelCopyBetweenCellstargetCellReference = mSExcelCopyBetweenCellstargetCellReference == null ? null : WorkflowExpression.Compile(mSExcelCopyBetweenCellstargetCellReference);
            WorkflowExpression.Validate(__workflow_mSExcelCopyBetweenCellstargetCellReference, nameof(mSExcelCopyBetweenCellstargetCellReference), required: true);
            var __workflow_mSExcelCopyBetweenCellsworkflow = mSExcelCopyBetweenCellsworkflow == null ? null : WorkflowExpression.Compile(mSExcelCopyBetweenCellsworkflow);
            WorkflowExpression.Validate(__workflow_mSExcelCopyBetweenCellsworkflow, nameof(mSExcelCopyBetweenCellsworkflow), required: true);
            var __workflow_mSExcelCopyBetweenCellssourceHandle = mSExcelCopyBetweenCellssourceHandle == null ? null : WorkflowExpression.Compile(mSExcelCopyBetweenCellssourceHandle);
            WorkflowExpression.Validate(__workflow_mSExcelCopyBetweenCellssourceHandle, nameof(mSExcelCopyBetweenCellssourceHandle), required: false);
            var __workflow_mSExcelCopyBetweenCellssourceWorkbookName = mSExcelCopyBetweenCellssourceWorkbookName == null ? null : WorkflowExpression.Compile(mSExcelCopyBetweenCellssourceWorkbookName);
            WorkflowExpression.Validate(__workflow_mSExcelCopyBetweenCellssourceWorkbookName, nameof(mSExcelCopyBetweenCellssourceWorkbookName), required: false);
            var __workflow_mSExcelCopyBetweenCellssourceWorksheetName = mSExcelCopyBetweenCellssourceWorksheetName == null ? null : WorkflowExpression.Compile(mSExcelCopyBetweenCellssourceWorksheetName);
            WorkflowExpression.Validate(__workflow_mSExcelCopyBetweenCellssourceWorksheetName, nameof(mSExcelCopyBetweenCellssourceWorksheetName), required: false);
            var __workflow_mSExcelCopyBetweenCellssourceEntireRow = mSExcelCopyBetweenCellssourceEntireRow == null ? null : WorkflowExpression.Compile(mSExcelCopyBetweenCellssourceEntireRow);
            WorkflowExpression.Validate(__workflow_mSExcelCopyBetweenCellssourceEntireRow, nameof(mSExcelCopyBetweenCellssourceEntireRow), required: false);
            var __workflow_mSExcelCopyBetweenCellssourceEntireColumn = mSExcelCopyBetweenCellssourceEntireColumn == null ? null : WorkflowExpression.Compile(mSExcelCopyBetweenCellssourceEntireColumn);
            WorkflowExpression.Validate(__workflow_mSExcelCopyBetweenCellssourceEntireColumn, nameof(mSExcelCopyBetweenCellssourceEntireColumn), required: false);
            var __workflow_mSExcelCopyBetweenCellstargetHandle = mSExcelCopyBetweenCellstargetHandle == null ? null : WorkflowExpression.Compile(mSExcelCopyBetweenCellstargetHandle);
            WorkflowExpression.Validate(__workflow_mSExcelCopyBetweenCellstargetHandle, nameof(mSExcelCopyBetweenCellstargetHandle), required: false);
            var __workflow_mSExcelCopyBetweenCellstargetWorkbookName = mSExcelCopyBetweenCellstargetWorkbookName == null ? null : WorkflowExpression.Compile(mSExcelCopyBetweenCellstargetWorkbookName);
            WorkflowExpression.Validate(__workflow_mSExcelCopyBetweenCellstargetWorkbookName, nameof(mSExcelCopyBetweenCellstargetWorkbookName), required: false);
            var __workflow_mSExcelCopyBetweenCellstargetWorksheetName = mSExcelCopyBetweenCellstargetWorksheetName == null ? null : WorkflowExpression.Compile(mSExcelCopyBetweenCellstargetWorksheetName);
            WorkflowExpression.Validate(__workflow_mSExcelCopyBetweenCellstargetWorksheetName, nameof(mSExcelCopyBetweenCellstargetWorksheetName), required: false);
            var __workflow_mSExcelCopyBetweenCellstargetEntireRow = mSExcelCopyBetweenCellstargetEntireRow == null ? null : WorkflowExpression.Compile(mSExcelCopyBetweenCellstargetEntireRow);
            WorkflowExpression.Validate(__workflow_mSExcelCopyBetweenCellstargetEntireRow, nameof(mSExcelCopyBetweenCellstargetEntireRow), required: false);
            var __workflow_mSExcelCopyBetweenCellstargetEntireColumn = mSExcelCopyBetweenCellstargetEntireColumn == null ? null : WorkflowExpression.Compile(mSExcelCopyBetweenCellstargetEntireColumn);
            WorkflowExpression.Validate(__workflow_mSExcelCopyBetweenCellstargetEntireColumn, nameof(mSExcelCopyBetweenCellstargetEntireColumn), required: false);
            var __workflow_mSExcelCopyBetweenCellsvaluesOnly = mSExcelCopyBetweenCellsvaluesOnly == null ? null : WorkflowExpression.Compile(mSExcelCopyBetweenCellsvaluesOnly);
            WorkflowExpression.Validate(__workflow_mSExcelCopyBetweenCellsvaluesOnly, nameof(mSExcelCopyBetweenCellsvaluesOnly), required: false);
            var __workflow_mSExcelCopyBetweenCellssimplePasteOnly = mSExcelCopyBetweenCellssimplePasteOnly == null ? null : WorkflowExpression.Compile(mSExcelCopyBetweenCellssimplePasteOnly);
            WorkflowExpression.Validate(__workflow_mSExcelCopyBetweenCellssimplePasteOnly, nameof(mSExcelCopyBetweenCellssimplePasteOnly), required: false);
            return new DeferredBodyAction<MSExcelCopyBetweenCellsResponse>(() =>
            {
                var apiCallPath = "/MSExcel/CopyBetweenCells";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSExcelCopyBetweenCells = new JObject();
                var mSExcelCopyBetweenCellspropCount = 0;
                if (__workflow_mSExcelCopyBetweenCellssourceHandle != null)
                {
                    if (__workflow_mSExcelCopyBetweenCellssourceHandle != null)
                    {
                        mSExcelCopyBetweenCells["SourceHandle"] = ExpressionConverter.ConvertO(__workflow_mSExcelCopyBetweenCellssourceHandle);
                        mSExcelCopyBetweenCellspropCount++;
                    }

                    mSExcelCopyBetweenCellspropCount++;
                }
                else
                {
                    mSExcelCopyBetweenCells["SourceHandle"] = 0;
                    mSExcelCopyBetweenCellspropCount++;
                }

                if (__workflow_mSExcelCopyBetweenCellssourceWorkbookName != null)
                {
                    mSExcelCopyBetweenCells["SourceWorkbookName"] = ExpressionConverter.ConvertO(__workflow_mSExcelCopyBetweenCellssourceWorkbookName);
                    mSExcelCopyBetweenCellspropCount++;
                }

                if (__workflow_mSExcelCopyBetweenCellssourceWorksheetName != null)
                {
                    mSExcelCopyBetweenCells["SourceWorksheetName"] = ExpressionConverter.ConvertO(__workflow_mSExcelCopyBetweenCellssourceWorksheetName);
                    mSExcelCopyBetweenCellspropCount++;
                }

                mSExcelCopyBetweenCellspropCount++;
                mSExcelCopyBetweenCells["SourceCellReference"] = ExpressionConverter.ConvertO(__workflow_mSExcelCopyBetweenCellssourceCellReference);
                if (__workflow_mSExcelCopyBetweenCellssourceEntireRow != null)
                {
                    if (__workflow_mSExcelCopyBetweenCellssourceEntireRow != null)
                    {
                        mSExcelCopyBetweenCells["SourceEntireRow"] = ExpressionConverter.ConvertO(__workflow_mSExcelCopyBetweenCellssourceEntireRow);
                        mSExcelCopyBetweenCellspropCount++;
                    }

                    mSExcelCopyBetweenCellspropCount++;
                }
                else
                {
                    mSExcelCopyBetweenCells["SourceEntireRow"] = false;
                    mSExcelCopyBetweenCellspropCount++;
                }

                if (__workflow_mSExcelCopyBetweenCellssourceEntireColumn != null)
                {
                    if (__workflow_mSExcelCopyBetweenCellssourceEntireColumn != null)
                    {
                        mSExcelCopyBetweenCells["SourceEntireColumn"] = ExpressionConverter.ConvertO(__workflow_mSExcelCopyBetweenCellssourceEntireColumn);
                        mSExcelCopyBetweenCellspropCount++;
                    }

                    mSExcelCopyBetweenCellspropCount++;
                }
                else
                {
                    mSExcelCopyBetweenCells["SourceEntireColumn"] = false;
                    mSExcelCopyBetweenCellspropCount++;
                }

                if (__workflow_mSExcelCopyBetweenCellstargetHandle != null)
                {
                    if (__workflow_mSExcelCopyBetweenCellstargetHandle != null)
                    {
                        mSExcelCopyBetweenCells["TargetHandle"] = ExpressionConverter.ConvertO(__workflow_mSExcelCopyBetweenCellstargetHandle);
                        mSExcelCopyBetweenCellspropCount++;
                    }

                    mSExcelCopyBetweenCellspropCount++;
                }
                else
                {
                    mSExcelCopyBetweenCells["TargetHandle"] = 0;
                    mSExcelCopyBetweenCellspropCount++;
                }

                if (__workflow_mSExcelCopyBetweenCellstargetWorkbookName != null)
                {
                    mSExcelCopyBetweenCells["TargetWorkbookName"] = ExpressionConverter.ConvertO(__workflow_mSExcelCopyBetweenCellstargetWorkbookName);
                    mSExcelCopyBetweenCellspropCount++;
                }

                if (__workflow_mSExcelCopyBetweenCellstargetWorksheetName != null)
                {
                    mSExcelCopyBetweenCells["TargetWorksheetName"] = ExpressionConverter.ConvertO(__workflow_mSExcelCopyBetweenCellstargetWorksheetName);
                    mSExcelCopyBetweenCellspropCount++;
                }

                mSExcelCopyBetweenCellspropCount++;
                mSExcelCopyBetweenCells["TargetCellReference"] = ExpressionConverter.ConvertO(__workflow_mSExcelCopyBetweenCellstargetCellReference);
                if (__workflow_mSExcelCopyBetweenCellstargetEntireRow != null)
                {
                    if (__workflow_mSExcelCopyBetweenCellstargetEntireRow != null)
                    {
                        mSExcelCopyBetweenCells["TargetEntireRow"] = ExpressionConverter.ConvertO(__workflow_mSExcelCopyBetweenCellstargetEntireRow);
                        mSExcelCopyBetweenCellspropCount++;
                    }

                    mSExcelCopyBetweenCellspropCount++;
                }
                else
                {
                    mSExcelCopyBetweenCells["TargetEntireRow"] = false;
                    mSExcelCopyBetweenCellspropCount++;
                }

                if (__workflow_mSExcelCopyBetweenCellstargetEntireColumn != null)
                {
                    if (__workflow_mSExcelCopyBetweenCellstargetEntireColumn != null)
                    {
                        mSExcelCopyBetweenCells["TargetEntireColumn"] = ExpressionConverter.ConvertO(__workflow_mSExcelCopyBetweenCellstargetEntireColumn);
                        mSExcelCopyBetweenCellspropCount++;
                    }

                    mSExcelCopyBetweenCellspropCount++;
                }
                else
                {
                    mSExcelCopyBetweenCells["TargetEntireColumn"] = false;
                    mSExcelCopyBetweenCellspropCount++;
                }

                if (__workflow_mSExcelCopyBetweenCellsvaluesOnly != null)
                {
                    if (__workflow_mSExcelCopyBetweenCellsvaluesOnly != null)
                    {
                        mSExcelCopyBetweenCells["ValuesOnly"] = ExpressionConverter.ConvertO(__workflow_mSExcelCopyBetweenCellsvaluesOnly);
                        mSExcelCopyBetweenCellspropCount++;
                    }

                    mSExcelCopyBetweenCellspropCount++;
                }
                else
                {
                    mSExcelCopyBetweenCells["ValuesOnly"] = false;
                    mSExcelCopyBetweenCellspropCount++;
                }

                if (__workflow_mSExcelCopyBetweenCellssimplePasteOnly != null)
                {
                    if (__workflow_mSExcelCopyBetweenCellssimplePasteOnly != null)
                    {
                        mSExcelCopyBetweenCells["SimplePasteOnly"] = ExpressionConverter.ConvertO(__workflow_mSExcelCopyBetweenCellssimplePasteOnly);
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
                mSExcelCopyBetweenCells["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSExcelCopyBetweenCellsworkflow);
                if (mSExcelCopyBetweenCellspropCount > 0)
                {
                    callPayload.Body = mSExcelCopyBetweenCells;
                }

                return new ApiConnectionAction<MSExcelCopyBetweenCellsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelCutBetweenCellsResponse> MSExcelCutBetweenCells(Expression<Func<string>> mSExcelCutBetweenCellssourceCellReference, Expression<Func<string>> mSExcelCutBetweenCellstargetCellReference, Expression<Func<string>> mSExcelCutBetweenCellsworkflow, Expression<Func<int>> mSExcelCutBetweenCellssourceHandle = null, Expression<Func<string>> mSExcelCutBetweenCellssourceWorkbookName = null, Expression<Func<string>> mSExcelCutBetweenCellssourceWorksheetName = null, Expression<Func<bool>> mSExcelCutBetweenCellssourceEntireRow = null, Expression<Func<bool>> mSExcelCutBetweenCellssourceEntireColumn = null, Expression<Func<int>> mSExcelCutBetweenCellstargetHandle = null, Expression<Func<string>> mSExcelCutBetweenCellstargetWorkbookName = null, Expression<Func<string>> mSExcelCutBetweenCellstargetWorksheetName = null, Expression<Func<bool>> mSExcelCutBetweenCellstargetEntireRow = null, Expression<Func<bool>> mSExcelCutBetweenCellstargetEntireColumn = null, Expression<Func<bool>> mSExcelCutBetweenCellsvaluesOnly = null)
        {
            var __workflow_mSExcelCutBetweenCellssourceCellReference = mSExcelCutBetweenCellssourceCellReference == null ? null : WorkflowExpression.Compile(mSExcelCutBetweenCellssourceCellReference);
            WorkflowExpression.Validate(__workflow_mSExcelCutBetweenCellssourceCellReference, nameof(mSExcelCutBetweenCellssourceCellReference), required: true);
            var __workflow_mSExcelCutBetweenCellstargetCellReference = mSExcelCutBetweenCellstargetCellReference == null ? null : WorkflowExpression.Compile(mSExcelCutBetweenCellstargetCellReference);
            WorkflowExpression.Validate(__workflow_mSExcelCutBetweenCellstargetCellReference, nameof(mSExcelCutBetweenCellstargetCellReference), required: true);
            var __workflow_mSExcelCutBetweenCellsworkflow = mSExcelCutBetweenCellsworkflow == null ? null : WorkflowExpression.Compile(mSExcelCutBetweenCellsworkflow);
            WorkflowExpression.Validate(__workflow_mSExcelCutBetweenCellsworkflow, nameof(mSExcelCutBetweenCellsworkflow), required: true);
            var __workflow_mSExcelCutBetweenCellssourceHandle = mSExcelCutBetweenCellssourceHandle == null ? null : WorkflowExpression.Compile(mSExcelCutBetweenCellssourceHandle);
            WorkflowExpression.Validate(__workflow_mSExcelCutBetweenCellssourceHandle, nameof(mSExcelCutBetweenCellssourceHandle), required: false);
            var __workflow_mSExcelCutBetweenCellssourceWorkbookName = mSExcelCutBetweenCellssourceWorkbookName == null ? null : WorkflowExpression.Compile(mSExcelCutBetweenCellssourceWorkbookName);
            WorkflowExpression.Validate(__workflow_mSExcelCutBetweenCellssourceWorkbookName, nameof(mSExcelCutBetweenCellssourceWorkbookName), required: false);
            var __workflow_mSExcelCutBetweenCellssourceWorksheetName = mSExcelCutBetweenCellssourceWorksheetName == null ? null : WorkflowExpression.Compile(mSExcelCutBetweenCellssourceWorksheetName);
            WorkflowExpression.Validate(__workflow_mSExcelCutBetweenCellssourceWorksheetName, nameof(mSExcelCutBetweenCellssourceWorksheetName), required: false);
            var __workflow_mSExcelCutBetweenCellssourceEntireRow = mSExcelCutBetweenCellssourceEntireRow == null ? null : WorkflowExpression.Compile(mSExcelCutBetweenCellssourceEntireRow);
            WorkflowExpression.Validate(__workflow_mSExcelCutBetweenCellssourceEntireRow, nameof(mSExcelCutBetweenCellssourceEntireRow), required: false);
            var __workflow_mSExcelCutBetweenCellssourceEntireColumn = mSExcelCutBetweenCellssourceEntireColumn == null ? null : WorkflowExpression.Compile(mSExcelCutBetweenCellssourceEntireColumn);
            WorkflowExpression.Validate(__workflow_mSExcelCutBetweenCellssourceEntireColumn, nameof(mSExcelCutBetweenCellssourceEntireColumn), required: false);
            var __workflow_mSExcelCutBetweenCellstargetHandle = mSExcelCutBetweenCellstargetHandle == null ? null : WorkflowExpression.Compile(mSExcelCutBetweenCellstargetHandle);
            WorkflowExpression.Validate(__workflow_mSExcelCutBetweenCellstargetHandle, nameof(mSExcelCutBetweenCellstargetHandle), required: false);
            var __workflow_mSExcelCutBetweenCellstargetWorkbookName = mSExcelCutBetweenCellstargetWorkbookName == null ? null : WorkflowExpression.Compile(mSExcelCutBetweenCellstargetWorkbookName);
            WorkflowExpression.Validate(__workflow_mSExcelCutBetweenCellstargetWorkbookName, nameof(mSExcelCutBetweenCellstargetWorkbookName), required: false);
            var __workflow_mSExcelCutBetweenCellstargetWorksheetName = mSExcelCutBetweenCellstargetWorksheetName == null ? null : WorkflowExpression.Compile(mSExcelCutBetweenCellstargetWorksheetName);
            WorkflowExpression.Validate(__workflow_mSExcelCutBetweenCellstargetWorksheetName, nameof(mSExcelCutBetweenCellstargetWorksheetName), required: false);
            var __workflow_mSExcelCutBetweenCellstargetEntireRow = mSExcelCutBetweenCellstargetEntireRow == null ? null : WorkflowExpression.Compile(mSExcelCutBetweenCellstargetEntireRow);
            WorkflowExpression.Validate(__workflow_mSExcelCutBetweenCellstargetEntireRow, nameof(mSExcelCutBetweenCellstargetEntireRow), required: false);
            var __workflow_mSExcelCutBetweenCellstargetEntireColumn = mSExcelCutBetweenCellstargetEntireColumn == null ? null : WorkflowExpression.Compile(mSExcelCutBetweenCellstargetEntireColumn);
            WorkflowExpression.Validate(__workflow_mSExcelCutBetweenCellstargetEntireColumn, nameof(mSExcelCutBetweenCellstargetEntireColumn), required: false);
            var __workflow_mSExcelCutBetweenCellsvaluesOnly = mSExcelCutBetweenCellsvaluesOnly == null ? null : WorkflowExpression.Compile(mSExcelCutBetweenCellsvaluesOnly);
            WorkflowExpression.Validate(__workflow_mSExcelCutBetweenCellsvaluesOnly, nameof(mSExcelCutBetweenCellsvaluesOnly), required: false);
            return new DeferredBodyAction<MSExcelCutBetweenCellsResponse>(() =>
            {
                var apiCallPath = "/MSExcel/CutBetweenCells";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSExcelCutBetweenCells = new JObject();
                var mSExcelCutBetweenCellspropCount = 0;
                if (__workflow_mSExcelCutBetweenCellssourceHandle != null)
                {
                    if (__workflow_mSExcelCutBetweenCellssourceHandle != null)
                    {
                        mSExcelCutBetweenCells["SourceHandle"] = ExpressionConverter.ConvertO(__workflow_mSExcelCutBetweenCellssourceHandle);
                        mSExcelCutBetweenCellspropCount++;
                    }

                    mSExcelCutBetweenCellspropCount++;
                }
                else
                {
                    mSExcelCutBetweenCells["SourceHandle"] = 0;
                    mSExcelCutBetweenCellspropCount++;
                }

                if (__workflow_mSExcelCutBetweenCellssourceWorkbookName != null)
                {
                    mSExcelCutBetweenCells["SourceWorkbookName"] = ExpressionConverter.ConvertO(__workflow_mSExcelCutBetweenCellssourceWorkbookName);
                    mSExcelCutBetweenCellspropCount++;
                }

                if (__workflow_mSExcelCutBetweenCellssourceWorksheetName != null)
                {
                    mSExcelCutBetweenCells["SourceWorksheetName"] = ExpressionConverter.ConvertO(__workflow_mSExcelCutBetweenCellssourceWorksheetName);
                    mSExcelCutBetweenCellspropCount++;
                }

                mSExcelCutBetweenCellspropCount++;
                mSExcelCutBetweenCells["SourceCellReference"] = ExpressionConverter.ConvertO(__workflow_mSExcelCutBetweenCellssourceCellReference);
                if (__workflow_mSExcelCutBetweenCellssourceEntireRow != null)
                {
                    if (__workflow_mSExcelCutBetweenCellssourceEntireRow != null)
                    {
                        mSExcelCutBetweenCells["SourceEntireRow"] = ExpressionConverter.ConvertO(__workflow_mSExcelCutBetweenCellssourceEntireRow);
                        mSExcelCutBetweenCellspropCount++;
                    }

                    mSExcelCutBetweenCellspropCount++;
                }
                else
                {
                    mSExcelCutBetweenCells["SourceEntireRow"] = false;
                    mSExcelCutBetweenCellspropCount++;
                }

                if (__workflow_mSExcelCutBetweenCellssourceEntireColumn != null)
                {
                    if (__workflow_mSExcelCutBetweenCellssourceEntireColumn != null)
                    {
                        mSExcelCutBetweenCells["SourceEntireColumn"] = ExpressionConverter.ConvertO(__workflow_mSExcelCutBetweenCellssourceEntireColumn);
                        mSExcelCutBetweenCellspropCount++;
                    }

                    mSExcelCutBetweenCellspropCount++;
                }
                else
                {
                    mSExcelCutBetweenCells["SourceEntireColumn"] = false;
                    mSExcelCutBetweenCellspropCount++;
                }

                if (__workflow_mSExcelCutBetweenCellstargetHandle != null)
                {
                    if (__workflow_mSExcelCutBetweenCellstargetHandle != null)
                    {
                        mSExcelCutBetweenCells["TargetHandle"] = ExpressionConverter.ConvertO(__workflow_mSExcelCutBetweenCellstargetHandle);
                        mSExcelCutBetweenCellspropCount++;
                    }

                    mSExcelCutBetweenCellspropCount++;
                }
                else
                {
                    mSExcelCutBetweenCells["TargetHandle"] = 0;
                    mSExcelCutBetweenCellspropCount++;
                }

                if (__workflow_mSExcelCutBetweenCellstargetWorkbookName != null)
                {
                    mSExcelCutBetweenCells["TargetWorkbookName"] = ExpressionConverter.ConvertO(__workflow_mSExcelCutBetweenCellstargetWorkbookName);
                    mSExcelCutBetweenCellspropCount++;
                }

                if (__workflow_mSExcelCutBetweenCellstargetWorksheetName != null)
                {
                    mSExcelCutBetweenCells["TargetWorksheetName"] = ExpressionConverter.ConvertO(__workflow_mSExcelCutBetweenCellstargetWorksheetName);
                    mSExcelCutBetweenCellspropCount++;
                }

                mSExcelCutBetweenCellspropCount++;
                mSExcelCutBetweenCells["TargetCellReference"] = ExpressionConverter.ConvertO(__workflow_mSExcelCutBetweenCellstargetCellReference);
                if (__workflow_mSExcelCutBetweenCellstargetEntireRow != null)
                {
                    if (__workflow_mSExcelCutBetweenCellstargetEntireRow != null)
                    {
                        mSExcelCutBetweenCells["TargetEntireRow"] = ExpressionConverter.ConvertO(__workflow_mSExcelCutBetweenCellstargetEntireRow);
                        mSExcelCutBetweenCellspropCount++;
                    }

                    mSExcelCutBetweenCellspropCount++;
                }
                else
                {
                    mSExcelCutBetweenCells["TargetEntireRow"] = false;
                    mSExcelCutBetweenCellspropCount++;
                }

                if (__workflow_mSExcelCutBetweenCellstargetEntireColumn != null)
                {
                    if (__workflow_mSExcelCutBetweenCellstargetEntireColumn != null)
                    {
                        mSExcelCutBetweenCells["TargetEntireColumn"] = ExpressionConverter.ConvertO(__workflow_mSExcelCutBetweenCellstargetEntireColumn);
                        mSExcelCutBetweenCellspropCount++;
                    }

                    mSExcelCutBetweenCellspropCount++;
                }
                else
                {
                    mSExcelCutBetweenCells["TargetEntireColumn"] = false;
                    mSExcelCutBetweenCellspropCount++;
                }

                if (__workflow_mSExcelCutBetweenCellsvaluesOnly != null)
                {
                    if (__workflow_mSExcelCutBetweenCellsvaluesOnly != null)
                    {
                        mSExcelCutBetweenCells["ValuesOnly"] = ExpressionConverter.ConvertO(__workflow_mSExcelCutBetweenCellsvaluesOnly);
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
                mSExcelCutBetweenCells["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSExcelCutBetweenCellsworkflow);
                if (mSExcelCutBetweenCellspropCount > 0)
                {
                    callPayload.Body = mSExcelCutBetweenCells;
                }

                return new ApiConnectionAction<MSExcelCutBetweenCellsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelMinimiseWindowResponse> MSExcelMinimiseWindow(Expression<Func<string>> mSExcelMinimiseWindowworkflow, Expression<Func<int>> mSExcelMinimiseWindowhandle = null)
        {
            var __workflow_mSExcelMinimiseWindowworkflow = mSExcelMinimiseWindowworkflow == null ? null : WorkflowExpression.Compile(mSExcelMinimiseWindowworkflow);
            WorkflowExpression.Validate(__workflow_mSExcelMinimiseWindowworkflow, nameof(mSExcelMinimiseWindowworkflow), required: true);
            var __workflow_mSExcelMinimiseWindowhandle = mSExcelMinimiseWindowhandle == null ? null : WorkflowExpression.Compile(mSExcelMinimiseWindowhandle);
            WorkflowExpression.Validate(__workflow_mSExcelMinimiseWindowhandle, nameof(mSExcelMinimiseWindowhandle), required: false);
            return new DeferredBodyAction<MSExcelMinimiseWindowResponse>(() =>
            {
                var apiCallPath = "/MSExcel/MinimiseWindow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSExcelMinimiseWindow = new JObject();
                var mSExcelMinimiseWindowpropCount = 0;
                if (__workflow_mSExcelMinimiseWindowhandle != null)
                {
                    if (__workflow_mSExcelMinimiseWindowhandle != null)
                    {
                        mSExcelMinimiseWindow["Handle"] = ExpressionConverter.ConvertO(__workflow_mSExcelMinimiseWindowhandle);
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
                mSExcelMinimiseWindow["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSExcelMinimiseWindowworkflow);
                if (mSExcelMinimiseWindowpropCount > 0)
                {
                    callPayload.Body = mSExcelMinimiseWindow;
                }

                return new ApiConnectionAction<MSExcelMinimiseWindowResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelMaximiseWindowResponse> MSExcelMaximiseWindow(Expression<Func<string>> mSExcelMaximiseWindowworkflow, Expression<Func<int>> mSExcelMaximiseWindowhandle = null)
        {
            var __workflow_mSExcelMaximiseWindowworkflow = mSExcelMaximiseWindowworkflow == null ? null : WorkflowExpression.Compile(mSExcelMaximiseWindowworkflow);
            WorkflowExpression.Validate(__workflow_mSExcelMaximiseWindowworkflow, nameof(mSExcelMaximiseWindowworkflow), required: true);
            var __workflow_mSExcelMaximiseWindowhandle = mSExcelMaximiseWindowhandle == null ? null : WorkflowExpression.Compile(mSExcelMaximiseWindowhandle);
            WorkflowExpression.Validate(__workflow_mSExcelMaximiseWindowhandle, nameof(mSExcelMaximiseWindowhandle), required: false);
            return new DeferredBodyAction<MSExcelMaximiseWindowResponse>(() =>
            {
                var apiCallPath = "/MSExcel/MaximiseWindow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSExcelMaximiseWindow = new JObject();
                var mSExcelMaximiseWindowpropCount = 0;
                if (__workflow_mSExcelMaximiseWindowhandle != null)
                {
                    if (__workflow_mSExcelMaximiseWindowhandle != null)
                    {
                        mSExcelMaximiseWindow["Handle"] = ExpressionConverter.ConvertO(__workflow_mSExcelMaximiseWindowhandle);
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
                mSExcelMaximiseWindow["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSExcelMaximiseWindowworkflow);
                if (mSExcelMaximiseWindowpropCount > 0)
                {
                    callPayload.Body = mSExcelMaximiseWindow;
                }

                return new ApiConnectionAction<MSExcelMaximiseWindowResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelNormaliseWindowResponse> MSExcelNormaliseWindow(Expression<Func<string>> mSExcelNormaliseWindowworkflow, Expression<Func<int>> mSExcelNormaliseWindowhandle = null)
        {
            var __workflow_mSExcelNormaliseWindowworkflow = mSExcelNormaliseWindowworkflow == null ? null : WorkflowExpression.Compile(mSExcelNormaliseWindowworkflow);
            WorkflowExpression.Validate(__workflow_mSExcelNormaliseWindowworkflow, nameof(mSExcelNormaliseWindowworkflow), required: true);
            var __workflow_mSExcelNormaliseWindowhandle = mSExcelNormaliseWindowhandle == null ? null : WorkflowExpression.Compile(mSExcelNormaliseWindowhandle);
            WorkflowExpression.Validate(__workflow_mSExcelNormaliseWindowhandle, nameof(mSExcelNormaliseWindowhandle), required: false);
            return new DeferredBodyAction<MSExcelNormaliseWindowResponse>(() =>
            {
                var apiCallPath = "/MSExcel/NormaliseWindow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSExcelNormaliseWindow = new JObject();
                var mSExcelNormaliseWindowpropCount = 0;
                if (__workflow_mSExcelNormaliseWindowhandle != null)
                {
                    if (__workflow_mSExcelNormaliseWindowhandle != null)
                    {
                        mSExcelNormaliseWindow["Handle"] = ExpressionConverter.ConvertO(__workflow_mSExcelNormaliseWindowhandle);
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
                mSExcelNormaliseWindow["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSExcelNormaliseWindowworkflow);
                if (mSExcelNormaliseWindowpropCount > 0)
                {
                    callPayload.Body = mSExcelNormaliseWindow;
                }

                return new ApiConnectionAction<MSExcelNormaliseWindowResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetAndSetCellValueResponse> MSExcelGetAndSetCellValue(Expression<Func<string>> mSExcelGetAndSetCellValuesourceCellReference, Expression<Func<string>> mSExcelGetAndSetCellValuetargetCellReference, Expression<Func<string>> mSExcelGetAndSetCellValueworkflow, Expression<Func<int>> mSExcelGetAndSetCellValuesourceHandle = null, Expression<Func<string>> mSExcelGetAndSetCellValuesourceWorkbookName = null, Expression<Func<string>> mSExcelGetAndSetCellValuesourceWorksheetName = null, Expression<Func<int>> mSExcelGetAndSetCellValuetargetHandle = null, Expression<Func<string>> mSExcelGetAndSetCellValuetargetWorkbookName = null, Expression<Func<string>> mSExcelGetAndSetCellValuetargetWorksheetName = null)
        {
            var __workflow_mSExcelGetAndSetCellValuesourceCellReference = mSExcelGetAndSetCellValuesourceCellReference == null ? null : WorkflowExpression.Compile(mSExcelGetAndSetCellValuesourceCellReference);
            WorkflowExpression.Validate(__workflow_mSExcelGetAndSetCellValuesourceCellReference, nameof(mSExcelGetAndSetCellValuesourceCellReference), required: true);
            var __workflow_mSExcelGetAndSetCellValuetargetCellReference = mSExcelGetAndSetCellValuetargetCellReference == null ? null : WorkflowExpression.Compile(mSExcelGetAndSetCellValuetargetCellReference);
            WorkflowExpression.Validate(__workflow_mSExcelGetAndSetCellValuetargetCellReference, nameof(mSExcelGetAndSetCellValuetargetCellReference), required: true);
            var __workflow_mSExcelGetAndSetCellValueworkflow = mSExcelGetAndSetCellValueworkflow == null ? null : WorkflowExpression.Compile(mSExcelGetAndSetCellValueworkflow);
            WorkflowExpression.Validate(__workflow_mSExcelGetAndSetCellValueworkflow, nameof(mSExcelGetAndSetCellValueworkflow), required: true);
            var __workflow_mSExcelGetAndSetCellValuesourceHandle = mSExcelGetAndSetCellValuesourceHandle == null ? null : WorkflowExpression.Compile(mSExcelGetAndSetCellValuesourceHandle);
            WorkflowExpression.Validate(__workflow_mSExcelGetAndSetCellValuesourceHandle, nameof(mSExcelGetAndSetCellValuesourceHandle), required: false);
            var __workflow_mSExcelGetAndSetCellValuesourceWorkbookName = mSExcelGetAndSetCellValuesourceWorkbookName == null ? null : WorkflowExpression.Compile(mSExcelGetAndSetCellValuesourceWorkbookName);
            WorkflowExpression.Validate(__workflow_mSExcelGetAndSetCellValuesourceWorkbookName, nameof(mSExcelGetAndSetCellValuesourceWorkbookName), required: false);
            var __workflow_mSExcelGetAndSetCellValuesourceWorksheetName = mSExcelGetAndSetCellValuesourceWorksheetName == null ? null : WorkflowExpression.Compile(mSExcelGetAndSetCellValuesourceWorksheetName);
            WorkflowExpression.Validate(__workflow_mSExcelGetAndSetCellValuesourceWorksheetName, nameof(mSExcelGetAndSetCellValuesourceWorksheetName), required: false);
            var __workflow_mSExcelGetAndSetCellValuetargetHandle = mSExcelGetAndSetCellValuetargetHandle == null ? null : WorkflowExpression.Compile(mSExcelGetAndSetCellValuetargetHandle);
            WorkflowExpression.Validate(__workflow_mSExcelGetAndSetCellValuetargetHandle, nameof(mSExcelGetAndSetCellValuetargetHandle), required: false);
            var __workflow_mSExcelGetAndSetCellValuetargetWorkbookName = mSExcelGetAndSetCellValuetargetWorkbookName == null ? null : WorkflowExpression.Compile(mSExcelGetAndSetCellValuetargetWorkbookName);
            WorkflowExpression.Validate(__workflow_mSExcelGetAndSetCellValuetargetWorkbookName, nameof(mSExcelGetAndSetCellValuetargetWorkbookName), required: false);
            var __workflow_mSExcelGetAndSetCellValuetargetWorksheetName = mSExcelGetAndSetCellValuetargetWorksheetName == null ? null : WorkflowExpression.Compile(mSExcelGetAndSetCellValuetargetWorksheetName);
            WorkflowExpression.Validate(__workflow_mSExcelGetAndSetCellValuetargetWorksheetName, nameof(mSExcelGetAndSetCellValuetargetWorksheetName), required: false);
            return new DeferredBodyAction<MSExcelGetAndSetCellValueResponse>(() =>
            {
                var apiCallPath = "/MSExcel/GetAndSetCellValue";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSExcelGetAndSetCellValue = new JObject();
                var mSExcelGetAndSetCellValuepropCount = 0;
                if (__workflow_mSExcelGetAndSetCellValuesourceHandle != null)
                {
                    if (__workflow_mSExcelGetAndSetCellValuesourceHandle != null)
                    {
                        mSExcelGetAndSetCellValue["SourceHandle"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetAndSetCellValuesourceHandle);
                        mSExcelGetAndSetCellValuepropCount++;
                    }

                    mSExcelGetAndSetCellValuepropCount++;
                }
                else
                {
                    mSExcelGetAndSetCellValue["SourceHandle"] = 0;
                    mSExcelGetAndSetCellValuepropCount++;
                }

                if (__workflow_mSExcelGetAndSetCellValuesourceWorkbookName != null)
                {
                    mSExcelGetAndSetCellValue["SourceWorkbookName"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetAndSetCellValuesourceWorkbookName);
                    mSExcelGetAndSetCellValuepropCount++;
                }

                if (__workflow_mSExcelGetAndSetCellValuesourceWorksheetName != null)
                {
                    mSExcelGetAndSetCellValue["SourceWorksheetName"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetAndSetCellValuesourceWorksheetName);
                    mSExcelGetAndSetCellValuepropCount++;
                }

                mSExcelGetAndSetCellValuepropCount++;
                mSExcelGetAndSetCellValue["SourceCellReference"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetAndSetCellValuesourceCellReference);
                if (__workflow_mSExcelGetAndSetCellValuetargetHandle != null)
                {
                    if (__workflow_mSExcelGetAndSetCellValuetargetHandle != null)
                    {
                        mSExcelGetAndSetCellValue["TargetHandle"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetAndSetCellValuetargetHandle);
                        mSExcelGetAndSetCellValuepropCount++;
                    }

                    mSExcelGetAndSetCellValuepropCount++;
                }
                else
                {
                    mSExcelGetAndSetCellValue["TargetHandle"] = 0;
                    mSExcelGetAndSetCellValuepropCount++;
                }

                if (__workflow_mSExcelGetAndSetCellValuetargetWorkbookName != null)
                {
                    mSExcelGetAndSetCellValue["TargetWorkbookName"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetAndSetCellValuetargetWorkbookName);
                    mSExcelGetAndSetCellValuepropCount++;
                }

                if (__workflow_mSExcelGetAndSetCellValuetargetWorksheetName != null)
                {
                    mSExcelGetAndSetCellValue["TargetWorksheetName"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetAndSetCellValuetargetWorksheetName);
                    mSExcelGetAndSetCellValuepropCount++;
                }

                mSExcelGetAndSetCellValuepropCount++;
                mSExcelGetAndSetCellValue["TargetCellReference"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetAndSetCellValuetargetCellReference);
                mSExcelGetAndSetCellValuepropCount++;
                mSExcelGetAndSetCellValue["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetAndSetCellValueworkflow);
                if (mSExcelGetAndSetCellValuepropCount > 0)
                {
                    callPayload.Body = mSExcelGetAndSetCellValue;
                }

                return new ApiConnectionAction<MSExcelGetAndSetCellValueResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetAndSetCellValue2Response> MSExcelGetAndSetCellValue2(Expression<Func<string>> mSExcelGetAndSetCellValue2sourceCellReference, Expression<Func<string>> mSExcelGetAndSetCellValue2targetCellReference, Expression<Func<string>> mSExcelGetAndSetCellValue2workflow, Expression<Func<int>> mSExcelGetAndSetCellValue2sourceHandle = null, Expression<Func<string>> mSExcelGetAndSetCellValue2sourceWorkbookName = null, Expression<Func<string>> mSExcelGetAndSetCellValue2sourceWorksheetName = null, Expression<Func<int>> mSExcelGetAndSetCellValue2targetHandle = null, Expression<Func<string>> mSExcelGetAndSetCellValue2targetWorkbookName = null, Expression<Func<string>> mSExcelGetAndSetCellValue2targetWorksheetName = null)
        {
            var __workflow_mSExcelGetAndSetCellValue2sourceCellReference = mSExcelGetAndSetCellValue2sourceCellReference == null ? null : WorkflowExpression.Compile(mSExcelGetAndSetCellValue2sourceCellReference);
            WorkflowExpression.Validate(__workflow_mSExcelGetAndSetCellValue2sourceCellReference, nameof(mSExcelGetAndSetCellValue2sourceCellReference), required: true);
            var __workflow_mSExcelGetAndSetCellValue2targetCellReference = mSExcelGetAndSetCellValue2targetCellReference == null ? null : WorkflowExpression.Compile(mSExcelGetAndSetCellValue2targetCellReference);
            WorkflowExpression.Validate(__workflow_mSExcelGetAndSetCellValue2targetCellReference, nameof(mSExcelGetAndSetCellValue2targetCellReference), required: true);
            var __workflow_mSExcelGetAndSetCellValue2workflow = mSExcelGetAndSetCellValue2workflow == null ? null : WorkflowExpression.Compile(mSExcelGetAndSetCellValue2workflow);
            WorkflowExpression.Validate(__workflow_mSExcelGetAndSetCellValue2workflow, nameof(mSExcelGetAndSetCellValue2workflow), required: true);
            var __workflow_mSExcelGetAndSetCellValue2sourceHandle = mSExcelGetAndSetCellValue2sourceHandle == null ? null : WorkflowExpression.Compile(mSExcelGetAndSetCellValue2sourceHandle);
            WorkflowExpression.Validate(__workflow_mSExcelGetAndSetCellValue2sourceHandle, nameof(mSExcelGetAndSetCellValue2sourceHandle), required: false);
            var __workflow_mSExcelGetAndSetCellValue2sourceWorkbookName = mSExcelGetAndSetCellValue2sourceWorkbookName == null ? null : WorkflowExpression.Compile(mSExcelGetAndSetCellValue2sourceWorkbookName);
            WorkflowExpression.Validate(__workflow_mSExcelGetAndSetCellValue2sourceWorkbookName, nameof(mSExcelGetAndSetCellValue2sourceWorkbookName), required: false);
            var __workflow_mSExcelGetAndSetCellValue2sourceWorksheetName = mSExcelGetAndSetCellValue2sourceWorksheetName == null ? null : WorkflowExpression.Compile(mSExcelGetAndSetCellValue2sourceWorksheetName);
            WorkflowExpression.Validate(__workflow_mSExcelGetAndSetCellValue2sourceWorksheetName, nameof(mSExcelGetAndSetCellValue2sourceWorksheetName), required: false);
            var __workflow_mSExcelGetAndSetCellValue2targetHandle = mSExcelGetAndSetCellValue2targetHandle == null ? null : WorkflowExpression.Compile(mSExcelGetAndSetCellValue2targetHandle);
            WorkflowExpression.Validate(__workflow_mSExcelGetAndSetCellValue2targetHandle, nameof(mSExcelGetAndSetCellValue2targetHandle), required: false);
            var __workflow_mSExcelGetAndSetCellValue2targetWorkbookName = mSExcelGetAndSetCellValue2targetWorkbookName == null ? null : WorkflowExpression.Compile(mSExcelGetAndSetCellValue2targetWorkbookName);
            WorkflowExpression.Validate(__workflow_mSExcelGetAndSetCellValue2targetWorkbookName, nameof(mSExcelGetAndSetCellValue2targetWorkbookName), required: false);
            var __workflow_mSExcelGetAndSetCellValue2targetWorksheetName = mSExcelGetAndSetCellValue2targetWorksheetName == null ? null : WorkflowExpression.Compile(mSExcelGetAndSetCellValue2targetWorksheetName);
            WorkflowExpression.Validate(__workflow_mSExcelGetAndSetCellValue2targetWorksheetName, nameof(mSExcelGetAndSetCellValue2targetWorksheetName), required: false);
            return new DeferredBodyAction<MSExcelGetAndSetCellValue2Response>(() =>
            {
                var apiCallPath = "/MSExcel/GetAndSetCellValue2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSExcelGetAndSetCellValue2 = new JObject();
                var mSExcelGetAndSetCellValue2propCount = 0;
                if (__workflow_mSExcelGetAndSetCellValue2sourceHandle != null)
                {
                    if (__workflow_mSExcelGetAndSetCellValue2sourceHandle != null)
                    {
                        mSExcelGetAndSetCellValue2["SourceHandle"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetAndSetCellValue2sourceHandle);
                        mSExcelGetAndSetCellValue2propCount++;
                    }

                    mSExcelGetAndSetCellValue2propCount++;
                }
                else
                {
                    mSExcelGetAndSetCellValue2["SourceHandle"] = 0;
                    mSExcelGetAndSetCellValue2propCount++;
                }

                if (__workflow_mSExcelGetAndSetCellValue2sourceWorkbookName != null)
                {
                    mSExcelGetAndSetCellValue2["SourceWorkbookName"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetAndSetCellValue2sourceWorkbookName);
                    mSExcelGetAndSetCellValue2propCount++;
                }

                if (__workflow_mSExcelGetAndSetCellValue2sourceWorksheetName != null)
                {
                    mSExcelGetAndSetCellValue2["SourceWorksheetName"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetAndSetCellValue2sourceWorksheetName);
                    mSExcelGetAndSetCellValue2propCount++;
                }

                mSExcelGetAndSetCellValue2propCount++;
                mSExcelGetAndSetCellValue2["SourceCellReference"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetAndSetCellValue2sourceCellReference);
                if (__workflow_mSExcelGetAndSetCellValue2targetHandle != null)
                {
                    if (__workflow_mSExcelGetAndSetCellValue2targetHandle != null)
                    {
                        mSExcelGetAndSetCellValue2["TargetHandle"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetAndSetCellValue2targetHandle);
                        mSExcelGetAndSetCellValue2propCount++;
                    }

                    mSExcelGetAndSetCellValue2propCount++;
                }
                else
                {
                    mSExcelGetAndSetCellValue2["TargetHandle"] = 0;
                    mSExcelGetAndSetCellValue2propCount++;
                }

                if (__workflow_mSExcelGetAndSetCellValue2targetWorkbookName != null)
                {
                    mSExcelGetAndSetCellValue2["TargetWorkbookName"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetAndSetCellValue2targetWorkbookName);
                    mSExcelGetAndSetCellValue2propCount++;
                }

                if (__workflow_mSExcelGetAndSetCellValue2targetWorksheetName != null)
                {
                    mSExcelGetAndSetCellValue2["TargetWorksheetName"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetAndSetCellValue2targetWorksheetName);
                    mSExcelGetAndSetCellValue2propCount++;
                }

                mSExcelGetAndSetCellValue2propCount++;
                mSExcelGetAndSetCellValue2["TargetCellReference"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetAndSetCellValue2targetCellReference);
                mSExcelGetAndSetCellValue2propCount++;
                mSExcelGetAndSetCellValue2["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetAndSetCellValue2workflow);
                if (mSExcelGetAndSetCellValue2propCount > 0)
                {
                    callPayload.Body = mSExcelGetAndSetCellValue2;
                }

                return new ApiConnectionAction<MSExcelGetAndSetCellValue2Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetAndSetCellTextResponse> MSExcelGetAndSetCellText(Expression<Func<string>> mSExcelGetAndSetCellTextsourceCellReference, Expression<Func<string>> mSExcelGetAndSetCellTexttargetCellReference, Expression<Func<string>> mSExcelGetAndSetCellTextworkflow, Expression<Func<int>> mSExcelGetAndSetCellTextsourceHandle = null, Expression<Func<string>> mSExcelGetAndSetCellTextsourceWorkbookName = null, Expression<Func<string>> mSExcelGetAndSetCellTextsourceWorksheetName = null, Expression<Func<int>> mSExcelGetAndSetCellTexttargetHandle = null, Expression<Func<string>> mSExcelGetAndSetCellTexttargetWorkbookName = null, Expression<Func<string>> mSExcelGetAndSetCellTexttargetWorksheetName = null)
        {
            var __workflow_mSExcelGetAndSetCellTextsourceCellReference = mSExcelGetAndSetCellTextsourceCellReference == null ? null : WorkflowExpression.Compile(mSExcelGetAndSetCellTextsourceCellReference);
            WorkflowExpression.Validate(__workflow_mSExcelGetAndSetCellTextsourceCellReference, nameof(mSExcelGetAndSetCellTextsourceCellReference), required: true);
            var __workflow_mSExcelGetAndSetCellTexttargetCellReference = mSExcelGetAndSetCellTexttargetCellReference == null ? null : WorkflowExpression.Compile(mSExcelGetAndSetCellTexttargetCellReference);
            WorkflowExpression.Validate(__workflow_mSExcelGetAndSetCellTexttargetCellReference, nameof(mSExcelGetAndSetCellTexttargetCellReference), required: true);
            var __workflow_mSExcelGetAndSetCellTextworkflow = mSExcelGetAndSetCellTextworkflow == null ? null : WorkflowExpression.Compile(mSExcelGetAndSetCellTextworkflow);
            WorkflowExpression.Validate(__workflow_mSExcelGetAndSetCellTextworkflow, nameof(mSExcelGetAndSetCellTextworkflow), required: true);
            var __workflow_mSExcelGetAndSetCellTextsourceHandle = mSExcelGetAndSetCellTextsourceHandle == null ? null : WorkflowExpression.Compile(mSExcelGetAndSetCellTextsourceHandle);
            WorkflowExpression.Validate(__workflow_mSExcelGetAndSetCellTextsourceHandle, nameof(mSExcelGetAndSetCellTextsourceHandle), required: false);
            var __workflow_mSExcelGetAndSetCellTextsourceWorkbookName = mSExcelGetAndSetCellTextsourceWorkbookName == null ? null : WorkflowExpression.Compile(mSExcelGetAndSetCellTextsourceWorkbookName);
            WorkflowExpression.Validate(__workflow_mSExcelGetAndSetCellTextsourceWorkbookName, nameof(mSExcelGetAndSetCellTextsourceWorkbookName), required: false);
            var __workflow_mSExcelGetAndSetCellTextsourceWorksheetName = mSExcelGetAndSetCellTextsourceWorksheetName == null ? null : WorkflowExpression.Compile(mSExcelGetAndSetCellTextsourceWorksheetName);
            WorkflowExpression.Validate(__workflow_mSExcelGetAndSetCellTextsourceWorksheetName, nameof(mSExcelGetAndSetCellTextsourceWorksheetName), required: false);
            var __workflow_mSExcelGetAndSetCellTexttargetHandle = mSExcelGetAndSetCellTexttargetHandle == null ? null : WorkflowExpression.Compile(mSExcelGetAndSetCellTexttargetHandle);
            WorkflowExpression.Validate(__workflow_mSExcelGetAndSetCellTexttargetHandle, nameof(mSExcelGetAndSetCellTexttargetHandle), required: false);
            var __workflow_mSExcelGetAndSetCellTexttargetWorkbookName = mSExcelGetAndSetCellTexttargetWorkbookName == null ? null : WorkflowExpression.Compile(mSExcelGetAndSetCellTexttargetWorkbookName);
            WorkflowExpression.Validate(__workflow_mSExcelGetAndSetCellTexttargetWorkbookName, nameof(mSExcelGetAndSetCellTexttargetWorkbookName), required: false);
            var __workflow_mSExcelGetAndSetCellTexttargetWorksheetName = mSExcelGetAndSetCellTexttargetWorksheetName == null ? null : WorkflowExpression.Compile(mSExcelGetAndSetCellTexttargetWorksheetName);
            WorkflowExpression.Validate(__workflow_mSExcelGetAndSetCellTexttargetWorksheetName, nameof(mSExcelGetAndSetCellTexttargetWorksheetName), required: false);
            return new DeferredBodyAction<MSExcelGetAndSetCellTextResponse>(() =>
            {
                var apiCallPath = "/MSExcel/GetAndSetCellText";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSExcelGetAndSetCellText = new JObject();
                var mSExcelGetAndSetCellTextpropCount = 0;
                if (__workflow_mSExcelGetAndSetCellTextsourceHandle != null)
                {
                    if (__workflow_mSExcelGetAndSetCellTextsourceHandle != null)
                    {
                        mSExcelGetAndSetCellText["SourceHandle"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetAndSetCellTextsourceHandle);
                        mSExcelGetAndSetCellTextpropCount++;
                    }

                    mSExcelGetAndSetCellTextpropCount++;
                }
                else
                {
                    mSExcelGetAndSetCellText["SourceHandle"] = 0;
                    mSExcelGetAndSetCellTextpropCount++;
                }

                if (__workflow_mSExcelGetAndSetCellTextsourceWorkbookName != null)
                {
                    mSExcelGetAndSetCellText["SourceWorkbookName"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetAndSetCellTextsourceWorkbookName);
                    mSExcelGetAndSetCellTextpropCount++;
                }

                if (__workflow_mSExcelGetAndSetCellTextsourceWorksheetName != null)
                {
                    mSExcelGetAndSetCellText["SourceWorksheetName"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetAndSetCellTextsourceWorksheetName);
                    mSExcelGetAndSetCellTextpropCount++;
                }

                mSExcelGetAndSetCellTextpropCount++;
                mSExcelGetAndSetCellText["SourceCellReference"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetAndSetCellTextsourceCellReference);
                if (__workflow_mSExcelGetAndSetCellTexttargetHandle != null)
                {
                    if (__workflow_mSExcelGetAndSetCellTexttargetHandle != null)
                    {
                        mSExcelGetAndSetCellText["TargetHandle"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetAndSetCellTexttargetHandle);
                        mSExcelGetAndSetCellTextpropCount++;
                    }

                    mSExcelGetAndSetCellTextpropCount++;
                }
                else
                {
                    mSExcelGetAndSetCellText["TargetHandle"] = 0;
                    mSExcelGetAndSetCellTextpropCount++;
                }

                if (__workflow_mSExcelGetAndSetCellTexttargetWorkbookName != null)
                {
                    mSExcelGetAndSetCellText["TargetWorkbookName"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetAndSetCellTexttargetWorkbookName);
                    mSExcelGetAndSetCellTextpropCount++;
                }

                if (__workflow_mSExcelGetAndSetCellTexttargetWorksheetName != null)
                {
                    mSExcelGetAndSetCellText["TargetWorksheetName"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetAndSetCellTexttargetWorksheetName);
                    mSExcelGetAndSetCellTextpropCount++;
                }

                mSExcelGetAndSetCellTextpropCount++;
                mSExcelGetAndSetCellText["TargetCellReference"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetAndSetCellTexttargetCellReference);
                mSExcelGetAndSetCellTextpropCount++;
                mSExcelGetAndSetCellText["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetAndSetCellTextworkflow);
                if (mSExcelGetAndSetCellTextpropCount > 0)
                {
                    callPayload.Body = mSExcelGetAndSetCellText;
                }

                return new ApiConnectionAction<MSExcelGetAndSetCellTextResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelCheckOLEObjectResponse> MSExcelCheckOLEObject(Expression<Func<string>> mSExcelCheckOLEObjectoLEObjectName, Expression<Func<string>> mSExcelCheckOLEObjectworkflow, Expression<Func<int>> mSExcelCheckOLEObjecthandle = null, Expression<Func<string>> mSExcelCheckOLEObjectworkbookName = null, Expression<Func<string>> mSExcelCheckOLEObjectworksheetName = null, Expression<Func<bool>> mSExcelCheckOLEObjectchecked = null, Expression<Func<bool>> mSExcelCheckOLEObjectrunInBackground = null)
        {
            var __workflow_mSExcelCheckOLEObjectoLEObjectName = mSExcelCheckOLEObjectoLEObjectName == null ? null : WorkflowExpression.Compile(mSExcelCheckOLEObjectoLEObjectName);
            WorkflowExpression.Validate(__workflow_mSExcelCheckOLEObjectoLEObjectName, nameof(mSExcelCheckOLEObjectoLEObjectName), required: true);
            var __workflow_mSExcelCheckOLEObjectworkflow = mSExcelCheckOLEObjectworkflow == null ? null : WorkflowExpression.Compile(mSExcelCheckOLEObjectworkflow);
            WorkflowExpression.Validate(__workflow_mSExcelCheckOLEObjectworkflow, nameof(mSExcelCheckOLEObjectworkflow), required: true);
            var __workflow_mSExcelCheckOLEObjecthandle = mSExcelCheckOLEObjecthandle == null ? null : WorkflowExpression.Compile(mSExcelCheckOLEObjecthandle);
            WorkflowExpression.Validate(__workflow_mSExcelCheckOLEObjecthandle, nameof(mSExcelCheckOLEObjecthandle), required: false);
            var __workflow_mSExcelCheckOLEObjectworkbookName = mSExcelCheckOLEObjectworkbookName == null ? null : WorkflowExpression.Compile(mSExcelCheckOLEObjectworkbookName);
            WorkflowExpression.Validate(__workflow_mSExcelCheckOLEObjectworkbookName, nameof(mSExcelCheckOLEObjectworkbookName), required: false);
            var __workflow_mSExcelCheckOLEObjectworksheetName = mSExcelCheckOLEObjectworksheetName == null ? null : WorkflowExpression.Compile(mSExcelCheckOLEObjectworksheetName);
            WorkflowExpression.Validate(__workflow_mSExcelCheckOLEObjectworksheetName, nameof(mSExcelCheckOLEObjectworksheetName), required: false);
            var __workflow_mSExcelCheckOLEObjectchecked = mSExcelCheckOLEObjectchecked == null ? null : WorkflowExpression.Compile(mSExcelCheckOLEObjectchecked);
            WorkflowExpression.Validate(__workflow_mSExcelCheckOLEObjectchecked, nameof(mSExcelCheckOLEObjectchecked), required: false);
            var __workflow_mSExcelCheckOLEObjectrunInBackground = mSExcelCheckOLEObjectrunInBackground == null ? null : WorkflowExpression.Compile(mSExcelCheckOLEObjectrunInBackground);
            WorkflowExpression.Validate(__workflow_mSExcelCheckOLEObjectrunInBackground, nameof(mSExcelCheckOLEObjectrunInBackground), required: false);
            return new DeferredBodyAction<MSExcelCheckOLEObjectResponse>(() =>
            {
                var apiCallPath = "/MSExcel/CheckOLEObject";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSExcelCheckOLEObject = new JObject();
                var mSExcelCheckOLEObjectpropCount = 0;
                if (__workflow_mSExcelCheckOLEObjecthandle != null)
                {
                    if (__workflow_mSExcelCheckOLEObjecthandle != null)
                    {
                        mSExcelCheckOLEObject["Handle"] = ExpressionConverter.ConvertO(__workflow_mSExcelCheckOLEObjecthandle);
                        mSExcelCheckOLEObjectpropCount++;
                    }

                    mSExcelCheckOLEObjectpropCount++;
                }
                else
                {
                    mSExcelCheckOLEObject["Handle"] = 0;
                    mSExcelCheckOLEObjectpropCount++;
                }

                if (__workflow_mSExcelCheckOLEObjectworkbookName != null)
                {
                    mSExcelCheckOLEObject["WorkbookName"] = ExpressionConverter.ConvertO(__workflow_mSExcelCheckOLEObjectworkbookName);
                    mSExcelCheckOLEObjectpropCount++;
                }

                if (__workflow_mSExcelCheckOLEObjectworksheetName != null)
                {
                    mSExcelCheckOLEObject["WorksheetName"] = ExpressionConverter.ConvertO(__workflow_mSExcelCheckOLEObjectworksheetName);
                    mSExcelCheckOLEObjectpropCount++;
                }

                mSExcelCheckOLEObjectpropCount++;
                mSExcelCheckOLEObject["OLEObjectName"] = ExpressionConverter.ConvertO(__workflow_mSExcelCheckOLEObjectoLEObjectName);
                if (__workflow_mSExcelCheckOLEObjectchecked != null)
                {
                    if (__workflow_mSExcelCheckOLEObjectchecked != null)
                    {
                        mSExcelCheckOLEObject["Checked"] = ExpressionConverter.ConvertO(__workflow_mSExcelCheckOLEObjectchecked);
                        mSExcelCheckOLEObjectpropCount++;
                    }

                    mSExcelCheckOLEObjectpropCount++;
                }
                else
                {
                    mSExcelCheckOLEObject["Checked"] = false;
                    mSExcelCheckOLEObjectpropCount++;
                }

                if (__workflow_mSExcelCheckOLEObjectrunInBackground != null)
                {
                    if (__workflow_mSExcelCheckOLEObjectrunInBackground != null)
                    {
                        mSExcelCheckOLEObject["RunInBackground"] = ExpressionConverter.ConvertO(__workflow_mSExcelCheckOLEObjectrunInBackground);
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
                mSExcelCheckOLEObject["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSExcelCheckOLEObjectworkflow);
                if (mSExcelCheckOLEObjectpropCount > 0)
                {
                    callPayload.Body = mSExcelCheckOLEObject;
                }

                return new ApiConnectionAction<MSExcelCheckOLEObjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelInputTextIntoOLEObjectResponse> MSExcelInputTextIntoOLEObject(Expression<Func<string>> mSExcelInputTextIntoOLEObjectoLEObjectName, Expression<Func<string>> mSExcelInputTextIntoOLEObjectworkflow, Expression<Func<int>> mSExcelInputTextIntoOLEObjecthandle = null, Expression<Func<string>> mSExcelInputTextIntoOLEObjectworkbookName = null, Expression<Func<string>> mSExcelInputTextIntoOLEObjectworksheetName = null, Expression<Func<string>> mSExcelInputTextIntoOLEObjecttextToInput = null, Expression<Func<bool>> mSExcelInputTextIntoOLEObjectrunInBackground = null)
        {
            var __workflow_mSExcelInputTextIntoOLEObjectoLEObjectName = mSExcelInputTextIntoOLEObjectoLEObjectName == null ? null : WorkflowExpression.Compile(mSExcelInputTextIntoOLEObjectoLEObjectName);
            WorkflowExpression.Validate(__workflow_mSExcelInputTextIntoOLEObjectoLEObjectName, nameof(mSExcelInputTextIntoOLEObjectoLEObjectName), required: true);
            var __workflow_mSExcelInputTextIntoOLEObjectworkflow = mSExcelInputTextIntoOLEObjectworkflow == null ? null : WorkflowExpression.Compile(mSExcelInputTextIntoOLEObjectworkflow);
            WorkflowExpression.Validate(__workflow_mSExcelInputTextIntoOLEObjectworkflow, nameof(mSExcelInputTextIntoOLEObjectworkflow), required: true);
            var __workflow_mSExcelInputTextIntoOLEObjecthandle = mSExcelInputTextIntoOLEObjecthandle == null ? null : WorkflowExpression.Compile(mSExcelInputTextIntoOLEObjecthandle);
            WorkflowExpression.Validate(__workflow_mSExcelInputTextIntoOLEObjecthandle, nameof(mSExcelInputTextIntoOLEObjecthandle), required: false);
            var __workflow_mSExcelInputTextIntoOLEObjectworkbookName = mSExcelInputTextIntoOLEObjectworkbookName == null ? null : WorkflowExpression.Compile(mSExcelInputTextIntoOLEObjectworkbookName);
            WorkflowExpression.Validate(__workflow_mSExcelInputTextIntoOLEObjectworkbookName, nameof(mSExcelInputTextIntoOLEObjectworkbookName), required: false);
            var __workflow_mSExcelInputTextIntoOLEObjectworksheetName = mSExcelInputTextIntoOLEObjectworksheetName == null ? null : WorkflowExpression.Compile(mSExcelInputTextIntoOLEObjectworksheetName);
            WorkflowExpression.Validate(__workflow_mSExcelInputTextIntoOLEObjectworksheetName, nameof(mSExcelInputTextIntoOLEObjectworksheetName), required: false);
            var __workflow_mSExcelInputTextIntoOLEObjecttextToInput = mSExcelInputTextIntoOLEObjecttextToInput == null ? null : WorkflowExpression.Compile(mSExcelInputTextIntoOLEObjecttextToInput);
            WorkflowExpression.Validate(__workflow_mSExcelInputTextIntoOLEObjecttextToInput, nameof(mSExcelInputTextIntoOLEObjecttextToInput), required: false);
            var __workflow_mSExcelInputTextIntoOLEObjectrunInBackground = mSExcelInputTextIntoOLEObjectrunInBackground == null ? null : WorkflowExpression.Compile(mSExcelInputTextIntoOLEObjectrunInBackground);
            WorkflowExpression.Validate(__workflow_mSExcelInputTextIntoOLEObjectrunInBackground, nameof(mSExcelInputTextIntoOLEObjectrunInBackground), required: false);
            return new DeferredBodyAction<MSExcelInputTextIntoOLEObjectResponse>(() =>
            {
                var apiCallPath = "/MSExcel/InputTextIntoOLEObject";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSExcelInputTextIntoOLEObject = new JObject();
                var mSExcelInputTextIntoOLEObjectpropCount = 0;
                if (__workflow_mSExcelInputTextIntoOLEObjecthandle != null)
                {
                    if (__workflow_mSExcelInputTextIntoOLEObjecthandle != null)
                    {
                        mSExcelInputTextIntoOLEObject["Handle"] = ExpressionConverter.ConvertO(__workflow_mSExcelInputTextIntoOLEObjecthandle);
                        mSExcelInputTextIntoOLEObjectpropCount++;
                    }

                    mSExcelInputTextIntoOLEObjectpropCount++;
                }
                else
                {
                    mSExcelInputTextIntoOLEObject["Handle"] = 0;
                    mSExcelInputTextIntoOLEObjectpropCount++;
                }

                if (__workflow_mSExcelInputTextIntoOLEObjectworkbookName != null)
                {
                    mSExcelInputTextIntoOLEObject["WorkbookName"] = ExpressionConverter.ConvertO(__workflow_mSExcelInputTextIntoOLEObjectworkbookName);
                    mSExcelInputTextIntoOLEObjectpropCount++;
                }

                if (__workflow_mSExcelInputTextIntoOLEObjectworksheetName != null)
                {
                    mSExcelInputTextIntoOLEObject["WorksheetName"] = ExpressionConverter.ConvertO(__workflow_mSExcelInputTextIntoOLEObjectworksheetName);
                    mSExcelInputTextIntoOLEObjectpropCount++;
                }

                mSExcelInputTextIntoOLEObjectpropCount++;
                mSExcelInputTextIntoOLEObject["OLEObjectName"] = ExpressionConverter.ConvertO(__workflow_mSExcelInputTextIntoOLEObjectoLEObjectName);
                if (__workflow_mSExcelInputTextIntoOLEObjecttextToInput != null)
                {
                    mSExcelInputTextIntoOLEObject["TextToInput"] = ExpressionConverter.ConvertO(__workflow_mSExcelInputTextIntoOLEObjecttextToInput);
                    mSExcelInputTextIntoOLEObjectpropCount++;
                }

                if (__workflow_mSExcelInputTextIntoOLEObjectrunInBackground != null)
                {
                    if (__workflow_mSExcelInputTextIntoOLEObjectrunInBackground != null)
                    {
                        mSExcelInputTextIntoOLEObject["RunInBackground"] = ExpressionConverter.ConvertO(__workflow_mSExcelInputTextIntoOLEObjectrunInBackground);
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
                mSExcelInputTextIntoOLEObject["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSExcelInputTextIntoOLEObjectworkflow);
                if (mSExcelInputTextIntoOLEObjectpropCount > 0)
                {
                    callPayload.Body = mSExcelInputTextIntoOLEObject;
                }

                return new ApiConnectionAction<MSExcelInputTextIntoOLEObjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelSetCellBackgroundColourResponse> MSExcelSetCellBackgroundColour(Expression<Func<string>> mSExcelSetCellBackgroundColourcellReference, Expression<Func<int>> mSExcelSetCellBackgroundColourcolourIndex, Expression<Func<string>> mSExcelSetCellBackgroundColourworkflow, Expression<Func<int>> mSExcelSetCellBackgroundColourhandle = null, Expression<Func<string>> mSExcelSetCellBackgroundColourworkbookName = null, Expression<Func<string>> mSExcelSetCellBackgroundColourworksheetName = null)
        {
            var __workflow_mSExcelSetCellBackgroundColourcellReference = mSExcelSetCellBackgroundColourcellReference == null ? null : WorkflowExpression.Compile(mSExcelSetCellBackgroundColourcellReference);
            WorkflowExpression.Validate(__workflow_mSExcelSetCellBackgroundColourcellReference, nameof(mSExcelSetCellBackgroundColourcellReference), required: true);
            var __workflow_mSExcelSetCellBackgroundColourcolourIndex = mSExcelSetCellBackgroundColourcolourIndex == null ? null : WorkflowExpression.Compile(mSExcelSetCellBackgroundColourcolourIndex);
            WorkflowExpression.Validate(__workflow_mSExcelSetCellBackgroundColourcolourIndex, nameof(mSExcelSetCellBackgroundColourcolourIndex), required: true);
            var __workflow_mSExcelSetCellBackgroundColourworkflow = mSExcelSetCellBackgroundColourworkflow == null ? null : WorkflowExpression.Compile(mSExcelSetCellBackgroundColourworkflow);
            WorkflowExpression.Validate(__workflow_mSExcelSetCellBackgroundColourworkflow, nameof(mSExcelSetCellBackgroundColourworkflow), required: true);
            var __workflow_mSExcelSetCellBackgroundColourhandle = mSExcelSetCellBackgroundColourhandle == null ? null : WorkflowExpression.Compile(mSExcelSetCellBackgroundColourhandle);
            WorkflowExpression.Validate(__workflow_mSExcelSetCellBackgroundColourhandle, nameof(mSExcelSetCellBackgroundColourhandle), required: false);
            var __workflow_mSExcelSetCellBackgroundColourworkbookName = mSExcelSetCellBackgroundColourworkbookName == null ? null : WorkflowExpression.Compile(mSExcelSetCellBackgroundColourworkbookName);
            WorkflowExpression.Validate(__workflow_mSExcelSetCellBackgroundColourworkbookName, nameof(mSExcelSetCellBackgroundColourworkbookName), required: false);
            var __workflow_mSExcelSetCellBackgroundColourworksheetName = mSExcelSetCellBackgroundColourworksheetName == null ? null : WorkflowExpression.Compile(mSExcelSetCellBackgroundColourworksheetName);
            WorkflowExpression.Validate(__workflow_mSExcelSetCellBackgroundColourworksheetName, nameof(mSExcelSetCellBackgroundColourworksheetName), required: false);
            return new DeferredBodyAction<MSExcelSetCellBackgroundColourResponse>(() =>
            {
                var apiCallPath = "/MSExcel/SetCellBackgroundColour";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSExcelSetCellBackgroundColour = new JObject();
                var mSExcelSetCellBackgroundColourpropCount = 0;
                if (__workflow_mSExcelSetCellBackgroundColourhandle != null)
                {
                    if (__workflow_mSExcelSetCellBackgroundColourhandle != null)
                    {
                        mSExcelSetCellBackgroundColour["Handle"] = ExpressionConverter.ConvertO(__workflow_mSExcelSetCellBackgroundColourhandle);
                        mSExcelSetCellBackgroundColourpropCount++;
                    }

                    mSExcelSetCellBackgroundColourpropCount++;
                }
                else
                {
                    mSExcelSetCellBackgroundColour["Handle"] = 0;
                    mSExcelSetCellBackgroundColourpropCount++;
                }

                if (__workflow_mSExcelSetCellBackgroundColourworkbookName != null)
                {
                    mSExcelSetCellBackgroundColour["WorkbookName"] = ExpressionConverter.ConvertO(__workflow_mSExcelSetCellBackgroundColourworkbookName);
                    mSExcelSetCellBackgroundColourpropCount++;
                }

                if (__workflow_mSExcelSetCellBackgroundColourworksheetName != null)
                {
                    mSExcelSetCellBackgroundColour["WorksheetName"] = ExpressionConverter.ConvertO(__workflow_mSExcelSetCellBackgroundColourworksheetName);
                    mSExcelSetCellBackgroundColourpropCount++;
                }

                mSExcelSetCellBackgroundColourpropCount++;
                mSExcelSetCellBackgroundColour["CellReference"] = ExpressionConverter.ConvertO(__workflow_mSExcelSetCellBackgroundColourcellReference);
                mSExcelSetCellBackgroundColourpropCount++;
                mSExcelSetCellBackgroundColour["ColourIndex"] = ExpressionConverter.ConvertO(__workflow_mSExcelSetCellBackgroundColourcolourIndex);
                mSExcelSetCellBackgroundColourpropCount++;
                mSExcelSetCellBackgroundColour["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSExcelSetCellBackgroundColourworkflow);
                if (mSExcelSetCellBackgroundColourpropCount > 0)
                {
                    callPayload.Body = mSExcelSetCellBackgroundColour;
                }

                return new ApiConnectionAction<MSExcelSetCellBackgroundColourResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetCellBackgroundColourResponse> MSExcelGetCellBackgroundColour(Expression<Func<string>> mSExcelGetCellBackgroundColourcellReference, Expression<Func<string>> mSExcelGetCellBackgroundColourworkflow, Expression<Func<int>> mSExcelGetCellBackgroundColourhandle = null, Expression<Func<string>> mSExcelGetCellBackgroundColourworkbookName = null, Expression<Func<string>> mSExcelGetCellBackgroundColourworksheetName = null)
        {
            var __workflow_mSExcelGetCellBackgroundColourcellReference = mSExcelGetCellBackgroundColourcellReference == null ? null : WorkflowExpression.Compile(mSExcelGetCellBackgroundColourcellReference);
            WorkflowExpression.Validate(__workflow_mSExcelGetCellBackgroundColourcellReference, nameof(mSExcelGetCellBackgroundColourcellReference), required: true);
            var __workflow_mSExcelGetCellBackgroundColourworkflow = mSExcelGetCellBackgroundColourworkflow == null ? null : WorkflowExpression.Compile(mSExcelGetCellBackgroundColourworkflow);
            WorkflowExpression.Validate(__workflow_mSExcelGetCellBackgroundColourworkflow, nameof(mSExcelGetCellBackgroundColourworkflow), required: true);
            var __workflow_mSExcelGetCellBackgroundColourhandle = mSExcelGetCellBackgroundColourhandle == null ? null : WorkflowExpression.Compile(mSExcelGetCellBackgroundColourhandle);
            WorkflowExpression.Validate(__workflow_mSExcelGetCellBackgroundColourhandle, nameof(mSExcelGetCellBackgroundColourhandle), required: false);
            var __workflow_mSExcelGetCellBackgroundColourworkbookName = mSExcelGetCellBackgroundColourworkbookName == null ? null : WorkflowExpression.Compile(mSExcelGetCellBackgroundColourworkbookName);
            WorkflowExpression.Validate(__workflow_mSExcelGetCellBackgroundColourworkbookName, nameof(mSExcelGetCellBackgroundColourworkbookName), required: false);
            var __workflow_mSExcelGetCellBackgroundColourworksheetName = mSExcelGetCellBackgroundColourworksheetName == null ? null : WorkflowExpression.Compile(mSExcelGetCellBackgroundColourworksheetName);
            WorkflowExpression.Validate(__workflow_mSExcelGetCellBackgroundColourworksheetName, nameof(mSExcelGetCellBackgroundColourworksheetName), required: false);
            return new DeferredBodyAction<MSExcelGetCellBackgroundColourResponse>(() =>
            {
                var apiCallPath = "/MSExcel/GetCellBackgroundColour";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSExcelGetCellBackgroundColour = new JObject();
                var mSExcelGetCellBackgroundColourpropCount = 0;
                if (__workflow_mSExcelGetCellBackgroundColourhandle != null)
                {
                    if (__workflow_mSExcelGetCellBackgroundColourhandle != null)
                    {
                        mSExcelGetCellBackgroundColour["Handle"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetCellBackgroundColourhandle);
                        mSExcelGetCellBackgroundColourpropCount++;
                    }

                    mSExcelGetCellBackgroundColourpropCount++;
                }
                else
                {
                    mSExcelGetCellBackgroundColour["Handle"] = 0;
                    mSExcelGetCellBackgroundColourpropCount++;
                }

                if (__workflow_mSExcelGetCellBackgroundColourworkbookName != null)
                {
                    mSExcelGetCellBackgroundColour["WorkbookName"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetCellBackgroundColourworkbookName);
                    mSExcelGetCellBackgroundColourpropCount++;
                }

                if (__workflow_mSExcelGetCellBackgroundColourworksheetName != null)
                {
                    mSExcelGetCellBackgroundColour["WorksheetName"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetCellBackgroundColourworksheetName);
                    mSExcelGetCellBackgroundColourpropCount++;
                }

                mSExcelGetCellBackgroundColourpropCount++;
                mSExcelGetCellBackgroundColour["CellReference"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetCellBackgroundColourcellReference);
                mSExcelGetCellBackgroundColourpropCount++;
                mSExcelGetCellBackgroundColour["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetCellBackgroundColourworkflow);
                if (mSExcelGetCellBackgroundColourpropCount > 0)
                {
                    callPayload.Body = mSExcelGetCellBackgroundColour;
                }

                return new ApiConnectionAction<MSExcelGetCellBackgroundColourResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetOLEObjectValueResponse> MSExcelGetOLEObjectValue(Expression<Func<string>> mSExcelGetOLEObjectValueoLEObjectName, Expression<Func<string>> mSExcelGetOLEObjectValueworkflow, Expression<Func<int>> mSExcelGetOLEObjectValuehandle = null, Expression<Func<string>> mSExcelGetOLEObjectValueworkbookName = null, Expression<Func<string>> mSExcelGetOLEObjectValueworksheetName = null)
        {
            var __workflow_mSExcelGetOLEObjectValueoLEObjectName = mSExcelGetOLEObjectValueoLEObjectName == null ? null : WorkflowExpression.Compile(mSExcelGetOLEObjectValueoLEObjectName);
            WorkflowExpression.Validate(__workflow_mSExcelGetOLEObjectValueoLEObjectName, nameof(mSExcelGetOLEObjectValueoLEObjectName), required: true);
            var __workflow_mSExcelGetOLEObjectValueworkflow = mSExcelGetOLEObjectValueworkflow == null ? null : WorkflowExpression.Compile(mSExcelGetOLEObjectValueworkflow);
            WorkflowExpression.Validate(__workflow_mSExcelGetOLEObjectValueworkflow, nameof(mSExcelGetOLEObjectValueworkflow), required: true);
            var __workflow_mSExcelGetOLEObjectValuehandle = mSExcelGetOLEObjectValuehandle == null ? null : WorkflowExpression.Compile(mSExcelGetOLEObjectValuehandle);
            WorkflowExpression.Validate(__workflow_mSExcelGetOLEObjectValuehandle, nameof(mSExcelGetOLEObjectValuehandle), required: false);
            var __workflow_mSExcelGetOLEObjectValueworkbookName = mSExcelGetOLEObjectValueworkbookName == null ? null : WorkflowExpression.Compile(mSExcelGetOLEObjectValueworkbookName);
            WorkflowExpression.Validate(__workflow_mSExcelGetOLEObjectValueworkbookName, nameof(mSExcelGetOLEObjectValueworkbookName), required: false);
            var __workflow_mSExcelGetOLEObjectValueworksheetName = mSExcelGetOLEObjectValueworksheetName == null ? null : WorkflowExpression.Compile(mSExcelGetOLEObjectValueworksheetName);
            WorkflowExpression.Validate(__workflow_mSExcelGetOLEObjectValueworksheetName, nameof(mSExcelGetOLEObjectValueworksheetName), required: false);
            return new DeferredBodyAction<MSExcelGetOLEObjectValueResponse>(() =>
            {
                var apiCallPath = "/MSExcel/GetOLEObjectValue";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSExcelGetOLEObjectValue = new JObject();
                var mSExcelGetOLEObjectValuepropCount = 0;
                if (__workflow_mSExcelGetOLEObjectValuehandle != null)
                {
                    if (__workflow_mSExcelGetOLEObjectValuehandle != null)
                    {
                        mSExcelGetOLEObjectValue["Handle"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetOLEObjectValuehandle);
                        mSExcelGetOLEObjectValuepropCount++;
                    }

                    mSExcelGetOLEObjectValuepropCount++;
                }
                else
                {
                    mSExcelGetOLEObjectValue["Handle"] = 0;
                    mSExcelGetOLEObjectValuepropCount++;
                }

                if (__workflow_mSExcelGetOLEObjectValueworkbookName != null)
                {
                    mSExcelGetOLEObjectValue["WorkbookName"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetOLEObjectValueworkbookName);
                    mSExcelGetOLEObjectValuepropCount++;
                }

                if (__workflow_mSExcelGetOLEObjectValueworksheetName != null)
                {
                    mSExcelGetOLEObjectValue["WorksheetName"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetOLEObjectValueworksheetName);
                    mSExcelGetOLEObjectValuepropCount++;
                }

                mSExcelGetOLEObjectValuepropCount++;
                mSExcelGetOLEObjectValue["OLEObjectName"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetOLEObjectValueoLEObjectName);
                mSExcelGetOLEObjectValuepropCount++;
                mSExcelGetOLEObjectValue["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetOLEObjectValueworkflow);
                if (mSExcelGetOLEObjectValuepropCount > 0)
                {
                    callPayload.Body = mSExcelGetOLEObjectValue;
                }

                return new ApiConnectionAction<MSExcelGetOLEObjectValueResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelDoesOLEObjectExistResponse> MSExcelDoesOLEObjectExist(Expression<Func<string>> mSExcelDoesOLEObjectExistoLEObjectName, Expression<Func<string>> mSExcelDoesOLEObjectExistworkflow, Expression<Func<int>> mSExcelDoesOLEObjectExisthandle = null, Expression<Func<string>> mSExcelDoesOLEObjectExistworkbookName = null, Expression<Func<string>> mSExcelDoesOLEObjectExistworksheetName = null)
        {
            var __workflow_mSExcelDoesOLEObjectExistoLEObjectName = mSExcelDoesOLEObjectExistoLEObjectName == null ? null : WorkflowExpression.Compile(mSExcelDoesOLEObjectExistoLEObjectName);
            WorkflowExpression.Validate(__workflow_mSExcelDoesOLEObjectExistoLEObjectName, nameof(mSExcelDoesOLEObjectExistoLEObjectName), required: true);
            var __workflow_mSExcelDoesOLEObjectExistworkflow = mSExcelDoesOLEObjectExistworkflow == null ? null : WorkflowExpression.Compile(mSExcelDoesOLEObjectExistworkflow);
            WorkflowExpression.Validate(__workflow_mSExcelDoesOLEObjectExistworkflow, nameof(mSExcelDoesOLEObjectExistworkflow), required: true);
            var __workflow_mSExcelDoesOLEObjectExisthandle = mSExcelDoesOLEObjectExisthandle == null ? null : WorkflowExpression.Compile(mSExcelDoesOLEObjectExisthandle);
            WorkflowExpression.Validate(__workflow_mSExcelDoesOLEObjectExisthandle, nameof(mSExcelDoesOLEObjectExisthandle), required: false);
            var __workflow_mSExcelDoesOLEObjectExistworkbookName = mSExcelDoesOLEObjectExistworkbookName == null ? null : WorkflowExpression.Compile(mSExcelDoesOLEObjectExistworkbookName);
            WorkflowExpression.Validate(__workflow_mSExcelDoesOLEObjectExistworkbookName, nameof(mSExcelDoesOLEObjectExistworkbookName), required: false);
            var __workflow_mSExcelDoesOLEObjectExistworksheetName = mSExcelDoesOLEObjectExistworksheetName == null ? null : WorkflowExpression.Compile(mSExcelDoesOLEObjectExistworksheetName);
            WorkflowExpression.Validate(__workflow_mSExcelDoesOLEObjectExistworksheetName, nameof(mSExcelDoesOLEObjectExistworksheetName), required: false);
            return new DeferredBodyAction<MSExcelDoesOLEObjectExistResponse>(() =>
            {
                var apiCallPath = "/MSExcel/DoesOLEObjectExist";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSExcelDoesOLEObjectExist = new JObject();
                var mSExcelDoesOLEObjectExistpropCount = 0;
                if (__workflow_mSExcelDoesOLEObjectExisthandle != null)
                {
                    if (__workflow_mSExcelDoesOLEObjectExisthandle != null)
                    {
                        mSExcelDoesOLEObjectExist["Handle"] = ExpressionConverter.ConvertO(__workflow_mSExcelDoesOLEObjectExisthandle);
                        mSExcelDoesOLEObjectExistpropCount++;
                    }

                    mSExcelDoesOLEObjectExistpropCount++;
                }
                else
                {
                    mSExcelDoesOLEObjectExist["Handle"] = 0;
                    mSExcelDoesOLEObjectExistpropCount++;
                }

                if (__workflow_mSExcelDoesOLEObjectExistworkbookName != null)
                {
                    mSExcelDoesOLEObjectExist["WorkbookName"] = ExpressionConverter.ConvertO(__workflow_mSExcelDoesOLEObjectExistworkbookName);
                    mSExcelDoesOLEObjectExistpropCount++;
                }

                if (__workflow_mSExcelDoesOLEObjectExistworksheetName != null)
                {
                    mSExcelDoesOLEObjectExist["WorksheetName"] = ExpressionConverter.ConvertO(__workflow_mSExcelDoesOLEObjectExistworksheetName);
                    mSExcelDoesOLEObjectExistpropCount++;
                }

                mSExcelDoesOLEObjectExistpropCount++;
                mSExcelDoesOLEObjectExist["OLEObjectName"] = ExpressionConverter.ConvertO(__workflow_mSExcelDoesOLEObjectExistoLEObjectName);
                mSExcelDoesOLEObjectExistpropCount++;
                mSExcelDoesOLEObjectExist["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSExcelDoesOLEObjectExistworkflow);
                if (mSExcelDoesOLEObjectExistpropCount > 0)
                {
                    callPayload.Body = mSExcelDoesOLEObjectExist;
                }

                return new ApiConnectionAction<MSExcelDoesOLEObjectExistResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelPressOLEObjectResponse> MSExcelPressOLEObject(Expression<Func<string>> mSExcelPressOLEObjectoLEObjectName, Expression<Func<string>> mSExcelPressOLEObjectworkflow, Expression<Func<int>> mSExcelPressOLEObjecthandle = null, Expression<Func<string>> mSExcelPressOLEObjectworkbookName = null, Expression<Func<string>> mSExcelPressOLEObjectworksheetName = null, Expression<Func<bool>> mSExcelPressOLEObjectrunInBackground = null)
        {
            var __workflow_mSExcelPressOLEObjectoLEObjectName = mSExcelPressOLEObjectoLEObjectName == null ? null : WorkflowExpression.Compile(mSExcelPressOLEObjectoLEObjectName);
            WorkflowExpression.Validate(__workflow_mSExcelPressOLEObjectoLEObjectName, nameof(mSExcelPressOLEObjectoLEObjectName), required: true);
            var __workflow_mSExcelPressOLEObjectworkflow = mSExcelPressOLEObjectworkflow == null ? null : WorkflowExpression.Compile(mSExcelPressOLEObjectworkflow);
            WorkflowExpression.Validate(__workflow_mSExcelPressOLEObjectworkflow, nameof(mSExcelPressOLEObjectworkflow), required: true);
            var __workflow_mSExcelPressOLEObjecthandle = mSExcelPressOLEObjecthandle == null ? null : WorkflowExpression.Compile(mSExcelPressOLEObjecthandle);
            WorkflowExpression.Validate(__workflow_mSExcelPressOLEObjecthandle, nameof(mSExcelPressOLEObjecthandle), required: false);
            var __workflow_mSExcelPressOLEObjectworkbookName = mSExcelPressOLEObjectworkbookName == null ? null : WorkflowExpression.Compile(mSExcelPressOLEObjectworkbookName);
            WorkflowExpression.Validate(__workflow_mSExcelPressOLEObjectworkbookName, nameof(mSExcelPressOLEObjectworkbookName), required: false);
            var __workflow_mSExcelPressOLEObjectworksheetName = mSExcelPressOLEObjectworksheetName == null ? null : WorkflowExpression.Compile(mSExcelPressOLEObjectworksheetName);
            WorkflowExpression.Validate(__workflow_mSExcelPressOLEObjectworksheetName, nameof(mSExcelPressOLEObjectworksheetName), required: false);
            var __workflow_mSExcelPressOLEObjectrunInBackground = mSExcelPressOLEObjectrunInBackground == null ? null : WorkflowExpression.Compile(mSExcelPressOLEObjectrunInBackground);
            WorkflowExpression.Validate(__workflow_mSExcelPressOLEObjectrunInBackground, nameof(mSExcelPressOLEObjectrunInBackground), required: false);
            return new DeferredBodyAction<MSExcelPressOLEObjectResponse>(() =>
            {
                var apiCallPath = "/MSExcel/PressOLEObject";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSExcelPressOLEObject = new JObject();
                var mSExcelPressOLEObjectpropCount = 0;
                if (__workflow_mSExcelPressOLEObjecthandle != null)
                {
                    if (__workflow_mSExcelPressOLEObjecthandle != null)
                    {
                        mSExcelPressOLEObject["Handle"] = ExpressionConverter.ConvertO(__workflow_mSExcelPressOLEObjecthandle);
                        mSExcelPressOLEObjectpropCount++;
                    }

                    mSExcelPressOLEObjectpropCount++;
                }
                else
                {
                    mSExcelPressOLEObject["Handle"] = 0;
                    mSExcelPressOLEObjectpropCount++;
                }

                if (__workflow_mSExcelPressOLEObjectworkbookName != null)
                {
                    mSExcelPressOLEObject["WorkbookName"] = ExpressionConverter.ConvertO(__workflow_mSExcelPressOLEObjectworkbookName);
                    mSExcelPressOLEObjectpropCount++;
                }

                if (__workflow_mSExcelPressOLEObjectworksheetName != null)
                {
                    mSExcelPressOLEObject["WorksheetName"] = ExpressionConverter.ConvertO(__workflow_mSExcelPressOLEObjectworksheetName);
                    mSExcelPressOLEObjectpropCount++;
                }

                mSExcelPressOLEObjectpropCount++;
                mSExcelPressOLEObject["OLEObjectName"] = ExpressionConverter.ConvertO(__workflow_mSExcelPressOLEObjectoLEObjectName);
                if (__workflow_mSExcelPressOLEObjectrunInBackground != null)
                {
                    if (__workflow_mSExcelPressOLEObjectrunInBackground != null)
                    {
                        mSExcelPressOLEObject["RunInBackground"] = ExpressionConverter.ConvertO(__workflow_mSExcelPressOLEObjectrunInBackground);
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
                mSExcelPressOLEObject["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSExcelPressOLEObjectworkflow);
                if (mSExcelPressOLEObjectpropCount > 0)
                {
                    callPayload.Body = mSExcelPressOLEObject;
                }

                return new ApiConnectionAction<MSExcelPressOLEObjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelSetWorksheetSensitivityLabelResponse> MSExcelSetWorksheetSensitivityLabel(Expression<Func<mSExcelSetWorksheetSensitivityLabelassignmentMethodInput>> mSExcelSetWorksheetSensitivityLabelassignmentMethod, Expression<Func<string>> mSExcelSetWorksheetSensitivityLabellabelId, Expression<Func<string>> mSExcelSetWorksheetSensitivityLabelworkflow, Expression<Func<int>> mSExcelSetWorksheetSensitivityLabelhandle = null, Expression<Func<string>> mSExcelSetWorksheetSensitivityLabelworkbookName = null, Expression<Func<string>> mSExcelSetWorksheetSensitivityLabellabelName = null, Expression<Func<string>> mSExcelSetWorksheetSensitivityLabelsiteId = null, Expression<Func<string>> mSExcelSetWorksheetSensitivityLabeljustification = null)
        {
            var __workflow_mSExcelSetWorksheetSensitivityLabelassignmentMethod = mSExcelSetWorksheetSensitivityLabelassignmentMethod == null ? null : WorkflowExpression.Compile(mSExcelSetWorksheetSensitivityLabelassignmentMethod);
            WorkflowExpression.Validate(__workflow_mSExcelSetWorksheetSensitivityLabelassignmentMethod, nameof(mSExcelSetWorksheetSensitivityLabelassignmentMethod), required: true);
            var __workflow_mSExcelSetWorksheetSensitivityLabellabelId = mSExcelSetWorksheetSensitivityLabellabelId == null ? null : WorkflowExpression.Compile(mSExcelSetWorksheetSensitivityLabellabelId);
            WorkflowExpression.Validate(__workflow_mSExcelSetWorksheetSensitivityLabellabelId, nameof(mSExcelSetWorksheetSensitivityLabellabelId), required: true);
            var __workflow_mSExcelSetWorksheetSensitivityLabelworkflow = mSExcelSetWorksheetSensitivityLabelworkflow == null ? null : WorkflowExpression.Compile(mSExcelSetWorksheetSensitivityLabelworkflow);
            WorkflowExpression.Validate(__workflow_mSExcelSetWorksheetSensitivityLabelworkflow, nameof(mSExcelSetWorksheetSensitivityLabelworkflow), required: true);
            var __workflow_mSExcelSetWorksheetSensitivityLabelhandle = mSExcelSetWorksheetSensitivityLabelhandle == null ? null : WorkflowExpression.Compile(mSExcelSetWorksheetSensitivityLabelhandle);
            WorkflowExpression.Validate(__workflow_mSExcelSetWorksheetSensitivityLabelhandle, nameof(mSExcelSetWorksheetSensitivityLabelhandle), required: false);
            var __workflow_mSExcelSetWorksheetSensitivityLabelworkbookName = mSExcelSetWorksheetSensitivityLabelworkbookName == null ? null : WorkflowExpression.Compile(mSExcelSetWorksheetSensitivityLabelworkbookName);
            WorkflowExpression.Validate(__workflow_mSExcelSetWorksheetSensitivityLabelworkbookName, nameof(mSExcelSetWorksheetSensitivityLabelworkbookName), required: false);
            var __workflow_mSExcelSetWorksheetSensitivityLabellabelName = mSExcelSetWorksheetSensitivityLabellabelName == null ? null : WorkflowExpression.Compile(mSExcelSetWorksheetSensitivityLabellabelName);
            WorkflowExpression.Validate(__workflow_mSExcelSetWorksheetSensitivityLabellabelName, nameof(mSExcelSetWorksheetSensitivityLabellabelName), required: false);
            var __workflow_mSExcelSetWorksheetSensitivityLabelsiteId = mSExcelSetWorksheetSensitivityLabelsiteId == null ? null : WorkflowExpression.Compile(mSExcelSetWorksheetSensitivityLabelsiteId);
            WorkflowExpression.Validate(__workflow_mSExcelSetWorksheetSensitivityLabelsiteId, nameof(mSExcelSetWorksheetSensitivityLabelsiteId), required: false);
            var __workflow_mSExcelSetWorksheetSensitivityLabeljustification = mSExcelSetWorksheetSensitivityLabeljustification == null ? null : WorkflowExpression.Compile(mSExcelSetWorksheetSensitivityLabeljustification);
            WorkflowExpression.Validate(__workflow_mSExcelSetWorksheetSensitivityLabeljustification, nameof(mSExcelSetWorksheetSensitivityLabeljustification), required: false);
            return new DeferredBodyAction<MSExcelSetWorksheetSensitivityLabelResponse>(() =>
            {
                var apiCallPath = "/MSExcel/SetWorksheetSensitivityLabel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSExcelSetWorksheetSensitivityLabel = new JObject();
                var mSExcelSetWorksheetSensitivityLabelpropCount = 0;
                if (__workflow_mSExcelSetWorksheetSensitivityLabelhandle != null)
                {
                    if (__workflow_mSExcelSetWorksheetSensitivityLabelhandle != null)
                    {
                        mSExcelSetWorksheetSensitivityLabel["Handle"] = ExpressionConverter.ConvertO(__workflow_mSExcelSetWorksheetSensitivityLabelhandle);
                        mSExcelSetWorksheetSensitivityLabelpropCount++;
                    }

                    mSExcelSetWorksheetSensitivityLabelpropCount++;
                }
                else
                {
                    mSExcelSetWorksheetSensitivityLabel["Handle"] = 0;
                    mSExcelSetWorksheetSensitivityLabelpropCount++;
                }

                if (__workflow_mSExcelSetWorksheetSensitivityLabelworkbookName != null)
                {
                    mSExcelSetWorksheetSensitivityLabel["WorkbookName"] = ExpressionConverter.ConvertO(__workflow_mSExcelSetWorksheetSensitivityLabelworkbookName);
                    mSExcelSetWorksheetSensitivityLabelpropCount++;
                }

                mSExcelSetWorksheetSensitivityLabelpropCount++;
                mSExcelSetWorksheetSensitivityLabel["AssignmentMethod"] = ExpressionConverter.ConvertO(__workflow_mSExcelSetWorksheetSensitivityLabelassignmentMethod);
                mSExcelSetWorksheetSensitivityLabelpropCount++;
                mSExcelSetWorksheetSensitivityLabel["LabelId"] = ExpressionConverter.ConvertO(__workflow_mSExcelSetWorksheetSensitivityLabellabelId);
                if (__workflow_mSExcelSetWorksheetSensitivityLabellabelName != null)
                {
                    mSExcelSetWorksheetSensitivityLabel["LabelName"] = ExpressionConverter.ConvertO(__workflow_mSExcelSetWorksheetSensitivityLabellabelName);
                    mSExcelSetWorksheetSensitivityLabelpropCount++;
                }

                if (__workflow_mSExcelSetWorksheetSensitivityLabelsiteId != null)
                {
                    mSExcelSetWorksheetSensitivityLabel["SiteId"] = ExpressionConverter.ConvertO(__workflow_mSExcelSetWorksheetSensitivityLabelsiteId);
                    mSExcelSetWorksheetSensitivityLabelpropCount++;
                }

                if (__workflow_mSExcelSetWorksheetSensitivityLabeljustification != null)
                {
                    mSExcelSetWorksheetSensitivityLabel["Justification"] = ExpressionConverter.ConvertO(__workflow_mSExcelSetWorksheetSensitivityLabeljustification);
                    mSExcelSetWorksheetSensitivityLabelpropCount++;
                }

                mSExcelSetWorksheetSensitivityLabelpropCount++;
                mSExcelSetWorksheetSensitivityLabel["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSExcelSetWorksheetSensitivityLabelworkflow);
                if (mSExcelSetWorksheetSensitivityLabelpropCount > 0)
                {
                    callPayload.Body = mSExcelSetWorksheetSensitivityLabel;
                }

                return new ApiConnectionAction<MSExcelSetWorksheetSensitivityLabelResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetWorksheetSensitivityLabelResponse> MSExcelGetWorksheetSensitivityLabel(Expression<Func<string>> mSExcelGetWorksheetSensitivityLabelworkflow, Expression<Func<int>> mSExcelGetWorksheetSensitivityLabelhandle = null, Expression<Func<string>> mSExcelGetWorksheetSensitivityLabelworkbookName = null)
        {
            var __workflow_mSExcelGetWorksheetSensitivityLabelworkflow = mSExcelGetWorksheetSensitivityLabelworkflow == null ? null : WorkflowExpression.Compile(mSExcelGetWorksheetSensitivityLabelworkflow);
            WorkflowExpression.Validate(__workflow_mSExcelGetWorksheetSensitivityLabelworkflow, nameof(mSExcelGetWorksheetSensitivityLabelworkflow), required: true);
            var __workflow_mSExcelGetWorksheetSensitivityLabelhandle = mSExcelGetWorksheetSensitivityLabelhandle == null ? null : WorkflowExpression.Compile(mSExcelGetWorksheetSensitivityLabelhandle);
            WorkflowExpression.Validate(__workflow_mSExcelGetWorksheetSensitivityLabelhandle, nameof(mSExcelGetWorksheetSensitivityLabelhandle), required: false);
            var __workflow_mSExcelGetWorksheetSensitivityLabelworkbookName = mSExcelGetWorksheetSensitivityLabelworkbookName == null ? null : WorkflowExpression.Compile(mSExcelGetWorksheetSensitivityLabelworkbookName);
            WorkflowExpression.Validate(__workflow_mSExcelGetWorksheetSensitivityLabelworkbookName, nameof(mSExcelGetWorksheetSensitivityLabelworkbookName), required: false);
            return new DeferredBodyAction<MSExcelGetWorksheetSensitivityLabelResponse>(() =>
            {
                var apiCallPath = "/MSExcel/GetWorksheetSensitivityLabel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSExcelGetWorksheetSensitivityLabel = new JObject();
                var mSExcelGetWorksheetSensitivityLabelpropCount = 0;
                if (__workflow_mSExcelGetWorksheetSensitivityLabelhandle != null)
                {
                    if (__workflow_mSExcelGetWorksheetSensitivityLabelhandle != null)
                    {
                        mSExcelGetWorksheetSensitivityLabel["Handle"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetWorksheetSensitivityLabelhandle);
                        mSExcelGetWorksheetSensitivityLabelpropCount++;
                    }

                    mSExcelGetWorksheetSensitivityLabelpropCount++;
                }
                else
                {
                    mSExcelGetWorksheetSensitivityLabel["Handle"] = 0;
                    mSExcelGetWorksheetSensitivityLabelpropCount++;
                }

                if (__workflow_mSExcelGetWorksheetSensitivityLabelworkbookName != null)
                {
                    mSExcelGetWorksheetSensitivityLabel["WorkbookName"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetWorksheetSensitivityLabelworkbookName);
                    mSExcelGetWorksheetSensitivityLabelpropCount++;
                }

                mSExcelGetWorksheetSensitivityLabelpropCount++;
                mSExcelGetWorksheetSensitivityLabel["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSExcelGetWorksheetSensitivityLabelworkflow);
                if (mSExcelGetWorksheetSensitivityLabelpropCount > 0)
                {
                    callPayload.Body = mSExcelGetWorksheetSensitivityLabel;
                }

                return new ApiConnectionAction<MSExcelGetWorksheetSensitivityLabelResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelWriteArrayResponse> MSExcelWriteArray(Expression<Func<string>> mSExcelWriteArraycellReference, Expression<Func<string>> mSExcelWriteArrayarrayToWriteJSON, Expression<Func<mSExcelWriteArraydirectionInput>> mSExcelWriteArraydirection, Expression<Func<string>> mSExcelWriteArrayworkflow, Expression<Func<int>> mSExcelWriteArrayhandle = null, Expression<Func<string>> mSExcelWriteArrayworkbookName = null, Expression<Func<string>> mSExcelWriteArrayworksheetName = null)
        {
            var __workflow_mSExcelWriteArraycellReference = mSExcelWriteArraycellReference == null ? null : WorkflowExpression.Compile(mSExcelWriteArraycellReference);
            WorkflowExpression.Validate(__workflow_mSExcelWriteArraycellReference, nameof(mSExcelWriteArraycellReference), required: true);
            var __workflow_mSExcelWriteArrayarrayToWriteJSON = mSExcelWriteArrayarrayToWriteJSON == null ? null : WorkflowExpression.Compile(mSExcelWriteArrayarrayToWriteJSON);
            WorkflowExpression.Validate(__workflow_mSExcelWriteArrayarrayToWriteJSON, nameof(mSExcelWriteArrayarrayToWriteJSON), required: true);
            var __workflow_mSExcelWriteArraydirection = mSExcelWriteArraydirection == null ? null : WorkflowExpression.Compile(mSExcelWriteArraydirection);
            WorkflowExpression.Validate(__workflow_mSExcelWriteArraydirection, nameof(mSExcelWriteArraydirection), required: true);
            var __workflow_mSExcelWriteArrayworkflow = mSExcelWriteArrayworkflow == null ? null : WorkflowExpression.Compile(mSExcelWriteArrayworkflow);
            WorkflowExpression.Validate(__workflow_mSExcelWriteArrayworkflow, nameof(mSExcelWriteArrayworkflow), required: true);
            var __workflow_mSExcelWriteArrayhandle = mSExcelWriteArrayhandle == null ? null : WorkflowExpression.Compile(mSExcelWriteArrayhandle);
            WorkflowExpression.Validate(__workflow_mSExcelWriteArrayhandle, nameof(mSExcelWriteArrayhandle), required: false);
            var __workflow_mSExcelWriteArrayworkbookName = mSExcelWriteArrayworkbookName == null ? null : WorkflowExpression.Compile(mSExcelWriteArrayworkbookName);
            WorkflowExpression.Validate(__workflow_mSExcelWriteArrayworkbookName, nameof(mSExcelWriteArrayworkbookName), required: false);
            var __workflow_mSExcelWriteArrayworksheetName = mSExcelWriteArrayworksheetName == null ? null : WorkflowExpression.Compile(mSExcelWriteArrayworksheetName);
            WorkflowExpression.Validate(__workflow_mSExcelWriteArrayworksheetName, nameof(mSExcelWriteArrayworksheetName), required: false);
            return new DeferredBodyAction<MSExcelWriteArrayResponse>(() =>
            {
                var apiCallPath = "/MSExcel/WriteArray";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSExcelWriteArray = new JObject();
                var mSExcelWriteArraypropCount = 0;
                if (__workflow_mSExcelWriteArrayhandle != null)
                {
                    if (__workflow_mSExcelWriteArrayhandle != null)
                    {
                        mSExcelWriteArray["Handle"] = ExpressionConverter.ConvertO(__workflow_mSExcelWriteArrayhandle);
                        mSExcelWriteArraypropCount++;
                    }

                    mSExcelWriteArraypropCount++;
                }
                else
                {
                    mSExcelWriteArray["Handle"] = 0;
                    mSExcelWriteArraypropCount++;
                }

                if (__workflow_mSExcelWriteArrayworkbookName != null)
                {
                    mSExcelWriteArray["WorkbookName"] = ExpressionConverter.ConvertO(__workflow_mSExcelWriteArrayworkbookName);
                    mSExcelWriteArraypropCount++;
                }

                if (__workflow_mSExcelWriteArrayworksheetName != null)
                {
                    mSExcelWriteArray["WorksheetName"] = ExpressionConverter.ConvertO(__workflow_mSExcelWriteArrayworksheetName);
                    mSExcelWriteArraypropCount++;
                }

                mSExcelWriteArraypropCount++;
                mSExcelWriteArray["CellReference"] = ExpressionConverter.ConvertO(__workflow_mSExcelWriteArraycellReference);
                mSExcelWriteArraypropCount++;
                mSExcelWriteArray["ArrayToWriteJSON"] = ExpressionConverter.ConvertO(__workflow_mSExcelWriteArrayarrayToWriteJSON);
                mSExcelWriteArraypropCount++;
                mSExcelWriteArray["Direction"] = ExpressionConverter.ConvertO(__workflow_mSExcelWriteArraydirection);
                mSExcelWriteArraypropCount++;
                mSExcelWriteArray["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSExcelWriteArrayworkflow);
                if (mSExcelWriteArraypropCount > 0)
                {
                    callPayload.Body = mSExcelWriteArray;
                }

                return new ApiConnectionAction<MSExcelWriteArrayResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookCreateInstanceResponse> MSOutlookCreateInstance(Expression<Func<string>> mSOutlookCreateInstanceworkflow, Expression<Func<string>> mSOutlookCreateInstanceprofileName = null, Expression<Func<bool>> mSOutlookCreateInstanceshowOutlook = null)
        {
            var __workflow_mSOutlookCreateInstanceworkflow = mSOutlookCreateInstanceworkflow == null ? null : WorkflowExpression.Compile(mSOutlookCreateInstanceworkflow);
            WorkflowExpression.Validate(__workflow_mSOutlookCreateInstanceworkflow, nameof(mSOutlookCreateInstanceworkflow), required: true);
            var __workflow_mSOutlookCreateInstanceprofileName = mSOutlookCreateInstanceprofileName == null ? null : WorkflowExpression.Compile(mSOutlookCreateInstanceprofileName);
            WorkflowExpression.Validate(__workflow_mSOutlookCreateInstanceprofileName, nameof(mSOutlookCreateInstanceprofileName), required: false);
            var __workflow_mSOutlookCreateInstanceshowOutlook = mSOutlookCreateInstanceshowOutlook == null ? null : WorkflowExpression.Compile(mSOutlookCreateInstanceshowOutlook);
            WorkflowExpression.Validate(__workflow_mSOutlookCreateInstanceshowOutlook, nameof(mSOutlookCreateInstanceshowOutlook), required: false);
            return new DeferredBodyAction<MSOutlookCreateInstanceResponse>(() =>
            {
                var apiCallPath = "/MSOutlook/CreateInstance";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSOutlookCreateInstance = new JObject();
                var mSOutlookCreateInstancepropCount = 0;
                if (__workflow_mSOutlookCreateInstanceprofileName != null)
                {
                    mSOutlookCreateInstance["ProfileName"] = ExpressionConverter.ConvertO(__workflow_mSOutlookCreateInstanceprofileName);
                    mSOutlookCreateInstancepropCount++;
                }

                if (__workflow_mSOutlookCreateInstanceshowOutlook != null)
                {
                    if (__workflow_mSOutlookCreateInstanceshowOutlook != null)
                    {
                        mSOutlookCreateInstance["ShowOutlook"] = ExpressionConverter.ConvertO(__workflow_mSOutlookCreateInstanceshowOutlook);
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
                mSOutlookCreateInstance["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSOutlookCreateInstanceworkflow);
                if (mSOutlookCreateInstancepropCount > 0)
                {
                    callPayload.Body = mSOutlookCreateInstance;
                }

                return new ApiConnectionAction<MSOutlookCreateInstanceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSOutlookCloseInstance(Expression<Func<string>> mSOutlookCloseInstanceworkflow, Expression<Func<int>> mSOutlookCloseInstancesecondsToWaitForProcessToClose = null)
        {
            var __workflow_mSOutlookCloseInstanceworkflow = mSOutlookCloseInstanceworkflow == null ? null : WorkflowExpression.Compile(mSOutlookCloseInstanceworkflow);
            WorkflowExpression.Validate(__workflow_mSOutlookCloseInstanceworkflow, nameof(mSOutlookCloseInstanceworkflow), required: true);
            var __workflow_mSOutlookCloseInstancesecondsToWaitForProcessToClose = mSOutlookCloseInstancesecondsToWaitForProcessToClose == null ? null : WorkflowExpression.Compile(mSOutlookCloseInstancesecondsToWaitForProcessToClose);
            WorkflowExpression.Validate(__workflow_mSOutlookCloseInstancesecondsToWaitForProcessToClose, nameof(mSOutlookCloseInstancesecondsToWaitForProcessToClose), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/MSOutlook/CloseInstance";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSOutlookCloseInstance = new JObject();
                var mSOutlookCloseInstancepropCount = 0;
                if (__workflow_mSOutlookCloseInstancesecondsToWaitForProcessToClose != null)
                {
                    if (__workflow_mSOutlookCloseInstancesecondsToWaitForProcessToClose != null)
                    {
                        mSOutlookCloseInstance["SecondsToWaitForProcessToClose"] = ExpressionConverter.ConvertO(__workflow_mSOutlookCloseInstancesecondsToWaitForProcessToClose);
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
                mSOutlookCloseInstance["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSOutlookCloseInstanceworkflow);
                if (mSOutlookCloseInstancepropCount > 0)
                {
                    callPayload.Body = mSOutlookCloseInstance;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSOutlookCloseInstanceUsingWindow(Expression<Func<string>> mSOutlookCloseInstanceUsingWindowworkflow, Expression<Func<bool>> mSOutlookCloseInstanceUsingWindowuseNativeWindow = null, Expression<Func<bool>> mSOutlookCloseInstanceUsingWindowuseUIA = null, Expression<Func<int>> mSOutlookCloseInstanceUsingWindowsecondsToWaitForProcessToClose = null)
        {
            var __workflow_mSOutlookCloseInstanceUsingWindowworkflow = mSOutlookCloseInstanceUsingWindowworkflow == null ? null : WorkflowExpression.Compile(mSOutlookCloseInstanceUsingWindowworkflow);
            WorkflowExpression.Validate(__workflow_mSOutlookCloseInstanceUsingWindowworkflow, nameof(mSOutlookCloseInstanceUsingWindowworkflow), required: true);
            var __workflow_mSOutlookCloseInstanceUsingWindowuseNativeWindow = mSOutlookCloseInstanceUsingWindowuseNativeWindow == null ? null : WorkflowExpression.Compile(mSOutlookCloseInstanceUsingWindowuseNativeWindow);
            WorkflowExpression.Validate(__workflow_mSOutlookCloseInstanceUsingWindowuseNativeWindow, nameof(mSOutlookCloseInstanceUsingWindowuseNativeWindow), required: false);
            var __workflow_mSOutlookCloseInstanceUsingWindowuseUIA = mSOutlookCloseInstanceUsingWindowuseUIA == null ? null : WorkflowExpression.Compile(mSOutlookCloseInstanceUsingWindowuseUIA);
            WorkflowExpression.Validate(__workflow_mSOutlookCloseInstanceUsingWindowuseUIA, nameof(mSOutlookCloseInstanceUsingWindowuseUIA), required: false);
            var __workflow_mSOutlookCloseInstanceUsingWindowsecondsToWaitForProcessToClose = mSOutlookCloseInstanceUsingWindowsecondsToWaitForProcessToClose == null ? null : WorkflowExpression.Compile(mSOutlookCloseInstanceUsingWindowsecondsToWaitForProcessToClose);
            WorkflowExpression.Validate(__workflow_mSOutlookCloseInstanceUsingWindowsecondsToWaitForProcessToClose, nameof(mSOutlookCloseInstanceUsingWindowsecondsToWaitForProcessToClose), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/MSOutlook/CloseInstanceUsingWindow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSOutlookCloseInstanceUsingWindow = new JObject();
                var mSOutlookCloseInstanceUsingWindowpropCount = 0;
                if (__workflow_mSOutlookCloseInstanceUsingWindowuseNativeWindow != null)
                {
                    if (__workflow_mSOutlookCloseInstanceUsingWindowuseNativeWindow != null)
                    {
                        mSOutlookCloseInstanceUsingWindow["UseNativeWindow"] = ExpressionConverter.ConvertO(__workflow_mSOutlookCloseInstanceUsingWindowuseNativeWindow);
                        mSOutlookCloseInstanceUsingWindowpropCount++;
                    }

                    mSOutlookCloseInstanceUsingWindowpropCount++;
                }
                else
                {
                    mSOutlookCloseInstanceUsingWindow["UseNativeWindow"] = true;
                    mSOutlookCloseInstanceUsingWindowpropCount++;
                }

                if (__workflow_mSOutlookCloseInstanceUsingWindowuseUIA != null)
                {
                    if (__workflow_mSOutlookCloseInstanceUsingWindowuseUIA != null)
                    {
                        mSOutlookCloseInstanceUsingWindow["UseUIA"] = ExpressionConverter.ConvertO(__workflow_mSOutlookCloseInstanceUsingWindowuseUIA);
                        mSOutlookCloseInstanceUsingWindowpropCount++;
                    }

                    mSOutlookCloseInstanceUsingWindowpropCount++;
                }
                else
                {
                    mSOutlookCloseInstanceUsingWindow["UseUIA"] = true;
                    mSOutlookCloseInstanceUsingWindowpropCount++;
                }

                if (__workflow_mSOutlookCloseInstanceUsingWindowsecondsToWaitForProcessToClose != null)
                {
                    if (__workflow_mSOutlookCloseInstanceUsingWindowsecondsToWaitForProcessToClose != null)
                    {
                        mSOutlookCloseInstanceUsingWindow["SecondsToWaitForProcessToClose"] = ExpressionConverter.ConvertO(__workflow_mSOutlookCloseInstanceUsingWindowsecondsToWaitForProcessToClose);
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
                mSOutlookCloseInstanceUsingWindow["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSOutlookCloseInstanceUsingWindowworkflow);
                if (mSOutlookCloseInstanceUsingWindowpropCount > 0)
                {
                    callPayload.Body = mSOutlookCloseInstanceUsingWindow;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookAttachToExistingInstanceResponse> MSOutlookAttachToExistingInstance(Expression<Func<string>> mSOutlookAttachToExistingInstanceworkflow, Expression<Func<bool>> mSOutlookAttachToExistingInstancetoggleWindow = null, Expression<Func<bool>> mSOutlookAttachToExistingInstancetoggleUsesGlobalLeftMouseClickAgent = null, Expression<Func<double>> mSOutlookAttachToExistingInstancetoggleDelay = null)
        {
            var __workflow_mSOutlookAttachToExistingInstanceworkflow = mSOutlookAttachToExistingInstanceworkflow == null ? null : WorkflowExpression.Compile(mSOutlookAttachToExistingInstanceworkflow);
            WorkflowExpression.Validate(__workflow_mSOutlookAttachToExistingInstanceworkflow, nameof(mSOutlookAttachToExistingInstanceworkflow), required: true);
            var __workflow_mSOutlookAttachToExistingInstancetoggleWindow = mSOutlookAttachToExistingInstancetoggleWindow == null ? null : WorkflowExpression.Compile(mSOutlookAttachToExistingInstancetoggleWindow);
            WorkflowExpression.Validate(__workflow_mSOutlookAttachToExistingInstancetoggleWindow, nameof(mSOutlookAttachToExistingInstancetoggleWindow), required: false);
            var __workflow_mSOutlookAttachToExistingInstancetoggleUsesGlobalLeftMouseClickAgent = mSOutlookAttachToExistingInstancetoggleUsesGlobalLeftMouseClickAgent == null ? null : WorkflowExpression.Compile(mSOutlookAttachToExistingInstancetoggleUsesGlobalLeftMouseClickAgent);
            WorkflowExpression.Validate(__workflow_mSOutlookAttachToExistingInstancetoggleUsesGlobalLeftMouseClickAgent, nameof(mSOutlookAttachToExistingInstancetoggleUsesGlobalLeftMouseClickAgent), required: false);
            var __workflow_mSOutlookAttachToExistingInstancetoggleDelay = mSOutlookAttachToExistingInstancetoggleDelay == null ? null : WorkflowExpression.Compile(mSOutlookAttachToExistingInstancetoggleDelay);
            WorkflowExpression.Validate(__workflow_mSOutlookAttachToExistingInstancetoggleDelay, nameof(mSOutlookAttachToExistingInstancetoggleDelay), required: false);
            return new DeferredBodyAction<MSOutlookAttachToExistingInstanceResponse>(() =>
            {
                var apiCallPath = "/MSOutlook/MSOutlookAttachToExistingInstance";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSOutlookAttachToExistingInstance = new JObject();
                var mSOutlookAttachToExistingInstancepropCount = 0;
                if (__workflow_mSOutlookAttachToExistingInstancetoggleWindow != null)
                {
                    if (__workflow_mSOutlookAttachToExistingInstancetoggleWindow != null)
                    {
                        mSOutlookAttachToExistingInstance["ToggleWindow"] = ExpressionConverter.ConvertO(__workflow_mSOutlookAttachToExistingInstancetoggleWindow);
                        mSOutlookAttachToExistingInstancepropCount++;
                    }

                    mSOutlookAttachToExistingInstancepropCount++;
                }
                else
                {
                    mSOutlookAttachToExistingInstance["ToggleWindow"] = true;
                    mSOutlookAttachToExistingInstancepropCount++;
                }

                if (__workflow_mSOutlookAttachToExistingInstancetoggleUsesGlobalLeftMouseClickAgent != null)
                {
                    if (__workflow_mSOutlookAttachToExistingInstancetoggleUsesGlobalLeftMouseClickAgent != null)
                    {
                        mSOutlookAttachToExistingInstance["ToggleUsesGlobalLeftMouseClickAgent"] = ExpressionConverter.ConvertO(__workflow_mSOutlookAttachToExistingInstancetoggleUsesGlobalLeftMouseClickAgent);
                        mSOutlookAttachToExistingInstancepropCount++;
                    }

                    mSOutlookAttachToExistingInstancepropCount++;
                }
                else
                {
                    mSOutlookAttachToExistingInstance["ToggleUsesGlobalLeftMouseClickAgent"] = true;
                    mSOutlookAttachToExistingInstancepropCount++;
                }

                if (__workflow_mSOutlookAttachToExistingInstancetoggleDelay != null)
                {
                    if (__workflow_mSOutlookAttachToExistingInstancetoggleDelay != null)
                    {
                        mSOutlookAttachToExistingInstance["ToggleDelay"] = ExpressionConverter.ConvertO(__workflow_mSOutlookAttachToExistingInstancetoggleDelay);
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
                mSOutlookAttachToExistingInstance["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSOutlookAttachToExistingInstanceworkflow);
                if (mSOutlookAttachToExistingInstancepropCount > 0)
                {
                    callPayload.Body = mSOutlookAttachToExistingInstance;
                }

                return new ApiConnectionAction<MSOutlookAttachToExistingInstanceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookIsConnectedResponse> MSOutlookIsConnected(Expression<Func<string>> mSOutlookIsConnectedworkflow)
        {
            var __workflow_mSOutlookIsConnectedworkflow = mSOutlookIsConnectedworkflow == null ? null : WorkflowExpression.Compile(mSOutlookIsConnectedworkflow);
            WorkflowExpression.Validate(__workflow_mSOutlookIsConnectedworkflow, nameof(mSOutlookIsConnectedworkflow), required: true);
            return new DeferredBodyAction<MSOutlookIsConnectedResponse>(() =>
            {
                var apiCallPath = "/MSOutlook/IsOutlookConnected";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSOutlookIsConnected = new JObject();
                var mSOutlookIsConnectedpropCount = 0;
                mSOutlookIsConnectedpropCount++;
                mSOutlookIsConnected["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSOutlookIsConnectedworkflow);
                if (mSOutlookIsConnectedpropCount > 0)
                {
                    callPayload.Body = mSOutlookIsConnected;
                }

                return new ApiConnectionAction<MSOutlookIsConnectedResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSOutlookShow(Expression<Func<string>> mSOutlookShowworkflow)
        {
            var __workflow_mSOutlookShowworkflow = mSOutlookShowworkflow == null ? null : WorkflowExpression.Compile(mSOutlookShowworkflow);
            WorkflowExpression.Validate(__workflow_mSOutlookShowworkflow, nameof(mSOutlookShowworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/MSOutlook/ShowOutlook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSOutlookShow = new JObject();
                var mSOutlookShowpropCount = 0;
                mSOutlookShowpropCount++;
                mSOutlookShow["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSOutlookShowworkflow);
                if (mSOutlookShowpropCount > 0)
                {
                    callPayload.Body = mSOutlookShow;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookGetNameSpaceInformationResponse> MSOutlookGetNameSpaceInformation(Expression<Func<string>> mSOutlookGetNameSpaceInformationworkflow)
        {
            var __workflow_mSOutlookGetNameSpaceInformationworkflow = mSOutlookGetNameSpaceInformationworkflow == null ? null : WorkflowExpression.Compile(mSOutlookGetNameSpaceInformationworkflow);
            WorkflowExpression.Validate(__workflow_mSOutlookGetNameSpaceInformationworkflow, nameof(mSOutlookGetNameSpaceInformationworkflow), required: true);
            return new DeferredBodyAction<MSOutlookGetNameSpaceInformationResponse>(() =>
            {
                var apiCallPath = "/MSOutlook/GetNameSpaceInformation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSOutlookGetNameSpaceInformation = new JObject();
                var mSOutlookGetNameSpaceInformationpropCount = 0;
                mSOutlookGetNameSpaceInformationpropCount++;
                mSOutlookGetNameSpaceInformation["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSOutlookGetNameSpaceInformationworkflow);
                if (mSOutlookGetNameSpaceInformationpropCount > 0)
                {
                    callPayload.Body = mSOutlookGetNameSpaceInformation;
                }

                return new ApiConnectionAction<MSOutlookGetNameSpaceInformationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookGetMailFoldersResponse> MSOutlookGetMailFolders(Expression<Func<string>> mSOutlookGetMailFoldersworkflow, Expression<Func<string>> mSOutlookGetMailFoldersfolderPath = null, Expression<Func<bool>> mSOutlookGetMailFolderssubFolders = null)
        {
            var __workflow_mSOutlookGetMailFoldersworkflow = mSOutlookGetMailFoldersworkflow == null ? null : WorkflowExpression.Compile(mSOutlookGetMailFoldersworkflow);
            WorkflowExpression.Validate(__workflow_mSOutlookGetMailFoldersworkflow, nameof(mSOutlookGetMailFoldersworkflow), required: true);
            var __workflow_mSOutlookGetMailFoldersfolderPath = mSOutlookGetMailFoldersfolderPath == null ? null : WorkflowExpression.Compile(mSOutlookGetMailFoldersfolderPath);
            WorkflowExpression.Validate(__workflow_mSOutlookGetMailFoldersfolderPath, nameof(mSOutlookGetMailFoldersfolderPath), required: false);
            var __workflow_mSOutlookGetMailFolderssubFolders = mSOutlookGetMailFolderssubFolders == null ? null : WorkflowExpression.Compile(mSOutlookGetMailFolderssubFolders);
            WorkflowExpression.Validate(__workflow_mSOutlookGetMailFolderssubFolders, nameof(mSOutlookGetMailFolderssubFolders), required: false);
            return new DeferredBodyAction<MSOutlookGetMailFoldersResponse>(() =>
            {
                var apiCallPath = "/MSOutlook/GetMailFolders";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSOutlookGetMailFolders = new JObject();
                var mSOutlookGetMailFolderspropCount = 0;
                if (__workflow_mSOutlookGetMailFoldersfolderPath != null)
                {
                    mSOutlookGetMailFolders["FolderPath"] = ExpressionConverter.ConvertO(__workflow_mSOutlookGetMailFoldersfolderPath);
                    mSOutlookGetMailFolderspropCount++;
                }

                if (__workflow_mSOutlookGetMailFolderssubFolders != null)
                {
                    if (__workflow_mSOutlookGetMailFolderssubFolders != null)
                    {
                        mSOutlookGetMailFolders["SubFolders"] = ExpressionConverter.ConvertO(__workflow_mSOutlookGetMailFolderssubFolders);
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
                mSOutlookGetMailFolders["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSOutlookGetMailFoldersworkflow);
                if (mSOutlookGetMailFolderspropCount > 0)
                {
                    callPayload.Body = mSOutlookGetMailFolders;
                }

                return new ApiConnectionAction<MSOutlookGetMailFoldersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSOutlookMarkEmailAsRead(Expression<Func<string>> mSOutlookMarkEmailAsReadentryID, Expression<Func<string>> mSOutlookMarkEmailAsReadworkflow, Expression<Func<bool>> mSOutlookMarkEmailAsReadread = null)
        {
            var __workflow_mSOutlookMarkEmailAsReadentryID = mSOutlookMarkEmailAsReadentryID == null ? null : WorkflowExpression.Compile(mSOutlookMarkEmailAsReadentryID);
            WorkflowExpression.Validate(__workflow_mSOutlookMarkEmailAsReadentryID, nameof(mSOutlookMarkEmailAsReadentryID), required: true);
            var __workflow_mSOutlookMarkEmailAsReadworkflow = mSOutlookMarkEmailAsReadworkflow == null ? null : WorkflowExpression.Compile(mSOutlookMarkEmailAsReadworkflow);
            WorkflowExpression.Validate(__workflow_mSOutlookMarkEmailAsReadworkflow, nameof(mSOutlookMarkEmailAsReadworkflow), required: true);
            var __workflow_mSOutlookMarkEmailAsReadread = mSOutlookMarkEmailAsReadread == null ? null : WorkflowExpression.Compile(mSOutlookMarkEmailAsReadread);
            WorkflowExpression.Validate(__workflow_mSOutlookMarkEmailAsReadread, nameof(mSOutlookMarkEmailAsReadread), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/MSOutlook/MarkEmailAsRead";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSOutlookMarkEmailAsRead = new JObject();
                var mSOutlookMarkEmailAsReadpropCount = 0;
                mSOutlookMarkEmailAsReadpropCount++;
                mSOutlookMarkEmailAsRead["EntryID"] = ExpressionConverter.ConvertO(__workflow_mSOutlookMarkEmailAsReadentryID);
                if (__workflow_mSOutlookMarkEmailAsReadread != null)
                {
                    if (__workflow_mSOutlookMarkEmailAsReadread != null)
                    {
                        mSOutlookMarkEmailAsRead["Read"] = ExpressionConverter.ConvertO(__workflow_mSOutlookMarkEmailAsReadread);
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
                mSOutlookMarkEmailAsRead["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSOutlookMarkEmailAsReadworkflow);
                if (mSOutlookMarkEmailAsReadpropCount > 0)
                {
                    callPayload.Body = mSOutlookMarkEmailAsRead;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookGetEmailBodyResponse> MSOutlookGetEmailBody(Expression<Func<string>> mSOutlookGetEmailBodyentryID, Expression<Func<string>> mSOutlookGetEmailBodyworkflow, Expression<Func<bool>> mSOutlookGetEmailBodyclickAllowButtonIfRequired = null)
        {
            var __workflow_mSOutlookGetEmailBodyentryID = mSOutlookGetEmailBodyentryID == null ? null : WorkflowExpression.Compile(mSOutlookGetEmailBodyentryID);
            WorkflowExpression.Validate(__workflow_mSOutlookGetEmailBodyentryID, nameof(mSOutlookGetEmailBodyentryID), required: true);
            var __workflow_mSOutlookGetEmailBodyworkflow = mSOutlookGetEmailBodyworkflow == null ? null : WorkflowExpression.Compile(mSOutlookGetEmailBodyworkflow);
            WorkflowExpression.Validate(__workflow_mSOutlookGetEmailBodyworkflow, nameof(mSOutlookGetEmailBodyworkflow), required: true);
            var __workflow_mSOutlookGetEmailBodyclickAllowButtonIfRequired = mSOutlookGetEmailBodyclickAllowButtonIfRequired == null ? null : WorkflowExpression.Compile(mSOutlookGetEmailBodyclickAllowButtonIfRequired);
            WorkflowExpression.Validate(__workflow_mSOutlookGetEmailBodyclickAllowButtonIfRequired, nameof(mSOutlookGetEmailBodyclickAllowButtonIfRequired), required: false);
            return new DeferredBodyAction<MSOutlookGetEmailBodyResponse>(() =>
            {
                var apiCallPath = "/MSOutlook/GetEmailBody";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSOutlookGetEmailBody = new JObject();
                var mSOutlookGetEmailBodypropCount = 0;
                mSOutlookGetEmailBodypropCount++;
                mSOutlookGetEmailBody["EntryID"] = ExpressionConverter.ConvertO(__workflow_mSOutlookGetEmailBodyentryID);
                if (__workflow_mSOutlookGetEmailBodyclickAllowButtonIfRequired != null)
                {
                    if (__workflow_mSOutlookGetEmailBodyclickAllowButtonIfRequired != null)
                    {
                        mSOutlookGetEmailBody["ClickAllowButtonIfRequired"] = ExpressionConverter.ConvertO(__workflow_mSOutlookGetEmailBodyclickAllowButtonIfRequired);
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
                mSOutlookGetEmailBody["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSOutlookGetEmailBodyworkflow);
                if (mSOutlookGetEmailBodypropCount > 0)
                {
                    callPayload.Body = mSOutlookGetEmailBody;
                }

                return new ApiConnectionAction<MSOutlookGetEmailBodyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookGetEmailAttachmentFilenamesResponse> MSOutlookGetEmailAttachmentFilenames(Expression<Func<string>> mSOutlookGetEmailAttachmentFilenamesentryID, Expression<Func<string>> mSOutlookGetEmailAttachmentFilenamesworkflow, Expression<Func<bool>> mSOutlookGetEmailAttachmentFilenamesclickAllowButtonIfRequired = null)
        {
            var __workflow_mSOutlookGetEmailAttachmentFilenamesentryID = mSOutlookGetEmailAttachmentFilenamesentryID == null ? null : WorkflowExpression.Compile(mSOutlookGetEmailAttachmentFilenamesentryID);
            WorkflowExpression.Validate(__workflow_mSOutlookGetEmailAttachmentFilenamesentryID, nameof(mSOutlookGetEmailAttachmentFilenamesentryID), required: true);
            var __workflow_mSOutlookGetEmailAttachmentFilenamesworkflow = mSOutlookGetEmailAttachmentFilenamesworkflow == null ? null : WorkflowExpression.Compile(mSOutlookGetEmailAttachmentFilenamesworkflow);
            WorkflowExpression.Validate(__workflow_mSOutlookGetEmailAttachmentFilenamesworkflow, nameof(mSOutlookGetEmailAttachmentFilenamesworkflow), required: true);
            var __workflow_mSOutlookGetEmailAttachmentFilenamesclickAllowButtonIfRequired = mSOutlookGetEmailAttachmentFilenamesclickAllowButtonIfRequired == null ? null : WorkflowExpression.Compile(mSOutlookGetEmailAttachmentFilenamesclickAllowButtonIfRequired);
            WorkflowExpression.Validate(__workflow_mSOutlookGetEmailAttachmentFilenamesclickAllowButtonIfRequired, nameof(mSOutlookGetEmailAttachmentFilenamesclickAllowButtonIfRequired), required: false);
            return new DeferredBodyAction<MSOutlookGetEmailAttachmentFilenamesResponse>(() =>
            {
                var apiCallPath = "/MSOutlook/GetEmailAttachmentFilenames";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSOutlookGetEmailAttachmentFilenames = new JObject();
                var mSOutlookGetEmailAttachmentFilenamespropCount = 0;
                mSOutlookGetEmailAttachmentFilenamespropCount++;
                mSOutlookGetEmailAttachmentFilenames["EntryID"] = ExpressionConverter.ConvertO(__workflow_mSOutlookGetEmailAttachmentFilenamesentryID);
                if (__workflow_mSOutlookGetEmailAttachmentFilenamesclickAllowButtonIfRequired != null)
                {
                    if (__workflow_mSOutlookGetEmailAttachmentFilenamesclickAllowButtonIfRequired != null)
                    {
                        mSOutlookGetEmailAttachmentFilenames["ClickAllowButtonIfRequired"] = ExpressionConverter.ConvertO(__workflow_mSOutlookGetEmailAttachmentFilenamesclickAllowButtonIfRequired);
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
                mSOutlookGetEmailAttachmentFilenames["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSOutlookGetEmailAttachmentFilenamesworkflow);
                if (mSOutlookGetEmailAttachmentFilenamespropCount > 0)
                {
                    callPayload.Body = mSOutlookGetEmailAttachmentFilenames;
                }

                return new ApiConnectionAction<MSOutlookGetEmailAttachmentFilenamesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookSaveEmailAttachmentsAsFileResponse> MSOutlookSaveEmailAttachmentsAsFile(Expression<Func<string>> mSOutlookSaveEmailAttachmentsAsFileentryID, Expression<Func<string>> mSOutlookSaveEmailAttachmentsAsFileworkflow, Expression<Func<string>> mSOutlookSaveEmailAttachmentsAsFilesaveFolderPath = null, Expression<Func<bool>> mSOutlookSaveEmailAttachmentsAsFilecreateFolder = null, Expression<Func<string>> mSOutlookSaveEmailAttachmentsAsFileonlySaveAttachmentsMatchingWildcard = null, Expression<Func<bool>> mSOutlookSaveEmailAttachmentsAsFilesaveHiddenAttachments = null, Expression<Func<bool>> mSOutlookSaveEmailAttachmentsAsFileclickAllowButtonIfRequired = null)
        {
            var __workflow_mSOutlookSaveEmailAttachmentsAsFileentryID = mSOutlookSaveEmailAttachmentsAsFileentryID == null ? null : WorkflowExpression.Compile(mSOutlookSaveEmailAttachmentsAsFileentryID);
            WorkflowExpression.Validate(__workflow_mSOutlookSaveEmailAttachmentsAsFileentryID, nameof(mSOutlookSaveEmailAttachmentsAsFileentryID), required: true);
            var __workflow_mSOutlookSaveEmailAttachmentsAsFileworkflow = mSOutlookSaveEmailAttachmentsAsFileworkflow == null ? null : WorkflowExpression.Compile(mSOutlookSaveEmailAttachmentsAsFileworkflow);
            WorkflowExpression.Validate(__workflow_mSOutlookSaveEmailAttachmentsAsFileworkflow, nameof(mSOutlookSaveEmailAttachmentsAsFileworkflow), required: true);
            var __workflow_mSOutlookSaveEmailAttachmentsAsFilesaveFolderPath = mSOutlookSaveEmailAttachmentsAsFilesaveFolderPath == null ? null : WorkflowExpression.Compile(mSOutlookSaveEmailAttachmentsAsFilesaveFolderPath);
            WorkflowExpression.Validate(__workflow_mSOutlookSaveEmailAttachmentsAsFilesaveFolderPath, nameof(mSOutlookSaveEmailAttachmentsAsFilesaveFolderPath), required: false);
            var __workflow_mSOutlookSaveEmailAttachmentsAsFilecreateFolder = mSOutlookSaveEmailAttachmentsAsFilecreateFolder == null ? null : WorkflowExpression.Compile(mSOutlookSaveEmailAttachmentsAsFilecreateFolder);
            WorkflowExpression.Validate(__workflow_mSOutlookSaveEmailAttachmentsAsFilecreateFolder, nameof(mSOutlookSaveEmailAttachmentsAsFilecreateFolder), required: false);
            var __workflow_mSOutlookSaveEmailAttachmentsAsFileonlySaveAttachmentsMatchingWildcard = mSOutlookSaveEmailAttachmentsAsFileonlySaveAttachmentsMatchingWildcard == null ? null : WorkflowExpression.Compile(mSOutlookSaveEmailAttachmentsAsFileonlySaveAttachmentsMatchingWildcard);
            WorkflowExpression.Validate(__workflow_mSOutlookSaveEmailAttachmentsAsFileonlySaveAttachmentsMatchingWildcard, nameof(mSOutlookSaveEmailAttachmentsAsFileonlySaveAttachmentsMatchingWildcard), required: false);
            var __workflow_mSOutlookSaveEmailAttachmentsAsFilesaveHiddenAttachments = mSOutlookSaveEmailAttachmentsAsFilesaveHiddenAttachments == null ? null : WorkflowExpression.Compile(mSOutlookSaveEmailAttachmentsAsFilesaveHiddenAttachments);
            WorkflowExpression.Validate(__workflow_mSOutlookSaveEmailAttachmentsAsFilesaveHiddenAttachments, nameof(mSOutlookSaveEmailAttachmentsAsFilesaveHiddenAttachments), required: false);
            var __workflow_mSOutlookSaveEmailAttachmentsAsFileclickAllowButtonIfRequired = mSOutlookSaveEmailAttachmentsAsFileclickAllowButtonIfRequired == null ? null : WorkflowExpression.Compile(mSOutlookSaveEmailAttachmentsAsFileclickAllowButtonIfRequired);
            WorkflowExpression.Validate(__workflow_mSOutlookSaveEmailAttachmentsAsFileclickAllowButtonIfRequired, nameof(mSOutlookSaveEmailAttachmentsAsFileclickAllowButtonIfRequired), required: false);
            return new DeferredBodyAction<MSOutlookSaveEmailAttachmentsAsFileResponse>(() =>
            {
                var apiCallPath = "/MSOutlook/SaveEmailAttachmentsAsFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSOutlookSaveEmailAttachmentsAsFile = new JObject();
                var mSOutlookSaveEmailAttachmentsAsFilepropCount = 0;
                mSOutlookSaveEmailAttachmentsAsFilepropCount++;
                mSOutlookSaveEmailAttachmentsAsFile["EntryID"] = ExpressionConverter.ConvertO(__workflow_mSOutlookSaveEmailAttachmentsAsFileentryID);
                if (__workflow_mSOutlookSaveEmailAttachmentsAsFilesaveFolderPath != null)
                {
                    mSOutlookSaveEmailAttachmentsAsFile["SaveFolderPath"] = ExpressionConverter.ConvertO(__workflow_mSOutlookSaveEmailAttachmentsAsFilesaveFolderPath);
                    mSOutlookSaveEmailAttachmentsAsFilepropCount++;
                }

                if (__workflow_mSOutlookSaveEmailAttachmentsAsFilecreateFolder != null)
                {
                    if (__workflow_mSOutlookSaveEmailAttachmentsAsFilecreateFolder != null)
                    {
                        mSOutlookSaveEmailAttachmentsAsFile["CreateFolder"] = ExpressionConverter.ConvertO(__workflow_mSOutlookSaveEmailAttachmentsAsFilecreateFolder);
                        mSOutlookSaveEmailAttachmentsAsFilepropCount++;
                    }

                    mSOutlookSaveEmailAttachmentsAsFilepropCount++;
                }
                else
                {
                    mSOutlookSaveEmailAttachmentsAsFile["CreateFolder"] = true;
                    mSOutlookSaveEmailAttachmentsAsFilepropCount++;
                }

                if (__workflow_mSOutlookSaveEmailAttachmentsAsFileonlySaveAttachmentsMatchingWildcard != null)
                {
                    mSOutlookSaveEmailAttachmentsAsFile["OnlySaveAttachmentsMatchingWildcard"] = ExpressionConverter.ConvertO(__workflow_mSOutlookSaveEmailAttachmentsAsFileonlySaveAttachmentsMatchingWildcard);
                    mSOutlookSaveEmailAttachmentsAsFilepropCount++;
                }

                if (__workflow_mSOutlookSaveEmailAttachmentsAsFilesaveHiddenAttachments != null)
                {
                    if (__workflow_mSOutlookSaveEmailAttachmentsAsFilesaveHiddenAttachments != null)
                    {
                        mSOutlookSaveEmailAttachmentsAsFile["SaveHiddenAttachments"] = ExpressionConverter.ConvertO(__workflow_mSOutlookSaveEmailAttachmentsAsFilesaveHiddenAttachments);
                        mSOutlookSaveEmailAttachmentsAsFilepropCount++;
                    }

                    mSOutlookSaveEmailAttachmentsAsFilepropCount++;
                }
                else
                {
                    mSOutlookSaveEmailAttachmentsAsFile["SaveHiddenAttachments"] = false;
                    mSOutlookSaveEmailAttachmentsAsFilepropCount++;
                }

                if (__workflow_mSOutlookSaveEmailAttachmentsAsFileclickAllowButtonIfRequired != null)
                {
                    if (__workflow_mSOutlookSaveEmailAttachmentsAsFileclickAllowButtonIfRequired != null)
                    {
                        mSOutlookSaveEmailAttachmentsAsFile["ClickAllowButtonIfRequired"] = ExpressionConverter.ConvertO(__workflow_mSOutlookSaveEmailAttachmentsAsFileclickAllowButtonIfRequired);
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
                mSOutlookSaveEmailAttachmentsAsFile["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSOutlookSaveEmailAttachmentsAsFileworkflow);
                if (mSOutlookSaveEmailAttachmentsAsFilepropCount > 0)
                {
                    callPayload.Body = mSOutlookSaveEmailAttachmentsAsFile;
                }

                return new ApiConnectionAction<MSOutlookSaveEmailAttachmentsAsFileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSOutlookDeleteEmail(Expression<Func<string>> mSOutlookDeleteEmailentryID, Expression<Func<string>> mSOutlookDeleteEmailworkflow)
        {
            var __workflow_mSOutlookDeleteEmailentryID = mSOutlookDeleteEmailentryID == null ? null : WorkflowExpression.Compile(mSOutlookDeleteEmailentryID);
            WorkflowExpression.Validate(__workflow_mSOutlookDeleteEmailentryID, nameof(mSOutlookDeleteEmailentryID), required: true);
            var __workflow_mSOutlookDeleteEmailworkflow = mSOutlookDeleteEmailworkflow == null ? null : WorkflowExpression.Compile(mSOutlookDeleteEmailworkflow);
            WorkflowExpression.Validate(__workflow_mSOutlookDeleteEmailworkflow, nameof(mSOutlookDeleteEmailworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/MSOutlook/DeleteEmail";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSOutlookDeleteEmail = new JObject();
                var mSOutlookDeleteEmailpropCount = 0;
                mSOutlookDeleteEmailpropCount++;
                mSOutlookDeleteEmail["EntryID"] = ExpressionConverter.ConvertO(__workflow_mSOutlookDeleteEmailentryID);
                mSOutlookDeleteEmailpropCount++;
                mSOutlookDeleteEmail["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSOutlookDeleteEmailworkflow);
                if (mSOutlookDeleteEmailpropCount > 0)
                {
                    callPayload.Body = mSOutlookDeleteEmail;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSOutlookMoveEmail(Expression<Func<string>> mSOutlookMoveEmailentryID, Expression<Func<string>> mSOutlookMoveEmailworkflow, Expression<Func<string>> mSOutlookMoveEmaildestinationFolder = null)
        {
            var __workflow_mSOutlookMoveEmailentryID = mSOutlookMoveEmailentryID == null ? null : WorkflowExpression.Compile(mSOutlookMoveEmailentryID);
            WorkflowExpression.Validate(__workflow_mSOutlookMoveEmailentryID, nameof(mSOutlookMoveEmailentryID), required: true);
            var __workflow_mSOutlookMoveEmailworkflow = mSOutlookMoveEmailworkflow == null ? null : WorkflowExpression.Compile(mSOutlookMoveEmailworkflow);
            WorkflowExpression.Validate(__workflow_mSOutlookMoveEmailworkflow, nameof(mSOutlookMoveEmailworkflow), required: true);
            var __workflow_mSOutlookMoveEmaildestinationFolder = mSOutlookMoveEmaildestinationFolder == null ? null : WorkflowExpression.Compile(mSOutlookMoveEmaildestinationFolder);
            WorkflowExpression.Validate(__workflow_mSOutlookMoveEmaildestinationFolder, nameof(mSOutlookMoveEmaildestinationFolder), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/MSOutlook/MoveEmail";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSOutlookMoveEmail = new JObject();
                var mSOutlookMoveEmailpropCount = 0;
                mSOutlookMoveEmailpropCount++;
                mSOutlookMoveEmail["EntryID"] = ExpressionConverter.ConvertO(__workflow_mSOutlookMoveEmailentryID);
                if (__workflow_mSOutlookMoveEmaildestinationFolder != null)
                {
                    mSOutlookMoveEmail["DestinationFolder"] = ExpressionConverter.ConvertO(__workflow_mSOutlookMoveEmaildestinationFolder);
                    mSOutlookMoveEmailpropCount++;
                }

                mSOutlookMoveEmailpropCount++;
                mSOutlookMoveEmail["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSOutlookMoveEmailworkflow);
                if (mSOutlookMoveEmailpropCount > 0)
                {
                    callPayload.Body = mSOutlookMoveEmail;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSOutlookSendEmail(Expression<Func<string>> mSOutlookSendEmailworkflow, Expression<Func<string>> mSOutlookSendEmailto = null, Expression<Func<string>> mSOutlookSendEmailcC = null, Expression<Func<string>> mSOutlookSendEmailbCC = null, Expression<Func<string>> mSOutlookSendEmailsubject = null, Expression<Func<mSOutlookSendEmailbodyFormatInput>> mSOutlookSendEmailbodyFormat = null, Expression<Func<string>> mSOutlookSendEmailbody = null, Expression<Func<string>> mSOutlookSendEmailhTMLBody = null, Expression<Func<string>> mSOutlookSendEmailrTFBody = null, Expression<Func<string>> mSOutlookSendEmailattachmentFilenamesJSON = null, Expression<Func<bool>> mSOutlookSendEmaildontSendIfAttachmentFilenameMissing = null, Expression<Func<bool>> mSOutlookSendEmailclickAllowButtonIfRequired = null, Expression<Func<string>> mSOutlookSendEmailvotingOptions = null, Expression<Func<string>> mSOutlookSendEmailsendAsSMTPAddress = null, Expression<Func<bool>> mSOutlookSendEmailbodyContainsStoredPassword = null)
        {
            var __workflow_mSOutlookSendEmailworkflow = mSOutlookSendEmailworkflow == null ? null : WorkflowExpression.Compile(mSOutlookSendEmailworkflow);
            WorkflowExpression.Validate(__workflow_mSOutlookSendEmailworkflow, nameof(mSOutlookSendEmailworkflow), required: true);
            var __workflow_mSOutlookSendEmailto = mSOutlookSendEmailto == null ? null : WorkflowExpression.Compile(mSOutlookSendEmailto);
            WorkflowExpression.Validate(__workflow_mSOutlookSendEmailto, nameof(mSOutlookSendEmailto), required: false);
            var __workflow_mSOutlookSendEmailcC = mSOutlookSendEmailcC == null ? null : WorkflowExpression.Compile(mSOutlookSendEmailcC);
            WorkflowExpression.Validate(__workflow_mSOutlookSendEmailcC, nameof(mSOutlookSendEmailcC), required: false);
            var __workflow_mSOutlookSendEmailbCC = mSOutlookSendEmailbCC == null ? null : WorkflowExpression.Compile(mSOutlookSendEmailbCC);
            WorkflowExpression.Validate(__workflow_mSOutlookSendEmailbCC, nameof(mSOutlookSendEmailbCC), required: false);
            var __workflow_mSOutlookSendEmailsubject = mSOutlookSendEmailsubject == null ? null : WorkflowExpression.Compile(mSOutlookSendEmailsubject);
            WorkflowExpression.Validate(__workflow_mSOutlookSendEmailsubject, nameof(mSOutlookSendEmailsubject), required: false);
            var __workflow_mSOutlookSendEmailbodyFormat = mSOutlookSendEmailbodyFormat == null ? null : WorkflowExpression.Compile(mSOutlookSendEmailbodyFormat);
            WorkflowExpression.Validate(__workflow_mSOutlookSendEmailbodyFormat, nameof(mSOutlookSendEmailbodyFormat), required: false);
            var __workflow_mSOutlookSendEmailbody = mSOutlookSendEmailbody == null ? null : WorkflowExpression.Compile(mSOutlookSendEmailbody);
            WorkflowExpression.Validate(__workflow_mSOutlookSendEmailbody, nameof(mSOutlookSendEmailbody), required: false);
            var __workflow_mSOutlookSendEmailhTMLBody = mSOutlookSendEmailhTMLBody == null ? null : WorkflowExpression.Compile(mSOutlookSendEmailhTMLBody);
            WorkflowExpression.Validate(__workflow_mSOutlookSendEmailhTMLBody, nameof(mSOutlookSendEmailhTMLBody), required: false);
            var __workflow_mSOutlookSendEmailrTFBody = mSOutlookSendEmailrTFBody == null ? null : WorkflowExpression.Compile(mSOutlookSendEmailrTFBody);
            WorkflowExpression.Validate(__workflow_mSOutlookSendEmailrTFBody, nameof(mSOutlookSendEmailrTFBody), required: false);
            var __workflow_mSOutlookSendEmailattachmentFilenamesJSON = mSOutlookSendEmailattachmentFilenamesJSON == null ? null : WorkflowExpression.Compile(mSOutlookSendEmailattachmentFilenamesJSON);
            WorkflowExpression.Validate(__workflow_mSOutlookSendEmailattachmentFilenamesJSON, nameof(mSOutlookSendEmailattachmentFilenamesJSON), required: false);
            var __workflow_mSOutlookSendEmaildontSendIfAttachmentFilenameMissing = mSOutlookSendEmaildontSendIfAttachmentFilenameMissing == null ? null : WorkflowExpression.Compile(mSOutlookSendEmaildontSendIfAttachmentFilenameMissing);
            WorkflowExpression.Validate(__workflow_mSOutlookSendEmaildontSendIfAttachmentFilenameMissing, nameof(mSOutlookSendEmaildontSendIfAttachmentFilenameMissing), required: false);
            var __workflow_mSOutlookSendEmailclickAllowButtonIfRequired = mSOutlookSendEmailclickAllowButtonIfRequired == null ? null : WorkflowExpression.Compile(mSOutlookSendEmailclickAllowButtonIfRequired);
            WorkflowExpression.Validate(__workflow_mSOutlookSendEmailclickAllowButtonIfRequired, nameof(mSOutlookSendEmailclickAllowButtonIfRequired), required: false);
            var __workflow_mSOutlookSendEmailvotingOptions = mSOutlookSendEmailvotingOptions == null ? null : WorkflowExpression.Compile(mSOutlookSendEmailvotingOptions);
            WorkflowExpression.Validate(__workflow_mSOutlookSendEmailvotingOptions, nameof(mSOutlookSendEmailvotingOptions), required: false);
            var __workflow_mSOutlookSendEmailsendAsSMTPAddress = mSOutlookSendEmailsendAsSMTPAddress == null ? null : WorkflowExpression.Compile(mSOutlookSendEmailsendAsSMTPAddress);
            WorkflowExpression.Validate(__workflow_mSOutlookSendEmailsendAsSMTPAddress, nameof(mSOutlookSendEmailsendAsSMTPAddress), required: false);
            var __workflow_mSOutlookSendEmailbodyContainsStoredPassword = mSOutlookSendEmailbodyContainsStoredPassword == null ? null : WorkflowExpression.Compile(mSOutlookSendEmailbodyContainsStoredPassword);
            WorkflowExpression.Validate(__workflow_mSOutlookSendEmailbodyContainsStoredPassword, nameof(mSOutlookSendEmailbodyContainsStoredPassword), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/MSOutlook/SendEmail";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSOutlookSendEmail = new JObject();
                var mSOutlookSendEmailpropCount = 0;
                if (__workflow_mSOutlookSendEmailto != null)
                {
                    mSOutlookSendEmail["To"] = ExpressionConverter.ConvertO(__workflow_mSOutlookSendEmailto);
                    mSOutlookSendEmailpropCount++;
                }

                if (__workflow_mSOutlookSendEmailcC != null)
                {
                    mSOutlookSendEmail["CC"] = ExpressionConverter.ConvertO(__workflow_mSOutlookSendEmailcC);
                    mSOutlookSendEmailpropCount++;
                }

                if (__workflow_mSOutlookSendEmailbCC != null)
                {
                    mSOutlookSendEmail["BCC"] = ExpressionConverter.ConvertO(__workflow_mSOutlookSendEmailbCC);
                    mSOutlookSendEmailpropCount++;
                }

                if (__workflow_mSOutlookSendEmailsubject != null)
                {
                    mSOutlookSendEmail["Subject"] = ExpressionConverter.ConvertO(__workflow_mSOutlookSendEmailsubject);
                    mSOutlookSendEmailpropCount++;
                }

                if (__workflow_mSOutlookSendEmailbodyFormat != null)
                {
                    mSOutlookSendEmail["BodyFormat"] = ExpressionConverter.ConvertO(__workflow_mSOutlookSendEmailbodyFormat);
                    mSOutlookSendEmailpropCount++;
                }

                if (__workflow_mSOutlookSendEmailbody != null)
                {
                    mSOutlookSendEmail["Body"] = ExpressionConverter.ConvertO(__workflow_mSOutlookSendEmailbody);
                    mSOutlookSendEmailpropCount++;
                }

                if (__workflow_mSOutlookSendEmailhTMLBody != null)
                {
                    mSOutlookSendEmail["HTMLBody"] = ExpressionConverter.ConvertO(__workflow_mSOutlookSendEmailhTMLBody);
                    mSOutlookSendEmailpropCount++;
                }

                if (__workflow_mSOutlookSendEmailrTFBody != null)
                {
                    mSOutlookSendEmail["RTFBody"] = ExpressionConverter.ConvertO(__workflow_mSOutlookSendEmailrTFBody);
                    mSOutlookSendEmailpropCount++;
                }

                if (__workflow_mSOutlookSendEmailattachmentFilenamesJSON != null)
                {
                    mSOutlookSendEmail["AttachmentFilenamesJSON"] = ExpressionConverter.ConvertO(__workflow_mSOutlookSendEmailattachmentFilenamesJSON);
                    mSOutlookSendEmailpropCount++;
                }

                if (__workflow_mSOutlookSendEmaildontSendIfAttachmentFilenameMissing != null)
                {
                    if (__workflow_mSOutlookSendEmaildontSendIfAttachmentFilenameMissing != null)
                    {
                        mSOutlookSendEmail["DontSendIfAttachmentFilenameMissing"] = ExpressionConverter.ConvertO(__workflow_mSOutlookSendEmaildontSendIfAttachmentFilenameMissing);
                        mSOutlookSendEmailpropCount++;
                    }

                    mSOutlookSendEmailpropCount++;
                }
                else
                {
                    mSOutlookSendEmail["DontSendIfAttachmentFilenameMissing"] = false;
                    mSOutlookSendEmailpropCount++;
                }

                if (__workflow_mSOutlookSendEmailclickAllowButtonIfRequired != null)
                {
                    if (__workflow_mSOutlookSendEmailclickAllowButtonIfRequired != null)
                    {
                        mSOutlookSendEmail["ClickAllowButtonIfRequired"] = ExpressionConverter.ConvertO(__workflow_mSOutlookSendEmailclickAllowButtonIfRequired);
                        mSOutlookSendEmailpropCount++;
                    }

                    mSOutlookSendEmailpropCount++;
                }
                else
                {
                    mSOutlookSendEmail["ClickAllowButtonIfRequired"] = true;
                    mSOutlookSendEmailpropCount++;
                }

                if (__workflow_mSOutlookSendEmailvotingOptions != null)
                {
                    mSOutlookSendEmail["VotingOptions"] = ExpressionConverter.ConvertO(__workflow_mSOutlookSendEmailvotingOptions);
                    mSOutlookSendEmailpropCount++;
                }

                if (__workflow_mSOutlookSendEmailsendAsSMTPAddress != null)
                {
                    mSOutlookSendEmail["SendAsSMTPAddress"] = ExpressionConverter.ConvertO(__workflow_mSOutlookSendEmailsendAsSMTPAddress);
                    mSOutlookSendEmailpropCount++;
                }

                if (__workflow_mSOutlookSendEmailbodyContainsStoredPassword != null)
                {
                    if (__workflow_mSOutlookSendEmailbodyContainsStoredPassword != null)
                    {
                        mSOutlookSendEmail["BodyContainsStoredPassword"] = ExpressionConverter.ConvertO(__workflow_mSOutlookSendEmailbodyContainsStoredPassword);
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
                mSOutlookSendEmail["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSOutlookSendEmailworkflow);
                if (mSOutlookSendEmailpropCount > 0)
                {
                    callPayload.Body = mSOutlookSendEmail;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSOutlookCreateMailFolder(Expression<Func<string>> mSOutlookCreateMailFolderworkflow, Expression<Func<string>> mSOutlookCreateMailFolderparentFolderPath = null, Expression<Func<string>> mSOutlookCreateMailFoldernewFolderName = null)
        {
            var __workflow_mSOutlookCreateMailFolderworkflow = mSOutlookCreateMailFolderworkflow == null ? null : WorkflowExpression.Compile(mSOutlookCreateMailFolderworkflow);
            WorkflowExpression.Validate(__workflow_mSOutlookCreateMailFolderworkflow, nameof(mSOutlookCreateMailFolderworkflow), required: true);
            var __workflow_mSOutlookCreateMailFolderparentFolderPath = mSOutlookCreateMailFolderparentFolderPath == null ? null : WorkflowExpression.Compile(mSOutlookCreateMailFolderparentFolderPath);
            WorkflowExpression.Validate(__workflow_mSOutlookCreateMailFolderparentFolderPath, nameof(mSOutlookCreateMailFolderparentFolderPath), required: false);
            var __workflow_mSOutlookCreateMailFoldernewFolderName = mSOutlookCreateMailFoldernewFolderName == null ? null : WorkflowExpression.Compile(mSOutlookCreateMailFoldernewFolderName);
            WorkflowExpression.Validate(__workflow_mSOutlookCreateMailFoldernewFolderName, nameof(mSOutlookCreateMailFoldernewFolderName), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/MSOutlook/CreateMailFolder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSOutlookCreateMailFolder = new JObject();
                var mSOutlookCreateMailFolderpropCount = 0;
                if (__workflow_mSOutlookCreateMailFolderparentFolderPath != null)
                {
                    mSOutlookCreateMailFolder["ParentFolderPath"] = ExpressionConverter.ConvertO(__workflow_mSOutlookCreateMailFolderparentFolderPath);
                    mSOutlookCreateMailFolderpropCount++;
                }

                if (__workflow_mSOutlookCreateMailFoldernewFolderName != null)
                {
                    mSOutlookCreateMailFolder["NewFolderName"] = ExpressionConverter.ConvertO(__workflow_mSOutlookCreateMailFoldernewFolderName);
                    mSOutlookCreateMailFolderpropCount++;
                }

                mSOutlookCreateMailFolderpropCount++;
                mSOutlookCreateMailFolder["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSOutlookCreateMailFolderworkflow);
                if (mSOutlookCreateMailFolderpropCount > 0)
                {
                    callPayload.Body = mSOutlookCreateMailFolder;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSOutlookReplyToEmail(Expression<Func<string>> mSOutlookReplyToEmailentryID, Expression<Func<string>> mSOutlookReplyToEmailworkflow, Expression<Func<bool>> mSOutlookReplyToEmailreplyToAll = null, Expression<Func<mSOutlookReplyToEmailbodyFormatInput>> mSOutlookReplyToEmailbodyFormat = null, Expression<Func<string>> mSOutlookReplyToEmailbody = null, Expression<Func<string>> mSOutlookReplyToEmailhTMLBody = null, Expression<Func<string>> mSOutlookReplyToEmailrTFBody = null, Expression<Func<string>> mSOutlookReplyToEmailattachmentFilenamesJSON = null, Expression<Func<bool>> mSOutlookReplyToEmaildontSendIfAttachmentFilenameMissing = null, Expression<Func<bool>> mSOutlookReplyToEmailclickAllowButtonIfRequired = null, Expression<Func<string>> mSOutlookReplyToEmailvotingOptions = null, Expression<Func<string>> mSOutlookReplyToEmailsendAsSMTPAddress = null, Expression<Func<bool>> mSOutlookReplyToEmailbodyContainsStoredPassword = null)
        {
            var __workflow_mSOutlookReplyToEmailentryID = mSOutlookReplyToEmailentryID == null ? null : WorkflowExpression.Compile(mSOutlookReplyToEmailentryID);
            WorkflowExpression.Validate(__workflow_mSOutlookReplyToEmailentryID, nameof(mSOutlookReplyToEmailentryID), required: true);
            var __workflow_mSOutlookReplyToEmailworkflow = mSOutlookReplyToEmailworkflow == null ? null : WorkflowExpression.Compile(mSOutlookReplyToEmailworkflow);
            WorkflowExpression.Validate(__workflow_mSOutlookReplyToEmailworkflow, nameof(mSOutlookReplyToEmailworkflow), required: true);
            var __workflow_mSOutlookReplyToEmailreplyToAll = mSOutlookReplyToEmailreplyToAll == null ? null : WorkflowExpression.Compile(mSOutlookReplyToEmailreplyToAll);
            WorkflowExpression.Validate(__workflow_mSOutlookReplyToEmailreplyToAll, nameof(mSOutlookReplyToEmailreplyToAll), required: false);
            var __workflow_mSOutlookReplyToEmailbodyFormat = mSOutlookReplyToEmailbodyFormat == null ? null : WorkflowExpression.Compile(mSOutlookReplyToEmailbodyFormat);
            WorkflowExpression.Validate(__workflow_mSOutlookReplyToEmailbodyFormat, nameof(mSOutlookReplyToEmailbodyFormat), required: false);
            var __workflow_mSOutlookReplyToEmailbody = mSOutlookReplyToEmailbody == null ? null : WorkflowExpression.Compile(mSOutlookReplyToEmailbody);
            WorkflowExpression.Validate(__workflow_mSOutlookReplyToEmailbody, nameof(mSOutlookReplyToEmailbody), required: false);
            var __workflow_mSOutlookReplyToEmailhTMLBody = mSOutlookReplyToEmailhTMLBody == null ? null : WorkflowExpression.Compile(mSOutlookReplyToEmailhTMLBody);
            WorkflowExpression.Validate(__workflow_mSOutlookReplyToEmailhTMLBody, nameof(mSOutlookReplyToEmailhTMLBody), required: false);
            var __workflow_mSOutlookReplyToEmailrTFBody = mSOutlookReplyToEmailrTFBody == null ? null : WorkflowExpression.Compile(mSOutlookReplyToEmailrTFBody);
            WorkflowExpression.Validate(__workflow_mSOutlookReplyToEmailrTFBody, nameof(mSOutlookReplyToEmailrTFBody), required: false);
            var __workflow_mSOutlookReplyToEmailattachmentFilenamesJSON = mSOutlookReplyToEmailattachmentFilenamesJSON == null ? null : WorkflowExpression.Compile(mSOutlookReplyToEmailattachmentFilenamesJSON);
            WorkflowExpression.Validate(__workflow_mSOutlookReplyToEmailattachmentFilenamesJSON, nameof(mSOutlookReplyToEmailattachmentFilenamesJSON), required: false);
            var __workflow_mSOutlookReplyToEmaildontSendIfAttachmentFilenameMissing = mSOutlookReplyToEmaildontSendIfAttachmentFilenameMissing == null ? null : WorkflowExpression.Compile(mSOutlookReplyToEmaildontSendIfAttachmentFilenameMissing);
            WorkflowExpression.Validate(__workflow_mSOutlookReplyToEmaildontSendIfAttachmentFilenameMissing, nameof(mSOutlookReplyToEmaildontSendIfAttachmentFilenameMissing), required: false);
            var __workflow_mSOutlookReplyToEmailclickAllowButtonIfRequired = mSOutlookReplyToEmailclickAllowButtonIfRequired == null ? null : WorkflowExpression.Compile(mSOutlookReplyToEmailclickAllowButtonIfRequired);
            WorkflowExpression.Validate(__workflow_mSOutlookReplyToEmailclickAllowButtonIfRequired, nameof(mSOutlookReplyToEmailclickAllowButtonIfRequired), required: false);
            var __workflow_mSOutlookReplyToEmailvotingOptions = mSOutlookReplyToEmailvotingOptions == null ? null : WorkflowExpression.Compile(mSOutlookReplyToEmailvotingOptions);
            WorkflowExpression.Validate(__workflow_mSOutlookReplyToEmailvotingOptions, nameof(mSOutlookReplyToEmailvotingOptions), required: false);
            var __workflow_mSOutlookReplyToEmailsendAsSMTPAddress = mSOutlookReplyToEmailsendAsSMTPAddress == null ? null : WorkflowExpression.Compile(mSOutlookReplyToEmailsendAsSMTPAddress);
            WorkflowExpression.Validate(__workflow_mSOutlookReplyToEmailsendAsSMTPAddress, nameof(mSOutlookReplyToEmailsendAsSMTPAddress), required: false);
            var __workflow_mSOutlookReplyToEmailbodyContainsStoredPassword = mSOutlookReplyToEmailbodyContainsStoredPassword == null ? null : WorkflowExpression.Compile(mSOutlookReplyToEmailbodyContainsStoredPassword);
            WorkflowExpression.Validate(__workflow_mSOutlookReplyToEmailbodyContainsStoredPassword, nameof(mSOutlookReplyToEmailbodyContainsStoredPassword), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/MSOutlook/ReplyToEmail";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSOutlookReplyToEmail = new JObject();
                var mSOutlookReplyToEmailpropCount = 0;
                mSOutlookReplyToEmailpropCount++;
                mSOutlookReplyToEmail["EntryID"] = ExpressionConverter.ConvertO(__workflow_mSOutlookReplyToEmailentryID);
                if (__workflow_mSOutlookReplyToEmailreplyToAll != null)
                {
                    if (__workflow_mSOutlookReplyToEmailreplyToAll != null)
                    {
                        mSOutlookReplyToEmail["ReplyToAll"] = ExpressionConverter.ConvertO(__workflow_mSOutlookReplyToEmailreplyToAll);
                        mSOutlookReplyToEmailpropCount++;
                    }

                    mSOutlookReplyToEmailpropCount++;
                }
                else
                {
                    mSOutlookReplyToEmail["ReplyToAll"] = false;
                    mSOutlookReplyToEmailpropCount++;
                }

                if (__workflow_mSOutlookReplyToEmailbodyFormat != null)
                {
                    mSOutlookReplyToEmail["BodyFormat"] = ExpressionConverter.ConvertO(__workflow_mSOutlookReplyToEmailbodyFormat);
                    mSOutlookReplyToEmailpropCount++;
                }

                if (__workflow_mSOutlookReplyToEmailbody != null)
                {
                    mSOutlookReplyToEmail["Body"] = ExpressionConverter.ConvertO(__workflow_mSOutlookReplyToEmailbody);
                    mSOutlookReplyToEmailpropCount++;
                }

                if (__workflow_mSOutlookReplyToEmailhTMLBody != null)
                {
                    mSOutlookReplyToEmail["HTMLBody"] = ExpressionConverter.ConvertO(__workflow_mSOutlookReplyToEmailhTMLBody);
                    mSOutlookReplyToEmailpropCount++;
                }

                if (__workflow_mSOutlookReplyToEmailrTFBody != null)
                {
                    mSOutlookReplyToEmail["RTFBody"] = ExpressionConverter.ConvertO(__workflow_mSOutlookReplyToEmailrTFBody);
                    mSOutlookReplyToEmailpropCount++;
                }

                if (__workflow_mSOutlookReplyToEmailattachmentFilenamesJSON != null)
                {
                    mSOutlookReplyToEmail["AttachmentFilenamesJSON"] = ExpressionConverter.ConvertO(__workflow_mSOutlookReplyToEmailattachmentFilenamesJSON);
                    mSOutlookReplyToEmailpropCount++;
                }

                if (__workflow_mSOutlookReplyToEmaildontSendIfAttachmentFilenameMissing != null)
                {
                    if (__workflow_mSOutlookReplyToEmaildontSendIfAttachmentFilenameMissing != null)
                    {
                        mSOutlookReplyToEmail["DontSendIfAttachmentFilenameMissing"] = ExpressionConverter.ConvertO(__workflow_mSOutlookReplyToEmaildontSendIfAttachmentFilenameMissing);
                        mSOutlookReplyToEmailpropCount++;
                    }

                    mSOutlookReplyToEmailpropCount++;
                }
                else
                {
                    mSOutlookReplyToEmail["DontSendIfAttachmentFilenameMissing"] = false;
                    mSOutlookReplyToEmailpropCount++;
                }

                if (__workflow_mSOutlookReplyToEmailclickAllowButtonIfRequired != null)
                {
                    if (__workflow_mSOutlookReplyToEmailclickAllowButtonIfRequired != null)
                    {
                        mSOutlookReplyToEmail["ClickAllowButtonIfRequired"] = ExpressionConverter.ConvertO(__workflow_mSOutlookReplyToEmailclickAllowButtonIfRequired);
                        mSOutlookReplyToEmailpropCount++;
                    }

                    mSOutlookReplyToEmailpropCount++;
                }
                else
                {
                    mSOutlookReplyToEmail["ClickAllowButtonIfRequired"] = true;
                    mSOutlookReplyToEmailpropCount++;
                }

                if (__workflow_mSOutlookReplyToEmailvotingOptions != null)
                {
                    mSOutlookReplyToEmail["VotingOptions"] = ExpressionConverter.ConvertO(__workflow_mSOutlookReplyToEmailvotingOptions);
                    mSOutlookReplyToEmailpropCount++;
                }

                if (__workflow_mSOutlookReplyToEmailsendAsSMTPAddress != null)
                {
                    mSOutlookReplyToEmail["SendAsSMTPAddress"] = ExpressionConverter.ConvertO(__workflow_mSOutlookReplyToEmailsendAsSMTPAddress);
                    mSOutlookReplyToEmailpropCount++;
                }

                if (__workflow_mSOutlookReplyToEmailbodyContainsStoredPassword != null)
                {
                    if (__workflow_mSOutlookReplyToEmailbodyContainsStoredPassword != null)
                    {
                        mSOutlookReplyToEmail["BodyContainsStoredPassword"] = ExpressionConverter.ConvertO(__workflow_mSOutlookReplyToEmailbodyContainsStoredPassword);
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
                mSOutlookReplyToEmail["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSOutlookReplyToEmailworkflow);
                if (mSOutlookReplyToEmailpropCount > 0)
                {
                    callPayload.Body = mSOutlookReplyToEmail;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSOutlookForwardEmail(Expression<Func<string>> mSOutlookForwardEmailentryID, Expression<Func<string>> mSOutlookForwardEmailworkflow, Expression<Func<string>> mSOutlookForwardEmailto = null, Expression<Func<string>> mSOutlookForwardEmailcC = null, Expression<Func<string>> mSOutlookForwardEmailbCC = null, Expression<Func<bool>> mSOutlookForwardEmailoverrideSubject = null, Expression<Func<string>> mSOutlookForwardEmailsubject = null, Expression<Func<bool>> mSOutlookForwardEmailoverrideBody = null, Expression<Func<mSOutlookForwardEmailbodyFormatInput>> mSOutlookForwardEmailbodyFormat = null, Expression<Func<string>> mSOutlookForwardEmailbody = null, Expression<Func<string>> mSOutlookForwardEmailhTMLBody = null, Expression<Func<string>> mSOutlookForwardEmailrTFBody = null, Expression<Func<bool>> mSOutlookForwardEmailclickAllowButtonIfRequired = null, Expression<Func<string>> mSOutlookForwardEmailvotingOptions = null, Expression<Func<string>> mSOutlookForwardEmailsendAsSMTPAddress = null, Expression<Func<bool>> mSOutlookForwardEmailincludeExistingHiddenAttachments = null, Expression<Func<bool>> mSOutlookForwardEmailincludeExistingVisibleAttachments = null, Expression<Func<string>> mSOutlookForwardEmailattachmentFilenamesJSON = null, Expression<Func<bool>> mSOutlookForwardEmaildontSendIfAttachmentFilenameMissing = null, Expression<Func<bool>> mSOutlookForwardEmailbodyContainsStoredPassword = null)
        {
            var __workflow_mSOutlookForwardEmailentryID = mSOutlookForwardEmailentryID == null ? null : WorkflowExpression.Compile(mSOutlookForwardEmailentryID);
            WorkflowExpression.Validate(__workflow_mSOutlookForwardEmailentryID, nameof(mSOutlookForwardEmailentryID), required: true);
            var __workflow_mSOutlookForwardEmailworkflow = mSOutlookForwardEmailworkflow == null ? null : WorkflowExpression.Compile(mSOutlookForwardEmailworkflow);
            WorkflowExpression.Validate(__workflow_mSOutlookForwardEmailworkflow, nameof(mSOutlookForwardEmailworkflow), required: true);
            var __workflow_mSOutlookForwardEmailto = mSOutlookForwardEmailto == null ? null : WorkflowExpression.Compile(mSOutlookForwardEmailto);
            WorkflowExpression.Validate(__workflow_mSOutlookForwardEmailto, nameof(mSOutlookForwardEmailto), required: false);
            var __workflow_mSOutlookForwardEmailcC = mSOutlookForwardEmailcC == null ? null : WorkflowExpression.Compile(mSOutlookForwardEmailcC);
            WorkflowExpression.Validate(__workflow_mSOutlookForwardEmailcC, nameof(mSOutlookForwardEmailcC), required: false);
            var __workflow_mSOutlookForwardEmailbCC = mSOutlookForwardEmailbCC == null ? null : WorkflowExpression.Compile(mSOutlookForwardEmailbCC);
            WorkflowExpression.Validate(__workflow_mSOutlookForwardEmailbCC, nameof(mSOutlookForwardEmailbCC), required: false);
            var __workflow_mSOutlookForwardEmailoverrideSubject = mSOutlookForwardEmailoverrideSubject == null ? null : WorkflowExpression.Compile(mSOutlookForwardEmailoverrideSubject);
            WorkflowExpression.Validate(__workflow_mSOutlookForwardEmailoverrideSubject, nameof(mSOutlookForwardEmailoverrideSubject), required: false);
            var __workflow_mSOutlookForwardEmailsubject = mSOutlookForwardEmailsubject == null ? null : WorkflowExpression.Compile(mSOutlookForwardEmailsubject);
            WorkflowExpression.Validate(__workflow_mSOutlookForwardEmailsubject, nameof(mSOutlookForwardEmailsubject), required: false);
            var __workflow_mSOutlookForwardEmailoverrideBody = mSOutlookForwardEmailoverrideBody == null ? null : WorkflowExpression.Compile(mSOutlookForwardEmailoverrideBody);
            WorkflowExpression.Validate(__workflow_mSOutlookForwardEmailoverrideBody, nameof(mSOutlookForwardEmailoverrideBody), required: false);
            var __workflow_mSOutlookForwardEmailbodyFormat = mSOutlookForwardEmailbodyFormat == null ? null : WorkflowExpression.Compile(mSOutlookForwardEmailbodyFormat);
            WorkflowExpression.Validate(__workflow_mSOutlookForwardEmailbodyFormat, nameof(mSOutlookForwardEmailbodyFormat), required: false);
            var __workflow_mSOutlookForwardEmailbody = mSOutlookForwardEmailbody == null ? null : WorkflowExpression.Compile(mSOutlookForwardEmailbody);
            WorkflowExpression.Validate(__workflow_mSOutlookForwardEmailbody, nameof(mSOutlookForwardEmailbody), required: false);
            var __workflow_mSOutlookForwardEmailhTMLBody = mSOutlookForwardEmailhTMLBody == null ? null : WorkflowExpression.Compile(mSOutlookForwardEmailhTMLBody);
            WorkflowExpression.Validate(__workflow_mSOutlookForwardEmailhTMLBody, nameof(mSOutlookForwardEmailhTMLBody), required: false);
            var __workflow_mSOutlookForwardEmailrTFBody = mSOutlookForwardEmailrTFBody == null ? null : WorkflowExpression.Compile(mSOutlookForwardEmailrTFBody);
            WorkflowExpression.Validate(__workflow_mSOutlookForwardEmailrTFBody, nameof(mSOutlookForwardEmailrTFBody), required: false);
            var __workflow_mSOutlookForwardEmailclickAllowButtonIfRequired = mSOutlookForwardEmailclickAllowButtonIfRequired == null ? null : WorkflowExpression.Compile(mSOutlookForwardEmailclickAllowButtonIfRequired);
            WorkflowExpression.Validate(__workflow_mSOutlookForwardEmailclickAllowButtonIfRequired, nameof(mSOutlookForwardEmailclickAllowButtonIfRequired), required: false);
            var __workflow_mSOutlookForwardEmailvotingOptions = mSOutlookForwardEmailvotingOptions == null ? null : WorkflowExpression.Compile(mSOutlookForwardEmailvotingOptions);
            WorkflowExpression.Validate(__workflow_mSOutlookForwardEmailvotingOptions, nameof(mSOutlookForwardEmailvotingOptions), required: false);
            var __workflow_mSOutlookForwardEmailsendAsSMTPAddress = mSOutlookForwardEmailsendAsSMTPAddress == null ? null : WorkflowExpression.Compile(mSOutlookForwardEmailsendAsSMTPAddress);
            WorkflowExpression.Validate(__workflow_mSOutlookForwardEmailsendAsSMTPAddress, nameof(mSOutlookForwardEmailsendAsSMTPAddress), required: false);
            var __workflow_mSOutlookForwardEmailincludeExistingHiddenAttachments = mSOutlookForwardEmailincludeExistingHiddenAttachments == null ? null : WorkflowExpression.Compile(mSOutlookForwardEmailincludeExistingHiddenAttachments);
            WorkflowExpression.Validate(__workflow_mSOutlookForwardEmailincludeExistingHiddenAttachments, nameof(mSOutlookForwardEmailincludeExistingHiddenAttachments), required: false);
            var __workflow_mSOutlookForwardEmailincludeExistingVisibleAttachments = mSOutlookForwardEmailincludeExistingVisibleAttachments == null ? null : WorkflowExpression.Compile(mSOutlookForwardEmailincludeExistingVisibleAttachments);
            WorkflowExpression.Validate(__workflow_mSOutlookForwardEmailincludeExistingVisibleAttachments, nameof(mSOutlookForwardEmailincludeExistingVisibleAttachments), required: false);
            var __workflow_mSOutlookForwardEmailattachmentFilenamesJSON = mSOutlookForwardEmailattachmentFilenamesJSON == null ? null : WorkflowExpression.Compile(mSOutlookForwardEmailattachmentFilenamesJSON);
            WorkflowExpression.Validate(__workflow_mSOutlookForwardEmailattachmentFilenamesJSON, nameof(mSOutlookForwardEmailattachmentFilenamesJSON), required: false);
            var __workflow_mSOutlookForwardEmaildontSendIfAttachmentFilenameMissing = mSOutlookForwardEmaildontSendIfAttachmentFilenameMissing == null ? null : WorkflowExpression.Compile(mSOutlookForwardEmaildontSendIfAttachmentFilenameMissing);
            WorkflowExpression.Validate(__workflow_mSOutlookForwardEmaildontSendIfAttachmentFilenameMissing, nameof(mSOutlookForwardEmaildontSendIfAttachmentFilenameMissing), required: false);
            var __workflow_mSOutlookForwardEmailbodyContainsStoredPassword = mSOutlookForwardEmailbodyContainsStoredPassword == null ? null : WorkflowExpression.Compile(mSOutlookForwardEmailbodyContainsStoredPassword);
            WorkflowExpression.Validate(__workflow_mSOutlookForwardEmailbodyContainsStoredPassword, nameof(mSOutlookForwardEmailbodyContainsStoredPassword), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/MSOutlook/MSOutlookForwardEmail";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSOutlookForwardEmail = new JObject();
                var mSOutlookForwardEmailpropCount = 0;
                mSOutlookForwardEmailpropCount++;
                mSOutlookForwardEmail["EntryID"] = ExpressionConverter.ConvertO(__workflow_mSOutlookForwardEmailentryID);
                if (__workflow_mSOutlookForwardEmailto != null)
                {
                    mSOutlookForwardEmail["To"] = ExpressionConverter.ConvertO(__workflow_mSOutlookForwardEmailto);
                    mSOutlookForwardEmailpropCount++;
                }

                if (__workflow_mSOutlookForwardEmailcC != null)
                {
                    mSOutlookForwardEmail["CC"] = ExpressionConverter.ConvertO(__workflow_mSOutlookForwardEmailcC);
                    mSOutlookForwardEmailpropCount++;
                }

                if (__workflow_mSOutlookForwardEmailbCC != null)
                {
                    mSOutlookForwardEmail["BCC"] = ExpressionConverter.ConvertO(__workflow_mSOutlookForwardEmailbCC);
                    mSOutlookForwardEmailpropCount++;
                }

                if (__workflow_mSOutlookForwardEmailoverrideSubject != null)
                {
                    if (__workflow_mSOutlookForwardEmailoverrideSubject != null)
                    {
                        mSOutlookForwardEmail["OverrideSubject"] = ExpressionConverter.ConvertO(__workflow_mSOutlookForwardEmailoverrideSubject);
                        mSOutlookForwardEmailpropCount++;
                    }

                    mSOutlookForwardEmailpropCount++;
                }
                else
                {
                    mSOutlookForwardEmail["OverrideSubject"] = false;
                    mSOutlookForwardEmailpropCount++;
                }

                if (__workflow_mSOutlookForwardEmailsubject != null)
                {
                    mSOutlookForwardEmail["Subject"] = ExpressionConverter.ConvertO(__workflow_mSOutlookForwardEmailsubject);
                    mSOutlookForwardEmailpropCount++;
                }

                if (__workflow_mSOutlookForwardEmailoverrideBody != null)
                {
                    if (__workflow_mSOutlookForwardEmailoverrideBody != null)
                    {
                        mSOutlookForwardEmail["OverrideBody"] = ExpressionConverter.ConvertO(__workflow_mSOutlookForwardEmailoverrideBody);
                        mSOutlookForwardEmailpropCount++;
                    }

                    mSOutlookForwardEmailpropCount++;
                }
                else
                {
                    mSOutlookForwardEmail["OverrideBody"] = false;
                    mSOutlookForwardEmailpropCount++;
                }

                if (__workflow_mSOutlookForwardEmailbodyFormat != null)
                {
                    mSOutlookForwardEmail["BodyFormat"] = ExpressionConverter.ConvertO(__workflow_mSOutlookForwardEmailbodyFormat);
                    mSOutlookForwardEmailpropCount++;
                }

                if (__workflow_mSOutlookForwardEmailbody != null)
                {
                    mSOutlookForwardEmail["Body"] = ExpressionConverter.ConvertO(__workflow_mSOutlookForwardEmailbody);
                    mSOutlookForwardEmailpropCount++;
                }

                if (__workflow_mSOutlookForwardEmailhTMLBody != null)
                {
                    mSOutlookForwardEmail["HTMLBody"] = ExpressionConverter.ConvertO(__workflow_mSOutlookForwardEmailhTMLBody);
                    mSOutlookForwardEmailpropCount++;
                }

                if (__workflow_mSOutlookForwardEmailrTFBody != null)
                {
                    mSOutlookForwardEmail["RTFBody"] = ExpressionConverter.ConvertO(__workflow_mSOutlookForwardEmailrTFBody);
                    mSOutlookForwardEmailpropCount++;
                }

                if (__workflow_mSOutlookForwardEmailclickAllowButtonIfRequired != null)
                {
                    if (__workflow_mSOutlookForwardEmailclickAllowButtonIfRequired != null)
                    {
                        mSOutlookForwardEmail["ClickAllowButtonIfRequired"] = ExpressionConverter.ConvertO(__workflow_mSOutlookForwardEmailclickAllowButtonIfRequired);
                        mSOutlookForwardEmailpropCount++;
                    }

                    mSOutlookForwardEmailpropCount++;
                }
                else
                {
                    mSOutlookForwardEmail["ClickAllowButtonIfRequired"] = true;
                    mSOutlookForwardEmailpropCount++;
                }

                if (__workflow_mSOutlookForwardEmailvotingOptions != null)
                {
                    mSOutlookForwardEmail["VotingOptions"] = ExpressionConverter.ConvertO(__workflow_mSOutlookForwardEmailvotingOptions);
                    mSOutlookForwardEmailpropCount++;
                }

                if (__workflow_mSOutlookForwardEmailsendAsSMTPAddress != null)
                {
                    mSOutlookForwardEmail["SendAsSMTPAddress"] = ExpressionConverter.ConvertO(__workflow_mSOutlookForwardEmailsendAsSMTPAddress);
                    mSOutlookForwardEmailpropCount++;
                }

                if (__workflow_mSOutlookForwardEmailincludeExistingHiddenAttachments != null)
                {
                    if (__workflow_mSOutlookForwardEmailincludeExistingHiddenAttachments != null)
                    {
                        mSOutlookForwardEmail["IncludeExistingHiddenAttachments"] = ExpressionConverter.ConvertO(__workflow_mSOutlookForwardEmailincludeExistingHiddenAttachments);
                        mSOutlookForwardEmailpropCount++;
                    }

                    mSOutlookForwardEmailpropCount++;
                }
                else
                {
                    mSOutlookForwardEmail["IncludeExistingHiddenAttachments"] = false;
                    mSOutlookForwardEmailpropCount++;
                }

                if (__workflow_mSOutlookForwardEmailincludeExistingVisibleAttachments != null)
                {
                    if (__workflow_mSOutlookForwardEmailincludeExistingVisibleAttachments != null)
                    {
                        mSOutlookForwardEmail["IncludeExistingVisibleAttachments"] = ExpressionConverter.ConvertO(__workflow_mSOutlookForwardEmailincludeExistingVisibleAttachments);
                        mSOutlookForwardEmailpropCount++;
                    }

                    mSOutlookForwardEmailpropCount++;
                }
                else
                {
                    mSOutlookForwardEmail["IncludeExistingVisibleAttachments"] = false;
                    mSOutlookForwardEmailpropCount++;
                }

                if (__workflow_mSOutlookForwardEmailattachmentFilenamesJSON != null)
                {
                    mSOutlookForwardEmail["AttachmentFilenamesJSON"] = ExpressionConverter.ConvertO(__workflow_mSOutlookForwardEmailattachmentFilenamesJSON);
                    mSOutlookForwardEmailpropCount++;
                }

                if (__workflow_mSOutlookForwardEmaildontSendIfAttachmentFilenameMissing != null)
                {
                    if (__workflow_mSOutlookForwardEmaildontSendIfAttachmentFilenameMissing != null)
                    {
                        mSOutlookForwardEmail["DontSendIfAttachmentFilenameMissing"] = ExpressionConverter.ConvertO(__workflow_mSOutlookForwardEmaildontSendIfAttachmentFilenameMissing);
                        mSOutlookForwardEmailpropCount++;
                    }

                    mSOutlookForwardEmailpropCount++;
                }
                else
                {
                    mSOutlookForwardEmail["DontSendIfAttachmentFilenameMissing"] = false;
                    mSOutlookForwardEmailpropCount++;
                }

                if (__workflow_mSOutlookForwardEmailbodyContainsStoredPassword != null)
                {
                    if (__workflow_mSOutlookForwardEmailbodyContainsStoredPassword != null)
                    {
                        mSOutlookForwardEmail["BodyContainsStoredPassword"] = ExpressionConverter.ConvertO(__workflow_mSOutlookForwardEmailbodyContainsStoredPassword);
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
                mSOutlookForwardEmail["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSOutlookForwardEmailworkflow);
                if (mSOutlookForwardEmailpropCount > 0)
                {
                    callPayload.Body = mSOutlookForwardEmail;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookGetMAPIProfilesResponse> MSOutlookGetMAPIProfiles(Expression<Func<string>> mSOutlookGetMAPIProfilesworkflow)
        {
            var __workflow_mSOutlookGetMAPIProfilesworkflow = mSOutlookGetMAPIProfilesworkflow == null ? null : WorkflowExpression.Compile(mSOutlookGetMAPIProfilesworkflow);
            WorkflowExpression.Validate(__workflow_mSOutlookGetMAPIProfilesworkflow, nameof(mSOutlookGetMAPIProfilesworkflow), required: true);
            return new DeferredBodyAction<MSOutlookGetMAPIProfilesResponse>(() =>
            {
                var apiCallPath = "/MSOutlook/GetMAPIProfiles";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSOutlookGetMAPIProfiles = new JObject();
                var mSOutlookGetMAPIProfilespropCount = 0;
                mSOutlookGetMAPIProfilespropCount++;
                mSOutlookGetMAPIProfiles["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSOutlookGetMAPIProfilesworkflow);
                if (mSOutlookGetMAPIProfilespropCount > 0)
                {
                    callPayload.Body = mSOutlookGetMAPIProfiles;
                }

                return new ApiConnectionAction<MSOutlookGetMAPIProfilesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookGetOutlookProcessIdResponse> MSOutlookGetOutlookProcessId(Expression<Func<string>> mSOutlookGetOutlookProcessIdworkflow)
        {
            var __workflow_mSOutlookGetOutlookProcessIdworkflow = mSOutlookGetOutlookProcessIdworkflow == null ? null : WorkflowExpression.Compile(mSOutlookGetOutlookProcessIdworkflow);
            WorkflowExpression.Validate(__workflow_mSOutlookGetOutlookProcessIdworkflow, nameof(mSOutlookGetOutlookProcessIdworkflow), required: true);
            return new DeferredBodyAction<MSOutlookGetOutlookProcessIdResponse>(() =>
            {
                var apiCallPath = "/MSOutlook/GetOutlookProcessId";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSOutlookGetOutlookProcessId = new JObject();
                var mSOutlookGetOutlookProcessIdpropCount = 0;
                mSOutlookGetOutlookProcessIdpropCount++;
                mSOutlookGetOutlookProcessId["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSOutlookGetOutlookProcessIdworkflow);
                if (mSOutlookGetOutlookProcessIdpropCount > 0)
                {
                    callPayload.Body = mSOutlookGetOutlookProcessId;
                }

                return new ApiConnectionAction<MSOutlookGetOutlookProcessIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSOutlookBackgroundMonitorForAllowPopup(Expression<Func<string>> mSOutlookBackgroundMonitorForAllowPopupworkflow, Expression<Func<int>> mSOutlookBackgroundMonitorForAllowPopupsecondsToWaitForDialog = null, Expression<Func<int>> mSOutlookBackgroundMonitorForAllowPopupsecondsToWaitForAllowButton = null, Expression<Func<int>> mSOutlookBackgroundMonitorForAllowPopupsecondsToWaitForAllowButtonToBeEnabled = null, Expression<Func<string>> mSOutlookBackgroundMonitorForAllowPopupoutlookAllowButtonName = null)
        {
            var __workflow_mSOutlookBackgroundMonitorForAllowPopupworkflow = mSOutlookBackgroundMonitorForAllowPopupworkflow == null ? null : WorkflowExpression.Compile(mSOutlookBackgroundMonitorForAllowPopupworkflow);
            WorkflowExpression.Validate(__workflow_mSOutlookBackgroundMonitorForAllowPopupworkflow, nameof(mSOutlookBackgroundMonitorForAllowPopupworkflow), required: true);
            var __workflow_mSOutlookBackgroundMonitorForAllowPopupsecondsToWaitForDialog = mSOutlookBackgroundMonitorForAllowPopupsecondsToWaitForDialog == null ? null : WorkflowExpression.Compile(mSOutlookBackgroundMonitorForAllowPopupsecondsToWaitForDialog);
            WorkflowExpression.Validate(__workflow_mSOutlookBackgroundMonitorForAllowPopupsecondsToWaitForDialog, nameof(mSOutlookBackgroundMonitorForAllowPopupsecondsToWaitForDialog), required: false);
            var __workflow_mSOutlookBackgroundMonitorForAllowPopupsecondsToWaitForAllowButton = mSOutlookBackgroundMonitorForAllowPopupsecondsToWaitForAllowButton == null ? null : WorkflowExpression.Compile(mSOutlookBackgroundMonitorForAllowPopupsecondsToWaitForAllowButton);
            WorkflowExpression.Validate(__workflow_mSOutlookBackgroundMonitorForAllowPopupsecondsToWaitForAllowButton, nameof(mSOutlookBackgroundMonitorForAllowPopupsecondsToWaitForAllowButton), required: false);
            var __workflow_mSOutlookBackgroundMonitorForAllowPopupsecondsToWaitForAllowButtonToBeEnabled = mSOutlookBackgroundMonitorForAllowPopupsecondsToWaitForAllowButtonToBeEnabled == null ? null : WorkflowExpression.Compile(mSOutlookBackgroundMonitorForAllowPopupsecondsToWaitForAllowButtonToBeEnabled);
            WorkflowExpression.Validate(__workflow_mSOutlookBackgroundMonitorForAllowPopupsecondsToWaitForAllowButtonToBeEnabled, nameof(mSOutlookBackgroundMonitorForAllowPopupsecondsToWaitForAllowButtonToBeEnabled), required: false);
            var __workflow_mSOutlookBackgroundMonitorForAllowPopupoutlookAllowButtonName = mSOutlookBackgroundMonitorForAllowPopupoutlookAllowButtonName == null ? null : WorkflowExpression.Compile(mSOutlookBackgroundMonitorForAllowPopupoutlookAllowButtonName);
            WorkflowExpression.Validate(__workflow_mSOutlookBackgroundMonitorForAllowPopupoutlookAllowButtonName, nameof(mSOutlookBackgroundMonitorForAllowPopupoutlookAllowButtonName), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/MSOutlook/BackgroundMonitorForAllowPopup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSOutlookBackgroundMonitorForAllowPopup = new JObject();
                var mSOutlookBackgroundMonitorForAllowPopuppropCount = 0;
                if (__workflow_mSOutlookBackgroundMonitorForAllowPopupsecondsToWaitForDialog != null)
                {
                    if (__workflow_mSOutlookBackgroundMonitorForAllowPopupsecondsToWaitForDialog != null)
                    {
                        mSOutlookBackgroundMonitorForAllowPopup["SecondsToWaitForDialog"] = ExpressionConverter.ConvertO(__workflow_mSOutlookBackgroundMonitorForAllowPopupsecondsToWaitForDialog);
                        mSOutlookBackgroundMonitorForAllowPopuppropCount++;
                    }

                    mSOutlookBackgroundMonitorForAllowPopuppropCount++;
                }
                else
                {
                    mSOutlookBackgroundMonitorForAllowPopup["SecondsToWaitForDialog"] = 10;
                    mSOutlookBackgroundMonitorForAllowPopuppropCount++;
                }

                if (__workflow_mSOutlookBackgroundMonitorForAllowPopupsecondsToWaitForAllowButton != null)
                {
                    if (__workflow_mSOutlookBackgroundMonitorForAllowPopupsecondsToWaitForAllowButton != null)
                    {
                        mSOutlookBackgroundMonitorForAllowPopup["SecondsToWaitForAllowButton"] = ExpressionConverter.ConvertO(__workflow_mSOutlookBackgroundMonitorForAllowPopupsecondsToWaitForAllowButton);
                        mSOutlookBackgroundMonitorForAllowPopuppropCount++;
                    }

                    mSOutlookBackgroundMonitorForAllowPopuppropCount++;
                }
                else
                {
                    mSOutlookBackgroundMonitorForAllowPopup["SecondsToWaitForAllowButton"] = 10;
                    mSOutlookBackgroundMonitorForAllowPopuppropCount++;
                }

                if (__workflow_mSOutlookBackgroundMonitorForAllowPopupsecondsToWaitForAllowButtonToBeEnabled != null)
                {
                    if (__workflow_mSOutlookBackgroundMonitorForAllowPopupsecondsToWaitForAllowButtonToBeEnabled != null)
                    {
                        mSOutlookBackgroundMonitorForAllowPopup["SecondsToWaitForAllowButtonToBeEnabled"] = ExpressionConverter.ConvertO(__workflow_mSOutlookBackgroundMonitorForAllowPopupsecondsToWaitForAllowButtonToBeEnabled);
                        mSOutlookBackgroundMonitorForAllowPopuppropCount++;
                    }

                    mSOutlookBackgroundMonitorForAllowPopuppropCount++;
                }
                else
                {
                    mSOutlookBackgroundMonitorForAllowPopup["SecondsToWaitForAllowButtonToBeEnabled"] = 10;
                    mSOutlookBackgroundMonitorForAllowPopuppropCount++;
                }

                if (__workflow_mSOutlookBackgroundMonitorForAllowPopupoutlookAllowButtonName != null)
                {
                    if (__workflow_mSOutlookBackgroundMonitorForAllowPopupoutlookAllowButtonName != null)
                    {
                        mSOutlookBackgroundMonitorForAllowPopup["OutlookAllowButtonName"] = ExpressionConverter.ConvertO(__workflow_mSOutlookBackgroundMonitorForAllowPopupoutlookAllowButtonName);
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
                mSOutlookBackgroundMonitorForAllowPopup["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSOutlookBackgroundMonitorForAllowPopupworkflow);
                if (mSOutlookBackgroundMonitorForAllowPopuppropCount > 0)
                {
                    callPayload.Body = mSOutlookBackgroundMonitorForAllowPopup;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSOutlookSetAllowPopupDetails(Expression<Func<string>> mSOutlookSetAllowPopupDetailsworkflow, Expression<Func<string>> mSOutlookSetAllowPopupDetailsoutlookAllowButtonName = null, Expression<Func<string>> mSOutlookSetAllowPopupDetailsoutlookAllowButtonAutomationId = null, Expression<Func<string>> mSOutlookSetAllowPopupDetailsoutlookAllowCheckboxAutomationId = null)
        {
            var __workflow_mSOutlookSetAllowPopupDetailsworkflow = mSOutlookSetAllowPopupDetailsworkflow == null ? null : WorkflowExpression.Compile(mSOutlookSetAllowPopupDetailsworkflow);
            WorkflowExpression.Validate(__workflow_mSOutlookSetAllowPopupDetailsworkflow, nameof(mSOutlookSetAllowPopupDetailsworkflow), required: true);
            var __workflow_mSOutlookSetAllowPopupDetailsoutlookAllowButtonName = mSOutlookSetAllowPopupDetailsoutlookAllowButtonName == null ? null : WorkflowExpression.Compile(mSOutlookSetAllowPopupDetailsoutlookAllowButtonName);
            WorkflowExpression.Validate(__workflow_mSOutlookSetAllowPopupDetailsoutlookAllowButtonName, nameof(mSOutlookSetAllowPopupDetailsoutlookAllowButtonName), required: false);
            var __workflow_mSOutlookSetAllowPopupDetailsoutlookAllowButtonAutomationId = mSOutlookSetAllowPopupDetailsoutlookAllowButtonAutomationId == null ? null : WorkflowExpression.Compile(mSOutlookSetAllowPopupDetailsoutlookAllowButtonAutomationId);
            WorkflowExpression.Validate(__workflow_mSOutlookSetAllowPopupDetailsoutlookAllowButtonAutomationId, nameof(mSOutlookSetAllowPopupDetailsoutlookAllowButtonAutomationId), required: false);
            var __workflow_mSOutlookSetAllowPopupDetailsoutlookAllowCheckboxAutomationId = mSOutlookSetAllowPopupDetailsoutlookAllowCheckboxAutomationId == null ? null : WorkflowExpression.Compile(mSOutlookSetAllowPopupDetailsoutlookAllowCheckboxAutomationId);
            WorkflowExpression.Validate(__workflow_mSOutlookSetAllowPopupDetailsoutlookAllowCheckboxAutomationId, nameof(mSOutlookSetAllowPopupDetailsoutlookAllowCheckboxAutomationId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/MSOutlook/MSOutlookSetAllowPopupDetails";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSOutlookSetAllowPopupDetails = new JObject();
                var mSOutlookSetAllowPopupDetailspropCount = 0;
                if (__workflow_mSOutlookSetAllowPopupDetailsoutlookAllowButtonName != null)
                {
                    if (__workflow_mSOutlookSetAllowPopupDetailsoutlookAllowButtonName != null)
                    {
                        mSOutlookSetAllowPopupDetails["OutlookAllowButtonName"] = ExpressionConverter.ConvertO(__workflow_mSOutlookSetAllowPopupDetailsoutlookAllowButtonName);
                        mSOutlookSetAllowPopupDetailspropCount++;
                    }

                    mSOutlookSetAllowPopupDetailspropCount++;
                }
                else
                {
                    mSOutlookSetAllowPopupDetails["OutlookAllowButtonName"] = "Allow";
                    mSOutlookSetAllowPopupDetailspropCount++;
                }

                if (__workflow_mSOutlookSetAllowPopupDetailsoutlookAllowButtonAutomationId != null)
                {
                    if (__workflow_mSOutlookSetAllowPopupDetailsoutlookAllowButtonAutomationId != null)
                    {
                        mSOutlookSetAllowPopupDetails["OutlookAllowButtonAutomationId"] = ExpressionConverter.ConvertO(__workflow_mSOutlookSetAllowPopupDetailsoutlookAllowButtonAutomationId);
                        mSOutlookSetAllowPopupDetailspropCount++;
                    }

                    mSOutlookSetAllowPopupDetailspropCount++;
                }
                else
                {
                    mSOutlookSetAllowPopupDetails["OutlookAllowButtonAutomationId"] = "4774";
                    mSOutlookSetAllowPopupDetailspropCount++;
                }

                if (__workflow_mSOutlookSetAllowPopupDetailsoutlookAllowCheckboxAutomationId != null)
                {
                    if (__workflow_mSOutlookSetAllowPopupDetailsoutlookAllowCheckboxAutomationId != null)
                    {
                        mSOutlookSetAllowPopupDetails["OutlookAllowCheckboxAutomationId"] = ExpressionConverter.ConvertO(__workflow_mSOutlookSetAllowPopupDetailsoutlookAllowCheckboxAutomationId);
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
                mSOutlookSetAllowPopupDetails["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSOutlookSetAllowPopupDetailsworkflow);
                if (mSOutlookSetAllowPopupDetailspropCount > 0)
                {
                    callPayload.Body = mSOutlookSetAllowPopupDetails;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookExecuteCommandBarObjectResponse> MSOutlookExecuteCommandBarObject(Expression<Func<string>> mSOutlookExecuteCommandBarObjectobjectId, Expression<Func<string>> mSOutlookExecuteCommandBarObjectworkflow, Expression<Func<bool>> mSOutlookExecuteCommandBarObjectrunInBackground = null)
        {
            var __workflow_mSOutlookExecuteCommandBarObjectobjectId = mSOutlookExecuteCommandBarObjectobjectId == null ? null : WorkflowExpression.Compile(mSOutlookExecuteCommandBarObjectobjectId);
            WorkflowExpression.Validate(__workflow_mSOutlookExecuteCommandBarObjectobjectId, nameof(mSOutlookExecuteCommandBarObjectobjectId), required: true);
            var __workflow_mSOutlookExecuteCommandBarObjectworkflow = mSOutlookExecuteCommandBarObjectworkflow == null ? null : WorkflowExpression.Compile(mSOutlookExecuteCommandBarObjectworkflow);
            WorkflowExpression.Validate(__workflow_mSOutlookExecuteCommandBarObjectworkflow, nameof(mSOutlookExecuteCommandBarObjectworkflow), required: true);
            var __workflow_mSOutlookExecuteCommandBarObjectrunInBackground = mSOutlookExecuteCommandBarObjectrunInBackground == null ? null : WorkflowExpression.Compile(mSOutlookExecuteCommandBarObjectrunInBackground);
            WorkflowExpression.Validate(__workflow_mSOutlookExecuteCommandBarObjectrunInBackground, nameof(mSOutlookExecuteCommandBarObjectrunInBackground), required: false);
            return new DeferredBodyAction<MSOutlookExecuteCommandBarObjectResponse>(() =>
            {
                var apiCallPath = "/MSOutlook/MSOutlookExecuteCommandBarObject";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSOutlookExecuteCommandBarObject = new JObject();
                var mSOutlookExecuteCommandBarObjectpropCount = 0;
                mSOutlookExecuteCommandBarObjectpropCount++;
                mSOutlookExecuteCommandBarObject["ObjectId"] = ExpressionConverter.ConvertO(__workflow_mSOutlookExecuteCommandBarObjectobjectId);
                if (__workflow_mSOutlookExecuteCommandBarObjectrunInBackground != null)
                {
                    if (__workflow_mSOutlookExecuteCommandBarObjectrunInBackground != null)
                    {
                        mSOutlookExecuteCommandBarObject["RunInBackground"] = ExpressionConverter.ConvertO(__workflow_mSOutlookExecuteCommandBarObjectrunInBackground);
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
                mSOutlookExecuteCommandBarObject["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSOutlookExecuteCommandBarObjectworkflow);
                if (mSOutlookExecuteCommandBarObjectpropCount > 0)
                {
                    callPayload.Body = mSOutlookExecuteCommandBarObject;
                }

                return new ApiConnectionAction<MSOutlookExecuteCommandBarObjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookGetEmailsResponse> MSOutlookGetEmails(Expression<Func<string>> mSOutlookGetEmailsworkflow, Expression<Func<string>> mSOutlookGetEmailsfolderPath = null, Expression<Func<bool>> mSOutlookGetEmailssearchRead = null, Expression<Func<bool>> mSOutlookGetEmailssearchUnread = null, Expression<Func<string>> mSOutlookGetEmailssearchSubject = null, Expression<Func<string>> mSOutlookGetEmailssearchFromSMTP = null, Expression<Func<string>> mSOutlookGetEmailssearchFromName = null, Expression<Func<string>> mSOutlookGetEmailssearchQuery = null, Expression<Func<int>> mSOutlookGetEmailssearchMaxAgeInDays = null, Expression<Func<string>> mSOutlookGetEmailssearchStartDateTimeAsString = null, Expression<Func<string>> mSOutlookGetEmailssearchEndDateTimeAsString = null, Expression<Func<int>> mSOutlookGetEmailsmaxResultsToReturn = null, Expression<Func<bool>> mSOutlookGetEmailsclickAllowButtonIfRequired = null)
        {
            var __workflow_mSOutlookGetEmailsworkflow = mSOutlookGetEmailsworkflow == null ? null : WorkflowExpression.Compile(mSOutlookGetEmailsworkflow);
            WorkflowExpression.Validate(__workflow_mSOutlookGetEmailsworkflow, nameof(mSOutlookGetEmailsworkflow), required: true);
            var __workflow_mSOutlookGetEmailsfolderPath = mSOutlookGetEmailsfolderPath == null ? null : WorkflowExpression.Compile(mSOutlookGetEmailsfolderPath);
            WorkflowExpression.Validate(__workflow_mSOutlookGetEmailsfolderPath, nameof(mSOutlookGetEmailsfolderPath), required: false);
            var __workflow_mSOutlookGetEmailssearchRead = mSOutlookGetEmailssearchRead == null ? null : WorkflowExpression.Compile(mSOutlookGetEmailssearchRead);
            WorkflowExpression.Validate(__workflow_mSOutlookGetEmailssearchRead, nameof(mSOutlookGetEmailssearchRead), required: false);
            var __workflow_mSOutlookGetEmailssearchUnread = mSOutlookGetEmailssearchUnread == null ? null : WorkflowExpression.Compile(mSOutlookGetEmailssearchUnread);
            WorkflowExpression.Validate(__workflow_mSOutlookGetEmailssearchUnread, nameof(mSOutlookGetEmailssearchUnread), required: false);
            var __workflow_mSOutlookGetEmailssearchSubject = mSOutlookGetEmailssearchSubject == null ? null : WorkflowExpression.Compile(mSOutlookGetEmailssearchSubject);
            WorkflowExpression.Validate(__workflow_mSOutlookGetEmailssearchSubject, nameof(mSOutlookGetEmailssearchSubject), required: false);
            var __workflow_mSOutlookGetEmailssearchFromSMTP = mSOutlookGetEmailssearchFromSMTP == null ? null : WorkflowExpression.Compile(mSOutlookGetEmailssearchFromSMTP);
            WorkflowExpression.Validate(__workflow_mSOutlookGetEmailssearchFromSMTP, nameof(mSOutlookGetEmailssearchFromSMTP), required: false);
            var __workflow_mSOutlookGetEmailssearchFromName = mSOutlookGetEmailssearchFromName == null ? null : WorkflowExpression.Compile(mSOutlookGetEmailssearchFromName);
            WorkflowExpression.Validate(__workflow_mSOutlookGetEmailssearchFromName, nameof(mSOutlookGetEmailssearchFromName), required: false);
            var __workflow_mSOutlookGetEmailssearchQuery = mSOutlookGetEmailssearchQuery == null ? null : WorkflowExpression.Compile(mSOutlookGetEmailssearchQuery);
            WorkflowExpression.Validate(__workflow_mSOutlookGetEmailssearchQuery, nameof(mSOutlookGetEmailssearchQuery), required: false);
            var __workflow_mSOutlookGetEmailssearchMaxAgeInDays = mSOutlookGetEmailssearchMaxAgeInDays == null ? null : WorkflowExpression.Compile(mSOutlookGetEmailssearchMaxAgeInDays);
            WorkflowExpression.Validate(__workflow_mSOutlookGetEmailssearchMaxAgeInDays, nameof(mSOutlookGetEmailssearchMaxAgeInDays), required: false);
            var __workflow_mSOutlookGetEmailssearchStartDateTimeAsString = mSOutlookGetEmailssearchStartDateTimeAsString == null ? null : WorkflowExpression.Compile(mSOutlookGetEmailssearchStartDateTimeAsString);
            WorkflowExpression.Validate(__workflow_mSOutlookGetEmailssearchStartDateTimeAsString, nameof(mSOutlookGetEmailssearchStartDateTimeAsString), required: false);
            var __workflow_mSOutlookGetEmailssearchEndDateTimeAsString = mSOutlookGetEmailssearchEndDateTimeAsString == null ? null : WorkflowExpression.Compile(mSOutlookGetEmailssearchEndDateTimeAsString);
            WorkflowExpression.Validate(__workflow_mSOutlookGetEmailssearchEndDateTimeAsString, nameof(mSOutlookGetEmailssearchEndDateTimeAsString), required: false);
            var __workflow_mSOutlookGetEmailsmaxResultsToReturn = mSOutlookGetEmailsmaxResultsToReturn == null ? null : WorkflowExpression.Compile(mSOutlookGetEmailsmaxResultsToReturn);
            WorkflowExpression.Validate(__workflow_mSOutlookGetEmailsmaxResultsToReturn, nameof(mSOutlookGetEmailsmaxResultsToReturn), required: false);
            var __workflow_mSOutlookGetEmailsclickAllowButtonIfRequired = mSOutlookGetEmailsclickAllowButtonIfRequired == null ? null : WorkflowExpression.Compile(mSOutlookGetEmailsclickAllowButtonIfRequired);
            WorkflowExpression.Validate(__workflow_mSOutlookGetEmailsclickAllowButtonIfRequired, nameof(mSOutlookGetEmailsclickAllowButtonIfRequired), required: false);
            return new DeferredBodyAction<MSOutlookGetEmailsResponse>(() =>
            {
                var apiCallPath = "/MSOutlook/GetEmails";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSOutlookGetEmails = new JObject();
                var mSOutlookGetEmailspropCount = 0;
                if (__workflow_mSOutlookGetEmailsfolderPath != null)
                {
                    mSOutlookGetEmails["FolderPath"] = ExpressionConverter.ConvertO(__workflow_mSOutlookGetEmailsfolderPath);
                    mSOutlookGetEmailspropCount++;
                }

                if (__workflow_mSOutlookGetEmailssearchRead != null)
                {
                    if (__workflow_mSOutlookGetEmailssearchRead != null)
                    {
                        mSOutlookGetEmails["SearchRead"] = ExpressionConverter.ConvertO(__workflow_mSOutlookGetEmailssearchRead);
                        mSOutlookGetEmailspropCount++;
                    }

                    mSOutlookGetEmailspropCount++;
                }
                else
                {
                    mSOutlookGetEmails["SearchRead"] = false;
                    mSOutlookGetEmailspropCount++;
                }

                if (__workflow_mSOutlookGetEmailssearchUnread != null)
                {
                    if (__workflow_mSOutlookGetEmailssearchUnread != null)
                    {
                        mSOutlookGetEmails["SearchUnread"] = ExpressionConverter.ConvertO(__workflow_mSOutlookGetEmailssearchUnread);
                        mSOutlookGetEmailspropCount++;
                    }

                    mSOutlookGetEmailspropCount++;
                }
                else
                {
                    mSOutlookGetEmails["SearchUnread"] = true;
                    mSOutlookGetEmailspropCount++;
                }

                if (__workflow_mSOutlookGetEmailssearchSubject != null)
                {
                    mSOutlookGetEmails["SearchSubject"] = ExpressionConverter.ConvertO(__workflow_mSOutlookGetEmailssearchSubject);
                    mSOutlookGetEmailspropCount++;
                }

                if (__workflow_mSOutlookGetEmailssearchFromSMTP != null)
                {
                    mSOutlookGetEmails["SearchFromSMTP"] = ExpressionConverter.ConvertO(__workflow_mSOutlookGetEmailssearchFromSMTP);
                    mSOutlookGetEmailspropCount++;
                }

                if (__workflow_mSOutlookGetEmailssearchFromName != null)
                {
                    mSOutlookGetEmails["SearchFromName"] = ExpressionConverter.ConvertO(__workflow_mSOutlookGetEmailssearchFromName);
                    mSOutlookGetEmailspropCount++;
                }

                if (__workflow_mSOutlookGetEmailssearchQuery != null)
                {
                    mSOutlookGetEmails["SearchQuery"] = ExpressionConverter.ConvertO(__workflow_mSOutlookGetEmailssearchQuery);
                    mSOutlookGetEmailspropCount++;
                }

                if (__workflow_mSOutlookGetEmailssearchMaxAgeInDays != null)
                {
                    if (__workflow_mSOutlookGetEmailssearchMaxAgeInDays != null)
                    {
                        mSOutlookGetEmails["SearchMaxAgeInDays"] = ExpressionConverter.ConvertO(__workflow_mSOutlookGetEmailssearchMaxAgeInDays);
                        mSOutlookGetEmailspropCount++;
                    }

                    mSOutlookGetEmailspropCount++;
                }
                else
                {
                    mSOutlookGetEmails["SearchMaxAgeInDays"] = -1;
                    mSOutlookGetEmailspropCount++;
                }

                if (__workflow_mSOutlookGetEmailssearchStartDateTimeAsString != null)
                {
                    mSOutlookGetEmails["SearchStartDateTimeAsString"] = ExpressionConverter.ConvertO(__workflow_mSOutlookGetEmailssearchStartDateTimeAsString);
                    mSOutlookGetEmailspropCount++;
                }

                if (__workflow_mSOutlookGetEmailssearchEndDateTimeAsString != null)
                {
                    mSOutlookGetEmails["SearchEndDateTimeAsString"] = ExpressionConverter.ConvertO(__workflow_mSOutlookGetEmailssearchEndDateTimeAsString);
                    mSOutlookGetEmailspropCount++;
                }

                if (__workflow_mSOutlookGetEmailsmaxResultsToReturn != null)
                {
                    if (__workflow_mSOutlookGetEmailsmaxResultsToReturn != null)
                    {
                        mSOutlookGetEmails["MaxResultsToReturn"] = ExpressionConverter.ConvertO(__workflow_mSOutlookGetEmailsmaxResultsToReturn);
                        mSOutlookGetEmailspropCount++;
                    }

                    mSOutlookGetEmailspropCount++;
                }
                else
                {
                    mSOutlookGetEmails["MaxResultsToReturn"] = 0;
                    mSOutlookGetEmailspropCount++;
                }

                if (__workflow_mSOutlookGetEmailsclickAllowButtonIfRequired != null)
                {
                    if (__workflow_mSOutlookGetEmailsclickAllowButtonIfRequired != null)
                    {
                        mSOutlookGetEmails["ClickAllowButtonIfRequired"] = ExpressionConverter.ConvertO(__workflow_mSOutlookGetEmailsclickAllowButtonIfRequired);
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
                mSOutlookGetEmails["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSOutlookGetEmailsworkflow);
                if (mSOutlookGetEmailspropCount > 0)
                {
                    callPayload.Body = mSOutlookGetEmails;
                }

                return new ApiConnectionAction<MSOutlookGetEmailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookGetFirstEmailResponse> MSOutlookGetFirstEmail(Expression<Func<string>> mSOutlookGetFirstEmailworkflow, Expression<Func<string>> mSOutlookGetFirstEmailfolderPath = null, Expression<Func<bool>> mSOutlookGetFirstEmailsearchRead = null, Expression<Func<bool>> mSOutlookGetFirstEmailsearchUnread = null, Expression<Func<string>> mSOutlookGetFirstEmailsearchSubject = null, Expression<Func<string>> mSOutlookGetFirstEmailsearchFromSMTP = null, Expression<Func<string>> mSOutlookGetFirstEmailsearchFromName = null, Expression<Func<string>> mSOutlookGetFirstEmailsearchQuery = null, Expression<Func<int>> mSOutlookGetFirstEmailsearchMaxAgeInDays = null, Expression<Func<string>> mSOutlookGetFirstEmailsearchStartDateTimeAsString = null, Expression<Func<string>> mSOutlookGetFirstEmailsearchEndDateTimeAsString = null, Expression<Func<bool>> mSOutlookGetFirstEmailclickAllowButtonIfRequired = null)
        {
            var __workflow_mSOutlookGetFirstEmailworkflow = mSOutlookGetFirstEmailworkflow == null ? null : WorkflowExpression.Compile(mSOutlookGetFirstEmailworkflow);
            WorkflowExpression.Validate(__workflow_mSOutlookGetFirstEmailworkflow, nameof(mSOutlookGetFirstEmailworkflow), required: true);
            var __workflow_mSOutlookGetFirstEmailfolderPath = mSOutlookGetFirstEmailfolderPath == null ? null : WorkflowExpression.Compile(mSOutlookGetFirstEmailfolderPath);
            WorkflowExpression.Validate(__workflow_mSOutlookGetFirstEmailfolderPath, nameof(mSOutlookGetFirstEmailfolderPath), required: false);
            var __workflow_mSOutlookGetFirstEmailsearchRead = mSOutlookGetFirstEmailsearchRead == null ? null : WorkflowExpression.Compile(mSOutlookGetFirstEmailsearchRead);
            WorkflowExpression.Validate(__workflow_mSOutlookGetFirstEmailsearchRead, nameof(mSOutlookGetFirstEmailsearchRead), required: false);
            var __workflow_mSOutlookGetFirstEmailsearchUnread = mSOutlookGetFirstEmailsearchUnread == null ? null : WorkflowExpression.Compile(mSOutlookGetFirstEmailsearchUnread);
            WorkflowExpression.Validate(__workflow_mSOutlookGetFirstEmailsearchUnread, nameof(mSOutlookGetFirstEmailsearchUnread), required: false);
            var __workflow_mSOutlookGetFirstEmailsearchSubject = mSOutlookGetFirstEmailsearchSubject == null ? null : WorkflowExpression.Compile(mSOutlookGetFirstEmailsearchSubject);
            WorkflowExpression.Validate(__workflow_mSOutlookGetFirstEmailsearchSubject, nameof(mSOutlookGetFirstEmailsearchSubject), required: false);
            var __workflow_mSOutlookGetFirstEmailsearchFromSMTP = mSOutlookGetFirstEmailsearchFromSMTP == null ? null : WorkflowExpression.Compile(mSOutlookGetFirstEmailsearchFromSMTP);
            WorkflowExpression.Validate(__workflow_mSOutlookGetFirstEmailsearchFromSMTP, nameof(mSOutlookGetFirstEmailsearchFromSMTP), required: false);
            var __workflow_mSOutlookGetFirstEmailsearchFromName = mSOutlookGetFirstEmailsearchFromName == null ? null : WorkflowExpression.Compile(mSOutlookGetFirstEmailsearchFromName);
            WorkflowExpression.Validate(__workflow_mSOutlookGetFirstEmailsearchFromName, nameof(mSOutlookGetFirstEmailsearchFromName), required: false);
            var __workflow_mSOutlookGetFirstEmailsearchQuery = mSOutlookGetFirstEmailsearchQuery == null ? null : WorkflowExpression.Compile(mSOutlookGetFirstEmailsearchQuery);
            WorkflowExpression.Validate(__workflow_mSOutlookGetFirstEmailsearchQuery, nameof(mSOutlookGetFirstEmailsearchQuery), required: false);
            var __workflow_mSOutlookGetFirstEmailsearchMaxAgeInDays = mSOutlookGetFirstEmailsearchMaxAgeInDays == null ? null : WorkflowExpression.Compile(mSOutlookGetFirstEmailsearchMaxAgeInDays);
            WorkflowExpression.Validate(__workflow_mSOutlookGetFirstEmailsearchMaxAgeInDays, nameof(mSOutlookGetFirstEmailsearchMaxAgeInDays), required: false);
            var __workflow_mSOutlookGetFirstEmailsearchStartDateTimeAsString = mSOutlookGetFirstEmailsearchStartDateTimeAsString == null ? null : WorkflowExpression.Compile(mSOutlookGetFirstEmailsearchStartDateTimeAsString);
            WorkflowExpression.Validate(__workflow_mSOutlookGetFirstEmailsearchStartDateTimeAsString, nameof(mSOutlookGetFirstEmailsearchStartDateTimeAsString), required: false);
            var __workflow_mSOutlookGetFirstEmailsearchEndDateTimeAsString = mSOutlookGetFirstEmailsearchEndDateTimeAsString == null ? null : WorkflowExpression.Compile(mSOutlookGetFirstEmailsearchEndDateTimeAsString);
            WorkflowExpression.Validate(__workflow_mSOutlookGetFirstEmailsearchEndDateTimeAsString, nameof(mSOutlookGetFirstEmailsearchEndDateTimeAsString), required: false);
            var __workflow_mSOutlookGetFirstEmailclickAllowButtonIfRequired = mSOutlookGetFirstEmailclickAllowButtonIfRequired == null ? null : WorkflowExpression.Compile(mSOutlookGetFirstEmailclickAllowButtonIfRequired);
            WorkflowExpression.Validate(__workflow_mSOutlookGetFirstEmailclickAllowButtonIfRequired, nameof(mSOutlookGetFirstEmailclickAllowButtonIfRequired), required: false);
            return new DeferredBodyAction<MSOutlookGetFirstEmailResponse>(() =>
            {
                var apiCallPath = "/MSOutlook/GetFirstEmail";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSOutlookGetFirstEmail = new JObject();
                var mSOutlookGetFirstEmailpropCount = 0;
                if (__workflow_mSOutlookGetFirstEmailfolderPath != null)
                {
                    mSOutlookGetFirstEmail["FolderPath"] = ExpressionConverter.ConvertO(__workflow_mSOutlookGetFirstEmailfolderPath);
                    mSOutlookGetFirstEmailpropCount++;
                }

                if (__workflow_mSOutlookGetFirstEmailsearchRead != null)
                {
                    if (__workflow_mSOutlookGetFirstEmailsearchRead != null)
                    {
                        mSOutlookGetFirstEmail["SearchRead"] = ExpressionConverter.ConvertO(__workflow_mSOutlookGetFirstEmailsearchRead);
                        mSOutlookGetFirstEmailpropCount++;
                    }

                    mSOutlookGetFirstEmailpropCount++;
                }
                else
                {
                    mSOutlookGetFirstEmail["SearchRead"] = false;
                    mSOutlookGetFirstEmailpropCount++;
                }

                if (__workflow_mSOutlookGetFirstEmailsearchUnread != null)
                {
                    if (__workflow_mSOutlookGetFirstEmailsearchUnread != null)
                    {
                        mSOutlookGetFirstEmail["SearchUnread"] = ExpressionConverter.ConvertO(__workflow_mSOutlookGetFirstEmailsearchUnread);
                        mSOutlookGetFirstEmailpropCount++;
                    }

                    mSOutlookGetFirstEmailpropCount++;
                }
                else
                {
                    mSOutlookGetFirstEmail["SearchUnread"] = true;
                    mSOutlookGetFirstEmailpropCount++;
                }

                if (__workflow_mSOutlookGetFirstEmailsearchSubject != null)
                {
                    mSOutlookGetFirstEmail["SearchSubject"] = ExpressionConverter.ConvertO(__workflow_mSOutlookGetFirstEmailsearchSubject);
                    mSOutlookGetFirstEmailpropCount++;
                }

                if (__workflow_mSOutlookGetFirstEmailsearchFromSMTP != null)
                {
                    mSOutlookGetFirstEmail["SearchFromSMTP"] = ExpressionConverter.ConvertO(__workflow_mSOutlookGetFirstEmailsearchFromSMTP);
                    mSOutlookGetFirstEmailpropCount++;
                }

                if (__workflow_mSOutlookGetFirstEmailsearchFromName != null)
                {
                    mSOutlookGetFirstEmail["SearchFromName"] = ExpressionConverter.ConvertO(__workflow_mSOutlookGetFirstEmailsearchFromName);
                    mSOutlookGetFirstEmailpropCount++;
                }

                if (__workflow_mSOutlookGetFirstEmailsearchQuery != null)
                {
                    mSOutlookGetFirstEmail["SearchQuery"] = ExpressionConverter.ConvertO(__workflow_mSOutlookGetFirstEmailsearchQuery);
                    mSOutlookGetFirstEmailpropCount++;
                }

                if (__workflow_mSOutlookGetFirstEmailsearchMaxAgeInDays != null)
                {
                    if (__workflow_mSOutlookGetFirstEmailsearchMaxAgeInDays != null)
                    {
                        mSOutlookGetFirstEmail["SearchMaxAgeInDays"] = ExpressionConverter.ConvertO(__workflow_mSOutlookGetFirstEmailsearchMaxAgeInDays);
                        mSOutlookGetFirstEmailpropCount++;
                    }

                    mSOutlookGetFirstEmailpropCount++;
                }
                else
                {
                    mSOutlookGetFirstEmail["SearchMaxAgeInDays"] = -1;
                    mSOutlookGetFirstEmailpropCount++;
                }

                if (__workflow_mSOutlookGetFirstEmailsearchStartDateTimeAsString != null)
                {
                    mSOutlookGetFirstEmail["SearchStartDateTimeAsString"] = ExpressionConverter.ConvertO(__workflow_mSOutlookGetFirstEmailsearchStartDateTimeAsString);
                    mSOutlookGetFirstEmailpropCount++;
                }

                if (__workflow_mSOutlookGetFirstEmailsearchEndDateTimeAsString != null)
                {
                    mSOutlookGetFirstEmail["SearchEndDateTimeAsString"] = ExpressionConverter.ConvertO(__workflow_mSOutlookGetFirstEmailsearchEndDateTimeAsString);
                    mSOutlookGetFirstEmailpropCount++;
                }

                if (__workflow_mSOutlookGetFirstEmailclickAllowButtonIfRequired != null)
                {
                    if (__workflow_mSOutlookGetFirstEmailclickAllowButtonIfRequired != null)
                    {
                        mSOutlookGetFirstEmail["ClickAllowButtonIfRequired"] = ExpressionConverter.ConvertO(__workflow_mSOutlookGetFirstEmailclickAllowButtonIfRequired);
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
                mSOutlookGetFirstEmail["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSOutlookGetFirstEmailworkflow);
                if (mSOutlookGetFirstEmailpropCount > 0)
                {
                    callPayload.Body = mSOutlookGetFirstEmail;
                }

                return new ApiConnectionAction<MSOutlookGetFirstEmailResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookGetNumberOfEmailsResponse> MSOutlookGetNumberOfEmails(Expression<Func<string>> mSOutlookGetNumberOfEmailsworkflow, Expression<Func<string>> mSOutlookGetNumberOfEmailsfolderPath = null, Expression<Func<bool>> mSOutlookGetNumberOfEmailssearchRead = null, Expression<Func<bool>> mSOutlookGetNumberOfEmailssearchUnread = null, Expression<Func<string>> mSOutlookGetNumberOfEmailssearchSubject = null, Expression<Func<string>> mSOutlookGetNumberOfEmailssearchFromSMTP = null, Expression<Func<string>> mSOutlookGetNumberOfEmailssearchFromName = null, Expression<Func<string>> mSOutlookGetNumberOfEmailssearchQuery = null, Expression<Func<int>> mSOutlookGetNumberOfEmailssearchMaxAgeInDays = null, Expression<Func<string>> mSOutlookGetNumberOfEmailssearchStartDateTimeAsString = null, Expression<Func<string>> mSOutlookGetNumberOfEmailssearchEndDateTimeAsString = null)
        {
            var __workflow_mSOutlookGetNumberOfEmailsworkflow = mSOutlookGetNumberOfEmailsworkflow == null ? null : WorkflowExpression.Compile(mSOutlookGetNumberOfEmailsworkflow);
            WorkflowExpression.Validate(__workflow_mSOutlookGetNumberOfEmailsworkflow, nameof(mSOutlookGetNumberOfEmailsworkflow), required: true);
            var __workflow_mSOutlookGetNumberOfEmailsfolderPath = mSOutlookGetNumberOfEmailsfolderPath == null ? null : WorkflowExpression.Compile(mSOutlookGetNumberOfEmailsfolderPath);
            WorkflowExpression.Validate(__workflow_mSOutlookGetNumberOfEmailsfolderPath, nameof(mSOutlookGetNumberOfEmailsfolderPath), required: false);
            var __workflow_mSOutlookGetNumberOfEmailssearchRead = mSOutlookGetNumberOfEmailssearchRead == null ? null : WorkflowExpression.Compile(mSOutlookGetNumberOfEmailssearchRead);
            WorkflowExpression.Validate(__workflow_mSOutlookGetNumberOfEmailssearchRead, nameof(mSOutlookGetNumberOfEmailssearchRead), required: false);
            var __workflow_mSOutlookGetNumberOfEmailssearchUnread = mSOutlookGetNumberOfEmailssearchUnread == null ? null : WorkflowExpression.Compile(mSOutlookGetNumberOfEmailssearchUnread);
            WorkflowExpression.Validate(__workflow_mSOutlookGetNumberOfEmailssearchUnread, nameof(mSOutlookGetNumberOfEmailssearchUnread), required: false);
            var __workflow_mSOutlookGetNumberOfEmailssearchSubject = mSOutlookGetNumberOfEmailssearchSubject == null ? null : WorkflowExpression.Compile(mSOutlookGetNumberOfEmailssearchSubject);
            WorkflowExpression.Validate(__workflow_mSOutlookGetNumberOfEmailssearchSubject, nameof(mSOutlookGetNumberOfEmailssearchSubject), required: false);
            var __workflow_mSOutlookGetNumberOfEmailssearchFromSMTP = mSOutlookGetNumberOfEmailssearchFromSMTP == null ? null : WorkflowExpression.Compile(mSOutlookGetNumberOfEmailssearchFromSMTP);
            WorkflowExpression.Validate(__workflow_mSOutlookGetNumberOfEmailssearchFromSMTP, nameof(mSOutlookGetNumberOfEmailssearchFromSMTP), required: false);
            var __workflow_mSOutlookGetNumberOfEmailssearchFromName = mSOutlookGetNumberOfEmailssearchFromName == null ? null : WorkflowExpression.Compile(mSOutlookGetNumberOfEmailssearchFromName);
            WorkflowExpression.Validate(__workflow_mSOutlookGetNumberOfEmailssearchFromName, nameof(mSOutlookGetNumberOfEmailssearchFromName), required: false);
            var __workflow_mSOutlookGetNumberOfEmailssearchQuery = mSOutlookGetNumberOfEmailssearchQuery == null ? null : WorkflowExpression.Compile(mSOutlookGetNumberOfEmailssearchQuery);
            WorkflowExpression.Validate(__workflow_mSOutlookGetNumberOfEmailssearchQuery, nameof(mSOutlookGetNumberOfEmailssearchQuery), required: false);
            var __workflow_mSOutlookGetNumberOfEmailssearchMaxAgeInDays = mSOutlookGetNumberOfEmailssearchMaxAgeInDays == null ? null : WorkflowExpression.Compile(mSOutlookGetNumberOfEmailssearchMaxAgeInDays);
            WorkflowExpression.Validate(__workflow_mSOutlookGetNumberOfEmailssearchMaxAgeInDays, nameof(mSOutlookGetNumberOfEmailssearchMaxAgeInDays), required: false);
            var __workflow_mSOutlookGetNumberOfEmailssearchStartDateTimeAsString = mSOutlookGetNumberOfEmailssearchStartDateTimeAsString == null ? null : WorkflowExpression.Compile(mSOutlookGetNumberOfEmailssearchStartDateTimeAsString);
            WorkflowExpression.Validate(__workflow_mSOutlookGetNumberOfEmailssearchStartDateTimeAsString, nameof(mSOutlookGetNumberOfEmailssearchStartDateTimeAsString), required: false);
            var __workflow_mSOutlookGetNumberOfEmailssearchEndDateTimeAsString = mSOutlookGetNumberOfEmailssearchEndDateTimeAsString == null ? null : WorkflowExpression.Compile(mSOutlookGetNumberOfEmailssearchEndDateTimeAsString);
            WorkflowExpression.Validate(__workflow_mSOutlookGetNumberOfEmailssearchEndDateTimeAsString, nameof(mSOutlookGetNumberOfEmailssearchEndDateTimeAsString), required: false);
            return new DeferredBodyAction<MSOutlookGetNumberOfEmailsResponse>(() =>
            {
                var apiCallPath = "/MSOutlook/GetNumberOfEmails";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSOutlookGetNumberOfEmails = new JObject();
                var mSOutlookGetNumberOfEmailspropCount = 0;
                if (__workflow_mSOutlookGetNumberOfEmailsfolderPath != null)
                {
                    mSOutlookGetNumberOfEmails["FolderPath"] = ExpressionConverter.ConvertO(__workflow_mSOutlookGetNumberOfEmailsfolderPath);
                    mSOutlookGetNumberOfEmailspropCount++;
                }

                if (__workflow_mSOutlookGetNumberOfEmailssearchRead != null)
                {
                    if (__workflow_mSOutlookGetNumberOfEmailssearchRead != null)
                    {
                        mSOutlookGetNumberOfEmails["SearchRead"] = ExpressionConverter.ConvertO(__workflow_mSOutlookGetNumberOfEmailssearchRead);
                        mSOutlookGetNumberOfEmailspropCount++;
                    }

                    mSOutlookGetNumberOfEmailspropCount++;
                }
                else
                {
                    mSOutlookGetNumberOfEmails["SearchRead"] = false;
                    mSOutlookGetNumberOfEmailspropCount++;
                }

                if (__workflow_mSOutlookGetNumberOfEmailssearchUnread != null)
                {
                    if (__workflow_mSOutlookGetNumberOfEmailssearchUnread != null)
                    {
                        mSOutlookGetNumberOfEmails["SearchUnread"] = ExpressionConverter.ConvertO(__workflow_mSOutlookGetNumberOfEmailssearchUnread);
                        mSOutlookGetNumberOfEmailspropCount++;
                    }

                    mSOutlookGetNumberOfEmailspropCount++;
                }
                else
                {
                    mSOutlookGetNumberOfEmails["SearchUnread"] = true;
                    mSOutlookGetNumberOfEmailspropCount++;
                }

                if (__workflow_mSOutlookGetNumberOfEmailssearchSubject != null)
                {
                    mSOutlookGetNumberOfEmails["SearchSubject"] = ExpressionConverter.ConvertO(__workflow_mSOutlookGetNumberOfEmailssearchSubject);
                    mSOutlookGetNumberOfEmailspropCount++;
                }

                if (__workflow_mSOutlookGetNumberOfEmailssearchFromSMTP != null)
                {
                    mSOutlookGetNumberOfEmails["SearchFromSMTP"] = ExpressionConverter.ConvertO(__workflow_mSOutlookGetNumberOfEmailssearchFromSMTP);
                    mSOutlookGetNumberOfEmailspropCount++;
                }

                if (__workflow_mSOutlookGetNumberOfEmailssearchFromName != null)
                {
                    mSOutlookGetNumberOfEmails["SearchFromName"] = ExpressionConverter.ConvertO(__workflow_mSOutlookGetNumberOfEmailssearchFromName);
                    mSOutlookGetNumberOfEmailspropCount++;
                }

                if (__workflow_mSOutlookGetNumberOfEmailssearchQuery != null)
                {
                    mSOutlookGetNumberOfEmails["SearchQuery"] = ExpressionConverter.ConvertO(__workflow_mSOutlookGetNumberOfEmailssearchQuery);
                    mSOutlookGetNumberOfEmailspropCount++;
                }

                if (__workflow_mSOutlookGetNumberOfEmailssearchMaxAgeInDays != null)
                {
                    if (__workflow_mSOutlookGetNumberOfEmailssearchMaxAgeInDays != null)
                    {
                        mSOutlookGetNumberOfEmails["SearchMaxAgeInDays"] = ExpressionConverter.ConvertO(__workflow_mSOutlookGetNumberOfEmailssearchMaxAgeInDays);
                        mSOutlookGetNumberOfEmailspropCount++;
                    }

                    mSOutlookGetNumberOfEmailspropCount++;
                }
                else
                {
                    mSOutlookGetNumberOfEmails["SearchMaxAgeInDays"] = -1;
                    mSOutlookGetNumberOfEmailspropCount++;
                }

                if (__workflow_mSOutlookGetNumberOfEmailssearchStartDateTimeAsString != null)
                {
                    mSOutlookGetNumberOfEmails["SearchStartDateTimeAsString"] = ExpressionConverter.ConvertO(__workflow_mSOutlookGetNumberOfEmailssearchStartDateTimeAsString);
                    mSOutlookGetNumberOfEmailspropCount++;
                }

                if (__workflow_mSOutlookGetNumberOfEmailssearchEndDateTimeAsString != null)
                {
                    mSOutlookGetNumberOfEmails["SearchEndDateTimeAsString"] = ExpressionConverter.ConvertO(__workflow_mSOutlookGetNumberOfEmailssearchEndDateTimeAsString);
                    mSOutlookGetNumberOfEmailspropCount++;
                }

                mSOutlookGetNumberOfEmailspropCount++;
                mSOutlookGetNumberOfEmails["Workflow"] = ExpressionConverter.ConvertO(__workflow_mSOutlookGetNumberOfEmailsworkflow);
                if (mSOutlookGetNumberOfEmailspropCount > 0)
                {
                    callPayload.Body = mSOutlookGetNumberOfEmails;
                }

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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum mSExcelFindNextCellWithValuedirectionInput
    {
        U,
        D,
        L,
        R
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum mSExcelInsertOnSelectionshiftInput
    {
        R,
        D
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum mSOutlookSendEmailbodyFormatInput
    {
        HTML,
        Plain,
        RTF
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum mSOutlookReplyToEmailbodyFormatInput
    {
        HTML,
        Plain,
        RTF
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
