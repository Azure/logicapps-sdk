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
        public IWorkflowAction SAPEnableScripting(Expression<Func<string>> sAPEnableScriptingworkflow, Expression<Func<bool>> sAPEnableScriptingnotifyWhenScriptAttachesToGUI = null, Expression<Func<bool>> sAPEnableScriptingnotifyWhenScriptOpensConnection = null, Expression<Func<bool>> sAPEnableScriptingshowNativeWindowsDialogs = null)
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
                    sAPEnableScripting["NotifyWhenScriptAttachesToGUI"] = CSharpExpressionConverter.ConvertToken(sAPEnableScriptingnotifyWhenScriptAttachesToGUI);
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
                    sAPEnableScripting["NotifyWhenScriptOpensConnection"] = CSharpExpressionConverter.ConvertToken(sAPEnableScriptingnotifyWhenScriptOpensConnection);
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
                    sAPEnableScripting["ShowNativeWindowsDialogs"] = CSharpExpressionConverter.ConvertToken(sAPEnableScriptingshowNativeWindowsDialogs);
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
            sAPEnableScripting["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPEnableScriptingworkflow);
            if (sAPEnableScriptingpropCount > 0)
            {
                callPayload.Body = sAPEnableScripting;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPLaunchSAPGUIResponse> SAPLaunchSAPGUI(Expression<Func<string>> sAPLaunchSAPGUIworkflow, Expression<Func<string>> sAPLaunchSAPGUIsAPLogonEXE = null, Expression<Func<string>> sAPLaunchSAPGUIsAPLogonArguments = null, Expression<Func<bool>> sAPLaunchSAPGUIenableSAPScripting = null, Expression<Func<bool>> sAPLaunchSAPGUInotifyWhenScriptAttachesToGUI = null, Expression<Func<bool>> sAPLaunchSAPGUInotifyWhenScriptOpensConnection = null, Expression<Func<bool>> sAPLaunchSAPGUIshowNativeWindowsDialogs = null, Expression<Func<bool>> sAPLaunchSAPGUIattachAfterLaunch = null, Expression<Func<double>> sAPLaunchSAPGUIsecondsToWait = null, Expression<Func<string>> sAPLaunchSAPGUIsAPProgId = null, Expression<Func<bool>> sAPLaunchSAPGUIdisableSystemMessages = null)
        {
            var apiCallPath = "/SAPGUI/SAPLaunchSAPGUI";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPLaunchSAPGUI = new JObject();
            var sAPLaunchSAPGUIpropCount = 0;
            if (sAPLaunchSAPGUIsAPLogonEXE != null)
            {
                sAPLaunchSAPGUI["SAPLogonEXE"] = CSharpExpressionConverter.ConvertToken(sAPLaunchSAPGUIsAPLogonEXE);
                sAPLaunchSAPGUIpropCount++;
            }

            if (sAPLaunchSAPGUIsAPLogonArguments != null)
            {
                sAPLaunchSAPGUI["SAPLogonArguments"] = CSharpExpressionConverter.ConvertToken(sAPLaunchSAPGUIsAPLogonArguments);
                sAPLaunchSAPGUIpropCount++;
            }

            if (sAPLaunchSAPGUIenableSAPScripting != null)
            {
                if (sAPLaunchSAPGUIenableSAPScripting != null)
                {
                    sAPLaunchSAPGUI["EnableSAPScripting"] = CSharpExpressionConverter.ConvertToken(sAPLaunchSAPGUIenableSAPScripting);
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
                    sAPLaunchSAPGUI["NotifyWhenScriptAttachesToGUI"] = CSharpExpressionConverter.ConvertToken(sAPLaunchSAPGUInotifyWhenScriptAttachesToGUI);
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
                    sAPLaunchSAPGUI["NotifyWhenScriptOpensConnection"] = CSharpExpressionConverter.ConvertToken(sAPLaunchSAPGUInotifyWhenScriptOpensConnection);
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
                    sAPLaunchSAPGUI["ShowNativeWindowsDialogs"] = CSharpExpressionConverter.ConvertToken(sAPLaunchSAPGUIshowNativeWindowsDialogs);
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
                    sAPLaunchSAPGUI["AttachAfterLaunch"] = CSharpExpressionConverter.ConvertToken(sAPLaunchSAPGUIattachAfterLaunch);
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
                    sAPLaunchSAPGUI["SecondsToWait"] = CSharpExpressionConverter.ConvertToken(sAPLaunchSAPGUIsecondsToWait);
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
                    sAPLaunchSAPGUI["SAPProgId"] = CSharpExpressionConverter.ConvertToken(sAPLaunchSAPGUIsAPProgId);
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
                    sAPLaunchSAPGUI["DisableSystemMessages"] = CSharpExpressionConverter.ConvertToken(sAPLaunchSAPGUIdisableSystemMessages);
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
            sAPLaunchSAPGUI["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPLaunchSAPGUIworkflow);
            if (sAPLaunchSAPGUIpropCount > 0)
            {
                callPayload.Body = sAPLaunchSAPGUI;
            }

            return new ApiConnectionAction<SAPLaunchSAPGUIResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPAttachToSAPGUIResponse> SAPAttachToSAPGUI(Expression<Func<string>> sAPAttachToSAPGUIworkflow, Expression<Func<string>> sAPAttachToSAPGUIsAPProgId = null, Expression<Func<bool>> sAPAttachToSAPGUIdisableSystemMessages = null)
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
                    sAPAttachToSAPGUI["SAPProgId"] = CSharpExpressionConverter.ConvertToken(sAPAttachToSAPGUIsAPProgId);
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
                    sAPAttachToSAPGUI["DisableSystemMessages"] = CSharpExpressionConverter.ConvertToken(sAPAttachToSAPGUIdisableSystemMessages);
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
            sAPAttachToSAPGUI["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPAttachToSAPGUIworkflow);
            if (sAPAttachToSAPGUIpropCount > 0)
            {
                callPayload.Body = sAPAttachToSAPGUI;
            }

            return new ApiConnectionAction<SAPAttachToSAPGUIResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPDetachFromSAPGUI(Expression<Func<string>> sAPDetachFromSAPGUIworkflow)
        {
            var apiCallPath = "/SAPGUI/SAPDetachFromSAPGUI";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPDetachFromSAPGUI = new JObject();
            var sAPDetachFromSAPGUIpropCount = 0;
            sAPDetachFromSAPGUIpropCount++;
            sAPDetachFromSAPGUI["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPDetachFromSAPGUIworkflow);
            if (sAPDetachFromSAPGUIpropCount > 0)
            {
                callPayload.Body = sAPDetachFromSAPGUI;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetSAPGUIStatusResponse> SAPGetSAPGUIStatus(Expression<Func<string>> sAPGetSAPGUIStatusworkflow)
        {
            var apiCallPath = "/SAPGUI/SAPGetSAPGUIStatus";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPGetSAPGUIStatus = new JObject();
            var sAPGetSAPGUIStatuspropCount = 0;
            sAPGetSAPGUIStatuspropCount++;
            sAPGetSAPGUIStatus["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPGetSAPGUIStatusworkflow);
            if (sAPGetSAPGUIStatuspropCount > 0)
            {
                callPayload.Body = sAPGetSAPGUIStatus;
            }

            return new ApiConnectionAction<SAPGetSAPGUIStatusResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetSAPSessionsResponse> SAPGetSAPSessions(Expression<Func<string>> sAPGetSAPSessionsworkflow)
        {
            var apiCallPath = "/SAPGUI/SAPGetSAPSessions";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPGetSAPSessions = new JObject();
            var sAPGetSAPSessionspropCount = 0;
            sAPGetSAPSessionspropCount++;
            sAPGetSAPSessions["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPGetSAPSessionsworkflow);
            if (sAPGetSAPSessionspropCount > 0)
            {
                callPayload.Body = sAPGetSAPSessions;
            }

            return new ApiConnectionAction<SAPGetSAPSessionsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPAttachToSessionResponse> SAPAttachToSession(Expression<Func<string>> sAPAttachToSessionworkflow, Expression<Func<string>> sAPAttachToSessionsearchConnectionName = null, Expression<Func<string>> sAPAttachToSessionsearchSessionName = null)
        {
            var apiCallPath = "/SAPGUI/SAPAttachToSession";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPAttachToSession = new JObject();
            var sAPAttachToSessionpropCount = 0;
            if (sAPAttachToSessionsearchConnectionName != null)
            {
                sAPAttachToSession["SearchConnectionName"] = CSharpExpressionConverter.ConvertToken(sAPAttachToSessionsearchConnectionName);
                sAPAttachToSessionpropCount++;
            }

            if (sAPAttachToSessionsearchSessionName != null)
            {
                sAPAttachToSession["SearchSessionName"] = CSharpExpressionConverter.ConvertToken(sAPAttachToSessionsearchSessionName);
                sAPAttachToSessionpropCount++;
            }

            sAPAttachToSessionpropCount++;
            sAPAttachToSession["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPAttachToSessionworkflow);
            if (sAPAttachToSessionpropCount > 0)
            {
                callPayload.Body = sAPAttachToSession;
            }

            return new ApiConnectionAction<SAPAttachToSessionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPCloseSession(Expression<Func<string>> sAPCloseSessionworkflow, Expression<Func<bool>> sAPCloseSessioncloseAttachedSession = null, Expression<Func<string>> sAPCloseSessionsearchConnectionName = null, Expression<Func<string>> sAPCloseSessionsearchSessionName = null)
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
                    sAPCloseSession["CloseAttachedSession"] = CSharpExpressionConverter.ConvertToken(sAPCloseSessioncloseAttachedSession);
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
                sAPCloseSession["SearchConnectionName"] = CSharpExpressionConverter.ConvertToken(sAPCloseSessionsearchConnectionName);
                sAPCloseSessionpropCount++;
            }

            if (sAPCloseSessionsearchSessionName != null)
            {
                sAPCloseSession["SearchSessionName"] = CSharpExpressionConverter.ConvertToken(sAPCloseSessionsearchSessionName);
                sAPCloseSessionpropCount++;
            }

            sAPCloseSessionpropCount++;
            sAPCloseSession["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPCloseSessionworkflow);
            if (sAPCloseSessionpropCount > 0)
            {
                callPayload.Body = sAPCloseSession;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetAttachedSessionPropertiesResponse> SAPGetAttachedSessionProperties(Expression<Func<string>> sAPGetAttachedSessionPropertiesworkflow)
        {
            var apiCallPath = "/SAPGUI/SAPGetAttachedSessionProperties";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPGetAttachedSessionProperties = new JObject();
            var sAPGetAttachedSessionPropertiespropCount = 0;
            sAPGetAttachedSessionPropertiespropCount++;
            sAPGetAttachedSessionProperties["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPGetAttachedSessionPropertiesworkflow);
            if (sAPGetAttachedSessionPropertiespropCount > 0)
            {
                callPayload.Body = sAPGetAttachedSessionProperties;
            }

            return new ApiConnectionAction<SAPGetAttachedSessionPropertiesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPWaitForAttachedSessionNotBusyResponse> SAPWaitForAttachedSessionNotBusy(Expression<Func<double>> sAPWaitForAttachedSessionNotBusysecondsToWait, Expression<Func<string>> sAPWaitForAttachedSessionNotBusyworkflow, Expression<Func<bool>> sAPWaitForAttachedSessionNotBusyraiseExceptionIfBusyAfterWait = null)
        {
            var apiCallPath = "/SAPGUI/SAPWaitForAttachedSessionNotBusy";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPWaitForAttachedSessionNotBusy = new JObject();
            var sAPWaitForAttachedSessionNotBusypropCount = 0;
            sAPWaitForAttachedSessionNotBusypropCount++;
            sAPWaitForAttachedSessionNotBusy["SecondsToWait"] = CSharpExpressionConverter.ConvertToken(sAPWaitForAttachedSessionNotBusysecondsToWait);
            if (sAPWaitForAttachedSessionNotBusyraiseExceptionIfBusyAfterWait != null)
            {
                if (sAPWaitForAttachedSessionNotBusyraiseExceptionIfBusyAfterWait != null)
                {
                    sAPWaitForAttachedSessionNotBusy["RaiseExceptionIfBusyAfterWait"] = CSharpExpressionConverter.ConvertToken(sAPWaitForAttachedSessionNotBusyraiseExceptionIfBusyAfterWait);
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
            sAPWaitForAttachedSessionNotBusy["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPWaitForAttachedSessionNotBusyworkflow);
            if (sAPWaitForAttachedSessionNotBusypropCount > 0)
            {
                callPayload.Body = sAPWaitForAttachedSessionNotBusy;
            }

            return new ApiConnectionAction<SAPWaitForAttachedSessionNotBusyResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPInputTextIntoSAPElement(Expression<Func<string>> sAPInputTextIntoSAPElementsearchSAPElementId, Expression<Func<string>> sAPInputTextIntoSAPElementworkflow, Expression<Func<string>> sAPInputTextIntoSAPElementtextToInput = null, Expression<Func<bool>> sAPInputTextIntoSAPElementreplaceExistingValue = null, Expression<Func<int>> sAPInputTextIntoSAPElementinsertPosition = null)
        {
            var apiCallPath = "/SAPGUI/SAPInputTextIntoSAPElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPInputTextIntoSAPElement = new JObject();
            var sAPInputTextIntoSAPElementpropCount = 0;
            sAPInputTextIntoSAPElementpropCount++;
            sAPInputTextIntoSAPElement["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPInputTextIntoSAPElementsearchSAPElementId);
            if (sAPInputTextIntoSAPElementtextToInput != null)
            {
                sAPInputTextIntoSAPElement["TextToInput"] = CSharpExpressionConverter.ConvertToken(sAPInputTextIntoSAPElementtextToInput);
                sAPInputTextIntoSAPElementpropCount++;
            }

            if (sAPInputTextIntoSAPElementreplaceExistingValue != null)
            {
                if (sAPInputTextIntoSAPElementreplaceExistingValue != null)
                {
                    sAPInputTextIntoSAPElement["ReplaceExistingValue"] = CSharpExpressionConverter.ConvertToken(sAPInputTextIntoSAPElementreplaceExistingValue);
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
                    sAPInputTextIntoSAPElement["InsertPosition"] = CSharpExpressionConverter.ConvertToken(sAPInputTextIntoSAPElementinsertPosition);
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
            sAPInputTextIntoSAPElement["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPInputTextIntoSAPElementworkflow);
            if (sAPInputTextIntoSAPElementpropCount > 0)
            {
                callPayload.Body = sAPInputTextIntoSAPElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPInputPasswordIntoSAPElement(Expression<Func<string>> sAPInputPasswordIntoSAPElementsearchSAPElementId, Expression<Func<string>> sAPInputPasswordIntoSAPElementpasswordToInput, Expression<Func<string>> sAPInputPasswordIntoSAPElementworkflow)
        {
            var apiCallPath = "/SAPGUI/SAPInputPasswordIntoSAPElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPInputPasswordIntoSAPElement = new JObject();
            var sAPInputPasswordIntoSAPElementpropCount = 0;
            sAPInputPasswordIntoSAPElementpropCount++;
            sAPInputPasswordIntoSAPElement["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPInputPasswordIntoSAPElementsearchSAPElementId);
            sAPInputPasswordIntoSAPElementpropCount++;
            sAPInputPasswordIntoSAPElement["PasswordToInput"] = CSharpExpressionConverter.ConvertToken(sAPInputPasswordIntoSAPElementpasswordToInput);
            sAPInputPasswordIntoSAPElementpropCount++;
            sAPInputPasswordIntoSAPElement["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPInputPasswordIntoSAPElementworkflow);
            if (sAPInputPasswordIntoSAPElementpropCount > 0)
            {
                callPayload.Body = sAPInputPasswordIntoSAPElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetElementPropertiesResponse> SAPGetElementProperties(Expression<Func<string>> sAPGetElementPropertiessearchSAPElementId, Expression<Func<string>> sAPGetElementPropertiesworkflow)
        {
            var apiCallPath = "/SAPGUI/SAPGetElementProperties";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPGetElementProperties = new JObject();
            var sAPGetElementPropertiespropCount = 0;
            sAPGetElementPropertiespropCount++;
            sAPGetElementProperties["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPGetElementPropertiessearchSAPElementId);
            sAPGetElementPropertiespropCount++;
            sAPGetElementProperties["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPGetElementPropertiesworkflow);
            if (sAPGetElementPropertiespropCount > 0)
            {
                callPayload.Body = sAPGetElementProperties;
            }

            return new ApiConnectionAction<SAPGetElementPropertiesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPWaitForElementIdResponse> SAPWaitForElementId(Expression<Func<string>> sAPWaitForElementIdsearchSAPElementId, Expression<Func<string>> sAPWaitForElementIdworkflow, Expression<Func<double>> sAPWaitForElementIdsecondsToWait = null, Expression<Func<bool>> sAPWaitForElementIdraiseExceptionIfElementNotFound = null)
        {
            var apiCallPath = "/SAPGUI/SAPWaitForElementId";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPWaitForElementId = new JObject();
            var sAPWaitForElementIdpropCount = 0;
            sAPWaitForElementIdpropCount++;
            sAPWaitForElementId["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPWaitForElementIdsearchSAPElementId);
            if (sAPWaitForElementIdsecondsToWait != null)
            {
                if (sAPWaitForElementIdsecondsToWait != null)
                {
                    sAPWaitForElementId["SecondsToWait"] = CSharpExpressionConverter.ConvertToken(sAPWaitForElementIdsecondsToWait);
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
                    sAPWaitForElementId["RaiseExceptionIfElementNotFound"] = CSharpExpressionConverter.ConvertToken(sAPWaitForElementIdraiseExceptionIfElementNotFound);
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
            sAPWaitForElementId["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPWaitForElementIdworkflow);
            if (sAPWaitForElementIdpropCount > 0)
            {
                callPayload.Body = sAPWaitForElementId;
            }

            return new ApiConnectionAction<SAPWaitForElementIdResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPWaitForWindowResponse> SAPWaitForWindow(Expression<Func<string>> sAPWaitForWindowsearchSAPWindowTitle, Expression<Func<string>> sAPWaitForWindowworkflow, Expression<Func<bool>> sAPWaitForWindowsearchIsRegularExpression = null, Expression<Func<bool>> sAPWaitForWindowsearchIsCaseSensitive = null, Expression<Func<double>> sAPWaitForWindowsecondsToWait = null, Expression<Func<bool>> sAPWaitForWindowraiseExceptionIfElementNotFound = null)
        {
            var apiCallPath = "/SAPGUI/SAPWaitForWindow";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPWaitForWindow = new JObject();
            var sAPWaitForWindowpropCount = 0;
            sAPWaitForWindowpropCount++;
            sAPWaitForWindow["SearchSAPWindowTitle"] = CSharpExpressionConverter.ConvertToken(sAPWaitForWindowsearchSAPWindowTitle);
            if (sAPWaitForWindowsearchIsRegularExpression != null)
            {
                if (sAPWaitForWindowsearchIsRegularExpression != null)
                {
                    sAPWaitForWindow["SearchIsRegularExpression"] = CSharpExpressionConverter.ConvertToken(sAPWaitForWindowsearchIsRegularExpression);
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
                    sAPWaitForWindow["SearchIsCaseSensitive"] = CSharpExpressionConverter.ConvertToken(sAPWaitForWindowsearchIsCaseSensitive);
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
                    sAPWaitForWindow["SecondsToWait"] = CSharpExpressionConverter.ConvertToken(sAPWaitForWindowsecondsToWait);
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
                    sAPWaitForWindow["RaiseExceptionIfElementNotFound"] = CSharpExpressionConverter.ConvertToken(sAPWaitForWindowraiseExceptionIfElementNotFound);
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
            sAPWaitForWindow["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPWaitForWindowworkflow);
            if (sAPWaitForWindowpropCount > 0)
            {
                callPayload.Body = sAPWaitForWindow;
            }

            return new ApiConnectionAction<SAPWaitForWindowResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetElementTextValueResponse> SAPGetElementTextValue(Expression<Func<string>> sAPGetElementTextValuesearchSAPElementId, Expression<Func<string>> sAPGetElementTextValueworkflow)
        {
            var apiCallPath = "/SAPGUI/SAPGetElementTextValue";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPGetElementTextValue = new JObject();
            var sAPGetElementTextValuepropCount = 0;
            sAPGetElementTextValuepropCount++;
            sAPGetElementTextValue["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPGetElementTextValuesearchSAPElementId);
            sAPGetElementTextValuepropCount++;
            sAPGetElementTextValue["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPGetElementTextValueworkflow);
            if (sAPGetElementTextValuepropCount > 0)
            {
                callPayload.Body = sAPGetElementTextValue;
            }

            return new ApiConnectionAction<SAPGetElementTextValueResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPPressSAPElement(Expression<Func<string>> sAPPressSAPElementsearchSAPElementId, Expression<Func<string>> sAPPressSAPElementworkflow)
        {
            var apiCallPath = "/SAPGUI/SAPPressSAPElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPPressSAPElement = new JObject();
            var sAPPressSAPElementpropCount = 0;
            sAPPressSAPElementpropCount++;
            sAPPressSAPElement["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPPressSAPElementsearchSAPElementId);
            sAPPressSAPElementpropCount++;
            sAPPressSAPElement["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPPressSAPElementworkflow);
            if (sAPPressSAPElementpropCount > 0)
            {
                callPayload.Body = sAPPressSAPElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPSelectSAPElement(Expression<Func<string>> sAPSelectSAPElementsearchSAPElementId, Expression<Func<string>> sAPSelectSAPElementworkflow)
        {
            var apiCallPath = "/SAPGUI/SAPSelectSAPElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPSelectSAPElement = new JObject();
            var sAPSelectSAPElementpropCount = 0;
            sAPSelectSAPElementpropCount++;
            sAPSelectSAPElement["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPSelectSAPElementsearchSAPElementId);
            sAPSelectSAPElementpropCount++;
            sAPSelectSAPElement["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPSelectSAPElementworkflow);
            if (sAPSelectSAPElementpropCount > 0)
            {
                callPayload.Body = sAPSelectSAPElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPFocusSAPElement(Expression<Func<string>> sAPFocusSAPElementsearchSAPElementId, Expression<Func<string>> sAPFocusSAPElementworkflow)
        {
            var apiCallPath = "/SAPGUI/SAPFocusSAPElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPFocusSAPElement = new JObject();
            var sAPFocusSAPElementpropCount = 0;
            sAPFocusSAPElementpropCount++;
            sAPFocusSAPElement["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPFocusSAPElementsearchSAPElementId);
            sAPFocusSAPElementpropCount++;
            sAPFocusSAPElement["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPFocusSAPElementworkflow);
            if (sAPFocusSAPElementpropCount > 0)
            {
                callPayload.Body = sAPFocusSAPElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPCheckSAPElement(Expression<Func<string>> sAPCheckSAPElementsearchSAPElementId, Expression<Func<string>> sAPCheckSAPElementworkflow, Expression<Func<bool>> sAPCheckSAPElementcheckElement = null)
        {
            var apiCallPath = "/SAPGUI/SAPCheckSAPElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPCheckSAPElement = new JObject();
            var sAPCheckSAPElementpropCount = 0;
            sAPCheckSAPElementpropCount++;
            sAPCheckSAPElement["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPCheckSAPElementsearchSAPElementId);
            if (sAPCheckSAPElementcheckElement != null)
            {
                if (sAPCheckSAPElementcheckElement != null)
                {
                    sAPCheckSAPElement["CheckElement"] = CSharpExpressionConverter.ConvertToken(sAPCheckSAPElementcheckElement);
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
            sAPCheckSAPElement["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPCheckSAPElementworkflow);
            if (sAPCheckSAPElementpropCount > 0)
            {
                callPayload.Body = sAPCheckSAPElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPVisualiseSAPElement(Expression<Func<string>> sAPVisualiseSAPElementsearchSAPElementId, Expression<Func<string>> sAPVisualiseSAPElementworkflow, Expression<Func<bool>> sAPVisualiseSAPElementvisualiseOn = null)
        {
            var apiCallPath = "/SAPGUI/SAPVisualiseSAPElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPVisualiseSAPElement = new JObject();
            var sAPVisualiseSAPElementpropCount = 0;
            sAPVisualiseSAPElementpropCount++;
            sAPVisualiseSAPElement["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPVisualiseSAPElementsearchSAPElementId);
            if (sAPVisualiseSAPElementvisualiseOn != null)
            {
                if (sAPVisualiseSAPElementvisualiseOn != null)
                {
                    sAPVisualiseSAPElement["VisualiseOn"] = CSharpExpressionConverter.ConvertToken(sAPVisualiseSAPElementvisualiseOn);
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
            sAPVisualiseSAPElement["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPVisualiseSAPElementworkflow);
            if (sAPVisualiseSAPElementpropCount > 0)
            {
                callPayload.Body = sAPVisualiseSAPElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPDrawRectangleAroundSAPElement(Expression<Func<string>> sAPDrawRectangleAroundSAPElementsearchSAPElementId, Expression<Func<string>> sAPDrawRectangleAroundSAPElementworkflow, Expression<Func<string>> sAPDrawRectangleAroundSAPElementpenColour = null, Expression<Func<int>> sAPDrawRectangleAroundSAPElementpenThicknessPixels = null)
        {
            var apiCallPath = "/SAPGUI/SAPDrawRectangleAroundSAPElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPDrawRectangleAroundSAPElement = new JObject();
            var sAPDrawRectangleAroundSAPElementpropCount = 0;
            sAPDrawRectangleAroundSAPElementpropCount++;
            sAPDrawRectangleAroundSAPElement["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPDrawRectangleAroundSAPElementsearchSAPElementId);
            if (sAPDrawRectangleAroundSAPElementpenColour != null)
            {
                if (sAPDrawRectangleAroundSAPElementpenColour != null)
                {
                    sAPDrawRectangleAroundSAPElement["PenColour"] = CSharpExpressionConverter.ConvertToken(sAPDrawRectangleAroundSAPElementpenColour);
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
                    sAPDrawRectangleAroundSAPElement["PenThicknessPixels"] = CSharpExpressionConverter.ConvertToken(sAPDrawRectangleAroundSAPElementpenThicknessPixels);
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
            sAPDrawRectangleAroundSAPElement["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPDrawRectangleAroundSAPElementworkflow);
            if (sAPDrawRectangleAroundSAPElementpropCount > 0)
            {
                callPayload.Body = sAPDrawRectangleAroundSAPElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPSendCommand(Expression<Func<string>> sAPSendCommandsAPCommand, Expression<Func<string>> sAPSendCommandworkflow)
        {
            var apiCallPath = "/SAPGUI/SAPSendCommand";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPSendCommand = new JObject();
            var sAPSendCommandpropCount = 0;
            sAPSendCommandpropCount++;
            sAPSendCommand["SAPCommand"] = CSharpExpressionConverter.ConvertToken(sAPSendCommandsAPCommand);
            sAPSendCommandpropCount++;
            sAPSendCommand["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPSendCommandworkflow);
            if (sAPSendCommandpropCount > 0)
            {
                callPayload.Body = sAPSendCommand;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPEnterTCode(Expression<Func<string>> sAPEnterTCodesAPTCode, Expression<Func<string>> sAPEnterTCodeworkflow)
        {
            var apiCallPath = "/SAPGUI/SAPEnterTCode";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPEnterTCode = new JObject();
            var sAPEnterTCodepropCount = 0;
            sAPEnterTCodepropCount++;
            sAPEnterTCode["SAPTCode"] = CSharpExpressionConverter.ConvertToken(sAPEnterTCodesAPTCode);
            sAPEnterTCodepropCount++;
            sAPEnterTCode["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPEnterTCodeworkflow);
            if (sAPEnterTCodepropCount > 0)
            {
                callPayload.Body = sAPEnterTCode;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPSendVKey(Expression<Func<string>> sAPSendVKeysearchSAPElementId, Expression<Func<int>> sAPSendVKeysAPVKey, Expression<Func<string>> sAPSendVKeyworkflow, Expression<Func<bool>> sAPSendVKeydetectParentWindowElement = null)
        {
            var apiCallPath = "/SAPGUI/SAPSendVKey";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPSendVKey = new JObject();
            var sAPSendVKeypropCount = 0;
            sAPSendVKeypropCount++;
            sAPSendVKey["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPSendVKeysearchSAPElementId);
            sAPSendVKeypropCount++;
            sAPSendVKey["SAPVKey"] = CSharpExpressionConverter.ConvertToken(sAPSendVKeysAPVKey);
            if (sAPSendVKeydetectParentWindowElement != null)
            {
                if (sAPSendVKeydetectParentWindowElement != null)
                {
                    sAPSendVKey["DetectParentWindowElement"] = CSharpExpressionConverter.ConvertToken(sAPSendVKeydetectParentWindowElement);
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
            sAPSendVKey["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPSendVKeyworkflow);
            if (sAPSendVKeypropCount > 0)
            {
                callPayload.Body = sAPSendVKey;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPSendEnterVKey(Expression<Func<string>> sAPSendEnterVKeysearchSAPElementId, Expression<Func<string>> sAPSendEnterVKeyworkflow, Expression<Func<bool>> sAPSendEnterVKeydetectParentWindowElement = null)
        {
            var apiCallPath = "/SAPGUI/SAPSendEnterVKey";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPSendEnterVKey = new JObject();
            var sAPSendEnterVKeypropCount = 0;
            sAPSendEnterVKeypropCount++;
            sAPSendEnterVKey["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPSendEnterVKeysearchSAPElementId);
            if (sAPSendEnterVKeydetectParentWindowElement != null)
            {
                if (sAPSendEnterVKeydetectParentWindowElement != null)
                {
                    sAPSendEnterVKey["DetectParentWindowElement"] = CSharpExpressionConverter.ConvertToken(sAPSendEnterVKeydetectParentWindowElement);
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
            sAPSendEnterVKey["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPSendEnterVKeyworkflow);
            if (sAPSendEnterVKeypropCount > 0)
            {
                callPayload.Body = sAPSendEnterVKey;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPWindowRestore(Expression<Func<string>> sAPWindowRestoresearchSAPElementId, Expression<Func<string>> sAPWindowRestoreworkflow, Expression<Func<bool>> sAPWindowRestoredetectParentWindowElement = null)
        {
            var apiCallPath = "/SAPGUI/SAPWindowRestore";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPWindowRestore = new JObject();
            var sAPWindowRestorepropCount = 0;
            sAPWindowRestorepropCount++;
            sAPWindowRestore["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPWindowRestoresearchSAPElementId);
            if (sAPWindowRestoredetectParentWindowElement != null)
            {
                if (sAPWindowRestoredetectParentWindowElement != null)
                {
                    sAPWindowRestore["DetectParentWindowElement"] = CSharpExpressionConverter.ConvertToken(sAPWindowRestoredetectParentWindowElement);
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
            sAPWindowRestore["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPWindowRestoreworkflow);
            if (sAPWindowRestorepropCount > 0)
            {
                callPayload.Body = sAPWindowRestore;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPWindowMaximise(Expression<Func<string>> sAPWindowMaximisesearchSAPElementId, Expression<Func<string>> sAPWindowMaximiseworkflow, Expression<Func<bool>> sAPWindowMaximisedetectParentWindowElement = null)
        {
            var apiCallPath = "/SAPGUI/SAPWindowMaximise";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPWindowMaximise = new JObject();
            var sAPWindowMaximisepropCount = 0;
            sAPWindowMaximisepropCount++;
            sAPWindowMaximise["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPWindowMaximisesearchSAPElementId);
            if (sAPWindowMaximisedetectParentWindowElement != null)
            {
                if (sAPWindowMaximisedetectParentWindowElement != null)
                {
                    sAPWindowMaximise["DetectParentWindowElement"] = CSharpExpressionConverter.ConvertToken(sAPWindowMaximisedetectParentWindowElement);
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
            sAPWindowMaximise["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPWindowMaximiseworkflow);
            if (sAPWindowMaximisepropCount > 0)
            {
                callPayload.Body = sAPWindowMaximise;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPWindowMinimise(Expression<Func<string>> sAPWindowMinimisesearchSAPElementId, Expression<Func<string>> sAPWindowMinimiseworkflow, Expression<Func<bool>> sAPWindowMinimisedetectParentWindowElement = null)
        {
            var apiCallPath = "/SAPGUI/SAPWindowMinimise";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPWindowMinimise = new JObject();
            var sAPWindowMinimisepropCount = 0;
            sAPWindowMinimisepropCount++;
            sAPWindowMinimise["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPWindowMinimisesearchSAPElementId);
            if (sAPWindowMinimisedetectParentWindowElement != null)
            {
                if (sAPWindowMinimisedetectParentWindowElement != null)
                {
                    sAPWindowMinimise["DetectParentWindowElement"] = CSharpExpressionConverter.ConvertToken(sAPWindowMinimisedetectParentWindowElement);
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
            sAPWindowMinimise["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPWindowMinimiseworkflow);
            if (sAPWindowMinimisepropCount > 0)
            {
                callPayload.Body = sAPWindowMinimise;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPWindowClose(Expression<Func<string>> sAPWindowClosesearchSAPElementId, Expression<Func<string>> sAPWindowCloseworkflow, Expression<Func<bool>> sAPWindowClosedetectParentWindowElement = null)
        {
            var apiCallPath = "/SAPGUI/SAPWindowClose";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPWindowClose = new JObject();
            var sAPWindowClosepropCount = 0;
            sAPWindowClosepropCount++;
            sAPWindowClose["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPWindowClosesearchSAPElementId);
            if (sAPWindowClosedetectParentWindowElement != null)
            {
                if (sAPWindowClosedetectParentWindowElement != null)
                {
                    sAPWindowClose["DetectParentWindowElement"] = CSharpExpressionConverter.ConvertToken(sAPWindowClosedetectParentWindowElement);
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
            sAPWindowClose["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPWindowCloseworkflow);
            if (sAPWindowClosepropCount > 0)
            {
                callPayload.Body = sAPWindowClose;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPBringWindowToFront(Expression<Func<string>> sAPBringWindowToFrontsearchSAPElementId, Expression<Func<string>> sAPBringWindowToFrontworkflow, Expression<Func<bool>> sAPBringWindowToFronttoggleWindow = null, Expression<Func<bool>> sAPBringWindowToFronttoggleUsesGlobalLeftMouseClickAgent = null, Expression<Func<double>> sAPBringWindowToFronttoggleDelay = null, Expression<Func<bool>> sAPBringWindowToFrontdetectParentWindowElement = null)
        {
            var apiCallPath = "/SAPGUI/SAPBringWindowToFront";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPBringWindowToFront = new JObject();
            var sAPBringWindowToFrontpropCount = 0;
            sAPBringWindowToFrontpropCount++;
            sAPBringWindowToFront["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPBringWindowToFrontsearchSAPElementId);
            if (sAPBringWindowToFronttoggleWindow != null)
            {
                if (sAPBringWindowToFronttoggleWindow != null)
                {
                    sAPBringWindowToFront["ToggleWindow"] = CSharpExpressionConverter.ConvertToken(sAPBringWindowToFronttoggleWindow);
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
                    sAPBringWindowToFront["ToggleUsesGlobalLeftMouseClickAgent"] = CSharpExpressionConverter.ConvertToken(sAPBringWindowToFronttoggleUsesGlobalLeftMouseClickAgent);
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
                    sAPBringWindowToFront["ToggleDelay"] = CSharpExpressionConverter.ConvertToken(sAPBringWindowToFronttoggleDelay);
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
                    sAPBringWindowToFront["DetectParentWindowElement"] = CSharpExpressionConverter.ConvertToken(sAPBringWindowToFrontdetectParentWindowElement);
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
            sAPBringWindowToFront["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPBringWindowToFrontworkflow);
            if (sAPBringWindowToFrontpropCount > 0)
            {
                callPayload.Body = sAPBringWindowToFront;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPGlobalLeftMouseClickOnSAPElement(Expression<Func<string>> sAPGlobalLeftMouseClickOnSAPElementsearchSAPElementId, Expression<Func<string>> sAPGlobalLeftMouseClickOnSAPElementworkflow, Expression<Func<bool>> sAPGlobalLeftMouseClickOnSAPElementsetElementWindowTopMost = null, Expression<Func<bool>> sAPGlobalLeftMouseClickOnSAPElementbringElementWindowToFront = null, Expression<Func<bool>> sAPGlobalLeftMouseClickOnSAPElementtoggleWindow = null, Expression<Func<bool>> sAPGlobalLeftMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent = null, Expression<Func<double>> sAPGlobalLeftMouseClickOnSAPElementtoggleDelay = null, Expression<Func<int>> sAPGlobalLeftMouseClickOnSAPElementclickOffsetX = null, Expression<Func<int>> sAPGlobalLeftMouseClickOnSAPElementclickOffsetY = null, Expression<Func<sAPGlobalLeftMouseClickOnSAPElementoffsetRelativeToInput>> sAPGlobalLeftMouseClickOnSAPElementoffsetRelativeTo = null)
        {
            var apiCallPath = "/SAPGUI/SAPGlobalLeftMouseClickOnSAPElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPGlobalLeftMouseClickOnSAPElement = new JObject();
            var sAPGlobalLeftMouseClickOnSAPElementpropCount = 0;
            sAPGlobalLeftMouseClickOnSAPElementpropCount++;
            sAPGlobalLeftMouseClickOnSAPElement["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPGlobalLeftMouseClickOnSAPElementsearchSAPElementId);
            if (sAPGlobalLeftMouseClickOnSAPElementsetElementWindowTopMost != null)
            {
                if (sAPGlobalLeftMouseClickOnSAPElementsetElementWindowTopMost != null)
                {
                    sAPGlobalLeftMouseClickOnSAPElement["SetElementWindowTopMost"] = CSharpExpressionConverter.ConvertToken(sAPGlobalLeftMouseClickOnSAPElementsetElementWindowTopMost);
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
                    sAPGlobalLeftMouseClickOnSAPElement["BringElementWindowToFront"] = CSharpExpressionConverter.ConvertToken(sAPGlobalLeftMouseClickOnSAPElementbringElementWindowToFront);
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
                    sAPGlobalLeftMouseClickOnSAPElement["ToggleWindow"] = CSharpExpressionConverter.ConvertToken(sAPGlobalLeftMouseClickOnSAPElementtoggleWindow);
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
                    sAPGlobalLeftMouseClickOnSAPElement["ToggleUsesGlobalLeftMouseClickAgent"] = CSharpExpressionConverter.ConvertToken(sAPGlobalLeftMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent);
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
                    sAPGlobalLeftMouseClickOnSAPElement["ToggleDelay"] = CSharpExpressionConverter.ConvertToken(sAPGlobalLeftMouseClickOnSAPElementtoggleDelay);
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
                    sAPGlobalLeftMouseClickOnSAPElement["ClickOffsetX"] = CSharpExpressionConverter.ConvertToken(sAPGlobalLeftMouseClickOnSAPElementclickOffsetX);
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
                    sAPGlobalLeftMouseClickOnSAPElement["ClickOffsetY"] = CSharpExpressionConverter.ConvertToken(sAPGlobalLeftMouseClickOnSAPElementclickOffsetY);
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
                sAPGlobalLeftMouseClickOnSAPElement["OffsetRelativeTo"] = CSharpExpressionConverter.Convert(sAPGlobalLeftMouseClickOnSAPElementoffsetRelativeTo);
                sAPGlobalLeftMouseClickOnSAPElementpropCount++;
            }

            sAPGlobalLeftMouseClickOnSAPElementpropCount++;
            sAPGlobalLeftMouseClickOnSAPElement["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPGlobalLeftMouseClickOnSAPElementworkflow);
            if (sAPGlobalLeftMouseClickOnSAPElementpropCount > 0)
            {
                callPayload.Body = sAPGlobalLeftMouseClickOnSAPElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPGlobalRightMouseClickOnSAPElement(Expression<Func<string>> sAPGlobalRightMouseClickOnSAPElementsearchSAPElementId, Expression<Func<string>> sAPGlobalRightMouseClickOnSAPElementworkflow, Expression<Func<bool>> sAPGlobalRightMouseClickOnSAPElementsetElementWindowTopMost = null, Expression<Func<bool>> sAPGlobalRightMouseClickOnSAPElementbringElementWindowToFront = null, Expression<Func<bool>> sAPGlobalRightMouseClickOnSAPElementtoggleWindow = null, Expression<Func<bool>> sAPGlobalRightMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent = null, Expression<Func<double>> sAPGlobalRightMouseClickOnSAPElementtoggleDelay = null, Expression<Func<int>> sAPGlobalRightMouseClickOnSAPElementclickOffsetX = null, Expression<Func<int>> sAPGlobalRightMouseClickOnSAPElementclickOffsetY = null, Expression<Func<sAPGlobalRightMouseClickOnSAPElementoffsetRelativeToInput>> sAPGlobalRightMouseClickOnSAPElementoffsetRelativeTo = null)
        {
            var apiCallPath = "/SAPGUI/SAPGlobalRightMouseClickOnSAPElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPGlobalRightMouseClickOnSAPElement = new JObject();
            var sAPGlobalRightMouseClickOnSAPElementpropCount = 0;
            sAPGlobalRightMouseClickOnSAPElementpropCount++;
            sAPGlobalRightMouseClickOnSAPElement["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPGlobalRightMouseClickOnSAPElementsearchSAPElementId);
            if (sAPGlobalRightMouseClickOnSAPElementsetElementWindowTopMost != null)
            {
                if (sAPGlobalRightMouseClickOnSAPElementsetElementWindowTopMost != null)
                {
                    sAPGlobalRightMouseClickOnSAPElement["SetElementWindowTopMost"] = CSharpExpressionConverter.ConvertToken(sAPGlobalRightMouseClickOnSAPElementsetElementWindowTopMost);
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
                    sAPGlobalRightMouseClickOnSAPElement["BringElementWindowToFront"] = CSharpExpressionConverter.ConvertToken(sAPGlobalRightMouseClickOnSAPElementbringElementWindowToFront);
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
                    sAPGlobalRightMouseClickOnSAPElement["ToggleWindow"] = CSharpExpressionConverter.ConvertToken(sAPGlobalRightMouseClickOnSAPElementtoggleWindow);
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
                    sAPGlobalRightMouseClickOnSAPElement["ToggleUsesGlobalLeftMouseClickAgent"] = CSharpExpressionConverter.ConvertToken(sAPGlobalRightMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent);
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
                    sAPGlobalRightMouseClickOnSAPElement["ToggleDelay"] = CSharpExpressionConverter.ConvertToken(sAPGlobalRightMouseClickOnSAPElementtoggleDelay);
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
                    sAPGlobalRightMouseClickOnSAPElement["ClickOffsetX"] = CSharpExpressionConverter.ConvertToken(sAPGlobalRightMouseClickOnSAPElementclickOffsetX);
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
                    sAPGlobalRightMouseClickOnSAPElement["ClickOffsetY"] = CSharpExpressionConverter.ConvertToken(sAPGlobalRightMouseClickOnSAPElementclickOffsetY);
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
                sAPGlobalRightMouseClickOnSAPElement["OffsetRelativeTo"] = CSharpExpressionConverter.Convert(sAPGlobalRightMouseClickOnSAPElementoffsetRelativeTo);
                sAPGlobalRightMouseClickOnSAPElementpropCount++;
            }

            sAPGlobalRightMouseClickOnSAPElementpropCount++;
            sAPGlobalRightMouseClickOnSAPElement["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPGlobalRightMouseClickOnSAPElementworkflow);
            if (sAPGlobalRightMouseClickOnSAPElementpropCount > 0)
            {
                callPayload.Body = sAPGlobalRightMouseClickOnSAPElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPGlobalMiddleMouseClickOnSAPElement(Expression<Func<string>> sAPGlobalMiddleMouseClickOnSAPElementsearchSAPElementId, Expression<Func<string>> sAPGlobalMiddleMouseClickOnSAPElementworkflow, Expression<Func<bool>> sAPGlobalMiddleMouseClickOnSAPElementsetElementWindowTopMost = null, Expression<Func<bool>> sAPGlobalMiddleMouseClickOnSAPElementbringElementWindowToFront = null, Expression<Func<bool>> sAPGlobalMiddleMouseClickOnSAPElementtoggleWindow = null, Expression<Func<bool>> sAPGlobalMiddleMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent = null, Expression<Func<double>> sAPGlobalMiddleMouseClickOnSAPElementtoggleDelay = null, Expression<Func<int>> sAPGlobalMiddleMouseClickOnSAPElementclickOffsetX = null, Expression<Func<int>> sAPGlobalMiddleMouseClickOnSAPElementclickOffsetY = null, Expression<Func<sAPGlobalMiddleMouseClickOnSAPElementoffsetRelativeToInput>> sAPGlobalMiddleMouseClickOnSAPElementoffsetRelativeTo = null)
        {
            var apiCallPath = "/SAPGUI/SAPGlobalMiddleMouseClickOnSAPElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPGlobalMiddleMouseClickOnSAPElement = new JObject();
            var sAPGlobalMiddleMouseClickOnSAPElementpropCount = 0;
            sAPGlobalMiddleMouseClickOnSAPElementpropCount++;
            sAPGlobalMiddleMouseClickOnSAPElement["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPGlobalMiddleMouseClickOnSAPElementsearchSAPElementId);
            if (sAPGlobalMiddleMouseClickOnSAPElementsetElementWindowTopMost != null)
            {
                if (sAPGlobalMiddleMouseClickOnSAPElementsetElementWindowTopMost != null)
                {
                    sAPGlobalMiddleMouseClickOnSAPElement["SetElementWindowTopMost"] = CSharpExpressionConverter.ConvertToken(sAPGlobalMiddleMouseClickOnSAPElementsetElementWindowTopMost);
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
                    sAPGlobalMiddleMouseClickOnSAPElement["BringElementWindowToFront"] = CSharpExpressionConverter.ConvertToken(sAPGlobalMiddleMouseClickOnSAPElementbringElementWindowToFront);
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
                    sAPGlobalMiddleMouseClickOnSAPElement["ToggleWindow"] = CSharpExpressionConverter.ConvertToken(sAPGlobalMiddleMouseClickOnSAPElementtoggleWindow);
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
                    sAPGlobalMiddleMouseClickOnSAPElement["ToggleUsesGlobalLeftMouseClickAgent"] = CSharpExpressionConverter.ConvertToken(sAPGlobalMiddleMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent);
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
                    sAPGlobalMiddleMouseClickOnSAPElement["ToggleDelay"] = CSharpExpressionConverter.ConvertToken(sAPGlobalMiddleMouseClickOnSAPElementtoggleDelay);
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
                    sAPGlobalMiddleMouseClickOnSAPElement["ClickOffsetX"] = CSharpExpressionConverter.ConvertToken(sAPGlobalMiddleMouseClickOnSAPElementclickOffsetX);
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
                    sAPGlobalMiddleMouseClickOnSAPElement["ClickOffsetY"] = CSharpExpressionConverter.ConvertToken(sAPGlobalMiddleMouseClickOnSAPElementclickOffsetY);
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
                sAPGlobalMiddleMouseClickOnSAPElement["OffsetRelativeTo"] = CSharpExpressionConverter.Convert(sAPGlobalMiddleMouseClickOnSAPElementoffsetRelativeTo);
                sAPGlobalMiddleMouseClickOnSAPElementpropCount++;
            }

            sAPGlobalMiddleMouseClickOnSAPElementpropCount++;
            sAPGlobalMiddleMouseClickOnSAPElement["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPGlobalMiddleMouseClickOnSAPElementworkflow);
            if (sAPGlobalMiddleMouseClickOnSAPElementpropCount > 0)
            {
                callPayload.Body = sAPGlobalMiddleMouseClickOnSAPElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPGlobalDoubleLeftMouseClickOnSAPElement(Expression<Func<string>> sAPGlobalDoubleLeftMouseClickOnSAPElementsearchSAPElementId, Expression<Func<string>> sAPGlobalDoubleLeftMouseClickOnSAPElementworkflow, Expression<Func<bool>> sAPGlobalDoubleLeftMouseClickOnSAPElementsetElementWindowTopMost = null, Expression<Func<bool>> sAPGlobalDoubleLeftMouseClickOnSAPElementbringElementWindowToFront = null, Expression<Func<bool>> sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleWindow = null, Expression<Func<bool>> sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent = null, Expression<Func<double>> sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleDelay = null, Expression<Func<int>> sAPGlobalDoubleLeftMouseClickOnSAPElementclickOffsetX = null, Expression<Func<int>> sAPGlobalDoubleLeftMouseClickOnSAPElementclickOffsetY = null, Expression<Func<sAPGlobalDoubleLeftMouseClickOnSAPElementoffsetRelativeToInput>> sAPGlobalDoubleLeftMouseClickOnSAPElementoffsetRelativeTo = null, Expression<Func<int>> sAPGlobalDoubleLeftMouseClickOnSAPElementdoubleClickDelayInMilliseconds = null)
        {
            var apiCallPath = "/SAPGUI/SAPGlobalDoubleLeftMouseClickOnSAPElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPGlobalDoubleLeftMouseClickOnSAPElement = new JObject();
            var sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount = 0;
            sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount++;
            sAPGlobalDoubleLeftMouseClickOnSAPElement["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPGlobalDoubleLeftMouseClickOnSAPElementsearchSAPElementId);
            if (sAPGlobalDoubleLeftMouseClickOnSAPElementsetElementWindowTopMost != null)
            {
                if (sAPGlobalDoubleLeftMouseClickOnSAPElementsetElementWindowTopMost != null)
                {
                    sAPGlobalDoubleLeftMouseClickOnSAPElement["SetElementWindowTopMost"] = CSharpExpressionConverter.ConvertToken(sAPGlobalDoubleLeftMouseClickOnSAPElementsetElementWindowTopMost);
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
                    sAPGlobalDoubleLeftMouseClickOnSAPElement["BringElementWindowToFront"] = CSharpExpressionConverter.ConvertToken(sAPGlobalDoubleLeftMouseClickOnSAPElementbringElementWindowToFront);
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
                    sAPGlobalDoubleLeftMouseClickOnSAPElement["ToggleWindow"] = CSharpExpressionConverter.ConvertToken(sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleWindow);
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
                    sAPGlobalDoubleLeftMouseClickOnSAPElement["ToggleUsesGlobalLeftMouseClickAgent"] = CSharpExpressionConverter.ConvertToken(sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent);
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
                    sAPGlobalDoubleLeftMouseClickOnSAPElement["ToggleDelay"] = CSharpExpressionConverter.ConvertToken(sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleDelay);
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
                    sAPGlobalDoubleLeftMouseClickOnSAPElement["ClickOffsetX"] = CSharpExpressionConverter.ConvertToken(sAPGlobalDoubleLeftMouseClickOnSAPElementclickOffsetX);
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
                    sAPGlobalDoubleLeftMouseClickOnSAPElement["ClickOffsetY"] = CSharpExpressionConverter.ConvertToken(sAPGlobalDoubleLeftMouseClickOnSAPElementclickOffsetY);
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
                sAPGlobalDoubleLeftMouseClickOnSAPElement["OffsetRelativeTo"] = CSharpExpressionConverter.Convert(sAPGlobalDoubleLeftMouseClickOnSAPElementoffsetRelativeTo);
                sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount++;
            }

            if (sAPGlobalDoubleLeftMouseClickOnSAPElementdoubleClickDelayInMilliseconds != null)
            {
                if (sAPGlobalDoubleLeftMouseClickOnSAPElementdoubleClickDelayInMilliseconds != null)
                {
                    sAPGlobalDoubleLeftMouseClickOnSAPElement["DoubleClickDelayInMilliseconds"] = CSharpExpressionConverter.ConvertToken(sAPGlobalDoubleLeftMouseClickOnSAPElementdoubleClickDelayInMilliseconds);
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
            sAPGlobalDoubleLeftMouseClickOnSAPElement["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPGlobalDoubleLeftMouseClickOnSAPElementworkflow);
            if (sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount > 0)
            {
                callPayload.Body = sAPGlobalDoubleLeftMouseClickOnSAPElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPGlobalInputTextIntoSAPElement(Expression<Func<string>> sAPGlobalInputTextIntoSAPElementsearchSAPElementId, Expression<Func<string>> sAPGlobalInputTextIntoSAPElementworkflow, Expression<Func<bool>> sAPGlobalInputTextIntoSAPElementsetElementWindowTopMost = null, Expression<Func<bool>> sAPGlobalInputTextIntoSAPElementbringElementWindowToFront = null, Expression<Func<bool>> sAPGlobalInputTextIntoSAPElementtoggleWindow = null, Expression<Func<bool>> sAPGlobalInputTextIntoSAPElementtoggleUsesGlobalLeftMouseClickAgent = null, Expression<Func<double>> sAPGlobalInputTextIntoSAPElementtoggleDelay = null, Expression<Func<bool>> sAPGlobalInputTextIntoSAPElementglobalMouseClickOnElement = null, Expression<Func<bool>> sAPGlobalInputTextIntoSAPElementreplaceExistingValueUsingDoubleClickDelete = null, Expression<Func<bool>> sAPGlobalInputTextIntoSAPElementreplaceExistingValueUsingCTRLADelete = null, Expression<Func<string>> sAPGlobalInputTextIntoSAPElementtextToInput = null, Expression<Func<bool>> sAPGlobalInputTextIntoSAPElementsendKeyEvents = null, Expression<Func<int>> sAPGlobalInputTextIntoSAPElementkeyIntervalInMilliseconds = null, Expression<Func<int>> sAPGlobalInputTextIntoSAPElementdoubleClickIntervalInMilliseconds = null, Expression<Func<bool>> sAPGlobalInputTextIntoSAPElementdontInterpretSymbols = null)
        {
            var apiCallPath = "/SAPGUI/SAPGlobalInputTextIntoSAPElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPGlobalInputTextIntoSAPElement = new JObject();
            var sAPGlobalInputTextIntoSAPElementpropCount = 0;
            sAPGlobalInputTextIntoSAPElementpropCount++;
            sAPGlobalInputTextIntoSAPElement["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPGlobalInputTextIntoSAPElementsearchSAPElementId);
            if (sAPGlobalInputTextIntoSAPElementsetElementWindowTopMost != null)
            {
                if (sAPGlobalInputTextIntoSAPElementsetElementWindowTopMost != null)
                {
                    sAPGlobalInputTextIntoSAPElement["SetElementWindowTopMost"] = CSharpExpressionConverter.ConvertToken(sAPGlobalInputTextIntoSAPElementsetElementWindowTopMost);
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
                    sAPGlobalInputTextIntoSAPElement["BringElementWindowToFront"] = CSharpExpressionConverter.ConvertToken(sAPGlobalInputTextIntoSAPElementbringElementWindowToFront);
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
                    sAPGlobalInputTextIntoSAPElement["ToggleWindow"] = CSharpExpressionConverter.ConvertToken(sAPGlobalInputTextIntoSAPElementtoggleWindow);
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
                    sAPGlobalInputTextIntoSAPElement["ToggleUsesGlobalLeftMouseClickAgent"] = CSharpExpressionConverter.ConvertToken(sAPGlobalInputTextIntoSAPElementtoggleUsesGlobalLeftMouseClickAgent);
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
                    sAPGlobalInputTextIntoSAPElement["ToggleDelay"] = CSharpExpressionConverter.ConvertToken(sAPGlobalInputTextIntoSAPElementtoggleDelay);
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
                    sAPGlobalInputTextIntoSAPElement["GlobalMouseClickOnElement"] = CSharpExpressionConverter.ConvertToken(sAPGlobalInputTextIntoSAPElementglobalMouseClickOnElement);
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
                    sAPGlobalInputTextIntoSAPElement["ReplaceExistingValueUsingDoubleClickDelete"] = CSharpExpressionConverter.ConvertToken(sAPGlobalInputTextIntoSAPElementreplaceExistingValueUsingDoubleClickDelete);
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
                    sAPGlobalInputTextIntoSAPElement["ReplaceExistingValueUsingCTRLADelete"] = CSharpExpressionConverter.ConvertToken(sAPGlobalInputTextIntoSAPElementreplaceExistingValueUsingCTRLADelete);
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
                sAPGlobalInputTextIntoSAPElement["TextToInput"] = CSharpExpressionConverter.ConvertToken(sAPGlobalInputTextIntoSAPElementtextToInput);
                sAPGlobalInputTextIntoSAPElementpropCount++;
            }

            if (sAPGlobalInputTextIntoSAPElementsendKeyEvents != null)
            {
                if (sAPGlobalInputTextIntoSAPElementsendKeyEvents != null)
                {
                    sAPGlobalInputTextIntoSAPElement["SendKeyEvents"] = CSharpExpressionConverter.ConvertToken(sAPGlobalInputTextIntoSAPElementsendKeyEvents);
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
                    sAPGlobalInputTextIntoSAPElement["KeyIntervalInMilliseconds"] = CSharpExpressionConverter.ConvertToken(sAPGlobalInputTextIntoSAPElementkeyIntervalInMilliseconds);
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
                    sAPGlobalInputTextIntoSAPElement["DoubleClickIntervalInMilliseconds"] = CSharpExpressionConverter.ConvertToken(sAPGlobalInputTextIntoSAPElementdoubleClickIntervalInMilliseconds);
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
                    sAPGlobalInputTextIntoSAPElement["DontInterpretSymbols"] = CSharpExpressionConverter.ConvertToken(sAPGlobalInputTextIntoSAPElementdontInterpretSymbols);
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
            sAPGlobalInputTextIntoSAPElement["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPGlobalInputTextIntoSAPElementworkflow);
            if (sAPGlobalInputTextIntoSAPElementpropCount > 0)
            {
                callPayload.Body = sAPGlobalInputTextIntoSAPElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPGlobalInputPasswordIntoSAPElement(Expression<Func<string>> sAPGlobalInputPasswordIntoSAPElementsearchSAPElementId, Expression<Func<string>> sAPGlobalInputPasswordIntoSAPElementpasswordToInput, Expression<Func<string>> sAPGlobalInputPasswordIntoSAPElementworkflow, Expression<Func<bool>> sAPGlobalInputPasswordIntoSAPElementsetElementWindowTopMost = null, Expression<Func<bool>> sAPGlobalInputPasswordIntoSAPElementbringElementWindowToFront = null, Expression<Func<bool>> sAPGlobalInputPasswordIntoSAPElementtoggleWindow = null, Expression<Func<bool>> sAPGlobalInputPasswordIntoSAPElementtoggleUsesGlobalLeftMouseClickAgent = null, Expression<Func<double>> sAPGlobalInputPasswordIntoSAPElementtoggleDelay = null, Expression<Func<bool>> sAPGlobalInputPasswordIntoSAPElementglobalMouseClickOnElement = null, Expression<Func<bool>> sAPGlobalInputPasswordIntoSAPElementreplaceExistingValueUsingDoubleClickDelete = null, Expression<Func<bool>> sAPGlobalInputPasswordIntoSAPElementreplaceExistingValueUsingCTRLADelete = null, Expression<Func<bool>> sAPGlobalInputPasswordIntoSAPElementsendKeyEvents = null, Expression<Func<int>> sAPGlobalInputPasswordIntoSAPElementkeyIntervalInMilliseconds = null, Expression<Func<int>> sAPGlobalInputPasswordIntoSAPElementdoubleClickIntervalInMilliseconds = null, Expression<Func<bool>> sAPGlobalInputPasswordIntoSAPElementdontInterpretSymbols = null)
        {
            var apiCallPath = "/SAPGUI/SAPGlobalInputPasswordIntoSAPElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPGlobalInputPasswordIntoSAPElement = new JObject();
            var sAPGlobalInputPasswordIntoSAPElementpropCount = 0;
            sAPGlobalInputPasswordIntoSAPElementpropCount++;
            sAPGlobalInputPasswordIntoSAPElement["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPGlobalInputPasswordIntoSAPElementsearchSAPElementId);
            if (sAPGlobalInputPasswordIntoSAPElementsetElementWindowTopMost != null)
            {
                if (sAPGlobalInputPasswordIntoSAPElementsetElementWindowTopMost != null)
                {
                    sAPGlobalInputPasswordIntoSAPElement["SetElementWindowTopMost"] = CSharpExpressionConverter.ConvertToken(sAPGlobalInputPasswordIntoSAPElementsetElementWindowTopMost);
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
                    sAPGlobalInputPasswordIntoSAPElement["BringElementWindowToFront"] = CSharpExpressionConverter.ConvertToken(sAPGlobalInputPasswordIntoSAPElementbringElementWindowToFront);
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
                    sAPGlobalInputPasswordIntoSAPElement["ToggleWindow"] = CSharpExpressionConverter.ConvertToken(sAPGlobalInputPasswordIntoSAPElementtoggleWindow);
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
                    sAPGlobalInputPasswordIntoSAPElement["ToggleUsesGlobalLeftMouseClickAgent"] = CSharpExpressionConverter.ConvertToken(sAPGlobalInputPasswordIntoSAPElementtoggleUsesGlobalLeftMouseClickAgent);
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
                    sAPGlobalInputPasswordIntoSAPElement["ToggleDelay"] = CSharpExpressionConverter.ConvertToken(sAPGlobalInputPasswordIntoSAPElementtoggleDelay);
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
                    sAPGlobalInputPasswordIntoSAPElement["GlobalMouseClickOnElement"] = CSharpExpressionConverter.ConvertToken(sAPGlobalInputPasswordIntoSAPElementglobalMouseClickOnElement);
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
                    sAPGlobalInputPasswordIntoSAPElement["ReplaceExistingValueUsingDoubleClickDelete"] = CSharpExpressionConverter.ConvertToken(sAPGlobalInputPasswordIntoSAPElementreplaceExistingValueUsingDoubleClickDelete);
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
                    sAPGlobalInputPasswordIntoSAPElement["ReplaceExistingValueUsingCTRLADelete"] = CSharpExpressionConverter.ConvertToken(sAPGlobalInputPasswordIntoSAPElementreplaceExistingValueUsingCTRLADelete);
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
            sAPGlobalInputPasswordIntoSAPElement["PasswordToInput"] = CSharpExpressionConverter.ConvertToken(sAPGlobalInputPasswordIntoSAPElementpasswordToInput);
            if (sAPGlobalInputPasswordIntoSAPElementsendKeyEvents != null)
            {
                if (sAPGlobalInputPasswordIntoSAPElementsendKeyEvents != null)
                {
                    sAPGlobalInputPasswordIntoSAPElement["SendKeyEvents"] = CSharpExpressionConverter.ConvertToken(sAPGlobalInputPasswordIntoSAPElementsendKeyEvents);
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
                    sAPGlobalInputPasswordIntoSAPElement["KeyIntervalInMilliseconds"] = CSharpExpressionConverter.ConvertToken(sAPGlobalInputPasswordIntoSAPElementkeyIntervalInMilliseconds);
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
                    sAPGlobalInputPasswordIntoSAPElement["DoubleClickIntervalInMilliseconds"] = CSharpExpressionConverter.ConvertToken(sAPGlobalInputPasswordIntoSAPElementdoubleClickIntervalInMilliseconds);
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
                    sAPGlobalInputPasswordIntoSAPElement["DontInterpretSymbols"] = CSharpExpressionConverter.ConvertToken(sAPGlobalInputPasswordIntoSAPElementdontInterpretSymbols);
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
            sAPGlobalInputPasswordIntoSAPElement["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPGlobalInputPasswordIntoSAPElementworkflow);
            if (sAPGlobalInputPasswordIntoSAPElementpropCount > 0)
            {
                callPayload.Body = sAPGlobalInputPasswordIntoSAPElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPSetListSelectionByName(Expression<Func<string>> sAPSetListSelectionByNamesearchSAPElementId, Expression<Func<string>> sAPSetListSelectionByNamelistItemName, Expression<Func<string>> sAPSetListSelectionByNameworkflow)
        {
            var apiCallPath = "/SAPGUI/SAPSetListSelectionByName";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPSetListSelectionByName = new JObject();
            var sAPSetListSelectionByNamepropCount = 0;
            sAPSetListSelectionByNamepropCount++;
            sAPSetListSelectionByName["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPSetListSelectionByNamesearchSAPElementId);
            sAPSetListSelectionByNamepropCount++;
            sAPSetListSelectionByName["ListItemName"] = CSharpExpressionConverter.ConvertToken(sAPSetListSelectionByNamelistItemName);
            sAPSetListSelectionByNamepropCount++;
            sAPSetListSelectionByName["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPSetListSelectionByNameworkflow);
            if (sAPSetListSelectionByNamepropCount > 0)
            {
                callPayload.Body = sAPSetListSelectionByName;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPSetListSelectionByKey(Expression<Func<string>> sAPSetListSelectionByKeysearchSAPElementId, Expression<Func<string>> sAPSetListSelectionByKeylistItemKey, Expression<Func<string>> sAPSetListSelectionByKeyworkflow)
        {
            var apiCallPath = "/SAPGUI/SAPSetListSelectionByKey";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPSetListSelectionByKey = new JObject();
            var sAPSetListSelectionByKeypropCount = 0;
            sAPSetListSelectionByKeypropCount++;
            sAPSetListSelectionByKey["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPSetListSelectionByKeysearchSAPElementId);
            sAPSetListSelectionByKeypropCount++;
            sAPSetListSelectionByKey["ListItemKey"] = CSharpExpressionConverter.ConvertToken(sAPSetListSelectionByKeylistItemKey);
            sAPSetListSelectionByKeypropCount++;
            sAPSetListSelectionByKey["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPSetListSelectionByKeyworkflow);
            if (sAPSetListSelectionByKeypropCount > 0)
            {
                callPayload.Body = sAPSetListSelectionByKey;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetListSelectionElementItemsResponse> SAPGetListSelectionElementItems(Expression<Func<string>> sAPGetListSelectionElementItemssearchSAPElementId, Expression<Func<string>> sAPGetListSelectionElementItemsworkflow)
        {
            var apiCallPath = "/SAPGUI/SAPGetListSelectionElementItems";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPGetListSelectionElementItems = new JObject();
            var sAPGetListSelectionElementItemspropCount = 0;
            sAPGetListSelectionElementItemspropCount++;
            sAPGetListSelectionElementItems["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPGetListSelectionElementItemssearchSAPElementId);
            sAPGetListSelectionElementItemspropCount++;
            sAPGetListSelectionElementItems["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPGetListSelectionElementItemsworkflow);
            if (sAPGetListSelectionElementItemspropCount > 0)
            {
                callPayload.Body = sAPGetListSelectionElementItems;
            }

            return new ApiConnectionAction<SAPGetListSelectionElementItemsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetAllChildSAPElementPropertiesResponse> SAPGetAllChildSAPElementProperties(Expression<Func<string>> sAPGetAllChildSAPElementPropertiessearchSAPElementId, Expression<Func<string>> sAPGetAllChildSAPElementPropertiesworkflow, Expression<Func<int>> sAPGetAllChildSAPElementPropertiesfirstItemToReturn = null, Expression<Func<int>> sAPGetAllChildSAPElementPropertiesmaxItemsToReturn = null, Expression<Func<string>> sAPGetAllChildSAPElementPropertiessearchSAPElementType = null, Expression<Func<int>> sAPGetAllChildSAPElementPropertiesmaxTextLength = null)
        {
            var apiCallPath = "/SAPGUI/SAPGetAllChildSAPElementProperties";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPGetAllChildSAPElementProperties = new JObject();
            var sAPGetAllChildSAPElementPropertiespropCount = 0;
            sAPGetAllChildSAPElementPropertiespropCount++;
            sAPGetAllChildSAPElementProperties["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPGetAllChildSAPElementPropertiessearchSAPElementId);
            if (sAPGetAllChildSAPElementPropertiesfirstItemToReturn != null)
            {
                if (sAPGetAllChildSAPElementPropertiesfirstItemToReturn != null)
                {
                    sAPGetAllChildSAPElementProperties["FirstItemToReturn"] = CSharpExpressionConverter.ConvertToken(sAPGetAllChildSAPElementPropertiesfirstItemToReturn);
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
                    sAPGetAllChildSAPElementProperties["MaxItemsToReturn"] = CSharpExpressionConverter.ConvertToken(sAPGetAllChildSAPElementPropertiesmaxItemsToReturn);
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
                sAPGetAllChildSAPElementProperties["SearchSAPElementType"] = CSharpExpressionConverter.ConvertToken(sAPGetAllChildSAPElementPropertiessearchSAPElementType);
                sAPGetAllChildSAPElementPropertiespropCount++;
            }

            if (sAPGetAllChildSAPElementPropertiesmaxTextLength != null)
            {
                if (sAPGetAllChildSAPElementPropertiesmaxTextLength != null)
                {
                    sAPGetAllChildSAPElementProperties["MaxTextLength"] = CSharpExpressionConverter.ConvertToken(sAPGetAllChildSAPElementPropertiesmaxTextLength);
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
            sAPGetAllChildSAPElementProperties["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPGetAllChildSAPElementPropertiesworkflow);
            if (sAPGetAllChildSAPElementPropertiespropCount > 0)
            {
                callPayload.Body = sAPGetAllChildSAPElementProperties;
            }

            return new ApiConnectionAction<SAPGetAllChildSAPElementPropertiesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetSAPSessionTopLevelSAPElementPropertiesResponse> SAPGetSAPSessionTopLevelSAPElementProperties(Expression<Func<string>> sAPGetSAPSessionTopLevelSAPElementPropertiesworkflow, Expression<Func<int>> sAPGetSAPSessionTopLevelSAPElementPropertiesfirstItemToReturn = null, Expression<Func<int>> sAPGetSAPSessionTopLevelSAPElementPropertiesmaxItemsToReturn = null, Expression<Func<string>> sAPGetSAPSessionTopLevelSAPElementPropertiessearchSAPElementType = null, Expression<Func<int>> sAPGetSAPSessionTopLevelSAPElementPropertiesmaxTextLength = null)
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
                    sAPGetSAPSessionTopLevelSAPElementProperties["FirstItemToReturn"] = CSharpExpressionConverter.ConvertToken(sAPGetSAPSessionTopLevelSAPElementPropertiesfirstItemToReturn);
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
                    sAPGetSAPSessionTopLevelSAPElementProperties["MaxItemsToReturn"] = CSharpExpressionConverter.ConvertToken(sAPGetSAPSessionTopLevelSAPElementPropertiesmaxItemsToReturn);
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
                sAPGetSAPSessionTopLevelSAPElementProperties["SearchSAPElementType"] = CSharpExpressionConverter.ConvertToken(sAPGetSAPSessionTopLevelSAPElementPropertiessearchSAPElementType);
                sAPGetSAPSessionTopLevelSAPElementPropertiespropCount++;
            }

            if (sAPGetSAPSessionTopLevelSAPElementPropertiesmaxTextLength != null)
            {
                if (sAPGetSAPSessionTopLevelSAPElementPropertiesmaxTextLength != null)
                {
                    sAPGetSAPSessionTopLevelSAPElementProperties["MaxTextLength"] = CSharpExpressionConverter.ConvertToken(sAPGetSAPSessionTopLevelSAPElementPropertiesmaxTextLength);
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
            sAPGetSAPSessionTopLevelSAPElementProperties["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPGetSAPSessionTopLevelSAPElementPropertiesworkflow);
            if (sAPGetSAPSessionTopLevelSAPElementPropertiespropCount > 0)
            {
                callPayload.Body = sAPGetSAPSessionTopLevelSAPElementProperties;
            }

            return new ApiConnectionAction<SAPGetSAPSessionTopLevelSAPElementPropertiesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetSAPElementParentIdResponse> SAPGetSAPElementParentId(Expression<Func<string>> sAPGetSAPElementParentIdsearchSAPElementId, Expression<Func<string>> sAPGetSAPElementParentIdworkflow)
        {
            var apiCallPath = "/SAPGUI/SAPGetSAPElementParentId";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPGetSAPElementParentId = new JObject();
            var sAPGetSAPElementParentIdpropCount = 0;
            sAPGetSAPElementParentIdpropCount++;
            sAPGetSAPElementParentId["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPGetSAPElementParentIdsearchSAPElementId);
            sAPGetSAPElementParentIdpropCount++;
            sAPGetSAPElementParentId["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPGetSAPElementParentIdworkflow);
            if (sAPGetSAPElementParentIdpropCount > 0)
            {
                callPayload.Body = sAPGetSAPElementParentId;
            }

            return new ApiConnectionAction<SAPGetSAPElementParentIdResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetElementPropertiesAsListResponse> SAPGetElementPropertiesAsList(Expression<Func<string>> sAPGetElementPropertiesAsListsearchSAPElementId, Expression<Func<string>> sAPGetElementPropertiesAsListworkflow, Expression<Func<int>> sAPGetElementPropertiesAsListmaxTextLength = null)
        {
            var apiCallPath = "/SAPGUI/SAPGetElementPropertiesAsList";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPGetElementPropertiesAsList = new JObject();
            var sAPGetElementPropertiesAsListpropCount = 0;
            sAPGetElementPropertiesAsListpropCount++;
            sAPGetElementPropertiesAsList["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPGetElementPropertiesAsListsearchSAPElementId);
            if (sAPGetElementPropertiesAsListmaxTextLength != null)
            {
                if (sAPGetElementPropertiesAsListmaxTextLength != null)
                {
                    sAPGetElementPropertiesAsList["MaxTextLength"] = CSharpExpressionConverter.ConvertToken(sAPGetElementPropertiesAsListmaxTextLength);
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
            sAPGetElementPropertiesAsList["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPGetElementPropertiesAsListworkflow);
            if (sAPGetElementPropertiesAsListpropCount > 0)
            {
                callPayload.Body = sAPGetElementPropertiesAsList;
            }

            return new ApiConnectionAction<SAPGetElementPropertiesAsListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetSAPElementAtScreenCoordinateResponse> SAPGetSAPElementAtScreenCoordinate(Expression<Func<int>> sAPGetSAPElementAtScreenCoordinatescreenX, Expression<Func<int>> sAPGetSAPElementAtScreenCoordinatescreenY, Expression<Func<string>> sAPGetSAPElementAtScreenCoordinateworkflow)
        {
            var apiCallPath = "/SAPGUI/SAPGetSAPElementAtScreenCoordinate";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPGetSAPElementAtScreenCoordinate = new JObject();
            var sAPGetSAPElementAtScreenCoordinatepropCount = 0;
            sAPGetSAPElementAtScreenCoordinatepropCount++;
            sAPGetSAPElementAtScreenCoordinate["ScreenX"] = CSharpExpressionConverter.ConvertToken(sAPGetSAPElementAtScreenCoordinatescreenX);
            sAPGetSAPElementAtScreenCoordinatepropCount++;
            sAPGetSAPElementAtScreenCoordinate["ScreenY"] = CSharpExpressionConverter.ConvertToken(sAPGetSAPElementAtScreenCoordinatescreenY);
            sAPGetSAPElementAtScreenCoordinatepropCount++;
            sAPGetSAPElementAtScreenCoordinate["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPGetSAPElementAtScreenCoordinateworkflow);
            if (sAPGetSAPElementAtScreenCoordinatepropCount > 0)
            {
                callPayload.Body = sAPGetSAPElementAtScreenCoordinate;
            }

            return new ApiConnectionAction<SAPGetSAPElementAtScreenCoordinateResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPOpenConnectionResponse> SAPOpenConnection(Expression<Func<string>> sAPOpenConnectionworkflow, Expression<Func<string>> sAPOpenConnectionsAPConnectionDescription = null, Expression<Func<string>> sAPOpenConnectionsAPConnectionAddress = null, Expression<Func<bool>> sAPOpenConnectionconnectSynchronous = null, Expression<Func<bool>> sAPOpenConnectionconnectToSession = null)
        {
            var apiCallPath = "/SAPGUI/SAPOpenConnection";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPOpenConnection = new JObject();
            var sAPOpenConnectionpropCount = 0;
            if (sAPOpenConnectionsAPConnectionDescription != null)
            {
                sAPOpenConnection["SAPConnectionDescription"] = CSharpExpressionConverter.ConvertToken(sAPOpenConnectionsAPConnectionDescription);
                sAPOpenConnectionpropCount++;
            }

            if (sAPOpenConnectionsAPConnectionAddress != null)
            {
                sAPOpenConnection["SAPConnectionAddress"] = CSharpExpressionConverter.ConvertToken(sAPOpenConnectionsAPConnectionAddress);
                sAPOpenConnectionpropCount++;
            }

            if (sAPOpenConnectionconnectSynchronous != null)
            {
                if (sAPOpenConnectionconnectSynchronous != null)
                {
                    sAPOpenConnection["ConnectSynchronous"] = CSharpExpressionConverter.ConvertToken(sAPOpenConnectionconnectSynchronous);
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
                    sAPOpenConnection["ConnectToSession"] = CSharpExpressionConverter.ConvertToken(sAPOpenConnectionconnectToSession);
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
            sAPOpenConnection["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPOpenConnectionworkflow);
            if (sAPOpenConnectionpropCount > 0)
            {
                callPayload.Body = sAPOpenConnection;
            }

            return new ApiConnectionAction<SAPOpenConnectionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetSAPTablePropertiesResponse> SAPGetSAPTableProperties(Expression<Func<string>> sAPGetSAPTablePropertiessearchSAPElementId, Expression<Func<string>> sAPGetSAPTablePropertiesworkflow)
        {
            var apiCallPath = "/SAPGUI/SAPGetSAPTableProperties";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPGetSAPTableProperties = new JObject();
            var sAPGetSAPTablePropertiespropCount = 0;
            sAPGetSAPTablePropertiespropCount++;
            sAPGetSAPTableProperties["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPGetSAPTablePropertiessearchSAPElementId);
            sAPGetSAPTablePropertiespropCount++;
            sAPGetSAPTableProperties["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPGetSAPTablePropertiesworkflow);
            if (sAPGetSAPTablePropertiespropCount > 0)
            {
                callPayload.Body = sAPGetSAPTableProperties;
            }

            return new ApiConnectionAction<SAPGetSAPTablePropertiesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetSAPTableVisibleCellTextContentsAtIndexResponse> SAPGetSAPTableVisibleCellTextContentsAtIndex(Expression<Func<string>> sAPGetSAPTableVisibleCellTextContentsAtIndexsearchSAPElementId, Expression<Func<string>> sAPGetSAPTableVisibleCellTextContentsAtIndexworkflow, Expression<Func<int>> sAPGetSAPTableVisibleCellTextContentsAtIndexvisibleRowIndex = null, Expression<Func<int>> sAPGetSAPTableVisibleCellTextContentsAtIndexvisibleColumnIndex = null, Expression<Func<string>> sAPGetSAPTableVisibleCellTextContentsAtIndexcheckedElementValue = null)
        {
            var apiCallPath = "/SAPGUI/SAPGetSAPTableVisibleCellTextContentsAtIndex";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPGetSAPTableVisibleCellTextContentsAtIndex = new JObject();
            var sAPGetSAPTableVisibleCellTextContentsAtIndexpropCount = 0;
            sAPGetSAPTableVisibleCellTextContentsAtIndexpropCount++;
            sAPGetSAPTableVisibleCellTextContentsAtIndex["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPGetSAPTableVisibleCellTextContentsAtIndexsearchSAPElementId);
            if (sAPGetSAPTableVisibleCellTextContentsAtIndexvisibleRowIndex != null)
            {
                if (sAPGetSAPTableVisibleCellTextContentsAtIndexvisibleRowIndex != null)
                {
                    sAPGetSAPTableVisibleCellTextContentsAtIndex["VisibleRowIndex"] = CSharpExpressionConverter.ConvertToken(sAPGetSAPTableVisibleCellTextContentsAtIndexvisibleRowIndex);
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
                    sAPGetSAPTableVisibleCellTextContentsAtIndex["VisibleColumnIndex"] = CSharpExpressionConverter.ConvertToken(sAPGetSAPTableVisibleCellTextContentsAtIndexvisibleColumnIndex);
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
                    sAPGetSAPTableVisibleCellTextContentsAtIndex["CheckedElementValue"] = CSharpExpressionConverter.ConvertToken(sAPGetSAPTableVisibleCellTextContentsAtIndexcheckedElementValue);
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
            sAPGetSAPTableVisibleCellTextContentsAtIndex["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPGetSAPTableVisibleCellTextContentsAtIndexworkflow);
            if (sAPGetSAPTableVisibleCellTextContentsAtIndexpropCount > 0)
            {
                callPayload.Body = sAPGetSAPTableVisibleCellTextContentsAtIndex;
            }

            return new ApiConnectionAction<SAPGetSAPTableVisibleCellTextContentsAtIndexResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetSAPTableVisibleCellPropertiesAtIndexResponse> SAPGetSAPTableVisibleCellPropertiesAtIndex(Expression<Func<string>> sAPGetSAPTableVisibleCellPropertiesAtIndexsearchSAPElementId, Expression<Func<string>> sAPGetSAPTableVisibleCellPropertiesAtIndexworkflow, Expression<Func<int>> sAPGetSAPTableVisibleCellPropertiesAtIndexvisibleRowIndex = null, Expression<Func<int>> sAPGetSAPTableVisibleCellPropertiesAtIndexvisibleColumnIndex = null)
        {
            var apiCallPath = "/SAPGUI/SAPGetSAPTableVisibleCellPropertiesAtIndex";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPGetSAPTableVisibleCellPropertiesAtIndex = new JObject();
            var sAPGetSAPTableVisibleCellPropertiesAtIndexpropCount = 0;
            sAPGetSAPTableVisibleCellPropertiesAtIndexpropCount++;
            sAPGetSAPTableVisibleCellPropertiesAtIndex["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPGetSAPTableVisibleCellPropertiesAtIndexsearchSAPElementId);
            if (sAPGetSAPTableVisibleCellPropertiesAtIndexvisibleRowIndex != null)
            {
                if (sAPGetSAPTableVisibleCellPropertiesAtIndexvisibleRowIndex != null)
                {
                    sAPGetSAPTableVisibleCellPropertiesAtIndex["VisibleRowIndex"] = CSharpExpressionConverter.ConvertToken(sAPGetSAPTableVisibleCellPropertiesAtIndexvisibleRowIndex);
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
                    sAPGetSAPTableVisibleCellPropertiesAtIndex["VisibleColumnIndex"] = CSharpExpressionConverter.ConvertToken(sAPGetSAPTableVisibleCellPropertiesAtIndexvisibleColumnIndex);
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
            sAPGetSAPTableVisibleCellPropertiesAtIndex["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPGetSAPTableVisibleCellPropertiesAtIndexworkflow);
            if (sAPGetSAPTableVisibleCellPropertiesAtIndexpropCount > 0)
            {
                callPayload.Body = sAPGetSAPTableVisibleCellPropertiesAtIndex;
            }

            return new ApiConnectionAction<SAPGetSAPTableVisibleCellPropertiesAtIndexResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPSetSAPTableVisibleCellTextContentsAtIndex(Expression<Func<string>> sAPSetSAPTableVisibleCellTextContentsAtIndexsearchSAPElementId, Expression<Func<string>> sAPSetSAPTableVisibleCellTextContentsAtIndexworkflow, Expression<Func<int>> sAPSetSAPTableVisibleCellTextContentsAtIndexvisibleRowIndex = null, Expression<Func<int>> sAPSetSAPTableVisibleCellTextContentsAtIndexvisibleColumnIndex = null, Expression<Func<string>> sAPSetSAPTableVisibleCellTextContentsAtIndextextToInput = null, Expression<Func<bool>> sAPSetSAPTableVisibleCellTextContentsAtIndexreplaceExistingValue = null, Expression<Func<int>> sAPSetSAPTableVisibleCellTextContentsAtIndexinsertPosition = null)
        {
            var apiCallPath = "/SAPGUI/SAPSetSAPTableVisibleCellTextContentsAtIndex";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPSetSAPTableVisibleCellTextContentsAtIndex = new JObject();
            var sAPSetSAPTableVisibleCellTextContentsAtIndexpropCount = 0;
            sAPSetSAPTableVisibleCellTextContentsAtIndexpropCount++;
            sAPSetSAPTableVisibleCellTextContentsAtIndex["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPSetSAPTableVisibleCellTextContentsAtIndexsearchSAPElementId);
            if (sAPSetSAPTableVisibleCellTextContentsAtIndexvisibleRowIndex != null)
            {
                if (sAPSetSAPTableVisibleCellTextContentsAtIndexvisibleRowIndex != null)
                {
                    sAPSetSAPTableVisibleCellTextContentsAtIndex["VisibleRowIndex"] = CSharpExpressionConverter.ConvertToken(sAPSetSAPTableVisibleCellTextContentsAtIndexvisibleRowIndex);
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
                    sAPSetSAPTableVisibleCellTextContentsAtIndex["VisibleColumnIndex"] = CSharpExpressionConverter.ConvertToken(sAPSetSAPTableVisibleCellTextContentsAtIndexvisibleColumnIndex);
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
                sAPSetSAPTableVisibleCellTextContentsAtIndex["TextToInput"] = CSharpExpressionConverter.ConvertToken(sAPSetSAPTableVisibleCellTextContentsAtIndextextToInput);
                sAPSetSAPTableVisibleCellTextContentsAtIndexpropCount++;
            }

            if (sAPSetSAPTableVisibleCellTextContentsAtIndexreplaceExistingValue != null)
            {
                if (sAPSetSAPTableVisibleCellTextContentsAtIndexreplaceExistingValue != null)
                {
                    sAPSetSAPTableVisibleCellTextContentsAtIndex["ReplaceExistingValue"] = CSharpExpressionConverter.ConvertToken(sAPSetSAPTableVisibleCellTextContentsAtIndexreplaceExistingValue);
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
                    sAPSetSAPTableVisibleCellTextContentsAtIndex["InsertPosition"] = CSharpExpressionConverter.ConvertToken(sAPSetSAPTableVisibleCellTextContentsAtIndexinsertPosition);
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
            sAPSetSAPTableVisibleCellTextContentsAtIndex["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPSetSAPTableVisibleCellTextContentsAtIndexworkflow);
            if (sAPSetSAPTableVisibleCellTextContentsAtIndexpropCount > 0)
            {
                callPayload.Body = sAPSetSAPTableVisibleCellTextContentsAtIndex;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPCheckSAPTableVisibleCellCheckboxAtIndex(Expression<Func<string>> sAPCheckSAPTableVisibleCellCheckboxAtIndexsearchSAPElementId, Expression<Func<string>> sAPCheckSAPTableVisibleCellCheckboxAtIndexworkflow, Expression<Func<int>> sAPCheckSAPTableVisibleCellCheckboxAtIndexvisibleRowIndex = null, Expression<Func<int>> sAPCheckSAPTableVisibleCellCheckboxAtIndexvisibleColumnIndex = null, Expression<Func<bool>> sAPCheckSAPTableVisibleCellCheckboxAtIndexcheckCellElement = null)
        {
            var apiCallPath = "/SAPGUI/SAPCheckSAPTableVisibleCellCheckboxAtIndex";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPCheckSAPTableVisibleCellCheckboxAtIndex = new JObject();
            var sAPCheckSAPTableVisibleCellCheckboxAtIndexpropCount = 0;
            sAPCheckSAPTableVisibleCellCheckboxAtIndexpropCount++;
            sAPCheckSAPTableVisibleCellCheckboxAtIndex["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPCheckSAPTableVisibleCellCheckboxAtIndexsearchSAPElementId);
            if (sAPCheckSAPTableVisibleCellCheckboxAtIndexvisibleRowIndex != null)
            {
                if (sAPCheckSAPTableVisibleCellCheckboxAtIndexvisibleRowIndex != null)
                {
                    sAPCheckSAPTableVisibleCellCheckboxAtIndex["VisibleRowIndex"] = CSharpExpressionConverter.ConvertToken(sAPCheckSAPTableVisibleCellCheckboxAtIndexvisibleRowIndex);
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
                    sAPCheckSAPTableVisibleCellCheckboxAtIndex["VisibleColumnIndex"] = CSharpExpressionConverter.ConvertToken(sAPCheckSAPTableVisibleCellCheckboxAtIndexvisibleColumnIndex);
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
                    sAPCheckSAPTableVisibleCellCheckboxAtIndex["CheckCellElement"] = CSharpExpressionConverter.ConvertToken(sAPCheckSAPTableVisibleCellCheckboxAtIndexcheckCellElement);
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
            sAPCheckSAPTableVisibleCellCheckboxAtIndex["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPCheckSAPTableVisibleCellCheckboxAtIndexworkflow);
            if (sAPCheckSAPTableVisibleCellCheckboxAtIndexpropCount > 0)
            {
                callPayload.Body = sAPCheckSAPTableVisibleCellCheckboxAtIndex;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPPressSAPTableVisibleCellAtIndex(Expression<Func<string>> sAPPressSAPTableVisibleCellAtIndexsearchSAPElementId, Expression<Func<string>> sAPPressSAPTableVisibleCellAtIndexworkflow, Expression<Func<int>> sAPPressSAPTableVisibleCellAtIndexvisibleRowIndex = null, Expression<Func<int>> sAPPressSAPTableVisibleCellAtIndexvisibleColumnIndex = null)
        {
            var apiCallPath = "/SAPGUI/SAPPressSAPTableVisibleCellAtIndex";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPPressSAPTableVisibleCellAtIndex = new JObject();
            var sAPPressSAPTableVisibleCellAtIndexpropCount = 0;
            sAPPressSAPTableVisibleCellAtIndexpropCount++;
            sAPPressSAPTableVisibleCellAtIndex["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPPressSAPTableVisibleCellAtIndexsearchSAPElementId);
            if (sAPPressSAPTableVisibleCellAtIndexvisibleRowIndex != null)
            {
                if (sAPPressSAPTableVisibleCellAtIndexvisibleRowIndex != null)
                {
                    sAPPressSAPTableVisibleCellAtIndex["VisibleRowIndex"] = CSharpExpressionConverter.ConvertToken(sAPPressSAPTableVisibleCellAtIndexvisibleRowIndex);
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
                    sAPPressSAPTableVisibleCellAtIndex["VisibleColumnIndex"] = CSharpExpressionConverter.ConvertToken(sAPPressSAPTableVisibleCellAtIndexvisibleColumnIndex);
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
            sAPPressSAPTableVisibleCellAtIndex["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPPressSAPTableVisibleCellAtIndexworkflow);
            if (sAPPressSAPTableVisibleCellAtIndexpropCount > 0)
            {
                callPayload.Body = sAPPressSAPTableVisibleCellAtIndex;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPScrollSAPTable(Expression<Func<string>> sAPScrollSAPTablesearchSAPElementId, Expression<Func<string>> sAPScrollSAPTableworkflow, Expression<Func<bool>> sAPScrollSAPTablemoveHorizontalScrollbar = null, Expression<Func<int>> sAPScrollSAPTablehorizontalScrollbarPosition = null, Expression<Func<bool>> sAPScrollSAPTablemoveVerticalScrollbar = null, Expression<Func<int>> sAPScrollSAPTableverticalScrollbarPosition = null)
        {
            var apiCallPath = "/SAPGUI/SAPScrollSAPTable";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPScrollSAPTable = new JObject();
            var sAPScrollSAPTablepropCount = 0;
            sAPScrollSAPTablepropCount++;
            sAPScrollSAPTable["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPScrollSAPTablesearchSAPElementId);
            if (sAPScrollSAPTablemoveHorizontalScrollbar != null)
            {
                if (sAPScrollSAPTablemoveHorizontalScrollbar != null)
                {
                    sAPScrollSAPTable["MoveHorizontalScrollbar"] = CSharpExpressionConverter.ConvertToken(sAPScrollSAPTablemoveHorizontalScrollbar);
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
                sAPScrollSAPTable["HorizontalScrollbarPosition"] = CSharpExpressionConverter.ConvertToken(sAPScrollSAPTablehorizontalScrollbarPosition);
                sAPScrollSAPTablepropCount++;
            }

            if (sAPScrollSAPTablemoveVerticalScrollbar != null)
            {
                if (sAPScrollSAPTablemoveVerticalScrollbar != null)
                {
                    sAPScrollSAPTable["MoveVerticalScrollbar"] = CSharpExpressionConverter.ConvertToken(sAPScrollSAPTablemoveVerticalScrollbar);
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
                sAPScrollSAPTable["VerticalScrollbarPosition"] = CSharpExpressionConverter.ConvertToken(sAPScrollSAPTableverticalScrollbarPosition);
                sAPScrollSAPTablepropCount++;
            }

            sAPScrollSAPTablepropCount++;
            sAPScrollSAPTable["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPScrollSAPTableworkflow);
            if (sAPScrollSAPTablepropCount > 0)
            {
                callPayload.Body = sAPScrollSAPTable;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetTableVisibleTextContentsResponse> SAPGetTableVisibleTextContents(Expression<Func<string>> sAPGetTableVisibleTextContentssearchSAPElementId, Expression<Func<string>> sAPGetTableVisibleTextContentsworkflow, Expression<Func<int>> sAPGetTableVisibleTextContentsfirstVisibleRowToReturn = null, Expression<Func<int>> sAPGetTableVisibleTextContentsmaxRowsToReturn = null, Expression<Func<int>> sAPGetTableVisibleTextContentsfirstVisibleColumnToReturn = null, Expression<Func<int>> sAPGetTableVisibleTextContentsmaxColumnsToReturn = null, Expression<Func<bool>> sAPGetTableVisibleTextContentsuseColumnHeadersFromTable = null, Expression<Func<bool>> sAPGetTableVisibleTextContentsreturnRowIndexInOutputCollection = null, Expression<Func<string>> sAPGetTableVisibleTextContentsnameOfColumnToStoreRowIndex = null, Expression<Func<string>> sAPGetTableVisibleTextContentscheckedElementValue = null)
        {
            var apiCallPath = "/SAPGUI/SAPGetTableVisibleTextContents";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPGetTableVisibleTextContents = new JObject();
            var sAPGetTableVisibleTextContentspropCount = 0;
            sAPGetTableVisibleTextContentspropCount++;
            sAPGetTableVisibleTextContents["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPGetTableVisibleTextContentssearchSAPElementId);
            if (sAPGetTableVisibleTextContentsfirstVisibleRowToReturn != null)
            {
                if (sAPGetTableVisibleTextContentsfirstVisibleRowToReturn != null)
                {
                    sAPGetTableVisibleTextContents["FirstVisibleRowToReturn"] = CSharpExpressionConverter.ConvertToken(sAPGetTableVisibleTextContentsfirstVisibleRowToReturn);
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
                    sAPGetTableVisibleTextContents["MaxRowsToReturn"] = CSharpExpressionConverter.ConvertToken(sAPGetTableVisibleTextContentsmaxRowsToReturn);
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
                    sAPGetTableVisibleTextContents["FirstVisibleColumnToReturn"] = CSharpExpressionConverter.ConvertToken(sAPGetTableVisibleTextContentsfirstVisibleColumnToReturn);
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
                    sAPGetTableVisibleTextContents["MaxColumnsToReturn"] = CSharpExpressionConverter.ConvertToken(sAPGetTableVisibleTextContentsmaxColumnsToReturn);
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
                    sAPGetTableVisibleTextContents["UseColumnHeadersFromTable"] = CSharpExpressionConverter.ConvertToken(sAPGetTableVisibleTextContentsuseColumnHeadersFromTable);
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
                    sAPGetTableVisibleTextContents["ReturnRowIndexInOutputCollection"] = CSharpExpressionConverter.ConvertToken(sAPGetTableVisibleTextContentsreturnRowIndexInOutputCollection);
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
                sAPGetTableVisibleTextContents["NameOfColumnToStoreRowIndex"] = CSharpExpressionConverter.ConvertToken(sAPGetTableVisibleTextContentsnameOfColumnToStoreRowIndex);
                sAPGetTableVisibleTextContentspropCount++;
            }

            if (sAPGetTableVisibleTextContentscheckedElementValue != null)
            {
                if (sAPGetTableVisibleTextContentscheckedElementValue != null)
                {
                    sAPGetTableVisibleTextContents["CheckedElementValue"] = CSharpExpressionConverter.ConvertToken(sAPGetTableVisibleTextContentscheckedElementValue);
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
            sAPGetTableVisibleTextContents["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPGetTableVisibleTextContentsworkflow);
            if (sAPGetTableVisibleTextContentspropCount > 0)
            {
                callPayload.Body = sAPGetTableVisibleTextContents;
            }

            return new ApiConnectionAction<SAPGetTableVisibleTextContentsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPSelectSAPTableRow(Expression<Func<string>> sAPSelectSAPTableRowsearchSAPElementId, Expression<Func<string>> sAPSelectSAPTableRowworkflow, Expression<Func<int>> sAPSelectSAPTableRowvisibleRowIndex = null, Expression<Func<bool>> sAPSelectSAPTableRowselect = null)
        {
            var apiCallPath = "/SAPGUI/SAPSelectSAPTableRow";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPSelectSAPTableRow = new JObject();
            var sAPSelectSAPTableRowpropCount = 0;
            sAPSelectSAPTableRowpropCount++;
            sAPSelectSAPTableRow["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPSelectSAPTableRowsearchSAPElementId);
            if (sAPSelectSAPTableRowvisibleRowIndex != null)
            {
                if (sAPSelectSAPTableRowvisibleRowIndex != null)
                {
                    sAPSelectSAPTableRow["VisibleRowIndex"] = CSharpExpressionConverter.ConvertToken(sAPSelectSAPTableRowvisibleRowIndex);
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
                    sAPSelectSAPTableRow["Select"] = CSharpExpressionConverter.ConvertToken(sAPSelectSAPTableRowselect);
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
            sAPSelectSAPTableRow["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPSelectSAPTableRowworkflow);
            if (sAPSelectSAPTableRowpropCount > 0)
            {
                callPayload.Body = sAPSelectSAPTableRow;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPSelectSAPTableColumn(Expression<Func<string>> sAPSelectSAPTableColumnsearchSAPElementId, Expression<Func<string>> sAPSelectSAPTableColumnworkflow, Expression<Func<int>> sAPSelectSAPTableColumnvisibleColumnIndex = null, Expression<Func<bool>> sAPSelectSAPTableColumnselect = null)
        {
            var apiCallPath = "/SAPGUI/SAPSelectSAPTableColumn";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPSelectSAPTableColumn = new JObject();
            var sAPSelectSAPTableColumnpropCount = 0;
            sAPSelectSAPTableColumnpropCount++;
            sAPSelectSAPTableColumn["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPSelectSAPTableColumnsearchSAPElementId);
            if (sAPSelectSAPTableColumnvisibleColumnIndex != null)
            {
                if (sAPSelectSAPTableColumnvisibleColumnIndex != null)
                {
                    sAPSelectSAPTableColumn["VisibleColumnIndex"] = CSharpExpressionConverter.ConvertToken(sAPSelectSAPTableColumnvisibleColumnIndex);
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
                    sAPSelectSAPTableColumn["Select"] = CSharpExpressionConverter.ConvertToken(sAPSelectSAPTableColumnselect);
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
            sAPSelectSAPTableColumn["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPSelectSAPTableColumnworkflow);
            if (sAPSelectSAPTableColumnpropCount > 0)
            {
                callPayload.Body = sAPSelectSAPTableColumn;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetTreeNodesResponse> SAPGetTreeNodes(Expression<Func<string>> sAPGetTreeNodessearchSAPElementId, Expression<Func<string>> sAPGetTreeNodesworkflow, Expression<Func<string>> sAPGetTreeNodesparentNodeKey = null, Expression<Func<bool>> sAPGetTreeNodesprocessSubNodes = null)
        {
            var apiCallPath = "/SAPGUI/SAPGetTreeNodes";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPGetTreeNodes = new JObject();
            var sAPGetTreeNodespropCount = 0;
            sAPGetTreeNodespropCount++;
            sAPGetTreeNodes["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPGetTreeNodessearchSAPElementId);
            if (sAPGetTreeNodesparentNodeKey != null)
            {
                sAPGetTreeNodes["ParentNodeKey"] = CSharpExpressionConverter.ConvertToken(sAPGetTreeNodesparentNodeKey);
                sAPGetTreeNodespropCount++;
            }

            if (sAPGetTreeNodesprocessSubNodes != null)
            {
                if (sAPGetTreeNodesprocessSubNodes != null)
                {
                    sAPGetTreeNodes["ProcessSubNodes"] = CSharpExpressionConverter.ConvertToken(sAPGetTreeNodesprocessSubNodes);
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
            sAPGetTreeNodes["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPGetTreeNodesworkflow);
            if (sAPGetTreeNodespropCount > 0)
            {
                callPayload.Body = sAPGetTreeNodes;
            }

            return new ApiConnectionAction<SAPGetTreeNodesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPDoubleClickTreeItem(Expression<Func<string>> sAPDoubleClickTreeItemsearchSAPElementId, Expression<Func<string>> sAPDoubleClickTreeItemworkflow, Expression<Func<string>> sAPDoubleClickTreeItemsearchNodeKey = null, Expression<Func<string>> sAPDoubleClickTreeItemsearchNodePath = null, Expression<Func<string>> sAPDoubleClickTreeItemsearchNodeText = null, Expression<Func<bool>> sAPDoubleClickTreeItemsearchNodeTextIsRegularExpression = null, Expression<Func<bool>> sAPDoubleClickTreeItemsearchNodeTextIsCaseSensitive = null, Expression<Func<string>> sAPDoubleClickTreeItemsearchColumnName = null, Expression<Func<string>> sAPDoubleClickTreeItemsearchColumnTitle = null, Expression<Func<bool>> sAPDoubleClickTreeItemsearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPDoubleClickTreeItemsearchColumnTitleIsCaseSensitive = null)
        {
            var apiCallPath = "/SAPGUI/SAPDoubleClickTreeItem";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPDoubleClickTreeItem = new JObject();
            var sAPDoubleClickTreeItempropCount = 0;
            sAPDoubleClickTreeItempropCount++;
            sAPDoubleClickTreeItem["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPDoubleClickTreeItemsearchSAPElementId);
            if (sAPDoubleClickTreeItemsearchNodeKey != null)
            {
                sAPDoubleClickTreeItem["SearchNodeKey"] = CSharpExpressionConverter.ConvertToken(sAPDoubleClickTreeItemsearchNodeKey);
                sAPDoubleClickTreeItempropCount++;
            }

            if (sAPDoubleClickTreeItemsearchNodePath != null)
            {
                sAPDoubleClickTreeItem["SearchNodePath"] = CSharpExpressionConverter.ConvertToken(sAPDoubleClickTreeItemsearchNodePath);
                sAPDoubleClickTreeItempropCount++;
            }

            if (sAPDoubleClickTreeItemsearchNodeText != null)
            {
                sAPDoubleClickTreeItem["SearchNodeText"] = CSharpExpressionConverter.ConvertToken(sAPDoubleClickTreeItemsearchNodeText);
                sAPDoubleClickTreeItempropCount++;
            }

            if (sAPDoubleClickTreeItemsearchNodeTextIsRegularExpression != null)
            {
                if (sAPDoubleClickTreeItemsearchNodeTextIsRegularExpression != null)
                {
                    sAPDoubleClickTreeItem["SearchNodeTextIsRegularExpression"] = CSharpExpressionConverter.ConvertToken(sAPDoubleClickTreeItemsearchNodeTextIsRegularExpression);
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
                    sAPDoubleClickTreeItem["SearchNodeTextIsCaseSensitive"] = CSharpExpressionConverter.ConvertToken(sAPDoubleClickTreeItemsearchNodeTextIsCaseSensitive);
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
                sAPDoubleClickTreeItem["SearchColumnName"] = CSharpExpressionConverter.ConvertToken(sAPDoubleClickTreeItemsearchColumnName);
                sAPDoubleClickTreeItempropCount++;
            }

            if (sAPDoubleClickTreeItemsearchColumnTitle != null)
            {
                sAPDoubleClickTreeItem["SearchColumnTitle"] = CSharpExpressionConverter.ConvertToken(sAPDoubleClickTreeItemsearchColumnTitle);
                sAPDoubleClickTreeItempropCount++;
            }

            if (sAPDoubleClickTreeItemsearchColumnTitleIsRegularExpression != null)
            {
                if (sAPDoubleClickTreeItemsearchColumnTitleIsRegularExpression != null)
                {
                    sAPDoubleClickTreeItem["SearchColumnTitleIsRegularExpression"] = CSharpExpressionConverter.ConvertToken(sAPDoubleClickTreeItemsearchColumnTitleIsRegularExpression);
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
                    sAPDoubleClickTreeItem["SearchColumnTitleIsCaseSensitive"] = CSharpExpressionConverter.ConvertToken(sAPDoubleClickTreeItemsearchColumnTitleIsCaseSensitive);
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
            sAPDoubleClickTreeItem["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPDoubleClickTreeItemworkflow);
            if (sAPDoubleClickTreeItempropCount > 0)
            {
                callPayload.Body = sAPDoubleClickTreeItem;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPSelectTreeItem(Expression<Func<string>> sAPSelectTreeItemsearchSAPElementId, Expression<Func<string>> sAPSelectTreeItemworkflow, Expression<Func<string>> sAPSelectTreeItemsearchNodeKey = null, Expression<Func<string>> sAPSelectTreeItemsearchNodePath = null, Expression<Func<string>> sAPSelectTreeItemsearchNodeText = null, Expression<Func<bool>> sAPSelectTreeItemsearchNodeTextIsRegularExpression = null, Expression<Func<bool>> sAPSelectTreeItemsearchNodeTextIsCaseSensitive = null, Expression<Func<string>> sAPSelectTreeItemsearchColumnName = null, Expression<Func<string>> sAPSelectTreeItemsearchColumnTitle = null, Expression<Func<bool>> sAPSelectTreeItemsearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPSelectTreeItemsearchColumnTitleIsCaseSensitive = null, Expression<Func<bool>> sAPSelectTreeItemselect = null, Expression<Func<bool>> sAPSelectTreeItemdeselectAllFirst = null)
        {
            var apiCallPath = "/SAPGUI/SAPSelectTreeItem";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPSelectTreeItem = new JObject();
            var sAPSelectTreeItempropCount = 0;
            sAPSelectTreeItempropCount++;
            sAPSelectTreeItem["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPSelectTreeItemsearchSAPElementId);
            if (sAPSelectTreeItemsearchNodeKey != null)
            {
                sAPSelectTreeItem["SearchNodeKey"] = CSharpExpressionConverter.ConvertToken(sAPSelectTreeItemsearchNodeKey);
                sAPSelectTreeItempropCount++;
            }

            if (sAPSelectTreeItemsearchNodePath != null)
            {
                sAPSelectTreeItem["SearchNodePath"] = CSharpExpressionConverter.ConvertToken(sAPSelectTreeItemsearchNodePath);
                sAPSelectTreeItempropCount++;
            }

            if (sAPSelectTreeItemsearchNodeText != null)
            {
                sAPSelectTreeItem["SearchNodeText"] = CSharpExpressionConverter.ConvertToken(sAPSelectTreeItemsearchNodeText);
                sAPSelectTreeItempropCount++;
            }

            if (sAPSelectTreeItemsearchNodeTextIsRegularExpression != null)
            {
                if (sAPSelectTreeItemsearchNodeTextIsRegularExpression != null)
                {
                    sAPSelectTreeItem["SearchNodeTextIsRegularExpression"] = CSharpExpressionConverter.ConvertToken(sAPSelectTreeItemsearchNodeTextIsRegularExpression);
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
                    sAPSelectTreeItem["SearchNodeTextIsCaseSensitive"] = CSharpExpressionConverter.ConvertToken(sAPSelectTreeItemsearchNodeTextIsCaseSensitive);
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
                sAPSelectTreeItem["SearchColumnName"] = CSharpExpressionConverter.ConvertToken(sAPSelectTreeItemsearchColumnName);
                sAPSelectTreeItempropCount++;
            }

            if (sAPSelectTreeItemsearchColumnTitle != null)
            {
                sAPSelectTreeItem["SearchColumnTitle"] = CSharpExpressionConverter.ConvertToken(sAPSelectTreeItemsearchColumnTitle);
                sAPSelectTreeItempropCount++;
            }

            if (sAPSelectTreeItemsearchColumnTitleIsRegularExpression != null)
            {
                if (sAPSelectTreeItemsearchColumnTitleIsRegularExpression != null)
                {
                    sAPSelectTreeItem["SearchColumnTitleIsRegularExpression"] = CSharpExpressionConverter.ConvertToken(sAPSelectTreeItemsearchColumnTitleIsRegularExpression);
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
                    sAPSelectTreeItem["SearchColumnTitleIsCaseSensitive"] = CSharpExpressionConverter.ConvertToken(sAPSelectTreeItemsearchColumnTitleIsCaseSensitive);
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
                    sAPSelectTreeItem["Select"] = CSharpExpressionConverter.ConvertToken(sAPSelectTreeItemselect);
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
                    sAPSelectTreeItem["DeselectAllFirst"] = CSharpExpressionConverter.ConvertToken(sAPSelectTreeItemdeselectAllFirst);
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
            sAPSelectTreeItem["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPSelectTreeItemworkflow);
            if (sAPSelectTreeItempropCount > 0)
            {
                callPayload.Body = sAPSelectTreeItem;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPExpandTreeNode(Expression<Func<string>> sAPExpandTreeNodesearchSAPElementId, Expression<Func<string>> sAPExpandTreeNodeworkflow, Expression<Func<string>> sAPExpandTreeNodesearchNodeKey = null, Expression<Func<string>> sAPExpandTreeNodesearchNodePath = null, Expression<Func<string>> sAPExpandTreeNodesearchNodeText = null, Expression<Func<bool>> sAPExpandTreeNodesearchNodeTextIsRegularExpression = null, Expression<Func<bool>> sAPExpandTreeNodesearchNodeTextIsCaseSensitive = null, Expression<Func<bool>> sAPExpandTreeNodeexpand = null)
        {
            var apiCallPath = "/SAPGUI/SAPExpandTreeNode";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPExpandTreeNode = new JObject();
            var sAPExpandTreeNodepropCount = 0;
            sAPExpandTreeNodepropCount++;
            sAPExpandTreeNode["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPExpandTreeNodesearchSAPElementId);
            if (sAPExpandTreeNodesearchNodeKey != null)
            {
                sAPExpandTreeNode["SearchNodeKey"] = CSharpExpressionConverter.ConvertToken(sAPExpandTreeNodesearchNodeKey);
                sAPExpandTreeNodepropCount++;
            }

            if (sAPExpandTreeNodesearchNodePath != null)
            {
                sAPExpandTreeNode["SearchNodePath"] = CSharpExpressionConverter.ConvertToken(sAPExpandTreeNodesearchNodePath);
                sAPExpandTreeNodepropCount++;
            }

            if (sAPExpandTreeNodesearchNodeText != null)
            {
                sAPExpandTreeNode["SearchNodeText"] = CSharpExpressionConverter.ConvertToken(sAPExpandTreeNodesearchNodeText);
                sAPExpandTreeNodepropCount++;
            }

            if (sAPExpandTreeNodesearchNodeTextIsRegularExpression != null)
            {
                if (sAPExpandTreeNodesearchNodeTextIsRegularExpression != null)
                {
                    sAPExpandTreeNode["SearchNodeTextIsRegularExpression"] = CSharpExpressionConverter.ConvertToken(sAPExpandTreeNodesearchNodeTextIsRegularExpression);
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
                    sAPExpandTreeNode["SearchNodeTextIsCaseSensitive"] = CSharpExpressionConverter.ConvertToken(sAPExpandTreeNodesearchNodeTextIsCaseSensitive);
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
                    sAPExpandTreeNode["Expand"] = CSharpExpressionConverter.ConvertToken(sAPExpandTreeNodeexpand);
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
            sAPExpandTreeNode["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPExpandTreeNodeworkflow);
            if (sAPExpandTreeNodepropCount > 0)
            {
                callPayload.Body = sAPExpandTreeNode;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPDeselectAllTreeNodes(Expression<Func<string>> sAPDeselectAllTreeNodessearchSAPElementId, Expression<Func<string>> sAPDeselectAllTreeNodesworkflow)
        {
            var apiCallPath = "/SAPGUI/SAPDeselectAllTreeNodes";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPDeselectAllTreeNodes = new JObject();
            var sAPDeselectAllTreeNodespropCount = 0;
            sAPDeselectAllTreeNodespropCount++;
            sAPDeselectAllTreeNodes["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPDeselectAllTreeNodessearchSAPElementId);
            sAPDeselectAllTreeNodespropCount++;
            sAPDeselectAllTreeNodes["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPDeselectAllTreeNodesworkflow);
            if (sAPDeselectAllTreeNodespropCount > 0)
            {
                callPayload.Body = sAPDeselectAllTreeNodes;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPPressKeyOnTree(Expression<Func<string>> sAPPressKeyOnTreesearchSAPElementId, Expression<Func<string>> sAPPressKeyOnTreekey, Expression<Func<string>> sAPPressKeyOnTreeworkflow)
        {
            var apiCallPath = "/SAPGUI/SAPPressKeyOnTree";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPPressKeyOnTree = new JObject();
            var sAPPressKeyOnTreepropCount = 0;
            sAPPressKeyOnTreepropCount++;
            sAPPressKeyOnTree["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPPressKeyOnTreesearchSAPElementId);
            sAPPressKeyOnTreepropCount++;
            sAPPressKeyOnTree["Key"] = CSharpExpressionConverter.ConvertToken(sAPPressKeyOnTreekey);
            sAPPressKeyOnTreepropCount++;
            sAPPressKeyOnTree["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPPressKeyOnTreeworkflow);
            if (sAPPressKeyOnTreepropCount > 0)
            {
                callPayload.Body = sAPPressKeyOnTree;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPOpenContextMenuOnTreeItem(Expression<Func<string>> sAPOpenContextMenuOnTreeItemsearchSAPElementId, Expression<Func<string>> sAPOpenContextMenuOnTreeItemworkflow, Expression<Func<string>> sAPOpenContextMenuOnTreeItemsearchNodeKey = null, Expression<Func<string>> sAPOpenContextMenuOnTreeItemsearchNodePath = null, Expression<Func<string>> sAPOpenContextMenuOnTreeItemsearchNodeText = null, Expression<Func<bool>> sAPOpenContextMenuOnTreeItemsearchNodeTextIsRegularExpression = null, Expression<Func<bool>> sAPOpenContextMenuOnTreeItemsearchNodeTextIsCaseSensitive = null, Expression<Func<string>> sAPOpenContextMenuOnTreeItemsearchColumnName = null, Expression<Func<string>> sAPOpenContextMenuOnTreeItemsearchColumnTitle = null, Expression<Func<bool>> sAPOpenContextMenuOnTreeItemsearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPOpenContextMenuOnTreeItemsearchColumnTitleIsCaseSensitive = null)
        {
            var apiCallPath = "/SAPGUI/SAPOpenContextMenuOnTreeItem";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPOpenContextMenuOnTreeItem = new JObject();
            var sAPOpenContextMenuOnTreeItempropCount = 0;
            sAPOpenContextMenuOnTreeItempropCount++;
            sAPOpenContextMenuOnTreeItem["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPOpenContextMenuOnTreeItemsearchSAPElementId);
            if (sAPOpenContextMenuOnTreeItemsearchNodeKey != null)
            {
                sAPOpenContextMenuOnTreeItem["SearchNodeKey"] = CSharpExpressionConverter.ConvertToken(sAPOpenContextMenuOnTreeItemsearchNodeKey);
                sAPOpenContextMenuOnTreeItempropCount++;
            }

            if (sAPOpenContextMenuOnTreeItemsearchNodePath != null)
            {
                sAPOpenContextMenuOnTreeItem["SearchNodePath"] = CSharpExpressionConverter.ConvertToken(sAPOpenContextMenuOnTreeItemsearchNodePath);
                sAPOpenContextMenuOnTreeItempropCount++;
            }

            if (sAPOpenContextMenuOnTreeItemsearchNodeText != null)
            {
                sAPOpenContextMenuOnTreeItem["SearchNodeText"] = CSharpExpressionConverter.ConvertToken(sAPOpenContextMenuOnTreeItemsearchNodeText);
                sAPOpenContextMenuOnTreeItempropCount++;
            }

            if (sAPOpenContextMenuOnTreeItemsearchNodeTextIsRegularExpression != null)
            {
                if (sAPOpenContextMenuOnTreeItemsearchNodeTextIsRegularExpression != null)
                {
                    sAPOpenContextMenuOnTreeItem["SearchNodeTextIsRegularExpression"] = CSharpExpressionConverter.ConvertToken(sAPOpenContextMenuOnTreeItemsearchNodeTextIsRegularExpression);
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
                    sAPOpenContextMenuOnTreeItem["SearchNodeTextIsCaseSensitive"] = CSharpExpressionConverter.ConvertToken(sAPOpenContextMenuOnTreeItemsearchNodeTextIsCaseSensitive);
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
                sAPOpenContextMenuOnTreeItem["SearchColumnName"] = CSharpExpressionConverter.ConvertToken(sAPOpenContextMenuOnTreeItemsearchColumnName);
                sAPOpenContextMenuOnTreeItempropCount++;
            }

            if (sAPOpenContextMenuOnTreeItemsearchColumnTitle != null)
            {
                sAPOpenContextMenuOnTreeItem["SearchColumnTitle"] = CSharpExpressionConverter.ConvertToken(sAPOpenContextMenuOnTreeItemsearchColumnTitle);
                sAPOpenContextMenuOnTreeItempropCount++;
            }

            if (sAPOpenContextMenuOnTreeItemsearchColumnTitleIsRegularExpression != null)
            {
                if (sAPOpenContextMenuOnTreeItemsearchColumnTitleIsRegularExpression != null)
                {
                    sAPOpenContextMenuOnTreeItem["SearchColumnTitleIsRegularExpression"] = CSharpExpressionConverter.ConvertToken(sAPOpenContextMenuOnTreeItemsearchColumnTitleIsRegularExpression);
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
                    sAPOpenContextMenuOnTreeItem["SearchColumnTitleIsCaseSensitive"] = CSharpExpressionConverter.ConvertToken(sAPOpenContextMenuOnTreeItemsearchColumnTitleIsCaseSensitive);
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
            sAPOpenContextMenuOnTreeItem["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPOpenContextMenuOnTreeItemworkflow);
            if (sAPOpenContextMenuOnTreeItempropCount > 0)
            {
                callPayload.Body = sAPOpenContextMenuOnTreeItem;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetTreeTextContentsResponse> SAPGetTreeTextContents(Expression<Func<string>> sAPGetTreeTextContentssearchSAPElementId, Expression<Func<string>> sAPGetTreeTextContentsworkflow, Expression<Func<int>> sAPGetTreeTextContentsfirstRowToReturn = null, Expression<Func<int>> sAPGetTreeTextContentsmaxRowsToReturn = null, Expression<Func<int>> sAPGetTreeTextContentsfirstColumnToReturn = null, Expression<Func<int>> sAPGetTreeTextContentsmaxColumnsToReturn = null, Expression<Func<bool>> sAPGetTreeTextContentsuseColumnHeadersFromTree = null, Expression<Func<bool>> sAPGetTreeTextContentsreturnRowIndexInOutputCollection = null, Expression<Func<string>> sAPGetTreeTextContentsnameOfColumnToStoreRowIndex = null)
        {
            var apiCallPath = "/SAPGUI/SAPGetTreeTextContents";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPGetTreeTextContents = new JObject();
            var sAPGetTreeTextContentspropCount = 0;
            sAPGetTreeTextContentspropCount++;
            sAPGetTreeTextContents["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPGetTreeTextContentssearchSAPElementId);
            if (sAPGetTreeTextContentsfirstRowToReturn != null)
            {
                if (sAPGetTreeTextContentsfirstRowToReturn != null)
                {
                    sAPGetTreeTextContents["FirstRowToReturn"] = CSharpExpressionConverter.ConvertToken(sAPGetTreeTextContentsfirstRowToReturn);
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
                    sAPGetTreeTextContents["MaxRowsToReturn"] = CSharpExpressionConverter.ConvertToken(sAPGetTreeTextContentsmaxRowsToReturn);
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
                    sAPGetTreeTextContents["FirstColumnToReturn"] = CSharpExpressionConverter.ConvertToken(sAPGetTreeTextContentsfirstColumnToReturn);
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
                    sAPGetTreeTextContents["MaxColumnsToReturn"] = CSharpExpressionConverter.ConvertToken(sAPGetTreeTextContentsmaxColumnsToReturn);
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
                    sAPGetTreeTextContents["UseColumnHeadersFromTree"] = CSharpExpressionConverter.ConvertToken(sAPGetTreeTextContentsuseColumnHeadersFromTree);
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
                    sAPGetTreeTextContents["ReturnRowIndexInOutputCollection"] = CSharpExpressionConverter.ConvertToken(sAPGetTreeTextContentsreturnRowIndexInOutputCollection);
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
                sAPGetTreeTextContents["NameOfColumnToStoreRowIndex"] = CSharpExpressionConverter.ConvertToken(sAPGetTreeTextContentsnameOfColumnToStoreRowIndex);
                sAPGetTreeTextContentspropCount++;
            }

            sAPGetTreeTextContentspropCount++;
            sAPGetTreeTextContents["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPGetTreeTextContentsworkflow);
            if (sAPGetTreeTextContentspropCount > 0)
            {
                callPayload.Body = sAPGetTreeTextContents;
            }

            return new ApiConnectionAction<SAPGetTreeTextContentsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPSetTreeColumnWidth(Expression<Func<string>> sAPSetTreeColumnWidthsearchSAPElementId, Expression<Func<string>> sAPSetTreeColumnWidthworkflow, Expression<Func<string>> sAPSetTreeColumnWidthsearchColumnName = null, Expression<Func<string>> sAPSetTreeColumnWidthsearchColumnTitle = null, Expression<Func<bool>> sAPSetTreeColumnWidthsearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPSetTreeColumnWidthsearchColumnTitleIsCaseSensitive = null, Expression<Func<int>> sAPSetTreeColumnWidthcolumnWidthInPixels = null)
        {
            var apiCallPath = "/SAPGUI/SAPSetTreeColumnWidth";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPSetTreeColumnWidth = new JObject();
            var sAPSetTreeColumnWidthpropCount = 0;
            sAPSetTreeColumnWidthpropCount++;
            sAPSetTreeColumnWidth["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPSetTreeColumnWidthsearchSAPElementId);
            if (sAPSetTreeColumnWidthsearchColumnName != null)
            {
                sAPSetTreeColumnWidth["SearchColumnName"] = CSharpExpressionConverter.ConvertToken(sAPSetTreeColumnWidthsearchColumnName);
                sAPSetTreeColumnWidthpropCount++;
            }

            if (sAPSetTreeColumnWidthsearchColumnTitle != null)
            {
                sAPSetTreeColumnWidth["SearchColumnTitle"] = CSharpExpressionConverter.ConvertToken(sAPSetTreeColumnWidthsearchColumnTitle);
                sAPSetTreeColumnWidthpropCount++;
            }

            if (sAPSetTreeColumnWidthsearchColumnTitleIsRegularExpression != null)
            {
                if (sAPSetTreeColumnWidthsearchColumnTitleIsRegularExpression != null)
                {
                    sAPSetTreeColumnWidth["SearchColumnTitleIsRegularExpression"] = CSharpExpressionConverter.ConvertToken(sAPSetTreeColumnWidthsearchColumnTitleIsRegularExpression);
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
                    sAPSetTreeColumnWidth["SearchColumnTitleIsCaseSensitive"] = CSharpExpressionConverter.ConvertToken(sAPSetTreeColumnWidthsearchColumnTitleIsCaseSensitive);
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
                    sAPSetTreeColumnWidth["ColumnWidthInPixels"] = CSharpExpressionConverter.ConvertToken(sAPSetTreeColumnWidthcolumnWidthInPixels);
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
            sAPSetTreeColumnWidth["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPSetTreeColumnWidthworkflow);
            if (sAPSetTreeColumnWidthpropCount > 0)
            {
                callPayload.Body = sAPSetTreeColumnWidth;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPPressButtonOnTreeItem(Expression<Func<string>> sAPPressButtonOnTreeItemsearchSAPElementId, Expression<Func<string>> sAPPressButtonOnTreeItemworkflow, Expression<Func<string>> sAPPressButtonOnTreeItemsearchNodeKey = null, Expression<Func<string>> sAPPressButtonOnTreeItemsearchNodePath = null, Expression<Func<string>> sAPPressButtonOnTreeItemsearchNodeText = null, Expression<Func<bool>> sAPPressButtonOnTreeItemsearchNodeTextIsRegularExpression = null, Expression<Func<bool>> sAPPressButtonOnTreeItemsearchNodeTextIsCaseSensitive = null, Expression<Func<string>> sAPPressButtonOnTreeItemsearchColumnName = null, Expression<Func<string>> sAPPressButtonOnTreeItemsearchColumnTitle = null, Expression<Func<bool>> sAPPressButtonOnTreeItemsearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPPressButtonOnTreeItemsearchColumnTitleIsCaseSensitive = null, Expression<Func<bool>> sAPPressButtonOnTreeItemforce = null)
        {
            var apiCallPath = "/SAPGUI/SAPPressButtonOnTreeItem";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPPressButtonOnTreeItem = new JObject();
            var sAPPressButtonOnTreeItempropCount = 0;
            sAPPressButtonOnTreeItempropCount++;
            sAPPressButtonOnTreeItem["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPPressButtonOnTreeItemsearchSAPElementId);
            if (sAPPressButtonOnTreeItemsearchNodeKey != null)
            {
                sAPPressButtonOnTreeItem["SearchNodeKey"] = CSharpExpressionConverter.ConvertToken(sAPPressButtonOnTreeItemsearchNodeKey);
                sAPPressButtonOnTreeItempropCount++;
            }

            if (sAPPressButtonOnTreeItemsearchNodePath != null)
            {
                sAPPressButtonOnTreeItem["SearchNodePath"] = CSharpExpressionConverter.ConvertToken(sAPPressButtonOnTreeItemsearchNodePath);
                sAPPressButtonOnTreeItempropCount++;
            }

            if (sAPPressButtonOnTreeItemsearchNodeText != null)
            {
                sAPPressButtonOnTreeItem["SearchNodeText"] = CSharpExpressionConverter.ConvertToken(sAPPressButtonOnTreeItemsearchNodeText);
                sAPPressButtonOnTreeItempropCount++;
            }

            if (sAPPressButtonOnTreeItemsearchNodeTextIsRegularExpression != null)
            {
                if (sAPPressButtonOnTreeItemsearchNodeTextIsRegularExpression != null)
                {
                    sAPPressButtonOnTreeItem["SearchNodeTextIsRegularExpression"] = CSharpExpressionConverter.ConvertToken(sAPPressButtonOnTreeItemsearchNodeTextIsRegularExpression);
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
                    sAPPressButtonOnTreeItem["SearchNodeTextIsCaseSensitive"] = CSharpExpressionConverter.ConvertToken(sAPPressButtonOnTreeItemsearchNodeTextIsCaseSensitive);
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
                sAPPressButtonOnTreeItem["SearchColumnName"] = CSharpExpressionConverter.ConvertToken(sAPPressButtonOnTreeItemsearchColumnName);
                sAPPressButtonOnTreeItempropCount++;
            }

            if (sAPPressButtonOnTreeItemsearchColumnTitle != null)
            {
                sAPPressButtonOnTreeItem["SearchColumnTitle"] = CSharpExpressionConverter.ConvertToken(sAPPressButtonOnTreeItemsearchColumnTitle);
                sAPPressButtonOnTreeItempropCount++;
            }

            if (sAPPressButtonOnTreeItemsearchColumnTitleIsRegularExpression != null)
            {
                if (sAPPressButtonOnTreeItemsearchColumnTitleIsRegularExpression != null)
                {
                    sAPPressButtonOnTreeItem["SearchColumnTitleIsRegularExpression"] = CSharpExpressionConverter.ConvertToken(sAPPressButtonOnTreeItemsearchColumnTitleIsRegularExpression);
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
                    sAPPressButtonOnTreeItem["SearchColumnTitleIsCaseSensitive"] = CSharpExpressionConverter.ConvertToken(sAPPressButtonOnTreeItemsearchColumnTitleIsCaseSensitive);
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
                    sAPPressButtonOnTreeItem["Force"] = CSharpExpressionConverter.ConvertToken(sAPPressButtonOnTreeItemforce);
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
            sAPPressButtonOnTreeItem["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPPressButtonOnTreeItemworkflow);
            if (sAPPressButtonOnTreeItempropCount > 0)
            {
                callPayload.Body = sAPPressButtonOnTreeItem;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPClickLinkOnTreeItem(Expression<Func<string>> sAPClickLinkOnTreeItemsearchSAPElementId, Expression<Func<string>> sAPClickLinkOnTreeItemworkflow, Expression<Func<string>> sAPClickLinkOnTreeItemsearchNodeKey = null, Expression<Func<string>> sAPClickLinkOnTreeItemsearchNodePath = null, Expression<Func<string>> sAPClickLinkOnTreeItemsearchNodeText = null, Expression<Func<bool>> sAPClickLinkOnTreeItemsearchNodeTextIsRegularExpression = null, Expression<Func<bool>> sAPClickLinkOnTreeItemsearchNodeTextIsCaseSensitive = null, Expression<Func<string>> sAPClickLinkOnTreeItemsearchColumnName = null, Expression<Func<string>> sAPClickLinkOnTreeItemsearchColumnTitle = null, Expression<Func<bool>> sAPClickLinkOnTreeItemsearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPClickLinkOnTreeItemsearchColumnTitleIsCaseSensitive = null, Expression<Func<bool>> sAPClickLinkOnTreeItemforce = null)
        {
            var apiCallPath = "/SAPGUI/SAPClickLinkOnTreeItem";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPClickLinkOnTreeItem = new JObject();
            var sAPClickLinkOnTreeItempropCount = 0;
            sAPClickLinkOnTreeItempropCount++;
            sAPClickLinkOnTreeItem["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPClickLinkOnTreeItemsearchSAPElementId);
            if (sAPClickLinkOnTreeItemsearchNodeKey != null)
            {
                sAPClickLinkOnTreeItem["SearchNodeKey"] = CSharpExpressionConverter.ConvertToken(sAPClickLinkOnTreeItemsearchNodeKey);
                sAPClickLinkOnTreeItempropCount++;
            }

            if (sAPClickLinkOnTreeItemsearchNodePath != null)
            {
                sAPClickLinkOnTreeItem["SearchNodePath"] = CSharpExpressionConverter.ConvertToken(sAPClickLinkOnTreeItemsearchNodePath);
                sAPClickLinkOnTreeItempropCount++;
            }

            if (sAPClickLinkOnTreeItemsearchNodeText != null)
            {
                sAPClickLinkOnTreeItem["SearchNodeText"] = CSharpExpressionConverter.ConvertToken(sAPClickLinkOnTreeItemsearchNodeText);
                sAPClickLinkOnTreeItempropCount++;
            }

            if (sAPClickLinkOnTreeItemsearchNodeTextIsRegularExpression != null)
            {
                if (sAPClickLinkOnTreeItemsearchNodeTextIsRegularExpression != null)
                {
                    sAPClickLinkOnTreeItem["SearchNodeTextIsRegularExpression"] = CSharpExpressionConverter.ConvertToken(sAPClickLinkOnTreeItemsearchNodeTextIsRegularExpression);
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
                    sAPClickLinkOnTreeItem["SearchNodeTextIsCaseSensitive"] = CSharpExpressionConverter.ConvertToken(sAPClickLinkOnTreeItemsearchNodeTextIsCaseSensitive);
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
                sAPClickLinkOnTreeItem["SearchColumnName"] = CSharpExpressionConverter.ConvertToken(sAPClickLinkOnTreeItemsearchColumnName);
                sAPClickLinkOnTreeItempropCount++;
            }

            if (sAPClickLinkOnTreeItemsearchColumnTitle != null)
            {
                sAPClickLinkOnTreeItem["SearchColumnTitle"] = CSharpExpressionConverter.ConvertToken(sAPClickLinkOnTreeItemsearchColumnTitle);
                sAPClickLinkOnTreeItempropCount++;
            }

            if (sAPClickLinkOnTreeItemsearchColumnTitleIsRegularExpression != null)
            {
                if (sAPClickLinkOnTreeItemsearchColumnTitleIsRegularExpression != null)
                {
                    sAPClickLinkOnTreeItem["SearchColumnTitleIsRegularExpression"] = CSharpExpressionConverter.ConvertToken(sAPClickLinkOnTreeItemsearchColumnTitleIsRegularExpression);
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
                    sAPClickLinkOnTreeItem["SearchColumnTitleIsCaseSensitive"] = CSharpExpressionConverter.ConvertToken(sAPClickLinkOnTreeItemsearchColumnTitleIsCaseSensitive);
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
                    sAPClickLinkOnTreeItem["Force"] = CSharpExpressionConverter.ConvertToken(sAPClickLinkOnTreeItemforce);
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
            sAPClickLinkOnTreeItem["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPClickLinkOnTreeItemworkflow);
            if (sAPClickLinkOnTreeItempropCount > 0)
            {
                callPayload.Body = sAPClickLinkOnTreeItem;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPCheckTreeItem(Expression<Func<string>> sAPCheckTreeItemsearchSAPElementId, Expression<Func<string>> sAPCheckTreeItemworkflow, Expression<Func<string>> sAPCheckTreeItemsearchNodeKey = null, Expression<Func<string>> sAPCheckTreeItemsearchNodePath = null, Expression<Func<string>> sAPCheckTreeItemsearchNodeText = null, Expression<Func<bool>> sAPCheckTreeItemsearchNodeTextIsRegularExpression = null, Expression<Func<bool>> sAPCheckTreeItemsearchNodeTextIsCaseSensitive = null, Expression<Func<string>> sAPCheckTreeItemsearchColumnName = null, Expression<Func<string>> sAPCheckTreeItemsearchColumnTitle = null, Expression<Func<bool>> sAPCheckTreeItemsearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPCheckTreeItemsearchColumnTitleIsCaseSensitive = null, Expression<Func<bool>> sAPCheckTreeItemcheckItem = null, Expression<Func<bool>> sAPCheckTreeItemforce = null)
        {
            var apiCallPath = "/SAPGUI/SAPCheckTreeItem";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPCheckTreeItem = new JObject();
            var sAPCheckTreeItempropCount = 0;
            sAPCheckTreeItempropCount++;
            sAPCheckTreeItem["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPCheckTreeItemsearchSAPElementId);
            if (sAPCheckTreeItemsearchNodeKey != null)
            {
                sAPCheckTreeItem["SearchNodeKey"] = CSharpExpressionConverter.ConvertToken(sAPCheckTreeItemsearchNodeKey);
                sAPCheckTreeItempropCount++;
            }

            if (sAPCheckTreeItemsearchNodePath != null)
            {
                sAPCheckTreeItem["SearchNodePath"] = CSharpExpressionConverter.ConvertToken(sAPCheckTreeItemsearchNodePath);
                sAPCheckTreeItempropCount++;
            }

            if (sAPCheckTreeItemsearchNodeText != null)
            {
                sAPCheckTreeItem["SearchNodeText"] = CSharpExpressionConverter.ConvertToken(sAPCheckTreeItemsearchNodeText);
                sAPCheckTreeItempropCount++;
            }

            if (sAPCheckTreeItemsearchNodeTextIsRegularExpression != null)
            {
                if (sAPCheckTreeItemsearchNodeTextIsRegularExpression != null)
                {
                    sAPCheckTreeItem["SearchNodeTextIsRegularExpression"] = CSharpExpressionConverter.ConvertToken(sAPCheckTreeItemsearchNodeTextIsRegularExpression);
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
                    sAPCheckTreeItem["SearchNodeTextIsCaseSensitive"] = CSharpExpressionConverter.ConvertToken(sAPCheckTreeItemsearchNodeTextIsCaseSensitive);
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
                sAPCheckTreeItem["SearchColumnName"] = CSharpExpressionConverter.ConvertToken(sAPCheckTreeItemsearchColumnName);
                sAPCheckTreeItempropCount++;
            }

            if (sAPCheckTreeItemsearchColumnTitle != null)
            {
                sAPCheckTreeItem["SearchColumnTitle"] = CSharpExpressionConverter.ConvertToken(sAPCheckTreeItemsearchColumnTitle);
                sAPCheckTreeItempropCount++;
            }

            if (sAPCheckTreeItemsearchColumnTitleIsRegularExpression != null)
            {
                if (sAPCheckTreeItemsearchColumnTitleIsRegularExpression != null)
                {
                    sAPCheckTreeItem["SearchColumnTitleIsRegularExpression"] = CSharpExpressionConverter.ConvertToken(sAPCheckTreeItemsearchColumnTitleIsRegularExpression);
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
                    sAPCheckTreeItem["SearchColumnTitleIsCaseSensitive"] = CSharpExpressionConverter.ConvertToken(sAPCheckTreeItemsearchColumnTitleIsCaseSensitive);
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
                    sAPCheckTreeItem["CheckItem"] = CSharpExpressionConverter.ConvertToken(sAPCheckTreeItemcheckItem);
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
                    sAPCheckTreeItem["Force"] = CSharpExpressionConverter.ConvertToken(sAPCheckTreeItemforce);
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
            sAPCheckTreeItem["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPCheckTreeItemworkflow);
            if (sAPCheckTreeItempropCount > 0)
            {
                callPayload.Body = sAPCheckTreeItem;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetTreeColumnHeadersResponse> SAPGetTreeColumnHeaders(Expression<Func<string>> sAPGetTreeColumnHeaderssearchSAPElementId, Expression<Func<string>> sAPGetTreeColumnHeadersworkflow)
        {
            var apiCallPath = "/SAPGUI/SAPGetTreeColumnHeaders";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPGetTreeColumnHeaders = new JObject();
            var sAPGetTreeColumnHeaderspropCount = 0;
            sAPGetTreeColumnHeaderspropCount++;
            sAPGetTreeColumnHeaders["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPGetTreeColumnHeaderssearchSAPElementId);
            sAPGetTreeColumnHeaderspropCount++;
            sAPGetTreeColumnHeaders["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPGetTreeColumnHeadersworkflow);
            if (sAPGetTreeColumnHeaderspropCount > 0)
            {
                callPayload.Body = sAPGetTreeColumnHeaders;
            }

            return new ApiConnectionAction<SAPGetTreeColumnHeadersResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetTreeItemPropertiesResponse> SAPGetTreeItemProperties(Expression<Func<string>> sAPGetTreeItemPropertiessearchSAPElementId, Expression<Func<string>> sAPGetTreeItemPropertiesworkflow, Expression<Func<string>> sAPGetTreeItemPropertiessearchNodeKey = null, Expression<Func<string>> sAPGetTreeItemPropertiessearchNodePath = null, Expression<Func<string>> sAPGetTreeItemPropertiessearchNodeText = null, Expression<Func<bool>> sAPGetTreeItemPropertiessearchNodeTextIsRegularExpression = null, Expression<Func<bool>> sAPGetTreeItemPropertiessearchNodeTextIsCaseSensitive = null, Expression<Func<string>> sAPGetTreeItemPropertiessearchColumnName = null, Expression<Func<string>> sAPGetTreeItemPropertiessearchColumnTitle = null, Expression<Func<bool>> sAPGetTreeItemPropertiessearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPGetTreeItemPropertiessearchColumnTitleIsCaseSensitive = null)
        {
            var apiCallPath = "/SAPGUI/SAPGetTreeItemProperties";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPGetTreeItemProperties = new JObject();
            var sAPGetTreeItemPropertiespropCount = 0;
            sAPGetTreeItemPropertiespropCount++;
            sAPGetTreeItemProperties["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPGetTreeItemPropertiessearchSAPElementId);
            if (sAPGetTreeItemPropertiessearchNodeKey != null)
            {
                sAPGetTreeItemProperties["SearchNodeKey"] = CSharpExpressionConverter.ConvertToken(sAPGetTreeItemPropertiessearchNodeKey);
                sAPGetTreeItemPropertiespropCount++;
            }

            if (sAPGetTreeItemPropertiessearchNodePath != null)
            {
                sAPGetTreeItemProperties["SearchNodePath"] = CSharpExpressionConverter.ConvertToken(sAPGetTreeItemPropertiessearchNodePath);
                sAPGetTreeItemPropertiespropCount++;
            }

            if (sAPGetTreeItemPropertiessearchNodeText != null)
            {
                sAPGetTreeItemProperties["SearchNodeText"] = CSharpExpressionConverter.ConvertToken(sAPGetTreeItemPropertiessearchNodeText);
                sAPGetTreeItemPropertiespropCount++;
            }

            if (sAPGetTreeItemPropertiessearchNodeTextIsRegularExpression != null)
            {
                if (sAPGetTreeItemPropertiessearchNodeTextIsRegularExpression != null)
                {
                    sAPGetTreeItemProperties["SearchNodeTextIsRegularExpression"] = CSharpExpressionConverter.ConvertToken(sAPGetTreeItemPropertiessearchNodeTextIsRegularExpression);
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
                    sAPGetTreeItemProperties["SearchNodeTextIsCaseSensitive"] = CSharpExpressionConverter.ConvertToken(sAPGetTreeItemPropertiessearchNodeTextIsCaseSensitive);
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
                sAPGetTreeItemProperties["SearchColumnName"] = CSharpExpressionConverter.ConvertToken(sAPGetTreeItemPropertiessearchColumnName);
                sAPGetTreeItemPropertiespropCount++;
            }

            if (sAPGetTreeItemPropertiessearchColumnTitle != null)
            {
                sAPGetTreeItemProperties["SearchColumnTitle"] = CSharpExpressionConverter.ConvertToken(sAPGetTreeItemPropertiessearchColumnTitle);
                sAPGetTreeItemPropertiespropCount++;
            }

            if (sAPGetTreeItemPropertiessearchColumnTitleIsRegularExpression != null)
            {
                if (sAPGetTreeItemPropertiessearchColumnTitleIsRegularExpression != null)
                {
                    sAPGetTreeItemProperties["SearchColumnTitleIsRegularExpression"] = CSharpExpressionConverter.ConvertToken(sAPGetTreeItemPropertiessearchColumnTitleIsRegularExpression);
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
                    sAPGetTreeItemProperties["SearchColumnTitleIsCaseSensitive"] = CSharpExpressionConverter.ConvertToken(sAPGetTreeItemPropertiessearchColumnTitleIsCaseSensitive);
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
            sAPGetTreeItemProperties["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPGetTreeItemPropertiesworkflow);
            if (sAPGetTreeItemPropertiespropCount > 0)
            {
                callPayload.Body = sAPGetTreeItemProperties;
            }

            return new ApiConnectionAction<SAPGetTreeItemPropertiesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetShellToolbarElementsResponse> SAPGetShellToolbarElements(Expression<Func<string>> sAPGetShellToolbarElementssearchSAPElementId, Expression<Func<string>> sAPGetShellToolbarElementsworkflow)
        {
            var apiCallPath = "/SAPGUI/SAPGetShellToolbarElements";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPGetShellToolbarElements = new JObject();
            var sAPGetShellToolbarElementspropCount = 0;
            sAPGetShellToolbarElementspropCount++;
            sAPGetShellToolbarElements["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPGetShellToolbarElementssearchSAPElementId);
            sAPGetShellToolbarElementspropCount++;
            sAPGetShellToolbarElements["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPGetShellToolbarElementsworkflow);
            if (sAPGetShellToolbarElementspropCount > 0)
            {
                callPayload.Body = sAPGetShellToolbarElements;
            }

            return new ApiConnectionAction<SAPGetShellToolbarElementsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPPressShellToolbarElement(Expression<Func<string>> sAPPressShellToolbarElementsearchSAPElementId, Expression<Func<string>> sAPPressShellToolbarElementworkflow, Expression<Func<string>> sAPPressShellToolbarElementsearchToolbarElementId = null, Expression<Func<string>> sAPPressShellToolbarElementsearchToolbarElementText = null, Expression<Func<int>> sAPPressShellToolbarElementsearchToolbarElementIndex = null, Expression<Func<bool>> sAPPressShellToolbarElementsearchToolbarTextIsRegularExpression = null, Expression<Func<bool>> sAPPressShellToolbarElementsearchToolbarTextIsCaseSensitive = null)
        {
            var apiCallPath = "/SAPGUI/SAPPressShellToolbarElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPPressShellToolbarElement = new JObject();
            var sAPPressShellToolbarElementpropCount = 0;
            sAPPressShellToolbarElementpropCount++;
            sAPPressShellToolbarElement["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPPressShellToolbarElementsearchSAPElementId);
            if (sAPPressShellToolbarElementsearchToolbarElementId != null)
            {
                sAPPressShellToolbarElement["SearchToolbarElementId"] = CSharpExpressionConverter.ConvertToken(sAPPressShellToolbarElementsearchToolbarElementId);
                sAPPressShellToolbarElementpropCount++;
            }

            if (sAPPressShellToolbarElementsearchToolbarElementText != null)
            {
                sAPPressShellToolbarElement["SearchToolbarElementText"] = CSharpExpressionConverter.ConvertToken(sAPPressShellToolbarElementsearchToolbarElementText);
                sAPPressShellToolbarElementpropCount++;
            }

            if (sAPPressShellToolbarElementsearchToolbarElementIndex != null)
            {
                if (sAPPressShellToolbarElementsearchToolbarElementIndex != null)
                {
                    sAPPressShellToolbarElement["SearchToolbarElementIndex"] = CSharpExpressionConverter.ConvertToken(sAPPressShellToolbarElementsearchToolbarElementIndex);
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
                    sAPPressShellToolbarElement["SearchToolbarTextIsRegularExpression"] = CSharpExpressionConverter.ConvertToken(sAPPressShellToolbarElementsearchToolbarTextIsRegularExpression);
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
                    sAPPressShellToolbarElement["SearchToolbarTextIsCaseSensitive"] = CSharpExpressionConverter.ConvertToken(sAPPressShellToolbarElementsearchToolbarTextIsCaseSensitive);
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
            sAPPressShellToolbarElement["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPPressShellToolbarElementworkflow);
            if (sAPPressShellToolbarElementpropCount > 0)
            {
                callPayload.Body = sAPPressShellToolbarElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPPressShellToolbarElementContextButton(Expression<Func<string>> sAPPressShellToolbarElementContextButtonsearchSAPElementId, Expression<Func<string>> sAPPressShellToolbarElementContextButtonworkflow, Expression<Func<string>> sAPPressShellToolbarElementContextButtonsearchToolbarElementId = null, Expression<Func<string>> sAPPressShellToolbarElementContextButtonsearchToolbarElementText = null, Expression<Func<int>> sAPPressShellToolbarElementContextButtonsearchToolbarElementIndex = null, Expression<Func<bool>> sAPPressShellToolbarElementContextButtonsearchToolbarTextIsRegularExpression = null, Expression<Func<bool>> sAPPressShellToolbarElementContextButtonsearchToolbarTextIsCaseSensitive = null)
        {
            var apiCallPath = "/SAPGUI/SAPPressShellToolbarElementContextButton";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPPressShellToolbarElementContextButton = new JObject();
            var sAPPressShellToolbarElementContextButtonpropCount = 0;
            sAPPressShellToolbarElementContextButtonpropCount++;
            sAPPressShellToolbarElementContextButton["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPPressShellToolbarElementContextButtonsearchSAPElementId);
            if (sAPPressShellToolbarElementContextButtonsearchToolbarElementId != null)
            {
                sAPPressShellToolbarElementContextButton["SearchToolbarElementId"] = CSharpExpressionConverter.ConvertToken(sAPPressShellToolbarElementContextButtonsearchToolbarElementId);
                sAPPressShellToolbarElementContextButtonpropCount++;
            }

            if (sAPPressShellToolbarElementContextButtonsearchToolbarElementText != null)
            {
                sAPPressShellToolbarElementContextButton["SearchToolbarElementText"] = CSharpExpressionConverter.ConvertToken(sAPPressShellToolbarElementContextButtonsearchToolbarElementText);
                sAPPressShellToolbarElementContextButtonpropCount++;
            }

            if (sAPPressShellToolbarElementContextButtonsearchToolbarElementIndex != null)
            {
                if (sAPPressShellToolbarElementContextButtonsearchToolbarElementIndex != null)
                {
                    sAPPressShellToolbarElementContextButton["SearchToolbarElementIndex"] = CSharpExpressionConverter.ConvertToken(sAPPressShellToolbarElementContextButtonsearchToolbarElementIndex);
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
                    sAPPressShellToolbarElementContextButton["SearchToolbarTextIsRegularExpression"] = CSharpExpressionConverter.ConvertToken(sAPPressShellToolbarElementContextButtonsearchToolbarTextIsRegularExpression);
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
                    sAPPressShellToolbarElementContextButton["SearchToolbarTextIsCaseSensitive"] = CSharpExpressionConverter.ConvertToken(sAPPressShellToolbarElementContextButtonsearchToolbarTextIsCaseSensitive);
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
            sAPPressShellToolbarElementContextButton["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPPressShellToolbarElementContextButtonworkflow);
            if (sAPPressShellToolbarElementContextButtonpropCount > 0)
            {
                callPayload.Body = sAPPressShellToolbarElementContextButton;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPSelectShellToolbarMenuItem(Expression<Func<string>> sAPSelectShellToolbarMenuItemsearchSAPElementId, Expression<Func<string>> sAPSelectShellToolbarMenuItemworkflow, Expression<Func<string>> sAPSelectShellToolbarMenuItemsearchToolbarElementId = null, Expression<Func<string>> sAPSelectShellToolbarMenuItemsearchToolbarElementText = null, Expression<Func<int>> sAPSelectShellToolbarMenuItemsearchToolbarElementIndex = null, Expression<Func<bool>> sAPSelectShellToolbarMenuItemsearchToolbarTextIsRegularExpression = null, Expression<Func<bool>> sAPSelectShellToolbarMenuItemsearchToolbarTextIsCaseSensitive = null)
        {
            var apiCallPath = "/SAPGUI/SAPSelectShellToolbarMenuItem";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPSelectShellToolbarMenuItem = new JObject();
            var sAPSelectShellToolbarMenuItempropCount = 0;
            sAPSelectShellToolbarMenuItempropCount++;
            sAPSelectShellToolbarMenuItem["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPSelectShellToolbarMenuItemsearchSAPElementId);
            if (sAPSelectShellToolbarMenuItemsearchToolbarElementId != null)
            {
                sAPSelectShellToolbarMenuItem["SearchToolbarElementId"] = CSharpExpressionConverter.ConvertToken(sAPSelectShellToolbarMenuItemsearchToolbarElementId);
                sAPSelectShellToolbarMenuItempropCount++;
            }

            if (sAPSelectShellToolbarMenuItemsearchToolbarElementText != null)
            {
                sAPSelectShellToolbarMenuItem["SearchToolbarElementText"] = CSharpExpressionConverter.ConvertToken(sAPSelectShellToolbarMenuItemsearchToolbarElementText);
                sAPSelectShellToolbarMenuItempropCount++;
            }

            if (sAPSelectShellToolbarMenuItemsearchToolbarElementIndex != null)
            {
                if (sAPSelectShellToolbarMenuItemsearchToolbarElementIndex != null)
                {
                    sAPSelectShellToolbarMenuItem["SearchToolbarElementIndex"] = CSharpExpressionConverter.ConvertToken(sAPSelectShellToolbarMenuItemsearchToolbarElementIndex);
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
                    sAPSelectShellToolbarMenuItem["SearchToolbarTextIsRegularExpression"] = CSharpExpressionConverter.ConvertToken(sAPSelectShellToolbarMenuItemsearchToolbarTextIsRegularExpression);
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
                    sAPSelectShellToolbarMenuItem["SearchToolbarTextIsCaseSensitive"] = CSharpExpressionConverter.ConvertToken(sAPSelectShellToolbarMenuItemsearchToolbarTextIsCaseSensitive);
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
            sAPSelectShellToolbarMenuItem["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPSelectShellToolbarMenuItemworkflow);
            if (sAPSelectShellToolbarMenuItempropCount > 0)
            {
                callPayload.Body = sAPSelectShellToolbarMenuItem;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetSAPGridViewPropertiesResponse> SAPGetSAPGridViewProperties(Expression<Func<string>> sAPGetSAPGridViewPropertiessearchSAPElementId, Expression<Func<string>> sAPGetSAPGridViewPropertiesworkflow)
        {
            var apiCallPath = "/SAPGUI/SAPGetSAPGridViewProperties";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPGetSAPGridViewProperties = new JObject();
            var sAPGetSAPGridViewPropertiespropCount = 0;
            sAPGetSAPGridViewPropertiespropCount++;
            sAPGetSAPGridViewProperties["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPGetSAPGridViewPropertiessearchSAPElementId);
            sAPGetSAPGridViewPropertiespropCount++;
            sAPGetSAPGridViewProperties["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPGetSAPGridViewPropertiesworkflow);
            if (sAPGetSAPGridViewPropertiespropCount > 0)
            {
                callPayload.Body = sAPGetSAPGridViewProperties;
            }

            return new ApiConnectionAction<SAPGetSAPGridViewPropertiesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetSAPGridViewCellContentsAtIndexResponse> SAPGetSAPGridViewCellContentsAtIndex(Expression<Func<string>> sAPGetSAPGridViewCellContentsAtIndexsearchSAPElementId, Expression<Func<int>> sAPGetSAPGridViewCellContentsAtIndexrowIndex, Expression<Func<string>> sAPGetSAPGridViewCellContentsAtIndexworkflow, Expression<Func<string>> sAPGetSAPGridViewCellContentsAtIndexsearchColumnName = null, Expression<Func<string>> sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitle = null, Expression<Func<bool>> sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitleIsCaseSensitive = null)
        {
            var apiCallPath = "/SAPGUI/SAPGetSAPGridViewCellContentsAtIndex";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPGetSAPGridViewCellContentsAtIndex = new JObject();
            var sAPGetSAPGridViewCellContentsAtIndexpropCount = 0;
            sAPGetSAPGridViewCellContentsAtIndexpropCount++;
            sAPGetSAPGridViewCellContentsAtIndex["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPGetSAPGridViewCellContentsAtIndexsearchSAPElementId);
            sAPGetSAPGridViewCellContentsAtIndexpropCount++;
            sAPGetSAPGridViewCellContentsAtIndex["RowIndex"] = CSharpExpressionConverter.ConvertToken(sAPGetSAPGridViewCellContentsAtIndexrowIndex);
            if (sAPGetSAPGridViewCellContentsAtIndexsearchColumnName != null)
            {
                sAPGetSAPGridViewCellContentsAtIndex["SearchColumnName"] = CSharpExpressionConverter.ConvertToken(sAPGetSAPGridViewCellContentsAtIndexsearchColumnName);
                sAPGetSAPGridViewCellContentsAtIndexpropCount++;
            }

            if (sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitle != null)
            {
                sAPGetSAPGridViewCellContentsAtIndex["SearchColumnTitle"] = CSharpExpressionConverter.ConvertToken(sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitle);
                sAPGetSAPGridViewCellContentsAtIndexpropCount++;
            }

            if (sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitleIsRegularExpression != null)
            {
                if (sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitleIsRegularExpression != null)
                {
                    sAPGetSAPGridViewCellContentsAtIndex["SearchColumnTitleIsRegularExpression"] = CSharpExpressionConverter.ConvertToken(sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitleIsRegularExpression);
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
                    sAPGetSAPGridViewCellContentsAtIndex["SearchColumnTitleIsCaseSensitive"] = CSharpExpressionConverter.ConvertToken(sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitleIsCaseSensitive);
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
            sAPGetSAPGridViewCellContentsAtIndex["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPGetSAPGridViewCellContentsAtIndexworkflow);
            if (sAPGetSAPGridViewCellContentsAtIndexpropCount > 0)
            {
                callPayload.Body = sAPGetSAPGridViewCellContentsAtIndex;
            }

            return new ApiConnectionAction<SAPGetSAPGridViewCellContentsAtIndexResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetSAPGridViewCellPropertiesAtIndexResponse> SAPGetSAPGridViewCellPropertiesAtIndex(Expression<Func<string>> sAPGetSAPGridViewCellPropertiesAtIndexsearchSAPElementId, Expression<Func<int>> sAPGetSAPGridViewCellPropertiesAtIndexrowIndex, Expression<Func<string>> sAPGetSAPGridViewCellPropertiesAtIndexworkflow, Expression<Func<string>> sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnName = null, Expression<Func<string>> sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitle = null, Expression<Func<bool>> sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitleIsCaseSensitive = null)
        {
            var apiCallPath = "/SAPGUI/SAPGetSAPGridViewCellPropertiesAtIndex";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPGetSAPGridViewCellPropertiesAtIndex = new JObject();
            var sAPGetSAPGridViewCellPropertiesAtIndexpropCount = 0;
            sAPGetSAPGridViewCellPropertiesAtIndexpropCount++;
            sAPGetSAPGridViewCellPropertiesAtIndex["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPGetSAPGridViewCellPropertiesAtIndexsearchSAPElementId);
            sAPGetSAPGridViewCellPropertiesAtIndexpropCount++;
            sAPGetSAPGridViewCellPropertiesAtIndex["RowIndex"] = CSharpExpressionConverter.ConvertToken(sAPGetSAPGridViewCellPropertiesAtIndexrowIndex);
            if (sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnName != null)
            {
                sAPGetSAPGridViewCellPropertiesAtIndex["SearchColumnName"] = CSharpExpressionConverter.ConvertToken(sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnName);
                sAPGetSAPGridViewCellPropertiesAtIndexpropCount++;
            }

            if (sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitle != null)
            {
                sAPGetSAPGridViewCellPropertiesAtIndex["SearchColumnTitle"] = CSharpExpressionConverter.ConvertToken(sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitle);
                sAPGetSAPGridViewCellPropertiesAtIndexpropCount++;
            }

            if (sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitleIsRegularExpression != null)
            {
                if (sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitleIsRegularExpression != null)
                {
                    sAPGetSAPGridViewCellPropertiesAtIndex["SearchColumnTitleIsRegularExpression"] = CSharpExpressionConverter.ConvertToken(sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitleIsRegularExpression);
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
                    sAPGetSAPGridViewCellPropertiesAtIndex["SearchColumnTitleIsCaseSensitive"] = CSharpExpressionConverter.ConvertToken(sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitleIsCaseSensitive);
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
            sAPGetSAPGridViewCellPropertiesAtIndex["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPGetSAPGridViewCellPropertiesAtIndexworkflow);
            if (sAPGetSAPGridViewCellPropertiesAtIndexpropCount > 0)
            {
                callPayload.Body = sAPGetSAPGridViewCellPropertiesAtIndex;
            }

            return new ApiConnectionAction<SAPGetSAPGridViewCellPropertiesAtIndexResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPDrawRectangleAroundSAPGridViewCellAtIndex(Expression<Func<string>> sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchSAPElementId, Expression<Func<int>> sAPDrawRectangleAroundSAPGridViewCellAtIndexrowIndex, Expression<Func<string>> sAPDrawRectangleAroundSAPGridViewCellAtIndexworkflow, Expression<Func<string>> sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnName = null, Expression<Func<string>> sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitle = null, Expression<Func<bool>> sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive = null, Expression<Func<string>> sAPDrawRectangleAroundSAPGridViewCellAtIndexpenColour = null, Expression<Func<int>> sAPDrawRectangleAroundSAPGridViewCellAtIndexpenThicknessPixels = null)
        {
            var apiCallPath = "/SAPGUI/SAPDrawRectangleAroundSAPGridViewCellAtIndex";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPDrawRectangleAroundSAPGridViewCellAtIndex = new JObject();
            var sAPDrawRectangleAroundSAPGridViewCellAtIndexpropCount = 0;
            sAPDrawRectangleAroundSAPGridViewCellAtIndexpropCount++;
            sAPDrawRectangleAroundSAPGridViewCellAtIndex["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchSAPElementId);
            sAPDrawRectangleAroundSAPGridViewCellAtIndexpropCount++;
            sAPDrawRectangleAroundSAPGridViewCellAtIndex["RowIndex"] = CSharpExpressionConverter.ConvertToken(sAPDrawRectangleAroundSAPGridViewCellAtIndexrowIndex);
            if (sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnName != null)
            {
                sAPDrawRectangleAroundSAPGridViewCellAtIndex["SearchColumnName"] = CSharpExpressionConverter.ConvertToken(sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnName);
                sAPDrawRectangleAroundSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitle != null)
            {
                sAPDrawRectangleAroundSAPGridViewCellAtIndex["SearchColumnTitle"] = CSharpExpressionConverter.ConvertToken(sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitle);
                sAPDrawRectangleAroundSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression != null)
            {
                if (sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression != null)
                {
                    sAPDrawRectangleAroundSAPGridViewCellAtIndex["SearchColumnTitleIsRegularExpression"] = CSharpExpressionConverter.ConvertToken(sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression);
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
                    sAPDrawRectangleAroundSAPGridViewCellAtIndex["SearchColumnTitleIsCaseSensitive"] = CSharpExpressionConverter.ConvertToken(sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive);
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
                    sAPDrawRectangleAroundSAPGridViewCellAtIndex["PenColour"] = CSharpExpressionConverter.ConvertToken(sAPDrawRectangleAroundSAPGridViewCellAtIndexpenColour);
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
                    sAPDrawRectangleAroundSAPGridViewCellAtIndex["PenThicknessPixels"] = CSharpExpressionConverter.ConvertToken(sAPDrawRectangleAroundSAPGridViewCellAtIndexpenThicknessPixels);
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
            sAPDrawRectangleAroundSAPGridViewCellAtIndex["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPDrawRectangleAroundSAPGridViewCellAtIndexworkflow);
            if (sAPDrawRectangleAroundSAPGridViewCellAtIndexpropCount > 0)
            {
                callPayload.Body = sAPDrawRectangleAroundSAPGridViewCellAtIndex;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPGlobalLeftClickSAPGridViewCellAtIndex(Expression<Func<string>> sAPGlobalLeftClickSAPGridViewCellAtIndexsearchSAPElementId, Expression<Func<int>> sAPGlobalLeftClickSAPGridViewCellAtIndexrowIndex, Expression<Func<string>> sAPGlobalLeftClickSAPGridViewCellAtIndexworkflow, Expression<Func<string>> sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnName = null, Expression<Func<string>> sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitle = null, Expression<Func<bool>> sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive = null, Expression<Func<bool>> sAPGlobalLeftClickSAPGridViewCellAtIndexsetElementWindowTopMost = null, Expression<Func<bool>> sAPGlobalLeftClickSAPGridViewCellAtIndexbringElementWindowToFront = null, Expression<Func<bool>> sAPGlobalLeftClickSAPGridViewCellAtIndextoggleWindow = null, Expression<Func<bool>> sAPGlobalLeftClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent = null, Expression<Func<double>> sAPGlobalLeftClickSAPGridViewCellAtIndextoggleDelay = null, Expression<Func<int>> sAPGlobalLeftClickSAPGridViewCellAtIndexclickOffsetX = null, Expression<Func<int>> sAPGlobalLeftClickSAPGridViewCellAtIndexclickOffsetY = null, Expression<Func<sAPGlobalLeftClickSAPGridViewCellAtIndexoffsetRelativeToInput>> sAPGlobalLeftClickSAPGridViewCellAtIndexoffsetRelativeTo = null)
        {
            var apiCallPath = "/SAPGUI/SAPGlobalLeftClickSAPGridViewCellAtIndex";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPGlobalLeftClickSAPGridViewCellAtIndex = new JObject();
            var sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount = 0;
            sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
            sAPGlobalLeftClickSAPGridViewCellAtIndex["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPGlobalLeftClickSAPGridViewCellAtIndexsearchSAPElementId);
            sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
            sAPGlobalLeftClickSAPGridViewCellAtIndex["RowIndex"] = CSharpExpressionConverter.ConvertToken(sAPGlobalLeftClickSAPGridViewCellAtIndexrowIndex);
            if (sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnName != null)
            {
                sAPGlobalLeftClickSAPGridViewCellAtIndex["SearchColumnName"] = CSharpExpressionConverter.ConvertToken(sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnName);
                sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitle != null)
            {
                sAPGlobalLeftClickSAPGridViewCellAtIndex["SearchColumnTitle"] = CSharpExpressionConverter.ConvertToken(sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitle);
                sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression != null)
            {
                if (sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression != null)
                {
                    sAPGlobalLeftClickSAPGridViewCellAtIndex["SearchColumnTitleIsRegularExpression"] = CSharpExpressionConverter.ConvertToken(sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression);
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
                    sAPGlobalLeftClickSAPGridViewCellAtIndex["SearchColumnTitleIsCaseSensitive"] = CSharpExpressionConverter.ConvertToken(sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive);
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
                    sAPGlobalLeftClickSAPGridViewCellAtIndex["SetElementWindowTopMost"] = CSharpExpressionConverter.ConvertToken(sAPGlobalLeftClickSAPGridViewCellAtIndexsetElementWindowTopMost);
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
                    sAPGlobalLeftClickSAPGridViewCellAtIndex["BringElementWindowToFront"] = CSharpExpressionConverter.ConvertToken(sAPGlobalLeftClickSAPGridViewCellAtIndexbringElementWindowToFront);
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
                    sAPGlobalLeftClickSAPGridViewCellAtIndex["ToggleWindow"] = CSharpExpressionConverter.ConvertToken(sAPGlobalLeftClickSAPGridViewCellAtIndextoggleWindow);
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
                    sAPGlobalLeftClickSAPGridViewCellAtIndex["ToggleUsesGlobalLeftMouseClickAgent"] = CSharpExpressionConverter.ConvertToken(sAPGlobalLeftClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent);
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
                    sAPGlobalLeftClickSAPGridViewCellAtIndex["ToggleDelay"] = CSharpExpressionConverter.ConvertToken(sAPGlobalLeftClickSAPGridViewCellAtIndextoggleDelay);
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
                    sAPGlobalLeftClickSAPGridViewCellAtIndex["ClickOffsetX"] = CSharpExpressionConverter.ConvertToken(sAPGlobalLeftClickSAPGridViewCellAtIndexclickOffsetX);
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
                    sAPGlobalLeftClickSAPGridViewCellAtIndex["ClickOffsetY"] = CSharpExpressionConverter.ConvertToken(sAPGlobalLeftClickSAPGridViewCellAtIndexclickOffsetY);
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
                sAPGlobalLeftClickSAPGridViewCellAtIndex["OffsetRelativeTo"] = CSharpExpressionConverter.Convert(sAPGlobalLeftClickSAPGridViewCellAtIndexoffsetRelativeTo);
                sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
            }

            sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
            sAPGlobalLeftClickSAPGridViewCellAtIndex["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPGlobalLeftClickSAPGridViewCellAtIndexworkflow);
            if (sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount > 0)
            {
                callPayload.Body = sAPGlobalLeftClickSAPGridViewCellAtIndex;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPGlobalRightClickSAPGridViewCellAtIndex(Expression<Func<string>> sAPGlobalRightClickSAPGridViewCellAtIndexsearchSAPElementId, Expression<Func<int>> sAPGlobalRightClickSAPGridViewCellAtIndexrowIndex, Expression<Func<string>> sAPGlobalRightClickSAPGridViewCellAtIndexworkflow, Expression<Func<string>> sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnName = null, Expression<Func<string>> sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitle = null, Expression<Func<bool>> sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive = null, Expression<Func<bool>> sAPGlobalRightClickSAPGridViewCellAtIndexsetElementWindowTopMost = null, Expression<Func<bool>> sAPGlobalRightClickSAPGridViewCellAtIndexbringElementWindowToFront = null, Expression<Func<bool>> sAPGlobalRightClickSAPGridViewCellAtIndextoggleWindow = null, Expression<Func<bool>> sAPGlobalRightClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent = null, Expression<Func<double>> sAPGlobalRightClickSAPGridViewCellAtIndextoggleDelay = null, Expression<Func<int>> sAPGlobalRightClickSAPGridViewCellAtIndexclickOffsetX = null, Expression<Func<int>> sAPGlobalRightClickSAPGridViewCellAtIndexclickOffsetY = null, Expression<Func<sAPGlobalRightClickSAPGridViewCellAtIndexoffsetRelativeToInput>> sAPGlobalRightClickSAPGridViewCellAtIndexoffsetRelativeTo = null)
        {
            var apiCallPath = "/SAPGUI/SAPGlobalRightClickSAPGridViewCellAtIndex";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPGlobalRightClickSAPGridViewCellAtIndex = new JObject();
            var sAPGlobalRightClickSAPGridViewCellAtIndexpropCount = 0;
            sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
            sAPGlobalRightClickSAPGridViewCellAtIndex["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPGlobalRightClickSAPGridViewCellAtIndexsearchSAPElementId);
            sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
            sAPGlobalRightClickSAPGridViewCellAtIndex["RowIndex"] = CSharpExpressionConverter.ConvertToken(sAPGlobalRightClickSAPGridViewCellAtIndexrowIndex);
            if (sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnName != null)
            {
                sAPGlobalRightClickSAPGridViewCellAtIndex["SearchColumnName"] = CSharpExpressionConverter.ConvertToken(sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnName);
                sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitle != null)
            {
                sAPGlobalRightClickSAPGridViewCellAtIndex["SearchColumnTitle"] = CSharpExpressionConverter.ConvertToken(sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitle);
                sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression != null)
            {
                if (sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression != null)
                {
                    sAPGlobalRightClickSAPGridViewCellAtIndex["SearchColumnTitleIsRegularExpression"] = CSharpExpressionConverter.ConvertToken(sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression);
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
                    sAPGlobalRightClickSAPGridViewCellAtIndex["SearchColumnTitleIsCaseSensitive"] = CSharpExpressionConverter.ConvertToken(sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive);
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
                    sAPGlobalRightClickSAPGridViewCellAtIndex["SetElementWindowTopMost"] = CSharpExpressionConverter.ConvertToken(sAPGlobalRightClickSAPGridViewCellAtIndexsetElementWindowTopMost);
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
                    sAPGlobalRightClickSAPGridViewCellAtIndex["BringElementWindowToFront"] = CSharpExpressionConverter.ConvertToken(sAPGlobalRightClickSAPGridViewCellAtIndexbringElementWindowToFront);
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
                    sAPGlobalRightClickSAPGridViewCellAtIndex["ToggleWindow"] = CSharpExpressionConverter.ConvertToken(sAPGlobalRightClickSAPGridViewCellAtIndextoggleWindow);
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
                    sAPGlobalRightClickSAPGridViewCellAtIndex["ToggleUsesGlobalLeftMouseClickAgent"] = CSharpExpressionConverter.ConvertToken(sAPGlobalRightClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent);
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
                    sAPGlobalRightClickSAPGridViewCellAtIndex["ToggleDelay"] = CSharpExpressionConverter.ConvertToken(sAPGlobalRightClickSAPGridViewCellAtIndextoggleDelay);
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
                    sAPGlobalRightClickSAPGridViewCellAtIndex["ClickOffsetX"] = CSharpExpressionConverter.ConvertToken(sAPGlobalRightClickSAPGridViewCellAtIndexclickOffsetX);
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
                    sAPGlobalRightClickSAPGridViewCellAtIndex["ClickOffsetY"] = CSharpExpressionConverter.ConvertToken(sAPGlobalRightClickSAPGridViewCellAtIndexclickOffsetY);
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
                sAPGlobalRightClickSAPGridViewCellAtIndex["OffsetRelativeTo"] = CSharpExpressionConverter.Convert(sAPGlobalRightClickSAPGridViewCellAtIndexoffsetRelativeTo);
                sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
            }

            sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
            sAPGlobalRightClickSAPGridViewCellAtIndex["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPGlobalRightClickSAPGridViewCellAtIndexworkflow);
            if (sAPGlobalRightClickSAPGridViewCellAtIndexpropCount > 0)
            {
                callPayload.Body = sAPGlobalRightClickSAPGridViewCellAtIndex;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPGlobalDoubleLeftClickSAPGridViewCellAtIndex(Expression<Func<string>> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchSAPElementId, Expression<Func<int>> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexrowIndex, Expression<Func<string>> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexworkflow, Expression<Func<string>> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnName = null, Expression<Func<string>> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitle = null, Expression<Func<bool>> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive = null, Expression<Func<bool>> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsetElementWindowTopMost = null, Expression<Func<bool>> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexbringElementWindowToFront = null, Expression<Func<bool>> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleWindow = null, Expression<Func<bool>> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent = null, Expression<Func<double>> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleDelay = null, Expression<Func<int>> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexclickOffsetX = null, Expression<Func<int>> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexclickOffsetY = null, Expression<Func<sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexoffsetRelativeToInput>> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexoffsetRelativeTo = null, Expression<Func<int>> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexdoubleClickDelayInMilliseconds = null)
        {
            var apiCallPath = "/SAPGUI/SAPGlobalDoubleLeftClickSAPGridViewCellAtIndex";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex = new JObject();
            var sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount = 0;
            sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
            sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchSAPElementId);
            sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
            sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["RowIndex"] = CSharpExpressionConverter.ConvertToken(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexrowIndex);
            if (sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnName != null)
            {
                sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["SearchColumnName"] = CSharpExpressionConverter.ConvertToken(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnName);
                sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitle != null)
            {
                sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["SearchColumnTitle"] = CSharpExpressionConverter.ConvertToken(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitle);
                sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression != null)
            {
                if (sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression != null)
                {
                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["SearchColumnTitleIsRegularExpression"] = CSharpExpressionConverter.ConvertToken(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression);
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
                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["SearchColumnTitleIsCaseSensitive"] = CSharpExpressionConverter.ConvertToken(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive);
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
                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["SetElementWindowTopMost"] = CSharpExpressionConverter.ConvertToken(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsetElementWindowTopMost);
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
                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["BringElementWindowToFront"] = CSharpExpressionConverter.ConvertToken(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexbringElementWindowToFront);
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
                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["ToggleWindow"] = CSharpExpressionConverter.ConvertToken(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleWindow);
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
                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["ToggleUsesGlobalLeftMouseClickAgent"] = CSharpExpressionConverter.ConvertToken(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent);
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
                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["ToggleDelay"] = CSharpExpressionConverter.ConvertToken(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleDelay);
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
                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["ClickOffsetX"] = CSharpExpressionConverter.ConvertToken(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexclickOffsetX);
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
                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["ClickOffsetY"] = CSharpExpressionConverter.ConvertToken(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexclickOffsetY);
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
                sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["OffsetRelativeTo"] = CSharpExpressionConverter.Convert(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexoffsetRelativeTo);
                sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexdoubleClickDelayInMilliseconds != null)
            {
                if (sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexdoubleClickDelayInMilliseconds != null)
                {
                    sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["DoubleClickDelayInMilliseconds"] = CSharpExpressionConverter.ConvertToken(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexdoubleClickDelayInMilliseconds);
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
            sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexworkflow);
            if (sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount > 0)
            {
                callPayload.Body = sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetSAPGridViewColumnHeadersResponse> SAPGetSAPGridViewColumnHeaders(Expression<Func<string>> sAPGetSAPGridViewColumnHeaderssearchSAPElementId, Expression<Func<string>> sAPGetSAPGridViewColumnHeadersworkflow)
        {
            var apiCallPath = "/SAPGUI/SAPGetSAPGridViewColumnHeaders";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPGetSAPGridViewColumnHeaders = new JObject();
            var sAPGetSAPGridViewColumnHeaderspropCount = 0;
            sAPGetSAPGridViewColumnHeaderspropCount++;
            sAPGetSAPGridViewColumnHeaders["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPGetSAPGridViewColumnHeaderssearchSAPElementId);
            sAPGetSAPGridViewColumnHeaderspropCount++;
            sAPGetSAPGridViewColumnHeaders["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPGetSAPGridViewColumnHeadersworkflow);
            if (sAPGetSAPGridViewColumnHeaderspropCount > 0)
            {
                callPayload.Body = sAPGetSAPGridViewColumnHeaders;
            }

            return new ApiConnectionAction<SAPGetSAPGridViewColumnHeadersResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPClickSAPGridViewCellAtIndex(Expression<Func<string>> sAPClickSAPGridViewCellAtIndexsearchSAPElementId, Expression<Func<int>> sAPClickSAPGridViewCellAtIndexrowIndex, Expression<Func<string>> sAPClickSAPGridViewCellAtIndexworkflow, Expression<Func<string>> sAPClickSAPGridViewCellAtIndexsearchColumnName = null, Expression<Func<string>> sAPClickSAPGridViewCellAtIndexsearchColumnTitle = null, Expression<Func<bool>> sAPClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive = null)
        {
            var apiCallPath = "/SAPGUI/SAPClickSAPGridViewCellAtIndex";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPClickSAPGridViewCellAtIndex = new JObject();
            var sAPClickSAPGridViewCellAtIndexpropCount = 0;
            sAPClickSAPGridViewCellAtIndexpropCount++;
            sAPClickSAPGridViewCellAtIndex["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPClickSAPGridViewCellAtIndexsearchSAPElementId);
            sAPClickSAPGridViewCellAtIndexpropCount++;
            sAPClickSAPGridViewCellAtIndex["RowIndex"] = CSharpExpressionConverter.ConvertToken(sAPClickSAPGridViewCellAtIndexrowIndex);
            if (sAPClickSAPGridViewCellAtIndexsearchColumnName != null)
            {
                sAPClickSAPGridViewCellAtIndex["SearchColumnName"] = CSharpExpressionConverter.ConvertToken(sAPClickSAPGridViewCellAtIndexsearchColumnName);
                sAPClickSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPClickSAPGridViewCellAtIndexsearchColumnTitle != null)
            {
                sAPClickSAPGridViewCellAtIndex["SearchColumnTitle"] = CSharpExpressionConverter.ConvertToken(sAPClickSAPGridViewCellAtIndexsearchColumnTitle);
                sAPClickSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression != null)
            {
                if (sAPClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression != null)
                {
                    sAPClickSAPGridViewCellAtIndex["SearchColumnTitleIsRegularExpression"] = CSharpExpressionConverter.ConvertToken(sAPClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression);
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
                    sAPClickSAPGridViewCellAtIndex["SearchColumnTitleIsCaseSensitive"] = CSharpExpressionConverter.ConvertToken(sAPClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive);
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
            sAPClickSAPGridViewCellAtIndex["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPClickSAPGridViewCellAtIndexworkflow);
            if (sAPClickSAPGridViewCellAtIndexpropCount > 0)
            {
                callPayload.Body = sAPClickSAPGridViewCellAtIndex;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPDoubleClickSAPGridViewCellAtIndex(Expression<Func<string>> sAPDoubleClickSAPGridViewCellAtIndexsearchSAPElementId, Expression<Func<int>> sAPDoubleClickSAPGridViewCellAtIndexrowIndex, Expression<Func<string>> sAPDoubleClickSAPGridViewCellAtIndexworkflow, Expression<Func<string>> sAPDoubleClickSAPGridViewCellAtIndexsearchColumnName = null, Expression<Func<string>> sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitle = null, Expression<Func<bool>> sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive = null)
        {
            var apiCallPath = "/SAPGUI/SAPDoubleClickSAPGridViewCellAtIndex";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPDoubleClickSAPGridViewCellAtIndex = new JObject();
            var sAPDoubleClickSAPGridViewCellAtIndexpropCount = 0;
            sAPDoubleClickSAPGridViewCellAtIndexpropCount++;
            sAPDoubleClickSAPGridViewCellAtIndex["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPDoubleClickSAPGridViewCellAtIndexsearchSAPElementId);
            sAPDoubleClickSAPGridViewCellAtIndexpropCount++;
            sAPDoubleClickSAPGridViewCellAtIndex["RowIndex"] = CSharpExpressionConverter.ConvertToken(sAPDoubleClickSAPGridViewCellAtIndexrowIndex);
            if (sAPDoubleClickSAPGridViewCellAtIndexsearchColumnName != null)
            {
                sAPDoubleClickSAPGridViewCellAtIndex["SearchColumnName"] = CSharpExpressionConverter.ConvertToken(sAPDoubleClickSAPGridViewCellAtIndexsearchColumnName);
                sAPDoubleClickSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitle != null)
            {
                sAPDoubleClickSAPGridViewCellAtIndex["SearchColumnTitle"] = CSharpExpressionConverter.ConvertToken(sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitle);
                sAPDoubleClickSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression != null)
            {
                if (sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression != null)
                {
                    sAPDoubleClickSAPGridViewCellAtIndex["SearchColumnTitleIsRegularExpression"] = CSharpExpressionConverter.ConvertToken(sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression);
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
                    sAPDoubleClickSAPGridViewCellAtIndex["SearchColumnTitleIsCaseSensitive"] = CSharpExpressionConverter.ConvertToken(sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive);
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
            sAPDoubleClickSAPGridViewCellAtIndex["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPDoubleClickSAPGridViewCellAtIndexworkflow);
            if (sAPDoubleClickSAPGridViewCellAtIndexpropCount > 0)
            {
                callPayload.Body = sAPDoubleClickSAPGridViewCellAtIndex;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPPressSAPGridViewCellButtonAtIndex(Expression<Func<string>> sAPPressSAPGridViewCellButtonAtIndexsearchSAPElementId, Expression<Func<int>> sAPPressSAPGridViewCellButtonAtIndexrowIndex, Expression<Func<string>> sAPPressSAPGridViewCellButtonAtIndexworkflow, Expression<Func<string>> sAPPressSAPGridViewCellButtonAtIndexsearchColumnName = null, Expression<Func<string>> sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitle = null, Expression<Func<bool>> sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitleIsCaseSensitive = null)
        {
            var apiCallPath = "/SAPGUI/SAPPressSAPGridViewCellButtonAtIndex";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPPressSAPGridViewCellButtonAtIndex = new JObject();
            var sAPPressSAPGridViewCellButtonAtIndexpropCount = 0;
            sAPPressSAPGridViewCellButtonAtIndexpropCount++;
            sAPPressSAPGridViewCellButtonAtIndex["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPPressSAPGridViewCellButtonAtIndexsearchSAPElementId);
            sAPPressSAPGridViewCellButtonAtIndexpropCount++;
            sAPPressSAPGridViewCellButtonAtIndex["RowIndex"] = CSharpExpressionConverter.ConvertToken(sAPPressSAPGridViewCellButtonAtIndexrowIndex);
            if (sAPPressSAPGridViewCellButtonAtIndexsearchColumnName != null)
            {
                sAPPressSAPGridViewCellButtonAtIndex["SearchColumnName"] = CSharpExpressionConverter.ConvertToken(sAPPressSAPGridViewCellButtonAtIndexsearchColumnName);
                sAPPressSAPGridViewCellButtonAtIndexpropCount++;
            }

            if (sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitle != null)
            {
                sAPPressSAPGridViewCellButtonAtIndex["SearchColumnTitle"] = CSharpExpressionConverter.ConvertToken(sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitle);
                sAPPressSAPGridViewCellButtonAtIndexpropCount++;
            }

            if (sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitleIsRegularExpression != null)
            {
                if (sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitleIsRegularExpression != null)
                {
                    sAPPressSAPGridViewCellButtonAtIndex["SearchColumnTitleIsRegularExpression"] = CSharpExpressionConverter.ConvertToken(sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitleIsRegularExpression);
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
                    sAPPressSAPGridViewCellButtonAtIndex["SearchColumnTitleIsCaseSensitive"] = CSharpExpressionConverter.ConvertToken(sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitleIsCaseSensitive);
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
            sAPPressSAPGridViewCellButtonAtIndex["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPPressSAPGridViewCellButtonAtIndexworkflow);
            if (sAPPressSAPGridViewCellButtonAtIndexpropCount > 0)
            {
                callPayload.Body = sAPPressSAPGridViewCellButtonAtIndex;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPCheckSAPGridViewCellCheckboxAtIndex(Expression<Func<string>> sAPCheckSAPGridViewCellCheckboxAtIndexsearchSAPElementId, Expression<Func<int>> sAPCheckSAPGridViewCellCheckboxAtIndexrowIndex, Expression<Func<string>> sAPCheckSAPGridViewCellCheckboxAtIndexworkflow, Expression<Func<string>> sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnName = null, Expression<Func<string>> sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitle = null, Expression<Func<bool>> sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitleIsCaseSensitive = null, Expression<Func<bool>> sAPCheckSAPGridViewCellCheckboxAtIndexcheckCellElement = null)
        {
            var apiCallPath = "/SAPGUI/SAPCheckSAPGridViewCellCheckboxAtIndex";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPCheckSAPGridViewCellCheckboxAtIndex = new JObject();
            var sAPCheckSAPGridViewCellCheckboxAtIndexpropCount = 0;
            sAPCheckSAPGridViewCellCheckboxAtIndexpropCount++;
            sAPCheckSAPGridViewCellCheckboxAtIndex["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPCheckSAPGridViewCellCheckboxAtIndexsearchSAPElementId);
            sAPCheckSAPGridViewCellCheckboxAtIndexpropCount++;
            sAPCheckSAPGridViewCellCheckboxAtIndex["RowIndex"] = CSharpExpressionConverter.ConvertToken(sAPCheckSAPGridViewCellCheckboxAtIndexrowIndex);
            if (sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnName != null)
            {
                sAPCheckSAPGridViewCellCheckboxAtIndex["SearchColumnName"] = CSharpExpressionConverter.ConvertToken(sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnName);
                sAPCheckSAPGridViewCellCheckboxAtIndexpropCount++;
            }

            if (sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitle != null)
            {
                sAPCheckSAPGridViewCellCheckboxAtIndex["SearchColumnTitle"] = CSharpExpressionConverter.ConvertToken(sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitle);
                sAPCheckSAPGridViewCellCheckboxAtIndexpropCount++;
            }

            if (sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitleIsRegularExpression != null)
            {
                if (sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitleIsRegularExpression != null)
                {
                    sAPCheckSAPGridViewCellCheckboxAtIndex["SearchColumnTitleIsRegularExpression"] = CSharpExpressionConverter.ConvertToken(sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitleIsRegularExpression);
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
                    sAPCheckSAPGridViewCellCheckboxAtIndex["SearchColumnTitleIsCaseSensitive"] = CSharpExpressionConverter.ConvertToken(sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitleIsCaseSensitive);
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
                    sAPCheckSAPGridViewCellCheckboxAtIndex["CheckCellElement"] = CSharpExpressionConverter.ConvertToken(sAPCheckSAPGridViewCellCheckboxAtIndexcheckCellElement);
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
            sAPCheckSAPGridViewCellCheckboxAtIndex["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPCheckSAPGridViewCellCheckboxAtIndexworkflow);
            if (sAPCheckSAPGridViewCellCheckboxAtIndexpropCount > 0)
            {
                callPayload.Body = sAPCheckSAPGridViewCellCheckboxAtIndex;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPModifySAPGridViewCellAtIndexResponse> SAPModifySAPGridViewCellAtIndex(Expression<Func<string>> sAPModifySAPGridViewCellAtIndexsearchSAPElementId, Expression<Func<int>> sAPModifySAPGridViewCellAtIndexrowIndex, Expression<Func<string>> sAPModifySAPGridViewCellAtIndexworkflow, Expression<Func<string>> sAPModifySAPGridViewCellAtIndexsearchColumnName = null, Expression<Func<string>> sAPModifySAPGridViewCellAtIndexsearchColumnTitle = null, Expression<Func<bool>> sAPModifySAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPModifySAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive = null, Expression<Func<string>> sAPModifySAPGridViewCellAtIndexnewValue = null)
        {
            var apiCallPath = "/SAPGUI/SAPModifySAPGridViewCellAtIndex";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPModifySAPGridViewCellAtIndex = new JObject();
            var sAPModifySAPGridViewCellAtIndexpropCount = 0;
            sAPModifySAPGridViewCellAtIndexpropCount++;
            sAPModifySAPGridViewCellAtIndex["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPModifySAPGridViewCellAtIndexsearchSAPElementId);
            sAPModifySAPGridViewCellAtIndexpropCount++;
            sAPModifySAPGridViewCellAtIndex["RowIndex"] = CSharpExpressionConverter.ConvertToken(sAPModifySAPGridViewCellAtIndexrowIndex);
            if (sAPModifySAPGridViewCellAtIndexsearchColumnName != null)
            {
                sAPModifySAPGridViewCellAtIndex["SearchColumnName"] = CSharpExpressionConverter.ConvertToken(sAPModifySAPGridViewCellAtIndexsearchColumnName);
                sAPModifySAPGridViewCellAtIndexpropCount++;
            }

            if (sAPModifySAPGridViewCellAtIndexsearchColumnTitle != null)
            {
                sAPModifySAPGridViewCellAtIndex["SearchColumnTitle"] = CSharpExpressionConverter.ConvertToken(sAPModifySAPGridViewCellAtIndexsearchColumnTitle);
                sAPModifySAPGridViewCellAtIndexpropCount++;
            }

            if (sAPModifySAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression != null)
            {
                if (sAPModifySAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression != null)
                {
                    sAPModifySAPGridViewCellAtIndex["SearchColumnTitleIsRegularExpression"] = CSharpExpressionConverter.ConvertToken(sAPModifySAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression);
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
                    sAPModifySAPGridViewCellAtIndex["SearchColumnTitleIsCaseSensitive"] = CSharpExpressionConverter.ConvertToken(sAPModifySAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive);
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
                sAPModifySAPGridViewCellAtIndex["NewValue"] = CSharpExpressionConverter.ConvertToken(sAPModifySAPGridViewCellAtIndexnewValue);
                sAPModifySAPGridViewCellAtIndexpropCount++;
            }

            sAPModifySAPGridViewCellAtIndexpropCount++;
            sAPModifySAPGridViewCellAtIndex["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPModifySAPGridViewCellAtIndexworkflow);
            if (sAPModifySAPGridViewCellAtIndexpropCount > 0)
            {
                callPayload.Body = sAPModifySAPGridViewCellAtIndex;
            }

            return new ApiConnectionAction<SAPModifySAPGridViewCellAtIndexResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPSetSAPGridViewCurrentRow(Expression<Func<string>> sAPSetSAPGridViewCurrentRowsearchSAPElementId, Expression<Func<int>> sAPSetSAPGridViewCurrentRowrowIndex, Expression<Func<string>> sAPSetSAPGridViewCurrentRowworkflow)
        {
            var apiCallPath = "/SAPGUI/SAPSetSAPGridViewCurrentRow";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPSetSAPGridViewCurrentRow = new JObject();
            var sAPSetSAPGridViewCurrentRowpropCount = 0;
            sAPSetSAPGridViewCurrentRowpropCount++;
            sAPSetSAPGridViewCurrentRow["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPSetSAPGridViewCurrentRowsearchSAPElementId);
            sAPSetSAPGridViewCurrentRowpropCount++;
            sAPSetSAPGridViewCurrentRow["RowIndex"] = CSharpExpressionConverter.ConvertToken(sAPSetSAPGridViewCurrentRowrowIndex);
            sAPSetSAPGridViewCurrentRowpropCount++;
            sAPSetSAPGridViewCurrentRow["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPSetSAPGridViewCurrentRowworkflow);
            if (sAPSetSAPGridViewCurrentRowpropCount > 0)
            {
                callPayload.Body = sAPSetSAPGridViewCurrentRow;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPPressSAPGridViewColumnHeader(Expression<Func<string>> sAPPressSAPGridViewColumnHeadersearchSAPElementId, Expression<Func<string>> sAPPressSAPGridViewColumnHeaderworkflow, Expression<Func<string>> sAPPressSAPGridViewColumnHeadersearchColumnName = null, Expression<Func<string>> sAPPressSAPGridViewColumnHeadersearchColumnTitle = null, Expression<Func<bool>> sAPPressSAPGridViewColumnHeadersearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPPressSAPGridViewColumnHeadersearchColumnTitleIsCaseSensitive = null)
        {
            var apiCallPath = "/SAPGUI/SAPPressSAPGridViewColumnHeader";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPPressSAPGridViewColumnHeader = new JObject();
            var sAPPressSAPGridViewColumnHeaderpropCount = 0;
            sAPPressSAPGridViewColumnHeaderpropCount++;
            sAPPressSAPGridViewColumnHeader["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPPressSAPGridViewColumnHeadersearchSAPElementId);
            if (sAPPressSAPGridViewColumnHeadersearchColumnName != null)
            {
                sAPPressSAPGridViewColumnHeader["SearchColumnName"] = CSharpExpressionConverter.ConvertToken(sAPPressSAPGridViewColumnHeadersearchColumnName);
                sAPPressSAPGridViewColumnHeaderpropCount++;
            }

            if (sAPPressSAPGridViewColumnHeadersearchColumnTitle != null)
            {
                sAPPressSAPGridViewColumnHeader["SearchColumnTitle"] = CSharpExpressionConverter.ConvertToken(sAPPressSAPGridViewColumnHeadersearchColumnTitle);
                sAPPressSAPGridViewColumnHeaderpropCount++;
            }

            if (sAPPressSAPGridViewColumnHeadersearchColumnTitleIsRegularExpression != null)
            {
                if (sAPPressSAPGridViewColumnHeadersearchColumnTitleIsRegularExpression != null)
                {
                    sAPPressSAPGridViewColumnHeader["SearchColumnTitleIsRegularExpression"] = CSharpExpressionConverter.ConvertToken(sAPPressSAPGridViewColumnHeadersearchColumnTitleIsRegularExpression);
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
                    sAPPressSAPGridViewColumnHeader["SearchColumnTitleIsCaseSensitive"] = CSharpExpressionConverter.ConvertToken(sAPPressSAPGridViewColumnHeadersearchColumnTitleIsCaseSensitive);
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
            sAPPressSAPGridViewColumnHeader["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPPressSAPGridViewColumnHeaderworkflow);
            if (sAPPressSAPGridViewColumnHeaderpropCount > 0)
            {
                callPayload.Body = sAPPressSAPGridViewColumnHeader;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPSetSAPGridViewFirstVisibleRowResponse> SAPSetSAPGridViewFirstVisibleRow(Expression<Func<string>> sAPSetSAPGridViewFirstVisibleRowsearchSAPElementId, Expression<Func<int>> sAPSetSAPGridViewFirstVisibleRowfirstVisibleRowIndex, Expression<Func<string>> sAPSetSAPGridViewFirstVisibleRowworkflow)
        {
            var apiCallPath = "/SAPGUI/SAPSetSAPGridViewFirstVisibleRow";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPSetSAPGridViewFirstVisibleRow = new JObject();
            var sAPSetSAPGridViewFirstVisibleRowpropCount = 0;
            sAPSetSAPGridViewFirstVisibleRowpropCount++;
            sAPSetSAPGridViewFirstVisibleRow["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPSetSAPGridViewFirstVisibleRowsearchSAPElementId);
            sAPSetSAPGridViewFirstVisibleRowpropCount++;
            sAPSetSAPGridViewFirstVisibleRow["FirstVisibleRowIndex"] = CSharpExpressionConverter.ConvertToken(sAPSetSAPGridViewFirstVisibleRowfirstVisibleRowIndex);
            sAPSetSAPGridViewFirstVisibleRowpropCount++;
            sAPSetSAPGridViewFirstVisibleRow["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPSetSAPGridViewFirstVisibleRowworkflow);
            if (sAPSetSAPGridViewFirstVisibleRowpropCount > 0)
            {
                callPayload.Body = sAPSetSAPGridViewFirstVisibleRow;
            }

            return new ApiConnectionAction<SAPSetSAPGridViewFirstVisibleRowResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPSelectSAPGridViewRow(Expression<Func<string>> sAPSelectSAPGridViewRowsearchSAPElementId, Expression<Func<int>> sAPSelectSAPGridViewRowrowIndex, Expression<Func<string>> sAPSelectSAPGridViewRowworkflow, Expression<Func<bool>> sAPSelectSAPGridViewRowsetAsCurrentRow = null)
        {
            var apiCallPath = "/SAPGUI/SAPSelectSAPGridViewRow";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPSelectSAPGridViewRow = new JObject();
            var sAPSelectSAPGridViewRowpropCount = 0;
            sAPSelectSAPGridViewRowpropCount++;
            sAPSelectSAPGridViewRow["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPSelectSAPGridViewRowsearchSAPElementId);
            sAPSelectSAPGridViewRowpropCount++;
            sAPSelectSAPGridViewRow["RowIndex"] = CSharpExpressionConverter.ConvertToken(sAPSelectSAPGridViewRowrowIndex);
            if (sAPSelectSAPGridViewRowsetAsCurrentRow != null)
            {
                if (sAPSelectSAPGridViewRowsetAsCurrentRow != null)
                {
                    sAPSelectSAPGridViewRow["SetAsCurrentRow"] = CSharpExpressionConverter.ConvertToken(sAPSelectSAPGridViewRowsetAsCurrentRow);
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
            sAPSelectSAPGridViewRow["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPSelectSAPGridViewRowworkflow);
            if (sAPSelectSAPGridViewRowpropCount > 0)
            {
                callPayload.Body = sAPSelectSAPGridViewRow;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPSelectSAPGridViewMultipleRows(Expression<Func<string>> sAPSelectSAPGridViewMultipleRowssearchSAPElementId, Expression<Func<string>> sAPSelectSAPGridViewMultipleRowsrowsToSelect, Expression<Func<string>> sAPSelectSAPGridViewMultipleRowsworkflow)
        {
            var apiCallPath = "/SAPGUI/SAPSelectSAPGridViewMultipleRows";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPSelectSAPGridViewMultipleRows = new JObject();
            var sAPSelectSAPGridViewMultipleRowspropCount = 0;
            sAPSelectSAPGridViewMultipleRowspropCount++;
            sAPSelectSAPGridViewMultipleRows["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPSelectSAPGridViewMultipleRowssearchSAPElementId);
            sAPSelectSAPGridViewMultipleRowspropCount++;
            sAPSelectSAPGridViewMultipleRows["RowsToSelect"] = CSharpExpressionConverter.ConvertToken(sAPSelectSAPGridViewMultipleRowsrowsToSelect);
            sAPSelectSAPGridViewMultipleRowspropCount++;
            sAPSelectSAPGridViewMultipleRows["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPSelectSAPGridViewMultipleRowsworkflow);
            if (sAPSelectSAPGridViewMultipleRowspropCount > 0)
            {
                callPayload.Body = sAPSelectSAPGridViewMultipleRows;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPSetSAPGridViewCurrentColumn(Expression<Func<string>> sAPSetSAPGridViewCurrentColumnsearchSAPElementId, Expression<Func<string>> sAPSetSAPGridViewCurrentColumnworkflow, Expression<Func<string>> sAPSetSAPGridViewCurrentColumnsearchColumnName = null, Expression<Func<string>> sAPSetSAPGridViewCurrentColumnsearchColumnTitle = null, Expression<Func<bool>> sAPSetSAPGridViewCurrentColumnsearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPSetSAPGridViewCurrentColumnsearchColumnTitleIsCaseSensitive = null)
        {
            var apiCallPath = "/SAPGUI/SAPSetSAPGridViewCurrentColumn";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPSetSAPGridViewCurrentColumn = new JObject();
            var sAPSetSAPGridViewCurrentColumnpropCount = 0;
            sAPSetSAPGridViewCurrentColumnpropCount++;
            sAPSetSAPGridViewCurrentColumn["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPSetSAPGridViewCurrentColumnsearchSAPElementId);
            if (sAPSetSAPGridViewCurrentColumnsearchColumnName != null)
            {
                sAPSetSAPGridViewCurrentColumn["SearchColumnName"] = CSharpExpressionConverter.ConvertToken(sAPSetSAPGridViewCurrentColumnsearchColumnName);
                sAPSetSAPGridViewCurrentColumnpropCount++;
            }

            if (sAPSetSAPGridViewCurrentColumnsearchColumnTitle != null)
            {
                sAPSetSAPGridViewCurrentColumn["SearchColumnTitle"] = CSharpExpressionConverter.ConvertToken(sAPSetSAPGridViewCurrentColumnsearchColumnTitle);
                sAPSetSAPGridViewCurrentColumnpropCount++;
            }

            if (sAPSetSAPGridViewCurrentColumnsearchColumnTitleIsRegularExpression != null)
            {
                if (sAPSetSAPGridViewCurrentColumnsearchColumnTitleIsRegularExpression != null)
                {
                    sAPSetSAPGridViewCurrentColumn["SearchColumnTitleIsRegularExpression"] = CSharpExpressionConverter.ConvertToken(sAPSetSAPGridViewCurrentColumnsearchColumnTitleIsRegularExpression);
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
                    sAPSetSAPGridViewCurrentColumn["SearchColumnTitleIsCaseSensitive"] = CSharpExpressionConverter.ConvertToken(sAPSetSAPGridViewCurrentColumnsearchColumnTitleIsCaseSensitive);
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
            sAPSetSAPGridViewCurrentColumn["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPSetSAPGridViewCurrentColumnworkflow);
            if (sAPSetSAPGridViewCurrentColumnpropCount > 0)
            {
                callPayload.Body = sAPSetSAPGridViewCurrentColumn;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPSetSAPGridViewCurrentCell(Expression<Func<string>> sAPSetSAPGridViewCurrentCellsearchSAPElementId, Expression<Func<int>> sAPSetSAPGridViewCurrentCellrowIndex, Expression<Func<string>> sAPSetSAPGridViewCurrentCellworkflow, Expression<Func<string>> sAPSetSAPGridViewCurrentCellsearchColumnName = null, Expression<Func<string>> sAPSetSAPGridViewCurrentCellsearchColumnTitle = null, Expression<Func<bool>> sAPSetSAPGridViewCurrentCellsearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPSetSAPGridViewCurrentCellsearchColumnTitleIsCaseSensitive = null)
        {
            var apiCallPath = "/SAPGUI/SAPSetSAPGridViewCurrentCell";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPSetSAPGridViewCurrentCell = new JObject();
            var sAPSetSAPGridViewCurrentCellpropCount = 0;
            sAPSetSAPGridViewCurrentCellpropCount++;
            sAPSetSAPGridViewCurrentCell["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPSetSAPGridViewCurrentCellsearchSAPElementId);
            sAPSetSAPGridViewCurrentCellpropCount++;
            sAPSetSAPGridViewCurrentCell["RowIndex"] = CSharpExpressionConverter.ConvertToken(sAPSetSAPGridViewCurrentCellrowIndex);
            if (sAPSetSAPGridViewCurrentCellsearchColumnName != null)
            {
                sAPSetSAPGridViewCurrentCell["SearchColumnName"] = CSharpExpressionConverter.ConvertToken(sAPSetSAPGridViewCurrentCellsearchColumnName);
                sAPSetSAPGridViewCurrentCellpropCount++;
            }

            if (sAPSetSAPGridViewCurrentCellsearchColumnTitle != null)
            {
                sAPSetSAPGridViewCurrentCell["SearchColumnTitle"] = CSharpExpressionConverter.ConvertToken(sAPSetSAPGridViewCurrentCellsearchColumnTitle);
                sAPSetSAPGridViewCurrentCellpropCount++;
            }

            if (sAPSetSAPGridViewCurrentCellsearchColumnTitleIsRegularExpression != null)
            {
                if (sAPSetSAPGridViewCurrentCellsearchColumnTitleIsRegularExpression != null)
                {
                    sAPSetSAPGridViewCurrentCell["SearchColumnTitleIsRegularExpression"] = CSharpExpressionConverter.ConvertToken(sAPSetSAPGridViewCurrentCellsearchColumnTitleIsRegularExpression);
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
                    sAPSetSAPGridViewCurrentCell["SearchColumnTitleIsCaseSensitive"] = CSharpExpressionConverter.ConvertToken(sAPSetSAPGridViewCurrentCellsearchColumnTitleIsCaseSensitive);
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
            sAPSetSAPGridViewCurrentCell["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPSetSAPGridViewCurrentCellworkflow);
            if (sAPSetSAPGridViewCurrentCellpropCount > 0)
            {
                callPayload.Body = sAPSetSAPGridViewCurrentCell;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPSelectSAPGridViewColumn(Expression<Func<string>> sAPSelectSAPGridViewColumnsearchSAPElementId, Expression<Func<string>> sAPSelectSAPGridViewColumnworkflow, Expression<Func<string>> sAPSelectSAPGridViewColumnsearchColumnName = null, Expression<Func<string>> sAPSelectSAPGridViewColumnsearchColumnTitle = null, Expression<Func<bool>> sAPSelectSAPGridViewColumnsearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPSelectSAPGridViewColumnsearchColumnTitleIsCaseSensitive = null, Expression<Func<bool>> sAPSelectSAPGridViewColumnselectColumn = null, Expression<Func<bool>> sAPSelectSAPGridViewColumnsetAsCurrentColumn = null, Expression<Func<bool>> sAPSelectSAPGridViewColumnclearSelectionFirst = null)
        {
            var apiCallPath = "/SAPGUI/SAPSelectSAPGridViewColumn";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPSelectSAPGridViewColumn = new JObject();
            var sAPSelectSAPGridViewColumnpropCount = 0;
            sAPSelectSAPGridViewColumnpropCount++;
            sAPSelectSAPGridViewColumn["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPSelectSAPGridViewColumnsearchSAPElementId);
            if (sAPSelectSAPGridViewColumnsearchColumnName != null)
            {
                sAPSelectSAPGridViewColumn["SearchColumnName"] = CSharpExpressionConverter.ConvertToken(sAPSelectSAPGridViewColumnsearchColumnName);
                sAPSelectSAPGridViewColumnpropCount++;
            }

            if (sAPSelectSAPGridViewColumnsearchColumnTitle != null)
            {
                sAPSelectSAPGridViewColumn["SearchColumnTitle"] = CSharpExpressionConverter.ConvertToken(sAPSelectSAPGridViewColumnsearchColumnTitle);
                sAPSelectSAPGridViewColumnpropCount++;
            }

            if (sAPSelectSAPGridViewColumnsearchColumnTitleIsRegularExpression != null)
            {
                if (sAPSelectSAPGridViewColumnsearchColumnTitleIsRegularExpression != null)
                {
                    sAPSelectSAPGridViewColumn["SearchColumnTitleIsRegularExpression"] = CSharpExpressionConverter.ConvertToken(sAPSelectSAPGridViewColumnsearchColumnTitleIsRegularExpression);
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
                    sAPSelectSAPGridViewColumn["SearchColumnTitleIsCaseSensitive"] = CSharpExpressionConverter.ConvertToken(sAPSelectSAPGridViewColumnsearchColumnTitleIsCaseSensitive);
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
                    sAPSelectSAPGridViewColumn["SelectColumn"] = CSharpExpressionConverter.ConvertToken(sAPSelectSAPGridViewColumnselectColumn);
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
                    sAPSelectSAPGridViewColumn["SetAsCurrentColumn"] = CSharpExpressionConverter.ConvertToken(sAPSelectSAPGridViewColumnsetAsCurrentColumn);
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
                    sAPSelectSAPGridViewColumn["ClearSelectionFirst"] = CSharpExpressionConverter.ConvertToken(sAPSelectSAPGridViewColumnclearSelectionFirst);
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
            sAPSelectSAPGridViewColumn["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPSelectSAPGridViewColumnworkflow);
            if (sAPSelectSAPGridViewColumnpropCount > 0)
            {
                callPayload.Body = sAPSelectSAPGridViewColumn;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPGridViewSelectAll(Expression<Func<string>> sAPGridViewSelectAllsearchSAPElementId, Expression<Func<string>> sAPGridViewSelectAllworkflow)
        {
            var apiCallPath = "/SAPGUI/SAPGridViewSelectAll";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPGridViewSelectAll = new JObject();
            var sAPGridViewSelectAllpropCount = 0;
            sAPGridViewSelectAllpropCount++;
            sAPGridViewSelectAll["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPGridViewSelectAllsearchSAPElementId);
            sAPGridViewSelectAllpropCount++;
            sAPGridViewSelectAll["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPGridViewSelectAllworkflow);
            if (sAPGridViewSelectAllpropCount > 0)
            {
                callPayload.Body = sAPGridViewSelectAll;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPGridViewDeselectAll(Expression<Func<string>> sAPGridViewDeselectAllsearchSAPElementId, Expression<Func<string>> sAPGridViewDeselectAllworkflow)
        {
            var apiCallPath = "/SAPGUI/SAPGridViewDeselectAll";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPGridViewDeselectAll = new JObject();
            var sAPGridViewDeselectAllpropCount = 0;
            sAPGridViewDeselectAllpropCount++;
            sAPGridViewDeselectAll["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPGridViewDeselectAllsearchSAPElementId);
            sAPGridViewDeselectAllpropCount++;
            sAPGridViewDeselectAll["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPGridViewDeselectAllworkflow);
            if (sAPGridViewDeselectAllpropCount > 0)
            {
                callPayload.Body = sAPGridViewDeselectAll;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPSetSAPGridViewFirstVisibleColumnResponse> SAPSetSAPGridViewFirstVisibleColumn(Expression<Func<string>> sAPSetSAPGridViewFirstVisibleColumnsearchSAPElementId, Expression<Func<string>> sAPSetSAPGridViewFirstVisibleColumnworkflow, Expression<Func<string>> sAPSetSAPGridViewFirstVisibleColumnsearchColumnName = null, Expression<Func<string>> sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitle = null, Expression<Func<bool>> sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitleIsCaseSensitive = null)
        {
            var apiCallPath = "/SAPGUI/SAPSetSAPGridViewFirstVisibleColumn";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPSetSAPGridViewFirstVisibleColumn = new JObject();
            var sAPSetSAPGridViewFirstVisibleColumnpropCount = 0;
            sAPSetSAPGridViewFirstVisibleColumnpropCount++;
            sAPSetSAPGridViewFirstVisibleColumn["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPSetSAPGridViewFirstVisibleColumnsearchSAPElementId);
            if (sAPSetSAPGridViewFirstVisibleColumnsearchColumnName != null)
            {
                sAPSetSAPGridViewFirstVisibleColumn["SearchColumnName"] = CSharpExpressionConverter.ConvertToken(sAPSetSAPGridViewFirstVisibleColumnsearchColumnName);
                sAPSetSAPGridViewFirstVisibleColumnpropCount++;
            }

            if (sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitle != null)
            {
                sAPSetSAPGridViewFirstVisibleColumn["SearchColumnTitle"] = CSharpExpressionConverter.ConvertToken(sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitle);
                sAPSetSAPGridViewFirstVisibleColumnpropCount++;
            }

            if (sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitleIsRegularExpression != null)
            {
                if (sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitleIsRegularExpression != null)
                {
                    sAPSetSAPGridViewFirstVisibleColumn["SearchColumnTitleIsRegularExpression"] = CSharpExpressionConverter.ConvertToken(sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitleIsRegularExpression);
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
                    sAPSetSAPGridViewFirstVisibleColumn["SearchColumnTitleIsCaseSensitive"] = CSharpExpressionConverter.ConvertToken(sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitleIsCaseSensitive);
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
            sAPSetSAPGridViewFirstVisibleColumn["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPSetSAPGridViewFirstVisibleColumnworkflow);
            if (sAPSetSAPGridViewFirstVisibleColumnpropCount > 0)
            {
                callPayload.Body = sAPSetSAPGridViewFirstVisibleColumn;
            }

            return new ApiConnectionAction<SAPSetSAPGridViewFirstVisibleColumnResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPGridViewOpenContextMenu(Expression<Func<string>> sAPGridViewOpenContextMenusearchSAPElementId, Expression<Func<int>> sAPGridViewOpenContextMenurowIndex, Expression<Func<string>> sAPGridViewOpenContextMenuworkflow, Expression<Func<string>> sAPGridViewOpenContextMenusearchColumnName = null, Expression<Func<string>> sAPGridViewOpenContextMenusearchColumnTitle = null, Expression<Func<bool>> sAPGridViewOpenContextMenusearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPGridViewOpenContextMenusearchColumnTitleIsCaseSensitive = null)
        {
            var apiCallPath = "/SAPGUI/SAPGridViewOpenContextMenu";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPGridViewOpenContextMenu = new JObject();
            var sAPGridViewOpenContextMenupropCount = 0;
            sAPGridViewOpenContextMenupropCount++;
            sAPGridViewOpenContextMenu["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPGridViewOpenContextMenusearchSAPElementId);
            sAPGridViewOpenContextMenupropCount++;
            sAPGridViewOpenContextMenu["RowIndex"] = CSharpExpressionConverter.ConvertToken(sAPGridViewOpenContextMenurowIndex);
            if (sAPGridViewOpenContextMenusearchColumnName != null)
            {
                sAPGridViewOpenContextMenu["SearchColumnName"] = CSharpExpressionConverter.ConvertToken(sAPGridViewOpenContextMenusearchColumnName);
                sAPGridViewOpenContextMenupropCount++;
            }

            if (sAPGridViewOpenContextMenusearchColumnTitle != null)
            {
                sAPGridViewOpenContextMenu["SearchColumnTitle"] = CSharpExpressionConverter.ConvertToken(sAPGridViewOpenContextMenusearchColumnTitle);
                sAPGridViewOpenContextMenupropCount++;
            }

            if (sAPGridViewOpenContextMenusearchColumnTitleIsRegularExpression != null)
            {
                if (sAPGridViewOpenContextMenusearchColumnTitleIsRegularExpression != null)
                {
                    sAPGridViewOpenContextMenu["SearchColumnTitleIsRegularExpression"] = CSharpExpressionConverter.ConvertToken(sAPGridViewOpenContextMenusearchColumnTitleIsRegularExpression);
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
                    sAPGridViewOpenContextMenu["SearchColumnTitleIsCaseSensitive"] = CSharpExpressionConverter.ConvertToken(sAPGridViewOpenContextMenusearchColumnTitleIsCaseSensitive);
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
            sAPGridViewOpenContextMenu["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPGridViewOpenContextMenuworkflow);
            if (sAPGridViewOpenContextMenupropCount > 0)
            {
                callPayload.Body = sAPGridViewOpenContextMenu;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetGridViewTextContentsResponse> SAPGetGridViewTextContents(Expression<Func<string>> sAPGetGridViewTextContentssearchSAPElementId, Expression<Func<string>> sAPGetGridViewTextContentsworkflow, Expression<Func<int>> sAPGetGridViewTextContentsfirstRowToReturn = null, Expression<Func<int>> sAPGetGridViewTextContentsmaxRowsToReturn = null, Expression<Func<string>> sAPGetGridViewTextContentsfirstSearchColumnName = null, Expression<Func<string>> sAPGetGridViewTextContentsfirstSearchColumnTitle = null, Expression<Func<bool>> sAPGetGridViewTextContentsfirstSearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPGetGridViewTextContentsfirstSearchColumnTitleIsCaseSensitive = null, Expression<Func<int>> sAPGetGridViewTextContentsmaxColumnsToReturn = null, Expression<Func<bool>> sAPGetGridViewTextContentsuseColumnHeadersFromTable = null, Expression<Func<bool>> sAPGetGridViewTextContentsreturnRowIndexInOutputCollection = null, Expression<Func<string>> sAPGetGridViewTextContentsnameOfColumnToStoreRowIndex = null, Expression<Func<string>> sAPGetGridViewTextContentscheckedElementValue = null)
        {
            var apiCallPath = "/SAPGUI/SAPGetGridViewTextContents";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPGetGridViewTextContents = new JObject();
            var sAPGetGridViewTextContentspropCount = 0;
            sAPGetGridViewTextContentspropCount++;
            sAPGetGridViewTextContents["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPGetGridViewTextContentssearchSAPElementId);
            if (sAPGetGridViewTextContentsfirstRowToReturn != null)
            {
                if (sAPGetGridViewTextContentsfirstRowToReturn != null)
                {
                    sAPGetGridViewTextContents["FirstRowToReturn"] = CSharpExpressionConverter.ConvertToken(sAPGetGridViewTextContentsfirstRowToReturn);
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
                    sAPGetGridViewTextContents["MaxRowsToReturn"] = CSharpExpressionConverter.ConvertToken(sAPGetGridViewTextContentsmaxRowsToReturn);
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
                sAPGetGridViewTextContents["FirstSearchColumnName"] = CSharpExpressionConverter.ConvertToken(sAPGetGridViewTextContentsfirstSearchColumnName);
                sAPGetGridViewTextContentspropCount++;
            }

            if (sAPGetGridViewTextContentsfirstSearchColumnTitle != null)
            {
                sAPGetGridViewTextContents["FirstSearchColumnTitle"] = CSharpExpressionConverter.ConvertToken(sAPGetGridViewTextContentsfirstSearchColumnTitle);
                sAPGetGridViewTextContentspropCount++;
            }

            if (sAPGetGridViewTextContentsfirstSearchColumnTitleIsRegularExpression != null)
            {
                if (sAPGetGridViewTextContentsfirstSearchColumnTitleIsRegularExpression != null)
                {
                    sAPGetGridViewTextContents["FirstSearchColumnTitleIsRegularExpression"] = CSharpExpressionConverter.ConvertToken(sAPGetGridViewTextContentsfirstSearchColumnTitleIsRegularExpression);
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
                    sAPGetGridViewTextContents["FirstSearchColumnTitleIsCaseSensitive"] = CSharpExpressionConverter.ConvertToken(sAPGetGridViewTextContentsfirstSearchColumnTitleIsCaseSensitive);
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
                    sAPGetGridViewTextContents["MaxColumnsToReturn"] = CSharpExpressionConverter.ConvertToken(sAPGetGridViewTextContentsmaxColumnsToReturn);
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
                    sAPGetGridViewTextContents["UseColumnHeadersFromTable"] = CSharpExpressionConverter.ConvertToken(sAPGetGridViewTextContentsuseColumnHeadersFromTable);
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
                    sAPGetGridViewTextContents["ReturnRowIndexInOutputCollection"] = CSharpExpressionConverter.ConvertToken(sAPGetGridViewTextContentsreturnRowIndexInOutputCollection);
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
                sAPGetGridViewTextContents["NameOfColumnToStoreRowIndex"] = CSharpExpressionConverter.ConvertToken(sAPGetGridViewTextContentsnameOfColumnToStoreRowIndex);
                sAPGetGridViewTextContentspropCount++;
            }

            if (sAPGetGridViewTextContentscheckedElementValue != null)
            {
                if (sAPGetGridViewTextContentscheckedElementValue != null)
                {
                    sAPGetGridViewTextContents["CheckedElementValue"] = CSharpExpressionConverter.ConvertToken(sAPGetGridViewTextContentscheckedElementValue);
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
            sAPGetGridViewTextContents["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPGetGridViewTextContentsworkflow);
            if (sAPGetGridViewTextContentspropCount > 0)
            {
                callPayload.Body = sAPGetGridViewTextContents;
            }

            return new ApiConnectionAction<SAPGetGridViewTextContentsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPSelectCalendarMonth(Expression<Func<string>> sAPSelectCalendarMonthsearchSAPElementId, Expression<Func<int>> sAPSelectCalendarMonthmonth, Expression<Func<int>> sAPSelectCalendarMonthyear, Expression<Func<string>> sAPSelectCalendarMonthworkflow)
        {
            var apiCallPath = "/SAPGUI/SAPSelectCalendarMonth";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPSelectCalendarMonth = new JObject();
            var sAPSelectCalendarMonthpropCount = 0;
            sAPSelectCalendarMonthpropCount++;
            sAPSelectCalendarMonth["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPSelectCalendarMonthsearchSAPElementId);
            sAPSelectCalendarMonthpropCount++;
            sAPSelectCalendarMonth["Month"] = CSharpExpressionConverter.ConvertToken(sAPSelectCalendarMonthmonth);
            sAPSelectCalendarMonthpropCount++;
            sAPSelectCalendarMonth["Year"] = CSharpExpressionConverter.ConvertToken(sAPSelectCalendarMonthyear);
            sAPSelectCalendarMonthpropCount++;
            sAPSelectCalendarMonth["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPSelectCalendarMonthworkflow);
            if (sAPSelectCalendarMonthpropCount > 0)
            {
                callPayload.Body = sAPSelectCalendarMonth;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPSelectCalendarWeek(Expression<Func<string>> sAPSelectCalendarWeeksearchSAPElementId, Expression<Func<int>> sAPSelectCalendarWeekweek, Expression<Func<int>> sAPSelectCalendarWeekyear, Expression<Func<string>> sAPSelectCalendarWeekworkflow)
        {
            var apiCallPath = "/SAPGUI/SAPSelectCalendarWeek";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPSelectCalendarWeek = new JObject();
            var sAPSelectCalendarWeekpropCount = 0;
            sAPSelectCalendarWeekpropCount++;
            sAPSelectCalendarWeek["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPSelectCalendarWeeksearchSAPElementId);
            sAPSelectCalendarWeekpropCount++;
            sAPSelectCalendarWeek["Week"] = CSharpExpressionConverter.ConvertToken(sAPSelectCalendarWeekweek);
            sAPSelectCalendarWeekpropCount++;
            sAPSelectCalendarWeek["Year"] = CSharpExpressionConverter.ConvertToken(sAPSelectCalendarWeekyear);
            sAPSelectCalendarWeekpropCount++;
            sAPSelectCalendarWeek["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPSelectCalendarWeekworkflow);
            if (sAPSelectCalendarWeekpropCount > 0)
            {
                callPayload.Body = sAPSelectCalendarWeek;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPSelectCalendarRange(Expression<Func<string>> sAPSelectCalendarRangesearchSAPElementId, Expression<Func<string>> sAPSelectCalendarRangefromDateYYYYMMDD, Expression<Func<string>> sAPSelectCalendarRangetoDateYYYYMMDD, Expression<Func<string>> sAPSelectCalendarRangeworkflow)
        {
            var apiCallPath = "/SAPGUI/SAPSelectCalendarRange";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPSelectCalendarRange = new JObject();
            var sAPSelectCalendarRangepropCount = 0;
            sAPSelectCalendarRangepropCount++;
            sAPSelectCalendarRange["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPSelectCalendarRangesearchSAPElementId);
            sAPSelectCalendarRangepropCount++;
            sAPSelectCalendarRange["FromDateYYYYMMDD"] = CSharpExpressionConverter.ConvertToken(sAPSelectCalendarRangefromDateYYYYMMDD);
            sAPSelectCalendarRangepropCount++;
            sAPSelectCalendarRange["ToDateYYYYMMDD"] = CSharpExpressionConverter.ConvertToken(sAPSelectCalendarRangetoDateYYYYMMDD);
            sAPSelectCalendarRangepropCount++;
            sAPSelectCalendarRange["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPSelectCalendarRangeworkflow);
            if (sAPSelectCalendarRangepropCount > 0)
            {
                callPayload.Body = sAPSelectCalendarRange;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPFocusCalendarDate(Expression<Func<string>> sAPFocusCalendarDatesearchSAPElementId, Expression<Func<string>> sAPFocusCalendarDatedateYYYYMMDD, Expression<Func<string>> sAPFocusCalendarDateworkflow)
        {
            var apiCallPath = "/SAPGUI/SAPFocusCalendarDate";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPFocusCalendarDate = new JObject();
            var sAPFocusCalendarDatepropCount = 0;
            sAPFocusCalendarDatepropCount++;
            sAPFocusCalendarDate["SearchSAPElementId"] = CSharpExpressionConverter.ConvertToken(sAPFocusCalendarDatesearchSAPElementId);
            sAPFocusCalendarDatepropCount++;
            sAPFocusCalendarDate["DateYYYYMMDD"] = CSharpExpressionConverter.ConvertToken(sAPFocusCalendarDatedateYYYYMMDD);
            sAPFocusCalendarDatepropCount++;
            sAPFocusCalendarDate["Workflow"] = CSharpExpressionConverter.ConvertToken(sAPFocusCalendarDateworkflow);
            if (sAPFocusCalendarDatepropCount > 0)
            {
                callPayload.Body = sAPFocusCalendarDate;
            }

            return new ApiConnectionAction(callPayload);
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