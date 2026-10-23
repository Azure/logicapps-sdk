//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectsapgui
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IaconnectsapguiActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPEnableScripting(Expression<Func<string>> sAPEnableScriptingworkflow, Expression<Func<bool>> sAPEnableScriptingnotifyWhenScriptAttachesToGUI = null, Expression<Func<bool>> sAPEnableScriptingnotifyWhenScriptOpensConnection = null, Expression<Func<bool>> sAPEnableScriptingshowNativeWindowsDialogs = null)
        {
            var __workflow_sAPEnableScriptingworkflow = WorkflowExpression.Compile(sAPEnableScriptingworkflow, nameof(sAPEnableScriptingworkflow), required: true);
            var __workflow_sAPEnableScriptingnotifyWhenScriptAttachesToGUI = WorkflowExpression.Compile(sAPEnableScriptingnotifyWhenScriptAttachesToGUI, nameof(sAPEnableScriptingnotifyWhenScriptAttachesToGUI), required: false);
            var __workflow_sAPEnableScriptingnotifyWhenScriptOpensConnection = WorkflowExpression.Compile(sAPEnableScriptingnotifyWhenScriptOpensConnection, nameof(sAPEnableScriptingnotifyWhenScriptOpensConnection), required: false);
            var __workflow_sAPEnableScriptingshowNativeWindowsDialogs = WorkflowExpression.Compile(sAPEnableScriptingshowNativeWindowsDialogs, nameof(sAPEnableScriptingshowNativeWindowsDialogs), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPEnableScripting";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPEnableScripting = new JObject();
                var sAPEnableScriptingpropCount = 0;
                if (__workflow_sAPEnableScriptingnotifyWhenScriptAttachesToGUI != null)
                {
                    if (__workflow_sAPEnableScriptingnotifyWhenScriptAttachesToGUI != null)
                    {
                        sAPEnableScripting["NotifyWhenScriptAttachesToGUI"] = ExpressionConverter.ConvertO(__workflow_sAPEnableScriptingnotifyWhenScriptAttachesToGUI);
                        sAPEnableScriptingpropCount++;
                    }

                    sAPEnableScriptingpropCount++;
                }
                else
                {
                    sAPEnableScripting["NotifyWhenScriptAttachesToGUI"] = false;
                    sAPEnableScriptingpropCount++;
                }

                if (__workflow_sAPEnableScriptingnotifyWhenScriptOpensConnection != null)
                {
                    if (__workflow_sAPEnableScriptingnotifyWhenScriptOpensConnection != null)
                    {
                        sAPEnableScripting["NotifyWhenScriptOpensConnection"] = ExpressionConverter.ConvertO(__workflow_sAPEnableScriptingnotifyWhenScriptOpensConnection);
                        sAPEnableScriptingpropCount++;
                    }

                    sAPEnableScriptingpropCount++;
                }
                else
                {
                    sAPEnableScripting["NotifyWhenScriptOpensConnection"] = false;
                    sAPEnableScriptingpropCount++;
                }

                if (__workflow_sAPEnableScriptingshowNativeWindowsDialogs != null)
                {
                    if (__workflow_sAPEnableScriptingshowNativeWindowsDialogs != null)
                    {
                        sAPEnableScripting["ShowNativeWindowsDialogs"] = ExpressionConverter.ConvertO(__workflow_sAPEnableScriptingshowNativeWindowsDialogs);
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
                sAPEnableScripting["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPEnableScriptingworkflow);
                if (sAPEnableScriptingpropCount > 0)
                {
                    callPayload.Body = sAPEnableScripting;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPLaunchSAPGUIResponse, ApiConnectionActionConfiguration> SAPLaunchSAPGUI(Expression<Func<string>> sAPLaunchSAPGUIworkflow, Expression<Func<string>> sAPLaunchSAPGUIsAPLogonEXE = null, Expression<Func<string>> sAPLaunchSAPGUIsAPLogonArguments = null, Expression<Func<bool>> sAPLaunchSAPGUIenableSAPScripting = null, Expression<Func<bool>> sAPLaunchSAPGUInotifyWhenScriptAttachesToGUI = null, Expression<Func<bool>> sAPLaunchSAPGUInotifyWhenScriptOpensConnection = null, Expression<Func<bool>> sAPLaunchSAPGUIshowNativeWindowsDialogs = null, Expression<Func<bool>> sAPLaunchSAPGUIattachAfterLaunch = null, Expression<Func<double>> sAPLaunchSAPGUIsecondsToWait = null, Expression<Func<string>> sAPLaunchSAPGUIsAPProgId = null, Expression<Func<bool>> sAPLaunchSAPGUIdisableSystemMessages = null)
        {
            var __workflow_sAPLaunchSAPGUIworkflow = WorkflowExpression.Compile(sAPLaunchSAPGUIworkflow, nameof(sAPLaunchSAPGUIworkflow), required: true);
            var __workflow_sAPLaunchSAPGUIsAPLogonEXE = WorkflowExpression.Compile(sAPLaunchSAPGUIsAPLogonEXE, nameof(sAPLaunchSAPGUIsAPLogonEXE), required: false);
            var __workflow_sAPLaunchSAPGUIsAPLogonArguments = WorkflowExpression.Compile(sAPLaunchSAPGUIsAPLogonArguments, nameof(sAPLaunchSAPGUIsAPLogonArguments), required: false);
            var __workflow_sAPLaunchSAPGUIenableSAPScripting = WorkflowExpression.Compile(sAPLaunchSAPGUIenableSAPScripting, nameof(sAPLaunchSAPGUIenableSAPScripting), required: false);
            var __workflow_sAPLaunchSAPGUInotifyWhenScriptAttachesToGUI = WorkflowExpression.Compile(sAPLaunchSAPGUInotifyWhenScriptAttachesToGUI, nameof(sAPLaunchSAPGUInotifyWhenScriptAttachesToGUI), required: false);
            var __workflow_sAPLaunchSAPGUInotifyWhenScriptOpensConnection = WorkflowExpression.Compile(sAPLaunchSAPGUInotifyWhenScriptOpensConnection, nameof(sAPLaunchSAPGUInotifyWhenScriptOpensConnection), required: false);
            var __workflow_sAPLaunchSAPGUIshowNativeWindowsDialogs = WorkflowExpression.Compile(sAPLaunchSAPGUIshowNativeWindowsDialogs, nameof(sAPLaunchSAPGUIshowNativeWindowsDialogs), required: false);
            var __workflow_sAPLaunchSAPGUIattachAfterLaunch = WorkflowExpression.Compile(sAPLaunchSAPGUIattachAfterLaunch, nameof(sAPLaunchSAPGUIattachAfterLaunch), required: false);
            var __workflow_sAPLaunchSAPGUIsecondsToWait = WorkflowExpression.Compile(sAPLaunchSAPGUIsecondsToWait, nameof(sAPLaunchSAPGUIsecondsToWait), required: false);
            var __workflow_sAPLaunchSAPGUIsAPProgId = WorkflowExpression.Compile(sAPLaunchSAPGUIsAPProgId, nameof(sAPLaunchSAPGUIsAPProgId), required: false);
            var __workflow_sAPLaunchSAPGUIdisableSystemMessages = WorkflowExpression.Compile(sAPLaunchSAPGUIdisableSystemMessages, nameof(sAPLaunchSAPGUIdisableSystemMessages), required: false);
            return new DeferredBodyAction<SAPLaunchSAPGUIResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPLaunchSAPGUI";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPLaunchSAPGUI = new JObject();
                var sAPLaunchSAPGUIpropCount = 0;
                if (__workflow_sAPLaunchSAPGUIsAPLogonEXE != null)
                {
                    sAPLaunchSAPGUI["SAPLogonEXE"] = ExpressionConverter.ConvertO(__workflow_sAPLaunchSAPGUIsAPLogonEXE);
                    sAPLaunchSAPGUIpropCount++;
                }

                if (__workflow_sAPLaunchSAPGUIsAPLogonArguments != null)
                {
                    sAPLaunchSAPGUI["SAPLogonArguments"] = ExpressionConverter.ConvertO(__workflow_sAPLaunchSAPGUIsAPLogonArguments);
                    sAPLaunchSAPGUIpropCount++;
                }

                if (__workflow_sAPLaunchSAPGUIenableSAPScripting != null)
                {
                    if (__workflow_sAPLaunchSAPGUIenableSAPScripting != null)
                    {
                        sAPLaunchSAPGUI["EnableSAPScripting"] = ExpressionConverter.ConvertO(__workflow_sAPLaunchSAPGUIenableSAPScripting);
                        sAPLaunchSAPGUIpropCount++;
                    }

                    sAPLaunchSAPGUIpropCount++;
                }
                else
                {
                    sAPLaunchSAPGUI["EnableSAPScripting"] = true;
                    sAPLaunchSAPGUIpropCount++;
                }

                if (__workflow_sAPLaunchSAPGUInotifyWhenScriptAttachesToGUI != null)
                {
                    if (__workflow_sAPLaunchSAPGUInotifyWhenScriptAttachesToGUI != null)
                    {
                        sAPLaunchSAPGUI["NotifyWhenScriptAttachesToGUI"] = ExpressionConverter.ConvertO(__workflow_sAPLaunchSAPGUInotifyWhenScriptAttachesToGUI);
                        sAPLaunchSAPGUIpropCount++;
                    }

                    sAPLaunchSAPGUIpropCount++;
                }
                else
                {
                    sAPLaunchSAPGUI["NotifyWhenScriptAttachesToGUI"] = false;
                    sAPLaunchSAPGUIpropCount++;
                }

                if (__workflow_sAPLaunchSAPGUInotifyWhenScriptOpensConnection != null)
                {
                    if (__workflow_sAPLaunchSAPGUInotifyWhenScriptOpensConnection != null)
                    {
                        sAPLaunchSAPGUI["NotifyWhenScriptOpensConnection"] = ExpressionConverter.ConvertO(__workflow_sAPLaunchSAPGUInotifyWhenScriptOpensConnection);
                        sAPLaunchSAPGUIpropCount++;
                    }

                    sAPLaunchSAPGUIpropCount++;
                }
                else
                {
                    sAPLaunchSAPGUI["NotifyWhenScriptOpensConnection"] = false;
                    sAPLaunchSAPGUIpropCount++;
                }

                if (__workflow_sAPLaunchSAPGUIshowNativeWindowsDialogs != null)
                {
                    if (__workflow_sAPLaunchSAPGUIshowNativeWindowsDialogs != null)
                    {
                        sAPLaunchSAPGUI["ShowNativeWindowsDialogs"] = ExpressionConverter.ConvertO(__workflow_sAPLaunchSAPGUIshowNativeWindowsDialogs);
                        sAPLaunchSAPGUIpropCount++;
                    }

                    sAPLaunchSAPGUIpropCount++;
                }
                else
                {
                    sAPLaunchSAPGUI["ShowNativeWindowsDialogs"] = false;
                    sAPLaunchSAPGUIpropCount++;
                }

                if (__workflow_sAPLaunchSAPGUIattachAfterLaunch != null)
                {
                    if (__workflow_sAPLaunchSAPGUIattachAfterLaunch != null)
                    {
                        sAPLaunchSAPGUI["AttachAfterLaunch"] = ExpressionConverter.ConvertO(__workflow_sAPLaunchSAPGUIattachAfterLaunch);
                        sAPLaunchSAPGUIpropCount++;
                    }

                    sAPLaunchSAPGUIpropCount++;
                }
                else
                {
                    sAPLaunchSAPGUI["AttachAfterLaunch"] = true;
                    sAPLaunchSAPGUIpropCount++;
                }

                if (__workflow_sAPLaunchSAPGUIsecondsToWait != null)
                {
                    if (__workflow_sAPLaunchSAPGUIsecondsToWait != null)
                    {
                        sAPLaunchSAPGUI["SecondsToWait"] = ExpressionConverter.ConvertO(__workflow_sAPLaunchSAPGUIsecondsToWait);
                        sAPLaunchSAPGUIpropCount++;
                    }

                    sAPLaunchSAPGUIpropCount++;
                }
                else
                {
                    sAPLaunchSAPGUI["SecondsToWait"] = 15;
                    sAPLaunchSAPGUIpropCount++;
                }

                if (__workflow_sAPLaunchSAPGUIsAPProgId != null)
                {
                    if (__workflow_sAPLaunchSAPGUIsAPProgId != null)
                    {
                        sAPLaunchSAPGUI["SAPProgId"] = ExpressionConverter.ConvertO(__workflow_sAPLaunchSAPGUIsAPProgId);
                        sAPLaunchSAPGUIpropCount++;
                    }

                    sAPLaunchSAPGUIpropCount++;
                }
                else
                {
                    sAPLaunchSAPGUI["SAPProgId"] = "SAPGUI";
                    sAPLaunchSAPGUIpropCount++;
                }

                if (__workflow_sAPLaunchSAPGUIdisableSystemMessages != null)
                {
                    if (__workflow_sAPLaunchSAPGUIdisableSystemMessages != null)
                    {
                        sAPLaunchSAPGUI["DisableSystemMessages"] = ExpressionConverter.ConvertO(__workflow_sAPLaunchSAPGUIdisableSystemMessages);
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
                sAPLaunchSAPGUI["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPLaunchSAPGUIworkflow);
                if (sAPLaunchSAPGUIpropCount > 0)
                {
                    callPayload.Body = sAPLaunchSAPGUI;
                }

                return new ApiConnectionAction<SAPLaunchSAPGUIResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPAttachToSAPGUIResponse, ApiConnectionActionConfiguration> SAPAttachToSAPGUI(Expression<Func<string>> sAPAttachToSAPGUIworkflow, Expression<Func<string>> sAPAttachToSAPGUIsAPProgId = null, Expression<Func<bool>> sAPAttachToSAPGUIdisableSystemMessages = null)
        {
            var __workflow_sAPAttachToSAPGUIworkflow = WorkflowExpression.Compile(sAPAttachToSAPGUIworkflow, nameof(sAPAttachToSAPGUIworkflow), required: true);
            var __workflow_sAPAttachToSAPGUIsAPProgId = WorkflowExpression.Compile(sAPAttachToSAPGUIsAPProgId, nameof(sAPAttachToSAPGUIsAPProgId), required: false);
            var __workflow_sAPAttachToSAPGUIdisableSystemMessages = WorkflowExpression.Compile(sAPAttachToSAPGUIdisableSystemMessages, nameof(sAPAttachToSAPGUIdisableSystemMessages), required: false);
            return new DeferredBodyAction<SAPAttachToSAPGUIResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPAttachToSAPGUI";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPAttachToSAPGUI = new JObject();
                var sAPAttachToSAPGUIpropCount = 0;
                if (__workflow_sAPAttachToSAPGUIsAPProgId != null)
                {
                    if (__workflow_sAPAttachToSAPGUIsAPProgId != null)
                    {
                        sAPAttachToSAPGUI["SAPProgId"] = ExpressionConverter.ConvertO(__workflow_sAPAttachToSAPGUIsAPProgId);
                        sAPAttachToSAPGUIpropCount++;
                    }

                    sAPAttachToSAPGUIpropCount++;
                }
                else
                {
                    sAPAttachToSAPGUI["SAPProgId"] = "SAPGUI";
                    sAPAttachToSAPGUIpropCount++;
                }

                if (__workflow_sAPAttachToSAPGUIdisableSystemMessages != null)
                {
                    if (__workflow_sAPAttachToSAPGUIdisableSystemMessages != null)
                    {
                        sAPAttachToSAPGUI["DisableSystemMessages"] = ExpressionConverter.ConvertO(__workflow_sAPAttachToSAPGUIdisableSystemMessages);
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
                sAPAttachToSAPGUI["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPAttachToSAPGUIworkflow);
                if (sAPAttachToSAPGUIpropCount > 0)
                {
                    callPayload.Body = sAPAttachToSAPGUI;
                }

                return new ApiConnectionAction<SAPAttachToSAPGUIResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPDetachFromSAPGUI(Expression<Func<string>> sAPDetachFromSAPGUIworkflow)
        {
            var __workflow_sAPDetachFromSAPGUIworkflow = WorkflowExpression.Compile(sAPDetachFromSAPGUIworkflow, nameof(sAPDetachFromSAPGUIworkflow), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPDetachFromSAPGUI";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPDetachFromSAPGUI = new JObject();
                var sAPDetachFromSAPGUIpropCount = 0;
                sAPDetachFromSAPGUIpropCount++;
                sAPDetachFromSAPGUI["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPDetachFromSAPGUIworkflow);
                if (sAPDetachFromSAPGUIpropCount > 0)
                {
                    callPayload.Body = sAPDetachFromSAPGUI;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetSAPGUIStatusResponse, ApiConnectionActionConfiguration> SAPGetSAPGUIStatus(Expression<Func<string>> sAPGetSAPGUIStatusworkflow)
        {
            var __workflow_sAPGetSAPGUIStatusworkflow = WorkflowExpression.Compile(sAPGetSAPGUIStatusworkflow, nameof(sAPGetSAPGUIStatusworkflow), required: true);
            return new DeferredBodyAction<SAPGetSAPGUIStatusResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetSAPGUIStatus";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGetSAPGUIStatus = new JObject();
                var sAPGetSAPGUIStatuspropCount = 0;
                sAPGetSAPGUIStatuspropCount++;
                sAPGetSAPGUIStatus["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPGetSAPGUIStatusworkflow);
                if (sAPGetSAPGUIStatuspropCount > 0)
                {
                    callPayload.Body = sAPGetSAPGUIStatus;
                }

                return new ApiConnectionAction<SAPGetSAPGUIStatusResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetSAPSessionsResponse, ApiConnectionActionConfiguration> SAPGetSAPSessions(Expression<Func<string>> sAPGetSAPSessionsworkflow)
        {
            var __workflow_sAPGetSAPSessionsworkflow = WorkflowExpression.Compile(sAPGetSAPSessionsworkflow, nameof(sAPGetSAPSessionsworkflow), required: true);
            return new DeferredBodyAction<SAPGetSAPSessionsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetSAPSessions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGetSAPSessions = new JObject();
                var sAPGetSAPSessionspropCount = 0;
                sAPGetSAPSessionspropCount++;
                sAPGetSAPSessions["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPGetSAPSessionsworkflow);
                if (sAPGetSAPSessionspropCount > 0)
                {
                    callPayload.Body = sAPGetSAPSessions;
                }

                return new ApiConnectionAction<SAPGetSAPSessionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPAttachToSessionResponse, ApiConnectionActionConfiguration> SAPAttachToSession(Expression<Func<string>> sAPAttachToSessionworkflow, Expression<Func<string>> sAPAttachToSessionsearchConnectionName = null, Expression<Func<string>> sAPAttachToSessionsearchSessionName = null)
        {
            var __workflow_sAPAttachToSessionworkflow = WorkflowExpression.Compile(sAPAttachToSessionworkflow, nameof(sAPAttachToSessionworkflow), required: true);
            var __workflow_sAPAttachToSessionsearchConnectionName = WorkflowExpression.Compile(sAPAttachToSessionsearchConnectionName, nameof(sAPAttachToSessionsearchConnectionName), required: false);
            var __workflow_sAPAttachToSessionsearchSessionName = WorkflowExpression.Compile(sAPAttachToSessionsearchSessionName, nameof(sAPAttachToSessionsearchSessionName), required: false);
            return new DeferredBodyAction<SAPAttachToSessionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPAttachToSession";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPAttachToSession = new JObject();
                var sAPAttachToSessionpropCount = 0;
                if (__workflow_sAPAttachToSessionsearchConnectionName != null)
                {
                    sAPAttachToSession["SearchConnectionName"] = ExpressionConverter.ConvertO(__workflow_sAPAttachToSessionsearchConnectionName);
                    sAPAttachToSessionpropCount++;
                }

                if (__workflow_sAPAttachToSessionsearchSessionName != null)
                {
                    sAPAttachToSession["SearchSessionName"] = ExpressionConverter.ConvertO(__workflow_sAPAttachToSessionsearchSessionName);
                    sAPAttachToSessionpropCount++;
                }

                sAPAttachToSessionpropCount++;
                sAPAttachToSession["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPAttachToSessionworkflow);
                if (sAPAttachToSessionpropCount > 0)
                {
                    callPayload.Body = sAPAttachToSession;
                }

                return new ApiConnectionAction<SAPAttachToSessionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPCloseSession(Expression<Func<string>> sAPCloseSessionworkflow, Expression<Func<bool>> sAPCloseSessioncloseAttachedSession = null, Expression<Func<string>> sAPCloseSessionsearchConnectionName = null, Expression<Func<string>> sAPCloseSessionsearchSessionName = null)
        {
            var __workflow_sAPCloseSessionworkflow = WorkflowExpression.Compile(sAPCloseSessionworkflow, nameof(sAPCloseSessionworkflow), required: true);
            var __workflow_sAPCloseSessioncloseAttachedSession = WorkflowExpression.Compile(sAPCloseSessioncloseAttachedSession, nameof(sAPCloseSessioncloseAttachedSession), required: false);
            var __workflow_sAPCloseSessionsearchConnectionName = WorkflowExpression.Compile(sAPCloseSessionsearchConnectionName, nameof(sAPCloseSessionsearchConnectionName), required: false);
            var __workflow_sAPCloseSessionsearchSessionName = WorkflowExpression.Compile(sAPCloseSessionsearchSessionName, nameof(sAPCloseSessionsearchSessionName), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPCloseSession";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPCloseSession = new JObject();
                var sAPCloseSessionpropCount = 0;
                if (__workflow_sAPCloseSessioncloseAttachedSession != null)
                {
                    if (__workflow_sAPCloseSessioncloseAttachedSession != null)
                    {
                        sAPCloseSession["CloseAttachedSession"] = ExpressionConverter.ConvertO(__workflow_sAPCloseSessioncloseAttachedSession);
                        sAPCloseSessionpropCount++;
                    }

                    sAPCloseSessionpropCount++;
                }
                else
                {
                    sAPCloseSession["CloseAttachedSession"] = true;
                    sAPCloseSessionpropCount++;
                }

                if (__workflow_sAPCloseSessionsearchConnectionName != null)
                {
                    sAPCloseSession["SearchConnectionName"] = ExpressionConverter.ConvertO(__workflow_sAPCloseSessionsearchConnectionName);
                    sAPCloseSessionpropCount++;
                }

                if (__workflow_sAPCloseSessionsearchSessionName != null)
                {
                    sAPCloseSession["SearchSessionName"] = ExpressionConverter.ConvertO(__workflow_sAPCloseSessionsearchSessionName);
                    sAPCloseSessionpropCount++;
                }

                sAPCloseSessionpropCount++;
                sAPCloseSession["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPCloseSessionworkflow);
                if (sAPCloseSessionpropCount > 0)
                {
                    callPayload.Body = sAPCloseSession;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetAttachedSessionPropertiesResponse, ApiConnectionActionConfiguration> SAPGetAttachedSessionProperties(Expression<Func<string>> sAPGetAttachedSessionPropertiesworkflow)
        {
            var __workflow_sAPGetAttachedSessionPropertiesworkflow = WorkflowExpression.Compile(sAPGetAttachedSessionPropertiesworkflow, nameof(sAPGetAttachedSessionPropertiesworkflow), required: true);
            return new DeferredBodyAction<SAPGetAttachedSessionPropertiesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetAttachedSessionProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGetAttachedSessionProperties = new JObject();
                var sAPGetAttachedSessionPropertiespropCount = 0;
                sAPGetAttachedSessionPropertiespropCount++;
                sAPGetAttachedSessionProperties["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPGetAttachedSessionPropertiesworkflow);
                if (sAPGetAttachedSessionPropertiespropCount > 0)
                {
                    callPayload.Body = sAPGetAttachedSessionProperties;
                }

                return new ApiConnectionAction<SAPGetAttachedSessionPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPWaitForAttachedSessionNotBusyResponse, ApiConnectionActionConfiguration> SAPWaitForAttachedSessionNotBusy(Expression<Func<double>> sAPWaitForAttachedSessionNotBusysecondsToWait, Expression<Func<string>> sAPWaitForAttachedSessionNotBusyworkflow, Expression<Func<bool>> sAPWaitForAttachedSessionNotBusyraiseExceptionIfBusyAfterWait = null)
        {
            var __workflow_sAPWaitForAttachedSessionNotBusysecondsToWait = WorkflowExpression.Compile(sAPWaitForAttachedSessionNotBusysecondsToWait, nameof(sAPWaitForAttachedSessionNotBusysecondsToWait), required: true);
            var __workflow_sAPWaitForAttachedSessionNotBusyworkflow = WorkflowExpression.Compile(sAPWaitForAttachedSessionNotBusyworkflow, nameof(sAPWaitForAttachedSessionNotBusyworkflow), required: true);
            var __workflow_sAPWaitForAttachedSessionNotBusyraiseExceptionIfBusyAfterWait = WorkflowExpression.Compile(sAPWaitForAttachedSessionNotBusyraiseExceptionIfBusyAfterWait, nameof(sAPWaitForAttachedSessionNotBusyraiseExceptionIfBusyAfterWait), required: false);
            return new DeferredBodyAction<SAPWaitForAttachedSessionNotBusyResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPWaitForAttachedSessionNotBusy";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPWaitForAttachedSessionNotBusy = new JObject();
                var sAPWaitForAttachedSessionNotBusypropCount = 0;
                sAPWaitForAttachedSessionNotBusypropCount++;
                sAPWaitForAttachedSessionNotBusy["SecondsToWait"] = ExpressionConverter.ConvertO(__workflow_sAPWaitForAttachedSessionNotBusysecondsToWait);
                if (__workflow_sAPWaitForAttachedSessionNotBusyraiseExceptionIfBusyAfterWait != null)
                {
                    if (__workflow_sAPWaitForAttachedSessionNotBusyraiseExceptionIfBusyAfterWait != null)
                    {
                        sAPWaitForAttachedSessionNotBusy["RaiseExceptionIfBusyAfterWait"] = ExpressionConverter.ConvertO(__workflow_sAPWaitForAttachedSessionNotBusyraiseExceptionIfBusyAfterWait);
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
                sAPWaitForAttachedSessionNotBusy["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPWaitForAttachedSessionNotBusyworkflow);
                if (sAPWaitForAttachedSessionNotBusypropCount > 0)
                {
                    callPayload.Body = sAPWaitForAttachedSessionNotBusy;
                }

                return new ApiConnectionAction<SAPWaitForAttachedSessionNotBusyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPInputTextIntoSAPElement(Expression<Func<string>> sAPInputTextIntoSAPElementsearchSAPElementId, Expression<Func<string>> sAPInputTextIntoSAPElementworkflow, Expression<Func<string>> sAPInputTextIntoSAPElementtextToInput = null, Expression<Func<bool>> sAPInputTextIntoSAPElementreplaceExistingValue = null, Expression<Func<int>> sAPInputTextIntoSAPElementinsertPosition = null)
        {
            var __workflow_sAPInputTextIntoSAPElementsearchSAPElementId = WorkflowExpression.Compile(sAPInputTextIntoSAPElementsearchSAPElementId, nameof(sAPInputTextIntoSAPElementsearchSAPElementId), required: true);
            var __workflow_sAPInputTextIntoSAPElementworkflow = WorkflowExpression.Compile(sAPInputTextIntoSAPElementworkflow, nameof(sAPInputTextIntoSAPElementworkflow), required: true);
            var __workflow_sAPInputTextIntoSAPElementtextToInput = WorkflowExpression.Compile(sAPInputTextIntoSAPElementtextToInput, nameof(sAPInputTextIntoSAPElementtextToInput), required: false);
            var __workflow_sAPInputTextIntoSAPElementreplaceExistingValue = WorkflowExpression.Compile(sAPInputTextIntoSAPElementreplaceExistingValue, nameof(sAPInputTextIntoSAPElementreplaceExistingValue), required: false);
            var __workflow_sAPInputTextIntoSAPElementinsertPosition = WorkflowExpression.Compile(sAPInputTextIntoSAPElementinsertPosition, nameof(sAPInputTextIntoSAPElementinsertPosition), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPInputTextIntoSAPElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPInputTextIntoSAPElement = new JObject();
                var sAPInputTextIntoSAPElementpropCount = 0;
                sAPInputTextIntoSAPElementpropCount++;
                sAPInputTextIntoSAPElement["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPInputTextIntoSAPElementsearchSAPElementId);
                if (__workflow_sAPInputTextIntoSAPElementtextToInput != null)
                {
                    sAPInputTextIntoSAPElement["TextToInput"] = ExpressionConverter.ConvertO(__workflow_sAPInputTextIntoSAPElementtextToInput);
                    sAPInputTextIntoSAPElementpropCount++;
                }

                if (__workflow_sAPInputTextIntoSAPElementreplaceExistingValue != null)
                {
                    if (__workflow_sAPInputTextIntoSAPElementreplaceExistingValue != null)
                    {
                        sAPInputTextIntoSAPElement["ReplaceExistingValue"] = ExpressionConverter.ConvertO(__workflow_sAPInputTextIntoSAPElementreplaceExistingValue);
                        sAPInputTextIntoSAPElementpropCount++;
                    }

                    sAPInputTextIntoSAPElementpropCount++;
                }
                else
                {
                    sAPInputTextIntoSAPElement["ReplaceExistingValue"] = true;
                    sAPInputTextIntoSAPElementpropCount++;
                }

                if (__workflow_sAPInputTextIntoSAPElementinsertPosition != null)
                {
                    if (__workflow_sAPInputTextIntoSAPElementinsertPosition != null)
                    {
                        sAPInputTextIntoSAPElement["InsertPosition"] = ExpressionConverter.ConvertO(__workflow_sAPInputTextIntoSAPElementinsertPosition);
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
                sAPInputTextIntoSAPElement["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPInputTextIntoSAPElementworkflow);
                if (sAPInputTextIntoSAPElementpropCount > 0)
                {
                    callPayload.Body = sAPInputTextIntoSAPElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPInputPasswordIntoSAPElement(Expression<Func<string>> sAPInputPasswordIntoSAPElementsearchSAPElementId, Expression<Func<string>> sAPInputPasswordIntoSAPElementpasswordToInput, Expression<Func<string>> sAPInputPasswordIntoSAPElementworkflow)
        {
            var __workflow_sAPInputPasswordIntoSAPElementsearchSAPElementId = WorkflowExpression.Compile(sAPInputPasswordIntoSAPElementsearchSAPElementId, nameof(sAPInputPasswordIntoSAPElementsearchSAPElementId), required: true);
            var __workflow_sAPInputPasswordIntoSAPElementpasswordToInput = WorkflowExpression.Compile(sAPInputPasswordIntoSAPElementpasswordToInput, nameof(sAPInputPasswordIntoSAPElementpasswordToInput), required: true);
            var __workflow_sAPInputPasswordIntoSAPElementworkflow = WorkflowExpression.Compile(sAPInputPasswordIntoSAPElementworkflow, nameof(sAPInputPasswordIntoSAPElementworkflow), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPInputPasswordIntoSAPElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPInputPasswordIntoSAPElement = new JObject();
                var sAPInputPasswordIntoSAPElementpropCount = 0;
                sAPInputPasswordIntoSAPElementpropCount++;
                sAPInputPasswordIntoSAPElement["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPInputPasswordIntoSAPElementsearchSAPElementId);
                sAPInputPasswordIntoSAPElementpropCount++;
                sAPInputPasswordIntoSAPElement["PasswordToInput"] = ExpressionConverter.ConvertO(__workflow_sAPInputPasswordIntoSAPElementpasswordToInput);
                sAPInputPasswordIntoSAPElementpropCount++;
                sAPInputPasswordIntoSAPElement["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPInputPasswordIntoSAPElementworkflow);
                if (sAPInputPasswordIntoSAPElementpropCount > 0)
                {
                    callPayload.Body = sAPInputPasswordIntoSAPElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetElementPropertiesResponse, ApiConnectionActionConfiguration> SAPGetElementProperties(Expression<Func<string>> sAPGetElementPropertiessearchSAPElementId, Expression<Func<string>> sAPGetElementPropertiesworkflow)
        {
            var __workflow_sAPGetElementPropertiessearchSAPElementId = WorkflowExpression.Compile(sAPGetElementPropertiessearchSAPElementId, nameof(sAPGetElementPropertiessearchSAPElementId), required: true);
            var __workflow_sAPGetElementPropertiesworkflow = WorkflowExpression.Compile(sAPGetElementPropertiesworkflow, nameof(sAPGetElementPropertiesworkflow), required: true);
            return new DeferredBodyAction<SAPGetElementPropertiesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetElementProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGetElementProperties = new JObject();
                var sAPGetElementPropertiespropCount = 0;
                sAPGetElementPropertiespropCount++;
                sAPGetElementProperties["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPGetElementPropertiessearchSAPElementId);
                sAPGetElementPropertiespropCount++;
                sAPGetElementProperties["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPGetElementPropertiesworkflow);
                if (sAPGetElementPropertiespropCount > 0)
                {
                    callPayload.Body = sAPGetElementProperties;
                }

                return new ApiConnectionAction<SAPGetElementPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPWaitForElementIdResponse, ApiConnectionActionConfiguration> SAPWaitForElementId(Expression<Func<string>> sAPWaitForElementIdsearchSAPElementId, Expression<Func<string>> sAPWaitForElementIdworkflow, Expression<Func<double>> sAPWaitForElementIdsecondsToWait = null, Expression<Func<bool>> sAPWaitForElementIdraiseExceptionIfElementNotFound = null)
        {
            var __workflow_sAPWaitForElementIdsearchSAPElementId = WorkflowExpression.Compile(sAPWaitForElementIdsearchSAPElementId, nameof(sAPWaitForElementIdsearchSAPElementId), required: true);
            var __workflow_sAPWaitForElementIdworkflow = WorkflowExpression.Compile(sAPWaitForElementIdworkflow, nameof(sAPWaitForElementIdworkflow), required: true);
            var __workflow_sAPWaitForElementIdsecondsToWait = WorkflowExpression.Compile(sAPWaitForElementIdsecondsToWait, nameof(sAPWaitForElementIdsecondsToWait), required: false);
            var __workflow_sAPWaitForElementIdraiseExceptionIfElementNotFound = WorkflowExpression.Compile(sAPWaitForElementIdraiseExceptionIfElementNotFound, nameof(sAPWaitForElementIdraiseExceptionIfElementNotFound), required: false);
            return new DeferredBodyAction<SAPWaitForElementIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPWaitForElementId";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPWaitForElementId = new JObject();
                var sAPWaitForElementIdpropCount = 0;
                sAPWaitForElementIdpropCount++;
                sAPWaitForElementId["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPWaitForElementIdsearchSAPElementId);
                if (__workflow_sAPWaitForElementIdsecondsToWait != null)
                {
                    if (__workflow_sAPWaitForElementIdsecondsToWait != null)
                    {
                        sAPWaitForElementId["SecondsToWait"] = ExpressionConverter.ConvertO(__workflow_sAPWaitForElementIdsecondsToWait);
                        sAPWaitForElementIdpropCount++;
                    }

                    sAPWaitForElementIdpropCount++;
                }
                else
                {
                    sAPWaitForElementId["SecondsToWait"] = 15;
                    sAPWaitForElementIdpropCount++;
                }

                if (__workflow_sAPWaitForElementIdraiseExceptionIfElementNotFound != null)
                {
                    if (__workflow_sAPWaitForElementIdraiseExceptionIfElementNotFound != null)
                    {
                        sAPWaitForElementId["RaiseExceptionIfElementNotFound"] = ExpressionConverter.ConvertO(__workflow_sAPWaitForElementIdraiseExceptionIfElementNotFound);
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
                sAPWaitForElementId["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPWaitForElementIdworkflow);
                if (sAPWaitForElementIdpropCount > 0)
                {
                    callPayload.Body = sAPWaitForElementId;
                }

                return new ApiConnectionAction<SAPWaitForElementIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPWaitForWindowResponse, ApiConnectionActionConfiguration> SAPWaitForWindow(Expression<Func<string>> sAPWaitForWindowsearchSAPWindowTitle, Expression<Func<string>> sAPWaitForWindowworkflow, Expression<Func<bool>> sAPWaitForWindowsearchIsRegularExpression = null, Expression<Func<bool>> sAPWaitForWindowsearchIsCaseSensitive = null, Expression<Func<double>> sAPWaitForWindowsecondsToWait = null, Expression<Func<bool>> sAPWaitForWindowraiseExceptionIfElementNotFound = null)
        {
            var __workflow_sAPWaitForWindowsearchSAPWindowTitle = WorkflowExpression.Compile(sAPWaitForWindowsearchSAPWindowTitle, nameof(sAPWaitForWindowsearchSAPWindowTitle), required: true);
            var __workflow_sAPWaitForWindowworkflow = WorkflowExpression.Compile(sAPWaitForWindowworkflow, nameof(sAPWaitForWindowworkflow), required: true);
            var __workflow_sAPWaitForWindowsearchIsRegularExpression = WorkflowExpression.Compile(sAPWaitForWindowsearchIsRegularExpression, nameof(sAPWaitForWindowsearchIsRegularExpression), required: false);
            var __workflow_sAPWaitForWindowsearchIsCaseSensitive = WorkflowExpression.Compile(sAPWaitForWindowsearchIsCaseSensitive, nameof(sAPWaitForWindowsearchIsCaseSensitive), required: false);
            var __workflow_sAPWaitForWindowsecondsToWait = WorkflowExpression.Compile(sAPWaitForWindowsecondsToWait, nameof(sAPWaitForWindowsecondsToWait), required: false);
            var __workflow_sAPWaitForWindowraiseExceptionIfElementNotFound = WorkflowExpression.Compile(sAPWaitForWindowraiseExceptionIfElementNotFound, nameof(sAPWaitForWindowraiseExceptionIfElementNotFound), required: false);
            return new DeferredBodyAction<SAPWaitForWindowResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPWaitForWindow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPWaitForWindow = new JObject();
                var sAPWaitForWindowpropCount = 0;
                sAPWaitForWindowpropCount++;
                sAPWaitForWindow["SearchSAPWindowTitle"] = ExpressionConverter.ConvertO(__workflow_sAPWaitForWindowsearchSAPWindowTitle);
                if (__workflow_sAPWaitForWindowsearchIsRegularExpression != null)
                {
                    if (__workflow_sAPWaitForWindowsearchIsRegularExpression != null)
                    {
                        sAPWaitForWindow["SearchIsRegularExpression"] = ExpressionConverter.ConvertO(__workflow_sAPWaitForWindowsearchIsRegularExpression);
                        sAPWaitForWindowpropCount++;
                    }

                    sAPWaitForWindowpropCount++;
                }
                else
                {
                    sAPWaitForWindow["SearchIsRegularExpression"] = false;
                    sAPWaitForWindowpropCount++;
                }

                if (__workflow_sAPWaitForWindowsearchIsCaseSensitive != null)
                {
                    if (__workflow_sAPWaitForWindowsearchIsCaseSensitive != null)
                    {
                        sAPWaitForWindow["SearchIsCaseSensitive"] = ExpressionConverter.ConvertO(__workflow_sAPWaitForWindowsearchIsCaseSensitive);
                        sAPWaitForWindowpropCount++;
                    }

                    sAPWaitForWindowpropCount++;
                }
                else
                {
                    sAPWaitForWindow["SearchIsCaseSensitive"] = false;
                    sAPWaitForWindowpropCount++;
                }

                if (__workflow_sAPWaitForWindowsecondsToWait != null)
                {
                    if (__workflow_sAPWaitForWindowsecondsToWait != null)
                    {
                        sAPWaitForWindow["SecondsToWait"] = ExpressionConverter.ConvertO(__workflow_sAPWaitForWindowsecondsToWait);
                        sAPWaitForWindowpropCount++;
                    }

                    sAPWaitForWindowpropCount++;
                }
                else
                {
                    sAPWaitForWindow["SecondsToWait"] = 15;
                    sAPWaitForWindowpropCount++;
                }

                if (__workflow_sAPWaitForWindowraiseExceptionIfElementNotFound != null)
                {
                    if (__workflow_sAPWaitForWindowraiseExceptionIfElementNotFound != null)
                    {
                        sAPWaitForWindow["RaiseExceptionIfElementNotFound"] = ExpressionConverter.ConvertO(__workflow_sAPWaitForWindowraiseExceptionIfElementNotFound);
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
                sAPWaitForWindow["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPWaitForWindowworkflow);
                if (sAPWaitForWindowpropCount > 0)
                {
                    callPayload.Body = sAPWaitForWindow;
                }

                return new ApiConnectionAction<SAPWaitForWindowResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetElementTextValueResponse, ApiConnectionActionConfiguration> SAPGetElementTextValue(Expression<Func<string>> sAPGetElementTextValuesearchSAPElementId, Expression<Func<string>> sAPGetElementTextValueworkflow)
        {
            var __workflow_sAPGetElementTextValuesearchSAPElementId = WorkflowExpression.Compile(sAPGetElementTextValuesearchSAPElementId, nameof(sAPGetElementTextValuesearchSAPElementId), required: true);
            var __workflow_sAPGetElementTextValueworkflow = WorkflowExpression.Compile(sAPGetElementTextValueworkflow, nameof(sAPGetElementTextValueworkflow), required: true);
            return new DeferredBodyAction<SAPGetElementTextValueResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetElementTextValue";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGetElementTextValue = new JObject();
                var sAPGetElementTextValuepropCount = 0;
                sAPGetElementTextValuepropCount++;
                sAPGetElementTextValue["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPGetElementTextValuesearchSAPElementId);
                sAPGetElementTextValuepropCount++;
                sAPGetElementTextValue["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPGetElementTextValueworkflow);
                if (sAPGetElementTextValuepropCount > 0)
                {
                    callPayload.Body = sAPGetElementTextValue;
                }

                return new ApiConnectionAction<SAPGetElementTextValueResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPPressSAPElement(Expression<Func<string>> sAPPressSAPElementsearchSAPElementId, Expression<Func<string>> sAPPressSAPElementworkflow)
        {
            var __workflow_sAPPressSAPElementsearchSAPElementId = WorkflowExpression.Compile(sAPPressSAPElementsearchSAPElementId, nameof(sAPPressSAPElementsearchSAPElementId), required: true);
            var __workflow_sAPPressSAPElementworkflow = WorkflowExpression.Compile(sAPPressSAPElementworkflow, nameof(sAPPressSAPElementworkflow), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPPressSAPElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPPressSAPElement = new JObject();
                var sAPPressSAPElementpropCount = 0;
                sAPPressSAPElementpropCount++;
                sAPPressSAPElement["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPPressSAPElementsearchSAPElementId);
                sAPPressSAPElementpropCount++;
                sAPPressSAPElement["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPPressSAPElementworkflow);
                if (sAPPressSAPElementpropCount > 0)
                {
                    callPayload.Body = sAPPressSAPElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPSelectSAPElement(Expression<Func<string>> sAPSelectSAPElementsearchSAPElementId, Expression<Func<string>> sAPSelectSAPElementworkflow)
        {
            var __workflow_sAPSelectSAPElementsearchSAPElementId = WorkflowExpression.Compile(sAPSelectSAPElementsearchSAPElementId, nameof(sAPSelectSAPElementsearchSAPElementId), required: true);
            var __workflow_sAPSelectSAPElementworkflow = WorkflowExpression.Compile(sAPSelectSAPElementworkflow, nameof(sAPSelectSAPElementworkflow), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSelectSAPElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPSelectSAPElement = new JObject();
                var sAPSelectSAPElementpropCount = 0;
                sAPSelectSAPElementpropCount++;
                sAPSelectSAPElement["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPSelectSAPElementsearchSAPElementId);
                sAPSelectSAPElementpropCount++;
                sAPSelectSAPElement["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPSelectSAPElementworkflow);
                if (sAPSelectSAPElementpropCount > 0)
                {
                    callPayload.Body = sAPSelectSAPElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPFocusSAPElement(Expression<Func<string>> sAPFocusSAPElementsearchSAPElementId, Expression<Func<string>> sAPFocusSAPElementworkflow)
        {
            var __workflow_sAPFocusSAPElementsearchSAPElementId = WorkflowExpression.Compile(sAPFocusSAPElementsearchSAPElementId, nameof(sAPFocusSAPElementsearchSAPElementId), required: true);
            var __workflow_sAPFocusSAPElementworkflow = WorkflowExpression.Compile(sAPFocusSAPElementworkflow, nameof(sAPFocusSAPElementworkflow), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPFocusSAPElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPFocusSAPElement = new JObject();
                var sAPFocusSAPElementpropCount = 0;
                sAPFocusSAPElementpropCount++;
                sAPFocusSAPElement["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPFocusSAPElementsearchSAPElementId);
                sAPFocusSAPElementpropCount++;
                sAPFocusSAPElement["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPFocusSAPElementworkflow);
                if (sAPFocusSAPElementpropCount > 0)
                {
                    callPayload.Body = sAPFocusSAPElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPCheckSAPElement(Expression<Func<string>> sAPCheckSAPElementsearchSAPElementId, Expression<Func<string>> sAPCheckSAPElementworkflow, Expression<Func<bool>> sAPCheckSAPElementcheckElement = null)
        {
            var __workflow_sAPCheckSAPElementsearchSAPElementId = WorkflowExpression.Compile(sAPCheckSAPElementsearchSAPElementId, nameof(sAPCheckSAPElementsearchSAPElementId), required: true);
            var __workflow_sAPCheckSAPElementworkflow = WorkflowExpression.Compile(sAPCheckSAPElementworkflow, nameof(sAPCheckSAPElementworkflow), required: true);
            var __workflow_sAPCheckSAPElementcheckElement = WorkflowExpression.Compile(sAPCheckSAPElementcheckElement, nameof(sAPCheckSAPElementcheckElement), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPCheckSAPElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPCheckSAPElement = new JObject();
                var sAPCheckSAPElementpropCount = 0;
                sAPCheckSAPElementpropCount++;
                sAPCheckSAPElement["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPCheckSAPElementsearchSAPElementId);
                if (__workflow_sAPCheckSAPElementcheckElement != null)
                {
                    if (__workflow_sAPCheckSAPElementcheckElement != null)
                    {
                        sAPCheckSAPElement["CheckElement"] = ExpressionConverter.ConvertO(__workflow_sAPCheckSAPElementcheckElement);
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
                sAPCheckSAPElement["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPCheckSAPElementworkflow);
                if (sAPCheckSAPElementpropCount > 0)
                {
                    callPayload.Body = sAPCheckSAPElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPVisualiseSAPElement(Expression<Func<string>> sAPVisualiseSAPElementsearchSAPElementId, Expression<Func<string>> sAPVisualiseSAPElementworkflow, Expression<Func<bool>> sAPVisualiseSAPElementvisualiseOn = null)
        {
            var __workflow_sAPVisualiseSAPElementsearchSAPElementId = WorkflowExpression.Compile(sAPVisualiseSAPElementsearchSAPElementId, nameof(sAPVisualiseSAPElementsearchSAPElementId), required: true);
            var __workflow_sAPVisualiseSAPElementworkflow = WorkflowExpression.Compile(sAPVisualiseSAPElementworkflow, nameof(sAPVisualiseSAPElementworkflow), required: true);
            var __workflow_sAPVisualiseSAPElementvisualiseOn = WorkflowExpression.Compile(sAPVisualiseSAPElementvisualiseOn, nameof(sAPVisualiseSAPElementvisualiseOn), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPVisualiseSAPElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPVisualiseSAPElement = new JObject();
                var sAPVisualiseSAPElementpropCount = 0;
                sAPVisualiseSAPElementpropCount++;
                sAPVisualiseSAPElement["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPVisualiseSAPElementsearchSAPElementId);
                if (__workflow_sAPVisualiseSAPElementvisualiseOn != null)
                {
                    if (__workflow_sAPVisualiseSAPElementvisualiseOn != null)
                    {
                        sAPVisualiseSAPElement["VisualiseOn"] = ExpressionConverter.ConvertO(__workflow_sAPVisualiseSAPElementvisualiseOn);
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
                sAPVisualiseSAPElement["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPVisualiseSAPElementworkflow);
                if (sAPVisualiseSAPElementpropCount > 0)
                {
                    callPayload.Body = sAPVisualiseSAPElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPDrawRectangleAroundSAPElement(Expression<Func<string>> sAPDrawRectangleAroundSAPElementsearchSAPElementId, Expression<Func<string>> sAPDrawRectangleAroundSAPElementworkflow, Expression<Func<string>> sAPDrawRectangleAroundSAPElementpenColour = null, Expression<Func<int>> sAPDrawRectangleAroundSAPElementpenThicknessPixels = null)
        {
            var __workflow_sAPDrawRectangleAroundSAPElementsearchSAPElementId = WorkflowExpression.Compile(sAPDrawRectangleAroundSAPElementsearchSAPElementId, nameof(sAPDrawRectangleAroundSAPElementsearchSAPElementId), required: true);
            var __workflow_sAPDrawRectangleAroundSAPElementworkflow = WorkflowExpression.Compile(sAPDrawRectangleAroundSAPElementworkflow, nameof(sAPDrawRectangleAroundSAPElementworkflow), required: true);
            var __workflow_sAPDrawRectangleAroundSAPElementpenColour = WorkflowExpression.Compile(sAPDrawRectangleAroundSAPElementpenColour, nameof(sAPDrawRectangleAroundSAPElementpenColour), required: false);
            var __workflow_sAPDrawRectangleAroundSAPElementpenThicknessPixels = WorkflowExpression.Compile(sAPDrawRectangleAroundSAPElementpenThicknessPixels, nameof(sAPDrawRectangleAroundSAPElementpenThicknessPixels), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPDrawRectangleAroundSAPElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPDrawRectangleAroundSAPElement = new JObject();
                var sAPDrawRectangleAroundSAPElementpropCount = 0;
                sAPDrawRectangleAroundSAPElementpropCount++;
                sAPDrawRectangleAroundSAPElement["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPDrawRectangleAroundSAPElementsearchSAPElementId);
                if (__workflow_sAPDrawRectangleAroundSAPElementpenColour != null)
                {
                    if (__workflow_sAPDrawRectangleAroundSAPElementpenColour != null)
                    {
                        sAPDrawRectangleAroundSAPElement["PenColour"] = ExpressionConverter.ConvertO(__workflow_sAPDrawRectangleAroundSAPElementpenColour);
                        sAPDrawRectangleAroundSAPElementpropCount++;
                    }

                    sAPDrawRectangleAroundSAPElementpropCount++;
                }
                else
                {
                    sAPDrawRectangleAroundSAPElement["PenColour"] = "#009FDE";
                    sAPDrawRectangleAroundSAPElementpropCount++;
                }

                if (__workflow_sAPDrawRectangleAroundSAPElementpenThicknessPixels != null)
                {
                    if (__workflow_sAPDrawRectangleAroundSAPElementpenThicknessPixels != null)
                    {
                        sAPDrawRectangleAroundSAPElement["PenThicknessPixels"] = ExpressionConverter.ConvertO(__workflow_sAPDrawRectangleAroundSAPElementpenThicknessPixels);
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
                sAPDrawRectangleAroundSAPElement["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPDrawRectangleAroundSAPElementworkflow);
                if (sAPDrawRectangleAroundSAPElementpropCount > 0)
                {
                    callPayload.Body = sAPDrawRectangleAroundSAPElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPSendCommand(Expression<Func<string>> sAPSendCommandsAPCommand, Expression<Func<string>> sAPSendCommandworkflow)
        {
            var __workflow_sAPSendCommandsAPCommand = WorkflowExpression.Compile(sAPSendCommandsAPCommand, nameof(sAPSendCommandsAPCommand), required: true);
            var __workflow_sAPSendCommandworkflow = WorkflowExpression.Compile(sAPSendCommandworkflow, nameof(sAPSendCommandworkflow), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSendCommand";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPSendCommand = new JObject();
                var sAPSendCommandpropCount = 0;
                sAPSendCommandpropCount++;
                sAPSendCommand["SAPCommand"] = ExpressionConverter.ConvertO(__workflow_sAPSendCommandsAPCommand);
                sAPSendCommandpropCount++;
                sAPSendCommand["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPSendCommandworkflow);
                if (sAPSendCommandpropCount > 0)
                {
                    callPayload.Body = sAPSendCommand;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPEnterTCode(Expression<Func<string>> sAPEnterTCodesAPTCode, Expression<Func<string>> sAPEnterTCodeworkflow)
        {
            var __workflow_sAPEnterTCodesAPTCode = WorkflowExpression.Compile(sAPEnterTCodesAPTCode, nameof(sAPEnterTCodesAPTCode), required: true);
            var __workflow_sAPEnterTCodeworkflow = WorkflowExpression.Compile(sAPEnterTCodeworkflow, nameof(sAPEnterTCodeworkflow), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPEnterTCode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPEnterTCode = new JObject();
                var sAPEnterTCodepropCount = 0;
                sAPEnterTCodepropCount++;
                sAPEnterTCode["SAPTCode"] = ExpressionConverter.ConvertO(__workflow_sAPEnterTCodesAPTCode);
                sAPEnterTCodepropCount++;
                sAPEnterTCode["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPEnterTCodeworkflow);
                if (sAPEnterTCodepropCount > 0)
                {
                    callPayload.Body = sAPEnterTCode;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPSendVKey(Expression<Func<string>> sAPSendVKeysearchSAPElementId, Expression<Func<int>> sAPSendVKeysAPVKey, Expression<Func<string>> sAPSendVKeyworkflow, Expression<Func<bool>> sAPSendVKeydetectParentWindowElement = null)
        {
            var __workflow_sAPSendVKeysearchSAPElementId = WorkflowExpression.Compile(sAPSendVKeysearchSAPElementId, nameof(sAPSendVKeysearchSAPElementId), required: true);
            var __workflow_sAPSendVKeysAPVKey = WorkflowExpression.Compile(sAPSendVKeysAPVKey, nameof(sAPSendVKeysAPVKey), required: true);
            var __workflow_sAPSendVKeyworkflow = WorkflowExpression.Compile(sAPSendVKeyworkflow, nameof(sAPSendVKeyworkflow), required: true);
            var __workflow_sAPSendVKeydetectParentWindowElement = WorkflowExpression.Compile(sAPSendVKeydetectParentWindowElement, nameof(sAPSendVKeydetectParentWindowElement), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSendVKey";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPSendVKey = new JObject();
                var sAPSendVKeypropCount = 0;
                sAPSendVKeypropCount++;
                sAPSendVKey["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPSendVKeysearchSAPElementId);
                sAPSendVKeypropCount++;
                sAPSendVKey["SAPVKey"] = ExpressionConverter.ConvertO(__workflow_sAPSendVKeysAPVKey);
                if (__workflow_sAPSendVKeydetectParentWindowElement != null)
                {
                    if (__workflow_sAPSendVKeydetectParentWindowElement != null)
                    {
                        sAPSendVKey["DetectParentWindowElement"] = ExpressionConverter.ConvertO(__workflow_sAPSendVKeydetectParentWindowElement);
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
                sAPSendVKey["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPSendVKeyworkflow);
                if (sAPSendVKeypropCount > 0)
                {
                    callPayload.Body = sAPSendVKey;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPSendEnterVKey(Expression<Func<string>> sAPSendEnterVKeysearchSAPElementId, Expression<Func<string>> sAPSendEnterVKeyworkflow, Expression<Func<bool>> sAPSendEnterVKeydetectParentWindowElement = null)
        {
            var __workflow_sAPSendEnterVKeysearchSAPElementId = WorkflowExpression.Compile(sAPSendEnterVKeysearchSAPElementId, nameof(sAPSendEnterVKeysearchSAPElementId), required: true);
            var __workflow_sAPSendEnterVKeyworkflow = WorkflowExpression.Compile(sAPSendEnterVKeyworkflow, nameof(sAPSendEnterVKeyworkflow), required: true);
            var __workflow_sAPSendEnterVKeydetectParentWindowElement = WorkflowExpression.Compile(sAPSendEnterVKeydetectParentWindowElement, nameof(sAPSendEnterVKeydetectParentWindowElement), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSendEnterVKey";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPSendEnterVKey = new JObject();
                var sAPSendEnterVKeypropCount = 0;
                sAPSendEnterVKeypropCount++;
                sAPSendEnterVKey["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPSendEnterVKeysearchSAPElementId);
                if (__workflow_sAPSendEnterVKeydetectParentWindowElement != null)
                {
                    if (__workflow_sAPSendEnterVKeydetectParentWindowElement != null)
                    {
                        sAPSendEnterVKey["DetectParentWindowElement"] = ExpressionConverter.ConvertO(__workflow_sAPSendEnterVKeydetectParentWindowElement);
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
                sAPSendEnterVKey["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPSendEnterVKeyworkflow);
                if (sAPSendEnterVKeypropCount > 0)
                {
                    callPayload.Body = sAPSendEnterVKey;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPWindowRestore(Expression<Func<string>> sAPWindowRestoresearchSAPElementId, Expression<Func<string>> sAPWindowRestoreworkflow, Expression<Func<bool>> sAPWindowRestoredetectParentWindowElement = null)
        {
            var __workflow_sAPWindowRestoresearchSAPElementId = WorkflowExpression.Compile(sAPWindowRestoresearchSAPElementId, nameof(sAPWindowRestoresearchSAPElementId), required: true);
            var __workflow_sAPWindowRestoreworkflow = WorkflowExpression.Compile(sAPWindowRestoreworkflow, nameof(sAPWindowRestoreworkflow), required: true);
            var __workflow_sAPWindowRestoredetectParentWindowElement = WorkflowExpression.Compile(sAPWindowRestoredetectParentWindowElement, nameof(sAPWindowRestoredetectParentWindowElement), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPWindowRestore";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPWindowRestore = new JObject();
                var sAPWindowRestorepropCount = 0;
                sAPWindowRestorepropCount++;
                sAPWindowRestore["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPWindowRestoresearchSAPElementId);
                if (__workflow_sAPWindowRestoredetectParentWindowElement != null)
                {
                    if (__workflow_sAPWindowRestoredetectParentWindowElement != null)
                    {
                        sAPWindowRestore["DetectParentWindowElement"] = ExpressionConverter.ConvertO(__workflow_sAPWindowRestoredetectParentWindowElement);
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
                sAPWindowRestore["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPWindowRestoreworkflow);
                if (sAPWindowRestorepropCount > 0)
                {
                    callPayload.Body = sAPWindowRestore;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPWindowMaximise(Expression<Func<string>> sAPWindowMaximisesearchSAPElementId, Expression<Func<string>> sAPWindowMaximiseworkflow, Expression<Func<bool>> sAPWindowMaximisedetectParentWindowElement = null)
        {
            var __workflow_sAPWindowMaximisesearchSAPElementId = WorkflowExpression.Compile(sAPWindowMaximisesearchSAPElementId, nameof(sAPWindowMaximisesearchSAPElementId), required: true);
            var __workflow_sAPWindowMaximiseworkflow = WorkflowExpression.Compile(sAPWindowMaximiseworkflow, nameof(sAPWindowMaximiseworkflow), required: true);
            var __workflow_sAPWindowMaximisedetectParentWindowElement = WorkflowExpression.Compile(sAPWindowMaximisedetectParentWindowElement, nameof(sAPWindowMaximisedetectParentWindowElement), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPWindowMaximise";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPWindowMaximise = new JObject();
                var sAPWindowMaximisepropCount = 0;
                sAPWindowMaximisepropCount++;
                sAPWindowMaximise["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPWindowMaximisesearchSAPElementId);
                if (__workflow_sAPWindowMaximisedetectParentWindowElement != null)
                {
                    if (__workflow_sAPWindowMaximisedetectParentWindowElement != null)
                    {
                        sAPWindowMaximise["DetectParentWindowElement"] = ExpressionConverter.ConvertO(__workflow_sAPWindowMaximisedetectParentWindowElement);
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
                sAPWindowMaximise["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPWindowMaximiseworkflow);
                if (sAPWindowMaximisepropCount > 0)
                {
                    callPayload.Body = sAPWindowMaximise;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPWindowMinimise(Expression<Func<string>> sAPWindowMinimisesearchSAPElementId, Expression<Func<string>> sAPWindowMinimiseworkflow, Expression<Func<bool>> sAPWindowMinimisedetectParentWindowElement = null)
        {
            var __workflow_sAPWindowMinimisesearchSAPElementId = WorkflowExpression.Compile(sAPWindowMinimisesearchSAPElementId, nameof(sAPWindowMinimisesearchSAPElementId), required: true);
            var __workflow_sAPWindowMinimiseworkflow = WorkflowExpression.Compile(sAPWindowMinimiseworkflow, nameof(sAPWindowMinimiseworkflow), required: true);
            var __workflow_sAPWindowMinimisedetectParentWindowElement = WorkflowExpression.Compile(sAPWindowMinimisedetectParentWindowElement, nameof(sAPWindowMinimisedetectParentWindowElement), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPWindowMinimise";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPWindowMinimise = new JObject();
                var sAPWindowMinimisepropCount = 0;
                sAPWindowMinimisepropCount++;
                sAPWindowMinimise["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPWindowMinimisesearchSAPElementId);
                if (__workflow_sAPWindowMinimisedetectParentWindowElement != null)
                {
                    if (__workflow_sAPWindowMinimisedetectParentWindowElement != null)
                    {
                        sAPWindowMinimise["DetectParentWindowElement"] = ExpressionConverter.ConvertO(__workflow_sAPWindowMinimisedetectParentWindowElement);
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
                sAPWindowMinimise["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPWindowMinimiseworkflow);
                if (sAPWindowMinimisepropCount > 0)
                {
                    callPayload.Body = sAPWindowMinimise;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPWindowClose(Expression<Func<string>> sAPWindowClosesearchSAPElementId, Expression<Func<string>> sAPWindowCloseworkflow, Expression<Func<bool>> sAPWindowClosedetectParentWindowElement = null)
        {
            var __workflow_sAPWindowClosesearchSAPElementId = WorkflowExpression.Compile(sAPWindowClosesearchSAPElementId, nameof(sAPWindowClosesearchSAPElementId), required: true);
            var __workflow_sAPWindowCloseworkflow = WorkflowExpression.Compile(sAPWindowCloseworkflow, nameof(sAPWindowCloseworkflow), required: true);
            var __workflow_sAPWindowClosedetectParentWindowElement = WorkflowExpression.Compile(sAPWindowClosedetectParentWindowElement, nameof(sAPWindowClosedetectParentWindowElement), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPWindowClose";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPWindowClose = new JObject();
                var sAPWindowClosepropCount = 0;
                sAPWindowClosepropCount++;
                sAPWindowClose["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPWindowClosesearchSAPElementId);
                if (__workflow_sAPWindowClosedetectParentWindowElement != null)
                {
                    if (__workflow_sAPWindowClosedetectParentWindowElement != null)
                    {
                        sAPWindowClose["DetectParentWindowElement"] = ExpressionConverter.ConvertO(__workflow_sAPWindowClosedetectParentWindowElement);
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
                sAPWindowClose["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPWindowCloseworkflow);
                if (sAPWindowClosepropCount > 0)
                {
                    callPayload.Body = sAPWindowClose;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPBringWindowToFront(Expression<Func<string>> sAPBringWindowToFrontsearchSAPElementId, Expression<Func<string>> sAPBringWindowToFrontworkflow, Expression<Func<bool>> sAPBringWindowToFronttoggleWindow = null, Expression<Func<bool>> sAPBringWindowToFronttoggleUsesGlobalLeftMouseClickAgent = null, Expression<Func<double>> sAPBringWindowToFronttoggleDelay = null, Expression<Func<bool>> sAPBringWindowToFrontdetectParentWindowElement = null)
        {
            var __workflow_sAPBringWindowToFrontsearchSAPElementId = WorkflowExpression.Compile(sAPBringWindowToFrontsearchSAPElementId, nameof(sAPBringWindowToFrontsearchSAPElementId), required: true);
            var __workflow_sAPBringWindowToFrontworkflow = WorkflowExpression.Compile(sAPBringWindowToFrontworkflow, nameof(sAPBringWindowToFrontworkflow), required: true);
            var __workflow_sAPBringWindowToFronttoggleWindow = WorkflowExpression.Compile(sAPBringWindowToFronttoggleWindow, nameof(sAPBringWindowToFronttoggleWindow), required: false);
            var __workflow_sAPBringWindowToFronttoggleUsesGlobalLeftMouseClickAgent = WorkflowExpression.Compile(sAPBringWindowToFronttoggleUsesGlobalLeftMouseClickAgent, nameof(sAPBringWindowToFronttoggleUsesGlobalLeftMouseClickAgent), required: false);
            var __workflow_sAPBringWindowToFronttoggleDelay = WorkflowExpression.Compile(sAPBringWindowToFronttoggleDelay, nameof(sAPBringWindowToFronttoggleDelay), required: false);
            var __workflow_sAPBringWindowToFrontdetectParentWindowElement = WorkflowExpression.Compile(sAPBringWindowToFrontdetectParentWindowElement, nameof(sAPBringWindowToFrontdetectParentWindowElement), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPBringWindowToFront";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPBringWindowToFront = new JObject();
                var sAPBringWindowToFrontpropCount = 0;
                sAPBringWindowToFrontpropCount++;
                sAPBringWindowToFront["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPBringWindowToFrontsearchSAPElementId);
                if (__workflow_sAPBringWindowToFronttoggleWindow != null)
                {
                    if (__workflow_sAPBringWindowToFronttoggleWindow != null)
                    {
                        sAPBringWindowToFront["ToggleWindow"] = ExpressionConverter.ConvertO(__workflow_sAPBringWindowToFronttoggleWindow);
                        sAPBringWindowToFrontpropCount++;
                    }

                    sAPBringWindowToFrontpropCount++;
                }
                else
                {
                    sAPBringWindowToFront["ToggleWindow"] = true;
                    sAPBringWindowToFrontpropCount++;
                }

                if (__workflow_sAPBringWindowToFronttoggleUsesGlobalLeftMouseClickAgent != null)
                {
                    if (__workflow_sAPBringWindowToFronttoggleUsesGlobalLeftMouseClickAgent != null)
                    {
                        sAPBringWindowToFront["ToggleUsesGlobalLeftMouseClickAgent"] = ExpressionConverter.ConvertO(__workflow_sAPBringWindowToFronttoggleUsesGlobalLeftMouseClickAgent);
                        sAPBringWindowToFrontpropCount++;
                    }

                    sAPBringWindowToFrontpropCount++;
                }
                else
                {
                    sAPBringWindowToFront["ToggleUsesGlobalLeftMouseClickAgent"] = true;
                    sAPBringWindowToFrontpropCount++;
                }

                if (__workflow_sAPBringWindowToFronttoggleDelay != null)
                {
                    if (__workflow_sAPBringWindowToFronttoggleDelay != null)
                    {
                        sAPBringWindowToFront["ToggleDelay"] = ExpressionConverter.ConvertO(__workflow_sAPBringWindowToFronttoggleDelay);
                        sAPBringWindowToFrontpropCount++;
                    }

                    sAPBringWindowToFrontpropCount++;
                }
                else
                {
                    sAPBringWindowToFront["ToggleDelay"] = 0.5;
                    sAPBringWindowToFrontpropCount++;
                }

                if (__workflow_sAPBringWindowToFrontdetectParentWindowElement != null)
                {
                    if (__workflow_sAPBringWindowToFrontdetectParentWindowElement != null)
                    {
                        sAPBringWindowToFront["DetectParentWindowElement"] = ExpressionConverter.ConvertO(__workflow_sAPBringWindowToFrontdetectParentWindowElement);
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
                sAPBringWindowToFront["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPBringWindowToFrontworkflow);
                if (sAPBringWindowToFrontpropCount > 0)
                {
                    callPayload.Body = sAPBringWindowToFront;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPGlobalLeftMouseClickOnSAPElement(Expression<Func<string>> sAPGlobalLeftMouseClickOnSAPElementsearchSAPElementId, Expression<Func<string>> sAPGlobalLeftMouseClickOnSAPElementworkflow, Expression<Func<bool>> sAPGlobalLeftMouseClickOnSAPElementsetElementWindowTopMost = null, Expression<Func<bool>> sAPGlobalLeftMouseClickOnSAPElementbringElementWindowToFront = null, Expression<Func<bool>> sAPGlobalLeftMouseClickOnSAPElementtoggleWindow = null, Expression<Func<bool>> sAPGlobalLeftMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent = null, Expression<Func<double>> sAPGlobalLeftMouseClickOnSAPElementtoggleDelay = null, Expression<Func<int>> sAPGlobalLeftMouseClickOnSAPElementclickOffsetX = null, Expression<Func<int>> sAPGlobalLeftMouseClickOnSAPElementclickOffsetY = null, Expression<Func<sAPGlobalLeftMouseClickOnSAPElementoffsetRelativeToInput>> sAPGlobalLeftMouseClickOnSAPElementoffsetRelativeTo = null)
        {
            var __workflow_sAPGlobalLeftMouseClickOnSAPElementsearchSAPElementId = WorkflowExpression.Compile(sAPGlobalLeftMouseClickOnSAPElementsearchSAPElementId, nameof(sAPGlobalLeftMouseClickOnSAPElementsearchSAPElementId), required: true);
            var __workflow_sAPGlobalLeftMouseClickOnSAPElementworkflow = WorkflowExpression.Compile(sAPGlobalLeftMouseClickOnSAPElementworkflow, nameof(sAPGlobalLeftMouseClickOnSAPElementworkflow), required: true);
            var __workflow_sAPGlobalLeftMouseClickOnSAPElementsetElementWindowTopMost = WorkflowExpression.Compile(sAPGlobalLeftMouseClickOnSAPElementsetElementWindowTopMost, nameof(sAPGlobalLeftMouseClickOnSAPElementsetElementWindowTopMost), required: false);
            var __workflow_sAPGlobalLeftMouseClickOnSAPElementbringElementWindowToFront = WorkflowExpression.Compile(sAPGlobalLeftMouseClickOnSAPElementbringElementWindowToFront, nameof(sAPGlobalLeftMouseClickOnSAPElementbringElementWindowToFront), required: false);
            var __workflow_sAPGlobalLeftMouseClickOnSAPElementtoggleWindow = WorkflowExpression.Compile(sAPGlobalLeftMouseClickOnSAPElementtoggleWindow, nameof(sAPGlobalLeftMouseClickOnSAPElementtoggleWindow), required: false);
            var __workflow_sAPGlobalLeftMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent = WorkflowExpression.Compile(sAPGlobalLeftMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent, nameof(sAPGlobalLeftMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent), required: false);
            var __workflow_sAPGlobalLeftMouseClickOnSAPElementtoggleDelay = WorkflowExpression.Compile(sAPGlobalLeftMouseClickOnSAPElementtoggleDelay, nameof(sAPGlobalLeftMouseClickOnSAPElementtoggleDelay), required: false);
            var __workflow_sAPGlobalLeftMouseClickOnSAPElementclickOffsetX = WorkflowExpression.Compile(sAPGlobalLeftMouseClickOnSAPElementclickOffsetX, nameof(sAPGlobalLeftMouseClickOnSAPElementclickOffsetX), required: false);
            var __workflow_sAPGlobalLeftMouseClickOnSAPElementclickOffsetY = WorkflowExpression.Compile(sAPGlobalLeftMouseClickOnSAPElementclickOffsetY, nameof(sAPGlobalLeftMouseClickOnSAPElementclickOffsetY), required: false);
            var __workflow_sAPGlobalLeftMouseClickOnSAPElementoffsetRelativeTo = WorkflowExpression.Compile(sAPGlobalLeftMouseClickOnSAPElementoffsetRelativeTo, nameof(sAPGlobalLeftMouseClickOnSAPElementoffsetRelativeTo), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGlobalLeftMouseClickOnSAPElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGlobalLeftMouseClickOnSAPElement = new JObject();
                var sAPGlobalLeftMouseClickOnSAPElementpropCount = 0;
                sAPGlobalLeftMouseClickOnSAPElementpropCount++;
                sAPGlobalLeftMouseClickOnSAPElement["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalLeftMouseClickOnSAPElementsearchSAPElementId);
                if (__workflow_sAPGlobalLeftMouseClickOnSAPElementsetElementWindowTopMost != null)
                {
                    if (__workflow_sAPGlobalLeftMouseClickOnSAPElementsetElementWindowTopMost != null)
                    {
                        sAPGlobalLeftMouseClickOnSAPElement["SetElementWindowTopMost"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalLeftMouseClickOnSAPElementsetElementWindowTopMost);
                        sAPGlobalLeftMouseClickOnSAPElementpropCount++;
                    }

                    sAPGlobalLeftMouseClickOnSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalLeftMouseClickOnSAPElement["SetElementWindowTopMost"] = false;
                    sAPGlobalLeftMouseClickOnSAPElementpropCount++;
                }

                if (__workflow_sAPGlobalLeftMouseClickOnSAPElementbringElementWindowToFront != null)
                {
                    if (__workflow_sAPGlobalLeftMouseClickOnSAPElementbringElementWindowToFront != null)
                    {
                        sAPGlobalLeftMouseClickOnSAPElement["BringElementWindowToFront"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalLeftMouseClickOnSAPElementbringElementWindowToFront);
                        sAPGlobalLeftMouseClickOnSAPElementpropCount++;
                    }

                    sAPGlobalLeftMouseClickOnSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalLeftMouseClickOnSAPElement["BringElementWindowToFront"] = false;
                    sAPGlobalLeftMouseClickOnSAPElementpropCount++;
                }

                if (__workflow_sAPGlobalLeftMouseClickOnSAPElementtoggleWindow != null)
                {
                    if (__workflow_sAPGlobalLeftMouseClickOnSAPElementtoggleWindow != null)
                    {
                        sAPGlobalLeftMouseClickOnSAPElement["ToggleWindow"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalLeftMouseClickOnSAPElementtoggleWindow);
                        sAPGlobalLeftMouseClickOnSAPElementpropCount++;
                    }

                    sAPGlobalLeftMouseClickOnSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalLeftMouseClickOnSAPElement["ToggleWindow"] = true;
                    sAPGlobalLeftMouseClickOnSAPElementpropCount++;
                }

                if (__workflow_sAPGlobalLeftMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent != null)
                {
                    if (__workflow_sAPGlobalLeftMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent != null)
                    {
                        sAPGlobalLeftMouseClickOnSAPElement["ToggleUsesGlobalLeftMouseClickAgent"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalLeftMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent);
                        sAPGlobalLeftMouseClickOnSAPElementpropCount++;
                    }

                    sAPGlobalLeftMouseClickOnSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalLeftMouseClickOnSAPElement["ToggleUsesGlobalLeftMouseClickAgent"] = true;
                    sAPGlobalLeftMouseClickOnSAPElementpropCount++;
                }

                if (__workflow_sAPGlobalLeftMouseClickOnSAPElementtoggleDelay != null)
                {
                    if (__workflow_sAPGlobalLeftMouseClickOnSAPElementtoggleDelay != null)
                    {
                        sAPGlobalLeftMouseClickOnSAPElement["ToggleDelay"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalLeftMouseClickOnSAPElementtoggleDelay);
                        sAPGlobalLeftMouseClickOnSAPElementpropCount++;
                    }

                    sAPGlobalLeftMouseClickOnSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalLeftMouseClickOnSAPElement["ToggleDelay"] = 0.5;
                    sAPGlobalLeftMouseClickOnSAPElementpropCount++;
                }

                if (__workflow_sAPGlobalLeftMouseClickOnSAPElementclickOffsetX != null)
                {
                    if (__workflow_sAPGlobalLeftMouseClickOnSAPElementclickOffsetX != null)
                    {
                        sAPGlobalLeftMouseClickOnSAPElement["ClickOffsetX"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalLeftMouseClickOnSAPElementclickOffsetX);
                        sAPGlobalLeftMouseClickOnSAPElementpropCount++;
                    }

                    sAPGlobalLeftMouseClickOnSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalLeftMouseClickOnSAPElement["ClickOffsetX"] = 0;
                    sAPGlobalLeftMouseClickOnSAPElementpropCount++;
                }

                if (__workflow_sAPGlobalLeftMouseClickOnSAPElementclickOffsetY != null)
                {
                    if (__workflow_sAPGlobalLeftMouseClickOnSAPElementclickOffsetY != null)
                    {
                        sAPGlobalLeftMouseClickOnSAPElement["ClickOffsetY"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalLeftMouseClickOnSAPElementclickOffsetY);
                        sAPGlobalLeftMouseClickOnSAPElementpropCount++;
                    }

                    sAPGlobalLeftMouseClickOnSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalLeftMouseClickOnSAPElement["ClickOffsetY"] = 0;
                    sAPGlobalLeftMouseClickOnSAPElementpropCount++;
                }

                if (__workflow_sAPGlobalLeftMouseClickOnSAPElementoffsetRelativeTo != null)
                {
                    sAPGlobalLeftMouseClickOnSAPElement["OffsetRelativeTo"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalLeftMouseClickOnSAPElementoffsetRelativeTo);
                    sAPGlobalLeftMouseClickOnSAPElementpropCount++;
                }

                sAPGlobalLeftMouseClickOnSAPElementpropCount++;
                sAPGlobalLeftMouseClickOnSAPElement["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalLeftMouseClickOnSAPElementworkflow);
                if (sAPGlobalLeftMouseClickOnSAPElementpropCount > 0)
                {
                    callPayload.Body = sAPGlobalLeftMouseClickOnSAPElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPGlobalRightMouseClickOnSAPElement(Expression<Func<string>> sAPGlobalRightMouseClickOnSAPElementsearchSAPElementId, Expression<Func<string>> sAPGlobalRightMouseClickOnSAPElementworkflow, Expression<Func<bool>> sAPGlobalRightMouseClickOnSAPElementsetElementWindowTopMost = null, Expression<Func<bool>> sAPGlobalRightMouseClickOnSAPElementbringElementWindowToFront = null, Expression<Func<bool>> sAPGlobalRightMouseClickOnSAPElementtoggleWindow = null, Expression<Func<bool>> sAPGlobalRightMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent = null, Expression<Func<double>> sAPGlobalRightMouseClickOnSAPElementtoggleDelay = null, Expression<Func<int>> sAPGlobalRightMouseClickOnSAPElementclickOffsetX = null, Expression<Func<int>> sAPGlobalRightMouseClickOnSAPElementclickOffsetY = null, Expression<Func<sAPGlobalRightMouseClickOnSAPElementoffsetRelativeToInput>> sAPGlobalRightMouseClickOnSAPElementoffsetRelativeTo = null)
        {
            var __workflow_sAPGlobalRightMouseClickOnSAPElementsearchSAPElementId = WorkflowExpression.Compile(sAPGlobalRightMouseClickOnSAPElementsearchSAPElementId, nameof(sAPGlobalRightMouseClickOnSAPElementsearchSAPElementId), required: true);
            var __workflow_sAPGlobalRightMouseClickOnSAPElementworkflow = WorkflowExpression.Compile(sAPGlobalRightMouseClickOnSAPElementworkflow, nameof(sAPGlobalRightMouseClickOnSAPElementworkflow), required: true);
            var __workflow_sAPGlobalRightMouseClickOnSAPElementsetElementWindowTopMost = WorkflowExpression.Compile(sAPGlobalRightMouseClickOnSAPElementsetElementWindowTopMost, nameof(sAPGlobalRightMouseClickOnSAPElementsetElementWindowTopMost), required: false);
            var __workflow_sAPGlobalRightMouseClickOnSAPElementbringElementWindowToFront = WorkflowExpression.Compile(sAPGlobalRightMouseClickOnSAPElementbringElementWindowToFront, nameof(sAPGlobalRightMouseClickOnSAPElementbringElementWindowToFront), required: false);
            var __workflow_sAPGlobalRightMouseClickOnSAPElementtoggleWindow = WorkflowExpression.Compile(sAPGlobalRightMouseClickOnSAPElementtoggleWindow, nameof(sAPGlobalRightMouseClickOnSAPElementtoggleWindow), required: false);
            var __workflow_sAPGlobalRightMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent = WorkflowExpression.Compile(sAPGlobalRightMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent, nameof(sAPGlobalRightMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent), required: false);
            var __workflow_sAPGlobalRightMouseClickOnSAPElementtoggleDelay = WorkflowExpression.Compile(sAPGlobalRightMouseClickOnSAPElementtoggleDelay, nameof(sAPGlobalRightMouseClickOnSAPElementtoggleDelay), required: false);
            var __workflow_sAPGlobalRightMouseClickOnSAPElementclickOffsetX = WorkflowExpression.Compile(sAPGlobalRightMouseClickOnSAPElementclickOffsetX, nameof(sAPGlobalRightMouseClickOnSAPElementclickOffsetX), required: false);
            var __workflow_sAPGlobalRightMouseClickOnSAPElementclickOffsetY = WorkflowExpression.Compile(sAPGlobalRightMouseClickOnSAPElementclickOffsetY, nameof(sAPGlobalRightMouseClickOnSAPElementclickOffsetY), required: false);
            var __workflow_sAPGlobalRightMouseClickOnSAPElementoffsetRelativeTo = WorkflowExpression.Compile(sAPGlobalRightMouseClickOnSAPElementoffsetRelativeTo, nameof(sAPGlobalRightMouseClickOnSAPElementoffsetRelativeTo), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGlobalRightMouseClickOnSAPElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGlobalRightMouseClickOnSAPElement = new JObject();
                var sAPGlobalRightMouseClickOnSAPElementpropCount = 0;
                sAPGlobalRightMouseClickOnSAPElementpropCount++;
                sAPGlobalRightMouseClickOnSAPElement["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalRightMouseClickOnSAPElementsearchSAPElementId);
                if (__workflow_sAPGlobalRightMouseClickOnSAPElementsetElementWindowTopMost != null)
                {
                    if (__workflow_sAPGlobalRightMouseClickOnSAPElementsetElementWindowTopMost != null)
                    {
                        sAPGlobalRightMouseClickOnSAPElement["SetElementWindowTopMost"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalRightMouseClickOnSAPElementsetElementWindowTopMost);
                        sAPGlobalRightMouseClickOnSAPElementpropCount++;
                    }

                    sAPGlobalRightMouseClickOnSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalRightMouseClickOnSAPElement["SetElementWindowTopMost"] = false;
                    sAPGlobalRightMouseClickOnSAPElementpropCount++;
                }

                if (__workflow_sAPGlobalRightMouseClickOnSAPElementbringElementWindowToFront != null)
                {
                    if (__workflow_sAPGlobalRightMouseClickOnSAPElementbringElementWindowToFront != null)
                    {
                        sAPGlobalRightMouseClickOnSAPElement["BringElementWindowToFront"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalRightMouseClickOnSAPElementbringElementWindowToFront);
                        sAPGlobalRightMouseClickOnSAPElementpropCount++;
                    }

                    sAPGlobalRightMouseClickOnSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalRightMouseClickOnSAPElement["BringElementWindowToFront"] = false;
                    sAPGlobalRightMouseClickOnSAPElementpropCount++;
                }

                if (__workflow_sAPGlobalRightMouseClickOnSAPElementtoggleWindow != null)
                {
                    if (__workflow_sAPGlobalRightMouseClickOnSAPElementtoggleWindow != null)
                    {
                        sAPGlobalRightMouseClickOnSAPElement["ToggleWindow"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalRightMouseClickOnSAPElementtoggleWindow);
                        sAPGlobalRightMouseClickOnSAPElementpropCount++;
                    }

                    sAPGlobalRightMouseClickOnSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalRightMouseClickOnSAPElement["ToggleWindow"] = true;
                    sAPGlobalRightMouseClickOnSAPElementpropCount++;
                }

                if (__workflow_sAPGlobalRightMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent != null)
                {
                    if (__workflow_sAPGlobalRightMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent != null)
                    {
                        sAPGlobalRightMouseClickOnSAPElement["ToggleUsesGlobalLeftMouseClickAgent"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalRightMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent);
                        sAPGlobalRightMouseClickOnSAPElementpropCount++;
                    }

                    sAPGlobalRightMouseClickOnSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalRightMouseClickOnSAPElement["ToggleUsesGlobalLeftMouseClickAgent"] = true;
                    sAPGlobalRightMouseClickOnSAPElementpropCount++;
                }

                if (__workflow_sAPGlobalRightMouseClickOnSAPElementtoggleDelay != null)
                {
                    if (__workflow_sAPGlobalRightMouseClickOnSAPElementtoggleDelay != null)
                    {
                        sAPGlobalRightMouseClickOnSAPElement["ToggleDelay"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalRightMouseClickOnSAPElementtoggleDelay);
                        sAPGlobalRightMouseClickOnSAPElementpropCount++;
                    }

                    sAPGlobalRightMouseClickOnSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalRightMouseClickOnSAPElement["ToggleDelay"] = 0.5;
                    sAPGlobalRightMouseClickOnSAPElementpropCount++;
                }

                if (__workflow_sAPGlobalRightMouseClickOnSAPElementclickOffsetX != null)
                {
                    if (__workflow_sAPGlobalRightMouseClickOnSAPElementclickOffsetX != null)
                    {
                        sAPGlobalRightMouseClickOnSAPElement["ClickOffsetX"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalRightMouseClickOnSAPElementclickOffsetX);
                        sAPGlobalRightMouseClickOnSAPElementpropCount++;
                    }

                    sAPGlobalRightMouseClickOnSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalRightMouseClickOnSAPElement["ClickOffsetX"] = 0;
                    sAPGlobalRightMouseClickOnSAPElementpropCount++;
                }

                if (__workflow_sAPGlobalRightMouseClickOnSAPElementclickOffsetY != null)
                {
                    if (__workflow_sAPGlobalRightMouseClickOnSAPElementclickOffsetY != null)
                    {
                        sAPGlobalRightMouseClickOnSAPElement["ClickOffsetY"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalRightMouseClickOnSAPElementclickOffsetY);
                        sAPGlobalRightMouseClickOnSAPElementpropCount++;
                    }

                    sAPGlobalRightMouseClickOnSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalRightMouseClickOnSAPElement["ClickOffsetY"] = 0;
                    sAPGlobalRightMouseClickOnSAPElementpropCount++;
                }

                if (__workflow_sAPGlobalRightMouseClickOnSAPElementoffsetRelativeTo != null)
                {
                    sAPGlobalRightMouseClickOnSAPElement["OffsetRelativeTo"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalRightMouseClickOnSAPElementoffsetRelativeTo);
                    sAPGlobalRightMouseClickOnSAPElementpropCount++;
                }

                sAPGlobalRightMouseClickOnSAPElementpropCount++;
                sAPGlobalRightMouseClickOnSAPElement["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalRightMouseClickOnSAPElementworkflow);
                if (sAPGlobalRightMouseClickOnSAPElementpropCount > 0)
                {
                    callPayload.Body = sAPGlobalRightMouseClickOnSAPElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPGlobalMiddleMouseClickOnSAPElement(Expression<Func<string>> sAPGlobalMiddleMouseClickOnSAPElementsearchSAPElementId, Expression<Func<string>> sAPGlobalMiddleMouseClickOnSAPElementworkflow, Expression<Func<bool>> sAPGlobalMiddleMouseClickOnSAPElementsetElementWindowTopMost = null, Expression<Func<bool>> sAPGlobalMiddleMouseClickOnSAPElementbringElementWindowToFront = null, Expression<Func<bool>> sAPGlobalMiddleMouseClickOnSAPElementtoggleWindow = null, Expression<Func<bool>> sAPGlobalMiddleMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent = null, Expression<Func<double>> sAPGlobalMiddleMouseClickOnSAPElementtoggleDelay = null, Expression<Func<int>> sAPGlobalMiddleMouseClickOnSAPElementclickOffsetX = null, Expression<Func<int>> sAPGlobalMiddleMouseClickOnSAPElementclickOffsetY = null, Expression<Func<sAPGlobalMiddleMouseClickOnSAPElementoffsetRelativeToInput>> sAPGlobalMiddleMouseClickOnSAPElementoffsetRelativeTo = null)
        {
            var __workflow_sAPGlobalMiddleMouseClickOnSAPElementsearchSAPElementId = WorkflowExpression.Compile(sAPGlobalMiddleMouseClickOnSAPElementsearchSAPElementId, nameof(sAPGlobalMiddleMouseClickOnSAPElementsearchSAPElementId), required: true);
            var __workflow_sAPGlobalMiddleMouseClickOnSAPElementworkflow = WorkflowExpression.Compile(sAPGlobalMiddleMouseClickOnSAPElementworkflow, nameof(sAPGlobalMiddleMouseClickOnSAPElementworkflow), required: true);
            var __workflow_sAPGlobalMiddleMouseClickOnSAPElementsetElementWindowTopMost = WorkflowExpression.Compile(sAPGlobalMiddleMouseClickOnSAPElementsetElementWindowTopMost, nameof(sAPGlobalMiddleMouseClickOnSAPElementsetElementWindowTopMost), required: false);
            var __workflow_sAPGlobalMiddleMouseClickOnSAPElementbringElementWindowToFront = WorkflowExpression.Compile(sAPGlobalMiddleMouseClickOnSAPElementbringElementWindowToFront, nameof(sAPGlobalMiddleMouseClickOnSAPElementbringElementWindowToFront), required: false);
            var __workflow_sAPGlobalMiddleMouseClickOnSAPElementtoggleWindow = WorkflowExpression.Compile(sAPGlobalMiddleMouseClickOnSAPElementtoggleWindow, nameof(sAPGlobalMiddleMouseClickOnSAPElementtoggleWindow), required: false);
            var __workflow_sAPGlobalMiddleMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent = WorkflowExpression.Compile(sAPGlobalMiddleMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent, nameof(sAPGlobalMiddleMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent), required: false);
            var __workflow_sAPGlobalMiddleMouseClickOnSAPElementtoggleDelay = WorkflowExpression.Compile(sAPGlobalMiddleMouseClickOnSAPElementtoggleDelay, nameof(sAPGlobalMiddleMouseClickOnSAPElementtoggleDelay), required: false);
            var __workflow_sAPGlobalMiddleMouseClickOnSAPElementclickOffsetX = WorkflowExpression.Compile(sAPGlobalMiddleMouseClickOnSAPElementclickOffsetX, nameof(sAPGlobalMiddleMouseClickOnSAPElementclickOffsetX), required: false);
            var __workflow_sAPGlobalMiddleMouseClickOnSAPElementclickOffsetY = WorkflowExpression.Compile(sAPGlobalMiddleMouseClickOnSAPElementclickOffsetY, nameof(sAPGlobalMiddleMouseClickOnSAPElementclickOffsetY), required: false);
            var __workflow_sAPGlobalMiddleMouseClickOnSAPElementoffsetRelativeTo = WorkflowExpression.Compile(sAPGlobalMiddleMouseClickOnSAPElementoffsetRelativeTo, nameof(sAPGlobalMiddleMouseClickOnSAPElementoffsetRelativeTo), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGlobalMiddleMouseClickOnSAPElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGlobalMiddleMouseClickOnSAPElement = new JObject();
                var sAPGlobalMiddleMouseClickOnSAPElementpropCount = 0;
                sAPGlobalMiddleMouseClickOnSAPElementpropCount++;
                sAPGlobalMiddleMouseClickOnSAPElement["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalMiddleMouseClickOnSAPElementsearchSAPElementId);
                if (__workflow_sAPGlobalMiddleMouseClickOnSAPElementsetElementWindowTopMost != null)
                {
                    if (__workflow_sAPGlobalMiddleMouseClickOnSAPElementsetElementWindowTopMost != null)
                    {
                        sAPGlobalMiddleMouseClickOnSAPElement["SetElementWindowTopMost"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalMiddleMouseClickOnSAPElementsetElementWindowTopMost);
                        sAPGlobalMiddleMouseClickOnSAPElementpropCount++;
                    }

                    sAPGlobalMiddleMouseClickOnSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalMiddleMouseClickOnSAPElement["SetElementWindowTopMost"] = false;
                    sAPGlobalMiddleMouseClickOnSAPElementpropCount++;
                }

                if (__workflow_sAPGlobalMiddleMouseClickOnSAPElementbringElementWindowToFront != null)
                {
                    if (__workflow_sAPGlobalMiddleMouseClickOnSAPElementbringElementWindowToFront != null)
                    {
                        sAPGlobalMiddleMouseClickOnSAPElement["BringElementWindowToFront"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalMiddleMouseClickOnSAPElementbringElementWindowToFront);
                        sAPGlobalMiddleMouseClickOnSAPElementpropCount++;
                    }

                    sAPGlobalMiddleMouseClickOnSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalMiddleMouseClickOnSAPElement["BringElementWindowToFront"] = false;
                    sAPGlobalMiddleMouseClickOnSAPElementpropCount++;
                }

                if (__workflow_sAPGlobalMiddleMouseClickOnSAPElementtoggleWindow != null)
                {
                    if (__workflow_sAPGlobalMiddleMouseClickOnSAPElementtoggleWindow != null)
                    {
                        sAPGlobalMiddleMouseClickOnSAPElement["ToggleWindow"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalMiddleMouseClickOnSAPElementtoggleWindow);
                        sAPGlobalMiddleMouseClickOnSAPElementpropCount++;
                    }

                    sAPGlobalMiddleMouseClickOnSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalMiddleMouseClickOnSAPElement["ToggleWindow"] = true;
                    sAPGlobalMiddleMouseClickOnSAPElementpropCount++;
                }

                if (__workflow_sAPGlobalMiddleMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent != null)
                {
                    if (__workflow_sAPGlobalMiddleMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent != null)
                    {
                        sAPGlobalMiddleMouseClickOnSAPElement["ToggleUsesGlobalLeftMouseClickAgent"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalMiddleMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent);
                        sAPGlobalMiddleMouseClickOnSAPElementpropCount++;
                    }

                    sAPGlobalMiddleMouseClickOnSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalMiddleMouseClickOnSAPElement["ToggleUsesGlobalLeftMouseClickAgent"] = true;
                    sAPGlobalMiddleMouseClickOnSAPElementpropCount++;
                }

                if (__workflow_sAPGlobalMiddleMouseClickOnSAPElementtoggleDelay != null)
                {
                    if (__workflow_sAPGlobalMiddleMouseClickOnSAPElementtoggleDelay != null)
                    {
                        sAPGlobalMiddleMouseClickOnSAPElement["ToggleDelay"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalMiddleMouseClickOnSAPElementtoggleDelay);
                        sAPGlobalMiddleMouseClickOnSAPElementpropCount++;
                    }

                    sAPGlobalMiddleMouseClickOnSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalMiddleMouseClickOnSAPElement["ToggleDelay"] = 0.5;
                    sAPGlobalMiddleMouseClickOnSAPElementpropCount++;
                }

                if (__workflow_sAPGlobalMiddleMouseClickOnSAPElementclickOffsetX != null)
                {
                    if (__workflow_sAPGlobalMiddleMouseClickOnSAPElementclickOffsetX != null)
                    {
                        sAPGlobalMiddleMouseClickOnSAPElement["ClickOffsetX"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalMiddleMouseClickOnSAPElementclickOffsetX);
                        sAPGlobalMiddleMouseClickOnSAPElementpropCount++;
                    }

                    sAPGlobalMiddleMouseClickOnSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalMiddleMouseClickOnSAPElement["ClickOffsetX"] = 0;
                    sAPGlobalMiddleMouseClickOnSAPElementpropCount++;
                }

                if (__workflow_sAPGlobalMiddleMouseClickOnSAPElementclickOffsetY != null)
                {
                    if (__workflow_sAPGlobalMiddleMouseClickOnSAPElementclickOffsetY != null)
                    {
                        sAPGlobalMiddleMouseClickOnSAPElement["ClickOffsetY"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalMiddleMouseClickOnSAPElementclickOffsetY);
                        sAPGlobalMiddleMouseClickOnSAPElementpropCount++;
                    }

                    sAPGlobalMiddleMouseClickOnSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalMiddleMouseClickOnSAPElement["ClickOffsetY"] = 0;
                    sAPGlobalMiddleMouseClickOnSAPElementpropCount++;
                }

                if (__workflow_sAPGlobalMiddleMouseClickOnSAPElementoffsetRelativeTo != null)
                {
                    sAPGlobalMiddleMouseClickOnSAPElement["OffsetRelativeTo"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalMiddleMouseClickOnSAPElementoffsetRelativeTo);
                    sAPGlobalMiddleMouseClickOnSAPElementpropCount++;
                }

                sAPGlobalMiddleMouseClickOnSAPElementpropCount++;
                sAPGlobalMiddleMouseClickOnSAPElement["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalMiddleMouseClickOnSAPElementworkflow);
                if (sAPGlobalMiddleMouseClickOnSAPElementpropCount > 0)
                {
                    callPayload.Body = sAPGlobalMiddleMouseClickOnSAPElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPGlobalDoubleLeftMouseClickOnSAPElement(Expression<Func<string>> sAPGlobalDoubleLeftMouseClickOnSAPElementsearchSAPElementId, Expression<Func<string>> sAPGlobalDoubleLeftMouseClickOnSAPElementworkflow, Expression<Func<bool>> sAPGlobalDoubleLeftMouseClickOnSAPElementsetElementWindowTopMost = null, Expression<Func<bool>> sAPGlobalDoubleLeftMouseClickOnSAPElementbringElementWindowToFront = null, Expression<Func<bool>> sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleWindow = null, Expression<Func<bool>> sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent = null, Expression<Func<double>> sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleDelay = null, Expression<Func<int>> sAPGlobalDoubleLeftMouseClickOnSAPElementclickOffsetX = null, Expression<Func<int>> sAPGlobalDoubleLeftMouseClickOnSAPElementclickOffsetY = null, Expression<Func<sAPGlobalDoubleLeftMouseClickOnSAPElementoffsetRelativeToInput>> sAPGlobalDoubleLeftMouseClickOnSAPElementoffsetRelativeTo = null, Expression<Func<int>> sAPGlobalDoubleLeftMouseClickOnSAPElementdoubleClickDelayInMilliseconds = null)
        {
            var __workflow_sAPGlobalDoubleLeftMouseClickOnSAPElementsearchSAPElementId = WorkflowExpression.Compile(sAPGlobalDoubleLeftMouseClickOnSAPElementsearchSAPElementId, nameof(sAPGlobalDoubleLeftMouseClickOnSAPElementsearchSAPElementId), required: true);
            var __workflow_sAPGlobalDoubleLeftMouseClickOnSAPElementworkflow = WorkflowExpression.Compile(sAPGlobalDoubleLeftMouseClickOnSAPElementworkflow, nameof(sAPGlobalDoubleLeftMouseClickOnSAPElementworkflow), required: true);
            var __workflow_sAPGlobalDoubleLeftMouseClickOnSAPElementsetElementWindowTopMost = WorkflowExpression.Compile(sAPGlobalDoubleLeftMouseClickOnSAPElementsetElementWindowTopMost, nameof(sAPGlobalDoubleLeftMouseClickOnSAPElementsetElementWindowTopMost), required: false);
            var __workflow_sAPGlobalDoubleLeftMouseClickOnSAPElementbringElementWindowToFront = WorkflowExpression.Compile(sAPGlobalDoubleLeftMouseClickOnSAPElementbringElementWindowToFront, nameof(sAPGlobalDoubleLeftMouseClickOnSAPElementbringElementWindowToFront), required: false);
            var __workflow_sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleWindow = WorkflowExpression.Compile(sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleWindow, nameof(sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleWindow), required: false);
            var __workflow_sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent = WorkflowExpression.Compile(sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent, nameof(sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent), required: false);
            var __workflow_sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleDelay = WorkflowExpression.Compile(sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleDelay, nameof(sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleDelay), required: false);
            var __workflow_sAPGlobalDoubleLeftMouseClickOnSAPElementclickOffsetX = WorkflowExpression.Compile(sAPGlobalDoubleLeftMouseClickOnSAPElementclickOffsetX, nameof(sAPGlobalDoubleLeftMouseClickOnSAPElementclickOffsetX), required: false);
            var __workflow_sAPGlobalDoubleLeftMouseClickOnSAPElementclickOffsetY = WorkflowExpression.Compile(sAPGlobalDoubleLeftMouseClickOnSAPElementclickOffsetY, nameof(sAPGlobalDoubleLeftMouseClickOnSAPElementclickOffsetY), required: false);
            var __workflow_sAPGlobalDoubleLeftMouseClickOnSAPElementoffsetRelativeTo = WorkflowExpression.Compile(sAPGlobalDoubleLeftMouseClickOnSAPElementoffsetRelativeTo, nameof(sAPGlobalDoubleLeftMouseClickOnSAPElementoffsetRelativeTo), required: false);
            var __workflow_sAPGlobalDoubleLeftMouseClickOnSAPElementdoubleClickDelayInMilliseconds = WorkflowExpression.Compile(sAPGlobalDoubleLeftMouseClickOnSAPElementdoubleClickDelayInMilliseconds, nameof(sAPGlobalDoubleLeftMouseClickOnSAPElementdoubleClickDelayInMilliseconds), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGlobalDoubleLeftMouseClickOnSAPElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGlobalDoubleLeftMouseClickOnSAPElement = new JObject();
                var sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount = 0;
                sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount++;
                sAPGlobalDoubleLeftMouseClickOnSAPElement["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalDoubleLeftMouseClickOnSAPElementsearchSAPElementId);
                if (__workflow_sAPGlobalDoubleLeftMouseClickOnSAPElementsetElementWindowTopMost != null)
                {
                    if (__workflow_sAPGlobalDoubleLeftMouseClickOnSAPElementsetElementWindowTopMost != null)
                    {
                        sAPGlobalDoubleLeftMouseClickOnSAPElement["SetElementWindowTopMost"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalDoubleLeftMouseClickOnSAPElementsetElementWindowTopMost);
                        sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount++;
                    }

                    sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalDoubleLeftMouseClickOnSAPElement["SetElementWindowTopMost"] = false;
                    sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount++;
                }

                if (__workflow_sAPGlobalDoubleLeftMouseClickOnSAPElementbringElementWindowToFront != null)
                {
                    if (__workflow_sAPGlobalDoubleLeftMouseClickOnSAPElementbringElementWindowToFront != null)
                    {
                        sAPGlobalDoubleLeftMouseClickOnSAPElement["BringElementWindowToFront"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalDoubleLeftMouseClickOnSAPElementbringElementWindowToFront);
                        sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount++;
                    }

                    sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalDoubleLeftMouseClickOnSAPElement["BringElementWindowToFront"] = false;
                    sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount++;
                }

                if (__workflow_sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleWindow != null)
                {
                    if (__workflow_sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleWindow != null)
                    {
                        sAPGlobalDoubleLeftMouseClickOnSAPElement["ToggleWindow"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleWindow);
                        sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount++;
                    }

                    sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalDoubleLeftMouseClickOnSAPElement["ToggleWindow"] = true;
                    sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount++;
                }

                if (__workflow_sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent != null)
                {
                    if (__workflow_sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent != null)
                    {
                        sAPGlobalDoubleLeftMouseClickOnSAPElement["ToggleUsesGlobalLeftMouseClickAgent"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent);
                        sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount++;
                    }

                    sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalDoubleLeftMouseClickOnSAPElement["ToggleUsesGlobalLeftMouseClickAgent"] = true;
                    sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount++;
                }

                if (__workflow_sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleDelay != null)
                {
                    if (__workflow_sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleDelay != null)
                    {
                        sAPGlobalDoubleLeftMouseClickOnSAPElement["ToggleDelay"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleDelay);
                        sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount++;
                    }

                    sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalDoubleLeftMouseClickOnSAPElement["ToggleDelay"] = 0.5;
                    sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount++;
                }

                if (__workflow_sAPGlobalDoubleLeftMouseClickOnSAPElementclickOffsetX != null)
                {
                    if (__workflow_sAPGlobalDoubleLeftMouseClickOnSAPElementclickOffsetX != null)
                    {
                        sAPGlobalDoubleLeftMouseClickOnSAPElement["ClickOffsetX"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalDoubleLeftMouseClickOnSAPElementclickOffsetX);
                        sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount++;
                    }

                    sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalDoubleLeftMouseClickOnSAPElement["ClickOffsetX"] = 0;
                    sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount++;
                }

                if (__workflow_sAPGlobalDoubleLeftMouseClickOnSAPElementclickOffsetY != null)
                {
                    if (__workflow_sAPGlobalDoubleLeftMouseClickOnSAPElementclickOffsetY != null)
                    {
                        sAPGlobalDoubleLeftMouseClickOnSAPElement["ClickOffsetY"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalDoubleLeftMouseClickOnSAPElementclickOffsetY);
                        sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount++;
                    }

                    sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalDoubleLeftMouseClickOnSAPElement["ClickOffsetY"] = 0;
                    sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount++;
                }

                if (__workflow_sAPGlobalDoubleLeftMouseClickOnSAPElementoffsetRelativeTo != null)
                {
                    sAPGlobalDoubleLeftMouseClickOnSAPElement["OffsetRelativeTo"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalDoubleLeftMouseClickOnSAPElementoffsetRelativeTo);
                    sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount++;
                }

                if (__workflow_sAPGlobalDoubleLeftMouseClickOnSAPElementdoubleClickDelayInMilliseconds != null)
                {
                    if (__workflow_sAPGlobalDoubleLeftMouseClickOnSAPElementdoubleClickDelayInMilliseconds != null)
                    {
                        sAPGlobalDoubleLeftMouseClickOnSAPElement["DoubleClickDelayInMilliseconds"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalDoubleLeftMouseClickOnSAPElementdoubleClickDelayInMilliseconds);
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
                sAPGlobalDoubleLeftMouseClickOnSAPElement["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalDoubleLeftMouseClickOnSAPElementworkflow);
                if (sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount > 0)
                {
                    callPayload.Body = sAPGlobalDoubleLeftMouseClickOnSAPElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPGlobalInputTextIntoSAPElement(Expression<Func<string>> sAPGlobalInputTextIntoSAPElementsearchSAPElementId, Expression<Func<string>> sAPGlobalInputTextIntoSAPElementworkflow, Expression<Func<bool>> sAPGlobalInputTextIntoSAPElementsetElementWindowTopMost = null, Expression<Func<bool>> sAPGlobalInputTextIntoSAPElementbringElementWindowToFront = null, Expression<Func<bool>> sAPGlobalInputTextIntoSAPElementtoggleWindow = null, Expression<Func<bool>> sAPGlobalInputTextIntoSAPElementtoggleUsesGlobalLeftMouseClickAgent = null, Expression<Func<double>> sAPGlobalInputTextIntoSAPElementtoggleDelay = null, Expression<Func<bool>> sAPGlobalInputTextIntoSAPElementglobalMouseClickOnElement = null, Expression<Func<bool>> sAPGlobalInputTextIntoSAPElementreplaceExistingValueUsingDoubleClickDelete = null, Expression<Func<bool>> sAPGlobalInputTextIntoSAPElementreplaceExistingValueUsingCTRLADelete = null, Expression<Func<string>> sAPGlobalInputTextIntoSAPElementtextToInput = null, Expression<Func<bool>> sAPGlobalInputTextIntoSAPElementsendKeyEvents = null, Expression<Func<int>> sAPGlobalInputTextIntoSAPElementkeyIntervalInMilliseconds = null, Expression<Func<int>> sAPGlobalInputTextIntoSAPElementdoubleClickIntervalInMilliseconds = null, Expression<Func<bool>> sAPGlobalInputTextIntoSAPElementdontInterpretSymbols = null)
        {
            var __workflow_sAPGlobalInputTextIntoSAPElementsearchSAPElementId = WorkflowExpression.Compile(sAPGlobalInputTextIntoSAPElementsearchSAPElementId, nameof(sAPGlobalInputTextIntoSAPElementsearchSAPElementId), required: true);
            var __workflow_sAPGlobalInputTextIntoSAPElementworkflow = WorkflowExpression.Compile(sAPGlobalInputTextIntoSAPElementworkflow, nameof(sAPGlobalInputTextIntoSAPElementworkflow), required: true);
            var __workflow_sAPGlobalInputTextIntoSAPElementsetElementWindowTopMost = WorkflowExpression.Compile(sAPGlobalInputTextIntoSAPElementsetElementWindowTopMost, nameof(sAPGlobalInputTextIntoSAPElementsetElementWindowTopMost), required: false);
            var __workflow_sAPGlobalInputTextIntoSAPElementbringElementWindowToFront = WorkflowExpression.Compile(sAPGlobalInputTextIntoSAPElementbringElementWindowToFront, nameof(sAPGlobalInputTextIntoSAPElementbringElementWindowToFront), required: false);
            var __workflow_sAPGlobalInputTextIntoSAPElementtoggleWindow = WorkflowExpression.Compile(sAPGlobalInputTextIntoSAPElementtoggleWindow, nameof(sAPGlobalInputTextIntoSAPElementtoggleWindow), required: false);
            var __workflow_sAPGlobalInputTextIntoSAPElementtoggleUsesGlobalLeftMouseClickAgent = WorkflowExpression.Compile(sAPGlobalInputTextIntoSAPElementtoggleUsesGlobalLeftMouseClickAgent, nameof(sAPGlobalInputTextIntoSAPElementtoggleUsesGlobalLeftMouseClickAgent), required: false);
            var __workflow_sAPGlobalInputTextIntoSAPElementtoggleDelay = WorkflowExpression.Compile(sAPGlobalInputTextIntoSAPElementtoggleDelay, nameof(sAPGlobalInputTextIntoSAPElementtoggleDelay), required: false);
            var __workflow_sAPGlobalInputTextIntoSAPElementglobalMouseClickOnElement = WorkflowExpression.Compile(sAPGlobalInputTextIntoSAPElementglobalMouseClickOnElement, nameof(sAPGlobalInputTextIntoSAPElementglobalMouseClickOnElement), required: false);
            var __workflow_sAPGlobalInputTextIntoSAPElementreplaceExistingValueUsingDoubleClickDelete = WorkflowExpression.Compile(sAPGlobalInputTextIntoSAPElementreplaceExistingValueUsingDoubleClickDelete, nameof(sAPGlobalInputTextIntoSAPElementreplaceExistingValueUsingDoubleClickDelete), required: false);
            var __workflow_sAPGlobalInputTextIntoSAPElementreplaceExistingValueUsingCTRLADelete = WorkflowExpression.Compile(sAPGlobalInputTextIntoSAPElementreplaceExistingValueUsingCTRLADelete, nameof(sAPGlobalInputTextIntoSAPElementreplaceExistingValueUsingCTRLADelete), required: false);
            var __workflow_sAPGlobalInputTextIntoSAPElementtextToInput = WorkflowExpression.Compile(sAPGlobalInputTextIntoSAPElementtextToInput, nameof(sAPGlobalInputTextIntoSAPElementtextToInput), required: false);
            var __workflow_sAPGlobalInputTextIntoSAPElementsendKeyEvents = WorkflowExpression.Compile(sAPGlobalInputTextIntoSAPElementsendKeyEvents, nameof(sAPGlobalInputTextIntoSAPElementsendKeyEvents), required: false);
            var __workflow_sAPGlobalInputTextIntoSAPElementkeyIntervalInMilliseconds = WorkflowExpression.Compile(sAPGlobalInputTextIntoSAPElementkeyIntervalInMilliseconds, nameof(sAPGlobalInputTextIntoSAPElementkeyIntervalInMilliseconds), required: false);
            var __workflow_sAPGlobalInputTextIntoSAPElementdoubleClickIntervalInMilliseconds = WorkflowExpression.Compile(sAPGlobalInputTextIntoSAPElementdoubleClickIntervalInMilliseconds, nameof(sAPGlobalInputTextIntoSAPElementdoubleClickIntervalInMilliseconds), required: false);
            var __workflow_sAPGlobalInputTextIntoSAPElementdontInterpretSymbols = WorkflowExpression.Compile(sAPGlobalInputTextIntoSAPElementdontInterpretSymbols, nameof(sAPGlobalInputTextIntoSAPElementdontInterpretSymbols), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGlobalInputTextIntoSAPElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGlobalInputTextIntoSAPElement = new JObject();
                var sAPGlobalInputTextIntoSAPElementpropCount = 0;
                sAPGlobalInputTextIntoSAPElementpropCount++;
                sAPGlobalInputTextIntoSAPElement["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalInputTextIntoSAPElementsearchSAPElementId);
                if (__workflow_sAPGlobalInputTextIntoSAPElementsetElementWindowTopMost != null)
                {
                    if (__workflow_sAPGlobalInputTextIntoSAPElementsetElementWindowTopMost != null)
                    {
                        sAPGlobalInputTextIntoSAPElement["SetElementWindowTopMost"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalInputTextIntoSAPElementsetElementWindowTopMost);
                        sAPGlobalInputTextIntoSAPElementpropCount++;
                    }

                    sAPGlobalInputTextIntoSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalInputTextIntoSAPElement["SetElementWindowTopMost"] = false;
                    sAPGlobalInputTextIntoSAPElementpropCount++;
                }

                if (__workflow_sAPGlobalInputTextIntoSAPElementbringElementWindowToFront != null)
                {
                    if (__workflow_sAPGlobalInputTextIntoSAPElementbringElementWindowToFront != null)
                    {
                        sAPGlobalInputTextIntoSAPElement["BringElementWindowToFront"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalInputTextIntoSAPElementbringElementWindowToFront);
                        sAPGlobalInputTextIntoSAPElementpropCount++;
                    }

                    sAPGlobalInputTextIntoSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalInputTextIntoSAPElement["BringElementWindowToFront"] = false;
                    sAPGlobalInputTextIntoSAPElementpropCount++;
                }

                if (__workflow_sAPGlobalInputTextIntoSAPElementtoggleWindow != null)
                {
                    if (__workflow_sAPGlobalInputTextIntoSAPElementtoggleWindow != null)
                    {
                        sAPGlobalInputTextIntoSAPElement["ToggleWindow"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalInputTextIntoSAPElementtoggleWindow);
                        sAPGlobalInputTextIntoSAPElementpropCount++;
                    }

                    sAPGlobalInputTextIntoSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalInputTextIntoSAPElement["ToggleWindow"] = true;
                    sAPGlobalInputTextIntoSAPElementpropCount++;
                }

                if (__workflow_sAPGlobalInputTextIntoSAPElementtoggleUsesGlobalLeftMouseClickAgent != null)
                {
                    if (__workflow_sAPGlobalInputTextIntoSAPElementtoggleUsesGlobalLeftMouseClickAgent != null)
                    {
                        sAPGlobalInputTextIntoSAPElement["ToggleUsesGlobalLeftMouseClickAgent"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalInputTextIntoSAPElementtoggleUsesGlobalLeftMouseClickAgent);
                        sAPGlobalInputTextIntoSAPElementpropCount++;
                    }

                    sAPGlobalInputTextIntoSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalInputTextIntoSAPElement["ToggleUsesGlobalLeftMouseClickAgent"] = true;
                    sAPGlobalInputTextIntoSAPElementpropCount++;
                }

                if (__workflow_sAPGlobalInputTextIntoSAPElementtoggleDelay != null)
                {
                    if (__workflow_sAPGlobalInputTextIntoSAPElementtoggleDelay != null)
                    {
                        sAPGlobalInputTextIntoSAPElement["ToggleDelay"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalInputTextIntoSAPElementtoggleDelay);
                        sAPGlobalInputTextIntoSAPElementpropCount++;
                    }

                    sAPGlobalInputTextIntoSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalInputTextIntoSAPElement["ToggleDelay"] = 0.5;
                    sAPGlobalInputTextIntoSAPElementpropCount++;
                }

                if (__workflow_sAPGlobalInputTextIntoSAPElementglobalMouseClickOnElement != null)
                {
                    if (__workflow_sAPGlobalInputTextIntoSAPElementglobalMouseClickOnElement != null)
                    {
                        sAPGlobalInputTextIntoSAPElement["GlobalMouseClickOnElement"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalInputTextIntoSAPElementglobalMouseClickOnElement);
                        sAPGlobalInputTextIntoSAPElementpropCount++;
                    }

                    sAPGlobalInputTextIntoSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalInputTextIntoSAPElement["GlobalMouseClickOnElement"] = true;
                    sAPGlobalInputTextIntoSAPElementpropCount++;
                }

                if (__workflow_sAPGlobalInputTextIntoSAPElementreplaceExistingValueUsingDoubleClickDelete != null)
                {
                    if (__workflow_sAPGlobalInputTextIntoSAPElementreplaceExistingValueUsingDoubleClickDelete != null)
                    {
                        sAPGlobalInputTextIntoSAPElement["ReplaceExistingValueUsingDoubleClickDelete"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalInputTextIntoSAPElementreplaceExistingValueUsingDoubleClickDelete);
                        sAPGlobalInputTextIntoSAPElementpropCount++;
                    }

                    sAPGlobalInputTextIntoSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalInputTextIntoSAPElement["ReplaceExistingValueUsingDoubleClickDelete"] = false;
                    sAPGlobalInputTextIntoSAPElementpropCount++;
                }

                if (__workflow_sAPGlobalInputTextIntoSAPElementreplaceExistingValueUsingCTRLADelete != null)
                {
                    if (__workflow_sAPGlobalInputTextIntoSAPElementreplaceExistingValueUsingCTRLADelete != null)
                    {
                        sAPGlobalInputTextIntoSAPElement["ReplaceExistingValueUsingCTRLADelete"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalInputTextIntoSAPElementreplaceExistingValueUsingCTRLADelete);
                        sAPGlobalInputTextIntoSAPElementpropCount++;
                    }

                    sAPGlobalInputTextIntoSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalInputTextIntoSAPElement["ReplaceExistingValueUsingCTRLADelete"] = false;
                    sAPGlobalInputTextIntoSAPElementpropCount++;
                }

                if (__workflow_sAPGlobalInputTextIntoSAPElementtextToInput != null)
                {
                    sAPGlobalInputTextIntoSAPElement["TextToInput"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalInputTextIntoSAPElementtextToInput);
                    sAPGlobalInputTextIntoSAPElementpropCount++;
                }

                if (__workflow_sAPGlobalInputTextIntoSAPElementsendKeyEvents != null)
                {
                    if (__workflow_sAPGlobalInputTextIntoSAPElementsendKeyEvents != null)
                    {
                        sAPGlobalInputTextIntoSAPElement["SendKeyEvents"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalInputTextIntoSAPElementsendKeyEvents);
                        sAPGlobalInputTextIntoSAPElementpropCount++;
                    }

                    sAPGlobalInputTextIntoSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalInputTextIntoSAPElement["SendKeyEvents"] = false;
                    sAPGlobalInputTextIntoSAPElementpropCount++;
                }

                if (__workflow_sAPGlobalInputTextIntoSAPElementkeyIntervalInMilliseconds != null)
                {
                    if (__workflow_sAPGlobalInputTextIntoSAPElementkeyIntervalInMilliseconds != null)
                    {
                        sAPGlobalInputTextIntoSAPElement["KeyIntervalInMilliseconds"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalInputTextIntoSAPElementkeyIntervalInMilliseconds);
                        sAPGlobalInputTextIntoSAPElementpropCount++;
                    }

                    sAPGlobalInputTextIntoSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalInputTextIntoSAPElement["KeyIntervalInMilliseconds"] = 10;
                    sAPGlobalInputTextIntoSAPElementpropCount++;
                }

                if (__workflow_sAPGlobalInputTextIntoSAPElementdoubleClickIntervalInMilliseconds != null)
                {
                    if (__workflow_sAPGlobalInputTextIntoSAPElementdoubleClickIntervalInMilliseconds != null)
                    {
                        sAPGlobalInputTextIntoSAPElement["DoubleClickIntervalInMilliseconds"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalInputTextIntoSAPElementdoubleClickIntervalInMilliseconds);
                        sAPGlobalInputTextIntoSAPElementpropCount++;
                    }

                    sAPGlobalInputTextIntoSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalInputTextIntoSAPElement["DoubleClickIntervalInMilliseconds"] = 10;
                    sAPGlobalInputTextIntoSAPElementpropCount++;
                }

                if (__workflow_sAPGlobalInputTextIntoSAPElementdontInterpretSymbols != null)
                {
                    if (__workflow_sAPGlobalInputTextIntoSAPElementdontInterpretSymbols != null)
                    {
                        sAPGlobalInputTextIntoSAPElement["DontInterpretSymbols"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalInputTextIntoSAPElementdontInterpretSymbols);
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
                sAPGlobalInputTextIntoSAPElement["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalInputTextIntoSAPElementworkflow);
                if (sAPGlobalInputTextIntoSAPElementpropCount > 0)
                {
                    callPayload.Body = sAPGlobalInputTextIntoSAPElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPGlobalInputPasswordIntoSAPElement(Expression<Func<string>> sAPGlobalInputPasswordIntoSAPElementsearchSAPElementId, Expression<Func<string>> sAPGlobalInputPasswordIntoSAPElementpasswordToInput, Expression<Func<string>> sAPGlobalInputPasswordIntoSAPElementworkflow, Expression<Func<bool>> sAPGlobalInputPasswordIntoSAPElementsetElementWindowTopMost = null, Expression<Func<bool>> sAPGlobalInputPasswordIntoSAPElementbringElementWindowToFront = null, Expression<Func<bool>> sAPGlobalInputPasswordIntoSAPElementtoggleWindow = null, Expression<Func<bool>> sAPGlobalInputPasswordIntoSAPElementtoggleUsesGlobalLeftMouseClickAgent = null, Expression<Func<double>> sAPGlobalInputPasswordIntoSAPElementtoggleDelay = null, Expression<Func<bool>> sAPGlobalInputPasswordIntoSAPElementglobalMouseClickOnElement = null, Expression<Func<bool>> sAPGlobalInputPasswordIntoSAPElementreplaceExistingValueUsingDoubleClickDelete = null, Expression<Func<bool>> sAPGlobalInputPasswordIntoSAPElementreplaceExistingValueUsingCTRLADelete = null, Expression<Func<bool>> sAPGlobalInputPasswordIntoSAPElementsendKeyEvents = null, Expression<Func<int>> sAPGlobalInputPasswordIntoSAPElementkeyIntervalInMilliseconds = null, Expression<Func<int>> sAPGlobalInputPasswordIntoSAPElementdoubleClickIntervalInMilliseconds = null, Expression<Func<bool>> sAPGlobalInputPasswordIntoSAPElementdontInterpretSymbols = null)
        {
            var __workflow_sAPGlobalInputPasswordIntoSAPElementsearchSAPElementId = WorkflowExpression.Compile(sAPGlobalInputPasswordIntoSAPElementsearchSAPElementId, nameof(sAPGlobalInputPasswordIntoSAPElementsearchSAPElementId), required: true);
            var __workflow_sAPGlobalInputPasswordIntoSAPElementpasswordToInput = WorkflowExpression.Compile(sAPGlobalInputPasswordIntoSAPElementpasswordToInput, nameof(sAPGlobalInputPasswordIntoSAPElementpasswordToInput), required: true);
            var __workflow_sAPGlobalInputPasswordIntoSAPElementworkflow = WorkflowExpression.Compile(sAPGlobalInputPasswordIntoSAPElementworkflow, nameof(sAPGlobalInputPasswordIntoSAPElementworkflow), required: true);
            var __workflow_sAPGlobalInputPasswordIntoSAPElementsetElementWindowTopMost = WorkflowExpression.Compile(sAPGlobalInputPasswordIntoSAPElementsetElementWindowTopMost, nameof(sAPGlobalInputPasswordIntoSAPElementsetElementWindowTopMost), required: false);
            var __workflow_sAPGlobalInputPasswordIntoSAPElementbringElementWindowToFront = WorkflowExpression.Compile(sAPGlobalInputPasswordIntoSAPElementbringElementWindowToFront, nameof(sAPGlobalInputPasswordIntoSAPElementbringElementWindowToFront), required: false);
            var __workflow_sAPGlobalInputPasswordIntoSAPElementtoggleWindow = WorkflowExpression.Compile(sAPGlobalInputPasswordIntoSAPElementtoggleWindow, nameof(sAPGlobalInputPasswordIntoSAPElementtoggleWindow), required: false);
            var __workflow_sAPGlobalInputPasswordIntoSAPElementtoggleUsesGlobalLeftMouseClickAgent = WorkflowExpression.Compile(sAPGlobalInputPasswordIntoSAPElementtoggleUsesGlobalLeftMouseClickAgent, nameof(sAPGlobalInputPasswordIntoSAPElementtoggleUsesGlobalLeftMouseClickAgent), required: false);
            var __workflow_sAPGlobalInputPasswordIntoSAPElementtoggleDelay = WorkflowExpression.Compile(sAPGlobalInputPasswordIntoSAPElementtoggleDelay, nameof(sAPGlobalInputPasswordIntoSAPElementtoggleDelay), required: false);
            var __workflow_sAPGlobalInputPasswordIntoSAPElementglobalMouseClickOnElement = WorkflowExpression.Compile(sAPGlobalInputPasswordIntoSAPElementglobalMouseClickOnElement, nameof(sAPGlobalInputPasswordIntoSAPElementglobalMouseClickOnElement), required: false);
            var __workflow_sAPGlobalInputPasswordIntoSAPElementreplaceExistingValueUsingDoubleClickDelete = WorkflowExpression.Compile(sAPGlobalInputPasswordIntoSAPElementreplaceExistingValueUsingDoubleClickDelete, nameof(sAPGlobalInputPasswordIntoSAPElementreplaceExistingValueUsingDoubleClickDelete), required: false);
            var __workflow_sAPGlobalInputPasswordIntoSAPElementreplaceExistingValueUsingCTRLADelete = WorkflowExpression.Compile(sAPGlobalInputPasswordIntoSAPElementreplaceExistingValueUsingCTRLADelete, nameof(sAPGlobalInputPasswordIntoSAPElementreplaceExistingValueUsingCTRLADelete), required: false);
            var __workflow_sAPGlobalInputPasswordIntoSAPElementsendKeyEvents = WorkflowExpression.Compile(sAPGlobalInputPasswordIntoSAPElementsendKeyEvents, nameof(sAPGlobalInputPasswordIntoSAPElementsendKeyEvents), required: false);
            var __workflow_sAPGlobalInputPasswordIntoSAPElementkeyIntervalInMilliseconds = WorkflowExpression.Compile(sAPGlobalInputPasswordIntoSAPElementkeyIntervalInMilliseconds, nameof(sAPGlobalInputPasswordIntoSAPElementkeyIntervalInMilliseconds), required: false);
            var __workflow_sAPGlobalInputPasswordIntoSAPElementdoubleClickIntervalInMilliseconds = WorkflowExpression.Compile(sAPGlobalInputPasswordIntoSAPElementdoubleClickIntervalInMilliseconds, nameof(sAPGlobalInputPasswordIntoSAPElementdoubleClickIntervalInMilliseconds), required: false);
            var __workflow_sAPGlobalInputPasswordIntoSAPElementdontInterpretSymbols = WorkflowExpression.Compile(sAPGlobalInputPasswordIntoSAPElementdontInterpretSymbols, nameof(sAPGlobalInputPasswordIntoSAPElementdontInterpretSymbols), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGlobalInputPasswordIntoSAPElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGlobalInputPasswordIntoSAPElement = new JObject();
                var sAPGlobalInputPasswordIntoSAPElementpropCount = 0;
                sAPGlobalInputPasswordIntoSAPElementpropCount++;
                sAPGlobalInputPasswordIntoSAPElement["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalInputPasswordIntoSAPElementsearchSAPElementId);
                if (__workflow_sAPGlobalInputPasswordIntoSAPElementsetElementWindowTopMost != null)
                {
                    if (__workflow_sAPGlobalInputPasswordIntoSAPElementsetElementWindowTopMost != null)
                    {
                        sAPGlobalInputPasswordIntoSAPElement["SetElementWindowTopMost"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalInputPasswordIntoSAPElementsetElementWindowTopMost);
                        sAPGlobalInputPasswordIntoSAPElementpropCount++;
                    }

                    sAPGlobalInputPasswordIntoSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalInputPasswordIntoSAPElement["SetElementWindowTopMost"] = false;
                    sAPGlobalInputPasswordIntoSAPElementpropCount++;
                }

                if (__workflow_sAPGlobalInputPasswordIntoSAPElementbringElementWindowToFront != null)
                {
                    if (__workflow_sAPGlobalInputPasswordIntoSAPElementbringElementWindowToFront != null)
                    {
                        sAPGlobalInputPasswordIntoSAPElement["BringElementWindowToFront"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalInputPasswordIntoSAPElementbringElementWindowToFront);
                        sAPGlobalInputPasswordIntoSAPElementpropCount++;
                    }

                    sAPGlobalInputPasswordIntoSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalInputPasswordIntoSAPElement["BringElementWindowToFront"] = false;
                    sAPGlobalInputPasswordIntoSAPElementpropCount++;
                }

                if (__workflow_sAPGlobalInputPasswordIntoSAPElementtoggleWindow != null)
                {
                    if (__workflow_sAPGlobalInputPasswordIntoSAPElementtoggleWindow != null)
                    {
                        sAPGlobalInputPasswordIntoSAPElement["ToggleWindow"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalInputPasswordIntoSAPElementtoggleWindow);
                        sAPGlobalInputPasswordIntoSAPElementpropCount++;
                    }

                    sAPGlobalInputPasswordIntoSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalInputPasswordIntoSAPElement["ToggleWindow"] = true;
                    sAPGlobalInputPasswordIntoSAPElementpropCount++;
                }

                if (__workflow_sAPGlobalInputPasswordIntoSAPElementtoggleUsesGlobalLeftMouseClickAgent != null)
                {
                    if (__workflow_sAPGlobalInputPasswordIntoSAPElementtoggleUsesGlobalLeftMouseClickAgent != null)
                    {
                        sAPGlobalInputPasswordIntoSAPElement["ToggleUsesGlobalLeftMouseClickAgent"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalInputPasswordIntoSAPElementtoggleUsesGlobalLeftMouseClickAgent);
                        sAPGlobalInputPasswordIntoSAPElementpropCount++;
                    }

                    sAPGlobalInputPasswordIntoSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalInputPasswordIntoSAPElement["ToggleUsesGlobalLeftMouseClickAgent"] = true;
                    sAPGlobalInputPasswordIntoSAPElementpropCount++;
                }

                if (__workflow_sAPGlobalInputPasswordIntoSAPElementtoggleDelay != null)
                {
                    if (__workflow_sAPGlobalInputPasswordIntoSAPElementtoggleDelay != null)
                    {
                        sAPGlobalInputPasswordIntoSAPElement["ToggleDelay"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalInputPasswordIntoSAPElementtoggleDelay);
                        sAPGlobalInputPasswordIntoSAPElementpropCount++;
                    }

                    sAPGlobalInputPasswordIntoSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalInputPasswordIntoSAPElement["ToggleDelay"] = 0.5;
                    sAPGlobalInputPasswordIntoSAPElementpropCount++;
                }

                if (__workflow_sAPGlobalInputPasswordIntoSAPElementglobalMouseClickOnElement != null)
                {
                    if (__workflow_sAPGlobalInputPasswordIntoSAPElementglobalMouseClickOnElement != null)
                    {
                        sAPGlobalInputPasswordIntoSAPElement["GlobalMouseClickOnElement"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalInputPasswordIntoSAPElementglobalMouseClickOnElement);
                        sAPGlobalInputPasswordIntoSAPElementpropCount++;
                    }

                    sAPGlobalInputPasswordIntoSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalInputPasswordIntoSAPElement["GlobalMouseClickOnElement"] = true;
                    sAPGlobalInputPasswordIntoSAPElementpropCount++;
                }

                if (__workflow_sAPGlobalInputPasswordIntoSAPElementreplaceExistingValueUsingDoubleClickDelete != null)
                {
                    if (__workflow_sAPGlobalInputPasswordIntoSAPElementreplaceExistingValueUsingDoubleClickDelete != null)
                    {
                        sAPGlobalInputPasswordIntoSAPElement["ReplaceExistingValueUsingDoubleClickDelete"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalInputPasswordIntoSAPElementreplaceExistingValueUsingDoubleClickDelete);
                        sAPGlobalInputPasswordIntoSAPElementpropCount++;
                    }

                    sAPGlobalInputPasswordIntoSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalInputPasswordIntoSAPElement["ReplaceExistingValueUsingDoubleClickDelete"] = false;
                    sAPGlobalInputPasswordIntoSAPElementpropCount++;
                }

                if (__workflow_sAPGlobalInputPasswordIntoSAPElementreplaceExistingValueUsingCTRLADelete != null)
                {
                    if (__workflow_sAPGlobalInputPasswordIntoSAPElementreplaceExistingValueUsingCTRLADelete != null)
                    {
                        sAPGlobalInputPasswordIntoSAPElement["ReplaceExistingValueUsingCTRLADelete"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalInputPasswordIntoSAPElementreplaceExistingValueUsingCTRLADelete);
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
                sAPGlobalInputPasswordIntoSAPElement["PasswordToInput"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalInputPasswordIntoSAPElementpasswordToInput);
                if (__workflow_sAPGlobalInputPasswordIntoSAPElementsendKeyEvents != null)
                {
                    if (__workflow_sAPGlobalInputPasswordIntoSAPElementsendKeyEvents != null)
                    {
                        sAPGlobalInputPasswordIntoSAPElement["SendKeyEvents"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalInputPasswordIntoSAPElementsendKeyEvents);
                        sAPGlobalInputPasswordIntoSAPElementpropCount++;
                    }

                    sAPGlobalInputPasswordIntoSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalInputPasswordIntoSAPElement["SendKeyEvents"] = false;
                    sAPGlobalInputPasswordIntoSAPElementpropCount++;
                }

                if (__workflow_sAPGlobalInputPasswordIntoSAPElementkeyIntervalInMilliseconds != null)
                {
                    if (__workflow_sAPGlobalInputPasswordIntoSAPElementkeyIntervalInMilliseconds != null)
                    {
                        sAPGlobalInputPasswordIntoSAPElement["KeyIntervalInMilliseconds"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalInputPasswordIntoSAPElementkeyIntervalInMilliseconds);
                        sAPGlobalInputPasswordIntoSAPElementpropCount++;
                    }

                    sAPGlobalInputPasswordIntoSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalInputPasswordIntoSAPElement["KeyIntervalInMilliseconds"] = 10;
                    sAPGlobalInputPasswordIntoSAPElementpropCount++;
                }

                if (__workflow_sAPGlobalInputPasswordIntoSAPElementdoubleClickIntervalInMilliseconds != null)
                {
                    if (__workflow_sAPGlobalInputPasswordIntoSAPElementdoubleClickIntervalInMilliseconds != null)
                    {
                        sAPGlobalInputPasswordIntoSAPElement["DoubleClickIntervalInMilliseconds"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalInputPasswordIntoSAPElementdoubleClickIntervalInMilliseconds);
                        sAPGlobalInputPasswordIntoSAPElementpropCount++;
                    }

                    sAPGlobalInputPasswordIntoSAPElementpropCount++;
                }
                else
                {
                    sAPGlobalInputPasswordIntoSAPElement["DoubleClickIntervalInMilliseconds"] = 10;
                    sAPGlobalInputPasswordIntoSAPElementpropCount++;
                }

                if (__workflow_sAPGlobalInputPasswordIntoSAPElementdontInterpretSymbols != null)
                {
                    if (__workflow_sAPGlobalInputPasswordIntoSAPElementdontInterpretSymbols != null)
                    {
                        sAPGlobalInputPasswordIntoSAPElement["DontInterpretSymbols"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalInputPasswordIntoSAPElementdontInterpretSymbols);
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
                sAPGlobalInputPasswordIntoSAPElement["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalInputPasswordIntoSAPElementworkflow);
                if (sAPGlobalInputPasswordIntoSAPElementpropCount > 0)
                {
                    callPayload.Body = sAPGlobalInputPasswordIntoSAPElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPSetListSelectionByName(Expression<Func<string>> sAPSetListSelectionByNamesearchSAPElementId, Expression<Func<string>> sAPSetListSelectionByNamelistItemName, Expression<Func<string>> sAPSetListSelectionByNameworkflow)
        {
            var __workflow_sAPSetListSelectionByNamesearchSAPElementId = WorkflowExpression.Compile(sAPSetListSelectionByNamesearchSAPElementId, nameof(sAPSetListSelectionByNamesearchSAPElementId), required: true);
            var __workflow_sAPSetListSelectionByNamelistItemName = WorkflowExpression.Compile(sAPSetListSelectionByNamelistItemName, nameof(sAPSetListSelectionByNamelistItemName), required: true);
            var __workflow_sAPSetListSelectionByNameworkflow = WorkflowExpression.Compile(sAPSetListSelectionByNameworkflow, nameof(sAPSetListSelectionByNameworkflow), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSetListSelectionByName";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPSetListSelectionByName = new JObject();
                var sAPSetListSelectionByNamepropCount = 0;
                sAPSetListSelectionByNamepropCount++;
                sAPSetListSelectionByName["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPSetListSelectionByNamesearchSAPElementId);
                sAPSetListSelectionByNamepropCount++;
                sAPSetListSelectionByName["ListItemName"] = ExpressionConverter.ConvertO(__workflow_sAPSetListSelectionByNamelistItemName);
                sAPSetListSelectionByNamepropCount++;
                sAPSetListSelectionByName["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPSetListSelectionByNameworkflow);
                if (sAPSetListSelectionByNamepropCount > 0)
                {
                    callPayload.Body = sAPSetListSelectionByName;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPSetListSelectionByKey(Expression<Func<string>> sAPSetListSelectionByKeysearchSAPElementId, Expression<Func<string>> sAPSetListSelectionByKeylistItemKey, Expression<Func<string>> sAPSetListSelectionByKeyworkflow)
        {
            var __workflow_sAPSetListSelectionByKeysearchSAPElementId = WorkflowExpression.Compile(sAPSetListSelectionByKeysearchSAPElementId, nameof(sAPSetListSelectionByKeysearchSAPElementId), required: true);
            var __workflow_sAPSetListSelectionByKeylistItemKey = WorkflowExpression.Compile(sAPSetListSelectionByKeylistItemKey, nameof(sAPSetListSelectionByKeylistItemKey), required: true);
            var __workflow_sAPSetListSelectionByKeyworkflow = WorkflowExpression.Compile(sAPSetListSelectionByKeyworkflow, nameof(sAPSetListSelectionByKeyworkflow), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSetListSelectionByKey";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPSetListSelectionByKey = new JObject();
                var sAPSetListSelectionByKeypropCount = 0;
                sAPSetListSelectionByKeypropCount++;
                sAPSetListSelectionByKey["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPSetListSelectionByKeysearchSAPElementId);
                sAPSetListSelectionByKeypropCount++;
                sAPSetListSelectionByKey["ListItemKey"] = ExpressionConverter.ConvertO(__workflow_sAPSetListSelectionByKeylistItemKey);
                sAPSetListSelectionByKeypropCount++;
                sAPSetListSelectionByKey["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPSetListSelectionByKeyworkflow);
                if (sAPSetListSelectionByKeypropCount > 0)
                {
                    callPayload.Body = sAPSetListSelectionByKey;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetListSelectionElementItemsResponse, ApiConnectionActionConfiguration> SAPGetListSelectionElementItems(Expression<Func<string>> sAPGetListSelectionElementItemssearchSAPElementId, Expression<Func<string>> sAPGetListSelectionElementItemsworkflow)
        {
            var __workflow_sAPGetListSelectionElementItemssearchSAPElementId = WorkflowExpression.Compile(sAPGetListSelectionElementItemssearchSAPElementId, nameof(sAPGetListSelectionElementItemssearchSAPElementId), required: true);
            var __workflow_sAPGetListSelectionElementItemsworkflow = WorkflowExpression.Compile(sAPGetListSelectionElementItemsworkflow, nameof(sAPGetListSelectionElementItemsworkflow), required: true);
            return new DeferredBodyAction<SAPGetListSelectionElementItemsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetListSelectionElementItems";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGetListSelectionElementItems = new JObject();
                var sAPGetListSelectionElementItemspropCount = 0;
                sAPGetListSelectionElementItemspropCount++;
                sAPGetListSelectionElementItems["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPGetListSelectionElementItemssearchSAPElementId);
                sAPGetListSelectionElementItemspropCount++;
                sAPGetListSelectionElementItems["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPGetListSelectionElementItemsworkflow);
                if (sAPGetListSelectionElementItemspropCount > 0)
                {
                    callPayload.Body = sAPGetListSelectionElementItems;
                }

                return new ApiConnectionAction<SAPGetListSelectionElementItemsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetAllChildSAPElementPropertiesResponse, ApiConnectionActionConfiguration> SAPGetAllChildSAPElementProperties(Expression<Func<string>> sAPGetAllChildSAPElementPropertiessearchSAPElementId, Expression<Func<string>> sAPGetAllChildSAPElementPropertiesworkflow, Expression<Func<int>> sAPGetAllChildSAPElementPropertiesfirstItemToReturn = null, Expression<Func<int>> sAPGetAllChildSAPElementPropertiesmaxItemsToReturn = null, Expression<Func<string>> sAPGetAllChildSAPElementPropertiessearchSAPElementType = null, Expression<Func<int>> sAPGetAllChildSAPElementPropertiesmaxTextLength = null)
        {
            var __workflow_sAPGetAllChildSAPElementPropertiessearchSAPElementId = WorkflowExpression.Compile(sAPGetAllChildSAPElementPropertiessearchSAPElementId, nameof(sAPGetAllChildSAPElementPropertiessearchSAPElementId), required: true);
            var __workflow_sAPGetAllChildSAPElementPropertiesworkflow = WorkflowExpression.Compile(sAPGetAllChildSAPElementPropertiesworkflow, nameof(sAPGetAllChildSAPElementPropertiesworkflow), required: true);
            var __workflow_sAPGetAllChildSAPElementPropertiesfirstItemToReturn = WorkflowExpression.Compile(sAPGetAllChildSAPElementPropertiesfirstItemToReturn, nameof(sAPGetAllChildSAPElementPropertiesfirstItemToReturn), required: false);
            var __workflow_sAPGetAllChildSAPElementPropertiesmaxItemsToReturn = WorkflowExpression.Compile(sAPGetAllChildSAPElementPropertiesmaxItemsToReturn, nameof(sAPGetAllChildSAPElementPropertiesmaxItemsToReturn), required: false);
            var __workflow_sAPGetAllChildSAPElementPropertiessearchSAPElementType = WorkflowExpression.Compile(sAPGetAllChildSAPElementPropertiessearchSAPElementType, nameof(sAPGetAllChildSAPElementPropertiessearchSAPElementType), required: false);
            var __workflow_sAPGetAllChildSAPElementPropertiesmaxTextLength = WorkflowExpression.Compile(sAPGetAllChildSAPElementPropertiesmaxTextLength, nameof(sAPGetAllChildSAPElementPropertiesmaxTextLength), required: false);
            return new DeferredBodyAction<SAPGetAllChildSAPElementPropertiesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetAllChildSAPElementProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGetAllChildSAPElementProperties = new JObject();
                var sAPGetAllChildSAPElementPropertiespropCount = 0;
                sAPGetAllChildSAPElementPropertiespropCount++;
                sAPGetAllChildSAPElementProperties["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPGetAllChildSAPElementPropertiessearchSAPElementId);
                if (__workflow_sAPGetAllChildSAPElementPropertiesfirstItemToReturn != null)
                {
                    if (__workflow_sAPGetAllChildSAPElementPropertiesfirstItemToReturn != null)
                    {
                        sAPGetAllChildSAPElementProperties["FirstItemToReturn"] = ExpressionConverter.ConvertO(__workflow_sAPGetAllChildSAPElementPropertiesfirstItemToReturn);
                        sAPGetAllChildSAPElementPropertiespropCount++;
                    }

                    sAPGetAllChildSAPElementPropertiespropCount++;
                }
                else
                {
                    sAPGetAllChildSAPElementProperties["FirstItemToReturn"] = 1;
                    sAPGetAllChildSAPElementPropertiespropCount++;
                }

                if (__workflow_sAPGetAllChildSAPElementPropertiesmaxItemsToReturn != null)
                {
                    if (__workflow_sAPGetAllChildSAPElementPropertiesmaxItemsToReturn != null)
                    {
                        sAPGetAllChildSAPElementProperties["MaxItemsToReturn"] = ExpressionConverter.ConvertO(__workflow_sAPGetAllChildSAPElementPropertiesmaxItemsToReturn);
                        sAPGetAllChildSAPElementPropertiespropCount++;
                    }

                    sAPGetAllChildSAPElementPropertiespropCount++;
                }
                else
                {
                    sAPGetAllChildSAPElementProperties["MaxItemsToReturn"] = 0;
                    sAPGetAllChildSAPElementPropertiespropCount++;
                }

                if (__workflow_sAPGetAllChildSAPElementPropertiessearchSAPElementType != null)
                {
                    sAPGetAllChildSAPElementProperties["SearchSAPElementType"] = ExpressionConverter.ConvertO(__workflow_sAPGetAllChildSAPElementPropertiessearchSAPElementType);
                    sAPGetAllChildSAPElementPropertiespropCount++;
                }

                if (__workflow_sAPGetAllChildSAPElementPropertiesmaxTextLength != null)
                {
                    if (__workflow_sAPGetAllChildSAPElementPropertiesmaxTextLength != null)
                    {
                        sAPGetAllChildSAPElementProperties["MaxTextLength"] = ExpressionConverter.ConvertO(__workflow_sAPGetAllChildSAPElementPropertiesmaxTextLength);
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
                sAPGetAllChildSAPElementProperties["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPGetAllChildSAPElementPropertiesworkflow);
                if (sAPGetAllChildSAPElementPropertiespropCount > 0)
                {
                    callPayload.Body = sAPGetAllChildSAPElementProperties;
                }

                return new ApiConnectionAction<SAPGetAllChildSAPElementPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetSAPSessionTopLevelSAPElementPropertiesResponse, ApiConnectionActionConfiguration> SAPGetSAPSessionTopLevelSAPElementProperties(Expression<Func<string>> sAPGetSAPSessionTopLevelSAPElementPropertiesworkflow, Expression<Func<int>> sAPGetSAPSessionTopLevelSAPElementPropertiesfirstItemToReturn = null, Expression<Func<int>> sAPGetSAPSessionTopLevelSAPElementPropertiesmaxItemsToReturn = null, Expression<Func<string>> sAPGetSAPSessionTopLevelSAPElementPropertiessearchSAPElementType = null, Expression<Func<int>> sAPGetSAPSessionTopLevelSAPElementPropertiesmaxTextLength = null)
        {
            var __workflow_sAPGetSAPSessionTopLevelSAPElementPropertiesworkflow = WorkflowExpression.Compile(sAPGetSAPSessionTopLevelSAPElementPropertiesworkflow, nameof(sAPGetSAPSessionTopLevelSAPElementPropertiesworkflow), required: true);
            var __workflow_sAPGetSAPSessionTopLevelSAPElementPropertiesfirstItemToReturn = WorkflowExpression.Compile(sAPGetSAPSessionTopLevelSAPElementPropertiesfirstItemToReturn, nameof(sAPGetSAPSessionTopLevelSAPElementPropertiesfirstItemToReturn), required: false);
            var __workflow_sAPGetSAPSessionTopLevelSAPElementPropertiesmaxItemsToReturn = WorkflowExpression.Compile(sAPGetSAPSessionTopLevelSAPElementPropertiesmaxItemsToReturn, nameof(sAPGetSAPSessionTopLevelSAPElementPropertiesmaxItemsToReturn), required: false);
            var __workflow_sAPGetSAPSessionTopLevelSAPElementPropertiessearchSAPElementType = WorkflowExpression.Compile(sAPGetSAPSessionTopLevelSAPElementPropertiessearchSAPElementType, nameof(sAPGetSAPSessionTopLevelSAPElementPropertiessearchSAPElementType), required: false);
            var __workflow_sAPGetSAPSessionTopLevelSAPElementPropertiesmaxTextLength = WorkflowExpression.Compile(sAPGetSAPSessionTopLevelSAPElementPropertiesmaxTextLength, nameof(sAPGetSAPSessionTopLevelSAPElementPropertiesmaxTextLength), required: false);
            return new DeferredBodyAction<SAPGetSAPSessionTopLevelSAPElementPropertiesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetSAPSessionTopLevelSAPElementProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGetSAPSessionTopLevelSAPElementProperties = new JObject();
                var sAPGetSAPSessionTopLevelSAPElementPropertiespropCount = 0;
                if (__workflow_sAPGetSAPSessionTopLevelSAPElementPropertiesfirstItemToReturn != null)
                {
                    if (__workflow_sAPGetSAPSessionTopLevelSAPElementPropertiesfirstItemToReturn != null)
                    {
                        sAPGetSAPSessionTopLevelSAPElementProperties["FirstItemToReturn"] = ExpressionConverter.ConvertO(__workflow_sAPGetSAPSessionTopLevelSAPElementPropertiesfirstItemToReturn);
                        sAPGetSAPSessionTopLevelSAPElementPropertiespropCount++;
                    }

                    sAPGetSAPSessionTopLevelSAPElementPropertiespropCount++;
                }
                else
                {
                    sAPGetSAPSessionTopLevelSAPElementProperties["FirstItemToReturn"] = 1;
                    sAPGetSAPSessionTopLevelSAPElementPropertiespropCount++;
                }

                if (__workflow_sAPGetSAPSessionTopLevelSAPElementPropertiesmaxItemsToReturn != null)
                {
                    if (__workflow_sAPGetSAPSessionTopLevelSAPElementPropertiesmaxItemsToReturn != null)
                    {
                        sAPGetSAPSessionTopLevelSAPElementProperties["MaxItemsToReturn"] = ExpressionConverter.ConvertO(__workflow_sAPGetSAPSessionTopLevelSAPElementPropertiesmaxItemsToReturn);
                        sAPGetSAPSessionTopLevelSAPElementPropertiespropCount++;
                    }

                    sAPGetSAPSessionTopLevelSAPElementPropertiespropCount++;
                }
                else
                {
                    sAPGetSAPSessionTopLevelSAPElementProperties["MaxItemsToReturn"] = 0;
                    sAPGetSAPSessionTopLevelSAPElementPropertiespropCount++;
                }

                if (__workflow_sAPGetSAPSessionTopLevelSAPElementPropertiessearchSAPElementType != null)
                {
                    sAPGetSAPSessionTopLevelSAPElementProperties["SearchSAPElementType"] = ExpressionConverter.ConvertO(__workflow_sAPGetSAPSessionTopLevelSAPElementPropertiessearchSAPElementType);
                    sAPGetSAPSessionTopLevelSAPElementPropertiespropCount++;
                }

                if (__workflow_sAPGetSAPSessionTopLevelSAPElementPropertiesmaxTextLength != null)
                {
                    if (__workflow_sAPGetSAPSessionTopLevelSAPElementPropertiesmaxTextLength != null)
                    {
                        sAPGetSAPSessionTopLevelSAPElementProperties["MaxTextLength"] = ExpressionConverter.ConvertO(__workflow_sAPGetSAPSessionTopLevelSAPElementPropertiesmaxTextLength);
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
                sAPGetSAPSessionTopLevelSAPElementProperties["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPGetSAPSessionTopLevelSAPElementPropertiesworkflow);
                if (sAPGetSAPSessionTopLevelSAPElementPropertiespropCount > 0)
                {
                    callPayload.Body = sAPGetSAPSessionTopLevelSAPElementProperties;
                }

                return new ApiConnectionAction<SAPGetSAPSessionTopLevelSAPElementPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetSAPElementParentIdResponse, ApiConnectionActionConfiguration> SAPGetSAPElementParentId(Expression<Func<string>> sAPGetSAPElementParentIdsearchSAPElementId, Expression<Func<string>> sAPGetSAPElementParentIdworkflow)
        {
            var __workflow_sAPGetSAPElementParentIdsearchSAPElementId = WorkflowExpression.Compile(sAPGetSAPElementParentIdsearchSAPElementId, nameof(sAPGetSAPElementParentIdsearchSAPElementId), required: true);
            var __workflow_sAPGetSAPElementParentIdworkflow = WorkflowExpression.Compile(sAPGetSAPElementParentIdworkflow, nameof(sAPGetSAPElementParentIdworkflow), required: true);
            return new DeferredBodyAction<SAPGetSAPElementParentIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetSAPElementParentId";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGetSAPElementParentId = new JObject();
                var sAPGetSAPElementParentIdpropCount = 0;
                sAPGetSAPElementParentIdpropCount++;
                sAPGetSAPElementParentId["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPGetSAPElementParentIdsearchSAPElementId);
                sAPGetSAPElementParentIdpropCount++;
                sAPGetSAPElementParentId["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPGetSAPElementParentIdworkflow);
                if (sAPGetSAPElementParentIdpropCount > 0)
                {
                    callPayload.Body = sAPGetSAPElementParentId;
                }

                return new ApiConnectionAction<SAPGetSAPElementParentIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetElementPropertiesAsListResponse, ApiConnectionActionConfiguration> SAPGetElementPropertiesAsList(Expression<Func<string>> sAPGetElementPropertiesAsListsearchSAPElementId, Expression<Func<string>> sAPGetElementPropertiesAsListworkflow, Expression<Func<int>> sAPGetElementPropertiesAsListmaxTextLength = null)
        {
            var __workflow_sAPGetElementPropertiesAsListsearchSAPElementId = WorkflowExpression.Compile(sAPGetElementPropertiesAsListsearchSAPElementId, nameof(sAPGetElementPropertiesAsListsearchSAPElementId), required: true);
            var __workflow_sAPGetElementPropertiesAsListworkflow = WorkflowExpression.Compile(sAPGetElementPropertiesAsListworkflow, nameof(sAPGetElementPropertiesAsListworkflow), required: true);
            var __workflow_sAPGetElementPropertiesAsListmaxTextLength = WorkflowExpression.Compile(sAPGetElementPropertiesAsListmaxTextLength, nameof(sAPGetElementPropertiesAsListmaxTextLength), required: false);
            return new DeferredBodyAction<SAPGetElementPropertiesAsListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetElementPropertiesAsList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGetElementPropertiesAsList = new JObject();
                var sAPGetElementPropertiesAsListpropCount = 0;
                sAPGetElementPropertiesAsListpropCount++;
                sAPGetElementPropertiesAsList["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPGetElementPropertiesAsListsearchSAPElementId);
                if (__workflow_sAPGetElementPropertiesAsListmaxTextLength != null)
                {
                    if (__workflow_sAPGetElementPropertiesAsListmaxTextLength != null)
                    {
                        sAPGetElementPropertiesAsList["MaxTextLength"] = ExpressionConverter.ConvertO(__workflow_sAPGetElementPropertiesAsListmaxTextLength);
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
                sAPGetElementPropertiesAsList["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPGetElementPropertiesAsListworkflow);
                if (sAPGetElementPropertiesAsListpropCount > 0)
                {
                    callPayload.Body = sAPGetElementPropertiesAsList;
                }

                return new ApiConnectionAction<SAPGetElementPropertiesAsListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetSAPElementAtScreenCoordinateResponse, ApiConnectionActionConfiguration> SAPGetSAPElementAtScreenCoordinate(Expression<Func<int>> sAPGetSAPElementAtScreenCoordinatescreenX, Expression<Func<int>> sAPGetSAPElementAtScreenCoordinatescreenY, Expression<Func<string>> sAPGetSAPElementAtScreenCoordinateworkflow)
        {
            var __workflow_sAPGetSAPElementAtScreenCoordinatescreenX = WorkflowExpression.Compile(sAPGetSAPElementAtScreenCoordinatescreenX, nameof(sAPGetSAPElementAtScreenCoordinatescreenX), required: true);
            var __workflow_sAPGetSAPElementAtScreenCoordinatescreenY = WorkflowExpression.Compile(sAPGetSAPElementAtScreenCoordinatescreenY, nameof(sAPGetSAPElementAtScreenCoordinatescreenY), required: true);
            var __workflow_sAPGetSAPElementAtScreenCoordinateworkflow = WorkflowExpression.Compile(sAPGetSAPElementAtScreenCoordinateworkflow, nameof(sAPGetSAPElementAtScreenCoordinateworkflow), required: true);
            return new DeferredBodyAction<SAPGetSAPElementAtScreenCoordinateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetSAPElementAtScreenCoordinate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGetSAPElementAtScreenCoordinate = new JObject();
                var sAPGetSAPElementAtScreenCoordinatepropCount = 0;
                sAPGetSAPElementAtScreenCoordinatepropCount++;
                sAPGetSAPElementAtScreenCoordinate["ScreenX"] = ExpressionConverter.ConvertO(__workflow_sAPGetSAPElementAtScreenCoordinatescreenX);
                sAPGetSAPElementAtScreenCoordinatepropCount++;
                sAPGetSAPElementAtScreenCoordinate["ScreenY"] = ExpressionConverter.ConvertO(__workflow_sAPGetSAPElementAtScreenCoordinatescreenY);
                sAPGetSAPElementAtScreenCoordinatepropCount++;
                sAPGetSAPElementAtScreenCoordinate["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPGetSAPElementAtScreenCoordinateworkflow);
                if (sAPGetSAPElementAtScreenCoordinatepropCount > 0)
                {
                    callPayload.Body = sAPGetSAPElementAtScreenCoordinate;
                }

                return new ApiConnectionAction<SAPGetSAPElementAtScreenCoordinateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPOpenConnectionResponse, ApiConnectionActionConfiguration> SAPOpenConnection(Expression<Func<string>> sAPOpenConnectionworkflow, Expression<Func<string>> sAPOpenConnectionsAPConnectionDescription = null, Expression<Func<string>> sAPOpenConnectionsAPConnectionAddress = null, Expression<Func<bool>> sAPOpenConnectionconnectSynchronous = null, Expression<Func<bool>> sAPOpenConnectionconnectToSession = null)
        {
            var __workflow_sAPOpenConnectionworkflow = WorkflowExpression.Compile(sAPOpenConnectionworkflow, nameof(sAPOpenConnectionworkflow), required: true);
            var __workflow_sAPOpenConnectionsAPConnectionDescription = WorkflowExpression.Compile(sAPOpenConnectionsAPConnectionDescription, nameof(sAPOpenConnectionsAPConnectionDescription), required: false);
            var __workflow_sAPOpenConnectionsAPConnectionAddress = WorkflowExpression.Compile(sAPOpenConnectionsAPConnectionAddress, nameof(sAPOpenConnectionsAPConnectionAddress), required: false);
            var __workflow_sAPOpenConnectionconnectSynchronous = WorkflowExpression.Compile(sAPOpenConnectionconnectSynchronous, nameof(sAPOpenConnectionconnectSynchronous), required: false);
            var __workflow_sAPOpenConnectionconnectToSession = WorkflowExpression.Compile(sAPOpenConnectionconnectToSession, nameof(sAPOpenConnectionconnectToSession), required: false);
            return new DeferredBodyAction<SAPOpenConnectionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPOpenConnection";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPOpenConnection = new JObject();
                var sAPOpenConnectionpropCount = 0;
                if (__workflow_sAPOpenConnectionsAPConnectionDescription != null)
                {
                    sAPOpenConnection["SAPConnectionDescription"] = ExpressionConverter.ConvertO(__workflow_sAPOpenConnectionsAPConnectionDescription);
                    sAPOpenConnectionpropCount++;
                }

                if (__workflow_sAPOpenConnectionsAPConnectionAddress != null)
                {
                    sAPOpenConnection["SAPConnectionAddress"] = ExpressionConverter.ConvertO(__workflow_sAPOpenConnectionsAPConnectionAddress);
                    sAPOpenConnectionpropCount++;
                }

                if (__workflow_sAPOpenConnectionconnectSynchronous != null)
                {
                    if (__workflow_sAPOpenConnectionconnectSynchronous != null)
                    {
                        sAPOpenConnection["ConnectSynchronous"] = ExpressionConverter.ConvertO(__workflow_sAPOpenConnectionconnectSynchronous);
                        sAPOpenConnectionpropCount++;
                    }

                    sAPOpenConnectionpropCount++;
                }
                else
                {
                    sAPOpenConnection["ConnectSynchronous"] = true;
                    sAPOpenConnectionpropCount++;
                }

                if (__workflow_sAPOpenConnectionconnectToSession != null)
                {
                    if (__workflow_sAPOpenConnectionconnectToSession != null)
                    {
                        sAPOpenConnection["ConnectToSession"] = ExpressionConverter.ConvertO(__workflow_sAPOpenConnectionconnectToSession);
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
                sAPOpenConnection["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPOpenConnectionworkflow);
                if (sAPOpenConnectionpropCount > 0)
                {
                    callPayload.Body = sAPOpenConnection;
                }

                return new ApiConnectionAction<SAPOpenConnectionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetSAPTablePropertiesResponse, ApiConnectionActionConfiguration> SAPGetSAPTableProperties(Expression<Func<string>> sAPGetSAPTablePropertiessearchSAPElementId, Expression<Func<string>> sAPGetSAPTablePropertiesworkflow)
        {
            var __workflow_sAPGetSAPTablePropertiessearchSAPElementId = WorkflowExpression.Compile(sAPGetSAPTablePropertiessearchSAPElementId, nameof(sAPGetSAPTablePropertiessearchSAPElementId), required: true);
            var __workflow_sAPGetSAPTablePropertiesworkflow = WorkflowExpression.Compile(sAPGetSAPTablePropertiesworkflow, nameof(sAPGetSAPTablePropertiesworkflow), required: true);
            return new DeferredBodyAction<SAPGetSAPTablePropertiesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetSAPTableProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGetSAPTableProperties = new JObject();
                var sAPGetSAPTablePropertiespropCount = 0;
                sAPGetSAPTablePropertiespropCount++;
                sAPGetSAPTableProperties["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPGetSAPTablePropertiessearchSAPElementId);
                sAPGetSAPTablePropertiespropCount++;
                sAPGetSAPTableProperties["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPGetSAPTablePropertiesworkflow);
                if (sAPGetSAPTablePropertiespropCount > 0)
                {
                    callPayload.Body = sAPGetSAPTableProperties;
                }

                return new ApiConnectionAction<SAPGetSAPTablePropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetSAPTableVisibleCellTextContentsAtIndexResponse, ApiConnectionActionConfiguration> SAPGetSAPTableVisibleCellTextContentsAtIndex(Expression<Func<string>> sAPGetSAPTableVisibleCellTextContentsAtIndexsearchSAPElementId, Expression<Func<string>> sAPGetSAPTableVisibleCellTextContentsAtIndexworkflow, Expression<Func<int>> sAPGetSAPTableVisibleCellTextContentsAtIndexvisibleRowIndex = null, Expression<Func<int>> sAPGetSAPTableVisibleCellTextContentsAtIndexvisibleColumnIndex = null, Expression<Func<string>> sAPGetSAPTableVisibleCellTextContentsAtIndexcheckedElementValue = null)
        {
            var __workflow_sAPGetSAPTableVisibleCellTextContentsAtIndexsearchSAPElementId = WorkflowExpression.Compile(sAPGetSAPTableVisibleCellTextContentsAtIndexsearchSAPElementId, nameof(sAPGetSAPTableVisibleCellTextContentsAtIndexsearchSAPElementId), required: true);
            var __workflow_sAPGetSAPTableVisibleCellTextContentsAtIndexworkflow = WorkflowExpression.Compile(sAPGetSAPTableVisibleCellTextContentsAtIndexworkflow, nameof(sAPGetSAPTableVisibleCellTextContentsAtIndexworkflow), required: true);
            var __workflow_sAPGetSAPTableVisibleCellTextContentsAtIndexvisibleRowIndex = WorkflowExpression.Compile(sAPGetSAPTableVisibleCellTextContentsAtIndexvisibleRowIndex, nameof(sAPGetSAPTableVisibleCellTextContentsAtIndexvisibleRowIndex), required: false);
            var __workflow_sAPGetSAPTableVisibleCellTextContentsAtIndexvisibleColumnIndex = WorkflowExpression.Compile(sAPGetSAPTableVisibleCellTextContentsAtIndexvisibleColumnIndex, nameof(sAPGetSAPTableVisibleCellTextContentsAtIndexvisibleColumnIndex), required: false);
            var __workflow_sAPGetSAPTableVisibleCellTextContentsAtIndexcheckedElementValue = WorkflowExpression.Compile(sAPGetSAPTableVisibleCellTextContentsAtIndexcheckedElementValue, nameof(sAPGetSAPTableVisibleCellTextContentsAtIndexcheckedElementValue), required: false);
            return new DeferredBodyAction<SAPGetSAPTableVisibleCellTextContentsAtIndexResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetSAPTableVisibleCellTextContentsAtIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGetSAPTableVisibleCellTextContentsAtIndex = new JObject();
                var sAPGetSAPTableVisibleCellTextContentsAtIndexpropCount = 0;
                sAPGetSAPTableVisibleCellTextContentsAtIndexpropCount++;
                sAPGetSAPTableVisibleCellTextContentsAtIndex["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPGetSAPTableVisibleCellTextContentsAtIndexsearchSAPElementId);
                if (__workflow_sAPGetSAPTableVisibleCellTextContentsAtIndexvisibleRowIndex != null)
                {
                    if (__workflow_sAPGetSAPTableVisibleCellTextContentsAtIndexvisibleRowIndex != null)
                    {
                        sAPGetSAPTableVisibleCellTextContentsAtIndex["VisibleRowIndex"] = ExpressionConverter.ConvertO(__workflow_sAPGetSAPTableVisibleCellTextContentsAtIndexvisibleRowIndex);
                        sAPGetSAPTableVisibleCellTextContentsAtIndexpropCount++;
                    }

                    sAPGetSAPTableVisibleCellTextContentsAtIndexpropCount++;
                }
                else
                {
                    sAPGetSAPTableVisibleCellTextContentsAtIndex["VisibleRowIndex"] = 1;
                    sAPGetSAPTableVisibleCellTextContentsAtIndexpropCount++;
                }

                if (__workflow_sAPGetSAPTableVisibleCellTextContentsAtIndexvisibleColumnIndex != null)
                {
                    if (__workflow_sAPGetSAPTableVisibleCellTextContentsAtIndexvisibleColumnIndex != null)
                    {
                        sAPGetSAPTableVisibleCellTextContentsAtIndex["VisibleColumnIndex"] = ExpressionConverter.ConvertO(__workflow_sAPGetSAPTableVisibleCellTextContentsAtIndexvisibleColumnIndex);
                        sAPGetSAPTableVisibleCellTextContentsAtIndexpropCount++;
                    }

                    sAPGetSAPTableVisibleCellTextContentsAtIndexpropCount++;
                }
                else
                {
                    sAPGetSAPTableVisibleCellTextContentsAtIndex["VisibleColumnIndex"] = 1;
                    sAPGetSAPTableVisibleCellTextContentsAtIndexpropCount++;
                }

                if (__workflow_sAPGetSAPTableVisibleCellTextContentsAtIndexcheckedElementValue != null)
                {
                    if (__workflow_sAPGetSAPTableVisibleCellTextContentsAtIndexcheckedElementValue != null)
                    {
                        sAPGetSAPTableVisibleCellTextContentsAtIndex["CheckedElementValue"] = ExpressionConverter.ConvertO(__workflow_sAPGetSAPTableVisibleCellTextContentsAtIndexcheckedElementValue);
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
                sAPGetSAPTableVisibleCellTextContentsAtIndex["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPGetSAPTableVisibleCellTextContentsAtIndexworkflow);
                if (sAPGetSAPTableVisibleCellTextContentsAtIndexpropCount > 0)
                {
                    callPayload.Body = sAPGetSAPTableVisibleCellTextContentsAtIndex;
                }

                return new ApiConnectionAction<SAPGetSAPTableVisibleCellTextContentsAtIndexResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetSAPTableVisibleCellPropertiesAtIndexResponse, ApiConnectionActionConfiguration> SAPGetSAPTableVisibleCellPropertiesAtIndex(Expression<Func<string>> sAPGetSAPTableVisibleCellPropertiesAtIndexsearchSAPElementId, Expression<Func<string>> sAPGetSAPTableVisibleCellPropertiesAtIndexworkflow, Expression<Func<int>> sAPGetSAPTableVisibleCellPropertiesAtIndexvisibleRowIndex = null, Expression<Func<int>> sAPGetSAPTableVisibleCellPropertiesAtIndexvisibleColumnIndex = null)
        {
            var __workflow_sAPGetSAPTableVisibleCellPropertiesAtIndexsearchSAPElementId = WorkflowExpression.Compile(sAPGetSAPTableVisibleCellPropertiesAtIndexsearchSAPElementId, nameof(sAPGetSAPTableVisibleCellPropertiesAtIndexsearchSAPElementId), required: true);
            var __workflow_sAPGetSAPTableVisibleCellPropertiesAtIndexworkflow = WorkflowExpression.Compile(sAPGetSAPTableVisibleCellPropertiesAtIndexworkflow, nameof(sAPGetSAPTableVisibleCellPropertiesAtIndexworkflow), required: true);
            var __workflow_sAPGetSAPTableVisibleCellPropertiesAtIndexvisibleRowIndex = WorkflowExpression.Compile(sAPGetSAPTableVisibleCellPropertiesAtIndexvisibleRowIndex, nameof(sAPGetSAPTableVisibleCellPropertiesAtIndexvisibleRowIndex), required: false);
            var __workflow_sAPGetSAPTableVisibleCellPropertiesAtIndexvisibleColumnIndex = WorkflowExpression.Compile(sAPGetSAPTableVisibleCellPropertiesAtIndexvisibleColumnIndex, nameof(sAPGetSAPTableVisibleCellPropertiesAtIndexvisibleColumnIndex), required: false);
            return new DeferredBodyAction<SAPGetSAPTableVisibleCellPropertiesAtIndexResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetSAPTableVisibleCellPropertiesAtIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGetSAPTableVisibleCellPropertiesAtIndex = new JObject();
                var sAPGetSAPTableVisibleCellPropertiesAtIndexpropCount = 0;
                sAPGetSAPTableVisibleCellPropertiesAtIndexpropCount++;
                sAPGetSAPTableVisibleCellPropertiesAtIndex["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPGetSAPTableVisibleCellPropertiesAtIndexsearchSAPElementId);
                if (__workflow_sAPGetSAPTableVisibleCellPropertiesAtIndexvisibleRowIndex != null)
                {
                    if (__workflow_sAPGetSAPTableVisibleCellPropertiesAtIndexvisibleRowIndex != null)
                    {
                        sAPGetSAPTableVisibleCellPropertiesAtIndex["VisibleRowIndex"] = ExpressionConverter.ConvertO(__workflow_sAPGetSAPTableVisibleCellPropertiesAtIndexvisibleRowIndex);
                        sAPGetSAPTableVisibleCellPropertiesAtIndexpropCount++;
                    }

                    sAPGetSAPTableVisibleCellPropertiesAtIndexpropCount++;
                }
                else
                {
                    sAPGetSAPTableVisibleCellPropertiesAtIndex["VisibleRowIndex"] = 1;
                    sAPGetSAPTableVisibleCellPropertiesAtIndexpropCount++;
                }

                if (__workflow_sAPGetSAPTableVisibleCellPropertiesAtIndexvisibleColumnIndex != null)
                {
                    if (__workflow_sAPGetSAPTableVisibleCellPropertiesAtIndexvisibleColumnIndex != null)
                    {
                        sAPGetSAPTableVisibleCellPropertiesAtIndex["VisibleColumnIndex"] = ExpressionConverter.ConvertO(__workflow_sAPGetSAPTableVisibleCellPropertiesAtIndexvisibleColumnIndex);
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
                sAPGetSAPTableVisibleCellPropertiesAtIndex["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPGetSAPTableVisibleCellPropertiesAtIndexworkflow);
                if (sAPGetSAPTableVisibleCellPropertiesAtIndexpropCount > 0)
                {
                    callPayload.Body = sAPGetSAPTableVisibleCellPropertiesAtIndex;
                }

                return new ApiConnectionAction<SAPGetSAPTableVisibleCellPropertiesAtIndexResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPSetSAPTableVisibleCellTextContentsAtIndex(Expression<Func<string>> sAPSetSAPTableVisibleCellTextContentsAtIndexsearchSAPElementId, Expression<Func<string>> sAPSetSAPTableVisibleCellTextContentsAtIndexworkflow, Expression<Func<int>> sAPSetSAPTableVisibleCellTextContentsAtIndexvisibleRowIndex = null, Expression<Func<int>> sAPSetSAPTableVisibleCellTextContentsAtIndexvisibleColumnIndex = null, Expression<Func<string>> sAPSetSAPTableVisibleCellTextContentsAtIndextextToInput = null, Expression<Func<bool>> sAPSetSAPTableVisibleCellTextContentsAtIndexreplaceExistingValue = null, Expression<Func<int>> sAPSetSAPTableVisibleCellTextContentsAtIndexinsertPosition = null)
        {
            var __workflow_sAPSetSAPTableVisibleCellTextContentsAtIndexsearchSAPElementId = WorkflowExpression.Compile(sAPSetSAPTableVisibleCellTextContentsAtIndexsearchSAPElementId, nameof(sAPSetSAPTableVisibleCellTextContentsAtIndexsearchSAPElementId), required: true);
            var __workflow_sAPSetSAPTableVisibleCellTextContentsAtIndexworkflow = WorkflowExpression.Compile(sAPSetSAPTableVisibleCellTextContentsAtIndexworkflow, nameof(sAPSetSAPTableVisibleCellTextContentsAtIndexworkflow), required: true);
            var __workflow_sAPSetSAPTableVisibleCellTextContentsAtIndexvisibleRowIndex = WorkflowExpression.Compile(sAPSetSAPTableVisibleCellTextContentsAtIndexvisibleRowIndex, nameof(sAPSetSAPTableVisibleCellTextContentsAtIndexvisibleRowIndex), required: false);
            var __workflow_sAPSetSAPTableVisibleCellTextContentsAtIndexvisibleColumnIndex = WorkflowExpression.Compile(sAPSetSAPTableVisibleCellTextContentsAtIndexvisibleColumnIndex, nameof(sAPSetSAPTableVisibleCellTextContentsAtIndexvisibleColumnIndex), required: false);
            var __workflow_sAPSetSAPTableVisibleCellTextContentsAtIndextextToInput = WorkflowExpression.Compile(sAPSetSAPTableVisibleCellTextContentsAtIndextextToInput, nameof(sAPSetSAPTableVisibleCellTextContentsAtIndextextToInput), required: false);
            var __workflow_sAPSetSAPTableVisibleCellTextContentsAtIndexreplaceExistingValue = WorkflowExpression.Compile(sAPSetSAPTableVisibleCellTextContentsAtIndexreplaceExistingValue, nameof(sAPSetSAPTableVisibleCellTextContentsAtIndexreplaceExistingValue), required: false);
            var __workflow_sAPSetSAPTableVisibleCellTextContentsAtIndexinsertPosition = WorkflowExpression.Compile(sAPSetSAPTableVisibleCellTextContentsAtIndexinsertPosition, nameof(sAPSetSAPTableVisibleCellTextContentsAtIndexinsertPosition), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSetSAPTableVisibleCellTextContentsAtIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPSetSAPTableVisibleCellTextContentsAtIndex = new JObject();
                var sAPSetSAPTableVisibleCellTextContentsAtIndexpropCount = 0;
                sAPSetSAPTableVisibleCellTextContentsAtIndexpropCount++;
                sAPSetSAPTableVisibleCellTextContentsAtIndex["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPSetSAPTableVisibleCellTextContentsAtIndexsearchSAPElementId);
                if (__workflow_sAPSetSAPTableVisibleCellTextContentsAtIndexvisibleRowIndex != null)
                {
                    if (__workflow_sAPSetSAPTableVisibleCellTextContentsAtIndexvisibleRowIndex != null)
                    {
                        sAPSetSAPTableVisibleCellTextContentsAtIndex["VisibleRowIndex"] = ExpressionConverter.ConvertO(__workflow_sAPSetSAPTableVisibleCellTextContentsAtIndexvisibleRowIndex);
                        sAPSetSAPTableVisibleCellTextContentsAtIndexpropCount++;
                    }

                    sAPSetSAPTableVisibleCellTextContentsAtIndexpropCount++;
                }
                else
                {
                    sAPSetSAPTableVisibleCellTextContentsAtIndex["VisibleRowIndex"] = 1;
                    sAPSetSAPTableVisibleCellTextContentsAtIndexpropCount++;
                }

                if (__workflow_sAPSetSAPTableVisibleCellTextContentsAtIndexvisibleColumnIndex != null)
                {
                    if (__workflow_sAPSetSAPTableVisibleCellTextContentsAtIndexvisibleColumnIndex != null)
                    {
                        sAPSetSAPTableVisibleCellTextContentsAtIndex["VisibleColumnIndex"] = ExpressionConverter.ConvertO(__workflow_sAPSetSAPTableVisibleCellTextContentsAtIndexvisibleColumnIndex);
                        sAPSetSAPTableVisibleCellTextContentsAtIndexpropCount++;
                    }

                    sAPSetSAPTableVisibleCellTextContentsAtIndexpropCount++;
                }
                else
                {
                    sAPSetSAPTableVisibleCellTextContentsAtIndex["VisibleColumnIndex"] = 1;
                    sAPSetSAPTableVisibleCellTextContentsAtIndexpropCount++;
                }

                if (__workflow_sAPSetSAPTableVisibleCellTextContentsAtIndextextToInput != null)
                {
                    sAPSetSAPTableVisibleCellTextContentsAtIndex["TextToInput"] = ExpressionConverter.ConvertO(__workflow_sAPSetSAPTableVisibleCellTextContentsAtIndextextToInput);
                    sAPSetSAPTableVisibleCellTextContentsAtIndexpropCount++;
                }

                if (__workflow_sAPSetSAPTableVisibleCellTextContentsAtIndexreplaceExistingValue != null)
                {
                    if (__workflow_sAPSetSAPTableVisibleCellTextContentsAtIndexreplaceExistingValue != null)
                    {
                        sAPSetSAPTableVisibleCellTextContentsAtIndex["ReplaceExistingValue"] = ExpressionConverter.ConvertO(__workflow_sAPSetSAPTableVisibleCellTextContentsAtIndexreplaceExistingValue);
                        sAPSetSAPTableVisibleCellTextContentsAtIndexpropCount++;
                    }

                    sAPSetSAPTableVisibleCellTextContentsAtIndexpropCount++;
                }
                else
                {
                    sAPSetSAPTableVisibleCellTextContentsAtIndex["ReplaceExistingValue"] = true;
                    sAPSetSAPTableVisibleCellTextContentsAtIndexpropCount++;
                }

                if (__workflow_sAPSetSAPTableVisibleCellTextContentsAtIndexinsertPosition != null)
                {
                    if (__workflow_sAPSetSAPTableVisibleCellTextContentsAtIndexinsertPosition != null)
                    {
                        sAPSetSAPTableVisibleCellTextContentsAtIndex["InsertPosition"] = ExpressionConverter.ConvertO(__workflow_sAPSetSAPTableVisibleCellTextContentsAtIndexinsertPosition);
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
                sAPSetSAPTableVisibleCellTextContentsAtIndex["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPSetSAPTableVisibleCellTextContentsAtIndexworkflow);
                if (sAPSetSAPTableVisibleCellTextContentsAtIndexpropCount > 0)
                {
                    callPayload.Body = sAPSetSAPTableVisibleCellTextContentsAtIndex;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPCheckSAPTableVisibleCellCheckboxAtIndex(Expression<Func<string>> sAPCheckSAPTableVisibleCellCheckboxAtIndexsearchSAPElementId, Expression<Func<string>> sAPCheckSAPTableVisibleCellCheckboxAtIndexworkflow, Expression<Func<int>> sAPCheckSAPTableVisibleCellCheckboxAtIndexvisibleRowIndex = null, Expression<Func<int>> sAPCheckSAPTableVisibleCellCheckboxAtIndexvisibleColumnIndex = null, Expression<Func<bool>> sAPCheckSAPTableVisibleCellCheckboxAtIndexcheckCellElement = null)
        {
            var __workflow_sAPCheckSAPTableVisibleCellCheckboxAtIndexsearchSAPElementId = WorkflowExpression.Compile(sAPCheckSAPTableVisibleCellCheckboxAtIndexsearchSAPElementId, nameof(sAPCheckSAPTableVisibleCellCheckboxAtIndexsearchSAPElementId), required: true);
            var __workflow_sAPCheckSAPTableVisibleCellCheckboxAtIndexworkflow = WorkflowExpression.Compile(sAPCheckSAPTableVisibleCellCheckboxAtIndexworkflow, nameof(sAPCheckSAPTableVisibleCellCheckboxAtIndexworkflow), required: true);
            var __workflow_sAPCheckSAPTableVisibleCellCheckboxAtIndexvisibleRowIndex = WorkflowExpression.Compile(sAPCheckSAPTableVisibleCellCheckboxAtIndexvisibleRowIndex, nameof(sAPCheckSAPTableVisibleCellCheckboxAtIndexvisibleRowIndex), required: false);
            var __workflow_sAPCheckSAPTableVisibleCellCheckboxAtIndexvisibleColumnIndex = WorkflowExpression.Compile(sAPCheckSAPTableVisibleCellCheckboxAtIndexvisibleColumnIndex, nameof(sAPCheckSAPTableVisibleCellCheckboxAtIndexvisibleColumnIndex), required: false);
            var __workflow_sAPCheckSAPTableVisibleCellCheckboxAtIndexcheckCellElement = WorkflowExpression.Compile(sAPCheckSAPTableVisibleCellCheckboxAtIndexcheckCellElement, nameof(sAPCheckSAPTableVisibleCellCheckboxAtIndexcheckCellElement), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPCheckSAPTableVisibleCellCheckboxAtIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPCheckSAPTableVisibleCellCheckboxAtIndex = new JObject();
                var sAPCheckSAPTableVisibleCellCheckboxAtIndexpropCount = 0;
                sAPCheckSAPTableVisibleCellCheckboxAtIndexpropCount++;
                sAPCheckSAPTableVisibleCellCheckboxAtIndex["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPCheckSAPTableVisibleCellCheckboxAtIndexsearchSAPElementId);
                if (__workflow_sAPCheckSAPTableVisibleCellCheckboxAtIndexvisibleRowIndex != null)
                {
                    if (__workflow_sAPCheckSAPTableVisibleCellCheckboxAtIndexvisibleRowIndex != null)
                    {
                        sAPCheckSAPTableVisibleCellCheckboxAtIndex["VisibleRowIndex"] = ExpressionConverter.ConvertO(__workflow_sAPCheckSAPTableVisibleCellCheckboxAtIndexvisibleRowIndex);
                        sAPCheckSAPTableVisibleCellCheckboxAtIndexpropCount++;
                    }

                    sAPCheckSAPTableVisibleCellCheckboxAtIndexpropCount++;
                }
                else
                {
                    sAPCheckSAPTableVisibleCellCheckboxAtIndex["VisibleRowIndex"] = 1;
                    sAPCheckSAPTableVisibleCellCheckboxAtIndexpropCount++;
                }

                if (__workflow_sAPCheckSAPTableVisibleCellCheckboxAtIndexvisibleColumnIndex != null)
                {
                    if (__workflow_sAPCheckSAPTableVisibleCellCheckboxAtIndexvisibleColumnIndex != null)
                    {
                        sAPCheckSAPTableVisibleCellCheckboxAtIndex["VisibleColumnIndex"] = ExpressionConverter.ConvertO(__workflow_sAPCheckSAPTableVisibleCellCheckboxAtIndexvisibleColumnIndex);
                        sAPCheckSAPTableVisibleCellCheckboxAtIndexpropCount++;
                    }

                    sAPCheckSAPTableVisibleCellCheckboxAtIndexpropCount++;
                }
                else
                {
                    sAPCheckSAPTableVisibleCellCheckboxAtIndex["VisibleColumnIndex"] = 1;
                    sAPCheckSAPTableVisibleCellCheckboxAtIndexpropCount++;
                }

                if (__workflow_sAPCheckSAPTableVisibleCellCheckboxAtIndexcheckCellElement != null)
                {
                    if (__workflow_sAPCheckSAPTableVisibleCellCheckboxAtIndexcheckCellElement != null)
                    {
                        sAPCheckSAPTableVisibleCellCheckboxAtIndex["CheckCellElement"] = ExpressionConverter.ConvertO(__workflow_sAPCheckSAPTableVisibleCellCheckboxAtIndexcheckCellElement);
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
                sAPCheckSAPTableVisibleCellCheckboxAtIndex["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPCheckSAPTableVisibleCellCheckboxAtIndexworkflow);
                if (sAPCheckSAPTableVisibleCellCheckboxAtIndexpropCount > 0)
                {
                    callPayload.Body = sAPCheckSAPTableVisibleCellCheckboxAtIndex;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPPressSAPTableVisibleCellAtIndex(Expression<Func<string>> sAPPressSAPTableVisibleCellAtIndexsearchSAPElementId, Expression<Func<string>> sAPPressSAPTableVisibleCellAtIndexworkflow, Expression<Func<int>> sAPPressSAPTableVisibleCellAtIndexvisibleRowIndex = null, Expression<Func<int>> sAPPressSAPTableVisibleCellAtIndexvisibleColumnIndex = null)
        {
            var __workflow_sAPPressSAPTableVisibleCellAtIndexsearchSAPElementId = WorkflowExpression.Compile(sAPPressSAPTableVisibleCellAtIndexsearchSAPElementId, nameof(sAPPressSAPTableVisibleCellAtIndexsearchSAPElementId), required: true);
            var __workflow_sAPPressSAPTableVisibleCellAtIndexworkflow = WorkflowExpression.Compile(sAPPressSAPTableVisibleCellAtIndexworkflow, nameof(sAPPressSAPTableVisibleCellAtIndexworkflow), required: true);
            var __workflow_sAPPressSAPTableVisibleCellAtIndexvisibleRowIndex = WorkflowExpression.Compile(sAPPressSAPTableVisibleCellAtIndexvisibleRowIndex, nameof(sAPPressSAPTableVisibleCellAtIndexvisibleRowIndex), required: false);
            var __workflow_sAPPressSAPTableVisibleCellAtIndexvisibleColumnIndex = WorkflowExpression.Compile(sAPPressSAPTableVisibleCellAtIndexvisibleColumnIndex, nameof(sAPPressSAPTableVisibleCellAtIndexvisibleColumnIndex), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPPressSAPTableVisibleCellAtIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPPressSAPTableVisibleCellAtIndex = new JObject();
                var sAPPressSAPTableVisibleCellAtIndexpropCount = 0;
                sAPPressSAPTableVisibleCellAtIndexpropCount++;
                sAPPressSAPTableVisibleCellAtIndex["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPPressSAPTableVisibleCellAtIndexsearchSAPElementId);
                if (__workflow_sAPPressSAPTableVisibleCellAtIndexvisibleRowIndex != null)
                {
                    if (__workflow_sAPPressSAPTableVisibleCellAtIndexvisibleRowIndex != null)
                    {
                        sAPPressSAPTableVisibleCellAtIndex["VisibleRowIndex"] = ExpressionConverter.ConvertO(__workflow_sAPPressSAPTableVisibleCellAtIndexvisibleRowIndex);
                        sAPPressSAPTableVisibleCellAtIndexpropCount++;
                    }

                    sAPPressSAPTableVisibleCellAtIndexpropCount++;
                }
                else
                {
                    sAPPressSAPTableVisibleCellAtIndex["VisibleRowIndex"] = 1;
                    sAPPressSAPTableVisibleCellAtIndexpropCount++;
                }

                if (__workflow_sAPPressSAPTableVisibleCellAtIndexvisibleColumnIndex != null)
                {
                    if (__workflow_sAPPressSAPTableVisibleCellAtIndexvisibleColumnIndex != null)
                    {
                        sAPPressSAPTableVisibleCellAtIndex["VisibleColumnIndex"] = ExpressionConverter.ConvertO(__workflow_sAPPressSAPTableVisibleCellAtIndexvisibleColumnIndex);
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
                sAPPressSAPTableVisibleCellAtIndex["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPPressSAPTableVisibleCellAtIndexworkflow);
                if (sAPPressSAPTableVisibleCellAtIndexpropCount > 0)
                {
                    callPayload.Body = sAPPressSAPTableVisibleCellAtIndex;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPScrollSAPTable(Expression<Func<string>> sAPScrollSAPTablesearchSAPElementId, Expression<Func<string>> sAPScrollSAPTableworkflow, Expression<Func<bool>> sAPScrollSAPTablemoveHorizontalScrollbar = null, Expression<Func<int>> sAPScrollSAPTablehorizontalScrollbarPosition = null, Expression<Func<bool>> sAPScrollSAPTablemoveVerticalScrollbar = null, Expression<Func<int>> sAPScrollSAPTableverticalScrollbarPosition = null)
        {
            var __workflow_sAPScrollSAPTablesearchSAPElementId = WorkflowExpression.Compile(sAPScrollSAPTablesearchSAPElementId, nameof(sAPScrollSAPTablesearchSAPElementId), required: true);
            var __workflow_sAPScrollSAPTableworkflow = WorkflowExpression.Compile(sAPScrollSAPTableworkflow, nameof(sAPScrollSAPTableworkflow), required: true);
            var __workflow_sAPScrollSAPTablemoveHorizontalScrollbar = WorkflowExpression.Compile(sAPScrollSAPTablemoveHorizontalScrollbar, nameof(sAPScrollSAPTablemoveHorizontalScrollbar), required: false);
            var __workflow_sAPScrollSAPTablehorizontalScrollbarPosition = WorkflowExpression.Compile(sAPScrollSAPTablehorizontalScrollbarPosition, nameof(sAPScrollSAPTablehorizontalScrollbarPosition), required: false);
            var __workflow_sAPScrollSAPTablemoveVerticalScrollbar = WorkflowExpression.Compile(sAPScrollSAPTablemoveVerticalScrollbar, nameof(sAPScrollSAPTablemoveVerticalScrollbar), required: false);
            var __workflow_sAPScrollSAPTableverticalScrollbarPosition = WorkflowExpression.Compile(sAPScrollSAPTableverticalScrollbarPosition, nameof(sAPScrollSAPTableverticalScrollbarPosition), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPScrollSAPTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPScrollSAPTable = new JObject();
                var sAPScrollSAPTablepropCount = 0;
                sAPScrollSAPTablepropCount++;
                sAPScrollSAPTable["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPScrollSAPTablesearchSAPElementId);
                if (__workflow_sAPScrollSAPTablemoveHorizontalScrollbar != null)
                {
                    if (__workflow_sAPScrollSAPTablemoveHorizontalScrollbar != null)
                    {
                        sAPScrollSAPTable["MoveHorizontalScrollbar"] = ExpressionConverter.ConvertO(__workflow_sAPScrollSAPTablemoveHorizontalScrollbar);
                        sAPScrollSAPTablepropCount++;
                    }

                    sAPScrollSAPTablepropCount++;
                }
                else
                {
                    sAPScrollSAPTable["MoveHorizontalScrollbar"] = false;
                    sAPScrollSAPTablepropCount++;
                }

                if (__workflow_sAPScrollSAPTablehorizontalScrollbarPosition != null)
                {
                    sAPScrollSAPTable["HorizontalScrollbarPosition"] = ExpressionConverter.ConvertO(__workflow_sAPScrollSAPTablehorizontalScrollbarPosition);
                    sAPScrollSAPTablepropCount++;
                }

                if (__workflow_sAPScrollSAPTablemoveVerticalScrollbar != null)
                {
                    if (__workflow_sAPScrollSAPTablemoveVerticalScrollbar != null)
                    {
                        sAPScrollSAPTable["MoveVerticalScrollbar"] = ExpressionConverter.ConvertO(__workflow_sAPScrollSAPTablemoveVerticalScrollbar);
                        sAPScrollSAPTablepropCount++;
                    }

                    sAPScrollSAPTablepropCount++;
                }
                else
                {
                    sAPScrollSAPTable["MoveVerticalScrollbar"] = false;
                    sAPScrollSAPTablepropCount++;
                }

                if (__workflow_sAPScrollSAPTableverticalScrollbarPosition != null)
                {
                    sAPScrollSAPTable["VerticalScrollbarPosition"] = ExpressionConverter.ConvertO(__workflow_sAPScrollSAPTableverticalScrollbarPosition);
                    sAPScrollSAPTablepropCount++;
                }

                sAPScrollSAPTablepropCount++;
                sAPScrollSAPTable["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPScrollSAPTableworkflow);
                if (sAPScrollSAPTablepropCount > 0)
                {
                    callPayload.Body = sAPScrollSAPTable;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetTableVisibleTextContentsResponse, ApiConnectionActionConfiguration> SAPGetTableVisibleTextContents(Expression<Func<string>> sAPGetTableVisibleTextContentssearchSAPElementId, Expression<Func<string>> sAPGetTableVisibleTextContentsworkflow, Expression<Func<int>> sAPGetTableVisibleTextContentsfirstVisibleRowToReturn = null, Expression<Func<int>> sAPGetTableVisibleTextContentsmaxRowsToReturn = null, Expression<Func<int>> sAPGetTableVisibleTextContentsfirstVisibleColumnToReturn = null, Expression<Func<int>> sAPGetTableVisibleTextContentsmaxColumnsToReturn = null, Expression<Func<bool>> sAPGetTableVisibleTextContentsuseColumnHeadersFromTable = null, Expression<Func<bool>> sAPGetTableVisibleTextContentsreturnRowIndexInOutputCollection = null, Expression<Func<string>> sAPGetTableVisibleTextContentsnameOfColumnToStoreRowIndex = null, Expression<Func<string>> sAPGetTableVisibleTextContentscheckedElementValue = null)
        {
            var __workflow_sAPGetTableVisibleTextContentssearchSAPElementId = WorkflowExpression.Compile(sAPGetTableVisibleTextContentssearchSAPElementId, nameof(sAPGetTableVisibleTextContentssearchSAPElementId), required: true);
            var __workflow_sAPGetTableVisibleTextContentsworkflow = WorkflowExpression.Compile(sAPGetTableVisibleTextContentsworkflow, nameof(sAPGetTableVisibleTextContentsworkflow), required: true);
            var __workflow_sAPGetTableVisibleTextContentsfirstVisibleRowToReturn = WorkflowExpression.Compile(sAPGetTableVisibleTextContentsfirstVisibleRowToReturn, nameof(sAPGetTableVisibleTextContentsfirstVisibleRowToReturn), required: false);
            var __workflow_sAPGetTableVisibleTextContentsmaxRowsToReturn = WorkflowExpression.Compile(sAPGetTableVisibleTextContentsmaxRowsToReturn, nameof(sAPGetTableVisibleTextContentsmaxRowsToReturn), required: false);
            var __workflow_sAPGetTableVisibleTextContentsfirstVisibleColumnToReturn = WorkflowExpression.Compile(sAPGetTableVisibleTextContentsfirstVisibleColumnToReturn, nameof(sAPGetTableVisibleTextContentsfirstVisibleColumnToReturn), required: false);
            var __workflow_sAPGetTableVisibleTextContentsmaxColumnsToReturn = WorkflowExpression.Compile(sAPGetTableVisibleTextContentsmaxColumnsToReturn, nameof(sAPGetTableVisibleTextContentsmaxColumnsToReturn), required: false);
            var __workflow_sAPGetTableVisibleTextContentsuseColumnHeadersFromTable = WorkflowExpression.Compile(sAPGetTableVisibleTextContentsuseColumnHeadersFromTable, nameof(sAPGetTableVisibleTextContentsuseColumnHeadersFromTable), required: false);
            var __workflow_sAPGetTableVisibleTextContentsreturnRowIndexInOutputCollection = WorkflowExpression.Compile(sAPGetTableVisibleTextContentsreturnRowIndexInOutputCollection, nameof(sAPGetTableVisibleTextContentsreturnRowIndexInOutputCollection), required: false);
            var __workflow_sAPGetTableVisibleTextContentsnameOfColumnToStoreRowIndex = WorkflowExpression.Compile(sAPGetTableVisibleTextContentsnameOfColumnToStoreRowIndex, nameof(sAPGetTableVisibleTextContentsnameOfColumnToStoreRowIndex), required: false);
            var __workflow_sAPGetTableVisibleTextContentscheckedElementValue = WorkflowExpression.Compile(sAPGetTableVisibleTextContentscheckedElementValue, nameof(sAPGetTableVisibleTextContentscheckedElementValue), required: false);
            return new DeferredBodyAction<SAPGetTableVisibleTextContentsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetTableVisibleTextContents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGetTableVisibleTextContents = new JObject();
                var sAPGetTableVisibleTextContentspropCount = 0;
                sAPGetTableVisibleTextContentspropCount++;
                sAPGetTableVisibleTextContents["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPGetTableVisibleTextContentssearchSAPElementId);
                if (__workflow_sAPGetTableVisibleTextContentsfirstVisibleRowToReturn != null)
                {
                    if (__workflow_sAPGetTableVisibleTextContentsfirstVisibleRowToReturn != null)
                    {
                        sAPGetTableVisibleTextContents["FirstVisibleRowToReturn"] = ExpressionConverter.ConvertO(__workflow_sAPGetTableVisibleTextContentsfirstVisibleRowToReturn);
                        sAPGetTableVisibleTextContentspropCount++;
                    }

                    sAPGetTableVisibleTextContentspropCount++;
                }
                else
                {
                    sAPGetTableVisibleTextContents["FirstVisibleRowToReturn"] = 1;
                    sAPGetTableVisibleTextContentspropCount++;
                }

                if (__workflow_sAPGetTableVisibleTextContentsmaxRowsToReturn != null)
                {
                    if (__workflow_sAPGetTableVisibleTextContentsmaxRowsToReturn != null)
                    {
                        sAPGetTableVisibleTextContents["MaxRowsToReturn"] = ExpressionConverter.ConvertO(__workflow_sAPGetTableVisibleTextContentsmaxRowsToReturn);
                        sAPGetTableVisibleTextContentspropCount++;
                    }

                    sAPGetTableVisibleTextContentspropCount++;
                }
                else
                {
                    sAPGetTableVisibleTextContents["MaxRowsToReturn"] = 0;
                    sAPGetTableVisibleTextContentspropCount++;
                }

                if (__workflow_sAPGetTableVisibleTextContentsfirstVisibleColumnToReturn != null)
                {
                    if (__workflow_sAPGetTableVisibleTextContentsfirstVisibleColumnToReturn != null)
                    {
                        sAPGetTableVisibleTextContents["FirstVisibleColumnToReturn"] = ExpressionConverter.ConvertO(__workflow_sAPGetTableVisibleTextContentsfirstVisibleColumnToReturn);
                        sAPGetTableVisibleTextContentspropCount++;
                    }

                    sAPGetTableVisibleTextContentspropCount++;
                }
                else
                {
                    sAPGetTableVisibleTextContents["FirstVisibleColumnToReturn"] = 1;
                    sAPGetTableVisibleTextContentspropCount++;
                }

                if (__workflow_sAPGetTableVisibleTextContentsmaxColumnsToReturn != null)
                {
                    if (__workflow_sAPGetTableVisibleTextContentsmaxColumnsToReturn != null)
                    {
                        sAPGetTableVisibleTextContents["MaxColumnsToReturn"] = ExpressionConverter.ConvertO(__workflow_sAPGetTableVisibleTextContentsmaxColumnsToReturn);
                        sAPGetTableVisibleTextContentspropCount++;
                    }

                    sAPGetTableVisibleTextContentspropCount++;
                }
                else
                {
                    sAPGetTableVisibleTextContents["MaxColumnsToReturn"] = 0;
                    sAPGetTableVisibleTextContentspropCount++;
                }

                if (__workflow_sAPGetTableVisibleTextContentsuseColumnHeadersFromTable != null)
                {
                    if (__workflow_sAPGetTableVisibleTextContentsuseColumnHeadersFromTable != null)
                    {
                        sAPGetTableVisibleTextContents["UseColumnHeadersFromTable"] = ExpressionConverter.ConvertO(__workflow_sAPGetTableVisibleTextContentsuseColumnHeadersFromTable);
                        sAPGetTableVisibleTextContentspropCount++;
                    }

                    sAPGetTableVisibleTextContentspropCount++;
                }
                else
                {
                    sAPGetTableVisibleTextContents["UseColumnHeadersFromTable"] = false;
                    sAPGetTableVisibleTextContentspropCount++;
                }

                if (__workflow_sAPGetTableVisibleTextContentsreturnRowIndexInOutputCollection != null)
                {
                    if (__workflow_sAPGetTableVisibleTextContentsreturnRowIndexInOutputCollection != null)
                    {
                        sAPGetTableVisibleTextContents["ReturnRowIndexInOutputCollection"] = ExpressionConverter.ConvertO(__workflow_sAPGetTableVisibleTextContentsreturnRowIndexInOutputCollection);
                        sAPGetTableVisibleTextContentspropCount++;
                    }

                    sAPGetTableVisibleTextContentspropCount++;
                }
                else
                {
                    sAPGetTableVisibleTextContents["ReturnRowIndexInOutputCollection"] = false;
                    sAPGetTableVisibleTextContentspropCount++;
                }

                if (__workflow_sAPGetTableVisibleTextContentsnameOfColumnToStoreRowIndex != null)
                {
                    sAPGetTableVisibleTextContents["NameOfColumnToStoreRowIndex"] = ExpressionConverter.ConvertO(__workflow_sAPGetTableVisibleTextContentsnameOfColumnToStoreRowIndex);
                    sAPGetTableVisibleTextContentspropCount++;
                }

                if (__workflow_sAPGetTableVisibleTextContentscheckedElementValue != null)
                {
                    if (__workflow_sAPGetTableVisibleTextContentscheckedElementValue != null)
                    {
                        sAPGetTableVisibleTextContents["CheckedElementValue"] = ExpressionConverter.ConvertO(__workflow_sAPGetTableVisibleTextContentscheckedElementValue);
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
                sAPGetTableVisibleTextContents["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPGetTableVisibleTextContentsworkflow);
                if (sAPGetTableVisibleTextContentspropCount > 0)
                {
                    callPayload.Body = sAPGetTableVisibleTextContents;
                }

                return new ApiConnectionAction<SAPGetTableVisibleTextContentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPSelectSAPTableRow(Expression<Func<string>> sAPSelectSAPTableRowsearchSAPElementId, Expression<Func<string>> sAPSelectSAPTableRowworkflow, Expression<Func<int>> sAPSelectSAPTableRowvisibleRowIndex = null, Expression<Func<bool>> sAPSelectSAPTableRowselect = null)
        {
            var __workflow_sAPSelectSAPTableRowsearchSAPElementId = WorkflowExpression.Compile(sAPSelectSAPTableRowsearchSAPElementId, nameof(sAPSelectSAPTableRowsearchSAPElementId), required: true);
            var __workflow_sAPSelectSAPTableRowworkflow = WorkflowExpression.Compile(sAPSelectSAPTableRowworkflow, nameof(sAPSelectSAPTableRowworkflow), required: true);
            var __workflow_sAPSelectSAPTableRowvisibleRowIndex = WorkflowExpression.Compile(sAPSelectSAPTableRowvisibleRowIndex, nameof(sAPSelectSAPTableRowvisibleRowIndex), required: false);
            var __workflow_sAPSelectSAPTableRowselect = WorkflowExpression.Compile(sAPSelectSAPTableRowselect, nameof(sAPSelectSAPTableRowselect), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSelectSAPTableRow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPSelectSAPTableRow = new JObject();
                var sAPSelectSAPTableRowpropCount = 0;
                sAPSelectSAPTableRowpropCount++;
                sAPSelectSAPTableRow["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPSelectSAPTableRowsearchSAPElementId);
                if (__workflow_sAPSelectSAPTableRowvisibleRowIndex != null)
                {
                    if (__workflow_sAPSelectSAPTableRowvisibleRowIndex != null)
                    {
                        sAPSelectSAPTableRow["VisibleRowIndex"] = ExpressionConverter.ConvertO(__workflow_sAPSelectSAPTableRowvisibleRowIndex);
                        sAPSelectSAPTableRowpropCount++;
                    }

                    sAPSelectSAPTableRowpropCount++;
                }
                else
                {
                    sAPSelectSAPTableRow["VisibleRowIndex"] = 1;
                    sAPSelectSAPTableRowpropCount++;
                }

                if (__workflow_sAPSelectSAPTableRowselect != null)
                {
                    if (__workflow_sAPSelectSAPTableRowselect != null)
                    {
                        sAPSelectSAPTableRow["Select"] = ExpressionConverter.ConvertO(__workflow_sAPSelectSAPTableRowselect);
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
                sAPSelectSAPTableRow["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPSelectSAPTableRowworkflow);
                if (sAPSelectSAPTableRowpropCount > 0)
                {
                    callPayload.Body = sAPSelectSAPTableRow;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPSelectSAPTableColumn(Expression<Func<string>> sAPSelectSAPTableColumnsearchSAPElementId, Expression<Func<string>> sAPSelectSAPTableColumnworkflow, Expression<Func<int>> sAPSelectSAPTableColumnvisibleColumnIndex = null, Expression<Func<bool>> sAPSelectSAPTableColumnselect = null)
        {
            var __workflow_sAPSelectSAPTableColumnsearchSAPElementId = WorkflowExpression.Compile(sAPSelectSAPTableColumnsearchSAPElementId, nameof(sAPSelectSAPTableColumnsearchSAPElementId), required: true);
            var __workflow_sAPSelectSAPTableColumnworkflow = WorkflowExpression.Compile(sAPSelectSAPTableColumnworkflow, nameof(sAPSelectSAPTableColumnworkflow), required: true);
            var __workflow_sAPSelectSAPTableColumnvisibleColumnIndex = WorkflowExpression.Compile(sAPSelectSAPTableColumnvisibleColumnIndex, nameof(sAPSelectSAPTableColumnvisibleColumnIndex), required: false);
            var __workflow_sAPSelectSAPTableColumnselect = WorkflowExpression.Compile(sAPSelectSAPTableColumnselect, nameof(sAPSelectSAPTableColumnselect), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSelectSAPTableColumn";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPSelectSAPTableColumn = new JObject();
                var sAPSelectSAPTableColumnpropCount = 0;
                sAPSelectSAPTableColumnpropCount++;
                sAPSelectSAPTableColumn["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPSelectSAPTableColumnsearchSAPElementId);
                if (__workflow_sAPSelectSAPTableColumnvisibleColumnIndex != null)
                {
                    if (__workflow_sAPSelectSAPTableColumnvisibleColumnIndex != null)
                    {
                        sAPSelectSAPTableColumn["VisibleColumnIndex"] = ExpressionConverter.ConvertO(__workflow_sAPSelectSAPTableColumnvisibleColumnIndex);
                        sAPSelectSAPTableColumnpropCount++;
                    }

                    sAPSelectSAPTableColumnpropCount++;
                }
                else
                {
                    sAPSelectSAPTableColumn["VisibleColumnIndex"] = 1;
                    sAPSelectSAPTableColumnpropCount++;
                }

                if (__workflow_sAPSelectSAPTableColumnselect != null)
                {
                    if (__workflow_sAPSelectSAPTableColumnselect != null)
                    {
                        sAPSelectSAPTableColumn["Select"] = ExpressionConverter.ConvertO(__workflow_sAPSelectSAPTableColumnselect);
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
                sAPSelectSAPTableColumn["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPSelectSAPTableColumnworkflow);
                if (sAPSelectSAPTableColumnpropCount > 0)
                {
                    callPayload.Body = sAPSelectSAPTableColumn;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetTreeNodesResponse, ApiConnectionActionConfiguration> SAPGetTreeNodes(Expression<Func<string>> sAPGetTreeNodessearchSAPElementId, Expression<Func<string>> sAPGetTreeNodesworkflow, Expression<Func<string>> sAPGetTreeNodesparentNodeKey = null, Expression<Func<bool>> sAPGetTreeNodesprocessSubNodes = null)
        {
            var __workflow_sAPGetTreeNodessearchSAPElementId = WorkflowExpression.Compile(sAPGetTreeNodessearchSAPElementId, nameof(sAPGetTreeNodessearchSAPElementId), required: true);
            var __workflow_sAPGetTreeNodesworkflow = WorkflowExpression.Compile(sAPGetTreeNodesworkflow, nameof(sAPGetTreeNodesworkflow), required: true);
            var __workflow_sAPGetTreeNodesparentNodeKey = WorkflowExpression.Compile(sAPGetTreeNodesparentNodeKey, nameof(sAPGetTreeNodesparentNodeKey), required: false);
            var __workflow_sAPGetTreeNodesprocessSubNodes = WorkflowExpression.Compile(sAPGetTreeNodesprocessSubNodes, nameof(sAPGetTreeNodesprocessSubNodes), required: false);
            return new DeferredBodyAction<SAPGetTreeNodesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetTreeNodes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGetTreeNodes = new JObject();
                var sAPGetTreeNodespropCount = 0;
                sAPGetTreeNodespropCount++;
                sAPGetTreeNodes["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPGetTreeNodessearchSAPElementId);
                if (__workflow_sAPGetTreeNodesparentNodeKey != null)
                {
                    sAPGetTreeNodes["ParentNodeKey"] = ExpressionConverter.ConvertO(__workflow_sAPGetTreeNodesparentNodeKey);
                    sAPGetTreeNodespropCount++;
                }

                if (__workflow_sAPGetTreeNodesprocessSubNodes != null)
                {
                    if (__workflow_sAPGetTreeNodesprocessSubNodes != null)
                    {
                        sAPGetTreeNodes["ProcessSubNodes"] = ExpressionConverter.ConvertO(__workflow_sAPGetTreeNodesprocessSubNodes);
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
                sAPGetTreeNodes["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPGetTreeNodesworkflow);
                if (sAPGetTreeNodespropCount > 0)
                {
                    callPayload.Body = sAPGetTreeNodes;
                }

                return new ApiConnectionAction<SAPGetTreeNodesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPDoubleClickTreeItem(Expression<Func<string>> sAPDoubleClickTreeItemsearchSAPElementId, Expression<Func<string>> sAPDoubleClickTreeItemworkflow, Expression<Func<string>> sAPDoubleClickTreeItemsearchNodeKey = null, Expression<Func<string>> sAPDoubleClickTreeItemsearchNodePath = null, Expression<Func<string>> sAPDoubleClickTreeItemsearchNodeText = null, Expression<Func<bool>> sAPDoubleClickTreeItemsearchNodeTextIsRegularExpression = null, Expression<Func<bool>> sAPDoubleClickTreeItemsearchNodeTextIsCaseSensitive = null, Expression<Func<string>> sAPDoubleClickTreeItemsearchColumnName = null, Expression<Func<string>> sAPDoubleClickTreeItemsearchColumnTitle = null, Expression<Func<bool>> sAPDoubleClickTreeItemsearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPDoubleClickTreeItemsearchColumnTitleIsCaseSensitive = null)
        {
            var __workflow_sAPDoubleClickTreeItemsearchSAPElementId = WorkflowExpression.Compile(sAPDoubleClickTreeItemsearchSAPElementId, nameof(sAPDoubleClickTreeItemsearchSAPElementId), required: true);
            var __workflow_sAPDoubleClickTreeItemworkflow = WorkflowExpression.Compile(sAPDoubleClickTreeItemworkflow, nameof(sAPDoubleClickTreeItemworkflow), required: true);
            var __workflow_sAPDoubleClickTreeItemsearchNodeKey = WorkflowExpression.Compile(sAPDoubleClickTreeItemsearchNodeKey, nameof(sAPDoubleClickTreeItemsearchNodeKey), required: false);
            var __workflow_sAPDoubleClickTreeItemsearchNodePath = WorkflowExpression.Compile(sAPDoubleClickTreeItemsearchNodePath, nameof(sAPDoubleClickTreeItemsearchNodePath), required: false);
            var __workflow_sAPDoubleClickTreeItemsearchNodeText = WorkflowExpression.Compile(sAPDoubleClickTreeItemsearchNodeText, nameof(sAPDoubleClickTreeItemsearchNodeText), required: false);
            var __workflow_sAPDoubleClickTreeItemsearchNodeTextIsRegularExpression = WorkflowExpression.Compile(sAPDoubleClickTreeItemsearchNodeTextIsRegularExpression, nameof(sAPDoubleClickTreeItemsearchNodeTextIsRegularExpression), required: false);
            var __workflow_sAPDoubleClickTreeItemsearchNodeTextIsCaseSensitive = WorkflowExpression.Compile(sAPDoubleClickTreeItemsearchNodeTextIsCaseSensitive, nameof(sAPDoubleClickTreeItemsearchNodeTextIsCaseSensitive), required: false);
            var __workflow_sAPDoubleClickTreeItemsearchColumnName = WorkflowExpression.Compile(sAPDoubleClickTreeItemsearchColumnName, nameof(sAPDoubleClickTreeItemsearchColumnName), required: false);
            var __workflow_sAPDoubleClickTreeItemsearchColumnTitle = WorkflowExpression.Compile(sAPDoubleClickTreeItemsearchColumnTitle, nameof(sAPDoubleClickTreeItemsearchColumnTitle), required: false);
            var __workflow_sAPDoubleClickTreeItemsearchColumnTitleIsRegularExpression = WorkflowExpression.Compile(sAPDoubleClickTreeItemsearchColumnTitleIsRegularExpression, nameof(sAPDoubleClickTreeItemsearchColumnTitleIsRegularExpression), required: false);
            var __workflow_sAPDoubleClickTreeItemsearchColumnTitleIsCaseSensitive = WorkflowExpression.Compile(sAPDoubleClickTreeItemsearchColumnTitleIsCaseSensitive, nameof(sAPDoubleClickTreeItemsearchColumnTitleIsCaseSensitive), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPDoubleClickTreeItem";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPDoubleClickTreeItem = new JObject();
                var sAPDoubleClickTreeItempropCount = 0;
                sAPDoubleClickTreeItempropCount++;
                sAPDoubleClickTreeItem["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPDoubleClickTreeItemsearchSAPElementId);
                if (__workflow_sAPDoubleClickTreeItemsearchNodeKey != null)
                {
                    sAPDoubleClickTreeItem["SearchNodeKey"] = ExpressionConverter.ConvertO(__workflow_sAPDoubleClickTreeItemsearchNodeKey);
                    sAPDoubleClickTreeItempropCount++;
                }

                if (__workflow_sAPDoubleClickTreeItemsearchNodePath != null)
                {
                    sAPDoubleClickTreeItem["SearchNodePath"] = ExpressionConverter.ConvertO(__workflow_sAPDoubleClickTreeItemsearchNodePath);
                    sAPDoubleClickTreeItempropCount++;
                }

                if (__workflow_sAPDoubleClickTreeItemsearchNodeText != null)
                {
                    sAPDoubleClickTreeItem["SearchNodeText"] = ExpressionConverter.ConvertO(__workflow_sAPDoubleClickTreeItemsearchNodeText);
                    sAPDoubleClickTreeItempropCount++;
                }

                if (__workflow_sAPDoubleClickTreeItemsearchNodeTextIsRegularExpression != null)
                {
                    if (__workflow_sAPDoubleClickTreeItemsearchNodeTextIsRegularExpression != null)
                    {
                        sAPDoubleClickTreeItem["SearchNodeTextIsRegularExpression"] = ExpressionConverter.ConvertO(__workflow_sAPDoubleClickTreeItemsearchNodeTextIsRegularExpression);
                        sAPDoubleClickTreeItempropCount++;
                    }

                    sAPDoubleClickTreeItempropCount++;
                }
                else
                {
                    sAPDoubleClickTreeItem["SearchNodeTextIsRegularExpression"] = false;
                    sAPDoubleClickTreeItempropCount++;
                }

                if (__workflow_sAPDoubleClickTreeItemsearchNodeTextIsCaseSensitive != null)
                {
                    if (__workflow_sAPDoubleClickTreeItemsearchNodeTextIsCaseSensitive != null)
                    {
                        sAPDoubleClickTreeItem["SearchNodeTextIsCaseSensitive"] = ExpressionConverter.ConvertO(__workflow_sAPDoubleClickTreeItemsearchNodeTextIsCaseSensitive);
                        sAPDoubleClickTreeItempropCount++;
                    }

                    sAPDoubleClickTreeItempropCount++;
                }
                else
                {
                    sAPDoubleClickTreeItem["SearchNodeTextIsCaseSensitive"] = false;
                    sAPDoubleClickTreeItempropCount++;
                }

                if (__workflow_sAPDoubleClickTreeItemsearchColumnName != null)
                {
                    sAPDoubleClickTreeItem["SearchColumnName"] = ExpressionConverter.ConvertO(__workflow_sAPDoubleClickTreeItemsearchColumnName);
                    sAPDoubleClickTreeItempropCount++;
                }

                if (__workflow_sAPDoubleClickTreeItemsearchColumnTitle != null)
                {
                    sAPDoubleClickTreeItem["SearchColumnTitle"] = ExpressionConverter.ConvertO(__workflow_sAPDoubleClickTreeItemsearchColumnTitle);
                    sAPDoubleClickTreeItempropCount++;
                }

                if (__workflow_sAPDoubleClickTreeItemsearchColumnTitleIsRegularExpression != null)
                {
                    if (__workflow_sAPDoubleClickTreeItemsearchColumnTitleIsRegularExpression != null)
                    {
                        sAPDoubleClickTreeItem["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(__workflow_sAPDoubleClickTreeItemsearchColumnTitleIsRegularExpression);
                        sAPDoubleClickTreeItempropCount++;
                    }

                    sAPDoubleClickTreeItempropCount++;
                }
                else
                {
                    sAPDoubleClickTreeItem["SearchColumnTitleIsRegularExpression"] = false;
                    sAPDoubleClickTreeItempropCount++;
                }

                if (__workflow_sAPDoubleClickTreeItemsearchColumnTitleIsCaseSensitive != null)
                {
                    if (__workflow_sAPDoubleClickTreeItemsearchColumnTitleIsCaseSensitive != null)
                    {
                        sAPDoubleClickTreeItem["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(__workflow_sAPDoubleClickTreeItemsearchColumnTitleIsCaseSensitive);
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
                sAPDoubleClickTreeItem["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPDoubleClickTreeItemworkflow);
                if (sAPDoubleClickTreeItempropCount > 0)
                {
                    callPayload.Body = sAPDoubleClickTreeItem;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPSelectTreeItem(Expression<Func<string>> sAPSelectTreeItemsearchSAPElementId, Expression<Func<string>> sAPSelectTreeItemworkflow, Expression<Func<string>> sAPSelectTreeItemsearchNodeKey = null, Expression<Func<string>> sAPSelectTreeItemsearchNodePath = null, Expression<Func<string>> sAPSelectTreeItemsearchNodeText = null, Expression<Func<bool>> sAPSelectTreeItemsearchNodeTextIsRegularExpression = null, Expression<Func<bool>> sAPSelectTreeItemsearchNodeTextIsCaseSensitive = null, Expression<Func<string>> sAPSelectTreeItemsearchColumnName = null, Expression<Func<string>> sAPSelectTreeItemsearchColumnTitle = null, Expression<Func<bool>> sAPSelectTreeItemsearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPSelectTreeItemsearchColumnTitleIsCaseSensitive = null, Expression<Func<bool>> sAPSelectTreeItemselect = null, Expression<Func<bool>> sAPSelectTreeItemdeselectAllFirst = null)
        {
            var __workflow_sAPSelectTreeItemsearchSAPElementId = WorkflowExpression.Compile(sAPSelectTreeItemsearchSAPElementId, nameof(sAPSelectTreeItemsearchSAPElementId), required: true);
            var __workflow_sAPSelectTreeItemworkflow = WorkflowExpression.Compile(sAPSelectTreeItemworkflow, nameof(sAPSelectTreeItemworkflow), required: true);
            var __workflow_sAPSelectTreeItemsearchNodeKey = WorkflowExpression.Compile(sAPSelectTreeItemsearchNodeKey, nameof(sAPSelectTreeItemsearchNodeKey), required: false);
            var __workflow_sAPSelectTreeItemsearchNodePath = WorkflowExpression.Compile(sAPSelectTreeItemsearchNodePath, nameof(sAPSelectTreeItemsearchNodePath), required: false);
            var __workflow_sAPSelectTreeItemsearchNodeText = WorkflowExpression.Compile(sAPSelectTreeItemsearchNodeText, nameof(sAPSelectTreeItemsearchNodeText), required: false);
            var __workflow_sAPSelectTreeItemsearchNodeTextIsRegularExpression = WorkflowExpression.Compile(sAPSelectTreeItemsearchNodeTextIsRegularExpression, nameof(sAPSelectTreeItemsearchNodeTextIsRegularExpression), required: false);
            var __workflow_sAPSelectTreeItemsearchNodeTextIsCaseSensitive = WorkflowExpression.Compile(sAPSelectTreeItemsearchNodeTextIsCaseSensitive, nameof(sAPSelectTreeItemsearchNodeTextIsCaseSensitive), required: false);
            var __workflow_sAPSelectTreeItemsearchColumnName = WorkflowExpression.Compile(sAPSelectTreeItemsearchColumnName, nameof(sAPSelectTreeItemsearchColumnName), required: false);
            var __workflow_sAPSelectTreeItemsearchColumnTitle = WorkflowExpression.Compile(sAPSelectTreeItemsearchColumnTitle, nameof(sAPSelectTreeItemsearchColumnTitle), required: false);
            var __workflow_sAPSelectTreeItemsearchColumnTitleIsRegularExpression = WorkflowExpression.Compile(sAPSelectTreeItemsearchColumnTitleIsRegularExpression, nameof(sAPSelectTreeItemsearchColumnTitleIsRegularExpression), required: false);
            var __workflow_sAPSelectTreeItemsearchColumnTitleIsCaseSensitive = WorkflowExpression.Compile(sAPSelectTreeItemsearchColumnTitleIsCaseSensitive, nameof(sAPSelectTreeItemsearchColumnTitleIsCaseSensitive), required: false);
            var __workflow_sAPSelectTreeItemselect = WorkflowExpression.Compile(sAPSelectTreeItemselect, nameof(sAPSelectTreeItemselect), required: false);
            var __workflow_sAPSelectTreeItemdeselectAllFirst = WorkflowExpression.Compile(sAPSelectTreeItemdeselectAllFirst, nameof(sAPSelectTreeItemdeselectAllFirst), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSelectTreeItem";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPSelectTreeItem = new JObject();
                var sAPSelectTreeItempropCount = 0;
                sAPSelectTreeItempropCount++;
                sAPSelectTreeItem["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPSelectTreeItemsearchSAPElementId);
                if (__workflow_sAPSelectTreeItemsearchNodeKey != null)
                {
                    sAPSelectTreeItem["SearchNodeKey"] = ExpressionConverter.ConvertO(__workflow_sAPSelectTreeItemsearchNodeKey);
                    sAPSelectTreeItempropCount++;
                }

                if (__workflow_sAPSelectTreeItemsearchNodePath != null)
                {
                    sAPSelectTreeItem["SearchNodePath"] = ExpressionConverter.ConvertO(__workflow_sAPSelectTreeItemsearchNodePath);
                    sAPSelectTreeItempropCount++;
                }

                if (__workflow_sAPSelectTreeItemsearchNodeText != null)
                {
                    sAPSelectTreeItem["SearchNodeText"] = ExpressionConverter.ConvertO(__workflow_sAPSelectTreeItemsearchNodeText);
                    sAPSelectTreeItempropCount++;
                }

                if (__workflow_sAPSelectTreeItemsearchNodeTextIsRegularExpression != null)
                {
                    if (__workflow_sAPSelectTreeItemsearchNodeTextIsRegularExpression != null)
                    {
                        sAPSelectTreeItem["SearchNodeTextIsRegularExpression"] = ExpressionConverter.ConvertO(__workflow_sAPSelectTreeItemsearchNodeTextIsRegularExpression);
                        sAPSelectTreeItempropCount++;
                    }

                    sAPSelectTreeItempropCount++;
                }
                else
                {
                    sAPSelectTreeItem["SearchNodeTextIsRegularExpression"] = false;
                    sAPSelectTreeItempropCount++;
                }

                if (__workflow_sAPSelectTreeItemsearchNodeTextIsCaseSensitive != null)
                {
                    if (__workflow_sAPSelectTreeItemsearchNodeTextIsCaseSensitive != null)
                    {
                        sAPSelectTreeItem["SearchNodeTextIsCaseSensitive"] = ExpressionConverter.ConvertO(__workflow_sAPSelectTreeItemsearchNodeTextIsCaseSensitive);
                        sAPSelectTreeItempropCount++;
                    }

                    sAPSelectTreeItempropCount++;
                }
                else
                {
                    sAPSelectTreeItem["SearchNodeTextIsCaseSensitive"] = false;
                    sAPSelectTreeItempropCount++;
                }

                if (__workflow_sAPSelectTreeItemsearchColumnName != null)
                {
                    sAPSelectTreeItem["SearchColumnName"] = ExpressionConverter.ConvertO(__workflow_sAPSelectTreeItemsearchColumnName);
                    sAPSelectTreeItempropCount++;
                }

                if (__workflow_sAPSelectTreeItemsearchColumnTitle != null)
                {
                    sAPSelectTreeItem["SearchColumnTitle"] = ExpressionConverter.ConvertO(__workflow_sAPSelectTreeItemsearchColumnTitle);
                    sAPSelectTreeItempropCount++;
                }

                if (__workflow_sAPSelectTreeItemsearchColumnTitleIsRegularExpression != null)
                {
                    if (__workflow_sAPSelectTreeItemsearchColumnTitleIsRegularExpression != null)
                    {
                        sAPSelectTreeItem["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(__workflow_sAPSelectTreeItemsearchColumnTitleIsRegularExpression);
                        sAPSelectTreeItempropCount++;
                    }

                    sAPSelectTreeItempropCount++;
                }
                else
                {
                    sAPSelectTreeItem["SearchColumnTitleIsRegularExpression"] = false;
                    sAPSelectTreeItempropCount++;
                }

                if (__workflow_sAPSelectTreeItemsearchColumnTitleIsCaseSensitive != null)
                {
                    if (__workflow_sAPSelectTreeItemsearchColumnTitleIsCaseSensitive != null)
                    {
                        sAPSelectTreeItem["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(__workflow_sAPSelectTreeItemsearchColumnTitleIsCaseSensitive);
                        sAPSelectTreeItempropCount++;
                    }

                    sAPSelectTreeItempropCount++;
                }
                else
                {
                    sAPSelectTreeItem["SearchColumnTitleIsCaseSensitive"] = false;
                    sAPSelectTreeItempropCount++;
                }

                if (__workflow_sAPSelectTreeItemselect != null)
                {
                    if (__workflow_sAPSelectTreeItemselect != null)
                    {
                        sAPSelectTreeItem["Select"] = ExpressionConverter.ConvertO(__workflow_sAPSelectTreeItemselect);
                        sAPSelectTreeItempropCount++;
                    }

                    sAPSelectTreeItempropCount++;
                }
                else
                {
                    sAPSelectTreeItem["Select"] = true;
                    sAPSelectTreeItempropCount++;
                }

                if (__workflow_sAPSelectTreeItemdeselectAllFirst != null)
                {
                    if (__workflow_sAPSelectTreeItemdeselectAllFirst != null)
                    {
                        sAPSelectTreeItem["DeselectAllFirst"] = ExpressionConverter.ConvertO(__workflow_sAPSelectTreeItemdeselectAllFirst);
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
                sAPSelectTreeItem["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPSelectTreeItemworkflow);
                if (sAPSelectTreeItempropCount > 0)
                {
                    callPayload.Body = sAPSelectTreeItem;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPExpandTreeNode(Expression<Func<string>> sAPExpandTreeNodesearchSAPElementId, Expression<Func<string>> sAPExpandTreeNodeworkflow, Expression<Func<string>> sAPExpandTreeNodesearchNodeKey = null, Expression<Func<string>> sAPExpandTreeNodesearchNodePath = null, Expression<Func<string>> sAPExpandTreeNodesearchNodeText = null, Expression<Func<bool>> sAPExpandTreeNodesearchNodeTextIsRegularExpression = null, Expression<Func<bool>> sAPExpandTreeNodesearchNodeTextIsCaseSensitive = null, Expression<Func<bool>> sAPExpandTreeNodeexpand = null)
        {
            var __workflow_sAPExpandTreeNodesearchSAPElementId = WorkflowExpression.Compile(sAPExpandTreeNodesearchSAPElementId, nameof(sAPExpandTreeNodesearchSAPElementId), required: true);
            var __workflow_sAPExpandTreeNodeworkflow = WorkflowExpression.Compile(sAPExpandTreeNodeworkflow, nameof(sAPExpandTreeNodeworkflow), required: true);
            var __workflow_sAPExpandTreeNodesearchNodeKey = WorkflowExpression.Compile(sAPExpandTreeNodesearchNodeKey, nameof(sAPExpandTreeNodesearchNodeKey), required: false);
            var __workflow_sAPExpandTreeNodesearchNodePath = WorkflowExpression.Compile(sAPExpandTreeNodesearchNodePath, nameof(sAPExpandTreeNodesearchNodePath), required: false);
            var __workflow_sAPExpandTreeNodesearchNodeText = WorkflowExpression.Compile(sAPExpandTreeNodesearchNodeText, nameof(sAPExpandTreeNodesearchNodeText), required: false);
            var __workflow_sAPExpandTreeNodesearchNodeTextIsRegularExpression = WorkflowExpression.Compile(sAPExpandTreeNodesearchNodeTextIsRegularExpression, nameof(sAPExpandTreeNodesearchNodeTextIsRegularExpression), required: false);
            var __workflow_sAPExpandTreeNodesearchNodeTextIsCaseSensitive = WorkflowExpression.Compile(sAPExpandTreeNodesearchNodeTextIsCaseSensitive, nameof(sAPExpandTreeNodesearchNodeTextIsCaseSensitive), required: false);
            var __workflow_sAPExpandTreeNodeexpand = WorkflowExpression.Compile(sAPExpandTreeNodeexpand, nameof(sAPExpandTreeNodeexpand), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPExpandTreeNode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPExpandTreeNode = new JObject();
                var sAPExpandTreeNodepropCount = 0;
                sAPExpandTreeNodepropCount++;
                sAPExpandTreeNode["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPExpandTreeNodesearchSAPElementId);
                if (__workflow_sAPExpandTreeNodesearchNodeKey != null)
                {
                    sAPExpandTreeNode["SearchNodeKey"] = ExpressionConverter.ConvertO(__workflow_sAPExpandTreeNodesearchNodeKey);
                    sAPExpandTreeNodepropCount++;
                }

                if (__workflow_sAPExpandTreeNodesearchNodePath != null)
                {
                    sAPExpandTreeNode["SearchNodePath"] = ExpressionConverter.ConvertO(__workflow_sAPExpandTreeNodesearchNodePath);
                    sAPExpandTreeNodepropCount++;
                }

                if (__workflow_sAPExpandTreeNodesearchNodeText != null)
                {
                    sAPExpandTreeNode["SearchNodeText"] = ExpressionConverter.ConvertO(__workflow_sAPExpandTreeNodesearchNodeText);
                    sAPExpandTreeNodepropCount++;
                }

                if (__workflow_sAPExpandTreeNodesearchNodeTextIsRegularExpression != null)
                {
                    if (__workflow_sAPExpandTreeNodesearchNodeTextIsRegularExpression != null)
                    {
                        sAPExpandTreeNode["SearchNodeTextIsRegularExpression"] = ExpressionConverter.ConvertO(__workflow_sAPExpandTreeNodesearchNodeTextIsRegularExpression);
                        sAPExpandTreeNodepropCount++;
                    }

                    sAPExpandTreeNodepropCount++;
                }
                else
                {
                    sAPExpandTreeNode["SearchNodeTextIsRegularExpression"] = false;
                    sAPExpandTreeNodepropCount++;
                }

                if (__workflow_sAPExpandTreeNodesearchNodeTextIsCaseSensitive != null)
                {
                    if (__workflow_sAPExpandTreeNodesearchNodeTextIsCaseSensitive != null)
                    {
                        sAPExpandTreeNode["SearchNodeTextIsCaseSensitive"] = ExpressionConverter.ConvertO(__workflow_sAPExpandTreeNodesearchNodeTextIsCaseSensitive);
                        sAPExpandTreeNodepropCount++;
                    }

                    sAPExpandTreeNodepropCount++;
                }
                else
                {
                    sAPExpandTreeNode["SearchNodeTextIsCaseSensitive"] = false;
                    sAPExpandTreeNodepropCount++;
                }

                if (__workflow_sAPExpandTreeNodeexpand != null)
                {
                    if (__workflow_sAPExpandTreeNodeexpand != null)
                    {
                        sAPExpandTreeNode["Expand"] = ExpressionConverter.ConvertO(__workflow_sAPExpandTreeNodeexpand);
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
                sAPExpandTreeNode["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPExpandTreeNodeworkflow);
                if (sAPExpandTreeNodepropCount > 0)
                {
                    callPayload.Body = sAPExpandTreeNode;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPDeselectAllTreeNodes(Expression<Func<string>> sAPDeselectAllTreeNodessearchSAPElementId, Expression<Func<string>> sAPDeselectAllTreeNodesworkflow)
        {
            var __workflow_sAPDeselectAllTreeNodessearchSAPElementId = WorkflowExpression.Compile(sAPDeselectAllTreeNodessearchSAPElementId, nameof(sAPDeselectAllTreeNodessearchSAPElementId), required: true);
            var __workflow_sAPDeselectAllTreeNodesworkflow = WorkflowExpression.Compile(sAPDeselectAllTreeNodesworkflow, nameof(sAPDeselectAllTreeNodesworkflow), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPDeselectAllTreeNodes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPDeselectAllTreeNodes = new JObject();
                var sAPDeselectAllTreeNodespropCount = 0;
                sAPDeselectAllTreeNodespropCount++;
                sAPDeselectAllTreeNodes["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPDeselectAllTreeNodessearchSAPElementId);
                sAPDeselectAllTreeNodespropCount++;
                sAPDeselectAllTreeNodes["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPDeselectAllTreeNodesworkflow);
                if (sAPDeselectAllTreeNodespropCount > 0)
                {
                    callPayload.Body = sAPDeselectAllTreeNodes;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPPressKeyOnTree(Expression<Func<string>> sAPPressKeyOnTreesearchSAPElementId, Expression<Func<string>> sAPPressKeyOnTreekey, Expression<Func<string>> sAPPressKeyOnTreeworkflow)
        {
            var __workflow_sAPPressKeyOnTreesearchSAPElementId = WorkflowExpression.Compile(sAPPressKeyOnTreesearchSAPElementId, nameof(sAPPressKeyOnTreesearchSAPElementId), required: true);
            var __workflow_sAPPressKeyOnTreekey = WorkflowExpression.Compile(sAPPressKeyOnTreekey, nameof(sAPPressKeyOnTreekey), required: true);
            var __workflow_sAPPressKeyOnTreeworkflow = WorkflowExpression.Compile(sAPPressKeyOnTreeworkflow, nameof(sAPPressKeyOnTreeworkflow), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPPressKeyOnTree";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPPressKeyOnTree = new JObject();
                var sAPPressKeyOnTreepropCount = 0;
                sAPPressKeyOnTreepropCount++;
                sAPPressKeyOnTree["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPPressKeyOnTreesearchSAPElementId);
                sAPPressKeyOnTreepropCount++;
                sAPPressKeyOnTree["Key"] = ExpressionConverter.ConvertO(__workflow_sAPPressKeyOnTreekey);
                sAPPressKeyOnTreepropCount++;
                sAPPressKeyOnTree["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPPressKeyOnTreeworkflow);
                if (sAPPressKeyOnTreepropCount > 0)
                {
                    callPayload.Body = sAPPressKeyOnTree;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPOpenContextMenuOnTreeItem(Expression<Func<string>> sAPOpenContextMenuOnTreeItemsearchSAPElementId, Expression<Func<string>> sAPOpenContextMenuOnTreeItemworkflow, Expression<Func<string>> sAPOpenContextMenuOnTreeItemsearchNodeKey = null, Expression<Func<string>> sAPOpenContextMenuOnTreeItemsearchNodePath = null, Expression<Func<string>> sAPOpenContextMenuOnTreeItemsearchNodeText = null, Expression<Func<bool>> sAPOpenContextMenuOnTreeItemsearchNodeTextIsRegularExpression = null, Expression<Func<bool>> sAPOpenContextMenuOnTreeItemsearchNodeTextIsCaseSensitive = null, Expression<Func<string>> sAPOpenContextMenuOnTreeItemsearchColumnName = null, Expression<Func<string>> sAPOpenContextMenuOnTreeItemsearchColumnTitle = null, Expression<Func<bool>> sAPOpenContextMenuOnTreeItemsearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPOpenContextMenuOnTreeItemsearchColumnTitleIsCaseSensitive = null)
        {
            var __workflow_sAPOpenContextMenuOnTreeItemsearchSAPElementId = WorkflowExpression.Compile(sAPOpenContextMenuOnTreeItemsearchSAPElementId, nameof(sAPOpenContextMenuOnTreeItemsearchSAPElementId), required: true);
            var __workflow_sAPOpenContextMenuOnTreeItemworkflow = WorkflowExpression.Compile(sAPOpenContextMenuOnTreeItemworkflow, nameof(sAPOpenContextMenuOnTreeItemworkflow), required: true);
            var __workflow_sAPOpenContextMenuOnTreeItemsearchNodeKey = WorkflowExpression.Compile(sAPOpenContextMenuOnTreeItemsearchNodeKey, nameof(sAPOpenContextMenuOnTreeItemsearchNodeKey), required: false);
            var __workflow_sAPOpenContextMenuOnTreeItemsearchNodePath = WorkflowExpression.Compile(sAPOpenContextMenuOnTreeItemsearchNodePath, nameof(sAPOpenContextMenuOnTreeItemsearchNodePath), required: false);
            var __workflow_sAPOpenContextMenuOnTreeItemsearchNodeText = WorkflowExpression.Compile(sAPOpenContextMenuOnTreeItemsearchNodeText, nameof(sAPOpenContextMenuOnTreeItemsearchNodeText), required: false);
            var __workflow_sAPOpenContextMenuOnTreeItemsearchNodeTextIsRegularExpression = WorkflowExpression.Compile(sAPOpenContextMenuOnTreeItemsearchNodeTextIsRegularExpression, nameof(sAPOpenContextMenuOnTreeItemsearchNodeTextIsRegularExpression), required: false);
            var __workflow_sAPOpenContextMenuOnTreeItemsearchNodeTextIsCaseSensitive = WorkflowExpression.Compile(sAPOpenContextMenuOnTreeItemsearchNodeTextIsCaseSensitive, nameof(sAPOpenContextMenuOnTreeItemsearchNodeTextIsCaseSensitive), required: false);
            var __workflow_sAPOpenContextMenuOnTreeItemsearchColumnName = WorkflowExpression.Compile(sAPOpenContextMenuOnTreeItemsearchColumnName, nameof(sAPOpenContextMenuOnTreeItemsearchColumnName), required: false);
            var __workflow_sAPOpenContextMenuOnTreeItemsearchColumnTitle = WorkflowExpression.Compile(sAPOpenContextMenuOnTreeItemsearchColumnTitle, nameof(sAPOpenContextMenuOnTreeItemsearchColumnTitle), required: false);
            var __workflow_sAPOpenContextMenuOnTreeItemsearchColumnTitleIsRegularExpression = WorkflowExpression.Compile(sAPOpenContextMenuOnTreeItemsearchColumnTitleIsRegularExpression, nameof(sAPOpenContextMenuOnTreeItemsearchColumnTitleIsRegularExpression), required: false);
            var __workflow_sAPOpenContextMenuOnTreeItemsearchColumnTitleIsCaseSensitive = WorkflowExpression.Compile(sAPOpenContextMenuOnTreeItemsearchColumnTitleIsCaseSensitive, nameof(sAPOpenContextMenuOnTreeItemsearchColumnTitleIsCaseSensitive), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPOpenContextMenuOnTreeItem";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPOpenContextMenuOnTreeItem = new JObject();
                var sAPOpenContextMenuOnTreeItempropCount = 0;
                sAPOpenContextMenuOnTreeItempropCount++;
                sAPOpenContextMenuOnTreeItem["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPOpenContextMenuOnTreeItemsearchSAPElementId);
                if (__workflow_sAPOpenContextMenuOnTreeItemsearchNodeKey != null)
                {
                    sAPOpenContextMenuOnTreeItem["SearchNodeKey"] = ExpressionConverter.ConvertO(__workflow_sAPOpenContextMenuOnTreeItemsearchNodeKey);
                    sAPOpenContextMenuOnTreeItempropCount++;
                }

                if (__workflow_sAPOpenContextMenuOnTreeItemsearchNodePath != null)
                {
                    sAPOpenContextMenuOnTreeItem["SearchNodePath"] = ExpressionConverter.ConvertO(__workflow_sAPOpenContextMenuOnTreeItemsearchNodePath);
                    sAPOpenContextMenuOnTreeItempropCount++;
                }

                if (__workflow_sAPOpenContextMenuOnTreeItemsearchNodeText != null)
                {
                    sAPOpenContextMenuOnTreeItem["SearchNodeText"] = ExpressionConverter.ConvertO(__workflow_sAPOpenContextMenuOnTreeItemsearchNodeText);
                    sAPOpenContextMenuOnTreeItempropCount++;
                }

                if (__workflow_sAPOpenContextMenuOnTreeItemsearchNodeTextIsRegularExpression != null)
                {
                    if (__workflow_sAPOpenContextMenuOnTreeItemsearchNodeTextIsRegularExpression != null)
                    {
                        sAPOpenContextMenuOnTreeItem["SearchNodeTextIsRegularExpression"] = ExpressionConverter.ConvertO(__workflow_sAPOpenContextMenuOnTreeItemsearchNodeTextIsRegularExpression);
                        sAPOpenContextMenuOnTreeItempropCount++;
                    }

                    sAPOpenContextMenuOnTreeItempropCount++;
                }
                else
                {
                    sAPOpenContextMenuOnTreeItem["SearchNodeTextIsRegularExpression"] = false;
                    sAPOpenContextMenuOnTreeItempropCount++;
                }

                if (__workflow_sAPOpenContextMenuOnTreeItemsearchNodeTextIsCaseSensitive != null)
                {
                    if (__workflow_sAPOpenContextMenuOnTreeItemsearchNodeTextIsCaseSensitive != null)
                    {
                        sAPOpenContextMenuOnTreeItem["SearchNodeTextIsCaseSensitive"] = ExpressionConverter.ConvertO(__workflow_sAPOpenContextMenuOnTreeItemsearchNodeTextIsCaseSensitive);
                        sAPOpenContextMenuOnTreeItempropCount++;
                    }

                    sAPOpenContextMenuOnTreeItempropCount++;
                }
                else
                {
                    sAPOpenContextMenuOnTreeItem["SearchNodeTextIsCaseSensitive"] = false;
                    sAPOpenContextMenuOnTreeItempropCount++;
                }

                if (__workflow_sAPOpenContextMenuOnTreeItemsearchColumnName != null)
                {
                    sAPOpenContextMenuOnTreeItem["SearchColumnName"] = ExpressionConverter.ConvertO(__workflow_sAPOpenContextMenuOnTreeItemsearchColumnName);
                    sAPOpenContextMenuOnTreeItempropCount++;
                }

                if (__workflow_sAPOpenContextMenuOnTreeItemsearchColumnTitle != null)
                {
                    sAPOpenContextMenuOnTreeItem["SearchColumnTitle"] = ExpressionConverter.ConvertO(__workflow_sAPOpenContextMenuOnTreeItemsearchColumnTitle);
                    sAPOpenContextMenuOnTreeItempropCount++;
                }

                if (__workflow_sAPOpenContextMenuOnTreeItemsearchColumnTitleIsRegularExpression != null)
                {
                    if (__workflow_sAPOpenContextMenuOnTreeItemsearchColumnTitleIsRegularExpression != null)
                    {
                        sAPOpenContextMenuOnTreeItem["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(__workflow_sAPOpenContextMenuOnTreeItemsearchColumnTitleIsRegularExpression);
                        sAPOpenContextMenuOnTreeItempropCount++;
                    }

                    sAPOpenContextMenuOnTreeItempropCount++;
                }
                else
                {
                    sAPOpenContextMenuOnTreeItem["SearchColumnTitleIsRegularExpression"] = false;
                    sAPOpenContextMenuOnTreeItempropCount++;
                }

                if (__workflow_sAPOpenContextMenuOnTreeItemsearchColumnTitleIsCaseSensitive != null)
                {
                    if (__workflow_sAPOpenContextMenuOnTreeItemsearchColumnTitleIsCaseSensitive != null)
                    {
                        sAPOpenContextMenuOnTreeItem["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(__workflow_sAPOpenContextMenuOnTreeItemsearchColumnTitleIsCaseSensitive);
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
                sAPOpenContextMenuOnTreeItem["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPOpenContextMenuOnTreeItemworkflow);
                if (sAPOpenContextMenuOnTreeItempropCount > 0)
                {
                    callPayload.Body = sAPOpenContextMenuOnTreeItem;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetTreeTextContentsResponse, ApiConnectionActionConfiguration> SAPGetTreeTextContents(Expression<Func<string>> sAPGetTreeTextContentssearchSAPElementId, Expression<Func<string>> sAPGetTreeTextContentsworkflow, Expression<Func<int>> sAPGetTreeTextContentsfirstRowToReturn = null, Expression<Func<int>> sAPGetTreeTextContentsmaxRowsToReturn = null, Expression<Func<int>> sAPGetTreeTextContentsfirstColumnToReturn = null, Expression<Func<int>> sAPGetTreeTextContentsmaxColumnsToReturn = null, Expression<Func<bool>> sAPGetTreeTextContentsuseColumnHeadersFromTree = null, Expression<Func<bool>> sAPGetTreeTextContentsreturnRowIndexInOutputCollection = null, Expression<Func<string>> sAPGetTreeTextContentsnameOfColumnToStoreRowIndex = null)
        {
            var __workflow_sAPGetTreeTextContentssearchSAPElementId = WorkflowExpression.Compile(sAPGetTreeTextContentssearchSAPElementId, nameof(sAPGetTreeTextContentssearchSAPElementId), required: true);
            var __workflow_sAPGetTreeTextContentsworkflow = WorkflowExpression.Compile(sAPGetTreeTextContentsworkflow, nameof(sAPGetTreeTextContentsworkflow), required: true);
            var __workflow_sAPGetTreeTextContentsfirstRowToReturn = WorkflowExpression.Compile(sAPGetTreeTextContentsfirstRowToReturn, nameof(sAPGetTreeTextContentsfirstRowToReturn), required: false);
            var __workflow_sAPGetTreeTextContentsmaxRowsToReturn = WorkflowExpression.Compile(sAPGetTreeTextContentsmaxRowsToReturn, nameof(sAPGetTreeTextContentsmaxRowsToReturn), required: false);
            var __workflow_sAPGetTreeTextContentsfirstColumnToReturn = WorkflowExpression.Compile(sAPGetTreeTextContentsfirstColumnToReturn, nameof(sAPGetTreeTextContentsfirstColumnToReturn), required: false);
            var __workflow_sAPGetTreeTextContentsmaxColumnsToReturn = WorkflowExpression.Compile(sAPGetTreeTextContentsmaxColumnsToReturn, nameof(sAPGetTreeTextContentsmaxColumnsToReturn), required: false);
            var __workflow_sAPGetTreeTextContentsuseColumnHeadersFromTree = WorkflowExpression.Compile(sAPGetTreeTextContentsuseColumnHeadersFromTree, nameof(sAPGetTreeTextContentsuseColumnHeadersFromTree), required: false);
            var __workflow_sAPGetTreeTextContentsreturnRowIndexInOutputCollection = WorkflowExpression.Compile(sAPGetTreeTextContentsreturnRowIndexInOutputCollection, nameof(sAPGetTreeTextContentsreturnRowIndexInOutputCollection), required: false);
            var __workflow_sAPGetTreeTextContentsnameOfColumnToStoreRowIndex = WorkflowExpression.Compile(sAPGetTreeTextContentsnameOfColumnToStoreRowIndex, nameof(sAPGetTreeTextContentsnameOfColumnToStoreRowIndex), required: false);
            return new DeferredBodyAction<SAPGetTreeTextContentsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetTreeTextContents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGetTreeTextContents = new JObject();
                var sAPGetTreeTextContentspropCount = 0;
                sAPGetTreeTextContentspropCount++;
                sAPGetTreeTextContents["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPGetTreeTextContentssearchSAPElementId);
                if (__workflow_sAPGetTreeTextContentsfirstRowToReturn != null)
                {
                    if (__workflow_sAPGetTreeTextContentsfirstRowToReturn != null)
                    {
                        sAPGetTreeTextContents["FirstRowToReturn"] = ExpressionConverter.ConvertO(__workflow_sAPGetTreeTextContentsfirstRowToReturn);
                        sAPGetTreeTextContentspropCount++;
                    }

                    sAPGetTreeTextContentspropCount++;
                }
                else
                {
                    sAPGetTreeTextContents["FirstRowToReturn"] = 1;
                    sAPGetTreeTextContentspropCount++;
                }

                if (__workflow_sAPGetTreeTextContentsmaxRowsToReturn != null)
                {
                    if (__workflow_sAPGetTreeTextContentsmaxRowsToReturn != null)
                    {
                        sAPGetTreeTextContents["MaxRowsToReturn"] = ExpressionConverter.ConvertO(__workflow_sAPGetTreeTextContentsmaxRowsToReturn);
                        sAPGetTreeTextContentspropCount++;
                    }

                    sAPGetTreeTextContentspropCount++;
                }
                else
                {
                    sAPGetTreeTextContents["MaxRowsToReturn"] = 0;
                    sAPGetTreeTextContentspropCount++;
                }

                if (__workflow_sAPGetTreeTextContentsfirstColumnToReturn != null)
                {
                    if (__workflow_sAPGetTreeTextContentsfirstColumnToReturn != null)
                    {
                        sAPGetTreeTextContents["FirstColumnToReturn"] = ExpressionConverter.ConvertO(__workflow_sAPGetTreeTextContentsfirstColumnToReturn);
                        sAPGetTreeTextContentspropCount++;
                    }

                    sAPGetTreeTextContentspropCount++;
                }
                else
                {
                    sAPGetTreeTextContents["FirstColumnToReturn"] = 1;
                    sAPGetTreeTextContentspropCount++;
                }

                if (__workflow_sAPGetTreeTextContentsmaxColumnsToReturn != null)
                {
                    if (__workflow_sAPGetTreeTextContentsmaxColumnsToReturn != null)
                    {
                        sAPGetTreeTextContents["MaxColumnsToReturn"] = ExpressionConverter.ConvertO(__workflow_sAPGetTreeTextContentsmaxColumnsToReturn);
                        sAPGetTreeTextContentspropCount++;
                    }

                    sAPGetTreeTextContentspropCount++;
                }
                else
                {
                    sAPGetTreeTextContents["MaxColumnsToReturn"] = 0;
                    sAPGetTreeTextContentspropCount++;
                }

                if (__workflow_sAPGetTreeTextContentsuseColumnHeadersFromTree != null)
                {
                    if (__workflow_sAPGetTreeTextContentsuseColumnHeadersFromTree != null)
                    {
                        sAPGetTreeTextContents["UseColumnHeadersFromTree"] = ExpressionConverter.ConvertO(__workflow_sAPGetTreeTextContentsuseColumnHeadersFromTree);
                        sAPGetTreeTextContentspropCount++;
                    }

                    sAPGetTreeTextContentspropCount++;
                }
                else
                {
                    sAPGetTreeTextContents["UseColumnHeadersFromTree"] = false;
                    sAPGetTreeTextContentspropCount++;
                }

                if (__workflow_sAPGetTreeTextContentsreturnRowIndexInOutputCollection != null)
                {
                    if (__workflow_sAPGetTreeTextContentsreturnRowIndexInOutputCollection != null)
                    {
                        sAPGetTreeTextContents["ReturnRowIndexInOutputCollection"] = ExpressionConverter.ConvertO(__workflow_sAPGetTreeTextContentsreturnRowIndexInOutputCollection);
                        sAPGetTreeTextContentspropCount++;
                    }

                    sAPGetTreeTextContentspropCount++;
                }
                else
                {
                    sAPGetTreeTextContents["ReturnRowIndexInOutputCollection"] = false;
                    sAPGetTreeTextContentspropCount++;
                }

                if (__workflow_sAPGetTreeTextContentsnameOfColumnToStoreRowIndex != null)
                {
                    sAPGetTreeTextContents["NameOfColumnToStoreRowIndex"] = ExpressionConverter.ConvertO(__workflow_sAPGetTreeTextContentsnameOfColumnToStoreRowIndex);
                    sAPGetTreeTextContentspropCount++;
                }

                sAPGetTreeTextContentspropCount++;
                sAPGetTreeTextContents["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPGetTreeTextContentsworkflow);
                if (sAPGetTreeTextContentspropCount > 0)
                {
                    callPayload.Body = sAPGetTreeTextContents;
                }

                return new ApiConnectionAction<SAPGetTreeTextContentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPSetTreeColumnWidth(Expression<Func<string>> sAPSetTreeColumnWidthsearchSAPElementId, Expression<Func<string>> sAPSetTreeColumnWidthworkflow, Expression<Func<string>> sAPSetTreeColumnWidthsearchColumnName = null, Expression<Func<string>> sAPSetTreeColumnWidthsearchColumnTitle = null, Expression<Func<bool>> sAPSetTreeColumnWidthsearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPSetTreeColumnWidthsearchColumnTitleIsCaseSensitive = null, Expression<Func<int>> sAPSetTreeColumnWidthcolumnWidthInPixels = null)
        {
            var __workflow_sAPSetTreeColumnWidthsearchSAPElementId = WorkflowExpression.Compile(sAPSetTreeColumnWidthsearchSAPElementId, nameof(sAPSetTreeColumnWidthsearchSAPElementId), required: true);
            var __workflow_sAPSetTreeColumnWidthworkflow = WorkflowExpression.Compile(sAPSetTreeColumnWidthworkflow, nameof(sAPSetTreeColumnWidthworkflow), required: true);
            var __workflow_sAPSetTreeColumnWidthsearchColumnName = WorkflowExpression.Compile(sAPSetTreeColumnWidthsearchColumnName, nameof(sAPSetTreeColumnWidthsearchColumnName), required: false);
            var __workflow_sAPSetTreeColumnWidthsearchColumnTitle = WorkflowExpression.Compile(sAPSetTreeColumnWidthsearchColumnTitle, nameof(sAPSetTreeColumnWidthsearchColumnTitle), required: false);
            var __workflow_sAPSetTreeColumnWidthsearchColumnTitleIsRegularExpression = WorkflowExpression.Compile(sAPSetTreeColumnWidthsearchColumnTitleIsRegularExpression, nameof(sAPSetTreeColumnWidthsearchColumnTitleIsRegularExpression), required: false);
            var __workflow_sAPSetTreeColumnWidthsearchColumnTitleIsCaseSensitive = WorkflowExpression.Compile(sAPSetTreeColumnWidthsearchColumnTitleIsCaseSensitive, nameof(sAPSetTreeColumnWidthsearchColumnTitleIsCaseSensitive), required: false);
            var __workflow_sAPSetTreeColumnWidthcolumnWidthInPixels = WorkflowExpression.Compile(sAPSetTreeColumnWidthcolumnWidthInPixels, nameof(sAPSetTreeColumnWidthcolumnWidthInPixels), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSetTreeColumnWidth";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPSetTreeColumnWidth = new JObject();
                var sAPSetTreeColumnWidthpropCount = 0;
                sAPSetTreeColumnWidthpropCount++;
                sAPSetTreeColumnWidth["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPSetTreeColumnWidthsearchSAPElementId);
                if (__workflow_sAPSetTreeColumnWidthsearchColumnName != null)
                {
                    sAPSetTreeColumnWidth["SearchColumnName"] = ExpressionConverter.ConvertO(__workflow_sAPSetTreeColumnWidthsearchColumnName);
                    sAPSetTreeColumnWidthpropCount++;
                }

                if (__workflow_sAPSetTreeColumnWidthsearchColumnTitle != null)
                {
                    sAPSetTreeColumnWidth["SearchColumnTitle"] = ExpressionConverter.ConvertO(__workflow_sAPSetTreeColumnWidthsearchColumnTitle);
                    sAPSetTreeColumnWidthpropCount++;
                }

                if (__workflow_sAPSetTreeColumnWidthsearchColumnTitleIsRegularExpression != null)
                {
                    if (__workflow_sAPSetTreeColumnWidthsearchColumnTitleIsRegularExpression != null)
                    {
                        sAPSetTreeColumnWidth["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(__workflow_sAPSetTreeColumnWidthsearchColumnTitleIsRegularExpression);
                        sAPSetTreeColumnWidthpropCount++;
                    }

                    sAPSetTreeColumnWidthpropCount++;
                }
                else
                {
                    sAPSetTreeColumnWidth["SearchColumnTitleIsRegularExpression"] = false;
                    sAPSetTreeColumnWidthpropCount++;
                }

                if (__workflow_sAPSetTreeColumnWidthsearchColumnTitleIsCaseSensitive != null)
                {
                    if (__workflow_sAPSetTreeColumnWidthsearchColumnTitleIsCaseSensitive != null)
                    {
                        sAPSetTreeColumnWidth["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(__workflow_sAPSetTreeColumnWidthsearchColumnTitleIsCaseSensitive);
                        sAPSetTreeColumnWidthpropCount++;
                    }

                    sAPSetTreeColumnWidthpropCount++;
                }
                else
                {
                    sAPSetTreeColumnWidth["SearchColumnTitleIsCaseSensitive"] = false;
                    sAPSetTreeColumnWidthpropCount++;
                }

                if (__workflow_sAPSetTreeColumnWidthcolumnWidthInPixels != null)
                {
                    if (__workflow_sAPSetTreeColumnWidthcolumnWidthInPixels != null)
                    {
                        sAPSetTreeColumnWidth["ColumnWidthInPixels"] = ExpressionConverter.ConvertO(__workflow_sAPSetTreeColumnWidthcolumnWidthInPixels);
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
                sAPSetTreeColumnWidth["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPSetTreeColumnWidthworkflow);
                if (sAPSetTreeColumnWidthpropCount > 0)
                {
                    callPayload.Body = sAPSetTreeColumnWidth;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPPressButtonOnTreeItem(Expression<Func<string>> sAPPressButtonOnTreeItemsearchSAPElementId, Expression<Func<string>> sAPPressButtonOnTreeItemworkflow, Expression<Func<string>> sAPPressButtonOnTreeItemsearchNodeKey = null, Expression<Func<string>> sAPPressButtonOnTreeItemsearchNodePath = null, Expression<Func<string>> sAPPressButtonOnTreeItemsearchNodeText = null, Expression<Func<bool>> sAPPressButtonOnTreeItemsearchNodeTextIsRegularExpression = null, Expression<Func<bool>> sAPPressButtonOnTreeItemsearchNodeTextIsCaseSensitive = null, Expression<Func<string>> sAPPressButtonOnTreeItemsearchColumnName = null, Expression<Func<string>> sAPPressButtonOnTreeItemsearchColumnTitle = null, Expression<Func<bool>> sAPPressButtonOnTreeItemsearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPPressButtonOnTreeItemsearchColumnTitleIsCaseSensitive = null, Expression<Func<bool>> sAPPressButtonOnTreeItemforce = null)
        {
            var __workflow_sAPPressButtonOnTreeItemsearchSAPElementId = WorkflowExpression.Compile(sAPPressButtonOnTreeItemsearchSAPElementId, nameof(sAPPressButtonOnTreeItemsearchSAPElementId), required: true);
            var __workflow_sAPPressButtonOnTreeItemworkflow = WorkflowExpression.Compile(sAPPressButtonOnTreeItemworkflow, nameof(sAPPressButtonOnTreeItemworkflow), required: true);
            var __workflow_sAPPressButtonOnTreeItemsearchNodeKey = WorkflowExpression.Compile(sAPPressButtonOnTreeItemsearchNodeKey, nameof(sAPPressButtonOnTreeItemsearchNodeKey), required: false);
            var __workflow_sAPPressButtonOnTreeItemsearchNodePath = WorkflowExpression.Compile(sAPPressButtonOnTreeItemsearchNodePath, nameof(sAPPressButtonOnTreeItemsearchNodePath), required: false);
            var __workflow_sAPPressButtonOnTreeItemsearchNodeText = WorkflowExpression.Compile(sAPPressButtonOnTreeItemsearchNodeText, nameof(sAPPressButtonOnTreeItemsearchNodeText), required: false);
            var __workflow_sAPPressButtonOnTreeItemsearchNodeTextIsRegularExpression = WorkflowExpression.Compile(sAPPressButtonOnTreeItemsearchNodeTextIsRegularExpression, nameof(sAPPressButtonOnTreeItemsearchNodeTextIsRegularExpression), required: false);
            var __workflow_sAPPressButtonOnTreeItemsearchNodeTextIsCaseSensitive = WorkflowExpression.Compile(sAPPressButtonOnTreeItemsearchNodeTextIsCaseSensitive, nameof(sAPPressButtonOnTreeItemsearchNodeTextIsCaseSensitive), required: false);
            var __workflow_sAPPressButtonOnTreeItemsearchColumnName = WorkflowExpression.Compile(sAPPressButtonOnTreeItemsearchColumnName, nameof(sAPPressButtonOnTreeItemsearchColumnName), required: false);
            var __workflow_sAPPressButtonOnTreeItemsearchColumnTitle = WorkflowExpression.Compile(sAPPressButtonOnTreeItemsearchColumnTitle, nameof(sAPPressButtonOnTreeItemsearchColumnTitle), required: false);
            var __workflow_sAPPressButtonOnTreeItemsearchColumnTitleIsRegularExpression = WorkflowExpression.Compile(sAPPressButtonOnTreeItemsearchColumnTitleIsRegularExpression, nameof(sAPPressButtonOnTreeItemsearchColumnTitleIsRegularExpression), required: false);
            var __workflow_sAPPressButtonOnTreeItemsearchColumnTitleIsCaseSensitive = WorkflowExpression.Compile(sAPPressButtonOnTreeItemsearchColumnTitleIsCaseSensitive, nameof(sAPPressButtonOnTreeItemsearchColumnTitleIsCaseSensitive), required: false);
            var __workflow_sAPPressButtonOnTreeItemforce = WorkflowExpression.Compile(sAPPressButtonOnTreeItemforce, nameof(sAPPressButtonOnTreeItemforce), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPPressButtonOnTreeItem";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPPressButtonOnTreeItem = new JObject();
                var sAPPressButtonOnTreeItempropCount = 0;
                sAPPressButtonOnTreeItempropCount++;
                sAPPressButtonOnTreeItem["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPPressButtonOnTreeItemsearchSAPElementId);
                if (__workflow_sAPPressButtonOnTreeItemsearchNodeKey != null)
                {
                    sAPPressButtonOnTreeItem["SearchNodeKey"] = ExpressionConverter.ConvertO(__workflow_sAPPressButtonOnTreeItemsearchNodeKey);
                    sAPPressButtonOnTreeItempropCount++;
                }

                if (__workflow_sAPPressButtonOnTreeItemsearchNodePath != null)
                {
                    sAPPressButtonOnTreeItem["SearchNodePath"] = ExpressionConverter.ConvertO(__workflow_sAPPressButtonOnTreeItemsearchNodePath);
                    sAPPressButtonOnTreeItempropCount++;
                }

                if (__workflow_sAPPressButtonOnTreeItemsearchNodeText != null)
                {
                    sAPPressButtonOnTreeItem["SearchNodeText"] = ExpressionConverter.ConvertO(__workflow_sAPPressButtonOnTreeItemsearchNodeText);
                    sAPPressButtonOnTreeItempropCount++;
                }

                if (__workflow_sAPPressButtonOnTreeItemsearchNodeTextIsRegularExpression != null)
                {
                    if (__workflow_sAPPressButtonOnTreeItemsearchNodeTextIsRegularExpression != null)
                    {
                        sAPPressButtonOnTreeItem["SearchNodeTextIsRegularExpression"] = ExpressionConverter.ConvertO(__workflow_sAPPressButtonOnTreeItemsearchNodeTextIsRegularExpression);
                        sAPPressButtonOnTreeItempropCount++;
                    }

                    sAPPressButtonOnTreeItempropCount++;
                }
                else
                {
                    sAPPressButtonOnTreeItem["SearchNodeTextIsRegularExpression"] = false;
                    sAPPressButtonOnTreeItempropCount++;
                }

                if (__workflow_sAPPressButtonOnTreeItemsearchNodeTextIsCaseSensitive != null)
                {
                    if (__workflow_sAPPressButtonOnTreeItemsearchNodeTextIsCaseSensitive != null)
                    {
                        sAPPressButtonOnTreeItem["SearchNodeTextIsCaseSensitive"] = ExpressionConverter.ConvertO(__workflow_sAPPressButtonOnTreeItemsearchNodeTextIsCaseSensitive);
                        sAPPressButtonOnTreeItempropCount++;
                    }

                    sAPPressButtonOnTreeItempropCount++;
                }
                else
                {
                    sAPPressButtonOnTreeItem["SearchNodeTextIsCaseSensitive"] = false;
                    sAPPressButtonOnTreeItempropCount++;
                }

                if (__workflow_sAPPressButtonOnTreeItemsearchColumnName != null)
                {
                    sAPPressButtonOnTreeItem["SearchColumnName"] = ExpressionConverter.ConvertO(__workflow_sAPPressButtonOnTreeItemsearchColumnName);
                    sAPPressButtonOnTreeItempropCount++;
                }

                if (__workflow_sAPPressButtonOnTreeItemsearchColumnTitle != null)
                {
                    sAPPressButtonOnTreeItem["SearchColumnTitle"] = ExpressionConverter.ConvertO(__workflow_sAPPressButtonOnTreeItemsearchColumnTitle);
                    sAPPressButtonOnTreeItempropCount++;
                }

                if (__workflow_sAPPressButtonOnTreeItemsearchColumnTitleIsRegularExpression != null)
                {
                    if (__workflow_sAPPressButtonOnTreeItemsearchColumnTitleIsRegularExpression != null)
                    {
                        sAPPressButtonOnTreeItem["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(__workflow_sAPPressButtonOnTreeItemsearchColumnTitleIsRegularExpression);
                        sAPPressButtonOnTreeItempropCount++;
                    }

                    sAPPressButtonOnTreeItempropCount++;
                }
                else
                {
                    sAPPressButtonOnTreeItem["SearchColumnTitleIsRegularExpression"] = false;
                    sAPPressButtonOnTreeItempropCount++;
                }

                if (__workflow_sAPPressButtonOnTreeItemsearchColumnTitleIsCaseSensitive != null)
                {
                    if (__workflow_sAPPressButtonOnTreeItemsearchColumnTitleIsCaseSensitive != null)
                    {
                        sAPPressButtonOnTreeItem["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(__workflow_sAPPressButtonOnTreeItemsearchColumnTitleIsCaseSensitive);
                        sAPPressButtonOnTreeItempropCount++;
                    }

                    sAPPressButtonOnTreeItempropCount++;
                }
                else
                {
                    sAPPressButtonOnTreeItem["SearchColumnTitleIsCaseSensitive"] = false;
                    sAPPressButtonOnTreeItempropCount++;
                }

                if (__workflow_sAPPressButtonOnTreeItemforce != null)
                {
                    if (__workflow_sAPPressButtonOnTreeItemforce != null)
                    {
                        sAPPressButtonOnTreeItem["Force"] = ExpressionConverter.ConvertO(__workflow_sAPPressButtonOnTreeItemforce);
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
                sAPPressButtonOnTreeItem["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPPressButtonOnTreeItemworkflow);
                if (sAPPressButtonOnTreeItempropCount > 0)
                {
                    callPayload.Body = sAPPressButtonOnTreeItem;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPClickLinkOnTreeItem(Expression<Func<string>> sAPClickLinkOnTreeItemsearchSAPElementId, Expression<Func<string>> sAPClickLinkOnTreeItemworkflow, Expression<Func<string>> sAPClickLinkOnTreeItemsearchNodeKey = null, Expression<Func<string>> sAPClickLinkOnTreeItemsearchNodePath = null, Expression<Func<string>> sAPClickLinkOnTreeItemsearchNodeText = null, Expression<Func<bool>> sAPClickLinkOnTreeItemsearchNodeTextIsRegularExpression = null, Expression<Func<bool>> sAPClickLinkOnTreeItemsearchNodeTextIsCaseSensitive = null, Expression<Func<string>> sAPClickLinkOnTreeItemsearchColumnName = null, Expression<Func<string>> sAPClickLinkOnTreeItemsearchColumnTitle = null, Expression<Func<bool>> sAPClickLinkOnTreeItemsearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPClickLinkOnTreeItemsearchColumnTitleIsCaseSensitive = null, Expression<Func<bool>> sAPClickLinkOnTreeItemforce = null)
        {
            var __workflow_sAPClickLinkOnTreeItemsearchSAPElementId = WorkflowExpression.Compile(sAPClickLinkOnTreeItemsearchSAPElementId, nameof(sAPClickLinkOnTreeItemsearchSAPElementId), required: true);
            var __workflow_sAPClickLinkOnTreeItemworkflow = WorkflowExpression.Compile(sAPClickLinkOnTreeItemworkflow, nameof(sAPClickLinkOnTreeItemworkflow), required: true);
            var __workflow_sAPClickLinkOnTreeItemsearchNodeKey = WorkflowExpression.Compile(sAPClickLinkOnTreeItemsearchNodeKey, nameof(sAPClickLinkOnTreeItemsearchNodeKey), required: false);
            var __workflow_sAPClickLinkOnTreeItemsearchNodePath = WorkflowExpression.Compile(sAPClickLinkOnTreeItemsearchNodePath, nameof(sAPClickLinkOnTreeItemsearchNodePath), required: false);
            var __workflow_sAPClickLinkOnTreeItemsearchNodeText = WorkflowExpression.Compile(sAPClickLinkOnTreeItemsearchNodeText, nameof(sAPClickLinkOnTreeItemsearchNodeText), required: false);
            var __workflow_sAPClickLinkOnTreeItemsearchNodeTextIsRegularExpression = WorkflowExpression.Compile(sAPClickLinkOnTreeItemsearchNodeTextIsRegularExpression, nameof(sAPClickLinkOnTreeItemsearchNodeTextIsRegularExpression), required: false);
            var __workflow_sAPClickLinkOnTreeItemsearchNodeTextIsCaseSensitive = WorkflowExpression.Compile(sAPClickLinkOnTreeItemsearchNodeTextIsCaseSensitive, nameof(sAPClickLinkOnTreeItemsearchNodeTextIsCaseSensitive), required: false);
            var __workflow_sAPClickLinkOnTreeItemsearchColumnName = WorkflowExpression.Compile(sAPClickLinkOnTreeItemsearchColumnName, nameof(sAPClickLinkOnTreeItemsearchColumnName), required: false);
            var __workflow_sAPClickLinkOnTreeItemsearchColumnTitle = WorkflowExpression.Compile(sAPClickLinkOnTreeItemsearchColumnTitle, nameof(sAPClickLinkOnTreeItemsearchColumnTitle), required: false);
            var __workflow_sAPClickLinkOnTreeItemsearchColumnTitleIsRegularExpression = WorkflowExpression.Compile(sAPClickLinkOnTreeItemsearchColumnTitleIsRegularExpression, nameof(sAPClickLinkOnTreeItemsearchColumnTitleIsRegularExpression), required: false);
            var __workflow_sAPClickLinkOnTreeItemsearchColumnTitleIsCaseSensitive = WorkflowExpression.Compile(sAPClickLinkOnTreeItemsearchColumnTitleIsCaseSensitive, nameof(sAPClickLinkOnTreeItemsearchColumnTitleIsCaseSensitive), required: false);
            var __workflow_sAPClickLinkOnTreeItemforce = WorkflowExpression.Compile(sAPClickLinkOnTreeItemforce, nameof(sAPClickLinkOnTreeItemforce), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPClickLinkOnTreeItem";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPClickLinkOnTreeItem = new JObject();
                var sAPClickLinkOnTreeItempropCount = 0;
                sAPClickLinkOnTreeItempropCount++;
                sAPClickLinkOnTreeItem["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPClickLinkOnTreeItemsearchSAPElementId);
                if (__workflow_sAPClickLinkOnTreeItemsearchNodeKey != null)
                {
                    sAPClickLinkOnTreeItem["SearchNodeKey"] = ExpressionConverter.ConvertO(__workflow_sAPClickLinkOnTreeItemsearchNodeKey);
                    sAPClickLinkOnTreeItempropCount++;
                }

                if (__workflow_sAPClickLinkOnTreeItemsearchNodePath != null)
                {
                    sAPClickLinkOnTreeItem["SearchNodePath"] = ExpressionConverter.ConvertO(__workflow_sAPClickLinkOnTreeItemsearchNodePath);
                    sAPClickLinkOnTreeItempropCount++;
                }

                if (__workflow_sAPClickLinkOnTreeItemsearchNodeText != null)
                {
                    sAPClickLinkOnTreeItem["SearchNodeText"] = ExpressionConverter.ConvertO(__workflow_sAPClickLinkOnTreeItemsearchNodeText);
                    sAPClickLinkOnTreeItempropCount++;
                }

                if (__workflow_sAPClickLinkOnTreeItemsearchNodeTextIsRegularExpression != null)
                {
                    if (__workflow_sAPClickLinkOnTreeItemsearchNodeTextIsRegularExpression != null)
                    {
                        sAPClickLinkOnTreeItem["SearchNodeTextIsRegularExpression"] = ExpressionConverter.ConvertO(__workflow_sAPClickLinkOnTreeItemsearchNodeTextIsRegularExpression);
                        sAPClickLinkOnTreeItempropCount++;
                    }

                    sAPClickLinkOnTreeItempropCount++;
                }
                else
                {
                    sAPClickLinkOnTreeItem["SearchNodeTextIsRegularExpression"] = false;
                    sAPClickLinkOnTreeItempropCount++;
                }

                if (__workflow_sAPClickLinkOnTreeItemsearchNodeTextIsCaseSensitive != null)
                {
                    if (__workflow_sAPClickLinkOnTreeItemsearchNodeTextIsCaseSensitive != null)
                    {
                        sAPClickLinkOnTreeItem["SearchNodeTextIsCaseSensitive"] = ExpressionConverter.ConvertO(__workflow_sAPClickLinkOnTreeItemsearchNodeTextIsCaseSensitive);
                        sAPClickLinkOnTreeItempropCount++;
                    }

                    sAPClickLinkOnTreeItempropCount++;
                }
                else
                {
                    sAPClickLinkOnTreeItem["SearchNodeTextIsCaseSensitive"] = false;
                    sAPClickLinkOnTreeItempropCount++;
                }

                if (__workflow_sAPClickLinkOnTreeItemsearchColumnName != null)
                {
                    sAPClickLinkOnTreeItem["SearchColumnName"] = ExpressionConverter.ConvertO(__workflow_sAPClickLinkOnTreeItemsearchColumnName);
                    sAPClickLinkOnTreeItempropCount++;
                }

                if (__workflow_sAPClickLinkOnTreeItemsearchColumnTitle != null)
                {
                    sAPClickLinkOnTreeItem["SearchColumnTitle"] = ExpressionConverter.ConvertO(__workflow_sAPClickLinkOnTreeItemsearchColumnTitle);
                    sAPClickLinkOnTreeItempropCount++;
                }

                if (__workflow_sAPClickLinkOnTreeItemsearchColumnTitleIsRegularExpression != null)
                {
                    if (__workflow_sAPClickLinkOnTreeItemsearchColumnTitleIsRegularExpression != null)
                    {
                        sAPClickLinkOnTreeItem["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(__workflow_sAPClickLinkOnTreeItemsearchColumnTitleIsRegularExpression);
                        sAPClickLinkOnTreeItempropCount++;
                    }

                    sAPClickLinkOnTreeItempropCount++;
                }
                else
                {
                    sAPClickLinkOnTreeItem["SearchColumnTitleIsRegularExpression"] = false;
                    sAPClickLinkOnTreeItempropCount++;
                }

                if (__workflow_sAPClickLinkOnTreeItemsearchColumnTitleIsCaseSensitive != null)
                {
                    if (__workflow_sAPClickLinkOnTreeItemsearchColumnTitleIsCaseSensitive != null)
                    {
                        sAPClickLinkOnTreeItem["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(__workflow_sAPClickLinkOnTreeItemsearchColumnTitleIsCaseSensitive);
                        sAPClickLinkOnTreeItempropCount++;
                    }

                    sAPClickLinkOnTreeItempropCount++;
                }
                else
                {
                    sAPClickLinkOnTreeItem["SearchColumnTitleIsCaseSensitive"] = false;
                    sAPClickLinkOnTreeItempropCount++;
                }

                if (__workflow_sAPClickLinkOnTreeItemforce != null)
                {
                    if (__workflow_sAPClickLinkOnTreeItemforce != null)
                    {
                        sAPClickLinkOnTreeItem["Force"] = ExpressionConverter.ConvertO(__workflow_sAPClickLinkOnTreeItemforce);
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
                sAPClickLinkOnTreeItem["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPClickLinkOnTreeItemworkflow);
                if (sAPClickLinkOnTreeItempropCount > 0)
                {
                    callPayload.Body = sAPClickLinkOnTreeItem;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPCheckTreeItem(Expression<Func<string>> sAPCheckTreeItemsearchSAPElementId, Expression<Func<string>> sAPCheckTreeItemworkflow, Expression<Func<string>> sAPCheckTreeItemsearchNodeKey = null, Expression<Func<string>> sAPCheckTreeItemsearchNodePath = null, Expression<Func<string>> sAPCheckTreeItemsearchNodeText = null, Expression<Func<bool>> sAPCheckTreeItemsearchNodeTextIsRegularExpression = null, Expression<Func<bool>> sAPCheckTreeItemsearchNodeTextIsCaseSensitive = null, Expression<Func<string>> sAPCheckTreeItemsearchColumnName = null, Expression<Func<string>> sAPCheckTreeItemsearchColumnTitle = null, Expression<Func<bool>> sAPCheckTreeItemsearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPCheckTreeItemsearchColumnTitleIsCaseSensitive = null, Expression<Func<bool>> sAPCheckTreeItemcheckItem = null, Expression<Func<bool>> sAPCheckTreeItemforce = null)
        {
            var __workflow_sAPCheckTreeItemsearchSAPElementId = WorkflowExpression.Compile(sAPCheckTreeItemsearchSAPElementId, nameof(sAPCheckTreeItemsearchSAPElementId), required: true);
            var __workflow_sAPCheckTreeItemworkflow = WorkflowExpression.Compile(sAPCheckTreeItemworkflow, nameof(sAPCheckTreeItemworkflow), required: true);
            var __workflow_sAPCheckTreeItemsearchNodeKey = WorkflowExpression.Compile(sAPCheckTreeItemsearchNodeKey, nameof(sAPCheckTreeItemsearchNodeKey), required: false);
            var __workflow_sAPCheckTreeItemsearchNodePath = WorkflowExpression.Compile(sAPCheckTreeItemsearchNodePath, nameof(sAPCheckTreeItemsearchNodePath), required: false);
            var __workflow_sAPCheckTreeItemsearchNodeText = WorkflowExpression.Compile(sAPCheckTreeItemsearchNodeText, nameof(sAPCheckTreeItemsearchNodeText), required: false);
            var __workflow_sAPCheckTreeItemsearchNodeTextIsRegularExpression = WorkflowExpression.Compile(sAPCheckTreeItemsearchNodeTextIsRegularExpression, nameof(sAPCheckTreeItemsearchNodeTextIsRegularExpression), required: false);
            var __workflow_sAPCheckTreeItemsearchNodeTextIsCaseSensitive = WorkflowExpression.Compile(sAPCheckTreeItemsearchNodeTextIsCaseSensitive, nameof(sAPCheckTreeItemsearchNodeTextIsCaseSensitive), required: false);
            var __workflow_sAPCheckTreeItemsearchColumnName = WorkflowExpression.Compile(sAPCheckTreeItemsearchColumnName, nameof(sAPCheckTreeItemsearchColumnName), required: false);
            var __workflow_sAPCheckTreeItemsearchColumnTitle = WorkflowExpression.Compile(sAPCheckTreeItemsearchColumnTitle, nameof(sAPCheckTreeItemsearchColumnTitle), required: false);
            var __workflow_sAPCheckTreeItemsearchColumnTitleIsRegularExpression = WorkflowExpression.Compile(sAPCheckTreeItemsearchColumnTitleIsRegularExpression, nameof(sAPCheckTreeItemsearchColumnTitleIsRegularExpression), required: false);
            var __workflow_sAPCheckTreeItemsearchColumnTitleIsCaseSensitive = WorkflowExpression.Compile(sAPCheckTreeItemsearchColumnTitleIsCaseSensitive, nameof(sAPCheckTreeItemsearchColumnTitleIsCaseSensitive), required: false);
            var __workflow_sAPCheckTreeItemcheckItem = WorkflowExpression.Compile(sAPCheckTreeItemcheckItem, nameof(sAPCheckTreeItemcheckItem), required: false);
            var __workflow_sAPCheckTreeItemforce = WorkflowExpression.Compile(sAPCheckTreeItemforce, nameof(sAPCheckTreeItemforce), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPCheckTreeItem";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPCheckTreeItem = new JObject();
                var sAPCheckTreeItempropCount = 0;
                sAPCheckTreeItempropCount++;
                sAPCheckTreeItem["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPCheckTreeItemsearchSAPElementId);
                if (__workflow_sAPCheckTreeItemsearchNodeKey != null)
                {
                    sAPCheckTreeItem["SearchNodeKey"] = ExpressionConverter.ConvertO(__workflow_sAPCheckTreeItemsearchNodeKey);
                    sAPCheckTreeItempropCount++;
                }

                if (__workflow_sAPCheckTreeItemsearchNodePath != null)
                {
                    sAPCheckTreeItem["SearchNodePath"] = ExpressionConverter.ConvertO(__workflow_sAPCheckTreeItemsearchNodePath);
                    sAPCheckTreeItempropCount++;
                }

                if (__workflow_sAPCheckTreeItemsearchNodeText != null)
                {
                    sAPCheckTreeItem["SearchNodeText"] = ExpressionConverter.ConvertO(__workflow_sAPCheckTreeItemsearchNodeText);
                    sAPCheckTreeItempropCount++;
                }

                if (__workflow_sAPCheckTreeItemsearchNodeTextIsRegularExpression != null)
                {
                    if (__workflow_sAPCheckTreeItemsearchNodeTextIsRegularExpression != null)
                    {
                        sAPCheckTreeItem["SearchNodeTextIsRegularExpression"] = ExpressionConverter.ConvertO(__workflow_sAPCheckTreeItemsearchNodeTextIsRegularExpression);
                        sAPCheckTreeItempropCount++;
                    }

                    sAPCheckTreeItempropCount++;
                }
                else
                {
                    sAPCheckTreeItem["SearchNodeTextIsRegularExpression"] = false;
                    sAPCheckTreeItempropCount++;
                }

                if (__workflow_sAPCheckTreeItemsearchNodeTextIsCaseSensitive != null)
                {
                    if (__workflow_sAPCheckTreeItemsearchNodeTextIsCaseSensitive != null)
                    {
                        sAPCheckTreeItem["SearchNodeTextIsCaseSensitive"] = ExpressionConverter.ConvertO(__workflow_sAPCheckTreeItemsearchNodeTextIsCaseSensitive);
                        sAPCheckTreeItempropCount++;
                    }

                    sAPCheckTreeItempropCount++;
                }
                else
                {
                    sAPCheckTreeItem["SearchNodeTextIsCaseSensitive"] = false;
                    sAPCheckTreeItempropCount++;
                }

                if (__workflow_sAPCheckTreeItemsearchColumnName != null)
                {
                    sAPCheckTreeItem["SearchColumnName"] = ExpressionConverter.ConvertO(__workflow_sAPCheckTreeItemsearchColumnName);
                    sAPCheckTreeItempropCount++;
                }

                if (__workflow_sAPCheckTreeItemsearchColumnTitle != null)
                {
                    sAPCheckTreeItem["SearchColumnTitle"] = ExpressionConverter.ConvertO(__workflow_sAPCheckTreeItemsearchColumnTitle);
                    sAPCheckTreeItempropCount++;
                }

                if (__workflow_sAPCheckTreeItemsearchColumnTitleIsRegularExpression != null)
                {
                    if (__workflow_sAPCheckTreeItemsearchColumnTitleIsRegularExpression != null)
                    {
                        sAPCheckTreeItem["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(__workflow_sAPCheckTreeItemsearchColumnTitleIsRegularExpression);
                        sAPCheckTreeItempropCount++;
                    }

                    sAPCheckTreeItempropCount++;
                }
                else
                {
                    sAPCheckTreeItem["SearchColumnTitleIsRegularExpression"] = false;
                    sAPCheckTreeItempropCount++;
                }

                if (__workflow_sAPCheckTreeItemsearchColumnTitleIsCaseSensitive != null)
                {
                    if (__workflow_sAPCheckTreeItemsearchColumnTitleIsCaseSensitive != null)
                    {
                        sAPCheckTreeItem["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(__workflow_sAPCheckTreeItemsearchColumnTitleIsCaseSensitive);
                        sAPCheckTreeItempropCount++;
                    }

                    sAPCheckTreeItempropCount++;
                }
                else
                {
                    sAPCheckTreeItem["SearchColumnTitleIsCaseSensitive"] = false;
                    sAPCheckTreeItempropCount++;
                }

                if (__workflow_sAPCheckTreeItemcheckItem != null)
                {
                    if (__workflow_sAPCheckTreeItemcheckItem != null)
                    {
                        sAPCheckTreeItem["CheckItem"] = ExpressionConverter.ConvertO(__workflow_sAPCheckTreeItemcheckItem);
                        sAPCheckTreeItempropCount++;
                    }

                    sAPCheckTreeItempropCount++;
                }
                else
                {
                    sAPCheckTreeItem["CheckItem"] = true;
                    sAPCheckTreeItempropCount++;
                }

                if (__workflow_sAPCheckTreeItemforce != null)
                {
                    if (__workflow_sAPCheckTreeItemforce != null)
                    {
                        sAPCheckTreeItem["Force"] = ExpressionConverter.ConvertO(__workflow_sAPCheckTreeItemforce);
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
                sAPCheckTreeItem["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPCheckTreeItemworkflow);
                if (sAPCheckTreeItempropCount > 0)
                {
                    callPayload.Body = sAPCheckTreeItem;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetTreeColumnHeadersResponse, ApiConnectionActionConfiguration> SAPGetTreeColumnHeaders(Expression<Func<string>> sAPGetTreeColumnHeaderssearchSAPElementId, Expression<Func<string>> sAPGetTreeColumnHeadersworkflow)
        {
            var __workflow_sAPGetTreeColumnHeaderssearchSAPElementId = WorkflowExpression.Compile(sAPGetTreeColumnHeaderssearchSAPElementId, nameof(sAPGetTreeColumnHeaderssearchSAPElementId), required: true);
            var __workflow_sAPGetTreeColumnHeadersworkflow = WorkflowExpression.Compile(sAPGetTreeColumnHeadersworkflow, nameof(sAPGetTreeColumnHeadersworkflow), required: true);
            return new DeferredBodyAction<SAPGetTreeColumnHeadersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetTreeColumnHeaders";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGetTreeColumnHeaders = new JObject();
                var sAPGetTreeColumnHeaderspropCount = 0;
                sAPGetTreeColumnHeaderspropCount++;
                sAPGetTreeColumnHeaders["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPGetTreeColumnHeaderssearchSAPElementId);
                sAPGetTreeColumnHeaderspropCount++;
                sAPGetTreeColumnHeaders["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPGetTreeColumnHeadersworkflow);
                if (sAPGetTreeColumnHeaderspropCount > 0)
                {
                    callPayload.Body = sAPGetTreeColumnHeaders;
                }

                return new ApiConnectionAction<SAPGetTreeColumnHeadersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetTreeItemPropertiesResponse, ApiConnectionActionConfiguration> SAPGetTreeItemProperties(Expression<Func<string>> sAPGetTreeItemPropertiessearchSAPElementId, Expression<Func<string>> sAPGetTreeItemPropertiesworkflow, Expression<Func<string>> sAPGetTreeItemPropertiessearchNodeKey = null, Expression<Func<string>> sAPGetTreeItemPropertiessearchNodePath = null, Expression<Func<string>> sAPGetTreeItemPropertiessearchNodeText = null, Expression<Func<bool>> sAPGetTreeItemPropertiessearchNodeTextIsRegularExpression = null, Expression<Func<bool>> sAPGetTreeItemPropertiessearchNodeTextIsCaseSensitive = null, Expression<Func<string>> sAPGetTreeItemPropertiessearchColumnName = null, Expression<Func<string>> sAPGetTreeItemPropertiessearchColumnTitle = null, Expression<Func<bool>> sAPGetTreeItemPropertiessearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPGetTreeItemPropertiessearchColumnTitleIsCaseSensitive = null)
        {
            var __workflow_sAPGetTreeItemPropertiessearchSAPElementId = WorkflowExpression.Compile(sAPGetTreeItemPropertiessearchSAPElementId, nameof(sAPGetTreeItemPropertiessearchSAPElementId), required: true);
            var __workflow_sAPGetTreeItemPropertiesworkflow = WorkflowExpression.Compile(sAPGetTreeItemPropertiesworkflow, nameof(sAPGetTreeItemPropertiesworkflow), required: true);
            var __workflow_sAPGetTreeItemPropertiessearchNodeKey = WorkflowExpression.Compile(sAPGetTreeItemPropertiessearchNodeKey, nameof(sAPGetTreeItemPropertiessearchNodeKey), required: false);
            var __workflow_sAPGetTreeItemPropertiessearchNodePath = WorkflowExpression.Compile(sAPGetTreeItemPropertiessearchNodePath, nameof(sAPGetTreeItemPropertiessearchNodePath), required: false);
            var __workflow_sAPGetTreeItemPropertiessearchNodeText = WorkflowExpression.Compile(sAPGetTreeItemPropertiessearchNodeText, nameof(sAPGetTreeItemPropertiessearchNodeText), required: false);
            var __workflow_sAPGetTreeItemPropertiessearchNodeTextIsRegularExpression = WorkflowExpression.Compile(sAPGetTreeItemPropertiessearchNodeTextIsRegularExpression, nameof(sAPGetTreeItemPropertiessearchNodeTextIsRegularExpression), required: false);
            var __workflow_sAPGetTreeItemPropertiessearchNodeTextIsCaseSensitive = WorkflowExpression.Compile(sAPGetTreeItemPropertiessearchNodeTextIsCaseSensitive, nameof(sAPGetTreeItemPropertiessearchNodeTextIsCaseSensitive), required: false);
            var __workflow_sAPGetTreeItemPropertiessearchColumnName = WorkflowExpression.Compile(sAPGetTreeItemPropertiessearchColumnName, nameof(sAPGetTreeItemPropertiessearchColumnName), required: false);
            var __workflow_sAPGetTreeItemPropertiessearchColumnTitle = WorkflowExpression.Compile(sAPGetTreeItemPropertiessearchColumnTitle, nameof(sAPGetTreeItemPropertiessearchColumnTitle), required: false);
            var __workflow_sAPGetTreeItemPropertiessearchColumnTitleIsRegularExpression = WorkflowExpression.Compile(sAPGetTreeItemPropertiessearchColumnTitleIsRegularExpression, nameof(sAPGetTreeItemPropertiessearchColumnTitleIsRegularExpression), required: false);
            var __workflow_sAPGetTreeItemPropertiessearchColumnTitleIsCaseSensitive = WorkflowExpression.Compile(sAPGetTreeItemPropertiessearchColumnTitleIsCaseSensitive, nameof(sAPGetTreeItemPropertiessearchColumnTitleIsCaseSensitive), required: false);
            return new DeferredBodyAction<SAPGetTreeItemPropertiesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetTreeItemProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGetTreeItemProperties = new JObject();
                var sAPGetTreeItemPropertiespropCount = 0;
                sAPGetTreeItemPropertiespropCount++;
                sAPGetTreeItemProperties["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPGetTreeItemPropertiessearchSAPElementId);
                if (__workflow_sAPGetTreeItemPropertiessearchNodeKey != null)
                {
                    sAPGetTreeItemProperties["SearchNodeKey"] = ExpressionConverter.ConvertO(__workflow_sAPGetTreeItemPropertiessearchNodeKey);
                    sAPGetTreeItemPropertiespropCount++;
                }

                if (__workflow_sAPGetTreeItemPropertiessearchNodePath != null)
                {
                    sAPGetTreeItemProperties["SearchNodePath"] = ExpressionConverter.ConvertO(__workflow_sAPGetTreeItemPropertiessearchNodePath);
                    sAPGetTreeItemPropertiespropCount++;
                }

                if (__workflow_sAPGetTreeItemPropertiessearchNodeText != null)
                {
                    sAPGetTreeItemProperties["SearchNodeText"] = ExpressionConverter.ConvertO(__workflow_sAPGetTreeItemPropertiessearchNodeText);
                    sAPGetTreeItemPropertiespropCount++;
                }

                if (__workflow_sAPGetTreeItemPropertiessearchNodeTextIsRegularExpression != null)
                {
                    if (__workflow_sAPGetTreeItemPropertiessearchNodeTextIsRegularExpression != null)
                    {
                        sAPGetTreeItemProperties["SearchNodeTextIsRegularExpression"] = ExpressionConverter.ConvertO(__workflow_sAPGetTreeItemPropertiessearchNodeTextIsRegularExpression);
                        sAPGetTreeItemPropertiespropCount++;
                    }

                    sAPGetTreeItemPropertiespropCount++;
                }
                else
                {
                    sAPGetTreeItemProperties["SearchNodeTextIsRegularExpression"] = false;
                    sAPGetTreeItemPropertiespropCount++;
                }

                if (__workflow_sAPGetTreeItemPropertiessearchNodeTextIsCaseSensitive != null)
                {
                    if (__workflow_sAPGetTreeItemPropertiessearchNodeTextIsCaseSensitive != null)
                    {
                        sAPGetTreeItemProperties["SearchNodeTextIsCaseSensitive"] = ExpressionConverter.ConvertO(__workflow_sAPGetTreeItemPropertiessearchNodeTextIsCaseSensitive);
                        sAPGetTreeItemPropertiespropCount++;
                    }

                    sAPGetTreeItemPropertiespropCount++;
                }
                else
                {
                    sAPGetTreeItemProperties["SearchNodeTextIsCaseSensitive"] = false;
                    sAPGetTreeItemPropertiespropCount++;
                }

                if (__workflow_sAPGetTreeItemPropertiessearchColumnName != null)
                {
                    sAPGetTreeItemProperties["SearchColumnName"] = ExpressionConverter.ConvertO(__workflow_sAPGetTreeItemPropertiessearchColumnName);
                    sAPGetTreeItemPropertiespropCount++;
                }

                if (__workflow_sAPGetTreeItemPropertiessearchColumnTitle != null)
                {
                    sAPGetTreeItemProperties["SearchColumnTitle"] = ExpressionConverter.ConvertO(__workflow_sAPGetTreeItemPropertiessearchColumnTitle);
                    sAPGetTreeItemPropertiespropCount++;
                }

                if (__workflow_sAPGetTreeItemPropertiessearchColumnTitleIsRegularExpression != null)
                {
                    if (__workflow_sAPGetTreeItemPropertiessearchColumnTitleIsRegularExpression != null)
                    {
                        sAPGetTreeItemProperties["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(__workflow_sAPGetTreeItemPropertiessearchColumnTitleIsRegularExpression);
                        sAPGetTreeItemPropertiespropCount++;
                    }

                    sAPGetTreeItemPropertiespropCount++;
                }
                else
                {
                    sAPGetTreeItemProperties["SearchColumnTitleIsRegularExpression"] = false;
                    sAPGetTreeItemPropertiespropCount++;
                }

                if (__workflow_sAPGetTreeItemPropertiessearchColumnTitleIsCaseSensitive != null)
                {
                    if (__workflow_sAPGetTreeItemPropertiessearchColumnTitleIsCaseSensitive != null)
                    {
                        sAPGetTreeItemProperties["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(__workflow_sAPGetTreeItemPropertiessearchColumnTitleIsCaseSensitive);
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
                sAPGetTreeItemProperties["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPGetTreeItemPropertiesworkflow);
                if (sAPGetTreeItemPropertiespropCount > 0)
                {
                    callPayload.Body = sAPGetTreeItemProperties;
                }

                return new ApiConnectionAction<SAPGetTreeItemPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetShellToolbarElementsResponse, ApiConnectionActionConfiguration> SAPGetShellToolbarElements(Expression<Func<string>> sAPGetShellToolbarElementssearchSAPElementId, Expression<Func<string>> sAPGetShellToolbarElementsworkflow)
        {
            var __workflow_sAPGetShellToolbarElementssearchSAPElementId = WorkflowExpression.Compile(sAPGetShellToolbarElementssearchSAPElementId, nameof(sAPGetShellToolbarElementssearchSAPElementId), required: true);
            var __workflow_sAPGetShellToolbarElementsworkflow = WorkflowExpression.Compile(sAPGetShellToolbarElementsworkflow, nameof(sAPGetShellToolbarElementsworkflow), required: true);
            return new DeferredBodyAction<SAPGetShellToolbarElementsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetShellToolbarElements";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGetShellToolbarElements = new JObject();
                var sAPGetShellToolbarElementspropCount = 0;
                sAPGetShellToolbarElementspropCount++;
                sAPGetShellToolbarElements["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPGetShellToolbarElementssearchSAPElementId);
                sAPGetShellToolbarElementspropCount++;
                sAPGetShellToolbarElements["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPGetShellToolbarElementsworkflow);
                if (sAPGetShellToolbarElementspropCount > 0)
                {
                    callPayload.Body = sAPGetShellToolbarElements;
                }

                return new ApiConnectionAction<SAPGetShellToolbarElementsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPPressShellToolbarElement(Expression<Func<string>> sAPPressShellToolbarElementsearchSAPElementId, Expression<Func<string>> sAPPressShellToolbarElementworkflow, Expression<Func<string>> sAPPressShellToolbarElementsearchToolbarElementId = null, Expression<Func<string>> sAPPressShellToolbarElementsearchToolbarElementText = null, Expression<Func<int>> sAPPressShellToolbarElementsearchToolbarElementIndex = null, Expression<Func<bool>> sAPPressShellToolbarElementsearchToolbarTextIsRegularExpression = null, Expression<Func<bool>> sAPPressShellToolbarElementsearchToolbarTextIsCaseSensitive = null)
        {
            var __workflow_sAPPressShellToolbarElementsearchSAPElementId = WorkflowExpression.Compile(sAPPressShellToolbarElementsearchSAPElementId, nameof(sAPPressShellToolbarElementsearchSAPElementId), required: true);
            var __workflow_sAPPressShellToolbarElementworkflow = WorkflowExpression.Compile(sAPPressShellToolbarElementworkflow, nameof(sAPPressShellToolbarElementworkflow), required: true);
            var __workflow_sAPPressShellToolbarElementsearchToolbarElementId = WorkflowExpression.Compile(sAPPressShellToolbarElementsearchToolbarElementId, nameof(sAPPressShellToolbarElementsearchToolbarElementId), required: false);
            var __workflow_sAPPressShellToolbarElementsearchToolbarElementText = WorkflowExpression.Compile(sAPPressShellToolbarElementsearchToolbarElementText, nameof(sAPPressShellToolbarElementsearchToolbarElementText), required: false);
            var __workflow_sAPPressShellToolbarElementsearchToolbarElementIndex = WorkflowExpression.Compile(sAPPressShellToolbarElementsearchToolbarElementIndex, nameof(sAPPressShellToolbarElementsearchToolbarElementIndex), required: false);
            var __workflow_sAPPressShellToolbarElementsearchToolbarTextIsRegularExpression = WorkflowExpression.Compile(sAPPressShellToolbarElementsearchToolbarTextIsRegularExpression, nameof(sAPPressShellToolbarElementsearchToolbarTextIsRegularExpression), required: false);
            var __workflow_sAPPressShellToolbarElementsearchToolbarTextIsCaseSensitive = WorkflowExpression.Compile(sAPPressShellToolbarElementsearchToolbarTextIsCaseSensitive, nameof(sAPPressShellToolbarElementsearchToolbarTextIsCaseSensitive), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPPressShellToolbarElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPPressShellToolbarElement = new JObject();
                var sAPPressShellToolbarElementpropCount = 0;
                sAPPressShellToolbarElementpropCount++;
                sAPPressShellToolbarElement["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPPressShellToolbarElementsearchSAPElementId);
                if (__workflow_sAPPressShellToolbarElementsearchToolbarElementId != null)
                {
                    sAPPressShellToolbarElement["SearchToolbarElementId"] = ExpressionConverter.ConvertO(__workflow_sAPPressShellToolbarElementsearchToolbarElementId);
                    sAPPressShellToolbarElementpropCount++;
                }

                if (__workflow_sAPPressShellToolbarElementsearchToolbarElementText != null)
                {
                    sAPPressShellToolbarElement["SearchToolbarElementText"] = ExpressionConverter.ConvertO(__workflow_sAPPressShellToolbarElementsearchToolbarElementText);
                    sAPPressShellToolbarElementpropCount++;
                }

                if (__workflow_sAPPressShellToolbarElementsearchToolbarElementIndex != null)
                {
                    if (__workflow_sAPPressShellToolbarElementsearchToolbarElementIndex != null)
                    {
                        sAPPressShellToolbarElement["SearchToolbarElementIndex"] = ExpressionConverter.ConvertO(__workflow_sAPPressShellToolbarElementsearchToolbarElementIndex);
                        sAPPressShellToolbarElementpropCount++;
                    }

                    sAPPressShellToolbarElementpropCount++;
                }
                else
                {
                    sAPPressShellToolbarElement["SearchToolbarElementIndex"] = 0;
                    sAPPressShellToolbarElementpropCount++;
                }

                if (__workflow_sAPPressShellToolbarElementsearchToolbarTextIsRegularExpression != null)
                {
                    if (__workflow_sAPPressShellToolbarElementsearchToolbarTextIsRegularExpression != null)
                    {
                        sAPPressShellToolbarElement["SearchToolbarTextIsRegularExpression"] = ExpressionConverter.ConvertO(__workflow_sAPPressShellToolbarElementsearchToolbarTextIsRegularExpression);
                        sAPPressShellToolbarElementpropCount++;
                    }

                    sAPPressShellToolbarElementpropCount++;
                }
                else
                {
                    sAPPressShellToolbarElement["SearchToolbarTextIsRegularExpression"] = false;
                    sAPPressShellToolbarElementpropCount++;
                }

                if (__workflow_sAPPressShellToolbarElementsearchToolbarTextIsCaseSensitive != null)
                {
                    if (__workflow_sAPPressShellToolbarElementsearchToolbarTextIsCaseSensitive != null)
                    {
                        sAPPressShellToolbarElement["SearchToolbarTextIsCaseSensitive"] = ExpressionConverter.ConvertO(__workflow_sAPPressShellToolbarElementsearchToolbarTextIsCaseSensitive);
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
                sAPPressShellToolbarElement["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPPressShellToolbarElementworkflow);
                if (sAPPressShellToolbarElementpropCount > 0)
                {
                    callPayload.Body = sAPPressShellToolbarElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPPressShellToolbarElementContextButton(Expression<Func<string>> sAPPressShellToolbarElementContextButtonsearchSAPElementId, Expression<Func<string>> sAPPressShellToolbarElementContextButtonworkflow, Expression<Func<string>> sAPPressShellToolbarElementContextButtonsearchToolbarElementId = null, Expression<Func<string>> sAPPressShellToolbarElementContextButtonsearchToolbarElementText = null, Expression<Func<int>> sAPPressShellToolbarElementContextButtonsearchToolbarElementIndex = null, Expression<Func<bool>> sAPPressShellToolbarElementContextButtonsearchToolbarTextIsRegularExpression = null, Expression<Func<bool>> sAPPressShellToolbarElementContextButtonsearchToolbarTextIsCaseSensitive = null)
        {
            var __workflow_sAPPressShellToolbarElementContextButtonsearchSAPElementId = WorkflowExpression.Compile(sAPPressShellToolbarElementContextButtonsearchSAPElementId, nameof(sAPPressShellToolbarElementContextButtonsearchSAPElementId), required: true);
            var __workflow_sAPPressShellToolbarElementContextButtonworkflow = WorkflowExpression.Compile(sAPPressShellToolbarElementContextButtonworkflow, nameof(sAPPressShellToolbarElementContextButtonworkflow), required: true);
            var __workflow_sAPPressShellToolbarElementContextButtonsearchToolbarElementId = WorkflowExpression.Compile(sAPPressShellToolbarElementContextButtonsearchToolbarElementId, nameof(sAPPressShellToolbarElementContextButtonsearchToolbarElementId), required: false);
            var __workflow_sAPPressShellToolbarElementContextButtonsearchToolbarElementText = WorkflowExpression.Compile(sAPPressShellToolbarElementContextButtonsearchToolbarElementText, nameof(sAPPressShellToolbarElementContextButtonsearchToolbarElementText), required: false);
            var __workflow_sAPPressShellToolbarElementContextButtonsearchToolbarElementIndex = WorkflowExpression.Compile(sAPPressShellToolbarElementContextButtonsearchToolbarElementIndex, nameof(sAPPressShellToolbarElementContextButtonsearchToolbarElementIndex), required: false);
            var __workflow_sAPPressShellToolbarElementContextButtonsearchToolbarTextIsRegularExpression = WorkflowExpression.Compile(sAPPressShellToolbarElementContextButtonsearchToolbarTextIsRegularExpression, nameof(sAPPressShellToolbarElementContextButtonsearchToolbarTextIsRegularExpression), required: false);
            var __workflow_sAPPressShellToolbarElementContextButtonsearchToolbarTextIsCaseSensitive = WorkflowExpression.Compile(sAPPressShellToolbarElementContextButtonsearchToolbarTextIsCaseSensitive, nameof(sAPPressShellToolbarElementContextButtonsearchToolbarTextIsCaseSensitive), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPPressShellToolbarElementContextButton";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPPressShellToolbarElementContextButton = new JObject();
                var sAPPressShellToolbarElementContextButtonpropCount = 0;
                sAPPressShellToolbarElementContextButtonpropCount++;
                sAPPressShellToolbarElementContextButton["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPPressShellToolbarElementContextButtonsearchSAPElementId);
                if (__workflow_sAPPressShellToolbarElementContextButtonsearchToolbarElementId != null)
                {
                    sAPPressShellToolbarElementContextButton["SearchToolbarElementId"] = ExpressionConverter.ConvertO(__workflow_sAPPressShellToolbarElementContextButtonsearchToolbarElementId);
                    sAPPressShellToolbarElementContextButtonpropCount++;
                }

                if (__workflow_sAPPressShellToolbarElementContextButtonsearchToolbarElementText != null)
                {
                    sAPPressShellToolbarElementContextButton["SearchToolbarElementText"] = ExpressionConverter.ConvertO(__workflow_sAPPressShellToolbarElementContextButtonsearchToolbarElementText);
                    sAPPressShellToolbarElementContextButtonpropCount++;
                }

                if (__workflow_sAPPressShellToolbarElementContextButtonsearchToolbarElementIndex != null)
                {
                    if (__workflow_sAPPressShellToolbarElementContextButtonsearchToolbarElementIndex != null)
                    {
                        sAPPressShellToolbarElementContextButton["SearchToolbarElementIndex"] = ExpressionConverter.ConvertO(__workflow_sAPPressShellToolbarElementContextButtonsearchToolbarElementIndex);
                        sAPPressShellToolbarElementContextButtonpropCount++;
                    }

                    sAPPressShellToolbarElementContextButtonpropCount++;
                }
                else
                {
                    sAPPressShellToolbarElementContextButton["SearchToolbarElementIndex"] = 0;
                    sAPPressShellToolbarElementContextButtonpropCount++;
                }

                if (__workflow_sAPPressShellToolbarElementContextButtonsearchToolbarTextIsRegularExpression != null)
                {
                    if (__workflow_sAPPressShellToolbarElementContextButtonsearchToolbarTextIsRegularExpression != null)
                    {
                        sAPPressShellToolbarElementContextButton["SearchToolbarTextIsRegularExpression"] = ExpressionConverter.ConvertO(__workflow_sAPPressShellToolbarElementContextButtonsearchToolbarTextIsRegularExpression);
                        sAPPressShellToolbarElementContextButtonpropCount++;
                    }

                    sAPPressShellToolbarElementContextButtonpropCount++;
                }
                else
                {
                    sAPPressShellToolbarElementContextButton["SearchToolbarTextIsRegularExpression"] = false;
                    sAPPressShellToolbarElementContextButtonpropCount++;
                }

                if (__workflow_sAPPressShellToolbarElementContextButtonsearchToolbarTextIsCaseSensitive != null)
                {
                    if (__workflow_sAPPressShellToolbarElementContextButtonsearchToolbarTextIsCaseSensitive != null)
                    {
                        sAPPressShellToolbarElementContextButton["SearchToolbarTextIsCaseSensitive"] = ExpressionConverter.ConvertO(__workflow_sAPPressShellToolbarElementContextButtonsearchToolbarTextIsCaseSensitive);
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
                sAPPressShellToolbarElementContextButton["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPPressShellToolbarElementContextButtonworkflow);
                if (sAPPressShellToolbarElementContextButtonpropCount > 0)
                {
                    callPayload.Body = sAPPressShellToolbarElementContextButton;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPSelectShellToolbarMenuItem(Expression<Func<string>> sAPSelectShellToolbarMenuItemsearchSAPElementId, Expression<Func<string>> sAPSelectShellToolbarMenuItemworkflow, Expression<Func<string>> sAPSelectShellToolbarMenuItemsearchToolbarElementId = null, Expression<Func<string>> sAPSelectShellToolbarMenuItemsearchToolbarElementText = null, Expression<Func<int>> sAPSelectShellToolbarMenuItemsearchToolbarElementIndex = null, Expression<Func<bool>> sAPSelectShellToolbarMenuItemsearchToolbarTextIsRegularExpression = null, Expression<Func<bool>> sAPSelectShellToolbarMenuItemsearchToolbarTextIsCaseSensitive = null)
        {
            var __workflow_sAPSelectShellToolbarMenuItemsearchSAPElementId = WorkflowExpression.Compile(sAPSelectShellToolbarMenuItemsearchSAPElementId, nameof(sAPSelectShellToolbarMenuItemsearchSAPElementId), required: true);
            var __workflow_sAPSelectShellToolbarMenuItemworkflow = WorkflowExpression.Compile(sAPSelectShellToolbarMenuItemworkflow, nameof(sAPSelectShellToolbarMenuItemworkflow), required: true);
            var __workflow_sAPSelectShellToolbarMenuItemsearchToolbarElementId = WorkflowExpression.Compile(sAPSelectShellToolbarMenuItemsearchToolbarElementId, nameof(sAPSelectShellToolbarMenuItemsearchToolbarElementId), required: false);
            var __workflow_sAPSelectShellToolbarMenuItemsearchToolbarElementText = WorkflowExpression.Compile(sAPSelectShellToolbarMenuItemsearchToolbarElementText, nameof(sAPSelectShellToolbarMenuItemsearchToolbarElementText), required: false);
            var __workflow_sAPSelectShellToolbarMenuItemsearchToolbarElementIndex = WorkflowExpression.Compile(sAPSelectShellToolbarMenuItemsearchToolbarElementIndex, nameof(sAPSelectShellToolbarMenuItemsearchToolbarElementIndex), required: false);
            var __workflow_sAPSelectShellToolbarMenuItemsearchToolbarTextIsRegularExpression = WorkflowExpression.Compile(sAPSelectShellToolbarMenuItemsearchToolbarTextIsRegularExpression, nameof(sAPSelectShellToolbarMenuItemsearchToolbarTextIsRegularExpression), required: false);
            var __workflow_sAPSelectShellToolbarMenuItemsearchToolbarTextIsCaseSensitive = WorkflowExpression.Compile(sAPSelectShellToolbarMenuItemsearchToolbarTextIsCaseSensitive, nameof(sAPSelectShellToolbarMenuItemsearchToolbarTextIsCaseSensitive), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSelectShellToolbarMenuItem";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPSelectShellToolbarMenuItem = new JObject();
                var sAPSelectShellToolbarMenuItempropCount = 0;
                sAPSelectShellToolbarMenuItempropCount++;
                sAPSelectShellToolbarMenuItem["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPSelectShellToolbarMenuItemsearchSAPElementId);
                if (__workflow_sAPSelectShellToolbarMenuItemsearchToolbarElementId != null)
                {
                    sAPSelectShellToolbarMenuItem["SearchToolbarElementId"] = ExpressionConverter.ConvertO(__workflow_sAPSelectShellToolbarMenuItemsearchToolbarElementId);
                    sAPSelectShellToolbarMenuItempropCount++;
                }

                if (__workflow_sAPSelectShellToolbarMenuItemsearchToolbarElementText != null)
                {
                    sAPSelectShellToolbarMenuItem["SearchToolbarElementText"] = ExpressionConverter.ConvertO(__workflow_sAPSelectShellToolbarMenuItemsearchToolbarElementText);
                    sAPSelectShellToolbarMenuItempropCount++;
                }

                if (__workflow_sAPSelectShellToolbarMenuItemsearchToolbarElementIndex != null)
                {
                    if (__workflow_sAPSelectShellToolbarMenuItemsearchToolbarElementIndex != null)
                    {
                        sAPSelectShellToolbarMenuItem["SearchToolbarElementIndex"] = ExpressionConverter.ConvertO(__workflow_sAPSelectShellToolbarMenuItemsearchToolbarElementIndex);
                        sAPSelectShellToolbarMenuItempropCount++;
                    }

                    sAPSelectShellToolbarMenuItempropCount++;
                }
                else
                {
                    sAPSelectShellToolbarMenuItem["SearchToolbarElementIndex"] = 0;
                    sAPSelectShellToolbarMenuItempropCount++;
                }

                if (__workflow_sAPSelectShellToolbarMenuItemsearchToolbarTextIsRegularExpression != null)
                {
                    if (__workflow_sAPSelectShellToolbarMenuItemsearchToolbarTextIsRegularExpression != null)
                    {
                        sAPSelectShellToolbarMenuItem["SearchToolbarTextIsRegularExpression"] = ExpressionConverter.ConvertO(__workflow_sAPSelectShellToolbarMenuItemsearchToolbarTextIsRegularExpression);
                        sAPSelectShellToolbarMenuItempropCount++;
                    }

                    sAPSelectShellToolbarMenuItempropCount++;
                }
                else
                {
                    sAPSelectShellToolbarMenuItem["SearchToolbarTextIsRegularExpression"] = false;
                    sAPSelectShellToolbarMenuItempropCount++;
                }

                if (__workflow_sAPSelectShellToolbarMenuItemsearchToolbarTextIsCaseSensitive != null)
                {
                    if (__workflow_sAPSelectShellToolbarMenuItemsearchToolbarTextIsCaseSensitive != null)
                    {
                        sAPSelectShellToolbarMenuItem["SearchToolbarTextIsCaseSensitive"] = ExpressionConverter.ConvertO(__workflow_sAPSelectShellToolbarMenuItemsearchToolbarTextIsCaseSensitive);
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
                sAPSelectShellToolbarMenuItem["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPSelectShellToolbarMenuItemworkflow);
                if (sAPSelectShellToolbarMenuItempropCount > 0)
                {
                    callPayload.Body = sAPSelectShellToolbarMenuItem;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetSAPGridViewPropertiesResponse, ApiConnectionActionConfiguration> SAPGetSAPGridViewProperties(Expression<Func<string>> sAPGetSAPGridViewPropertiessearchSAPElementId, Expression<Func<string>> sAPGetSAPGridViewPropertiesworkflow)
        {
            var __workflow_sAPGetSAPGridViewPropertiessearchSAPElementId = WorkflowExpression.Compile(sAPGetSAPGridViewPropertiessearchSAPElementId, nameof(sAPGetSAPGridViewPropertiessearchSAPElementId), required: true);
            var __workflow_sAPGetSAPGridViewPropertiesworkflow = WorkflowExpression.Compile(sAPGetSAPGridViewPropertiesworkflow, nameof(sAPGetSAPGridViewPropertiesworkflow), required: true);
            return new DeferredBodyAction<SAPGetSAPGridViewPropertiesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetSAPGridViewProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGetSAPGridViewProperties = new JObject();
                var sAPGetSAPGridViewPropertiespropCount = 0;
                sAPGetSAPGridViewPropertiespropCount++;
                sAPGetSAPGridViewProperties["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPGetSAPGridViewPropertiessearchSAPElementId);
                sAPGetSAPGridViewPropertiespropCount++;
                sAPGetSAPGridViewProperties["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPGetSAPGridViewPropertiesworkflow);
                if (sAPGetSAPGridViewPropertiespropCount > 0)
                {
                    callPayload.Body = sAPGetSAPGridViewProperties;
                }

                return new ApiConnectionAction<SAPGetSAPGridViewPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetSAPGridViewCellContentsAtIndexResponse, ApiConnectionActionConfiguration> SAPGetSAPGridViewCellContentsAtIndex(Expression<Func<string>> sAPGetSAPGridViewCellContentsAtIndexsearchSAPElementId, Expression<Func<int>> sAPGetSAPGridViewCellContentsAtIndexrowIndex, Expression<Func<string>> sAPGetSAPGridViewCellContentsAtIndexworkflow, Expression<Func<string>> sAPGetSAPGridViewCellContentsAtIndexsearchColumnName = null, Expression<Func<string>> sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitle = null, Expression<Func<bool>> sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitleIsCaseSensitive = null)
        {
            var __workflow_sAPGetSAPGridViewCellContentsAtIndexsearchSAPElementId = WorkflowExpression.Compile(sAPGetSAPGridViewCellContentsAtIndexsearchSAPElementId, nameof(sAPGetSAPGridViewCellContentsAtIndexsearchSAPElementId), required: true);
            var __workflow_sAPGetSAPGridViewCellContentsAtIndexrowIndex = WorkflowExpression.Compile(sAPGetSAPGridViewCellContentsAtIndexrowIndex, nameof(sAPGetSAPGridViewCellContentsAtIndexrowIndex), required: true);
            var __workflow_sAPGetSAPGridViewCellContentsAtIndexworkflow = WorkflowExpression.Compile(sAPGetSAPGridViewCellContentsAtIndexworkflow, nameof(sAPGetSAPGridViewCellContentsAtIndexworkflow), required: true);
            var __workflow_sAPGetSAPGridViewCellContentsAtIndexsearchColumnName = WorkflowExpression.Compile(sAPGetSAPGridViewCellContentsAtIndexsearchColumnName, nameof(sAPGetSAPGridViewCellContentsAtIndexsearchColumnName), required: false);
            var __workflow_sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitle = WorkflowExpression.Compile(sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitle, nameof(sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitle), required: false);
            var __workflow_sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitleIsRegularExpression = WorkflowExpression.Compile(sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitleIsRegularExpression, nameof(sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitleIsRegularExpression), required: false);
            var __workflow_sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitleIsCaseSensitive = WorkflowExpression.Compile(sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitleIsCaseSensitive, nameof(sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitleIsCaseSensitive), required: false);
            return new DeferredBodyAction<SAPGetSAPGridViewCellContentsAtIndexResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetSAPGridViewCellContentsAtIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGetSAPGridViewCellContentsAtIndex = new JObject();
                var sAPGetSAPGridViewCellContentsAtIndexpropCount = 0;
                sAPGetSAPGridViewCellContentsAtIndexpropCount++;
                sAPGetSAPGridViewCellContentsAtIndex["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPGetSAPGridViewCellContentsAtIndexsearchSAPElementId);
                sAPGetSAPGridViewCellContentsAtIndexpropCount++;
                sAPGetSAPGridViewCellContentsAtIndex["RowIndex"] = ExpressionConverter.ConvertO(__workflow_sAPGetSAPGridViewCellContentsAtIndexrowIndex);
                if (__workflow_sAPGetSAPGridViewCellContentsAtIndexsearchColumnName != null)
                {
                    sAPGetSAPGridViewCellContentsAtIndex["SearchColumnName"] = ExpressionConverter.ConvertO(__workflow_sAPGetSAPGridViewCellContentsAtIndexsearchColumnName);
                    sAPGetSAPGridViewCellContentsAtIndexpropCount++;
                }

                if (__workflow_sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitle != null)
                {
                    sAPGetSAPGridViewCellContentsAtIndex["SearchColumnTitle"] = ExpressionConverter.ConvertO(__workflow_sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitle);
                    sAPGetSAPGridViewCellContentsAtIndexpropCount++;
                }

                if (__workflow_sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitleIsRegularExpression != null)
                {
                    if (__workflow_sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitleIsRegularExpression != null)
                    {
                        sAPGetSAPGridViewCellContentsAtIndex["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(__workflow_sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitleIsRegularExpression);
                        sAPGetSAPGridViewCellContentsAtIndexpropCount++;
                    }

                    sAPGetSAPGridViewCellContentsAtIndexpropCount++;
                }
                else
                {
                    sAPGetSAPGridViewCellContentsAtIndex["SearchColumnTitleIsRegularExpression"] = false;
                    sAPGetSAPGridViewCellContentsAtIndexpropCount++;
                }

                if (__workflow_sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitleIsCaseSensitive != null)
                {
                    if (__workflow_sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitleIsCaseSensitive != null)
                    {
                        sAPGetSAPGridViewCellContentsAtIndex["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(__workflow_sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitleIsCaseSensitive);
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
                sAPGetSAPGridViewCellContentsAtIndex["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPGetSAPGridViewCellContentsAtIndexworkflow);
                if (sAPGetSAPGridViewCellContentsAtIndexpropCount > 0)
                {
                    callPayload.Body = sAPGetSAPGridViewCellContentsAtIndex;
                }

                return new ApiConnectionAction<SAPGetSAPGridViewCellContentsAtIndexResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetSAPGridViewCellPropertiesAtIndexResponse, ApiConnectionActionConfiguration> SAPGetSAPGridViewCellPropertiesAtIndex(Expression<Func<string>> sAPGetSAPGridViewCellPropertiesAtIndexsearchSAPElementId, Expression<Func<int>> sAPGetSAPGridViewCellPropertiesAtIndexrowIndex, Expression<Func<string>> sAPGetSAPGridViewCellPropertiesAtIndexworkflow, Expression<Func<string>> sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnName = null, Expression<Func<string>> sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitle = null, Expression<Func<bool>> sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitleIsCaseSensitive = null)
        {
            var __workflow_sAPGetSAPGridViewCellPropertiesAtIndexsearchSAPElementId = WorkflowExpression.Compile(sAPGetSAPGridViewCellPropertiesAtIndexsearchSAPElementId, nameof(sAPGetSAPGridViewCellPropertiesAtIndexsearchSAPElementId), required: true);
            var __workflow_sAPGetSAPGridViewCellPropertiesAtIndexrowIndex = WorkflowExpression.Compile(sAPGetSAPGridViewCellPropertiesAtIndexrowIndex, nameof(sAPGetSAPGridViewCellPropertiesAtIndexrowIndex), required: true);
            var __workflow_sAPGetSAPGridViewCellPropertiesAtIndexworkflow = WorkflowExpression.Compile(sAPGetSAPGridViewCellPropertiesAtIndexworkflow, nameof(sAPGetSAPGridViewCellPropertiesAtIndexworkflow), required: true);
            var __workflow_sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnName = WorkflowExpression.Compile(sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnName, nameof(sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnName), required: false);
            var __workflow_sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitle = WorkflowExpression.Compile(sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitle, nameof(sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitle), required: false);
            var __workflow_sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitleIsRegularExpression = WorkflowExpression.Compile(sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitleIsRegularExpression, nameof(sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitleIsRegularExpression), required: false);
            var __workflow_sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitleIsCaseSensitive = WorkflowExpression.Compile(sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitleIsCaseSensitive, nameof(sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitleIsCaseSensitive), required: false);
            return new DeferredBodyAction<SAPGetSAPGridViewCellPropertiesAtIndexResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetSAPGridViewCellPropertiesAtIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGetSAPGridViewCellPropertiesAtIndex = new JObject();
                var sAPGetSAPGridViewCellPropertiesAtIndexpropCount = 0;
                sAPGetSAPGridViewCellPropertiesAtIndexpropCount++;
                sAPGetSAPGridViewCellPropertiesAtIndex["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPGetSAPGridViewCellPropertiesAtIndexsearchSAPElementId);
                sAPGetSAPGridViewCellPropertiesAtIndexpropCount++;
                sAPGetSAPGridViewCellPropertiesAtIndex["RowIndex"] = ExpressionConverter.ConvertO(__workflow_sAPGetSAPGridViewCellPropertiesAtIndexrowIndex);
                if (__workflow_sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnName != null)
                {
                    sAPGetSAPGridViewCellPropertiesAtIndex["SearchColumnName"] = ExpressionConverter.ConvertO(__workflow_sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnName);
                    sAPGetSAPGridViewCellPropertiesAtIndexpropCount++;
                }

                if (__workflow_sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitle != null)
                {
                    sAPGetSAPGridViewCellPropertiesAtIndex["SearchColumnTitle"] = ExpressionConverter.ConvertO(__workflow_sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitle);
                    sAPGetSAPGridViewCellPropertiesAtIndexpropCount++;
                }

                if (__workflow_sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitleIsRegularExpression != null)
                {
                    if (__workflow_sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitleIsRegularExpression != null)
                    {
                        sAPGetSAPGridViewCellPropertiesAtIndex["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(__workflow_sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitleIsRegularExpression);
                        sAPGetSAPGridViewCellPropertiesAtIndexpropCount++;
                    }

                    sAPGetSAPGridViewCellPropertiesAtIndexpropCount++;
                }
                else
                {
                    sAPGetSAPGridViewCellPropertiesAtIndex["SearchColumnTitleIsRegularExpression"] = false;
                    sAPGetSAPGridViewCellPropertiesAtIndexpropCount++;
                }

                if (__workflow_sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitleIsCaseSensitive != null)
                {
                    if (__workflow_sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitleIsCaseSensitive != null)
                    {
                        sAPGetSAPGridViewCellPropertiesAtIndex["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(__workflow_sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitleIsCaseSensitive);
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
                sAPGetSAPGridViewCellPropertiesAtIndex["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPGetSAPGridViewCellPropertiesAtIndexworkflow);
                if (sAPGetSAPGridViewCellPropertiesAtIndexpropCount > 0)
                {
                    callPayload.Body = sAPGetSAPGridViewCellPropertiesAtIndex;
                }

                return new ApiConnectionAction<SAPGetSAPGridViewCellPropertiesAtIndexResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPDrawRectangleAroundSAPGridViewCellAtIndex(Expression<Func<string>> sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchSAPElementId, Expression<Func<int>> sAPDrawRectangleAroundSAPGridViewCellAtIndexrowIndex, Expression<Func<string>> sAPDrawRectangleAroundSAPGridViewCellAtIndexworkflow, Expression<Func<string>> sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnName = null, Expression<Func<string>> sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitle = null, Expression<Func<bool>> sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive = null, Expression<Func<string>> sAPDrawRectangleAroundSAPGridViewCellAtIndexpenColour = null, Expression<Func<int>> sAPDrawRectangleAroundSAPGridViewCellAtIndexpenThicknessPixels = null)
        {
            var __workflow_sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchSAPElementId = WorkflowExpression.Compile(sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchSAPElementId, nameof(sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchSAPElementId), required: true);
            var __workflow_sAPDrawRectangleAroundSAPGridViewCellAtIndexrowIndex = WorkflowExpression.Compile(sAPDrawRectangleAroundSAPGridViewCellAtIndexrowIndex, nameof(sAPDrawRectangleAroundSAPGridViewCellAtIndexrowIndex), required: true);
            var __workflow_sAPDrawRectangleAroundSAPGridViewCellAtIndexworkflow = WorkflowExpression.Compile(sAPDrawRectangleAroundSAPGridViewCellAtIndexworkflow, nameof(sAPDrawRectangleAroundSAPGridViewCellAtIndexworkflow), required: true);
            var __workflow_sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnName = WorkflowExpression.Compile(sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnName, nameof(sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnName), required: false);
            var __workflow_sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitle = WorkflowExpression.Compile(sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitle, nameof(sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitle), required: false);
            var __workflow_sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression = WorkflowExpression.Compile(sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression, nameof(sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression), required: false);
            var __workflow_sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive = WorkflowExpression.Compile(sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive, nameof(sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive), required: false);
            var __workflow_sAPDrawRectangleAroundSAPGridViewCellAtIndexpenColour = WorkflowExpression.Compile(sAPDrawRectangleAroundSAPGridViewCellAtIndexpenColour, nameof(sAPDrawRectangleAroundSAPGridViewCellAtIndexpenColour), required: false);
            var __workflow_sAPDrawRectangleAroundSAPGridViewCellAtIndexpenThicknessPixels = WorkflowExpression.Compile(sAPDrawRectangleAroundSAPGridViewCellAtIndexpenThicknessPixels, nameof(sAPDrawRectangleAroundSAPGridViewCellAtIndexpenThicknessPixels), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPDrawRectangleAroundSAPGridViewCellAtIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPDrawRectangleAroundSAPGridViewCellAtIndex = new JObject();
                var sAPDrawRectangleAroundSAPGridViewCellAtIndexpropCount = 0;
                sAPDrawRectangleAroundSAPGridViewCellAtIndexpropCount++;
                sAPDrawRectangleAroundSAPGridViewCellAtIndex["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchSAPElementId);
                sAPDrawRectangleAroundSAPGridViewCellAtIndexpropCount++;
                sAPDrawRectangleAroundSAPGridViewCellAtIndex["RowIndex"] = ExpressionConverter.ConvertO(__workflow_sAPDrawRectangleAroundSAPGridViewCellAtIndexrowIndex);
                if (__workflow_sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnName != null)
                {
                    sAPDrawRectangleAroundSAPGridViewCellAtIndex["SearchColumnName"] = ExpressionConverter.ConvertO(__workflow_sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnName);
                    sAPDrawRectangleAroundSAPGridViewCellAtIndexpropCount++;
                }

                if (__workflow_sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitle != null)
                {
                    sAPDrawRectangleAroundSAPGridViewCellAtIndex["SearchColumnTitle"] = ExpressionConverter.ConvertO(__workflow_sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitle);
                    sAPDrawRectangleAroundSAPGridViewCellAtIndexpropCount++;
                }

                if (__workflow_sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression != null)
                {
                    if (__workflow_sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression != null)
                    {
                        sAPDrawRectangleAroundSAPGridViewCellAtIndex["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(__workflow_sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression);
                        sAPDrawRectangleAroundSAPGridViewCellAtIndexpropCount++;
                    }

                    sAPDrawRectangleAroundSAPGridViewCellAtIndexpropCount++;
                }
                else
                {
                    sAPDrawRectangleAroundSAPGridViewCellAtIndex["SearchColumnTitleIsRegularExpression"] = false;
                    sAPDrawRectangleAroundSAPGridViewCellAtIndexpropCount++;
                }

                if (__workflow_sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive != null)
                {
                    if (__workflow_sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive != null)
                    {
                        sAPDrawRectangleAroundSAPGridViewCellAtIndex["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(__workflow_sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive);
                        sAPDrawRectangleAroundSAPGridViewCellAtIndexpropCount++;
                    }

                    sAPDrawRectangleAroundSAPGridViewCellAtIndexpropCount++;
                }
                else
                {
                    sAPDrawRectangleAroundSAPGridViewCellAtIndex["SearchColumnTitleIsCaseSensitive"] = false;
                    sAPDrawRectangleAroundSAPGridViewCellAtIndexpropCount++;
                }

                if (__workflow_sAPDrawRectangleAroundSAPGridViewCellAtIndexpenColour != null)
                {
                    if (__workflow_sAPDrawRectangleAroundSAPGridViewCellAtIndexpenColour != null)
                    {
                        sAPDrawRectangleAroundSAPGridViewCellAtIndex["PenColour"] = ExpressionConverter.ConvertO(__workflow_sAPDrawRectangleAroundSAPGridViewCellAtIndexpenColour);
                        sAPDrawRectangleAroundSAPGridViewCellAtIndexpropCount++;
                    }

                    sAPDrawRectangleAroundSAPGridViewCellAtIndexpropCount++;
                }
                else
                {
                    sAPDrawRectangleAroundSAPGridViewCellAtIndex["PenColour"] = "#009FDE";
                    sAPDrawRectangleAroundSAPGridViewCellAtIndexpropCount++;
                }

                if (__workflow_sAPDrawRectangleAroundSAPGridViewCellAtIndexpenThicknessPixels != null)
                {
                    if (__workflow_sAPDrawRectangleAroundSAPGridViewCellAtIndexpenThicknessPixels != null)
                    {
                        sAPDrawRectangleAroundSAPGridViewCellAtIndex["PenThicknessPixels"] = ExpressionConverter.ConvertO(__workflow_sAPDrawRectangleAroundSAPGridViewCellAtIndexpenThicknessPixels);
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
                sAPDrawRectangleAroundSAPGridViewCellAtIndex["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPDrawRectangleAroundSAPGridViewCellAtIndexworkflow);
                if (sAPDrawRectangleAroundSAPGridViewCellAtIndexpropCount > 0)
                {
                    callPayload.Body = sAPDrawRectangleAroundSAPGridViewCellAtIndex;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPGlobalLeftClickSAPGridViewCellAtIndex(Expression<Func<string>> sAPGlobalLeftClickSAPGridViewCellAtIndexsearchSAPElementId, Expression<Func<int>> sAPGlobalLeftClickSAPGridViewCellAtIndexrowIndex, Expression<Func<string>> sAPGlobalLeftClickSAPGridViewCellAtIndexworkflow, Expression<Func<string>> sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnName = null, Expression<Func<string>> sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitle = null, Expression<Func<bool>> sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive = null, Expression<Func<bool>> sAPGlobalLeftClickSAPGridViewCellAtIndexsetElementWindowTopMost = null, Expression<Func<bool>> sAPGlobalLeftClickSAPGridViewCellAtIndexbringElementWindowToFront = null, Expression<Func<bool>> sAPGlobalLeftClickSAPGridViewCellAtIndextoggleWindow = null, Expression<Func<bool>> sAPGlobalLeftClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent = null, Expression<Func<double>> sAPGlobalLeftClickSAPGridViewCellAtIndextoggleDelay = null, Expression<Func<int>> sAPGlobalLeftClickSAPGridViewCellAtIndexclickOffsetX = null, Expression<Func<int>> sAPGlobalLeftClickSAPGridViewCellAtIndexclickOffsetY = null, Expression<Func<sAPGlobalLeftClickSAPGridViewCellAtIndexoffsetRelativeToInput>> sAPGlobalLeftClickSAPGridViewCellAtIndexoffsetRelativeTo = null)
        {
            var __workflow_sAPGlobalLeftClickSAPGridViewCellAtIndexsearchSAPElementId = WorkflowExpression.Compile(sAPGlobalLeftClickSAPGridViewCellAtIndexsearchSAPElementId, nameof(sAPGlobalLeftClickSAPGridViewCellAtIndexsearchSAPElementId), required: true);
            var __workflow_sAPGlobalLeftClickSAPGridViewCellAtIndexrowIndex = WorkflowExpression.Compile(sAPGlobalLeftClickSAPGridViewCellAtIndexrowIndex, nameof(sAPGlobalLeftClickSAPGridViewCellAtIndexrowIndex), required: true);
            var __workflow_sAPGlobalLeftClickSAPGridViewCellAtIndexworkflow = WorkflowExpression.Compile(sAPGlobalLeftClickSAPGridViewCellAtIndexworkflow, nameof(sAPGlobalLeftClickSAPGridViewCellAtIndexworkflow), required: true);
            var __workflow_sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnName = WorkflowExpression.Compile(sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnName, nameof(sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnName), required: false);
            var __workflow_sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitle = WorkflowExpression.Compile(sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitle, nameof(sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitle), required: false);
            var __workflow_sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression = WorkflowExpression.Compile(sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression, nameof(sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression), required: false);
            var __workflow_sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive = WorkflowExpression.Compile(sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive, nameof(sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive), required: false);
            var __workflow_sAPGlobalLeftClickSAPGridViewCellAtIndexsetElementWindowTopMost = WorkflowExpression.Compile(sAPGlobalLeftClickSAPGridViewCellAtIndexsetElementWindowTopMost, nameof(sAPGlobalLeftClickSAPGridViewCellAtIndexsetElementWindowTopMost), required: false);
            var __workflow_sAPGlobalLeftClickSAPGridViewCellAtIndexbringElementWindowToFront = WorkflowExpression.Compile(sAPGlobalLeftClickSAPGridViewCellAtIndexbringElementWindowToFront, nameof(sAPGlobalLeftClickSAPGridViewCellAtIndexbringElementWindowToFront), required: false);
            var __workflow_sAPGlobalLeftClickSAPGridViewCellAtIndextoggleWindow = WorkflowExpression.Compile(sAPGlobalLeftClickSAPGridViewCellAtIndextoggleWindow, nameof(sAPGlobalLeftClickSAPGridViewCellAtIndextoggleWindow), required: false);
            var __workflow_sAPGlobalLeftClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent = WorkflowExpression.Compile(sAPGlobalLeftClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent, nameof(sAPGlobalLeftClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent), required: false);
            var __workflow_sAPGlobalLeftClickSAPGridViewCellAtIndextoggleDelay = WorkflowExpression.Compile(sAPGlobalLeftClickSAPGridViewCellAtIndextoggleDelay, nameof(sAPGlobalLeftClickSAPGridViewCellAtIndextoggleDelay), required: false);
            var __workflow_sAPGlobalLeftClickSAPGridViewCellAtIndexclickOffsetX = WorkflowExpression.Compile(sAPGlobalLeftClickSAPGridViewCellAtIndexclickOffsetX, nameof(sAPGlobalLeftClickSAPGridViewCellAtIndexclickOffsetX), required: false);
            var __workflow_sAPGlobalLeftClickSAPGridViewCellAtIndexclickOffsetY = WorkflowExpression.Compile(sAPGlobalLeftClickSAPGridViewCellAtIndexclickOffsetY, nameof(sAPGlobalLeftClickSAPGridViewCellAtIndexclickOffsetY), required: false);
            var __workflow_sAPGlobalLeftClickSAPGridViewCellAtIndexoffsetRelativeTo = WorkflowExpression.Compile(sAPGlobalLeftClickSAPGridViewCellAtIndexoffsetRelativeTo, nameof(sAPGlobalLeftClickSAPGridViewCellAtIndexoffsetRelativeTo), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGlobalLeftClickSAPGridViewCellAtIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGlobalLeftClickSAPGridViewCellAtIndex = new JObject();
                var sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount = 0;
                sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
                sAPGlobalLeftClickSAPGridViewCellAtIndex["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalLeftClickSAPGridViewCellAtIndexsearchSAPElementId);
                sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
                sAPGlobalLeftClickSAPGridViewCellAtIndex["RowIndex"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalLeftClickSAPGridViewCellAtIndexrowIndex);
                if (__workflow_sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnName != null)
                {
                    sAPGlobalLeftClickSAPGridViewCellAtIndex["SearchColumnName"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnName);
                    sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
                }

                if (__workflow_sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitle != null)
                {
                    sAPGlobalLeftClickSAPGridViewCellAtIndex["SearchColumnTitle"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitle);
                    sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
                }

                if (__workflow_sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression != null)
                {
                    if (__workflow_sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression != null)
                    {
                        sAPGlobalLeftClickSAPGridViewCellAtIndex["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression);
                        sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
                    }

                    sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
                }
                else
                {
                    sAPGlobalLeftClickSAPGridViewCellAtIndex["SearchColumnTitleIsRegularExpression"] = false;
                    sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
                }

                if (__workflow_sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive != null)
                {
                    if (__workflow_sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive != null)
                    {
                        sAPGlobalLeftClickSAPGridViewCellAtIndex["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive);
                        sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
                    }

                    sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
                }
                else
                {
                    sAPGlobalLeftClickSAPGridViewCellAtIndex["SearchColumnTitleIsCaseSensitive"] = false;
                    sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
                }

                if (__workflow_sAPGlobalLeftClickSAPGridViewCellAtIndexsetElementWindowTopMost != null)
                {
                    if (__workflow_sAPGlobalLeftClickSAPGridViewCellAtIndexsetElementWindowTopMost != null)
                    {
                        sAPGlobalLeftClickSAPGridViewCellAtIndex["SetElementWindowTopMost"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalLeftClickSAPGridViewCellAtIndexsetElementWindowTopMost);
                        sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
                    }

                    sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
                }
                else
                {
                    sAPGlobalLeftClickSAPGridViewCellAtIndex["SetElementWindowTopMost"] = false;
                    sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
                }

                if (__workflow_sAPGlobalLeftClickSAPGridViewCellAtIndexbringElementWindowToFront != null)
                {
                    if (__workflow_sAPGlobalLeftClickSAPGridViewCellAtIndexbringElementWindowToFront != null)
                    {
                        sAPGlobalLeftClickSAPGridViewCellAtIndex["BringElementWindowToFront"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalLeftClickSAPGridViewCellAtIndexbringElementWindowToFront);
                        sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
                    }

                    sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
                }
                else
                {
                    sAPGlobalLeftClickSAPGridViewCellAtIndex["BringElementWindowToFront"] = false;
                    sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
                }

                if (__workflow_sAPGlobalLeftClickSAPGridViewCellAtIndextoggleWindow != null)
                {
                    if (__workflow_sAPGlobalLeftClickSAPGridViewCellAtIndextoggleWindow != null)
                    {
                        sAPGlobalLeftClickSAPGridViewCellAtIndex["ToggleWindow"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalLeftClickSAPGridViewCellAtIndextoggleWindow);
                        sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
                    }

                    sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
                }
                else
                {
                    sAPGlobalLeftClickSAPGridViewCellAtIndex["ToggleWindow"] = true;
                    sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
                }

                if (__workflow_sAPGlobalLeftClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent != null)
                {
                    if (__workflow_sAPGlobalLeftClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent != null)
                    {
                        sAPGlobalLeftClickSAPGridViewCellAtIndex["ToggleUsesGlobalLeftMouseClickAgent"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalLeftClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent);
                        sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
                    }

                    sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
                }
                else
                {
                    sAPGlobalLeftClickSAPGridViewCellAtIndex["ToggleUsesGlobalLeftMouseClickAgent"] = true;
                    sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
                }

                if (__workflow_sAPGlobalLeftClickSAPGridViewCellAtIndextoggleDelay != null)
                {
                    if (__workflow_sAPGlobalLeftClickSAPGridViewCellAtIndextoggleDelay != null)
                    {
                        sAPGlobalLeftClickSAPGridViewCellAtIndex["ToggleDelay"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalLeftClickSAPGridViewCellAtIndextoggleDelay);
                        sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
                    }

                    sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
                }
                else
                {
                    sAPGlobalLeftClickSAPGridViewCellAtIndex["ToggleDelay"] = 0.5;
                    sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
                }

                if (__workflow_sAPGlobalLeftClickSAPGridViewCellAtIndexclickOffsetX != null)
                {
                    if (__workflow_sAPGlobalLeftClickSAPGridViewCellAtIndexclickOffsetX != null)
                    {
                        sAPGlobalLeftClickSAPGridViewCellAtIndex["ClickOffsetX"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalLeftClickSAPGridViewCellAtIndexclickOffsetX);
                        sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
                    }

                    sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
                }
                else
                {
                    sAPGlobalLeftClickSAPGridViewCellAtIndex["ClickOffsetX"] = 0;
                    sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
                }

                if (__workflow_sAPGlobalLeftClickSAPGridViewCellAtIndexclickOffsetY != null)
                {
                    if (__workflow_sAPGlobalLeftClickSAPGridViewCellAtIndexclickOffsetY != null)
                    {
                        sAPGlobalLeftClickSAPGridViewCellAtIndex["ClickOffsetY"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalLeftClickSAPGridViewCellAtIndexclickOffsetY);
                        sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
                    }

                    sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
                }
                else
                {
                    sAPGlobalLeftClickSAPGridViewCellAtIndex["ClickOffsetY"] = 0;
                    sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
                }

                if (__workflow_sAPGlobalLeftClickSAPGridViewCellAtIndexoffsetRelativeTo != null)
                {
                    sAPGlobalLeftClickSAPGridViewCellAtIndex["OffsetRelativeTo"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalLeftClickSAPGridViewCellAtIndexoffsetRelativeTo);
                    sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
                }

                sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
                sAPGlobalLeftClickSAPGridViewCellAtIndex["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalLeftClickSAPGridViewCellAtIndexworkflow);
                if (sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount > 0)
                {
                    callPayload.Body = sAPGlobalLeftClickSAPGridViewCellAtIndex;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPGlobalRightClickSAPGridViewCellAtIndex(Expression<Func<string>> sAPGlobalRightClickSAPGridViewCellAtIndexsearchSAPElementId, Expression<Func<int>> sAPGlobalRightClickSAPGridViewCellAtIndexrowIndex, Expression<Func<string>> sAPGlobalRightClickSAPGridViewCellAtIndexworkflow, Expression<Func<string>> sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnName = null, Expression<Func<string>> sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitle = null, Expression<Func<bool>> sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive = null, Expression<Func<bool>> sAPGlobalRightClickSAPGridViewCellAtIndexsetElementWindowTopMost = null, Expression<Func<bool>> sAPGlobalRightClickSAPGridViewCellAtIndexbringElementWindowToFront = null, Expression<Func<bool>> sAPGlobalRightClickSAPGridViewCellAtIndextoggleWindow = null, Expression<Func<bool>> sAPGlobalRightClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent = null, Expression<Func<double>> sAPGlobalRightClickSAPGridViewCellAtIndextoggleDelay = null, Expression<Func<int>> sAPGlobalRightClickSAPGridViewCellAtIndexclickOffsetX = null, Expression<Func<int>> sAPGlobalRightClickSAPGridViewCellAtIndexclickOffsetY = null, Expression<Func<sAPGlobalRightClickSAPGridViewCellAtIndexoffsetRelativeToInput>> sAPGlobalRightClickSAPGridViewCellAtIndexoffsetRelativeTo = null)
        {
            var __workflow_sAPGlobalRightClickSAPGridViewCellAtIndexsearchSAPElementId = WorkflowExpression.Compile(sAPGlobalRightClickSAPGridViewCellAtIndexsearchSAPElementId, nameof(sAPGlobalRightClickSAPGridViewCellAtIndexsearchSAPElementId), required: true);
            var __workflow_sAPGlobalRightClickSAPGridViewCellAtIndexrowIndex = WorkflowExpression.Compile(sAPGlobalRightClickSAPGridViewCellAtIndexrowIndex, nameof(sAPGlobalRightClickSAPGridViewCellAtIndexrowIndex), required: true);
            var __workflow_sAPGlobalRightClickSAPGridViewCellAtIndexworkflow = WorkflowExpression.Compile(sAPGlobalRightClickSAPGridViewCellAtIndexworkflow, nameof(sAPGlobalRightClickSAPGridViewCellAtIndexworkflow), required: true);
            var __workflow_sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnName = WorkflowExpression.Compile(sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnName, nameof(sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnName), required: false);
            var __workflow_sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitle = WorkflowExpression.Compile(sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitle, nameof(sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitle), required: false);
            var __workflow_sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression = WorkflowExpression.Compile(sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression, nameof(sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression), required: false);
            var __workflow_sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive = WorkflowExpression.Compile(sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive, nameof(sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive), required: false);
            var __workflow_sAPGlobalRightClickSAPGridViewCellAtIndexsetElementWindowTopMost = WorkflowExpression.Compile(sAPGlobalRightClickSAPGridViewCellAtIndexsetElementWindowTopMost, nameof(sAPGlobalRightClickSAPGridViewCellAtIndexsetElementWindowTopMost), required: false);
            var __workflow_sAPGlobalRightClickSAPGridViewCellAtIndexbringElementWindowToFront = WorkflowExpression.Compile(sAPGlobalRightClickSAPGridViewCellAtIndexbringElementWindowToFront, nameof(sAPGlobalRightClickSAPGridViewCellAtIndexbringElementWindowToFront), required: false);
            var __workflow_sAPGlobalRightClickSAPGridViewCellAtIndextoggleWindow = WorkflowExpression.Compile(sAPGlobalRightClickSAPGridViewCellAtIndextoggleWindow, nameof(sAPGlobalRightClickSAPGridViewCellAtIndextoggleWindow), required: false);
            var __workflow_sAPGlobalRightClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent = WorkflowExpression.Compile(sAPGlobalRightClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent, nameof(sAPGlobalRightClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent), required: false);
            var __workflow_sAPGlobalRightClickSAPGridViewCellAtIndextoggleDelay = WorkflowExpression.Compile(sAPGlobalRightClickSAPGridViewCellAtIndextoggleDelay, nameof(sAPGlobalRightClickSAPGridViewCellAtIndextoggleDelay), required: false);
            var __workflow_sAPGlobalRightClickSAPGridViewCellAtIndexclickOffsetX = WorkflowExpression.Compile(sAPGlobalRightClickSAPGridViewCellAtIndexclickOffsetX, nameof(sAPGlobalRightClickSAPGridViewCellAtIndexclickOffsetX), required: false);
            var __workflow_sAPGlobalRightClickSAPGridViewCellAtIndexclickOffsetY = WorkflowExpression.Compile(sAPGlobalRightClickSAPGridViewCellAtIndexclickOffsetY, nameof(sAPGlobalRightClickSAPGridViewCellAtIndexclickOffsetY), required: false);
            var __workflow_sAPGlobalRightClickSAPGridViewCellAtIndexoffsetRelativeTo = WorkflowExpression.Compile(sAPGlobalRightClickSAPGridViewCellAtIndexoffsetRelativeTo, nameof(sAPGlobalRightClickSAPGridViewCellAtIndexoffsetRelativeTo), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGlobalRightClickSAPGridViewCellAtIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGlobalRightClickSAPGridViewCellAtIndex = new JObject();
                var sAPGlobalRightClickSAPGridViewCellAtIndexpropCount = 0;
                sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
                sAPGlobalRightClickSAPGridViewCellAtIndex["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalRightClickSAPGridViewCellAtIndexsearchSAPElementId);
                sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
                sAPGlobalRightClickSAPGridViewCellAtIndex["RowIndex"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalRightClickSAPGridViewCellAtIndexrowIndex);
                if (__workflow_sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnName != null)
                {
                    sAPGlobalRightClickSAPGridViewCellAtIndex["SearchColumnName"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnName);
                    sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
                }

                if (__workflow_sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitle != null)
                {
                    sAPGlobalRightClickSAPGridViewCellAtIndex["SearchColumnTitle"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitle);
                    sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
                }

                if (__workflow_sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression != null)
                {
                    if (__workflow_sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression != null)
                    {
                        sAPGlobalRightClickSAPGridViewCellAtIndex["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression);
                        sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
                    }

                    sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
                }
                else
                {
                    sAPGlobalRightClickSAPGridViewCellAtIndex["SearchColumnTitleIsRegularExpression"] = false;
                    sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
                }

                if (__workflow_sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive != null)
                {
                    if (__workflow_sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive != null)
                    {
                        sAPGlobalRightClickSAPGridViewCellAtIndex["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive);
                        sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
                    }

                    sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
                }
                else
                {
                    sAPGlobalRightClickSAPGridViewCellAtIndex["SearchColumnTitleIsCaseSensitive"] = false;
                    sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
                }

                if (__workflow_sAPGlobalRightClickSAPGridViewCellAtIndexsetElementWindowTopMost != null)
                {
                    if (__workflow_sAPGlobalRightClickSAPGridViewCellAtIndexsetElementWindowTopMost != null)
                    {
                        sAPGlobalRightClickSAPGridViewCellAtIndex["SetElementWindowTopMost"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalRightClickSAPGridViewCellAtIndexsetElementWindowTopMost);
                        sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
                    }

                    sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
                }
                else
                {
                    sAPGlobalRightClickSAPGridViewCellAtIndex["SetElementWindowTopMost"] = false;
                    sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
                }

                if (__workflow_sAPGlobalRightClickSAPGridViewCellAtIndexbringElementWindowToFront != null)
                {
                    if (__workflow_sAPGlobalRightClickSAPGridViewCellAtIndexbringElementWindowToFront != null)
                    {
                        sAPGlobalRightClickSAPGridViewCellAtIndex["BringElementWindowToFront"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalRightClickSAPGridViewCellAtIndexbringElementWindowToFront);
                        sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
                    }

                    sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
                }
                else
                {
                    sAPGlobalRightClickSAPGridViewCellAtIndex["BringElementWindowToFront"] = false;
                    sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
                }

                if (__workflow_sAPGlobalRightClickSAPGridViewCellAtIndextoggleWindow != null)
                {
                    if (__workflow_sAPGlobalRightClickSAPGridViewCellAtIndextoggleWindow != null)
                    {
                        sAPGlobalRightClickSAPGridViewCellAtIndex["ToggleWindow"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalRightClickSAPGridViewCellAtIndextoggleWindow);
                        sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
                    }

                    sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
                }
                else
                {
                    sAPGlobalRightClickSAPGridViewCellAtIndex["ToggleWindow"] = true;
                    sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
                }

                if (__workflow_sAPGlobalRightClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent != null)
                {
                    if (__workflow_sAPGlobalRightClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent != null)
                    {
                        sAPGlobalRightClickSAPGridViewCellAtIndex["ToggleUsesGlobalLeftMouseClickAgent"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalRightClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent);
                        sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
                    }

                    sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
                }
                else
                {
                    sAPGlobalRightClickSAPGridViewCellAtIndex["ToggleUsesGlobalLeftMouseClickAgent"] = true;
                    sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
                }

                if (__workflow_sAPGlobalRightClickSAPGridViewCellAtIndextoggleDelay != null)
                {
                    if (__workflow_sAPGlobalRightClickSAPGridViewCellAtIndextoggleDelay != null)
                    {
                        sAPGlobalRightClickSAPGridViewCellAtIndex["ToggleDelay"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalRightClickSAPGridViewCellAtIndextoggleDelay);
                        sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
                    }

                    sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
                }
                else
                {
                    sAPGlobalRightClickSAPGridViewCellAtIndex["ToggleDelay"] = 0.5;
                    sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
                }

                if (__workflow_sAPGlobalRightClickSAPGridViewCellAtIndexclickOffsetX != null)
                {
                    if (__workflow_sAPGlobalRightClickSAPGridViewCellAtIndexclickOffsetX != null)
                    {
                        sAPGlobalRightClickSAPGridViewCellAtIndex["ClickOffsetX"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalRightClickSAPGridViewCellAtIndexclickOffsetX);
                        sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
                    }

                    sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
                }
                else
                {
                    sAPGlobalRightClickSAPGridViewCellAtIndex["ClickOffsetX"] = 0;
                    sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
                }

                if (__workflow_sAPGlobalRightClickSAPGridViewCellAtIndexclickOffsetY != null)
                {
                    if (__workflow_sAPGlobalRightClickSAPGridViewCellAtIndexclickOffsetY != null)
                    {
                        sAPGlobalRightClickSAPGridViewCellAtIndex["ClickOffsetY"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalRightClickSAPGridViewCellAtIndexclickOffsetY);
                        sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
                    }

                    sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
                }
                else
                {
                    sAPGlobalRightClickSAPGridViewCellAtIndex["ClickOffsetY"] = 0;
                    sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
                }

                if (__workflow_sAPGlobalRightClickSAPGridViewCellAtIndexoffsetRelativeTo != null)
                {
                    sAPGlobalRightClickSAPGridViewCellAtIndex["OffsetRelativeTo"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalRightClickSAPGridViewCellAtIndexoffsetRelativeTo);
                    sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
                }

                sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
                sAPGlobalRightClickSAPGridViewCellAtIndex["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalRightClickSAPGridViewCellAtIndexworkflow);
                if (sAPGlobalRightClickSAPGridViewCellAtIndexpropCount > 0)
                {
                    callPayload.Body = sAPGlobalRightClickSAPGridViewCellAtIndex;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPGlobalDoubleLeftClickSAPGridViewCellAtIndex(Expression<Func<string>> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchSAPElementId, Expression<Func<int>> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexrowIndex, Expression<Func<string>> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexworkflow, Expression<Func<string>> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnName = null, Expression<Func<string>> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitle = null, Expression<Func<bool>> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive = null, Expression<Func<bool>> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsetElementWindowTopMost = null, Expression<Func<bool>> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexbringElementWindowToFront = null, Expression<Func<bool>> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleWindow = null, Expression<Func<bool>> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent = null, Expression<Func<double>> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleDelay = null, Expression<Func<int>> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexclickOffsetX = null, Expression<Func<int>> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexclickOffsetY = null, Expression<Func<sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexoffsetRelativeToInput>> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexoffsetRelativeTo = null, Expression<Func<int>> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexdoubleClickDelayInMilliseconds = null)
        {
            var __workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchSAPElementId = WorkflowExpression.Compile(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchSAPElementId, nameof(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchSAPElementId), required: true);
            var __workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexrowIndex = WorkflowExpression.Compile(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexrowIndex, nameof(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexrowIndex), required: true);
            var __workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexworkflow = WorkflowExpression.Compile(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexworkflow, nameof(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexworkflow), required: true);
            var __workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnName = WorkflowExpression.Compile(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnName, nameof(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnName), required: false);
            var __workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitle = WorkflowExpression.Compile(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitle, nameof(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitle), required: false);
            var __workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression = WorkflowExpression.Compile(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression, nameof(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression), required: false);
            var __workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive = WorkflowExpression.Compile(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive, nameof(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive), required: false);
            var __workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsetElementWindowTopMost = WorkflowExpression.Compile(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsetElementWindowTopMost, nameof(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsetElementWindowTopMost), required: false);
            var __workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexbringElementWindowToFront = WorkflowExpression.Compile(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexbringElementWindowToFront, nameof(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexbringElementWindowToFront), required: false);
            var __workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleWindow = WorkflowExpression.Compile(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleWindow, nameof(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleWindow), required: false);
            var __workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent = WorkflowExpression.Compile(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent, nameof(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent), required: false);
            var __workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleDelay = WorkflowExpression.Compile(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleDelay, nameof(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleDelay), required: false);
            var __workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexclickOffsetX = WorkflowExpression.Compile(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexclickOffsetX, nameof(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexclickOffsetX), required: false);
            var __workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexclickOffsetY = WorkflowExpression.Compile(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexclickOffsetY, nameof(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexclickOffsetY), required: false);
            var __workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexoffsetRelativeTo = WorkflowExpression.Compile(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexoffsetRelativeTo, nameof(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexoffsetRelativeTo), required: false);
            var __workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexdoubleClickDelayInMilliseconds = WorkflowExpression.Compile(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexdoubleClickDelayInMilliseconds, nameof(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexdoubleClickDelayInMilliseconds), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGlobalDoubleLeftClickSAPGridViewCellAtIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex = new JObject();
                var sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount = 0;
                sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
                sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchSAPElementId);
                sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
                sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["RowIndex"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexrowIndex);
                if (__workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnName != null)
                {
                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["SearchColumnName"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnName);
                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
                }

                if (__workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitle != null)
                {
                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["SearchColumnTitle"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitle);
                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
                }

                if (__workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression != null)
                {
                    if (__workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression != null)
                    {
                        sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression);
                        sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
                    }

                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
                }
                else
                {
                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["SearchColumnTitleIsRegularExpression"] = false;
                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
                }

                if (__workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive != null)
                {
                    if (__workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive != null)
                    {
                        sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive);
                        sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
                    }

                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
                }
                else
                {
                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["SearchColumnTitleIsCaseSensitive"] = false;
                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
                }

                if (__workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsetElementWindowTopMost != null)
                {
                    if (__workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsetElementWindowTopMost != null)
                    {
                        sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["SetElementWindowTopMost"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsetElementWindowTopMost);
                        sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
                    }

                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
                }
                else
                {
                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["SetElementWindowTopMost"] = false;
                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
                }

                if (__workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexbringElementWindowToFront != null)
                {
                    if (__workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexbringElementWindowToFront != null)
                    {
                        sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["BringElementWindowToFront"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexbringElementWindowToFront);
                        sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
                    }

                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
                }
                else
                {
                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["BringElementWindowToFront"] = false;
                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
                }

                if (__workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleWindow != null)
                {
                    if (__workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleWindow != null)
                    {
                        sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["ToggleWindow"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleWindow);
                        sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
                    }

                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
                }
                else
                {
                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["ToggleWindow"] = true;
                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
                }

                if (__workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent != null)
                {
                    if (__workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent != null)
                    {
                        sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["ToggleUsesGlobalLeftMouseClickAgent"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent);
                        sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
                    }

                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
                }
                else
                {
                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["ToggleUsesGlobalLeftMouseClickAgent"] = true;
                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
                }

                if (__workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleDelay != null)
                {
                    if (__workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleDelay != null)
                    {
                        sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["ToggleDelay"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleDelay);
                        sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
                    }

                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
                }
                else
                {
                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["ToggleDelay"] = 0.5;
                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
                }

                if (__workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexclickOffsetX != null)
                {
                    if (__workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexclickOffsetX != null)
                    {
                        sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["ClickOffsetX"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexclickOffsetX);
                        sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
                    }

                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
                }
                else
                {
                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["ClickOffsetX"] = 0;
                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
                }

                if (__workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexclickOffsetY != null)
                {
                    if (__workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexclickOffsetY != null)
                    {
                        sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["ClickOffsetY"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexclickOffsetY);
                        sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
                    }

                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
                }
                else
                {
                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["ClickOffsetY"] = 0;
                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
                }

                if (__workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexoffsetRelativeTo != null)
                {
                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["OffsetRelativeTo"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexoffsetRelativeTo);
                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
                }

                if (__workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexdoubleClickDelayInMilliseconds != null)
                {
                    if (__workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexdoubleClickDelayInMilliseconds != null)
                    {
                        sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["DoubleClickDelayInMilliseconds"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexdoubleClickDelayInMilliseconds);
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
                sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexworkflow);
                if (sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount > 0)
                {
                    callPayload.Body = sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetSAPGridViewColumnHeadersResponse, ApiConnectionActionConfiguration> SAPGetSAPGridViewColumnHeaders(Expression<Func<string>> sAPGetSAPGridViewColumnHeaderssearchSAPElementId, Expression<Func<string>> sAPGetSAPGridViewColumnHeadersworkflow)
        {
            var __workflow_sAPGetSAPGridViewColumnHeaderssearchSAPElementId = WorkflowExpression.Compile(sAPGetSAPGridViewColumnHeaderssearchSAPElementId, nameof(sAPGetSAPGridViewColumnHeaderssearchSAPElementId), required: true);
            var __workflow_sAPGetSAPGridViewColumnHeadersworkflow = WorkflowExpression.Compile(sAPGetSAPGridViewColumnHeadersworkflow, nameof(sAPGetSAPGridViewColumnHeadersworkflow), required: true);
            return new DeferredBodyAction<SAPGetSAPGridViewColumnHeadersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetSAPGridViewColumnHeaders";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGetSAPGridViewColumnHeaders = new JObject();
                var sAPGetSAPGridViewColumnHeaderspropCount = 0;
                sAPGetSAPGridViewColumnHeaderspropCount++;
                sAPGetSAPGridViewColumnHeaders["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPGetSAPGridViewColumnHeaderssearchSAPElementId);
                sAPGetSAPGridViewColumnHeaderspropCount++;
                sAPGetSAPGridViewColumnHeaders["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPGetSAPGridViewColumnHeadersworkflow);
                if (sAPGetSAPGridViewColumnHeaderspropCount > 0)
                {
                    callPayload.Body = sAPGetSAPGridViewColumnHeaders;
                }

                return new ApiConnectionAction<SAPGetSAPGridViewColumnHeadersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPClickSAPGridViewCellAtIndex(Expression<Func<string>> sAPClickSAPGridViewCellAtIndexsearchSAPElementId, Expression<Func<int>> sAPClickSAPGridViewCellAtIndexrowIndex, Expression<Func<string>> sAPClickSAPGridViewCellAtIndexworkflow, Expression<Func<string>> sAPClickSAPGridViewCellAtIndexsearchColumnName = null, Expression<Func<string>> sAPClickSAPGridViewCellAtIndexsearchColumnTitle = null, Expression<Func<bool>> sAPClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive = null)
        {
            var __workflow_sAPClickSAPGridViewCellAtIndexsearchSAPElementId = WorkflowExpression.Compile(sAPClickSAPGridViewCellAtIndexsearchSAPElementId, nameof(sAPClickSAPGridViewCellAtIndexsearchSAPElementId), required: true);
            var __workflow_sAPClickSAPGridViewCellAtIndexrowIndex = WorkflowExpression.Compile(sAPClickSAPGridViewCellAtIndexrowIndex, nameof(sAPClickSAPGridViewCellAtIndexrowIndex), required: true);
            var __workflow_sAPClickSAPGridViewCellAtIndexworkflow = WorkflowExpression.Compile(sAPClickSAPGridViewCellAtIndexworkflow, nameof(sAPClickSAPGridViewCellAtIndexworkflow), required: true);
            var __workflow_sAPClickSAPGridViewCellAtIndexsearchColumnName = WorkflowExpression.Compile(sAPClickSAPGridViewCellAtIndexsearchColumnName, nameof(sAPClickSAPGridViewCellAtIndexsearchColumnName), required: false);
            var __workflow_sAPClickSAPGridViewCellAtIndexsearchColumnTitle = WorkflowExpression.Compile(sAPClickSAPGridViewCellAtIndexsearchColumnTitle, nameof(sAPClickSAPGridViewCellAtIndexsearchColumnTitle), required: false);
            var __workflow_sAPClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression = WorkflowExpression.Compile(sAPClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression, nameof(sAPClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression), required: false);
            var __workflow_sAPClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive = WorkflowExpression.Compile(sAPClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive, nameof(sAPClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPClickSAPGridViewCellAtIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPClickSAPGridViewCellAtIndex = new JObject();
                var sAPClickSAPGridViewCellAtIndexpropCount = 0;
                sAPClickSAPGridViewCellAtIndexpropCount++;
                sAPClickSAPGridViewCellAtIndex["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPClickSAPGridViewCellAtIndexsearchSAPElementId);
                sAPClickSAPGridViewCellAtIndexpropCount++;
                sAPClickSAPGridViewCellAtIndex["RowIndex"] = ExpressionConverter.ConvertO(__workflow_sAPClickSAPGridViewCellAtIndexrowIndex);
                if (__workflow_sAPClickSAPGridViewCellAtIndexsearchColumnName != null)
                {
                    sAPClickSAPGridViewCellAtIndex["SearchColumnName"] = ExpressionConverter.ConvertO(__workflow_sAPClickSAPGridViewCellAtIndexsearchColumnName);
                    sAPClickSAPGridViewCellAtIndexpropCount++;
                }

                if (__workflow_sAPClickSAPGridViewCellAtIndexsearchColumnTitle != null)
                {
                    sAPClickSAPGridViewCellAtIndex["SearchColumnTitle"] = ExpressionConverter.ConvertO(__workflow_sAPClickSAPGridViewCellAtIndexsearchColumnTitle);
                    sAPClickSAPGridViewCellAtIndexpropCount++;
                }

                if (__workflow_sAPClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression != null)
                {
                    if (__workflow_sAPClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression != null)
                    {
                        sAPClickSAPGridViewCellAtIndex["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(__workflow_sAPClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression);
                        sAPClickSAPGridViewCellAtIndexpropCount++;
                    }

                    sAPClickSAPGridViewCellAtIndexpropCount++;
                }
                else
                {
                    sAPClickSAPGridViewCellAtIndex["SearchColumnTitleIsRegularExpression"] = false;
                    sAPClickSAPGridViewCellAtIndexpropCount++;
                }

                if (__workflow_sAPClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive != null)
                {
                    if (__workflow_sAPClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive != null)
                    {
                        sAPClickSAPGridViewCellAtIndex["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(__workflow_sAPClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive);
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
                sAPClickSAPGridViewCellAtIndex["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPClickSAPGridViewCellAtIndexworkflow);
                if (sAPClickSAPGridViewCellAtIndexpropCount > 0)
                {
                    callPayload.Body = sAPClickSAPGridViewCellAtIndex;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPDoubleClickSAPGridViewCellAtIndex(Expression<Func<string>> sAPDoubleClickSAPGridViewCellAtIndexsearchSAPElementId, Expression<Func<int>> sAPDoubleClickSAPGridViewCellAtIndexrowIndex, Expression<Func<string>> sAPDoubleClickSAPGridViewCellAtIndexworkflow, Expression<Func<string>> sAPDoubleClickSAPGridViewCellAtIndexsearchColumnName = null, Expression<Func<string>> sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitle = null, Expression<Func<bool>> sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive = null)
        {
            var __workflow_sAPDoubleClickSAPGridViewCellAtIndexsearchSAPElementId = WorkflowExpression.Compile(sAPDoubleClickSAPGridViewCellAtIndexsearchSAPElementId, nameof(sAPDoubleClickSAPGridViewCellAtIndexsearchSAPElementId), required: true);
            var __workflow_sAPDoubleClickSAPGridViewCellAtIndexrowIndex = WorkflowExpression.Compile(sAPDoubleClickSAPGridViewCellAtIndexrowIndex, nameof(sAPDoubleClickSAPGridViewCellAtIndexrowIndex), required: true);
            var __workflow_sAPDoubleClickSAPGridViewCellAtIndexworkflow = WorkflowExpression.Compile(sAPDoubleClickSAPGridViewCellAtIndexworkflow, nameof(sAPDoubleClickSAPGridViewCellAtIndexworkflow), required: true);
            var __workflow_sAPDoubleClickSAPGridViewCellAtIndexsearchColumnName = WorkflowExpression.Compile(sAPDoubleClickSAPGridViewCellAtIndexsearchColumnName, nameof(sAPDoubleClickSAPGridViewCellAtIndexsearchColumnName), required: false);
            var __workflow_sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitle = WorkflowExpression.Compile(sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitle, nameof(sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitle), required: false);
            var __workflow_sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression = WorkflowExpression.Compile(sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression, nameof(sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression), required: false);
            var __workflow_sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive = WorkflowExpression.Compile(sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive, nameof(sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPDoubleClickSAPGridViewCellAtIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPDoubleClickSAPGridViewCellAtIndex = new JObject();
                var sAPDoubleClickSAPGridViewCellAtIndexpropCount = 0;
                sAPDoubleClickSAPGridViewCellAtIndexpropCount++;
                sAPDoubleClickSAPGridViewCellAtIndex["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPDoubleClickSAPGridViewCellAtIndexsearchSAPElementId);
                sAPDoubleClickSAPGridViewCellAtIndexpropCount++;
                sAPDoubleClickSAPGridViewCellAtIndex["RowIndex"] = ExpressionConverter.ConvertO(__workflow_sAPDoubleClickSAPGridViewCellAtIndexrowIndex);
                if (__workflow_sAPDoubleClickSAPGridViewCellAtIndexsearchColumnName != null)
                {
                    sAPDoubleClickSAPGridViewCellAtIndex["SearchColumnName"] = ExpressionConverter.ConvertO(__workflow_sAPDoubleClickSAPGridViewCellAtIndexsearchColumnName);
                    sAPDoubleClickSAPGridViewCellAtIndexpropCount++;
                }

                if (__workflow_sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitle != null)
                {
                    sAPDoubleClickSAPGridViewCellAtIndex["SearchColumnTitle"] = ExpressionConverter.ConvertO(__workflow_sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitle);
                    sAPDoubleClickSAPGridViewCellAtIndexpropCount++;
                }

                if (__workflow_sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression != null)
                {
                    if (__workflow_sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression != null)
                    {
                        sAPDoubleClickSAPGridViewCellAtIndex["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(__workflow_sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression);
                        sAPDoubleClickSAPGridViewCellAtIndexpropCount++;
                    }

                    sAPDoubleClickSAPGridViewCellAtIndexpropCount++;
                }
                else
                {
                    sAPDoubleClickSAPGridViewCellAtIndex["SearchColumnTitleIsRegularExpression"] = false;
                    sAPDoubleClickSAPGridViewCellAtIndexpropCount++;
                }

                if (__workflow_sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive != null)
                {
                    if (__workflow_sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive != null)
                    {
                        sAPDoubleClickSAPGridViewCellAtIndex["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(__workflow_sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive);
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
                sAPDoubleClickSAPGridViewCellAtIndex["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPDoubleClickSAPGridViewCellAtIndexworkflow);
                if (sAPDoubleClickSAPGridViewCellAtIndexpropCount > 0)
                {
                    callPayload.Body = sAPDoubleClickSAPGridViewCellAtIndex;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPPressSAPGridViewCellButtonAtIndex(Expression<Func<string>> sAPPressSAPGridViewCellButtonAtIndexsearchSAPElementId, Expression<Func<int>> sAPPressSAPGridViewCellButtonAtIndexrowIndex, Expression<Func<string>> sAPPressSAPGridViewCellButtonAtIndexworkflow, Expression<Func<string>> sAPPressSAPGridViewCellButtonAtIndexsearchColumnName = null, Expression<Func<string>> sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitle = null, Expression<Func<bool>> sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitleIsCaseSensitive = null)
        {
            var __workflow_sAPPressSAPGridViewCellButtonAtIndexsearchSAPElementId = WorkflowExpression.Compile(sAPPressSAPGridViewCellButtonAtIndexsearchSAPElementId, nameof(sAPPressSAPGridViewCellButtonAtIndexsearchSAPElementId), required: true);
            var __workflow_sAPPressSAPGridViewCellButtonAtIndexrowIndex = WorkflowExpression.Compile(sAPPressSAPGridViewCellButtonAtIndexrowIndex, nameof(sAPPressSAPGridViewCellButtonAtIndexrowIndex), required: true);
            var __workflow_sAPPressSAPGridViewCellButtonAtIndexworkflow = WorkflowExpression.Compile(sAPPressSAPGridViewCellButtonAtIndexworkflow, nameof(sAPPressSAPGridViewCellButtonAtIndexworkflow), required: true);
            var __workflow_sAPPressSAPGridViewCellButtonAtIndexsearchColumnName = WorkflowExpression.Compile(sAPPressSAPGridViewCellButtonAtIndexsearchColumnName, nameof(sAPPressSAPGridViewCellButtonAtIndexsearchColumnName), required: false);
            var __workflow_sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitle = WorkflowExpression.Compile(sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitle, nameof(sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitle), required: false);
            var __workflow_sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitleIsRegularExpression = WorkflowExpression.Compile(sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitleIsRegularExpression, nameof(sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitleIsRegularExpression), required: false);
            var __workflow_sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitleIsCaseSensitive = WorkflowExpression.Compile(sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitleIsCaseSensitive, nameof(sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitleIsCaseSensitive), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPPressSAPGridViewCellButtonAtIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPPressSAPGridViewCellButtonAtIndex = new JObject();
                var sAPPressSAPGridViewCellButtonAtIndexpropCount = 0;
                sAPPressSAPGridViewCellButtonAtIndexpropCount++;
                sAPPressSAPGridViewCellButtonAtIndex["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPPressSAPGridViewCellButtonAtIndexsearchSAPElementId);
                sAPPressSAPGridViewCellButtonAtIndexpropCount++;
                sAPPressSAPGridViewCellButtonAtIndex["RowIndex"] = ExpressionConverter.ConvertO(__workflow_sAPPressSAPGridViewCellButtonAtIndexrowIndex);
                if (__workflow_sAPPressSAPGridViewCellButtonAtIndexsearchColumnName != null)
                {
                    sAPPressSAPGridViewCellButtonAtIndex["SearchColumnName"] = ExpressionConverter.ConvertO(__workflow_sAPPressSAPGridViewCellButtonAtIndexsearchColumnName);
                    sAPPressSAPGridViewCellButtonAtIndexpropCount++;
                }

                if (__workflow_sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitle != null)
                {
                    sAPPressSAPGridViewCellButtonAtIndex["SearchColumnTitle"] = ExpressionConverter.ConvertO(__workflow_sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitle);
                    sAPPressSAPGridViewCellButtonAtIndexpropCount++;
                }

                if (__workflow_sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitleIsRegularExpression != null)
                {
                    if (__workflow_sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitleIsRegularExpression != null)
                    {
                        sAPPressSAPGridViewCellButtonAtIndex["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(__workflow_sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitleIsRegularExpression);
                        sAPPressSAPGridViewCellButtonAtIndexpropCount++;
                    }

                    sAPPressSAPGridViewCellButtonAtIndexpropCount++;
                }
                else
                {
                    sAPPressSAPGridViewCellButtonAtIndex["SearchColumnTitleIsRegularExpression"] = false;
                    sAPPressSAPGridViewCellButtonAtIndexpropCount++;
                }

                if (__workflow_sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitleIsCaseSensitive != null)
                {
                    if (__workflow_sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitleIsCaseSensitive != null)
                    {
                        sAPPressSAPGridViewCellButtonAtIndex["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(__workflow_sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitleIsCaseSensitive);
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
                sAPPressSAPGridViewCellButtonAtIndex["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPPressSAPGridViewCellButtonAtIndexworkflow);
                if (sAPPressSAPGridViewCellButtonAtIndexpropCount > 0)
                {
                    callPayload.Body = sAPPressSAPGridViewCellButtonAtIndex;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPCheckSAPGridViewCellCheckboxAtIndex(Expression<Func<string>> sAPCheckSAPGridViewCellCheckboxAtIndexsearchSAPElementId, Expression<Func<int>> sAPCheckSAPGridViewCellCheckboxAtIndexrowIndex, Expression<Func<string>> sAPCheckSAPGridViewCellCheckboxAtIndexworkflow, Expression<Func<string>> sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnName = null, Expression<Func<string>> sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitle = null, Expression<Func<bool>> sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitleIsCaseSensitive = null, Expression<Func<bool>> sAPCheckSAPGridViewCellCheckboxAtIndexcheckCellElement = null)
        {
            var __workflow_sAPCheckSAPGridViewCellCheckboxAtIndexsearchSAPElementId = WorkflowExpression.Compile(sAPCheckSAPGridViewCellCheckboxAtIndexsearchSAPElementId, nameof(sAPCheckSAPGridViewCellCheckboxAtIndexsearchSAPElementId), required: true);
            var __workflow_sAPCheckSAPGridViewCellCheckboxAtIndexrowIndex = WorkflowExpression.Compile(sAPCheckSAPGridViewCellCheckboxAtIndexrowIndex, nameof(sAPCheckSAPGridViewCellCheckboxAtIndexrowIndex), required: true);
            var __workflow_sAPCheckSAPGridViewCellCheckboxAtIndexworkflow = WorkflowExpression.Compile(sAPCheckSAPGridViewCellCheckboxAtIndexworkflow, nameof(sAPCheckSAPGridViewCellCheckboxAtIndexworkflow), required: true);
            var __workflow_sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnName = WorkflowExpression.Compile(sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnName, nameof(sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnName), required: false);
            var __workflow_sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitle = WorkflowExpression.Compile(sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitle, nameof(sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitle), required: false);
            var __workflow_sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitleIsRegularExpression = WorkflowExpression.Compile(sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitleIsRegularExpression, nameof(sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitleIsRegularExpression), required: false);
            var __workflow_sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitleIsCaseSensitive = WorkflowExpression.Compile(sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitleIsCaseSensitive, nameof(sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitleIsCaseSensitive), required: false);
            var __workflow_sAPCheckSAPGridViewCellCheckboxAtIndexcheckCellElement = WorkflowExpression.Compile(sAPCheckSAPGridViewCellCheckboxAtIndexcheckCellElement, nameof(sAPCheckSAPGridViewCellCheckboxAtIndexcheckCellElement), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPCheckSAPGridViewCellCheckboxAtIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPCheckSAPGridViewCellCheckboxAtIndex = new JObject();
                var sAPCheckSAPGridViewCellCheckboxAtIndexpropCount = 0;
                sAPCheckSAPGridViewCellCheckboxAtIndexpropCount++;
                sAPCheckSAPGridViewCellCheckboxAtIndex["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPCheckSAPGridViewCellCheckboxAtIndexsearchSAPElementId);
                sAPCheckSAPGridViewCellCheckboxAtIndexpropCount++;
                sAPCheckSAPGridViewCellCheckboxAtIndex["RowIndex"] = ExpressionConverter.ConvertO(__workflow_sAPCheckSAPGridViewCellCheckboxAtIndexrowIndex);
                if (__workflow_sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnName != null)
                {
                    sAPCheckSAPGridViewCellCheckboxAtIndex["SearchColumnName"] = ExpressionConverter.ConvertO(__workflow_sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnName);
                    sAPCheckSAPGridViewCellCheckboxAtIndexpropCount++;
                }

                if (__workflow_sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitle != null)
                {
                    sAPCheckSAPGridViewCellCheckboxAtIndex["SearchColumnTitle"] = ExpressionConverter.ConvertO(__workflow_sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitle);
                    sAPCheckSAPGridViewCellCheckboxAtIndexpropCount++;
                }

                if (__workflow_sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitleIsRegularExpression != null)
                {
                    if (__workflow_sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitleIsRegularExpression != null)
                    {
                        sAPCheckSAPGridViewCellCheckboxAtIndex["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(__workflow_sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitleIsRegularExpression);
                        sAPCheckSAPGridViewCellCheckboxAtIndexpropCount++;
                    }

                    sAPCheckSAPGridViewCellCheckboxAtIndexpropCount++;
                }
                else
                {
                    sAPCheckSAPGridViewCellCheckboxAtIndex["SearchColumnTitleIsRegularExpression"] = false;
                    sAPCheckSAPGridViewCellCheckboxAtIndexpropCount++;
                }

                if (__workflow_sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitleIsCaseSensitive != null)
                {
                    if (__workflow_sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitleIsCaseSensitive != null)
                    {
                        sAPCheckSAPGridViewCellCheckboxAtIndex["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(__workflow_sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitleIsCaseSensitive);
                        sAPCheckSAPGridViewCellCheckboxAtIndexpropCount++;
                    }

                    sAPCheckSAPGridViewCellCheckboxAtIndexpropCount++;
                }
                else
                {
                    sAPCheckSAPGridViewCellCheckboxAtIndex["SearchColumnTitleIsCaseSensitive"] = false;
                    sAPCheckSAPGridViewCellCheckboxAtIndexpropCount++;
                }

                if (__workflow_sAPCheckSAPGridViewCellCheckboxAtIndexcheckCellElement != null)
                {
                    if (__workflow_sAPCheckSAPGridViewCellCheckboxAtIndexcheckCellElement != null)
                    {
                        sAPCheckSAPGridViewCellCheckboxAtIndex["CheckCellElement"] = ExpressionConverter.ConvertO(__workflow_sAPCheckSAPGridViewCellCheckboxAtIndexcheckCellElement);
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
                sAPCheckSAPGridViewCellCheckboxAtIndex["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPCheckSAPGridViewCellCheckboxAtIndexworkflow);
                if (sAPCheckSAPGridViewCellCheckboxAtIndexpropCount > 0)
                {
                    callPayload.Body = sAPCheckSAPGridViewCellCheckboxAtIndex;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPModifySAPGridViewCellAtIndexResponse, ApiConnectionActionConfiguration> SAPModifySAPGridViewCellAtIndex(Expression<Func<string>> sAPModifySAPGridViewCellAtIndexsearchSAPElementId, Expression<Func<int>> sAPModifySAPGridViewCellAtIndexrowIndex, Expression<Func<string>> sAPModifySAPGridViewCellAtIndexworkflow, Expression<Func<string>> sAPModifySAPGridViewCellAtIndexsearchColumnName = null, Expression<Func<string>> sAPModifySAPGridViewCellAtIndexsearchColumnTitle = null, Expression<Func<bool>> sAPModifySAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPModifySAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive = null, Expression<Func<string>> sAPModifySAPGridViewCellAtIndexnewValue = null)
        {
            var __workflow_sAPModifySAPGridViewCellAtIndexsearchSAPElementId = WorkflowExpression.Compile(sAPModifySAPGridViewCellAtIndexsearchSAPElementId, nameof(sAPModifySAPGridViewCellAtIndexsearchSAPElementId), required: true);
            var __workflow_sAPModifySAPGridViewCellAtIndexrowIndex = WorkflowExpression.Compile(sAPModifySAPGridViewCellAtIndexrowIndex, nameof(sAPModifySAPGridViewCellAtIndexrowIndex), required: true);
            var __workflow_sAPModifySAPGridViewCellAtIndexworkflow = WorkflowExpression.Compile(sAPModifySAPGridViewCellAtIndexworkflow, nameof(sAPModifySAPGridViewCellAtIndexworkflow), required: true);
            var __workflow_sAPModifySAPGridViewCellAtIndexsearchColumnName = WorkflowExpression.Compile(sAPModifySAPGridViewCellAtIndexsearchColumnName, nameof(sAPModifySAPGridViewCellAtIndexsearchColumnName), required: false);
            var __workflow_sAPModifySAPGridViewCellAtIndexsearchColumnTitle = WorkflowExpression.Compile(sAPModifySAPGridViewCellAtIndexsearchColumnTitle, nameof(sAPModifySAPGridViewCellAtIndexsearchColumnTitle), required: false);
            var __workflow_sAPModifySAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression = WorkflowExpression.Compile(sAPModifySAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression, nameof(sAPModifySAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression), required: false);
            var __workflow_sAPModifySAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive = WorkflowExpression.Compile(sAPModifySAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive, nameof(sAPModifySAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive), required: false);
            var __workflow_sAPModifySAPGridViewCellAtIndexnewValue = WorkflowExpression.Compile(sAPModifySAPGridViewCellAtIndexnewValue, nameof(sAPModifySAPGridViewCellAtIndexnewValue), required: false);
            return new DeferredBodyAction<SAPModifySAPGridViewCellAtIndexResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPModifySAPGridViewCellAtIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPModifySAPGridViewCellAtIndex = new JObject();
                var sAPModifySAPGridViewCellAtIndexpropCount = 0;
                sAPModifySAPGridViewCellAtIndexpropCount++;
                sAPModifySAPGridViewCellAtIndex["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPModifySAPGridViewCellAtIndexsearchSAPElementId);
                sAPModifySAPGridViewCellAtIndexpropCount++;
                sAPModifySAPGridViewCellAtIndex["RowIndex"] = ExpressionConverter.ConvertO(__workflow_sAPModifySAPGridViewCellAtIndexrowIndex);
                if (__workflow_sAPModifySAPGridViewCellAtIndexsearchColumnName != null)
                {
                    sAPModifySAPGridViewCellAtIndex["SearchColumnName"] = ExpressionConverter.ConvertO(__workflow_sAPModifySAPGridViewCellAtIndexsearchColumnName);
                    sAPModifySAPGridViewCellAtIndexpropCount++;
                }

                if (__workflow_sAPModifySAPGridViewCellAtIndexsearchColumnTitle != null)
                {
                    sAPModifySAPGridViewCellAtIndex["SearchColumnTitle"] = ExpressionConverter.ConvertO(__workflow_sAPModifySAPGridViewCellAtIndexsearchColumnTitle);
                    sAPModifySAPGridViewCellAtIndexpropCount++;
                }

                if (__workflow_sAPModifySAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression != null)
                {
                    if (__workflow_sAPModifySAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression != null)
                    {
                        sAPModifySAPGridViewCellAtIndex["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(__workflow_sAPModifySAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression);
                        sAPModifySAPGridViewCellAtIndexpropCount++;
                    }

                    sAPModifySAPGridViewCellAtIndexpropCount++;
                }
                else
                {
                    sAPModifySAPGridViewCellAtIndex["SearchColumnTitleIsRegularExpression"] = false;
                    sAPModifySAPGridViewCellAtIndexpropCount++;
                }

                if (__workflow_sAPModifySAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive != null)
                {
                    if (__workflow_sAPModifySAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive != null)
                    {
                        sAPModifySAPGridViewCellAtIndex["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(__workflow_sAPModifySAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive);
                        sAPModifySAPGridViewCellAtIndexpropCount++;
                    }

                    sAPModifySAPGridViewCellAtIndexpropCount++;
                }
                else
                {
                    sAPModifySAPGridViewCellAtIndex["SearchColumnTitleIsCaseSensitive"] = false;
                    sAPModifySAPGridViewCellAtIndexpropCount++;
                }

                if (__workflow_sAPModifySAPGridViewCellAtIndexnewValue != null)
                {
                    sAPModifySAPGridViewCellAtIndex["NewValue"] = ExpressionConverter.ConvertO(__workflow_sAPModifySAPGridViewCellAtIndexnewValue);
                    sAPModifySAPGridViewCellAtIndexpropCount++;
                }

                sAPModifySAPGridViewCellAtIndexpropCount++;
                sAPModifySAPGridViewCellAtIndex["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPModifySAPGridViewCellAtIndexworkflow);
                if (sAPModifySAPGridViewCellAtIndexpropCount > 0)
                {
                    callPayload.Body = sAPModifySAPGridViewCellAtIndex;
                }

                return new ApiConnectionAction<SAPModifySAPGridViewCellAtIndexResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPSetSAPGridViewCurrentRow(Expression<Func<string>> sAPSetSAPGridViewCurrentRowsearchSAPElementId, Expression<Func<int>> sAPSetSAPGridViewCurrentRowrowIndex, Expression<Func<string>> sAPSetSAPGridViewCurrentRowworkflow)
        {
            var __workflow_sAPSetSAPGridViewCurrentRowsearchSAPElementId = WorkflowExpression.Compile(sAPSetSAPGridViewCurrentRowsearchSAPElementId, nameof(sAPSetSAPGridViewCurrentRowsearchSAPElementId), required: true);
            var __workflow_sAPSetSAPGridViewCurrentRowrowIndex = WorkflowExpression.Compile(sAPSetSAPGridViewCurrentRowrowIndex, nameof(sAPSetSAPGridViewCurrentRowrowIndex), required: true);
            var __workflow_sAPSetSAPGridViewCurrentRowworkflow = WorkflowExpression.Compile(sAPSetSAPGridViewCurrentRowworkflow, nameof(sAPSetSAPGridViewCurrentRowworkflow), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSetSAPGridViewCurrentRow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPSetSAPGridViewCurrentRow = new JObject();
                var sAPSetSAPGridViewCurrentRowpropCount = 0;
                sAPSetSAPGridViewCurrentRowpropCount++;
                sAPSetSAPGridViewCurrentRow["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPSetSAPGridViewCurrentRowsearchSAPElementId);
                sAPSetSAPGridViewCurrentRowpropCount++;
                sAPSetSAPGridViewCurrentRow["RowIndex"] = ExpressionConverter.ConvertO(__workflow_sAPSetSAPGridViewCurrentRowrowIndex);
                sAPSetSAPGridViewCurrentRowpropCount++;
                sAPSetSAPGridViewCurrentRow["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPSetSAPGridViewCurrentRowworkflow);
                if (sAPSetSAPGridViewCurrentRowpropCount > 0)
                {
                    callPayload.Body = sAPSetSAPGridViewCurrentRow;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPPressSAPGridViewColumnHeader(Expression<Func<string>> sAPPressSAPGridViewColumnHeadersearchSAPElementId, Expression<Func<string>> sAPPressSAPGridViewColumnHeaderworkflow, Expression<Func<string>> sAPPressSAPGridViewColumnHeadersearchColumnName = null, Expression<Func<string>> sAPPressSAPGridViewColumnHeadersearchColumnTitle = null, Expression<Func<bool>> sAPPressSAPGridViewColumnHeadersearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPPressSAPGridViewColumnHeadersearchColumnTitleIsCaseSensitive = null)
        {
            var __workflow_sAPPressSAPGridViewColumnHeadersearchSAPElementId = WorkflowExpression.Compile(sAPPressSAPGridViewColumnHeadersearchSAPElementId, nameof(sAPPressSAPGridViewColumnHeadersearchSAPElementId), required: true);
            var __workflow_sAPPressSAPGridViewColumnHeaderworkflow = WorkflowExpression.Compile(sAPPressSAPGridViewColumnHeaderworkflow, nameof(sAPPressSAPGridViewColumnHeaderworkflow), required: true);
            var __workflow_sAPPressSAPGridViewColumnHeadersearchColumnName = WorkflowExpression.Compile(sAPPressSAPGridViewColumnHeadersearchColumnName, nameof(sAPPressSAPGridViewColumnHeadersearchColumnName), required: false);
            var __workflow_sAPPressSAPGridViewColumnHeadersearchColumnTitle = WorkflowExpression.Compile(sAPPressSAPGridViewColumnHeadersearchColumnTitle, nameof(sAPPressSAPGridViewColumnHeadersearchColumnTitle), required: false);
            var __workflow_sAPPressSAPGridViewColumnHeadersearchColumnTitleIsRegularExpression = WorkflowExpression.Compile(sAPPressSAPGridViewColumnHeadersearchColumnTitleIsRegularExpression, nameof(sAPPressSAPGridViewColumnHeadersearchColumnTitleIsRegularExpression), required: false);
            var __workflow_sAPPressSAPGridViewColumnHeadersearchColumnTitleIsCaseSensitive = WorkflowExpression.Compile(sAPPressSAPGridViewColumnHeadersearchColumnTitleIsCaseSensitive, nameof(sAPPressSAPGridViewColumnHeadersearchColumnTitleIsCaseSensitive), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPPressSAPGridViewColumnHeader";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPPressSAPGridViewColumnHeader = new JObject();
                var sAPPressSAPGridViewColumnHeaderpropCount = 0;
                sAPPressSAPGridViewColumnHeaderpropCount++;
                sAPPressSAPGridViewColumnHeader["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPPressSAPGridViewColumnHeadersearchSAPElementId);
                if (__workflow_sAPPressSAPGridViewColumnHeadersearchColumnName != null)
                {
                    sAPPressSAPGridViewColumnHeader["SearchColumnName"] = ExpressionConverter.ConvertO(__workflow_sAPPressSAPGridViewColumnHeadersearchColumnName);
                    sAPPressSAPGridViewColumnHeaderpropCount++;
                }

                if (__workflow_sAPPressSAPGridViewColumnHeadersearchColumnTitle != null)
                {
                    sAPPressSAPGridViewColumnHeader["SearchColumnTitle"] = ExpressionConverter.ConvertO(__workflow_sAPPressSAPGridViewColumnHeadersearchColumnTitle);
                    sAPPressSAPGridViewColumnHeaderpropCount++;
                }

                if (__workflow_sAPPressSAPGridViewColumnHeadersearchColumnTitleIsRegularExpression != null)
                {
                    if (__workflow_sAPPressSAPGridViewColumnHeadersearchColumnTitleIsRegularExpression != null)
                    {
                        sAPPressSAPGridViewColumnHeader["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(__workflow_sAPPressSAPGridViewColumnHeadersearchColumnTitleIsRegularExpression);
                        sAPPressSAPGridViewColumnHeaderpropCount++;
                    }

                    sAPPressSAPGridViewColumnHeaderpropCount++;
                }
                else
                {
                    sAPPressSAPGridViewColumnHeader["SearchColumnTitleIsRegularExpression"] = false;
                    sAPPressSAPGridViewColumnHeaderpropCount++;
                }

                if (__workflow_sAPPressSAPGridViewColumnHeadersearchColumnTitleIsCaseSensitive != null)
                {
                    if (__workflow_sAPPressSAPGridViewColumnHeadersearchColumnTitleIsCaseSensitive != null)
                    {
                        sAPPressSAPGridViewColumnHeader["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(__workflow_sAPPressSAPGridViewColumnHeadersearchColumnTitleIsCaseSensitive);
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
                sAPPressSAPGridViewColumnHeader["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPPressSAPGridViewColumnHeaderworkflow);
                if (sAPPressSAPGridViewColumnHeaderpropCount > 0)
                {
                    callPayload.Body = sAPPressSAPGridViewColumnHeader;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPSetSAPGridViewFirstVisibleRowResponse, ApiConnectionActionConfiguration> SAPSetSAPGridViewFirstVisibleRow(Expression<Func<string>> sAPSetSAPGridViewFirstVisibleRowsearchSAPElementId, Expression<Func<int>> sAPSetSAPGridViewFirstVisibleRowfirstVisibleRowIndex, Expression<Func<string>> sAPSetSAPGridViewFirstVisibleRowworkflow)
        {
            var __workflow_sAPSetSAPGridViewFirstVisibleRowsearchSAPElementId = WorkflowExpression.Compile(sAPSetSAPGridViewFirstVisibleRowsearchSAPElementId, nameof(sAPSetSAPGridViewFirstVisibleRowsearchSAPElementId), required: true);
            var __workflow_sAPSetSAPGridViewFirstVisibleRowfirstVisibleRowIndex = WorkflowExpression.Compile(sAPSetSAPGridViewFirstVisibleRowfirstVisibleRowIndex, nameof(sAPSetSAPGridViewFirstVisibleRowfirstVisibleRowIndex), required: true);
            var __workflow_sAPSetSAPGridViewFirstVisibleRowworkflow = WorkflowExpression.Compile(sAPSetSAPGridViewFirstVisibleRowworkflow, nameof(sAPSetSAPGridViewFirstVisibleRowworkflow), required: true);
            return new DeferredBodyAction<SAPSetSAPGridViewFirstVisibleRowResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSetSAPGridViewFirstVisibleRow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPSetSAPGridViewFirstVisibleRow = new JObject();
                var sAPSetSAPGridViewFirstVisibleRowpropCount = 0;
                sAPSetSAPGridViewFirstVisibleRowpropCount++;
                sAPSetSAPGridViewFirstVisibleRow["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPSetSAPGridViewFirstVisibleRowsearchSAPElementId);
                sAPSetSAPGridViewFirstVisibleRowpropCount++;
                sAPSetSAPGridViewFirstVisibleRow["FirstVisibleRowIndex"] = ExpressionConverter.ConvertO(__workflow_sAPSetSAPGridViewFirstVisibleRowfirstVisibleRowIndex);
                sAPSetSAPGridViewFirstVisibleRowpropCount++;
                sAPSetSAPGridViewFirstVisibleRow["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPSetSAPGridViewFirstVisibleRowworkflow);
                if (sAPSetSAPGridViewFirstVisibleRowpropCount > 0)
                {
                    callPayload.Body = sAPSetSAPGridViewFirstVisibleRow;
                }

                return new ApiConnectionAction<SAPSetSAPGridViewFirstVisibleRowResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPSelectSAPGridViewRow(Expression<Func<string>> sAPSelectSAPGridViewRowsearchSAPElementId, Expression<Func<int>> sAPSelectSAPGridViewRowrowIndex, Expression<Func<string>> sAPSelectSAPGridViewRowworkflow, Expression<Func<bool>> sAPSelectSAPGridViewRowsetAsCurrentRow = null)
        {
            var __workflow_sAPSelectSAPGridViewRowsearchSAPElementId = WorkflowExpression.Compile(sAPSelectSAPGridViewRowsearchSAPElementId, nameof(sAPSelectSAPGridViewRowsearchSAPElementId), required: true);
            var __workflow_sAPSelectSAPGridViewRowrowIndex = WorkflowExpression.Compile(sAPSelectSAPGridViewRowrowIndex, nameof(sAPSelectSAPGridViewRowrowIndex), required: true);
            var __workflow_sAPSelectSAPGridViewRowworkflow = WorkflowExpression.Compile(sAPSelectSAPGridViewRowworkflow, nameof(sAPSelectSAPGridViewRowworkflow), required: true);
            var __workflow_sAPSelectSAPGridViewRowsetAsCurrentRow = WorkflowExpression.Compile(sAPSelectSAPGridViewRowsetAsCurrentRow, nameof(sAPSelectSAPGridViewRowsetAsCurrentRow), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSelectSAPGridViewRow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPSelectSAPGridViewRow = new JObject();
                var sAPSelectSAPGridViewRowpropCount = 0;
                sAPSelectSAPGridViewRowpropCount++;
                sAPSelectSAPGridViewRow["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPSelectSAPGridViewRowsearchSAPElementId);
                sAPSelectSAPGridViewRowpropCount++;
                sAPSelectSAPGridViewRow["RowIndex"] = ExpressionConverter.ConvertO(__workflow_sAPSelectSAPGridViewRowrowIndex);
                if (__workflow_sAPSelectSAPGridViewRowsetAsCurrentRow != null)
                {
                    if (__workflow_sAPSelectSAPGridViewRowsetAsCurrentRow != null)
                    {
                        sAPSelectSAPGridViewRow["SetAsCurrentRow"] = ExpressionConverter.ConvertO(__workflow_sAPSelectSAPGridViewRowsetAsCurrentRow);
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
                sAPSelectSAPGridViewRow["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPSelectSAPGridViewRowworkflow);
                if (sAPSelectSAPGridViewRowpropCount > 0)
                {
                    callPayload.Body = sAPSelectSAPGridViewRow;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPSelectSAPGridViewMultipleRows(Expression<Func<string>> sAPSelectSAPGridViewMultipleRowssearchSAPElementId, Expression<Func<string>> sAPSelectSAPGridViewMultipleRowsrowsToSelect, Expression<Func<string>> sAPSelectSAPGridViewMultipleRowsworkflow)
        {
            var __workflow_sAPSelectSAPGridViewMultipleRowssearchSAPElementId = WorkflowExpression.Compile(sAPSelectSAPGridViewMultipleRowssearchSAPElementId, nameof(sAPSelectSAPGridViewMultipleRowssearchSAPElementId), required: true);
            var __workflow_sAPSelectSAPGridViewMultipleRowsrowsToSelect = WorkflowExpression.Compile(sAPSelectSAPGridViewMultipleRowsrowsToSelect, nameof(sAPSelectSAPGridViewMultipleRowsrowsToSelect), required: true);
            var __workflow_sAPSelectSAPGridViewMultipleRowsworkflow = WorkflowExpression.Compile(sAPSelectSAPGridViewMultipleRowsworkflow, nameof(sAPSelectSAPGridViewMultipleRowsworkflow), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSelectSAPGridViewMultipleRows";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPSelectSAPGridViewMultipleRows = new JObject();
                var sAPSelectSAPGridViewMultipleRowspropCount = 0;
                sAPSelectSAPGridViewMultipleRowspropCount++;
                sAPSelectSAPGridViewMultipleRows["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPSelectSAPGridViewMultipleRowssearchSAPElementId);
                sAPSelectSAPGridViewMultipleRowspropCount++;
                sAPSelectSAPGridViewMultipleRows["RowsToSelect"] = ExpressionConverter.ConvertO(__workflow_sAPSelectSAPGridViewMultipleRowsrowsToSelect);
                sAPSelectSAPGridViewMultipleRowspropCount++;
                sAPSelectSAPGridViewMultipleRows["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPSelectSAPGridViewMultipleRowsworkflow);
                if (sAPSelectSAPGridViewMultipleRowspropCount > 0)
                {
                    callPayload.Body = sAPSelectSAPGridViewMultipleRows;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPSetSAPGridViewCurrentColumn(Expression<Func<string>> sAPSetSAPGridViewCurrentColumnsearchSAPElementId, Expression<Func<string>> sAPSetSAPGridViewCurrentColumnworkflow, Expression<Func<string>> sAPSetSAPGridViewCurrentColumnsearchColumnName = null, Expression<Func<string>> sAPSetSAPGridViewCurrentColumnsearchColumnTitle = null, Expression<Func<bool>> sAPSetSAPGridViewCurrentColumnsearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPSetSAPGridViewCurrentColumnsearchColumnTitleIsCaseSensitive = null)
        {
            var __workflow_sAPSetSAPGridViewCurrentColumnsearchSAPElementId = WorkflowExpression.Compile(sAPSetSAPGridViewCurrentColumnsearchSAPElementId, nameof(sAPSetSAPGridViewCurrentColumnsearchSAPElementId), required: true);
            var __workflow_sAPSetSAPGridViewCurrentColumnworkflow = WorkflowExpression.Compile(sAPSetSAPGridViewCurrentColumnworkflow, nameof(sAPSetSAPGridViewCurrentColumnworkflow), required: true);
            var __workflow_sAPSetSAPGridViewCurrentColumnsearchColumnName = WorkflowExpression.Compile(sAPSetSAPGridViewCurrentColumnsearchColumnName, nameof(sAPSetSAPGridViewCurrentColumnsearchColumnName), required: false);
            var __workflow_sAPSetSAPGridViewCurrentColumnsearchColumnTitle = WorkflowExpression.Compile(sAPSetSAPGridViewCurrentColumnsearchColumnTitle, nameof(sAPSetSAPGridViewCurrentColumnsearchColumnTitle), required: false);
            var __workflow_sAPSetSAPGridViewCurrentColumnsearchColumnTitleIsRegularExpression = WorkflowExpression.Compile(sAPSetSAPGridViewCurrentColumnsearchColumnTitleIsRegularExpression, nameof(sAPSetSAPGridViewCurrentColumnsearchColumnTitleIsRegularExpression), required: false);
            var __workflow_sAPSetSAPGridViewCurrentColumnsearchColumnTitleIsCaseSensitive = WorkflowExpression.Compile(sAPSetSAPGridViewCurrentColumnsearchColumnTitleIsCaseSensitive, nameof(sAPSetSAPGridViewCurrentColumnsearchColumnTitleIsCaseSensitive), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSetSAPGridViewCurrentColumn";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPSetSAPGridViewCurrentColumn = new JObject();
                var sAPSetSAPGridViewCurrentColumnpropCount = 0;
                sAPSetSAPGridViewCurrentColumnpropCount++;
                sAPSetSAPGridViewCurrentColumn["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPSetSAPGridViewCurrentColumnsearchSAPElementId);
                if (__workflow_sAPSetSAPGridViewCurrentColumnsearchColumnName != null)
                {
                    sAPSetSAPGridViewCurrentColumn["SearchColumnName"] = ExpressionConverter.ConvertO(__workflow_sAPSetSAPGridViewCurrentColumnsearchColumnName);
                    sAPSetSAPGridViewCurrentColumnpropCount++;
                }

                if (__workflow_sAPSetSAPGridViewCurrentColumnsearchColumnTitle != null)
                {
                    sAPSetSAPGridViewCurrentColumn["SearchColumnTitle"] = ExpressionConverter.ConvertO(__workflow_sAPSetSAPGridViewCurrentColumnsearchColumnTitle);
                    sAPSetSAPGridViewCurrentColumnpropCount++;
                }

                if (__workflow_sAPSetSAPGridViewCurrentColumnsearchColumnTitleIsRegularExpression != null)
                {
                    if (__workflow_sAPSetSAPGridViewCurrentColumnsearchColumnTitleIsRegularExpression != null)
                    {
                        sAPSetSAPGridViewCurrentColumn["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(__workflow_sAPSetSAPGridViewCurrentColumnsearchColumnTitleIsRegularExpression);
                        sAPSetSAPGridViewCurrentColumnpropCount++;
                    }

                    sAPSetSAPGridViewCurrentColumnpropCount++;
                }
                else
                {
                    sAPSetSAPGridViewCurrentColumn["SearchColumnTitleIsRegularExpression"] = false;
                    sAPSetSAPGridViewCurrentColumnpropCount++;
                }

                if (__workflow_sAPSetSAPGridViewCurrentColumnsearchColumnTitleIsCaseSensitive != null)
                {
                    if (__workflow_sAPSetSAPGridViewCurrentColumnsearchColumnTitleIsCaseSensitive != null)
                    {
                        sAPSetSAPGridViewCurrentColumn["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(__workflow_sAPSetSAPGridViewCurrentColumnsearchColumnTitleIsCaseSensitive);
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
                sAPSetSAPGridViewCurrentColumn["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPSetSAPGridViewCurrentColumnworkflow);
                if (sAPSetSAPGridViewCurrentColumnpropCount > 0)
                {
                    callPayload.Body = sAPSetSAPGridViewCurrentColumn;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPSetSAPGridViewCurrentCell(Expression<Func<string>> sAPSetSAPGridViewCurrentCellsearchSAPElementId, Expression<Func<int>> sAPSetSAPGridViewCurrentCellrowIndex, Expression<Func<string>> sAPSetSAPGridViewCurrentCellworkflow, Expression<Func<string>> sAPSetSAPGridViewCurrentCellsearchColumnName = null, Expression<Func<string>> sAPSetSAPGridViewCurrentCellsearchColumnTitle = null, Expression<Func<bool>> sAPSetSAPGridViewCurrentCellsearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPSetSAPGridViewCurrentCellsearchColumnTitleIsCaseSensitive = null)
        {
            var __workflow_sAPSetSAPGridViewCurrentCellsearchSAPElementId = WorkflowExpression.Compile(sAPSetSAPGridViewCurrentCellsearchSAPElementId, nameof(sAPSetSAPGridViewCurrentCellsearchSAPElementId), required: true);
            var __workflow_sAPSetSAPGridViewCurrentCellrowIndex = WorkflowExpression.Compile(sAPSetSAPGridViewCurrentCellrowIndex, nameof(sAPSetSAPGridViewCurrentCellrowIndex), required: true);
            var __workflow_sAPSetSAPGridViewCurrentCellworkflow = WorkflowExpression.Compile(sAPSetSAPGridViewCurrentCellworkflow, nameof(sAPSetSAPGridViewCurrentCellworkflow), required: true);
            var __workflow_sAPSetSAPGridViewCurrentCellsearchColumnName = WorkflowExpression.Compile(sAPSetSAPGridViewCurrentCellsearchColumnName, nameof(sAPSetSAPGridViewCurrentCellsearchColumnName), required: false);
            var __workflow_sAPSetSAPGridViewCurrentCellsearchColumnTitle = WorkflowExpression.Compile(sAPSetSAPGridViewCurrentCellsearchColumnTitle, nameof(sAPSetSAPGridViewCurrentCellsearchColumnTitle), required: false);
            var __workflow_sAPSetSAPGridViewCurrentCellsearchColumnTitleIsRegularExpression = WorkflowExpression.Compile(sAPSetSAPGridViewCurrentCellsearchColumnTitleIsRegularExpression, nameof(sAPSetSAPGridViewCurrentCellsearchColumnTitleIsRegularExpression), required: false);
            var __workflow_sAPSetSAPGridViewCurrentCellsearchColumnTitleIsCaseSensitive = WorkflowExpression.Compile(sAPSetSAPGridViewCurrentCellsearchColumnTitleIsCaseSensitive, nameof(sAPSetSAPGridViewCurrentCellsearchColumnTitleIsCaseSensitive), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSetSAPGridViewCurrentCell";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPSetSAPGridViewCurrentCell = new JObject();
                var sAPSetSAPGridViewCurrentCellpropCount = 0;
                sAPSetSAPGridViewCurrentCellpropCount++;
                sAPSetSAPGridViewCurrentCell["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPSetSAPGridViewCurrentCellsearchSAPElementId);
                sAPSetSAPGridViewCurrentCellpropCount++;
                sAPSetSAPGridViewCurrentCell["RowIndex"] = ExpressionConverter.ConvertO(__workflow_sAPSetSAPGridViewCurrentCellrowIndex);
                if (__workflow_sAPSetSAPGridViewCurrentCellsearchColumnName != null)
                {
                    sAPSetSAPGridViewCurrentCell["SearchColumnName"] = ExpressionConverter.ConvertO(__workflow_sAPSetSAPGridViewCurrentCellsearchColumnName);
                    sAPSetSAPGridViewCurrentCellpropCount++;
                }

                if (__workflow_sAPSetSAPGridViewCurrentCellsearchColumnTitle != null)
                {
                    sAPSetSAPGridViewCurrentCell["SearchColumnTitle"] = ExpressionConverter.ConvertO(__workflow_sAPSetSAPGridViewCurrentCellsearchColumnTitle);
                    sAPSetSAPGridViewCurrentCellpropCount++;
                }

                if (__workflow_sAPSetSAPGridViewCurrentCellsearchColumnTitleIsRegularExpression != null)
                {
                    if (__workflow_sAPSetSAPGridViewCurrentCellsearchColumnTitleIsRegularExpression != null)
                    {
                        sAPSetSAPGridViewCurrentCell["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(__workflow_sAPSetSAPGridViewCurrentCellsearchColumnTitleIsRegularExpression);
                        sAPSetSAPGridViewCurrentCellpropCount++;
                    }

                    sAPSetSAPGridViewCurrentCellpropCount++;
                }
                else
                {
                    sAPSetSAPGridViewCurrentCell["SearchColumnTitleIsRegularExpression"] = false;
                    sAPSetSAPGridViewCurrentCellpropCount++;
                }

                if (__workflow_sAPSetSAPGridViewCurrentCellsearchColumnTitleIsCaseSensitive != null)
                {
                    if (__workflow_sAPSetSAPGridViewCurrentCellsearchColumnTitleIsCaseSensitive != null)
                    {
                        sAPSetSAPGridViewCurrentCell["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(__workflow_sAPSetSAPGridViewCurrentCellsearchColumnTitleIsCaseSensitive);
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
                sAPSetSAPGridViewCurrentCell["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPSetSAPGridViewCurrentCellworkflow);
                if (sAPSetSAPGridViewCurrentCellpropCount > 0)
                {
                    callPayload.Body = sAPSetSAPGridViewCurrentCell;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPSelectSAPGridViewColumn(Expression<Func<string>> sAPSelectSAPGridViewColumnsearchSAPElementId, Expression<Func<string>> sAPSelectSAPGridViewColumnworkflow, Expression<Func<string>> sAPSelectSAPGridViewColumnsearchColumnName = null, Expression<Func<string>> sAPSelectSAPGridViewColumnsearchColumnTitle = null, Expression<Func<bool>> sAPSelectSAPGridViewColumnsearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPSelectSAPGridViewColumnsearchColumnTitleIsCaseSensitive = null, Expression<Func<bool>> sAPSelectSAPGridViewColumnselectColumn = null, Expression<Func<bool>> sAPSelectSAPGridViewColumnsetAsCurrentColumn = null, Expression<Func<bool>> sAPSelectSAPGridViewColumnclearSelectionFirst = null)
        {
            var __workflow_sAPSelectSAPGridViewColumnsearchSAPElementId = WorkflowExpression.Compile(sAPSelectSAPGridViewColumnsearchSAPElementId, nameof(sAPSelectSAPGridViewColumnsearchSAPElementId), required: true);
            var __workflow_sAPSelectSAPGridViewColumnworkflow = WorkflowExpression.Compile(sAPSelectSAPGridViewColumnworkflow, nameof(sAPSelectSAPGridViewColumnworkflow), required: true);
            var __workflow_sAPSelectSAPGridViewColumnsearchColumnName = WorkflowExpression.Compile(sAPSelectSAPGridViewColumnsearchColumnName, nameof(sAPSelectSAPGridViewColumnsearchColumnName), required: false);
            var __workflow_sAPSelectSAPGridViewColumnsearchColumnTitle = WorkflowExpression.Compile(sAPSelectSAPGridViewColumnsearchColumnTitle, nameof(sAPSelectSAPGridViewColumnsearchColumnTitle), required: false);
            var __workflow_sAPSelectSAPGridViewColumnsearchColumnTitleIsRegularExpression = WorkflowExpression.Compile(sAPSelectSAPGridViewColumnsearchColumnTitleIsRegularExpression, nameof(sAPSelectSAPGridViewColumnsearchColumnTitleIsRegularExpression), required: false);
            var __workflow_sAPSelectSAPGridViewColumnsearchColumnTitleIsCaseSensitive = WorkflowExpression.Compile(sAPSelectSAPGridViewColumnsearchColumnTitleIsCaseSensitive, nameof(sAPSelectSAPGridViewColumnsearchColumnTitleIsCaseSensitive), required: false);
            var __workflow_sAPSelectSAPGridViewColumnselectColumn = WorkflowExpression.Compile(sAPSelectSAPGridViewColumnselectColumn, nameof(sAPSelectSAPGridViewColumnselectColumn), required: false);
            var __workflow_sAPSelectSAPGridViewColumnsetAsCurrentColumn = WorkflowExpression.Compile(sAPSelectSAPGridViewColumnsetAsCurrentColumn, nameof(sAPSelectSAPGridViewColumnsetAsCurrentColumn), required: false);
            var __workflow_sAPSelectSAPGridViewColumnclearSelectionFirst = WorkflowExpression.Compile(sAPSelectSAPGridViewColumnclearSelectionFirst, nameof(sAPSelectSAPGridViewColumnclearSelectionFirst), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSelectSAPGridViewColumn";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPSelectSAPGridViewColumn = new JObject();
                var sAPSelectSAPGridViewColumnpropCount = 0;
                sAPSelectSAPGridViewColumnpropCount++;
                sAPSelectSAPGridViewColumn["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPSelectSAPGridViewColumnsearchSAPElementId);
                if (__workflow_sAPSelectSAPGridViewColumnsearchColumnName != null)
                {
                    sAPSelectSAPGridViewColumn["SearchColumnName"] = ExpressionConverter.ConvertO(__workflow_sAPSelectSAPGridViewColumnsearchColumnName);
                    sAPSelectSAPGridViewColumnpropCount++;
                }

                if (__workflow_sAPSelectSAPGridViewColumnsearchColumnTitle != null)
                {
                    sAPSelectSAPGridViewColumn["SearchColumnTitle"] = ExpressionConverter.ConvertO(__workflow_sAPSelectSAPGridViewColumnsearchColumnTitle);
                    sAPSelectSAPGridViewColumnpropCount++;
                }

                if (__workflow_sAPSelectSAPGridViewColumnsearchColumnTitleIsRegularExpression != null)
                {
                    if (__workflow_sAPSelectSAPGridViewColumnsearchColumnTitleIsRegularExpression != null)
                    {
                        sAPSelectSAPGridViewColumn["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(__workflow_sAPSelectSAPGridViewColumnsearchColumnTitleIsRegularExpression);
                        sAPSelectSAPGridViewColumnpropCount++;
                    }

                    sAPSelectSAPGridViewColumnpropCount++;
                }
                else
                {
                    sAPSelectSAPGridViewColumn["SearchColumnTitleIsRegularExpression"] = false;
                    sAPSelectSAPGridViewColumnpropCount++;
                }

                if (__workflow_sAPSelectSAPGridViewColumnsearchColumnTitleIsCaseSensitive != null)
                {
                    if (__workflow_sAPSelectSAPGridViewColumnsearchColumnTitleIsCaseSensitive != null)
                    {
                        sAPSelectSAPGridViewColumn["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(__workflow_sAPSelectSAPGridViewColumnsearchColumnTitleIsCaseSensitive);
                        sAPSelectSAPGridViewColumnpropCount++;
                    }

                    sAPSelectSAPGridViewColumnpropCount++;
                }
                else
                {
                    sAPSelectSAPGridViewColumn["SearchColumnTitleIsCaseSensitive"] = false;
                    sAPSelectSAPGridViewColumnpropCount++;
                }

                if (__workflow_sAPSelectSAPGridViewColumnselectColumn != null)
                {
                    if (__workflow_sAPSelectSAPGridViewColumnselectColumn != null)
                    {
                        sAPSelectSAPGridViewColumn["SelectColumn"] = ExpressionConverter.ConvertO(__workflow_sAPSelectSAPGridViewColumnselectColumn);
                        sAPSelectSAPGridViewColumnpropCount++;
                    }

                    sAPSelectSAPGridViewColumnpropCount++;
                }
                else
                {
                    sAPSelectSAPGridViewColumn["SelectColumn"] = true;
                    sAPSelectSAPGridViewColumnpropCount++;
                }

                if (__workflow_sAPSelectSAPGridViewColumnsetAsCurrentColumn != null)
                {
                    if (__workflow_sAPSelectSAPGridViewColumnsetAsCurrentColumn != null)
                    {
                        sAPSelectSAPGridViewColumn["SetAsCurrentColumn"] = ExpressionConverter.ConvertO(__workflow_sAPSelectSAPGridViewColumnsetAsCurrentColumn);
                        sAPSelectSAPGridViewColumnpropCount++;
                    }

                    sAPSelectSAPGridViewColumnpropCount++;
                }
                else
                {
                    sAPSelectSAPGridViewColumn["SetAsCurrentColumn"] = false;
                    sAPSelectSAPGridViewColumnpropCount++;
                }

                if (__workflow_sAPSelectSAPGridViewColumnclearSelectionFirst != null)
                {
                    if (__workflow_sAPSelectSAPGridViewColumnclearSelectionFirst != null)
                    {
                        sAPSelectSAPGridViewColumn["ClearSelectionFirst"] = ExpressionConverter.ConvertO(__workflow_sAPSelectSAPGridViewColumnclearSelectionFirst);
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
                sAPSelectSAPGridViewColumn["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPSelectSAPGridViewColumnworkflow);
                if (sAPSelectSAPGridViewColumnpropCount > 0)
                {
                    callPayload.Body = sAPSelectSAPGridViewColumn;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPGridViewSelectAll(Expression<Func<string>> sAPGridViewSelectAllsearchSAPElementId, Expression<Func<string>> sAPGridViewSelectAllworkflow)
        {
            var __workflow_sAPGridViewSelectAllsearchSAPElementId = WorkflowExpression.Compile(sAPGridViewSelectAllsearchSAPElementId, nameof(sAPGridViewSelectAllsearchSAPElementId), required: true);
            var __workflow_sAPGridViewSelectAllworkflow = WorkflowExpression.Compile(sAPGridViewSelectAllworkflow, nameof(sAPGridViewSelectAllworkflow), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGridViewSelectAll";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGridViewSelectAll = new JObject();
                var sAPGridViewSelectAllpropCount = 0;
                sAPGridViewSelectAllpropCount++;
                sAPGridViewSelectAll["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPGridViewSelectAllsearchSAPElementId);
                sAPGridViewSelectAllpropCount++;
                sAPGridViewSelectAll["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPGridViewSelectAllworkflow);
                if (sAPGridViewSelectAllpropCount > 0)
                {
                    callPayload.Body = sAPGridViewSelectAll;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPGridViewDeselectAll(Expression<Func<string>> sAPGridViewDeselectAllsearchSAPElementId, Expression<Func<string>> sAPGridViewDeselectAllworkflow)
        {
            var __workflow_sAPGridViewDeselectAllsearchSAPElementId = WorkflowExpression.Compile(sAPGridViewDeselectAllsearchSAPElementId, nameof(sAPGridViewDeselectAllsearchSAPElementId), required: true);
            var __workflow_sAPGridViewDeselectAllworkflow = WorkflowExpression.Compile(sAPGridViewDeselectAllworkflow, nameof(sAPGridViewDeselectAllworkflow), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGridViewDeselectAll";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGridViewDeselectAll = new JObject();
                var sAPGridViewDeselectAllpropCount = 0;
                sAPGridViewDeselectAllpropCount++;
                sAPGridViewDeselectAll["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPGridViewDeselectAllsearchSAPElementId);
                sAPGridViewDeselectAllpropCount++;
                sAPGridViewDeselectAll["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPGridViewDeselectAllworkflow);
                if (sAPGridViewDeselectAllpropCount > 0)
                {
                    callPayload.Body = sAPGridViewDeselectAll;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPSetSAPGridViewFirstVisibleColumnResponse, ApiConnectionActionConfiguration> SAPSetSAPGridViewFirstVisibleColumn(Expression<Func<string>> sAPSetSAPGridViewFirstVisibleColumnsearchSAPElementId, Expression<Func<string>> sAPSetSAPGridViewFirstVisibleColumnworkflow, Expression<Func<string>> sAPSetSAPGridViewFirstVisibleColumnsearchColumnName = null, Expression<Func<string>> sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitle = null, Expression<Func<bool>> sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitleIsCaseSensitive = null)
        {
            var __workflow_sAPSetSAPGridViewFirstVisibleColumnsearchSAPElementId = WorkflowExpression.Compile(sAPSetSAPGridViewFirstVisibleColumnsearchSAPElementId, nameof(sAPSetSAPGridViewFirstVisibleColumnsearchSAPElementId), required: true);
            var __workflow_sAPSetSAPGridViewFirstVisibleColumnworkflow = WorkflowExpression.Compile(sAPSetSAPGridViewFirstVisibleColumnworkflow, nameof(sAPSetSAPGridViewFirstVisibleColumnworkflow), required: true);
            var __workflow_sAPSetSAPGridViewFirstVisibleColumnsearchColumnName = WorkflowExpression.Compile(sAPSetSAPGridViewFirstVisibleColumnsearchColumnName, nameof(sAPSetSAPGridViewFirstVisibleColumnsearchColumnName), required: false);
            var __workflow_sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitle = WorkflowExpression.Compile(sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitle, nameof(sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitle), required: false);
            var __workflow_sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitleIsRegularExpression = WorkflowExpression.Compile(sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitleIsRegularExpression, nameof(sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitleIsRegularExpression), required: false);
            var __workflow_sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitleIsCaseSensitive = WorkflowExpression.Compile(sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitleIsCaseSensitive, nameof(sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitleIsCaseSensitive), required: false);
            return new DeferredBodyAction<SAPSetSAPGridViewFirstVisibleColumnResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSetSAPGridViewFirstVisibleColumn";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPSetSAPGridViewFirstVisibleColumn = new JObject();
                var sAPSetSAPGridViewFirstVisibleColumnpropCount = 0;
                sAPSetSAPGridViewFirstVisibleColumnpropCount++;
                sAPSetSAPGridViewFirstVisibleColumn["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPSetSAPGridViewFirstVisibleColumnsearchSAPElementId);
                if (__workflow_sAPSetSAPGridViewFirstVisibleColumnsearchColumnName != null)
                {
                    sAPSetSAPGridViewFirstVisibleColumn["SearchColumnName"] = ExpressionConverter.ConvertO(__workflow_sAPSetSAPGridViewFirstVisibleColumnsearchColumnName);
                    sAPSetSAPGridViewFirstVisibleColumnpropCount++;
                }

                if (__workflow_sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitle != null)
                {
                    sAPSetSAPGridViewFirstVisibleColumn["SearchColumnTitle"] = ExpressionConverter.ConvertO(__workflow_sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitle);
                    sAPSetSAPGridViewFirstVisibleColumnpropCount++;
                }

                if (__workflow_sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitleIsRegularExpression != null)
                {
                    if (__workflow_sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitleIsRegularExpression != null)
                    {
                        sAPSetSAPGridViewFirstVisibleColumn["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(__workflow_sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitleIsRegularExpression);
                        sAPSetSAPGridViewFirstVisibleColumnpropCount++;
                    }

                    sAPSetSAPGridViewFirstVisibleColumnpropCount++;
                }
                else
                {
                    sAPSetSAPGridViewFirstVisibleColumn["SearchColumnTitleIsRegularExpression"] = false;
                    sAPSetSAPGridViewFirstVisibleColumnpropCount++;
                }

                if (__workflow_sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitleIsCaseSensitive != null)
                {
                    if (__workflow_sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitleIsCaseSensitive != null)
                    {
                        sAPSetSAPGridViewFirstVisibleColumn["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(__workflow_sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitleIsCaseSensitive);
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
                sAPSetSAPGridViewFirstVisibleColumn["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPSetSAPGridViewFirstVisibleColumnworkflow);
                if (sAPSetSAPGridViewFirstVisibleColumnpropCount > 0)
                {
                    callPayload.Body = sAPSetSAPGridViewFirstVisibleColumn;
                }

                return new ApiConnectionAction<SAPSetSAPGridViewFirstVisibleColumnResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPGridViewOpenContextMenu(Expression<Func<string>> sAPGridViewOpenContextMenusearchSAPElementId, Expression<Func<int>> sAPGridViewOpenContextMenurowIndex, Expression<Func<string>> sAPGridViewOpenContextMenuworkflow, Expression<Func<string>> sAPGridViewOpenContextMenusearchColumnName = null, Expression<Func<string>> sAPGridViewOpenContextMenusearchColumnTitle = null, Expression<Func<bool>> sAPGridViewOpenContextMenusearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPGridViewOpenContextMenusearchColumnTitleIsCaseSensitive = null)
        {
            var __workflow_sAPGridViewOpenContextMenusearchSAPElementId = WorkflowExpression.Compile(sAPGridViewOpenContextMenusearchSAPElementId, nameof(sAPGridViewOpenContextMenusearchSAPElementId), required: true);
            var __workflow_sAPGridViewOpenContextMenurowIndex = WorkflowExpression.Compile(sAPGridViewOpenContextMenurowIndex, nameof(sAPGridViewOpenContextMenurowIndex), required: true);
            var __workflow_sAPGridViewOpenContextMenuworkflow = WorkflowExpression.Compile(sAPGridViewOpenContextMenuworkflow, nameof(sAPGridViewOpenContextMenuworkflow), required: true);
            var __workflow_sAPGridViewOpenContextMenusearchColumnName = WorkflowExpression.Compile(sAPGridViewOpenContextMenusearchColumnName, nameof(sAPGridViewOpenContextMenusearchColumnName), required: false);
            var __workflow_sAPGridViewOpenContextMenusearchColumnTitle = WorkflowExpression.Compile(sAPGridViewOpenContextMenusearchColumnTitle, nameof(sAPGridViewOpenContextMenusearchColumnTitle), required: false);
            var __workflow_sAPGridViewOpenContextMenusearchColumnTitleIsRegularExpression = WorkflowExpression.Compile(sAPGridViewOpenContextMenusearchColumnTitleIsRegularExpression, nameof(sAPGridViewOpenContextMenusearchColumnTitleIsRegularExpression), required: false);
            var __workflow_sAPGridViewOpenContextMenusearchColumnTitleIsCaseSensitive = WorkflowExpression.Compile(sAPGridViewOpenContextMenusearchColumnTitleIsCaseSensitive, nameof(sAPGridViewOpenContextMenusearchColumnTitleIsCaseSensitive), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGridViewOpenContextMenu";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGridViewOpenContextMenu = new JObject();
                var sAPGridViewOpenContextMenupropCount = 0;
                sAPGridViewOpenContextMenupropCount++;
                sAPGridViewOpenContextMenu["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPGridViewOpenContextMenusearchSAPElementId);
                sAPGridViewOpenContextMenupropCount++;
                sAPGridViewOpenContextMenu["RowIndex"] = ExpressionConverter.ConvertO(__workflow_sAPGridViewOpenContextMenurowIndex);
                if (__workflow_sAPGridViewOpenContextMenusearchColumnName != null)
                {
                    sAPGridViewOpenContextMenu["SearchColumnName"] = ExpressionConverter.ConvertO(__workflow_sAPGridViewOpenContextMenusearchColumnName);
                    sAPGridViewOpenContextMenupropCount++;
                }

                if (__workflow_sAPGridViewOpenContextMenusearchColumnTitle != null)
                {
                    sAPGridViewOpenContextMenu["SearchColumnTitle"] = ExpressionConverter.ConvertO(__workflow_sAPGridViewOpenContextMenusearchColumnTitle);
                    sAPGridViewOpenContextMenupropCount++;
                }

                if (__workflow_sAPGridViewOpenContextMenusearchColumnTitleIsRegularExpression != null)
                {
                    if (__workflow_sAPGridViewOpenContextMenusearchColumnTitleIsRegularExpression != null)
                    {
                        sAPGridViewOpenContextMenu["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(__workflow_sAPGridViewOpenContextMenusearchColumnTitleIsRegularExpression);
                        sAPGridViewOpenContextMenupropCount++;
                    }

                    sAPGridViewOpenContextMenupropCount++;
                }
                else
                {
                    sAPGridViewOpenContextMenu["SearchColumnTitleIsRegularExpression"] = false;
                    sAPGridViewOpenContextMenupropCount++;
                }

                if (__workflow_sAPGridViewOpenContextMenusearchColumnTitleIsCaseSensitive != null)
                {
                    if (__workflow_sAPGridViewOpenContextMenusearchColumnTitleIsCaseSensitive != null)
                    {
                        sAPGridViewOpenContextMenu["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(__workflow_sAPGridViewOpenContextMenusearchColumnTitleIsCaseSensitive);
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
                sAPGridViewOpenContextMenu["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPGridViewOpenContextMenuworkflow);
                if (sAPGridViewOpenContextMenupropCount > 0)
                {
                    callPayload.Body = sAPGridViewOpenContextMenu;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetGridViewTextContentsResponse, ApiConnectionActionConfiguration> SAPGetGridViewTextContents(Expression<Func<string>> sAPGetGridViewTextContentssearchSAPElementId, Expression<Func<string>> sAPGetGridViewTextContentsworkflow, Expression<Func<int>> sAPGetGridViewTextContentsfirstRowToReturn = null, Expression<Func<int>> sAPGetGridViewTextContentsmaxRowsToReturn = null, Expression<Func<string>> sAPGetGridViewTextContentsfirstSearchColumnName = null, Expression<Func<string>> sAPGetGridViewTextContentsfirstSearchColumnTitle = null, Expression<Func<bool>> sAPGetGridViewTextContentsfirstSearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPGetGridViewTextContentsfirstSearchColumnTitleIsCaseSensitive = null, Expression<Func<int>> sAPGetGridViewTextContentsmaxColumnsToReturn = null, Expression<Func<bool>> sAPGetGridViewTextContentsuseColumnHeadersFromTable = null, Expression<Func<bool>> sAPGetGridViewTextContentsreturnRowIndexInOutputCollection = null, Expression<Func<string>> sAPGetGridViewTextContentsnameOfColumnToStoreRowIndex = null, Expression<Func<string>> sAPGetGridViewTextContentscheckedElementValue = null)
        {
            var __workflow_sAPGetGridViewTextContentssearchSAPElementId = WorkflowExpression.Compile(sAPGetGridViewTextContentssearchSAPElementId, nameof(sAPGetGridViewTextContentssearchSAPElementId), required: true);
            var __workflow_sAPGetGridViewTextContentsworkflow = WorkflowExpression.Compile(sAPGetGridViewTextContentsworkflow, nameof(sAPGetGridViewTextContentsworkflow), required: true);
            var __workflow_sAPGetGridViewTextContentsfirstRowToReturn = WorkflowExpression.Compile(sAPGetGridViewTextContentsfirstRowToReturn, nameof(sAPGetGridViewTextContentsfirstRowToReturn), required: false);
            var __workflow_sAPGetGridViewTextContentsmaxRowsToReturn = WorkflowExpression.Compile(sAPGetGridViewTextContentsmaxRowsToReturn, nameof(sAPGetGridViewTextContentsmaxRowsToReturn), required: false);
            var __workflow_sAPGetGridViewTextContentsfirstSearchColumnName = WorkflowExpression.Compile(sAPGetGridViewTextContentsfirstSearchColumnName, nameof(sAPGetGridViewTextContentsfirstSearchColumnName), required: false);
            var __workflow_sAPGetGridViewTextContentsfirstSearchColumnTitle = WorkflowExpression.Compile(sAPGetGridViewTextContentsfirstSearchColumnTitle, nameof(sAPGetGridViewTextContentsfirstSearchColumnTitle), required: false);
            var __workflow_sAPGetGridViewTextContentsfirstSearchColumnTitleIsRegularExpression = WorkflowExpression.Compile(sAPGetGridViewTextContentsfirstSearchColumnTitleIsRegularExpression, nameof(sAPGetGridViewTextContentsfirstSearchColumnTitleIsRegularExpression), required: false);
            var __workflow_sAPGetGridViewTextContentsfirstSearchColumnTitleIsCaseSensitive = WorkflowExpression.Compile(sAPGetGridViewTextContentsfirstSearchColumnTitleIsCaseSensitive, nameof(sAPGetGridViewTextContentsfirstSearchColumnTitleIsCaseSensitive), required: false);
            var __workflow_sAPGetGridViewTextContentsmaxColumnsToReturn = WorkflowExpression.Compile(sAPGetGridViewTextContentsmaxColumnsToReturn, nameof(sAPGetGridViewTextContentsmaxColumnsToReturn), required: false);
            var __workflow_sAPGetGridViewTextContentsuseColumnHeadersFromTable = WorkflowExpression.Compile(sAPGetGridViewTextContentsuseColumnHeadersFromTable, nameof(sAPGetGridViewTextContentsuseColumnHeadersFromTable), required: false);
            var __workflow_sAPGetGridViewTextContentsreturnRowIndexInOutputCollection = WorkflowExpression.Compile(sAPGetGridViewTextContentsreturnRowIndexInOutputCollection, nameof(sAPGetGridViewTextContentsreturnRowIndexInOutputCollection), required: false);
            var __workflow_sAPGetGridViewTextContentsnameOfColumnToStoreRowIndex = WorkflowExpression.Compile(sAPGetGridViewTextContentsnameOfColumnToStoreRowIndex, nameof(sAPGetGridViewTextContentsnameOfColumnToStoreRowIndex), required: false);
            var __workflow_sAPGetGridViewTextContentscheckedElementValue = WorkflowExpression.Compile(sAPGetGridViewTextContentscheckedElementValue, nameof(sAPGetGridViewTextContentscheckedElementValue), required: false);
            return new DeferredBodyAction<SAPGetGridViewTextContentsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetGridViewTextContents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGetGridViewTextContents = new JObject();
                var sAPGetGridViewTextContentspropCount = 0;
                sAPGetGridViewTextContentspropCount++;
                sAPGetGridViewTextContents["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPGetGridViewTextContentssearchSAPElementId);
                if (__workflow_sAPGetGridViewTextContentsfirstRowToReturn != null)
                {
                    if (__workflow_sAPGetGridViewTextContentsfirstRowToReturn != null)
                    {
                        sAPGetGridViewTextContents["FirstRowToReturn"] = ExpressionConverter.ConvertO(__workflow_sAPGetGridViewTextContentsfirstRowToReturn);
                        sAPGetGridViewTextContentspropCount++;
                    }

                    sAPGetGridViewTextContentspropCount++;
                }
                else
                {
                    sAPGetGridViewTextContents["FirstRowToReturn"] = 1;
                    sAPGetGridViewTextContentspropCount++;
                }

                if (__workflow_sAPGetGridViewTextContentsmaxRowsToReturn != null)
                {
                    if (__workflow_sAPGetGridViewTextContentsmaxRowsToReturn != null)
                    {
                        sAPGetGridViewTextContents["MaxRowsToReturn"] = ExpressionConverter.ConvertO(__workflow_sAPGetGridViewTextContentsmaxRowsToReturn);
                        sAPGetGridViewTextContentspropCount++;
                    }

                    sAPGetGridViewTextContentspropCount++;
                }
                else
                {
                    sAPGetGridViewTextContents["MaxRowsToReturn"] = 0;
                    sAPGetGridViewTextContentspropCount++;
                }

                if (__workflow_sAPGetGridViewTextContentsfirstSearchColumnName != null)
                {
                    sAPGetGridViewTextContents["FirstSearchColumnName"] = ExpressionConverter.ConvertO(__workflow_sAPGetGridViewTextContentsfirstSearchColumnName);
                    sAPGetGridViewTextContentspropCount++;
                }

                if (__workflow_sAPGetGridViewTextContentsfirstSearchColumnTitle != null)
                {
                    sAPGetGridViewTextContents["FirstSearchColumnTitle"] = ExpressionConverter.ConvertO(__workflow_sAPGetGridViewTextContentsfirstSearchColumnTitle);
                    sAPGetGridViewTextContentspropCount++;
                }

                if (__workflow_sAPGetGridViewTextContentsfirstSearchColumnTitleIsRegularExpression != null)
                {
                    if (__workflow_sAPGetGridViewTextContentsfirstSearchColumnTitleIsRegularExpression != null)
                    {
                        sAPGetGridViewTextContents["FirstSearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(__workflow_sAPGetGridViewTextContentsfirstSearchColumnTitleIsRegularExpression);
                        sAPGetGridViewTextContentspropCount++;
                    }

                    sAPGetGridViewTextContentspropCount++;
                }
                else
                {
                    sAPGetGridViewTextContents["FirstSearchColumnTitleIsRegularExpression"] = false;
                    sAPGetGridViewTextContentspropCount++;
                }

                if (__workflow_sAPGetGridViewTextContentsfirstSearchColumnTitleIsCaseSensitive != null)
                {
                    if (__workflow_sAPGetGridViewTextContentsfirstSearchColumnTitleIsCaseSensitive != null)
                    {
                        sAPGetGridViewTextContents["FirstSearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(__workflow_sAPGetGridViewTextContentsfirstSearchColumnTitleIsCaseSensitive);
                        sAPGetGridViewTextContentspropCount++;
                    }

                    sAPGetGridViewTextContentspropCount++;
                }
                else
                {
                    sAPGetGridViewTextContents["FirstSearchColumnTitleIsCaseSensitive"] = false;
                    sAPGetGridViewTextContentspropCount++;
                }

                if (__workflow_sAPGetGridViewTextContentsmaxColumnsToReturn != null)
                {
                    if (__workflow_sAPGetGridViewTextContentsmaxColumnsToReturn != null)
                    {
                        sAPGetGridViewTextContents["MaxColumnsToReturn"] = ExpressionConverter.ConvertO(__workflow_sAPGetGridViewTextContentsmaxColumnsToReturn);
                        sAPGetGridViewTextContentspropCount++;
                    }

                    sAPGetGridViewTextContentspropCount++;
                }
                else
                {
                    sAPGetGridViewTextContents["MaxColumnsToReturn"] = 0;
                    sAPGetGridViewTextContentspropCount++;
                }

                if (__workflow_sAPGetGridViewTextContentsuseColumnHeadersFromTable != null)
                {
                    if (__workflow_sAPGetGridViewTextContentsuseColumnHeadersFromTable != null)
                    {
                        sAPGetGridViewTextContents["UseColumnHeadersFromTable"] = ExpressionConverter.ConvertO(__workflow_sAPGetGridViewTextContentsuseColumnHeadersFromTable);
                        sAPGetGridViewTextContentspropCount++;
                    }

                    sAPGetGridViewTextContentspropCount++;
                }
                else
                {
                    sAPGetGridViewTextContents["UseColumnHeadersFromTable"] = true;
                    sAPGetGridViewTextContentspropCount++;
                }

                if (__workflow_sAPGetGridViewTextContentsreturnRowIndexInOutputCollection != null)
                {
                    if (__workflow_sAPGetGridViewTextContentsreturnRowIndexInOutputCollection != null)
                    {
                        sAPGetGridViewTextContents["ReturnRowIndexInOutputCollection"] = ExpressionConverter.ConvertO(__workflow_sAPGetGridViewTextContentsreturnRowIndexInOutputCollection);
                        sAPGetGridViewTextContentspropCount++;
                    }

                    sAPGetGridViewTextContentspropCount++;
                }
                else
                {
                    sAPGetGridViewTextContents["ReturnRowIndexInOutputCollection"] = false;
                    sAPGetGridViewTextContentspropCount++;
                }

                if (__workflow_sAPGetGridViewTextContentsnameOfColumnToStoreRowIndex != null)
                {
                    sAPGetGridViewTextContents["NameOfColumnToStoreRowIndex"] = ExpressionConverter.ConvertO(__workflow_sAPGetGridViewTextContentsnameOfColumnToStoreRowIndex);
                    sAPGetGridViewTextContentspropCount++;
                }

                if (__workflow_sAPGetGridViewTextContentscheckedElementValue != null)
                {
                    if (__workflow_sAPGetGridViewTextContentscheckedElementValue != null)
                    {
                        sAPGetGridViewTextContents["CheckedElementValue"] = ExpressionConverter.ConvertO(__workflow_sAPGetGridViewTextContentscheckedElementValue);
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
                sAPGetGridViewTextContents["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPGetGridViewTextContentsworkflow);
                if (sAPGetGridViewTextContentspropCount > 0)
                {
                    callPayload.Body = sAPGetGridViewTextContents;
                }

                return new ApiConnectionAction<SAPGetGridViewTextContentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPSelectCalendarMonth(Expression<Func<string>> sAPSelectCalendarMonthsearchSAPElementId, Expression<Func<int>> sAPSelectCalendarMonthmonth, Expression<Func<int>> sAPSelectCalendarMonthyear, Expression<Func<string>> sAPSelectCalendarMonthworkflow)
        {
            var __workflow_sAPSelectCalendarMonthsearchSAPElementId = WorkflowExpression.Compile(sAPSelectCalendarMonthsearchSAPElementId, nameof(sAPSelectCalendarMonthsearchSAPElementId), required: true);
            var __workflow_sAPSelectCalendarMonthmonth = WorkflowExpression.Compile(sAPSelectCalendarMonthmonth, nameof(sAPSelectCalendarMonthmonth), required: true);
            var __workflow_sAPSelectCalendarMonthyear = WorkflowExpression.Compile(sAPSelectCalendarMonthyear, nameof(sAPSelectCalendarMonthyear), required: true);
            var __workflow_sAPSelectCalendarMonthworkflow = WorkflowExpression.Compile(sAPSelectCalendarMonthworkflow, nameof(sAPSelectCalendarMonthworkflow), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSelectCalendarMonth";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPSelectCalendarMonth = new JObject();
                var sAPSelectCalendarMonthpropCount = 0;
                sAPSelectCalendarMonthpropCount++;
                sAPSelectCalendarMonth["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPSelectCalendarMonthsearchSAPElementId);
                sAPSelectCalendarMonthpropCount++;
                sAPSelectCalendarMonth["Month"] = ExpressionConverter.ConvertO(__workflow_sAPSelectCalendarMonthmonth);
                sAPSelectCalendarMonthpropCount++;
                sAPSelectCalendarMonth["Year"] = ExpressionConverter.ConvertO(__workflow_sAPSelectCalendarMonthyear);
                sAPSelectCalendarMonthpropCount++;
                sAPSelectCalendarMonth["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPSelectCalendarMonthworkflow);
                if (sAPSelectCalendarMonthpropCount > 0)
                {
                    callPayload.Body = sAPSelectCalendarMonth;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPSelectCalendarWeek(Expression<Func<string>> sAPSelectCalendarWeeksearchSAPElementId, Expression<Func<int>> sAPSelectCalendarWeekweek, Expression<Func<int>> sAPSelectCalendarWeekyear, Expression<Func<string>> sAPSelectCalendarWeekworkflow)
        {
            var __workflow_sAPSelectCalendarWeeksearchSAPElementId = WorkflowExpression.Compile(sAPSelectCalendarWeeksearchSAPElementId, nameof(sAPSelectCalendarWeeksearchSAPElementId), required: true);
            var __workflow_sAPSelectCalendarWeekweek = WorkflowExpression.Compile(sAPSelectCalendarWeekweek, nameof(sAPSelectCalendarWeekweek), required: true);
            var __workflow_sAPSelectCalendarWeekyear = WorkflowExpression.Compile(sAPSelectCalendarWeekyear, nameof(sAPSelectCalendarWeekyear), required: true);
            var __workflow_sAPSelectCalendarWeekworkflow = WorkflowExpression.Compile(sAPSelectCalendarWeekworkflow, nameof(sAPSelectCalendarWeekworkflow), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSelectCalendarWeek";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPSelectCalendarWeek = new JObject();
                var sAPSelectCalendarWeekpropCount = 0;
                sAPSelectCalendarWeekpropCount++;
                sAPSelectCalendarWeek["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPSelectCalendarWeeksearchSAPElementId);
                sAPSelectCalendarWeekpropCount++;
                sAPSelectCalendarWeek["Week"] = ExpressionConverter.ConvertO(__workflow_sAPSelectCalendarWeekweek);
                sAPSelectCalendarWeekpropCount++;
                sAPSelectCalendarWeek["Year"] = ExpressionConverter.ConvertO(__workflow_sAPSelectCalendarWeekyear);
                sAPSelectCalendarWeekpropCount++;
                sAPSelectCalendarWeek["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPSelectCalendarWeekworkflow);
                if (sAPSelectCalendarWeekpropCount > 0)
                {
                    callPayload.Body = sAPSelectCalendarWeek;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPSelectCalendarRange(Expression<Func<string>> sAPSelectCalendarRangesearchSAPElementId, Expression<Func<string>> sAPSelectCalendarRangefromDateYYYYMMDD, Expression<Func<string>> sAPSelectCalendarRangetoDateYYYYMMDD, Expression<Func<string>> sAPSelectCalendarRangeworkflow)
        {
            var __workflow_sAPSelectCalendarRangesearchSAPElementId = WorkflowExpression.Compile(sAPSelectCalendarRangesearchSAPElementId, nameof(sAPSelectCalendarRangesearchSAPElementId), required: true);
            var __workflow_sAPSelectCalendarRangefromDateYYYYMMDD = WorkflowExpression.Compile(sAPSelectCalendarRangefromDateYYYYMMDD, nameof(sAPSelectCalendarRangefromDateYYYYMMDD), required: true);
            var __workflow_sAPSelectCalendarRangetoDateYYYYMMDD = WorkflowExpression.Compile(sAPSelectCalendarRangetoDateYYYYMMDD, nameof(sAPSelectCalendarRangetoDateYYYYMMDD), required: true);
            var __workflow_sAPSelectCalendarRangeworkflow = WorkflowExpression.Compile(sAPSelectCalendarRangeworkflow, nameof(sAPSelectCalendarRangeworkflow), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSelectCalendarRange";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPSelectCalendarRange = new JObject();
                var sAPSelectCalendarRangepropCount = 0;
                sAPSelectCalendarRangepropCount++;
                sAPSelectCalendarRange["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPSelectCalendarRangesearchSAPElementId);
                sAPSelectCalendarRangepropCount++;
                sAPSelectCalendarRange["FromDateYYYYMMDD"] = ExpressionConverter.ConvertO(__workflow_sAPSelectCalendarRangefromDateYYYYMMDD);
                sAPSelectCalendarRangepropCount++;
                sAPSelectCalendarRange["ToDateYYYYMMDD"] = ExpressionConverter.ConvertO(__workflow_sAPSelectCalendarRangetoDateYYYYMMDD);
                sAPSelectCalendarRangepropCount++;
                sAPSelectCalendarRange["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPSelectCalendarRangeworkflow);
                if (sAPSelectCalendarRangepropCount > 0)
                {
                    callPayload.Body = sAPSelectCalendarRange;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPFocusCalendarDate(Expression<Func<string>> sAPFocusCalendarDatesearchSAPElementId, Expression<Func<string>> sAPFocusCalendarDatedateYYYYMMDD, Expression<Func<string>> sAPFocusCalendarDateworkflow)
        {
            var __workflow_sAPFocusCalendarDatesearchSAPElementId = WorkflowExpression.Compile(sAPFocusCalendarDatesearchSAPElementId, nameof(sAPFocusCalendarDatesearchSAPElementId), required: true);
            var __workflow_sAPFocusCalendarDatedateYYYYMMDD = WorkflowExpression.Compile(sAPFocusCalendarDatedateYYYYMMDD, nameof(sAPFocusCalendarDatedateYYYYMMDD), required: true);
            var __workflow_sAPFocusCalendarDateworkflow = WorkflowExpression.Compile(sAPFocusCalendarDateworkflow, nameof(sAPFocusCalendarDateworkflow), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPFocusCalendarDate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPFocusCalendarDate = new JObject();
                var sAPFocusCalendarDatepropCount = 0;
                sAPFocusCalendarDatepropCount++;
                sAPFocusCalendarDate["SearchSAPElementId"] = ExpressionConverter.ConvertO(__workflow_sAPFocusCalendarDatesearchSAPElementId);
                sAPFocusCalendarDatepropCount++;
                sAPFocusCalendarDate["DateYYYYMMDD"] = ExpressionConverter.ConvertO(__workflow_sAPFocusCalendarDatedateYYYYMMDD);
                sAPFocusCalendarDatepropCount++;
                sAPFocusCalendarDate["Workflow"] = ExpressionConverter.ConvertO(__workflow_sAPFocusCalendarDateworkflow);
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
