//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectsapgui
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IaconnectsapguiActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPEnableScripting))]
        public IWorkflowAction SAPEnableScripting([WorkflowExpression] Func<string> sAPEnableScriptingworkflow, [WorkflowExpression] Func<bool> sAPEnableScriptingnotifyWhenScriptAttachesToGUI = null, [WorkflowExpression] Func<bool> sAPEnableScriptingnotifyWhenScriptOpensConnection = null, [WorkflowExpression] Func<bool> sAPEnableScriptingshowNativeWindowsDialogs = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSAPEnableScripting(WorkflowValue<string> sAPEnableScriptingworkflow, WorkflowValue<bool> sAPEnableScriptingnotifyWhenScriptAttachesToGUI = null, WorkflowValue<bool> sAPEnableScriptingnotifyWhenScriptOpensConnection = null, WorkflowValue<bool> sAPEnableScriptingshowNativeWindowsDialogs = null)
        {
            WorkflowValue.Validate(sAPEnableScriptingworkflow, nameof(sAPEnableScriptingworkflow), required: true);
            WorkflowValue.Validate(sAPEnableScriptingnotifyWhenScriptAttachesToGUI, nameof(sAPEnableScriptingnotifyWhenScriptAttachesToGUI), required: false);
            WorkflowValue.Validate(sAPEnableScriptingnotifyWhenScriptOpensConnection, nameof(sAPEnableScriptingnotifyWhenScriptOpensConnection), required: false);
            WorkflowValue.Validate(sAPEnableScriptingshowNativeWindowsDialogs, nameof(sAPEnableScriptingshowNativeWindowsDialogs), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/SAPGUI/SAPEnableScripting";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPEnableScripting = new JObject();
                var sAPEnableScriptingpropCount = 0;
                if (sAPEnableScriptingnotifyWhenScriptAttachesToGUI != null)
                {
                    if (sAPEnableScriptingnotifyWhenScriptAttachesToGUI != null)
                    {
                        sAPEnableScripting["NotifyWhenScriptAttachesToGUI"] = ExpressionConverter.ConvertO(sAPEnableScriptingnotifyWhenScriptAttachesToGUI);
                        sAPEnableScriptingpropCount++;
                    }

                    sAPEnableScriptingpropCount++;
                }
                else
                {
                    sAPEnableScripting["NotifyWhenScriptAttachesToGUI"] = false;
                    sAPEnableScriptingpropCount++;
                }

                if (sAPEnableScriptingnotifyWhenScriptOpensConnection != null)
                {
                    if (sAPEnableScriptingnotifyWhenScriptOpensConnection != null)
                    {
                        sAPEnableScripting["NotifyWhenScriptOpensConnection"] = ExpressionConverter.ConvertO(sAPEnableScriptingnotifyWhenScriptOpensConnection);
                        sAPEnableScriptingpropCount++;
                    }

                    sAPEnableScriptingpropCount++;
                }
                else
                {
                    sAPEnableScripting["NotifyWhenScriptOpensConnection"] = false;
                    sAPEnableScriptingpropCount++;
                }

                if (sAPEnableScriptingshowNativeWindowsDialogs != null)
                {
                    if (sAPEnableScriptingshowNativeWindowsDialogs != null)
                    {
                        sAPEnableScripting["ShowNativeWindowsDialogs"] = ExpressionConverter.ConvertO(sAPEnableScriptingshowNativeWindowsDialogs);
                        sAPEnableScriptingpropCount++;
                    }

                    sAPEnableScriptingpropCount++;
                }
                else
                {
                    sAPEnableScripting["ShowNativeWindowsDialogs"] = false;
                    sAPEnableScriptingpropCount++;
                }

                sAPEnableScriptingpropCount++;
                sAPEnableScripting["Workflow"] = ExpressionConverter.ConvertO(sAPEnableScriptingworkflow);
                if (sAPEnableScriptingpropCount > 0)
                {
                    callPayload.Body = sAPEnableScripting;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPLaunchSAPGUI))]
        public IBodyWorkflowAction<SAPLaunchSAPGUIResponse> SAPLaunchSAPGUI([WorkflowExpression] Func<string> sAPLaunchSAPGUIworkflow, [WorkflowExpression] Func<string> sAPLaunchSAPGUIsAPLogonEXE = null, [WorkflowExpression] Func<string> sAPLaunchSAPGUIsAPLogonArguments = null, [WorkflowExpression] Func<bool> sAPLaunchSAPGUIenableSAPScripting = null, [WorkflowExpression] Func<bool> sAPLaunchSAPGUInotifyWhenScriptAttachesToGUI = null, [WorkflowExpression] Func<bool> sAPLaunchSAPGUInotifyWhenScriptOpensConnection = null, [WorkflowExpression] Func<bool> sAPLaunchSAPGUIshowNativeWindowsDialogs = null, [WorkflowExpression] Func<bool> sAPLaunchSAPGUIattachAfterLaunch = null, [WorkflowExpression] Func<double> sAPLaunchSAPGUIsecondsToWait = null, [WorkflowExpression] Func<string> sAPLaunchSAPGUIsAPProgId = null, [WorkflowExpression] Func<bool> sAPLaunchSAPGUIdisableSystemMessages = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SAPLaunchSAPGUIResponse> __BuildSAPLaunchSAPGUI(WorkflowValue<string> sAPLaunchSAPGUIworkflow, WorkflowValue<string> sAPLaunchSAPGUIsAPLogonEXE = null, WorkflowValue<string> sAPLaunchSAPGUIsAPLogonArguments = null, WorkflowValue<bool> sAPLaunchSAPGUIenableSAPScripting = null, WorkflowValue<bool> sAPLaunchSAPGUInotifyWhenScriptAttachesToGUI = null, WorkflowValue<bool> sAPLaunchSAPGUInotifyWhenScriptOpensConnection = null, WorkflowValue<bool> sAPLaunchSAPGUIshowNativeWindowsDialogs = null, WorkflowValue<bool> sAPLaunchSAPGUIattachAfterLaunch = null, WorkflowValue<double> sAPLaunchSAPGUIsecondsToWait = null, WorkflowValue<string> sAPLaunchSAPGUIsAPProgId = null, WorkflowValue<bool> sAPLaunchSAPGUIdisableSystemMessages = null)
        {
            WorkflowValue.Validate(sAPLaunchSAPGUIworkflow, nameof(sAPLaunchSAPGUIworkflow), required: true);
            WorkflowValue.Validate(sAPLaunchSAPGUIsAPLogonEXE, nameof(sAPLaunchSAPGUIsAPLogonEXE), required: false);
            WorkflowValue.Validate(sAPLaunchSAPGUIsAPLogonArguments, nameof(sAPLaunchSAPGUIsAPLogonArguments), required: false);
            WorkflowValue.Validate(sAPLaunchSAPGUIenableSAPScripting, nameof(sAPLaunchSAPGUIenableSAPScripting), required: false);
            WorkflowValue.Validate(sAPLaunchSAPGUInotifyWhenScriptAttachesToGUI, nameof(sAPLaunchSAPGUInotifyWhenScriptAttachesToGUI), required: false);
            WorkflowValue.Validate(sAPLaunchSAPGUInotifyWhenScriptOpensConnection, nameof(sAPLaunchSAPGUInotifyWhenScriptOpensConnection), required: false);
            WorkflowValue.Validate(sAPLaunchSAPGUIshowNativeWindowsDialogs, nameof(sAPLaunchSAPGUIshowNativeWindowsDialogs), required: false);
            WorkflowValue.Validate(sAPLaunchSAPGUIattachAfterLaunch, nameof(sAPLaunchSAPGUIattachAfterLaunch), required: false);
            WorkflowValue.Validate(sAPLaunchSAPGUIsecondsToWait, nameof(sAPLaunchSAPGUIsecondsToWait), required: false);
            WorkflowValue.Validate(sAPLaunchSAPGUIsAPProgId, nameof(sAPLaunchSAPGUIsAPProgId), required: false);
            WorkflowValue.Validate(sAPLaunchSAPGUIdisableSystemMessages, nameof(sAPLaunchSAPGUIdisableSystemMessages), required: false);
            return new DeferredBodyAction<SAPLaunchSAPGUIResponse>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPLaunchSAPGUI";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPLaunchSAPGUI = new JObject();
                var sAPLaunchSAPGUIpropCount = 0;
                if (sAPLaunchSAPGUIsAPLogonEXE != null)
                {
                    sAPLaunchSAPGUI["SAPLogonEXE"] = ExpressionConverter.ConvertO(sAPLaunchSAPGUIsAPLogonEXE);
                    sAPLaunchSAPGUIpropCount++;
                }

                if (sAPLaunchSAPGUIsAPLogonArguments != null)
                {
                    sAPLaunchSAPGUI["SAPLogonArguments"] = ExpressionConverter.ConvertO(sAPLaunchSAPGUIsAPLogonArguments);
                    sAPLaunchSAPGUIpropCount++;
                }

                if (sAPLaunchSAPGUIenableSAPScripting != null)
                {
                    if (sAPLaunchSAPGUIenableSAPScripting != null)
                    {
                        sAPLaunchSAPGUI["EnableSAPScripting"] = ExpressionConverter.ConvertO(sAPLaunchSAPGUIenableSAPScripting);
                        sAPLaunchSAPGUIpropCount++;
                    }

                    sAPLaunchSAPGUIpropCount++;
                }
                else
                {
                    sAPLaunchSAPGUI["EnableSAPScripting"] = true;
                    sAPLaunchSAPGUIpropCount++;
                }

                if (sAPLaunchSAPGUInotifyWhenScriptAttachesToGUI != null)
                {
                    if (sAPLaunchSAPGUInotifyWhenScriptAttachesToGUI != null)
                    {
                        sAPLaunchSAPGUI["NotifyWhenScriptAttachesToGUI"] = ExpressionConverter.ConvertO(sAPLaunchSAPGUInotifyWhenScriptAttachesToGUI);
                        sAPLaunchSAPGUIpropCount++;
                    }

                    sAPLaunchSAPGUIpropCount++;
                }
                else
                {
                    sAPLaunchSAPGUI["NotifyWhenScriptAttachesToGUI"] = false;
                    sAPLaunchSAPGUIpropCount++;
                }

                if (sAPLaunchSAPGUInotifyWhenScriptOpensConnection != null)
                {
                    if (sAPLaunchSAPGUInotifyWhenScriptOpensConnection != null)
                    {
                        sAPLaunchSAPGUI["NotifyWhenScriptOpensConnection"] = ExpressionConverter.ConvertO(sAPLaunchSAPGUInotifyWhenScriptOpensConnection);
                        sAPLaunchSAPGUIpropCount++;
                    }

                    sAPLaunchSAPGUIpropCount++;
                }
                else
                {
                    sAPLaunchSAPGUI["NotifyWhenScriptOpensConnection"] = false;
                    sAPLaunchSAPGUIpropCount++;
                }

                if (sAPLaunchSAPGUIshowNativeWindowsDialogs != null)
                {
                    if (sAPLaunchSAPGUIshowNativeWindowsDialogs != null)
                    {
                        sAPLaunchSAPGUI["ShowNativeWindowsDialogs"] = ExpressionConverter.ConvertO(sAPLaunchSAPGUIshowNativeWindowsDialogs);
                        sAPLaunchSAPGUIpropCount++;
                    }

                    sAPLaunchSAPGUIpropCount++;
                }
                else
                {
                    sAPLaunchSAPGUI["ShowNativeWindowsDialogs"] = false;
                    sAPLaunchSAPGUIpropCount++;
                }

                if (sAPLaunchSAPGUIattachAfterLaunch != null)
                {
                    if (sAPLaunchSAPGUIattachAfterLaunch != null)
                    {
                        sAPLaunchSAPGUI["AttachAfterLaunch"] = ExpressionConverter.ConvertO(sAPLaunchSAPGUIattachAfterLaunch);
                        sAPLaunchSAPGUIpropCount++;
                    }

                    sAPLaunchSAPGUIpropCount++;
                }
                else
                {
                    sAPLaunchSAPGUI["AttachAfterLaunch"] = true;
                    sAPLaunchSAPGUIpropCount++;
                }

                if (sAPLaunchSAPGUIsecondsToWait != null)
                {
                    if (sAPLaunchSAPGUIsecondsToWait != null)
                    {
                        sAPLaunchSAPGUI["SecondsToWait"] = ExpressionConverter.ConvertO(sAPLaunchSAPGUIsecondsToWait);
                        sAPLaunchSAPGUIpropCount++;
                    }

                    sAPLaunchSAPGUIpropCount++;
                }
                else
                {
                    sAPLaunchSAPGUI["SecondsToWait"] = 15;
                    sAPLaunchSAPGUIpropCount++;
                }

                if (sAPLaunchSAPGUIsAPProgId != null)
                {
                    if (sAPLaunchSAPGUIsAPProgId != null)
                    {
                        sAPLaunchSAPGUI["SAPProgId"] = ExpressionConverter.ConvertO(sAPLaunchSAPGUIsAPProgId);
                        sAPLaunchSAPGUIpropCount++;
                    }

                    sAPLaunchSAPGUIpropCount++;
                }
                else
                {
                    sAPLaunchSAPGUI["SAPProgId"] = "SAPGUI";
                    sAPLaunchSAPGUIpropCount++;
                }

                if (sAPLaunchSAPGUIdisableSystemMessages != null)
                {
                    if (sAPLaunchSAPGUIdisableSystemMessages != null)
                    {
                        sAPLaunchSAPGUI["DisableSystemMessages"] = ExpressionConverter.ConvertO(sAPLaunchSAPGUIdisableSystemMessages);
                        sAPLaunchSAPGUIpropCount++;
                    }

                    sAPLaunchSAPGUIpropCount++;
                }
                else
                {
                    sAPLaunchSAPGUI["DisableSystemMessages"] = true;
                    sAPLaunchSAPGUIpropCount++;
                }

                sAPLaunchSAPGUIpropCount++;
                sAPLaunchSAPGUI["Workflow"] = ExpressionConverter.ConvertO(sAPLaunchSAPGUIworkflow);
                if (sAPLaunchSAPGUIpropCount > 0)
                {
                    callPayload.Body = sAPLaunchSAPGUI;
                }

                return new ApiConnectionAction<SAPLaunchSAPGUIResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPAttachToSAPGUI))]
        public IBodyWorkflowAction<SAPAttachToSAPGUIResponse> SAPAttachToSAPGUI([WorkflowExpression] Func<string> sAPAttachToSAPGUIworkflow, [WorkflowExpression] Func<string> sAPAttachToSAPGUIsAPProgId = null, [WorkflowExpression] Func<bool> sAPAttachToSAPGUIdisableSystemMessages = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SAPAttachToSAPGUIResponse> __BuildSAPAttachToSAPGUI(WorkflowValue<string> sAPAttachToSAPGUIworkflow, WorkflowValue<string> sAPAttachToSAPGUIsAPProgId = null, WorkflowValue<bool> sAPAttachToSAPGUIdisableSystemMessages = null)
        {
            WorkflowValue.Validate(sAPAttachToSAPGUIworkflow, nameof(sAPAttachToSAPGUIworkflow), required: true);
            WorkflowValue.Validate(sAPAttachToSAPGUIsAPProgId, nameof(sAPAttachToSAPGUIsAPProgId), required: false);
            WorkflowValue.Validate(sAPAttachToSAPGUIdisableSystemMessages, nameof(sAPAttachToSAPGUIdisableSystemMessages), required: false);
            return new DeferredBodyAction<SAPAttachToSAPGUIResponse>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPAttachToSAPGUI";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPAttachToSAPGUI = new JObject();
                var sAPAttachToSAPGUIpropCount = 0;
                if (sAPAttachToSAPGUIsAPProgId != null)
                {
                    if (sAPAttachToSAPGUIsAPProgId != null)
                    {
                        sAPAttachToSAPGUI["SAPProgId"] = ExpressionConverter.ConvertO(sAPAttachToSAPGUIsAPProgId);
                        sAPAttachToSAPGUIpropCount++;
                    }

                    sAPAttachToSAPGUIpropCount++;
                }
                else
                {
                    sAPAttachToSAPGUI["SAPProgId"] = "SAPGUI";
                    sAPAttachToSAPGUIpropCount++;
                }

                if (sAPAttachToSAPGUIdisableSystemMessages != null)
                {
                    if (sAPAttachToSAPGUIdisableSystemMessages != null)
                    {
                        sAPAttachToSAPGUI["DisableSystemMessages"] = ExpressionConverter.ConvertO(sAPAttachToSAPGUIdisableSystemMessages);
                        sAPAttachToSAPGUIpropCount++;
                    }

                    sAPAttachToSAPGUIpropCount++;
                }
                else
                {
                    sAPAttachToSAPGUI["DisableSystemMessages"] = true;
                    sAPAttachToSAPGUIpropCount++;
                }

                sAPAttachToSAPGUIpropCount++;
                sAPAttachToSAPGUI["Workflow"] = ExpressionConverter.ConvertO(sAPAttachToSAPGUIworkflow);
                if (sAPAttachToSAPGUIpropCount > 0)
                {
                    callPayload.Body = sAPAttachToSAPGUI;
                }

                return new ApiConnectionAction<SAPAttachToSAPGUIResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPDetachFromSAPGUI))]
        public IWorkflowAction SAPDetachFromSAPGUI([WorkflowExpression] Func<string> sAPDetachFromSAPGUIworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSAPDetachFromSAPGUI(WorkflowValue<string> sAPDetachFromSAPGUIworkflow)
        {
            WorkflowValue.Validate(sAPDetachFromSAPGUIworkflow, nameof(sAPDetachFromSAPGUIworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/SAPGUI/SAPDetachFromSAPGUI";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPDetachFromSAPGUI = new JObject();
                var sAPDetachFromSAPGUIpropCount = 0;
                sAPDetachFromSAPGUIpropCount++;
                sAPDetachFromSAPGUI["Workflow"] = ExpressionConverter.ConvertO(sAPDetachFromSAPGUIworkflow);
                if (sAPDetachFromSAPGUIpropCount > 0)
                {
                    callPayload.Body = sAPDetachFromSAPGUI;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPGetSAPGUIStatus))]
        public IBodyWorkflowAction<SAPGetSAPGUIStatusResponse> SAPGetSAPGUIStatus([WorkflowExpression] Func<string> sAPGetSAPGUIStatusworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SAPGetSAPGUIStatusResponse> __BuildSAPGetSAPGUIStatus(WorkflowValue<string> sAPGetSAPGUIStatusworkflow)
        {
            WorkflowValue.Validate(sAPGetSAPGUIStatusworkflow, nameof(sAPGetSAPGUIStatusworkflow), required: true);
            return new DeferredBodyAction<SAPGetSAPGUIStatusResponse>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetSAPGUIStatus";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGetSAPGUIStatus = new JObject();
                var sAPGetSAPGUIStatuspropCount = 0;
                sAPGetSAPGUIStatuspropCount++;
                sAPGetSAPGUIStatus["Workflow"] = ExpressionConverter.ConvertO(sAPGetSAPGUIStatusworkflow);
                if (sAPGetSAPGUIStatuspropCount > 0)
                {
                    callPayload.Body = sAPGetSAPGUIStatus;
                }

                return new ApiConnectionAction<SAPGetSAPGUIStatusResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPGetSAPSessions))]
        public IBodyWorkflowAction<SAPGetSAPSessionsResponse> SAPGetSAPSessions([WorkflowExpression] Func<string> sAPGetSAPSessionsworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SAPGetSAPSessionsResponse> __BuildSAPGetSAPSessions(WorkflowValue<string> sAPGetSAPSessionsworkflow)
        {
            WorkflowValue.Validate(sAPGetSAPSessionsworkflow, nameof(sAPGetSAPSessionsworkflow), required: true);
            return new DeferredBodyAction<SAPGetSAPSessionsResponse>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetSAPSessions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGetSAPSessions = new JObject();
                var sAPGetSAPSessionspropCount = 0;
                sAPGetSAPSessionspropCount++;
                sAPGetSAPSessions["Workflow"] = ExpressionConverter.ConvertO(sAPGetSAPSessionsworkflow);
                if (sAPGetSAPSessionspropCount > 0)
                {
                    callPayload.Body = sAPGetSAPSessions;
                }

                return new ApiConnectionAction<SAPGetSAPSessionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPAttachToSession))]
        public IBodyWorkflowAction<SAPAttachToSessionResponse> SAPAttachToSession([WorkflowExpression] Func<string> sAPAttachToSessionworkflow, [WorkflowExpression] Func<string> sAPAttachToSessionsearchConnectionName = null, [WorkflowExpression] Func<string> sAPAttachToSessionsearchSessionName = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SAPAttachToSessionResponse> __BuildSAPAttachToSession(WorkflowValue<string> sAPAttachToSessionworkflow, WorkflowValue<string> sAPAttachToSessionsearchConnectionName = null, WorkflowValue<string> sAPAttachToSessionsearchSessionName = null)
        {
            WorkflowValue.Validate(sAPAttachToSessionworkflow, nameof(sAPAttachToSessionworkflow), required: true);
            WorkflowValue.Validate(sAPAttachToSessionsearchConnectionName, nameof(sAPAttachToSessionsearchConnectionName), required: false);
            WorkflowValue.Validate(sAPAttachToSessionsearchSessionName, nameof(sAPAttachToSessionsearchSessionName), required: false);
            return new DeferredBodyAction<SAPAttachToSessionResponse>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPAttachToSession";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPAttachToSession = new JObject();
                var sAPAttachToSessionpropCount = 0;
                if (sAPAttachToSessionsearchConnectionName != null)
                {
                    sAPAttachToSession["SearchConnectionName"] = ExpressionConverter.ConvertO(sAPAttachToSessionsearchConnectionName);
                    sAPAttachToSessionpropCount++;
                }

                if (sAPAttachToSessionsearchSessionName != null)
                {
                    sAPAttachToSession["SearchSessionName"] = ExpressionConverter.ConvertO(sAPAttachToSessionsearchSessionName);
                    sAPAttachToSessionpropCount++;
                }

                sAPAttachToSessionpropCount++;
                sAPAttachToSession["Workflow"] = ExpressionConverter.ConvertO(sAPAttachToSessionworkflow);
                if (sAPAttachToSessionpropCount > 0)
                {
                    callPayload.Body = sAPAttachToSession;
                }

                return new ApiConnectionAction<SAPAttachToSessionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPCloseSession))]
        public IWorkflowAction SAPCloseSession([WorkflowExpression] Func<string> sAPCloseSessionworkflow, [WorkflowExpression] Func<bool> sAPCloseSessioncloseAttachedSession = null, [WorkflowExpression] Func<string> sAPCloseSessionsearchConnectionName = null, [WorkflowExpression] Func<string> sAPCloseSessionsearchSessionName = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSAPCloseSession(WorkflowValue<string> sAPCloseSessionworkflow, WorkflowValue<bool> sAPCloseSessioncloseAttachedSession = null, WorkflowValue<string> sAPCloseSessionsearchConnectionName = null, WorkflowValue<string> sAPCloseSessionsearchSessionName = null)
        {
            WorkflowValue.Validate(sAPCloseSessionworkflow, nameof(sAPCloseSessionworkflow), required: true);
            WorkflowValue.Validate(sAPCloseSessioncloseAttachedSession, nameof(sAPCloseSessioncloseAttachedSession), required: false);
            WorkflowValue.Validate(sAPCloseSessionsearchConnectionName, nameof(sAPCloseSessionsearchConnectionName), required: false);
            WorkflowValue.Validate(sAPCloseSessionsearchSessionName, nameof(sAPCloseSessionsearchSessionName), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/SAPGUI/SAPCloseSession";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPCloseSession = new JObject();
                var sAPCloseSessionpropCount = 0;
                if (sAPCloseSessioncloseAttachedSession != null)
                {
                    if (sAPCloseSessioncloseAttachedSession != null)
                    {
                        sAPCloseSession["CloseAttachedSession"] = ExpressionConverter.ConvertO(sAPCloseSessioncloseAttachedSession);
                        sAPCloseSessionpropCount++;
                    }

                    sAPCloseSessionpropCount++;
                }
                else
                {
                    sAPCloseSession["CloseAttachedSession"] = true;
                    sAPCloseSessionpropCount++;
                }

                if (sAPCloseSessionsearchConnectionName != null)
                {
                    sAPCloseSession["SearchConnectionName"] = ExpressionConverter.ConvertO(sAPCloseSessionsearchConnectionName);
                    sAPCloseSessionpropCount++;
                }

                if (sAPCloseSessionsearchSessionName != null)
                {
                    sAPCloseSession["SearchSessionName"] = ExpressionConverter.ConvertO(sAPCloseSessionsearchSessionName);
                    sAPCloseSessionpropCount++;
                }

                sAPCloseSessionpropCount++;
                sAPCloseSession["Workflow"] = ExpressionConverter.ConvertO(sAPCloseSessionworkflow);
                if (sAPCloseSessionpropCount > 0)
                {
                    callPayload.Body = sAPCloseSession;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPGetAttachedSessionProperties))]
        public IBodyWorkflowAction<SAPGetAttachedSessionPropertiesResponse> SAPGetAttachedSessionProperties([WorkflowExpression] Func<string> sAPGetAttachedSessionPropertiesworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SAPGetAttachedSessionPropertiesResponse> __BuildSAPGetAttachedSessionProperties(WorkflowValue<string> sAPGetAttachedSessionPropertiesworkflow)
        {
            WorkflowValue.Validate(sAPGetAttachedSessionPropertiesworkflow, nameof(sAPGetAttachedSessionPropertiesworkflow), required: true);
            return new DeferredBodyAction<SAPGetAttachedSessionPropertiesResponse>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetAttachedSessionProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGetAttachedSessionProperties = new JObject();
                var sAPGetAttachedSessionPropertiespropCount = 0;
                sAPGetAttachedSessionPropertiespropCount++;
                sAPGetAttachedSessionProperties["Workflow"] = ExpressionConverter.ConvertO(sAPGetAttachedSessionPropertiesworkflow);
                if (sAPGetAttachedSessionPropertiespropCount > 0)
                {
                    callPayload.Body = sAPGetAttachedSessionProperties;
                }

                return new ApiConnectionAction<SAPGetAttachedSessionPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPWaitForAttachedSessionNotBusy))]
        public IBodyWorkflowAction<SAPWaitForAttachedSessionNotBusyResponse> SAPWaitForAttachedSessionNotBusy([WorkflowExpression] Func<double> sAPWaitForAttachedSessionNotBusysecondsToWait, [WorkflowExpression] Func<string> sAPWaitForAttachedSessionNotBusyworkflow, [WorkflowExpression] Func<bool> sAPWaitForAttachedSessionNotBusyraiseExceptionIfBusyAfterWait = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SAPWaitForAttachedSessionNotBusyResponse> __BuildSAPWaitForAttachedSessionNotBusy(WorkflowValue<double> sAPWaitForAttachedSessionNotBusysecondsToWait, WorkflowValue<string> sAPWaitForAttachedSessionNotBusyworkflow, WorkflowValue<bool> sAPWaitForAttachedSessionNotBusyraiseExceptionIfBusyAfterWait = null)
        {
            WorkflowValue.Validate(sAPWaitForAttachedSessionNotBusysecondsToWait, nameof(sAPWaitForAttachedSessionNotBusysecondsToWait), required: true);
            WorkflowValue.Validate(sAPWaitForAttachedSessionNotBusyworkflow, nameof(sAPWaitForAttachedSessionNotBusyworkflow), required: true);
            WorkflowValue.Validate(sAPWaitForAttachedSessionNotBusyraiseExceptionIfBusyAfterWait, nameof(sAPWaitForAttachedSessionNotBusyraiseExceptionIfBusyAfterWait), required: false);
            return new DeferredBodyAction<SAPWaitForAttachedSessionNotBusyResponse>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPWaitForAttachedSessionNotBusy";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPWaitForAttachedSessionNotBusy = new JObject();
                var sAPWaitForAttachedSessionNotBusypropCount = 0;
                sAPWaitForAttachedSessionNotBusypropCount++;
                sAPWaitForAttachedSessionNotBusy["SecondsToWait"] = ExpressionConverter.ConvertO(sAPWaitForAttachedSessionNotBusysecondsToWait);
                if (sAPWaitForAttachedSessionNotBusyraiseExceptionIfBusyAfterWait != null)
                {
                    if (sAPWaitForAttachedSessionNotBusyraiseExceptionIfBusyAfterWait != null)
                    {
                        sAPWaitForAttachedSessionNotBusy["RaiseExceptionIfBusyAfterWait"] = ExpressionConverter.ConvertO(sAPWaitForAttachedSessionNotBusyraiseExceptionIfBusyAfterWait);
                        sAPWaitForAttachedSessionNotBusypropCount++;
                    }

                    sAPWaitForAttachedSessionNotBusypropCount++;
                }
                else
                {
                    sAPWaitForAttachedSessionNotBusy["RaiseExceptionIfBusyAfterWait"] = false;
                    sAPWaitForAttachedSessionNotBusypropCount++;
                }

                sAPWaitForAttachedSessionNotBusypropCount++;
                sAPWaitForAttachedSessionNotBusy["Workflow"] = ExpressionConverter.ConvertO(sAPWaitForAttachedSessionNotBusyworkflow);
                if (sAPWaitForAttachedSessionNotBusypropCount > 0)
                {
                    callPayload.Body = sAPWaitForAttachedSessionNotBusy;
                }

                return new ApiConnectionAction<SAPWaitForAttachedSessionNotBusyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPInputTextIntoSAPElement))]
        public IWorkflowAction SAPInputTextIntoSAPElement([WorkflowExpression] Func<string> sAPInputTextIntoSAPElementsearchSAPElementId, [WorkflowExpression] Func<string> sAPInputTextIntoSAPElementworkflow, [WorkflowExpression] Func<string> sAPInputTextIntoSAPElementtextToInput = null, [WorkflowExpression] Func<bool> sAPInputTextIntoSAPElementreplaceExistingValue = null, [WorkflowExpression] Func<int> sAPInputTextIntoSAPElementinsertPosition = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSAPInputTextIntoSAPElement(WorkflowValue<string> sAPInputTextIntoSAPElementsearchSAPElementId, WorkflowValue<string> sAPInputTextIntoSAPElementworkflow, WorkflowValue<string> sAPInputTextIntoSAPElementtextToInput = null, WorkflowValue<bool> sAPInputTextIntoSAPElementreplaceExistingValue = null, WorkflowValue<int> sAPInputTextIntoSAPElementinsertPosition = null)
        {
            WorkflowValue.Validate(sAPInputTextIntoSAPElementsearchSAPElementId, nameof(sAPInputTextIntoSAPElementsearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPInputTextIntoSAPElementworkflow, nameof(sAPInputTextIntoSAPElementworkflow), required: true);
            WorkflowValue.Validate(sAPInputTextIntoSAPElementtextToInput, nameof(sAPInputTextIntoSAPElementtextToInput), required: false);
            WorkflowValue.Validate(sAPInputTextIntoSAPElementreplaceExistingValue, nameof(sAPInputTextIntoSAPElementreplaceExistingValue), required: false);
            WorkflowValue.Validate(sAPInputTextIntoSAPElementinsertPosition, nameof(sAPInputTextIntoSAPElementinsertPosition), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/SAPGUI/SAPInputTextIntoSAPElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPInputTextIntoSAPElement = new JObject();
                var sAPInputTextIntoSAPElementpropCount = 0;
                sAPInputTextIntoSAPElementpropCount++;
                sAPInputTextIntoSAPElement["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPInputTextIntoSAPElementsearchSAPElementId);
                if (sAPInputTextIntoSAPElementtextToInput != null)
                {
                    sAPInputTextIntoSAPElement["TextToInput"] = ExpressionConverter.ConvertO(sAPInputTextIntoSAPElementtextToInput);
                    sAPInputTextIntoSAPElementpropCount++;
                }

                if (sAPInputTextIntoSAPElementreplaceExistingValue != null)
                {
                    if (sAPInputTextIntoSAPElementreplaceExistingValue != null)
                    {
                        sAPInputTextIntoSAPElement["ReplaceExistingValue"] = ExpressionConverter.ConvertO(sAPInputTextIntoSAPElementreplaceExistingValue);
                        sAPInputTextIntoSAPElementpropCount++;
                    }

                    sAPInputTextIntoSAPElementpropCount++;
                }
                else
                {
                    sAPInputTextIntoSAPElement["ReplaceExistingValue"] = true;
                    sAPInputTextIntoSAPElementpropCount++;
                }

                if (sAPInputTextIntoSAPElementinsertPosition != null)
                {
                    if (sAPInputTextIntoSAPElementinsertPosition != null)
                    {
                        sAPInputTextIntoSAPElement["InsertPosition"] = ExpressionConverter.ConvertO(sAPInputTextIntoSAPElementinsertPosition);
                        sAPInputTextIntoSAPElementpropCount++;
                    }

                    sAPInputTextIntoSAPElementpropCount++;
                }
                else
                {
                    sAPInputTextIntoSAPElement["InsertPosition"] = 0;
                    sAPInputTextIntoSAPElementpropCount++;
                }

                sAPInputTextIntoSAPElementpropCount++;
                sAPInputTextIntoSAPElement["Workflow"] = ExpressionConverter.ConvertO(sAPInputTextIntoSAPElementworkflow);
                if (sAPInputTextIntoSAPElementpropCount > 0)
                {
                    callPayload.Body = sAPInputTextIntoSAPElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPInputPasswordIntoSAPElement))]
        public IWorkflowAction SAPInputPasswordIntoSAPElement([WorkflowExpression] Func<string> sAPInputPasswordIntoSAPElementsearchSAPElementId, [WorkflowExpression] Func<string> sAPInputPasswordIntoSAPElementpasswordToInput, [WorkflowExpression] Func<string> sAPInputPasswordIntoSAPElementworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSAPInputPasswordIntoSAPElement(WorkflowValue<string> sAPInputPasswordIntoSAPElementsearchSAPElementId, WorkflowValue<string> sAPInputPasswordIntoSAPElementpasswordToInput, WorkflowValue<string> sAPInputPasswordIntoSAPElementworkflow)
        {
            WorkflowValue.Validate(sAPInputPasswordIntoSAPElementsearchSAPElementId, nameof(sAPInputPasswordIntoSAPElementsearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPInputPasswordIntoSAPElementpasswordToInput, nameof(sAPInputPasswordIntoSAPElementpasswordToInput), required: true);
            WorkflowValue.Validate(sAPInputPasswordIntoSAPElementworkflow, nameof(sAPInputPasswordIntoSAPElementworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/SAPGUI/SAPInputPasswordIntoSAPElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPInputPasswordIntoSAPElement = new JObject();
                var sAPInputPasswordIntoSAPElementpropCount = 0;
                sAPInputPasswordIntoSAPElementpropCount++;
                sAPInputPasswordIntoSAPElement["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPInputPasswordIntoSAPElementsearchSAPElementId);
                sAPInputPasswordIntoSAPElementpropCount++;
                sAPInputPasswordIntoSAPElement["PasswordToInput"] = ExpressionConverter.ConvertO(sAPInputPasswordIntoSAPElementpasswordToInput);
                sAPInputPasswordIntoSAPElementpropCount++;
                sAPInputPasswordIntoSAPElement["Workflow"] = ExpressionConverter.ConvertO(sAPInputPasswordIntoSAPElementworkflow);
                if (sAPInputPasswordIntoSAPElementpropCount > 0)
                {
                    callPayload.Body = sAPInputPasswordIntoSAPElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPGetElementProperties))]
        public IBodyWorkflowAction<SAPGetElementPropertiesResponse> SAPGetElementProperties([WorkflowExpression] Func<string> sAPGetElementPropertiessearchSAPElementId, [WorkflowExpression] Func<string> sAPGetElementPropertiesworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SAPGetElementPropertiesResponse> __BuildSAPGetElementProperties(WorkflowValue<string> sAPGetElementPropertiessearchSAPElementId, WorkflowValue<string> sAPGetElementPropertiesworkflow)
        {
            WorkflowValue.Validate(sAPGetElementPropertiessearchSAPElementId, nameof(sAPGetElementPropertiessearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPGetElementPropertiesworkflow, nameof(sAPGetElementPropertiesworkflow), required: true);
            return new DeferredBodyAction<SAPGetElementPropertiesResponse>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetElementProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGetElementProperties = new JObject();
                var sAPGetElementPropertiespropCount = 0;
                sAPGetElementPropertiespropCount++;
                sAPGetElementProperties["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGetElementPropertiessearchSAPElementId);
                sAPGetElementPropertiespropCount++;
                sAPGetElementProperties["Workflow"] = ExpressionConverter.ConvertO(sAPGetElementPropertiesworkflow);
                if (sAPGetElementPropertiespropCount > 0)
                {
                    callPayload.Body = sAPGetElementProperties;
                }

                return new ApiConnectionAction<SAPGetElementPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPWaitForElementId))]
        public IBodyWorkflowAction<SAPWaitForElementIdResponse> SAPWaitForElementId([WorkflowExpression] Func<string> sAPWaitForElementIdsearchSAPElementId, [WorkflowExpression] Func<string> sAPWaitForElementIdworkflow, [WorkflowExpression] Func<double> sAPWaitForElementIdsecondsToWait = null, [WorkflowExpression] Func<bool> sAPWaitForElementIdraiseExceptionIfElementNotFound = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SAPWaitForElementIdResponse> __BuildSAPWaitForElementId(WorkflowValue<string> sAPWaitForElementIdsearchSAPElementId, WorkflowValue<string> sAPWaitForElementIdworkflow, WorkflowValue<double> sAPWaitForElementIdsecondsToWait = null, WorkflowValue<bool> sAPWaitForElementIdraiseExceptionIfElementNotFound = null)
        {
            WorkflowValue.Validate(sAPWaitForElementIdsearchSAPElementId, nameof(sAPWaitForElementIdsearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPWaitForElementIdworkflow, nameof(sAPWaitForElementIdworkflow), required: true);
            WorkflowValue.Validate(sAPWaitForElementIdsecondsToWait, nameof(sAPWaitForElementIdsecondsToWait), required: false);
            WorkflowValue.Validate(sAPWaitForElementIdraiseExceptionIfElementNotFound, nameof(sAPWaitForElementIdraiseExceptionIfElementNotFound), required: false);
            return new DeferredBodyAction<SAPWaitForElementIdResponse>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPWaitForElementId";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPWaitForElementId = new JObject();
                var sAPWaitForElementIdpropCount = 0;
                sAPWaitForElementIdpropCount++;
                sAPWaitForElementId["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPWaitForElementIdsearchSAPElementId);
                if (sAPWaitForElementIdsecondsToWait != null)
                {
                    if (sAPWaitForElementIdsecondsToWait != null)
                    {
                        sAPWaitForElementId["SecondsToWait"] = ExpressionConverter.ConvertO(sAPWaitForElementIdsecondsToWait);
                        sAPWaitForElementIdpropCount++;
                    }

                    sAPWaitForElementIdpropCount++;
                }
                else
                {
                    sAPWaitForElementId["SecondsToWait"] = 15;
                    sAPWaitForElementIdpropCount++;
                }

                if (sAPWaitForElementIdraiseExceptionIfElementNotFound != null)
                {
                    if (sAPWaitForElementIdraiseExceptionIfElementNotFound != null)
                    {
                        sAPWaitForElementId["RaiseExceptionIfElementNotFound"] = ExpressionConverter.ConvertO(sAPWaitForElementIdraiseExceptionIfElementNotFound);
                        sAPWaitForElementIdpropCount++;
                    }

                    sAPWaitForElementIdpropCount++;
                }
                else
                {
                    sAPWaitForElementId["RaiseExceptionIfElementNotFound"] = false;
                    sAPWaitForElementIdpropCount++;
                }

                sAPWaitForElementIdpropCount++;
                sAPWaitForElementId["Workflow"] = ExpressionConverter.ConvertO(sAPWaitForElementIdworkflow);
                if (sAPWaitForElementIdpropCount > 0)
                {
                    callPayload.Body = sAPWaitForElementId;
                }

                return new ApiConnectionAction<SAPWaitForElementIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPWaitForWindow))]
        public IBodyWorkflowAction<SAPWaitForWindowResponse> SAPWaitForWindow([WorkflowExpression] Func<string> sAPWaitForWindowsearchSAPWindowTitle, [WorkflowExpression] Func<string> sAPWaitForWindowworkflow, [WorkflowExpression] Func<bool> sAPWaitForWindowsearchIsRegularExpression = null, [WorkflowExpression] Func<bool> sAPWaitForWindowsearchIsCaseSensitive = null, [WorkflowExpression] Func<double> sAPWaitForWindowsecondsToWait = null, [WorkflowExpression] Func<bool> sAPWaitForWindowraiseExceptionIfElementNotFound = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SAPWaitForWindowResponse> __BuildSAPWaitForWindow(WorkflowValue<string> sAPWaitForWindowsearchSAPWindowTitle, WorkflowValue<string> sAPWaitForWindowworkflow, WorkflowValue<bool> sAPWaitForWindowsearchIsRegularExpression = null, WorkflowValue<bool> sAPWaitForWindowsearchIsCaseSensitive = null, WorkflowValue<double> sAPWaitForWindowsecondsToWait = null, WorkflowValue<bool> sAPWaitForWindowraiseExceptionIfElementNotFound = null)
        {
            WorkflowValue.Validate(sAPWaitForWindowsearchSAPWindowTitle, nameof(sAPWaitForWindowsearchSAPWindowTitle), required: true);
            WorkflowValue.Validate(sAPWaitForWindowworkflow, nameof(sAPWaitForWindowworkflow), required: true);
            WorkflowValue.Validate(sAPWaitForWindowsearchIsRegularExpression, nameof(sAPWaitForWindowsearchIsRegularExpression), required: false);
            WorkflowValue.Validate(sAPWaitForWindowsearchIsCaseSensitive, nameof(sAPWaitForWindowsearchIsCaseSensitive), required: false);
            WorkflowValue.Validate(sAPWaitForWindowsecondsToWait, nameof(sAPWaitForWindowsecondsToWait), required: false);
            WorkflowValue.Validate(sAPWaitForWindowraiseExceptionIfElementNotFound, nameof(sAPWaitForWindowraiseExceptionIfElementNotFound), required: false);
            return new DeferredBodyAction<SAPWaitForWindowResponse>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPWaitForWindow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPWaitForWindow = new JObject();
                var sAPWaitForWindowpropCount = 0;
                sAPWaitForWindowpropCount++;
                sAPWaitForWindow["SearchSAPWindowTitle"] = ExpressionConverter.ConvertO(sAPWaitForWindowsearchSAPWindowTitle);
                if (sAPWaitForWindowsearchIsRegularExpression != null)
                {
                    if (sAPWaitForWindowsearchIsRegularExpression != null)
                    {
                        sAPWaitForWindow["SearchIsRegularExpression"] = ExpressionConverter.ConvertO(sAPWaitForWindowsearchIsRegularExpression);
                        sAPWaitForWindowpropCount++;
                    }

                    sAPWaitForWindowpropCount++;
                }
                else
                {
                    sAPWaitForWindow["SearchIsRegularExpression"] = false;
                    sAPWaitForWindowpropCount++;
                }

                if (sAPWaitForWindowsearchIsCaseSensitive != null)
                {
                    if (sAPWaitForWindowsearchIsCaseSensitive != null)
                    {
                        sAPWaitForWindow["SearchIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPWaitForWindowsearchIsCaseSensitive);
                        sAPWaitForWindowpropCount++;
                    }

                    sAPWaitForWindowpropCount++;
                }
                else
                {
                    sAPWaitForWindow["SearchIsCaseSensitive"] = false;
                    sAPWaitForWindowpropCount++;
                }

                if (sAPWaitForWindowsecondsToWait != null)
                {
                    if (sAPWaitForWindowsecondsToWait != null)
                    {
                        sAPWaitForWindow["SecondsToWait"] = ExpressionConverter.ConvertO(sAPWaitForWindowsecondsToWait);
                        sAPWaitForWindowpropCount++;
                    }

                    sAPWaitForWindowpropCount++;
                }
                else
                {
                    sAPWaitForWindow["SecondsToWait"] = 15;
                    sAPWaitForWindowpropCount++;
                }

                if (sAPWaitForWindowraiseExceptionIfElementNotFound != null)
                {
                    if (sAPWaitForWindowraiseExceptionIfElementNotFound != null)
                    {
                        sAPWaitForWindow["RaiseExceptionIfElementNotFound"] = ExpressionConverter.ConvertO(sAPWaitForWindowraiseExceptionIfElementNotFound);
                        sAPWaitForWindowpropCount++;
                    }

                    sAPWaitForWindowpropCount++;
                }
                else
                {
                    sAPWaitForWindow["RaiseExceptionIfElementNotFound"] = false;
                    sAPWaitForWindowpropCount++;
                }

                sAPWaitForWindowpropCount++;
                sAPWaitForWindow["Workflow"] = ExpressionConverter.ConvertO(sAPWaitForWindowworkflow);
                if (sAPWaitForWindowpropCount > 0)
                {
                    callPayload.Body = sAPWaitForWindow;
                }

                return new ApiConnectionAction<SAPWaitForWindowResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPGetElementTextValue))]
        public IBodyWorkflowAction<SAPGetElementTextValueResponse> SAPGetElementTextValue([WorkflowExpression] Func<string> sAPGetElementTextValuesearchSAPElementId, [WorkflowExpression] Func<string> sAPGetElementTextValueworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SAPGetElementTextValueResponse> __BuildSAPGetElementTextValue(WorkflowValue<string> sAPGetElementTextValuesearchSAPElementId, WorkflowValue<string> sAPGetElementTextValueworkflow)
        {
            WorkflowValue.Validate(sAPGetElementTextValuesearchSAPElementId, nameof(sAPGetElementTextValuesearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPGetElementTextValueworkflow, nameof(sAPGetElementTextValueworkflow), required: true);
            return new DeferredBodyAction<SAPGetElementTextValueResponse>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetElementTextValue";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGetElementTextValue = new JObject();
                var sAPGetElementTextValuepropCount = 0;
                sAPGetElementTextValuepropCount++;
                sAPGetElementTextValue["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGetElementTextValuesearchSAPElementId);
                sAPGetElementTextValuepropCount++;
                sAPGetElementTextValue["Workflow"] = ExpressionConverter.ConvertO(sAPGetElementTextValueworkflow);
                if (sAPGetElementTextValuepropCount > 0)
                {
                    callPayload.Body = sAPGetElementTextValue;
                }

                return new ApiConnectionAction<SAPGetElementTextValueResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPPressSAPElement))]
        public IWorkflowAction SAPPressSAPElement([WorkflowExpression] Func<string> sAPPressSAPElementsearchSAPElementId, [WorkflowExpression] Func<string> sAPPressSAPElementworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSAPPressSAPElement(WorkflowValue<string> sAPPressSAPElementsearchSAPElementId, WorkflowValue<string> sAPPressSAPElementworkflow)
        {
            WorkflowValue.Validate(sAPPressSAPElementsearchSAPElementId, nameof(sAPPressSAPElementsearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPPressSAPElementworkflow, nameof(sAPPressSAPElementworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/SAPGUI/SAPPressSAPElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPPressSAPElement = new JObject();
                var sAPPressSAPElementpropCount = 0;
                sAPPressSAPElementpropCount++;
                sAPPressSAPElement["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPPressSAPElementsearchSAPElementId);
                sAPPressSAPElementpropCount++;
                sAPPressSAPElement["Workflow"] = ExpressionConverter.ConvertO(sAPPressSAPElementworkflow);
                if (sAPPressSAPElementpropCount > 0)
                {
                    callPayload.Body = sAPPressSAPElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPSelectSAPElement))]
        public IWorkflowAction SAPSelectSAPElement([WorkflowExpression] Func<string> sAPSelectSAPElementsearchSAPElementId, [WorkflowExpression] Func<string> sAPSelectSAPElementworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSAPSelectSAPElement(WorkflowValue<string> sAPSelectSAPElementsearchSAPElementId, WorkflowValue<string> sAPSelectSAPElementworkflow)
        {
            WorkflowValue.Validate(sAPSelectSAPElementsearchSAPElementId, nameof(sAPSelectSAPElementsearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPSelectSAPElementworkflow, nameof(sAPSelectSAPElementworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSelectSAPElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPSelectSAPElement = new JObject();
                var sAPSelectSAPElementpropCount = 0;
                sAPSelectSAPElementpropCount++;
                sAPSelectSAPElement["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPSelectSAPElementsearchSAPElementId);
                sAPSelectSAPElementpropCount++;
                sAPSelectSAPElement["Workflow"] = ExpressionConverter.ConvertO(sAPSelectSAPElementworkflow);
                if (sAPSelectSAPElementpropCount > 0)
                {
                    callPayload.Body = sAPSelectSAPElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPFocusSAPElement))]
        public IWorkflowAction SAPFocusSAPElement([WorkflowExpression] Func<string> sAPFocusSAPElementsearchSAPElementId, [WorkflowExpression] Func<string> sAPFocusSAPElementworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSAPFocusSAPElement(WorkflowValue<string> sAPFocusSAPElementsearchSAPElementId, WorkflowValue<string> sAPFocusSAPElementworkflow)
        {
            WorkflowValue.Validate(sAPFocusSAPElementsearchSAPElementId, nameof(sAPFocusSAPElementsearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPFocusSAPElementworkflow, nameof(sAPFocusSAPElementworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/SAPGUI/SAPFocusSAPElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPFocusSAPElement = new JObject();
                var sAPFocusSAPElementpropCount = 0;
                sAPFocusSAPElementpropCount++;
                sAPFocusSAPElement["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPFocusSAPElementsearchSAPElementId);
                sAPFocusSAPElementpropCount++;
                sAPFocusSAPElement["Workflow"] = ExpressionConverter.ConvertO(sAPFocusSAPElementworkflow);
                if (sAPFocusSAPElementpropCount > 0)
                {
                    callPayload.Body = sAPFocusSAPElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPCheckSAPElement))]
        public IWorkflowAction SAPCheckSAPElement([WorkflowExpression] Func<string> sAPCheckSAPElementsearchSAPElementId, [WorkflowExpression] Func<string> sAPCheckSAPElementworkflow, [WorkflowExpression] Func<bool> sAPCheckSAPElementcheckElement = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSAPCheckSAPElement(WorkflowValue<string> sAPCheckSAPElementsearchSAPElementId, WorkflowValue<string> sAPCheckSAPElementworkflow, WorkflowValue<bool> sAPCheckSAPElementcheckElement = null)
        {
            WorkflowValue.Validate(sAPCheckSAPElementsearchSAPElementId, nameof(sAPCheckSAPElementsearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPCheckSAPElementworkflow, nameof(sAPCheckSAPElementworkflow), required: true);
            WorkflowValue.Validate(sAPCheckSAPElementcheckElement, nameof(sAPCheckSAPElementcheckElement), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/SAPGUI/SAPCheckSAPElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPCheckSAPElement = new JObject();
                var sAPCheckSAPElementpropCount = 0;
                sAPCheckSAPElementpropCount++;
                sAPCheckSAPElement["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPCheckSAPElementsearchSAPElementId);
                if (sAPCheckSAPElementcheckElement != null)
                {
                    if (sAPCheckSAPElementcheckElement != null)
                    {
                        sAPCheckSAPElement["CheckElement"] = ExpressionConverter.ConvertO(sAPCheckSAPElementcheckElement);
                        sAPCheckSAPElementpropCount++;
                    }

                    sAPCheckSAPElementpropCount++;
                }
                else
                {
                    sAPCheckSAPElement["CheckElement"] = true;
                    sAPCheckSAPElementpropCount++;
                }

                sAPCheckSAPElementpropCount++;
                sAPCheckSAPElement["Workflow"] = ExpressionConverter.ConvertO(sAPCheckSAPElementworkflow);
                if (sAPCheckSAPElementpropCount > 0)
                {
                    callPayload.Body = sAPCheckSAPElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPVisualiseSAPElement))]
        public IWorkflowAction SAPVisualiseSAPElement([WorkflowExpression] Func<string> sAPVisualiseSAPElementsearchSAPElementId, [WorkflowExpression] Func<string> sAPVisualiseSAPElementworkflow, [WorkflowExpression] Func<bool> sAPVisualiseSAPElementvisualiseOn = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSAPVisualiseSAPElement(WorkflowValue<string> sAPVisualiseSAPElementsearchSAPElementId, WorkflowValue<string> sAPVisualiseSAPElementworkflow, WorkflowValue<bool> sAPVisualiseSAPElementvisualiseOn = null)
        {
            WorkflowValue.Validate(sAPVisualiseSAPElementsearchSAPElementId, nameof(sAPVisualiseSAPElementsearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPVisualiseSAPElementworkflow, nameof(sAPVisualiseSAPElementworkflow), required: true);
            WorkflowValue.Validate(sAPVisualiseSAPElementvisualiseOn, nameof(sAPVisualiseSAPElementvisualiseOn), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/SAPGUI/SAPVisualiseSAPElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPVisualiseSAPElement = new JObject();
                var sAPVisualiseSAPElementpropCount = 0;
                sAPVisualiseSAPElementpropCount++;
                sAPVisualiseSAPElement["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPVisualiseSAPElementsearchSAPElementId);
                if (sAPVisualiseSAPElementvisualiseOn != null)
                {
                    if (sAPVisualiseSAPElementvisualiseOn != null)
                    {
                        sAPVisualiseSAPElement["VisualiseOn"] = ExpressionConverter.ConvertO(sAPVisualiseSAPElementvisualiseOn);
                        sAPVisualiseSAPElementpropCount++;
                    }

                    sAPVisualiseSAPElementpropCount++;
                }
                else
                {
                    sAPVisualiseSAPElement["VisualiseOn"] = true;
                    sAPVisualiseSAPElementpropCount++;
                }

                sAPVisualiseSAPElementpropCount++;
                sAPVisualiseSAPElement["Workflow"] = ExpressionConverter.ConvertO(sAPVisualiseSAPElementworkflow);
                if (sAPVisualiseSAPElementpropCount > 0)
                {
                    callPayload.Body = sAPVisualiseSAPElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPDrawRectangleAroundSAPElement))]
        public IWorkflowAction SAPDrawRectangleAroundSAPElement([WorkflowExpression] Func<string> sAPDrawRectangleAroundSAPElementsearchSAPElementId, [WorkflowExpression] Func<string> sAPDrawRectangleAroundSAPElementworkflow, [WorkflowExpression] Func<string> sAPDrawRectangleAroundSAPElementpenColour = null, [WorkflowExpression] Func<int> sAPDrawRectangleAroundSAPElementpenThicknessPixels = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSAPDrawRectangleAroundSAPElement(WorkflowValue<string> sAPDrawRectangleAroundSAPElementsearchSAPElementId, WorkflowValue<string> sAPDrawRectangleAroundSAPElementworkflow, WorkflowValue<string> sAPDrawRectangleAroundSAPElementpenColour = null, WorkflowValue<int> sAPDrawRectangleAroundSAPElementpenThicknessPixels = null)
        {
            WorkflowValue.Validate(sAPDrawRectangleAroundSAPElementsearchSAPElementId, nameof(sAPDrawRectangleAroundSAPElementsearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPDrawRectangleAroundSAPElementworkflow, nameof(sAPDrawRectangleAroundSAPElementworkflow), required: true);
            WorkflowValue.Validate(sAPDrawRectangleAroundSAPElementpenColour, nameof(sAPDrawRectangleAroundSAPElementpenColour), required: false);
            WorkflowValue.Validate(sAPDrawRectangleAroundSAPElementpenThicknessPixels, nameof(sAPDrawRectangleAroundSAPElementpenThicknessPixels), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/SAPGUI/SAPDrawRectangleAroundSAPElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPDrawRectangleAroundSAPElement = new JObject();
                var sAPDrawRectangleAroundSAPElementpropCount = 0;
                sAPDrawRectangleAroundSAPElementpropCount++;
                sAPDrawRectangleAroundSAPElement["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPDrawRectangleAroundSAPElementsearchSAPElementId);
                if (sAPDrawRectangleAroundSAPElementpenColour != null)
                {
                    if (sAPDrawRectangleAroundSAPElementpenColour != null)
                    {
                        sAPDrawRectangleAroundSAPElement["PenColour"] = ExpressionConverter.ConvertO(sAPDrawRectangleAroundSAPElementpenColour);
                        sAPDrawRectangleAroundSAPElementpropCount++;
                    }

                    sAPDrawRectangleAroundSAPElementpropCount++;
                }
                else
                {
                    sAPDrawRectangleAroundSAPElement["PenColour"] = "#009FDE";
                    sAPDrawRectangleAroundSAPElementpropCount++;
                }

                if (sAPDrawRectangleAroundSAPElementpenThicknessPixels != null)
                {
                    if (sAPDrawRectangleAroundSAPElementpenThicknessPixels != null)
                    {
                        sAPDrawRectangleAroundSAPElement["PenThicknessPixels"] = ExpressionConverter.ConvertO(sAPDrawRectangleAroundSAPElementpenThicknessPixels);
                        sAPDrawRectangleAroundSAPElementpropCount++;
                    }

                    sAPDrawRectangleAroundSAPElementpropCount++;
                }
                else
                {
                    sAPDrawRectangleAroundSAPElement["PenThicknessPixels"] = 4;
                    sAPDrawRectangleAroundSAPElementpropCount++;
                }

                sAPDrawRectangleAroundSAPElementpropCount++;
                sAPDrawRectangleAroundSAPElement["Workflow"] = ExpressionConverter.ConvertO(sAPDrawRectangleAroundSAPElementworkflow);
                if (sAPDrawRectangleAroundSAPElementpropCount > 0)
                {
                    callPayload.Body = sAPDrawRectangleAroundSAPElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPSendCommand))]
        public IWorkflowAction SAPSendCommand([WorkflowExpression] Func<string> sAPSendCommandsAPCommand, [WorkflowExpression] Func<string> sAPSendCommandworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSAPSendCommand(WorkflowValue<string> sAPSendCommandsAPCommand, WorkflowValue<string> sAPSendCommandworkflow)
        {
            WorkflowValue.Validate(sAPSendCommandsAPCommand, nameof(sAPSendCommandsAPCommand), required: true);
            WorkflowValue.Validate(sAPSendCommandworkflow, nameof(sAPSendCommandworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSendCommand";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPSendCommand = new JObject();
                var sAPSendCommandpropCount = 0;
                sAPSendCommandpropCount++;
                sAPSendCommand["SAPCommand"] = ExpressionConverter.ConvertO(sAPSendCommandsAPCommand);
                sAPSendCommandpropCount++;
                sAPSendCommand["Workflow"] = ExpressionConverter.ConvertO(sAPSendCommandworkflow);
                if (sAPSendCommandpropCount > 0)
                {
                    callPayload.Body = sAPSendCommand;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPEnterTCode))]
        public IWorkflowAction SAPEnterTCode([WorkflowExpression] Func<string> sAPEnterTCodesAPTCode, [WorkflowExpression] Func<string> sAPEnterTCodeworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSAPEnterTCode(WorkflowValue<string> sAPEnterTCodesAPTCode, WorkflowValue<string> sAPEnterTCodeworkflow)
        {
            WorkflowValue.Validate(sAPEnterTCodesAPTCode, nameof(sAPEnterTCodesAPTCode), required: true);
            WorkflowValue.Validate(sAPEnterTCodeworkflow, nameof(sAPEnterTCodeworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/SAPGUI/SAPEnterTCode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPEnterTCode = new JObject();
                var sAPEnterTCodepropCount = 0;
                sAPEnterTCodepropCount++;
                sAPEnterTCode["SAPTCode"] = ExpressionConverter.ConvertO(sAPEnterTCodesAPTCode);
                sAPEnterTCodepropCount++;
                sAPEnterTCode["Workflow"] = ExpressionConverter.ConvertO(sAPEnterTCodeworkflow);
                if (sAPEnterTCodepropCount > 0)
                {
                    callPayload.Body = sAPEnterTCode;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPSendVKey))]
        public IWorkflowAction SAPSendVKey([WorkflowExpression] Func<string> sAPSendVKeysearchSAPElementId, [WorkflowExpression] Func<int> sAPSendVKeysAPVKey, [WorkflowExpression] Func<string> sAPSendVKeyworkflow, [WorkflowExpression] Func<bool> sAPSendVKeydetectParentWindowElement = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSAPSendVKey(WorkflowValue<string> sAPSendVKeysearchSAPElementId, WorkflowValue<int> sAPSendVKeysAPVKey, WorkflowValue<string> sAPSendVKeyworkflow, WorkflowValue<bool> sAPSendVKeydetectParentWindowElement = null)
        {
            WorkflowValue.Validate(sAPSendVKeysearchSAPElementId, nameof(sAPSendVKeysearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPSendVKeysAPVKey, nameof(sAPSendVKeysAPVKey), required: true);
            WorkflowValue.Validate(sAPSendVKeyworkflow, nameof(sAPSendVKeyworkflow), required: true);
            WorkflowValue.Validate(sAPSendVKeydetectParentWindowElement, nameof(sAPSendVKeydetectParentWindowElement), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSendVKey";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPSendVKey = new JObject();
                var sAPSendVKeypropCount = 0;
                sAPSendVKeypropCount++;
                sAPSendVKey["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPSendVKeysearchSAPElementId);
                sAPSendVKeypropCount++;
                sAPSendVKey["SAPVKey"] = ExpressionConverter.ConvertO(sAPSendVKeysAPVKey);
                if (sAPSendVKeydetectParentWindowElement != null)
                {
                    if (sAPSendVKeydetectParentWindowElement != null)
                    {
                        sAPSendVKey["DetectParentWindowElement"] = ExpressionConverter.ConvertO(sAPSendVKeydetectParentWindowElement);
                        sAPSendVKeypropCount++;
                    }

                    sAPSendVKeypropCount++;
                }
                else
                {
                    sAPSendVKey["DetectParentWindowElement"] = true;
                    sAPSendVKeypropCount++;
                }

                sAPSendVKeypropCount++;
                sAPSendVKey["Workflow"] = ExpressionConverter.ConvertO(sAPSendVKeyworkflow);
                if (sAPSendVKeypropCount > 0)
                {
                    callPayload.Body = sAPSendVKey;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPSendEnterVKey))]
        public IWorkflowAction SAPSendEnterVKey([WorkflowExpression] Func<string> sAPSendEnterVKeysearchSAPElementId, [WorkflowExpression] Func<string> sAPSendEnterVKeyworkflow, [WorkflowExpression] Func<bool> sAPSendEnterVKeydetectParentWindowElement = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSAPSendEnterVKey(WorkflowValue<string> sAPSendEnterVKeysearchSAPElementId, WorkflowValue<string> sAPSendEnterVKeyworkflow, WorkflowValue<bool> sAPSendEnterVKeydetectParentWindowElement = null)
        {
            WorkflowValue.Validate(sAPSendEnterVKeysearchSAPElementId, nameof(sAPSendEnterVKeysearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPSendEnterVKeyworkflow, nameof(sAPSendEnterVKeyworkflow), required: true);
            WorkflowValue.Validate(sAPSendEnterVKeydetectParentWindowElement, nameof(sAPSendEnterVKeydetectParentWindowElement), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSendEnterVKey";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPSendEnterVKey = new JObject();
                var sAPSendEnterVKeypropCount = 0;
                sAPSendEnterVKeypropCount++;
                sAPSendEnterVKey["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPSendEnterVKeysearchSAPElementId);
                if (sAPSendEnterVKeydetectParentWindowElement != null)
                {
                    if (sAPSendEnterVKeydetectParentWindowElement != null)
                    {
                        sAPSendEnterVKey["DetectParentWindowElement"] = ExpressionConverter.ConvertO(sAPSendEnterVKeydetectParentWindowElement);
                        sAPSendEnterVKeypropCount++;
                    }

                    sAPSendEnterVKeypropCount++;
                }
                else
                {
                    sAPSendEnterVKey["DetectParentWindowElement"] = true;
                    sAPSendEnterVKeypropCount++;
                }

                sAPSendEnterVKeypropCount++;
                sAPSendEnterVKey["Workflow"] = ExpressionConverter.ConvertO(sAPSendEnterVKeyworkflow);
                if (sAPSendEnterVKeypropCount > 0)
                {
                    callPayload.Body = sAPSendEnterVKey;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPWindowRestore))]
        public IWorkflowAction SAPWindowRestore([WorkflowExpression] Func<string> sAPWindowRestoresearchSAPElementId, [WorkflowExpression] Func<string> sAPWindowRestoreworkflow, [WorkflowExpression] Func<bool> sAPWindowRestoredetectParentWindowElement = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSAPWindowRestore(WorkflowValue<string> sAPWindowRestoresearchSAPElementId, WorkflowValue<string> sAPWindowRestoreworkflow, WorkflowValue<bool> sAPWindowRestoredetectParentWindowElement = null)
        {
            WorkflowValue.Validate(sAPWindowRestoresearchSAPElementId, nameof(sAPWindowRestoresearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPWindowRestoreworkflow, nameof(sAPWindowRestoreworkflow), required: true);
            WorkflowValue.Validate(sAPWindowRestoredetectParentWindowElement, nameof(sAPWindowRestoredetectParentWindowElement), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/SAPGUI/SAPWindowRestore";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPWindowRestore = new JObject();
                var sAPWindowRestorepropCount = 0;
                sAPWindowRestorepropCount++;
                sAPWindowRestore["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPWindowRestoresearchSAPElementId);
                if (sAPWindowRestoredetectParentWindowElement != null)
                {
                    if (sAPWindowRestoredetectParentWindowElement != null)
                    {
                        sAPWindowRestore["DetectParentWindowElement"] = ExpressionConverter.ConvertO(sAPWindowRestoredetectParentWindowElement);
                        sAPWindowRestorepropCount++;
                    }

                    sAPWindowRestorepropCount++;
                }
                else
                {
                    sAPWindowRestore["DetectParentWindowElement"] = true;
                    sAPWindowRestorepropCount++;
                }

                sAPWindowRestorepropCount++;
                sAPWindowRestore["Workflow"] = ExpressionConverter.ConvertO(sAPWindowRestoreworkflow);
                if (sAPWindowRestorepropCount > 0)
                {
                    callPayload.Body = sAPWindowRestore;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPWindowMaximise))]
        public IWorkflowAction SAPWindowMaximise([WorkflowExpression] Func<string> sAPWindowMaximisesearchSAPElementId, [WorkflowExpression] Func<string> sAPWindowMaximiseworkflow, [WorkflowExpression] Func<bool> sAPWindowMaximisedetectParentWindowElement = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSAPWindowMaximise(WorkflowValue<string> sAPWindowMaximisesearchSAPElementId, WorkflowValue<string> sAPWindowMaximiseworkflow, WorkflowValue<bool> sAPWindowMaximisedetectParentWindowElement = null)
        {
            WorkflowValue.Validate(sAPWindowMaximisesearchSAPElementId, nameof(sAPWindowMaximisesearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPWindowMaximiseworkflow, nameof(sAPWindowMaximiseworkflow), required: true);
            WorkflowValue.Validate(sAPWindowMaximisedetectParentWindowElement, nameof(sAPWindowMaximisedetectParentWindowElement), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/SAPGUI/SAPWindowMaximise";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPWindowMaximise = new JObject();
                var sAPWindowMaximisepropCount = 0;
                sAPWindowMaximisepropCount++;
                sAPWindowMaximise["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPWindowMaximisesearchSAPElementId);
                if (sAPWindowMaximisedetectParentWindowElement != null)
                {
                    if (sAPWindowMaximisedetectParentWindowElement != null)
                    {
                        sAPWindowMaximise["DetectParentWindowElement"] = ExpressionConverter.ConvertO(sAPWindowMaximisedetectParentWindowElement);
                        sAPWindowMaximisepropCount++;
                    }

                    sAPWindowMaximisepropCount++;
                }
                else
                {
                    sAPWindowMaximise["DetectParentWindowElement"] = true;
                    sAPWindowMaximisepropCount++;
                }

                sAPWindowMaximisepropCount++;
                sAPWindowMaximise["Workflow"] = ExpressionConverter.ConvertO(sAPWindowMaximiseworkflow);
                if (sAPWindowMaximisepropCount > 0)
                {
                    callPayload.Body = sAPWindowMaximise;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPWindowMinimise))]
        public IWorkflowAction SAPWindowMinimise([WorkflowExpression] Func<string> sAPWindowMinimisesearchSAPElementId, [WorkflowExpression] Func<string> sAPWindowMinimiseworkflow, [WorkflowExpression] Func<bool> sAPWindowMinimisedetectParentWindowElement = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSAPWindowMinimise(WorkflowValue<string> sAPWindowMinimisesearchSAPElementId, WorkflowValue<string> sAPWindowMinimiseworkflow, WorkflowValue<bool> sAPWindowMinimisedetectParentWindowElement = null)
        {
            WorkflowValue.Validate(sAPWindowMinimisesearchSAPElementId, nameof(sAPWindowMinimisesearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPWindowMinimiseworkflow, nameof(sAPWindowMinimiseworkflow), required: true);
            WorkflowValue.Validate(sAPWindowMinimisedetectParentWindowElement, nameof(sAPWindowMinimisedetectParentWindowElement), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/SAPGUI/SAPWindowMinimise";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPWindowMinimise = new JObject();
                var sAPWindowMinimisepropCount = 0;
                sAPWindowMinimisepropCount++;
                sAPWindowMinimise["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPWindowMinimisesearchSAPElementId);
                if (sAPWindowMinimisedetectParentWindowElement != null)
                {
                    if (sAPWindowMinimisedetectParentWindowElement != null)
                    {
                        sAPWindowMinimise["DetectParentWindowElement"] = ExpressionConverter.ConvertO(sAPWindowMinimisedetectParentWindowElement);
                        sAPWindowMinimisepropCount++;
                    }

                    sAPWindowMinimisepropCount++;
                }
                else
                {
                    sAPWindowMinimise["DetectParentWindowElement"] = true;
                    sAPWindowMinimisepropCount++;
                }

                sAPWindowMinimisepropCount++;
                sAPWindowMinimise["Workflow"] = ExpressionConverter.ConvertO(sAPWindowMinimiseworkflow);
                if (sAPWindowMinimisepropCount > 0)
                {
                    callPayload.Body = sAPWindowMinimise;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPWindowClose))]
        public IWorkflowAction SAPWindowClose([WorkflowExpression] Func<string> sAPWindowClosesearchSAPElementId, [WorkflowExpression] Func<string> sAPWindowCloseworkflow, [WorkflowExpression] Func<bool> sAPWindowClosedetectParentWindowElement = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSAPWindowClose(WorkflowValue<string> sAPWindowClosesearchSAPElementId, WorkflowValue<string> sAPWindowCloseworkflow, WorkflowValue<bool> sAPWindowClosedetectParentWindowElement = null)
        {
            WorkflowValue.Validate(sAPWindowClosesearchSAPElementId, nameof(sAPWindowClosesearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPWindowCloseworkflow, nameof(sAPWindowCloseworkflow), required: true);
            WorkflowValue.Validate(sAPWindowClosedetectParentWindowElement, nameof(sAPWindowClosedetectParentWindowElement), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/SAPGUI/SAPWindowClose";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPWindowClose = new JObject();
                var sAPWindowClosepropCount = 0;
                sAPWindowClosepropCount++;
                sAPWindowClose["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPWindowClosesearchSAPElementId);
                if (sAPWindowClosedetectParentWindowElement != null)
                {
                    if (sAPWindowClosedetectParentWindowElement != null)
                    {
                        sAPWindowClose["DetectParentWindowElement"] = ExpressionConverter.ConvertO(sAPWindowClosedetectParentWindowElement);
                        sAPWindowClosepropCount++;
                    }

                    sAPWindowClosepropCount++;
                }
                else
                {
                    sAPWindowClose["DetectParentWindowElement"] = true;
                    sAPWindowClosepropCount++;
                }

                sAPWindowClosepropCount++;
                sAPWindowClose["Workflow"] = ExpressionConverter.ConvertO(sAPWindowCloseworkflow);
                if (sAPWindowClosepropCount > 0)
                {
                    callPayload.Body = sAPWindowClose;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPBringWindowToFront))]
        public IWorkflowAction SAPBringWindowToFront([WorkflowExpression] Func<string> sAPBringWindowToFrontsearchSAPElementId, [WorkflowExpression] Func<string> sAPBringWindowToFrontworkflow, [WorkflowExpression] Func<bool> sAPBringWindowToFronttoggleWindow = null, [WorkflowExpression] Func<bool> sAPBringWindowToFronttoggleUsesGlobalLeftMouseClickAgent = null, [WorkflowExpression] Func<double> sAPBringWindowToFronttoggleDelay = null, [WorkflowExpression] Func<bool> sAPBringWindowToFrontdetectParentWindowElement = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSAPBringWindowToFront(WorkflowValue<string> sAPBringWindowToFrontsearchSAPElementId, WorkflowValue<string> sAPBringWindowToFrontworkflow, WorkflowValue<bool> sAPBringWindowToFronttoggleWindow = null, WorkflowValue<bool> sAPBringWindowToFronttoggleUsesGlobalLeftMouseClickAgent = null, WorkflowValue<double> sAPBringWindowToFronttoggleDelay = null, WorkflowValue<bool> sAPBringWindowToFrontdetectParentWindowElement = null)
        {
            WorkflowValue.Validate(sAPBringWindowToFrontsearchSAPElementId, nameof(sAPBringWindowToFrontsearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPBringWindowToFrontworkflow, nameof(sAPBringWindowToFrontworkflow), required: true);
            WorkflowValue.Validate(sAPBringWindowToFronttoggleWindow, nameof(sAPBringWindowToFronttoggleWindow), required: false);
            WorkflowValue.Validate(sAPBringWindowToFronttoggleUsesGlobalLeftMouseClickAgent, nameof(sAPBringWindowToFronttoggleUsesGlobalLeftMouseClickAgent), required: false);
            WorkflowValue.Validate(sAPBringWindowToFronttoggleDelay, nameof(sAPBringWindowToFronttoggleDelay), required: false);
            WorkflowValue.Validate(sAPBringWindowToFrontdetectParentWindowElement, nameof(sAPBringWindowToFrontdetectParentWindowElement), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/SAPGUI/SAPBringWindowToFront";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPBringWindowToFront = new JObject();
                var sAPBringWindowToFrontpropCount = 0;
                sAPBringWindowToFrontpropCount++;
                sAPBringWindowToFront["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPBringWindowToFrontsearchSAPElementId);
                if (sAPBringWindowToFronttoggleWindow != null)
                {
                    if (sAPBringWindowToFronttoggleWindow != null)
                    {
                        sAPBringWindowToFront["ToggleWindow"] = ExpressionConverter.ConvertO(sAPBringWindowToFronttoggleWindow);
                        sAPBringWindowToFrontpropCount++;
                    }

                    sAPBringWindowToFrontpropCount++;
                }
                else
                {
                    sAPBringWindowToFront["ToggleWindow"] = true;
                    sAPBringWindowToFrontpropCount++;
                }

                if (sAPBringWindowToFronttoggleUsesGlobalLeftMouseClickAgent != null)
                {
                    if (sAPBringWindowToFronttoggleUsesGlobalLeftMouseClickAgent != null)
                    {
                        sAPBringWindowToFront["ToggleUsesGlobalLeftMouseClickAgent"] = ExpressionConverter.ConvertO(sAPBringWindowToFronttoggleUsesGlobalLeftMouseClickAgent);
                        sAPBringWindowToFrontpropCount++;
                    }

                    sAPBringWindowToFrontpropCount++;
                }
                else
                {
                    sAPBringWindowToFront["ToggleUsesGlobalLeftMouseClickAgent"] = true;
                    sAPBringWindowToFrontpropCount++;
                }

                if (sAPBringWindowToFronttoggleDelay != null)
                {
                    if (sAPBringWindowToFronttoggleDelay != null)
                    {
                        sAPBringWindowToFront["ToggleDelay"] = ExpressionConverter.ConvertO(sAPBringWindowToFronttoggleDelay);
                        sAPBringWindowToFrontpropCount++;
                    }

                    sAPBringWindowToFrontpropCount++;
                }
                else
                {
                    sAPBringWindowToFront["ToggleDelay"] = 0.5;
                    sAPBringWindowToFrontpropCount++;
                }

                if (sAPBringWindowToFrontdetectParentWindowElement != null)
                {
                    if (sAPBringWindowToFrontdetectParentWindowElement != null)
                    {
                        sAPBringWindowToFront["DetectParentWindowElement"] = ExpressionConverter.ConvertO(sAPBringWindowToFrontdetectParentWindowElement);
                        sAPBringWindowToFrontpropCount++;
                    }

                    sAPBringWindowToFrontpropCount++;
                }
                else
                {
                    sAPBringWindowToFront["DetectParentWindowElement"] = true;
                    sAPBringWindowToFrontpropCount++;
                }

                sAPBringWindowToFrontpropCount++;
                sAPBringWindowToFront["Workflow"] = ExpressionConverter.ConvertO(sAPBringWindowToFrontworkflow);
                if (sAPBringWindowToFrontpropCount > 0)
                {
                    callPayload.Body = sAPBringWindowToFront;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPGlobalLeftMouseClickOnSAPElement))]
        public IWorkflowAction SAPGlobalLeftMouseClickOnSAPElement([WorkflowExpression] Func<string> sAPGlobalLeftMouseClickOnSAPElementsearchSAPElementId, [WorkflowExpression] Func<string> sAPGlobalLeftMouseClickOnSAPElementworkflow, [WorkflowExpression] Func<bool> sAPGlobalLeftMouseClickOnSAPElementsetElementWindowTopMost = null, [WorkflowExpression] Func<bool> sAPGlobalLeftMouseClickOnSAPElementbringElementWindowToFront = null, [WorkflowExpression] Func<bool> sAPGlobalLeftMouseClickOnSAPElementtoggleWindow = null, [WorkflowExpression] Func<bool> sAPGlobalLeftMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent = null, [WorkflowExpression] Func<double> sAPGlobalLeftMouseClickOnSAPElementtoggleDelay = null, [WorkflowExpression] Func<int> sAPGlobalLeftMouseClickOnSAPElementclickOffsetX = null, [WorkflowExpression] Func<int> sAPGlobalLeftMouseClickOnSAPElementclickOffsetY = null, [WorkflowExpression] Func<sAPGlobalLeftMouseClickOnSAPElementoffsetRelativeToInput> sAPGlobalLeftMouseClickOnSAPElementoffsetRelativeTo = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSAPGlobalLeftMouseClickOnSAPElement(WorkflowValue<string> sAPGlobalLeftMouseClickOnSAPElementsearchSAPElementId, WorkflowValue<string> sAPGlobalLeftMouseClickOnSAPElementworkflow, WorkflowValue<bool> sAPGlobalLeftMouseClickOnSAPElementsetElementWindowTopMost = null, WorkflowValue<bool> sAPGlobalLeftMouseClickOnSAPElementbringElementWindowToFront = null, WorkflowValue<bool> sAPGlobalLeftMouseClickOnSAPElementtoggleWindow = null, WorkflowValue<bool> sAPGlobalLeftMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent = null, WorkflowValue<double> sAPGlobalLeftMouseClickOnSAPElementtoggleDelay = null, WorkflowValue<int> sAPGlobalLeftMouseClickOnSAPElementclickOffsetX = null, WorkflowValue<int> sAPGlobalLeftMouseClickOnSAPElementclickOffsetY = null, WorkflowValue<sAPGlobalLeftMouseClickOnSAPElementoffsetRelativeToInput> sAPGlobalLeftMouseClickOnSAPElementoffsetRelativeTo = null)
        {
            WorkflowValue.Validate(sAPGlobalLeftMouseClickOnSAPElementsearchSAPElementId, nameof(sAPGlobalLeftMouseClickOnSAPElementsearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPGlobalLeftMouseClickOnSAPElementworkflow, nameof(sAPGlobalLeftMouseClickOnSAPElementworkflow), required: true);
            WorkflowValue.Validate(sAPGlobalLeftMouseClickOnSAPElementsetElementWindowTopMost, nameof(sAPGlobalLeftMouseClickOnSAPElementsetElementWindowTopMost), required: false);
            WorkflowValue.Validate(sAPGlobalLeftMouseClickOnSAPElementbringElementWindowToFront, nameof(sAPGlobalLeftMouseClickOnSAPElementbringElementWindowToFront), required: false);
            WorkflowValue.Validate(sAPGlobalLeftMouseClickOnSAPElementtoggleWindow, nameof(sAPGlobalLeftMouseClickOnSAPElementtoggleWindow), required: false);
            WorkflowValue.Validate(sAPGlobalLeftMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent, nameof(sAPGlobalLeftMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent), required: false);
            WorkflowValue.Validate(sAPGlobalLeftMouseClickOnSAPElementtoggleDelay, nameof(sAPGlobalLeftMouseClickOnSAPElementtoggleDelay), required: false);
            WorkflowValue.Validate(sAPGlobalLeftMouseClickOnSAPElementclickOffsetX, nameof(sAPGlobalLeftMouseClickOnSAPElementclickOffsetX), required: false);
            WorkflowValue.Validate(sAPGlobalLeftMouseClickOnSAPElementclickOffsetY, nameof(sAPGlobalLeftMouseClickOnSAPElementclickOffsetY), required: false);
            WorkflowValue.Validate(sAPGlobalLeftMouseClickOnSAPElementoffsetRelativeTo, nameof(sAPGlobalLeftMouseClickOnSAPElementoffsetRelativeTo), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGlobalLeftMouseClickOnSAPElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGlobalLeftMouseClickOnSAPElement = new JObject();
                var sAPGlobalLeftMouseClickOnSAPElementpropCount = 0;
                sAPGlobalLeftMouseClickOnSAPElementpropCount++;
                sAPGlobalLeftMouseClickOnSAPElement["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGlobalLeftMouseClickOnSAPElementsearchSAPElementId);
                if (sAPGlobalLeftMouseClickOnSAPElementsetElementWindowTopMost != null)
                {
                    if (sAPGlobalLeftMouseClickOnSAPElementsetElementWindowTopMost != null)
                    {
                        sAPGlobalLeftMouseClickOnSAPElement["SetElementWindowTopMost"] = ExpressionConverter.ConvertO(sAPGlobalLeftMouseClickOnSAPElementsetElementWindowTopMost);
                        sAPGlobalLeftMouseClickOnSAPElementpropCount++;
                    }

                    sAPGlobalLeftMouseClickOnSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalLeftMouseClickOnSAPElement["SetElementWindowTopMost"] = false;
                    sAPGlobalLeftMouseClickOnSAPElementpropCount++;
                }

                if (sAPGlobalLeftMouseClickOnSAPElementbringElementWindowToFront != null)
                {
                    if (sAPGlobalLeftMouseClickOnSAPElementbringElementWindowToFront != null)
                    {
                        sAPGlobalLeftMouseClickOnSAPElement["BringElementWindowToFront"] = ExpressionConverter.ConvertO(sAPGlobalLeftMouseClickOnSAPElementbringElementWindowToFront);
                        sAPGlobalLeftMouseClickOnSAPElementpropCount++;
                    }

                    sAPGlobalLeftMouseClickOnSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalLeftMouseClickOnSAPElement["BringElementWindowToFront"] = false;
                    sAPGlobalLeftMouseClickOnSAPElementpropCount++;
                }

                if (sAPGlobalLeftMouseClickOnSAPElementtoggleWindow != null)
                {
                    if (sAPGlobalLeftMouseClickOnSAPElementtoggleWindow != null)
                    {
                        sAPGlobalLeftMouseClickOnSAPElement["ToggleWindow"] = ExpressionConverter.ConvertO(sAPGlobalLeftMouseClickOnSAPElementtoggleWindow);
                        sAPGlobalLeftMouseClickOnSAPElementpropCount++;
                    }

                    sAPGlobalLeftMouseClickOnSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalLeftMouseClickOnSAPElement["ToggleWindow"] = true;
                    sAPGlobalLeftMouseClickOnSAPElementpropCount++;
                }

                if (sAPGlobalLeftMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent != null)
                {
                    if (sAPGlobalLeftMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent != null)
                    {
                        sAPGlobalLeftMouseClickOnSAPElement["ToggleUsesGlobalLeftMouseClickAgent"] = ExpressionConverter.ConvertO(sAPGlobalLeftMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent);
                        sAPGlobalLeftMouseClickOnSAPElementpropCount++;
                    }

                    sAPGlobalLeftMouseClickOnSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalLeftMouseClickOnSAPElement["ToggleUsesGlobalLeftMouseClickAgent"] = true;
                    sAPGlobalLeftMouseClickOnSAPElementpropCount++;
                }

                if (sAPGlobalLeftMouseClickOnSAPElementtoggleDelay != null)
                {
                    if (sAPGlobalLeftMouseClickOnSAPElementtoggleDelay != null)
                    {
                        sAPGlobalLeftMouseClickOnSAPElement["ToggleDelay"] = ExpressionConverter.ConvertO(sAPGlobalLeftMouseClickOnSAPElementtoggleDelay);
                        sAPGlobalLeftMouseClickOnSAPElementpropCount++;
                    }

                    sAPGlobalLeftMouseClickOnSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalLeftMouseClickOnSAPElement["ToggleDelay"] = 0.5;
                    sAPGlobalLeftMouseClickOnSAPElementpropCount++;
                }

                if (sAPGlobalLeftMouseClickOnSAPElementclickOffsetX != null)
                {
                    if (sAPGlobalLeftMouseClickOnSAPElementclickOffsetX != null)
                    {
                        sAPGlobalLeftMouseClickOnSAPElement["ClickOffsetX"] = ExpressionConverter.ConvertO(sAPGlobalLeftMouseClickOnSAPElementclickOffsetX);
                        sAPGlobalLeftMouseClickOnSAPElementpropCount++;
                    }

                    sAPGlobalLeftMouseClickOnSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalLeftMouseClickOnSAPElement["ClickOffsetX"] = 0;
                    sAPGlobalLeftMouseClickOnSAPElementpropCount++;
                }

                if (sAPGlobalLeftMouseClickOnSAPElementclickOffsetY != null)
                {
                    if (sAPGlobalLeftMouseClickOnSAPElementclickOffsetY != null)
                    {
                        sAPGlobalLeftMouseClickOnSAPElement["ClickOffsetY"] = ExpressionConverter.ConvertO(sAPGlobalLeftMouseClickOnSAPElementclickOffsetY);
                        sAPGlobalLeftMouseClickOnSAPElementpropCount++;
                    }

                    sAPGlobalLeftMouseClickOnSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalLeftMouseClickOnSAPElement["ClickOffsetY"] = 0;
                    sAPGlobalLeftMouseClickOnSAPElementpropCount++;
                }

                if (sAPGlobalLeftMouseClickOnSAPElementoffsetRelativeTo != null)
                {
                    sAPGlobalLeftMouseClickOnSAPElement["OffsetRelativeTo"] = ExpressionConverter.ConvertO(sAPGlobalLeftMouseClickOnSAPElementoffsetRelativeTo);
                    sAPGlobalLeftMouseClickOnSAPElementpropCount++;
                }

                sAPGlobalLeftMouseClickOnSAPElementpropCount++;
                sAPGlobalLeftMouseClickOnSAPElement["Workflow"] = ExpressionConverter.ConvertO(sAPGlobalLeftMouseClickOnSAPElementworkflow);
                if (sAPGlobalLeftMouseClickOnSAPElementpropCount > 0)
                {
                    callPayload.Body = sAPGlobalLeftMouseClickOnSAPElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPGlobalRightMouseClickOnSAPElement))]
        public IWorkflowAction SAPGlobalRightMouseClickOnSAPElement([WorkflowExpression] Func<string> sAPGlobalRightMouseClickOnSAPElementsearchSAPElementId, [WorkflowExpression] Func<string> sAPGlobalRightMouseClickOnSAPElementworkflow, [WorkflowExpression] Func<bool> sAPGlobalRightMouseClickOnSAPElementsetElementWindowTopMost = null, [WorkflowExpression] Func<bool> sAPGlobalRightMouseClickOnSAPElementbringElementWindowToFront = null, [WorkflowExpression] Func<bool> sAPGlobalRightMouseClickOnSAPElementtoggleWindow = null, [WorkflowExpression] Func<bool> sAPGlobalRightMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent = null, [WorkflowExpression] Func<double> sAPGlobalRightMouseClickOnSAPElementtoggleDelay = null, [WorkflowExpression] Func<int> sAPGlobalRightMouseClickOnSAPElementclickOffsetX = null, [WorkflowExpression] Func<int> sAPGlobalRightMouseClickOnSAPElementclickOffsetY = null, [WorkflowExpression] Func<sAPGlobalRightMouseClickOnSAPElementoffsetRelativeToInput> sAPGlobalRightMouseClickOnSAPElementoffsetRelativeTo = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSAPGlobalRightMouseClickOnSAPElement(WorkflowValue<string> sAPGlobalRightMouseClickOnSAPElementsearchSAPElementId, WorkflowValue<string> sAPGlobalRightMouseClickOnSAPElementworkflow, WorkflowValue<bool> sAPGlobalRightMouseClickOnSAPElementsetElementWindowTopMost = null, WorkflowValue<bool> sAPGlobalRightMouseClickOnSAPElementbringElementWindowToFront = null, WorkflowValue<bool> sAPGlobalRightMouseClickOnSAPElementtoggleWindow = null, WorkflowValue<bool> sAPGlobalRightMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent = null, WorkflowValue<double> sAPGlobalRightMouseClickOnSAPElementtoggleDelay = null, WorkflowValue<int> sAPGlobalRightMouseClickOnSAPElementclickOffsetX = null, WorkflowValue<int> sAPGlobalRightMouseClickOnSAPElementclickOffsetY = null, WorkflowValue<sAPGlobalRightMouseClickOnSAPElementoffsetRelativeToInput> sAPGlobalRightMouseClickOnSAPElementoffsetRelativeTo = null)
        {
            WorkflowValue.Validate(sAPGlobalRightMouseClickOnSAPElementsearchSAPElementId, nameof(sAPGlobalRightMouseClickOnSAPElementsearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPGlobalRightMouseClickOnSAPElementworkflow, nameof(sAPGlobalRightMouseClickOnSAPElementworkflow), required: true);
            WorkflowValue.Validate(sAPGlobalRightMouseClickOnSAPElementsetElementWindowTopMost, nameof(sAPGlobalRightMouseClickOnSAPElementsetElementWindowTopMost), required: false);
            WorkflowValue.Validate(sAPGlobalRightMouseClickOnSAPElementbringElementWindowToFront, nameof(sAPGlobalRightMouseClickOnSAPElementbringElementWindowToFront), required: false);
            WorkflowValue.Validate(sAPGlobalRightMouseClickOnSAPElementtoggleWindow, nameof(sAPGlobalRightMouseClickOnSAPElementtoggleWindow), required: false);
            WorkflowValue.Validate(sAPGlobalRightMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent, nameof(sAPGlobalRightMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent), required: false);
            WorkflowValue.Validate(sAPGlobalRightMouseClickOnSAPElementtoggleDelay, nameof(sAPGlobalRightMouseClickOnSAPElementtoggleDelay), required: false);
            WorkflowValue.Validate(sAPGlobalRightMouseClickOnSAPElementclickOffsetX, nameof(sAPGlobalRightMouseClickOnSAPElementclickOffsetX), required: false);
            WorkflowValue.Validate(sAPGlobalRightMouseClickOnSAPElementclickOffsetY, nameof(sAPGlobalRightMouseClickOnSAPElementclickOffsetY), required: false);
            WorkflowValue.Validate(sAPGlobalRightMouseClickOnSAPElementoffsetRelativeTo, nameof(sAPGlobalRightMouseClickOnSAPElementoffsetRelativeTo), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGlobalRightMouseClickOnSAPElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGlobalRightMouseClickOnSAPElement = new JObject();
                var sAPGlobalRightMouseClickOnSAPElementpropCount = 0;
                sAPGlobalRightMouseClickOnSAPElementpropCount++;
                sAPGlobalRightMouseClickOnSAPElement["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGlobalRightMouseClickOnSAPElementsearchSAPElementId);
                if (sAPGlobalRightMouseClickOnSAPElementsetElementWindowTopMost != null)
                {
                    if (sAPGlobalRightMouseClickOnSAPElementsetElementWindowTopMost != null)
                    {
                        sAPGlobalRightMouseClickOnSAPElement["SetElementWindowTopMost"] = ExpressionConverter.ConvertO(sAPGlobalRightMouseClickOnSAPElementsetElementWindowTopMost);
                        sAPGlobalRightMouseClickOnSAPElementpropCount++;
                    }

                    sAPGlobalRightMouseClickOnSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalRightMouseClickOnSAPElement["SetElementWindowTopMost"] = false;
                    sAPGlobalRightMouseClickOnSAPElementpropCount++;
                }

                if (sAPGlobalRightMouseClickOnSAPElementbringElementWindowToFront != null)
                {
                    if (sAPGlobalRightMouseClickOnSAPElementbringElementWindowToFront != null)
                    {
                        sAPGlobalRightMouseClickOnSAPElement["BringElementWindowToFront"] = ExpressionConverter.ConvertO(sAPGlobalRightMouseClickOnSAPElementbringElementWindowToFront);
                        sAPGlobalRightMouseClickOnSAPElementpropCount++;
                    }

                    sAPGlobalRightMouseClickOnSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalRightMouseClickOnSAPElement["BringElementWindowToFront"] = false;
                    sAPGlobalRightMouseClickOnSAPElementpropCount++;
                }

                if (sAPGlobalRightMouseClickOnSAPElementtoggleWindow != null)
                {
                    if (sAPGlobalRightMouseClickOnSAPElementtoggleWindow != null)
                    {
                        sAPGlobalRightMouseClickOnSAPElement["ToggleWindow"] = ExpressionConverter.ConvertO(sAPGlobalRightMouseClickOnSAPElementtoggleWindow);
                        sAPGlobalRightMouseClickOnSAPElementpropCount++;
                    }

                    sAPGlobalRightMouseClickOnSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalRightMouseClickOnSAPElement["ToggleWindow"] = true;
                    sAPGlobalRightMouseClickOnSAPElementpropCount++;
                }

                if (sAPGlobalRightMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent != null)
                {
                    if (sAPGlobalRightMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent != null)
                    {
                        sAPGlobalRightMouseClickOnSAPElement["ToggleUsesGlobalLeftMouseClickAgent"] = ExpressionConverter.ConvertO(sAPGlobalRightMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent);
                        sAPGlobalRightMouseClickOnSAPElementpropCount++;
                    }

                    sAPGlobalRightMouseClickOnSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalRightMouseClickOnSAPElement["ToggleUsesGlobalLeftMouseClickAgent"] = true;
                    sAPGlobalRightMouseClickOnSAPElementpropCount++;
                }

                if (sAPGlobalRightMouseClickOnSAPElementtoggleDelay != null)
                {
                    if (sAPGlobalRightMouseClickOnSAPElementtoggleDelay != null)
                    {
                        sAPGlobalRightMouseClickOnSAPElement["ToggleDelay"] = ExpressionConverter.ConvertO(sAPGlobalRightMouseClickOnSAPElementtoggleDelay);
                        sAPGlobalRightMouseClickOnSAPElementpropCount++;
                    }

                    sAPGlobalRightMouseClickOnSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalRightMouseClickOnSAPElement["ToggleDelay"] = 0.5;
                    sAPGlobalRightMouseClickOnSAPElementpropCount++;
                }

                if (sAPGlobalRightMouseClickOnSAPElementclickOffsetX != null)
                {
                    if (sAPGlobalRightMouseClickOnSAPElementclickOffsetX != null)
                    {
                        sAPGlobalRightMouseClickOnSAPElement["ClickOffsetX"] = ExpressionConverter.ConvertO(sAPGlobalRightMouseClickOnSAPElementclickOffsetX);
                        sAPGlobalRightMouseClickOnSAPElementpropCount++;
                    }

                    sAPGlobalRightMouseClickOnSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalRightMouseClickOnSAPElement["ClickOffsetX"] = 0;
                    sAPGlobalRightMouseClickOnSAPElementpropCount++;
                }

                if (sAPGlobalRightMouseClickOnSAPElementclickOffsetY != null)
                {
                    if (sAPGlobalRightMouseClickOnSAPElementclickOffsetY != null)
                    {
                        sAPGlobalRightMouseClickOnSAPElement["ClickOffsetY"] = ExpressionConverter.ConvertO(sAPGlobalRightMouseClickOnSAPElementclickOffsetY);
                        sAPGlobalRightMouseClickOnSAPElementpropCount++;
                    }

                    sAPGlobalRightMouseClickOnSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalRightMouseClickOnSAPElement["ClickOffsetY"] = 0;
                    sAPGlobalRightMouseClickOnSAPElementpropCount++;
                }

                if (sAPGlobalRightMouseClickOnSAPElementoffsetRelativeTo != null)
                {
                    sAPGlobalRightMouseClickOnSAPElement["OffsetRelativeTo"] = ExpressionConverter.ConvertO(sAPGlobalRightMouseClickOnSAPElementoffsetRelativeTo);
                    sAPGlobalRightMouseClickOnSAPElementpropCount++;
                }

                sAPGlobalRightMouseClickOnSAPElementpropCount++;
                sAPGlobalRightMouseClickOnSAPElement["Workflow"] = ExpressionConverter.ConvertO(sAPGlobalRightMouseClickOnSAPElementworkflow);
                if (sAPGlobalRightMouseClickOnSAPElementpropCount > 0)
                {
                    callPayload.Body = sAPGlobalRightMouseClickOnSAPElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPGlobalMiddleMouseClickOnSAPElement))]
        public IWorkflowAction SAPGlobalMiddleMouseClickOnSAPElement([WorkflowExpression] Func<string> sAPGlobalMiddleMouseClickOnSAPElementsearchSAPElementId, [WorkflowExpression] Func<string> sAPGlobalMiddleMouseClickOnSAPElementworkflow, [WorkflowExpression] Func<bool> sAPGlobalMiddleMouseClickOnSAPElementsetElementWindowTopMost = null, [WorkflowExpression] Func<bool> sAPGlobalMiddleMouseClickOnSAPElementbringElementWindowToFront = null, [WorkflowExpression] Func<bool> sAPGlobalMiddleMouseClickOnSAPElementtoggleWindow = null, [WorkflowExpression] Func<bool> sAPGlobalMiddleMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent = null, [WorkflowExpression] Func<double> sAPGlobalMiddleMouseClickOnSAPElementtoggleDelay = null, [WorkflowExpression] Func<int> sAPGlobalMiddleMouseClickOnSAPElementclickOffsetX = null, [WorkflowExpression] Func<int> sAPGlobalMiddleMouseClickOnSAPElementclickOffsetY = null, [WorkflowExpression] Func<sAPGlobalMiddleMouseClickOnSAPElementoffsetRelativeToInput> sAPGlobalMiddleMouseClickOnSAPElementoffsetRelativeTo = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSAPGlobalMiddleMouseClickOnSAPElement(WorkflowValue<string> sAPGlobalMiddleMouseClickOnSAPElementsearchSAPElementId, WorkflowValue<string> sAPGlobalMiddleMouseClickOnSAPElementworkflow, WorkflowValue<bool> sAPGlobalMiddleMouseClickOnSAPElementsetElementWindowTopMost = null, WorkflowValue<bool> sAPGlobalMiddleMouseClickOnSAPElementbringElementWindowToFront = null, WorkflowValue<bool> sAPGlobalMiddleMouseClickOnSAPElementtoggleWindow = null, WorkflowValue<bool> sAPGlobalMiddleMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent = null, WorkflowValue<double> sAPGlobalMiddleMouseClickOnSAPElementtoggleDelay = null, WorkflowValue<int> sAPGlobalMiddleMouseClickOnSAPElementclickOffsetX = null, WorkflowValue<int> sAPGlobalMiddleMouseClickOnSAPElementclickOffsetY = null, WorkflowValue<sAPGlobalMiddleMouseClickOnSAPElementoffsetRelativeToInput> sAPGlobalMiddleMouseClickOnSAPElementoffsetRelativeTo = null)
        {
            WorkflowValue.Validate(sAPGlobalMiddleMouseClickOnSAPElementsearchSAPElementId, nameof(sAPGlobalMiddleMouseClickOnSAPElementsearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPGlobalMiddleMouseClickOnSAPElementworkflow, nameof(sAPGlobalMiddleMouseClickOnSAPElementworkflow), required: true);
            WorkflowValue.Validate(sAPGlobalMiddleMouseClickOnSAPElementsetElementWindowTopMost, nameof(sAPGlobalMiddleMouseClickOnSAPElementsetElementWindowTopMost), required: false);
            WorkflowValue.Validate(sAPGlobalMiddleMouseClickOnSAPElementbringElementWindowToFront, nameof(sAPGlobalMiddleMouseClickOnSAPElementbringElementWindowToFront), required: false);
            WorkflowValue.Validate(sAPGlobalMiddleMouseClickOnSAPElementtoggleWindow, nameof(sAPGlobalMiddleMouseClickOnSAPElementtoggleWindow), required: false);
            WorkflowValue.Validate(sAPGlobalMiddleMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent, nameof(sAPGlobalMiddleMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent), required: false);
            WorkflowValue.Validate(sAPGlobalMiddleMouseClickOnSAPElementtoggleDelay, nameof(sAPGlobalMiddleMouseClickOnSAPElementtoggleDelay), required: false);
            WorkflowValue.Validate(sAPGlobalMiddleMouseClickOnSAPElementclickOffsetX, nameof(sAPGlobalMiddleMouseClickOnSAPElementclickOffsetX), required: false);
            WorkflowValue.Validate(sAPGlobalMiddleMouseClickOnSAPElementclickOffsetY, nameof(sAPGlobalMiddleMouseClickOnSAPElementclickOffsetY), required: false);
            WorkflowValue.Validate(sAPGlobalMiddleMouseClickOnSAPElementoffsetRelativeTo, nameof(sAPGlobalMiddleMouseClickOnSAPElementoffsetRelativeTo), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGlobalMiddleMouseClickOnSAPElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGlobalMiddleMouseClickOnSAPElement = new JObject();
                var sAPGlobalMiddleMouseClickOnSAPElementpropCount = 0;
                sAPGlobalMiddleMouseClickOnSAPElementpropCount++;
                sAPGlobalMiddleMouseClickOnSAPElement["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGlobalMiddleMouseClickOnSAPElementsearchSAPElementId);
                if (sAPGlobalMiddleMouseClickOnSAPElementsetElementWindowTopMost != null)
                {
                    if (sAPGlobalMiddleMouseClickOnSAPElementsetElementWindowTopMost != null)
                    {
                        sAPGlobalMiddleMouseClickOnSAPElement["SetElementWindowTopMost"] = ExpressionConverter.ConvertO(sAPGlobalMiddleMouseClickOnSAPElementsetElementWindowTopMost);
                        sAPGlobalMiddleMouseClickOnSAPElementpropCount++;
                    }

                    sAPGlobalMiddleMouseClickOnSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalMiddleMouseClickOnSAPElement["SetElementWindowTopMost"] = false;
                    sAPGlobalMiddleMouseClickOnSAPElementpropCount++;
                }

                if (sAPGlobalMiddleMouseClickOnSAPElementbringElementWindowToFront != null)
                {
                    if (sAPGlobalMiddleMouseClickOnSAPElementbringElementWindowToFront != null)
                    {
                        sAPGlobalMiddleMouseClickOnSAPElement["BringElementWindowToFront"] = ExpressionConverter.ConvertO(sAPGlobalMiddleMouseClickOnSAPElementbringElementWindowToFront);
                        sAPGlobalMiddleMouseClickOnSAPElementpropCount++;
                    }

                    sAPGlobalMiddleMouseClickOnSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalMiddleMouseClickOnSAPElement["BringElementWindowToFront"] = false;
                    sAPGlobalMiddleMouseClickOnSAPElementpropCount++;
                }

                if (sAPGlobalMiddleMouseClickOnSAPElementtoggleWindow != null)
                {
                    if (sAPGlobalMiddleMouseClickOnSAPElementtoggleWindow != null)
                    {
                        sAPGlobalMiddleMouseClickOnSAPElement["ToggleWindow"] = ExpressionConverter.ConvertO(sAPGlobalMiddleMouseClickOnSAPElementtoggleWindow);
                        sAPGlobalMiddleMouseClickOnSAPElementpropCount++;
                    }

                    sAPGlobalMiddleMouseClickOnSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalMiddleMouseClickOnSAPElement["ToggleWindow"] = true;
                    sAPGlobalMiddleMouseClickOnSAPElementpropCount++;
                }

                if (sAPGlobalMiddleMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent != null)
                {
                    if (sAPGlobalMiddleMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent != null)
                    {
                        sAPGlobalMiddleMouseClickOnSAPElement["ToggleUsesGlobalLeftMouseClickAgent"] = ExpressionConverter.ConvertO(sAPGlobalMiddleMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent);
                        sAPGlobalMiddleMouseClickOnSAPElementpropCount++;
                    }

                    sAPGlobalMiddleMouseClickOnSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalMiddleMouseClickOnSAPElement["ToggleUsesGlobalLeftMouseClickAgent"] = true;
                    sAPGlobalMiddleMouseClickOnSAPElementpropCount++;
                }

                if (sAPGlobalMiddleMouseClickOnSAPElementtoggleDelay != null)
                {
                    if (sAPGlobalMiddleMouseClickOnSAPElementtoggleDelay != null)
                    {
                        sAPGlobalMiddleMouseClickOnSAPElement["ToggleDelay"] = ExpressionConverter.ConvertO(sAPGlobalMiddleMouseClickOnSAPElementtoggleDelay);
                        sAPGlobalMiddleMouseClickOnSAPElementpropCount++;
                    }

                    sAPGlobalMiddleMouseClickOnSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalMiddleMouseClickOnSAPElement["ToggleDelay"] = 0.5;
                    sAPGlobalMiddleMouseClickOnSAPElementpropCount++;
                }

                if (sAPGlobalMiddleMouseClickOnSAPElementclickOffsetX != null)
                {
                    if (sAPGlobalMiddleMouseClickOnSAPElementclickOffsetX != null)
                    {
                        sAPGlobalMiddleMouseClickOnSAPElement["ClickOffsetX"] = ExpressionConverter.ConvertO(sAPGlobalMiddleMouseClickOnSAPElementclickOffsetX);
                        sAPGlobalMiddleMouseClickOnSAPElementpropCount++;
                    }

                    sAPGlobalMiddleMouseClickOnSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalMiddleMouseClickOnSAPElement["ClickOffsetX"] = 0;
                    sAPGlobalMiddleMouseClickOnSAPElementpropCount++;
                }

                if (sAPGlobalMiddleMouseClickOnSAPElementclickOffsetY != null)
                {
                    if (sAPGlobalMiddleMouseClickOnSAPElementclickOffsetY != null)
                    {
                        sAPGlobalMiddleMouseClickOnSAPElement["ClickOffsetY"] = ExpressionConverter.ConvertO(sAPGlobalMiddleMouseClickOnSAPElementclickOffsetY);
                        sAPGlobalMiddleMouseClickOnSAPElementpropCount++;
                    }

                    sAPGlobalMiddleMouseClickOnSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalMiddleMouseClickOnSAPElement["ClickOffsetY"] = 0;
                    sAPGlobalMiddleMouseClickOnSAPElementpropCount++;
                }

                if (sAPGlobalMiddleMouseClickOnSAPElementoffsetRelativeTo != null)
                {
                    sAPGlobalMiddleMouseClickOnSAPElement["OffsetRelativeTo"] = ExpressionConverter.ConvertO(sAPGlobalMiddleMouseClickOnSAPElementoffsetRelativeTo);
                    sAPGlobalMiddleMouseClickOnSAPElementpropCount++;
                }

                sAPGlobalMiddleMouseClickOnSAPElementpropCount++;
                sAPGlobalMiddleMouseClickOnSAPElement["Workflow"] = ExpressionConverter.ConvertO(sAPGlobalMiddleMouseClickOnSAPElementworkflow);
                if (sAPGlobalMiddleMouseClickOnSAPElementpropCount > 0)
                {
                    callPayload.Body = sAPGlobalMiddleMouseClickOnSAPElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPGlobalDoubleLeftMouseClickOnSAPElement))]
        public IWorkflowAction SAPGlobalDoubleLeftMouseClickOnSAPElement([WorkflowExpression] Func<string> sAPGlobalDoubleLeftMouseClickOnSAPElementsearchSAPElementId, [WorkflowExpression] Func<string> sAPGlobalDoubleLeftMouseClickOnSAPElementworkflow, [WorkflowExpression] Func<bool> sAPGlobalDoubleLeftMouseClickOnSAPElementsetElementWindowTopMost = null, [WorkflowExpression] Func<bool> sAPGlobalDoubleLeftMouseClickOnSAPElementbringElementWindowToFront = null, [WorkflowExpression] Func<bool> sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleWindow = null, [WorkflowExpression] Func<bool> sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent = null, [WorkflowExpression] Func<double> sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleDelay = null, [WorkflowExpression] Func<int> sAPGlobalDoubleLeftMouseClickOnSAPElementclickOffsetX = null, [WorkflowExpression] Func<int> sAPGlobalDoubleLeftMouseClickOnSAPElementclickOffsetY = null, [WorkflowExpression] Func<sAPGlobalDoubleLeftMouseClickOnSAPElementoffsetRelativeToInput> sAPGlobalDoubleLeftMouseClickOnSAPElementoffsetRelativeTo = null, [WorkflowExpression] Func<int> sAPGlobalDoubleLeftMouseClickOnSAPElementdoubleClickDelayInMilliseconds = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSAPGlobalDoubleLeftMouseClickOnSAPElement(WorkflowValue<string> sAPGlobalDoubleLeftMouseClickOnSAPElementsearchSAPElementId, WorkflowValue<string> sAPGlobalDoubleLeftMouseClickOnSAPElementworkflow, WorkflowValue<bool> sAPGlobalDoubleLeftMouseClickOnSAPElementsetElementWindowTopMost = null, WorkflowValue<bool> sAPGlobalDoubleLeftMouseClickOnSAPElementbringElementWindowToFront = null, WorkflowValue<bool> sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleWindow = null, WorkflowValue<bool> sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent = null, WorkflowValue<double> sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleDelay = null, WorkflowValue<int> sAPGlobalDoubleLeftMouseClickOnSAPElementclickOffsetX = null, WorkflowValue<int> sAPGlobalDoubleLeftMouseClickOnSAPElementclickOffsetY = null, WorkflowValue<sAPGlobalDoubleLeftMouseClickOnSAPElementoffsetRelativeToInput> sAPGlobalDoubleLeftMouseClickOnSAPElementoffsetRelativeTo = null, WorkflowValue<int> sAPGlobalDoubleLeftMouseClickOnSAPElementdoubleClickDelayInMilliseconds = null)
        {
            WorkflowValue.Validate(sAPGlobalDoubleLeftMouseClickOnSAPElementsearchSAPElementId, nameof(sAPGlobalDoubleLeftMouseClickOnSAPElementsearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPGlobalDoubleLeftMouseClickOnSAPElementworkflow, nameof(sAPGlobalDoubleLeftMouseClickOnSAPElementworkflow), required: true);
            WorkflowValue.Validate(sAPGlobalDoubleLeftMouseClickOnSAPElementsetElementWindowTopMost, nameof(sAPGlobalDoubleLeftMouseClickOnSAPElementsetElementWindowTopMost), required: false);
            WorkflowValue.Validate(sAPGlobalDoubleLeftMouseClickOnSAPElementbringElementWindowToFront, nameof(sAPGlobalDoubleLeftMouseClickOnSAPElementbringElementWindowToFront), required: false);
            WorkflowValue.Validate(sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleWindow, nameof(sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleWindow), required: false);
            WorkflowValue.Validate(sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent, nameof(sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent), required: false);
            WorkflowValue.Validate(sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleDelay, nameof(sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleDelay), required: false);
            WorkflowValue.Validate(sAPGlobalDoubleLeftMouseClickOnSAPElementclickOffsetX, nameof(sAPGlobalDoubleLeftMouseClickOnSAPElementclickOffsetX), required: false);
            WorkflowValue.Validate(sAPGlobalDoubleLeftMouseClickOnSAPElementclickOffsetY, nameof(sAPGlobalDoubleLeftMouseClickOnSAPElementclickOffsetY), required: false);
            WorkflowValue.Validate(sAPGlobalDoubleLeftMouseClickOnSAPElementoffsetRelativeTo, nameof(sAPGlobalDoubleLeftMouseClickOnSAPElementoffsetRelativeTo), required: false);
            WorkflowValue.Validate(sAPGlobalDoubleLeftMouseClickOnSAPElementdoubleClickDelayInMilliseconds, nameof(sAPGlobalDoubleLeftMouseClickOnSAPElementdoubleClickDelayInMilliseconds), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGlobalDoubleLeftMouseClickOnSAPElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGlobalDoubleLeftMouseClickOnSAPElement = new JObject();
                var sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount = 0;
                sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount++;
                sAPGlobalDoubleLeftMouseClickOnSAPElement["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGlobalDoubleLeftMouseClickOnSAPElementsearchSAPElementId);
                if (sAPGlobalDoubleLeftMouseClickOnSAPElementsetElementWindowTopMost != null)
                {
                    if (sAPGlobalDoubleLeftMouseClickOnSAPElementsetElementWindowTopMost != null)
                    {
                        sAPGlobalDoubleLeftMouseClickOnSAPElement["SetElementWindowTopMost"] = ExpressionConverter.ConvertO(sAPGlobalDoubleLeftMouseClickOnSAPElementsetElementWindowTopMost);
                        sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount++;
                    }

                    sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalDoubleLeftMouseClickOnSAPElement["SetElementWindowTopMost"] = false;
                    sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount++;
                }

                if (sAPGlobalDoubleLeftMouseClickOnSAPElementbringElementWindowToFront != null)
                {
                    if (sAPGlobalDoubleLeftMouseClickOnSAPElementbringElementWindowToFront != null)
                    {
                        sAPGlobalDoubleLeftMouseClickOnSAPElement["BringElementWindowToFront"] = ExpressionConverter.ConvertO(sAPGlobalDoubleLeftMouseClickOnSAPElementbringElementWindowToFront);
                        sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount++;
                    }

                    sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalDoubleLeftMouseClickOnSAPElement["BringElementWindowToFront"] = false;
                    sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount++;
                }

                if (sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleWindow != null)
                {
                    if (sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleWindow != null)
                    {
                        sAPGlobalDoubleLeftMouseClickOnSAPElement["ToggleWindow"] = ExpressionConverter.ConvertO(sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleWindow);
                        sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount++;
                    }

                    sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalDoubleLeftMouseClickOnSAPElement["ToggleWindow"] = true;
                    sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount++;
                }

                if (sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent != null)
                {
                    if (sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent != null)
                    {
                        sAPGlobalDoubleLeftMouseClickOnSAPElement["ToggleUsesGlobalLeftMouseClickAgent"] = ExpressionConverter.ConvertO(sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent);
                        sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount++;
                    }

                    sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalDoubleLeftMouseClickOnSAPElement["ToggleUsesGlobalLeftMouseClickAgent"] = true;
                    sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount++;
                }

                if (sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleDelay != null)
                {
                    if (sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleDelay != null)
                    {
                        sAPGlobalDoubleLeftMouseClickOnSAPElement["ToggleDelay"] = ExpressionConverter.ConvertO(sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleDelay);
                        sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount++;
                    }

                    sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalDoubleLeftMouseClickOnSAPElement["ToggleDelay"] = 0.5;
                    sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount++;
                }

                if (sAPGlobalDoubleLeftMouseClickOnSAPElementclickOffsetX != null)
                {
                    if (sAPGlobalDoubleLeftMouseClickOnSAPElementclickOffsetX != null)
                    {
                        sAPGlobalDoubleLeftMouseClickOnSAPElement["ClickOffsetX"] = ExpressionConverter.ConvertO(sAPGlobalDoubleLeftMouseClickOnSAPElementclickOffsetX);
                        sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount++;
                    }

                    sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalDoubleLeftMouseClickOnSAPElement["ClickOffsetX"] = 0;
                    sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount++;
                }

                if (sAPGlobalDoubleLeftMouseClickOnSAPElementclickOffsetY != null)
                {
                    if (sAPGlobalDoubleLeftMouseClickOnSAPElementclickOffsetY != null)
                    {
                        sAPGlobalDoubleLeftMouseClickOnSAPElement["ClickOffsetY"] = ExpressionConverter.ConvertO(sAPGlobalDoubleLeftMouseClickOnSAPElementclickOffsetY);
                        sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount++;
                    }

                    sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalDoubleLeftMouseClickOnSAPElement["ClickOffsetY"] = 0;
                    sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount++;
                }

                if (sAPGlobalDoubleLeftMouseClickOnSAPElementoffsetRelativeTo != null)
                {
                    sAPGlobalDoubleLeftMouseClickOnSAPElement["OffsetRelativeTo"] = ExpressionConverter.ConvertO(sAPGlobalDoubleLeftMouseClickOnSAPElementoffsetRelativeTo);
                    sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount++;
                }

                if (sAPGlobalDoubleLeftMouseClickOnSAPElementdoubleClickDelayInMilliseconds != null)
                {
                    if (sAPGlobalDoubleLeftMouseClickOnSAPElementdoubleClickDelayInMilliseconds != null)
                    {
                        sAPGlobalDoubleLeftMouseClickOnSAPElement["DoubleClickDelayInMilliseconds"] = ExpressionConverter.ConvertO(sAPGlobalDoubleLeftMouseClickOnSAPElementdoubleClickDelayInMilliseconds);
                        sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount++;
                    }

                    sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalDoubleLeftMouseClickOnSAPElement["DoubleClickDelayInMilliseconds"] = 10;
                    sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount++;
                }

                sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount++;
                sAPGlobalDoubleLeftMouseClickOnSAPElement["Workflow"] = ExpressionConverter.ConvertO(sAPGlobalDoubleLeftMouseClickOnSAPElementworkflow);
                if (sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount > 0)
                {
                    callPayload.Body = sAPGlobalDoubleLeftMouseClickOnSAPElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPGlobalInputTextIntoSAPElement))]
        public IWorkflowAction SAPGlobalInputTextIntoSAPElement([WorkflowExpression] Func<string> sAPGlobalInputTextIntoSAPElementsearchSAPElementId, [WorkflowExpression] Func<string> sAPGlobalInputTextIntoSAPElementworkflow, [WorkflowExpression] Func<bool> sAPGlobalInputTextIntoSAPElementsetElementWindowTopMost = null, [WorkflowExpression] Func<bool> sAPGlobalInputTextIntoSAPElementbringElementWindowToFront = null, [WorkflowExpression] Func<bool> sAPGlobalInputTextIntoSAPElementtoggleWindow = null, [WorkflowExpression] Func<bool> sAPGlobalInputTextIntoSAPElementtoggleUsesGlobalLeftMouseClickAgent = null, [WorkflowExpression] Func<double> sAPGlobalInputTextIntoSAPElementtoggleDelay = null, [WorkflowExpression] Func<bool> sAPGlobalInputTextIntoSAPElementglobalMouseClickOnElement = null, [WorkflowExpression] Func<bool> sAPGlobalInputTextIntoSAPElementreplaceExistingValueUsingDoubleClickDelete = null, [WorkflowExpression] Func<bool> sAPGlobalInputTextIntoSAPElementreplaceExistingValueUsingCTRLADelete = null, [WorkflowExpression] Func<string> sAPGlobalInputTextIntoSAPElementtextToInput = null, [WorkflowExpression] Func<bool> sAPGlobalInputTextIntoSAPElementsendKeyEvents = null, [WorkflowExpression] Func<int> sAPGlobalInputTextIntoSAPElementkeyIntervalInMilliseconds = null, [WorkflowExpression] Func<int> sAPGlobalInputTextIntoSAPElementdoubleClickIntervalInMilliseconds = null, [WorkflowExpression] Func<bool> sAPGlobalInputTextIntoSAPElementdontInterpretSymbols = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSAPGlobalInputTextIntoSAPElement(WorkflowValue<string> sAPGlobalInputTextIntoSAPElementsearchSAPElementId, WorkflowValue<string> sAPGlobalInputTextIntoSAPElementworkflow, WorkflowValue<bool> sAPGlobalInputTextIntoSAPElementsetElementWindowTopMost = null, WorkflowValue<bool> sAPGlobalInputTextIntoSAPElementbringElementWindowToFront = null, WorkflowValue<bool> sAPGlobalInputTextIntoSAPElementtoggleWindow = null, WorkflowValue<bool> sAPGlobalInputTextIntoSAPElementtoggleUsesGlobalLeftMouseClickAgent = null, WorkflowValue<double> sAPGlobalInputTextIntoSAPElementtoggleDelay = null, WorkflowValue<bool> sAPGlobalInputTextIntoSAPElementglobalMouseClickOnElement = null, WorkflowValue<bool> sAPGlobalInputTextIntoSAPElementreplaceExistingValueUsingDoubleClickDelete = null, WorkflowValue<bool> sAPGlobalInputTextIntoSAPElementreplaceExistingValueUsingCTRLADelete = null, WorkflowValue<string> sAPGlobalInputTextIntoSAPElementtextToInput = null, WorkflowValue<bool> sAPGlobalInputTextIntoSAPElementsendKeyEvents = null, WorkflowValue<int> sAPGlobalInputTextIntoSAPElementkeyIntervalInMilliseconds = null, WorkflowValue<int> sAPGlobalInputTextIntoSAPElementdoubleClickIntervalInMilliseconds = null, WorkflowValue<bool> sAPGlobalInputTextIntoSAPElementdontInterpretSymbols = null)
        {
            WorkflowValue.Validate(sAPGlobalInputTextIntoSAPElementsearchSAPElementId, nameof(sAPGlobalInputTextIntoSAPElementsearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPGlobalInputTextIntoSAPElementworkflow, nameof(sAPGlobalInputTextIntoSAPElementworkflow), required: true);
            WorkflowValue.Validate(sAPGlobalInputTextIntoSAPElementsetElementWindowTopMost, nameof(sAPGlobalInputTextIntoSAPElementsetElementWindowTopMost), required: false);
            WorkflowValue.Validate(sAPGlobalInputTextIntoSAPElementbringElementWindowToFront, nameof(sAPGlobalInputTextIntoSAPElementbringElementWindowToFront), required: false);
            WorkflowValue.Validate(sAPGlobalInputTextIntoSAPElementtoggleWindow, nameof(sAPGlobalInputTextIntoSAPElementtoggleWindow), required: false);
            WorkflowValue.Validate(sAPGlobalInputTextIntoSAPElementtoggleUsesGlobalLeftMouseClickAgent, nameof(sAPGlobalInputTextIntoSAPElementtoggleUsesGlobalLeftMouseClickAgent), required: false);
            WorkflowValue.Validate(sAPGlobalInputTextIntoSAPElementtoggleDelay, nameof(sAPGlobalInputTextIntoSAPElementtoggleDelay), required: false);
            WorkflowValue.Validate(sAPGlobalInputTextIntoSAPElementglobalMouseClickOnElement, nameof(sAPGlobalInputTextIntoSAPElementglobalMouseClickOnElement), required: false);
            WorkflowValue.Validate(sAPGlobalInputTextIntoSAPElementreplaceExistingValueUsingDoubleClickDelete, nameof(sAPGlobalInputTextIntoSAPElementreplaceExistingValueUsingDoubleClickDelete), required: false);
            WorkflowValue.Validate(sAPGlobalInputTextIntoSAPElementreplaceExistingValueUsingCTRLADelete, nameof(sAPGlobalInputTextIntoSAPElementreplaceExistingValueUsingCTRLADelete), required: false);
            WorkflowValue.Validate(sAPGlobalInputTextIntoSAPElementtextToInput, nameof(sAPGlobalInputTextIntoSAPElementtextToInput), required: false);
            WorkflowValue.Validate(sAPGlobalInputTextIntoSAPElementsendKeyEvents, nameof(sAPGlobalInputTextIntoSAPElementsendKeyEvents), required: false);
            WorkflowValue.Validate(sAPGlobalInputTextIntoSAPElementkeyIntervalInMilliseconds, nameof(sAPGlobalInputTextIntoSAPElementkeyIntervalInMilliseconds), required: false);
            WorkflowValue.Validate(sAPGlobalInputTextIntoSAPElementdoubleClickIntervalInMilliseconds, nameof(sAPGlobalInputTextIntoSAPElementdoubleClickIntervalInMilliseconds), required: false);
            WorkflowValue.Validate(sAPGlobalInputTextIntoSAPElementdontInterpretSymbols, nameof(sAPGlobalInputTextIntoSAPElementdontInterpretSymbols), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGlobalInputTextIntoSAPElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGlobalInputTextIntoSAPElement = new JObject();
                var sAPGlobalInputTextIntoSAPElementpropCount = 0;
                sAPGlobalInputTextIntoSAPElementpropCount++;
                sAPGlobalInputTextIntoSAPElement["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGlobalInputTextIntoSAPElementsearchSAPElementId);
                if (sAPGlobalInputTextIntoSAPElementsetElementWindowTopMost != null)
                {
                    if (sAPGlobalInputTextIntoSAPElementsetElementWindowTopMost != null)
                    {
                        sAPGlobalInputTextIntoSAPElement["SetElementWindowTopMost"] = ExpressionConverter.ConvertO(sAPGlobalInputTextIntoSAPElementsetElementWindowTopMost);
                        sAPGlobalInputTextIntoSAPElementpropCount++;
                    }

                    sAPGlobalInputTextIntoSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalInputTextIntoSAPElement["SetElementWindowTopMost"] = false;
                    sAPGlobalInputTextIntoSAPElementpropCount++;
                }

                if (sAPGlobalInputTextIntoSAPElementbringElementWindowToFront != null)
                {
                    if (sAPGlobalInputTextIntoSAPElementbringElementWindowToFront != null)
                    {
                        sAPGlobalInputTextIntoSAPElement["BringElementWindowToFront"] = ExpressionConverter.ConvertO(sAPGlobalInputTextIntoSAPElementbringElementWindowToFront);
                        sAPGlobalInputTextIntoSAPElementpropCount++;
                    }

                    sAPGlobalInputTextIntoSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalInputTextIntoSAPElement["BringElementWindowToFront"] = false;
                    sAPGlobalInputTextIntoSAPElementpropCount++;
                }

                if (sAPGlobalInputTextIntoSAPElementtoggleWindow != null)
                {
                    if (sAPGlobalInputTextIntoSAPElementtoggleWindow != null)
                    {
                        sAPGlobalInputTextIntoSAPElement["ToggleWindow"] = ExpressionConverter.ConvertO(sAPGlobalInputTextIntoSAPElementtoggleWindow);
                        sAPGlobalInputTextIntoSAPElementpropCount++;
                    }

                    sAPGlobalInputTextIntoSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalInputTextIntoSAPElement["ToggleWindow"] = true;
                    sAPGlobalInputTextIntoSAPElementpropCount++;
                }

                if (sAPGlobalInputTextIntoSAPElementtoggleUsesGlobalLeftMouseClickAgent != null)
                {
                    if (sAPGlobalInputTextIntoSAPElementtoggleUsesGlobalLeftMouseClickAgent != null)
                    {
                        sAPGlobalInputTextIntoSAPElement["ToggleUsesGlobalLeftMouseClickAgent"] = ExpressionConverter.ConvertO(sAPGlobalInputTextIntoSAPElementtoggleUsesGlobalLeftMouseClickAgent);
                        sAPGlobalInputTextIntoSAPElementpropCount++;
                    }

                    sAPGlobalInputTextIntoSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalInputTextIntoSAPElement["ToggleUsesGlobalLeftMouseClickAgent"] = true;
                    sAPGlobalInputTextIntoSAPElementpropCount++;
                }

                if (sAPGlobalInputTextIntoSAPElementtoggleDelay != null)
                {
                    if (sAPGlobalInputTextIntoSAPElementtoggleDelay != null)
                    {
                        sAPGlobalInputTextIntoSAPElement["ToggleDelay"] = ExpressionConverter.ConvertO(sAPGlobalInputTextIntoSAPElementtoggleDelay);
                        sAPGlobalInputTextIntoSAPElementpropCount++;
                    }

                    sAPGlobalInputTextIntoSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalInputTextIntoSAPElement["ToggleDelay"] = 0.5;
                    sAPGlobalInputTextIntoSAPElementpropCount++;
                }

                if (sAPGlobalInputTextIntoSAPElementglobalMouseClickOnElement != null)
                {
                    if (sAPGlobalInputTextIntoSAPElementglobalMouseClickOnElement != null)
                    {
                        sAPGlobalInputTextIntoSAPElement["GlobalMouseClickOnElement"] = ExpressionConverter.ConvertO(sAPGlobalInputTextIntoSAPElementglobalMouseClickOnElement);
                        sAPGlobalInputTextIntoSAPElementpropCount++;
                    }

                    sAPGlobalInputTextIntoSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalInputTextIntoSAPElement["GlobalMouseClickOnElement"] = true;
                    sAPGlobalInputTextIntoSAPElementpropCount++;
                }

                if (sAPGlobalInputTextIntoSAPElementreplaceExistingValueUsingDoubleClickDelete != null)
                {
                    if (sAPGlobalInputTextIntoSAPElementreplaceExistingValueUsingDoubleClickDelete != null)
                    {
                        sAPGlobalInputTextIntoSAPElement["ReplaceExistingValueUsingDoubleClickDelete"] = ExpressionConverter.ConvertO(sAPGlobalInputTextIntoSAPElementreplaceExistingValueUsingDoubleClickDelete);
                        sAPGlobalInputTextIntoSAPElementpropCount++;
                    }

                    sAPGlobalInputTextIntoSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalInputTextIntoSAPElement["ReplaceExistingValueUsingDoubleClickDelete"] = false;
                    sAPGlobalInputTextIntoSAPElementpropCount++;
                }

                if (sAPGlobalInputTextIntoSAPElementreplaceExistingValueUsingCTRLADelete != null)
                {
                    if (sAPGlobalInputTextIntoSAPElementreplaceExistingValueUsingCTRLADelete != null)
                    {
                        sAPGlobalInputTextIntoSAPElement["ReplaceExistingValueUsingCTRLADelete"] = ExpressionConverter.ConvertO(sAPGlobalInputTextIntoSAPElementreplaceExistingValueUsingCTRLADelete);
                        sAPGlobalInputTextIntoSAPElementpropCount++;
                    }

                    sAPGlobalInputTextIntoSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalInputTextIntoSAPElement["ReplaceExistingValueUsingCTRLADelete"] = false;
                    sAPGlobalInputTextIntoSAPElementpropCount++;
                }

                if (sAPGlobalInputTextIntoSAPElementtextToInput != null)
                {
                    sAPGlobalInputTextIntoSAPElement["TextToInput"] = ExpressionConverter.ConvertO(sAPGlobalInputTextIntoSAPElementtextToInput);
                    sAPGlobalInputTextIntoSAPElementpropCount++;
                }

                if (sAPGlobalInputTextIntoSAPElementsendKeyEvents != null)
                {
                    if (sAPGlobalInputTextIntoSAPElementsendKeyEvents != null)
                    {
                        sAPGlobalInputTextIntoSAPElement["SendKeyEvents"] = ExpressionConverter.ConvertO(sAPGlobalInputTextIntoSAPElementsendKeyEvents);
                        sAPGlobalInputTextIntoSAPElementpropCount++;
                    }

                    sAPGlobalInputTextIntoSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalInputTextIntoSAPElement["SendKeyEvents"] = false;
                    sAPGlobalInputTextIntoSAPElementpropCount++;
                }

                if (sAPGlobalInputTextIntoSAPElementkeyIntervalInMilliseconds != null)
                {
                    if (sAPGlobalInputTextIntoSAPElementkeyIntervalInMilliseconds != null)
                    {
                        sAPGlobalInputTextIntoSAPElement["KeyIntervalInMilliseconds"] = ExpressionConverter.ConvertO(sAPGlobalInputTextIntoSAPElementkeyIntervalInMilliseconds);
                        sAPGlobalInputTextIntoSAPElementpropCount++;
                    }

                    sAPGlobalInputTextIntoSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalInputTextIntoSAPElement["KeyIntervalInMilliseconds"] = 10;
                    sAPGlobalInputTextIntoSAPElementpropCount++;
                }

                if (sAPGlobalInputTextIntoSAPElementdoubleClickIntervalInMilliseconds != null)
                {
                    if (sAPGlobalInputTextIntoSAPElementdoubleClickIntervalInMilliseconds != null)
                    {
                        sAPGlobalInputTextIntoSAPElement["DoubleClickIntervalInMilliseconds"] = ExpressionConverter.ConvertO(sAPGlobalInputTextIntoSAPElementdoubleClickIntervalInMilliseconds);
                        sAPGlobalInputTextIntoSAPElementpropCount++;
                    }

                    sAPGlobalInputTextIntoSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalInputTextIntoSAPElement["DoubleClickIntervalInMilliseconds"] = 10;
                    sAPGlobalInputTextIntoSAPElementpropCount++;
                }

                if (sAPGlobalInputTextIntoSAPElementdontInterpretSymbols != null)
                {
                    if (sAPGlobalInputTextIntoSAPElementdontInterpretSymbols != null)
                    {
                        sAPGlobalInputTextIntoSAPElement["DontInterpretSymbols"] = ExpressionConverter.ConvertO(sAPGlobalInputTextIntoSAPElementdontInterpretSymbols);
                        sAPGlobalInputTextIntoSAPElementpropCount++;
                    }

                    sAPGlobalInputTextIntoSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalInputTextIntoSAPElement["DontInterpretSymbols"] = false;
                    sAPGlobalInputTextIntoSAPElementpropCount++;
                }

                sAPGlobalInputTextIntoSAPElementpropCount++;
                sAPGlobalInputTextIntoSAPElement["Workflow"] = ExpressionConverter.ConvertO(sAPGlobalInputTextIntoSAPElementworkflow);
                if (sAPGlobalInputTextIntoSAPElementpropCount > 0)
                {
                    callPayload.Body = sAPGlobalInputTextIntoSAPElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPGlobalInputPasswordIntoSAPElement))]
        public IWorkflowAction SAPGlobalInputPasswordIntoSAPElement([WorkflowExpression] Func<string> sAPGlobalInputPasswordIntoSAPElementsearchSAPElementId, [WorkflowExpression] Func<string> sAPGlobalInputPasswordIntoSAPElementpasswordToInput, [WorkflowExpression] Func<string> sAPGlobalInputPasswordIntoSAPElementworkflow, [WorkflowExpression] Func<bool> sAPGlobalInputPasswordIntoSAPElementsetElementWindowTopMost = null, [WorkflowExpression] Func<bool> sAPGlobalInputPasswordIntoSAPElementbringElementWindowToFront = null, [WorkflowExpression] Func<bool> sAPGlobalInputPasswordIntoSAPElementtoggleWindow = null, [WorkflowExpression] Func<bool> sAPGlobalInputPasswordIntoSAPElementtoggleUsesGlobalLeftMouseClickAgent = null, [WorkflowExpression] Func<double> sAPGlobalInputPasswordIntoSAPElementtoggleDelay = null, [WorkflowExpression] Func<bool> sAPGlobalInputPasswordIntoSAPElementglobalMouseClickOnElement = null, [WorkflowExpression] Func<bool> sAPGlobalInputPasswordIntoSAPElementreplaceExistingValueUsingDoubleClickDelete = null, [WorkflowExpression] Func<bool> sAPGlobalInputPasswordIntoSAPElementreplaceExistingValueUsingCTRLADelete = null, [WorkflowExpression] Func<bool> sAPGlobalInputPasswordIntoSAPElementsendKeyEvents = null, [WorkflowExpression] Func<int> sAPGlobalInputPasswordIntoSAPElementkeyIntervalInMilliseconds = null, [WorkflowExpression] Func<int> sAPGlobalInputPasswordIntoSAPElementdoubleClickIntervalInMilliseconds = null, [WorkflowExpression] Func<bool> sAPGlobalInputPasswordIntoSAPElementdontInterpretSymbols = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSAPGlobalInputPasswordIntoSAPElement(WorkflowValue<string> sAPGlobalInputPasswordIntoSAPElementsearchSAPElementId, WorkflowValue<string> sAPGlobalInputPasswordIntoSAPElementpasswordToInput, WorkflowValue<string> sAPGlobalInputPasswordIntoSAPElementworkflow, WorkflowValue<bool> sAPGlobalInputPasswordIntoSAPElementsetElementWindowTopMost = null, WorkflowValue<bool> sAPGlobalInputPasswordIntoSAPElementbringElementWindowToFront = null, WorkflowValue<bool> sAPGlobalInputPasswordIntoSAPElementtoggleWindow = null, WorkflowValue<bool> sAPGlobalInputPasswordIntoSAPElementtoggleUsesGlobalLeftMouseClickAgent = null, WorkflowValue<double> sAPGlobalInputPasswordIntoSAPElementtoggleDelay = null, WorkflowValue<bool> sAPGlobalInputPasswordIntoSAPElementglobalMouseClickOnElement = null, WorkflowValue<bool> sAPGlobalInputPasswordIntoSAPElementreplaceExistingValueUsingDoubleClickDelete = null, WorkflowValue<bool> sAPGlobalInputPasswordIntoSAPElementreplaceExistingValueUsingCTRLADelete = null, WorkflowValue<bool> sAPGlobalInputPasswordIntoSAPElementsendKeyEvents = null, WorkflowValue<int> sAPGlobalInputPasswordIntoSAPElementkeyIntervalInMilliseconds = null, WorkflowValue<int> sAPGlobalInputPasswordIntoSAPElementdoubleClickIntervalInMilliseconds = null, WorkflowValue<bool> sAPGlobalInputPasswordIntoSAPElementdontInterpretSymbols = null)
        {
            WorkflowValue.Validate(sAPGlobalInputPasswordIntoSAPElementsearchSAPElementId, nameof(sAPGlobalInputPasswordIntoSAPElementsearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPGlobalInputPasswordIntoSAPElementpasswordToInput, nameof(sAPGlobalInputPasswordIntoSAPElementpasswordToInput), required: true);
            WorkflowValue.Validate(sAPGlobalInputPasswordIntoSAPElementworkflow, nameof(sAPGlobalInputPasswordIntoSAPElementworkflow), required: true);
            WorkflowValue.Validate(sAPGlobalInputPasswordIntoSAPElementsetElementWindowTopMost, nameof(sAPGlobalInputPasswordIntoSAPElementsetElementWindowTopMost), required: false);
            WorkflowValue.Validate(sAPGlobalInputPasswordIntoSAPElementbringElementWindowToFront, nameof(sAPGlobalInputPasswordIntoSAPElementbringElementWindowToFront), required: false);
            WorkflowValue.Validate(sAPGlobalInputPasswordIntoSAPElementtoggleWindow, nameof(sAPGlobalInputPasswordIntoSAPElementtoggleWindow), required: false);
            WorkflowValue.Validate(sAPGlobalInputPasswordIntoSAPElementtoggleUsesGlobalLeftMouseClickAgent, nameof(sAPGlobalInputPasswordIntoSAPElementtoggleUsesGlobalLeftMouseClickAgent), required: false);
            WorkflowValue.Validate(sAPGlobalInputPasswordIntoSAPElementtoggleDelay, nameof(sAPGlobalInputPasswordIntoSAPElementtoggleDelay), required: false);
            WorkflowValue.Validate(sAPGlobalInputPasswordIntoSAPElementglobalMouseClickOnElement, nameof(sAPGlobalInputPasswordIntoSAPElementglobalMouseClickOnElement), required: false);
            WorkflowValue.Validate(sAPGlobalInputPasswordIntoSAPElementreplaceExistingValueUsingDoubleClickDelete, nameof(sAPGlobalInputPasswordIntoSAPElementreplaceExistingValueUsingDoubleClickDelete), required: false);
            WorkflowValue.Validate(sAPGlobalInputPasswordIntoSAPElementreplaceExistingValueUsingCTRLADelete, nameof(sAPGlobalInputPasswordIntoSAPElementreplaceExistingValueUsingCTRLADelete), required: false);
            WorkflowValue.Validate(sAPGlobalInputPasswordIntoSAPElementsendKeyEvents, nameof(sAPGlobalInputPasswordIntoSAPElementsendKeyEvents), required: false);
            WorkflowValue.Validate(sAPGlobalInputPasswordIntoSAPElementkeyIntervalInMilliseconds, nameof(sAPGlobalInputPasswordIntoSAPElementkeyIntervalInMilliseconds), required: false);
            WorkflowValue.Validate(sAPGlobalInputPasswordIntoSAPElementdoubleClickIntervalInMilliseconds, nameof(sAPGlobalInputPasswordIntoSAPElementdoubleClickIntervalInMilliseconds), required: false);
            WorkflowValue.Validate(sAPGlobalInputPasswordIntoSAPElementdontInterpretSymbols, nameof(sAPGlobalInputPasswordIntoSAPElementdontInterpretSymbols), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGlobalInputPasswordIntoSAPElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGlobalInputPasswordIntoSAPElement = new JObject();
                var sAPGlobalInputPasswordIntoSAPElementpropCount = 0;
                sAPGlobalInputPasswordIntoSAPElementpropCount++;
                sAPGlobalInputPasswordIntoSAPElement["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGlobalInputPasswordIntoSAPElementsearchSAPElementId);
                if (sAPGlobalInputPasswordIntoSAPElementsetElementWindowTopMost != null)
                {
                    if (sAPGlobalInputPasswordIntoSAPElementsetElementWindowTopMost != null)
                    {
                        sAPGlobalInputPasswordIntoSAPElement["SetElementWindowTopMost"] = ExpressionConverter.ConvertO(sAPGlobalInputPasswordIntoSAPElementsetElementWindowTopMost);
                        sAPGlobalInputPasswordIntoSAPElementpropCount++;
                    }

                    sAPGlobalInputPasswordIntoSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalInputPasswordIntoSAPElement["SetElementWindowTopMost"] = false;
                    sAPGlobalInputPasswordIntoSAPElementpropCount++;
                }

                if (sAPGlobalInputPasswordIntoSAPElementbringElementWindowToFront != null)
                {
                    if (sAPGlobalInputPasswordIntoSAPElementbringElementWindowToFront != null)
                    {
                        sAPGlobalInputPasswordIntoSAPElement["BringElementWindowToFront"] = ExpressionConverter.ConvertO(sAPGlobalInputPasswordIntoSAPElementbringElementWindowToFront);
                        sAPGlobalInputPasswordIntoSAPElementpropCount++;
                    }

                    sAPGlobalInputPasswordIntoSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalInputPasswordIntoSAPElement["BringElementWindowToFront"] = false;
                    sAPGlobalInputPasswordIntoSAPElementpropCount++;
                }

                if (sAPGlobalInputPasswordIntoSAPElementtoggleWindow != null)
                {
                    if (sAPGlobalInputPasswordIntoSAPElementtoggleWindow != null)
                    {
                        sAPGlobalInputPasswordIntoSAPElement["ToggleWindow"] = ExpressionConverter.ConvertO(sAPGlobalInputPasswordIntoSAPElementtoggleWindow);
                        sAPGlobalInputPasswordIntoSAPElementpropCount++;
                    }

                    sAPGlobalInputPasswordIntoSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalInputPasswordIntoSAPElement["ToggleWindow"] = true;
                    sAPGlobalInputPasswordIntoSAPElementpropCount++;
                }

                if (sAPGlobalInputPasswordIntoSAPElementtoggleUsesGlobalLeftMouseClickAgent != null)
                {
                    if (sAPGlobalInputPasswordIntoSAPElementtoggleUsesGlobalLeftMouseClickAgent != null)
                    {
                        sAPGlobalInputPasswordIntoSAPElement["ToggleUsesGlobalLeftMouseClickAgent"] = ExpressionConverter.ConvertO(sAPGlobalInputPasswordIntoSAPElementtoggleUsesGlobalLeftMouseClickAgent);
                        sAPGlobalInputPasswordIntoSAPElementpropCount++;
                    }

                    sAPGlobalInputPasswordIntoSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalInputPasswordIntoSAPElement["ToggleUsesGlobalLeftMouseClickAgent"] = true;
                    sAPGlobalInputPasswordIntoSAPElementpropCount++;
                }

                if (sAPGlobalInputPasswordIntoSAPElementtoggleDelay != null)
                {
                    if (sAPGlobalInputPasswordIntoSAPElementtoggleDelay != null)
                    {
                        sAPGlobalInputPasswordIntoSAPElement["ToggleDelay"] = ExpressionConverter.ConvertO(sAPGlobalInputPasswordIntoSAPElementtoggleDelay);
                        sAPGlobalInputPasswordIntoSAPElementpropCount++;
                    }

                    sAPGlobalInputPasswordIntoSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalInputPasswordIntoSAPElement["ToggleDelay"] = 0.5;
                    sAPGlobalInputPasswordIntoSAPElementpropCount++;
                }

                if (sAPGlobalInputPasswordIntoSAPElementglobalMouseClickOnElement != null)
                {
                    if (sAPGlobalInputPasswordIntoSAPElementglobalMouseClickOnElement != null)
                    {
                        sAPGlobalInputPasswordIntoSAPElement["GlobalMouseClickOnElement"] = ExpressionConverter.ConvertO(sAPGlobalInputPasswordIntoSAPElementglobalMouseClickOnElement);
                        sAPGlobalInputPasswordIntoSAPElementpropCount++;
                    }

                    sAPGlobalInputPasswordIntoSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalInputPasswordIntoSAPElement["GlobalMouseClickOnElement"] = true;
                    sAPGlobalInputPasswordIntoSAPElementpropCount++;
                }

                if (sAPGlobalInputPasswordIntoSAPElementreplaceExistingValueUsingDoubleClickDelete != null)
                {
                    if (sAPGlobalInputPasswordIntoSAPElementreplaceExistingValueUsingDoubleClickDelete != null)
                    {
                        sAPGlobalInputPasswordIntoSAPElement["ReplaceExistingValueUsingDoubleClickDelete"] = ExpressionConverter.ConvertO(sAPGlobalInputPasswordIntoSAPElementreplaceExistingValueUsingDoubleClickDelete);
                        sAPGlobalInputPasswordIntoSAPElementpropCount++;
                    }

                    sAPGlobalInputPasswordIntoSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalInputPasswordIntoSAPElement["ReplaceExistingValueUsingDoubleClickDelete"] = false;
                    sAPGlobalInputPasswordIntoSAPElementpropCount++;
                }

                if (sAPGlobalInputPasswordIntoSAPElementreplaceExistingValueUsingCTRLADelete != null)
                {
                    if (sAPGlobalInputPasswordIntoSAPElementreplaceExistingValueUsingCTRLADelete != null)
                    {
                        sAPGlobalInputPasswordIntoSAPElement["ReplaceExistingValueUsingCTRLADelete"] = ExpressionConverter.ConvertO(sAPGlobalInputPasswordIntoSAPElementreplaceExistingValueUsingCTRLADelete);
                        sAPGlobalInputPasswordIntoSAPElementpropCount++;
                    }

                    sAPGlobalInputPasswordIntoSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalInputPasswordIntoSAPElement["ReplaceExistingValueUsingCTRLADelete"] = false;
                    sAPGlobalInputPasswordIntoSAPElementpropCount++;
                }

                sAPGlobalInputPasswordIntoSAPElementpropCount++;
                sAPGlobalInputPasswordIntoSAPElement["PasswordToInput"] = ExpressionConverter.ConvertO(sAPGlobalInputPasswordIntoSAPElementpasswordToInput);
                if (sAPGlobalInputPasswordIntoSAPElementsendKeyEvents != null)
                {
                    if (sAPGlobalInputPasswordIntoSAPElementsendKeyEvents != null)
                    {
                        sAPGlobalInputPasswordIntoSAPElement["SendKeyEvents"] = ExpressionConverter.ConvertO(sAPGlobalInputPasswordIntoSAPElementsendKeyEvents);
                        sAPGlobalInputPasswordIntoSAPElementpropCount++;
                    }

                    sAPGlobalInputPasswordIntoSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalInputPasswordIntoSAPElement["SendKeyEvents"] = false;
                    sAPGlobalInputPasswordIntoSAPElementpropCount++;
                }

                if (sAPGlobalInputPasswordIntoSAPElementkeyIntervalInMilliseconds != null)
                {
                    if (sAPGlobalInputPasswordIntoSAPElementkeyIntervalInMilliseconds != null)
                    {
                        sAPGlobalInputPasswordIntoSAPElement["KeyIntervalInMilliseconds"] = ExpressionConverter.ConvertO(sAPGlobalInputPasswordIntoSAPElementkeyIntervalInMilliseconds);
                        sAPGlobalInputPasswordIntoSAPElementpropCount++;
                    }

                    sAPGlobalInputPasswordIntoSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalInputPasswordIntoSAPElement["KeyIntervalInMilliseconds"] = 10;
                    sAPGlobalInputPasswordIntoSAPElementpropCount++;
                }

                if (sAPGlobalInputPasswordIntoSAPElementdoubleClickIntervalInMilliseconds != null)
                {
                    if (sAPGlobalInputPasswordIntoSAPElementdoubleClickIntervalInMilliseconds != null)
                    {
                        sAPGlobalInputPasswordIntoSAPElement["DoubleClickIntervalInMilliseconds"] = ExpressionConverter.ConvertO(sAPGlobalInputPasswordIntoSAPElementdoubleClickIntervalInMilliseconds);
                        sAPGlobalInputPasswordIntoSAPElementpropCount++;
                    }

                    sAPGlobalInputPasswordIntoSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalInputPasswordIntoSAPElement["DoubleClickIntervalInMilliseconds"] = 10;
                    sAPGlobalInputPasswordIntoSAPElementpropCount++;
                }

                if (sAPGlobalInputPasswordIntoSAPElementdontInterpretSymbols != null)
                {
                    if (sAPGlobalInputPasswordIntoSAPElementdontInterpretSymbols != null)
                    {
                        sAPGlobalInputPasswordIntoSAPElement["DontInterpretSymbols"] = ExpressionConverter.ConvertO(sAPGlobalInputPasswordIntoSAPElementdontInterpretSymbols);
                        sAPGlobalInputPasswordIntoSAPElementpropCount++;
                    }

                    sAPGlobalInputPasswordIntoSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalInputPasswordIntoSAPElement["DontInterpretSymbols"] = false;
                    sAPGlobalInputPasswordIntoSAPElementpropCount++;
                }

                sAPGlobalInputPasswordIntoSAPElementpropCount++;
                sAPGlobalInputPasswordIntoSAPElement["Workflow"] = ExpressionConverter.ConvertO(sAPGlobalInputPasswordIntoSAPElementworkflow);
                if (sAPGlobalInputPasswordIntoSAPElementpropCount > 0)
                {
                    callPayload.Body = sAPGlobalInputPasswordIntoSAPElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPSetListSelectionByName))]
        public IWorkflowAction SAPSetListSelectionByName([WorkflowExpression] Func<string> sAPSetListSelectionByNamesearchSAPElementId, [WorkflowExpression] Func<string> sAPSetListSelectionByNamelistItemName, [WorkflowExpression] Func<string> sAPSetListSelectionByNameworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSAPSetListSelectionByName(WorkflowValue<string> sAPSetListSelectionByNamesearchSAPElementId, WorkflowValue<string> sAPSetListSelectionByNamelistItemName, WorkflowValue<string> sAPSetListSelectionByNameworkflow)
        {
            WorkflowValue.Validate(sAPSetListSelectionByNamesearchSAPElementId, nameof(sAPSetListSelectionByNamesearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPSetListSelectionByNamelistItemName, nameof(sAPSetListSelectionByNamelistItemName), required: true);
            WorkflowValue.Validate(sAPSetListSelectionByNameworkflow, nameof(sAPSetListSelectionByNameworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSetListSelectionByName";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPSetListSelectionByName = new JObject();
                var sAPSetListSelectionByNamepropCount = 0;
                sAPSetListSelectionByNamepropCount++;
                sAPSetListSelectionByName["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPSetListSelectionByNamesearchSAPElementId);
                sAPSetListSelectionByNamepropCount++;
                sAPSetListSelectionByName["ListItemName"] = ExpressionConverter.ConvertO(sAPSetListSelectionByNamelistItemName);
                sAPSetListSelectionByNamepropCount++;
                sAPSetListSelectionByName["Workflow"] = ExpressionConverter.ConvertO(sAPSetListSelectionByNameworkflow);
                if (sAPSetListSelectionByNamepropCount > 0)
                {
                    callPayload.Body = sAPSetListSelectionByName;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPSetListSelectionByKey))]
        public IWorkflowAction SAPSetListSelectionByKey([WorkflowExpression] Func<string> sAPSetListSelectionByKeysearchSAPElementId, [WorkflowExpression] Func<string> sAPSetListSelectionByKeylistItemKey, [WorkflowExpression] Func<string> sAPSetListSelectionByKeyworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSAPSetListSelectionByKey(WorkflowValue<string> sAPSetListSelectionByKeysearchSAPElementId, WorkflowValue<string> sAPSetListSelectionByKeylistItemKey, WorkflowValue<string> sAPSetListSelectionByKeyworkflow)
        {
            WorkflowValue.Validate(sAPSetListSelectionByKeysearchSAPElementId, nameof(sAPSetListSelectionByKeysearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPSetListSelectionByKeylistItemKey, nameof(sAPSetListSelectionByKeylistItemKey), required: true);
            WorkflowValue.Validate(sAPSetListSelectionByKeyworkflow, nameof(sAPSetListSelectionByKeyworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSetListSelectionByKey";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPSetListSelectionByKey = new JObject();
                var sAPSetListSelectionByKeypropCount = 0;
                sAPSetListSelectionByKeypropCount++;
                sAPSetListSelectionByKey["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPSetListSelectionByKeysearchSAPElementId);
                sAPSetListSelectionByKeypropCount++;
                sAPSetListSelectionByKey["ListItemKey"] = ExpressionConverter.ConvertO(sAPSetListSelectionByKeylistItemKey);
                sAPSetListSelectionByKeypropCount++;
                sAPSetListSelectionByKey["Workflow"] = ExpressionConverter.ConvertO(sAPSetListSelectionByKeyworkflow);
                if (sAPSetListSelectionByKeypropCount > 0)
                {
                    callPayload.Body = sAPSetListSelectionByKey;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPGetListSelectionElementItems))]
        public IBodyWorkflowAction<SAPGetListSelectionElementItemsResponse> SAPGetListSelectionElementItems([WorkflowExpression] Func<string> sAPGetListSelectionElementItemssearchSAPElementId, [WorkflowExpression] Func<string> sAPGetListSelectionElementItemsworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SAPGetListSelectionElementItemsResponse> __BuildSAPGetListSelectionElementItems(WorkflowValue<string> sAPGetListSelectionElementItemssearchSAPElementId, WorkflowValue<string> sAPGetListSelectionElementItemsworkflow)
        {
            WorkflowValue.Validate(sAPGetListSelectionElementItemssearchSAPElementId, nameof(sAPGetListSelectionElementItemssearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPGetListSelectionElementItemsworkflow, nameof(sAPGetListSelectionElementItemsworkflow), required: true);
            return new DeferredBodyAction<SAPGetListSelectionElementItemsResponse>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetListSelectionElementItems";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGetListSelectionElementItems = new JObject();
                var sAPGetListSelectionElementItemspropCount = 0;
                sAPGetListSelectionElementItemspropCount++;
                sAPGetListSelectionElementItems["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGetListSelectionElementItemssearchSAPElementId);
                sAPGetListSelectionElementItemspropCount++;
                sAPGetListSelectionElementItems["Workflow"] = ExpressionConverter.ConvertO(sAPGetListSelectionElementItemsworkflow);
                if (sAPGetListSelectionElementItemspropCount > 0)
                {
                    callPayload.Body = sAPGetListSelectionElementItems;
                }

                return new ApiConnectionAction<SAPGetListSelectionElementItemsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPGetAllChildSAPElementProperties))]
        public IBodyWorkflowAction<SAPGetAllChildSAPElementPropertiesResponse> SAPGetAllChildSAPElementProperties([WorkflowExpression] Func<string> sAPGetAllChildSAPElementPropertiessearchSAPElementId, [WorkflowExpression] Func<string> sAPGetAllChildSAPElementPropertiesworkflow, [WorkflowExpression] Func<int> sAPGetAllChildSAPElementPropertiesfirstItemToReturn = null, [WorkflowExpression] Func<int> sAPGetAllChildSAPElementPropertiesmaxItemsToReturn = null, [WorkflowExpression] Func<string> sAPGetAllChildSAPElementPropertiessearchSAPElementType = null, [WorkflowExpression] Func<int> sAPGetAllChildSAPElementPropertiesmaxTextLength = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SAPGetAllChildSAPElementPropertiesResponse> __BuildSAPGetAllChildSAPElementProperties(WorkflowValue<string> sAPGetAllChildSAPElementPropertiessearchSAPElementId, WorkflowValue<string> sAPGetAllChildSAPElementPropertiesworkflow, WorkflowValue<int> sAPGetAllChildSAPElementPropertiesfirstItemToReturn = null, WorkflowValue<int> sAPGetAllChildSAPElementPropertiesmaxItemsToReturn = null, WorkflowValue<string> sAPGetAllChildSAPElementPropertiessearchSAPElementType = null, WorkflowValue<int> sAPGetAllChildSAPElementPropertiesmaxTextLength = null)
        {
            WorkflowValue.Validate(sAPGetAllChildSAPElementPropertiessearchSAPElementId, nameof(sAPGetAllChildSAPElementPropertiessearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPGetAllChildSAPElementPropertiesworkflow, nameof(sAPGetAllChildSAPElementPropertiesworkflow), required: true);
            WorkflowValue.Validate(sAPGetAllChildSAPElementPropertiesfirstItemToReturn, nameof(sAPGetAllChildSAPElementPropertiesfirstItemToReturn), required: false);
            WorkflowValue.Validate(sAPGetAllChildSAPElementPropertiesmaxItemsToReturn, nameof(sAPGetAllChildSAPElementPropertiesmaxItemsToReturn), required: false);
            WorkflowValue.Validate(sAPGetAllChildSAPElementPropertiessearchSAPElementType, nameof(sAPGetAllChildSAPElementPropertiessearchSAPElementType), required: false);
            WorkflowValue.Validate(sAPGetAllChildSAPElementPropertiesmaxTextLength, nameof(sAPGetAllChildSAPElementPropertiesmaxTextLength), required: false);
            return new DeferredBodyAction<SAPGetAllChildSAPElementPropertiesResponse>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetAllChildSAPElementProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGetAllChildSAPElementProperties = new JObject();
                var sAPGetAllChildSAPElementPropertiespropCount = 0;
                sAPGetAllChildSAPElementPropertiespropCount++;
                sAPGetAllChildSAPElementProperties["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGetAllChildSAPElementPropertiessearchSAPElementId);
                if (sAPGetAllChildSAPElementPropertiesfirstItemToReturn != null)
                {
                    if (sAPGetAllChildSAPElementPropertiesfirstItemToReturn != null)
                    {
                        sAPGetAllChildSAPElementProperties["FirstItemToReturn"] = ExpressionConverter.ConvertO(sAPGetAllChildSAPElementPropertiesfirstItemToReturn);
                        sAPGetAllChildSAPElementPropertiespropCount++;
                    }

                    sAPGetAllChildSAPElementPropertiespropCount++;
                }
                else
                {
                    sAPGetAllChildSAPElementProperties["FirstItemToReturn"] = 1;
                    sAPGetAllChildSAPElementPropertiespropCount++;
                }

                if (sAPGetAllChildSAPElementPropertiesmaxItemsToReturn != null)
                {
                    if (sAPGetAllChildSAPElementPropertiesmaxItemsToReturn != null)
                    {
                        sAPGetAllChildSAPElementProperties["MaxItemsToReturn"] = ExpressionConverter.ConvertO(sAPGetAllChildSAPElementPropertiesmaxItemsToReturn);
                        sAPGetAllChildSAPElementPropertiespropCount++;
                    }

                    sAPGetAllChildSAPElementPropertiespropCount++;
                }
                else
                {
                    sAPGetAllChildSAPElementProperties["MaxItemsToReturn"] = 0;
                    sAPGetAllChildSAPElementPropertiespropCount++;
                }

                if (sAPGetAllChildSAPElementPropertiessearchSAPElementType != null)
                {
                    sAPGetAllChildSAPElementProperties["SearchSAPElementType"] = ExpressionConverter.ConvertO(sAPGetAllChildSAPElementPropertiessearchSAPElementType);
                    sAPGetAllChildSAPElementPropertiespropCount++;
                }

                if (sAPGetAllChildSAPElementPropertiesmaxTextLength != null)
                {
                    if (sAPGetAllChildSAPElementPropertiesmaxTextLength != null)
                    {
                        sAPGetAllChildSAPElementProperties["MaxTextLength"] = ExpressionConverter.ConvertO(sAPGetAllChildSAPElementPropertiesmaxTextLength);
                        sAPGetAllChildSAPElementPropertiespropCount++;
                    }

                    sAPGetAllChildSAPElementPropertiespropCount++;
                }
                else
                {
                    sAPGetAllChildSAPElementProperties["MaxTextLength"] = 0;
                    sAPGetAllChildSAPElementPropertiespropCount++;
                }

                sAPGetAllChildSAPElementPropertiespropCount++;
                sAPGetAllChildSAPElementProperties["Workflow"] = ExpressionConverter.ConvertO(sAPGetAllChildSAPElementPropertiesworkflow);
                if (sAPGetAllChildSAPElementPropertiespropCount > 0)
                {
                    callPayload.Body = sAPGetAllChildSAPElementProperties;
                }

                return new ApiConnectionAction<SAPGetAllChildSAPElementPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPGetSAPSessionTopLevelSAPElementProperties))]
        public IBodyWorkflowAction<SAPGetSAPSessionTopLevelSAPElementPropertiesResponse> SAPGetSAPSessionTopLevelSAPElementProperties([WorkflowExpression] Func<string> sAPGetSAPSessionTopLevelSAPElementPropertiesworkflow, [WorkflowExpression] Func<int> sAPGetSAPSessionTopLevelSAPElementPropertiesfirstItemToReturn = null, [WorkflowExpression] Func<int> sAPGetSAPSessionTopLevelSAPElementPropertiesmaxItemsToReturn = null, [WorkflowExpression] Func<string> sAPGetSAPSessionTopLevelSAPElementPropertiessearchSAPElementType = null, [WorkflowExpression] Func<int> sAPGetSAPSessionTopLevelSAPElementPropertiesmaxTextLength = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SAPGetSAPSessionTopLevelSAPElementPropertiesResponse> __BuildSAPGetSAPSessionTopLevelSAPElementProperties(WorkflowValue<string> sAPGetSAPSessionTopLevelSAPElementPropertiesworkflow, WorkflowValue<int> sAPGetSAPSessionTopLevelSAPElementPropertiesfirstItemToReturn = null, WorkflowValue<int> sAPGetSAPSessionTopLevelSAPElementPropertiesmaxItemsToReturn = null, WorkflowValue<string> sAPGetSAPSessionTopLevelSAPElementPropertiessearchSAPElementType = null, WorkflowValue<int> sAPGetSAPSessionTopLevelSAPElementPropertiesmaxTextLength = null)
        {
            WorkflowValue.Validate(sAPGetSAPSessionTopLevelSAPElementPropertiesworkflow, nameof(sAPGetSAPSessionTopLevelSAPElementPropertiesworkflow), required: true);
            WorkflowValue.Validate(sAPGetSAPSessionTopLevelSAPElementPropertiesfirstItemToReturn, nameof(sAPGetSAPSessionTopLevelSAPElementPropertiesfirstItemToReturn), required: false);
            WorkflowValue.Validate(sAPGetSAPSessionTopLevelSAPElementPropertiesmaxItemsToReturn, nameof(sAPGetSAPSessionTopLevelSAPElementPropertiesmaxItemsToReturn), required: false);
            WorkflowValue.Validate(sAPGetSAPSessionTopLevelSAPElementPropertiessearchSAPElementType, nameof(sAPGetSAPSessionTopLevelSAPElementPropertiessearchSAPElementType), required: false);
            WorkflowValue.Validate(sAPGetSAPSessionTopLevelSAPElementPropertiesmaxTextLength, nameof(sAPGetSAPSessionTopLevelSAPElementPropertiesmaxTextLength), required: false);
            return new DeferredBodyAction<SAPGetSAPSessionTopLevelSAPElementPropertiesResponse>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetSAPSessionTopLevelSAPElementProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGetSAPSessionTopLevelSAPElementProperties = new JObject();
                var sAPGetSAPSessionTopLevelSAPElementPropertiespropCount = 0;
                if (sAPGetSAPSessionTopLevelSAPElementPropertiesfirstItemToReturn != null)
                {
                    if (sAPGetSAPSessionTopLevelSAPElementPropertiesfirstItemToReturn != null)
                    {
                        sAPGetSAPSessionTopLevelSAPElementProperties["FirstItemToReturn"] = ExpressionConverter.ConvertO(sAPGetSAPSessionTopLevelSAPElementPropertiesfirstItemToReturn);
                        sAPGetSAPSessionTopLevelSAPElementPropertiespropCount++;
                    }

                    sAPGetSAPSessionTopLevelSAPElementPropertiespropCount++;
                }
                else
                {
                    sAPGetSAPSessionTopLevelSAPElementProperties["FirstItemToReturn"] = 1;
                    sAPGetSAPSessionTopLevelSAPElementPropertiespropCount++;
                }

                if (sAPGetSAPSessionTopLevelSAPElementPropertiesmaxItemsToReturn != null)
                {
                    if (sAPGetSAPSessionTopLevelSAPElementPropertiesmaxItemsToReturn != null)
                    {
                        sAPGetSAPSessionTopLevelSAPElementProperties["MaxItemsToReturn"] = ExpressionConverter.ConvertO(sAPGetSAPSessionTopLevelSAPElementPropertiesmaxItemsToReturn);
                        sAPGetSAPSessionTopLevelSAPElementPropertiespropCount++;
                    }

                    sAPGetSAPSessionTopLevelSAPElementPropertiespropCount++;
                }
                else
                {
                    sAPGetSAPSessionTopLevelSAPElementProperties["MaxItemsToReturn"] = 0;
                    sAPGetSAPSessionTopLevelSAPElementPropertiespropCount++;
                }

                if (sAPGetSAPSessionTopLevelSAPElementPropertiessearchSAPElementType != null)
                {
                    sAPGetSAPSessionTopLevelSAPElementProperties["SearchSAPElementType"] = ExpressionConverter.ConvertO(sAPGetSAPSessionTopLevelSAPElementPropertiessearchSAPElementType);
                    sAPGetSAPSessionTopLevelSAPElementPropertiespropCount++;
                }

                if (sAPGetSAPSessionTopLevelSAPElementPropertiesmaxTextLength != null)
                {
                    if (sAPGetSAPSessionTopLevelSAPElementPropertiesmaxTextLength != null)
                    {
                        sAPGetSAPSessionTopLevelSAPElementProperties["MaxTextLength"] = ExpressionConverter.ConvertO(sAPGetSAPSessionTopLevelSAPElementPropertiesmaxTextLength);
                        sAPGetSAPSessionTopLevelSAPElementPropertiespropCount++;
                    }

                    sAPGetSAPSessionTopLevelSAPElementPropertiespropCount++;
                }
                else
                {
                    sAPGetSAPSessionTopLevelSAPElementProperties["MaxTextLength"] = 0;
                    sAPGetSAPSessionTopLevelSAPElementPropertiespropCount++;
                }

                sAPGetSAPSessionTopLevelSAPElementPropertiespropCount++;
                sAPGetSAPSessionTopLevelSAPElementProperties["Workflow"] = ExpressionConverter.ConvertO(sAPGetSAPSessionTopLevelSAPElementPropertiesworkflow);
                if (sAPGetSAPSessionTopLevelSAPElementPropertiespropCount > 0)
                {
                    callPayload.Body = sAPGetSAPSessionTopLevelSAPElementProperties;
                }

                return new ApiConnectionAction<SAPGetSAPSessionTopLevelSAPElementPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPGetSAPElementParentId))]
        public IBodyWorkflowAction<SAPGetSAPElementParentIdResponse> SAPGetSAPElementParentId([WorkflowExpression] Func<string> sAPGetSAPElementParentIdsearchSAPElementId, [WorkflowExpression] Func<string> sAPGetSAPElementParentIdworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SAPGetSAPElementParentIdResponse> __BuildSAPGetSAPElementParentId(WorkflowValue<string> sAPGetSAPElementParentIdsearchSAPElementId, WorkflowValue<string> sAPGetSAPElementParentIdworkflow)
        {
            WorkflowValue.Validate(sAPGetSAPElementParentIdsearchSAPElementId, nameof(sAPGetSAPElementParentIdsearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPGetSAPElementParentIdworkflow, nameof(sAPGetSAPElementParentIdworkflow), required: true);
            return new DeferredBodyAction<SAPGetSAPElementParentIdResponse>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetSAPElementParentId";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGetSAPElementParentId = new JObject();
                var sAPGetSAPElementParentIdpropCount = 0;
                sAPGetSAPElementParentIdpropCount++;
                sAPGetSAPElementParentId["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGetSAPElementParentIdsearchSAPElementId);
                sAPGetSAPElementParentIdpropCount++;
                sAPGetSAPElementParentId["Workflow"] = ExpressionConverter.ConvertO(sAPGetSAPElementParentIdworkflow);
                if (sAPGetSAPElementParentIdpropCount > 0)
                {
                    callPayload.Body = sAPGetSAPElementParentId;
                }

                return new ApiConnectionAction<SAPGetSAPElementParentIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPGetElementPropertiesAsList))]
        public IBodyWorkflowAction<SAPGetElementPropertiesAsListResponse> SAPGetElementPropertiesAsList([WorkflowExpression] Func<string> sAPGetElementPropertiesAsListsearchSAPElementId, [WorkflowExpression] Func<string> sAPGetElementPropertiesAsListworkflow, [WorkflowExpression] Func<int> sAPGetElementPropertiesAsListmaxTextLength = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SAPGetElementPropertiesAsListResponse> __BuildSAPGetElementPropertiesAsList(WorkflowValue<string> sAPGetElementPropertiesAsListsearchSAPElementId, WorkflowValue<string> sAPGetElementPropertiesAsListworkflow, WorkflowValue<int> sAPGetElementPropertiesAsListmaxTextLength = null)
        {
            WorkflowValue.Validate(sAPGetElementPropertiesAsListsearchSAPElementId, nameof(sAPGetElementPropertiesAsListsearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPGetElementPropertiesAsListworkflow, nameof(sAPGetElementPropertiesAsListworkflow), required: true);
            WorkflowValue.Validate(sAPGetElementPropertiesAsListmaxTextLength, nameof(sAPGetElementPropertiesAsListmaxTextLength), required: false);
            return new DeferredBodyAction<SAPGetElementPropertiesAsListResponse>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetElementPropertiesAsList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGetElementPropertiesAsList = new JObject();
                var sAPGetElementPropertiesAsListpropCount = 0;
                sAPGetElementPropertiesAsListpropCount++;
                sAPGetElementPropertiesAsList["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGetElementPropertiesAsListsearchSAPElementId);
                if (sAPGetElementPropertiesAsListmaxTextLength != null)
                {
                    if (sAPGetElementPropertiesAsListmaxTextLength != null)
                    {
                        sAPGetElementPropertiesAsList["MaxTextLength"] = ExpressionConverter.ConvertO(sAPGetElementPropertiesAsListmaxTextLength);
                        sAPGetElementPropertiesAsListpropCount++;
                    }

                    sAPGetElementPropertiesAsListpropCount++;
                }
                else
                {
                    sAPGetElementPropertiesAsList["MaxTextLength"] = 0;
                    sAPGetElementPropertiesAsListpropCount++;
                }

                sAPGetElementPropertiesAsListpropCount++;
                sAPGetElementPropertiesAsList["Workflow"] = ExpressionConverter.ConvertO(sAPGetElementPropertiesAsListworkflow);
                if (sAPGetElementPropertiesAsListpropCount > 0)
                {
                    callPayload.Body = sAPGetElementPropertiesAsList;
                }

                return new ApiConnectionAction<SAPGetElementPropertiesAsListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPGetSAPElementAtScreenCoordinate))]
        public IBodyWorkflowAction<SAPGetSAPElementAtScreenCoordinateResponse> SAPGetSAPElementAtScreenCoordinate([WorkflowExpression] Func<int> sAPGetSAPElementAtScreenCoordinatescreenX, [WorkflowExpression] Func<int> sAPGetSAPElementAtScreenCoordinatescreenY, [WorkflowExpression] Func<string> sAPGetSAPElementAtScreenCoordinateworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SAPGetSAPElementAtScreenCoordinateResponse> __BuildSAPGetSAPElementAtScreenCoordinate(WorkflowValue<int> sAPGetSAPElementAtScreenCoordinatescreenX, WorkflowValue<int> sAPGetSAPElementAtScreenCoordinatescreenY, WorkflowValue<string> sAPGetSAPElementAtScreenCoordinateworkflow)
        {
            WorkflowValue.Validate(sAPGetSAPElementAtScreenCoordinatescreenX, nameof(sAPGetSAPElementAtScreenCoordinatescreenX), required: true);
            WorkflowValue.Validate(sAPGetSAPElementAtScreenCoordinatescreenY, nameof(sAPGetSAPElementAtScreenCoordinatescreenY), required: true);
            WorkflowValue.Validate(sAPGetSAPElementAtScreenCoordinateworkflow, nameof(sAPGetSAPElementAtScreenCoordinateworkflow), required: true);
            return new DeferredBodyAction<SAPGetSAPElementAtScreenCoordinateResponse>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetSAPElementAtScreenCoordinate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGetSAPElementAtScreenCoordinate = new JObject();
                var sAPGetSAPElementAtScreenCoordinatepropCount = 0;
                sAPGetSAPElementAtScreenCoordinatepropCount++;
                sAPGetSAPElementAtScreenCoordinate["ScreenX"] = ExpressionConverter.ConvertO(sAPGetSAPElementAtScreenCoordinatescreenX);
                sAPGetSAPElementAtScreenCoordinatepropCount++;
                sAPGetSAPElementAtScreenCoordinate["ScreenY"] = ExpressionConverter.ConvertO(sAPGetSAPElementAtScreenCoordinatescreenY);
                sAPGetSAPElementAtScreenCoordinatepropCount++;
                sAPGetSAPElementAtScreenCoordinate["Workflow"] = ExpressionConverter.ConvertO(sAPGetSAPElementAtScreenCoordinateworkflow);
                if (sAPGetSAPElementAtScreenCoordinatepropCount > 0)
                {
                    callPayload.Body = sAPGetSAPElementAtScreenCoordinate;
                }

                return new ApiConnectionAction<SAPGetSAPElementAtScreenCoordinateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPOpenConnection))]
        public IBodyWorkflowAction<SAPOpenConnectionResponse> SAPOpenConnection([WorkflowExpression] Func<string> sAPOpenConnectionworkflow, [WorkflowExpression] Func<string> sAPOpenConnectionsAPConnectionDescription = null, [WorkflowExpression] Func<string> sAPOpenConnectionsAPConnectionAddress = null, [WorkflowExpression] Func<bool> sAPOpenConnectionconnectSynchronous = null, [WorkflowExpression] Func<bool> sAPOpenConnectionconnectToSession = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SAPOpenConnectionResponse> __BuildSAPOpenConnection(WorkflowValue<string> sAPOpenConnectionworkflow, WorkflowValue<string> sAPOpenConnectionsAPConnectionDescription = null, WorkflowValue<string> sAPOpenConnectionsAPConnectionAddress = null, WorkflowValue<bool> sAPOpenConnectionconnectSynchronous = null, WorkflowValue<bool> sAPOpenConnectionconnectToSession = null)
        {
            WorkflowValue.Validate(sAPOpenConnectionworkflow, nameof(sAPOpenConnectionworkflow), required: true);
            WorkflowValue.Validate(sAPOpenConnectionsAPConnectionDescription, nameof(sAPOpenConnectionsAPConnectionDescription), required: false);
            WorkflowValue.Validate(sAPOpenConnectionsAPConnectionAddress, nameof(sAPOpenConnectionsAPConnectionAddress), required: false);
            WorkflowValue.Validate(sAPOpenConnectionconnectSynchronous, nameof(sAPOpenConnectionconnectSynchronous), required: false);
            WorkflowValue.Validate(sAPOpenConnectionconnectToSession, nameof(sAPOpenConnectionconnectToSession), required: false);
            return new DeferredBodyAction<SAPOpenConnectionResponse>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPOpenConnection";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPOpenConnection = new JObject();
                var sAPOpenConnectionpropCount = 0;
                if (sAPOpenConnectionsAPConnectionDescription != null)
                {
                    sAPOpenConnection["SAPConnectionDescription"] = ExpressionConverter.ConvertO(sAPOpenConnectionsAPConnectionDescription);
                    sAPOpenConnectionpropCount++;
                }

                if (sAPOpenConnectionsAPConnectionAddress != null)
                {
                    sAPOpenConnection["SAPConnectionAddress"] = ExpressionConverter.ConvertO(sAPOpenConnectionsAPConnectionAddress);
                    sAPOpenConnectionpropCount++;
                }

                if (sAPOpenConnectionconnectSynchronous != null)
                {
                    if (sAPOpenConnectionconnectSynchronous != null)
                    {
                        sAPOpenConnection["ConnectSynchronous"] = ExpressionConverter.ConvertO(sAPOpenConnectionconnectSynchronous);
                        sAPOpenConnectionpropCount++;
                    }

                    sAPOpenConnectionpropCount++;
                }
                else
                {
                    sAPOpenConnection["ConnectSynchronous"] = true;
                    sAPOpenConnectionpropCount++;
                }

                if (sAPOpenConnectionconnectToSession != null)
                {
                    if (sAPOpenConnectionconnectToSession != null)
                    {
                        sAPOpenConnection["ConnectToSession"] = ExpressionConverter.ConvertO(sAPOpenConnectionconnectToSession);
                        sAPOpenConnectionpropCount++;
                    }

                    sAPOpenConnectionpropCount++;
                }
                else
                {
                    sAPOpenConnection["ConnectToSession"] = true;
                    sAPOpenConnectionpropCount++;
                }

                sAPOpenConnectionpropCount++;
                sAPOpenConnection["Workflow"] = ExpressionConverter.ConvertO(sAPOpenConnectionworkflow);
                if (sAPOpenConnectionpropCount > 0)
                {
                    callPayload.Body = sAPOpenConnection;
                }

                return new ApiConnectionAction<SAPOpenConnectionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPGetSAPTableProperties))]
        public IBodyWorkflowAction<SAPGetSAPTablePropertiesResponse> SAPGetSAPTableProperties([WorkflowExpression] Func<string> sAPGetSAPTablePropertiessearchSAPElementId, [WorkflowExpression] Func<string> sAPGetSAPTablePropertiesworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SAPGetSAPTablePropertiesResponse> __BuildSAPGetSAPTableProperties(WorkflowValue<string> sAPGetSAPTablePropertiessearchSAPElementId, WorkflowValue<string> sAPGetSAPTablePropertiesworkflow)
        {
            WorkflowValue.Validate(sAPGetSAPTablePropertiessearchSAPElementId, nameof(sAPGetSAPTablePropertiessearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPGetSAPTablePropertiesworkflow, nameof(sAPGetSAPTablePropertiesworkflow), required: true);
            return new DeferredBodyAction<SAPGetSAPTablePropertiesResponse>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetSAPTableProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGetSAPTableProperties = new JObject();
                var sAPGetSAPTablePropertiespropCount = 0;
                sAPGetSAPTablePropertiespropCount++;
                sAPGetSAPTableProperties["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGetSAPTablePropertiessearchSAPElementId);
                sAPGetSAPTablePropertiespropCount++;
                sAPGetSAPTableProperties["Workflow"] = ExpressionConverter.ConvertO(sAPGetSAPTablePropertiesworkflow);
                if (sAPGetSAPTablePropertiespropCount > 0)
                {
                    callPayload.Body = sAPGetSAPTableProperties;
                }

                return new ApiConnectionAction<SAPGetSAPTablePropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPGetSAPTableVisibleCellTextContentsAtIndex))]
        public IBodyWorkflowAction<SAPGetSAPTableVisibleCellTextContentsAtIndexResponse> SAPGetSAPTableVisibleCellTextContentsAtIndex([WorkflowExpression] Func<string> sAPGetSAPTableVisibleCellTextContentsAtIndexsearchSAPElementId, [WorkflowExpression] Func<string> sAPGetSAPTableVisibleCellTextContentsAtIndexworkflow, [WorkflowExpression] Func<int> sAPGetSAPTableVisibleCellTextContentsAtIndexvisibleRowIndex = null, [WorkflowExpression] Func<int> sAPGetSAPTableVisibleCellTextContentsAtIndexvisibleColumnIndex = null, [WorkflowExpression] Func<string> sAPGetSAPTableVisibleCellTextContentsAtIndexcheckedElementValue = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SAPGetSAPTableVisibleCellTextContentsAtIndexResponse> __BuildSAPGetSAPTableVisibleCellTextContentsAtIndex(WorkflowValue<string> sAPGetSAPTableVisibleCellTextContentsAtIndexsearchSAPElementId, WorkflowValue<string> sAPGetSAPTableVisibleCellTextContentsAtIndexworkflow, WorkflowValue<int> sAPGetSAPTableVisibleCellTextContentsAtIndexvisibleRowIndex = null, WorkflowValue<int> sAPGetSAPTableVisibleCellTextContentsAtIndexvisibleColumnIndex = null, WorkflowValue<string> sAPGetSAPTableVisibleCellTextContentsAtIndexcheckedElementValue = null)
        {
            WorkflowValue.Validate(sAPGetSAPTableVisibleCellTextContentsAtIndexsearchSAPElementId, nameof(sAPGetSAPTableVisibleCellTextContentsAtIndexsearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPGetSAPTableVisibleCellTextContentsAtIndexworkflow, nameof(sAPGetSAPTableVisibleCellTextContentsAtIndexworkflow), required: true);
            WorkflowValue.Validate(sAPGetSAPTableVisibleCellTextContentsAtIndexvisibleRowIndex, nameof(sAPGetSAPTableVisibleCellTextContentsAtIndexvisibleRowIndex), required: false);
            WorkflowValue.Validate(sAPGetSAPTableVisibleCellTextContentsAtIndexvisibleColumnIndex, nameof(sAPGetSAPTableVisibleCellTextContentsAtIndexvisibleColumnIndex), required: false);
            WorkflowValue.Validate(sAPGetSAPTableVisibleCellTextContentsAtIndexcheckedElementValue, nameof(sAPGetSAPTableVisibleCellTextContentsAtIndexcheckedElementValue), required: false);
            return new DeferredBodyAction<SAPGetSAPTableVisibleCellTextContentsAtIndexResponse>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetSAPTableVisibleCellTextContentsAtIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGetSAPTableVisibleCellTextContentsAtIndex = new JObject();
                var sAPGetSAPTableVisibleCellTextContentsAtIndexpropCount = 0;
                sAPGetSAPTableVisibleCellTextContentsAtIndexpropCount++;
                sAPGetSAPTableVisibleCellTextContentsAtIndex["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGetSAPTableVisibleCellTextContentsAtIndexsearchSAPElementId);
                if (sAPGetSAPTableVisibleCellTextContentsAtIndexvisibleRowIndex != null)
                {
                    if (sAPGetSAPTableVisibleCellTextContentsAtIndexvisibleRowIndex != null)
                    {
                        sAPGetSAPTableVisibleCellTextContentsAtIndex["VisibleRowIndex"] = ExpressionConverter.ConvertO(sAPGetSAPTableVisibleCellTextContentsAtIndexvisibleRowIndex);
                        sAPGetSAPTableVisibleCellTextContentsAtIndexpropCount++;
                    }

                    sAPGetSAPTableVisibleCellTextContentsAtIndexpropCount++;
                }
                else
                {
                    sAPGetSAPTableVisibleCellTextContentsAtIndex["VisibleRowIndex"] = 1;
                    sAPGetSAPTableVisibleCellTextContentsAtIndexpropCount++;
                }

                if (sAPGetSAPTableVisibleCellTextContentsAtIndexvisibleColumnIndex != null)
                {
                    if (sAPGetSAPTableVisibleCellTextContentsAtIndexvisibleColumnIndex != null)
                    {
                        sAPGetSAPTableVisibleCellTextContentsAtIndex["VisibleColumnIndex"] = ExpressionConverter.ConvertO(sAPGetSAPTableVisibleCellTextContentsAtIndexvisibleColumnIndex);
                        sAPGetSAPTableVisibleCellTextContentsAtIndexpropCount++;
                    }

                    sAPGetSAPTableVisibleCellTextContentsAtIndexpropCount++;
                }
                else
                {
                    sAPGetSAPTableVisibleCellTextContentsAtIndex["VisibleColumnIndex"] = 1;
                    sAPGetSAPTableVisibleCellTextContentsAtIndexpropCount++;
                }

                if (sAPGetSAPTableVisibleCellTextContentsAtIndexcheckedElementValue != null)
                {
                    if (sAPGetSAPTableVisibleCellTextContentsAtIndexcheckedElementValue != null)
                    {
                        sAPGetSAPTableVisibleCellTextContentsAtIndex["CheckedElementValue"] = ExpressionConverter.ConvertO(sAPGetSAPTableVisibleCellTextContentsAtIndexcheckedElementValue);
                        sAPGetSAPTableVisibleCellTextContentsAtIndexpropCount++;
                    }

                    sAPGetSAPTableVisibleCellTextContentsAtIndexpropCount++;
                }
                else
                {
                    sAPGetSAPTableVisibleCellTextContentsAtIndex["CheckedElementValue"] = "True";
                    sAPGetSAPTableVisibleCellTextContentsAtIndexpropCount++;
                }

                sAPGetSAPTableVisibleCellTextContentsAtIndexpropCount++;
                sAPGetSAPTableVisibleCellTextContentsAtIndex["Workflow"] = ExpressionConverter.ConvertO(sAPGetSAPTableVisibleCellTextContentsAtIndexworkflow);
                if (sAPGetSAPTableVisibleCellTextContentsAtIndexpropCount > 0)
                {
                    callPayload.Body = sAPGetSAPTableVisibleCellTextContentsAtIndex;
                }

                return new ApiConnectionAction<SAPGetSAPTableVisibleCellTextContentsAtIndexResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPGetSAPTableVisibleCellPropertiesAtIndex))]
        public IBodyWorkflowAction<SAPGetSAPTableVisibleCellPropertiesAtIndexResponse> SAPGetSAPTableVisibleCellPropertiesAtIndex([WorkflowExpression] Func<string> sAPGetSAPTableVisibleCellPropertiesAtIndexsearchSAPElementId, [WorkflowExpression] Func<string> sAPGetSAPTableVisibleCellPropertiesAtIndexworkflow, [WorkflowExpression] Func<int> sAPGetSAPTableVisibleCellPropertiesAtIndexvisibleRowIndex = null, [WorkflowExpression] Func<int> sAPGetSAPTableVisibleCellPropertiesAtIndexvisibleColumnIndex = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SAPGetSAPTableVisibleCellPropertiesAtIndexResponse> __BuildSAPGetSAPTableVisibleCellPropertiesAtIndex(WorkflowValue<string> sAPGetSAPTableVisibleCellPropertiesAtIndexsearchSAPElementId, WorkflowValue<string> sAPGetSAPTableVisibleCellPropertiesAtIndexworkflow, WorkflowValue<int> sAPGetSAPTableVisibleCellPropertiesAtIndexvisibleRowIndex = null, WorkflowValue<int> sAPGetSAPTableVisibleCellPropertiesAtIndexvisibleColumnIndex = null)
        {
            WorkflowValue.Validate(sAPGetSAPTableVisibleCellPropertiesAtIndexsearchSAPElementId, nameof(sAPGetSAPTableVisibleCellPropertiesAtIndexsearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPGetSAPTableVisibleCellPropertiesAtIndexworkflow, nameof(sAPGetSAPTableVisibleCellPropertiesAtIndexworkflow), required: true);
            WorkflowValue.Validate(sAPGetSAPTableVisibleCellPropertiesAtIndexvisibleRowIndex, nameof(sAPGetSAPTableVisibleCellPropertiesAtIndexvisibleRowIndex), required: false);
            WorkflowValue.Validate(sAPGetSAPTableVisibleCellPropertiesAtIndexvisibleColumnIndex, nameof(sAPGetSAPTableVisibleCellPropertiesAtIndexvisibleColumnIndex), required: false);
            return new DeferredBodyAction<SAPGetSAPTableVisibleCellPropertiesAtIndexResponse>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetSAPTableVisibleCellPropertiesAtIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGetSAPTableVisibleCellPropertiesAtIndex = new JObject();
                var sAPGetSAPTableVisibleCellPropertiesAtIndexpropCount = 0;
                sAPGetSAPTableVisibleCellPropertiesAtIndexpropCount++;
                sAPGetSAPTableVisibleCellPropertiesAtIndex["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGetSAPTableVisibleCellPropertiesAtIndexsearchSAPElementId);
                if (sAPGetSAPTableVisibleCellPropertiesAtIndexvisibleRowIndex != null)
                {
                    if (sAPGetSAPTableVisibleCellPropertiesAtIndexvisibleRowIndex != null)
                    {
                        sAPGetSAPTableVisibleCellPropertiesAtIndex["VisibleRowIndex"] = ExpressionConverter.ConvertO(sAPGetSAPTableVisibleCellPropertiesAtIndexvisibleRowIndex);
                        sAPGetSAPTableVisibleCellPropertiesAtIndexpropCount++;
                    }

                    sAPGetSAPTableVisibleCellPropertiesAtIndexpropCount++;
                }
                else
                {
                    sAPGetSAPTableVisibleCellPropertiesAtIndex["VisibleRowIndex"] = 1;
                    sAPGetSAPTableVisibleCellPropertiesAtIndexpropCount++;
                }

                if (sAPGetSAPTableVisibleCellPropertiesAtIndexvisibleColumnIndex != null)
                {
                    if (sAPGetSAPTableVisibleCellPropertiesAtIndexvisibleColumnIndex != null)
                    {
                        sAPGetSAPTableVisibleCellPropertiesAtIndex["VisibleColumnIndex"] = ExpressionConverter.ConvertO(sAPGetSAPTableVisibleCellPropertiesAtIndexvisibleColumnIndex);
                        sAPGetSAPTableVisibleCellPropertiesAtIndexpropCount++;
                    }

                    sAPGetSAPTableVisibleCellPropertiesAtIndexpropCount++;
                }
                else
                {
                    sAPGetSAPTableVisibleCellPropertiesAtIndex["VisibleColumnIndex"] = 1;
                    sAPGetSAPTableVisibleCellPropertiesAtIndexpropCount++;
                }

                sAPGetSAPTableVisibleCellPropertiesAtIndexpropCount++;
                sAPGetSAPTableVisibleCellPropertiesAtIndex["Workflow"] = ExpressionConverter.ConvertO(sAPGetSAPTableVisibleCellPropertiesAtIndexworkflow);
                if (sAPGetSAPTableVisibleCellPropertiesAtIndexpropCount > 0)
                {
                    callPayload.Body = sAPGetSAPTableVisibleCellPropertiesAtIndex;
                }

                return new ApiConnectionAction<SAPGetSAPTableVisibleCellPropertiesAtIndexResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPSetSAPTableVisibleCellTextContentsAtIndex))]
        public IWorkflowAction SAPSetSAPTableVisibleCellTextContentsAtIndex([WorkflowExpression] Func<string> sAPSetSAPTableVisibleCellTextContentsAtIndexsearchSAPElementId, [WorkflowExpression] Func<string> sAPSetSAPTableVisibleCellTextContentsAtIndexworkflow, [WorkflowExpression] Func<int> sAPSetSAPTableVisibleCellTextContentsAtIndexvisibleRowIndex = null, [WorkflowExpression] Func<int> sAPSetSAPTableVisibleCellTextContentsAtIndexvisibleColumnIndex = null, [WorkflowExpression] Func<string> sAPSetSAPTableVisibleCellTextContentsAtIndextextToInput = null, [WorkflowExpression] Func<bool> sAPSetSAPTableVisibleCellTextContentsAtIndexreplaceExistingValue = null, [WorkflowExpression] Func<int> sAPSetSAPTableVisibleCellTextContentsAtIndexinsertPosition = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSAPSetSAPTableVisibleCellTextContentsAtIndex(WorkflowValue<string> sAPSetSAPTableVisibleCellTextContentsAtIndexsearchSAPElementId, WorkflowValue<string> sAPSetSAPTableVisibleCellTextContentsAtIndexworkflow, WorkflowValue<int> sAPSetSAPTableVisibleCellTextContentsAtIndexvisibleRowIndex = null, WorkflowValue<int> sAPSetSAPTableVisibleCellTextContentsAtIndexvisibleColumnIndex = null, WorkflowValue<string> sAPSetSAPTableVisibleCellTextContentsAtIndextextToInput = null, WorkflowValue<bool> sAPSetSAPTableVisibleCellTextContentsAtIndexreplaceExistingValue = null, WorkflowValue<int> sAPSetSAPTableVisibleCellTextContentsAtIndexinsertPosition = null)
        {
            WorkflowValue.Validate(sAPSetSAPTableVisibleCellTextContentsAtIndexsearchSAPElementId, nameof(sAPSetSAPTableVisibleCellTextContentsAtIndexsearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPSetSAPTableVisibleCellTextContentsAtIndexworkflow, nameof(sAPSetSAPTableVisibleCellTextContentsAtIndexworkflow), required: true);
            WorkflowValue.Validate(sAPSetSAPTableVisibleCellTextContentsAtIndexvisibleRowIndex, nameof(sAPSetSAPTableVisibleCellTextContentsAtIndexvisibleRowIndex), required: false);
            WorkflowValue.Validate(sAPSetSAPTableVisibleCellTextContentsAtIndexvisibleColumnIndex, nameof(sAPSetSAPTableVisibleCellTextContentsAtIndexvisibleColumnIndex), required: false);
            WorkflowValue.Validate(sAPSetSAPTableVisibleCellTextContentsAtIndextextToInput, nameof(sAPSetSAPTableVisibleCellTextContentsAtIndextextToInput), required: false);
            WorkflowValue.Validate(sAPSetSAPTableVisibleCellTextContentsAtIndexreplaceExistingValue, nameof(sAPSetSAPTableVisibleCellTextContentsAtIndexreplaceExistingValue), required: false);
            WorkflowValue.Validate(sAPSetSAPTableVisibleCellTextContentsAtIndexinsertPosition, nameof(sAPSetSAPTableVisibleCellTextContentsAtIndexinsertPosition), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSetSAPTableVisibleCellTextContentsAtIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPSetSAPTableVisibleCellTextContentsAtIndex = new JObject();
                var sAPSetSAPTableVisibleCellTextContentsAtIndexpropCount = 0;
                sAPSetSAPTableVisibleCellTextContentsAtIndexpropCount++;
                sAPSetSAPTableVisibleCellTextContentsAtIndex["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPSetSAPTableVisibleCellTextContentsAtIndexsearchSAPElementId);
                if (sAPSetSAPTableVisibleCellTextContentsAtIndexvisibleRowIndex != null)
                {
                    if (sAPSetSAPTableVisibleCellTextContentsAtIndexvisibleRowIndex != null)
                    {
                        sAPSetSAPTableVisibleCellTextContentsAtIndex["VisibleRowIndex"] = ExpressionConverter.ConvertO(sAPSetSAPTableVisibleCellTextContentsAtIndexvisibleRowIndex);
                        sAPSetSAPTableVisibleCellTextContentsAtIndexpropCount++;
                    }

                    sAPSetSAPTableVisibleCellTextContentsAtIndexpropCount++;
                }
                else
                {
                    sAPSetSAPTableVisibleCellTextContentsAtIndex["VisibleRowIndex"] = 1;
                    sAPSetSAPTableVisibleCellTextContentsAtIndexpropCount++;
                }

                if (sAPSetSAPTableVisibleCellTextContentsAtIndexvisibleColumnIndex != null)
                {
                    if (sAPSetSAPTableVisibleCellTextContentsAtIndexvisibleColumnIndex != null)
                    {
                        sAPSetSAPTableVisibleCellTextContentsAtIndex["VisibleColumnIndex"] = ExpressionConverter.ConvertO(sAPSetSAPTableVisibleCellTextContentsAtIndexvisibleColumnIndex);
                        sAPSetSAPTableVisibleCellTextContentsAtIndexpropCount++;
                    }

                    sAPSetSAPTableVisibleCellTextContentsAtIndexpropCount++;
                }
                else
                {
                    sAPSetSAPTableVisibleCellTextContentsAtIndex["VisibleColumnIndex"] = 1;
                    sAPSetSAPTableVisibleCellTextContentsAtIndexpropCount++;
                }

                if (sAPSetSAPTableVisibleCellTextContentsAtIndextextToInput != null)
                {
                    sAPSetSAPTableVisibleCellTextContentsAtIndex["TextToInput"] = ExpressionConverter.ConvertO(sAPSetSAPTableVisibleCellTextContentsAtIndextextToInput);
                    sAPSetSAPTableVisibleCellTextContentsAtIndexpropCount++;
                }

                if (sAPSetSAPTableVisibleCellTextContentsAtIndexreplaceExistingValue != null)
                {
                    if (sAPSetSAPTableVisibleCellTextContentsAtIndexreplaceExistingValue != null)
                    {
                        sAPSetSAPTableVisibleCellTextContentsAtIndex["ReplaceExistingValue"] = ExpressionConverter.ConvertO(sAPSetSAPTableVisibleCellTextContentsAtIndexreplaceExistingValue);
                        sAPSetSAPTableVisibleCellTextContentsAtIndexpropCount++;
                    }

                    sAPSetSAPTableVisibleCellTextContentsAtIndexpropCount++;
                }
                else
                {
                    sAPSetSAPTableVisibleCellTextContentsAtIndex["ReplaceExistingValue"] = true;
                    sAPSetSAPTableVisibleCellTextContentsAtIndexpropCount++;
                }

                if (sAPSetSAPTableVisibleCellTextContentsAtIndexinsertPosition != null)
                {
                    if (sAPSetSAPTableVisibleCellTextContentsAtIndexinsertPosition != null)
                    {
                        sAPSetSAPTableVisibleCellTextContentsAtIndex["InsertPosition"] = ExpressionConverter.ConvertO(sAPSetSAPTableVisibleCellTextContentsAtIndexinsertPosition);
                        sAPSetSAPTableVisibleCellTextContentsAtIndexpropCount++;
                    }

                    sAPSetSAPTableVisibleCellTextContentsAtIndexpropCount++;
                }
                else
                {
                    sAPSetSAPTableVisibleCellTextContentsAtIndex["InsertPosition"] = 0;
                    sAPSetSAPTableVisibleCellTextContentsAtIndexpropCount++;
                }

                sAPSetSAPTableVisibleCellTextContentsAtIndexpropCount++;
                sAPSetSAPTableVisibleCellTextContentsAtIndex["Workflow"] = ExpressionConverter.ConvertO(sAPSetSAPTableVisibleCellTextContentsAtIndexworkflow);
                if (sAPSetSAPTableVisibleCellTextContentsAtIndexpropCount > 0)
                {
                    callPayload.Body = sAPSetSAPTableVisibleCellTextContentsAtIndex;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPCheckSAPTableVisibleCellCheckboxAtIndex))]
        public IWorkflowAction SAPCheckSAPTableVisibleCellCheckboxAtIndex([WorkflowExpression] Func<string> sAPCheckSAPTableVisibleCellCheckboxAtIndexsearchSAPElementId, [WorkflowExpression] Func<string> sAPCheckSAPTableVisibleCellCheckboxAtIndexworkflow, [WorkflowExpression] Func<int> sAPCheckSAPTableVisibleCellCheckboxAtIndexvisibleRowIndex = null, [WorkflowExpression] Func<int> sAPCheckSAPTableVisibleCellCheckboxAtIndexvisibleColumnIndex = null, [WorkflowExpression] Func<bool> sAPCheckSAPTableVisibleCellCheckboxAtIndexcheckCellElement = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSAPCheckSAPTableVisibleCellCheckboxAtIndex(WorkflowValue<string> sAPCheckSAPTableVisibleCellCheckboxAtIndexsearchSAPElementId, WorkflowValue<string> sAPCheckSAPTableVisibleCellCheckboxAtIndexworkflow, WorkflowValue<int> sAPCheckSAPTableVisibleCellCheckboxAtIndexvisibleRowIndex = null, WorkflowValue<int> sAPCheckSAPTableVisibleCellCheckboxAtIndexvisibleColumnIndex = null, WorkflowValue<bool> sAPCheckSAPTableVisibleCellCheckboxAtIndexcheckCellElement = null)
        {
            WorkflowValue.Validate(sAPCheckSAPTableVisibleCellCheckboxAtIndexsearchSAPElementId, nameof(sAPCheckSAPTableVisibleCellCheckboxAtIndexsearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPCheckSAPTableVisibleCellCheckboxAtIndexworkflow, nameof(sAPCheckSAPTableVisibleCellCheckboxAtIndexworkflow), required: true);
            WorkflowValue.Validate(sAPCheckSAPTableVisibleCellCheckboxAtIndexvisibleRowIndex, nameof(sAPCheckSAPTableVisibleCellCheckboxAtIndexvisibleRowIndex), required: false);
            WorkflowValue.Validate(sAPCheckSAPTableVisibleCellCheckboxAtIndexvisibleColumnIndex, nameof(sAPCheckSAPTableVisibleCellCheckboxAtIndexvisibleColumnIndex), required: false);
            WorkflowValue.Validate(sAPCheckSAPTableVisibleCellCheckboxAtIndexcheckCellElement, nameof(sAPCheckSAPTableVisibleCellCheckboxAtIndexcheckCellElement), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/SAPGUI/SAPCheckSAPTableVisibleCellCheckboxAtIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPCheckSAPTableVisibleCellCheckboxAtIndex = new JObject();
                var sAPCheckSAPTableVisibleCellCheckboxAtIndexpropCount = 0;
                sAPCheckSAPTableVisibleCellCheckboxAtIndexpropCount++;
                sAPCheckSAPTableVisibleCellCheckboxAtIndex["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPCheckSAPTableVisibleCellCheckboxAtIndexsearchSAPElementId);
                if (sAPCheckSAPTableVisibleCellCheckboxAtIndexvisibleRowIndex != null)
                {
                    if (sAPCheckSAPTableVisibleCellCheckboxAtIndexvisibleRowIndex != null)
                    {
                        sAPCheckSAPTableVisibleCellCheckboxAtIndex["VisibleRowIndex"] = ExpressionConverter.ConvertO(sAPCheckSAPTableVisibleCellCheckboxAtIndexvisibleRowIndex);
                        sAPCheckSAPTableVisibleCellCheckboxAtIndexpropCount++;
                    }

                    sAPCheckSAPTableVisibleCellCheckboxAtIndexpropCount++;
                }
                else
                {
                    sAPCheckSAPTableVisibleCellCheckboxAtIndex["VisibleRowIndex"] = 1;
                    sAPCheckSAPTableVisibleCellCheckboxAtIndexpropCount++;
                }

                if (sAPCheckSAPTableVisibleCellCheckboxAtIndexvisibleColumnIndex != null)
                {
                    if (sAPCheckSAPTableVisibleCellCheckboxAtIndexvisibleColumnIndex != null)
                    {
                        sAPCheckSAPTableVisibleCellCheckboxAtIndex["VisibleColumnIndex"] = ExpressionConverter.ConvertO(sAPCheckSAPTableVisibleCellCheckboxAtIndexvisibleColumnIndex);
                        sAPCheckSAPTableVisibleCellCheckboxAtIndexpropCount++;
                    }

                    sAPCheckSAPTableVisibleCellCheckboxAtIndexpropCount++;
                }
                else
                {
                    sAPCheckSAPTableVisibleCellCheckboxAtIndex["VisibleColumnIndex"] = 1;
                    sAPCheckSAPTableVisibleCellCheckboxAtIndexpropCount++;
                }

                if (sAPCheckSAPTableVisibleCellCheckboxAtIndexcheckCellElement != null)
                {
                    if (sAPCheckSAPTableVisibleCellCheckboxAtIndexcheckCellElement != null)
                    {
                        sAPCheckSAPTableVisibleCellCheckboxAtIndex["CheckCellElement"] = ExpressionConverter.ConvertO(sAPCheckSAPTableVisibleCellCheckboxAtIndexcheckCellElement);
                        sAPCheckSAPTableVisibleCellCheckboxAtIndexpropCount++;
                    }

                    sAPCheckSAPTableVisibleCellCheckboxAtIndexpropCount++;
                }
                else
                {
                    sAPCheckSAPTableVisibleCellCheckboxAtIndex["CheckCellElement"] = true;
                    sAPCheckSAPTableVisibleCellCheckboxAtIndexpropCount++;
                }

                sAPCheckSAPTableVisibleCellCheckboxAtIndexpropCount++;
                sAPCheckSAPTableVisibleCellCheckboxAtIndex["Workflow"] = ExpressionConverter.ConvertO(sAPCheckSAPTableVisibleCellCheckboxAtIndexworkflow);
                if (sAPCheckSAPTableVisibleCellCheckboxAtIndexpropCount > 0)
                {
                    callPayload.Body = sAPCheckSAPTableVisibleCellCheckboxAtIndex;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPPressSAPTableVisibleCellAtIndex))]
        public IWorkflowAction SAPPressSAPTableVisibleCellAtIndex([WorkflowExpression] Func<string> sAPPressSAPTableVisibleCellAtIndexsearchSAPElementId, [WorkflowExpression] Func<string> sAPPressSAPTableVisibleCellAtIndexworkflow, [WorkflowExpression] Func<int> sAPPressSAPTableVisibleCellAtIndexvisibleRowIndex = null, [WorkflowExpression] Func<int> sAPPressSAPTableVisibleCellAtIndexvisibleColumnIndex = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSAPPressSAPTableVisibleCellAtIndex(WorkflowValue<string> sAPPressSAPTableVisibleCellAtIndexsearchSAPElementId, WorkflowValue<string> sAPPressSAPTableVisibleCellAtIndexworkflow, WorkflowValue<int> sAPPressSAPTableVisibleCellAtIndexvisibleRowIndex = null, WorkflowValue<int> sAPPressSAPTableVisibleCellAtIndexvisibleColumnIndex = null)
        {
            WorkflowValue.Validate(sAPPressSAPTableVisibleCellAtIndexsearchSAPElementId, nameof(sAPPressSAPTableVisibleCellAtIndexsearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPPressSAPTableVisibleCellAtIndexworkflow, nameof(sAPPressSAPTableVisibleCellAtIndexworkflow), required: true);
            WorkflowValue.Validate(sAPPressSAPTableVisibleCellAtIndexvisibleRowIndex, nameof(sAPPressSAPTableVisibleCellAtIndexvisibleRowIndex), required: false);
            WorkflowValue.Validate(sAPPressSAPTableVisibleCellAtIndexvisibleColumnIndex, nameof(sAPPressSAPTableVisibleCellAtIndexvisibleColumnIndex), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/SAPGUI/SAPPressSAPTableVisibleCellAtIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPPressSAPTableVisibleCellAtIndex = new JObject();
                var sAPPressSAPTableVisibleCellAtIndexpropCount = 0;
                sAPPressSAPTableVisibleCellAtIndexpropCount++;
                sAPPressSAPTableVisibleCellAtIndex["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPPressSAPTableVisibleCellAtIndexsearchSAPElementId);
                if (sAPPressSAPTableVisibleCellAtIndexvisibleRowIndex != null)
                {
                    if (sAPPressSAPTableVisibleCellAtIndexvisibleRowIndex != null)
                    {
                        sAPPressSAPTableVisibleCellAtIndex["VisibleRowIndex"] = ExpressionConverter.ConvertO(sAPPressSAPTableVisibleCellAtIndexvisibleRowIndex);
                        sAPPressSAPTableVisibleCellAtIndexpropCount++;
                    }

                    sAPPressSAPTableVisibleCellAtIndexpropCount++;
                }
                else
                {
                    sAPPressSAPTableVisibleCellAtIndex["VisibleRowIndex"] = 1;
                    sAPPressSAPTableVisibleCellAtIndexpropCount++;
                }

                if (sAPPressSAPTableVisibleCellAtIndexvisibleColumnIndex != null)
                {
                    if (sAPPressSAPTableVisibleCellAtIndexvisibleColumnIndex != null)
                    {
                        sAPPressSAPTableVisibleCellAtIndex["VisibleColumnIndex"] = ExpressionConverter.ConvertO(sAPPressSAPTableVisibleCellAtIndexvisibleColumnIndex);
                        sAPPressSAPTableVisibleCellAtIndexpropCount++;
                    }

                    sAPPressSAPTableVisibleCellAtIndexpropCount++;
                }
                else
                {
                    sAPPressSAPTableVisibleCellAtIndex["VisibleColumnIndex"] = 1;
                    sAPPressSAPTableVisibleCellAtIndexpropCount++;
                }

                sAPPressSAPTableVisibleCellAtIndexpropCount++;
                sAPPressSAPTableVisibleCellAtIndex["Workflow"] = ExpressionConverter.ConvertO(sAPPressSAPTableVisibleCellAtIndexworkflow);
                if (sAPPressSAPTableVisibleCellAtIndexpropCount > 0)
                {
                    callPayload.Body = sAPPressSAPTableVisibleCellAtIndex;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPScrollSAPTable))]
        public IWorkflowAction SAPScrollSAPTable([WorkflowExpression] Func<string> sAPScrollSAPTablesearchSAPElementId, [WorkflowExpression] Func<string> sAPScrollSAPTableworkflow, [WorkflowExpression] Func<bool> sAPScrollSAPTablemoveHorizontalScrollbar = null, [WorkflowExpression] Func<int> sAPScrollSAPTablehorizontalScrollbarPosition = null, [WorkflowExpression] Func<bool> sAPScrollSAPTablemoveVerticalScrollbar = null, [WorkflowExpression] Func<int> sAPScrollSAPTableverticalScrollbarPosition = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSAPScrollSAPTable(WorkflowValue<string> sAPScrollSAPTablesearchSAPElementId, WorkflowValue<string> sAPScrollSAPTableworkflow, WorkflowValue<bool> sAPScrollSAPTablemoveHorizontalScrollbar = null, WorkflowValue<int> sAPScrollSAPTablehorizontalScrollbarPosition = null, WorkflowValue<bool> sAPScrollSAPTablemoveVerticalScrollbar = null, WorkflowValue<int> sAPScrollSAPTableverticalScrollbarPosition = null)
        {
            WorkflowValue.Validate(sAPScrollSAPTablesearchSAPElementId, nameof(sAPScrollSAPTablesearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPScrollSAPTableworkflow, nameof(sAPScrollSAPTableworkflow), required: true);
            WorkflowValue.Validate(sAPScrollSAPTablemoveHorizontalScrollbar, nameof(sAPScrollSAPTablemoveHorizontalScrollbar), required: false);
            WorkflowValue.Validate(sAPScrollSAPTablehorizontalScrollbarPosition, nameof(sAPScrollSAPTablehorizontalScrollbarPosition), required: false);
            WorkflowValue.Validate(sAPScrollSAPTablemoveVerticalScrollbar, nameof(sAPScrollSAPTablemoveVerticalScrollbar), required: false);
            WorkflowValue.Validate(sAPScrollSAPTableverticalScrollbarPosition, nameof(sAPScrollSAPTableverticalScrollbarPosition), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/SAPGUI/SAPScrollSAPTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPScrollSAPTable = new JObject();
                var sAPScrollSAPTablepropCount = 0;
                sAPScrollSAPTablepropCount++;
                sAPScrollSAPTable["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPScrollSAPTablesearchSAPElementId);
                if (sAPScrollSAPTablemoveHorizontalScrollbar != null)
                {
                    if (sAPScrollSAPTablemoveHorizontalScrollbar != null)
                    {
                        sAPScrollSAPTable["MoveHorizontalScrollbar"] = ExpressionConverter.ConvertO(sAPScrollSAPTablemoveHorizontalScrollbar);
                        sAPScrollSAPTablepropCount++;
                    }

                    sAPScrollSAPTablepropCount++;
                }
                else
                {
                    sAPScrollSAPTable["MoveHorizontalScrollbar"] = false;
                    sAPScrollSAPTablepropCount++;
                }

                if (sAPScrollSAPTablehorizontalScrollbarPosition != null)
                {
                    sAPScrollSAPTable["HorizontalScrollbarPosition"] = ExpressionConverter.ConvertO(sAPScrollSAPTablehorizontalScrollbarPosition);
                    sAPScrollSAPTablepropCount++;
                }

                if (sAPScrollSAPTablemoveVerticalScrollbar != null)
                {
                    if (sAPScrollSAPTablemoveVerticalScrollbar != null)
                    {
                        sAPScrollSAPTable["MoveVerticalScrollbar"] = ExpressionConverter.ConvertO(sAPScrollSAPTablemoveVerticalScrollbar);
                        sAPScrollSAPTablepropCount++;
                    }

                    sAPScrollSAPTablepropCount++;
                }
                else
                {
                    sAPScrollSAPTable["MoveVerticalScrollbar"] = false;
                    sAPScrollSAPTablepropCount++;
                }

                if (sAPScrollSAPTableverticalScrollbarPosition != null)
                {
                    sAPScrollSAPTable["VerticalScrollbarPosition"] = ExpressionConverter.ConvertO(sAPScrollSAPTableverticalScrollbarPosition);
                    sAPScrollSAPTablepropCount++;
                }

                sAPScrollSAPTablepropCount++;
                sAPScrollSAPTable["Workflow"] = ExpressionConverter.ConvertO(sAPScrollSAPTableworkflow);
                if (sAPScrollSAPTablepropCount > 0)
                {
                    callPayload.Body = sAPScrollSAPTable;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPGetTableVisibleTextContents))]
        public IBodyWorkflowAction<SAPGetTableVisibleTextContentsResponse> SAPGetTableVisibleTextContents([WorkflowExpression] Func<string> sAPGetTableVisibleTextContentssearchSAPElementId, [WorkflowExpression] Func<string> sAPGetTableVisibleTextContentsworkflow, [WorkflowExpression] Func<int> sAPGetTableVisibleTextContentsfirstVisibleRowToReturn = null, [WorkflowExpression] Func<int> sAPGetTableVisibleTextContentsmaxRowsToReturn = null, [WorkflowExpression] Func<int> sAPGetTableVisibleTextContentsfirstVisibleColumnToReturn = null, [WorkflowExpression] Func<int> sAPGetTableVisibleTextContentsmaxColumnsToReturn = null, [WorkflowExpression] Func<bool> sAPGetTableVisibleTextContentsuseColumnHeadersFromTable = null, [WorkflowExpression] Func<bool> sAPGetTableVisibleTextContentsreturnRowIndexInOutputCollection = null, [WorkflowExpression] Func<string> sAPGetTableVisibleTextContentsnameOfColumnToStoreRowIndex = null, [WorkflowExpression] Func<string> sAPGetTableVisibleTextContentscheckedElementValue = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SAPGetTableVisibleTextContentsResponse> __BuildSAPGetTableVisibleTextContents(WorkflowValue<string> sAPGetTableVisibleTextContentssearchSAPElementId, WorkflowValue<string> sAPGetTableVisibleTextContentsworkflow, WorkflowValue<int> sAPGetTableVisibleTextContentsfirstVisibleRowToReturn = null, WorkflowValue<int> sAPGetTableVisibleTextContentsmaxRowsToReturn = null, WorkflowValue<int> sAPGetTableVisibleTextContentsfirstVisibleColumnToReturn = null, WorkflowValue<int> sAPGetTableVisibleTextContentsmaxColumnsToReturn = null, WorkflowValue<bool> sAPGetTableVisibleTextContentsuseColumnHeadersFromTable = null, WorkflowValue<bool> sAPGetTableVisibleTextContentsreturnRowIndexInOutputCollection = null, WorkflowValue<string> sAPGetTableVisibleTextContentsnameOfColumnToStoreRowIndex = null, WorkflowValue<string> sAPGetTableVisibleTextContentscheckedElementValue = null)
        {
            WorkflowValue.Validate(sAPGetTableVisibleTextContentssearchSAPElementId, nameof(sAPGetTableVisibleTextContentssearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPGetTableVisibleTextContentsworkflow, nameof(sAPGetTableVisibleTextContentsworkflow), required: true);
            WorkflowValue.Validate(sAPGetTableVisibleTextContentsfirstVisibleRowToReturn, nameof(sAPGetTableVisibleTextContentsfirstVisibleRowToReturn), required: false);
            WorkflowValue.Validate(sAPGetTableVisibleTextContentsmaxRowsToReturn, nameof(sAPGetTableVisibleTextContentsmaxRowsToReturn), required: false);
            WorkflowValue.Validate(sAPGetTableVisibleTextContentsfirstVisibleColumnToReturn, nameof(sAPGetTableVisibleTextContentsfirstVisibleColumnToReturn), required: false);
            WorkflowValue.Validate(sAPGetTableVisibleTextContentsmaxColumnsToReturn, nameof(sAPGetTableVisibleTextContentsmaxColumnsToReturn), required: false);
            WorkflowValue.Validate(sAPGetTableVisibleTextContentsuseColumnHeadersFromTable, nameof(sAPGetTableVisibleTextContentsuseColumnHeadersFromTable), required: false);
            WorkflowValue.Validate(sAPGetTableVisibleTextContentsreturnRowIndexInOutputCollection, nameof(sAPGetTableVisibleTextContentsreturnRowIndexInOutputCollection), required: false);
            WorkflowValue.Validate(sAPGetTableVisibleTextContentsnameOfColumnToStoreRowIndex, nameof(sAPGetTableVisibleTextContentsnameOfColumnToStoreRowIndex), required: false);
            WorkflowValue.Validate(sAPGetTableVisibleTextContentscheckedElementValue, nameof(sAPGetTableVisibleTextContentscheckedElementValue), required: false);
            return new DeferredBodyAction<SAPGetTableVisibleTextContentsResponse>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetTableVisibleTextContents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGetTableVisibleTextContents = new JObject();
                var sAPGetTableVisibleTextContentspropCount = 0;
                sAPGetTableVisibleTextContentspropCount++;
                sAPGetTableVisibleTextContents["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGetTableVisibleTextContentssearchSAPElementId);
                if (sAPGetTableVisibleTextContentsfirstVisibleRowToReturn != null)
                {
                    if (sAPGetTableVisibleTextContentsfirstVisibleRowToReturn != null)
                    {
                        sAPGetTableVisibleTextContents["FirstVisibleRowToReturn"] = ExpressionConverter.ConvertO(sAPGetTableVisibleTextContentsfirstVisibleRowToReturn);
                        sAPGetTableVisibleTextContentspropCount++;
                    }

                    sAPGetTableVisibleTextContentspropCount++;
                }
                else
                {
                    sAPGetTableVisibleTextContents["FirstVisibleRowToReturn"] = 1;
                    sAPGetTableVisibleTextContentspropCount++;
                }

                if (sAPGetTableVisibleTextContentsmaxRowsToReturn != null)
                {
                    if (sAPGetTableVisibleTextContentsmaxRowsToReturn != null)
                    {
                        sAPGetTableVisibleTextContents["MaxRowsToReturn"] = ExpressionConverter.ConvertO(sAPGetTableVisibleTextContentsmaxRowsToReturn);
                        sAPGetTableVisibleTextContentspropCount++;
                    }

                    sAPGetTableVisibleTextContentspropCount++;
                }
                else
                {
                    sAPGetTableVisibleTextContents["MaxRowsToReturn"] = 0;
                    sAPGetTableVisibleTextContentspropCount++;
                }

                if (sAPGetTableVisibleTextContentsfirstVisibleColumnToReturn != null)
                {
                    if (sAPGetTableVisibleTextContentsfirstVisibleColumnToReturn != null)
                    {
                        sAPGetTableVisibleTextContents["FirstVisibleColumnToReturn"] = ExpressionConverter.ConvertO(sAPGetTableVisibleTextContentsfirstVisibleColumnToReturn);
                        sAPGetTableVisibleTextContentspropCount++;
                    }

                    sAPGetTableVisibleTextContentspropCount++;
                }
                else
                {
                    sAPGetTableVisibleTextContents["FirstVisibleColumnToReturn"] = 1;
                    sAPGetTableVisibleTextContentspropCount++;
                }

                if (sAPGetTableVisibleTextContentsmaxColumnsToReturn != null)
                {
                    if (sAPGetTableVisibleTextContentsmaxColumnsToReturn != null)
                    {
                        sAPGetTableVisibleTextContents["MaxColumnsToReturn"] = ExpressionConverter.ConvertO(sAPGetTableVisibleTextContentsmaxColumnsToReturn);
                        sAPGetTableVisibleTextContentspropCount++;
                    }

                    sAPGetTableVisibleTextContentspropCount++;
                }
                else
                {
                    sAPGetTableVisibleTextContents["MaxColumnsToReturn"] = 0;
                    sAPGetTableVisibleTextContentspropCount++;
                }

                if (sAPGetTableVisibleTextContentsuseColumnHeadersFromTable != null)
                {
                    if (sAPGetTableVisibleTextContentsuseColumnHeadersFromTable != null)
                    {
                        sAPGetTableVisibleTextContents["UseColumnHeadersFromTable"] = ExpressionConverter.ConvertO(sAPGetTableVisibleTextContentsuseColumnHeadersFromTable);
                        sAPGetTableVisibleTextContentspropCount++;
                    }

                    sAPGetTableVisibleTextContentspropCount++;
                }
                else
                {
                    sAPGetTableVisibleTextContents["UseColumnHeadersFromTable"] = false;
                    sAPGetTableVisibleTextContentspropCount++;
                }

                if (sAPGetTableVisibleTextContentsreturnRowIndexInOutputCollection != null)
                {
                    if (sAPGetTableVisibleTextContentsreturnRowIndexInOutputCollection != null)
                    {
                        sAPGetTableVisibleTextContents["ReturnRowIndexInOutputCollection"] = ExpressionConverter.ConvertO(sAPGetTableVisibleTextContentsreturnRowIndexInOutputCollection);
                        sAPGetTableVisibleTextContentspropCount++;
                    }

                    sAPGetTableVisibleTextContentspropCount++;
                }
                else
                {
                    sAPGetTableVisibleTextContents["ReturnRowIndexInOutputCollection"] = false;
                    sAPGetTableVisibleTextContentspropCount++;
                }

                if (sAPGetTableVisibleTextContentsnameOfColumnToStoreRowIndex != null)
                {
                    sAPGetTableVisibleTextContents["NameOfColumnToStoreRowIndex"] = ExpressionConverter.ConvertO(sAPGetTableVisibleTextContentsnameOfColumnToStoreRowIndex);
                    sAPGetTableVisibleTextContentspropCount++;
                }

                if (sAPGetTableVisibleTextContentscheckedElementValue != null)
                {
                    if (sAPGetTableVisibleTextContentscheckedElementValue != null)
                    {
                        sAPGetTableVisibleTextContents["CheckedElementValue"] = ExpressionConverter.ConvertO(sAPGetTableVisibleTextContentscheckedElementValue);
                        sAPGetTableVisibleTextContentspropCount++;
                    }

                    sAPGetTableVisibleTextContentspropCount++;
                }
                else
                {
                    sAPGetTableVisibleTextContents["CheckedElementValue"] = "True";
                    sAPGetTableVisibleTextContentspropCount++;
                }

                sAPGetTableVisibleTextContentspropCount++;
                sAPGetTableVisibleTextContents["Workflow"] = ExpressionConverter.ConvertO(sAPGetTableVisibleTextContentsworkflow);
                if (sAPGetTableVisibleTextContentspropCount > 0)
                {
                    callPayload.Body = sAPGetTableVisibleTextContents;
                }

                return new ApiConnectionAction<SAPGetTableVisibleTextContentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPSelectSAPTableRow))]
        public IWorkflowAction SAPSelectSAPTableRow([WorkflowExpression] Func<string> sAPSelectSAPTableRowsearchSAPElementId, [WorkflowExpression] Func<string> sAPSelectSAPTableRowworkflow, [WorkflowExpression] Func<int> sAPSelectSAPTableRowvisibleRowIndex = null, [WorkflowExpression] Func<bool> sAPSelectSAPTableRowselect = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSAPSelectSAPTableRow(WorkflowValue<string> sAPSelectSAPTableRowsearchSAPElementId, WorkflowValue<string> sAPSelectSAPTableRowworkflow, WorkflowValue<int> sAPSelectSAPTableRowvisibleRowIndex = null, WorkflowValue<bool> sAPSelectSAPTableRowselect = null)
        {
            WorkflowValue.Validate(sAPSelectSAPTableRowsearchSAPElementId, nameof(sAPSelectSAPTableRowsearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPSelectSAPTableRowworkflow, nameof(sAPSelectSAPTableRowworkflow), required: true);
            WorkflowValue.Validate(sAPSelectSAPTableRowvisibleRowIndex, nameof(sAPSelectSAPTableRowvisibleRowIndex), required: false);
            WorkflowValue.Validate(sAPSelectSAPTableRowselect, nameof(sAPSelectSAPTableRowselect), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSelectSAPTableRow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPSelectSAPTableRow = new JObject();
                var sAPSelectSAPTableRowpropCount = 0;
                sAPSelectSAPTableRowpropCount++;
                sAPSelectSAPTableRow["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPSelectSAPTableRowsearchSAPElementId);
                if (sAPSelectSAPTableRowvisibleRowIndex != null)
                {
                    if (sAPSelectSAPTableRowvisibleRowIndex != null)
                    {
                        sAPSelectSAPTableRow["VisibleRowIndex"] = ExpressionConverter.ConvertO(sAPSelectSAPTableRowvisibleRowIndex);
                        sAPSelectSAPTableRowpropCount++;
                    }

                    sAPSelectSAPTableRowpropCount++;
                }
                else
                {
                    sAPSelectSAPTableRow["VisibleRowIndex"] = 1;
                    sAPSelectSAPTableRowpropCount++;
                }

                if (sAPSelectSAPTableRowselect != null)
                {
                    if (sAPSelectSAPTableRowselect != null)
                    {
                        sAPSelectSAPTableRow["Select"] = ExpressionConverter.ConvertO(sAPSelectSAPTableRowselect);
                        sAPSelectSAPTableRowpropCount++;
                    }

                    sAPSelectSAPTableRowpropCount++;
                }
                else
                {
                    sAPSelectSAPTableRow["Select"] = true;
                    sAPSelectSAPTableRowpropCount++;
                }

                sAPSelectSAPTableRowpropCount++;
                sAPSelectSAPTableRow["Workflow"] = ExpressionConverter.ConvertO(sAPSelectSAPTableRowworkflow);
                if (sAPSelectSAPTableRowpropCount > 0)
                {
                    callPayload.Body = sAPSelectSAPTableRow;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPSelectSAPTableColumn))]
        public IWorkflowAction SAPSelectSAPTableColumn([WorkflowExpression] Func<string> sAPSelectSAPTableColumnsearchSAPElementId, [WorkflowExpression] Func<string> sAPSelectSAPTableColumnworkflow, [WorkflowExpression] Func<int> sAPSelectSAPTableColumnvisibleColumnIndex = null, [WorkflowExpression] Func<bool> sAPSelectSAPTableColumnselect = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSAPSelectSAPTableColumn(WorkflowValue<string> sAPSelectSAPTableColumnsearchSAPElementId, WorkflowValue<string> sAPSelectSAPTableColumnworkflow, WorkflowValue<int> sAPSelectSAPTableColumnvisibleColumnIndex = null, WorkflowValue<bool> sAPSelectSAPTableColumnselect = null)
        {
            WorkflowValue.Validate(sAPSelectSAPTableColumnsearchSAPElementId, nameof(sAPSelectSAPTableColumnsearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPSelectSAPTableColumnworkflow, nameof(sAPSelectSAPTableColumnworkflow), required: true);
            WorkflowValue.Validate(sAPSelectSAPTableColumnvisibleColumnIndex, nameof(sAPSelectSAPTableColumnvisibleColumnIndex), required: false);
            WorkflowValue.Validate(sAPSelectSAPTableColumnselect, nameof(sAPSelectSAPTableColumnselect), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSelectSAPTableColumn";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPSelectSAPTableColumn = new JObject();
                var sAPSelectSAPTableColumnpropCount = 0;
                sAPSelectSAPTableColumnpropCount++;
                sAPSelectSAPTableColumn["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPSelectSAPTableColumnsearchSAPElementId);
                if (sAPSelectSAPTableColumnvisibleColumnIndex != null)
                {
                    if (sAPSelectSAPTableColumnvisibleColumnIndex != null)
                    {
                        sAPSelectSAPTableColumn["VisibleColumnIndex"] = ExpressionConverter.ConvertO(sAPSelectSAPTableColumnvisibleColumnIndex);
                        sAPSelectSAPTableColumnpropCount++;
                    }

                    sAPSelectSAPTableColumnpropCount++;
                }
                else
                {
                    sAPSelectSAPTableColumn["VisibleColumnIndex"] = 1;
                    sAPSelectSAPTableColumnpropCount++;
                }

                if (sAPSelectSAPTableColumnselect != null)
                {
                    if (sAPSelectSAPTableColumnselect != null)
                    {
                        sAPSelectSAPTableColumn["Select"] = ExpressionConverter.ConvertO(sAPSelectSAPTableColumnselect);
                        sAPSelectSAPTableColumnpropCount++;
                    }

                    sAPSelectSAPTableColumnpropCount++;
                }
                else
                {
                    sAPSelectSAPTableColumn["Select"] = true;
                    sAPSelectSAPTableColumnpropCount++;
                }

                sAPSelectSAPTableColumnpropCount++;
                sAPSelectSAPTableColumn["Workflow"] = ExpressionConverter.ConvertO(sAPSelectSAPTableColumnworkflow);
                if (sAPSelectSAPTableColumnpropCount > 0)
                {
                    callPayload.Body = sAPSelectSAPTableColumn;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPGetTreeNodes))]
        public IBodyWorkflowAction<SAPGetTreeNodesResponse> SAPGetTreeNodes([WorkflowExpression] Func<string> sAPGetTreeNodessearchSAPElementId, [WorkflowExpression] Func<string> sAPGetTreeNodesworkflow, [WorkflowExpression] Func<string> sAPGetTreeNodesparentNodeKey = null, [WorkflowExpression] Func<bool> sAPGetTreeNodesprocessSubNodes = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SAPGetTreeNodesResponse> __BuildSAPGetTreeNodes(WorkflowValue<string> sAPGetTreeNodessearchSAPElementId, WorkflowValue<string> sAPGetTreeNodesworkflow, WorkflowValue<string> sAPGetTreeNodesparentNodeKey = null, WorkflowValue<bool> sAPGetTreeNodesprocessSubNodes = null)
        {
            WorkflowValue.Validate(sAPGetTreeNodessearchSAPElementId, nameof(sAPGetTreeNodessearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPGetTreeNodesworkflow, nameof(sAPGetTreeNodesworkflow), required: true);
            WorkflowValue.Validate(sAPGetTreeNodesparentNodeKey, nameof(sAPGetTreeNodesparentNodeKey), required: false);
            WorkflowValue.Validate(sAPGetTreeNodesprocessSubNodes, nameof(sAPGetTreeNodesprocessSubNodes), required: false);
            return new DeferredBodyAction<SAPGetTreeNodesResponse>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetTreeNodes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGetTreeNodes = new JObject();
                var sAPGetTreeNodespropCount = 0;
                sAPGetTreeNodespropCount++;
                sAPGetTreeNodes["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGetTreeNodessearchSAPElementId);
                if (sAPGetTreeNodesparentNodeKey != null)
                {
                    sAPGetTreeNodes["ParentNodeKey"] = ExpressionConverter.ConvertO(sAPGetTreeNodesparentNodeKey);
                    sAPGetTreeNodespropCount++;
                }

                if (sAPGetTreeNodesprocessSubNodes != null)
                {
                    if (sAPGetTreeNodesprocessSubNodes != null)
                    {
                        sAPGetTreeNodes["ProcessSubNodes"] = ExpressionConverter.ConvertO(sAPGetTreeNodesprocessSubNodes);
                        sAPGetTreeNodespropCount++;
                    }

                    sAPGetTreeNodespropCount++;
                }
                else
                {
                    sAPGetTreeNodes["ProcessSubNodes"] = true;
                    sAPGetTreeNodespropCount++;
                }

                sAPGetTreeNodespropCount++;
                sAPGetTreeNodes["Workflow"] = ExpressionConverter.ConvertO(sAPGetTreeNodesworkflow);
                if (sAPGetTreeNodespropCount > 0)
                {
                    callPayload.Body = sAPGetTreeNodes;
                }

                return new ApiConnectionAction<SAPGetTreeNodesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPDoubleClickTreeItem))]
        public IWorkflowAction SAPDoubleClickTreeItem([WorkflowExpression] Func<string> sAPDoubleClickTreeItemsearchSAPElementId, [WorkflowExpression] Func<string> sAPDoubleClickTreeItemworkflow, [WorkflowExpression] Func<string> sAPDoubleClickTreeItemsearchNodeKey = null, [WorkflowExpression] Func<string> sAPDoubleClickTreeItemsearchNodePath = null, [WorkflowExpression] Func<string> sAPDoubleClickTreeItemsearchNodeText = null, [WorkflowExpression] Func<bool> sAPDoubleClickTreeItemsearchNodeTextIsRegularExpression = null, [WorkflowExpression] Func<bool> sAPDoubleClickTreeItemsearchNodeTextIsCaseSensitive = null, [WorkflowExpression] Func<string> sAPDoubleClickTreeItemsearchColumnName = null, [WorkflowExpression] Func<string> sAPDoubleClickTreeItemsearchColumnTitle = null, [WorkflowExpression] Func<bool> sAPDoubleClickTreeItemsearchColumnTitleIsRegularExpression = null, [WorkflowExpression] Func<bool> sAPDoubleClickTreeItemsearchColumnTitleIsCaseSensitive = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSAPDoubleClickTreeItem(WorkflowValue<string> sAPDoubleClickTreeItemsearchSAPElementId, WorkflowValue<string> sAPDoubleClickTreeItemworkflow, WorkflowValue<string> sAPDoubleClickTreeItemsearchNodeKey = null, WorkflowValue<string> sAPDoubleClickTreeItemsearchNodePath = null, WorkflowValue<string> sAPDoubleClickTreeItemsearchNodeText = null, WorkflowValue<bool> sAPDoubleClickTreeItemsearchNodeTextIsRegularExpression = null, WorkflowValue<bool> sAPDoubleClickTreeItemsearchNodeTextIsCaseSensitive = null, WorkflowValue<string> sAPDoubleClickTreeItemsearchColumnName = null, WorkflowValue<string> sAPDoubleClickTreeItemsearchColumnTitle = null, WorkflowValue<bool> sAPDoubleClickTreeItemsearchColumnTitleIsRegularExpression = null, WorkflowValue<bool> sAPDoubleClickTreeItemsearchColumnTitleIsCaseSensitive = null)
        {
            WorkflowValue.Validate(sAPDoubleClickTreeItemsearchSAPElementId, nameof(sAPDoubleClickTreeItemsearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPDoubleClickTreeItemworkflow, nameof(sAPDoubleClickTreeItemworkflow), required: true);
            WorkflowValue.Validate(sAPDoubleClickTreeItemsearchNodeKey, nameof(sAPDoubleClickTreeItemsearchNodeKey), required: false);
            WorkflowValue.Validate(sAPDoubleClickTreeItemsearchNodePath, nameof(sAPDoubleClickTreeItemsearchNodePath), required: false);
            WorkflowValue.Validate(sAPDoubleClickTreeItemsearchNodeText, nameof(sAPDoubleClickTreeItemsearchNodeText), required: false);
            WorkflowValue.Validate(sAPDoubleClickTreeItemsearchNodeTextIsRegularExpression, nameof(sAPDoubleClickTreeItemsearchNodeTextIsRegularExpression), required: false);
            WorkflowValue.Validate(sAPDoubleClickTreeItemsearchNodeTextIsCaseSensitive, nameof(sAPDoubleClickTreeItemsearchNodeTextIsCaseSensitive), required: false);
            WorkflowValue.Validate(sAPDoubleClickTreeItemsearchColumnName, nameof(sAPDoubleClickTreeItemsearchColumnName), required: false);
            WorkflowValue.Validate(sAPDoubleClickTreeItemsearchColumnTitle, nameof(sAPDoubleClickTreeItemsearchColumnTitle), required: false);
            WorkflowValue.Validate(sAPDoubleClickTreeItemsearchColumnTitleIsRegularExpression, nameof(sAPDoubleClickTreeItemsearchColumnTitleIsRegularExpression), required: false);
            WorkflowValue.Validate(sAPDoubleClickTreeItemsearchColumnTitleIsCaseSensitive, nameof(sAPDoubleClickTreeItemsearchColumnTitleIsCaseSensitive), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/SAPGUI/SAPDoubleClickTreeItem";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPDoubleClickTreeItem = new JObject();
                var sAPDoubleClickTreeItempropCount = 0;
                sAPDoubleClickTreeItempropCount++;
                sAPDoubleClickTreeItem["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPDoubleClickTreeItemsearchSAPElementId);
                if (sAPDoubleClickTreeItemsearchNodeKey != null)
                {
                    sAPDoubleClickTreeItem["SearchNodeKey"] = ExpressionConverter.ConvertO(sAPDoubleClickTreeItemsearchNodeKey);
                    sAPDoubleClickTreeItempropCount++;
                }

                if (sAPDoubleClickTreeItemsearchNodePath != null)
                {
                    sAPDoubleClickTreeItem["SearchNodePath"] = ExpressionConverter.ConvertO(sAPDoubleClickTreeItemsearchNodePath);
                    sAPDoubleClickTreeItempropCount++;
                }

                if (sAPDoubleClickTreeItemsearchNodeText != null)
                {
                    sAPDoubleClickTreeItem["SearchNodeText"] = ExpressionConverter.ConvertO(sAPDoubleClickTreeItemsearchNodeText);
                    sAPDoubleClickTreeItempropCount++;
                }

                if (sAPDoubleClickTreeItemsearchNodeTextIsRegularExpression != null)
                {
                    if (sAPDoubleClickTreeItemsearchNodeTextIsRegularExpression != null)
                    {
                        sAPDoubleClickTreeItem["SearchNodeTextIsRegularExpression"] = ExpressionConverter.ConvertO(sAPDoubleClickTreeItemsearchNodeTextIsRegularExpression);
                        sAPDoubleClickTreeItempropCount++;
                    }

                    sAPDoubleClickTreeItempropCount++;
                }
                else
                {
                    sAPDoubleClickTreeItem["SearchNodeTextIsRegularExpression"] = false;
                    sAPDoubleClickTreeItempropCount++;
                }

                if (sAPDoubleClickTreeItemsearchNodeTextIsCaseSensitive != null)
                {
                    if (sAPDoubleClickTreeItemsearchNodeTextIsCaseSensitive != null)
                    {
                        sAPDoubleClickTreeItem["SearchNodeTextIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPDoubleClickTreeItemsearchNodeTextIsCaseSensitive);
                        sAPDoubleClickTreeItempropCount++;
                    }

                    sAPDoubleClickTreeItempropCount++;
                }
                else
                {
                    sAPDoubleClickTreeItem["SearchNodeTextIsCaseSensitive"] = false;
                    sAPDoubleClickTreeItempropCount++;
                }

                if (sAPDoubleClickTreeItemsearchColumnName != null)
                {
                    sAPDoubleClickTreeItem["SearchColumnName"] = ExpressionConverter.ConvertO(sAPDoubleClickTreeItemsearchColumnName);
                    sAPDoubleClickTreeItempropCount++;
                }

                if (sAPDoubleClickTreeItemsearchColumnTitle != null)
                {
                    sAPDoubleClickTreeItem["SearchColumnTitle"] = ExpressionConverter.ConvertO(sAPDoubleClickTreeItemsearchColumnTitle);
                    sAPDoubleClickTreeItempropCount++;
                }

                if (sAPDoubleClickTreeItemsearchColumnTitleIsRegularExpression != null)
                {
                    if (sAPDoubleClickTreeItemsearchColumnTitleIsRegularExpression != null)
                    {
                        sAPDoubleClickTreeItem["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(sAPDoubleClickTreeItemsearchColumnTitleIsRegularExpression);
                        sAPDoubleClickTreeItempropCount++;
                    }

                    sAPDoubleClickTreeItempropCount++;
                }
                else
                {
                    sAPDoubleClickTreeItem["SearchColumnTitleIsRegularExpression"] = false;
                    sAPDoubleClickTreeItempropCount++;
                }

                if (sAPDoubleClickTreeItemsearchColumnTitleIsCaseSensitive != null)
                {
                    if (sAPDoubleClickTreeItemsearchColumnTitleIsCaseSensitive != null)
                    {
                        sAPDoubleClickTreeItem["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPDoubleClickTreeItemsearchColumnTitleIsCaseSensitive);
                        sAPDoubleClickTreeItempropCount++;
                    }

                    sAPDoubleClickTreeItempropCount++;
                }
                else
                {
                    sAPDoubleClickTreeItem["SearchColumnTitleIsCaseSensitive"] = false;
                    sAPDoubleClickTreeItempropCount++;
                }

                sAPDoubleClickTreeItempropCount++;
                sAPDoubleClickTreeItem["Workflow"] = ExpressionConverter.ConvertO(sAPDoubleClickTreeItemworkflow);
                if (sAPDoubleClickTreeItempropCount > 0)
                {
                    callPayload.Body = sAPDoubleClickTreeItem;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPSelectTreeItem))]
        public IWorkflowAction SAPSelectTreeItem([WorkflowExpression] Func<string> sAPSelectTreeItemsearchSAPElementId, [WorkflowExpression] Func<string> sAPSelectTreeItemworkflow, [WorkflowExpression] Func<string> sAPSelectTreeItemsearchNodeKey = null, [WorkflowExpression] Func<string> sAPSelectTreeItemsearchNodePath = null, [WorkflowExpression] Func<string> sAPSelectTreeItemsearchNodeText = null, [WorkflowExpression] Func<bool> sAPSelectTreeItemsearchNodeTextIsRegularExpression = null, [WorkflowExpression] Func<bool> sAPSelectTreeItemsearchNodeTextIsCaseSensitive = null, [WorkflowExpression] Func<string> sAPSelectTreeItemsearchColumnName = null, [WorkflowExpression] Func<string> sAPSelectTreeItemsearchColumnTitle = null, [WorkflowExpression] Func<bool> sAPSelectTreeItemsearchColumnTitleIsRegularExpression = null, [WorkflowExpression] Func<bool> sAPSelectTreeItemsearchColumnTitleIsCaseSensitive = null, [WorkflowExpression] Func<bool> sAPSelectTreeItemselect = null, [WorkflowExpression] Func<bool> sAPSelectTreeItemdeselectAllFirst = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSAPSelectTreeItem(WorkflowValue<string> sAPSelectTreeItemsearchSAPElementId, WorkflowValue<string> sAPSelectTreeItemworkflow, WorkflowValue<string> sAPSelectTreeItemsearchNodeKey = null, WorkflowValue<string> sAPSelectTreeItemsearchNodePath = null, WorkflowValue<string> sAPSelectTreeItemsearchNodeText = null, WorkflowValue<bool> sAPSelectTreeItemsearchNodeTextIsRegularExpression = null, WorkflowValue<bool> sAPSelectTreeItemsearchNodeTextIsCaseSensitive = null, WorkflowValue<string> sAPSelectTreeItemsearchColumnName = null, WorkflowValue<string> sAPSelectTreeItemsearchColumnTitle = null, WorkflowValue<bool> sAPSelectTreeItemsearchColumnTitleIsRegularExpression = null, WorkflowValue<bool> sAPSelectTreeItemsearchColumnTitleIsCaseSensitive = null, WorkflowValue<bool> sAPSelectTreeItemselect = null, WorkflowValue<bool> sAPSelectTreeItemdeselectAllFirst = null)
        {
            WorkflowValue.Validate(sAPSelectTreeItemsearchSAPElementId, nameof(sAPSelectTreeItemsearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPSelectTreeItemworkflow, nameof(sAPSelectTreeItemworkflow), required: true);
            WorkflowValue.Validate(sAPSelectTreeItemsearchNodeKey, nameof(sAPSelectTreeItemsearchNodeKey), required: false);
            WorkflowValue.Validate(sAPSelectTreeItemsearchNodePath, nameof(sAPSelectTreeItemsearchNodePath), required: false);
            WorkflowValue.Validate(sAPSelectTreeItemsearchNodeText, nameof(sAPSelectTreeItemsearchNodeText), required: false);
            WorkflowValue.Validate(sAPSelectTreeItemsearchNodeTextIsRegularExpression, nameof(sAPSelectTreeItemsearchNodeTextIsRegularExpression), required: false);
            WorkflowValue.Validate(sAPSelectTreeItemsearchNodeTextIsCaseSensitive, nameof(sAPSelectTreeItemsearchNodeTextIsCaseSensitive), required: false);
            WorkflowValue.Validate(sAPSelectTreeItemsearchColumnName, nameof(sAPSelectTreeItemsearchColumnName), required: false);
            WorkflowValue.Validate(sAPSelectTreeItemsearchColumnTitle, nameof(sAPSelectTreeItemsearchColumnTitle), required: false);
            WorkflowValue.Validate(sAPSelectTreeItemsearchColumnTitleIsRegularExpression, nameof(sAPSelectTreeItemsearchColumnTitleIsRegularExpression), required: false);
            WorkflowValue.Validate(sAPSelectTreeItemsearchColumnTitleIsCaseSensitive, nameof(sAPSelectTreeItemsearchColumnTitleIsCaseSensitive), required: false);
            WorkflowValue.Validate(sAPSelectTreeItemselect, nameof(sAPSelectTreeItemselect), required: false);
            WorkflowValue.Validate(sAPSelectTreeItemdeselectAllFirst, nameof(sAPSelectTreeItemdeselectAllFirst), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSelectTreeItem";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPSelectTreeItem = new JObject();
                var sAPSelectTreeItempropCount = 0;
                sAPSelectTreeItempropCount++;
                sAPSelectTreeItem["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPSelectTreeItemsearchSAPElementId);
                if (sAPSelectTreeItemsearchNodeKey != null)
                {
                    sAPSelectTreeItem["SearchNodeKey"] = ExpressionConverter.ConvertO(sAPSelectTreeItemsearchNodeKey);
                    sAPSelectTreeItempropCount++;
                }

                if (sAPSelectTreeItemsearchNodePath != null)
                {
                    sAPSelectTreeItem["SearchNodePath"] = ExpressionConverter.ConvertO(sAPSelectTreeItemsearchNodePath);
                    sAPSelectTreeItempropCount++;
                }

                if (sAPSelectTreeItemsearchNodeText != null)
                {
                    sAPSelectTreeItem["SearchNodeText"] = ExpressionConverter.ConvertO(sAPSelectTreeItemsearchNodeText);
                    sAPSelectTreeItempropCount++;
                }

                if (sAPSelectTreeItemsearchNodeTextIsRegularExpression != null)
                {
                    if (sAPSelectTreeItemsearchNodeTextIsRegularExpression != null)
                    {
                        sAPSelectTreeItem["SearchNodeTextIsRegularExpression"] = ExpressionConverter.ConvertO(sAPSelectTreeItemsearchNodeTextIsRegularExpression);
                        sAPSelectTreeItempropCount++;
                    }

                    sAPSelectTreeItempropCount++;
                }
                else
                {
                    sAPSelectTreeItem["SearchNodeTextIsRegularExpression"] = false;
                    sAPSelectTreeItempropCount++;
                }

                if (sAPSelectTreeItemsearchNodeTextIsCaseSensitive != null)
                {
                    if (sAPSelectTreeItemsearchNodeTextIsCaseSensitive != null)
                    {
                        sAPSelectTreeItem["SearchNodeTextIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPSelectTreeItemsearchNodeTextIsCaseSensitive);
                        sAPSelectTreeItempropCount++;
                    }

                    sAPSelectTreeItempropCount++;
                }
                else
                {
                    sAPSelectTreeItem["SearchNodeTextIsCaseSensitive"] = false;
                    sAPSelectTreeItempropCount++;
                }

                if (sAPSelectTreeItemsearchColumnName != null)
                {
                    sAPSelectTreeItem["SearchColumnName"] = ExpressionConverter.ConvertO(sAPSelectTreeItemsearchColumnName);
                    sAPSelectTreeItempropCount++;
                }

                if (sAPSelectTreeItemsearchColumnTitle != null)
                {
                    sAPSelectTreeItem["SearchColumnTitle"] = ExpressionConverter.ConvertO(sAPSelectTreeItemsearchColumnTitle);
                    sAPSelectTreeItempropCount++;
                }

                if (sAPSelectTreeItemsearchColumnTitleIsRegularExpression != null)
                {
                    if (sAPSelectTreeItemsearchColumnTitleIsRegularExpression != null)
                    {
                        sAPSelectTreeItem["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(sAPSelectTreeItemsearchColumnTitleIsRegularExpression);
                        sAPSelectTreeItempropCount++;
                    }

                    sAPSelectTreeItempropCount++;
                }
                else
                {
                    sAPSelectTreeItem["SearchColumnTitleIsRegularExpression"] = false;
                    sAPSelectTreeItempropCount++;
                }

                if (sAPSelectTreeItemsearchColumnTitleIsCaseSensitive != null)
                {
                    if (sAPSelectTreeItemsearchColumnTitleIsCaseSensitive != null)
                    {
                        sAPSelectTreeItem["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPSelectTreeItemsearchColumnTitleIsCaseSensitive);
                        sAPSelectTreeItempropCount++;
                    }

                    sAPSelectTreeItempropCount++;
                }
                else
                {
                    sAPSelectTreeItem["SearchColumnTitleIsCaseSensitive"] = false;
                    sAPSelectTreeItempropCount++;
                }

                if (sAPSelectTreeItemselect != null)
                {
                    if (sAPSelectTreeItemselect != null)
                    {
                        sAPSelectTreeItem["Select"] = ExpressionConverter.ConvertO(sAPSelectTreeItemselect);
                        sAPSelectTreeItempropCount++;
                    }

                    sAPSelectTreeItempropCount++;
                }
                else
                {
                    sAPSelectTreeItem["Select"] = true;
                    sAPSelectTreeItempropCount++;
                }

                if (sAPSelectTreeItemdeselectAllFirst != null)
                {
                    if (sAPSelectTreeItemdeselectAllFirst != null)
                    {
                        sAPSelectTreeItem["DeselectAllFirst"] = ExpressionConverter.ConvertO(sAPSelectTreeItemdeselectAllFirst);
                        sAPSelectTreeItempropCount++;
                    }

                    sAPSelectTreeItempropCount++;
                }
                else
                {
                    sAPSelectTreeItem["DeselectAllFirst"] = false;
                    sAPSelectTreeItempropCount++;
                }

                sAPSelectTreeItempropCount++;
                sAPSelectTreeItem["Workflow"] = ExpressionConverter.ConvertO(sAPSelectTreeItemworkflow);
                if (sAPSelectTreeItempropCount > 0)
                {
                    callPayload.Body = sAPSelectTreeItem;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPExpandTreeNode))]
        public IWorkflowAction SAPExpandTreeNode([WorkflowExpression] Func<string> sAPExpandTreeNodesearchSAPElementId, [WorkflowExpression] Func<string> sAPExpandTreeNodeworkflow, [WorkflowExpression] Func<string> sAPExpandTreeNodesearchNodeKey = null, [WorkflowExpression] Func<string> sAPExpandTreeNodesearchNodePath = null, [WorkflowExpression] Func<string> sAPExpandTreeNodesearchNodeText = null, [WorkflowExpression] Func<bool> sAPExpandTreeNodesearchNodeTextIsRegularExpression = null, [WorkflowExpression] Func<bool> sAPExpandTreeNodesearchNodeTextIsCaseSensitive = null, [WorkflowExpression] Func<bool> sAPExpandTreeNodeexpand = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSAPExpandTreeNode(WorkflowValue<string> sAPExpandTreeNodesearchSAPElementId, WorkflowValue<string> sAPExpandTreeNodeworkflow, WorkflowValue<string> sAPExpandTreeNodesearchNodeKey = null, WorkflowValue<string> sAPExpandTreeNodesearchNodePath = null, WorkflowValue<string> sAPExpandTreeNodesearchNodeText = null, WorkflowValue<bool> sAPExpandTreeNodesearchNodeTextIsRegularExpression = null, WorkflowValue<bool> sAPExpandTreeNodesearchNodeTextIsCaseSensitive = null, WorkflowValue<bool> sAPExpandTreeNodeexpand = null)
        {
            WorkflowValue.Validate(sAPExpandTreeNodesearchSAPElementId, nameof(sAPExpandTreeNodesearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPExpandTreeNodeworkflow, nameof(sAPExpandTreeNodeworkflow), required: true);
            WorkflowValue.Validate(sAPExpandTreeNodesearchNodeKey, nameof(sAPExpandTreeNodesearchNodeKey), required: false);
            WorkflowValue.Validate(sAPExpandTreeNodesearchNodePath, nameof(sAPExpandTreeNodesearchNodePath), required: false);
            WorkflowValue.Validate(sAPExpandTreeNodesearchNodeText, nameof(sAPExpandTreeNodesearchNodeText), required: false);
            WorkflowValue.Validate(sAPExpandTreeNodesearchNodeTextIsRegularExpression, nameof(sAPExpandTreeNodesearchNodeTextIsRegularExpression), required: false);
            WorkflowValue.Validate(sAPExpandTreeNodesearchNodeTextIsCaseSensitive, nameof(sAPExpandTreeNodesearchNodeTextIsCaseSensitive), required: false);
            WorkflowValue.Validate(sAPExpandTreeNodeexpand, nameof(sAPExpandTreeNodeexpand), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/SAPGUI/SAPExpandTreeNode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPExpandTreeNode = new JObject();
                var sAPExpandTreeNodepropCount = 0;
                sAPExpandTreeNodepropCount++;
                sAPExpandTreeNode["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPExpandTreeNodesearchSAPElementId);
                if (sAPExpandTreeNodesearchNodeKey != null)
                {
                    sAPExpandTreeNode["SearchNodeKey"] = ExpressionConverter.ConvertO(sAPExpandTreeNodesearchNodeKey);
                    sAPExpandTreeNodepropCount++;
                }

                if (sAPExpandTreeNodesearchNodePath != null)
                {
                    sAPExpandTreeNode["SearchNodePath"] = ExpressionConverter.ConvertO(sAPExpandTreeNodesearchNodePath);
                    sAPExpandTreeNodepropCount++;
                }

                if (sAPExpandTreeNodesearchNodeText != null)
                {
                    sAPExpandTreeNode["SearchNodeText"] = ExpressionConverter.ConvertO(sAPExpandTreeNodesearchNodeText);
                    sAPExpandTreeNodepropCount++;
                }

                if (sAPExpandTreeNodesearchNodeTextIsRegularExpression != null)
                {
                    if (sAPExpandTreeNodesearchNodeTextIsRegularExpression != null)
                    {
                        sAPExpandTreeNode["SearchNodeTextIsRegularExpression"] = ExpressionConverter.ConvertO(sAPExpandTreeNodesearchNodeTextIsRegularExpression);
                        sAPExpandTreeNodepropCount++;
                    }

                    sAPExpandTreeNodepropCount++;
                }
                else
                {
                    sAPExpandTreeNode["SearchNodeTextIsRegularExpression"] = false;
                    sAPExpandTreeNodepropCount++;
                }

                if (sAPExpandTreeNodesearchNodeTextIsCaseSensitive != null)
                {
                    if (sAPExpandTreeNodesearchNodeTextIsCaseSensitive != null)
                    {
                        sAPExpandTreeNode["SearchNodeTextIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPExpandTreeNodesearchNodeTextIsCaseSensitive);
                        sAPExpandTreeNodepropCount++;
                    }

                    sAPExpandTreeNodepropCount++;
                }
                else
                {
                    sAPExpandTreeNode["SearchNodeTextIsCaseSensitive"] = false;
                    sAPExpandTreeNodepropCount++;
                }

                if (sAPExpandTreeNodeexpand != null)
                {
                    if (sAPExpandTreeNodeexpand != null)
                    {
                        sAPExpandTreeNode["Expand"] = ExpressionConverter.ConvertO(sAPExpandTreeNodeexpand);
                        sAPExpandTreeNodepropCount++;
                    }

                    sAPExpandTreeNodepropCount++;
                }
                else
                {
                    sAPExpandTreeNode["Expand"] = true;
                    sAPExpandTreeNodepropCount++;
                }

                sAPExpandTreeNodepropCount++;
                sAPExpandTreeNode["Workflow"] = ExpressionConverter.ConvertO(sAPExpandTreeNodeworkflow);
                if (sAPExpandTreeNodepropCount > 0)
                {
                    callPayload.Body = sAPExpandTreeNode;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPDeselectAllTreeNodes))]
        public IWorkflowAction SAPDeselectAllTreeNodes([WorkflowExpression] Func<string> sAPDeselectAllTreeNodessearchSAPElementId, [WorkflowExpression] Func<string> sAPDeselectAllTreeNodesworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSAPDeselectAllTreeNodes(WorkflowValue<string> sAPDeselectAllTreeNodessearchSAPElementId, WorkflowValue<string> sAPDeselectAllTreeNodesworkflow)
        {
            WorkflowValue.Validate(sAPDeselectAllTreeNodessearchSAPElementId, nameof(sAPDeselectAllTreeNodessearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPDeselectAllTreeNodesworkflow, nameof(sAPDeselectAllTreeNodesworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/SAPGUI/SAPDeselectAllTreeNodes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPDeselectAllTreeNodes = new JObject();
                var sAPDeselectAllTreeNodespropCount = 0;
                sAPDeselectAllTreeNodespropCount++;
                sAPDeselectAllTreeNodes["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPDeselectAllTreeNodessearchSAPElementId);
                sAPDeselectAllTreeNodespropCount++;
                sAPDeselectAllTreeNodes["Workflow"] = ExpressionConverter.ConvertO(sAPDeselectAllTreeNodesworkflow);
                if (sAPDeselectAllTreeNodespropCount > 0)
                {
                    callPayload.Body = sAPDeselectAllTreeNodes;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPPressKeyOnTree))]
        public IWorkflowAction SAPPressKeyOnTree([WorkflowExpression] Func<string> sAPPressKeyOnTreesearchSAPElementId, [WorkflowExpression] Func<string> sAPPressKeyOnTreekey, [WorkflowExpression] Func<string> sAPPressKeyOnTreeworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSAPPressKeyOnTree(WorkflowValue<string> sAPPressKeyOnTreesearchSAPElementId, WorkflowValue<string> sAPPressKeyOnTreekey, WorkflowValue<string> sAPPressKeyOnTreeworkflow)
        {
            WorkflowValue.Validate(sAPPressKeyOnTreesearchSAPElementId, nameof(sAPPressKeyOnTreesearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPPressKeyOnTreekey, nameof(sAPPressKeyOnTreekey), required: true);
            WorkflowValue.Validate(sAPPressKeyOnTreeworkflow, nameof(sAPPressKeyOnTreeworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/SAPGUI/SAPPressKeyOnTree";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPPressKeyOnTree = new JObject();
                var sAPPressKeyOnTreepropCount = 0;
                sAPPressKeyOnTreepropCount++;
                sAPPressKeyOnTree["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPPressKeyOnTreesearchSAPElementId);
                sAPPressKeyOnTreepropCount++;
                sAPPressKeyOnTree["Key"] = ExpressionConverter.ConvertO(sAPPressKeyOnTreekey);
                sAPPressKeyOnTreepropCount++;
                sAPPressKeyOnTree["Workflow"] = ExpressionConverter.ConvertO(sAPPressKeyOnTreeworkflow);
                if (sAPPressKeyOnTreepropCount > 0)
                {
                    callPayload.Body = sAPPressKeyOnTree;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPOpenContextMenuOnTreeItem))]
        public IWorkflowAction SAPOpenContextMenuOnTreeItem([WorkflowExpression] Func<string> sAPOpenContextMenuOnTreeItemsearchSAPElementId, [WorkflowExpression] Func<string> sAPOpenContextMenuOnTreeItemworkflow, [WorkflowExpression] Func<string> sAPOpenContextMenuOnTreeItemsearchNodeKey = null, [WorkflowExpression] Func<string> sAPOpenContextMenuOnTreeItemsearchNodePath = null, [WorkflowExpression] Func<string> sAPOpenContextMenuOnTreeItemsearchNodeText = null, [WorkflowExpression] Func<bool> sAPOpenContextMenuOnTreeItemsearchNodeTextIsRegularExpression = null, [WorkflowExpression] Func<bool> sAPOpenContextMenuOnTreeItemsearchNodeTextIsCaseSensitive = null, [WorkflowExpression] Func<string> sAPOpenContextMenuOnTreeItemsearchColumnName = null, [WorkflowExpression] Func<string> sAPOpenContextMenuOnTreeItemsearchColumnTitle = null, [WorkflowExpression] Func<bool> sAPOpenContextMenuOnTreeItemsearchColumnTitleIsRegularExpression = null, [WorkflowExpression] Func<bool> sAPOpenContextMenuOnTreeItemsearchColumnTitleIsCaseSensitive = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSAPOpenContextMenuOnTreeItem(WorkflowValue<string> sAPOpenContextMenuOnTreeItemsearchSAPElementId, WorkflowValue<string> sAPOpenContextMenuOnTreeItemworkflow, WorkflowValue<string> sAPOpenContextMenuOnTreeItemsearchNodeKey = null, WorkflowValue<string> sAPOpenContextMenuOnTreeItemsearchNodePath = null, WorkflowValue<string> sAPOpenContextMenuOnTreeItemsearchNodeText = null, WorkflowValue<bool> sAPOpenContextMenuOnTreeItemsearchNodeTextIsRegularExpression = null, WorkflowValue<bool> sAPOpenContextMenuOnTreeItemsearchNodeTextIsCaseSensitive = null, WorkflowValue<string> sAPOpenContextMenuOnTreeItemsearchColumnName = null, WorkflowValue<string> sAPOpenContextMenuOnTreeItemsearchColumnTitle = null, WorkflowValue<bool> sAPOpenContextMenuOnTreeItemsearchColumnTitleIsRegularExpression = null, WorkflowValue<bool> sAPOpenContextMenuOnTreeItemsearchColumnTitleIsCaseSensitive = null)
        {
            WorkflowValue.Validate(sAPOpenContextMenuOnTreeItemsearchSAPElementId, nameof(sAPOpenContextMenuOnTreeItemsearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPOpenContextMenuOnTreeItemworkflow, nameof(sAPOpenContextMenuOnTreeItemworkflow), required: true);
            WorkflowValue.Validate(sAPOpenContextMenuOnTreeItemsearchNodeKey, nameof(sAPOpenContextMenuOnTreeItemsearchNodeKey), required: false);
            WorkflowValue.Validate(sAPOpenContextMenuOnTreeItemsearchNodePath, nameof(sAPOpenContextMenuOnTreeItemsearchNodePath), required: false);
            WorkflowValue.Validate(sAPOpenContextMenuOnTreeItemsearchNodeText, nameof(sAPOpenContextMenuOnTreeItemsearchNodeText), required: false);
            WorkflowValue.Validate(sAPOpenContextMenuOnTreeItemsearchNodeTextIsRegularExpression, nameof(sAPOpenContextMenuOnTreeItemsearchNodeTextIsRegularExpression), required: false);
            WorkflowValue.Validate(sAPOpenContextMenuOnTreeItemsearchNodeTextIsCaseSensitive, nameof(sAPOpenContextMenuOnTreeItemsearchNodeTextIsCaseSensitive), required: false);
            WorkflowValue.Validate(sAPOpenContextMenuOnTreeItemsearchColumnName, nameof(sAPOpenContextMenuOnTreeItemsearchColumnName), required: false);
            WorkflowValue.Validate(sAPOpenContextMenuOnTreeItemsearchColumnTitle, nameof(sAPOpenContextMenuOnTreeItemsearchColumnTitle), required: false);
            WorkflowValue.Validate(sAPOpenContextMenuOnTreeItemsearchColumnTitleIsRegularExpression, nameof(sAPOpenContextMenuOnTreeItemsearchColumnTitleIsRegularExpression), required: false);
            WorkflowValue.Validate(sAPOpenContextMenuOnTreeItemsearchColumnTitleIsCaseSensitive, nameof(sAPOpenContextMenuOnTreeItemsearchColumnTitleIsCaseSensitive), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/SAPGUI/SAPOpenContextMenuOnTreeItem";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPOpenContextMenuOnTreeItem = new JObject();
                var sAPOpenContextMenuOnTreeItempropCount = 0;
                sAPOpenContextMenuOnTreeItempropCount++;
                sAPOpenContextMenuOnTreeItem["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPOpenContextMenuOnTreeItemsearchSAPElementId);
                if (sAPOpenContextMenuOnTreeItemsearchNodeKey != null)
                {
                    sAPOpenContextMenuOnTreeItem["SearchNodeKey"] = ExpressionConverter.ConvertO(sAPOpenContextMenuOnTreeItemsearchNodeKey);
                    sAPOpenContextMenuOnTreeItempropCount++;
                }

                if (sAPOpenContextMenuOnTreeItemsearchNodePath != null)
                {
                    sAPOpenContextMenuOnTreeItem["SearchNodePath"] = ExpressionConverter.ConvertO(sAPOpenContextMenuOnTreeItemsearchNodePath);
                    sAPOpenContextMenuOnTreeItempropCount++;
                }

                if (sAPOpenContextMenuOnTreeItemsearchNodeText != null)
                {
                    sAPOpenContextMenuOnTreeItem["SearchNodeText"] = ExpressionConverter.ConvertO(sAPOpenContextMenuOnTreeItemsearchNodeText);
                    sAPOpenContextMenuOnTreeItempropCount++;
                }

                if (sAPOpenContextMenuOnTreeItemsearchNodeTextIsRegularExpression != null)
                {
                    if (sAPOpenContextMenuOnTreeItemsearchNodeTextIsRegularExpression != null)
                    {
                        sAPOpenContextMenuOnTreeItem["SearchNodeTextIsRegularExpression"] = ExpressionConverter.ConvertO(sAPOpenContextMenuOnTreeItemsearchNodeTextIsRegularExpression);
                        sAPOpenContextMenuOnTreeItempropCount++;
                    }

                    sAPOpenContextMenuOnTreeItempropCount++;
                }
                else
                {
                    sAPOpenContextMenuOnTreeItem["SearchNodeTextIsRegularExpression"] = false;
                    sAPOpenContextMenuOnTreeItempropCount++;
                }

                if (sAPOpenContextMenuOnTreeItemsearchNodeTextIsCaseSensitive != null)
                {
                    if (sAPOpenContextMenuOnTreeItemsearchNodeTextIsCaseSensitive != null)
                    {
                        sAPOpenContextMenuOnTreeItem["SearchNodeTextIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPOpenContextMenuOnTreeItemsearchNodeTextIsCaseSensitive);
                        sAPOpenContextMenuOnTreeItempropCount++;
                    }

                    sAPOpenContextMenuOnTreeItempropCount++;
                }
                else
                {
                    sAPOpenContextMenuOnTreeItem["SearchNodeTextIsCaseSensitive"] = false;
                    sAPOpenContextMenuOnTreeItempropCount++;
                }

                if (sAPOpenContextMenuOnTreeItemsearchColumnName != null)
                {
                    sAPOpenContextMenuOnTreeItem["SearchColumnName"] = ExpressionConverter.ConvertO(sAPOpenContextMenuOnTreeItemsearchColumnName);
                    sAPOpenContextMenuOnTreeItempropCount++;
                }

                if (sAPOpenContextMenuOnTreeItemsearchColumnTitle != null)
                {
                    sAPOpenContextMenuOnTreeItem["SearchColumnTitle"] = ExpressionConverter.ConvertO(sAPOpenContextMenuOnTreeItemsearchColumnTitle);
                    sAPOpenContextMenuOnTreeItempropCount++;
                }

                if (sAPOpenContextMenuOnTreeItemsearchColumnTitleIsRegularExpression != null)
                {
                    if (sAPOpenContextMenuOnTreeItemsearchColumnTitleIsRegularExpression != null)
                    {
                        sAPOpenContextMenuOnTreeItem["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(sAPOpenContextMenuOnTreeItemsearchColumnTitleIsRegularExpression);
                        sAPOpenContextMenuOnTreeItempropCount++;
                    }

                    sAPOpenContextMenuOnTreeItempropCount++;
                }
                else
                {
                    sAPOpenContextMenuOnTreeItem["SearchColumnTitleIsRegularExpression"] = false;
                    sAPOpenContextMenuOnTreeItempropCount++;
                }

                if (sAPOpenContextMenuOnTreeItemsearchColumnTitleIsCaseSensitive != null)
                {
                    if (sAPOpenContextMenuOnTreeItemsearchColumnTitleIsCaseSensitive != null)
                    {
                        sAPOpenContextMenuOnTreeItem["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPOpenContextMenuOnTreeItemsearchColumnTitleIsCaseSensitive);
                        sAPOpenContextMenuOnTreeItempropCount++;
                    }

                    sAPOpenContextMenuOnTreeItempropCount++;
                }
                else
                {
                    sAPOpenContextMenuOnTreeItem["SearchColumnTitleIsCaseSensitive"] = false;
                    sAPOpenContextMenuOnTreeItempropCount++;
                }

                sAPOpenContextMenuOnTreeItempropCount++;
                sAPOpenContextMenuOnTreeItem["Workflow"] = ExpressionConverter.ConvertO(sAPOpenContextMenuOnTreeItemworkflow);
                if (sAPOpenContextMenuOnTreeItempropCount > 0)
                {
                    callPayload.Body = sAPOpenContextMenuOnTreeItem;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPGetTreeTextContents))]
        public IBodyWorkflowAction<SAPGetTreeTextContentsResponse> SAPGetTreeTextContents([WorkflowExpression] Func<string> sAPGetTreeTextContentssearchSAPElementId, [WorkflowExpression] Func<string> sAPGetTreeTextContentsworkflow, [WorkflowExpression] Func<int> sAPGetTreeTextContentsfirstRowToReturn = null, [WorkflowExpression] Func<int> sAPGetTreeTextContentsmaxRowsToReturn = null, [WorkflowExpression] Func<int> sAPGetTreeTextContentsfirstColumnToReturn = null, [WorkflowExpression] Func<int> sAPGetTreeTextContentsmaxColumnsToReturn = null, [WorkflowExpression] Func<bool> sAPGetTreeTextContentsuseColumnHeadersFromTree = null, [WorkflowExpression] Func<bool> sAPGetTreeTextContentsreturnRowIndexInOutputCollection = null, [WorkflowExpression] Func<string> sAPGetTreeTextContentsnameOfColumnToStoreRowIndex = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SAPGetTreeTextContentsResponse> __BuildSAPGetTreeTextContents(WorkflowValue<string> sAPGetTreeTextContentssearchSAPElementId, WorkflowValue<string> sAPGetTreeTextContentsworkflow, WorkflowValue<int> sAPGetTreeTextContentsfirstRowToReturn = null, WorkflowValue<int> sAPGetTreeTextContentsmaxRowsToReturn = null, WorkflowValue<int> sAPGetTreeTextContentsfirstColumnToReturn = null, WorkflowValue<int> sAPGetTreeTextContentsmaxColumnsToReturn = null, WorkflowValue<bool> sAPGetTreeTextContentsuseColumnHeadersFromTree = null, WorkflowValue<bool> sAPGetTreeTextContentsreturnRowIndexInOutputCollection = null, WorkflowValue<string> sAPGetTreeTextContentsnameOfColumnToStoreRowIndex = null)
        {
            WorkflowValue.Validate(sAPGetTreeTextContentssearchSAPElementId, nameof(sAPGetTreeTextContentssearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPGetTreeTextContentsworkflow, nameof(sAPGetTreeTextContentsworkflow), required: true);
            WorkflowValue.Validate(sAPGetTreeTextContentsfirstRowToReturn, nameof(sAPGetTreeTextContentsfirstRowToReturn), required: false);
            WorkflowValue.Validate(sAPGetTreeTextContentsmaxRowsToReturn, nameof(sAPGetTreeTextContentsmaxRowsToReturn), required: false);
            WorkflowValue.Validate(sAPGetTreeTextContentsfirstColumnToReturn, nameof(sAPGetTreeTextContentsfirstColumnToReturn), required: false);
            WorkflowValue.Validate(sAPGetTreeTextContentsmaxColumnsToReturn, nameof(sAPGetTreeTextContentsmaxColumnsToReturn), required: false);
            WorkflowValue.Validate(sAPGetTreeTextContentsuseColumnHeadersFromTree, nameof(sAPGetTreeTextContentsuseColumnHeadersFromTree), required: false);
            WorkflowValue.Validate(sAPGetTreeTextContentsreturnRowIndexInOutputCollection, nameof(sAPGetTreeTextContentsreturnRowIndexInOutputCollection), required: false);
            WorkflowValue.Validate(sAPGetTreeTextContentsnameOfColumnToStoreRowIndex, nameof(sAPGetTreeTextContentsnameOfColumnToStoreRowIndex), required: false);
            return new DeferredBodyAction<SAPGetTreeTextContentsResponse>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetTreeTextContents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGetTreeTextContents = new JObject();
                var sAPGetTreeTextContentspropCount = 0;
                sAPGetTreeTextContentspropCount++;
                sAPGetTreeTextContents["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGetTreeTextContentssearchSAPElementId);
                if (sAPGetTreeTextContentsfirstRowToReturn != null)
                {
                    if (sAPGetTreeTextContentsfirstRowToReturn != null)
                    {
                        sAPGetTreeTextContents["FirstRowToReturn"] = ExpressionConverter.ConvertO(sAPGetTreeTextContentsfirstRowToReturn);
                        sAPGetTreeTextContentspropCount++;
                    }

                    sAPGetTreeTextContentspropCount++;
                }
                else
                {
                    sAPGetTreeTextContents["FirstRowToReturn"] = 1;
                    sAPGetTreeTextContentspropCount++;
                }

                if (sAPGetTreeTextContentsmaxRowsToReturn != null)
                {
                    if (sAPGetTreeTextContentsmaxRowsToReturn != null)
                    {
                        sAPGetTreeTextContents["MaxRowsToReturn"] = ExpressionConverter.ConvertO(sAPGetTreeTextContentsmaxRowsToReturn);
                        sAPGetTreeTextContentspropCount++;
                    }

                    sAPGetTreeTextContentspropCount++;
                }
                else
                {
                    sAPGetTreeTextContents["MaxRowsToReturn"] = 0;
                    sAPGetTreeTextContentspropCount++;
                }

                if (sAPGetTreeTextContentsfirstColumnToReturn != null)
                {
                    if (sAPGetTreeTextContentsfirstColumnToReturn != null)
                    {
                        sAPGetTreeTextContents["FirstColumnToReturn"] = ExpressionConverter.ConvertO(sAPGetTreeTextContentsfirstColumnToReturn);
                        sAPGetTreeTextContentspropCount++;
                    }

                    sAPGetTreeTextContentspropCount++;
                }
                else
                {
                    sAPGetTreeTextContents["FirstColumnToReturn"] = 1;
                    sAPGetTreeTextContentspropCount++;
                }

                if (sAPGetTreeTextContentsmaxColumnsToReturn != null)
                {
                    if (sAPGetTreeTextContentsmaxColumnsToReturn != null)
                    {
                        sAPGetTreeTextContents["MaxColumnsToReturn"] = ExpressionConverter.ConvertO(sAPGetTreeTextContentsmaxColumnsToReturn);
                        sAPGetTreeTextContentspropCount++;
                    }

                    sAPGetTreeTextContentspropCount++;
                }
                else
                {
                    sAPGetTreeTextContents["MaxColumnsToReturn"] = 0;
                    sAPGetTreeTextContentspropCount++;
                }

                if (sAPGetTreeTextContentsuseColumnHeadersFromTree != null)
                {
                    if (sAPGetTreeTextContentsuseColumnHeadersFromTree != null)
                    {
                        sAPGetTreeTextContents["UseColumnHeadersFromTree"] = ExpressionConverter.ConvertO(sAPGetTreeTextContentsuseColumnHeadersFromTree);
                        sAPGetTreeTextContentspropCount++;
                    }

                    sAPGetTreeTextContentspropCount++;
                }
                else
                {
                    sAPGetTreeTextContents["UseColumnHeadersFromTree"] = false;
                    sAPGetTreeTextContentspropCount++;
                }

                if (sAPGetTreeTextContentsreturnRowIndexInOutputCollection != null)
                {
                    if (sAPGetTreeTextContentsreturnRowIndexInOutputCollection != null)
                    {
                        sAPGetTreeTextContents["ReturnRowIndexInOutputCollection"] = ExpressionConverter.ConvertO(sAPGetTreeTextContentsreturnRowIndexInOutputCollection);
                        sAPGetTreeTextContentspropCount++;
                    }

                    sAPGetTreeTextContentspropCount++;
                }
                else
                {
                    sAPGetTreeTextContents["ReturnRowIndexInOutputCollection"] = false;
                    sAPGetTreeTextContentspropCount++;
                }

                if (sAPGetTreeTextContentsnameOfColumnToStoreRowIndex != null)
                {
                    sAPGetTreeTextContents["NameOfColumnToStoreRowIndex"] = ExpressionConverter.ConvertO(sAPGetTreeTextContentsnameOfColumnToStoreRowIndex);
                    sAPGetTreeTextContentspropCount++;
                }

                sAPGetTreeTextContentspropCount++;
                sAPGetTreeTextContents["Workflow"] = ExpressionConverter.ConvertO(sAPGetTreeTextContentsworkflow);
                if (sAPGetTreeTextContentspropCount > 0)
                {
                    callPayload.Body = sAPGetTreeTextContents;
                }

                return new ApiConnectionAction<SAPGetTreeTextContentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPSetTreeColumnWidth))]
        public IWorkflowAction SAPSetTreeColumnWidth([WorkflowExpression] Func<string> sAPSetTreeColumnWidthsearchSAPElementId, [WorkflowExpression] Func<string> sAPSetTreeColumnWidthworkflow, [WorkflowExpression] Func<string> sAPSetTreeColumnWidthsearchColumnName = null, [WorkflowExpression] Func<string> sAPSetTreeColumnWidthsearchColumnTitle = null, [WorkflowExpression] Func<bool> sAPSetTreeColumnWidthsearchColumnTitleIsRegularExpression = null, [WorkflowExpression] Func<bool> sAPSetTreeColumnWidthsearchColumnTitleIsCaseSensitive = null, [WorkflowExpression] Func<int> sAPSetTreeColumnWidthcolumnWidthInPixels = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSAPSetTreeColumnWidth(WorkflowValue<string> sAPSetTreeColumnWidthsearchSAPElementId, WorkflowValue<string> sAPSetTreeColumnWidthworkflow, WorkflowValue<string> sAPSetTreeColumnWidthsearchColumnName = null, WorkflowValue<string> sAPSetTreeColumnWidthsearchColumnTitle = null, WorkflowValue<bool> sAPSetTreeColumnWidthsearchColumnTitleIsRegularExpression = null, WorkflowValue<bool> sAPSetTreeColumnWidthsearchColumnTitleIsCaseSensitive = null, WorkflowValue<int> sAPSetTreeColumnWidthcolumnWidthInPixels = null)
        {
            WorkflowValue.Validate(sAPSetTreeColumnWidthsearchSAPElementId, nameof(sAPSetTreeColumnWidthsearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPSetTreeColumnWidthworkflow, nameof(sAPSetTreeColumnWidthworkflow), required: true);
            WorkflowValue.Validate(sAPSetTreeColumnWidthsearchColumnName, nameof(sAPSetTreeColumnWidthsearchColumnName), required: false);
            WorkflowValue.Validate(sAPSetTreeColumnWidthsearchColumnTitle, nameof(sAPSetTreeColumnWidthsearchColumnTitle), required: false);
            WorkflowValue.Validate(sAPSetTreeColumnWidthsearchColumnTitleIsRegularExpression, nameof(sAPSetTreeColumnWidthsearchColumnTitleIsRegularExpression), required: false);
            WorkflowValue.Validate(sAPSetTreeColumnWidthsearchColumnTitleIsCaseSensitive, nameof(sAPSetTreeColumnWidthsearchColumnTitleIsCaseSensitive), required: false);
            WorkflowValue.Validate(sAPSetTreeColumnWidthcolumnWidthInPixels, nameof(sAPSetTreeColumnWidthcolumnWidthInPixels), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSetTreeColumnWidth";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPSetTreeColumnWidth = new JObject();
                var sAPSetTreeColumnWidthpropCount = 0;
                sAPSetTreeColumnWidthpropCount++;
                sAPSetTreeColumnWidth["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPSetTreeColumnWidthsearchSAPElementId);
                if (sAPSetTreeColumnWidthsearchColumnName != null)
                {
                    sAPSetTreeColumnWidth["SearchColumnName"] = ExpressionConverter.ConvertO(sAPSetTreeColumnWidthsearchColumnName);
                    sAPSetTreeColumnWidthpropCount++;
                }

                if (sAPSetTreeColumnWidthsearchColumnTitle != null)
                {
                    sAPSetTreeColumnWidth["SearchColumnTitle"] = ExpressionConverter.ConvertO(sAPSetTreeColumnWidthsearchColumnTitle);
                    sAPSetTreeColumnWidthpropCount++;
                }

                if (sAPSetTreeColumnWidthsearchColumnTitleIsRegularExpression != null)
                {
                    if (sAPSetTreeColumnWidthsearchColumnTitleIsRegularExpression != null)
                    {
                        sAPSetTreeColumnWidth["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(sAPSetTreeColumnWidthsearchColumnTitleIsRegularExpression);
                        sAPSetTreeColumnWidthpropCount++;
                    }

                    sAPSetTreeColumnWidthpropCount++;
                }
                else
                {
                    sAPSetTreeColumnWidth["SearchColumnTitleIsRegularExpression"] = false;
                    sAPSetTreeColumnWidthpropCount++;
                }

                if (sAPSetTreeColumnWidthsearchColumnTitleIsCaseSensitive != null)
                {
                    if (sAPSetTreeColumnWidthsearchColumnTitleIsCaseSensitive != null)
                    {
                        sAPSetTreeColumnWidth["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPSetTreeColumnWidthsearchColumnTitleIsCaseSensitive);
                        sAPSetTreeColumnWidthpropCount++;
                    }

                    sAPSetTreeColumnWidthpropCount++;
                }
                else
                {
                    sAPSetTreeColumnWidth["SearchColumnTitleIsCaseSensitive"] = false;
                    sAPSetTreeColumnWidthpropCount++;
                }

                if (sAPSetTreeColumnWidthcolumnWidthInPixels != null)
                {
                    if (sAPSetTreeColumnWidthcolumnWidthInPixels != null)
                    {
                        sAPSetTreeColumnWidth["ColumnWidthInPixels"] = ExpressionConverter.ConvertO(sAPSetTreeColumnWidthcolumnWidthInPixels);
                        sAPSetTreeColumnWidthpropCount++;
                    }

                    sAPSetTreeColumnWidthpropCount++;
                }
                else
                {
                    sAPSetTreeColumnWidth["ColumnWidthInPixels"] = 200;
                    sAPSetTreeColumnWidthpropCount++;
                }

                sAPSetTreeColumnWidthpropCount++;
                sAPSetTreeColumnWidth["Workflow"] = ExpressionConverter.ConvertO(sAPSetTreeColumnWidthworkflow);
                if (sAPSetTreeColumnWidthpropCount > 0)
                {
                    callPayload.Body = sAPSetTreeColumnWidth;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPPressButtonOnTreeItem))]
        public IWorkflowAction SAPPressButtonOnTreeItem([WorkflowExpression] Func<string> sAPPressButtonOnTreeItemsearchSAPElementId, [WorkflowExpression] Func<string> sAPPressButtonOnTreeItemworkflow, [WorkflowExpression] Func<string> sAPPressButtonOnTreeItemsearchNodeKey = null, [WorkflowExpression] Func<string> sAPPressButtonOnTreeItemsearchNodePath = null, [WorkflowExpression] Func<string> sAPPressButtonOnTreeItemsearchNodeText = null, [WorkflowExpression] Func<bool> sAPPressButtonOnTreeItemsearchNodeTextIsRegularExpression = null, [WorkflowExpression] Func<bool> sAPPressButtonOnTreeItemsearchNodeTextIsCaseSensitive = null, [WorkflowExpression] Func<string> sAPPressButtonOnTreeItemsearchColumnName = null, [WorkflowExpression] Func<string> sAPPressButtonOnTreeItemsearchColumnTitle = null, [WorkflowExpression] Func<bool> sAPPressButtonOnTreeItemsearchColumnTitleIsRegularExpression = null, [WorkflowExpression] Func<bool> sAPPressButtonOnTreeItemsearchColumnTitleIsCaseSensitive = null, [WorkflowExpression] Func<bool> sAPPressButtonOnTreeItemforce = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSAPPressButtonOnTreeItem(WorkflowValue<string> sAPPressButtonOnTreeItemsearchSAPElementId, WorkflowValue<string> sAPPressButtonOnTreeItemworkflow, WorkflowValue<string> sAPPressButtonOnTreeItemsearchNodeKey = null, WorkflowValue<string> sAPPressButtonOnTreeItemsearchNodePath = null, WorkflowValue<string> sAPPressButtonOnTreeItemsearchNodeText = null, WorkflowValue<bool> sAPPressButtonOnTreeItemsearchNodeTextIsRegularExpression = null, WorkflowValue<bool> sAPPressButtonOnTreeItemsearchNodeTextIsCaseSensitive = null, WorkflowValue<string> sAPPressButtonOnTreeItemsearchColumnName = null, WorkflowValue<string> sAPPressButtonOnTreeItemsearchColumnTitle = null, WorkflowValue<bool> sAPPressButtonOnTreeItemsearchColumnTitleIsRegularExpression = null, WorkflowValue<bool> sAPPressButtonOnTreeItemsearchColumnTitleIsCaseSensitive = null, WorkflowValue<bool> sAPPressButtonOnTreeItemforce = null)
        {
            WorkflowValue.Validate(sAPPressButtonOnTreeItemsearchSAPElementId, nameof(sAPPressButtonOnTreeItemsearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPPressButtonOnTreeItemworkflow, nameof(sAPPressButtonOnTreeItemworkflow), required: true);
            WorkflowValue.Validate(sAPPressButtonOnTreeItemsearchNodeKey, nameof(sAPPressButtonOnTreeItemsearchNodeKey), required: false);
            WorkflowValue.Validate(sAPPressButtonOnTreeItemsearchNodePath, nameof(sAPPressButtonOnTreeItemsearchNodePath), required: false);
            WorkflowValue.Validate(sAPPressButtonOnTreeItemsearchNodeText, nameof(sAPPressButtonOnTreeItemsearchNodeText), required: false);
            WorkflowValue.Validate(sAPPressButtonOnTreeItemsearchNodeTextIsRegularExpression, nameof(sAPPressButtonOnTreeItemsearchNodeTextIsRegularExpression), required: false);
            WorkflowValue.Validate(sAPPressButtonOnTreeItemsearchNodeTextIsCaseSensitive, nameof(sAPPressButtonOnTreeItemsearchNodeTextIsCaseSensitive), required: false);
            WorkflowValue.Validate(sAPPressButtonOnTreeItemsearchColumnName, nameof(sAPPressButtonOnTreeItemsearchColumnName), required: false);
            WorkflowValue.Validate(sAPPressButtonOnTreeItemsearchColumnTitle, nameof(sAPPressButtonOnTreeItemsearchColumnTitle), required: false);
            WorkflowValue.Validate(sAPPressButtonOnTreeItemsearchColumnTitleIsRegularExpression, nameof(sAPPressButtonOnTreeItemsearchColumnTitleIsRegularExpression), required: false);
            WorkflowValue.Validate(sAPPressButtonOnTreeItemsearchColumnTitleIsCaseSensitive, nameof(sAPPressButtonOnTreeItemsearchColumnTitleIsCaseSensitive), required: false);
            WorkflowValue.Validate(sAPPressButtonOnTreeItemforce, nameof(sAPPressButtonOnTreeItemforce), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/SAPGUI/SAPPressButtonOnTreeItem";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPPressButtonOnTreeItem = new JObject();
                var sAPPressButtonOnTreeItempropCount = 0;
                sAPPressButtonOnTreeItempropCount++;
                sAPPressButtonOnTreeItem["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPPressButtonOnTreeItemsearchSAPElementId);
                if (sAPPressButtonOnTreeItemsearchNodeKey != null)
                {
                    sAPPressButtonOnTreeItem["SearchNodeKey"] = ExpressionConverter.ConvertO(sAPPressButtonOnTreeItemsearchNodeKey);
                    sAPPressButtonOnTreeItempropCount++;
                }

                if (sAPPressButtonOnTreeItemsearchNodePath != null)
                {
                    sAPPressButtonOnTreeItem["SearchNodePath"] = ExpressionConverter.ConvertO(sAPPressButtonOnTreeItemsearchNodePath);
                    sAPPressButtonOnTreeItempropCount++;
                }

                if (sAPPressButtonOnTreeItemsearchNodeText != null)
                {
                    sAPPressButtonOnTreeItem["SearchNodeText"] = ExpressionConverter.ConvertO(sAPPressButtonOnTreeItemsearchNodeText);
                    sAPPressButtonOnTreeItempropCount++;
                }

                if (sAPPressButtonOnTreeItemsearchNodeTextIsRegularExpression != null)
                {
                    if (sAPPressButtonOnTreeItemsearchNodeTextIsRegularExpression != null)
                    {
                        sAPPressButtonOnTreeItem["SearchNodeTextIsRegularExpression"] = ExpressionConverter.ConvertO(sAPPressButtonOnTreeItemsearchNodeTextIsRegularExpression);
                        sAPPressButtonOnTreeItempropCount++;
                    }

                    sAPPressButtonOnTreeItempropCount++;
                }
                else
                {
                    sAPPressButtonOnTreeItem["SearchNodeTextIsRegularExpression"] = false;
                    sAPPressButtonOnTreeItempropCount++;
                }

                if (sAPPressButtonOnTreeItemsearchNodeTextIsCaseSensitive != null)
                {
                    if (sAPPressButtonOnTreeItemsearchNodeTextIsCaseSensitive != null)
                    {
                        sAPPressButtonOnTreeItem["SearchNodeTextIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPPressButtonOnTreeItemsearchNodeTextIsCaseSensitive);
                        sAPPressButtonOnTreeItempropCount++;
                    }

                    sAPPressButtonOnTreeItempropCount++;
                }
                else
                {
                    sAPPressButtonOnTreeItem["SearchNodeTextIsCaseSensitive"] = false;
                    sAPPressButtonOnTreeItempropCount++;
                }

                if (sAPPressButtonOnTreeItemsearchColumnName != null)
                {
                    sAPPressButtonOnTreeItem["SearchColumnName"] = ExpressionConverter.ConvertO(sAPPressButtonOnTreeItemsearchColumnName);
                    sAPPressButtonOnTreeItempropCount++;
                }

                if (sAPPressButtonOnTreeItemsearchColumnTitle != null)
                {
                    sAPPressButtonOnTreeItem["SearchColumnTitle"] = ExpressionConverter.ConvertO(sAPPressButtonOnTreeItemsearchColumnTitle);
                    sAPPressButtonOnTreeItempropCount++;
                }

                if (sAPPressButtonOnTreeItemsearchColumnTitleIsRegularExpression != null)
                {
                    if (sAPPressButtonOnTreeItemsearchColumnTitleIsRegularExpression != null)
                    {
                        sAPPressButtonOnTreeItem["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(sAPPressButtonOnTreeItemsearchColumnTitleIsRegularExpression);
                        sAPPressButtonOnTreeItempropCount++;
                    }

                    sAPPressButtonOnTreeItempropCount++;
                }
                else
                {
                    sAPPressButtonOnTreeItem["SearchColumnTitleIsRegularExpression"] = false;
                    sAPPressButtonOnTreeItempropCount++;
                }

                if (sAPPressButtonOnTreeItemsearchColumnTitleIsCaseSensitive != null)
                {
                    if (sAPPressButtonOnTreeItemsearchColumnTitleIsCaseSensitive != null)
                    {
                        sAPPressButtonOnTreeItem["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPPressButtonOnTreeItemsearchColumnTitleIsCaseSensitive);
                        sAPPressButtonOnTreeItempropCount++;
                    }

                    sAPPressButtonOnTreeItempropCount++;
                }
                else
                {
                    sAPPressButtonOnTreeItem["SearchColumnTitleIsCaseSensitive"] = false;
                    sAPPressButtonOnTreeItempropCount++;
                }

                if (sAPPressButtonOnTreeItemforce != null)
                {
                    if (sAPPressButtonOnTreeItemforce != null)
                    {
                        sAPPressButtonOnTreeItem["Force"] = ExpressionConverter.ConvertO(sAPPressButtonOnTreeItemforce);
                        sAPPressButtonOnTreeItempropCount++;
                    }

                    sAPPressButtonOnTreeItempropCount++;
                }
                else
                {
                    sAPPressButtonOnTreeItem["Force"] = false;
                    sAPPressButtonOnTreeItempropCount++;
                }

                sAPPressButtonOnTreeItempropCount++;
                sAPPressButtonOnTreeItem["Workflow"] = ExpressionConverter.ConvertO(sAPPressButtonOnTreeItemworkflow);
                if (sAPPressButtonOnTreeItempropCount > 0)
                {
                    callPayload.Body = sAPPressButtonOnTreeItem;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPClickLinkOnTreeItem))]
        public IWorkflowAction SAPClickLinkOnTreeItem([WorkflowExpression] Func<string> sAPClickLinkOnTreeItemsearchSAPElementId, [WorkflowExpression] Func<string> sAPClickLinkOnTreeItemworkflow, [WorkflowExpression] Func<string> sAPClickLinkOnTreeItemsearchNodeKey = null, [WorkflowExpression] Func<string> sAPClickLinkOnTreeItemsearchNodePath = null, [WorkflowExpression] Func<string> sAPClickLinkOnTreeItemsearchNodeText = null, [WorkflowExpression] Func<bool> sAPClickLinkOnTreeItemsearchNodeTextIsRegularExpression = null, [WorkflowExpression] Func<bool> sAPClickLinkOnTreeItemsearchNodeTextIsCaseSensitive = null, [WorkflowExpression] Func<string> sAPClickLinkOnTreeItemsearchColumnName = null, [WorkflowExpression] Func<string> sAPClickLinkOnTreeItemsearchColumnTitle = null, [WorkflowExpression] Func<bool> sAPClickLinkOnTreeItemsearchColumnTitleIsRegularExpression = null, [WorkflowExpression] Func<bool> sAPClickLinkOnTreeItemsearchColumnTitleIsCaseSensitive = null, [WorkflowExpression] Func<bool> sAPClickLinkOnTreeItemforce = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSAPClickLinkOnTreeItem(WorkflowValue<string> sAPClickLinkOnTreeItemsearchSAPElementId, WorkflowValue<string> sAPClickLinkOnTreeItemworkflow, WorkflowValue<string> sAPClickLinkOnTreeItemsearchNodeKey = null, WorkflowValue<string> sAPClickLinkOnTreeItemsearchNodePath = null, WorkflowValue<string> sAPClickLinkOnTreeItemsearchNodeText = null, WorkflowValue<bool> sAPClickLinkOnTreeItemsearchNodeTextIsRegularExpression = null, WorkflowValue<bool> sAPClickLinkOnTreeItemsearchNodeTextIsCaseSensitive = null, WorkflowValue<string> sAPClickLinkOnTreeItemsearchColumnName = null, WorkflowValue<string> sAPClickLinkOnTreeItemsearchColumnTitle = null, WorkflowValue<bool> sAPClickLinkOnTreeItemsearchColumnTitleIsRegularExpression = null, WorkflowValue<bool> sAPClickLinkOnTreeItemsearchColumnTitleIsCaseSensitive = null, WorkflowValue<bool> sAPClickLinkOnTreeItemforce = null)
        {
            WorkflowValue.Validate(sAPClickLinkOnTreeItemsearchSAPElementId, nameof(sAPClickLinkOnTreeItemsearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPClickLinkOnTreeItemworkflow, nameof(sAPClickLinkOnTreeItemworkflow), required: true);
            WorkflowValue.Validate(sAPClickLinkOnTreeItemsearchNodeKey, nameof(sAPClickLinkOnTreeItemsearchNodeKey), required: false);
            WorkflowValue.Validate(sAPClickLinkOnTreeItemsearchNodePath, nameof(sAPClickLinkOnTreeItemsearchNodePath), required: false);
            WorkflowValue.Validate(sAPClickLinkOnTreeItemsearchNodeText, nameof(sAPClickLinkOnTreeItemsearchNodeText), required: false);
            WorkflowValue.Validate(sAPClickLinkOnTreeItemsearchNodeTextIsRegularExpression, nameof(sAPClickLinkOnTreeItemsearchNodeTextIsRegularExpression), required: false);
            WorkflowValue.Validate(sAPClickLinkOnTreeItemsearchNodeTextIsCaseSensitive, nameof(sAPClickLinkOnTreeItemsearchNodeTextIsCaseSensitive), required: false);
            WorkflowValue.Validate(sAPClickLinkOnTreeItemsearchColumnName, nameof(sAPClickLinkOnTreeItemsearchColumnName), required: false);
            WorkflowValue.Validate(sAPClickLinkOnTreeItemsearchColumnTitle, nameof(sAPClickLinkOnTreeItemsearchColumnTitle), required: false);
            WorkflowValue.Validate(sAPClickLinkOnTreeItemsearchColumnTitleIsRegularExpression, nameof(sAPClickLinkOnTreeItemsearchColumnTitleIsRegularExpression), required: false);
            WorkflowValue.Validate(sAPClickLinkOnTreeItemsearchColumnTitleIsCaseSensitive, nameof(sAPClickLinkOnTreeItemsearchColumnTitleIsCaseSensitive), required: false);
            WorkflowValue.Validate(sAPClickLinkOnTreeItemforce, nameof(sAPClickLinkOnTreeItemforce), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/SAPGUI/SAPClickLinkOnTreeItem";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPClickLinkOnTreeItem = new JObject();
                var sAPClickLinkOnTreeItempropCount = 0;
                sAPClickLinkOnTreeItempropCount++;
                sAPClickLinkOnTreeItem["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPClickLinkOnTreeItemsearchSAPElementId);
                if (sAPClickLinkOnTreeItemsearchNodeKey != null)
                {
                    sAPClickLinkOnTreeItem["SearchNodeKey"] = ExpressionConverter.ConvertO(sAPClickLinkOnTreeItemsearchNodeKey);
                    sAPClickLinkOnTreeItempropCount++;
                }

                if (sAPClickLinkOnTreeItemsearchNodePath != null)
                {
                    sAPClickLinkOnTreeItem["SearchNodePath"] = ExpressionConverter.ConvertO(sAPClickLinkOnTreeItemsearchNodePath);
                    sAPClickLinkOnTreeItempropCount++;
                }

                if (sAPClickLinkOnTreeItemsearchNodeText != null)
                {
                    sAPClickLinkOnTreeItem["SearchNodeText"] = ExpressionConverter.ConvertO(sAPClickLinkOnTreeItemsearchNodeText);
                    sAPClickLinkOnTreeItempropCount++;
                }

                if (sAPClickLinkOnTreeItemsearchNodeTextIsRegularExpression != null)
                {
                    if (sAPClickLinkOnTreeItemsearchNodeTextIsRegularExpression != null)
                    {
                        sAPClickLinkOnTreeItem["SearchNodeTextIsRegularExpression"] = ExpressionConverter.ConvertO(sAPClickLinkOnTreeItemsearchNodeTextIsRegularExpression);
                        sAPClickLinkOnTreeItempropCount++;
                    }

                    sAPClickLinkOnTreeItempropCount++;
                }
                else
                {
                    sAPClickLinkOnTreeItem["SearchNodeTextIsRegularExpression"] = false;
                    sAPClickLinkOnTreeItempropCount++;
                }

                if (sAPClickLinkOnTreeItemsearchNodeTextIsCaseSensitive != null)
                {
                    if (sAPClickLinkOnTreeItemsearchNodeTextIsCaseSensitive != null)
                    {
                        sAPClickLinkOnTreeItem["SearchNodeTextIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPClickLinkOnTreeItemsearchNodeTextIsCaseSensitive);
                        sAPClickLinkOnTreeItempropCount++;
                    }

                    sAPClickLinkOnTreeItempropCount++;
                }
                else
                {
                    sAPClickLinkOnTreeItem["SearchNodeTextIsCaseSensitive"] = false;
                    sAPClickLinkOnTreeItempropCount++;
                }

                if (sAPClickLinkOnTreeItemsearchColumnName != null)
                {
                    sAPClickLinkOnTreeItem["SearchColumnName"] = ExpressionConverter.ConvertO(sAPClickLinkOnTreeItemsearchColumnName);
                    sAPClickLinkOnTreeItempropCount++;
                }

                if (sAPClickLinkOnTreeItemsearchColumnTitle != null)
                {
                    sAPClickLinkOnTreeItem["SearchColumnTitle"] = ExpressionConverter.ConvertO(sAPClickLinkOnTreeItemsearchColumnTitle);
                    sAPClickLinkOnTreeItempropCount++;
                }

                if (sAPClickLinkOnTreeItemsearchColumnTitleIsRegularExpression != null)
                {
                    if (sAPClickLinkOnTreeItemsearchColumnTitleIsRegularExpression != null)
                    {
                        sAPClickLinkOnTreeItem["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(sAPClickLinkOnTreeItemsearchColumnTitleIsRegularExpression);
                        sAPClickLinkOnTreeItempropCount++;
                    }

                    sAPClickLinkOnTreeItempropCount++;
                }
                else
                {
                    sAPClickLinkOnTreeItem["SearchColumnTitleIsRegularExpression"] = false;
                    sAPClickLinkOnTreeItempropCount++;
                }

                if (sAPClickLinkOnTreeItemsearchColumnTitleIsCaseSensitive != null)
                {
                    if (sAPClickLinkOnTreeItemsearchColumnTitleIsCaseSensitive != null)
                    {
                        sAPClickLinkOnTreeItem["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPClickLinkOnTreeItemsearchColumnTitleIsCaseSensitive);
                        sAPClickLinkOnTreeItempropCount++;
                    }

                    sAPClickLinkOnTreeItempropCount++;
                }
                else
                {
                    sAPClickLinkOnTreeItem["SearchColumnTitleIsCaseSensitive"] = false;
                    sAPClickLinkOnTreeItempropCount++;
                }

                if (sAPClickLinkOnTreeItemforce != null)
                {
                    if (sAPClickLinkOnTreeItemforce != null)
                    {
                        sAPClickLinkOnTreeItem["Force"] = ExpressionConverter.ConvertO(sAPClickLinkOnTreeItemforce);
                        sAPClickLinkOnTreeItempropCount++;
                    }

                    sAPClickLinkOnTreeItempropCount++;
                }
                else
                {
                    sAPClickLinkOnTreeItem["Force"] = false;
                    sAPClickLinkOnTreeItempropCount++;
                }

                sAPClickLinkOnTreeItempropCount++;
                sAPClickLinkOnTreeItem["Workflow"] = ExpressionConverter.ConvertO(sAPClickLinkOnTreeItemworkflow);
                if (sAPClickLinkOnTreeItempropCount > 0)
                {
                    callPayload.Body = sAPClickLinkOnTreeItem;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPCheckTreeItem))]
        public IWorkflowAction SAPCheckTreeItem([WorkflowExpression] Func<string> sAPCheckTreeItemsearchSAPElementId, [WorkflowExpression] Func<string> sAPCheckTreeItemworkflow, [WorkflowExpression] Func<string> sAPCheckTreeItemsearchNodeKey = null, [WorkflowExpression] Func<string> sAPCheckTreeItemsearchNodePath = null, [WorkflowExpression] Func<string> sAPCheckTreeItemsearchNodeText = null, [WorkflowExpression] Func<bool> sAPCheckTreeItemsearchNodeTextIsRegularExpression = null, [WorkflowExpression] Func<bool> sAPCheckTreeItemsearchNodeTextIsCaseSensitive = null, [WorkflowExpression] Func<string> sAPCheckTreeItemsearchColumnName = null, [WorkflowExpression] Func<string> sAPCheckTreeItemsearchColumnTitle = null, [WorkflowExpression] Func<bool> sAPCheckTreeItemsearchColumnTitleIsRegularExpression = null, [WorkflowExpression] Func<bool> sAPCheckTreeItemsearchColumnTitleIsCaseSensitive = null, [WorkflowExpression] Func<bool> sAPCheckTreeItemcheckItem = null, [WorkflowExpression] Func<bool> sAPCheckTreeItemforce = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSAPCheckTreeItem(WorkflowValue<string> sAPCheckTreeItemsearchSAPElementId, WorkflowValue<string> sAPCheckTreeItemworkflow, WorkflowValue<string> sAPCheckTreeItemsearchNodeKey = null, WorkflowValue<string> sAPCheckTreeItemsearchNodePath = null, WorkflowValue<string> sAPCheckTreeItemsearchNodeText = null, WorkflowValue<bool> sAPCheckTreeItemsearchNodeTextIsRegularExpression = null, WorkflowValue<bool> sAPCheckTreeItemsearchNodeTextIsCaseSensitive = null, WorkflowValue<string> sAPCheckTreeItemsearchColumnName = null, WorkflowValue<string> sAPCheckTreeItemsearchColumnTitle = null, WorkflowValue<bool> sAPCheckTreeItemsearchColumnTitleIsRegularExpression = null, WorkflowValue<bool> sAPCheckTreeItemsearchColumnTitleIsCaseSensitive = null, WorkflowValue<bool> sAPCheckTreeItemcheckItem = null, WorkflowValue<bool> sAPCheckTreeItemforce = null)
        {
            WorkflowValue.Validate(sAPCheckTreeItemsearchSAPElementId, nameof(sAPCheckTreeItemsearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPCheckTreeItemworkflow, nameof(sAPCheckTreeItemworkflow), required: true);
            WorkflowValue.Validate(sAPCheckTreeItemsearchNodeKey, nameof(sAPCheckTreeItemsearchNodeKey), required: false);
            WorkflowValue.Validate(sAPCheckTreeItemsearchNodePath, nameof(sAPCheckTreeItemsearchNodePath), required: false);
            WorkflowValue.Validate(sAPCheckTreeItemsearchNodeText, nameof(sAPCheckTreeItemsearchNodeText), required: false);
            WorkflowValue.Validate(sAPCheckTreeItemsearchNodeTextIsRegularExpression, nameof(sAPCheckTreeItemsearchNodeTextIsRegularExpression), required: false);
            WorkflowValue.Validate(sAPCheckTreeItemsearchNodeTextIsCaseSensitive, nameof(sAPCheckTreeItemsearchNodeTextIsCaseSensitive), required: false);
            WorkflowValue.Validate(sAPCheckTreeItemsearchColumnName, nameof(sAPCheckTreeItemsearchColumnName), required: false);
            WorkflowValue.Validate(sAPCheckTreeItemsearchColumnTitle, nameof(sAPCheckTreeItemsearchColumnTitle), required: false);
            WorkflowValue.Validate(sAPCheckTreeItemsearchColumnTitleIsRegularExpression, nameof(sAPCheckTreeItemsearchColumnTitleIsRegularExpression), required: false);
            WorkflowValue.Validate(sAPCheckTreeItemsearchColumnTitleIsCaseSensitive, nameof(sAPCheckTreeItemsearchColumnTitleIsCaseSensitive), required: false);
            WorkflowValue.Validate(sAPCheckTreeItemcheckItem, nameof(sAPCheckTreeItemcheckItem), required: false);
            WorkflowValue.Validate(sAPCheckTreeItemforce, nameof(sAPCheckTreeItemforce), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/SAPGUI/SAPCheckTreeItem";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPCheckTreeItem = new JObject();
                var sAPCheckTreeItempropCount = 0;
                sAPCheckTreeItempropCount++;
                sAPCheckTreeItem["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPCheckTreeItemsearchSAPElementId);
                if (sAPCheckTreeItemsearchNodeKey != null)
                {
                    sAPCheckTreeItem["SearchNodeKey"] = ExpressionConverter.ConvertO(sAPCheckTreeItemsearchNodeKey);
                    sAPCheckTreeItempropCount++;
                }

                if (sAPCheckTreeItemsearchNodePath != null)
                {
                    sAPCheckTreeItem["SearchNodePath"] = ExpressionConverter.ConvertO(sAPCheckTreeItemsearchNodePath);
                    sAPCheckTreeItempropCount++;
                }

                if (sAPCheckTreeItemsearchNodeText != null)
                {
                    sAPCheckTreeItem["SearchNodeText"] = ExpressionConverter.ConvertO(sAPCheckTreeItemsearchNodeText);
                    sAPCheckTreeItempropCount++;
                }

                if (sAPCheckTreeItemsearchNodeTextIsRegularExpression != null)
                {
                    if (sAPCheckTreeItemsearchNodeTextIsRegularExpression != null)
                    {
                        sAPCheckTreeItem["SearchNodeTextIsRegularExpression"] = ExpressionConverter.ConvertO(sAPCheckTreeItemsearchNodeTextIsRegularExpression);
                        sAPCheckTreeItempropCount++;
                    }

                    sAPCheckTreeItempropCount++;
                }
                else
                {
                    sAPCheckTreeItem["SearchNodeTextIsRegularExpression"] = false;
                    sAPCheckTreeItempropCount++;
                }

                if (sAPCheckTreeItemsearchNodeTextIsCaseSensitive != null)
                {
                    if (sAPCheckTreeItemsearchNodeTextIsCaseSensitive != null)
                    {
                        sAPCheckTreeItem["SearchNodeTextIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPCheckTreeItemsearchNodeTextIsCaseSensitive);
                        sAPCheckTreeItempropCount++;
                    }

                    sAPCheckTreeItempropCount++;
                }
                else
                {
                    sAPCheckTreeItem["SearchNodeTextIsCaseSensitive"] = false;
                    sAPCheckTreeItempropCount++;
                }

                if (sAPCheckTreeItemsearchColumnName != null)
                {
                    sAPCheckTreeItem["SearchColumnName"] = ExpressionConverter.ConvertO(sAPCheckTreeItemsearchColumnName);
                    sAPCheckTreeItempropCount++;
                }

                if (sAPCheckTreeItemsearchColumnTitle != null)
                {
                    sAPCheckTreeItem["SearchColumnTitle"] = ExpressionConverter.ConvertO(sAPCheckTreeItemsearchColumnTitle);
                    sAPCheckTreeItempropCount++;
                }

                if (sAPCheckTreeItemsearchColumnTitleIsRegularExpression != null)
                {
                    if (sAPCheckTreeItemsearchColumnTitleIsRegularExpression != null)
                    {
                        sAPCheckTreeItem["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(sAPCheckTreeItemsearchColumnTitleIsRegularExpression);
                        sAPCheckTreeItempropCount++;
                    }

                    sAPCheckTreeItempropCount++;
                }
                else
                {
                    sAPCheckTreeItem["SearchColumnTitleIsRegularExpression"] = false;
                    sAPCheckTreeItempropCount++;
                }

                if (sAPCheckTreeItemsearchColumnTitleIsCaseSensitive != null)
                {
                    if (sAPCheckTreeItemsearchColumnTitleIsCaseSensitive != null)
                    {
                        sAPCheckTreeItem["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPCheckTreeItemsearchColumnTitleIsCaseSensitive);
                        sAPCheckTreeItempropCount++;
                    }

                    sAPCheckTreeItempropCount++;
                }
                else
                {
                    sAPCheckTreeItem["SearchColumnTitleIsCaseSensitive"] = false;
                    sAPCheckTreeItempropCount++;
                }

                if (sAPCheckTreeItemcheckItem != null)
                {
                    if (sAPCheckTreeItemcheckItem != null)
                    {
                        sAPCheckTreeItem["CheckItem"] = ExpressionConverter.ConvertO(sAPCheckTreeItemcheckItem);
                        sAPCheckTreeItempropCount++;
                    }

                    sAPCheckTreeItempropCount++;
                }
                else
                {
                    sAPCheckTreeItem["CheckItem"] = true;
                    sAPCheckTreeItempropCount++;
                }

                if (sAPCheckTreeItemforce != null)
                {
                    if (sAPCheckTreeItemforce != null)
                    {
                        sAPCheckTreeItem["Force"] = ExpressionConverter.ConvertO(sAPCheckTreeItemforce);
                        sAPCheckTreeItempropCount++;
                    }

                    sAPCheckTreeItempropCount++;
                }
                else
                {
                    sAPCheckTreeItem["Force"] = false;
                    sAPCheckTreeItempropCount++;
                }

                sAPCheckTreeItempropCount++;
                sAPCheckTreeItem["Workflow"] = ExpressionConverter.ConvertO(sAPCheckTreeItemworkflow);
                if (sAPCheckTreeItempropCount > 0)
                {
                    callPayload.Body = sAPCheckTreeItem;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPGetTreeColumnHeaders))]
        public IBodyWorkflowAction<SAPGetTreeColumnHeadersResponse> SAPGetTreeColumnHeaders([WorkflowExpression] Func<string> sAPGetTreeColumnHeaderssearchSAPElementId, [WorkflowExpression] Func<string> sAPGetTreeColumnHeadersworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SAPGetTreeColumnHeadersResponse> __BuildSAPGetTreeColumnHeaders(WorkflowValue<string> sAPGetTreeColumnHeaderssearchSAPElementId, WorkflowValue<string> sAPGetTreeColumnHeadersworkflow)
        {
            WorkflowValue.Validate(sAPGetTreeColumnHeaderssearchSAPElementId, nameof(sAPGetTreeColumnHeaderssearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPGetTreeColumnHeadersworkflow, nameof(sAPGetTreeColumnHeadersworkflow), required: true);
            return new DeferredBodyAction<SAPGetTreeColumnHeadersResponse>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetTreeColumnHeaders";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGetTreeColumnHeaders = new JObject();
                var sAPGetTreeColumnHeaderspropCount = 0;
                sAPGetTreeColumnHeaderspropCount++;
                sAPGetTreeColumnHeaders["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGetTreeColumnHeaderssearchSAPElementId);
                sAPGetTreeColumnHeaderspropCount++;
                sAPGetTreeColumnHeaders["Workflow"] = ExpressionConverter.ConvertO(sAPGetTreeColumnHeadersworkflow);
                if (sAPGetTreeColumnHeaderspropCount > 0)
                {
                    callPayload.Body = sAPGetTreeColumnHeaders;
                }

                return new ApiConnectionAction<SAPGetTreeColumnHeadersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPGetTreeItemProperties))]
        public IBodyWorkflowAction<SAPGetTreeItemPropertiesResponse> SAPGetTreeItemProperties([WorkflowExpression] Func<string> sAPGetTreeItemPropertiessearchSAPElementId, [WorkflowExpression] Func<string> sAPGetTreeItemPropertiesworkflow, [WorkflowExpression] Func<string> sAPGetTreeItemPropertiessearchNodeKey = null, [WorkflowExpression] Func<string> sAPGetTreeItemPropertiessearchNodePath = null, [WorkflowExpression] Func<string> sAPGetTreeItemPropertiessearchNodeText = null, [WorkflowExpression] Func<bool> sAPGetTreeItemPropertiessearchNodeTextIsRegularExpression = null, [WorkflowExpression] Func<bool> sAPGetTreeItemPropertiessearchNodeTextIsCaseSensitive = null, [WorkflowExpression] Func<string> sAPGetTreeItemPropertiessearchColumnName = null, [WorkflowExpression] Func<string> sAPGetTreeItemPropertiessearchColumnTitle = null, [WorkflowExpression] Func<bool> sAPGetTreeItemPropertiessearchColumnTitleIsRegularExpression = null, [WorkflowExpression] Func<bool> sAPGetTreeItemPropertiessearchColumnTitleIsCaseSensitive = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SAPGetTreeItemPropertiesResponse> __BuildSAPGetTreeItemProperties(WorkflowValue<string> sAPGetTreeItemPropertiessearchSAPElementId, WorkflowValue<string> sAPGetTreeItemPropertiesworkflow, WorkflowValue<string> sAPGetTreeItemPropertiessearchNodeKey = null, WorkflowValue<string> sAPGetTreeItemPropertiessearchNodePath = null, WorkflowValue<string> sAPGetTreeItemPropertiessearchNodeText = null, WorkflowValue<bool> sAPGetTreeItemPropertiessearchNodeTextIsRegularExpression = null, WorkflowValue<bool> sAPGetTreeItemPropertiessearchNodeTextIsCaseSensitive = null, WorkflowValue<string> sAPGetTreeItemPropertiessearchColumnName = null, WorkflowValue<string> sAPGetTreeItemPropertiessearchColumnTitle = null, WorkflowValue<bool> sAPGetTreeItemPropertiessearchColumnTitleIsRegularExpression = null, WorkflowValue<bool> sAPGetTreeItemPropertiessearchColumnTitleIsCaseSensitive = null)
        {
            WorkflowValue.Validate(sAPGetTreeItemPropertiessearchSAPElementId, nameof(sAPGetTreeItemPropertiessearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPGetTreeItemPropertiesworkflow, nameof(sAPGetTreeItemPropertiesworkflow), required: true);
            WorkflowValue.Validate(sAPGetTreeItemPropertiessearchNodeKey, nameof(sAPGetTreeItemPropertiessearchNodeKey), required: false);
            WorkflowValue.Validate(sAPGetTreeItemPropertiessearchNodePath, nameof(sAPGetTreeItemPropertiessearchNodePath), required: false);
            WorkflowValue.Validate(sAPGetTreeItemPropertiessearchNodeText, nameof(sAPGetTreeItemPropertiessearchNodeText), required: false);
            WorkflowValue.Validate(sAPGetTreeItemPropertiessearchNodeTextIsRegularExpression, nameof(sAPGetTreeItemPropertiessearchNodeTextIsRegularExpression), required: false);
            WorkflowValue.Validate(sAPGetTreeItemPropertiessearchNodeTextIsCaseSensitive, nameof(sAPGetTreeItemPropertiessearchNodeTextIsCaseSensitive), required: false);
            WorkflowValue.Validate(sAPGetTreeItemPropertiessearchColumnName, nameof(sAPGetTreeItemPropertiessearchColumnName), required: false);
            WorkflowValue.Validate(sAPGetTreeItemPropertiessearchColumnTitle, nameof(sAPGetTreeItemPropertiessearchColumnTitle), required: false);
            WorkflowValue.Validate(sAPGetTreeItemPropertiessearchColumnTitleIsRegularExpression, nameof(sAPGetTreeItemPropertiessearchColumnTitleIsRegularExpression), required: false);
            WorkflowValue.Validate(sAPGetTreeItemPropertiessearchColumnTitleIsCaseSensitive, nameof(sAPGetTreeItemPropertiessearchColumnTitleIsCaseSensitive), required: false);
            return new DeferredBodyAction<SAPGetTreeItemPropertiesResponse>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetTreeItemProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGetTreeItemProperties = new JObject();
                var sAPGetTreeItemPropertiespropCount = 0;
                sAPGetTreeItemPropertiespropCount++;
                sAPGetTreeItemProperties["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGetTreeItemPropertiessearchSAPElementId);
                if (sAPGetTreeItemPropertiessearchNodeKey != null)
                {
                    sAPGetTreeItemProperties["SearchNodeKey"] = ExpressionConverter.ConvertO(sAPGetTreeItemPropertiessearchNodeKey);
                    sAPGetTreeItemPropertiespropCount++;
                }

                if (sAPGetTreeItemPropertiessearchNodePath != null)
                {
                    sAPGetTreeItemProperties["SearchNodePath"] = ExpressionConverter.ConvertO(sAPGetTreeItemPropertiessearchNodePath);
                    sAPGetTreeItemPropertiespropCount++;
                }

                if (sAPGetTreeItemPropertiessearchNodeText != null)
                {
                    sAPGetTreeItemProperties["SearchNodeText"] = ExpressionConverter.ConvertO(sAPGetTreeItemPropertiessearchNodeText);
                    sAPGetTreeItemPropertiespropCount++;
                }

                if (sAPGetTreeItemPropertiessearchNodeTextIsRegularExpression != null)
                {
                    if (sAPGetTreeItemPropertiessearchNodeTextIsRegularExpression != null)
                    {
                        sAPGetTreeItemProperties["SearchNodeTextIsRegularExpression"] = ExpressionConverter.ConvertO(sAPGetTreeItemPropertiessearchNodeTextIsRegularExpression);
                        sAPGetTreeItemPropertiespropCount++;
                    }

                    sAPGetTreeItemPropertiespropCount++;
                }
                else
                {
                    sAPGetTreeItemProperties["SearchNodeTextIsRegularExpression"] = false;
                    sAPGetTreeItemPropertiespropCount++;
                }

                if (sAPGetTreeItemPropertiessearchNodeTextIsCaseSensitive != null)
                {
                    if (sAPGetTreeItemPropertiessearchNodeTextIsCaseSensitive != null)
                    {
                        sAPGetTreeItemProperties["SearchNodeTextIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPGetTreeItemPropertiessearchNodeTextIsCaseSensitive);
                        sAPGetTreeItemPropertiespropCount++;
                    }

                    sAPGetTreeItemPropertiespropCount++;
                }
                else
                {
                    sAPGetTreeItemProperties["SearchNodeTextIsCaseSensitive"] = false;
                    sAPGetTreeItemPropertiespropCount++;
                }

                if (sAPGetTreeItemPropertiessearchColumnName != null)
                {
                    sAPGetTreeItemProperties["SearchColumnName"] = ExpressionConverter.ConvertO(sAPGetTreeItemPropertiessearchColumnName);
                    sAPGetTreeItemPropertiespropCount++;
                }

                if (sAPGetTreeItemPropertiessearchColumnTitle != null)
                {
                    sAPGetTreeItemProperties["SearchColumnTitle"] = ExpressionConverter.ConvertO(sAPGetTreeItemPropertiessearchColumnTitle);
                    sAPGetTreeItemPropertiespropCount++;
                }

                if (sAPGetTreeItemPropertiessearchColumnTitleIsRegularExpression != null)
                {
                    if (sAPGetTreeItemPropertiessearchColumnTitleIsRegularExpression != null)
                    {
                        sAPGetTreeItemProperties["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(sAPGetTreeItemPropertiessearchColumnTitleIsRegularExpression);
                        sAPGetTreeItemPropertiespropCount++;
                    }

                    sAPGetTreeItemPropertiespropCount++;
                }
                else
                {
                    sAPGetTreeItemProperties["SearchColumnTitleIsRegularExpression"] = false;
                    sAPGetTreeItemPropertiespropCount++;
                }

                if (sAPGetTreeItemPropertiessearchColumnTitleIsCaseSensitive != null)
                {
                    if (sAPGetTreeItemPropertiessearchColumnTitleIsCaseSensitive != null)
                    {
                        sAPGetTreeItemProperties["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPGetTreeItemPropertiessearchColumnTitleIsCaseSensitive);
                        sAPGetTreeItemPropertiespropCount++;
                    }

                    sAPGetTreeItemPropertiespropCount++;
                }
                else
                {
                    sAPGetTreeItemProperties["SearchColumnTitleIsCaseSensitive"] = false;
                    sAPGetTreeItemPropertiespropCount++;
                }

                sAPGetTreeItemPropertiespropCount++;
                sAPGetTreeItemProperties["Workflow"] = ExpressionConverter.ConvertO(sAPGetTreeItemPropertiesworkflow);
                if (sAPGetTreeItemPropertiespropCount > 0)
                {
                    callPayload.Body = sAPGetTreeItemProperties;
                }

                return new ApiConnectionAction<SAPGetTreeItemPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPGetShellToolbarElements))]
        public IBodyWorkflowAction<SAPGetShellToolbarElementsResponse> SAPGetShellToolbarElements([WorkflowExpression] Func<string> sAPGetShellToolbarElementssearchSAPElementId, [WorkflowExpression] Func<string> sAPGetShellToolbarElementsworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SAPGetShellToolbarElementsResponse> __BuildSAPGetShellToolbarElements(WorkflowValue<string> sAPGetShellToolbarElementssearchSAPElementId, WorkflowValue<string> sAPGetShellToolbarElementsworkflow)
        {
            WorkflowValue.Validate(sAPGetShellToolbarElementssearchSAPElementId, nameof(sAPGetShellToolbarElementssearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPGetShellToolbarElementsworkflow, nameof(sAPGetShellToolbarElementsworkflow), required: true);
            return new DeferredBodyAction<SAPGetShellToolbarElementsResponse>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetShellToolbarElements";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGetShellToolbarElements = new JObject();
                var sAPGetShellToolbarElementspropCount = 0;
                sAPGetShellToolbarElementspropCount++;
                sAPGetShellToolbarElements["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGetShellToolbarElementssearchSAPElementId);
                sAPGetShellToolbarElementspropCount++;
                sAPGetShellToolbarElements["Workflow"] = ExpressionConverter.ConvertO(sAPGetShellToolbarElementsworkflow);
                if (sAPGetShellToolbarElementspropCount > 0)
                {
                    callPayload.Body = sAPGetShellToolbarElements;
                }

                return new ApiConnectionAction<SAPGetShellToolbarElementsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPPressShellToolbarElement))]
        public IWorkflowAction SAPPressShellToolbarElement([WorkflowExpression] Func<string> sAPPressShellToolbarElementsearchSAPElementId, [WorkflowExpression] Func<string> sAPPressShellToolbarElementworkflow, [WorkflowExpression] Func<string> sAPPressShellToolbarElementsearchToolbarElementId = null, [WorkflowExpression] Func<string> sAPPressShellToolbarElementsearchToolbarElementText = null, [WorkflowExpression] Func<int> sAPPressShellToolbarElementsearchToolbarElementIndex = null, [WorkflowExpression] Func<bool> sAPPressShellToolbarElementsearchToolbarTextIsRegularExpression = null, [WorkflowExpression] Func<bool> sAPPressShellToolbarElementsearchToolbarTextIsCaseSensitive = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSAPPressShellToolbarElement(WorkflowValue<string> sAPPressShellToolbarElementsearchSAPElementId, WorkflowValue<string> sAPPressShellToolbarElementworkflow, WorkflowValue<string> sAPPressShellToolbarElementsearchToolbarElementId = null, WorkflowValue<string> sAPPressShellToolbarElementsearchToolbarElementText = null, WorkflowValue<int> sAPPressShellToolbarElementsearchToolbarElementIndex = null, WorkflowValue<bool> sAPPressShellToolbarElementsearchToolbarTextIsRegularExpression = null, WorkflowValue<bool> sAPPressShellToolbarElementsearchToolbarTextIsCaseSensitive = null)
        {
            WorkflowValue.Validate(sAPPressShellToolbarElementsearchSAPElementId, nameof(sAPPressShellToolbarElementsearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPPressShellToolbarElementworkflow, nameof(sAPPressShellToolbarElementworkflow), required: true);
            WorkflowValue.Validate(sAPPressShellToolbarElementsearchToolbarElementId, nameof(sAPPressShellToolbarElementsearchToolbarElementId), required: false);
            WorkflowValue.Validate(sAPPressShellToolbarElementsearchToolbarElementText, nameof(sAPPressShellToolbarElementsearchToolbarElementText), required: false);
            WorkflowValue.Validate(sAPPressShellToolbarElementsearchToolbarElementIndex, nameof(sAPPressShellToolbarElementsearchToolbarElementIndex), required: false);
            WorkflowValue.Validate(sAPPressShellToolbarElementsearchToolbarTextIsRegularExpression, nameof(sAPPressShellToolbarElementsearchToolbarTextIsRegularExpression), required: false);
            WorkflowValue.Validate(sAPPressShellToolbarElementsearchToolbarTextIsCaseSensitive, nameof(sAPPressShellToolbarElementsearchToolbarTextIsCaseSensitive), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/SAPGUI/SAPPressShellToolbarElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPPressShellToolbarElement = new JObject();
                var sAPPressShellToolbarElementpropCount = 0;
                sAPPressShellToolbarElementpropCount++;
                sAPPressShellToolbarElement["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPPressShellToolbarElementsearchSAPElementId);
                if (sAPPressShellToolbarElementsearchToolbarElementId != null)
                {
                    sAPPressShellToolbarElement["SearchToolbarElementId"] = ExpressionConverter.ConvertO(sAPPressShellToolbarElementsearchToolbarElementId);
                    sAPPressShellToolbarElementpropCount++;
                }

                if (sAPPressShellToolbarElementsearchToolbarElementText != null)
                {
                    sAPPressShellToolbarElement["SearchToolbarElementText"] = ExpressionConverter.ConvertO(sAPPressShellToolbarElementsearchToolbarElementText);
                    sAPPressShellToolbarElementpropCount++;
                }

                if (sAPPressShellToolbarElementsearchToolbarElementIndex != null)
                {
                    if (sAPPressShellToolbarElementsearchToolbarElementIndex != null)
                    {
                        sAPPressShellToolbarElement["SearchToolbarElementIndex"] = ExpressionConverter.ConvertO(sAPPressShellToolbarElementsearchToolbarElementIndex);
                        sAPPressShellToolbarElementpropCount++;
                    }

                    sAPPressShellToolbarElementpropCount++;
                }
                else
                {
                    sAPPressShellToolbarElement["SearchToolbarElementIndex"] = 0;
                    sAPPressShellToolbarElementpropCount++;
                }

                if (sAPPressShellToolbarElementsearchToolbarTextIsRegularExpression != null)
                {
                    if (sAPPressShellToolbarElementsearchToolbarTextIsRegularExpression != null)
                    {
                        sAPPressShellToolbarElement["SearchToolbarTextIsRegularExpression"] = ExpressionConverter.ConvertO(sAPPressShellToolbarElementsearchToolbarTextIsRegularExpression);
                        sAPPressShellToolbarElementpropCount++;
                    }

                    sAPPressShellToolbarElementpropCount++;
                }
                else
                {
                    sAPPressShellToolbarElement["SearchToolbarTextIsRegularExpression"] = false;
                    sAPPressShellToolbarElementpropCount++;
                }

                if (sAPPressShellToolbarElementsearchToolbarTextIsCaseSensitive != null)
                {
                    if (sAPPressShellToolbarElementsearchToolbarTextIsCaseSensitive != null)
                    {
                        sAPPressShellToolbarElement["SearchToolbarTextIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPPressShellToolbarElementsearchToolbarTextIsCaseSensitive);
                        sAPPressShellToolbarElementpropCount++;
                    }

                    sAPPressShellToolbarElementpropCount++;
                }
                else
                {
                    sAPPressShellToolbarElement["SearchToolbarTextIsCaseSensitive"] = false;
                    sAPPressShellToolbarElementpropCount++;
                }

                sAPPressShellToolbarElementpropCount++;
                sAPPressShellToolbarElement["Workflow"] = ExpressionConverter.ConvertO(sAPPressShellToolbarElementworkflow);
                if (sAPPressShellToolbarElementpropCount > 0)
                {
                    callPayload.Body = sAPPressShellToolbarElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPPressShellToolbarElementContextButton))]
        public IWorkflowAction SAPPressShellToolbarElementContextButton([WorkflowExpression] Func<string> sAPPressShellToolbarElementContextButtonsearchSAPElementId, [WorkflowExpression] Func<string> sAPPressShellToolbarElementContextButtonworkflow, [WorkflowExpression] Func<string> sAPPressShellToolbarElementContextButtonsearchToolbarElementId = null, [WorkflowExpression] Func<string> sAPPressShellToolbarElementContextButtonsearchToolbarElementText = null, [WorkflowExpression] Func<int> sAPPressShellToolbarElementContextButtonsearchToolbarElementIndex = null, [WorkflowExpression] Func<bool> sAPPressShellToolbarElementContextButtonsearchToolbarTextIsRegularExpression = null, [WorkflowExpression] Func<bool> sAPPressShellToolbarElementContextButtonsearchToolbarTextIsCaseSensitive = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSAPPressShellToolbarElementContextButton(WorkflowValue<string> sAPPressShellToolbarElementContextButtonsearchSAPElementId, WorkflowValue<string> sAPPressShellToolbarElementContextButtonworkflow, WorkflowValue<string> sAPPressShellToolbarElementContextButtonsearchToolbarElementId = null, WorkflowValue<string> sAPPressShellToolbarElementContextButtonsearchToolbarElementText = null, WorkflowValue<int> sAPPressShellToolbarElementContextButtonsearchToolbarElementIndex = null, WorkflowValue<bool> sAPPressShellToolbarElementContextButtonsearchToolbarTextIsRegularExpression = null, WorkflowValue<bool> sAPPressShellToolbarElementContextButtonsearchToolbarTextIsCaseSensitive = null)
        {
            WorkflowValue.Validate(sAPPressShellToolbarElementContextButtonsearchSAPElementId, nameof(sAPPressShellToolbarElementContextButtonsearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPPressShellToolbarElementContextButtonworkflow, nameof(sAPPressShellToolbarElementContextButtonworkflow), required: true);
            WorkflowValue.Validate(sAPPressShellToolbarElementContextButtonsearchToolbarElementId, nameof(sAPPressShellToolbarElementContextButtonsearchToolbarElementId), required: false);
            WorkflowValue.Validate(sAPPressShellToolbarElementContextButtonsearchToolbarElementText, nameof(sAPPressShellToolbarElementContextButtonsearchToolbarElementText), required: false);
            WorkflowValue.Validate(sAPPressShellToolbarElementContextButtonsearchToolbarElementIndex, nameof(sAPPressShellToolbarElementContextButtonsearchToolbarElementIndex), required: false);
            WorkflowValue.Validate(sAPPressShellToolbarElementContextButtonsearchToolbarTextIsRegularExpression, nameof(sAPPressShellToolbarElementContextButtonsearchToolbarTextIsRegularExpression), required: false);
            WorkflowValue.Validate(sAPPressShellToolbarElementContextButtonsearchToolbarTextIsCaseSensitive, nameof(sAPPressShellToolbarElementContextButtonsearchToolbarTextIsCaseSensitive), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/SAPGUI/SAPPressShellToolbarElementContextButton";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPPressShellToolbarElementContextButton = new JObject();
                var sAPPressShellToolbarElementContextButtonpropCount = 0;
                sAPPressShellToolbarElementContextButtonpropCount++;
                sAPPressShellToolbarElementContextButton["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPPressShellToolbarElementContextButtonsearchSAPElementId);
                if (sAPPressShellToolbarElementContextButtonsearchToolbarElementId != null)
                {
                    sAPPressShellToolbarElementContextButton["SearchToolbarElementId"] = ExpressionConverter.ConvertO(sAPPressShellToolbarElementContextButtonsearchToolbarElementId);
                    sAPPressShellToolbarElementContextButtonpropCount++;
                }

                if (sAPPressShellToolbarElementContextButtonsearchToolbarElementText != null)
                {
                    sAPPressShellToolbarElementContextButton["SearchToolbarElementText"] = ExpressionConverter.ConvertO(sAPPressShellToolbarElementContextButtonsearchToolbarElementText);
                    sAPPressShellToolbarElementContextButtonpropCount++;
                }

                if (sAPPressShellToolbarElementContextButtonsearchToolbarElementIndex != null)
                {
                    if (sAPPressShellToolbarElementContextButtonsearchToolbarElementIndex != null)
                    {
                        sAPPressShellToolbarElementContextButton["SearchToolbarElementIndex"] = ExpressionConverter.ConvertO(sAPPressShellToolbarElementContextButtonsearchToolbarElementIndex);
                        sAPPressShellToolbarElementContextButtonpropCount++;
                    }

                    sAPPressShellToolbarElementContextButtonpropCount++;
                }
                else
                {
                    sAPPressShellToolbarElementContextButton["SearchToolbarElementIndex"] = 0;
                    sAPPressShellToolbarElementContextButtonpropCount++;
                }

                if (sAPPressShellToolbarElementContextButtonsearchToolbarTextIsRegularExpression != null)
                {
                    if (sAPPressShellToolbarElementContextButtonsearchToolbarTextIsRegularExpression != null)
                    {
                        sAPPressShellToolbarElementContextButton["SearchToolbarTextIsRegularExpression"] = ExpressionConverter.ConvertO(sAPPressShellToolbarElementContextButtonsearchToolbarTextIsRegularExpression);
                        sAPPressShellToolbarElementContextButtonpropCount++;
                    }

                    sAPPressShellToolbarElementContextButtonpropCount++;
                }
                else
                {
                    sAPPressShellToolbarElementContextButton["SearchToolbarTextIsRegularExpression"] = false;
                    sAPPressShellToolbarElementContextButtonpropCount++;
                }

                if (sAPPressShellToolbarElementContextButtonsearchToolbarTextIsCaseSensitive != null)
                {
                    if (sAPPressShellToolbarElementContextButtonsearchToolbarTextIsCaseSensitive != null)
                    {
                        sAPPressShellToolbarElementContextButton["SearchToolbarTextIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPPressShellToolbarElementContextButtonsearchToolbarTextIsCaseSensitive);
                        sAPPressShellToolbarElementContextButtonpropCount++;
                    }

                    sAPPressShellToolbarElementContextButtonpropCount++;
                }
                else
                {
                    sAPPressShellToolbarElementContextButton["SearchToolbarTextIsCaseSensitive"] = false;
                    sAPPressShellToolbarElementContextButtonpropCount++;
                }

                sAPPressShellToolbarElementContextButtonpropCount++;
                sAPPressShellToolbarElementContextButton["Workflow"] = ExpressionConverter.ConvertO(sAPPressShellToolbarElementContextButtonworkflow);
                if (sAPPressShellToolbarElementContextButtonpropCount > 0)
                {
                    callPayload.Body = sAPPressShellToolbarElementContextButton;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPSelectShellToolbarMenuItem))]
        public IWorkflowAction SAPSelectShellToolbarMenuItem([WorkflowExpression] Func<string> sAPSelectShellToolbarMenuItemsearchSAPElementId, [WorkflowExpression] Func<string> sAPSelectShellToolbarMenuItemworkflow, [WorkflowExpression] Func<string> sAPSelectShellToolbarMenuItemsearchToolbarElementId = null, [WorkflowExpression] Func<string> sAPSelectShellToolbarMenuItemsearchToolbarElementText = null, [WorkflowExpression] Func<int> sAPSelectShellToolbarMenuItemsearchToolbarElementIndex = null, [WorkflowExpression] Func<bool> sAPSelectShellToolbarMenuItemsearchToolbarTextIsRegularExpression = null, [WorkflowExpression] Func<bool> sAPSelectShellToolbarMenuItemsearchToolbarTextIsCaseSensitive = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSAPSelectShellToolbarMenuItem(WorkflowValue<string> sAPSelectShellToolbarMenuItemsearchSAPElementId, WorkflowValue<string> sAPSelectShellToolbarMenuItemworkflow, WorkflowValue<string> sAPSelectShellToolbarMenuItemsearchToolbarElementId = null, WorkflowValue<string> sAPSelectShellToolbarMenuItemsearchToolbarElementText = null, WorkflowValue<int> sAPSelectShellToolbarMenuItemsearchToolbarElementIndex = null, WorkflowValue<bool> sAPSelectShellToolbarMenuItemsearchToolbarTextIsRegularExpression = null, WorkflowValue<bool> sAPSelectShellToolbarMenuItemsearchToolbarTextIsCaseSensitive = null)
        {
            WorkflowValue.Validate(sAPSelectShellToolbarMenuItemsearchSAPElementId, nameof(sAPSelectShellToolbarMenuItemsearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPSelectShellToolbarMenuItemworkflow, nameof(sAPSelectShellToolbarMenuItemworkflow), required: true);
            WorkflowValue.Validate(sAPSelectShellToolbarMenuItemsearchToolbarElementId, nameof(sAPSelectShellToolbarMenuItemsearchToolbarElementId), required: false);
            WorkflowValue.Validate(sAPSelectShellToolbarMenuItemsearchToolbarElementText, nameof(sAPSelectShellToolbarMenuItemsearchToolbarElementText), required: false);
            WorkflowValue.Validate(sAPSelectShellToolbarMenuItemsearchToolbarElementIndex, nameof(sAPSelectShellToolbarMenuItemsearchToolbarElementIndex), required: false);
            WorkflowValue.Validate(sAPSelectShellToolbarMenuItemsearchToolbarTextIsRegularExpression, nameof(sAPSelectShellToolbarMenuItemsearchToolbarTextIsRegularExpression), required: false);
            WorkflowValue.Validate(sAPSelectShellToolbarMenuItemsearchToolbarTextIsCaseSensitive, nameof(sAPSelectShellToolbarMenuItemsearchToolbarTextIsCaseSensitive), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSelectShellToolbarMenuItem";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPSelectShellToolbarMenuItem = new JObject();
                var sAPSelectShellToolbarMenuItempropCount = 0;
                sAPSelectShellToolbarMenuItempropCount++;
                sAPSelectShellToolbarMenuItem["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPSelectShellToolbarMenuItemsearchSAPElementId);
                if (sAPSelectShellToolbarMenuItemsearchToolbarElementId != null)
                {
                    sAPSelectShellToolbarMenuItem["SearchToolbarElementId"] = ExpressionConverter.ConvertO(sAPSelectShellToolbarMenuItemsearchToolbarElementId);
                    sAPSelectShellToolbarMenuItempropCount++;
                }

                if (sAPSelectShellToolbarMenuItemsearchToolbarElementText != null)
                {
                    sAPSelectShellToolbarMenuItem["SearchToolbarElementText"] = ExpressionConverter.ConvertO(sAPSelectShellToolbarMenuItemsearchToolbarElementText);
                    sAPSelectShellToolbarMenuItempropCount++;
                }

                if (sAPSelectShellToolbarMenuItemsearchToolbarElementIndex != null)
                {
                    if (sAPSelectShellToolbarMenuItemsearchToolbarElementIndex != null)
                    {
                        sAPSelectShellToolbarMenuItem["SearchToolbarElementIndex"] = ExpressionConverter.ConvertO(sAPSelectShellToolbarMenuItemsearchToolbarElementIndex);
                        sAPSelectShellToolbarMenuItempropCount++;
                    }

                    sAPSelectShellToolbarMenuItempropCount++;
                }
                else
                {
                    sAPSelectShellToolbarMenuItem["SearchToolbarElementIndex"] = 0;
                    sAPSelectShellToolbarMenuItempropCount++;
                }

                if (sAPSelectShellToolbarMenuItemsearchToolbarTextIsRegularExpression != null)
                {
                    if (sAPSelectShellToolbarMenuItemsearchToolbarTextIsRegularExpression != null)
                    {
                        sAPSelectShellToolbarMenuItem["SearchToolbarTextIsRegularExpression"] = ExpressionConverter.ConvertO(sAPSelectShellToolbarMenuItemsearchToolbarTextIsRegularExpression);
                        sAPSelectShellToolbarMenuItempropCount++;
                    }

                    sAPSelectShellToolbarMenuItempropCount++;
                }
                else
                {
                    sAPSelectShellToolbarMenuItem["SearchToolbarTextIsRegularExpression"] = false;
                    sAPSelectShellToolbarMenuItempropCount++;
                }

                if (sAPSelectShellToolbarMenuItemsearchToolbarTextIsCaseSensitive != null)
                {
                    if (sAPSelectShellToolbarMenuItemsearchToolbarTextIsCaseSensitive != null)
                    {
                        sAPSelectShellToolbarMenuItem["SearchToolbarTextIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPSelectShellToolbarMenuItemsearchToolbarTextIsCaseSensitive);
                        sAPSelectShellToolbarMenuItempropCount++;
                    }

                    sAPSelectShellToolbarMenuItempropCount++;
                }
                else
                {
                    sAPSelectShellToolbarMenuItem["SearchToolbarTextIsCaseSensitive"] = false;
                    sAPSelectShellToolbarMenuItempropCount++;
                }

                sAPSelectShellToolbarMenuItempropCount++;
                sAPSelectShellToolbarMenuItem["Workflow"] = ExpressionConverter.ConvertO(sAPSelectShellToolbarMenuItemworkflow);
                if (sAPSelectShellToolbarMenuItempropCount > 0)
                {
                    callPayload.Body = sAPSelectShellToolbarMenuItem;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPGetSAPGridViewProperties))]
        public IBodyWorkflowAction<SAPGetSAPGridViewPropertiesResponse> SAPGetSAPGridViewProperties([WorkflowExpression] Func<string> sAPGetSAPGridViewPropertiessearchSAPElementId, [WorkflowExpression] Func<string> sAPGetSAPGridViewPropertiesworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SAPGetSAPGridViewPropertiesResponse> __BuildSAPGetSAPGridViewProperties(WorkflowValue<string> sAPGetSAPGridViewPropertiessearchSAPElementId, WorkflowValue<string> sAPGetSAPGridViewPropertiesworkflow)
        {
            WorkflowValue.Validate(sAPGetSAPGridViewPropertiessearchSAPElementId, nameof(sAPGetSAPGridViewPropertiessearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPGetSAPGridViewPropertiesworkflow, nameof(sAPGetSAPGridViewPropertiesworkflow), required: true);
            return new DeferredBodyAction<SAPGetSAPGridViewPropertiesResponse>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetSAPGridViewProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGetSAPGridViewProperties = new JObject();
                var sAPGetSAPGridViewPropertiespropCount = 0;
                sAPGetSAPGridViewPropertiespropCount++;
                sAPGetSAPGridViewProperties["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGetSAPGridViewPropertiessearchSAPElementId);
                sAPGetSAPGridViewPropertiespropCount++;
                sAPGetSAPGridViewProperties["Workflow"] = ExpressionConverter.ConvertO(sAPGetSAPGridViewPropertiesworkflow);
                if (sAPGetSAPGridViewPropertiespropCount > 0)
                {
                    callPayload.Body = sAPGetSAPGridViewProperties;
                }

                return new ApiConnectionAction<SAPGetSAPGridViewPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPGetSAPGridViewCellContentsAtIndex))]
        public IBodyWorkflowAction<SAPGetSAPGridViewCellContentsAtIndexResponse> SAPGetSAPGridViewCellContentsAtIndex([WorkflowExpression] Func<string> sAPGetSAPGridViewCellContentsAtIndexsearchSAPElementId, [WorkflowExpression] Func<int> sAPGetSAPGridViewCellContentsAtIndexrowIndex, [WorkflowExpression] Func<string> sAPGetSAPGridViewCellContentsAtIndexworkflow, [WorkflowExpression] Func<string> sAPGetSAPGridViewCellContentsAtIndexsearchColumnName = null, [WorkflowExpression] Func<string> sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitle = null, [WorkflowExpression] Func<bool> sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitleIsRegularExpression = null, [WorkflowExpression] Func<bool> sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitleIsCaseSensitive = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SAPGetSAPGridViewCellContentsAtIndexResponse> __BuildSAPGetSAPGridViewCellContentsAtIndex(WorkflowValue<string> sAPGetSAPGridViewCellContentsAtIndexsearchSAPElementId, WorkflowValue<int> sAPGetSAPGridViewCellContentsAtIndexrowIndex, WorkflowValue<string> sAPGetSAPGridViewCellContentsAtIndexworkflow, WorkflowValue<string> sAPGetSAPGridViewCellContentsAtIndexsearchColumnName = null, WorkflowValue<string> sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitle = null, WorkflowValue<bool> sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitleIsRegularExpression = null, WorkflowValue<bool> sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitleIsCaseSensitive = null)
        {
            WorkflowValue.Validate(sAPGetSAPGridViewCellContentsAtIndexsearchSAPElementId, nameof(sAPGetSAPGridViewCellContentsAtIndexsearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPGetSAPGridViewCellContentsAtIndexrowIndex, nameof(sAPGetSAPGridViewCellContentsAtIndexrowIndex), required: true);
            WorkflowValue.Validate(sAPGetSAPGridViewCellContentsAtIndexworkflow, nameof(sAPGetSAPGridViewCellContentsAtIndexworkflow), required: true);
            WorkflowValue.Validate(sAPGetSAPGridViewCellContentsAtIndexsearchColumnName, nameof(sAPGetSAPGridViewCellContentsAtIndexsearchColumnName), required: false);
            WorkflowValue.Validate(sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitle, nameof(sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitle), required: false);
            WorkflowValue.Validate(sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitleIsRegularExpression, nameof(sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitleIsRegularExpression), required: false);
            WorkflowValue.Validate(sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitleIsCaseSensitive, nameof(sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitleIsCaseSensitive), required: false);
            return new DeferredBodyAction<SAPGetSAPGridViewCellContentsAtIndexResponse>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetSAPGridViewCellContentsAtIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGetSAPGridViewCellContentsAtIndex = new JObject();
                var sAPGetSAPGridViewCellContentsAtIndexpropCount = 0;
                sAPGetSAPGridViewCellContentsAtIndexpropCount++;
                sAPGetSAPGridViewCellContentsAtIndex["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGetSAPGridViewCellContentsAtIndexsearchSAPElementId);
                sAPGetSAPGridViewCellContentsAtIndexpropCount++;
                sAPGetSAPGridViewCellContentsAtIndex["RowIndex"] = ExpressionConverter.ConvertO(sAPGetSAPGridViewCellContentsAtIndexrowIndex);
                if (sAPGetSAPGridViewCellContentsAtIndexsearchColumnName != null)
                {
                    sAPGetSAPGridViewCellContentsAtIndex["SearchColumnName"] = ExpressionConverter.ConvertO(sAPGetSAPGridViewCellContentsAtIndexsearchColumnName);
                    sAPGetSAPGridViewCellContentsAtIndexpropCount++;
                }

                if (sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitle != null)
                {
                    sAPGetSAPGridViewCellContentsAtIndex["SearchColumnTitle"] = ExpressionConverter.ConvertO(sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitle);
                    sAPGetSAPGridViewCellContentsAtIndexpropCount++;
                }

                if (sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitleIsRegularExpression != null)
                {
                    if (sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitleIsRegularExpression != null)
                    {
                        sAPGetSAPGridViewCellContentsAtIndex["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitleIsRegularExpression);
                        sAPGetSAPGridViewCellContentsAtIndexpropCount++;
                    }

                    sAPGetSAPGridViewCellContentsAtIndexpropCount++;
                }
                else
                {
                    sAPGetSAPGridViewCellContentsAtIndex["SearchColumnTitleIsRegularExpression"] = false;
                    sAPGetSAPGridViewCellContentsAtIndexpropCount++;
                }

                if (sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitleIsCaseSensitive != null)
                {
                    if (sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitleIsCaseSensitive != null)
                    {
                        sAPGetSAPGridViewCellContentsAtIndex["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitleIsCaseSensitive);
                        sAPGetSAPGridViewCellContentsAtIndexpropCount++;
                    }

                    sAPGetSAPGridViewCellContentsAtIndexpropCount++;
                }
                else
                {
                    sAPGetSAPGridViewCellContentsAtIndex["SearchColumnTitleIsCaseSensitive"] = false;
                    sAPGetSAPGridViewCellContentsAtIndexpropCount++;
                }

                sAPGetSAPGridViewCellContentsAtIndexpropCount++;
                sAPGetSAPGridViewCellContentsAtIndex["Workflow"] = ExpressionConverter.ConvertO(sAPGetSAPGridViewCellContentsAtIndexworkflow);
                if (sAPGetSAPGridViewCellContentsAtIndexpropCount > 0)
                {
                    callPayload.Body = sAPGetSAPGridViewCellContentsAtIndex;
                }

                return new ApiConnectionAction<SAPGetSAPGridViewCellContentsAtIndexResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPGetSAPGridViewCellPropertiesAtIndex))]
        public IBodyWorkflowAction<SAPGetSAPGridViewCellPropertiesAtIndexResponse> SAPGetSAPGridViewCellPropertiesAtIndex([WorkflowExpression] Func<string> sAPGetSAPGridViewCellPropertiesAtIndexsearchSAPElementId, [WorkflowExpression] Func<int> sAPGetSAPGridViewCellPropertiesAtIndexrowIndex, [WorkflowExpression] Func<string> sAPGetSAPGridViewCellPropertiesAtIndexworkflow, [WorkflowExpression] Func<string> sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnName = null, [WorkflowExpression] Func<string> sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitle = null, [WorkflowExpression] Func<bool> sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitleIsRegularExpression = null, [WorkflowExpression] Func<bool> sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitleIsCaseSensitive = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SAPGetSAPGridViewCellPropertiesAtIndexResponse> __BuildSAPGetSAPGridViewCellPropertiesAtIndex(WorkflowValue<string> sAPGetSAPGridViewCellPropertiesAtIndexsearchSAPElementId, WorkflowValue<int> sAPGetSAPGridViewCellPropertiesAtIndexrowIndex, WorkflowValue<string> sAPGetSAPGridViewCellPropertiesAtIndexworkflow, WorkflowValue<string> sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnName = null, WorkflowValue<string> sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitle = null, WorkflowValue<bool> sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitleIsRegularExpression = null, WorkflowValue<bool> sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitleIsCaseSensitive = null)
        {
            WorkflowValue.Validate(sAPGetSAPGridViewCellPropertiesAtIndexsearchSAPElementId, nameof(sAPGetSAPGridViewCellPropertiesAtIndexsearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPGetSAPGridViewCellPropertiesAtIndexrowIndex, nameof(sAPGetSAPGridViewCellPropertiesAtIndexrowIndex), required: true);
            WorkflowValue.Validate(sAPGetSAPGridViewCellPropertiesAtIndexworkflow, nameof(sAPGetSAPGridViewCellPropertiesAtIndexworkflow), required: true);
            WorkflowValue.Validate(sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnName, nameof(sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnName), required: false);
            WorkflowValue.Validate(sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitle, nameof(sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitle), required: false);
            WorkflowValue.Validate(sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitleIsRegularExpression, nameof(sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitleIsRegularExpression), required: false);
            WorkflowValue.Validate(sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitleIsCaseSensitive, nameof(sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitleIsCaseSensitive), required: false);
            return new DeferredBodyAction<SAPGetSAPGridViewCellPropertiesAtIndexResponse>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetSAPGridViewCellPropertiesAtIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGetSAPGridViewCellPropertiesAtIndex = new JObject();
                var sAPGetSAPGridViewCellPropertiesAtIndexpropCount = 0;
                sAPGetSAPGridViewCellPropertiesAtIndexpropCount++;
                sAPGetSAPGridViewCellPropertiesAtIndex["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGetSAPGridViewCellPropertiesAtIndexsearchSAPElementId);
                sAPGetSAPGridViewCellPropertiesAtIndexpropCount++;
                sAPGetSAPGridViewCellPropertiesAtIndex["RowIndex"] = ExpressionConverter.ConvertO(sAPGetSAPGridViewCellPropertiesAtIndexrowIndex);
                if (sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnName != null)
                {
                    sAPGetSAPGridViewCellPropertiesAtIndex["SearchColumnName"] = ExpressionConverter.ConvertO(sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnName);
                    sAPGetSAPGridViewCellPropertiesAtIndexpropCount++;
                }

                if (sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitle != null)
                {
                    sAPGetSAPGridViewCellPropertiesAtIndex["SearchColumnTitle"] = ExpressionConverter.ConvertO(sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitle);
                    sAPGetSAPGridViewCellPropertiesAtIndexpropCount++;
                }

                if (sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitleIsRegularExpression != null)
                {
                    if (sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitleIsRegularExpression != null)
                    {
                        sAPGetSAPGridViewCellPropertiesAtIndex["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitleIsRegularExpression);
                        sAPGetSAPGridViewCellPropertiesAtIndexpropCount++;
                    }

                    sAPGetSAPGridViewCellPropertiesAtIndexpropCount++;
                }
                else
                {
                    sAPGetSAPGridViewCellPropertiesAtIndex["SearchColumnTitleIsRegularExpression"] = false;
                    sAPGetSAPGridViewCellPropertiesAtIndexpropCount++;
                }

                if (sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitleIsCaseSensitive != null)
                {
                    if (sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitleIsCaseSensitive != null)
                    {
                        sAPGetSAPGridViewCellPropertiesAtIndex["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitleIsCaseSensitive);
                        sAPGetSAPGridViewCellPropertiesAtIndexpropCount++;
                    }

                    sAPGetSAPGridViewCellPropertiesAtIndexpropCount++;
                }
                else
                {
                    sAPGetSAPGridViewCellPropertiesAtIndex["SearchColumnTitleIsCaseSensitive"] = false;
                    sAPGetSAPGridViewCellPropertiesAtIndexpropCount++;
                }

                sAPGetSAPGridViewCellPropertiesAtIndexpropCount++;
                sAPGetSAPGridViewCellPropertiesAtIndex["Workflow"] = ExpressionConverter.ConvertO(sAPGetSAPGridViewCellPropertiesAtIndexworkflow);
                if (sAPGetSAPGridViewCellPropertiesAtIndexpropCount > 0)
                {
                    callPayload.Body = sAPGetSAPGridViewCellPropertiesAtIndex;
                }

                return new ApiConnectionAction<SAPGetSAPGridViewCellPropertiesAtIndexResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPDrawRectangleAroundSAPGridViewCellAtIndex))]
        public IWorkflowAction SAPDrawRectangleAroundSAPGridViewCellAtIndex([WorkflowExpression] Func<string> sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchSAPElementId, [WorkflowExpression] Func<int> sAPDrawRectangleAroundSAPGridViewCellAtIndexrowIndex, [WorkflowExpression] Func<string> sAPDrawRectangleAroundSAPGridViewCellAtIndexworkflow, [WorkflowExpression] Func<string> sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnName = null, [WorkflowExpression] Func<string> sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitle = null, [WorkflowExpression] Func<bool> sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression = null, [WorkflowExpression] Func<bool> sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive = null, [WorkflowExpression] Func<string> sAPDrawRectangleAroundSAPGridViewCellAtIndexpenColour = null, [WorkflowExpression] Func<int> sAPDrawRectangleAroundSAPGridViewCellAtIndexpenThicknessPixels = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSAPDrawRectangleAroundSAPGridViewCellAtIndex(WorkflowValue<string> sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchSAPElementId, WorkflowValue<int> sAPDrawRectangleAroundSAPGridViewCellAtIndexrowIndex, WorkflowValue<string> sAPDrawRectangleAroundSAPGridViewCellAtIndexworkflow, WorkflowValue<string> sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnName = null, WorkflowValue<string> sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitle = null, WorkflowValue<bool> sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression = null, WorkflowValue<bool> sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive = null, WorkflowValue<string> sAPDrawRectangleAroundSAPGridViewCellAtIndexpenColour = null, WorkflowValue<int> sAPDrawRectangleAroundSAPGridViewCellAtIndexpenThicknessPixels = null)
        {
            WorkflowValue.Validate(sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchSAPElementId, nameof(sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPDrawRectangleAroundSAPGridViewCellAtIndexrowIndex, nameof(sAPDrawRectangleAroundSAPGridViewCellAtIndexrowIndex), required: true);
            WorkflowValue.Validate(sAPDrawRectangleAroundSAPGridViewCellAtIndexworkflow, nameof(sAPDrawRectangleAroundSAPGridViewCellAtIndexworkflow), required: true);
            WorkflowValue.Validate(sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnName, nameof(sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnName), required: false);
            WorkflowValue.Validate(sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitle, nameof(sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitle), required: false);
            WorkflowValue.Validate(sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression, nameof(sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression), required: false);
            WorkflowValue.Validate(sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive, nameof(sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive), required: false);
            WorkflowValue.Validate(sAPDrawRectangleAroundSAPGridViewCellAtIndexpenColour, nameof(sAPDrawRectangleAroundSAPGridViewCellAtIndexpenColour), required: false);
            WorkflowValue.Validate(sAPDrawRectangleAroundSAPGridViewCellAtIndexpenThicknessPixels, nameof(sAPDrawRectangleAroundSAPGridViewCellAtIndexpenThicknessPixels), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/SAPGUI/SAPDrawRectangleAroundSAPGridViewCellAtIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPDrawRectangleAroundSAPGridViewCellAtIndex = new JObject();
                var sAPDrawRectangleAroundSAPGridViewCellAtIndexpropCount = 0;
                sAPDrawRectangleAroundSAPGridViewCellAtIndexpropCount++;
                sAPDrawRectangleAroundSAPGridViewCellAtIndex["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchSAPElementId);
                sAPDrawRectangleAroundSAPGridViewCellAtIndexpropCount++;
                sAPDrawRectangleAroundSAPGridViewCellAtIndex["RowIndex"] = ExpressionConverter.ConvertO(sAPDrawRectangleAroundSAPGridViewCellAtIndexrowIndex);
                if (sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnName != null)
                {
                    sAPDrawRectangleAroundSAPGridViewCellAtIndex["SearchColumnName"] = ExpressionConverter.ConvertO(sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnName);
                    sAPDrawRectangleAroundSAPGridViewCellAtIndexpropCount++;
                }

                if (sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitle != null)
                {
                    sAPDrawRectangleAroundSAPGridViewCellAtIndex["SearchColumnTitle"] = ExpressionConverter.ConvertO(sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitle);
                    sAPDrawRectangleAroundSAPGridViewCellAtIndexpropCount++;
                }

                if (sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression != null)
                {
                    if (sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression != null)
                    {
                        sAPDrawRectangleAroundSAPGridViewCellAtIndex["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression);
                        sAPDrawRectangleAroundSAPGridViewCellAtIndexpropCount++;
                    }

                    sAPDrawRectangleAroundSAPGridViewCellAtIndexpropCount++;
                }
                else
                {
                    sAPDrawRectangleAroundSAPGridViewCellAtIndex["SearchColumnTitleIsRegularExpression"] = false;
                    sAPDrawRectangleAroundSAPGridViewCellAtIndexpropCount++;
                }

                if (sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive != null)
                {
                    if (sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive != null)
                    {
                        sAPDrawRectangleAroundSAPGridViewCellAtIndex["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive);
                        sAPDrawRectangleAroundSAPGridViewCellAtIndexpropCount++;
                    }

                    sAPDrawRectangleAroundSAPGridViewCellAtIndexpropCount++;
                }
                else
                {
                    sAPDrawRectangleAroundSAPGridViewCellAtIndex["SearchColumnTitleIsCaseSensitive"] = false;
                    sAPDrawRectangleAroundSAPGridViewCellAtIndexpropCount++;
                }

                if (sAPDrawRectangleAroundSAPGridViewCellAtIndexpenColour != null)
                {
                    if (sAPDrawRectangleAroundSAPGridViewCellAtIndexpenColour != null)
                    {
                        sAPDrawRectangleAroundSAPGridViewCellAtIndex["PenColour"] = ExpressionConverter.ConvertO(sAPDrawRectangleAroundSAPGridViewCellAtIndexpenColour);
                        sAPDrawRectangleAroundSAPGridViewCellAtIndexpropCount++;
                    }

                    sAPDrawRectangleAroundSAPGridViewCellAtIndexpropCount++;
                }
                else
                {
                    sAPDrawRectangleAroundSAPGridViewCellAtIndex["PenColour"] = "#009FDE";
                    sAPDrawRectangleAroundSAPGridViewCellAtIndexpropCount++;
                }

                if (sAPDrawRectangleAroundSAPGridViewCellAtIndexpenThicknessPixels != null)
                {
                    if (sAPDrawRectangleAroundSAPGridViewCellAtIndexpenThicknessPixels != null)
                    {
                        sAPDrawRectangleAroundSAPGridViewCellAtIndex["PenThicknessPixels"] = ExpressionConverter.ConvertO(sAPDrawRectangleAroundSAPGridViewCellAtIndexpenThicknessPixels);
                        sAPDrawRectangleAroundSAPGridViewCellAtIndexpropCount++;
                    }

                    sAPDrawRectangleAroundSAPGridViewCellAtIndexpropCount++;
                }
                else
                {
                    sAPDrawRectangleAroundSAPGridViewCellAtIndex["PenThicknessPixels"] = 4;
                    sAPDrawRectangleAroundSAPGridViewCellAtIndexpropCount++;
                }

                sAPDrawRectangleAroundSAPGridViewCellAtIndexpropCount++;
                sAPDrawRectangleAroundSAPGridViewCellAtIndex["Workflow"] = ExpressionConverter.ConvertO(sAPDrawRectangleAroundSAPGridViewCellAtIndexworkflow);
                if (sAPDrawRectangleAroundSAPGridViewCellAtIndexpropCount > 0)
                {
                    callPayload.Body = sAPDrawRectangleAroundSAPGridViewCellAtIndex;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPGlobalLeftClickSAPGridViewCellAtIndex))]
        public IWorkflowAction SAPGlobalLeftClickSAPGridViewCellAtIndex([WorkflowExpression] Func<string> sAPGlobalLeftClickSAPGridViewCellAtIndexsearchSAPElementId, [WorkflowExpression] Func<int> sAPGlobalLeftClickSAPGridViewCellAtIndexrowIndex, [WorkflowExpression] Func<string> sAPGlobalLeftClickSAPGridViewCellAtIndexworkflow, [WorkflowExpression] Func<string> sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnName = null, [WorkflowExpression] Func<string> sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitle = null, [WorkflowExpression] Func<bool> sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression = null, [WorkflowExpression] Func<bool> sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive = null, [WorkflowExpression] Func<bool> sAPGlobalLeftClickSAPGridViewCellAtIndexsetElementWindowTopMost = null, [WorkflowExpression] Func<bool> sAPGlobalLeftClickSAPGridViewCellAtIndexbringElementWindowToFront = null, [WorkflowExpression] Func<bool> sAPGlobalLeftClickSAPGridViewCellAtIndextoggleWindow = null, [WorkflowExpression] Func<bool> sAPGlobalLeftClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent = null, [WorkflowExpression] Func<double> sAPGlobalLeftClickSAPGridViewCellAtIndextoggleDelay = null, [WorkflowExpression] Func<int> sAPGlobalLeftClickSAPGridViewCellAtIndexclickOffsetX = null, [WorkflowExpression] Func<int> sAPGlobalLeftClickSAPGridViewCellAtIndexclickOffsetY = null, [WorkflowExpression] Func<sAPGlobalLeftClickSAPGridViewCellAtIndexoffsetRelativeToInput> sAPGlobalLeftClickSAPGridViewCellAtIndexoffsetRelativeTo = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSAPGlobalLeftClickSAPGridViewCellAtIndex(WorkflowValue<string> sAPGlobalLeftClickSAPGridViewCellAtIndexsearchSAPElementId, WorkflowValue<int> sAPGlobalLeftClickSAPGridViewCellAtIndexrowIndex, WorkflowValue<string> sAPGlobalLeftClickSAPGridViewCellAtIndexworkflow, WorkflowValue<string> sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnName = null, WorkflowValue<string> sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitle = null, WorkflowValue<bool> sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression = null, WorkflowValue<bool> sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive = null, WorkflowValue<bool> sAPGlobalLeftClickSAPGridViewCellAtIndexsetElementWindowTopMost = null, WorkflowValue<bool> sAPGlobalLeftClickSAPGridViewCellAtIndexbringElementWindowToFront = null, WorkflowValue<bool> sAPGlobalLeftClickSAPGridViewCellAtIndextoggleWindow = null, WorkflowValue<bool> sAPGlobalLeftClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent = null, WorkflowValue<double> sAPGlobalLeftClickSAPGridViewCellAtIndextoggleDelay = null, WorkflowValue<int> sAPGlobalLeftClickSAPGridViewCellAtIndexclickOffsetX = null, WorkflowValue<int> sAPGlobalLeftClickSAPGridViewCellAtIndexclickOffsetY = null, WorkflowValue<sAPGlobalLeftClickSAPGridViewCellAtIndexoffsetRelativeToInput> sAPGlobalLeftClickSAPGridViewCellAtIndexoffsetRelativeTo = null)
        {
            WorkflowValue.Validate(sAPGlobalLeftClickSAPGridViewCellAtIndexsearchSAPElementId, nameof(sAPGlobalLeftClickSAPGridViewCellAtIndexsearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPGlobalLeftClickSAPGridViewCellAtIndexrowIndex, nameof(sAPGlobalLeftClickSAPGridViewCellAtIndexrowIndex), required: true);
            WorkflowValue.Validate(sAPGlobalLeftClickSAPGridViewCellAtIndexworkflow, nameof(sAPGlobalLeftClickSAPGridViewCellAtIndexworkflow), required: true);
            WorkflowValue.Validate(sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnName, nameof(sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnName), required: false);
            WorkflowValue.Validate(sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitle, nameof(sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitle), required: false);
            WorkflowValue.Validate(sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression, nameof(sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression), required: false);
            WorkflowValue.Validate(sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive, nameof(sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive), required: false);
            WorkflowValue.Validate(sAPGlobalLeftClickSAPGridViewCellAtIndexsetElementWindowTopMost, nameof(sAPGlobalLeftClickSAPGridViewCellAtIndexsetElementWindowTopMost), required: false);
            WorkflowValue.Validate(sAPGlobalLeftClickSAPGridViewCellAtIndexbringElementWindowToFront, nameof(sAPGlobalLeftClickSAPGridViewCellAtIndexbringElementWindowToFront), required: false);
            WorkflowValue.Validate(sAPGlobalLeftClickSAPGridViewCellAtIndextoggleWindow, nameof(sAPGlobalLeftClickSAPGridViewCellAtIndextoggleWindow), required: false);
            WorkflowValue.Validate(sAPGlobalLeftClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent, nameof(sAPGlobalLeftClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent), required: false);
            WorkflowValue.Validate(sAPGlobalLeftClickSAPGridViewCellAtIndextoggleDelay, nameof(sAPGlobalLeftClickSAPGridViewCellAtIndextoggleDelay), required: false);
            WorkflowValue.Validate(sAPGlobalLeftClickSAPGridViewCellAtIndexclickOffsetX, nameof(sAPGlobalLeftClickSAPGridViewCellAtIndexclickOffsetX), required: false);
            WorkflowValue.Validate(sAPGlobalLeftClickSAPGridViewCellAtIndexclickOffsetY, nameof(sAPGlobalLeftClickSAPGridViewCellAtIndexclickOffsetY), required: false);
            WorkflowValue.Validate(sAPGlobalLeftClickSAPGridViewCellAtIndexoffsetRelativeTo, nameof(sAPGlobalLeftClickSAPGridViewCellAtIndexoffsetRelativeTo), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGlobalLeftClickSAPGridViewCellAtIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGlobalLeftClickSAPGridViewCellAtIndex = new JObject();
                var sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount = 0;
                sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
                sAPGlobalLeftClickSAPGridViewCellAtIndex["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGlobalLeftClickSAPGridViewCellAtIndexsearchSAPElementId);
                sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
                sAPGlobalLeftClickSAPGridViewCellAtIndex["RowIndex"] = ExpressionConverter.ConvertO(sAPGlobalLeftClickSAPGridViewCellAtIndexrowIndex);
                if (sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnName != null)
                {
                    sAPGlobalLeftClickSAPGridViewCellAtIndex["SearchColumnName"] = ExpressionConverter.ConvertO(sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnName);
                    sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
                }

                if (sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitle != null)
                {
                    sAPGlobalLeftClickSAPGridViewCellAtIndex["SearchColumnTitle"] = ExpressionConverter.ConvertO(sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitle);
                    sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
                }

                if (sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression != null)
                {
                    if (sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression != null)
                    {
                        sAPGlobalLeftClickSAPGridViewCellAtIndex["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression);
                        sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
                    }

                    sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
                }
                else
                {
                    sAPGlobalLeftClickSAPGridViewCellAtIndex["SearchColumnTitleIsRegularExpression"] = false;
                    sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
                }

                if (sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive != null)
                {
                    if (sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive != null)
                    {
                        sAPGlobalLeftClickSAPGridViewCellAtIndex["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive);
                        sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
                    }

                    sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
                }
                else
                {
                    sAPGlobalLeftClickSAPGridViewCellAtIndex["SearchColumnTitleIsCaseSensitive"] = false;
                    sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
                }

                if (sAPGlobalLeftClickSAPGridViewCellAtIndexsetElementWindowTopMost != null)
                {
                    if (sAPGlobalLeftClickSAPGridViewCellAtIndexsetElementWindowTopMost != null)
                    {
                        sAPGlobalLeftClickSAPGridViewCellAtIndex["SetElementWindowTopMost"] = ExpressionConverter.ConvertO(sAPGlobalLeftClickSAPGridViewCellAtIndexsetElementWindowTopMost);
                        sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
                    }

                    sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
                }
                else
                {
                    sAPGlobalLeftClickSAPGridViewCellAtIndex["SetElementWindowTopMost"] = false;
                    sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
                }

                if (sAPGlobalLeftClickSAPGridViewCellAtIndexbringElementWindowToFront != null)
                {
                    if (sAPGlobalLeftClickSAPGridViewCellAtIndexbringElementWindowToFront != null)
                    {
                        sAPGlobalLeftClickSAPGridViewCellAtIndex["BringElementWindowToFront"] = ExpressionConverter.ConvertO(sAPGlobalLeftClickSAPGridViewCellAtIndexbringElementWindowToFront);
                        sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
                    }

                    sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
                }
                else
                {
                    sAPGlobalLeftClickSAPGridViewCellAtIndex["BringElementWindowToFront"] = false;
                    sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
                }

                if (sAPGlobalLeftClickSAPGridViewCellAtIndextoggleWindow != null)
                {
                    if (sAPGlobalLeftClickSAPGridViewCellAtIndextoggleWindow != null)
                    {
                        sAPGlobalLeftClickSAPGridViewCellAtIndex["ToggleWindow"] = ExpressionConverter.ConvertO(sAPGlobalLeftClickSAPGridViewCellAtIndextoggleWindow);
                        sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
                    }

                    sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
                }
                else
                {
                    sAPGlobalLeftClickSAPGridViewCellAtIndex["ToggleWindow"] = true;
                    sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
                }

                if (sAPGlobalLeftClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent != null)
                {
                    if (sAPGlobalLeftClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent != null)
                    {
                        sAPGlobalLeftClickSAPGridViewCellAtIndex["ToggleUsesGlobalLeftMouseClickAgent"] = ExpressionConverter.ConvertO(sAPGlobalLeftClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent);
                        sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
                    }

                    sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
                }
                else
                {
                    sAPGlobalLeftClickSAPGridViewCellAtIndex["ToggleUsesGlobalLeftMouseClickAgent"] = true;
                    sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
                }

                if (sAPGlobalLeftClickSAPGridViewCellAtIndextoggleDelay != null)
                {
                    if (sAPGlobalLeftClickSAPGridViewCellAtIndextoggleDelay != null)
                    {
                        sAPGlobalLeftClickSAPGridViewCellAtIndex["ToggleDelay"] = ExpressionConverter.ConvertO(sAPGlobalLeftClickSAPGridViewCellAtIndextoggleDelay);
                        sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
                    }

                    sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
                }
                else
                {
                    sAPGlobalLeftClickSAPGridViewCellAtIndex["ToggleDelay"] = 0.5;
                    sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
                }

                if (sAPGlobalLeftClickSAPGridViewCellAtIndexclickOffsetX != null)
                {
                    if (sAPGlobalLeftClickSAPGridViewCellAtIndexclickOffsetX != null)
                    {
                        sAPGlobalLeftClickSAPGridViewCellAtIndex["ClickOffsetX"] = ExpressionConverter.ConvertO(sAPGlobalLeftClickSAPGridViewCellAtIndexclickOffsetX);
                        sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
                    }

                    sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
                }
                else
                {
                    sAPGlobalLeftClickSAPGridViewCellAtIndex["ClickOffsetX"] = 0;
                    sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
                }

                if (sAPGlobalLeftClickSAPGridViewCellAtIndexclickOffsetY != null)
                {
                    if (sAPGlobalLeftClickSAPGridViewCellAtIndexclickOffsetY != null)
                    {
                        sAPGlobalLeftClickSAPGridViewCellAtIndex["ClickOffsetY"] = ExpressionConverter.ConvertO(sAPGlobalLeftClickSAPGridViewCellAtIndexclickOffsetY);
                        sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
                    }

                    sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
                }
                else
                {
                    sAPGlobalLeftClickSAPGridViewCellAtIndex["ClickOffsetY"] = 0;
                    sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
                }

                if (sAPGlobalLeftClickSAPGridViewCellAtIndexoffsetRelativeTo != null)
                {
                    sAPGlobalLeftClickSAPGridViewCellAtIndex["OffsetRelativeTo"] = ExpressionConverter.ConvertO(sAPGlobalLeftClickSAPGridViewCellAtIndexoffsetRelativeTo);
                    sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
                }

                sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
                sAPGlobalLeftClickSAPGridViewCellAtIndex["Workflow"] = ExpressionConverter.ConvertO(sAPGlobalLeftClickSAPGridViewCellAtIndexworkflow);
                if (sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount > 0)
                {
                    callPayload.Body = sAPGlobalLeftClickSAPGridViewCellAtIndex;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPGlobalRightClickSAPGridViewCellAtIndex))]
        public IWorkflowAction SAPGlobalRightClickSAPGridViewCellAtIndex([WorkflowExpression] Func<string> sAPGlobalRightClickSAPGridViewCellAtIndexsearchSAPElementId, [WorkflowExpression] Func<int> sAPGlobalRightClickSAPGridViewCellAtIndexrowIndex, [WorkflowExpression] Func<string> sAPGlobalRightClickSAPGridViewCellAtIndexworkflow, [WorkflowExpression] Func<string> sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnName = null, [WorkflowExpression] Func<string> sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitle = null, [WorkflowExpression] Func<bool> sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression = null, [WorkflowExpression] Func<bool> sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive = null, [WorkflowExpression] Func<bool> sAPGlobalRightClickSAPGridViewCellAtIndexsetElementWindowTopMost = null, [WorkflowExpression] Func<bool> sAPGlobalRightClickSAPGridViewCellAtIndexbringElementWindowToFront = null, [WorkflowExpression] Func<bool> sAPGlobalRightClickSAPGridViewCellAtIndextoggleWindow = null, [WorkflowExpression] Func<bool> sAPGlobalRightClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent = null, [WorkflowExpression] Func<double> sAPGlobalRightClickSAPGridViewCellAtIndextoggleDelay = null, [WorkflowExpression] Func<int> sAPGlobalRightClickSAPGridViewCellAtIndexclickOffsetX = null, [WorkflowExpression] Func<int> sAPGlobalRightClickSAPGridViewCellAtIndexclickOffsetY = null, [WorkflowExpression] Func<sAPGlobalRightClickSAPGridViewCellAtIndexoffsetRelativeToInput> sAPGlobalRightClickSAPGridViewCellAtIndexoffsetRelativeTo = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSAPGlobalRightClickSAPGridViewCellAtIndex(WorkflowValue<string> sAPGlobalRightClickSAPGridViewCellAtIndexsearchSAPElementId, WorkflowValue<int> sAPGlobalRightClickSAPGridViewCellAtIndexrowIndex, WorkflowValue<string> sAPGlobalRightClickSAPGridViewCellAtIndexworkflow, WorkflowValue<string> sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnName = null, WorkflowValue<string> sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitle = null, WorkflowValue<bool> sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression = null, WorkflowValue<bool> sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive = null, WorkflowValue<bool> sAPGlobalRightClickSAPGridViewCellAtIndexsetElementWindowTopMost = null, WorkflowValue<bool> sAPGlobalRightClickSAPGridViewCellAtIndexbringElementWindowToFront = null, WorkflowValue<bool> sAPGlobalRightClickSAPGridViewCellAtIndextoggleWindow = null, WorkflowValue<bool> sAPGlobalRightClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent = null, WorkflowValue<double> sAPGlobalRightClickSAPGridViewCellAtIndextoggleDelay = null, WorkflowValue<int> sAPGlobalRightClickSAPGridViewCellAtIndexclickOffsetX = null, WorkflowValue<int> sAPGlobalRightClickSAPGridViewCellAtIndexclickOffsetY = null, WorkflowValue<sAPGlobalRightClickSAPGridViewCellAtIndexoffsetRelativeToInput> sAPGlobalRightClickSAPGridViewCellAtIndexoffsetRelativeTo = null)
        {
            WorkflowValue.Validate(sAPGlobalRightClickSAPGridViewCellAtIndexsearchSAPElementId, nameof(sAPGlobalRightClickSAPGridViewCellAtIndexsearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPGlobalRightClickSAPGridViewCellAtIndexrowIndex, nameof(sAPGlobalRightClickSAPGridViewCellAtIndexrowIndex), required: true);
            WorkflowValue.Validate(sAPGlobalRightClickSAPGridViewCellAtIndexworkflow, nameof(sAPGlobalRightClickSAPGridViewCellAtIndexworkflow), required: true);
            WorkflowValue.Validate(sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnName, nameof(sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnName), required: false);
            WorkflowValue.Validate(sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitle, nameof(sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitle), required: false);
            WorkflowValue.Validate(sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression, nameof(sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression), required: false);
            WorkflowValue.Validate(sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive, nameof(sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive), required: false);
            WorkflowValue.Validate(sAPGlobalRightClickSAPGridViewCellAtIndexsetElementWindowTopMost, nameof(sAPGlobalRightClickSAPGridViewCellAtIndexsetElementWindowTopMost), required: false);
            WorkflowValue.Validate(sAPGlobalRightClickSAPGridViewCellAtIndexbringElementWindowToFront, nameof(sAPGlobalRightClickSAPGridViewCellAtIndexbringElementWindowToFront), required: false);
            WorkflowValue.Validate(sAPGlobalRightClickSAPGridViewCellAtIndextoggleWindow, nameof(sAPGlobalRightClickSAPGridViewCellAtIndextoggleWindow), required: false);
            WorkflowValue.Validate(sAPGlobalRightClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent, nameof(sAPGlobalRightClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent), required: false);
            WorkflowValue.Validate(sAPGlobalRightClickSAPGridViewCellAtIndextoggleDelay, nameof(sAPGlobalRightClickSAPGridViewCellAtIndextoggleDelay), required: false);
            WorkflowValue.Validate(sAPGlobalRightClickSAPGridViewCellAtIndexclickOffsetX, nameof(sAPGlobalRightClickSAPGridViewCellAtIndexclickOffsetX), required: false);
            WorkflowValue.Validate(sAPGlobalRightClickSAPGridViewCellAtIndexclickOffsetY, nameof(sAPGlobalRightClickSAPGridViewCellAtIndexclickOffsetY), required: false);
            WorkflowValue.Validate(sAPGlobalRightClickSAPGridViewCellAtIndexoffsetRelativeTo, nameof(sAPGlobalRightClickSAPGridViewCellAtIndexoffsetRelativeTo), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGlobalRightClickSAPGridViewCellAtIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGlobalRightClickSAPGridViewCellAtIndex = new JObject();
                var sAPGlobalRightClickSAPGridViewCellAtIndexpropCount = 0;
                sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
                sAPGlobalRightClickSAPGridViewCellAtIndex["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGlobalRightClickSAPGridViewCellAtIndexsearchSAPElementId);
                sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
                sAPGlobalRightClickSAPGridViewCellAtIndex["RowIndex"] = ExpressionConverter.ConvertO(sAPGlobalRightClickSAPGridViewCellAtIndexrowIndex);
                if (sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnName != null)
                {
                    sAPGlobalRightClickSAPGridViewCellAtIndex["SearchColumnName"] = ExpressionConverter.ConvertO(sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnName);
                    sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
                }

                if (sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitle != null)
                {
                    sAPGlobalRightClickSAPGridViewCellAtIndex["SearchColumnTitle"] = ExpressionConverter.ConvertO(sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitle);
                    sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
                }

                if (sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression != null)
                {
                    if (sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression != null)
                    {
                        sAPGlobalRightClickSAPGridViewCellAtIndex["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression);
                        sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
                    }

                    sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
                }
                else
                {
                    sAPGlobalRightClickSAPGridViewCellAtIndex["SearchColumnTitleIsRegularExpression"] = false;
                    sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
                }

                if (sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive != null)
                {
                    if (sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive != null)
                    {
                        sAPGlobalRightClickSAPGridViewCellAtIndex["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive);
                        sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
                    }

                    sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
                }
                else
                {
                    sAPGlobalRightClickSAPGridViewCellAtIndex["SearchColumnTitleIsCaseSensitive"] = false;
                    sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
                }

                if (sAPGlobalRightClickSAPGridViewCellAtIndexsetElementWindowTopMost != null)
                {
                    if (sAPGlobalRightClickSAPGridViewCellAtIndexsetElementWindowTopMost != null)
                    {
                        sAPGlobalRightClickSAPGridViewCellAtIndex["SetElementWindowTopMost"] = ExpressionConverter.ConvertO(sAPGlobalRightClickSAPGridViewCellAtIndexsetElementWindowTopMost);
                        sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
                    }

                    sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
                }
                else
                {
                    sAPGlobalRightClickSAPGridViewCellAtIndex["SetElementWindowTopMost"] = false;
                    sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
                }

                if (sAPGlobalRightClickSAPGridViewCellAtIndexbringElementWindowToFront != null)
                {
                    if (sAPGlobalRightClickSAPGridViewCellAtIndexbringElementWindowToFront != null)
                    {
                        sAPGlobalRightClickSAPGridViewCellAtIndex["BringElementWindowToFront"] = ExpressionConverter.ConvertO(sAPGlobalRightClickSAPGridViewCellAtIndexbringElementWindowToFront);
                        sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
                    }

                    sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
                }
                else
                {
                    sAPGlobalRightClickSAPGridViewCellAtIndex["BringElementWindowToFront"] = false;
                    sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
                }

                if (sAPGlobalRightClickSAPGridViewCellAtIndextoggleWindow != null)
                {
                    if (sAPGlobalRightClickSAPGridViewCellAtIndextoggleWindow != null)
                    {
                        sAPGlobalRightClickSAPGridViewCellAtIndex["ToggleWindow"] = ExpressionConverter.ConvertO(sAPGlobalRightClickSAPGridViewCellAtIndextoggleWindow);
                        sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
                    }

                    sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
                }
                else
                {
                    sAPGlobalRightClickSAPGridViewCellAtIndex["ToggleWindow"] = true;
                    sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
                }

                if (sAPGlobalRightClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent != null)
                {
                    if (sAPGlobalRightClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent != null)
                    {
                        sAPGlobalRightClickSAPGridViewCellAtIndex["ToggleUsesGlobalLeftMouseClickAgent"] = ExpressionConverter.ConvertO(sAPGlobalRightClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent);
                        sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
                    }

                    sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
                }
                else
                {
                    sAPGlobalRightClickSAPGridViewCellAtIndex["ToggleUsesGlobalLeftMouseClickAgent"] = true;
                    sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
                }

                if (sAPGlobalRightClickSAPGridViewCellAtIndextoggleDelay != null)
                {
                    if (sAPGlobalRightClickSAPGridViewCellAtIndextoggleDelay != null)
                    {
                        sAPGlobalRightClickSAPGridViewCellAtIndex["ToggleDelay"] = ExpressionConverter.ConvertO(sAPGlobalRightClickSAPGridViewCellAtIndextoggleDelay);
                        sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
                    }

                    sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
                }
                else
                {
                    sAPGlobalRightClickSAPGridViewCellAtIndex["ToggleDelay"] = 0.5;
                    sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
                }

                if (sAPGlobalRightClickSAPGridViewCellAtIndexclickOffsetX != null)
                {
                    if (sAPGlobalRightClickSAPGridViewCellAtIndexclickOffsetX != null)
                    {
                        sAPGlobalRightClickSAPGridViewCellAtIndex["ClickOffsetX"] = ExpressionConverter.ConvertO(sAPGlobalRightClickSAPGridViewCellAtIndexclickOffsetX);
                        sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
                    }

                    sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
                }
                else
                {
                    sAPGlobalRightClickSAPGridViewCellAtIndex["ClickOffsetX"] = 0;
                    sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
                }

                if (sAPGlobalRightClickSAPGridViewCellAtIndexclickOffsetY != null)
                {
                    if (sAPGlobalRightClickSAPGridViewCellAtIndexclickOffsetY != null)
                    {
                        sAPGlobalRightClickSAPGridViewCellAtIndex["ClickOffsetY"] = ExpressionConverter.ConvertO(sAPGlobalRightClickSAPGridViewCellAtIndexclickOffsetY);
                        sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
                    }

                    sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
                }
                else
                {
                    sAPGlobalRightClickSAPGridViewCellAtIndex["ClickOffsetY"] = 0;
                    sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
                }

                if (sAPGlobalRightClickSAPGridViewCellAtIndexoffsetRelativeTo != null)
                {
                    sAPGlobalRightClickSAPGridViewCellAtIndex["OffsetRelativeTo"] = ExpressionConverter.ConvertO(sAPGlobalRightClickSAPGridViewCellAtIndexoffsetRelativeTo);
                    sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
                }

                sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
                sAPGlobalRightClickSAPGridViewCellAtIndex["Workflow"] = ExpressionConverter.ConvertO(sAPGlobalRightClickSAPGridViewCellAtIndexworkflow);
                if (sAPGlobalRightClickSAPGridViewCellAtIndexpropCount > 0)
                {
                    callPayload.Body = sAPGlobalRightClickSAPGridViewCellAtIndex;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPGlobalDoubleLeftClickSAPGridViewCellAtIndex))]
        public IWorkflowAction SAPGlobalDoubleLeftClickSAPGridViewCellAtIndex([WorkflowExpression] Func<string> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchSAPElementId, [WorkflowExpression] Func<int> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexrowIndex, [WorkflowExpression] Func<string> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexworkflow, [WorkflowExpression] Func<string> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnName = null, [WorkflowExpression] Func<string> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitle = null, [WorkflowExpression] Func<bool> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression = null, [WorkflowExpression] Func<bool> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive = null, [WorkflowExpression] Func<bool> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsetElementWindowTopMost = null, [WorkflowExpression] Func<bool> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexbringElementWindowToFront = null, [WorkflowExpression] Func<bool> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleWindow = null, [WorkflowExpression] Func<bool> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent = null, [WorkflowExpression] Func<double> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleDelay = null, [WorkflowExpression] Func<int> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexclickOffsetX = null, [WorkflowExpression] Func<int> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexclickOffsetY = null, [WorkflowExpression] Func<sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexoffsetRelativeToInput> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexoffsetRelativeTo = null, [WorkflowExpression] Func<int> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexdoubleClickDelayInMilliseconds = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSAPGlobalDoubleLeftClickSAPGridViewCellAtIndex(WorkflowValue<string> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchSAPElementId, WorkflowValue<int> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexrowIndex, WorkflowValue<string> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexworkflow, WorkflowValue<string> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnName = null, WorkflowValue<string> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitle = null, WorkflowValue<bool> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression = null, WorkflowValue<bool> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive = null, WorkflowValue<bool> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsetElementWindowTopMost = null, WorkflowValue<bool> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexbringElementWindowToFront = null, WorkflowValue<bool> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleWindow = null, WorkflowValue<bool> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent = null, WorkflowValue<double> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleDelay = null, WorkflowValue<int> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexclickOffsetX = null, WorkflowValue<int> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexclickOffsetY = null, WorkflowValue<sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexoffsetRelativeToInput> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexoffsetRelativeTo = null, WorkflowValue<int> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexdoubleClickDelayInMilliseconds = null)
        {
            WorkflowValue.Validate(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchSAPElementId, nameof(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexrowIndex, nameof(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexrowIndex), required: true);
            WorkflowValue.Validate(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexworkflow, nameof(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexworkflow), required: true);
            WorkflowValue.Validate(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnName, nameof(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnName), required: false);
            WorkflowValue.Validate(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitle, nameof(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitle), required: false);
            WorkflowValue.Validate(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression, nameof(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression), required: false);
            WorkflowValue.Validate(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive, nameof(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive), required: false);
            WorkflowValue.Validate(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsetElementWindowTopMost, nameof(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsetElementWindowTopMost), required: false);
            WorkflowValue.Validate(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexbringElementWindowToFront, nameof(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexbringElementWindowToFront), required: false);
            WorkflowValue.Validate(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleWindow, nameof(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleWindow), required: false);
            WorkflowValue.Validate(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent, nameof(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent), required: false);
            WorkflowValue.Validate(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleDelay, nameof(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleDelay), required: false);
            WorkflowValue.Validate(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexclickOffsetX, nameof(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexclickOffsetX), required: false);
            WorkflowValue.Validate(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexclickOffsetY, nameof(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexclickOffsetY), required: false);
            WorkflowValue.Validate(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexoffsetRelativeTo, nameof(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexoffsetRelativeTo), required: false);
            WorkflowValue.Validate(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexdoubleClickDelayInMilliseconds, nameof(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexdoubleClickDelayInMilliseconds), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGlobalDoubleLeftClickSAPGridViewCellAtIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex = new JObject();
                var sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount = 0;
                sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
                sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchSAPElementId);
                sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
                sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["RowIndex"] = ExpressionConverter.ConvertO(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexrowIndex);
                if (sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnName != null)
                {
                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["SearchColumnName"] = ExpressionConverter.ConvertO(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnName);
                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
                }

                if (sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitle != null)
                {
                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["SearchColumnTitle"] = ExpressionConverter.ConvertO(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitle);
                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
                }

                if (sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression != null)
                {
                    if (sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression != null)
                    {
                        sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression);
                        sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
                    }

                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
                }
                else
                {
                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["SearchColumnTitleIsRegularExpression"] = false;
                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
                }

                if (sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive != null)
                {
                    if (sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive != null)
                    {
                        sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive);
                        sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
                    }

                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
                }
                else
                {
                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["SearchColumnTitleIsCaseSensitive"] = false;
                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
                }

                if (sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsetElementWindowTopMost != null)
                {
                    if (sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsetElementWindowTopMost != null)
                    {
                        sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["SetElementWindowTopMost"] = ExpressionConverter.ConvertO(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsetElementWindowTopMost);
                        sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
                    }

                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
                }
                else
                {
                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["SetElementWindowTopMost"] = false;
                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
                }

                if (sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexbringElementWindowToFront != null)
                {
                    if (sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexbringElementWindowToFront != null)
                    {
                        sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["BringElementWindowToFront"] = ExpressionConverter.ConvertO(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexbringElementWindowToFront);
                        sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
                    }

                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
                }
                else
                {
                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["BringElementWindowToFront"] = false;
                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
                }

                if (sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleWindow != null)
                {
                    if (sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleWindow != null)
                    {
                        sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["ToggleWindow"] = ExpressionConverter.ConvertO(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleWindow);
                        sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
                    }

                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
                }
                else
                {
                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["ToggleWindow"] = true;
                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
                }

                if (sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent != null)
                {
                    if (sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent != null)
                    {
                        sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["ToggleUsesGlobalLeftMouseClickAgent"] = ExpressionConverter.ConvertO(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent);
                        sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
                    }

                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
                }
                else
                {
                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["ToggleUsesGlobalLeftMouseClickAgent"] = true;
                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
                }

                if (sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleDelay != null)
                {
                    if (sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleDelay != null)
                    {
                        sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["ToggleDelay"] = ExpressionConverter.ConvertO(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleDelay);
                        sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
                    }

                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
                }
                else
                {
                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["ToggleDelay"] = 0.5;
                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
                }

                if (sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexclickOffsetX != null)
                {
                    if (sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexclickOffsetX != null)
                    {
                        sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["ClickOffsetX"] = ExpressionConverter.ConvertO(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexclickOffsetX);
                        sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
                    }

                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
                }
                else
                {
                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["ClickOffsetX"] = 0;
                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
                }

                if (sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexclickOffsetY != null)
                {
                    if (sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexclickOffsetY != null)
                    {
                        sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["ClickOffsetY"] = ExpressionConverter.ConvertO(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexclickOffsetY);
                        sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
                    }

                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
                }
                else
                {
                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["ClickOffsetY"] = 0;
                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
                }

                if (sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexoffsetRelativeTo != null)
                {
                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["OffsetRelativeTo"] = ExpressionConverter.ConvertO(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexoffsetRelativeTo);
                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
                }

                if (sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexdoubleClickDelayInMilliseconds != null)
                {
                    if (sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexdoubleClickDelayInMilliseconds != null)
                    {
                        sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["DoubleClickDelayInMilliseconds"] = ExpressionConverter.ConvertO(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexdoubleClickDelayInMilliseconds);
                        sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
                    }

                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
                }
                else
                {
                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["DoubleClickDelayInMilliseconds"] = 10;
                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
                }

                sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
                sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["Workflow"] = ExpressionConverter.ConvertO(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexworkflow);
                if (sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount > 0)
                {
                    callPayload.Body = sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPGetSAPGridViewColumnHeaders))]
        public IBodyWorkflowAction<SAPGetSAPGridViewColumnHeadersResponse> SAPGetSAPGridViewColumnHeaders([WorkflowExpression] Func<string> sAPGetSAPGridViewColumnHeaderssearchSAPElementId, [WorkflowExpression] Func<string> sAPGetSAPGridViewColumnHeadersworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SAPGetSAPGridViewColumnHeadersResponse> __BuildSAPGetSAPGridViewColumnHeaders(WorkflowValue<string> sAPGetSAPGridViewColumnHeaderssearchSAPElementId, WorkflowValue<string> sAPGetSAPGridViewColumnHeadersworkflow)
        {
            WorkflowValue.Validate(sAPGetSAPGridViewColumnHeaderssearchSAPElementId, nameof(sAPGetSAPGridViewColumnHeaderssearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPGetSAPGridViewColumnHeadersworkflow, nameof(sAPGetSAPGridViewColumnHeadersworkflow), required: true);
            return new DeferredBodyAction<SAPGetSAPGridViewColumnHeadersResponse>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetSAPGridViewColumnHeaders";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGetSAPGridViewColumnHeaders = new JObject();
                var sAPGetSAPGridViewColumnHeaderspropCount = 0;
                sAPGetSAPGridViewColumnHeaderspropCount++;
                sAPGetSAPGridViewColumnHeaders["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGetSAPGridViewColumnHeaderssearchSAPElementId);
                sAPGetSAPGridViewColumnHeaderspropCount++;
                sAPGetSAPGridViewColumnHeaders["Workflow"] = ExpressionConverter.ConvertO(sAPGetSAPGridViewColumnHeadersworkflow);
                if (sAPGetSAPGridViewColumnHeaderspropCount > 0)
                {
                    callPayload.Body = sAPGetSAPGridViewColumnHeaders;
                }

                return new ApiConnectionAction<SAPGetSAPGridViewColumnHeadersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPClickSAPGridViewCellAtIndex))]
        public IWorkflowAction SAPClickSAPGridViewCellAtIndex([WorkflowExpression] Func<string> sAPClickSAPGridViewCellAtIndexsearchSAPElementId, [WorkflowExpression] Func<int> sAPClickSAPGridViewCellAtIndexrowIndex, [WorkflowExpression] Func<string> sAPClickSAPGridViewCellAtIndexworkflow, [WorkflowExpression] Func<string> sAPClickSAPGridViewCellAtIndexsearchColumnName = null, [WorkflowExpression] Func<string> sAPClickSAPGridViewCellAtIndexsearchColumnTitle = null, [WorkflowExpression] Func<bool> sAPClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression = null, [WorkflowExpression] Func<bool> sAPClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSAPClickSAPGridViewCellAtIndex(WorkflowValue<string> sAPClickSAPGridViewCellAtIndexsearchSAPElementId, WorkflowValue<int> sAPClickSAPGridViewCellAtIndexrowIndex, WorkflowValue<string> sAPClickSAPGridViewCellAtIndexworkflow, WorkflowValue<string> sAPClickSAPGridViewCellAtIndexsearchColumnName = null, WorkflowValue<string> sAPClickSAPGridViewCellAtIndexsearchColumnTitle = null, WorkflowValue<bool> sAPClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression = null, WorkflowValue<bool> sAPClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive = null)
        {
            WorkflowValue.Validate(sAPClickSAPGridViewCellAtIndexsearchSAPElementId, nameof(sAPClickSAPGridViewCellAtIndexsearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPClickSAPGridViewCellAtIndexrowIndex, nameof(sAPClickSAPGridViewCellAtIndexrowIndex), required: true);
            WorkflowValue.Validate(sAPClickSAPGridViewCellAtIndexworkflow, nameof(sAPClickSAPGridViewCellAtIndexworkflow), required: true);
            WorkflowValue.Validate(sAPClickSAPGridViewCellAtIndexsearchColumnName, nameof(sAPClickSAPGridViewCellAtIndexsearchColumnName), required: false);
            WorkflowValue.Validate(sAPClickSAPGridViewCellAtIndexsearchColumnTitle, nameof(sAPClickSAPGridViewCellAtIndexsearchColumnTitle), required: false);
            WorkflowValue.Validate(sAPClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression, nameof(sAPClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression), required: false);
            WorkflowValue.Validate(sAPClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive, nameof(sAPClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/SAPGUI/SAPClickSAPGridViewCellAtIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPClickSAPGridViewCellAtIndex = new JObject();
                var sAPClickSAPGridViewCellAtIndexpropCount = 0;
                sAPClickSAPGridViewCellAtIndexpropCount++;
                sAPClickSAPGridViewCellAtIndex["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPClickSAPGridViewCellAtIndexsearchSAPElementId);
                sAPClickSAPGridViewCellAtIndexpropCount++;
                sAPClickSAPGridViewCellAtIndex["RowIndex"] = ExpressionConverter.ConvertO(sAPClickSAPGridViewCellAtIndexrowIndex);
                if (sAPClickSAPGridViewCellAtIndexsearchColumnName != null)
                {
                    sAPClickSAPGridViewCellAtIndex["SearchColumnName"] = ExpressionConverter.ConvertO(sAPClickSAPGridViewCellAtIndexsearchColumnName);
                    sAPClickSAPGridViewCellAtIndexpropCount++;
                }

                if (sAPClickSAPGridViewCellAtIndexsearchColumnTitle != null)
                {
                    sAPClickSAPGridViewCellAtIndex["SearchColumnTitle"] = ExpressionConverter.ConvertO(sAPClickSAPGridViewCellAtIndexsearchColumnTitle);
                    sAPClickSAPGridViewCellAtIndexpropCount++;
                }

                if (sAPClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression != null)
                {
                    if (sAPClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression != null)
                    {
                        sAPClickSAPGridViewCellAtIndex["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(sAPClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression);
                        sAPClickSAPGridViewCellAtIndexpropCount++;
                    }

                    sAPClickSAPGridViewCellAtIndexpropCount++;
                }
                else
                {
                    sAPClickSAPGridViewCellAtIndex["SearchColumnTitleIsRegularExpression"] = false;
                    sAPClickSAPGridViewCellAtIndexpropCount++;
                }

                if (sAPClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive != null)
                {
                    if (sAPClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive != null)
                    {
                        sAPClickSAPGridViewCellAtIndex["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive);
                        sAPClickSAPGridViewCellAtIndexpropCount++;
                    }

                    sAPClickSAPGridViewCellAtIndexpropCount++;
                }
                else
                {
                    sAPClickSAPGridViewCellAtIndex["SearchColumnTitleIsCaseSensitive"] = false;
                    sAPClickSAPGridViewCellAtIndexpropCount++;
                }

                sAPClickSAPGridViewCellAtIndexpropCount++;
                sAPClickSAPGridViewCellAtIndex["Workflow"] = ExpressionConverter.ConvertO(sAPClickSAPGridViewCellAtIndexworkflow);
                if (sAPClickSAPGridViewCellAtIndexpropCount > 0)
                {
                    callPayload.Body = sAPClickSAPGridViewCellAtIndex;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPDoubleClickSAPGridViewCellAtIndex))]
        public IWorkflowAction SAPDoubleClickSAPGridViewCellAtIndex([WorkflowExpression] Func<string> sAPDoubleClickSAPGridViewCellAtIndexsearchSAPElementId, [WorkflowExpression] Func<int> sAPDoubleClickSAPGridViewCellAtIndexrowIndex, [WorkflowExpression] Func<string> sAPDoubleClickSAPGridViewCellAtIndexworkflow, [WorkflowExpression] Func<string> sAPDoubleClickSAPGridViewCellAtIndexsearchColumnName = null, [WorkflowExpression] Func<string> sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitle = null, [WorkflowExpression] Func<bool> sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression = null, [WorkflowExpression] Func<bool> sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSAPDoubleClickSAPGridViewCellAtIndex(WorkflowValue<string> sAPDoubleClickSAPGridViewCellAtIndexsearchSAPElementId, WorkflowValue<int> sAPDoubleClickSAPGridViewCellAtIndexrowIndex, WorkflowValue<string> sAPDoubleClickSAPGridViewCellAtIndexworkflow, WorkflowValue<string> sAPDoubleClickSAPGridViewCellAtIndexsearchColumnName = null, WorkflowValue<string> sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitle = null, WorkflowValue<bool> sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression = null, WorkflowValue<bool> sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive = null)
        {
            WorkflowValue.Validate(sAPDoubleClickSAPGridViewCellAtIndexsearchSAPElementId, nameof(sAPDoubleClickSAPGridViewCellAtIndexsearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPDoubleClickSAPGridViewCellAtIndexrowIndex, nameof(sAPDoubleClickSAPGridViewCellAtIndexrowIndex), required: true);
            WorkflowValue.Validate(sAPDoubleClickSAPGridViewCellAtIndexworkflow, nameof(sAPDoubleClickSAPGridViewCellAtIndexworkflow), required: true);
            WorkflowValue.Validate(sAPDoubleClickSAPGridViewCellAtIndexsearchColumnName, nameof(sAPDoubleClickSAPGridViewCellAtIndexsearchColumnName), required: false);
            WorkflowValue.Validate(sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitle, nameof(sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitle), required: false);
            WorkflowValue.Validate(sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression, nameof(sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression), required: false);
            WorkflowValue.Validate(sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive, nameof(sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/SAPGUI/SAPDoubleClickSAPGridViewCellAtIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPDoubleClickSAPGridViewCellAtIndex = new JObject();
                var sAPDoubleClickSAPGridViewCellAtIndexpropCount = 0;
                sAPDoubleClickSAPGridViewCellAtIndexpropCount++;
                sAPDoubleClickSAPGridViewCellAtIndex["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPDoubleClickSAPGridViewCellAtIndexsearchSAPElementId);
                sAPDoubleClickSAPGridViewCellAtIndexpropCount++;
                sAPDoubleClickSAPGridViewCellAtIndex["RowIndex"] = ExpressionConverter.ConvertO(sAPDoubleClickSAPGridViewCellAtIndexrowIndex);
                if (sAPDoubleClickSAPGridViewCellAtIndexsearchColumnName != null)
                {
                    sAPDoubleClickSAPGridViewCellAtIndex["SearchColumnName"] = ExpressionConverter.ConvertO(sAPDoubleClickSAPGridViewCellAtIndexsearchColumnName);
                    sAPDoubleClickSAPGridViewCellAtIndexpropCount++;
                }

                if (sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitle != null)
                {
                    sAPDoubleClickSAPGridViewCellAtIndex["SearchColumnTitle"] = ExpressionConverter.ConvertO(sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitle);
                    sAPDoubleClickSAPGridViewCellAtIndexpropCount++;
                }

                if (sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression != null)
                {
                    if (sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression != null)
                    {
                        sAPDoubleClickSAPGridViewCellAtIndex["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression);
                        sAPDoubleClickSAPGridViewCellAtIndexpropCount++;
                    }

                    sAPDoubleClickSAPGridViewCellAtIndexpropCount++;
                }
                else
                {
                    sAPDoubleClickSAPGridViewCellAtIndex["SearchColumnTitleIsRegularExpression"] = false;
                    sAPDoubleClickSAPGridViewCellAtIndexpropCount++;
                }

                if (sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive != null)
                {
                    if (sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive != null)
                    {
                        sAPDoubleClickSAPGridViewCellAtIndex["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive);
                        sAPDoubleClickSAPGridViewCellAtIndexpropCount++;
                    }

                    sAPDoubleClickSAPGridViewCellAtIndexpropCount++;
                }
                else
                {
                    sAPDoubleClickSAPGridViewCellAtIndex["SearchColumnTitleIsCaseSensitive"] = false;
                    sAPDoubleClickSAPGridViewCellAtIndexpropCount++;
                }

                sAPDoubleClickSAPGridViewCellAtIndexpropCount++;
                sAPDoubleClickSAPGridViewCellAtIndex["Workflow"] = ExpressionConverter.ConvertO(sAPDoubleClickSAPGridViewCellAtIndexworkflow);
                if (sAPDoubleClickSAPGridViewCellAtIndexpropCount > 0)
                {
                    callPayload.Body = sAPDoubleClickSAPGridViewCellAtIndex;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPPressSAPGridViewCellButtonAtIndex))]
        public IWorkflowAction SAPPressSAPGridViewCellButtonAtIndex([WorkflowExpression] Func<string> sAPPressSAPGridViewCellButtonAtIndexsearchSAPElementId, [WorkflowExpression] Func<int> sAPPressSAPGridViewCellButtonAtIndexrowIndex, [WorkflowExpression] Func<string> sAPPressSAPGridViewCellButtonAtIndexworkflow, [WorkflowExpression] Func<string> sAPPressSAPGridViewCellButtonAtIndexsearchColumnName = null, [WorkflowExpression] Func<string> sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitle = null, [WorkflowExpression] Func<bool> sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitleIsRegularExpression = null, [WorkflowExpression] Func<bool> sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitleIsCaseSensitive = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSAPPressSAPGridViewCellButtonAtIndex(WorkflowValue<string> sAPPressSAPGridViewCellButtonAtIndexsearchSAPElementId, WorkflowValue<int> sAPPressSAPGridViewCellButtonAtIndexrowIndex, WorkflowValue<string> sAPPressSAPGridViewCellButtonAtIndexworkflow, WorkflowValue<string> sAPPressSAPGridViewCellButtonAtIndexsearchColumnName = null, WorkflowValue<string> sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitle = null, WorkflowValue<bool> sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitleIsRegularExpression = null, WorkflowValue<bool> sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitleIsCaseSensitive = null)
        {
            WorkflowValue.Validate(sAPPressSAPGridViewCellButtonAtIndexsearchSAPElementId, nameof(sAPPressSAPGridViewCellButtonAtIndexsearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPPressSAPGridViewCellButtonAtIndexrowIndex, nameof(sAPPressSAPGridViewCellButtonAtIndexrowIndex), required: true);
            WorkflowValue.Validate(sAPPressSAPGridViewCellButtonAtIndexworkflow, nameof(sAPPressSAPGridViewCellButtonAtIndexworkflow), required: true);
            WorkflowValue.Validate(sAPPressSAPGridViewCellButtonAtIndexsearchColumnName, nameof(sAPPressSAPGridViewCellButtonAtIndexsearchColumnName), required: false);
            WorkflowValue.Validate(sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitle, nameof(sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitle), required: false);
            WorkflowValue.Validate(sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitleIsRegularExpression, nameof(sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitleIsRegularExpression), required: false);
            WorkflowValue.Validate(sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitleIsCaseSensitive, nameof(sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitleIsCaseSensitive), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/SAPGUI/SAPPressSAPGridViewCellButtonAtIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPPressSAPGridViewCellButtonAtIndex = new JObject();
                var sAPPressSAPGridViewCellButtonAtIndexpropCount = 0;
                sAPPressSAPGridViewCellButtonAtIndexpropCount++;
                sAPPressSAPGridViewCellButtonAtIndex["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPPressSAPGridViewCellButtonAtIndexsearchSAPElementId);
                sAPPressSAPGridViewCellButtonAtIndexpropCount++;
                sAPPressSAPGridViewCellButtonAtIndex["RowIndex"] = ExpressionConverter.ConvertO(sAPPressSAPGridViewCellButtonAtIndexrowIndex);
                if (sAPPressSAPGridViewCellButtonAtIndexsearchColumnName != null)
                {
                    sAPPressSAPGridViewCellButtonAtIndex["SearchColumnName"] = ExpressionConverter.ConvertO(sAPPressSAPGridViewCellButtonAtIndexsearchColumnName);
                    sAPPressSAPGridViewCellButtonAtIndexpropCount++;
                }

                if (sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitle != null)
                {
                    sAPPressSAPGridViewCellButtonAtIndex["SearchColumnTitle"] = ExpressionConverter.ConvertO(sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitle);
                    sAPPressSAPGridViewCellButtonAtIndexpropCount++;
                }

                if (sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitleIsRegularExpression != null)
                {
                    if (sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitleIsRegularExpression != null)
                    {
                        sAPPressSAPGridViewCellButtonAtIndex["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitleIsRegularExpression);
                        sAPPressSAPGridViewCellButtonAtIndexpropCount++;
                    }

                    sAPPressSAPGridViewCellButtonAtIndexpropCount++;
                }
                else
                {
                    sAPPressSAPGridViewCellButtonAtIndex["SearchColumnTitleIsRegularExpression"] = false;
                    sAPPressSAPGridViewCellButtonAtIndexpropCount++;
                }

                if (sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitleIsCaseSensitive != null)
                {
                    if (sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitleIsCaseSensitive != null)
                    {
                        sAPPressSAPGridViewCellButtonAtIndex["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitleIsCaseSensitive);
                        sAPPressSAPGridViewCellButtonAtIndexpropCount++;
                    }

                    sAPPressSAPGridViewCellButtonAtIndexpropCount++;
                }
                else
                {
                    sAPPressSAPGridViewCellButtonAtIndex["SearchColumnTitleIsCaseSensitive"] = false;
                    sAPPressSAPGridViewCellButtonAtIndexpropCount++;
                }

                sAPPressSAPGridViewCellButtonAtIndexpropCount++;
                sAPPressSAPGridViewCellButtonAtIndex["Workflow"] = ExpressionConverter.ConvertO(sAPPressSAPGridViewCellButtonAtIndexworkflow);
                if (sAPPressSAPGridViewCellButtonAtIndexpropCount > 0)
                {
                    callPayload.Body = sAPPressSAPGridViewCellButtonAtIndex;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPCheckSAPGridViewCellCheckboxAtIndex))]
        public IWorkflowAction SAPCheckSAPGridViewCellCheckboxAtIndex([WorkflowExpression] Func<string> sAPCheckSAPGridViewCellCheckboxAtIndexsearchSAPElementId, [WorkflowExpression] Func<int> sAPCheckSAPGridViewCellCheckboxAtIndexrowIndex, [WorkflowExpression] Func<string> sAPCheckSAPGridViewCellCheckboxAtIndexworkflow, [WorkflowExpression] Func<string> sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnName = null, [WorkflowExpression] Func<string> sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitle = null, [WorkflowExpression] Func<bool> sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitleIsRegularExpression = null, [WorkflowExpression] Func<bool> sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitleIsCaseSensitive = null, [WorkflowExpression] Func<bool> sAPCheckSAPGridViewCellCheckboxAtIndexcheckCellElement = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSAPCheckSAPGridViewCellCheckboxAtIndex(WorkflowValue<string> sAPCheckSAPGridViewCellCheckboxAtIndexsearchSAPElementId, WorkflowValue<int> sAPCheckSAPGridViewCellCheckboxAtIndexrowIndex, WorkflowValue<string> sAPCheckSAPGridViewCellCheckboxAtIndexworkflow, WorkflowValue<string> sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnName = null, WorkflowValue<string> sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitle = null, WorkflowValue<bool> sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitleIsRegularExpression = null, WorkflowValue<bool> sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitleIsCaseSensitive = null, WorkflowValue<bool> sAPCheckSAPGridViewCellCheckboxAtIndexcheckCellElement = null)
        {
            WorkflowValue.Validate(sAPCheckSAPGridViewCellCheckboxAtIndexsearchSAPElementId, nameof(sAPCheckSAPGridViewCellCheckboxAtIndexsearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPCheckSAPGridViewCellCheckboxAtIndexrowIndex, nameof(sAPCheckSAPGridViewCellCheckboxAtIndexrowIndex), required: true);
            WorkflowValue.Validate(sAPCheckSAPGridViewCellCheckboxAtIndexworkflow, nameof(sAPCheckSAPGridViewCellCheckboxAtIndexworkflow), required: true);
            WorkflowValue.Validate(sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnName, nameof(sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnName), required: false);
            WorkflowValue.Validate(sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitle, nameof(sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitle), required: false);
            WorkflowValue.Validate(sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitleIsRegularExpression, nameof(sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitleIsRegularExpression), required: false);
            WorkflowValue.Validate(sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitleIsCaseSensitive, nameof(sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitleIsCaseSensitive), required: false);
            WorkflowValue.Validate(sAPCheckSAPGridViewCellCheckboxAtIndexcheckCellElement, nameof(sAPCheckSAPGridViewCellCheckboxAtIndexcheckCellElement), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/SAPGUI/SAPCheckSAPGridViewCellCheckboxAtIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPCheckSAPGridViewCellCheckboxAtIndex = new JObject();
                var sAPCheckSAPGridViewCellCheckboxAtIndexpropCount = 0;
                sAPCheckSAPGridViewCellCheckboxAtIndexpropCount++;
                sAPCheckSAPGridViewCellCheckboxAtIndex["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPCheckSAPGridViewCellCheckboxAtIndexsearchSAPElementId);
                sAPCheckSAPGridViewCellCheckboxAtIndexpropCount++;
                sAPCheckSAPGridViewCellCheckboxAtIndex["RowIndex"] = ExpressionConverter.ConvertO(sAPCheckSAPGridViewCellCheckboxAtIndexrowIndex);
                if (sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnName != null)
                {
                    sAPCheckSAPGridViewCellCheckboxAtIndex["SearchColumnName"] = ExpressionConverter.ConvertO(sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnName);
                    sAPCheckSAPGridViewCellCheckboxAtIndexpropCount++;
                }

                if (sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitle != null)
                {
                    sAPCheckSAPGridViewCellCheckboxAtIndex["SearchColumnTitle"] = ExpressionConverter.ConvertO(sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitle);
                    sAPCheckSAPGridViewCellCheckboxAtIndexpropCount++;
                }

                if (sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitleIsRegularExpression != null)
                {
                    if (sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitleIsRegularExpression != null)
                    {
                        sAPCheckSAPGridViewCellCheckboxAtIndex["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitleIsRegularExpression);
                        sAPCheckSAPGridViewCellCheckboxAtIndexpropCount++;
                    }

                    sAPCheckSAPGridViewCellCheckboxAtIndexpropCount++;
                }
                else
                {
                    sAPCheckSAPGridViewCellCheckboxAtIndex["SearchColumnTitleIsRegularExpression"] = false;
                    sAPCheckSAPGridViewCellCheckboxAtIndexpropCount++;
                }

                if (sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitleIsCaseSensitive != null)
                {
                    if (sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitleIsCaseSensitive != null)
                    {
                        sAPCheckSAPGridViewCellCheckboxAtIndex["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitleIsCaseSensitive);
                        sAPCheckSAPGridViewCellCheckboxAtIndexpropCount++;
                    }

                    sAPCheckSAPGridViewCellCheckboxAtIndexpropCount++;
                }
                else
                {
                    sAPCheckSAPGridViewCellCheckboxAtIndex["SearchColumnTitleIsCaseSensitive"] = false;
                    sAPCheckSAPGridViewCellCheckboxAtIndexpropCount++;
                }

                if (sAPCheckSAPGridViewCellCheckboxAtIndexcheckCellElement != null)
                {
                    if (sAPCheckSAPGridViewCellCheckboxAtIndexcheckCellElement != null)
                    {
                        sAPCheckSAPGridViewCellCheckboxAtIndex["CheckCellElement"] = ExpressionConverter.ConvertO(sAPCheckSAPGridViewCellCheckboxAtIndexcheckCellElement);
                        sAPCheckSAPGridViewCellCheckboxAtIndexpropCount++;
                    }

                    sAPCheckSAPGridViewCellCheckboxAtIndexpropCount++;
                }
                else
                {
                    sAPCheckSAPGridViewCellCheckboxAtIndex["CheckCellElement"] = true;
                    sAPCheckSAPGridViewCellCheckboxAtIndexpropCount++;
                }

                sAPCheckSAPGridViewCellCheckboxAtIndexpropCount++;
                sAPCheckSAPGridViewCellCheckboxAtIndex["Workflow"] = ExpressionConverter.ConvertO(sAPCheckSAPGridViewCellCheckboxAtIndexworkflow);
                if (sAPCheckSAPGridViewCellCheckboxAtIndexpropCount > 0)
                {
                    callPayload.Body = sAPCheckSAPGridViewCellCheckboxAtIndex;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPModifySAPGridViewCellAtIndex))]
        public IBodyWorkflowAction<SAPModifySAPGridViewCellAtIndexResponse> SAPModifySAPGridViewCellAtIndex([WorkflowExpression] Func<string> sAPModifySAPGridViewCellAtIndexsearchSAPElementId, [WorkflowExpression] Func<int> sAPModifySAPGridViewCellAtIndexrowIndex, [WorkflowExpression] Func<string> sAPModifySAPGridViewCellAtIndexworkflow, [WorkflowExpression] Func<string> sAPModifySAPGridViewCellAtIndexsearchColumnName = null, [WorkflowExpression] Func<string> sAPModifySAPGridViewCellAtIndexsearchColumnTitle = null, [WorkflowExpression] Func<bool> sAPModifySAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression = null, [WorkflowExpression] Func<bool> sAPModifySAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive = null, [WorkflowExpression] Func<string> sAPModifySAPGridViewCellAtIndexnewValue = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SAPModifySAPGridViewCellAtIndexResponse> __BuildSAPModifySAPGridViewCellAtIndex(WorkflowValue<string> sAPModifySAPGridViewCellAtIndexsearchSAPElementId, WorkflowValue<int> sAPModifySAPGridViewCellAtIndexrowIndex, WorkflowValue<string> sAPModifySAPGridViewCellAtIndexworkflow, WorkflowValue<string> sAPModifySAPGridViewCellAtIndexsearchColumnName = null, WorkflowValue<string> sAPModifySAPGridViewCellAtIndexsearchColumnTitle = null, WorkflowValue<bool> sAPModifySAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression = null, WorkflowValue<bool> sAPModifySAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive = null, WorkflowValue<string> sAPModifySAPGridViewCellAtIndexnewValue = null)
        {
            WorkflowValue.Validate(sAPModifySAPGridViewCellAtIndexsearchSAPElementId, nameof(sAPModifySAPGridViewCellAtIndexsearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPModifySAPGridViewCellAtIndexrowIndex, nameof(sAPModifySAPGridViewCellAtIndexrowIndex), required: true);
            WorkflowValue.Validate(sAPModifySAPGridViewCellAtIndexworkflow, nameof(sAPModifySAPGridViewCellAtIndexworkflow), required: true);
            WorkflowValue.Validate(sAPModifySAPGridViewCellAtIndexsearchColumnName, nameof(sAPModifySAPGridViewCellAtIndexsearchColumnName), required: false);
            WorkflowValue.Validate(sAPModifySAPGridViewCellAtIndexsearchColumnTitle, nameof(sAPModifySAPGridViewCellAtIndexsearchColumnTitle), required: false);
            WorkflowValue.Validate(sAPModifySAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression, nameof(sAPModifySAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression), required: false);
            WorkflowValue.Validate(sAPModifySAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive, nameof(sAPModifySAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive), required: false);
            WorkflowValue.Validate(sAPModifySAPGridViewCellAtIndexnewValue, nameof(sAPModifySAPGridViewCellAtIndexnewValue), required: false);
            return new DeferredBodyAction<SAPModifySAPGridViewCellAtIndexResponse>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPModifySAPGridViewCellAtIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPModifySAPGridViewCellAtIndex = new JObject();
                var sAPModifySAPGridViewCellAtIndexpropCount = 0;
                sAPModifySAPGridViewCellAtIndexpropCount++;
                sAPModifySAPGridViewCellAtIndex["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPModifySAPGridViewCellAtIndexsearchSAPElementId);
                sAPModifySAPGridViewCellAtIndexpropCount++;
                sAPModifySAPGridViewCellAtIndex["RowIndex"] = ExpressionConverter.ConvertO(sAPModifySAPGridViewCellAtIndexrowIndex);
                if (sAPModifySAPGridViewCellAtIndexsearchColumnName != null)
                {
                    sAPModifySAPGridViewCellAtIndex["SearchColumnName"] = ExpressionConverter.ConvertO(sAPModifySAPGridViewCellAtIndexsearchColumnName);
                    sAPModifySAPGridViewCellAtIndexpropCount++;
                }

                if (sAPModifySAPGridViewCellAtIndexsearchColumnTitle != null)
                {
                    sAPModifySAPGridViewCellAtIndex["SearchColumnTitle"] = ExpressionConverter.ConvertO(sAPModifySAPGridViewCellAtIndexsearchColumnTitle);
                    sAPModifySAPGridViewCellAtIndexpropCount++;
                }

                if (sAPModifySAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression != null)
                {
                    if (sAPModifySAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression != null)
                    {
                        sAPModifySAPGridViewCellAtIndex["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(sAPModifySAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression);
                        sAPModifySAPGridViewCellAtIndexpropCount++;
                    }

                    sAPModifySAPGridViewCellAtIndexpropCount++;
                }
                else
                {
                    sAPModifySAPGridViewCellAtIndex["SearchColumnTitleIsRegularExpression"] = false;
                    sAPModifySAPGridViewCellAtIndexpropCount++;
                }

                if (sAPModifySAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive != null)
                {
                    if (sAPModifySAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive != null)
                    {
                        sAPModifySAPGridViewCellAtIndex["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPModifySAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive);
                        sAPModifySAPGridViewCellAtIndexpropCount++;
                    }

                    sAPModifySAPGridViewCellAtIndexpropCount++;
                }
                else
                {
                    sAPModifySAPGridViewCellAtIndex["SearchColumnTitleIsCaseSensitive"] = false;
                    sAPModifySAPGridViewCellAtIndexpropCount++;
                }

                if (sAPModifySAPGridViewCellAtIndexnewValue != null)
                {
                    sAPModifySAPGridViewCellAtIndex["NewValue"] = ExpressionConverter.ConvertO(sAPModifySAPGridViewCellAtIndexnewValue);
                    sAPModifySAPGridViewCellAtIndexpropCount++;
                }

                sAPModifySAPGridViewCellAtIndexpropCount++;
                sAPModifySAPGridViewCellAtIndex["Workflow"] = ExpressionConverter.ConvertO(sAPModifySAPGridViewCellAtIndexworkflow);
                if (sAPModifySAPGridViewCellAtIndexpropCount > 0)
                {
                    callPayload.Body = sAPModifySAPGridViewCellAtIndex;
                }

                return new ApiConnectionAction<SAPModifySAPGridViewCellAtIndexResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPSetSAPGridViewCurrentRow))]
        public IWorkflowAction SAPSetSAPGridViewCurrentRow([WorkflowExpression] Func<string> sAPSetSAPGridViewCurrentRowsearchSAPElementId, [WorkflowExpression] Func<int> sAPSetSAPGridViewCurrentRowrowIndex, [WorkflowExpression] Func<string> sAPSetSAPGridViewCurrentRowworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSAPSetSAPGridViewCurrentRow(WorkflowValue<string> sAPSetSAPGridViewCurrentRowsearchSAPElementId, WorkflowValue<int> sAPSetSAPGridViewCurrentRowrowIndex, WorkflowValue<string> sAPSetSAPGridViewCurrentRowworkflow)
        {
            WorkflowValue.Validate(sAPSetSAPGridViewCurrentRowsearchSAPElementId, nameof(sAPSetSAPGridViewCurrentRowsearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPSetSAPGridViewCurrentRowrowIndex, nameof(sAPSetSAPGridViewCurrentRowrowIndex), required: true);
            WorkflowValue.Validate(sAPSetSAPGridViewCurrentRowworkflow, nameof(sAPSetSAPGridViewCurrentRowworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSetSAPGridViewCurrentRow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPSetSAPGridViewCurrentRow = new JObject();
                var sAPSetSAPGridViewCurrentRowpropCount = 0;
                sAPSetSAPGridViewCurrentRowpropCount++;
                sAPSetSAPGridViewCurrentRow["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPSetSAPGridViewCurrentRowsearchSAPElementId);
                sAPSetSAPGridViewCurrentRowpropCount++;
                sAPSetSAPGridViewCurrentRow["RowIndex"] = ExpressionConverter.ConvertO(sAPSetSAPGridViewCurrentRowrowIndex);
                sAPSetSAPGridViewCurrentRowpropCount++;
                sAPSetSAPGridViewCurrentRow["Workflow"] = ExpressionConverter.ConvertO(sAPSetSAPGridViewCurrentRowworkflow);
                if (sAPSetSAPGridViewCurrentRowpropCount > 0)
                {
                    callPayload.Body = sAPSetSAPGridViewCurrentRow;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPPressSAPGridViewColumnHeader))]
        public IWorkflowAction SAPPressSAPGridViewColumnHeader([WorkflowExpression] Func<string> sAPPressSAPGridViewColumnHeadersearchSAPElementId, [WorkflowExpression] Func<string> sAPPressSAPGridViewColumnHeaderworkflow, [WorkflowExpression] Func<string> sAPPressSAPGridViewColumnHeadersearchColumnName = null, [WorkflowExpression] Func<string> sAPPressSAPGridViewColumnHeadersearchColumnTitle = null, [WorkflowExpression] Func<bool> sAPPressSAPGridViewColumnHeadersearchColumnTitleIsRegularExpression = null, [WorkflowExpression] Func<bool> sAPPressSAPGridViewColumnHeadersearchColumnTitleIsCaseSensitive = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSAPPressSAPGridViewColumnHeader(WorkflowValue<string> sAPPressSAPGridViewColumnHeadersearchSAPElementId, WorkflowValue<string> sAPPressSAPGridViewColumnHeaderworkflow, WorkflowValue<string> sAPPressSAPGridViewColumnHeadersearchColumnName = null, WorkflowValue<string> sAPPressSAPGridViewColumnHeadersearchColumnTitle = null, WorkflowValue<bool> sAPPressSAPGridViewColumnHeadersearchColumnTitleIsRegularExpression = null, WorkflowValue<bool> sAPPressSAPGridViewColumnHeadersearchColumnTitleIsCaseSensitive = null)
        {
            WorkflowValue.Validate(sAPPressSAPGridViewColumnHeadersearchSAPElementId, nameof(sAPPressSAPGridViewColumnHeadersearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPPressSAPGridViewColumnHeaderworkflow, nameof(sAPPressSAPGridViewColumnHeaderworkflow), required: true);
            WorkflowValue.Validate(sAPPressSAPGridViewColumnHeadersearchColumnName, nameof(sAPPressSAPGridViewColumnHeadersearchColumnName), required: false);
            WorkflowValue.Validate(sAPPressSAPGridViewColumnHeadersearchColumnTitle, nameof(sAPPressSAPGridViewColumnHeadersearchColumnTitle), required: false);
            WorkflowValue.Validate(sAPPressSAPGridViewColumnHeadersearchColumnTitleIsRegularExpression, nameof(sAPPressSAPGridViewColumnHeadersearchColumnTitleIsRegularExpression), required: false);
            WorkflowValue.Validate(sAPPressSAPGridViewColumnHeadersearchColumnTitleIsCaseSensitive, nameof(sAPPressSAPGridViewColumnHeadersearchColumnTitleIsCaseSensitive), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/SAPGUI/SAPPressSAPGridViewColumnHeader";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPPressSAPGridViewColumnHeader = new JObject();
                var sAPPressSAPGridViewColumnHeaderpropCount = 0;
                sAPPressSAPGridViewColumnHeaderpropCount++;
                sAPPressSAPGridViewColumnHeader["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPPressSAPGridViewColumnHeadersearchSAPElementId);
                if (sAPPressSAPGridViewColumnHeadersearchColumnName != null)
                {
                    sAPPressSAPGridViewColumnHeader["SearchColumnName"] = ExpressionConverter.ConvertO(sAPPressSAPGridViewColumnHeadersearchColumnName);
                    sAPPressSAPGridViewColumnHeaderpropCount++;
                }

                if (sAPPressSAPGridViewColumnHeadersearchColumnTitle != null)
                {
                    sAPPressSAPGridViewColumnHeader["SearchColumnTitle"] = ExpressionConverter.ConvertO(sAPPressSAPGridViewColumnHeadersearchColumnTitle);
                    sAPPressSAPGridViewColumnHeaderpropCount++;
                }

                if (sAPPressSAPGridViewColumnHeadersearchColumnTitleIsRegularExpression != null)
                {
                    if (sAPPressSAPGridViewColumnHeadersearchColumnTitleIsRegularExpression != null)
                    {
                        sAPPressSAPGridViewColumnHeader["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(sAPPressSAPGridViewColumnHeadersearchColumnTitleIsRegularExpression);
                        sAPPressSAPGridViewColumnHeaderpropCount++;
                    }

                    sAPPressSAPGridViewColumnHeaderpropCount++;
                }
                else
                {
                    sAPPressSAPGridViewColumnHeader["SearchColumnTitleIsRegularExpression"] = false;
                    sAPPressSAPGridViewColumnHeaderpropCount++;
                }

                if (sAPPressSAPGridViewColumnHeadersearchColumnTitleIsCaseSensitive != null)
                {
                    if (sAPPressSAPGridViewColumnHeadersearchColumnTitleIsCaseSensitive != null)
                    {
                        sAPPressSAPGridViewColumnHeader["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPPressSAPGridViewColumnHeadersearchColumnTitleIsCaseSensitive);
                        sAPPressSAPGridViewColumnHeaderpropCount++;
                    }

                    sAPPressSAPGridViewColumnHeaderpropCount++;
                }
                else
                {
                    sAPPressSAPGridViewColumnHeader["SearchColumnTitleIsCaseSensitive"] = false;
                    sAPPressSAPGridViewColumnHeaderpropCount++;
                }

                sAPPressSAPGridViewColumnHeaderpropCount++;
                sAPPressSAPGridViewColumnHeader["Workflow"] = ExpressionConverter.ConvertO(sAPPressSAPGridViewColumnHeaderworkflow);
                if (sAPPressSAPGridViewColumnHeaderpropCount > 0)
                {
                    callPayload.Body = sAPPressSAPGridViewColumnHeader;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPSetSAPGridViewFirstVisibleRow))]
        public IBodyWorkflowAction<SAPSetSAPGridViewFirstVisibleRowResponse> SAPSetSAPGridViewFirstVisibleRow([WorkflowExpression] Func<string> sAPSetSAPGridViewFirstVisibleRowsearchSAPElementId, [WorkflowExpression] Func<int> sAPSetSAPGridViewFirstVisibleRowfirstVisibleRowIndex, [WorkflowExpression] Func<string> sAPSetSAPGridViewFirstVisibleRowworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SAPSetSAPGridViewFirstVisibleRowResponse> __BuildSAPSetSAPGridViewFirstVisibleRow(WorkflowValue<string> sAPSetSAPGridViewFirstVisibleRowsearchSAPElementId, WorkflowValue<int> sAPSetSAPGridViewFirstVisibleRowfirstVisibleRowIndex, WorkflowValue<string> sAPSetSAPGridViewFirstVisibleRowworkflow)
        {
            WorkflowValue.Validate(sAPSetSAPGridViewFirstVisibleRowsearchSAPElementId, nameof(sAPSetSAPGridViewFirstVisibleRowsearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPSetSAPGridViewFirstVisibleRowfirstVisibleRowIndex, nameof(sAPSetSAPGridViewFirstVisibleRowfirstVisibleRowIndex), required: true);
            WorkflowValue.Validate(sAPSetSAPGridViewFirstVisibleRowworkflow, nameof(sAPSetSAPGridViewFirstVisibleRowworkflow), required: true);
            return new DeferredBodyAction<SAPSetSAPGridViewFirstVisibleRowResponse>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSetSAPGridViewFirstVisibleRow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPSetSAPGridViewFirstVisibleRow = new JObject();
                var sAPSetSAPGridViewFirstVisibleRowpropCount = 0;
                sAPSetSAPGridViewFirstVisibleRowpropCount++;
                sAPSetSAPGridViewFirstVisibleRow["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPSetSAPGridViewFirstVisibleRowsearchSAPElementId);
                sAPSetSAPGridViewFirstVisibleRowpropCount++;
                sAPSetSAPGridViewFirstVisibleRow["FirstVisibleRowIndex"] = ExpressionConverter.ConvertO(sAPSetSAPGridViewFirstVisibleRowfirstVisibleRowIndex);
                sAPSetSAPGridViewFirstVisibleRowpropCount++;
                sAPSetSAPGridViewFirstVisibleRow["Workflow"] = ExpressionConverter.ConvertO(sAPSetSAPGridViewFirstVisibleRowworkflow);
                if (sAPSetSAPGridViewFirstVisibleRowpropCount > 0)
                {
                    callPayload.Body = sAPSetSAPGridViewFirstVisibleRow;
                }

                return new ApiConnectionAction<SAPSetSAPGridViewFirstVisibleRowResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPSelectSAPGridViewRow))]
        public IWorkflowAction SAPSelectSAPGridViewRow([WorkflowExpression] Func<string> sAPSelectSAPGridViewRowsearchSAPElementId, [WorkflowExpression] Func<int> sAPSelectSAPGridViewRowrowIndex, [WorkflowExpression] Func<string> sAPSelectSAPGridViewRowworkflow, [WorkflowExpression] Func<bool> sAPSelectSAPGridViewRowsetAsCurrentRow = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSAPSelectSAPGridViewRow(WorkflowValue<string> sAPSelectSAPGridViewRowsearchSAPElementId, WorkflowValue<int> sAPSelectSAPGridViewRowrowIndex, WorkflowValue<string> sAPSelectSAPGridViewRowworkflow, WorkflowValue<bool> sAPSelectSAPGridViewRowsetAsCurrentRow = null)
        {
            WorkflowValue.Validate(sAPSelectSAPGridViewRowsearchSAPElementId, nameof(sAPSelectSAPGridViewRowsearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPSelectSAPGridViewRowrowIndex, nameof(sAPSelectSAPGridViewRowrowIndex), required: true);
            WorkflowValue.Validate(sAPSelectSAPGridViewRowworkflow, nameof(sAPSelectSAPGridViewRowworkflow), required: true);
            WorkflowValue.Validate(sAPSelectSAPGridViewRowsetAsCurrentRow, nameof(sAPSelectSAPGridViewRowsetAsCurrentRow), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSelectSAPGridViewRow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPSelectSAPGridViewRow = new JObject();
                var sAPSelectSAPGridViewRowpropCount = 0;
                sAPSelectSAPGridViewRowpropCount++;
                sAPSelectSAPGridViewRow["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPSelectSAPGridViewRowsearchSAPElementId);
                sAPSelectSAPGridViewRowpropCount++;
                sAPSelectSAPGridViewRow["RowIndex"] = ExpressionConverter.ConvertO(sAPSelectSAPGridViewRowrowIndex);
                if (sAPSelectSAPGridViewRowsetAsCurrentRow != null)
                {
                    if (sAPSelectSAPGridViewRowsetAsCurrentRow != null)
                    {
                        sAPSelectSAPGridViewRow["SetAsCurrentRow"] = ExpressionConverter.ConvertO(sAPSelectSAPGridViewRowsetAsCurrentRow);
                        sAPSelectSAPGridViewRowpropCount++;
                    }

                    sAPSelectSAPGridViewRowpropCount++;
                }
                else
                {
                    sAPSelectSAPGridViewRow["SetAsCurrentRow"] = true;
                    sAPSelectSAPGridViewRowpropCount++;
                }

                sAPSelectSAPGridViewRowpropCount++;
                sAPSelectSAPGridViewRow["Workflow"] = ExpressionConverter.ConvertO(sAPSelectSAPGridViewRowworkflow);
                if (sAPSelectSAPGridViewRowpropCount > 0)
                {
                    callPayload.Body = sAPSelectSAPGridViewRow;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPSelectSAPGridViewMultipleRows))]
        public IWorkflowAction SAPSelectSAPGridViewMultipleRows([WorkflowExpression] Func<string> sAPSelectSAPGridViewMultipleRowssearchSAPElementId, [WorkflowExpression] Func<string> sAPSelectSAPGridViewMultipleRowsrowsToSelect, [WorkflowExpression] Func<string> sAPSelectSAPGridViewMultipleRowsworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSAPSelectSAPGridViewMultipleRows(WorkflowValue<string> sAPSelectSAPGridViewMultipleRowssearchSAPElementId, WorkflowValue<string> sAPSelectSAPGridViewMultipleRowsrowsToSelect, WorkflowValue<string> sAPSelectSAPGridViewMultipleRowsworkflow)
        {
            WorkflowValue.Validate(sAPSelectSAPGridViewMultipleRowssearchSAPElementId, nameof(sAPSelectSAPGridViewMultipleRowssearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPSelectSAPGridViewMultipleRowsrowsToSelect, nameof(sAPSelectSAPGridViewMultipleRowsrowsToSelect), required: true);
            WorkflowValue.Validate(sAPSelectSAPGridViewMultipleRowsworkflow, nameof(sAPSelectSAPGridViewMultipleRowsworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSelectSAPGridViewMultipleRows";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPSelectSAPGridViewMultipleRows = new JObject();
                var sAPSelectSAPGridViewMultipleRowspropCount = 0;
                sAPSelectSAPGridViewMultipleRowspropCount++;
                sAPSelectSAPGridViewMultipleRows["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPSelectSAPGridViewMultipleRowssearchSAPElementId);
                sAPSelectSAPGridViewMultipleRowspropCount++;
                sAPSelectSAPGridViewMultipleRows["RowsToSelect"] = ExpressionConverter.ConvertO(sAPSelectSAPGridViewMultipleRowsrowsToSelect);
                sAPSelectSAPGridViewMultipleRowspropCount++;
                sAPSelectSAPGridViewMultipleRows["Workflow"] = ExpressionConverter.ConvertO(sAPSelectSAPGridViewMultipleRowsworkflow);
                if (sAPSelectSAPGridViewMultipleRowspropCount > 0)
                {
                    callPayload.Body = sAPSelectSAPGridViewMultipleRows;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPSetSAPGridViewCurrentColumn))]
        public IWorkflowAction SAPSetSAPGridViewCurrentColumn([WorkflowExpression] Func<string> sAPSetSAPGridViewCurrentColumnsearchSAPElementId, [WorkflowExpression] Func<string> sAPSetSAPGridViewCurrentColumnworkflow, [WorkflowExpression] Func<string> sAPSetSAPGridViewCurrentColumnsearchColumnName = null, [WorkflowExpression] Func<string> sAPSetSAPGridViewCurrentColumnsearchColumnTitle = null, [WorkflowExpression] Func<bool> sAPSetSAPGridViewCurrentColumnsearchColumnTitleIsRegularExpression = null, [WorkflowExpression] Func<bool> sAPSetSAPGridViewCurrentColumnsearchColumnTitleIsCaseSensitive = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSAPSetSAPGridViewCurrentColumn(WorkflowValue<string> sAPSetSAPGridViewCurrentColumnsearchSAPElementId, WorkflowValue<string> sAPSetSAPGridViewCurrentColumnworkflow, WorkflowValue<string> sAPSetSAPGridViewCurrentColumnsearchColumnName = null, WorkflowValue<string> sAPSetSAPGridViewCurrentColumnsearchColumnTitle = null, WorkflowValue<bool> sAPSetSAPGridViewCurrentColumnsearchColumnTitleIsRegularExpression = null, WorkflowValue<bool> sAPSetSAPGridViewCurrentColumnsearchColumnTitleIsCaseSensitive = null)
        {
            WorkflowValue.Validate(sAPSetSAPGridViewCurrentColumnsearchSAPElementId, nameof(sAPSetSAPGridViewCurrentColumnsearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPSetSAPGridViewCurrentColumnworkflow, nameof(sAPSetSAPGridViewCurrentColumnworkflow), required: true);
            WorkflowValue.Validate(sAPSetSAPGridViewCurrentColumnsearchColumnName, nameof(sAPSetSAPGridViewCurrentColumnsearchColumnName), required: false);
            WorkflowValue.Validate(sAPSetSAPGridViewCurrentColumnsearchColumnTitle, nameof(sAPSetSAPGridViewCurrentColumnsearchColumnTitle), required: false);
            WorkflowValue.Validate(sAPSetSAPGridViewCurrentColumnsearchColumnTitleIsRegularExpression, nameof(sAPSetSAPGridViewCurrentColumnsearchColumnTitleIsRegularExpression), required: false);
            WorkflowValue.Validate(sAPSetSAPGridViewCurrentColumnsearchColumnTitleIsCaseSensitive, nameof(sAPSetSAPGridViewCurrentColumnsearchColumnTitleIsCaseSensitive), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSetSAPGridViewCurrentColumn";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPSetSAPGridViewCurrentColumn = new JObject();
                var sAPSetSAPGridViewCurrentColumnpropCount = 0;
                sAPSetSAPGridViewCurrentColumnpropCount++;
                sAPSetSAPGridViewCurrentColumn["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPSetSAPGridViewCurrentColumnsearchSAPElementId);
                if (sAPSetSAPGridViewCurrentColumnsearchColumnName != null)
                {
                    sAPSetSAPGridViewCurrentColumn["SearchColumnName"] = ExpressionConverter.ConvertO(sAPSetSAPGridViewCurrentColumnsearchColumnName);
                    sAPSetSAPGridViewCurrentColumnpropCount++;
                }

                if (sAPSetSAPGridViewCurrentColumnsearchColumnTitle != null)
                {
                    sAPSetSAPGridViewCurrentColumn["SearchColumnTitle"] = ExpressionConverter.ConvertO(sAPSetSAPGridViewCurrentColumnsearchColumnTitle);
                    sAPSetSAPGridViewCurrentColumnpropCount++;
                }

                if (sAPSetSAPGridViewCurrentColumnsearchColumnTitleIsRegularExpression != null)
                {
                    if (sAPSetSAPGridViewCurrentColumnsearchColumnTitleIsRegularExpression != null)
                    {
                        sAPSetSAPGridViewCurrentColumn["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(sAPSetSAPGridViewCurrentColumnsearchColumnTitleIsRegularExpression);
                        sAPSetSAPGridViewCurrentColumnpropCount++;
                    }

                    sAPSetSAPGridViewCurrentColumnpropCount++;
                }
                else
                {
                    sAPSetSAPGridViewCurrentColumn["SearchColumnTitleIsRegularExpression"] = false;
                    sAPSetSAPGridViewCurrentColumnpropCount++;
                }

                if (sAPSetSAPGridViewCurrentColumnsearchColumnTitleIsCaseSensitive != null)
                {
                    if (sAPSetSAPGridViewCurrentColumnsearchColumnTitleIsCaseSensitive != null)
                    {
                        sAPSetSAPGridViewCurrentColumn["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPSetSAPGridViewCurrentColumnsearchColumnTitleIsCaseSensitive);
                        sAPSetSAPGridViewCurrentColumnpropCount++;
                    }

                    sAPSetSAPGridViewCurrentColumnpropCount++;
                }
                else
                {
                    sAPSetSAPGridViewCurrentColumn["SearchColumnTitleIsCaseSensitive"] = false;
                    sAPSetSAPGridViewCurrentColumnpropCount++;
                }

                sAPSetSAPGridViewCurrentColumnpropCount++;
                sAPSetSAPGridViewCurrentColumn["Workflow"] = ExpressionConverter.ConvertO(sAPSetSAPGridViewCurrentColumnworkflow);
                if (sAPSetSAPGridViewCurrentColumnpropCount > 0)
                {
                    callPayload.Body = sAPSetSAPGridViewCurrentColumn;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPSetSAPGridViewCurrentCell))]
        public IWorkflowAction SAPSetSAPGridViewCurrentCell([WorkflowExpression] Func<string> sAPSetSAPGridViewCurrentCellsearchSAPElementId, [WorkflowExpression] Func<int> sAPSetSAPGridViewCurrentCellrowIndex, [WorkflowExpression] Func<string> sAPSetSAPGridViewCurrentCellworkflow, [WorkflowExpression] Func<string> sAPSetSAPGridViewCurrentCellsearchColumnName = null, [WorkflowExpression] Func<string> sAPSetSAPGridViewCurrentCellsearchColumnTitle = null, [WorkflowExpression] Func<bool> sAPSetSAPGridViewCurrentCellsearchColumnTitleIsRegularExpression = null, [WorkflowExpression] Func<bool> sAPSetSAPGridViewCurrentCellsearchColumnTitleIsCaseSensitive = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSAPSetSAPGridViewCurrentCell(WorkflowValue<string> sAPSetSAPGridViewCurrentCellsearchSAPElementId, WorkflowValue<int> sAPSetSAPGridViewCurrentCellrowIndex, WorkflowValue<string> sAPSetSAPGridViewCurrentCellworkflow, WorkflowValue<string> sAPSetSAPGridViewCurrentCellsearchColumnName = null, WorkflowValue<string> sAPSetSAPGridViewCurrentCellsearchColumnTitle = null, WorkflowValue<bool> sAPSetSAPGridViewCurrentCellsearchColumnTitleIsRegularExpression = null, WorkflowValue<bool> sAPSetSAPGridViewCurrentCellsearchColumnTitleIsCaseSensitive = null)
        {
            WorkflowValue.Validate(sAPSetSAPGridViewCurrentCellsearchSAPElementId, nameof(sAPSetSAPGridViewCurrentCellsearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPSetSAPGridViewCurrentCellrowIndex, nameof(sAPSetSAPGridViewCurrentCellrowIndex), required: true);
            WorkflowValue.Validate(sAPSetSAPGridViewCurrentCellworkflow, nameof(sAPSetSAPGridViewCurrentCellworkflow), required: true);
            WorkflowValue.Validate(sAPSetSAPGridViewCurrentCellsearchColumnName, nameof(sAPSetSAPGridViewCurrentCellsearchColumnName), required: false);
            WorkflowValue.Validate(sAPSetSAPGridViewCurrentCellsearchColumnTitle, nameof(sAPSetSAPGridViewCurrentCellsearchColumnTitle), required: false);
            WorkflowValue.Validate(sAPSetSAPGridViewCurrentCellsearchColumnTitleIsRegularExpression, nameof(sAPSetSAPGridViewCurrentCellsearchColumnTitleIsRegularExpression), required: false);
            WorkflowValue.Validate(sAPSetSAPGridViewCurrentCellsearchColumnTitleIsCaseSensitive, nameof(sAPSetSAPGridViewCurrentCellsearchColumnTitleIsCaseSensitive), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSetSAPGridViewCurrentCell";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPSetSAPGridViewCurrentCell = new JObject();
                var sAPSetSAPGridViewCurrentCellpropCount = 0;
                sAPSetSAPGridViewCurrentCellpropCount++;
                sAPSetSAPGridViewCurrentCell["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPSetSAPGridViewCurrentCellsearchSAPElementId);
                sAPSetSAPGridViewCurrentCellpropCount++;
                sAPSetSAPGridViewCurrentCell["RowIndex"] = ExpressionConverter.ConvertO(sAPSetSAPGridViewCurrentCellrowIndex);
                if (sAPSetSAPGridViewCurrentCellsearchColumnName != null)
                {
                    sAPSetSAPGridViewCurrentCell["SearchColumnName"] = ExpressionConverter.ConvertO(sAPSetSAPGridViewCurrentCellsearchColumnName);
                    sAPSetSAPGridViewCurrentCellpropCount++;
                }

                if (sAPSetSAPGridViewCurrentCellsearchColumnTitle != null)
                {
                    sAPSetSAPGridViewCurrentCell["SearchColumnTitle"] = ExpressionConverter.ConvertO(sAPSetSAPGridViewCurrentCellsearchColumnTitle);
                    sAPSetSAPGridViewCurrentCellpropCount++;
                }

                if (sAPSetSAPGridViewCurrentCellsearchColumnTitleIsRegularExpression != null)
                {
                    if (sAPSetSAPGridViewCurrentCellsearchColumnTitleIsRegularExpression != null)
                    {
                        sAPSetSAPGridViewCurrentCell["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(sAPSetSAPGridViewCurrentCellsearchColumnTitleIsRegularExpression);
                        sAPSetSAPGridViewCurrentCellpropCount++;
                    }

                    sAPSetSAPGridViewCurrentCellpropCount++;
                }
                else
                {
                    sAPSetSAPGridViewCurrentCell["SearchColumnTitleIsRegularExpression"] = false;
                    sAPSetSAPGridViewCurrentCellpropCount++;
                }

                if (sAPSetSAPGridViewCurrentCellsearchColumnTitleIsCaseSensitive != null)
                {
                    if (sAPSetSAPGridViewCurrentCellsearchColumnTitleIsCaseSensitive != null)
                    {
                        sAPSetSAPGridViewCurrentCell["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPSetSAPGridViewCurrentCellsearchColumnTitleIsCaseSensitive);
                        sAPSetSAPGridViewCurrentCellpropCount++;
                    }

                    sAPSetSAPGridViewCurrentCellpropCount++;
                }
                else
                {
                    sAPSetSAPGridViewCurrentCell["SearchColumnTitleIsCaseSensitive"] = false;
                    sAPSetSAPGridViewCurrentCellpropCount++;
                }

                sAPSetSAPGridViewCurrentCellpropCount++;
                sAPSetSAPGridViewCurrentCell["Workflow"] = ExpressionConverter.ConvertO(sAPSetSAPGridViewCurrentCellworkflow);
                if (sAPSetSAPGridViewCurrentCellpropCount > 0)
                {
                    callPayload.Body = sAPSetSAPGridViewCurrentCell;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPSelectSAPGridViewColumn))]
        public IWorkflowAction SAPSelectSAPGridViewColumn([WorkflowExpression] Func<string> sAPSelectSAPGridViewColumnsearchSAPElementId, [WorkflowExpression] Func<string> sAPSelectSAPGridViewColumnworkflow, [WorkflowExpression] Func<string> sAPSelectSAPGridViewColumnsearchColumnName = null, [WorkflowExpression] Func<string> sAPSelectSAPGridViewColumnsearchColumnTitle = null, [WorkflowExpression] Func<bool> sAPSelectSAPGridViewColumnsearchColumnTitleIsRegularExpression = null, [WorkflowExpression] Func<bool> sAPSelectSAPGridViewColumnsearchColumnTitleIsCaseSensitive = null, [WorkflowExpression] Func<bool> sAPSelectSAPGridViewColumnselectColumn = null, [WorkflowExpression] Func<bool> sAPSelectSAPGridViewColumnsetAsCurrentColumn = null, [WorkflowExpression] Func<bool> sAPSelectSAPGridViewColumnclearSelectionFirst = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSAPSelectSAPGridViewColumn(WorkflowValue<string> sAPSelectSAPGridViewColumnsearchSAPElementId, WorkflowValue<string> sAPSelectSAPGridViewColumnworkflow, WorkflowValue<string> sAPSelectSAPGridViewColumnsearchColumnName = null, WorkflowValue<string> sAPSelectSAPGridViewColumnsearchColumnTitle = null, WorkflowValue<bool> sAPSelectSAPGridViewColumnsearchColumnTitleIsRegularExpression = null, WorkflowValue<bool> sAPSelectSAPGridViewColumnsearchColumnTitleIsCaseSensitive = null, WorkflowValue<bool> sAPSelectSAPGridViewColumnselectColumn = null, WorkflowValue<bool> sAPSelectSAPGridViewColumnsetAsCurrentColumn = null, WorkflowValue<bool> sAPSelectSAPGridViewColumnclearSelectionFirst = null)
        {
            WorkflowValue.Validate(sAPSelectSAPGridViewColumnsearchSAPElementId, nameof(sAPSelectSAPGridViewColumnsearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPSelectSAPGridViewColumnworkflow, nameof(sAPSelectSAPGridViewColumnworkflow), required: true);
            WorkflowValue.Validate(sAPSelectSAPGridViewColumnsearchColumnName, nameof(sAPSelectSAPGridViewColumnsearchColumnName), required: false);
            WorkflowValue.Validate(sAPSelectSAPGridViewColumnsearchColumnTitle, nameof(sAPSelectSAPGridViewColumnsearchColumnTitle), required: false);
            WorkflowValue.Validate(sAPSelectSAPGridViewColumnsearchColumnTitleIsRegularExpression, nameof(sAPSelectSAPGridViewColumnsearchColumnTitleIsRegularExpression), required: false);
            WorkflowValue.Validate(sAPSelectSAPGridViewColumnsearchColumnTitleIsCaseSensitive, nameof(sAPSelectSAPGridViewColumnsearchColumnTitleIsCaseSensitive), required: false);
            WorkflowValue.Validate(sAPSelectSAPGridViewColumnselectColumn, nameof(sAPSelectSAPGridViewColumnselectColumn), required: false);
            WorkflowValue.Validate(sAPSelectSAPGridViewColumnsetAsCurrentColumn, nameof(sAPSelectSAPGridViewColumnsetAsCurrentColumn), required: false);
            WorkflowValue.Validate(sAPSelectSAPGridViewColumnclearSelectionFirst, nameof(sAPSelectSAPGridViewColumnclearSelectionFirst), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSelectSAPGridViewColumn";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPSelectSAPGridViewColumn = new JObject();
                var sAPSelectSAPGridViewColumnpropCount = 0;
                sAPSelectSAPGridViewColumnpropCount++;
                sAPSelectSAPGridViewColumn["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPSelectSAPGridViewColumnsearchSAPElementId);
                if (sAPSelectSAPGridViewColumnsearchColumnName != null)
                {
                    sAPSelectSAPGridViewColumn["SearchColumnName"] = ExpressionConverter.ConvertO(sAPSelectSAPGridViewColumnsearchColumnName);
                    sAPSelectSAPGridViewColumnpropCount++;
                }

                if (sAPSelectSAPGridViewColumnsearchColumnTitle != null)
                {
                    sAPSelectSAPGridViewColumn["SearchColumnTitle"] = ExpressionConverter.ConvertO(sAPSelectSAPGridViewColumnsearchColumnTitle);
                    sAPSelectSAPGridViewColumnpropCount++;
                }

                if (sAPSelectSAPGridViewColumnsearchColumnTitleIsRegularExpression != null)
                {
                    if (sAPSelectSAPGridViewColumnsearchColumnTitleIsRegularExpression != null)
                    {
                        sAPSelectSAPGridViewColumn["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(sAPSelectSAPGridViewColumnsearchColumnTitleIsRegularExpression);
                        sAPSelectSAPGridViewColumnpropCount++;
                    }

                    sAPSelectSAPGridViewColumnpropCount++;
                }
                else
                {
                    sAPSelectSAPGridViewColumn["SearchColumnTitleIsRegularExpression"] = false;
                    sAPSelectSAPGridViewColumnpropCount++;
                }

                if (sAPSelectSAPGridViewColumnsearchColumnTitleIsCaseSensitive != null)
                {
                    if (sAPSelectSAPGridViewColumnsearchColumnTitleIsCaseSensitive != null)
                    {
                        sAPSelectSAPGridViewColumn["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPSelectSAPGridViewColumnsearchColumnTitleIsCaseSensitive);
                        sAPSelectSAPGridViewColumnpropCount++;
                    }

                    sAPSelectSAPGridViewColumnpropCount++;
                }
                else
                {
                    sAPSelectSAPGridViewColumn["SearchColumnTitleIsCaseSensitive"] = false;
                    sAPSelectSAPGridViewColumnpropCount++;
                }

                if (sAPSelectSAPGridViewColumnselectColumn != null)
                {
                    if (sAPSelectSAPGridViewColumnselectColumn != null)
                    {
                        sAPSelectSAPGridViewColumn["SelectColumn"] = ExpressionConverter.ConvertO(sAPSelectSAPGridViewColumnselectColumn);
                        sAPSelectSAPGridViewColumnpropCount++;
                    }

                    sAPSelectSAPGridViewColumnpropCount++;
                }
                else
                {
                    sAPSelectSAPGridViewColumn["SelectColumn"] = true;
                    sAPSelectSAPGridViewColumnpropCount++;
                }

                if (sAPSelectSAPGridViewColumnsetAsCurrentColumn != null)
                {
                    if (sAPSelectSAPGridViewColumnsetAsCurrentColumn != null)
                    {
                        sAPSelectSAPGridViewColumn["SetAsCurrentColumn"] = ExpressionConverter.ConvertO(sAPSelectSAPGridViewColumnsetAsCurrentColumn);
                        sAPSelectSAPGridViewColumnpropCount++;
                    }

                    sAPSelectSAPGridViewColumnpropCount++;
                }
                else
                {
                    sAPSelectSAPGridViewColumn["SetAsCurrentColumn"] = false;
                    sAPSelectSAPGridViewColumnpropCount++;
                }

                if (sAPSelectSAPGridViewColumnclearSelectionFirst != null)
                {
                    if (sAPSelectSAPGridViewColumnclearSelectionFirst != null)
                    {
                        sAPSelectSAPGridViewColumn["ClearSelectionFirst"] = ExpressionConverter.ConvertO(sAPSelectSAPGridViewColumnclearSelectionFirst);
                        sAPSelectSAPGridViewColumnpropCount++;
                    }

                    sAPSelectSAPGridViewColumnpropCount++;
                }
                else
                {
                    sAPSelectSAPGridViewColumn["ClearSelectionFirst"] = false;
                    sAPSelectSAPGridViewColumnpropCount++;
                }

                sAPSelectSAPGridViewColumnpropCount++;
                sAPSelectSAPGridViewColumn["Workflow"] = ExpressionConverter.ConvertO(sAPSelectSAPGridViewColumnworkflow);
                if (sAPSelectSAPGridViewColumnpropCount > 0)
                {
                    callPayload.Body = sAPSelectSAPGridViewColumn;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPGridViewSelectAll))]
        public IWorkflowAction SAPGridViewSelectAll([WorkflowExpression] Func<string> sAPGridViewSelectAllsearchSAPElementId, [WorkflowExpression] Func<string> sAPGridViewSelectAllworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSAPGridViewSelectAll(WorkflowValue<string> sAPGridViewSelectAllsearchSAPElementId, WorkflowValue<string> sAPGridViewSelectAllworkflow)
        {
            WorkflowValue.Validate(sAPGridViewSelectAllsearchSAPElementId, nameof(sAPGridViewSelectAllsearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPGridViewSelectAllworkflow, nameof(sAPGridViewSelectAllworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGridViewSelectAll";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGridViewSelectAll = new JObject();
                var sAPGridViewSelectAllpropCount = 0;
                sAPGridViewSelectAllpropCount++;
                sAPGridViewSelectAll["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGridViewSelectAllsearchSAPElementId);
                sAPGridViewSelectAllpropCount++;
                sAPGridViewSelectAll["Workflow"] = ExpressionConverter.ConvertO(sAPGridViewSelectAllworkflow);
                if (sAPGridViewSelectAllpropCount > 0)
                {
                    callPayload.Body = sAPGridViewSelectAll;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPGridViewDeselectAll))]
        public IWorkflowAction SAPGridViewDeselectAll([WorkflowExpression] Func<string> sAPGridViewDeselectAllsearchSAPElementId, [WorkflowExpression] Func<string> sAPGridViewDeselectAllworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSAPGridViewDeselectAll(WorkflowValue<string> sAPGridViewDeselectAllsearchSAPElementId, WorkflowValue<string> sAPGridViewDeselectAllworkflow)
        {
            WorkflowValue.Validate(sAPGridViewDeselectAllsearchSAPElementId, nameof(sAPGridViewDeselectAllsearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPGridViewDeselectAllworkflow, nameof(sAPGridViewDeselectAllworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGridViewDeselectAll";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGridViewDeselectAll = new JObject();
                var sAPGridViewDeselectAllpropCount = 0;
                sAPGridViewDeselectAllpropCount++;
                sAPGridViewDeselectAll["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGridViewDeselectAllsearchSAPElementId);
                sAPGridViewDeselectAllpropCount++;
                sAPGridViewDeselectAll["Workflow"] = ExpressionConverter.ConvertO(sAPGridViewDeselectAllworkflow);
                if (sAPGridViewDeselectAllpropCount > 0)
                {
                    callPayload.Body = sAPGridViewDeselectAll;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPSetSAPGridViewFirstVisibleColumn))]
        public IBodyWorkflowAction<SAPSetSAPGridViewFirstVisibleColumnResponse> SAPSetSAPGridViewFirstVisibleColumn([WorkflowExpression] Func<string> sAPSetSAPGridViewFirstVisibleColumnsearchSAPElementId, [WorkflowExpression] Func<string> sAPSetSAPGridViewFirstVisibleColumnworkflow, [WorkflowExpression] Func<string> sAPSetSAPGridViewFirstVisibleColumnsearchColumnName = null, [WorkflowExpression] Func<string> sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitle = null, [WorkflowExpression] Func<bool> sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitleIsRegularExpression = null, [WorkflowExpression] Func<bool> sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitleIsCaseSensitive = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SAPSetSAPGridViewFirstVisibleColumnResponse> __BuildSAPSetSAPGridViewFirstVisibleColumn(WorkflowValue<string> sAPSetSAPGridViewFirstVisibleColumnsearchSAPElementId, WorkflowValue<string> sAPSetSAPGridViewFirstVisibleColumnworkflow, WorkflowValue<string> sAPSetSAPGridViewFirstVisibleColumnsearchColumnName = null, WorkflowValue<string> sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitle = null, WorkflowValue<bool> sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitleIsRegularExpression = null, WorkflowValue<bool> sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitleIsCaseSensitive = null)
        {
            WorkflowValue.Validate(sAPSetSAPGridViewFirstVisibleColumnsearchSAPElementId, nameof(sAPSetSAPGridViewFirstVisibleColumnsearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPSetSAPGridViewFirstVisibleColumnworkflow, nameof(sAPSetSAPGridViewFirstVisibleColumnworkflow), required: true);
            WorkflowValue.Validate(sAPSetSAPGridViewFirstVisibleColumnsearchColumnName, nameof(sAPSetSAPGridViewFirstVisibleColumnsearchColumnName), required: false);
            WorkflowValue.Validate(sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitle, nameof(sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitle), required: false);
            WorkflowValue.Validate(sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitleIsRegularExpression, nameof(sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitleIsRegularExpression), required: false);
            WorkflowValue.Validate(sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitleIsCaseSensitive, nameof(sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitleIsCaseSensitive), required: false);
            return new DeferredBodyAction<SAPSetSAPGridViewFirstVisibleColumnResponse>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSetSAPGridViewFirstVisibleColumn";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPSetSAPGridViewFirstVisibleColumn = new JObject();
                var sAPSetSAPGridViewFirstVisibleColumnpropCount = 0;
                sAPSetSAPGridViewFirstVisibleColumnpropCount++;
                sAPSetSAPGridViewFirstVisibleColumn["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPSetSAPGridViewFirstVisibleColumnsearchSAPElementId);
                if (sAPSetSAPGridViewFirstVisibleColumnsearchColumnName != null)
                {
                    sAPSetSAPGridViewFirstVisibleColumn["SearchColumnName"] = ExpressionConverter.ConvertO(sAPSetSAPGridViewFirstVisibleColumnsearchColumnName);
                    sAPSetSAPGridViewFirstVisibleColumnpropCount++;
                }

                if (sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitle != null)
                {
                    sAPSetSAPGridViewFirstVisibleColumn["SearchColumnTitle"] = ExpressionConverter.ConvertO(sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitle);
                    sAPSetSAPGridViewFirstVisibleColumnpropCount++;
                }

                if (sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitleIsRegularExpression != null)
                {
                    if (sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitleIsRegularExpression != null)
                    {
                        sAPSetSAPGridViewFirstVisibleColumn["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitleIsRegularExpression);
                        sAPSetSAPGridViewFirstVisibleColumnpropCount++;
                    }

                    sAPSetSAPGridViewFirstVisibleColumnpropCount++;
                }
                else
                {
                    sAPSetSAPGridViewFirstVisibleColumn["SearchColumnTitleIsRegularExpression"] = false;
                    sAPSetSAPGridViewFirstVisibleColumnpropCount++;
                }

                if (sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitleIsCaseSensitive != null)
                {
                    if (sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitleIsCaseSensitive != null)
                    {
                        sAPSetSAPGridViewFirstVisibleColumn["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitleIsCaseSensitive);
                        sAPSetSAPGridViewFirstVisibleColumnpropCount++;
                    }

                    sAPSetSAPGridViewFirstVisibleColumnpropCount++;
                }
                else
                {
                    sAPSetSAPGridViewFirstVisibleColumn["SearchColumnTitleIsCaseSensitive"] = false;
                    sAPSetSAPGridViewFirstVisibleColumnpropCount++;
                }

                sAPSetSAPGridViewFirstVisibleColumnpropCount++;
                sAPSetSAPGridViewFirstVisibleColumn["Workflow"] = ExpressionConverter.ConvertO(sAPSetSAPGridViewFirstVisibleColumnworkflow);
                if (sAPSetSAPGridViewFirstVisibleColumnpropCount > 0)
                {
                    callPayload.Body = sAPSetSAPGridViewFirstVisibleColumn;
                }

                return new ApiConnectionAction<SAPSetSAPGridViewFirstVisibleColumnResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPGridViewOpenContextMenu))]
        public IWorkflowAction SAPGridViewOpenContextMenu([WorkflowExpression] Func<string> sAPGridViewOpenContextMenusearchSAPElementId, [WorkflowExpression] Func<int> sAPGridViewOpenContextMenurowIndex, [WorkflowExpression] Func<string> sAPGridViewOpenContextMenuworkflow, [WorkflowExpression] Func<string> sAPGridViewOpenContextMenusearchColumnName = null, [WorkflowExpression] Func<string> sAPGridViewOpenContextMenusearchColumnTitle = null, [WorkflowExpression] Func<bool> sAPGridViewOpenContextMenusearchColumnTitleIsRegularExpression = null, [WorkflowExpression] Func<bool> sAPGridViewOpenContextMenusearchColumnTitleIsCaseSensitive = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSAPGridViewOpenContextMenu(WorkflowValue<string> sAPGridViewOpenContextMenusearchSAPElementId, WorkflowValue<int> sAPGridViewOpenContextMenurowIndex, WorkflowValue<string> sAPGridViewOpenContextMenuworkflow, WorkflowValue<string> sAPGridViewOpenContextMenusearchColumnName = null, WorkflowValue<string> sAPGridViewOpenContextMenusearchColumnTitle = null, WorkflowValue<bool> sAPGridViewOpenContextMenusearchColumnTitleIsRegularExpression = null, WorkflowValue<bool> sAPGridViewOpenContextMenusearchColumnTitleIsCaseSensitive = null)
        {
            WorkflowValue.Validate(sAPGridViewOpenContextMenusearchSAPElementId, nameof(sAPGridViewOpenContextMenusearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPGridViewOpenContextMenurowIndex, nameof(sAPGridViewOpenContextMenurowIndex), required: true);
            WorkflowValue.Validate(sAPGridViewOpenContextMenuworkflow, nameof(sAPGridViewOpenContextMenuworkflow), required: true);
            WorkflowValue.Validate(sAPGridViewOpenContextMenusearchColumnName, nameof(sAPGridViewOpenContextMenusearchColumnName), required: false);
            WorkflowValue.Validate(sAPGridViewOpenContextMenusearchColumnTitle, nameof(sAPGridViewOpenContextMenusearchColumnTitle), required: false);
            WorkflowValue.Validate(sAPGridViewOpenContextMenusearchColumnTitleIsRegularExpression, nameof(sAPGridViewOpenContextMenusearchColumnTitleIsRegularExpression), required: false);
            WorkflowValue.Validate(sAPGridViewOpenContextMenusearchColumnTitleIsCaseSensitive, nameof(sAPGridViewOpenContextMenusearchColumnTitleIsCaseSensitive), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGridViewOpenContextMenu";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGridViewOpenContextMenu = new JObject();
                var sAPGridViewOpenContextMenupropCount = 0;
                sAPGridViewOpenContextMenupropCount++;
                sAPGridViewOpenContextMenu["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGridViewOpenContextMenusearchSAPElementId);
                sAPGridViewOpenContextMenupropCount++;
                sAPGridViewOpenContextMenu["RowIndex"] = ExpressionConverter.ConvertO(sAPGridViewOpenContextMenurowIndex);
                if (sAPGridViewOpenContextMenusearchColumnName != null)
                {
                    sAPGridViewOpenContextMenu["SearchColumnName"] = ExpressionConverter.ConvertO(sAPGridViewOpenContextMenusearchColumnName);
                    sAPGridViewOpenContextMenupropCount++;
                }

                if (sAPGridViewOpenContextMenusearchColumnTitle != null)
                {
                    sAPGridViewOpenContextMenu["SearchColumnTitle"] = ExpressionConverter.ConvertO(sAPGridViewOpenContextMenusearchColumnTitle);
                    sAPGridViewOpenContextMenupropCount++;
                }

                if (sAPGridViewOpenContextMenusearchColumnTitleIsRegularExpression != null)
                {
                    if (sAPGridViewOpenContextMenusearchColumnTitleIsRegularExpression != null)
                    {
                        sAPGridViewOpenContextMenu["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(sAPGridViewOpenContextMenusearchColumnTitleIsRegularExpression);
                        sAPGridViewOpenContextMenupropCount++;
                    }

                    sAPGridViewOpenContextMenupropCount++;
                }
                else
                {
                    sAPGridViewOpenContextMenu["SearchColumnTitleIsRegularExpression"] = false;
                    sAPGridViewOpenContextMenupropCount++;
                }

                if (sAPGridViewOpenContextMenusearchColumnTitleIsCaseSensitive != null)
                {
                    if (sAPGridViewOpenContextMenusearchColumnTitleIsCaseSensitive != null)
                    {
                        sAPGridViewOpenContextMenu["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPGridViewOpenContextMenusearchColumnTitleIsCaseSensitive);
                        sAPGridViewOpenContextMenupropCount++;
                    }

                    sAPGridViewOpenContextMenupropCount++;
                }
                else
                {
                    sAPGridViewOpenContextMenu["SearchColumnTitleIsCaseSensitive"] = false;
                    sAPGridViewOpenContextMenupropCount++;
                }

                sAPGridViewOpenContextMenupropCount++;
                sAPGridViewOpenContextMenu["Workflow"] = ExpressionConverter.ConvertO(sAPGridViewOpenContextMenuworkflow);
                if (sAPGridViewOpenContextMenupropCount > 0)
                {
                    callPayload.Body = sAPGridViewOpenContextMenu;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPGetGridViewTextContents))]
        public IBodyWorkflowAction<SAPGetGridViewTextContentsResponse> SAPGetGridViewTextContents([WorkflowExpression] Func<string> sAPGetGridViewTextContentssearchSAPElementId, [WorkflowExpression] Func<string> sAPGetGridViewTextContentsworkflow, [WorkflowExpression] Func<int> sAPGetGridViewTextContentsfirstRowToReturn = null, [WorkflowExpression] Func<int> sAPGetGridViewTextContentsmaxRowsToReturn = null, [WorkflowExpression] Func<string> sAPGetGridViewTextContentsfirstSearchColumnName = null, [WorkflowExpression] Func<string> sAPGetGridViewTextContentsfirstSearchColumnTitle = null, [WorkflowExpression] Func<bool> sAPGetGridViewTextContentsfirstSearchColumnTitleIsRegularExpression = null, [WorkflowExpression] Func<bool> sAPGetGridViewTextContentsfirstSearchColumnTitleIsCaseSensitive = null, [WorkflowExpression] Func<int> sAPGetGridViewTextContentsmaxColumnsToReturn = null, [WorkflowExpression] Func<bool> sAPGetGridViewTextContentsuseColumnHeadersFromTable = null, [WorkflowExpression] Func<bool> sAPGetGridViewTextContentsreturnRowIndexInOutputCollection = null, [WorkflowExpression] Func<string> sAPGetGridViewTextContentsnameOfColumnToStoreRowIndex = null, [WorkflowExpression] Func<string> sAPGetGridViewTextContentscheckedElementValue = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SAPGetGridViewTextContentsResponse> __BuildSAPGetGridViewTextContents(WorkflowValue<string> sAPGetGridViewTextContentssearchSAPElementId, WorkflowValue<string> sAPGetGridViewTextContentsworkflow, WorkflowValue<int> sAPGetGridViewTextContentsfirstRowToReturn = null, WorkflowValue<int> sAPGetGridViewTextContentsmaxRowsToReturn = null, WorkflowValue<string> sAPGetGridViewTextContentsfirstSearchColumnName = null, WorkflowValue<string> sAPGetGridViewTextContentsfirstSearchColumnTitle = null, WorkflowValue<bool> sAPGetGridViewTextContentsfirstSearchColumnTitleIsRegularExpression = null, WorkflowValue<bool> sAPGetGridViewTextContentsfirstSearchColumnTitleIsCaseSensitive = null, WorkflowValue<int> sAPGetGridViewTextContentsmaxColumnsToReturn = null, WorkflowValue<bool> sAPGetGridViewTextContentsuseColumnHeadersFromTable = null, WorkflowValue<bool> sAPGetGridViewTextContentsreturnRowIndexInOutputCollection = null, WorkflowValue<string> sAPGetGridViewTextContentsnameOfColumnToStoreRowIndex = null, WorkflowValue<string> sAPGetGridViewTextContentscheckedElementValue = null)
        {
            WorkflowValue.Validate(sAPGetGridViewTextContentssearchSAPElementId, nameof(sAPGetGridViewTextContentssearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPGetGridViewTextContentsworkflow, nameof(sAPGetGridViewTextContentsworkflow), required: true);
            WorkflowValue.Validate(sAPGetGridViewTextContentsfirstRowToReturn, nameof(sAPGetGridViewTextContentsfirstRowToReturn), required: false);
            WorkflowValue.Validate(sAPGetGridViewTextContentsmaxRowsToReturn, nameof(sAPGetGridViewTextContentsmaxRowsToReturn), required: false);
            WorkflowValue.Validate(sAPGetGridViewTextContentsfirstSearchColumnName, nameof(sAPGetGridViewTextContentsfirstSearchColumnName), required: false);
            WorkflowValue.Validate(sAPGetGridViewTextContentsfirstSearchColumnTitle, nameof(sAPGetGridViewTextContentsfirstSearchColumnTitle), required: false);
            WorkflowValue.Validate(sAPGetGridViewTextContentsfirstSearchColumnTitleIsRegularExpression, nameof(sAPGetGridViewTextContentsfirstSearchColumnTitleIsRegularExpression), required: false);
            WorkflowValue.Validate(sAPGetGridViewTextContentsfirstSearchColumnTitleIsCaseSensitive, nameof(sAPGetGridViewTextContentsfirstSearchColumnTitleIsCaseSensitive), required: false);
            WorkflowValue.Validate(sAPGetGridViewTextContentsmaxColumnsToReturn, nameof(sAPGetGridViewTextContentsmaxColumnsToReturn), required: false);
            WorkflowValue.Validate(sAPGetGridViewTextContentsuseColumnHeadersFromTable, nameof(sAPGetGridViewTextContentsuseColumnHeadersFromTable), required: false);
            WorkflowValue.Validate(sAPGetGridViewTextContentsreturnRowIndexInOutputCollection, nameof(sAPGetGridViewTextContentsreturnRowIndexInOutputCollection), required: false);
            WorkflowValue.Validate(sAPGetGridViewTextContentsnameOfColumnToStoreRowIndex, nameof(sAPGetGridViewTextContentsnameOfColumnToStoreRowIndex), required: false);
            WorkflowValue.Validate(sAPGetGridViewTextContentscheckedElementValue, nameof(sAPGetGridViewTextContentscheckedElementValue), required: false);
            return new DeferredBodyAction<SAPGetGridViewTextContentsResponse>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetGridViewTextContents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGetGridViewTextContents = new JObject();
                var sAPGetGridViewTextContentspropCount = 0;
                sAPGetGridViewTextContentspropCount++;
                sAPGetGridViewTextContents["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGetGridViewTextContentssearchSAPElementId);
                if (sAPGetGridViewTextContentsfirstRowToReturn != null)
                {
                    if (sAPGetGridViewTextContentsfirstRowToReturn != null)
                    {
                        sAPGetGridViewTextContents["FirstRowToReturn"] = ExpressionConverter.ConvertO(sAPGetGridViewTextContentsfirstRowToReturn);
                        sAPGetGridViewTextContentspropCount++;
                    }

                    sAPGetGridViewTextContentspropCount++;
                }
                else
                {
                    sAPGetGridViewTextContents["FirstRowToReturn"] = 1;
                    sAPGetGridViewTextContentspropCount++;
                }

                if (sAPGetGridViewTextContentsmaxRowsToReturn != null)
                {
                    if (sAPGetGridViewTextContentsmaxRowsToReturn != null)
                    {
                        sAPGetGridViewTextContents["MaxRowsToReturn"] = ExpressionConverter.ConvertO(sAPGetGridViewTextContentsmaxRowsToReturn);
                        sAPGetGridViewTextContentspropCount++;
                    }

                    sAPGetGridViewTextContentspropCount++;
                }
                else
                {
                    sAPGetGridViewTextContents["MaxRowsToReturn"] = 0;
                    sAPGetGridViewTextContentspropCount++;
                }

                if (sAPGetGridViewTextContentsfirstSearchColumnName != null)
                {
                    sAPGetGridViewTextContents["FirstSearchColumnName"] = ExpressionConverter.ConvertO(sAPGetGridViewTextContentsfirstSearchColumnName);
                    sAPGetGridViewTextContentspropCount++;
                }

                if (sAPGetGridViewTextContentsfirstSearchColumnTitle != null)
                {
                    sAPGetGridViewTextContents["FirstSearchColumnTitle"] = ExpressionConverter.ConvertO(sAPGetGridViewTextContentsfirstSearchColumnTitle);
                    sAPGetGridViewTextContentspropCount++;
                }

                if (sAPGetGridViewTextContentsfirstSearchColumnTitleIsRegularExpression != null)
                {
                    if (sAPGetGridViewTextContentsfirstSearchColumnTitleIsRegularExpression != null)
                    {
                        sAPGetGridViewTextContents["FirstSearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(sAPGetGridViewTextContentsfirstSearchColumnTitleIsRegularExpression);
                        sAPGetGridViewTextContentspropCount++;
                    }

                    sAPGetGridViewTextContentspropCount++;
                }
                else
                {
                    sAPGetGridViewTextContents["FirstSearchColumnTitleIsRegularExpression"] = false;
                    sAPGetGridViewTextContentspropCount++;
                }

                if (sAPGetGridViewTextContentsfirstSearchColumnTitleIsCaseSensitive != null)
                {
                    if (sAPGetGridViewTextContentsfirstSearchColumnTitleIsCaseSensitive != null)
                    {
                        sAPGetGridViewTextContents["FirstSearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPGetGridViewTextContentsfirstSearchColumnTitleIsCaseSensitive);
                        sAPGetGridViewTextContentspropCount++;
                    }

                    sAPGetGridViewTextContentspropCount++;
                }
                else
                {
                    sAPGetGridViewTextContents["FirstSearchColumnTitleIsCaseSensitive"] = false;
                    sAPGetGridViewTextContentspropCount++;
                }

                if (sAPGetGridViewTextContentsmaxColumnsToReturn != null)
                {
                    if (sAPGetGridViewTextContentsmaxColumnsToReturn != null)
                    {
                        sAPGetGridViewTextContents["MaxColumnsToReturn"] = ExpressionConverter.ConvertO(sAPGetGridViewTextContentsmaxColumnsToReturn);
                        sAPGetGridViewTextContentspropCount++;
                    }

                    sAPGetGridViewTextContentspropCount++;
                }
                else
                {
                    sAPGetGridViewTextContents["MaxColumnsToReturn"] = 0;
                    sAPGetGridViewTextContentspropCount++;
                }

                if (sAPGetGridViewTextContentsuseColumnHeadersFromTable != null)
                {
                    if (sAPGetGridViewTextContentsuseColumnHeadersFromTable != null)
                    {
                        sAPGetGridViewTextContents["UseColumnHeadersFromTable"] = ExpressionConverter.ConvertO(sAPGetGridViewTextContentsuseColumnHeadersFromTable);
                        sAPGetGridViewTextContentspropCount++;
                    }

                    sAPGetGridViewTextContentspropCount++;
                }
                else
                {
                    sAPGetGridViewTextContents["UseColumnHeadersFromTable"] = true;
                    sAPGetGridViewTextContentspropCount++;
                }

                if (sAPGetGridViewTextContentsreturnRowIndexInOutputCollection != null)
                {
                    if (sAPGetGridViewTextContentsreturnRowIndexInOutputCollection != null)
                    {
                        sAPGetGridViewTextContents["ReturnRowIndexInOutputCollection"] = ExpressionConverter.ConvertO(sAPGetGridViewTextContentsreturnRowIndexInOutputCollection);
                        sAPGetGridViewTextContentspropCount++;
                    }

                    sAPGetGridViewTextContentspropCount++;
                }
                else
                {
                    sAPGetGridViewTextContents["ReturnRowIndexInOutputCollection"] = false;
                    sAPGetGridViewTextContentspropCount++;
                }

                if (sAPGetGridViewTextContentsnameOfColumnToStoreRowIndex != null)
                {
                    sAPGetGridViewTextContents["NameOfColumnToStoreRowIndex"] = ExpressionConverter.ConvertO(sAPGetGridViewTextContentsnameOfColumnToStoreRowIndex);
                    sAPGetGridViewTextContentspropCount++;
                }

                if (sAPGetGridViewTextContentscheckedElementValue != null)
                {
                    if (sAPGetGridViewTextContentscheckedElementValue != null)
                    {
                        sAPGetGridViewTextContents["CheckedElementValue"] = ExpressionConverter.ConvertO(sAPGetGridViewTextContentscheckedElementValue);
                        sAPGetGridViewTextContentspropCount++;
                    }

                    sAPGetGridViewTextContentspropCount++;
                }
                else
                {
                    sAPGetGridViewTextContents["CheckedElementValue"] = "True";
                    sAPGetGridViewTextContentspropCount++;
                }

                sAPGetGridViewTextContentspropCount++;
                sAPGetGridViewTextContents["Workflow"] = ExpressionConverter.ConvertO(sAPGetGridViewTextContentsworkflow);
                if (sAPGetGridViewTextContentspropCount > 0)
                {
                    callPayload.Body = sAPGetGridViewTextContents;
                }

                return new ApiConnectionAction<SAPGetGridViewTextContentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPSelectCalendarMonth))]
        public IWorkflowAction SAPSelectCalendarMonth([WorkflowExpression] Func<string> sAPSelectCalendarMonthsearchSAPElementId, [WorkflowExpression] Func<int> sAPSelectCalendarMonthmonth, [WorkflowExpression] Func<int> sAPSelectCalendarMonthyear, [WorkflowExpression] Func<string> sAPSelectCalendarMonthworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSAPSelectCalendarMonth(WorkflowValue<string> sAPSelectCalendarMonthsearchSAPElementId, WorkflowValue<int> sAPSelectCalendarMonthmonth, WorkflowValue<int> sAPSelectCalendarMonthyear, WorkflowValue<string> sAPSelectCalendarMonthworkflow)
        {
            WorkflowValue.Validate(sAPSelectCalendarMonthsearchSAPElementId, nameof(sAPSelectCalendarMonthsearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPSelectCalendarMonthmonth, nameof(sAPSelectCalendarMonthmonth), required: true);
            WorkflowValue.Validate(sAPSelectCalendarMonthyear, nameof(sAPSelectCalendarMonthyear), required: true);
            WorkflowValue.Validate(sAPSelectCalendarMonthworkflow, nameof(sAPSelectCalendarMonthworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSelectCalendarMonth";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPSelectCalendarMonth = new JObject();
                var sAPSelectCalendarMonthpropCount = 0;
                sAPSelectCalendarMonthpropCount++;
                sAPSelectCalendarMonth["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPSelectCalendarMonthsearchSAPElementId);
                sAPSelectCalendarMonthpropCount++;
                sAPSelectCalendarMonth["Month"] = ExpressionConverter.ConvertO(sAPSelectCalendarMonthmonth);
                sAPSelectCalendarMonthpropCount++;
                sAPSelectCalendarMonth["Year"] = ExpressionConverter.ConvertO(sAPSelectCalendarMonthyear);
                sAPSelectCalendarMonthpropCount++;
                sAPSelectCalendarMonth["Workflow"] = ExpressionConverter.ConvertO(sAPSelectCalendarMonthworkflow);
                if (sAPSelectCalendarMonthpropCount > 0)
                {
                    callPayload.Body = sAPSelectCalendarMonth;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPSelectCalendarWeek))]
        public IWorkflowAction SAPSelectCalendarWeek([WorkflowExpression] Func<string> sAPSelectCalendarWeeksearchSAPElementId, [WorkflowExpression] Func<int> sAPSelectCalendarWeekweek, [WorkflowExpression] Func<int> sAPSelectCalendarWeekyear, [WorkflowExpression] Func<string> sAPSelectCalendarWeekworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSAPSelectCalendarWeek(WorkflowValue<string> sAPSelectCalendarWeeksearchSAPElementId, WorkflowValue<int> sAPSelectCalendarWeekweek, WorkflowValue<int> sAPSelectCalendarWeekyear, WorkflowValue<string> sAPSelectCalendarWeekworkflow)
        {
            WorkflowValue.Validate(sAPSelectCalendarWeeksearchSAPElementId, nameof(sAPSelectCalendarWeeksearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPSelectCalendarWeekweek, nameof(sAPSelectCalendarWeekweek), required: true);
            WorkflowValue.Validate(sAPSelectCalendarWeekyear, nameof(sAPSelectCalendarWeekyear), required: true);
            WorkflowValue.Validate(sAPSelectCalendarWeekworkflow, nameof(sAPSelectCalendarWeekworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSelectCalendarWeek";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPSelectCalendarWeek = new JObject();
                var sAPSelectCalendarWeekpropCount = 0;
                sAPSelectCalendarWeekpropCount++;
                sAPSelectCalendarWeek["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPSelectCalendarWeeksearchSAPElementId);
                sAPSelectCalendarWeekpropCount++;
                sAPSelectCalendarWeek["Week"] = ExpressionConverter.ConvertO(sAPSelectCalendarWeekweek);
                sAPSelectCalendarWeekpropCount++;
                sAPSelectCalendarWeek["Year"] = ExpressionConverter.ConvertO(sAPSelectCalendarWeekyear);
                sAPSelectCalendarWeekpropCount++;
                sAPSelectCalendarWeek["Workflow"] = ExpressionConverter.ConvertO(sAPSelectCalendarWeekworkflow);
                if (sAPSelectCalendarWeekpropCount > 0)
                {
                    callPayload.Body = sAPSelectCalendarWeek;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPSelectCalendarRange))]
        public IWorkflowAction SAPSelectCalendarRange([WorkflowExpression] Func<string> sAPSelectCalendarRangesearchSAPElementId, [WorkflowExpression] Func<string> sAPSelectCalendarRangefromDateYYYYMMDD, [WorkflowExpression] Func<string> sAPSelectCalendarRangetoDateYYYYMMDD, [WorkflowExpression] Func<string> sAPSelectCalendarRangeworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSAPSelectCalendarRange(WorkflowValue<string> sAPSelectCalendarRangesearchSAPElementId, WorkflowValue<string> sAPSelectCalendarRangefromDateYYYYMMDD, WorkflowValue<string> sAPSelectCalendarRangetoDateYYYYMMDD, WorkflowValue<string> sAPSelectCalendarRangeworkflow)
        {
            WorkflowValue.Validate(sAPSelectCalendarRangesearchSAPElementId, nameof(sAPSelectCalendarRangesearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPSelectCalendarRangefromDateYYYYMMDD, nameof(sAPSelectCalendarRangefromDateYYYYMMDD), required: true);
            WorkflowValue.Validate(sAPSelectCalendarRangetoDateYYYYMMDD, nameof(sAPSelectCalendarRangetoDateYYYYMMDD), required: true);
            WorkflowValue.Validate(sAPSelectCalendarRangeworkflow, nameof(sAPSelectCalendarRangeworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSelectCalendarRange";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPSelectCalendarRange = new JObject();
                var sAPSelectCalendarRangepropCount = 0;
                sAPSelectCalendarRangepropCount++;
                sAPSelectCalendarRange["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPSelectCalendarRangesearchSAPElementId);
                sAPSelectCalendarRangepropCount++;
                sAPSelectCalendarRange["FromDateYYYYMMDD"] = ExpressionConverter.ConvertO(sAPSelectCalendarRangefromDateYYYYMMDD);
                sAPSelectCalendarRangepropCount++;
                sAPSelectCalendarRange["ToDateYYYYMMDD"] = ExpressionConverter.ConvertO(sAPSelectCalendarRangetoDateYYYYMMDD);
                sAPSelectCalendarRangepropCount++;
                sAPSelectCalendarRange["Workflow"] = ExpressionConverter.ConvertO(sAPSelectCalendarRangeworkflow);
                if (sAPSelectCalendarRangepropCount > 0)
                {
                    callPayload.Body = sAPSelectCalendarRange;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        [WorkflowExpressionFactory(nameof(__BuildSAPFocusCalendarDate))]
        public IWorkflowAction SAPFocusCalendarDate([WorkflowExpression] Func<string> sAPFocusCalendarDatesearchSAPElementId, [WorkflowExpression] Func<string> sAPFocusCalendarDatedateYYYYMMDD, [WorkflowExpression] Func<string> sAPFocusCalendarDateworkflow)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSAPFocusCalendarDate(WorkflowValue<string> sAPFocusCalendarDatesearchSAPElementId, WorkflowValue<string> sAPFocusCalendarDatedateYYYYMMDD, WorkflowValue<string> sAPFocusCalendarDateworkflow)
        {
            WorkflowValue.Validate(sAPFocusCalendarDatesearchSAPElementId, nameof(sAPFocusCalendarDatesearchSAPElementId), required: true);
            WorkflowValue.Validate(sAPFocusCalendarDatedateYYYYMMDD, nameof(sAPFocusCalendarDatedateYYYYMMDD), required: true);
            WorkflowValue.Validate(sAPFocusCalendarDateworkflow, nameof(sAPFocusCalendarDateworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/SAPGUI/SAPFocusCalendarDate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPFocusCalendarDate = new JObject();
                var sAPFocusCalendarDatepropCount = 0;
                sAPFocusCalendarDatepropCount++;
                sAPFocusCalendarDate["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPFocusCalendarDatesearchSAPElementId);
                sAPFocusCalendarDatepropCount++;
                sAPFocusCalendarDate["DateYYYYMMDD"] = ExpressionConverter.ConvertO(sAPFocusCalendarDatedateYYYYMMDD);
                sAPFocusCalendarDatepropCount++;
                sAPFocusCalendarDate["Workflow"] = ExpressionConverter.ConvertO(sAPFocusCalendarDateworkflow);
                if (sAPFocusCalendarDatepropCount > 0)
                {
                    callPayload.Body = sAPFocusCalendarDate;
                }

                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class IaconnectsapguiTriggers([ConnectionName] string connectionId)
    {
    }

    public class SAPLaunchSAPGUIResponse
    {
        public int SAPGUIMajorVersion { get; set; }
        public int SAPGUIRevision { get; set; }
        public int SAPGUIPatchLevel { get; set; }
        public int SAPGUIMinorVersion { get; set; }
        public bool SAPGUINewVisualDesign { get; set; }
    }

    public class SAPAttachToSAPGUIResponse
    {
        public int NumberOfSAPConnections { get; set; }
        public int SAPGUIMajorVersion { get; set; }
        public int SAPGUIRevision { get; set; }
        public int SAPGUIPatchLevel { get; set; }
        public int SAPGUIMinorVersion { get; set; }
        public bool SAPGUINewVisualDesign { get; set; }
    }

    public class SAPGetSAPGUIStatusResponse
    {
        public bool Connected { get; set; }
        public string ConnectionError { get; set; }
        public int NumberOfSAPConnections { get; set; }
        public int SAPGUIMajorVersion { get; set; }
        public int SAPGUIRevision { get; set; }
        public int SAPGUIPatchLevel { get; set; }
        public int SAPGUIMinorVersion { get; set; }
        public bool SAPGUINewVisualDesign { get; set; }
        public bool ConnectedToSession { get; set; }
        public string SessionError { get; set; }
        public string SessionName { get; set; }
        public string SessionSystemName { get; set; }
    }

    public class SAPGetSAPSessionsResponse
    {
        public int NumberOfSAPConnections { get; set; }
        public string SAPConnectionsJSON { get; set; }
        public int NumberOfSAPSessions { get; set; }
        public string SAPSessionsJSON { get; set; }
    }

    public class SAPAttachToSessionResponse
    {
        public string AttachedConnectionName { get; set; }
        public string AttachedSessionName { get; set; }
    }

    public class SAPGetAttachedSessionPropertiesResponse
    {
        public bool ConnectedToSession { get; set; }
        public string SessionError { get; set; }
        public string SessionName { get; set; }
        public string SessionSystemName { get; set; }
        public bool Busy { get; set; }
        public int SessionNumber { get; set; }
        public string LoggedInUser { get; set; }
        public int ScreenNumber { get; set; }
        public string ActiveTransaction { get; set; }
    }

    public class SAPWaitForAttachedSessionNotBusyResponse
    {
        public bool BusyAfterWait { get; set; }
    }

    public class SAPGetElementPropertiesResponse
    {
        public string SAPElementType { get; set; }
        public int SAPElementTypeCode { get; set; }
        public string SAPElementName { get; set; }
        public string SAPElementId { get; set; }
        public string SAPElementSubType { get; set; }
        public string SAPElementTextValue { get; set; }
        public bool SAPElementIsContainer { get; set; }
        public int SAPElementNumberOfChildren { get; set; }
        public bool SAPElementIsChangeable { get; set; }
        public bool SAPElementIsModified { get; set; }
        public bool SAPElementIsSelected { get; set; }
        public bool SAPElementIsHighlighted { get; set; }
        public bool SAPElementIsVisible { get; set; }
        public int SAPElementLeftEdge { get; set; }
        public int SAPElementTopEdge { get; set; }
        public int SAPElementWidth { get; set; }
        public int SAPElementHeight { get; set; }
        public int SAPElementRightEdge { get; set; }
        public int SAPElementBottomEdge { get; set; }
        public string SAPElementMessageType { get; set; }
    }

    public class SAPWaitForElementIdResponse
    {
        public bool SAPElementExists { get; set; }
        public string SAPElementType { get; set; }
        public int SAPElementTypeCode { get; set; }
        public string SAPElementName { get; set; }
        public string SAPElementSubType { get; set; }
    }

    public class SAPWaitForWindowResponse
    {
        public bool SAPWindowExists { get; set; }
        public string SAPElementId { get; set; }
        public string SAPElementType { get; set; }
        public int SAPElementTypeCode { get; set; }
        public string SAPElementName { get; set; }
        public string SAPElementSubType { get; set; }
    }

    public class SAPGetElementTextValueResponse
    {
        public string SAPElementTextValue { get; set; }
        public string SAPElementMessageType { get; set; }
    }

    public enum sAPGlobalLeftMouseClickOnSAPElementoffsetRelativeToInput
    {
        Center,
        Left,
        Right,
        Top,
        Bottom,
        [EnumMember(Value = "Top Left")]
        TopLeft,
        [EnumMember(Value = "Top Right")]
        TopRight,
        [EnumMember(Value = "Bottom Left")]
        BottomLeft,
        [EnumMember(Value = "Bottom Right")]
        BottomRight
    }

    public enum sAPGlobalRightMouseClickOnSAPElementoffsetRelativeToInput
    {
        Center,
        Left,
        Right,
        Top,
        Bottom,
        [EnumMember(Value = "Top Left")]
        TopLeft,
        [EnumMember(Value = "Top Right")]
        TopRight,
        [EnumMember(Value = "Bottom Left")]
        BottomLeft,
        [EnumMember(Value = "Bottom Right")]
        BottomRight
    }

    public enum sAPGlobalMiddleMouseClickOnSAPElementoffsetRelativeToInput
    {
        Center,
        Left,
        Right,
        Top,
        Bottom,
        [EnumMember(Value = "Top Left")]
        TopLeft,
        [EnumMember(Value = "Top Right")]
        TopRight,
        [EnumMember(Value = "Bottom Left")]
        BottomLeft,
        [EnumMember(Value = "Bottom Right")]
        BottomRight
    }

    public enum sAPGlobalDoubleLeftMouseClickOnSAPElementoffsetRelativeToInput
    {
        Center,
        Left,
        Right,
        Top,
        Bottom,
        [EnumMember(Value = "Top Left")]
        TopLeft,
        [EnumMember(Value = "Top Right")]
        TopRight,
        [EnumMember(Value = "Bottom Left")]
        BottomLeft,
        [EnumMember(Value = "Bottom Right")]
        BottomRight
    }

    public class SAPGetListSelectionElementItemsResponse
    {
        public int NumberOfItemsInList { get; set; }
        public string SAPSelectionListItemsJSON { get; set; }
        public string CurrentlySelectedValue { get; set; }
        public string CurrentlySelectedKey { get; set; }
        public bool ValueRequired { get; set; }
    }

    public class SAPGetAllChildSAPElementPropertiesResponse
    {
        public int NumberOfChildElementsReturned { get; set; }
        public bool MoreElementsAvailableAtCurrentDepth { get; set; }
        public string SAPChildElementsJSON { get; set; }
    }

    public class SAPGetSAPSessionTopLevelSAPElementPropertiesResponse
    {
        public int NumberOfChildElementsReturned { get; set; }
        public bool MoreElementsAvailableAtCurrentDepth { get; set; }
        public string SAPChildElementsJSON { get; set; }
    }

    public class SAPGetSAPElementParentIdResponse
    {
        public string SAPParentElementId { get; set; }
        public string SAPParentElementType { get; set; }
        public int SAPParentElementTypeCode { get; set; }
    }

    public class SAPGetElementPropertiesAsListResponse
    {
        public int NumberOfElementsReturned { get; set; }
        public string SAPElementsJSON { get; set; }
    }

    public class SAPGetSAPElementAtScreenCoordinateResponse
    {
        public string SAPElementId { get; set; }
    }

    public class SAPOpenConnectionResponse
    {
        public string OpenedConnectionName { get; set; }
        public bool ScriptingDisabledByServer { get; set; }
        public int NumberOfSAPSessions { get; set; }
        public string ConnectedSessionName { get; set; }
    }

    public class SAPGetSAPTablePropertiesResponse
    {
        public int NumberOfVisibleRows { get; set; }
        public int NumberOfVisibleColumns { get; set; }
        public int VerticalScrollbarMinimum { get; set; }
        public int VerticalScrollbarMaximum { get; set; }
        public int VerticalScrollbarPosition { get; set; }
        public int VerticalScrollbarPageSize { get; set; }
        public int EstimatedNumberOfRows { get; set; }
        public int HorizontalScrollbarMinimum { get; set; }
        public int HorizontalScrollbarMaximum { get; set; }
        public int HorizontalScrollbarPosition { get; set; }
        public int HorizontalScrollbarPageSize { get; set; }
        public int EstimatedNumberOfColumns { get; set; }
        public string RowSelectMode { get; set; }
        public string ColumnSelectMode { get; set; }
    }

    public class SAPGetSAPTableVisibleCellTextContentsAtIndexResponse
    {
        public string CellTextContents { get; set; }
        public string CellColumnName { get; set; }
        public int HorizontalScrollbarPosition { get; set; }
        public int VerticalScrollbarPosition { get; set; }
        public int EstimatedActualRowIndex { get; set; }
        public int EstimatedActualColumnIndex { get; set; }
    }

    public class SAPGetSAPTableVisibleCellPropertiesAtIndexResponse
    {
        public string SAPElementType { get; set; }
        public int SAPElementTypeCode { get; set; }
        public string SAPElementName { get; set; }
        public string SAPElementId { get; set; }
        public string SAPElementSubType { get; set; }
        public string SAPElementTextValue { get; set; }
        public bool SAPElementIsContainer { get; set; }
        public int SAPElementNumberOfChildren { get; set; }
        public bool SAPElementIsChangeable { get; set; }
        public bool SAPElementIsModified { get; set; }
        public bool SAPElementIsSelected { get; set; }
        public bool SAPElementIsHighlighted { get; set; }
        public bool SAPElementIsVisible { get; set; }
        public int SAPElementLeftEdge { get; set; }
        public int SAPElementTopEdge { get; set; }
        public int SAPElementWidth { get; set; }
        public int SAPElementHeight { get; set; }
        public int SAPElementRightEdge { get; set; }
        public int SAPElementBottomEdge { get; set; }
        public string CellColumnName { get; set; }
        public int HorizontalScrollbarPosition { get; set; }
        public int VerticalScrollbarPosition { get; set; }
        public int EstimatedActualRowIndex { get; set; }
        public int EstimatedActualColumnIndex { get; set; }
    }

    public class SAPGetTableVisibleTextContentsResponse
    {
        public string SAPTableTextContentsJSON { get; set; }
        public int NumberOfRowsReturned { get; set; }
        public int NumberOfColumnsReturned { get; set; }
    }

    public class SAPGetTreeNodesResponse
    {
        public int NumberOfNodesInTree { get; set; }
        public string SAPTreeNodesJSON { get; set; }
        public int NumberOfSelectedNodes { get; set; }
        public string CurrentlySelectedNode { get; set; }
        public string TreeType { get; set; }
        public string TreeSelectionMode { get; set; }
    }

    public class SAPGetTreeTextContentsResponse
    {
        public string SAPTreeTextContentsJSON { get; set; }
        public int NumberOfRowsReturned { get; set; }
        public int NumberOfColumnsReturned { get; set; }
    }

    public class SAPGetTreeColumnHeadersResponse
    {
        public string SAPTreeColumnHeadersJSON { get; set; }
        public int NumberOfColumnHeaders { get; set; }
    }

    public class SAPGetTreeItemPropertiesResponse
    {
        public string ItemType { get; set; }
        public string ItemTextValue { get; set; }
        public bool ItemEnabled { get; set; }
        public bool ItemHighlighted { get; set; }
        public bool ItemChecked { get; set; }
        public bool ItemVisible { get; set; }
        public int ItemLeftEdge { get; set; }
        public int ItemTopEdge { get; set; }
        public int ItemWidth { get; set; }
        public int ItemHeight { get; set; }
        public int ItemRightEdge { get; set; }
        public int ItemBottomEdge { get; set; }
        public string ItemTextColourHex { get; set; }
        public int ItemStyle { get; set; }
    }

    public class SAPGetShellToolbarElementsResponse
    {
        public int NumberOfToolbarButtons { get; set; }
        public string SAPShellToolbarElementsJSON { get; set; }
    }

    public class SAPGetSAPGridViewPropertiesResponse
    {
        public int NumberOfRows { get; set; }
        public int NumberOfVisibleRows { get; set; }
        public int FirstVisibleRowIndex { get; set; }
        public int CurrentCellRowIndex { get; set; }
        public int NumberOfColumns { get; set; }
        public string FirstVisibleColumnName { get; set; }
        public string CurrentCellColumnName { get; set; }
        public int NumberOfFrozenColumns { get; set; }
        public int NumberOfToolbarButtons { get; set; }
        public string SelectionMode { get; set; }
        public string GridViewTitle { get; set; }
    }

    public class SAPGetSAPGridViewCellContentsAtIndexResponse
    {
        public string CellTextContents { get; set; }
        public bool CellIsChangeable { get; set; }
        public string CellType { get; set; }
        public bool CellIsChecked { get; set; }
    }

    public class SAPGetSAPGridViewCellPropertiesAtIndexResponse
    {
        public string CellTextContents { get; set; }
        public bool CellIsChangeable { get; set; }
        public string CellType { get; set; }
        public bool CellIsChecked { get; set; }
        public bool CellIsVisible { get; set; }
        public int LeftEdge { get; set; }
        public int TopEdge { get; set; }
        public int RightEdge { get; set; }
        public int BottomEdge { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int ClickablePointX { get; set; }
        public int ClickablePointY { get; set; }
        public string CellState { get; set; }
        public int CellColour { get; set; }
        public string CellColourInfo { get; set; }
        public bool CellIsLink { get; set; }
    }

    public enum sAPGlobalLeftClickSAPGridViewCellAtIndexoffsetRelativeToInput
    {
        Center,
        Left,
        Right,
        Top,
        Bottom,
        [EnumMember(Value = "Top Left")]
        TopLeft,
        [EnumMember(Value = "Top Right")]
        TopRight,
        [EnumMember(Value = "Bottom Left")]
        BottomLeft,
        [EnumMember(Value = "Bottom Right")]
        BottomRight
    }

    public enum sAPGlobalRightClickSAPGridViewCellAtIndexoffsetRelativeToInput
    {
        Center,
        Left,
        Right,
        Top,
        Bottom,
        [EnumMember(Value = "Top Left")]
        TopLeft,
        [EnumMember(Value = "Top Right")]
        TopRight,
        [EnumMember(Value = "Bottom Left")]
        BottomLeft,
        [EnumMember(Value = "Bottom Right")]
        BottomRight
    }

    public enum sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexoffsetRelativeToInput
    {
        Center,
        Left,
        Right,
        Top,
        Bottom,
        [EnumMember(Value = "Top Left")]
        TopLeft,
        [EnumMember(Value = "Top Right")]
        TopRight,
        [EnumMember(Value = "Bottom Left")]
        BottomLeft,
        [EnumMember(Value = "Bottom Right")]
        BottomRight
    }

    public class SAPGetSAPGridViewColumnHeadersResponse
    {
        public string SAPGridViewColumnHeadersJSON { get; set; }
        public int NumberOfColumnHeaders { get; set; }
    }

    public class SAPModifySAPGridViewCellAtIndexResponse
    {
        public string ModifiedValue { get; set; }
    }

    public class SAPSetSAPGridViewFirstVisibleRowResponse
    {
        public int ActualFirstVisibleRowIndex { get; set; }
    }

    public class SAPSetSAPGridViewFirstVisibleColumnResponse
    {
        public string ActualFirstVisibleColumnName { get; set; }
    }

    public class SAPGetGridViewTextContentsResponse
    {
        public string SAPGridViewTextContentsJSON { get; set; }
        public int NumberOfRowsReturned { get; set; }
        public int NumberOfColumnsReturned { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectsapgui;

    public partial class WorkflowManagedActions
    {
        public IaconnectsapguiActions Iaconnectsapgui(string connectionId) => new IaconnectsapguiActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public IaconnectsapguiTriggers Iaconnectsapgui(string connectionId) => new IaconnectsapguiTriggers(connectionId);
    }
}
