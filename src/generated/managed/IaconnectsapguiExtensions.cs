//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectsapgui
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class IaconnectsapguiActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPEnableScripting(Expression<Func<string>> sAPEnableScriptingworkflow, Expression<Func<bool>> sAPEnableScriptingnotifyWhenScriptAttachesToGUI = null, Expression<Func<bool>> sAPEnableScriptingnotifyWhenScriptOpensConnection = null, Expression<Func<bool>> sAPEnableScriptingshowNativeWindowsDialogs = null)
        {
            var __workflow_sAPEnableScriptingworkflow = sAPEnableScriptingworkflow == null ? null : WorkflowExpression.Compile(sAPEnableScriptingworkflow);
            WorkflowExpression.Validate(__workflow_sAPEnableScriptingworkflow, nameof(sAPEnableScriptingworkflow), required: true);
            var __workflow_sAPEnableScriptingnotifyWhenScriptAttachesToGUI = sAPEnableScriptingnotifyWhenScriptAttachesToGUI == null ? null : WorkflowExpression.Compile(sAPEnableScriptingnotifyWhenScriptAttachesToGUI);
            WorkflowExpression.Validate(__workflow_sAPEnableScriptingnotifyWhenScriptAttachesToGUI, nameof(sAPEnableScriptingnotifyWhenScriptAttachesToGUI), required: false);
            var __workflow_sAPEnableScriptingnotifyWhenScriptOpensConnection = sAPEnableScriptingnotifyWhenScriptOpensConnection == null ? null : WorkflowExpression.Compile(sAPEnableScriptingnotifyWhenScriptOpensConnection);
            WorkflowExpression.Validate(__workflow_sAPEnableScriptingnotifyWhenScriptOpensConnection, nameof(sAPEnableScriptingnotifyWhenScriptOpensConnection), required: false);
            var __workflow_sAPEnableScriptingshowNativeWindowsDialogs = sAPEnableScriptingshowNativeWindowsDialogs == null ? null : WorkflowExpression.Compile(sAPEnableScriptingshowNativeWindowsDialogs);
            WorkflowExpression.Validate(__workflow_sAPEnableScriptingshowNativeWindowsDialogs, nameof(sAPEnableScriptingshowNativeWindowsDialogs), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IBodyWorkflowAction<SAPLaunchSAPGUIResponse> SAPLaunchSAPGUI(Expression<Func<string>> sAPLaunchSAPGUIworkflow, Expression<Func<string>> sAPLaunchSAPGUIsAPLogonEXE = null, Expression<Func<string>> sAPLaunchSAPGUIsAPLogonArguments = null, Expression<Func<bool>> sAPLaunchSAPGUIenableSAPScripting = null, Expression<Func<bool>> sAPLaunchSAPGUInotifyWhenScriptAttachesToGUI = null, Expression<Func<bool>> sAPLaunchSAPGUInotifyWhenScriptOpensConnection = null, Expression<Func<bool>> sAPLaunchSAPGUIshowNativeWindowsDialogs = null, Expression<Func<bool>> sAPLaunchSAPGUIattachAfterLaunch = null, Expression<Func<double>> sAPLaunchSAPGUIsecondsToWait = null, Expression<Func<string>> sAPLaunchSAPGUIsAPProgId = null, Expression<Func<bool>> sAPLaunchSAPGUIdisableSystemMessages = null)
        {
            var __workflow_sAPLaunchSAPGUIworkflow = sAPLaunchSAPGUIworkflow == null ? null : WorkflowExpression.Compile(sAPLaunchSAPGUIworkflow);
            WorkflowExpression.Validate(__workflow_sAPLaunchSAPGUIworkflow, nameof(sAPLaunchSAPGUIworkflow), required: true);
            var __workflow_sAPLaunchSAPGUIsAPLogonEXE = sAPLaunchSAPGUIsAPLogonEXE == null ? null : WorkflowExpression.Compile(sAPLaunchSAPGUIsAPLogonEXE);
            WorkflowExpression.Validate(__workflow_sAPLaunchSAPGUIsAPLogonEXE, nameof(sAPLaunchSAPGUIsAPLogonEXE), required: false);
            var __workflow_sAPLaunchSAPGUIsAPLogonArguments = sAPLaunchSAPGUIsAPLogonArguments == null ? null : WorkflowExpression.Compile(sAPLaunchSAPGUIsAPLogonArguments);
            WorkflowExpression.Validate(__workflow_sAPLaunchSAPGUIsAPLogonArguments, nameof(sAPLaunchSAPGUIsAPLogonArguments), required: false);
            var __workflow_sAPLaunchSAPGUIenableSAPScripting = sAPLaunchSAPGUIenableSAPScripting == null ? null : WorkflowExpression.Compile(sAPLaunchSAPGUIenableSAPScripting);
            WorkflowExpression.Validate(__workflow_sAPLaunchSAPGUIenableSAPScripting, nameof(sAPLaunchSAPGUIenableSAPScripting), required: false);
            var __workflow_sAPLaunchSAPGUInotifyWhenScriptAttachesToGUI = sAPLaunchSAPGUInotifyWhenScriptAttachesToGUI == null ? null : WorkflowExpression.Compile(sAPLaunchSAPGUInotifyWhenScriptAttachesToGUI);
            WorkflowExpression.Validate(__workflow_sAPLaunchSAPGUInotifyWhenScriptAttachesToGUI, nameof(sAPLaunchSAPGUInotifyWhenScriptAttachesToGUI), required: false);
            var __workflow_sAPLaunchSAPGUInotifyWhenScriptOpensConnection = sAPLaunchSAPGUInotifyWhenScriptOpensConnection == null ? null : WorkflowExpression.Compile(sAPLaunchSAPGUInotifyWhenScriptOpensConnection);
            WorkflowExpression.Validate(__workflow_sAPLaunchSAPGUInotifyWhenScriptOpensConnection, nameof(sAPLaunchSAPGUInotifyWhenScriptOpensConnection), required: false);
            var __workflow_sAPLaunchSAPGUIshowNativeWindowsDialogs = sAPLaunchSAPGUIshowNativeWindowsDialogs == null ? null : WorkflowExpression.Compile(sAPLaunchSAPGUIshowNativeWindowsDialogs);
            WorkflowExpression.Validate(__workflow_sAPLaunchSAPGUIshowNativeWindowsDialogs, nameof(sAPLaunchSAPGUIshowNativeWindowsDialogs), required: false);
            var __workflow_sAPLaunchSAPGUIattachAfterLaunch = sAPLaunchSAPGUIattachAfterLaunch == null ? null : WorkflowExpression.Compile(sAPLaunchSAPGUIattachAfterLaunch);
            WorkflowExpression.Validate(__workflow_sAPLaunchSAPGUIattachAfterLaunch, nameof(sAPLaunchSAPGUIattachAfterLaunch), required: false);
            var __workflow_sAPLaunchSAPGUIsecondsToWait = sAPLaunchSAPGUIsecondsToWait == null ? null : WorkflowExpression.Compile(sAPLaunchSAPGUIsecondsToWait);
            WorkflowExpression.Validate(__workflow_sAPLaunchSAPGUIsecondsToWait, nameof(sAPLaunchSAPGUIsecondsToWait), required: false);
            var __workflow_sAPLaunchSAPGUIsAPProgId = sAPLaunchSAPGUIsAPProgId == null ? null : WorkflowExpression.Compile(sAPLaunchSAPGUIsAPProgId);
            WorkflowExpression.Validate(__workflow_sAPLaunchSAPGUIsAPProgId, nameof(sAPLaunchSAPGUIsAPProgId), required: false);
            var __workflow_sAPLaunchSAPGUIdisableSystemMessages = sAPLaunchSAPGUIdisableSystemMessages == null ? null : WorkflowExpression.Compile(sAPLaunchSAPGUIdisableSystemMessages);
            WorkflowExpression.Validate(__workflow_sAPLaunchSAPGUIdisableSystemMessages, nameof(sAPLaunchSAPGUIdisableSystemMessages), required: false);
            return new DeferredBodyAction<SAPLaunchSAPGUIResponse>(() =>
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
        public IBodyWorkflowAction<SAPAttachToSAPGUIResponse> SAPAttachToSAPGUI(Expression<Func<string>> sAPAttachToSAPGUIworkflow, Expression<Func<string>> sAPAttachToSAPGUIsAPProgId = null, Expression<Func<bool>> sAPAttachToSAPGUIdisableSystemMessages = null)
        {
            var __workflow_sAPAttachToSAPGUIworkflow = sAPAttachToSAPGUIworkflow == null ? null : WorkflowExpression.Compile(sAPAttachToSAPGUIworkflow);
            WorkflowExpression.Validate(__workflow_sAPAttachToSAPGUIworkflow, nameof(sAPAttachToSAPGUIworkflow), required: true);
            var __workflow_sAPAttachToSAPGUIsAPProgId = sAPAttachToSAPGUIsAPProgId == null ? null : WorkflowExpression.Compile(sAPAttachToSAPGUIsAPProgId);
            WorkflowExpression.Validate(__workflow_sAPAttachToSAPGUIsAPProgId, nameof(sAPAttachToSAPGUIsAPProgId), required: false);
            var __workflow_sAPAttachToSAPGUIdisableSystemMessages = sAPAttachToSAPGUIdisableSystemMessages == null ? null : WorkflowExpression.Compile(sAPAttachToSAPGUIdisableSystemMessages);
            WorkflowExpression.Validate(__workflow_sAPAttachToSAPGUIdisableSystemMessages, nameof(sAPAttachToSAPGUIdisableSystemMessages), required: false);
            return new DeferredBodyAction<SAPAttachToSAPGUIResponse>(() =>
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
        public IWorkflowAction SAPDetachFromSAPGUI(Expression<Func<string>> sAPDetachFromSAPGUIworkflow)
        {
            var __workflow_sAPDetachFromSAPGUIworkflow = sAPDetachFromSAPGUIworkflow == null ? null : WorkflowExpression.Compile(sAPDetachFromSAPGUIworkflow);
            WorkflowExpression.Validate(__workflow_sAPDetachFromSAPGUIworkflow, nameof(sAPDetachFromSAPGUIworkflow), required: true);
            return new DeferredWorkflowAction(() =>
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
        public IBodyWorkflowAction<SAPGetSAPGUIStatusResponse> SAPGetSAPGUIStatus(Expression<Func<string>> sAPGetSAPGUIStatusworkflow)
        {
            var __workflow_sAPGetSAPGUIStatusworkflow = sAPGetSAPGUIStatusworkflow == null ? null : WorkflowExpression.Compile(sAPGetSAPGUIStatusworkflow);
            WorkflowExpression.Validate(__workflow_sAPGetSAPGUIStatusworkflow, nameof(sAPGetSAPGUIStatusworkflow), required: true);
            return new DeferredBodyAction<SAPGetSAPGUIStatusResponse>(() =>
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
        public IBodyWorkflowAction<SAPGetSAPSessionsResponse> SAPGetSAPSessions(Expression<Func<string>> sAPGetSAPSessionsworkflow)
        {
            var __workflow_sAPGetSAPSessionsworkflow = sAPGetSAPSessionsworkflow == null ? null : WorkflowExpression.Compile(sAPGetSAPSessionsworkflow);
            WorkflowExpression.Validate(__workflow_sAPGetSAPSessionsworkflow, nameof(sAPGetSAPSessionsworkflow), required: true);
            return new DeferredBodyAction<SAPGetSAPSessionsResponse>(() =>
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
        public IBodyWorkflowAction<SAPAttachToSessionResponse> SAPAttachToSession(Expression<Func<string>> sAPAttachToSessionworkflow, Expression<Func<string>> sAPAttachToSessionsearchConnectionName = null, Expression<Func<string>> sAPAttachToSessionsearchSessionName = null)
        {
            var __workflow_sAPAttachToSessionworkflow = sAPAttachToSessionworkflow == null ? null : WorkflowExpression.Compile(sAPAttachToSessionworkflow);
            WorkflowExpression.Validate(__workflow_sAPAttachToSessionworkflow, nameof(sAPAttachToSessionworkflow), required: true);
            var __workflow_sAPAttachToSessionsearchConnectionName = sAPAttachToSessionsearchConnectionName == null ? null : WorkflowExpression.Compile(sAPAttachToSessionsearchConnectionName);
            WorkflowExpression.Validate(__workflow_sAPAttachToSessionsearchConnectionName, nameof(sAPAttachToSessionsearchConnectionName), required: false);
            var __workflow_sAPAttachToSessionsearchSessionName = sAPAttachToSessionsearchSessionName == null ? null : WorkflowExpression.Compile(sAPAttachToSessionsearchSessionName);
            WorkflowExpression.Validate(__workflow_sAPAttachToSessionsearchSessionName, nameof(sAPAttachToSessionsearchSessionName), required: false);
            return new DeferredBodyAction<SAPAttachToSessionResponse>(() =>
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
        public IWorkflowAction SAPCloseSession(Expression<Func<string>> sAPCloseSessionworkflow, Expression<Func<bool>> sAPCloseSessioncloseAttachedSession = null, Expression<Func<string>> sAPCloseSessionsearchConnectionName = null, Expression<Func<string>> sAPCloseSessionsearchSessionName = null)
        {
            var __workflow_sAPCloseSessionworkflow = sAPCloseSessionworkflow == null ? null : WorkflowExpression.Compile(sAPCloseSessionworkflow);
            WorkflowExpression.Validate(__workflow_sAPCloseSessionworkflow, nameof(sAPCloseSessionworkflow), required: true);
            var __workflow_sAPCloseSessioncloseAttachedSession = sAPCloseSessioncloseAttachedSession == null ? null : WorkflowExpression.Compile(sAPCloseSessioncloseAttachedSession);
            WorkflowExpression.Validate(__workflow_sAPCloseSessioncloseAttachedSession, nameof(sAPCloseSessioncloseAttachedSession), required: false);
            var __workflow_sAPCloseSessionsearchConnectionName = sAPCloseSessionsearchConnectionName == null ? null : WorkflowExpression.Compile(sAPCloseSessionsearchConnectionName);
            WorkflowExpression.Validate(__workflow_sAPCloseSessionsearchConnectionName, nameof(sAPCloseSessionsearchConnectionName), required: false);
            var __workflow_sAPCloseSessionsearchSessionName = sAPCloseSessionsearchSessionName == null ? null : WorkflowExpression.Compile(sAPCloseSessionsearchSessionName);
            WorkflowExpression.Validate(__workflow_sAPCloseSessionsearchSessionName, nameof(sAPCloseSessionsearchSessionName), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IBodyWorkflowAction<SAPGetAttachedSessionPropertiesResponse> SAPGetAttachedSessionProperties(Expression<Func<string>> sAPGetAttachedSessionPropertiesworkflow)
        {
            var __workflow_sAPGetAttachedSessionPropertiesworkflow = sAPGetAttachedSessionPropertiesworkflow == null ? null : WorkflowExpression.Compile(sAPGetAttachedSessionPropertiesworkflow);
            WorkflowExpression.Validate(__workflow_sAPGetAttachedSessionPropertiesworkflow, nameof(sAPGetAttachedSessionPropertiesworkflow), required: true);
            return new DeferredBodyAction<SAPGetAttachedSessionPropertiesResponse>(() =>
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
        public IBodyWorkflowAction<SAPWaitForAttachedSessionNotBusyResponse> SAPWaitForAttachedSessionNotBusy(Expression<Func<double>> sAPWaitForAttachedSessionNotBusysecondsToWait, Expression<Func<string>> sAPWaitForAttachedSessionNotBusyworkflow, Expression<Func<bool>> sAPWaitForAttachedSessionNotBusyraiseExceptionIfBusyAfterWait = null)
        {
            var __workflow_sAPWaitForAttachedSessionNotBusysecondsToWait = sAPWaitForAttachedSessionNotBusysecondsToWait == null ? null : WorkflowExpression.Compile(sAPWaitForAttachedSessionNotBusysecondsToWait);
            WorkflowExpression.Validate(__workflow_sAPWaitForAttachedSessionNotBusysecondsToWait, nameof(sAPWaitForAttachedSessionNotBusysecondsToWait), required: true);
            var __workflow_sAPWaitForAttachedSessionNotBusyworkflow = sAPWaitForAttachedSessionNotBusyworkflow == null ? null : WorkflowExpression.Compile(sAPWaitForAttachedSessionNotBusyworkflow);
            WorkflowExpression.Validate(__workflow_sAPWaitForAttachedSessionNotBusyworkflow, nameof(sAPWaitForAttachedSessionNotBusyworkflow), required: true);
            var __workflow_sAPWaitForAttachedSessionNotBusyraiseExceptionIfBusyAfterWait = sAPWaitForAttachedSessionNotBusyraiseExceptionIfBusyAfterWait == null ? null : WorkflowExpression.Compile(sAPWaitForAttachedSessionNotBusyraiseExceptionIfBusyAfterWait);
            WorkflowExpression.Validate(__workflow_sAPWaitForAttachedSessionNotBusyraiseExceptionIfBusyAfterWait, nameof(sAPWaitForAttachedSessionNotBusyraiseExceptionIfBusyAfterWait), required: false);
            return new DeferredBodyAction<SAPWaitForAttachedSessionNotBusyResponse>(() =>
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
        public IWorkflowAction SAPInputTextIntoSAPElement(Expression<Func<string>> sAPInputTextIntoSAPElementsearchSAPElementId, Expression<Func<string>> sAPInputTextIntoSAPElementworkflow, Expression<Func<string>> sAPInputTextIntoSAPElementtextToInput = null, Expression<Func<bool>> sAPInputTextIntoSAPElementreplaceExistingValue = null, Expression<Func<int>> sAPInputTextIntoSAPElementinsertPosition = null)
        {
            var __workflow_sAPInputTextIntoSAPElementsearchSAPElementId = sAPInputTextIntoSAPElementsearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPInputTextIntoSAPElementsearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPInputTextIntoSAPElementsearchSAPElementId, nameof(sAPInputTextIntoSAPElementsearchSAPElementId), required: true);
            var __workflow_sAPInputTextIntoSAPElementworkflow = sAPInputTextIntoSAPElementworkflow == null ? null : WorkflowExpression.Compile(sAPInputTextIntoSAPElementworkflow);
            WorkflowExpression.Validate(__workflow_sAPInputTextIntoSAPElementworkflow, nameof(sAPInputTextIntoSAPElementworkflow), required: true);
            var __workflow_sAPInputTextIntoSAPElementtextToInput = sAPInputTextIntoSAPElementtextToInput == null ? null : WorkflowExpression.Compile(sAPInputTextIntoSAPElementtextToInput);
            WorkflowExpression.Validate(__workflow_sAPInputTextIntoSAPElementtextToInput, nameof(sAPInputTextIntoSAPElementtextToInput), required: false);
            var __workflow_sAPInputTextIntoSAPElementreplaceExistingValue = sAPInputTextIntoSAPElementreplaceExistingValue == null ? null : WorkflowExpression.Compile(sAPInputTextIntoSAPElementreplaceExistingValue);
            WorkflowExpression.Validate(__workflow_sAPInputTextIntoSAPElementreplaceExistingValue, nameof(sAPInputTextIntoSAPElementreplaceExistingValue), required: false);
            var __workflow_sAPInputTextIntoSAPElementinsertPosition = sAPInputTextIntoSAPElementinsertPosition == null ? null : WorkflowExpression.Compile(sAPInputTextIntoSAPElementinsertPosition);
            WorkflowExpression.Validate(__workflow_sAPInputTextIntoSAPElementinsertPosition, nameof(sAPInputTextIntoSAPElementinsertPosition), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction SAPInputPasswordIntoSAPElement(Expression<Func<string>> sAPInputPasswordIntoSAPElementsearchSAPElementId, Expression<Func<string>> sAPInputPasswordIntoSAPElementpasswordToInput, Expression<Func<string>> sAPInputPasswordIntoSAPElementworkflow)
        {
            var __workflow_sAPInputPasswordIntoSAPElementsearchSAPElementId = sAPInputPasswordIntoSAPElementsearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPInputPasswordIntoSAPElementsearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPInputPasswordIntoSAPElementsearchSAPElementId, nameof(sAPInputPasswordIntoSAPElementsearchSAPElementId), required: true);
            var __workflow_sAPInputPasswordIntoSAPElementpasswordToInput = sAPInputPasswordIntoSAPElementpasswordToInput == null ? null : WorkflowExpression.Compile(sAPInputPasswordIntoSAPElementpasswordToInput);
            WorkflowExpression.Validate(__workflow_sAPInputPasswordIntoSAPElementpasswordToInput, nameof(sAPInputPasswordIntoSAPElementpasswordToInput), required: true);
            var __workflow_sAPInputPasswordIntoSAPElementworkflow = sAPInputPasswordIntoSAPElementworkflow == null ? null : WorkflowExpression.Compile(sAPInputPasswordIntoSAPElementworkflow);
            WorkflowExpression.Validate(__workflow_sAPInputPasswordIntoSAPElementworkflow, nameof(sAPInputPasswordIntoSAPElementworkflow), required: true);
            return new DeferredWorkflowAction(() =>
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
        public IBodyWorkflowAction<SAPGetElementPropertiesResponse> SAPGetElementProperties(Expression<Func<string>> sAPGetElementPropertiessearchSAPElementId, Expression<Func<string>> sAPGetElementPropertiesworkflow)
        {
            var __workflow_sAPGetElementPropertiessearchSAPElementId = sAPGetElementPropertiessearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPGetElementPropertiessearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPGetElementPropertiessearchSAPElementId, nameof(sAPGetElementPropertiessearchSAPElementId), required: true);
            var __workflow_sAPGetElementPropertiesworkflow = sAPGetElementPropertiesworkflow == null ? null : WorkflowExpression.Compile(sAPGetElementPropertiesworkflow);
            WorkflowExpression.Validate(__workflow_sAPGetElementPropertiesworkflow, nameof(sAPGetElementPropertiesworkflow), required: true);
            return new DeferredBodyAction<SAPGetElementPropertiesResponse>(() =>
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
        public IBodyWorkflowAction<SAPWaitForElementIdResponse> SAPWaitForElementId(Expression<Func<string>> sAPWaitForElementIdsearchSAPElementId, Expression<Func<string>> sAPWaitForElementIdworkflow, Expression<Func<double>> sAPWaitForElementIdsecondsToWait = null, Expression<Func<bool>> sAPWaitForElementIdraiseExceptionIfElementNotFound = null)
        {
            var __workflow_sAPWaitForElementIdsearchSAPElementId = sAPWaitForElementIdsearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPWaitForElementIdsearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPWaitForElementIdsearchSAPElementId, nameof(sAPWaitForElementIdsearchSAPElementId), required: true);
            var __workflow_sAPWaitForElementIdworkflow = sAPWaitForElementIdworkflow == null ? null : WorkflowExpression.Compile(sAPWaitForElementIdworkflow);
            WorkflowExpression.Validate(__workflow_sAPWaitForElementIdworkflow, nameof(sAPWaitForElementIdworkflow), required: true);
            var __workflow_sAPWaitForElementIdsecondsToWait = sAPWaitForElementIdsecondsToWait == null ? null : WorkflowExpression.Compile(sAPWaitForElementIdsecondsToWait);
            WorkflowExpression.Validate(__workflow_sAPWaitForElementIdsecondsToWait, nameof(sAPWaitForElementIdsecondsToWait), required: false);
            var __workflow_sAPWaitForElementIdraiseExceptionIfElementNotFound = sAPWaitForElementIdraiseExceptionIfElementNotFound == null ? null : WorkflowExpression.Compile(sAPWaitForElementIdraiseExceptionIfElementNotFound);
            WorkflowExpression.Validate(__workflow_sAPWaitForElementIdraiseExceptionIfElementNotFound, nameof(sAPWaitForElementIdraiseExceptionIfElementNotFound), required: false);
            return new DeferredBodyAction<SAPWaitForElementIdResponse>(() =>
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
        public IBodyWorkflowAction<SAPWaitForWindowResponse> SAPWaitForWindow(Expression<Func<string>> sAPWaitForWindowsearchSAPWindowTitle, Expression<Func<string>> sAPWaitForWindowworkflow, Expression<Func<bool>> sAPWaitForWindowsearchIsRegularExpression = null, Expression<Func<bool>> sAPWaitForWindowsearchIsCaseSensitive = null, Expression<Func<double>> sAPWaitForWindowsecondsToWait = null, Expression<Func<bool>> sAPWaitForWindowraiseExceptionIfElementNotFound = null)
        {
            var __workflow_sAPWaitForWindowsearchSAPWindowTitle = sAPWaitForWindowsearchSAPWindowTitle == null ? null : WorkflowExpression.Compile(sAPWaitForWindowsearchSAPWindowTitle);
            WorkflowExpression.Validate(__workflow_sAPWaitForWindowsearchSAPWindowTitle, nameof(sAPWaitForWindowsearchSAPWindowTitle), required: true);
            var __workflow_sAPWaitForWindowworkflow = sAPWaitForWindowworkflow == null ? null : WorkflowExpression.Compile(sAPWaitForWindowworkflow);
            WorkflowExpression.Validate(__workflow_sAPWaitForWindowworkflow, nameof(sAPWaitForWindowworkflow), required: true);
            var __workflow_sAPWaitForWindowsearchIsRegularExpression = sAPWaitForWindowsearchIsRegularExpression == null ? null : WorkflowExpression.Compile(sAPWaitForWindowsearchIsRegularExpression);
            WorkflowExpression.Validate(__workflow_sAPWaitForWindowsearchIsRegularExpression, nameof(sAPWaitForWindowsearchIsRegularExpression), required: false);
            var __workflow_sAPWaitForWindowsearchIsCaseSensitive = sAPWaitForWindowsearchIsCaseSensitive == null ? null : WorkflowExpression.Compile(sAPWaitForWindowsearchIsCaseSensitive);
            WorkflowExpression.Validate(__workflow_sAPWaitForWindowsearchIsCaseSensitive, nameof(sAPWaitForWindowsearchIsCaseSensitive), required: false);
            var __workflow_sAPWaitForWindowsecondsToWait = sAPWaitForWindowsecondsToWait == null ? null : WorkflowExpression.Compile(sAPWaitForWindowsecondsToWait);
            WorkflowExpression.Validate(__workflow_sAPWaitForWindowsecondsToWait, nameof(sAPWaitForWindowsecondsToWait), required: false);
            var __workflow_sAPWaitForWindowraiseExceptionIfElementNotFound = sAPWaitForWindowraiseExceptionIfElementNotFound == null ? null : WorkflowExpression.Compile(sAPWaitForWindowraiseExceptionIfElementNotFound);
            WorkflowExpression.Validate(__workflow_sAPWaitForWindowraiseExceptionIfElementNotFound, nameof(sAPWaitForWindowraiseExceptionIfElementNotFound), required: false);
            return new DeferredBodyAction<SAPWaitForWindowResponse>(() =>
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
        public IBodyWorkflowAction<SAPGetElementTextValueResponse> SAPGetElementTextValue(Expression<Func<string>> sAPGetElementTextValuesearchSAPElementId, Expression<Func<string>> sAPGetElementTextValueworkflow)
        {
            var __workflow_sAPGetElementTextValuesearchSAPElementId = sAPGetElementTextValuesearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPGetElementTextValuesearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPGetElementTextValuesearchSAPElementId, nameof(sAPGetElementTextValuesearchSAPElementId), required: true);
            var __workflow_sAPGetElementTextValueworkflow = sAPGetElementTextValueworkflow == null ? null : WorkflowExpression.Compile(sAPGetElementTextValueworkflow);
            WorkflowExpression.Validate(__workflow_sAPGetElementTextValueworkflow, nameof(sAPGetElementTextValueworkflow), required: true);
            return new DeferredBodyAction<SAPGetElementTextValueResponse>(() =>
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
        public IWorkflowAction SAPPressSAPElement(Expression<Func<string>> sAPPressSAPElementsearchSAPElementId, Expression<Func<string>> sAPPressSAPElementworkflow)
        {
            var __workflow_sAPPressSAPElementsearchSAPElementId = sAPPressSAPElementsearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPPressSAPElementsearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPPressSAPElementsearchSAPElementId, nameof(sAPPressSAPElementsearchSAPElementId), required: true);
            var __workflow_sAPPressSAPElementworkflow = sAPPressSAPElementworkflow == null ? null : WorkflowExpression.Compile(sAPPressSAPElementworkflow);
            WorkflowExpression.Validate(__workflow_sAPPressSAPElementworkflow, nameof(sAPPressSAPElementworkflow), required: true);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction SAPSelectSAPElement(Expression<Func<string>> sAPSelectSAPElementsearchSAPElementId, Expression<Func<string>> sAPSelectSAPElementworkflow)
        {
            var __workflow_sAPSelectSAPElementsearchSAPElementId = sAPSelectSAPElementsearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPSelectSAPElementsearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPSelectSAPElementsearchSAPElementId, nameof(sAPSelectSAPElementsearchSAPElementId), required: true);
            var __workflow_sAPSelectSAPElementworkflow = sAPSelectSAPElementworkflow == null ? null : WorkflowExpression.Compile(sAPSelectSAPElementworkflow);
            WorkflowExpression.Validate(__workflow_sAPSelectSAPElementworkflow, nameof(sAPSelectSAPElementworkflow), required: true);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction SAPFocusSAPElement(Expression<Func<string>> sAPFocusSAPElementsearchSAPElementId, Expression<Func<string>> sAPFocusSAPElementworkflow)
        {
            var __workflow_sAPFocusSAPElementsearchSAPElementId = sAPFocusSAPElementsearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPFocusSAPElementsearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPFocusSAPElementsearchSAPElementId, nameof(sAPFocusSAPElementsearchSAPElementId), required: true);
            var __workflow_sAPFocusSAPElementworkflow = sAPFocusSAPElementworkflow == null ? null : WorkflowExpression.Compile(sAPFocusSAPElementworkflow);
            WorkflowExpression.Validate(__workflow_sAPFocusSAPElementworkflow, nameof(sAPFocusSAPElementworkflow), required: true);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction SAPCheckSAPElement(Expression<Func<string>> sAPCheckSAPElementsearchSAPElementId, Expression<Func<string>> sAPCheckSAPElementworkflow, Expression<Func<bool>> sAPCheckSAPElementcheckElement = null)
        {
            var __workflow_sAPCheckSAPElementsearchSAPElementId = sAPCheckSAPElementsearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPCheckSAPElementsearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPCheckSAPElementsearchSAPElementId, nameof(sAPCheckSAPElementsearchSAPElementId), required: true);
            var __workflow_sAPCheckSAPElementworkflow = sAPCheckSAPElementworkflow == null ? null : WorkflowExpression.Compile(sAPCheckSAPElementworkflow);
            WorkflowExpression.Validate(__workflow_sAPCheckSAPElementworkflow, nameof(sAPCheckSAPElementworkflow), required: true);
            var __workflow_sAPCheckSAPElementcheckElement = sAPCheckSAPElementcheckElement == null ? null : WorkflowExpression.Compile(sAPCheckSAPElementcheckElement);
            WorkflowExpression.Validate(__workflow_sAPCheckSAPElementcheckElement, nameof(sAPCheckSAPElementcheckElement), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction SAPVisualiseSAPElement(Expression<Func<string>> sAPVisualiseSAPElementsearchSAPElementId, Expression<Func<string>> sAPVisualiseSAPElementworkflow, Expression<Func<bool>> sAPVisualiseSAPElementvisualiseOn = null)
        {
            var __workflow_sAPVisualiseSAPElementsearchSAPElementId = sAPVisualiseSAPElementsearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPVisualiseSAPElementsearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPVisualiseSAPElementsearchSAPElementId, nameof(sAPVisualiseSAPElementsearchSAPElementId), required: true);
            var __workflow_sAPVisualiseSAPElementworkflow = sAPVisualiseSAPElementworkflow == null ? null : WorkflowExpression.Compile(sAPVisualiseSAPElementworkflow);
            WorkflowExpression.Validate(__workflow_sAPVisualiseSAPElementworkflow, nameof(sAPVisualiseSAPElementworkflow), required: true);
            var __workflow_sAPVisualiseSAPElementvisualiseOn = sAPVisualiseSAPElementvisualiseOn == null ? null : WorkflowExpression.Compile(sAPVisualiseSAPElementvisualiseOn);
            WorkflowExpression.Validate(__workflow_sAPVisualiseSAPElementvisualiseOn, nameof(sAPVisualiseSAPElementvisualiseOn), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction SAPDrawRectangleAroundSAPElement(Expression<Func<string>> sAPDrawRectangleAroundSAPElementsearchSAPElementId, Expression<Func<string>> sAPDrawRectangleAroundSAPElementworkflow, Expression<Func<string>> sAPDrawRectangleAroundSAPElementpenColour = null, Expression<Func<int>> sAPDrawRectangleAroundSAPElementpenThicknessPixels = null)
        {
            var __workflow_sAPDrawRectangleAroundSAPElementsearchSAPElementId = sAPDrawRectangleAroundSAPElementsearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPDrawRectangleAroundSAPElementsearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPDrawRectangleAroundSAPElementsearchSAPElementId, nameof(sAPDrawRectangleAroundSAPElementsearchSAPElementId), required: true);
            var __workflow_sAPDrawRectangleAroundSAPElementworkflow = sAPDrawRectangleAroundSAPElementworkflow == null ? null : WorkflowExpression.Compile(sAPDrawRectangleAroundSAPElementworkflow);
            WorkflowExpression.Validate(__workflow_sAPDrawRectangleAroundSAPElementworkflow, nameof(sAPDrawRectangleAroundSAPElementworkflow), required: true);
            var __workflow_sAPDrawRectangleAroundSAPElementpenColour = sAPDrawRectangleAroundSAPElementpenColour == null ? null : WorkflowExpression.Compile(sAPDrawRectangleAroundSAPElementpenColour);
            WorkflowExpression.Validate(__workflow_sAPDrawRectangleAroundSAPElementpenColour, nameof(sAPDrawRectangleAroundSAPElementpenColour), required: false);
            var __workflow_sAPDrawRectangleAroundSAPElementpenThicknessPixels = sAPDrawRectangleAroundSAPElementpenThicknessPixels == null ? null : WorkflowExpression.Compile(sAPDrawRectangleAroundSAPElementpenThicknessPixels);
            WorkflowExpression.Validate(__workflow_sAPDrawRectangleAroundSAPElementpenThicknessPixels, nameof(sAPDrawRectangleAroundSAPElementpenThicknessPixels), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction SAPSendCommand(Expression<Func<string>> sAPSendCommandsAPCommand, Expression<Func<string>> sAPSendCommandworkflow)
        {
            var __workflow_sAPSendCommandsAPCommand = sAPSendCommandsAPCommand == null ? null : WorkflowExpression.Compile(sAPSendCommandsAPCommand);
            WorkflowExpression.Validate(__workflow_sAPSendCommandsAPCommand, nameof(sAPSendCommandsAPCommand), required: true);
            var __workflow_sAPSendCommandworkflow = sAPSendCommandworkflow == null ? null : WorkflowExpression.Compile(sAPSendCommandworkflow);
            WorkflowExpression.Validate(__workflow_sAPSendCommandworkflow, nameof(sAPSendCommandworkflow), required: true);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction SAPEnterTCode(Expression<Func<string>> sAPEnterTCodesAPTCode, Expression<Func<string>> sAPEnterTCodeworkflow)
        {
            var __workflow_sAPEnterTCodesAPTCode = sAPEnterTCodesAPTCode == null ? null : WorkflowExpression.Compile(sAPEnterTCodesAPTCode);
            WorkflowExpression.Validate(__workflow_sAPEnterTCodesAPTCode, nameof(sAPEnterTCodesAPTCode), required: true);
            var __workflow_sAPEnterTCodeworkflow = sAPEnterTCodeworkflow == null ? null : WorkflowExpression.Compile(sAPEnterTCodeworkflow);
            WorkflowExpression.Validate(__workflow_sAPEnterTCodeworkflow, nameof(sAPEnterTCodeworkflow), required: true);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction SAPSendVKey(Expression<Func<string>> sAPSendVKeysearchSAPElementId, Expression<Func<int>> sAPSendVKeysAPVKey, Expression<Func<string>> sAPSendVKeyworkflow, Expression<Func<bool>> sAPSendVKeydetectParentWindowElement = null)
        {
            var __workflow_sAPSendVKeysearchSAPElementId = sAPSendVKeysearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPSendVKeysearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPSendVKeysearchSAPElementId, nameof(sAPSendVKeysearchSAPElementId), required: true);
            var __workflow_sAPSendVKeysAPVKey = sAPSendVKeysAPVKey == null ? null : WorkflowExpression.Compile(sAPSendVKeysAPVKey);
            WorkflowExpression.Validate(__workflow_sAPSendVKeysAPVKey, nameof(sAPSendVKeysAPVKey), required: true);
            var __workflow_sAPSendVKeyworkflow = sAPSendVKeyworkflow == null ? null : WorkflowExpression.Compile(sAPSendVKeyworkflow);
            WorkflowExpression.Validate(__workflow_sAPSendVKeyworkflow, nameof(sAPSendVKeyworkflow), required: true);
            var __workflow_sAPSendVKeydetectParentWindowElement = sAPSendVKeydetectParentWindowElement == null ? null : WorkflowExpression.Compile(sAPSendVKeydetectParentWindowElement);
            WorkflowExpression.Validate(__workflow_sAPSendVKeydetectParentWindowElement, nameof(sAPSendVKeydetectParentWindowElement), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction SAPSendEnterVKey(Expression<Func<string>> sAPSendEnterVKeysearchSAPElementId, Expression<Func<string>> sAPSendEnterVKeyworkflow, Expression<Func<bool>> sAPSendEnterVKeydetectParentWindowElement = null)
        {
            var __workflow_sAPSendEnterVKeysearchSAPElementId = sAPSendEnterVKeysearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPSendEnterVKeysearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPSendEnterVKeysearchSAPElementId, nameof(sAPSendEnterVKeysearchSAPElementId), required: true);
            var __workflow_sAPSendEnterVKeyworkflow = sAPSendEnterVKeyworkflow == null ? null : WorkflowExpression.Compile(sAPSendEnterVKeyworkflow);
            WorkflowExpression.Validate(__workflow_sAPSendEnterVKeyworkflow, nameof(sAPSendEnterVKeyworkflow), required: true);
            var __workflow_sAPSendEnterVKeydetectParentWindowElement = sAPSendEnterVKeydetectParentWindowElement == null ? null : WorkflowExpression.Compile(sAPSendEnterVKeydetectParentWindowElement);
            WorkflowExpression.Validate(__workflow_sAPSendEnterVKeydetectParentWindowElement, nameof(sAPSendEnterVKeydetectParentWindowElement), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction SAPWindowRestore(Expression<Func<string>> sAPWindowRestoresearchSAPElementId, Expression<Func<string>> sAPWindowRestoreworkflow, Expression<Func<bool>> sAPWindowRestoredetectParentWindowElement = null)
        {
            var __workflow_sAPWindowRestoresearchSAPElementId = sAPWindowRestoresearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPWindowRestoresearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPWindowRestoresearchSAPElementId, nameof(sAPWindowRestoresearchSAPElementId), required: true);
            var __workflow_sAPWindowRestoreworkflow = sAPWindowRestoreworkflow == null ? null : WorkflowExpression.Compile(sAPWindowRestoreworkflow);
            WorkflowExpression.Validate(__workflow_sAPWindowRestoreworkflow, nameof(sAPWindowRestoreworkflow), required: true);
            var __workflow_sAPWindowRestoredetectParentWindowElement = sAPWindowRestoredetectParentWindowElement == null ? null : WorkflowExpression.Compile(sAPWindowRestoredetectParentWindowElement);
            WorkflowExpression.Validate(__workflow_sAPWindowRestoredetectParentWindowElement, nameof(sAPWindowRestoredetectParentWindowElement), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction SAPWindowMaximise(Expression<Func<string>> sAPWindowMaximisesearchSAPElementId, Expression<Func<string>> sAPWindowMaximiseworkflow, Expression<Func<bool>> sAPWindowMaximisedetectParentWindowElement = null)
        {
            var __workflow_sAPWindowMaximisesearchSAPElementId = sAPWindowMaximisesearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPWindowMaximisesearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPWindowMaximisesearchSAPElementId, nameof(sAPWindowMaximisesearchSAPElementId), required: true);
            var __workflow_sAPWindowMaximiseworkflow = sAPWindowMaximiseworkflow == null ? null : WorkflowExpression.Compile(sAPWindowMaximiseworkflow);
            WorkflowExpression.Validate(__workflow_sAPWindowMaximiseworkflow, nameof(sAPWindowMaximiseworkflow), required: true);
            var __workflow_sAPWindowMaximisedetectParentWindowElement = sAPWindowMaximisedetectParentWindowElement == null ? null : WorkflowExpression.Compile(sAPWindowMaximisedetectParentWindowElement);
            WorkflowExpression.Validate(__workflow_sAPWindowMaximisedetectParentWindowElement, nameof(sAPWindowMaximisedetectParentWindowElement), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction SAPWindowMinimise(Expression<Func<string>> sAPWindowMinimisesearchSAPElementId, Expression<Func<string>> sAPWindowMinimiseworkflow, Expression<Func<bool>> sAPWindowMinimisedetectParentWindowElement = null)
        {
            var __workflow_sAPWindowMinimisesearchSAPElementId = sAPWindowMinimisesearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPWindowMinimisesearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPWindowMinimisesearchSAPElementId, nameof(sAPWindowMinimisesearchSAPElementId), required: true);
            var __workflow_sAPWindowMinimiseworkflow = sAPWindowMinimiseworkflow == null ? null : WorkflowExpression.Compile(sAPWindowMinimiseworkflow);
            WorkflowExpression.Validate(__workflow_sAPWindowMinimiseworkflow, nameof(sAPWindowMinimiseworkflow), required: true);
            var __workflow_sAPWindowMinimisedetectParentWindowElement = sAPWindowMinimisedetectParentWindowElement == null ? null : WorkflowExpression.Compile(sAPWindowMinimisedetectParentWindowElement);
            WorkflowExpression.Validate(__workflow_sAPWindowMinimisedetectParentWindowElement, nameof(sAPWindowMinimisedetectParentWindowElement), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction SAPWindowClose(Expression<Func<string>> sAPWindowClosesearchSAPElementId, Expression<Func<string>> sAPWindowCloseworkflow, Expression<Func<bool>> sAPWindowClosedetectParentWindowElement = null)
        {
            var __workflow_sAPWindowClosesearchSAPElementId = sAPWindowClosesearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPWindowClosesearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPWindowClosesearchSAPElementId, nameof(sAPWindowClosesearchSAPElementId), required: true);
            var __workflow_sAPWindowCloseworkflow = sAPWindowCloseworkflow == null ? null : WorkflowExpression.Compile(sAPWindowCloseworkflow);
            WorkflowExpression.Validate(__workflow_sAPWindowCloseworkflow, nameof(sAPWindowCloseworkflow), required: true);
            var __workflow_sAPWindowClosedetectParentWindowElement = sAPWindowClosedetectParentWindowElement == null ? null : WorkflowExpression.Compile(sAPWindowClosedetectParentWindowElement);
            WorkflowExpression.Validate(__workflow_sAPWindowClosedetectParentWindowElement, nameof(sAPWindowClosedetectParentWindowElement), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction SAPBringWindowToFront(Expression<Func<string>> sAPBringWindowToFrontsearchSAPElementId, Expression<Func<string>> sAPBringWindowToFrontworkflow, Expression<Func<bool>> sAPBringWindowToFronttoggleWindow = null, Expression<Func<bool>> sAPBringWindowToFronttoggleUsesGlobalLeftMouseClickAgent = null, Expression<Func<double>> sAPBringWindowToFronttoggleDelay = null, Expression<Func<bool>> sAPBringWindowToFrontdetectParentWindowElement = null)
        {
            var __workflow_sAPBringWindowToFrontsearchSAPElementId = sAPBringWindowToFrontsearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPBringWindowToFrontsearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPBringWindowToFrontsearchSAPElementId, nameof(sAPBringWindowToFrontsearchSAPElementId), required: true);
            var __workflow_sAPBringWindowToFrontworkflow = sAPBringWindowToFrontworkflow == null ? null : WorkflowExpression.Compile(sAPBringWindowToFrontworkflow);
            WorkflowExpression.Validate(__workflow_sAPBringWindowToFrontworkflow, nameof(sAPBringWindowToFrontworkflow), required: true);
            var __workflow_sAPBringWindowToFronttoggleWindow = sAPBringWindowToFronttoggleWindow == null ? null : WorkflowExpression.Compile(sAPBringWindowToFronttoggleWindow);
            WorkflowExpression.Validate(__workflow_sAPBringWindowToFronttoggleWindow, nameof(sAPBringWindowToFronttoggleWindow), required: false);
            var __workflow_sAPBringWindowToFronttoggleUsesGlobalLeftMouseClickAgent = sAPBringWindowToFronttoggleUsesGlobalLeftMouseClickAgent == null ? null : WorkflowExpression.Compile(sAPBringWindowToFronttoggleUsesGlobalLeftMouseClickAgent);
            WorkflowExpression.Validate(__workflow_sAPBringWindowToFronttoggleUsesGlobalLeftMouseClickAgent, nameof(sAPBringWindowToFronttoggleUsesGlobalLeftMouseClickAgent), required: false);
            var __workflow_sAPBringWindowToFronttoggleDelay = sAPBringWindowToFronttoggleDelay == null ? null : WorkflowExpression.Compile(sAPBringWindowToFronttoggleDelay);
            WorkflowExpression.Validate(__workflow_sAPBringWindowToFronttoggleDelay, nameof(sAPBringWindowToFronttoggleDelay), required: false);
            var __workflow_sAPBringWindowToFrontdetectParentWindowElement = sAPBringWindowToFrontdetectParentWindowElement == null ? null : WorkflowExpression.Compile(sAPBringWindowToFrontdetectParentWindowElement);
            WorkflowExpression.Validate(__workflow_sAPBringWindowToFrontdetectParentWindowElement, nameof(sAPBringWindowToFrontdetectParentWindowElement), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction SAPGlobalLeftMouseClickOnSAPElement(Expression<Func<string>> sAPGlobalLeftMouseClickOnSAPElementsearchSAPElementId, Expression<Func<string>> sAPGlobalLeftMouseClickOnSAPElementworkflow, Expression<Func<bool>> sAPGlobalLeftMouseClickOnSAPElementsetElementWindowTopMost = null, Expression<Func<bool>> sAPGlobalLeftMouseClickOnSAPElementbringElementWindowToFront = null, Expression<Func<bool>> sAPGlobalLeftMouseClickOnSAPElementtoggleWindow = null, Expression<Func<bool>> sAPGlobalLeftMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent = null, Expression<Func<double>> sAPGlobalLeftMouseClickOnSAPElementtoggleDelay = null, Expression<Func<int>> sAPGlobalLeftMouseClickOnSAPElementclickOffsetX = null, Expression<Func<int>> sAPGlobalLeftMouseClickOnSAPElementclickOffsetY = null, Expression<Func<sAPGlobalLeftMouseClickOnSAPElementoffsetRelativeToInput>> sAPGlobalLeftMouseClickOnSAPElementoffsetRelativeTo = null)
        {
            var __workflow_sAPGlobalLeftMouseClickOnSAPElementsearchSAPElementId = sAPGlobalLeftMouseClickOnSAPElementsearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPGlobalLeftMouseClickOnSAPElementsearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPGlobalLeftMouseClickOnSAPElementsearchSAPElementId, nameof(sAPGlobalLeftMouseClickOnSAPElementsearchSAPElementId), required: true);
            var __workflow_sAPGlobalLeftMouseClickOnSAPElementworkflow = sAPGlobalLeftMouseClickOnSAPElementworkflow == null ? null : WorkflowExpression.Compile(sAPGlobalLeftMouseClickOnSAPElementworkflow);
            WorkflowExpression.Validate(__workflow_sAPGlobalLeftMouseClickOnSAPElementworkflow, nameof(sAPGlobalLeftMouseClickOnSAPElementworkflow), required: true);
            var __workflow_sAPGlobalLeftMouseClickOnSAPElementsetElementWindowTopMost = sAPGlobalLeftMouseClickOnSAPElementsetElementWindowTopMost == null ? null : WorkflowExpression.Compile(sAPGlobalLeftMouseClickOnSAPElementsetElementWindowTopMost);
            WorkflowExpression.Validate(__workflow_sAPGlobalLeftMouseClickOnSAPElementsetElementWindowTopMost, nameof(sAPGlobalLeftMouseClickOnSAPElementsetElementWindowTopMost), required: false);
            var __workflow_sAPGlobalLeftMouseClickOnSAPElementbringElementWindowToFront = sAPGlobalLeftMouseClickOnSAPElementbringElementWindowToFront == null ? null : WorkflowExpression.Compile(sAPGlobalLeftMouseClickOnSAPElementbringElementWindowToFront);
            WorkflowExpression.Validate(__workflow_sAPGlobalLeftMouseClickOnSAPElementbringElementWindowToFront, nameof(sAPGlobalLeftMouseClickOnSAPElementbringElementWindowToFront), required: false);
            var __workflow_sAPGlobalLeftMouseClickOnSAPElementtoggleWindow = sAPGlobalLeftMouseClickOnSAPElementtoggleWindow == null ? null : WorkflowExpression.Compile(sAPGlobalLeftMouseClickOnSAPElementtoggleWindow);
            WorkflowExpression.Validate(__workflow_sAPGlobalLeftMouseClickOnSAPElementtoggleWindow, nameof(sAPGlobalLeftMouseClickOnSAPElementtoggleWindow), required: false);
            var __workflow_sAPGlobalLeftMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent = sAPGlobalLeftMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent == null ? null : WorkflowExpression.Compile(sAPGlobalLeftMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent);
            WorkflowExpression.Validate(__workflow_sAPGlobalLeftMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent, nameof(sAPGlobalLeftMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent), required: false);
            var __workflow_sAPGlobalLeftMouseClickOnSAPElementtoggleDelay = sAPGlobalLeftMouseClickOnSAPElementtoggleDelay == null ? null : WorkflowExpression.Compile(sAPGlobalLeftMouseClickOnSAPElementtoggleDelay);
            WorkflowExpression.Validate(__workflow_sAPGlobalLeftMouseClickOnSAPElementtoggleDelay, nameof(sAPGlobalLeftMouseClickOnSAPElementtoggleDelay), required: false);
            var __workflow_sAPGlobalLeftMouseClickOnSAPElementclickOffsetX = sAPGlobalLeftMouseClickOnSAPElementclickOffsetX == null ? null : WorkflowExpression.Compile(sAPGlobalLeftMouseClickOnSAPElementclickOffsetX);
            WorkflowExpression.Validate(__workflow_sAPGlobalLeftMouseClickOnSAPElementclickOffsetX, nameof(sAPGlobalLeftMouseClickOnSAPElementclickOffsetX), required: false);
            var __workflow_sAPGlobalLeftMouseClickOnSAPElementclickOffsetY = sAPGlobalLeftMouseClickOnSAPElementclickOffsetY == null ? null : WorkflowExpression.Compile(sAPGlobalLeftMouseClickOnSAPElementclickOffsetY);
            WorkflowExpression.Validate(__workflow_sAPGlobalLeftMouseClickOnSAPElementclickOffsetY, nameof(sAPGlobalLeftMouseClickOnSAPElementclickOffsetY), required: false);
            var __workflow_sAPGlobalLeftMouseClickOnSAPElementoffsetRelativeTo = sAPGlobalLeftMouseClickOnSAPElementoffsetRelativeTo == null ? null : WorkflowExpression.Compile(sAPGlobalLeftMouseClickOnSAPElementoffsetRelativeTo);
            WorkflowExpression.Validate(__workflow_sAPGlobalLeftMouseClickOnSAPElementoffsetRelativeTo, nameof(sAPGlobalLeftMouseClickOnSAPElementoffsetRelativeTo), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction SAPGlobalRightMouseClickOnSAPElement(Expression<Func<string>> sAPGlobalRightMouseClickOnSAPElementsearchSAPElementId, Expression<Func<string>> sAPGlobalRightMouseClickOnSAPElementworkflow, Expression<Func<bool>> sAPGlobalRightMouseClickOnSAPElementsetElementWindowTopMost = null, Expression<Func<bool>> sAPGlobalRightMouseClickOnSAPElementbringElementWindowToFront = null, Expression<Func<bool>> sAPGlobalRightMouseClickOnSAPElementtoggleWindow = null, Expression<Func<bool>> sAPGlobalRightMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent = null, Expression<Func<double>> sAPGlobalRightMouseClickOnSAPElementtoggleDelay = null, Expression<Func<int>> sAPGlobalRightMouseClickOnSAPElementclickOffsetX = null, Expression<Func<int>> sAPGlobalRightMouseClickOnSAPElementclickOffsetY = null, Expression<Func<sAPGlobalRightMouseClickOnSAPElementoffsetRelativeToInput>> sAPGlobalRightMouseClickOnSAPElementoffsetRelativeTo = null)
        {
            var __workflow_sAPGlobalRightMouseClickOnSAPElementsearchSAPElementId = sAPGlobalRightMouseClickOnSAPElementsearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPGlobalRightMouseClickOnSAPElementsearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPGlobalRightMouseClickOnSAPElementsearchSAPElementId, nameof(sAPGlobalRightMouseClickOnSAPElementsearchSAPElementId), required: true);
            var __workflow_sAPGlobalRightMouseClickOnSAPElementworkflow = sAPGlobalRightMouseClickOnSAPElementworkflow == null ? null : WorkflowExpression.Compile(sAPGlobalRightMouseClickOnSAPElementworkflow);
            WorkflowExpression.Validate(__workflow_sAPGlobalRightMouseClickOnSAPElementworkflow, nameof(sAPGlobalRightMouseClickOnSAPElementworkflow), required: true);
            var __workflow_sAPGlobalRightMouseClickOnSAPElementsetElementWindowTopMost = sAPGlobalRightMouseClickOnSAPElementsetElementWindowTopMost == null ? null : WorkflowExpression.Compile(sAPGlobalRightMouseClickOnSAPElementsetElementWindowTopMost);
            WorkflowExpression.Validate(__workflow_sAPGlobalRightMouseClickOnSAPElementsetElementWindowTopMost, nameof(sAPGlobalRightMouseClickOnSAPElementsetElementWindowTopMost), required: false);
            var __workflow_sAPGlobalRightMouseClickOnSAPElementbringElementWindowToFront = sAPGlobalRightMouseClickOnSAPElementbringElementWindowToFront == null ? null : WorkflowExpression.Compile(sAPGlobalRightMouseClickOnSAPElementbringElementWindowToFront);
            WorkflowExpression.Validate(__workflow_sAPGlobalRightMouseClickOnSAPElementbringElementWindowToFront, nameof(sAPGlobalRightMouseClickOnSAPElementbringElementWindowToFront), required: false);
            var __workflow_sAPGlobalRightMouseClickOnSAPElementtoggleWindow = sAPGlobalRightMouseClickOnSAPElementtoggleWindow == null ? null : WorkflowExpression.Compile(sAPGlobalRightMouseClickOnSAPElementtoggleWindow);
            WorkflowExpression.Validate(__workflow_sAPGlobalRightMouseClickOnSAPElementtoggleWindow, nameof(sAPGlobalRightMouseClickOnSAPElementtoggleWindow), required: false);
            var __workflow_sAPGlobalRightMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent = sAPGlobalRightMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent == null ? null : WorkflowExpression.Compile(sAPGlobalRightMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent);
            WorkflowExpression.Validate(__workflow_sAPGlobalRightMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent, nameof(sAPGlobalRightMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent), required: false);
            var __workflow_sAPGlobalRightMouseClickOnSAPElementtoggleDelay = sAPGlobalRightMouseClickOnSAPElementtoggleDelay == null ? null : WorkflowExpression.Compile(sAPGlobalRightMouseClickOnSAPElementtoggleDelay);
            WorkflowExpression.Validate(__workflow_sAPGlobalRightMouseClickOnSAPElementtoggleDelay, nameof(sAPGlobalRightMouseClickOnSAPElementtoggleDelay), required: false);
            var __workflow_sAPGlobalRightMouseClickOnSAPElementclickOffsetX = sAPGlobalRightMouseClickOnSAPElementclickOffsetX == null ? null : WorkflowExpression.Compile(sAPGlobalRightMouseClickOnSAPElementclickOffsetX);
            WorkflowExpression.Validate(__workflow_sAPGlobalRightMouseClickOnSAPElementclickOffsetX, nameof(sAPGlobalRightMouseClickOnSAPElementclickOffsetX), required: false);
            var __workflow_sAPGlobalRightMouseClickOnSAPElementclickOffsetY = sAPGlobalRightMouseClickOnSAPElementclickOffsetY == null ? null : WorkflowExpression.Compile(sAPGlobalRightMouseClickOnSAPElementclickOffsetY);
            WorkflowExpression.Validate(__workflow_sAPGlobalRightMouseClickOnSAPElementclickOffsetY, nameof(sAPGlobalRightMouseClickOnSAPElementclickOffsetY), required: false);
            var __workflow_sAPGlobalRightMouseClickOnSAPElementoffsetRelativeTo = sAPGlobalRightMouseClickOnSAPElementoffsetRelativeTo == null ? null : WorkflowExpression.Compile(sAPGlobalRightMouseClickOnSAPElementoffsetRelativeTo);
            WorkflowExpression.Validate(__workflow_sAPGlobalRightMouseClickOnSAPElementoffsetRelativeTo, nameof(sAPGlobalRightMouseClickOnSAPElementoffsetRelativeTo), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction SAPGlobalMiddleMouseClickOnSAPElement(Expression<Func<string>> sAPGlobalMiddleMouseClickOnSAPElementsearchSAPElementId, Expression<Func<string>> sAPGlobalMiddleMouseClickOnSAPElementworkflow, Expression<Func<bool>> sAPGlobalMiddleMouseClickOnSAPElementsetElementWindowTopMost = null, Expression<Func<bool>> sAPGlobalMiddleMouseClickOnSAPElementbringElementWindowToFront = null, Expression<Func<bool>> sAPGlobalMiddleMouseClickOnSAPElementtoggleWindow = null, Expression<Func<bool>> sAPGlobalMiddleMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent = null, Expression<Func<double>> sAPGlobalMiddleMouseClickOnSAPElementtoggleDelay = null, Expression<Func<int>> sAPGlobalMiddleMouseClickOnSAPElementclickOffsetX = null, Expression<Func<int>> sAPGlobalMiddleMouseClickOnSAPElementclickOffsetY = null, Expression<Func<sAPGlobalMiddleMouseClickOnSAPElementoffsetRelativeToInput>> sAPGlobalMiddleMouseClickOnSAPElementoffsetRelativeTo = null)
        {
            var __workflow_sAPGlobalMiddleMouseClickOnSAPElementsearchSAPElementId = sAPGlobalMiddleMouseClickOnSAPElementsearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPGlobalMiddleMouseClickOnSAPElementsearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPGlobalMiddleMouseClickOnSAPElementsearchSAPElementId, nameof(sAPGlobalMiddleMouseClickOnSAPElementsearchSAPElementId), required: true);
            var __workflow_sAPGlobalMiddleMouseClickOnSAPElementworkflow = sAPGlobalMiddleMouseClickOnSAPElementworkflow == null ? null : WorkflowExpression.Compile(sAPGlobalMiddleMouseClickOnSAPElementworkflow);
            WorkflowExpression.Validate(__workflow_sAPGlobalMiddleMouseClickOnSAPElementworkflow, nameof(sAPGlobalMiddleMouseClickOnSAPElementworkflow), required: true);
            var __workflow_sAPGlobalMiddleMouseClickOnSAPElementsetElementWindowTopMost = sAPGlobalMiddleMouseClickOnSAPElementsetElementWindowTopMost == null ? null : WorkflowExpression.Compile(sAPGlobalMiddleMouseClickOnSAPElementsetElementWindowTopMost);
            WorkflowExpression.Validate(__workflow_sAPGlobalMiddleMouseClickOnSAPElementsetElementWindowTopMost, nameof(sAPGlobalMiddleMouseClickOnSAPElementsetElementWindowTopMost), required: false);
            var __workflow_sAPGlobalMiddleMouseClickOnSAPElementbringElementWindowToFront = sAPGlobalMiddleMouseClickOnSAPElementbringElementWindowToFront == null ? null : WorkflowExpression.Compile(sAPGlobalMiddleMouseClickOnSAPElementbringElementWindowToFront);
            WorkflowExpression.Validate(__workflow_sAPGlobalMiddleMouseClickOnSAPElementbringElementWindowToFront, nameof(sAPGlobalMiddleMouseClickOnSAPElementbringElementWindowToFront), required: false);
            var __workflow_sAPGlobalMiddleMouseClickOnSAPElementtoggleWindow = sAPGlobalMiddleMouseClickOnSAPElementtoggleWindow == null ? null : WorkflowExpression.Compile(sAPGlobalMiddleMouseClickOnSAPElementtoggleWindow);
            WorkflowExpression.Validate(__workflow_sAPGlobalMiddleMouseClickOnSAPElementtoggleWindow, nameof(sAPGlobalMiddleMouseClickOnSAPElementtoggleWindow), required: false);
            var __workflow_sAPGlobalMiddleMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent = sAPGlobalMiddleMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent == null ? null : WorkflowExpression.Compile(sAPGlobalMiddleMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent);
            WorkflowExpression.Validate(__workflow_sAPGlobalMiddleMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent, nameof(sAPGlobalMiddleMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent), required: false);
            var __workflow_sAPGlobalMiddleMouseClickOnSAPElementtoggleDelay = sAPGlobalMiddleMouseClickOnSAPElementtoggleDelay == null ? null : WorkflowExpression.Compile(sAPGlobalMiddleMouseClickOnSAPElementtoggleDelay);
            WorkflowExpression.Validate(__workflow_sAPGlobalMiddleMouseClickOnSAPElementtoggleDelay, nameof(sAPGlobalMiddleMouseClickOnSAPElementtoggleDelay), required: false);
            var __workflow_sAPGlobalMiddleMouseClickOnSAPElementclickOffsetX = sAPGlobalMiddleMouseClickOnSAPElementclickOffsetX == null ? null : WorkflowExpression.Compile(sAPGlobalMiddleMouseClickOnSAPElementclickOffsetX);
            WorkflowExpression.Validate(__workflow_sAPGlobalMiddleMouseClickOnSAPElementclickOffsetX, nameof(sAPGlobalMiddleMouseClickOnSAPElementclickOffsetX), required: false);
            var __workflow_sAPGlobalMiddleMouseClickOnSAPElementclickOffsetY = sAPGlobalMiddleMouseClickOnSAPElementclickOffsetY == null ? null : WorkflowExpression.Compile(sAPGlobalMiddleMouseClickOnSAPElementclickOffsetY);
            WorkflowExpression.Validate(__workflow_sAPGlobalMiddleMouseClickOnSAPElementclickOffsetY, nameof(sAPGlobalMiddleMouseClickOnSAPElementclickOffsetY), required: false);
            var __workflow_sAPGlobalMiddleMouseClickOnSAPElementoffsetRelativeTo = sAPGlobalMiddleMouseClickOnSAPElementoffsetRelativeTo == null ? null : WorkflowExpression.Compile(sAPGlobalMiddleMouseClickOnSAPElementoffsetRelativeTo);
            WorkflowExpression.Validate(__workflow_sAPGlobalMiddleMouseClickOnSAPElementoffsetRelativeTo, nameof(sAPGlobalMiddleMouseClickOnSAPElementoffsetRelativeTo), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction SAPGlobalDoubleLeftMouseClickOnSAPElement(Expression<Func<string>> sAPGlobalDoubleLeftMouseClickOnSAPElementsearchSAPElementId, Expression<Func<string>> sAPGlobalDoubleLeftMouseClickOnSAPElementworkflow, Expression<Func<bool>> sAPGlobalDoubleLeftMouseClickOnSAPElementsetElementWindowTopMost = null, Expression<Func<bool>> sAPGlobalDoubleLeftMouseClickOnSAPElementbringElementWindowToFront = null, Expression<Func<bool>> sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleWindow = null, Expression<Func<bool>> sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent = null, Expression<Func<double>> sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleDelay = null, Expression<Func<int>> sAPGlobalDoubleLeftMouseClickOnSAPElementclickOffsetX = null, Expression<Func<int>> sAPGlobalDoubleLeftMouseClickOnSAPElementclickOffsetY = null, Expression<Func<sAPGlobalDoubleLeftMouseClickOnSAPElementoffsetRelativeToInput>> sAPGlobalDoubleLeftMouseClickOnSAPElementoffsetRelativeTo = null, Expression<Func<int>> sAPGlobalDoubleLeftMouseClickOnSAPElementdoubleClickDelayInMilliseconds = null)
        {
            var __workflow_sAPGlobalDoubleLeftMouseClickOnSAPElementsearchSAPElementId = sAPGlobalDoubleLeftMouseClickOnSAPElementsearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPGlobalDoubleLeftMouseClickOnSAPElementsearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPGlobalDoubleLeftMouseClickOnSAPElementsearchSAPElementId, nameof(sAPGlobalDoubleLeftMouseClickOnSAPElementsearchSAPElementId), required: true);
            var __workflow_sAPGlobalDoubleLeftMouseClickOnSAPElementworkflow = sAPGlobalDoubleLeftMouseClickOnSAPElementworkflow == null ? null : WorkflowExpression.Compile(sAPGlobalDoubleLeftMouseClickOnSAPElementworkflow);
            WorkflowExpression.Validate(__workflow_sAPGlobalDoubleLeftMouseClickOnSAPElementworkflow, nameof(sAPGlobalDoubleLeftMouseClickOnSAPElementworkflow), required: true);
            var __workflow_sAPGlobalDoubleLeftMouseClickOnSAPElementsetElementWindowTopMost = sAPGlobalDoubleLeftMouseClickOnSAPElementsetElementWindowTopMost == null ? null : WorkflowExpression.Compile(sAPGlobalDoubleLeftMouseClickOnSAPElementsetElementWindowTopMost);
            WorkflowExpression.Validate(__workflow_sAPGlobalDoubleLeftMouseClickOnSAPElementsetElementWindowTopMost, nameof(sAPGlobalDoubleLeftMouseClickOnSAPElementsetElementWindowTopMost), required: false);
            var __workflow_sAPGlobalDoubleLeftMouseClickOnSAPElementbringElementWindowToFront = sAPGlobalDoubleLeftMouseClickOnSAPElementbringElementWindowToFront == null ? null : WorkflowExpression.Compile(sAPGlobalDoubleLeftMouseClickOnSAPElementbringElementWindowToFront);
            WorkflowExpression.Validate(__workflow_sAPGlobalDoubleLeftMouseClickOnSAPElementbringElementWindowToFront, nameof(sAPGlobalDoubleLeftMouseClickOnSAPElementbringElementWindowToFront), required: false);
            var __workflow_sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleWindow = sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleWindow == null ? null : WorkflowExpression.Compile(sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleWindow);
            WorkflowExpression.Validate(__workflow_sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleWindow, nameof(sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleWindow), required: false);
            var __workflow_sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent = sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent == null ? null : WorkflowExpression.Compile(sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent);
            WorkflowExpression.Validate(__workflow_sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent, nameof(sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent), required: false);
            var __workflow_sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleDelay = sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleDelay == null ? null : WorkflowExpression.Compile(sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleDelay);
            WorkflowExpression.Validate(__workflow_sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleDelay, nameof(sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleDelay), required: false);
            var __workflow_sAPGlobalDoubleLeftMouseClickOnSAPElementclickOffsetX = sAPGlobalDoubleLeftMouseClickOnSAPElementclickOffsetX == null ? null : WorkflowExpression.Compile(sAPGlobalDoubleLeftMouseClickOnSAPElementclickOffsetX);
            WorkflowExpression.Validate(__workflow_sAPGlobalDoubleLeftMouseClickOnSAPElementclickOffsetX, nameof(sAPGlobalDoubleLeftMouseClickOnSAPElementclickOffsetX), required: false);
            var __workflow_sAPGlobalDoubleLeftMouseClickOnSAPElementclickOffsetY = sAPGlobalDoubleLeftMouseClickOnSAPElementclickOffsetY == null ? null : WorkflowExpression.Compile(sAPGlobalDoubleLeftMouseClickOnSAPElementclickOffsetY);
            WorkflowExpression.Validate(__workflow_sAPGlobalDoubleLeftMouseClickOnSAPElementclickOffsetY, nameof(sAPGlobalDoubleLeftMouseClickOnSAPElementclickOffsetY), required: false);
            var __workflow_sAPGlobalDoubleLeftMouseClickOnSAPElementoffsetRelativeTo = sAPGlobalDoubleLeftMouseClickOnSAPElementoffsetRelativeTo == null ? null : WorkflowExpression.Compile(sAPGlobalDoubleLeftMouseClickOnSAPElementoffsetRelativeTo);
            WorkflowExpression.Validate(__workflow_sAPGlobalDoubleLeftMouseClickOnSAPElementoffsetRelativeTo, nameof(sAPGlobalDoubleLeftMouseClickOnSAPElementoffsetRelativeTo), required: false);
            var __workflow_sAPGlobalDoubleLeftMouseClickOnSAPElementdoubleClickDelayInMilliseconds = sAPGlobalDoubleLeftMouseClickOnSAPElementdoubleClickDelayInMilliseconds == null ? null : WorkflowExpression.Compile(sAPGlobalDoubleLeftMouseClickOnSAPElementdoubleClickDelayInMilliseconds);
            WorkflowExpression.Validate(__workflow_sAPGlobalDoubleLeftMouseClickOnSAPElementdoubleClickDelayInMilliseconds, nameof(sAPGlobalDoubleLeftMouseClickOnSAPElementdoubleClickDelayInMilliseconds), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction SAPGlobalInputTextIntoSAPElement(Expression<Func<string>> sAPGlobalInputTextIntoSAPElementsearchSAPElementId, Expression<Func<string>> sAPGlobalInputTextIntoSAPElementworkflow, Expression<Func<bool>> sAPGlobalInputTextIntoSAPElementsetElementWindowTopMost = null, Expression<Func<bool>> sAPGlobalInputTextIntoSAPElementbringElementWindowToFront = null, Expression<Func<bool>> sAPGlobalInputTextIntoSAPElementtoggleWindow = null, Expression<Func<bool>> sAPGlobalInputTextIntoSAPElementtoggleUsesGlobalLeftMouseClickAgent = null, Expression<Func<double>> sAPGlobalInputTextIntoSAPElementtoggleDelay = null, Expression<Func<bool>> sAPGlobalInputTextIntoSAPElementglobalMouseClickOnElement = null, Expression<Func<bool>> sAPGlobalInputTextIntoSAPElementreplaceExistingValueUsingDoubleClickDelete = null, Expression<Func<bool>> sAPGlobalInputTextIntoSAPElementreplaceExistingValueUsingCTRLADelete = null, Expression<Func<string>> sAPGlobalInputTextIntoSAPElementtextToInput = null, Expression<Func<bool>> sAPGlobalInputTextIntoSAPElementsendKeyEvents = null, Expression<Func<int>> sAPGlobalInputTextIntoSAPElementkeyIntervalInMilliseconds = null, Expression<Func<int>> sAPGlobalInputTextIntoSAPElementdoubleClickIntervalInMilliseconds = null, Expression<Func<bool>> sAPGlobalInputTextIntoSAPElementdontInterpretSymbols = null)
        {
            var __workflow_sAPGlobalInputTextIntoSAPElementsearchSAPElementId = sAPGlobalInputTextIntoSAPElementsearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPGlobalInputTextIntoSAPElementsearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPGlobalInputTextIntoSAPElementsearchSAPElementId, nameof(sAPGlobalInputTextIntoSAPElementsearchSAPElementId), required: true);
            var __workflow_sAPGlobalInputTextIntoSAPElementworkflow = sAPGlobalInputTextIntoSAPElementworkflow == null ? null : WorkflowExpression.Compile(sAPGlobalInputTextIntoSAPElementworkflow);
            WorkflowExpression.Validate(__workflow_sAPGlobalInputTextIntoSAPElementworkflow, nameof(sAPGlobalInputTextIntoSAPElementworkflow), required: true);
            var __workflow_sAPGlobalInputTextIntoSAPElementsetElementWindowTopMost = sAPGlobalInputTextIntoSAPElementsetElementWindowTopMost == null ? null : WorkflowExpression.Compile(sAPGlobalInputTextIntoSAPElementsetElementWindowTopMost);
            WorkflowExpression.Validate(__workflow_sAPGlobalInputTextIntoSAPElementsetElementWindowTopMost, nameof(sAPGlobalInputTextIntoSAPElementsetElementWindowTopMost), required: false);
            var __workflow_sAPGlobalInputTextIntoSAPElementbringElementWindowToFront = sAPGlobalInputTextIntoSAPElementbringElementWindowToFront == null ? null : WorkflowExpression.Compile(sAPGlobalInputTextIntoSAPElementbringElementWindowToFront);
            WorkflowExpression.Validate(__workflow_sAPGlobalInputTextIntoSAPElementbringElementWindowToFront, nameof(sAPGlobalInputTextIntoSAPElementbringElementWindowToFront), required: false);
            var __workflow_sAPGlobalInputTextIntoSAPElementtoggleWindow = sAPGlobalInputTextIntoSAPElementtoggleWindow == null ? null : WorkflowExpression.Compile(sAPGlobalInputTextIntoSAPElementtoggleWindow);
            WorkflowExpression.Validate(__workflow_sAPGlobalInputTextIntoSAPElementtoggleWindow, nameof(sAPGlobalInputTextIntoSAPElementtoggleWindow), required: false);
            var __workflow_sAPGlobalInputTextIntoSAPElementtoggleUsesGlobalLeftMouseClickAgent = sAPGlobalInputTextIntoSAPElementtoggleUsesGlobalLeftMouseClickAgent == null ? null : WorkflowExpression.Compile(sAPGlobalInputTextIntoSAPElementtoggleUsesGlobalLeftMouseClickAgent);
            WorkflowExpression.Validate(__workflow_sAPGlobalInputTextIntoSAPElementtoggleUsesGlobalLeftMouseClickAgent, nameof(sAPGlobalInputTextIntoSAPElementtoggleUsesGlobalLeftMouseClickAgent), required: false);
            var __workflow_sAPGlobalInputTextIntoSAPElementtoggleDelay = sAPGlobalInputTextIntoSAPElementtoggleDelay == null ? null : WorkflowExpression.Compile(sAPGlobalInputTextIntoSAPElementtoggleDelay);
            WorkflowExpression.Validate(__workflow_sAPGlobalInputTextIntoSAPElementtoggleDelay, nameof(sAPGlobalInputTextIntoSAPElementtoggleDelay), required: false);
            var __workflow_sAPGlobalInputTextIntoSAPElementglobalMouseClickOnElement = sAPGlobalInputTextIntoSAPElementglobalMouseClickOnElement == null ? null : WorkflowExpression.Compile(sAPGlobalInputTextIntoSAPElementglobalMouseClickOnElement);
            WorkflowExpression.Validate(__workflow_sAPGlobalInputTextIntoSAPElementglobalMouseClickOnElement, nameof(sAPGlobalInputTextIntoSAPElementglobalMouseClickOnElement), required: false);
            var __workflow_sAPGlobalInputTextIntoSAPElementreplaceExistingValueUsingDoubleClickDelete = sAPGlobalInputTextIntoSAPElementreplaceExistingValueUsingDoubleClickDelete == null ? null : WorkflowExpression.Compile(sAPGlobalInputTextIntoSAPElementreplaceExistingValueUsingDoubleClickDelete);
            WorkflowExpression.Validate(__workflow_sAPGlobalInputTextIntoSAPElementreplaceExistingValueUsingDoubleClickDelete, nameof(sAPGlobalInputTextIntoSAPElementreplaceExistingValueUsingDoubleClickDelete), required: false);
            var __workflow_sAPGlobalInputTextIntoSAPElementreplaceExistingValueUsingCTRLADelete = sAPGlobalInputTextIntoSAPElementreplaceExistingValueUsingCTRLADelete == null ? null : WorkflowExpression.Compile(sAPGlobalInputTextIntoSAPElementreplaceExistingValueUsingCTRLADelete);
            WorkflowExpression.Validate(__workflow_sAPGlobalInputTextIntoSAPElementreplaceExistingValueUsingCTRLADelete, nameof(sAPGlobalInputTextIntoSAPElementreplaceExistingValueUsingCTRLADelete), required: false);
            var __workflow_sAPGlobalInputTextIntoSAPElementtextToInput = sAPGlobalInputTextIntoSAPElementtextToInput == null ? null : WorkflowExpression.Compile(sAPGlobalInputTextIntoSAPElementtextToInput);
            WorkflowExpression.Validate(__workflow_sAPGlobalInputTextIntoSAPElementtextToInput, nameof(sAPGlobalInputTextIntoSAPElementtextToInput), required: false);
            var __workflow_sAPGlobalInputTextIntoSAPElementsendKeyEvents = sAPGlobalInputTextIntoSAPElementsendKeyEvents == null ? null : WorkflowExpression.Compile(sAPGlobalInputTextIntoSAPElementsendKeyEvents);
            WorkflowExpression.Validate(__workflow_sAPGlobalInputTextIntoSAPElementsendKeyEvents, nameof(sAPGlobalInputTextIntoSAPElementsendKeyEvents), required: false);
            var __workflow_sAPGlobalInputTextIntoSAPElementkeyIntervalInMilliseconds = sAPGlobalInputTextIntoSAPElementkeyIntervalInMilliseconds == null ? null : WorkflowExpression.Compile(sAPGlobalInputTextIntoSAPElementkeyIntervalInMilliseconds);
            WorkflowExpression.Validate(__workflow_sAPGlobalInputTextIntoSAPElementkeyIntervalInMilliseconds, nameof(sAPGlobalInputTextIntoSAPElementkeyIntervalInMilliseconds), required: false);
            var __workflow_sAPGlobalInputTextIntoSAPElementdoubleClickIntervalInMilliseconds = sAPGlobalInputTextIntoSAPElementdoubleClickIntervalInMilliseconds == null ? null : WorkflowExpression.Compile(sAPGlobalInputTextIntoSAPElementdoubleClickIntervalInMilliseconds);
            WorkflowExpression.Validate(__workflow_sAPGlobalInputTextIntoSAPElementdoubleClickIntervalInMilliseconds, nameof(sAPGlobalInputTextIntoSAPElementdoubleClickIntervalInMilliseconds), required: false);
            var __workflow_sAPGlobalInputTextIntoSAPElementdontInterpretSymbols = sAPGlobalInputTextIntoSAPElementdontInterpretSymbols == null ? null : WorkflowExpression.Compile(sAPGlobalInputTextIntoSAPElementdontInterpretSymbols);
            WorkflowExpression.Validate(__workflow_sAPGlobalInputTextIntoSAPElementdontInterpretSymbols, nameof(sAPGlobalInputTextIntoSAPElementdontInterpretSymbols), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction SAPGlobalInputPasswordIntoSAPElement(Expression<Func<string>> sAPGlobalInputPasswordIntoSAPElementsearchSAPElementId, Expression<Func<string>> sAPGlobalInputPasswordIntoSAPElementpasswordToInput, Expression<Func<string>> sAPGlobalInputPasswordIntoSAPElementworkflow, Expression<Func<bool>> sAPGlobalInputPasswordIntoSAPElementsetElementWindowTopMost = null, Expression<Func<bool>> sAPGlobalInputPasswordIntoSAPElementbringElementWindowToFront = null, Expression<Func<bool>> sAPGlobalInputPasswordIntoSAPElementtoggleWindow = null, Expression<Func<bool>> sAPGlobalInputPasswordIntoSAPElementtoggleUsesGlobalLeftMouseClickAgent = null, Expression<Func<double>> sAPGlobalInputPasswordIntoSAPElementtoggleDelay = null, Expression<Func<bool>> sAPGlobalInputPasswordIntoSAPElementglobalMouseClickOnElement = null, Expression<Func<bool>> sAPGlobalInputPasswordIntoSAPElementreplaceExistingValueUsingDoubleClickDelete = null, Expression<Func<bool>> sAPGlobalInputPasswordIntoSAPElementreplaceExistingValueUsingCTRLADelete = null, Expression<Func<bool>> sAPGlobalInputPasswordIntoSAPElementsendKeyEvents = null, Expression<Func<int>> sAPGlobalInputPasswordIntoSAPElementkeyIntervalInMilliseconds = null, Expression<Func<int>> sAPGlobalInputPasswordIntoSAPElementdoubleClickIntervalInMilliseconds = null, Expression<Func<bool>> sAPGlobalInputPasswordIntoSAPElementdontInterpretSymbols = null)
        {
            var __workflow_sAPGlobalInputPasswordIntoSAPElementsearchSAPElementId = sAPGlobalInputPasswordIntoSAPElementsearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPGlobalInputPasswordIntoSAPElementsearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPGlobalInputPasswordIntoSAPElementsearchSAPElementId, nameof(sAPGlobalInputPasswordIntoSAPElementsearchSAPElementId), required: true);
            var __workflow_sAPGlobalInputPasswordIntoSAPElementpasswordToInput = sAPGlobalInputPasswordIntoSAPElementpasswordToInput == null ? null : WorkflowExpression.Compile(sAPGlobalInputPasswordIntoSAPElementpasswordToInput);
            WorkflowExpression.Validate(__workflow_sAPGlobalInputPasswordIntoSAPElementpasswordToInput, nameof(sAPGlobalInputPasswordIntoSAPElementpasswordToInput), required: true);
            var __workflow_sAPGlobalInputPasswordIntoSAPElementworkflow = sAPGlobalInputPasswordIntoSAPElementworkflow == null ? null : WorkflowExpression.Compile(sAPGlobalInputPasswordIntoSAPElementworkflow);
            WorkflowExpression.Validate(__workflow_sAPGlobalInputPasswordIntoSAPElementworkflow, nameof(sAPGlobalInputPasswordIntoSAPElementworkflow), required: true);
            var __workflow_sAPGlobalInputPasswordIntoSAPElementsetElementWindowTopMost = sAPGlobalInputPasswordIntoSAPElementsetElementWindowTopMost == null ? null : WorkflowExpression.Compile(sAPGlobalInputPasswordIntoSAPElementsetElementWindowTopMost);
            WorkflowExpression.Validate(__workflow_sAPGlobalInputPasswordIntoSAPElementsetElementWindowTopMost, nameof(sAPGlobalInputPasswordIntoSAPElementsetElementWindowTopMost), required: false);
            var __workflow_sAPGlobalInputPasswordIntoSAPElementbringElementWindowToFront = sAPGlobalInputPasswordIntoSAPElementbringElementWindowToFront == null ? null : WorkflowExpression.Compile(sAPGlobalInputPasswordIntoSAPElementbringElementWindowToFront);
            WorkflowExpression.Validate(__workflow_sAPGlobalInputPasswordIntoSAPElementbringElementWindowToFront, nameof(sAPGlobalInputPasswordIntoSAPElementbringElementWindowToFront), required: false);
            var __workflow_sAPGlobalInputPasswordIntoSAPElementtoggleWindow = sAPGlobalInputPasswordIntoSAPElementtoggleWindow == null ? null : WorkflowExpression.Compile(sAPGlobalInputPasswordIntoSAPElementtoggleWindow);
            WorkflowExpression.Validate(__workflow_sAPGlobalInputPasswordIntoSAPElementtoggleWindow, nameof(sAPGlobalInputPasswordIntoSAPElementtoggleWindow), required: false);
            var __workflow_sAPGlobalInputPasswordIntoSAPElementtoggleUsesGlobalLeftMouseClickAgent = sAPGlobalInputPasswordIntoSAPElementtoggleUsesGlobalLeftMouseClickAgent == null ? null : WorkflowExpression.Compile(sAPGlobalInputPasswordIntoSAPElementtoggleUsesGlobalLeftMouseClickAgent);
            WorkflowExpression.Validate(__workflow_sAPGlobalInputPasswordIntoSAPElementtoggleUsesGlobalLeftMouseClickAgent, nameof(sAPGlobalInputPasswordIntoSAPElementtoggleUsesGlobalLeftMouseClickAgent), required: false);
            var __workflow_sAPGlobalInputPasswordIntoSAPElementtoggleDelay = sAPGlobalInputPasswordIntoSAPElementtoggleDelay == null ? null : WorkflowExpression.Compile(sAPGlobalInputPasswordIntoSAPElementtoggleDelay);
            WorkflowExpression.Validate(__workflow_sAPGlobalInputPasswordIntoSAPElementtoggleDelay, nameof(sAPGlobalInputPasswordIntoSAPElementtoggleDelay), required: false);
            var __workflow_sAPGlobalInputPasswordIntoSAPElementglobalMouseClickOnElement = sAPGlobalInputPasswordIntoSAPElementglobalMouseClickOnElement == null ? null : WorkflowExpression.Compile(sAPGlobalInputPasswordIntoSAPElementglobalMouseClickOnElement);
            WorkflowExpression.Validate(__workflow_sAPGlobalInputPasswordIntoSAPElementglobalMouseClickOnElement, nameof(sAPGlobalInputPasswordIntoSAPElementglobalMouseClickOnElement), required: false);
            var __workflow_sAPGlobalInputPasswordIntoSAPElementreplaceExistingValueUsingDoubleClickDelete = sAPGlobalInputPasswordIntoSAPElementreplaceExistingValueUsingDoubleClickDelete == null ? null : WorkflowExpression.Compile(sAPGlobalInputPasswordIntoSAPElementreplaceExistingValueUsingDoubleClickDelete);
            WorkflowExpression.Validate(__workflow_sAPGlobalInputPasswordIntoSAPElementreplaceExistingValueUsingDoubleClickDelete, nameof(sAPGlobalInputPasswordIntoSAPElementreplaceExistingValueUsingDoubleClickDelete), required: false);
            var __workflow_sAPGlobalInputPasswordIntoSAPElementreplaceExistingValueUsingCTRLADelete = sAPGlobalInputPasswordIntoSAPElementreplaceExistingValueUsingCTRLADelete == null ? null : WorkflowExpression.Compile(sAPGlobalInputPasswordIntoSAPElementreplaceExistingValueUsingCTRLADelete);
            WorkflowExpression.Validate(__workflow_sAPGlobalInputPasswordIntoSAPElementreplaceExistingValueUsingCTRLADelete, nameof(sAPGlobalInputPasswordIntoSAPElementreplaceExistingValueUsingCTRLADelete), required: false);
            var __workflow_sAPGlobalInputPasswordIntoSAPElementsendKeyEvents = sAPGlobalInputPasswordIntoSAPElementsendKeyEvents == null ? null : WorkflowExpression.Compile(sAPGlobalInputPasswordIntoSAPElementsendKeyEvents);
            WorkflowExpression.Validate(__workflow_sAPGlobalInputPasswordIntoSAPElementsendKeyEvents, nameof(sAPGlobalInputPasswordIntoSAPElementsendKeyEvents), required: false);
            var __workflow_sAPGlobalInputPasswordIntoSAPElementkeyIntervalInMilliseconds = sAPGlobalInputPasswordIntoSAPElementkeyIntervalInMilliseconds == null ? null : WorkflowExpression.Compile(sAPGlobalInputPasswordIntoSAPElementkeyIntervalInMilliseconds);
            WorkflowExpression.Validate(__workflow_sAPGlobalInputPasswordIntoSAPElementkeyIntervalInMilliseconds, nameof(sAPGlobalInputPasswordIntoSAPElementkeyIntervalInMilliseconds), required: false);
            var __workflow_sAPGlobalInputPasswordIntoSAPElementdoubleClickIntervalInMilliseconds = sAPGlobalInputPasswordIntoSAPElementdoubleClickIntervalInMilliseconds == null ? null : WorkflowExpression.Compile(sAPGlobalInputPasswordIntoSAPElementdoubleClickIntervalInMilliseconds);
            WorkflowExpression.Validate(__workflow_sAPGlobalInputPasswordIntoSAPElementdoubleClickIntervalInMilliseconds, nameof(sAPGlobalInputPasswordIntoSAPElementdoubleClickIntervalInMilliseconds), required: false);
            var __workflow_sAPGlobalInputPasswordIntoSAPElementdontInterpretSymbols = sAPGlobalInputPasswordIntoSAPElementdontInterpretSymbols == null ? null : WorkflowExpression.Compile(sAPGlobalInputPasswordIntoSAPElementdontInterpretSymbols);
            WorkflowExpression.Validate(__workflow_sAPGlobalInputPasswordIntoSAPElementdontInterpretSymbols, nameof(sAPGlobalInputPasswordIntoSAPElementdontInterpretSymbols), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction SAPSetListSelectionByName(Expression<Func<string>> sAPSetListSelectionByNamesearchSAPElementId, Expression<Func<string>> sAPSetListSelectionByNamelistItemName, Expression<Func<string>> sAPSetListSelectionByNameworkflow)
        {
            var __workflow_sAPSetListSelectionByNamesearchSAPElementId = sAPSetListSelectionByNamesearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPSetListSelectionByNamesearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPSetListSelectionByNamesearchSAPElementId, nameof(sAPSetListSelectionByNamesearchSAPElementId), required: true);
            var __workflow_sAPSetListSelectionByNamelistItemName = sAPSetListSelectionByNamelistItemName == null ? null : WorkflowExpression.Compile(sAPSetListSelectionByNamelistItemName);
            WorkflowExpression.Validate(__workflow_sAPSetListSelectionByNamelistItemName, nameof(sAPSetListSelectionByNamelistItemName), required: true);
            var __workflow_sAPSetListSelectionByNameworkflow = sAPSetListSelectionByNameworkflow == null ? null : WorkflowExpression.Compile(sAPSetListSelectionByNameworkflow);
            WorkflowExpression.Validate(__workflow_sAPSetListSelectionByNameworkflow, nameof(sAPSetListSelectionByNameworkflow), required: true);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction SAPSetListSelectionByKey(Expression<Func<string>> sAPSetListSelectionByKeysearchSAPElementId, Expression<Func<string>> sAPSetListSelectionByKeylistItemKey, Expression<Func<string>> sAPSetListSelectionByKeyworkflow)
        {
            var __workflow_sAPSetListSelectionByKeysearchSAPElementId = sAPSetListSelectionByKeysearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPSetListSelectionByKeysearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPSetListSelectionByKeysearchSAPElementId, nameof(sAPSetListSelectionByKeysearchSAPElementId), required: true);
            var __workflow_sAPSetListSelectionByKeylistItemKey = sAPSetListSelectionByKeylistItemKey == null ? null : WorkflowExpression.Compile(sAPSetListSelectionByKeylistItemKey);
            WorkflowExpression.Validate(__workflow_sAPSetListSelectionByKeylistItemKey, nameof(sAPSetListSelectionByKeylistItemKey), required: true);
            var __workflow_sAPSetListSelectionByKeyworkflow = sAPSetListSelectionByKeyworkflow == null ? null : WorkflowExpression.Compile(sAPSetListSelectionByKeyworkflow);
            WorkflowExpression.Validate(__workflow_sAPSetListSelectionByKeyworkflow, nameof(sAPSetListSelectionByKeyworkflow), required: true);
            return new DeferredWorkflowAction(() =>
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
        public IBodyWorkflowAction<SAPGetListSelectionElementItemsResponse> SAPGetListSelectionElementItems(Expression<Func<string>> sAPGetListSelectionElementItemssearchSAPElementId, Expression<Func<string>> sAPGetListSelectionElementItemsworkflow)
        {
            var __workflow_sAPGetListSelectionElementItemssearchSAPElementId = sAPGetListSelectionElementItemssearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPGetListSelectionElementItemssearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPGetListSelectionElementItemssearchSAPElementId, nameof(sAPGetListSelectionElementItemssearchSAPElementId), required: true);
            var __workflow_sAPGetListSelectionElementItemsworkflow = sAPGetListSelectionElementItemsworkflow == null ? null : WorkflowExpression.Compile(sAPGetListSelectionElementItemsworkflow);
            WorkflowExpression.Validate(__workflow_sAPGetListSelectionElementItemsworkflow, nameof(sAPGetListSelectionElementItemsworkflow), required: true);
            return new DeferredBodyAction<SAPGetListSelectionElementItemsResponse>(() =>
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
        public IBodyWorkflowAction<SAPGetAllChildSAPElementPropertiesResponse> SAPGetAllChildSAPElementProperties(Expression<Func<string>> sAPGetAllChildSAPElementPropertiessearchSAPElementId, Expression<Func<string>> sAPGetAllChildSAPElementPropertiesworkflow, Expression<Func<int>> sAPGetAllChildSAPElementPropertiesfirstItemToReturn = null, Expression<Func<int>> sAPGetAllChildSAPElementPropertiesmaxItemsToReturn = null, Expression<Func<string>> sAPGetAllChildSAPElementPropertiessearchSAPElementType = null, Expression<Func<int>> sAPGetAllChildSAPElementPropertiesmaxTextLength = null)
        {
            var __workflow_sAPGetAllChildSAPElementPropertiessearchSAPElementId = sAPGetAllChildSAPElementPropertiessearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPGetAllChildSAPElementPropertiessearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPGetAllChildSAPElementPropertiessearchSAPElementId, nameof(sAPGetAllChildSAPElementPropertiessearchSAPElementId), required: true);
            var __workflow_sAPGetAllChildSAPElementPropertiesworkflow = sAPGetAllChildSAPElementPropertiesworkflow == null ? null : WorkflowExpression.Compile(sAPGetAllChildSAPElementPropertiesworkflow);
            WorkflowExpression.Validate(__workflow_sAPGetAllChildSAPElementPropertiesworkflow, nameof(sAPGetAllChildSAPElementPropertiesworkflow), required: true);
            var __workflow_sAPGetAllChildSAPElementPropertiesfirstItemToReturn = sAPGetAllChildSAPElementPropertiesfirstItemToReturn == null ? null : WorkflowExpression.Compile(sAPGetAllChildSAPElementPropertiesfirstItemToReturn);
            WorkflowExpression.Validate(__workflow_sAPGetAllChildSAPElementPropertiesfirstItemToReturn, nameof(sAPGetAllChildSAPElementPropertiesfirstItemToReturn), required: false);
            var __workflow_sAPGetAllChildSAPElementPropertiesmaxItemsToReturn = sAPGetAllChildSAPElementPropertiesmaxItemsToReturn == null ? null : WorkflowExpression.Compile(sAPGetAllChildSAPElementPropertiesmaxItemsToReturn);
            WorkflowExpression.Validate(__workflow_sAPGetAllChildSAPElementPropertiesmaxItemsToReturn, nameof(sAPGetAllChildSAPElementPropertiesmaxItemsToReturn), required: false);
            var __workflow_sAPGetAllChildSAPElementPropertiessearchSAPElementType = sAPGetAllChildSAPElementPropertiessearchSAPElementType == null ? null : WorkflowExpression.Compile(sAPGetAllChildSAPElementPropertiessearchSAPElementType);
            WorkflowExpression.Validate(__workflow_sAPGetAllChildSAPElementPropertiessearchSAPElementType, nameof(sAPGetAllChildSAPElementPropertiessearchSAPElementType), required: false);
            var __workflow_sAPGetAllChildSAPElementPropertiesmaxTextLength = sAPGetAllChildSAPElementPropertiesmaxTextLength == null ? null : WorkflowExpression.Compile(sAPGetAllChildSAPElementPropertiesmaxTextLength);
            WorkflowExpression.Validate(__workflow_sAPGetAllChildSAPElementPropertiesmaxTextLength, nameof(sAPGetAllChildSAPElementPropertiesmaxTextLength), required: false);
            return new DeferredBodyAction<SAPGetAllChildSAPElementPropertiesResponse>(() =>
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
        public IBodyWorkflowAction<SAPGetSAPSessionTopLevelSAPElementPropertiesResponse> SAPGetSAPSessionTopLevelSAPElementProperties(Expression<Func<string>> sAPGetSAPSessionTopLevelSAPElementPropertiesworkflow, Expression<Func<int>> sAPGetSAPSessionTopLevelSAPElementPropertiesfirstItemToReturn = null, Expression<Func<int>> sAPGetSAPSessionTopLevelSAPElementPropertiesmaxItemsToReturn = null, Expression<Func<string>> sAPGetSAPSessionTopLevelSAPElementPropertiessearchSAPElementType = null, Expression<Func<int>> sAPGetSAPSessionTopLevelSAPElementPropertiesmaxTextLength = null)
        {
            var __workflow_sAPGetSAPSessionTopLevelSAPElementPropertiesworkflow = sAPGetSAPSessionTopLevelSAPElementPropertiesworkflow == null ? null : WorkflowExpression.Compile(sAPGetSAPSessionTopLevelSAPElementPropertiesworkflow);
            WorkflowExpression.Validate(__workflow_sAPGetSAPSessionTopLevelSAPElementPropertiesworkflow, nameof(sAPGetSAPSessionTopLevelSAPElementPropertiesworkflow), required: true);
            var __workflow_sAPGetSAPSessionTopLevelSAPElementPropertiesfirstItemToReturn = sAPGetSAPSessionTopLevelSAPElementPropertiesfirstItemToReturn == null ? null : WorkflowExpression.Compile(sAPGetSAPSessionTopLevelSAPElementPropertiesfirstItemToReturn);
            WorkflowExpression.Validate(__workflow_sAPGetSAPSessionTopLevelSAPElementPropertiesfirstItemToReturn, nameof(sAPGetSAPSessionTopLevelSAPElementPropertiesfirstItemToReturn), required: false);
            var __workflow_sAPGetSAPSessionTopLevelSAPElementPropertiesmaxItemsToReturn = sAPGetSAPSessionTopLevelSAPElementPropertiesmaxItemsToReturn == null ? null : WorkflowExpression.Compile(sAPGetSAPSessionTopLevelSAPElementPropertiesmaxItemsToReturn);
            WorkflowExpression.Validate(__workflow_sAPGetSAPSessionTopLevelSAPElementPropertiesmaxItemsToReturn, nameof(sAPGetSAPSessionTopLevelSAPElementPropertiesmaxItemsToReturn), required: false);
            var __workflow_sAPGetSAPSessionTopLevelSAPElementPropertiessearchSAPElementType = sAPGetSAPSessionTopLevelSAPElementPropertiessearchSAPElementType == null ? null : WorkflowExpression.Compile(sAPGetSAPSessionTopLevelSAPElementPropertiessearchSAPElementType);
            WorkflowExpression.Validate(__workflow_sAPGetSAPSessionTopLevelSAPElementPropertiessearchSAPElementType, nameof(sAPGetSAPSessionTopLevelSAPElementPropertiessearchSAPElementType), required: false);
            var __workflow_sAPGetSAPSessionTopLevelSAPElementPropertiesmaxTextLength = sAPGetSAPSessionTopLevelSAPElementPropertiesmaxTextLength == null ? null : WorkflowExpression.Compile(sAPGetSAPSessionTopLevelSAPElementPropertiesmaxTextLength);
            WorkflowExpression.Validate(__workflow_sAPGetSAPSessionTopLevelSAPElementPropertiesmaxTextLength, nameof(sAPGetSAPSessionTopLevelSAPElementPropertiesmaxTextLength), required: false);
            return new DeferredBodyAction<SAPGetSAPSessionTopLevelSAPElementPropertiesResponse>(() =>
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
        public IBodyWorkflowAction<SAPGetSAPElementParentIdResponse> SAPGetSAPElementParentId(Expression<Func<string>> sAPGetSAPElementParentIdsearchSAPElementId, Expression<Func<string>> sAPGetSAPElementParentIdworkflow)
        {
            var __workflow_sAPGetSAPElementParentIdsearchSAPElementId = sAPGetSAPElementParentIdsearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPGetSAPElementParentIdsearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPGetSAPElementParentIdsearchSAPElementId, nameof(sAPGetSAPElementParentIdsearchSAPElementId), required: true);
            var __workflow_sAPGetSAPElementParentIdworkflow = sAPGetSAPElementParentIdworkflow == null ? null : WorkflowExpression.Compile(sAPGetSAPElementParentIdworkflow);
            WorkflowExpression.Validate(__workflow_sAPGetSAPElementParentIdworkflow, nameof(sAPGetSAPElementParentIdworkflow), required: true);
            return new DeferredBodyAction<SAPGetSAPElementParentIdResponse>(() =>
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
        public IBodyWorkflowAction<SAPGetElementPropertiesAsListResponse> SAPGetElementPropertiesAsList(Expression<Func<string>> sAPGetElementPropertiesAsListsearchSAPElementId, Expression<Func<string>> sAPGetElementPropertiesAsListworkflow, Expression<Func<int>> sAPGetElementPropertiesAsListmaxTextLength = null)
        {
            var __workflow_sAPGetElementPropertiesAsListsearchSAPElementId = sAPGetElementPropertiesAsListsearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPGetElementPropertiesAsListsearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPGetElementPropertiesAsListsearchSAPElementId, nameof(sAPGetElementPropertiesAsListsearchSAPElementId), required: true);
            var __workflow_sAPGetElementPropertiesAsListworkflow = sAPGetElementPropertiesAsListworkflow == null ? null : WorkflowExpression.Compile(sAPGetElementPropertiesAsListworkflow);
            WorkflowExpression.Validate(__workflow_sAPGetElementPropertiesAsListworkflow, nameof(sAPGetElementPropertiesAsListworkflow), required: true);
            var __workflow_sAPGetElementPropertiesAsListmaxTextLength = sAPGetElementPropertiesAsListmaxTextLength == null ? null : WorkflowExpression.Compile(sAPGetElementPropertiesAsListmaxTextLength);
            WorkflowExpression.Validate(__workflow_sAPGetElementPropertiesAsListmaxTextLength, nameof(sAPGetElementPropertiesAsListmaxTextLength), required: false);
            return new DeferredBodyAction<SAPGetElementPropertiesAsListResponse>(() =>
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
        public IBodyWorkflowAction<SAPGetSAPElementAtScreenCoordinateResponse> SAPGetSAPElementAtScreenCoordinate(Expression<Func<int>> sAPGetSAPElementAtScreenCoordinatescreenX, Expression<Func<int>> sAPGetSAPElementAtScreenCoordinatescreenY, Expression<Func<string>> sAPGetSAPElementAtScreenCoordinateworkflow)
        {
            var __workflow_sAPGetSAPElementAtScreenCoordinatescreenX = sAPGetSAPElementAtScreenCoordinatescreenX == null ? null : WorkflowExpression.Compile(sAPGetSAPElementAtScreenCoordinatescreenX);
            WorkflowExpression.Validate(__workflow_sAPGetSAPElementAtScreenCoordinatescreenX, nameof(sAPGetSAPElementAtScreenCoordinatescreenX), required: true);
            var __workflow_sAPGetSAPElementAtScreenCoordinatescreenY = sAPGetSAPElementAtScreenCoordinatescreenY == null ? null : WorkflowExpression.Compile(sAPGetSAPElementAtScreenCoordinatescreenY);
            WorkflowExpression.Validate(__workflow_sAPGetSAPElementAtScreenCoordinatescreenY, nameof(sAPGetSAPElementAtScreenCoordinatescreenY), required: true);
            var __workflow_sAPGetSAPElementAtScreenCoordinateworkflow = sAPGetSAPElementAtScreenCoordinateworkflow == null ? null : WorkflowExpression.Compile(sAPGetSAPElementAtScreenCoordinateworkflow);
            WorkflowExpression.Validate(__workflow_sAPGetSAPElementAtScreenCoordinateworkflow, nameof(sAPGetSAPElementAtScreenCoordinateworkflow), required: true);
            return new DeferredBodyAction<SAPGetSAPElementAtScreenCoordinateResponse>(() =>
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
        public IBodyWorkflowAction<SAPOpenConnectionResponse> SAPOpenConnection(Expression<Func<string>> sAPOpenConnectionworkflow, Expression<Func<string>> sAPOpenConnectionsAPConnectionDescription = null, Expression<Func<string>> sAPOpenConnectionsAPConnectionAddress = null, Expression<Func<bool>> sAPOpenConnectionconnectSynchronous = null, Expression<Func<bool>> sAPOpenConnectionconnectToSession = null)
        {
            var __workflow_sAPOpenConnectionworkflow = sAPOpenConnectionworkflow == null ? null : WorkflowExpression.Compile(sAPOpenConnectionworkflow);
            WorkflowExpression.Validate(__workflow_sAPOpenConnectionworkflow, nameof(sAPOpenConnectionworkflow), required: true);
            var __workflow_sAPOpenConnectionsAPConnectionDescription = sAPOpenConnectionsAPConnectionDescription == null ? null : WorkflowExpression.Compile(sAPOpenConnectionsAPConnectionDescription);
            WorkflowExpression.Validate(__workflow_sAPOpenConnectionsAPConnectionDescription, nameof(sAPOpenConnectionsAPConnectionDescription), required: false);
            var __workflow_sAPOpenConnectionsAPConnectionAddress = sAPOpenConnectionsAPConnectionAddress == null ? null : WorkflowExpression.Compile(sAPOpenConnectionsAPConnectionAddress);
            WorkflowExpression.Validate(__workflow_sAPOpenConnectionsAPConnectionAddress, nameof(sAPOpenConnectionsAPConnectionAddress), required: false);
            var __workflow_sAPOpenConnectionconnectSynchronous = sAPOpenConnectionconnectSynchronous == null ? null : WorkflowExpression.Compile(sAPOpenConnectionconnectSynchronous);
            WorkflowExpression.Validate(__workflow_sAPOpenConnectionconnectSynchronous, nameof(sAPOpenConnectionconnectSynchronous), required: false);
            var __workflow_sAPOpenConnectionconnectToSession = sAPOpenConnectionconnectToSession == null ? null : WorkflowExpression.Compile(sAPOpenConnectionconnectToSession);
            WorkflowExpression.Validate(__workflow_sAPOpenConnectionconnectToSession, nameof(sAPOpenConnectionconnectToSession), required: false);
            return new DeferredBodyAction<SAPOpenConnectionResponse>(() =>
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
        public IBodyWorkflowAction<SAPGetSAPTablePropertiesResponse> SAPGetSAPTableProperties(Expression<Func<string>> sAPGetSAPTablePropertiessearchSAPElementId, Expression<Func<string>> sAPGetSAPTablePropertiesworkflow)
        {
            var __workflow_sAPGetSAPTablePropertiessearchSAPElementId = sAPGetSAPTablePropertiessearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPGetSAPTablePropertiessearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPGetSAPTablePropertiessearchSAPElementId, nameof(sAPGetSAPTablePropertiessearchSAPElementId), required: true);
            var __workflow_sAPGetSAPTablePropertiesworkflow = sAPGetSAPTablePropertiesworkflow == null ? null : WorkflowExpression.Compile(sAPGetSAPTablePropertiesworkflow);
            WorkflowExpression.Validate(__workflow_sAPGetSAPTablePropertiesworkflow, nameof(sAPGetSAPTablePropertiesworkflow), required: true);
            return new DeferredBodyAction<SAPGetSAPTablePropertiesResponse>(() =>
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
        public IBodyWorkflowAction<SAPGetSAPTableVisibleCellTextContentsAtIndexResponse> SAPGetSAPTableVisibleCellTextContentsAtIndex(Expression<Func<string>> sAPGetSAPTableVisibleCellTextContentsAtIndexsearchSAPElementId, Expression<Func<string>> sAPGetSAPTableVisibleCellTextContentsAtIndexworkflow, Expression<Func<int>> sAPGetSAPTableVisibleCellTextContentsAtIndexvisibleRowIndex = null, Expression<Func<int>> sAPGetSAPTableVisibleCellTextContentsAtIndexvisibleColumnIndex = null, Expression<Func<string>> sAPGetSAPTableVisibleCellTextContentsAtIndexcheckedElementValue = null)
        {
            var __workflow_sAPGetSAPTableVisibleCellTextContentsAtIndexsearchSAPElementId = sAPGetSAPTableVisibleCellTextContentsAtIndexsearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPGetSAPTableVisibleCellTextContentsAtIndexsearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPGetSAPTableVisibleCellTextContentsAtIndexsearchSAPElementId, nameof(sAPGetSAPTableVisibleCellTextContentsAtIndexsearchSAPElementId), required: true);
            var __workflow_sAPGetSAPTableVisibleCellTextContentsAtIndexworkflow = sAPGetSAPTableVisibleCellTextContentsAtIndexworkflow == null ? null : WorkflowExpression.Compile(sAPGetSAPTableVisibleCellTextContentsAtIndexworkflow);
            WorkflowExpression.Validate(__workflow_sAPGetSAPTableVisibleCellTextContentsAtIndexworkflow, nameof(sAPGetSAPTableVisibleCellTextContentsAtIndexworkflow), required: true);
            var __workflow_sAPGetSAPTableVisibleCellTextContentsAtIndexvisibleRowIndex = sAPGetSAPTableVisibleCellTextContentsAtIndexvisibleRowIndex == null ? null : WorkflowExpression.Compile(sAPGetSAPTableVisibleCellTextContentsAtIndexvisibleRowIndex);
            WorkflowExpression.Validate(__workflow_sAPGetSAPTableVisibleCellTextContentsAtIndexvisibleRowIndex, nameof(sAPGetSAPTableVisibleCellTextContentsAtIndexvisibleRowIndex), required: false);
            var __workflow_sAPGetSAPTableVisibleCellTextContentsAtIndexvisibleColumnIndex = sAPGetSAPTableVisibleCellTextContentsAtIndexvisibleColumnIndex == null ? null : WorkflowExpression.Compile(sAPGetSAPTableVisibleCellTextContentsAtIndexvisibleColumnIndex);
            WorkflowExpression.Validate(__workflow_sAPGetSAPTableVisibleCellTextContentsAtIndexvisibleColumnIndex, nameof(sAPGetSAPTableVisibleCellTextContentsAtIndexvisibleColumnIndex), required: false);
            var __workflow_sAPGetSAPTableVisibleCellTextContentsAtIndexcheckedElementValue = sAPGetSAPTableVisibleCellTextContentsAtIndexcheckedElementValue == null ? null : WorkflowExpression.Compile(sAPGetSAPTableVisibleCellTextContentsAtIndexcheckedElementValue);
            WorkflowExpression.Validate(__workflow_sAPGetSAPTableVisibleCellTextContentsAtIndexcheckedElementValue, nameof(sAPGetSAPTableVisibleCellTextContentsAtIndexcheckedElementValue), required: false);
            return new DeferredBodyAction<SAPGetSAPTableVisibleCellTextContentsAtIndexResponse>(() =>
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
        public IBodyWorkflowAction<SAPGetSAPTableVisibleCellPropertiesAtIndexResponse> SAPGetSAPTableVisibleCellPropertiesAtIndex(Expression<Func<string>> sAPGetSAPTableVisibleCellPropertiesAtIndexsearchSAPElementId, Expression<Func<string>> sAPGetSAPTableVisibleCellPropertiesAtIndexworkflow, Expression<Func<int>> sAPGetSAPTableVisibleCellPropertiesAtIndexvisibleRowIndex = null, Expression<Func<int>> sAPGetSAPTableVisibleCellPropertiesAtIndexvisibleColumnIndex = null)
        {
            var __workflow_sAPGetSAPTableVisibleCellPropertiesAtIndexsearchSAPElementId = sAPGetSAPTableVisibleCellPropertiesAtIndexsearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPGetSAPTableVisibleCellPropertiesAtIndexsearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPGetSAPTableVisibleCellPropertiesAtIndexsearchSAPElementId, nameof(sAPGetSAPTableVisibleCellPropertiesAtIndexsearchSAPElementId), required: true);
            var __workflow_sAPGetSAPTableVisibleCellPropertiesAtIndexworkflow = sAPGetSAPTableVisibleCellPropertiesAtIndexworkflow == null ? null : WorkflowExpression.Compile(sAPGetSAPTableVisibleCellPropertiesAtIndexworkflow);
            WorkflowExpression.Validate(__workflow_sAPGetSAPTableVisibleCellPropertiesAtIndexworkflow, nameof(sAPGetSAPTableVisibleCellPropertiesAtIndexworkflow), required: true);
            var __workflow_sAPGetSAPTableVisibleCellPropertiesAtIndexvisibleRowIndex = sAPGetSAPTableVisibleCellPropertiesAtIndexvisibleRowIndex == null ? null : WorkflowExpression.Compile(sAPGetSAPTableVisibleCellPropertiesAtIndexvisibleRowIndex);
            WorkflowExpression.Validate(__workflow_sAPGetSAPTableVisibleCellPropertiesAtIndexvisibleRowIndex, nameof(sAPGetSAPTableVisibleCellPropertiesAtIndexvisibleRowIndex), required: false);
            var __workflow_sAPGetSAPTableVisibleCellPropertiesAtIndexvisibleColumnIndex = sAPGetSAPTableVisibleCellPropertiesAtIndexvisibleColumnIndex == null ? null : WorkflowExpression.Compile(sAPGetSAPTableVisibleCellPropertiesAtIndexvisibleColumnIndex);
            WorkflowExpression.Validate(__workflow_sAPGetSAPTableVisibleCellPropertiesAtIndexvisibleColumnIndex, nameof(sAPGetSAPTableVisibleCellPropertiesAtIndexvisibleColumnIndex), required: false);
            return new DeferredBodyAction<SAPGetSAPTableVisibleCellPropertiesAtIndexResponse>(() =>
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
        public IWorkflowAction SAPSetSAPTableVisibleCellTextContentsAtIndex(Expression<Func<string>> sAPSetSAPTableVisibleCellTextContentsAtIndexsearchSAPElementId, Expression<Func<string>> sAPSetSAPTableVisibleCellTextContentsAtIndexworkflow, Expression<Func<int>> sAPSetSAPTableVisibleCellTextContentsAtIndexvisibleRowIndex = null, Expression<Func<int>> sAPSetSAPTableVisibleCellTextContentsAtIndexvisibleColumnIndex = null, Expression<Func<string>> sAPSetSAPTableVisibleCellTextContentsAtIndextextToInput = null, Expression<Func<bool>> sAPSetSAPTableVisibleCellTextContentsAtIndexreplaceExistingValue = null, Expression<Func<int>> sAPSetSAPTableVisibleCellTextContentsAtIndexinsertPosition = null)
        {
            var __workflow_sAPSetSAPTableVisibleCellTextContentsAtIndexsearchSAPElementId = sAPSetSAPTableVisibleCellTextContentsAtIndexsearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPSetSAPTableVisibleCellTextContentsAtIndexsearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPSetSAPTableVisibleCellTextContentsAtIndexsearchSAPElementId, nameof(sAPSetSAPTableVisibleCellTextContentsAtIndexsearchSAPElementId), required: true);
            var __workflow_sAPSetSAPTableVisibleCellTextContentsAtIndexworkflow = sAPSetSAPTableVisibleCellTextContentsAtIndexworkflow == null ? null : WorkflowExpression.Compile(sAPSetSAPTableVisibleCellTextContentsAtIndexworkflow);
            WorkflowExpression.Validate(__workflow_sAPSetSAPTableVisibleCellTextContentsAtIndexworkflow, nameof(sAPSetSAPTableVisibleCellTextContentsAtIndexworkflow), required: true);
            var __workflow_sAPSetSAPTableVisibleCellTextContentsAtIndexvisibleRowIndex = sAPSetSAPTableVisibleCellTextContentsAtIndexvisibleRowIndex == null ? null : WorkflowExpression.Compile(sAPSetSAPTableVisibleCellTextContentsAtIndexvisibleRowIndex);
            WorkflowExpression.Validate(__workflow_sAPSetSAPTableVisibleCellTextContentsAtIndexvisibleRowIndex, nameof(sAPSetSAPTableVisibleCellTextContentsAtIndexvisibleRowIndex), required: false);
            var __workflow_sAPSetSAPTableVisibleCellTextContentsAtIndexvisibleColumnIndex = sAPSetSAPTableVisibleCellTextContentsAtIndexvisibleColumnIndex == null ? null : WorkflowExpression.Compile(sAPSetSAPTableVisibleCellTextContentsAtIndexvisibleColumnIndex);
            WorkflowExpression.Validate(__workflow_sAPSetSAPTableVisibleCellTextContentsAtIndexvisibleColumnIndex, nameof(sAPSetSAPTableVisibleCellTextContentsAtIndexvisibleColumnIndex), required: false);
            var __workflow_sAPSetSAPTableVisibleCellTextContentsAtIndextextToInput = sAPSetSAPTableVisibleCellTextContentsAtIndextextToInput == null ? null : WorkflowExpression.Compile(sAPSetSAPTableVisibleCellTextContentsAtIndextextToInput);
            WorkflowExpression.Validate(__workflow_sAPSetSAPTableVisibleCellTextContentsAtIndextextToInput, nameof(sAPSetSAPTableVisibleCellTextContentsAtIndextextToInput), required: false);
            var __workflow_sAPSetSAPTableVisibleCellTextContentsAtIndexreplaceExistingValue = sAPSetSAPTableVisibleCellTextContentsAtIndexreplaceExistingValue == null ? null : WorkflowExpression.Compile(sAPSetSAPTableVisibleCellTextContentsAtIndexreplaceExistingValue);
            WorkflowExpression.Validate(__workflow_sAPSetSAPTableVisibleCellTextContentsAtIndexreplaceExistingValue, nameof(sAPSetSAPTableVisibleCellTextContentsAtIndexreplaceExistingValue), required: false);
            var __workflow_sAPSetSAPTableVisibleCellTextContentsAtIndexinsertPosition = sAPSetSAPTableVisibleCellTextContentsAtIndexinsertPosition == null ? null : WorkflowExpression.Compile(sAPSetSAPTableVisibleCellTextContentsAtIndexinsertPosition);
            WorkflowExpression.Validate(__workflow_sAPSetSAPTableVisibleCellTextContentsAtIndexinsertPosition, nameof(sAPSetSAPTableVisibleCellTextContentsAtIndexinsertPosition), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction SAPCheckSAPTableVisibleCellCheckboxAtIndex(Expression<Func<string>> sAPCheckSAPTableVisibleCellCheckboxAtIndexsearchSAPElementId, Expression<Func<string>> sAPCheckSAPTableVisibleCellCheckboxAtIndexworkflow, Expression<Func<int>> sAPCheckSAPTableVisibleCellCheckboxAtIndexvisibleRowIndex = null, Expression<Func<int>> sAPCheckSAPTableVisibleCellCheckboxAtIndexvisibleColumnIndex = null, Expression<Func<bool>> sAPCheckSAPTableVisibleCellCheckboxAtIndexcheckCellElement = null)
        {
            var __workflow_sAPCheckSAPTableVisibleCellCheckboxAtIndexsearchSAPElementId = sAPCheckSAPTableVisibleCellCheckboxAtIndexsearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPCheckSAPTableVisibleCellCheckboxAtIndexsearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPCheckSAPTableVisibleCellCheckboxAtIndexsearchSAPElementId, nameof(sAPCheckSAPTableVisibleCellCheckboxAtIndexsearchSAPElementId), required: true);
            var __workflow_sAPCheckSAPTableVisibleCellCheckboxAtIndexworkflow = sAPCheckSAPTableVisibleCellCheckboxAtIndexworkflow == null ? null : WorkflowExpression.Compile(sAPCheckSAPTableVisibleCellCheckboxAtIndexworkflow);
            WorkflowExpression.Validate(__workflow_sAPCheckSAPTableVisibleCellCheckboxAtIndexworkflow, nameof(sAPCheckSAPTableVisibleCellCheckboxAtIndexworkflow), required: true);
            var __workflow_sAPCheckSAPTableVisibleCellCheckboxAtIndexvisibleRowIndex = sAPCheckSAPTableVisibleCellCheckboxAtIndexvisibleRowIndex == null ? null : WorkflowExpression.Compile(sAPCheckSAPTableVisibleCellCheckboxAtIndexvisibleRowIndex);
            WorkflowExpression.Validate(__workflow_sAPCheckSAPTableVisibleCellCheckboxAtIndexvisibleRowIndex, nameof(sAPCheckSAPTableVisibleCellCheckboxAtIndexvisibleRowIndex), required: false);
            var __workflow_sAPCheckSAPTableVisibleCellCheckboxAtIndexvisibleColumnIndex = sAPCheckSAPTableVisibleCellCheckboxAtIndexvisibleColumnIndex == null ? null : WorkflowExpression.Compile(sAPCheckSAPTableVisibleCellCheckboxAtIndexvisibleColumnIndex);
            WorkflowExpression.Validate(__workflow_sAPCheckSAPTableVisibleCellCheckboxAtIndexvisibleColumnIndex, nameof(sAPCheckSAPTableVisibleCellCheckboxAtIndexvisibleColumnIndex), required: false);
            var __workflow_sAPCheckSAPTableVisibleCellCheckboxAtIndexcheckCellElement = sAPCheckSAPTableVisibleCellCheckboxAtIndexcheckCellElement == null ? null : WorkflowExpression.Compile(sAPCheckSAPTableVisibleCellCheckboxAtIndexcheckCellElement);
            WorkflowExpression.Validate(__workflow_sAPCheckSAPTableVisibleCellCheckboxAtIndexcheckCellElement, nameof(sAPCheckSAPTableVisibleCellCheckboxAtIndexcheckCellElement), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction SAPPressSAPTableVisibleCellAtIndex(Expression<Func<string>> sAPPressSAPTableVisibleCellAtIndexsearchSAPElementId, Expression<Func<string>> sAPPressSAPTableVisibleCellAtIndexworkflow, Expression<Func<int>> sAPPressSAPTableVisibleCellAtIndexvisibleRowIndex = null, Expression<Func<int>> sAPPressSAPTableVisibleCellAtIndexvisibleColumnIndex = null)
        {
            var __workflow_sAPPressSAPTableVisibleCellAtIndexsearchSAPElementId = sAPPressSAPTableVisibleCellAtIndexsearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPPressSAPTableVisibleCellAtIndexsearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPPressSAPTableVisibleCellAtIndexsearchSAPElementId, nameof(sAPPressSAPTableVisibleCellAtIndexsearchSAPElementId), required: true);
            var __workflow_sAPPressSAPTableVisibleCellAtIndexworkflow = sAPPressSAPTableVisibleCellAtIndexworkflow == null ? null : WorkflowExpression.Compile(sAPPressSAPTableVisibleCellAtIndexworkflow);
            WorkflowExpression.Validate(__workflow_sAPPressSAPTableVisibleCellAtIndexworkflow, nameof(sAPPressSAPTableVisibleCellAtIndexworkflow), required: true);
            var __workflow_sAPPressSAPTableVisibleCellAtIndexvisibleRowIndex = sAPPressSAPTableVisibleCellAtIndexvisibleRowIndex == null ? null : WorkflowExpression.Compile(sAPPressSAPTableVisibleCellAtIndexvisibleRowIndex);
            WorkflowExpression.Validate(__workflow_sAPPressSAPTableVisibleCellAtIndexvisibleRowIndex, nameof(sAPPressSAPTableVisibleCellAtIndexvisibleRowIndex), required: false);
            var __workflow_sAPPressSAPTableVisibleCellAtIndexvisibleColumnIndex = sAPPressSAPTableVisibleCellAtIndexvisibleColumnIndex == null ? null : WorkflowExpression.Compile(sAPPressSAPTableVisibleCellAtIndexvisibleColumnIndex);
            WorkflowExpression.Validate(__workflow_sAPPressSAPTableVisibleCellAtIndexvisibleColumnIndex, nameof(sAPPressSAPTableVisibleCellAtIndexvisibleColumnIndex), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction SAPScrollSAPTable(Expression<Func<string>> sAPScrollSAPTablesearchSAPElementId, Expression<Func<string>> sAPScrollSAPTableworkflow, Expression<Func<bool>> sAPScrollSAPTablemoveHorizontalScrollbar = null, Expression<Func<int>> sAPScrollSAPTablehorizontalScrollbarPosition = null, Expression<Func<bool>> sAPScrollSAPTablemoveVerticalScrollbar = null, Expression<Func<int>> sAPScrollSAPTableverticalScrollbarPosition = null)
        {
            var __workflow_sAPScrollSAPTablesearchSAPElementId = sAPScrollSAPTablesearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPScrollSAPTablesearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPScrollSAPTablesearchSAPElementId, nameof(sAPScrollSAPTablesearchSAPElementId), required: true);
            var __workflow_sAPScrollSAPTableworkflow = sAPScrollSAPTableworkflow == null ? null : WorkflowExpression.Compile(sAPScrollSAPTableworkflow);
            WorkflowExpression.Validate(__workflow_sAPScrollSAPTableworkflow, nameof(sAPScrollSAPTableworkflow), required: true);
            var __workflow_sAPScrollSAPTablemoveHorizontalScrollbar = sAPScrollSAPTablemoveHorizontalScrollbar == null ? null : WorkflowExpression.Compile(sAPScrollSAPTablemoveHorizontalScrollbar);
            WorkflowExpression.Validate(__workflow_sAPScrollSAPTablemoveHorizontalScrollbar, nameof(sAPScrollSAPTablemoveHorizontalScrollbar), required: false);
            var __workflow_sAPScrollSAPTablehorizontalScrollbarPosition = sAPScrollSAPTablehorizontalScrollbarPosition == null ? null : WorkflowExpression.Compile(sAPScrollSAPTablehorizontalScrollbarPosition);
            WorkflowExpression.Validate(__workflow_sAPScrollSAPTablehorizontalScrollbarPosition, nameof(sAPScrollSAPTablehorizontalScrollbarPosition), required: false);
            var __workflow_sAPScrollSAPTablemoveVerticalScrollbar = sAPScrollSAPTablemoveVerticalScrollbar == null ? null : WorkflowExpression.Compile(sAPScrollSAPTablemoveVerticalScrollbar);
            WorkflowExpression.Validate(__workflow_sAPScrollSAPTablemoveVerticalScrollbar, nameof(sAPScrollSAPTablemoveVerticalScrollbar), required: false);
            var __workflow_sAPScrollSAPTableverticalScrollbarPosition = sAPScrollSAPTableverticalScrollbarPosition == null ? null : WorkflowExpression.Compile(sAPScrollSAPTableverticalScrollbarPosition);
            WorkflowExpression.Validate(__workflow_sAPScrollSAPTableverticalScrollbarPosition, nameof(sAPScrollSAPTableverticalScrollbarPosition), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IBodyWorkflowAction<SAPGetTableVisibleTextContentsResponse> SAPGetTableVisibleTextContents(Expression<Func<string>> sAPGetTableVisibleTextContentssearchSAPElementId, Expression<Func<string>> sAPGetTableVisibleTextContentsworkflow, Expression<Func<int>> sAPGetTableVisibleTextContentsfirstVisibleRowToReturn = null, Expression<Func<int>> sAPGetTableVisibleTextContentsmaxRowsToReturn = null, Expression<Func<int>> sAPGetTableVisibleTextContentsfirstVisibleColumnToReturn = null, Expression<Func<int>> sAPGetTableVisibleTextContentsmaxColumnsToReturn = null, Expression<Func<bool>> sAPGetTableVisibleTextContentsuseColumnHeadersFromTable = null, Expression<Func<bool>> sAPGetTableVisibleTextContentsreturnRowIndexInOutputCollection = null, Expression<Func<string>> sAPGetTableVisibleTextContentsnameOfColumnToStoreRowIndex = null, Expression<Func<string>> sAPGetTableVisibleTextContentscheckedElementValue = null)
        {
            var __workflow_sAPGetTableVisibleTextContentssearchSAPElementId = sAPGetTableVisibleTextContentssearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPGetTableVisibleTextContentssearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPGetTableVisibleTextContentssearchSAPElementId, nameof(sAPGetTableVisibleTextContentssearchSAPElementId), required: true);
            var __workflow_sAPGetTableVisibleTextContentsworkflow = sAPGetTableVisibleTextContentsworkflow == null ? null : WorkflowExpression.Compile(sAPGetTableVisibleTextContentsworkflow);
            WorkflowExpression.Validate(__workflow_sAPGetTableVisibleTextContentsworkflow, nameof(sAPGetTableVisibleTextContentsworkflow), required: true);
            var __workflow_sAPGetTableVisibleTextContentsfirstVisibleRowToReturn = sAPGetTableVisibleTextContentsfirstVisibleRowToReturn == null ? null : WorkflowExpression.Compile(sAPGetTableVisibleTextContentsfirstVisibleRowToReturn);
            WorkflowExpression.Validate(__workflow_sAPGetTableVisibleTextContentsfirstVisibleRowToReturn, nameof(sAPGetTableVisibleTextContentsfirstVisibleRowToReturn), required: false);
            var __workflow_sAPGetTableVisibleTextContentsmaxRowsToReturn = sAPGetTableVisibleTextContentsmaxRowsToReturn == null ? null : WorkflowExpression.Compile(sAPGetTableVisibleTextContentsmaxRowsToReturn);
            WorkflowExpression.Validate(__workflow_sAPGetTableVisibleTextContentsmaxRowsToReturn, nameof(sAPGetTableVisibleTextContentsmaxRowsToReturn), required: false);
            var __workflow_sAPGetTableVisibleTextContentsfirstVisibleColumnToReturn = sAPGetTableVisibleTextContentsfirstVisibleColumnToReturn == null ? null : WorkflowExpression.Compile(sAPGetTableVisibleTextContentsfirstVisibleColumnToReturn);
            WorkflowExpression.Validate(__workflow_sAPGetTableVisibleTextContentsfirstVisibleColumnToReturn, nameof(sAPGetTableVisibleTextContentsfirstVisibleColumnToReturn), required: false);
            var __workflow_sAPGetTableVisibleTextContentsmaxColumnsToReturn = sAPGetTableVisibleTextContentsmaxColumnsToReturn == null ? null : WorkflowExpression.Compile(sAPGetTableVisibleTextContentsmaxColumnsToReturn);
            WorkflowExpression.Validate(__workflow_sAPGetTableVisibleTextContentsmaxColumnsToReturn, nameof(sAPGetTableVisibleTextContentsmaxColumnsToReturn), required: false);
            var __workflow_sAPGetTableVisibleTextContentsuseColumnHeadersFromTable = sAPGetTableVisibleTextContentsuseColumnHeadersFromTable == null ? null : WorkflowExpression.Compile(sAPGetTableVisibleTextContentsuseColumnHeadersFromTable);
            WorkflowExpression.Validate(__workflow_sAPGetTableVisibleTextContentsuseColumnHeadersFromTable, nameof(sAPGetTableVisibleTextContentsuseColumnHeadersFromTable), required: false);
            var __workflow_sAPGetTableVisibleTextContentsreturnRowIndexInOutputCollection = sAPGetTableVisibleTextContentsreturnRowIndexInOutputCollection == null ? null : WorkflowExpression.Compile(sAPGetTableVisibleTextContentsreturnRowIndexInOutputCollection);
            WorkflowExpression.Validate(__workflow_sAPGetTableVisibleTextContentsreturnRowIndexInOutputCollection, nameof(sAPGetTableVisibleTextContentsreturnRowIndexInOutputCollection), required: false);
            var __workflow_sAPGetTableVisibleTextContentsnameOfColumnToStoreRowIndex = sAPGetTableVisibleTextContentsnameOfColumnToStoreRowIndex == null ? null : WorkflowExpression.Compile(sAPGetTableVisibleTextContentsnameOfColumnToStoreRowIndex);
            WorkflowExpression.Validate(__workflow_sAPGetTableVisibleTextContentsnameOfColumnToStoreRowIndex, nameof(sAPGetTableVisibleTextContentsnameOfColumnToStoreRowIndex), required: false);
            var __workflow_sAPGetTableVisibleTextContentscheckedElementValue = sAPGetTableVisibleTextContentscheckedElementValue == null ? null : WorkflowExpression.Compile(sAPGetTableVisibleTextContentscheckedElementValue);
            WorkflowExpression.Validate(__workflow_sAPGetTableVisibleTextContentscheckedElementValue, nameof(sAPGetTableVisibleTextContentscheckedElementValue), required: false);
            return new DeferredBodyAction<SAPGetTableVisibleTextContentsResponse>(() =>
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
        public IWorkflowAction SAPSelectSAPTableRow(Expression<Func<string>> sAPSelectSAPTableRowsearchSAPElementId, Expression<Func<string>> sAPSelectSAPTableRowworkflow, Expression<Func<int>> sAPSelectSAPTableRowvisibleRowIndex = null, Expression<Func<bool>> sAPSelectSAPTableRowselect = null)
        {
            var __workflow_sAPSelectSAPTableRowsearchSAPElementId = sAPSelectSAPTableRowsearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPSelectSAPTableRowsearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPSelectSAPTableRowsearchSAPElementId, nameof(sAPSelectSAPTableRowsearchSAPElementId), required: true);
            var __workflow_sAPSelectSAPTableRowworkflow = sAPSelectSAPTableRowworkflow == null ? null : WorkflowExpression.Compile(sAPSelectSAPTableRowworkflow);
            WorkflowExpression.Validate(__workflow_sAPSelectSAPTableRowworkflow, nameof(sAPSelectSAPTableRowworkflow), required: true);
            var __workflow_sAPSelectSAPTableRowvisibleRowIndex = sAPSelectSAPTableRowvisibleRowIndex == null ? null : WorkflowExpression.Compile(sAPSelectSAPTableRowvisibleRowIndex);
            WorkflowExpression.Validate(__workflow_sAPSelectSAPTableRowvisibleRowIndex, nameof(sAPSelectSAPTableRowvisibleRowIndex), required: false);
            var __workflow_sAPSelectSAPTableRowselect = sAPSelectSAPTableRowselect == null ? null : WorkflowExpression.Compile(sAPSelectSAPTableRowselect);
            WorkflowExpression.Validate(__workflow_sAPSelectSAPTableRowselect, nameof(sAPSelectSAPTableRowselect), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction SAPSelectSAPTableColumn(Expression<Func<string>> sAPSelectSAPTableColumnsearchSAPElementId, Expression<Func<string>> sAPSelectSAPTableColumnworkflow, Expression<Func<int>> sAPSelectSAPTableColumnvisibleColumnIndex = null, Expression<Func<bool>> sAPSelectSAPTableColumnselect = null)
        {
            var __workflow_sAPSelectSAPTableColumnsearchSAPElementId = sAPSelectSAPTableColumnsearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPSelectSAPTableColumnsearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPSelectSAPTableColumnsearchSAPElementId, nameof(sAPSelectSAPTableColumnsearchSAPElementId), required: true);
            var __workflow_sAPSelectSAPTableColumnworkflow = sAPSelectSAPTableColumnworkflow == null ? null : WorkflowExpression.Compile(sAPSelectSAPTableColumnworkflow);
            WorkflowExpression.Validate(__workflow_sAPSelectSAPTableColumnworkflow, nameof(sAPSelectSAPTableColumnworkflow), required: true);
            var __workflow_sAPSelectSAPTableColumnvisibleColumnIndex = sAPSelectSAPTableColumnvisibleColumnIndex == null ? null : WorkflowExpression.Compile(sAPSelectSAPTableColumnvisibleColumnIndex);
            WorkflowExpression.Validate(__workflow_sAPSelectSAPTableColumnvisibleColumnIndex, nameof(sAPSelectSAPTableColumnvisibleColumnIndex), required: false);
            var __workflow_sAPSelectSAPTableColumnselect = sAPSelectSAPTableColumnselect == null ? null : WorkflowExpression.Compile(sAPSelectSAPTableColumnselect);
            WorkflowExpression.Validate(__workflow_sAPSelectSAPTableColumnselect, nameof(sAPSelectSAPTableColumnselect), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IBodyWorkflowAction<SAPGetTreeNodesResponse> SAPGetTreeNodes(Expression<Func<string>> sAPGetTreeNodessearchSAPElementId, Expression<Func<string>> sAPGetTreeNodesworkflow, Expression<Func<string>> sAPGetTreeNodesparentNodeKey = null, Expression<Func<bool>> sAPGetTreeNodesprocessSubNodes = null)
        {
            var __workflow_sAPGetTreeNodessearchSAPElementId = sAPGetTreeNodessearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPGetTreeNodessearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPGetTreeNodessearchSAPElementId, nameof(sAPGetTreeNodessearchSAPElementId), required: true);
            var __workflow_sAPGetTreeNodesworkflow = sAPGetTreeNodesworkflow == null ? null : WorkflowExpression.Compile(sAPGetTreeNodesworkflow);
            WorkflowExpression.Validate(__workflow_sAPGetTreeNodesworkflow, nameof(sAPGetTreeNodesworkflow), required: true);
            var __workflow_sAPGetTreeNodesparentNodeKey = sAPGetTreeNodesparentNodeKey == null ? null : WorkflowExpression.Compile(sAPGetTreeNodesparentNodeKey);
            WorkflowExpression.Validate(__workflow_sAPGetTreeNodesparentNodeKey, nameof(sAPGetTreeNodesparentNodeKey), required: false);
            var __workflow_sAPGetTreeNodesprocessSubNodes = sAPGetTreeNodesprocessSubNodes == null ? null : WorkflowExpression.Compile(sAPGetTreeNodesprocessSubNodes);
            WorkflowExpression.Validate(__workflow_sAPGetTreeNodesprocessSubNodes, nameof(sAPGetTreeNodesprocessSubNodes), required: false);
            return new DeferredBodyAction<SAPGetTreeNodesResponse>(() =>
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
        public IWorkflowAction SAPDoubleClickTreeItem(Expression<Func<string>> sAPDoubleClickTreeItemsearchSAPElementId, Expression<Func<string>> sAPDoubleClickTreeItemworkflow, Expression<Func<string>> sAPDoubleClickTreeItemsearchNodeKey = null, Expression<Func<string>> sAPDoubleClickTreeItemsearchNodePath = null, Expression<Func<string>> sAPDoubleClickTreeItemsearchNodeText = null, Expression<Func<bool>> sAPDoubleClickTreeItemsearchNodeTextIsRegularExpression = null, Expression<Func<bool>> sAPDoubleClickTreeItemsearchNodeTextIsCaseSensitive = null, Expression<Func<string>> sAPDoubleClickTreeItemsearchColumnName = null, Expression<Func<string>> sAPDoubleClickTreeItemsearchColumnTitle = null, Expression<Func<bool>> sAPDoubleClickTreeItemsearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPDoubleClickTreeItemsearchColumnTitleIsCaseSensitive = null)
        {
            var __workflow_sAPDoubleClickTreeItemsearchSAPElementId = sAPDoubleClickTreeItemsearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPDoubleClickTreeItemsearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPDoubleClickTreeItemsearchSAPElementId, nameof(sAPDoubleClickTreeItemsearchSAPElementId), required: true);
            var __workflow_sAPDoubleClickTreeItemworkflow = sAPDoubleClickTreeItemworkflow == null ? null : WorkflowExpression.Compile(sAPDoubleClickTreeItemworkflow);
            WorkflowExpression.Validate(__workflow_sAPDoubleClickTreeItemworkflow, nameof(sAPDoubleClickTreeItemworkflow), required: true);
            var __workflow_sAPDoubleClickTreeItemsearchNodeKey = sAPDoubleClickTreeItemsearchNodeKey == null ? null : WorkflowExpression.Compile(sAPDoubleClickTreeItemsearchNodeKey);
            WorkflowExpression.Validate(__workflow_sAPDoubleClickTreeItemsearchNodeKey, nameof(sAPDoubleClickTreeItemsearchNodeKey), required: false);
            var __workflow_sAPDoubleClickTreeItemsearchNodePath = sAPDoubleClickTreeItemsearchNodePath == null ? null : WorkflowExpression.Compile(sAPDoubleClickTreeItemsearchNodePath);
            WorkflowExpression.Validate(__workflow_sAPDoubleClickTreeItemsearchNodePath, nameof(sAPDoubleClickTreeItemsearchNodePath), required: false);
            var __workflow_sAPDoubleClickTreeItemsearchNodeText = sAPDoubleClickTreeItemsearchNodeText == null ? null : WorkflowExpression.Compile(sAPDoubleClickTreeItemsearchNodeText);
            WorkflowExpression.Validate(__workflow_sAPDoubleClickTreeItemsearchNodeText, nameof(sAPDoubleClickTreeItemsearchNodeText), required: false);
            var __workflow_sAPDoubleClickTreeItemsearchNodeTextIsRegularExpression = sAPDoubleClickTreeItemsearchNodeTextIsRegularExpression == null ? null : WorkflowExpression.Compile(sAPDoubleClickTreeItemsearchNodeTextIsRegularExpression);
            WorkflowExpression.Validate(__workflow_sAPDoubleClickTreeItemsearchNodeTextIsRegularExpression, nameof(sAPDoubleClickTreeItemsearchNodeTextIsRegularExpression), required: false);
            var __workflow_sAPDoubleClickTreeItemsearchNodeTextIsCaseSensitive = sAPDoubleClickTreeItemsearchNodeTextIsCaseSensitive == null ? null : WorkflowExpression.Compile(sAPDoubleClickTreeItemsearchNodeTextIsCaseSensitive);
            WorkflowExpression.Validate(__workflow_sAPDoubleClickTreeItemsearchNodeTextIsCaseSensitive, nameof(sAPDoubleClickTreeItemsearchNodeTextIsCaseSensitive), required: false);
            var __workflow_sAPDoubleClickTreeItemsearchColumnName = sAPDoubleClickTreeItemsearchColumnName == null ? null : WorkflowExpression.Compile(sAPDoubleClickTreeItemsearchColumnName);
            WorkflowExpression.Validate(__workflow_sAPDoubleClickTreeItemsearchColumnName, nameof(sAPDoubleClickTreeItemsearchColumnName), required: false);
            var __workflow_sAPDoubleClickTreeItemsearchColumnTitle = sAPDoubleClickTreeItemsearchColumnTitle == null ? null : WorkflowExpression.Compile(sAPDoubleClickTreeItemsearchColumnTitle);
            WorkflowExpression.Validate(__workflow_sAPDoubleClickTreeItemsearchColumnTitle, nameof(sAPDoubleClickTreeItemsearchColumnTitle), required: false);
            var __workflow_sAPDoubleClickTreeItemsearchColumnTitleIsRegularExpression = sAPDoubleClickTreeItemsearchColumnTitleIsRegularExpression == null ? null : WorkflowExpression.Compile(sAPDoubleClickTreeItemsearchColumnTitleIsRegularExpression);
            WorkflowExpression.Validate(__workflow_sAPDoubleClickTreeItemsearchColumnTitleIsRegularExpression, nameof(sAPDoubleClickTreeItemsearchColumnTitleIsRegularExpression), required: false);
            var __workflow_sAPDoubleClickTreeItemsearchColumnTitleIsCaseSensitive = sAPDoubleClickTreeItemsearchColumnTitleIsCaseSensitive == null ? null : WorkflowExpression.Compile(sAPDoubleClickTreeItemsearchColumnTitleIsCaseSensitive);
            WorkflowExpression.Validate(__workflow_sAPDoubleClickTreeItemsearchColumnTitleIsCaseSensitive, nameof(sAPDoubleClickTreeItemsearchColumnTitleIsCaseSensitive), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction SAPSelectTreeItem(Expression<Func<string>> sAPSelectTreeItemsearchSAPElementId, Expression<Func<string>> sAPSelectTreeItemworkflow, Expression<Func<string>> sAPSelectTreeItemsearchNodeKey = null, Expression<Func<string>> sAPSelectTreeItemsearchNodePath = null, Expression<Func<string>> sAPSelectTreeItemsearchNodeText = null, Expression<Func<bool>> sAPSelectTreeItemsearchNodeTextIsRegularExpression = null, Expression<Func<bool>> sAPSelectTreeItemsearchNodeTextIsCaseSensitive = null, Expression<Func<string>> sAPSelectTreeItemsearchColumnName = null, Expression<Func<string>> sAPSelectTreeItemsearchColumnTitle = null, Expression<Func<bool>> sAPSelectTreeItemsearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPSelectTreeItemsearchColumnTitleIsCaseSensitive = null, Expression<Func<bool>> sAPSelectTreeItemselect = null, Expression<Func<bool>> sAPSelectTreeItemdeselectAllFirst = null)
        {
            var __workflow_sAPSelectTreeItemsearchSAPElementId = sAPSelectTreeItemsearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPSelectTreeItemsearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPSelectTreeItemsearchSAPElementId, nameof(sAPSelectTreeItemsearchSAPElementId), required: true);
            var __workflow_sAPSelectTreeItemworkflow = sAPSelectTreeItemworkflow == null ? null : WorkflowExpression.Compile(sAPSelectTreeItemworkflow);
            WorkflowExpression.Validate(__workflow_sAPSelectTreeItemworkflow, nameof(sAPSelectTreeItemworkflow), required: true);
            var __workflow_sAPSelectTreeItemsearchNodeKey = sAPSelectTreeItemsearchNodeKey == null ? null : WorkflowExpression.Compile(sAPSelectTreeItemsearchNodeKey);
            WorkflowExpression.Validate(__workflow_sAPSelectTreeItemsearchNodeKey, nameof(sAPSelectTreeItemsearchNodeKey), required: false);
            var __workflow_sAPSelectTreeItemsearchNodePath = sAPSelectTreeItemsearchNodePath == null ? null : WorkflowExpression.Compile(sAPSelectTreeItemsearchNodePath);
            WorkflowExpression.Validate(__workflow_sAPSelectTreeItemsearchNodePath, nameof(sAPSelectTreeItemsearchNodePath), required: false);
            var __workflow_sAPSelectTreeItemsearchNodeText = sAPSelectTreeItemsearchNodeText == null ? null : WorkflowExpression.Compile(sAPSelectTreeItemsearchNodeText);
            WorkflowExpression.Validate(__workflow_sAPSelectTreeItemsearchNodeText, nameof(sAPSelectTreeItemsearchNodeText), required: false);
            var __workflow_sAPSelectTreeItemsearchNodeTextIsRegularExpression = sAPSelectTreeItemsearchNodeTextIsRegularExpression == null ? null : WorkflowExpression.Compile(sAPSelectTreeItemsearchNodeTextIsRegularExpression);
            WorkflowExpression.Validate(__workflow_sAPSelectTreeItemsearchNodeTextIsRegularExpression, nameof(sAPSelectTreeItemsearchNodeTextIsRegularExpression), required: false);
            var __workflow_sAPSelectTreeItemsearchNodeTextIsCaseSensitive = sAPSelectTreeItemsearchNodeTextIsCaseSensitive == null ? null : WorkflowExpression.Compile(sAPSelectTreeItemsearchNodeTextIsCaseSensitive);
            WorkflowExpression.Validate(__workflow_sAPSelectTreeItemsearchNodeTextIsCaseSensitive, nameof(sAPSelectTreeItemsearchNodeTextIsCaseSensitive), required: false);
            var __workflow_sAPSelectTreeItemsearchColumnName = sAPSelectTreeItemsearchColumnName == null ? null : WorkflowExpression.Compile(sAPSelectTreeItemsearchColumnName);
            WorkflowExpression.Validate(__workflow_sAPSelectTreeItemsearchColumnName, nameof(sAPSelectTreeItemsearchColumnName), required: false);
            var __workflow_sAPSelectTreeItemsearchColumnTitle = sAPSelectTreeItemsearchColumnTitle == null ? null : WorkflowExpression.Compile(sAPSelectTreeItemsearchColumnTitle);
            WorkflowExpression.Validate(__workflow_sAPSelectTreeItemsearchColumnTitle, nameof(sAPSelectTreeItemsearchColumnTitle), required: false);
            var __workflow_sAPSelectTreeItemsearchColumnTitleIsRegularExpression = sAPSelectTreeItemsearchColumnTitleIsRegularExpression == null ? null : WorkflowExpression.Compile(sAPSelectTreeItemsearchColumnTitleIsRegularExpression);
            WorkflowExpression.Validate(__workflow_sAPSelectTreeItemsearchColumnTitleIsRegularExpression, nameof(sAPSelectTreeItemsearchColumnTitleIsRegularExpression), required: false);
            var __workflow_sAPSelectTreeItemsearchColumnTitleIsCaseSensitive = sAPSelectTreeItemsearchColumnTitleIsCaseSensitive == null ? null : WorkflowExpression.Compile(sAPSelectTreeItemsearchColumnTitleIsCaseSensitive);
            WorkflowExpression.Validate(__workflow_sAPSelectTreeItemsearchColumnTitleIsCaseSensitive, nameof(sAPSelectTreeItemsearchColumnTitleIsCaseSensitive), required: false);
            var __workflow_sAPSelectTreeItemselect = sAPSelectTreeItemselect == null ? null : WorkflowExpression.Compile(sAPSelectTreeItemselect);
            WorkflowExpression.Validate(__workflow_sAPSelectTreeItemselect, nameof(sAPSelectTreeItemselect), required: false);
            var __workflow_sAPSelectTreeItemdeselectAllFirst = sAPSelectTreeItemdeselectAllFirst == null ? null : WorkflowExpression.Compile(sAPSelectTreeItemdeselectAllFirst);
            WorkflowExpression.Validate(__workflow_sAPSelectTreeItemdeselectAllFirst, nameof(sAPSelectTreeItemdeselectAllFirst), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction SAPExpandTreeNode(Expression<Func<string>> sAPExpandTreeNodesearchSAPElementId, Expression<Func<string>> sAPExpandTreeNodeworkflow, Expression<Func<string>> sAPExpandTreeNodesearchNodeKey = null, Expression<Func<string>> sAPExpandTreeNodesearchNodePath = null, Expression<Func<string>> sAPExpandTreeNodesearchNodeText = null, Expression<Func<bool>> sAPExpandTreeNodesearchNodeTextIsRegularExpression = null, Expression<Func<bool>> sAPExpandTreeNodesearchNodeTextIsCaseSensitive = null, Expression<Func<bool>> sAPExpandTreeNodeexpand = null)
        {
            var __workflow_sAPExpandTreeNodesearchSAPElementId = sAPExpandTreeNodesearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPExpandTreeNodesearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPExpandTreeNodesearchSAPElementId, nameof(sAPExpandTreeNodesearchSAPElementId), required: true);
            var __workflow_sAPExpandTreeNodeworkflow = sAPExpandTreeNodeworkflow == null ? null : WorkflowExpression.Compile(sAPExpandTreeNodeworkflow);
            WorkflowExpression.Validate(__workflow_sAPExpandTreeNodeworkflow, nameof(sAPExpandTreeNodeworkflow), required: true);
            var __workflow_sAPExpandTreeNodesearchNodeKey = sAPExpandTreeNodesearchNodeKey == null ? null : WorkflowExpression.Compile(sAPExpandTreeNodesearchNodeKey);
            WorkflowExpression.Validate(__workflow_sAPExpandTreeNodesearchNodeKey, nameof(sAPExpandTreeNodesearchNodeKey), required: false);
            var __workflow_sAPExpandTreeNodesearchNodePath = sAPExpandTreeNodesearchNodePath == null ? null : WorkflowExpression.Compile(sAPExpandTreeNodesearchNodePath);
            WorkflowExpression.Validate(__workflow_sAPExpandTreeNodesearchNodePath, nameof(sAPExpandTreeNodesearchNodePath), required: false);
            var __workflow_sAPExpandTreeNodesearchNodeText = sAPExpandTreeNodesearchNodeText == null ? null : WorkflowExpression.Compile(sAPExpandTreeNodesearchNodeText);
            WorkflowExpression.Validate(__workflow_sAPExpandTreeNodesearchNodeText, nameof(sAPExpandTreeNodesearchNodeText), required: false);
            var __workflow_sAPExpandTreeNodesearchNodeTextIsRegularExpression = sAPExpandTreeNodesearchNodeTextIsRegularExpression == null ? null : WorkflowExpression.Compile(sAPExpandTreeNodesearchNodeTextIsRegularExpression);
            WorkflowExpression.Validate(__workflow_sAPExpandTreeNodesearchNodeTextIsRegularExpression, nameof(sAPExpandTreeNodesearchNodeTextIsRegularExpression), required: false);
            var __workflow_sAPExpandTreeNodesearchNodeTextIsCaseSensitive = sAPExpandTreeNodesearchNodeTextIsCaseSensitive == null ? null : WorkflowExpression.Compile(sAPExpandTreeNodesearchNodeTextIsCaseSensitive);
            WorkflowExpression.Validate(__workflow_sAPExpandTreeNodesearchNodeTextIsCaseSensitive, nameof(sAPExpandTreeNodesearchNodeTextIsCaseSensitive), required: false);
            var __workflow_sAPExpandTreeNodeexpand = sAPExpandTreeNodeexpand == null ? null : WorkflowExpression.Compile(sAPExpandTreeNodeexpand);
            WorkflowExpression.Validate(__workflow_sAPExpandTreeNodeexpand, nameof(sAPExpandTreeNodeexpand), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction SAPDeselectAllTreeNodes(Expression<Func<string>> sAPDeselectAllTreeNodessearchSAPElementId, Expression<Func<string>> sAPDeselectAllTreeNodesworkflow)
        {
            var __workflow_sAPDeselectAllTreeNodessearchSAPElementId = sAPDeselectAllTreeNodessearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPDeselectAllTreeNodessearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPDeselectAllTreeNodessearchSAPElementId, nameof(sAPDeselectAllTreeNodessearchSAPElementId), required: true);
            var __workflow_sAPDeselectAllTreeNodesworkflow = sAPDeselectAllTreeNodesworkflow == null ? null : WorkflowExpression.Compile(sAPDeselectAllTreeNodesworkflow);
            WorkflowExpression.Validate(__workflow_sAPDeselectAllTreeNodesworkflow, nameof(sAPDeselectAllTreeNodesworkflow), required: true);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction SAPPressKeyOnTree(Expression<Func<string>> sAPPressKeyOnTreesearchSAPElementId, Expression<Func<string>> sAPPressKeyOnTreekey, Expression<Func<string>> sAPPressKeyOnTreeworkflow)
        {
            var __workflow_sAPPressKeyOnTreesearchSAPElementId = sAPPressKeyOnTreesearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPPressKeyOnTreesearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPPressKeyOnTreesearchSAPElementId, nameof(sAPPressKeyOnTreesearchSAPElementId), required: true);
            var __workflow_sAPPressKeyOnTreekey = sAPPressKeyOnTreekey == null ? null : WorkflowExpression.Compile(sAPPressKeyOnTreekey);
            WorkflowExpression.Validate(__workflow_sAPPressKeyOnTreekey, nameof(sAPPressKeyOnTreekey), required: true);
            var __workflow_sAPPressKeyOnTreeworkflow = sAPPressKeyOnTreeworkflow == null ? null : WorkflowExpression.Compile(sAPPressKeyOnTreeworkflow);
            WorkflowExpression.Validate(__workflow_sAPPressKeyOnTreeworkflow, nameof(sAPPressKeyOnTreeworkflow), required: true);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction SAPOpenContextMenuOnTreeItem(Expression<Func<string>> sAPOpenContextMenuOnTreeItemsearchSAPElementId, Expression<Func<string>> sAPOpenContextMenuOnTreeItemworkflow, Expression<Func<string>> sAPOpenContextMenuOnTreeItemsearchNodeKey = null, Expression<Func<string>> sAPOpenContextMenuOnTreeItemsearchNodePath = null, Expression<Func<string>> sAPOpenContextMenuOnTreeItemsearchNodeText = null, Expression<Func<bool>> sAPOpenContextMenuOnTreeItemsearchNodeTextIsRegularExpression = null, Expression<Func<bool>> sAPOpenContextMenuOnTreeItemsearchNodeTextIsCaseSensitive = null, Expression<Func<string>> sAPOpenContextMenuOnTreeItemsearchColumnName = null, Expression<Func<string>> sAPOpenContextMenuOnTreeItemsearchColumnTitle = null, Expression<Func<bool>> sAPOpenContextMenuOnTreeItemsearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPOpenContextMenuOnTreeItemsearchColumnTitleIsCaseSensitive = null)
        {
            var __workflow_sAPOpenContextMenuOnTreeItemsearchSAPElementId = sAPOpenContextMenuOnTreeItemsearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPOpenContextMenuOnTreeItemsearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPOpenContextMenuOnTreeItemsearchSAPElementId, nameof(sAPOpenContextMenuOnTreeItemsearchSAPElementId), required: true);
            var __workflow_sAPOpenContextMenuOnTreeItemworkflow = sAPOpenContextMenuOnTreeItemworkflow == null ? null : WorkflowExpression.Compile(sAPOpenContextMenuOnTreeItemworkflow);
            WorkflowExpression.Validate(__workflow_sAPOpenContextMenuOnTreeItemworkflow, nameof(sAPOpenContextMenuOnTreeItemworkflow), required: true);
            var __workflow_sAPOpenContextMenuOnTreeItemsearchNodeKey = sAPOpenContextMenuOnTreeItemsearchNodeKey == null ? null : WorkflowExpression.Compile(sAPOpenContextMenuOnTreeItemsearchNodeKey);
            WorkflowExpression.Validate(__workflow_sAPOpenContextMenuOnTreeItemsearchNodeKey, nameof(sAPOpenContextMenuOnTreeItemsearchNodeKey), required: false);
            var __workflow_sAPOpenContextMenuOnTreeItemsearchNodePath = sAPOpenContextMenuOnTreeItemsearchNodePath == null ? null : WorkflowExpression.Compile(sAPOpenContextMenuOnTreeItemsearchNodePath);
            WorkflowExpression.Validate(__workflow_sAPOpenContextMenuOnTreeItemsearchNodePath, nameof(sAPOpenContextMenuOnTreeItemsearchNodePath), required: false);
            var __workflow_sAPOpenContextMenuOnTreeItemsearchNodeText = sAPOpenContextMenuOnTreeItemsearchNodeText == null ? null : WorkflowExpression.Compile(sAPOpenContextMenuOnTreeItemsearchNodeText);
            WorkflowExpression.Validate(__workflow_sAPOpenContextMenuOnTreeItemsearchNodeText, nameof(sAPOpenContextMenuOnTreeItemsearchNodeText), required: false);
            var __workflow_sAPOpenContextMenuOnTreeItemsearchNodeTextIsRegularExpression = sAPOpenContextMenuOnTreeItemsearchNodeTextIsRegularExpression == null ? null : WorkflowExpression.Compile(sAPOpenContextMenuOnTreeItemsearchNodeTextIsRegularExpression);
            WorkflowExpression.Validate(__workflow_sAPOpenContextMenuOnTreeItemsearchNodeTextIsRegularExpression, nameof(sAPOpenContextMenuOnTreeItemsearchNodeTextIsRegularExpression), required: false);
            var __workflow_sAPOpenContextMenuOnTreeItemsearchNodeTextIsCaseSensitive = sAPOpenContextMenuOnTreeItemsearchNodeTextIsCaseSensitive == null ? null : WorkflowExpression.Compile(sAPOpenContextMenuOnTreeItemsearchNodeTextIsCaseSensitive);
            WorkflowExpression.Validate(__workflow_sAPOpenContextMenuOnTreeItemsearchNodeTextIsCaseSensitive, nameof(sAPOpenContextMenuOnTreeItemsearchNodeTextIsCaseSensitive), required: false);
            var __workflow_sAPOpenContextMenuOnTreeItemsearchColumnName = sAPOpenContextMenuOnTreeItemsearchColumnName == null ? null : WorkflowExpression.Compile(sAPOpenContextMenuOnTreeItemsearchColumnName);
            WorkflowExpression.Validate(__workflow_sAPOpenContextMenuOnTreeItemsearchColumnName, nameof(sAPOpenContextMenuOnTreeItemsearchColumnName), required: false);
            var __workflow_sAPOpenContextMenuOnTreeItemsearchColumnTitle = sAPOpenContextMenuOnTreeItemsearchColumnTitle == null ? null : WorkflowExpression.Compile(sAPOpenContextMenuOnTreeItemsearchColumnTitle);
            WorkflowExpression.Validate(__workflow_sAPOpenContextMenuOnTreeItemsearchColumnTitle, nameof(sAPOpenContextMenuOnTreeItemsearchColumnTitle), required: false);
            var __workflow_sAPOpenContextMenuOnTreeItemsearchColumnTitleIsRegularExpression = sAPOpenContextMenuOnTreeItemsearchColumnTitleIsRegularExpression == null ? null : WorkflowExpression.Compile(sAPOpenContextMenuOnTreeItemsearchColumnTitleIsRegularExpression);
            WorkflowExpression.Validate(__workflow_sAPOpenContextMenuOnTreeItemsearchColumnTitleIsRegularExpression, nameof(sAPOpenContextMenuOnTreeItemsearchColumnTitleIsRegularExpression), required: false);
            var __workflow_sAPOpenContextMenuOnTreeItemsearchColumnTitleIsCaseSensitive = sAPOpenContextMenuOnTreeItemsearchColumnTitleIsCaseSensitive == null ? null : WorkflowExpression.Compile(sAPOpenContextMenuOnTreeItemsearchColumnTitleIsCaseSensitive);
            WorkflowExpression.Validate(__workflow_sAPOpenContextMenuOnTreeItemsearchColumnTitleIsCaseSensitive, nameof(sAPOpenContextMenuOnTreeItemsearchColumnTitleIsCaseSensitive), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IBodyWorkflowAction<SAPGetTreeTextContentsResponse> SAPGetTreeTextContents(Expression<Func<string>> sAPGetTreeTextContentssearchSAPElementId, Expression<Func<string>> sAPGetTreeTextContentsworkflow, Expression<Func<int>> sAPGetTreeTextContentsfirstRowToReturn = null, Expression<Func<int>> sAPGetTreeTextContentsmaxRowsToReturn = null, Expression<Func<int>> sAPGetTreeTextContentsfirstColumnToReturn = null, Expression<Func<int>> sAPGetTreeTextContentsmaxColumnsToReturn = null, Expression<Func<bool>> sAPGetTreeTextContentsuseColumnHeadersFromTree = null, Expression<Func<bool>> sAPGetTreeTextContentsreturnRowIndexInOutputCollection = null, Expression<Func<string>> sAPGetTreeTextContentsnameOfColumnToStoreRowIndex = null)
        {
            var __workflow_sAPGetTreeTextContentssearchSAPElementId = sAPGetTreeTextContentssearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPGetTreeTextContentssearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPGetTreeTextContentssearchSAPElementId, nameof(sAPGetTreeTextContentssearchSAPElementId), required: true);
            var __workflow_sAPGetTreeTextContentsworkflow = sAPGetTreeTextContentsworkflow == null ? null : WorkflowExpression.Compile(sAPGetTreeTextContentsworkflow);
            WorkflowExpression.Validate(__workflow_sAPGetTreeTextContentsworkflow, nameof(sAPGetTreeTextContentsworkflow), required: true);
            var __workflow_sAPGetTreeTextContentsfirstRowToReturn = sAPGetTreeTextContentsfirstRowToReturn == null ? null : WorkflowExpression.Compile(sAPGetTreeTextContentsfirstRowToReturn);
            WorkflowExpression.Validate(__workflow_sAPGetTreeTextContentsfirstRowToReturn, nameof(sAPGetTreeTextContentsfirstRowToReturn), required: false);
            var __workflow_sAPGetTreeTextContentsmaxRowsToReturn = sAPGetTreeTextContentsmaxRowsToReturn == null ? null : WorkflowExpression.Compile(sAPGetTreeTextContentsmaxRowsToReturn);
            WorkflowExpression.Validate(__workflow_sAPGetTreeTextContentsmaxRowsToReturn, nameof(sAPGetTreeTextContentsmaxRowsToReturn), required: false);
            var __workflow_sAPGetTreeTextContentsfirstColumnToReturn = sAPGetTreeTextContentsfirstColumnToReturn == null ? null : WorkflowExpression.Compile(sAPGetTreeTextContentsfirstColumnToReturn);
            WorkflowExpression.Validate(__workflow_sAPGetTreeTextContentsfirstColumnToReturn, nameof(sAPGetTreeTextContentsfirstColumnToReturn), required: false);
            var __workflow_sAPGetTreeTextContentsmaxColumnsToReturn = sAPGetTreeTextContentsmaxColumnsToReturn == null ? null : WorkflowExpression.Compile(sAPGetTreeTextContentsmaxColumnsToReturn);
            WorkflowExpression.Validate(__workflow_sAPGetTreeTextContentsmaxColumnsToReturn, nameof(sAPGetTreeTextContentsmaxColumnsToReturn), required: false);
            var __workflow_sAPGetTreeTextContentsuseColumnHeadersFromTree = sAPGetTreeTextContentsuseColumnHeadersFromTree == null ? null : WorkflowExpression.Compile(sAPGetTreeTextContentsuseColumnHeadersFromTree);
            WorkflowExpression.Validate(__workflow_sAPGetTreeTextContentsuseColumnHeadersFromTree, nameof(sAPGetTreeTextContentsuseColumnHeadersFromTree), required: false);
            var __workflow_sAPGetTreeTextContentsreturnRowIndexInOutputCollection = sAPGetTreeTextContentsreturnRowIndexInOutputCollection == null ? null : WorkflowExpression.Compile(sAPGetTreeTextContentsreturnRowIndexInOutputCollection);
            WorkflowExpression.Validate(__workflow_sAPGetTreeTextContentsreturnRowIndexInOutputCollection, nameof(sAPGetTreeTextContentsreturnRowIndexInOutputCollection), required: false);
            var __workflow_sAPGetTreeTextContentsnameOfColumnToStoreRowIndex = sAPGetTreeTextContentsnameOfColumnToStoreRowIndex == null ? null : WorkflowExpression.Compile(sAPGetTreeTextContentsnameOfColumnToStoreRowIndex);
            WorkflowExpression.Validate(__workflow_sAPGetTreeTextContentsnameOfColumnToStoreRowIndex, nameof(sAPGetTreeTextContentsnameOfColumnToStoreRowIndex), required: false);
            return new DeferredBodyAction<SAPGetTreeTextContentsResponse>(() =>
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
        public IWorkflowAction SAPSetTreeColumnWidth(Expression<Func<string>> sAPSetTreeColumnWidthsearchSAPElementId, Expression<Func<string>> sAPSetTreeColumnWidthworkflow, Expression<Func<string>> sAPSetTreeColumnWidthsearchColumnName = null, Expression<Func<string>> sAPSetTreeColumnWidthsearchColumnTitle = null, Expression<Func<bool>> sAPSetTreeColumnWidthsearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPSetTreeColumnWidthsearchColumnTitleIsCaseSensitive = null, Expression<Func<int>> sAPSetTreeColumnWidthcolumnWidthInPixels = null)
        {
            var __workflow_sAPSetTreeColumnWidthsearchSAPElementId = sAPSetTreeColumnWidthsearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPSetTreeColumnWidthsearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPSetTreeColumnWidthsearchSAPElementId, nameof(sAPSetTreeColumnWidthsearchSAPElementId), required: true);
            var __workflow_sAPSetTreeColumnWidthworkflow = sAPSetTreeColumnWidthworkflow == null ? null : WorkflowExpression.Compile(sAPSetTreeColumnWidthworkflow);
            WorkflowExpression.Validate(__workflow_sAPSetTreeColumnWidthworkflow, nameof(sAPSetTreeColumnWidthworkflow), required: true);
            var __workflow_sAPSetTreeColumnWidthsearchColumnName = sAPSetTreeColumnWidthsearchColumnName == null ? null : WorkflowExpression.Compile(sAPSetTreeColumnWidthsearchColumnName);
            WorkflowExpression.Validate(__workflow_sAPSetTreeColumnWidthsearchColumnName, nameof(sAPSetTreeColumnWidthsearchColumnName), required: false);
            var __workflow_sAPSetTreeColumnWidthsearchColumnTitle = sAPSetTreeColumnWidthsearchColumnTitle == null ? null : WorkflowExpression.Compile(sAPSetTreeColumnWidthsearchColumnTitle);
            WorkflowExpression.Validate(__workflow_sAPSetTreeColumnWidthsearchColumnTitle, nameof(sAPSetTreeColumnWidthsearchColumnTitle), required: false);
            var __workflow_sAPSetTreeColumnWidthsearchColumnTitleIsRegularExpression = sAPSetTreeColumnWidthsearchColumnTitleIsRegularExpression == null ? null : WorkflowExpression.Compile(sAPSetTreeColumnWidthsearchColumnTitleIsRegularExpression);
            WorkflowExpression.Validate(__workflow_sAPSetTreeColumnWidthsearchColumnTitleIsRegularExpression, nameof(sAPSetTreeColumnWidthsearchColumnTitleIsRegularExpression), required: false);
            var __workflow_sAPSetTreeColumnWidthsearchColumnTitleIsCaseSensitive = sAPSetTreeColumnWidthsearchColumnTitleIsCaseSensitive == null ? null : WorkflowExpression.Compile(sAPSetTreeColumnWidthsearchColumnTitleIsCaseSensitive);
            WorkflowExpression.Validate(__workflow_sAPSetTreeColumnWidthsearchColumnTitleIsCaseSensitive, nameof(sAPSetTreeColumnWidthsearchColumnTitleIsCaseSensitive), required: false);
            var __workflow_sAPSetTreeColumnWidthcolumnWidthInPixels = sAPSetTreeColumnWidthcolumnWidthInPixels == null ? null : WorkflowExpression.Compile(sAPSetTreeColumnWidthcolumnWidthInPixels);
            WorkflowExpression.Validate(__workflow_sAPSetTreeColumnWidthcolumnWidthInPixels, nameof(sAPSetTreeColumnWidthcolumnWidthInPixels), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction SAPPressButtonOnTreeItem(Expression<Func<string>> sAPPressButtonOnTreeItemsearchSAPElementId, Expression<Func<string>> sAPPressButtonOnTreeItemworkflow, Expression<Func<string>> sAPPressButtonOnTreeItemsearchNodeKey = null, Expression<Func<string>> sAPPressButtonOnTreeItemsearchNodePath = null, Expression<Func<string>> sAPPressButtonOnTreeItemsearchNodeText = null, Expression<Func<bool>> sAPPressButtonOnTreeItemsearchNodeTextIsRegularExpression = null, Expression<Func<bool>> sAPPressButtonOnTreeItemsearchNodeTextIsCaseSensitive = null, Expression<Func<string>> sAPPressButtonOnTreeItemsearchColumnName = null, Expression<Func<string>> sAPPressButtonOnTreeItemsearchColumnTitle = null, Expression<Func<bool>> sAPPressButtonOnTreeItemsearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPPressButtonOnTreeItemsearchColumnTitleIsCaseSensitive = null, Expression<Func<bool>> sAPPressButtonOnTreeItemforce = null)
        {
            var __workflow_sAPPressButtonOnTreeItemsearchSAPElementId = sAPPressButtonOnTreeItemsearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPPressButtonOnTreeItemsearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPPressButtonOnTreeItemsearchSAPElementId, nameof(sAPPressButtonOnTreeItemsearchSAPElementId), required: true);
            var __workflow_sAPPressButtonOnTreeItemworkflow = sAPPressButtonOnTreeItemworkflow == null ? null : WorkflowExpression.Compile(sAPPressButtonOnTreeItemworkflow);
            WorkflowExpression.Validate(__workflow_sAPPressButtonOnTreeItemworkflow, nameof(sAPPressButtonOnTreeItemworkflow), required: true);
            var __workflow_sAPPressButtonOnTreeItemsearchNodeKey = sAPPressButtonOnTreeItemsearchNodeKey == null ? null : WorkflowExpression.Compile(sAPPressButtonOnTreeItemsearchNodeKey);
            WorkflowExpression.Validate(__workflow_sAPPressButtonOnTreeItemsearchNodeKey, nameof(sAPPressButtonOnTreeItemsearchNodeKey), required: false);
            var __workflow_sAPPressButtonOnTreeItemsearchNodePath = sAPPressButtonOnTreeItemsearchNodePath == null ? null : WorkflowExpression.Compile(sAPPressButtonOnTreeItemsearchNodePath);
            WorkflowExpression.Validate(__workflow_sAPPressButtonOnTreeItemsearchNodePath, nameof(sAPPressButtonOnTreeItemsearchNodePath), required: false);
            var __workflow_sAPPressButtonOnTreeItemsearchNodeText = sAPPressButtonOnTreeItemsearchNodeText == null ? null : WorkflowExpression.Compile(sAPPressButtonOnTreeItemsearchNodeText);
            WorkflowExpression.Validate(__workflow_sAPPressButtonOnTreeItemsearchNodeText, nameof(sAPPressButtonOnTreeItemsearchNodeText), required: false);
            var __workflow_sAPPressButtonOnTreeItemsearchNodeTextIsRegularExpression = sAPPressButtonOnTreeItemsearchNodeTextIsRegularExpression == null ? null : WorkflowExpression.Compile(sAPPressButtonOnTreeItemsearchNodeTextIsRegularExpression);
            WorkflowExpression.Validate(__workflow_sAPPressButtonOnTreeItemsearchNodeTextIsRegularExpression, nameof(sAPPressButtonOnTreeItemsearchNodeTextIsRegularExpression), required: false);
            var __workflow_sAPPressButtonOnTreeItemsearchNodeTextIsCaseSensitive = sAPPressButtonOnTreeItemsearchNodeTextIsCaseSensitive == null ? null : WorkflowExpression.Compile(sAPPressButtonOnTreeItemsearchNodeTextIsCaseSensitive);
            WorkflowExpression.Validate(__workflow_sAPPressButtonOnTreeItemsearchNodeTextIsCaseSensitive, nameof(sAPPressButtonOnTreeItemsearchNodeTextIsCaseSensitive), required: false);
            var __workflow_sAPPressButtonOnTreeItemsearchColumnName = sAPPressButtonOnTreeItemsearchColumnName == null ? null : WorkflowExpression.Compile(sAPPressButtonOnTreeItemsearchColumnName);
            WorkflowExpression.Validate(__workflow_sAPPressButtonOnTreeItemsearchColumnName, nameof(sAPPressButtonOnTreeItemsearchColumnName), required: false);
            var __workflow_sAPPressButtonOnTreeItemsearchColumnTitle = sAPPressButtonOnTreeItemsearchColumnTitle == null ? null : WorkflowExpression.Compile(sAPPressButtonOnTreeItemsearchColumnTitle);
            WorkflowExpression.Validate(__workflow_sAPPressButtonOnTreeItemsearchColumnTitle, nameof(sAPPressButtonOnTreeItemsearchColumnTitle), required: false);
            var __workflow_sAPPressButtonOnTreeItemsearchColumnTitleIsRegularExpression = sAPPressButtonOnTreeItemsearchColumnTitleIsRegularExpression == null ? null : WorkflowExpression.Compile(sAPPressButtonOnTreeItemsearchColumnTitleIsRegularExpression);
            WorkflowExpression.Validate(__workflow_sAPPressButtonOnTreeItemsearchColumnTitleIsRegularExpression, nameof(sAPPressButtonOnTreeItemsearchColumnTitleIsRegularExpression), required: false);
            var __workflow_sAPPressButtonOnTreeItemsearchColumnTitleIsCaseSensitive = sAPPressButtonOnTreeItemsearchColumnTitleIsCaseSensitive == null ? null : WorkflowExpression.Compile(sAPPressButtonOnTreeItemsearchColumnTitleIsCaseSensitive);
            WorkflowExpression.Validate(__workflow_sAPPressButtonOnTreeItemsearchColumnTitleIsCaseSensitive, nameof(sAPPressButtonOnTreeItemsearchColumnTitleIsCaseSensitive), required: false);
            var __workflow_sAPPressButtonOnTreeItemforce = sAPPressButtonOnTreeItemforce == null ? null : WorkflowExpression.Compile(sAPPressButtonOnTreeItemforce);
            WorkflowExpression.Validate(__workflow_sAPPressButtonOnTreeItemforce, nameof(sAPPressButtonOnTreeItemforce), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction SAPClickLinkOnTreeItem(Expression<Func<string>> sAPClickLinkOnTreeItemsearchSAPElementId, Expression<Func<string>> sAPClickLinkOnTreeItemworkflow, Expression<Func<string>> sAPClickLinkOnTreeItemsearchNodeKey = null, Expression<Func<string>> sAPClickLinkOnTreeItemsearchNodePath = null, Expression<Func<string>> sAPClickLinkOnTreeItemsearchNodeText = null, Expression<Func<bool>> sAPClickLinkOnTreeItemsearchNodeTextIsRegularExpression = null, Expression<Func<bool>> sAPClickLinkOnTreeItemsearchNodeTextIsCaseSensitive = null, Expression<Func<string>> sAPClickLinkOnTreeItemsearchColumnName = null, Expression<Func<string>> sAPClickLinkOnTreeItemsearchColumnTitle = null, Expression<Func<bool>> sAPClickLinkOnTreeItemsearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPClickLinkOnTreeItemsearchColumnTitleIsCaseSensitive = null, Expression<Func<bool>> sAPClickLinkOnTreeItemforce = null)
        {
            var __workflow_sAPClickLinkOnTreeItemsearchSAPElementId = sAPClickLinkOnTreeItemsearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPClickLinkOnTreeItemsearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPClickLinkOnTreeItemsearchSAPElementId, nameof(sAPClickLinkOnTreeItemsearchSAPElementId), required: true);
            var __workflow_sAPClickLinkOnTreeItemworkflow = sAPClickLinkOnTreeItemworkflow == null ? null : WorkflowExpression.Compile(sAPClickLinkOnTreeItemworkflow);
            WorkflowExpression.Validate(__workflow_sAPClickLinkOnTreeItemworkflow, nameof(sAPClickLinkOnTreeItemworkflow), required: true);
            var __workflow_sAPClickLinkOnTreeItemsearchNodeKey = sAPClickLinkOnTreeItemsearchNodeKey == null ? null : WorkflowExpression.Compile(sAPClickLinkOnTreeItemsearchNodeKey);
            WorkflowExpression.Validate(__workflow_sAPClickLinkOnTreeItemsearchNodeKey, nameof(sAPClickLinkOnTreeItemsearchNodeKey), required: false);
            var __workflow_sAPClickLinkOnTreeItemsearchNodePath = sAPClickLinkOnTreeItemsearchNodePath == null ? null : WorkflowExpression.Compile(sAPClickLinkOnTreeItemsearchNodePath);
            WorkflowExpression.Validate(__workflow_sAPClickLinkOnTreeItemsearchNodePath, nameof(sAPClickLinkOnTreeItemsearchNodePath), required: false);
            var __workflow_sAPClickLinkOnTreeItemsearchNodeText = sAPClickLinkOnTreeItemsearchNodeText == null ? null : WorkflowExpression.Compile(sAPClickLinkOnTreeItemsearchNodeText);
            WorkflowExpression.Validate(__workflow_sAPClickLinkOnTreeItemsearchNodeText, nameof(sAPClickLinkOnTreeItemsearchNodeText), required: false);
            var __workflow_sAPClickLinkOnTreeItemsearchNodeTextIsRegularExpression = sAPClickLinkOnTreeItemsearchNodeTextIsRegularExpression == null ? null : WorkflowExpression.Compile(sAPClickLinkOnTreeItemsearchNodeTextIsRegularExpression);
            WorkflowExpression.Validate(__workflow_sAPClickLinkOnTreeItemsearchNodeTextIsRegularExpression, nameof(sAPClickLinkOnTreeItemsearchNodeTextIsRegularExpression), required: false);
            var __workflow_sAPClickLinkOnTreeItemsearchNodeTextIsCaseSensitive = sAPClickLinkOnTreeItemsearchNodeTextIsCaseSensitive == null ? null : WorkflowExpression.Compile(sAPClickLinkOnTreeItemsearchNodeTextIsCaseSensitive);
            WorkflowExpression.Validate(__workflow_sAPClickLinkOnTreeItemsearchNodeTextIsCaseSensitive, nameof(sAPClickLinkOnTreeItemsearchNodeTextIsCaseSensitive), required: false);
            var __workflow_sAPClickLinkOnTreeItemsearchColumnName = sAPClickLinkOnTreeItemsearchColumnName == null ? null : WorkflowExpression.Compile(sAPClickLinkOnTreeItemsearchColumnName);
            WorkflowExpression.Validate(__workflow_sAPClickLinkOnTreeItemsearchColumnName, nameof(sAPClickLinkOnTreeItemsearchColumnName), required: false);
            var __workflow_sAPClickLinkOnTreeItemsearchColumnTitle = sAPClickLinkOnTreeItemsearchColumnTitle == null ? null : WorkflowExpression.Compile(sAPClickLinkOnTreeItemsearchColumnTitle);
            WorkflowExpression.Validate(__workflow_sAPClickLinkOnTreeItemsearchColumnTitle, nameof(sAPClickLinkOnTreeItemsearchColumnTitle), required: false);
            var __workflow_sAPClickLinkOnTreeItemsearchColumnTitleIsRegularExpression = sAPClickLinkOnTreeItemsearchColumnTitleIsRegularExpression == null ? null : WorkflowExpression.Compile(sAPClickLinkOnTreeItemsearchColumnTitleIsRegularExpression);
            WorkflowExpression.Validate(__workflow_sAPClickLinkOnTreeItemsearchColumnTitleIsRegularExpression, nameof(sAPClickLinkOnTreeItemsearchColumnTitleIsRegularExpression), required: false);
            var __workflow_sAPClickLinkOnTreeItemsearchColumnTitleIsCaseSensitive = sAPClickLinkOnTreeItemsearchColumnTitleIsCaseSensitive == null ? null : WorkflowExpression.Compile(sAPClickLinkOnTreeItemsearchColumnTitleIsCaseSensitive);
            WorkflowExpression.Validate(__workflow_sAPClickLinkOnTreeItemsearchColumnTitleIsCaseSensitive, nameof(sAPClickLinkOnTreeItemsearchColumnTitleIsCaseSensitive), required: false);
            var __workflow_sAPClickLinkOnTreeItemforce = sAPClickLinkOnTreeItemforce == null ? null : WorkflowExpression.Compile(sAPClickLinkOnTreeItemforce);
            WorkflowExpression.Validate(__workflow_sAPClickLinkOnTreeItemforce, nameof(sAPClickLinkOnTreeItemforce), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction SAPCheckTreeItem(Expression<Func<string>> sAPCheckTreeItemsearchSAPElementId, Expression<Func<string>> sAPCheckTreeItemworkflow, Expression<Func<string>> sAPCheckTreeItemsearchNodeKey = null, Expression<Func<string>> sAPCheckTreeItemsearchNodePath = null, Expression<Func<string>> sAPCheckTreeItemsearchNodeText = null, Expression<Func<bool>> sAPCheckTreeItemsearchNodeTextIsRegularExpression = null, Expression<Func<bool>> sAPCheckTreeItemsearchNodeTextIsCaseSensitive = null, Expression<Func<string>> sAPCheckTreeItemsearchColumnName = null, Expression<Func<string>> sAPCheckTreeItemsearchColumnTitle = null, Expression<Func<bool>> sAPCheckTreeItemsearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPCheckTreeItemsearchColumnTitleIsCaseSensitive = null, Expression<Func<bool>> sAPCheckTreeItemcheckItem = null, Expression<Func<bool>> sAPCheckTreeItemforce = null)
        {
            var __workflow_sAPCheckTreeItemsearchSAPElementId = sAPCheckTreeItemsearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPCheckTreeItemsearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPCheckTreeItemsearchSAPElementId, nameof(sAPCheckTreeItemsearchSAPElementId), required: true);
            var __workflow_sAPCheckTreeItemworkflow = sAPCheckTreeItemworkflow == null ? null : WorkflowExpression.Compile(sAPCheckTreeItemworkflow);
            WorkflowExpression.Validate(__workflow_sAPCheckTreeItemworkflow, nameof(sAPCheckTreeItemworkflow), required: true);
            var __workflow_sAPCheckTreeItemsearchNodeKey = sAPCheckTreeItemsearchNodeKey == null ? null : WorkflowExpression.Compile(sAPCheckTreeItemsearchNodeKey);
            WorkflowExpression.Validate(__workflow_sAPCheckTreeItemsearchNodeKey, nameof(sAPCheckTreeItemsearchNodeKey), required: false);
            var __workflow_sAPCheckTreeItemsearchNodePath = sAPCheckTreeItemsearchNodePath == null ? null : WorkflowExpression.Compile(sAPCheckTreeItemsearchNodePath);
            WorkflowExpression.Validate(__workflow_sAPCheckTreeItemsearchNodePath, nameof(sAPCheckTreeItemsearchNodePath), required: false);
            var __workflow_sAPCheckTreeItemsearchNodeText = sAPCheckTreeItemsearchNodeText == null ? null : WorkflowExpression.Compile(sAPCheckTreeItemsearchNodeText);
            WorkflowExpression.Validate(__workflow_sAPCheckTreeItemsearchNodeText, nameof(sAPCheckTreeItemsearchNodeText), required: false);
            var __workflow_sAPCheckTreeItemsearchNodeTextIsRegularExpression = sAPCheckTreeItemsearchNodeTextIsRegularExpression == null ? null : WorkflowExpression.Compile(sAPCheckTreeItemsearchNodeTextIsRegularExpression);
            WorkflowExpression.Validate(__workflow_sAPCheckTreeItemsearchNodeTextIsRegularExpression, nameof(sAPCheckTreeItemsearchNodeTextIsRegularExpression), required: false);
            var __workflow_sAPCheckTreeItemsearchNodeTextIsCaseSensitive = sAPCheckTreeItemsearchNodeTextIsCaseSensitive == null ? null : WorkflowExpression.Compile(sAPCheckTreeItemsearchNodeTextIsCaseSensitive);
            WorkflowExpression.Validate(__workflow_sAPCheckTreeItemsearchNodeTextIsCaseSensitive, nameof(sAPCheckTreeItemsearchNodeTextIsCaseSensitive), required: false);
            var __workflow_sAPCheckTreeItemsearchColumnName = sAPCheckTreeItemsearchColumnName == null ? null : WorkflowExpression.Compile(sAPCheckTreeItemsearchColumnName);
            WorkflowExpression.Validate(__workflow_sAPCheckTreeItemsearchColumnName, nameof(sAPCheckTreeItemsearchColumnName), required: false);
            var __workflow_sAPCheckTreeItemsearchColumnTitle = sAPCheckTreeItemsearchColumnTitle == null ? null : WorkflowExpression.Compile(sAPCheckTreeItemsearchColumnTitle);
            WorkflowExpression.Validate(__workflow_sAPCheckTreeItemsearchColumnTitle, nameof(sAPCheckTreeItemsearchColumnTitle), required: false);
            var __workflow_sAPCheckTreeItemsearchColumnTitleIsRegularExpression = sAPCheckTreeItemsearchColumnTitleIsRegularExpression == null ? null : WorkflowExpression.Compile(sAPCheckTreeItemsearchColumnTitleIsRegularExpression);
            WorkflowExpression.Validate(__workflow_sAPCheckTreeItemsearchColumnTitleIsRegularExpression, nameof(sAPCheckTreeItemsearchColumnTitleIsRegularExpression), required: false);
            var __workflow_sAPCheckTreeItemsearchColumnTitleIsCaseSensitive = sAPCheckTreeItemsearchColumnTitleIsCaseSensitive == null ? null : WorkflowExpression.Compile(sAPCheckTreeItemsearchColumnTitleIsCaseSensitive);
            WorkflowExpression.Validate(__workflow_sAPCheckTreeItemsearchColumnTitleIsCaseSensitive, nameof(sAPCheckTreeItemsearchColumnTitleIsCaseSensitive), required: false);
            var __workflow_sAPCheckTreeItemcheckItem = sAPCheckTreeItemcheckItem == null ? null : WorkflowExpression.Compile(sAPCheckTreeItemcheckItem);
            WorkflowExpression.Validate(__workflow_sAPCheckTreeItemcheckItem, nameof(sAPCheckTreeItemcheckItem), required: false);
            var __workflow_sAPCheckTreeItemforce = sAPCheckTreeItemforce == null ? null : WorkflowExpression.Compile(sAPCheckTreeItemforce);
            WorkflowExpression.Validate(__workflow_sAPCheckTreeItemforce, nameof(sAPCheckTreeItemforce), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IBodyWorkflowAction<SAPGetTreeColumnHeadersResponse> SAPGetTreeColumnHeaders(Expression<Func<string>> sAPGetTreeColumnHeaderssearchSAPElementId, Expression<Func<string>> sAPGetTreeColumnHeadersworkflow)
        {
            var __workflow_sAPGetTreeColumnHeaderssearchSAPElementId = sAPGetTreeColumnHeaderssearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPGetTreeColumnHeaderssearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPGetTreeColumnHeaderssearchSAPElementId, nameof(sAPGetTreeColumnHeaderssearchSAPElementId), required: true);
            var __workflow_sAPGetTreeColumnHeadersworkflow = sAPGetTreeColumnHeadersworkflow == null ? null : WorkflowExpression.Compile(sAPGetTreeColumnHeadersworkflow);
            WorkflowExpression.Validate(__workflow_sAPGetTreeColumnHeadersworkflow, nameof(sAPGetTreeColumnHeadersworkflow), required: true);
            return new DeferredBodyAction<SAPGetTreeColumnHeadersResponse>(() =>
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
        public IBodyWorkflowAction<SAPGetTreeItemPropertiesResponse> SAPGetTreeItemProperties(Expression<Func<string>> sAPGetTreeItemPropertiessearchSAPElementId, Expression<Func<string>> sAPGetTreeItemPropertiesworkflow, Expression<Func<string>> sAPGetTreeItemPropertiessearchNodeKey = null, Expression<Func<string>> sAPGetTreeItemPropertiessearchNodePath = null, Expression<Func<string>> sAPGetTreeItemPropertiessearchNodeText = null, Expression<Func<bool>> sAPGetTreeItemPropertiessearchNodeTextIsRegularExpression = null, Expression<Func<bool>> sAPGetTreeItemPropertiessearchNodeTextIsCaseSensitive = null, Expression<Func<string>> sAPGetTreeItemPropertiessearchColumnName = null, Expression<Func<string>> sAPGetTreeItemPropertiessearchColumnTitle = null, Expression<Func<bool>> sAPGetTreeItemPropertiessearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPGetTreeItemPropertiessearchColumnTitleIsCaseSensitive = null)
        {
            var __workflow_sAPGetTreeItemPropertiessearchSAPElementId = sAPGetTreeItemPropertiessearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPGetTreeItemPropertiessearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPGetTreeItemPropertiessearchSAPElementId, nameof(sAPGetTreeItemPropertiessearchSAPElementId), required: true);
            var __workflow_sAPGetTreeItemPropertiesworkflow = sAPGetTreeItemPropertiesworkflow == null ? null : WorkflowExpression.Compile(sAPGetTreeItemPropertiesworkflow);
            WorkflowExpression.Validate(__workflow_sAPGetTreeItemPropertiesworkflow, nameof(sAPGetTreeItemPropertiesworkflow), required: true);
            var __workflow_sAPGetTreeItemPropertiessearchNodeKey = sAPGetTreeItemPropertiessearchNodeKey == null ? null : WorkflowExpression.Compile(sAPGetTreeItemPropertiessearchNodeKey);
            WorkflowExpression.Validate(__workflow_sAPGetTreeItemPropertiessearchNodeKey, nameof(sAPGetTreeItemPropertiessearchNodeKey), required: false);
            var __workflow_sAPGetTreeItemPropertiessearchNodePath = sAPGetTreeItemPropertiessearchNodePath == null ? null : WorkflowExpression.Compile(sAPGetTreeItemPropertiessearchNodePath);
            WorkflowExpression.Validate(__workflow_sAPGetTreeItemPropertiessearchNodePath, nameof(sAPGetTreeItemPropertiessearchNodePath), required: false);
            var __workflow_sAPGetTreeItemPropertiessearchNodeText = sAPGetTreeItemPropertiessearchNodeText == null ? null : WorkflowExpression.Compile(sAPGetTreeItemPropertiessearchNodeText);
            WorkflowExpression.Validate(__workflow_sAPGetTreeItemPropertiessearchNodeText, nameof(sAPGetTreeItemPropertiessearchNodeText), required: false);
            var __workflow_sAPGetTreeItemPropertiessearchNodeTextIsRegularExpression = sAPGetTreeItemPropertiessearchNodeTextIsRegularExpression == null ? null : WorkflowExpression.Compile(sAPGetTreeItemPropertiessearchNodeTextIsRegularExpression);
            WorkflowExpression.Validate(__workflow_sAPGetTreeItemPropertiessearchNodeTextIsRegularExpression, nameof(sAPGetTreeItemPropertiessearchNodeTextIsRegularExpression), required: false);
            var __workflow_sAPGetTreeItemPropertiessearchNodeTextIsCaseSensitive = sAPGetTreeItemPropertiessearchNodeTextIsCaseSensitive == null ? null : WorkflowExpression.Compile(sAPGetTreeItemPropertiessearchNodeTextIsCaseSensitive);
            WorkflowExpression.Validate(__workflow_sAPGetTreeItemPropertiessearchNodeTextIsCaseSensitive, nameof(sAPGetTreeItemPropertiessearchNodeTextIsCaseSensitive), required: false);
            var __workflow_sAPGetTreeItemPropertiessearchColumnName = sAPGetTreeItemPropertiessearchColumnName == null ? null : WorkflowExpression.Compile(sAPGetTreeItemPropertiessearchColumnName);
            WorkflowExpression.Validate(__workflow_sAPGetTreeItemPropertiessearchColumnName, nameof(sAPGetTreeItemPropertiessearchColumnName), required: false);
            var __workflow_sAPGetTreeItemPropertiessearchColumnTitle = sAPGetTreeItemPropertiessearchColumnTitle == null ? null : WorkflowExpression.Compile(sAPGetTreeItemPropertiessearchColumnTitle);
            WorkflowExpression.Validate(__workflow_sAPGetTreeItemPropertiessearchColumnTitle, nameof(sAPGetTreeItemPropertiessearchColumnTitle), required: false);
            var __workflow_sAPGetTreeItemPropertiessearchColumnTitleIsRegularExpression = sAPGetTreeItemPropertiessearchColumnTitleIsRegularExpression == null ? null : WorkflowExpression.Compile(sAPGetTreeItemPropertiessearchColumnTitleIsRegularExpression);
            WorkflowExpression.Validate(__workflow_sAPGetTreeItemPropertiessearchColumnTitleIsRegularExpression, nameof(sAPGetTreeItemPropertiessearchColumnTitleIsRegularExpression), required: false);
            var __workflow_sAPGetTreeItemPropertiessearchColumnTitleIsCaseSensitive = sAPGetTreeItemPropertiessearchColumnTitleIsCaseSensitive == null ? null : WorkflowExpression.Compile(sAPGetTreeItemPropertiessearchColumnTitleIsCaseSensitive);
            WorkflowExpression.Validate(__workflow_sAPGetTreeItemPropertiessearchColumnTitleIsCaseSensitive, nameof(sAPGetTreeItemPropertiessearchColumnTitleIsCaseSensitive), required: false);
            return new DeferredBodyAction<SAPGetTreeItemPropertiesResponse>(() =>
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
        public IBodyWorkflowAction<SAPGetShellToolbarElementsResponse> SAPGetShellToolbarElements(Expression<Func<string>> sAPGetShellToolbarElementssearchSAPElementId, Expression<Func<string>> sAPGetShellToolbarElementsworkflow)
        {
            var __workflow_sAPGetShellToolbarElementssearchSAPElementId = sAPGetShellToolbarElementssearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPGetShellToolbarElementssearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPGetShellToolbarElementssearchSAPElementId, nameof(sAPGetShellToolbarElementssearchSAPElementId), required: true);
            var __workflow_sAPGetShellToolbarElementsworkflow = sAPGetShellToolbarElementsworkflow == null ? null : WorkflowExpression.Compile(sAPGetShellToolbarElementsworkflow);
            WorkflowExpression.Validate(__workflow_sAPGetShellToolbarElementsworkflow, nameof(sAPGetShellToolbarElementsworkflow), required: true);
            return new DeferredBodyAction<SAPGetShellToolbarElementsResponse>(() =>
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
        public IWorkflowAction SAPPressShellToolbarElement(Expression<Func<string>> sAPPressShellToolbarElementsearchSAPElementId, Expression<Func<string>> sAPPressShellToolbarElementworkflow, Expression<Func<string>> sAPPressShellToolbarElementsearchToolbarElementId = null, Expression<Func<string>> sAPPressShellToolbarElementsearchToolbarElementText = null, Expression<Func<int>> sAPPressShellToolbarElementsearchToolbarElementIndex = null, Expression<Func<bool>> sAPPressShellToolbarElementsearchToolbarTextIsRegularExpression = null, Expression<Func<bool>> sAPPressShellToolbarElementsearchToolbarTextIsCaseSensitive = null)
        {
            var __workflow_sAPPressShellToolbarElementsearchSAPElementId = sAPPressShellToolbarElementsearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPPressShellToolbarElementsearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPPressShellToolbarElementsearchSAPElementId, nameof(sAPPressShellToolbarElementsearchSAPElementId), required: true);
            var __workflow_sAPPressShellToolbarElementworkflow = sAPPressShellToolbarElementworkflow == null ? null : WorkflowExpression.Compile(sAPPressShellToolbarElementworkflow);
            WorkflowExpression.Validate(__workflow_sAPPressShellToolbarElementworkflow, nameof(sAPPressShellToolbarElementworkflow), required: true);
            var __workflow_sAPPressShellToolbarElementsearchToolbarElementId = sAPPressShellToolbarElementsearchToolbarElementId == null ? null : WorkflowExpression.Compile(sAPPressShellToolbarElementsearchToolbarElementId);
            WorkflowExpression.Validate(__workflow_sAPPressShellToolbarElementsearchToolbarElementId, nameof(sAPPressShellToolbarElementsearchToolbarElementId), required: false);
            var __workflow_sAPPressShellToolbarElementsearchToolbarElementText = sAPPressShellToolbarElementsearchToolbarElementText == null ? null : WorkflowExpression.Compile(sAPPressShellToolbarElementsearchToolbarElementText);
            WorkflowExpression.Validate(__workflow_sAPPressShellToolbarElementsearchToolbarElementText, nameof(sAPPressShellToolbarElementsearchToolbarElementText), required: false);
            var __workflow_sAPPressShellToolbarElementsearchToolbarElementIndex = sAPPressShellToolbarElementsearchToolbarElementIndex == null ? null : WorkflowExpression.Compile(sAPPressShellToolbarElementsearchToolbarElementIndex);
            WorkflowExpression.Validate(__workflow_sAPPressShellToolbarElementsearchToolbarElementIndex, nameof(sAPPressShellToolbarElementsearchToolbarElementIndex), required: false);
            var __workflow_sAPPressShellToolbarElementsearchToolbarTextIsRegularExpression = sAPPressShellToolbarElementsearchToolbarTextIsRegularExpression == null ? null : WorkflowExpression.Compile(sAPPressShellToolbarElementsearchToolbarTextIsRegularExpression);
            WorkflowExpression.Validate(__workflow_sAPPressShellToolbarElementsearchToolbarTextIsRegularExpression, nameof(sAPPressShellToolbarElementsearchToolbarTextIsRegularExpression), required: false);
            var __workflow_sAPPressShellToolbarElementsearchToolbarTextIsCaseSensitive = sAPPressShellToolbarElementsearchToolbarTextIsCaseSensitive == null ? null : WorkflowExpression.Compile(sAPPressShellToolbarElementsearchToolbarTextIsCaseSensitive);
            WorkflowExpression.Validate(__workflow_sAPPressShellToolbarElementsearchToolbarTextIsCaseSensitive, nameof(sAPPressShellToolbarElementsearchToolbarTextIsCaseSensitive), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction SAPPressShellToolbarElementContextButton(Expression<Func<string>> sAPPressShellToolbarElementContextButtonsearchSAPElementId, Expression<Func<string>> sAPPressShellToolbarElementContextButtonworkflow, Expression<Func<string>> sAPPressShellToolbarElementContextButtonsearchToolbarElementId = null, Expression<Func<string>> sAPPressShellToolbarElementContextButtonsearchToolbarElementText = null, Expression<Func<int>> sAPPressShellToolbarElementContextButtonsearchToolbarElementIndex = null, Expression<Func<bool>> sAPPressShellToolbarElementContextButtonsearchToolbarTextIsRegularExpression = null, Expression<Func<bool>> sAPPressShellToolbarElementContextButtonsearchToolbarTextIsCaseSensitive = null)
        {
            var __workflow_sAPPressShellToolbarElementContextButtonsearchSAPElementId = sAPPressShellToolbarElementContextButtonsearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPPressShellToolbarElementContextButtonsearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPPressShellToolbarElementContextButtonsearchSAPElementId, nameof(sAPPressShellToolbarElementContextButtonsearchSAPElementId), required: true);
            var __workflow_sAPPressShellToolbarElementContextButtonworkflow = sAPPressShellToolbarElementContextButtonworkflow == null ? null : WorkflowExpression.Compile(sAPPressShellToolbarElementContextButtonworkflow);
            WorkflowExpression.Validate(__workflow_sAPPressShellToolbarElementContextButtonworkflow, nameof(sAPPressShellToolbarElementContextButtonworkflow), required: true);
            var __workflow_sAPPressShellToolbarElementContextButtonsearchToolbarElementId = sAPPressShellToolbarElementContextButtonsearchToolbarElementId == null ? null : WorkflowExpression.Compile(sAPPressShellToolbarElementContextButtonsearchToolbarElementId);
            WorkflowExpression.Validate(__workflow_sAPPressShellToolbarElementContextButtonsearchToolbarElementId, nameof(sAPPressShellToolbarElementContextButtonsearchToolbarElementId), required: false);
            var __workflow_sAPPressShellToolbarElementContextButtonsearchToolbarElementText = sAPPressShellToolbarElementContextButtonsearchToolbarElementText == null ? null : WorkflowExpression.Compile(sAPPressShellToolbarElementContextButtonsearchToolbarElementText);
            WorkflowExpression.Validate(__workflow_sAPPressShellToolbarElementContextButtonsearchToolbarElementText, nameof(sAPPressShellToolbarElementContextButtonsearchToolbarElementText), required: false);
            var __workflow_sAPPressShellToolbarElementContextButtonsearchToolbarElementIndex = sAPPressShellToolbarElementContextButtonsearchToolbarElementIndex == null ? null : WorkflowExpression.Compile(sAPPressShellToolbarElementContextButtonsearchToolbarElementIndex);
            WorkflowExpression.Validate(__workflow_sAPPressShellToolbarElementContextButtonsearchToolbarElementIndex, nameof(sAPPressShellToolbarElementContextButtonsearchToolbarElementIndex), required: false);
            var __workflow_sAPPressShellToolbarElementContextButtonsearchToolbarTextIsRegularExpression = sAPPressShellToolbarElementContextButtonsearchToolbarTextIsRegularExpression == null ? null : WorkflowExpression.Compile(sAPPressShellToolbarElementContextButtonsearchToolbarTextIsRegularExpression);
            WorkflowExpression.Validate(__workflow_sAPPressShellToolbarElementContextButtonsearchToolbarTextIsRegularExpression, nameof(sAPPressShellToolbarElementContextButtonsearchToolbarTextIsRegularExpression), required: false);
            var __workflow_sAPPressShellToolbarElementContextButtonsearchToolbarTextIsCaseSensitive = sAPPressShellToolbarElementContextButtonsearchToolbarTextIsCaseSensitive == null ? null : WorkflowExpression.Compile(sAPPressShellToolbarElementContextButtonsearchToolbarTextIsCaseSensitive);
            WorkflowExpression.Validate(__workflow_sAPPressShellToolbarElementContextButtonsearchToolbarTextIsCaseSensitive, nameof(sAPPressShellToolbarElementContextButtonsearchToolbarTextIsCaseSensitive), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction SAPSelectShellToolbarMenuItem(Expression<Func<string>> sAPSelectShellToolbarMenuItemsearchSAPElementId, Expression<Func<string>> sAPSelectShellToolbarMenuItemworkflow, Expression<Func<string>> sAPSelectShellToolbarMenuItemsearchToolbarElementId = null, Expression<Func<string>> sAPSelectShellToolbarMenuItemsearchToolbarElementText = null, Expression<Func<int>> sAPSelectShellToolbarMenuItemsearchToolbarElementIndex = null, Expression<Func<bool>> sAPSelectShellToolbarMenuItemsearchToolbarTextIsRegularExpression = null, Expression<Func<bool>> sAPSelectShellToolbarMenuItemsearchToolbarTextIsCaseSensitive = null)
        {
            var __workflow_sAPSelectShellToolbarMenuItemsearchSAPElementId = sAPSelectShellToolbarMenuItemsearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPSelectShellToolbarMenuItemsearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPSelectShellToolbarMenuItemsearchSAPElementId, nameof(sAPSelectShellToolbarMenuItemsearchSAPElementId), required: true);
            var __workflow_sAPSelectShellToolbarMenuItemworkflow = sAPSelectShellToolbarMenuItemworkflow == null ? null : WorkflowExpression.Compile(sAPSelectShellToolbarMenuItemworkflow);
            WorkflowExpression.Validate(__workflow_sAPSelectShellToolbarMenuItemworkflow, nameof(sAPSelectShellToolbarMenuItemworkflow), required: true);
            var __workflow_sAPSelectShellToolbarMenuItemsearchToolbarElementId = sAPSelectShellToolbarMenuItemsearchToolbarElementId == null ? null : WorkflowExpression.Compile(sAPSelectShellToolbarMenuItemsearchToolbarElementId);
            WorkflowExpression.Validate(__workflow_sAPSelectShellToolbarMenuItemsearchToolbarElementId, nameof(sAPSelectShellToolbarMenuItemsearchToolbarElementId), required: false);
            var __workflow_sAPSelectShellToolbarMenuItemsearchToolbarElementText = sAPSelectShellToolbarMenuItemsearchToolbarElementText == null ? null : WorkflowExpression.Compile(sAPSelectShellToolbarMenuItemsearchToolbarElementText);
            WorkflowExpression.Validate(__workflow_sAPSelectShellToolbarMenuItemsearchToolbarElementText, nameof(sAPSelectShellToolbarMenuItemsearchToolbarElementText), required: false);
            var __workflow_sAPSelectShellToolbarMenuItemsearchToolbarElementIndex = sAPSelectShellToolbarMenuItemsearchToolbarElementIndex == null ? null : WorkflowExpression.Compile(sAPSelectShellToolbarMenuItemsearchToolbarElementIndex);
            WorkflowExpression.Validate(__workflow_sAPSelectShellToolbarMenuItemsearchToolbarElementIndex, nameof(sAPSelectShellToolbarMenuItemsearchToolbarElementIndex), required: false);
            var __workflow_sAPSelectShellToolbarMenuItemsearchToolbarTextIsRegularExpression = sAPSelectShellToolbarMenuItemsearchToolbarTextIsRegularExpression == null ? null : WorkflowExpression.Compile(sAPSelectShellToolbarMenuItemsearchToolbarTextIsRegularExpression);
            WorkflowExpression.Validate(__workflow_sAPSelectShellToolbarMenuItemsearchToolbarTextIsRegularExpression, nameof(sAPSelectShellToolbarMenuItemsearchToolbarTextIsRegularExpression), required: false);
            var __workflow_sAPSelectShellToolbarMenuItemsearchToolbarTextIsCaseSensitive = sAPSelectShellToolbarMenuItemsearchToolbarTextIsCaseSensitive == null ? null : WorkflowExpression.Compile(sAPSelectShellToolbarMenuItemsearchToolbarTextIsCaseSensitive);
            WorkflowExpression.Validate(__workflow_sAPSelectShellToolbarMenuItemsearchToolbarTextIsCaseSensitive, nameof(sAPSelectShellToolbarMenuItemsearchToolbarTextIsCaseSensitive), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IBodyWorkflowAction<SAPGetSAPGridViewPropertiesResponse> SAPGetSAPGridViewProperties(Expression<Func<string>> sAPGetSAPGridViewPropertiessearchSAPElementId, Expression<Func<string>> sAPGetSAPGridViewPropertiesworkflow)
        {
            var __workflow_sAPGetSAPGridViewPropertiessearchSAPElementId = sAPGetSAPGridViewPropertiessearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPGetSAPGridViewPropertiessearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPGetSAPGridViewPropertiessearchSAPElementId, nameof(sAPGetSAPGridViewPropertiessearchSAPElementId), required: true);
            var __workflow_sAPGetSAPGridViewPropertiesworkflow = sAPGetSAPGridViewPropertiesworkflow == null ? null : WorkflowExpression.Compile(sAPGetSAPGridViewPropertiesworkflow);
            WorkflowExpression.Validate(__workflow_sAPGetSAPGridViewPropertiesworkflow, nameof(sAPGetSAPGridViewPropertiesworkflow), required: true);
            return new DeferredBodyAction<SAPGetSAPGridViewPropertiesResponse>(() =>
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
        public IBodyWorkflowAction<SAPGetSAPGridViewCellContentsAtIndexResponse> SAPGetSAPGridViewCellContentsAtIndex(Expression<Func<string>> sAPGetSAPGridViewCellContentsAtIndexsearchSAPElementId, Expression<Func<int>> sAPGetSAPGridViewCellContentsAtIndexrowIndex, Expression<Func<string>> sAPGetSAPGridViewCellContentsAtIndexworkflow, Expression<Func<string>> sAPGetSAPGridViewCellContentsAtIndexsearchColumnName = null, Expression<Func<string>> sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitle = null, Expression<Func<bool>> sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitleIsCaseSensitive = null)
        {
            var __workflow_sAPGetSAPGridViewCellContentsAtIndexsearchSAPElementId = sAPGetSAPGridViewCellContentsAtIndexsearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPGetSAPGridViewCellContentsAtIndexsearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPGetSAPGridViewCellContentsAtIndexsearchSAPElementId, nameof(sAPGetSAPGridViewCellContentsAtIndexsearchSAPElementId), required: true);
            var __workflow_sAPGetSAPGridViewCellContentsAtIndexrowIndex = sAPGetSAPGridViewCellContentsAtIndexrowIndex == null ? null : WorkflowExpression.Compile(sAPGetSAPGridViewCellContentsAtIndexrowIndex);
            WorkflowExpression.Validate(__workflow_sAPGetSAPGridViewCellContentsAtIndexrowIndex, nameof(sAPGetSAPGridViewCellContentsAtIndexrowIndex), required: true);
            var __workflow_sAPGetSAPGridViewCellContentsAtIndexworkflow = sAPGetSAPGridViewCellContentsAtIndexworkflow == null ? null : WorkflowExpression.Compile(sAPGetSAPGridViewCellContentsAtIndexworkflow);
            WorkflowExpression.Validate(__workflow_sAPGetSAPGridViewCellContentsAtIndexworkflow, nameof(sAPGetSAPGridViewCellContentsAtIndexworkflow), required: true);
            var __workflow_sAPGetSAPGridViewCellContentsAtIndexsearchColumnName = sAPGetSAPGridViewCellContentsAtIndexsearchColumnName == null ? null : WorkflowExpression.Compile(sAPGetSAPGridViewCellContentsAtIndexsearchColumnName);
            WorkflowExpression.Validate(__workflow_sAPGetSAPGridViewCellContentsAtIndexsearchColumnName, nameof(sAPGetSAPGridViewCellContentsAtIndexsearchColumnName), required: false);
            var __workflow_sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitle = sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitle == null ? null : WorkflowExpression.Compile(sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitle);
            WorkflowExpression.Validate(__workflow_sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitle, nameof(sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitle), required: false);
            var __workflow_sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitleIsRegularExpression = sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitleIsRegularExpression == null ? null : WorkflowExpression.Compile(sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitleIsRegularExpression);
            WorkflowExpression.Validate(__workflow_sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitleIsRegularExpression, nameof(sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitleIsRegularExpression), required: false);
            var __workflow_sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitleIsCaseSensitive = sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitleIsCaseSensitive == null ? null : WorkflowExpression.Compile(sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitleIsCaseSensitive);
            WorkflowExpression.Validate(__workflow_sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitleIsCaseSensitive, nameof(sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitleIsCaseSensitive), required: false);
            return new DeferredBodyAction<SAPGetSAPGridViewCellContentsAtIndexResponse>(() =>
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
        public IBodyWorkflowAction<SAPGetSAPGridViewCellPropertiesAtIndexResponse> SAPGetSAPGridViewCellPropertiesAtIndex(Expression<Func<string>> sAPGetSAPGridViewCellPropertiesAtIndexsearchSAPElementId, Expression<Func<int>> sAPGetSAPGridViewCellPropertiesAtIndexrowIndex, Expression<Func<string>> sAPGetSAPGridViewCellPropertiesAtIndexworkflow, Expression<Func<string>> sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnName = null, Expression<Func<string>> sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitle = null, Expression<Func<bool>> sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitleIsCaseSensitive = null)
        {
            var __workflow_sAPGetSAPGridViewCellPropertiesAtIndexsearchSAPElementId = sAPGetSAPGridViewCellPropertiesAtIndexsearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPGetSAPGridViewCellPropertiesAtIndexsearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPGetSAPGridViewCellPropertiesAtIndexsearchSAPElementId, nameof(sAPGetSAPGridViewCellPropertiesAtIndexsearchSAPElementId), required: true);
            var __workflow_sAPGetSAPGridViewCellPropertiesAtIndexrowIndex = sAPGetSAPGridViewCellPropertiesAtIndexrowIndex == null ? null : WorkflowExpression.Compile(sAPGetSAPGridViewCellPropertiesAtIndexrowIndex);
            WorkflowExpression.Validate(__workflow_sAPGetSAPGridViewCellPropertiesAtIndexrowIndex, nameof(sAPGetSAPGridViewCellPropertiesAtIndexrowIndex), required: true);
            var __workflow_sAPGetSAPGridViewCellPropertiesAtIndexworkflow = sAPGetSAPGridViewCellPropertiesAtIndexworkflow == null ? null : WorkflowExpression.Compile(sAPGetSAPGridViewCellPropertiesAtIndexworkflow);
            WorkflowExpression.Validate(__workflow_sAPGetSAPGridViewCellPropertiesAtIndexworkflow, nameof(sAPGetSAPGridViewCellPropertiesAtIndexworkflow), required: true);
            var __workflow_sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnName = sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnName == null ? null : WorkflowExpression.Compile(sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnName);
            WorkflowExpression.Validate(__workflow_sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnName, nameof(sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnName), required: false);
            var __workflow_sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitle = sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitle == null ? null : WorkflowExpression.Compile(sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitle);
            WorkflowExpression.Validate(__workflow_sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitle, nameof(sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitle), required: false);
            var __workflow_sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitleIsRegularExpression = sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitleIsRegularExpression == null ? null : WorkflowExpression.Compile(sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitleIsRegularExpression);
            WorkflowExpression.Validate(__workflow_sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitleIsRegularExpression, nameof(sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitleIsRegularExpression), required: false);
            var __workflow_sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitleIsCaseSensitive = sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitleIsCaseSensitive == null ? null : WorkflowExpression.Compile(sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitleIsCaseSensitive);
            WorkflowExpression.Validate(__workflow_sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitleIsCaseSensitive, nameof(sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitleIsCaseSensitive), required: false);
            return new DeferredBodyAction<SAPGetSAPGridViewCellPropertiesAtIndexResponse>(() =>
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
        public IWorkflowAction SAPDrawRectangleAroundSAPGridViewCellAtIndex(Expression<Func<string>> sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchSAPElementId, Expression<Func<int>> sAPDrawRectangleAroundSAPGridViewCellAtIndexrowIndex, Expression<Func<string>> sAPDrawRectangleAroundSAPGridViewCellAtIndexworkflow, Expression<Func<string>> sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnName = null, Expression<Func<string>> sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitle = null, Expression<Func<bool>> sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive = null, Expression<Func<string>> sAPDrawRectangleAroundSAPGridViewCellAtIndexpenColour = null, Expression<Func<int>> sAPDrawRectangleAroundSAPGridViewCellAtIndexpenThicknessPixels = null)
        {
            var __workflow_sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchSAPElementId = sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchSAPElementId, nameof(sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchSAPElementId), required: true);
            var __workflow_sAPDrawRectangleAroundSAPGridViewCellAtIndexrowIndex = sAPDrawRectangleAroundSAPGridViewCellAtIndexrowIndex == null ? null : WorkflowExpression.Compile(sAPDrawRectangleAroundSAPGridViewCellAtIndexrowIndex);
            WorkflowExpression.Validate(__workflow_sAPDrawRectangleAroundSAPGridViewCellAtIndexrowIndex, nameof(sAPDrawRectangleAroundSAPGridViewCellAtIndexrowIndex), required: true);
            var __workflow_sAPDrawRectangleAroundSAPGridViewCellAtIndexworkflow = sAPDrawRectangleAroundSAPGridViewCellAtIndexworkflow == null ? null : WorkflowExpression.Compile(sAPDrawRectangleAroundSAPGridViewCellAtIndexworkflow);
            WorkflowExpression.Validate(__workflow_sAPDrawRectangleAroundSAPGridViewCellAtIndexworkflow, nameof(sAPDrawRectangleAroundSAPGridViewCellAtIndexworkflow), required: true);
            var __workflow_sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnName = sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnName == null ? null : WorkflowExpression.Compile(sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnName);
            WorkflowExpression.Validate(__workflow_sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnName, nameof(sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnName), required: false);
            var __workflow_sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitle = sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitle == null ? null : WorkflowExpression.Compile(sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitle);
            WorkflowExpression.Validate(__workflow_sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitle, nameof(sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitle), required: false);
            var __workflow_sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression = sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression == null ? null : WorkflowExpression.Compile(sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression);
            WorkflowExpression.Validate(__workflow_sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression, nameof(sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression), required: false);
            var __workflow_sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive = sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive == null ? null : WorkflowExpression.Compile(sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive);
            WorkflowExpression.Validate(__workflow_sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive, nameof(sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive), required: false);
            var __workflow_sAPDrawRectangleAroundSAPGridViewCellAtIndexpenColour = sAPDrawRectangleAroundSAPGridViewCellAtIndexpenColour == null ? null : WorkflowExpression.Compile(sAPDrawRectangleAroundSAPGridViewCellAtIndexpenColour);
            WorkflowExpression.Validate(__workflow_sAPDrawRectangleAroundSAPGridViewCellAtIndexpenColour, nameof(sAPDrawRectangleAroundSAPGridViewCellAtIndexpenColour), required: false);
            var __workflow_sAPDrawRectangleAroundSAPGridViewCellAtIndexpenThicknessPixels = sAPDrawRectangleAroundSAPGridViewCellAtIndexpenThicknessPixels == null ? null : WorkflowExpression.Compile(sAPDrawRectangleAroundSAPGridViewCellAtIndexpenThicknessPixels);
            WorkflowExpression.Validate(__workflow_sAPDrawRectangleAroundSAPGridViewCellAtIndexpenThicknessPixels, nameof(sAPDrawRectangleAroundSAPGridViewCellAtIndexpenThicknessPixels), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction SAPGlobalLeftClickSAPGridViewCellAtIndex(Expression<Func<string>> sAPGlobalLeftClickSAPGridViewCellAtIndexsearchSAPElementId, Expression<Func<int>> sAPGlobalLeftClickSAPGridViewCellAtIndexrowIndex, Expression<Func<string>> sAPGlobalLeftClickSAPGridViewCellAtIndexworkflow, Expression<Func<string>> sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnName = null, Expression<Func<string>> sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitle = null, Expression<Func<bool>> sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive = null, Expression<Func<bool>> sAPGlobalLeftClickSAPGridViewCellAtIndexsetElementWindowTopMost = null, Expression<Func<bool>> sAPGlobalLeftClickSAPGridViewCellAtIndexbringElementWindowToFront = null, Expression<Func<bool>> sAPGlobalLeftClickSAPGridViewCellAtIndextoggleWindow = null, Expression<Func<bool>> sAPGlobalLeftClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent = null, Expression<Func<double>> sAPGlobalLeftClickSAPGridViewCellAtIndextoggleDelay = null, Expression<Func<int>> sAPGlobalLeftClickSAPGridViewCellAtIndexclickOffsetX = null, Expression<Func<int>> sAPGlobalLeftClickSAPGridViewCellAtIndexclickOffsetY = null, Expression<Func<sAPGlobalLeftClickSAPGridViewCellAtIndexoffsetRelativeToInput>> sAPGlobalLeftClickSAPGridViewCellAtIndexoffsetRelativeTo = null)
        {
            var __workflow_sAPGlobalLeftClickSAPGridViewCellAtIndexsearchSAPElementId = sAPGlobalLeftClickSAPGridViewCellAtIndexsearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPGlobalLeftClickSAPGridViewCellAtIndexsearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPGlobalLeftClickSAPGridViewCellAtIndexsearchSAPElementId, nameof(sAPGlobalLeftClickSAPGridViewCellAtIndexsearchSAPElementId), required: true);
            var __workflow_sAPGlobalLeftClickSAPGridViewCellAtIndexrowIndex = sAPGlobalLeftClickSAPGridViewCellAtIndexrowIndex == null ? null : WorkflowExpression.Compile(sAPGlobalLeftClickSAPGridViewCellAtIndexrowIndex);
            WorkflowExpression.Validate(__workflow_sAPGlobalLeftClickSAPGridViewCellAtIndexrowIndex, nameof(sAPGlobalLeftClickSAPGridViewCellAtIndexrowIndex), required: true);
            var __workflow_sAPGlobalLeftClickSAPGridViewCellAtIndexworkflow = sAPGlobalLeftClickSAPGridViewCellAtIndexworkflow == null ? null : WorkflowExpression.Compile(sAPGlobalLeftClickSAPGridViewCellAtIndexworkflow);
            WorkflowExpression.Validate(__workflow_sAPGlobalLeftClickSAPGridViewCellAtIndexworkflow, nameof(sAPGlobalLeftClickSAPGridViewCellAtIndexworkflow), required: true);
            var __workflow_sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnName = sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnName == null ? null : WorkflowExpression.Compile(sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnName);
            WorkflowExpression.Validate(__workflow_sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnName, nameof(sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnName), required: false);
            var __workflow_sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitle = sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitle == null ? null : WorkflowExpression.Compile(sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitle);
            WorkflowExpression.Validate(__workflow_sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitle, nameof(sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitle), required: false);
            var __workflow_sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression = sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression == null ? null : WorkflowExpression.Compile(sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression);
            WorkflowExpression.Validate(__workflow_sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression, nameof(sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression), required: false);
            var __workflow_sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive = sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive == null ? null : WorkflowExpression.Compile(sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive);
            WorkflowExpression.Validate(__workflow_sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive, nameof(sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive), required: false);
            var __workflow_sAPGlobalLeftClickSAPGridViewCellAtIndexsetElementWindowTopMost = sAPGlobalLeftClickSAPGridViewCellAtIndexsetElementWindowTopMost == null ? null : WorkflowExpression.Compile(sAPGlobalLeftClickSAPGridViewCellAtIndexsetElementWindowTopMost);
            WorkflowExpression.Validate(__workflow_sAPGlobalLeftClickSAPGridViewCellAtIndexsetElementWindowTopMost, nameof(sAPGlobalLeftClickSAPGridViewCellAtIndexsetElementWindowTopMost), required: false);
            var __workflow_sAPGlobalLeftClickSAPGridViewCellAtIndexbringElementWindowToFront = sAPGlobalLeftClickSAPGridViewCellAtIndexbringElementWindowToFront == null ? null : WorkflowExpression.Compile(sAPGlobalLeftClickSAPGridViewCellAtIndexbringElementWindowToFront);
            WorkflowExpression.Validate(__workflow_sAPGlobalLeftClickSAPGridViewCellAtIndexbringElementWindowToFront, nameof(sAPGlobalLeftClickSAPGridViewCellAtIndexbringElementWindowToFront), required: false);
            var __workflow_sAPGlobalLeftClickSAPGridViewCellAtIndextoggleWindow = sAPGlobalLeftClickSAPGridViewCellAtIndextoggleWindow == null ? null : WorkflowExpression.Compile(sAPGlobalLeftClickSAPGridViewCellAtIndextoggleWindow);
            WorkflowExpression.Validate(__workflow_sAPGlobalLeftClickSAPGridViewCellAtIndextoggleWindow, nameof(sAPGlobalLeftClickSAPGridViewCellAtIndextoggleWindow), required: false);
            var __workflow_sAPGlobalLeftClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent = sAPGlobalLeftClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent == null ? null : WorkflowExpression.Compile(sAPGlobalLeftClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent);
            WorkflowExpression.Validate(__workflow_sAPGlobalLeftClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent, nameof(sAPGlobalLeftClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent), required: false);
            var __workflow_sAPGlobalLeftClickSAPGridViewCellAtIndextoggleDelay = sAPGlobalLeftClickSAPGridViewCellAtIndextoggleDelay == null ? null : WorkflowExpression.Compile(sAPGlobalLeftClickSAPGridViewCellAtIndextoggleDelay);
            WorkflowExpression.Validate(__workflow_sAPGlobalLeftClickSAPGridViewCellAtIndextoggleDelay, nameof(sAPGlobalLeftClickSAPGridViewCellAtIndextoggleDelay), required: false);
            var __workflow_sAPGlobalLeftClickSAPGridViewCellAtIndexclickOffsetX = sAPGlobalLeftClickSAPGridViewCellAtIndexclickOffsetX == null ? null : WorkflowExpression.Compile(sAPGlobalLeftClickSAPGridViewCellAtIndexclickOffsetX);
            WorkflowExpression.Validate(__workflow_sAPGlobalLeftClickSAPGridViewCellAtIndexclickOffsetX, nameof(sAPGlobalLeftClickSAPGridViewCellAtIndexclickOffsetX), required: false);
            var __workflow_sAPGlobalLeftClickSAPGridViewCellAtIndexclickOffsetY = sAPGlobalLeftClickSAPGridViewCellAtIndexclickOffsetY == null ? null : WorkflowExpression.Compile(sAPGlobalLeftClickSAPGridViewCellAtIndexclickOffsetY);
            WorkflowExpression.Validate(__workflow_sAPGlobalLeftClickSAPGridViewCellAtIndexclickOffsetY, nameof(sAPGlobalLeftClickSAPGridViewCellAtIndexclickOffsetY), required: false);
            var __workflow_sAPGlobalLeftClickSAPGridViewCellAtIndexoffsetRelativeTo = sAPGlobalLeftClickSAPGridViewCellAtIndexoffsetRelativeTo == null ? null : WorkflowExpression.Compile(sAPGlobalLeftClickSAPGridViewCellAtIndexoffsetRelativeTo);
            WorkflowExpression.Validate(__workflow_sAPGlobalLeftClickSAPGridViewCellAtIndexoffsetRelativeTo, nameof(sAPGlobalLeftClickSAPGridViewCellAtIndexoffsetRelativeTo), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction SAPGlobalRightClickSAPGridViewCellAtIndex(Expression<Func<string>> sAPGlobalRightClickSAPGridViewCellAtIndexsearchSAPElementId, Expression<Func<int>> sAPGlobalRightClickSAPGridViewCellAtIndexrowIndex, Expression<Func<string>> sAPGlobalRightClickSAPGridViewCellAtIndexworkflow, Expression<Func<string>> sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnName = null, Expression<Func<string>> sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitle = null, Expression<Func<bool>> sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive = null, Expression<Func<bool>> sAPGlobalRightClickSAPGridViewCellAtIndexsetElementWindowTopMost = null, Expression<Func<bool>> sAPGlobalRightClickSAPGridViewCellAtIndexbringElementWindowToFront = null, Expression<Func<bool>> sAPGlobalRightClickSAPGridViewCellAtIndextoggleWindow = null, Expression<Func<bool>> sAPGlobalRightClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent = null, Expression<Func<double>> sAPGlobalRightClickSAPGridViewCellAtIndextoggleDelay = null, Expression<Func<int>> sAPGlobalRightClickSAPGridViewCellAtIndexclickOffsetX = null, Expression<Func<int>> sAPGlobalRightClickSAPGridViewCellAtIndexclickOffsetY = null, Expression<Func<sAPGlobalRightClickSAPGridViewCellAtIndexoffsetRelativeToInput>> sAPGlobalRightClickSAPGridViewCellAtIndexoffsetRelativeTo = null)
        {
            var __workflow_sAPGlobalRightClickSAPGridViewCellAtIndexsearchSAPElementId = sAPGlobalRightClickSAPGridViewCellAtIndexsearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPGlobalRightClickSAPGridViewCellAtIndexsearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPGlobalRightClickSAPGridViewCellAtIndexsearchSAPElementId, nameof(sAPGlobalRightClickSAPGridViewCellAtIndexsearchSAPElementId), required: true);
            var __workflow_sAPGlobalRightClickSAPGridViewCellAtIndexrowIndex = sAPGlobalRightClickSAPGridViewCellAtIndexrowIndex == null ? null : WorkflowExpression.Compile(sAPGlobalRightClickSAPGridViewCellAtIndexrowIndex);
            WorkflowExpression.Validate(__workflow_sAPGlobalRightClickSAPGridViewCellAtIndexrowIndex, nameof(sAPGlobalRightClickSAPGridViewCellAtIndexrowIndex), required: true);
            var __workflow_sAPGlobalRightClickSAPGridViewCellAtIndexworkflow = sAPGlobalRightClickSAPGridViewCellAtIndexworkflow == null ? null : WorkflowExpression.Compile(sAPGlobalRightClickSAPGridViewCellAtIndexworkflow);
            WorkflowExpression.Validate(__workflow_sAPGlobalRightClickSAPGridViewCellAtIndexworkflow, nameof(sAPGlobalRightClickSAPGridViewCellAtIndexworkflow), required: true);
            var __workflow_sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnName = sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnName == null ? null : WorkflowExpression.Compile(sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnName);
            WorkflowExpression.Validate(__workflow_sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnName, nameof(sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnName), required: false);
            var __workflow_sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitle = sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitle == null ? null : WorkflowExpression.Compile(sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitle);
            WorkflowExpression.Validate(__workflow_sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitle, nameof(sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitle), required: false);
            var __workflow_sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression = sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression == null ? null : WorkflowExpression.Compile(sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression);
            WorkflowExpression.Validate(__workflow_sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression, nameof(sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression), required: false);
            var __workflow_sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive = sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive == null ? null : WorkflowExpression.Compile(sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive);
            WorkflowExpression.Validate(__workflow_sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive, nameof(sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive), required: false);
            var __workflow_sAPGlobalRightClickSAPGridViewCellAtIndexsetElementWindowTopMost = sAPGlobalRightClickSAPGridViewCellAtIndexsetElementWindowTopMost == null ? null : WorkflowExpression.Compile(sAPGlobalRightClickSAPGridViewCellAtIndexsetElementWindowTopMost);
            WorkflowExpression.Validate(__workflow_sAPGlobalRightClickSAPGridViewCellAtIndexsetElementWindowTopMost, nameof(sAPGlobalRightClickSAPGridViewCellAtIndexsetElementWindowTopMost), required: false);
            var __workflow_sAPGlobalRightClickSAPGridViewCellAtIndexbringElementWindowToFront = sAPGlobalRightClickSAPGridViewCellAtIndexbringElementWindowToFront == null ? null : WorkflowExpression.Compile(sAPGlobalRightClickSAPGridViewCellAtIndexbringElementWindowToFront);
            WorkflowExpression.Validate(__workflow_sAPGlobalRightClickSAPGridViewCellAtIndexbringElementWindowToFront, nameof(sAPGlobalRightClickSAPGridViewCellAtIndexbringElementWindowToFront), required: false);
            var __workflow_sAPGlobalRightClickSAPGridViewCellAtIndextoggleWindow = sAPGlobalRightClickSAPGridViewCellAtIndextoggleWindow == null ? null : WorkflowExpression.Compile(sAPGlobalRightClickSAPGridViewCellAtIndextoggleWindow);
            WorkflowExpression.Validate(__workflow_sAPGlobalRightClickSAPGridViewCellAtIndextoggleWindow, nameof(sAPGlobalRightClickSAPGridViewCellAtIndextoggleWindow), required: false);
            var __workflow_sAPGlobalRightClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent = sAPGlobalRightClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent == null ? null : WorkflowExpression.Compile(sAPGlobalRightClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent);
            WorkflowExpression.Validate(__workflow_sAPGlobalRightClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent, nameof(sAPGlobalRightClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent), required: false);
            var __workflow_sAPGlobalRightClickSAPGridViewCellAtIndextoggleDelay = sAPGlobalRightClickSAPGridViewCellAtIndextoggleDelay == null ? null : WorkflowExpression.Compile(sAPGlobalRightClickSAPGridViewCellAtIndextoggleDelay);
            WorkflowExpression.Validate(__workflow_sAPGlobalRightClickSAPGridViewCellAtIndextoggleDelay, nameof(sAPGlobalRightClickSAPGridViewCellAtIndextoggleDelay), required: false);
            var __workflow_sAPGlobalRightClickSAPGridViewCellAtIndexclickOffsetX = sAPGlobalRightClickSAPGridViewCellAtIndexclickOffsetX == null ? null : WorkflowExpression.Compile(sAPGlobalRightClickSAPGridViewCellAtIndexclickOffsetX);
            WorkflowExpression.Validate(__workflow_sAPGlobalRightClickSAPGridViewCellAtIndexclickOffsetX, nameof(sAPGlobalRightClickSAPGridViewCellAtIndexclickOffsetX), required: false);
            var __workflow_sAPGlobalRightClickSAPGridViewCellAtIndexclickOffsetY = sAPGlobalRightClickSAPGridViewCellAtIndexclickOffsetY == null ? null : WorkflowExpression.Compile(sAPGlobalRightClickSAPGridViewCellAtIndexclickOffsetY);
            WorkflowExpression.Validate(__workflow_sAPGlobalRightClickSAPGridViewCellAtIndexclickOffsetY, nameof(sAPGlobalRightClickSAPGridViewCellAtIndexclickOffsetY), required: false);
            var __workflow_sAPGlobalRightClickSAPGridViewCellAtIndexoffsetRelativeTo = sAPGlobalRightClickSAPGridViewCellAtIndexoffsetRelativeTo == null ? null : WorkflowExpression.Compile(sAPGlobalRightClickSAPGridViewCellAtIndexoffsetRelativeTo);
            WorkflowExpression.Validate(__workflow_sAPGlobalRightClickSAPGridViewCellAtIndexoffsetRelativeTo, nameof(sAPGlobalRightClickSAPGridViewCellAtIndexoffsetRelativeTo), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction SAPGlobalDoubleLeftClickSAPGridViewCellAtIndex(Expression<Func<string>> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchSAPElementId, Expression<Func<int>> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexrowIndex, Expression<Func<string>> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexworkflow, Expression<Func<string>> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnName = null, Expression<Func<string>> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitle = null, Expression<Func<bool>> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive = null, Expression<Func<bool>> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsetElementWindowTopMost = null, Expression<Func<bool>> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexbringElementWindowToFront = null, Expression<Func<bool>> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleWindow = null, Expression<Func<bool>> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent = null, Expression<Func<double>> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleDelay = null, Expression<Func<int>> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexclickOffsetX = null, Expression<Func<int>> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexclickOffsetY = null, Expression<Func<sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexoffsetRelativeToInput>> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexoffsetRelativeTo = null, Expression<Func<int>> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexdoubleClickDelayInMilliseconds = null)
        {
            var __workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchSAPElementId = sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchSAPElementId, nameof(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchSAPElementId), required: true);
            var __workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexrowIndex = sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexrowIndex == null ? null : WorkflowExpression.Compile(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexrowIndex);
            WorkflowExpression.Validate(__workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexrowIndex, nameof(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexrowIndex), required: true);
            var __workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexworkflow = sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexworkflow == null ? null : WorkflowExpression.Compile(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexworkflow);
            WorkflowExpression.Validate(__workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexworkflow, nameof(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexworkflow), required: true);
            var __workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnName = sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnName == null ? null : WorkflowExpression.Compile(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnName);
            WorkflowExpression.Validate(__workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnName, nameof(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnName), required: false);
            var __workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitle = sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitle == null ? null : WorkflowExpression.Compile(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitle);
            WorkflowExpression.Validate(__workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitle, nameof(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitle), required: false);
            var __workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression = sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression == null ? null : WorkflowExpression.Compile(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression);
            WorkflowExpression.Validate(__workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression, nameof(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression), required: false);
            var __workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive = sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive == null ? null : WorkflowExpression.Compile(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive);
            WorkflowExpression.Validate(__workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive, nameof(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive), required: false);
            var __workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsetElementWindowTopMost = sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsetElementWindowTopMost == null ? null : WorkflowExpression.Compile(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsetElementWindowTopMost);
            WorkflowExpression.Validate(__workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsetElementWindowTopMost, nameof(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsetElementWindowTopMost), required: false);
            var __workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexbringElementWindowToFront = sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexbringElementWindowToFront == null ? null : WorkflowExpression.Compile(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexbringElementWindowToFront);
            WorkflowExpression.Validate(__workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexbringElementWindowToFront, nameof(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexbringElementWindowToFront), required: false);
            var __workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleWindow = sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleWindow == null ? null : WorkflowExpression.Compile(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleWindow);
            WorkflowExpression.Validate(__workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleWindow, nameof(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleWindow), required: false);
            var __workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent = sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent == null ? null : WorkflowExpression.Compile(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent);
            WorkflowExpression.Validate(__workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent, nameof(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent), required: false);
            var __workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleDelay = sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleDelay == null ? null : WorkflowExpression.Compile(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleDelay);
            WorkflowExpression.Validate(__workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleDelay, nameof(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleDelay), required: false);
            var __workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexclickOffsetX = sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexclickOffsetX == null ? null : WorkflowExpression.Compile(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexclickOffsetX);
            WorkflowExpression.Validate(__workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexclickOffsetX, nameof(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexclickOffsetX), required: false);
            var __workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexclickOffsetY = sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexclickOffsetY == null ? null : WorkflowExpression.Compile(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexclickOffsetY);
            WorkflowExpression.Validate(__workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexclickOffsetY, nameof(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexclickOffsetY), required: false);
            var __workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexoffsetRelativeTo = sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexoffsetRelativeTo == null ? null : WorkflowExpression.Compile(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexoffsetRelativeTo);
            WorkflowExpression.Validate(__workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexoffsetRelativeTo, nameof(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexoffsetRelativeTo), required: false);
            var __workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexdoubleClickDelayInMilliseconds = sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexdoubleClickDelayInMilliseconds == null ? null : WorkflowExpression.Compile(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexdoubleClickDelayInMilliseconds);
            WorkflowExpression.Validate(__workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexdoubleClickDelayInMilliseconds, nameof(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexdoubleClickDelayInMilliseconds), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IBodyWorkflowAction<SAPGetSAPGridViewColumnHeadersResponse> SAPGetSAPGridViewColumnHeaders(Expression<Func<string>> sAPGetSAPGridViewColumnHeaderssearchSAPElementId, Expression<Func<string>> sAPGetSAPGridViewColumnHeadersworkflow)
        {
            var __workflow_sAPGetSAPGridViewColumnHeaderssearchSAPElementId = sAPGetSAPGridViewColumnHeaderssearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPGetSAPGridViewColumnHeaderssearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPGetSAPGridViewColumnHeaderssearchSAPElementId, nameof(sAPGetSAPGridViewColumnHeaderssearchSAPElementId), required: true);
            var __workflow_sAPGetSAPGridViewColumnHeadersworkflow = sAPGetSAPGridViewColumnHeadersworkflow == null ? null : WorkflowExpression.Compile(sAPGetSAPGridViewColumnHeadersworkflow);
            WorkflowExpression.Validate(__workflow_sAPGetSAPGridViewColumnHeadersworkflow, nameof(sAPGetSAPGridViewColumnHeadersworkflow), required: true);
            return new DeferredBodyAction<SAPGetSAPGridViewColumnHeadersResponse>(() =>
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
        public IWorkflowAction SAPClickSAPGridViewCellAtIndex(Expression<Func<string>> sAPClickSAPGridViewCellAtIndexsearchSAPElementId, Expression<Func<int>> sAPClickSAPGridViewCellAtIndexrowIndex, Expression<Func<string>> sAPClickSAPGridViewCellAtIndexworkflow, Expression<Func<string>> sAPClickSAPGridViewCellAtIndexsearchColumnName = null, Expression<Func<string>> sAPClickSAPGridViewCellAtIndexsearchColumnTitle = null, Expression<Func<bool>> sAPClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive = null)
        {
            var __workflow_sAPClickSAPGridViewCellAtIndexsearchSAPElementId = sAPClickSAPGridViewCellAtIndexsearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPClickSAPGridViewCellAtIndexsearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPClickSAPGridViewCellAtIndexsearchSAPElementId, nameof(sAPClickSAPGridViewCellAtIndexsearchSAPElementId), required: true);
            var __workflow_sAPClickSAPGridViewCellAtIndexrowIndex = sAPClickSAPGridViewCellAtIndexrowIndex == null ? null : WorkflowExpression.Compile(sAPClickSAPGridViewCellAtIndexrowIndex);
            WorkflowExpression.Validate(__workflow_sAPClickSAPGridViewCellAtIndexrowIndex, nameof(sAPClickSAPGridViewCellAtIndexrowIndex), required: true);
            var __workflow_sAPClickSAPGridViewCellAtIndexworkflow = sAPClickSAPGridViewCellAtIndexworkflow == null ? null : WorkflowExpression.Compile(sAPClickSAPGridViewCellAtIndexworkflow);
            WorkflowExpression.Validate(__workflow_sAPClickSAPGridViewCellAtIndexworkflow, nameof(sAPClickSAPGridViewCellAtIndexworkflow), required: true);
            var __workflow_sAPClickSAPGridViewCellAtIndexsearchColumnName = sAPClickSAPGridViewCellAtIndexsearchColumnName == null ? null : WorkflowExpression.Compile(sAPClickSAPGridViewCellAtIndexsearchColumnName);
            WorkflowExpression.Validate(__workflow_sAPClickSAPGridViewCellAtIndexsearchColumnName, nameof(sAPClickSAPGridViewCellAtIndexsearchColumnName), required: false);
            var __workflow_sAPClickSAPGridViewCellAtIndexsearchColumnTitle = sAPClickSAPGridViewCellAtIndexsearchColumnTitle == null ? null : WorkflowExpression.Compile(sAPClickSAPGridViewCellAtIndexsearchColumnTitle);
            WorkflowExpression.Validate(__workflow_sAPClickSAPGridViewCellAtIndexsearchColumnTitle, nameof(sAPClickSAPGridViewCellAtIndexsearchColumnTitle), required: false);
            var __workflow_sAPClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression = sAPClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression == null ? null : WorkflowExpression.Compile(sAPClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression);
            WorkflowExpression.Validate(__workflow_sAPClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression, nameof(sAPClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression), required: false);
            var __workflow_sAPClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive = sAPClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive == null ? null : WorkflowExpression.Compile(sAPClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive);
            WorkflowExpression.Validate(__workflow_sAPClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive, nameof(sAPClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction SAPDoubleClickSAPGridViewCellAtIndex(Expression<Func<string>> sAPDoubleClickSAPGridViewCellAtIndexsearchSAPElementId, Expression<Func<int>> sAPDoubleClickSAPGridViewCellAtIndexrowIndex, Expression<Func<string>> sAPDoubleClickSAPGridViewCellAtIndexworkflow, Expression<Func<string>> sAPDoubleClickSAPGridViewCellAtIndexsearchColumnName = null, Expression<Func<string>> sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitle = null, Expression<Func<bool>> sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive = null)
        {
            var __workflow_sAPDoubleClickSAPGridViewCellAtIndexsearchSAPElementId = sAPDoubleClickSAPGridViewCellAtIndexsearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPDoubleClickSAPGridViewCellAtIndexsearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPDoubleClickSAPGridViewCellAtIndexsearchSAPElementId, nameof(sAPDoubleClickSAPGridViewCellAtIndexsearchSAPElementId), required: true);
            var __workflow_sAPDoubleClickSAPGridViewCellAtIndexrowIndex = sAPDoubleClickSAPGridViewCellAtIndexrowIndex == null ? null : WorkflowExpression.Compile(sAPDoubleClickSAPGridViewCellAtIndexrowIndex);
            WorkflowExpression.Validate(__workflow_sAPDoubleClickSAPGridViewCellAtIndexrowIndex, nameof(sAPDoubleClickSAPGridViewCellAtIndexrowIndex), required: true);
            var __workflow_sAPDoubleClickSAPGridViewCellAtIndexworkflow = sAPDoubleClickSAPGridViewCellAtIndexworkflow == null ? null : WorkflowExpression.Compile(sAPDoubleClickSAPGridViewCellAtIndexworkflow);
            WorkflowExpression.Validate(__workflow_sAPDoubleClickSAPGridViewCellAtIndexworkflow, nameof(sAPDoubleClickSAPGridViewCellAtIndexworkflow), required: true);
            var __workflow_sAPDoubleClickSAPGridViewCellAtIndexsearchColumnName = sAPDoubleClickSAPGridViewCellAtIndexsearchColumnName == null ? null : WorkflowExpression.Compile(sAPDoubleClickSAPGridViewCellAtIndexsearchColumnName);
            WorkflowExpression.Validate(__workflow_sAPDoubleClickSAPGridViewCellAtIndexsearchColumnName, nameof(sAPDoubleClickSAPGridViewCellAtIndexsearchColumnName), required: false);
            var __workflow_sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitle = sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitle == null ? null : WorkflowExpression.Compile(sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitle);
            WorkflowExpression.Validate(__workflow_sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitle, nameof(sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitle), required: false);
            var __workflow_sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression = sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression == null ? null : WorkflowExpression.Compile(sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression);
            WorkflowExpression.Validate(__workflow_sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression, nameof(sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression), required: false);
            var __workflow_sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive = sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive == null ? null : WorkflowExpression.Compile(sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive);
            WorkflowExpression.Validate(__workflow_sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive, nameof(sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction SAPPressSAPGridViewCellButtonAtIndex(Expression<Func<string>> sAPPressSAPGridViewCellButtonAtIndexsearchSAPElementId, Expression<Func<int>> sAPPressSAPGridViewCellButtonAtIndexrowIndex, Expression<Func<string>> sAPPressSAPGridViewCellButtonAtIndexworkflow, Expression<Func<string>> sAPPressSAPGridViewCellButtonAtIndexsearchColumnName = null, Expression<Func<string>> sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitle = null, Expression<Func<bool>> sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitleIsCaseSensitive = null)
        {
            var __workflow_sAPPressSAPGridViewCellButtonAtIndexsearchSAPElementId = sAPPressSAPGridViewCellButtonAtIndexsearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPPressSAPGridViewCellButtonAtIndexsearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPPressSAPGridViewCellButtonAtIndexsearchSAPElementId, nameof(sAPPressSAPGridViewCellButtonAtIndexsearchSAPElementId), required: true);
            var __workflow_sAPPressSAPGridViewCellButtonAtIndexrowIndex = sAPPressSAPGridViewCellButtonAtIndexrowIndex == null ? null : WorkflowExpression.Compile(sAPPressSAPGridViewCellButtonAtIndexrowIndex);
            WorkflowExpression.Validate(__workflow_sAPPressSAPGridViewCellButtonAtIndexrowIndex, nameof(sAPPressSAPGridViewCellButtonAtIndexrowIndex), required: true);
            var __workflow_sAPPressSAPGridViewCellButtonAtIndexworkflow = sAPPressSAPGridViewCellButtonAtIndexworkflow == null ? null : WorkflowExpression.Compile(sAPPressSAPGridViewCellButtonAtIndexworkflow);
            WorkflowExpression.Validate(__workflow_sAPPressSAPGridViewCellButtonAtIndexworkflow, nameof(sAPPressSAPGridViewCellButtonAtIndexworkflow), required: true);
            var __workflow_sAPPressSAPGridViewCellButtonAtIndexsearchColumnName = sAPPressSAPGridViewCellButtonAtIndexsearchColumnName == null ? null : WorkflowExpression.Compile(sAPPressSAPGridViewCellButtonAtIndexsearchColumnName);
            WorkflowExpression.Validate(__workflow_sAPPressSAPGridViewCellButtonAtIndexsearchColumnName, nameof(sAPPressSAPGridViewCellButtonAtIndexsearchColumnName), required: false);
            var __workflow_sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitle = sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitle == null ? null : WorkflowExpression.Compile(sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitle);
            WorkflowExpression.Validate(__workflow_sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitle, nameof(sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitle), required: false);
            var __workflow_sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitleIsRegularExpression = sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitleIsRegularExpression == null ? null : WorkflowExpression.Compile(sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitleIsRegularExpression);
            WorkflowExpression.Validate(__workflow_sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitleIsRegularExpression, nameof(sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitleIsRegularExpression), required: false);
            var __workflow_sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitleIsCaseSensitive = sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitleIsCaseSensitive == null ? null : WorkflowExpression.Compile(sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitleIsCaseSensitive);
            WorkflowExpression.Validate(__workflow_sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitleIsCaseSensitive, nameof(sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitleIsCaseSensitive), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction SAPCheckSAPGridViewCellCheckboxAtIndex(Expression<Func<string>> sAPCheckSAPGridViewCellCheckboxAtIndexsearchSAPElementId, Expression<Func<int>> sAPCheckSAPGridViewCellCheckboxAtIndexrowIndex, Expression<Func<string>> sAPCheckSAPGridViewCellCheckboxAtIndexworkflow, Expression<Func<string>> sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnName = null, Expression<Func<string>> sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitle = null, Expression<Func<bool>> sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitleIsCaseSensitive = null, Expression<Func<bool>> sAPCheckSAPGridViewCellCheckboxAtIndexcheckCellElement = null)
        {
            var __workflow_sAPCheckSAPGridViewCellCheckboxAtIndexsearchSAPElementId = sAPCheckSAPGridViewCellCheckboxAtIndexsearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPCheckSAPGridViewCellCheckboxAtIndexsearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPCheckSAPGridViewCellCheckboxAtIndexsearchSAPElementId, nameof(sAPCheckSAPGridViewCellCheckboxAtIndexsearchSAPElementId), required: true);
            var __workflow_sAPCheckSAPGridViewCellCheckboxAtIndexrowIndex = sAPCheckSAPGridViewCellCheckboxAtIndexrowIndex == null ? null : WorkflowExpression.Compile(sAPCheckSAPGridViewCellCheckboxAtIndexrowIndex);
            WorkflowExpression.Validate(__workflow_sAPCheckSAPGridViewCellCheckboxAtIndexrowIndex, nameof(sAPCheckSAPGridViewCellCheckboxAtIndexrowIndex), required: true);
            var __workflow_sAPCheckSAPGridViewCellCheckboxAtIndexworkflow = sAPCheckSAPGridViewCellCheckboxAtIndexworkflow == null ? null : WorkflowExpression.Compile(sAPCheckSAPGridViewCellCheckboxAtIndexworkflow);
            WorkflowExpression.Validate(__workflow_sAPCheckSAPGridViewCellCheckboxAtIndexworkflow, nameof(sAPCheckSAPGridViewCellCheckboxAtIndexworkflow), required: true);
            var __workflow_sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnName = sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnName == null ? null : WorkflowExpression.Compile(sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnName);
            WorkflowExpression.Validate(__workflow_sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnName, nameof(sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnName), required: false);
            var __workflow_sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitle = sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitle == null ? null : WorkflowExpression.Compile(sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitle);
            WorkflowExpression.Validate(__workflow_sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitle, nameof(sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitle), required: false);
            var __workflow_sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitleIsRegularExpression = sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitleIsRegularExpression == null ? null : WorkflowExpression.Compile(sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitleIsRegularExpression);
            WorkflowExpression.Validate(__workflow_sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitleIsRegularExpression, nameof(sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitleIsRegularExpression), required: false);
            var __workflow_sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitleIsCaseSensitive = sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitleIsCaseSensitive == null ? null : WorkflowExpression.Compile(sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitleIsCaseSensitive);
            WorkflowExpression.Validate(__workflow_sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitleIsCaseSensitive, nameof(sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitleIsCaseSensitive), required: false);
            var __workflow_sAPCheckSAPGridViewCellCheckboxAtIndexcheckCellElement = sAPCheckSAPGridViewCellCheckboxAtIndexcheckCellElement == null ? null : WorkflowExpression.Compile(sAPCheckSAPGridViewCellCheckboxAtIndexcheckCellElement);
            WorkflowExpression.Validate(__workflow_sAPCheckSAPGridViewCellCheckboxAtIndexcheckCellElement, nameof(sAPCheckSAPGridViewCellCheckboxAtIndexcheckCellElement), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IBodyWorkflowAction<SAPModifySAPGridViewCellAtIndexResponse> SAPModifySAPGridViewCellAtIndex(Expression<Func<string>> sAPModifySAPGridViewCellAtIndexsearchSAPElementId, Expression<Func<int>> sAPModifySAPGridViewCellAtIndexrowIndex, Expression<Func<string>> sAPModifySAPGridViewCellAtIndexworkflow, Expression<Func<string>> sAPModifySAPGridViewCellAtIndexsearchColumnName = null, Expression<Func<string>> sAPModifySAPGridViewCellAtIndexsearchColumnTitle = null, Expression<Func<bool>> sAPModifySAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPModifySAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive = null, Expression<Func<string>> sAPModifySAPGridViewCellAtIndexnewValue = null)
        {
            var __workflow_sAPModifySAPGridViewCellAtIndexsearchSAPElementId = sAPModifySAPGridViewCellAtIndexsearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPModifySAPGridViewCellAtIndexsearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPModifySAPGridViewCellAtIndexsearchSAPElementId, nameof(sAPModifySAPGridViewCellAtIndexsearchSAPElementId), required: true);
            var __workflow_sAPModifySAPGridViewCellAtIndexrowIndex = sAPModifySAPGridViewCellAtIndexrowIndex == null ? null : WorkflowExpression.Compile(sAPModifySAPGridViewCellAtIndexrowIndex);
            WorkflowExpression.Validate(__workflow_sAPModifySAPGridViewCellAtIndexrowIndex, nameof(sAPModifySAPGridViewCellAtIndexrowIndex), required: true);
            var __workflow_sAPModifySAPGridViewCellAtIndexworkflow = sAPModifySAPGridViewCellAtIndexworkflow == null ? null : WorkflowExpression.Compile(sAPModifySAPGridViewCellAtIndexworkflow);
            WorkflowExpression.Validate(__workflow_sAPModifySAPGridViewCellAtIndexworkflow, nameof(sAPModifySAPGridViewCellAtIndexworkflow), required: true);
            var __workflow_sAPModifySAPGridViewCellAtIndexsearchColumnName = sAPModifySAPGridViewCellAtIndexsearchColumnName == null ? null : WorkflowExpression.Compile(sAPModifySAPGridViewCellAtIndexsearchColumnName);
            WorkflowExpression.Validate(__workflow_sAPModifySAPGridViewCellAtIndexsearchColumnName, nameof(sAPModifySAPGridViewCellAtIndexsearchColumnName), required: false);
            var __workflow_sAPModifySAPGridViewCellAtIndexsearchColumnTitle = sAPModifySAPGridViewCellAtIndexsearchColumnTitle == null ? null : WorkflowExpression.Compile(sAPModifySAPGridViewCellAtIndexsearchColumnTitle);
            WorkflowExpression.Validate(__workflow_sAPModifySAPGridViewCellAtIndexsearchColumnTitle, nameof(sAPModifySAPGridViewCellAtIndexsearchColumnTitle), required: false);
            var __workflow_sAPModifySAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression = sAPModifySAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression == null ? null : WorkflowExpression.Compile(sAPModifySAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression);
            WorkflowExpression.Validate(__workflow_sAPModifySAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression, nameof(sAPModifySAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression), required: false);
            var __workflow_sAPModifySAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive = sAPModifySAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive == null ? null : WorkflowExpression.Compile(sAPModifySAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive);
            WorkflowExpression.Validate(__workflow_sAPModifySAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive, nameof(sAPModifySAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive), required: false);
            var __workflow_sAPModifySAPGridViewCellAtIndexnewValue = sAPModifySAPGridViewCellAtIndexnewValue == null ? null : WorkflowExpression.Compile(sAPModifySAPGridViewCellAtIndexnewValue);
            WorkflowExpression.Validate(__workflow_sAPModifySAPGridViewCellAtIndexnewValue, nameof(sAPModifySAPGridViewCellAtIndexnewValue), required: false);
            return new DeferredBodyAction<SAPModifySAPGridViewCellAtIndexResponse>(() =>
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
        public IWorkflowAction SAPSetSAPGridViewCurrentRow(Expression<Func<string>> sAPSetSAPGridViewCurrentRowsearchSAPElementId, Expression<Func<int>> sAPSetSAPGridViewCurrentRowrowIndex, Expression<Func<string>> sAPSetSAPGridViewCurrentRowworkflow)
        {
            var __workflow_sAPSetSAPGridViewCurrentRowsearchSAPElementId = sAPSetSAPGridViewCurrentRowsearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPSetSAPGridViewCurrentRowsearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPSetSAPGridViewCurrentRowsearchSAPElementId, nameof(sAPSetSAPGridViewCurrentRowsearchSAPElementId), required: true);
            var __workflow_sAPSetSAPGridViewCurrentRowrowIndex = sAPSetSAPGridViewCurrentRowrowIndex == null ? null : WorkflowExpression.Compile(sAPSetSAPGridViewCurrentRowrowIndex);
            WorkflowExpression.Validate(__workflow_sAPSetSAPGridViewCurrentRowrowIndex, nameof(sAPSetSAPGridViewCurrentRowrowIndex), required: true);
            var __workflow_sAPSetSAPGridViewCurrentRowworkflow = sAPSetSAPGridViewCurrentRowworkflow == null ? null : WorkflowExpression.Compile(sAPSetSAPGridViewCurrentRowworkflow);
            WorkflowExpression.Validate(__workflow_sAPSetSAPGridViewCurrentRowworkflow, nameof(sAPSetSAPGridViewCurrentRowworkflow), required: true);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction SAPPressSAPGridViewColumnHeader(Expression<Func<string>> sAPPressSAPGridViewColumnHeadersearchSAPElementId, Expression<Func<string>> sAPPressSAPGridViewColumnHeaderworkflow, Expression<Func<string>> sAPPressSAPGridViewColumnHeadersearchColumnName = null, Expression<Func<string>> sAPPressSAPGridViewColumnHeadersearchColumnTitle = null, Expression<Func<bool>> sAPPressSAPGridViewColumnHeadersearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPPressSAPGridViewColumnHeadersearchColumnTitleIsCaseSensitive = null)
        {
            var __workflow_sAPPressSAPGridViewColumnHeadersearchSAPElementId = sAPPressSAPGridViewColumnHeadersearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPPressSAPGridViewColumnHeadersearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPPressSAPGridViewColumnHeadersearchSAPElementId, nameof(sAPPressSAPGridViewColumnHeadersearchSAPElementId), required: true);
            var __workflow_sAPPressSAPGridViewColumnHeaderworkflow = sAPPressSAPGridViewColumnHeaderworkflow == null ? null : WorkflowExpression.Compile(sAPPressSAPGridViewColumnHeaderworkflow);
            WorkflowExpression.Validate(__workflow_sAPPressSAPGridViewColumnHeaderworkflow, nameof(sAPPressSAPGridViewColumnHeaderworkflow), required: true);
            var __workflow_sAPPressSAPGridViewColumnHeadersearchColumnName = sAPPressSAPGridViewColumnHeadersearchColumnName == null ? null : WorkflowExpression.Compile(sAPPressSAPGridViewColumnHeadersearchColumnName);
            WorkflowExpression.Validate(__workflow_sAPPressSAPGridViewColumnHeadersearchColumnName, nameof(sAPPressSAPGridViewColumnHeadersearchColumnName), required: false);
            var __workflow_sAPPressSAPGridViewColumnHeadersearchColumnTitle = sAPPressSAPGridViewColumnHeadersearchColumnTitle == null ? null : WorkflowExpression.Compile(sAPPressSAPGridViewColumnHeadersearchColumnTitle);
            WorkflowExpression.Validate(__workflow_sAPPressSAPGridViewColumnHeadersearchColumnTitle, nameof(sAPPressSAPGridViewColumnHeadersearchColumnTitle), required: false);
            var __workflow_sAPPressSAPGridViewColumnHeadersearchColumnTitleIsRegularExpression = sAPPressSAPGridViewColumnHeadersearchColumnTitleIsRegularExpression == null ? null : WorkflowExpression.Compile(sAPPressSAPGridViewColumnHeadersearchColumnTitleIsRegularExpression);
            WorkflowExpression.Validate(__workflow_sAPPressSAPGridViewColumnHeadersearchColumnTitleIsRegularExpression, nameof(sAPPressSAPGridViewColumnHeadersearchColumnTitleIsRegularExpression), required: false);
            var __workflow_sAPPressSAPGridViewColumnHeadersearchColumnTitleIsCaseSensitive = sAPPressSAPGridViewColumnHeadersearchColumnTitleIsCaseSensitive == null ? null : WorkflowExpression.Compile(sAPPressSAPGridViewColumnHeadersearchColumnTitleIsCaseSensitive);
            WorkflowExpression.Validate(__workflow_sAPPressSAPGridViewColumnHeadersearchColumnTitleIsCaseSensitive, nameof(sAPPressSAPGridViewColumnHeadersearchColumnTitleIsCaseSensitive), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IBodyWorkflowAction<SAPSetSAPGridViewFirstVisibleRowResponse> SAPSetSAPGridViewFirstVisibleRow(Expression<Func<string>> sAPSetSAPGridViewFirstVisibleRowsearchSAPElementId, Expression<Func<int>> sAPSetSAPGridViewFirstVisibleRowfirstVisibleRowIndex, Expression<Func<string>> sAPSetSAPGridViewFirstVisibleRowworkflow)
        {
            var __workflow_sAPSetSAPGridViewFirstVisibleRowsearchSAPElementId = sAPSetSAPGridViewFirstVisibleRowsearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPSetSAPGridViewFirstVisibleRowsearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPSetSAPGridViewFirstVisibleRowsearchSAPElementId, nameof(sAPSetSAPGridViewFirstVisibleRowsearchSAPElementId), required: true);
            var __workflow_sAPSetSAPGridViewFirstVisibleRowfirstVisibleRowIndex = sAPSetSAPGridViewFirstVisibleRowfirstVisibleRowIndex == null ? null : WorkflowExpression.Compile(sAPSetSAPGridViewFirstVisibleRowfirstVisibleRowIndex);
            WorkflowExpression.Validate(__workflow_sAPSetSAPGridViewFirstVisibleRowfirstVisibleRowIndex, nameof(sAPSetSAPGridViewFirstVisibleRowfirstVisibleRowIndex), required: true);
            var __workflow_sAPSetSAPGridViewFirstVisibleRowworkflow = sAPSetSAPGridViewFirstVisibleRowworkflow == null ? null : WorkflowExpression.Compile(sAPSetSAPGridViewFirstVisibleRowworkflow);
            WorkflowExpression.Validate(__workflow_sAPSetSAPGridViewFirstVisibleRowworkflow, nameof(sAPSetSAPGridViewFirstVisibleRowworkflow), required: true);
            return new DeferredBodyAction<SAPSetSAPGridViewFirstVisibleRowResponse>(() =>
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
        public IWorkflowAction SAPSelectSAPGridViewRow(Expression<Func<string>> sAPSelectSAPGridViewRowsearchSAPElementId, Expression<Func<int>> sAPSelectSAPGridViewRowrowIndex, Expression<Func<string>> sAPSelectSAPGridViewRowworkflow, Expression<Func<bool>> sAPSelectSAPGridViewRowsetAsCurrentRow = null)
        {
            var __workflow_sAPSelectSAPGridViewRowsearchSAPElementId = sAPSelectSAPGridViewRowsearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPSelectSAPGridViewRowsearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPSelectSAPGridViewRowsearchSAPElementId, nameof(sAPSelectSAPGridViewRowsearchSAPElementId), required: true);
            var __workflow_sAPSelectSAPGridViewRowrowIndex = sAPSelectSAPGridViewRowrowIndex == null ? null : WorkflowExpression.Compile(sAPSelectSAPGridViewRowrowIndex);
            WorkflowExpression.Validate(__workflow_sAPSelectSAPGridViewRowrowIndex, nameof(sAPSelectSAPGridViewRowrowIndex), required: true);
            var __workflow_sAPSelectSAPGridViewRowworkflow = sAPSelectSAPGridViewRowworkflow == null ? null : WorkflowExpression.Compile(sAPSelectSAPGridViewRowworkflow);
            WorkflowExpression.Validate(__workflow_sAPSelectSAPGridViewRowworkflow, nameof(sAPSelectSAPGridViewRowworkflow), required: true);
            var __workflow_sAPSelectSAPGridViewRowsetAsCurrentRow = sAPSelectSAPGridViewRowsetAsCurrentRow == null ? null : WorkflowExpression.Compile(sAPSelectSAPGridViewRowsetAsCurrentRow);
            WorkflowExpression.Validate(__workflow_sAPSelectSAPGridViewRowsetAsCurrentRow, nameof(sAPSelectSAPGridViewRowsetAsCurrentRow), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction SAPSelectSAPGridViewMultipleRows(Expression<Func<string>> sAPSelectSAPGridViewMultipleRowssearchSAPElementId, Expression<Func<string>> sAPSelectSAPGridViewMultipleRowsrowsToSelect, Expression<Func<string>> sAPSelectSAPGridViewMultipleRowsworkflow)
        {
            var __workflow_sAPSelectSAPGridViewMultipleRowssearchSAPElementId = sAPSelectSAPGridViewMultipleRowssearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPSelectSAPGridViewMultipleRowssearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPSelectSAPGridViewMultipleRowssearchSAPElementId, nameof(sAPSelectSAPGridViewMultipleRowssearchSAPElementId), required: true);
            var __workflow_sAPSelectSAPGridViewMultipleRowsrowsToSelect = sAPSelectSAPGridViewMultipleRowsrowsToSelect == null ? null : WorkflowExpression.Compile(sAPSelectSAPGridViewMultipleRowsrowsToSelect);
            WorkflowExpression.Validate(__workflow_sAPSelectSAPGridViewMultipleRowsrowsToSelect, nameof(sAPSelectSAPGridViewMultipleRowsrowsToSelect), required: true);
            var __workflow_sAPSelectSAPGridViewMultipleRowsworkflow = sAPSelectSAPGridViewMultipleRowsworkflow == null ? null : WorkflowExpression.Compile(sAPSelectSAPGridViewMultipleRowsworkflow);
            WorkflowExpression.Validate(__workflow_sAPSelectSAPGridViewMultipleRowsworkflow, nameof(sAPSelectSAPGridViewMultipleRowsworkflow), required: true);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction SAPSetSAPGridViewCurrentColumn(Expression<Func<string>> sAPSetSAPGridViewCurrentColumnsearchSAPElementId, Expression<Func<string>> sAPSetSAPGridViewCurrentColumnworkflow, Expression<Func<string>> sAPSetSAPGridViewCurrentColumnsearchColumnName = null, Expression<Func<string>> sAPSetSAPGridViewCurrentColumnsearchColumnTitle = null, Expression<Func<bool>> sAPSetSAPGridViewCurrentColumnsearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPSetSAPGridViewCurrentColumnsearchColumnTitleIsCaseSensitive = null)
        {
            var __workflow_sAPSetSAPGridViewCurrentColumnsearchSAPElementId = sAPSetSAPGridViewCurrentColumnsearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPSetSAPGridViewCurrentColumnsearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPSetSAPGridViewCurrentColumnsearchSAPElementId, nameof(sAPSetSAPGridViewCurrentColumnsearchSAPElementId), required: true);
            var __workflow_sAPSetSAPGridViewCurrentColumnworkflow = sAPSetSAPGridViewCurrentColumnworkflow == null ? null : WorkflowExpression.Compile(sAPSetSAPGridViewCurrentColumnworkflow);
            WorkflowExpression.Validate(__workflow_sAPSetSAPGridViewCurrentColumnworkflow, nameof(sAPSetSAPGridViewCurrentColumnworkflow), required: true);
            var __workflow_sAPSetSAPGridViewCurrentColumnsearchColumnName = sAPSetSAPGridViewCurrentColumnsearchColumnName == null ? null : WorkflowExpression.Compile(sAPSetSAPGridViewCurrentColumnsearchColumnName);
            WorkflowExpression.Validate(__workflow_sAPSetSAPGridViewCurrentColumnsearchColumnName, nameof(sAPSetSAPGridViewCurrentColumnsearchColumnName), required: false);
            var __workflow_sAPSetSAPGridViewCurrentColumnsearchColumnTitle = sAPSetSAPGridViewCurrentColumnsearchColumnTitle == null ? null : WorkflowExpression.Compile(sAPSetSAPGridViewCurrentColumnsearchColumnTitle);
            WorkflowExpression.Validate(__workflow_sAPSetSAPGridViewCurrentColumnsearchColumnTitle, nameof(sAPSetSAPGridViewCurrentColumnsearchColumnTitle), required: false);
            var __workflow_sAPSetSAPGridViewCurrentColumnsearchColumnTitleIsRegularExpression = sAPSetSAPGridViewCurrentColumnsearchColumnTitleIsRegularExpression == null ? null : WorkflowExpression.Compile(sAPSetSAPGridViewCurrentColumnsearchColumnTitleIsRegularExpression);
            WorkflowExpression.Validate(__workflow_sAPSetSAPGridViewCurrentColumnsearchColumnTitleIsRegularExpression, nameof(sAPSetSAPGridViewCurrentColumnsearchColumnTitleIsRegularExpression), required: false);
            var __workflow_sAPSetSAPGridViewCurrentColumnsearchColumnTitleIsCaseSensitive = sAPSetSAPGridViewCurrentColumnsearchColumnTitleIsCaseSensitive == null ? null : WorkflowExpression.Compile(sAPSetSAPGridViewCurrentColumnsearchColumnTitleIsCaseSensitive);
            WorkflowExpression.Validate(__workflow_sAPSetSAPGridViewCurrentColumnsearchColumnTitleIsCaseSensitive, nameof(sAPSetSAPGridViewCurrentColumnsearchColumnTitleIsCaseSensitive), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction SAPSetSAPGridViewCurrentCell(Expression<Func<string>> sAPSetSAPGridViewCurrentCellsearchSAPElementId, Expression<Func<int>> sAPSetSAPGridViewCurrentCellrowIndex, Expression<Func<string>> sAPSetSAPGridViewCurrentCellworkflow, Expression<Func<string>> sAPSetSAPGridViewCurrentCellsearchColumnName = null, Expression<Func<string>> sAPSetSAPGridViewCurrentCellsearchColumnTitle = null, Expression<Func<bool>> sAPSetSAPGridViewCurrentCellsearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPSetSAPGridViewCurrentCellsearchColumnTitleIsCaseSensitive = null)
        {
            var __workflow_sAPSetSAPGridViewCurrentCellsearchSAPElementId = sAPSetSAPGridViewCurrentCellsearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPSetSAPGridViewCurrentCellsearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPSetSAPGridViewCurrentCellsearchSAPElementId, nameof(sAPSetSAPGridViewCurrentCellsearchSAPElementId), required: true);
            var __workflow_sAPSetSAPGridViewCurrentCellrowIndex = sAPSetSAPGridViewCurrentCellrowIndex == null ? null : WorkflowExpression.Compile(sAPSetSAPGridViewCurrentCellrowIndex);
            WorkflowExpression.Validate(__workflow_sAPSetSAPGridViewCurrentCellrowIndex, nameof(sAPSetSAPGridViewCurrentCellrowIndex), required: true);
            var __workflow_sAPSetSAPGridViewCurrentCellworkflow = sAPSetSAPGridViewCurrentCellworkflow == null ? null : WorkflowExpression.Compile(sAPSetSAPGridViewCurrentCellworkflow);
            WorkflowExpression.Validate(__workflow_sAPSetSAPGridViewCurrentCellworkflow, nameof(sAPSetSAPGridViewCurrentCellworkflow), required: true);
            var __workflow_sAPSetSAPGridViewCurrentCellsearchColumnName = sAPSetSAPGridViewCurrentCellsearchColumnName == null ? null : WorkflowExpression.Compile(sAPSetSAPGridViewCurrentCellsearchColumnName);
            WorkflowExpression.Validate(__workflow_sAPSetSAPGridViewCurrentCellsearchColumnName, nameof(sAPSetSAPGridViewCurrentCellsearchColumnName), required: false);
            var __workflow_sAPSetSAPGridViewCurrentCellsearchColumnTitle = sAPSetSAPGridViewCurrentCellsearchColumnTitle == null ? null : WorkflowExpression.Compile(sAPSetSAPGridViewCurrentCellsearchColumnTitle);
            WorkflowExpression.Validate(__workflow_sAPSetSAPGridViewCurrentCellsearchColumnTitle, nameof(sAPSetSAPGridViewCurrentCellsearchColumnTitle), required: false);
            var __workflow_sAPSetSAPGridViewCurrentCellsearchColumnTitleIsRegularExpression = sAPSetSAPGridViewCurrentCellsearchColumnTitleIsRegularExpression == null ? null : WorkflowExpression.Compile(sAPSetSAPGridViewCurrentCellsearchColumnTitleIsRegularExpression);
            WorkflowExpression.Validate(__workflow_sAPSetSAPGridViewCurrentCellsearchColumnTitleIsRegularExpression, nameof(sAPSetSAPGridViewCurrentCellsearchColumnTitleIsRegularExpression), required: false);
            var __workflow_sAPSetSAPGridViewCurrentCellsearchColumnTitleIsCaseSensitive = sAPSetSAPGridViewCurrentCellsearchColumnTitleIsCaseSensitive == null ? null : WorkflowExpression.Compile(sAPSetSAPGridViewCurrentCellsearchColumnTitleIsCaseSensitive);
            WorkflowExpression.Validate(__workflow_sAPSetSAPGridViewCurrentCellsearchColumnTitleIsCaseSensitive, nameof(sAPSetSAPGridViewCurrentCellsearchColumnTitleIsCaseSensitive), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction SAPSelectSAPGridViewColumn(Expression<Func<string>> sAPSelectSAPGridViewColumnsearchSAPElementId, Expression<Func<string>> sAPSelectSAPGridViewColumnworkflow, Expression<Func<string>> sAPSelectSAPGridViewColumnsearchColumnName = null, Expression<Func<string>> sAPSelectSAPGridViewColumnsearchColumnTitle = null, Expression<Func<bool>> sAPSelectSAPGridViewColumnsearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPSelectSAPGridViewColumnsearchColumnTitleIsCaseSensitive = null, Expression<Func<bool>> sAPSelectSAPGridViewColumnselectColumn = null, Expression<Func<bool>> sAPSelectSAPGridViewColumnsetAsCurrentColumn = null, Expression<Func<bool>> sAPSelectSAPGridViewColumnclearSelectionFirst = null)
        {
            var __workflow_sAPSelectSAPGridViewColumnsearchSAPElementId = sAPSelectSAPGridViewColumnsearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPSelectSAPGridViewColumnsearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPSelectSAPGridViewColumnsearchSAPElementId, nameof(sAPSelectSAPGridViewColumnsearchSAPElementId), required: true);
            var __workflow_sAPSelectSAPGridViewColumnworkflow = sAPSelectSAPGridViewColumnworkflow == null ? null : WorkflowExpression.Compile(sAPSelectSAPGridViewColumnworkflow);
            WorkflowExpression.Validate(__workflow_sAPSelectSAPGridViewColumnworkflow, nameof(sAPSelectSAPGridViewColumnworkflow), required: true);
            var __workflow_sAPSelectSAPGridViewColumnsearchColumnName = sAPSelectSAPGridViewColumnsearchColumnName == null ? null : WorkflowExpression.Compile(sAPSelectSAPGridViewColumnsearchColumnName);
            WorkflowExpression.Validate(__workflow_sAPSelectSAPGridViewColumnsearchColumnName, nameof(sAPSelectSAPGridViewColumnsearchColumnName), required: false);
            var __workflow_sAPSelectSAPGridViewColumnsearchColumnTitle = sAPSelectSAPGridViewColumnsearchColumnTitle == null ? null : WorkflowExpression.Compile(sAPSelectSAPGridViewColumnsearchColumnTitle);
            WorkflowExpression.Validate(__workflow_sAPSelectSAPGridViewColumnsearchColumnTitle, nameof(sAPSelectSAPGridViewColumnsearchColumnTitle), required: false);
            var __workflow_sAPSelectSAPGridViewColumnsearchColumnTitleIsRegularExpression = sAPSelectSAPGridViewColumnsearchColumnTitleIsRegularExpression == null ? null : WorkflowExpression.Compile(sAPSelectSAPGridViewColumnsearchColumnTitleIsRegularExpression);
            WorkflowExpression.Validate(__workflow_sAPSelectSAPGridViewColumnsearchColumnTitleIsRegularExpression, nameof(sAPSelectSAPGridViewColumnsearchColumnTitleIsRegularExpression), required: false);
            var __workflow_sAPSelectSAPGridViewColumnsearchColumnTitleIsCaseSensitive = sAPSelectSAPGridViewColumnsearchColumnTitleIsCaseSensitive == null ? null : WorkflowExpression.Compile(sAPSelectSAPGridViewColumnsearchColumnTitleIsCaseSensitive);
            WorkflowExpression.Validate(__workflow_sAPSelectSAPGridViewColumnsearchColumnTitleIsCaseSensitive, nameof(sAPSelectSAPGridViewColumnsearchColumnTitleIsCaseSensitive), required: false);
            var __workflow_sAPSelectSAPGridViewColumnselectColumn = sAPSelectSAPGridViewColumnselectColumn == null ? null : WorkflowExpression.Compile(sAPSelectSAPGridViewColumnselectColumn);
            WorkflowExpression.Validate(__workflow_sAPSelectSAPGridViewColumnselectColumn, nameof(sAPSelectSAPGridViewColumnselectColumn), required: false);
            var __workflow_sAPSelectSAPGridViewColumnsetAsCurrentColumn = sAPSelectSAPGridViewColumnsetAsCurrentColumn == null ? null : WorkflowExpression.Compile(sAPSelectSAPGridViewColumnsetAsCurrentColumn);
            WorkflowExpression.Validate(__workflow_sAPSelectSAPGridViewColumnsetAsCurrentColumn, nameof(sAPSelectSAPGridViewColumnsetAsCurrentColumn), required: false);
            var __workflow_sAPSelectSAPGridViewColumnclearSelectionFirst = sAPSelectSAPGridViewColumnclearSelectionFirst == null ? null : WorkflowExpression.Compile(sAPSelectSAPGridViewColumnclearSelectionFirst);
            WorkflowExpression.Validate(__workflow_sAPSelectSAPGridViewColumnclearSelectionFirst, nameof(sAPSelectSAPGridViewColumnclearSelectionFirst), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction SAPGridViewSelectAll(Expression<Func<string>> sAPGridViewSelectAllsearchSAPElementId, Expression<Func<string>> sAPGridViewSelectAllworkflow)
        {
            var __workflow_sAPGridViewSelectAllsearchSAPElementId = sAPGridViewSelectAllsearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPGridViewSelectAllsearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPGridViewSelectAllsearchSAPElementId, nameof(sAPGridViewSelectAllsearchSAPElementId), required: true);
            var __workflow_sAPGridViewSelectAllworkflow = sAPGridViewSelectAllworkflow == null ? null : WorkflowExpression.Compile(sAPGridViewSelectAllworkflow);
            WorkflowExpression.Validate(__workflow_sAPGridViewSelectAllworkflow, nameof(sAPGridViewSelectAllworkflow), required: true);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction SAPGridViewDeselectAll(Expression<Func<string>> sAPGridViewDeselectAllsearchSAPElementId, Expression<Func<string>> sAPGridViewDeselectAllworkflow)
        {
            var __workflow_sAPGridViewDeselectAllsearchSAPElementId = sAPGridViewDeselectAllsearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPGridViewDeselectAllsearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPGridViewDeselectAllsearchSAPElementId, nameof(sAPGridViewDeselectAllsearchSAPElementId), required: true);
            var __workflow_sAPGridViewDeselectAllworkflow = sAPGridViewDeselectAllworkflow == null ? null : WorkflowExpression.Compile(sAPGridViewDeselectAllworkflow);
            WorkflowExpression.Validate(__workflow_sAPGridViewDeselectAllworkflow, nameof(sAPGridViewDeselectAllworkflow), required: true);
            return new DeferredWorkflowAction(() =>
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
        public IBodyWorkflowAction<SAPSetSAPGridViewFirstVisibleColumnResponse> SAPSetSAPGridViewFirstVisibleColumn(Expression<Func<string>> sAPSetSAPGridViewFirstVisibleColumnsearchSAPElementId, Expression<Func<string>> sAPSetSAPGridViewFirstVisibleColumnworkflow, Expression<Func<string>> sAPSetSAPGridViewFirstVisibleColumnsearchColumnName = null, Expression<Func<string>> sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitle = null, Expression<Func<bool>> sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitleIsCaseSensitive = null)
        {
            var __workflow_sAPSetSAPGridViewFirstVisibleColumnsearchSAPElementId = sAPSetSAPGridViewFirstVisibleColumnsearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPSetSAPGridViewFirstVisibleColumnsearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPSetSAPGridViewFirstVisibleColumnsearchSAPElementId, nameof(sAPSetSAPGridViewFirstVisibleColumnsearchSAPElementId), required: true);
            var __workflow_sAPSetSAPGridViewFirstVisibleColumnworkflow = sAPSetSAPGridViewFirstVisibleColumnworkflow == null ? null : WorkflowExpression.Compile(sAPSetSAPGridViewFirstVisibleColumnworkflow);
            WorkflowExpression.Validate(__workflow_sAPSetSAPGridViewFirstVisibleColumnworkflow, nameof(sAPSetSAPGridViewFirstVisibleColumnworkflow), required: true);
            var __workflow_sAPSetSAPGridViewFirstVisibleColumnsearchColumnName = sAPSetSAPGridViewFirstVisibleColumnsearchColumnName == null ? null : WorkflowExpression.Compile(sAPSetSAPGridViewFirstVisibleColumnsearchColumnName);
            WorkflowExpression.Validate(__workflow_sAPSetSAPGridViewFirstVisibleColumnsearchColumnName, nameof(sAPSetSAPGridViewFirstVisibleColumnsearchColumnName), required: false);
            var __workflow_sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitle = sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitle == null ? null : WorkflowExpression.Compile(sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitle);
            WorkflowExpression.Validate(__workflow_sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitle, nameof(sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitle), required: false);
            var __workflow_sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitleIsRegularExpression = sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitleIsRegularExpression == null ? null : WorkflowExpression.Compile(sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitleIsRegularExpression);
            WorkflowExpression.Validate(__workflow_sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitleIsRegularExpression, nameof(sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitleIsRegularExpression), required: false);
            var __workflow_sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitleIsCaseSensitive = sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitleIsCaseSensitive == null ? null : WorkflowExpression.Compile(sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitleIsCaseSensitive);
            WorkflowExpression.Validate(__workflow_sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitleIsCaseSensitive, nameof(sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitleIsCaseSensitive), required: false);
            return new DeferredBodyAction<SAPSetSAPGridViewFirstVisibleColumnResponse>(() =>
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
        public IWorkflowAction SAPGridViewOpenContextMenu(Expression<Func<string>> sAPGridViewOpenContextMenusearchSAPElementId, Expression<Func<int>> sAPGridViewOpenContextMenurowIndex, Expression<Func<string>> sAPGridViewOpenContextMenuworkflow, Expression<Func<string>> sAPGridViewOpenContextMenusearchColumnName = null, Expression<Func<string>> sAPGridViewOpenContextMenusearchColumnTitle = null, Expression<Func<bool>> sAPGridViewOpenContextMenusearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPGridViewOpenContextMenusearchColumnTitleIsCaseSensitive = null)
        {
            var __workflow_sAPGridViewOpenContextMenusearchSAPElementId = sAPGridViewOpenContextMenusearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPGridViewOpenContextMenusearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPGridViewOpenContextMenusearchSAPElementId, nameof(sAPGridViewOpenContextMenusearchSAPElementId), required: true);
            var __workflow_sAPGridViewOpenContextMenurowIndex = sAPGridViewOpenContextMenurowIndex == null ? null : WorkflowExpression.Compile(sAPGridViewOpenContextMenurowIndex);
            WorkflowExpression.Validate(__workflow_sAPGridViewOpenContextMenurowIndex, nameof(sAPGridViewOpenContextMenurowIndex), required: true);
            var __workflow_sAPGridViewOpenContextMenuworkflow = sAPGridViewOpenContextMenuworkflow == null ? null : WorkflowExpression.Compile(sAPGridViewOpenContextMenuworkflow);
            WorkflowExpression.Validate(__workflow_sAPGridViewOpenContextMenuworkflow, nameof(sAPGridViewOpenContextMenuworkflow), required: true);
            var __workflow_sAPGridViewOpenContextMenusearchColumnName = sAPGridViewOpenContextMenusearchColumnName == null ? null : WorkflowExpression.Compile(sAPGridViewOpenContextMenusearchColumnName);
            WorkflowExpression.Validate(__workflow_sAPGridViewOpenContextMenusearchColumnName, nameof(sAPGridViewOpenContextMenusearchColumnName), required: false);
            var __workflow_sAPGridViewOpenContextMenusearchColumnTitle = sAPGridViewOpenContextMenusearchColumnTitle == null ? null : WorkflowExpression.Compile(sAPGridViewOpenContextMenusearchColumnTitle);
            WorkflowExpression.Validate(__workflow_sAPGridViewOpenContextMenusearchColumnTitle, nameof(sAPGridViewOpenContextMenusearchColumnTitle), required: false);
            var __workflow_sAPGridViewOpenContextMenusearchColumnTitleIsRegularExpression = sAPGridViewOpenContextMenusearchColumnTitleIsRegularExpression == null ? null : WorkflowExpression.Compile(sAPGridViewOpenContextMenusearchColumnTitleIsRegularExpression);
            WorkflowExpression.Validate(__workflow_sAPGridViewOpenContextMenusearchColumnTitleIsRegularExpression, nameof(sAPGridViewOpenContextMenusearchColumnTitleIsRegularExpression), required: false);
            var __workflow_sAPGridViewOpenContextMenusearchColumnTitleIsCaseSensitive = sAPGridViewOpenContextMenusearchColumnTitleIsCaseSensitive == null ? null : WorkflowExpression.Compile(sAPGridViewOpenContextMenusearchColumnTitleIsCaseSensitive);
            WorkflowExpression.Validate(__workflow_sAPGridViewOpenContextMenusearchColumnTitleIsCaseSensitive, nameof(sAPGridViewOpenContextMenusearchColumnTitleIsCaseSensitive), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IBodyWorkflowAction<SAPGetGridViewTextContentsResponse> SAPGetGridViewTextContents(Expression<Func<string>> sAPGetGridViewTextContentssearchSAPElementId, Expression<Func<string>> sAPGetGridViewTextContentsworkflow, Expression<Func<int>> sAPGetGridViewTextContentsfirstRowToReturn = null, Expression<Func<int>> sAPGetGridViewTextContentsmaxRowsToReturn = null, Expression<Func<string>> sAPGetGridViewTextContentsfirstSearchColumnName = null, Expression<Func<string>> sAPGetGridViewTextContentsfirstSearchColumnTitle = null, Expression<Func<bool>> sAPGetGridViewTextContentsfirstSearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPGetGridViewTextContentsfirstSearchColumnTitleIsCaseSensitive = null, Expression<Func<int>> sAPGetGridViewTextContentsmaxColumnsToReturn = null, Expression<Func<bool>> sAPGetGridViewTextContentsuseColumnHeadersFromTable = null, Expression<Func<bool>> sAPGetGridViewTextContentsreturnRowIndexInOutputCollection = null, Expression<Func<string>> sAPGetGridViewTextContentsnameOfColumnToStoreRowIndex = null, Expression<Func<string>> sAPGetGridViewTextContentscheckedElementValue = null)
        {
            var __workflow_sAPGetGridViewTextContentssearchSAPElementId = sAPGetGridViewTextContentssearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPGetGridViewTextContentssearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPGetGridViewTextContentssearchSAPElementId, nameof(sAPGetGridViewTextContentssearchSAPElementId), required: true);
            var __workflow_sAPGetGridViewTextContentsworkflow = sAPGetGridViewTextContentsworkflow == null ? null : WorkflowExpression.Compile(sAPGetGridViewTextContentsworkflow);
            WorkflowExpression.Validate(__workflow_sAPGetGridViewTextContentsworkflow, nameof(sAPGetGridViewTextContentsworkflow), required: true);
            var __workflow_sAPGetGridViewTextContentsfirstRowToReturn = sAPGetGridViewTextContentsfirstRowToReturn == null ? null : WorkflowExpression.Compile(sAPGetGridViewTextContentsfirstRowToReturn);
            WorkflowExpression.Validate(__workflow_sAPGetGridViewTextContentsfirstRowToReturn, nameof(sAPGetGridViewTextContentsfirstRowToReturn), required: false);
            var __workflow_sAPGetGridViewTextContentsmaxRowsToReturn = sAPGetGridViewTextContentsmaxRowsToReturn == null ? null : WorkflowExpression.Compile(sAPGetGridViewTextContentsmaxRowsToReturn);
            WorkflowExpression.Validate(__workflow_sAPGetGridViewTextContentsmaxRowsToReturn, nameof(sAPGetGridViewTextContentsmaxRowsToReturn), required: false);
            var __workflow_sAPGetGridViewTextContentsfirstSearchColumnName = sAPGetGridViewTextContentsfirstSearchColumnName == null ? null : WorkflowExpression.Compile(sAPGetGridViewTextContentsfirstSearchColumnName);
            WorkflowExpression.Validate(__workflow_sAPGetGridViewTextContentsfirstSearchColumnName, nameof(sAPGetGridViewTextContentsfirstSearchColumnName), required: false);
            var __workflow_sAPGetGridViewTextContentsfirstSearchColumnTitle = sAPGetGridViewTextContentsfirstSearchColumnTitle == null ? null : WorkflowExpression.Compile(sAPGetGridViewTextContentsfirstSearchColumnTitle);
            WorkflowExpression.Validate(__workflow_sAPGetGridViewTextContentsfirstSearchColumnTitle, nameof(sAPGetGridViewTextContentsfirstSearchColumnTitle), required: false);
            var __workflow_sAPGetGridViewTextContentsfirstSearchColumnTitleIsRegularExpression = sAPGetGridViewTextContentsfirstSearchColumnTitleIsRegularExpression == null ? null : WorkflowExpression.Compile(sAPGetGridViewTextContentsfirstSearchColumnTitleIsRegularExpression);
            WorkflowExpression.Validate(__workflow_sAPGetGridViewTextContentsfirstSearchColumnTitleIsRegularExpression, nameof(sAPGetGridViewTextContentsfirstSearchColumnTitleIsRegularExpression), required: false);
            var __workflow_sAPGetGridViewTextContentsfirstSearchColumnTitleIsCaseSensitive = sAPGetGridViewTextContentsfirstSearchColumnTitleIsCaseSensitive == null ? null : WorkflowExpression.Compile(sAPGetGridViewTextContentsfirstSearchColumnTitleIsCaseSensitive);
            WorkflowExpression.Validate(__workflow_sAPGetGridViewTextContentsfirstSearchColumnTitleIsCaseSensitive, nameof(sAPGetGridViewTextContentsfirstSearchColumnTitleIsCaseSensitive), required: false);
            var __workflow_sAPGetGridViewTextContentsmaxColumnsToReturn = sAPGetGridViewTextContentsmaxColumnsToReturn == null ? null : WorkflowExpression.Compile(sAPGetGridViewTextContentsmaxColumnsToReturn);
            WorkflowExpression.Validate(__workflow_sAPGetGridViewTextContentsmaxColumnsToReturn, nameof(sAPGetGridViewTextContentsmaxColumnsToReturn), required: false);
            var __workflow_sAPGetGridViewTextContentsuseColumnHeadersFromTable = sAPGetGridViewTextContentsuseColumnHeadersFromTable == null ? null : WorkflowExpression.Compile(sAPGetGridViewTextContentsuseColumnHeadersFromTable);
            WorkflowExpression.Validate(__workflow_sAPGetGridViewTextContentsuseColumnHeadersFromTable, nameof(sAPGetGridViewTextContentsuseColumnHeadersFromTable), required: false);
            var __workflow_sAPGetGridViewTextContentsreturnRowIndexInOutputCollection = sAPGetGridViewTextContentsreturnRowIndexInOutputCollection == null ? null : WorkflowExpression.Compile(sAPGetGridViewTextContentsreturnRowIndexInOutputCollection);
            WorkflowExpression.Validate(__workflow_sAPGetGridViewTextContentsreturnRowIndexInOutputCollection, nameof(sAPGetGridViewTextContentsreturnRowIndexInOutputCollection), required: false);
            var __workflow_sAPGetGridViewTextContentsnameOfColumnToStoreRowIndex = sAPGetGridViewTextContentsnameOfColumnToStoreRowIndex == null ? null : WorkflowExpression.Compile(sAPGetGridViewTextContentsnameOfColumnToStoreRowIndex);
            WorkflowExpression.Validate(__workflow_sAPGetGridViewTextContentsnameOfColumnToStoreRowIndex, nameof(sAPGetGridViewTextContentsnameOfColumnToStoreRowIndex), required: false);
            var __workflow_sAPGetGridViewTextContentscheckedElementValue = sAPGetGridViewTextContentscheckedElementValue == null ? null : WorkflowExpression.Compile(sAPGetGridViewTextContentscheckedElementValue);
            WorkflowExpression.Validate(__workflow_sAPGetGridViewTextContentscheckedElementValue, nameof(sAPGetGridViewTextContentscheckedElementValue), required: false);
            return new DeferredBodyAction<SAPGetGridViewTextContentsResponse>(() =>
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
        public IWorkflowAction SAPSelectCalendarMonth(Expression<Func<string>> sAPSelectCalendarMonthsearchSAPElementId, Expression<Func<int>> sAPSelectCalendarMonthmonth, Expression<Func<int>> sAPSelectCalendarMonthyear, Expression<Func<string>> sAPSelectCalendarMonthworkflow)
        {
            var __workflow_sAPSelectCalendarMonthsearchSAPElementId = sAPSelectCalendarMonthsearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPSelectCalendarMonthsearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPSelectCalendarMonthsearchSAPElementId, nameof(sAPSelectCalendarMonthsearchSAPElementId), required: true);
            var __workflow_sAPSelectCalendarMonthmonth = sAPSelectCalendarMonthmonth == null ? null : WorkflowExpression.Compile(sAPSelectCalendarMonthmonth);
            WorkflowExpression.Validate(__workflow_sAPSelectCalendarMonthmonth, nameof(sAPSelectCalendarMonthmonth), required: true);
            var __workflow_sAPSelectCalendarMonthyear = sAPSelectCalendarMonthyear == null ? null : WorkflowExpression.Compile(sAPSelectCalendarMonthyear);
            WorkflowExpression.Validate(__workflow_sAPSelectCalendarMonthyear, nameof(sAPSelectCalendarMonthyear), required: true);
            var __workflow_sAPSelectCalendarMonthworkflow = sAPSelectCalendarMonthworkflow == null ? null : WorkflowExpression.Compile(sAPSelectCalendarMonthworkflow);
            WorkflowExpression.Validate(__workflow_sAPSelectCalendarMonthworkflow, nameof(sAPSelectCalendarMonthworkflow), required: true);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction SAPSelectCalendarWeek(Expression<Func<string>> sAPSelectCalendarWeeksearchSAPElementId, Expression<Func<int>> sAPSelectCalendarWeekweek, Expression<Func<int>> sAPSelectCalendarWeekyear, Expression<Func<string>> sAPSelectCalendarWeekworkflow)
        {
            var __workflow_sAPSelectCalendarWeeksearchSAPElementId = sAPSelectCalendarWeeksearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPSelectCalendarWeeksearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPSelectCalendarWeeksearchSAPElementId, nameof(sAPSelectCalendarWeeksearchSAPElementId), required: true);
            var __workflow_sAPSelectCalendarWeekweek = sAPSelectCalendarWeekweek == null ? null : WorkflowExpression.Compile(sAPSelectCalendarWeekweek);
            WorkflowExpression.Validate(__workflow_sAPSelectCalendarWeekweek, nameof(sAPSelectCalendarWeekweek), required: true);
            var __workflow_sAPSelectCalendarWeekyear = sAPSelectCalendarWeekyear == null ? null : WorkflowExpression.Compile(sAPSelectCalendarWeekyear);
            WorkflowExpression.Validate(__workflow_sAPSelectCalendarWeekyear, nameof(sAPSelectCalendarWeekyear), required: true);
            var __workflow_sAPSelectCalendarWeekworkflow = sAPSelectCalendarWeekworkflow == null ? null : WorkflowExpression.Compile(sAPSelectCalendarWeekworkflow);
            WorkflowExpression.Validate(__workflow_sAPSelectCalendarWeekworkflow, nameof(sAPSelectCalendarWeekworkflow), required: true);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction SAPSelectCalendarRange(Expression<Func<string>> sAPSelectCalendarRangesearchSAPElementId, Expression<Func<string>> sAPSelectCalendarRangefromDateYYYYMMDD, Expression<Func<string>> sAPSelectCalendarRangetoDateYYYYMMDD, Expression<Func<string>> sAPSelectCalendarRangeworkflow)
        {
            var __workflow_sAPSelectCalendarRangesearchSAPElementId = sAPSelectCalendarRangesearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPSelectCalendarRangesearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPSelectCalendarRangesearchSAPElementId, nameof(sAPSelectCalendarRangesearchSAPElementId), required: true);
            var __workflow_sAPSelectCalendarRangefromDateYYYYMMDD = sAPSelectCalendarRangefromDateYYYYMMDD == null ? null : WorkflowExpression.Compile(sAPSelectCalendarRangefromDateYYYYMMDD);
            WorkflowExpression.Validate(__workflow_sAPSelectCalendarRangefromDateYYYYMMDD, nameof(sAPSelectCalendarRangefromDateYYYYMMDD), required: true);
            var __workflow_sAPSelectCalendarRangetoDateYYYYMMDD = sAPSelectCalendarRangetoDateYYYYMMDD == null ? null : WorkflowExpression.Compile(sAPSelectCalendarRangetoDateYYYYMMDD);
            WorkflowExpression.Validate(__workflow_sAPSelectCalendarRangetoDateYYYYMMDD, nameof(sAPSelectCalendarRangetoDateYYYYMMDD), required: true);
            var __workflow_sAPSelectCalendarRangeworkflow = sAPSelectCalendarRangeworkflow == null ? null : WorkflowExpression.Compile(sAPSelectCalendarRangeworkflow);
            WorkflowExpression.Validate(__workflow_sAPSelectCalendarRangeworkflow, nameof(sAPSelectCalendarRangeworkflow), required: true);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction SAPFocusCalendarDate(Expression<Func<string>> sAPFocusCalendarDatesearchSAPElementId, Expression<Func<string>> sAPFocusCalendarDatedateYYYYMMDD, Expression<Func<string>> sAPFocusCalendarDateworkflow)
        {
            var __workflow_sAPFocusCalendarDatesearchSAPElementId = sAPFocusCalendarDatesearchSAPElementId == null ? null : WorkflowExpression.Compile(sAPFocusCalendarDatesearchSAPElementId);
            WorkflowExpression.Validate(__workflow_sAPFocusCalendarDatesearchSAPElementId, nameof(sAPFocusCalendarDatesearchSAPElementId), required: true);
            var __workflow_sAPFocusCalendarDatedateYYYYMMDD = sAPFocusCalendarDatedateYYYYMMDD == null ? null : WorkflowExpression.Compile(sAPFocusCalendarDatedateYYYYMMDD);
            WorkflowExpression.Validate(__workflow_sAPFocusCalendarDatedateYYYYMMDD, nameof(sAPFocusCalendarDatedateYYYYMMDD), required: true);
            var __workflow_sAPFocusCalendarDateworkflow = sAPFocusCalendarDateworkflow == null ? null : WorkflowExpression.Compile(sAPFocusCalendarDateworkflow);
            WorkflowExpression.Validate(__workflow_sAPFocusCalendarDateworkflow, nameof(sAPFocusCalendarDateworkflow), required: true);
            return new DeferredWorkflowAction(() =>
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
