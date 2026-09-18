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
        public IBodyWorkflowAction<MSWordCreateInstanceResponse> MSWordCreateInstance([WorkflowExpression] Func<string> mSWordCreateInstanceworkflow, [WorkflowExpression] Func<bool> mSWordCreateInstanceshowWord = null)
        {
            SourceExpression.Validate(mSWordCreateInstanceworkflow, nameof(mSWordCreateInstanceworkflow), required: true);
            SourceExpression.Validate(mSWordCreateInstanceshowWord, nameof(mSWordCreateInstanceshowWord), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSWordCreateInstance["ShowWord"] = SourceExpressionConverter.ConvertToken(mSWordCreateInstanceshowWord);
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
                mSWordCreateInstance["Workflow"] = SourceExpressionConverter.ConvertToken(mSWordCreateInstanceworkflow);
                if (mSWordCreateInstancepropCount > 0)
                {
                    callPayload.Body = mSWordCreateInstance;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MSWordCreateInstanceResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordCloseInstance([WorkflowExpression] Func<string> mSWordCloseInstanceworkflow, [WorkflowExpression] Func<int> mSWordCloseInstancehandle = null)
        {
            SourceExpression.Validate(mSWordCloseInstanceworkflow, nameof(mSWordCloseInstanceworkflow), required: true);
            SourceExpression.Validate(mSWordCloseInstancehandle, nameof(mSWordCloseInstancehandle), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSWordCloseInstance["Handle"] = SourceExpressionConverter.ConvertToken(mSWordCloseInstancehandle);
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
                mSWordCloseInstance["Workflow"] = SourceExpressionConverter.ConvertToken(mSWordCloseInstanceworkflow);
                if (mSWordCloseInstancepropCount > 0)
                {
                    callPayload.Body = mSWordCloseInstance;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordDetachFromInstance([WorkflowExpression] Func<string> mSWordDetachFromInstanceworkflow, [WorkflowExpression] Func<int> mSWordDetachFromInstancehandle = null)
        {
            SourceExpression.Validate(mSWordDetachFromInstanceworkflow, nameof(mSWordDetachFromInstanceworkflow), required: true);
            SourceExpression.Validate(mSWordDetachFromInstancehandle, nameof(mSWordDetachFromInstancehandle), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSWordDetachFromInstance["Handle"] = SourceExpressionConverter.ConvertToken(mSWordDetachFromInstancehandle);
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
                mSWordDetachFromInstance["Workflow"] = SourceExpressionConverter.ConvertToken(mSWordDetachFromInstanceworkflow);
                if (mSWordDetachFromInstancepropCount > 0)
                {
                    callPayload.Body = mSWordDetachFromInstance;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordAttachToExistingInstanceResponse> MSWordAttachToExistingInstance([WorkflowExpression] Func<string> mSWordAttachToExistingInstanceworkflow, [WorkflowExpression] Func<string> mSWordAttachToExistingInstancefilename = null, [WorkflowExpression] Func<bool> mSWordAttachToExistingInstancetoggleWindow = null, [WorkflowExpression] Func<bool> mSWordAttachToExistingInstancetoggleUsesGlobalLeftMouseClickAgent = null, [WorkflowExpression] Func<double> mSWordAttachToExistingInstancetoggleDelay = null)
        {
            SourceExpression.Validate(mSWordAttachToExistingInstanceworkflow, nameof(mSWordAttachToExistingInstanceworkflow), required: true);
            SourceExpression.Validate(mSWordAttachToExistingInstancefilename, nameof(mSWordAttachToExistingInstancefilename), required: false);
            SourceExpression.Validate(mSWordAttachToExistingInstancetoggleWindow, nameof(mSWordAttachToExistingInstancetoggleWindow), required: false);
            SourceExpression.Validate(mSWordAttachToExistingInstancetoggleUsesGlobalLeftMouseClickAgent, nameof(mSWordAttachToExistingInstancetoggleUsesGlobalLeftMouseClickAgent), required: false);
            SourceExpression.Validate(mSWordAttachToExistingInstancetoggleDelay, nameof(mSWordAttachToExistingInstancetoggleDelay), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/MSWord/AttachToExistingInstance";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSWordAttachToExistingInstance = new JObject();
                var mSWordAttachToExistingInstancepropCount = 0;
                if (mSWordAttachToExistingInstancefilename != null)
                {
                    mSWordAttachToExistingInstance["Filename"] = SourceExpressionConverter.ConvertToken(mSWordAttachToExistingInstancefilename);
                    mSWordAttachToExistingInstancepropCount++;
                }

                if (mSWordAttachToExistingInstancetoggleWindow != null)
                {
                    if (mSWordAttachToExistingInstancetoggleWindow != null)
                    {
                        mSWordAttachToExistingInstance["ToggleWindow"] = SourceExpressionConverter.ConvertToken(mSWordAttachToExistingInstancetoggleWindow);
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
                        mSWordAttachToExistingInstance["ToggleUsesGlobalLeftMouseClickAgent"] = SourceExpressionConverter.ConvertToken(mSWordAttachToExistingInstancetoggleUsesGlobalLeftMouseClickAgent);
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
                        mSWordAttachToExistingInstance["ToggleDelay"] = SourceExpressionConverter.ConvertToken(mSWordAttachToExistingInstancetoggleDelay);
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
                mSWordAttachToExistingInstance["Workflow"] = SourceExpressionConverter.ConvertToken(mSWordAttachToExistingInstanceworkflow);
                if (mSWordAttachToExistingInstancepropCount > 0)
                {
                    callPayload.Body = mSWordAttachToExistingInstance;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MSWordAttachToExistingInstanceResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordShowWord([WorkflowExpression] Func<string> mSWordShowWordworkflow, [WorkflowExpression] Func<int> mSWordShowWordhandle = null)
        {
            SourceExpression.Validate(mSWordShowWordworkflow, nameof(mSWordShowWordworkflow), required: true);
            SourceExpression.Validate(mSWordShowWordhandle, nameof(mSWordShowWordhandle), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSWordShowWord["Handle"] = SourceExpressionConverter.ConvertToken(mSWordShowWordhandle);
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
                mSWordShowWord["Workflow"] = SourceExpressionConverter.ConvertToken(mSWordShowWordworkflow);
                if (mSWordShowWordpropCount > 0)
                {
                    callPayload.Body = mSWordShowWord;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordHideWord([WorkflowExpression] Func<string> mSWordHideWordworkflow, [WorkflowExpression] Func<int> mSWordHideWordhandle = null)
        {
            SourceExpression.Validate(mSWordHideWordworkflow, nameof(mSWordHideWordworkflow), required: true);
            SourceExpression.Validate(mSWordHideWordhandle, nameof(mSWordHideWordhandle), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSWordHideWord["Handle"] = SourceExpressionConverter.ConvertToken(mSWordHideWordhandle);
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
                mSWordHideWord["Workflow"] = SourceExpressionConverter.ConvertToken(mSWordHideWordworkflow);
                if (mSWordHideWordpropCount > 0)
                {
                    callPayload.Body = mSWordHideWord;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordCreateDocumentResponse> MSWordCreateDocument([WorkflowExpression] Func<string> mSWordCreateDocumentworkflow, [WorkflowExpression] Func<int> mSWordCreateDocumenthandle = null)
        {
            SourceExpression.Validate(mSWordCreateDocumentworkflow, nameof(mSWordCreateDocumentworkflow), required: true);
            SourceExpression.Validate(mSWordCreateDocumenthandle, nameof(mSWordCreateDocumenthandle), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSWordCreateDocument["Handle"] = SourceExpressionConverter.ConvertToken(mSWordCreateDocumenthandle);
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
                mSWordCreateDocument["Workflow"] = SourceExpressionConverter.ConvertToken(mSWordCreateDocumentworkflow);
                if (mSWordCreateDocumentpropCount > 0)
                {
                    callPayload.Body = mSWordCreateDocument;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MSWordCreateDocumentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordOpenDocumentResponse> MSWordOpenDocument([WorkflowExpression] Func<string> mSWordOpenDocumentfilename, [WorkflowExpression] Func<string> mSWordOpenDocumentworkflow, [WorkflowExpression] Func<int> mSWordOpenDocumenthandle = null, [WorkflowExpression] Func<bool> mSWordOpenDocumentopenReadOnly = null, [WorkflowExpression] Func<bool> mSWordOpenDocumentaddToRecentFiles = null, [WorkflowExpression] Func<string> mSWordOpenDocumentpassword = null, [WorkflowExpression] Func<bool> mSWordOpenDocumentopenAndRepair = null)
        {
            SourceExpression.Validate(mSWordOpenDocumentfilename, nameof(mSWordOpenDocumentfilename), required: true);
            SourceExpression.Validate(mSWordOpenDocumentworkflow, nameof(mSWordOpenDocumentworkflow), required: true);
            SourceExpression.Validate(mSWordOpenDocumenthandle, nameof(mSWordOpenDocumenthandle), required: false);
            SourceExpression.Validate(mSWordOpenDocumentopenReadOnly, nameof(mSWordOpenDocumentopenReadOnly), required: false);
            SourceExpression.Validate(mSWordOpenDocumentaddToRecentFiles, nameof(mSWordOpenDocumentaddToRecentFiles), required: false);
            SourceExpression.Validate(mSWordOpenDocumentpassword, nameof(mSWordOpenDocumentpassword), required: false);
            SourceExpression.Validate(mSWordOpenDocumentopenAndRepair, nameof(mSWordOpenDocumentopenAndRepair), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSWordOpenDocument["Handle"] = SourceExpressionConverter.ConvertToken(mSWordOpenDocumenthandle);
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
                mSWordOpenDocument["Filename"] = SourceExpressionConverter.ConvertToken(mSWordOpenDocumentfilename);
                if (mSWordOpenDocumentopenReadOnly != null)
                {
                    if (mSWordOpenDocumentopenReadOnly != null)
                    {
                        mSWordOpenDocument["OpenReadOnly"] = SourceExpressionConverter.ConvertToken(mSWordOpenDocumentopenReadOnly);
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
                        mSWordOpenDocument["AddToRecentFiles"] = SourceExpressionConverter.ConvertToken(mSWordOpenDocumentaddToRecentFiles);
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
                    mSWordOpenDocument["Password"] = SourceExpressionConverter.ConvertToken(mSWordOpenDocumentpassword);
                    mSWordOpenDocumentpropCount++;
                }

                if (mSWordOpenDocumentopenAndRepair != null)
                {
                    if (mSWordOpenDocumentopenAndRepair != null)
                    {
                        mSWordOpenDocument["OpenAndRepair"] = SourceExpressionConverter.ConvertToken(mSWordOpenDocumentopenAndRepair);
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
                mSWordOpenDocument["Workflow"] = SourceExpressionConverter.ConvertToken(mSWordOpenDocumentworkflow);
                if (mSWordOpenDocumentpropCount > 0)
                {
                    callPayload.Body = mSWordOpenDocument;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MSWordOpenDocumentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordSaveDocument([WorkflowExpression] Func<string> mSWordSaveDocumentworkflow, [WorkflowExpression] Func<int> mSWordSaveDocumenthandle = null, [WorkflowExpression] Func<string> mSWordSaveDocumentdocumentName = null)
        {
            SourceExpression.Validate(mSWordSaveDocumentworkflow, nameof(mSWordSaveDocumentworkflow), required: true);
            SourceExpression.Validate(mSWordSaveDocumenthandle, nameof(mSWordSaveDocumenthandle), required: false);
            SourceExpression.Validate(mSWordSaveDocumentdocumentName, nameof(mSWordSaveDocumentdocumentName), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSWordSaveDocument["Handle"] = SourceExpressionConverter.ConvertToken(mSWordSaveDocumenthandle);
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
                    mSWordSaveDocument["DocumentName"] = SourceExpressionConverter.ConvertToken(mSWordSaveDocumentdocumentName);
                    mSWordSaveDocumentpropCount++;
                }

                mSWordSaveDocumentpropCount++;
                mSWordSaveDocument["Workflow"] = SourceExpressionConverter.ConvertToken(mSWordSaveDocumentworkflow);
                if (mSWordSaveDocumentpropCount > 0)
                {
                    callPayload.Body = mSWordSaveDocument;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordSaveAsDocumentResponse> MSWordSaveAsDocument([WorkflowExpression] Func<string> mSWordSaveAsDocumentsaveFilename, [WorkflowExpression] Func<string> mSWordSaveAsDocumentworkflow, [WorkflowExpression] Func<int> mSWordSaveAsDocumenthandle = null, [WorkflowExpression] Func<string> mSWordSaveAsDocumentdocumentName = null)
        {
            SourceExpression.Validate(mSWordSaveAsDocumentsaveFilename, nameof(mSWordSaveAsDocumentsaveFilename), required: true);
            SourceExpression.Validate(mSWordSaveAsDocumentworkflow, nameof(mSWordSaveAsDocumentworkflow), required: true);
            SourceExpression.Validate(mSWordSaveAsDocumenthandle, nameof(mSWordSaveAsDocumenthandle), required: false);
            SourceExpression.Validate(mSWordSaveAsDocumentdocumentName, nameof(mSWordSaveAsDocumentdocumentName), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSWordSaveAsDocument["Handle"] = SourceExpressionConverter.ConvertToken(mSWordSaveAsDocumenthandle);
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
                    mSWordSaveAsDocument["DocumentName"] = SourceExpressionConverter.ConvertToken(mSWordSaveAsDocumentdocumentName);
                    mSWordSaveAsDocumentpropCount++;
                }

                mSWordSaveAsDocumentpropCount++;
                mSWordSaveAsDocument["SaveFilename"] = SourceExpressionConverter.ConvertToken(mSWordSaveAsDocumentsaveFilename);
                mSWordSaveAsDocumentpropCount++;
                mSWordSaveAsDocument["Workflow"] = SourceExpressionConverter.ConvertToken(mSWordSaveAsDocumentworkflow);
                if (mSWordSaveAsDocumentpropCount > 0)
                {
                    callPayload.Body = mSWordSaveAsDocument;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MSWordSaveAsDocumentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordCloseDocument([WorkflowExpression] Func<string> mSWordCloseDocumentworkflow, [WorkflowExpression] Func<int> mSWordCloseDocumenthandle = null, [WorkflowExpression] Func<string> mSWordCloseDocumentdocumentName = null)
        {
            SourceExpression.Validate(mSWordCloseDocumentworkflow, nameof(mSWordCloseDocumentworkflow), required: true);
            SourceExpression.Validate(mSWordCloseDocumenthandle, nameof(mSWordCloseDocumenthandle), required: false);
            SourceExpression.Validate(mSWordCloseDocumentdocumentName, nameof(mSWordCloseDocumentdocumentName), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSWordCloseDocument["Handle"] = SourceExpressionConverter.ConvertToken(mSWordCloseDocumenthandle);
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
                    mSWordCloseDocument["DocumentName"] = SourceExpressionConverter.ConvertToken(mSWordCloseDocumentdocumentName);
                    mSWordCloseDocumentpropCount++;
                }

                mSWordCloseDocumentpropCount++;
                mSWordCloseDocument["Workflow"] = SourceExpressionConverter.ConvertToken(mSWordCloseDocumentworkflow);
                if (mSWordCloseDocumentpropCount > 0)
                {
                    callPayload.Body = mSWordCloseDocument;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordTypeText([WorkflowExpression] Func<string> mSWordTypeTexttext, [WorkflowExpression] Func<string> mSWordTypeTextworkflow, [WorkflowExpression] Func<int> mSWordTypeTexthandle = null)
        {
            SourceExpression.Validate(mSWordTypeTexttext, nameof(mSWordTypeTexttext), required: true);
            SourceExpression.Validate(mSWordTypeTextworkflow, nameof(mSWordTypeTextworkflow), required: true);
            SourceExpression.Validate(mSWordTypeTexthandle, nameof(mSWordTypeTexthandle), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSWordTypeText["Handle"] = SourceExpressionConverter.ConvertToken(mSWordTypeTexthandle);
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
                mSWordTypeText["Text"] = SourceExpressionConverter.ConvertToken(mSWordTypeTexttext);
                mSWordTypeTextpropCount++;
                mSWordTypeText["Workflow"] = SourceExpressionConverter.ConvertToken(mSWordTypeTextworkflow);
                if (mSWordTypeTextpropCount > 0)
                {
                    callPayload.Body = mSWordTypeText;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordSelectAll([WorkflowExpression] Func<string> mSWordSelectAllworkflow, [WorkflowExpression] Func<int> mSWordSelectAllhandle = null, [WorkflowExpression] Func<string> mSWordSelectAlldocumentName = null)
        {
            SourceExpression.Validate(mSWordSelectAllworkflow, nameof(mSWordSelectAllworkflow), required: true);
            SourceExpression.Validate(mSWordSelectAllhandle, nameof(mSWordSelectAllhandle), required: false);
            SourceExpression.Validate(mSWordSelectAlldocumentName, nameof(mSWordSelectAlldocumentName), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSWordSelectAll["Handle"] = SourceExpressionConverter.ConvertToken(mSWordSelectAllhandle);
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
                    mSWordSelectAll["DocumentName"] = SourceExpressionConverter.ConvertToken(mSWordSelectAlldocumentName);
                    mSWordSelectAllpropCount++;
                }

                mSWordSelectAllpropCount++;
                mSWordSelectAll["Workflow"] = SourceExpressionConverter.ConvertToken(mSWordSelectAllworkflow);
                if (mSWordSelectAllpropCount > 0)
                {
                    callPayload.Body = mSWordSelectAll;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordSelectRange([WorkflowExpression] Func<int> mSWordSelectRangestart, [WorkflowExpression] Func<int> mSWordSelectRangefinish, [WorkflowExpression] Func<string> mSWordSelectRangeworkflow, [WorkflowExpression] Func<int> mSWordSelectRangehandle = null, [WorkflowExpression] Func<string> mSWordSelectRangedocumentName = null)
        {
            SourceExpression.Validate(mSWordSelectRangestart, nameof(mSWordSelectRangestart), required: true);
            SourceExpression.Validate(mSWordSelectRangefinish, nameof(mSWordSelectRangefinish), required: true);
            SourceExpression.Validate(mSWordSelectRangeworkflow, nameof(mSWordSelectRangeworkflow), required: true);
            SourceExpression.Validate(mSWordSelectRangehandle, nameof(mSWordSelectRangehandle), required: false);
            SourceExpression.Validate(mSWordSelectRangedocumentName, nameof(mSWordSelectRangedocumentName), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSWordSelectRange["Handle"] = SourceExpressionConverter.ConvertToken(mSWordSelectRangehandle);
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
                    mSWordSelectRange["DocumentName"] = SourceExpressionConverter.ConvertToken(mSWordSelectRangedocumentName);
                    mSWordSelectRangepropCount++;
                }

                mSWordSelectRangepropCount++;
                mSWordSelectRange["Start"] = SourceExpressionConverter.ConvertToken(mSWordSelectRangestart);
                mSWordSelectRangepropCount++;
                mSWordSelectRange["Finish"] = SourceExpressionConverter.ConvertToken(mSWordSelectRangefinish);
                mSWordSelectRangepropCount++;
                mSWordSelectRange["Workflow"] = SourceExpressionConverter.ConvertToken(mSWordSelectRangeworkflow);
                if (mSWordSelectRangepropCount > 0)
                {
                    callPayload.Body = mSWordSelectRange;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordCopyToClipboard([WorkflowExpression] Func<string> mSWordCopyToClipboardworkflow, [WorkflowExpression] Func<int> mSWordCopyToClipboardhandle = null)
        {
            SourceExpression.Validate(mSWordCopyToClipboardworkflow, nameof(mSWordCopyToClipboardworkflow), required: true);
            SourceExpression.Validate(mSWordCopyToClipboardhandle, nameof(mSWordCopyToClipboardhandle), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSWordCopyToClipboard["Handle"] = SourceExpressionConverter.ConvertToken(mSWordCopyToClipboardhandle);
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
                mSWordCopyToClipboard["Workflow"] = SourceExpressionConverter.ConvertToken(mSWordCopyToClipboardworkflow);
                if (mSWordCopyToClipboardpropCount > 0)
                {
                    callPayload.Body = mSWordCopyToClipboard;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordPasteFromClipboard([WorkflowExpression] Func<string> mSWordPasteFromClipboardworkflow, [WorkflowExpression] Func<int> mSWordPasteFromClipboardhandle = null)
        {
            SourceExpression.Validate(mSWordPasteFromClipboardworkflow, nameof(mSWordPasteFromClipboardworkflow), required: true);
            SourceExpression.Validate(mSWordPasteFromClipboardhandle, nameof(mSWordPasteFromClipboardhandle), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSWordPasteFromClipboard["Handle"] = SourceExpressionConverter.ConvertToken(mSWordPasteFromClipboardhandle);
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
                mSWordPasteFromClipboard["Workflow"] = SourceExpressionConverter.ConvertToken(mSWordPasteFromClipboardworkflow);
                if (mSWordPasteFromClipboardpropCount > 0)
                {
                    callPayload.Body = mSWordPasteFromClipboard;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordClearClipboard([WorkflowExpression] Func<string> mSWordClearClipboardworkflow)
        {
            SourceExpression.Validate(mSWordClearClipboardworkflow, nameof(mSWordClearClipboardworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/MSWord/ClearClipboard";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSWordClearClipboard = new JObject();
                var mSWordClearClipboardpropCount = 0;
                mSWordClearClipboardpropCount++;
                mSWordClearClipboard["Workflow"] = SourceExpressionConverter.ConvertToken(mSWordClearClipboardworkflow);
                if (mSWordClearClipboardpropCount > 0)
                {
                    callPayload.Body = mSWordClearClipboard;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordGetDocumentBodyTextResponse> MSWordGetDocumentBodyText([WorkflowExpression] Func<int> mSWordGetDocumentBodyTextstart, [WorkflowExpression] Func<int> mSWordGetDocumentBodyTextfinish, [WorkflowExpression] Func<string> mSWordGetDocumentBodyTextworkflow, [WorkflowExpression] Func<int> mSWordGetDocumentBodyTexthandle = null, [WorkflowExpression] Func<string> mSWordGetDocumentBodyTextdocumentName = null)
        {
            SourceExpression.Validate(mSWordGetDocumentBodyTextstart, nameof(mSWordGetDocumentBodyTextstart), required: true);
            SourceExpression.Validate(mSWordGetDocumentBodyTextfinish, nameof(mSWordGetDocumentBodyTextfinish), required: true);
            SourceExpression.Validate(mSWordGetDocumentBodyTextworkflow, nameof(mSWordGetDocumentBodyTextworkflow), required: true);
            SourceExpression.Validate(mSWordGetDocumentBodyTexthandle, nameof(mSWordGetDocumentBodyTexthandle), required: false);
            SourceExpression.Validate(mSWordGetDocumentBodyTextdocumentName, nameof(mSWordGetDocumentBodyTextdocumentName), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSWordGetDocumentBodyText["Handle"] = SourceExpressionConverter.ConvertToken(mSWordGetDocumentBodyTexthandle);
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
                    mSWordGetDocumentBodyText["DocumentName"] = SourceExpressionConverter.ConvertToken(mSWordGetDocumentBodyTextdocumentName);
                    mSWordGetDocumentBodyTextpropCount++;
                }

                mSWordGetDocumentBodyTextpropCount++;
                mSWordGetDocumentBodyText["Start"] = SourceExpressionConverter.ConvertToken(mSWordGetDocumentBodyTextstart);
                mSWordGetDocumentBodyTextpropCount++;
                mSWordGetDocumentBodyText["Finish"] = SourceExpressionConverter.ConvertToken(mSWordGetDocumentBodyTextfinish);
                mSWordGetDocumentBodyTextpropCount++;
                mSWordGetDocumentBodyText["Workflow"] = SourceExpressionConverter.ConvertToken(mSWordGetDocumentBodyTextworkflow);
                if (mSWordGetDocumentBodyTextpropCount > 0)
                {
                    callPayload.Body = mSWordGetDocumentBodyText;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MSWordGetDocumentBodyTextResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordGetNumberOfTablesInDocumentResponse> MSWordGetNumberOfTablesInDocument([WorkflowExpression] Func<string> mSWordGetNumberOfTablesInDocumentworkflow, [WorkflowExpression] Func<int> mSWordGetNumberOfTablesInDocumenthandle = null, [WorkflowExpression] Func<string> mSWordGetNumberOfTablesInDocumentdocumentName = null)
        {
            SourceExpression.Validate(mSWordGetNumberOfTablesInDocumentworkflow, nameof(mSWordGetNumberOfTablesInDocumentworkflow), required: true);
            SourceExpression.Validate(mSWordGetNumberOfTablesInDocumenthandle, nameof(mSWordGetNumberOfTablesInDocumenthandle), required: false);
            SourceExpression.Validate(mSWordGetNumberOfTablesInDocumentdocumentName, nameof(mSWordGetNumberOfTablesInDocumentdocumentName), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSWordGetNumberOfTablesInDocument["Handle"] = SourceExpressionConverter.ConvertToken(mSWordGetNumberOfTablesInDocumenthandle);
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
                    mSWordGetNumberOfTablesInDocument["DocumentName"] = SourceExpressionConverter.ConvertToken(mSWordGetNumberOfTablesInDocumentdocumentName);
                    mSWordGetNumberOfTablesInDocumentpropCount++;
                }

                mSWordGetNumberOfTablesInDocumentpropCount++;
                mSWordGetNumberOfTablesInDocument["Workflow"] = SourceExpressionConverter.ConvertToken(mSWordGetNumberOfTablesInDocumentworkflow);
                if (mSWordGetNumberOfTablesInDocumentpropCount > 0)
                {
                    callPayload.Body = mSWordGetNumberOfTablesInDocument;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MSWordGetNumberOfTablesInDocumentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordUpdateBookmark([WorkflowExpression] Func<string> mSWordUpdateBookmarkbookmarkName, [WorkflowExpression] Func<string> mSWordUpdateBookmarkworkflow, [WorkflowExpression] Func<int> mSWordUpdateBookmarkhandle = null, [WorkflowExpression] Func<string> mSWordUpdateBookmarkdocumentName = null, [WorkflowExpression] Func<string> mSWordUpdateBookmarknewValue = null)
        {
            SourceExpression.Validate(mSWordUpdateBookmarkbookmarkName, nameof(mSWordUpdateBookmarkbookmarkName), required: true);
            SourceExpression.Validate(mSWordUpdateBookmarkworkflow, nameof(mSWordUpdateBookmarkworkflow), required: true);
            SourceExpression.Validate(mSWordUpdateBookmarkhandle, nameof(mSWordUpdateBookmarkhandle), required: false);
            SourceExpression.Validate(mSWordUpdateBookmarkdocumentName, nameof(mSWordUpdateBookmarkdocumentName), required: false);
            SourceExpression.Validate(mSWordUpdateBookmarknewValue, nameof(mSWordUpdateBookmarknewValue), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSWordUpdateBookmark["Handle"] = SourceExpressionConverter.ConvertToken(mSWordUpdateBookmarkhandle);
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
                    mSWordUpdateBookmark["DocumentName"] = SourceExpressionConverter.ConvertToken(mSWordUpdateBookmarkdocumentName);
                    mSWordUpdateBookmarkpropCount++;
                }

                mSWordUpdateBookmarkpropCount++;
                mSWordUpdateBookmark["BookmarkName"] = SourceExpressionConverter.ConvertToken(mSWordUpdateBookmarkbookmarkName);
                if (mSWordUpdateBookmarknewValue != null)
                {
                    mSWordUpdateBookmark["NewValue"] = SourceExpressionConverter.ConvertToken(mSWordUpdateBookmarknewValue);
                    mSWordUpdateBookmarkpropCount++;
                }

                mSWordUpdateBookmarkpropCount++;
                mSWordUpdateBookmark["Workflow"] = SourceExpressionConverter.ConvertToken(mSWordUpdateBookmarkworkflow);
                if (mSWordUpdateBookmarkpropCount > 0)
                {
                    callPayload.Body = mSWordUpdateBookmark;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordSelectTable([WorkflowExpression] Func<int> mSWordSelectTabletableIndex, [WorkflowExpression] Func<string> mSWordSelectTableworkflow, [WorkflowExpression] Func<int> mSWordSelectTablehandle = null, [WorkflowExpression] Func<string> mSWordSelectTabledocumentName = null)
        {
            SourceExpression.Validate(mSWordSelectTabletableIndex, nameof(mSWordSelectTabletableIndex), required: true);
            SourceExpression.Validate(mSWordSelectTableworkflow, nameof(mSWordSelectTableworkflow), required: true);
            SourceExpression.Validate(mSWordSelectTablehandle, nameof(mSWordSelectTablehandle), required: false);
            SourceExpression.Validate(mSWordSelectTabledocumentName, nameof(mSWordSelectTabledocumentName), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSWordSelectTable["Handle"] = SourceExpressionConverter.ConvertToken(mSWordSelectTablehandle);
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
                    mSWordSelectTable["DocumentName"] = SourceExpressionConverter.ConvertToken(mSWordSelectTabledocumentName);
                    mSWordSelectTablepropCount++;
                }

                mSWordSelectTablepropCount++;
                mSWordSelectTable["TableIndex"] = SourceExpressionConverter.ConvertToken(mSWordSelectTabletableIndex);
                mSWordSelectTablepropCount++;
                mSWordSelectTable["Workflow"] = SourceExpressionConverter.ConvertToken(mSWordSelectTableworkflow);
                if (mSWordSelectTablepropCount > 0)
                {
                    callPayload.Body = mSWordSelectTable;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordGetTableBoundsResponse> MSWordGetTableBounds([WorkflowExpression] Func<int> mSWordGetTableBoundstableIndex, [WorkflowExpression] Func<string> mSWordGetTableBoundsworkflow, [WorkflowExpression] Func<int> mSWordGetTableBoundshandle = null, [WorkflowExpression] Func<string> mSWordGetTableBoundsdocumentName = null)
        {
            SourceExpression.Validate(mSWordGetTableBoundstableIndex, nameof(mSWordGetTableBoundstableIndex), required: true);
            SourceExpression.Validate(mSWordGetTableBoundsworkflow, nameof(mSWordGetTableBoundsworkflow), required: true);
            SourceExpression.Validate(mSWordGetTableBoundshandle, nameof(mSWordGetTableBoundshandle), required: false);
            SourceExpression.Validate(mSWordGetTableBoundsdocumentName, nameof(mSWordGetTableBoundsdocumentName), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSWordGetTableBounds["Handle"] = SourceExpressionConverter.ConvertToken(mSWordGetTableBoundshandle);
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
                    mSWordGetTableBounds["DocumentName"] = SourceExpressionConverter.ConvertToken(mSWordGetTableBoundsdocumentName);
                    mSWordGetTableBoundspropCount++;
                }

                mSWordGetTableBoundspropCount++;
                mSWordGetTableBounds["TableIndex"] = SourceExpressionConverter.ConvertToken(mSWordGetTableBoundstableIndex);
                mSWordGetTableBoundspropCount++;
                mSWordGetTableBounds["Workflow"] = SourceExpressionConverter.ConvertToken(mSWordGetTableBoundsworkflow);
                if (mSWordGetTableBoundspropCount > 0)
                {
                    callPayload.Body = mSWordGetTableBounds;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MSWordGetTableBoundsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordSelectTableCell([WorkflowExpression] Func<int> mSWordSelectTableCelltableIndex, [WorkflowExpression] Func<int> mSWordSelectTableCellrowIndex, [WorkflowExpression] Func<int> mSWordSelectTableCellcolumnIndex, [WorkflowExpression] Func<string> mSWordSelectTableCellworkflow, [WorkflowExpression] Func<int> mSWordSelectTableCellhandle = null, [WorkflowExpression] Func<string> mSWordSelectTableCelldocumentName = null)
        {
            SourceExpression.Validate(mSWordSelectTableCelltableIndex, nameof(mSWordSelectTableCelltableIndex), required: true);
            SourceExpression.Validate(mSWordSelectTableCellrowIndex, nameof(mSWordSelectTableCellrowIndex), required: true);
            SourceExpression.Validate(mSWordSelectTableCellcolumnIndex, nameof(mSWordSelectTableCellcolumnIndex), required: true);
            SourceExpression.Validate(mSWordSelectTableCellworkflow, nameof(mSWordSelectTableCellworkflow), required: true);
            SourceExpression.Validate(mSWordSelectTableCellhandle, nameof(mSWordSelectTableCellhandle), required: false);
            SourceExpression.Validate(mSWordSelectTableCelldocumentName, nameof(mSWordSelectTableCelldocumentName), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSWordSelectTableCell["Handle"] = SourceExpressionConverter.ConvertToken(mSWordSelectTableCellhandle);
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
                    mSWordSelectTableCell["DocumentName"] = SourceExpressionConverter.ConvertToken(mSWordSelectTableCelldocumentName);
                    mSWordSelectTableCellpropCount++;
                }

                mSWordSelectTableCellpropCount++;
                mSWordSelectTableCell["TableIndex"] = SourceExpressionConverter.ConvertToken(mSWordSelectTableCelltableIndex);
                mSWordSelectTableCellpropCount++;
                mSWordSelectTableCell["RowIndex"] = SourceExpressionConverter.ConvertToken(mSWordSelectTableCellrowIndex);
                mSWordSelectTableCellpropCount++;
                mSWordSelectTableCell["ColumnIndex"] = SourceExpressionConverter.ConvertToken(mSWordSelectTableCellcolumnIndex);
                mSWordSelectTableCellpropCount++;
                mSWordSelectTableCell["Workflow"] = SourceExpressionConverter.ConvertToken(mSWordSelectTableCellworkflow);
                if (mSWordSelectTableCellpropCount > 0)
                {
                    callPayload.Body = mSWordSelectTableCell;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordGetTableCellTextValueResponse> MSWordGetTableCellTextValue([WorkflowExpression] Func<int> mSWordGetTableCellTextValuetableIndex, [WorkflowExpression] Func<int> mSWordGetTableCellTextValuerowIndex, [WorkflowExpression] Func<int> mSWordGetTableCellTextValuecolumnIndex, [WorkflowExpression] Func<string> mSWordGetTableCellTextValueworkflow, [WorkflowExpression] Func<int> mSWordGetTableCellTextValuehandle = null, [WorkflowExpression] Func<string> mSWordGetTableCellTextValuedocumentName = null)
        {
            SourceExpression.Validate(mSWordGetTableCellTextValuetableIndex, nameof(mSWordGetTableCellTextValuetableIndex), required: true);
            SourceExpression.Validate(mSWordGetTableCellTextValuerowIndex, nameof(mSWordGetTableCellTextValuerowIndex), required: true);
            SourceExpression.Validate(mSWordGetTableCellTextValuecolumnIndex, nameof(mSWordGetTableCellTextValuecolumnIndex), required: true);
            SourceExpression.Validate(mSWordGetTableCellTextValueworkflow, nameof(mSWordGetTableCellTextValueworkflow), required: true);
            SourceExpression.Validate(mSWordGetTableCellTextValuehandle, nameof(mSWordGetTableCellTextValuehandle), required: false);
            SourceExpression.Validate(mSWordGetTableCellTextValuedocumentName, nameof(mSWordGetTableCellTextValuedocumentName), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSWordGetTableCellTextValue["Handle"] = SourceExpressionConverter.ConvertToken(mSWordGetTableCellTextValuehandle);
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
                    mSWordGetTableCellTextValue["DocumentName"] = SourceExpressionConverter.ConvertToken(mSWordGetTableCellTextValuedocumentName);
                    mSWordGetTableCellTextValuepropCount++;
                }

                mSWordGetTableCellTextValuepropCount++;
                mSWordGetTableCellTextValue["TableIndex"] = SourceExpressionConverter.ConvertToken(mSWordGetTableCellTextValuetableIndex);
                mSWordGetTableCellTextValuepropCount++;
                mSWordGetTableCellTextValue["RowIndex"] = SourceExpressionConverter.ConvertToken(mSWordGetTableCellTextValuerowIndex);
                mSWordGetTableCellTextValuepropCount++;
                mSWordGetTableCellTextValue["ColumnIndex"] = SourceExpressionConverter.ConvertToken(mSWordGetTableCellTextValuecolumnIndex);
                mSWordGetTableCellTextValuepropCount++;
                mSWordGetTableCellTextValue["Workflow"] = SourceExpressionConverter.ConvertToken(mSWordGetTableCellTextValueworkflow);
                if (mSWordGetTableCellTextValuepropCount > 0)
                {
                    callPayload.Body = mSWordGetTableCellTextValue;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MSWordGetTableCellTextValueResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordGetTableCellTextValueTrimmedResponse> MSWordGetTableCellTextValueTrimmed([WorkflowExpression] Func<int> mSWordGetTableCellTextValueTrimmedtableIndex, [WorkflowExpression] Func<int> mSWordGetTableCellTextValueTrimmedrowIndex, [WorkflowExpression] Func<int> mSWordGetTableCellTextValueTrimmedcolumnIndex, [WorkflowExpression] Func<string> mSWordGetTableCellTextValueTrimmedworkflow, [WorkflowExpression] Func<int> mSWordGetTableCellTextValueTrimmedhandle = null, [WorkflowExpression] Func<string> mSWordGetTableCellTextValueTrimmeddocumentName = null)
        {
            SourceExpression.Validate(mSWordGetTableCellTextValueTrimmedtableIndex, nameof(mSWordGetTableCellTextValueTrimmedtableIndex), required: true);
            SourceExpression.Validate(mSWordGetTableCellTextValueTrimmedrowIndex, nameof(mSWordGetTableCellTextValueTrimmedrowIndex), required: true);
            SourceExpression.Validate(mSWordGetTableCellTextValueTrimmedcolumnIndex, nameof(mSWordGetTableCellTextValueTrimmedcolumnIndex), required: true);
            SourceExpression.Validate(mSWordGetTableCellTextValueTrimmedworkflow, nameof(mSWordGetTableCellTextValueTrimmedworkflow), required: true);
            SourceExpression.Validate(mSWordGetTableCellTextValueTrimmedhandle, nameof(mSWordGetTableCellTextValueTrimmedhandle), required: false);
            SourceExpression.Validate(mSWordGetTableCellTextValueTrimmeddocumentName, nameof(mSWordGetTableCellTextValueTrimmeddocumentName), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSWordGetTableCellTextValueTrimmed["Handle"] = SourceExpressionConverter.ConvertToken(mSWordGetTableCellTextValueTrimmedhandle);
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
                    mSWordGetTableCellTextValueTrimmed["DocumentName"] = SourceExpressionConverter.ConvertToken(mSWordGetTableCellTextValueTrimmeddocumentName);
                    mSWordGetTableCellTextValueTrimmedpropCount++;
                }

                mSWordGetTableCellTextValueTrimmedpropCount++;
                mSWordGetTableCellTextValueTrimmed["TableIndex"] = SourceExpressionConverter.ConvertToken(mSWordGetTableCellTextValueTrimmedtableIndex);
                mSWordGetTableCellTextValueTrimmedpropCount++;
                mSWordGetTableCellTextValueTrimmed["RowIndex"] = SourceExpressionConverter.ConvertToken(mSWordGetTableCellTextValueTrimmedrowIndex);
                mSWordGetTableCellTextValueTrimmedpropCount++;
                mSWordGetTableCellTextValueTrimmed["ColumnIndex"] = SourceExpressionConverter.ConvertToken(mSWordGetTableCellTextValueTrimmedcolumnIndex);
                mSWordGetTableCellTextValueTrimmedpropCount++;
                mSWordGetTableCellTextValueTrimmed["Workflow"] = SourceExpressionConverter.ConvertToken(mSWordGetTableCellTextValueTrimmedworkflow);
                if (mSWordGetTableCellTextValueTrimmedpropCount > 0)
                {
                    callPayload.Body = mSWordGetTableCellTextValueTrimmed;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MSWordGetTableCellTextValueTrimmedResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordSetTableCellTextValue([WorkflowExpression] Func<int> mSWordSetTableCellTextValuetableIndex, [WorkflowExpression] Func<int> mSWordSetTableCellTextValuerowIndex, [WorkflowExpression] Func<int> mSWordSetTableCellTextValuecolumnIndex, [WorkflowExpression] Func<string> mSWordSetTableCellTextValueworkflow, [WorkflowExpression] Func<int> mSWordSetTableCellTextValuehandle = null, [WorkflowExpression] Func<string> mSWordSetTableCellTextValuedocumentName = null, [WorkflowExpression] Func<string> mSWordSetTableCellTextValuenewCellText = null)
        {
            SourceExpression.Validate(mSWordSetTableCellTextValuetableIndex, nameof(mSWordSetTableCellTextValuetableIndex), required: true);
            SourceExpression.Validate(mSWordSetTableCellTextValuerowIndex, nameof(mSWordSetTableCellTextValuerowIndex), required: true);
            SourceExpression.Validate(mSWordSetTableCellTextValuecolumnIndex, nameof(mSWordSetTableCellTextValuecolumnIndex), required: true);
            SourceExpression.Validate(mSWordSetTableCellTextValueworkflow, nameof(mSWordSetTableCellTextValueworkflow), required: true);
            SourceExpression.Validate(mSWordSetTableCellTextValuehandle, nameof(mSWordSetTableCellTextValuehandle), required: false);
            SourceExpression.Validate(mSWordSetTableCellTextValuedocumentName, nameof(mSWordSetTableCellTextValuedocumentName), required: false);
            SourceExpression.Validate(mSWordSetTableCellTextValuenewCellText, nameof(mSWordSetTableCellTextValuenewCellText), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSWordSetTableCellTextValue["Handle"] = SourceExpressionConverter.ConvertToken(mSWordSetTableCellTextValuehandle);
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
                    mSWordSetTableCellTextValue["DocumentName"] = SourceExpressionConverter.ConvertToken(mSWordSetTableCellTextValuedocumentName);
                    mSWordSetTableCellTextValuepropCount++;
                }

                mSWordSetTableCellTextValuepropCount++;
                mSWordSetTableCellTextValue["TableIndex"] = SourceExpressionConverter.ConvertToken(mSWordSetTableCellTextValuetableIndex);
                mSWordSetTableCellTextValuepropCount++;
                mSWordSetTableCellTextValue["RowIndex"] = SourceExpressionConverter.ConvertToken(mSWordSetTableCellTextValuerowIndex);
                mSWordSetTableCellTextValuepropCount++;
                mSWordSetTableCellTextValue["ColumnIndex"] = SourceExpressionConverter.ConvertToken(mSWordSetTableCellTextValuecolumnIndex);
                if (mSWordSetTableCellTextValuenewCellText != null)
                {
                    mSWordSetTableCellTextValue["NewCellText"] = SourceExpressionConverter.ConvertToken(mSWordSetTableCellTextValuenewCellText);
                    mSWordSetTableCellTextValuepropCount++;
                }

                mSWordSetTableCellTextValuepropCount++;
                mSWordSetTableCellTextValue["Workflow"] = SourceExpressionConverter.ConvertToken(mSWordSetTableCellTextValueworkflow);
                if (mSWordSetTableCellTextValuepropCount > 0)
                {
                    callPayload.Body = mSWordSetTableCellTextValue;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordExportDocumentAsPDF([WorkflowExpression] Func<string> mSWordExportDocumentAsPDFsaveFileName, [WorkflowExpression] Func<string> mSWordExportDocumentAsPDFworkflow, [WorkflowExpression] Func<int> mSWordExportDocumentAsPDFhandle = null, [WorkflowExpression] Func<string> mSWordExportDocumentAsPDFdocumentName = null)
        {
            SourceExpression.Validate(mSWordExportDocumentAsPDFsaveFileName, nameof(mSWordExportDocumentAsPDFsaveFileName), required: true);
            SourceExpression.Validate(mSWordExportDocumentAsPDFworkflow, nameof(mSWordExportDocumentAsPDFworkflow), required: true);
            SourceExpression.Validate(mSWordExportDocumentAsPDFhandle, nameof(mSWordExportDocumentAsPDFhandle), required: false);
            SourceExpression.Validate(mSWordExportDocumentAsPDFdocumentName, nameof(mSWordExportDocumentAsPDFdocumentName), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSWordExportDocumentAsPDF["Handle"] = SourceExpressionConverter.ConvertToken(mSWordExportDocumentAsPDFhandle);
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
                    mSWordExportDocumentAsPDF["DocumentName"] = SourceExpressionConverter.ConvertToken(mSWordExportDocumentAsPDFdocumentName);
                    mSWordExportDocumentAsPDFpropCount++;
                }

                mSWordExportDocumentAsPDFpropCount++;
                mSWordExportDocumentAsPDF["SaveFileName"] = SourceExpressionConverter.ConvertToken(mSWordExportDocumentAsPDFsaveFileName);
                mSWordExportDocumentAsPDFpropCount++;
                mSWordExportDocumentAsPDF["Workflow"] = SourceExpressionConverter.ConvertToken(mSWordExportDocumentAsPDFworkflow);
                if (mSWordExportDocumentAsPDFpropCount > 0)
                {
                    callPayload.Body = mSWordExportDocumentAsPDF;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordAddTable([WorkflowExpression] Func<int> mSWordAddTablenumberOfRows, [WorkflowExpression] Func<int> mSWordAddTablenumberOfColumns, [WorkflowExpression] Func<string> mSWordAddTableworkflow, [WorkflowExpression] Func<int> mSWordAddTablehandle = null, [WorkflowExpression] Func<string> mSWordAddTabledocumentName = null, [WorkflowExpression] Func<int> mSWordAddTableautoFitBehaviour = null)
        {
            SourceExpression.Validate(mSWordAddTablenumberOfRows, nameof(mSWordAddTablenumberOfRows), required: true);
            SourceExpression.Validate(mSWordAddTablenumberOfColumns, nameof(mSWordAddTablenumberOfColumns), required: true);
            SourceExpression.Validate(mSWordAddTableworkflow, nameof(mSWordAddTableworkflow), required: true);
            SourceExpression.Validate(mSWordAddTablehandle, nameof(mSWordAddTablehandle), required: false);
            SourceExpression.Validate(mSWordAddTabledocumentName, nameof(mSWordAddTabledocumentName), required: false);
            SourceExpression.Validate(mSWordAddTableautoFitBehaviour, nameof(mSWordAddTableautoFitBehaviour), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSWordAddTable["Handle"] = SourceExpressionConverter.ConvertToken(mSWordAddTablehandle);
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
                    mSWordAddTable["DocumentName"] = SourceExpressionConverter.ConvertToken(mSWordAddTabledocumentName);
                    mSWordAddTablepropCount++;
                }

                mSWordAddTablepropCount++;
                mSWordAddTable["NumberOfRows"] = SourceExpressionConverter.ConvertToken(mSWordAddTablenumberOfRows);
                mSWordAddTablepropCount++;
                mSWordAddTable["NumberOfColumns"] = SourceExpressionConverter.ConvertToken(mSWordAddTablenumberOfColumns);
                if (mSWordAddTableautoFitBehaviour != null)
                {
                    if (mSWordAddTableautoFitBehaviour != null)
                    {
                        mSWordAddTable["AutoFitBehaviour"] = SourceExpressionConverter.ConvertToken(mSWordAddTableautoFitBehaviour);
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
                mSWordAddTable["Workflow"] = SourceExpressionConverter.ConvertToken(mSWordAddTableworkflow);
                if (mSWordAddTablepropCount > 0)
                {
                    callPayload.Body = mSWordAddTable;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordAddTableRow([WorkflowExpression] Func<int> mSWordAddTableRowtableIndex, [WorkflowExpression] Func<string> mSWordAddTableRowworkflow, [WorkflowExpression] Func<int> mSWordAddTableRowhandle = null, [WorkflowExpression] Func<string> mSWordAddTableRowdocumentName = null)
        {
            SourceExpression.Validate(mSWordAddTableRowtableIndex, nameof(mSWordAddTableRowtableIndex), required: true);
            SourceExpression.Validate(mSWordAddTableRowworkflow, nameof(mSWordAddTableRowworkflow), required: true);
            SourceExpression.Validate(mSWordAddTableRowhandle, nameof(mSWordAddTableRowhandle), required: false);
            SourceExpression.Validate(mSWordAddTableRowdocumentName, nameof(mSWordAddTableRowdocumentName), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSWordAddTableRow["Handle"] = SourceExpressionConverter.ConvertToken(mSWordAddTableRowhandle);
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
                    mSWordAddTableRow["DocumentName"] = SourceExpressionConverter.ConvertToken(mSWordAddTableRowdocumentName);
                    mSWordAddTableRowpropCount++;
                }

                mSWordAddTableRowpropCount++;
                mSWordAddTableRow["TableIndex"] = SourceExpressionConverter.ConvertToken(mSWordAddTableRowtableIndex);
                mSWordAddTableRowpropCount++;
                mSWordAddTableRow["Workflow"] = SourceExpressionConverter.ConvertToken(mSWordAddTableRowworkflow);
                if (mSWordAddTableRowpropCount > 0)
                {
                    callPayload.Body = mSWordAddTableRow;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSWordAddTableColumn([WorkflowExpression] Func<int> mSWordAddTableColumntableIndex, [WorkflowExpression] Func<string> mSWordAddTableColumnworkflow, [WorkflowExpression] Func<int> mSWordAddTableColumnhandle = null, [WorkflowExpression] Func<string> mSWordAddTableColumndocumentName = null)
        {
            SourceExpression.Validate(mSWordAddTableColumntableIndex, nameof(mSWordAddTableColumntableIndex), required: true);
            SourceExpression.Validate(mSWordAddTableColumnworkflow, nameof(mSWordAddTableColumnworkflow), required: true);
            SourceExpression.Validate(mSWordAddTableColumnhandle, nameof(mSWordAddTableColumnhandle), required: false);
            SourceExpression.Validate(mSWordAddTableColumndocumentName, nameof(mSWordAddTableColumndocumentName), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSWordAddTableColumn["Handle"] = SourceExpressionConverter.ConvertToken(mSWordAddTableColumnhandle);
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
                    mSWordAddTableColumn["DocumentName"] = SourceExpressionConverter.ConvertToken(mSWordAddTableColumndocumentName);
                    mSWordAddTableColumnpropCount++;
                }

                mSWordAddTableColumnpropCount++;
                mSWordAddTableColumn["TableIndex"] = SourceExpressionConverter.ConvertToken(mSWordAddTableColumntableIndex);
                mSWordAddTableColumnpropCount++;
                mSWordAddTableColumn["Workflow"] = SourceExpressionConverter.ConvertToken(mSWordAddTableColumnworkflow);
                if (mSWordAddTableColumnpropCount > 0)
                {
                    callPayload.Body = mSWordAddTableColumn;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordGetHighlightedTextResponse> MSWordGetHighlightedText([WorkflowExpression] Func<string> mSWordGetHighlightedTextworkflow, [WorkflowExpression] Func<int> mSWordGetHighlightedTexthandle = null, [WorkflowExpression] Func<string> mSWordGetHighlightedTextdocumentName = null)
        {
            SourceExpression.Validate(mSWordGetHighlightedTextworkflow, nameof(mSWordGetHighlightedTextworkflow), required: true);
            SourceExpression.Validate(mSWordGetHighlightedTexthandle, nameof(mSWordGetHighlightedTexthandle), required: false);
            SourceExpression.Validate(mSWordGetHighlightedTextdocumentName, nameof(mSWordGetHighlightedTextdocumentName), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSWordGetHighlightedText["Handle"] = SourceExpressionConverter.ConvertToken(mSWordGetHighlightedTexthandle);
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
                    mSWordGetHighlightedText["DocumentName"] = SourceExpressionConverter.ConvertToken(mSWordGetHighlightedTextdocumentName);
                    mSWordGetHighlightedTextpropCount++;
                }

                mSWordGetHighlightedTextpropCount++;
                mSWordGetHighlightedText["Workflow"] = SourceExpressionConverter.ConvertToken(mSWordGetHighlightedTextworkflow);
                if (mSWordGetHighlightedTextpropCount > 0)
                {
                    callPayload.Body = mSWordGetHighlightedText;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MSWordGetHighlightedTextResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordExecuteCommandBarObjectResponse> MSWordExecuteCommandBarObject([WorkflowExpression] Func<string> mSWordExecuteCommandBarObjectobjectId, [WorkflowExpression] Func<string> mSWordExecuteCommandBarObjectworkflow, [WorkflowExpression] Func<int> mSWordExecuteCommandBarObjecthandle = null, [WorkflowExpression] Func<bool> mSWordExecuteCommandBarObjectrunInBackground = null)
        {
            SourceExpression.Validate(mSWordExecuteCommandBarObjectobjectId, nameof(mSWordExecuteCommandBarObjectobjectId), required: true);
            SourceExpression.Validate(mSWordExecuteCommandBarObjectworkflow, nameof(mSWordExecuteCommandBarObjectworkflow), required: true);
            SourceExpression.Validate(mSWordExecuteCommandBarObjecthandle, nameof(mSWordExecuteCommandBarObjecthandle), required: false);
            SourceExpression.Validate(mSWordExecuteCommandBarObjectrunInBackground, nameof(mSWordExecuteCommandBarObjectrunInBackground), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSWordExecuteCommandBarObject["Handle"] = SourceExpressionConverter.ConvertToken(mSWordExecuteCommandBarObjecthandle);
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
                mSWordExecuteCommandBarObject["ObjectId"] = SourceExpressionConverter.ConvertToken(mSWordExecuteCommandBarObjectobjectId);
                if (mSWordExecuteCommandBarObjectrunInBackground != null)
                {
                    if (mSWordExecuteCommandBarObjectrunInBackground != null)
                    {
                        mSWordExecuteCommandBarObject["RunInBackground"] = SourceExpressionConverter.ConvertToken(mSWordExecuteCommandBarObjectrunInBackground);
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
                mSWordExecuteCommandBarObject["Workflow"] = SourceExpressionConverter.ConvertToken(mSWordExecuteCommandBarObjectworkflow);
                if (mSWordExecuteCommandBarObjectpropCount > 0)
                {
                    callPayload.Body = mSWordExecuteCommandBarObject;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MSWordExecuteCommandBarObjectResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordSetDocumentSensitivityLabelResponse> MSWordSetDocumentSensitivityLabel([WorkflowExpression] Func<mSWordSetDocumentSensitivityLabelassignmentMethodInput> mSWordSetDocumentSensitivityLabelassignmentMethod, [WorkflowExpression] Func<string> mSWordSetDocumentSensitivityLabellabelId, [WorkflowExpression] Func<string> mSWordSetDocumentSensitivityLabelworkflow, [WorkflowExpression] Func<int> mSWordSetDocumentSensitivityLabelhandle = null, [WorkflowExpression] Func<string> mSWordSetDocumentSensitivityLabeldocumentName = null, [WorkflowExpression] Func<string> mSWordSetDocumentSensitivityLabellabelName = null, [WorkflowExpression] Func<string> mSWordSetDocumentSensitivityLabelsiteId = null, [WorkflowExpression] Func<string> mSWordSetDocumentSensitivityLabeljustification = null)
        {
            SourceExpression.Validate(mSWordSetDocumentSensitivityLabelassignmentMethod, nameof(mSWordSetDocumentSensitivityLabelassignmentMethod), required: true);
            SourceExpression.Validate(mSWordSetDocumentSensitivityLabellabelId, nameof(mSWordSetDocumentSensitivityLabellabelId), required: true);
            SourceExpression.Validate(mSWordSetDocumentSensitivityLabelworkflow, nameof(mSWordSetDocumentSensitivityLabelworkflow), required: true);
            SourceExpression.Validate(mSWordSetDocumentSensitivityLabelhandle, nameof(mSWordSetDocumentSensitivityLabelhandle), required: false);
            SourceExpression.Validate(mSWordSetDocumentSensitivityLabeldocumentName, nameof(mSWordSetDocumentSensitivityLabeldocumentName), required: false);
            SourceExpression.Validate(mSWordSetDocumentSensitivityLabellabelName, nameof(mSWordSetDocumentSensitivityLabellabelName), required: false);
            SourceExpression.Validate(mSWordSetDocumentSensitivityLabelsiteId, nameof(mSWordSetDocumentSensitivityLabelsiteId), required: false);
            SourceExpression.Validate(mSWordSetDocumentSensitivityLabeljustification, nameof(mSWordSetDocumentSensitivityLabeljustification), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSWordSetDocumentSensitivityLabel["Handle"] = SourceExpressionConverter.ConvertToken(mSWordSetDocumentSensitivityLabelhandle);
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
                    mSWordSetDocumentSensitivityLabel["DocumentName"] = SourceExpressionConverter.ConvertToken(mSWordSetDocumentSensitivityLabeldocumentName);
                    mSWordSetDocumentSensitivityLabelpropCount++;
                }

                mSWordSetDocumentSensitivityLabelpropCount++;
                mSWordSetDocumentSensitivityLabel["AssignmentMethod"] = SourceExpressionConverter.Convert(mSWordSetDocumentSensitivityLabelassignmentMethod);
                mSWordSetDocumentSensitivityLabelpropCount++;
                mSWordSetDocumentSensitivityLabel["LabelId"] = SourceExpressionConverter.ConvertToken(mSWordSetDocumentSensitivityLabellabelId);
                if (mSWordSetDocumentSensitivityLabellabelName != null)
                {
                    mSWordSetDocumentSensitivityLabel["LabelName"] = SourceExpressionConverter.ConvertToken(mSWordSetDocumentSensitivityLabellabelName);
                    mSWordSetDocumentSensitivityLabelpropCount++;
                }

                if (mSWordSetDocumentSensitivityLabelsiteId != null)
                {
                    mSWordSetDocumentSensitivityLabel["SiteId"] = SourceExpressionConverter.ConvertToken(mSWordSetDocumentSensitivityLabelsiteId);
                    mSWordSetDocumentSensitivityLabelpropCount++;
                }

                if (mSWordSetDocumentSensitivityLabeljustification != null)
                {
                    mSWordSetDocumentSensitivityLabel["Justification"] = SourceExpressionConverter.ConvertToken(mSWordSetDocumentSensitivityLabeljustification);
                    mSWordSetDocumentSensitivityLabelpropCount++;
                }

                mSWordSetDocumentSensitivityLabelpropCount++;
                mSWordSetDocumentSensitivityLabel["Workflow"] = SourceExpressionConverter.ConvertToken(mSWordSetDocumentSensitivityLabelworkflow);
                if (mSWordSetDocumentSensitivityLabelpropCount > 0)
                {
                    callPayload.Body = mSWordSetDocumentSensitivityLabel;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MSWordSetDocumentSensitivityLabelResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSWordGetDocumentSensitivityLabelResponse> MSWordGetDocumentSensitivityLabel([WorkflowExpression] Func<string> mSWordGetDocumentSensitivityLabelworkflow, [WorkflowExpression] Func<int> mSWordGetDocumentSensitivityLabelhandle = null, [WorkflowExpression] Func<string> mSWordGetDocumentSensitivityLabeldocumentName = null)
        {
            SourceExpression.Validate(mSWordGetDocumentSensitivityLabelworkflow, nameof(mSWordGetDocumentSensitivityLabelworkflow), required: true);
            SourceExpression.Validate(mSWordGetDocumentSensitivityLabelhandle, nameof(mSWordGetDocumentSensitivityLabelhandle), required: false);
            SourceExpression.Validate(mSWordGetDocumentSensitivityLabeldocumentName, nameof(mSWordGetDocumentSensitivityLabeldocumentName), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSWordGetDocumentSensitivityLabel["Handle"] = SourceExpressionConverter.ConvertToken(mSWordGetDocumentSensitivityLabelhandle);
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
                    mSWordGetDocumentSensitivityLabel["DocumentName"] = SourceExpressionConverter.ConvertToken(mSWordGetDocumentSensitivityLabeldocumentName);
                    mSWordGetDocumentSensitivityLabelpropCount++;
                }

                mSWordGetDocumentSensitivityLabelpropCount++;
                mSWordGetDocumentSensitivityLabel["Workflow"] = SourceExpressionConverter.ConvertToken(mSWordGetDocumentSensitivityLabelworkflow);
                if (mSWordGetDocumentSensitivityLabelpropCount > 0)
                {
                    callPayload.Body = mSWordGetDocumentSensitivityLabel;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MSWordGetDocumentSensitivityLabelResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelCreateInstanceResponse> MSExcelCreateInstance([WorkflowExpression] Func<string> mSExcelCreateInstanceworkflow, [WorkflowExpression] Func<bool> mSExcelCreateInstanceenableEvents = null, [WorkflowExpression] Func<bool> mSExcelCreateInstanceshowExcel = null)
        {
            SourceExpression.Validate(mSExcelCreateInstanceworkflow, nameof(mSExcelCreateInstanceworkflow), required: true);
            SourceExpression.Validate(mSExcelCreateInstanceenableEvents, nameof(mSExcelCreateInstanceenableEvents), required: false);
            SourceExpression.Validate(mSExcelCreateInstanceshowExcel, nameof(mSExcelCreateInstanceshowExcel), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSExcelCreateInstance["EnableEvents"] = SourceExpressionConverter.ConvertToken(mSExcelCreateInstanceenableEvents);
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
                        mSExcelCreateInstance["ShowExcel"] = SourceExpressionConverter.ConvertToken(mSExcelCreateInstanceshowExcel);
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
                mSExcelCreateInstance["Workflow"] = SourceExpressionConverter.ConvertToken(mSExcelCreateInstanceworkflow);
                if (mSExcelCreateInstancepropCount > 0)
                {
                    callPayload.Body = mSExcelCreateInstance;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MSExcelCreateInstanceResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelCloseInstance([WorkflowExpression] Func<string> mSExcelCloseInstanceworkflow, [WorkflowExpression] Func<int> mSExcelCloseInstancehandle = null)
        {
            SourceExpression.Validate(mSExcelCloseInstanceworkflow, nameof(mSExcelCloseInstanceworkflow), required: true);
            SourceExpression.Validate(mSExcelCloseInstancehandle, nameof(mSExcelCloseInstancehandle), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSExcelCloseInstance["Handle"] = SourceExpressionConverter.ConvertToken(mSExcelCloseInstancehandle);
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
                mSExcelCloseInstance["Workflow"] = SourceExpressionConverter.ConvertToken(mSExcelCloseInstanceworkflow);
                if (mSExcelCloseInstancepropCount > 0)
                {
                    callPayload.Body = mSExcelCloseInstance;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelAttachToExistingInstanceResponse> MSExcelAttachToExistingInstance([WorkflowExpression] Func<string> mSExcelAttachToExistingInstanceworkflow, [WorkflowExpression] Func<string> mSExcelAttachToExistingInstancefilename = null, [WorkflowExpression] Func<bool> mSExcelAttachToExistingInstancetoggleWindow = null, [WorkflowExpression] Func<bool> mSExcelAttachToExistingInstancetoggleUsesGlobalLeftMouseClickAgent = null, [WorkflowExpression] Func<double> mSExcelAttachToExistingInstancetoggleDelay = null)
        {
            SourceExpression.Validate(mSExcelAttachToExistingInstanceworkflow, nameof(mSExcelAttachToExistingInstanceworkflow), required: true);
            SourceExpression.Validate(mSExcelAttachToExistingInstancefilename, nameof(mSExcelAttachToExistingInstancefilename), required: false);
            SourceExpression.Validate(mSExcelAttachToExistingInstancetoggleWindow, nameof(mSExcelAttachToExistingInstancetoggleWindow), required: false);
            SourceExpression.Validate(mSExcelAttachToExistingInstancetoggleUsesGlobalLeftMouseClickAgent, nameof(mSExcelAttachToExistingInstancetoggleUsesGlobalLeftMouseClickAgent), required: false);
            SourceExpression.Validate(mSExcelAttachToExistingInstancetoggleDelay, nameof(mSExcelAttachToExistingInstancetoggleDelay), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/MSExcel/MSExcelAttachToExistingInstance";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSExcelAttachToExistingInstance = new JObject();
                var mSExcelAttachToExistingInstancepropCount = 0;
                if (mSExcelAttachToExistingInstancefilename != null)
                {
                    mSExcelAttachToExistingInstance["Filename"] = SourceExpressionConverter.ConvertToken(mSExcelAttachToExistingInstancefilename);
                    mSExcelAttachToExistingInstancepropCount++;
                }

                if (mSExcelAttachToExistingInstancetoggleWindow != null)
                {
                    if (mSExcelAttachToExistingInstancetoggleWindow != null)
                    {
                        mSExcelAttachToExistingInstance["ToggleWindow"] = SourceExpressionConverter.ConvertToken(mSExcelAttachToExistingInstancetoggleWindow);
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
                        mSExcelAttachToExistingInstance["ToggleUsesGlobalLeftMouseClickAgent"] = SourceExpressionConverter.ConvertToken(mSExcelAttachToExistingInstancetoggleUsesGlobalLeftMouseClickAgent);
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
                        mSExcelAttachToExistingInstance["ToggleDelay"] = SourceExpressionConverter.ConvertToken(mSExcelAttachToExistingInstancetoggleDelay);
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
                mSExcelAttachToExistingInstance["Workflow"] = SourceExpressionConverter.ConvertToken(mSExcelAttachToExistingInstanceworkflow);
                if (mSExcelAttachToExistingInstancepropCount > 0)
                {
                    callPayload.Body = mSExcelAttachToExistingInstance;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MSExcelAttachToExistingInstanceResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelShowExcel([WorkflowExpression] Func<string> mSExcelShowExcelworkflow, [WorkflowExpression] Func<int> mSExcelShowExcelhandle = null)
        {
            SourceExpression.Validate(mSExcelShowExcelworkflow, nameof(mSExcelShowExcelworkflow), required: true);
            SourceExpression.Validate(mSExcelShowExcelhandle, nameof(mSExcelShowExcelhandle), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSExcelShowExcel["Handle"] = SourceExpressionConverter.ConvertToken(mSExcelShowExcelhandle);
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
                mSExcelShowExcel["Workflow"] = SourceExpressionConverter.ConvertToken(mSExcelShowExcelworkflow);
                if (mSExcelShowExcelpropCount > 0)
                {
                    callPayload.Body = mSExcelShowExcel;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelHideExcel([WorkflowExpression] Func<string> mSExcelHideExcelworkflow, [WorkflowExpression] Func<int> mSExcelHideExcelhandle = null)
        {
            SourceExpression.Validate(mSExcelHideExcelworkflow, nameof(mSExcelHideExcelworkflow), required: true);
            SourceExpression.Validate(mSExcelHideExcelhandle, nameof(mSExcelHideExcelhandle), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSExcelHideExcel["Handle"] = SourceExpressionConverter.ConvertToken(mSExcelHideExcelhandle);
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
                mSExcelHideExcel["Workflow"] = SourceExpressionConverter.ConvertToken(mSExcelHideExcelworkflow);
                if (mSExcelHideExcelpropCount > 0)
                {
                    callPayload.Body = mSExcelHideExcel;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelOpenWorkbookResponse> MSExcelOpenWorkbook([WorkflowExpression] Func<string> mSExcelOpenWorkbookworkflow, [WorkflowExpression] Func<int> mSExcelOpenWorkbookhandle = null, [WorkflowExpression] Func<string> mSExcelOpenWorkbookfilename = null, [WorkflowExpression] Func<bool> mSExcelOpenWorkbookreadOnly = null, [WorkflowExpression] Func<bool> mSExcelOpenWorkbookupdateLinks = null, [WorkflowExpression] Func<string> mSExcelOpenWorkbookpassword = null, [WorkflowExpression] Func<bool> mSExcelOpenWorkbookenableEvents = null, [WorkflowExpression] Func<bool> mSExcelOpenWorkbookputHTTPWorkbooksIntoEditMode = null, [WorkflowExpression] Func<bool> mSExcelOpenWorkbookputFilePathWorkbooksIntoEditMode = null)
        {
            SourceExpression.Validate(mSExcelOpenWorkbookworkflow, nameof(mSExcelOpenWorkbookworkflow), required: true);
            SourceExpression.Validate(mSExcelOpenWorkbookhandle, nameof(mSExcelOpenWorkbookhandle), required: false);
            SourceExpression.Validate(mSExcelOpenWorkbookfilename, nameof(mSExcelOpenWorkbookfilename), required: false);
            SourceExpression.Validate(mSExcelOpenWorkbookreadOnly, nameof(mSExcelOpenWorkbookreadOnly), required: false);
            SourceExpression.Validate(mSExcelOpenWorkbookupdateLinks, nameof(mSExcelOpenWorkbookupdateLinks), required: false);
            SourceExpression.Validate(mSExcelOpenWorkbookpassword, nameof(mSExcelOpenWorkbookpassword), required: false);
            SourceExpression.Validate(mSExcelOpenWorkbookenableEvents, nameof(mSExcelOpenWorkbookenableEvents), required: false);
            SourceExpression.Validate(mSExcelOpenWorkbookputHTTPWorkbooksIntoEditMode, nameof(mSExcelOpenWorkbookputHTTPWorkbooksIntoEditMode), required: false);
            SourceExpression.Validate(mSExcelOpenWorkbookputFilePathWorkbooksIntoEditMode, nameof(mSExcelOpenWorkbookputFilePathWorkbooksIntoEditMode), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSExcelOpenWorkbook["Handle"] = SourceExpressionConverter.ConvertToken(mSExcelOpenWorkbookhandle);
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
                    mSExcelOpenWorkbook["Filename"] = SourceExpressionConverter.ConvertToken(mSExcelOpenWorkbookfilename);
                    mSExcelOpenWorkbookpropCount++;
                }

                if (mSExcelOpenWorkbookreadOnly != null)
                {
                    if (mSExcelOpenWorkbookreadOnly != null)
                    {
                        mSExcelOpenWorkbook["ReadOnly"] = SourceExpressionConverter.ConvertToken(mSExcelOpenWorkbookreadOnly);
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
                        mSExcelOpenWorkbook["UpdateLinks"] = SourceExpressionConverter.ConvertToken(mSExcelOpenWorkbookupdateLinks);
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
                    mSExcelOpenWorkbook["Password"] = SourceExpressionConverter.ConvertToken(mSExcelOpenWorkbookpassword);
                    mSExcelOpenWorkbookpropCount++;
                }

                if (mSExcelOpenWorkbookenableEvents != null)
                {
                    if (mSExcelOpenWorkbookenableEvents != null)
                    {
                        mSExcelOpenWorkbook["EnableEvents"] = SourceExpressionConverter.ConvertToken(mSExcelOpenWorkbookenableEvents);
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
                        mSExcelOpenWorkbook["PutHTTPWorkbooksIntoEditMode"] = SourceExpressionConverter.ConvertToken(mSExcelOpenWorkbookputHTTPWorkbooksIntoEditMode);
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
                        mSExcelOpenWorkbook["PutFilePathWorkbooksIntoEditMode"] = SourceExpressionConverter.ConvertToken(mSExcelOpenWorkbookputFilePathWorkbooksIntoEditMode);
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
                mSExcelOpenWorkbook["Workflow"] = SourceExpressionConverter.ConvertToken(mSExcelOpenWorkbookworkflow);
                if (mSExcelOpenWorkbookpropCount > 0)
                {
                    callPayload.Body = mSExcelOpenWorkbook;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MSExcelOpenWorkbookResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelPutWorkbookInEditModeResponse> MSExcelPutWorkbookInEditMode([WorkflowExpression] Func<string> mSExcelPutWorkbookInEditModeworkflow, [WorkflowExpression] Func<int> mSExcelPutWorkbookInEditModehandle = null, [WorkflowExpression] Func<string> mSExcelPutWorkbookInEditModeworkbookName = null, [WorkflowExpression] Func<bool> mSExcelPutWorkbookInEditModeforce = null)
        {
            SourceExpression.Validate(mSExcelPutWorkbookInEditModeworkflow, nameof(mSExcelPutWorkbookInEditModeworkflow), required: true);
            SourceExpression.Validate(mSExcelPutWorkbookInEditModehandle, nameof(mSExcelPutWorkbookInEditModehandle), required: false);
            SourceExpression.Validate(mSExcelPutWorkbookInEditModeworkbookName, nameof(mSExcelPutWorkbookInEditModeworkbookName), required: false);
            SourceExpression.Validate(mSExcelPutWorkbookInEditModeforce, nameof(mSExcelPutWorkbookInEditModeforce), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSExcelPutWorkbookInEditMode["Handle"] = SourceExpressionConverter.ConvertToken(mSExcelPutWorkbookInEditModehandle);
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
                    mSExcelPutWorkbookInEditMode["WorkbookName"] = SourceExpressionConverter.ConvertToken(mSExcelPutWorkbookInEditModeworkbookName);
                    mSExcelPutWorkbookInEditModepropCount++;
                }

                if (mSExcelPutWorkbookInEditModeforce != null)
                {
                    if (mSExcelPutWorkbookInEditModeforce != null)
                    {
                        mSExcelPutWorkbookInEditMode["Force"] = SourceExpressionConverter.ConvertToken(mSExcelPutWorkbookInEditModeforce);
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
                mSExcelPutWorkbookInEditMode["Workflow"] = SourceExpressionConverter.ConvertToken(mSExcelPutWorkbookInEditModeworkflow);
                if (mSExcelPutWorkbookInEditModepropCount > 0)
                {
                    callPayload.Body = mSExcelPutWorkbookInEditMode;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MSExcelPutWorkbookInEditModeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelCreateWorkbookResponse> MSExcelCreateWorkbook([WorkflowExpression] Func<string> mSExcelCreateWorkbookworkflow, [WorkflowExpression] Func<int> mSExcelCreateWorkbookhandle = null)
        {
            SourceExpression.Validate(mSExcelCreateWorkbookworkflow, nameof(mSExcelCreateWorkbookworkflow), required: true);
            SourceExpression.Validate(mSExcelCreateWorkbookhandle, nameof(mSExcelCreateWorkbookhandle), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSExcelCreateWorkbook["Handle"] = SourceExpressionConverter.ConvertToken(mSExcelCreateWorkbookhandle);
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
                mSExcelCreateWorkbook["Workflow"] = SourceExpressionConverter.ConvertToken(mSExcelCreateWorkbookworkflow);
                if (mSExcelCreateWorkbookpropCount > 0)
                {
                    callPayload.Body = mSExcelCreateWorkbook;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MSExcelCreateWorkbookResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelCloseWorkbook([WorkflowExpression] Func<string> mSExcelCloseWorkbookworkflow, [WorkflowExpression] Func<int> mSExcelCloseWorkbookhandle = null, [WorkflowExpression] Func<string> mSExcelCloseWorkbookworkbookName = null, [WorkflowExpression] Func<bool> mSExcelCloseWorkbooksaveData = null)
        {
            SourceExpression.Validate(mSExcelCloseWorkbookworkflow, nameof(mSExcelCloseWorkbookworkflow), required: true);
            SourceExpression.Validate(mSExcelCloseWorkbookhandle, nameof(mSExcelCloseWorkbookhandle), required: false);
            SourceExpression.Validate(mSExcelCloseWorkbookworkbookName, nameof(mSExcelCloseWorkbookworkbookName), required: false);
            SourceExpression.Validate(mSExcelCloseWorkbooksaveData, nameof(mSExcelCloseWorkbooksaveData), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSExcelCloseWorkbook["Handle"] = SourceExpressionConverter.ConvertToken(mSExcelCloseWorkbookhandle);
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
                    mSExcelCloseWorkbook["WorkbookName"] = SourceExpressionConverter.ConvertToken(mSExcelCloseWorkbookworkbookName);
                    mSExcelCloseWorkbookpropCount++;
                }

                if (mSExcelCloseWorkbooksaveData != null)
                {
                    if (mSExcelCloseWorkbooksaveData != null)
                    {
                        mSExcelCloseWorkbook["SaveData"] = SourceExpressionConverter.ConvertToken(mSExcelCloseWorkbooksaveData);
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
                mSExcelCloseWorkbook["Workflow"] = SourceExpressionConverter.ConvertToken(mSExcelCloseWorkbookworkflow);
                if (mSExcelCloseWorkbookpropCount > 0)
                {
                    callPayload.Body = mSExcelCloseWorkbook;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelCloseCurrentWorkbook([WorkflowExpression] Func<string> mSExcelCloseCurrentWorkbookworkflow, [WorkflowExpression] Func<int> mSExcelCloseCurrentWorkbookhandle = null)
        {
            SourceExpression.Validate(mSExcelCloseCurrentWorkbookworkflow, nameof(mSExcelCloseCurrentWorkbookworkflow), required: true);
            SourceExpression.Validate(mSExcelCloseCurrentWorkbookhandle, nameof(mSExcelCloseCurrentWorkbookhandle), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSExcelCloseCurrentWorkbook["Handle"] = SourceExpressionConverter.ConvertToken(mSExcelCloseCurrentWorkbookhandle);
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
                mSExcelCloseCurrentWorkbook["Workflow"] = SourceExpressionConverter.ConvertToken(mSExcelCloseCurrentWorkbookworkflow);
                if (mSExcelCloseCurrentWorkbookpropCount > 0)
                {
                    callPayload.Body = mSExcelCloseCurrentWorkbook;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelGoToCell([WorkflowExpression] Func<string> mSExcelGoToCellcellReference, [WorkflowExpression] Func<string> mSExcelGoToCellworkflow, [WorkflowExpression] Func<int> mSExcelGoToCellhandle = null, [WorkflowExpression] Func<string> mSExcelGoToCellworkbookName = null, [WorkflowExpression] Func<string> mSExcelGoToCellworksheetName = null)
        {
            SourceExpression.Validate(mSExcelGoToCellcellReference, nameof(mSExcelGoToCellcellReference), required: true);
            SourceExpression.Validate(mSExcelGoToCellworkflow, nameof(mSExcelGoToCellworkflow), required: true);
            SourceExpression.Validate(mSExcelGoToCellhandle, nameof(mSExcelGoToCellhandle), required: false);
            SourceExpression.Validate(mSExcelGoToCellworkbookName, nameof(mSExcelGoToCellworkbookName), required: false);
            SourceExpression.Validate(mSExcelGoToCellworksheetName, nameof(mSExcelGoToCellworksheetName), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSExcelGoToCell["Handle"] = SourceExpressionConverter.ConvertToken(mSExcelGoToCellhandle);
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
                    mSExcelGoToCell["WorkbookName"] = SourceExpressionConverter.ConvertToken(mSExcelGoToCellworkbookName);
                    mSExcelGoToCellpropCount++;
                }

                if (mSExcelGoToCellworksheetName != null)
                {
                    mSExcelGoToCell["WorksheetName"] = SourceExpressionConverter.ConvertToken(mSExcelGoToCellworksheetName);
                    mSExcelGoToCellpropCount++;
                }

                mSExcelGoToCellpropCount++;
                mSExcelGoToCell["CellReference"] = SourceExpressionConverter.ConvertToken(mSExcelGoToCellcellReference);
                mSExcelGoToCellpropCount++;
                mSExcelGoToCell["Workflow"] = SourceExpressionConverter.ConvertToken(mSExcelGoToCellworkflow);
                if (mSExcelGoToCellpropCount > 0)
                {
                    callPayload.Body = mSExcelGoToCell;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetCellValueResponse> MSExcelGetCellValue([WorkflowExpression] Func<string> mSExcelGetCellValuecellReference, [WorkflowExpression] Func<string> mSExcelGetCellValueworkflow, [WorkflowExpression] Func<int> mSExcelGetCellValuehandle = null, [WorkflowExpression] Func<string> mSExcelGetCellValueworkbookName = null, [WorkflowExpression] Func<string> mSExcelGetCellValueworksheetName = null)
        {
            SourceExpression.Validate(mSExcelGetCellValuecellReference, nameof(mSExcelGetCellValuecellReference), required: true);
            SourceExpression.Validate(mSExcelGetCellValueworkflow, nameof(mSExcelGetCellValueworkflow), required: true);
            SourceExpression.Validate(mSExcelGetCellValuehandle, nameof(mSExcelGetCellValuehandle), required: false);
            SourceExpression.Validate(mSExcelGetCellValueworkbookName, nameof(mSExcelGetCellValueworkbookName), required: false);
            SourceExpression.Validate(mSExcelGetCellValueworksheetName, nameof(mSExcelGetCellValueworksheetName), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSExcelGetCellValue["Handle"] = SourceExpressionConverter.ConvertToken(mSExcelGetCellValuehandle);
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
                    mSExcelGetCellValue["WorkbookName"] = SourceExpressionConverter.ConvertToken(mSExcelGetCellValueworkbookName);
                    mSExcelGetCellValuepropCount++;
                }

                if (mSExcelGetCellValueworksheetName != null)
                {
                    mSExcelGetCellValue["WorksheetName"] = SourceExpressionConverter.ConvertToken(mSExcelGetCellValueworksheetName);
                    mSExcelGetCellValuepropCount++;
                }

                mSExcelGetCellValuepropCount++;
                mSExcelGetCellValue["CellReference"] = SourceExpressionConverter.ConvertToken(mSExcelGetCellValuecellReference);
                mSExcelGetCellValuepropCount++;
                mSExcelGetCellValue["Workflow"] = SourceExpressionConverter.ConvertToken(mSExcelGetCellValueworkflow);
                if (mSExcelGetCellValuepropCount > 0)
                {
                    callPayload.Body = mSExcelGetCellValue;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MSExcelGetCellValueResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetCellValue2Response> MSExcelGetCellValue2([WorkflowExpression] Func<string> mSExcelGetCellValue2cellReference, [WorkflowExpression] Func<string> mSExcelGetCellValue2workflow, [WorkflowExpression] Func<int> mSExcelGetCellValue2handle = null, [WorkflowExpression] Func<string> mSExcelGetCellValue2workbookName = null, [WorkflowExpression] Func<string> mSExcelGetCellValue2worksheetName = null)
        {
            SourceExpression.Validate(mSExcelGetCellValue2cellReference, nameof(mSExcelGetCellValue2cellReference), required: true);
            SourceExpression.Validate(mSExcelGetCellValue2workflow, nameof(mSExcelGetCellValue2workflow), required: true);
            SourceExpression.Validate(mSExcelGetCellValue2handle, nameof(mSExcelGetCellValue2handle), required: false);
            SourceExpression.Validate(mSExcelGetCellValue2workbookName, nameof(mSExcelGetCellValue2workbookName), required: false);
            SourceExpression.Validate(mSExcelGetCellValue2worksheetName, nameof(mSExcelGetCellValue2worksheetName), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSExcelGetCellValue2["Handle"] = SourceExpressionConverter.ConvertToken(mSExcelGetCellValue2handle);
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
                    mSExcelGetCellValue2["WorkbookName"] = SourceExpressionConverter.ConvertToken(mSExcelGetCellValue2workbookName);
                    mSExcelGetCellValue2propCount++;
                }

                if (mSExcelGetCellValue2worksheetName != null)
                {
                    mSExcelGetCellValue2["WorksheetName"] = SourceExpressionConverter.ConvertToken(mSExcelGetCellValue2worksheetName);
                    mSExcelGetCellValue2propCount++;
                }

                mSExcelGetCellValue2propCount++;
                mSExcelGetCellValue2["CellReference"] = SourceExpressionConverter.ConvertToken(mSExcelGetCellValue2cellReference);
                mSExcelGetCellValue2propCount++;
                mSExcelGetCellValue2["Workflow"] = SourceExpressionConverter.ConvertToken(mSExcelGetCellValue2workflow);
                if (mSExcelGetCellValue2propCount > 0)
                {
                    callPayload.Body = mSExcelGetCellValue2;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MSExcelGetCellValue2Response>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetCellTextResponse> MSExcelGetCellText([WorkflowExpression] Func<string> mSExcelGetCellTextcellReference, [WorkflowExpression] Func<string> mSExcelGetCellTextworkflow, [WorkflowExpression] Func<int> mSExcelGetCellTexthandle = null, [WorkflowExpression] Func<string> mSExcelGetCellTextworkbookName = null, [WorkflowExpression] Func<string> mSExcelGetCellTextworksheetName = null)
        {
            SourceExpression.Validate(mSExcelGetCellTextcellReference, nameof(mSExcelGetCellTextcellReference), required: true);
            SourceExpression.Validate(mSExcelGetCellTextworkflow, nameof(mSExcelGetCellTextworkflow), required: true);
            SourceExpression.Validate(mSExcelGetCellTexthandle, nameof(mSExcelGetCellTexthandle), required: false);
            SourceExpression.Validate(mSExcelGetCellTextworkbookName, nameof(mSExcelGetCellTextworkbookName), required: false);
            SourceExpression.Validate(mSExcelGetCellTextworksheetName, nameof(mSExcelGetCellTextworksheetName), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSExcelGetCellText["Handle"] = SourceExpressionConverter.ConvertToken(mSExcelGetCellTexthandle);
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
                    mSExcelGetCellText["WorkbookName"] = SourceExpressionConverter.ConvertToken(mSExcelGetCellTextworkbookName);
                    mSExcelGetCellTextpropCount++;
                }

                if (mSExcelGetCellTextworksheetName != null)
                {
                    mSExcelGetCellText["WorksheetName"] = SourceExpressionConverter.ConvertToken(mSExcelGetCellTextworksheetName);
                    mSExcelGetCellTextpropCount++;
                }

                mSExcelGetCellTextpropCount++;
                mSExcelGetCellText["CellReference"] = SourceExpressionConverter.ConvertToken(mSExcelGetCellTextcellReference);
                mSExcelGetCellTextpropCount++;
                mSExcelGetCellText["Workflow"] = SourceExpressionConverter.ConvertToken(mSExcelGetCellTextworkflow);
                if (mSExcelGetCellTextpropCount > 0)
                {
                    callPayload.Body = mSExcelGetCellText;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MSExcelGetCellTextResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelSetCellValue([WorkflowExpression] Func<string> mSExcelSetCellValuecellReference, [WorkflowExpression] Func<string> mSExcelSetCellValueworkflow, [WorkflowExpression] Func<int> mSExcelSetCellValuehandle = null, [WorkflowExpression] Func<string> mSExcelSetCellValueworkbookName = null, [WorkflowExpression] Func<string> mSExcelSetCellValueworksheetName = null, [WorkflowExpression] Func<string> mSExcelSetCellValuecellValue = null, [WorkflowExpression] Func<bool> mSExcelSetCellValuecellValueContainsStoredPassword = null)
        {
            SourceExpression.Validate(mSExcelSetCellValuecellReference, nameof(mSExcelSetCellValuecellReference), required: true);
            SourceExpression.Validate(mSExcelSetCellValueworkflow, nameof(mSExcelSetCellValueworkflow), required: true);
            SourceExpression.Validate(mSExcelSetCellValuehandle, nameof(mSExcelSetCellValuehandle), required: false);
            SourceExpression.Validate(mSExcelSetCellValueworkbookName, nameof(mSExcelSetCellValueworkbookName), required: false);
            SourceExpression.Validate(mSExcelSetCellValueworksheetName, nameof(mSExcelSetCellValueworksheetName), required: false);
            SourceExpression.Validate(mSExcelSetCellValuecellValue, nameof(mSExcelSetCellValuecellValue), required: false);
            SourceExpression.Validate(mSExcelSetCellValuecellValueContainsStoredPassword, nameof(mSExcelSetCellValuecellValueContainsStoredPassword), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSExcelSetCellValue["Handle"] = SourceExpressionConverter.ConvertToken(mSExcelSetCellValuehandle);
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
                    mSExcelSetCellValue["WorkbookName"] = SourceExpressionConverter.ConvertToken(mSExcelSetCellValueworkbookName);
                    mSExcelSetCellValuepropCount++;
                }

                if (mSExcelSetCellValueworksheetName != null)
                {
                    mSExcelSetCellValue["WorksheetName"] = SourceExpressionConverter.ConvertToken(mSExcelSetCellValueworksheetName);
                    mSExcelSetCellValuepropCount++;
                }

                mSExcelSetCellValuepropCount++;
                mSExcelSetCellValue["CellReference"] = SourceExpressionConverter.ConvertToken(mSExcelSetCellValuecellReference);
                if (mSExcelSetCellValuecellValue != null)
                {
                    mSExcelSetCellValue["CellValue"] = SourceExpressionConverter.ConvertToken(mSExcelSetCellValuecellValue);
                    mSExcelSetCellValuepropCount++;
                }

                if (mSExcelSetCellValuecellValueContainsStoredPassword != null)
                {
                    if (mSExcelSetCellValuecellValueContainsStoredPassword != null)
                    {
                        mSExcelSetCellValue["CellValueContainsStoredPassword"] = SourceExpressionConverter.ConvertToken(mSExcelSetCellValuecellValueContainsStoredPassword);
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
                mSExcelSetCellValue["Workflow"] = SourceExpressionConverter.ConvertToken(mSExcelSetCellValueworkflow);
                if (mSExcelSetCellValuepropCount > 0)
                {
                    callPayload.Body = mSExcelSetCellValue;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelFindNextCellWithValueResponse> MSExcelFindNextCellWithValue([WorkflowExpression] Func<mSExcelFindNextCellWithValuedirectionInput> mSExcelFindNextCellWithValuedirection, [WorkflowExpression] Func<string> mSExcelFindNextCellWithValuesearchValue, [WorkflowExpression] Func<string> mSExcelFindNextCellWithValueworkflow, [WorkflowExpression] Func<int> mSExcelFindNextCellWithValuehandle = null, [WorkflowExpression] Func<string> mSExcelFindNextCellWithValueworkbookName = null, [WorkflowExpression] Func<string> mSExcelFindNextCellWithValueworksheetName = null, [WorkflowExpression] Func<bool> mSExcelFindNextCellWithValuecaseSensitive = null, [WorkflowExpression] Func<mSExcelFindNextCellWithValuecomparisonTypeInput> mSExcelFindNextCellWithValuecomparisonType = null, [WorkflowExpression] Func<int> mSExcelFindNextCellWithValuemaxCellsToSearch = null, [WorkflowExpression] Func<bool> mSExcelFindNextCellWithValueactivateCell = null)
        {
            SourceExpression.Validate(mSExcelFindNextCellWithValuedirection, nameof(mSExcelFindNextCellWithValuedirection), required: true);
            SourceExpression.Validate(mSExcelFindNextCellWithValuesearchValue, nameof(mSExcelFindNextCellWithValuesearchValue), required: true);
            SourceExpression.Validate(mSExcelFindNextCellWithValueworkflow, nameof(mSExcelFindNextCellWithValueworkflow), required: true);
            SourceExpression.Validate(mSExcelFindNextCellWithValuehandle, nameof(mSExcelFindNextCellWithValuehandle), required: false);
            SourceExpression.Validate(mSExcelFindNextCellWithValueworkbookName, nameof(mSExcelFindNextCellWithValueworkbookName), required: false);
            SourceExpression.Validate(mSExcelFindNextCellWithValueworksheetName, nameof(mSExcelFindNextCellWithValueworksheetName), required: false);
            SourceExpression.Validate(mSExcelFindNextCellWithValuecaseSensitive, nameof(mSExcelFindNextCellWithValuecaseSensitive), required: false);
            SourceExpression.Validate(mSExcelFindNextCellWithValuecomparisonType, nameof(mSExcelFindNextCellWithValuecomparisonType), required: false);
            SourceExpression.Validate(mSExcelFindNextCellWithValuemaxCellsToSearch, nameof(mSExcelFindNextCellWithValuemaxCellsToSearch), required: false);
            SourceExpression.Validate(mSExcelFindNextCellWithValueactivateCell, nameof(mSExcelFindNextCellWithValueactivateCell), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSExcelFindNextCellWithValue["Handle"] = SourceExpressionConverter.ConvertToken(mSExcelFindNextCellWithValuehandle);
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
                    mSExcelFindNextCellWithValue["WorkbookName"] = SourceExpressionConverter.ConvertToken(mSExcelFindNextCellWithValueworkbookName);
                    mSExcelFindNextCellWithValuepropCount++;
                }

                if (mSExcelFindNextCellWithValueworksheetName != null)
                {
                    mSExcelFindNextCellWithValue["WorksheetName"] = SourceExpressionConverter.ConvertToken(mSExcelFindNextCellWithValueworksheetName);
                    mSExcelFindNextCellWithValuepropCount++;
                }

                mSExcelFindNextCellWithValuepropCount++;
                mSExcelFindNextCellWithValue["Direction"] = SourceExpressionConverter.Convert(mSExcelFindNextCellWithValuedirection);
                mSExcelFindNextCellWithValuepropCount++;
                mSExcelFindNextCellWithValue["SearchValue"] = SourceExpressionConverter.ConvertToken(mSExcelFindNextCellWithValuesearchValue);
                if (mSExcelFindNextCellWithValuecaseSensitive != null)
                {
                    if (mSExcelFindNextCellWithValuecaseSensitive != null)
                    {
                        mSExcelFindNextCellWithValue["CaseSensitive"] = SourceExpressionConverter.ConvertToken(mSExcelFindNextCellWithValuecaseSensitive);
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
                    mSExcelFindNextCellWithValue["ComparisonType"] = SourceExpressionConverter.Convert(mSExcelFindNextCellWithValuecomparisonType);
                    mSExcelFindNextCellWithValuepropCount++;
                }

                if (mSExcelFindNextCellWithValuemaxCellsToSearch != null)
                {
                    mSExcelFindNextCellWithValue["MaxCellsToSearch"] = SourceExpressionConverter.ConvertToken(mSExcelFindNextCellWithValuemaxCellsToSearch);
                    mSExcelFindNextCellWithValuepropCount++;
                }

                if (mSExcelFindNextCellWithValueactivateCell != null)
                {
                    if (mSExcelFindNextCellWithValueactivateCell != null)
                    {
                        mSExcelFindNextCellWithValue["ActivateCell"] = SourceExpressionConverter.ConvertToken(mSExcelFindNextCellWithValueactivateCell);
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
                mSExcelFindNextCellWithValue["Workflow"] = SourceExpressionConverter.ConvertToken(mSExcelFindNextCellWithValueworkflow);
                if (mSExcelFindNextCellWithValuepropCount > 0)
                {
                    callPayload.Body = mSExcelFindNextCellWithValue;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MSExcelFindNextCellWithValueResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelFindNextEmptyCellResponse> MSExcelFindNextEmptyCell([WorkflowExpression] Func<mSExcelFindNextEmptyCelldirectionInput> mSExcelFindNextEmptyCelldirection, [WorkflowExpression] Func<string> mSExcelFindNextEmptyCellworkflow, [WorkflowExpression] Func<int> mSExcelFindNextEmptyCellhandle = null, [WorkflowExpression] Func<string> mSExcelFindNextEmptyCellworkbookName = null, [WorkflowExpression] Func<string> mSExcelFindNextEmptyCellworksheetName = null, [WorkflowExpression] Func<bool> mSExcelFindNextEmptyCellactivateCell = null)
        {
            SourceExpression.Validate(mSExcelFindNextEmptyCelldirection, nameof(mSExcelFindNextEmptyCelldirection), required: true);
            SourceExpression.Validate(mSExcelFindNextEmptyCellworkflow, nameof(mSExcelFindNextEmptyCellworkflow), required: true);
            SourceExpression.Validate(mSExcelFindNextEmptyCellhandle, nameof(mSExcelFindNextEmptyCellhandle), required: false);
            SourceExpression.Validate(mSExcelFindNextEmptyCellworkbookName, nameof(mSExcelFindNextEmptyCellworkbookName), required: false);
            SourceExpression.Validate(mSExcelFindNextEmptyCellworksheetName, nameof(mSExcelFindNextEmptyCellworksheetName), required: false);
            SourceExpression.Validate(mSExcelFindNextEmptyCellactivateCell, nameof(mSExcelFindNextEmptyCellactivateCell), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSExcelFindNextEmptyCell["Handle"] = SourceExpressionConverter.ConvertToken(mSExcelFindNextEmptyCellhandle);
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
                    mSExcelFindNextEmptyCell["WorkbookName"] = SourceExpressionConverter.ConvertToken(mSExcelFindNextEmptyCellworkbookName);
                    mSExcelFindNextEmptyCellpropCount++;
                }

                if (mSExcelFindNextEmptyCellworksheetName != null)
                {
                    mSExcelFindNextEmptyCell["WorksheetName"] = SourceExpressionConverter.ConvertToken(mSExcelFindNextEmptyCellworksheetName);
                    mSExcelFindNextEmptyCellpropCount++;
                }

                mSExcelFindNextEmptyCellpropCount++;
                mSExcelFindNextEmptyCell["Direction"] = SourceExpressionConverter.Convert(mSExcelFindNextEmptyCelldirection);
                if (mSExcelFindNextEmptyCellactivateCell != null)
                {
                    if (mSExcelFindNextEmptyCellactivateCell != null)
                    {
                        mSExcelFindNextEmptyCell["ActivateCell"] = SourceExpressionConverter.ConvertToken(mSExcelFindNextEmptyCellactivateCell);
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
                mSExcelFindNextEmptyCell["Workflow"] = SourceExpressionConverter.ConvertToken(mSExcelFindNextEmptyCellworkflow);
                if (mSExcelFindNextEmptyCellpropCount > 0)
                {
                    callPayload.Body = mSExcelFindNextEmptyCell;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MSExcelFindNextEmptyCellResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGotoNextEmptyCellLeftResponse> MSExcelGotoNextEmptyCellLeft([WorkflowExpression] Func<string> mSExcelGotoNextEmptyCellLeftworkflow, [WorkflowExpression] Func<int> mSExcelGotoNextEmptyCellLefthandle = null, [WorkflowExpression] Func<string> mSExcelGotoNextEmptyCellLeftworkbookName = null, [WorkflowExpression] Func<string> mSExcelGotoNextEmptyCellLeftworksheetName = null)
        {
            SourceExpression.Validate(mSExcelGotoNextEmptyCellLeftworkflow, nameof(mSExcelGotoNextEmptyCellLeftworkflow), required: true);
            SourceExpression.Validate(mSExcelGotoNextEmptyCellLefthandle, nameof(mSExcelGotoNextEmptyCellLefthandle), required: false);
            SourceExpression.Validate(mSExcelGotoNextEmptyCellLeftworkbookName, nameof(mSExcelGotoNextEmptyCellLeftworkbookName), required: false);
            SourceExpression.Validate(mSExcelGotoNextEmptyCellLeftworksheetName, nameof(mSExcelGotoNextEmptyCellLeftworksheetName), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSExcelGotoNextEmptyCellLeft["Handle"] = SourceExpressionConverter.ConvertToken(mSExcelGotoNextEmptyCellLefthandle);
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
                    mSExcelGotoNextEmptyCellLeft["WorkbookName"] = SourceExpressionConverter.ConvertToken(mSExcelGotoNextEmptyCellLeftworkbookName);
                    mSExcelGotoNextEmptyCellLeftpropCount++;
                }

                if (mSExcelGotoNextEmptyCellLeftworksheetName != null)
                {
                    mSExcelGotoNextEmptyCellLeft["WorksheetName"] = SourceExpressionConverter.ConvertToken(mSExcelGotoNextEmptyCellLeftworksheetName);
                    mSExcelGotoNextEmptyCellLeftpropCount++;
                }

                mSExcelGotoNextEmptyCellLeftpropCount++;
                mSExcelGotoNextEmptyCellLeft["Workflow"] = SourceExpressionConverter.ConvertToken(mSExcelGotoNextEmptyCellLeftworkflow);
                if (mSExcelGotoNextEmptyCellLeftpropCount > 0)
                {
                    callPayload.Body = mSExcelGotoNextEmptyCellLeft;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MSExcelGotoNextEmptyCellLeftResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGotoNextEmptyCellRightResponse> MSExcelGotoNextEmptyCellRight([WorkflowExpression] Func<string> mSExcelGotoNextEmptyCellRightworkflow, [WorkflowExpression] Func<int> mSExcelGotoNextEmptyCellRighthandle = null, [WorkflowExpression] Func<string> mSExcelGotoNextEmptyCellRightworkbookName = null, [WorkflowExpression] Func<string> mSExcelGotoNextEmptyCellRightworksheetName = null)
        {
            SourceExpression.Validate(mSExcelGotoNextEmptyCellRightworkflow, nameof(mSExcelGotoNextEmptyCellRightworkflow), required: true);
            SourceExpression.Validate(mSExcelGotoNextEmptyCellRighthandle, nameof(mSExcelGotoNextEmptyCellRighthandle), required: false);
            SourceExpression.Validate(mSExcelGotoNextEmptyCellRightworkbookName, nameof(mSExcelGotoNextEmptyCellRightworkbookName), required: false);
            SourceExpression.Validate(mSExcelGotoNextEmptyCellRightworksheetName, nameof(mSExcelGotoNextEmptyCellRightworksheetName), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSExcelGotoNextEmptyCellRight["Handle"] = SourceExpressionConverter.ConvertToken(mSExcelGotoNextEmptyCellRighthandle);
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
                    mSExcelGotoNextEmptyCellRight["WorkbookName"] = SourceExpressionConverter.ConvertToken(mSExcelGotoNextEmptyCellRightworkbookName);
                    mSExcelGotoNextEmptyCellRightpropCount++;
                }

                if (mSExcelGotoNextEmptyCellRightworksheetName != null)
                {
                    mSExcelGotoNextEmptyCellRight["WorksheetName"] = SourceExpressionConverter.ConvertToken(mSExcelGotoNextEmptyCellRightworksheetName);
                    mSExcelGotoNextEmptyCellRightpropCount++;
                }

                mSExcelGotoNextEmptyCellRightpropCount++;
                mSExcelGotoNextEmptyCellRight["Workflow"] = SourceExpressionConverter.ConvertToken(mSExcelGotoNextEmptyCellRightworkflow);
                if (mSExcelGotoNextEmptyCellRightpropCount > 0)
                {
                    callPayload.Body = mSExcelGotoNextEmptyCellRight;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MSExcelGotoNextEmptyCellRightResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGotoNextEmptyCellUpResponse> MSExcelGotoNextEmptyCellUp([WorkflowExpression] Func<string> mSExcelGotoNextEmptyCellUpworkflow, [WorkflowExpression] Func<int> mSExcelGotoNextEmptyCellUphandle = null, [WorkflowExpression] Func<string> mSExcelGotoNextEmptyCellUpworkbookName = null, [WorkflowExpression] Func<string> mSExcelGotoNextEmptyCellUpworksheetName = null)
        {
            SourceExpression.Validate(mSExcelGotoNextEmptyCellUpworkflow, nameof(mSExcelGotoNextEmptyCellUpworkflow), required: true);
            SourceExpression.Validate(mSExcelGotoNextEmptyCellUphandle, nameof(mSExcelGotoNextEmptyCellUphandle), required: false);
            SourceExpression.Validate(mSExcelGotoNextEmptyCellUpworkbookName, nameof(mSExcelGotoNextEmptyCellUpworkbookName), required: false);
            SourceExpression.Validate(mSExcelGotoNextEmptyCellUpworksheetName, nameof(mSExcelGotoNextEmptyCellUpworksheetName), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSExcelGotoNextEmptyCellUp["Handle"] = SourceExpressionConverter.ConvertToken(mSExcelGotoNextEmptyCellUphandle);
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
                    mSExcelGotoNextEmptyCellUp["WorkbookName"] = SourceExpressionConverter.ConvertToken(mSExcelGotoNextEmptyCellUpworkbookName);
                    mSExcelGotoNextEmptyCellUppropCount++;
                }

                if (mSExcelGotoNextEmptyCellUpworksheetName != null)
                {
                    mSExcelGotoNextEmptyCellUp["WorksheetName"] = SourceExpressionConverter.ConvertToken(mSExcelGotoNextEmptyCellUpworksheetName);
                    mSExcelGotoNextEmptyCellUppropCount++;
                }

                mSExcelGotoNextEmptyCellUppropCount++;
                mSExcelGotoNextEmptyCellUp["Workflow"] = SourceExpressionConverter.ConvertToken(mSExcelGotoNextEmptyCellUpworkflow);
                if (mSExcelGotoNextEmptyCellUppropCount > 0)
                {
                    callPayload.Body = mSExcelGotoNextEmptyCellUp;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MSExcelGotoNextEmptyCellUpResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGotoNextEmptyCellDownResponse> MSExcelGotoNextEmptyCellDown([WorkflowExpression] Func<string> mSExcelGotoNextEmptyCellDownworkflow, [WorkflowExpression] Func<int> mSExcelGotoNextEmptyCellDownhandle = null, [WorkflowExpression] Func<string> mSExcelGotoNextEmptyCellDownworkbookName = null, [WorkflowExpression] Func<string> mSExcelGotoNextEmptyCellDownworksheetName = null)
        {
            SourceExpression.Validate(mSExcelGotoNextEmptyCellDownworkflow, nameof(mSExcelGotoNextEmptyCellDownworkflow), required: true);
            SourceExpression.Validate(mSExcelGotoNextEmptyCellDownhandle, nameof(mSExcelGotoNextEmptyCellDownhandle), required: false);
            SourceExpression.Validate(mSExcelGotoNextEmptyCellDownworkbookName, nameof(mSExcelGotoNextEmptyCellDownworkbookName), required: false);
            SourceExpression.Validate(mSExcelGotoNextEmptyCellDownworksheetName, nameof(mSExcelGotoNextEmptyCellDownworksheetName), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSExcelGotoNextEmptyCellDown["Handle"] = SourceExpressionConverter.ConvertToken(mSExcelGotoNextEmptyCellDownhandle);
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
                    mSExcelGotoNextEmptyCellDown["WorkbookName"] = SourceExpressionConverter.ConvertToken(mSExcelGotoNextEmptyCellDownworkbookName);
                    mSExcelGotoNextEmptyCellDownpropCount++;
                }

                if (mSExcelGotoNextEmptyCellDownworksheetName != null)
                {
                    mSExcelGotoNextEmptyCellDown["WorksheetName"] = SourceExpressionConverter.ConvertToken(mSExcelGotoNextEmptyCellDownworksheetName);
                    mSExcelGotoNextEmptyCellDownpropCount++;
                }

                mSExcelGotoNextEmptyCellDownpropCount++;
                mSExcelGotoNextEmptyCellDown["Workflow"] = SourceExpressionConverter.ConvertToken(mSExcelGotoNextEmptyCellDownworkflow);
                if (mSExcelGotoNextEmptyCellDownpropCount > 0)
                {
                    callPayload.Body = mSExcelGotoNextEmptyCellDown;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MSExcelGotoNextEmptyCellDownResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelSaveWorkbookResponse> MSExcelSaveWorkbook([WorkflowExpression] Func<string> mSExcelSaveWorkbookworkflow, [WorkflowExpression] Func<int> mSExcelSaveWorkbookhandle = null, [WorkflowExpression] Func<string> mSExcelSaveWorkbookworkbookName = null)
        {
            SourceExpression.Validate(mSExcelSaveWorkbookworkflow, nameof(mSExcelSaveWorkbookworkflow), required: true);
            SourceExpression.Validate(mSExcelSaveWorkbookhandle, nameof(mSExcelSaveWorkbookhandle), required: false);
            SourceExpression.Validate(mSExcelSaveWorkbookworkbookName, nameof(mSExcelSaveWorkbookworkbookName), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSExcelSaveWorkbook["Handle"] = SourceExpressionConverter.ConvertToken(mSExcelSaveWorkbookhandle);
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
                    mSExcelSaveWorkbook["WorkbookName"] = SourceExpressionConverter.ConvertToken(mSExcelSaveWorkbookworkbookName);
                    mSExcelSaveWorkbookpropCount++;
                }

                mSExcelSaveWorkbookpropCount++;
                mSExcelSaveWorkbook["Workflow"] = SourceExpressionConverter.ConvertToken(mSExcelSaveWorkbookworkflow);
                if (mSExcelSaveWorkbookpropCount > 0)
                {
                    callPayload.Body = mSExcelSaveWorkbook;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MSExcelSaveWorkbookResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelSaveWorkbookAsResponse> MSExcelSaveWorkbookAs([WorkflowExpression] Func<string> mSExcelSaveWorkbookAssaveFilename, [WorkflowExpression] Func<string> mSExcelSaveWorkbookAsworkflow, [WorkflowExpression] Func<int> mSExcelSaveWorkbookAshandle = null, [WorkflowExpression] Func<string> mSExcelSaveWorkbookAsworkbookName = null, [WorkflowExpression] Func<bool> mSExcelSaveWorkbookAsdeleteExistingSaveFilename = null, [WorkflowExpression] Func<mSExcelSaveWorkbookAsexcelFileFormatInput> mSExcelSaveWorkbookAsexcelFileFormat = null)
        {
            SourceExpression.Validate(mSExcelSaveWorkbookAssaveFilename, nameof(mSExcelSaveWorkbookAssaveFilename), required: true);
            SourceExpression.Validate(mSExcelSaveWorkbookAsworkflow, nameof(mSExcelSaveWorkbookAsworkflow), required: true);
            SourceExpression.Validate(mSExcelSaveWorkbookAshandle, nameof(mSExcelSaveWorkbookAshandle), required: false);
            SourceExpression.Validate(mSExcelSaveWorkbookAsworkbookName, nameof(mSExcelSaveWorkbookAsworkbookName), required: false);
            SourceExpression.Validate(mSExcelSaveWorkbookAsdeleteExistingSaveFilename, nameof(mSExcelSaveWorkbookAsdeleteExistingSaveFilename), required: false);
            SourceExpression.Validate(mSExcelSaveWorkbookAsexcelFileFormat, nameof(mSExcelSaveWorkbookAsexcelFileFormat), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSExcelSaveWorkbookAs["Handle"] = SourceExpressionConverter.ConvertToken(mSExcelSaveWorkbookAshandle);
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
                    mSExcelSaveWorkbookAs["WorkbookName"] = SourceExpressionConverter.ConvertToken(mSExcelSaveWorkbookAsworkbookName);
                    mSExcelSaveWorkbookAspropCount++;
                }

                mSExcelSaveWorkbookAspropCount++;
                mSExcelSaveWorkbookAs["SaveFilename"] = SourceExpressionConverter.ConvertToken(mSExcelSaveWorkbookAssaveFilename);
                if (mSExcelSaveWorkbookAsdeleteExistingSaveFilename != null)
                {
                    if (mSExcelSaveWorkbookAsdeleteExistingSaveFilename != null)
                    {
                        mSExcelSaveWorkbookAs["DeleteExistingSaveFilename"] = SourceExpressionConverter.ConvertToken(mSExcelSaveWorkbookAsdeleteExistingSaveFilename);
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
                        mSExcelSaveWorkbookAs["ExcelFileFormat"] = SourceExpressionConverter.Convert(mSExcelSaveWorkbookAsexcelFileFormat);
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
                mSExcelSaveWorkbookAs["Workflow"] = SourceExpressionConverter.ConvertToken(mSExcelSaveWorkbookAsworkflow);
                if (mSExcelSaveWorkbookAspropCount > 0)
                {
                    callPayload.Body = mSExcelSaveWorkbookAs;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MSExcelSaveWorkbookAsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelSaveWorkbookAsCSVResponse> MSExcelSaveWorkbookAsCSV([WorkflowExpression] Func<string> mSExcelSaveWorkbookAsCSVsaveFilename, [WorkflowExpression] Func<string> mSExcelSaveWorkbookAsCSVworkflow, [WorkflowExpression] Func<int> mSExcelSaveWorkbookAsCSVhandle = null, [WorkflowExpression] Func<string> mSExcelSaveWorkbookAsCSVworkbookName = null, [WorkflowExpression] Func<bool> mSExcelSaveWorkbookAsCSVdeleteExistingSaveFilename = null)
        {
            SourceExpression.Validate(mSExcelSaveWorkbookAsCSVsaveFilename, nameof(mSExcelSaveWorkbookAsCSVsaveFilename), required: true);
            SourceExpression.Validate(mSExcelSaveWorkbookAsCSVworkflow, nameof(mSExcelSaveWorkbookAsCSVworkflow), required: true);
            SourceExpression.Validate(mSExcelSaveWorkbookAsCSVhandle, nameof(mSExcelSaveWorkbookAsCSVhandle), required: false);
            SourceExpression.Validate(mSExcelSaveWorkbookAsCSVworkbookName, nameof(mSExcelSaveWorkbookAsCSVworkbookName), required: false);
            SourceExpression.Validate(mSExcelSaveWorkbookAsCSVdeleteExistingSaveFilename, nameof(mSExcelSaveWorkbookAsCSVdeleteExistingSaveFilename), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSExcelSaveWorkbookAsCSV["Handle"] = SourceExpressionConverter.ConvertToken(mSExcelSaveWorkbookAsCSVhandle);
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
                    mSExcelSaveWorkbookAsCSV["WorkbookName"] = SourceExpressionConverter.ConvertToken(mSExcelSaveWorkbookAsCSVworkbookName);
                    mSExcelSaveWorkbookAsCSVpropCount++;
                }

                mSExcelSaveWorkbookAsCSVpropCount++;
                mSExcelSaveWorkbookAsCSV["SaveFilename"] = SourceExpressionConverter.ConvertToken(mSExcelSaveWorkbookAsCSVsaveFilename);
                if (mSExcelSaveWorkbookAsCSVdeleteExistingSaveFilename != null)
                {
                    if (mSExcelSaveWorkbookAsCSVdeleteExistingSaveFilename != null)
                    {
                        mSExcelSaveWorkbookAsCSV["DeleteExistingSaveFilename"] = SourceExpressionConverter.ConvertToken(mSExcelSaveWorkbookAsCSVdeleteExistingSaveFilename);
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
                mSExcelSaveWorkbookAsCSV["Workflow"] = SourceExpressionConverter.ConvertToken(mSExcelSaveWorkbookAsCSVworkflow);
                if (mSExcelSaveWorkbookAsCSVpropCount > 0)
                {
                    callPayload.Body = mSExcelSaveWorkbookAsCSV;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MSExcelSaveWorkbookAsCSVResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelSaveWorkbookAsWithPasswordResponse> MSExcelSaveWorkbookAsWithPassword([WorkflowExpression] Func<string> mSExcelSaveWorkbookAsWithPasswordsaveFilename, [WorkflowExpression] Func<string> mSExcelSaveWorkbookAsWithPasswordpassword, [WorkflowExpression] Func<string> mSExcelSaveWorkbookAsWithPasswordworkflow, [WorkflowExpression] Func<int> mSExcelSaveWorkbookAsWithPasswordhandle = null, [WorkflowExpression] Func<string> mSExcelSaveWorkbookAsWithPasswordworkbookName = null, [WorkflowExpression] Func<bool> mSExcelSaveWorkbookAsWithPassworddeleteExistingSaveFilename = null, [WorkflowExpression] Func<mSExcelSaveWorkbookAsWithPasswordexcelFileFormatInput> mSExcelSaveWorkbookAsWithPasswordexcelFileFormat = null)
        {
            SourceExpression.Validate(mSExcelSaveWorkbookAsWithPasswordsaveFilename, nameof(mSExcelSaveWorkbookAsWithPasswordsaveFilename), required: true);
            SourceExpression.Validate(mSExcelSaveWorkbookAsWithPasswordpassword, nameof(mSExcelSaveWorkbookAsWithPasswordpassword), required: true);
            SourceExpression.Validate(mSExcelSaveWorkbookAsWithPasswordworkflow, nameof(mSExcelSaveWorkbookAsWithPasswordworkflow), required: true);
            SourceExpression.Validate(mSExcelSaveWorkbookAsWithPasswordhandle, nameof(mSExcelSaveWorkbookAsWithPasswordhandle), required: false);
            SourceExpression.Validate(mSExcelSaveWorkbookAsWithPasswordworkbookName, nameof(mSExcelSaveWorkbookAsWithPasswordworkbookName), required: false);
            SourceExpression.Validate(mSExcelSaveWorkbookAsWithPassworddeleteExistingSaveFilename, nameof(mSExcelSaveWorkbookAsWithPassworddeleteExistingSaveFilename), required: false);
            SourceExpression.Validate(mSExcelSaveWorkbookAsWithPasswordexcelFileFormat, nameof(mSExcelSaveWorkbookAsWithPasswordexcelFileFormat), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSExcelSaveWorkbookAsWithPassword["Handle"] = SourceExpressionConverter.ConvertToken(mSExcelSaveWorkbookAsWithPasswordhandle);
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
                    mSExcelSaveWorkbookAsWithPassword["WorkbookName"] = SourceExpressionConverter.ConvertToken(mSExcelSaveWorkbookAsWithPasswordworkbookName);
                    mSExcelSaveWorkbookAsWithPasswordpropCount++;
                }

                mSExcelSaveWorkbookAsWithPasswordpropCount++;
                mSExcelSaveWorkbookAsWithPassword["SaveFilename"] = SourceExpressionConverter.ConvertToken(mSExcelSaveWorkbookAsWithPasswordsaveFilename);
                mSExcelSaveWorkbookAsWithPasswordpropCount++;
                mSExcelSaveWorkbookAsWithPassword["Password"] = SourceExpressionConverter.ConvertToken(mSExcelSaveWorkbookAsWithPasswordpassword);
                if (mSExcelSaveWorkbookAsWithPassworddeleteExistingSaveFilename != null)
                {
                    if (mSExcelSaveWorkbookAsWithPassworddeleteExistingSaveFilename != null)
                    {
                        mSExcelSaveWorkbookAsWithPassword["DeleteExistingSaveFilename"] = SourceExpressionConverter.ConvertToken(mSExcelSaveWorkbookAsWithPassworddeleteExistingSaveFilename);
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
                        mSExcelSaveWorkbookAsWithPassword["ExcelFileFormat"] = SourceExpressionConverter.Convert(mSExcelSaveWorkbookAsWithPasswordexcelFileFormat);
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
                mSExcelSaveWorkbookAsWithPassword["Workflow"] = SourceExpressionConverter.ConvertToken(mSExcelSaveWorkbookAsWithPasswordworkflow);
                if (mSExcelSaveWorkbookAsWithPasswordpropCount > 0)
                {
                    callPayload.Body = mSExcelSaveWorkbookAsWithPassword;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MSExcelSaveWorkbookAsWithPasswordResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelSaveCurrentWorkbookResponse> MSExcelSaveCurrentWorkbook([WorkflowExpression] Func<string> mSExcelSaveCurrentWorkbookworkflow, [WorkflowExpression] Func<int> mSExcelSaveCurrentWorkbookhandle = null)
        {
            SourceExpression.Validate(mSExcelSaveCurrentWorkbookworkflow, nameof(mSExcelSaveCurrentWorkbookworkflow), required: true);
            SourceExpression.Validate(mSExcelSaveCurrentWorkbookhandle, nameof(mSExcelSaveCurrentWorkbookhandle), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSExcelSaveCurrentWorkbook["Handle"] = SourceExpressionConverter.ConvertToken(mSExcelSaveCurrentWorkbookhandle);
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
                mSExcelSaveCurrentWorkbook["Workflow"] = SourceExpressionConverter.ConvertToken(mSExcelSaveCurrentWorkbookworkflow);
                if (mSExcelSaveCurrentWorkbookpropCount > 0)
                {
                    callPayload.Body = mSExcelSaveCurrentWorkbook;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MSExcelSaveCurrentWorkbookResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelSaveCurrentWorkbookAsResponse> MSExcelSaveCurrentWorkbookAs([WorkflowExpression] Func<string> mSExcelSaveCurrentWorkbookAsworkflow, [WorkflowExpression] Func<int> mSExcelSaveCurrentWorkbookAshandle = null, [WorkflowExpression] Func<string> mSExcelSaveCurrentWorkbookAssaveFilename = null, [WorkflowExpression] Func<bool> mSExcelSaveCurrentWorkbookAsdeleteExistingSaveFilename = null, [WorkflowExpression] Func<mSExcelSaveCurrentWorkbookAsexcelFileFormatInput> mSExcelSaveCurrentWorkbookAsexcelFileFormat = null)
        {
            SourceExpression.Validate(mSExcelSaveCurrentWorkbookAsworkflow, nameof(mSExcelSaveCurrentWorkbookAsworkflow), required: true);
            SourceExpression.Validate(mSExcelSaveCurrentWorkbookAshandle, nameof(mSExcelSaveCurrentWorkbookAshandle), required: false);
            SourceExpression.Validate(mSExcelSaveCurrentWorkbookAssaveFilename, nameof(mSExcelSaveCurrentWorkbookAssaveFilename), required: false);
            SourceExpression.Validate(mSExcelSaveCurrentWorkbookAsdeleteExistingSaveFilename, nameof(mSExcelSaveCurrentWorkbookAsdeleteExistingSaveFilename), required: false);
            SourceExpression.Validate(mSExcelSaveCurrentWorkbookAsexcelFileFormat, nameof(mSExcelSaveCurrentWorkbookAsexcelFileFormat), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSExcelSaveCurrentWorkbookAs["Handle"] = SourceExpressionConverter.ConvertToken(mSExcelSaveCurrentWorkbookAshandle);
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
                    mSExcelSaveCurrentWorkbookAs["SaveFilename"] = SourceExpressionConverter.ConvertToken(mSExcelSaveCurrentWorkbookAssaveFilename);
                    mSExcelSaveCurrentWorkbookAspropCount++;
                }

                if (mSExcelSaveCurrentWorkbookAsdeleteExistingSaveFilename != null)
                {
                    if (mSExcelSaveCurrentWorkbookAsdeleteExistingSaveFilename != null)
                    {
                        mSExcelSaveCurrentWorkbookAs["DeleteExistingSaveFilename"] = SourceExpressionConverter.ConvertToken(mSExcelSaveCurrentWorkbookAsdeleteExistingSaveFilename);
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
                        mSExcelSaveCurrentWorkbookAs["ExcelFileFormat"] = SourceExpressionConverter.Convert(mSExcelSaveCurrentWorkbookAsexcelFileFormat);
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
                mSExcelSaveCurrentWorkbookAs["Workflow"] = SourceExpressionConverter.ConvertToken(mSExcelSaveCurrentWorkbookAsworkflow);
                if (mSExcelSaveCurrentWorkbookAspropCount > 0)
                {
                    callPayload.Body = mSExcelSaveCurrentWorkbookAs;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MSExcelSaveCurrentWorkbookAsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelSaveCurrentWorkbookAsCSVResponse> MSExcelSaveCurrentWorkbookAsCSV([WorkflowExpression] Func<string> mSExcelSaveCurrentWorkbookAsCSVsaveFilename, [WorkflowExpression] Func<string> mSExcelSaveCurrentWorkbookAsCSVworkflow, [WorkflowExpression] Func<int> mSExcelSaveCurrentWorkbookAsCSVhandle = null, [WorkflowExpression] Func<bool> mSExcelSaveCurrentWorkbookAsCSVdeleteExistingSaveFilename = null)
        {
            SourceExpression.Validate(mSExcelSaveCurrentWorkbookAsCSVsaveFilename, nameof(mSExcelSaveCurrentWorkbookAsCSVsaveFilename), required: true);
            SourceExpression.Validate(mSExcelSaveCurrentWorkbookAsCSVworkflow, nameof(mSExcelSaveCurrentWorkbookAsCSVworkflow), required: true);
            SourceExpression.Validate(mSExcelSaveCurrentWorkbookAsCSVhandle, nameof(mSExcelSaveCurrentWorkbookAsCSVhandle), required: false);
            SourceExpression.Validate(mSExcelSaveCurrentWorkbookAsCSVdeleteExistingSaveFilename, nameof(mSExcelSaveCurrentWorkbookAsCSVdeleteExistingSaveFilename), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSExcelSaveCurrentWorkbookAsCSV["Handle"] = SourceExpressionConverter.ConvertToken(mSExcelSaveCurrentWorkbookAsCSVhandle);
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
                mSExcelSaveCurrentWorkbookAsCSV["SaveFilename"] = SourceExpressionConverter.ConvertToken(mSExcelSaveCurrentWorkbookAsCSVsaveFilename);
                if (mSExcelSaveCurrentWorkbookAsCSVdeleteExistingSaveFilename != null)
                {
                    if (mSExcelSaveCurrentWorkbookAsCSVdeleteExistingSaveFilename != null)
                    {
                        mSExcelSaveCurrentWorkbookAsCSV["DeleteExistingSaveFilename"] = SourceExpressionConverter.ConvertToken(mSExcelSaveCurrentWorkbookAsCSVdeleteExistingSaveFilename);
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
                mSExcelSaveCurrentWorkbookAsCSV["Workflow"] = SourceExpressionConverter.ConvertToken(mSExcelSaveCurrentWorkbookAsCSVworkflow);
                if (mSExcelSaveCurrentWorkbookAsCSVpropCount > 0)
                {
                    callPayload.Body = mSExcelSaveCurrentWorkbookAsCSV;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MSExcelSaveCurrentWorkbookAsCSVResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetWorksheetNamesResponse> MSExcelGetWorksheetNames([WorkflowExpression] Func<string> mSExcelGetWorksheetNamesworkflow, [WorkflowExpression] Func<int> mSExcelGetWorksheetNameshandle = null, [WorkflowExpression] Func<string> mSExcelGetWorksheetNamesworkbookName = null)
        {
            SourceExpression.Validate(mSExcelGetWorksheetNamesworkflow, nameof(mSExcelGetWorksheetNamesworkflow), required: true);
            SourceExpression.Validate(mSExcelGetWorksheetNameshandle, nameof(mSExcelGetWorksheetNameshandle), required: false);
            SourceExpression.Validate(mSExcelGetWorksheetNamesworkbookName, nameof(mSExcelGetWorksheetNamesworkbookName), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSExcelGetWorksheetNames["Handle"] = SourceExpressionConverter.ConvertToken(mSExcelGetWorksheetNameshandle);
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
                    mSExcelGetWorksheetNames["WorkbookName"] = SourceExpressionConverter.ConvertToken(mSExcelGetWorksheetNamesworkbookName);
                    mSExcelGetWorksheetNamespropCount++;
                }

                mSExcelGetWorksheetNamespropCount++;
                mSExcelGetWorksheetNames["Workflow"] = SourceExpressionConverter.ConvertToken(mSExcelGetWorksheetNamesworkflow);
                if (mSExcelGetWorksheetNamespropCount > 0)
                {
                    callPayload.Body = mSExcelGetWorksheetNames;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MSExcelGetWorksheetNamesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetWorksheetNameResponse> MSExcelGetWorksheetName([WorkflowExpression] Func<string> mSExcelGetWorksheetNameworkflow, [WorkflowExpression] Func<int> mSExcelGetWorksheetNamehandle = null, [WorkflowExpression] Func<string> mSExcelGetWorksheetNameworkbookName = null, [WorkflowExpression] Func<int> mSExcelGetWorksheetNameposition = null)
        {
            SourceExpression.Validate(mSExcelGetWorksheetNameworkflow, nameof(mSExcelGetWorksheetNameworkflow), required: true);
            SourceExpression.Validate(mSExcelGetWorksheetNamehandle, nameof(mSExcelGetWorksheetNamehandle), required: false);
            SourceExpression.Validate(mSExcelGetWorksheetNameworkbookName, nameof(mSExcelGetWorksheetNameworkbookName), required: false);
            SourceExpression.Validate(mSExcelGetWorksheetNameposition, nameof(mSExcelGetWorksheetNameposition), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSExcelGetWorksheetName["Handle"] = SourceExpressionConverter.ConvertToken(mSExcelGetWorksheetNamehandle);
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
                    mSExcelGetWorksheetName["WorkbookName"] = SourceExpressionConverter.ConvertToken(mSExcelGetWorksheetNameworkbookName);
                    mSExcelGetWorksheetNamepropCount++;
                }

                if (mSExcelGetWorksheetNameposition != null)
                {
                    mSExcelGetWorksheetName["Position"] = SourceExpressionConverter.ConvertToken(mSExcelGetWorksheetNameposition);
                    mSExcelGetWorksheetNamepropCount++;
                }

                mSExcelGetWorksheetNamepropCount++;
                mSExcelGetWorksheetName["Workflow"] = SourceExpressionConverter.ConvertToken(mSExcelGetWorksheetNameworkflow);
                if (mSExcelGetWorksheetNamepropCount > 0)
                {
                    callPayload.Body = mSExcelGetWorksheetName;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MSExcelGetWorksheetNameResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelActivateWorksheet([WorkflowExpression] Func<string> mSExcelActivateWorksheetworkflow, [WorkflowExpression] Func<int> mSExcelActivateWorksheethandle = null, [WorkflowExpression] Func<string> mSExcelActivateWorksheetworkbookName = null, [WorkflowExpression] Func<string> mSExcelActivateWorksheetworksheetName = null, [WorkflowExpression] Func<bool> mSExcelActivateWorksheetcreateIfMissing = null)
        {
            SourceExpression.Validate(mSExcelActivateWorksheetworkflow, nameof(mSExcelActivateWorksheetworkflow), required: true);
            SourceExpression.Validate(mSExcelActivateWorksheethandle, nameof(mSExcelActivateWorksheethandle), required: false);
            SourceExpression.Validate(mSExcelActivateWorksheetworkbookName, nameof(mSExcelActivateWorksheetworkbookName), required: false);
            SourceExpression.Validate(mSExcelActivateWorksheetworksheetName, nameof(mSExcelActivateWorksheetworksheetName), required: false);
            SourceExpression.Validate(mSExcelActivateWorksheetcreateIfMissing, nameof(mSExcelActivateWorksheetcreateIfMissing), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSExcelActivateWorksheet["Handle"] = SourceExpressionConverter.ConvertToken(mSExcelActivateWorksheethandle);
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
                    mSExcelActivateWorksheet["WorkbookName"] = SourceExpressionConverter.ConvertToken(mSExcelActivateWorksheetworkbookName);
                    mSExcelActivateWorksheetpropCount++;
                }

                if (mSExcelActivateWorksheetworksheetName != null)
                {
                    mSExcelActivateWorksheet["WorksheetName"] = SourceExpressionConverter.ConvertToken(mSExcelActivateWorksheetworksheetName);
                    mSExcelActivateWorksheetpropCount++;
                }

                if (mSExcelActivateWorksheetcreateIfMissing != null)
                {
                    if (mSExcelActivateWorksheetcreateIfMissing != null)
                    {
                        mSExcelActivateWorksheet["CreateIfMissing"] = SourceExpressionConverter.ConvertToken(mSExcelActivateWorksheetcreateIfMissing);
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
                mSExcelActivateWorksheet["Workflow"] = SourceExpressionConverter.ConvertToken(mSExcelActivateWorksheetworkflow);
                if (mSExcelActivateWorksheetpropCount > 0)
                {
                    callPayload.Body = mSExcelActivateWorksheet;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelCreateWorksheet([WorkflowExpression] Func<string> mSExcelCreateWorksheetworkflow, [WorkflowExpression] Func<int> mSExcelCreateWorksheethandle = null, [WorkflowExpression] Func<string> mSExcelCreateWorksheetworkbookName = null, [WorkflowExpression] Func<string> mSExcelCreateWorksheetworksheetName = null)
        {
            SourceExpression.Validate(mSExcelCreateWorksheetworkflow, nameof(mSExcelCreateWorksheetworkflow), required: true);
            SourceExpression.Validate(mSExcelCreateWorksheethandle, nameof(mSExcelCreateWorksheethandle), required: false);
            SourceExpression.Validate(mSExcelCreateWorksheetworkbookName, nameof(mSExcelCreateWorksheetworkbookName), required: false);
            SourceExpression.Validate(mSExcelCreateWorksheetworksheetName, nameof(mSExcelCreateWorksheetworksheetName), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSExcelCreateWorksheet["Handle"] = SourceExpressionConverter.ConvertToken(mSExcelCreateWorksheethandle);
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
                    mSExcelCreateWorksheet["WorkbookName"] = SourceExpressionConverter.ConvertToken(mSExcelCreateWorksheetworkbookName);
                    mSExcelCreateWorksheetpropCount++;
                }

                if (mSExcelCreateWorksheetworksheetName != null)
                {
                    mSExcelCreateWorksheet["WorksheetName"] = SourceExpressionConverter.ConvertToken(mSExcelCreateWorksheetworksheetName);
                    mSExcelCreateWorksheetpropCount++;
                }

                mSExcelCreateWorksheetpropCount++;
                mSExcelCreateWorksheet["Workflow"] = SourceExpressionConverter.ConvertToken(mSExcelCreateWorksheetworkflow);
                if (mSExcelCreateWorksheetpropCount > 0)
                {
                    callPayload.Body = mSExcelCreateWorksheet;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelDeleteWorksheet([WorkflowExpression] Func<string> mSExcelDeleteWorksheetworkflow, [WorkflowExpression] Func<int> mSExcelDeleteWorksheethandle = null, [WorkflowExpression] Func<string> mSExcelDeleteWorksheetworkbookName = null, [WorkflowExpression] Func<string> mSExcelDeleteWorksheetworksheetName = null)
        {
            SourceExpression.Validate(mSExcelDeleteWorksheetworkflow, nameof(mSExcelDeleteWorksheetworkflow), required: true);
            SourceExpression.Validate(mSExcelDeleteWorksheethandle, nameof(mSExcelDeleteWorksheethandle), required: false);
            SourceExpression.Validate(mSExcelDeleteWorksheetworkbookName, nameof(mSExcelDeleteWorksheetworkbookName), required: false);
            SourceExpression.Validate(mSExcelDeleteWorksheetworksheetName, nameof(mSExcelDeleteWorksheetworksheetName), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSExcelDeleteWorksheet["Handle"] = SourceExpressionConverter.ConvertToken(mSExcelDeleteWorksheethandle);
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
                    mSExcelDeleteWorksheet["WorkbookName"] = SourceExpressionConverter.ConvertToken(mSExcelDeleteWorksheetworkbookName);
                    mSExcelDeleteWorksheetpropCount++;
                }

                if (mSExcelDeleteWorksheetworksheetName != null)
                {
                    mSExcelDeleteWorksheet["WorksheetName"] = SourceExpressionConverter.ConvertToken(mSExcelDeleteWorksheetworksheetName);
                    mSExcelDeleteWorksheetpropCount++;
                }

                mSExcelDeleteWorksheetpropCount++;
                mSExcelDeleteWorksheet["Workflow"] = SourceExpressionConverter.ConvertToken(mSExcelDeleteWorksheetworkflow);
                if (mSExcelDeleteWorksheetpropCount > 0)
                {
                    callPayload.Body = mSExcelDeleteWorksheet;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetWorksheetAsCollectionEnhancedResponse> MSExcelGetWorksheetAsCollectionEnhanced([WorkflowExpression] Func<string> mSExcelGetWorksheetAsCollectionEnhancedworkflow, [WorkflowExpression] Func<int> mSExcelGetWorksheetAsCollectionEnhancedhandle = null, [WorkflowExpression] Func<string> mSExcelGetWorksheetAsCollectionEnhancedworkbookName = null, [WorkflowExpression] Func<string> mSExcelGetWorksheetAsCollectionEnhancedworksheetName = null, [WorkflowExpression] Func<bool> mSExcelGetWorksheetAsCollectionEnhanceduseHeader = null, [WorkflowExpression] Func<string> mSExcelGetWorksheetAsCollectionEnhancedstartCell = null, [WorkflowExpression] Func<int> mSExcelGetWorksheetAsCollectionEnhancedmaximumColumnNumber = null, [WorkflowExpression] Func<bool> mSExcelGetWorksheetAsCollectionEnhancedskipBlankRows = null, [WorkflowExpression] Func<bool> mSExcelGetWorksheetAsCollectionEnhancedskipColumnsWithNoHeader = null, [WorkflowExpression] Func<string> mSExcelGetWorksheetAsCollectionEnhancedkeyColumn = null, [WorkflowExpression] Func<bool> mSExcelGetWorksheetAsCollectionEnhancedgetRawData = null, [WorkflowExpression] Func<int> mSExcelGetWorksheetAsCollectionEnhancedignoreRowsWithLowCellCount = null, [WorkflowExpression] Func<int> mSExcelGetWorksheetAsCollectionEnhancedmaxConcurrentBlankRows = null, [WorkflowExpression] Func<int> mSExcelGetWorksheetAsCollectionEnhancedfirstDataRowToReturn = null, [WorkflowExpression] Func<int> mSExcelGetWorksheetAsCollectionEnhancedmaxNumberOfDataRowsToReturn = null)
        {
            SourceExpression.Validate(mSExcelGetWorksheetAsCollectionEnhancedworkflow, nameof(mSExcelGetWorksheetAsCollectionEnhancedworkflow), required: true);
            SourceExpression.Validate(mSExcelGetWorksheetAsCollectionEnhancedhandle, nameof(mSExcelGetWorksheetAsCollectionEnhancedhandle), required: false);
            SourceExpression.Validate(mSExcelGetWorksheetAsCollectionEnhancedworkbookName, nameof(mSExcelGetWorksheetAsCollectionEnhancedworkbookName), required: false);
            SourceExpression.Validate(mSExcelGetWorksheetAsCollectionEnhancedworksheetName, nameof(mSExcelGetWorksheetAsCollectionEnhancedworksheetName), required: false);
            SourceExpression.Validate(mSExcelGetWorksheetAsCollectionEnhanceduseHeader, nameof(mSExcelGetWorksheetAsCollectionEnhanceduseHeader), required: false);
            SourceExpression.Validate(mSExcelGetWorksheetAsCollectionEnhancedstartCell, nameof(mSExcelGetWorksheetAsCollectionEnhancedstartCell), required: false);
            SourceExpression.Validate(mSExcelGetWorksheetAsCollectionEnhancedmaximumColumnNumber, nameof(mSExcelGetWorksheetAsCollectionEnhancedmaximumColumnNumber), required: false);
            SourceExpression.Validate(mSExcelGetWorksheetAsCollectionEnhancedskipBlankRows, nameof(mSExcelGetWorksheetAsCollectionEnhancedskipBlankRows), required: false);
            SourceExpression.Validate(mSExcelGetWorksheetAsCollectionEnhancedskipColumnsWithNoHeader, nameof(mSExcelGetWorksheetAsCollectionEnhancedskipColumnsWithNoHeader), required: false);
            SourceExpression.Validate(mSExcelGetWorksheetAsCollectionEnhancedkeyColumn, nameof(mSExcelGetWorksheetAsCollectionEnhancedkeyColumn), required: false);
            SourceExpression.Validate(mSExcelGetWorksheetAsCollectionEnhancedgetRawData, nameof(mSExcelGetWorksheetAsCollectionEnhancedgetRawData), required: false);
            SourceExpression.Validate(mSExcelGetWorksheetAsCollectionEnhancedignoreRowsWithLowCellCount, nameof(mSExcelGetWorksheetAsCollectionEnhancedignoreRowsWithLowCellCount), required: false);
            SourceExpression.Validate(mSExcelGetWorksheetAsCollectionEnhancedmaxConcurrentBlankRows, nameof(mSExcelGetWorksheetAsCollectionEnhancedmaxConcurrentBlankRows), required: false);
            SourceExpression.Validate(mSExcelGetWorksheetAsCollectionEnhancedfirstDataRowToReturn, nameof(mSExcelGetWorksheetAsCollectionEnhancedfirstDataRowToReturn), required: false);
            SourceExpression.Validate(mSExcelGetWorksheetAsCollectionEnhancedmaxNumberOfDataRowsToReturn, nameof(mSExcelGetWorksheetAsCollectionEnhancedmaxNumberOfDataRowsToReturn), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSExcelGetWorksheetAsCollectionEnhanced["Handle"] = SourceExpressionConverter.ConvertToken(mSExcelGetWorksheetAsCollectionEnhancedhandle);
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
                    mSExcelGetWorksheetAsCollectionEnhanced["WorkbookName"] = SourceExpressionConverter.ConvertToken(mSExcelGetWorksheetAsCollectionEnhancedworkbookName);
                    mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
                }

                if (mSExcelGetWorksheetAsCollectionEnhancedworksheetName != null)
                {
                    mSExcelGetWorksheetAsCollectionEnhanced["WorksheetName"] = SourceExpressionConverter.ConvertToken(mSExcelGetWorksheetAsCollectionEnhancedworksheetName);
                    mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
                }

                if (mSExcelGetWorksheetAsCollectionEnhanceduseHeader != null)
                {
                    if (mSExcelGetWorksheetAsCollectionEnhanceduseHeader != null)
                    {
                        mSExcelGetWorksheetAsCollectionEnhanced["UseHeader"] = SourceExpressionConverter.ConvertToken(mSExcelGetWorksheetAsCollectionEnhanceduseHeader);
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
                    mSExcelGetWorksheetAsCollectionEnhanced["StartCell"] = SourceExpressionConverter.ConvertToken(mSExcelGetWorksheetAsCollectionEnhancedstartCell);
                    mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
                }

                if (mSExcelGetWorksheetAsCollectionEnhancedmaximumColumnNumber != null)
                {
                    if (mSExcelGetWorksheetAsCollectionEnhancedmaximumColumnNumber != null)
                    {
                        mSExcelGetWorksheetAsCollectionEnhanced["MaximumColumnNumber"] = SourceExpressionConverter.ConvertToken(mSExcelGetWorksheetAsCollectionEnhancedmaximumColumnNumber);
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
                        mSExcelGetWorksheetAsCollectionEnhanced["SkipBlankRows"] = SourceExpressionConverter.ConvertToken(mSExcelGetWorksheetAsCollectionEnhancedskipBlankRows);
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
                        mSExcelGetWorksheetAsCollectionEnhanced["SkipColumnsWithNoHeader"] = SourceExpressionConverter.ConvertToken(mSExcelGetWorksheetAsCollectionEnhancedskipColumnsWithNoHeader);
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
                    mSExcelGetWorksheetAsCollectionEnhanced["KeyColumn"] = SourceExpressionConverter.ConvertToken(mSExcelGetWorksheetAsCollectionEnhancedkeyColumn);
                    mSExcelGetWorksheetAsCollectionEnhancedpropCount++;
                }

                if (mSExcelGetWorksheetAsCollectionEnhancedgetRawData != null)
                {
                    if (mSExcelGetWorksheetAsCollectionEnhancedgetRawData != null)
                    {
                        mSExcelGetWorksheetAsCollectionEnhanced["GetRawData"] = SourceExpressionConverter.ConvertToken(mSExcelGetWorksheetAsCollectionEnhancedgetRawData);
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
                        mSExcelGetWorksheetAsCollectionEnhanced["IgnoreRowsWithLowCellCount"] = SourceExpressionConverter.ConvertToken(mSExcelGetWorksheetAsCollectionEnhancedignoreRowsWithLowCellCount);
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
                        mSExcelGetWorksheetAsCollectionEnhanced["MaxConcurrentBlankRows"] = SourceExpressionConverter.ConvertToken(mSExcelGetWorksheetAsCollectionEnhancedmaxConcurrentBlankRows);
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
                        mSExcelGetWorksheetAsCollectionEnhanced["FirstDataRowToReturn"] = SourceExpressionConverter.ConvertToken(mSExcelGetWorksheetAsCollectionEnhancedfirstDataRowToReturn);
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
                        mSExcelGetWorksheetAsCollectionEnhanced["MaxNumberOfDataRowsToReturn"] = SourceExpressionConverter.ConvertToken(mSExcelGetWorksheetAsCollectionEnhancedmaxNumberOfDataRowsToReturn);
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
                mSExcelGetWorksheetAsCollectionEnhanced["Workflow"] = SourceExpressionConverter.ConvertToken(mSExcelGetWorksheetAsCollectionEnhancedworkflow);
                if (mSExcelGetWorksheetAsCollectionEnhancedpropCount > 0)
                {
                    callPayload.Body = mSExcelGetWorksheetAsCollectionEnhanced;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MSExcelGetWorksheetAsCollectionEnhancedResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetNumberOfRowsResponse> MSExcelGetNumberOfRows([WorkflowExpression] Func<string> mSExcelGetNumberOfRowsworkflow, [WorkflowExpression] Func<int> mSExcelGetNumberOfRowshandle = null, [WorkflowExpression] Func<string> mSExcelGetNumberOfRowsworkbookName = null, [WorkflowExpression] Func<string> mSExcelGetNumberOfRowsworksheetName = null)
        {
            SourceExpression.Validate(mSExcelGetNumberOfRowsworkflow, nameof(mSExcelGetNumberOfRowsworkflow), required: true);
            SourceExpression.Validate(mSExcelGetNumberOfRowshandle, nameof(mSExcelGetNumberOfRowshandle), required: false);
            SourceExpression.Validate(mSExcelGetNumberOfRowsworkbookName, nameof(mSExcelGetNumberOfRowsworkbookName), required: false);
            SourceExpression.Validate(mSExcelGetNumberOfRowsworksheetName, nameof(mSExcelGetNumberOfRowsworksheetName), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSExcelGetNumberOfRows["Handle"] = SourceExpressionConverter.ConvertToken(mSExcelGetNumberOfRowshandle);
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
                    mSExcelGetNumberOfRows["WorkbookName"] = SourceExpressionConverter.ConvertToken(mSExcelGetNumberOfRowsworkbookName);
                    mSExcelGetNumberOfRowspropCount++;
                }

                if (mSExcelGetNumberOfRowsworksheetName != null)
                {
                    mSExcelGetNumberOfRows["WorksheetName"] = SourceExpressionConverter.ConvertToken(mSExcelGetNumberOfRowsworksheetName);
                    mSExcelGetNumberOfRowspropCount++;
                }

                mSExcelGetNumberOfRowspropCount++;
                mSExcelGetNumberOfRows["Workflow"] = SourceExpressionConverter.ConvertToken(mSExcelGetNumberOfRowsworkflow);
                if (mSExcelGetNumberOfRowspropCount > 0)
                {
                    callPayload.Body = mSExcelGetNumberOfRows;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MSExcelGetNumberOfRowsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelEvaluateExpressionResponse> MSExcelEvaluateExpression([WorkflowExpression] Func<string> mSExcelEvaluateExpressionexpression, [WorkflowExpression] Func<string> mSExcelEvaluateExpressionworkflow, [WorkflowExpression] Func<int> mSExcelEvaluateExpressionhandle = null)
        {
            SourceExpression.Validate(mSExcelEvaluateExpressionexpression, nameof(mSExcelEvaluateExpressionexpression), required: true);
            SourceExpression.Validate(mSExcelEvaluateExpressionworkflow, nameof(mSExcelEvaluateExpressionworkflow), required: true);
            SourceExpression.Validate(mSExcelEvaluateExpressionhandle, nameof(mSExcelEvaluateExpressionhandle), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSExcelEvaluateExpression["Handle"] = SourceExpressionConverter.ConvertToken(mSExcelEvaluateExpressionhandle);
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
                mSExcelEvaluateExpression["Expression"] = SourceExpressionConverter.ConvertToken(mSExcelEvaluateExpressionexpression);
                mSExcelEvaluateExpressionpropCount++;
                mSExcelEvaluateExpression["Workflow"] = SourceExpressionConverter.ConvertToken(mSExcelEvaluateExpressionworkflow);
                if (mSExcelEvaluateExpressionpropCount > 0)
                {
                    callPayload.Body = mSExcelEvaluateExpression;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MSExcelEvaluateExpressionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetWorksheetUsedRangeResponse> MSExcelGetWorksheetUsedRange([WorkflowExpression] Func<string> mSExcelGetWorksheetUsedRangeworkflow, [WorkflowExpression] Func<int> mSExcelGetWorksheetUsedRangehandle = null, [WorkflowExpression] Func<string> mSExcelGetWorksheetUsedRangeworkbookName = null, [WorkflowExpression] Func<string> mSExcelGetWorksheetUsedRangeworksheetName = null)
        {
            SourceExpression.Validate(mSExcelGetWorksheetUsedRangeworkflow, nameof(mSExcelGetWorksheetUsedRangeworkflow), required: true);
            SourceExpression.Validate(mSExcelGetWorksheetUsedRangehandle, nameof(mSExcelGetWorksheetUsedRangehandle), required: false);
            SourceExpression.Validate(mSExcelGetWorksheetUsedRangeworkbookName, nameof(mSExcelGetWorksheetUsedRangeworkbookName), required: false);
            SourceExpression.Validate(mSExcelGetWorksheetUsedRangeworksheetName, nameof(mSExcelGetWorksheetUsedRangeworksheetName), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSExcelGetWorksheetUsedRange["Handle"] = SourceExpressionConverter.ConvertToken(mSExcelGetWorksheetUsedRangehandle);
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
                    mSExcelGetWorksheetUsedRange["WorkbookName"] = SourceExpressionConverter.ConvertToken(mSExcelGetWorksheetUsedRangeworkbookName);
                    mSExcelGetWorksheetUsedRangepropCount++;
                }

                if (mSExcelGetWorksheetUsedRangeworksheetName != null)
                {
                    mSExcelGetWorksheetUsedRange["WorksheetName"] = SourceExpressionConverter.ConvertToken(mSExcelGetWorksheetUsedRangeworksheetName);
                    mSExcelGetWorksheetUsedRangepropCount++;
                }

                mSExcelGetWorksheetUsedRangepropCount++;
                mSExcelGetWorksheetUsedRange["Workflow"] = SourceExpressionConverter.ConvertToken(mSExcelGetWorksheetUsedRangeworkflow);
                if (mSExcelGetWorksheetUsedRangepropCount > 0)
                {
                    callPayload.Body = mSExcelGetWorksheetUsedRange;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MSExcelGetWorksheetUsedRangeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetCountrySettingResponse> MSExcelGetCountrySetting([WorkflowExpression] Func<string> mSExcelGetCountrySettingworkflow, [WorkflowExpression] Func<int> mSExcelGetCountrySettinghandle = null)
        {
            SourceExpression.Validate(mSExcelGetCountrySettingworkflow, nameof(mSExcelGetCountrySettingworkflow), required: true);
            SourceExpression.Validate(mSExcelGetCountrySettinghandle, nameof(mSExcelGetCountrySettinghandle), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSExcelGetCountrySetting["Handle"] = SourceExpressionConverter.ConvertToken(mSExcelGetCountrySettinghandle);
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
                mSExcelGetCountrySetting["Workflow"] = SourceExpressionConverter.ConvertToken(mSExcelGetCountrySettingworkflow);
                if (mSExcelGetCountrySettingpropCount > 0)
                {
                    callPayload.Body = mSExcelGetCountrySetting;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MSExcelGetCountrySettingResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelWriteCollection([WorkflowExpression] Func<string> mSExcelWriteCollectioncellReference, [WorkflowExpression] Func<string> mSExcelWriteCollectioncollectionToWriteJSON, [WorkflowExpression] Func<string> mSExcelWriteCollectionworkflow, [WorkflowExpression] Func<int> mSExcelWriteCollectionhandle = null, [WorkflowExpression] Func<string> mSExcelWriteCollectionworkbookName = null, [WorkflowExpression] Func<string> mSExcelWriteCollectionworksheetName = null, [WorkflowExpression] Func<bool> mSExcelWriteCollectionincludeColumnNames = null)
        {
            SourceExpression.Validate(mSExcelWriteCollectioncellReference, nameof(mSExcelWriteCollectioncellReference), required: true);
            SourceExpression.Validate(mSExcelWriteCollectioncollectionToWriteJSON, nameof(mSExcelWriteCollectioncollectionToWriteJSON), required: true);
            SourceExpression.Validate(mSExcelWriteCollectionworkflow, nameof(mSExcelWriteCollectionworkflow), required: true);
            SourceExpression.Validate(mSExcelWriteCollectionhandle, nameof(mSExcelWriteCollectionhandle), required: false);
            SourceExpression.Validate(mSExcelWriteCollectionworkbookName, nameof(mSExcelWriteCollectionworkbookName), required: false);
            SourceExpression.Validate(mSExcelWriteCollectionworksheetName, nameof(mSExcelWriteCollectionworksheetName), required: false);
            SourceExpression.Validate(mSExcelWriteCollectionincludeColumnNames, nameof(mSExcelWriteCollectionincludeColumnNames), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSExcelWriteCollection["Handle"] = SourceExpressionConverter.ConvertToken(mSExcelWriteCollectionhandle);
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
                    mSExcelWriteCollection["WorkbookName"] = SourceExpressionConverter.ConvertToken(mSExcelWriteCollectionworkbookName);
                    mSExcelWriteCollectionpropCount++;
                }

                if (mSExcelWriteCollectionworksheetName != null)
                {
                    mSExcelWriteCollection["WorksheetName"] = SourceExpressionConverter.ConvertToken(mSExcelWriteCollectionworksheetName);
                    mSExcelWriteCollectionpropCount++;
                }

                mSExcelWriteCollectionpropCount++;
                mSExcelWriteCollection["CellReference"] = SourceExpressionConverter.ConvertToken(mSExcelWriteCollectioncellReference);
                mSExcelWriteCollectionpropCount++;
                mSExcelWriteCollection["CollectionToWriteJSON"] = SourceExpressionConverter.ConvertToken(mSExcelWriteCollectioncollectionToWriteJSON);
                if (mSExcelWriteCollectionincludeColumnNames != null)
                {
                    if (mSExcelWriteCollectionincludeColumnNames != null)
                    {
                        mSExcelWriteCollection["IncludeColumnNames"] = SourceExpressionConverter.ConvertToken(mSExcelWriteCollectionincludeColumnNames);
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
                mSExcelWriteCollection["Workflow"] = SourceExpressionConverter.ConvertToken(mSExcelWriteCollectionworkflow);
                if (mSExcelWriteCollectionpropCount > 0)
                {
                    callPayload.Body = mSExcelWriteCollection;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelWriteCollectionWithDates([WorkflowExpression] Func<string> mSExcelWriteCollectionWithDatescellReference, [WorkflowExpression] Func<string> mSExcelWriteCollectionWithDatescollectionToWriteJSON, [WorkflowExpression] Func<string> mSExcelWriteCollectionWithDatesworkflow, [WorkflowExpression] Func<int> mSExcelWriteCollectionWithDateshandle = null, [WorkflowExpression] Func<string> mSExcelWriteCollectionWithDatesworkbookName = null, [WorkflowExpression] Func<string> mSExcelWriteCollectionWithDatesworksheetName = null, [WorkflowExpression] Func<bool> mSExcelWriteCollectionWithDatesincludeColumnNames = null, [WorkflowExpression] Func<bool> mSExcelWriteCollectionWithDatestryToConvertAllFieldsToDate = null, [WorkflowExpression] Func<string> mSExcelWriteCollectionWithDatescolumnsToConvertToDateJSON = null)
        {
            SourceExpression.Validate(mSExcelWriteCollectionWithDatescellReference, nameof(mSExcelWriteCollectionWithDatescellReference), required: true);
            SourceExpression.Validate(mSExcelWriteCollectionWithDatescollectionToWriteJSON, nameof(mSExcelWriteCollectionWithDatescollectionToWriteJSON), required: true);
            SourceExpression.Validate(mSExcelWriteCollectionWithDatesworkflow, nameof(mSExcelWriteCollectionWithDatesworkflow), required: true);
            SourceExpression.Validate(mSExcelWriteCollectionWithDateshandle, nameof(mSExcelWriteCollectionWithDateshandle), required: false);
            SourceExpression.Validate(mSExcelWriteCollectionWithDatesworkbookName, nameof(mSExcelWriteCollectionWithDatesworkbookName), required: false);
            SourceExpression.Validate(mSExcelWriteCollectionWithDatesworksheetName, nameof(mSExcelWriteCollectionWithDatesworksheetName), required: false);
            SourceExpression.Validate(mSExcelWriteCollectionWithDatesincludeColumnNames, nameof(mSExcelWriteCollectionWithDatesincludeColumnNames), required: false);
            SourceExpression.Validate(mSExcelWriteCollectionWithDatestryToConvertAllFieldsToDate, nameof(mSExcelWriteCollectionWithDatestryToConvertAllFieldsToDate), required: false);
            SourceExpression.Validate(mSExcelWriteCollectionWithDatescolumnsToConvertToDateJSON, nameof(mSExcelWriteCollectionWithDatescolumnsToConvertToDateJSON), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSExcelWriteCollectionWithDates["Handle"] = SourceExpressionConverter.ConvertToken(mSExcelWriteCollectionWithDateshandle);
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
                    mSExcelWriteCollectionWithDates["WorkbookName"] = SourceExpressionConverter.ConvertToken(mSExcelWriteCollectionWithDatesworkbookName);
                    mSExcelWriteCollectionWithDatespropCount++;
                }

                if (mSExcelWriteCollectionWithDatesworksheetName != null)
                {
                    mSExcelWriteCollectionWithDates["WorksheetName"] = SourceExpressionConverter.ConvertToken(mSExcelWriteCollectionWithDatesworksheetName);
                    mSExcelWriteCollectionWithDatespropCount++;
                }

                mSExcelWriteCollectionWithDatespropCount++;
                mSExcelWriteCollectionWithDates["CellReference"] = SourceExpressionConverter.ConvertToken(mSExcelWriteCollectionWithDatescellReference);
                mSExcelWriteCollectionWithDatespropCount++;
                mSExcelWriteCollectionWithDates["CollectionToWriteJSON"] = SourceExpressionConverter.ConvertToken(mSExcelWriteCollectionWithDatescollectionToWriteJSON);
                if (mSExcelWriteCollectionWithDatesincludeColumnNames != null)
                {
                    if (mSExcelWriteCollectionWithDatesincludeColumnNames != null)
                    {
                        mSExcelWriteCollectionWithDates["IncludeColumnNames"] = SourceExpressionConverter.ConvertToken(mSExcelWriteCollectionWithDatesincludeColumnNames);
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
                        mSExcelWriteCollectionWithDates["TryToConvertAllFieldsToDate"] = SourceExpressionConverter.ConvertToken(mSExcelWriteCollectionWithDatestryToConvertAllFieldsToDate);
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
                    mSExcelWriteCollectionWithDates["ColumnsToConvertToDateJSON"] = SourceExpressionConverter.ConvertToken(mSExcelWriteCollectionWithDatescolumnsToConvertToDateJSON);
                    mSExcelWriteCollectionWithDatespropCount++;
                }

                mSExcelWriteCollectionWithDatespropCount++;
                mSExcelWriteCollectionWithDates["Workflow"] = SourceExpressionConverter.ConvertToken(mSExcelWriteCollectionWithDatesworkflow);
                if (mSExcelWriteCollectionWithDatespropCount > 0)
                {
                    callPayload.Body = mSExcelWriteCollectionWithDates;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetActiveCellResponse> MSExcelGetActiveCell([WorkflowExpression] Func<string> mSExcelGetActiveCellworkflow, [WorkflowExpression] Func<int> mSExcelGetActiveCellhandle = null)
        {
            SourceExpression.Validate(mSExcelGetActiveCellworkflow, nameof(mSExcelGetActiveCellworkflow), required: true);
            SourceExpression.Validate(mSExcelGetActiveCellhandle, nameof(mSExcelGetActiveCellhandle), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSExcelGetActiveCell["Handle"] = SourceExpressionConverter.ConvertToken(mSExcelGetActiveCellhandle);
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
                mSExcelGetActiveCell["Workflow"] = SourceExpressionConverter.ConvertToken(mSExcelGetActiveCellworkflow);
                if (mSExcelGetActiveCellpropCount > 0)
                {
                    callPayload.Body = mSExcelGetActiveCell;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MSExcelGetActiveCellResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelFormatCell([WorkflowExpression] Func<string> mSExcelFormatCellcellReference, [WorkflowExpression] Func<string> mSExcelFormatCellcellFormat, [WorkflowExpression] Func<string> mSExcelFormatCellworkflow, [WorkflowExpression] Func<int> mSExcelFormatCellhandle = null, [WorkflowExpression] Func<string> mSExcelFormatCellworkbookName = null, [WorkflowExpression] Func<string> mSExcelFormatCellworksheetName = null)
        {
            SourceExpression.Validate(mSExcelFormatCellcellReference, nameof(mSExcelFormatCellcellReference), required: true);
            SourceExpression.Validate(mSExcelFormatCellcellFormat, nameof(mSExcelFormatCellcellFormat), required: true);
            SourceExpression.Validate(mSExcelFormatCellworkflow, nameof(mSExcelFormatCellworkflow), required: true);
            SourceExpression.Validate(mSExcelFormatCellhandle, nameof(mSExcelFormatCellhandle), required: false);
            SourceExpression.Validate(mSExcelFormatCellworkbookName, nameof(mSExcelFormatCellworkbookName), required: false);
            SourceExpression.Validate(mSExcelFormatCellworksheetName, nameof(mSExcelFormatCellworksheetName), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSExcelFormatCell["Handle"] = SourceExpressionConverter.ConvertToken(mSExcelFormatCellhandle);
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
                    mSExcelFormatCell["WorkbookName"] = SourceExpressionConverter.ConvertToken(mSExcelFormatCellworkbookName);
                    mSExcelFormatCellpropCount++;
                }

                if (mSExcelFormatCellworksheetName != null)
                {
                    mSExcelFormatCell["WorksheetName"] = SourceExpressionConverter.ConvertToken(mSExcelFormatCellworksheetName);
                    mSExcelFormatCellpropCount++;
                }

                mSExcelFormatCellpropCount++;
                mSExcelFormatCell["CellReference"] = SourceExpressionConverter.ConvertToken(mSExcelFormatCellcellReference);
                mSExcelFormatCellpropCount++;
                mSExcelFormatCell["CellFormat"] = SourceExpressionConverter.ConvertToken(mSExcelFormatCellcellFormat);
                mSExcelFormatCellpropCount++;
                mSExcelFormatCell["Workflow"] = SourceExpressionConverter.ConvertToken(mSExcelFormatCellworkflow);
                if (mSExcelFormatCellpropCount > 0)
                {
                    callPayload.Body = mSExcelFormatCell;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelFormatCurrentCell([WorkflowExpression] Func<string> mSExcelFormatCurrentCellcellFormat, [WorkflowExpression] Func<string> mSExcelFormatCurrentCellworkflow, [WorkflowExpression] Func<int> mSExcelFormatCurrentCellhandle = null)
        {
            SourceExpression.Validate(mSExcelFormatCurrentCellcellFormat, nameof(mSExcelFormatCurrentCellcellFormat), required: true);
            SourceExpression.Validate(mSExcelFormatCurrentCellworkflow, nameof(mSExcelFormatCurrentCellworkflow), required: true);
            SourceExpression.Validate(mSExcelFormatCurrentCellhandle, nameof(mSExcelFormatCurrentCellhandle), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSExcelFormatCurrentCell["Handle"] = SourceExpressionConverter.ConvertToken(mSExcelFormatCurrentCellhandle);
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
                mSExcelFormatCurrentCell["CellFormat"] = SourceExpressionConverter.ConvertToken(mSExcelFormatCurrentCellcellFormat);
                mSExcelFormatCurrentCellpropCount++;
                mSExcelFormatCurrentCell["Workflow"] = SourceExpressionConverter.ConvertToken(mSExcelFormatCurrentCellworkflow);
                if (mSExcelFormatCurrentCellpropCount > 0)
                {
                    callPayload.Body = mSExcelFormatCurrentCell;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelSelectCellRange([WorkflowExpression] Func<string> mSExcelSelectCellRangecellReference, [WorkflowExpression] Func<string> mSExcelSelectCellRangeworkflow, [WorkflowExpression] Func<int> mSExcelSelectCellRangehandle = null, [WorkflowExpression] Func<string> mSExcelSelectCellRangeworkbookName = null, [WorkflowExpression] Func<string> mSExcelSelectCellRangeworksheetName = null, [WorkflowExpression] Func<bool> mSExcelSelectCellRangeentireRow = null, [WorkflowExpression] Func<bool> mSExcelSelectCellRangeentireColumn = null)
        {
            SourceExpression.Validate(mSExcelSelectCellRangecellReference, nameof(mSExcelSelectCellRangecellReference), required: true);
            SourceExpression.Validate(mSExcelSelectCellRangeworkflow, nameof(mSExcelSelectCellRangeworkflow), required: true);
            SourceExpression.Validate(mSExcelSelectCellRangehandle, nameof(mSExcelSelectCellRangehandle), required: false);
            SourceExpression.Validate(mSExcelSelectCellRangeworkbookName, nameof(mSExcelSelectCellRangeworkbookName), required: false);
            SourceExpression.Validate(mSExcelSelectCellRangeworksheetName, nameof(mSExcelSelectCellRangeworksheetName), required: false);
            SourceExpression.Validate(mSExcelSelectCellRangeentireRow, nameof(mSExcelSelectCellRangeentireRow), required: false);
            SourceExpression.Validate(mSExcelSelectCellRangeentireColumn, nameof(mSExcelSelectCellRangeentireColumn), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSExcelSelectCellRange["Handle"] = SourceExpressionConverter.ConvertToken(mSExcelSelectCellRangehandle);
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
                    mSExcelSelectCellRange["WorkbookName"] = SourceExpressionConverter.ConvertToken(mSExcelSelectCellRangeworkbookName);
                    mSExcelSelectCellRangepropCount++;
                }

                if (mSExcelSelectCellRangeworksheetName != null)
                {
                    mSExcelSelectCellRange["WorksheetName"] = SourceExpressionConverter.ConvertToken(mSExcelSelectCellRangeworksheetName);
                    mSExcelSelectCellRangepropCount++;
                }

                mSExcelSelectCellRangepropCount++;
                mSExcelSelectCellRange["CellReference"] = SourceExpressionConverter.ConvertToken(mSExcelSelectCellRangecellReference);
                if (mSExcelSelectCellRangeentireRow != null)
                {
                    if (mSExcelSelectCellRangeentireRow != null)
                    {
                        mSExcelSelectCellRange["EntireRow"] = SourceExpressionConverter.ConvertToken(mSExcelSelectCellRangeentireRow);
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
                        mSExcelSelectCellRange["EntireColumn"] = SourceExpressionConverter.ConvertToken(mSExcelSelectCellRangeentireColumn);
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
                mSExcelSelectCellRange["Workflow"] = SourceExpressionConverter.ConvertToken(mSExcelSelectCellRangeworkflow);
                if (mSExcelSelectCellRangepropCount > 0)
                {
                    callPayload.Body = mSExcelSelectCellRange;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelCopySelection([WorkflowExpression] Func<string> mSExcelCopySelectionworkflow, [WorkflowExpression] Func<int> mSExcelCopySelectionhandle = null, [WorkflowExpression] Func<string> mSExcelCopySelectionworkbookName = null, [WorkflowExpression] Func<string> mSExcelCopySelectionworksheetName = null, [WorkflowExpression] Func<string> mSExcelCopySelectioncellReference = null, [WorkflowExpression] Func<bool> mSExcelCopySelectionentireRow = null, [WorkflowExpression] Func<bool> mSExcelCopySelectionentireColumn = null)
        {
            SourceExpression.Validate(mSExcelCopySelectionworkflow, nameof(mSExcelCopySelectionworkflow), required: true);
            SourceExpression.Validate(mSExcelCopySelectionhandle, nameof(mSExcelCopySelectionhandle), required: false);
            SourceExpression.Validate(mSExcelCopySelectionworkbookName, nameof(mSExcelCopySelectionworkbookName), required: false);
            SourceExpression.Validate(mSExcelCopySelectionworksheetName, nameof(mSExcelCopySelectionworksheetName), required: false);
            SourceExpression.Validate(mSExcelCopySelectioncellReference, nameof(mSExcelCopySelectioncellReference), required: false);
            SourceExpression.Validate(mSExcelCopySelectionentireRow, nameof(mSExcelCopySelectionentireRow), required: false);
            SourceExpression.Validate(mSExcelCopySelectionentireColumn, nameof(mSExcelCopySelectionentireColumn), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSExcelCopySelection["Handle"] = SourceExpressionConverter.ConvertToken(mSExcelCopySelectionhandle);
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
                    mSExcelCopySelection["WorkbookName"] = SourceExpressionConverter.ConvertToken(mSExcelCopySelectionworkbookName);
                    mSExcelCopySelectionpropCount++;
                }

                if (mSExcelCopySelectionworksheetName != null)
                {
                    mSExcelCopySelection["WorksheetName"] = SourceExpressionConverter.ConvertToken(mSExcelCopySelectionworksheetName);
                    mSExcelCopySelectionpropCount++;
                }

                if (mSExcelCopySelectioncellReference != null)
                {
                    mSExcelCopySelection["CellReference"] = SourceExpressionConverter.ConvertToken(mSExcelCopySelectioncellReference);
                    mSExcelCopySelectionpropCount++;
                }

                if (mSExcelCopySelectionentireRow != null)
                {
                    if (mSExcelCopySelectionentireRow != null)
                    {
                        mSExcelCopySelection["EntireRow"] = SourceExpressionConverter.ConvertToken(mSExcelCopySelectionentireRow);
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
                        mSExcelCopySelection["EntireColumn"] = SourceExpressionConverter.ConvertToken(mSExcelCopySelectionentireColumn);
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
                mSExcelCopySelection["Workflow"] = SourceExpressionConverter.ConvertToken(mSExcelCopySelectionworkflow);
                if (mSExcelCopySelectionpropCount > 0)
                {
                    callPayload.Body = mSExcelCopySelection;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelCutSelection([WorkflowExpression] Func<string> mSExcelCutSelectionworkflow, [WorkflowExpression] Func<int> mSExcelCutSelectionhandle = null, [WorkflowExpression] Func<string> mSExcelCutSelectionworkbookName = null, [WorkflowExpression] Func<string> mSExcelCutSelectionworksheetName = null, [WorkflowExpression] Func<string> mSExcelCutSelectioncellReference = null, [WorkflowExpression] Func<bool> mSExcelCutSelectionentireRow = null, [WorkflowExpression] Func<bool> mSExcelCutSelectionentireColumn = null)
        {
            SourceExpression.Validate(mSExcelCutSelectionworkflow, nameof(mSExcelCutSelectionworkflow), required: true);
            SourceExpression.Validate(mSExcelCutSelectionhandle, nameof(mSExcelCutSelectionhandle), required: false);
            SourceExpression.Validate(mSExcelCutSelectionworkbookName, nameof(mSExcelCutSelectionworkbookName), required: false);
            SourceExpression.Validate(mSExcelCutSelectionworksheetName, nameof(mSExcelCutSelectionworksheetName), required: false);
            SourceExpression.Validate(mSExcelCutSelectioncellReference, nameof(mSExcelCutSelectioncellReference), required: false);
            SourceExpression.Validate(mSExcelCutSelectionentireRow, nameof(mSExcelCutSelectionentireRow), required: false);
            SourceExpression.Validate(mSExcelCutSelectionentireColumn, nameof(mSExcelCutSelectionentireColumn), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSExcelCutSelection["Handle"] = SourceExpressionConverter.ConvertToken(mSExcelCutSelectionhandle);
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
                    mSExcelCutSelection["WorkbookName"] = SourceExpressionConverter.ConvertToken(mSExcelCutSelectionworkbookName);
                    mSExcelCutSelectionpropCount++;
                }

                if (mSExcelCutSelectionworksheetName != null)
                {
                    mSExcelCutSelection["WorksheetName"] = SourceExpressionConverter.ConvertToken(mSExcelCutSelectionworksheetName);
                    mSExcelCutSelectionpropCount++;
                }

                if (mSExcelCutSelectioncellReference != null)
                {
                    mSExcelCutSelection["CellReference"] = SourceExpressionConverter.ConvertToken(mSExcelCutSelectioncellReference);
                    mSExcelCutSelectionpropCount++;
                }

                if (mSExcelCutSelectionentireRow != null)
                {
                    if (mSExcelCutSelectionentireRow != null)
                    {
                        mSExcelCutSelection["EntireRow"] = SourceExpressionConverter.ConvertToken(mSExcelCutSelectionentireRow);
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
                        mSExcelCutSelection["EntireColumn"] = SourceExpressionConverter.ConvertToken(mSExcelCutSelectionentireColumn);
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
                mSExcelCutSelection["Workflow"] = SourceExpressionConverter.ConvertToken(mSExcelCutSelectionworkflow);
                if (mSExcelCutSelectionpropCount > 0)
                {
                    callPayload.Body = mSExcelCutSelection;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelPasteIntoSelection([WorkflowExpression] Func<string> mSExcelPasteIntoSelectionworkflow, [WorkflowExpression] Func<int> mSExcelPasteIntoSelectionhandle = null, [WorkflowExpression] Func<string> mSExcelPasteIntoSelectionworkbookName = null, [WorkflowExpression] Func<string> mSExcelPasteIntoSelectionworksheetName = null, [WorkflowExpression] Func<bool> mSExcelPasteIntoSelectionvaluesOnly = null, [WorkflowExpression] Func<bool> mSExcelPasteIntoSelectionsimplePasteOnly = null, [WorkflowExpression] Func<string> mSExcelPasteIntoSelectioncellReference = null, [WorkflowExpression] Func<bool> mSExcelPasteIntoSelectionentireRow = null, [WorkflowExpression] Func<bool> mSExcelPasteIntoSelectionentireColumn = null)
        {
            SourceExpression.Validate(mSExcelPasteIntoSelectionworkflow, nameof(mSExcelPasteIntoSelectionworkflow), required: true);
            SourceExpression.Validate(mSExcelPasteIntoSelectionhandle, nameof(mSExcelPasteIntoSelectionhandle), required: false);
            SourceExpression.Validate(mSExcelPasteIntoSelectionworkbookName, nameof(mSExcelPasteIntoSelectionworkbookName), required: false);
            SourceExpression.Validate(mSExcelPasteIntoSelectionworksheetName, nameof(mSExcelPasteIntoSelectionworksheetName), required: false);
            SourceExpression.Validate(mSExcelPasteIntoSelectionvaluesOnly, nameof(mSExcelPasteIntoSelectionvaluesOnly), required: false);
            SourceExpression.Validate(mSExcelPasteIntoSelectionsimplePasteOnly, nameof(mSExcelPasteIntoSelectionsimplePasteOnly), required: false);
            SourceExpression.Validate(mSExcelPasteIntoSelectioncellReference, nameof(mSExcelPasteIntoSelectioncellReference), required: false);
            SourceExpression.Validate(mSExcelPasteIntoSelectionentireRow, nameof(mSExcelPasteIntoSelectionentireRow), required: false);
            SourceExpression.Validate(mSExcelPasteIntoSelectionentireColumn, nameof(mSExcelPasteIntoSelectionentireColumn), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSExcelPasteIntoSelection["Handle"] = SourceExpressionConverter.ConvertToken(mSExcelPasteIntoSelectionhandle);
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
                    mSExcelPasteIntoSelection["WorkbookName"] = SourceExpressionConverter.ConvertToken(mSExcelPasteIntoSelectionworkbookName);
                    mSExcelPasteIntoSelectionpropCount++;
                }

                if (mSExcelPasteIntoSelectionworksheetName != null)
                {
                    mSExcelPasteIntoSelection["WorksheetName"] = SourceExpressionConverter.ConvertToken(mSExcelPasteIntoSelectionworksheetName);
                    mSExcelPasteIntoSelectionpropCount++;
                }

                if (mSExcelPasteIntoSelectionvaluesOnly != null)
                {
                    if (mSExcelPasteIntoSelectionvaluesOnly != null)
                    {
                        mSExcelPasteIntoSelection["ValuesOnly"] = SourceExpressionConverter.ConvertToken(mSExcelPasteIntoSelectionvaluesOnly);
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
                        mSExcelPasteIntoSelection["SimplePasteOnly"] = SourceExpressionConverter.ConvertToken(mSExcelPasteIntoSelectionsimplePasteOnly);
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
                    mSExcelPasteIntoSelection["CellReference"] = SourceExpressionConverter.ConvertToken(mSExcelPasteIntoSelectioncellReference);
                    mSExcelPasteIntoSelectionpropCount++;
                }

                if (mSExcelPasteIntoSelectionentireRow != null)
                {
                    if (mSExcelPasteIntoSelectionentireRow != null)
                    {
                        mSExcelPasteIntoSelection["EntireRow"] = SourceExpressionConverter.ConvertToken(mSExcelPasteIntoSelectionentireRow);
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
                        mSExcelPasteIntoSelection["EntireColumn"] = SourceExpressionConverter.ConvertToken(mSExcelPasteIntoSelectionentireColumn);
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
                mSExcelPasteIntoSelection["Workflow"] = SourceExpressionConverter.ConvertToken(mSExcelPasteIntoSelectionworkflow);
                if (mSExcelPasteIntoSelectionpropCount > 0)
                {
                    callPayload.Body = mSExcelPasteIntoSelection;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelInsertOnSelection([WorkflowExpression] Func<string> mSExcelInsertOnSelectionworkflow, [WorkflowExpression] Func<int> mSExcelInsertOnSelectionhandle = null, [WorkflowExpression] Func<string> mSExcelInsertOnSelectionworkbookName = null, [WorkflowExpression] Func<string> mSExcelInsertOnSelectionworksheetName = null, [WorkflowExpression] Func<string> mSExcelInsertOnSelectioncellReference = null, [WorkflowExpression] Func<bool> mSExcelInsertOnSelectionentireRow = null, [WorkflowExpression] Func<bool> mSExcelInsertOnSelectionentireColumn = null, [WorkflowExpression] Func<mSExcelInsertOnSelectionshiftInput> mSExcelInsertOnSelectionshift = null)
        {
            SourceExpression.Validate(mSExcelInsertOnSelectionworkflow, nameof(mSExcelInsertOnSelectionworkflow), required: true);
            SourceExpression.Validate(mSExcelInsertOnSelectionhandle, nameof(mSExcelInsertOnSelectionhandle), required: false);
            SourceExpression.Validate(mSExcelInsertOnSelectionworkbookName, nameof(mSExcelInsertOnSelectionworkbookName), required: false);
            SourceExpression.Validate(mSExcelInsertOnSelectionworksheetName, nameof(mSExcelInsertOnSelectionworksheetName), required: false);
            SourceExpression.Validate(mSExcelInsertOnSelectioncellReference, nameof(mSExcelInsertOnSelectioncellReference), required: false);
            SourceExpression.Validate(mSExcelInsertOnSelectionentireRow, nameof(mSExcelInsertOnSelectionentireRow), required: false);
            SourceExpression.Validate(mSExcelInsertOnSelectionentireColumn, nameof(mSExcelInsertOnSelectionentireColumn), required: false);
            SourceExpression.Validate(mSExcelInsertOnSelectionshift, nameof(mSExcelInsertOnSelectionshift), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSExcelInsertOnSelection["Handle"] = SourceExpressionConverter.ConvertToken(mSExcelInsertOnSelectionhandle);
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
                    mSExcelInsertOnSelection["WorkbookName"] = SourceExpressionConverter.ConvertToken(mSExcelInsertOnSelectionworkbookName);
                    mSExcelInsertOnSelectionpropCount++;
                }

                if (mSExcelInsertOnSelectionworksheetName != null)
                {
                    mSExcelInsertOnSelection["WorksheetName"] = SourceExpressionConverter.ConvertToken(mSExcelInsertOnSelectionworksheetName);
                    mSExcelInsertOnSelectionpropCount++;
                }

                if (mSExcelInsertOnSelectioncellReference != null)
                {
                    mSExcelInsertOnSelection["CellReference"] = SourceExpressionConverter.ConvertToken(mSExcelInsertOnSelectioncellReference);
                    mSExcelInsertOnSelectionpropCount++;
                }

                if (mSExcelInsertOnSelectionentireRow != null)
                {
                    if (mSExcelInsertOnSelectionentireRow != null)
                    {
                        mSExcelInsertOnSelection["EntireRow"] = SourceExpressionConverter.ConvertToken(mSExcelInsertOnSelectionentireRow);
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
                        mSExcelInsertOnSelection["EntireColumn"] = SourceExpressionConverter.ConvertToken(mSExcelInsertOnSelectionentireColumn);
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
                    mSExcelInsertOnSelection["Shift"] = SourceExpressionConverter.Convert(mSExcelInsertOnSelectionshift);
                    mSExcelInsertOnSelectionpropCount++;
                }

                mSExcelInsertOnSelectionpropCount++;
                mSExcelInsertOnSelection["Workflow"] = SourceExpressionConverter.ConvertToken(mSExcelInsertOnSelectionworkflow);
                if (mSExcelInsertOnSelectionpropCount > 0)
                {
                    callPayload.Body = mSExcelInsertOnSelection;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelDeleteSelection([WorkflowExpression] Func<string> mSExcelDeleteSelectionworkflow, [WorkflowExpression] Func<int> mSExcelDeleteSelectionhandle = null, [WorkflowExpression] Func<string> mSExcelDeleteSelectionworkbookName = null, [WorkflowExpression] Func<string> mSExcelDeleteSelectionworksheetName = null, [WorkflowExpression] Func<string> mSExcelDeleteSelectioncellReference = null, [WorkflowExpression] Func<bool> mSExcelDeleteSelectionentireRow = null, [WorkflowExpression] Func<bool> mSExcelDeleteSelectionentireColumn = null, [WorkflowExpression] Func<mSExcelDeleteSelectionshiftInput> mSExcelDeleteSelectionshift = null)
        {
            SourceExpression.Validate(mSExcelDeleteSelectionworkflow, nameof(mSExcelDeleteSelectionworkflow), required: true);
            SourceExpression.Validate(mSExcelDeleteSelectionhandle, nameof(mSExcelDeleteSelectionhandle), required: false);
            SourceExpression.Validate(mSExcelDeleteSelectionworkbookName, nameof(mSExcelDeleteSelectionworkbookName), required: false);
            SourceExpression.Validate(mSExcelDeleteSelectionworksheetName, nameof(mSExcelDeleteSelectionworksheetName), required: false);
            SourceExpression.Validate(mSExcelDeleteSelectioncellReference, nameof(mSExcelDeleteSelectioncellReference), required: false);
            SourceExpression.Validate(mSExcelDeleteSelectionentireRow, nameof(mSExcelDeleteSelectionentireRow), required: false);
            SourceExpression.Validate(mSExcelDeleteSelectionentireColumn, nameof(mSExcelDeleteSelectionentireColumn), required: false);
            SourceExpression.Validate(mSExcelDeleteSelectionshift, nameof(mSExcelDeleteSelectionshift), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSExcelDeleteSelection["Handle"] = SourceExpressionConverter.ConvertToken(mSExcelDeleteSelectionhandle);
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
                    mSExcelDeleteSelection["WorkbookName"] = SourceExpressionConverter.ConvertToken(mSExcelDeleteSelectionworkbookName);
                    mSExcelDeleteSelectionpropCount++;
                }

                if (mSExcelDeleteSelectionworksheetName != null)
                {
                    mSExcelDeleteSelection["WorksheetName"] = SourceExpressionConverter.ConvertToken(mSExcelDeleteSelectionworksheetName);
                    mSExcelDeleteSelectionpropCount++;
                }

                if (mSExcelDeleteSelectioncellReference != null)
                {
                    mSExcelDeleteSelection["CellReference"] = SourceExpressionConverter.ConvertToken(mSExcelDeleteSelectioncellReference);
                    mSExcelDeleteSelectionpropCount++;
                }

                if (mSExcelDeleteSelectionentireRow != null)
                {
                    if (mSExcelDeleteSelectionentireRow != null)
                    {
                        mSExcelDeleteSelection["EntireRow"] = SourceExpressionConverter.ConvertToken(mSExcelDeleteSelectionentireRow);
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
                        mSExcelDeleteSelection["EntireColumn"] = SourceExpressionConverter.ConvertToken(mSExcelDeleteSelectionentireColumn);
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
                    mSExcelDeleteSelection["Shift"] = SourceExpressionConverter.Convert(mSExcelDeleteSelectionshift);
                    mSExcelDeleteSelectionpropCount++;
                }

                mSExcelDeleteSelectionpropCount++;
                mSExcelDeleteSelection["Workflow"] = SourceExpressionConverter.ConvertToken(mSExcelDeleteSelectionworkflow);
                if (mSExcelDeleteSelectionpropCount > 0)
                {
                    callPayload.Body = mSExcelDeleteSelection;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelClearExcelClipboard([WorkflowExpression] Func<string> mSExcelClearExcelClipboardworkflow, [WorkflowExpression] Func<int> mSExcelClearExcelClipboardhandle = null)
        {
            SourceExpression.Validate(mSExcelClearExcelClipboardworkflow, nameof(mSExcelClearExcelClipboardworkflow), required: true);
            SourceExpression.Validate(mSExcelClearExcelClipboardhandle, nameof(mSExcelClearExcelClipboardhandle), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSExcelClearExcelClipboard["Handle"] = SourceExpressionConverter.ConvertToken(mSExcelClearExcelClipboardhandle);
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
                mSExcelClearExcelClipboard["Workflow"] = SourceExpressionConverter.ConvertToken(mSExcelClearExcelClipboardworkflow);
                if (mSExcelClearExcelClipboardpropCount > 0)
                {
                    callPayload.Body = mSExcelClearExcelClipboard;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelRunMacroResponse> MSExcelRunMacro([WorkflowExpression] Func<string> mSExcelRunMacromacroName, [WorkflowExpression] Func<string> mSExcelRunMacroworkflow, [WorkflowExpression] Func<int> mSExcelRunMacrohandle = null, [WorkflowExpression] Func<int> mSExcelRunMacronumberOfArguments = null, [WorkflowExpression] Func<string> mSExcelRunMacroargument1 = null, [WorkflowExpression] Func<string> mSExcelRunMacroargument2 = null, [WorkflowExpression] Func<string> mSExcelRunMacroargument3 = null, [WorkflowExpression] Func<string> mSExcelRunMacroargument4 = null, [WorkflowExpression] Func<string> mSExcelRunMacroargument5 = null, [WorkflowExpression] Func<string> mSExcelRunMacroargument6 = null, [WorkflowExpression] Func<string> mSExcelRunMacroargument7 = null, [WorkflowExpression] Func<string> mSExcelRunMacroargument8 = null, [WorkflowExpression] Func<string> mSExcelRunMacroargument9 = null, [WorkflowExpression] Func<string> mSExcelRunMacroargument10 = null, [WorkflowExpression] Func<bool> mSExcelRunMacrorunInBackground = null)
        {
            SourceExpression.Validate(mSExcelRunMacromacroName, nameof(mSExcelRunMacromacroName), required: true);
            SourceExpression.Validate(mSExcelRunMacroworkflow, nameof(mSExcelRunMacroworkflow), required: true);
            SourceExpression.Validate(mSExcelRunMacrohandle, nameof(mSExcelRunMacrohandle), required: false);
            SourceExpression.Validate(mSExcelRunMacronumberOfArguments, nameof(mSExcelRunMacronumberOfArguments), required: false);
            SourceExpression.Validate(mSExcelRunMacroargument1, nameof(mSExcelRunMacroargument1), required: false);
            SourceExpression.Validate(mSExcelRunMacroargument2, nameof(mSExcelRunMacroargument2), required: false);
            SourceExpression.Validate(mSExcelRunMacroargument3, nameof(mSExcelRunMacroargument3), required: false);
            SourceExpression.Validate(mSExcelRunMacroargument4, nameof(mSExcelRunMacroargument4), required: false);
            SourceExpression.Validate(mSExcelRunMacroargument5, nameof(mSExcelRunMacroargument5), required: false);
            SourceExpression.Validate(mSExcelRunMacroargument6, nameof(mSExcelRunMacroargument6), required: false);
            SourceExpression.Validate(mSExcelRunMacroargument7, nameof(mSExcelRunMacroargument7), required: false);
            SourceExpression.Validate(mSExcelRunMacroargument8, nameof(mSExcelRunMacroargument8), required: false);
            SourceExpression.Validate(mSExcelRunMacroargument9, nameof(mSExcelRunMacroargument9), required: false);
            SourceExpression.Validate(mSExcelRunMacroargument10, nameof(mSExcelRunMacroargument10), required: false);
            SourceExpression.Validate(mSExcelRunMacrorunInBackground, nameof(mSExcelRunMacrorunInBackground), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSExcelRunMacro["Handle"] = SourceExpressionConverter.ConvertToken(mSExcelRunMacrohandle);
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
                mSExcelRunMacro["MacroName"] = SourceExpressionConverter.ConvertToken(mSExcelRunMacromacroName);
                if (mSExcelRunMacronumberOfArguments != null)
                {
                    mSExcelRunMacro["NumberOfArguments"] = SourceExpressionConverter.ConvertToken(mSExcelRunMacronumberOfArguments);
                    mSExcelRunMacropropCount++;
                }

                if (mSExcelRunMacroargument1 != null)
                {
                    mSExcelRunMacro["Argument1"] = SourceExpressionConverter.ConvertToken(mSExcelRunMacroargument1);
                    mSExcelRunMacropropCount++;
                }

                if (mSExcelRunMacroargument2 != null)
                {
                    mSExcelRunMacro["Argument2"] = SourceExpressionConverter.ConvertToken(mSExcelRunMacroargument2);
                    mSExcelRunMacropropCount++;
                }

                if (mSExcelRunMacroargument3 != null)
                {
                    mSExcelRunMacro["Argument3"] = SourceExpressionConverter.ConvertToken(mSExcelRunMacroargument3);
                    mSExcelRunMacropropCount++;
                }

                if (mSExcelRunMacroargument4 != null)
                {
                    mSExcelRunMacro["Argument4"] = SourceExpressionConverter.ConvertToken(mSExcelRunMacroargument4);
                    mSExcelRunMacropropCount++;
                }

                if (mSExcelRunMacroargument5 != null)
                {
                    mSExcelRunMacro["Argument5"] = SourceExpressionConverter.ConvertToken(mSExcelRunMacroargument5);
                    mSExcelRunMacropropCount++;
                }

                if (mSExcelRunMacroargument6 != null)
                {
                    mSExcelRunMacro["Argument6"] = SourceExpressionConverter.ConvertToken(mSExcelRunMacroargument6);
                    mSExcelRunMacropropCount++;
                }

                if (mSExcelRunMacroargument7 != null)
                {
                    mSExcelRunMacro["Argument7"] = SourceExpressionConverter.ConvertToken(mSExcelRunMacroargument7);
                    mSExcelRunMacropropCount++;
                }

                if (mSExcelRunMacroargument8 != null)
                {
                    mSExcelRunMacro["Argument8"] = SourceExpressionConverter.ConvertToken(mSExcelRunMacroargument8);
                    mSExcelRunMacropropCount++;
                }

                if (mSExcelRunMacroargument9 != null)
                {
                    mSExcelRunMacro["Argument9"] = SourceExpressionConverter.ConvertToken(mSExcelRunMacroargument9);
                    mSExcelRunMacropropCount++;
                }

                if (mSExcelRunMacroargument10 != null)
                {
                    mSExcelRunMacro["Argument10"] = SourceExpressionConverter.ConvertToken(mSExcelRunMacroargument10);
                    mSExcelRunMacropropCount++;
                }

                if (mSExcelRunMacrorunInBackground != null)
                {
                    if (mSExcelRunMacrorunInBackground != null)
                    {
                        mSExcelRunMacro["RunInBackground"] = SourceExpressionConverter.ConvertToken(mSExcelRunMacrorunInBackground);
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
                mSExcelRunMacro["Workflow"] = SourceExpressionConverter.ConvertToken(mSExcelRunMacroworkflow);
                if (mSExcelRunMacropropCount > 0)
                {
                    callPayload.Body = mSExcelRunMacro;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MSExcelRunMacroResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelAddMacroToWorkbook([WorkflowExpression] Func<string> mSExcelAddMacroToWorkbookmacroCode, [WorkflowExpression] Func<string> mSExcelAddMacroToWorkbookworkflow, [WorkflowExpression] Func<int> mSExcelAddMacroToWorkbookhandle = null, [WorkflowExpression] Func<string> mSExcelAddMacroToWorkbookworkbookName = null)
        {
            SourceExpression.Validate(mSExcelAddMacroToWorkbookmacroCode, nameof(mSExcelAddMacroToWorkbookmacroCode), required: true);
            SourceExpression.Validate(mSExcelAddMacroToWorkbookworkflow, nameof(mSExcelAddMacroToWorkbookworkflow), required: true);
            SourceExpression.Validate(mSExcelAddMacroToWorkbookhandle, nameof(mSExcelAddMacroToWorkbookhandle), required: false);
            SourceExpression.Validate(mSExcelAddMacroToWorkbookworkbookName, nameof(mSExcelAddMacroToWorkbookworkbookName), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSExcelAddMacroToWorkbook["Handle"] = SourceExpressionConverter.ConvertToken(mSExcelAddMacroToWorkbookhandle);
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
                    mSExcelAddMacroToWorkbook["WorkbookName"] = SourceExpressionConverter.ConvertToken(mSExcelAddMacroToWorkbookworkbookName);
                    mSExcelAddMacroToWorkbookpropCount++;
                }

                mSExcelAddMacroToWorkbookpropCount++;
                mSExcelAddMacroToWorkbook["MacroCode"] = SourceExpressionConverter.ConvertToken(mSExcelAddMacroToWorkbookmacroCode);
                mSExcelAddMacroToWorkbookpropCount++;
                mSExcelAddMacroToWorkbook["Workflow"] = SourceExpressionConverter.ConvertToken(mSExcelAddMacroToWorkbookworkflow);
                if (mSExcelAddMacroToWorkbookpropCount > 0)
                {
                    callPayload.Body = mSExcelAddMacroToWorkbook;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelTrustVBOMInRegistry([WorkflowExpression] Func<string> mSExcelTrustVBOMInRegistryworkflow, [WorkflowExpression] Func<int> mSExcelTrustVBOMInRegistryexcelVersion = null, [WorkflowExpression] Func<bool> mSExcelTrustVBOMInRegistrytrustVBOM = null)
        {
            SourceExpression.Validate(mSExcelTrustVBOMInRegistryworkflow, nameof(mSExcelTrustVBOMInRegistryworkflow), required: true);
            SourceExpression.Validate(mSExcelTrustVBOMInRegistryexcelVersion, nameof(mSExcelTrustVBOMInRegistryexcelVersion), required: false);
            SourceExpression.Validate(mSExcelTrustVBOMInRegistrytrustVBOM, nameof(mSExcelTrustVBOMInRegistrytrustVBOM), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/MSExcel/TrustVBOMInRegistry";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSExcelTrustVBOMInRegistry = new JObject();
                var mSExcelTrustVBOMInRegistrypropCount = 0;
                if (mSExcelTrustVBOMInRegistryexcelVersion != null)
                {
                    mSExcelTrustVBOMInRegistry["ExcelVersion"] = SourceExpressionConverter.ConvertToken(mSExcelTrustVBOMInRegistryexcelVersion);
                    mSExcelTrustVBOMInRegistrypropCount++;
                }

                if (mSExcelTrustVBOMInRegistrytrustVBOM != null)
                {
                    if (mSExcelTrustVBOMInRegistrytrustVBOM != null)
                    {
                        mSExcelTrustVBOMInRegistry["TrustVBOM"] = SourceExpressionConverter.ConvertToken(mSExcelTrustVBOMInRegistrytrustVBOM);
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
                mSExcelTrustVBOMInRegistry["Workflow"] = SourceExpressionConverter.ConvertToken(mSExcelTrustVBOMInRegistryworkflow);
                if (mSExcelTrustVBOMInRegistrypropCount > 0)
                {
                    callPayload.Body = mSExcelTrustVBOMInRegistry;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelSetCalculationMode([WorkflowExpression] Func<int> mSExcelSetCalculationModecalculationMode, [WorkflowExpression] Func<string> mSExcelSetCalculationModeworkflow, [WorkflowExpression] Func<int> mSExcelSetCalculationModehandle = null)
        {
            SourceExpression.Validate(mSExcelSetCalculationModecalculationMode, nameof(mSExcelSetCalculationModecalculationMode), required: true);
            SourceExpression.Validate(mSExcelSetCalculationModeworkflow, nameof(mSExcelSetCalculationModeworkflow), required: true);
            SourceExpression.Validate(mSExcelSetCalculationModehandle, nameof(mSExcelSetCalculationModehandle), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSExcelSetCalculationMode["Handle"] = SourceExpressionConverter.ConvertToken(mSExcelSetCalculationModehandle);
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
                mSExcelSetCalculationMode["CalculationMode"] = SourceExpressionConverter.ConvertToken(mSExcelSetCalculationModecalculationMode);
                mSExcelSetCalculationModepropCount++;
                mSExcelSetCalculationMode["Workflow"] = SourceExpressionConverter.ConvertToken(mSExcelSetCalculationModeworkflow);
                if (mSExcelSetCalculationModepropCount > 0)
                {
                    callPayload.Body = mSExcelSetCalculationMode;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSExcelExecuteCommandBarObject([WorkflowExpression] Func<string> mSExcelExecuteCommandBarObjectobjectId, [WorkflowExpression] Func<string> mSExcelExecuteCommandBarObjectworkflow, [WorkflowExpression] Func<int> mSExcelExecuteCommandBarObjecthandle = null, [WorkflowExpression] Func<bool> mSExcelExecuteCommandBarObjectrunInBackground = null)
        {
            SourceExpression.Validate(mSExcelExecuteCommandBarObjectobjectId, nameof(mSExcelExecuteCommandBarObjectobjectId), required: true);
            SourceExpression.Validate(mSExcelExecuteCommandBarObjectworkflow, nameof(mSExcelExecuteCommandBarObjectworkflow), required: true);
            SourceExpression.Validate(mSExcelExecuteCommandBarObjecthandle, nameof(mSExcelExecuteCommandBarObjecthandle), required: false);
            SourceExpression.Validate(mSExcelExecuteCommandBarObjectrunInBackground, nameof(mSExcelExecuteCommandBarObjectrunInBackground), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSExcelExecuteCommandBarObject["Handle"] = SourceExpressionConverter.ConvertToken(mSExcelExecuteCommandBarObjecthandle);
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
                mSExcelExecuteCommandBarObject["ObjectId"] = SourceExpressionConverter.ConvertToken(mSExcelExecuteCommandBarObjectobjectId);
                if (mSExcelExecuteCommandBarObjectrunInBackground != null)
                {
                    if (mSExcelExecuteCommandBarObjectrunInBackground != null)
                    {
                        mSExcelExecuteCommandBarObject["RunInBackground"] = SourceExpressionConverter.ConvertToken(mSExcelExecuteCommandBarObjectrunInBackground);
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
                mSExcelExecuteCommandBarObject["Workflow"] = SourceExpressionConverter.ConvertToken(mSExcelExecuteCommandBarObjectworkflow);
                if (mSExcelExecuteCommandBarObjectpropCount > 0)
                {
                    callPayload.Body = mSExcelExecuteCommandBarObject;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelCopyBetweenCellsResponse> MSExcelCopyBetweenCells([WorkflowExpression] Func<string> mSExcelCopyBetweenCellssourceCellReference, [WorkflowExpression] Func<string> mSExcelCopyBetweenCellstargetCellReference, [WorkflowExpression] Func<string> mSExcelCopyBetweenCellsworkflow, [WorkflowExpression] Func<int> mSExcelCopyBetweenCellssourceHandle = null, [WorkflowExpression] Func<string> mSExcelCopyBetweenCellssourceWorkbookName = null, [WorkflowExpression] Func<string> mSExcelCopyBetweenCellssourceWorksheetName = null, [WorkflowExpression] Func<bool> mSExcelCopyBetweenCellssourceEntireRow = null, [WorkflowExpression] Func<bool> mSExcelCopyBetweenCellssourceEntireColumn = null, [WorkflowExpression] Func<int> mSExcelCopyBetweenCellstargetHandle = null, [WorkflowExpression] Func<string> mSExcelCopyBetweenCellstargetWorkbookName = null, [WorkflowExpression] Func<string> mSExcelCopyBetweenCellstargetWorksheetName = null, [WorkflowExpression] Func<bool> mSExcelCopyBetweenCellstargetEntireRow = null, [WorkflowExpression] Func<bool> mSExcelCopyBetweenCellstargetEntireColumn = null, [WorkflowExpression] Func<bool> mSExcelCopyBetweenCellsvaluesOnly = null, [WorkflowExpression] Func<bool> mSExcelCopyBetweenCellssimplePasteOnly = null)
        {
            SourceExpression.Validate(mSExcelCopyBetweenCellssourceCellReference, nameof(mSExcelCopyBetweenCellssourceCellReference), required: true);
            SourceExpression.Validate(mSExcelCopyBetweenCellstargetCellReference, nameof(mSExcelCopyBetweenCellstargetCellReference), required: true);
            SourceExpression.Validate(mSExcelCopyBetweenCellsworkflow, nameof(mSExcelCopyBetweenCellsworkflow), required: true);
            SourceExpression.Validate(mSExcelCopyBetweenCellssourceHandle, nameof(mSExcelCopyBetweenCellssourceHandle), required: false);
            SourceExpression.Validate(mSExcelCopyBetweenCellssourceWorkbookName, nameof(mSExcelCopyBetweenCellssourceWorkbookName), required: false);
            SourceExpression.Validate(mSExcelCopyBetweenCellssourceWorksheetName, nameof(mSExcelCopyBetweenCellssourceWorksheetName), required: false);
            SourceExpression.Validate(mSExcelCopyBetweenCellssourceEntireRow, nameof(mSExcelCopyBetweenCellssourceEntireRow), required: false);
            SourceExpression.Validate(mSExcelCopyBetweenCellssourceEntireColumn, nameof(mSExcelCopyBetweenCellssourceEntireColumn), required: false);
            SourceExpression.Validate(mSExcelCopyBetweenCellstargetHandle, nameof(mSExcelCopyBetweenCellstargetHandle), required: false);
            SourceExpression.Validate(mSExcelCopyBetweenCellstargetWorkbookName, nameof(mSExcelCopyBetweenCellstargetWorkbookName), required: false);
            SourceExpression.Validate(mSExcelCopyBetweenCellstargetWorksheetName, nameof(mSExcelCopyBetweenCellstargetWorksheetName), required: false);
            SourceExpression.Validate(mSExcelCopyBetweenCellstargetEntireRow, nameof(mSExcelCopyBetweenCellstargetEntireRow), required: false);
            SourceExpression.Validate(mSExcelCopyBetweenCellstargetEntireColumn, nameof(mSExcelCopyBetweenCellstargetEntireColumn), required: false);
            SourceExpression.Validate(mSExcelCopyBetweenCellsvaluesOnly, nameof(mSExcelCopyBetweenCellsvaluesOnly), required: false);
            SourceExpression.Validate(mSExcelCopyBetweenCellssimplePasteOnly, nameof(mSExcelCopyBetweenCellssimplePasteOnly), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSExcelCopyBetweenCells["SourceHandle"] = SourceExpressionConverter.ConvertToken(mSExcelCopyBetweenCellssourceHandle);
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
                    mSExcelCopyBetweenCells["SourceWorkbookName"] = SourceExpressionConverter.ConvertToken(mSExcelCopyBetweenCellssourceWorkbookName);
                    mSExcelCopyBetweenCellspropCount++;
                }

                if (mSExcelCopyBetweenCellssourceWorksheetName != null)
                {
                    mSExcelCopyBetweenCells["SourceWorksheetName"] = SourceExpressionConverter.ConvertToken(mSExcelCopyBetweenCellssourceWorksheetName);
                    mSExcelCopyBetweenCellspropCount++;
                }

                mSExcelCopyBetweenCellspropCount++;
                mSExcelCopyBetweenCells["SourceCellReference"] = SourceExpressionConverter.ConvertToken(mSExcelCopyBetweenCellssourceCellReference);
                if (mSExcelCopyBetweenCellssourceEntireRow != null)
                {
                    if (mSExcelCopyBetweenCellssourceEntireRow != null)
                    {
                        mSExcelCopyBetweenCells["SourceEntireRow"] = SourceExpressionConverter.ConvertToken(mSExcelCopyBetweenCellssourceEntireRow);
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
                        mSExcelCopyBetweenCells["SourceEntireColumn"] = SourceExpressionConverter.ConvertToken(mSExcelCopyBetweenCellssourceEntireColumn);
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
                        mSExcelCopyBetweenCells["TargetHandle"] = SourceExpressionConverter.ConvertToken(mSExcelCopyBetweenCellstargetHandle);
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
                    mSExcelCopyBetweenCells["TargetWorkbookName"] = SourceExpressionConverter.ConvertToken(mSExcelCopyBetweenCellstargetWorkbookName);
                    mSExcelCopyBetweenCellspropCount++;
                }

                if (mSExcelCopyBetweenCellstargetWorksheetName != null)
                {
                    mSExcelCopyBetweenCells["TargetWorksheetName"] = SourceExpressionConverter.ConvertToken(mSExcelCopyBetweenCellstargetWorksheetName);
                    mSExcelCopyBetweenCellspropCount++;
                }

                mSExcelCopyBetweenCellspropCount++;
                mSExcelCopyBetweenCells["TargetCellReference"] = SourceExpressionConverter.ConvertToken(mSExcelCopyBetweenCellstargetCellReference);
                if (mSExcelCopyBetweenCellstargetEntireRow != null)
                {
                    if (mSExcelCopyBetweenCellstargetEntireRow != null)
                    {
                        mSExcelCopyBetweenCells["TargetEntireRow"] = SourceExpressionConverter.ConvertToken(mSExcelCopyBetweenCellstargetEntireRow);
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
                        mSExcelCopyBetweenCells["TargetEntireColumn"] = SourceExpressionConverter.ConvertToken(mSExcelCopyBetweenCellstargetEntireColumn);
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
                        mSExcelCopyBetweenCells["ValuesOnly"] = SourceExpressionConverter.ConvertToken(mSExcelCopyBetweenCellsvaluesOnly);
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
                        mSExcelCopyBetweenCells["SimplePasteOnly"] = SourceExpressionConverter.ConvertToken(mSExcelCopyBetweenCellssimplePasteOnly);
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
                mSExcelCopyBetweenCells["Workflow"] = SourceExpressionConverter.ConvertToken(mSExcelCopyBetweenCellsworkflow);
                if (mSExcelCopyBetweenCellspropCount > 0)
                {
                    callPayload.Body = mSExcelCopyBetweenCells;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MSExcelCopyBetweenCellsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelCutBetweenCellsResponse> MSExcelCutBetweenCells([WorkflowExpression] Func<string> mSExcelCutBetweenCellssourceCellReference, [WorkflowExpression] Func<string> mSExcelCutBetweenCellstargetCellReference, [WorkflowExpression] Func<string> mSExcelCutBetweenCellsworkflow, [WorkflowExpression] Func<int> mSExcelCutBetweenCellssourceHandle = null, [WorkflowExpression] Func<string> mSExcelCutBetweenCellssourceWorkbookName = null, [WorkflowExpression] Func<string> mSExcelCutBetweenCellssourceWorksheetName = null, [WorkflowExpression] Func<bool> mSExcelCutBetweenCellssourceEntireRow = null, [WorkflowExpression] Func<bool> mSExcelCutBetweenCellssourceEntireColumn = null, [WorkflowExpression] Func<int> mSExcelCutBetweenCellstargetHandle = null, [WorkflowExpression] Func<string> mSExcelCutBetweenCellstargetWorkbookName = null, [WorkflowExpression] Func<string> mSExcelCutBetweenCellstargetWorksheetName = null, [WorkflowExpression] Func<bool> mSExcelCutBetweenCellstargetEntireRow = null, [WorkflowExpression] Func<bool> mSExcelCutBetweenCellstargetEntireColumn = null, [WorkflowExpression] Func<bool> mSExcelCutBetweenCellsvaluesOnly = null)
        {
            SourceExpression.Validate(mSExcelCutBetweenCellssourceCellReference, nameof(mSExcelCutBetweenCellssourceCellReference), required: true);
            SourceExpression.Validate(mSExcelCutBetweenCellstargetCellReference, nameof(mSExcelCutBetweenCellstargetCellReference), required: true);
            SourceExpression.Validate(mSExcelCutBetweenCellsworkflow, nameof(mSExcelCutBetweenCellsworkflow), required: true);
            SourceExpression.Validate(mSExcelCutBetweenCellssourceHandle, nameof(mSExcelCutBetweenCellssourceHandle), required: false);
            SourceExpression.Validate(mSExcelCutBetweenCellssourceWorkbookName, nameof(mSExcelCutBetweenCellssourceWorkbookName), required: false);
            SourceExpression.Validate(mSExcelCutBetweenCellssourceWorksheetName, nameof(mSExcelCutBetweenCellssourceWorksheetName), required: false);
            SourceExpression.Validate(mSExcelCutBetweenCellssourceEntireRow, nameof(mSExcelCutBetweenCellssourceEntireRow), required: false);
            SourceExpression.Validate(mSExcelCutBetweenCellssourceEntireColumn, nameof(mSExcelCutBetweenCellssourceEntireColumn), required: false);
            SourceExpression.Validate(mSExcelCutBetweenCellstargetHandle, nameof(mSExcelCutBetweenCellstargetHandle), required: false);
            SourceExpression.Validate(mSExcelCutBetweenCellstargetWorkbookName, nameof(mSExcelCutBetweenCellstargetWorkbookName), required: false);
            SourceExpression.Validate(mSExcelCutBetweenCellstargetWorksheetName, nameof(mSExcelCutBetweenCellstargetWorksheetName), required: false);
            SourceExpression.Validate(mSExcelCutBetweenCellstargetEntireRow, nameof(mSExcelCutBetweenCellstargetEntireRow), required: false);
            SourceExpression.Validate(mSExcelCutBetweenCellstargetEntireColumn, nameof(mSExcelCutBetweenCellstargetEntireColumn), required: false);
            SourceExpression.Validate(mSExcelCutBetweenCellsvaluesOnly, nameof(mSExcelCutBetweenCellsvaluesOnly), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSExcelCutBetweenCells["SourceHandle"] = SourceExpressionConverter.ConvertToken(mSExcelCutBetweenCellssourceHandle);
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
                    mSExcelCutBetweenCells["SourceWorkbookName"] = SourceExpressionConverter.ConvertToken(mSExcelCutBetweenCellssourceWorkbookName);
                    mSExcelCutBetweenCellspropCount++;
                }

                if (mSExcelCutBetweenCellssourceWorksheetName != null)
                {
                    mSExcelCutBetweenCells["SourceWorksheetName"] = SourceExpressionConverter.ConvertToken(mSExcelCutBetweenCellssourceWorksheetName);
                    mSExcelCutBetweenCellspropCount++;
                }

                mSExcelCutBetweenCellspropCount++;
                mSExcelCutBetweenCells["SourceCellReference"] = SourceExpressionConverter.ConvertToken(mSExcelCutBetweenCellssourceCellReference);
                if (mSExcelCutBetweenCellssourceEntireRow != null)
                {
                    if (mSExcelCutBetweenCellssourceEntireRow != null)
                    {
                        mSExcelCutBetweenCells["SourceEntireRow"] = SourceExpressionConverter.ConvertToken(mSExcelCutBetweenCellssourceEntireRow);
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
                        mSExcelCutBetweenCells["SourceEntireColumn"] = SourceExpressionConverter.ConvertToken(mSExcelCutBetweenCellssourceEntireColumn);
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
                        mSExcelCutBetweenCells["TargetHandle"] = SourceExpressionConverter.ConvertToken(mSExcelCutBetweenCellstargetHandle);
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
                    mSExcelCutBetweenCells["TargetWorkbookName"] = SourceExpressionConverter.ConvertToken(mSExcelCutBetweenCellstargetWorkbookName);
                    mSExcelCutBetweenCellspropCount++;
                }

                if (mSExcelCutBetweenCellstargetWorksheetName != null)
                {
                    mSExcelCutBetweenCells["TargetWorksheetName"] = SourceExpressionConverter.ConvertToken(mSExcelCutBetweenCellstargetWorksheetName);
                    mSExcelCutBetweenCellspropCount++;
                }

                mSExcelCutBetweenCellspropCount++;
                mSExcelCutBetweenCells["TargetCellReference"] = SourceExpressionConverter.ConvertToken(mSExcelCutBetweenCellstargetCellReference);
                if (mSExcelCutBetweenCellstargetEntireRow != null)
                {
                    if (mSExcelCutBetweenCellstargetEntireRow != null)
                    {
                        mSExcelCutBetweenCells["TargetEntireRow"] = SourceExpressionConverter.ConvertToken(mSExcelCutBetweenCellstargetEntireRow);
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
                        mSExcelCutBetweenCells["TargetEntireColumn"] = SourceExpressionConverter.ConvertToken(mSExcelCutBetweenCellstargetEntireColumn);
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
                        mSExcelCutBetweenCells["ValuesOnly"] = SourceExpressionConverter.ConvertToken(mSExcelCutBetweenCellsvaluesOnly);
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
                mSExcelCutBetweenCells["Workflow"] = SourceExpressionConverter.ConvertToken(mSExcelCutBetweenCellsworkflow);
                if (mSExcelCutBetweenCellspropCount > 0)
                {
                    callPayload.Body = mSExcelCutBetweenCells;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MSExcelCutBetweenCellsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelMinimiseWindowResponse> MSExcelMinimiseWindow([WorkflowExpression] Func<string> mSExcelMinimiseWindowworkflow, [WorkflowExpression] Func<int> mSExcelMinimiseWindowhandle = null)
        {
            SourceExpression.Validate(mSExcelMinimiseWindowworkflow, nameof(mSExcelMinimiseWindowworkflow), required: true);
            SourceExpression.Validate(mSExcelMinimiseWindowhandle, nameof(mSExcelMinimiseWindowhandle), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSExcelMinimiseWindow["Handle"] = SourceExpressionConverter.ConvertToken(mSExcelMinimiseWindowhandle);
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
                mSExcelMinimiseWindow["Workflow"] = SourceExpressionConverter.ConvertToken(mSExcelMinimiseWindowworkflow);
                if (mSExcelMinimiseWindowpropCount > 0)
                {
                    callPayload.Body = mSExcelMinimiseWindow;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MSExcelMinimiseWindowResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelMaximiseWindowResponse> MSExcelMaximiseWindow([WorkflowExpression] Func<string> mSExcelMaximiseWindowworkflow, [WorkflowExpression] Func<int> mSExcelMaximiseWindowhandle = null)
        {
            SourceExpression.Validate(mSExcelMaximiseWindowworkflow, nameof(mSExcelMaximiseWindowworkflow), required: true);
            SourceExpression.Validate(mSExcelMaximiseWindowhandle, nameof(mSExcelMaximiseWindowhandle), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSExcelMaximiseWindow["Handle"] = SourceExpressionConverter.ConvertToken(mSExcelMaximiseWindowhandle);
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
                mSExcelMaximiseWindow["Workflow"] = SourceExpressionConverter.ConvertToken(mSExcelMaximiseWindowworkflow);
                if (mSExcelMaximiseWindowpropCount > 0)
                {
                    callPayload.Body = mSExcelMaximiseWindow;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MSExcelMaximiseWindowResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelNormaliseWindowResponse> MSExcelNormaliseWindow([WorkflowExpression] Func<string> mSExcelNormaliseWindowworkflow, [WorkflowExpression] Func<int> mSExcelNormaliseWindowhandle = null)
        {
            SourceExpression.Validate(mSExcelNormaliseWindowworkflow, nameof(mSExcelNormaliseWindowworkflow), required: true);
            SourceExpression.Validate(mSExcelNormaliseWindowhandle, nameof(mSExcelNormaliseWindowhandle), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSExcelNormaliseWindow["Handle"] = SourceExpressionConverter.ConvertToken(mSExcelNormaliseWindowhandle);
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
                mSExcelNormaliseWindow["Workflow"] = SourceExpressionConverter.ConvertToken(mSExcelNormaliseWindowworkflow);
                if (mSExcelNormaliseWindowpropCount > 0)
                {
                    callPayload.Body = mSExcelNormaliseWindow;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MSExcelNormaliseWindowResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetAndSetCellValueResponse> MSExcelGetAndSetCellValue([WorkflowExpression] Func<string> mSExcelGetAndSetCellValuesourceCellReference, [WorkflowExpression] Func<string> mSExcelGetAndSetCellValuetargetCellReference, [WorkflowExpression] Func<string> mSExcelGetAndSetCellValueworkflow, [WorkflowExpression] Func<int> mSExcelGetAndSetCellValuesourceHandle = null, [WorkflowExpression] Func<string> mSExcelGetAndSetCellValuesourceWorkbookName = null, [WorkflowExpression] Func<string> mSExcelGetAndSetCellValuesourceWorksheetName = null, [WorkflowExpression] Func<int> mSExcelGetAndSetCellValuetargetHandle = null, [WorkflowExpression] Func<string> mSExcelGetAndSetCellValuetargetWorkbookName = null, [WorkflowExpression] Func<string> mSExcelGetAndSetCellValuetargetWorksheetName = null)
        {
            SourceExpression.Validate(mSExcelGetAndSetCellValuesourceCellReference, nameof(mSExcelGetAndSetCellValuesourceCellReference), required: true);
            SourceExpression.Validate(mSExcelGetAndSetCellValuetargetCellReference, nameof(mSExcelGetAndSetCellValuetargetCellReference), required: true);
            SourceExpression.Validate(mSExcelGetAndSetCellValueworkflow, nameof(mSExcelGetAndSetCellValueworkflow), required: true);
            SourceExpression.Validate(mSExcelGetAndSetCellValuesourceHandle, nameof(mSExcelGetAndSetCellValuesourceHandle), required: false);
            SourceExpression.Validate(mSExcelGetAndSetCellValuesourceWorkbookName, nameof(mSExcelGetAndSetCellValuesourceWorkbookName), required: false);
            SourceExpression.Validate(mSExcelGetAndSetCellValuesourceWorksheetName, nameof(mSExcelGetAndSetCellValuesourceWorksheetName), required: false);
            SourceExpression.Validate(mSExcelGetAndSetCellValuetargetHandle, nameof(mSExcelGetAndSetCellValuetargetHandle), required: false);
            SourceExpression.Validate(mSExcelGetAndSetCellValuetargetWorkbookName, nameof(mSExcelGetAndSetCellValuetargetWorkbookName), required: false);
            SourceExpression.Validate(mSExcelGetAndSetCellValuetargetWorksheetName, nameof(mSExcelGetAndSetCellValuetargetWorksheetName), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSExcelGetAndSetCellValue["SourceHandle"] = SourceExpressionConverter.ConvertToken(mSExcelGetAndSetCellValuesourceHandle);
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
                    mSExcelGetAndSetCellValue["SourceWorkbookName"] = SourceExpressionConverter.ConvertToken(mSExcelGetAndSetCellValuesourceWorkbookName);
                    mSExcelGetAndSetCellValuepropCount++;
                }

                if (mSExcelGetAndSetCellValuesourceWorksheetName != null)
                {
                    mSExcelGetAndSetCellValue["SourceWorksheetName"] = SourceExpressionConverter.ConvertToken(mSExcelGetAndSetCellValuesourceWorksheetName);
                    mSExcelGetAndSetCellValuepropCount++;
                }

                mSExcelGetAndSetCellValuepropCount++;
                mSExcelGetAndSetCellValue["SourceCellReference"] = SourceExpressionConverter.ConvertToken(mSExcelGetAndSetCellValuesourceCellReference);
                if (mSExcelGetAndSetCellValuetargetHandle != null)
                {
                    if (mSExcelGetAndSetCellValuetargetHandle != null)
                    {
                        mSExcelGetAndSetCellValue["TargetHandle"] = SourceExpressionConverter.ConvertToken(mSExcelGetAndSetCellValuetargetHandle);
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
                    mSExcelGetAndSetCellValue["TargetWorkbookName"] = SourceExpressionConverter.ConvertToken(mSExcelGetAndSetCellValuetargetWorkbookName);
                    mSExcelGetAndSetCellValuepropCount++;
                }

                if (mSExcelGetAndSetCellValuetargetWorksheetName != null)
                {
                    mSExcelGetAndSetCellValue["TargetWorksheetName"] = SourceExpressionConverter.ConvertToken(mSExcelGetAndSetCellValuetargetWorksheetName);
                    mSExcelGetAndSetCellValuepropCount++;
                }

                mSExcelGetAndSetCellValuepropCount++;
                mSExcelGetAndSetCellValue["TargetCellReference"] = SourceExpressionConverter.ConvertToken(mSExcelGetAndSetCellValuetargetCellReference);
                mSExcelGetAndSetCellValuepropCount++;
                mSExcelGetAndSetCellValue["Workflow"] = SourceExpressionConverter.ConvertToken(mSExcelGetAndSetCellValueworkflow);
                if (mSExcelGetAndSetCellValuepropCount > 0)
                {
                    callPayload.Body = mSExcelGetAndSetCellValue;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MSExcelGetAndSetCellValueResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetAndSetCellValue2Response> MSExcelGetAndSetCellValue2([WorkflowExpression] Func<string> mSExcelGetAndSetCellValue2sourceCellReference, [WorkflowExpression] Func<string> mSExcelGetAndSetCellValue2targetCellReference, [WorkflowExpression] Func<string> mSExcelGetAndSetCellValue2workflow, [WorkflowExpression] Func<int> mSExcelGetAndSetCellValue2sourceHandle = null, [WorkflowExpression] Func<string> mSExcelGetAndSetCellValue2sourceWorkbookName = null, [WorkflowExpression] Func<string> mSExcelGetAndSetCellValue2sourceWorksheetName = null, [WorkflowExpression] Func<int> mSExcelGetAndSetCellValue2targetHandle = null, [WorkflowExpression] Func<string> mSExcelGetAndSetCellValue2targetWorkbookName = null, [WorkflowExpression] Func<string> mSExcelGetAndSetCellValue2targetWorksheetName = null)
        {
            SourceExpression.Validate(mSExcelGetAndSetCellValue2sourceCellReference, nameof(mSExcelGetAndSetCellValue2sourceCellReference), required: true);
            SourceExpression.Validate(mSExcelGetAndSetCellValue2targetCellReference, nameof(mSExcelGetAndSetCellValue2targetCellReference), required: true);
            SourceExpression.Validate(mSExcelGetAndSetCellValue2workflow, nameof(mSExcelGetAndSetCellValue2workflow), required: true);
            SourceExpression.Validate(mSExcelGetAndSetCellValue2sourceHandle, nameof(mSExcelGetAndSetCellValue2sourceHandle), required: false);
            SourceExpression.Validate(mSExcelGetAndSetCellValue2sourceWorkbookName, nameof(mSExcelGetAndSetCellValue2sourceWorkbookName), required: false);
            SourceExpression.Validate(mSExcelGetAndSetCellValue2sourceWorksheetName, nameof(mSExcelGetAndSetCellValue2sourceWorksheetName), required: false);
            SourceExpression.Validate(mSExcelGetAndSetCellValue2targetHandle, nameof(mSExcelGetAndSetCellValue2targetHandle), required: false);
            SourceExpression.Validate(mSExcelGetAndSetCellValue2targetWorkbookName, nameof(mSExcelGetAndSetCellValue2targetWorkbookName), required: false);
            SourceExpression.Validate(mSExcelGetAndSetCellValue2targetWorksheetName, nameof(mSExcelGetAndSetCellValue2targetWorksheetName), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSExcelGetAndSetCellValue2["SourceHandle"] = SourceExpressionConverter.ConvertToken(mSExcelGetAndSetCellValue2sourceHandle);
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
                    mSExcelGetAndSetCellValue2["SourceWorkbookName"] = SourceExpressionConverter.ConvertToken(mSExcelGetAndSetCellValue2sourceWorkbookName);
                    mSExcelGetAndSetCellValue2propCount++;
                }

                if (mSExcelGetAndSetCellValue2sourceWorksheetName != null)
                {
                    mSExcelGetAndSetCellValue2["SourceWorksheetName"] = SourceExpressionConverter.ConvertToken(mSExcelGetAndSetCellValue2sourceWorksheetName);
                    mSExcelGetAndSetCellValue2propCount++;
                }

                mSExcelGetAndSetCellValue2propCount++;
                mSExcelGetAndSetCellValue2["SourceCellReference"] = SourceExpressionConverter.ConvertToken(mSExcelGetAndSetCellValue2sourceCellReference);
                if (mSExcelGetAndSetCellValue2targetHandle != null)
                {
                    if (mSExcelGetAndSetCellValue2targetHandle != null)
                    {
                        mSExcelGetAndSetCellValue2["TargetHandle"] = SourceExpressionConverter.ConvertToken(mSExcelGetAndSetCellValue2targetHandle);
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
                    mSExcelGetAndSetCellValue2["TargetWorkbookName"] = SourceExpressionConverter.ConvertToken(mSExcelGetAndSetCellValue2targetWorkbookName);
                    mSExcelGetAndSetCellValue2propCount++;
                }

                if (mSExcelGetAndSetCellValue2targetWorksheetName != null)
                {
                    mSExcelGetAndSetCellValue2["TargetWorksheetName"] = SourceExpressionConverter.ConvertToken(mSExcelGetAndSetCellValue2targetWorksheetName);
                    mSExcelGetAndSetCellValue2propCount++;
                }

                mSExcelGetAndSetCellValue2propCount++;
                mSExcelGetAndSetCellValue2["TargetCellReference"] = SourceExpressionConverter.ConvertToken(mSExcelGetAndSetCellValue2targetCellReference);
                mSExcelGetAndSetCellValue2propCount++;
                mSExcelGetAndSetCellValue2["Workflow"] = SourceExpressionConverter.ConvertToken(mSExcelGetAndSetCellValue2workflow);
                if (mSExcelGetAndSetCellValue2propCount > 0)
                {
                    callPayload.Body = mSExcelGetAndSetCellValue2;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MSExcelGetAndSetCellValue2Response>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetAndSetCellTextResponse> MSExcelGetAndSetCellText([WorkflowExpression] Func<string> mSExcelGetAndSetCellTextsourceCellReference, [WorkflowExpression] Func<string> mSExcelGetAndSetCellTexttargetCellReference, [WorkflowExpression] Func<string> mSExcelGetAndSetCellTextworkflow, [WorkflowExpression] Func<int> mSExcelGetAndSetCellTextsourceHandle = null, [WorkflowExpression] Func<string> mSExcelGetAndSetCellTextsourceWorkbookName = null, [WorkflowExpression] Func<string> mSExcelGetAndSetCellTextsourceWorksheetName = null, [WorkflowExpression] Func<int> mSExcelGetAndSetCellTexttargetHandle = null, [WorkflowExpression] Func<string> mSExcelGetAndSetCellTexttargetWorkbookName = null, [WorkflowExpression] Func<string> mSExcelGetAndSetCellTexttargetWorksheetName = null)
        {
            SourceExpression.Validate(mSExcelGetAndSetCellTextsourceCellReference, nameof(mSExcelGetAndSetCellTextsourceCellReference), required: true);
            SourceExpression.Validate(mSExcelGetAndSetCellTexttargetCellReference, nameof(mSExcelGetAndSetCellTexttargetCellReference), required: true);
            SourceExpression.Validate(mSExcelGetAndSetCellTextworkflow, nameof(mSExcelGetAndSetCellTextworkflow), required: true);
            SourceExpression.Validate(mSExcelGetAndSetCellTextsourceHandle, nameof(mSExcelGetAndSetCellTextsourceHandle), required: false);
            SourceExpression.Validate(mSExcelGetAndSetCellTextsourceWorkbookName, nameof(mSExcelGetAndSetCellTextsourceWorkbookName), required: false);
            SourceExpression.Validate(mSExcelGetAndSetCellTextsourceWorksheetName, nameof(mSExcelGetAndSetCellTextsourceWorksheetName), required: false);
            SourceExpression.Validate(mSExcelGetAndSetCellTexttargetHandle, nameof(mSExcelGetAndSetCellTexttargetHandle), required: false);
            SourceExpression.Validate(mSExcelGetAndSetCellTexttargetWorkbookName, nameof(mSExcelGetAndSetCellTexttargetWorkbookName), required: false);
            SourceExpression.Validate(mSExcelGetAndSetCellTexttargetWorksheetName, nameof(mSExcelGetAndSetCellTexttargetWorksheetName), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSExcelGetAndSetCellText["SourceHandle"] = SourceExpressionConverter.ConvertToken(mSExcelGetAndSetCellTextsourceHandle);
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
                    mSExcelGetAndSetCellText["SourceWorkbookName"] = SourceExpressionConverter.ConvertToken(mSExcelGetAndSetCellTextsourceWorkbookName);
                    mSExcelGetAndSetCellTextpropCount++;
                }

                if (mSExcelGetAndSetCellTextsourceWorksheetName != null)
                {
                    mSExcelGetAndSetCellText["SourceWorksheetName"] = SourceExpressionConverter.ConvertToken(mSExcelGetAndSetCellTextsourceWorksheetName);
                    mSExcelGetAndSetCellTextpropCount++;
                }

                mSExcelGetAndSetCellTextpropCount++;
                mSExcelGetAndSetCellText["SourceCellReference"] = SourceExpressionConverter.ConvertToken(mSExcelGetAndSetCellTextsourceCellReference);
                if (mSExcelGetAndSetCellTexttargetHandle != null)
                {
                    if (mSExcelGetAndSetCellTexttargetHandle != null)
                    {
                        mSExcelGetAndSetCellText["TargetHandle"] = SourceExpressionConverter.ConvertToken(mSExcelGetAndSetCellTexttargetHandle);
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
                    mSExcelGetAndSetCellText["TargetWorkbookName"] = SourceExpressionConverter.ConvertToken(mSExcelGetAndSetCellTexttargetWorkbookName);
                    mSExcelGetAndSetCellTextpropCount++;
                }

                if (mSExcelGetAndSetCellTexttargetWorksheetName != null)
                {
                    mSExcelGetAndSetCellText["TargetWorksheetName"] = SourceExpressionConverter.ConvertToken(mSExcelGetAndSetCellTexttargetWorksheetName);
                    mSExcelGetAndSetCellTextpropCount++;
                }

                mSExcelGetAndSetCellTextpropCount++;
                mSExcelGetAndSetCellText["TargetCellReference"] = SourceExpressionConverter.ConvertToken(mSExcelGetAndSetCellTexttargetCellReference);
                mSExcelGetAndSetCellTextpropCount++;
                mSExcelGetAndSetCellText["Workflow"] = SourceExpressionConverter.ConvertToken(mSExcelGetAndSetCellTextworkflow);
                if (mSExcelGetAndSetCellTextpropCount > 0)
                {
                    callPayload.Body = mSExcelGetAndSetCellText;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MSExcelGetAndSetCellTextResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelCheckOLEObjectResponse> MSExcelCheckOLEObject([WorkflowExpression] Func<string> mSExcelCheckOLEObjectoLEObjectName, [WorkflowExpression] Func<string> mSExcelCheckOLEObjectworkflow, [WorkflowExpression] Func<int> mSExcelCheckOLEObjecthandle = null, [WorkflowExpression] Func<string> mSExcelCheckOLEObjectworkbookName = null, [WorkflowExpression] Func<string> mSExcelCheckOLEObjectworksheetName = null, [WorkflowExpression] Func<bool> mSExcelCheckOLEObjectchecked = null, [WorkflowExpression] Func<bool> mSExcelCheckOLEObjectrunInBackground = null)
        {
            SourceExpression.Validate(mSExcelCheckOLEObjectoLEObjectName, nameof(mSExcelCheckOLEObjectoLEObjectName), required: true);
            SourceExpression.Validate(mSExcelCheckOLEObjectworkflow, nameof(mSExcelCheckOLEObjectworkflow), required: true);
            SourceExpression.Validate(mSExcelCheckOLEObjecthandle, nameof(mSExcelCheckOLEObjecthandle), required: false);
            SourceExpression.Validate(mSExcelCheckOLEObjectworkbookName, nameof(mSExcelCheckOLEObjectworkbookName), required: false);
            SourceExpression.Validate(mSExcelCheckOLEObjectworksheetName, nameof(mSExcelCheckOLEObjectworksheetName), required: false);
            SourceExpression.Validate(mSExcelCheckOLEObjectchecked, nameof(mSExcelCheckOLEObjectchecked), required: false);
            SourceExpression.Validate(mSExcelCheckOLEObjectrunInBackground, nameof(mSExcelCheckOLEObjectrunInBackground), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSExcelCheckOLEObject["Handle"] = SourceExpressionConverter.ConvertToken(mSExcelCheckOLEObjecthandle);
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
                    mSExcelCheckOLEObject["WorkbookName"] = SourceExpressionConverter.ConvertToken(mSExcelCheckOLEObjectworkbookName);
                    mSExcelCheckOLEObjectpropCount++;
                }

                if (mSExcelCheckOLEObjectworksheetName != null)
                {
                    mSExcelCheckOLEObject["WorksheetName"] = SourceExpressionConverter.ConvertToken(mSExcelCheckOLEObjectworksheetName);
                    mSExcelCheckOLEObjectpropCount++;
                }

                mSExcelCheckOLEObjectpropCount++;
                mSExcelCheckOLEObject["OLEObjectName"] = SourceExpressionConverter.ConvertToken(mSExcelCheckOLEObjectoLEObjectName);
                if (mSExcelCheckOLEObjectchecked != null)
                {
                    if (mSExcelCheckOLEObjectchecked != null)
                    {
                        mSExcelCheckOLEObject["Checked"] = SourceExpressionConverter.ConvertToken(mSExcelCheckOLEObjectchecked);
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
                        mSExcelCheckOLEObject["RunInBackground"] = SourceExpressionConverter.ConvertToken(mSExcelCheckOLEObjectrunInBackground);
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
                mSExcelCheckOLEObject["Workflow"] = SourceExpressionConverter.ConvertToken(mSExcelCheckOLEObjectworkflow);
                if (mSExcelCheckOLEObjectpropCount > 0)
                {
                    callPayload.Body = mSExcelCheckOLEObject;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MSExcelCheckOLEObjectResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelInputTextIntoOLEObjectResponse> MSExcelInputTextIntoOLEObject([WorkflowExpression] Func<string> mSExcelInputTextIntoOLEObjectoLEObjectName, [WorkflowExpression] Func<string> mSExcelInputTextIntoOLEObjectworkflow, [WorkflowExpression] Func<int> mSExcelInputTextIntoOLEObjecthandle = null, [WorkflowExpression] Func<string> mSExcelInputTextIntoOLEObjectworkbookName = null, [WorkflowExpression] Func<string> mSExcelInputTextIntoOLEObjectworksheetName = null, [WorkflowExpression] Func<string> mSExcelInputTextIntoOLEObjecttextToInput = null, [WorkflowExpression] Func<bool> mSExcelInputTextIntoOLEObjectrunInBackground = null)
        {
            SourceExpression.Validate(mSExcelInputTextIntoOLEObjectoLEObjectName, nameof(mSExcelInputTextIntoOLEObjectoLEObjectName), required: true);
            SourceExpression.Validate(mSExcelInputTextIntoOLEObjectworkflow, nameof(mSExcelInputTextIntoOLEObjectworkflow), required: true);
            SourceExpression.Validate(mSExcelInputTextIntoOLEObjecthandle, nameof(mSExcelInputTextIntoOLEObjecthandle), required: false);
            SourceExpression.Validate(mSExcelInputTextIntoOLEObjectworkbookName, nameof(mSExcelInputTextIntoOLEObjectworkbookName), required: false);
            SourceExpression.Validate(mSExcelInputTextIntoOLEObjectworksheetName, nameof(mSExcelInputTextIntoOLEObjectworksheetName), required: false);
            SourceExpression.Validate(mSExcelInputTextIntoOLEObjecttextToInput, nameof(mSExcelInputTextIntoOLEObjecttextToInput), required: false);
            SourceExpression.Validate(mSExcelInputTextIntoOLEObjectrunInBackground, nameof(mSExcelInputTextIntoOLEObjectrunInBackground), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSExcelInputTextIntoOLEObject["Handle"] = SourceExpressionConverter.ConvertToken(mSExcelInputTextIntoOLEObjecthandle);
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
                    mSExcelInputTextIntoOLEObject["WorkbookName"] = SourceExpressionConverter.ConvertToken(mSExcelInputTextIntoOLEObjectworkbookName);
                    mSExcelInputTextIntoOLEObjectpropCount++;
                }

                if (mSExcelInputTextIntoOLEObjectworksheetName != null)
                {
                    mSExcelInputTextIntoOLEObject["WorksheetName"] = SourceExpressionConverter.ConvertToken(mSExcelInputTextIntoOLEObjectworksheetName);
                    mSExcelInputTextIntoOLEObjectpropCount++;
                }

                mSExcelInputTextIntoOLEObjectpropCount++;
                mSExcelInputTextIntoOLEObject["OLEObjectName"] = SourceExpressionConverter.ConvertToken(mSExcelInputTextIntoOLEObjectoLEObjectName);
                if (mSExcelInputTextIntoOLEObjecttextToInput != null)
                {
                    mSExcelInputTextIntoOLEObject["TextToInput"] = SourceExpressionConverter.ConvertToken(mSExcelInputTextIntoOLEObjecttextToInput);
                    mSExcelInputTextIntoOLEObjectpropCount++;
                }

                if (mSExcelInputTextIntoOLEObjectrunInBackground != null)
                {
                    if (mSExcelInputTextIntoOLEObjectrunInBackground != null)
                    {
                        mSExcelInputTextIntoOLEObject["RunInBackground"] = SourceExpressionConverter.ConvertToken(mSExcelInputTextIntoOLEObjectrunInBackground);
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
                mSExcelInputTextIntoOLEObject["Workflow"] = SourceExpressionConverter.ConvertToken(mSExcelInputTextIntoOLEObjectworkflow);
                if (mSExcelInputTextIntoOLEObjectpropCount > 0)
                {
                    callPayload.Body = mSExcelInputTextIntoOLEObject;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MSExcelInputTextIntoOLEObjectResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelSetCellBackgroundColourResponse> MSExcelSetCellBackgroundColour([WorkflowExpression] Func<string> mSExcelSetCellBackgroundColourcellReference, [WorkflowExpression] Func<int> mSExcelSetCellBackgroundColourcolourIndex, [WorkflowExpression] Func<string> mSExcelSetCellBackgroundColourworkflow, [WorkflowExpression] Func<int> mSExcelSetCellBackgroundColourhandle = null, [WorkflowExpression] Func<string> mSExcelSetCellBackgroundColourworkbookName = null, [WorkflowExpression] Func<string> mSExcelSetCellBackgroundColourworksheetName = null)
        {
            SourceExpression.Validate(mSExcelSetCellBackgroundColourcellReference, nameof(mSExcelSetCellBackgroundColourcellReference), required: true);
            SourceExpression.Validate(mSExcelSetCellBackgroundColourcolourIndex, nameof(mSExcelSetCellBackgroundColourcolourIndex), required: true);
            SourceExpression.Validate(mSExcelSetCellBackgroundColourworkflow, nameof(mSExcelSetCellBackgroundColourworkflow), required: true);
            SourceExpression.Validate(mSExcelSetCellBackgroundColourhandle, nameof(mSExcelSetCellBackgroundColourhandle), required: false);
            SourceExpression.Validate(mSExcelSetCellBackgroundColourworkbookName, nameof(mSExcelSetCellBackgroundColourworkbookName), required: false);
            SourceExpression.Validate(mSExcelSetCellBackgroundColourworksheetName, nameof(mSExcelSetCellBackgroundColourworksheetName), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSExcelSetCellBackgroundColour["Handle"] = SourceExpressionConverter.ConvertToken(mSExcelSetCellBackgroundColourhandle);
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
                    mSExcelSetCellBackgroundColour["WorkbookName"] = SourceExpressionConverter.ConvertToken(mSExcelSetCellBackgroundColourworkbookName);
                    mSExcelSetCellBackgroundColourpropCount++;
                }

                if (mSExcelSetCellBackgroundColourworksheetName != null)
                {
                    mSExcelSetCellBackgroundColour["WorksheetName"] = SourceExpressionConverter.ConvertToken(mSExcelSetCellBackgroundColourworksheetName);
                    mSExcelSetCellBackgroundColourpropCount++;
                }

                mSExcelSetCellBackgroundColourpropCount++;
                mSExcelSetCellBackgroundColour["CellReference"] = SourceExpressionConverter.ConvertToken(mSExcelSetCellBackgroundColourcellReference);
                mSExcelSetCellBackgroundColourpropCount++;
                mSExcelSetCellBackgroundColour["ColourIndex"] = SourceExpressionConverter.ConvertToken(mSExcelSetCellBackgroundColourcolourIndex);
                mSExcelSetCellBackgroundColourpropCount++;
                mSExcelSetCellBackgroundColour["Workflow"] = SourceExpressionConverter.ConvertToken(mSExcelSetCellBackgroundColourworkflow);
                if (mSExcelSetCellBackgroundColourpropCount > 0)
                {
                    callPayload.Body = mSExcelSetCellBackgroundColour;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MSExcelSetCellBackgroundColourResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetCellBackgroundColourResponse> MSExcelGetCellBackgroundColour([WorkflowExpression] Func<string> mSExcelGetCellBackgroundColourcellReference, [WorkflowExpression] Func<string> mSExcelGetCellBackgroundColourworkflow, [WorkflowExpression] Func<int> mSExcelGetCellBackgroundColourhandle = null, [WorkflowExpression] Func<string> mSExcelGetCellBackgroundColourworkbookName = null, [WorkflowExpression] Func<string> mSExcelGetCellBackgroundColourworksheetName = null)
        {
            SourceExpression.Validate(mSExcelGetCellBackgroundColourcellReference, nameof(mSExcelGetCellBackgroundColourcellReference), required: true);
            SourceExpression.Validate(mSExcelGetCellBackgroundColourworkflow, nameof(mSExcelGetCellBackgroundColourworkflow), required: true);
            SourceExpression.Validate(mSExcelGetCellBackgroundColourhandle, nameof(mSExcelGetCellBackgroundColourhandle), required: false);
            SourceExpression.Validate(mSExcelGetCellBackgroundColourworkbookName, nameof(mSExcelGetCellBackgroundColourworkbookName), required: false);
            SourceExpression.Validate(mSExcelGetCellBackgroundColourworksheetName, nameof(mSExcelGetCellBackgroundColourworksheetName), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSExcelGetCellBackgroundColour["Handle"] = SourceExpressionConverter.ConvertToken(mSExcelGetCellBackgroundColourhandle);
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
                    mSExcelGetCellBackgroundColour["WorkbookName"] = SourceExpressionConverter.ConvertToken(mSExcelGetCellBackgroundColourworkbookName);
                    mSExcelGetCellBackgroundColourpropCount++;
                }

                if (mSExcelGetCellBackgroundColourworksheetName != null)
                {
                    mSExcelGetCellBackgroundColour["WorksheetName"] = SourceExpressionConverter.ConvertToken(mSExcelGetCellBackgroundColourworksheetName);
                    mSExcelGetCellBackgroundColourpropCount++;
                }

                mSExcelGetCellBackgroundColourpropCount++;
                mSExcelGetCellBackgroundColour["CellReference"] = SourceExpressionConverter.ConvertToken(mSExcelGetCellBackgroundColourcellReference);
                mSExcelGetCellBackgroundColourpropCount++;
                mSExcelGetCellBackgroundColour["Workflow"] = SourceExpressionConverter.ConvertToken(mSExcelGetCellBackgroundColourworkflow);
                if (mSExcelGetCellBackgroundColourpropCount > 0)
                {
                    callPayload.Body = mSExcelGetCellBackgroundColour;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MSExcelGetCellBackgroundColourResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetOLEObjectValueResponse> MSExcelGetOLEObjectValue([WorkflowExpression] Func<string> mSExcelGetOLEObjectValueoLEObjectName, [WorkflowExpression] Func<string> mSExcelGetOLEObjectValueworkflow, [WorkflowExpression] Func<int> mSExcelGetOLEObjectValuehandle = null, [WorkflowExpression] Func<string> mSExcelGetOLEObjectValueworkbookName = null, [WorkflowExpression] Func<string> mSExcelGetOLEObjectValueworksheetName = null)
        {
            SourceExpression.Validate(mSExcelGetOLEObjectValueoLEObjectName, nameof(mSExcelGetOLEObjectValueoLEObjectName), required: true);
            SourceExpression.Validate(mSExcelGetOLEObjectValueworkflow, nameof(mSExcelGetOLEObjectValueworkflow), required: true);
            SourceExpression.Validate(mSExcelGetOLEObjectValuehandle, nameof(mSExcelGetOLEObjectValuehandle), required: false);
            SourceExpression.Validate(mSExcelGetOLEObjectValueworkbookName, nameof(mSExcelGetOLEObjectValueworkbookName), required: false);
            SourceExpression.Validate(mSExcelGetOLEObjectValueworksheetName, nameof(mSExcelGetOLEObjectValueworksheetName), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSExcelGetOLEObjectValue["Handle"] = SourceExpressionConverter.ConvertToken(mSExcelGetOLEObjectValuehandle);
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
                    mSExcelGetOLEObjectValue["WorkbookName"] = SourceExpressionConverter.ConvertToken(mSExcelGetOLEObjectValueworkbookName);
                    mSExcelGetOLEObjectValuepropCount++;
                }

                if (mSExcelGetOLEObjectValueworksheetName != null)
                {
                    mSExcelGetOLEObjectValue["WorksheetName"] = SourceExpressionConverter.ConvertToken(mSExcelGetOLEObjectValueworksheetName);
                    mSExcelGetOLEObjectValuepropCount++;
                }

                mSExcelGetOLEObjectValuepropCount++;
                mSExcelGetOLEObjectValue["OLEObjectName"] = SourceExpressionConverter.ConvertToken(mSExcelGetOLEObjectValueoLEObjectName);
                mSExcelGetOLEObjectValuepropCount++;
                mSExcelGetOLEObjectValue["Workflow"] = SourceExpressionConverter.ConvertToken(mSExcelGetOLEObjectValueworkflow);
                if (mSExcelGetOLEObjectValuepropCount > 0)
                {
                    callPayload.Body = mSExcelGetOLEObjectValue;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MSExcelGetOLEObjectValueResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelDoesOLEObjectExistResponse> MSExcelDoesOLEObjectExist([WorkflowExpression] Func<string> mSExcelDoesOLEObjectExistoLEObjectName, [WorkflowExpression] Func<string> mSExcelDoesOLEObjectExistworkflow, [WorkflowExpression] Func<int> mSExcelDoesOLEObjectExisthandle = null, [WorkflowExpression] Func<string> mSExcelDoesOLEObjectExistworkbookName = null, [WorkflowExpression] Func<string> mSExcelDoesOLEObjectExistworksheetName = null)
        {
            SourceExpression.Validate(mSExcelDoesOLEObjectExistoLEObjectName, nameof(mSExcelDoesOLEObjectExistoLEObjectName), required: true);
            SourceExpression.Validate(mSExcelDoesOLEObjectExistworkflow, nameof(mSExcelDoesOLEObjectExistworkflow), required: true);
            SourceExpression.Validate(mSExcelDoesOLEObjectExisthandle, nameof(mSExcelDoesOLEObjectExisthandle), required: false);
            SourceExpression.Validate(mSExcelDoesOLEObjectExistworkbookName, nameof(mSExcelDoesOLEObjectExistworkbookName), required: false);
            SourceExpression.Validate(mSExcelDoesOLEObjectExistworksheetName, nameof(mSExcelDoesOLEObjectExistworksheetName), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSExcelDoesOLEObjectExist["Handle"] = SourceExpressionConverter.ConvertToken(mSExcelDoesOLEObjectExisthandle);
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
                    mSExcelDoesOLEObjectExist["WorkbookName"] = SourceExpressionConverter.ConvertToken(mSExcelDoesOLEObjectExistworkbookName);
                    mSExcelDoesOLEObjectExistpropCount++;
                }

                if (mSExcelDoesOLEObjectExistworksheetName != null)
                {
                    mSExcelDoesOLEObjectExist["WorksheetName"] = SourceExpressionConverter.ConvertToken(mSExcelDoesOLEObjectExistworksheetName);
                    mSExcelDoesOLEObjectExistpropCount++;
                }

                mSExcelDoesOLEObjectExistpropCount++;
                mSExcelDoesOLEObjectExist["OLEObjectName"] = SourceExpressionConverter.ConvertToken(mSExcelDoesOLEObjectExistoLEObjectName);
                mSExcelDoesOLEObjectExistpropCount++;
                mSExcelDoesOLEObjectExist["Workflow"] = SourceExpressionConverter.ConvertToken(mSExcelDoesOLEObjectExistworkflow);
                if (mSExcelDoesOLEObjectExistpropCount > 0)
                {
                    callPayload.Body = mSExcelDoesOLEObjectExist;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MSExcelDoesOLEObjectExistResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelPressOLEObjectResponse> MSExcelPressOLEObject([WorkflowExpression] Func<string> mSExcelPressOLEObjectoLEObjectName, [WorkflowExpression] Func<string> mSExcelPressOLEObjectworkflow, [WorkflowExpression] Func<int> mSExcelPressOLEObjecthandle = null, [WorkflowExpression] Func<string> mSExcelPressOLEObjectworkbookName = null, [WorkflowExpression] Func<string> mSExcelPressOLEObjectworksheetName = null, [WorkflowExpression] Func<bool> mSExcelPressOLEObjectrunInBackground = null)
        {
            SourceExpression.Validate(mSExcelPressOLEObjectoLEObjectName, nameof(mSExcelPressOLEObjectoLEObjectName), required: true);
            SourceExpression.Validate(mSExcelPressOLEObjectworkflow, nameof(mSExcelPressOLEObjectworkflow), required: true);
            SourceExpression.Validate(mSExcelPressOLEObjecthandle, nameof(mSExcelPressOLEObjecthandle), required: false);
            SourceExpression.Validate(mSExcelPressOLEObjectworkbookName, nameof(mSExcelPressOLEObjectworkbookName), required: false);
            SourceExpression.Validate(mSExcelPressOLEObjectworksheetName, nameof(mSExcelPressOLEObjectworksheetName), required: false);
            SourceExpression.Validate(mSExcelPressOLEObjectrunInBackground, nameof(mSExcelPressOLEObjectrunInBackground), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSExcelPressOLEObject["Handle"] = SourceExpressionConverter.ConvertToken(mSExcelPressOLEObjecthandle);
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
                    mSExcelPressOLEObject["WorkbookName"] = SourceExpressionConverter.ConvertToken(mSExcelPressOLEObjectworkbookName);
                    mSExcelPressOLEObjectpropCount++;
                }

                if (mSExcelPressOLEObjectworksheetName != null)
                {
                    mSExcelPressOLEObject["WorksheetName"] = SourceExpressionConverter.ConvertToken(mSExcelPressOLEObjectworksheetName);
                    mSExcelPressOLEObjectpropCount++;
                }

                mSExcelPressOLEObjectpropCount++;
                mSExcelPressOLEObject["OLEObjectName"] = SourceExpressionConverter.ConvertToken(mSExcelPressOLEObjectoLEObjectName);
                if (mSExcelPressOLEObjectrunInBackground != null)
                {
                    if (mSExcelPressOLEObjectrunInBackground != null)
                    {
                        mSExcelPressOLEObject["RunInBackground"] = SourceExpressionConverter.ConvertToken(mSExcelPressOLEObjectrunInBackground);
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
                mSExcelPressOLEObject["Workflow"] = SourceExpressionConverter.ConvertToken(mSExcelPressOLEObjectworkflow);
                if (mSExcelPressOLEObjectpropCount > 0)
                {
                    callPayload.Body = mSExcelPressOLEObject;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MSExcelPressOLEObjectResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelSetWorksheetSensitivityLabelResponse> MSExcelSetWorksheetSensitivityLabel([WorkflowExpression] Func<mSExcelSetWorksheetSensitivityLabelassignmentMethodInput> mSExcelSetWorksheetSensitivityLabelassignmentMethod, [WorkflowExpression] Func<string> mSExcelSetWorksheetSensitivityLabellabelId, [WorkflowExpression] Func<string> mSExcelSetWorksheetSensitivityLabelworkflow, [WorkflowExpression] Func<int> mSExcelSetWorksheetSensitivityLabelhandle = null, [WorkflowExpression] Func<string> mSExcelSetWorksheetSensitivityLabelworkbookName = null, [WorkflowExpression] Func<string> mSExcelSetWorksheetSensitivityLabellabelName = null, [WorkflowExpression] Func<string> mSExcelSetWorksheetSensitivityLabelsiteId = null, [WorkflowExpression] Func<string> mSExcelSetWorksheetSensitivityLabeljustification = null)
        {
            SourceExpression.Validate(mSExcelSetWorksheetSensitivityLabelassignmentMethod, nameof(mSExcelSetWorksheetSensitivityLabelassignmentMethod), required: true);
            SourceExpression.Validate(mSExcelSetWorksheetSensitivityLabellabelId, nameof(mSExcelSetWorksheetSensitivityLabellabelId), required: true);
            SourceExpression.Validate(mSExcelSetWorksheetSensitivityLabelworkflow, nameof(mSExcelSetWorksheetSensitivityLabelworkflow), required: true);
            SourceExpression.Validate(mSExcelSetWorksheetSensitivityLabelhandle, nameof(mSExcelSetWorksheetSensitivityLabelhandle), required: false);
            SourceExpression.Validate(mSExcelSetWorksheetSensitivityLabelworkbookName, nameof(mSExcelSetWorksheetSensitivityLabelworkbookName), required: false);
            SourceExpression.Validate(mSExcelSetWorksheetSensitivityLabellabelName, nameof(mSExcelSetWorksheetSensitivityLabellabelName), required: false);
            SourceExpression.Validate(mSExcelSetWorksheetSensitivityLabelsiteId, nameof(mSExcelSetWorksheetSensitivityLabelsiteId), required: false);
            SourceExpression.Validate(mSExcelSetWorksheetSensitivityLabeljustification, nameof(mSExcelSetWorksheetSensitivityLabeljustification), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSExcelSetWorksheetSensitivityLabel["Handle"] = SourceExpressionConverter.ConvertToken(mSExcelSetWorksheetSensitivityLabelhandle);
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
                    mSExcelSetWorksheetSensitivityLabel["WorkbookName"] = SourceExpressionConverter.ConvertToken(mSExcelSetWorksheetSensitivityLabelworkbookName);
                    mSExcelSetWorksheetSensitivityLabelpropCount++;
                }

                mSExcelSetWorksheetSensitivityLabelpropCount++;
                mSExcelSetWorksheetSensitivityLabel["AssignmentMethod"] = SourceExpressionConverter.Convert(mSExcelSetWorksheetSensitivityLabelassignmentMethod);
                mSExcelSetWorksheetSensitivityLabelpropCount++;
                mSExcelSetWorksheetSensitivityLabel["LabelId"] = SourceExpressionConverter.ConvertToken(mSExcelSetWorksheetSensitivityLabellabelId);
                if (mSExcelSetWorksheetSensitivityLabellabelName != null)
                {
                    mSExcelSetWorksheetSensitivityLabel["LabelName"] = SourceExpressionConverter.ConvertToken(mSExcelSetWorksheetSensitivityLabellabelName);
                    mSExcelSetWorksheetSensitivityLabelpropCount++;
                }

                if (mSExcelSetWorksheetSensitivityLabelsiteId != null)
                {
                    mSExcelSetWorksheetSensitivityLabel["SiteId"] = SourceExpressionConverter.ConvertToken(mSExcelSetWorksheetSensitivityLabelsiteId);
                    mSExcelSetWorksheetSensitivityLabelpropCount++;
                }

                if (mSExcelSetWorksheetSensitivityLabeljustification != null)
                {
                    mSExcelSetWorksheetSensitivityLabel["Justification"] = SourceExpressionConverter.ConvertToken(mSExcelSetWorksheetSensitivityLabeljustification);
                    mSExcelSetWorksheetSensitivityLabelpropCount++;
                }

                mSExcelSetWorksheetSensitivityLabelpropCount++;
                mSExcelSetWorksheetSensitivityLabel["Workflow"] = SourceExpressionConverter.ConvertToken(mSExcelSetWorksheetSensitivityLabelworkflow);
                if (mSExcelSetWorksheetSensitivityLabelpropCount > 0)
                {
                    callPayload.Body = mSExcelSetWorksheetSensitivityLabel;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MSExcelSetWorksheetSensitivityLabelResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelGetWorksheetSensitivityLabelResponse> MSExcelGetWorksheetSensitivityLabel([WorkflowExpression] Func<string> mSExcelGetWorksheetSensitivityLabelworkflow, [WorkflowExpression] Func<int> mSExcelGetWorksheetSensitivityLabelhandle = null, [WorkflowExpression] Func<string> mSExcelGetWorksheetSensitivityLabelworkbookName = null)
        {
            SourceExpression.Validate(mSExcelGetWorksheetSensitivityLabelworkflow, nameof(mSExcelGetWorksheetSensitivityLabelworkflow), required: true);
            SourceExpression.Validate(mSExcelGetWorksheetSensitivityLabelhandle, nameof(mSExcelGetWorksheetSensitivityLabelhandle), required: false);
            SourceExpression.Validate(mSExcelGetWorksheetSensitivityLabelworkbookName, nameof(mSExcelGetWorksheetSensitivityLabelworkbookName), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSExcelGetWorksheetSensitivityLabel["Handle"] = SourceExpressionConverter.ConvertToken(mSExcelGetWorksheetSensitivityLabelhandle);
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
                    mSExcelGetWorksheetSensitivityLabel["WorkbookName"] = SourceExpressionConverter.ConvertToken(mSExcelGetWorksheetSensitivityLabelworkbookName);
                    mSExcelGetWorksheetSensitivityLabelpropCount++;
                }

                mSExcelGetWorksheetSensitivityLabelpropCount++;
                mSExcelGetWorksheetSensitivityLabel["Workflow"] = SourceExpressionConverter.ConvertToken(mSExcelGetWorksheetSensitivityLabelworkflow);
                if (mSExcelGetWorksheetSensitivityLabelpropCount > 0)
                {
                    callPayload.Body = mSExcelGetWorksheetSensitivityLabel;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MSExcelGetWorksheetSensitivityLabelResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSExcelWriteArrayResponse> MSExcelWriteArray([WorkflowExpression] Func<string> mSExcelWriteArraycellReference, [WorkflowExpression] Func<string> mSExcelWriteArrayarrayToWriteJSON, [WorkflowExpression] Func<mSExcelWriteArraydirectionInput> mSExcelWriteArraydirection, [WorkflowExpression] Func<string> mSExcelWriteArrayworkflow, [WorkflowExpression] Func<int> mSExcelWriteArrayhandle = null, [WorkflowExpression] Func<string> mSExcelWriteArrayworkbookName = null, [WorkflowExpression] Func<string> mSExcelWriteArrayworksheetName = null)
        {
            SourceExpression.Validate(mSExcelWriteArraycellReference, nameof(mSExcelWriteArraycellReference), required: true);
            SourceExpression.Validate(mSExcelWriteArrayarrayToWriteJSON, nameof(mSExcelWriteArrayarrayToWriteJSON), required: true);
            SourceExpression.Validate(mSExcelWriteArraydirection, nameof(mSExcelWriteArraydirection), required: true);
            SourceExpression.Validate(mSExcelWriteArrayworkflow, nameof(mSExcelWriteArrayworkflow), required: true);
            SourceExpression.Validate(mSExcelWriteArrayhandle, nameof(mSExcelWriteArrayhandle), required: false);
            SourceExpression.Validate(mSExcelWriteArrayworkbookName, nameof(mSExcelWriteArrayworkbookName), required: false);
            SourceExpression.Validate(mSExcelWriteArrayworksheetName, nameof(mSExcelWriteArrayworksheetName), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSExcelWriteArray["Handle"] = SourceExpressionConverter.ConvertToken(mSExcelWriteArrayhandle);
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
                    mSExcelWriteArray["WorkbookName"] = SourceExpressionConverter.ConvertToken(mSExcelWriteArrayworkbookName);
                    mSExcelWriteArraypropCount++;
                }

                if (mSExcelWriteArrayworksheetName != null)
                {
                    mSExcelWriteArray["WorksheetName"] = SourceExpressionConverter.ConvertToken(mSExcelWriteArrayworksheetName);
                    mSExcelWriteArraypropCount++;
                }

                mSExcelWriteArraypropCount++;
                mSExcelWriteArray["CellReference"] = SourceExpressionConverter.ConvertToken(mSExcelWriteArraycellReference);
                mSExcelWriteArraypropCount++;
                mSExcelWriteArray["ArrayToWriteJSON"] = SourceExpressionConverter.ConvertToken(mSExcelWriteArrayarrayToWriteJSON);
                mSExcelWriteArraypropCount++;
                mSExcelWriteArray["Direction"] = SourceExpressionConverter.Convert(mSExcelWriteArraydirection);
                mSExcelWriteArraypropCount++;
                mSExcelWriteArray["Workflow"] = SourceExpressionConverter.ConvertToken(mSExcelWriteArrayworkflow);
                if (mSExcelWriteArraypropCount > 0)
                {
                    callPayload.Body = mSExcelWriteArray;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MSExcelWriteArrayResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookCreateInstanceResponse> MSOutlookCreateInstance([WorkflowExpression] Func<string> mSOutlookCreateInstanceworkflow, [WorkflowExpression] Func<string> mSOutlookCreateInstanceprofileName = null, [WorkflowExpression] Func<bool> mSOutlookCreateInstanceshowOutlook = null)
        {
            SourceExpression.Validate(mSOutlookCreateInstanceworkflow, nameof(mSOutlookCreateInstanceworkflow), required: true);
            SourceExpression.Validate(mSOutlookCreateInstanceprofileName, nameof(mSOutlookCreateInstanceprofileName), required: false);
            SourceExpression.Validate(mSOutlookCreateInstanceshowOutlook, nameof(mSOutlookCreateInstanceshowOutlook), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/MSOutlook/CreateInstance";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSOutlookCreateInstance = new JObject();
                var mSOutlookCreateInstancepropCount = 0;
                if (mSOutlookCreateInstanceprofileName != null)
                {
                    mSOutlookCreateInstance["ProfileName"] = SourceExpressionConverter.ConvertToken(mSOutlookCreateInstanceprofileName);
                    mSOutlookCreateInstancepropCount++;
                }

                if (mSOutlookCreateInstanceshowOutlook != null)
                {
                    if (mSOutlookCreateInstanceshowOutlook != null)
                    {
                        mSOutlookCreateInstance["ShowOutlook"] = SourceExpressionConverter.ConvertToken(mSOutlookCreateInstanceshowOutlook);
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
                mSOutlookCreateInstance["Workflow"] = SourceExpressionConverter.ConvertToken(mSOutlookCreateInstanceworkflow);
                if (mSOutlookCreateInstancepropCount > 0)
                {
                    callPayload.Body = mSOutlookCreateInstance;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MSOutlookCreateInstanceResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSOutlookCloseInstance([WorkflowExpression] Func<string> mSOutlookCloseInstanceworkflow, [WorkflowExpression] Func<int> mSOutlookCloseInstancesecondsToWaitForProcessToClose = null)
        {
            SourceExpression.Validate(mSOutlookCloseInstanceworkflow, nameof(mSOutlookCloseInstanceworkflow), required: true);
            SourceExpression.Validate(mSOutlookCloseInstancesecondsToWaitForProcessToClose, nameof(mSOutlookCloseInstancesecondsToWaitForProcessToClose), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSOutlookCloseInstance["SecondsToWaitForProcessToClose"] = SourceExpressionConverter.ConvertToken(mSOutlookCloseInstancesecondsToWaitForProcessToClose);
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
                mSOutlookCloseInstance["Workflow"] = SourceExpressionConverter.ConvertToken(mSOutlookCloseInstanceworkflow);
                if (mSOutlookCloseInstancepropCount > 0)
                {
                    callPayload.Body = mSOutlookCloseInstance;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSOutlookCloseInstanceUsingWindow([WorkflowExpression] Func<string> mSOutlookCloseInstanceUsingWindowworkflow, [WorkflowExpression] Func<bool> mSOutlookCloseInstanceUsingWindowuseNativeWindow = null, [WorkflowExpression] Func<bool> mSOutlookCloseInstanceUsingWindowuseUIA = null, [WorkflowExpression] Func<int> mSOutlookCloseInstanceUsingWindowsecondsToWaitForProcessToClose = null)
        {
            SourceExpression.Validate(mSOutlookCloseInstanceUsingWindowworkflow, nameof(mSOutlookCloseInstanceUsingWindowworkflow), required: true);
            SourceExpression.Validate(mSOutlookCloseInstanceUsingWindowuseNativeWindow, nameof(mSOutlookCloseInstanceUsingWindowuseNativeWindow), required: false);
            SourceExpression.Validate(mSOutlookCloseInstanceUsingWindowuseUIA, nameof(mSOutlookCloseInstanceUsingWindowuseUIA), required: false);
            SourceExpression.Validate(mSOutlookCloseInstanceUsingWindowsecondsToWaitForProcessToClose, nameof(mSOutlookCloseInstanceUsingWindowsecondsToWaitForProcessToClose), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSOutlookCloseInstanceUsingWindow["UseNativeWindow"] = SourceExpressionConverter.ConvertToken(mSOutlookCloseInstanceUsingWindowuseNativeWindow);
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
                        mSOutlookCloseInstanceUsingWindow["UseUIA"] = SourceExpressionConverter.ConvertToken(mSOutlookCloseInstanceUsingWindowuseUIA);
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
                        mSOutlookCloseInstanceUsingWindow["SecondsToWaitForProcessToClose"] = SourceExpressionConverter.ConvertToken(mSOutlookCloseInstanceUsingWindowsecondsToWaitForProcessToClose);
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
                mSOutlookCloseInstanceUsingWindow["Workflow"] = SourceExpressionConverter.ConvertToken(mSOutlookCloseInstanceUsingWindowworkflow);
                if (mSOutlookCloseInstanceUsingWindowpropCount > 0)
                {
                    callPayload.Body = mSOutlookCloseInstanceUsingWindow;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookAttachToExistingInstanceResponse> MSOutlookAttachToExistingInstance([WorkflowExpression] Func<string> mSOutlookAttachToExistingInstanceworkflow, [WorkflowExpression] Func<bool> mSOutlookAttachToExistingInstancetoggleWindow = null, [WorkflowExpression] Func<bool> mSOutlookAttachToExistingInstancetoggleUsesGlobalLeftMouseClickAgent = null, [WorkflowExpression] Func<double> mSOutlookAttachToExistingInstancetoggleDelay = null)
        {
            SourceExpression.Validate(mSOutlookAttachToExistingInstanceworkflow, nameof(mSOutlookAttachToExistingInstanceworkflow), required: true);
            SourceExpression.Validate(mSOutlookAttachToExistingInstancetoggleWindow, nameof(mSOutlookAttachToExistingInstancetoggleWindow), required: false);
            SourceExpression.Validate(mSOutlookAttachToExistingInstancetoggleUsesGlobalLeftMouseClickAgent, nameof(mSOutlookAttachToExistingInstancetoggleUsesGlobalLeftMouseClickAgent), required: false);
            SourceExpression.Validate(mSOutlookAttachToExistingInstancetoggleDelay, nameof(mSOutlookAttachToExistingInstancetoggleDelay), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSOutlookAttachToExistingInstance["ToggleWindow"] = SourceExpressionConverter.ConvertToken(mSOutlookAttachToExistingInstancetoggleWindow);
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
                        mSOutlookAttachToExistingInstance["ToggleUsesGlobalLeftMouseClickAgent"] = SourceExpressionConverter.ConvertToken(mSOutlookAttachToExistingInstancetoggleUsesGlobalLeftMouseClickAgent);
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
                        mSOutlookAttachToExistingInstance["ToggleDelay"] = SourceExpressionConverter.ConvertToken(mSOutlookAttachToExistingInstancetoggleDelay);
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
                mSOutlookAttachToExistingInstance["Workflow"] = SourceExpressionConverter.ConvertToken(mSOutlookAttachToExistingInstanceworkflow);
                if (mSOutlookAttachToExistingInstancepropCount > 0)
                {
                    callPayload.Body = mSOutlookAttachToExistingInstance;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MSOutlookAttachToExistingInstanceResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookIsConnectedResponse> MSOutlookIsConnected([WorkflowExpression] Func<string> mSOutlookIsConnectedworkflow)
        {
            SourceExpression.Validate(mSOutlookIsConnectedworkflow, nameof(mSOutlookIsConnectedworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/MSOutlook/IsOutlookConnected";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSOutlookIsConnected = new JObject();
                var mSOutlookIsConnectedpropCount = 0;
                mSOutlookIsConnectedpropCount++;
                mSOutlookIsConnected["Workflow"] = SourceExpressionConverter.ConvertToken(mSOutlookIsConnectedworkflow);
                if (mSOutlookIsConnectedpropCount > 0)
                {
                    callPayload.Body = mSOutlookIsConnected;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MSOutlookIsConnectedResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSOutlookShow([WorkflowExpression] Func<string> mSOutlookShowworkflow)
        {
            SourceExpression.Validate(mSOutlookShowworkflow, nameof(mSOutlookShowworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/MSOutlook/ShowOutlook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSOutlookShow = new JObject();
                var mSOutlookShowpropCount = 0;
                mSOutlookShowpropCount++;
                mSOutlookShow["Workflow"] = SourceExpressionConverter.ConvertToken(mSOutlookShowworkflow);
                if (mSOutlookShowpropCount > 0)
                {
                    callPayload.Body = mSOutlookShow;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookGetNameSpaceInformationResponse> MSOutlookGetNameSpaceInformation([WorkflowExpression] Func<string> mSOutlookGetNameSpaceInformationworkflow)
        {
            SourceExpression.Validate(mSOutlookGetNameSpaceInformationworkflow, nameof(mSOutlookGetNameSpaceInformationworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/MSOutlook/GetNameSpaceInformation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSOutlookGetNameSpaceInformation = new JObject();
                var mSOutlookGetNameSpaceInformationpropCount = 0;
                mSOutlookGetNameSpaceInformationpropCount++;
                mSOutlookGetNameSpaceInformation["Workflow"] = SourceExpressionConverter.ConvertToken(mSOutlookGetNameSpaceInformationworkflow);
                if (mSOutlookGetNameSpaceInformationpropCount > 0)
                {
                    callPayload.Body = mSOutlookGetNameSpaceInformation;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MSOutlookGetNameSpaceInformationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookGetMailFoldersResponse> MSOutlookGetMailFolders([WorkflowExpression] Func<string> mSOutlookGetMailFoldersworkflow, [WorkflowExpression] Func<string> mSOutlookGetMailFoldersfolderPath = null, [WorkflowExpression] Func<bool> mSOutlookGetMailFolderssubFolders = null)
        {
            SourceExpression.Validate(mSOutlookGetMailFoldersworkflow, nameof(mSOutlookGetMailFoldersworkflow), required: true);
            SourceExpression.Validate(mSOutlookGetMailFoldersfolderPath, nameof(mSOutlookGetMailFoldersfolderPath), required: false);
            SourceExpression.Validate(mSOutlookGetMailFolderssubFolders, nameof(mSOutlookGetMailFolderssubFolders), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/MSOutlook/GetMailFolders";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSOutlookGetMailFolders = new JObject();
                var mSOutlookGetMailFolderspropCount = 0;
                if (mSOutlookGetMailFoldersfolderPath != null)
                {
                    mSOutlookGetMailFolders["FolderPath"] = SourceExpressionConverter.ConvertToken(mSOutlookGetMailFoldersfolderPath);
                    mSOutlookGetMailFolderspropCount++;
                }

                if (mSOutlookGetMailFolderssubFolders != null)
                {
                    if (mSOutlookGetMailFolderssubFolders != null)
                    {
                        mSOutlookGetMailFolders["SubFolders"] = SourceExpressionConverter.ConvertToken(mSOutlookGetMailFolderssubFolders);
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
                mSOutlookGetMailFolders["Workflow"] = SourceExpressionConverter.ConvertToken(mSOutlookGetMailFoldersworkflow);
                if (mSOutlookGetMailFolderspropCount > 0)
                {
                    callPayload.Body = mSOutlookGetMailFolders;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MSOutlookGetMailFoldersResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSOutlookMarkEmailAsRead([WorkflowExpression] Func<string> mSOutlookMarkEmailAsReadentryID, [WorkflowExpression] Func<string> mSOutlookMarkEmailAsReadworkflow, [WorkflowExpression] Func<bool> mSOutlookMarkEmailAsReadread = null)
        {
            SourceExpression.Validate(mSOutlookMarkEmailAsReadentryID, nameof(mSOutlookMarkEmailAsReadentryID), required: true);
            SourceExpression.Validate(mSOutlookMarkEmailAsReadworkflow, nameof(mSOutlookMarkEmailAsReadworkflow), required: true);
            SourceExpression.Validate(mSOutlookMarkEmailAsReadread, nameof(mSOutlookMarkEmailAsReadread), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/MSOutlook/MarkEmailAsRead";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSOutlookMarkEmailAsRead = new JObject();
                var mSOutlookMarkEmailAsReadpropCount = 0;
                mSOutlookMarkEmailAsReadpropCount++;
                mSOutlookMarkEmailAsRead["EntryID"] = SourceExpressionConverter.ConvertToken(mSOutlookMarkEmailAsReadentryID);
                if (mSOutlookMarkEmailAsReadread != null)
                {
                    if (mSOutlookMarkEmailAsReadread != null)
                    {
                        mSOutlookMarkEmailAsRead["Read"] = SourceExpressionConverter.ConvertToken(mSOutlookMarkEmailAsReadread);
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
                mSOutlookMarkEmailAsRead["Workflow"] = SourceExpressionConverter.ConvertToken(mSOutlookMarkEmailAsReadworkflow);
                if (mSOutlookMarkEmailAsReadpropCount > 0)
                {
                    callPayload.Body = mSOutlookMarkEmailAsRead;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookGetEmailBodyResponse> MSOutlookGetEmailBody([WorkflowExpression] Func<string> mSOutlookGetEmailBodyentryID, [WorkflowExpression] Func<string> mSOutlookGetEmailBodyworkflow, [WorkflowExpression] Func<bool> mSOutlookGetEmailBodyclickAllowButtonIfRequired = null)
        {
            SourceExpression.Validate(mSOutlookGetEmailBodyentryID, nameof(mSOutlookGetEmailBodyentryID), required: true);
            SourceExpression.Validate(mSOutlookGetEmailBodyworkflow, nameof(mSOutlookGetEmailBodyworkflow), required: true);
            SourceExpression.Validate(mSOutlookGetEmailBodyclickAllowButtonIfRequired, nameof(mSOutlookGetEmailBodyclickAllowButtonIfRequired), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/MSOutlook/GetEmailBody";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSOutlookGetEmailBody = new JObject();
                var mSOutlookGetEmailBodypropCount = 0;
                mSOutlookGetEmailBodypropCount++;
                mSOutlookGetEmailBody["EntryID"] = SourceExpressionConverter.ConvertToken(mSOutlookGetEmailBodyentryID);
                if (mSOutlookGetEmailBodyclickAllowButtonIfRequired != null)
                {
                    if (mSOutlookGetEmailBodyclickAllowButtonIfRequired != null)
                    {
                        mSOutlookGetEmailBody["ClickAllowButtonIfRequired"] = SourceExpressionConverter.ConvertToken(mSOutlookGetEmailBodyclickAllowButtonIfRequired);
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
                mSOutlookGetEmailBody["Workflow"] = SourceExpressionConverter.ConvertToken(mSOutlookGetEmailBodyworkflow);
                if (mSOutlookGetEmailBodypropCount > 0)
                {
                    callPayload.Body = mSOutlookGetEmailBody;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MSOutlookGetEmailBodyResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookGetEmailAttachmentFilenamesResponse> MSOutlookGetEmailAttachmentFilenames([WorkflowExpression] Func<string> mSOutlookGetEmailAttachmentFilenamesentryID, [WorkflowExpression] Func<string> mSOutlookGetEmailAttachmentFilenamesworkflow, [WorkflowExpression] Func<bool> mSOutlookGetEmailAttachmentFilenamesclickAllowButtonIfRequired = null)
        {
            SourceExpression.Validate(mSOutlookGetEmailAttachmentFilenamesentryID, nameof(mSOutlookGetEmailAttachmentFilenamesentryID), required: true);
            SourceExpression.Validate(mSOutlookGetEmailAttachmentFilenamesworkflow, nameof(mSOutlookGetEmailAttachmentFilenamesworkflow), required: true);
            SourceExpression.Validate(mSOutlookGetEmailAttachmentFilenamesclickAllowButtonIfRequired, nameof(mSOutlookGetEmailAttachmentFilenamesclickAllowButtonIfRequired), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/MSOutlook/GetEmailAttachmentFilenames";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSOutlookGetEmailAttachmentFilenames = new JObject();
                var mSOutlookGetEmailAttachmentFilenamespropCount = 0;
                mSOutlookGetEmailAttachmentFilenamespropCount++;
                mSOutlookGetEmailAttachmentFilenames["EntryID"] = SourceExpressionConverter.ConvertToken(mSOutlookGetEmailAttachmentFilenamesentryID);
                if (mSOutlookGetEmailAttachmentFilenamesclickAllowButtonIfRequired != null)
                {
                    if (mSOutlookGetEmailAttachmentFilenamesclickAllowButtonIfRequired != null)
                    {
                        mSOutlookGetEmailAttachmentFilenames["ClickAllowButtonIfRequired"] = SourceExpressionConverter.ConvertToken(mSOutlookGetEmailAttachmentFilenamesclickAllowButtonIfRequired);
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
                mSOutlookGetEmailAttachmentFilenames["Workflow"] = SourceExpressionConverter.ConvertToken(mSOutlookGetEmailAttachmentFilenamesworkflow);
                if (mSOutlookGetEmailAttachmentFilenamespropCount > 0)
                {
                    callPayload.Body = mSOutlookGetEmailAttachmentFilenames;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MSOutlookGetEmailAttachmentFilenamesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookSaveEmailAttachmentsAsFileResponse> MSOutlookSaveEmailAttachmentsAsFile([WorkflowExpression] Func<string> mSOutlookSaveEmailAttachmentsAsFileentryID, [WorkflowExpression] Func<string> mSOutlookSaveEmailAttachmentsAsFileworkflow, [WorkflowExpression] Func<string> mSOutlookSaveEmailAttachmentsAsFilesaveFolderPath = null, [WorkflowExpression] Func<bool> mSOutlookSaveEmailAttachmentsAsFilecreateFolder = null, [WorkflowExpression] Func<string> mSOutlookSaveEmailAttachmentsAsFileonlySaveAttachmentsMatchingWildcard = null, [WorkflowExpression] Func<bool> mSOutlookSaveEmailAttachmentsAsFilesaveHiddenAttachments = null, [WorkflowExpression] Func<bool> mSOutlookSaveEmailAttachmentsAsFileclickAllowButtonIfRequired = null)
        {
            SourceExpression.Validate(mSOutlookSaveEmailAttachmentsAsFileentryID, nameof(mSOutlookSaveEmailAttachmentsAsFileentryID), required: true);
            SourceExpression.Validate(mSOutlookSaveEmailAttachmentsAsFileworkflow, nameof(mSOutlookSaveEmailAttachmentsAsFileworkflow), required: true);
            SourceExpression.Validate(mSOutlookSaveEmailAttachmentsAsFilesaveFolderPath, nameof(mSOutlookSaveEmailAttachmentsAsFilesaveFolderPath), required: false);
            SourceExpression.Validate(mSOutlookSaveEmailAttachmentsAsFilecreateFolder, nameof(mSOutlookSaveEmailAttachmentsAsFilecreateFolder), required: false);
            SourceExpression.Validate(mSOutlookSaveEmailAttachmentsAsFileonlySaveAttachmentsMatchingWildcard, nameof(mSOutlookSaveEmailAttachmentsAsFileonlySaveAttachmentsMatchingWildcard), required: false);
            SourceExpression.Validate(mSOutlookSaveEmailAttachmentsAsFilesaveHiddenAttachments, nameof(mSOutlookSaveEmailAttachmentsAsFilesaveHiddenAttachments), required: false);
            SourceExpression.Validate(mSOutlookSaveEmailAttachmentsAsFileclickAllowButtonIfRequired, nameof(mSOutlookSaveEmailAttachmentsAsFileclickAllowButtonIfRequired), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/MSOutlook/SaveEmailAttachmentsAsFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSOutlookSaveEmailAttachmentsAsFile = new JObject();
                var mSOutlookSaveEmailAttachmentsAsFilepropCount = 0;
                mSOutlookSaveEmailAttachmentsAsFilepropCount++;
                mSOutlookSaveEmailAttachmentsAsFile["EntryID"] = SourceExpressionConverter.ConvertToken(mSOutlookSaveEmailAttachmentsAsFileentryID);
                if (mSOutlookSaveEmailAttachmentsAsFilesaveFolderPath != null)
                {
                    mSOutlookSaveEmailAttachmentsAsFile["SaveFolderPath"] = SourceExpressionConverter.ConvertToken(mSOutlookSaveEmailAttachmentsAsFilesaveFolderPath);
                    mSOutlookSaveEmailAttachmentsAsFilepropCount++;
                }

                if (mSOutlookSaveEmailAttachmentsAsFilecreateFolder != null)
                {
                    if (mSOutlookSaveEmailAttachmentsAsFilecreateFolder != null)
                    {
                        mSOutlookSaveEmailAttachmentsAsFile["CreateFolder"] = SourceExpressionConverter.ConvertToken(mSOutlookSaveEmailAttachmentsAsFilecreateFolder);
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
                    mSOutlookSaveEmailAttachmentsAsFile["OnlySaveAttachmentsMatchingWildcard"] = SourceExpressionConverter.ConvertToken(mSOutlookSaveEmailAttachmentsAsFileonlySaveAttachmentsMatchingWildcard);
                    mSOutlookSaveEmailAttachmentsAsFilepropCount++;
                }

                if (mSOutlookSaveEmailAttachmentsAsFilesaveHiddenAttachments != null)
                {
                    if (mSOutlookSaveEmailAttachmentsAsFilesaveHiddenAttachments != null)
                    {
                        mSOutlookSaveEmailAttachmentsAsFile["SaveHiddenAttachments"] = SourceExpressionConverter.ConvertToken(mSOutlookSaveEmailAttachmentsAsFilesaveHiddenAttachments);
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
                        mSOutlookSaveEmailAttachmentsAsFile["ClickAllowButtonIfRequired"] = SourceExpressionConverter.ConvertToken(mSOutlookSaveEmailAttachmentsAsFileclickAllowButtonIfRequired);
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
                mSOutlookSaveEmailAttachmentsAsFile["Workflow"] = SourceExpressionConverter.ConvertToken(mSOutlookSaveEmailAttachmentsAsFileworkflow);
                if (mSOutlookSaveEmailAttachmentsAsFilepropCount > 0)
                {
                    callPayload.Body = mSOutlookSaveEmailAttachmentsAsFile;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MSOutlookSaveEmailAttachmentsAsFileResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSOutlookDeleteEmail([WorkflowExpression] Func<string> mSOutlookDeleteEmailentryID, [WorkflowExpression] Func<string> mSOutlookDeleteEmailworkflow)
        {
            SourceExpression.Validate(mSOutlookDeleteEmailentryID, nameof(mSOutlookDeleteEmailentryID), required: true);
            SourceExpression.Validate(mSOutlookDeleteEmailworkflow, nameof(mSOutlookDeleteEmailworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/MSOutlook/DeleteEmail";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSOutlookDeleteEmail = new JObject();
                var mSOutlookDeleteEmailpropCount = 0;
                mSOutlookDeleteEmailpropCount++;
                mSOutlookDeleteEmail["EntryID"] = SourceExpressionConverter.ConvertToken(mSOutlookDeleteEmailentryID);
                mSOutlookDeleteEmailpropCount++;
                mSOutlookDeleteEmail["Workflow"] = SourceExpressionConverter.ConvertToken(mSOutlookDeleteEmailworkflow);
                if (mSOutlookDeleteEmailpropCount > 0)
                {
                    callPayload.Body = mSOutlookDeleteEmail;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSOutlookMoveEmail([WorkflowExpression] Func<string> mSOutlookMoveEmailentryID, [WorkflowExpression] Func<string> mSOutlookMoveEmailworkflow, [WorkflowExpression] Func<string> mSOutlookMoveEmaildestinationFolder = null)
        {
            SourceExpression.Validate(mSOutlookMoveEmailentryID, nameof(mSOutlookMoveEmailentryID), required: true);
            SourceExpression.Validate(mSOutlookMoveEmailworkflow, nameof(mSOutlookMoveEmailworkflow), required: true);
            SourceExpression.Validate(mSOutlookMoveEmaildestinationFolder, nameof(mSOutlookMoveEmaildestinationFolder), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/MSOutlook/MoveEmail";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSOutlookMoveEmail = new JObject();
                var mSOutlookMoveEmailpropCount = 0;
                mSOutlookMoveEmailpropCount++;
                mSOutlookMoveEmail["EntryID"] = SourceExpressionConverter.ConvertToken(mSOutlookMoveEmailentryID);
                if (mSOutlookMoveEmaildestinationFolder != null)
                {
                    mSOutlookMoveEmail["DestinationFolder"] = SourceExpressionConverter.ConvertToken(mSOutlookMoveEmaildestinationFolder);
                    mSOutlookMoveEmailpropCount++;
                }

                mSOutlookMoveEmailpropCount++;
                mSOutlookMoveEmail["Workflow"] = SourceExpressionConverter.ConvertToken(mSOutlookMoveEmailworkflow);
                if (mSOutlookMoveEmailpropCount > 0)
                {
                    callPayload.Body = mSOutlookMoveEmail;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSOutlookSendEmail([WorkflowExpression] Func<string> mSOutlookSendEmailworkflow, [WorkflowExpression] Func<string> mSOutlookSendEmailto = null, [WorkflowExpression] Func<string> mSOutlookSendEmailcC = null, [WorkflowExpression] Func<string> mSOutlookSendEmailbCC = null, [WorkflowExpression] Func<string> mSOutlookSendEmailsubject = null, [WorkflowExpression] Func<mSOutlookSendEmailbodyFormatInput> mSOutlookSendEmailbodyFormat = null, [WorkflowExpression] Func<string> mSOutlookSendEmailbody = null, [WorkflowExpression] Func<string> mSOutlookSendEmailhTMLBody = null, [WorkflowExpression] Func<string> mSOutlookSendEmailrTFBody = null, [WorkflowExpression] Func<string> mSOutlookSendEmailattachmentFilenamesJSON = null, [WorkflowExpression] Func<bool> mSOutlookSendEmaildontSendIfAttachmentFilenameMissing = null, [WorkflowExpression] Func<bool> mSOutlookSendEmailclickAllowButtonIfRequired = null, [WorkflowExpression] Func<string> mSOutlookSendEmailvotingOptions = null, [WorkflowExpression] Func<string> mSOutlookSendEmailsendAsSMTPAddress = null, [WorkflowExpression] Func<bool> mSOutlookSendEmailbodyContainsStoredPassword = null)
        {
            SourceExpression.Validate(mSOutlookSendEmailworkflow, nameof(mSOutlookSendEmailworkflow), required: true);
            SourceExpression.Validate(mSOutlookSendEmailto, nameof(mSOutlookSendEmailto), required: false);
            SourceExpression.Validate(mSOutlookSendEmailcC, nameof(mSOutlookSendEmailcC), required: false);
            SourceExpression.Validate(mSOutlookSendEmailbCC, nameof(mSOutlookSendEmailbCC), required: false);
            SourceExpression.Validate(mSOutlookSendEmailsubject, nameof(mSOutlookSendEmailsubject), required: false);
            SourceExpression.Validate(mSOutlookSendEmailbodyFormat, nameof(mSOutlookSendEmailbodyFormat), required: false);
            SourceExpression.Validate(mSOutlookSendEmailbody, nameof(mSOutlookSendEmailbody), required: false);
            SourceExpression.Validate(mSOutlookSendEmailhTMLBody, nameof(mSOutlookSendEmailhTMLBody), required: false);
            SourceExpression.Validate(mSOutlookSendEmailrTFBody, nameof(mSOutlookSendEmailrTFBody), required: false);
            SourceExpression.Validate(mSOutlookSendEmailattachmentFilenamesJSON, nameof(mSOutlookSendEmailattachmentFilenamesJSON), required: false);
            SourceExpression.Validate(mSOutlookSendEmaildontSendIfAttachmentFilenameMissing, nameof(mSOutlookSendEmaildontSendIfAttachmentFilenameMissing), required: false);
            SourceExpression.Validate(mSOutlookSendEmailclickAllowButtonIfRequired, nameof(mSOutlookSendEmailclickAllowButtonIfRequired), required: false);
            SourceExpression.Validate(mSOutlookSendEmailvotingOptions, nameof(mSOutlookSendEmailvotingOptions), required: false);
            SourceExpression.Validate(mSOutlookSendEmailsendAsSMTPAddress, nameof(mSOutlookSendEmailsendAsSMTPAddress), required: false);
            SourceExpression.Validate(mSOutlookSendEmailbodyContainsStoredPassword, nameof(mSOutlookSendEmailbodyContainsStoredPassword), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/MSOutlook/SendEmail";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSOutlookSendEmail = new JObject();
                var mSOutlookSendEmailpropCount = 0;
                if (mSOutlookSendEmailto != null)
                {
                    mSOutlookSendEmail["To"] = SourceExpressionConverter.ConvertToken(mSOutlookSendEmailto);
                    mSOutlookSendEmailpropCount++;
                }

                if (mSOutlookSendEmailcC != null)
                {
                    mSOutlookSendEmail["CC"] = SourceExpressionConverter.ConvertToken(mSOutlookSendEmailcC);
                    mSOutlookSendEmailpropCount++;
                }

                if (mSOutlookSendEmailbCC != null)
                {
                    mSOutlookSendEmail["BCC"] = SourceExpressionConverter.ConvertToken(mSOutlookSendEmailbCC);
                    mSOutlookSendEmailpropCount++;
                }

                if (mSOutlookSendEmailsubject != null)
                {
                    mSOutlookSendEmail["Subject"] = SourceExpressionConverter.ConvertToken(mSOutlookSendEmailsubject);
                    mSOutlookSendEmailpropCount++;
                }

                if (mSOutlookSendEmailbodyFormat != null)
                {
                    mSOutlookSendEmail["BodyFormat"] = SourceExpressionConverter.Convert(mSOutlookSendEmailbodyFormat);
                    mSOutlookSendEmailpropCount++;
                }

                if (mSOutlookSendEmailbody != null)
                {
                    mSOutlookSendEmail["Body"] = SourceExpressionConverter.ConvertToken(mSOutlookSendEmailbody);
                    mSOutlookSendEmailpropCount++;
                }

                if (mSOutlookSendEmailhTMLBody != null)
                {
                    mSOutlookSendEmail["HTMLBody"] = SourceExpressionConverter.ConvertToken(mSOutlookSendEmailhTMLBody);
                    mSOutlookSendEmailpropCount++;
                }

                if (mSOutlookSendEmailrTFBody != null)
                {
                    mSOutlookSendEmail["RTFBody"] = SourceExpressionConverter.ConvertToken(mSOutlookSendEmailrTFBody);
                    mSOutlookSendEmailpropCount++;
                }

                if (mSOutlookSendEmailattachmentFilenamesJSON != null)
                {
                    mSOutlookSendEmail["AttachmentFilenamesJSON"] = SourceExpressionConverter.ConvertToken(mSOutlookSendEmailattachmentFilenamesJSON);
                    mSOutlookSendEmailpropCount++;
                }

                if (mSOutlookSendEmaildontSendIfAttachmentFilenameMissing != null)
                {
                    if (mSOutlookSendEmaildontSendIfAttachmentFilenameMissing != null)
                    {
                        mSOutlookSendEmail["DontSendIfAttachmentFilenameMissing"] = SourceExpressionConverter.ConvertToken(mSOutlookSendEmaildontSendIfAttachmentFilenameMissing);
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
                        mSOutlookSendEmail["ClickAllowButtonIfRequired"] = SourceExpressionConverter.ConvertToken(mSOutlookSendEmailclickAllowButtonIfRequired);
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
                    mSOutlookSendEmail["VotingOptions"] = SourceExpressionConverter.ConvertToken(mSOutlookSendEmailvotingOptions);
                    mSOutlookSendEmailpropCount++;
                }

                if (mSOutlookSendEmailsendAsSMTPAddress != null)
                {
                    mSOutlookSendEmail["SendAsSMTPAddress"] = SourceExpressionConverter.ConvertToken(mSOutlookSendEmailsendAsSMTPAddress);
                    mSOutlookSendEmailpropCount++;
                }

                if (mSOutlookSendEmailbodyContainsStoredPassword != null)
                {
                    if (mSOutlookSendEmailbodyContainsStoredPassword != null)
                    {
                        mSOutlookSendEmail["BodyContainsStoredPassword"] = SourceExpressionConverter.ConvertToken(mSOutlookSendEmailbodyContainsStoredPassword);
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
                mSOutlookSendEmail["Workflow"] = SourceExpressionConverter.ConvertToken(mSOutlookSendEmailworkflow);
                if (mSOutlookSendEmailpropCount > 0)
                {
                    callPayload.Body = mSOutlookSendEmail;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSOutlookCreateMailFolder([WorkflowExpression] Func<string> mSOutlookCreateMailFolderworkflow, [WorkflowExpression] Func<string> mSOutlookCreateMailFolderparentFolderPath = null, [WorkflowExpression] Func<string> mSOutlookCreateMailFoldernewFolderName = null)
        {
            SourceExpression.Validate(mSOutlookCreateMailFolderworkflow, nameof(mSOutlookCreateMailFolderworkflow), required: true);
            SourceExpression.Validate(mSOutlookCreateMailFolderparentFolderPath, nameof(mSOutlookCreateMailFolderparentFolderPath), required: false);
            SourceExpression.Validate(mSOutlookCreateMailFoldernewFolderName, nameof(mSOutlookCreateMailFoldernewFolderName), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/MSOutlook/CreateMailFolder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSOutlookCreateMailFolder = new JObject();
                var mSOutlookCreateMailFolderpropCount = 0;
                if (mSOutlookCreateMailFolderparentFolderPath != null)
                {
                    mSOutlookCreateMailFolder["ParentFolderPath"] = SourceExpressionConverter.ConvertToken(mSOutlookCreateMailFolderparentFolderPath);
                    mSOutlookCreateMailFolderpropCount++;
                }

                if (mSOutlookCreateMailFoldernewFolderName != null)
                {
                    mSOutlookCreateMailFolder["NewFolderName"] = SourceExpressionConverter.ConvertToken(mSOutlookCreateMailFoldernewFolderName);
                    mSOutlookCreateMailFolderpropCount++;
                }

                mSOutlookCreateMailFolderpropCount++;
                mSOutlookCreateMailFolder["Workflow"] = SourceExpressionConverter.ConvertToken(mSOutlookCreateMailFolderworkflow);
                if (mSOutlookCreateMailFolderpropCount > 0)
                {
                    callPayload.Body = mSOutlookCreateMailFolder;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSOutlookReplyToEmail([WorkflowExpression] Func<string> mSOutlookReplyToEmailentryID, [WorkflowExpression] Func<string> mSOutlookReplyToEmailworkflow, [WorkflowExpression] Func<bool> mSOutlookReplyToEmailreplyToAll = null, [WorkflowExpression] Func<mSOutlookReplyToEmailbodyFormatInput> mSOutlookReplyToEmailbodyFormat = null, [WorkflowExpression] Func<string> mSOutlookReplyToEmailbody = null, [WorkflowExpression] Func<string> mSOutlookReplyToEmailhTMLBody = null, [WorkflowExpression] Func<string> mSOutlookReplyToEmailrTFBody = null, [WorkflowExpression] Func<string> mSOutlookReplyToEmailattachmentFilenamesJSON = null, [WorkflowExpression] Func<bool> mSOutlookReplyToEmaildontSendIfAttachmentFilenameMissing = null, [WorkflowExpression] Func<bool> mSOutlookReplyToEmailclickAllowButtonIfRequired = null, [WorkflowExpression] Func<string> mSOutlookReplyToEmailvotingOptions = null, [WorkflowExpression] Func<string> mSOutlookReplyToEmailsendAsSMTPAddress = null, [WorkflowExpression] Func<bool> mSOutlookReplyToEmailbodyContainsStoredPassword = null)
        {
            SourceExpression.Validate(mSOutlookReplyToEmailentryID, nameof(mSOutlookReplyToEmailentryID), required: true);
            SourceExpression.Validate(mSOutlookReplyToEmailworkflow, nameof(mSOutlookReplyToEmailworkflow), required: true);
            SourceExpression.Validate(mSOutlookReplyToEmailreplyToAll, nameof(mSOutlookReplyToEmailreplyToAll), required: false);
            SourceExpression.Validate(mSOutlookReplyToEmailbodyFormat, nameof(mSOutlookReplyToEmailbodyFormat), required: false);
            SourceExpression.Validate(mSOutlookReplyToEmailbody, nameof(mSOutlookReplyToEmailbody), required: false);
            SourceExpression.Validate(mSOutlookReplyToEmailhTMLBody, nameof(mSOutlookReplyToEmailhTMLBody), required: false);
            SourceExpression.Validate(mSOutlookReplyToEmailrTFBody, nameof(mSOutlookReplyToEmailrTFBody), required: false);
            SourceExpression.Validate(mSOutlookReplyToEmailattachmentFilenamesJSON, nameof(mSOutlookReplyToEmailattachmentFilenamesJSON), required: false);
            SourceExpression.Validate(mSOutlookReplyToEmaildontSendIfAttachmentFilenameMissing, nameof(mSOutlookReplyToEmaildontSendIfAttachmentFilenameMissing), required: false);
            SourceExpression.Validate(mSOutlookReplyToEmailclickAllowButtonIfRequired, nameof(mSOutlookReplyToEmailclickAllowButtonIfRequired), required: false);
            SourceExpression.Validate(mSOutlookReplyToEmailvotingOptions, nameof(mSOutlookReplyToEmailvotingOptions), required: false);
            SourceExpression.Validate(mSOutlookReplyToEmailsendAsSMTPAddress, nameof(mSOutlookReplyToEmailsendAsSMTPAddress), required: false);
            SourceExpression.Validate(mSOutlookReplyToEmailbodyContainsStoredPassword, nameof(mSOutlookReplyToEmailbodyContainsStoredPassword), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/MSOutlook/ReplyToEmail";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSOutlookReplyToEmail = new JObject();
                var mSOutlookReplyToEmailpropCount = 0;
                mSOutlookReplyToEmailpropCount++;
                mSOutlookReplyToEmail["EntryID"] = SourceExpressionConverter.ConvertToken(mSOutlookReplyToEmailentryID);
                if (mSOutlookReplyToEmailreplyToAll != null)
                {
                    if (mSOutlookReplyToEmailreplyToAll != null)
                    {
                        mSOutlookReplyToEmail["ReplyToAll"] = SourceExpressionConverter.ConvertToken(mSOutlookReplyToEmailreplyToAll);
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
                    mSOutlookReplyToEmail["BodyFormat"] = SourceExpressionConverter.Convert(mSOutlookReplyToEmailbodyFormat);
                    mSOutlookReplyToEmailpropCount++;
                }

                if (mSOutlookReplyToEmailbody != null)
                {
                    mSOutlookReplyToEmail["Body"] = SourceExpressionConverter.ConvertToken(mSOutlookReplyToEmailbody);
                    mSOutlookReplyToEmailpropCount++;
                }

                if (mSOutlookReplyToEmailhTMLBody != null)
                {
                    mSOutlookReplyToEmail["HTMLBody"] = SourceExpressionConverter.ConvertToken(mSOutlookReplyToEmailhTMLBody);
                    mSOutlookReplyToEmailpropCount++;
                }

                if (mSOutlookReplyToEmailrTFBody != null)
                {
                    mSOutlookReplyToEmail["RTFBody"] = SourceExpressionConverter.ConvertToken(mSOutlookReplyToEmailrTFBody);
                    mSOutlookReplyToEmailpropCount++;
                }

                if (mSOutlookReplyToEmailattachmentFilenamesJSON != null)
                {
                    mSOutlookReplyToEmail["AttachmentFilenamesJSON"] = SourceExpressionConverter.ConvertToken(mSOutlookReplyToEmailattachmentFilenamesJSON);
                    mSOutlookReplyToEmailpropCount++;
                }

                if (mSOutlookReplyToEmaildontSendIfAttachmentFilenameMissing != null)
                {
                    if (mSOutlookReplyToEmaildontSendIfAttachmentFilenameMissing != null)
                    {
                        mSOutlookReplyToEmail["DontSendIfAttachmentFilenameMissing"] = SourceExpressionConverter.ConvertToken(mSOutlookReplyToEmaildontSendIfAttachmentFilenameMissing);
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
                        mSOutlookReplyToEmail["ClickAllowButtonIfRequired"] = SourceExpressionConverter.ConvertToken(mSOutlookReplyToEmailclickAllowButtonIfRequired);
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
                    mSOutlookReplyToEmail["VotingOptions"] = SourceExpressionConverter.ConvertToken(mSOutlookReplyToEmailvotingOptions);
                    mSOutlookReplyToEmailpropCount++;
                }

                if (mSOutlookReplyToEmailsendAsSMTPAddress != null)
                {
                    mSOutlookReplyToEmail["SendAsSMTPAddress"] = SourceExpressionConverter.ConvertToken(mSOutlookReplyToEmailsendAsSMTPAddress);
                    mSOutlookReplyToEmailpropCount++;
                }

                if (mSOutlookReplyToEmailbodyContainsStoredPassword != null)
                {
                    if (mSOutlookReplyToEmailbodyContainsStoredPassword != null)
                    {
                        mSOutlookReplyToEmail["BodyContainsStoredPassword"] = SourceExpressionConverter.ConvertToken(mSOutlookReplyToEmailbodyContainsStoredPassword);
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
                mSOutlookReplyToEmail["Workflow"] = SourceExpressionConverter.ConvertToken(mSOutlookReplyToEmailworkflow);
                if (mSOutlookReplyToEmailpropCount > 0)
                {
                    callPayload.Body = mSOutlookReplyToEmail;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSOutlookForwardEmail([WorkflowExpression] Func<string> mSOutlookForwardEmailentryID, [WorkflowExpression] Func<string> mSOutlookForwardEmailworkflow, [WorkflowExpression] Func<string> mSOutlookForwardEmailto = null, [WorkflowExpression] Func<string> mSOutlookForwardEmailcC = null, [WorkflowExpression] Func<string> mSOutlookForwardEmailbCC = null, [WorkflowExpression] Func<bool> mSOutlookForwardEmailoverrideSubject = null, [WorkflowExpression] Func<string> mSOutlookForwardEmailsubject = null, [WorkflowExpression] Func<bool> mSOutlookForwardEmailoverrideBody = null, [WorkflowExpression] Func<mSOutlookForwardEmailbodyFormatInput> mSOutlookForwardEmailbodyFormat = null, [WorkflowExpression] Func<string> mSOutlookForwardEmailbody = null, [WorkflowExpression] Func<string> mSOutlookForwardEmailhTMLBody = null, [WorkflowExpression] Func<string> mSOutlookForwardEmailrTFBody = null, [WorkflowExpression] Func<bool> mSOutlookForwardEmailclickAllowButtonIfRequired = null, [WorkflowExpression] Func<string> mSOutlookForwardEmailvotingOptions = null, [WorkflowExpression] Func<string> mSOutlookForwardEmailsendAsSMTPAddress = null, [WorkflowExpression] Func<bool> mSOutlookForwardEmailincludeExistingHiddenAttachments = null, [WorkflowExpression] Func<bool> mSOutlookForwardEmailincludeExistingVisibleAttachments = null, [WorkflowExpression] Func<string> mSOutlookForwardEmailattachmentFilenamesJSON = null, [WorkflowExpression] Func<bool> mSOutlookForwardEmaildontSendIfAttachmentFilenameMissing = null, [WorkflowExpression] Func<bool> mSOutlookForwardEmailbodyContainsStoredPassword = null)
        {
            SourceExpression.Validate(mSOutlookForwardEmailentryID, nameof(mSOutlookForwardEmailentryID), required: true);
            SourceExpression.Validate(mSOutlookForwardEmailworkflow, nameof(mSOutlookForwardEmailworkflow), required: true);
            SourceExpression.Validate(mSOutlookForwardEmailto, nameof(mSOutlookForwardEmailto), required: false);
            SourceExpression.Validate(mSOutlookForwardEmailcC, nameof(mSOutlookForwardEmailcC), required: false);
            SourceExpression.Validate(mSOutlookForwardEmailbCC, nameof(mSOutlookForwardEmailbCC), required: false);
            SourceExpression.Validate(mSOutlookForwardEmailoverrideSubject, nameof(mSOutlookForwardEmailoverrideSubject), required: false);
            SourceExpression.Validate(mSOutlookForwardEmailsubject, nameof(mSOutlookForwardEmailsubject), required: false);
            SourceExpression.Validate(mSOutlookForwardEmailoverrideBody, nameof(mSOutlookForwardEmailoverrideBody), required: false);
            SourceExpression.Validate(mSOutlookForwardEmailbodyFormat, nameof(mSOutlookForwardEmailbodyFormat), required: false);
            SourceExpression.Validate(mSOutlookForwardEmailbody, nameof(mSOutlookForwardEmailbody), required: false);
            SourceExpression.Validate(mSOutlookForwardEmailhTMLBody, nameof(mSOutlookForwardEmailhTMLBody), required: false);
            SourceExpression.Validate(mSOutlookForwardEmailrTFBody, nameof(mSOutlookForwardEmailrTFBody), required: false);
            SourceExpression.Validate(mSOutlookForwardEmailclickAllowButtonIfRequired, nameof(mSOutlookForwardEmailclickAllowButtonIfRequired), required: false);
            SourceExpression.Validate(mSOutlookForwardEmailvotingOptions, nameof(mSOutlookForwardEmailvotingOptions), required: false);
            SourceExpression.Validate(mSOutlookForwardEmailsendAsSMTPAddress, nameof(mSOutlookForwardEmailsendAsSMTPAddress), required: false);
            SourceExpression.Validate(mSOutlookForwardEmailincludeExistingHiddenAttachments, nameof(mSOutlookForwardEmailincludeExistingHiddenAttachments), required: false);
            SourceExpression.Validate(mSOutlookForwardEmailincludeExistingVisibleAttachments, nameof(mSOutlookForwardEmailincludeExistingVisibleAttachments), required: false);
            SourceExpression.Validate(mSOutlookForwardEmailattachmentFilenamesJSON, nameof(mSOutlookForwardEmailattachmentFilenamesJSON), required: false);
            SourceExpression.Validate(mSOutlookForwardEmaildontSendIfAttachmentFilenameMissing, nameof(mSOutlookForwardEmaildontSendIfAttachmentFilenameMissing), required: false);
            SourceExpression.Validate(mSOutlookForwardEmailbodyContainsStoredPassword, nameof(mSOutlookForwardEmailbodyContainsStoredPassword), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/MSOutlook/MSOutlookForwardEmail";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSOutlookForwardEmail = new JObject();
                var mSOutlookForwardEmailpropCount = 0;
                mSOutlookForwardEmailpropCount++;
                mSOutlookForwardEmail["EntryID"] = SourceExpressionConverter.ConvertToken(mSOutlookForwardEmailentryID);
                if (mSOutlookForwardEmailto != null)
                {
                    mSOutlookForwardEmail["To"] = SourceExpressionConverter.ConvertToken(mSOutlookForwardEmailto);
                    mSOutlookForwardEmailpropCount++;
                }

                if (mSOutlookForwardEmailcC != null)
                {
                    mSOutlookForwardEmail["CC"] = SourceExpressionConverter.ConvertToken(mSOutlookForwardEmailcC);
                    mSOutlookForwardEmailpropCount++;
                }

                if (mSOutlookForwardEmailbCC != null)
                {
                    mSOutlookForwardEmail["BCC"] = SourceExpressionConverter.ConvertToken(mSOutlookForwardEmailbCC);
                    mSOutlookForwardEmailpropCount++;
                }

                if (mSOutlookForwardEmailoverrideSubject != null)
                {
                    if (mSOutlookForwardEmailoverrideSubject != null)
                    {
                        mSOutlookForwardEmail["OverrideSubject"] = SourceExpressionConverter.ConvertToken(mSOutlookForwardEmailoverrideSubject);
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
                    mSOutlookForwardEmail["Subject"] = SourceExpressionConverter.ConvertToken(mSOutlookForwardEmailsubject);
                    mSOutlookForwardEmailpropCount++;
                }

                if (mSOutlookForwardEmailoverrideBody != null)
                {
                    if (mSOutlookForwardEmailoverrideBody != null)
                    {
                        mSOutlookForwardEmail["OverrideBody"] = SourceExpressionConverter.ConvertToken(mSOutlookForwardEmailoverrideBody);
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
                    mSOutlookForwardEmail["BodyFormat"] = SourceExpressionConverter.Convert(mSOutlookForwardEmailbodyFormat);
                    mSOutlookForwardEmailpropCount++;
                }

                if (mSOutlookForwardEmailbody != null)
                {
                    mSOutlookForwardEmail["Body"] = SourceExpressionConverter.ConvertToken(mSOutlookForwardEmailbody);
                    mSOutlookForwardEmailpropCount++;
                }

                if (mSOutlookForwardEmailhTMLBody != null)
                {
                    mSOutlookForwardEmail["HTMLBody"] = SourceExpressionConverter.ConvertToken(mSOutlookForwardEmailhTMLBody);
                    mSOutlookForwardEmailpropCount++;
                }

                if (mSOutlookForwardEmailrTFBody != null)
                {
                    mSOutlookForwardEmail["RTFBody"] = SourceExpressionConverter.ConvertToken(mSOutlookForwardEmailrTFBody);
                    mSOutlookForwardEmailpropCount++;
                }

                if (mSOutlookForwardEmailclickAllowButtonIfRequired != null)
                {
                    if (mSOutlookForwardEmailclickAllowButtonIfRequired != null)
                    {
                        mSOutlookForwardEmail["ClickAllowButtonIfRequired"] = SourceExpressionConverter.ConvertToken(mSOutlookForwardEmailclickAllowButtonIfRequired);
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
                    mSOutlookForwardEmail["VotingOptions"] = SourceExpressionConverter.ConvertToken(mSOutlookForwardEmailvotingOptions);
                    mSOutlookForwardEmailpropCount++;
                }

                if (mSOutlookForwardEmailsendAsSMTPAddress != null)
                {
                    mSOutlookForwardEmail["SendAsSMTPAddress"] = SourceExpressionConverter.ConvertToken(mSOutlookForwardEmailsendAsSMTPAddress);
                    mSOutlookForwardEmailpropCount++;
                }

                if (mSOutlookForwardEmailincludeExistingHiddenAttachments != null)
                {
                    if (mSOutlookForwardEmailincludeExistingHiddenAttachments != null)
                    {
                        mSOutlookForwardEmail["IncludeExistingHiddenAttachments"] = SourceExpressionConverter.ConvertToken(mSOutlookForwardEmailincludeExistingHiddenAttachments);
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
                        mSOutlookForwardEmail["IncludeExistingVisibleAttachments"] = SourceExpressionConverter.ConvertToken(mSOutlookForwardEmailincludeExistingVisibleAttachments);
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
                    mSOutlookForwardEmail["AttachmentFilenamesJSON"] = SourceExpressionConverter.ConvertToken(mSOutlookForwardEmailattachmentFilenamesJSON);
                    mSOutlookForwardEmailpropCount++;
                }

                if (mSOutlookForwardEmaildontSendIfAttachmentFilenameMissing != null)
                {
                    if (mSOutlookForwardEmaildontSendIfAttachmentFilenameMissing != null)
                    {
                        mSOutlookForwardEmail["DontSendIfAttachmentFilenameMissing"] = SourceExpressionConverter.ConvertToken(mSOutlookForwardEmaildontSendIfAttachmentFilenameMissing);
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
                        mSOutlookForwardEmail["BodyContainsStoredPassword"] = SourceExpressionConverter.ConvertToken(mSOutlookForwardEmailbodyContainsStoredPassword);
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
                mSOutlookForwardEmail["Workflow"] = SourceExpressionConverter.ConvertToken(mSOutlookForwardEmailworkflow);
                if (mSOutlookForwardEmailpropCount > 0)
                {
                    callPayload.Body = mSOutlookForwardEmail;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookGetMAPIProfilesResponse> MSOutlookGetMAPIProfiles([WorkflowExpression] Func<string> mSOutlookGetMAPIProfilesworkflow)
        {
            SourceExpression.Validate(mSOutlookGetMAPIProfilesworkflow, nameof(mSOutlookGetMAPIProfilesworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/MSOutlook/GetMAPIProfiles";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSOutlookGetMAPIProfiles = new JObject();
                var mSOutlookGetMAPIProfilespropCount = 0;
                mSOutlookGetMAPIProfilespropCount++;
                mSOutlookGetMAPIProfiles["Workflow"] = SourceExpressionConverter.ConvertToken(mSOutlookGetMAPIProfilesworkflow);
                if (mSOutlookGetMAPIProfilespropCount > 0)
                {
                    callPayload.Body = mSOutlookGetMAPIProfiles;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MSOutlookGetMAPIProfilesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookGetOutlookProcessIdResponse> MSOutlookGetOutlookProcessId([WorkflowExpression] Func<string> mSOutlookGetOutlookProcessIdworkflow)
        {
            SourceExpression.Validate(mSOutlookGetOutlookProcessIdworkflow, nameof(mSOutlookGetOutlookProcessIdworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/MSOutlook/GetOutlookProcessId";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSOutlookGetOutlookProcessId = new JObject();
                var mSOutlookGetOutlookProcessIdpropCount = 0;
                mSOutlookGetOutlookProcessIdpropCount++;
                mSOutlookGetOutlookProcessId["Workflow"] = SourceExpressionConverter.ConvertToken(mSOutlookGetOutlookProcessIdworkflow);
                if (mSOutlookGetOutlookProcessIdpropCount > 0)
                {
                    callPayload.Body = mSOutlookGetOutlookProcessId;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MSOutlookGetOutlookProcessIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSOutlookBackgroundMonitorForAllowPopup([WorkflowExpression] Func<string> mSOutlookBackgroundMonitorForAllowPopupworkflow, [WorkflowExpression] Func<int> mSOutlookBackgroundMonitorForAllowPopupsecondsToWaitForDialog = null, [WorkflowExpression] Func<int> mSOutlookBackgroundMonitorForAllowPopupsecondsToWaitForAllowButton = null, [WorkflowExpression] Func<int> mSOutlookBackgroundMonitorForAllowPopupsecondsToWaitForAllowButtonToBeEnabled = null, [WorkflowExpression] Func<string> mSOutlookBackgroundMonitorForAllowPopupoutlookAllowButtonName = null)
        {
            SourceExpression.Validate(mSOutlookBackgroundMonitorForAllowPopupworkflow, nameof(mSOutlookBackgroundMonitorForAllowPopupworkflow), required: true);
            SourceExpression.Validate(mSOutlookBackgroundMonitorForAllowPopupsecondsToWaitForDialog, nameof(mSOutlookBackgroundMonitorForAllowPopupsecondsToWaitForDialog), required: false);
            SourceExpression.Validate(mSOutlookBackgroundMonitorForAllowPopupsecondsToWaitForAllowButton, nameof(mSOutlookBackgroundMonitorForAllowPopupsecondsToWaitForAllowButton), required: false);
            SourceExpression.Validate(mSOutlookBackgroundMonitorForAllowPopupsecondsToWaitForAllowButtonToBeEnabled, nameof(mSOutlookBackgroundMonitorForAllowPopupsecondsToWaitForAllowButtonToBeEnabled), required: false);
            SourceExpression.Validate(mSOutlookBackgroundMonitorForAllowPopupoutlookAllowButtonName, nameof(mSOutlookBackgroundMonitorForAllowPopupoutlookAllowButtonName), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSOutlookBackgroundMonitorForAllowPopup["SecondsToWaitForDialog"] = SourceExpressionConverter.ConvertToken(mSOutlookBackgroundMonitorForAllowPopupsecondsToWaitForDialog);
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
                        mSOutlookBackgroundMonitorForAllowPopup["SecondsToWaitForAllowButton"] = SourceExpressionConverter.ConvertToken(mSOutlookBackgroundMonitorForAllowPopupsecondsToWaitForAllowButton);
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
                        mSOutlookBackgroundMonitorForAllowPopup["SecondsToWaitForAllowButtonToBeEnabled"] = SourceExpressionConverter.ConvertToken(mSOutlookBackgroundMonitorForAllowPopupsecondsToWaitForAllowButtonToBeEnabled);
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
                        mSOutlookBackgroundMonitorForAllowPopup["OutlookAllowButtonName"] = SourceExpressionConverter.ConvertToken(mSOutlookBackgroundMonitorForAllowPopupoutlookAllowButtonName);
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
                mSOutlookBackgroundMonitorForAllowPopup["Workflow"] = SourceExpressionConverter.ConvertToken(mSOutlookBackgroundMonitorForAllowPopupworkflow);
                if (mSOutlookBackgroundMonitorForAllowPopuppropCount > 0)
                {
                    callPayload.Body = mSOutlookBackgroundMonitorForAllowPopup;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IWorkflowAction MSOutlookSetAllowPopupDetails([WorkflowExpression] Func<string> mSOutlookSetAllowPopupDetailsworkflow, [WorkflowExpression] Func<string> mSOutlookSetAllowPopupDetailsoutlookAllowButtonName = null, [WorkflowExpression] Func<string> mSOutlookSetAllowPopupDetailsoutlookAllowButtonAutomationId = null, [WorkflowExpression] Func<string> mSOutlookSetAllowPopupDetailsoutlookAllowCheckboxAutomationId = null)
        {
            SourceExpression.Validate(mSOutlookSetAllowPopupDetailsworkflow, nameof(mSOutlookSetAllowPopupDetailsworkflow), required: true);
            SourceExpression.Validate(mSOutlookSetAllowPopupDetailsoutlookAllowButtonName, nameof(mSOutlookSetAllowPopupDetailsoutlookAllowButtonName), required: false);
            SourceExpression.Validate(mSOutlookSetAllowPopupDetailsoutlookAllowButtonAutomationId, nameof(mSOutlookSetAllowPopupDetailsoutlookAllowButtonAutomationId), required: false);
            SourceExpression.Validate(mSOutlookSetAllowPopupDetailsoutlookAllowCheckboxAutomationId, nameof(mSOutlookSetAllowPopupDetailsoutlookAllowCheckboxAutomationId), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        mSOutlookSetAllowPopupDetails["OutlookAllowButtonName"] = SourceExpressionConverter.ConvertToken(mSOutlookSetAllowPopupDetailsoutlookAllowButtonName);
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
                        mSOutlookSetAllowPopupDetails["OutlookAllowButtonAutomationId"] = SourceExpressionConverter.ConvertToken(mSOutlookSetAllowPopupDetailsoutlookAllowButtonAutomationId);
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
                        mSOutlookSetAllowPopupDetails["OutlookAllowCheckboxAutomationId"] = SourceExpressionConverter.ConvertToken(mSOutlookSetAllowPopupDetailsoutlookAllowCheckboxAutomationId);
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
                mSOutlookSetAllowPopupDetails["Workflow"] = SourceExpressionConverter.ConvertToken(mSOutlookSetAllowPopupDetailsworkflow);
                if (mSOutlookSetAllowPopupDetailspropCount > 0)
                {
                    callPayload.Body = mSOutlookSetAllowPopupDetails;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookExecuteCommandBarObjectResponse> MSOutlookExecuteCommandBarObject([WorkflowExpression] Func<string> mSOutlookExecuteCommandBarObjectobjectId, [WorkflowExpression] Func<string> mSOutlookExecuteCommandBarObjectworkflow, [WorkflowExpression] Func<bool> mSOutlookExecuteCommandBarObjectrunInBackground = null)
        {
            SourceExpression.Validate(mSOutlookExecuteCommandBarObjectobjectId, nameof(mSOutlookExecuteCommandBarObjectobjectId), required: true);
            SourceExpression.Validate(mSOutlookExecuteCommandBarObjectworkflow, nameof(mSOutlookExecuteCommandBarObjectworkflow), required: true);
            SourceExpression.Validate(mSOutlookExecuteCommandBarObjectrunInBackground, nameof(mSOutlookExecuteCommandBarObjectrunInBackground), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/MSOutlook/MSOutlookExecuteCommandBarObject";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSOutlookExecuteCommandBarObject = new JObject();
                var mSOutlookExecuteCommandBarObjectpropCount = 0;
                mSOutlookExecuteCommandBarObjectpropCount++;
                mSOutlookExecuteCommandBarObject["ObjectId"] = SourceExpressionConverter.ConvertToken(mSOutlookExecuteCommandBarObjectobjectId);
                if (mSOutlookExecuteCommandBarObjectrunInBackground != null)
                {
                    if (mSOutlookExecuteCommandBarObjectrunInBackground != null)
                    {
                        mSOutlookExecuteCommandBarObject["RunInBackground"] = SourceExpressionConverter.ConvertToken(mSOutlookExecuteCommandBarObjectrunInBackground);
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
                mSOutlookExecuteCommandBarObject["Workflow"] = SourceExpressionConverter.ConvertToken(mSOutlookExecuteCommandBarObjectworkflow);
                if (mSOutlookExecuteCommandBarObjectpropCount > 0)
                {
                    callPayload.Body = mSOutlookExecuteCommandBarObject;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MSOutlookExecuteCommandBarObjectResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookGetEmailsResponse> MSOutlookGetEmails([WorkflowExpression] Func<string> mSOutlookGetEmailsworkflow, [WorkflowExpression] Func<string> mSOutlookGetEmailsfolderPath = null, [WorkflowExpression] Func<bool> mSOutlookGetEmailssearchRead = null, [WorkflowExpression] Func<bool> mSOutlookGetEmailssearchUnread = null, [WorkflowExpression] Func<string> mSOutlookGetEmailssearchSubject = null, [WorkflowExpression] Func<string> mSOutlookGetEmailssearchFromSMTP = null, [WorkflowExpression] Func<string> mSOutlookGetEmailssearchFromName = null, [WorkflowExpression] Func<string> mSOutlookGetEmailssearchQuery = null, [WorkflowExpression] Func<int> mSOutlookGetEmailssearchMaxAgeInDays = null, [WorkflowExpression] Func<string> mSOutlookGetEmailssearchStartDateTimeAsString = null, [WorkflowExpression] Func<string> mSOutlookGetEmailssearchEndDateTimeAsString = null, [WorkflowExpression] Func<int> mSOutlookGetEmailsmaxResultsToReturn = null, [WorkflowExpression] Func<bool> mSOutlookGetEmailsclickAllowButtonIfRequired = null)
        {
            SourceExpression.Validate(mSOutlookGetEmailsworkflow, nameof(mSOutlookGetEmailsworkflow), required: true);
            SourceExpression.Validate(mSOutlookGetEmailsfolderPath, nameof(mSOutlookGetEmailsfolderPath), required: false);
            SourceExpression.Validate(mSOutlookGetEmailssearchRead, nameof(mSOutlookGetEmailssearchRead), required: false);
            SourceExpression.Validate(mSOutlookGetEmailssearchUnread, nameof(mSOutlookGetEmailssearchUnread), required: false);
            SourceExpression.Validate(mSOutlookGetEmailssearchSubject, nameof(mSOutlookGetEmailssearchSubject), required: false);
            SourceExpression.Validate(mSOutlookGetEmailssearchFromSMTP, nameof(mSOutlookGetEmailssearchFromSMTP), required: false);
            SourceExpression.Validate(mSOutlookGetEmailssearchFromName, nameof(mSOutlookGetEmailssearchFromName), required: false);
            SourceExpression.Validate(mSOutlookGetEmailssearchQuery, nameof(mSOutlookGetEmailssearchQuery), required: false);
            SourceExpression.Validate(mSOutlookGetEmailssearchMaxAgeInDays, nameof(mSOutlookGetEmailssearchMaxAgeInDays), required: false);
            SourceExpression.Validate(mSOutlookGetEmailssearchStartDateTimeAsString, nameof(mSOutlookGetEmailssearchStartDateTimeAsString), required: false);
            SourceExpression.Validate(mSOutlookGetEmailssearchEndDateTimeAsString, nameof(mSOutlookGetEmailssearchEndDateTimeAsString), required: false);
            SourceExpression.Validate(mSOutlookGetEmailsmaxResultsToReturn, nameof(mSOutlookGetEmailsmaxResultsToReturn), required: false);
            SourceExpression.Validate(mSOutlookGetEmailsclickAllowButtonIfRequired, nameof(mSOutlookGetEmailsclickAllowButtonIfRequired), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/MSOutlook/GetEmails";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSOutlookGetEmails = new JObject();
                var mSOutlookGetEmailspropCount = 0;
                if (mSOutlookGetEmailsfolderPath != null)
                {
                    mSOutlookGetEmails["FolderPath"] = SourceExpressionConverter.ConvertToken(mSOutlookGetEmailsfolderPath);
                    mSOutlookGetEmailspropCount++;
                }

                if (mSOutlookGetEmailssearchRead != null)
                {
                    if (mSOutlookGetEmailssearchRead != null)
                    {
                        mSOutlookGetEmails["SearchRead"] = SourceExpressionConverter.ConvertToken(mSOutlookGetEmailssearchRead);
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
                        mSOutlookGetEmails["SearchUnread"] = SourceExpressionConverter.ConvertToken(mSOutlookGetEmailssearchUnread);
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
                    mSOutlookGetEmails["SearchSubject"] = SourceExpressionConverter.ConvertToken(mSOutlookGetEmailssearchSubject);
                    mSOutlookGetEmailspropCount++;
                }

                if (mSOutlookGetEmailssearchFromSMTP != null)
                {
                    mSOutlookGetEmails["SearchFromSMTP"] = SourceExpressionConverter.ConvertToken(mSOutlookGetEmailssearchFromSMTP);
                    mSOutlookGetEmailspropCount++;
                }

                if (mSOutlookGetEmailssearchFromName != null)
                {
                    mSOutlookGetEmails["SearchFromName"] = SourceExpressionConverter.ConvertToken(mSOutlookGetEmailssearchFromName);
                    mSOutlookGetEmailspropCount++;
                }

                if (mSOutlookGetEmailssearchQuery != null)
                {
                    mSOutlookGetEmails["SearchQuery"] = SourceExpressionConverter.ConvertToken(mSOutlookGetEmailssearchQuery);
                    mSOutlookGetEmailspropCount++;
                }

                if (mSOutlookGetEmailssearchMaxAgeInDays != null)
                {
                    if (mSOutlookGetEmailssearchMaxAgeInDays != null)
                    {
                        mSOutlookGetEmails["SearchMaxAgeInDays"] = SourceExpressionConverter.ConvertToken(mSOutlookGetEmailssearchMaxAgeInDays);
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
                    mSOutlookGetEmails["SearchStartDateTimeAsString"] = SourceExpressionConverter.ConvertToken(mSOutlookGetEmailssearchStartDateTimeAsString);
                    mSOutlookGetEmailspropCount++;
                }

                if (mSOutlookGetEmailssearchEndDateTimeAsString != null)
                {
                    mSOutlookGetEmails["SearchEndDateTimeAsString"] = SourceExpressionConverter.ConvertToken(mSOutlookGetEmailssearchEndDateTimeAsString);
                    mSOutlookGetEmailspropCount++;
                }

                if (mSOutlookGetEmailsmaxResultsToReturn != null)
                {
                    if (mSOutlookGetEmailsmaxResultsToReturn != null)
                    {
                        mSOutlookGetEmails["MaxResultsToReturn"] = SourceExpressionConverter.ConvertToken(mSOutlookGetEmailsmaxResultsToReturn);
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
                        mSOutlookGetEmails["ClickAllowButtonIfRequired"] = SourceExpressionConverter.ConvertToken(mSOutlookGetEmailsclickAllowButtonIfRequired);
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
                mSOutlookGetEmails["Workflow"] = SourceExpressionConverter.ConvertToken(mSOutlookGetEmailsworkflow);
                if (mSOutlookGetEmailspropCount > 0)
                {
                    callPayload.Body = mSOutlookGetEmails;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MSOutlookGetEmailsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookGetFirstEmailResponse> MSOutlookGetFirstEmail([WorkflowExpression] Func<string> mSOutlookGetFirstEmailworkflow, [WorkflowExpression] Func<string> mSOutlookGetFirstEmailfolderPath = null, [WorkflowExpression] Func<bool> mSOutlookGetFirstEmailsearchRead = null, [WorkflowExpression] Func<bool> mSOutlookGetFirstEmailsearchUnread = null, [WorkflowExpression] Func<string> mSOutlookGetFirstEmailsearchSubject = null, [WorkflowExpression] Func<string> mSOutlookGetFirstEmailsearchFromSMTP = null, [WorkflowExpression] Func<string> mSOutlookGetFirstEmailsearchFromName = null, [WorkflowExpression] Func<string> mSOutlookGetFirstEmailsearchQuery = null, [WorkflowExpression] Func<int> mSOutlookGetFirstEmailsearchMaxAgeInDays = null, [WorkflowExpression] Func<string> mSOutlookGetFirstEmailsearchStartDateTimeAsString = null, [WorkflowExpression] Func<string> mSOutlookGetFirstEmailsearchEndDateTimeAsString = null, [WorkflowExpression] Func<bool> mSOutlookGetFirstEmailclickAllowButtonIfRequired = null)
        {
            SourceExpression.Validate(mSOutlookGetFirstEmailworkflow, nameof(mSOutlookGetFirstEmailworkflow), required: true);
            SourceExpression.Validate(mSOutlookGetFirstEmailfolderPath, nameof(mSOutlookGetFirstEmailfolderPath), required: false);
            SourceExpression.Validate(mSOutlookGetFirstEmailsearchRead, nameof(mSOutlookGetFirstEmailsearchRead), required: false);
            SourceExpression.Validate(mSOutlookGetFirstEmailsearchUnread, nameof(mSOutlookGetFirstEmailsearchUnread), required: false);
            SourceExpression.Validate(mSOutlookGetFirstEmailsearchSubject, nameof(mSOutlookGetFirstEmailsearchSubject), required: false);
            SourceExpression.Validate(mSOutlookGetFirstEmailsearchFromSMTP, nameof(mSOutlookGetFirstEmailsearchFromSMTP), required: false);
            SourceExpression.Validate(mSOutlookGetFirstEmailsearchFromName, nameof(mSOutlookGetFirstEmailsearchFromName), required: false);
            SourceExpression.Validate(mSOutlookGetFirstEmailsearchQuery, nameof(mSOutlookGetFirstEmailsearchQuery), required: false);
            SourceExpression.Validate(mSOutlookGetFirstEmailsearchMaxAgeInDays, nameof(mSOutlookGetFirstEmailsearchMaxAgeInDays), required: false);
            SourceExpression.Validate(mSOutlookGetFirstEmailsearchStartDateTimeAsString, nameof(mSOutlookGetFirstEmailsearchStartDateTimeAsString), required: false);
            SourceExpression.Validate(mSOutlookGetFirstEmailsearchEndDateTimeAsString, nameof(mSOutlookGetFirstEmailsearchEndDateTimeAsString), required: false);
            SourceExpression.Validate(mSOutlookGetFirstEmailclickAllowButtonIfRequired, nameof(mSOutlookGetFirstEmailclickAllowButtonIfRequired), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/MSOutlook/GetFirstEmail";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSOutlookGetFirstEmail = new JObject();
                var mSOutlookGetFirstEmailpropCount = 0;
                if (mSOutlookGetFirstEmailfolderPath != null)
                {
                    mSOutlookGetFirstEmail["FolderPath"] = SourceExpressionConverter.ConvertToken(mSOutlookGetFirstEmailfolderPath);
                    mSOutlookGetFirstEmailpropCount++;
                }

                if (mSOutlookGetFirstEmailsearchRead != null)
                {
                    if (mSOutlookGetFirstEmailsearchRead != null)
                    {
                        mSOutlookGetFirstEmail["SearchRead"] = SourceExpressionConverter.ConvertToken(mSOutlookGetFirstEmailsearchRead);
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
                        mSOutlookGetFirstEmail["SearchUnread"] = SourceExpressionConverter.ConvertToken(mSOutlookGetFirstEmailsearchUnread);
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
                    mSOutlookGetFirstEmail["SearchSubject"] = SourceExpressionConverter.ConvertToken(mSOutlookGetFirstEmailsearchSubject);
                    mSOutlookGetFirstEmailpropCount++;
                }

                if (mSOutlookGetFirstEmailsearchFromSMTP != null)
                {
                    mSOutlookGetFirstEmail["SearchFromSMTP"] = SourceExpressionConverter.ConvertToken(mSOutlookGetFirstEmailsearchFromSMTP);
                    mSOutlookGetFirstEmailpropCount++;
                }

                if (mSOutlookGetFirstEmailsearchFromName != null)
                {
                    mSOutlookGetFirstEmail["SearchFromName"] = SourceExpressionConverter.ConvertToken(mSOutlookGetFirstEmailsearchFromName);
                    mSOutlookGetFirstEmailpropCount++;
                }

                if (mSOutlookGetFirstEmailsearchQuery != null)
                {
                    mSOutlookGetFirstEmail["SearchQuery"] = SourceExpressionConverter.ConvertToken(mSOutlookGetFirstEmailsearchQuery);
                    mSOutlookGetFirstEmailpropCount++;
                }

                if (mSOutlookGetFirstEmailsearchMaxAgeInDays != null)
                {
                    if (mSOutlookGetFirstEmailsearchMaxAgeInDays != null)
                    {
                        mSOutlookGetFirstEmail["SearchMaxAgeInDays"] = SourceExpressionConverter.ConvertToken(mSOutlookGetFirstEmailsearchMaxAgeInDays);
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
                    mSOutlookGetFirstEmail["SearchStartDateTimeAsString"] = SourceExpressionConverter.ConvertToken(mSOutlookGetFirstEmailsearchStartDateTimeAsString);
                    mSOutlookGetFirstEmailpropCount++;
                }

                if (mSOutlookGetFirstEmailsearchEndDateTimeAsString != null)
                {
                    mSOutlookGetFirstEmail["SearchEndDateTimeAsString"] = SourceExpressionConverter.ConvertToken(mSOutlookGetFirstEmailsearchEndDateTimeAsString);
                    mSOutlookGetFirstEmailpropCount++;
                }

                if (mSOutlookGetFirstEmailclickAllowButtonIfRequired != null)
                {
                    if (mSOutlookGetFirstEmailclickAllowButtonIfRequired != null)
                    {
                        mSOutlookGetFirstEmail["ClickAllowButtonIfRequired"] = SourceExpressionConverter.ConvertToken(mSOutlookGetFirstEmailclickAllowButtonIfRequired);
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
                mSOutlookGetFirstEmail["Workflow"] = SourceExpressionConverter.ConvertToken(mSOutlookGetFirstEmailworkflow);
                if (mSOutlookGetFirstEmailpropCount > 0)
                {
                    callPayload.Body = mSOutlookGetFirstEmail;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MSOutlookGetFirstEmailResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmsoffice")]
        public IBodyWorkflowAction<MSOutlookGetNumberOfEmailsResponse> MSOutlookGetNumberOfEmails([WorkflowExpression] Func<string> mSOutlookGetNumberOfEmailsworkflow, [WorkflowExpression] Func<string> mSOutlookGetNumberOfEmailsfolderPath = null, [WorkflowExpression] Func<bool> mSOutlookGetNumberOfEmailssearchRead = null, [WorkflowExpression] Func<bool> mSOutlookGetNumberOfEmailssearchUnread = null, [WorkflowExpression] Func<string> mSOutlookGetNumberOfEmailssearchSubject = null, [WorkflowExpression] Func<string> mSOutlookGetNumberOfEmailssearchFromSMTP = null, [WorkflowExpression] Func<string> mSOutlookGetNumberOfEmailssearchFromName = null, [WorkflowExpression] Func<string> mSOutlookGetNumberOfEmailssearchQuery = null, [WorkflowExpression] Func<int> mSOutlookGetNumberOfEmailssearchMaxAgeInDays = null, [WorkflowExpression] Func<string> mSOutlookGetNumberOfEmailssearchStartDateTimeAsString = null, [WorkflowExpression] Func<string> mSOutlookGetNumberOfEmailssearchEndDateTimeAsString = null)
        {
            SourceExpression.Validate(mSOutlookGetNumberOfEmailsworkflow, nameof(mSOutlookGetNumberOfEmailsworkflow), required: true);
            SourceExpression.Validate(mSOutlookGetNumberOfEmailsfolderPath, nameof(mSOutlookGetNumberOfEmailsfolderPath), required: false);
            SourceExpression.Validate(mSOutlookGetNumberOfEmailssearchRead, nameof(mSOutlookGetNumberOfEmailssearchRead), required: false);
            SourceExpression.Validate(mSOutlookGetNumberOfEmailssearchUnread, nameof(mSOutlookGetNumberOfEmailssearchUnread), required: false);
            SourceExpression.Validate(mSOutlookGetNumberOfEmailssearchSubject, nameof(mSOutlookGetNumberOfEmailssearchSubject), required: false);
            SourceExpression.Validate(mSOutlookGetNumberOfEmailssearchFromSMTP, nameof(mSOutlookGetNumberOfEmailssearchFromSMTP), required: false);
            SourceExpression.Validate(mSOutlookGetNumberOfEmailssearchFromName, nameof(mSOutlookGetNumberOfEmailssearchFromName), required: false);
            SourceExpression.Validate(mSOutlookGetNumberOfEmailssearchQuery, nameof(mSOutlookGetNumberOfEmailssearchQuery), required: false);
            SourceExpression.Validate(mSOutlookGetNumberOfEmailssearchMaxAgeInDays, nameof(mSOutlookGetNumberOfEmailssearchMaxAgeInDays), required: false);
            SourceExpression.Validate(mSOutlookGetNumberOfEmailssearchStartDateTimeAsString, nameof(mSOutlookGetNumberOfEmailssearchStartDateTimeAsString), required: false);
            SourceExpression.Validate(mSOutlookGetNumberOfEmailssearchEndDateTimeAsString, nameof(mSOutlookGetNumberOfEmailssearchEndDateTimeAsString), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/MSOutlook/GetNumberOfEmails";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var mSOutlookGetNumberOfEmails = new JObject();
                var mSOutlookGetNumberOfEmailspropCount = 0;
                if (mSOutlookGetNumberOfEmailsfolderPath != null)
                {
                    mSOutlookGetNumberOfEmails["FolderPath"] = SourceExpressionConverter.ConvertToken(mSOutlookGetNumberOfEmailsfolderPath);
                    mSOutlookGetNumberOfEmailspropCount++;
                }

                if (mSOutlookGetNumberOfEmailssearchRead != null)
                {
                    if (mSOutlookGetNumberOfEmailssearchRead != null)
                    {
                        mSOutlookGetNumberOfEmails["SearchRead"] = SourceExpressionConverter.ConvertToken(mSOutlookGetNumberOfEmailssearchRead);
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
                        mSOutlookGetNumberOfEmails["SearchUnread"] = SourceExpressionConverter.ConvertToken(mSOutlookGetNumberOfEmailssearchUnread);
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
                    mSOutlookGetNumberOfEmails["SearchSubject"] = SourceExpressionConverter.ConvertToken(mSOutlookGetNumberOfEmailssearchSubject);
                    mSOutlookGetNumberOfEmailspropCount++;
                }

                if (mSOutlookGetNumberOfEmailssearchFromSMTP != null)
                {
                    mSOutlookGetNumberOfEmails["SearchFromSMTP"] = SourceExpressionConverter.ConvertToken(mSOutlookGetNumberOfEmailssearchFromSMTP);
                    mSOutlookGetNumberOfEmailspropCount++;
                }

                if (mSOutlookGetNumberOfEmailssearchFromName != null)
                {
                    mSOutlookGetNumberOfEmails["SearchFromName"] = SourceExpressionConverter.ConvertToken(mSOutlookGetNumberOfEmailssearchFromName);
                    mSOutlookGetNumberOfEmailspropCount++;
                }

                if (mSOutlookGetNumberOfEmailssearchQuery != null)
                {
                    mSOutlookGetNumberOfEmails["SearchQuery"] = SourceExpressionConverter.ConvertToken(mSOutlookGetNumberOfEmailssearchQuery);
                    mSOutlookGetNumberOfEmailspropCount++;
                }

                if (mSOutlookGetNumberOfEmailssearchMaxAgeInDays != null)
                {
                    if (mSOutlookGetNumberOfEmailssearchMaxAgeInDays != null)
                    {
                        mSOutlookGetNumberOfEmails["SearchMaxAgeInDays"] = SourceExpressionConverter.ConvertToken(mSOutlookGetNumberOfEmailssearchMaxAgeInDays);
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
                    mSOutlookGetNumberOfEmails["SearchStartDateTimeAsString"] = SourceExpressionConverter.ConvertToken(mSOutlookGetNumberOfEmailssearchStartDateTimeAsString);
                    mSOutlookGetNumberOfEmailspropCount++;
                }

                if (mSOutlookGetNumberOfEmailssearchEndDateTimeAsString != null)
                {
                    mSOutlookGetNumberOfEmails["SearchEndDateTimeAsString"] = SourceExpressionConverter.ConvertToken(mSOutlookGetNumberOfEmailssearchEndDateTimeAsString);
                    mSOutlookGetNumberOfEmailspropCount++;
                }

                mSOutlookGetNumberOfEmailspropCount++;
                mSOutlookGetNumberOfEmails["Workflow"] = SourceExpressionConverter.ConvertToken(mSOutlookGetNumberOfEmailsworkflow);
                if (mSOutlookGetNumberOfEmailspropCount > 0)
                {
                    callPayload.Body = mSOutlookGetNumberOfEmails;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MSOutlookGetNumberOfEmailsResponse>(BuildSourceInput);
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