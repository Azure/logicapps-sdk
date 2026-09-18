//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectsapgui
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IaconnectsapguiActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPEnableScripting([WorkflowExpression] Func<string> sAPEnableScriptingworkflow, [WorkflowExpression] Func<bool> sAPEnableScriptingnotifyWhenScriptAttachesToGUI = null, [WorkflowExpression] Func<bool> sAPEnableScriptingnotifyWhenScriptOpensConnection = null, [WorkflowExpression] Func<bool> sAPEnableScriptingshowNativeWindowsDialogs = null)
        {
            SourceExpression.Validate(sAPEnableScriptingworkflow, nameof(sAPEnableScriptingworkflow), required: true);
            SourceExpression.Validate(sAPEnableScriptingnotifyWhenScriptAttachesToGUI, nameof(sAPEnableScriptingnotifyWhenScriptAttachesToGUI), required: false);
            SourceExpression.Validate(sAPEnableScriptingnotifyWhenScriptOpensConnection, nameof(sAPEnableScriptingnotifyWhenScriptOpensConnection), required: false);
            SourceExpression.Validate(sAPEnableScriptingshowNativeWindowsDialogs, nameof(sAPEnableScriptingshowNativeWindowsDialogs), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        sAPEnableScripting["NotifyWhenScriptAttachesToGUI"] = SourceExpressionConverter.ConvertToken(sAPEnableScriptingnotifyWhenScriptAttachesToGUI);
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
                        sAPEnableScripting["NotifyWhenScriptOpensConnection"] = SourceExpressionConverter.ConvertToken(sAPEnableScriptingnotifyWhenScriptOpensConnection);
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
                        sAPEnableScripting["ShowNativeWindowsDialogs"] = SourceExpressionConverter.ConvertToken(sAPEnableScriptingshowNativeWindowsDialogs);
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
                sAPEnableScripting["Workflow"] = SourceExpressionConverter.ConvertToken(sAPEnableScriptingworkflow);
                if (sAPEnableScriptingpropCount > 0)
                {
                    callPayload.Body = sAPEnableScripting;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPLaunchSAPGUIResponse> SAPLaunchSAPGUI([WorkflowExpression] Func<string> sAPLaunchSAPGUIworkflow, [WorkflowExpression] Func<string> sAPLaunchSAPGUIsAPLogonEXE = null, [WorkflowExpression] Func<string> sAPLaunchSAPGUIsAPLogonArguments = null, [WorkflowExpression] Func<bool> sAPLaunchSAPGUIenableSAPScripting = null, [WorkflowExpression] Func<bool> sAPLaunchSAPGUInotifyWhenScriptAttachesToGUI = null, [WorkflowExpression] Func<bool> sAPLaunchSAPGUInotifyWhenScriptOpensConnection = null, [WorkflowExpression] Func<bool> sAPLaunchSAPGUIshowNativeWindowsDialogs = null, [WorkflowExpression] Func<bool> sAPLaunchSAPGUIattachAfterLaunch = null, [WorkflowExpression] Func<double> sAPLaunchSAPGUIsecondsToWait = null, [WorkflowExpression] Func<string> sAPLaunchSAPGUIsAPProgId = null, [WorkflowExpression] Func<bool> sAPLaunchSAPGUIdisableSystemMessages = null)
        {
            SourceExpression.Validate(sAPLaunchSAPGUIworkflow, nameof(sAPLaunchSAPGUIworkflow), required: true);
            SourceExpression.Validate(sAPLaunchSAPGUIsAPLogonEXE, nameof(sAPLaunchSAPGUIsAPLogonEXE), required: false);
            SourceExpression.Validate(sAPLaunchSAPGUIsAPLogonArguments, nameof(sAPLaunchSAPGUIsAPLogonArguments), required: false);
            SourceExpression.Validate(sAPLaunchSAPGUIenableSAPScripting, nameof(sAPLaunchSAPGUIenableSAPScripting), required: false);
            SourceExpression.Validate(sAPLaunchSAPGUInotifyWhenScriptAttachesToGUI, nameof(sAPLaunchSAPGUInotifyWhenScriptAttachesToGUI), required: false);
            SourceExpression.Validate(sAPLaunchSAPGUInotifyWhenScriptOpensConnection, nameof(sAPLaunchSAPGUInotifyWhenScriptOpensConnection), required: false);
            SourceExpression.Validate(sAPLaunchSAPGUIshowNativeWindowsDialogs, nameof(sAPLaunchSAPGUIshowNativeWindowsDialogs), required: false);
            SourceExpression.Validate(sAPLaunchSAPGUIattachAfterLaunch, nameof(sAPLaunchSAPGUIattachAfterLaunch), required: false);
            SourceExpression.Validate(sAPLaunchSAPGUIsecondsToWait, nameof(sAPLaunchSAPGUIsecondsToWait), required: false);
            SourceExpression.Validate(sAPLaunchSAPGUIsAPProgId, nameof(sAPLaunchSAPGUIsAPProgId), required: false);
            SourceExpression.Validate(sAPLaunchSAPGUIdisableSystemMessages, nameof(sAPLaunchSAPGUIdisableSystemMessages), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPLaunchSAPGUI";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPLaunchSAPGUI = new JObject();
                var sAPLaunchSAPGUIpropCount = 0;
                if (sAPLaunchSAPGUIsAPLogonEXE != null)
                {
                    sAPLaunchSAPGUI["SAPLogonEXE"] = SourceExpressionConverter.ConvertToken(sAPLaunchSAPGUIsAPLogonEXE);
                    sAPLaunchSAPGUIpropCount++;
                }

                if (sAPLaunchSAPGUIsAPLogonArguments != null)
                {
                    sAPLaunchSAPGUI["SAPLogonArguments"] = SourceExpressionConverter.ConvertToken(sAPLaunchSAPGUIsAPLogonArguments);
                    sAPLaunchSAPGUIpropCount++;
                }

                if (sAPLaunchSAPGUIenableSAPScripting != null)
                {
                    if (sAPLaunchSAPGUIenableSAPScripting != null)
                    {
                        sAPLaunchSAPGUI["EnableSAPScripting"] = SourceExpressionConverter.ConvertToken(sAPLaunchSAPGUIenableSAPScripting);
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
                        sAPLaunchSAPGUI["NotifyWhenScriptAttachesToGUI"] = SourceExpressionConverter.ConvertToken(sAPLaunchSAPGUInotifyWhenScriptAttachesToGUI);
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
                        sAPLaunchSAPGUI["NotifyWhenScriptOpensConnection"] = SourceExpressionConverter.ConvertToken(sAPLaunchSAPGUInotifyWhenScriptOpensConnection);
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
                        sAPLaunchSAPGUI["ShowNativeWindowsDialogs"] = SourceExpressionConverter.ConvertToken(sAPLaunchSAPGUIshowNativeWindowsDialogs);
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
                        sAPLaunchSAPGUI["AttachAfterLaunch"] = SourceExpressionConverter.ConvertToken(sAPLaunchSAPGUIattachAfterLaunch);
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
                        sAPLaunchSAPGUI["SecondsToWait"] = SourceExpressionConverter.ConvertToken(sAPLaunchSAPGUIsecondsToWait);
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
                        sAPLaunchSAPGUI["SAPProgId"] = SourceExpressionConverter.ConvertToken(sAPLaunchSAPGUIsAPProgId);
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
                        sAPLaunchSAPGUI["DisableSystemMessages"] = SourceExpressionConverter.ConvertToken(sAPLaunchSAPGUIdisableSystemMessages);
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
                sAPLaunchSAPGUI["Workflow"] = SourceExpressionConverter.ConvertToken(sAPLaunchSAPGUIworkflow);
                if (sAPLaunchSAPGUIpropCount > 0)
                {
                    callPayload.Body = sAPLaunchSAPGUI;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SAPLaunchSAPGUIResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPAttachToSAPGUIResponse> SAPAttachToSAPGUI([WorkflowExpression] Func<string> sAPAttachToSAPGUIworkflow, [WorkflowExpression] Func<string> sAPAttachToSAPGUIsAPProgId = null, [WorkflowExpression] Func<bool> sAPAttachToSAPGUIdisableSystemMessages = null)
        {
            SourceExpression.Validate(sAPAttachToSAPGUIworkflow, nameof(sAPAttachToSAPGUIworkflow), required: true);
            SourceExpression.Validate(sAPAttachToSAPGUIsAPProgId, nameof(sAPAttachToSAPGUIsAPProgId), required: false);
            SourceExpression.Validate(sAPAttachToSAPGUIdisableSystemMessages, nameof(sAPAttachToSAPGUIdisableSystemMessages), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        sAPAttachToSAPGUI["SAPProgId"] = SourceExpressionConverter.ConvertToken(sAPAttachToSAPGUIsAPProgId);
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
                        sAPAttachToSAPGUI["DisableSystemMessages"] = SourceExpressionConverter.ConvertToken(sAPAttachToSAPGUIdisableSystemMessages);
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
                sAPAttachToSAPGUI["Workflow"] = SourceExpressionConverter.ConvertToken(sAPAttachToSAPGUIworkflow);
                if (sAPAttachToSAPGUIpropCount > 0)
                {
                    callPayload.Body = sAPAttachToSAPGUI;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SAPAttachToSAPGUIResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPDetachFromSAPGUI([WorkflowExpression] Func<string> sAPDetachFromSAPGUIworkflow)
        {
            SourceExpression.Validate(sAPDetachFromSAPGUIworkflow, nameof(sAPDetachFromSAPGUIworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPDetachFromSAPGUI";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPDetachFromSAPGUI = new JObject();
                var sAPDetachFromSAPGUIpropCount = 0;
                sAPDetachFromSAPGUIpropCount++;
                sAPDetachFromSAPGUI["Workflow"] = SourceExpressionConverter.ConvertToken(sAPDetachFromSAPGUIworkflow);
                if (sAPDetachFromSAPGUIpropCount > 0)
                {
                    callPayload.Body = sAPDetachFromSAPGUI;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetSAPGUIStatusResponse> SAPGetSAPGUIStatus([WorkflowExpression] Func<string> sAPGetSAPGUIStatusworkflow)
        {
            SourceExpression.Validate(sAPGetSAPGUIStatusworkflow, nameof(sAPGetSAPGUIStatusworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPGetSAPGUIStatus";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGetSAPGUIStatus = new JObject();
                var sAPGetSAPGUIStatuspropCount = 0;
                sAPGetSAPGUIStatuspropCount++;
                sAPGetSAPGUIStatus["Workflow"] = SourceExpressionConverter.ConvertToken(sAPGetSAPGUIStatusworkflow);
                if (sAPGetSAPGUIStatuspropCount > 0)
                {
                    callPayload.Body = sAPGetSAPGUIStatus;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SAPGetSAPGUIStatusResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetSAPSessionsResponse> SAPGetSAPSessions([WorkflowExpression] Func<string> sAPGetSAPSessionsworkflow)
        {
            SourceExpression.Validate(sAPGetSAPSessionsworkflow, nameof(sAPGetSAPSessionsworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPGetSAPSessions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGetSAPSessions = new JObject();
                var sAPGetSAPSessionspropCount = 0;
                sAPGetSAPSessionspropCount++;
                sAPGetSAPSessions["Workflow"] = SourceExpressionConverter.ConvertToken(sAPGetSAPSessionsworkflow);
                if (sAPGetSAPSessionspropCount > 0)
                {
                    callPayload.Body = sAPGetSAPSessions;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SAPGetSAPSessionsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPAttachToSessionResponse> SAPAttachToSession([WorkflowExpression] Func<string> sAPAttachToSessionworkflow, [WorkflowExpression] Func<string> sAPAttachToSessionsearchConnectionName = null, [WorkflowExpression] Func<string> sAPAttachToSessionsearchSessionName = null)
        {
            SourceExpression.Validate(sAPAttachToSessionworkflow, nameof(sAPAttachToSessionworkflow), required: true);
            SourceExpression.Validate(sAPAttachToSessionsearchConnectionName, nameof(sAPAttachToSessionsearchConnectionName), required: false);
            SourceExpression.Validate(sAPAttachToSessionsearchSessionName, nameof(sAPAttachToSessionsearchSessionName), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPAttachToSession";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPAttachToSession = new JObject();
                var sAPAttachToSessionpropCount = 0;
                if (sAPAttachToSessionsearchConnectionName != null)
                {
                    sAPAttachToSession["SearchConnectionName"] = SourceExpressionConverter.ConvertToken(sAPAttachToSessionsearchConnectionName);
                    sAPAttachToSessionpropCount++;
                }

                if (sAPAttachToSessionsearchSessionName != null)
                {
                    sAPAttachToSession["SearchSessionName"] = SourceExpressionConverter.ConvertToken(sAPAttachToSessionsearchSessionName);
                    sAPAttachToSessionpropCount++;
                }

                sAPAttachToSessionpropCount++;
                sAPAttachToSession["Workflow"] = SourceExpressionConverter.ConvertToken(sAPAttachToSessionworkflow);
                if (sAPAttachToSessionpropCount > 0)
                {
                    callPayload.Body = sAPAttachToSession;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SAPAttachToSessionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPCloseSession([WorkflowExpression] Func<string> sAPCloseSessionworkflow, [WorkflowExpression] Func<bool> sAPCloseSessioncloseAttachedSession = null, [WorkflowExpression] Func<string> sAPCloseSessionsearchConnectionName = null, [WorkflowExpression] Func<string> sAPCloseSessionsearchSessionName = null)
        {
            SourceExpression.Validate(sAPCloseSessionworkflow, nameof(sAPCloseSessionworkflow), required: true);
            SourceExpression.Validate(sAPCloseSessioncloseAttachedSession, nameof(sAPCloseSessioncloseAttachedSession), required: false);
            SourceExpression.Validate(sAPCloseSessionsearchConnectionName, nameof(sAPCloseSessionsearchConnectionName), required: false);
            SourceExpression.Validate(sAPCloseSessionsearchSessionName, nameof(sAPCloseSessionsearchSessionName), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        sAPCloseSession["CloseAttachedSession"] = SourceExpressionConverter.ConvertToken(sAPCloseSessioncloseAttachedSession);
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
                    sAPCloseSession["SearchConnectionName"] = SourceExpressionConverter.ConvertToken(sAPCloseSessionsearchConnectionName);
                    sAPCloseSessionpropCount++;
                }

                if (sAPCloseSessionsearchSessionName != null)
                {
                    sAPCloseSession["SearchSessionName"] = SourceExpressionConverter.ConvertToken(sAPCloseSessionsearchSessionName);
                    sAPCloseSessionpropCount++;
                }

                sAPCloseSessionpropCount++;
                sAPCloseSession["Workflow"] = SourceExpressionConverter.ConvertToken(sAPCloseSessionworkflow);
                if (sAPCloseSessionpropCount > 0)
                {
                    callPayload.Body = sAPCloseSession;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetAttachedSessionPropertiesResponse> SAPGetAttachedSessionProperties([WorkflowExpression] Func<string> sAPGetAttachedSessionPropertiesworkflow)
        {
            SourceExpression.Validate(sAPGetAttachedSessionPropertiesworkflow, nameof(sAPGetAttachedSessionPropertiesworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPGetAttachedSessionProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGetAttachedSessionProperties = new JObject();
                var sAPGetAttachedSessionPropertiespropCount = 0;
                sAPGetAttachedSessionPropertiespropCount++;
                sAPGetAttachedSessionProperties["Workflow"] = SourceExpressionConverter.ConvertToken(sAPGetAttachedSessionPropertiesworkflow);
                if (sAPGetAttachedSessionPropertiespropCount > 0)
                {
                    callPayload.Body = sAPGetAttachedSessionProperties;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SAPGetAttachedSessionPropertiesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPWaitForAttachedSessionNotBusyResponse> SAPWaitForAttachedSessionNotBusy([WorkflowExpression] Func<double> sAPWaitForAttachedSessionNotBusysecondsToWait, [WorkflowExpression] Func<string> sAPWaitForAttachedSessionNotBusyworkflow, [WorkflowExpression] Func<bool> sAPWaitForAttachedSessionNotBusyraiseExceptionIfBusyAfterWait = null)
        {
            SourceExpression.Validate(sAPWaitForAttachedSessionNotBusysecondsToWait, nameof(sAPWaitForAttachedSessionNotBusysecondsToWait), required: true);
            SourceExpression.Validate(sAPWaitForAttachedSessionNotBusyworkflow, nameof(sAPWaitForAttachedSessionNotBusyworkflow), required: true);
            SourceExpression.Validate(sAPWaitForAttachedSessionNotBusyraiseExceptionIfBusyAfterWait, nameof(sAPWaitForAttachedSessionNotBusyraiseExceptionIfBusyAfterWait), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPWaitForAttachedSessionNotBusy";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPWaitForAttachedSessionNotBusy = new JObject();
                var sAPWaitForAttachedSessionNotBusypropCount = 0;
                sAPWaitForAttachedSessionNotBusypropCount++;
                sAPWaitForAttachedSessionNotBusy["SecondsToWait"] = SourceExpressionConverter.ConvertToken(sAPWaitForAttachedSessionNotBusysecondsToWait);
                if (sAPWaitForAttachedSessionNotBusyraiseExceptionIfBusyAfterWait != null)
                {
                    if (sAPWaitForAttachedSessionNotBusyraiseExceptionIfBusyAfterWait != null)
                    {
                        sAPWaitForAttachedSessionNotBusy["RaiseExceptionIfBusyAfterWait"] = SourceExpressionConverter.ConvertToken(sAPWaitForAttachedSessionNotBusyraiseExceptionIfBusyAfterWait);
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
                sAPWaitForAttachedSessionNotBusy["Workflow"] = SourceExpressionConverter.ConvertToken(sAPWaitForAttachedSessionNotBusyworkflow);
                if (sAPWaitForAttachedSessionNotBusypropCount > 0)
                {
                    callPayload.Body = sAPWaitForAttachedSessionNotBusy;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SAPWaitForAttachedSessionNotBusyResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPInputTextIntoSAPElement([WorkflowExpression] Func<string> sAPInputTextIntoSAPElementsearchSAPElementId, [WorkflowExpression] Func<string> sAPInputTextIntoSAPElementworkflow, [WorkflowExpression] Func<string> sAPInputTextIntoSAPElementtextToInput = null, [WorkflowExpression] Func<bool> sAPInputTextIntoSAPElementreplaceExistingValue = null, [WorkflowExpression] Func<int> sAPInputTextIntoSAPElementinsertPosition = null)
        {
            SourceExpression.Validate(sAPInputTextIntoSAPElementsearchSAPElementId, nameof(sAPInputTextIntoSAPElementsearchSAPElementId), required: true);
            SourceExpression.Validate(sAPInputTextIntoSAPElementworkflow, nameof(sAPInputTextIntoSAPElementworkflow), required: true);
            SourceExpression.Validate(sAPInputTextIntoSAPElementtextToInput, nameof(sAPInputTextIntoSAPElementtextToInput), required: false);
            SourceExpression.Validate(sAPInputTextIntoSAPElementreplaceExistingValue, nameof(sAPInputTextIntoSAPElementreplaceExistingValue), required: false);
            SourceExpression.Validate(sAPInputTextIntoSAPElementinsertPosition, nameof(sAPInputTextIntoSAPElementinsertPosition), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPInputTextIntoSAPElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPInputTextIntoSAPElement = new JObject();
                var sAPInputTextIntoSAPElementpropCount = 0;
                sAPInputTextIntoSAPElementpropCount++;
                sAPInputTextIntoSAPElement["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPInputTextIntoSAPElementsearchSAPElementId);
                if (sAPInputTextIntoSAPElementtextToInput != null)
                {
                    sAPInputTextIntoSAPElement["TextToInput"] = SourceExpressionConverter.ConvertToken(sAPInputTextIntoSAPElementtextToInput);
                    sAPInputTextIntoSAPElementpropCount++;
                }

                if (sAPInputTextIntoSAPElementreplaceExistingValue != null)
                {
                    if (sAPInputTextIntoSAPElementreplaceExistingValue != null)
                    {
                        sAPInputTextIntoSAPElement["ReplaceExistingValue"] = SourceExpressionConverter.ConvertToken(sAPInputTextIntoSAPElementreplaceExistingValue);
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
                        sAPInputTextIntoSAPElement["InsertPosition"] = SourceExpressionConverter.ConvertToken(sAPInputTextIntoSAPElementinsertPosition);
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
                sAPInputTextIntoSAPElement["Workflow"] = SourceExpressionConverter.ConvertToken(sAPInputTextIntoSAPElementworkflow);
                if (sAPInputTextIntoSAPElementpropCount > 0)
                {
                    callPayload.Body = sAPInputTextIntoSAPElement;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPInputPasswordIntoSAPElement([WorkflowExpression] Func<string> sAPInputPasswordIntoSAPElementsearchSAPElementId, [WorkflowExpression] Func<string> sAPInputPasswordIntoSAPElementpasswordToInput, [WorkflowExpression] Func<string> sAPInputPasswordIntoSAPElementworkflow)
        {
            SourceExpression.Validate(sAPInputPasswordIntoSAPElementsearchSAPElementId, nameof(sAPInputPasswordIntoSAPElementsearchSAPElementId), required: true);
            SourceExpression.Validate(sAPInputPasswordIntoSAPElementpasswordToInput, nameof(sAPInputPasswordIntoSAPElementpasswordToInput), required: true);
            SourceExpression.Validate(sAPInputPasswordIntoSAPElementworkflow, nameof(sAPInputPasswordIntoSAPElementworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPInputPasswordIntoSAPElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPInputPasswordIntoSAPElement = new JObject();
                var sAPInputPasswordIntoSAPElementpropCount = 0;
                sAPInputPasswordIntoSAPElementpropCount++;
                sAPInputPasswordIntoSAPElement["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPInputPasswordIntoSAPElementsearchSAPElementId);
                sAPInputPasswordIntoSAPElementpropCount++;
                sAPInputPasswordIntoSAPElement["PasswordToInput"] = SourceExpressionConverter.ConvertToken(sAPInputPasswordIntoSAPElementpasswordToInput);
                sAPInputPasswordIntoSAPElementpropCount++;
                sAPInputPasswordIntoSAPElement["Workflow"] = SourceExpressionConverter.ConvertToken(sAPInputPasswordIntoSAPElementworkflow);
                if (sAPInputPasswordIntoSAPElementpropCount > 0)
                {
                    callPayload.Body = sAPInputPasswordIntoSAPElement;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetElementPropertiesResponse> SAPGetElementProperties([WorkflowExpression] Func<string> sAPGetElementPropertiessearchSAPElementId, [WorkflowExpression] Func<string> sAPGetElementPropertiesworkflow)
        {
            SourceExpression.Validate(sAPGetElementPropertiessearchSAPElementId, nameof(sAPGetElementPropertiessearchSAPElementId), required: true);
            SourceExpression.Validate(sAPGetElementPropertiesworkflow, nameof(sAPGetElementPropertiesworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPGetElementProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGetElementProperties = new JObject();
                var sAPGetElementPropertiespropCount = 0;
                sAPGetElementPropertiespropCount++;
                sAPGetElementProperties["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPGetElementPropertiessearchSAPElementId);
                sAPGetElementPropertiespropCount++;
                sAPGetElementProperties["Workflow"] = SourceExpressionConverter.ConvertToken(sAPGetElementPropertiesworkflow);
                if (sAPGetElementPropertiespropCount > 0)
                {
                    callPayload.Body = sAPGetElementProperties;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SAPGetElementPropertiesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPWaitForElementIdResponse> SAPWaitForElementId([WorkflowExpression] Func<string> sAPWaitForElementIdsearchSAPElementId, [WorkflowExpression] Func<string> sAPWaitForElementIdworkflow, [WorkflowExpression] Func<double> sAPWaitForElementIdsecondsToWait = null, [WorkflowExpression] Func<bool> sAPWaitForElementIdraiseExceptionIfElementNotFound = null)
        {
            SourceExpression.Validate(sAPWaitForElementIdsearchSAPElementId, nameof(sAPWaitForElementIdsearchSAPElementId), required: true);
            SourceExpression.Validate(sAPWaitForElementIdworkflow, nameof(sAPWaitForElementIdworkflow), required: true);
            SourceExpression.Validate(sAPWaitForElementIdsecondsToWait, nameof(sAPWaitForElementIdsecondsToWait), required: false);
            SourceExpression.Validate(sAPWaitForElementIdraiseExceptionIfElementNotFound, nameof(sAPWaitForElementIdraiseExceptionIfElementNotFound), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPWaitForElementId";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPWaitForElementId = new JObject();
                var sAPWaitForElementIdpropCount = 0;
                sAPWaitForElementIdpropCount++;
                sAPWaitForElementId["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPWaitForElementIdsearchSAPElementId);
                if (sAPWaitForElementIdsecondsToWait != null)
                {
                    if (sAPWaitForElementIdsecondsToWait != null)
                    {
                        sAPWaitForElementId["SecondsToWait"] = SourceExpressionConverter.ConvertToken(sAPWaitForElementIdsecondsToWait);
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
                        sAPWaitForElementId["RaiseExceptionIfElementNotFound"] = SourceExpressionConverter.ConvertToken(sAPWaitForElementIdraiseExceptionIfElementNotFound);
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
                sAPWaitForElementId["Workflow"] = SourceExpressionConverter.ConvertToken(sAPWaitForElementIdworkflow);
                if (sAPWaitForElementIdpropCount > 0)
                {
                    callPayload.Body = sAPWaitForElementId;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SAPWaitForElementIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPWaitForWindowResponse> SAPWaitForWindow([WorkflowExpression] Func<string> sAPWaitForWindowsearchSAPWindowTitle, [WorkflowExpression] Func<string> sAPWaitForWindowworkflow, [WorkflowExpression] Func<bool> sAPWaitForWindowsearchIsRegularExpression = null, [WorkflowExpression] Func<bool> sAPWaitForWindowsearchIsCaseSensitive = null, [WorkflowExpression] Func<double> sAPWaitForWindowsecondsToWait = null, [WorkflowExpression] Func<bool> sAPWaitForWindowraiseExceptionIfElementNotFound = null)
        {
            SourceExpression.Validate(sAPWaitForWindowsearchSAPWindowTitle, nameof(sAPWaitForWindowsearchSAPWindowTitle), required: true);
            SourceExpression.Validate(sAPWaitForWindowworkflow, nameof(sAPWaitForWindowworkflow), required: true);
            SourceExpression.Validate(sAPWaitForWindowsearchIsRegularExpression, nameof(sAPWaitForWindowsearchIsRegularExpression), required: false);
            SourceExpression.Validate(sAPWaitForWindowsearchIsCaseSensitive, nameof(sAPWaitForWindowsearchIsCaseSensitive), required: false);
            SourceExpression.Validate(sAPWaitForWindowsecondsToWait, nameof(sAPWaitForWindowsecondsToWait), required: false);
            SourceExpression.Validate(sAPWaitForWindowraiseExceptionIfElementNotFound, nameof(sAPWaitForWindowraiseExceptionIfElementNotFound), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPWaitForWindow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPWaitForWindow = new JObject();
                var sAPWaitForWindowpropCount = 0;
                sAPWaitForWindowpropCount++;
                sAPWaitForWindow["SearchSAPWindowTitle"] = SourceExpressionConverter.ConvertToken(sAPWaitForWindowsearchSAPWindowTitle);
                if (sAPWaitForWindowsearchIsRegularExpression != null)
                {
                    if (sAPWaitForWindowsearchIsRegularExpression != null)
                    {
                        sAPWaitForWindow["SearchIsRegularExpression"] = SourceExpressionConverter.ConvertToken(sAPWaitForWindowsearchIsRegularExpression);
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
                        sAPWaitForWindow["SearchIsCaseSensitive"] = SourceExpressionConverter.ConvertToken(sAPWaitForWindowsearchIsCaseSensitive);
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
                        sAPWaitForWindow["SecondsToWait"] = SourceExpressionConverter.ConvertToken(sAPWaitForWindowsecondsToWait);
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
                        sAPWaitForWindow["RaiseExceptionIfElementNotFound"] = SourceExpressionConverter.ConvertToken(sAPWaitForWindowraiseExceptionIfElementNotFound);
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
                sAPWaitForWindow["Workflow"] = SourceExpressionConverter.ConvertToken(sAPWaitForWindowworkflow);
                if (sAPWaitForWindowpropCount > 0)
                {
                    callPayload.Body = sAPWaitForWindow;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SAPWaitForWindowResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetElementTextValueResponse> SAPGetElementTextValue([WorkflowExpression] Func<string> sAPGetElementTextValuesearchSAPElementId, [WorkflowExpression] Func<string> sAPGetElementTextValueworkflow)
        {
            SourceExpression.Validate(sAPGetElementTextValuesearchSAPElementId, nameof(sAPGetElementTextValuesearchSAPElementId), required: true);
            SourceExpression.Validate(sAPGetElementTextValueworkflow, nameof(sAPGetElementTextValueworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPGetElementTextValue";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGetElementTextValue = new JObject();
                var sAPGetElementTextValuepropCount = 0;
                sAPGetElementTextValuepropCount++;
                sAPGetElementTextValue["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPGetElementTextValuesearchSAPElementId);
                sAPGetElementTextValuepropCount++;
                sAPGetElementTextValue["Workflow"] = SourceExpressionConverter.ConvertToken(sAPGetElementTextValueworkflow);
                if (sAPGetElementTextValuepropCount > 0)
                {
                    callPayload.Body = sAPGetElementTextValue;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SAPGetElementTextValueResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPPressSAPElement([WorkflowExpression] Func<string> sAPPressSAPElementsearchSAPElementId, [WorkflowExpression] Func<string> sAPPressSAPElementworkflow)
        {
            SourceExpression.Validate(sAPPressSAPElementsearchSAPElementId, nameof(sAPPressSAPElementsearchSAPElementId), required: true);
            SourceExpression.Validate(sAPPressSAPElementworkflow, nameof(sAPPressSAPElementworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPPressSAPElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPPressSAPElement = new JObject();
                var sAPPressSAPElementpropCount = 0;
                sAPPressSAPElementpropCount++;
                sAPPressSAPElement["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPPressSAPElementsearchSAPElementId);
                sAPPressSAPElementpropCount++;
                sAPPressSAPElement["Workflow"] = SourceExpressionConverter.ConvertToken(sAPPressSAPElementworkflow);
                if (sAPPressSAPElementpropCount > 0)
                {
                    callPayload.Body = sAPPressSAPElement;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPSelectSAPElement([WorkflowExpression] Func<string> sAPSelectSAPElementsearchSAPElementId, [WorkflowExpression] Func<string> sAPSelectSAPElementworkflow)
        {
            SourceExpression.Validate(sAPSelectSAPElementsearchSAPElementId, nameof(sAPSelectSAPElementsearchSAPElementId), required: true);
            SourceExpression.Validate(sAPSelectSAPElementworkflow, nameof(sAPSelectSAPElementworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPSelectSAPElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPSelectSAPElement = new JObject();
                var sAPSelectSAPElementpropCount = 0;
                sAPSelectSAPElementpropCount++;
                sAPSelectSAPElement["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPSelectSAPElementsearchSAPElementId);
                sAPSelectSAPElementpropCount++;
                sAPSelectSAPElement["Workflow"] = SourceExpressionConverter.ConvertToken(sAPSelectSAPElementworkflow);
                if (sAPSelectSAPElementpropCount > 0)
                {
                    callPayload.Body = sAPSelectSAPElement;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPFocusSAPElement([WorkflowExpression] Func<string> sAPFocusSAPElementsearchSAPElementId, [WorkflowExpression] Func<string> sAPFocusSAPElementworkflow)
        {
            SourceExpression.Validate(sAPFocusSAPElementsearchSAPElementId, nameof(sAPFocusSAPElementsearchSAPElementId), required: true);
            SourceExpression.Validate(sAPFocusSAPElementworkflow, nameof(sAPFocusSAPElementworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPFocusSAPElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPFocusSAPElement = new JObject();
                var sAPFocusSAPElementpropCount = 0;
                sAPFocusSAPElementpropCount++;
                sAPFocusSAPElement["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPFocusSAPElementsearchSAPElementId);
                sAPFocusSAPElementpropCount++;
                sAPFocusSAPElement["Workflow"] = SourceExpressionConverter.ConvertToken(sAPFocusSAPElementworkflow);
                if (sAPFocusSAPElementpropCount > 0)
                {
                    callPayload.Body = sAPFocusSAPElement;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPCheckSAPElement([WorkflowExpression] Func<string> sAPCheckSAPElementsearchSAPElementId, [WorkflowExpression] Func<string> sAPCheckSAPElementworkflow, [WorkflowExpression] Func<bool> sAPCheckSAPElementcheckElement = null)
        {
            SourceExpression.Validate(sAPCheckSAPElementsearchSAPElementId, nameof(sAPCheckSAPElementsearchSAPElementId), required: true);
            SourceExpression.Validate(sAPCheckSAPElementworkflow, nameof(sAPCheckSAPElementworkflow), required: true);
            SourceExpression.Validate(sAPCheckSAPElementcheckElement, nameof(sAPCheckSAPElementcheckElement), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPCheckSAPElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPCheckSAPElement = new JObject();
                var sAPCheckSAPElementpropCount = 0;
                sAPCheckSAPElementpropCount++;
                sAPCheckSAPElement["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPCheckSAPElementsearchSAPElementId);
                if (sAPCheckSAPElementcheckElement != null)
                {
                    if (sAPCheckSAPElementcheckElement != null)
                    {
                        sAPCheckSAPElement["CheckElement"] = SourceExpressionConverter.ConvertToken(sAPCheckSAPElementcheckElement);
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
                sAPCheckSAPElement["Workflow"] = SourceExpressionConverter.ConvertToken(sAPCheckSAPElementworkflow);
                if (sAPCheckSAPElementpropCount > 0)
                {
                    callPayload.Body = sAPCheckSAPElement;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPVisualiseSAPElement([WorkflowExpression] Func<string> sAPVisualiseSAPElementsearchSAPElementId, [WorkflowExpression] Func<string> sAPVisualiseSAPElementworkflow, [WorkflowExpression] Func<bool> sAPVisualiseSAPElementvisualiseOn = null)
        {
            SourceExpression.Validate(sAPVisualiseSAPElementsearchSAPElementId, nameof(sAPVisualiseSAPElementsearchSAPElementId), required: true);
            SourceExpression.Validate(sAPVisualiseSAPElementworkflow, nameof(sAPVisualiseSAPElementworkflow), required: true);
            SourceExpression.Validate(sAPVisualiseSAPElementvisualiseOn, nameof(sAPVisualiseSAPElementvisualiseOn), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPVisualiseSAPElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPVisualiseSAPElement = new JObject();
                var sAPVisualiseSAPElementpropCount = 0;
                sAPVisualiseSAPElementpropCount++;
                sAPVisualiseSAPElement["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPVisualiseSAPElementsearchSAPElementId);
                if (sAPVisualiseSAPElementvisualiseOn != null)
                {
                    if (sAPVisualiseSAPElementvisualiseOn != null)
                    {
                        sAPVisualiseSAPElement["VisualiseOn"] = SourceExpressionConverter.ConvertToken(sAPVisualiseSAPElementvisualiseOn);
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
                sAPVisualiseSAPElement["Workflow"] = SourceExpressionConverter.ConvertToken(sAPVisualiseSAPElementworkflow);
                if (sAPVisualiseSAPElementpropCount > 0)
                {
                    callPayload.Body = sAPVisualiseSAPElement;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPDrawRectangleAroundSAPElement([WorkflowExpression] Func<string> sAPDrawRectangleAroundSAPElementsearchSAPElementId, [WorkflowExpression] Func<string> sAPDrawRectangleAroundSAPElementworkflow, [WorkflowExpression] Func<string> sAPDrawRectangleAroundSAPElementpenColour = null, [WorkflowExpression] Func<int> sAPDrawRectangleAroundSAPElementpenThicknessPixels = null)
        {
            SourceExpression.Validate(sAPDrawRectangleAroundSAPElementsearchSAPElementId, nameof(sAPDrawRectangleAroundSAPElementsearchSAPElementId), required: true);
            SourceExpression.Validate(sAPDrawRectangleAroundSAPElementworkflow, nameof(sAPDrawRectangleAroundSAPElementworkflow), required: true);
            SourceExpression.Validate(sAPDrawRectangleAroundSAPElementpenColour, nameof(sAPDrawRectangleAroundSAPElementpenColour), required: false);
            SourceExpression.Validate(sAPDrawRectangleAroundSAPElementpenThicknessPixels, nameof(sAPDrawRectangleAroundSAPElementpenThicknessPixels), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPDrawRectangleAroundSAPElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPDrawRectangleAroundSAPElement = new JObject();
                var sAPDrawRectangleAroundSAPElementpropCount = 0;
                sAPDrawRectangleAroundSAPElementpropCount++;
                sAPDrawRectangleAroundSAPElement["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPDrawRectangleAroundSAPElementsearchSAPElementId);
                if (sAPDrawRectangleAroundSAPElementpenColour != null)
                {
                    if (sAPDrawRectangleAroundSAPElementpenColour != null)
                    {
                        sAPDrawRectangleAroundSAPElement["PenColour"] = SourceExpressionConverter.ConvertToken(sAPDrawRectangleAroundSAPElementpenColour);
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
                        sAPDrawRectangleAroundSAPElement["PenThicknessPixels"] = SourceExpressionConverter.ConvertToken(sAPDrawRectangleAroundSAPElementpenThicknessPixels);
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
                sAPDrawRectangleAroundSAPElement["Workflow"] = SourceExpressionConverter.ConvertToken(sAPDrawRectangleAroundSAPElementworkflow);
                if (sAPDrawRectangleAroundSAPElementpropCount > 0)
                {
                    callPayload.Body = sAPDrawRectangleAroundSAPElement;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPSendCommand([WorkflowExpression] Func<string> sAPSendCommandsAPCommand, [WorkflowExpression] Func<string> sAPSendCommandworkflow)
        {
            SourceExpression.Validate(sAPSendCommandsAPCommand, nameof(sAPSendCommandsAPCommand), required: true);
            SourceExpression.Validate(sAPSendCommandworkflow, nameof(sAPSendCommandworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPSendCommand";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPSendCommand = new JObject();
                var sAPSendCommandpropCount = 0;
                sAPSendCommandpropCount++;
                sAPSendCommand["SAPCommand"] = SourceExpressionConverter.ConvertToken(sAPSendCommandsAPCommand);
                sAPSendCommandpropCount++;
                sAPSendCommand["Workflow"] = SourceExpressionConverter.ConvertToken(sAPSendCommandworkflow);
                if (sAPSendCommandpropCount > 0)
                {
                    callPayload.Body = sAPSendCommand;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPEnterTCode([WorkflowExpression] Func<string> sAPEnterTCodesAPTCode, [WorkflowExpression] Func<string> sAPEnterTCodeworkflow)
        {
            SourceExpression.Validate(sAPEnterTCodesAPTCode, nameof(sAPEnterTCodesAPTCode), required: true);
            SourceExpression.Validate(sAPEnterTCodeworkflow, nameof(sAPEnterTCodeworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPEnterTCode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPEnterTCode = new JObject();
                var sAPEnterTCodepropCount = 0;
                sAPEnterTCodepropCount++;
                sAPEnterTCode["SAPTCode"] = SourceExpressionConverter.ConvertToken(sAPEnterTCodesAPTCode);
                sAPEnterTCodepropCount++;
                sAPEnterTCode["Workflow"] = SourceExpressionConverter.ConvertToken(sAPEnterTCodeworkflow);
                if (sAPEnterTCodepropCount > 0)
                {
                    callPayload.Body = sAPEnterTCode;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPSendVKey([WorkflowExpression] Func<string> sAPSendVKeysearchSAPElementId, [WorkflowExpression] Func<int> sAPSendVKeysAPVKey, [WorkflowExpression] Func<string> sAPSendVKeyworkflow, [WorkflowExpression] Func<bool> sAPSendVKeydetectParentWindowElement = null)
        {
            SourceExpression.Validate(sAPSendVKeysearchSAPElementId, nameof(sAPSendVKeysearchSAPElementId), required: true);
            SourceExpression.Validate(sAPSendVKeysAPVKey, nameof(sAPSendVKeysAPVKey), required: true);
            SourceExpression.Validate(sAPSendVKeyworkflow, nameof(sAPSendVKeyworkflow), required: true);
            SourceExpression.Validate(sAPSendVKeydetectParentWindowElement, nameof(sAPSendVKeydetectParentWindowElement), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPSendVKey";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPSendVKey = new JObject();
                var sAPSendVKeypropCount = 0;
                sAPSendVKeypropCount++;
                sAPSendVKey["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPSendVKeysearchSAPElementId);
                sAPSendVKeypropCount++;
                sAPSendVKey["SAPVKey"] = SourceExpressionConverter.ConvertToken(sAPSendVKeysAPVKey);
                if (sAPSendVKeydetectParentWindowElement != null)
                {
                    if (sAPSendVKeydetectParentWindowElement != null)
                    {
                        sAPSendVKey["DetectParentWindowElement"] = SourceExpressionConverter.ConvertToken(sAPSendVKeydetectParentWindowElement);
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
                sAPSendVKey["Workflow"] = SourceExpressionConverter.ConvertToken(sAPSendVKeyworkflow);
                if (sAPSendVKeypropCount > 0)
                {
                    callPayload.Body = sAPSendVKey;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPSendEnterVKey([WorkflowExpression] Func<string> sAPSendEnterVKeysearchSAPElementId, [WorkflowExpression] Func<string> sAPSendEnterVKeyworkflow, [WorkflowExpression] Func<bool> sAPSendEnterVKeydetectParentWindowElement = null)
        {
            SourceExpression.Validate(sAPSendEnterVKeysearchSAPElementId, nameof(sAPSendEnterVKeysearchSAPElementId), required: true);
            SourceExpression.Validate(sAPSendEnterVKeyworkflow, nameof(sAPSendEnterVKeyworkflow), required: true);
            SourceExpression.Validate(sAPSendEnterVKeydetectParentWindowElement, nameof(sAPSendEnterVKeydetectParentWindowElement), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPSendEnterVKey";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPSendEnterVKey = new JObject();
                var sAPSendEnterVKeypropCount = 0;
                sAPSendEnterVKeypropCount++;
                sAPSendEnterVKey["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPSendEnterVKeysearchSAPElementId);
                if (sAPSendEnterVKeydetectParentWindowElement != null)
                {
                    if (sAPSendEnterVKeydetectParentWindowElement != null)
                    {
                        sAPSendEnterVKey["DetectParentWindowElement"] = SourceExpressionConverter.ConvertToken(sAPSendEnterVKeydetectParentWindowElement);
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
                sAPSendEnterVKey["Workflow"] = SourceExpressionConverter.ConvertToken(sAPSendEnterVKeyworkflow);
                if (sAPSendEnterVKeypropCount > 0)
                {
                    callPayload.Body = sAPSendEnterVKey;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPWindowRestore([WorkflowExpression] Func<string> sAPWindowRestoresearchSAPElementId, [WorkflowExpression] Func<string> sAPWindowRestoreworkflow, [WorkflowExpression] Func<bool> sAPWindowRestoredetectParentWindowElement = null)
        {
            SourceExpression.Validate(sAPWindowRestoresearchSAPElementId, nameof(sAPWindowRestoresearchSAPElementId), required: true);
            SourceExpression.Validate(sAPWindowRestoreworkflow, nameof(sAPWindowRestoreworkflow), required: true);
            SourceExpression.Validate(sAPWindowRestoredetectParentWindowElement, nameof(sAPWindowRestoredetectParentWindowElement), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPWindowRestore";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPWindowRestore = new JObject();
                var sAPWindowRestorepropCount = 0;
                sAPWindowRestorepropCount++;
                sAPWindowRestore["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPWindowRestoresearchSAPElementId);
                if (sAPWindowRestoredetectParentWindowElement != null)
                {
                    if (sAPWindowRestoredetectParentWindowElement != null)
                    {
                        sAPWindowRestore["DetectParentWindowElement"] = SourceExpressionConverter.ConvertToken(sAPWindowRestoredetectParentWindowElement);
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
                sAPWindowRestore["Workflow"] = SourceExpressionConverter.ConvertToken(sAPWindowRestoreworkflow);
                if (sAPWindowRestorepropCount > 0)
                {
                    callPayload.Body = sAPWindowRestore;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPWindowMaximise([WorkflowExpression] Func<string> sAPWindowMaximisesearchSAPElementId, [WorkflowExpression] Func<string> sAPWindowMaximiseworkflow, [WorkflowExpression] Func<bool> sAPWindowMaximisedetectParentWindowElement = null)
        {
            SourceExpression.Validate(sAPWindowMaximisesearchSAPElementId, nameof(sAPWindowMaximisesearchSAPElementId), required: true);
            SourceExpression.Validate(sAPWindowMaximiseworkflow, nameof(sAPWindowMaximiseworkflow), required: true);
            SourceExpression.Validate(sAPWindowMaximisedetectParentWindowElement, nameof(sAPWindowMaximisedetectParentWindowElement), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPWindowMaximise";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPWindowMaximise = new JObject();
                var sAPWindowMaximisepropCount = 0;
                sAPWindowMaximisepropCount++;
                sAPWindowMaximise["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPWindowMaximisesearchSAPElementId);
                if (sAPWindowMaximisedetectParentWindowElement != null)
                {
                    if (sAPWindowMaximisedetectParentWindowElement != null)
                    {
                        sAPWindowMaximise["DetectParentWindowElement"] = SourceExpressionConverter.ConvertToken(sAPWindowMaximisedetectParentWindowElement);
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
                sAPWindowMaximise["Workflow"] = SourceExpressionConverter.ConvertToken(sAPWindowMaximiseworkflow);
                if (sAPWindowMaximisepropCount > 0)
                {
                    callPayload.Body = sAPWindowMaximise;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPWindowMinimise([WorkflowExpression] Func<string> sAPWindowMinimisesearchSAPElementId, [WorkflowExpression] Func<string> sAPWindowMinimiseworkflow, [WorkflowExpression] Func<bool> sAPWindowMinimisedetectParentWindowElement = null)
        {
            SourceExpression.Validate(sAPWindowMinimisesearchSAPElementId, nameof(sAPWindowMinimisesearchSAPElementId), required: true);
            SourceExpression.Validate(sAPWindowMinimiseworkflow, nameof(sAPWindowMinimiseworkflow), required: true);
            SourceExpression.Validate(sAPWindowMinimisedetectParentWindowElement, nameof(sAPWindowMinimisedetectParentWindowElement), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPWindowMinimise";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPWindowMinimise = new JObject();
                var sAPWindowMinimisepropCount = 0;
                sAPWindowMinimisepropCount++;
                sAPWindowMinimise["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPWindowMinimisesearchSAPElementId);
                if (sAPWindowMinimisedetectParentWindowElement != null)
                {
                    if (sAPWindowMinimisedetectParentWindowElement != null)
                    {
                        sAPWindowMinimise["DetectParentWindowElement"] = SourceExpressionConverter.ConvertToken(sAPWindowMinimisedetectParentWindowElement);
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
                sAPWindowMinimise["Workflow"] = SourceExpressionConverter.ConvertToken(sAPWindowMinimiseworkflow);
                if (sAPWindowMinimisepropCount > 0)
                {
                    callPayload.Body = sAPWindowMinimise;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPWindowClose([WorkflowExpression] Func<string> sAPWindowClosesearchSAPElementId, [WorkflowExpression] Func<string> sAPWindowCloseworkflow, [WorkflowExpression] Func<bool> sAPWindowClosedetectParentWindowElement = null)
        {
            SourceExpression.Validate(sAPWindowClosesearchSAPElementId, nameof(sAPWindowClosesearchSAPElementId), required: true);
            SourceExpression.Validate(sAPWindowCloseworkflow, nameof(sAPWindowCloseworkflow), required: true);
            SourceExpression.Validate(sAPWindowClosedetectParentWindowElement, nameof(sAPWindowClosedetectParentWindowElement), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPWindowClose";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPWindowClose = new JObject();
                var sAPWindowClosepropCount = 0;
                sAPWindowClosepropCount++;
                sAPWindowClose["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPWindowClosesearchSAPElementId);
                if (sAPWindowClosedetectParentWindowElement != null)
                {
                    if (sAPWindowClosedetectParentWindowElement != null)
                    {
                        sAPWindowClose["DetectParentWindowElement"] = SourceExpressionConverter.ConvertToken(sAPWindowClosedetectParentWindowElement);
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
                sAPWindowClose["Workflow"] = SourceExpressionConverter.ConvertToken(sAPWindowCloseworkflow);
                if (sAPWindowClosepropCount > 0)
                {
                    callPayload.Body = sAPWindowClose;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPBringWindowToFront([WorkflowExpression] Func<string> sAPBringWindowToFrontsearchSAPElementId, [WorkflowExpression] Func<string> sAPBringWindowToFrontworkflow, [WorkflowExpression] Func<bool> sAPBringWindowToFronttoggleWindow = null, [WorkflowExpression] Func<bool> sAPBringWindowToFronttoggleUsesGlobalLeftMouseClickAgent = null, [WorkflowExpression] Func<double> sAPBringWindowToFronttoggleDelay = null, [WorkflowExpression] Func<bool> sAPBringWindowToFrontdetectParentWindowElement = null)
        {
            SourceExpression.Validate(sAPBringWindowToFrontsearchSAPElementId, nameof(sAPBringWindowToFrontsearchSAPElementId), required: true);
            SourceExpression.Validate(sAPBringWindowToFrontworkflow, nameof(sAPBringWindowToFrontworkflow), required: true);
            SourceExpression.Validate(sAPBringWindowToFronttoggleWindow, nameof(sAPBringWindowToFronttoggleWindow), required: false);
            SourceExpression.Validate(sAPBringWindowToFronttoggleUsesGlobalLeftMouseClickAgent, nameof(sAPBringWindowToFronttoggleUsesGlobalLeftMouseClickAgent), required: false);
            SourceExpression.Validate(sAPBringWindowToFronttoggleDelay, nameof(sAPBringWindowToFronttoggleDelay), required: false);
            SourceExpression.Validate(sAPBringWindowToFrontdetectParentWindowElement, nameof(sAPBringWindowToFrontdetectParentWindowElement), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPBringWindowToFront";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPBringWindowToFront = new JObject();
                var sAPBringWindowToFrontpropCount = 0;
                sAPBringWindowToFrontpropCount++;
                sAPBringWindowToFront["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPBringWindowToFrontsearchSAPElementId);
                if (sAPBringWindowToFronttoggleWindow != null)
                {
                    if (sAPBringWindowToFronttoggleWindow != null)
                    {
                        sAPBringWindowToFront["ToggleWindow"] = SourceExpressionConverter.ConvertToken(sAPBringWindowToFronttoggleWindow);
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
                        sAPBringWindowToFront["ToggleUsesGlobalLeftMouseClickAgent"] = SourceExpressionConverter.ConvertToken(sAPBringWindowToFronttoggleUsesGlobalLeftMouseClickAgent);
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
                        sAPBringWindowToFront["ToggleDelay"] = SourceExpressionConverter.ConvertToken(sAPBringWindowToFronttoggleDelay);
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
                        sAPBringWindowToFront["DetectParentWindowElement"] = SourceExpressionConverter.ConvertToken(sAPBringWindowToFrontdetectParentWindowElement);
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
                sAPBringWindowToFront["Workflow"] = SourceExpressionConverter.ConvertToken(sAPBringWindowToFrontworkflow);
                if (sAPBringWindowToFrontpropCount > 0)
                {
                    callPayload.Body = sAPBringWindowToFront;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPGlobalLeftMouseClickOnSAPElement([WorkflowExpression] Func<string> sAPGlobalLeftMouseClickOnSAPElementsearchSAPElementId, [WorkflowExpression] Func<string> sAPGlobalLeftMouseClickOnSAPElementworkflow, [WorkflowExpression] Func<bool> sAPGlobalLeftMouseClickOnSAPElementsetElementWindowTopMost = null, [WorkflowExpression] Func<bool> sAPGlobalLeftMouseClickOnSAPElementbringElementWindowToFront = null, [WorkflowExpression] Func<bool> sAPGlobalLeftMouseClickOnSAPElementtoggleWindow = null, [WorkflowExpression] Func<bool> sAPGlobalLeftMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent = null, [WorkflowExpression] Func<double> sAPGlobalLeftMouseClickOnSAPElementtoggleDelay = null, [WorkflowExpression] Func<int> sAPGlobalLeftMouseClickOnSAPElementclickOffsetX = null, [WorkflowExpression] Func<int> sAPGlobalLeftMouseClickOnSAPElementclickOffsetY = null, [WorkflowExpression] Func<sAPGlobalLeftMouseClickOnSAPElementoffsetRelativeToInput> sAPGlobalLeftMouseClickOnSAPElementoffsetRelativeTo = null)
        {
            SourceExpression.Validate(sAPGlobalLeftMouseClickOnSAPElementsearchSAPElementId, nameof(sAPGlobalLeftMouseClickOnSAPElementsearchSAPElementId), required: true);
            SourceExpression.Validate(sAPGlobalLeftMouseClickOnSAPElementworkflow, nameof(sAPGlobalLeftMouseClickOnSAPElementworkflow), required: true);
            SourceExpression.Validate(sAPGlobalLeftMouseClickOnSAPElementsetElementWindowTopMost, nameof(sAPGlobalLeftMouseClickOnSAPElementsetElementWindowTopMost), required: false);
            SourceExpression.Validate(sAPGlobalLeftMouseClickOnSAPElementbringElementWindowToFront, nameof(sAPGlobalLeftMouseClickOnSAPElementbringElementWindowToFront), required: false);
            SourceExpression.Validate(sAPGlobalLeftMouseClickOnSAPElementtoggleWindow, nameof(sAPGlobalLeftMouseClickOnSAPElementtoggleWindow), required: false);
            SourceExpression.Validate(sAPGlobalLeftMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent, nameof(sAPGlobalLeftMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent), required: false);
            SourceExpression.Validate(sAPGlobalLeftMouseClickOnSAPElementtoggleDelay, nameof(sAPGlobalLeftMouseClickOnSAPElementtoggleDelay), required: false);
            SourceExpression.Validate(sAPGlobalLeftMouseClickOnSAPElementclickOffsetX, nameof(sAPGlobalLeftMouseClickOnSAPElementclickOffsetX), required: false);
            SourceExpression.Validate(sAPGlobalLeftMouseClickOnSAPElementclickOffsetY, nameof(sAPGlobalLeftMouseClickOnSAPElementclickOffsetY), required: false);
            SourceExpression.Validate(sAPGlobalLeftMouseClickOnSAPElementoffsetRelativeTo, nameof(sAPGlobalLeftMouseClickOnSAPElementoffsetRelativeTo), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPGlobalLeftMouseClickOnSAPElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGlobalLeftMouseClickOnSAPElement = new JObject();
                var sAPGlobalLeftMouseClickOnSAPElementpropCount = 0;
                sAPGlobalLeftMouseClickOnSAPElementpropCount++;
                sAPGlobalLeftMouseClickOnSAPElement["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPGlobalLeftMouseClickOnSAPElementsearchSAPElementId);
                if (sAPGlobalLeftMouseClickOnSAPElementsetElementWindowTopMost != null)
                {
                    if (sAPGlobalLeftMouseClickOnSAPElementsetElementWindowTopMost != null)
                    {
                        sAPGlobalLeftMouseClickOnSAPElement["SetElementWindowTopMost"] = SourceExpressionConverter.ConvertToken(sAPGlobalLeftMouseClickOnSAPElementsetElementWindowTopMost);
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
                        sAPGlobalLeftMouseClickOnSAPElement["BringElementWindowToFront"] = SourceExpressionConverter.ConvertToken(sAPGlobalLeftMouseClickOnSAPElementbringElementWindowToFront);
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
                        sAPGlobalLeftMouseClickOnSAPElement["ToggleWindow"] = SourceExpressionConverter.ConvertToken(sAPGlobalLeftMouseClickOnSAPElementtoggleWindow);
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
                        sAPGlobalLeftMouseClickOnSAPElement["ToggleUsesGlobalLeftMouseClickAgent"] = SourceExpressionConverter.ConvertToken(sAPGlobalLeftMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent);
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
                        sAPGlobalLeftMouseClickOnSAPElement["ToggleDelay"] = SourceExpressionConverter.ConvertToken(sAPGlobalLeftMouseClickOnSAPElementtoggleDelay);
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
                        sAPGlobalLeftMouseClickOnSAPElement["ClickOffsetX"] = SourceExpressionConverter.ConvertToken(sAPGlobalLeftMouseClickOnSAPElementclickOffsetX);
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
                        sAPGlobalLeftMouseClickOnSAPElement["ClickOffsetY"] = SourceExpressionConverter.ConvertToken(sAPGlobalLeftMouseClickOnSAPElementclickOffsetY);
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
                    sAPGlobalLeftMouseClickOnSAPElement["OffsetRelativeTo"] = SourceExpressionConverter.Convert(sAPGlobalLeftMouseClickOnSAPElementoffsetRelativeTo);
                    sAPGlobalLeftMouseClickOnSAPElementpropCount++;
                }

                sAPGlobalLeftMouseClickOnSAPElementpropCount++;
                sAPGlobalLeftMouseClickOnSAPElement["Workflow"] = SourceExpressionConverter.ConvertToken(sAPGlobalLeftMouseClickOnSAPElementworkflow);
                if (sAPGlobalLeftMouseClickOnSAPElementpropCount > 0)
                {
                    callPayload.Body = sAPGlobalLeftMouseClickOnSAPElement;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPGlobalRightMouseClickOnSAPElement([WorkflowExpression] Func<string> sAPGlobalRightMouseClickOnSAPElementsearchSAPElementId, [WorkflowExpression] Func<string> sAPGlobalRightMouseClickOnSAPElementworkflow, [WorkflowExpression] Func<bool> sAPGlobalRightMouseClickOnSAPElementsetElementWindowTopMost = null, [WorkflowExpression] Func<bool> sAPGlobalRightMouseClickOnSAPElementbringElementWindowToFront = null, [WorkflowExpression] Func<bool> sAPGlobalRightMouseClickOnSAPElementtoggleWindow = null, [WorkflowExpression] Func<bool> sAPGlobalRightMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent = null, [WorkflowExpression] Func<double> sAPGlobalRightMouseClickOnSAPElementtoggleDelay = null, [WorkflowExpression] Func<int> sAPGlobalRightMouseClickOnSAPElementclickOffsetX = null, [WorkflowExpression] Func<int> sAPGlobalRightMouseClickOnSAPElementclickOffsetY = null, [WorkflowExpression] Func<sAPGlobalRightMouseClickOnSAPElementoffsetRelativeToInput> sAPGlobalRightMouseClickOnSAPElementoffsetRelativeTo = null)
        {
            SourceExpression.Validate(sAPGlobalRightMouseClickOnSAPElementsearchSAPElementId, nameof(sAPGlobalRightMouseClickOnSAPElementsearchSAPElementId), required: true);
            SourceExpression.Validate(sAPGlobalRightMouseClickOnSAPElementworkflow, nameof(sAPGlobalRightMouseClickOnSAPElementworkflow), required: true);
            SourceExpression.Validate(sAPGlobalRightMouseClickOnSAPElementsetElementWindowTopMost, nameof(sAPGlobalRightMouseClickOnSAPElementsetElementWindowTopMost), required: false);
            SourceExpression.Validate(sAPGlobalRightMouseClickOnSAPElementbringElementWindowToFront, nameof(sAPGlobalRightMouseClickOnSAPElementbringElementWindowToFront), required: false);
            SourceExpression.Validate(sAPGlobalRightMouseClickOnSAPElementtoggleWindow, nameof(sAPGlobalRightMouseClickOnSAPElementtoggleWindow), required: false);
            SourceExpression.Validate(sAPGlobalRightMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent, nameof(sAPGlobalRightMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent), required: false);
            SourceExpression.Validate(sAPGlobalRightMouseClickOnSAPElementtoggleDelay, nameof(sAPGlobalRightMouseClickOnSAPElementtoggleDelay), required: false);
            SourceExpression.Validate(sAPGlobalRightMouseClickOnSAPElementclickOffsetX, nameof(sAPGlobalRightMouseClickOnSAPElementclickOffsetX), required: false);
            SourceExpression.Validate(sAPGlobalRightMouseClickOnSAPElementclickOffsetY, nameof(sAPGlobalRightMouseClickOnSAPElementclickOffsetY), required: false);
            SourceExpression.Validate(sAPGlobalRightMouseClickOnSAPElementoffsetRelativeTo, nameof(sAPGlobalRightMouseClickOnSAPElementoffsetRelativeTo), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPGlobalRightMouseClickOnSAPElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGlobalRightMouseClickOnSAPElement = new JObject();
                var sAPGlobalRightMouseClickOnSAPElementpropCount = 0;
                sAPGlobalRightMouseClickOnSAPElementpropCount++;
                sAPGlobalRightMouseClickOnSAPElement["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPGlobalRightMouseClickOnSAPElementsearchSAPElementId);
                if (sAPGlobalRightMouseClickOnSAPElementsetElementWindowTopMost != null)
                {
                    if (sAPGlobalRightMouseClickOnSAPElementsetElementWindowTopMost != null)
                    {
                        sAPGlobalRightMouseClickOnSAPElement["SetElementWindowTopMost"] = SourceExpressionConverter.ConvertToken(sAPGlobalRightMouseClickOnSAPElementsetElementWindowTopMost);
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
                        sAPGlobalRightMouseClickOnSAPElement["BringElementWindowToFront"] = SourceExpressionConverter.ConvertToken(sAPGlobalRightMouseClickOnSAPElementbringElementWindowToFront);
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
                        sAPGlobalRightMouseClickOnSAPElement["ToggleWindow"] = SourceExpressionConverter.ConvertToken(sAPGlobalRightMouseClickOnSAPElementtoggleWindow);
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
                        sAPGlobalRightMouseClickOnSAPElement["ToggleUsesGlobalLeftMouseClickAgent"] = SourceExpressionConverter.ConvertToken(sAPGlobalRightMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent);
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
                        sAPGlobalRightMouseClickOnSAPElement["ToggleDelay"] = SourceExpressionConverter.ConvertToken(sAPGlobalRightMouseClickOnSAPElementtoggleDelay);
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
                        sAPGlobalRightMouseClickOnSAPElement["ClickOffsetX"] = SourceExpressionConverter.ConvertToken(sAPGlobalRightMouseClickOnSAPElementclickOffsetX);
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
                        sAPGlobalRightMouseClickOnSAPElement["ClickOffsetY"] = SourceExpressionConverter.ConvertToken(sAPGlobalRightMouseClickOnSAPElementclickOffsetY);
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
                    sAPGlobalRightMouseClickOnSAPElement["OffsetRelativeTo"] = SourceExpressionConverter.Convert(sAPGlobalRightMouseClickOnSAPElementoffsetRelativeTo);
                    sAPGlobalRightMouseClickOnSAPElementpropCount++;
                }

                sAPGlobalRightMouseClickOnSAPElementpropCount++;
                sAPGlobalRightMouseClickOnSAPElement["Workflow"] = SourceExpressionConverter.ConvertToken(sAPGlobalRightMouseClickOnSAPElementworkflow);
                if (sAPGlobalRightMouseClickOnSAPElementpropCount > 0)
                {
                    callPayload.Body = sAPGlobalRightMouseClickOnSAPElement;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPGlobalMiddleMouseClickOnSAPElement([WorkflowExpression] Func<string> sAPGlobalMiddleMouseClickOnSAPElementsearchSAPElementId, [WorkflowExpression] Func<string> sAPGlobalMiddleMouseClickOnSAPElementworkflow, [WorkflowExpression] Func<bool> sAPGlobalMiddleMouseClickOnSAPElementsetElementWindowTopMost = null, [WorkflowExpression] Func<bool> sAPGlobalMiddleMouseClickOnSAPElementbringElementWindowToFront = null, [WorkflowExpression] Func<bool> sAPGlobalMiddleMouseClickOnSAPElementtoggleWindow = null, [WorkflowExpression] Func<bool> sAPGlobalMiddleMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent = null, [WorkflowExpression] Func<double> sAPGlobalMiddleMouseClickOnSAPElementtoggleDelay = null, [WorkflowExpression] Func<int> sAPGlobalMiddleMouseClickOnSAPElementclickOffsetX = null, [WorkflowExpression] Func<int> sAPGlobalMiddleMouseClickOnSAPElementclickOffsetY = null, [WorkflowExpression] Func<sAPGlobalMiddleMouseClickOnSAPElementoffsetRelativeToInput> sAPGlobalMiddleMouseClickOnSAPElementoffsetRelativeTo = null)
        {
            SourceExpression.Validate(sAPGlobalMiddleMouseClickOnSAPElementsearchSAPElementId, nameof(sAPGlobalMiddleMouseClickOnSAPElementsearchSAPElementId), required: true);
            SourceExpression.Validate(sAPGlobalMiddleMouseClickOnSAPElementworkflow, nameof(sAPGlobalMiddleMouseClickOnSAPElementworkflow), required: true);
            SourceExpression.Validate(sAPGlobalMiddleMouseClickOnSAPElementsetElementWindowTopMost, nameof(sAPGlobalMiddleMouseClickOnSAPElementsetElementWindowTopMost), required: false);
            SourceExpression.Validate(sAPGlobalMiddleMouseClickOnSAPElementbringElementWindowToFront, nameof(sAPGlobalMiddleMouseClickOnSAPElementbringElementWindowToFront), required: false);
            SourceExpression.Validate(sAPGlobalMiddleMouseClickOnSAPElementtoggleWindow, nameof(sAPGlobalMiddleMouseClickOnSAPElementtoggleWindow), required: false);
            SourceExpression.Validate(sAPGlobalMiddleMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent, nameof(sAPGlobalMiddleMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent), required: false);
            SourceExpression.Validate(sAPGlobalMiddleMouseClickOnSAPElementtoggleDelay, nameof(sAPGlobalMiddleMouseClickOnSAPElementtoggleDelay), required: false);
            SourceExpression.Validate(sAPGlobalMiddleMouseClickOnSAPElementclickOffsetX, nameof(sAPGlobalMiddleMouseClickOnSAPElementclickOffsetX), required: false);
            SourceExpression.Validate(sAPGlobalMiddleMouseClickOnSAPElementclickOffsetY, nameof(sAPGlobalMiddleMouseClickOnSAPElementclickOffsetY), required: false);
            SourceExpression.Validate(sAPGlobalMiddleMouseClickOnSAPElementoffsetRelativeTo, nameof(sAPGlobalMiddleMouseClickOnSAPElementoffsetRelativeTo), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPGlobalMiddleMouseClickOnSAPElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGlobalMiddleMouseClickOnSAPElement = new JObject();
                var sAPGlobalMiddleMouseClickOnSAPElementpropCount = 0;
                sAPGlobalMiddleMouseClickOnSAPElementpropCount++;
                sAPGlobalMiddleMouseClickOnSAPElement["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPGlobalMiddleMouseClickOnSAPElementsearchSAPElementId);
                if (sAPGlobalMiddleMouseClickOnSAPElementsetElementWindowTopMost != null)
                {
                    if (sAPGlobalMiddleMouseClickOnSAPElementsetElementWindowTopMost != null)
                    {
                        sAPGlobalMiddleMouseClickOnSAPElement["SetElementWindowTopMost"] = SourceExpressionConverter.ConvertToken(sAPGlobalMiddleMouseClickOnSAPElementsetElementWindowTopMost);
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
                        sAPGlobalMiddleMouseClickOnSAPElement["BringElementWindowToFront"] = SourceExpressionConverter.ConvertToken(sAPGlobalMiddleMouseClickOnSAPElementbringElementWindowToFront);
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
                        sAPGlobalMiddleMouseClickOnSAPElement["ToggleWindow"] = SourceExpressionConverter.ConvertToken(sAPGlobalMiddleMouseClickOnSAPElementtoggleWindow);
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
                        sAPGlobalMiddleMouseClickOnSAPElement["ToggleUsesGlobalLeftMouseClickAgent"] = SourceExpressionConverter.ConvertToken(sAPGlobalMiddleMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent);
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
                        sAPGlobalMiddleMouseClickOnSAPElement["ToggleDelay"] = SourceExpressionConverter.ConvertToken(sAPGlobalMiddleMouseClickOnSAPElementtoggleDelay);
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
                        sAPGlobalMiddleMouseClickOnSAPElement["ClickOffsetX"] = SourceExpressionConverter.ConvertToken(sAPGlobalMiddleMouseClickOnSAPElementclickOffsetX);
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
                        sAPGlobalMiddleMouseClickOnSAPElement["ClickOffsetY"] = SourceExpressionConverter.ConvertToken(sAPGlobalMiddleMouseClickOnSAPElementclickOffsetY);
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
                    sAPGlobalMiddleMouseClickOnSAPElement["OffsetRelativeTo"] = SourceExpressionConverter.Convert(sAPGlobalMiddleMouseClickOnSAPElementoffsetRelativeTo);
                    sAPGlobalMiddleMouseClickOnSAPElementpropCount++;
                }

                sAPGlobalMiddleMouseClickOnSAPElementpropCount++;
                sAPGlobalMiddleMouseClickOnSAPElement["Workflow"] = SourceExpressionConverter.ConvertToken(sAPGlobalMiddleMouseClickOnSAPElementworkflow);
                if (sAPGlobalMiddleMouseClickOnSAPElementpropCount > 0)
                {
                    callPayload.Body = sAPGlobalMiddleMouseClickOnSAPElement;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPGlobalDoubleLeftMouseClickOnSAPElement([WorkflowExpression] Func<string> sAPGlobalDoubleLeftMouseClickOnSAPElementsearchSAPElementId, [WorkflowExpression] Func<string> sAPGlobalDoubleLeftMouseClickOnSAPElementworkflow, [WorkflowExpression] Func<bool> sAPGlobalDoubleLeftMouseClickOnSAPElementsetElementWindowTopMost = null, [WorkflowExpression] Func<bool> sAPGlobalDoubleLeftMouseClickOnSAPElementbringElementWindowToFront = null, [WorkflowExpression] Func<bool> sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleWindow = null, [WorkflowExpression] Func<bool> sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent = null, [WorkflowExpression] Func<double> sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleDelay = null, [WorkflowExpression] Func<int> sAPGlobalDoubleLeftMouseClickOnSAPElementclickOffsetX = null, [WorkflowExpression] Func<int> sAPGlobalDoubleLeftMouseClickOnSAPElementclickOffsetY = null, [WorkflowExpression] Func<sAPGlobalDoubleLeftMouseClickOnSAPElementoffsetRelativeToInput> sAPGlobalDoubleLeftMouseClickOnSAPElementoffsetRelativeTo = null, [WorkflowExpression] Func<int> sAPGlobalDoubleLeftMouseClickOnSAPElementdoubleClickDelayInMilliseconds = null)
        {
            SourceExpression.Validate(sAPGlobalDoubleLeftMouseClickOnSAPElementsearchSAPElementId, nameof(sAPGlobalDoubleLeftMouseClickOnSAPElementsearchSAPElementId), required: true);
            SourceExpression.Validate(sAPGlobalDoubleLeftMouseClickOnSAPElementworkflow, nameof(sAPGlobalDoubleLeftMouseClickOnSAPElementworkflow), required: true);
            SourceExpression.Validate(sAPGlobalDoubleLeftMouseClickOnSAPElementsetElementWindowTopMost, nameof(sAPGlobalDoubleLeftMouseClickOnSAPElementsetElementWindowTopMost), required: false);
            SourceExpression.Validate(sAPGlobalDoubleLeftMouseClickOnSAPElementbringElementWindowToFront, nameof(sAPGlobalDoubleLeftMouseClickOnSAPElementbringElementWindowToFront), required: false);
            SourceExpression.Validate(sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleWindow, nameof(sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleWindow), required: false);
            SourceExpression.Validate(sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent, nameof(sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent), required: false);
            SourceExpression.Validate(sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleDelay, nameof(sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleDelay), required: false);
            SourceExpression.Validate(sAPGlobalDoubleLeftMouseClickOnSAPElementclickOffsetX, nameof(sAPGlobalDoubleLeftMouseClickOnSAPElementclickOffsetX), required: false);
            SourceExpression.Validate(sAPGlobalDoubleLeftMouseClickOnSAPElementclickOffsetY, nameof(sAPGlobalDoubleLeftMouseClickOnSAPElementclickOffsetY), required: false);
            SourceExpression.Validate(sAPGlobalDoubleLeftMouseClickOnSAPElementoffsetRelativeTo, nameof(sAPGlobalDoubleLeftMouseClickOnSAPElementoffsetRelativeTo), required: false);
            SourceExpression.Validate(sAPGlobalDoubleLeftMouseClickOnSAPElementdoubleClickDelayInMilliseconds, nameof(sAPGlobalDoubleLeftMouseClickOnSAPElementdoubleClickDelayInMilliseconds), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPGlobalDoubleLeftMouseClickOnSAPElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGlobalDoubleLeftMouseClickOnSAPElement = new JObject();
                var sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount = 0;
                sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount++;
                sAPGlobalDoubleLeftMouseClickOnSAPElement["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPGlobalDoubleLeftMouseClickOnSAPElementsearchSAPElementId);
                if (sAPGlobalDoubleLeftMouseClickOnSAPElementsetElementWindowTopMost != null)
                {
                    if (sAPGlobalDoubleLeftMouseClickOnSAPElementsetElementWindowTopMost != null)
                    {
                        sAPGlobalDoubleLeftMouseClickOnSAPElement["SetElementWindowTopMost"] = SourceExpressionConverter.ConvertToken(sAPGlobalDoubleLeftMouseClickOnSAPElementsetElementWindowTopMost);
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
                        sAPGlobalDoubleLeftMouseClickOnSAPElement["BringElementWindowToFront"] = SourceExpressionConverter.ConvertToken(sAPGlobalDoubleLeftMouseClickOnSAPElementbringElementWindowToFront);
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
                        sAPGlobalDoubleLeftMouseClickOnSAPElement["ToggleWindow"] = SourceExpressionConverter.ConvertToken(sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleWindow);
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
                        sAPGlobalDoubleLeftMouseClickOnSAPElement["ToggleUsesGlobalLeftMouseClickAgent"] = SourceExpressionConverter.ConvertToken(sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent);
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
                        sAPGlobalDoubleLeftMouseClickOnSAPElement["ToggleDelay"] = SourceExpressionConverter.ConvertToken(sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleDelay);
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
                        sAPGlobalDoubleLeftMouseClickOnSAPElement["ClickOffsetX"] = SourceExpressionConverter.ConvertToken(sAPGlobalDoubleLeftMouseClickOnSAPElementclickOffsetX);
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
                        sAPGlobalDoubleLeftMouseClickOnSAPElement["ClickOffsetY"] = SourceExpressionConverter.ConvertToken(sAPGlobalDoubleLeftMouseClickOnSAPElementclickOffsetY);
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
                    sAPGlobalDoubleLeftMouseClickOnSAPElement["OffsetRelativeTo"] = SourceExpressionConverter.Convert(sAPGlobalDoubleLeftMouseClickOnSAPElementoffsetRelativeTo);
                    sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount++;
                }

                if (sAPGlobalDoubleLeftMouseClickOnSAPElementdoubleClickDelayInMilliseconds != null)
                {
                    if (sAPGlobalDoubleLeftMouseClickOnSAPElementdoubleClickDelayInMilliseconds != null)
                    {
                        sAPGlobalDoubleLeftMouseClickOnSAPElement["DoubleClickDelayInMilliseconds"] = SourceExpressionConverter.ConvertToken(sAPGlobalDoubleLeftMouseClickOnSAPElementdoubleClickDelayInMilliseconds);
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
                sAPGlobalDoubleLeftMouseClickOnSAPElement["Workflow"] = SourceExpressionConverter.ConvertToken(sAPGlobalDoubleLeftMouseClickOnSAPElementworkflow);
                if (sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount > 0)
                {
                    callPayload.Body = sAPGlobalDoubleLeftMouseClickOnSAPElement;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPGlobalInputTextIntoSAPElement([WorkflowExpression] Func<string> sAPGlobalInputTextIntoSAPElementsearchSAPElementId, [WorkflowExpression] Func<string> sAPGlobalInputTextIntoSAPElementworkflow, [WorkflowExpression] Func<bool> sAPGlobalInputTextIntoSAPElementsetElementWindowTopMost = null, [WorkflowExpression] Func<bool> sAPGlobalInputTextIntoSAPElementbringElementWindowToFront = null, [WorkflowExpression] Func<bool> sAPGlobalInputTextIntoSAPElementtoggleWindow = null, [WorkflowExpression] Func<bool> sAPGlobalInputTextIntoSAPElementtoggleUsesGlobalLeftMouseClickAgent = null, [WorkflowExpression] Func<double> sAPGlobalInputTextIntoSAPElementtoggleDelay = null, [WorkflowExpression] Func<bool> sAPGlobalInputTextIntoSAPElementglobalMouseClickOnElement = null, [WorkflowExpression] Func<bool> sAPGlobalInputTextIntoSAPElementreplaceExistingValueUsingDoubleClickDelete = null, [WorkflowExpression] Func<bool> sAPGlobalInputTextIntoSAPElementreplaceExistingValueUsingCTRLADelete = null, [WorkflowExpression] Func<string> sAPGlobalInputTextIntoSAPElementtextToInput = null, [WorkflowExpression] Func<bool> sAPGlobalInputTextIntoSAPElementsendKeyEvents = null, [WorkflowExpression] Func<int> sAPGlobalInputTextIntoSAPElementkeyIntervalInMilliseconds = null, [WorkflowExpression] Func<int> sAPGlobalInputTextIntoSAPElementdoubleClickIntervalInMilliseconds = null, [WorkflowExpression] Func<bool> sAPGlobalInputTextIntoSAPElementdontInterpretSymbols = null)
        {
            SourceExpression.Validate(sAPGlobalInputTextIntoSAPElementsearchSAPElementId, nameof(sAPGlobalInputTextIntoSAPElementsearchSAPElementId), required: true);
            SourceExpression.Validate(sAPGlobalInputTextIntoSAPElementworkflow, nameof(sAPGlobalInputTextIntoSAPElementworkflow), required: true);
            SourceExpression.Validate(sAPGlobalInputTextIntoSAPElementsetElementWindowTopMost, nameof(sAPGlobalInputTextIntoSAPElementsetElementWindowTopMost), required: false);
            SourceExpression.Validate(sAPGlobalInputTextIntoSAPElementbringElementWindowToFront, nameof(sAPGlobalInputTextIntoSAPElementbringElementWindowToFront), required: false);
            SourceExpression.Validate(sAPGlobalInputTextIntoSAPElementtoggleWindow, nameof(sAPGlobalInputTextIntoSAPElementtoggleWindow), required: false);
            SourceExpression.Validate(sAPGlobalInputTextIntoSAPElementtoggleUsesGlobalLeftMouseClickAgent, nameof(sAPGlobalInputTextIntoSAPElementtoggleUsesGlobalLeftMouseClickAgent), required: false);
            SourceExpression.Validate(sAPGlobalInputTextIntoSAPElementtoggleDelay, nameof(sAPGlobalInputTextIntoSAPElementtoggleDelay), required: false);
            SourceExpression.Validate(sAPGlobalInputTextIntoSAPElementglobalMouseClickOnElement, nameof(sAPGlobalInputTextIntoSAPElementglobalMouseClickOnElement), required: false);
            SourceExpression.Validate(sAPGlobalInputTextIntoSAPElementreplaceExistingValueUsingDoubleClickDelete, nameof(sAPGlobalInputTextIntoSAPElementreplaceExistingValueUsingDoubleClickDelete), required: false);
            SourceExpression.Validate(sAPGlobalInputTextIntoSAPElementreplaceExistingValueUsingCTRLADelete, nameof(sAPGlobalInputTextIntoSAPElementreplaceExistingValueUsingCTRLADelete), required: false);
            SourceExpression.Validate(sAPGlobalInputTextIntoSAPElementtextToInput, nameof(sAPGlobalInputTextIntoSAPElementtextToInput), required: false);
            SourceExpression.Validate(sAPGlobalInputTextIntoSAPElementsendKeyEvents, nameof(sAPGlobalInputTextIntoSAPElementsendKeyEvents), required: false);
            SourceExpression.Validate(sAPGlobalInputTextIntoSAPElementkeyIntervalInMilliseconds, nameof(sAPGlobalInputTextIntoSAPElementkeyIntervalInMilliseconds), required: false);
            SourceExpression.Validate(sAPGlobalInputTextIntoSAPElementdoubleClickIntervalInMilliseconds, nameof(sAPGlobalInputTextIntoSAPElementdoubleClickIntervalInMilliseconds), required: false);
            SourceExpression.Validate(sAPGlobalInputTextIntoSAPElementdontInterpretSymbols, nameof(sAPGlobalInputTextIntoSAPElementdontInterpretSymbols), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPGlobalInputTextIntoSAPElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGlobalInputTextIntoSAPElement = new JObject();
                var sAPGlobalInputTextIntoSAPElementpropCount = 0;
                sAPGlobalInputTextIntoSAPElementpropCount++;
                sAPGlobalInputTextIntoSAPElement["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPGlobalInputTextIntoSAPElementsearchSAPElementId);
                if (sAPGlobalInputTextIntoSAPElementsetElementWindowTopMost != null)
                {
                    if (sAPGlobalInputTextIntoSAPElementsetElementWindowTopMost != null)
                    {
                        sAPGlobalInputTextIntoSAPElement["SetElementWindowTopMost"] = SourceExpressionConverter.ConvertToken(sAPGlobalInputTextIntoSAPElementsetElementWindowTopMost);
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
                        sAPGlobalInputTextIntoSAPElement["BringElementWindowToFront"] = SourceExpressionConverter.ConvertToken(sAPGlobalInputTextIntoSAPElementbringElementWindowToFront);
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
                        sAPGlobalInputTextIntoSAPElement["ToggleWindow"] = SourceExpressionConverter.ConvertToken(sAPGlobalInputTextIntoSAPElementtoggleWindow);
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
                        sAPGlobalInputTextIntoSAPElement["ToggleUsesGlobalLeftMouseClickAgent"] = SourceExpressionConverter.ConvertToken(sAPGlobalInputTextIntoSAPElementtoggleUsesGlobalLeftMouseClickAgent);
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
                        sAPGlobalInputTextIntoSAPElement["ToggleDelay"] = SourceExpressionConverter.ConvertToken(sAPGlobalInputTextIntoSAPElementtoggleDelay);
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
                        sAPGlobalInputTextIntoSAPElement["GlobalMouseClickOnElement"] = SourceExpressionConverter.ConvertToken(sAPGlobalInputTextIntoSAPElementglobalMouseClickOnElement);
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
                        sAPGlobalInputTextIntoSAPElement["ReplaceExistingValueUsingDoubleClickDelete"] = SourceExpressionConverter.ConvertToken(sAPGlobalInputTextIntoSAPElementreplaceExistingValueUsingDoubleClickDelete);
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
                        sAPGlobalInputTextIntoSAPElement["ReplaceExistingValueUsingCTRLADelete"] = SourceExpressionConverter.ConvertToken(sAPGlobalInputTextIntoSAPElementreplaceExistingValueUsingCTRLADelete);
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
                    sAPGlobalInputTextIntoSAPElement["TextToInput"] = SourceExpressionConverter.ConvertToken(sAPGlobalInputTextIntoSAPElementtextToInput);
                    sAPGlobalInputTextIntoSAPElementpropCount++;
                }

                if (sAPGlobalInputTextIntoSAPElementsendKeyEvents != null)
                {
                    if (sAPGlobalInputTextIntoSAPElementsendKeyEvents != null)
                    {
                        sAPGlobalInputTextIntoSAPElement["SendKeyEvents"] = SourceExpressionConverter.ConvertToken(sAPGlobalInputTextIntoSAPElementsendKeyEvents);
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
                        sAPGlobalInputTextIntoSAPElement["KeyIntervalInMilliseconds"] = SourceExpressionConverter.ConvertToken(sAPGlobalInputTextIntoSAPElementkeyIntervalInMilliseconds);
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
                        sAPGlobalInputTextIntoSAPElement["DoubleClickIntervalInMilliseconds"] = SourceExpressionConverter.ConvertToken(sAPGlobalInputTextIntoSAPElementdoubleClickIntervalInMilliseconds);
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
                        sAPGlobalInputTextIntoSAPElement["DontInterpretSymbols"] = SourceExpressionConverter.ConvertToken(sAPGlobalInputTextIntoSAPElementdontInterpretSymbols);
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
                sAPGlobalInputTextIntoSAPElement["Workflow"] = SourceExpressionConverter.ConvertToken(sAPGlobalInputTextIntoSAPElementworkflow);
                if (sAPGlobalInputTextIntoSAPElementpropCount > 0)
                {
                    callPayload.Body = sAPGlobalInputTextIntoSAPElement;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPGlobalInputPasswordIntoSAPElement([WorkflowExpression] Func<string> sAPGlobalInputPasswordIntoSAPElementsearchSAPElementId, [WorkflowExpression] Func<string> sAPGlobalInputPasswordIntoSAPElementpasswordToInput, [WorkflowExpression] Func<string> sAPGlobalInputPasswordIntoSAPElementworkflow, [WorkflowExpression] Func<bool> sAPGlobalInputPasswordIntoSAPElementsetElementWindowTopMost = null, [WorkflowExpression] Func<bool> sAPGlobalInputPasswordIntoSAPElementbringElementWindowToFront = null, [WorkflowExpression] Func<bool> sAPGlobalInputPasswordIntoSAPElementtoggleWindow = null, [WorkflowExpression] Func<bool> sAPGlobalInputPasswordIntoSAPElementtoggleUsesGlobalLeftMouseClickAgent = null, [WorkflowExpression] Func<double> sAPGlobalInputPasswordIntoSAPElementtoggleDelay = null, [WorkflowExpression] Func<bool> sAPGlobalInputPasswordIntoSAPElementglobalMouseClickOnElement = null, [WorkflowExpression] Func<bool> sAPGlobalInputPasswordIntoSAPElementreplaceExistingValueUsingDoubleClickDelete = null, [WorkflowExpression] Func<bool> sAPGlobalInputPasswordIntoSAPElementreplaceExistingValueUsingCTRLADelete = null, [WorkflowExpression] Func<bool> sAPGlobalInputPasswordIntoSAPElementsendKeyEvents = null, [WorkflowExpression] Func<int> sAPGlobalInputPasswordIntoSAPElementkeyIntervalInMilliseconds = null, [WorkflowExpression] Func<int> sAPGlobalInputPasswordIntoSAPElementdoubleClickIntervalInMilliseconds = null, [WorkflowExpression] Func<bool> sAPGlobalInputPasswordIntoSAPElementdontInterpretSymbols = null)
        {
            SourceExpression.Validate(sAPGlobalInputPasswordIntoSAPElementsearchSAPElementId, nameof(sAPGlobalInputPasswordIntoSAPElementsearchSAPElementId), required: true);
            SourceExpression.Validate(sAPGlobalInputPasswordIntoSAPElementpasswordToInput, nameof(sAPGlobalInputPasswordIntoSAPElementpasswordToInput), required: true);
            SourceExpression.Validate(sAPGlobalInputPasswordIntoSAPElementworkflow, nameof(sAPGlobalInputPasswordIntoSAPElementworkflow), required: true);
            SourceExpression.Validate(sAPGlobalInputPasswordIntoSAPElementsetElementWindowTopMost, nameof(sAPGlobalInputPasswordIntoSAPElementsetElementWindowTopMost), required: false);
            SourceExpression.Validate(sAPGlobalInputPasswordIntoSAPElementbringElementWindowToFront, nameof(sAPGlobalInputPasswordIntoSAPElementbringElementWindowToFront), required: false);
            SourceExpression.Validate(sAPGlobalInputPasswordIntoSAPElementtoggleWindow, nameof(sAPGlobalInputPasswordIntoSAPElementtoggleWindow), required: false);
            SourceExpression.Validate(sAPGlobalInputPasswordIntoSAPElementtoggleUsesGlobalLeftMouseClickAgent, nameof(sAPGlobalInputPasswordIntoSAPElementtoggleUsesGlobalLeftMouseClickAgent), required: false);
            SourceExpression.Validate(sAPGlobalInputPasswordIntoSAPElementtoggleDelay, nameof(sAPGlobalInputPasswordIntoSAPElementtoggleDelay), required: false);
            SourceExpression.Validate(sAPGlobalInputPasswordIntoSAPElementglobalMouseClickOnElement, nameof(sAPGlobalInputPasswordIntoSAPElementglobalMouseClickOnElement), required: false);
            SourceExpression.Validate(sAPGlobalInputPasswordIntoSAPElementreplaceExistingValueUsingDoubleClickDelete, nameof(sAPGlobalInputPasswordIntoSAPElementreplaceExistingValueUsingDoubleClickDelete), required: false);
            SourceExpression.Validate(sAPGlobalInputPasswordIntoSAPElementreplaceExistingValueUsingCTRLADelete, nameof(sAPGlobalInputPasswordIntoSAPElementreplaceExistingValueUsingCTRLADelete), required: false);
            SourceExpression.Validate(sAPGlobalInputPasswordIntoSAPElementsendKeyEvents, nameof(sAPGlobalInputPasswordIntoSAPElementsendKeyEvents), required: false);
            SourceExpression.Validate(sAPGlobalInputPasswordIntoSAPElementkeyIntervalInMilliseconds, nameof(sAPGlobalInputPasswordIntoSAPElementkeyIntervalInMilliseconds), required: false);
            SourceExpression.Validate(sAPGlobalInputPasswordIntoSAPElementdoubleClickIntervalInMilliseconds, nameof(sAPGlobalInputPasswordIntoSAPElementdoubleClickIntervalInMilliseconds), required: false);
            SourceExpression.Validate(sAPGlobalInputPasswordIntoSAPElementdontInterpretSymbols, nameof(sAPGlobalInputPasswordIntoSAPElementdontInterpretSymbols), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPGlobalInputPasswordIntoSAPElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGlobalInputPasswordIntoSAPElement = new JObject();
                var sAPGlobalInputPasswordIntoSAPElementpropCount = 0;
                sAPGlobalInputPasswordIntoSAPElementpropCount++;
                sAPGlobalInputPasswordIntoSAPElement["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPGlobalInputPasswordIntoSAPElementsearchSAPElementId);
                if (sAPGlobalInputPasswordIntoSAPElementsetElementWindowTopMost != null)
                {
                    if (sAPGlobalInputPasswordIntoSAPElementsetElementWindowTopMost != null)
                    {
                        sAPGlobalInputPasswordIntoSAPElement["SetElementWindowTopMost"] = SourceExpressionConverter.ConvertToken(sAPGlobalInputPasswordIntoSAPElementsetElementWindowTopMost);
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
                        sAPGlobalInputPasswordIntoSAPElement["BringElementWindowToFront"] = SourceExpressionConverter.ConvertToken(sAPGlobalInputPasswordIntoSAPElementbringElementWindowToFront);
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
                        sAPGlobalInputPasswordIntoSAPElement["ToggleWindow"] = SourceExpressionConverter.ConvertToken(sAPGlobalInputPasswordIntoSAPElementtoggleWindow);
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
                        sAPGlobalInputPasswordIntoSAPElement["ToggleUsesGlobalLeftMouseClickAgent"] = SourceExpressionConverter.ConvertToken(sAPGlobalInputPasswordIntoSAPElementtoggleUsesGlobalLeftMouseClickAgent);
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
                        sAPGlobalInputPasswordIntoSAPElement["ToggleDelay"] = SourceExpressionConverter.ConvertToken(sAPGlobalInputPasswordIntoSAPElementtoggleDelay);
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
                        sAPGlobalInputPasswordIntoSAPElement["GlobalMouseClickOnElement"] = SourceExpressionConverter.ConvertToken(sAPGlobalInputPasswordIntoSAPElementglobalMouseClickOnElement);
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
                        sAPGlobalInputPasswordIntoSAPElement["ReplaceExistingValueUsingDoubleClickDelete"] = SourceExpressionConverter.ConvertToken(sAPGlobalInputPasswordIntoSAPElementreplaceExistingValueUsingDoubleClickDelete);
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
                        sAPGlobalInputPasswordIntoSAPElement["ReplaceExistingValueUsingCTRLADelete"] = SourceExpressionConverter.ConvertToken(sAPGlobalInputPasswordIntoSAPElementreplaceExistingValueUsingCTRLADelete);
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
                sAPGlobalInputPasswordIntoSAPElement["PasswordToInput"] = SourceExpressionConverter.ConvertToken(sAPGlobalInputPasswordIntoSAPElementpasswordToInput);
                if (sAPGlobalInputPasswordIntoSAPElementsendKeyEvents != null)
                {
                    if (sAPGlobalInputPasswordIntoSAPElementsendKeyEvents != null)
                    {
                        sAPGlobalInputPasswordIntoSAPElement["SendKeyEvents"] = SourceExpressionConverter.ConvertToken(sAPGlobalInputPasswordIntoSAPElementsendKeyEvents);
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
                        sAPGlobalInputPasswordIntoSAPElement["KeyIntervalInMilliseconds"] = SourceExpressionConverter.ConvertToken(sAPGlobalInputPasswordIntoSAPElementkeyIntervalInMilliseconds);
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
                        sAPGlobalInputPasswordIntoSAPElement["DoubleClickIntervalInMilliseconds"] = SourceExpressionConverter.ConvertToken(sAPGlobalInputPasswordIntoSAPElementdoubleClickIntervalInMilliseconds);
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
                        sAPGlobalInputPasswordIntoSAPElement["DontInterpretSymbols"] = SourceExpressionConverter.ConvertToken(sAPGlobalInputPasswordIntoSAPElementdontInterpretSymbols);
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
                sAPGlobalInputPasswordIntoSAPElement["Workflow"] = SourceExpressionConverter.ConvertToken(sAPGlobalInputPasswordIntoSAPElementworkflow);
                if (sAPGlobalInputPasswordIntoSAPElementpropCount > 0)
                {
                    callPayload.Body = sAPGlobalInputPasswordIntoSAPElement;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPSetListSelectionByName([WorkflowExpression] Func<string> sAPSetListSelectionByNamesearchSAPElementId, [WorkflowExpression] Func<string> sAPSetListSelectionByNamelistItemName, [WorkflowExpression] Func<string> sAPSetListSelectionByNameworkflow)
        {
            SourceExpression.Validate(sAPSetListSelectionByNamesearchSAPElementId, nameof(sAPSetListSelectionByNamesearchSAPElementId), required: true);
            SourceExpression.Validate(sAPSetListSelectionByNamelistItemName, nameof(sAPSetListSelectionByNamelistItemName), required: true);
            SourceExpression.Validate(sAPSetListSelectionByNameworkflow, nameof(sAPSetListSelectionByNameworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPSetListSelectionByName";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPSetListSelectionByName = new JObject();
                var sAPSetListSelectionByNamepropCount = 0;
                sAPSetListSelectionByNamepropCount++;
                sAPSetListSelectionByName["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPSetListSelectionByNamesearchSAPElementId);
                sAPSetListSelectionByNamepropCount++;
                sAPSetListSelectionByName["ListItemName"] = SourceExpressionConverter.ConvertToken(sAPSetListSelectionByNamelistItemName);
                sAPSetListSelectionByNamepropCount++;
                sAPSetListSelectionByName["Workflow"] = SourceExpressionConverter.ConvertToken(sAPSetListSelectionByNameworkflow);
                if (sAPSetListSelectionByNamepropCount > 0)
                {
                    callPayload.Body = sAPSetListSelectionByName;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPSetListSelectionByKey([WorkflowExpression] Func<string> sAPSetListSelectionByKeysearchSAPElementId, [WorkflowExpression] Func<string> sAPSetListSelectionByKeylistItemKey, [WorkflowExpression] Func<string> sAPSetListSelectionByKeyworkflow)
        {
            SourceExpression.Validate(sAPSetListSelectionByKeysearchSAPElementId, nameof(sAPSetListSelectionByKeysearchSAPElementId), required: true);
            SourceExpression.Validate(sAPSetListSelectionByKeylistItemKey, nameof(sAPSetListSelectionByKeylistItemKey), required: true);
            SourceExpression.Validate(sAPSetListSelectionByKeyworkflow, nameof(sAPSetListSelectionByKeyworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPSetListSelectionByKey";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPSetListSelectionByKey = new JObject();
                var sAPSetListSelectionByKeypropCount = 0;
                sAPSetListSelectionByKeypropCount++;
                sAPSetListSelectionByKey["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPSetListSelectionByKeysearchSAPElementId);
                sAPSetListSelectionByKeypropCount++;
                sAPSetListSelectionByKey["ListItemKey"] = SourceExpressionConverter.ConvertToken(sAPSetListSelectionByKeylistItemKey);
                sAPSetListSelectionByKeypropCount++;
                sAPSetListSelectionByKey["Workflow"] = SourceExpressionConverter.ConvertToken(sAPSetListSelectionByKeyworkflow);
                if (sAPSetListSelectionByKeypropCount > 0)
                {
                    callPayload.Body = sAPSetListSelectionByKey;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetListSelectionElementItemsResponse> SAPGetListSelectionElementItems([WorkflowExpression] Func<string> sAPGetListSelectionElementItemssearchSAPElementId, [WorkflowExpression] Func<string> sAPGetListSelectionElementItemsworkflow)
        {
            SourceExpression.Validate(sAPGetListSelectionElementItemssearchSAPElementId, nameof(sAPGetListSelectionElementItemssearchSAPElementId), required: true);
            SourceExpression.Validate(sAPGetListSelectionElementItemsworkflow, nameof(sAPGetListSelectionElementItemsworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPGetListSelectionElementItems";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGetListSelectionElementItems = new JObject();
                var sAPGetListSelectionElementItemspropCount = 0;
                sAPGetListSelectionElementItemspropCount++;
                sAPGetListSelectionElementItems["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPGetListSelectionElementItemssearchSAPElementId);
                sAPGetListSelectionElementItemspropCount++;
                sAPGetListSelectionElementItems["Workflow"] = SourceExpressionConverter.ConvertToken(sAPGetListSelectionElementItemsworkflow);
                if (sAPGetListSelectionElementItemspropCount > 0)
                {
                    callPayload.Body = sAPGetListSelectionElementItems;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SAPGetListSelectionElementItemsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetAllChildSAPElementPropertiesResponse> SAPGetAllChildSAPElementProperties([WorkflowExpression] Func<string> sAPGetAllChildSAPElementPropertiessearchSAPElementId, [WorkflowExpression] Func<string> sAPGetAllChildSAPElementPropertiesworkflow, [WorkflowExpression] Func<int> sAPGetAllChildSAPElementPropertiesfirstItemToReturn = null, [WorkflowExpression] Func<int> sAPGetAllChildSAPElementPropertiesmaxItemsToReturn = null, [WorkflowExpression] Func<string> sAPGetAllChildSAPElementPropertiessearchSAPElementType = null, [WorkflowExpression] Func<int> sAPGetAllChildSAPElementPropertiesmaxTextLength = null)
        {
            SourceExpression.Validate(sAPGetAllChildSAPElementPropertiessearchSAPElementId, nameof(sAPGetAllChildSAPElementPropertiessearchSAPElementId), required: true);
            SourceExpression.Validate(sAPGetAllChildSAPElementPropertiesworkflow, nameof(sAPGetAllChildSAPElementPropertiesworkflow), required: true);
            SourceExpression.Validate(sAPGetAllChildSAPElementPropertiesfirstItemToReturn, nameof(sAPGetAllChildSAPElementPropertiesfirstItemToReturn), required: false);
            SourceExpression.Validate(sAPGetAllChildSAPElementPropertiesmaxItemsToReturn, nameof(sAPGetAllChildSAPElementPropertiesmaxItemsToReturn), required: false);
            SourceExpression.Validate(sAPGetAllChildSAPElementPropertiessearchSAPElementType, nameof(sAPGetAllChildSAPElementPropertiessearchSAPElementType), required: false);
            SourceExpression.Validate(sAPGetAllChildSAPElementPropertiesmaxTextLength, nameof(sAPGetAllChildSAPElementPropertiesmaxTextLength), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPGetAllChildSAPElementProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGetAllChildSAPElementProperties = new JObject();
                var sAPGetAllChildSAPElementPropertiespropCount = 0;
                sAPGetAllChildSAPElementPropertiespropCount++;
                sAPGetAllChildSAPElementProperties["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPGetAllChildSAPElementPropertiessearchSAPElementId);
                if (sAPGetAllChildSAPElementPropertiesfirstItemToReturn != null)
                {
                    if (sAPGetAllChildSAPElementPropertiesfirstItemToReturn != null)
                    {
                        sAPGetAllChildSAPElementProperties["FirstItemToReturn"] = SourceExpressionConverter.ConvertToken(sAPGetAllChildSAPElementPropertiesfirstItemToReturn);
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
                        sAPGetAllChildSAPElementProperties["MaxItemsToReturn"] = SourceExpressionConverter.ConvertToken(sAPGetAllChildSAPElementPropertiesmaxItemsToReturn);
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
                    sAPGetAllChildSAPElementProperties["SearchSAPElementType"] = SourceExpressionConverter.ConvertToken(sAPGetAllChildSAPElementPropertiessearchSAPElementType);
                    sAPGetAllChildSAPElementPropertiespropCount++;
                }

                if (sAPGetAllChildSAPElementPropertiesmaxTextLength != null)
                {
                    if (sAPGetAllChildSAPElementPropertiesmaxTextLength != null)
                    {
                        sAPGetAllChildSAPElementProperties["MaxTextLength"] = SourceExpressionConverter.ConvertToken(sAPGetAllChildSAPElementPropertiesmaxTextLength);
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
                sAPGetAllChildSAPElementProperties["Workflow"] = SourceExpressionConverter.ConvertToken(sAPGetAllChildSAPElementPropertiesworkflow);
                if (sAPGetAllChildSAPElementPropertiespropCount > 0)
                {
                    callPayload.Body = sAPGetAllChildSAPElementProperties;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SAPGetAllChildSAPElementPropertiesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetSAPSessionTopLevelSAPElementPropertiesResponse> SAPGetSAPSessionTopLevelSAPElementProperties([WorkflowExpression] Func<string> sAPGetSAPSessionTopLevelSAPElementPropertiesworkflow, [WorkflowExpression] Func<int> sAPGetSAPSessionTopLevelSAPElementPropertiesfirstItemToReturn = null, [WorkflowExpression] Func<int> sAPGetSAPSessionTopLevelSAPElementPropertiesmaxItemsToReturn = null, [WorkflowExpression] Func<string> sAPGetSAPSessionTopLevelSAPElementPropertiessearchSAPElementType = null, [WorkflowExpression] Func<int> sAPGetSAPSessionTopLevelSAPElementPropertiesmaxTextLength = null)
        {
            SourceExpression.Validate(sAPGetSAPSessionTopLevelSAPElementPropertiesworkflow, nameof(sAPGetSAPSessionTopLevelSAPElementPropertiesworkflow), required: true);
            SourceExpression.Validate(sAPGetSAPSessionTopLevelSAPElementPropertiesfirstItemToReturn, nameof(sAPGetSAPSessionTopLevelSAPElementPropertiesfirstItemToReturn), required: false);
            SourceExpression.Validate(sAPGetSAPSessionTopLevelSAPElementPropertiesmaxItemsToReturn, nameof(sAPGetSAPSessionTopLevelSAPElementPropertiesmaxItemsToReturn), required: false);
            SourceExpression.Validate(sAPGetSAPSessionTopLevelSAPElementPropertiessearchSAPElementType, nameof(sAPGetSAPSessionTopLevelSAPElementPropertiessearchSAPElementType), required: false);
            SourceExpression.Validate(sAPGetSAPSessionTopLevelSAPElementPropertiesmaxTextLength, nameof(sAPGetSAPSessionTopLevelSAPElementPropertiesmaxTextLength), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        sAPGetSAPSessionTopLevelSAPElementProperties["FirstItemToReturn"] = SourceExpressionConverter.ConvertToken(sAPGetSAPSessionTopLevelSAPElementPropertiesfirstItemToReturn);
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
                        sAPGetSAPSessionTopLevelSAPElementProperties["MaxItemsToReturn"] = SourceExpressionConverter.ConvertToken(sAPGetSAPSessionTopLevelSAPElementPropertiesmaxItemsToReturn);
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
                    sAPGetSAPSessionTopLevelSAPElementProperties["SearchSAPElementType"] = SourceExpressionConverter.ConvertToken(sAPGetSAPSessionTopLevelSAPElementPropertiessearchSAPElementType);
                    sAPGetSAPSessionTopLevelSAPElementPropertiespropCount++;
                }

                if (sAPGetSAPSessionTopLevelSAPElementPropertiesmaxTextLength != null)
                {
                    if (sAPGetSAPSessionTopLevelSAPElementPropertiesmaxTextLength != null)
                    {
                        sAPGetSAPSessionTopLevelSAPElementProperties["MaxTextLength"] = SourceExpressionConverter.ConvertToken(sAPGetSAPSessionTopLevelSAPElementPropertiesmaxTextLength);
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
                sAPGetSAPSessionTopLevelSAPElementProperties["Workflow"] = SourceExpressionConverter.ConvertToken(sAPGetSAPSessionTopLevelSAPElementPropertiesworkflow);
                if (sAPGetSAPSessionTopLevelSAPElementPropertiespropCount > 0)
                {
                    callPayload.Body = sAPGetSAPSessionTopLevelSAPElementProperties;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SAPGetSAPSessionTopLevelSAPElementPropertiesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetSAPElementParentIdResponse> SAPGetSAPElementParentId([WorkflowExpression] Func<string> sAPGetSAPElementParentIdsearchSAPElementId, [WorkflowExpression] Func<string> sAPGetSAPElementParentIdworkflow)
        {
            SourceExpression.Validate(sAPGetSAPElementParentIdsearchSAPElementId, nameof(sAPGetSAPElementParentIdsearchSAPElementId), required: true);
            SourceExpression.Validate(sAPGetSAPElementParentIdworkflow, nameof(sAPGetSAPElementParentIdworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPGetSAPElementParentId";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGetSAPElementParentId = new JObject();
                var sAPGetSAPElementParentIdpropCount = 0;
                sAPGetSAPElementParentIdpropCount++;
                sAPGetSAPElementParentId["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPGetSAPElementParentIdsearchSAPElementId);
                sAPGetSAPElementParentIdpropCount++;
                sAPGetSAPElementParentId["Workflow"] = SourceExpressionConverter.ConvertToken(sAPGetSAPElementParentIdworkflow);
                if (sAPGetSAPElementParentIdpropCount > 0)
                {
                    callPayload.Body = sAPGetSAPElementParentId;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SAPGetSAPElementParentIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetElementPropertiesAsListResponse> SAPGetElementPropertiesAsList([WorkflowExpression] Func<string> sAPGetElementPropertiesAsListsearchSAPElementId, [WorkflowExpression] Func<string> sAPGetElementPropertiesAsListworkflow, [WorkflowExpression] Func<int> sAPGetElementPropertiesAsListmaxTextLength = null)
        {
            SourceExpression.Validate(sAPGetElementPropertiesAsListsearchSAPElementId, nameof(sAPGetElementPropertiesAsListsearchSAPElementId), required: true);
            SourceExpression.Validate(sAPGetElementPropertiesAsListworkflow, nameof(sAPGetElementPropertiesAsListworkflow), required: true);
            SourceExpression.Validate(sAPGetElementPropertiesAsListmaxTextLength, nameof(sAPGetElementPropertiesAsListmaxTextLength), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPGetElementPropertiesAsList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGetElementPropertiesAsList = new JObject();
                var sAPGetElementPropertiesAsListpropCount = 0;
                sAPGetElementPropertiesAsListpropCount++;
                sAPGetElementPropertiesAsList["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPGetElementPropertiesAsListsearchSAPElementId);
                if (sAPGetElementPropertiesAsListmaxTextLength != null)
                {
                    if (sAPGetElementPropertiesAsListmaxTextLength != null)
                    {
                        sAPGetElementPropertiesAsList["MaxTextLength"] = SourceExpressionConverter.ConvertToken(sAPGetElementPropertiesAsListmaxTextLength);
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
                sAPGetElementPropertiesAsList["Workflow"] = SourceExpressionConverter.ConvertToken(sAPGetElementPropertiesAsListworkflow);
                if (sAPGetElementPropertiesAsListpropCount > 0)
                {
                    callPayload.Body = sAPGetElementPropertiesAsList;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SAPGetElementPropertiesAsListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetSAPElementAtScreenCoordinateResponse> SAPGetSAPElementAtScreenCoordinate([WorkflowExpression] Func<int> sAPGetSAPElementAtScreenCoordinatescreenX, [WorkflowExpression] Func<int> sAPGetSAPElementAtScreenCoordinatescreenY, [WorkflowExpression] Func<string> sAPGetSAPElementAtScreenCoordinateworkflow)
        {
            SourceExpression.Validate(sAPGetSAPElementAtScreenCoordinatescreenX, nameof(sAPGetSAPElementAtScreenCoordinatescreenX), required: true);
            SourceExpression.Validate(sAPGetSAPElementAtScreenCoordinatescreenY, nameof(sAPGetSAPElementAtScreenCoordinatescreenY), required: true);
            SourceExpression.Validate(sAPGetSAPElementAtScreenCoordinateworkflow, nameof(sAPGetSAPElementAtScreenCoordinateworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPGetSAPElementAtScreenCoordinate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGetSAPElementAtScreenCoordinate = new JObject();
                var sAPGetSAPElementAtScreenCoordinatepropCount = 0;
                sAPGetSAPElementAtScreenCoordinatepropCount++;
                sAPGetSAPElementAtScreenCoordinate["ScreenX"] = SourceExpressionConverter.ConvertToken(sAPGetSAPElementAtScreenCoordinatescreenX);
                sAPGetSAPElementAtScreenCoordinatepropCount++;
                sAPGetSAPElementAtScreenCoordinate["ScreenY"] = SourceExpressionConverter.ConvertToken(sAPGetSAPElementAtScreenCoordinatescreenY);
                sAPGetSAPElementAtScreenCoordinatepropCount++;
                sAPGetSAPElementAtScreenCoordinate["Workflow"] = SourceExpressionConverter.ConvertToken(sAPGetSAPElementAtScreenCoordinateworkflow);
                if (sAPGetSAPElementAtScreenCoordinatepropCount > 0)
                {
                    callPayload.Body = sAPGetSAPElementAtScreenCoordinate;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SAPGetSAPElementAtScreenCoordinateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPOpenConnectionResponse> SAPOpenConnection([WorkflowExpression] Func<string> sAPOpenConnectionworkflow, [WorkflowExpression] Func<string> sAPOpenConnectionsAPConnectionDescription = null, [WorkflowExpression] Func<string> sAPOpenConnectionsAPConnectionAddress = null, [WorkflowExpression] Func<bool> sAPOpenConnectionconnectSynchronous = null, [WorkflowExpression] Func<bool> sAPOpenConnectionconnectToSession = null)
        {
            SourceExpression.Validate(sAPOpenConnectionworkflow, nameof(sAPOpenConnectionworkflow), required: true);
            SourceExpression.Validate(sAPOpenConnectionsAPConnectionDescription, nameof(sAPOpenConnectionsAPConnectionDescription), required: false);
            SourceExpression.Validate(sAPOpenConnectionsAPConnectionAddress, nameof(sAPOpenConnectionsAPConnectionAddress), required: false);
            SourceExpression.Validate(sAPOpenConnectionconnectSynchronous, nameof(sAPOpenConnectionconnectSynchronous), required: false);
            SourceExpression.Validate(sAPOpenConnectionconnectToSession, nameof(sAPOpenConnectionconnectToSession), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPOpenConnection";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPOpenConnection = new JObject();
                var sAPOpenConnectionpropCount = 0;
                if (sAPOpenConnectionsAPConnectionDescription != null)
                {
                    sAPOpenConnection["SAPConnectionDescription"] = SourceExpressionConverter.ConvertToken(sAPOpenConnectionsAPConnectionDescription);
                    sAPOpenConnectionpropCount++;
                }

                if (sAPOpenConnectionsAPConnectionAddress != null)
                {
                    sAPOpenConnection["SAPConnectionAddress"] = SourceExpressionConverter.ConvertToken(sAPOpenConnectionsAPConnectionAddress);
                    sAPOpenConnectionpropCount++;
                }

                if (sAPOpenConnectionconnectSynchronous != null)
                {
                    if (sAPOpenConnectionconnectSynchronous != null)
                    {
                        sAPOpenConnection["ConnectSynchronous"] = SourceExpressionConverter.ConvertToken(sAPOpenConnectionconnectSynchronous);
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
                        sAPOpenConnection["ConnectToSession"] = SourceExpressionConverter.ConvertToken(sAPOpenConnectionconnectToSession);
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
                sAPOpenConnection["Workflow"] = SourceExpressionConverter.ConvertToken(sAPOpenConnectionworkflow);
                if (sAPOpenConnectionpropCount > 0)
                {
                    callPayload.Body = sAPOpenConnection;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SAPOpenConnectionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetSAPTablePropertiesResponse> SAPGetSAPTableProperties([WorkflowExpression] Func<string> sAPGetSAPTablePropertiessearchSAPElementId, [WorkflowExpression] Func<string> sAPGetSAPTablePropertiesworkflow)
        {
            SourceExpression.Validate(sAPGetSAPTablePropertiessearchSAPElementId, nameof(sAPGetSAPTablePropertiessearchSAPElementId), required: true);
            SourceExpression.Validate(sAPGetSAPTablePropertiesworkflow, nameof(sAPGetSAPTablePropertiesworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPGetSAPTableProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGetSAPTableProperties = new JObject();
                var sAPGetSAPTablePropertiespropCount = 0;
                sAPGetSAPTablePropertiespropCount++;
                sAPGetSAPTableProperties["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPGetSAPTablePropertiessearchSAPElementId);
                sAPGetSAPTablePropertiespropCount++;
                sAPGetSAPTableProperties["Workflow"] = SourceExpressionConverter.ConvertToken(sAPGetSAPTablePropertiesworkflow);
                if (sAPGetSAPTablePropertiespropCount > 0)
                {
                    callPayload.Body = sAPGetSAPTableProperties;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SAPGetSAPTablePropertiesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetSAPTableVisibleCellTextContentsAtIndexResponse> SAPGetSAPTableVisibleCellTextContentsAtIndex([WorkflowExpression] Func<string> sAPGetSAPTableVisibleCellTextContentsAtIndexsearchSAPElementId, [WorkflowExpression] Func<string> sAPGetSAPTableVisibleCellTextContentsAtIndexworkflow, [WorkflowExpression] Func<int> sAPGetSAPTableVisibleCellTextContentsAtIndexvisibleRowIndex = null, [WorkflowExpression] Func<int> sAPGetSAPTableVisibleCellTextContentsAtIndexvisibleColumnIndex = null, [WorkflowExpression] Func<string> sAPGetSAPTableVisibleCellTextContentsAtIndexcheckedElementValue = null)
        {
            SourceExpression.Validate(sAPGetSAPTableVisibleCellTextContentsAtIndexsearchSAPElementId, nameof(sAPGetSAPTableVisibleCellTextContentsAtIndexsearchSAPElementId), required: true);
            SourceExpression.Validate(sAPGetSAPTableVisibleCellTextContentsAtIndexworkflow, nameof(sAPGetSAPTableVisibleCellTextContentsAtIndexworkflow), required: true);
            SourceExpression.Validate(sAPGetSAPTableVisibleCellTextContentsAtIndexvisibleRowIndex, nameof(sAPGetSAPTableVisibleCellTextContentsAtIndexvisibleRowIndex), required: false);
            SourceExpression.Validate(sAPGetSAPTableVisibleCellTextContentsAtIndexvisibleColumnIndex, nameof(sAPGetSAPTableVisibleCellTextContentsAtIndexvisibleColumnIndex), required: false);
            SourceExpression.Validate(sAPGetSAPTableVisibleCellTextContentsAtIndexcheckedElementValue, nameof(sAPGetSAPTableVisibleCellTextContentsAtIndexcheckedElementValue), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPGetSAPTableVisibleCellTextContentsAtIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGetSAPTableVisibleCellTextContentsAtIndex = new JObject();
                var sAPGetSAPTableVisibleCellTextContentsAtIndexpropCount = 0;
                sAPGetSAPTableVisibleCellTextContentsAtIndexpropCount++;
                sAPGetSAPTableVisibleCellTextContentsAtIndex["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPGetSAPTableVisibleCellTextContentsAtIndexsearchSAPElementId);
                if (sAPGetSAPTableVisibleCellTextContentsAtIndexvisibleRowIndex != null)
                {
                    if (sAPGetSAPTableVisibleCellTextContentsAtIndexvisibleRowIndex != null)
                    {
                        sAPGetSAPTableVisibleCellTextContentsAtIndex["VisibleRowIndex"] = SourceExpressionConverter.ConvertToken(sAPGetSAPTableVisibleCellTextContentsAtIndexvisibleRowIndex);
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
                        sAPGetSAPTableVisibleCellTextContentsAtIndex["VisibleColumnIndex"] = SourceExpressionConverter.ConvertToken(sAPGetSAPTableVisibleCellTextContentsAtIndexvisibleColumnIndex);
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
                        sAPGetSAPTableVisibleCellTextContentsAtIndex["CheckedElementValue"] = SourceExpressionConverter.ConvertToken(sAPGetSAPTableVisibleCellTextContentsAtIndexcheckedElementValue);
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
                sAPGetSAPTableVisibleCellTextContentsAtIndex["Workflow"] = SourceExpressionConverter.ConvertToken(sAPGetSAPTableVisibleCellTextContentsAtIndexworkflow);
                if (sAPGetSAPTableVisibleCellTextContentsAtIndexpropCount > 0)
                {
                    callPayload.Body = sAPGetSAPTableVisibleCellTextContentsAtIndex;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SAPGetSAPTableVisibleCellTextContentsAtIndexResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetSAPTableVisibleCellPropertiesAtIndexResponse> SAPGetSAPTableVisibleCellPropertiesAtIndex([WorkflowExpression] Func<string> sAPGetSAPTableVisibleCellPropertiesAtIndexsearchSAPElementId, [WorkflowExpression] Func<string> sAPGetSAPTableVisibleCellPropertiesAtIndexworkflow, [WorkflowExpression] Func<int> sAPGetSAPTableVisibleCellPropertiesAtIndexvisibleRowIndex = null, [WorkflowExpression] Func<int> sAPGetSAPTableVisibleCellPropertiesAtIndexvisibleColumnIndex = null)
        {
            SourceExpression.Validate(sAPGetSAPTableVisibleCellPropertiesAtIndexsearchSAPElementId, nameof(sAPGetSAPTableVisibleCellPropertiesAtIndexsearchSAPElementId), required: true);
            SourceExpression.Validate(sAPGetSAPTableVisibleCellPropertiesAtIndexworkflow, nameof(sAPGetSAPTableVisibleCellPropertiesAtIndexworkflow), required: true);
            SourceExpression.Validate(sAPGetSAPTableVisibleCellPropertiesAtIndexvisibleRowIndex, nameof(sAPGetSAPTableVisibleCellPropertiesAtIndexvisibleRowIndex), required: false);
            SourceExpression.Validate(sAPGetSAPTableVisibleCellPropertiesAtIndexvisibleColumnIndex, nameof(sAPGetSAPTableVisibleCellPropertiesAtIndexvisibleColumnIndex), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPGetSAPTableVisibleCellPropertiesAtIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGetSAPTableVisibleCellPropertiesAtIndex = new JObject();
                var sAPGetSAPTableVisibleCellPropertiesAtIndexpropCount = 0;
                sAPGetSAPTableVisibleCellPropertiesAtIndexpropCount++;
                sAPGetSAPTableVisibleCellPropertiesAtIndex["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPGetSAPTableVisibleCellPropertiesAtIndexsearchSAPElementId);
                if (sAPGetSAPTableVisibleCellPropertiesAtIndexvisibleRowIndex != null)
                {
                    if (sAPGetSAPTableVisibleCellPropertiesAtIndexvisibleRowIndex != null)
                    {
                        sAPGetSAPTableVisibleCellPropertiesAtIndex["VisibleRowIndex"] = SourceExpressionConverter.ConvertToken(sAPGetSAPTableVisibleCellPropertiesAtIndexvisibleRowIndex);
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
                        sAPGetSAPTableVisibleCellPropertiesAtIndex["VisibleColumnIndex"] = SourceExpressionConverter.ConvertToken(sAPGetSAPTableVisibleCellPropertiesAtIndexvisibleColumnIndex);
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
                sAPGetSAPTableVisibleCellPropertiesAtIndex["Workflow"] = SourceExpressionConverter.ConvertToken(sAPGetSAPTableVisibleCellPropertiesAtIndexworkflow);
                if (sAPGetSAPTableVisibleCellPropertiesAtIndexpropCount > 0)
                {
                    callPayload.Body = sAPGetSAPTableVisibleCellPropertiesAtIndex;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SAPGetSAPTableVisibleCellPropertiesAtIndexResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPSetSAPTableVisibleCellTextContentsAtIndex([WorkflowExpression] Func<string> sAPSetSAPTableVisibleCellTextContentsAtIndexsearchSAPElementId, [WorkflowExpression] Func<string> sAPSetSAPTableVisibleCellTextContentsAtIndexworkflow, [WorkflowExpression] Func<int> sAPSetSAPTableVisibleCellTextContentsAtIndexvisibleRowIndex = null, [WorkflowExpression] Func<int> sAPSetSAPTableVisibleCellTextContentsAtIndexvisibleColumnIndex = null, [WorkflowExpression] Func<string> sAPSetSAPTableVisibleCellTextContentsAtIndextextToInput = null, [WorkflowExpression] Func<bool> sAPSetSAPTableVisibleCellTextContentsAtIndexreplaceExistingValue = null, [WorkflowExpression] Func<int> sAPSetSAPTableVisibleCellTextContentsAtIndexinsertPosition = null)
        {
            SourceExpression.Validate(sAPSetSAPTableVisibleCellTextContentsAtIndexsearchSAPElementId, nameof(sAPSetSAPTableVisibleCellTextContentsAtIndexsearchSAPElementId), required: true);
            SourceExpression.Validate(sAPSetSAPTableVisibleCellTextContentsAtIndexworkflow, nameof(sAPSetSAPTableVisibleCellTextContentsAtIndexworkflow), required: true);
            SourceExpression.Validate(sAPSetSAPTableVisibleCellTextContentsAtIndexvisibleRowIndex, nameof(sAPSetSAPTableVisibleCellTextContentsAtIndexvisibleRowIndex), required: false);
            SourceExpression.Validate(sAPSetSAPTableVisibleCellTextContentsAtIndexvisibleColumnIndex, nameof(sAPSetSAPTableVisibleCellTextContentsAtIndexvisibleColumnIndex), required: false);
            SourceExpression.Validate(sAPSetSAPTableVisibleCellTextContentsAtIndextextToInput, nameof(sAPSetSAPTableVisibleCellTextContentsAtIndextextToInput), required: false);
            SourceExpression.Validate(sAPSetSAPTableVisibleCellTextContentsAtIndexreplaceExistingValue, nameof(sAPSetSAPTableVisibleCellTextContentsAtIndexreplaceExistingValue), required: false);
            SourceExpression.Validate(sAPSetSAPTableVisibleCellTextContentsAtIndexinsertPosition, nameof(sAPSetSAPTableVisibleCellTextContentsAtIndexinsertPosition), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPSetSAPTableVisibleCellTextContentsAtIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPSetSAPTableVisibleCellTextContentsAtIndex = new JObject();
                var sAPSetSAPTableVisibleCellTextContentsAtIndexpropCount = 0;
                sAPSetSAPTableVisibleCellTextContentsAtIndexpropCount++;
                sAPSetSAPTableVisibleCellTextContentsAtIndex["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPSetSAPTableVisibleCellTextContentsAtIndexsearchSAPElementId);
                if (sAPSetSAPTableVisibleCellTextContentsAtIndexvisibleRowIndex != null)
                {
                    if (sAPSetSAPTableVisibleCellTextContentsAtIndexvisibleRowIndex != null)
                    {
                        sAPSetSAPTableVisibleCellTextContentsAtIndex["VisibleRowIndex"] = SourceExpressionConverter.ConvertToken(sAPSetSAPTableVisibleCellTextContentsAtIndexvisibleRowIndex);
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
                        sAPSetSAPTableVisibleCellTextContentsAtIndex["VisibleColumnIndex"] = SourceExpressionConverter.ConvertToken(sAPSetSAPTableVisibleCellTextContentsAtIndexvisibleColumnIndex);
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
                    sAPSetSAPTableVisibleCellTextContentsAtIndex["TextToInput"] = SourceExpressionConverter.ConvertToken(sAPSetSAPTableVisibleCellTextContentsAtIndextextToInput);
                    sAPSetSAPTableVisibleCellTextContentsAtIndexpropCount++;
                }

                if (sAPSetSAPTableVisibleCellTextContentsAtIndexreplaceExistingValue != null)
                {
                    if (sAPSetSAPTableVisibleCellTextContentsAtIndexreplaceExistingValue != null)
                    {
                        sAPSetSAPTableVisibleCellTextContentsAtIndex["ReplaceExistingValue"] = SourceExpressionConverter.ConvertToken(sAPSetSAPTableVisibleCellTextContentsAtIndexreplaceExistingValue);
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
                        sAPSetSAPTableVisibleCellTextContentsAtIndex["InsertPosition"] = SourceExpressionConverter.ConvertToken(sAPSetSAPTableVisibleCellTextContentsAtIndexinsertPosition);
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
                sAPSetSAPTableVisibleCellTextContentsAtIndex["Workflow"] = SourceExpressionConverter.ConvertToken(sAPSetSAPTableVisibleCellTextContentsAtIndexworkflow);
                if (sAPSetSAPTableVisibleCellTextContentsAtIndexpropCount > 0)
                {
                    callPayload.Body = sAPSetSAPTableVisibleCellTextContentsAtIndex;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPCheckSAPTableVisibleCellCheckboxAtIndex([WorkflowExpression] Func<string> sAPCheckSAPTableVisibleCellCheckboxAtIndexsearchSAPElementId, [WorkflowExpression] Func<string> sAPCheckSAPTableVisibleCellCheckboxAtIndexworkflow, [WorkflowExpression] Func<int> sAPCheckSAPTableVisibleCellCheckboxAtIndexvisibleRowIndex = null, [WorkflowExpression] Func<int> sAPCheckSAPTableVisibleCellCheckboxAtIndexvisibleColumnIndex = null, [WorkflowExpression] Func<bool> sAPCheckSAPTableVisibleCellCheckboxAtIndexcheckCellElement = null)
        {
            SourceExpression.Validate(sAPCheckSAPTableVisibleCellCheckboxAtIndexsearchSAPElementId, nameof(sAPCheckSAPTableVisibleCellCheckboxAtIndexsearchSAPElementId), required: true);
            SourceExpression.Validate(sAPCheckSAPTableVisibleCellCheckboxAtIndexworkflow, nameof(sAPCheckSAPTableVisibleCellCheckboxAtIndexworkflow), required: true);
            SourceExpression.Validate(sAPCheckSAPTableVisibleCellCheckboxAtIndexvisibleRowIndex, nameof(sAPCheckSAPTableVisibleCellCheckboxAtIndexvisibleRowIndex), required: false);
            SourceExpression.Validate(sAPCheckSAPTableVisibleCellCheckboxAtIndexvisibleColumnIndex, nameof(sAPCheckSAPTableVisibleCellCheckboxAtIndexvisibleColumnIndex), required: false);
            SourceExpression.Validate(sAPCheckSAPTableVisibleCellCheckboxAtIndexcheckCellElement, nameof(sAPCheckSAPTableVisibleCellCheckboxAtIndexcheckCellElement), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPCheckSAPTableVisibleCellCheckboxAtIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPCheckSAPTableVisibleCellCheckboxAtIndex = new JObject();
                var sAPCheckSAPTableVisibleCellCheckboxAtIndexpropCount = 0;
                sAPCheckSAPTableVisibleCellCheckboxAtIndexpropCount++;
                sAPCheckSAPTableVisibleCellCheckboxAtIndex["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPCheckSAPTableVisibleCellCheckboxAtIndexsearchSAPElementId);
                if (sAPCheckSAPTableVisibleCellCheckboxAtIndexvisibleRowIndex != null)
                {
                    if (sAPCheckSAPTableVisibleCellCheckboxAtIndexvisibleRowIndex != null)
                    {
                        sAPCheckSAPTableVisibleCellCheckboxAtIndex["VisibleRowIndex"] = SourceExpressionConverter.ConvertToken(sAPCheckSAPTableVisibleCellCheckboxAtIndexvisibleRowIndex);
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
                        sAPCheckSAPTableVisibleCellCheckboxAtIndex["VisibleColumnIndex"] = SourceExpressionConverter.ConvertToken(sAPCheckSAPTableVisibleCellCheckboxAtIndexvisibleColumnIndex);
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
                        sAPCheckSAPTableVisibleCellCheckboxAtIndex["CheckCellElement"] = SourceExpressionConverter.ConvertToken(sAPCheckSAPTableVisibleCellCheckboxAtIndexcheckCellElement);
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
                sAPCheckSAPTableVisibleCellCheckboxAtIndex["Workflow"] = SourceExpressionConverter.ConvertToken(sAPCheckSAPTableVisibleCellCheckboxAtIndexworkflow);
                if (sAPCheckSAPTableVisibleCellCheckboxAtIndexpropCount > 0)
                {
                    callPayload.Body = sAPCheckSAPTableVisibleCellCheckboxAtIndex;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPPressSAPTableVisibleCellAtIndex([WorkflowExpression] Func<string> sAPPressSAPTableVisibleCellAtIndexsearchSAPElementId, [WorkflowExpression] Func<string> sAPPressSAPTableVisibleCellAtIndexworkflow, [WorkflowExpression] Func<int> sAPPressSAPTableVisibleCellAtIndexvisibleRowIndex = null, [WorkflowExpression] Func<int> sAPPressSAPTableVisibleCellAtIndexvisibleColumnIndex = null)
        {
            SourceExpression.Validate(sAPPressSAPTableVisibleCellAtIndexsearchSAPElementId, nameof(sAPPressSAPTableVisibleCellAtIndexsearchSAPElementId), required: true);
            SourceExpression.Validate(sAPPressSAPTableVisibleCellAtIndexworkflow, nameof(sAPPressSAPTableVisibleCellAtIndexworkflow), required: true);
            SourceExpression.Validate(sAPPressSAPTableVisibleCellAtIndexvisibleRowIndex, nameof(sAPPressSAPTableVisibleCellAtIndexvisibleRowIndex), required: false);
            SourceExpression.Validate(sAPPressSAPTableVisibleCellAtIndexvisibleColumnIndex, nameof(sAPPressSAPTableVisibleCellAtIndexvisibleColumnIndex), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPPressSAPTableVisibleCellAtIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPPressSAPTableVisibleCellAtIndex = new JObject();
                var sAPPressSAPTableVisibleCellAtIndexpropCount = 0;
                sAPPressSAPTableVisibleCellAtIndexpropCount++;
                sAPPressSAPTableVisibleCellAtIndex["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPPressSAPTableVisibleCellAtIndexsearchSAPElementId);
                if (sAPPressSAPTableVisibleCellAtIndexvisibleRowIndex != null)
                {
                    if (sAPPressSAPTableVisibleCellAtIndexvisibleRowIndex != null)
                    {
                        sAPPressSAPTableVisibleCellAtIndex["VisibleRowIndex"] = SourceExpressionConverter.ConvertToken(sAPPressSAPTableVisibleCellAtIndexvisibleRowIndex);
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
                        sAPPressSAPTableVisibleCellAtIndex["VisibleColumnIndex"] = SourceExpressionConverter.ConvertToken(sAPPressSAPTableVisibleCellAtIndexvisibleColumnIndex);
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
                sAPPressSAPTableVisibleCellAtIndex["Workflow"] = SourceExpressionConverter.ConvertToken(sAPPressSAPTableVisibleCellAtIndexworkflow);
                if (sAPPressSAPTableVisibleCellAtIndexpropCount > 0)
                {
                    callPayload.Body = sAPPressSAPTableVisibleCellAtIndex;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPScrollSAPTable([WorkflowExpression] Func<string> sAPScrollSAPTablesearchSAPElementId, [WorkflowExpression] Func<string> sAPScrollSAPTableworkflow, [WorkflowExpression] Func<bool> sAPScrollSAPTablemoveHorizontalScrollbar = null, [WorkflowExpression] Func<int> sAPScrollSAPTablehorizontalScrollbarPosition = null, [WorkflowExpression] Func<bool> sAPScrollSAPTablemoveVerticalScrollbar = null, [WorkflowExpression] Func<int> sAPScrollSAPTableverticalScrollbarPosition = null)
        {
            SourceExpression.Validate(sAPScrollSAPTablesearchSAPElementId, nameof(sAPScrollSAPTablesearchSAPElementId), required: true);
            SourceExpression.Validate(sAPScrollSAPTableworkflow, nameof(sAPScrollSAPTableworkflow), required: true);
            SourceExpression.Validate(sAPScrollSAPTablemoveHorizontalScrollbar, nameof(sAPScrollSAPTablemoveHorizontalScrollbar), required: false);
            SourceExpression.Validate(sAPScrollSAPTablehorizontalScrollbarPosition, nameof(sAPScrollSAPTablehorizontalScrollbarPosition), required: false);
            SourceExpression.Validate(sAPScrollSAPTablemoveVerticalScrollbar, nameof(sAPScrollSAPTablemoveVerticalScrollbar), required: false);
            SourceExpression.Validate(sAPScrollSAPTableverticalScrollbarPosition, nameof(sAPScrollSAPTableverticalScrollbarPosition), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPScrollSAPTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPScrollSAPTable = new JObject();
                var sAPScrollSAPTablepropCount = 0;
                sAPScrollSAPTablepropCount++;
                sAPScrollSAPTable["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPScrollSAPTablesearchSAPElementId);
                if (sAPScrollSAPTablemoveHorizontalScrollbar != null)
                {
                    if (sAPScrollSAPTablemoveHorizontalScrollbar != null)
                    {
                        sAPScrollSAPTable["MoveHorizontalScrollbar"] = SourceExpressionConverter.ConvertToken(sAPScrollSAPTablemoveHorizontalScrollbar);
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
                    sAPScrollSAPTable["HorizontalScrollbarPosition"] = SourceExpressionConverter.ConvertToken(sAPScrollSAPTablehorizontalScrollbarPosition);
                    sAPScrollSAPTablepropCount++;
                }

                if (sAPScrollSAPTablemoveVerticalScrollbar != null)
                {
                    if (sAPScrollSAPTablemoveVerticalScrollbar != null)
                    {
                        sAPScrollSAPTable["MoveVerticalScrollbar"] = SourceExpressionConverter.ConvertToken(sAPScrollSAPTablemoveVerticalScrollbar);
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
                    sAPScrollSAPTable["VerticalScrollbarPosition"] = SourceExpressionConverter.ConvertToken(sAPScrollSAPTableverticalScrollbarPosition);
                    sAPScrollSAPTablepropCount++;
                }

                sAPScrollSAPTablepropCount++;
                sAPScrollSAPTable["Workflow"] = SourceExpressionConverter.ConvertToken(sAPScrollSAPTableworkflow);
                if (sAPScrollSAPTablepropCount > 0)
                {
                    callPayload.Body = sAPScrollSAPTable;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetTableVisibleTextContentsResponse> SAPGetTableVisibleTextContents([WorkflowExpression] Func<string> sAPGetTableVisibleTextContentssearchSAPElementId, [WorkflowExpression] Func<string> sAPGetTableVisibleTextContentsworkflow, [WorkflowExpression] Func<int> sAPGetTableVisibleTextContentsfirstVisibleRowToReturn = null, [WorkflowExpression] Func<int> sAPGetTableVisibleTextContentsmaxRowsToReturn = null, [WorkflowExpression] Func<int> sAPGetTableVisibleTextContentsfirstVisibleColumnToReturn = null, [WorkflowExpression] Func<int> sAPGetTableVisibleTextContentsmaxColumnsToReturn = null, [WorkflowExpression] Func<bool> sAPGetTableVisibleTextContentsuseColumnHeadersFromTable = null, [WorkflowExpression] Func<bool> sAPGetTableVisibleTextContentsreturnRowIndexInOutputCollection = null, [WorkflowExpression] Func<string> sAPGetTableVisibleTextContentsnameOfColumnToStoreRowIndex = null, [WorkflowExpression] Func<string> sAPGetTableVisibleTextContentscheckedElementValue = null)
        {
            SourceExpression.Validate(sAPGetTableVisibleTextContentssearchSAPElementId, nameof(sAPGetTableVisibleTextContentssearchSAPElementId), required: true);
            SourceExpression.Validate(sAPGetTableVisibleTextContentsworkflow, nameof(sAPGetTableVisibleTextContentsworkflow), required: true);
            SourceExpression.Validate(sAPGetTableVisibleTextContentsfirstVisibleRowToReturn, nameof(sAPGetTableVisibleTextContentsfirstVisibleRowToReturn), required: false);
            SourceExpression.Validate(sAPGetTableVisibleTextContentsmaxRowsToReturn, nameof(sAPGetTableVisibleTextContentsmaxRowsToReturn), required: false);
            SourceExpression.Validate(sAPGetTableVisibleTextContentsfirstVisibleColumnToReturn, nameof(sAPGetTableVisibleTextContentsfirstVisibleColumnToReturn), required: false);
            SourceExpression.Validate(sAPGetTableVisibleTextContentsmaxColumnsToReturn, nameof(sAPGetTableVisibleTextContentsmaxColumnsToReturn), required: false);
            SourceExpression.Validate(sAPGetTableVisibleTextContentsuseColumnHeadersFromTable, nameof(sAPGetTableVisibleTextContentsuseColumnHeadersFromTable), required: false);
            SourceExpression.Validate(sAPGetTableVisibleTextContentsreturnRowIndexInOutputCollection, nameof(sAPGetTableVisibleTextContentsreturnRowIndexInOutputCollection), required: false);
            SourceExpression.Validate(sAPGetTableVisibleTextContentsnameOfColumnToStoreRowIndex, nameof(sAPGetTableVisibleTextContentsnameOfColumnToStoreRowIndex), required: false);
            SourceExpression.Validate(sAPGetTableVisibleTextContentscheckedElementValue, nameof(sAPGetTableVisibleTextContentscheckedElementValue), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPGetTableVisibleTextContents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGetTableVisibleTextContents = new JObject();
                var sAPGetTableVisibleTextContentspropCount = 0;
                sAPGetTableVisibleTextContentspropCount++;
                sAPGetTableVisibleTextContents["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPGetTableVisibleTextContentssearchSAPElementId);
                if (sAPGetTableVisibleTextContentsfirstVisibleRowToReturn != null)
                {
                    if (sAPGetTableVisibleTextContentsfirstVisibleRowToReturn != null)
                    {
                        sAPGetTableVisibleTextContents["FirstVisibleRowToReturn"] = SourceExpressionConverter.ConvertToken(sAPGetTableVisibleTextContentsfirstVisibleRowToReturn);
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
                        sAPGetTableVisibleTextContents["MaxRowsToReturn"] = SourceExpressionConverter.ConvertToken(sAPGetTableVisibleTextContentsmaxRowsToReturn);
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
                        sAPGetTableVisibleTextContents["FirstVisibleColumnToReturn"] = SourceExpressionConverter.ConvertToken(sAPGetTableVisibleTextContentsfirstVisibleColumnToReturn);
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
                        sAPGetTableVisibleTextContents["MaxColumnsToReturn"] = SourceExpressionConverter.ConvertToken(sAPGetTableVisibleTextContentsmaxColumnsToReturn);
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
                        sAPGetTableVisibleTextContents["UseColumnHeadersFromTable"] = SourceExpressionConverter.ConvertToken(sAPGetTableVisibleTextContentsuseColumnHeadersFromTable);
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
                        sAPGetTableVisibleTextContents["ReturnRowIndexInOutputCollection"] = SourceExpressionConverter.ConvertToken(sAPGetTableVisibleTextContentsreturnRowIndexInOutputCollection);
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
                    sAPGetTableVisibleTextContents["NameOfColumnToStoreRowIndex"] = SourceExpressionConverter.ConvertToken(sAPGetTableVisibleTextContentsnameOfColumnToStoreRowIndex);
                    sAPGetTableVisibleTextContentspropCount++;
                }

                if (sAPGetTableVisibleTextContentscheckedElementValue != null)
                {
                    if (sAPGetTableVisibleTextContentscheckedElementValue != null)
                    {
                        sAPGetTableVisibleTextContents["CheckedElementValue"] = SourceExpressionConverter.ConvertToken(sAPGetTableVisibleTextContentscheckedElementValue);
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
                sAPGetTableVisibleTextContents["Workflow"] = SourceExpressionConverter.ConvertToken(sAPGetTableVisibleTextContentsworkflow);
                if (sAPGetTableVisibleTextContentspropCount > 0)
                {
                    callPayload.Body = sAPGetTableVisibleTextContents;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SAPGetTableVisibleTextContentsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPSelectSAPTableRow([WorkflowExpression] Func<string> sAPSelectSAPTableRowsearchSAPElementId, [WorkflowExpression] Func<string> sAPSelectSAPTableRowworkflow, [WorkflowExpression] Func<int> sAPSelectSAPTableRowvisibleRowIndex = null, [WorkflowExpression] Func<bool> sAPSelectSAPTableRowselect = null)
        {
            SourceExpression.Validate(sAPSelectSAPTableRowsearchSAPElementId, nameof(sAPSelectSAPTableRowsearchSAPElementId), required: true);
            SourceExpression.Validate(sAPSelectSAPTableRowworkflow, nameof(sAPSelectSAPTableRowworkflow), required: true);
            SourceExpression.Validate(sAPSelectSAPTableRowvisibleRowIndex, nameof(sAPSelectSAPTableRowvisibleRowIndex), required: false);
            SourceExpression.Validate(sAPSelectSAPTableRowselect, nameof(sAPSelectSAPTableRowselect), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPSelectSAPTableRow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPSelectSAPTableRow = new JObject();
                var sAPSelectSAPTableRowpropCount = 0;
                sAPSelectSAPTableRowpropCount++;
                sAPSelectSAPTableRow["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPSelectSAPTableRowsearchSAPElementId);
                if (sAPSelectSAPTableRowvisibleRowIndex != null)
                {
                    if (sAPSelectSAPTableRowvisibleRowIndex != null)
                    {
                        sAPSelectSAPTableRow["VisibleRowIndex"] = SourceExpressionConverter.ConvertToken(sAPSelectSAPTableRowvisibleRowIndex);
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
                        sAPSelectSAPTableRow["Select"] = SourceExpressionConverter.ConvertToken(sAPSelectSAPTableRowselect);
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
                sAPSelectSAPTableRow["Workflow"] = SourceExpressionConverter.ConvertToken(sAPSelectSAPTableRowworkflow);
                if (sAPSelectSAPTableRowpropCount > 0)
                {
                    callPayload.Body = sAPSelectSAPTableRow;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPSelectSAPTableColumn([WorkflowExpression] Func<string> sAPSelectSAPTableColumnsearchSAPElementId, [WorkflowExpression] Func<string> sAPSelectSAPTableColumnworkflow, [WorkflowExpression] Func<int> sAPSelectSAPTableColumnvisibleColumnIndex = null, [WorkflowExpression] Func<bool> sAPSelectSAPTableColumnselect = null)
        {
            SourceExpression.Validate(sAPSelectSAPTableColumnsearchSAPElementId, nameof(sAPSelectSAPTableColumnsearchSAPElementId), required: true);
            SourceExpression.Validate(sAPSelectSAPTableColumnworkflow, nameof(sAPSelectSAPTableColumnworkflow), required: true);
            SourceExpression.Validate(sAPSelectSAPTableColumnvisibleColumnIndex, nameof(sAPSelectSAPTableColumnvisibleColumnIndex), required: false);
            SourceExpression.Validate(sAPSelectSAPTableColumnselect, nameof(sAPSelectSAPTableColumnselect), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPSelectSAPTableColumn";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPSelectSAPTableColumn = new JObject();
                var sAPSelectSAPTableColumnpropCount = 0;
                sAPSelectSAPTableColumnpropCount++;
                sAPSelectSAPTableColumn["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPSelectSAPTableColumnsearchSAPElementId);
                if (sAPSelectSAPTableColumnvisibleColumnIndex != null)
                {
                    if (sAPSelectSAPTableColumnvisibleColumnIndex != null)
                    {
                        sAPSelectSAPTableColumn["VisibleColumnIndex"] = SourceExpressionConverter.ConvertToken(sAPSelectSAPTableColumnvisibleColumnIndex);
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
                        sAPSelectSAPTableColumn["Select"] = SourceExpressionConverter.ConvertToken(sAPSelectSAPTableColumnselect);
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
                sAPSelectSAPTableColumn["Workflow"] = SourceExpressionConverter.ConvertToken(sAPSelectSAPTableColumnworkflow);
                if (sAPSelectSAPTableColumnpropCount > 0)
                {
                    callPayload.Body = sAPSelectSAPTableColumn;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetTreeNodesResponse> SAPGetTreeNodes([WorkflowExpression] Func<string> sAPGetTreeNodessearchSAPElementId, [WorkflowExpression] Func<string> sAPGetTreeNodesworkflow, [WorkflowExpression] Func<string> sAPGetTreeNodesparentNodeKey = null, [WorkflowExpression] Func<bool> sAPGetTreeNodesprocessSubNodes = null)
        {
            SourceExpression.Validate(sAPGetTreeNodessearchSAPElementId, nameof(sAPGetTreeNodessearchSAPElementId), required: true);
            SourceExpression.Validate(sAPGetTreeNodesworkflow, nameof(sAPGetTreeNodesworkflow), required: true);
            SourceExpression.Validate(sAPGetTreeNodesparentNodeKey, nameof(sAPGetTreeNodesparentNodeKey), required: false);
            SourceExpression.Validate(sAPGetTreeNodesprocessSubNodes, nameof(sAPGetTreeNodesprocessSubNodes), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPGetTreeNodes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGetTreeNodes = new JObject();
                var sAPGetTreeNodespropCount = 0;
                sAPGetTreeNodespropCount++;
                sAPGetTreeNodes["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPGetTreeNodessearchSAPElementId);
                if (sAPGetTreeNodesparentNodeKey != null)
                {
                    sAPGetTreeNodes["ParentNodeKey"] = SourceExpressionConverter.ConvertToken(sAPGetTreeNodesparentNodeKey);
                    sAPGetTreeNodespropCount++;
                }

                if (sAPGetTreeNodesprocessSubNodes != null)
                {
                    if (sAPGetTreeNodesprocessSubNodes != null)
                    {
                        sAPGetTreeNodes["ProcessSubNodes"] = SourceExpressionConverter.ConvertToken(sAPGetTreeNodesprocessSubNodes);
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
                sAPGetTreeNodes["Workflow"] = SourceExpressionConverter.ConvertToken(sAPGetTreeNodesworkflow);
                if (sAPGetTreeNodespropCount > 0)
                {
                    callPayload.Body = sAPGetTreeNodes;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SAPGetTreeNodesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPDoubleClickTreeItem([WorkflowExpression] Func<string> sAPDoubleClickTreeItemsearchSAPElementId, [WorkflowExpression] Func<string> sAPDoubleClickTreeItemworkflow, [WorkflowExpression] Func<string> sAPDoubleClickTreeItemsearchNodeKey = null, [WorkflowExpression] Func<string> sAPDoubleClickTreeItemsearchNodePath = null, [WorkflowExpression] Func<string> sAPDoubleClickTreeItemsearchNodeText = null, [WorkflowExpression] Func<bool> sAPDoubleClickTreeItemsearchNodeTextIsRegularExpression = null, [WorkflowExpression] Func<bool> sAPDoubleClickTreeItemsearchNodeTextIsCaseSensitive = null, [WorkflowExpression] Func<string> sAPDoubleClickTreeItemsearchColumnName = null, [WorkflowExpression] Func<string> sAPDoubleClickTreeItemsearchColumnTitle = null, [WorkflowExpression] Func<bool> sAPDoubleClickTreeItemsearchColumnTitleIsRegularExpression = null, [WorkflowExpression] Func<bool> sAPDoubleClickTreeItemsearchColumnTitleIsCaseSensitive = null)
        {
            SourceExpression.Validate(sAPDoubleClickTreeItemsearchSAPElementId, nameof(sAPDoubleClickTreeItemsearchSAPElementId), required: true);
            SourceExpression.Validate(sAPDoubleClickTreeItemworkflow, nameof(sAPDoubleClickTreeItemworkflow), required: true);
            SourceExpression.Validate(sAPDoubleClickTreeItemsearchNodeKey, nameof(sAPDoubleClickTreeItemsearchNodeKey), required: false);
            SourceExpression.Validate(sAPDoubleClickTreeItemsearchNodePath, nameof(sAPDoubleClickTreeItemsearchNodePath), required: false);
            SourceExpression.Validate(sAPDoubleClickTreeItemsearchNodeText, nameof(sAPDoubleClickTreeItemsearchNodeText), required: false);
            SourceExpression.Validate(sAPDoubleClickTreeItemsearchNodeTextIsRegularExpression, nameof(sAPDoubleClickTreeItemsearchNodeTextIsRegularExpression), required: false);
            SourceExpression.Validate(sAPDoubleClickTreeItemsearchNodeTextIsCaseSensitive, nameof(sAPDoubleClickTreeItemsearchNodeTextIsCaseSensitive), required: false);
            SourceExpression.Validate(sAPDoubleClickTreeItemsearchColumnName, nameof(sAPDoubleClickTreeItemsearchColumnName), required: false);
            SourceExpression.Validate(sAPDoubleClickTreeItemsearchColumnTitle, nameof(sAPDoubleClickTreeItemsearchColumnTitle), required: false);
            SourceExpression.Validate(sAPDoubleClickTreeItemsearchColumnTitleIsRegularExpression, nameof(sAPDoubleClickTreeItemsearchColumnTitleIsRegularExpression), required: false);
            SourceExpression.Validate(sAPDoubleClickTreeItemsearchColumnTitleIsCaseSensitive, nameof(sAPDoubleClickTreeItemsearchColumnTitleIsCaseSensitive), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPDoubleClickTreeItem";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPDoubleClickTreeItem = new JObject();
                var sAPDoubleClickTreeItempropCount = 0;
                sAPDoubleClickTreeItempropCount++;
                sAPDoubleClickTreeItem["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPDoubleClickTreeItemsearchSAPElementId);
                if (sAPDoubleClickTreeItemsearchNodeKey != null)
                {
                    sAPDoubleClickTreeItem["SearchNodeKey"] = SourceExpressionConverter.ConvertToken(sAPDoubleClickTreeItemsearchNodeKey);
                    sAPDoubleClickTreeItempropCount++;
                }

                if (sAPDoubleClickTreeItemsearchNodePath != null)
                {
                    sAPDoubleClickTreeItem["SearchNodePath"] = SourceExpressionConverter.ConvertToken(sAPDoubleClickTreeItemsearchNodePath);
                    sAPDoubleClickTreeItempropCount++;
                }

                if (sAPDoubleClickTreeItemsearchNodeText != null)
                {
                    sAPDoubleClickTreeItem["SearchNodeText"] = SourceExpressionConverter.ConvertToken(sAPDoubleClickTreeItemsearchNodeText);
                    sAPDoubleClickTreeItempropCount++;
                }

                if (sAPDoubleClickTreeItemsearchNodeTextIsRegularExpression != null)
                {
                    if (sAPDoubleClickTreeItemsearchNodeTextIsRegularExpression != null)
                    {
                        sAPDoubleClickTreeItem["SearchNodeTextIsRegularExpression"] = SourceExpressionConverter.ConvertToken(sAPDoubleClickTreeItemsearchNodeTextIsRegularExpression);
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
                        sAPDoubleClickTreeItem["SearchNodeTextIsCaseSensitive"] = SourceExpressionConverter.ConvertToken(sAPDoubleClickTreeItemsearchNodeTextIsCaseSensitive);
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
                    sAPDoubleClickTreeItem["SearchColumnName"] = SourceExpressionConverter.ConvertToken(sAPDoubleClickTreeItemsearchColumnName);
                    sAPDoubleClickTreeItempropCount++;
                }

                if (sAPDoubleClickTreeItemsearchColumnTitle != null)
                {
                    sAPDoubleClickTreeItem["SearchColumnTitle"] = SourceExpressionConverter.ConvertToken(sAPDoubleClickTreeItemsearchColumnTitle);
                    sAPDoubleClickTreeItempropCount++;
                }

                if (sAPDoubleClickTreeItemsearchColumnTitleIsRegularExpression != null)
                {
                    if (sAPDoubleClickTreeItemsearchColumnTitleIsRegularExpression != null)
                    {
                        sAPDoubleClickTreeItem["SearchColumnTitleIsRegularExpression"] = SourceExpressionConverter.ConvertToken(sAPDoubleClickTreeItemsearchColumnTitleIsRegularExpression);
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
                        sAPDoubleClickTreeItem["SearchColumnTitleIsCaseSensitive"] = SourceExpressionConverter.ConvertToken(sAPDoubleClickTreeItemsearchColumnTitleIsCaseSensitive);
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
                sAPDoubleClickTreeItem["Workflow"] = SourceExpressionConverter.ConvertToken(sAPDoubleClickTreeItemworkflow);
                if (sAPDoubleClickTreeItempropCount > 0)
                {
                    callPayload.Body = sAPDoubleClickTreeItem;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPSelectTreeItem([WorkflowExpression] Func<string> sAPSelectTreeItemsearchSAPElementId, [WorkflowExpression] Func<string> sAPSelectTreeItemworkflow, [WorkflowExpression] Func<string> sAPSelectTreeItemsearchNodeKey = null, [WorkflowExpression] Func<string> sAPSelectTreeItemsearchNodePath = null, [WorkflowExpression] Func<string> sAPSelectTreeItemsearchNodeText = null, [WorkflowExpression] Func<bool> sAPSelectTreeItemsearchNodeTextIsRegularExpression = null, [WorkflowExpression] Func<bool> sAPSelectTreeItemsearchNodeTextIsCaseSensitive = null, [WorkflowExpression] Func<string> sAPSelectTreeItemsearchColumnName = null, [WorkflowExpression] Func<string> sAPSelectTreeItemsearchColumnTitle = null, [WorkflowExpression] Func<bool> sAPSelectTreeItemsearchColumnTitleIsRegularExpression = null, [WorkflowExpression] Func<bool> sAPSelectTreeItemsearchColumnTitleIsCaseSensitive = null, [WorkflowExpression] Func<bool> sAPSelectTreeItemselect = null, [WorkflowExpression] Func<bool> sAPSelectTreeItemdeselectAllFirst = null)
        {
            SourceExpression.Validate(sAPSelectTreeItemsearchSAPElementId, nameof(sAPSelectTreeItemsearchSAPElementId), required: true);
            SourceExpression.Validate(sAPSelectTreeItemworkflow, nameof(sAPSelectTreeItemworkflow), required: true);
            SourceExpression.Validate(sAPSelectTreeItemsearchNodeKey, nameof(sAPSelectTreeItemsearchNodeKey), required: false);
            SourceExpression.Validate(sAPSelectTreeItemsearchNodePath, nameof(sAPSelectTreeItemsearchNodePath), required: false);
            SourceExpression.Validate(sAPSelectTreeItemsearchNodeText, nameof(sAPSelectTreeItemsearchNodeText), required: false);
            SourceExpression.Validate(sAPSelectTreeItemsearchNodeTextIsRegularExpression, nameof(sAPSelectTreeItemsearchNodeTextIsRegularExpression), required: false);
            SourceExpression.Validate(sAPSelectTreeItemsearchNodeTextIsCaseSensitive, nameof(sAPSelectTreeItemsearchNodeTextIsCaseSensitive), required: false);
            SourceExpression.Validate(sAPSelectTreeItemsearchColumnName, nameof(sAPSelectTreeItemsearchColumnName), required: false);
            SourceExpression.Validate(sAPSelectTreeItemsearchColumnTitle, nameof(sAPSelectTreeItemsearchColumnTitle), required: false);
            SourceExpression.Validate(sAPSelectTreeItemsearchColumnTitleIsRegularExpression, nameof(sAPSelectTreeItemsearchColumnTitleIsRegularExpression), required: false);
            SourceExpression.Validate(sAPSelectTreeItemsearchColumnTitleIsCaseSensitive, nameof(sAPSelectTreeItemsearchColumnTitleIsCaseSensitive), required: false);
            SourceExpression.Validate(sAPSelectTreeItemselect, nameof(sAPSelectTreeItemselect), required: false);
            SourceExpression.Validate(sAPSelectTreeItemdeselectAllFirst, nameof(sAPSelectTreeItemdeselectAllFirst), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPSelectTreeItem";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPSelectTreeItem = new JObject();
                var sAPSelectTreeItempropCount = 0;
                sAPSelectTreeItempropCount++;
                sAPSelectTreeItem["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPSelectTreeItemsearchSAPElementId);
                if (sAPSelectTreeItemsearchNodeKey != null)
                {
                    sAPSelectTreeItem["SearchNodeKey"] = SourceExpressionConverter.ConvertToken(sAPSelectTreeItemsearchNodeKey);
                    sAPSelectTreeItempropCount++;
                }

                if (sAPSelectTreeItemsearchNodePath != null)
                {
                    sAPSelectTreeItem["SearchNodePath"] = SourceExpressionConverter.ConvertToken(sAPSelectTreeItemsearchNodePath);
                    sAPSelectTreeItempropCount++;
                }

                if (sAPSelectTreeItemsearchNodeText != null)
                {
                    sAPSelectTreeItem["SearchNodeText"] = SourceExpressionConverter.ConvertToken(sAPSelectTreeItemsearchNodeText);
                    sAPSelectTreeItempropCount++;
                }

                if (sAPSelectTreeItemsearchNodeTextIsRegularExpression != null)
                {
                    if (sAPSelectTreeItemsearchNodeTextIsRegularExpression != null)
                    {
                        sAPSelectTreeItem["SearchNodeTextIsRegularExpression"] = SourceExpressionConverter.ConvertToken(sAPSelectTreeItemsearchNodeTextIsRegularExpression);
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
                        sAPSelectTreeItem["SearchNodeTextIsCaseSensitive"] = SourceExpressionConverter.ConvertToken(sAPSelectTreeItemsearchNodeTextIsCaseSensitive);
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
                    sAPSelectTreeItem["SearchColumnName"] = SourceExpressionConverter.ConvertToken(sAPSelectTreeItemsearchColumnName);
                    sAPSelectTreeItempropCount++;
                }

                if (sAPSelectTreeItemsearchColumnTitle != null)
                {
                    sAPSelectTreeItem["SearchColumnTitle"] = SourceExpressionConverter.ConvertToken(sAPSelectTreeItemsearchColumnTitle);
                    sAPSelectTreeItempropCount++;
                }

                if (sAPSelectTreeItemsearchColumnTitleIsRegularExpression != null)
                {
                    if (sAPSelectTreeItemsearchColumnTitleIsRegularExpression != null)
                    {
                        sAPSelectTreeItem["SearchColumnTitleIsRegularExpression"] = SourceExpressionConverter.ConvertToken(sAPSelectTreeItemsearchColumnTitleIsRegularExpression);
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
                        sAPSelectTreeItem["SearchColumnTitleIsCaseSensitive"] = SourceExpressionConverter.ConvertToken(sAPSelectTreeItemsearchColumnTitleIsCaseSensitive);
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
                        sAPSelectTreeItem["Select"] = SourceExpressionConverter.ConvertToken(sAPSelectTreeItemselect);
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
                        sAPSelectTreeItem["DeselectAllFirst"] = SourceExpressionConverter.ConvertToken(sAPSelectTreeItemdeselectAllFirst);
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
                sAPSelectTreeItem["Workflow"] = SourceExpressionConverter.ConvertToken(sAPSelectTreeItemworkflow);
                if (sAPSelectTreeItempropCount > 0)
                {
                    callPayload.Body = sAPSelectTreeItem;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPExpandTreeNode([WorkflowExpression] Func<string> sAPExpandTreeNodesearchSAPElementId, [WorkflowExpression] Func<string> sAPExpandTreeNodeworkflow, [WorkflowExpression] Func<string> sAPExpandTreeNodesearchNodeKey = null, [WorkflowExpression] Func<string> sAPExpandTreeNodesearchNodePath = null, [WorkflowExpression] Func<string> sAPExpandTreeNodesearchNodeText = null, [WorkflowExpression] Func<bool> sAPExpandTreeNodesearchNodeTextIsRegularExpression = null, [WorkflowExpression] Func<bool> sAPExpandTreeNodesearchNodeTextIsCaseSensitive = null, [WorkflowExpression] Func<bool> sAPExpandTreeNodeexpand = null)
        {
            SourceExpression.Validate(sAPExpandTreeNodesearchSAPElementId, nameof(sAPExpandTreeNodesearchSAPElementId), required: true);
            SourceExpression.Validate(sAPExpandTreeNodeworkflow, nameof(sAPExpandTreeNodeworkflow), required: true);
            SourceExpression.Validate(sAPExpandTreeNodesearchNodeKey, nameof(sAPExpandTreeNodesearchNodeKey), required: false);
            SourceExpression.Validate(sAPExpandTreeNodesearchNodePath, nameof(sAPExpandTreeNodesearchNodePath), required: false);
            SourceExpression.Validate(sAPExpandTreeNodesearchNodeText, nameof(sAPExpandTreeNodesearchNodeText), required: false);
            SourceExpression.Validate(sAPExpandTreeNodesearchNodeTextIsRegularExpression, nameof(sAPExpandTreeNodesearchNodeTextIsRegularExpression), required: false);
            SourceExpression.Validate(sAPExpandTreeNodesearchNodeTextIsCaseSensitive, nameof(sAPExpandTreeNodesearchNodeTextIsCaseSensitive), required: false);
            SourceExpression.Validate(sAPExpandTreeNodeexpand, nameof(sAPExpandTreeNodeexpand), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPExpandTreeNode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPExpandTreeNode = new JObject();
                var sAPExpandTreeNodepropCount = 0;
                sAPExpandTreeNodepropCount++;
                sAPExpandTreeNode["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPExpandTreeNodesearchSAPElementId);
                if (sAPExpandTreeNodesearchNodeKey != null)
                {
                    sAPExpandTreeNode["SearchNodeKey"] = SourceExpressionConverter.ConvertToken(sAPExpandTreeNodesearchNodeKey);
                    sAPExpandTreeNodepropCount++;
                }

                if (sAPExpandTreeNodesearchNodePath != null)
                {
                    sAPExpandTreeNode["SearchNodePath"] = SourceExpressionConverter.ConvertToken(sAPExpandTreeNodesearchNodePath);
                    sAPExpandTreeNodepropCount++;
                }

                if (sAPExpandTreeNodesearchNodeText != null)
                {
                    sAPExpandTreeNode["SearchNodeText"] = SourceExpressionConverter.ConvertToken(sAPExpandTreeNodesearchNodeText);
                    sAPExpandTreeNodepropCount++;
                }

                if (sAPExpandTreeNodesearchNodeTextIsRegularExpression != null)
                {
                    if (sAPExpandTreeNodesearchNodeTextIsRegularExpression != null)
                    {
                        sAPExpandTreeNode["SearchNodeTextIsRegularExpression"] = SourceExpressionConverter.ConvertToken(sAPExpandTreeNodesearchNodeTextIsRegularExpression);
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
                        sAPExpandTreeNode["SearchNodeTextIsCaseSensitive"] = SourceExpressionConverter.ConvertToken(sAPExpandTreeNodesearchNodeTextIsCaseSensitive);
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
                        sAPExpandTreeNode["Expand"] = SourceExpressionConverter.ConvertToken(sAPExpandTreeNodeexpand);
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
                sAPExpandTreeNode["Workflow"] = SourceExpressionConverter.ConvertToken(sAPExpandTreeNodeworkflow);
                if (sAPExpandTreeNodepropCount > 0)
                {
                    callPayload.Body = sAPExpandTreeNode;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPDeselectAllTreeNodes([WorkflowExpression] Func<string> sAPDeselectAllTreeNodessearchSAPElementId, [WorkflowExpression] Func<string> sAPDeselectAllTreeNodesworkflow)
        {
            SourceExpression.Validate(sAPDeselectAllTreeNodessearchSAPElementId, nameof(sAPDeselectAllTreeNodessearchSAPElementId), required: true);
            SourceExpression.Validate(sAPDeselectAllTreeNodesworkflow, nameof(sAPDeselectAllTreeNodesworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPDeselectAllTreeNodes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPDeselectAllTreeNodes = new JObject();
                var sAPDeselectAllTreeNodespropCount = 0;
                sAPDeselectAllTreeNodespropCount++;
                sAPDeselectAllTreeNodes["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPDeselectAllTreeNodessearchSAPElementId);
                sAPDeselectAllTreeNodespropCount++;
                sAPDeselectAllTreeNodes["Workflow"] = SourceExpressionConverter.ConvertToken(sAPDeselectAllTreeNodesworkflow);
                if (sAPDeselectAllTreeNodespropCount > 0)
                {
                    callPayload.Body = sAPDeselectAllTreeNodes;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPPressKeyOnTree([WorkflowExpression] Func<string> sAPPressKeyOnTreesearchSAPElementId, [WorkflowExpression] Func<string> sAPPressKeyOnTreekey, [WorkflowExpression] Func<string> sAPPressKeyOnTreeworkflow)
        {
            SourceExpression.Validate(sAPPressKeyOnTreesearchSAPElementId, nameof(sAPPressKeyOnTreesearchSAPElementId), required: true);
            SourceExpression.Validate(sAPPressKeyOnTreekey, nameof(sAPPressKeyOnTreekey), required: true);
            SourceExpression.Validate(sAPPressKeyOnTreeworkflow, nameof(sAPPressKeyOnTreeworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPPressKeyOnTree";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPPressKeyOnTree = new JObject();
                var sAPPressKeyOnTreepropCount = 0;
                sAPPressKeyOnTreepropCount++;
                sAPPressKeyOnTree["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPPressKeyOnTreesearchSAPElementId);
                sAPPressKeyOnTreepropCount++;
                sAPPressKeyOnTree["Key"] = SourceExpressionConverter.ConvertToken(sAPPressKeyOnTreekey);
                sAPPressKeyOnTreepropCount++;
                sAPPressKeyOnTree["Workflow"] = SourceExpressionConverter.ConvertToken(sAPPressKeyOnTreeworkflow);
                if (sAPPressKeyOnTreepropCount > 0)
                {
                    callPayload.Body = sAPPressKeyOnTree;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPOpenContextMenuOnTreeItem([WorkflowExpression] Func<string> sAPOpenContextMenuOnTreeItemsearchSAPElementId, [WorkflowExpression] Func<string> sAPOpenContextMenuOnTreeItemworkflow, [WorkflowExpression] Func<string> sAPOpenContextMenuOnTreeItemsearchNodeKey = null, [WorkflowExpression] Func<string> sAPOpenContextMenuOnTreeItemsearchNodePath = null, [WorkflowExpression] Func<string> sAPOpenContextMenuOnTreeItemsearchNodeText = null, [WorkflowExpression] Func<bool> sAPOpenContextMenuOnTreeItemsearchNodeTextIsRegularExpression = null, [WorkflowExpression] Func<bool> sAPOpenContextMenuOnTreeItemsearchNodeTextIsCaseSensitive = null, [WorkflowExpression] Func<string> sAPOpenContextMenuOnTreeItemsearchColumnName = null, [WorkflowExpression] Func<string> sAPOpenContextMenuOnTreeItemsearchColumnTitle = null, [WorkflowExpression] Func<bool> sAPOpenContextMenuOnTreeItemsearchColumnTitleIsRegularExpression = null, [WorkflowExpression] Func<bool> sAPOpenContextMenuOnTreeItemsearchColumnTitleIsCaseSensitive = null)
        {
            SourceExpression.Validate(sAPOpenContextMenuOnTreeItemsearchSAPElementId, nameof(sAPOpenContextMenuOnTreeItemsearchSAPElementId), required: true);
            SourceExpression.Validate(sAPOpenContextMenuOnTreeItemworkflow, nameof(sAPOpenContextMenuOnTreeItemworkflow), required: true);
            SourceExpression.Validate(sAPOpenContextMenuOnTreeItemsearchNodeKey, nameof(sAPOpenContextMenuOnTreeItemsearchNodeKey), required: false);
            SourceExpression.Validate(sAPOpenContextMenuOnTreeItemsearchNodePath, nameof(sAPOpenContextMenuOnTreeItemsearchNodePath), required: false);
            SourceExpression.Validate(sAPOpenContextMenuOnTreeItemsearchNodeText, nameof(sAPOpenContextMenuOnTreeItemsearchNodeText), required: false);
            SourceExpression.Validate(sAPOpenContextMenuOnTreeItemsearchNodeTextIsRegularExpression, nameof(sAPOpenContextMenuOnTreeItemsearchNodeTextIsRegularExpression), required: false);
            SourceExpression.Validate(sAPOpenContextMenuOnTreeItemsearchNodeTextIsCaseSensitive, nameof(sAPOpenContextMenuOnTreeItemsearchNodeTextIsCaseSensitive), required: false);
            SourceExpression.Validate(sAPOpenContextMenuOnTreeItemsearchColumnName, nameof(sAPOpenContextMenuOnTreeItemsearchColumnName), required: false);
            SourceExpression.Validate(sAPOpenContextMenuOnTreeItemsearchColumnTitle, nameof(sAPOpenContextMenuOnTreeItemsearchColumnTitle), required: false);
            SourceExpression.Validate(sAPOpenContextMenuOnTreeItemsearchColumnTitleIsRegularExpression, nameof(sAPOpenContextMenuOnTreeItemsearchColumnTitleIsRegularExpression), required: false);
            SourceExpression.Validate(sAPOpenContextMenuOnTreeItemsearchColumnTitleIsCaseSensitive, nameof(sAPOpenContextMenuOnTreeItemsearchColumnTitleIsCaseSensitive), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPOpenContextMenuOnTreeItem";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPOpenContextMenuOnTreeItem = new JObject();
                var sAPOpenContextMenuOnTreeItempropCount = 0;
                sAPOpenContextMenuOnTreeItempropCount++;
                sAPOpenContextMenuOnTreeItem["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPOpenContextMenuOnTreeItemsearchSAPElementId);
                if (sAPOpenContextMenuOnTreeItemsearchNodeKey != null)
                {
                    sAPOpenContextMenuOnTreeItem["SearchNodeKey"] = SourceExpressionConverter.ConvertToken(sAPOpenContextMenuOnTreeItemsearchNodeKey);
                    sAPOpenContextMenuOnTreeItempropCount++;
                }

                if (sAPOpenContextMenuOnTreeItemsearchNodePath != null)
                {
                    sAPOpenContextMenuOnTreeItem["SearchNodePath"] = SourceExpressionConverter.ConvertToken(sAPOpenContextMenuOnTreeItemsearchNodePath);
                    sAPOpenContextMenuOnTreeItempropCount++;
                }

                if (sAPOpenContextMenuOnTreeItemsearchNodeText != null)
                {
                    sAPOpenContextMenuOnTreeItem["SearchNodeText"] = SourceExpressionConverter.ConvertToken(sAPOpenContextMenuOnTreeItemsearchNodeText);
                    sAPOpenContextMenuOnTreeItempropCount++;
                }

                if (sAPOpenContextMenuOnTreeItemsearchNodeTextIsRegularExpression != null)
                {
                    if (sAPOpenContextMenuOnTreeItemsearchNodeTextIsRegularExpression != null)
                    {
                        sAPOpenContextMenuOnTreeItem["SearchNodeTextIsRegularExpression"] = SourceExpressionConverter.ConvertToken(sAPOpenContextMenuOnTreeItemsearchNodeTextIsRegularExpression);
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
                        sAPOpenContextMenuOnTreeItem["SearchNodeTextIsCaseSensitive"] = SourceExpressionConverter.ConvertToken(sAPOpenContextMenuOnTreeItemsearchNodeTextIsCaseSensitive);
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
                    sAPOpenContextMenuOnTreeItem["SearchColumnName"] = SourceExpressionConverter.ConvertToken(sAPOpenContextMenuOnTreeItemsearchColumnName);
                    sAPOpenContextMenuOnTreeItempropCount++;
                }

                if (sAPOpenContextMenuOnTreeItemsearchColumnTitle != null)
                {
                    sAPOpenContextMenuOnTreeItem["SearchColumnTitle"] = SourceExpressionConverter.ConvertToken(sAPOpenContextMenuOnTreeItemsearchColumnTitle);
                    sAPOpenContextMenuOnTreeItempropCount++;
                }

                if (sAPOpenContextMenuOnTreeItemsearchColumnTitleIsRegularExpression != null)
                {
                    if (sAPOpenContextMenuOnTreeItemsearchColumnTitleIsRegularExpression != null)
                    {
                        sAPOpenContextMenuOnTreeItem["SearchColumnTitleIsRegularExpression"] = SourceExpressionConverter.ConvertToken(sAPOpenContextMenuOnTreeItemsearchColumnTitleIsRegularExpression);
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
                        sAPOpenContextMenuOnTreeItem["SearchColumnTitleIsCaseSensitive"] = SourceExpressionConverter.ConvertToken(sAPOpenContextMenuOnTreeItemsearchColumnTitleIsCaseSensitive);
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
                sAPOpenContextMenuOnTreeItem["Workflow"] = SourceExpressionConverter.ConvertToken(sAPOpenContextMenuOnTreeItemworkflow);
                if (sAPOpenContextMenuOnTreeItempropCount > 0)
                {
                    callPayload.Body = sAPOpenContextMenuOnTreeItem;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetTreeTextContentsResponse> SAPGetTreeTextContents([WorkflowExpression] Func<string> sAPGetTreeTextContentssearchSAPElementId, [WorkflowExpression] Func<string> sAPGetTreeTextContentsworkflow, [WorkflowExpression] Func<int> sAPGetTreeTextContentsfirstRowToReturn = null, [WorkflowExpression] Func<int> sAPGetTreeTextContentsmaxRowsToReturn = null, [WorkflowExpression] Func<int> sAPGetTreeTextContentsfirstColumnToReturn = null, [WorkflowExpression] Func<int> sAPGetTreeTextContentsmaxColumnsToReturn = null, [WorkflowExpression] Func<bool> sAPGetTreeTextContentsuseColumnHeadersFromTree = null, [WorkflowExpression] Func<bool> sAPGetTreeTextContentsreturnRowIndexInOutputCollection = null, [WorkflowExpression] Func<string> sAPGetTreeTextContentsnameOfColumnToStoreRowIndex = null)
        {
            SourceExpression.Validate(sAPGetTreeTextContentssearchSAPElementId, nameof(sAPGetTreeTextContentssearchSAPElementId), required: true);
            SourceExpression.Validate(sAPGetTreeTextContentsworkflow, nameof(sAPGetTreeTextContentsworkflow), required: true);
            SourceExpression.Validate(sAPGetTreeTextContentsfirstRowToReturn, nameof(sAPGetTreeTextContentsfirstRowToReturn), required: false);
            SourceExpression.Validate(sAPGetTreeTextContentsmaxRowsToReturn, nameof(sAPGetTreeTextContentsmaxRowsToReturn), required: false);
            SourceExpression.Validate(sAPGetTreeTextContentsfirstColumnToReturn, nameof(sAPGetTreeTextContentsfirstColumnToReturn), required: false);
            SourceExpression.Validate(sAPGetTreeTextContentsmaxColumnsToReturn, nameof(sAPGetTreeTextContentsmaxColumnsToReturn), required: false);
            SourceExpression.Validate(sAPGetTreeTextContentsuseColumnHeadersFromTree, nameof(sAPGetTreeTextContentsuseColumnHeadersFromTree), required: false);
            SourceExpression.Validate(sAPGetTreeTextContentsreturnRowIndexInOutputCollection, nameof(sAPGetTreeTextContentsreturnRowIndexInOutputCollection), required: false);
            SourceExpression.Validate(sAPGetTreeTextContentsnameOfColumnToStoreRowIndex, nameof(sAPGetTreeTextContentsnameOfColumnToStoreRowIndex), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPGetTreeTextContents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGetTreeTextContents = new JObject();
                var sAPGetTreeTextContentspropCount = 0;
                sAPGetTreeTextContentspropCount++;
                sAPGetTreeTextContents["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPGetTreeTextContentssearchSAPElementId);
                if (sAPGetTreeTextContentsfirstRowToReturn != null)
                {
                    if (sAPGetTreeTextContentsfirstRowToReturn != null)
                    {
                        sAPGetTreeTextContents["FirstRowToReturn"] = SourceExpressionConverter.ConvertToken(sAPGetTreeTextContentsfirstRowToReturn);
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
                        sAPGetTreeTextContents["MaxRowsToReturn"] = SourceExpressionConverter.ConvertToken(sAPGetTreeTextContentsmaxRowsToReturn);
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
                        sAPGetTreeTextContents["FirstColumnToReturn"] = SourceExpressionConverter.ConvertToken(sAPGetTreeTextContentsfirstColumnToReturn);
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
                        sAPGetTreeTextContents["MaxColumnsToReturn"] = SourceExpressionConverter.ConvertToken(sAPGetTreeTextContentsmaxColumnsToReturn);
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
                        sAPGetTreeTextContents["UseColumnHeadersFromTree"] = SourceExpressionConverter.ConvertToken(sAPGetTreeTextContentsuseColumnHeadersFromTree);
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
                        sAPGetTreeTextContents["ReturnRowIndexInOutputCollection"] = SourceExpressionConverter.ConvertToken(sAPGetTreeTextContentsreturnRowIndexInOutputCollection);
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
                    sAPGetTreeTextContents["NameOfColumnToStoreRowIndex"] = SourceExpressionConverter.ConvertToken(sAPGetTreeTextContentsnameOfColumnToStoreRowIndex);
                    sAPGetTreeTextContentspropCount++;
                }

                sAPGetTreeTextContentspropCount++;
                sAPGetTreeTextContents["Workflow"] = SourceExpressionConverter.ConvertToken(sAPGetTreeTextContentsworkflow);
                if (sAPGetTreeTextContentspropCount > 0)
                {
                    callPayload.Body = sAPGetTreeTextContents;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SAPGetTreeTextContentsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPSetTreeColumnWidth([WorkflowExpression] Func<string> sAPSetTreeColumnWidthsearchSAPElementId, [WorkflowExpression] Func<string> sAPSetTreeColumnWidthworkflow, [WorkflowExpression] Func<string> sAPSetTreeColumnWidthsearchColumnName = null, [WorkflowExpression] Func<string> sAPSetTreeColumnWidthsearchColumnTitle = null, [WorkflowExpression] Func<bool> sAPSetTreeColumnWidthsearchColumnTitleIsRegularExpression = null, [WorkflowExpression] Func<bool> sAPSetTreeColumnWidthsearchColumnTitleIsCaseSensitive = null, [WorkflowExpression] Func<int> sAPSetTreeColumnWidthcolumnWidthInPixels = null)
        {
            SourceExpression.Validate(sAPSetTreeColumnWidthsearchSAPElementId, nameof(sAPSetTreeColumnWidthsearchSAPElementId), required: true);
            SourceExpression.Validate(sAPSetTreeColumnWidthworkflow, nameof(sAPSetTreeColumnWidthworkflow), required: true);
            SourceExpression.Validate(sAPSetTreeColumnWidthsearchColumnName, nameof(sAPSetTreeColumnWidthsearchColumnName), required: false);
            SourceExpression.Validate(sAPSetTreeColumnWidthsearchColumnTitle, nameof(sAPSetTreeColumnWidthsearchColumnTitle), required: false);
            SourceExpression.Validate(sAPSetTreeColumnWidthsearchColumnTitleIsRegularExpression, nameof(sAPSetTreeColumnWidthsearchColumnTitleIsRegularExpression), required: false);
            SourceExpression.Validate(sAPSetTreeColumnWidthsearchColumnTitleIsCaseSensitive, nameof(sAPSetTreeColumnWidthsearchColumnTitleIsCaseSensitive), required: false);
            SourceExpression.Validate(sAPSetTreeColumnWidthcolumnWidthInPixels, nameof(sAPSetTreeColumnWidthcolumnWidthInPixels), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPSetTreeColumnWidth";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPSetTreeColumnWidth = new JObject();
                var sAPSetTreeColumnWidthpropCount = 0;
                sAPSetTreeColumnWidthpropCount++;
                sAPSetTreeColumnWidth["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPSetTreeColumnWidthsearchSAPElementId);
                if (sAPSetTreeColumnWidthsearchColumnName != null)
                {
                    sAPSetTreeColumnWidth["SearchColumnName"] = SourceExpressionConverter.ConvertToken(sAPSetTreeColumnWidthsearchColumnName);
                    sAPSetTreeColumnWidthpropCount++;
                }

                if (sAPSetTreeColumnWidthsearchColumnTitle != null)
                {
                    sAPSetTreeColumnWidth["SearchColumnTitle"] = SourceExpressionConverter.ConvertToken(sAPSetTreeColumnWidthsearchColumnTitle);
                    sAPSetTreeColumnWidthpropCount++;
                }

                if (sAPSetTreeColumnWidthsearchColumnTitleIsRegularExpression != null)
                {
                    if (sAPSetTreeColumnWidthsearchColumnTitleIsRegularExpression != null)
                    {
                        sAPSetTreeColumnWidth["SearchColumnTitleIsRegularExpression"] = SourceExpressionConverter.ConvertToken(sAPSetTreeColumnWidthsearchColumnTitleIsRegularExpression);
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
                        sAPSetTreeColumnWidth["SearchColumnTitleIsCaseSensitive"] = SourceExpressionConverter.ConvertToken(sAPSetTreeColumnWidthsearchColumnTitleIsCaseSensitive);
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
                        sAPSetTreeColumnWidth["ColumnWidthInPixels"] = SourceExpressionConverter.ConvertToken(sAPSetTreeColumnWidthcolumnWidthInPixels);
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
                sAPSetTreeColumnWidth["Workflow"] = SourceExpressionConverter.ConvertToken(sAPSetTreeColumnWidthworkflow);
                if (sAPSetTreeColumnWidthpropCount > 0)
                {
                    callPayload.Body = sAPSetTreeColumnWidth;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPPressButtonOnTreeItem([WorkflowExpression] Func<string> sAPPressButtonOnTreeItemsearchSAPElementId, [WorkflowExpression] Func<string> sAPPressButtonOnTreeItemworkflow, [WorkflowExpression] Func<string> sAPPressButtonOnTreeItemsearchNodeKey = null, [WorkflowExpression] Func<string> sAPPressButtonOnTreeItemsearchNodePath = null, [WorkflowExpression] Func<string> sAPPressButtonOnTreeItemsearchNodeText = null, [WorkflowExpression] Func<bool> sAPPressButtonOnTreeItemsearchNodeTextIsRegularExpression = null, [WorkflowExpression] Func<bool> sAPPressButtonOnTreeItemsearchNodeTextIsCaseSensitive = null, [WorkflowExpression] Func<string> sAPPressButtonOnTreeItemsearchColumnName = null, [WorkflowExpression] Func<string> sAPPressButtonOnTreeItemsearchColumnTitle = null, [WorkflowExpression] Func<bool> sAPPressButtonOnTreeItemsearchColumnTitleIsRegularExpression = null, [WorkflowExpression] Func<bool> sAPPressButtonOnTreeItemsearchColumnTitleIsCaseSensitive = null, [WorkflowExpression] Func<bool> sAPPressButtonOnTreeItemforce = null)
        {
            SourceExpression.Validate(sAPPressButtonOnTreeItemsearchSAPElementId, nameof(sAPPressButtonOnTreeItemsearchSAPElementId), required: true);
            SourceExpression.Validate(sAPPressButtonOnTreeItemworkflow, nameof(sAPPressButtonOnTreeItemworkflow), required: true);
            SourceExpression.Validate(sAPPressButtonOnTreeItemsearchNodeKey, nameof(sAPPressButtonOnTreeItemsearchNodeKey), required: false);
            SourceExpression.Validate(sAPPressButtonOnTreeItemsearchNodePath, nameof(sAPPressButtonOnTreeItemsearchNodePath), required: false);
            SourceExpression.Validate(sAPPressButtonOnTreeItemsearchNodeText, nameof(sAPPressButtonOnTreeItemsearchNodeText), required: false);
            SourceExpression.Validate(sAPPressButtonOnTreeItemsearchNodeTextIsRegularExpression, nameof(sAPPressButtonOnTreeItemsearchNodeTextIsRegularExpression), required: false);
            SourceExpression.Validate(sAPPressButtonOnTreeItemsearchNodeTextIsCaseSensitive, nameof(sAPPressButtonOnTreeItemsearchNodeTextIsCaseSensitive), required: false);
            SourceExpression.Validate(sAPPressButtonOnTreeItemsearchColumnName, nameof(sAPPressButtonOnTreeItemsearchColumnName), required: false);
            SourceExpression.Validate(sAPPressButtonOnTreeItemsearchColumnTitle, nameof(sAPPressButtonOnTreeItemsearchColumnTitle), required: false);
            SourceExpression.Validate(sAPPressButtonOnTreeItemsearchColumnTitleIsRegularExpression, nameof(sAPPressButtonOnTreeItemsearchColumnTitleIsRegularExpression), required: false);
            SourceExpression.Validate(sAPPressButtonOnTreeItemsearchColumnTitleIsCaseSensitive, nameof(sAPPressButtonOnTreeItemsearchColumnTitleIsCaseSensitive), required: false);
            SourceExpression.Validate(sAPPressButtonOnTreeItemforce, nameof(sAPPressButtonOnTreeItemforce), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPPressButtonOnTreeItem";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPPressButtonOnTreeItem = new JObject();
                var sAPPressButtonOnTreeItempropCount = 0;
                sAPPressButtonOnTreeItempropCount++;
                sAPPressButtonOnTreeItem["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPPressButtonOnTreeItemsearchSAPElementId);
                if (sAPPressButtonOnTreeItemsearchNodeKey != null)
                {
                    sAPPressButtonOnTreeItem["SearchNodeKey"] = SourceExpressionConverter.ConvertToken(sAPPressButtonOnTreeItemsearchNodeKey);
                    sAPPressButtonOnTreeItempropCount++;
                }

                if (sAPPressButtonOnTreeItemsearchNodePath != null)
                {
                    sAPPressButtonOnTreeItem["SearchNodePath"] = SourceExpressionConverter.ConvertToken(sAPPressButtonOnTreeItemsearchNodePath);
                    sAPPressButtonOnTreeItempropCount++;
                }

                if (sAPPressButtonOnTreeItemsearchNodeText != null)
                {
                    sAPPressButtonOnTreeItem["SearchNodeText"] = SourceExpressionConverter.ConvertToken(sAPPressButtonOnTreeItemsearchNodeText);
                    sAPPressButtonOnTreeItempropCount++;
                }

                if (sAPPressButtonOnTreeItemsearchNodeTextIsRegularExpression != null)
                {
                    if (sAPPressButtonOnTreeItemsearchNodeTextIsRegularExpression != null)
                    {
                        sAPPressButtonOnTreeItem["SearchNodeTextIsRegularExpression"] = SourceExpressionConverter.ConvertToken(sAPPressButtonOnTreeItemsearchNodeTextIsRegularExpression);
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
                        sAPPressButtonOnTreeItem["SearchNodeTextIsCaseSensitive"] = SourceExpressionConverter.ConvertToken(sAPPressButtonOnTreeItemsearchNodeTextIsCaseSensitive);
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
                    sAPPressButtonOnTreeItem["SearchColumnName"] = SourceExpressionConverter.ConvertToken(sAPPressButtonOnTreeItemsearchColumnName);
                    sAPPressButtonOnTreeItempropCount++;
                }

                if (sAPPressButtonOnTreeItemsearchColumnTitle != null)
                {
                    sAPPressButtonOnTreeItem["SearchColumnTitle"] = SourceExpressionConverter.ConvertToken(sAPPressButtonOnTreeItemsearchColumnTitle);
                    sAPPressButtonOnTreeItempropCount++;
                }

                if (sAPPressButtonOnTreeItemsearchColumnTitleIsRegularExpression != null)
                {
                    if (sAPPressButtonOnTreeItemsearchColumnTitleIsRegularExpression != null)
                    {
                        sAPPressButtonOnTreeItem["SearchColumnTitleIsRegularExpression"] = SourceExpressionConverter.ConvertToken(sAPPressButtonOnTreeItemsearchColumnTitleIsRegularExpression);
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
                        sAPPressButtonOnTreeItem["SearchColumnTitleIsCaseSensitive"] = SourceExpressionConverter.ConvertToken(sAPPressButtonOnTreeItemsearchColumnTitleIsCaseSensitive);
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
                        sAPPressButtonOnTreeItem["Force"] = SourceExpressionConverter.ConvertToken(sAPPressButtonOnTreeItemforce);
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
                sAPPressButtonOnTreeItem["Workflow"] = SourceExpressionConverter.ConvertToken(sAPPressButtonOnTreeItemworkflow);
                if (sAPPressButtonOnTreeItempropCount > 0)
                {
                    callPayload.Body = sAPPressButtonOnTreeItem;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPClickLinkOnTreeItem([WorkflowExpression] Func<string> sAPClickLinkOnTreeItemsearchSAPElementId, [WorkflowExpression] Func<string> sAPClickLinkOnTreeItemworkflow, [WorkflowExpression] Func<string> sAPClickLinkOnTreeItemsearchNodeKey = null, [WorkflowExpression] Func<string> sAPClickLinkOnTreeItemsearchNodePath = null, [WorkflowExpression] Func<string> sAPClickLinkOnTreeItemsearchNodeText = null, [WorkflowExpression] Func<bool> sAPClickLinkOnTreeItemsearchNodeTextIsRegularExpression = null, [WorkflowExpression] Func<bool> sAPClickLinkOnTreeItemsearchNodeTextIsCaseSensitive = null, [WorkflowExpression] Func<string> sAPClickLinkOnTreeItemsearchColumnName = null, [WorkflowExpression] Func<string> sAPClickLinkOnTreeItemsearchColumnTitle = null, [WorkflowExpression] Func<bool> sAPClickLinkOnTreeItemsearchColumnTitleIsRegularExpression = null, [WorkflowExpression] Func<bool> sAPClickLinkOnTreeItemsearchColumnTitleIsCaseSensitive = null, [WorkflowExpression] Func<bool> sAPClickLinkOnTreeItemforce = null)
        {
            SourceExpression.Validate(sAPClickLinkOnTreeItemsearchSAPElementId, nameof(sAPClickLinkOnTreeItemsearchSAPElementId), required: true);
            SourceExpression.Validate(sAPClickLinkOnTreeItemworkflow, nameof(sAPClickLinkOnTreeItemworkflow), required: true);
            SourceExpression.Validate(sAPClickLinkOnTreeItemsearchNodeKey, nameof(sAPClickLinkOnTreeItemsearchNodeKey), required: false);
            SourceExpression.Validate(sAPClickLinkOnTreeItemsearchNodePath, nameof(sAPClickLinkOnTreeItemsearchNodePath), required: false);
            SourceExpression.Validate(sAPClickLinkOnTreeItemsearchNodeText, nameof(sAPClickLinkOnTreeItemsearchNodeText), required: false);
            SourceExpression.Validate(sAPClickLinkOnTreeItemsearchNodeTextIsRegularExpression, nameof(sAPClickLinkOnTreeItemsearchNodeTextIsRegularExpression), required: false);
            SourceExpression.Validate(sAPClickLinkOnTreeItemsearchNodeTextIsCaseSensitive, nameof(sAPClickLinkOnTreeItemsearchNodeTextIsCaseSensitive), required: false);
            SourceExpression.Validate(sAPClickLinkOnTreeItemsearchColumnName, nameof(sAPClickLinkOnTreeItemsearchColumnName), required: false);
            SourceExpression.Validate(sAPClickLinkOnTreeItemsearchColumnTitle, nameof(sAPClickLinkOnTreeItemsearchColumnTitle), required: false);
            SourceExpression.Validate(sAPClickLinkOnTreeItemsearchColumnTitleIsRegularExpression, nameof(sAPClickLinkOnTreeItemsearchColumnTitleIsRegularExpression), required: false);
            SourceExpression.Validate(sAPClickLinkOnTreeItemsearchColumnTitleIsCaseSensitive, nameof(sAPClickLinkOnTreeItemsearchColumnTitleIsCaseSensitive), required: false);
            SourceExpression.Validate(sAPClickLinkOnTreeItemforce, nameof(sAPClickLinkOnTreeItemforce), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPClickLinkOnTreeItem";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPClickLinkOnTreeItem = new JObject();
                var sAPClickLinkOnTreeItempropCount = 0;
                sAPClickLinkOnTreeItempropCount++;
                sAPClickLinkOnTreeItem["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPClickLinkOnTreeItemsearchSAPElementId);
                if (sAPClickLinkOnTreeItemsearchNodeKey != null)
                {
                    sAPClickLinkOnTreeItem["SearchNodeKey"] = SourceExpressionConverter.ConvertToken(sAPClickLinkOnTreeItemsearchNodeKey);
                    sAPClickLinkOnTreeItempropCount++;
                }

                if (sAPClickLinkOnTreeItemsearchNodePath != null)
                {
                    sAPClickLinkOnTreeItem["SearchNodePath"] = SourceExpressionConverter.ConvertToken(sAPClickLinkOnTreeItemsearchNodePath);
                    sAPClickLinkOnTreeItempropCount++;
                }

                if (sAPClickLinkOnTreeItemsearchNodeText != null)
                {
                    sAPClickLinkOnTreeItem["SearchNodeText"] = SourceExpressionConverter.ConvertToken(sAPClickLinkOnTreeItemsearchNodeText);
                    sAPClickLinkOnTreeItempropCount++;
                }

                if (sAPClickLinkOnTreeItemsearchNodeTextIsRegularExpression != null)
                {
                    if (sAPClickLinkOnTreeItemsearchNodeTextIsRegularExpression != null)
                    {
                        sAPClickLinkOnTreeItem["SearchNodeTextIsRegularExpression"] = SourceExpressionConverter.ConvertToken(sAPClickLinkOnTreeItemsearchNodeTextIsRegularExpression);
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
                        sAPClickLinkOnTreeItem["SearchNodeTextIsCaseSensitive"] = SourceExpressionConverter.ConvertToken(sAPClickLinkOnTreeItemsearchNodeTextIsCaseSensitive);
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
                    sAPClickLinkOnTreeItem["SearchColumnName"] = SourceExpressionConverter.ConvertToken(sAPClickLinkOnTreeItemsearchColumnName);
                    sAPClickLinkOnTreeItempropCount++;
                }

                if (sAPClickLinkOnTreeItemsearchColumnTitle != null)
                {
                    sAPClickLinkOnTreeItem["SearchColumnTitle"] = SourceExpressionConverter.ConvertToken(sAPClickLinkOnTreeItemsearchColumnTitle);
                    sAPClickLinkOnTreeItempropCount++;
                }

                if (sAPClickLinkOnTreeItemsearchColumnTitleIsRegularExpression != null)
                {
                    if (sAPClickLinkOnTreeItemsearchColumnTitleIsRegularExpression != null)
                    {
                        sAPClickLinkOnTreeItem["SearchColumnTitleIsRegularExpression"] = SourceExpressionConverter.ConvertToken(sAPClickLinkOnTreeItemsearchColumnTitleIsRegularExpression);
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
                        sAPClickLinkOnTreeItem["SearchColumnTitleIsCaseSensitive"] = SourceExpressionConverter.ConvertToken(sAPClickLinkOnTreeItemsearchColumnTitleIsCaseSensitive);
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
                        sAPClickLinkOnTreeItem["Force"] = SourceExpressionConverter.ConvertToken(sAPClickLinkOnTreeItemforce);
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
                sAPClickLinkOnTreeItem["Workflow"] = SourceExpressionConverter.ConvertToken(sAPClickLinkOnTreeItemworkflow);
                if (sAPClickLinkOnTreeItempropCount > 0)
                {
                    callPayload.Body = sAPClickLinkOnTreeItem;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPCheckTreeItem([WorkflowExpression] Func<string> sAPCheckTreeItemsearchSAPElementId, [WorkflowExpression] Func<string> sAPCheckTreeItemworkflow, [WorkflowExpression] Func<string> sAPCheckTreeItemsearchNodeKey = null, [WorkflowExpression] Func<string> sAPCheckTreeItemsearchNodePath = null, [WorkflowExpression] Func<string> sAPCheckTreeItemsearchNodeText = null, [WorkflowExpression] Func<bool> sAPCheckTreeItemsearchNodeTextIsRegularExpression = null, [WorkflowExpression] Func<bool> sAPCheckTreeItemsearchNodeTextIsCaseSensitive = null, [WorkflowExpression] Func<string> sAPCheckTreeItemsearchColumnName = null, [WorkflowExpression] Func<string> sAPCheckTreeItemsearchColumnTitle = null, [WorkflowExpression] Func<bool> sAPCheckTreeItemsearchColumnTitleIsRegularExpression = null, [WorkflowExpression] Func<bool> sAPCheckTreeItemsearchColumnTitleIsCaseSensitive = null, [WorkflowExpression] Func<bool> sAPCheckTreeItemcheckItem = null, [WorkflowExpression] Func<bool> sAPCheckTreeItemforce = null)
        {
            SourceExpression.Validate(sAPCheckTreeItemsearchSAPElementId, nameof(sAPCheckTreeItemsearchSAPElementId), required: true);
            SourceExpression.Validate(sAPCheckTreeItemworkflow, nameof(sAPCheckTreeItemworkflow), required: true);
            SourceExpression.Validate(sAPCheckTreeItemsearchNodeKey, nameof(sAPCheckTreeItemsearchNodeKey), required: false);
            SourceExpression.Validate(sAPCheckTreeItemsearchNodePath, nameof(sAPCheckTreeItemsearchNodePath), required: false);
            SourceExpression.Validate(sAPCheckTreeItemsearchNodeText, nameof(sAPCheckTreeItemsearchNodeText), required: false);
            SourceExpression.Validate(sAPCheckTreeItemsearchNodeTextIsRegularExpression, nameof(sAPCheckTreeItemsearchNodeTextIsRegularExpression), required: false);
            SourceExpression.Validate(sAPCheckTreeItemsearchNodeTextIsCaseSensitive, nameof(sAPCheckTreeItemsearchNodeTextIsCaseSensitive), required: false);
            SourceExpression.Validate(sAPCheckTreeItemsearchColumnName, nameof(sAPCheckTreeItemsearchColumnName), required: false);
            SourceExpression.Validate(sAPCheckTreeItemsearchColumnTitle, nameof(sAPCheckTreeItemsearchColumnTitle), required: false);
            SourceExpression.Validate(sAPCheckTreeItemsearchColumnTitleIsRegularExpression, nameof(sAPCheckTreeItemsearchColumnTitleIsRegularExpression), required: false);
            SourceExpression.Validate(sAPCheckTreeItemsearchColumnTitleIsCaseSensitive, nameof(sAPCheckTreeItemsearchColumnTitleIsCaseSensitive), required: false);
            SourceExpression.Validate(sAPCheckTreeItemcheckItem, nameof(sAPCheckTreeItemcheckItem), required: false);
            SourceExpression.Validate(sAPCheckTreeItemforce, nameof(sAPCheckTreeItemforce), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPCheckTreeItem";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPCheckTreeItem = new JObject();
                var sAPCheckTreeItempropCount = 0;
                sAPCheckTreeItempropCount++;
                sAPCheckTreeItem["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPCheckTreeItemsearchSAPElementId);
                if (sAPCheckTreeItemsearchNodeKey != null)
                {
                    sAPCheckTreeItem["SearchNodeKey"] = SourceExpressionConverter.ConvertToken(sAPCheckTreeItemsearchNodeKey);
                    sAPCheckTreeItempropCount++;
                }

                if (sAPCheckTreeItemsearchNodePath != null)
                {
                    sAPCheckTreeItem["SearchNodePath"] = SourceExpressionConverter.ConvertToken(sAPCheckTreeItemsearchNodePath);
                    sAPCheckTreeItempropCount++;
                }

                if (sAPCheckTreeItemsearchNodeText != null)
                {
                    sAPCheckTreeItem["SearchNodeText"] = SourceExpressionConverter.ConvertToken(sAPCheckTreeItemsearchNodeText);
                    sAPCheckTreeItempropCount++;
                }

                if (sAPCheckTreeItemsearchNodeTextIsRegularExpression != null)
                {
                    if (sAPCheckTreeItemsearchNodeTextIsRegularExpression != null)
                    {
                        sAPCheckTreeItem["SearchNodeTextIsRegularExpression"] = SourceExpressionConverter.ConvertToken(sAPCheckTreeItemsearchNodeTextIsRegularExpression);
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
                        sAPCheckTreeItem["SearchNodeTextIsCaseSensitive"] = SourceExpressionConverter.ConvertToken(sAPCheckTreeItemsearchNodeTextIsCaseSensitive);
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
                    sAPCheckTreeItem["SearchColumnName"] = SourceExpressionConverter.ConvertToken(sAPCheckTreeItemsearchColumnName);
                    sAPCheckTreeItempropCount++;
                }

                if (sAPCheckTreeItemsearchColumnTitle != null)
                {
                    sAPCheckTreeItem["SearchColumnTitle"] = SourceExpressionConverter.ConvertToken(sAPCheckTreeItemsearchColumnTitle);
                    sAPCheckTreeItempropCount++;
                }

                if (sAPCheckTreeItemsearchColumnTitleIsRegularExpression != null)
                {
                    if (sAPCheckTreeItemsearchColumnTitleIsRegularExpression != null)
                    {
                        sAPCheckTreeItem["SearchColumnTitleIsRegularExpression"] = SourceExpressionConverter.ConvertToken(sAPCheckTreeItemsearchColumnTitleIsRegularExpression);
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
                        sAPCheckTreeItem["SearchColumnTitleIsCaseSensitive"] = SourceExpressionConverter.ConvertToken(sAPCheckTreeItemsearchColumnTitleIsCaseSensitive);
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
                        sAPCheckTreeItem["CheckItem"] = SourceExpressionConverter.ConvertToken(sAPCheckTreeItemcheckItem);
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
                        sAPCheckTreeItem["Force"] = SourceExpressionConverter.ConvertToken(sAPCheckTreeItemforce);
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
                sAPCheckTreeItem["Workflow"] = SourceExpressionConverter.ConvertToken(sAPCheckTreeItemworkflow);
                if (sAPCheckTreeItempropCount > 0)
                {
                    callPayload.Body = sAPCheckTreeItem;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetTreeColumnHeadersResponse> SAPGetTreeColumnHeaders([WorkflowExpression] Func<string> sAPGetTreeColumnHeaderssearchSAPElementId, [WorkflowExpression] Func<string> sAPGetTreeColumnHeadersworkflow)
        {
            SourceExpression.Validate(sAPGetTreeColumnHeaderssearchSAPElementId, nameof(sAPGetTreeColumnHeaderssearchSAPElementId), required: true);
            SourceExpression.Validate(sAPGetTreeColumnHeadersworkflow, nameof(sAPGetTreeColumnHeadersworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPGetTreeColumnHeaders";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGetTreeColumnHeaders = new JObject();
                var sAPGetTreeColumnHeaderspropCount = 0;
                sAPGetTreeColumnHeaderspropCount++;
                sAPGetTreeColumnHeaders["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPGetTreeColumnHeaderssearchSAPElementId);
                sAPGetTreeColumnHeaderspropCount++;
                sAPGetTreeColumnHeaders["Workflow"] = SourceExpressionConverter.ConvertToken(sAPGetTreeColumnHeadersworkflow);
                if (sAPGetTreeColumnHeaderspropCount > 0)
                {
                    callPayload.Body = sAPGetTreeColumnHeaders;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SAPGetTreeColumnHeadersResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetTreeItemPropertiesResponse> SAPGetTreeItemProperties([WorkflowExpression] Func<string> sAPGetTreeItemPropertiessearchSAPElementId, [WorkflowExpression] Func<string> sAPGetTreeItemPropertiesworkflow, [WorkflowExpression] Func<string> sAPGetTreeItemPropertiessearchNodeKey = null, [WorkflowExpression] Func<string> sAPGetTreeItemPropertiessearchNodePath = null, [WorkflowExpression] Func<string> sAPGetTreeItemPropertiessearchNodeText = null, [WorkflowExpression] Func<bool> sAPGetTreeItemPropertiessearchNodeTextIsRegularExpression = null, [WorkflowExpression] Func<bool> sAPGetTreeItemPropertiessearchNodeTextIsCaseSensitive = null, [WorkflowExpression] Func<string> sAPGetTreeItemPropertiessearchColumnName = null, [WorkflowExpression] Func<string> sAPGetTreeItemPropertiessearchColumnTitle = null, [WorkflowExpression] Func<bool> sAPGetTreeItemPropertiessearchColumnTitleIsRegularExpression = null, [WorkflowExpression] Func<bool> sAPGetTreeItemPropertiessearchColumnTitleIsCaseSensitive = null)
        {
            SourceExpression.Validate(sAPGetTreeItemPropertiessearchSAPElementId, nameof(sAPGetTreeItemPropertiessearchSAPElementId), required: true);
            SourceExpression.Validate(sAPGetTreeItemPropertiesworkflow, nameof(sAPGetTreeItemPropertiesworkflow), required: true);
            SourceExpression.Validate(sAPGetTreeItemPropertiessearchNodeKey, nameof(sAPGetTreeItemPropertiessearchNodeKey), required: false);
            SourceExpression.Validate(sAPGetTreeItemPropertiessearchNodePath, nameof(sAPGetTreeItemPropertiessearchNodePath), required: false);
            SourceExpression.Validate(sAPGetTreeItemPropertiessearchNodeText, nameof(sAPGetTreeItemPropertiessearchNodeText), required: false);
            SourceExpression.Validate(sAPGetTreeItemPropertiessearchNodeTextIsRegularExpression, nameof(sAPGetTreeItemPropertiessearchNodeTextIsRegularExpression), required: false);
            SourceExpression.Validate(sAPGetTreeItemPropertiessearchNodeTextIsCaseSensitive, nameof(sAPGetTreeItemPropertiessearchNodeTextIsCaseSensitive), required: false);
            SourceExpression.Validate(sAPGetTreeItemPropertiessearchColumnName, nameof(sAPGetTreeItemPropertiessearchColumnName), required: false);
            SourceExpression.Validate(sAPGetTreeItemPropertiessearchColumnTitle, nameof(sAPGetTreeItemPropertiessearchColumnTitle), required: false);
            SourceExpression.Validate(sAPGetTreeItemPropertiessearchColumnTitleIsRegularExpression, nameof(sAPGetTreeItemPropertiessearchColumnTitleIsRegularExpression), required: false);
            SourceExpression.Validate(sAPGetTreeItemPropertiessearchColumnTitleIsCaseSensitive, nameof(sAPGetTreeItemPropertiessearchColumnTitleIsCaseSensitive), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPGetTreeItemProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGetTreeItemProperties = new JObject();
                var sAPGetTreeItemPropertiespropCount = 0;
                sAPGetTreeItemPropertiespropCount++;
                sAPGetTreeItemProperties["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPGetTreeItemPropertiessearchSAPElementId);
                if (sAPGetTreeItemPropertiessearchNodeKey != null)
                {
                    sAPGetTreeItemProperties["SearchNodeKey"] = SourceExpressionConverter.ConvertToken(sAPGetTreeItemPropertiessearchNodeKey);
                    sAPGetTreeItemPropertiespropCount++;
                }

                if (sAPGetTreeItemPropertiessearchNodePath != null)
                {
                    sAPGetTreeItemProperties["SearchNodePath"] = SourceExpressionConverter.ConvertToken(sAPGetTreeItemPropertiessearchNodePath);
                    sAPGetTreeItemPropertiespropCount++;
                }

                if (sAPGetTreeItemPropertiessearchNodeText != null)
                {
                    sAPGetTreeItemProperties["SearchNodeText"] = SourceExpressionConverter.ConvertToken(sAPGetTreeItemPropertiessearchNodeText);
                    sAPGetTreeItemPropertiespropCount++;
                }

                if (sAPGetTreeItemPropertiessearchNodeTextIsRegularExpression != null)
                {
                    if (sAPGetTreeItemPropertiessearchNodeTextIsRegularExpression != null)
                    {
                        sAPGetTreeItemProperties["SearchNodeTextIsRegularExpression"] = SourceExpressionConverter.ConvertToken(sAPGetTreeItemPropertiessearchNodeTextIsRegularExpression);
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
                        sAPGetTreeItemProperties["SearchNodeTextIsCaseSensitive"] = SourceExpressionConverter.ConvertToken(sAPGetTreeItemPropertiessearchNodeTextIsCaseSensitive);
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
                    sAPGetTreeItemProperties["SearchColumnName"] = SourceExpressionConverter.ConvertToken(sAPGetTreeItemPropertiessearchColumnName);
                    sAPGetTreeItemPropertiespropCount++;
                }

                if (sAPGetTreeItemPropertiessearchColumnTitle != null)
                {
                    sAPGetTreeItemProperties["SearchColumnTitle"] = SourceExpressionConverter.ConvertToken(sAPGetTreeItemPropertiessearchColumnTitle);
                    sAPGetTreeItemPropertiespropCount++;
                }

                if (sAPGetTreeItemPropertiessearchColumnTitleIsRegularExpression != null)
                {
                    if (sAPGetTreeItemPropertiessearchColumnTitleIsRegularExpression != null)
                    {
                        sAPGetTreeItemProperties["SearchColumnTitleIsRegularExpression"] = SourceExpressionConverter.ConvertToken(sAPGetTreeItemPropertiessearchColumnTitleIsRegularExpression);
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
                        sAPGetTreeItemProperties["SearchColumnTitleIsCaseSensitive"] = SourceExpressionConverter.ConvertToken(sAPGetTreeItemPropertiessearchColumnTitleIsCaseSensitive);
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
                sAPGetTreeItemProperties["Workflow"] = SourceExpressionConverter.ConvertToken(sAPGetTreeItemPropertiesworkflow);
                if (sAPGetTreeItemPropertiespropCount > 0)
                {
                    callPayload.Body = sAPGetTreeItemProperties;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SAPGetTreeItemPropertiesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetShellToolbarElementsResponse> SAPGetShellToolbarElements([WorkflowExpression] Func<string> sAPGetShellToolbarElementssearchSAPElementId, [WorkflowExpression] Func<string> sAPGetShellToolbarElementsworkflow)
        {
            SourceExpression.Validate(sAPGetShellToolbarElementssearchSAPElementId, nameof(sAPGetShellToolbarElementssearchSAPElementId), required: true);
            SourceExpression.Validate(sAPGetShellToolbarElementsworkflow, nameof(sAPGetShellToolbarElementsworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPGetShellToolbarElements";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGetShellToolbarElements = new JObject();
                var sAPGetShellToolbarElementspropCount = 0;
                sAPGetShellToolbarElementspropCount++;
                sAPGetShellToolbarElements["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPGetShellToolbarElementssearchSAPElementId);
                sAPGetShellToolbarElementspropCount++;
                sAPGetShellToolbarElements["Workflow"] = SourceExpressionConverter.ConvertToken(sAPGetShellToolbarElementsworkflow);
                if (sAPGetShellToolbarElementspropCount > 0)
                {
                    callPayload.Body = sAPGetShellToolbarElements;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SAPGetShellToolbarElementsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPPressShellToolbarElement([WorkflowExpression] Func<string> sAPPressShellToolbarElementsearchSAPElementId, [WorkflowExpression] Func<string> sAPPressShellToolbarElementworkflow, [WorkflowExpression] Func<string> sAPPressShellToolbarElementsearchToolbarElementId = null, [WorkflowExpression] Func<string> sAPPressShellToolbarElementsearchToolbarElementText = null, [WorkflowExpression] Func<int> sAPPressShellToolbarElementsearchToolbarElementIndex = null, [WorkflowExpression] Func<bool> sAPPressShellToolbarElementsearchToolbarTextIsRegularExpression = null, [WorkflowExpression] Func<bool> sAPPressShellToolbarElementsearchToolbarTextIsCaseSensitive = null)
        {
            SourceExpression.Validate(sAPPressShellToolbarElementsearchSAPElementId, nameof(sAPPressShellToolbarElementsearchSAPElementId), required: true);
            SourceExpression.Validate(sAPPressShellToolbarElementworkflow, nameof(sAPPressShellToolbarElementworkflow), required: true);
            SourceExpression.Validate(sAPPressShellToolbarElementsearchToolbarElementId, nameof(sAPPressShellToolbarElementsearchToolbarElementId), required: false);
            SourceExpression.Validate(sAPPressShellToolbarElementsearchToolbarElementText, nameof(sAPPressShellToolbarElementsearchToolbarElementText), required: false);
            SourceExpression.Validate(sAPPressShellToolbarElementsearchToolbarElementIndex, nameof(sAPPressShellToolbarElementsearchToolbarElementIndex), required: false);
            SourceExpression.Validate(sAPPressShellToolbarElementsearchToolbarTextIsRegularExpression, nameof(sAPPressShellToolbarElementsearchToolbarTextIsRegularExpression), required: false);
            SourceExpression.Validate(sAPPressShellToolbarElementsearchToolbarTextIsCaseSensitive, nameof(sAPPressShellToolbarElementsearchToolbarTextIsCaseSensitive), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPPressShellToolbarElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPPressShellToolbarElement = new JObject();
                var sAPPressShellToolbarElementpropCount = 0;
                sAPPressShellToolbarElementpropCount++;
                sAPPressShellToolbarElement["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPPressShellToolbarElementsearchSAPElementId);
                if (sAPPressShellToolbarElementsearchToolbarElementId != null)
                {
                    sAPPressShellToolbarElement["SearchToolbarElementId"] = SourceExpressionConverter.ConvertToken(sAPPressShellToolbarElementsearchToolbarElementId);
                    sAPPressShellToolbarElementpropCount++;
                }

                if (sAPPressShellToolbarElementsearchToolbarElementText != null)
                {
                    sAPPressShellToolbarElement["SearchToolbarElementText"] = SourceExpressionConverter.ConvertToken(sAPPressShellToolbarElementsearchToolbarElementText);
                    sAPPressShellToolbarElementpropCount++;
                }

                if (sAPPressShellToolbarElementsearchToolbarElementIndex != null)
                {
                    if (sAPPressShellToolbarElementsearchToolbarElementIndex != null)
                    {
                        sAPPressShellToolbarElement["SearchToolbarElementIndex"] = SourceExpressionConverter.ConvertToken(sAPPressShellToolbarElementsearchToolbarElementIndex);
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
                        sAPPressShellToolbarElement["SearchToolbarTextIsRegularExpression"] = SourceExpressionConverter.ConvertToken(sAPPressShellToolbarElementsearchToolbarTextIsRegularExpression);
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
                        sAPPressShellToolbarElement["SearchToolbarTextIsCaseSensitive"] = SourceExpressionConverter.ConvertToken(sAPPressShellToolbarElementsearchToolbarTextIsCaseSensitive);
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
                sAPPressShellToolbarElement["Workflow"] = SourceExpressionConverter.ConvertToken(sAPPressShellToolbarElementworkflow);
                if (sAPPressShellToolbarElementpropCount > 0)
                {
                    callPayload.Body = sAPPressShellToolbarElement;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPPressShellToolbarElementContextButton([WorkflowExpression] Func<string> sAPPressShellToolbarElementContextButtonsearchSAPElementId, [WorkflowExpression] Func<string> sAPPressShellToolbarElementContextButtonworkflow, [WorkflowExpression] Func<string> sAPPressShellToolbarElementContextButtonsearchToolbarElementId = null, [WorkflowExpression] Func<string> sAPPressShellToolbarElementContextButtonsearchToolbarElementText = null, [WorkflowExpression] Func<int> sAPPressShellToolbarElementContextButtonsearchToolbarElementIndex = null, [WorkflowExpression] Func<bool> sAPPressShellToolbarElementContextButtonsearchToolbarTextIsRegularExpression = null, [WorkflowExpression] Func<bool> sAPPressShellToolbarElementContextButtonsearchToolbarTextIsCaseSensitive = null)
        {
            SourceExpression.Validate(sAPPressShellToolbarElementContextButtonsearchSAPElementId, nameof(sAPPressShellToolbarElementContextButtonsearchSAPElementId), required: true);
            SourceExpression.Validate(sAPPressShellToolbarElementContextButtonworkflow, nameof(sAPPressShellToolbarElementContextButtonworkflow), required: true);
            SourceExpression.Validate(sAPPressShellToolbarElementContextButtonsearchToolbarElementId, nameof(sAPPressShellToolbarElementContextButtonsearchToolbarElementId), required: false);
            SourceExpression.Validate(sAPPressShellToolbarElementContextButtonsearchToolbarElementText, nameof(sAPPressShellToolbarElementContextButtonsearchToolbarElementText), required: false);
            SourceExpression.Validate(sAPPressShellToolbarElementContextButtonsearchToolbarElementIndex, nameof(sAPPressShellToolbarElementContextButtonsearchToolbarElementIndex), required: false);
            SourceExpression.Validate(sAPPressShellToolbarElementContextButtonsearchToolbarTextIsRegularExpression, nameof(sAPPressShellToolbarElementContextButtonsearchToolbarTextIsRegularExpression), required: false);
            SourceExpression.Validate(sAPPressShellToolbarElementContextButtonsearchToolbarTextIsCaseSensitive, nameof(sAPPressShellToolbarElementContextButtonsearchToolbarTextIsCaseSensitive), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPPressShellToolbarElementContextButton";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPPressShellToolbarElementContextButton = new JObject();
                var sAPPressShellToolbarElementContextButtonpropCount = 0;
                sAPPressShellToolbarElementContextButtonpropCount++;
                sAPPressShellToolbarElementContextButton["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPPressShellToolbarElementContextButtonsearchSAPElementId);
                if (sAPPressShellToolbarElementContextButtonsearchToolbarElementId != null)
                {
                    sAPPressShellToolbarElementContextButton["SearchToolbarElementId"] = SourceExpressionConverter.ConvertToken(sAPPressShellToolbarElementContextButtonsearchToolbarElementId);
                    sAPPressShellToolbarElementContextButtonpropCount++;
                }

                if (sAPPressShellToolbarElementContextButtonsearchToolbarElementText != null)
                {
                    sAPPressShellToolbarElementContextButton["SearchToolbarElementText"] = SourceExpressionConverter.ConvertToken(sAPPressShellToolbarElementContextButtonsearchToolbarElementText);
                    sAPPressShellToolbarElementContextButtonpropCount++;
                }

                if (sAPPressShellToolbarElementContextButtonsearchToolbarElementIndex != null)
                {
                    if (sAPPressShellToolbarElementContextButtonsearchToolbarElementIndex != null)
                    {
                        sAPPressShellToolbarElementContextButton["SearchToolbarElementIndex"] = SourceExpressionConverter.ConvertToken(sAPPressShellToolbarElementContextButtonsearchToolbarElementIndex);
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
                        sAPPressShellToolbarElementContextButton["SearchToolbarTextIsRegularExpression"] = SourceExpressionConverter.ConvertToken(sAPPressShellToolbarElementContextButtonsearchToolbarTextIsRegularExpression);
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
                        sAPPressShellToolbarElementContextButton["SearchToolbarTextIsCaseSensitive"] = SourceExpressionConverter.ConvertToken(sAPPressShellToolbarElementContextButtonsearchToolbarTextIsCaseSensitive);
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
                sAPPressShellToolbarElementContextButton["Workflow"] = SourceExpressionConverter.ConvertToken(sAPPressShellToolbarElementContextButtonworkflow);
                if (sAPPressShellToolbarElementContextButtonpropCount > 0)
                {
                    callPayload.Body = sAPPressShellToolbarElementContextButton;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPSelectShellToolbarMenuItem([WorkflowExpression] Func<string> sAPSelectShellToolbarMenuItemsearchSAPElementId, [WorkflowExpression] Func<string> sAPSelectShellToolbarMenuItemworkflow, [WorkflowExpression] Func<string> sAPSelectShellToolbarMenuItemsearchToolbarElementId = null, [WorkflowExpression] Func<string> sAPSelectShellToolbarMenuItemsearchToolbarElementText = null, [WorkflowExpression] Func<int> sAPSelectShellToolbarMenuItemsearchToolbarElementIndex = null, [WorkflowExpression] Func<bool> sAPSelectShellToolbarMenuItemsearchToolbarTextIsRegularExpression = null, [WorkflowExpression] Func<bool> sAPSelectShellToolbarMenuItemsearchToolbarTextIsCaseSensitive = null)
        {
            SourceExpression.Validate(sAPSelectShellToolbarMenuItemsearchSAPElementId, nameof(sAPSelectShellToolbarMenuItemsearchSAPElementId), required: true);
            SourceExpression.Validate(sAPSelectShellToolbarMenuItemworkflow, nameof(sAPSelectShellToolbarMenuItemworkflow), required: true);
            SourceExpression.Validate(sAPSelectShellToolbarMenuItemsearchToolbarElementId, nameof(sAPSelectShellToolbarMenuItemsearchToolbarElementId), required: false);
            SourceExpression.Validate(sAPSelectShellToolbarMenuItemsearchToolbarElementText, nameof(sAPSelectShellToolbarMenuItemsearchToolbarElementText), required: false);
            SourceExpression.Validate(sAPSelectShellToolbarMenuItemsearchToolbarElementIndex, nameof(sAPSelectShellToolbarMenuItemsearchToolbarElementIndex), required: false);
            SourceExpression.Validate(sAPSelectShellToolbarMenuItemsearchToolbarTextIsRegularExpression, nameof(sAPSelectShellToolbarMenuItemsearchToolbarTextIsRegularExpression), required: false);
            SourceExpression.Validate(sAPSelectShellToolbarMenuItemsearchToolbarTextIsCaseSensitive, nameof(sAPSelectShellToolbarMenuItemsearchToolbarTextIsCaseSensitive), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPSelectShellToolbarMenuItem";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPSelectShellToolbarMenuItem = new JObject();
                var sAPSelectShellToolbarMenuItempropCount = 0;
                sAPSelectShellToolbarMenuItempropCount++;
                sAPSelectShellToolbarMenuItem["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPSelectShellToolbarMenuItemsearchSAPElementId);
                if (sAPSelectShellToolbarMenuItemsearchToolbarElementId != null)
                {
                    sAPSelectShellToolbarMenuItem["SearchToolbarElementId"] = SourceExpressionConverter.ConvertToken(sAPSelectShellToolbarMenuItemsearchToolbarElementId);
                    sAPSelectShellToolbarMenuItempropCount++;
                }

                if (sAPSelectShellToolbarMenuItemsearchToolbarElementText != null)
                {
                    sAPSelectShellToolbarMenuItem["SearchToolbarElementText"] = SourceExpressionConverter.ConvertToken(sAPSelectShellToolbarMenuItemsearchToolbarElementText);
                    sAPSelectShellToolbarMenuItempropCount++;
                }

                if (sAPSelectShellToolbarMenuItemsearchToolbarElementIndex != null)
                {
                    if (sAPSelectShellToolbarMenuItemsearchToolbarElementIndex != null)
                    {
                        sAPSelectShellToolbarMenuItem["SearchToolbarElementIndex"] = SourceExpressionConverter.ConvertToken(sAPSelectShellToolbarMenuItemsearchToolbarElementIndex);
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
                        sAPSelectShellToolbarMenuItem["SearchToolbarTextIsRegularExpression"] = SourceExpressionConverter.ConvertToken(sAPSelectShellToolbarMenuItemsearchToolbarTextIsRegularExpression);
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
                        sAPSelectShellToolbarMenuItem["SearchToolbarTextIsCaseSensitive"] = SourceExpressionConverter.ConvertToken(sAPSelectShellToolbarMenuItemsearchToolbarTextIsCaseSensitive);
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
                sAPSelectShellToolbarMenuItem["Workflow"] = SourceExpressionConverter.ConvertToken(sAPSelectShellToolbarMenuItemworkflow);
                if (sAPSelectShellToolbarMenuItempropCount > 0)
                {
                    callPayload.Body = sAPSelectShellToolbarMenuItem;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetSAPGridViewPropertiesResponse> SAPGetSAPGridViewProperties([WorkflowExpression] Func<string> sAPGetSAPGridViewPropertiessearchSAPElementId, [WorkflowExpression] Func<string> sAPGetSAPGridViewPropertiesworkflow)
        {
            SourceExpression.Validate(sAPGetSAPGridViewPropertiessearchSAPElementId, nameof(sAPGetSAPGridViewPropertiessearchSAPElementId), required: true);
            SourceExpression.Validate(sAPGetSAPGridViewPropertiesworkflow, nameof(sAPGetSAPGridViewPropertiesworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPGetSAPGridViewProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGetSAPGridViewProperties = new JObject();
                var sAPGetSAPGridViewPropertiespropCount = 0;
                sAPGetSAPGridViewPropertiespropCount++;
                sAPGetSAPGridViewProperties["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPGetSAPGridViewPropertiessearchSAPElementId);
                sAPGetSAPGridViewPropertiespropCount++;
                sAPGetSAPGridViewProperties["Workflow"] = SourceExpressionConverter.ConvertToken(sAPGetSAPGridViewPropertiesworkflow);
                if (sAPGetSAPGridViewPropertiespropCount > 0)
                {
                    callPayload.Body = sAPGetSAPGridViewProperties;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SAPGetSAPGridViewPropertiesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetSAPGridViewCellContentsAtIndexResponse> SAPGetSAPGridViewCellContentsAtIndex([WorkflowExpression] Func<string> sAPGetSAPGridViewCellContentsAtIndexsearchSAPElementId, [WorkflowExpression] Func<int> sAPGetSAPGridViewCellContentsAtIndexrowIndex, [WorkflowExpression] Func<string> sAPGetSAPGridViewCellContentsAtIndexworkflow, [WorkflowExpression] Func<string> sAPGetSAPGridViewCellContentsAtIndexsearchColumnName = null, [WorkflowExpression] Func<string> sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitle = null, [WorkflowExpression] Func<bool> sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitleIsRegularExpression = null, [WorkflowExpression] Func<bool> sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitleIsCaseSensitive = null)
        {
            SourceExpression.Validate(sAPGetSAPGridViewCellContentsAtIndexsearchSAPElementId, nameof(sAPGetSAPGridViewCellContentsAtIndexsearchSAPElementId), required: true);
            SourceExpression.Validate(sAPGetSAPGridViewCellContentsAtIndexrowIndex, nameof(sAPGetSAPGridViewCellContentsAtIndexrowIndex), required: true);
            SourceExpression.Validate(sAPGetSAPGridViewCellContentsAtIndexworkflow, nameof(sAPGetSAPGridViewCellContentsAtIndexworkflow), required: true);
            SourceExpression.Validate(sAPGetSAPGridViewCellContentsAtIndexsearchColumnName, nameof(sAPGetSAPGridViewCellContentsAtIndexsearchColumnName), required: false);
            SourceExpression.Validate(sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitle, nameof(sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitle), required: false);
            SourceExpression.Validate(sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitleIsRegularExpression, nameof(sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitleIsRegularExpression), required: false);
            SourceExpression.Validate(sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitleIsCaseSensitive, nameof(sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitleIsCaseSensitive), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPGetSAPGridViewCellContentsAtIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGetSAPGridViewCellContentsAtIndex = new JObject();
                var sAPGetSAPGridViewCellContentsAtIndexpropCount = 0;
                sAPGetSAPGridViewCellContentsAtIndexpropCount++;
                sAPGetSAPGridViewCellContentsAtIndex["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPGetSAPGridViewCellContentsAtIndexsearchSAPElementId);
                sAPGetSAPGridViewCellContentsAtIndexpropCount++;
                sAPGetSAPGridViewCellContentsAtIndex["RowIndex"] = SourceExpressionConverter.ConvertToken(sAPGetSAPGridViewCellContentsAtIndexrowIndex);
                if (sAPGetSAPGridViewCellContentsAtIndexsearchColumnName != null)
                {
                    sAPGetSAPGridViewCellContentsAtIndex["SearchColumnName"] = SourceExpressionConverter.ConvertToken(sAPGetSAPGridViewCellContentsAtIndexsearchColumnName);
                    sAPGetSAPGridViewCellContentsAtIndexpropCount++;
                }

                if (sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitle != null)
                {
                    sAPGetSAPGridViewCellContentsAtIndex["SearchColumnTitle"] = SourceExpressionConverter.ConvertToken(sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitle);
                    sAPGetSAPGridViewCellContentsAtIndexpropCount++;
                }

                if (sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitleIsRegularExpression != null)
                {
                    if (sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitleIsRegularExpression != null)
                    {
                        sAPGetSAPGridViewCellContentsAtIndex["SearchColumnTitleIsRegularExpression"] = SourceExpressionConverter.ConvertToken(sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitleIsRegularExpression);
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
                        sAPGetSAPGridViewCellContentsAtIndex["SearchColumnTitleIsCaseSensitive"] = SourceExpressionConverter.ConvertToken(sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitleIsCaseSensitive);
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
                sAPGetSAPGridViewCellContentsAtIndex["Workflow"] = SourceExpressionConverter.ConvertToken(sAPGetSAPGridViewCellContentsAtIndexworkflow);
                if (sAPGetSAPGridViewCellContentsAtIndexpropCount > 0)
                {
                    callPayload.Body = sAPGetSAPGridViewCellContentsAtIndex;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SAPGetSAPGridViewCellContentsAtIndexResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetSAPGridViewCellPropertiesAtIndexResponse> SAPGetSAPGridViewCellPropertiesAtIndex([WorkflowExpression] Func<string> sAPGetSAPGridViewCellPropertiesAtIndexsearchSAPElementId, [WorkflowExpression] Func<int> sAPGetSAPGridViewCellPropertiesAtIndexrowIndex, [WorkflowExpression] Func<string> sAPGetSAPGridViewCellPropertiesAtIndexworkflow, [WorkflowExpression] Func<string> sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnName = null, [WorkflowExpression] Func<string> sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitle = null, [WorkflowExpression] Func<bool> sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitleIsRegularExpression = null, [WorkflowExpression] Func<bool> sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitleIsCaseSensitive = null)
        {
            SourceExpression.Validate(sAPGetSAPGridViewCellPropertiesAtIndexsearchSAPElementId, nameof(sAPGetSAPGridViewCellPropertiesAtIndexsearchSAPElementId), required: true);
            SourceExpression.Validate(sAPGetSAPGridViewCellPropertiesAtIndexrowIndex, nameof(sAPGetSAPGridViewCellPropertiesAtIndexrowIndex), required: true);
            SourceExpression.Validate(sAPGetSAPGridViewCellPropertiesAtIndexworkflow, nameof(sAPGetSAPGridViewCellPropertiesAtIndexworkflow), required: true);
            SourceExpression.Validate(sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnName, nameof(sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnName), required: false);
            SourceExpression.Validate(sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitle, nameof(sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitle), required: false);
            SourceExpression.Validate(sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitleIsRegularExpression, nameof(sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitleIsRegularExpression), required: false);
            SourceExpression.Validate(sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitleIsCaseSensitive, nameof(sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitleIsCaseSensitive), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPGetSAPGridViewCellPropertiesAtIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGetSAPGridViewCellPropertiesAtIndex = new JObject();
                var sAPGetSAPGridViewCellPropertiesAtIndexpropCount = 0;
                sAPGetSAPGridViewCellPropertiesAtIndexpropCount++;
                sAPGetSAPGridViewCellPropertiesAtIndex["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPGetSAPGridViewCellPropertiesAtIndexsearchSAPElementId);
                sAPGetSAPGridViewCellPropertiesAtIndexpropCount++;
                sAPGetSAPGridViewCellPropertiesAtIndex["RowIndex"] = SourceExpressionConverter.ConvertToken(sAPGetSAPGridViewCellPropertiesAtIndexrowIndex);
                if (sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnName != null)
                {
                    sAPGetSAPGridViewCellPropertiesAtIndex["SearchColumnName"] = SourceExpressionConverter.ConvertToken(sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnName);
                    sAPGetSAPGridViewCellPropertiesAtIndexpropCount++;
                }

                if (sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitle != null)
                {
                    sAPGetSAPGridViewCellPropertiesAtIndex["SearchColumnTitle"] = SourceExpressionConverter.ConvertToken(sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitle);
                    sAPGetSAPGridViewCellPropertiesAtIndexpropCount++;
                }

                if (sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitleIsRegularExpression != null)
                {
                    if (sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitleIsRegularExpression != null)
                    {
                        sAPGetSAPGridViewCellPropertiesAtIndex["SearchColumnTitleIsRegularExpression"] = SourceExpressionConverter.ConvertToken(sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitleIsRegularExpression);
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
                        sAPGetSAPGridViewCellPropertiesAtIndex["SearchColumnTitleIsCaseSensitive"] = SourceExpressionConverter.ConvertToken(sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitleIsCaseSensitive);
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
                sAPGetSAPGridViewCellPropertiesAtIndex["Workflow"] = SourceExpressionConverter.ConvertToken(sAPGetSAPGridViewCellPropertiesAtIndexworkflow);
                if (sAPGetSAPGridViewCellPropertiesAtIndexpropCount > 0)
                {
                    callPayload.Body = sAPGetSAPGridViewCellPropertiesAtIndex;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SAPGetSAPGridViewCellPropertiesAtIndexResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPDrawRectangleAroundSAPGridViewCellAtIndex([WorkflowExpression] Func<string> sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchSAPElementId, [WorkflowExpression] Func<int> sAPDrawRectangleAroundSAPGridViewCellAtIndexrowIndex, [WorkflowExpression] Func<string> sAPDrawRectangleAroundSAPGridViewCellAtIndexworkflow, [WorkflowExpression] Func<string> sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnName = null, [WorkflowExpression] Func<string> sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitle = null, [WorkflowExpression] Func<bool> sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression = null, [WorkflowExpression] Func<bool> sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive = null, [WorkflowExpression] Func<string> sAPDrawRectangleAroundSAPGridViewCellAtIndexpenColour = null, [WorkflowExpression] Func<int> sAPDrawRectangleAroundSAPGridViewCellAtIndexpenThicknessPixels = null)
        {
            SourceExpression.Validate(sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchSAPElementId, nameof(sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchSAPElementId), required: true);
            SourceExpression.Validate(sAPDrawRectangleAroundSAPGridViewCellAtIndexrowIndex, nameof(sAPDrawRectangleAroundSAPGridViewCellAtIndexrowIndex), required: true);
            SourceExpression.Validate(sAPDrawRectangleAroundSAPGridViewCellAtIndexworkflow, nameof(sAPDrawRectangleAroundSAPGridViewCellAtIndexworkflow), required: true);
            SourceExpression.Validate(sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnName, nameof(sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnName), required: false);
            SourceExpression.Validate(sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitle, nameof(sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitle), required: false);
            SourceExpression.Validate(sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression, nameof(sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression), required: false);
            SourceExpression.Validate(sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive, nameof(sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive), required: false);
            SourceExpression.Validate(sAPDrawRectangleAroundSAPGridViewCellAtIndexpenColour, nameof(sAPDrawRectangleAroundSAPGridViewCellAtIndexpenColour), required: false);
            SourceExpression.Validate(sAPDrawRectangleAroundSAPGridViewCellAtIndexpenThicknessPixels, nameof(sAPDrawRectangleAroundSAPGridViewCellAtIndexpenThicknessPixels), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPDrawRectangleAroundSAPGridViewCellAtIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPDrawRectangleAroundSAPGridViewCellAtIndex = new JObject();
                var sAPDrawRectangleAroundSAPGridViewCellAtIndexpropCount = 0;
                sAPDrawRectangleAroundSAPGridViewCellAtIndexpropCount++;
                sAPDrawRectangleAroundSAPGridViewCellAtIndex["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchSAPElementId);
                sAPDrawRectangleAroundSAPGridViewCellAtIndexpropCount++;
                sAPDrawRectangleAroundSAPGridViewCellAtIndex["RowIndex"] = SourceExpressionConverter.ConvertToken(sAPDrawRectangleAroundSAPGridViewCellAtIndexrowIndex);
                if (sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnName != null)
                {
                    sAPDrawRectangleAroundSAPGridViewCellAtIndex["SearchColumnName"] = SourceExpressionConverter.ConvertToken(sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnName);
                    sAPDrawRectangleAroundSAPGridViewCellAtIndexpropCount++;
                }

                if (sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitle != null)
                {
                    sAPDrawRectangleAroundSAPGridViewCellAtIndex["SearchColumnTitle"] = SourceExpressionConverter.ConvertToken(sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitle);
                    sAPDrawRectangleAroundSAPGridViewCellAtIndexpropCount++;
                }

                if (sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression != null)
                {
                    if (sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression != null)
                    {
                        sAPDrawRectangleAroundSAPGridViewCellAtIndex["SearchColumnTitleIsRegularExpression"] = SourceExpressionConverter.ConvertToken(sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression);
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
                        sAPDrawRectangleAroundSAPGridViewCellAtIndex["SearchColumnTitleIsCaseSensitive"] = SourceExpressionConverter.ConvertToken(sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive);
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
                        sAPDrawRectangleAroundSAPGridViewCellAtIndex["PenColour"] = SourceExpressionConverter.ConvertToken(sAPDrawRectangleAroundSAPGridViewCellAtIndexpenColour);
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
                        sAPDrawRectangleAroundSAPGridViewCellAtIndex["PenThicknessPixels"] = SourceExpressionConverter.ConvertToken(sAPDrawRectangleAroundSAPGridViewCellAtIndexpenThicknessPixels);
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
                sAPDrawRectangleAroundSAPGridViewCellAtIndex["Workflow"] = SourceExpressionConverter.ConvertToken(sAPDrawRectangleAroundSAPGridViewCellAtIndexworkflow);
                if (sAPDrawRectangleAroundSAPGridViewCellAtIndexpropCount > 0)
                {
                    callPayload.Body = sAPDrawRectangleAroundSAPGridViewCellAtIndex;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPGlobalLeftClickSAPGridViewCellAtIndex([WorkflowExpression] Func<string> sAPGlobalLeftClickSAPGridViewCellAtIndexsearchSAPElementId, [WorkflowExpression] Func<int> sAPGlobalLeftClickSAPGridViewCellAtIndexrowIndex, [WorkflowExpression] Func<string> sAPGlobalLeftClickSAPGridViewCellAtIndexworkflow, [WorkflowExpression] Func<string> sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnName = null, [WorkflowExpression] Func<string> sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitle = null, [WorkflowExpression] Func<bool> sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression = null, [WorkflowExpression] Func<bool> sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive = null, [WorkflowExpression] Func<bool> sAPGlobalLeftClickSAPGridViewCellAtIndexsetElementWindowTopMost = null, [WorkflowExpression] Func<bool> sAPGlobalLeftClickSAPGridViewCellAtIndexbringElementWindowToFront = null, [WorkflowExpression] Func<bool> sAPGlobalLeftClickSAPGridViewCellAtIndextoggleWindow = null, [WorkflowExpression] Func<bool> sAPGlobalLeftClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent = null, [WorkflowExpression] Func<double> sAPGlobalLeftClickSAPGridViewCellAtIndextoggleDelay = null, [WorkflowExpression] Func<int> sAPGlobalLeftClickSAPGridViewCellAtIndexclickOffsetX = null, [WorkflowExpression] Func<int> sAPGlobalLeftClickSAPGridViewCellAtIndexclickOffsetY = null, [WorkflowExpression] Func<sAPGlobalLeftClickSAPGridViewCellAtIndexoffsetRelativeToInput> sAPGlobalLeftClickSAPGridViewCellAtIndexoffsetRelativeTo = null)
        {
            SourceExpression.Validate(sAPGlobalLeftClickSAPGridViewCellAtIndexsearchSAPElementId, nameof(sAPGlobalLeftClickSAPGridViewCellAtIndexsearchSAPElementId), required: true);
            SourceExpression.Validate(sAPGlobalLeftClickSAPGridViewCellAtIndexrowIndex, nameof(sAPGlobalLeftClickSAPGridViewCellAtIndexrowIndex), required: true);
            SourceExpression.Validate(sAPGlobalLeftClickSAPGridViewCellAtIndexworkflow, nameof(sAPGlobalLeftClickSAPGridViewCellAtIndexworkflow), required: true);
            SourceExpression.Validate(sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnName, nameof(sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnName), required: false);
            SourceExpression.Validate(sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitle, nameof(sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitle), required: false);
            SourceExpression.Validate(sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression, nameof(sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression), required: false);
            SourceExpression.Validate(sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive, nameof(sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive), required: false);
            SourceExpression.Validate(sAPGlobalLeftClickSAPGridViewCellAtIndexsetElementWindowTopMost, nameof(sAPGlobalLeftClickSAPGridViewCellAtIndexsetElementWindowTopMost), required: false);
            SourceExpression.Validate(sAPGlobalLeftClickSAPGridViewCellAtIndexbringElementWindowToFront, nameof(sAPGlobalLeftClickSAPGridViewCellAtIndexbringElementWindowToFront), required: false);
            SourceExpression.Validate(sAPGlobalLeftClickSAPGridViewCellAtIndextoggleWindow, nameof(sAPGlobalLeftClickSAPGridViewCellAtIndextoggleWindow), required: false);
            SourceExpression.Validate(sAPGlobalLeftClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent, nameof(sAPGlobalLeftClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent), required: false);
            SourceExpression.Validate(sAPGlobalLeftClickSAPGridViewCellAtIndextoggleDelay, nameof(sAPGlobalLeftClickSAPGridViewCellAtIndextoggleDelay), required: false);
            SourceExpression.Validate(sAPGlobalLeftClickSAPGridViewCellAtIndexclickOffsetX, nameof(sAPGlobalLeftClickSAPGridViewCellAtIndexclickOffsetX), required: false);
            SourceExpression.Validate(sAPGlobalLeftClickSAPGridViewCellAtIndexclickOffsetY, nameof(sAPGlobalLeftClickSAPGridViewCellAtIndexclickOffsetY), required: false);
            SourceExpression.Validate(sAPGlobalLeftClickSAPGridViewCellAtIndexoffsetRelativeTo, nameof(sAPGlobalLeftClickSAPGridViewCellAtIndexoffsetRelativeTo), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPGlobalLeftClickSAPGridViewCellAtIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGlobalLeftClickSAPGridViewCellAtIndex = new JObject();
                var sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount = 0;
                sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
                sAPGlobalLeftClickSAPGridViewCellAtIndex["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPGlobalLeftClickSAPGridViewCellAtIndexsearchSAPElementId);
                sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
                sAPGlobalLeftClickSAPGridViewCellAtIndex["RowIndex"] = SourceExpressionConverter.ConvertToken(sAPGlobalLeftClickSAPGridViewCellAtIndexrowIndex);
                if (sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnName != null)
                {
                    sAPGlobalLeftClickSAPGridViewCellAtIndex["SearchColumnName"] = SourceExpressionConverter.ConvertToken(sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnName);
                    sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
                }

                if (sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitle != null)
                {
                    sAPGlobalLeftClickSAPGridViewCellAtIndex["SearchColumnTitle"] = SourceExpressionConverter.ConvertToken(sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitle);
                    sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
                }

                if (sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression != null)
                {
                    if (sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression != null)
                    {
                        sAPGlobalLeftClickSAPGridViewCellAtIndex["SearchColumnTitleIsRegularExpression"] = SourceExpressionConverter.ConvertToken(sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression);
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
                        sAPGlobalLeftClickSAPGridViewCellAtIndex["SearchColumnTitleIsCaseSensitive"] = SourceExpressionConverter.ConvertToken(sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive);
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
                        sAPGlobalLeftClickSAPGridViewCellAtIndex["SetElementWindowTopMost"] = SourceExpressionConverter.ConvertToken(sAPGlobalLeftClickSAPGridViewCellAtIndexsetElementWindowTopMost);
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
                        sAPGlobalLeftClickSAPGridViewCellAtIndex["BringElementWindowToFront"] = SourceExpressionConverter.ConvertToken(sAPGlobalLeftClickSAPGridViewCellAtIndexbringElementWindowToFront);
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
                        sAPGlobalLeftClickSAPGridViewCellAtIndex["ToggleWindow"] = SourceExpressionConverter.ConvertToken(sAPGlobalLeftClickSAPGridViewCellAtIndextoggleWindow);
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
                        sAPGlobalLeftClickSAPGridViewCellAtIndex["ToggleUsesGlobalLeftMouseClickAgent"] = SourceExpressionConverter.ConvertToken(sAPGlobalLeftClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent);
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
                        sAPGlobalLeftClickSAPGridViewCellAtIndex["ToggleDelay"] = SourceExpressionConverter.ConvertToken(sAPGlobalLeftClickSAPGridViewCellAtIndextoggleDelay);
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
                        sAPGlobalLeftClickSAPGridViewCellAtIndex["ClickOffsetX"] = SourceExpressionConverter.ConvertToken(sAPGlobalLeftClickSAPGridViewCellAtIndexclickOffsetX);
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
                        sAPGlobalLeftClickSAPGridViewCellAtIndex["ClickOffsetY"] = SourceExpressionConverter.ConvertToken(sAPGlobalLeftClickSAPGridViewCellAtIndexclickOffsetY);
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
                    sAPGlobalLeftClickSAPGridViewCellAtIndex["OffsetRelativeTo"] = SourceExpressionConverter.Convert(sAPGlobalLeftClickSAPGridViewCellAtIndexoffsetRelativeTo);
                    sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
                }

                sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
                sAPGlobalLeftClickSAPGridViewCellAtIndex["Workflow"] = SourceExpressionConverter.ConvertToken(sAPGlobalLeftClickSAPGridViewCellAtIndexworkflow);
                if (sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount > 0)
                {
                    callPayload.Body = sAPGlobalLeftClickSAPGridViewCellAtIndex;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPGlobalRightClickSAPGridViewCellAtIndex([WorkflowExpression] Func<string> sAPGlobalRightClickSAPGridViewCellAtIndexsearchSAPElementId, [WorkflowExpression] Func<int> sAPGlobalRightClickSAPGridViewCellAtIndexrowIndex, [WorkflowExpression] Func<string> sAPGlobalRightClickSAPGridViewCellAtIndexworkflow, [WorkflowExpression] Func<string> sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnName = null, [WorkflowExpression] Func<string> sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitle = null, [WorkflowExpression] Func<bool> sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression = null, [WorkflowExpression] Func<bool> sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive = null, [WorkflowExpression] Func<bool> sAPGlobalRightClickSAPGridViewCellAtIndexsetElementWindowTopMost = null, [WorkflowExpression] Func<bool> sAPGlobalRightClickSAPGridViewCellAtIndexbringElementWindowToFront = null, [WorkflowExpression] Func<bool> sAPGlobalRightClickSAPGridViewCellAtIndextoggleWindow = null, [WorkflowExpression] Func<bool> sAPGlobalRightClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent = null, [WorkflowExpression] Func<double> sAPGlobalRightClickSAPGridViewCellAtIndextoggleDelay = null, [WorkflowExpression] Func<int> sAPGlobalRightClickSAPGridViewCellAtIndexclickOffsetX = null, [WorkflowExpression] Func<int> sAPGlobalRightClickSAPGridViewCellAtIndexclickOffsetY = null, [WorkflowExpression] Func<sAPGlobalRightClickSAPGridViewCellAtIndexoffsetRelativeToInput> sAPGlobalRightClickSAPGridViewCellAtIndexoffsetRelativeTo = null)
        {
            SourceExpression.Validate(sAPGlobalRightClickSAPGridViewCellAtIndexsearchSAPElementId, nameof(sAPGlobalRightClickSAPGridViewCellAtIndexsearchSAPElementId), required: true);
            SourceExpression.Validate(sAPGlobalRightClickSAPGridViewCellAtIndexrowIndex, nameof(sAPGlobalRightClickSAPGridViewCellAtIndexrowIndex), required: true);
            SourceExpression.Validate(sAPGlobalRightClickSAPGridViewCellAtIndexworkflow, nameof(sAPGlobalRightClickSAPGridViewCellAtIndexworkflow), required: true);
            SourceExpression.Validate(sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnName, nameof(sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnName), required: false);
            SourceExpression.Validate(sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitle, nameof(sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitle), required: false);
            SourceExpression.Validate(sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression, nameof(sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression), required: false);
            SourceExpression.Validate(sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive, nameof(sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive), required: false);
            SourceExpression.Validate(sAPGlobalRightClickSAPGridViewCellAtIndexsetElementWindowTopMost, nameof(sAPGlobalRightClickSAPGridViewCellAtIndexsetElementWindowTopMost), required: false);
            SourceExpression.Validate(sAPGlobalRightClickSAPGridViewCellAtIndexbringElementWindowToFront, nameof(sAPGlobalRightClickSAPGridViewCellAtIndexbringElementWindowToFront), required: false);
            SourceExpression.Validate(sAPGlobalRightClickSAPGridViewCellAtIndextoggleWindow, nameof(sAPGlobalRightClickSAPGridViewCellAtIndextoggleWindow), required: false);
            SourceExpression.Validate(sAPGlobalRightClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent, nameof(sAPGlobalRightClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent), required: false);
            SourceExpression.Validate(sAPGlobalRightClickSAPGridViewCellAtIndextoggleDelay, nameof(sAPGlobalRightClickSAPGridViewCellAtIndextoggleDelay), required: false);
            SourceExpression.Validate(sAPGlobalRightClickSAPGridViewCellAtIndexclickOffsetX, nameof(sAPGlobalRightClickSAPGridViewCellAtIndexclickOffsetX), required: false);
            SourceExpression.Validate(sAPGlobalRightClickSAPGridViewCellAtIndexclickOffsetY, nameof(sAPGlobalRightClickSAPGridViewCellAtIndexclickOffsetY), required: false);
            SourceExpression.Validate(sAPGlobalRightClickSAPGridViewCellAtIndexoffsetRelativeTo, nameof(sAPGlobalRightClickSAPGridViewCellAtIndexoffsetRelativeTo), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPGlobalRightClickSAPGridViewCellAtIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGlobalRightClickSAPGridViewCellAtIndex = new JObject();
                var sAPGlobalRightClickSAPGridViewCellAtIndexpropCount = 0;
                sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
                sAPGlobalRightClickSAPGridViewCellAtIndex["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPGlobalRightClickSAPGridViewCellAtIndexsearchSAPElementId);
                sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
                sAPGlobalRightClickSAPGridViewCellAtIndex["RowIndex"] = SourceExpressionConverter.ConvertToken(sAPGlobalRightClickSAPGridViewCellAtIndexrowIndex);
                if (sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnName != null)
                {
                    sAPGlobalRightClickSAPGridViewCellAtIndex["SearchColumnName"] = SourceExpressionConverter.ConvertToken(sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnName);
                    sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
                }

                if (sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitle != null)
                {
                    sAPGlobalRightClickSAPGridViewCellAtIndex["SearchColumnTitle"] = SourceExpressionConverter.ConvertToken(sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitle);
                    sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
                }

                if (sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression != null)
                {
                    if (sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression != null)
                    {
                        sAPGlobalRightClickSAPGridViewCellAtIndex["SearchColumnTitleIsRegularExpression"] = SourceExpressionConverter.ConvertToken(sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression);
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
                        sAPGlobalRightClickSAPGridViewCellAtIndex["SearchColumnTitleIsCaseSensitive"] = SourceExpressionConverter.ConvertToken(sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive);
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
                        sAPGlobalRightClickSAPGridViewCellAtIndex["SetElementWindowTopMost"] = SourceExpressionConverter.ConvertToken(sAPGlobalRightClickSAPGridViewCellAtIndexsetElementWindowTopMost);
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
                        sAPGlobalRightClickSAPGridViewCellAtIndex["BringElementWindowToFront"] = SourceExpressionConverter.ConvertToken(sAPGlobalRightClickSAPGridViewCellAtIndexbringElementWindowToFront);
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
                        sAPGlobalRightClickSAPGridViewCellAtIndex["ToggleWindow"] = SourceExpressionConverter.ConvertToken(sAPGlobalRightClickSAPGridViewCellAtIndextoggleWindow);
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
                        sAPGlobalRightClickSAPGridViewCellAtIndex["ToggleUsesGlobalLeftMouseClickAgent"] = SourceExpressionConverter.ConvertToken(sAPGlobalRightClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent);
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
                        sAPGlobalRightClickSAPGridViewCellAtIndex["ToggleDelay"] = SourceExpressionConverter.ConvertToken(sAPGlobalRightClickSAPGridViewCellAtIndextoggleDelay);
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
                        sAPGlobalRightClickSAPGridViewCellAtIndex["ClickOffsetX"] = SourceExpressionConverter.ConvertToken(sAPGlobalRightClickSAPGridViewCellAtIndexclickOffsetX);
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
                        sAPGlobalRightClickSAPGridViewCellAtIndex["ClickOffsetY"] = SourceExpressionConverter.ConvertToken(sAPGlobalRightClickSAPGridViewCellAtIndexclickOffsetY);
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
                    sAPGlobalRightClickSAPGridViewCellAtIndex["OffsetRelativeTo"] = SourceExpressionConverter.Convert(sAPGlobalRightClickSAPGridViewCellAtIndexoffsetRelativeTo);
                    sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
                }

                sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
                sAPGlobalRightClickSAPGridViewCellAtIndex["Workflow"] = SourceExpressionConverter.ConvertToken(sAPGlobalRightClickSAPGridViewCellAtIndexworkflow);
                if (sAPGlobalRightClickSAPGridViewCellAtIndexpropCount > 0)
                {
                    callPayload.Body = sAPGlobalRightClickSAPGridViewCellAtIndex;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPGlobalDoubleLeftClickSAPGridViewCellAtIndex([WorkflowExpression] Func<string> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchSAPElementId, [WorkflowExpression] Func<int> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexrowIndex, [WorkflowExpression] Func<string> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexworkflow, [WorkflowExpression] Func<string> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnName = null, [WorkflowExpression] Func<string> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitle = null, [WorkflowExpression] Func<bool> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression = null, [WorkflowExpression] Func<bool> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive = null, [WorkflowExpression] Func<bool> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsetElementWindowTopMost = null, [WorkflowExpression] Func<bool> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexbringElementWindowToFront = null, [WorkflowExpression] Func<bool> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleWindow = null, [WorkflowExpression] Func<bool> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent = null, [WorkflowExpression] Func<double> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleDelay = null, [WorkflowExpression] Func<int> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexclickOffsetX = null, [WorkflowExpression] Func<int> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexclickOffsetY = null, [WorkflowExpression] Func<sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexoffsetRelativeToInput> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexoffsetRelativeTo = null, [WorkflowExpression] Func<int> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexdoubleClickDelayInMilliseconds = null)
        {
            SourceExpression.Validate(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchSAPElementId, nameof(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchSAPElementId), required: true);
            SourceExpression.Validate(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexrowIndex, nameof(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexrowIndex), required: true);
            SourceExpression.Validate(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexworkflow, nameof(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexworkflow), required: true);
            SourceExpression.Validate(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnName, nameof(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnName), required: false);
            SourceExpression.Validate(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitle, nameof(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitle), required: false);
            SourceExpression.Validate(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression, nameof(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression), required: false);
            SourceExpression.Validate(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive, nameof(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive), required: false);
            SourceExpression.Validate(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsetElementWindowTopMost, nameof(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsetElementWindowTopMost), required: false);
            SourceExpression.Validate(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexbringElementWindowToFront, nameof(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexbringElementWindowToFront), required: false);
            SourceExpression.Validate(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleWindow, nameof(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleWindow), required: false);
            SourceExpression.Validate(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent, nameof(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent), required: false);
            SourceExpression.Validate(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleDelay, nameof(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleDelay), required: false);
            SourceExpression.Validate(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexclickOffsetX, nameof(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexclickOffsetX), required: false);
            SourceExpression.Validate(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexclickOffsetY, nameof(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexclickOffsetY), required: false);
            SourceExpression.Validate(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexoffsetRelativeTo, nameof(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexoffsetRelativeTo), required: false);
            SourceExpression.Validate(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexdoubleClickDelayInMilliseconds, nameof(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexdoubleClickDelayInMilliseconds), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPGlobalDoubleLeftClickSAPGridViewCellAtIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex = new JObject();
                var sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount = 0;
                sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
                sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchSAPElementId);
                sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
                sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["RowIndex"] = SourceExpressionConverter.ConvertToken(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexrowIndex);
                if (sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnName != null)
                {
                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["SearchColumnName"] = SourceExpressionConverter.ConvertToken(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnName);
                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
                }

                if (sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitle != null)
                {
                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["SearchColumnTitle"] = SourceExpressionConverter.ConvertToken(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitle);
                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
                }

                if (sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression != null)
                {
                    if (sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression != null)
                    {
                        sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["SearchColumnTitleIsRegularExpression"] = SourceExpressionConverter.ConvertToken(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression);
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
                        sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["SearchColumnTitleIsCaseSensitive"] = SourceExpressionConverter.ConvertToken(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive);
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
                        sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["SetElementWindowTopMost"] = SourceExpressionConverter.ConvertToken(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsetElementWindowTopMost);
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
                        sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["BringElementWindowToFront"] = SourceExpressionConverter.ConvertToken(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexbringElementWindowToFront);
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
                        sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["ToggleWindow"] = SourceExpressionConverter.ConvertToken(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleWindow);
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
                        sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["ToggleUsesGlobalLeftMouseClickAgent"] = SourceExpressionConverter.ConvertToken(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent);
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
                        sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["ToggleDelay"] = SourceExpressionConverter.ConvertToken(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleDelay);
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
                        sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["ClickOffsetX"] = SourceExpressionConverter.ConvertToken(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexclickOffsetX);
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
                        sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["ClickOffsetY"] = SourceExpressionConverter.ConvertToken(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexclickOffsetY);
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
                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["OffsetRelativeTo"] = SourceExpressionConverter.Convert(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexoffsetRelativeTo);
                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
                }

                if (sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexdoubleClickDelayInMilliseconds != null)
                {
                    if (sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexdoubleClickDelayInMilliseconds != null)
                    {
                        sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["DoubleClickDelayInMilliseconds"] = SourceExpressionConverter.ConvertToken(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexdoubleClickDelayInMilliseconds);
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
                sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["Workflow"] = SourceExpressionConverter.ConvertToken(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexworkflow);
                if (sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount > 0)
                {
                    callPayload.Body = sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetSAPGridViewColumnHeadersResponse> SAPGetSAPGridViewColumnHeaders([WorkflowExpression] Func<string> sAPGetSAPGridViewColumnHeaderssearchSAPElementId, [WorkflowExpression] Func<string> sAPGetSAPGridViewColumnHeadersworkflow)
        {
            SourceExpression.Validate(sAPGetSAPGridViewColumnHeaderssearchSAPElementId, nameof(sAPGetSAPGridViewColumnHeaderssearchSAPElementId), required: true);
            SourceExpression.Validate(sAPGetSAPGridViewColumnHeadersworkflow, nameof(sAPGetSAPGridViewColumnHeadersworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPGetSAPGridViewColumnHeaders";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGetSAPGridViewColumnHeaders = new JObject();
                var sAPGetSAPGridViewColumnHeaderspropCount = 0;
                sAPGetSAPGridViewColumnHeaderspropCount++;
                sAPGetSAPGridViewColumnHeaders["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPGetSAPGridViewColumnHeaderssearchSAPElementId);
                sAPGetSAPGridViewColumnHeaderspropCount++;
                sAPGetSAPGridViewColumnHeaders["Workflow"] = SourceExpressionConverter.ConvertToken(sAPGetSAPGridViewColumnHeadersworkflow);
                if (sAPGetSAPGridViewColumnHeaderspropCount > 0)
                {
                    callPayload.Body = sAPGetSAPGridViewColumnHeaders;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SAPGetSAPGridViewColumnHeadersResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPClickSAPGridViewCellAtIndex([WorkflowExpression] Func<string> sAPClickSAPGridViewCellAtIndexsearchSAPElementId, [WorkflowExpression] Func<int> sAPClickSAPGridViewCellAtIndexrowIndex, [WorkflowExpression] Func<string> sAPClickSAPGridViewCellAtIndexworkflow, [WorkflowExpression] Func<string> sAPClickSAPGridViewCellAtIndexsearchColumnName = null, [WorkflowExpression] Func<string> sAPClickSAPGridViewCellAtIndexsearchColumnTitle = null, [WorkflowExpression] Func<bool> sAPClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression = null, [WorkflowExpression] Func<bool> sAPClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive = null)
        {
            SourceExpression.Validate(sAPClickSAPGridViewCellAtIndexsearchSAPElementId, nameof(sAPClickSAPGridViewCellAtIndexsearchSAPElementId), required: true);
            SourceExpression.Validate(sAPClickSAPGridViewCellAtIndexrowIndex, nameof(sAPClickSAPGridViewCellAtIndexrowIndex), required: true);
            SourceExpression.Validate(sAPClickSAPGridViewCellAtIndexworkflow, nameof(sAPClickSAPGridViewCellAtIndexworkflow), required: true);
            SourceExpression.Validate(sAPClickSAPGridViewCellAtIndexsearchColumnName, nameof(sAPClickSAPGridViewCellAtIndexsearchColumnName), required: false);
            SourceExpression.Validate(sAPClickSAPGridViewCellAtIndexsearchColumnTitle, nameof(sAPClickSAPGridViewCellAtIndexsearchColumnTitle), required: false);
            SourceExpression.Validate(sAPClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression, nameof(sAPClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression), required: false);
            SourceExpression.Validate(sAPClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive, nameof(sAPClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPClickSAPGridViewCellAtIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPClickSAPGridViewCellAtIndex = new JObject();
                var sAPClickSAPGridViewCellAtIndexpropCount = 0;
                sAPClickSAPGridViewCellAtIndexpropCount++;
                sAPClickSAPGridViewCellAtIndex["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPClickSAPGridViewCellAtIndexsearchSAPElementId);
                sAPClickSAPGridViewCellAtIndexpropCount++;
                sAPClickSAPGridViewCellAtIndex["RowIndex"] = SourceExpressionConverter.ConvertToken(sAPClickSAPGridViewCellAtIndexrowIndex);
                if (sAPClickSAPGridViewCellAtIndexsearchColumnName != null)
                {
                    sAPClickSAPGridViewCellAtIndex["SearchColumnName"] = SourceExpressionConverter.ConvertToken(sAPClickSAPGridViewCellAtIndexsearchColumnName);
                    sAPClickSAPGridViewCellAtIndexpropCount++;
                }

                if (sAPClickSAPGridViewCellAtIndexsearchColumnTitle != null)
                {
                    sAPClickSAPGridViewCellAtIndex["SearchColumnTitle"] = SourceExpressionConverter.ConvertToken(sAPClickSAPGridViewCellAtIndexsearchColumnTitle);
                    sAPClickSAPGridViewCellAtIndexpropCount++;
                }

                if (sAPClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression != null)
                {
                    if (sAPClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression != null)
                    {
                        sAPClickSAPGridViewCellAtIndex["SearchColumnTitleIsRegularExpression"] = SourceExpressionConverter.ConvertToken(sAPClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression);
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
                        sAPClickSAPGridViewCellAtIndex["SearchColumnTitleIsCaseSensitive"] = SourceExpressionConverter.ConvertToken(sAPClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive);
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
                sAPClickSAPGridViewCellAtIndex["Workflow"] = SourceExpressionConverter.ConvertToken(sAPClickSAPGridViewCellAtIndexworkflow);
                if (sAPClickSAPGridViewCellAtIndexpropCount > 0)
                {
                    callPayload.Body = sAPClickSAPGridViewCellAtIndex;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPDoubleClickSAPGridViewCellAtIndex([WorkflowExpression] Func<string> sAPDoubleClickSAPGridViewCellAtIndexsearchSAPElementId, [WorkflowExpression] Func<int> sAPDoubleClickSAPGridViewCellAtIndexrowIndex, [WorkflowExpression] Func<string> sAPDoubleClickSAPGridViewCellAtIndexworkflow, [WorkflowExpression] Func<string> sAPDoubleClickSAPGridViewCellAtIndexsearchColumnName = null, [WorkflowExpression] Func<string> sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitle = null, [WorkflowExpression] Func<bool> sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression = null, [WorkflowExpression] Func<bool> sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive = null)
        {
            SourceExpression.Validate(sAPDoubleClickSAPGridViewCellAtIndexsearchSAPElementId, nameof(sAPDoubleClickSAPGridViewCellAtIndexsearchSAPElementId), required: true);
            SourceExpression.Validate(sAPDoubleClickSAPGridViewCellAtIndexrowIndex, nameof(sAPDoubleClickSAPGridViewCellAtIndexrowIndex), required: true);
            SourceExpression.Validate(sAPDoubleClickSAPGridViewCellAtIndexworkflow, nameof(sAPDoubleClickSAPGridViewCellAtIndexworkflow), required: true);
            SourceExpression.Validate(sAPDoubleClickSAPGridViewCellAtIndexsearchColumnName, nameof(sAPDoubleClickSAPGridViewCellAtIndexsearchColumnName), required: false);
            SourceExpression.Validate(sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitle, nameof(sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitle), required: false);
            SourceExpression.Validate(sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression, nameof(sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression), required: false);
            SourceExpression.Validate(sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive, nameof(sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPDoubleClickSAPGridViewCellAtIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPDoubleClickSAPGridViewCellAtIndex = new JObject();
                var sAPDoubleClickSAPGridViewCellAtIndexpropCount = 0;
                sAPDoubleClickSAPGridViewCellAtIndexpropCount++;
                sAPDoubleClickSAPGridViewCellAtIndex["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPDoubleClickSAPGridViewCellAtIndexsearchSAPElementId);
                sAPDoubleClickSAPGridViewCellAtIndexpropCount++;
                sAPDoubleClickSAPGridViewCellAtIndex["RowIndex"] = SourceExpressionConverter.ConvertToken(sAPDoubleClickSAPGridViewCellAtIndexrowIndex);
                if (sAPDoubleClickSAPGridViewCellAtIndexsearchColumnName != null)
                {
                    sAPDoubleClickSAPGridViewCellAtIndex["SearchColumnName"] = SourceExpressionConverter.ConvertToken(sAPDoubleClickSAPGridViewCellAtIndexsearchColumnName);
                    sAPDoubleClickSAPGridViewCellAtIndexpropCount++;
                }

                if (sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitle != null)
                {
                    sAPDoubleClickSAPGridViewCellAtIndex["SearchColumnTitle"] = SourceExpressionConverter.ConvertToken(sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitle);
                    sAPDoubleClickSAPGridViewCellAtIndexpropCount++;
                }

                if (sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression != null)
                {
                    if (sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression != null)
                    {
                        sAPDoubleClickSAPGridViewCellAtIndex["SearchColumnTitleIsRegularExpression"] = SourceExpressionConverter.ConvertToken(sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression);
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
                        sAPDoubleClickSAPGridViewCellAtIndex["SearchColumnTitleIsCaseSensitive"] = SourceExpressionConverter.ConvertToken(sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive);
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
                sAPDoubleClickSAPGridViewCellAtIndex["Workflow"] = SourceExpressionConverter.ConvertToken(sAPDoubleClickSAPGridViewCellAtIndexworkflow);
                if (sAPDoubleClickSAPGridViewCellAtIndexpropCount > 0)
                {
                    callPayload.Body = sAPDoubleClickSAPGridViewCellAtIndex;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPPressSAPGridViewCellButtonAtIndex([WorkflowExpression] Func<string> sAPPressSAPGridViewCellButtonAtIndexsearchSAPElementId, [WorkflowExpression] Func<int> sAPPressSAPGridViewCellButtonAtIndexrowIndex, [WorkflowExpression] Func<string> sAPPressSAPGridViewCellButtonAtIndexworkflow, [WorkflowExpression] Func<string> sAPPressSAPGridViewCellButtonAtIndexsearchColumnName = null, [WorkflowExpression] Func<string> sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitle = null, [WorkflowExpression] Func<bool> sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitleIsRegularExpression = null, [WorkflowExpression] Func<bool> sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitleIsCaseSensitive = null)
        {
            SourceExpression.Validate(sAPPressSAPGridViewCellButtonAtIndexsearchSAPElementId, nameof(sAPPressSAPGridViewCellButtonAtIndexsearchSAPElementId), required: true);
            SourceExpression.Validate(sAPPressSAPGridViewCellButtonAtIndexrowIndex, nameof(sAPPressSAPGridViewCellButtonAtIndexrowIndex), required: true);
            SourceExpression.Validate(sAPPressSAPGridViewCellButtonAtIndexworkflow, nameof(sAPPressSAPGridViewCellButtonAtIndexworkflow), required: true);
            SourceExpression.Validate(sAPPressSAPGridViewCellButtonAtIndexsearchColumnName, nameof(sAPPressSAPGridViewCellButtonAtIndexsearchColumnName), required: false);
            SourceExpression.Validate(sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitle, nameof(sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitle), required: false);
            SourceExpression.Validate(sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitleIsRegularExpression, nameof(sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitleIsRegularExpression), required: false);
            SourceExpression.Validate(sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitleIsCaseSensitive, nameof(sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitleIsCaseSensitive), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPPressSAPGridViewCellButtonAtIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPPressSAPGridViewCellButtonAtIndex = new JObject();
                var sAPPressSAPGridViewCellButtonAtIndexpropCount = 0;
                sAPPressSAPGridViewCellButtonAtIndexpropCount++;
                sAPPressSAPGridViewCellButtonAtIndex["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPPressSAPGridViewCellButtonAtIndexsearchSAPElementId);
                sAPPressSAPGridViewCellButtonAtIndexpropCount++;
                sAPPressSAPGridViewCellButtonAtIndex["RowIndex"] = SourceExpressionConverter.ConvertToken(sAPPressSAPGridViewCellButtonAtIndexrowIndex);
                if (sAPPressSAPGridViewCellButtonAtIndexsearchColumnName != null)
                {
                    sAPPressSAPGridViewCellButtonAtIndex["SearchColumnName"] = SourceExpressionConverter.ConvertToken(sAPPressSAPGridViewCellButtonAtIndexsearchColumnName);
                    sAPPressSAPGridViewCellButtonAtIndexpropCount++;
                }

                if (sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitle != null)
                {
                    sAPPressSAPGridViewCellButtonAtIndex["SearchColumnTitle"] = SourceExpressionConverter.ConvertToken(sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitle);
                    sAPPressSAPGridViewCellButtonAtIndexpropCount++;
                }

                if (sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitleIsRegularExpression != null)
                {
                    if (sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitleIsRegularExpression != null)
                    {
                        sAPPressSAPGridViewCellButtonAtIndex["SearchColumnTitleIsRegularExpression"] = SourceExpressionConverter.ConvertToken(sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitleIsRegularExpression);
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
                        sAPPressSAPGridViewCellButtonAtIndex["SearchColumnTitleIsCaseSensitive"] = SourceExpressionConverter.ConvertToken(sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitleIsCaseSensitive);
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
                sAPPressSAPGridViewCellButtonAtIndex["Workflow"] = SourceExpressionConverter.ConvertToken(sAPPressSAPGridViewCellButtonAtIndexworkflow);
                if (sAPPressSAPGridViewCellButtonAtIndexpropCount > 0)
                {
                    callPayload.Body = sAPPressSAPGridViewCellButtonAtIndex;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPCheckSAPGridViewCellCheckboxAtIndex([WorkflowExpression] Func<string> sAPCheckSAPGridViewCellCheckboxAtIndexsearchSAPElementId, [WorkflowExpression] Func<int> sAPCheckSAPGridViewCellCheckboxAtIndexrowIndex, [WorkflowExpression] Func<string> sAPCheckSAPGridViewCellCheckboxAtIndexworkflow, [WorkflowExpression] Func<string> sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnName = null, [WorkflowExpression] Func<string> sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitle = null, [WorkflowExpression] Func<bool> sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitleIsRegularExpression = null, [WorkflowExpression] Func<bool> sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitleIsCaseSensitive = null, [WorkflowExpression] Func<bool> sAPCheckSAPGridViewCellCheckboxAtIndexcheckCellElement = null)
        {
            SourceExpression.Validate(sAPCheckSAPGridViewCellCheckboxAtIndexsearchSAPElementId, nameof(sAPCheckSAPGridViewCellCheckboxAtIndexsearchSAPElementId), required: true);
            SourceExpression.Validate(sAPCheckSAPGridViewCellCheckboxAtIndexrowIndex, nameof(sAPCheckSAPGridViewCellCheckboxAtIndexrowIndex), required: true);
            SourceExpression.Validate(sAPCheckSAPGridViewCellCheckboxAtIndexworkflow, nameof(sAPCheckSAPGridViewCellCheckboxAtIndexworkflow), required: true);
            SourceExpression.Validate(sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnName, nameof(sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnName), required: false);
            SourceExpression.Validate(sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitle, nameof(sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitle), required: false);
            SourceExpression.Validate(sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitleIsRegularExpression, nameof(sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitleIsRegularExpression), required: false);
            SourceExpression.Validate(sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitleIsCaseSensitive, nameof(sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitleIsCaseSensitive), required: false);
            SourceExpression.Validate(sAPCheckSAPGridViewCellCheckboxAtIndexcheckCellElement, nameof(sAPCheckSAPGridViewCellCheckboxAtIndexcheckCellElement), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPCheckSAPGridViewCellCheckboxAtIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPCheckSAPGridViewCellCheckboxAtIndex = new JObject();
                var sAPCheckSAPGridViewCellCheckboxAtIndexpropCount = 0;
                sAPCheckSAPGridViewCellCheckboxAtIndexpropCount++;
                sAPCheckSAPGridViewCellCheckboxAtIndex["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPCheckSAPGridViewCellCheckboxAtIndexsearchSAPElementId);
                sAPCheckSAPGridViewCellCheckboxAtIndexpropCount++;
                sAPCheckSAPGridViewCellCheckboxAtIndex["RowIndex"] = SourceExpressionConverter.ConvertToken(sAPCheckSAPGridViewCellCheckboxAtIndexrowIndex);
                if (sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnName != null)
                {
                    sAPCheckSAPGridViewCellCheckboxAtIndex["SearchColumnName"] = SourceExpressionConverter.ConvertToken(sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnName);
                    sAPCheckSAPGridViewCellCheckboxAtIndexpropCount++;
                }

                if (sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitle != null)
                {
                    sAPCheckSAPGridViewCellCheckboxAtIndex["SearchColumnTitle"] = SourceExpressionConverter.ConvertToken(sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitle);
                    sAPCheckSAPGridViewCellCheckboxAtIndexpropCount++;
                }

                if (sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitleIsRegularExpression != null)
                {
                    if (sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitleIsRegularExpression != null)
                    {
                        sAPCheckSAPGridViewCellCheckboxAtIndex["SearchColumnTitleIsRegularExpression"] = SourceExpressionConverter.ConvertToken(sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitleIsRegularExpression);
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
                        sAPCheckSAPGridViewCellCheckboxAtIndex["SearchColumnTitleIsCaseSensitive"] = SourceExpressionConverter.ConvertToken(sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitleIsCaseSensitive);
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
                        sAPCheckSAPGridViewCellCheckboxAtIndex["CheckCellElement"] = SourceExpressionConverter.ConvertToken(sAPCheckSAPGridViewCellCheckboxAtIndexcheckCellElement);
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
                sAPCheckSAPGridViewCellCheckboxAtIndex["Workflow"] = SourceExpressionConverter.ConvertToken(sAPCheckSAPGridViewCellCheckboxAtIndexworkflow);
                if (sAPCheckSAPGridViewCellCheckboxAtIndexpropCount > 0)
                {
                    callPayload.Body = sAPCheckSAPGridViewCellCheckboxAtIndex;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPModifySAPGridViewCellAtIndexResponse> SAPModifySAPGridViewCellAtIndex([WorkflowExpression] Func<string> sAPModifySAPGridViewCellAtIndexsearchSAPElementId, [WorkflowExpression] Func<int> sAPModifySAPGridViewCellAtIndexrowIndex, [WorkflowExpression] Func<string> sAPModifySAPGridViewCellAtIndexworkflow, [WorkflowExpression] Func<string> sAPModifySAPGridViewCellAtIndexsearchColumnName = null, [WorkflowExpression] Func<string> sAPModifySAPGridViewCellAtIndexsearchColumnTitle = null, [WorkflowExpression] Func<bool> sAPModifySAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression = null, [WorkflowExpression] Func<bool> sAPModifySAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive = null, [WorkflowExpression] Func<string> sAPModifySAPGridViewCellAtIndexnewValue = null)
        {
            SourceExpression.Validate(sAPModifySAPGridViewCellAtIndexsearchSAPElementId, nameof(sAPModifySAPGridViewCellAtIndexsearchSAPElementId), required: true);
            SourceExpression.Validate(sAPModifySAPGridViewCellAtIndexrowIndex, nameof(sAPModifySAPGridViewCellAtIndexrowIndex), required: true);
            SourceExpression.Validate(sAPModifySAPGridViewCellAtIndexworkflow, nameof(sAPModifySAPGridViewCellAtIndexworkflow), required: true);
            SourceExpression.Validate(sAPModifySAPGridViewCellAtIndexsearchColumnName, nameof(sAPModifySAPGridViewCellAtIndexsearchColumnName), required: false);
            SourceExpression.Validate(sAPModifySAPGridViewCellAtIndexsearchColumnTitle, nameof(sAPModifySAPGridViewCellAtIndexsearchColumnTitle), required: false);
            SourceExpression.Validate(sAPModifySAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression, nameof(sAPModifySAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression), required: false);
            SourceExpression.Validate(sAPModifySAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive, nameof(sAPModifySAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive), required: false);
            SourceExpression.Validate(sAPModifySAPGridViewCellAtIndexnewValue, nameof(sAPModifySAPGridViewCellAtIndexnewValue), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPModifySAPGridViewCellAtIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPModifySAPGridViewCellAtIndex = new JObject();
                var sAPModifySAPGridViewCellAtIndexpropCount = 0;
                sAPModifySAPGridViewCellAtIndexpropCount++;
                sAPModifySAPGridViewCellAtIndex["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPModifySAPGridViewCellAtIndexsearchSAPElementId);
                sAPModifySAPGridViewCellAtIndexpropCount++;
                sAPModifySAPGridViewCellAtIndex["RowIndex"] = SourceExpressionConverter.ConvertToken(sAPModifySAPGridViewCellAtIndexrowIndex);
                if (sAPModifySAPGridViewCellAtIndexsearchColumnName != null)
                {
                    sAPModifySAPGridViewCellAtIndex["SearchColumnName"] = SourceExpressionConverter.ConvertToken(sAPModifySAPGridViewCellAtIndexsearchColumnName);
                    sAPModifySAPGridViewCellAtIndexpropCount++;
                }

                if (sAPModifySAPGridViewCellAtIndexsearchColumnTitle != null)
                {
                    sAPModifySAPGridViewCellAtIndex["SearchColumnTitle"] = SourceExpressionConverter.ConvertToken(sAPModifySAPGridViewCellAtIndexsearchColumnTitle);
                    sAPModifySAPGridViewCellAtIndexpropCount++;
                }

                if (sAPModifySAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression != null)
                {
                    if (sAPModifySAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression != null)
                    {
                        sAPModifySAPGridViewCellAtIndex["SearchColumnTitleIsRegularExpression"] = SourceExpressionConverter.ConvertToken(sAPModifySAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression);
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
                        sAPModifySAPGridViewCellAtIndex["SearchColumnTitleIsCaseSensitive"] = SourceExpressionConverter.ConvertToken(sAPModifySAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive);
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
                    sAPModifySAPGridViewCellAtIndex["NewValue"] = SourceExpressionConverter.ConvertToken(sAPModifySAPGridViewCellAtIndexnewValue);
                    sAPModifySAPGridViewCellAtIndexpropCount++;
                }

                sAPModifySAPGridViewCellAtIndexpropCount++;
                sAPModifySAPGridViewCellAtIndex["Workflow"] = SourceExpressionConverter.ConvertToken(sAPModifySAPGridViewCellAtIndexworkflow);
                if (sAPModifySAPGridViewCellAtIndexpropCount > 0)
                {
                    callPayload.Body = sAPModifySAPGridViewCellAtIndex;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SAPModifySAPGridViewCellAtIndexResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPSetSAPGridViewCurrentRow([WorkflowExpression] Func<string> sAPSetSAPGridViewCurrentRowsearchSAPElementId, [WorkflowExpression] Func<int> sAPSetSAPGridViewCurrentRowrowIndex, [WorkflowExpression] Func<string> sAPSetSAPGridViewCurrentRowworkflow)
        {
            SourceExpression.Validate(sAPSetSAPGridViewCurrentRowsearchSAPElementId, nameof(sAPSetSAPGridViewCurrentRowsearchSAPElementId), required: true);
            SourceExpression.Validate(sAPSetSAPGridViewCurrentRowrowIndex, nameof(sAPSetSAPGridViewCurrentRowrowIndex), required: true);
            SourceExpression.Validate(sAPSetSAPGridViewCurrentRowworkflow, nameof(sAPSetSAPGridViewCurrentRowworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPSetSAPGridViewCurrentRow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPSetSAPGridViewCurrentRow = new JObject();
                var sAPSetSAPGridViewCurrentRowpropCount = 0;
                sAPSetSAPGridViewCurrentRowpropCount++;
                sAPSetSAPGridViewCurrentRow["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPSetSAPGridViewCurrentRowsearchSAPElementId);
                sAPSetSAPGridViewCurrentRowpropCount++;
                sAPSetSAPGridViewCurrentRow["RowIndex"] = SourceExpressionConverter.ConvertToken(sAPSetSAPGridViewCurrentRowrowIndex);
                sAPSetSAPGridViewCurrentRowpropCount++;
                sAPSetSAPGridViewCurrentRow["Workflow"] = SourceExpressionConverter.ConvertToken(sAPSetSAPGridViewCurrentRowworkflow);
                if (sAPSetSAPGridViewCurrentRowpropCount > 0)
                {
                    callPayload.Body = sAPSetSAPGridViewCurrentRow;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPPressSAPGridViewColumnHeader([WorkflowExpression] Func<string> sAPPressSAPGridViewColumnHeadersearchSAPElementId, [WorkflowExpression] Func<string> sAPPressSAPGridViewColumnHeaderworkflow, [WorkflowExpression] Func<string> sAPPressSAPGridViewColumnHeadersearchColumnName = null, [WorkflowExpression] Func<string> sAPPressSAPGridViewColumnHeadersearchColumnTitle = null, [WorkflowExpression] Func<bool> sAPPressSAPGridViewColumnHeadersearchColumnTitleIsRegularExpression = null, [WorkflowExpression] Func<bool> sAPPressSAPGridViewColumnHeadersearchColumnTitleIsCaseSensitive = null)
        {
            SourceExpression.Validate(sAPPressSAPGridViewColumnHeadersearchSAPElementId, nameof(sAPPressSAPGridViewColumnHeadersearchSAPElementId), required: true);
            SourceExpression.Validate(sAPPressSAPGridViewColumnHeaderworkflow, nameof(sAPPressSAPGridViewColumnHeaderworkflow), required: true);
            SourceExpression.Validate(sAPPressSAPGridViewColumnHeadersearchColumnName, nameof(sAPPressSAPGridViewColumnHeadersearchColumnName), required: false);
            SourceExpression.Validate(sAPPressSAPGridViewColumnHeadersearchColumnTitle, nameof(sAPPressSAPGridViewColumnHeadersearchColumnTitle), required: false);
            SourceExpression.Validate(sAPPressSAPGridViewColumnHeadersearchColumnTitleIsRegularExpression, nameof(sAPPressSAPGridViewColumnHeadersearchColumnTitleIsRegularExpression), required: false);
            SourceExpression.Validate(sAPPressSAPGridViewColumnHeadersearchColumnTitleIsCaseSensitive, nameof(sAPPressSAPGridViewColumnHeadersearchColumnTitleIsCaseSensitive), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPPressSAPGridViewColumnHeader";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPPressSAPGridViewColumnHeader = new JObject();
                var sAPPressSAPGridViewColumnHeaderpropCount = 0;
                sAPPressSAPGridViewColumnHeaderpropCount++;
                sAPPressSAPGridViewColumnHeader["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPPressSAPGridViewColumnHeadersearchSAPElementId);
                if (sAPPressSAPGridViewColumnHeadersearchColumnName != null)
                {
                    sAPPressSAPGridViewColumnHeader["SearchColumnName"] = SourceExpressionConverter.ConvertToken(sAPPressSAPGridViewColumnHeadersearchColumnName);
                    sAPPressSAPGridViewColumnHeaderpropCount++;
                }

                if (sAPPressSAPGridViewColumnHeadersearchColumnTitle != null)
                {
                    sAPPressSAPGridViewColumnHeader["SearchColumnTitle"] = SourceExpressionConverter.ConvertToken(sAPPressSAPGridViewColumnHeadersearchColumnTitle);
                    sAPPressSAPGridViewColumnHeaderpropCount++;
                }

                if (sAPPressSAPGridViewColumnHeadersearchColumnTitleIsRegularExpression != null)
                {
                    if (sAPPressSAPGridViewColumnHeadersearchColumnTitleIsRegularExpression != null)
                    {
                        sAPPressSAPGridViewColumnHeader["SearchColumnTitleIsRegularExpression"] = SourceExpressionConverter.ConvertToken(sAPPressSAPGridViewColumnHeadersearchColumnTitleIsRegularExpression);
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
                        sAPPressSAPGridViewColumnHeader["SearchColumnTitleIsCaseSensitive"] = SourceExpressionConverter.ConvertToken(sAPPressSAPGridViewColumnHeadersearchColumnTitleIsCaseSensitive);
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
                sAPPressSAPGridViewColumnHeader["Workflow"] = SourceExpressionConverter.ConvertToken(sAPPressSAPGridViewColumnHeaderworkflow);
                if (sAPPressSAPGridViewColumnHeaderpropCount > 0)
                {
                    callPayload.Body = sAPPressSAPGridViewColumnHeader;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPSetSAPGridViewFirstVisibleRowResponse> SAPSetSAPGridViewFirstVisibleRow([WorkflowExpression] Func<string> sAPSetSAPGridViewFirstVisibleRowsearchSAPElementId, [WorkflowExpression] Func<int> sAPSetSAPGridViewFirstVisibleRowfirstVisibleRowIndex, [WorkflowExpression] Func<string> sAPSetSAPGridViewFirstVisibleRowworkflow)
        {
            SourceExpression.Validate(sAPSetSAPGridViewFirstVisibleRowsearchSAPElementId, nameof(sAPSetSAPGridViewFirstVisibleRowsearchSAPElementId), required: true);
            SourceExpression.Validate(sAPSetSAPGridViewFirstVisibleRowfirstVisibleRowIndex, nameof(sAPSetSAPGridViewFirstVisibleRowfirstVisibleRowIndex), required: true);
            SourceExpression.Validate(sAPSetSAPGridViewFirstVisibleRowworkflow, nameof(sAPSetSAPGridViewFirstVisibleRowworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPSetSAPGridViewFirstVisibleRow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPSetSAPGridViewFirstVisibleRow = new JObject();
                var sAPSetSAPGridViewFirstVisibleRowpropCount = 0;
                sAPSetSAPGridViewFirstVisibleRowpropCount++;
                sAPSetSAPGridViewFirstVisibleRow["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPSetSAPGridViewFirstVisibleRowsearchSAPElementId);
                sAPSetSAPGridViewFirstVisibleRowpropCount++;
                sAPSetSAPGridViewFirstVisibleRow["FirstVisibleRowIndex"] = SourceExpressionConverter.ConvertToken(sAPSetSAPGridViewFirstVisibleRowfirstVisibleRowIndex);
                sAPSetSAPGridViewFirstVisibleRowpropCount++;
                sAPSetSAPGridViewFirstVisibleRow["Workflow"] = SourceExpressionConverter.ConvertToken(sAPSetSAPGridViewFirstVisibleRowworkflow);
                if (sAPSetSAPGridViewFirstVisibleRowpropCount > 0)
                {
                    callPayload.Body = sAPSetSAPGridViewFirstVisibleRow;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SAPSetSAPGridViewFirstVisibleRowResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPSelectSAPGridViewRow([WorkflowExpression] Func<string> sAPSelectSAPGridViewRowsearchSAPElementId, [WorkflowExpression] Func<int> sAPSelectSAPGridViewRowrowIndex, [WorkflowExpression] Func<string> sAPSelectSAPGridViewRowworkflow, [WorkflowExpression] Func<bool> sAPSelectSAPGridViewRowsetAsCurrentRow = null)
        {
            SourceExpression.Validate(sAPSelectSAPGridViewRowsearchSAPElementId, nameof(sAPSelectSAPGridViewRowsearchSAPElementId), required: true);
            SourceExpression.Validate(sAPSelectSAPGridViewRowrowIndex, nameof(sAPSelectSAPGridViewRowrowIndex), required: true);
            SourceExpression.Validate(sAPSelectSAPGridViewRowworkflow, nameof(sAPSelectSAPGridViewRowworkflow), required: true);
            SourceExpression.Validate(sAPSelectSAPGridViewRowsetAsCurrentRow, nameof(sAPSelectSAPGridViewRowsetAsCurrentRow), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPSelectSAPGridViewRow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPSelectSAPGridViewRow = new JObject();
                var sAPSelectSAPGridViewRowpropCount = 0;
                sAPSelectSAPGridViewRowpropCount++;
                sAPSelectSAPGridViewRow["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPSelectSAPGridViewRowsearchSAPElementId);
                sAPSelectSAPGridViewRowpropCount++;
                sAPSelectSAPGridViewRow["RowIndex"] = SourceExpressionConverter.ConvertToken(sAPSelectSAPGridViewRowrowIndex);
                if (sAPSelectSAPGridViewRowsetAsCurrentRow != null)
                {
                    if (sAPSelectSAPGridViewRowsetAsCurrentRow != null)
                    {
                        sAPSelectSAPGridViewRow["SetAsCurrentRow"] = SourceExpressionConverter.ConvertToken(sAPSelectSAPGridViewRowsetAsCurrentRow);
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
                sAPSelectSAPGridViewRow["Workflow"] = SourceExpressionConverter.ConvertToken(sAPSelectSAPGridViewRowworkflow);
                if (sAPSelectSAPGridViewRowpropCount > 0)
                {
                    callPayload.Body = sAPSelectSAPGridViewRow;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPSelectSAPGridViewMultipleRows([WorkflowExpression] Func<string> sAPSelectSAPGridViewMultipleRowssearchSAPElementId, [WorkflowExpression] Func<string> sAPSelectSAPGridViewMultipleRowsrowsToSelect, [WorkflowExpression] Func<string> sAPSelectSAPGridViewMultipleRowsworkflow)
        {
            SourceExpression.Validate(sAPSelectSAPGridViewMultipleRowssearchSAPElementId, nameof(sAPSelectSAPGridViewMultipleRowssearchSAPElementId), required: true);
            SourceExpression.Validate(sAPSelectSAPGridViewMultipleRowsrowsToSelect, nameof(sAPSelectSAPGridViewMultipleRowsrowsToSelect), required: true);
            SourceExpression.Validate(sAPSelectSAPGridViewMultipleRowsworkflow, nameof(sAPSelectSAPGridViewMultipleRowsworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPSelectSAPGridViewMultipleRows";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPSelectSAPGridViewMultipleRows = new JObject();
                var sAPSelectSAPGridViewMultipleRowspropCount = 0;
                sAPSelectSAPGridViewMultipleRowspropCount++;
                sAPSelectSAPGridViewMultipleRows["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPSelectSAPGridViewMultipleRowssearchSAPElementId);
                sAPSelectSAPGridViewMultipleRowspropCount++;
                sAPSelectSAPGridViewMultipleRows["RowsToSelect"] = SourceExpressionConverter.ConvertToken(sAPSelectSAPGridViewMultipleRowsrowsToSelect);
                sAPSelectSAPGridViewMultipleRowspropCount++;
                sAPSelectSAPGridViewMultipleRows["Workflow"] = SourceExpressionConverter.ConvertToken(sAPSelectSAPGridViewMultipleRowsworkflow);
                if (sAPSelectSAPGridViewMultipleRowspropCount > 0)
                {
                    callPayload.Body = sAPSelectSAPGridViewMultipleRows;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPSetSAPGridViewCurrentColumn([WorkflowExpression] Func<string> sAPSetSAPGridViewCurrentColumnsearchSAPElementId, [WorkflowExpression] Func<string> sAPSetSAPGridViewCurrentColumnworkflow, [WorkflowExpression] Func<string> sAPSetSAPGridViewCurrentColumnsearchColumnName = null, [WorkflowExpression] Func<string> sAPSetSAPGridViewCurrentColumnsearchColumnTitle = null, [WorkflowExpression] Func<bool> sAPSetSAPGridViewCurrentColumnsearchColumnTitleIsRegularExpression = null, [WorkflowExpression] Func<bool> sAPSetSAPGridViewCurrentColumnsearchColumnTitleIsCaseSensitive = null)
        {
            SourceExpression.Validate(sAPSetSAPGridViewCurrentColumnsearchSAPElementId, nameof(sAPSetSAPGridViewCurrentColumnsearchSAPElementId), required: true);
            SourceExpression.Validate(sAPSetSAPGridViewCurrentColumnworkflow, nameof(sAPSetSAPGridViewCurrentColumnworkflow), required: true);
            SourceExpression.Validate(sAPSetSAPGridViewCurrentColumnsearchColumnName, nameof(sAPSetSAPGridViewCurrentColumnsearchColumnName), required: false);
            SourceExpression.Validate(sAPSetSAPGridViewCurrentColumnsearchColumnTitle, nameof(sAPSetSAPGridViewCurrentColumnsearchColumnTitle), required: false);
            SourceExpression.Validate(sAPSetSAPGridViewCurrentColumnsearchColumnTitleIsRegularExpression, nameof(sAPSetSAPGridViewCurrentColumnsearchColumnTitleIsRegularExpression), required: false);
            SourceExpression.Validate(sAPSetSAPGridViewCurrentColumnsearchColumnTitleIsCaseSensitive, nameof(sAPSetSAPGridViewCurrentColumnsearchColumnTitleIsCaseSensitive), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPSetSAPGridViewCurrentColumn";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPSetSAPGridViewCurrentColumn = new JObject();
                var sAPSetSAPGridViewCurrentColumnpropCount = 0;
                sAPSetSAPGridViewCurrentColumnpropCount++;
                sAPSetSAPGridViewCurrentColumn["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPSetSAPGridViewCurrentColumnsearchSAPElementId);
                if (sAPSetSAPGridViewCurrentColumnsearchColumnName != null)
                {
                    sAPSetSAPGridViewCurrentColumn["SearchColumnName"] = SourceExpressionConverter.ConvertToken(sAPSetSAPGridViewCurrentColumnsearchColumnName);
                    sAPSetSAPGridViewCurrentColumnpropCount++;
                }

                if (sAPSetSAPGridViewCurrentColumnsearchColumnTitle != null)
                {
                    sAPSetSAPGridViewCurrentColumn["SearchColumnTitle"] = SourceExpressionConverter.ConvertToken(sAPSetSAPGridViewCurrentColumnsearchColumnTitle);
                    sAPSetSAPGridViewCurrentColumnpropCount++;
                }

                if (sAPSetSAPGridViewCurrentColumnsearchColumnTitleIsRegularExpression != null)
                {
                    if (sAPSetSAPGridViewCurrentColumnsearchColumnTitleIsRegularExpression != null)
                    {
                        sAPSetSAPGridViewCurrentColumn["SearchColumnTitleIsRegularExpression"] = SourceExpressionConverter.ConvertToken(sAPSetSAPGridViewCurrentColumnsearchColumnTitleIsRegularExpression);
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
                        sAPSetSAPGridViewCurrentColumn["SearchColumnTitleIsCaseSensitive"] = SourceExpressionConverter.ConvertToken(sAPSetSAPGridViewCurrentColumnsearchColumnTitleIsCaseSensitive);
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
                sAPSetSAPGridViewCurrentColumn["Workflow"] = SourceExpressionConverter.ConvertToken(sAPSetSAPGridViewCurrentColumnworkflow);
                if (sAPSetSAPGridViewCurrentColumnpropCount > 0)
                {
                    callPayload.Body = sAPSetSAPGridViewCurrentColumn;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPSetSAPGridViewCurrentCell([WorkflowExpression] Func<string> sAPSetSAPGridViewCurrentCellsearchSAPElementId, [WorkflowExpression] Func<int> sAPSetSAPGridViewCurrentCellrowIndex, [WorkflowExpression] Func<string> sAPSetSAPGridViewCurrentCellworkflow, [WorkflowExpression] Func<string> sAPSetSAPGridViewCurrentCellsearchColumnName = null, [WorkflowExpression] Func<string> sAPSetSAPGridViewCurrentCellsearchColumnTitle = null, [WorkflowExpression] Func<bool> sAPSetSAPGridViewCurrentCellsearchColumnTitleIsRegularExpression = null, [WorkflowExpression] Func<bool> sAPSetSAPGridViewCurrentCellsearchColumnTitleIsCaseSensitive = null)
        {
            SourceExpression.Validate(sAPSetSAPGridViewCurrentCellsearchSAPElementId, nameof(sAPSetSAPGridViewCurrentCellsearchSAPElementId), required: true);
            SourceExpression.Validate(sAPSetSAPGridViewCurrentCellrowIndex, nameof(sAPSetSAPGridViewCurrentCellrowIndex), required: true);
            SourceExpression.Validate(sAPSetSAPGridViewCurrentCellworkflow, nameof(sAPSetSAPGridViewCurrentCellworkflow), required: true);
            SourceExpression.Validate(sAPSetSAPGridViewCurrentCellsearchColumnName, nameof(sAPSetSAPGridViewCurrentCellsearchColumnName), required: false);
            SourceExpression.Validate(sAPSetSAPGridViewCurrentCellsearchColumnTitle, nameof(sAPSetSAPGridViewCurrentCellsearchColumnTitle), required: false);
            SourceExpression.Validate(sAPSetSAPGridViewCurrentCellsearchColumnTitleIsRegularExpression, nameof(sAPSetSAPGridViewCurrentCellsearchColumnTitleIsRegularExpression), required: false);
            SourceExpression.Validate(sAPSetSAPGridViewCurrentCellsearchColumnTitleIsCaseSensitive, nameof(sAPSetSAPGridViewCurrentCellsearchColumnTitleIsCaseSensitive), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPSetSAPGridViewCurrentCell";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPSetSAPGridViewCurrentCell = new JObject();
                var sAPSetSAPGridViewCurrentCellpropCount = 0;
                sAPSetSAPGridViewCurrentCellpropCount++;
                sAPSetSAPGridViewCurrentCell["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPSetSAPGridViewCurrentCellsearchSAPElementId);
                sAPSetSAPGridViewCurrentCellpropCount++;
                sAPSetSAPGridViewCurrentCell["RowIndex"] = SourceExpressionConverter.ConvertToken(sAPSetSAPGridViewCurrentCellrowIndex);
                if (sAPSetSAPGridViewCurrentCellsearchColumnName != null)
                {
                    sAPSetSAPGridViewCurrentCell["SearchColumnName"] = SourceExpressionConverter.ConvertToken(sAPSetSAPGridViewCurrentCellsearchColumnName);
                    sAPSetSAPGridViewCurrentCellpropCount++;
                }

                if (sAPSetSAPGridViewCurrentCellsearchColumnTitle != null)
                {
                    sAPSetSAPGridViewCurrentCell["SearchColumnTitle"] = SourceExpressionConverter.ConvertToken(sAPSetSAPGridViewCurrentCellsearchColumnTitle);
                    sAPSetSAPGridViewCurrentCellpropCount++;
                }

                if (sAPSetSAPGridViewCurrentCellsearchColumnTitleIsRegularExpression != null)
                {
                    if (sAPSetSAPGridViewCurrentCellsearchColumnTitleIsRegularExpression != null)
                    {
                        sAPSetSAPGridViewCurrentCell["SearchColumnTitleIsRegularExpression"] = SourceExpressionConverter.ConvertToken(sAPSetSAPGridViewCurrentCellsearchColumnTitleIsRegularExpression);
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
                        sAPSetSAPGridViewCurrentCell["SearchColumnTitleIsCaseSensitive"] = SourceExpressionConverter.ConvertToken(sAPSetSAPGridViewCurrentCellsearchColumnTitleIsCaseSensitive);
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
                sAPSetSAPGridViewCurrentCell["Workflow"] = SourceExpressionConverter.ConvertToken(sAPSetSAPGridViewCurrentCellworkflow);
                if (sAPSetSAPGridViewCurrentCellpropCount > 0)
                {
                    callPayload.Body = sAPSetSAPGridViewCurrentCell;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPSelectSAPGridViewColumn([WorkflowExpression] Func<string> sAPSelectSAPGridViewColumnsearchSAPElementId, [WorkflowExpression] Func<string> sAPSelectSAPGridViewColumnworkflow, [WorkflowExpression] Func<string> sAPSelectSAPGridViewColumnsearchColumnName = null, [WorkflowExpression] Func<string> sAPSelectSAPGridViewColumnsearchColumnTitle = null, [WorkflowExpression] Func<bool> sAPSelectSAPGridViewColumnsearchColumnTitleIsRegularExpression = null, [WorkflowExpression] Func<bool> sAPSelectSAPGridViewColumnsearchColumnTitleIsCaseSensitive = null, [WorkflowExpression] Func<bool> sAPSelectSAPGridViewColumnselectColumn = null, [WorkflowExpression] Func<bool> sAPSelectSAPGridViewColumnsetAsCurrentColumn = null, [WorkflowExpression] Func<bool> sAPSelectSAPGridViewColumnclearSelectionFirst = null)
        {
            SourceExpression.Validate(sAPSelectSAPGridViewColumnsearchSAPElementId, nameof(sAPSelectSAPGridViewColumnsearchSAPElementId), required: true);
            SourceExpression.Validate(sAPSelectSAPGridViewColumnworkflow, nameof(sAPSelectSAPGridViewColumnworkflow), required: true);
            SourceExpression.Validate(sAPSelectSAPGridViewColumnsearchColumnName, nameof(sAPSelectSAPGridViewColumnsearchColumnName), required: false);
            SourceExpression.Validate(sAPSelectSAPGridViewColumnsearchColumnTitle, nameof(sAPSelectSAPGridViewColumnsearchColumnTitle), required: false);
            SourceExpression.Validate(sAPSelectSAPGridViewColumnsearchColumnTitleIsRegularExpression, nameof(sAPSelectSAPGridViewColumnsearchColumnTitleIsRegularExpression), required: false);
            SourceExpression.Validate(sAPSelectSAPGridViewColumnsearchColumnTitleIsCaseSensitive, nameof(sAPSelectSAPGridViewColumnsearchColumnTitleIsCaseSensitive), required: false);
            SourceExpression.Validate(sAPSelectSAPGridViewColumnselectColumn, nameof(sAPSelectSAPGridViewColumnselectColumn), required: false);
            SourceExpression.Validate(sAPSelectSAPGridViewColumnsetAsCurrentColumn, nameof(sAPSelectSAPGridViewColumnsetAsCurrentColumn), required: false);
            SourceExpression.Validate(sAPSelectSAPGridViewColumnclearSelectionFirst, nameof(sAPSelectSAPGridViewColumnclearSelectionFirst), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPSelectSAPGridViewColumn";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPSelectSAPGridViewColumn = new JObject();
                var sAPSelectSAPGridViewColumnpropCount = 0;
                sAPSelectSAPGridViewColumnpropCount++;
                sAPSelectSAPGridViewColumn["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPSelectSAPGridViewColumnsearchSAPElementId);
                if (sAPSelectSAPGridViewColumnsearchColumnName != null)
                {
                    sAPSelectSAPGridViewColumn["SearchColumnName"] = SourceExpressionConverter.ConvertToken(sAPSelectSAPGridViewColumnsearchColumnName);
                    sAPSelectSAPGridViewColumnpropCount++;
                }

                if (sAPSelectSAPGridViewColumnsearchColumnTitle != null)
                {
                    sAPSelectSAPGridViewColumn["SearchColumnTitle"] = SourceExpressionConverter.ConvertToken(sAPSelectSAPGridViewColumnsearchColumnTitle);
                    sAPSelectSAPGridViewColumnpropCount++;
                }

                if (sAPSelectSAPGridViewColumnsearchColumnTitleIsRegularExpression != null)
                {
                    if (sAPSelectSAPGridViewColumnsearchColumnTitleIsRegularExpression != null)
                    {
                        sAPSelectSAPGridViewColumn["SearchColumnTitleIsRegularExpression"] = SourceExpressionConverter.ConvertToken(sAPSelectSAPGridViewColumnsearchColumnTitleIsRegularExpression);
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
                        sAPSelectSAPGridViewColumn["SearchColumnTitleIsCaseSensitive"] = SourceExpressionConverter.ConvertToken(sAPSelectSAPGridViewColumnsearchColumnTitleIsCaseSensitive);
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
                        sAPSelectSAPGridViewColumn["SelectColumn"] = SourceExpressionConverter.ConvertToken(sAPSelectSAPGridViewColumnselectColumn);
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
                        sAPSelectSAPGridViewColumn["SetAsCurrentColumn"] = SourceExpressionConverter.ConvertToken(sAPSelectSAPGridViewColumnsetAsCurrentColumn);
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
                        sAPSelectSAPGridViewColumn["ClearSelectionFirst"] = SourceExpressionConverter.ConvertToken(sAPSelectSAPGridViewColumnclearSelectionFirst);
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
                sAPSelectSAPGridViewColumn["Workflow"] = SourceExpressionConverter.ConvertToken(sAPSelectSAPGridViewColumnworkflow);
                if (sAPSelectSAPGridViewColumnpropCount > 0)
                {
                    callPayload.Body = sAPSelectSAPGridViewColumn;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPGridViewSelectAll([WorkflowExpression] Func<string> sAPGridViewSelectAllsearchSAPElementId, [WorkflowExpression] Func<string> sAPGridViewSelectAllworkflow)
        {
            SourceExpression.Validate(sAPGridViewSelectAllsearchSAPElementId, nameof(sAPGridViewSelectAllsearchSAPElementId), required: true);
            SourceExpression.Validate(sAPGridViewSelectAllworkflow, nameof(sAPGridViewSelectAllworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPGridViewSelectAll";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGridViewSelectAll = new JObject();
                var sAPGridViewSelectAllpropCount = 0;
                sAPGridViewSelectAllpropCount++;
                sAPGridViewSelectAll["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPGridViewSelectAllsearchSAPElementId);
                sAPGridViewSelectAllpropCount++;
                sAPGridViewSelectAll["Workflow"] = SourceExpressionConverter.ConvertToken(sAPGridViewSelectAllworkflow);
                if (sAPGridViewSelectAllpropCount > 0)
                {
                    callPayload.Body = sAPGridViewSelectAll;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPGridViewDeselectAll([WorkflowExpression] Func<string> sAPGridViewDeselectAllsearchSAPElementId, [WorkflowExpression] Func<string> sAPGridViewDeselectAllworkflow)
        {
            SourceExpression.Validate(sAPGridViewDeselectAllsearchSAPElementId, nameof(sAPGridViewDeselectAllsearchSAPElementId), required: true);
            SourceExpression.Validate(sAPGridViewDeselectAllworkflow, nameof(sAPGridViewDeselectAllworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPGridViewDeselectAll";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGridViewDeselectAll = new JObject();
                var sAPGridViewDeselectAllpropCount = 0;
                sAPGridViewDeselectAllpropCount++;
                sAPGridViewDeselectAll["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPGridViewDeselectAllsearchSAPElementId);
                sAPGridViewDeselectAllpropCount++;
                sAPGridViewDeselectAll["Workflow"] = SourceExpressionConverter.ConvertToken(sAPGridViewDeselectAllworkflow);
                if (sAPGridViewDeselectAllpropCount > 0)
                {
                    callPayload.Body = sAPGridViewDeselectAll;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPSetSAPGridViewFirstVisibleColumnResponse> SAPSetSAPGridViewFirstVisibleColumn([WorkflowExpression] Func<string> sAPSetSAPGridViewFirstVisibleColumnsearchSAPElementId, [WorkflowExpression] Func<string> sAPSetSAPGridViewFirstVisibleColumnworkflow, [WorkflowExpression] Func<string> sAPSetSAPGridViewFirstVisibleColumnsearchColumnName = null, [WorkflowExpression] Func<string> sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitle = null, [WorkflowExpression] Func<bool> sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitleIsRegularExpression = null, [WorkflowExpression] Func<bool> sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitleIsCaseSensitive = null)
        {
            SourceExpression.Validate(sAPSetSAPGridViewFirstVisibleColumnsearchSAPElementId, nameof(sAPSetSAPGridViewFirstVisibleColumnsearchSAPElementId), required: true);
            SourceExpression.Validate(sAPSetSAPGridViewFirstVisibleColumnworkflow, nameof(sAPSetSAPGridViewFirstVisibleColumnworkflow), required: true);
            SourceExpression.Validate(sAPSetSAPGridViewFirstVisibleColumnsearchColumnName, nameof(sAPSetSAPGridViewFirstVisibleColumnsearchColumnName), required: false);
            SourceExpression.Validate(sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitle, nameof(sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitle), required: false);
            SourceExpression.Validate(sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitleIsRegularExpression, nameof(sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitleIsRegularExpression), required: false);
            SourceExpression.Validate(sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitleIsCaseSensitive, nameof(sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitleIsCaseSensitive), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPSetSAPGridViewFirstVisibleColumn";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPSetSAPGridViewFirstVisibleColumn = new JObject();
                var sAPSetSAPGridViewFirstVisibleColumnpropCount = 0;
                sAPSetSAPGridViewFirstVisibleColumnpropCount++;
                sAPSetSAPGridViewFirstVisibleColumn["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPSetSAPGridViewFirstVisibleColumnsearchSAPElementId);
                if (sAPSetSAPGridViewFirstVisibleColumnsearchColumnName != null)
                {
                    sAPSetSAPGridViewFirstVisibleColumn["SearchColumnName"] = SourceExpressionConverter.ConvertToken(sAPSetSAPGridViewFirstVisibleColumnsearchColumnName);
                    sAPSetSAPGridViewFirstVisibleColumnpropCount++;
                }

                if (sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitle != null)
                {
                    sAPSetSAPGridViewFirstVisibleColumn["SearchColumnTitle"] = SourceExpressionConverter.ConvertToken(sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitle);
                    sAPSetSAPGridViewFirstVisibleColumnpropCount++;
                }

                if (sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitleIsRegularExpression != null)
                {
                    if (sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitleIsRegularExpression != null)
                    {
                        sAPSetSAPGridViewFirstVisibleColumn["SearchColumnTitleIsRegularExpression"] = SourceExpressionConverter.ConvertToken(sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitleIsRegularExpression);
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
                        sAPSetSAPGridViewFirstVisibleColumn["SearchColumnTitleIsCaseSensitive"] = SourceExpressionConverter.ConvertToken(sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitleIsCaseSensitive);
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
                sAPSetSAPGridViewFirstVisibleColumn["Workflow"] = SourceExpressionConverter.ConvertToken(sAPSetSAPGridViewFirstVisibleColumnworkflow);
                if (sAPSetSAPGridViewFirstVisibleColumnpropCount > 0)
                {
                    callPayload.Body = sAPSetSAPGridViewFirstVisibleColumn;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SAPSetSAPGridViewFirstVisibleColumnResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPGridViewOpenContextMenu([WorkflowExpression] Func<string> sAPGridViewOpenContextMenusearchSAPElementId, [WorkflowExpression] Func<int> sAPGridViewOpenContextMenurowIndex, [WorkflowExpression] Func<string> sAPGridViewOpenContextMenuworkflow, [WorkflowExpression] Func<string> sAPGridViewOpenContextMenusearchColumnName = null, [WorkflowExpression] Func<string> sAPGridViewOpenContextMenusearchColumnTitle = null, [WorkflowExpression] Func<bool> sAPGridViewOpenContextMenusearchColumnTitleIsRegularExpression = null, [WorkflowExpression] Func<bool> sAPGridViewOpenContextMenusearchColumnTitleIsCaseSensitive = null)
        {
            SourceExpression.Validate(sAPGridViewOpenContextMenusearchSAPElementId, nameof(sAPGridViewOpenContextMenusearchSAPElementId), required: true);
            SourceExpression.Validate(sAPGridViewOpenContextMenurowIndex, nameof(sAPGridViewOpenContextMenurowIndex), required: true);
            SourceExpression.Validate(sAPGridViewOpenContextMenuworkflow, nameof(sAPGridViewOpenContextMenuworkflow), required: true);
            SourceExpression.Validate(sAPGridViewOpenContextMenusearchColumnName, nameof(sAPGridViewOpenContextMenusearchColumnName), required: false);
            SourceExpression.Validate(sAPGridViewOpenContextMenusearchColumnTitle, nameof(sAPGridViewOpenContextMenusearchColumnTitle), required: false);
            SourceExpression.Validate(sAPGridViewOpenContextMenusearchColumnTitleIsRegularExpression, nameof(sAPGridViewOpenContextMenusearchColumnTitleIsRegularExpression), required: false);
            SourceExpression.Validate(sAPGridViewOpenContextMenusearchColumnTitleIsCaseSensitive, nameof(sAPGridViewOpenContextMenusearchColumnTitleIsCaseSensitive), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPGridViewOpenContextMenu";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGridViewOpenContextMenu = new JObject();
                var sAPGridViewOpenContextMenupropCount = 0;
                sAPGridViewOpenContextMenupropCount++;
                sAPGridViewOpenContextMenu["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPGridViewOpenContextMenusearchSAPElementId);
                sAPGridViewOpenContextMenupropCount++;
                sAPGridViewOpenContextMenu["RowIndex"] = SourceExpressionConverter.ConvertToken(sAPGridViewOpenContextMenurowIndex);
                if (sAPGridViewOpenContextMenusearchColumnName != null)
                {
                    sAPGridViewOpenContextMenu["SearchColumnName"] = SourceExpressionConverter.ConvertToken(sAPGridViewOpenContextMenusearchColumnName);
                    sAPGridViewOpenContextMenupropCount++;
                }

                if (sAPGridViewOpenContextMenusearchColumnTitle != null)
                {
                    sAPGridViewOpenContextMenu["SearchColumnTitle"] = SourceExpressionConverter.ConvertToken(sAPGridViewOpenContextMenusearchColumnTitle);
                    sAPGridViewOpenContextMenupropCount++;
                }

                if (sAPGridViewOpenContextMenusearchColumnTitleIsRegularExpression != null)
                {
                    if (sAPGridViewOpenContextMenusearchColumnTitleIsRegularExpression != null)
                    {
                        sAPGridViewOpenContextMenu["SearchColumnTitleIsRegularExpression"] = SourceExpressionConverter.ConvertToken(sAPGridViewOpenContextMenusearchColumnTitleIsRegularExpression);
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
                        sAPGridViewOpenContextMenu["SearchColumnTitleIsCaseSensitive"] = SourceExpressionConverter.ConvertToken(sAPGridViewOpenContextMenusearchColumnTitleIsCaseSensitive);
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
                sAPGridViewOpenContextMenu["Workflow"] = SourceExpressionConverter.ConvertToken(sAPGridViewOpenContextMenuworkflow);
                if (sAPGridViewOpenContextMenupropCount > 0)
                {
                    callPayload.Body = sAPGridViewOpenContextMenu;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetGridViewTextContentsResponse> SAPGetGridViewTextContents([WorkflowExpression] Func<string> sAPGetGridViewTextContentssearchSAPElementId, [WorkflowExpression] Func<string> sAPGetGridViewTextContentsworkflow, [WorkflowExpression] Func<int> sAPGetGridViewTextContentsfirstRowToReturn = null, [WorkflowExpression] Func<int> sAPGetGridViewTextContentsmaxRowsToReturn = null, [WorkflowExpression] Func<string> sAPGetGridViewTextContentsfirstSearchColumnName = null, [WorkflowExpression] Func<string> sAPGetGridViewTextContentsfirstSearchColumnTitle = null, [WorkflowExpression] Func<bool> sAPGetGridViewTextContentsfirstSearchColumnTitleIsRegularExpression = null, [WorkflowExpression] Func<bool> sAPGetGridViewTextContentsfirstSearchColumnTitleIsCaseSensitive = null, [WorkflowExpression] Func<int> sAPGetGridViewTextContentsmaxColumnsToReturn = null, [WorkflowExpression] Func<bool> sAPGetGridViewTextContentsuseColumnHeadersFromTable = null, [WorkflowExpression] Func<bool> sAPGetGridViewTextContentsreturnRowIndexInOutputCollection = null, [WorkflowExpression] Func<string> sAPGetGridViewTextContentsnameOfColumnToStoreRowIndex = null, [WorkflowExpression] Func<string> sAPGetGridViewTextContentscheckedElementValue = null)
        {
            SourceExpression.Validate(sAPGetGridViewTextContentssearchSAPElementId, nameof(sAPGetGridViewTextContentssearchSAPElementId), required: true);
            SourceExpression.Validate(sAPGetGridViewTextContentsworkflow, nameof(sAPGetGridViewTextContentsworkflow), required: true);
            SourceExpression.Validate(sAPGetGridViewTextContentsfirstRowToReturn, nameof(sAPGetGridViewTextContentsfirstRowToReturn), required: false);
            SourceExpression.Validate(sAPGetGridViewTextContentsmaxRowsToReturn, nameof(sAPGetGridViewTextContentsmaxRowsToReturn), required: false);
            SourceExpression.Validate(sAPGetGridViewTextContentsfirstSearchColumnName, nameof(sAPGetGridViewTextContentsfirstSearchColumnName), required: false);
            SourceExpression.Validate(sAPGetGridViewTextContentsfirstSearchColumnTitle, nameof(sAPGetGridViewTextContentsfirstSearchColumnTitle), required: false);
            SourceExpression.Validate(sAPGetGridViewTextContentsfirstSearchColumnTitleIsRegularExpression, nameof(sAPGetGridViewTextContentsfirstSearchColumnTitleIsRegularExpression), required: false);
            SourceExpression.Validate(sAPGetGridViewTextContentsfirstSearchColumnTitleIsCaseSensitive, nameof(sAPGetGridViewTextContentsfirstSearchColumnTitleIsCaseSensitive), required: false);
            SourceExpression.Validate(sAPGetGridViewTextContentsmaxColumnsToReturn, nameof(sAPGetGridViewTextContentsmaxColumnsToReturn), required: false);
            SourceExpression.Validate(sAPGetGridViewTextContentsuseColumnHeadersFromTable, nameof(sAPGetGridViewTextContentsuseColumnHeadersFromTable), required: false);
            SourceExpression.Validate(sAPGetGridViewTextContentsreturnRowIndexInOutputCollection, nameof(sAPGetGridViewTextContentsreturnRowIndexInOutputCollection), required: false);
            SourceExpression.Validate(sAPGetGridViewTextContentsnameOfColumnToStoreRowIndex, nameof(sAPGetGridViewTextContentsnameOfColumnToStoreRowIndex), required: false);
            SourceExpression.Validate(sAPGetGridViewTextContentscheckedElementValue, nameof(sAPGetGridViewTextContentscheckedElementValue), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPGetGridViewTextContents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPGetGridViewTextContents = new JObject();
                var sAPGetGridViewTextContentspropCount = 0;
                sAPGetGridViewTextContentspropCount++;
                sAPGetGridViewTextContents["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPGetGridViewTextContentssearchSAPElementId);
                if (sAPGetGridViewTextContentsfirstRowToReturn != null)
                {
                    if (sAPGetGridViewTextContentsfirstRowToReturn != null)
                    {
                        sAPGetGridViewTextContents["FirstRowToReturn"] = SourceExpressionConverter.ConvertToken(sAPGetGridViewTextContentsfirstRowToReturn);
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
                        sAPGetGridViewTextContents["MaxRowsToReturn"] = SourceExpressionConverter.ConvertToken(sAPGetGridViewTextContentsmaxRowsToReturn);
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
                    sAPGetGridViewTextContents["FirstSearchColumnName"] = SourceExpressionConverter.ConvertToken(sAPGetGridViewTextContentsfirstSearchColumnName);
                    sAPGetGridViewTextContentspropCount++;
                }

                if (sAPGetGridViewTextContentsfirstSearchColumnTitle != null)
                {
                    sAPGetGridViewTextContents["FirstSearchColumnTitle"] = SourceExpressionConverter.ConvertToken(sAPGetGridViewTextContentsfirstSearchColumnTitle);
                    sAPGetGridViewTextContentspropCount++;
                }

                if (sAPGetGridViewTextContentsfirstSearchColumnTitleIsRegularExpression != null)
                {
                    if (sAPGetGridViewTextContentsfirstSearchColumnTitleIsRegularExpression != null)
                    {
                        sAPGetGridViewTextContents["FirstSearchColumnTitleIsRegularExpression"] = SourceExpressionConverter.ConvertToken(sAPGetGridViewTextContentsfirstSearchColumnTitleIsRegularExpression);
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
                        sAPGetGridViewTextContents["FirstSearchColumnTitleIsCaseSensitive"] = SourceExpressionConverter.ConvertToken(sAPGetGridViewTextContentsfirstSearchColumnTitleIsCaseSensitive);
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
                        sAPGetGridViewTextContents["MaxColumnsToReturn"] = SourceExpressionConverter.ConvertToken(sAPGetGridViewTextContentsmaxColumnsToReturn);
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
                        sAPGetGridViewTextContents["UseColumnHeadersFromTable"] = SourceExpressionConverter.ConvertToken(sAPGetGridViewTextContentsuseColumnHeadersFromTable);
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
                        sAPGetGridViewTextContents["ReturnRowIndexInOutputCollection"] = SourceExpressionConverter.ConvertToken(sAPGetGridViewTextContentsreturnRowIndexInOutputCollection);
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
                    sAPGetGridViewTextContents["NameOfColumnToStoreRowIndex"] = SourceExpressionConverter.ConvertToken(sAPGetGridViewTextContentsnameOfColumnToStoreRowIndex);
                    sAPGetGridViewTextContentspropCount++;
                }

                if (sAPGetGridViewTextContentscheckedElementValue != null)
                {
                    if (sAPGetGridViewTextContentscheckedElementValue != null)
                    {
                        sAPGetGridViewTextContents["CheckedElementValue"] = SourceExpressionConverter.ConvertToken(sAPGetGridViewTextContentscheckedElementValue);
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
                sAPGetGridViewTextContents["Workflow"] = SourceExpressionConverter.ConvertToken(sAPGetGridViewTextContentsworkflow);
                if (sAPGetGridViewTextContentspropCount > 0)
                {
                    callPayload.Body = sAPGetGridViewTextContents;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SAPGetGridViewTextContentsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPSelectCalendarMonth([WorkflowExpression] Func<string> sAPSelectCalendarMonthsearchSAPElementId, [WorkflowExpression] Func<int> sAPSelectCalendarMonthmonth, [WorkflowExpression] Func<int> sAPSelectCalendarMonthyear, [WorkflowExpression] Func<string> sAPSelectCalendarMonthworkflow)
        {
            SourceExpression.Validate(sAPSelectCalendarMonthsearchSAPElementId, nameof(sAPSelectCalendarMonthsearchSAPElementId), required: true);
            SourceExpression.Validate(sAPSelectCalendarMonthmonth, nameof(sAPSelectCalendarMonthmonth), required: true);
            SourceExpression.Validate(sAPSelectCalendarMonthyear, nameof(sAPSelectCalendarMonthyear), required: true);
            SourceExpression.Validate(sAPSelectCalendarMonthworkflow, nameof(sAPSelectCalendarMonthworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPSelectCalendarMonth";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPSelectCalendarMonth = new JObject();
                var sAPSelectCalendarMonthpropCount = 0;
                sAPSelectCalendarMonthpropCount++;
                sAPSelectCalendarMonth["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPSelectCalendarMonthsearchSAPElementId);
                sAPSelectCalendarMonthpropCount++;
                sAPSelectCalendarMonth["Month"] = SourceExpressionConverter.ConvertToken(sAPSelectCalendarMonthmonth);
                sAPSelectCalendarMonthpropCount++;
                sAPSelectCalendarMonth["Year"] = SourceExpressionConverter.ConvertToken(sAPSelectCalendarMonthyear);
                sAPSelectCalendarMonthpropCount++;
                sAPSelectCalendarMonth["Workflow"] = SourceExpressionConverter.ConvertToken(sAPSelectCalendarMonthworkflow);
                if (sAPSelectCalendarMonthpropCount > 0)
                {
                    callPayload.Body = sAPSelectCalendarMonth;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPSelectCalendarWeek([WorkflowExpression] Func<string> sAPSelectCalendarWeeksearchSAPElementId, [WorkflowExpression] Func<int> sAPSelectCalendarWeekweek, [WorkflowExpression] Func<int> sAPSelectCalendarWeekyear, [WorkflowExpression] Func<string> sAPSelectCalendarWeekworkflow)
        {
            SourceExpression.Validate(sAPSelectCalendarWeeksearchSAPElementId, nameof(sAPSelectCalendarWeeksearchSAPElementId), required: true);
            SourceExpression.Validate(sAPSelectCalendarWeekweek, nameof(sAPSelectCalendarWeekweek), required: true);
            SourceExpression.Validate(sAPSelectCalendarWeekyear, nameof(sAPSelectCalendarWeekyear), required: true);
            SourceExpression.Validate(sAPSelectCalendarWeekworkflow, nameof(sAPSelectCalendarWeekworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPSelectCalendarWeek";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPSelectCalendarWeek = new JObject();
                var sAPSelectCalendarWeekpropCount = 0;
                sAPSelectCalendarWeekpropCount++;
                sAPSelectCalendarWeek["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPSelectCalendarWeeksearchSAPElementId);
                sAPSelectCalendarWeekpropCount++;
                sAPSelectCalendarWeek["Week"] = SourceExpressionConverter.ConvertToken(sAPSelectCalendarWeekweek);
                sAPSelectCalendarWeekpropCount++;
                sAPSelectCalendarWeek["Year"] = SourceExpressionConverter.ConvertToken(sAPSelectCalendarWeekyear);
                sAPSelectCalendarWeekpropCount++;
                sAPSelectCalendarWeek["Workflow"] = SourceExpressionConverter.ConvertToken(sAPSelectCalendarWeekworkflow);
                if (sAPSelectCalendarWeekpropCount > 0)
                {
                    callPayload.Body = sAPSelectCalendarWeek;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPSelectCalendarRange([WorkflowExpression] Func<string> sAPSelectCalendarRangesearchSAPElementId, [WorkflowExpression] Func<string> sAPSelectCalendarRangefromDateYYYYMMDD, [WorkflowExpression] Func<string> sAPSelectCalendarRangetoDateYYYYMMDD, [WorkflowExpression] Func<string> sAPSelectCalendarRangeworkflow)
        {
            SourceExpression.Validate(sAPSelectCalendarRangesearchSAPElementId, nameof(sAPSelectCalendarRangesearchSAPElementId), required: true);
            SourceExpression.Validate(sAPSelectCalendarRangefromDateYYYYMMDD, nameof(sAPSelectCalendarRangefromDateYYYYMMDD), required: true);
            SourceExpression.Validate(sAPSelectCalendarRangetoDateYYYYMMDD, nameof(sAPSelectCalendarRangetoDateYYYYMMDD), required: true);
            SourceExpression.Validate(sAPSelectCalendarRangeworkflow, nameof(sAPSelectCalendarRangeworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPSelectCalendarRange";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPSelectCalendarRange = new JObject();
                var sAPSelectCalendarRangepropCount = 0;
                sAPSelectCalendarRangepropCount++;
                sAPSelectCalendarRange["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPSelectCalendarRangesearchSAPElementId);
                sAPSelectCalendarRangepropCount++;
                sAPSelectCalendarRange["FromDateYYYYMMDD"] = SourceExpressionConverter.ConvertToken(sAPSelectCalendarRangefromDateYYYYMMDD);
                sAPSelectCalendarRangepropCount++;
                sAPSelectCalendarRange["ToDateYYYYMMDD"] = SourceExpressionConverter.ConvertToken(sAPSelectCalendarRangetoDateYYYYMMDD);
                sAPSelectCalendarRangepropCount++;
                sAPSelectCalendarRange["Workflow"] = SourceExpressionConverter.ConvertToken(sAPSelectCalendarRangeworkflow);
                if (sAPSelectCalendarRangepropCount > 0)
                {
                    callPayload.Body = sAPSelectCalendarRange;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPFocusCalendarDate([WorkflowExpression] Func<string> sAPFocusCalendarDatesearchSAPElementId, [WorkflowExpression] Func<string> sAPFocusCalendarDatedateYYYYMMDD, [WorkflowExpression] Func<string> sAPFocusCalendarDateworkflow)
        {
            SourceExpression.Validate(sAPFocusCalendarDatesearchSAPElementId, nameof(sAPFocusCalendarDatesearchSAPElementId), required: true);
            SourceExpression.Validate(sAPFocusCalendarDatedateYYYYMMDD, nameof(sAPFocusCalendarDatedateYYYYMMDD), required: true);
            SourceExpression.Validate(sAPFocusCalendarDateworkflow, nameof(sAPFocusCalendarDateworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SAPGUI/SAPFocusCalendarDate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var sAPFocusCalendarDate = new JObject();
                var sAPFocusCalendarDatepropCount = 0;
                sAPFocusCalendarDatepropCount++;
                sAPFocusCalendarDate["SearchSAPElementId"] = SourceExpressionConverter.ConvertToken(sAPFocusCalendarDatesearchSAPElementId);
                sAPFocusCalendarDatepropCount++;
                sAPFocusCalendarDate["DateYYYYMMDD"] = SourceExpressionConverter.ConvertToken(sAPFocusCalendarDatedateYYYYMMDD);
                sAPFocusCalendarDatepropCount++;
                sAPFocusCalendarDate["Workflow"] = SourceExpressionConverter.ConvertToken(sAPFocusCalendarDateworkflow);
                if (sAPFocusCalendarDatepropCount > 0)
                {
                    callPayload.Body = sAPFocusCalendarDate;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
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