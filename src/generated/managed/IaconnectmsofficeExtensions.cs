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
        [WorkflowExpressionFactory(nameof(__BuildMSWordCreateInstance))]
        public IBodyWorkflowAction<MSWordCreateInstanceResponse> MSWordCreateInstance([WorkflowExpression] Func<string> mSWordCreateInstanceworkflow, [WorkflowExpression] Func<bool> mSWordCreateInstanceshowWord = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MSWordCreateInstanceResponse> __BuildMSWordCreateInstance(WorkflowExpression<string> mSWordCreateInstanceworkflow, WorkflowExpression<bool> mSWordCreateInstanceshowWord = null)
        {
            WorkflowExpression.Validate(mSWordCreateInstanceworkflow, nameof(mSWordCreateInstanceworkflow), required: true);
            WorkflowExpression.Validate(mSWordCreateInstanceshowWord, nameof(mSWordCreateInstanceshowWord), required: false);
            return new DeferredBodyAction<MSWordCreateInstanceResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSWordCloseInstance))]
        public IWorkflowAction MSWordCloseInstance([WorkflowExpression] Func<string> mSWordCloseInstanceworkflow, [WorkflowExpression] Func<int> mSWordCloseInstancehandle = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMSWordCloseInstance(WorkflowExpression<string> mSWordCloseInstanceworkflow, WorkflowExpression<int> mSWordCloseInstancehandle = null)
        {
            WorkflowExpression.Validate(mSWordCloseInstanceworkflow, nameof(mSWordCloseInstanceworkflow), required: true);
            WorkflowExpression.Validate(mSWordCloseInstancehandle, nameof(mSWordCloseInstancehandle), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSWordDetachFromInstance))]
        public IWorkflowAction MSWordDetachFromInstance([WorkflowExpression] Func<string> mSWordDetachFromInstanceworkflow, [WorkflowExpression] Func<int> mSWordDetachFromInstancehandle = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMSWordDetachFromInstance(WorkflowExpression<string> mSWordDetachFromInstanceworkflow, WorkflowExpression<int> mSWordDetachFromInstancehandle = null)
        {
            WorkflowExpression.Validate(mSWordDetachFromInstanceworkflow, nameof(mSWordDetachFromInstanceworkflow), required: true);
            WorkflowExpression.Validate(mSWordDetachFromInstancehandle, nameof(mSWordDetachFromInstancehandle), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSWordAttachToExistingInstance))]
        public IBodyWorkflowAction<MSWordAttachToExistingInstanceResponse> MSWordAttachToExistingInstance([WorkflowExpression] Func<string> mSWordAttachToExistingInstanceworkflow, [WorkflowExpression] Func<string> mSWordAttachToExistingInstancefilename = null, [WorkflowExpression] Func<bool> mSWordAttachToExistingInstancetoggleWindow = null, [WorkflowExpression] Func<bool> mSWordAttachToExistingInstancetoggleUsesGlobalLeftMouseClickAgent = null, [WorkflowExpression] Func<double> mSWordAttachToExistingInstancetoggleDelay = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MSWordAttachToExistingInstanceResponse> __BuildMSWordAttachToExistingInstance(WorkflowExpression<string> mSWordAttachToExistingInstanceworkflow, WorkflowExpression<string> mSWordAttachToExistingInstancefilename = null, WorkflowExpression<bool> mSWordAttachToExistingInstancetoggleWindow = null, WorkflowExpression<bool> mSWordAttachToExistingInstancetoggleUsesGlobalLeftMouseClickAgent = null, WorkflowExpression<double> mSWordAttachToExistingInstancetoggleDelay = null)
        {
            WorkflowExpression.Validate(mSWordAttachToExistingInstanceworkflow, nameof(mSWordAttachToExistingInstanceworkflow), required: true);
            WorkflowExpression.Validate(mSWordAttachToExistingInstancefilename, nameof(mSWordAttachToExistingInstancefilename), required: false);
            WorkflowExpression.Validate(mSWordAttachToExistingInstancetoggleWindow, nameof(mSWordAttachToExistingInstancetoggleWindow), required: false);
            WorkflowExpression.Validate(mSWordAttachToExistingInstancetoggleUsesGlobalLeftMouseClickAgent, nameof(mSWordAttachToExistingInstancetoggleUsesGlobalLeftMouseClickAgent), required: false);
            WorkflowExpression.Validate(mSWordAttachToExistingInstancetoggleDelay, nameof(mSWordAttachToExistingInstancetoggleDelay), required: false);
            return new DeferredBodyAction<MSWordAttachToExistingInstanceResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSWordShowWord))]
        public IWorkflowAction MSWordShowWord([WorkflowExpression] Func<string> mSWordShowWordworkflow, [WorkflowExpression] Func<int> mSWordShowWordhandle = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMSWordShowWord(WorkflowExpression<string> mSWordShowWordworkflow, WorkflowExpression<int> mSWordShowWordhandle = null)
        {
            WorkflowExpression.Validate(mSWordShowWordworkflow, nameof(mSWordShowWordworkflow), required: true);
            WorkflowExpression.Validate(mSWordShowWordhandle, nameof(mSWordShowWordhandle), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSWordHideWord))]
        public IWorkflowAction MSWordHideWord([WorkflowExpression] Func<string> mSWordHideWordworkflow, [WorkflowExpression] Func<int> mSWordHideWordhandle = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMSWordHideWord(WorkflowExpression<string> mSWordHideWordworkflow, WorkflowExpression<int> mSWordHideWordhandle = null)
        {
            WorkflowExpression.Validate(mSWordHideWordworkflow, nameof(mSWordHideWordworkflow), required: true);
            WorkflowExpression.Validate(mSWordHideWordhandle, nameof(mSWordHideWordhandle), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSWordCreateDocument))]
        public IBodyWorkflowAction<MSWordCreateDocumentResponse> MSWordCreateDocument([WorkflowExpression] Func<string> mSWordCreateDocumentworkflow, [WorkflowExpression] Func<int> mSWordCreateDocumenthandle = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MSWordCreateDocumentResponse> __BuildMSWordCreateDocument(WorkflowExpression<string> mSWordCreateDocumentworkflow, WorkflowExpression<int> mSWordCreateDocumenthandle = null)
        {
            WorkflowExpression.Validate(mSWordCreateDocumentworkflow, nameof(mSWordCreateDocumentworkflow), required: true);
            WorkflowExpression.Validate(mSWordCreateDocumenthandle, nameof(mSWordCreateDocumenthandle), required: false);
            return new DeferredBodyAction<MSWordCreateDocumentResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSWordOpenDocument))]
        public IBodyWorkflowAction<MSWordOpenDocumentResponse> MSWordOpenDocument([WorkflowExpression] Func<string> mSWordOpenDocumentfilename, [WorkflowExpression] Func<string> mSWordOpenDocumentworkflow, [WorkflowExpression] Func<int> mSWordOpenDocumenthandle = null, [WorkflowExpression] Func<bool> mSWordOpenDocumentopenReadOnly = null, [WorkflowExpression] Func<bool> mSWordOpenDocumentaddToRecentFiles = null, [WorkflowExpression] Func<string> mSWordOpenDocumentpassword = null, [WorkflowExpression] Func<bool> mSWordOpenDocumentopenAndRepair = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MSWordOpenDocumentResponse> __BuildMSWordOpenDocument(WorkflowExpression<string> mSWordOpenDocumentfilename, WorkflowExpression<string> mSWordOpenDocumentworkflow, WorkflowExpression<int> mSWordOpenDocumenthandle = null, WorkflowExpression<bool> mSWordOpenDocumentopenReadOnly = null, WorkflowExpression<bool> mSWordOpenDocumentaddToRecentFiles = null, WorkflowExpression<string> mSWordOpenDocumentpassword = null, WorkflowExpression<bool> mSWordOpenDocumentopenAndRepair = null)
        {
            WorkflowExpression.Validate(mSWordOpenDocumentfilename, nameof(mSWordOpenDocumentfilename), required: true);
            WorkflowExpression.Validate(mSWordOpenDocumentworkflow, nameof(mSWordOpenDocumentworkflow), required: true);
            WorkflowExpression.Validate(mSWordOpenDocumenthandle, nameof(mSWordOpenDocumenthandle), required: false);
            WorkflowExpression.Validate(mSWordOpenDocumentopenReadOnly, nameof(mSWordOpenDocumentopenReadOnly), required: false);
            WorkflowExpression.Validate(mSWordOpenDocumentaddToRecentFiles, nameof(mSWordOpenDocumentaddToRecentFiles), required: false);
            WorkflowExpression.Validate(mSWordOpenDocumentpassword, nameof(mSWordOpenDocumentpassword), required: false);
            WorkflowExpression.Validate(mSWordOpenDocumentopenAndRepair, nameof(mSWordOpenDocumentopenAndRepair), required: false);
            return new DeferredBodyAction<MSWordOpenDocumentResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSWordSaveDocument))]
        public IWorkflowAction MSWordSaveDocument([WorkflowExpression] Func<string> mSWordSaveDocumentworkflow, [WorkflowExpression] Func<int> mSWordSaveDocumenthandle = null, [WorkflowExpression] Func<string> mSWordSaveDocumentdocumentName = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMSWordSaveDocument(WorkflowExpression<string> mSWordSaveDocumentworkflow, WorkflowExpression<int> mSWordSaveDocumenthandle = null, WorkflowExpression<string> mSWordSaveDocumentdocumentName = null)
        {
            WorkflowExpression.Validate(mSWordSaveDocumentworkflow, nameof(mSWordSaveDocumentworkflow), required: true);
            WorkflowExpression.Validate(mSWordSaveDocumenthandle, nameof(mSWordSaveDocumenthandle), required: false);
            WorkflowExpression.Validate(mSWordSaveDocumentdocumentName, nameof(mSWordSaveDocumentdocumentName), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSWordSaveAsDocument))]
        public IBodyWorkflowAction<MSWordSaveAsDocumentResponse> MSWordSaveAsDocument([WorkflowExpression] Func<string> mSWordSaveAsDocumentsaveFilename, [WorkflowExpression] Func<string> mSWordSaveAsDocumentworkflow, [WorkflowExpression] Func<int> mSWordSaveAsDocumenthandle = null, [WorkflowExpression] Func<string> mSWordSaveAsDocumentdocumentName = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MSWordSaveAsDocumentResponse> __BuildMSWordSaveAsDocument(WorkflowExpression<string> mSWordSaveAsDocumentsaveFilename, WorkflowExpression<string> mSWordSaveAsDocumentworkflow, WorkflowExpression<int> mSWordSaveAsDocumenthandle = null, WorkflowExpression<string> mSWordSaveAsDocumentdocumentName = null)
        {
            WorkflowExpression.Validate(mSWordSaveAsDocumentsaveFilename, nameof(mSWordSaveAsDocumentsaveFilename), required: true);
            WorkflowExpression.Validate(mSWordSaveAsDocumentworkflow, nameof(mSWordSaveAsDocumentworkflow), required: true);
            WorkflowExpression.Validate(mSWordSaveAsDocumenthandle, nameof(mSWordSaveAsDocumenthandle), required: false);
            WorkflowExpression.Validate(mSWordSaveAsDocumentdocumentName, nameof(mSWordSaveAsDocumentdocumentName), required: false);
            return new DeferredBodyAction<MSWordSaveAsDocumentResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSWordCloseDocument))]
        public IWorkflowAction MSWordCloseDocument([WorkflowExpression] Func<string> mSWordCloseDocumentworkflow, [WorkflowExpression] Func<int> mSWordCloseDocumenthandle = null, [WorkflowExpression] Func<string> mSWordCloseDocumentdocumentName = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMSWordCloseDocument(WorkflowExpression<string> mSWordCloseDocumentworkflow, WorkflowExpression<int> mSWordCloseDocumenthandle = null, WorkflowExpression<string> mSWordCloseDocumentdocumentName = null)
        {
            WorkflowExpression.Validate(mSWordCloseDocumentworkflow, nameof(mSWordCloseDocumentworkflow), required: true);
            WorkflowExpression.Validate(mSWordCloseDocumenthandle, nameof(mSWordCloseDocumenthandle), required: false);
            WorkflowExpression.Validate(mSWordCloseDocumentdocumentName, nameof(mSWordCloseDocumentdocumentName), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSWordTypeText))]
        public IWorkflowAction MSWordTypeText([WorkflowExpression] Func<string> mSWordTypeTexttext, [WorkflowExpression] Func<string> mSWordTypeTextworkflow, [WorkflowExpression] Func<int> mSWordTypeTexthandle = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMSWordTypeText(WorkflowExpression<string> mSWordTypeTexttext, WorkflowExpression<string> mSWordTypeTextworkflow, WorkflowExpression<int> mSWordTypeTexthandle = null)
        {
            WorkflowExpression.Validate(mSWordTypeTexttext, nameof(mSWordTypeTexttext), required: true);
            WorkflowExpression.Validate(mSWordTypeTextworkflow, nameof(mSWordTypeTextworkflow), required: true);
            WorkflowExpression.Validate(mSWordTypeTexthandle, nameof(mSWordTypeTexthandle), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSWordSelectAll))]
        public IWorkflowAction MSWordSelectAll([WorkflowExpression] Func<string> mSWordSelectAllworkflow, [WorkflowExpression] Func<int> mSWordSelectAllhandle = null, [WorkflowExpression] Func<string> mSWordSelectAlldocumentName = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMSWordSelectAll(WorkflowExpression<string> mSWordSelectAllworkflow, WorkflowExpression<int> mSWordSelectAllhandle = null, WorkflowExpression<string> mSWordSelectAlldocumentName = null)
        {
            WorkflowExpression.Validate(mSWordSelectAllworkflow, nameof(mSWordSelectAllworkflow), required: true);
            WorkflowExpression.Validate(mSWordSelectAllhandle, nameof(mSWordSelectAllhandle), required: false);
            WorkflowExpression.Validate(mSWordSelectAlldocumentName, nameof(mSWordSelectAlldocumentName), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSWordSelectRange))]
        public IWorkflowAction MSWordSelectRange([WorkflowExpression] Func<int> mSWordSelectRangestart, [WorkflowExpression] Func<int> mSWordSelectRangefinish, [WorkflowExpression] Func<string> mSWordSelectRangeworkflow, [WorkflowExpression] Func<int> mSWordSelectRangehandle = null, [WorkflowExpression] Func<string> mSWordSelectRangedocumentName = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMSWordSelectRange(WorkflowExpression<int> mSWordSelectRangestart, WorkflowExpression<int> mSWordSelectRangefinish, WorkflowExpression<string> mSWordSelectRangeworkflow, WorkflowExpression<int> mSWordSelectRangehandle = null, WorkflowExpression<string> mSWordSelectRangedocumentName = null)
        {
            WorkflowExpression.Validate(mSWordSelectRangestart, nameof(mSWordSelectRangestart), required: true);
            WorkflowExpression.Validate(mSWordSelectRangefinish, nameof(mSWordSelectRangefinish), required: true);
            WorkflowExpression.Validate(mSWordSelectRangeworkflow, nameof(mSWordSelectRangeworkflow), required: true);
            WorkflowExpression.Validate(mSWordSelectRangehandle, nameof(mSWordSelectRangehandle), required: false);
            WorkflowExpression.Validate(mSWordSelectRangedocumentName, nameof(mSWordSelectRangedocumentName), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSWordCopyToClipboard))]
        public IWorkflowAction MSWordCopyToClipboard([WorkflowExpression] Func<string> mSWordCopyToClipboardworkflow, [WorkflowExpression] Func<int> mSWordCopyToClipboardhandle = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMSWordCopyToClipboard(WorkflowExpression<string> mSWordCopyToClipboardworkflow, WorkflowExpression<int> mSWordCopyToClipboardhandle = null)
        {
            WorkflowExpression.Validate(mSWordCopyToClipboardworkflow, nameof(mSWordCopyToClipboardworkflow), required: true);
            WorkflowExpression.Validate(mSWordCopyToClipboardhandle, nameof(mSWordCopyToClipboardhandle), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSWordPasteFromClipboard))]
        public IWorkflowAction MSWordPasteFromClipboard([WorkflowExpression] Func<string> mSWordPasteFromClipboardworkflow, [WorkflowExpression] Func<int> mSWordPasteFromClipboardhandle = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMSWordPasteFromClipboard(WorkflowExpression<string> mSWordPasteFromClipboardworkflow, WorkflowExpression<int> mSWordPasteFromClipboardhandle = null)
        {
            WorkflowExpression.Validate(mSWordPasteFromClipboardworkflow, nameof(mSWordPasteFromClipboardworkflow), required: true);
            WorkflowExpression.Validate(mSWordPasteFromClipboardhandle, nameof(mSWordPasteFromClipboardhandle), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSWordClearClipboard))]
        public IWorkflowAction MSWordClearClipboard([WorkflowExpression] Func<string> mSWordClearClipboardworkflow)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMSWordClearClipboard(WorkflowExpression<string> mSWordClearClipboardworkflow)
        {
            WorkflowExpression.Validate(mSWordClearClipboardworkflow, nameof(mSWordClearClipboardworkflow), required: true);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSWordGetDocumentBodyText))]
        public IBodyWorkflowAction<MSWordGetDocumentBodyTextResponse> MSWordGetDocumentBodyText([WorkflowExpression] Func<int> mSWordGetDocumentBodyTextstart, [WorkflowExpression] Func<int> mSWordGetDocumentBodyTextfinish, [WorkflowExpression] Func<string> mSWordGetDocumentBodyTextworkflow, [WorkflowExpression] Func<int> mSWordGetDocumentBodyTexthandle = null, [WorkflowExpression] Func<string> mSWordGetDocumentBodyTextdocumentName = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MSWordGetDocumentBodyTextResponse> __BuildMSWordGetDocumentBodyText(WorkflowExpression<int> mSWordGetDocumentBodyTextstart, WorkflowExpression<int> mSWordGetDocumentBodyTextfinish, WorkflowExpression<string> mSWordGetDocumentBodyTextworkflow, WorkflowExpression<int> mSWordGetDocumentBodyTexthandle = null, WorkflowExpression<string> mSWordGetDocumentBodyTextdocumentName = null)
        {
            WorkflowExpression.Validate(mSWordGetDocumentBodyTextstart, nameof(mSWordGetDocumentBodyTextstart), required: true);
            WorkflowExpression.Validate(mSWordGetDocumentBodyTextfinish, nameof(mSWordGetDocumentBodyTextfinish), required: true);
            WorkflowExpression.Validate(mSWordGetDocumentBodyTextworkflow, nameof(mSWordGetDocumentBodyTextworkflow), required: true);
            WorkflowExpression.Validate(mSWordGetDocumentBodyTexthandle, nameof(mSWordGetDocumentBodyTexthandle), required: false);
            WorkflowExpression.Validate(mSWordGetDocumentBodyTextdocumentName, nameof(mSWordGetDocumentBodyTextdocumentName), required: false);
            return new DeferredBodyAction<MSWordGetDocumentBodyTextResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSWordGetNumberOfTablesInDocument))]
        public IBodyWorkflowAction<MSWordGetNumberOfTablesInDocumentResponse> MSWordGetNumberOfTablesInDocument([WorkflowExpression] Func<string> mSWordGetNumberOfTablesInDocumentworkflow, [WorkflowExpression] Func<int> mSWordGetNumberOfTablesInDocumenthandle = null, [WorkflowExpression] Func<string> mSWordGetNumberOfTablesInDocumentdocumentName = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MSWordGetNumberOfTablesInDocumentResponse> __BuildMSWordGetNumberOfTablesInDocument(WorkflowExpression<string> mSWordGetNumberOfTablesInDocumentworkflow, WorkflowExpression<int> mSWordGetNumberOfTablesInDocumenthandle = null, WorkflowExpression<string> mSWordGetNumberOfTablesInDocumentdocumentName = null)
        {
            WorkflowExpression.Validate(mSWordGetNumberOfTablesInDocumentworkflow, nameof(mSWordGetNumberOfTablesInDocumentworkflow), required: true);
            WorkflowExpression.Validate(mSWordGetNumberOfTablesInDocumenthandle, nameof(mSWordGetNumberOfTablesInDocumenthandle), required: false);
            WorkflowExpression.Validate(mSWordGetNumberOfTablesInDocumentdocumentName, nameof(mSWordGetNumberOfTablesInDocumentdocumentName), required: false);
            return new DeferredBodyAction<MSWordGetNumberOfTablesInDocumentResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSWordUpdateBookmark))]
        public IWorkflowAction MSWordUpdateBookmark([WorkflowExpression] Func<string> mSWordUpdateBookmarkbookmarkName, [WorkflowExpression] Func<string> mSWordUpdateBookmarkworkflow, [WorkflowExpression] Func<int> mSWordUpdateBookmarkhandle = null, [WorkflowExpression] Func<string> mSWordUpdateBookmarkdocumentName = null, [WorkflowExpression] Func<string> mSWordUpdateBookmarknewValue = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMSWordUpdateBookmark(WorkflowExpression<string> mSWordUpdateBookmarkbookmarkName, WorkflowExpression<string> mSWordUpdateBookmarkworkflow, WorkflowExpression<int> mSWordUpdateBookmarkhandle = null, WorkflowExpression<string> mSWordUpdateBookmarkdocumentName = null, WorkflowExpression<string> mSWordUpdateBookmarknewValue = null)
        {
            WorkflowExpression.Validate(mSWordUpdateBookmarkbookmarkName, nameof(mSWordUpdateBookmarkbookmarkName), required: true);
            WorkflowExpression.Validate(mSWordUpdateBookmarkworkflow, nameof(mSWordUpdateBookmarkworkflow), required: true);
            WorkflowExpression.Validate(mSWordUpdateBookmarkhandle, nameof(mSWordUpdateBookmarkhandle), required: false);
            WorkflowExpression.Validate(mSWordUpdateBookmarkdocumentName, nameof(mSWordUpdateBookmarkdocumentName), required: false);
            WorkflowExpression.Validate(mSWordUpdateBookmarknewValue, nameof(mSWordUpdateBookmarknewValue), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSWordSelectTable))]
        public IWorkflowAction MSWordSelectTable([WorkflowExpression] Func<int> mSWordSelectTabletableIndex, [WorkflowExpression] Func<string> mSWordSelectTableworkflow, [WorkflowExpression] Func<int> mSWordSelectTablehandle = null, [WorkflowExpression] Func<string> mSWordSelectTabledocumentName = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMSWordSelectTable(WorkflowExpression<int> mSWordSelectTabletableIndex, WorkflowExpression<string> mSWordSelectTableworkflow, WorkflowExpression<int> mSWordSelectTablehandle = null, WorkflowExpression<string> mSWordSelectTabledocumentName = null)
        {
            WorkflowExpression.Validate(mSWordSelectTabletableIndex, nameof(mSWordSelectTabletableIndex), required: true);
            WorkflowExpression.Validate(mSWordSelectTableworkflow, nameof(mSWordSelectTableworkflow), required: true);
            WorkflowExpression.Validate(mSWordSelectTablehandle, nameof(mSWordSelectTablehandle), required: false);
            WorkflowExpression.Validate(mSWordSelectTabledocumentName, nameof(mSWordSelectTabledocumentName), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSWordGetTableBounds))]
        public IBodyWorkflowAction<MSWordGetTableBoundsResponse> MSWordGetTableBounds([WorkflowExpression] Func<int> mSWordGetTableBoundstableIndex, [WorkflowExpression] Func<string> mSWordGetTableBoundsworkflow, [WorkflowExpression] Func<int> mSWordGetTableBoundshandle = null, [WorkflowExpression] Func<string> mSWordGetTableBoundsdocumentName = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MSWordGetTableBoundsResponse> __BuildMSWordGetTableBounds(WorkflowExpression<int> mSWordGetTableBoundstableIndex, WorkflowExpression<string> mSWordGetTableBoundsworkflow, WorkflowExpression<int> mSWordGetTableBoundshandle = null, WorkflowExpression<string> mSWordGetTableBoundsdocumentName = null)
        {
            WorkflowExpression.Validate(mSWordGetTableBoundstableIndex, nameof(mSWordGetTableBoundstableIndex), required: true);
            WorkflowExpression.Validate(mSWordGetTableBoundsworkflow, nameof(mSWordGetTableBoundsworkflow), required: true);
            WorkflowExpression.Validate(mSWordGetTableBoundshandle, nameof(mSWordGetTableBoundshandle), required: false);
            WorkflowExpression.Validate(mSWordGetTableBoundsdocumentName, nameof(mSWordGetTableBoundsdocumentName), required: false);
            return new DeferredBodyAction<MSWordGetTableBoundsResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSWordSelectTableCell))]
        public IWorkflowAction MSWordSelectTableCell([WorkflowExpression] Func<int> mSWordSelectTableCelltableIndex, [WorkflowExpression] Func<int> mSWordSelectTableCellrowIndex, [WorkflowExpression] Func<int> mSWordSelectTableCellcolumnIndex, [WorkflowExpression] Func<string> mSWordSelectTableCellworkflow, [WorkflowExpression] Func<int> mSWordSelectTableCellhandle = null, [WorkflowExpression] Func<string> mSWordSelectTableCelldocumentName = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMSWordSelectTableCell(WorkflowExpression<int> mSWordSelectTableCelltableIndex, WorkflowExpression<int> mSWordSelectTableCellrowIndex, WorkflowExpression<int> mSWordSelectTableCellcolumnIndex, WorkflowExpression<string> mSWordSelectTableCellworkflow, WorkflowExpression<int> mSWordSelectTableCellhandle = null, WorkflowExpression<string> mSWordSelectTableCelldocumentName = null)
        {
            WorkflowExpression.Validate(mSWordSelectTableCelltableIndex, nameof(mSWordSelectTableCelltableIndex), required: true);
            WorkflowExpression.Validate(mSWordSelectTableCellrowIndex, nameof(mSWordSelectTableCellrowIndex), required: true);
            WorkflowExpression.Validate(mSWordSelectTableCellcolumnIndex, nameof(mSWordSelectTableCellcolumnIndex), required: true);
            WorkflowExpression.Validate(mSWordSelectTableCellworkflow, nameof(mSWordSelectTableCellworkflow), required: true);
            WorkflowExpression.Validate(mSWordSelectTableCellhandle, nameof(mSWordSelectTableCellhandle), required: false);
            WorkflowExpression.Validate(mSWordSelectTableCelldocumentName, nameof(mSWordSelectTableCelldocumentName), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSWordGetTableCellTextValue))]
        public IBodyWorkflowAction<MSWordGetTableCellTextValueResponse> MSWordGetTableCellTextValue([WorkflowExpression] Func<int> mSWordGetTableCellTextValuetableIndex, [WorkflowExpression] Func<int> mSWordGetTableCellTextValuerowIndex, [WorkflowExpression] Func<int> mSWordGetTableCellTextValuecolumnIndex, [WorkflowExpression] Func<string> mSWordGetTableCellTextValueworkflow, [WorkflowExpression] Func<int> mSWordGetTableCellTextValuehandle = null, [WorkflowExpression] Func<string> mSWordGetTableCellTextValuedocumentName = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MSWordGetTableCellTextValueResponse> __BuildMSWordGetTableCellTextValue(WorkflowExpression<int> mSWordGetTableCellTextValuetableIndex, WorkflowExpression<int> mSWordGetTableCellTextValuerowIndex, WorkflowExpression<int> mSWordGetTableCellTextValuecolumnIndex, WorkflowExpression<string> mSWordGetTableCellTextValueworkflow, WorkflowExpression<int> mSWordGetTableCellTextValuehandle = null, WorkflowExpression<string> mSWordGetTableCellTextValuedocumentName = null)
        {
            WorkflowExpression.Validate(mSWordGetTableCellTextValuetableIndex, nameof(mSWordGetTableCellTextValuetableIndex), required: true);
            WorkflowExpression.Validate(mSWordGetTableCellTextValuerowIndex, nameof(mSWordGetTableCellTextValuerowIndex), required: true);
            WorkflowExpression.Validate(mSWordGetTableCellTextValuecolumnIndex, nameof(mSWordGetTableCellTextValuecolumnIndex), required: true);
            WorkflowExpression.Validate(mSWordGetTableCellTextValueworkflow, nameof(mSWordGetTableCellTextValueworkflow), required: true);
            WorkflowExpression.Validate(mSWordGetTableCellTextValuehandle, nameof(mSWordGetTableCellTextValuehandle), required: false);
            WorkflowExpression.Validate(mSWordGetTableCellTextValuedocumentName, nameof(mSWordGetTableCellTextValuedocumentName), required: false);
            return new DeferredBodyAction<MSWordGetTableCellTextValueResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSWordGetTableCellTextValueTrimmed))]
        public IBodyWorkflowAction<MSWordGetTableCellTextValueTrimmedResponse> MSWordGetTableCellTextValueTrimmed([WorkflowExpression] Func<int> mSWordGetTableCellTextValueTrimmedtableIndex, [WorkflowExpression] Func<int> mSWordGetTableCellTextValueTrimmedrowIndex, [WorkflowExpression] Func<int> mSWordGetTableCellTextValueTrimmedcolumnIndex, [WorkflowExpression] Func<string> mSWordGetTableCellTextValueTrimmedworkflow, [WorkflowExpression] Func<int> mSWordGetTableCellTextValueTrimmedhandle = null, [WorkflowExpression] Func<string> mSWordGetTableCellTextValueTrimmeddocumentName = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MSWordGetTableCellTextValueTrimmedResponse> __BuildMSWordGetTableCellTextValueTrimmed(WorkflowExpression<int> mSWordGetTableCellTextValueTrimmedtableIndex, WorkflowExpression<int> mSWordGetTableCellTextValueTrimmedrowIndex, WorkflowExpression<int> mSWordGetTableCellTextValueTrimmedcolumnIndex, WorkflowExpression<string> mSWordGetTableCellTextValueTrimmedworkflow, WorkflowExpression<int> mSWordGetTableCellTextValueTrimmedhandle = null, WorkflowExpression<string> mSWordGetTableCellTextValueTrimmeddocumentName = null)
        {
            WorkflowExpression.Validate(mSWordGetTableCellTextValueTrimmedtableIndex, nameof(mSWordGetTableCellTextValueTrimmedtableIndex), required: true);
            WorkflowExpression.Validate(mSWordGetTableCellTextValueTrimmedrowIndex, nameof(mSWordGetTableCellTextValueTrimmedrowIndex), required: true);
            WorkflowExpression.Validate(mSWordGetTableCellTextValueTrimmedcolumnIndex, nameof(mSWordGetTableCellTextValueTrimmedcolumnIndex), required: true);
            WorkflowExpression.Validate(mSWordGetTableCellTextValueTrimmedworkflow, nameof(mSWordGetTableCellTextValueTrimmedworkflow), required: true);
            WorkflowExpression.Validate(mSWordGetTableCellTextValueTrimmedhandle, nameof(mSWordGetTableCellTextValueTrimmedhandle), required: false);
            WorkflowExpression.Validate(mSWordGetTableCellTextValueTrimmeddocumentName, nameof(mSWordGetTableCellTextValueTrimmeddocumentName), required: false);
            return new DeferredBodyAction<MSWordGetTableCellTextValueTrimmedResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSWordSetTableCellTextValue))]
        public IWorkflowAction MSWordSetTableCellTextValue([WorkflowExpression] Func<int> mSWordSetTableCellTextValuetableIndex, [WorkflowExpression] Func<int> mSWordSetTableCellTextValuerowIndex, [WorkflowExpression] Func<int> mSWordSetTableCellTextValuecolumnIndex, [WorkflowExpression] Func<string> mSWordSetTableCellTextValueworkflow, [WorkflowExpression] Func<int> mSWordSetTableCellTextValuehandle = null, [WorkflowExpression] Func<string> mSWordSetTableCellTextValuedocumentName = null, [WorkflowExpression] Func<string> mSWordSetTableCellTextValuenewCellText = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMSWordSetTableCellTextValue(WorkflowExpression<int> mSWordSetTableCellTextValuetableIndex, WorkflowExpression<int> mSWordSetTableCellTextValuerowIndex, WorkflowExpression<int> mSWordSetTableCellTextValuecolumnIndex, WorkflowExpression<string> mSWordSetTableCellTextValueworkflow, WorkflowExpression<int> mSWordSetTableCellTextValuehandle = null, WorkflowExpression<string> mSWordSetTableCellTextValuedocumentName = null, WorkflowExpression<string> mSWordSetTableCellTextValuenewCellText = null)
        {
            WorkflowExpression.Validate(mSWordSetTableCellTextValuetableIndex, nameof(mSWordSetTableCellTextValuetableIndex), required: true);
            WorkflowExpression.Validate(mSWordSetTableCellTextValuerowIndex, nameof(mSWordSetTableCellTextValuerowIndex), required: true);
            WorkflowExpression.Validate(mSWordSetTableCellTextValuecolumnIndex, nameof(mSWordSetTableCellTextValuecolumnIndex), required: true);
            WorkflowExpression.Validate(mSWordSetTableCellTextValueworkflow, nameof(mSWordSetTableCellTextValueworkflow), required: true);
            WorkflowExpression.Validate(mSWordSetTableCellTextValuehandle, nameof(mSWordSetTableCellTextValuehandle), required: false);
            WorkflowExpression.Validate(mSWordSetTableCellTextValuedocumentName, nameof(mSWordSetTableCellTextValuedocumentName), required: false);
            WorkflowExpression.Validate(mSWordSetTableCellTextValuenewCellText, nameof(mSWordSetTableCellTextValuenewCellText), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSWordExportDocumentAsPDF))]
        public IWorkflowAction MSWordExportDocumentAsPDF([WorkflowExpression] Func<string> mSWordExportDocumentAsPDFsaveFileName, [WorkflowExpression] Func<string> mSWordExportDocumentAsPDFworkflow, [WorkflowExpression] Func<int> mSWordExportDocumentAsPDFhandle = null, [WorkflowExpression] Func<string> mSWordExportDocumentAsPDFdocumentName = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMSWordExportDocumentAsPDF(WorkflowExpression<string> mSWordExportDocumentAsPDFsaveFileName, WorkflowExpression<string> mSWordExportDocumentAsPDFworkflow, WorkflowExpression<int> mSWordExportDocumentAsPDFhandle = null, WorkflowExpression<string> mSWordExportDocumentAsPDFdocumentName = null)
        {
            WorkflowExpression.Validate(mSWordExportDocumentAsPDFsaveFileName, nameof(mSWordExportDocumentAsPDFsaveFileName), required: true);
            WorkflowExpression.Validate(mSWordExportDocumentAsPDFworkflow, nameof(mSWordExportDocumentAsPDFworkflow), required: true);
            WorkflowExpression.Validate(mSWordExportDocumentAsPDFhandle, nameof(mSWordExportDocumentAsPDFhandle), required: false);
            WorkflowExpression.Validate(mSWordExportDocumentAsPDFdocumentName, nameof(mSWordExportDocumentAsPDFdocumentName), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSWordAddTable))]
        public IWorkflowAction MSWordAddTable([WorkflowExpression] Func<int> mSWordAddTablenumberOfRows, [WorkflowExpression] Func<int> mSWordAddTablenumberOfColumns, [WorkflowExpression] Func<string> mSWordAddTableworkflow, [WorkflowExpression] Func<int> mSWordAddTablehandle = null, [WorkflowExpression] Func<string> mSWordAddTabledocumentName = null, [WorkflowExpression] Func<int> mSWordAddTableautoFitBehaviour = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMSWordAddTable(WorkflowExpression<int> mSWordAddTablenumberOfRows, WorkflowExpression<int> mSWordAddTablenumberOfColumns, WorkflowExpression<string> mSWordAddTableworkflow, WorkflowExpression<int> mSWordAddTablehandle = null, WorkflowExpression<string> mSWordAddTabledocumentName = null, WorkflowExpression<int> mSWordAddTableautoFitBehaviour = null)
        {
            WorkflowExpression.Validate(mSWordAddTablenumberOfRows, nameof(mSWordAddTablenumberOfRows), required: true);
            WorkflowExpression.Validate(mSWordAddTablenumberOfColumns, nameof(mSWordAddTablenumberOfColumns), required: true);
            WorkflowExpression.Validate(mSWordAddTableworkflow, nameof(mSWordAddTableworkflow), required: true);
            WorkflowExpression.Validate(mSWordAddTablehandle, nameof(mSWordAddTablehandle), required: false);
            WorkflowExpression.Validate(mSWordAddTabledocumentName, nameof(mSWordAddTabledocumentName), required: false);
            WorkflowExpression.Validate(mSWordAddTableautoFitBehaviour, nameof(mSWordAddTableautoFitBehaviour), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSWordAddTableRow))]
        public IWorkflowAction MSWordAddTableRow([WorkflowExpression] Func<int> mSWordAddTableRowtableIndex, [WorkflowExpression] Func<string> mSWordAddTableRowworkflow, [WorkflowExpression] Func<int> mSWordAddTableRowhandle = null, [WorkflowExpression] Func<string> mSWordAddTableRowdocumentName = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMSWordAddTableRow(WorkflowExpression<int> mSWordAddTableRowtableIndex, WorkflowExpression<string> mSWordAddTableRowworkflow, WorkflowExpression<int> mSWordAddTableRowhandle = null, WorkflowExpression<string> mSWordAddTableRowdocumentName = null)
        {
            WorkflowExpression.Validate(mSWordAddTableRowtableIndex, nameof(mSWordAddTableRowtableIndex), required: true);
            WorkflowExpression.Validate(mSWordAddTableRowworkflow, nameof(mSWordAddTableRowworkflow), required: true);
            WorkflowExpression.Validate(mSWordAddTableRowhandle, nameof(mSWordAddTableRowhandle), required: false);
            WorkflowExpression.Validate(mSWordAddTableRowdocumentName, nameof(mSWordAddTableRowdocumentName), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSWordAddTableColumn))]
        public IWorkflowAction MSWordAddTableColumn([WorkflowExpression] Func<int> mSWordAddTableColumntableIndex, [WorkflowExpression] Func<string> mSWordAddTableColumnworkflow, [WorkflowExpression] Func<int> mSWordAddTableColumnhandle = null, [WorkflowExpression] Func<string> mSWordAddTableColumndocumentName = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMSWordAddTableColumn(WorkflowExpression<int> mSWordAddTableColumntableIndex, WorkflowExpression<string> mSWordAddTableColumnworkflow, WorkflowExpression<int> mSWordAddTableColumnhandle = null, WorkflowExpression<string> mSWordAddTableColumndocumentName = null)
        {
            WorkflowExpression.Validate(mSWordAddTableColumntableIndex, nameof(mSWordAddTableColumntableIndex), required: true);
            WorkflowExpression.Validate(mSWordAddTableColumnworkflow, nameof(mSWordAddTableColumnworkflow), required: true);
            WorkflowExpression.Validate(mSWordAddTableColumnhandle, nameof(mSWordAddTableColumnhandle), required: false);
            WorkflowExpression.Validate(mSWordAddTableColumndocumentName, nameof(mSWordAddTableColumndocumentName), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSWordGetHighlightedText))]
        public IBodyWorkflowAction<MSWordGetHighlightedTextResponse> MSWordGetHighlightedText([WorkflowExpression] Func<string> mSWordGetHighlightedTextworkflow, [WorkflowExpression] Func<int> mSWordGetHighlightedTexthandle = null, [WorkflowExpression] Func<string> mSWordGetHighlightedTextdocumentName = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MSWordGetHighlightedTextResponse> __BuildMSWordGetHighlightedText(WorkflowExpression<string> mSWordGetHighlightedTextworkflow, WorkflowExpression<int> mSWordGetHighlightedTexthandle = null, WorkflowExpression<string> mSWordGetHighlightedTextdocumentName = null)
        {
            WorkflowExpression.Validate(mSWordGetHighlightedTextworkflow, nameof(mSWordGetHighlightedTextworkflow), required: true);
            WorkflowExpression.Validate(mSWordGetHighlightedTexthandle, nameof(mSWordGetHighlightedTexthandle), required: false);
            WorkflowExpression.Validate(mSWordGetHighlightedTextdocumentName, nameof(mSWordGetHighlightedTextdocumentName), required: false);
            return new DeferredBodyAction<MSWordGetHighlightedTextResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSWordExecuteCommandBarObject))]
        public IBodyWorkflowAction<MSWordExecuteCommandBarObjectResponse> MSWordExecuteCommandBarObject([WorkflowExpression] Func<string> mSWordExecuteCommandBarObjectobjectId, [WorkflowExpression] Func<string> mSWordExecuteCommandBarObjectworkflow, [WorkflowExpression] Func<int> mSWordExecuteCommandBarObjecthandle = null, [WorkflowExpression] Func<bool> mSWordExecuteCommandBarObjectrunInBackground = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MSWordExecuteCommandBarObjectResponse> __BuildMSWordExecuteCommandBarObject(WorkflowExpression<string> mSWordExecuteCommandBarObjectobjectId, WorkflowExpression<string> mSWordExecuteCommandBarObjectworkflow, WorkflowExpression<int> mSWordExecuteCommandBarObjecthandle = null, WorkflowExpression<bool> mSWordExecuteCommandBarObjectrunInBackground = null)
        {
            WorkflowExpression.Validate(mSWordExecuteCommandBarObjectobjectId, nameof(mSWordExecuteCommandBarObjectobjectId), required: true);
            WorkflowExpression.Validate(mSWordExecuteCommandBarObjectworkflow, nameof(mSWordExecuteCommandBarObjectworkflow), required: true);
            WorkflowExpression.Validate(mSWordExecuteCommandBarObjecthandle, nameof(mSWordExecuteCommandBarObjecthandle), required: false);
            WorkflowExpression.Validate(mSWordExecuteCommandBarObjectrunInBackground, nameof(mSWordExecuteCommandBarObjectrunInBackground), required: false);
            return new DeferredBodyAction<MSWordExecuteCommandBarObjectResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSWordSetDocumentSensitivityLabel))]
        public IBodyWorkflowAction<MSWordSetDocumentSensitivityLabelResponse> MSWordSetDocumentSensitivityLabel([WorkflowExpression] Func<mSWordSetDocumentSensitivityLabelassignmentMethodInput> mSWordSetDocumentSensitivityLabelassignmentMethod, [WorkflowExpression] Func<string> mSWordSetDocumentSensitivityLabellabelId, [WorkflowExpression] Func<string> mSWordSetDocumentSensitivityLabelworkflow, [WorkflowExpression] Func<int> mSWordSetDocumentSensitivityLabelhandle = null, [WorkflowExpression] Func<string> mSWordSetDocumentSensitivityLabeldocumentName = null, [WorkflowExpression] Func<string> mSWordSetDocumentSensitivityLabellabelName = null, [WorkflowExpression] Func<string> mSWordSetDocumentSensitivityLabelsiteId = null, [WorkflowExpression] Func<string> mSWordSetDocumentSensitivityLabeljustification = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MSWordSetDocumentSensitivityLabelResponse> __BuildMSWordSetDocumentSensitivityLabel(WorkflowExpression<mSWordSetDocumentSensitivityLabelassignmentMethodInput> mSWordSetDocumentSensitivityLabelassignmentMethod, WorkflowExpression<string> mSWordSetDocumentSensitivityLabellabelId, WorkflowExpression<string> mSWordSetDocumentSensitivityLabelworkflow, WorkflowExpression<int> mSWordSetDocumentSensitivityLabelhandle = null, WorkflowExpression<string> mSWordSetDocumentSensitivityLabeldocumentName = null, WorkflowExpression<string> mSWordSetDocumentSensitivityLabellabelName = null, WorkflowExpression<string> mSWordSetDocumentSensitivityLabelsiteId = null, WorkflowExpression<string> mSWordSetDocumentSensitivityLabeljustification = null)
        {
            WorkflowExpression.Validate(mSWordSetDocumentSensitivityLabelassignmentMethod, nameof(mSWordSetDocumentSensitivityLabelassignmentMethod), required: true);
            WorkflowExpression.Validate(mSWordSetDocumentSensitivityLabellabelId, nameof(mSWordSetDocumentSensitivityLabellabelId), required: true);
            WorkflowExpression.Validate(mSWordSetDocumentSensitivityLabelworkflow, nameof(mSWordSetDocumentSensitivityLabelworkflow), required: true);
            WorkflowExpression.Validate(mSWordSetDocumentSensitivityLabelhandle, nameof(mSWordSetDocumentSensitivityLabelhandle), required: false);
            WorkflowExpression.Validate(mSWordSetDocumentSensitivityLabeldocumentName, nameof(mSWordSetDocumentSensitivityLabeldocumentName), required: false);
            WorkflowExpression.Validate(mSWordSetDocumentSensitivityLabellabelName, nameof(mSWordSetDocumentSensitivityLabellabelName), required: false);
            WorkflowExpression.Validate(mSWordSetDocumentSensitivityLabelsiteId, nameof(mSWordSetDocumentSensitivityLabelsiteId), required: false);
            WorkflowExpression.Validate(mSWordSetDocumentSensitivityLabeljustification, nameof(mSWordSetDocumentSensitivityLabeljustification), required: false);
            return new DeferredBodyAction<MSWordSetDocumentSensitivityLabelResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSWordGetDocumentSensitivityLabel))]
        public IBodyWorkflowAction<MSWordGetDocumentSensitivityLabelResponse> MSWordGetDocumentSensitivityLabel([WorkflowExpression] Func<string> mSWordGetDocumentSensitivityLabelworkflow, [WorkflowExpression] Func<int> mSWordGetDocumentSensitivityLabelhandle = null, [WorkflowExpression] Func<string> mSWordGetDocumentSensitivityLabeldocumentName = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MSWordGetDocumentSensitivityLabelResponse> __BuildMSWordGetDocumentSensitivityLabel(WorkflowExpression<string> mSWordGetDocumentSensitivityLabelworkflow, WorkflowExpression<int> mSWordGetDocumentSensitivityLabelhandle = null, WorkflowExpression<string> mSWordGetDocumentSensitivityLabeldocumentName = null)
        {
            WorkflowExpression.Validate(mSWordGetDocumentSensitivityLabelworkflow, nameof(mSWordGetDocumentSensitivityLabelworkflow), required: true);
            WorkflowExpression.Validate(mSWordGetDocumentSensitivityLabelhandle, nameof(mSWordGetDocumentSensitivityLabelhandle), required: false);
            WorkflowExpression.Validate(mSWordGetDocumentSensitivityLabeldocumentName, nameof(mSWordGetDocumentSensitivityLabeldocumentName), required: false);
            return new DeferredBodyAction<MSWordGetDocumentSensitivityLabelResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSExcelCreateInstance))]
        public IBodyWorkflowAction<MSExcelCreateInstanceResponse> MSExcelCreateInstance([WorkflowExpression] Func<string> mSExcelCreateInstanceworkflow, [WorkflowExpression] Func<bool> mSExcelCreateInstanceenableEvents = null, [WorkflowExpression] Func<bool> mSExcelCreateInstanceshowExcel = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MSExcelCreateInstanceResponse> __BuildMSExcelCreateInstance(WorkflowExpression<string> mSExcelCreateInstanceworkflow, WorkflowExpression<bool> mSExcelCreateInstanceenableEvents = null, WorkflowExpression<bool> mSExcelCreateInstanceshowExcel = null)
        {
            WorkflowExpression.Validate(mSExcelCreateInstanceworkflow, nameof(mSExcelCreateInstanceworkflow), required: true);
            WorkflowExpression.Validate(mSExcelCreateInstanceenableEvents, nameof(mSExcelCreateInstanceenableEvents), required: false);
            WorkflowExpression.Validate(mSExcelCreateInstanceshowExcel, nameof(mSExcelCreateInstanceshowExcel), required: false);
            return new DeferredBodyAction<MSExcelCreateInstanceResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSExcelCloseInstance))]
        public IWorkflowAction MSExcelCloseInstance([WorkflowExpression] Func<string> mSExcelCloseInstanceworkflow, [WorkflowExpression] Func<int> mSExcelCloseInstancehandle = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMSExcelCloseInstance(WorkflowExpression<string> mSExcelCloseInstanceworkflow, WorkflowExpression<int> mSExcelCloseInstancehandle = null)
        {
            WorkflowExpression.Validate(mSExcelCloseInstanceworkflow, nameof(mSExcelCloseInstanceworkflow), required: true);
            WorkflowExpression.Validate(mSExcelCloseInstancehandle, nameof(mSExcelCloseInstancehandle), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSExcelAttachToExistingInstance))]
        public IBodyWorkflowAction<MSExcelAttachToExistingInstanceResponse> MSExcelAttachToExistingInstance([WorkflowExpression] Func<string> mSExcelAttachToExistingInstanceworkflow, [WorkflowExpression] Func<string> mSExcelAttachToExistingInstancefilename = null, [WorkflowExpression] Func<bool> mSExcelAttachToExistingInstancetoggleWindow = null, [WorkflowExpression] Func<bool> mSExcelAttachToExistingInstancetoggleUsesGlobalLeftMouseClickAgent = null, [WorkflowExpression] Func<double> mSExcelAttachToExistingInstancetoggleDelay = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MSExcelAttachToExistingInstanceResponse> __BuildMSExcelAttachToExistingInstance(WorkflowExpression<string> mSExcelAttachToExistingInstanceworkflow, WorkflowExpression<string> mSExcelAttachToExistingInstancefilename = null, WorkflowExpression<bool> mSExcelAttachToExistingInstancetoggleWindow = null, WorkflowExpression<bool> mSExcelAttachToExistingInstancetoggleUsesGlobalLeftMouseClickAgent = null, WorkflowExpression<double> mSExcelAttachToExistingInstancetoggleDelay = null)
        {
            WorkflowExpression.Validate(mSExcelAttachToExistingInstanceworkflow, nameof(mSExcelAttachToExistingInstanceworkflow), required: true);
            WorkflowExpression.Validate(mSExcelAttachToExistingInstancefilename, nameof(mSExcelAttachToExistingInstancefilename), required: false);
            WorkflowExpression.Validate(mSExcelAttachToExistingInstancetoggleWindow, nameof(mSExcelAttachToExistingInstancetoggleWindow), required: false);
            WorkflowExpression.Validate(mSExcelAttachToExistingInstancetoggleUsesGlobalLeftMouseClickAgent, nameof(mSExcelAttachToExistingInstancetoggleUsesGlobalLeftMouseClickAgent), required: false);
            WorkflowExpression.Validate(mSExcelAttachToExistingInstancetoggleDelay, nameof(mSExcelAttachToExistingInstancetoggleDelay), required: false);
            return new DeferredBodyAction<MSExcelAttachToExistingInstanceResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSExcelShowExcel))]
        public IWorkflowAction MSExcelShowExcel([WorkflowExpression] Func<string> mSExcelShowExcelworkflow, [WorkflowExpression] Func<int> mSExcelShowExcelhandle = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMSExcelShowExcel(WorkflowExpression<string> mSExcelShowExcelworkflow, WorkflowExpression<int> mSExcelShowExcelhandle = null)
        {
            WorkflowExpression.Validate(mSExcelShowExcelworkflow, nameof(mSExcelShowExcelworkflow), required: true);
            WorkflowExpression.Validate(mSExcelShowExcelhandle, nameof(mSExcelShowExcelhandle), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSExcelHideExcel))]
        public IWorkflowAction MSExcelHideExcel([WorkflowExpression] Func<string> mSExcelHideExcelworkflow, [WorkflowExpression] Func<int> mSExcelHideExcelhandle = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMSExcelHideExcel(WorkflowExpression<string> mSExcelHideExcelworkflow, WorkflowExpression<int> mSExcelHideExcelhandle = null)
        {
            WorkflowExpression.Validate(mSExcelHideExcelworkflow, nameof(mSExcelHideExcelworkflow), required: true);
            WorkflowExpression.Validate(mSExcelHideExcelhandle, nameof(mSExcelHideExcelhandle), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSExcelOpenWorkbook))]
        public IBodyWorkflowAction<MSExcelOpenWorkbookResponse> MSExcelOpenWorkbook([WorkflowExpression] Func<string> mSExcelOpenWorkbookworkflow, [WorkflowExpression] Func<int> mSExcelOpenWorkbookhandle = null, [WorkflowExpression] Func<string> mSExcelOpenWorkbookfilename = null, [WorkflowExpression] Func<bool> mSExcelOpenWorkbookreadOnly = null, [WorkflowExpression] Func<bool> mSExcelOpenWorkbookupdateLinks = null, [WorkflowExpression] Func<string> mSExcelOpenWorkbookpassword = null, [WorkflowExpression] Func<bool> mSExcelOpenWorkbookenableEvents = null, [WorkflowExpression] Func<bool> mSExcelOpenWorkbookputHTTPWorkbooksIntoEditMode = null, [WorkflowExpression] Func<bool> mSExcelOpenWorkbookputFilePathWorkbooksIntoEditMode = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MSExcelOpenWorkbookResponse> __BuildMSExcelOpenWorkbook(WorkflowExpression<string> mSExcelOpenWorkbookworkflow, WorkflowExpression<int> mSExcelOpenWorkbookhandle = null, WorkflowExpression<string> mSExcelOpenWorkbookfilename = null, WorkflowExpression<bool> mSExcelOpenWorkbookreadOnly = null, WorkflowExpression<bool> mSExcelOpenWorkbookupdateLinks = null, WorkflowExpression<string> mSExcelOpenWorkbookpassword = null, WorkflowExpression<bool> mSExcelOpenWorkbookenableEvents = null, WorkflowExpression<bool> mSExcelOpenWorkbookputHTTPWorkbooksIntoEditMode = null, WorkflowExpression<bool> mSExcelOpenWorkbookputFilePathWorkbooksIntoEditMode = null)
        {
            WorkflowExpression.Validate(mSExcelOpenWorkbookworkflow, nameof(mSExcelOpenWorkbookworkflow), required: true);
            WorkflowExpression.Validate(mSExcelOpenWorkbookhandle, nameof(mSExcelOpenWorkbookhandle), required: false);
            WorkflowExpression.Validate(mSExcelOpenWorkbookfilename, nameof(mSExcelOpenWorkbookfilename), required: false);
            WorkflowExpression.Validate(mSExcelOpenWorkbookreadOnly, nameof(mSExcelOpenWorkbookreadOnly), required: false);
            WorkflowExpression.Validate(mSExcelOpenWorkbookupdateLinks, nameof(mSExcelOpenWorkbookupdateLinks), required: false);
            WorkflowExpression.Validate(mSExcelOpenWorkbookpassword, nameof(mSExcelOpenWorkbookpassword), required: false);
            WorkflowExpression.Validate(mSExcelOpenWorkbookenableEvents, nameof(mSExcelOpenWorkbookenableEvents), required: false);
            WorkflowExpression.Validate(mSExcelOpenWorkbookputHTTPWorkbooksIntoEditMode, nameof(mSExcelOpenWorkbookputHTTPWorkbooksIntoEditMode), required: false);
            WorkflowExpression.Validate(mSExcelOpenWorkbookputFilePathWorkbooksIntoEditMode, nameof(mSExcelOpenWorkbookputFilePathWorkbooksIntoEditMode), required: false);
            return new DeferredBodyAction<MSExcelOpenWorkbookResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSExcelPutWorkbookInEditMode))]
        public IBodyWorkflowAction<MSExcelPutWorkbookInEditModeResponse> MSExcelPutWorkbookInEditMode([WorkflowExpression] Func<string> mSExcelPutWorkbookInEditModeworkflow, [WorkflowExpression] Func<int> mSExcelPutWorkbookInEditModehandle = null, [WorkflowExpression] Func<string> mSExcelPutWorkbookInEditModeworkbookName = null, [WorkflowExpression] Func<bool> mSExcelPutWorkbookInEditModeforce = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MSExcelPutWorkbookInEditModeResponse> __BuildMSExcelPutWorkbookInEditMode(WorkflowExpression<string> mSExcelPutWorkbookInEditModeworkflow, WorkflowExpression<int> mSExcelPutWorkbookInEditModehandle = null, WorkflowExpression<string> mSExcelPutWorkbookInEditModeworkbookName = null, WorkflowExpression<bool> mSExcelPutWorkbookInEditModeforce = null)
        {
            WorkflowExpression.Validate(mSExcelPutWorkbookInEditModeworkflow, nameof(mSExcelPutWorkbookInEditModeworkflow), required: true);
            WorkflowExpression.Validate(mSExcelPutWorkbookInEditModehandle, nameof(mSExcelPutWorkbookInEditModehandle), required: false);
            WorkflowExpression.Validate(mSExcelPutWorkbookInEditModeworkbookName, nameof(mSExcelPutWorkbookInEditModeworkbookName), required: false);
            WorkflowExpression.Validate(mSExcelPutWorkbookInEditModeforce, nameof(mSExcelPutWorkbookInEditModeforce), required: false);
            return new DeferredBodyAction<MSExcelPutWorkbookInEditModeResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSExcelCreateWorkbook))]
        public IBodyWorkflowAction<MSExcelCreateWorkbookResponse> MSExcelCreateWorkbook([WorkflowExpression] Func<string> mSExcelCreateWorkbookworkflow, [WorkflowExpression] Func<int> mSExcelCreateWorkbookhandle = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MSExcelCreateWorkbookResponse> __BuildMSExcelCreateWorkbook(WorkflowExpression<string> mSExcelCreateWorkbookworkflow, WorkflowExpression<int> mSExcelCreateWorkbookhandle = null)
        {
            WorkflowExpression.Validate(mSExcelCreateWorkbookworkflow, nameof(mSExcelCreateWorkbookworkflow), required: true);
            WorkflowExpression.Validate(mSExcelCreateWorkbookhandle, nameof(mSExcelCreateWorkbookhandle), required: false);
            return new DeferredBodyAction<MSExcelCreateWorkbookResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSExcelCloseWorkbook))]
        public IWorkflowAction MSExcelCloseWorkbook([WorkflowExpression] Func<string> mSExcelCloseWorkbookworkflow, [WorkflowExpression] Func<int> mSExcelCloseWorkbookhandle = null, [WorkflowExpression] Func<string> mSExcelCloseWorkbookworkbookName = null, [WorkflowExpression] Func<bool> mSExcelCloseWorkbooksaveData = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMSExcelCloseWorkbook(WorkflowExpression<string> mSExcelCloseWorkbookworkflow, WorkflowExpression<int> mSExcelCloseWorkbookhandle = null, WorkflowExpression<string> mSExcelCloseWorkbookworkbookName = null, WorkflowExpression<bool> mSExcelCloseWorkbooksaveData = null)
        {
            WorkflowExpression.Validate(mSExcelCloseWorkbookworkflow, nameof(mSExcelCloseWorkbookworkflow), required: true);
            WorkflowExpression.Validate(mSExcelCloseWorkbookhandle, nameof(mSExcelCloseWorkbookhandle), required: false);
            WorkflowExpression.Validate(mSExcelCloseWorkbookworkbookName, nameof(mSExcelCloseWorkbookworkbookName), required: false);
            WorkflowExpression.Validate(mSExcelCloseWorkbooksaveData, nameof(mSExcelCloseWorkbooksaveData), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSExcelCloseCurrentWorkbook))]
        public IWorkflowAction MSExcelCloseCurrentWorkbook([WorkflowExpression] Func<string> mSExcelCloseCurrentWorkbookworkflow, [WorkflowExpression] Func<int> mSExcelCloseCurrentWorkbookhandle = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMSExcelCloseCurrentWorkbook(WorkflowExpression<string> mSExcelCloseCurrentWorkbookworkflow, WorkflowExpression<int> mSExcelCloseCurrentWorkbookhandle = null)
        {
            WorkflowExpression.Validate(mSExcelCloseCurrentWorkbookworkflow, nameof(mSExcelCloseCurrentWorkbookworkflow), required: true);
            WorkflowExpression.Validate(mSExcelCloseCurrentWorkbookhandle, nameof(mSExcelCloseCurrentWorkbookhandle), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSExcelGoToCell))]
        public IWorkflowAction MSExcelGoToCell([WorkflowExpression] Func<string> mSExcelGoToCellcellReference, [WorkflowExpression] Func<string> mSExcelGoToCellworkflow, [WorkflowExpression] Func<int> mSExcelGoToCellhandle = null, [WorkflowExpression] Func<string> mSExcelGoToCellworkbookName = null, [WorkflowExpression] Func<string> mSExcelGoToCellworksheetName = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMSExcelGoToCell(WorkflowExpression<string> mSExcelGoToCellcellReference, WorkflowExpression<string> mSExcelGoToCellworkflow, WorkflowExpression<int> mSExcelGoToCellhandle = null, WorkflowExpression<string> mSExcelGoToCellworkbookName = null, WorkflowExpression<string> mSExcelGoToCellworksheetName = null)
        {
            WorkflowExpression.Validate(mSExcelGoToCellcellReference, nameof(mSExcelGoToCellcellReference), required: true);
            WorkflowExpression.Validate(mSExcelGoToCellworkflow, nameof(mSExcelGoToCellworkflow), required: true);
            WorkflowExpression.Validate(mSExcelGoToCellhandle, nameof(mSExcelGoToCellhandle), required: false);
            WorkflowExpression.Validate(mSExcelGoToCellworkbookName, nameof(mSExcelGoToCellworkbookName), required: false);
            WorkflowExpression.Validate(mSExcelGoToCellworksheetName, nameof(mSExcelGoToCellworksheetName), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSExcelGetCellValue))]
        public IBodyWorkflowAction<MSExcelGetCellValueResponse> MSExcelGetCellValue([WorkflowExpression] Func<string> mSExcelGetCellValuecellReference, [WorkflowExpression] Func<string> mSExcelGetCellValueworkflow, [WorkflowExpression] Func<int> mSExcelGetCellValuehandle = null, [WorkflowExpression] Func<string> mSExcelGetCellValueworkbookName = null, [WorkflowExpression] Func<string> mSExcelGetCellValueworksheetName = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MSExcelGetCellValueResponse> __BuildMSExcelGetCellValue(WorkflowExpression<string> mSExcelGetCellValuecellReference, WorkflowExpression<string> mSExcelGetCellValueworkflow, WorkflowExpression<int> mSExcelGetCellValuehandle = null, WorkflowExpression<string> mSExcelGetCellValueworkbookName = null, WorkflowExpression<string> mSExcelGetCellValueworksheetName = null)
        {
            WorkflowExpression.Validate(mSExcelGetCellValuecellReference, nameof(mSExcelGetCellValuecellReference), required: true);
            WorkflowExpression.Validate(mSExcelGetCellValueworkflow, nameof(mSExcelGetCellValueworkflow), required: true);
            WorkflowExpression.Validate(mSExcelGetCellValuehandle, nameof(mSExcelGetCellValuehandle), required: false);
            WorkflowExpression.Validate(mSExcelGetCellValueworkbookName, nameof(mSExcelGetCellValueworkbookName), required: false);
            WorkflowExpression.Validate(mSExcelGetCellValueworksheetName, nameof(mSExcelGetCellValueworksheetName), required: false);
            return new DeferredBodyAction<MSExcelGetCellValueResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSExcelGetCellValue2))]
        public IBodyWorkflowAction<MSExcelGetCellValue2Response> MSExcelGetCellValue2([WorkflowExpression] Func<string> mSExcelGetCellValue2cellReference, [WorkflowExpression] Func<string> mSExcelGetCellValue2workflow, [WorkflowExpression] Func<int> mSExcelGetCellValue2handle = null, [WorkflowExpression] Func<string> mSExcelGetCellValue2workbookName = null, [WorkflowExpression] Func<string> mSExcelGetCellValue2worksheetName = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MSExcelGetCellValue2Response> __BuildMSExcelGetCellValue2(WorkflowExpression<string> mSExcelGetCellValue2cellReference, WorkflowExpression<string> mSExcelGetCellValue2workflow, WorkflowExpression<int> mSExcelGetCellValue2handle = null, WorkflowExpression<string> mSExcelGetCellValue2workbookName = null, WorkflowExpression<string> mSExcelGetCellValue2worksheetName = null)
        {
            WorkflowExpression.Validate(mSExcelGetCellValue2cellReference, nameof(mSExcelGetCellValue2cellReference), required: true);
            WorkflowExpression.Validate(mSExcelGetCellValue2workflow, nameof(mSExcelGetCellValue2workflow), required: true);
            WorkflowExpression.Validate(mSExcelGetCellValue2handle, nameof(mSExcelGetCellValue2handle), required: false);
            WorkflowExpression.Validate(mSExcelGetCellValue2workbookName, nameof(mSExcelGetCellValue2workbookName), required: false);
            WorkflowExpression.Validate(mSExcelGetCellValue2worksheetName, nameof(mSExcelGetCellValue2worksheetName), required: false);
            return new DeferredBodyAction<MSExcelGetCellValue2Response>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSExcelGetCellText))]
        public IBodyWorkflowAction<MSExcelGetCellTextResponse> MSExcelGetCellText([WorkflowExpression] Func<string> mSExcelGetCellTextcellReference, [WorkflowExpression] Func<string> mSExcelGetCellTextworkflow, [WorkflowExpression] Func<int> mSExcelGetCellTexthandle = null, [WorkflowExpression] Func<string> mSExcelGetCellTextworkbookName = null, [WorkflowExpression] Func<string> mSExcelGetCellTextworksheetName = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MSExcelGetCellTextResponse> __BuildMSExcelGetCellText(WorkflowExpression<string> mSExcelGetCellTextcellReference, WorkflowExpression<string> mSExcelGetCellTextworkflow, WorkflowExpression<int> mSExcelGetCellTexthandle = null, WorkflowExpression<string> mSExcelGetCellTextworkbookName = null, WorkflowExpression<string> mSExcelGetCellTextworksheetName = null)
        {
            WorkflowExpression.Validate(mSExcelGetCellTextcellReference, nameof(mSExcelGetCellTextcellReference), required: true);
            WorkflowExpression.Validate(mSExcelGetCellTextworkflow, nameof(mSExcelGetCellTextworkflow), required: true);
            WorkflowExpression.Validate(mSExcelGetCellTexthandle, nameof(mSExcelGetCellTexthandle), required: false);
            WorkflowExpression.Validate(mSExcelGetCellTextworkbookName, nameof(mSExcelGetCellTextworkbookName), required: false);
            WorkflowExpression.Validate(mSExcelGetCellTextworksheetName, nameof(mSExcelGetCellTextworksheetName), required: false);
            return new DeferredBodyAction<MSExcelGetCellTextResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSExcelSetCellValue))]
        public IWorkflowAction MSExcelSetCellValue([WorkflowExpression] Func<string> mSExcelSetCellValuecellReference, [WorkflowExpression] Func<string> mSExcelSetCellValueworkflow, [WorkflowExpression] Func<int> mSExcelSetCellValuehandle = null, [WorkflowExpression] Func<string> mSExcelSetCellValueworkbookName = null, [WorkflowExpression] Func<string> mSExcelSetCellValueworksheetName = null, [WorkflowExpression] Func<string> mSExcelSetCellValuecellValue = null, [WorkflowExpression] Func<bool> mSExcelSetCellValuecellValueContainsStoredPassword = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMSExcelSetCellValue(WorkflowExpression<string> mSExcelSetCellValuecellReference, WorkflowExpression<string> mSExcelSetCellValueworkflow, WorkflowExpression<int> mSExcelSetCellValuehandle = null, WorkflowExpression<string> mSExcelSetCellValueworkbookName = null, WorkflowExpression<string> mSExcelSetCellValueworksheetName = null, WorkflowExpression<string> mSExcelSetCellValuecellValue = null, WorkflowExpression<bool> mSExcelSetCellValuecellValueContainsStoredPassword = null)
        {
            WorkflowExpression.Validate(mSExcelSetCellValuecellReference, nameof(mSExcelSetCellValuecellReference), required: true);
            WorkflowExpression.Validate(mSExcelSetCellValueworkflow, nameof(mSExcelSetCellValueworkflow), required: true);
            WorkflowExpression.Validate(mSExcelSetCellValuehandle, nameof(mSExcelSetCellValuehandle), required: false);
            WorkflowExpression.Validate(mSExcelSetCellValueworkbookName, nameof(mSExcelSetCellValueworkbookName), required: false);
            WorkflowExpression.Validate(mSExcelSetCellValueworksheetName, nameof(mSExcelSetCellValueworksheetName), required: false);
            WorkflowExpression.Validate(mSExcelSetCellValuecellValue, nameof(mSExcelSetCellValuecellValue), required: false);
            WorkflowExpression.Validate(mSExcelSetCellValuecellValueContainsStoredPassword, nameof(mSExcelSetCellValuecellValueContainsStoredPassword), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSExcelFindNextCellWithValue))]
        public IBodyWorkflowAction<MSExcelFindNextCellWithValueResponse> MSExcelFindNextCellWithValue([WorkflowExpression] Func<mSExcelFindNextCellWithValuedirectionInput> mSExcelFindNextCellWithValuedirection, [WorkflowExpression] Func<string> mSExcelFindNextCellWithValuesearchValue, [WorkflowExpression] Func<string> mSExcelFindNextCellWithValueworkflow, [WorkflowExpression] Func<int> mSExcelFindNextCellWithValuehandle = null, [WorkflowExpression] Func<string> mSExcelFindNextCellWithValueworkbookName = null, [WorkflowExpression] Func<string> mSExcelFindNextCellWithValueworksheetName = null, [WorkflowExpression] Func<bool> mSExcelFindNextCellWithValuecaseSensitive = null, [WorkflowExpression] Func<mSExcelFindNextCellWithValuecomparisonTypeInput> mSExcelFindNextCellWithValuecomparisonType = null, [WorkflowExpression] Func<int> mSExcelFindNextCellWithValuemaxCellsToSearch = null, [WorkflowExpression] Func<bool> mSExcelFindNextCellWithValueactivateCell = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MSExcelFindNextCellWithValueResponse> __BuildMSExcelFindNextCellWithValue(WorkflowExpression<mSExcelFindNextCellWithValuedirectionInput> mSExcelFindNextCellWithValuedirection, WorkflowExpression<string> mSExcelFindNextCellWithValuesearchValue, WorkflowExpression<string> mSExcelFindNextCellWithValueworkflow, WorkflowExpression<int> mSExcelFindNextCellWithValuehandle = null, WorkflowExpression<string> mSExcelFindNextCellWithValueworkbookName = null, WorkflowExpression<string> mSExcelFindNextCellWithValueworksheetName = null, WorkflowExpression<bool> mSExcelFindNextCellWithValuecaseSensitive = null, WorkflowExpression<mSExcelFindNextCellWithValuecomparisonTypeInput> mSExcelFindNextCellWithValuecomparisonType = null, WorkflowExpression<int> mSExcelFindNextCellWithValuemaxCellsToSearch = null, WorkflowExpression<bool> mSExcelFindNextCellWithValueactivateCell = null)
        {
            WorkflowExpression.Validate(mSExcelFindNextCellWithValuedirection, nameof(mSExcelFindNextCellWithValuedirection), required: true);
            WorkflowExpression.Validate(mSExcelFindNextCellWithValuesearchValue, nameof(mSExcelFindNextCellWithValuesearchValue), required: true);
            WorkflowExpression.Validate(mSExcelFindNextCellWithValueworkflow, nameof(mSExcelFindNextCellWithValueworkflow), required: true);
            WorkflowExpression.Validate(mSExcelFindNextCellWithValuehandle, nameof(mSExcelFindNextCellWithValuehandle), required: false);
            WorkflowExpression.Validate(mSExcelFindNextCellWithValueworkbookName, nameof(mSExcelFindNextCellWithValueworkbookName), required: false);
            WorkflowExpression.Validate(mSExcelFindNextCellWithValueworksheetName, nameof(mSExcelFindNextCellWithValueworksheetName), required: false);
            WorkflowExpression.Validate(mSExcelFindNextCellWithValuecaseSensitive, nameof(mSExcelFindNextCellWithValuecaseSensitive), required: false);
            WorkflowExpression.Validate(mSExcelFindNextCellWithValuecomparisonType, nameof(mSExcelFindNextCellWithValuecomparisonType), required: false);
            WorkflowExpression.Validate(mSExcelFindNextCellWithValuemaxCellsToSearch, nameof(mSExcelFindNextCellWithValuemaxCellsToSearch), required: false);
            WorkflowExpression.Validate(mSExcelFindNextCellWithValueactivateCell, nameof(mSExcelFindNextCellWithValueactivateCell), required: false);
            return new DeferredBodyAction<MSExcelFindNextCellWithValueResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSExcelFindNextEmptyCell))]
        public IBodyWorkflowAction<MSExcelFindNextEmptyCellResponse> MSExcelFindNextEmptyCell([WorkflowExpression] Func<mSExcelFindNextEmptyCelldirectionInput> mSExcelFindNextEmptyCelldirection, [WorkflowExpression] Func<string> mSExcelFindNextEmptyCellworkflow, [WorkflowExpression] Func<int> mSExcelFindNextEmptyCellhandle = null, [WorkflowExpression] Func<string> mSExcelFindNextEmptyCellworkbookName = null, [WorkflowExpression] Func<string> mSExcelFindNextEmptyCellworksheetName = null, [WorkflowExpression] Func<bool> mSExcelFindNextEmptyCellactivateCell = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MSExcelFindNextEmptyCellResponse> __BuildMSExcelFindNextEmptyCell(WorkflowExpression<mSExcelFindNextEmptyCelldirectionInput> mSExcelFindNextEmptyCelldirection, WorkflowExpression<string> mSExcelFindNextEmptyCellworkflow, WorkflowExpression<int> mSExcelFindNextEmptyCellhandle = null, WorkflowExpression<string> mSExcelFindNextEmptyCellworkbookName = null, WorkflowExpression<string> mSExcelFindNextEmptyCellworksheetName = null, WorkflowExpression<bool> mSExcelFindNextEmptyCellactivateCell = null)
        {
            WorkflowExpression.Validate(mSExcelFindNextEmptyCelldirection, nameof(mSExcelFindNextEmptyCelldirection), required: true);
            WorkflowExpression.Validate(mSExcelFindNextEmptyCellworkflow, nameof(mSExcelFindNextEmptyCellworkflow), required: true);
            WorkflowExpression.Validate(mSExcelFindNextEmptyCellhandle, nameof(mSExcelFindNextEmptyCellhandle), required: false);
            WorkflowExpression.Validate(mSExcelFindNextEmptyCellworkbookName, nameof(mSExcelFindNextEmptyCellworkbookName), required: false);
            WorkflowExpression.Validate(mSExcelFindNextEmptyCellworksheetName, nameof(mSExcelFindNextEmptyCellworksheetName), required: false);
            WorkflowExpression.Validate(mSExcelFindNextEmptyCellactivateCell, nameof(mSExcelFindNextEmptyCellactivateCell), required: false);
            return new DeferredBodyAction<MSExcelFindNextEmptyCellResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSExcelGotoNextEmptyCellLeft))]
        public IBodyWorkflowAction<MSExcelGotoNextEmptyCellLeftResponse> MSExcelGotoNextEmptyCellLeft([WorkflowExpression] Func<string> mSExcelGotoNextEmptyCellLeftworkflow, [WorkflowExpression] Func<int> mSExcelGotoNextEmptyCellLefthandle = null, [WorkflowExpression] Func<string> mSExcelGotoNextEmptyCellLeftworkbookName = null, [WorkflowExpression] Func<string> mSExcelGotoNextEmptyCellLeftworksheetName = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MSExcelGotoNextEmptyCellLeftResponse> __BuildMSExcelGotoNextEmptyCellLeft(WorkflowExpression<string> mSExcelGotoNextEmptyCellLeftworkflow, WorkflowExpression<int> mSExcelGotoNextEmptyCellLefthandle = null, WorkflowExpression<string> mSExcelGotoNextEmptyCellLeftworkbookName = null, WorkflowExpression<string> mSExcelGotoNextEmptyCellLeftworksheetName = null)
        {
            WorkflowExpression.Validate(mSExcelGotoNextEmptyCellLeftworkflow, nameof(mSExcelGotoNextEmptyCellLeftworkflow), required: true);
            WorkflowExpression.Validate(mSExcelGotoNextEmptyCellLefthandle, nameof(mSExcelGotoNextEmptyCellLefthandle), required: false);
            WorkflowExpression.Validate(mSExcelGotoNextEmptyCellLeftworkbookName, nameof(mSExcelGotoNextEmptyCellLeftworkbookName), required: false);
            WorkflowExpression.Validate(mSExcelGotoNextEmptyCellLeftworksheetName, nameof(mSExcelGotoNextEmptyCellLeftworksheetName), required: false);
            return new DeferredBodyAction<MSExcelGotoNextEmptyCellLeftResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSExcelGotoNextEmptyCellRight))]
        public IBodyWorkflowAction<MSExcelGotoNextEmptyCellRightResponse> MSExcelGotoNextEmptyCellRight([WorkflowExpression] Func<string> mSExcelGotoNextEmptyCellRightworkflow, [WorkflowExpression] Func<int> mSExcelGotoNextEmptyCellRighthandle = null, [WorkflowExpression] Func<string> mSExcelGotoNextEmptyCellRightworkbookName = null, [WorkflowExpression] Func<string> mSExcelGotoNextEmptyCellRightworksheetName = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MSExcelGotoNextEmptyCellRightResponse> __BuildMSExcelGotoNextEmptyCellRight(WorkflowExpression<string> mSExcelGotoNextEmptyCellRightworkflow, WorkflowExpression<int> mSExcelGotoNextEmptyCellRighthandle = null, WorkflowExpression<string> mSExcelGotoNextEmptyCellRightworkbookName = null, WorkflowExpression<string> mSExcelGotoNextEmptyCellRightworksheetName = null)
        {
            WorkflowExpression.Validate(mSExcelGotoNextEmptyCellRightworkflow, nameof(mSExcelGotoNextEmptyCellRightworkflow), required: true);
            WorkflowExpression.Validate(mSExcelGotoNextEmptyCellRighthandle, nameof(mSExcelGotoNextEmptyCellRighthandle), required: false);
            WorkflowExpression.Validate(mSExcelGotoNextEmptyCellRightworkbookName, nameof(mSExcelGotoNextEmptyCellRightworkbookName), required: false);
            WorkflowExpression.Validate(mSExcelGotoNextEmptyCellRightworksheetName, nameof(mSExcelGotoNextEmptyCellRightworksheetName), required: false);
            return new DeferredBodyAction<MSExcelGotoNextEmptyCellRightResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSExcelGotoNextEmptyCellUp))]
        public IBodyWorkflowAction<MSExcelGotoNextEmptyCellUpResponse> MSExcelGotoNextEmptyCellUp([WorkflowExpression] Func<string> mSExcelGotoNextEmptyCellUpworkflow, [WorkflowExpression] Func<int> mSExcelGotoNextEmptyCellUphandle = null, [WorkflowExpression] Func<string> mSExcelGotoNextEmptyCellUpworkbookName = null, [WorkflowExpression] Func<string> mSExcelGotoNextEmptyCellUpworksheetName = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MSExcelGotoNextEmptyCellUpResponse> __BuildMSExcelGotoNextEmptyCellUp(WorkflowExpression<string> mSExcelGotoNextEmptyCellUpworkflow, WorkflowExpression<int> mSExcelGotoNextEmptyCellUphandle = null, WorkflowExpression<string> mSExcelGotoNextEmptyCellUpworkbookName = null, WorkflowExpression<string> mSExcelGotoNextEmptyCellUpworksheetName = null)
        {
            WorkflowExpression.Validate(mSExcelGotoNextEmptyCellUpworkflow, nameof(mSExcelGotoNextEmptyCellUpworkflow), required: true);
            WorkflowExpression.Validate(mSExcelGotoNextEmptyCellUphandle, nameof(mSExcelGotoNextEmptyCellUphandle), required: false);
            WorkflowExpression.Validate(mSExcelGotoNextEmptyCellUpworkbookName, nameof(mSExcelGotoNextEmptyCellUpworkbookName), required: false);
            WorkflowExpression.Validate(mSExcelGotoNextEmptyCellUpworksheetName, nameof(mSExcelGotoNextEmptyCellUpworksheetName), required: false);
            return new DeferredBodyAction<MSExcelGotoNextEmptyCellUpResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSExcelGotoNextEmptyCellDown))]
        public IBodyWorkflowAction<MSExcelGotoNextEmptyCellDownResponse> MSExcelGotoNextEmptyCellDown([WorkflowExpression] Func<string> mSExcelGotoNextEmptyCellDownworkflow, [WorkflowExpression] Func<int> mSExcelGotoNextEmptyCellDownhandle = null, [WorkflowExpression] Func<string> mSExcelGotoNextEmptyCellDownworkbookName = null, [WorkflowExpression] Func<string> mSExcelGotoNextEmptyCellDownworksheetName = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MSExcelGotoNextEmptyCellDownResponse> __BuildMSExcelGotoNextEmptyCellDown(WorkflowExpression<string> mSExcelGotoNextEmptyCellDownworkflow, WorkflowExpression<int> mSExcelGotoNextEmptyCellDownhandle = null, WorkflowExpression<string> mSExcelGotoNextEmptyCellDownworkbookName = null, WorkflowExpression<string> mSExcelGotoNextEmptyCellDownworksheetName = null)
        {
            WorkflowExpression.Validate(mSExcelGotoNextEmptyCellDownworkflow, nameof(mSExcelGotoNextEmptyCellDownworkflow), required: true);
            WorkflowExpression.Validate(mSExcelGotoNextEmptyCellDownhandle, nameof(mSExcelGotoNextEmptyCellDownhandle), required: false);
            WorkflowExpression.Validate(mSExcelGotoNextEmptyCellDownworkbookName, nameof(mSExcelGotoNextEmptyCellDownworkbookName), required: false);
            WorkflowExpression.Validate(mSExcelGotoNextEmptyCellDownworksheetName, nameof(mSExcelGotoNextEmptyCellDownworksheetName), required: false);
            return new DeferredBodyAction<MSExcelGotoNextEmptyCellDownResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSExcelSaveWorkbook))]
        public IBodyWorkflowAction<MSExcelSaveWorkbookResponse> MSExcelSaveWorkbook([WorkflowExpression] Func<string> mSExcelSaveWorkbookworkflow, [WorkflowExpression] Func<int> mSExcelSaveWorkbookhandle = null, [WorkflowExpression] Func<string> mSExcelSaveWorkbookworkbookName = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MSExcelSaveWorkbookResponse> __BuildMSExcelSaveWorkbook(WorkflowExpression<string> mSExcelSaveWorkbookworkflow, WorkflowExpression<int> mSExcelSaveWorkbookhandle = null, WorkflowExpression<string> mSExcelSaveWorkbookworkbookName = null)
        {
            WorkflowExpression.Validate(mSExcelSaveWorkbookworkflow, nameof(mSExcelSaveWorkbookworkflow), required: true);
            WorkflowExpression.Validate(mSExcelSaveWorkbookhandle, nameof(mSExcelSaveWorkbookhandle), required: false);
            WorkflowExpression.Validate(mSExcelSaveWorkbookworkbookName, nameof(mSExcelSaveWorkbookworkbookName), required: false);
            return new DeferredBodyAction<MSExcelSaveWorkbookResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSExcelSaveWorkbookAs))]
        public IBodyWorkflowAction<MSExcelSaveWorkbookAsResponse> MSExcelSaveWorkbookAs([WorkflowExpression] Func<string> mSExcelSaveWorkbookAssaveFilename, [WorkflowExpression] Func<string> mSExcelSaveWorkbookAsworkflow, [WorkflowExpression] Func<int> mSExcelSaveWorkbookAshandle = null, [WorkflowExpression] Func<string> mSExcelSaveWorkbookAsworkbookName = null, [WorkflowExpression] Func<bool> mSExcelSaveWorkbookAsdeleteExistingSaveFilename = null, [WorkflowExpression] Func<mSExcelSaveWorkbookAsexcelFileFormatInput> mSExcelSaveWorkbookAsexcelFileFormat = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MSExcelSaveWorkbookAsResponse> __BuildMSExcelSaveWorkbookAs(WorkflowExpression<string> mSExcelSaveWorkbookAssaveFilename, WorkflowExpression<string> mSExcelSaveWorkbookAsworkflow, WorkflowExpression<int> mSExcelSaveWorkbookAshandle = null, WorkflowExpression<string> mSExcelSaveWorkbookAsworkbookName = null, WorkflowExpression<bool> mSExcelSaveWorkbookAsdeleteExistingSaveFilename = null, WorkflowExpression<mSExcelSaveWorkbookAsexcelFileFormatInput> mSExcelSaveWorkbookAsexcelFileFormat = null)
        {
            WorkflowExpression.Validate(mSExcelSaveWorkbookAssaveFilename, nameof(mSExcelSaveWorkbookAssaveFilename), required: true);
            WorkflowExpression.Validate(mSExcelSaveWorkbookAsworkflow, nameof(mSExcelSaveWorkbookAsworkflow), required: true);
            WorkflowExpression.Validate(mSExcelSaveWorkbookAshandle, nameof(mSExcelSaveWorkbookAshandle), required: false);
            WorkflowExpression.Validate(mSExcelSaveWorkbookAsworkbookName, nameof(mSExcelSaveWorkbookAsworkbookName), required: false);
            WorkflowExpression.Validate(mSExcelSaveWorkbookAsdeleteExistingSaveFilename, nameof(mSExcelSaveWorkbookAsdeleteExistingSaveFilename), required: false);
            WorkflowExpression.Validate(mSExcelSaveWorkbookAsexcelFileFormat, nameof(mSExcelSaveWorkbookAsexcelFileFormat), required: false);
            return new DeferredBodyAction<MSExcelSaveWorkbookAsResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSExcelSaveWorkbookAsCSV))]
        public IBodyWorkflowAction<MSExcelSaveWorkbookAsCSVResponse> MSExcelSaveWorkbookAsCSV([WorkflowExpression] Func<string> mSExcelSaveWorkbookAsCSVsaveFilename, [WorkflowExpression] Func<string> mSExcelSaveWorkbookAsCSVworkflow, [WorkflowExpression] Func<int> mSExcelSaveWorkbookAsCSVhandle = null, [WorkflowExpression] Func<string> mSExcelSaveWorkbookAsCSVworkbookName = null, [WorkflowExpression] Func<bool> mSExcelSaveWorkbookAsCSVdeleteExistingSaveFilename = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MSExcelSaveWorkbookAsCSVResponse> __BuildMSExcelSaveWorkbookAsCSV(WorkflowExpression<string> mSExcelSaveWorkbookAsCSVsaveFilename, WorkflowExpression<string> mSExcelSaveWorkbookAsCSVworkflow, WorkflowExpression<int> mSExcelSaveWorkbookAsCSVhandle = null, WorkflowExpression<string> mSExcelSaveWorkbookAsCSVworkbookName = null, WorkflowExpression<bool> mSExcelSaveWorkbookAsCSVdeleteExistingSaveFilename = null)
        {
            WorkflowExpression.Validate(mSExcelSaveWorkbookAsCSVsaveFilename, nameof(mSExcelSaveWorkbookAsCSVsaveFilename), required: true);
            WorkflowExpression.Validate(mSExcelSaveWorkbookAsCSVworkflow, nameof(mSExcelSaveWorkbookAsCSVworkflow), required: true);
            WorkflowExpression.Validate(mSExcelSaveWorkbookAsCSVhandle, nameof(mSExcelSaveWorkbookAsCSVhandle), required: false);
            WorkflowExpression.Validate(mSExcelSaveWorkbookAsCSVworkbookName, nameof(mSExcelSaveWorkbookAsCSVworkbookName), required: false);
            WorkflowExpression.Validate(mSExcelSaveWorkbookAsCSVdeleteExistingSaveFilename, nameof(mSExcelSaveWorkbookAsCSVdeleteExistingSaveFilename), required: false);
            return new DeferredBodyAction<MSExcelSaveWorkbookAsCSVResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSExcelSaveWorkbookAsWithPassword))]
        public IBodyWorkflowAction<MSExcelSaveWorkbookAsWithPasswordResponse> MSExcelSaveWorkbookAsWithPassword([WorkflowExpression] Func<string> mSExcelSaveWorkbookAsWithPasswordsaveFilename, [WorkflowExpression] Func<string> mSExcelSaveWorkbookAsWithPasswordpassword, [WorkflowExpression] Func<string> mSExcelSaveWorkbookAsWithPasswordworkflow, [WorkflowExpression] Func<int> mSExcelSaveWorkbookAsWithPasswordhandle = null, [WorkflowExpression] Func<string> mSExcelSaveWorkbookAsWithPasswordworkbookName = null, [WorkflowExpression] Func<bool> mSExcelSaveWorkbookAsWithPassworddeleteExistingSaveFilename = null, [WorkflowExpression] Func<mSExcelSaveWorkbookAsWithPasswordexcelFileFormatInput> mSExcelSaveWorkbookAsWithPasswordexcelFileFormat = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MSExcelSaveWorkbookAsWithPasswordResponse> __BuildMSExcelSaveWorkbookAsWithPassword(WorkflowExpression<string> mSExcelSaveWorkbookAsWithPasswordsaveFilename, WorkflowExpression<string> mSExcelSaveWorkbookAsWithPasswordpassword, WorkflowExpression<string> mSExcelSaveWorkbookAsWithPasswordworkflow, WorkflowExpression<int> mSExcelSaveWorkbookAsWithPasswordhandle = null, WorkflowExpression<string> mSExcelSaveWorkbookAsWithPasswordworkbookName = null, WorkflowExpression<bool> mSExcelSaveWorkbookAsWithPassworddeleteExistingSaveFilename = null, WorkflowExpression<mSExcelSaveWorkbookAsWithPasswordexcelFileFormatInput> mSExcelSaveWorkbookAsWithPasswordexcelFileFormat = null)
        {
            WorkflowExpression.Validate(mSExcelSaveWorkbookAsWithPasswordsaveFilename, nameof(mSExcelSaveWorkbookAsWithPasswordsaveFilename), required: true);
            WorkflowExpression.Validate(mSExcelSaveWorkbookAsWithPasswordpassword, nameof(mSExcelSaveWorkbookAsWithPasswordpassword), required: true);
            WorkflowExpression.Validate(mSExcelSaveWorkbookAsWithPasswordworkflow, nameof(mSExcelSaveWorkbookAsWithPasswordworkflow), required: true);
            WorkflowExpression.Validate(mSExcelSaveWorkbookAsWithPasswordhandle, nameof(mSExcelSaveWorkbookAsWithPasswordhandle), required: false);
            WorkflowExpression.Validate(mSExcelSaveWorkbookAsWithPasswordworkbookName, nameof(mSExcelSaveWorkbookAsWithPasswordworkbookName), required: false);
            WorkflowExpression.Validate(mSExcelSaveWorkbookAsWithPassworddeleteExistingSaveFilename, nameof(mSExcelSaveWorkbookAsWithPassworddeleteExistingSaveFilename), required: false);
            WorkflowExpression.Validate(mSExcelSaveWorkbookAsWithPasswordexcelFileFormat, nameof(mSExcelSaveWorkbookAsWithPasswordexcelFileFormat), required: false);
            return new DeferredBodyAction<MSExcelSaveWorkbookAsWithPasswordResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSExcelSaveCurrentWorkbook))]
        public IBodyWorkflowAction<MSExcelSaveCurrentWorkbookResponse> MSExcelSaveCurrentWorkbook([WorkflowExpression] Func<string> mSExcelSaveCurrentWorkbookworkflow, [WorkflowExpression] Func<int> mSExcelSaveCurrentWorkbookhandle = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MSExcelSaveCurrentWorkbookResponse> __BuildMSExcelSaveCurrentWorkbook(WorkflowExpression<string> mSExcelSaveCurrentWorkbookworkflow, WorkflowExpression<int> mSExcelSaveCurrentWorkbookhandle = null)
        {
            WorkflowExpression.Validate(mSExcelSaveCurrentWorkbookworkflow, nameof(mSExcelSaveCurrentWorkbookworkflow), required: true);
            WorkflowExpression.Validate(mSExcelSaveCurrentWorkbookhandle, nameof(mSExcelSaveCurrentWorkbookhandle), required: false);
            return new DeferredBodyAction<MSExcelSaveCurrentWorkbookResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSExcelSaveCurrentWorkbookAs))]
        public IBodyWorkflowAction<MSExcelSaveCurrentWorkbookAsResponse> MSExcelSaveCurrentWorkbookAs([WorkflowExpression] Func<string> mSExcelSaveCurrentWorkbookAsworkflow, [WorkflowExpression] Func<int> mSExcelSaveCurrentWorkbookAshandle = null, [WorkflowExpression] Func<string> mSExcelSaveCurrentWorkbookAssaveFilename = null, [WorkflowExpression] Func<bool> mSExcelSaveCurrentWorkbookAsdeleteExistingSaveFilename = null, [WorkflowExpression] Func<mSExcelSaveCurrentWorkbookAsexcelFileFormatInput> mSExcelSaveCurrentWorkbookAsexcelFileFormat = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MSExcelSaveCurrentWorkbookAsResponse> __BuildMSExcelSaveCurrentWorkbookAs(WorkflowExpression<string> mSExcelSaveCurrentWorkbookAsworkflow, WorkflowExpression<int> mSExcelSaveCurrentWorkbookAshandle = null, WorkflowExpression<string> mSExcelSaveCurrentWorkbookAssaveFilename = null, WorkflowExpression<bool> mSExcelSaveCurrentWorkbookAsdeleteExistingSaveFilename = null, WorkflowExpression<mSExcelSaveCurrentWorkbookAsexcelFileFormatInput> mSExcelSaveCurrentWorkbookAsexcelFileFormat = null)
        {
            WorkflowExpression.Validate(mSExcelSaveCurrentWorkbookAsworkflow, nameof(mSExcelSaveCurrentWorkbookAsworkflow), required: true);
            WorkflowExpression.Validate(mSExcelSaveCurrentWorkbookAshandle, nameof(mSExcelSaveCurrentWorkbookAshandle), required: false);
            WorkflowExpression.Validate(mSExcelSaveCurrentWorkbookAssaveFilename, nameof(mSExcelSaveCurrentWorkbookAssaveFilename), required: false);
            WorkflowExpression.Validate(mSExcelSaveCurrentWorkbookAsdeleteExistingSaveFilename, nameof(mSExcelSaveCurrentWorkbookAsdeleteExistingSaveFilename), required: false);
            WorkflowExpression.Validate(mSExcelSaveCurrentWorkbookAsexcelFileFormat, nameof(mSExcelSaveCurrentWorkbookAsexcelFileFormat), required: false);
            return new DeferredBodyAction<MSExcelSaveCurrentWorkbookAsResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSExcelSaveCurrentWorkbookAsCSV))]
        public IBodyWorkflowAction<MSExcelSaveCurrentWorkbookAsCSVResponse> MSExcelSaveCurrentWorkbookAsCSV([WorkflowExpression] Func<string> mSExcelSaveCurrentWorkbookAsCSVsaveFilename, [WorkflowExpression] Func<string> mSExcelSaveCurrentWorkbookAsCSVworkflow, [WorkflowExpression] Func<int> mSExcelSaveCurrentWorkbookAsCSVhandle = null, [WorkflowExpression] Func<bool> mSExcelSaveCurrentWorkbookAsCSVdeleteExistingSaveFilename = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MSExcelSaveCurrentWorkbookAsCSVResponse> __BuildMSExcelSaveCurrentWorkbookAsCSV(WorkflowExpression<string> mSExcelSaveCurrentWorkbookAsCSVsaveFilename, WorkflowExpression<string> mSExcelSaveCurrentWorkbookAsCSVworkflow, WorkflowExpression<int> mSExcelSaveCurrentWorkbookAsCSVhandle = null, WorkflowExpression<bool> mSExcelSaveCurrentWorkbookAsCSVdeleteExistingSaveFilename = null)
        {
            WorkflowExpression.Validate(mSExcelSaveCurrentWorkbookAsCSVsaveFilename, nameof(mSExcelSaveCurrentWorkbookAsCSVsaveFilename), required: true);
            WorkflowExpression.Validate(mSExcelSaveCurrentWorkbookAsCSVworkflow, nameof(mSExcelSaveCurrentWorkbookAsCSVworkflow), required: true);
            WorkflowExpression.Validate(mSExcelSaveCurrentWorkbookAsCSVhandle, nameof(mSExcelSaveCurrentWorkbookAsCSVhandle), required: false);
            WorkflowExpression.Validate(mSExcelSaveCurrentWorkbookAsCSVdeleteExistingSaveFilename, nameof(mSExcelSaveCurrentWorkbookAsCSVdeleteExistingSaveFilename), required: false);
            return new DeferredBodyAction<MSExcelSaveCurrentWorkbookAsCSVResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSExcelGetWorksheetNames))]
        public IBodyWorkflowAction<MSExcelGetWorksheetNamesResponse> MSExcelGetWorksheetNames([WorkflowExpression] Func<string> mSExcelGetWorksheetNamesworkflow, [WorkflowExpression] Func<int> mSExcelGetWorksheetNameshandle = null, [WorkflowExpression] Func<string> mSExcelGetWorksheetNamesworkbookName = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MSExcelGetWorksheetNamesResponse> __BuildMSExcelGetWorksheetNames(WorkflowExpression<string> mSExcelGetWorksheetNamesworkflow, WorkflowExpression<int> mSExcelGetWorksheetNameshandle = null, WorkflowExpression<string> mSExcelGetWorksheetNamesworkbookName = null)
        {
            WorkflowExpression.Validate(mSExcelGetWorksheetNamesworkflow, nameof(mSExcelGetWorksheetNamesworkflow), required: true);
            WorkflowExpression.Validate(mSExcelGetWorksheetNameshandle, nameof(mSExcelGetWorksheetNameshandle), required: false);
            WorkflowExpression.Validate(mSExcelGetWorksheetNamesworkbookName, nameof(mSExcelGetWorksheetNamesworkbookName), required: false);
            return new DeferredBodyAction<MSExcelGetWorksheetNamesResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSExcelGetWorksheetName))]
        public IBodyWorkflowAction<MSExcelGetWorksheetNameResponse> MSExcelGetWorksheetName([WorkflowExpression] Func<string> mSExcelGetWorksheetNameworkflow, [WorkflowExpression] Func<int> mSExcelGetWorksheetNamehandle = null, [WorkflowExpression] Func<string> mSExcelGetWorksheetNameworkbookName = null, [WorkflowExpression] Func<int> mSExcelGetWorksheetNameposition = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MSExcelGetWorksheetNameResponse> __BuildMSExcelGetWorksheetName(WorkflowExpression<string> mSExcelGetWorksheetNameworkflow, WorkflowExpression<int> mSExcelGetWorksheetNamehandle = null, WorkflowExpression<string> mSExcelGetWorksheetNameworkbookName = null, WorkflowExpression<int> mSExcelGetWorksheetNameposition = null)
        {
            WorkflowExpression.Validate(mSExcelGetWorksheetNameworkflow, nameof(mSExcelGetWorksheetNameworkflow), required: true);
            WorkflowExpression.Validate(mSExcelGetWorksheetNamehandle, nameof(mSExcelGetWorksheetNamehandle), required: false);
            WorkflowExpression.Validate(mSExcelGetWorksheetNameworkbookName, nameof(mSExcelGetWorksheetNameworkbookName), required: false);
            WorkflowExpression.Validate(mSExcelGetWorksheetNameposition, nameof(mSExcelGetWorksheetNameposition), required: false);
            return new DeferredBodyAction<MSExcelGetWorksheetNameResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSExcelActivateWorksheet))]
        public IWorkflowAction MSExcelActivateWorksheet([WorkflowExpression] Func<string> mSExcelActivateWorksheetworkflow, [WorkflowExpression] Func<int> mSExcelActivateWorksheethandle = null, [WorkflowExpression] Func<string> mSExcelActivateWorksheetworkbookName = null, [WorkflowExpression] Func<string> mSExcelActivateWorksheetworksheetName = null, [WorkflowExpression] Func<bool> mSExcelActivateWorksheetcreateIfMissing = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMSExcelActivateWorksheet(WorkflowExpression<string> mSExcelActivateWorksheetworkflow, WorkflowExpression<int> mSExcelActivateWorksheethandle = null, WorkflowExpression<string> mSExcelActivateWorksheetworkbookName = null, WorkflowExpression<string> mSExcelActivateWorksheetworksheetName = null, WorkflowExpression<bool> mSExcelActivateWorksheetcreateIfMissing = null)
        {
            WorkflowExpression.Validate(mSExcelActivateWorksheetworkflow, nameof(mSExcelActivateWorksheetworkflow), required: true);
            WorkflowExpression.Validate(mSExcelActivateWorksheethandle, nameof(mSExcelActivateWorksheethandle), required: false);
            WorkflowExpression.Validate(mSExcelActivateWorksheetworkbookName, nameof(mSExcelActivateWorksheetworkbookName), required: false);
            WorkflowExpression.Validate(mSExcelActivateWorksheetworksheetName, nameof(mSExcelActivateWorksheetworksheetName), required: false);
            WorkflowExpression.Validate(mSExcelActivateWorksheetcreateIfMissing, nameof(mSExcelActivateWorksheetcreateIfMissing), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSExcelCreateWorksheet))]
        public IWorkflowAction MSExcelCreateWorksheet([WorkflowExpression] Func<string> mSExcelCreateWorksheetworkflow, [WorkflowExpression] Func<int> mSExcelCreateWorksheethandle = null, [WorkflowExpression] Func<string> mSExcelCreateWorksheetworkbookName = null, [WorkflowExpression] Func<string> mSExcelCreateWorksheetworksheetName = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMSExcelCreateWorksheet(WorkflowExpression<string> mSExcelCreateWorksheetworkflow, WorkflowExpression<int> mSExcelCreateWorksheethandle = null, WorkflowExpression<string> mSExcelCreateWorksheetworkbookName = null, WorkflowExpression<string> mSExcelCreateWorksheetworksheetName = null)
        {
            WorkflowExpression.Validate(mSExcelCreateWorksheetworkflow, nameof(mSExcelCreateWorksheetworkflow), required: true);
            WorkflowExpression.Validate(mSExcelCreateWorksheethandle, nameof(mSExcelCreateWorksheethandle), required: false);
            WorkflowExpression.Validate(mSExcelCreateWorksheetworkbookName, nameof(mSExcelCreateWorksheetworkbookName), required: false);
            WorkflowExpression.Validate(mSExcelCreateWorksheetworksheetName, nameof(mSExcelCreateWorksheetworksheetName), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSExcelDeleteWorksheet))]
        public IWorkflowAction MSExcelDeleteWorksheet([WorkflowExpression] Func<string> mSExcelDeleteWorksheetworkflow, [WorkflowExpression] Func<int> mSExcelDeleteWorksheethandle = null, [WorkflowExpression] Func<string> mSExcelDeleteWorksheetworkbookName = null, [WorkflowExpression] Func<string> mSExcelDeleteWorksheetworksheetName = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMSExcelDeleteWorksheet(WorkflowExpression<string> mSExcelDeleteWorksheetworkflow, WorkflowExpression<int> mSExcelDeleteWorksheethandle = null, WorkflowExpression<string> mSExcelDeleteWorksheetworkbookName = null, WorkflowExpression<string> mSExcelDeleteWorksheetworksheetName = null)
        {
            WorkflowExpression.Validate(mSExcelDeleteWorksheetworkflow, nameof(mSExcelDeleteWorksheetworkflow), required: true);
            WorkflowExpression.Validate(mSExcelDeleteWorksheethandle, nameof(mSExcelDeleteWorksheethandle), required: false);
            WorkflowExpression.Validate(mSExcelDeleteWorksheetworkbookName, nameof(mSExcelDeleteWorksheetworkbookName), required: false);
            WorkflowExpression.Validate(mSExcelDeleteWorksheetworksheetName, nameof(mSExcelDeleteWorksheetworksheetName), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSExcelGetWorksheetAsCollectionEnhanced))]
        public IBodyWorkflowAction<MSExcelGetWorksheetAsCollectionEnhancedResponse> MSExcelGetWorksheetAsCollectionEnhanced([WorkflowExpression] Func<string> mSExcelGetWorksheetAsCollectionEnhancedworkflow, [WorkflowExpression] Func<int> mSExcelGetWorksheetAsCollectionEnhancedhandle = null, [WorkflowExpression] Func<string> mSExcelGetWorksheetAsCollectionEnhancedworkbookName = null, [WorkflowExpression] Func<string> mSExcelGetWorksheetAsCollectionEnhancedworksheetName = null, [WorkflowExpression] Func<bool> mSExcelGetWorksheetAsCollectionEnhanceduseHeader = null, [WorkflowExpression] Func<string> mSExcelGetWorksheetAsCollectionEnhancedstartCell = null, [WorkflowExpression] Func<int> mSExcelGetWorksheetAsCollectionEnhancedmaximumColumnNumber = null, [WorkflowExpression] Func<bool> mSExcelGetWorksheetAsCollectionEnhancedskipBlankRows = null, [WorkflowExpression] Func<bool> mSExcelGetWorksheetAsCollectionEnhancedskipColumnsWithNoHeader = null, [WorkflowExpression] Func<string> mSExcelGetWorksheetAsCollectionEnhancedkeyColumn = null, [WorkflowExpression] Func<bool> mSExcelGetWorksheetAsCollectionEnhancedgetRawData = null, [WorkflowExpression] Func<int> mSExcelGetWorksheetAsCollectionEnhancedignoreRowsWithLowCellCount = null, [WorkflowExpression] Func<int> mSExcelGetWorksheetAsCollectionEnhancedmaxConcurrentBlankRows = null, [WorkflowExpression] Func<int> mSExcelGetWorksheetAsCollectionEnhancedfirstDataRowToReturn = null, [WorkflowExpression] Func<int> mSExcelGetWorksheetAsCollectionEnhancedmaxNumberOfDataRowsToReturn = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MSExcelGetWorksheetAsCollectionEnhancedResponse> __BuildMSExcelGetWorksheetAsCollectionEnhanced(WorkflowExpression<string> mSExcelGetWorksheetAsCollectionEnhancedworkflow, WorkflowExpression<int> mSExcelGetWorksheetAsCollectionEnhancedhandle = null, WorkflowExpression<string> mSExcelGetWorksheetAsCollectionEnhancedworkbookName = null, WorkflowExpression<string> mSExcelGetWorksheetAsCollectionEnhancedworksheetName = null, WorkflowExpression<bool> mSExcelGetWorksheetAsCollectionEnhanceduseHeader = null, WorkflowExpression<string> mSExcelGetWorksheetAsCollectionEnhancedstartCell = null, WorkflowExpression<int> mSExcelGetWorksheetAsCollectionEnhancedmaximumColumnNumber = null, WorkflowExpression<bool> mSExcelGetWorksheetAsCollectionEnhancedskipBlankRows = null, WorkflowExpression<bool> mSExcelGetWorksheetAsCollectionEnhancedskipColumnsWithNoHeader = null, WorkflowExpression<string> mSExcelGetWorksheetAsCollectionEnhancedkeyColumn = null, WorkflowExpression<bool> mSExcelGetWorksheetAsCollectionEnhancedgetRawData = null, WorkflowExpression<int> mSExcelGetWorksheetAsCollectionEnhancedignoreRowsWithLowCellCount = null, WorkflowExpression<int> mSExcelGetWorksheetAsCollectionEnhancedmaxConcurrentBlankRows = null, WorkflowExpression<int> mSExcelGetWorksheetAsCollectionEnhancedfirstDataRowToReturn = null, WorkflowExpression<int> mSExcelGetWorksheetAsCollectionEnhancedmaxNumberOfDataRowsToReturn = null)
        {
            WorkflowExpression.Validate(mSExcelGetWorksheetAsCollectionEnhancedworkflow, nameof(mSExcelGetWorksheetAsCollectionEnhancedworkflow), required: true);
            WorkflowExpression.Validate(mSExcelGetWorksheetAsCollectionEnhancedhandle, nameof(mSExcelGetWorksheetAsCollectionEnhancedhandle), required: false);
            WorkflowExpression.Validate(mSExcelGetWorksheetAsCollectionEnhancedworkbookName, nameof(mSExcelGetWorksheetAsCollectionEnhancedworkbookName), required: false);
            WorkflowExpression.Validate(mSExcelGetWorksheetAsCollectionEnhancedworksheetName, nameof(mSExcelGetWorksheetAsCollectionEnhancedworksheetName), required: false);
            WorkflowExpression.Validate(mSExcelGetWorksheetAsCollectionEnhanceduseHeader, nameof(mSExcelGetWorksheetAsCollectionEnhanceduseHeader), required: false);
            WorkflowExpression.Validate(mSExcelGetWorksheetAsCollectionEnhancedstartCell, nameof(mSExcelGetWorksheetAsCollectionEnhancedstartCell), required: false);
            WorkflowExpression.Validate(mSExcelGetWorksheetAsCollectionEnhancedmaximumColumnNumber, nameof(mSExcelGetWorksheetAsCollectionEnhancedmaximumColumnNumber), required: false);
            WorkflowExpression.Validate(mSExcelGetWorksheetAsCollectionEnhancedskipBlankRows, nameof(mSExcelGetWorksheetAsCollectionEnhancedskipBlankRows), required: false);
            WorkflowExpression.Validate(mSExcelGetWorksheetAsCollectionEnhancedskipColumnsWithNoHeader, nameof(mSExcelGetWorksheetAsCollectionEnhancedskipColumnsWithNoHeader), required: false);
            WorkflowExpression.Validate(mSExcelGetWorksheetAsCollectionEnhancedkeyColumn, nameof(mSExcelGetWorksheetAsCollectionEnhancedkeyColumn), required: false);
            WorkflowExpression.Validate(mSExcelGetWorksheetAsCollectionEnhancedgetRawData, nameof(mSExcelGetWorksheetAsCollectionEnhancedgetRawData), required: false);
            WorkflowExpression.Validate(mSExcelGetWorksheetAsCollectionEnhancedignoreRowsWithLowCellCount, nameof(mSExcelGetWorksheetAsCollectionEnhancedignoreRowsWithLowCellCount), required: false);
            WorkflowExpression.Validate(mSExcelGetWorksheetAsCollectionEnhancedmaxConcurrentBlankRows, nameof(mSExcelGetWorksheetAsCollectionEnhancedmaxConcurrentBlankRows), required: false);
            WorkflowExpression.Validate(mSExcelGetWorksheetAsCollectionEnhancedfirstDataRowToReturn, nameof(mSExcelGetWorksheetAsCollectionEnhancedfirstDataRowToReturn), required: false);
            WorkflowExpression.Validate(mSExcelGetWorksheetAsCollectionEnhancedmaxNumberOfDataRowsToReturn, nameof(mSExcelGetWorksheetAsCollectionEnhancedmaxNumberOfDataRowsToReturn), required: false);
            return new DeferredBodyAction<MSExcelGetWorksheetAsCollectionEnhancedResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSExcelGetNumberOfRows))]
        public IBodyWorkflowAction<MSExcelGetNumberOfRowsResponse> MSExcelGetNumberOfRows([WorkflowExpression] Func<string> mSExcelGetNumberOfRowsworkflow, [WorkflowExpression] Func<int> mSExcelGetNumberOfRowshandle = null, [WorkflowExpression] Func<string> mSExcelGetNumberOfRowsworkbookName = null, [WorkflowExpression] Func<string> mSExcelGetNumberOfRowsworksheetName = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MSExcelGetNumberOfRowsResponse> __BuildMSExcelGetNumberOfRows(WorkflowExpression<string> mSExcelGetNumberOfRowsworkflow, WorkflowExpression<int> mSExcelGetNumberOfRowshandle = null, WorkflowExpression<string> mSExcelGetNumberOfRowsworkbookName = null, WorkflowExpression<string> mSExcelGetNumberOfRowsworksheetName = null)
        {
            WorkflowExpression.Validate(mSExcelGetNumberOfRowsworkflow, nameof(mSExcelGetNumberOfRowsworkflow), required: true);
            WorkflowExpression.Validate(mSExcelGetNumberOfRowshandle, nameof(mSExcelGetNumberOfRowshandle), required: false);
            WorkflowExpression.Validate(mSExcelGetNumberOfRowsworkbookName, nameof(mSExcelGetNumberOfRowsworkbookName), required: false);
            WorkflowExpression.Validate(mSExcelGetNumberOfRowsworksheetName, nameof(mSExcelGetNumberOfRowsworksheetName), required: false);
            return new DeferredBodyAction<MSExcelGetNumberOfRowsResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSExcelEvaluateExpression))]
        public IBodyWorkflowAction<MSExcelEvaluateExpressionResponse> MSExcelEvaluateExpression([WorkflowExpression] Func<string> mSExcelEvaluateExpressionexpression, [WorkflowExpression] Func<string> mSExcelEvaluateExpressionworkflow, [WorkflowExpression] Func<int> mSExcelEvaluateExpressionhandle = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MSExcelEvaluateExpressionResponse> __BuildMSExcelEvaluateExpression(WorkflowExpression<string> mSExcelEvaluateExpressionexpression, WorkflowExpression<string> mSExcelEvaluateExpressionworkflow, WorkflowExpression<int> mSExcelEvaluateExpressionhandle = null)
        {
            WorkflowExpression.Validate(mSExcelEvaluateExpressionexpression, nameof(mSExcelEvaluateExpressionexpression), required: true);
            WorkflowExpression.Validate(mSExcelEvaluateExpressionworkflow, nameof(mSExcelEvaluateExpressionworkflow), required: true);
            WorkflowExpression.Validate(mSExcelEvaluateExpressionhandle, nameof(mSExcelEvaluateExpressionhandle), required: false);
            return new DeferredBodyAction<MSExcelEvaluateExpressionResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSExcelGetWorksheetUsedRange))]
        public IBodyWorkflowAction<MSExcelGetWorksheetUsedRangeResponse> MSExcelGetWorksheetUsedRange([WorkflowExpression] Func<string> mSExcelGetWorksheetUsedRangeworkflow, [WorkflowExpression] Func<int> mSExcelGetWorksheetUsedRangehandle = null, [WorkflowExpression] Func<string> mSExcelGetWorksheetUsedRangeworkbookName = null, [WorkflowExpression] Func<string> mSExcelGetWorksheetUsedRangeworksheetName = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MSExcelGetWorksheetUsedRangeResponse> __BuildMSExcelGetWorksheetUsedRange(WorkflowExpression<string> mSExcelGetWorksheetUsedRangeworkflow, WorkflowExpression<int> mSExcelGetWorksheetUsedRangehandle = null, WorkflowExpression<string> mSExcelGetWorksheetUsedRangeworkbookName = null, WorkflowExpression<string> mSExcelGetWorksheetUsedRangeworksheetName = null)
        {
            WorkflowExpression.Validate(mSExcelGetWorksheetUsedRangeworkflow, nameof(mSExcelGetWorksheetUsedRangeworkflow), required: true);
            WorkflowExpression.Validate(mSExcelGetWorksheetUsedRangehandle, nameof(mSExcelGetWorksheetUsedRangehandle), required: false);
            WorkflowExpression.Validate(mSExcelGetWorksheetUsedRangeworkbookName, nameof(mSExcelGetWorksheetUsedRangeworkbookName), required: false);
            WorkflowExpression.Validate(mSExcelGetWorksheetUsedRangeworksheetName, nameof(mSExcelGetWorksheetUsedRangeworksheetName), required: false);
            return new DeferredBodyAction<MSExcelGetWorksheetUsedRangeResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSExcelGetCountrySetting))]
        public IBodyWorkflowAction<MSExcelGetCountrySettingResponse> MSExcelGetCountrySetting([WorkflowExpression] Func<string> mSExcelGetCountrySettingworkflow, [WorkflowExpression] Func<int> mSExcelGetCountrySettinghandle = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MSExcelGetCountrySettingResponse> __BuildMSExcelGetCountrySetting(WorkflowExpression<string> mSExcelGetCountrySettingworkflow, WorkflowExpression<int> mSExcelGetCountrySettinghandle = null)
        {
            WorkflowExpression.Validate(mSExcelGetCountrySettingworkflow, nameof(mSExcelGetCountrySettingworkflow), required: true);
            WorkflowExpression.Validate(mSExcelGetCountrySettinghandle, nameof(mSExcelGetCountrySettinghandle), required: false);
            return new DeferredBodyAction<MSExcelGetCountrySettingResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSExcelWriteCollection))]
        public IWorkflowAction MSExcelWriteCollection([WorkflowExpression] Func<string> mSExcelWriteCollectioncellReference, [WorkflowExpression] Func<string> mSExcelWriteCollectioncollectionToWriteJSON, [WorkflowExpression] Func<string> mSExcelWriteCollectionworkflow, [WorkflowExpression] Func<int> mSExcelWriteCollectionhandle = null, [WorkflowExpression] Func<string> mSExcelWriteCollectionworkbookName = null, [WorkflowExpression] Func<string> mSExcelWriteCollectionworksheetName = null, [WorkflowExpression] Func<bool> mSExcelWriteCollectionincludeColumnNames = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMSExcelWriteCollection(WorkflowExpression<string> mSExcelWriteCollectioncellReference, WorkflowExpression<string> mSExcelWriteCollectioncollectionToWriteJSON, WorkflowExpression<string> mSExcelWriteCollectionworkflow, WorkflowExpression<int> mSExcelWriteCollectionhandle = null, WorkflowExpression<string> mSExcelWriteCollectionworkbookName = null, WorkflowExpression<string> mSExcelWriteCollectionworksheetName = null, WorkflowExpression<bool> mSExcelWriteCollectionincludeColumnNames = null)
        {
            WorkflowExpression.Validate(mSExcelWriteCollectioncellReference, nameof(mSExcelWriteCollectioncellReference), required: true);
            WorkflowExpression.Validate(mSExcelWriteCollectioncollectionToWriteJSON, nameof(mSExcelWriteCollectioncollectionToWriteJSON), required: true);
            WorkflowExpression.Validate(mSExcelWriteCollectionworkflow, nameof(mSExcelWriteCollectionworkflow), required: true);
            WorkflowExpression.Validate(mSExcelWriteCollectionhandle, nameof(mSExcelWriteCollectionhandle), required: false);
            WorkflowExpression.Validate(mSExcelWriteCollectionworkbookName, nameof(mSExcelWriteCollectionworkbookName), required: false);
            WorkflowExpression.Validate(mSExcelWriteCollectionworksheetName, nameof(mSExcelWriteCollectionworksheetName), required: false);
            WorkflowExpression.Validate(mSExcelWriteCollectionincludeColumnNames, nameof(mSExcelWriteCollectionincludeColumnNames), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSExcelWriteCollectionWithDates))]
        public IWorkflowAction MSExcelWriteCollectionWithDates([WorkflowExpression] Func<string> mSExcelWriteCollectionWithDatescellReference, [WorkflowExpression] Func<string> mSExcelWriteCollectionWithDatescollectionToWriteJSON, [WorkflowExpression] Func<string> mSExcelWriteCollectionWithDatesworkflow, [WorkflowExpression] Func<int> mSExcelWriteCollectionWithDateshandle = null, [WorkflowExpression] Func<string> mSExcelWriteCollectionWithDatesworkbookName = null, [WorkflowExpression] Func<string> mSExcelWriteCollectionWithDatesworksheetName = null, [WorkflowExpression] Func<bool> mSExcelWriteCollectionWithDatesincludeColumnNames = null, [WorkflowExpression] Func<bool> mSExcelWriteCollectionWithDatestryToConvertAllFieldsToDate = null, [WorkflowExpression] Func<string> mSExcelWriteCollectionWithDatescolumnsToConvertToDateJSON = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMSExcelWriteCollectionWithDates(WorkflowExpression<string> mSExcelWriteCollectionWithDatescellReference, WorkflowExpression<string> mSExcelWriteCollectionWithDatescollectionToWriteJSON, WorkflowExpression<string> mSExcelWriteCollectionWithDatesworkflow, WorkflowExpression<int> mSExcelWriteCollectionWithDateshandle = null, WorkflowExpression<string> mSExcelWriteCollectionWithDatesworkbookName = null, WorkflowExpression<string> mSExcelWriteCollectionWithDatesworksheetName = null, WorkflowExpression<bool> mSExcelWriteCollectionWithDatesincludeColumnNames = null, WorkflowExpression<bool> mSExcelWriteCollectionWithDatestryToConvertAllFieldsToDate = null, WorkflowExpression<string> mSExcelWriteCollectionWithDatescolumnsToConvertToDateJSON = null)
        {
            WorkflowExpression.Validate(mSExcelWriteCollectionWithDatescellReference, nameof(mSExcelWriteCollectionWithDatescellReference), required: true);
            WorkflowExpression.Validate(mSExcelWriteCollectionWithDatescollectionToWriteJSON, nameof(mSExcelWriteCollectionWithDatescollectionToWriteJSON), required: true);
            WorkflowExpression.Validate(mSExcelWriteCollectionWithDatesworkflow, nameof(mSExcelWriteCollectionWithDatesworkflow), required: true);
            WorkflowExpression.Validate(mSExcelWriteCollectionWithDateshandle, nameof(mSExcelWriteCollectionWithDateshandle), required: false);
            WorkflowExpression.Validate(mSExcelWriteCollectionWithDatesworkbookName, nameof(mSExcelWriteCollectionWithDatesworkbookName), required: false);
            WorkflowExpression.Validate(mSExcelWriteCollectionWithDatesworksheetName, nameof(mSExcelWriteCollectionWithDatesworksheetName), required: false);
            WorkflowExpression.Validate(mSExcelWriteCollectionWithDatesincludeColumnNames, nameof(mSExcelWriteCollectionWithDatesincludeColumnNames), required: false);
            WorkflowExpression.Validate(mSExcelWriteCollectionWithDatestryToConvertAllFieldsToDate, nameof(mSExcelWriteCollectionWithDatestryToConvertAllFieldsToDate), required: false);
            WorkflowExpression.Validate(mSExcelWriteCollectionWithDatescolumnsToConvertToDateJSON, nameof(mSExcelWriteCollectionWithDatescolumnsToConvertToDateJSON), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSExcelGetActiveCell))]
        public IBodyWorkflowAction<MSExcelGetActiveCellResponse> MSExcelGetActiveCell([WorkflowExpression] Func<string> mSExcelGetActiveCellworkflow, [WorkflowExpression] Func<int> mSExcelGetActiveCellhandle = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MSExcelGetActiveCellResponse> __BuildMSExcelGetActiveCell(WorkflowExpression<string> mSExcelGetActiveCellworkflow, WorkflowExpression<int> mSExcelGetActiveCellhandle = null)
        {
            WorkflowExpression.Validate(mSExcelGetActiveCellworkflow, nameof(mSExcelGetActiveCellworkflow), required: true);
            WorkflowExpression.Validate(mSExcelGetActiveCellhandle, nameof(mSExcelGetActiveCellhandle), required: false);
            return new DeferredBodyAction<MSExcelGetActiveCellResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSExcelFormatCell))]
        public IWorkflowAction MSExcelFormatCell([WorkflowExpression] Func<string> mSExcelFormatCellcellReference, [WorkflowExpression] Func<string> mSExcelFormatCellcellFormat, [WorkflowExpression] Func<string> mSExcelFormatCellworkflow, [WorkflowExpression] Func<int> mSExcelFormatCellhandle = null, [WorkflowExpression] Func<string> mSExcelFormatCellworkbookName = null, [WorkflowExpression] Func<string> mSExcelFormatCellworksheetName = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMSExcelFormatCell(WorkflowExpression<string> mSExcelFormatCellcellReference, WorkflowExpression<string> mSExcelFormatCellcellFormat, WorkflowExpression<string> mSExcelFormatCellworkflow, WorkflowExpression<int> mSExcelFormatCellhandle = null, WorkflowExpression<string> mSExcelFormatCellworkbookName = null, WorkflowExpression<string> mSExcelFormatCellworksheetName = null)
        {
            WorkflowExpression.Validate(mSExcelFormatCellcellReference, nameof(mSExcelFormatCellcellReference), required: true);
            WorkflowExpression.Validate(mSExcelFormatCellcellFormat, nameof(mSExcelFormatCellcellFormat), required: true);
            WorkflowExpression.Validate(mSExcelFormatCellworkflow, nameof(mSExcelFormatCellworkflow), required: true);
            WorkflowExpression.Validate(mSExcelFormatCellhandle, nameof(mSExcelFormatCellhandle), required: false);
            WorkflowExpression.Validate(mSExcelFormatCellworkbookName, nameof(mSExcelFormatCellworkbookName), required: false);
            WorkflowExpression.Validate(mSExcelFormatCellworksheetName, nameof(mSExcelFormatCellworksheetName), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSExcelFormatCurrentCell))]
        public IWorkflowAction MSExcelFormatCurrentCell([WorkflowExpression] Func<string> mSExcelFormatCurrentCellcellFormat, [WorkflowExpression] Func<string> mSExcelFormatCurrentCellworkflow, [WorkflowExpression] Func<int> mSExcelFormatCurrentCellhandle = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMSExcelFormatCurrentCell(WorkflowExpression<string> mSExcelFormatCurrentCellcellFormat, WorkflowExpression<string> mSExcelFormatCurrentCellworkflow, WorkflowExpression<int> mSExcelFormatCurrentCellhandle = null)
        {
            WorkflowExpression.Validate(mSExcelFormatCurrentCellcellFormat, nameof(mSExcelFormatCurrentCellcellFormat), required: true);
            WorkflowExpression.Validate(mSExcelFormatCurrentCellworkflow, nameof(mSExcelFormatCurrentCellworkflow), required: true);
            WorkflowExpression.Validate(mSExcelFormatCurrentCellhandle, nameof(mSExcelFormatCurrentCellhandle), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSExcelSelectCellRange))]
        public IWorkflowAction MSExcelSelectCellRange([WorkflowExpression] Func<string> mSExcelSelectCellRangecellReference, [WorkflowExpression] Func<string> mSExcelSelectCellRangeworkflow, [WorkflowExpression] Func<int> mSExcelSelectCellRangehandle = null, [WorkflowExpression] Func<string> mSExcelSelectCellRangeworkbookName = null, [WorkflowExpression] Func<string> mSExcelSelectCellRangeworksheetName = null, [WorkflowExpression] Func<bool> mSExcelSelectCellRangeentireRow = null, [WorkflowExpression] Func<bool> mSExcelSelectCellRangeentireColumn = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMSExcelSelectCellRange(WorkflowExpression<string> mSExcelSelectCellRangecellReference, WorkflowExpression<string> mSExcelSelectCellRangeworkflow, WorkflowExpression<int> mSExcelSelectCellRangehandle = null, WorkflowExpression<string> mSExcelSelectCellRangeworkbookName = null, WorkflowExpression<string> mSExcelSelectCellRangeworksheetName = null, WorkflowExpression<bool> mSExcelSelectCellRangeentireRow = null, WorkflowExpression<bool> mSExcelSelectCellRangeentireColumn = null)
        {
            WorkflowExpression.Validate(mSExcelSelectCellRangecellReference, nameof(mSExcelSelectCellRangecellReference), required: true);
            WorkflowExpression.Validate(mSExcelSelectCellRangeworkflow, nameof(mSExcelSelectCellRangeworkflow), required: true);
            WorkflowExpression.Validate(mSExcelSelectCellRangehandle, nameof(mSExcelSelectCellRangehandle), required: false);
            WorkflowExpression.Validate(mSExcelSelectCellRangeworkbookName, nameof(mSExcelSelectCellRangeworkbookName), required: false);
            WorkflowExpression.Validate(mSExcelSelectCellRangeworksheetName, nameof(mSExcelSelectCellRangeworksheetName), required: false);
            WorkflowExpression.Validate(mSExcelSelectCellRangeentireRow, nameof(mSExcelSelectCellRangeentireRow), required: false);
            WorkflowExpression.Validate(mSExcelSelectCellRangeentireColumn, nameof(mSExcelSelectCellRangeentireColumn), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSExcelCopySelection))]
        public IWorkflowAction MSExcelCopySelection([WorkflowExpression] Func<string> mSExcelCopySelectionworkflow, [WorkflowExpression] Func<int> mSExcelCopySelectionhandle = null, [WorkflowExpression] Func<string> mSExcelCopySelectionworkbookName = null, [WorkflowExpression] Func<string> mSExcelCopySelectionworksheetName = null, [WorkflowExpression] Func<string> mSExcelCopySelectioncellReference = null, [WorkflowExpression] Func<bool> mSExcelCopySelectionentireRow = null, [WorkflowExpression] Func<bool> mSExcelCopySelectionentireColumn = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMSExcelCopySelection(WorkflowExpression<string> mSExcelCopySelectionworkflow, WorkflowExpression<int> mSExcelCopySelectionhandle = null, WorkflowExpression<string> mSExcelCopySelectionworkbookName = null, WorkflowExpression<string> mSExcelCopySelectionworksheetName = null, WorkflowExpression<string> mSExcelCopySelectioncellReference = null, WorkflowExpression<bool> mSExcelCopySelectionentireRow = null, WorkflowExpression<bool> mSExcelCopySelectionentireColumn = null)
        {
            WorkflowExpression.Validate(mSExcelCopySelectionworkflow, nameof(mSExcelCopySelectionworkflow), required: true);
            WorkflowExpression.Validate(mSExcelCopySelectionhandle, nameof(mSExcelCopySelectionhandle), required: false);
            WorkflowExpression.Validate(mSExcelCopySelectionworkbookName, nameof(mSExcelCopySelectionworkbookName), required: false);
            WorkflowExpression.Validate(mSExcelCopySelectionworksheetName, nameof(mSExcelCopySelectionworksheetName), required: false);
            WorkflowExpression.Validate(mSExcelCopySelectioncellReference, nameof(mSExcelCopySelectioncellReference), required: false);
            WorkflowExpression.Validate(mSExcelCopySelectionentireRow, nameof(mSExcelCopySelectionentireRow), required: false);
            WorkflowExpression.Validate(mSExcelCopySelectionentireColumn, nameof(mSExcelCopySelectionentireColumn), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSExcelCutSelection))]
        public IWorkflowAction MSExcelCutSelection([WorkflowExpression] Func<string> mSExcelCutSelectionworkflow, [WorkflowExpression] Func<int> mSExcelCutSelectionhandle = null, [WorkflowExpression] Func<string> mSExcelCutSelectionworkbookName = null, [WorkflowExpression] Func<string> mSExcelCutSelectionworksheetName = null, [WorkflowExpression] Func<string> mSExcelCutSelectioncellReference = null, [WorkflowExpression] Func<bool> mSExcelCutSelectionentireRow = null, [WorkflowExpression] Func<bool> mSExcelCutSelectionentireColumn = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMSExcelCutSelection(WorkflowExpression<string> mSExcelCutSelectionworkflow, WorkflowExpression<int> mSExcelCutSelectionhandle = null, WorkflowExpression<string> mSExcelCutSelectionworkbookName = null, WorkflowExpression<string> mSExcelCutSelectionworksheetName = null, WorkflowExpression<string> mSExcelCutSelectioncellReference = null, WorkflowExpression<bool> mSExcelCutSelectionentireRow = null, WorkflowExpression<bool> mSExcelCutSelectionentireColumn = null)
        {
            WorkflowExpression.Validate(mSExcelCutSelectionworkflow, nameof(mSExcelCutSelectionworkflow), required: true);
            WorkflowExpression.Validate(mSExcelCutSelectionhandle, nameof(mSExcelCutSelectionhandle), required: false);
            WorkflowExpression.Validate(mSExcelCutSelectionworkbookName, nameof(mSExcelCutSelectionworkbookName), required: false);
            WorkflowExpression.Validate(mSExcelCutSelectionworksheetName, nameof(mSExcelCutSelectionworksheetName), required: false);
            WorkflowExpression.Validate(mSExcelCutSelectioncellReference, nameof(mSExcelCutSelectioncellReference), required: false);
            WorkflowExpression.Validate(mSExcelCutSelectionentireRow, nameof(mSExcelCutSelectionentireRow), required: false);
            WorkflowExpression.Validate(mSExcelCutSelectionentireColumn, nameof(mSExcelCutSelectionentireColumn), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSExcelPasteIntoSelection))]
        public IWorkflowAction MSExcelPasteIntoSelection([WorkflowExpression] Func<string> mSExcelPasteIntoSelectionworkflow, [WorkflowExpression] Func<int> mSExcelPasteIntoSelectionhandle = null, [WorkflowExpression] Func<string> mSExcelPasteIntoSelectionworkbookName = null, [WorkflowExpression] Func<string> mSExcelPasteIntoSelectionworksheetName = null, [WorkflowExpression] Func<bool> mSExcelPasteIntoSelectionvaluesOnly = null, [WorkflowExpression] Func<bool> mSExcelPasteIntoSelectionsimplePasteOnly = null, [WorkflowExpression] Func<string> mSExcelPasteIntoSelectioncellReference = null, [WorkflowExpression] Func<bool> mSExcelPasteIntoSelectionentireRow = null, [WorkflowExpression] Func<bool> mSExcelPasteIntoSelectionentireColumn = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMSExcelPasteIntoSelection(WorkflowExpression<string> mSExcelPasteIntoSelectionworkflow, WorkflowExpression<int> mSExcelPasteIntoSelectionhandle = null, WorkflowExpression<string> mSExcelPasteIntoSelectionworkbookName = null, WorkflowExpression<string> mSExcelPasteIntoSelectionworksheetName = null, WorkflowExpression<bool> mSExcelPasteIntoSelectionvaluesOnly = null, WorkflowExpression<bool> mSExcelPasteIntoSelectionsimplePasteOnly = null, WorkflowExpression<string> mSExcelPasteIntoSelectioncellReference = null, WorkflowExpression<bool> mSExcelPasteIntoSelectionentireRow = null, WorkflowExpression<bool> mSExcelPasteIntoSelectionentireColumn = null)
        {
            WorkflowExpression.Validate(mSExcelPasteIntoSelectionworkflow, nameof(mSExcelPasteIntoSelectionworkflow), required: true);
            WorkflowExpression.Validate(mSExcelPasteIntoSelectionhandle, nameof(mSExcelPasteIntoSelectionhandle), required: false);
            WorkflowExpression.Validate(mSExcelPasteIntoSelectionworkbookName, nameof(mSExcelPasteIntoSelectionworkbookName), required: false);
            WorkflowExpression.Validate(mSExcelPasteIntoSelectionworksheetName, nameof(mSExcelPasteIntoSelectionworksheetName), required: false);
            WorkflowExpression.Validate(mSExcelPasteIntoSelectionvaluesOnly, nameof(mSExcelPasteIntoSelectionvaluesOnly), required: false);
            WorkflowExpression.Validate(mSExcelPasteIntoSelectionsimplePasteOnly, nameof(mSExcelPasteIntoSelectionsimplePasteOnly), required: false);
            WorkflowExpression.Validate(mSExcelPasteIntoSelectioncellReference, nameof(mSExcelPasteIntoSelectioncellReference), required: false);
            WorkflowExpression.Validate(mSExcelPasteIntoSelectionentireRow, nameof(mSExcelPasteIntoSelectionentireRow), required: false);
            WorkflowExpression.Validate(mSExcelPasteIntoSelectionentireColumn, nameof(mSExcelPasteIntoSelectionentireColumn), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSExcelInsertOnSelection))]
        public IWorkflowAction MSExcelInsertOnSelection([WorkflowExpression] Func<string> mSExcelInsertOnSelectionworkflow, [WorkflowExpression] Func<int> mSExcelInsertOnSelectionhandle = null, [WorkflowExpression] Func<string> mSExcelInsertOnSelectionworkbookName = null, [WorkflowExpression] Func<string> mSExcelInsertOnSelectionworksheetName = null, [WorkflowExpression] Func<string> mSExcelInsertOnSelectioncellReference = null, [WorkflowExpression] Func<bool> mSExcelInsertOnSelectionentireRow = null, [WorkflowExpression] Func<bool> mSExcelInsertOnSelectionentireColumn = null, [WorkflowExpression] Func<mSExcelInsertOnSelectionshiftInput> mSExcelInsertOnSelectionshift = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMSExcelInsertOnSelection(WorkflowExpression<string> mSExcelInsertOnSelectionworkflow, WorkflowExpression<int> mSExcelInsertOnSelectionhandle = null, WorkflowExpression<string> mSExcelInsertOnSelectionworkbookName = null, WorkflowExpression<string> mSExcelInsertOnSelectionworksheetName = null, WorkflowExpression<string> mSExcelInsertOnSelectioncellReference = null, WorkflowExpression<bool> mSExcelInsertOnSelectionentireRow = null, WorkflowExpression<bool> mSExcelInsertOnSelectionentireColumn = null, WorkflowExpression<mSExcelInsertOnSelectionshiftInput> mSExcelInsertOnSelectionshift = null)
        {
            WorkflowExpression.Validate(mSExcelInsertOnSelectionworkflow, nameof(mSExcelInsertOnSelectionworkflow), required: true);
            WorkflowExpression.Validate(mSExcelInsertOnSelectionhandle, nameof(mSExcelInsertOnSelectionhandle), required: false);
            WorkflowExpression.Validate(mSExcelInsertOnSelectionworkbookName, nameof(mSExcelInsertOnSelectionworkbookName), required: false);
            WorkflowExpression.Validate(mSExcelInsertOnSelectionworksheetName, nameof(mSExcelInsertOnSelectionworksheetName), required: false);
            WorkflowExpression.Validate(mSExcelInsertOnSelectioncellReference, nameof(mSExcelInsertOnSelectioncellReference), required: false);
            WorkflowExpression.Validate(mSExcelInsertOnSelectionentireRow, nameof(mSExcelInsertOnSelectionentireRow), required: false);
            WorkflowExpression.Validate(mSExcelInsertOnSelectionentireColumn, nameof(mSExcelInsertOnSelectionentireColumn), required: false);
            WorkflowExpression.Validate(mSExcelInsertOnSelectionshift, nameof(mSExcelInsertOnSelectionshift), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSExcelDeleteSelection))]
        public IWorkflowAction MSExcelDeleteSelection([WorkflowExpression] Func<string> mSExcelDeleteSelectionworkflow, [WorkflowExpression] Func<int> mSExcelDeleteSelectionhandle = null, [WorkflowExpression] Func<string> mSExcelDeleteSelectionworkbookName = null, [WorkflowExpression] Func<string> mSExcelDeleteSelectionworksheetName = null, [WorkflowExpression] Func<string> mSExcelDeleteSelectioncellReference = null, [WorkflowExpression] Func<bool> mSExcelDeleteSelectionentireRow = null, [WorkflowExpression] Func<bool> mSExcelDeleteSelectionentireColumn = null, [WorkflowExpression] Func<mSExcelDeleteSelectionshiftInput> mSExcelDeleteSelectionshift = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMSExcelDeleteSelection(WorkflowExpression<string> mSExcelDeleteSelectionworkflow, WorkflowExpression<int> mSExcelDeleteSelectionhandle = null, WorkflowExpression<string> mSExcelDeleteSelectionworkbookName = null, WorkflowExpression<string> mSExcelDeleteSelectionworksheetName = null, WorkflowExpression<string> mSExcelDeleteSelectioncellReference = null, WorkflowExpression<bool> mSExcelDeleteSelectionentireRow = null, WorkflowExpression<bool> mSExcelDeleteSelectionentireColumn = null, WorkflowExpression<mSExcelDeleteSelectionshiftInput> mSExcelDeleteSelectionshift = null)
        {
            WorkflowExpression.Validate(mSExcelDeleteSelectionworkflow, nameof(mSExcelDeleteSelectionworkflow), required: true);
            WorkflowExpression.Validate(mSExcelDeleteSelectionhandle, nameof(mSExcelDeleteSelectionhandle), required: false);
            WorkflowExpression.Validate(mSExcelDeleteSelectionworkbookName, nameof(mSExcelDeleteSelectionworkbookName), required: false);
            WorkflowExpression.Validate(mSExcelDeleteSelectionworksheetName, nameof(mSExcelDeleteSelectionworksheetName), required: false);
            WorkflowExpression.Validate(mSExcelDeleteSelectioncellReference, nameof(mSExcelDeleteSelectioncellReference), required: false);
            WorkflowExpression.Validate(mSExcelDeleteSelectionentireRow, nameof(mSExcelDeleteSelectionentireRow), required: false);
            WorkflowExpression.Validate(mSExcelDeleteSelectionentireColumn, nameof(mSExcelDeleteSelectionentireColumn), required: false);
            WorkflowExpression.Validate(mSExcelDeleteSelectionshift, nameof(mSExcelDeleteSelectionshift), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSExcelClearExcelClipboard))]
        public IWorkflowAction MSExcelClearExcelClipboard([WorkflowExpression] Func<string> mSExcelClearExcelClipboardworkflow, [WorkflowExpression] Func<int> mSExcelClearExcelClipboardhandle = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMSExcelClearExcelClipboard(WorkflowExpression<string> mSExcelClearExcelClipboardworkflow, WorkflowExpression<int> mSExcelClearExcelClipboardhandle = null)
        {
            WorkflowExpression.Validate(mSExcelClearExcelClipboardworkflow, nameof(mSExcelClearExcelClipboardworkflow), required: true);
            WorkflowExpression.Validate(mSExcelClearExcelClipboardhandle, nameof(mSExcelClearExcelClipboardhandle), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSExcelRunMacro))]
        public IBodyWorkflowAction<MSExcelRunMacroResponse> MSExcelRunMacro([WorkflowExpression] Func<string> mSExcelRunMacromacroName, [WorkflowExpression] Func<string> mSExcelRunMacroworkflow, [WorkflowExpression] Func<int> mSExcelRunMacrohandle = null, [WorkflowExpression] Func<int> mSExcelRunMacronumberOfArguments = null, [WorkflowExpression] Func<string> mSExcelRunMacroargument1 = null, [WorkflowExpression] Func<string> mSExcelRunMacroargument2 = null, [WorkflowExpression] Func<string> mSExcelRunMacroargument3 = null, [WorkflowExpression] Func<string> mSExcelRunMacroargument4 = null, [WorkflowExpression] Func<string> mSExcelRunMacroargument5 = null, [WorkflowExpression] Func<string> mSExcelRunMacroargument6 = null, [WorkflowExpression] Func<string> mSExcelRunMacroargument7 = null, [WorkflowExpression] Func<string> mSExcelRunMacroargument8 = null, [WorkflowExpression] Func<string> mSExcelRunMacroargument9 = null, [WorkflowExpression] Func<string> mSExcelRunMacroargument10 = null, [WorkflowExpression] Func<bool> mSExcelRunMacrorunInBackground = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MSExcelRunMacroResponse> __BuildMSExcelRunMacro(WorkflowExpression<string> mSExcelRunMacromacroName, WorkflowExpression<string> mSExcelRunMacroworkflow, WorkflowExpression<int> mSExcelRunMacrohandle = null, WorkflowExpression<int> mSExcelRunMacronumberOfArguments = null, WorkflowExpression<string> mSExcelRunMacroargument1 = null, WorkflowExpression<string> mSExcelRunMacroargument2 = null, WorkflowExpression<string> mSExcelRunMacroargument3 = null, WorkflowExpression<string> mSExcelRunMacroargument4 = null, WorkflowExpression<string> mSExcelRunMacroargument5 = null, WorkflowExpression<string> mSExcelRunMacroargument6 = null, WorkflowExpression<string> mSExcelRunMacroargument7 = null, WorkflowExpression<string> mSExcelRunMacroargument8 = null, WorkflowExpression<string> mSExcelRunMacroargument9 = null, WorkflowExpression<string> mSExcelRunMacroargument10 = null, WorkflowExpression<bool> mSExcelRunMacrorunInBackground = null)
        {
            WorkflowExpression.Validate(mSExcelRunMacromacroName, nameof(mSExcelRunMacromacroName), required: true);
            WorkflowExpression.Validate(mSExcelRunMacroworkflow, nameof(mSExcelRunMacroworkflow), required: true);
            WorkflowExpression.Validate(mSExcelRunMacrohandle, nameof(mSExcelRunMacrohandle), required: false);
            WorkflowExpression.Validate(mSExcelRunMacronumberOfArguments, nameof(mSExcelRunMacronumberOfArguments), required: false);
            WorkflowExpression.Validate(mSExcelRunMacroargument1, nameof(mSExcelRunMacroargument1), required: false);
            WorkflowExpression.Validate(mSExcelRunMacroargument2, nameof(mSExcelRunMacroargument2), required: false);
            WorkflowExpression.Validate(mSExcelRunMacroargument3, nameof(mSExcelRunMacroargument3), required: false);
            WorkflowExpression.Validate(mSExcelRunMacroargument4, nameof(mSExcelRunMacroargument4), required: false);
            WorkflowExpression.Validate(mSExcelRunMacroargument5, nameof(mSExcelRunMacroargument5), required: false);
            WorkflowExpression.Validate(mSExcelRunMacroargument6, nameof(mSExcelRunMacroargument6), required: false);
            WorkflowExpression.Validate(mSExcelRunMacroargument7, nameof(mSExcelRunMacroargument7), required: false);
            WorkflowExpression.Validate(mSExcelRunMacroargument8, nameof(mSExcelRunMacroargument8), required: false);
            WorkflowExpression.Validate(mSExcelRunMacroargument9, nameof(mSExcelRunMacroargument9), required: false);
            WorkflowExpression.Validate(mSExcelRunMacroargument10, nameof(mSExcelRunMacroargument10), required: false);
            WorkflowExpression.Validate(mSExcelRunMacrorunInBackground, nameof(mSExcelRunMacrorunInBackground), required: false);
            return new DeferredBodyAction<MSExcelRunMacroResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSExcelAddMacroToWorkbook))]
        public IWorkflowAction MSExcelAddMacroToWorkbook([WorkflowExpression] Func<string> mSExcelAddMacroToWorkbookmacroCode, [WorkflowExpression] Func<string> mSExcelAddMacroToWorkbookworkflow, [WorkflowExpression] Func<int> mSExcelAddMacroToWorkbookhandle = null, [WorkflowExpression] Func<string> mSExcelAddMacroToWorkbookworkbookName = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMSExcelAddMacroToWorkbook(WorkflowExpression<string> mSExcelAddMacroToWorkbookmacroCode, WorkflowExpression<string> mSExcelAddMacroToWorkbookworkflow, WorkflowExpression<int> mSExcelAddMacroToWorkbookhandle = null, WorkflowExpression<string> mSExcelAddMacroToWorkbookworkbookName = null)
        {
            WorkflowExpression.Validate(mSExcelAddMacroToWorkbookmacroCode, nameof(mSExcelAddMacroToWorkbookmacroCode), required: true);
            WorkflowExpression.Validate(mSExcelAddMacroToWorkbookworkflow, nameof(mSExcelAddMacroToWorkbookworkflow), required: true);
            WorkflowExpression.Validate(mSExcelAddMacroToWorkbookhandle, nameof(mSExcelAddMacroToWorkbookhandle), required: false);
            WorkflowExpression.Validate(mSExcelAddMacroToWorkbookworkbookName, nameof(mSExcelAddMacroToWorkbookworkbookName), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSExcelTrustVBOMInRegistry))]
        public IWorkflowAction MSExcelTrustVBOMInRegistry([WorkflowExpression] Func<string> mSExcelTrustVBOMInRegistryworkflow, [WorkflowExpression] Func<int> mSExcelTrustVBOMInRegistryexcelVersion = null, [WorkflowExpression] Func<bool> mSExcelTrustVBOMInRegistrytrustVBOM = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMSExcelTrustVBOMInRegistry(WorkflowExpression<string> mSExcelTrustVBOMInRegistryworkflow, WorkflowExpression<int> mSExcelTrustVBOMInRegistryexcelVersion = null, WorkflowExpression<bool> mSExcelTrustVBOMInRegistrytrustVBOM = null)
        {
            WorkflowExpression.Validate(mSExcelTrustVBOMInRegistryworkflow, nameof(mSExcelTrustVBOMInRegistryworkflow), required: true);
            WorkflowExpression.Validate(mSExcelTrustVBOMInRegistryexcelVersion, nameof(mSExcelTrustVBOMInRegistryexcelVersion), required: false);
            WorkflowExpression.Validate(mSExcelTrustVBOMInRegistrytrustVBOM, nameof(mSExcelTrustVBOMInRegistrytrustVBOM), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSExcelSetCalculationMode))]
        public IWorkflowAction MSExcelSetCalculationMode([WorkflowExpression] Func<int> mSExcelSetCalculationModecalculationMode, [WorkflowExpression] Func<string> mSExcelSetCalculationModeworkflow, [WorkflowExpression] Func<int> mSExcelSetCalculationModehandle = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMSExcelSetCalculationMode(WorkflowExpression<int> mSExcelSetCalculationModecalculationMode, WorkflowExpression<string> mSExcelSetCalculationModeworkflow, WorkflowExpression<int> mSExcelSetCalculationModehandle = null)
        {
            WorkflowExpression.Validate(mSExcelSetCalculationModecalculationMode, nameof(mSExcelSetCalculationModecalculationMode), required: true);
            WorkflowExpression.Validate(mSExcelSetCalculationModeworkflow, nameof(mSExcelSetCalculationModeworkflow), required: true);
            WorkflowExpression.Validate(mSExcelSetCalculationModehandle, nameof(mSExcelSetCalculationModehandle), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSExcelExecuteCommandBarObject))]
        public IWorkflowAction MSExcelExecuteCommandBarObject([WorkflowExpression] Func<string> mSExcelExecuteCommandBarObjectobjectId, [WorkflowExpression] Func<string> mSExcelExecuteCommandBarObjectworkflow, [WorkflowExpression] Func<int> mSExcelExecuteCommandBarObjecthandle = null, [WorkflowExpression] Func<bool> mSExcelExecuteCommandBarObjectrunInBackground = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMSExcelExecuteCommandBarObject(WorkflowExpression<string> mSExcelExecuteCommandBarObjectobjectId, WorkflowExpression<string> mSExcelExecuteCommandBarObjectworkflow, WorkflowExpression<int> mSExcelExecuteCommandBarObjecthandle = null, WorkflowExpression<bool> mSExcelExecuteCommandBarObjectrunInBackground = null)
        {
            WorkflowExpression.Validate(mSExcelExecuteCommandBarObjectobjectId, nameof(mSExcelExecuteCommandBarObjectobjectId), required: true);
            WorkflowExpression.Validate(mSExcelExecuteCommandBarObjectworkflow, nameof(mSExcelExecuteCommandBarObjectworkflow), required: true);
            WorkflowExpression.Validate(mSExcelExecuteCommandBarObjecthandle, nameof(mSExcelExecuteCommandBarObjecthandle), required: false);
            WorkflowExpression.Validate(mSExcelExecuteCommandBarObjectrunInBackground, nameof(mSExcelExecuteCommandBarObjectrunInBackground), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSExcelCopyBetweenCells))]
        public IBodyWorkflowAction<MSExcelCopyBetweenCellsResponse> MSExcelCopyBetweenCells([WorkflowExpression] Func<string> mSExcelCopyBetweenCellssourceCellReference, [WorkflowExpression] Func<string> mSExcelCopyBetweenCellstargetCellReference, [WorkflowExpression] Func<string> mSExcelCopyBetweenCellsworkflow, [WorkflowExpression] Func<int> mSExcelCopyBetweenCellssourceHandle = null, [WorkflowExpression] Func<string> mSExcelCopyBetweenCellssourceWorkbookName = null, [WorkflowExpression] Func<string> mSExcelCopyBetweenCellssourceWorksheetName = null, [WorkflowExpression] Func<bool> mSExcelCopyBetweenCellssourceEntireRow = null, [WorkflowExpression] Func<bool> mSExcelCopyBetweenCellssourceEntireColumn = null, [WorkflowExpression] Func<int> mSExcelCopyBetweenCellstargetHandle = null, [WorkflowExpression] Func<string> mSExcelCopyBetweenCellstargetWorkbookName = null, [WorkflowExpression] Func<string> mSExcelCopyBetweenCellstargetWorksheetName = null, [WorkflowExpression] Func<bool> mSExcelCopyBetweenCellstargetEntireRow = null, [WorkflowExpression] Func<bool> mSExcelCopyBetweenCellstargetEntireColumn = null, [WorkflowExpression] Func<bool> mSExcelCopyBetweenCellsvaluesOnly = null, [WorkflowExpression] Func<bool> mSExcelCopyBetweenCellssimplePasteOnly = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MSExcelCopyBetweenCellsResponse> __BuildMSExcelCopyBetweenCells(WorkflowExpression<string> mSExcelCopyBetweenCellssourceCellReference, WorkflowExpression<string> mSExcelCopyBetweenCellstargetCellReference, WorkflowExpression<string> mSExcelCopyBetweenCellsworkflow, WorkflowExpression<int> mSExcelCopyBetweenCellssourceHandle = null, WorkflowExpression<string> mSExcelCopyBetweenCellssourceWorkbookName = null, WorkflowExpression<string> mSExcelCopyBetweenCellssourceWorksheetName = null, WorkflowExpression<bool> mSExcelCopyBetweenCellssourceEntireRow = null, WorkflowExpression<bool> mSExcelCopyBetweenCellssourceEntireColumn = null, WorkflowExpression<int> mSExcelCopyBetweenCellstargetHandle = null, WorkflowExpression<string> mSExcelCopyBetweenCellstargetWorkbookName = null, WorkflowExpression<string> mSExcelCopyBetweenCellstargetWorksheetName = null, WorkflowExpression<bool> mSExcelCopyBetweenCellstargetEntireRow = null, WorkflowExpression<bool> mSExcelCopyBetweenCellstargetEntireColumn = null, WorkflowExpression<bool> mSExcelCopyBetweenCellsvaluesOnly = null, WorkflowExpression<bool> mSExcelCopyBetweenCellssimplePasteOnly = null)
        {
            WorkflowExpression.Validate(mSExcelCopyBetweenCellssourceCellReference, nameof(mSExcelCopyBetweenCellssourceCellReference), required: true);
            WorkflowExpression.Validate(mSExcelCopyBetweenCellstargetCellReference, nameof(mSExcelCopyBetweenCellstargetCellReference), required: true);
            WorkflowExpression.Validate(mSExcelCopyBetweenCellsworkflow, nameof(mSExcelCopyBetweenCellsworkflow), required: true);
            WorkflowExpression.Validate(mSExcelCopyBetweenCellssourceHandle, nameof(mSExcelCopyBetweenCellssourceHandle), required: false);
            WorkflowExpression.Validate(mSExcelCopyBetweenCellssourceWorkbookName, nameof(mSExcelCopyBetweenCellssourceWorkbookName), required: false);
            WorkflowExpression.Validate(mSExcelCopyBetweenCellssourceWorksheetName, nameof(mSExcelCopyBetweenCellssourceWorksheetName), required: false);
            WorkflowExpression.Validate(mSExcelCopyBetweenCellssourceEntireRow, nameof(mSExcelCopyBetweenCellssourceEntireRow), required: false);
            WorkflowExpression.Validate(mSExcelCopyBetweenCellssourceEntireColumn, nameof(mSExcelCopyBetweenCellssourceEntireColumn), required: false);
            WorkflowExpression.Validate(mSExcelCopyBetweenCellstargetHandle, nameof(mSExcelCopyBetweenCellstargetHandle), required: false);
            WorkflowExpression.Validate(mSExcelCopyBetweenCellstargetWorkbookName, nameof(mSExcelCopyBetweenCellstargetWorkbookName), required: false);
            WorkflowExpression.Validate(mSExcelCopyBetweenCellstargetWorksheetName, nameof(mSExcelCopyBetweenCellstargetWorksheetName), required: false);
            WorkflowExpression.Validate(mSExcelCopyBetweenCellstargetEntireRow, nameof(mSExcelCopyBetweenCellstargetEntireRow), required: false);
            WorkflowExpression.Validate(mSExcelCopyBetweenCellstargetEntireColumn, nameof(mSExcelCopyBetweenCellstargetEntireColumn), required: false);
            WorkflowExpression.Validate(mSExcelCopyBetweenCellsvaluesOnly, nameof(mSExcelCopyBetweenCellsvaluesOnly), required: false);
            WorkflowExpression.Validate(mSExcelCopyBetweenCellssimplePasteOnly, nameof(mSExcelCopyBetweenCellssimplePasteOnly), required: false);
            return new DeferredBodyAction<MSExcelCopyBetweenCellsResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSExcelCutBetweenCells))]
        public IBodyWorkflowAction<MSExcelCutBetweenCellsResponse> MSExcelCutBetweenCells([WorkflowExpression] Func<string> mSExcelCutBetweenCellssourceCellReference, [WorkflowExpression] Func<string> mSExcelCutBetweenCellstargetCellReference, [WorkflowExpression] Func<string> mSExcelCutBetweenCellsworkflow, [WorkflowExpression] Func<int> mSExcelCutBetweenCellssourceHandle = null, [WorkflowExpression] Func<string> mSExcelCutBetweenCellssourceWorkbookName = null, [WorkflowExpression] Func<string> mSExcelCutBetweenCellssourceWorksheetName = null, [WorkflowExpression] Func<bool> mSExcelCutBetweenCellssourceEntireRow = null, [WorkflowExpression] Func<bool> mSExcelCutBetweenCellssourceEntireColumn = null, [WorkflowExpression] Func<int> mSExcelCutBetweenCellstargetHandle = null, [WorkflowExpression] Func<string> mSExcelCutBetweenCellstargetWorkbookName = null, [WorkflowExpression] Func<string> mSExcelCutBetweenCellstargetWorksheetName = null, [WorkflowExpression] Func<bool> mSExcelCutBetweenCellstargetEntireRow = null, [WorkflowExpression] Func<bool> mSExcelCutBetweenCellstargetEntireColumn = null, [WorkflowExpression] Func<bool> mSExcelCutBetweenCellsvaluesOnly = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MSExcelCutBetweenCellsResponse> __BuildMSExcelCutBetweenCells(WorkflowExpression<string> mSExcelCutBetweenCellssourceCellReference, WorkflowExpression<string> mSExcelCutBetweenCellstargetCellReference, WorkflowExpression<string> mSExcelCutBetweenCellsworkflow, WorkflowExpression<int> mSExcelCutBetweenCellssourceHandle = null, WorkflowExpression<string> mSExcelCutBetweenCellssourceWorkbookName = null, WorkflowExpression<string> mSExcelCutBetweenCellssourceWorksheetName = null, WorkflowExpression<bool> mSExcelCutBetweenCellssourceEntireRow = null, WorkflowExpression<bool> mSExcelCutBetweenCellssourceEntireColumn = null, WorkflowExpression<int> mSExcelCutBetweenCellstargetHandle = null, WorkflowExpression<string> mSExcelCutBetweenCellstargetWorkbookName = null, WorkflowExpression<string> mSExcelCutBetweenCellstargetWorksheetName = null, WorkflowExpression<bool> mSExcelCutBetweenCellstargetEntireRow = null, WorkflowExpression<bool> mSExcelCutBetweenCellstargetEntireColumn = null, WorkflowExpression<bool> mSExcelCutBetweenCellsvaluesOnly = null)
        {
            WorkflowExpression.Validate(mSExcelCutBetweenCellssourceCellReference, nameof(mSExcelCutBetweenCellssourceCellReference), required: true);
            WorkflowExpression.Validate(mSExcelCutBetweenCellstargetCellReference, nameof(mSExcelCutBetweenCellstargetCellReference), required: true);
            WorkflowExpression.Validate(mSExcelCutBetweenCellsworkflow, nameof(mSExcelCutBetweenCellsworkflow), required: true);
            WorkflowExpression.Validate(mSExcelCutBetweenCellssourceHandle, nameof(mSExcelCutBetweenCellssourceHandle), required: false);
            WorkflowExpression.Validate(mSExcelCutBetweenCellssourceWorkbookName, nameof(mSExcelCutBetweenCellssourceWorkbookName), required: false);
            WorkflowExpression.Validate(mSExcelCutBetweenCellssourceWorksheetName, nameof(mSExcelCutBetweenCellssourceWorksheetName), required: false);
            WorkflowExpression.Validate(mSExcelCutBetweenCellssourceEntireRow, nameof(mSExcelCutBetweenCellssourceEntireRow), required: false);
            WorkflowExpression.Validate(mSExcelCutBetweenCellssourceEntireColumn, nameof(mSExcelCutBetweenCellssourceEntireColumn), required: false);
            WorkflowExpression.Validate(mSExcelCutBetweenCellstargetHandle, nameof(mSExcelCutBetweenCellstargetHandle), required: false);
            WorkflowExpression.Validate(mSExcelCutBetweenCellstargetWorkbookName, nameof(mSExcelCutBetweenCellstargetWorkbookName), required: false);
            WorkflowExpression.Validate(mSExcelCutBetweenCellstargetWorksheetName, nameof(mSExcelCutBetweenCellstargetWorksheetName), required: false);
            WorkflowExpression.Validate(mSExcelCutBetweenCellstargetEntireRow, nameof(mSExcelCutBetweenCellstargetEntireRow), required: false);
            WorkflowExpression.Validate(mSExcelCutBetweenCellstargetEntireColumn, nameof(mSExcelCutBetweenCellstargetEntireColumn), required: false);
            WorkflowExpression.Validate(mSExcelCutBetweenCellsvaluesOnly, nameof(mSExcelCutBetweenCellsvaluesOnly), required: false);
            return new DeferredBodyAction<MSExcelCutBetweenCellsResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSExcelMinimiseWindow))]
        public IBodyWorkflowAction<MSExcelMinimiseWindowResponse> MSExcelMinimiseWindow([WorkflowExpression] Func<string> mSExcelMinimiseWindowworkflow, [WorkflowExpression] Func<int> mSExcelMinimiseWindowhandle = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MSExcelMinimiseWindowResponse> __BuildMSExcelMinimiseWindow(WorkflowExpression<string> mSExcelMinimiseWindowworkflow, WorkflowExpression<int> mSExcelMinimiseWindowhandle = null)
        {
            WorkflowExpression.Validate(mSExcelMinimiseWindowworkflow, nameof(mSExcelMinimiseWindowworkflow), required: true);
            WorkflowExpression.Validate(mSExcelMinimiseWindowhandle, nameof(mSExcelMinimiseWindowhandle), required: false);
            return new DeferredBodyAction<MSExcelMinimiseWindowResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSExcelMaximiseWindow))]
        public IBodyWorkflowAction<MSExcelMaximiseWindowResponse> MSExcelMaximiseWindow([WorkflowExpression] Func<string> mSExcelMaximiseWindowworkflow, [WorkflowExpression] Func<int> mSExcelMaximiseWindowhandle = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MSExcelMaximiseWindowResponse> __BuildMSExcelMaximiseWindow(WorkflowExpression<string> mSExcelMaximiseWindowworkflow, WorkflowExpression<int> mSExcelMaximiseWindowhandle = null)
        {
            WorkflowExpression.Validate(mSExcelMaximiseWindowworkflow, nameof(mSExcelMaximiseWindowworkflow), required: true);
            WorkflowExpression.Validate(mSExcelMaximiseWindowhandle, nameof(mSExcelMaximiseWindowhandle), required: false);
            return new DeferredBodyAction<MSExcelMaximiseWindowResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSExcelNormaliseWindow))]
        public IBodyWorkflowAction<MSExcelNormaliseWindowResponse> MSExcelNormaliseWindow([WorkflowExpression] Func<string> mSExcelNormaliseWindowworkflow, [WorkflowExpression] Func<int> mSExcelNormaliseWindowhandle = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MSExcelNormaliseWindowResponse> __BuildMSExcelNormaliseWindow(WorkflowExpression<string> mSExcelNormaliseWindowworkflow, WorkflowExpression<int> mSExcelNormaliseWindowhandle = null)
        {
            WorkflowExpression.Validate(mSExcelNormaliseWindowworkflow, nameof(mSExcelNormaliseWindowworkflow), required: true);
            WorkflowExpression.Validate(mSExcelNormaliseWindowhandle, nameof(mSExcelNormaliseWindowhandle), required: false);
            return new DeferredBodyAction<MSExcelNormaliseWindowResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSExcelGetAndSetCellValue))]
        public IBodyWorkflowAction<MSExcelGetAndSetCellValueResponse> MSExcelGetAndSetCellValue([WorkflowExpression] Func<string> mSExcelGetAndSetCellValuesourceCellReference, [WorkflowExpression] Func<string> mSExcelGetAndSetCellValuetargetCellReference, [WorkflowExpression] Func<string> mSExcelGetAndSetCellValueworkflow, [WorkflowExpression] Func<int> mSExcelGetAndSetCellValuesourceHandle = null, [WorkflowExpression] Func<string> mSExcelGetAndSetCellValuesourceWorkbookName = null, [WorkflowExpression] Func<string> mSExcelGetAndSetCellValuesourceWorksheetName = null, [WorkflowExpression] Func<int> mSExcelGetAndSetCellValuetargetHandle = null, [WorkflowExpression] Func<string> mSExcelGetAndSetCellValuetargetWorkbookName = null, [WorkflowExpression] Func<string> mSExcelGetAndSetCellValuetargetWorksheetName = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MSExcelGetAndSetCellValueResponse> __BuildMSExcelGetAndSetCellValue(WorkflowExpression<string> mSExcelGetAndSetCellValuesourceCellReference, WorkflowExpression<string> mSExcelGetAndSetCellValuetargetCellReference, WorkflowExpression<string> mSExcelGetAndSetCellValueworkflow, WorkflowExpression<int> mSExcelGetAndSetCellValuesourceHandle = null, WorkflowExpression<string> mSExcelGetAndSetCellValuesourceWorkbookName = null, WorkflowExpression<string> mSExcelGetAndSetCellValuesourceWorksheetName = null, WorkflowExpression<int> mSExcelGetAndSetCellValuetargetHandle = null, WorkflowExpression<string> mSExcelGetAndSetCellValuetargetWorkbookName = null, WorkflowExpression<string> mSExcelGetAndSetCellValuetargetWorksheetName = null)
        {
            WorkflowExpression.Validate(mSExcelGetAndSetCellValuesourceCellReference, nameof(mSExcelGetAndSetCellValuesourceCellReference), required: true);
            WorkflowExpression.Validate(mSExcelGetAndSetCellValuetargetCellReference, nameof(mSExcelGetAndSetCellValuetargetCellReference), required: true);
            WorkflowExpression.Validate(mSExcelGetAndSetCellValueworkflow, nameof(mSExcelGetAndSetCellValueworkflow), required: true);
            WorkflowExpression.Validate(mSExcelGetAndSetCellValuesourceHandle, nameof(mSExcelGetAndSetCellValuesourceHandle), required: false);
            WorkflowExpression.Validate(mSExcelGetAndSetCellValuesourceWorkbookName, nameof(mSExcelGetAndSetCellValuesourceWorkbookName), required: false);
            WorkflowExpression.Validate(mSExcelGetAndSetCellValuesourceWorksheetName, nameof(mSExcelGetAndSetCellValuesourceWorksheetName), required: false);
            WorkflowExpression.Validate(mSExcelGetAndSetCellValuetargetHandle, nameof(mSExcelGetAndSetCellValuetargetHandle), required: false);
            WorkflowExpression.Validate(mSExcelGetAndSetCellValuetargetWorkbookName, nameof(mSExcelGetAndSetCellValuetargetWorkbookName), required: false);
            WorkflowExpression.Validate(mSExcelGetAndSetCellValuetargetWorksheetName, nameof(mSExcelGetAndSetCellValuetargetWorksheetName), required: false);
            return new DeferredBodyAction<MSExcelGetAndSetCellValueResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSExcelGetAndSetCellValue2))]
        public IBodyWorkflowAction<MSExcelGetAndSetCellValue2Response> MSExcelGetAndSetCellValue2([WorkflowExpression] Func<string> mSExcelGetAndSetCellValue2sourceCellReference, [WorkflowExpression] Func<string> mSExcelGetAndSetCellValue2targetCellReference, [WorkflowExpression] Func<string> mSExcelGetAndSetCellValue2workflow, [WorkflowExpression] Func<int> mSExcelGetAndSetCellValue2sourceHandle = null, [WorkflowExpression] Func<string> mSExcelGetAndSetCellValue2sourceWorkbookName = null, [WorkflowExpression] Func<string> mSExcelGetAndSetCellValue2sourceWorksheetName = null, [WorkflowExpression] Func<int> mSExcelGetAndSetCellValue2targetHandle = null, [WorkflowExpression] Func<string> mSExcelGetAndSetCellValue2targetWorkbookName = null, [WorkflowExpression] Func<string> mSExcelGetAndSetCellValue2targetWorksheetName = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MSExcelGetAndSetCellValue2Response> __BuildMSExcelGetAndSetCellValue2(WorkflowExpression<string> mSExcelGetAndSetCellValue2sourceCellReference, WorkflowExpression<string> mSExcelGetAndSetCellValue2targetCellReference, WorkflowExpression<string> mSExcelGetAndSetCellValue2workflow, WorkflowExpression<int> mSExcelGetAndSetCellValue2sourceHandle = null, WorkflowExpression<string> mSExcelGetAndSetCellValue2sourceWorkbookName = null, WorkflowExpression<string> mSExcelGetAndSetCellValue2sourceWorksheetName = null, WorkflowExpression<int> mSExcelGetAndSetCellValue2targetHandle = null, WorkflowExpression<string> mSExcelGetAndSetCellValue2targetWorkbookName = null, WorkflowExpression<string> mSExcelGetAndSetCellValue2targetWorksheetName = null)
        {
            WorkflowExpression.Validate(mSExcelGetAndSetCellValue2sourceCellReference, nameof(mSExcelGetAndSetCellValue2sourceCellReference), required: true);
            WorkflowExpression.Validate(mSExcelGetAndSetCellValue2targetCellReference, nameof(mSExcelGetAndSetCellValue2targetCellReference), required: true);
            WorkflowExpression.Validate(mSExcelGetAndSetCellValue2workflow, nameof(mSExcelGetAndSetCellValue2workflow), required: true);
            WorkflowExpression.Validate(mSExcelGetAndSetCellValue2sourceHandle, nameof(mSExcelGetAndSetCellValue2sourceHandle), required: false);
            WorkflowExpression.Validate(mSExcelGetAndSetCellValue2sourceWorkbookName, nameof(mSExcelGetAndSetCellValue2sourceWorkbookName), required: false);
            WorkflowExpression.Validate(mSExcelGetAndSetCellValue2sourceWorksheetName, nameof(mSExcelGetAndSetCellValue2sourceWorksheetName), required: false);
            WorkflowExpression.Validate(mSExcelGetAndSetCellValue2targetHandle, nameof(mSExcelGetAndSetCellValue2targetHandle), required: false);
            WorkflowExpression.Validate(mSExcelGetAndSetCellValue2targetWorkbookName, nameof(mSExcelGetAndSetCellValue2targetWorkbookName), required: false);
            WorkflowExpression.Validate(mSExcelGetAndSetCellValue2targetWorksheetName, nameof(mSExcelGetAndSetCellValue2targetWorksheetName), required: false);
            return new DeferredBodyAction<MSExcelGetAndSetCellValue2Response>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSExcelGetAndSetCellText))]
        public IBodyWorkflowAction<MSExcelGetAndSetCellTextResponse> MSExcelGetAndSetCellText([WorkflowExpression] Func<string> mSExcelGetAndSetCellTextsourceCellReference, [WorkflowExpression] Func<string> mSExcelGetAndSetCellTexttargetCellReference, [WorkflowExpression] Func<string> mSExcelGetAndSetCellTextworkflow, [WorkflowExpression] Func<int> mSExcelGetAndSetCellTextsourceHandle = null, [WorkflowExpression] Func<string> mSExcelGetAndSetCellTextsourceWorkbookName = null, [WorkflowExpression] Func<string> mSExcelGetAndSetCellTextsourceWorksheetName = null, [WorkflowExpression] Func<int> mSExcelGetAndSetCellTexttargetHandle = null, [WorkflowExpression] Func<string> mSExcelGetAndSetCellTexttargetWorkbookName = null, [WorkflowExpression] Func<string> mSExcelGetAndSetCellTexttargetWorksheetName = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MSExcelGetAndSetCellTextResponse> __BuildMSExcelGetAndSetCellText(WorkflowExpression<string> mSExcelGetAndSetCellTextsourceCellReference, WorkflowExpression<string> mSExcelGetAndSetCellTexttargetCellReference, WorkflowExpression<string> mSExcelGetAndSetCellTextworkflow, WorkflowExpression<int> mSExcelGetAndSetCellTextsourceHandle = null, WorkflowExpression<string> mSExcelGetAndSetCellTextsourceWorkbookName = null, WorkflowExpression<string> mSExcelGetAndSetCellTextsourceWorksheetName = null, WorkflowExpression<int> mSExcelGetAndSetCellTexttargetHandle = null, WorkflowExpression<string> mSExcelGetAndSetCellTexttargetWorkbookName = null, WorkflowExpression<string> mSExcelGetAndSetCellTexttargetWorksheetName = null)
        {
            WorkflowExpression.Validate(mSExcelGetAndSetCellTextsourceCellReference, nameof(mSExcelGetAndSetCellTextsourceCellReference), required: true);
            WorkflowExpression.Validate(mSExcelGetAndSetCellTexttargetCellReference, nameof(mSExcelGetAndSetCellTexttargetCellReference), required: true);
            WorkflowExpression.Validate(mSExcelGetAndSetCellTextworkflow, nameof(mSExcelGetAndSetCellTextworkflow), required: true);
            WorkflowExpression.Validate(mSExcelGetAndSetCellTextsourceHandle, nameof(mSExcelGetAndSetCellTextsourceHandle), required: false);
            WorkflowExpression.Validate(mSExcelGetAndSetCellTextsourceWorkbookName, nameof(mSExcelGetAndSetCellTextsourceWorkbookName), required: false);
            WorkflowExpression.Validate(mSExcelGetAndSetCellTextsourceWorksheetName, nameof(mSExcelGetAndSetCellTextsourceWorksheetName), required: false);
            WorkflowExpression.Validate(mSExcelGetAndSetCellTexttargetHandle, nameof(mSExcelGetAndSetCellTexttargetHandle), required: false);
            WorkflowExpression.Validate(mSExcelGetAndSetCellTexttargetWorkbookName, nameof(mSExcelGetAndSetCellTexttargetWorkbookName), required: false);
            WorkflowExpression.Validate(mSExcelGetAndSetCellTexttargetWorksheetName, nameof(mSExcelGetAndSetCellTexttargetWorksheetName), required: false);
            return new DeferredBodyAction<MSExcelGetAndSetCellTextResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSExcelCheckOLEObject))]
        public IBodyWorkflowAction<MSExcelCheckOLEObjectResponse> MSExcelCheckOLEObject([WorkflowExpression] Func<string> mSExcelCheckOLEObjectoLEObjectName, [WorkflowExpression] Func<string> mSExcelCheckOLEObjectworkflow, [WorkflowExpression] Func<int> mSExcelCheckOLEObjecthandle = null, [WorkflowExpression] Func<string> mSExcelCheckOLEObjectworkbookName = null, [WorkflowExpression] Func<string> mSExcelCheckOLEObjectworksheetName = null, [WorkflowExpression] Func<bool> mSExcelCheckOLEObjectchecked = null, [WorkflowExpression] Func<bool> mSExcelCheckOLEObjectrunInBackground = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MSExcelCheckOLEObjectResponse> __BuildMSExcelCheckOLEObject(WorkflowExpression<string> mSExcelCheckOLEObjectoLEObjectName, WorkflowExpression<string> mSExcelCheckOLEObjectworkflow, WorkflowExpression<int> mSExcelCheckOLEObjecthandle = null, WorkflowExpression<string> mSExcelCheckOLEObjectworkbookName = null, WorkflowExpression<string> mSExcelCheckOLEObjectworksheetName = null, WorkflowExpression<bool> mSExcelCheckOLEObjectchecked = null, WorkflowExpression<bool> mSExcelCheckOLEObjectrunInBackground = null)
        {
            WorkflowExpression.Validate(mSExcelCheckOLEObjectoLEObjectName, nameof(mSExcelCheckOLEObjectoLEObjectName), required: true);
            WorkflowExpression.Validate(mSExcelCheckOLEObjectworkflow, nameof(mSExcelCheckOLEObjectworkflow), required: true);
            WorkflowExpression.Validate(mSExcelCheckOLEObjecthandle, nameof(mSExcelCheckOLEObjecthandle), required: false);
            WorkflowExpression.Validate(mSExcelCheckOLEObjectworkbookName, nameof(mSExcelCheckOLEObjectworkbookName), required: false);
            WorkflowExpression.Validate(mSExcelCheckOLEObjectworksheetName, nameof(mSExcelCheckOLEObjectworksheetName), required: false);
            WorkflowExpression.Validate(mSExcelCheckOLEObjectchecked, nameof(mSExcelCheckOLEObjectchecked), required: false);
            WorkflowExpression.Validate(mSExcelCheckOLEObjectrunInBackground, nameof(mSExcelCheckOLEObjectrunInBackground), required: false);
            return new DeferredBodyAction<MSExcelCheckOLEObjectResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSExcelInputTextIntoOLEObject))]
        public IBodyWorkflowAction<MSExcelInputTextIntoOLEObjectResponse> MSExcelInputTextIntoOLEObject([WorkflowExpression] Func<string> mSExcelInputTextIntoOLEObjectoLEObjectName, [WorkflowExpression] Func<string> mSExcelInputTextIntoOLEObjectworkflow, [WorkflowExpression] Func<int> mSExcelInputTextIntoOLEObjecthandle = null, [WorkflowExpression] Func<string> mSExcelInputTextIntoOLEObjectworkbookName = null, [WorkflowExpression] Func<string> mSExcelInputTextIntoOLEObjectworksheetName = null, [WorkflowExpression] Func<string> mSExcelInputTextIntoOLEObjecttextToInput = null, [WorkflowExpression] Func<bool> mSExcelInputTextIntoOLEObjectrunInBackground = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MSExcelInputTextIntoOLEObjectResponse> __BuildMSExcelInputTextIntoOLEObject(WorkflowExpression<string> mSExcelInputTextIntoOLEObjectoLEObjectName, WorkflowExpression<string> mSExcelInputTextIntoOLEObjectworkflow, WorkflowExpression<int> mSExcelInputTextIntoOLEObjecthandle = null, WorkflowExpression<string> mSExcelInputTextIntoOLEObjectworkbookName = null, WorkflowExpression<string> mSExcelInputTextIntoOLEObjectworksheetName = null, WorkflowExpression<string> mSExcelInputTextIntoOLEObjecttextToInput = null, WorkflowExpression<bool> mSExcelInputTextIntoOLEObjectrunInBackground = null)
        {
            WorkflowExpression.Validate(mSExcelInputTextIntoOLEObjectoLEObjectName, nameof(mSExcelInputTextIntoOLEObjectoLEObjectName), required: true);
            WorkflowExpression.Validate(mSExcelInputTextIntoOLEObjectworkflow, nameof(mSExcelInputTextIntoOLEObjectworkflow), required: true);
            WorkflowExpression.Validate(mSExcelInputTextIntoOLEObjecthandle, nameof(mSExcelInputTextIntoOLEObjecthandle), required: false);
            WorkflowExpression.Validate(mSExcelInputTextIntoOLEObjectworkbookName, nameof(mSExcelInputTextIntoOLEObjectworkbookName), required: false);
            WorkflowExpression.Validate(mSExcelInputTextIntoOLEObjectworksheetName, nameof(mSExcelInputTextIntoOLEObjectworksheetName), required: false);
            WorkflowExpression.Validate(mSExcelInputTextIntoOLEObjecttextToInput, nameof(mSExcelInputTextIntoOLEObjecttextToInput), required: false);
            WorkflowExpression.Validate(mSExcelInputTextIntoOLEObjectrunInBackground, nameof(mSExcelInputTextIntoOLEObjectrunInBackground), required: false);
            return new DeferredBodyAction<MSExcelInputTextIntoOLEObjectResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSExcelSetCellBackgroundColour))]
        public IBodyWorkflowAction<MSExcelSetCellBackgroundColourResponse> MSExcelSetCellBackgroundColour([WorkflowExpression] Func<string> mSExcelSetCellBackgroundColourcellReference, [WorkflowExpression] Func<int> mSExcelSetCellBackgroundColourcolourIndex, [WorkflowExpression] Func<string> mSExcelSetCellBackgroundColourworkflow, [WorkflowExpression] Func<int> mSExcelSetCellBackgroundColourhandle = null, [WorkflowExpression] Func<string> mSExcelSetCellBackgroundColourworkbookName = null, [WorkflowExpression] Func<string> mSExcelSetCellBackgroundColourworksheetName = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MSExcelSetCellBackgroundColourResponse> __BuildMSExcelSetCellBackgroundColour(WorkflowExpression<string> mSExcelSetCellBackgroundColourcellReference, WorkflowExpression<int> mSExcelSetCellBackgroundColourcolourIndex, WorkflowExpression<string> mSExcelSetCellBackgroundColourworkflow, WorkflowExpression<int> mSExcelSetCellBackgroundColourhandle = null, WorkflowExpression<string> mSExcelSetCellBackgroundColourworkbookName = null, WorkflowExpression<string> mSExcelSetCellBackgroundColourworksheetName = null)
        {
            WorkflowExpression.Validate(mSExcelSetCellBackgroundColourcellReference, nameof(mSExcelSetCellBackgroundColourcellReference), required: true);
            WorkflowExpression.Validate(mSExcelSetCellBackgroundColourcolourIndex, nameof(mSExcelSetCellBackgroundColourcolourIndex), required: true);
            WorkflowExpression.Validate(mSExcelSetCellBackgroundColourworkflow, nameof(mSExcelSetCellBackgroundColourworkflow), required: true);
            WorkflowExpression.Validate(mSExcelSetCellBackgroundColourhandle, nameof(mSExcelSetCellBackgroundColourhandle), required: false);
            WorkflowExpression.Validate(mSExcelSetCellBackgroundColourworkbookName, nameof(mSExcelSetCellBackgroundColourworkbookName), required: false);
            WorkflowExpression.Validate(mSExcelSetCellBackgroundColourworksheetName, nameof(mSExcelSetCellBackgroundColourworksheetName), required: false);
            return new DeferredBodyAction<MSExcelSetCellBackgroundColourResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSExcelGetCellBackgroundColour))]
        public IBodyWorkflowAction<MSExcelGetCellBackgroundColourResponse> MSExcelGetCellBackgroundColour([WorkflowExpression] Func<string> mSExcelGetCellBackgroundColourcellReference, [WorkflowExpression] Func<string> mSExcelGetCellBackgroundColourworkflow, [WorkflowExpression] Func<int> mSExcelGetCellBackgroundColourhandle = null, [WorkflowExpression] Func<string> mSExcelGetCellBackgroundColourworkbookName = null, [WorkflowExpression] Func<string> mSExcelGetCellBackgroundColourworksheetName = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MSExcelGetCellBackgroundColourResponse> __BuildMSExcelGetCellBackgroundColour(WorkflowExpression<string> mSExcelGetCellBackgroundColourcellReference, WorkflowExpression<string> mSExcelGetCellBackgroundColourworkflow, WorkflowExpression<int> mSExcelGetCellBackgroundColourhandle = null, WorkflowExpression<string> mSExcelGetCellBackgroundColourworkbookName = null, WorkflowExpression<string> mSExcelGetCellBackgroundColourworksheetName = null)
        {
            WorkflowExpression.Validate(mSExcelGetCellBackgroundColourcellReference, nameof(mSExcelGetCellBackgroundColourcellReference), required: true);
            WorkflowExpression.Validate(mSExcelGetCellBackgroundColourworkflow, nameof(mSExcelGetCellBackgroundColourworkflow), required: true);
            WorkflowExpression.Validate(mSExcelGetCellBackgroundColourhandle, nameof(mSExcelGetCellBackgroundColourhandle), required: false);
            WorkflowExpression.Validate(mSExcelGetCellBackgroundColourworkbookName, nameof(mSExcelGetCellBackgroundColourworkbookName), required: false);
            WorkflowExpression.Validate(mSExcelGetCellBackgroundColourworksheetName, nameof(mSExcelGetCellBackgroundColourworksheetName), required: false);
            return new DeferredBodyAction<MSExcelGetCellBackgroundColourResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSExcelGetOLEObjectValue))]
        public IBodyWorkflowAction<MSExcelGetOLEObjectValueResponse> MSExcelGetOLEObjectValue([WorkflowExpression] Func<string> mSExcelGetOLEObjectValueoLEObjectName, [WorkflowExpression] Func<string> mSExcelGetOLEObjectValueworkflow, [WorkflowExpression] Func<int> mSExcelGetOLEObjectValuehandle = null, [WorkflowExpression] Func<string> mSExcelGetOLEObjectValueworkbookName = null, [WorkflowExpression] Func<string> mSExcelGetOLEObjectValueworksheetName = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MSExcelGetOLEObjectValueResponse> __BuildMSExcelGetOLEObjectValue(WorkflowExpression<string> mSExcelGetOLEObjectValueoLEObjectName, WorkflowExpression<string> mSExcelGetOLEObjectValueworkflow, WorkflowExpression<int> mSExcelGetOLEObjectValuehandle = null, WorkflowExpression<string> mSExcelGetOLEObjectValueworkbookName = null, WorkflowExpression<string> mSExcelGetOLEObjectValueworksheetName = null)
        {
            WorkflowExpression.Validate(mSExcelGetOLEObjectValueoLEObjectName, nameof(mSExcelGetOLEObjectValueoLEObjectName), required: true);
            WorkflowExpression.Validate(mSExcelGetOLEObjectValueworkflow, nameof(mSExcelGetOLEObjectValueworkflow), required: true);
            WorkflowExpression.Validate(mSExcelGetOLEObjectValuehandle, nameof(mSExcelGetOLEObjectValuehandle), required: false);
            WorkflowExpression.Validate(mSExcelGetOLEObjectValueworkbookName, nameof(mSExcelGetOLEObjectValueworkbookName), required: false);
            WorkflowExpression.Validate(mSExcelGetOLEObjectValueworksheetName, nameof(mSExcelGetOLEObjectValueworksheetName), required: false);
            return new DeferredBodyAction<MSExcelGetOLEObjectValueResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSExcelDoesOLEObjectExist))]
        public IBodyWorkflowAction<MSExcelDoesOLEObjectExistResponse> MSExcelDoesOLEObjectExist([WorkflowExpression] Func<string> mSExcelDoesOLEObjectExistoLEObjectName, [WorkflowExpression] Func<string> mSExcelDoesOLEObjectExistworkflow, [WorkflowExpression] Func<int> mSExcelDoesOLEObjectExisthandle = null, [WorkflowExpression] Func<string> mSExcelDoesOLEObjectExistworkbookName = null, [WorkflowExpression] Func<string> mSExcelDoesOLEObjectExistworksheetName = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MSExcelDoesOLEObjectExistResponse> __BuildMSExcelDoesOLEObjectExist(WorkflowExpression<string> mSExcelDoesOLEObjectExistoLEObjectName, WorkflowExpression<string> mSExcelDoesOLEObjectExistworkflow, WorkflowExpression<int> mSExcelDoesOLEObjectExisthandle = null, WorkflowExpression<string> mSExcelDoesOLEObjectExistworkbookName = null, WorkflowExpression<string> mSExcelDoesOLEObjectExistworksheetName = null)
        {
            WorkflowExpression.Validate(mSExcelDoesOLEObjectExistoLEObjectName, nameof(mSExcelDoesOLEObjectExistoLEObjectName), required: true);
            WorkflowExpression.Validate(mSExcelDoesOLEObjectExistworkflow, nameof(mSExcelDoesOLEObjectExistworkflow), required: true);
            WorkflowExpression.Validate(mSExcelDoesOLEObjectExisthandle, nameof(mSExcelDoesOLEObjectExisthandle), required: false);
            WorkflowExpression.Validate(mSExcelDoesOLEObjectExistworkbookName, nameof(mSExcelDoesOLEObjectExistworkbookName), required: false);
            WorkflowExpression.Validate(mSExcelDoesOLEObjectExistworksheetName, nameof(mSExcelDoesOLEObjectExistworksheetName), required: false);
            return new DeferredBodyAction<MSExcelDoesOLEObjectExistResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSExcelPressOLEObject))]
        public IBodyWorkflowAction<MSExcelPressOLEObjectResponse> MSExcelPressOLEObject([WorkflowExpression] Func<string> mSExcelPressOLEObjectoLEObjectName, [WorkflowExpression] Func<string> mSExcelPressOLEObjectworkflow, [WorkflowExpression] Func<int> mSExcelPressOLEObjecthandle = null, [WorkflowExpression] Func<string> mSExcelPressOLEObjectworkbookName = null, [WorkflowExpression] Func<string> mSExcelPressOLEObjectworksheetName = null, [WorkflowExpression] Func<bool> mSExcelPressOLEObjectrunInBackground = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MSExcelPressOLEObjectResponse> __BuildMSExcelPressOLEObject(WorkflowExpression<string> mSExcelPressOLEObjectoLEObjectName, WorkflowExpression<string> mSExcelPressOLEObjectworkflow, WorkflowExpression<int> mSExcelPressOLEObjecthandle = null, WorkflowExpression<string> mSExcelPressOLEObjectworkbookName = null, WorkflowExpression<string> mSExcelPressOLEObjectworksheetName = null, WorkflowExpression<bool> mSExcelPressOLEObjectrunInBackground = null)
        {
            WorkflowExpression.Validate(mSExcelPressOLEObjectoLEObjectName, nameof(mSExcelPressOLEObjectoLEObjectName), required: true);
            WorkflowExpression.Validate(mSExcelPressOLEObjectworkflow, nameof(mSExcelPressOLEObjectworkflow), required: true);
            WorkflowExpression.Validate(mSExcelPressOLEObjecthandle, nameof(mSExcelPressOLEObjecthandle), required: false);
            WorkflowExpression.Validate(mSExcelPressOLEObjectworkbookName, nameof(mSExcelPressOLEObjectworkbookName), required: false);
            WorkflowExpression.Validate(mSExcelPressOLEObjectworksheetName, nameof(mSExcelPressOLEObjectworksheetName), required: false);
            WorkflowExpression.Validate(mSExcelPressOLEObjectrunInBackground, nameof(mSExcelPressOLEObjectrunInBackground), required: false);
            return new DeferredBodyAction<MSExcelPressOLEObjectResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSExcelSetWorksheetSensitivityLabel))]
        public IBodyWorkflowAction<MSExcelSetWorksheetSensitivityLabelResponse> MSExcelSetWorksheetSensitivityLabel([WorkflowExpression] Func<mSExcelSetWorksheetSensitivityLabelassignmentMethodInput> mSExcelSetWorksheetSensitivityLabelassignmentMethod, [WorkflowExpression] Func<string> mSExcelSetWorksheetSensitivityLabellabelId, [WorkflowExpression] Func<string> mSExcelSetWorksheetSensitivityLabelworkflow, [WorkflowExpression] Func<int> mSExcelSetWorksheetSensitivityLabelhandle = null, [WorkflowExpression] Func<string> mSExcelSetWorksheetSensitivityLabelworkbookName = null, [WorkflowExpression] Func<string> mSExcelSetWorksheetSensitivityLabellabelName = null, [WorkflowExpression] Func<string> mSExcelSetWorksheetSensitivityLabelsiteId = null, [WorkflowExpression] Func<string> mSExcelSetWorksheetSensitivityLabeljustification = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MSExcelSetWorksheetSensitivityLabelResponse> __BuildMSExcelSetWorksheetSensitivityLabel(WorkflowExpression<mSExcelSetWorksheetSensitivityLabelassignmentMethodInput> mSExcelSetWorksheetSensitivityLabelassignmentMethod, WorkflowExpression<string> mSExcelSetWorksheetSensitivityLabellabelId, WorkflowExpression<string> mSExcelSetWorksheetSensitivityLabelworkflow, WorkflowExpression<int> mSExcelSetWorksheetSensitivityLabelhandle = null, WorkflowExpression<string> mSExcelSetWorksheetSensitivityLabelworkbookName = null, WorkflowExpression<string> mSExcelSetWorksheetSensitivityLabellabelName = null, WorkflowExpression<string> mSExcelSetWorksheetSensitivityLabelsiteId = null, WorkflowExpression<string> mSExcelSetWorksheetSensitivityLabeljustification = null)
        {
            WorkflowExpression.Validate(mSExcelSetWorksheetSensitivityLabelassignmentMethod, nameof(mSExcelSetWorksheetSensitivityLabelassignmentMethod), required: true);
            WorkflowExpression.Validate(mSExcelSetWorksheetSensitivityLabellabelId, nameof(mSExcelSetWorksheetSensitivityLabellabelId), required: true);
            WorkflowExpression.Validate(mSExcelSetWorksheetSensitivityLabelworkflow, nameof(mSExcelSetWorksheetSensitivityLabelworkflow), required: true);
            WorkflowExpression.Validate(mSExcelSetWorksheetSensitivityLabelhandle, nameof(mSExcelSetWorksheetSensitivityLabelhandle), required: false);
            WorkflowExpression.Validate(mSExcelSetWorksheetSensitivityLabelworkbookName, nameof(mSExcelSetWorksheetSensitivityLabelworkbookName), required: false);
            WorkflowExpression.Validate(mSExcelSetWorksheetSensitivityLabellabelName, nameof(mSExcelSetWorksheetSensitivityLabellabelName), required: false);
            WorkflowExpression.Validate(mSExcelSetWorksheetSensitivityLabelsiteId, nameof(mSExcelSetWorksheetSensitivityLabelsiteId), required: false);
            WorkflowExpression.Validate(mSExcelSetWorksheetSensitivityLabeljustification, nameof(mSExcelSetWorksheetSensitivityLabeljustification), required: false);
            return new DeferredBodyAction<MSExcelSetWorksheetSensitivityLabelResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSExcelGetWorksheetSensitivityLabel))]
        public IBodyWorkflowAction<MSExcelGetWorksheetSensitivityLabelResponse> MSExcelGetWorksheetSensitivityLabel([WorkflowExpression] Func<string> mSExcelGetWorksheetSensitivityLabelworkflow, [WorkflowExpression] Func<int> mSExcelGetWorksheetSensitivityLabelhandle = null, [WorkflowExpression] Func<string> mSExcelGetWorksheetSensitivityLabelworkbookName = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MSExcelGetWorksheetSensitivityLabelResponse> __BuildMSExcelGetWorksheetSensitivityLabel(WorkflowExpression<string> mSExcelGetWorksheetSensitivityLabelworkflow, WorkflowExpression<int> mSExcelGetWorksheetSensitivityLabelhandle = null, WorkflowExpression<string> mSExcelGetWorksheetSensitivityLabelworkbookName = null)
        {
            WorkflowExpression.Validate(mSExcelGetWorksheetSensitivityLabelworkflow, nameof(mSExcelGetWorksheetSensitivityLabelworkflow), required: true);
            WorkflowExpression.Validate(mSExcelGetWorksheetSensitivityLabelhandle, nameof(mSExcelGetWorksheetSensitivityLabelhandle), required: false);
            WorkflowExpression.Validate(mSExcelGetWorksheetSensitivityLabelworkbookName, nameof(mSExcelGetWorksheetSensitivityLabelworkbookName), required: false);
            return new DeferredBodyAction<MSExcelGetWorksheetSensitivityLabelResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSExcelWriteArray))]
        public IBodyWorkflowAction<MSExcelWriteArrayResponse> MSExcelWriteArray([WorkflowExpression] Func<string> mSExcelWriteArraycellReference, [WorkflowExpression] Func<string> mSExcelWriteArrayarrayToWriteJSON, [WorkflowExpression] Func<mSExcelWriteArraydirectionInput> mSExcelWriteArraydirection, [WorkflowExpression] Func<string> mSExcelWriteArrayworkflow, [WorkflowExpression] Func<int> mSExcelWriteArrayhandle = null, [WorkflowExpression] Func<string> mSExcelWriteArrayworkbookName = null, [WorkflowExpression] Func<string> mSExcelWriteArrayworksheetName = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MSExcelWriteArrayResponse> __BuildMSExcelWriteArray(WorkflowExpression<string> mSExcelWriteArraycellReference, WorkflowExpression<string> mSExcelWriteArrayarrayToWriteJSON, WorkflowExpression<mSExcelWriteArraydirectionInput> mSExcelWriteArraydirection, WorkflowExpression<string> mSExcelWriteArrayworkflow, WorkflowExpression<int> mSExcelWriteArrayhandle = null, WorkflowExpression<string> mSExcelWriteArrayworkbookName = null, WorkflowExpression<string> mSExcelWriteArrayworksheetName = null)
        {
            WorkflowExpression.Validate(mSExcelWriteArraycellReference, nameof(mSExcelWriteArraycellReference), required: true);
            WorkflowExpression.Validate(mSExcelWriteArrayarrayToWriteJSON, nameof(mSExcelWriteArrayarrayToWriteJSON), required: true);
            WorkflowExpression.Validate(mSExcelWriteArraydirection, nameof(mSExcelWriteArraydirection), required: true);
            WorkflowExpression.Validate(mSExcelWriteArrayworkflow, nameof(mSExcelWriteArrayworkflow), required: true);
            WorkflowExpression.Validate(mSExcelWriteArrayhandle, nameof(mSExcelWriteArrayhandle), required: false);
            WorkflowExpression.Validate(mSExcelWriteArrayworkbookName, nameof(mSExcelWriteArrayworkbookName), required: false);
            WorkflowExpression.Validate(mSExcelWriteArrayworksheetName, nameof(mSExcelWriteArrayworksheetName), required: false);
            return new DeferredBodyAction<MSExcelWriteArrayResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSOutlookCreateInstance))]
        public IBodyWorkflowAction<MSOutlookCreateInstanceResponse> MSOutlookCreateInstance([WorkflowExpression] Func<string> mSOutlookCreateInstanceworkflow, [WorkflowExpression] Func<string> mSOutlookCreateInstanceprofileName = null, [WorkflowExpression] Func<bool> mSOutlookCreateInstanceshowOutlook = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MSOutlookCreateInstanceResponse> __BuildMSOutlookCreateInstance(WorkflowExpression<string> mSOutlookCreateInstanceworkflow, WorkflowExpression<string> mSOutlookCreateInstanceprofileName = null, WorkflowExpression<bool> mSOutlookCreateInstanceshowOutlook = null)
        {
            WorkflowExpression.Validate(mSOutlookCreateInstanceworkflow, nameof(mSOutlookCreateInstanceworkflow), required: true);
            WorkflowExpression.Validate(mSOutlookCreateInstanceprofileName, nameof(mSOutlookCreateInstanceprofileName), required: false);
            WorkflowExpression.Validate(mSOutlookCreateInstanceshowOutlook, nameof(mSOutlookCreateInstanceshowOutlook), required: false);
            return new DeferredBodyAction<MSOutlookCreateInstanceResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSOutlookCloseInstance))]
        public IWorkflowAction MSOutlookCloseInstance([WorkflowExpression] Func<string> mSOutlookCloseInstanceworkflow, [WorkflowExpression] Func<int> mSOutlookCloseInstancesecondsToWaitForProcessToClose = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMSOutlookCloseInstance(WorkflowExpression<string> mSOutlookCloseInstanceworkflow, WorkflowExpression<int> mSOutlookCloseInstancesecondsToWaitForProcessToClose = null)
        {
            WorkflowExpression.Validate(mSOutlookCloseInstanceworkflow, nameof(mSOutlookCloseInstanceworkflow), required: true);
            WorkflowExpression.Validate(mSOutlookCloseInstancesecondsToWaitForProcessToClose, nameof(mSOutlookCloseInstancesecondsToWaitForProcessToClose), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSOutlookCloseInstanceUsingWindow))]
        public IWorkflowAction MSOutlookCloseInstanceUsingWindow([WorkflowExpression] Func<string> mSOutlookCloseInstanceUsingWindowworkflow, [WorkflowExpression] Func<bool> mSOutlookCloseInstanceUsingWindowuseNativeWindow = null, [WorkflowExpression] Func<bool> mSOutlookCloseInstanceUsingWindowuseUIA = null, [WorkflowExpression] Func<int> mSOutlookCloseInstanceUsingWindowsecondsToWaitForProcessToClose = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMSOutlookCloseInstanceUsingWindow(WorkflowExpression<string> mSOutlookCloseInstanceUsingWindowworkflow, WorkflowExpression<bool> mSOutlookCloseInstanceUsingWindowuseNativeWindow = null, WorkflowExpression<bool> mSOutlookCloseInstanceUsingWindowuseUIA = null, WorkflowExpression<int> mSOutlookCloseInstanceUsingWindowsecondsToWaitForProcessToClose = null)
        {
            WorkflowExpression.Validate(mSOutlookCloseInstanceUsingWindowworkflow, nameof(mSOutlookCloseInstanceUsingWindowworkflow), required: true);
            WorkflowExpression.Validate(mSOutlookCloseInstanceUsingWindowuseNativeWindow, nameof(mSOutlookCloseInstanceUsingWindowuseNativeWindow), required: false);
            WorkflowExpression.Validate(mSOutlookCloseInstanceUsingWindowuseUIA, nameof(mSOutlookCloseInstanceUsingWindowuseUIA), required: false);
            WorkflowExpression.Validate(mSOutlookCloseInstanceUsingWindowsecondsToWaitForProcessToClose, nameof(mSOutlookCloseInstanceUsingWindowsecondsToWaitForProcessToClose), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSOutlookAttachToExistingInstance))]
        public IBodyWorkflowAction<MSOutlookAttachToExistingInstanceResponse> MSOutlookAttachToExistingInstance([WorkflowExpression] Func<string> mSOutlookAttachToExistingInstanceworkflow, [WorkflowExpression] Func<bool> mSOutlookAttachToExistingInstancetoggleWindow = null, [WorkflowExpression] Func<bool> mSOutlookAttachToExistingInstancetoggleUsesGlobalLeftMouseClickAgent = null, [WorkflowExpression] Func<double> mSOutlookAttachToExistingInstancetoggleDelay = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MSOutlookAttachToExistingInstanceResponse> __BuildMSOutlookAttachToExistingInstance(WorkflowExpression<string> mSOutlookAttachToExistingInstanceworkflow, WorkflowExpression<bool> mSOutlookAttachToExistingInstancetoggleWindow = null, WorkflowExpression<bool> mSOutlookAttachToExistingInstancetoggleUsesGlobalLeftMouseClickAgent = null, WorkflowExpression<double> mSOutlookAttachToExistingInstancetoggleDelay = null)
        {
            WorkflowExpression.Validate(mSOutlookAttachToExistingInstanceworkflow, nameof(mSOutlookAttachToExistingInstanceworkflow), required: true);
            WorkflowExpression.Validate(mSOutlookAttachToExistingInstancetoggleWindow, nameof(mSOutlookAttachToExistingInstancetoggleWindow), required: false);
            WorkflowExpression.Validate(mSOutlookAttachToExistingInstancetoggleUsesGlobalLeftMouseClickAgent, nameof(mSOutlookAttachToExistingInstancetoggleUsesGlobalLeftMouseClickAgent), required: false);
            WorkflowExpression.Validate(mSOutlookAttachToExistingInstancetoggleDelay, nameof(mSOutlookAttachToExistingInstancetoggleDelay), required: false);
            return new DeferredBodyAction<MSOutlookAttachToExistingInstanceResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSOutlookIsConnected))]
        public IBodyWorkflowAction<MSOutlookIsConnectedResponse> MSOutlookIsConnected([WorkflowExpression] Func<string> mSOutlookIsConnectedworkflow)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MSOutlookIsConnectedResponse> __BuildMSOutlookIsConnected(WorkflowExpression<string> mSOutlookIsConnectedworkflow)
        {
            WorkflowExpression.Validate(mSOutlookIsConnectedworkflow, nameof(mSOutlookIsConnectedworkflow), required: true);
            return new DeferredBodyAction<MSOutlookIsConnectedResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSOutlookShow))]
        public IWorkflowAction MSOutlookShow([WorkflowExpression] Func<string> mSOutlookShowworkflow)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMSOutlookShow(WorkflowExpression<string> mSOutlookShowworkflow)
        {
            WorkflowExpression.Validate(mSOutlookShowworkflow, nameof(mSOutlookShowworkflow), required: true);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSOutlookGetNameSpaceInformation))]
        public IBodyWorkflowAction<MSOutlookGetNameSpaceInformationResponse> MSOutlookGetNameSpaceInformation([WorkflowExpression] Func<string> mSOutlookGetNameSpaceInformationworkflow)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MSOutlookGetNameSpaceInformationResponse> __BuildMSOutlookGetNameSpaceInformation(WorkflowExpression<string> mSOutlookGetNameSpaceInformationworkflow)
        {
            WorkflowExpression.Validate(mSOutlookGetNameSpaceInformationworkflow, nameof(mSOutlookGetNameSpaceInformationworkflow), required: true);
            return new DeferredBodyAction<MSOutlookGetNameSpaceInformationResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSOutlookGetMailFolders))]
        public IBodyWorkflowAction<MSOutlookGetMailFoldersResponse> MSOutlookGetMailFolders([WorkflowExpression] Func<string> mSOutlookGetMailFoldersworkflow, [WorkflowExpression] Func<string> mSOutlookGetMailFoldersfolderPath = null, [WorkflowExpression] Func<bool> mSOutlookGetMailFolderssubFolders = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MSOutlookGetMailFoldersResponse> __BuildMSOutlookGetMailFolders(WorkflowExpression<string> mSOutlookGetMailFoldersworkflow, WorkflowExpression<string> mSOutlookGetMailFoldersfolderPath = null, WorkflowExpression<bool> mSOutlookGetMailFolderssubFolders = null)
        {
            WorkflowExpression.Validate(mSOutlookGetMailFoldersworkflow, nameof(mSOutlookGetMailFoldersworkflow), required: true);
            WorkflowExpression.Validate(mSOutlookGetMailFoldersfolderPath, nameof(mSOutlookGetMailFoldersfolderPath), required: false);
            WorkflowExpression.Validate(mSOutlookGetMailFolderssubFolders, nameof(mSOutlookGetMailFolderssubFolders), required: false);
            return new DeferredBodyAction<MSOutlookGetMailFoldersResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSOutlookMarkEmailAsRead))]
        public IWorkflowAction MSOutlookMarkEmailAsRead([WorkflowExpression] Func<string> mSOutlookMarkEmailAsReadentryID, [WorkflowExpression] Func<string> mSOutlookMarkEmailAsReadworkflow, [WorkflowExpression] Func<bool> mSOutlookMarkEmailAsReadread = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMSOutlookMarkEmailAsRead(WorkflowExpression<string> mSOutlookMarkEmailAsReadentryID, WorkflowExpression<string> mSOutlookMarkEmailAsReadworkflow, WorkflowExpression<bool> mSOutlookMarkEmailAsReadread = null)
        {
            WorkflowExpression.Validate(mSOutlookMarkEmailAsReadentryID, nameof(mSOutlookMarkEmailAsReadentryID), required: true);
            WorkflowExpression.Validate(mSOutlookMarkEmailAsReadworkflow, nameof(mSOutlookMarkEmailAsReadworkflow), required: true);
            WorkflowExpression.Validate(mSOutlookMarkEmailAsReadread, nameof(mSOutlookMarkEmailAsReadread), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSOutlookGetEmailBody))]
        public IBodyWorkflowAction<MSOutlookGetEmailBodyResponse> MSOutlookGetEmailBody([WorkflowExpression] Func<string> mSOutlookGetEmailBodyentryID, [WorkflowExpression] Func<string> mSOutlookGetEmailBodyworkflow, [WorkflowExpression] Func<bool> mSOutlookGetEmailBodyclickAllowButtonIfRequired = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MSOutlookGetEmailBodyResponse> __BuildMSOutlookGetEmailBody(WorkflowExpression<string> mSOutlookGetEmailBodyentryID, WorkflowExpression<string> mSOutlookGetEmailBodyworkflow, WorkflowExpression<bool> mSOutlookGetEmailBodyclickAllowButtonIfRequired = null)
        {
            WorkflowExpression.Validate(mSOutlookGetEmailBodyentryID, nameof(mSOutlookGetEmailBodyentryID), required: true);
            WorkflowExpression.Validate(mSOutlookGetEmailBodyworkflow, nameof(mSOutlookGetEmailBodyworkflow), required: true);
            WorkflowExpression.Validate(mSOutlookGetEmailBodyclickAllowButtonIfRequired, nameof(mSOutlookGetEmailBodyclickAllowButtonIfRequired), required: false);
            return new DeferredBodyAction<MSOutlookGetEmailBodyResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSOutlookGetEmailAttachmentFilenames))]
        public IBodyWorkflowAction<MSOutlookGetEmailAttachmentFilenamesResponse> MSOutlookGetEmailAttachmentFilenames([WorkflowExpression] Func<string> mSOutlookGetEmailAttachmentFilenamesentryID, [WorkflowExpression] Func<string> mSOutlookGetEmailAttachmentFilenamesworkflow, [WorkflowExpression] Func<bool> mSOutlookGetEmailAttachmentFilenamesclickAllowButtonIfRequired = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MSOutlookGetEmailAttachmentFilenamesResponse> __BuildMSOutlookGetEmailAttachmentFilenames(WorkflowExpression<string> mSOutlookGetEmailAttachmentFilenamesentryID, WorkflowExpression<string> mSOutlookGetEmailAttachmentFilenamesworkflow, WorkflowExpression<bool> mSOutlookGetEmailAttachmentFilenamesclickAllowButtonIfRequired = null)
        {
            WorkflowExpression.Validate(mSOutlookGetEmailAttachmentFilenamesentryID, nameof(mSOutlookGetEmailAttachmentFilenamesentryID), required: true);
            WorkflowExpression.Validate(mSOutlookGetEmailAttachmentFilenamesworkflow, nameof(mSOutlookGetEmailAttachmentFilenamesworkflow), required: true);
            WorkflowExpression.Validate(mSOutlookGetEmailAttachmentFilenamesclickAllowButtonIfRequired, nameof(mSOutlookGetEmailAttachmentFilenamesclickAllowButtonIfRequired), required: false);
            return new DeferredBodyAction<MSOutlookGetEmailAttachmentFilenamesResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSOutlookSaveEmailAttachmentsAsFile))]
        public IBodyWorkflowAction<MSOutlookSaveEmailAttachmentsAsFileResponse> MSOutlookSaveEmailAttachmentsAsFile([WorkflowExpression] Func<string> mSOutlookSaveEmailAttachmentsAsFileentryID, [WorkflowExpression] Func<string> mSOutlookSaveEmailAttachmentsAsFileworkflow, [WorkflowExpression] Func<string> mSOutlookSaveEmailAttachmentsAsFilesaveFolderPath = null, [WorkflowExpression] Func<bool> mSOutlookSaveEmailAttachmentsAsFilecreateFolder = null, [WorkflowExpression] Func<string> mSOutlookSaveEmailAttachmentsAsFileonlySaveAttachmentsMatchingWildcard = null, [WorkflowExpression] Func<bool> mSOutlookSaveEmailAttachmentsAsFilesaveHiddenAttachments = null, [WorkflowExpression] Func<bool> mSOutlookSaveEmailAttachmentsAsFileclickAllowButtonIfRequired = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MSOutlookSaveEmailAttachmentsAsFileResponse> __BuildMSOutlookSaveEmailAttachmentsAsFile(WorkflowExpression<string> mSOutlookSaveEmailAttachmentsAsFileentryID, WorkflowExpression<string> mSOutlookSaveEmailAttachmentsAsFileworkflow, WorkflowExpression<string> mSOutlookSaveEmailAttachmentsAsFilesaveFolderPath = null, WorkflowExpression<bool> mSOutlookSaveEmailAttachmentsAsFilecreateFolder = null, WorkflowExpression<string> mSOutlookSaveEmailAttachmentsAsFileonlySaveAttachmentsMatchingWildcard = null, WorkflowExpression<bool> mSOutlookSaveEmailAttachmentsAsFilesaveHiddenAttachments = null, WorkflowExpression<bool> mSOutlookSaveEmailAttachmentsAsFileclickAllowButtonIfRequired = null)
        {
            WorkflowExpression.Validate(mSOutlookSaveEmailAttachmentsAsFileentryID, nameof(mSOutlookSaveEmailAttachmentsAsFileentryID), required: true);
            WorkflowExpression.Validate(mSOutlookSaveEmailAttachmentsAsFileworkflow, nameof(mSOutlookSaveEmailAttachmentsAsFileworkflow), required: true);
            WorkflowExpression.Validate(mSOutlookSaveEmailAttachmentsAsFilesaveFolderPath, nameof(mSOutlookSaveEmailAttachmentsAsFilesaveFolderPath), required: false);
            WorkflowExpression.Validate(mSOutlookSaveEmailAttachmentsAsFilecreateFolder, nameof(mSOutlookSaveEmailAttachmentsAsFilecreateFolder), required: false);
            WorkflowExpression.Validate(mSOutlookSaveEmailAttachmentsAsFileonlySaveAttachmentsMatchingWildcard, nameof(mSOutlookSaveEmailAttachmentsAsFileonlySaveAttachmentsMatchingWildcard), required: false);
            WorkflowExpression.Validate(mSOutlookSaveEmailAttachmentsAsFilesaveHiddenAttachments, nameof(mSOutlookSaveEmailAttachmentsAsFilesaveHiddenAttachments), required: false);
            WorkflowExpression.Validate(mSOutlookSaveEmailAttachmentsAsFileclickAllowButtonIfRequired, nameof(mSOutlookSaveEmailAttachmentsAsFileclickAllowButtonIfRequired), required: false);
            return new DeferredBodyAction<MSOutlookSaveEmailAttachmentsAsFileResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSOutlookDeleteEmail))]
        public IWorkflowAction MSOutlookDeleteEmail([WorkflowExpression] Func<string> mSOutlookDeleteEmailentryID, [WorkflowExpression] Func<string> mSOutlookDeleteEmailworkflow)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMSOutlookDeleteEmail(WorkflowExpression<string> mSOutlookDeleteEmailentryID, WorkflowExpression<string> mSOutlookDeleteEmailworkflow)
        {
            WorkflowExpression.Validate(mSOutlookDeleteEmailentryID, nameof(mSOutlookDeleteEmailentryID), required: true);
            WorkflowExpression.Validate(mSOutlookDeleteEmailworkflow, nameof(mSOutlookDeleteEmailworkflow), required: true);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSOutlookMoveEmail))]
        public IWorkflowAction MSOutlookMoveEmail([WorkflowExpression] Func<string> mSOutlookMoveEmailentryID, [WorkflowExpression] Func<string> mSOutlookMoveEmailworkflow, [WorkflowExpression] Func<string> mSOutlookMoveEmaildestinationFolder = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMSOutlookMoveEmail(WorkflowExpression<string> mSOutlookMoveEmailentryID, WorkflowExpression<string> mSOutlookMoveEmailworkflow, WorkflowExpression<string> mSOutlookMoveEmaildestinationFolder = null)
        {
            WorkflowExpression.Validate(mSOutlookMoveEmailentryID, nameof(mSOutlookMoveEmailentryID), required: true);
            WorkflowExpression.Validate(mSOutlookMoveEmailworkflow, nameof(mSOutlookMoveEmailworkflow), required: true);
            WorkflowExpression.Validate(mSOutlookMoveEmaildestinationFolder, nameof(mSOutlookMoveEmaildestinationFolder), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSOutlookSendEmail))]
        public IWorkflowAction MSOutlookSendEmail([WorkflowExpression] Func<string> mSOutlookSendEmailworkflow, [WorkflowExpression] Func<string> mSOutlookSendEmailto = null, [WorkflowExpression] Func<string> mSOutlookSendEmailcC = null, [WorkflowExpression] Func<string> mSOutlookSendEmailbCC = null, [WorkflowExpression] Func<string> mSOutlookSendEmailsubject = null, [WorkflowExpression] Func<mSOutlookSendEmailbodyFormatInput> mSOutlookSendEmailbodyFormat = null, [WorkflowExpression] Func<string> mSOutlookSendEmailbody = null, [WorkflowExpression] Func<string> mSOutlookSendEmailhTMLBody = null, [WorkflowExpression] Func<string> mSOutlookSendEmailrTFBody = null, [WorkflowExpression] Func<string> mSOutlookSendEmailattachmentFilenamesJSON = null, [WorkflowExpression] Func<bool> mSOutlookSendEmaildontSendIfAttachmentFilenameMissing = null, [WorkflowExpression] Func<bool> mSOutlookSendEmailclickAllowButtonIfRequired = null, [WorkflowExpression] Func<string> mSOutlookSendEmailvotingOptions = null, [WorkflowExpression] Func<string> mSOutlookSendEmailsendAsSMTPAddress = null, [WorkflowExpression] Func<bool> mSOutlookSendEmailbodyContainsStoredPassword = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMSOutlookSendEmail(WorkflowExpression<string> mSOutlookSendEmailworkflow, WorkflowExpression<string> mSOutlookSendEmailto = null, WorkflowExpression<string> mSOutlookSendEmailcC = null, WorkflowExpression<string> mSOutlookSendEmailbCC = null, WorkflowExpression<string> mSOutlookSendEmailsubject = null, WorkflowExpression<mSOutlookSendEmailbodyFormatInput> mSOutlookSendEmailbodyFormat = null, WorkflowExpression<string> mSOutlookSendEmailbody = null, WorkflowExpression<string> mSOutlookSendEmailhTMLBody = null, WorkflowExpression<string> mSOutlookSendEmailrTFBody = null, WorkflowExpression<string> mSOutlookSendEmailattachmentFilenamesJSON = null, WorkflowExpression<bool> mSOutlookSendEmaildontSendIfAttachmentFilenameMissing = null, WorkflowExpression<bool> mSOutlookSendEmailclickAllowButtonIfRequired = null, WorkflowExpression<string> mSOutlookSendEmailvotingOptions = null, WorkflowExpression<string> mSOutlookSendEmailsendAsSMTPAddress = null, WorkflowExpression<bool> mSOutlookSendEmailbodyContainsStoredPassword = null)
        {
            WorkflowExpression.Validate(mSOutlookSendEmailworkflow, nameof(mSOutlookSendEmailworkflow), required: true);
            WorkflowExpression.Validate(mSOutlookSendEmailto, nameof(mSOutlookSendEmailto), required: false);
            WorkflowExpression.Validate(mSOutlookSendEmailcC, nameof(mSOutlookSendEmailcC), required: false);
            WorkflowExpression.Validate(mSOutlookSendEmailbCC, nameof(mSOutlookSendEmailbCC), required: false);
            WorkflowExpression.Validate(mSOutlookSendEmailsubject, nameof(mSOutlookSendEmailsubject), required: false);
            WorkflowExpression.Validate(mSOutlookSendEmailbodyFormat, nameof(mSOutlookSendEmailbodyFormat), required: false);
            WorkflowExpression.Validate(mSOutlookSendEmailbody, nameof(mSOutlookSendEmailbody), required: false);
            WorkflowExpression.Validate(mSOutlookSendEmailhTMLBody, nameof(mSOutlookSendEmailhTMLBody), required: false);
            WorkflowExpression.Validate(mSOutlookSendEmailrTFBody, nameof(mSOutlookSendEmailrTFBody), required: false);
            WorkflowExpression.Validate(mSOutlookSendEmailattachmentFilenamesJSON, nameof(mSOutlookSendEmailattachmentFilenamesJSON), required: false);
            WorkflowExpression.Validate(mSOutlookSendEmaildontSendIfAttachmentFilenameMissing, nameof(mSOutlookSendEmaildontSendIfAttachmentFilenameMissing), required: false);
            WorkflowExpression.Validate(mSOutlookSendEmailclickAllowButtonIfRequired, nameof(mSOutlookSendEmailclickAllowButtonIfRequired), required: false);
            WorkflowExpression.Validate(mSOutlookSendEmailvotingOptions, nameof(mSOutlookSendEmailvotingOptions), required: false);
            WorkflowExpression.Validate(mSOutlookSendEmailsendAsSMTPAddress, nameof(mSOutlookSendEmailsendAsSMTPAddress), required: false);
            WorkflowExpression.Validate(mSOutlookSendEmailbodyContainsStoredPassword, nameof(mSOutlookSendEmailbodyContainsStoredPassword), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSOutlookCreateMailFolder))]
        public IWorkflowAction MSOutlookCreateMailFolder([WorkflowExpression] Func<string> mSOutlookCreateMailFolderworkflow, [WorkflowExpression] Func<string> mSOutlookCreateMailFolderparentFolderPath = null, [WorkflowExpression] Func<string> mSOutlookCreateMailFoldernewFolderName = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMSOutlookCreateMailFolder(WorkflowExpression<string> mSOutlookCreateMailFolderworkflow, WorkflowExpression<string> mSOutlookCreateMailFolderparentFolderPath = null, WorkflowExpression<string> mSOutlookCreateMailFoldernewFolderName = null)
        {
            WorkflowExpression.Validate(mSOutlookCreateMailFolderworkflow, nameof(mSOutlookCreateMailFolderworkflow), required: true);
            WorkflowExpression.Validate(mSOutlookCreateMailFolderparentFolderPath, nameof(mSOutlookCreateMailFolderparentFolderPath), required: false);
            WorkflowExpression.Validate(mSOutlookCreateMailFoldernewFolderName, nameof(mSOutlookCreateMailFoldernewFolderName), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSOutlookReplyToEmail))]
        public IWorkflowAction MSOutlookReplyToEmail([WorkflowExpression] Func<string> mSOutlookReplyToEmailentryID, [WorkflowExpression] Func<string> mSOutlookReplyToEmailworkflow, [WorkflowExpression] Func<bool> mSOutlookReplyToEmailreplyToAll = null, [WorkflowExpression] Func<mSOutlookReplyToEmailbodyFormatInput> mSOutlookReplyToEmailbodyFormat = null, [WorkflowExpression] Func<string> mSOutlookReplyToEmailbody = null, [WorkflowExpression] Func<string> mSOutlookReplyToEmailhTMLBody = null, [WorkflowExpression] Func<string> mSOutlookReplyToEmailrTFBody = null, [WorkflowExpression] Func<string> mSOutlookReplyToEmailattachmentFilenamesJSON = null, [WorkflowExpression] Func<bool> mSOutlookReplyToEmaildontSendIfAttachmentFilenameMissing = null, [WorkflowExpression] Func<bool> mSOutlookReplyToEmailclickAllowButtonIfRequired = null, [WorkflowExpression] Func<string> mSOutlookReplyToEmailvotingOptions = null, [WorkflowExpression] Func<string> mSOutlookReplyToEmailsendAsSMTPAddress = null, [WorkflowExpression] Func<bool> mSOutlookReplyToEmailbodyContainsStoredPassword = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMSOutlookReplyToEmail(WorkflowExpression<string> mSOutlookReplyToEmailentryID, WorkflowExpression<string> mSOutlookReplyToEmailworkflow, WorkflowExpression<bool> mSOutlookReplyToEmailreplyToAll = null, WorkflowExpression<mSOutlookReplyToEmailbodyFormatInput> mSOutlookReplyToEmailbodyFormat = null, WorkflowExpression<string> mSOutlookReplyToEmailbody = null, WorkflowExpression<string> mSOutlookReplyToEmailhTMLBody = null, WorkflowExpression<string> mSOutlookReplyToEmailrTFBody = null, WorkflowExpression<string> mSOutlookReplyToEmailattachmentFilenamesJSON = null, WorkflowExpression<bool> mSOutlookReplyToEmaildontSendIfAttachmentFilenameMissing = null, WorkflowExpression<bool> mSOutlookReplyToEmailclickAllowButtonIfRequired = null, WorkflowExpression<string> mSOutlookReplyToEmailvotingOptions = null, WorkflowExpression<string> mSOutlookReplyToEmailsendAsSMTPAddress = null, WorkflowExpression<bool> mSOutlookReplyToEmailbodyContainsStoredPassword = null)
        {
            WorkflowExpression.Validate(mSOutlookReplyToEmailentryID, nameof(mSOutlookReplyToEmailentryID), required: true);
            WorkflowExpression.Validate(mSOutlookReplyToEmailworkflow, nameof(mSOutlookReplyToEmailworkflow), required: true);
            WorkflowExpression.Validate(mSOutlookReplyToEmailreplyToAll, nameof(mSOutlookReplyToEmailreplyToAll), required: false);
            WorkflowExpression.Validate(mSOutlookReplyToEmailbodyFormat, nameof(mSOutlookReplyToEmailbodyFormat), required: false);
            WorkflowExpression.Validate(mSOutlookReplyToEmailbody, nameof(mSOutlookReplyToEmailbody), required: false);
            WorkflowExpression.Validate(mSOutlookReplyToEmailhTMLBody, nameof(mSOutlookReplyToEmailhTMLBody), required: false);
            WorkflowExpression.Validate(mSOutlookReplyToEmailrTFBody, nameof(mSOutlookReplyToEmailrTFBody), required: false);
            WorkflowExpression.Validate(mSOutlookReplyToEmailattachmentFilenamesJSON, nameof(mSOutlookReplyToEmailattachmentFilenamesJSON), required: false);
            WorkflowExpression.Validate(mSOutlookReplyToEmaildontSendIfAttachmentFilenameMissing, nameof(mSOutlookReplyToEmaildontSendIfAttachmentFilenameMissing), required: false);
            WorkflowExpression.Validate(mSOutlookReplyToEmailclickAllowButtonIfRequired, nameof(mSOutlookReplyToEmailclickAllowButtonIfRequired), required: false);
            WorkflowExpression.Validate(mSOutlookReplyToEmailvotingOptions, nameof(mSOutlookReplyToEmailvotingOptions), required: false);
            WorkflowExpression.Validate(mSOutlookReplyToEmailsendAsSMTPAddress, nameof(mSOutlookReplyToEmailsendAsSMTPAddress), required: false);
            WorkflowExpression.Validate(mSOutlookReplyToEmailbodyContainsStoredPassword, nameof(mSOutlookReplyToEmailbodyContainsStoredPassword), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSOutlookForwardEmail))]
        public IWorkflowAction MSOutlookForwardEmail([WorkflowExpression] Func<string> mSOutlookForwardEmailentryID, [WorkflowExpression] Func<string> mSOutlookForwardEmailworkflow, [WorkflowExpression] Func<string> mSOutlookForwardEmailto = null, [WorkflowExpression] Func<string> mSOutlookForwardEmailcC = null, [WorkflowExpression] Func<string> mSOutlookForwardEmailbCC = null, [WorkflowExpression] Func<bool> mSOutlookForwardEmailoverrideSubject = null, [WorkflowExpression] Func<string> mSOutlookForwardEmailsubject = null, [WorkflowExpression] Func<bool> mSOutlookForwardEmailoverrideBody = null, [WorkflowExpression] Func<mSOutlookForwardEmailbodyFormatInput> mSOutlookForwardEmailbodyFormat = null, [WorkflowExpression] Func<string> mSOutlookForwardEmailbody = null, [WorkflowExpression] Func<string> mSOutlookForwardEmailhTMLBody = null, [WorkflowExpression] Func<string> mSOutlookForwardEmailrTFBody = null, [WorkflowExpression] Func<bool> mSOutlookForwardEmailclickAllowButtonIfRequired = null, [WorkflowExpression] Func<string> mSOutlookForwardEmailvotingOptions = null, [WorkflowExpression] Func<string> mSOutlookForwardEmailsendAsSMTPAddress = null, [WorkflowExpression] Func<bool> mSOutlookForwardEmailincludeExistingHiddenAttachments = null, [WorkflowExpression] Func<bool> mSOutlookForwardEmailincludeExistingVisibleAttachments = null, [WorkflowExpression] Func<string> mSOutlookForwardEmailattachmentFilenamesJSON = null, [WorkflowExpression] Func<bool> mSOutlookForwardEmaildontSendIfAttachmentFilenameMissing = null, [WorkflowExpression] Func<bool> mSOutlookForwardEmailbodyContainsStoredPassword = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMSOutlookForwardEmail(WorkflowExpression<string> mSOutlookForwardEmailentryID, WorkflowExpression<string> mSOutlookForwardEmailworkflow, WorkflowExpression<string> mSOutlookForwardEmailto = null, WorkflowExpression<string> mSOutlookForwardEmailcC = null, WorkflowExpression<string> mSOutlookForwardEmailbCC = null, WorkflowExpression<bool> mSOutlookForwardEmailoverrideSubject = null, WorkflowExpression<string> mSOutlookForwardEmailsubject = null, WorkflowExpression<bool> mSOutlookForwardEmailoverrideBody = null, WorkflowExpression<mSOutlookForwardEmailbodyFormatInput> mSOutlookForwardEmailbodyFormat = null, WorkflowExpression<string> mSOutlookForwardEmailbody = null, WorkflowExpression<string> mSOutlookForwardEmailhTMLBody = null, WorkflowExpression<string> mSOutlookForwardEmailrTFBody = null, WorkflowExpression<bool> mSOutlookForwardEmailclickAllowButtonIfRequired = null, WorkflowExpression<string> mSOutlookForwardEmailvotingOptions = null, WorkflowExpression<string> mSOutlookForwardEmailsendAsSMTPAddress = null, WorkflowExpression<bool> mSOutlookForwardEmailincludeExistingHiddenAttachments = null, WorkflowExpression<bool> mSOutlookForwardEmailincludeExistingVisibleAttachments = null, WorkflowExpression<string> mSOutlookForwardEmailattachmentFilenamesJSON = null, WorkflowExpression<bool> mSOutlookForwardEmaildontSendIfAttachmentFilenameMissing = null, WorkflowExpression<bool> mSOutlookForwardEmailbodyContainsStoredPassword = null)
        {
            WorkflowExpression.Validate(mSOutlookForwardEmailentryID, nameof(mSOutlookForwardEmailentryID), required: true);
            WorkflowExpression.Validate(mSOutlookForwardEmailworkflow, nameof(mSOutlookForwardEmailworkflow), required: true);
            WorkflowExpression.Validate(mSOutlookForwardEmailto, nameof(mSOutlookForwardEmailto), required: false);
            WorkflowExpression.Validate(mSOutlookForwardEmailcC, nameof(mSOutlookForwardEmailcC), required: false);
            WorkflowExpression.Validate(mSOutlookForwardEmailbCC, nameof(mSOutlookForwardEmailbCC), required: false);
            WorkflowExpression.Validate(mSOutlookForwardEmailoverrideSubject, nameof(mSOutlookForwardEmailoverrideSubject), required: false);
            WorkflowExpression.Validate(mSOutlookForwardEmailsubject, nameof(mSOutlookForwardEmailsubject), required: false);
            WorkflowExpression.Validate(mSOutlookForwardEmailoverrideBody, nameof(mSOutlookForwardEmailoverrideBody), required: false);
            WorkflowExpression.Validate(mSOutlookForwardEmailbodyFormat, nameof(mSOutlookForwardEmailbodyFormat), required: false);
            WorkflowExpression.Validate(mSOutlookForwardEmailbody, nameof(mSOutlookForwardEmailbody), required: false);
            WorkflowExpression.Validate(mSOutlookForwardEmailhTMLBody, nameof(mSOutlookForwardEmailhTMLBody), required: false);
            WorkflowExpression.Validate(mSOutlookForwardEmailrTFBody, nameof(mSOutlookForwardEmailrTFBody), required: false);
            WorkflowExpression.Validate(mSOutlookForwardEmailclickAllowButtonIfRequired, nameof(mSOutlookForwardEmailclickAllowButtonIfRequired), required: false);
            WorkflowExpression.Validate(mSOutlookForwardEmailvotingOptions, nameof(mSOutlookForwardEmailvotingOptions), required: false);
            WorkflowExpression.Validate(mSOutlookForwardEmailsendAsSMTPAddress, nameof(mSOutlookForwardEmailsendAsSMTPAddress), required: false);
            WorkflowExpression.Validate(mSOutlookForwardEmailincludeExistingHiddenAttachments, nameof(mSOutlookForwardEmailincludeExistingHiddenAttachments), required: false);
            WorkflowExpression.Validate(mSOutlookForwardEmailincludeExistingVisibleAttachments, nameof(mSOutlookForwardEmailincludeExistingVisibleAttachments), required: false);
            WorkflowExpression.Validate(mSOutlookForwardEmailattachmentFilenamesJSON, nameof(mSOutlookForwardEmailattachmentFilenamesJSON), required: false);
            WorkflowExpression.Validate(mSOutlookForwardEmaildontSendIfAttachmentFilenameMissing, nameof(mSOutlookForwardEmaildontSendIfAttachmentFilenameMissing), required: false);
            WorkflowExpression.Validate(mSOutlookForwardEmailbodyContainsStoredPassword, nameof(mSOutlookForwardEmailbodyContainsStoredPassword), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSOutlookGetMAPIProfiles))]
        public IBodyWorkflowAction<MSOutlookGetMAPIProfilesResponse> MSOutlookGetMAPIProfiles([WorkflowExpression] Func<string> mSOutlookGetMAPIProfilesworkflow)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MSOutlookGetMAPIProfilesResponse> __BuildMSOutlookGetMAPIProfiles(WorkflowExpression<string> mSOutlookGetMAPIProfilesworkflow)
        {
            WorkflowExpression.Validate(mSOutlookGetMAPIProfilesworkflow, nameof(mSOutlookGetMAPIProfilesworkflow), required: true);
            return new DeferredBodyAction<MSOutlookGetMAPIProfilesResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSOutlookGetOutlookProcessId))]
        public IBodyWorkflowAction<MSOutlookGetOutlookProcessIdResponse> MSOutlookGetOutlookProcessId([WorkflowExpression] Func<string> mSOutlookGetOutlookProcessIdworkflow)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MSOutlookGetOutlookProcessIdResponse> __BuildMSOutlookGetOutlookProcessId(WorkflowExpression<string> mSOutlookGetOutlookProcessIdworkflow)
        {
            WorkflowExpression.Validate(mSOutlookGetOutlookProcessIdworkflow, nameof(mSOutlookGetOutlookProcessIdworkflow), required: true);
            return new DeferredBodyAction<MSOutlookGetOutlookProcessIdResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSOutlookBackgroundMonitorForAllowPopup))]
        public IWorkflowAction MSOutlookBackgroundMonitorForAllowPopup([WorkflowExpression] Func<string> mSOutlookBackgroundMonitorForAllowPopupworkflow, [WorkflowExpression] Func<int> mSOutlookBackgroundMonitorForAllowPopupsecondsToWaitForDialog = null, [WorkflowExpression] Func<int> mSOutlookBackgroundMonitorForAllowPopupsecondsToWaitForAllowButton = null, [WorkflowExpression] Func<int> mSOutlookBackgroundMonitorForAllowPopupsecondsToWaitForAllowButtonToBeEnabled = null, [WorkflowExpression] Func<string> mSOutlookBackgroundMonitorForAllowPopupoutlookAllowButtonName = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMSOutlookBackgroundMonitorForAllowPopup(WorkflowExpression<string> mSOutlookBackgroundMonitorForAllowPopupworkflow, WorkflowExpression<int> mSOutlookBackgroundMonitorForAllowPopupsecondsToWaitForDialog = null, WorkflowExpression<int> mSOutlookBackgroundMonitorForAllowPopupsecondsToWaitForAllowButton = null, WorkflowExpression<int> mSOutlookBackgroundMonitorForAllowPopupsecondsToWaitForAllowButtonToBeEnabled = null, WorkflowExpression<string> mSOutlookBackgroundMonitorForAllowPopupoutlookAllowButtonName = null)
        {
            WorkflowExpression.Validate(mSOutlookBackgroundMonitorForAllowPopupworkflow, nameof(mSOutlookBackgroundMonitorForAllowPopupworkflow), required: true);
            WorkflowExpression.Validate(mSOutlookBackgroundMonitorForAllowPopupsecondsToWaitForDialog, nameof(mSOutlookBackgroundMonitorForAllowPopupsecondsToWaitForDialog), required: false);
            WorkflowExpression.Validate(mSOutlookBackgroundMonitorForAllowPopupsecondsToWaitForAllowButton, nameof(mSOutlookBackgroundMonitorForAllowPopupsecondsToWaitForAllowButton), required: false);
            WorkflowExpression.Validate(mSOutlookBackgroundMonitorForAllowPopupsecondsToWaitForAllowButtonToBeEnabled, nameof(mSOutlookBackgroundMonitorForAllowPopupsecondsToWaitForAllowButtonToBeEnabled), required: false);
            WorkflowExpression.Validate(mSOutlookBackgroundMonitorForAllowPopupoutlookAllowButtonName, nameof(mSOutlookBackgroundMonitorForAllowPopupoutlookAllowButtonName), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSOutlookSetAllowPopupDetails))]
        public IWorkflowAction MSOutlookSetAllowPopupDetails([WorkflowExpression] Func<string> mSOutlookSetAllowPopupDetailsworkflow, [WorkflowExpression] Func<string> mSOutlookSetAllowPopupDetailsoutlookAllowButtonName = null, [WorkflowExpression] Func<string> mSOutlookSetAllowPopupDetailsoutlookAllowButtonAutomationId = null, [WorkflowExpression] Func<string> mSOutlookSetAllowPopupDetailsoutlookAllowCheckboxAutomationId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMSOutlookSetAllowPopupDetails(WorkflowExpression<string> mSOutlookSetAllowPopupDetailsworkflow, WorkflowExpression<string> mSOutlookSetAllowPopupDetailsoutlookAllowButtonName = null, WorkflowExpression<string> mSOutlookSetAllowPopupDetailsoutlookAllowButtonAutomationId = null, WorkflowExpression<string> mSOutlookSetAllowPopupDetailsoutlookAllowCheckboxAutomationId = null)
        {
            WorkflowExpression.Validate(mSOutlookSetAllowPopupDetailsworkflow, nameof(mSOutlookSetAllowPopupDetailsworkflow), required: true);
            WorkflowExpression.Validate(mSOutlookSetAllowPopupDetailsoutlookAllowButtonName, nameof(mSOutlookSetAllowPopupDetailsoutlookAllowButtonName), required: false);
            WorkflowExpression.Validate(mSOutlookSetAllowPopupDetailsoutlookAllowButtonAutomationId, nameof(mSOutlookSetAllowPopupDetailsoutlookAllowButtonAutomationId), required: false);
            WorkflowExpression.Validate(mSOutlookSetAllowPopupDetailsoutlookAllowCheckboxAutomationId, nameof(mSOutlookSetAllowPopupDetailsoutlookAllowCheckboxAutomationId), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSOutlookExecuteCommandBarObject))]
        public IBodyWorkflowAction<MSOutlookExecuteCommandBarObjectResponse> MSOutlookExecuteCommandBarObject([WorkflowExpression] Func<string> mSOutlookExecuteCommandBarObjectobjectId, [WorkflowExpression] Func<string> mSOutlookExecuteCommandBarObjectworkflow, [WorkflowExpression] Func<bool> mSOutlookExecuteCommandBarObjectrunInBackground = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MSOutlookExecuteCommandBarObjectResponse> __BuildMSOutlookExecuteCommandBarObject(WorkflowExpression<string> mSOutlookExecuteCommandBarObjectobjectId, WorkflowExpression<string> mSOutlookExecuteCommandBarObjectworkflow, WorkflowExpression<bool> mSOutlookExecuteCommandBarObjectrunInBackground = null)
        {
            WorkflowExpression.Validate(mSOutlookExecuteCommandBarObjectobjectId, nameof(mSOutlookExecuteCommandBarObjectobjectId), required: true);
            WorkflowExpression.Validate(mSOutlookExecuteCommandBarObjectworkflow, nameof(mSOutlookExecuteCommandBarObjectworkflow), required: true);
            WorkflowExpression.Validate(mSOutlookExecuteCommandBarObjectrunInBackground, nameof(mSOutlookExecuteCommandBarObjectrunInBackground), required: false);
            return new DeferredBodyAction<MSOutlookExecuteCommandBarObjectResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSOutlookGetEmails))]
        public IBodyWorkflowAction<MSOutlookGetEmailsResponse> MSOutlookGetEmails([WorkflowExpression] Func<string> mSOutlookGetEmailsworkflow, [WorkflowExpression] Func<string> mSOutlookGetEmailsfolderPath = null, [WorkflowExpression] Func<bool> mSOutlookGetEmailssearchRead = null, [WorkflowExpression] Func<bool> mSOutlookGetEmailssearchUnread = null, [WorkflowExpression] Func<string> mSOutlookGetEmailssearchSubject = null, [WorkflowExpression] Func<string> mSOutlookGetEmailssearchFromSMTP = null, [WorkflowExpression] Func<string> mSOutlookGetEmailssearchFromName = null, [WorkflowExpression] Func<string> mSOutlookGetEmailssearchQuery = null, [WorkflowExpression] Func<int> mSOutlookGetEmailssearchMaxAgeInDays = null, [WorkflowExpression] Func<string> mSOutlookGetEmailssearchStartDateTimeAsString = null, [WorkflowExpression] Func<string> mSOutlookGetEmailssearchEndDateTimeAsString = null, [WorkflowExpression] Func<int> mSOutlookGetEmailsmaxResultsToReturn = null, [WorkflowExpression] Func<bool> mSOutlookGetEmailsclickAllowButtonIfRequired = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MSOutlookGetEmailsResponse> __BuildMSOutlookGetEmails(WorkflowExpression<string> mSOutlookGetEmailsworkflow, WorkflowExpression<string> mSOutlookGetEmailsfolderPath = null, WorkflowExpression<bool> mSOutlookGetEmailssearchRead = null, WorkflowExpression<bool> mSOutlookGetEmailssearchUnread = null, WorkflowExpression<string> mSOutlookGetEmailssearchSubject = null, WorkflowExpression<string> mSOutlookGetEmailssearchFromSMTP = null, WorkflowExpression<string> mSOutlookGetEmailssearchFromName = null, WorkflowExpression<string> mSOutlookGetEmailssearchQuery = null, WorkflowExpression<int> mSOutlookGetEmailssearchMaxAgeInDays = null, WorkflowExpression<string> mSOutlookGetEmailssearchStartDateTimeAsString = null, WorkflowExpression<string> mSOutlookGetEmailssearchEndDateTimeAsString = null, WorkflowExpression<int> mSOutlookGetEmailsmaxResultsToReturn = null, WorkflowExpression<bool> mSOutlookGetEmailsclickAllowButtonIfRequired = null)
        {
            WorkflowExpression.Validate(mSOutlookGetEmailsworkflow, nameof(mSOutlookGetEmailsworkflow), required: true);
            WorkflowExpression.Validate(mSOutlookGetEmailsfolderPath, nameof(mSOutlookGetEmailsfolderPath), required: false);
            WorkflowExpression.Validate(mSOutlookGetEmailssearchRead, nameof(mSOutlookGetEmailssearchRead), required: false);
            WorkflowExpression.Validate(mSOutlookGetEmailssearchUnread, nameof(mSOutlookGetEmailssearchUnread), required: false);
            WorkflowExpression.Validate(mSOutlookGetEmailssearchSubject, nameof(mSOutlookGetEmailssearchSubject), required: false);
            WorkflowExpression.Validate(mSOutlookGetEmailssearchFromSMTP, nameof(mSOutlookGetEmailssearchFromSMTP), required: false);
            WorkflowExpression.Validate(mSOutlookGetEmailssearchFromName, nameof(mSOutlookGetEmailssearchFromName), required: false);
            WorkflowExpression.Validate(mSOutlookGetEmailssearchQuery, nameof(mSOutlookGetEmailssearchQuery), required: false);
            WorkflowExpression.Validate(mSOutlookGetEmailssearchMaxAgeInDays, nameof(mSOutlookGetEmailssearchMaxAgeInDays), required: false);
            WorkflowExpression.Validate(mSOutlookGetEmailssearchStartDateTimeAsString, nameof(mSOutlookGetEmailssearchStartDateTimeAsString), required: false);
            WorkflowExpression.Validate(mSOutlookGetEmailssearchEndDateTimeAsString, nameof(mSOutlookGetEmailssearchEndDateTimeAsString), required: false);
            WorkflowExpression.Validate(mSOutlookGetEmailsmaxResultsToReturn, nameof(mSOutlookGetEmailsmaxResultsToReturn), required: false);
            WorkflowExpression.Validate(mSOutlookGetEmailsclickAllowButtonIfRequired, nameof(mSOutlookGetEmailsclickAllowButtonIfRequired), required: false);
            return new DeferredBodyAction<MSOutlookGetEmailsResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSOutlookGetFirstEmail))]
        public IBodyWorkflowAction<MSOutlookGetFirstEmailResponse> MSOutlookGetFirstEmail([WorkflowExpression] Func<string> mSOutlookGetFirstEmailworkflow, [WorkflowExpression] Func<string> mSOutlookGetFirstEmailfolderPath = null, [WorkflowExpression] Func<bool> mSOutlookGetFirstEmailsearchRead = null, [WorkflowExpression] Func<bool> mSOutlookGetFirstEmailsearchUnread = null, [WorkflowExpression] Func<string> mSOutlookGetFirstEmailsearchSubject = null, [WorkflowExpression] Func<string> mSOutlookGetFirstEmailsearchFromSMTP = null, [WorkflowExpression] Func<string> mSOutlookGetFirstEmailsearchFromName = null, [WorkflowExpression] Func<string> mSOutlookGetFirstEmailsearchQuery = null, [WorkflowExpression] Func<int> mSOutlookGetFirstEmailsearchMaxAgeInDays = null, [WorkflowExpression] Func<string> mSOutlookGetFirstEmailsearchStartDateTimeAsString = null, [WorkflowExpression] Func<string> mSOutlookGetFirstEmailsearchEndDateTimeAsString = null, [WorkflowExpression] Func<bool> mSOutlookGetFirstEmailclickAllowButtonIfRequired = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MSOutlookGetFirstEmailResponse> __BuildMSOutlookGetFirstEmail(WorkflowExpression<string> mSOutlookGetFirstEmailworkflow, WorkflowExpression<string> mSOutlookGetFirstEmailfolderPath = null, WorkflowExpression<bool> mSOutlookGetFirstEmailsearchRead = null, WorkflowExpression<bool> mSOutlookGetFirstEmailsearchUnread = null, WorkflowExpression<string> mSOutlookGetFirstEmailsearchSubject = null, WorkflowExpression<string> mSOutlookGetFirstEmailsearchFromSMTP = null, WorkflowExpression<string> mSOutlookGetFirstEmailsearchFromName = null, WorkflowExpression<string> mSOutlookGetFirstEmailsearchQuery = null, WorkflowExpression<int> mSOutlookGetFirstEmailsearchMaxAgeInDays = null, WorkflowExpression<string> mSOutlookGetFirstEmailsearchStartDateTimeAsString = null, WorkflowExpression<string> mSOutlookGetFirstEmailsearchEndDateTimeAsString = null, WorkflowExpression<bool> mSOutlookGetFirstEmailclickAllowButtonIfRequired = null)
        {
            WorkflowExpression.Validate(mSOutlookGetFirstEmailworkflow, nameof(mSOutlookGetFirstEmailworkflow), required: true);
            WorkflowExpression.Validate(mSOutlookGetFirstEmailfolderPath, nameof(mSOutlookGetFirstEmailfolderPath), required: false);
            WorkflowExpression.Validate(mSOutlookGetFirstEmailsearchRead, nameof(mSOutlookGetFirstEmailsearchRead), required: false);
            WorkflowExpression.Validate(mSOutlookGetFirstEmailsearchUnread, nameof(mSOutlookGetFirstEmailsearchUnread), required: false);
            WorkflowExpression.Validate(mSOutlookGetFirstEmailsearchSubject, nameof(mSOutlookGetFirstEmailsearchSubject), required: false);
            WorkflowExpression.Validate(mSOutlookGetFirstEmailsearchFromSMTP, nameof(mSOutlookGetFirstEmailsearchFromSMTP), required: false);
            WorkflowExpression.Validate(mSOutlookGetFirstEmailsearchFromName, nameof(mSOutlookGetFirstEmailsearchFromName), required: false);
            WorkflowExpression.Validate(mSOutlookGetFirstEmailsearchQuery, nameof(mSOutlookGetFirstEmailsearchQuery), required: false);
            WorkflowExpression.Validate(mSOutlookGetFirstEmailsearchMaxAgeInDays, nameof(mSOutlookGetFirstEmailsearchMaxAgeInDays), required: false);
            WorkflowExpression.Validate(mSOutlookGetFirstEmailsearchStartDateTimeAsString, nameof(mSOutlookGetFirstEmailsearchStartDateTimeAsString), required: false);
            WorkflowExpression.Validate(mSOutlookGetFirstEmailsearchEndDateTimeAsString, nameof(mSOutlookGetFirstEmailsearchEndDateTimeAsString), required: false);
            WorkflowExpression.Validate(mSOutlookGetFirstEmailclickAllowButtonIfRequired, nameof(mSOutlookGetFirstEmailclickAllowButtonIfRequired), required: false);
            return new DeferredBodyAction<MSOutlookGetFirstEmailResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [WorkflowExpressionFactory(nameof(__BuildMSOutlookGetNumberOfEmails))]
        public IBodyWorkflowAction<MSOutlookGetNumberOfEmailsResponse> MSOutlookGetNumberOfEmails([WorkflowExpression] Func<string> mSOutlookGetNumberOfEmailsworkflow, [WorkflowExpression] Func<string> mSOutlookGetNumberOfEmailsfolderPath = null, [WorkflowExpression] Func<bool> mSOutlookGetNumberOfEmailssearchRead = null, [WorkflowExpression] Func<bool> mSOutlookGetNumberOfEmailssearchUnread = null, [WorkflowExpression] Func<string> mSOutlookGetNumberOfEmailssearchSubject = null, [WorkflowExpression] Func<string> mSOutlookGetNumberOfEmailssearchFromSMTP = null, [WorkflowExpression] Func<string> mSOutlookGetNumberOfEmailssearchFromName = null, [WorkflowExpression] Func<string> mSOutlookGetNumberOfEmailssearchQuery = null, [WorkflowExpression] Func<int> mSOutlookGetNumberOfEmailssearchMaxAgeInDays = null, [WorkflowExpression] Func<string> mSOutlookGetNumberOfEmailssearchStartDateTimeAsString = null, [WorkflowExpression] Func<string> mSOutlookGetNumberOfEmailssearchEndDateTimeAsString = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MSOutlookGetNumberOfEmailsResponse> __BuildMSOutlookGetNumberOfEmails(WorkflowExpression<string> mSOutlookGetNumberOfEmailsworkflow, WorkflowExpression<string> mSOutlookGetNumberOfEmailsfolderPath = null, WorkflowExpression<bool> mSOutlookGetNumberOfEmailssearchRead = null, WorkflowExpression<bool> mSOutlookGetNumberOfEmailssearchUnread = null, WorkflowExpression<string> mSOutlookGetNumberOfEmailssearchSubject = null, WorkflowExpression<string> mSOutlookGetNumberOfEmailssearchFromSMTP = null, WorkflowExpression<string> mSOutlookGetNumberOfEmailssearchFromName = null, WorkflowExpression<string> mSOutlookGetNumberOfEmailssearchQuery = null, WorkflowExpression<int> mSOutlookGetNumberOfEmailssearchMaxAgeInDays = null, WorkflowExpression<string> mSOutlookGetNumberOfEmailssearchStartDateTimeAsString = null, WorkflowExpression<string> mSOutlookGetNumberOfEmailssearchEndDateTimeAsString = null)
        {
            WorkflowExpression.Validate(mSOutlookGetNumberOfEmailsworkflow, nameof(mSOutlookGetNumberOfEmailsworkflow), required: true);
            WorkflowExpression.Validate(mSOutlookGetNumberOfEmailsfolderPath, nameof(mSOutlookGetNumberOfEmailsfolderPath), required: false);
            WorkflowExpression.Validate(mSOutlookGetNumberOfEmailssearchRead, nameof(mSOutlookGetNumberOfEmailssearchRead), required: false);
            WorkflowExpression.Validate(mSOutlookGetNumberOfEmailssearchUnread, nameof(mSOutlookGetNumberOfEmailssearchUnread), required: false);
            WorkflowExpression.Validate(mSOutlookGetNumberOfEmailssearchSubject, nameof(mSOutlookGetNumberOfEmailssearchSubject), required: false);
            WorkflowExpression.Validate(mSOutlookGetNumberOfEmailssearchFromSMTP, nameof(mSOutlookGetNumberOfEmailssearchFromSMTP), required: false);
            WorkflowExpression.Validate(mSOutlookGetNumberOfEmailssearchFromName, nameof(mSOutlookGetNumberOfEmailssearchFromName), required: false);
            WorkflowExpression.Validate(mSOutlookGetNumberOfEmailssearchQuery, nameof(mSOutlookGetNumberOfEmailssearchQuery), required: false);
            WorkflowExpression.Validate(mSOutlookGetNumberOfEmailssearchMaxAgeInDays, nameof(mSOutlookGetNumberOfEmailssearchMaxAgeInDays), required: false);
            WorkflowExpression.Validate(mSOutlookGetNumberOfEmailssearchStartDateTimeAsString, nameof(mSOutlookGetNumberOfEmailssearchStartDateTimeAsString), required: false);
            WorkflowExpression.Validate(mSOutlookGetNumberOfEmailssearchEndDateTimeAsString, nameof(mSOutlookGetNumberOfEmailssearchEndDateTimeAsString), required: false);
            return new DeferredBodyAction<MSOutlookGetNumberOfEmailsResponse>(() =>
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