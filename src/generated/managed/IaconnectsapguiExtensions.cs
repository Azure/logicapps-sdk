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
        public IWorkflowAction SAPEnableScripting(Expression<Func<string>> sAPEnableScriptingWorkflow, Expression<Func<bool>> sAPEnableScriptingNotifyWhenScriptAttachesToGUI = null, Expression<Func<bool>> sAPEnableScriptingNotifyWhenScriptOpensConnection = null, Expression<Func<bool>> sAPEnableScriptingShowNativeWindowsDialogs = null)
        {
            var apiCallPath = "/SAPGUI/SAPEnableScripting";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPEnableScripting = new JObject();
            var sAPEnableScriptingpropCount = 0;
            if (sAPEnableScriptingNotifyWhenScriptAttachesToGUI != null)
            {
                sAPEnableScripting["NotifyWhenScriptAttachesToGUI"] = ExpressionConverter.ConvertO(sAPEnableScriptingNotifyWhenScriptAttachesToGUI);
                sAPEnableScriptingpropCount++;
            }

            if (sAPEnableScriptingNotifyWhenScriptOpensConnection != null)
            {
                sAPEnableScripting["NotifyWhenScriptOpensConnection"] = ExpressionConverter.ConvertO(sAPEnableScriptingNotifyWhenScriptOpensConnection);
                sAPEnableScriptingpropCount++;
            }

            if (sAPEnableScriptingShowNativeWindowsDialogs != null)
            {
                sAPEnableScripting["ShowNativeWindowsDialogs"] = ExpressionConverter.ConvertO(sAPEnableScriptingShowNativeWindowsDialogs);
                sAPEnableScriptingpropCount++;
            }

            sAPEnableScriptingpropCount++;
            sAPEnableScripting["Workflow"] = ExpressionConverter.ConvertO(sAPEnableScriptingWorkflow);
            if (sAPEnableScriptingpropCount > 0)
            {
                callPayload.Body = sAPEnableScripting;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPLaunchSAPGUIResponse> SAPLaunchSAPGUI(Expression<Func<string>> sAPLaunchSAPGUIWorkflow, Expression<Func<string>> sAPLaunchSAPGUISAPLogonEXE = null, Expression<Func<string>> sAPLaunchSAPGUISAPLogonArguments = null, Expression<Func<bool>> sAPLaunchSAPGUIEnableSAPScripting = null, Expression<Func<bool>> sAPLaunchSAPGUINotifyWhenScriptAttachesToGUI = null, Expression<Func<bool>> sAPLaunchSAPGUINotifyWhenScriptOpensConnection = null, Expression<Func<bool>> sAPLaunchSAPGUIShowNativeWindowsDialogs = null, Expression<Func<bool>> sAPLaunchSAPGUIAttachAfterLaunch = null, Expression<Func<double>> sAPLaunchSAPGUISecondsToWait = null, Expression<Func<string>> sAPLaunchSAPGUISAPProgId = null, Expression<Func<bool>> sAPLaunchSAPGUIDisableSystemMessages = null)
        {
            var apiCallPath = "/SAPGUI/SAPLaunchSAPGUI";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPLaunchSAPGUI = new JObject();
            var sAPLaunchSAPGUIpropCount = 0;
            if (sAPLaunchSAPGUISAPLogonEXE != null)
            {
                sAPLaunchSAPGUI["SAPLogonEXE"] = ExpressionConverter.ConvertO(sAPLaunchSAPGUISAPLogonEXE);
                sAPLaunchSAPGUIpropCount++;
            }

            if (sAPLaunchSAPGUISAPLogonArguments != null)
            {
                sAPLaunchSAPGUI["SAPLogonArguments"] = ExpressionConverter.ConvertO(sAPLaunchSAPGUISAPLogonArguments);
                sAPLaunchSAPGUIpropCount++;
            }

            if (sAPLaunchSAPGUIEnableSAPScripting != null)
            {
                sAPLaunchSAPGUI["EnableSAPScripting"] = ExpressionConverter.ConvertO(sAPLaunchSAPGUIEnableSAPScripting);
                sAPLaunchSAPGUIpropCount++;
            }

            if (sAPLaunchSAPGUINotifyWhenScriptAttachesToGUI != null)
            {
                sAPLaunchSAPGUI["NotifyWhenScriptAttachesToGUI"] = ExpressionConverter.ConvertO(sAPLaunchSAPGUINotifyWhenScriptAttachesToGUI);
                sAPLaunchSAPGUIpropCount++;
            }

            if (sAPLaunchSAPGUINotifyWhenScriptOpensConnection != null)
            {
                sAPLaunchSAPGUI["NotifyWhenScriptOpensConnection"] = ExpressionConverter.ConvertO(sAPLaunchSAPGUINotifyWhenScriptOpensConnection);
                sAPLaunchSAPGUIpropCount++;
            }

            if (sAPLaunchSAPGUIShowNativeWindowsDialogs != null)
            {
                sAPLaunchSAPGUI["ShowNativeWindowsDialogs"] = ExpressionConverter.ConvertO(sAPLaunchSAPGUIShowNativeWindowsDialogs);
                sAPLaunchSAPGUIpropCount++;
            }

            if (sAPLaunchSAPGUIAttachAfterLaunch != null)
            {
                sAPLaunchSAPGUI["AttachAfterLaunch"] = ExpressionConverter.ConvertO(sAPLaunchSAPGUIAttachAfterLaunch);
                sAPLaunchSAPGUIpropCount++;
            }

            if (sAPLaunchSAPGUISecondsToWait != null)
            {
                sAPLaunchSAPGUI["SecondsToWait"] = ExpressionConverter.ConvertO(sAPLaunchSAPGUISecondsToWait);
                sAPLaunchSAPGUIpropCount++;
            }

            if (sAPLaunchSAPGUISAPProgId != null)
            {
                sAPLaunchSAPGUI["SAPProgId"] = ExpressionConverter.ConvertO(sAPLaunchSAPGUISAPProgId);
                sAPLaunchSAPGUIpropCount++;
            }

            if (sAPLaunchSAPGUIDisableSystemMessages != null)
            {
                sAPLaunchSAPGUI["DisableSystemMessages"] = ExpressionConverter.ConvertO(sAPLaunchSAPGUIDisableSystemMessages);
                sAPLaunchSAPGUIpropCount++;
            }

            sAPLaunchSAPGUIpropCount++;
            sAPLaunchSAPGUI["Workflow"] = ExpressionConverter.ConvertO(sAPLaunchSAPGUIWorkflow);
            if (sAPLaunchSAPGUIpropCount > 0)
            {
                callPayload.Body = sAPLaunchSAPGUI;
            }

            return new ApiConnectionAction<SAPLaunchSAPGUIResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPAttachToSAPGUIResponse> SAPAttachToSAPGUI(Expression<Func<string>> sAPAttachToSAPGUIWorkflow, Expression<Func<string>> sAPAttachToSAPGUISAPProgId = null, Expression<Func<bool>> sAPAttachToSAPGUIDisableSystemMessages = null)
        {
            var apiCallPath = "/SAPGUI/SAPAttachToSAPGUI";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPAttachToSAPGUI = new JObject();
            var sAPAttachToSAPGUIpropCount = 0;
            if (sAPAttachToSAPGUISAPProgId != null)
            {
                sAPAttachToSAPGUI["SAPProgId"] = ExpressionConverter.ConvertO(sAPAttachToSAPGUISAPProgId);
                sAPAttachToSAPGUIpropCount++;
            }

            if (sAPAttachToSAPGUIDisableSystemMessages != null)
            {
                sAPAttachToSAPGUI["DisableSystemMessages"] = ExpressionConverter.ConvertO(sAPAttachToSAPGUIDisableSystemMessages);
                sAPAttachToSAPGUIpropCount++;
            }

            sAPAttachToSAPGUIpropCount++;
            sAPAttachToSAPGUI["Workflow"] = ExpressionConverter.ConvertO(sAPAttachToSAPGUIWorkflow);
            if (sAPAttachToSAPGUIpropCount > 0)
            {
                callPayload.Body = sAPAttachToSAPGUI;
            }

            return new ApiConnectionAction<SAPAttachToSAPGUIResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPDetachFromSAPGUI(Expression<Func<string>> sAPDetachFromSAPGUIWorkflow)
        {
            var apiCallPath = "/SAPGUI/SAPDetachFromSAPGUI";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPDetachFromSAPGUI = new JObject();
            var sAPDetachFromSAPGUIpropCount = 0;
            sAPDetachFromSAPGUIpropCount++;
            sAPDetachFromSAPGUI["Workflow"] = ExpressionConverter.ConvertO(sAPDetachFromSAPGUIWorkflow);
            if (sAPDetachFromSAPGUIpropCount > 0)
            {
                callPayload.Body = sAPDetachFromSAPGUI;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetSAPGUIStatusResponse> SAPGetSAPGUIStatus(Expression<Func<string>> sAPGetSAPGUIStatusWorkflow)
        {
            var apiCallPath = "/SAPGUI/SAPGetSAPGUIStatus";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPGetSAPGUIStatus = new JObject();
            var sAPGetSAPGUIStatuspropCount = 0;
            sAPGetSAPGUIStatuspropCount++;
            sAPGetSAPGUIStatus["Workflow"] = ExpressionConverter.ConvertO(sAPGetSAPGUIStatusWorkflow);
            if (sAPGetSAPGUIStatuspropCount > 0)
            {
                callPayload.Body = sAPGetSAPGUIStatus;
            }

            return new ApiConnectionAction<SAPGetSAPGUIStatusResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetSAPSessionsResponse> SAPGetSAPSessions(Expression<Func<string>> sAPGetSAPSessionsWorkflow)
        {
            var apiCallPath = "/SAPGUI/SAPGetSAPSessions";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPGetSAPSessions = new JObject();
            var sAPGetSAPSessionspropCount = 0;
            sAPGetSAPSessionspropCount++;
            sAPGetSAPSessions["Workflow"] = ExpressionConverter.ConvertO(sAPGetSAPSessionsWorkflow);
            if (sAPGetSAPSessionspropCount > 0)
            {
                callPayload.Body = sAPGetSAPSessions;
            }

            return new ApiConnectionAction<SAPGetSAPSessionsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPAttachToSessionResponse> SAPAttachToSession(Expression<Func<string>> sAPAttachToSessionWorkflow, Expression<Func<string>> sAPAttachToSessionSearchConnectionName = null, Expression<Func<string>> sAPAttachToSessionSearchSessionName = null)
        {
            var apiCallPath = "/SAPGUI/SAPAttachToSession";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPAttachToSession = new JObject();
            var sAPAttachToSessionpropCount = 0;
            if (sAPAttachToSessionSearchConnectionName != null)
            {
                sAPAttachToSession["SearchConnectionName"] = ExpressionConverter.ConvertO(sAPAttachToSessionSearchConnectionName);
                sAPAttachToSessionpropCount++;
            }

            if (sAPAttachToSessionSearchSessionName != null)
            {
                sAPAttachToSession["SearchSessionName"] = ExpressionConverter.ConvertO(sAPAttachToSessionSearchSessionName);
                sAPAttachToSessionpropCount++;
            }

            sAPAttachToSessionpropCount++;
            sAPAttachToSession["Workflow"] = ExpressionConverter.ConvertO(sAPAttachToSessionWorkflow);
            if (sAPAttachToSessionpropCount > 0)
            {
                callPayload.Body = sAPAttachToSession;
            }

            return new ApiConnectionAction<SAPAttachToSessionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPCloseSession(Expression<Func<string>> sAPCloseSessionWorkflow, Expression<Func<bool>> sAPCloseSessionCloseAttachedSession = null, Expression<Func<string>> sAPCloseSessionSearchConnectionName = null, Expression<Func<string>> sAPCloseSessionSearchSessionName = null)
        {
            var apiCallPath = "/SAPGUI/SAPCloseSession";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPCloseSession = new JObject();
            var sAPCloseSessionpropCount = 0;
            if (sAPCloseSessionCloseAttachedSession != null)
            {
                sAPCloseSession["CloseAttachedSession"] = ExpressionConverter.ConvertO(sAPCloseSessionCloseAttachedSession);
                sAPCloseSessionpropCount++;
            }

            if (sAPCloseSessionSearchConnectionName != null)
            {
                sAPCloseSession["SearchConnectionName"] = ExpressionConverter.ConvertO(sAPCloseSessionSearchConnectionName);
                sAPCloseSessionpropCount++;
            }

            if (sAPCloseSessionSearchSessionName != null)
            {
                sAPCloseSession["SearchSessionName"] = ExpressionConverter.ConvertO(sAPCloseSessionSearchSessionName);
                sAPCloseSessionpropCount++;
            }

            sAPCloseSessionpropCount++;
            sAPCloseSession["Workflow"] = ExpressionConverter.ConvertO(sAPCloseSessionWorkflow);
            if (sAPCloseSessionpropCount > 0)
            {
                callPayload.Body = sAPCloseSession;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetAttachedSessionPropertiesResponse> SAPGetAttachedSessionProperties(Expression<Func<string>> sAPGetAttachedSessionPropertiesWorkflow)
        {
            var apiCallPath = "/SAPGUI/SAPGetAttachedSessionProperties";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPGetAttachedSessionProperties = new JObject();
            var sAPGetAttachedSessionPropertiespropCount = 0;
            sAPGetAttachedSessionPropertiespropCount++;
            sAPGetAttachedSessionProperties["Workflow"] = ExpressionConverter.ConvertO(sAPGetAttachedSessionPropertiesWorkflow);
            if (sAPGetAttachedSessionPropertiespropCount > 0)
            {
                callPayload.Body = sAPGetAttachedSessionProperties;
            }

            return new ApiConnectionAction<SAPGetAttachedSessionPropertiesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPWaitForAttachedSessionNotBusyResponse> SAPWaitForAttachedSessionNotBusy(Expression<Func<double>> sAPWaitForAttachedSessionNotBusySecondsToWait, Expression<Func<string>> sAPWaitForAttachedSessionNotBusyWorkflow, Expression<Func<bool>> sAPWaitForAttachedSessionNotBusyRaiseExceptionIfBusyAfterWait = null)
        {
            var apiCallPath = "/SAPGUI/SAPWaitForAttachedSessionNotBusy";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPWaitForAttachedSessionNotBusy = new JObject();
            var sAPWaitForAttachedSessionNotBusypropCount = 0;
            sAPWaitForAttachedSessionNotBusypropCount++;
            sAPWaitForAttachedSessionNotBusy["SecondsToWait"] = ExpressionConverter.ConvertO(sAPWaitForAttachedSessionNotBusySecondsToWait);
            if (sAPWaitForAttachedSessionNotBusyRaiseExceptionIfBusyAfterWait != null)
            {
                sAPWaitForAttachedSessionNotBusy["RaiseExceptionIfBusyAfterWait"] = ExpressionConverter.ConvertO(sAPWaitForAttachedSessionNotBusyRaiseExceptionIfBusyAfterWait);
                sAPWaitForAttachedSessionNotBusypropCount++;
            }

            sAPWaitForAttachedSessionNotBusypropCount++;
            sAPWaitForAttachedSessionNotBusy["Workflow"] = ExpressionConverter.ConvertO(sAPWaitForAttachedSessionNotBusyWorkflow);
            if (sAPWaitForAttachedSessionNotBusypropCount > 0)
            {
                callPayload.Body = sAPWaitForAttachedSessionNotBusy;
            }

            return new ApiConnectionAction<SAPWaitForAttachedSessionNotBusyResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPInputTextIntoSAPElement(Expression<Func<string>> sAPInputTextIntoSAPElementSearchSAPElementId, Expression<Func<string>> sAPInputTextIntoSAPElementWorkflow, Expression<Func<string>> sAPInputTextIntoSAPElementTextToInput = null, Expression<Func<bool>> sAPInputTextIntoSAPElementReplaceExistingValue = null, Expression<Func<int>> sAPInputTextIntoSAPElementInsertPosition = null)
        {
            var apiCallPath = "/SAPGUI/SAPInputTextIntoSAPElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPInputTextIntoSAPElement = new JObject();
            var sAPInputTextIntoSAPElementpropCount = 0;
            sAPInputTextIntoSAPElementpropCount++;
            sAPInputTextIntoSAPElement["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPInputTextIntoSAPElementSearchSAPElementId);
            if (sAPInputTextIntoSAPElementTextToInput != null)
            {
                sAPInputTextIntoSAPElement["TextToInput"] = ExpressionConverter.ConvertO(sAPInputTextIntoSAPElementTextToInput);
                sAPInputTextIntoSAPElementpropCount++;
            }

            if (sAPInputTextIntoSAPElementReplaceExistingValue != null)
            {
                sAPInputTextIntoSAPElement["ReplaceExistingValue"] = ExpressionConverter.ConvertO(sAPInputTextIntoSAPElementReplaceExistingValue);
                sAPInputTextIntoSAPElementpropCount++;
            }

            if (sAPInputTextIntoSAPElementInsertPosition != null)
            {
                sAPInputTextIntoSAPElement["InsertPosition"] = ExpressionConverter.ConvertO(sAPInputTextIntoSAPElementInsertPosition);
                sAPInputTextIntoSAPElementpropCount++;
            }

            sAPInputTextIntoSAPElementpropCount++;
            sAPInputTextIntoSAPElement["Workflow"] = ExpressionConverter.ConvertO(sAPInputTextIntoSAPElementWorkflow);
            if (sAPInputTextIntoSAPElementpropCount > 0)
            {
                callPayload.Body = sAPInputTextIntoSAPElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPInputPasswordIntoSAPElement(Expression<Func<string>> sAPInputPasswordIntoSAPElementSearchSAPElementId, Expression<Func<string>> sAPInputPasswordIntoSAPElementPasswordToInput, Expression<Func<string>> sAPInputPasswordIntoSAPElementWorkflow)
        {
            var apiCallPath = "/SAPGUI/SAPInputPasswordIntoSAPElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPInputPasswordIntoSAPElement = new JObject();
            var sAPInputPasswordIntoSAPElementpropCount = 0;
            sAPInputPasswordIntoSAPElementpropCount++;
            sAPInputPasswordIntoSAPElement["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPInputPasswordIntoSAPElementSearchSAPElementId);
            sAPInputPasswordIntoSAPElementpropCount++;
            sAPInputPasswordIntoSAPElement["PasswordToInput"] = ExpressionConverter.ConvertO(sAPInputPasswordIntoSAPElementPasswordToInput);
            sAPInputPasswordIntoSAPElementpropCount++;
            sAPInputPasswordIntoSAPElement["Workflow"] = ExpressionConverter.ConvertO(sAPInputPasswordIntoSAPElementWorkflow);
            if (sAPInputPasswordIntoSAPElementpropCount > 0)
            {
                callPayload.Body = sAPInputPasswordIntoSAPElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetElementPropertiesResponse> SAPGetElementProperties(Expression<Func<string>> sAPGetElementPropertiesSearchSAPElementId, Expression<Func<string>> sAPGetElementPropertiesWorkflow)
        {
            var apiCallPath = "/SAPGUI/SAPGetElementProperties";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPGetElementProperties = new JObject();
            var sAPGetElementPropertiespropCount = 0;
            sAPGetElementPropertiespropCount++;
            sAPGetElementProperties["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGetElementPropertiesSearchSAPElementId);
            sAPGetElementPropertiespropCount++;
            sAPGetElementProperties["Workflow"] = ExpressionConverter.ConvertO(sAPGetElementPropertiesWorkflow);
            if (sAPGetElementPropertiespropCount > 0)
            {
                callPayload.Body = sAPGetElementProperties;
            }

            return new ApiConnectionAction<SAPGetElementPropertiesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPWaitForElementIdResponse> SAPWaitForElementId(Expression<Func<string>> sAPWaitForElementIdSearchSAPElementId, Expression<Func<string>> sAPWaitForElementIdWorkflow, Expression<Func<double>> sAPWaitForElementIdSecondsToWait = null, Expression<Func<bool>> sAPWaitForElementIdRaiseExceptionIfElementNotFound = null)
        {
            var apiCallPath = "/SAPGUI/SAPWaitForElementId";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPWaitForElementId = new JObject();
            var sAPWaitForElementIdpropCount = 0;
            sAPWaitForElementIdpropCount++;
            sAPWaitForElementId["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPWaitForElementIdSearchSAPElementId);
            if (sAPWaitForElementIdSecondsToWait != null)
            {
                sAPWaitForElementId["SecondsToWait"] = ExpressionConverter.ConvertO(sAPWaitForElementIdSecondsToWait);
                sAPWaitForElementIdpropCount++;
            }

            if (sAPWaitForElementIdRaiseExceptionIfElementNotFound != null)
            {
                sAPWaitForElementId["RaiseExceptionIfElementNotFound"] = ExpressionConverter.ConvertO(sAPWaitForElementIdRaiseExceptionIfElementNotFound);
                sAPWaitForElementIdpropCount++;
            }

            sAPWaitForElementIdpropCount++;
            sAPWaitForElementId["Workflow"] = ExpressionConverter.ConvertO(sAPWaitForElementIdWorkflow);
            if (sAPWaitForElementIdpropCount > 0)
            {
                callPayload.Body = sAPWaitForElementId;
            }

            return new ApiConnectionAction<SAPWaitForElementIdResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPWaitForWindowResponse> SAPWaitForWindow(Expression<Func<string>> sAPWaitForWindowSearchSAPWindowTitle, Expression<Func<string>> sAPWaitForWindowWorkflow, Expression<Func<bool>> sAPWaitForWindowSearchIsRegularExpression = null, Expression<Func<bool>> sAPWaitForWindowSearchIsCaseSensitive = null, Expression<Func<double>> sAPWaitForWindowSecondsToWait = null, Expression<Func<bool>> sAPWaitForWindowRaiseExceptionIfElementNotFound = null)
        {
            var apiCallPath = "/SAPGUI/SAPWaitForWindow";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPWaitForWindow = new JObject();
            var sAPWaitForWindowpropCount = 0;
            sAPWaitForWindowpropCount++;
            sAPWaitForWindow["SearchSAPWindowTitle"] = ExpressionConverter.ConvertO(sAPWaitForWindowSearchSAPWindowTitle);
            if (sAPWaitForWindowSearchIsRegularExpression != null)
            {
                sAPWaitForWindow["SearchIsRegularExpression"] = ExpressionConverter.ConvertO(sAPWaitForWindowSearchIsRegularExpression);
                sAPWaitForWindowpropCount++;
            }

            if (sAPWaitForWindowSearchIsCaseSensitive != null)
            {
                sAPWaitForWindow["SearchIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPWaitForWindowSearchIsCaseSensitive);
                sAPWaitForWindowpropCount++;
            }

            if (sAPWaitForWindowSecondsToWait != null)
            {
                sAPWaitForWindow["SecondsToWait"] = ExpressionConverter.ConvertO(sAPWaitForWindowSecondsToWait);
                sAPWaitForWindowpropCount++;
            }

            if (sAPWaitForWindowRaiseExceptionIfElementNotFound != null)
            {
                sAPWaitForWindow["RaiseExceptionIfElementNotFound"] = ExpressionConverter.ConvertO(sAPWaitForWindowRaiseExceptionIfElementNotFound);
                sAPWaitForWindowpropCount++;
            }

            sAPWaitForWindowpropCount++;
            sAPWaitForWindow["Workflow"] = ExpressionConverter.ConvertO(sAPWaitForWindowWorkflow);
            if (sAPWaitForWindowpropCount > 0)
            {
                callPayload.Body = sAPWaitForWindow;
            }

            return new ApiConnectionAction<SAPWaitForWindowResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetElementTextValueResponse> SAPGetElementTextValue(Expression<Func<string>> sAPGetElementTextValueSearchSAPElementId, Expression<Func<string>> sAPGetElementTextValueWorkflow)
        {
            var apiCallPath = "/SAPGUI/SAPGetElementTextValue";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPGetElementTextValue = new JObject();
            var sAPGetElementTextValuepropCount = 0;
            sAPGetElementTextValuepropCount++;
            sAPGetElementTextValue["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGetElementTextValueSearchSAPElementId);
            sAPGetElementTextValuepropCount++;
            sAPGetElementTextValue["Workflow"] = ExpressionConverter.ConvertO(sAPGetElementTextValueWorkflow);
            if (sAPGetElementTextValuepropCount > 0)
            {
                callPayload.Body = sAPGetElementTextValue;
            }

            return new ApiConnectionAction<SAPGetElementTextValueResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPPressSAPElement(Expression<Func<string>> sAPPressSAPElementSearchSAPElementId, Expression<Func<string>> sAPPressSAPElementWorkflow)
        {
            var apiCallPath = "/SAPGUI/SAPPressSAPElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPPressSAPElement = new JObject();
            var sAPPressSAPElementpropCount = 0;
            sAPPressSAPElementpropCount++;
            sAPPressSAPElement["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPPressSAPElementSearchSAPElementId);
            sAPPressSAPElementpropCount++;
            sAPPressSAPElement["Workflow"] = ExpressionConverter.ConvertO(sAPPressSAPElementWorkflow);
            if (sAPPressSAPElementpropCount > 0)
            {
                callPayload.Body = sAPPressSAPElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPSelectSAPElement(Expression<Func<string>> sAPSelectSAPElementSearchSAPElementId, Expression<Func<string>> sAPSelectSAPElementWorkflow)
        {
            var apiCallPath = "/SAPGUI/SAPSelectSAPElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPSelectSAPElement = new JObject();
            var sAPSelectSAPElementpropCount = 0;
            sAPSelectSAPElementpropCount++;
            sAPSelectSAPElement["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPSelectSAPElementSearchSAPElementId);
            sAPSelectSAPElementpropCount++;
            sAPSelectSAPElement["Workflow"] = ExpressionConverter.ConvertO(sAPSelectSAPElementWorkflow);
            if (sAPSelectSAPElementpropCount > 0)
            {
                callPayload.Body = sAPSelectSAPElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPFocusSAPElement(Expression<Func<string>> sAPFocusSAPElementSearchSAPElementId, Expression<Func<string>> sAPFocusSAPElementWorkflow)
        {
            var apiCallPath = "/SAPGUI/SAPFocusSAPElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPFocusSAPElement = new JObject();
            var sAPFocusSAPElementpropCount = 0;
            sAPFocusSAPElementpropCount++;
            sAPFocusSAPElement["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPFocusSAPElementSearchSAPElementId);
            sAPFocusSAPElementpropCount++;
            sAPFocusSAPElement["Workflow"] = ExpressionConverter.ConvertO(sAPFocusSAPElementWorkflow);
            if (sAPFocusSAPElementpropCount > 0)
            {
                callPayload.Body = sAPFocusSAPElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPCheckSAPElement(Expression<Func<string>> sAPCheckSAPElementSearchSAPElementId, Expression<Func<string>> sAPCheckSAPElementWorkflow, Expression<Func<bool>> sAPCheckSAPElementCheckElement = null)
        {
            var apiCallPath = "/SAPGUI/SAPCheckSAPElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPCheckSAPElement = new JObject();
            var sAPCheckSAPElementpropCount = 0;
            sAPCheckSAPElementpropCount++;
            sAPCheckSAPElement["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPCheckSAPElementSearchSAPElementId);
            if (sAPCheckSAPElementCheckElement != null)
            {
                sAPCheckSAPElement["CheckElement"] = ExpressionConverter.ConvertO(sAPCheckSAPElementCheckElement);
                sAPCheckSAPElementpropCount++;
            }

            sAPCheckSAPElementpropCount++;
            sAPCheckSAPElement["Workflow"] = ExpressionConverter.ConvertO(sAPCheckSAPElementWorkflow);
            if (sAPCheckSAPElementpropCount > 0)
            {
                callPayload.Body = sAPCheckSAPElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPVisualiseSAPElement(Expression<Func<string>> sAPVisualiseSAPElementSearchSAPElementId, Expression<Func<string>> sAPVisualiseSAPElementWorkflow, Expression<Func<bool>> sAPVisualiseSAPElementVisualiseOn = null)
        {
            var apiCallPath = "/SAPGUI/SAPVisualiseSAPElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPVisualiseSAPElement = new JObject();
            var sAPVisualiseSAPElementpropCount = 0;
            sAPVisualiseSAPElementpropCount++;
            sAPVisualiseSAPElement["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPVisualiseSAPElementSearchSAPElementId);
            if (sAPVisualiseSAPElementVisualiseOn != null)
            {
                sAPVisualiseSAPElement["VisualiseOn"] = ExpressionConverter.ConvertO(sAPVisualiseSAPElementVisualiseOn);
                sAPVisualiseSAPElementpropCount++;
            }

            sAPVisualiseSAPElementpropCount++;
            sAPVisualiseSAPElement["Workflow"] = ExpressionConverter.ConvertO(sAPVisualiseSAPElementWorkflow);
            if (sAPVisualiseSAPElementpropCount > 0)
            {
                callPayload.Body = sAPVisualiseSAPElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPDrawRectangleAroundSAPElement(Expression<Func<string>> sAPDrawRectangleAroundSAPElementSearchSAPElementId, Expression<Func<string>> sAPDrawRectangleAroundSAPElementWorkflow, Expression<Func<string>> sAPDrawRectangleAroundSAPElementPenColour = null, Expression<Func<int>> sAPDrawRectangleAroundSAPElementPenThicknessPixels = null)
        {
            var apiCallPath = "/SAPGUI/SAPDrawRectangleAroundSAPElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPDrawRectangleAroundSAPElement = new JObject();
            var sAPDrawRectangleAroundSAPElementpropCount = 0;
            sAPDrawRectangleAroundSAPElementpropCount++;
            sAPDrawRectangleAroundSAPElement["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPDrawRectangleAroundSAPElementSearchSAPElementId);
            if (sAPDrawRectangleAroundSAPElementPenColour != null)
            {
                sAPDrawRectangleAroundSAPElement["PenColour"] = ExpressionConverter.ConvertO(sAPDrawRectangleAroundSAPElementPenColour);
                sAPDrawRectangleAroundSAPElementpropCount++;
            }

            if (sAPDrawRectangleAroundSAPElementPenThicknessPixels != null)
            {
                sAPDrawRectangleAroundSAPElement["PenThicknessPixels"] = ExpressionConverter.ConvertO(sAPDrawRectangleAroundSAPElementPenThicknessPixels);
                sAPDrawRectangleAroundSAPElementpropCount++;
            }

            sAPDrawRectangleAroundSAPElementpropCount++;
            sAPDrawRectangleAroundSAPElement["Workflow"] = ExpressionConverter.ConvertO(sAPDrawRectangleAroundSAPElementWorkflow);
            if (sAPDrawRectangleAroundSAPElementpropCount > 0)
            {
                callPayload.Body = sAPDrawRectangleAroundSAPElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPSendCommand(Expression<Func<string>> sAPSendCommandSAPCommand, Expression<Func<string>> sAPSendCommandWorkflow)
        {
            var apiCallPath = "/SAPGUI/SAPSendCommand";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPSendCommand = new JObject();
            var sAPSendCommandpropCount = 0;
            sAPSendCommandpropCount++;
            sAPSendCommand["SAPCommand"] = ExpressionConverter.ConvertO(sAPSendCommandSAPCommand);
            sAPSendCommandpropCount++;
            sAPSendCommand["Workflow"] = ExpressionConverter.ConvertO(sAPSendCommandWorkflow);
            if (sAPSendCommandpropCount > 0)
            {
                callPayload.Body = sAPSendCommand;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPEnterTCode(Expression<Func<string>> sAPEnterTCodeSAPTCode, Expression<Func<string>> sAPEnterTCodeWorkflow)
        {
            var apiCallPath = "/SAPGUI/SAPEnterTCode";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPEnterTCode = new JObject();
            var sAPEnterTCodepropCount = 0;
            sAPEnterTCodepropCount++;
            sAPEnterTCode["SAPTCode"] = ExpressionConverter.ConvertO(sAPEnterTCodeSAPTCode);
            sAPEnterTCodepropCount++;
            sAPEnterTCode["Workflow"] = ExpressionConverter.ConvertO(sAPEnterTCodeWorkflow);
            if (sAPEnterTCodepropCount > 0)
            {
                callPayload.Body = sAPEnterTCode;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPSendVKey(Expression<Func<string>> sAPSendVKeySearchSAPElementId, Expression<Func<int>> sAPSendVKeySAPVKey, Expression<Func<string>> sAPSendVKeyWorkflow, Expression<Func<bool>> sAPSendVKeyDetectParentWindowElement = null)
        {
            var apiCallPath = "/SAPGUI/SAPSendVKey";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPSendVKey = new JObject();
            var sAPSendVKeypropCount = 0;
            sAPSendVKeypropCount++;
            sAPSendVKey["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPSendVKeySearchSAPElementId);
            sAPSendVKeypropCount++;
            sAPSendVKey["SAPVKey"] = ExpressionConverter.ConvertO(sAPSendVKeySAPVKey);
            if (sAPSendVKeyDetectParentWindowElement != null)
            {
                sAPSendVKey["DetectParentWindowElement"] = ExpressionConverter.ConvertO(sAPSendVKeyDetectParentWindowElement);
                sAPSendVKeypropCount++;
            }

            sAPSendVKeypropCount++;
            sAPSendVKey["Workflow"] = ExpressionConverter.ConvertO(sAPSendVKeyWorkflow);
            if (sAPSendVKeypropCount > 0)
            {
                callPayload.Body = sAPSendVKey;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPSendEnterVKey(Expression<Func<string>> sAPSendEnterVKeySearchSAPElementId, Expression<Func<string>> sAPSendEnterVKeyWorkflow, Expression<Func<bool>> sAPSendEnterVKeyDetectParentWindowElement = null)
        {
            var apiCallPath = "/SAPGUI/SAPSendEnterVKey";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPSendEnterVKey = new JObject();
            var sAPSendEnterVKeypropCount = 0;
            sAPSendEnterVKeypropCount++;
            sAPSendEnterVKey["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPSendEnterVKeySearchSAPElementId);
            if (sAPSendEnterVKeyDetectParentWindowElement != null)
            {
                sAPSendEnterVKey["DetectParentWindowElement"] = ExpressionConverter.ConvertO(sAPSendEnterVKeyDetectParentWindowElement);
                sAPSendEnterVKeypropCount++;
            }

            sAPSendEnterVKeypropCount++;
            sAPSendEnterVKey["Workflow"] = ExpressionConverter.ConvertO(sAPSendEnterVKeyWorkflow);
            if (sAPSendEnterVKeypropCount > 0)
            {
                callPayload.Body = sAPSendEnterVKey;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPWindowRestore(Expression<Func<string>> sAPWindowRestoreSearchSAPElementId, Expression<Func<string>> sAPWindowRestoreWorkflow, Expression<Func<bool>> sAPWindowRestoreDetectParentWindowElement = null)
        {
            var apiCallPath = "/SAPGUI/SAPWindowRestore";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPWindowRestore = new JObject();
            var sAPWindowRestorepropCount = 0;
            sAPWindowRestorepropCount++;
            sAPWindowRestore["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPWindowRestoreSearchSAPElementId);
            if (sAPWindowRestoreDetectParentWindowElement != null)
            {
                sAPWindowRestore["DetectParentWindowElement"] = ExpressionConverter.ConvertO(sAPWindowRestoreDetectParentWindowElement);
                sAPWindowRestorepropCount++;
            }

            sAPWindowRestorepropCount++;
            sAPWindowRestore["Workflow"] = ExpressionConverter.ConvertO(sAPWindowRestoreWorkflow);
            if (sAPWindowRestorepropCount > 0)
            {
                callPayload.Body = sAPWindowRestore;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPWindowMaximise(Expression<Func<string>> sAPWindowMaximiseSearchSAPElementId, Expression<Func<string>> sAPWindowMaximiseWorkflow, Expression<Func<bool>> sAPWindowMaximiseDetectParentWindowElement = null)
        {
            var apiCallPath = "/SAPGUI/SAPWindowMaximise";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPWindowMaximise = new JObject();
            var sAPWindowMaximisepropCount = 0;
            sAPWindowMaximisepropCount++;
            sAPWindowMaximise["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPWindowMaximiseSearchSAPElementId);
            if (sAPWindowMaximiseDetectParentWindowElement != null)
            {
                sAPWindowMaximise["DetectParentWindowElement"] = ExpressionConverter.ConvertO(sAPWindowMaximiseDetectParentWindowElement);
                sAPWindowMaximisepropCount++;
            }

            sAPWindowMaximisepropCount++;
            sAPWindowMaximise["Workflow"] = ExpressionConverter.ConvertO(sAPWindowMaximiseWorkflow);
            if (sAPWindowMaximisepropCount > 0)
            {
                callPayload.Body = sAPWindowMaximise;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPWindowMinimise(Expression<Func<string>> sAPWindowMinimiseSearchSAPElementId, Expression<Func<string>> sAPWindowMinimiseWorkflow, Expression<Func<bool>> sAPWindowMinimiseDetectParentWindowElement = null)
        {
            var apiCallPath = "/SAPGUI/SAPWindowMinimise";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPWindowMinimise = new JObject();
            var sAPWindowMinimisepropCount = 0;
            sAPWindowMinimisepropCount++;
            sAPWindowMinimise["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPWindowMinimiseSearchSAPElementId);
            if (sAPWindowMinimiseDetectParentWindowElement != null)
            {
                sAPWindowMinimise["DetectParentWindowElement"] = ExpressionConverter.ConvertO(sAPWindowMinimiseDetectParentWindowElement);
                sAPWindowMinimisepropCount++;
            }

            sAPWindowMinimisepropCount++;
            sAPWindowMinimise["Workflow"] = ExpressionConverter.ConvertO(sAPWindowMinimiseWorkflow);
            if (sAPWindowMinimisepropCount > 0)
            {
                callPayload.Body = sAPWindowMinimise;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPWindowClose(Expression<Func<string>> sAPWindowCloseSearchSAPElementId, Expression<Func<string>> sAPWindowCloseWorkflow, Expression<Func<bool>> sAPWindowCloseDetectParentWindowElement = null)
        {
            var apiCallPath = "/SAPGUI/SAPWindowClose";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPWindowClose = new JObject();
            var sAPWindowClosepropCount = 0;
            sAPWindowClosepropCount++;
            sAPWindowClose["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPWindowCloseSearchSAPElementId);
            if (sAPWindowCloseDetectParentWindowElement != null)
            {
                sAPWindowClose["DetectParentWindowElement"] = ExpressionConverter.ConvertO(sAPWindowCloseDetectParentWindowElement);
                sAPWindowClosepropCount++;
            }

            sAPWindowClosepropCount++;
            sAPWindowClose["Workflow"] = ExpressionConverter.ConvertO(sAPWindowCloseWorkflow);
            if (sAPWindowClosepropCount > 0)
            {
                callPayload.Body = sAPWindowClose;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPBringWindowToFront(Expression<Func<string>> sAPBringWindowToFrontSearchSAPElementId, Expression<Func<string>> sAPBringWindowToFrontWorkflow, Expression<Func<bool>> sAPBringWindowToFrontToggleWindow = null, Expression<Func<bool>> sAPBringWindowToFrontToggleUsesGlobalLeftMouseClickAgent = null, Expression<Func<double>> sAPBringWindowToFrontToggleDelay = null, Expression<Func<bool>> sAPBringWindowToFrontDetectParentWindowElement = null)
        {
            var apiCallPath = "/SAPGUI/SAPBringWindowToFront";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPBringWindowToFront = new JObject();
            var sAPBringWindowToFrontpropCount = 0;
            sAPBringWindowToFrontpropCount++;
            sAPBringWindowToFront["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPBringWindowToFrontSearchSAPElementId);
            if (sAPBringWindowToFrontToggleWindow != null)
            {
                sAPBringWindowToFront["ToggleWindow"] = ExpressionConverter.ConvertO(sAPBringWindowToFrontToggleWindow);
                sAPBringWindowToFrontpropCount++;
            }

            if (sAPBringWindowToFrontToggleUsesGlobalLeftMouseClickAgent != null)
            {
                sAPBringWindowToFront["ToggleUsesGlobalLeftMouseClickAgent"] = ExpressionConverter.ConvertO(sAPBringWindowToFrontToggleUsesGlobalLeftMouseClickAgent);
                sAPBringWindowToFrontpropCount++;
            }

            if (sAPBringWindowToFrontToggleDelay != null)
            {
                sAPBringWindowToFront["ToggleDelay"] = ExpressionConverter.ConvertO(sAPBringWindowToFrontToggleDelay);
                sAPBringWindowToFrontpropCount++;
            }

            if (sAPBringWindowToFrontDetectParentWindowElement != null)
            {
                sAPBringWindowToFront["DetectParentWindowElement"] = ExpressionConverter.ConvertO(sAPBringWindowToFrontDetectParentWindowElement);
                sAPBringWindowToFrontpropCount++;
            }

            sAPBringWindowToFrontpropCount++;
            sAPBringWindowToFront["Workflow"] = ExpressionConverter.ConvertO(sAPBringWindowToFrontWorkflow);
            if (sAPBringWindowToFrontpropCount > 0)
            {
                callPayload.Body = sAPBringWindowToFront;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPGlobalLeftMouseClickOnSAPElement(Expression<Func<string>> sAPGlobalLeftMouseClickOnSAPElementSearchSAPElementId, Expression<Func<string>> sAPGlobalLeftMouseClickOnSAPElementWorkflow, Expression<Func<bool>> sAPGlobalLeftMouseClickOnSAPElementSetElementWindowTopMost = null, Expression<Func<bool>> sAPGlobalLeftMouseClickOnSAPElementBringElementWindowToFront = null, Expression<Func<bool>> sAPGlobalLeftMouseClickOnSAPElementToggleWindow = null, Expression<Func<bool>> sAPGlobalLeftMouseClickOnSAPElementToggleUsesGlobalLeftMouseClickAgent = null, Expression<Func<double>> sAPGlobalLeftMouseClickOnSAPElementToggleDelay = null, Expression<Func<int>> sAPGlobalLeftMouseClickOnSAPElementClickOffsetX = null, Expression<Func<int>> sAPGlobalLeftMouseClickOnSAPElementClickOffsetY = null, Expression<Func<sAPGlobalLeftMouseClickOnSAPElementOffsetRelativeToInput>> sAPGlobalLeftMouseClickOnSAPElementOffsetRelativeTo = null)
        {
            var apiCallPath = "/SAPGUI/SAPGlobalLeftMouseClickOnSAPElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPGlobalLeftMouseClickOnSAPElement = new JObject();
            var sAPGlobalLeftMouseClickOnSAPElementpropCount = 0;
            sAPGlobalLeftMouseClickOnSAPElementpropCount++;
            sAPGlobalLeftMouseClickOnSAPElement["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGlobalLeftMouseClickOnSAPElementSearchSAPElementId);
            if (sAPGlobalLeftMouseClickOnSAPElementSetElementWindowTopMost != null)
            {
                sAPGlobalLeftMouseClickOnSAPElement["SetElementWindowTopMost"] = ExpressionConverter.ConvertO(sAPGlobalLeftMouseClickOnSAPElementSetElementWindowTopMost);
                sAPGlobalLeftMouseClickOnSAPElementpropCount++;
            }

            if (sAPGlobalLeftMouseClickOnSAPElementBringElementWindowToFront != null)
            {
                sAPGlobalLeftMouseClickOnSAPElement["BringElementWindowToFront"] = ExpressionConverter.ConvertO(sAPGlobalLeftMouseClickOnSAPElementBringElementWindowToFront);
                sAPGlobalLeftMouseClickOnSAPElementpropCount++;
            }

            if (sAPGlobalLeftMouseClickOnSAPElementToggleWindow != null)
            {
                sAPGlobalLeftMouseClickOnSAPElement["ToggleWindow"] = ExpressionConverter.ConvertO(sAPGlobalLeftMouseClickOnSAPElementToggleWindow);
                sAPGlobalLeftMouseClickOnSAPElementpropCount++;
            }

            if (sAPGlobalLeftMouseClickOnSAPElementToggleUsesGlobalLeftMouseClickAgent != null)
            {
                sAPGlobalLeftMouseClickOnSAPElement["ToggleUsesGlobalLeftMouseClickAgent"] = ExpressionConverter.ConvertO(sAPGlobalLeftMouseClickOnSAPElementToggleUsesGlobalLeftMouseClickAgent);
                sAPGlobalLeftMouseClickOnSAPElementpropCount++;
            }

            if (sAPGlobalLeftMouseClickOnSAPElementToggleDelay != null)
            {
                sAPGlobalLeftMouseClickOnSAPElement["ToggleDelay"] = ExpressionConverter.ConvertO(sAPGlobalLeftMouseClickOnSAPElementToggleDelay);
                sAPGlobalLeftMouseClickOnSAPElementpropCount++;
            }

            if (sAPGlobalLeftMouseClickOnSAPElementClickOffsetX != null)
            {
                sAPGlobalLeftMouseClickOnSAPElement["ClickOffsetX"] = ExpressionConverter.ConvertO(sAPGlobalLeftMouseClickOnSAPElementClickOffsetX);
                sAPGlobalLeftMouseClickOnSAPElementpropCount++;
            }

            if (sAPGlobalLeftMouseClickOnSAPElementClickOffsetY != null)
            {
                sAPGlobalLeftMouseClickOnSAPElement["ClickOffsetY"] = ExpressionConverter.ConvertO(sAPGlobalLeftMouseClickOnSAPElementClickOffsetY);
                sAPGlobalLeftMouseClickOnSAPElementpropCount++;
            }

            if (sAPGlobalLeftMouseClickOnSAPElementOffsetRelativeTo != null)
            {
                sAPGlobalLeftMouseClickOnSAPElement["OffsetRelativeTo"] = ExpressionConverter.ConvertO(sAPGlobalLeftMouseClickOnSAPElementOffsetRelativeTo);
                sAPGlobalLeftMouseClickOnSAPElementpropCount++;
            }

            sAPGlobalLeftMouseClickOnSAPElementpropCount++;
            sAPGlobalLeftMouseClickOnSAPElement["Workflow"] = ExpressionConverter.ConvertO(sAPGlobalLeftMouseClickOnSAPElementWorkflow);
            if (sAPGlobalLeftMouseClickOnSAPElementpropCount > 0)
            {
                callPayload.Body = sAPGlobalLeftMouseClickOnSAPElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPGlobalRightMouseClickOnSAPElement(Expression<Func<string>> sAPGlobalRightMouseClickOnSAPElementSearchSAPElementId, Expression<Func<string>> sAPGlobalRightMouseClickOnSAPElementWorkflow, Expression<Func<bool>> sAPGlobalRightMouseClickOnSAPElementSetElementWindowTopMost = null, Expression<Func<bool>> sAPGlobalRightMouseClickOnSAPElementBringElementWindowToFront = null, Expression<Func<bool>> sAPGlobalRightMouseClickOnSAPElementToggleWindow = null, Expression<Func<bool>> sAPGlobalRightMouseClickOnSAPElementToggleUsesGlobalLeftMouseClickAgent = null, Expression<Func<double>> sAPGlobalRightMouseClickOnSAPElementToggleDelay = null, Expression<Func<int>> sAPGlobalRightMouseClickOnSAPElementClickOffsetX = null, Expression<Func<int>> sAPGlobalRightMouseClickOnSAPElementClickOffsetY = null, Expression<Func<sAPGlobalRightMouseClickOnSAPElementOffsetRelativeToInput>> sAPGlobalRightMouseClickOnSAPElementOffsetRelativeTo = null)
        {
            var apiCallPath = "/SAPGUI/SAPGlobalRightMouseClickOnSAPElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPGlobalRightMouseClickOnSAPElement = new JObject();
            var sAPGlobalRightMouseClickOnSAPElementpropCount = 0;
            sAPGlobalRightMouseClickOnSAPElementpropCount++;
            sAPGlobalRightMouseClickOnSAPElement["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGlobalRightMouseClickOnSAPElementSearchSAPElementId);
            if (sAPGlobalRightMouseClickOnSAPElementSetElementWindowTopMost != null)
            {
                sAPGlobalRightMouseClickOnSAPElement["SetElementWindowTopMost"] = ExpressionConverter.ConvertO(sAPGlobalRightMouseClickOnSAPElementSetElementWindowTopMost);
                sAPGlobalRightMouseClickOnSAPElementpropCount++;
            }

            if (sAPGlobalRightMouseClickOnSAPElementBringElementWindowToFront != null)
            {
                sAPGlobalRightMouseClickOnSAPElement["BringElementWindowToFront"] = ExpressionConverter.ConvertO(sAPGlobalRightMouseClickOnSAPElementBringElementWindowToFront);
                sAPGlobalRightMouseClickOnSAPElementpropCount++;
            }

            if (sAPGlobalRightMouseClickOnSAPElementToggleWindow != null)
            {
                sAPGlobalRightMouseClickOnSAPElement["ToggleWindow"] = ExpressionConverter.ConvertO(sAPGlobalRightMouseClickOnSAPElementToggleWindow);
                sAPGlobalRightMouseClickOnSAPElementpropCount++;
            }

            if (sAPGlobalRightMouseClickOnSAPElementToggleUsesGlobalLeftMouseClickAgent != null)
            {
                sAPGlobalRightMouseClickOnSAPElement["ToggleUsesGlobalLeftMouseClickAgent"] = ExpressionConverter.ConvertO(sAPGlobalRightMouseClickOnSAPElementToggleUsesGlobalLeftMouseClickAgent);
                sAPGlobalRightMouseClickOnSAPElementpropCount++;
            }

            if (sAPGlobalRightMouseClickOnSAPElementToggleDelay != null)
            {
                sAPGlobalRightMouseClickOnSAPElement["ToggleDelay"] = ExpressionConverter.ConvertO(sAPGlobalRightMouseClickOnSAPElementToggleDelay);
                sAPGlobalRightMouseClickOnSAPElementpropCount++;
            }

            if (sAPGlobalRightMouseClickOnSAPElementClickOffsetX != null)
            {
                sAPGlobalRightMouseClickOnSAPElement["ClickOffsetX"] = ExpressionConverter.ConvertO(sAPGlobalRightMouseClickOnSAPElementClickOffsetX);
                sAPGlobalRightMouseClickOnSAPElementpropCount++;
            }

            if (sAPGlobalRightMouseClickOnSAPElementClickOffsetY != null)
            {
                sAPGlobalRightMouseClickOnSAPElement["ClickOffsetY"] = ExpressionConverter.ConvertO(sAPGlobalRightMouseClickOnSAPElementClickOffsetY);
                sAPGlobalRightMouseClickOnSAPElementpropCount++;
            }

            if (sAPGlobalRightMouseClickOnSAPElementOffsetRelativeTo != null)
            {
                sAPGlobalRightMouseClickOnSAPElement["OffsetRelativeTo"] = ExpressionConverter.ConvertO(sAPGlobalRightMouseClickOnSAPElementOffsetRelativeTo);
                sAPGlobalRightMouseClickOnSAPElementpropCount++;
            }

            sAPGlobalRightMouseClickOnSAPElementpropCount++;
            sAPGlobalRightMouseClickOnSAPElement["Workflow"] = ExpressionConverter.ConvertO(sAPGlobalRightMouseClickOnSAPElementWorkflow);
            if (sAPGlobalRightMouseClickOnSAPElementpropCount > 0)
            {
                callPayload.Body = sAPGlobalRightMouseClickOnSAPElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPGlobalMiddleMouseClickOnSAPElement(Expression<Func<string>> sAPGlobalMiddleMouseClickOnSAPElementSearchSAPElementId, Expression<Func<string>> sAPGlobalMiddleMouseClickOnSAPElementWorkflow, Expression<Func<bool>> sAPGlobalMiddleMouseClickOnSAPElementSetElementWindowTopMost = null, Expression<Func<bool>> sAPGlobalMiddleMouseClickOnSAPElementBringElementWindowToFront = null, Expression<Func<bool>> sAPGlobalMiddleMouseClickOnSAPElementToggleWindow = null, Expression<Func<bool>> sAPGlobalMiddleMouseClickOnSAPElementToggleUsesGlobalLeftMouseClickAgent = null, Expression<Func<double>> sAPGlobalMiddleMouseClickOnSAPElementToggleDelay = null, Expression<Func<int>> sAPGlobalMiddleMouseClickOnSAPElementClickOffsetX = null, Expression<Func<int>> sAPGlobalMiddleMouseClickOnSAPElementClickOffsetY = null, Expression<Func<sAPGlobalMiddleMouseClickOnSAPElementOffsetRelativeToInput>> sAPGlobalMiddleMouseClickOnSAPElementOffsetRelativeTo = null)
        {
            var apiCallPath = "/SAPGUI/SAPGlobalMiddleMouseClickOnSAPElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPGlobalMiddleMouseClickOnSAPElement = new JObject();
            var sAPGlobalMiddleMouseClickOnSAPElementpropCount = 0;
            sAPGlobalMiddleMouseClickOnSAPElementpropCount++;
            sAPGlobalMiddleMouseClickOnSAPElement["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGlobalMiddleMouseClickOnSAPElementSearchSAPElementId);
            if (sAPGlobalMiddleMouseClickOnSAPElementSetElementWindowTopMost != null)
            {
                sAPGlobalMiddleMouseClickOnSAPElement["SetElementWindowTopMost"] = ExpressionConverter.ConvertO(sAPGlobalMiddleMouseClickOnSAPElementSetElementWindowTopMost);
                sAPGlobalMiddleMouseClickOnSAPElementpropCount++;
            }

            if (sAPGlobalMiddleMouseClickOnSAPElementBringElementWindowToFront != null)
            {
                sAPGlobalMiddleMouseClickOnSAPElement["BringElementWindowToFront"] = ExpressionConverter.ConvertO(sAPGlobalMiddleMouseClickOnSAPElementBringElementWindowToFront);
                sAPGlobalMiddleMouseClickOnSAPElementpropCount++;
            }

            if (sAPGlobalMiddleMouseClickOnSAPElementToggleWindow != null)
            {
                sAPGlobalMiddleMouseClickOnSAPElement["ToggleWindow"] = ExpressionConverter.ConvertO(sAPGlobalMiddleMouseClickOnSAPElementToggleWindow);
                sAPGlobalMiddleMouseClickOnSAPElementpropCount++;
            }

            if (sAPGlobalMiddleMouseClickOnSAPElementToggleUsesGlobalLeftMouseClickAgent != null)
            {
                sAPGlobalMiddleMouseClickOnSAPElement["ToggleUsesGlobalLeftMouseClickAgent"] = ExpressionConverter.ConvertO(sAPGlobalMiddleMouseClickOnSAPElementToggleUsesGlobalLeftMouseClickAgent);
                sAPGlobalMiddleMouseClickOnSAPElementpropCount++;
            }

            if (sAPGlobalMiddleMouseClickOnSAPElementToggleDelay != null)
            {
                sAPGlobalMiddleMouseClickOnSAPElement["ToggleDelay"] = ExpressionConverter.ConvertO(sAPGlobalMiddleMouseClickOnSAPElementToggleDelay);
                sAPGlobalMiddleMouseClickOnSAPElementpropCount++;
            }

            if (sAPGlobalMiddleMouseClickOnSAPElementClickOffsetX != null)
            {
                sAPGlobalMiddleMouseClickOnSAPElement["ClickOffsetX"] = ExpressionConverter.ConvertO(sAPGlobalMiddleMouseClickOnSAPElementClickOffsetX);
                sAPGlobalMiddleMouseClickOnSAPElementpropCount++;
            }

            if (sAPGlobalMiddleMouseClickOnSAPElementClickOffsetY != null)
            {
                sAPGlobalMiddleMouseClickOnSAPElement["ClickOffsetY"] = ExpressionConverter.ConvertO(sAPGlobalMiddleMouseClickOnSAPElementClickOffsetY);
                sAPGlobalMiddleMouseClickOnSAPElementpropCount++;
            }

            if (sAPGlobalMiddleMouseClickOnSAPElementOffsetRelativeTo != null)
            {
                sAPGlobalMiddleMouseClickOnSAPElement["OffsetRelativeTo"] = ExpressionConverter.ConvertO(sAPGlobalMiddleMouseClickOnSAPElementOffsetRelativeTo);
                sAPGlobalMiddleMouseClickOnSAPElementpropCount++;
            }

            sAPGlobalMiddleMouseClickOnSAPElementpropCount++;
            sAPGlobalMiddleMouseClickOnSAPElement["Workflow"] = ExpressionConverter.ConvertO(sAPGlobalMiddleMouseClickOnSAPElementWorkflow);
            if (sAPGlobalMiddleMouseClickOnSAPElementpropCount > 0)
            {
                callPayload.Body = sAPGlobalMiddleMouseClickOnSAPElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPGlobalDoubleLeftMouseClickOnSAPElement(Expression<Func<string>> sAPGlobalDoubleLeftMouseClickOnSAPElementSearchSAPElementId, Expression<Func<string>> sAPGlobalDoubleLeftMouseClickOnSAPElementWorkflow, Expression<Func<bool>> sAPGlobalDoubleLeftMouseClickOnSAPElementSetElementWindowTopMost = null, Expression<Func<bool>> sAPGlobalDoubleLeftMouseClickOnSAPElementBringElementWindowToFront = null, Expression<Func<bool>> sAPGlobalDoubleLeftMouseClickOnSAPElementToggleWindow = null, Expression<Func<bool>> sAPGlobalDoubleLeftMouseClickOnSAPElementToggleUsesGlobalLeftMouseClickAgent = null, Expression<Func<double>> sAPGlobalDoubleLeftMouseClickOnSAPElementToggleDelay = null, Expression<Func<int>> sAPGlobalDoubleLeftMouseClickOnSAPElementClickOffsetX = null, Expression<Func<int>> sAPGlobalDoubleLeftMouseClickOnSAPElementClickOffsetY = null, Expression<Func<sAPGlobalDoubleLeftMouseClickOnSAPElementOffsetRelativeToInput>> sAPGlobalDoubleLeftMouseClickOnSAPElementOffsetRelativeTo = null, Expression<Func<int>> sAPGlobalDoubleLeftMouseClickOnSAPElementDoubleClickDelayInMilliseconds = null)
        {
            var apiCallPath = "/SAPGUI/SAPGlobalDoubleLeftMouseClickOnSAPElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPGlobalDoubleLeftMouseClickOnSAPElement = new JObject();
            var sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount = 0;
            sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount++;
            sAPGlobalDoubleLeftMouseClickOnSAPElement["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGlobalDoubleLeftMouseClickOnSAPElementSearchSAPElementId);
            if (sAPGlobalDoubleLeftMouseClickOnSAPElementSetElementWindowTopMost != null)
            {
                sAPGlobalDoubleLeftMouseClickOnSAPElement["SetElementWindowTopMost"] = ExpressionConverter.ConvertO(sAPGlobalDoubleLeftMouseClickOnSAPElementSetElementWindowTopMost);
                sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount++;
            }

            if (sAPGlobalDoubleLeftMouseClickOnSAPElementBringElementWindowToFront != null)
            {
                sAPGlobalDoubleLeftMouseClickOnSAPElement["BringElementWindowToFront"] = ExpressionConverter.ConvertO(sAPGlobalDoubleLeftMouseClickOnSAPElementBringElementWindowToFront);
                sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount++;
            }

            if (sAPGlobalDoubleLeftMouseClickOnSAPElementToggleWindow != null)
            {
                sAPGlobalDoubleLeftMouseClickOnSAPElement["ToggleWindow"] = ExpressionConverter.ConvertO(sAPGlobalDoubleLeftMouseClickOnSAPElementToggleWindow);
                sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount++;
            }

            if (sAPGlobalDoubleLeftMouseClickOnSAPElementToggleUsesGlobalLeftMouseClickAgent != null)
            {
                sAPGlobalDoubleLeftMouseClickOnSAPElement["ToggleUsesGlobalLeftMouseClickAgent"] = ExpressionConverter.ConvertO(sAPGlobalDoubleLeftMouseClickOnSAPElementToggleUsesGlobalLeftMouseClickAgent);
                sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount++;
            }

            if (sAPGlobalDoubleLeftMouseClickOnSAPElementToggleDelay != null)
            {
                sAPGlobalDoubleLeftMouseClickOnSAPElement["ToggleDelay"] = ExpressionConverter.ConvertO(sAPGlobalDoubleLeftMouseClickOnSAPElementToggleDelay);
                sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount++;
            }

            if (sAPGlobalDoubleLeftMouseClickOnSAPElementClickOffsetX != null)
            {
                sAPGlobalDoubleLeftMouseClickOnSAPElement["ClickOffsetX"] = ExpressionConverter.ConvertO(sAPGlobalDoubleLeftMouseClickOnSAPElementClickOffsetX);
                sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount++;
            }

            if (sAPGlobalDoubleLeftMouseClickOnSAPElementClickOffsetY != null)
            {
                sAPGlobalDoubleLeftMouseClickOnSAPElement["ClickOffsetY"] = ExpressionConverter.ConvertO(sAPGlobalDoubleLeftMouseClickOnSAPElementClickOffsetY);
                sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount++;
            }

            if (sAPGlobalDoubleLeftMouseClickOnSAPElementOffsetRelativeTo != null)
            {
                sAPGlobalDoubleLeftMouseClickOnSAPElement["OffsetRelativeTo"] = ExpressionConverter.ConvertO(sAPGlobalDoubleLeftMouseClickOnSAPElementOffsetRelativeTo);
                sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount++;
            }

            if (sAPGlobalDoubleLeftMouseClickOnSAPElementDoubleClickDelayInMilliseconds != null)
            {
                sAPGlobalDoubleLeftMouseClickOnSAPElement["DoubleClickDelayInMilliseconds"] = ExpressionConverter.ConvertO(sAPGlobalDoubleLeftMouseClickOnSAPElementDoubleClickDelayInMilliseconds);
                sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount++;
            }

            sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount++;
            sAPGlobalDoubleLeftMouseClickOnSAPElement["Workflow"] = ExpressionConverter.ConvertO(sAPGlobalDoubleLeftMouseClickOnSAPElementWorkflow);
            if (sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount > 0)
            {
                callPayload.Body = sAPGlobalDoubleLeftMouseClickOnSAPElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPGlobalInputTextIntoSAPElement(Expression<Func<string>> sAPGlobalInputTextIntoSAPElementSearchSAPElementId, Expression<Func<string>> sAPGlobalInputTextIntoSAPElementWorkflow, Expression<Func<bool>> sAPGlobalInputTextIntoSAPElementSetElementWindowTopMost = null, Expression<Func<bool>> sAPGlobalInputTextIntoSAPElementBringElementWindowToFront = null, Expression<Func<bool>> sAPGlobalInputTextIntoSAPElementToggleWindow = null, Expression<Func<bool>> sAPGlobalInputTextIntoSAPElementToggleUsesGlobalLeftMouseClickAgent = null, Expression<Func<double>> sAPGlobalInputTextIntoSAPElementToggleDelay = null, Expression<Func<bool>> sAPGlobalInputTextIntoSAPElementGlobalMouseClickOnElement = null, Expression<Func<bool>> sAPGlobalInputTextIntoSAPElementReplaceExistingValueUsingDoubleClickDelete = null, Expression<Func<bool>> sAPGlobalInputTextIntoSAPElementReplaceExistingValueUsingCTRLADelete = null, Expression<Func<string>> sAPGlobalInputTextIntoSAPElementTextToInput = null, Expression<Func<bool>> sAPGlobalInputTextIntoSAPElementSendKeyEvents = null, Expression<Func<int>> sAPGlobalInputTextIntoSAPElementKeyIntervalInMilliseconds = null, Expression<Func<int>> sAPGlobalInputTextIntoSAPElementDoubleClickIntervalInMilliseconds = null, Expression<Func<bool>> sAPGlobalInputTextIntoSAPElementDontInterpretSymbols = null)
        {
            var apiCallPath = "/SAPGUI/SAPGlobalInputTextIntoSAPElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPGlobalInputTextIntoSAPElement = new JObject();
            var sAPGlobalInputTextIntoSAPElementpropCount = 0;
            sAPGlobalInputTextIntoSAPElementpropCount++;
            sAPGlobalInputTextIntoSAPElement["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGlobalInputTextIntoSAPElementSearchSAPElementId);
            if (sAPGlobalInputTextIntoSAPElementSetElementWindowTopMost != null)
            {
                sAPGlobalInputTextIntoSAPElement["SetElementWindowTopMost"] = ExpressionConverter.ConvertO(sAPGlobalInputTextIntoSAPElementSetElementWindowTopMost);
                sAPGlobalInputTextIntoSAPElementpropCount++;
            }

            if (sAPGlobalInputTextIntoSAPElementBringElementWindowToFront != null)
            {
                sAPGlobalInputTextIntoSAPElement["BringElementWindowToFront"] = ExpressionConverter.ConvertO(sAPGlobalInputTextIntoSAPElementBringElementWindowToFront);
                sAPGlobalInputTextIntoSAPElementpropCount++;
            }

            if (sAPGlobalInputTextIntoSAPElementToggleWindow != null)
            {
                sAPGlobalInputTextIntoSAPElement["ToggleWindow"] = ExpressionConverter.ConvertO(sAPGlobalInputTextIntoSAPElementToggleWindow);
                sAPGlobalInputTextIntoSAPElementpropCount++;
            }

            if (sAPGlobalInputTextIntoSAPElementToggleUsesGlobalLeftMouseClickAgent != null)
            {
                sAPGlobalInputTextIntoSAPElement["ToggleUsesGlobalLeftMouseClickAgent"] = ExpressionConverter.ConvertO(sAPGlobalInputTextIntoSAPElementToggleUsesGlobalLeftMouseClickAgent);
                sAPGlobalInputTextIntoSAPElementpropCount++;
            }

            if (sAPGlobalInputTextIntoSAPElementToggleDelay != null)
            {
                sAPGlobalInputTextIntoSAPElement["ToggleDelay"] = ExpressionConverter.ConvertO(sAPGlobalInputTextIntoSAPElementToggleDelay);
                sAPGlobalInputTextIntoSAPElementpropCount++;
            }

            if (sAPGlobalInputTextIntoSAPElementGlobalMouseClickOnElement != null)
            {
                sAPGlobalInputTextIntoSAPElement["GlobalMouseClickOnElement"] = ExpressionConverter.ConvertO(sAPGlobalInputTextIntoSAPElementGlobalMouseClickOnElement);
                sAPGlobalInputTextIntoSAPElementpropCount++;
            }

            if (sAPGlobalInputTextIntoSAPElementReplaceExistingValueUsingDoubleClickDelete != null)
            {
                sAPGlobalInputTextIntoSAPElement["ReplaceExistingValueUsingDoubleClickDelete"] = ExpressionConverter.ConvertO(sAPGlobalInputTextIntoSAPElementReplaceExistingValueUsingDoubleClickDelete);
                sAPGlobalInputTextIntoSAPElementpropCount++;
            }

            if (sAPGlobalInputTextIntoSAPElementReplaceExistingValueUsingCTRLADelete != null)
            {
                sAPGlobalInputTextIntoSAPElement["ReplaceExistingValueUsingCTRLADelete"] = ExpressionConverter.ConvertO(sAPGlobalInputTextIntoSAPElementReplaceExistingValueUsingCTRLADelete);
                sAPGlobalInputTextIntoSAPElementpropCount++;
            }

            if (sAPGlobalInputTextIntoSAPElementTextToInput != null)
            {
                sAPGlobalInputTextIntoSAPElement["TextToInput"] = ExpressionConverter.ConvertO(sAPGlobalInputTextIntoSAPElementTextToInput);
                sAPGlobalInputTextIntoSAPElementpropCount++;
            }

            if (sAPGlobalInputTextIntoSAPElementSendKeyEvents != null)
            {
                sAPGlobalInputTextIntoSAPElement["SendKeyEvents"] = ExpressionConverter.ConvertO(sAPGlobalInputTextIntoSAPElementSendKeyEvents);
                sAPGlobalInputTextIntoSAPElementpropCount++;
            }

            if (sAPGlobalInputTextIntoSAPElementKeyIntervalInMilliseconds != null)
            {
                sAPGlobalInputTextIntoSAPElement["KeyIntervalInMilliseconds"] = ExpressionConverter.ConvertO(sAPGlobalInputTextIntoSAPElementKeyIntervalInMilliseconds);
                sAPGlobalInputTextIntoSAPElementpropCount++;
            }

            if (sAPGlobalInputTextIntoSAPElementDoubleClickIntervalInMilliseconds != null)
            {
                sAPGlobalInputTextIntoSAPElement["DoubleClickIntervalInMilliseconds"] = ExpressionConverter.ConvertO(sAPGlobalInputTextIntoSAPElementDoubleClickIntervalInMilliseconds);
                sAPGlobalInputTextIntoSAPElementpropCount++;
            }

            if (sAPGlobalInputTextIntoSAPElementDontInterpretSymbols != null)
            {
                sAPGlobalInputTextIntoSAPElement["DontInterpretSymbols"] = ExpressionConverter.ConvertO(sAPGlobalInputTextIntoSAPElementDontInterpretSymbols);
                sAPGlobalInputTextIntoSAPElementpropCount++;
            }

            sAPGlobalInputTextIntoSAPElementpropCount++;
            sAPGlobalInputTextIntoSAPElement["Workflow"] = ExpressionConverter.ConvertO(sAPGlobalInputTextIntoSAPElementWorkflow);
            if (sAPGlobalInputTextIntoSAPElementpropCount > 0)
            {
                callPayload.Body = sAPGlobalInputTextIntoSAPElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPGlobalInputPasswordIntoSAPElement(Expression<Func<string>> sAPGlobalInputPasswordIntoSAPElementSearchSAPElementId, Expression<Func<string>> sAPGlobalInputPasswordIntoSAPElementPasswordToInput, Expression<Func<string>> sAPGlobalInputPasswordIntoSAPElementWorkflow, Expression<Func<bool>> sAPGlobalInputPasswordIntoSAPElementSetElementWindowTopMost = null, Expression<Func<bool>> sAPGlobalInputPasswordIntoSAPElementBringElementWindowToFront = null, Expression<Func<bool>> sAPGlobalInputPasswordIntoSAPElementToggleWindow = null, Expression<Func<bool>> sAPGlobalInputPasswordIntoSAPElementToggleUsesGlobalLeftMouseClickAgent = null, Expression<Func<double>> sAPGlobalInputPasswordIntoSAPElementToggleDelay = null, Expression<Func<bool>> sAPGlobalInputPasswordIntoSAPElementGlobalMouseClickOnElement = null, Expression<Func<bool>> sAPGlobalInputPasswordIntoSAPElementReplaceExistingValueUsingDoubleClickDelete = null, Expression<Func<bool>> sAPGlobalInputPasswordIntoSAPElementReplaceExistingValueUsingCTRLADelete = null, Expression<Func<bool>> sAPGlobalInputPasswordIntoSAPElementSendKeyEvents = null, Expression<Func<int>> sAPGlobalInputPasswordIntoSAPElementKeyIntervalInMilliseconds = null, Expression<Func<int>> sAPGlobalInputPasswordIntoSAPElementDoubleClickIntervalInMilliseconds = null, Expression<Func<bool>> sAPGlobalInputPasswordIntoSAPElementDontInterpretSymbols = null)
        {
            var apiCallPath = "/SAPGUI/SAPGlobalInputPasswordIntoSAPElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPGlobalInputPasswordIntoSAPElement = new JObject();
            var sAPGlobalInputPasswordIntoSAPElementpropCount = 0;
            sAPGlobalInputPasswordIntoSAPElementpropCount++;
            sAPGlobalInputPasswordIntoSAPElement["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGlobalInputPasswordIntoSAPElementSearchSAPElementId);
            if (sAPGlobalInputPasswordIntoSAPElementSetElementWindowTopMost != null)
            {
                sAPGlobalInputPasswordIntoSAPElement["SetElementWindowTopMost"] = ExpressionConverter.ConvertO(sAPGlobalInputPasswordIntoSAPElementSetElementWindowTopMost);
                sAPGlobalInputPasswordIntoSAPElementpropCount++;
            }

            if (sAPGlobalInputPasswordIntoSAPElementBringElementWindowToFront != null)
            {
                sAPGlobalInputPasswordIntoSAPElement["BringElementWindowToFront"] = ExpressionConverter.ConvertO(sAPGlobalInputPasswordIntoSAPElementBringElementWindowToFront);
                sAPGlobalInputPasswordIntoSAPElementpropCount++;
            }

            if (sAPGlobalInputPasswordIntoSAPElementToggleWindow != null)
            {
                sAPGlobalInputPasswordIntoSAPElement["ToggleWindow"] = ExpressionConverter.ConvertO(sAPGlobalInputPasswordIntoSAPElementToggleWindow);
                sAPGlobalInputPasswordIntoSAPElementpropCount++;
            }

            if (sAPGlobalInputPasswordIntoSAPElementToggleUsesGlobalLeftMouseClickAgent != null)
            {
                sAPGlobalInputPasswordIntoSAPElement["ToggleUsesGlobalLeftMouseClickAgent"] = ExpressionConverter.ConvertO(sAPGlobalInputPasswordIntoSAPElementToggleUsesGlobalLeftMouseClickAgent);
                sAPGlobalInputPasswordIntoSAPElementpropCount++;
            }

            if (sAPGlobalInputPasswordIntoSAPElementToggleDelay != null)
            {
                sAPGlobalInputPasswordIntoSAPElement["ToggleDelay"] = ExpressionConverter.ConvertO(sAPGlobalInputPasswordIntoSAPElementToggleDelay);
                sAPGlobalInputPasswordIntoSAPElementpropCount++;
            }

            if (sAPGlobalInputPasswordIntoSAPElementGlobalMouseClickOnElement != null)
            {
                sAPGlobalInputPasswordIntoSAPElement["GlobalMouseClickOnElement"] = ExpressionConverter.ConvertO(sAPGlobalInputPasswordIntoSAPElementGlobalMouseClickOnElement);
                sAPGlobalInputPasswordIntoSAPElementpropCount++;
            }

            if (sAPGlobalInputPasswordIntoSAPElementReplaceExistingValueUsingDoubleClickDelete != null)
            {
                sAPGlobalInputPasswordIntoSAPElement["ReplaceExistingValueUsingDoubleClickDelete"] = ExpressionConverter.ConvertO(sAPGlobalInputPasswordIntoSAPElementReplaceExistingValueUsingDoubleClickDelete);
                sAPGlobalInputPasswordIntoSAPElementpropCount++;
            }

            if (sAPGlobalInputPasswordIntoSAPElementReplaceExistingValueUsingCTRLADelete != null)
            {
                sAPGlobalInputPasswordIntoSAPElement["ReplaceExistingValueUsingCTRLADelete"] = ExpressionConverter.ConvertO(sAPGlobalInputPasswordIntoSAPElementReplaceExistingValueUsingCTRLADelete);
                sAPGlobalInputPasswordIntoSAPElementpropCount++;
            }

            sAPGlobalInputPasswordIntoSAPElementpropCount++;
            sAPGlobalInputPasswordIntoSAPElement["PasswordToInput"] = ExpressionConverter.ConvertO(sAPGlobalInputPasswordIntoSAPElementPasswordToInput);
            if (sAPGlobalInputPasswordIntoSAPElementSendKeyEvents != null)
            {
                sAPGlobalInputPasswordIntoSAPElement["SendKeyEvents"] = ExpressionConverter.ConvertO(sAPGlobalInputPasswordIntoSAPElementSendKeyEvents);
                sAPGlobalInputPasswordIntoSAPElementpropCount++;
            }

            if (sAPGlobalInputPasswordIntoSAPElementKeyIntervalInMilliseconds != null)
            {
                sAPGlobalInputPasswordIntoSAPElement["KeyIntervalInMilliseconds"] = ExpressionConverter.ConvertO(sAPGlobalInputPasswordIntoSAPElementKeyIntervalInMilliseconds);
                sAPGlobalInputPasswordIntoSAPElementpropCount++;
            }

            if (sAPGlobalInputPasswordIntoSAPElementDoubleClickIntervalInMilliseconds != null)
            {
                sAPGlobalInputPasswordIntoSAPElement["DoubleClickIntervalInMilliseconds"] = ExpressionConverter.ConvertO(sAPGlobalInputPasswordIntoSAPElementDoubleClickIntervalInMilliseconds);
                sAPGlobalInputPasswordIntoSAPElementpropCount++;
            }

            if (sAPGlobalInputPasswordIntoSAPElementDontInterpretSymbols != null)
            {
                sAPGlobalInputPasswordIntoSAPElement["DontInterpretSymbols"] = ExpressionConverter.ConvertO(sAPGlobalInputPasswordIntoSAPElementDontInterpretSymbols);
                sAPGlobalInputPasswordIntoSAPElementpropCount++;
            }

            sAPGlobalInputPasswordIntoSAPElementpropCount++;
            sAPGlobalInputPasswordIntoSAPElement["Workflow"] = ExpressionConverter.ConvertO(sAPGlobalInputPasswordIntoSAPElementWorkflow);
            if (sAPGlobalInputPasswordIntoSAPElementpropCount > 0)
            {
                callPayload.Body = sAPGlobalInputPasswordIntoSAPElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPSetListSelectionByName(Expression<Func<string>> sAPSetListSelectionByNameSearchSAPElementId, Expression<Func<string>> sAPSetListSelectionByNameListItemName, Expression<Func<string>> sAPSetListSelectionByNameWorkflow)
        {
            var apiCallPath = "/SAPGUI/SAPSetListSelectionByName";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPSetListSelectionByName = new JObject();
            var sAPSetListSelectionByNamepropCount = 0;
            sAPSetListSelectionByNamepropCount++;
            sAPSetListSelectionByName["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPSetListSelectionByNameSearchSAPElementId);
            sAPSetListSelectionByNamepropCount++;
            sAPSetListSelectionByName["ListItemName"] = ExpressionConverter.ConvertO(sAPSetListSelectionByNameListItemName);
            sAPSetListSelectionByNamepropCount++;
            sAPSetListSelectionByName["Workflow"] = ExpressionConverter.ConvertO(sAPSetListSelectionByNameWorkflow);
            if (sAPSetListSelectionByNamepropCount > 0)
            {
                callPayload.Body = sAPSetListSelectionByName;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPSetListSelectionByKey(Expression<Func<string>> sAPSetListSelectionByKeySearchSAPElementId, Expression<Func<string>> sAPSetListSelectionByKeyListItemKey, Expression<Func<string>> sAPSetListSelectionByKeyWorkflow)
        {
            var apiCallPath = "/SAPGUI/SAPSetListSelectionByKey";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPSetListSelectionByKey = new JObject();
            var sAPSetListSelectionByKeypropCount = 0;
            sAPSetListSelectionByKeypropCount++;
            sAPSetListSelectionByKey["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPSetListSelectionByKeySearchSAPElementId);
            sAPSetListSelectionByKeypropCount++;
            sAPSetListSelectionByKey["ListItemKey"] = ExpressionConverter.ConvertO(sAPSetListSelectionByKeyListItemKey);
            sAPSetListSelectionByKeypropCount++;
            sAPSetListSelectionByKey["Workflow"] = ExpressionConverter.ConvertO(sAPSetListSelectionByKeyWorkflow);
            if (sAPSetListSelectionByKeypropCount > 0)
            {
                callPayload.Body = sAPSetListSelectionByKey;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetListSelectionElementItemsResponse> SAPGetListSelectionElementItems(Expression<Func<string>> sAPGetListSelectionElementItemsSearchSAPElementId, Expression<Func<string>> sAPGetListSelectionElementItemsWorkflow)
        {
            var apiCallPath = "/SAPGUI/SAPGetListSelectionElementItems";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPGetListSelectionElementItems = new JObject();
            var sAPGetListSelectionElementItemspropCount = 0;
            sAPGetListSelectionElementItemspropCount++;
            sAPGetListSelectionElementItems["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGetListSelectionElementItemsSearchSAPElementId);
            sAPGetListSelectionElementItemspropCount++;
            sAPGetListSelectionElementItems["Workflow"] = ExpressionConverter.ConvertO(sAPGetListSelectionElementItemsWorkflow);
            if (sAPGetListSelectionElementItemspropCount > 0)
            {
                callPayload.Body = sAPGetListSelectionElementItems;
            }

            return new ApiConnectionAction<SAPGetListSelectionElementItemsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetAllChildSAPElementPropertiesResponse> SAPGetAllChildSAPElementProperties(Expression<Func<string>> sAPGetAllChildSAPElementPropertiesSearchSAPElementId, Expression<Func<string>> sAPGetAllChildSAPElementPropertiesWorkflow, Expression<Func<int>> sAPGetAllChildSAPElementPropertiesFirstItemToReturn = null, Expression<Func<int>> sAPGetAllChildSAPElementPropertiesMaxItemsToReturn = null, Expression<Func<string>> sAPGetAllChildSAPElementPropertiesSearchSAPElementType = null, Expression<Func<int>> sAPGetAllChildSAPElementPropertiesMaxTextLength = null)
        {
            var apiCallPath = "/SAPGUI/SAPGetAllChildSAPElementProperties";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPGetAllChildSAPElementProperties = new JObject();
            var sAPGetAllChildSAPElementPropertiespropCount = 0;
            sAPGetAllChildSAPElementPropertiespropCount++;
            sAPGetAllChildSAPElementProperties["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGetAllChildSAPElementPropertiesSearchSAPElementId);
            if (sAPGetAllChildSAPElementPropertiesFirstItemToReturn != null)
            {
                sAPGetAllChildSAPElementProperties["FirstItemToReturn"] = ExpressionConverter.ConvertO(sAPGetAllChildSAPElementPropertiesFirstItemToReturn);
                sAPGetAllChildSAPElementPropertiespropCount++;
            }

            if (sAPGetAllChildSAPElementPropertiesMaxItemsToReturn != null)
            {
                sAPGetAllChildSAPElementProperties["MaxItemsToReturn"] = ExpressionConverter.ConvertO(sAPGetAllChildSAPElementPropertiesMaxItemsToReturn);
                sAPGetAllChildSAPElementPropertiespropCount++;
            }

            if (sAPGetAllChildSAPElementPropertiesSearchSAPElementType != null)
            {
                sAPGetAllChildSAPElementProperties["SearchSAPElementType"] = ExpressionConverter.ConvertO(sAPGetAllChildSAPElementPropertiesSearchSAPElementType);
                sAPGetAllChildSAPElementPropertiespropCount++;
            }

            if (sAPGetAllChildSAPElementPropertiesMaxTextLength != null)
            {
                sAPGetAllChildSAPElementProperties["MaxTextLength"] = ExpressionConverter.ConvertO(sAPGetAllChildSAPElementPropertiesMaxTextLength);
                sAPGetAllChildSAPElementPropertiespropCount++;
            }

            sAPGetAllChildSAPElementPropertiespropCount++;
            sAPGetAllChildSAPElementProperties["Workflow"] = ExpressionConverter.ConvertO(sAPGetAllChildSAPElementPropertiesWorkflow);
            if (sAPGetAllChildSAPElementPropertiespropCount > 0)
            {
                callPayload.Body = sAPGetAllChildSAPElementProperties;
            }

            return new ApiConnectionAction<SAPGetAllChildSAPElementPropertiesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetSAPSessionTopLevelSAPElementPropertiesResponse> SAPGetSAPSessionTopLevelSAPElementProperties(Expression<Func<string>> sAPGetSAPSessionTopLevelSAPElementPropertiesWorkflow, Expression<Func<int>> sAPGetSAPSessionTopLevelSAPElementPropertiesFirstItemToReturn = null, Expression<Func<int>> sAPGetSAPSessionTopLevelSAPElementPropertiesMaxItemsToReturn = null, Expression<Func<string>> sAPGetSAPSessionTopLevelSAPElementPropertiesSearchSAPElementType = null, Expression<Func<int>> sAPGetSAPSessionTopLevelSAPElementPropertiesMaxTextLength = null)
        {
            var apiCallPath = "/SAPGUI/SAPGetSAPSessionTopLevelSAPElementProperties";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPGetSAPSessionTopLevelSAPElementProperties = new JObject();
            var sAPGetSAPSessionTopLevelSAPElementPropertiespropCount = 0;
            if (sAPGetSAPSessionTopLevelSAPElementPropertiesFirstItemToReturn != null)
            {
                sAPGetSAPSessionTopLevelSAPElementProperties["FirstItemToReturn"] = ExpressionConverter.ConvertO(sAPGetSAPSessionTopLevelSAPElementPropertiesFirstItemToReturn);
                sAPGetSAPSessionTopLevelSAPElementPropertiespropCount++;
            }

            if (sAPGetSAPSessionTopLevelSAPElementPropertiesMaxItemsToReturn != null)
            {
                sAPGetSAPSessionTopLevelSAPElementProperties["MaxItemsToReturn"] = ExpressionConverter.ConvertO(sAPGetSAPSessionTopLevelSAPElementPropertiesMaxItemsToReturn);
                sAPGetSAPSessionTopLevelSAPElementPropertiespropCount++;
            }

            if (sAPGetSAPSessionTopLevelSAPElementPropertiesSearchSAPElementType != null)
            {
                sAPGetSAPSessionTopLevelSAPElementProperties["SearchSAPElementType"] = ExpressionConverter.ConvertO(sAPGetSAPSessionTopLevelSAPElementPropertiesSearchSAPElementType);
                sAPGetSAPSessionTopLevelSAPElementPropertiespropCount++;
            }

            if (sAPGetSAPSessionTopLevelSAPElementPropertiesMaxTextLength != null)
            {
                sAPGetSAPSessionTopLevelSAPElementProperties["MaxTextLength"] = ExpressionConverter.ConvertO(sAPGetSAPSessionTopLevelSAPElementPropertiesMaxTextLength);
                sAPGetSAPSessionTopLevelSAPElementPropertiespropCount++;
            }

            sAPGetSAPSessionTopLevelSAPElementPropertiespropCount++;
            sAPGetSAPSessionTopLevelSAPElementProperties["Workflow"] = ExpressionConverter.ConvertO(sAPGetSAPSessionTopLevelSAPElementPropertiesWorkflow);
            if (sAPGetSAPSessionTopLevelSAPElementPropertiespropCount > 0)
            {
                callPayload.Body = sAPGetSAPSessionTopLevelSAPElementProperties;
            }

            return new ApiConnectionAction<SAPGetSAPSessionTopLevelSAPElementPropertiesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetSAPElementParentIdResponse> SAPGetSAPElementParentId(Expression<Func<string>> sAPGetSAPElementParentIdSearchSAPElementId, Expression<Func<string>> sAPGetSAPElementParentIdWorkflow)
        {
            var apiCallPath = "/SAPGUI/SAPGetSAPElementParentId";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPGetSAPElementParentId = new JObject();
            var sAPGetSAPElementParentIdpropCount = 0;
            sAPGetSAPElementParentIdpropCount++;
            sAPGetSAPElementParentId["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGetSAPElementParentIdSearchSAPElementId);
            sAPGetSAPElementParentIdpropCount++;
            sAPGetSAPElementParentId["Workflow"] = ExpressionConverter.ConvertO(sAPGetSAPElementParentIdWorkflow);
            if (sAPGetSAPElementParentIdpropCount > 0)
            {
                callPayload.Body = sAPGetSAPElementParentId;
            }

            return new ApiConnectionAction<SAPGetSAPElementParentIdResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetElementPropertiesAsListResponse> SAPGetElementPropertiesAsList(Expression<Func<string>> sAPGetElementPropertiesAsListSearchSAPElementId, Expression<Func<string>> sAPGetElementPropertiesAsListWorkflow, Expression<Func<int>> sAPGetElementPropertiesAsListMaxTextLength = null)
        {
            var apiCallPath = "/SAPGUI/SAPGetElementPropertiesAsList";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPGetElementPropertiesAsList = new JObject();
            var sAPGetElementPropertiesAsListpropCount = 0;
            sAPGetElementPropertiesAsListpropCount++;
            sAPGetElementPropertiesAsList["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGetElementPropertiesAsListSearchSAPElementId);
            if (sAPGetElementPropertiesAsListMaxTextLength != null)
            {
                sAPGetElementPropertiesAsList["MaxTextLength"] = ExpressionConverter.ConvertO(sAPGetElementPropertiesAsListMaxTextLength);
                sAPGetElementPropertiesAsListpropCount++;
            }

            sAPGetElementPropertiesAsListpropCount++;
            sAPGetElementPropertiesAsList["Workflow"] = ExpressionConverter.ConvertO(sAPGetElementPropertiesAsListWorkflow);
            if (sAPGetElementPropertiesAsListpropCount > 0)
            {
                callPayload.Body = sAPGetElementPropertiesAsList;
            }

            return new ApiConnectionAction<SAPGetElementPropertiesAsListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetSAPElementAtScreenCoordinateResponse> SAPGetSAPElementAtScreenCoordinate(Expression<Func<int>> sAPGetSAPElementAtScreenCoordinateScreenX, Expression<Func<int>> sAPGetSAPElementAtScreenCoordinateScreenY, Expression<Func<string>> sAPGetSAPElementAtScreenCoordinateWorkflow)
        {
            var apiCallPath = "/SAPGUI/SAPGetSAPElementAtScreenCoordinate";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPGetSAPElementAtScreenCoordinate = new JObject();
            var sAPGetSAPElementAtScreenCoordinatepropCount = 0;
            sAPGetSAPElementAtScreenCoordinatepropCount++;
            sAPGetSAPElementAtScreenCoordinate["ScreenX"] = ExpressionConverter.ConvertO(sAPGetSAPElementAtScreenCoordinateScreenX);
            sAPGetSAPElementAtScreenCoordinatepropCount++;
            sAPGetSAPElementAtScreenCoordinate["ScreenY"] = ExpressionConverter.ConvertO(sAPGetSAPElementAtScreenCoordinateScreenY);
            sAPGetSAPElementAtScreenCoordinatepropCount++;
            sAPGetSAPElementAtScreenCoordinate["Workflow"] = ExpressionConverter.ConvertO(sAPGetSAPElementAtScreenCoordinateWorkflow);
            if (sAPGetSAPElementAtScreenCoordinatepropCount > 0)
            {
                callPayload.Body = sAPGetSAPElementAtScreenCoordinate;
            }

            return new ApiConnectionAction<SAPGetSAPElementAtScreenCoordinateResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPOpenConnectionResponse> SAPOpenConnection(Expression<Func<string>> sAPOpenConnectionWorkflow, Expression<Func<string>> sAPOpenConnectionSAPConnectionDescription = null, Expression<Func<string>> sAPOpenConnectionSAPConnectionAddress = null, Expression<Func<bool>> sAPOpenConnectionConnectSynchronous = null, Expression<Func<bool>> sAPOpenConnectionConnectToSession = null)
        {
            var apiCallPath = "/SAPGUI/SAPOpenConnection";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPOpenConnection = new JObject();
            var sAPOpenConnectionpropCount = 0;
            if (sAPOpenConnectionSAPConnectionDescription != null)
            {
                sAPOpenConnection["SAPConnectionDescription"] = ExpressionConverter.ConvertO(sAPOpenConnectionSAPConnectionDescription);
                sAPOpenConnectionpropCount++;
            }

            if (sAPOpenConnectionSAPConnectionAddress != null)
            {
                sAPOpenConnection["SAPConnectionAddress"] = ExpressionConverter.ConvertO(sAPOpenConnectionSAPConnectionAddress);
                sAPOpenConnectionpropCount++;
            }

            if (sAPOpenConnectionConnectSynchronous != null)
            {
                sAPOpenConnection["ConnectSynchronous"] = ExpressionConverter.ConvertO(sAPOpenConnectionConnectSynchronous);
                sAPOpenConnectionpropCount++;
            }

            if (sAPOpenConnectionConnectToSession != null)
            {
                sAPOpenConnection["ConnectToSession"] = ExpressionConverter.ConvertO(sAPOpenConnectionConnectToSession);
                sAPOpenConnectionpropCount++;
            }

            sAPOpenConnectionpropCount++;
            sAPOpenConnection["Workflow"] = ExpressionConverter.ConvertO(sAPOpenConnectionWorkflow);
            if (sAPOpenConnectionpropCount > 0)
            {
                callPayload.Body = sAPOpenConnection;
            }

            return new ApiConnectionAction<SAPOpenConnectionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetSAPTablePropertiesResponse> SAPGetSAPTableProperties(Expression<Func<string>> sAPGetSAPTablePropertiesSearchSAPElementId, Expression<Func<string>> sAPGetSAPTablePropertiesWorkflow)
        {
            var apiCallPath = "/SAPGUI/SAPGetSAPTableProperties";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPGetSAPTableProperties = new JObject();
            var sAPGetSAPTablePropertiespropCount = 0;
            sAPGetSAPTablePropertiespropCount++;
            sAPGetSAPTableProperties["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGetSAPTablePropertiesSearchSAPElementId);
            sAPGetSAPTablePropertiespropCount++;
            sAPGetSAPTableProperties["Workflow"] = ExpressionConverter.ConvertO(sAPGetSAPTablePropertiesWorkflow);
            if (sAPGetSAPTablePropertiespropCount > 0)
            {
                callPayload.Body = sAPGetSAPTableProperties;
            }

            return new ApiConnectionAction<SAPGetSAPTablePropertiesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetSAPTableVisibleCellTextContentsAtIndexResponse> SAPGetSAPTableVisibleCellTextContentsAtIndex(Expression<Func<string>> sAPGetSAPTableVisibleCellTextContentsAtIndexSearchSAPElementId, Expression<Func<string>> sAPGetSAPTableVisibleCellTextContentsAtIndexWorkflow, Expression<Func<int>> sAPGetSAPTableVisibleCellTextContentsAtIndexVisibleRowIndex = null, Expression<Func<int>> sAPGetSAPTableVisibleCellTextContentsAtIndexVisibleColumnIndex = null, Expression<Func<string>> sAPGetSAPTableVisibleCellTextContentsAtIndexCheckedElementValue = null)
        {
            var apiCallPath = "/SAPGUI/SAPGetSAPTableVisibleCellTextContentsAtIndex";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPGetSAPTableVisibleCellTextContentsAtIndex = new JObject();
            var sAPGetSAPTableVisibleCellTextContentsAtIndexpropCount = 0;
            sAPGetSAPTableVisibleCellTextContentsAtIndexpropCount++;
            sAPGetSAPTableVisibleCellTextContentsAtIndex["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGetSAPTableVisibleCellTextContentsAtIndexSearchSAPElementId);
            if (sAPGetSAPTableVisibleCellTextContentsAtIndexVisibleRowIndex != null)
            {
                sAPGetSAPTableVisibleCellTextContentsAtIndex["VisibleRowIndex"] = ExpressionConverter.ConvertO(sAPGetSAPTableVisibleCellTextContentsAtIndexVisibleRowIndex);
                sAPGetSAPTableVisibleCellTextContentsAtIndexpropCount++;
            }

            if (sAPGetSAPTableVisibleCellTextContentsAtIndexVisibleColumnIndex != null)
            {
                sAPGetSAPTableVisibleCellTextContentsAtIndex["VisibleColumnIndex"] = ExpressionConverter.ConvertO(sAPGetSAPTableVisibleCellTextContentsAtIndexVisibleColumnIndex);
                sAPGetSAPTableVisibleCellTextContentsAtIndexpropCount++;
            }

            if (sAPGetSAPTableVisibleCellTextContentsAtIndexCheckedElementValue != null)
            {
                sAPGetSAPTableVisibleCellTextContentsAtIndex["CheckedElementValue"] = ExpressionConverter.ConvertO(sAPGetSAPTableVisibleCellTextContentsAtIndexCheckedElementValue);
                sAPGetSAPTableVisibleCellTextContentsAtIndexpropCount++;
            }

            sAPGetSAPTableVisibleCellTextContentsAtIndexpropCount++;
            sAPGetSAPTableVisibleCellTextContentsAtIndex["Workflow"] = ExpressionConverter.ConvertO(sAPGetSAPTableVisibleCellTextContentsAtIndexWorkflow);
            if (sAPGetSAPTableVisibleCellTextContentsAtIndexpropCount > 0)
            {
                callPayload.Body = sAPGetSAPTableVisibleCellTextContentsAtIndex;
            }

            return new ApiConnectionAction<SAPGetSAPTableVisibleCellTextContentsAtIndexResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetSAPTableVisibleCellPropertiesAtIndexResponse> SAPGetSAPTableVisibleCellPropertiesAtIndex(Expression<Func<string>> sAPGetSAPTableVisibleCellPropertiesAtIndexSearchSAPElementId, Expression<Func<string>> sAPGetSAPTableVisibleCellPropertiesAtIndexWorkflow, Expression<Func<int>> sAPGetSAPTableVisibleCellPropertiesAtIndexVisibleRowIndex = null, Expression<Func<int>> sAPGetSAPTableVisibleCellPropertiesAtIndexVisibleColumnIndex = null)
        {
            var apiCallPath = "/SAPGUI/SAPGetSAPTableVisibleCellPropertiesAtIndex";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPGetSAPTableVisibleCellPropertiesAtIndex = new JObject();
            var sAPGetSAPTableVisibleCellPropertiesAtIndexpropCount = 0;
            sAPGetSAPTableVisibleCellPropertiesAtIndexpropCount++;
            sAPGetSAPTableVisibleCellPropertiesAtIndex["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGetSAPTableVisibleCellPropertiesAtIndexSearchSAPElementId);
            if (sAPGetSAPTableVisibleCellPropertiesAtIndexVisibleRowIndex != null)
            {
                sAPGetSAPTableVisibleCellPropertiesAtIndex["VisibleRowIndex"] = ExpressionConverter.ConvertO(sAPGetSAPTableVisibleCellPropertiesAtIndexVisibleRowIndex);
                sAPGetSAPTableVisibleCellPropertiesAtIndexpropCount++;
            }

            if (sAPGetSAPTableVisibleCellPropertiesAtIndexVisibleColumnIndex != null)
            {
                sAPGetSAPTableVisibleCellPropertiesAtIndex["VisibleColumnIndex"] = ExpressionConverter.ConvertO(sAPGetSAPTableVisibleCellPropertiesAtIndexVisibleColumnIndex);
                sAPGetSAPTableVisibleCellPropertiesAtIndexpropCount++;
            }

            sAPGetSAPTableVisibleCellPropertiesAtIndexpropCount++;
            sAPGetSAPTableVisibleCellPropertiesAtIndex["Workflow"] = ExpressionConverter.ConvertO(sAPGetSAPTableVisibleCellPropertiesAtIndexWorkflow);
            if (sAPGetSAPTableVisibleCellPropertiesAtIndexpropCount > 0)
            {
                callPayload.Body = sAPGetSAPTableVisibleCellPropertiesAtIndex;
            }

            return new ApiConnectionAction<SAPGetSAPTableVisibleCellPropertiesAtIndexResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPSetSAPTableVisibleCellTextContentsAtIndex(Expression<Func<string>> sAPSetSAPTableVisibleCellTextContentsAtIndexSearchSAPElementId, Expression<Func<string>> sAPSetSAPTableVisibleCellTextContentsAtIndexWorkflow, Expression<Func<int>> sAPSetSAPTableVisibleCellTextContentsAtIndexVisibleRowIndex = null, Expression<Func<int>> sAPSetSAPTableVisibleCellTextContentsAtIndexVisibleColumnIndex = null, Expression<Func<string>> sAPSetSAPTableVisibleCellTextContentsAtIndexTextToInput = null, Expression<Func<bool>> sAPSetSAPTableVisibleCellTextContentsAtIndexReplaceExistingValue = null, Expression<Func<int>> sAPSetSAPTableVisibleCellTextContentsAtIndexInsertPosition = null)
        {
            var apiCallPath = "/SAPGUI/SAPSetSAPTableVisibleCellTextContentsAtIndex";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPSetSAPTableVisibleCellTextContentsAtIndex = new JObject();
            var sAPSetSAPTableVisibleCellTextContentsAtIndexpropCount = 0;
            sAPSetSAPTableVisibleCellTextContentsAtIndexpropCount++;
            sAPSetSAPTableVisibleCellTextContentsAtIndex["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPSetSAPTableVisibleCellTextContentsAtIndexSearchSAPElementId);
            if (sAPSetSAPTableVisibleCellTextContentsAtIndexVisibleRowIndex != null)
            {
                sAPSetSAPTableVisibleCellTextContentsAtIndex["VisibleRowIndex"] = ExpressionConverter.ConvertO(sAPSetSAPTableVisibleCellTextContentsAtIndexVisibleRowIndex);
                sAPSetSAPTableVisibleCellTextContentsAtIndexpropCount++;
            }

            if (sAPSetSAPTableVisibleCellTextContentsAtIndexVisibleColumnIndex != null)
            {
                sAPSetSAPTableVisibleCellTextContentsAtIndex["VisibleColumnIndex"] = ExpressionConverter.ConvertO(sAPSetSAPTableVisibleCellTextContentsAtIndexVisibleColumnIndex);
                sAPSetSAPTableVisibleCellTextContentsAtIndexpropCount++;
            }

            if (sAPSetSAPTableVisibleCellTextContentsAtIndexTextToInput != null)
            {
                sAPSetSAPTableVisibleCellTextContentsAtIndex["TextToInput"] = ExpressionConverter.ConvertO(sAPSetSAPTableVisibleCellTextContentsAtIndexTextToInput);
                sAPSetSAPTableVisibleCellTextContentsAtIndexpropCount++;
            }

            if (sAPSetSAPTableVisibleCellTextContentsAtIndexReplaceExistingValue != null)
            {
                sAPSetSAPTableVisibleCellTextContentsAtIndex["ReplaceExistingValue"] = ExpressionConverter.ConvertO(sAPSetSAPTableVisibleCellTextContentsAtIndexReplaceExistingValue);
                sAPSetSAPTableVisibleCellTextContentsAtIndexpropCount++;
            }

            if (sAPSetSAPTableVisibleCellTextContentsAtIndexInsertPosition != null)
            {
                sAPSetSAPTableVisibleCellTextContentsAtIndex["InsertPosition"] = ExpressionConverter.ConvertO(sAPSetSAPTableVisibleCellTextContentsAtIndexInsertPosition);
                sAPSetSAPTableVisibleCellTextContentsAtIndexpropCount++;
            }

            sAPSetSAPTableVisibleCellTextContentsAtIndexpropCount++;
            sAPSetSAPTableVisibleCellTextContentsAtIndex["Workflow"] = ExpressionConverter.ConvertO(sAPSetSAPTableVisibleCellTextContentsAtIndexWorkflow);
            if (sAPSetSAPTableVisibleCellTextContentsAtIndexpropCount > 0)
            {
                callPayload.Body = sAPSetSAPTableVisibleCellTextContentsAtIndex;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPCheckSAPTableVisibleCellCheckboxAtIndex(Expression<Func<string>> sAPCheckSAPTableVisibleCellCheckboxAtIndexSearchSAPElementId, Expression<Func<string>> sAPCheckSAPTableVisibleCellCheckboxAtIndexWorkflow, Expression<Func<int>> sAPCheckSAPTableVisibleCellCheckboxAtIndexVisibleRowIndex = null, Expression<Func<int>> sAPCheckSAPTableVisibleCellCheckboxAtIndexVisibleColumnIndex = null, Expression<Func<bool>> sAPCheckSAPTableVisibleCellCheckboxAtIndexCheckCellElement = null)
        {
            var apiCallPath = "/SAPGUI/SAPCheckSAPTableVisibleCellCheckboxAtIndex";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPCheckSAPTableVisibleCellCheckboxAtIndex = new JObject();
            var sAPCheckSAPTableVisibleCellCheckboxAtIndexpropCount = 0;
            sAPCheckSAPTableVisibleCellCheckboxAtIndexpropCount++;
            sAPCheckSAPTableVisibleCellCheckboxAtIndex["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPCheckSAPTableVisibleCellCheckboxAtIndexSearchSAPElementId);
            if (sAPCheckSAPTableVisibleCellCheckboxAtIndexVisibleRowIndex != null)
            {
                sAPCheckSAPTableVisibleCellCheckboxAtIndex["VisibleRowIndex"] = ExpressionConverter.ConvertO(sAPCheckSAPTableVisibleCellCheckboxAtIndexVisibleRowIndex);
                sAPCheckSAPTableVisibleCellCheckboxAtIndexpropCount++;
            }

            if (sAPCheckSAPTableVisibleCellCheckboxAtIndexVisibleColumnIndex != null)
            {
                sAPCheckSAPTableVisibleCellCheckboxAtIndex["VisibleColumnIndex"] = ExpressionConverter.ConvertO(sAPCheckSAPTableVisibleCellCheckboxAtIndexVisibleColumnIndex);
                sAPCheckSAPTableVisibleCellCheckboxAtIndexpropCount++;
            }

            if (sAPCheckSAPTableVisibleCellCheckboxAtIndexCheckCellElement != null)
            {
                sAPCheckSAPTableVisibleCellCheckboxAtIndex["CheckCellElement"] = ExpressionConverter.ConvertO(sAPCheckSAPTableVisibleCellCheckboxAtIndexCheckCellElement);
                sAPCheckSAPTableVisibleCellCheckboxAtIndexpropCount++;
            }

            sAPCheckSAPTableVisibleCellCheckboxAtIndexpropCount++;
            sAPCheckSAPTableVisibleCellCheckboxAtIndex["Workflow"] = ExpressionConverter.ConvertO(sAPCheckSAPTableVisibleCellCheckboxAtIndexWorkflow);
            if (sAPCheckSAPTableVisibleCellCheckboxAtIndexpropCount > 0)
            {
                callPayload.Body = sAPCheckSAPTableVisibleCellCheckboxAtIndex;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPPressSAPTableVisibleCellAtIndex(Expression<Func<string>> sAPPressSAPTableVisibleCellAtIndexSearchSAPElementId, Expression<Func<string>> sAPPressSAPTableVisibleCellAtIndexWorkflow, Expression<Func<int>> sAPPressSAPTableVisibleCellAtIndexVisibleRowIndex = null, Expression<Func<int>> sAPPressSAPTableVisibleCellAtIndexVisibleColumnIndex = null)
        {
            var apiCallPath = "/SAPGUI/SAPPressSAPTableVisibleCellAtIndex";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPPressSAPTableVisibleCellAtIndex = new JObject();
            var sAPPressSAPTableVisibleCellAtIndexpropCount = 0;
            sAPPressSAPTableVisibleCellAtIndexpropCount++;
            sAPPressSAPTableVisibleCellAtIndex["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPPressSAPTableVisibleCellAtIndexSearchSAPElementId);
            if (sAPPressSAPTableVisibleCellAtIndexVisibleRowIndex != null)
            {
                sAPPressSAPTableVisibleCellAtIndex["VisibleRowIndex"] = ExpressionConverter.ConvertO(sAPPressSAPTableVisibleCellAtIndexVisibleRowIndex);
                sAPPressSAPTableVisibleCellAtIndexpropCount++;
            }

            if (sAPPressSAPTableVisibleCellAtIndexVisibleColumnIndex != null)
            {
                sAPPressSAPTableVisibleCellAtIndex["VisibleColumnIndex"] = ExpressionConverter.ConvertO(sAPPressSAPTableVisibleCellAtIndexVisibleColumnIndex);
                sAPPressSAPTableVisibleCellAtIndexpropCount++;
            }

            sAPPressSAPTableVisibleCellAtIndexpropCount++;
            sAPPressSAPTableVisibleCellAtIndex["Workflow"] = ExpressionConverter.ConvertO(sAPPressSAPTableVisibleCellAtIndexWorkflow);
            if (sAPPressSAPTableVisibleCellAtIndexpropCount > 0)
            {
                callPayload.Body = sAPPressSAPTableVisibleCellAtIndex;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPScrollSAPTable(Expression<Func<string>> sAPScrollSAPTableSearchSAPElementId, Expression<Func<string>> sAPScrollSAPTableWorkflow, Expression<Func<bool>> sAPScrollSAPTableMoveHorizontalScrollbar = null, Expression<Func<int>> sAPScrollSAPTableHorizontalScrollbarPosition = null, Expression<Func<bool>> sAPScrollSAPTableMoveVerticalScrollbar = null, Expression<Func<int>> sAPScrollSAPTableVerticalScrollbarPosition = null)
        {
            var apiCallPath = "/SAPGUI/SAPScrollSAPTable";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPScrollSAPTable = new JObject();
            var sAPScrollSAPTablepropCount = 0;
            sAPScrollSAPTablepropCount++;
            sAPScrollSAPTable["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPScrollSAPTableSearchSAPElementId);
            if (sAPScrollSAPTableMoveHorizontalScrollbar != null)
            {
                sAPScrollSAPTable["MoveHorizontalScrollbar"] = ExpressionConverter.ConvertO(sAPScrollSAPTableMoveHorizontalScrollbar);
                sAPScrollSAPTablepropCount++;
            }

            if (sAPScrollSAPTableHorizontalScrollbarPosition != null)
            {
                sAPScrollSAPTable["HorizontalScrollbarPosition"] = ExpressionConverter.ConvertO(sAPScrollSAPTableHorizontalScrollbarPosition);
                sAPScrollSAPTablepropCount++;
            }

            if (sAPScrollSAPTableMoveVerticalScrollbar != null)
            {
                sAPScrollSAPTable["MoveVerticalScrollbar"] = ExpressionConverter.ConvertO(sAPScrollSAPTableMoveVerticalScrollbar);
                sAPScrollSAPTablepropCount++;
            }

            if (sAPScrollSAPTableVerticalScrollbarPosition != null)
            {
                sAPScrollSAPTable["VerticalScrollbarPosition"] = ExpressionConverter.ConvertO(sAPScrollSAPTableVerticalScrollbarPosition);
                sAPScrollSAPTablepropCount++;
            }

            sAPScrollSAPTablepropCount++;
            sAPScrollSAPTable["Workflow"] = ExpressionConverter.ConvertO(sAPScrollSAPTableWorkflow);
            if (sAPScrollSAPTablepropCount > 0)
            {
                callPayload.Body = sAPScrollSAPTable;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetTableVisibleTextContentsResponse> SAPGetTableVisibleTextContents(Expression<Func<string>> sAPGetTableVisibleTextContentsSearchSAPElementId, Expression<Func<string>> sAPGetTableVisibleTextContentsWorkflow, Expression<Func<int>> sAPGetTableVisibleTextContentsFirstVisibleRowToReturn = null, Expression<Func<int>> sAPGetTableVisibleTextContentsMaxRowsToReturn = null, Expression<Func<int>> sAPGetTableVisibleTextContentsFirstVisibleColumnToReturn = null, Expression<Func<int>> sAPGetTableVisibleTextContentsMaxColumnsToReturn = null, Expression<Func<bool>> sAPGetTableVisibleTextContentsUseColumnHeadersFromTable = null, Expression<Func<bool>> sAPGetTableVisibleTextContentsReturnRowIndexInOutputCollection = null, Expression<Func<string>> sAPGetTableVisibleTextContentsNameOfColumnToStoreRowIndex = null, Expression<Func<string>> sAPGetTableVisibleTextContentsCheckedElementValue = null)
        {
            var apiCallPath = "/SAPGUI/SAPGetTableVisibleTextContents";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPGetTableVisibleTextContents = new JObject();
            var sAPGetTableVisibleTextContentspropCount = 0;
            sAPGetTableVisibleTextContentspropCount++;
            sAPGetTableVisibleTextContents["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGetTableVisibleTextContentsSearchSAPElementId);
            if (sAPGetTableVisibleTextContentsFirstVisibleRowToReturn != null)
            {
                sAPGetTableVisibleTextContents["FirstVisibleRowToReturn"] = ExpressionConverter.ConvertO(sAPGetTableVisibleTextContentsFirstVisibleRowToReturn);
                sAPGetTableVisibleTextContentspropCount++;
            }

            if (sAPGetTableVisibleTextContentsMaxRowsToReturn != null)
            {
                sAPGetTableVisibleTextContents["MaxRowsToReturn"] = ExpressionConverter.ConvertO(sAPGetTableVisibleTextContentsMaxRowsToReturn);
                sAPGetTableVisibleTextContentspropCount++;
            }

            if (sAPGetTableVisibleTextContentsFirstVisibleColumnToReturn != null)
            {
                sAPGetTableVisibleTextContents["FirstVisibleColumnToReturn"] = ExpressionConverter.ConvertO(sAPGetTableVisibleTextContentsFirstVisibleColumnToReturn);
                sAPGetTableVisibleTextContentspropCount++;
            }

            if (sAPGetTableVisibleTextContentsMaxColumnsToReturn != null)
            {
                sAPGetTableVisibleTextContents["MaxColumnsToReturn"] = ExpressionConverter.ConvertO(sAPGetTableVisibleTextContentsMaxColumnsToReturn);
                sAPGetTableVisibleTextContentspropCount++;
            }

            if (sAPGetTableVisibleTextContentsUseColumnHeadersFromTable != null)
            {
                sAPGetTableVisibleTextContents["UseColumnHeadersFromTable"] = ExpressionConverter.ConvertO(sAPGetTableVisibleTextContentsUseColumnHeadersFromTable);
                sAPGetTableVisibleTextContentspropCount++;
            }

            if (sAPGetTableVisibleTextContentsReturnRowIndexInOutputCollection != null)
            {
                sAPGetTableVisibleTextContents["ReturnRowIndexInOutputCollection"] = ExpressionConverter.ConvertO(sAPGetTableVisibleTextContentsReturnRowIndexInOutputCollection);
                sAPGetTableVisibleTextContentspropCount++;
            }

            if (sAPGetTableVisibleTextContentsNameOfColumnToStoreRowIndex != null)
            {
                sAPGetTableVisibleTextContents["NameOfColumnToStoreRowIndex"] = ExpressionConverter.ConvertO(sAPGetTableVisibleTextContentsNameOfColumnToStoreRowIndex);
                sAPGetTableVisibleTextContentspropCount++;
            }

            if (sAPGetTableVisibleTextContentsCheckedElementValue != null)
            {
                sAPGetTableVisibleTextContents["CheckedElementValue"] = ExpressionConverter.ConvertO(sAPGetTableVisibleTextContentsCheckedElementValue);
                sAPGetTableVisibleTextContentspropCount++;
            }

            sAPGetTableVisibleTextContentspropCount++;
            sAPGetTableVisibleTextContents["Workflow"] = ExpressionConverter.ConvertO(sAPGetTableVisibleTextContentsWorkflow);
            if (sAPGetTableVisibleTextContentspropCount > 0)
            {
                callPayload.Body = sAPGetTableVisibleTextContents;
            }

            return new ApiConnectionAction<SAPGetTableVisibleTextContentsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPSelectSAPTableRow(Expression<Func<string>> sAPSelectSAPTableRowSearchSAPElementId, Expression<Func<string>> sAPSelectSAPTableRowWorkflow, Expression<Func<int>> sAPSelectSAPTableRowVisibleRowIndex = null, Expression<Func<bool>> sAPSelectSAPTableRowSelect = null)
        {
            var apiCallPath = "/SAPGUI/SAPSelectSAPTableRow";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPSelectSAPTableRow = new JObject();
            var sAPSelectSAPTableRowpropCount = 0;
            sAPSelectSAPTableRowpropCount++;
            sAPSelectSAPTableRow["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPSelectSAPTableRowSearchSAPElementId);
            if (sAPSelectSAPTableRowVisibleRowIndex != null)
            {
                sAPSelectSAPTableRow["VisibleRowIndex"] = ExpressionConverter.ConvertO(sAPSelectSAPTableRowVisibleRowIndex);
                sAPSelectSAPTableRowpropCount++;
            }

            if (sAPSelectSAPTableRowSelect != null)
            {
                sAPSelectSAPTableRow["Select"] = ExpressionConverter.ConvertO(sAPSelectSAPTableRowSelect);
                sAPSelectSAPTableRowpropCount++;
            }

            sAPSelectSAPTableRowpropCount++;
            sAPSelectSAPTableRow["Workflow"] = ExpressionConverter.ConvertO(sAPSelectSAPTableRowWorkflow);
            if (sAPSelectSAPTableRowpropCount > 0)
            {
                callPayload.Body = sAPSelectSAPTableRow;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPSelectSAPTableColumn(Expression<Func<string>> sAPSelectSAPTableColumnSearchSAPElementId, Expression<Func<string>> sAPSelectSAPTableColumnWorkflow, Expression<Func<int>> sAPSelectSAPTableColumnVisibleColumnIndex = null, Expression<Func<bool>> sAPSelectSAPTableColumnSelect = null)
        {
            var apiCallPath = "/SAPGUI/SAPSelectSAPTableColumn";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPSelectSAPTableColumn = new JObject();
            var sAPSelectSAPTableColumnpropCount = 0;
            sAPSelectSAPTableColumnpropCount++;
            sAPSelectSAPTableColumn["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPSelectSAPTableColumnSearchSAPElementId);
            if (sAPSelectSAPTableColumnVisibleColumnIndex != null)
            {
                sAPSelectSAPTableColumn["VisibleColumnIndex"] = ExpressionConverter.ConvertO(sAPSelectSAPTableColumnVisibleColumnIndex);
                sAPSelectSAPTableColumnpropCount++;
            }

            if (sAPSelectSAPTableColumnSelect != null)
            {
                sAPSelectSAPTableColumn["Select"] = ExpressionConverter.ConvertO(sAPSelectSAPTableColumnSelect);
                sAPSelectSAPTableColumnpropCount++;
            }

            sAPSelectSAPTableColumnpropCount++;
            sAPSelectSAPTableColumn["Workflow"] = ExpressionConverter.ConvertO(sAPSelectSAPTableColumnWorkflow);
            if (sAPSelectSAPTableColumnpropCount > 0)
            {
                callPayload.Body = sAPSelectSAPTableColumn;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetTreeNodesResponse> SAPGetTreeNodes(Expression<Func<string>> sAPGetTreeNodesSearchSAPElementId, Expression<Func<string>> sAPGetTreeNodesWorkflow, Expression<Func<string>> sAPGetTreeNodesParentNodeKey = null, Expression<Func<bool>> sAPGetTreeNodesProcessSubNodes = null)
        {
            var apiCallPath = "/SAPGUI/SAPGetTreeNodes";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPGetTreeNodes = new JObject();
            var sAPGetTreeNodespropCount = 0;
            sAPGetTreeNodespropCount++;
            sAPGetTreeNodes["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGetTreeNodesSearchSAPElementId);
            if (sAPGetTreeNodesParentNodeKey != null)
            {
                sAPGetTreeNodes["ParentNodeKey"] = ExpressionConverter.ConvertO(sAPGetTreeNodesParentNodeKey);
                sAPGetTreeNodespropCount++;
            }

            if (sAPGetTreeNodesProcessSubNodes != null)
            {
                sAPGetTreeNodes["ProcessSubNodes"] = ExpressionConverter.ConvertO(sAPGetTreeNodesProcessSubNodes);
                sAPGetTreeNodespropCount++;
            }

            sAPGetTreeNodespropCount++;
            sAPGetTreeNodes["Workflow"] = ExpressionConverter.ConvertO(sAPGetTreeNodesWorkflow);
            if (sAPGetTreeNodespropCount > 0)
            {
                callPayload.Body = sAPGetTreeNodes;
            }

            return new ApiConnectionAction<SAPGetTreeNodesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPDoubleClickTreeItem(Expression<Func<string>> sAPDoubleClickTreeItemSearchSAPElementId, Expression<Func<string>> sAPDoubleClickTreeItemWorkflow, Expression<Func<string>> sAPDoubleClickTreeItemSearchNodeKey = null, Expression<Func<string>> sAPDoubleClickTreeItemSearchNodePath = null, Expression<Func<string>> sAPDoubleClickTreeItemSearchNodeText = null, Expression<Func<bool>> sAPDoubleClickTreeItemSearchNodeTextIsRegularExpression = null, Expression<Func<bool>> sAPDoubleClickTreeItemSearchNodeTextIsCaseSensitive = null, Expression<Func<string>> sAPDoubleClickTreeItemSearchColumnName = null, Expression<Func<string>> sAPDoubleClickTreeItemSearchColumnTitle = null, Expression<Func<bool>> sAPDoubleClickTreeItemSearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPDoubleClickTreeItemSearchColumnTitleIsCaseSensitive = null)
        {
            var apiCallPath = "/SAPGUI/SAPDoubleClickTreeItem";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPDoubleClickTreeItem = new JObject();
            var sAPDoubleClickTreeItempropCount = 0;
            sAPDoubleClickTreeItempropCount++;
            sAPDoubleClickTreeItem["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPDoubleClickTreeItemSearchSAPElementId);
            if (sAPDoubleClickTreeItemSearchNodeKey != null)
            {
                sAPDoubleClickTreeItem["SearchNodeKey"] = ExpressionConverter.ConvertO(sAPDoubleClickTreeItemSearchNodeKey);
                sAPDoubleClickTreeItempropCount++;
            }

            if (sAPDoubleClickTreeItemSearchNodePath != null)
            {
                sAPDoubleClickTreeItem["SearchNodePath"] = ExpressionConverter.ConvertO(sAPDoubleClickTreeItemSearchNodePath);
                sAPDoubleClickTreeItempropCount++;
            }

            if (sAPDoubleClickTreeItemSearchNodeText != null)
            {
                sAPDoubleClickTreeItem["SearchNodeText"] = ExpressionConverter.ConvertO(sAPDoubleClickTreeItemSearchNodeText);
                sAPDoubleClickTreeItempropCount++;
            }

            if (sAPDoubleClickTreeItemSearchNodeTextIsRegularExpression != null)
            {
                sAPDoubleClickTreeItem["SearchNodeTextIsRegularExpression"] = ExpressionConverter.ConvertO(sAPDoubleClickTreeItemSearchNodeTextIsRegularExpression);
                sAPDoubleClickTreeItempropCount++;
            }

            if (sAPDoubleClickTreeItemSearchNodeTextIsCaseSensitive != null)
            {
                sAPDoubleClickTreeItem["SearchNodeTextIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPDoubleClickTreeItemSearchNodeTextIsCaseSensitive);
                sAPDoubleClickTreeItempropCount++;
            }

            if (sAPDoubleClickTreeItemSearchColumnName != null)
            {
                sAPDoubleClickTreeItem["SearchColumnName"] = ExpressionConverter.ConvertO(sAPDoubleClickTreeItemSearchColumnName);
                sAPDoubleClickTreeItempropCount++;
            }

            if (sAPDoubleClickTreeItemSearchColumnTitle != null)
            {
                sAPDoubleClickTreeItem["SearchColumnTitle"] = ExpressionConverter.ConvertO(sAPDoubleClickTreeItemSearchColumnTitle);
                sAPDoubleClickTreeItempropCount++;
            }

            if (sAPDoubleClickTreeItemSearchColumnTitleIsRegularExpression != null)
            {
                sAPDoubleClickTreeItem["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(sAPDoubleClickTreeItemSearchColumnTitleIsRegularExpression);
                sAPDoubleClickTreeItempropCount++;
            }

            if (sAPDoubleClickTreeItemSearchColumnTitleIsCaseSensitive != null)
            {
                sAPDoubleClickTreeItem["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPDoubleClickTreeItemSearchColumnTitleIsCaseSensitive);
                sAPDoubleClickTreeItempropCount++;
            }

            sAPDoubleClickTreeItempropCount++;
            sAPDoubleClickTreeItem["Workflow"] = ExpressionConverter.ConvertO(sAPDoubleClickTreeItemWorkflow);
            if (sAPDoubleClickTreeItempropCount > 0)
            {
                callPayload.Body = sAPDoubleClickTreeItem;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPSelectTreeItem(Expression<Func<string>> sAPSelectTreeItemSearchSAPElementId, Expression<Func<string>> sAPSelectTreeItemWorkflow, Expression<Func<string>> sAPSelectTreeItemSearchNodeKey = null, Expression<Func<string>> sAPSelectTreeItemSearchNodePath = null, Expression<Func<string>> sAPSelectTreeItemSearchNodeText = null, Expression<Func<bool>> sAPSelectTreeItemSearchNodeTextIsRegularExpression = null, Expression<Func<bool>> sAPSelectTreeItemSearchNodeTextIsCaseSensitive = null, Expression<Func<string>> sAPSelectTreeItemSearchColumnName = null, Expression<Func<string>> sAPSelectTreeItemSearchColumnTitle = null, Expression<Func<bool>> sAPSelectTreeItemSearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPSelectTreeItemSearchColumnTitleIsCaseSensitive = null, Expression<Func<bool>> sAPSelectTreeItemSelect = null, Expression<Func<bool>> sAPSelectTreeItemDeselectAllFirst = null)
        {
            var apiCallPath = "/SAPGUI/SAPSelectTreeItem";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPSelectTreeItem = new JObject();
            var sAPSelectTreeItempropCount = 0;
            sAPSelectTreeItempropCount++;
            sAPSelectTreeItem["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPSelectTreeItemSearchSAPElementId);
            if (sAPSelectTreeItemSearchNodeKey != null)
            {
                sAPSelectTreeItem["SearchNodeKey"] = ExpressionConverter.ConvertO(sAPSelectTreeItemSearchNodeKey);
                sAPSelectTreeItempropCount++;
            }

            if (sAPSelectTreeItemSearchNodePath != null)
            {
                sAPSelectTreeItem["SearchNodePath"] = ExpressionConverter.ConvertO(sAPSelectTreeItemSearchNodePath);
                sAPSelectTreeItempropCount++;
            }

            if (sAPSelectTreeItemSearchNodeText != null)
            {
                sAPSelectTreeItem["SearchNodeText"] = ExpressionConverter.ConvertO(sAPSelectTreeItemSearchNodeText);
                sAPSelectTreeItempropCount++;
            }

            if (sAPSelectTreeItemSearchNodeTextIsRegularExpression != null)
            {
                sAPSelectTreeItem["SearchNodeTextIsRegularExpression"] = ExpressionConverter.ConvertO(sAPSelectTreeItemSearchNodeTextIsRegularExpression);
                sAPSelectTreeItempropCount++;
            }

            if (sAPSelectTreeItemSearchNodeTextIsCaseSensitive != null)
            {
                sAPSelectTreeItem["SearchNodeTextIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPSelectTreeItemSearchNodeTextIsCaseSensitive);
                sAPSelectTreeItempropCount++;
            }

            if (sAPSelectTreeItemSearchColumnName != null)
            {
                sAPSelectTreeItem["SearchColumnName"] = ExpressionConverter.ConvertO(sAPSelectTreeItemSearchColumnName);
                sAPSelectTreeItempropCount++;
            }

            if (sAPSelectTreeItemSearchColumnTitle != null)
            {
                sAPSelectTreeItem["SearchColumnTitle"] = ExpressionConverter.ConvertO(sAPSelectTreeItemSearchColumnTitle);
                sAPSelectTreeItempropCount++;
            }

            if (sAPSelectTreeItemSearchColumnTitleIsRegularExpression != null)
            {
                sAPSelectTreeItem["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(sAPSelectTreeItemSearchColumnTitleIsRegularExpression);
                sAPSelectTreeItempropCount++;
            }

            if (sAPSelectTreeItemSearchColumnTitleIsCaseSensitive != null)
            {
                sAPSelectTreeItem["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPSelectTreeItemSearchColumnTitleIsCaseSensitive);
                sAPSelectTreeItempropCount++;
            }

            if (sAPSelectTreeItemSelect != null)
            {
                sAPSelectTreeItem["Select"] = ExpressionConverter.ConvertO(sAPSelectTreeItemSelect);
                sAPSelectTreeItempropCount++;
            }

            if (sAPSelectTreeItemDeselectAllFirst != null)
            {
                sAPSelectTreeItem["DeselectAllFirst"] = ExpressionConverter.ConvertO(sAPSelectTreeItemDeselectAllFirst);
                sAPSelectTreeItempropCount++;
            }

            sAPSelectTreeItempropCount++;
            sAPSelectTreeItem["Workflow"] = ExpressionConverter.ConvertO(sAPSelectTreeItemWorkflow);
            if (sAPSelectTreeItempropCount > 0)
            {
                callPayload.Body = sAPSelectTreeItem;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPExpandTreeNode(Expression<Func<string>> sAPExpandTreeNodeSearchSAPElementId, Expression<Func<string>> sAPExpandTreeNodeWorkflow, Expression<Func<string>> sAPExpandTreeNodeSearchNodeKey = null, Expression<Func<string>> sAPExpandTreeNodeSearchNodePath = null, Expression<Func<string>> sAPExpandTreeNodeSearchNodeText = null, Expression<Func<bool>> sAPExpandTreeNodeSearchNodeTextIsRegularExpression = null, Expression<Func<bool>> sAPExpandTreeNodeSearchNodeTextIsCaseSensitive = null, Expression<Func<bool>> sAPExpandTreeNodeExpand = null)
        {
            var apiCallPath = "/SAPGUI/SAPExpandTreeNode";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPExpandTreeNode = new JObject();
            var sAPExpandTreeNodepropCount = 0;
            sAPExpandTreeNodepropCount++;
            sAPExpandTreeNode["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPExpandTreeNodeSearchSAPElementId);
            if (sAPExpandTreeNodeSearchNodeKey != null)
            {
                sAPExpandTreeNode["SearchNodeKey"] = ExpressionConverter.ConvertO(sAPExpandTreeNodeSearchNodeKey);
                sAPExpandTreeNodepropCount++;
            }

            if (sAPExpandTreeNodeSearchNodePath != null)
            {
                sAPExpandTreeNode["SearchNodePath"] = ExpressionConverter.ConvertO(sAPExpandTreeNodeSearchNodePath);
                sAPExpandTreeNodepropCount++;
            }

            if (sAPExpandTreeNodeSearchNodeText != null)
            {
                sAPExpandTreeNode["SearchNodeText"] = ExpressionConverter.ConvertO(sAPExpandTreeNodeSearchNodeText);
                sAPExpandTreeNodepropCount++;
            }

            if (sAPExpandTreeNodeSearchNodeTextIsRegularExpression != null)
            {
                sAPExpandTreeNode["SearchNodeTextIsRegularExpression"] = ExpressionConverter.ConvertO(sAPExpandTreeNodeSearchNodeTextIsRegularExpression);
                sAPExpandTreeNodepropCount++;
            }

            if (sAPExpandTreeNodeSearchNodeTextIsCaseSensitive != null)
            {
                sAPExpandTreeNode["SearchNodeTextIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPExpandTreeNodeSearchNodeTextIsCaseSensitive);
                sAPExpandTreeNodepropCount++;
            }

            if (sAPExpandTreeNodeExpand != null)
            {
                sAPExpandTreeNode["Expand"] = ExpressionConverter.ConvertO(sAPExpandTreeNodeExpand);
                sAPExpandTreeNodepropCount++;
            }

            sAPExpandTreeNodepropCount++;
            sAPExpandTreeNode["Workflow"] = ExpressionConverter.ConvertO(sAPExpandTreeNodeWorkflow);
            if (sAPExpandTreeNodepropCount > 0)
            {
                callPayload.Body = sAPExpandTreeNode;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPDeselectAllTreeNodes(Expression<Func<string>> sAPDeselectAllTreeNodesSearchSAPElementId, Expression<Func<string>> sAPDeselectAllTreeNodesWorkflow)
        {
            var apiCallPath = "/SAPGUI/SAPDeselectAllTreeNodes";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPDeselectAllTreeNodes = new JObject();
            var sAPDeselectAllTreeNodespropCount = 0;
            sAPDeselectAllTreeNodespropCount++;
            sAPDeselectAllTreeNodes["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPDeselectAllTreeNodesSearchSAPElementId);
            sAPDeselectAllTreeNodespropCount++;
            sAPDeselectAllTreeNodes["Workflow"] = ExpressionConverter.ConvertO(sAPDeselectAllTreeNodesWorkflow);
            if (sAPDeselectAllTreeNodespropCount > 0)
            {
                callPayload.Body = sAPDeselectAllTreeNodes;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPPressKeyOnTree(Expression<Func<string>> sAPPressKeyOnTreeSearchSAPElementId, Expression<Func<string>> sAPPressKeyOnTreeKey, Expression<Func<string>> sAPPressKeyOnTreeWorkflow)
        {
            var apiCallPath = "/SAPGUI/SAPPressKeyOnTree";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPPressKeyOnTree = new JObject();
            var sAPPressKeyOnTreepropCount = 0;
            sAPPressKeyOnTreepropCount++;
            sAPPressKeyOnTree["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPPressKeyOnTreeSearchSAPElementId);
            sAPPressKeyOnTreepropCount++;
            sAPPressKeyOnTree["Key"] = ExpressionConverter.ConvertO(sAPPressKeyOnTreeKey);
            sAPPressKeyOnTreepropCount++;
            sAPPressKeyOnTree["Workflow"] = ExpressionConverter.ConvertO(sAPPressKeyOnTreeWorkflow);
            if (sAPPressKeyOnTreepropCount > 0)
            {
                callPayload.Body = sAPPressKeyOnTree;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPOpenContextMenuOnTreeItem(Expression<Func<string>> sAPOpenContextMenuOnTreeItemSearchSAPElementId, Expression<Func<string>> sAPOpenContextMenuOnTreeItemWorkflow, Expression<Func<string>> sAPOpenContextMenuOnTreeItemSearchNodeKey = null, Expression<Func<string>> sAPOpenContextMenuOnTreeItemSearchNodePath = null, Expression<Func<string>> sAPOpenContextMenuOnTreeItemSearchNodeText = null, Expression<Func<bool>> sAPOpenContextMenuOnTreeItemSearchNodeTextIsRegularExpression = null, Expression<Func<bool>> sAPOpenContextMenuOnTreeItemSearchNodeTextIsCaseSensitive = null, Expression<Func<string>> sAPOpenContextMenuOnTreeItemSearchColumnName = null, Expression<Func<string>> sAPOpenContextMenuOnTreeItemSearchColumnTitle = null, Expression<Func<bool>> sAPOpenContextMenuOnTreeItemSearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPOpenContextMenuOnTreeItemSearchColumnTitleIsCaseSensitive = null)
        {
            var apiCallPath = "/SAPGUI/SAPOpenContextMenuOnTreeItem";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPOpenContextMenuOnTreeItem = new JObject();
            var sAPOpenContextMenuOnTreeItempropCount = 0;
            sAPOpenContextMenuOnTreeItempropCount++;
            sAPOpenContextMenuOnTreeItem["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPOpenContextMenuOnTreeItemSearchSAPElementId);
            if (sAPOpenContextMenuOnTreeItemSearchNodeKey != null)
            {
                sAPOpenContextMenuOnTreeItem["SearchNodeKey"] = ExpressionConverter.ConvertO(sAPOpenContextMenuOnTreeItemSearchNodeKey);
                sAPOpenContextMenuOnTreeItempropCount++;
            }

            if (sAPOpenContextMenuOnTreeItemSearchNodePath != null)
            {
                sAPOpenContextMenuOnTreeItem["SearchNodePath"] = ExpressionConverter.ConvertO(sAPOpenContextMenuOnTreeItemSearchNodePath);
                sAPOpenContextMenuOnTreeItempropCount++;
            }

            if (sAPOpenContextMenuOnTreeItemSearchNodeText != null)
            {
                sAPOpenContextMenuOnTreeItem["SearchNodeText"] = ExpressionConverter.ConvertO(sAPOpenContextMenuOnTreeItemSearchNodeText);
                sAPOpenContextMenuOnTreeItempropCount++;
            }

            if (sAPOpenContextMenuOnTreeItemSearchNodeTextIsRegularExpression != null)
            {
                sAPOpenContextMenuOnTreeItem["SearchNodeTextIsRegularExpression"] = ExpressionConverter.ConvertO(sAPOpenContextMenuOnTreeItemSearchNodeTextIsRegularExpression);
                sAPOpenContextMenuOnTreeItempropCount++;
            }

            if (sAPOpenContextMenuOnTreeItemSearchNodeTextIsCaseSensitive != null)
            {
                sAPOpenContextMenuOnTreeItem["SearchNodeTextIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPOpenContextMenuOnTreeItemSearchNodeTextIsCaseSensitive);
                sAPOpenContextMenuOnTreeItempropCount++;
            }

            if (sAPOpenContextMenuOnTreeItemSearchColumnName != null)
            {
                sAPOpenContextMenuOnTreeItem["SearchColumnName"] = ExpressionConverter.ConvertO(sAPOpenContextMenuOnTreeItemSearchColumnName);
                sAPOpenContextMenuOnTreeItempropCount++;
            }

            if (sAPOpenContextMenuOnTreeItemSearchColumnTitle != null)
            {
                sAPOpenContextMenuOnTreeItem["SearchColumnTitle"] = ExpressionConverter.ConvertO(sAPOpenContextMenuOnTreeItemSearchColumnTitle);
                sAPOpenContextMenuOnTreeItempropCount++;
            }

            if (sAPOpenContextMenuOnTreeItemSearchColumnTitleIsRegularExpression != null)
            {
                sAPOpenContextMenuOnTreeItem["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(sAPOpenContextMenuOnTreeItemSearchColumnTitleIsRegularExpression);
                sAPOpenContextMenuOnTreeItempropCount++;
            }

            if (sAPOpenContextMenuOnTreeItemSearchColumnTitleIsCaseSensitive != null)
            {
                sAPOpenContextMenuOnTreeItem["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPOpenContextMenuOnTreeItemSearchColumnTitleIsCaseSensitive);
                sAPOpenContextMenuOnTreeItempropCount++;
            }

            sAPOpenContextMenuOnTreeItempropCount++;
            sAPOpenContextMenuOnTreeItem["Workflow"] = ExpressionConverter.ConvertO(sAPOpenContextMenuOnTreeItemWorkflow);
            if (sAPOpenContextMenuOnTreeItempropCount > 0)
            {
                callPayload.Body = sAPOpenContextMenuOnTreeItem;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetTreeTextContentsResponse> SAPGetTreeTextContents(Expression<Func<string>> sAPGetTreeTextContentsSearchSAPElementId, Expression<Func<string>> sAPGetTreeTextContentsWorkflow, Expression<Func<int>> sAPGetTreeTextContentsFirstRowToReturn = null, Expression<Func<int>> sAPGetTreeTextContentsMaxRowsToReturn = null, Expression<Func<int>> sAPGetTreeTextContentsFirstColumnToReturn = null, Expression<Func<int>> sAPGetTreeTextContentsMaxColumnsToReturn = null, Expression<Func<bool>> sAPGetTreeTextContentsUseColumnHeadersFromTree = null, Expression<Func<bool>> sAPGetTreeTextContentsReturnRowIndexInOutputCollection = null, Expression<Func<string>> sAPGetTreeTextContentsNameOfColumnToStoreRowIndex = null)
        {
            var apiCallPath = "/SAPGUI/SAPGetTreeTextContents";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPGetTreeTextContents = new JObject();
            var sAPGetTreeTextContentspropCount = 0;
            sAPGetTreeTextContentspropCount++;
            sAPGetTreeTextContents["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGetTreeTextContentsSearchSAPElementId);
            if (sAPGetTreeTextContentsFirstRowToReturn != null)
            {
                sAPGetTreeTextContents["FirstRowToReturn"] = ExpressionConverter.ConvertO(sAPGetTreeTextContentsFirstRowToReturn);
                sAPGetTreeTextContentspropCount++;
            }

            if (sAPGetTreeTextContentsMaxRowsToReturn != null)
            {
                sAPGetTreeTextContents["MaxRowsToReturn"] = ExpressionConverter.ConvertO(sAPGetTreeTextContentsMaxRowsToReturn);
                sAPGetTreeTextContentspropCount++;
            }

            if (sAPGetTreeTextContentsFirstColumnToReturn != null)
            {
                sAPGetTreeTextContents["FirstColumnToReturn"] = ExpressionConverter.ConvertO(sAPGetTreeTextContentsFirstColumnToReturn);
                sAPGetTreeTextContentspropCount++;
            }

            if (sAPGetTreeTextContentsMaxColumnsToReturn != null)
            {
                sAPGetTreeTextContents["MaxColumnsToReturn"] = ExpressionConverter.ConvertO(sAPGetTreeTextContentsMaxColumnsToReturn);
                sAPGetTreeTextContentspropCount++;
            }

            if (sAPGetTreeTextContentsUseColumnHeadersFromTree != null)
            {
                sAPGetTreeTextContents["UseColumnHeadersFromTree"] = ExpressionConverter.ConvertO(sAPGetTreeTextContentsUseColumnHeadersFromTree);
                sAPGetTreeTextContentspropCount++;
            }

            if (sAPGetTreeTextContentsReturnRowIndexInOutputCollection != null)
            {
                sAPGetTreeTextContents["ReturnRowIndexInOutputCollection"] = ExpressionConverter.ConvertO(sAPGetTreeTextContentsReturnRowIndexInOutputCollection);
                sAPGetTreeTextContentspropCount++;
            }

            if (sAPGetTreeTextContentsNameOfColumnToStoreRowIndex != null)
            {
                sAPGetTreeTextContents["NameOfColumnToStoreRowIndex"] = ExpressionConverter.ConvertO(sAPGetTreeTextContentsNameOfColumnToStoreRowIndex);
                sAPGetTreeTextContentspropCount++;
            }

            sAPGetTreeTextContentspropCount++;
            sAPGetTreeTextContents["Workflow"] = ExpressionConverter.ConvertO(sAPGetTreeTextContentsWorkflow);
            if (sAPGetTreeTextContentspropCount > 0)
            {
                callPayload.Body = sAPGetTreeTextContents;
            }

            return new ApiConnectionAction<SAPGetTreeTextContentsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPSetTreeColumnWidth(Expression<Func<string>> sAPSetTreeColumnWidthSearchSAPElementId, Expression<Func<string>> sAPSetTreeColumnWidthWorkflow, Expression<Func<string>> sAPSetTreeColumnWidthSearchColumnName = null, Expression<Func<string>> sAPSetTreeColumnWidthSearchColumnTitle = null, Expression<Func<bool>> sAPSetTreeColumnWidthSearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPSetTreeColumnWidthSearchColumnTitleIsCaseSensitive = null, Expression<Func<int>> sAPSetTreeColumnWidthColumnWidthInPixels = null)
        {
            var apiCallPath = "/SAPGUI/SAPSetTreeColumnWidth";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPSetTreeColumnWidth = new JObject();
            var sAPSetTreeColumnWidthpropCount = 0;
            sAPSetTreeColumnWidthpropCount++;
            sAPSetTreeColumnWidth["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPSetTreeColumnWidthSearchSAPElementId);
            if (sAPSetTreeColumnWidthSearchColumnName != null)
            {
                sAPSetTreeColumnWidth["SearchColumnName"] = ExpressionConverter.ConvertO(sAPSetTreeColumnWidthSearchColumnName);
                sAPSetTreeColumnWidthpropCount++;
            }

            if (sAPSetTreeColumnWidthSearchColumnTitle != null)
            {
                sAPSetTreeColumnWidth["SearchColumnTitle"] = ExpressionConverter.ConvertO(sAPSetTreeColumnWidthSearchColumnTitle);
                sAPSetTreeColumnWidthpropCount++;
            }

            if (sAPSetTreeColumnWidthSearchColumnTitleIsRegularExpression != null)
            {
                sAPSetTreeColumnWidth["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(sAPSetTreeColumnWidthSearchColumnTitleIsRegularExpression);
                sAPSetTreeColumnWidthpropCount++;
            }

            if (sAPSetTreeColumnWidthSearchColumnTitleIsCaseSensitive != null)
            {
                sAPSetTreeColumnWidth["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPSetTreeColumnWidthSearchColumnTitleIsCaseSensitive);
                sAPSetTreeColumnWidthpropCount++;
            }

            if (sAPSetTreeColumnWidthColumnWidthInPixels != null)
            {
                sAPSetTreeColumnWidth["ColumnWidthInPixels"] = ExpressionConverter.ConvertO(sAPSetTreeColumnWidthColumnWidthInPixels);
                sAPSetTreeColumnWidthpropCount++;
            }

            sAPSetTreeColumnWidthpropCount++;
            sAPSetTreeColumnWidth["Workflow"] = ExpressionConverter.ConvertO(sAPSetTreeColumnWidthWorkflow);
            if (sAPSetTreeColumnWidthpropCount > 0)
            {
                callPayload.Body = sAPSetTreeColumnWidth;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPPressButtonOnTreeItem(Expression<Func<string>> sAPPressButtonOnTreeItemSearchSAPElementId, Expression<Func<string>> sAPPressButtonOnTreeItemWorkflow, Expression<Func<string>> sAPPressButtonOnTreeItemSearchNodeKey = null, Expression<Func<string>> sAPPressButtonOnTreeItemSearchNodePath = null, Expression<Func<string>> sAPPressButtonOnTreeItemSearchNodeText = null, Expression<Func<bool>> sAPPressButtonOnTreeItemSearchNodeTextIsRegularExpression = null, Expression<Func<bool>> sAPPressButtonOnTreeItemSearchNodeTextIsCaseSensitive = null, Expression<Func<string>> sAPPressButtonOnTreeItemSearchColumnName = null, Expression<Func<string>> sAPPressButtonOnTreeItemSearchColumnTitle = null, Expression<Func<bool>> sAPPressButtonOnTreeItemSearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPPressButtonOnTreeItemSearchColumnTitleIsCaseSensitive = null, Expression<Func<bool>> sAPPressButtonOnTreeItemForce = null)
        {
            var apiCallPath = "/SAPGUI/SAPPressButtonOnTreeItem";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPPressButtonOnTreeItem = new JObject();
            var sAPPressButtonOnTreeItempropCount = 0;
            sAPPressButtonOnTreeItempropCount++;
            sAPPressButtonOnTreeItem["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPPressButtonOnTreeItemSearchSAPElementId);
            if (sAPPressButtonOnTreeItemSearchNodeKey != null)
            {
                sAPPressButtonOnTreeItem["SearchNodeKey"] = ExpressionConverter.ConvertO(sAPPressButtonOnTreeItemSearchNodeKey);
                sAPPressButtonOnTreeItempropCount++;
            }

            if (sAPPressButtonOnTreeItemSearchNodePath != null)
            {
                sAPPressButtonOnTreeItem["SearchNodePath"] = ExpressionConverter.ConvertO(sAPPressButtonOnTreeItemSearchNodePath);
                sAPPressButtonOnTreeItempropCount++;
            }

            if (sAPPressButtonOnTreeItemSearchNodeText != null)
            {
                sAPPressButtonOnTreeItem["SearchNodeText"] = ExpressionConverter.ConvertO(sAPPressButtonOnTreeItemSearchNodeText);
                sAPPressButtonOnTreeItempropCount++;
            }

            if (sAPPressButtonOnTreeItemSearchNodeTextIsRegularExpression != null)
            {
                sAPPressButtonOnTreeItem["SearchNodeTextIsRegularExpression"] = ExpressionConverter.ConvertO(sAPPressButtonOnTreeItemSearchNodeTextIsRegularExpression);
                sAPPressButtonOnTreeItempropCount++;
            }

            if (sAPPressButtonOnTreeItemSearchNodeTextIsCaseSensitive != null)
            {
                sAPPressButtonOnTreeItem["SearchNodeTextIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPPressButtonOnTreeItemSearchNodeTextIsCaseSensitive);
                sAPPressButtonOnTreeItempropCount++;
            }

            if (sAPPressButtonOnTreeItemSearchColumnName != null)
            {
                sAPPressButtonOnTreeItem["SearchColumnName"] = ExpressionConverter.ConvertO(sAPPressButtonOnTreeItemSearchColumnName);
                sAPPressButtonOnTreeItempropCount++;
            }

            if (sAPPressButtonOnTreeItemSearchColumnTitle != null)
            {
                sAPPressButtonOnTreeItem["SearchColumnTitle"] = ExpressionConverter.ConvertO(sAPPressButtonOnTreeItemSearchColumnTitle);
                sAPPressButtonOnTreeItempropCount++;
            }

            if (sAPPressButtonOnTreeItemSearchColumnTitleIsRegularExpression != null)
            {
                sAPPressButtonOnTreeItem["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(sAPPressButtonOnTreeItemSearchColumnTitleIsRegularExpression);
                sAPPressButtonOnTreeItempropCount++;
            }

            if (sAPPressButtonOnTreeItemSearchColumnTitleIsCaseSensitive != null)
            {
                sAPPressButtonOnTreeItem["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPPressButtonOnTreeItemSearchColumnTitleIsCaseSensitive);
                sAPPressButtonOnTreeItempropCount++;
            }

            if (sAPPressButtonOnTreeItemForce != null)
            {
                sAPPressButtonOnTreeItem["Force"] = ExpressionConverter.ConvertO(sAPPressButtonOnTreeItemForce);
                sAPPressButtonOnTreeItempropCount++;
            }

            sAPPressButtonOnTreeItempropCount++;
            sAPPressButtonOnTreeItem["Workflow"] = ExpressionConverter.ConvertO(sAPPressButtonOnTreeItemWorkflow);
            if (sAPPressButtonOnTreeItempropCount > 0)
            {
                callPayload.Body = sAPPressButtonOnTreeItem;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPClickLinkOnTreeItem(Expression<Func<string>> sAPClickLinkOnTreeItemSearchSAPElementId, Expression<Func<string>> sAPClickLinkOnTreeItemWorkflow, Expression<Func<string>> sAPClickLinkOnTreeItemSearchNodeKey = null, Expression<Func<string>> sAPClickLinkOnTreeItemSearchNodePath = null, Expression<Func<string>> sAPClickLinkOnTreeItemSearchNodeText = null, Expression<Func<bool>> sAPClickLinkOnTreeItemSearchNodeTextIsRegularExpression = null, Expression<Func<bool>> sAPClickLinkOnTreeItemSearchNodeTextIsCaseSensitive = null, Expression<Func<string>> sAPClickLinkOnTreeItemSearchColumnName = null, Expression<Func<string>> sAPClickLinkOnTreeItemSearchColumnTitle = null, Expression<Func<bool>> sAPClickLinkOnTreeItemSearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPClickLinkOnTreeItemSearchColumnTitleIsCaseSensitive = null, Expression<Func<bool>> sAPClickLinkOnTreeItemForce = null)
        {
            var apiCallPath = "/SAPGUI/SAPClickLinkOnTreeItem";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPClickLinkOnTreeItem = new JObject();
            var sAPClickLinkOnTreeItempropCount = 0;
            sAPClickLinkOnTreeItempropCount++;
            sAPClickLinkOnTreeItem["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPClickLinkOnTreeItemSearchSAPElementId);
            if (sAPClickLinkOnTreeItemSearchNodeKey != null)
            {
                sAPClickLinkOnTreeItem["SearchNodeKey"] = ExpressionConverter.ConvertO(sAPClickLinkOnTreeItemSearchNodeKey);
                sAPClickLinkOnTreeItempropCount++;
            }

            if (sAPClickLinkOnTreeItemSearchNodePath != null)
            {
                sAPClickLinkOnTreeItem["SearchNodePath"] = ExpressionConverter.ConvertO(sAPClickLinkOnTreeItemSearchNodePath);
                sAPClickLinkOnTreeItempropCount++;
            }

            if (sAPClickLinkOnTreeItemSearchNodeText != null)
            {
                sAPClickLinkOnTreeItem["SearchNodeText"] = ExpressionConverter.ConvertO(sAPClickLinkOnTreeItemSearchNodeText);
                sAPClickLinkOnTreeItempropCount++;
            }

            if (sAPClickLinkOnTreeItemSearchNodeTextIsRegularExpression != null)
            {
                sAPClickLinkOnTreeItem["SearchNodeTextIsRegularExpression"] = ExpressionConverter.ConvertO(sAPClickLinkOnTreeItemSearchNodeTextIsRegularExpression);
                sAPClickLinkOnTreeItempropCount++;
            }

            if (sAPClickLinkOnTreeItemSearchNodeTextIsCaseSensitive != null)
            {
                sAPClickLinkOnTreeItem["SearchNodeTextIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPClickLinkOnTreeItemSearchNodeTextIsCaseSensitive);
                sAPClickLinkOnTreeItempropCount++;
            }

            if (sAPClickLinkOnTreeItemSearchColumnName != null)
            {
                sAPClickLinkOnTreeItem["SearchColumnName"] = ExpressionConverter.ConvertO(sAPClickLinkOnTreeItemSearchColumnName);
                sAPClickLinkOnTreeItempropCount++;
            }

            if (sAPClickLinkOnTreeItemSearchColumnTitle != null)
            {
                sAPClickLinkOnTreeItem["SearchColumnTitle"] = ExpressionConverter.ConvertO(sAPClickLinkOnTreeItemSearchColumnTitle);
                sAPClickLinkOnTreeItempropCount++;
            }

            if (sAPClickLinkOnTreeItemSearchColumnTitleIsRegularExpression != null)
            {
                sAPClickLinkOnTreeItem["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(sAPClickLinkOnTreeItemSearchColumnTitleIsRegularExpression);
                sAPClickLinkOnTreeItempropCount++;
            }

            if (sAPClickLinkOnTreeItemSearchColumnTitleIsCaseSensitive != null)
            {
                sAPClickLinkOnTreeItem["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPClickLinkOnTreeItemSearchColumnTitleIsCaseSensitive);
                sAPClickLinkOnTreeItempropCount++;
            }

            if (sAPClickLinkOnTreeItemForce != null)
            {
                sAPClickLinkOnTreeItem["Force"] = ExpressionConverter.ConvertO(sAPClickLinkOnTreeItemForce);
                sAPClickLinkOnTreeItempropCount++;
            }

            sAPClickLinkOnTreeItempropCount++;
            sAPClickLinkOnTreeItem["Workflow"] = ExpressionConverter.ConvertO(sAPClickLinkOnTreeItemWorkflow);
            if (sAPClickLinkOnTreeItempropCount > 0)
            {
                callPayload.Body = sAPClickLinkOnTreeItem;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPCheckTreeItem(Expression<Func<string>> sAPCheckTreeItemSearchSAPElementId, Expression<Func<string>> sAPCheckTreeItemWorkflow, Expression<Func<string>> sAPCheckTreeItemSearchNodeKey = null, Expression<Func<string>> sAPCheckTreeItemSearchNodePath = null, Expression<Func<string>> sAPCheckTreeItemSearchNodeText = null, Expression<Func<bool>> sAPCheckTreeItemSearchNodeTextIsRegularExpression = null, Expression<Func<bool>> sAPCheckTreeItemSearchNodeTextIsCaseSensitive = null, Expression<Func<string>> sAPCheckTreeItemSearchColumnName = null, Expression<Func<string>> sAPCheckTreeItemSearchColumnTitle = null, Expression<Func<bool>> sAPCheckTreeItemSearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPCheckTreeItemSearchColumnTitleIsCaseSensitive = null, Expression<Func<bool>> sAPCheckTreeItemCheckItem = null, Expression<Func<bool>> sAPCheckTreeItemForce = null)
        {
            var apiCallPath = "/SAPGUI/SAPCheckTreeItem";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPCheckTreeItem = new JObject();
            var sAPCheckTreeItempropCount = 0;
            sAPCheckTreeItempropCount++;
            sAPCheckTreeItem["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPCheckTreeItemSearchSAPElementId);
            if (sAPCheckTreeItemSearchNodeKey != null)
            {
                sAPCheckTreeItem["SearchNodeKey"] = ExpressionConverter.ConvertO(sAPCheckTreeItemSearchNodeKey);
                sAPCheckTreeItempropCount++;
            }

            if (sAPCheckTreeItemSearchNodePath != null)
            {
                sAPCheckTreeItem["SearchNodePath"] = ExpressionConverter.ConvertO(sAPCheckTreeItemSearchNodePath);
                sAPCheckTreeItempropCount++;
            }

            if (sAPCheckTreeItemSearchNodeText != null)
            {
                sAPCheckTreeItem["SearchNodeText"] = ExpressionConverter.ConvertO(sAPCheckTreeItemSearchNodeText);
                sAPCheckTreeItempropCount++;
            }

            if (sAPCheckTreeItemSearchNodeTextIsRegularExpression != null)
            {
                sAPCheckTreeItem["SearchNodeTextIsRegularExpression"] = ExpressionConverter.ConvertO(sAPCheckTreeItemSearchNodeTextIsRegularExpression);
                sAPCheckTreeItempropCount++;
            }

            if (sAPCheckTreeItemSearchNodeTextIsCaseSensitive != null)
            {
                sAPCheckTreeItem["SearchNodeTextIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPCheckTreeItemSearchNodeTextIsCaseSensitive);
                sAPCheckTreeItempropCount++;
            }

            if (sAPCheckTreeItemSearchColumnName != null)
            {
                sAPCheckTreeItem["SearchColumnName"] = ExpressionConverter.ConvertO(sAPCheckTreeItemSearchColumnName);
                sAPCheckTreeItempropCount++;
            }

            if (sAPCheckTreeItemSearchColumnTitle != null)
            {
                sAPCheckTreeItem["SearchColumnTitle"] = ExpressionConverter.ConvertO(sAPCheckTreeItemSearchColumnTitle);
                sAPCheckTreeItempropCount++;
            }

            if (sAPCheckTreeItemSearchColumnTitleIsRegularExpression != null)
            {
                sAPCheckTreeItem["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(sAPCheckTreeItemSearchColumnTitleIsRegularExpression);
                sAPCheckTreeItempropCount++;
            }

            if (sAPCheckTreeItemSearchColumnTitleIsCaseSensitive != null)
            {
                sAPCheckTreeItem["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPCheckTreeItemSearchColumnTitleIsCaseSensitive);
                sAPCheckTreeItempropCount++;
            }

            if (sAPCheckTreeItemCheckItem != null)
            {
                sAPCheckTreeItem["CheckItem"] = ExpressionConverter.ConvertO(sAPCheckTreeItemCheckItem);
                sAPCheckTreeItempropCount++;
            }

            if (sAPCheckTreeItemForce != null)
            {
                sAPCheckTreeItem["Force"] = ExpressionConverter.ConvertO(sAPCheckTreeItemForce);
                sAPCheckTreeItempropCount++;
            }

            sAPCheckTreeItempropCount++;
            sAPCheckTreeItem["Workflow"] = ExpressionConverter.ConvertO(sAPCheckTreeItemWorkflow);
            if (sAPCheckTreeItempropCount > 0)
            {
                callPayload.Body = sAPCheckTreeItem;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetTreeColumnHeadersResponse> SAPGetTreeColumnHeaders(Expression<Func<string>> sAPGetTreeColumnHeadersSearchSAPElementId, Expression<Func<string>> sAPGetTreeColumnHeadersWorkflow)
        {
            var apiCallPath = "/SAPGUI/SAPGetTreeColumnHeaders";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPGetTreeColumnHeaders = new JObject();
            var sAPGetTreeColumnHeaderspropCount = 0;
            sAPGetTreeColumnHeaderspropCount++;
            sAPGetTreeColumnHeaders["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGetTreeColumnHeadersSearchSAPElementId);
            sAPGetTreeColumnHeaderspropCount++;
            sAPGetTreeColumnHeaders["Workflow"] = ExpressionConverter.ConvertO(sAPGetTreeColumnHeadersWorkflow);
            if (sAPGetTreeColumnHeaderspropCount > 0)
            {
                callPayload.Body = sAPGetTreeColumnHeaders;
            }

            return new ApiConnectionAction<SAPGetTreeColumnHeadersResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetTreeItemPropertiesResponse> SAPGetTreeItemProperties(Expression<Func<string>> sAPGetTreeItemPropertiesSearchSAPElementId, Expression<Func<string>> sAPGetTreeItemPropertiesWorkflow, Expression<Func<string>> sAPGetTreeItemPropertiesSearchNodeKey = null, Expression<Func<string>> sAPGetTreeItemPropertiesSearchNodePath = null, Expression<Func<string>> sAPGetTreeItemPropertiesSearchNodeText = null, Expression<Func<bool>> sAPGetTreeItemPropertiesSearchNodeTextIsRegularExpression = null, Expression<Func<bool>> sAPGetTreeItemPropertiesSearchNodeTextIsCaseSensitive = null, Expression<Func<string>> sAPGetTreeItemPropertiesSearchColumnName = null, Expression<Func<string>> sAPGetTreeItemPropertiesSearchColumnTitle = null, Expression<Func<bool>> sAPGetTreeItemPropertiesSearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPGetTreeItemPropertiesSearchColumnTitleIsCaseSensitive = null)
        {
            var apiCallPath = "/SAPGUI/SAPGetTreeItemProperties";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPGetTreeItemProperties = new JObject();
            var sAPGetTreeItemPropertiespropCount = 0;
            sAPGetTreeItemPropertiespropCount++;
            sAPGetTreeItemProperties["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGetTreeItemPropertiesSearchSAPElementId);
            if (sAPGetTreeItemPropertiesSearchNodeKey != null)
            {
                sAPGetTreeItemProperties["SearchNodeKey"] = ExpressionConverter.ConvertO(sAPGetTreeItemPropertiesSearchNodeKey);
                sAPGetTreeItemPropertiespropCount++;
            }

            if (sAPGetTreeItemPropertiesSearchNodePath != null)
            {
                sAPGetTreeItemProperties["SearchNodePath"] = ExpressionConverter.ConvertO(sAPGetTreeItemPropertiesSearchNodePath);
                sAPGetTreeItemPropertiespropCount++;
            }

            if (sAPGetTreeItemPropertiesSearchNodeText != null)
            {
                sAPGetTreeItemProperties["SearchNodeText"] = ExpressionConverter.ConvertO(sAPGetTreeItemPropertiesSearchNodeText);
                sAPGetTreeItemPropertiespropCount++;
            }

            if (sAPGetTreeItemPropertiesSearchNodeTextIsRegularExpression != null)
            {
                sAPGetTreeItemProperties["SearchNodeTextIsRegularExpression"] = ExpressionConverter.ConvertO(sAPGetTreeItemPropertiesSearchNodeTextIsRegularExpression);
                sAPGetTreeItemPropertiespropCount++;
            }

            if (sAPGetTreeItemPropertiesSearchNodeTextIsCaseSensitive != null)
            {
                sAPGetTreeItemProperties["SearchNodeTextIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPGetTreeItemPropertiesSearchNodeTextIsCaseSensitive);
                sAPGetTreeItemPropertiespropCount++;
            }

            if (sAPGetTreeItemPropertiesSearchColumnName != null)
            {
                sAPGetTreeItemProperties["SearchColumnName"] = ExpressionConverter.ConvertO(sAPGetTreeItemPropertiesSearchColumnName);
                sAPGetTreeItemPropertiespropCount++;
            }

            if (sAPGetTreeItemPropertiesSearchColumnTitle != null)
            {
                sAPGetTreeItemProperties["SearchColumnTitle"] = ExpressionConverter.ConvertO(sAPGetTreeItemPropertiesSearchColumnTitle);
                sAPGetTreeItemPropertiespropCount++;
            }

            if (sAPGetTreeItemPropertiesSearchColumnTitleIsRegularExpression != null)
            {
                sAPGetTreeItemProperties["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(sAPGetTreeItemPropertiesSearchColumnTitleIsRegularExpression);
                sAPGetTreeItemPropertiespropCount++;
            }

            if (sAPGetTreeItemPropertiesSearchColumnTitleIsCaseSensitive != null)
            {
                sAPGetTreeItemProperties["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPGetTreeItemPropertiesSearchColumnTitleIsCaseSensitive);
                sAPGetTreeItemPropertiespropCount++;
            }

            sAPGetTreeItemPropertiespropCount++;
            sAPGetTreeItemProperties["Workflow"] = ExpressionConverter.ConvertO(sAPGetTreeItemPropertiesWorkflow);
            if (sAPGetTreeItemPropertiespropCount > 0)
            {
                callPayload.Body = sAPGetTreeItemProperties;
            }

            return new ApiConnectionAction<SAPGetTreeItemPropertiesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetShellToolbarElementsResponse> SAPGetShellToolbarElements(Expression<Func<string>> sAPGetShellToolbarElementsSearchSAPElementId, Expression<Func<string>> sAPGetShellToolbarElementsWorkflow)
        {
            var apiCallPath = "/SAPGUI/SAPGetShellToolbarElements";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPGetShellToolbarElements = new JObject();
            var sAPGetShellToolbarElementspropCount = 0;
            sAPGetShellToolbarElementspropCount++;
            sAPGetShellToolbarElements["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGetShellToolbarElementsSearchSAPElementId);
            sAPGetShellToolbarElementspropCount++;
            sAPGetShellToolbarElements["Workflow"] = ExpressionConverter.ConvertO(sAPGetShellToolbarElementsWorkflow);
            if (sAPGetShellToolbarElementspropCount > 0)
            {
                callPayload.Body = sAPGetShellToolbarElements;
            }

            return new ApiConnectionAction<SAPGetShellToolbarElementsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPPressShellToolbarElement(Expression<Func<string>> sAPPressShellToolbarElementSearchSAPElementId, Expression<Func<string>> sAPPressShellToolbarElementWorkflow, Expression<Func<string>> sAPPressShellToolbarElementSearchToolbarElementId = null, Expression<Func<string>> sAPPressShellToolbarElementSearchToolbarElementText = null, Expression<Func<int>> sAPPressShellToolbarElementSearchToolbarElementIndex = null, Expression<Func<bool>> sAPPressShellToolbarElementSearchToolbarTextIsRegularExpression = null, Expression<Func<bool>> sAPPressShellToolbarElementSearchToolbarTextIsCaseSensitive = null)
        {
            var apiCallPath = "/SAPGUI/SAPPressShellToolbarElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPPressShellToolbarElement = new JObject();
            var sAPPressShellToolbarElementpropCount = 0;
            sAPPressShellToolbarElementpropCount++;
            sAPPressShellToolbarElement["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPPressShellToolbarElementSearchSAPElementId);
            if (sAPPressShellToolbarElementSearchToolbarElementId != null)
            {
                sAPPressShellToolbarElement["SearchToolbarElementId"] = ExpressionConverter.ConvertO(sAPPressShellToolbarElementSearchToolbarElementId);
                sAPPressShellToolbarElementpropCount++;
            }

            if (sAPPressShellToolbarElementSearchToolbarElementText != null)
            {
                sAPPressShellToolbarElement["SearchToolbarElementText"] = ExpressionConverter.ConvertO(sAPPressShellToolbarElementSearchToolbarElementText);
                sAPPressShellToolbarElementpropCount++;
            }

            if (sAPPressShellToolbarElementSearchToolbarElementIndex != null)
            {
                sAPPressShellToolbarElement["SearchToolbarElementIndex"] = ExpressionConverter.ConvertO(sAPPressShellToolbarElementSearchToolbarElementIndex);
                sAPPressShellToolbarElementpropCount++;
            }

            if (sAPPressShellToolbarElementSearchToolbarTextIsRegularExpression != null)
            {
                sAPPressShellToolbarElement["SearchToolbarTextIsRegularExpression"] = ExpressionConverter.ConvertO(sAPPressShellToolbarElementSearchToolbarTextIsRegularExpression);
                sAPPressShellToolbarElementpropCount++;
            }

            if (sAPPressShellToolbarElementSearchToolbarTextIsCaseSensitive != null)
            {
                sAPPressShellToolbarElement["SearchToolbarTextIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPPressShellToolbarElementSearchToolbarTextIsCaseSensitive);
                sAPPressShellToolbarElementpropCount++;
            }

            sAPPressShellToolbarElementpropCount++;
            sAPPressShellToolbarElement["Workflow"] = ExpressionConverter.ConvertO(sAPPressShellToolbarElementWorkflow);
            if (sAPPressShellToolbarElementpropCount > 0)
            {
                callPayload.Body = sAPPressShellToolbarElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPPressShellToolbarElementContextButton(Expression<Func<string>> sAPPressShellToolbarElementContextButtonSearchSAPElementId, Expression<Func<string>> sAPPressShellToolbarElementContextButtonWorkflow, Expression<Func<string>> sAPPressShellToolbarElementContextButtonSearchToolbarElementId = null, Expression<Func<string>> sAPPressShellToolbarElementContextButtonSearchToolbarElementText = null, Expression<Func<int>> sAPPressShellToolbarElementContextButtonSearchToolbarElementIndex = null, Expression<Func<bool>> sAPPressShellToolbarElementContextButtonSearchToolbarTextIsRegularExpression = null, Expression<Func<bool>> sAPPressShellToolbarElementContextButtonSearchToolbarTextIsCaseSensitive = null)
        {
            var apiCallPath = "/SAPGUI/SAPPressShellToolbarElementContextButton";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPPressShellToolbarElementContextButton = new JObject();
            var sAPPressShellToolbarElementContextButtonpropCount = 0;
            sAPPressShellToolbarElementContextButtonpropCount++;
            sAPPressShellToolbarElementContextButton["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPPressShellToolbarElementContextButtonSearchSAPElementId);
            if (sAPPressShellToolbarElementContextButtonSearchToolbarElementId != null)
            {
                sAPPressShellToolbarElementContextButton["SearchToolbarElementId"] = ExpressionConverter.ConvertO(sAPPressShellToolbarElementContextButtonSearchToolbarElementId);
                sAPPressShellToolbarElementContextButtonpropCount++;
            }

            if (sAPPressShellToolbarElementContextButtonSearchToolbarElementText != null)
            {
                sAPPressShellToolbarElementContextButton["SearchToolbarElementText"] = ExpressionConverter.ConvertO(sAPPressShellToolbarElementContextButtonSearchToolbarElementText);
                sAPPressShellToolbarElementContextButtonpropCount++;
            }

            if (sAPPressShellToolbarElementContextButtonSearchToolbarElementIndex != null)
            {
                sAPPressShellToolbarElementContextButton["SearchToolbarElementIndex"] = ExpressionConverter.ConvertO(sAPPressShellToolbarElementContextButtonSearchToolbarElementIndex);
                sAPPressShellToolbarElementContextButtonpropCount++;
            }

            if (sAPPressShellToolbarElementContextButtonSearchToolbarTextIsRegularExpression != null)
            {
                sAPPressShellToolbarElementContextButton["SearchToolbarTextIsRegularExpression"] = ExpressionConverter.ConvertO(sAPPressShellToolbarElementContextButtonSearchToolbarTextIsRegularExpression);
                sAPPressShellToolbarElementContextButtonpropCount++;
            }

            if (sAPPressShellToolbarElementContextButtonSearchToolbarTextIsCaseSensitive != null)
            {
                sAPPressShellToolbarElementContextButton["SearchToolbarTextIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPPressShellToolbarElementContextButtonSearchToolbarTextIsCaseSensitive);
                sAPPressShellToolbarElementContextButtonpropCount++;
            }

            sAPPressShellToolbarElementContextButtonpropCount++;
            sAPPressShellToolbarElementContextButton["Workflow"] = ExpressionConverter.ConvertO(sAPPressShellToolbarElementContextButtonWorkflow);
            if (sAPPressShellToolbarElementContextButtonpropCount > 0)
            {
                callPayload.Body = sAPPressShellToolbarElementContextButton;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPSelectShellToolbarMenuItem(Expression<Func<string>> sAPSelectShellToolbarMenuItemSearchSAPElementId, Expression<Func<string>> sAPSelectShellToolbarMenuItemWorkflow, Expression<Func<string>> sAPSelectShellToolbarMenuItemSearchToolbarElementId = null, Expression<Func<string>> sAPSelectShellToolbarMenuItemSearchToolbarElementText = null, Expression<Func<int>> sAPSelectShellToolbarMenuItemSearchToolbarElementIndex = null, Expression<Func<bool>> sAPSelectShellToolbarMenuItemSearchToolbarTextIsRegularExpression = null, Expression<Func<bool>> sAPSelectShellToolbarMenuItemSearchToolbarTextIsCaseSensitive = null)
        {
            var apiCallPath = "/SAPGUI/SAPSelectShellToolbarMenuItem";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPSelectShellToolbarMenuItem = new JObject();
            var sAPSelectShellToolbarMenuItempropCount = 0;
            sAPSelectShellToolbarMenuItempropCount++;
            sAPSelectShellToolbarMenuItem["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPSelectShellToolbarMenuItemSearchSAPElementId);
            if (sAPSelectShellToolbarMenuItemSearchToolbarElementId != null)
            {
                sAPSelectShellToolbarMenuItem["SearchToolbarElementId"] = ExpressionConverter.ConvertO(sAPSelectShellToolbarMenuItemSearchToolbarElementId);
                sAPSelectShellToolbarMenuItempropCount++;
            }

            if (sAPSelectShellToolbarMenuItemSearchToolbarElementText != null)
            {
                sAPSelectShellToolbarMenuItem["SearchToolbarElementText"] = ExpressionConverter.ConvertO(sAPSelectShellToolbarMenuItemSearchToolbarElementText);
                sAPSelectShellToolbarMenuItempropCount++;
            }

            if (sAPSelectShellToolbarMenuItemSearchToolbarElementIndex != null)
            {
                sAPSelectShellToolbarMenuItem["SearchToolbarElementIndex"] = ExpressionConverter.ConvertO(sAPSelectShellToolbarMenuItemSearchToolbarElementIndex);
                sAPSelectShellToolbarMenuItempropCount++;
            }

            if (sAPSelectShellToolbarMenuItemSearchToolbarTextIsRegularExpression != null)
            {
                sAPSelectShellToolbarMenuItem["SearchToolbarTextIsRegularExpression"] = ExpressionConverter.ConvertO(sAPSelectShellToolbarMenuItemSearchToolbarTextIsRegularExpression);
                sAPSelectShellToolbarMenuItempropCount++;
            }

            if (sAPSelectShellToolbarMenuItemSearchToolbarTextIsCaseSensitive != null)
            {
                sAPSelectShellToolbarMenuItem["SearchToolbarTextIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPSelectShellToolbarMenuItemSearchToolbarTextIsCaseSensitive);
                sAPSelectShellToolbarMenuItempropCount++;
            }

            sAPSelectShellToolbarMenuItempropCount++;
            sAPSelectShellToolbarMenuItem["Workflow"] = ExpressionConverter.ConvertO(sAPSelectShellToolbarMenuItemWorkflow);
            if (sAPSelectShellToolbarMenuItempropCount > 0)
            {
                callPayload.Body = sAPSelectShellToolbarMenuItem;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetSAPGridViewPropertiesResponse> SAPGetSAPGridViewProperties(Expression<Func<string>> sAPGetSAPGridViewPropertiesSearchSAPElementId, Expression<Func<string>> sAPGetSAPGridViewPropertiesWorkflow)
        {
            var apiCallPath = "/SAPGUI/SAPGetSAPGridViewProperties";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPGetSAPGridViewProperties = new JObject();
            var sAPGetSAPGridViewPropertiespropCount = 0;
            sAPGetSAPGridViewPropertiespropCount++;
            sAPGetSAPGridViewProperties["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGetSAPGridViewPropertiesSearchSAPElementId);
            sAPGetSAPGridViewPropertiespropCount++;
            sAPGetSAPGridViewProperties["Workflow"] = ExpressionConverter.ConvertO(sAPGetSAPGridViewPropertiesWorkflow);
            if (sAPGetSAPGridViewPropertiespropCount > 0)
            {
                callPayload.Body = sAPGetSAPGridViewProperties;
            }

            return new ApiConnectionAction<SAPGetSAPGridViewPropertiesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetSAPGridViewCellContentsAtIndexResponse> SAPGetSAPGridViewCellContentsAtIndex(Expression<Func<string>> sAPGetSAPGridViewCellContentsAtIndexSearchSAPElementId, Expression<Func<int>> sAPGetSAPGridViewCellContentsAtIndexRowIndex, Expression<Func<string>> sAPGetSAPGridViewCellContentsAtIndexWorkflow, Expression<Func<string>> sAPGetSAPGridViewCellContentsAtIndexSearchColumnName = null, Expression<Func<string>> sAPGetSAPGridViewCellContentsAtIndexSearchColumnTitle = null, Expression<Func<bool>> sAPGetSAPGridViewCellContentsAtIndexSearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPGetSAPGridViewCellContentsAtIndexSearchColumnTitleIsCaseSensitive = null)
        {
            var apiCallPath = "/SAPGUI/SAPGetSAPGridViewCellContentsAtIndex";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPGetSAPGridViewCellContentsAtIndex = new JObject();
            var sAPGetSAPGridViewCellContentsAtIndexpropCount = 0;
            sAPGetSAPGridViewCellContentsAtIndexpropCount++;
            sAPGetSAPGridViewCellContentsAtIndex["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGetSAPGridViewCellContentsAtIndexSearchSAPElementId);
            sAPGetSAPGridViewCellContentsAtIndexpropCount++;
            sAPGetSAPGridViewCellContentsAtIndex["RowIndex"] = ExpressionConverter.ConvertO(sAPGetSAPGridViewCellContentsAtIndexRowIndex);
            if (sAPGetSAPGridViewCellContentsAtIndexSearchColumnName != null)
            {
                sAPGetSAPGridViewCellContentsAtIndex["SearchColumnName"] = ExpressionConverter.ConvertO(sAPGetSAPGridViewCellContentsAtIndexSearchColumnName);
                sAPGetSAPGridViewCellContentsAtIndexpropCount++;
            }

            if (sAPGetSAPGridViewCellContentsAtIndexSearchColumnTitle != null)
            {
                sAPGetSAPGridViewCellContentsAtIndex["SearchColumnTitle"] = ExpressionConverter.ConvertO(sAPGetSAPGridViewCellContentsAtIndexSearchColumnTitle);
                sAPGetSAPGridViewCellContentsAtIndexpropCount++;
            }

            if (sAPGetSAPGridViewCellContentsAtIndexSearchColumnTitleIsRegularExpression != null)
            {
                sAPGetSAPGridViewCellContentsAtIndex["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(sAPGetSAPGridViewCellContentsAtIndexSearchColumnTitleIsRegularExpression);
                sAPGetSAPGridViewCellContentsAtIndexpropCount++;
            }

            if (sAPGetSAPGridViewCellContentsAtIndexSearchColumnTitleIsCaseSensitive != null)
            {
                sAPGetSAPGridViewCellContentsAtIndex["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPGetSAPGridViewCellContentsAtIndexSearchColumnTitleIsCaseSensitive);
                sAPGetSAPGridViewCellContentsAtIndexpropCount++;
            }

            sAPGetSAPGridViewCellContentsAtIndexpropCount++;
            sAPGetSAPGridViewCellContentsAtIndex["Workflow"] = ExpressionConverter.ConvertO(sAPGetSAPGridViewCellContentsAtIndexWorkflow);
            if (sAPGetSAPGridViewCellContentsAtIndexpropCount > 0)
            {
                callPayload.Body = sAPGetSAPGridViewCellContentsAtIndex;
            }

            return new ApiConnectionAction<SAPGetSAPGridViewCellContentsAtIndexResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetSAPGridViewCellPropertiesAtIndexResponse> SAPGetSAPGridViewCellPropertiesAtIndex(Expression<Func<string>> sAPGetSAPGridViewCellPropertiesAtIndexSearchSAPElementId, Expression<Func<int>> sAPGetSAPGridViewCellPropertiesAtIndexRowIndex, Expression<Func<string>> sAPGetSAPGridViewCellPropertiesAtIndexWorkflow, Expression<Func<string>> sAPGetSAPGridViewCellPropertiesAtIndexSearchColumnName = null, Expression<Func<string>> sAPGetSAPGridViewCellPropertiesAtIndexSearchColumnTitle = null, Expression<Func<bool>> sAPGetSAPGridViewCellPropertiesAtIndexSearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPGetSAPGridViewCellPropertiesAtIndexSearchColumnTitleIsCaseSensitive = null)
        {
            var apiCallPath = "/SAPGUI/SAPGetSAPGridViewCellPropertiesAtIndex";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPGetSAPGridViewCellPropertiesAtIndex = new JObject();
            var sAPGetSAPGridViewCellPropertiesAtIndexpropCount = 0;
            sAPGetSAPGridViewCellPropertiesAtIndexpropCount++;
            sAPGetSAPGridViewCellPropertiesAtIndex["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGetSAPGridViewCellPropertiesAtIndexSearchSAPElementId);
            sAPGetSAPGridViewCellPropertiesAtIndexpropCount++;
            sAPGetSAPGridViewCellPropertiesAtIndex["RowIndex"] = ExpressionConverter.ConvertO(sAPGetSAPGridViewCellPropertiesAtIndexRowIndex);
            if (sAPGetSAPGridViewCellPropertiesAtIndexSearchColumnName != null)
            {
                sAPGetSAPGridViewCellPropertiesAtIndex["SearchColumnName"] = ExpressionConverter.ConvertO(sAPGetSAPGridViewCellPropertiesAtIndexSearchColumnName);
                sAPGetSAPGridViewCellPropertiesAtIndexpropCount++;
            }

            if (sAPGetSAPGridViewCellPropertiesAtIndexSearchColumnTitle != null)
            {
                sAPGetSAPGridViewCellPropertiesAtIndex["SearchColumnTitle"] = ExpressionConverter.ConvertO(sAPGetSAPGridViewCellPropertiesAtIndexSearchColumnTitle);
                sAPGetSAPGridViewCellPropertiesAtIndexpropCount++;
            }

            if (sAPGetSAPGridViewCellPropertiesAtIndexSearchColumnTitleIsRegularExpression != null)
            {
                sAPGetSAPGridViewCellPropertiesAtIndex["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(sAPGetSAPGridViewCellPropertiesAtIndexSearchColumnTitleIsRegularExpression);
                sAPGetSAPGridViewCellPropertiesAtIndexpropCount++;
            }

            if (sAPGetSAPGridViewCellPropertiesAtIndexSearchColumnTitleIsCaseSensitive != null)
            {
                sAPGetSAPGridViewCellPropertiesAtIndex["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPGetSAPGridViewCellPropertiesAtIndexSearchColumnTitleIsCaseSensitive);
                sAPGetSAPGridViewCellPropertiesAtIndexpropCount++;
            }

            sAPGetSAPGridViewCellPropertiesAtIndexpropCount++;
            sAPGetSAPGridViewCellPropertiesAtIndex["Workflow"] = ExpressionConverter.ConvertO(sAPGetSAPGridViewCellPropertiesAtIndexWorkflow);
            if (sAPGetSAPGridViewCellPropertiesAtIndexpropCount > 0)
            {
                callPayload.Body = sAPGetSAPGridViewCellPropertiesAtIndex;
            }

            return new ApiConnectionAction<SAPGetSAPGridViewCellPropertiesAtIndexResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPDrawRectangleAroundSAPGridViewCellAtIndex(Expression<Func<string>> sAPDrawRectangleAroundSAPGridViewCellAtIndexSearchSAPElementId, Expression<Func<int>> sAPDrawRectangleAroundSAPGridViewCellAtIndexRowIndex, Expression<Func<string>> sAPDrawRectangleAroundSAPGridViewCellAtIndexWorkflow, Expression<Func<string>> sAPDrawRectangleAroundSAPGridViewCellAtIndexSearchColumnName = null, Expression<Func<string>> sAPDrawRectangleAroundSAPGridViewCellAtIndexSearchColumnTitle = null, Expression<Func<bool>> sAPDrawRectangleAroundSAPGridViewCellAtIndexSearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPDrawRectangleAroundSAPGridViewCellAtIndexSearchColumnTitleIsCaseSensitive = null, Expression<Func<string>> sAPDrawRectangleAroundSAPGridViewCellAtIndexPenColour = null, Expression<Func<int>> sAPDrawRectangleAroundSAPGridViewCellAtIndexPenThicknessPixels = null)
        {
            var apiCallPath = "/SAPGUI/SAPDrawRectangleAroundSAPGridViewCellAtIndex";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPDrawRectangleAroundSAPGridViewCellAtIndex = new JObject();
            var sAPDrawRectangleAroundSAPGridViewCellAtIndexpropCount = 0;
            sAPDrawRectangleAroundSAPGridViewCellAtIndexpropCount++;
            sAPDrawRectangleAroundSAPGridViewCellAtIndex["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPDrawRectangleAroundSAPGridViewCellAtIndexSearchSAPElementId);
            sAPDrawRectangleAroundSAPGridViewCellAtIndexpropCount++;
            sAPDrawRectangleAroundSAPGridViewCellAtIndex["RowIndex"] = ExpressionConverter.ConvertO(sAPDrawRectangleAroundSAPGridViewCellAtIndexRowIndex);
            if (sAPDrawRectangleAroundSAPGridViewCellAtIndexSearchColumnName != null)
            {
                sAPDrawRectangleAroundSAPGridViewCellAtIndex["SearchColumnName"] = ExpressionConverter.ConvertO(sAPDrawRectangleAroundSAPGridViewCellAtIndexSearchColumnName);
                sAPDrawRectangleAroundSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPDrawRectangleAroundSAPGridViewCellAtIndexSearchColumnTitle != null)
            {
                sAPDrawRectangleAroundSAPGridViewCellAtIndex["SearchColumnTitle"] = ExpressionConverter.ConvertO(sAPDrawRectangleAroundSAPGridViewCellAtIndexSearchColumnTitle);
                sAPDrawRectangleAroundSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPDrawRectangleAroundSAPGridViewCellAtIndexSearchColumnTitleIsRegularExpression != null)
            {
                sAPDrawRectangleAroundSAPGridViewCellAtIndex["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(sAPDrawRectangleAroundSAPGridViewCellAtIndexSearchColumnTitleIsRegularExpression);
                sAPDrawRectangleAroundSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPDrawRectangleAroundSAPGridViewCellAtIndexSearchColumnTitleIsCaseSensitive != null)
            {
                sAPDrawRectangleAroundSAPGridViewCellAtIndex["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPDrawRectangleAroundSAPGridViewCellAtIndexSearchColumnTitleIsCaseSensitive);
                sAPDrawRectangleAroundSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPDrawRectangleAroundSAPGridViewCellAtIndexPenColour != null)
            {
                sAPDrawRectangleAroundSAPGridViewCellAtIndex["PenColour"] = ExpressionConverter.ConvertO(sAPDrawRectangleAroundSAPGridViewCellAtIndexPenColour);
                sAPDrawRectangleAroundSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPDrawRectangleAroundSAPGridViewCellAtIndexPenThicknessPixels != null)
            {
                sAPDrawRectangleAroundSAPGridViewCellAtIndex["PenThicknessPixels"] = ExpressionConverter.ConvertO(sAPDrawRectangleAroundSAPGridViewCellAtIndexPenThicknessPixels);
                sAPDrawRectangleAroundSAPGridViewCellAtIndexpropCount++;
            }

            sAPDrawRectangleAroundSAPGridViewCellAtIndexpropCount++;
            sAPDrawRectangleAroundSAPGridViewCellAtIndex["Workflow"] = ExpressionConverter.ConvertO(sAPDrawRectangleAroundSAPGridViewCellAtIndexWorkflow);
            if (sAPDrawRectangleAroundSAPGridViewCellAtIndexpropCount > 0)
            {
                callPayload.Body = sAPDrawRectangleAroundSAPGridViewCellAtIndex;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPGlobalLeftClickSAPGridViewCellAtIndex(Expression<Func<string>> sAPGlobalLeftClickSAPGridViewCellAtIndexSearchSAPElementId, Expression<Func<int>> sAPGlobalLeftClickSAPGridViewCellAtIndexRowIndex, Expression<Func<string>> sAPGlobalLeftClickSAPGridViewCellAtIndexWorkflow, Expression<Func<string>> sAPGlobalLeftClickSAPGridViewCellAtIndexSearchColumnName = null, Expression<Func<string>> sAPGlobalLeftClickSAPGridViewCellAtIndexSearchColumnTitle = null, Expression<Func<bool>> sAPGlobalLeftClickSAPGridViewCellAtIndexSearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPGlobalLeftClickSAPGridViewCellAtIndexSearchColumnTitleIsCaseSensitive = null, Expression<Func<bool>> sAPGlobalLeftClickSAPGridViewCellAtIndexSetElementWindowTopMost = null, Expression<Func<bool>> sAPGlobalLeftClickSAPGridViewCellAtIndexBringElementWindowToFront = null, Expression<Func<bool>> sAPGlobalLeftClickSAPGridViewCellAtIndexToggleWindow = null, Expression<Func<bool>> sAPGlobalLeftClickSAPGridViewCellAtIndexToggleUsesGlobalLeftMouseClickAgent = null, Expression<Func<double>> sAPGlobalLeftClickSAPGridViewCellAtIndexToggleDelay = null, Expression<Func<int>> sAPGlobalLeftClickSAPGridViewCellAtIndexClickOffsetX = null, Expression<Func<int>> sAPGlobalLeftClickSAPGridViewCellAtIndexClickOffsetY = null, Expression<Func<sAPGlobalLeftClickSAPGridViewCellAtIndexOffsetRelativeToInput>> sAPGlobalLeftClickSAPGridViewCellAtIndexOffsetRelativeTo = null)
        {
            var apiCallPath = "/SAPGUI/SAPGlobalLeftClickSAPGridViewCellAtIndex";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPGlobalLeftClickSAPGridViewCellAtIndex = new JObject();
            var sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount = 0;
            sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
            sAPGlobalLeftClickSAPGridViewCellAtIndex["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGlobalLeftClickSAPGridViewCellAtIndexSearchSAPElementId);
            sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
            sAPGlobalLeftClickSAPGridViewCellAtIndex["RowIndex"] = ExpressionConverter.ConvertO(sAPGlobalLeftClickSAPGridViewCellAtIndexRowIndex);
            if (sAPGlobalLeftClickSAPGridViewCellAtIndexSearchColumnName != null)
            {
                sAPGlobalLeftClickSAPGridViewCellAtIndex["SearchColumnName"] = ExpressionConverter.ConvertO(sAPGlobalLeftClickSAPGridViewCellAtIndexSearchColumnName);
                sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPGlobalLeftClickSAPGridViewCellAtIndexSearchColumnTitle != null)
            {
                sAPGlobalLeftClickSAPGridViewCellAtIndex["SearchColumnTitle"] = ExpressionConverter.ConvertO(sAPGlobalLeftClickSAPGridViewCellAtIndexSearchColumnTitle);
                sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPGlobalLeftClickSAPGridViewCellAtIndexSearchColumnTitleIsRegularExpression != null)
            {
                sAPGlobalLeftClickSAPGridViewCellAtIndex["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(sAPGlobalLeftClickSAPGridViewCellAtIndexSearchColumnTitleIsRegularExpression);
                sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPGlobalLeftClickSAPGridViewCellAtIndexSearchColumnTitleIsCaseSensitive != null)
            {
                sAPGlobalLeftClickSAPGridViewCellAtIndex["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPGlobalLeftClickSAPGridViewCellAtIndexSearchColumnTitleIsCaseSensitive);
                sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPGlobalLeftClickSAPGridViewCellAtIndexSetElementWindowTopMost != null)
            {
                sAPGlobalLeftClickSAPGridViewCellAtIndex["SetElementWindowTopMost"] = ExpressionConverter.ConvertO(sAPGlobalLeftClickSAPGridViewCellAtIndexSetElementWindowTopMost);
                sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPGlobalLeftClickSAPGridViewCellAtIndexBringElementWindowToFront != null)
            {
                sAPGlobalLeftClickSAPGridViewCellAtIndex["BringElementWindowToFront"] = ExpressionConverter.ConvertO(sAPGlobalLeftClickSAPGridViewCellAtIndexBringElementWindowToFront);
                sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPGlobalLeftClickSAPGridViewCellAtIndexToggleWindow != null)
            {
                sAPGlobalLeftClickSAPGridViewCellAtIndex["ToggleWindow"] = ExpressionConverter.ConvertO(sAPGlobalLeftClickSAPGridViewCellAtIndexToggleWindow);
                sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPGlobalLeftClickSAPGridViewCellAtIndexToggleUsesGlobalLeftMouseClickAgent != null)
            {
                sAPGlobalLeftClickSAPGridViewCellAtIndex["ToggleUsesGlobalLeftMouseClickAgent"] = ExpressionConverter.ConvertO(sAPGlobalLeftClickSAPGridViewCellAtIndexToggleUsesGlobalLeftMouseClickAgent);
                sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPGlobalLeftClickSAPGridViewCellAtIndexToggleDelay != null)
            {
                sAPGlobalLeftClickSAPGridViewCellAtIndex["ToggleDelay"] = ExpressionConverter.ConvertO(sAPGlobalLeftClickSAPGridViewCellAtIndexToggleDelay);
                sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPGlobalLeftClickSAPGridViewCellAtIndexClickOffsetX != null)
            {
                sAPGlobalLeftClickSAPGridViewCellAtIndex["ClickOffsetX"] = ExpressionConverter.ConvertO(sAPGlobalLeftClickSAPGridViewCellAtIndexClickOffsetX);
                sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPGlobalLeftClickSAPGridViewCellAtIndexClickOffsetY != null)
            {
                sAPGlobalLeftClickSAPGridViewCellAtIndex["ClickOffsetY"] = ExpressionConverter.ConvertO(sAPGlobalLeftClickSAPGridViewCellAtIndexClickOffsetY);
                sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPGlobalLeftClickSAPGridViewCellAtIndexOffsetRelativeTo != null)
            {
                sAPGlobalLeftClickSAPGridViewCellAtIndex["OffsetRelativeTo"] = ExpressionConverter.ConvertO(sAPGlobalLeftClickSAPGridViewCellAtIndexOffsetRelativeTo);
                sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
            }

            sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
            sAPGlobalLeftClickSAPGridViewCellAtIndex["Workflow"] = ExpressionConverter.ConvertO(sAPGlobalLeftClickSAPGridViewCellAtIndexWorkflow);
            if (sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount > 0)
            {
                callPayload.Body = sAPGlobalLeftClickSAPGridViewCellAtIndex;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPGlobalRightClickSAPGridViewCellAtIndex(Expression<Func<string>> sAPGlobalRightClickSAPGridViewCellAtIndexSearchSAPElementId, Expression<Func<int>> sAPGlobalRightClickSAPGridViewCellAtIndexRowIndex, Expression<Func<string>> sAPGlobalRightClickSAPGridViewCellAtIndexWorkflow, Expression<Func<string>> sAPGlobalRightClickSAPGridViewCellAtIndexSearchColumnName = null, Expression<Func<string>> sAPGlobalRightClickSAPGridViewCellAtIndexSearchColumnTitle = null, Expression<Func<bool>> sAPGlobalRightClickSAPGridViewCellAtIndexSearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPGlobalRightClickSAPGridViewCellAtIndexSearchColumnTitleIsCaseSensitive = null, Expression<Func<bool>> sAPGlobalRightClickSAPGridViewCellAtIndexSetElementWindowTopMost = null, Expression<Func<bool>> sAPGlobalRightClickSAPGridViewCellAtIndexBringElementWindowToFront = null, Expression<Func<bool>> sAPGlobalRightClickSAPGridViewCellAtIndexToggleWindow = null, Expression<Func<bool>> sAPGlobalRightClickSAPGridViewCellAtIndexToggleUsesGlobalLeftMouseClickAgent = null, Expression<Func<double>> sAPGlobalRightClickSAPGridViewCellAtIndexToggleDelay = null, Expression<Func<int>> sAPGlobalRightClickSAPGridViewCellAtIndexClickOffsetX = null, Expression<Func<int>> sAPGlobalRightClickSAPGridViewCellAtIndexClickOffsetY = null, Expression<Func<sAPGlobalRightClickSAPGridViewCellAtIndexOffsetRelativeToInput>> sAPGlobalRightClickSAPGridViewCellAtIndexOffsetRelativeTo = null)
        {
            var apiCallPath = "/SAPGUI/SAPGlobalRightClickSAPGridViewCellAtIndex";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPGlobalRightClickSAPGridViewCellAtIndex = new JObject();
            var sAPGlobalRightClickSAPGridViewCellAtIndexpropCount = 0;
            sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
            sAPGlobalRightClickSAPGridViewCellAtIndex["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGlobalRightClickSAPGridViewCellAtIndexSearchSAPElementId);
            sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
            sAPGlobalRightClickSAPGridViewCellAtIndex["RowIndex"] = ExpressionConverter.ConvertO(sAPGlobalRightClickSAPGridViewCellAtIndexRowIndex);
            if (sAPGlobalRightClickSAPGridViewCellAtIndexSearchColumnName != null)
            {
                sAPGlobalRightClickSAPGridViewCellAtIndex["SearchColumnName"] = ExpressionConverter.ConvertO(sAPGlobalRightClickSAPGridViewCellAtIndexSearchColumnName);
                sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPGlobalRightClickSAPGridViewCellAtIndexSearchColumnTitle != null)
            {
                sAPGlobalRightClickSAPGridViewCellAtIndex["SearchColumnTitle"] = ExpressionConverter.ConvertO(sAPGlobalRightClickSAPGridViewCellAtIndexSearchColumnTitle);
                sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPGlobalRightClickSAPGridViewCellAtIndexSearchColumnTitleIsRegularExpression != null)
            {
                sAPGlobalRightClickSAPGridViewCellAtIndex["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(sAPGlobalRightClickSAPGridViewCellAtIndexSearchColumnTitleIsRegularExpression);
                sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPGlobalRightClickSAPGridViewCellAtIndexSearchColumnTitleIsCaseSensitive != null)
            {
                sAPGlobalRightClickSAPGridViewCellAtIndex["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPGlobalRightClickSAPGridViewCellAtIndexSearchColumnTitleIsCaseSensitive);
                sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPGlobalRightClickSAPGridViewCellAtIndexSetElementWindowTopMost != null)
            {
                sAPGlobalRightClickSAPGridViewCellAtIndex["SetElementWindowTopMost"] = ExpressionConverter.ConvertO(sAPGlobalRightClickSAPGridViewCellAtIndexSetElementWindowTopMost);
                sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPGlobalRightClickSAPGridViewCellAtIndexBringElementWindowToFront != null)
            {
                sAPGlobalRightClickSAPGridViewCellAtIndex["BringElementWindowToFront"] = ExpressionConverter.ConvertO(sAPGlobalRightClickSAPGridViewCellAtIndexBringElementWindowToFront);
                sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPGlobalRightClickSAPGridViewCellAtIndexToggleWindow != null)
            {
                sAPGlobalRightClickSAPGridViewCellAtIndex["ToggleWindow"] = ExpressionConverter.ConvertO(sAPGlobalRightClickSAPGridViewCellAtIndexToggleWindow);
                sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPGlobalRightClickSAPGridViewCellAtIndexToggleUsesGlobalLeftMouseClickAgent != null)
            {
                sAPGlobalRightClickSAPGridViewCellAtIndex["ToggleUsesGlobalLeftMouseClickAgent"] = ExpressionConverter.ConvertO(sAPGlobalRightClickSAPGridViewCellAtIndexToggleUsesGlobalLeftMouseClickAgent);
                sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPGlobalRightClickSAPGridViewCellAtIndexToggleDelay != null)
            {
                sAPGlobalRightClickSAPGridViewCellAtIndex["ToggleDelay"] = ExpressionConverter.ConvertO(sAPGlobalRightClickSAPGridViewCellAtIndexToggleDelay);
                sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPGlobalRightClickSAPGridViewCellAtIndexClickOffsetX != null)
            {
                sAPGlobalRightClickSAPGridViewCellAtIndex["ClickOffsetX"] = ExpressionConverter.ConvertO(sAPGlobalRightClickSAPGridViewCellAtIndexClickOffsetX);
                sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPGlobalRightClickSAPGridViewCellAtIndexClickOffsetY != null)
            {
                sAPGlobalRightClickSAPGridViewCellAtIndex["ClickOffsetY"] = ExpressionConverter.ConvertO(sAPGlobalRightClickSAPGridViewCellAtIndexClickOffsetY);
                sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPGlobalRightClickSAPGridViewCellAtIndexOffsetRelativeTo != null)
            {
                sAPGlobalRightClickSAPGridViewCellAtIndex["OffsetRelativeTo"] = ExpressionConverter.ConvertO(sAPGlobalRightClickSAPGridViewCellAtIndexOffsetRelativeTo);
                sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
            }

            sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
            sAPGlobalRightClickSAPGridViewCellAtIndex["Workflow"] = ExpressionConverter.ConvertO(sAPGlobalRightClickSAPGridViewCellAtIndexWorkflow);
            if (sAPGlobalRightClickSAPGridViewCellAtIndexpropCount > 0)
            {
                callPayload.Body = sAPGlobalRightClickSAPGridViewCellAtIndex;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPGlobalDoubleLeftClickSAPGridViewCellAtIndex(Expression<Func<string>> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexSearchSAPElementId, Expression<Func<int>> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexRowIndex, Expression<Func<string>> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexWorkflow, Expression<Func<string>> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexSearchColumnName = null, Expression<Func<string>> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexSearchColumnTitle = null, Expression<Func<bool>> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexSearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexSearchColumnTitleIsCaseSensitive = null, Expression<Func<bool>> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexSetElementWindowTopMost = null, Expression<Func<bool>> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexBringElementWindowToFront = null, Expression<Func<bool>> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexToggleWindow = null, Expression<Func<bool>> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexToggleUsesGlobalLeftMouseClickAgent = null, Expression<Func<double>> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexToggleDelay = null, Expression<Func<int>> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexClickOffsetX = null, Expression<Func<int>> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexClickOffsetY = null, Expression<Func<sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexOffsetRelativeToInput>> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexOffsetRelativeTo = null, Expression<Func<int>> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexDoubleClickDelayInMilliseconds = null)
        {
            var apiCallPath = "/SAPGUI/SAPGlobalDoubleLeftClickSAPGridViewCellAtIndex";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex = new JObject();
            var sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount = 0;
            sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
            sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexSearchSAPElementId);
            sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
            sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["RowIndex"] = ExpressionConverter.ConvertO(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexRowIndex);
            if (sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexSearchColumnName != null)
            {
                sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["SearchColumnName"] = ExpressionConverter.ConvertO(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexSearchColumnName);
                sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexSearchColumnTitle != null)
            {
                sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["SearchColumnTitle"] = ExpressionConverter.ConvertO(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexSearchColumnTitle);
                sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexSearchColumnTitleIsRegularExpression != null)
            {
                sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexSearchColumnTitleIsRegularExpression);
                sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexSearchColumnTitleIsCaseSensitive != null)
            {
                sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexSearchColumnTitleIsCaseSensitive);
                sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexSetElementWindowTopMost != null)
            {
                sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["SetElementWindowTopMost"] = ExpressionConverter.ConvertO(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexSetElementWindowTopMost);
                sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexBringElementWindowToFront != null)
            {
                sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["BringElementWindowToFront"] = ExpressionConverter.ConvertO(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexBringElementWindowToFront);
                sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexToggleWindow != null)
            {
                sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["ToggleWindow"] = ExpressionConverter.ConvertO(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexToggleWindow);
                sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexToggleUsesGlobalLeftMouseClickAgent != null)
            {
                sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["ToggleUsesGlobalLeftMouseClickAgent"] = ExpressionConverter.ConvertO(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexToggleUsesGlobalLeftMouseClickAgent);
                sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexToggleDelay != null)
            {
                sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["ToggleDelay"] = ExpressionConverter.ConvertO(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexToggleDelay);
                sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexClickOffsetX != null)
            {
                sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["ClickOffsetX"] = ExpressionConverter.ConvertO(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexClickOffsetX);
                sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexClickOffsetY != null)
            {
                sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["ClickOffsetY"] = ExpressionConverter.ConvertO(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexClickOffsetY);
                sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexOffsetRelativeTo != null)
            {
                sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["OffsetRelativeTo"] = ExpressionConverter.ConvertO(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexOffsetRelativeTo);
                sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexDoubleClickDelayInMilliseconds != null)
            {
                sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["DoubleClickDelayInMilliseconds"] = ExpressionConverter.ConvertO(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexDoubleClickDelayInMilliseconds);
                sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
            }

            sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
            sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["Workflow"] = ExpressionConverter.ConvertO(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexWorkflow);
            if (sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount > 0)
            {
                callPayload.Body = sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetSAPGridViewColumnHeadersResponse> SAPGetSAPGridViewColumnHeaders(Expression<Func<string>> sAPGetSAPGridViewColumnHeadersSearchSAPElementId, Expression<Func<string>> sAPGetSAPGridViewColumnHeadersWorkflow)
        {
            var apiCallPath = "/SAPGUI/SAPGetSAPGridViewColumnHeaders";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPGetSAPGridViewColumnHeaders = new JObject();
            var sAPGetSAPGridViewColumnHeaderspropCount = 0;
            sAPGetSAPGridViewColumnHeaderspropCount++;
            sAPGetSAPGridViewColumnHeaders["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGetSAPGridViewColumnHeadersSearchSAPElementId);
            sAPGetSAPGridViewColumnHeaderspropCount++;
            sAPGetSAPGridViewColumnHeaders["Workflow"] = ExpressionConverter.ConvertO(sAPGetSAPGridViewColumnHeadersWorkflow);
            if (sAPGetSAPGridViewColumnHeaderspropCount > 0)
            {
                callPayload.Body = sAPGetSAPGridViewColumnHeaders;
            }

            return new ApiConnectionAction<SAPGetSAPGridViewColumnHeadersResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPClickSAPGridViewCellAtIndex(Expression<Func<string>> sAPClickSAPGridViewCellAtIndexSearchSAPElementId, Expression<Func<int>> sAPClickSAPGridViewCellAtIndexRowIndex, Expression<Func<string>> sAPClickSAPGridViewCellAtIndexWorkflow, Expression<Func<string>> sAPClickSAPGridViewCellAtIndexSearchColumnName = null, Expression<Func<string>> sAPClickSAPGridViewCellAtIndexSearchColumnTitle = null, Expression<Func<bool>> sAPClickSAPGridViewCellAtIndexSearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPClickSAPGridViewCellAtIndexSearchColumnTitleIsCaseSensitive = null)
        {
            var apiCallPath = "/SAPGUI/SAPClickSAPGridViewCellAtIndex";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPClickSAPGridViewCellAtIndex = new JObject();
            var sAPClickSAPGridViewCellAtIndexpropCount = 0;
            sAPClickSAPGridViewCellAtIndexpropCount++;
            sAPClickSAPGridViewCellAtIndex["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPClickSAPGridViewCellAtIndexSearchSAPElementId);
            sAPClickSAPGridViewCellAtIndexpropCount++;
            sAPClickSAPGridViewCellAtIndex["RowIndex"] = ExpressionConverter.ConvertO(sAPClickSAPGridViewCellAtIndexRowIndex);
            if (sAPClickSAPGridViewCellAtIndexSearchColumnName != null)
            {
                sAPClickSAPGridViewCellAtIndex["SearchColumnName"] = ExpressionConverter.ConvertO(sAPClickSAPGridViewCellAtIndexSearchColumnName);
                sAPClickSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPClickSAPGridViewCellAtIndexSearchColumnTitle != null)
            {
                sAPClickSAPGridViewCellAtIndex["SearchColumnTitle"] = ExpressionConverter.ConvertO(sAPClickSAPGridViewCellAtIndexSearchColumnTitle);
                sAPClickSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPClickSAPGridViewCellAtIndexSearchColumnTitleIsRegularExpression != null)
            {
                sAPClickSAPGridViewCellAtIndex["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(sAPClickSAPGridViewCellAtIndexSearchColumnTitleIsRegularExpression);
                sAPClickSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPClickSAPGridViewCellAtIndexSearchColumnTitleIsCaseSensitive != null)
            {
                sAPClickSAPGridViewCellAtIndex["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPClickSAPGridViewCellAtIndexSearchColumnTitleIsCaseSensitive);
                sAPClickSAPGridViewCellAtIndexpropCount++;
            }

            sAPClickSAPGridViewCellAtIndexpropCount++;
            sAPClickSAPGridViewCellAtIndex["Workflow"] = ExpressionConverter.ConvertO(sAPClickSAPGridViewCellAtIndexWorkflow);
            if (sAPClickSAPGridViewCellAtIndexpropCount > 0)
            {
                callPayload.Body = sAPClickSAPGridViewCellAtIndex;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPDoubleClickSAPGridViewCellAtIndex(Expression<Func<string>> sAPDoubleClickSAPGridViewCellAtIndexSearchSAPElementId, Expression<Func<int>> sAPDoubleClickSAPGridViewCellAtIndexRowIndex, Expression<Func<string>> sAPDoubleClickSAPGridViewCellAtIndexWorkflow, Expression<Func<string>> sAPDoubleClickSAPGridViewCellAtIndexSearchColumnName = null, Expression<Func<string>> sAPDoubleClickSAPGridViewCellAtIndexSearchColumnTitle = null, Expression<Func<bool>> sAPDoubleClickSAPGridViewCellAtIndexSearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPDoubleClickSAPGridViewCellAtIndexSearchColumnTitleIsCaseSensitive = null)
        {
            var apiCallPath = "/SAPGUI/SAPDoubleClickSAPGridViewCellAtIndex";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPDoubleClickSAPGridViewCellAtIndex = new JObject();
            var sAPDoubleClickSAPGridViewCellAtIndexpropCount = 0;
            sAPDoubleClickSAPGridViewCellAtIndexpropCount++;
            sAPDoubleClickSAPGridViewCellAtIndex["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPDoubleClickSAPGridViewCellAtIndexSearchSAPElementId);
            sAPDoubleClickSAPGridViewCellAtIndexpropCount++;
            sAPDoubleClickSAPGridViewCellAtIndex["RowIndex"] = ExpressionConverter.ConvertO(sAPDoubleClickSAPGridViewCellAtIndexRowIndex);
            if (sAPDoubleClickSAPGridViewCellAtIndexSearchColumnName != null)
            {
                sAPDoubleClickSAPGridViewCellAtIndex["SearchColumnName"] = ExpressionConverter.ConvertO(sAPDoubleClickSAPGridViewCellAtIndexSearchColumnName);
                sAPDoubleClickSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPDoubleClickSAPGridViewCellAtIndexSearchColumnTitle != null)
            {
                sAPDoubleClickSAPGridViewCellAtIndex["SearchColumnTitle"] = ExpressionConverter.ConvertO(sAPDoubleClickSAPGridViewCellAtIndexSearchColumnTitle);
                sAPDoubleClickSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPDoubleClickSAPGridViewCellAtIndexSearchColumnTitleIsRegularExpression != null)
            {
                sAPDoubleClickSAPGridViewCellAtIndex["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(sAPDoubleClickSAPGridViewCellAtIndexSearchColumnTitleIsRegularExpression);
                sAPDoubleClickSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPDoubleClickSAPGridViewCellAtIndexSearchColumnTitleIsCaseSensitive != null)
            {
                sAPDoubleClickSAPGridViewCellAtIndex["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPDoubleClickSAPGridViewCellAtIndexSearchColumnTitleIsCaseSensitive);
                sAPDoubleClickSAPGridViewCellAtIndexpropCount++;
            }

            sAPDoubleClickSAPGridViewCellAtIndexpropCount++;
            sAPDoubleClickSAPGridViewCellAtIndex["Workflow"] = ExpressionConverter.ConvertO(sAPDoubleClickSAPGridViewCellAtIndexWorkflow);
            if (sAPDoubleClickSAPGridViewCellAtIndexpropCount > 0)
            {
                callPayload.Body = sAPDoubleClickSAPGridViewCellAtIndex;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPPressSAPGridViewCellButtonAtIndex(Expression<Func<string>> sAPPressSAPGridViewCellButtonAtIndexSearchSAPElementId, Expression<Func<int>> sAPPressSAPGridViewCellButtonAtIndexRowIndex, Expression<Func<string>> sAPPressSAPGridViewCellButtonAtIndexWorkflow, Expression<Func<string>> sAPPressSAPGridViewCellButtonAtIndexSearchColumnName = null, Expression<Func<string>> sAPPressSAPGridViewCellButtonAtIndexSearchColumnTitle = null, Expression<Func<bool>> sAPPressSAPGridViewCellButtonAtIndexSearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPPressSAPGridViewCellButtonAtIndexSearchColumnTitleIsCaseSensitive = null)
        {
            var apiCallPath = "/SAPGUI/SAPPressSAPGridViewCellButtonAtIndex";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPPressSAPGridViewCellButtonAtIndex = new JObject();
            var sAPPressSAPGridViewCellButtonAtIndexpropCount = 0;
            sAPPressSAPGridViewCellButtonAtIndexpropCount++;
            sAPPressSAPGridViewCellButtonAtIndex["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPPressSAPGridViewCellButtonAtIndexSearchSAPElementId);
            sAPPressSAPGridViewCellButtonAtIndexpropCount++;
            sAPPressSAPGridViewCellButtonAtIndex["RowIndex"] = ExpressionConverter.ConvertO(sAPPressSAPGridViewCellButtonAtIndexRowIndex);
            if (sAPPressSAPGridViewCellButtonAtIndexSearchColumnName != null)
            {
                sAPPressSAPGridViewCellButtonAtIndex["SearchColumnName"] = ExpressionConverter.ConvertO(sAPPressSAPGridViewCellButtonAtIndexSearchColumnName);
                sAPPressSAPGridViewCellButtonAtIndexpropCount++;
            }

            if (sAPPressSAPGridViewCellButtonAtIndexSearchColumnTitle != null)
            {
                sAPPressSAPGridViewCellButtonAtIndex["SearchColumnTitle"] = ExpressionConverter.ConvertO(sAPPressSAPGridViewCellButtonAtIndexSearchColumnTitle);
                sAPPressSAPGridViewCellButtonAtIndexpropCount++;
            }

            if (sAPPressSAPGridViewCellButtonAtIndexSearchColumnTitleIsRegularExpression != null)
            {
                sAPPressSAPGridViewCellButtonAtIndex["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(sAPPressSAPGridViewCellButtonAtIndexSearchColumnTitleIsRegularExpression);
                sAPPressSAPGridViewCellButtonAtIndexpropCount++;
            }

            if (sAPPressSAPGridViewCellButtonAtIndexSearchColumnTitleIsCaseSensitive != null)
            {
                sAPPressSAPGridViewCellButtonAtIndex["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPPressSAPGridViewCellButtonAtIndexSearchColumnTitleIsCaseSensitive);
                sAPPressSAPGridViewCellButtonAtIndexpropCount++;
            }

            sAPPressSAPGridViewCellButtonAtIndexpropCount++;
            sAPPressSAPGridViewCellButtonAtIndex["Workflow"] = ExpressionConverter.ConvertO(sAPPressSAPGridViewCellButtonAtIndexWorkflow);
            if (sAPPressSAPGridViewCellButtonAtIndexpropCount > 0)
            {
                callPayload.Body = sAPPressSAPGridViewCellButtonAtIndex;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPCheckSAPGridViewCellCheckboxAtIndex(Expression<Func<string>> sAPCheckSAPGridViewCellCheckboxAtIndexSearchSAPElementId, Expression<Func<int>> sAPCheckSAPGridViewCellCheckboxAtIndexRowIndex, Expression<Func<string>> sAPCheckSAPGridViewCellCheckboxAtIndexWorkflow, Expression<Func<string>> sAPCheckSAPGridViewCellCheckboxAtIndexSearchColumnName = null, Expression<Func<string>> sAPCheckSAPGridViewCellCheckboxAtIndexSearchColumnTitle = null, Expression<Func<bool>> sAPCheckSAPGridViewCellCheckboxAtIndexSearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPCheckSAPGridViewCellCheckboxAtIndexSearchColumnTitleIsCaseSensitive = null, Expression<Func<bool>> sAPCheckSAPGridViewCellCheckboxAtIndexCheckCellElement = null)
        {
            var apiCallPath = "/SAPGUI/SAPCheckSAPGridViewCellCheckboxAtIndex";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPCheckSAPGridViewCellCheckboxAtIndex = new JObject();
            var sAPCheckSAPGridViewCellCheckboxAtIndexpropCount = 0;
            sAPCheckSAPGridViewCellCheckboxAtIndexpropCount++;
            sAPCheckSAPGridViewCellCheckboxAtIndex["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPCheckSAPGridViewCellCheckboxAtIndexSearchSAPElementId);
            sAPCheckSAPGridViewCellCheckboxAtIndexpropCount++;
            sAPCheckSAPGridViewCellCheckboxAtIndex["RowIndex"] = ExpressionConverter.ConvertO(sAPCheckSAPGridViewCellCheckboxAtIndexRowIndex);
            if (sAPCheckSAPGridViewCellCheckboxAtIndexSearchColumnName != null)
            {
                sAPCheckSAPGridViewCellCheckboxAtIndex["SearchColumnName"] = ExpressionConverter.ConvertO(sAPCheckSAPGridViewCellCheckboxAtIndexSearchColumnName);
                sAPCheckSAPGridViewCellCheckboxAtIndexpropCount++;
            }

            if (sAPCheckSAPGridViewCellCheckboxAtIndexSearchColumnTitle != null)
            {
                sAPCheckSAPGridViewCellCheckboxAtIndex["SearchColumnTitle"] = ExpressionConverter.ConvertO(sAPCheckSAPGridViewCellCheckboxAtIndexSearchColumnTitle);
                sAPCheckSAPGridViewCellCheckboxAtIndexpropCount++;
            }

            if (sAPCheckSAPGridViewCellCheckboxAtIndexSearchColumnTitleIsRegularExpression != null)
            {
                sAPCheckSAPGridViewCellCheckboxAtIndex["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(sAPCheckSAPGridViewCellCheckboxAtIndexSearchColumnTitleIsRegularExpression);
                sAPCheckSAPGridViewCellCheckboxAtIndexpropCount++;
            }

            if (sAPCheckSAPGridViewCellCheckboxAtIndexSearchColumnTitleIsCaseSensitive != null)
            {
                sAPCheckSAPGridViewCellCheckboxAtIndex["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPCheckSAPGridViewCellCheckboxAtIndexSearchColumnTitleIsCaseSensitive);
                sAPCheckSAPGridViewCellCheckboxAtIndexpropCount++;
            }

            if (sAPCheckSAPGridViewCellCheckboxAtIndexCheckCellElement != null)
            {
                sAPCheckSAPGridViewCellCheckboxAtIndex["CheckCellElement"] = ExpressionConverter.ConvertO(sAPCheckSAPGridViewCellCheckboxAtIndexCheckCellElement);
                sAPCheckSAPGridViewCellCheckboxAtIndexpropCount++;
            }

            sAPCheckSAPGridViewCellCheckboxAtIndexpropCount++;
            sAPCheckSAPGridViewCellCheckboxAtIndex["Workflow"] = ExpressionConverter.ConvertO(sAPCheckSAPGridViewCellCheckboxAtIndexWorkflow);
            if (sAPCheckSAPGridViewCellCheckboxAtIndexpropCount > 0)
            {
                callPayload.Body = sAPCheckSAPGridViewCellCheckboxAtIndex;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPModifySAPGridViewCellAtIndexResponse> SAPModifySAPGridViewCellAtIndex(Expression<Func<string>> sAPModifySAPGridViewCellAtIndexSearchSAPElementId, Expression<Func<int>> sAPModifySAPGridViewCellAtIndexRowIndex, Expression<Func<string>> sAPModifySAPGridViewCellAtIndexWorkflow, Expression<Func<string>> sAPModifySAPGridViewCellAtIndexSearchColumnName = null, Expression<Func<string>> sAPModifySAPGridViewCellAtIndexSearchColumnTitle = null, Expression<Func<bool>> sAPModifySAPGridViewCellAtIndexSearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPModifySAPGridViewCellAtIndexSearchColumnTitleIsCaseSensitive = null, Expression<Func<string>> sAPModifySAPGridViewCellAtIndexNewValue = null)
        {
            var apiCallPath = "/SAPGUI/SAPModifySAPGridViewCellAtIndex";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPModifySAPGridViewCellAtIndex = new JObject();
            var sAPModifySAPGridViewCellAtIndexpropCount = 0;
            sAPModifySAPGridViewCellAtIndexpropCount++;
            sAPModifySAPGridViewCellAtIndex["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPModifySAPGridViewCellAtIndexSearchSAPElementId);
            sAPModifySAPGridViewCellAtIndexpropCount++;
            sAPModifySAPGridViewCellAtIndex["RowIndex"] = ExpressionConverter.ConvertO(sAPModifySAPGridViewCellAtIndexRowIndex);
            if (sAPModifySAPGridViewCellAtIndexSearchColumnName != null)
            {
                sAPModifySAPGridViewCellAtIndex["SearchColumnName"] = ExpressionConverter.ConvertO(sAPModifySAPGridViewCellAtIndexSearchColumnName);
                sAPModifySAPGridViewCellAtIndexpropCount++;
            }

            if (sAPModifySAPGridViewCellAtIndexSearchColumnTitle != null)
            {
                sAPModifySAPGridViewCellAtIndex["SearchColumnTitle"] = ExpressionConverter.ConvertO(sAPModifySAPGridViewCellAtIndexSearchColumnTitle);
                sAPModifySAPGridViewCellAtIndexpropCount++;
            }

            if (sAPModifySAPGridViewCellAtIndexSearchColumnTitleIsRegularExpression != null)
            {
                sAPModifySAPGridViewCellAtIndex["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(sAPModifySAPGridViewCellAtIndexSearchColumnTitleIsRegularExpression);
                sAPModifySAPGridViewCellAtIndexpropCount++;
            }

            if (sAPModifySAPGridViewCellAtIndexSearchColumnTitleIsCaseSensitive != null)
            {
                sAPModifySAPGridViewCellAtIndex["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPModifySAPGridViewCellAtIndexSearchColumnTitleIsCaseSensitive);
                sAPModifySAPGridViewCellAtIndexpropCount++;
            }

            if (sAPModifySAPGridViewCellAtIndexNewValue != null)
            {
                sAPModifySAPGridViewCellAtIndex["NewValue"] = ExpressionConverter.ConvertO(sAPModifySAPGridViewCellAtIndexNewValue);
                sAPModifySAPGridViewCellAtIndexpropCount++;
            }

            sAPModifySAPGridViewCellAtIndexpropCount++;
            sAPModifySAPGridViewCellAtIndex["Workflow"] = ExpressionConverter.ConvertO(sAPModifySAPGridViewCellAtIndexWorkflow);
            if (sAPModifySAPGridViewCellAtIndexpropCount > 0)
            {
                callPayload.Body = sAPModifySAPGridViewCellAtIndex;
            }

            return new ApiConnectionAction<SAPModifySAPGridViewCellAtIndexResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPSetSAPGridViewCurrentRow(Expression<Func<string>> sAPSetSAPGridViewCurrentRowSearchSAPElementId, Expression<Func<int>> sAPSetSAPGridViewCurrentRowRowIndex, Expression<Func<string>> sAPSetSAPGridViewCurrentRowWorkflow)
        {
            var apiCallPath = "/SAPGUI/SAPSetSAPGridViewCurrentRow";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPSetSAPGridViewCurrentRow = new JObject();
            var sAPSetSAPGridViewCurrentRowpropCount = 0;
            sAPSetSAPGridViewCurrentRowpropCount++;
            sAPSetSAPGridViewCurrentRow["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPSetSAPGridViewCurrentRowSearchSAPElementId);
            sAPSetSAPGridViewCurrentRowpropCount++;
            sAPSetSAPGridViewCurrentRow["RowIndex"] = ExpressionConverter.ConvertO(sAPSetSAPGridViewCurrentRowRowIndex);
            sAPSetSAPGridViewCurrentRowpropCount++;
            sAPSetSAPGridViewCurrentRow["Workflow"] = ExpressionConverter.ConvertO(sAPSetSAPGridViewCurrentRowWorkflow);
            if (sAPSetSAPGridViewCurrentRowpropCount > 0)
            {
                callPayload.Body = sAPSetSAPGridViewCurrentRow;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPPressSAPGridViewColumnHeader(Expression<Func<string>> sAPPressSAPGridViewColumnHeaderSearchSAPElementId, Expression<Func<string>> sAPPressSAPGridViewColumnHeaderWorkflow, Expression<Func<string>> sAPPressSAPGridViewColumnHeaderSearchColumnName = null, Expression<Func<string>> sAPPressSAPGridViewColumnHeaderSearchColumnTitle = null, Expression<Func<bool>> sAPPressSAPGridViewColumnHeaderSearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPPressSAPGridViewColumnHeaderSearchColumnTitleIsCaseSensitive = null)
        {
            var apiCallPath = "/SAPGUI/SAPPressSAPGridViewColumnHeader";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPPressSAPGridViewColumnHeader = new JObject();
            var sAPPressSAPGridViewColumnHeaderpropCount = 0;
            sAPPressSAPGridViewColumnHeaderpropCount++;
            sAPPressSAPGridViewColumnHeader["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPPressSAPGridViewColumnHeaderSearchSAPElementId);
            if (sAPPressSAPGridViewColumnHeaderSearchColumnName != null)
            {
                sAPPressSAPGridViewColumnHeader["SearchColumnName"] = ExpressionConverter.ConvertO(sAPPressSAPGridViewColumnHeaderSearchColumnName);
                sAPPressSAPGridViewColumnHeaderpropCount++;
            }

            if (sAPPressSAPGridViewColumnHeaderSearchColumnTitle != null)
            {
                sAPPressSAPGridViewColumnHeader["SearchColumnTitle"] = ExpressionConverter.ConvertO(sAPPressSAPGridViewColumnHeaderSearchColumnTitle);
                sAPPressSAPGridViewColumnHeaderpropCount++;
            }

            if (sAPPressSAPGridViewColumnHeaderSearchColumnTitleIsRegularExpression != null)
            {
                sAPPressSAPGridViewColumnHeader["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(sAPPressSAPGridViewColumnHeaderSearchColumnTitleIsRegularExpression);
                sAPPressSAPGridViewColumnHeaderpropCount++;
            }

            if (sAPPressSAPGridViewColumnHeaderSearchColumnTitleIsCaseSensitive != null)
            {
                sAPPressSAPGridViewColumnHeader["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPPressSAPGridViewColumnHeaderSearchColumnTitleIsCaseSensitive);
                sAPPressSAPGridViewColumnHeaderpropCount++;
            }

            sAPPressSAPGridViewColumnHeaderpropCount++;
            sAPPressSAPGridViewColumnHeader["Workflow"] = ExpressionConverter.ConvertO(sAPPressSAPGridViewColumnHeaderWorkflow);
            if (sAPPressSAPGridViewColumnHeaderpropCount > 0)
            {
                callPayload.Body = sAPPressSAPGridViewColumnHeader;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPSetSAPGridViewFirstVisibleRowResponse> SAPSetSAPGridViewFirstVisibleRow(Expression<Func<string>> sAPSetSAPGridViewFirstVisibleRowSearchSAPElementId, Expression<Func<int>> sAPSetSAPGridViewFirstVisibleRowFirstVisibleRowIndex, Expression<Func<string>> sAPSetSAPGridViewFirstVisibleRowWorkflow)
        {
            var apiCallPath = "/SAPGUI/SAPSetSAPGridViewFirstVisibleRow";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPSetSAPGridViewFirstVisibleRow = new JObject();
            var sAPSetSAPGridViewFirstVisibleRowpropCount = 0;
            sAPSetSAPGridViewFirstVisibleRowpropCount++;
            sAPSetSAPGridViewFirstVisibleRow["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPSetSAPGridViewFirstVisibleRowSearchSAPElementId);
            sAPSetSAPGridViewFirstVisibleRowpropCount++;
            sAPSetSAPGridViewFirstVisibleRow["FirstVisibleRowIndex"] = ExpressionConverter.ConvertO(sAPSetSAPGridViewFirstVisibleRowFirstVisibleRowIndex);
            sAPSetSAPGridViewFirstVisibleRowpropCount++;
            sAPSetSAPGridViewFirstVisibleRow["Workflow"] = ExpressionConverter.ConvertO(sAPSetSAPGridViewFirstVisibleRowWorkflow);
            if (sAPSetSAPGridViewFirstVisibleRowpropCount > 0)
            {
                callPayload.Body = sAPSetSAPGridViewFirstVisibleRow;
            }

            return new ApiConnectionAction<SAPSetSAPGridViewFirstVisibleRowResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPSelectSAPGridViewRow(Expression<Func<string>> sAPSelectSAPGridViewRowSearchSAPElementId, Expression<Func<int>> sAPSelectSAPGridViewRowRowIndex, Expression<Func<string>> sAPSelectSAPGridViewRowWorkflow, Expression<Func<bool>> sAPSelectSAPGridViewRowSetAsCurrentRow = null)
        {
            var apiCallPath = "/SAPGUI/SAPSelectSAPGridViewRow";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPSelectSAPGridViewRow = new JObject();
            var sAPSelectSAPGridViewRowpropCount = 0;
            sAPSelectSAPGridViewRowpropCount++;
            sAPSelectSAPGridViewRow["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPSelectSAPGridViewRowSearchSAPElementId);
            sAPSelectSAPGridViewRowpropCount++;
            sAPSelectSAPGridViewRow["RowIndex"] = ExpressionConverter.ConvertO(sAPSelectSAPGridViewRowRowIndex);
            if (sAPSelectSAPGridViewRowSetAsCurrentRow != null)
            {
                sAPSelectSAPGridViewRow["SetAsCurrentRow"] = ExpressionConverter.ConvertO(sAPSelectSAPGridViewRowSetAsCurrentRow);
                sAPSelectSAPGridViewRowpropCount++;
            }

            sAPSelectSAPGridViewRowpropCount++;
            sAPSelectSAPGridViewRow["Workflow"] = ExpressionConverter.ConvertO(sAPSelectSAPGridViewRowWorkflow);
            if (sAPSelectSAPGridViewRowpropCount > 0)
            {
                callPayload.Body = sAPSelectSAPGridViewRow;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPSelectSAPGridViewMultipleRows(Expression<Func<string>> sAPSelectSAPGridViewMultipleRowsSearchSAPElementId, Expression<Func<string>> sAPSelectSAPGridViewMultipleRowsRowsToSelect, Expression<Func<string>> sAPSelectSAPGridViewMultipleRowsWorkflow)
        {
            var apiCallPath = "/SAPGUI/SAPSelectSAPGridViewMultipleRows";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPSelectSAPGridViewMultipleRows = new JObject();
            var sAPSelectSAPGridViewMultipleRowspropCount = 0;
            sAPSelectSAPGridViewMultipleRowspropCount++;
            sAPSelectSAPGridViewMultipleRows["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPSelectSAPGridViewMultipleRowsSearchSAPElementId);
            sAPSelectSAPGridViewMultipleRowspropCount++;
            sAPSelectSAPGridViewMultipleRows["RowsToSelect"] = ExpressionConverter.ConvertO(sAPSelectSAPGridViewMultipleRowsRowsToSelect);
            sAPSelectSAPGridViewMultipleRowspropCount++;
            sAPSelectSAPGridViewMultipleRows["Workflow"] = ExpressionConverter.ConvertO(sAPSelectSAPGridViewMultipleRowsWorkflow);
            if (sAPSelectSAPGridViewMultipleRowspropCount > 0)
            {
                callPayload.Body = sAPSelectSAPGridViewMultipleRows;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPSetSAPGridViewCurrentColumn(Expression<Func<string>> sAPSetSAPGridViewCurrentColumnSearchSAPElementId, Expression<Func<string>> sAPSetSAPGridViewCurrentColumnWorkflow, Expression<Func<string>> sAPSetSAPGridViewCurrentColumnSearchColumnName = null, Expression<Func<string>> sAPSetSAPGridViewCurrentColumnSearchColumnTitle = null, Expression<Func<bool>> sAPSetSAPGridViewCurrentColumnSearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPSetSAPGridViewCurrentColumnSearchColumnTitleIsCaseSensitive = null)
        {
            var apiCallPath = "/SAPGUI/SAPSetSAPGridViewCurrentColumn";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPSetSAPGridViewCurrentColumn = new JObject();
            var sAPSetSAPGridViewCurrentColumnpropCount = 0;
            sAPSetSAPGridViewCurrentColumnpropCount++;
            sAPSetSAPGridViewCurrentColumn["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPSetSAPGridViewCurrentColumnSearchSAPElementId);
            if (sAPSetSAPGridViewCurrentColumnSearchColumnName != null)
            {
                sAPSetSAPGridViewCurrentColumn["SearchColumnName"] = ExpressionConverter.ConvertO(sAPSetSAPGridViewCurrentColumnSearchColumnName);
                sAPSetSAPGridViewCurrentColumnpropCount++;
            }

            if (sAPSetSAPGridViewCurrentColumnSearchColumnTitle != null)
            {
                sAPSetSAPGridViewCurrentColumn["SearchColumnTitle"] = ExpressionConverter.ConvertO(sAPSetSAPGridViewCurrentColumnSearchColumnTitle);
                sAPSetSAPGridViewCurrentColumnpropCount++;
            }

            if (sAPSetSAPGridViewCurrentColumnSearchColumnTitleIsRegularExpression != null)
            {
                sAPSetSAPGridViewCurrentColumn["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(sAPSetSAPGridViewCurrentColumnSearchColumnTitleIsRegularExpression);
                sAPSetSAPGridViewCurrentColumnpropCount++;
            }

            if (sAPSetSAPGridViewCurrentColumnSearchColumnTitleIsCaseSensitive != null)
            {
                sAPSetSAPGridViewCurrentColumn["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPSetSAPGridViewCurrentColumnSearchColumnTitleIsCaseSensitive);
                sAPSetSAPGridViewCurrentColumnpropCount++;
            }

            sAPSetSAPGridViewCurrentColumnpropCount++;
            sAPSetSAPGridViewCurrentColumn["Workflow"] = ExpressionConverter.ConvertO(sAPSetSAPGridViewCurrentColumnWorkflow);
            if (sAPSetSAPGridViewCurrentColumnpropCount > 0)
            {
                callPayload.Body = sAPSetSAPGridViewCurrentColumn;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPSetSAPGridViewCurrentCell(Expression<Func<string>> sAPSetSAPGridViewCurrentCellSearchSAPElementId, Expression<Func<int>> sAPSetSAPGridViewCurrentCellRowIndex, Expression<Func<string>> sAPSetSAPGridViewCurrentCellWorkflow, Expression<Func<string>> sAPSetSAPGridViewCurrentCellSearchColumnName = null, Expression<Func<string>> sAPSetSAPGridViewCurrentCellSearchColumnTitle = null, Expression<Func<bool>> sAPSetSAPGridViewCurrentCellSearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPSetSAPGridViewCurrentCellSearchColumnTitleIsCaseSensitive = null)
        {
            var apiCallPath = "/SAPGUI/SAPSetSAPGridViewCurrentCell";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPSetSAPGridViewCurrentCell = new JObject();
            var sAPSetSAPGridViewCurrentCellpropCount = 0;
            sAPSetSAPGridViewCurrentCellpropCount++;
            sAPSetSAPGridViewCurrentCell["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPSetSAPGridViewCurrentCellSearchSAPElementId);
            sAPSetSAPGridViewCurrentCellpropCount++;
            sAPSetSAPGridViewCurrentCell["RowIndex"] = ExpressionConverter.ConvertO(sAPSetSAPGridViewCurrentCellRowIndex);
            if (sAPSetSAPGridViewCurrentCellSearchColumnName != null)
            {
                sAPSetSAPGridViewCurrentCell["SearchColumnName"] = ExpressionConverter.ConvertO(sAPSetSAPGridViewCurrentCellSearchColumnName);
                sAPSetSAPGridViewCurrentCellpropCount++;
            }

            if (sAPSetSAPGridViewCurrentCellSearchColumnTitle != null)
            {
                sAPSetSAPGridViewCurrentCell["SearchColumnTitle"] = ExpressionConverter.ConvertO(sAPSetSAPGridViewCurrentCellSearchColumnTitle);
                sAPSetSAPGridViewCurrentCellpropCount++;
            }

            if (sAPSetSAPGridViewCurrentCellSearchColumnTitleIsRegularExpression != null)
            {
                sAPSetSAPGridViewCurrentCell["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(sAPSetSAPGridViewCurrentCellSearchColumnTitleIsRegularExpression);
                sAPSetSAPGridViewCurrentCellpropCount++;
            }

            if (sAPSetSAPGridViewCurrentCellSearchColumnTitleIsCaseSensitive != null)
            {
                sAPSetSAPGridViewCurrentCell["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPSetSAPGridViewCurrentCellSearchColumnTitleIsCaseSensitive);
                sAPSetSAPGridViewCurrentCellpropCount++;
            }

            sAPSetSAPGridViewCurrentCellpropCount++;
            sAPSetSAPGridViewCurrentCell["Workflow"] = ExpressionConverter.ConvertO(sAPSetSAPGridViewCurrentCellWorkflow);
            if (sAPSetSAPGridViewCurrentCellpropCount > 0)
            {
                callPayload.Body = sAPSetSAPGridViewCurrentCell;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPSelectSAPGridViewColumn(Expression<Func<string>> sAPSelectSAPGridViewColumnSearchSAPElementId, Expression<Func<string>> sAPSelectSAPGridViewColumnWorkflow, Expression<Func<string>> sAPSelectSAPGridViewColumnSearchColumnName = null, Expression<Func<string>> sAPSelectSAPGridViewColumnSearchColumnTitle = null, Expression<Func<bool>> sAPSelectSAPGridViewColumnSearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPSelectSAPGridViewColumnSearchColumnTitleIsCaseSensitive = null, Expression<Func<bool>> sAPSelectSAPGridViewColumnSelectColumn = null, Expression<Func<bool>> sAPSelectSAPGridViewColumnSetAsCurrentColumn = null, Expression<Func<bool>> sAPSelectSAPGridViewColumnClearSelectionFirst = null)
        {
            var apiCallPath = "/SAPGUI/SAPSelectSAPGridViewColumn";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPSelectSAPGridViewColumn = new JObject();
            var sAPSelectSAPGridViewColumnpropCount = 0;
            sAPSelectSAPGridViewColumnpropCount++;
            sAPSelectSAPGridViewColumn["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPSelectSAPGridViewColumnSearchSAPElementId);
            if (sAPSelectSAPGridViewColumnSearchColumnName != null)
            {
                sAPSelectSAPGridViewColumn["SearchColumnName"] = ExpressionConverter.ConvertO(sAPSelectSAPGridViewColumnSearchColumnName);
                sAPSelectSAPGridViewColumnpropCount++;
            }

            if (sAPSelectSAPGridViewColumnSearchColumnTitle != null)
            {
                sAPSelectSAPGridViewColumn["SearchColumnTitle"] = ExpressionConverter.ConvertO(sAPSelectSAPGridViewColumnSearchColumnTitle);
                sAPSelectSAPGridViewColumnpropCount++;
            }

            if (sAPSelectSAPGridViewColumnSearchColumnTitleIsRegularExpression != null)
            {
                sAPSelectSAPGridViewColumn["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(sAPSelectSAPGridViewColumnSearchColumnTitleIsRegularExpression);
                sAPSelectSAPGridViewColumnpropCount++;
            }

            if (sAPSelectSAPGridViewColumnSearchColumnTitleIsCaseSensitive != null)
            {
                sAPSelectSAPGridViewColumn["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPSelectSAPGridViewColumnSearchColumnTitleIsCaseSensitive);
                sAPSelectSAPGridViewColumnpropCount++;
            }

            if (sAPSelectSAPGridViewColumnSelectColumn != null)
            {
                sAPSelectSAPGridViewColumn["SelectColumn"] = ExpressionConverter.ConvertO(sAPSelectSAPGridViewColumnSelectColumn);
                sAPSelectSAPGridViewColumnpropCount++;
            }

            if (sAPSelectSAPGridViewColumnSetAsCurrentColumn != null)
            {
                sAPSelectSAPGridViewColumn["SetAsCurrentColumn"] = ExpressionConverter.ConvertO(sAPSelectSAPGridViewColumnSetAsCurrentColumn);
                sAPSelectSAPGridViewColumnpropCount++;
            }

            if (sAPSelectSAPGridViewColumnClearSelectionFirst != null)
            {
                sAPSelectSAPGridViewColumn["ClearSelectionFirst"] = ExpressionConverter.ConvertO(sAPSelectSAPGridViewColumnClearSelectionFirst);
                sAPSelectSAPGridViewColumnpropCount++;
            }

            sAPSelectSAPGridViewColumnpropCount++;
            sAPSelectSAPGridViewColumn["Workflow"] = ExpressionConverter.ConvertO(sAPSelectSAPGridViewColumnWorkflow);
            if (sAPSelectSAPGridViewColumnpropCount > 0)
            {
                callPayload.Body = sAPSelectSAPGridViewColumn;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPGridViewSelectAll(Expression<Func<string>> sAPGridViewSelectAllSearchSAPElementId, Expression<Func<string>> sAPGridViewSelectAllWorkflow)
        {
            var apiCallPath = "/SAPGUI/SAPGridViewSelectAll";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPGridViewSelectAll = new JObject();
            var sAPGridViewSelectAllpropCount = 0;
            sAPGridViewSelectAllpropCount++;
            sAPGridViewSelectAll["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGridViewSelectAllSearchSAPElementId);
            sAPGridViewSelectAllpropCount++;
            sAPGridViewSelectAll["Workflow"] = ExpressionConverter.ConvertO(sAPGridViewSelectAllWorkflow);
            if (sAPGridViewSelectAllpropCount > 0)
            {
                callPayload.Body = sAPGridViewSelectAll;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPGridViewDeselectAll(Expression<Func<string>> sAPGridViewDeselectAllSearchSAPElementId, Expression<Func<string>> sAPGridViewDeselectAllWorkflow)
        {
            var apiCallPath = "/SAPGUI/SAPGridViewDeselectAll";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPGridViewDeselectAll = new JObject();
            var sAPGridViewDeselectAllpropCount = 0;
            sAPGridViewDeselectAllpropCount++;
            sAPGridViewDeselectAll["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGridViewDeselectAllSearchSAPElementId);
            sAPGridViewDeselectAllpropCount++;
            sAPGridViewDeselectAll["Workflow"] = ExpressionConverter.ConvertO(sAPGridViewDeselectAllWorkflow);
            if (sAPGridViewDeselectAllpropCount > 0)
            {
                callPayload.Body = sAPGridViewDeselectAll;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPSetSAPGridViewFirstVisibleColumnResponse> SAPSetSAPGridViewFirstVisibleColumn(Expression<Func<string>> sAPSetSAPGridViewFirstVisibleColumnSearchSAPElementId, Expression<Func<string>> sAPSetSAPGridViewFirstVisibleColumnWorkflow, Expression<Func<string>> sAPSetSAPGridViewFirstVisibleColumnSearchColumnName = null, Expression<Func<string>> sAPSetSAPGridViewFirstVisibleColumnSearchColumnTitle = null, Expression<Func<bool>> sAPSetSAPGridViewFirstVisibleColumnSearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPSetSAPGridViewFirstVisibleColumnSearchColumnTitleIsCaseSensitive = null)
        {
            var apiCallPath = "/SAPGUI/SAPSetSAPGridViewFirstVisibleColumn";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPSetSAPGridViewFirstVisibleColumn = new JObject();
            var sAPSetSAPGridViewFirstVisibleColumnpropCount = 0;
            sAPSetSAPGridViewFirstVisibleColumnpropCount++;
            sAPSetSAPGridViewFirstVisibleColumn["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPSetSAPGridViewFirstVisibleColumnSearchSAPElementId);
            if (sAPSetSAPGridViewFirstVisibleColumnSearchColumnName != null)
            {
                sAPSetSAPGridViewFirstVisibleColumn["SearchColumnName"] = ExpressionConverter.ConvertO(sAPSetSAPGridViewFirstVisibleColumnSearchColumnName);
                sAPSetSAPGridViewFirstVisibleColumnpropCount++;
            }

            if (sAPSetSAPGridViewFirstVisibleColumnSearchColumnTitle != null)
            {
                sAPSetSAPGridViewFirstVisibleColumn["SearchColumnTitle"] = ExpressionConverter.ConvertO(sAPSetSAPGridViewFirstVisibleColumnSearchColumnTitle);
                sAPSetSAPGridViewFirstVisibleColumnpropCount++;
            }

            if (sAPSetSAPGridViewFirstVisibleColumnSearchColumnTitleIsRegularExpression != null)
            {
                sAPSetSAPGridViewFirstVisibleColumn["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(sAPSetSAPGridViewFirstVisibleColumnSearchColumnTitleIsRegularExpression);
                sAPSetSAPGridViewFirstVisibleColumnpropCount++;
            }

            if (sAPSetSAPGridViewFirstVisibleColumnSearchColumnTitleIsCaseSensitive != null)
            {
                sAPSetSAPGridViewFirstVisibleColumn["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPSetSAPGridViewFirstVisibleColumnSearchColumnTitleIsCaseSensitive);
                sAPSetSAPGridViewFirstVisibleColumnpropCount++;
            }

            sAPSetSAPGridViewFirstVisibleColumnpropCount++;
            sAPSetSAPGridViewFirstVisibleColumn["Workflow"] = ExpressionConverter.ConvertO(sAPSetSAPGridViewFirstVisibleColumnWorkflow);
            if (sAPSetSAPGridViewFirstVisibleColumnpropCount > 0)
            {
                callPayload.Body = sAPSetSAPGridViewFirstVisibleColumn;
            }

            return new ApiConnectionAction<SAPSetSAPGridViewFirstVisibleColumnResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPGridViewOpenContextMenu(Expression<Func<string>> sAPGridViewOpenContextMenuSearchSAPElementId, Expression<Func<int>> sAPGridViewOpenContextMenuRowIndex, Expression<Func<string>> sAPGridViewOpenContextMenuWorkflow, Expression<Func<string>> sAPGridViewOpenContextMenuSearchColumnName = null, Expression<Func<string>> sAPGridViewOpenContextMenuSearchColumnTitle = null, Expression<Func<bool>> sAPGridViewOpenContextMenuSearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPGridViewOpenContextMenuSearchColumnTitleIsCaseSensitive = null)
        {
            var apiCallPath = "/SAPGUI/SAPGridViewOpenContextMenu";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPGridViewOpenContextMenu = new JObject();
            var sAPGridViewOpenContextMenupropCount = 0;
            sAPGridViewOpenContextMenupropCount++;
            sAPGridViewOpenContextMenu["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGridViewOpenContextMenuSearchSAPElementId);
            sAPGridViewOpenContextMenupropCount++;
            sAPGridViewOpenContextMenu["RowIndex"] = ExpressionConverter.ConvertO(sAPGridViewOpenContextMenuRowIndex);
            if (sAPGridViewOpenContextMenuSearchColumnName != null)
            {
                sAPGridViewOpenContextMenu["SearchColumnName"] = ExpressionConverter.ConvertO(sAPGridViewOpenContextMenuSearchColumnName);
                sAPGridViewOpenContextMenupropCount++;
            }

            if (sAPGridViewOpenContextMenuSearchColumnTitle != null)
            {
                sAPGridViewOpenContextMenu["SearchColumnTitle"] = ExpressionConverter.ConvertO(sAPGridViewOpenContextMenuSearchColumnTitle);
                sAPGridViewOpenContextMenupropCount++;
            }

            if (sAPGridViewOpenContextMenuSearchColumnTitleIsRegularExpression != null)
            {
                sAPGridViewOpenContextMenu["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(sAPGridViewOpenContextMenuSearchColumnTitleIsRegularExpression);
                sAPGridViewOpenContextMenupropCount++;
            }

            if (sAPGridViewOpenContextMenuSearchColumnTitleIsCaseSensitive != null)
            {
                sAPGridViewOpenContextMenu["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPGridViewOpenContextMenuSearchColumnTitleIsCaseSensitive);
                sAPGridViewOpenContextMenupropCount++;
            }

            sAPGridViewOpenContextMenupropCount++;
            sAPGridViewOpenContextMenu["Workflow"] = ExpressionConverter.ConvertO(sAPGridViewOpenContextMenuWorkflow);
            if (sAPGridViewOpenContextMenupropCount > 0)
            {
                callPayload.Body = sAPGridViewOpenContextMenu;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetGridViewTextContentsResponse> SAPGetGridViewTextContents(Expression<Func<string>> sAPGetGridViewTextContentsSearchSAPElementId, Expression<Func<string>> sAPGetGridViewTextContentsWorkflow, Expression<Func<int>> sAPGetGridViewTextContentsFirstRowToReturn = null, Expression<Func<int>> sAPGetGridViewTextContentsMaxRowsToReturn = null, Expression<Func<string>> sAPGetGridViewTextContentsFirstSearchColumnName = null, Expression<Func<string>> sAPGetGridViewTextContentsFirstSearchColumnTitle = null, Expression<Func<bool>> sAPGetGridViewTextContentsFirstSearchColumnTitleIsRegularExpression = null, Expression<Func<bool>> sAPGetGridViewTextContentsFirstSearchColumnTitleIsCaseSensitive = null, Expression<Func<int>> sAPGetGridViewTextContentsMaxColumnsToReturn = null, Expression<Func<bool>> sAPGetGridViewTextContentsUseColumnHeadersFromTable = null, Expression<Func<bool>> sAPGetGridViewTextContentsReturnRowIndexInOutputCollection = null, Expression<Func<string>> sAPGetGridViewTextContentsNameOfColumnToStoreRowIndex = null, Expression<Func<string>> sAPGetGridViewTextContentsCheckedElementValue = null)
        {
            var apiCallPath = "/SAPGUI/SAPGetGridViewTextContents";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPGetGridViewTextContents = new JObject();
            var sAPGetGridViewTextContentspropCount = 0;
            sAPGetGridViewTextContentspropCount++;
            sAPGetGridViewTextContents["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGetGridViewTextContentsSearchSAPElementId);
            if (sAPGetGridViewTextContentsFirstRowToReturn != null)
            {
                sAPGetGridViewTextContents["FirstRowToReturn"] = ExpressionConverter.ConvertO(sAPGetGridViewTextContentsFirstRowToReturn);
                sAPGetGridViewTextContentspropCount++;
            }

            if (sAPGetGridViewTextContentsMaxRowsToReturn != null)
            {
                sAPGetGridViewTextContents["MaxRowsToReturn"] = ExpressionConverter.ConvertO(sAPGetGridViewTextContentsMaxRowsToReturn);
                sAPGetGridViewTextContentspropCount++;
            }

            if (sAPGetGridViewTextContentsFirstSearchColumnName != null)
            {
                sAPGetGridViewTextContents["FirstSearchColumnName"] = ExpressionConverter.ConvertO(sAPGetGridViewTextContentsFirstSearchColumnName);
                sAPGetGridViewTextContentspropCount++;
            }

            if (sAPGetGridViewTextContentsFirstSearchColumnTitle != null)
            {
                sAPGetGridViewTextContents["FirstSearchColumnTitle"] = ExpressionConverter.ConvertO(sAPGetGridViewTextContentsFirstSearchColumnTitle);
                sAPGetGridViewTextContentspropCount++;
            }

            if (sAPGetGridViewTextContentsFirstSearchColumnTitleIsRegularExpression != null)
            {
                sAPGetGridViewTextContents["FirstSearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(sAPGetGridViewTextContentsFirstSearchColumnTitleIsRegularExpression);
                sAPGetGridViewTextContentspropCount++;
            }

            if (sAPGetGridViewTextContentsFirstSearchColumnTitleIsCaseSensitive != null)
            {
                sAPGetGridViewTextContents["FirstSearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPGetGridViewTextContentsFirstSearchColumnTitleIsCaseSensitive);
                sAPGetGridViewTextContentspropCount++;
            }

            if (sAPGetGridViewTextContentsMaxColumnsToReturn != null)
            {
                sAPGetGridViewTextContents["MaxColumnsToReturn"] = ExpressionConverter.ConvertO(sAPGetGridViewTextContentsMaxColumnsToReturn);
                sAPGetGridViewTextContentspropCount++;
            }

            if (sAPGetGridViewTextContentsUseColumnHeadersFromTable != null)
            {
                sAPGetGridViewTextContents["UseColumnHeadersFromTable"] = ExpressionConverter.ConvertO(sAPGetGridViewTextContentsUseColumnHeadersFromTable);
                sAPGetGridViewTextContentspropCount++;
            }

            if (sAPGetGridViewTextContentsReturnRowIndexInOutputCollection != null)
            {
                sAPGetGridViewTextContents["ReturnRowIndexInOutputCollection"] = ExpressionConverter.ConvertO(sAPGetGridViewTextContentsReturnRowIndexInOutputCollection);
                sAPGetGridViewTextContentspropCount++;
            }

            if (sAPGetGridViewTextContentsNameOfColumnToStoreRowIndex != null)
            {
                sAPGetGridViewTextContents["NameOfColumnToStoreRowIndex"] = ExpressionConverter.ConvertO(sAPGetGridViewTextContentsNameOfColumnToStoreRowIndex);
                sAPGetGridViewTextContentspropCount++;
            }

            if (sAPGetGridViewTextContentsCheckedElementValue != null)
            {
                sAPGetGridViewTextContents["CheckedElementValue"] = ExpressionConverter.ConvertO(sAPGetGridViewTextContentsCheckedElementValue);
                sAPGetGridViewTextContentspropCount++;
            }

            sAPGetGridViewTextContentspropCount++;
            sAPGetGridViewTextContents["Workflow"] = ExpressionConverter.ConvertO(sAPGetGridViewTextContentsWorkflow);
            if (sAPGetGridViewTextContentspropCount > 0)
            {
                callPayload.Body = sAPGetGridViewTextContents;
            }

            return new ApiConnectionAction<SAPGetGridViewTextContentsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPSelectCalendarMonth(Expression<Func<string>> sAPSelectCalendarMonthSearchSAPElementId, Expression<Func<int>> sAPSelectCalendarMonthMonth, Expression<Func<int>> sAPSelectCalendarMonthYear, Expression<Func<string>> sAPSelectCalendarMonthWorkflow)
        {
            var apiCallPath = "/SAPGUI/SAPSelectCalendarMonth";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPSelectCalendarMonth = new JObject();
            var sAPSelectCalendarMonthpropCount = 0;
            sAPSelectCalendarMonthpropCount++;
            sAPSelectCalendarMonth["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPSelectCalendarMonthSearchSAPElementId);
            sAPSelectCalendarMonthpropCount++;
            sAPSelectCalendarMonth["Month"] = ExpressionConverter.ConvertO(sAPSelectCalendarMonthMonth);
            sAPSelectCalendarMonthpropCount++;
            sAPSelectCalendarMonth["Year"] = ExpressionConverter.ConvertO(sAPSelectCalendarMonthYear);
            sAPSelectCalendarMonthpropCount++;
            sAPSelectCalendarMonth["Workflow"] = ExpressionConverter.ConvertO(sAPSelectCalendarMonthWorkflow);
            if (sAPSelectCalendarMonthpropCount > 0)
            {
                callPayload.Body = sAPSelectCalendarMonth;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPSelectCalendarWeek(Expression<Func<string>> sAPSelectCalendarWeekSearchSAPElementId, Expression<Func<int>> sAPSelectCalendarWeekWeek, Expression<Func<int>> sAPSelectCalendarWeekYear, Expression<Func<string>> sAPSelectCalendarWeekWorkflow)
        {
            var apiCallPath = "/SAPGUI/SAPSelectCalendarWeek";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPSelectCalendarWeek = new JObject();
            var sAPSelectCalendarWeekpropCount = 0;
            sAPSelectCalendarWeekpropCount++;
            sAPSelectCalendarWeek["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPSelectCalendarWeekSearchSAPElementId);
            sAPSelectCalendarWeekpropCount++;
            sAPSelectCalendarWeek["Week"] = ExpressionConverter.ConvertO(sAPSelectCalendarWeekWeek);
            sAPSelectCalendarWeekpropCount++;
            sAPSelectCalendarWeek["Year"] = ExpressionConverter.ConvertO(sAPSelectCalendarWeekYear);
            sAPSelectCalendarWeekpropCount++;
            sAPSelectCalendarWeek["Workflow"] = ExpressionConverter.ConvertO(sAPSelectCalendarWeekWorkflow);
            if (sAPSelectCalendarWeekpropCount > 0)
            {
                callPayload.Body = sAPSelectCalendarWeek;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPSelectCalendarRange(Expression<Func<string>> sAPSelectCalendarRangeSearchSAPElementId, Expression<Func<string>> sAPSelectCalendarRangeFromDateYYYYMMDD, Expression<Func<string>> sAPSelectCalendarRangeToDateYYYYMMDD, Expression<Func<string>> sAPSelectCalendarRangeWorkflow)
        {
            var apiCallPath = "/SAPGUI/SAPSelectCalendarRange";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPSelectCalendarRange = new JObject();
            var sAPSelectCalendarRangepropCount = 0;
            sAPSelectCalendarRangepropCount++;
            sAPSelectCalendarRange["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPSelectCalendarRangeSearchSAPElementId);
            sAPSelectCalendarRangepropCount++;
            sAPSelectCalendarRange["FromDateYYYYMMDD"] = ExpressionConverter.ConvertO(sAPSelectCalendarRangeFromDateYYYYMMDD);
            sAPSelectCalendarRangepropCount++;
            sAPSelectCalendarRange["ToDateYYYYMMDD"] = ExpressionConverter.ConvertO(sAPSelectCalendarRangeToDateYYYYMMDD);
            sAPSelectCalendarRangepropCount++;
            sAPSelectCalendarRange["Workflow"] = ExpressionConverter.ConvertO(sAPSelectCalendarRangeWorkflow);
            if (sAPSelectCalendarRangepropCount > 0)
            {
                callPayload.Body = sAPSelectCalendarRange;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction SAPFocusCalendarDate(Expression<Func<string>> sAPFocusCalendarDateSearchSAPElementId, Expression<Func<string>> sAPFocusCalendarDateDateYYYYMMDD, Expression<Func<string>> sAPFocusCalendarDateWorkflow)
        {
            var apiCallPath = "/SAPGUI/SAPFocusCalendarDate";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var sAPFocusCalendarDate = new JObject();
            var sAPFocusCalendarDatepropCount = 0;
            sAPFocusCalendarDatepropCount++;
            sAPFocusCalendarDate["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPFocusCalendarDateSearchSAPElementId);
            sAPFocusCalendarDatepropCount++;
            sAPFocusCalendarDate["DateYYYYMMDD"] = ExpressionConverter.ConvertO(sAPFocusCalendarDateDateYYYYMMDD);
            sAPFocusCalendarDatepropCount++;
            sAPFocusCalendarDate["Workflow"] = ExpressionConverter.ConvertO(sAPFocusCalendarDateWorkflow);
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

    public enum sAPGlobalLeftMouseClickOnSAPElementOffsetRelativeToInput
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

    public enum sAPGlobalRightMouseClickOnSAPElementOffsetRelativeToInput
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

    public enum sAPGlobalMiddleMouseClickOnSAPElementOffsetRelativeToInput
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

    public enum sAPGlobalDoubleLeftMouseClickOnSAPElementOffsetRelativeToInput
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

    public enum sAPGlobalLeftClickSAPGridViewCellAtIndexOffsetRelativeToInput
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

    public enum sAPGlobalRightClickSAPGridViewCellAtIndexOffsetRelativeToInput
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

    public enum sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexOffsetRelativeToInput
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

namespace Microsoft.Azure.Workflows.Sdk.Connectors
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