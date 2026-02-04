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
                sAPEnableScripting["NotifyWhenScriptAttachesToGUI"] = ExpressionConverter.ConvertO(sAPEnableScriptingnotifyWhenScriptAttachesToGUI);
                sAPEnableScriptingpropCount++;
            }

            if (sAPEnableScriptingnotifyWhenScriptOpensConnection != null)
            {
                sAPEnableScripting["NotifyWhenScriptOpensConnection"] = ExpressionConverter.ConvertO(sAPEnableScriptingnotifyWhenScriptOpensConnection);
                sAPEnableScriptingpropCount++;
            }

            if (sAPEnableScriptingshowNativeWindowsDialogs != null)
            {
                sAPEnableScripting["ShowNativeWindowsDialogs"] = ExpressionConverter.ConvertO(sAPEnableScriptingshowNativeWindowsDialogs);
                sAPEnableScriptingpropCount++;
            }

            sAPEnableScriptingpropCount++;
            sAPEnableScripting["Workflow"] = ExpressionConverter.ConvertO(sAPEnableScriptingworkflow);
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
                sAPLaunchSAPGUI["EnableSAPScripting"] = ExpressionConverter.ConvertO(sAPLaunchSAPGUIenableSAPScripting);
                sAPLaunchSAPGUIpropCount++;
            }

            if (sAPLaunchSAPGUInotifyWhenScriptAttachesToGUI != null)
            {
                sAPLaunchSAPGUI["NotifyWhenScriptAttachesToGUI"] = ExpressionConverter.ConvertO(sAPLaunchSAPGUInotifyWhenScriptAttachesToGUI);
                sAPLaunchSAPGUIpropCount++;
            }

            if (sAPLaunchSAPGUInotifyWhenScriptOpensConnection != null)
            {
                sAPLaunchSAPGUI["NotifyWhenScriptOpensConnection"] = ExpressionConverter.ConvertO(sAPLaunchSAPGUInotifyWhenScriptOpensConnection);
                sAPLaunchSAPGUIpropCount++;
            }

            if (sAPLaunchSAPGUIshowNativeWindowsDialogs != null)
            {
                sAPLaunchSAPGUI["ShowNativeWindowsDialogs"] = ExpressionConverter.ConvertO(sAPLaunchSAPGUIshowNativeWindowsDialogs);
                sAPLaunchSAPGUIpropCount++;
            }

            if (sAPLaunchSAPGUIattachAfterLaunch != null)
            {
                sAPLaunchSAPGUI["AttachAfterLaunch"] = ExpressionConverter.ConvertO(sAPLaunchSAPGUIattachAfterLaunch);
                sAPLaunchSAPGUIpropCount++;
            }

            if (sAPLaunchSAPGUIsecondsToWait != null)
            {
                sAPLaunchSAPGUI["SecondsToWait"] = ExpressionConverter.ConvertO(sAPLaunchSAPGUIsecondsToWait);
                sAPLaunchSAPGUIpropCount++;
            }

            if (sAPLaunchSAPGUIsAPProgId != null)
            {
                sAPLaunchSAPGUI["SAPProgId"] = ExpressionConverter.ConvertO(sAPLaunchSAPGUIsAPProgId);
                sAPLaunchSAPGUIpropCount++;
            }

            if (sAPLaunchSAPGUIdisableSystemMessages != null)
            {
                sAPLaunchSAPGUI["DisableSystemMessages"] = ExpressionConverter.ConvertO(sAPLaunchSAPGUIdisableSystemMessages);
                sAPLaunchSAPGUIpropCount++;
            }

            sAPLaunchSAPGUIpropCount++;
            sAPLaunchSAPGUI["Workflow"] = ExpressionConverter.ConvertO(sAPLaunchSAPGUIworkflow);
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
                sAPAttachToSAPGUI["SAPProgId"] = ExpressionConverter.ConvertO(sAPAttachToSAPGUIsAPProgId);
                sAPAttachToSAPGUIpropCount++;
            }

            if (sAPAttachToSAPGUIdisableSystemMessages != null)
            {
                sAPAttachToSAPGUI["DisableSystemMessages"] = ExpressionConverter.ConvertO(sAPAttachToSAPGUIdisableSystemMessages);
                sAPAttachToSAPGUIpropCount++;
            }

            sAPAttachToSAPGUIpropCount++;
            sAPAttachToSAPGUI["Workflow"] = ExpressionConverter.ConvertO(sAPAttachToSAPGUIworkflow);
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
            sAPDetachFromSAPGUI["Workflow"] = ExpressionConverter.ConvertO(sAPDetachFromSAPGUIworkflow);
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
            sAPGetSAPGUIStatus["Workflow"] = ExpressionConverter.ConvertO(sAPGetSAPGUIStatusworkflow);
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
            sAPGetSAPSessions["Workflow"] = ExpressionConverter.ConvertO(sAPGetSAPSessionsworkflow);
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
                sAPCloseSession["CloseAttachedSession"] = ExpressionConverter.ConvertO(sAPCloseSessioncloseAttachedSession);
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
            sAPGetAttachedSessionProperties["Workflow"] = ExpressionConverter.ConvertO(sAPGetAttachedSessionPropertiesworkflow);
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
            sAPWaitForAttachedSessionNotBusy["SecondsToWait"] = ExpressionConverter.ConvertO(sAPWaitForAttachedSessionNotBusysecondsToWait);
            if (sAPWaitForAttachedSessionNotBusyraiseExceptionIfBusyAfterWait != null)
            {
                sAPWaitForAttachedSessionNotBusy["RaiseExceptionIfBusyAfterWait"] = ExpressionConverter.ConvertO(sAPWaitForAttachedSessionNotBusyraiseExceptionIfBusyAfterWait);
                sAPWaitForAttachedSessionNotBusypropCount++;
            }

            sAPWaitForAttachedSessionNotBusypropCount++;
            sAPWaitForAttachedSessionNotBusy["Workflow"] = ExpressionConverter.ConvertO(sAPWaitForAttachedSessionNotBusyworkflow);
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
            sAPInputTextIntoSAPElement["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPInputTextIntoSAPElementsearchSAPElementId);
            if (sAPInputTextIntoSAPElementtextToInput != null)
            {
                sAPInputTextIntoSAPElement["TextToInput"] = ExpressionConverter.ConvertO(sAPInputTextIntoSAPElementtextToInput);
                sAPInputTextIntoSAPElementpropCount++;
            }

            if (sAPInputTextIntoSAPElementreplaceExistingValue != null)
            {
                sAPInputTextIntoSAPElement["ReplaceExistingValue"] = ExpressionConverter.ConvertO(sAPInputTextIntoSAPElementreplaceExistingValue);
                sAPInputTextIntoSAPElementpropCount++;
            }

            if (sAPInputTextIntoSAPElementinsertPosition != null)
            {
                sAPInputTextIntoSAPElement["InsertPosition"] = ExpressionConverter.ConvertO(sAPInputTextIntoSAPElementinsertPosition);
                sAPInputTextIntoSAPElementpropCount++;
            }

            sAPInputTextIntoSAPElementpropCount++;
            sAPInputTextIntoSAPElement["Workflow"] = ExpressionConverter.ConvertO(sAPInputTextIntoSAPElementworkflow);
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
            sAPGetElementProperties["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGetElementPropertiessearchSAPElementId);
            sAPGetElementPropertiespropCount++;
            sAPGetElementProperties["Workflow"] = ExpressionConverter.ConvertO(sAPGetElementPropertiesworkflow);
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
            sAPWaitForElementId["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPWaitForElementIdsearchSAPElementId);
            if (sAPWaitForElementIdsecondsToWait != null)
            {
                sAPWaitForElementId["SecondsToWait"] = ExpressionConverter.ConvertO(sAPWaitForElementIdsecondsToWait);
                sAPWaitForElementIdpropCount++;
            }

            if (sAPWaitForElementIdraiseExceptionIfElementNotFound != null)
            {
                sAPWaitForElementId["RaiseExceptionIfElementNotFound"] = ExpressionConverter.ConvertO(sAPWaitForElementIdraiseExceptionIfElementNotFound);
                sAPWaitForElementIdpropCount++;
            }

            sAPWaitForElementIdpropCount++;
            sAPWaitForElementId["Workflow"] = ExpressionConverter.ConvertO(sAPWaitForElementIdworkflow);
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
            sAPWaitForWindow["SearchSAPWindowTitle"] = ExpressionConverter.ConvertO(sAPWaitForWindowsearchSAPWindowTitle);
            if (sAPWaitForWindowsearchIsRegularExpression != null)
            {
                sAPWaitForWindow["SearchIsRegularExpression"] = ExpressionConverter.ConvertO(sAPWaitForWindowsearchIsRegularExpression);
                sAPWaitForWindowpropCount++;
            }

            if (sAPWaitForWindowsearchIsCaseSensitive != null)
            {
                sAPWaitForWindow["SearchIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPWaitForWindowsearchIsCaseSensitive);
                sAPWaitForWindowpropCount++;
            }

            if (sAPWaitForWindowsecondsToWait != null)
            {
                sAPWaitForWindow["SecondsToWait"] = ExpressionConverter.ConvertO(sAPWaitForWindowsecondsToWait);
                sAPWaitForWindowpropCount++;
            }

            if (sAPWaitForWindowraiseExceptionIfElementNotFound != null)
            {
                sAPWaitForWindow["RaiseExceptionIfElementNotFound"] = ExpressionConverter.ConvertO(sAPWaitForWindowraiseExceptionIfElementNotFound);
                sAPWaitForWindowpropCount++;
            }

            sAPWaitForWindowpropCount++;
            sAPWaitForWindow["Workflow"] = ExpressionConverter.ConvertO(sAPWaitForWindowworkflow);
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
            sAPGetElementTextValue["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGetElementTextValuesearchSAPElementId);
            sAPGetElementTextValuepropCount++;
            sAPGetElementTextValue["Workflow"] = ExpressionConverter.ConvertO(sAPGetElementTextValueworkflow);
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
            sAPPressSAPElement["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPPressSAPElementsearchSAPElementId);
            sAPPressSAPElementpropCount++;
            sAPPressSAPElement["Workflow"] = ExpressionConverter.ConvertO(sAPPressSAPElementworkflow);
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
            sAPSelectSAPElement["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPSelectSAPElementsearchSAPElementId);
            sAPSelectSAPElementpropCount++;
            sAPSelectSAPElement["Workflow"] = ExpressionConverter.ConvertO(sAPSelectSAPElementworkflow);
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
            sAPFocusSAPElement["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPFocusSAPElementsearchSAPElementId);
            sAPFocusSAPElementpropCount++;
            sAPFocusSAPElement["Workflow"] = ExpressionConverter.ConvertO(sAPFocusSAPElementworkflow);
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
            sAPCheckSAPElement["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPCheckSAPElementsearchSAPElementId);
            if (sAPCheckSAPElementcheckElement != null)
            {
                sAPCheckSAPElement["CheckElement"] = ExpressionConverter.ConvertO(sAPCheckSAPElementcheckElement);
                sAPCheckSAPElementpropCount++;
            }

            sAPCheckSAPElementpropCount++;
            sAPCheckSAPElement["Workflow"] = ExpressionConverter.ConvertO(sAPCheckSAPElementworkflow);
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
            sAPVisualiseSAPElement["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPVisualiseSAPElementsearchSAPElementId);
            if (sAPVisualiseSAPElementvisualiseOn != null)
            {
                sAPVisualiseSAPElement["VisualiseOn"] = ExpressionConverter.ConvertO(sAPVisualiseSAPElementvisualiseOn);
                sAPVisualiseSAPElementpropCount++;
            }

            sAPVisualiseSAPElementpropCount++;
            sAPVisualiseSAPElement["Workflow"] = ExpressionConverter.ConvertO(sAPVisualiseSAPElementworkflow);
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
            sAPDrawRectangleAroundSAPElement["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPDrawRectangleAroundSAPElementsearchSAPElementId);
            if (sAPDrawRectangleAroundSAPElementpenColour != null)
            {
                sAPDrawRectangleAroundSAPElement["PenColour"] = ExpressionConverter.ConvertO(sAPDrawRectangleAroundSAPElementpenColour);
                sAPDrawRectangleAroundSAPElementpropCount++;
            }

            if (sAPDrawRectangleAroundSAPElementpenThicknessPixels != null)
            {
                sAPDrawRectangleAroundSAPElement["PenThicknessPixels"] = ExpressionConverter.ConvertO(sAPDrawRectangleAroundSAPElementpenThicknessPixels);
                sAPDrawRectangleAroundSAPElementpropCount++;
            }

            sAPDrawRectangleAroundSAPElementpropCount++;
            sAPDrawRectangleAroundSAPElement["Workflow"] = ExpressionConverter.ConvertO(sAPDrawRectangleAroundSAPElementworkflow);
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
            sAPSendCommand["SAPCommand"] = ExpressionConverter.ConvertO(sAPSendCommandsAPCommand);
            sAPSendCommandpropCount++;
            sAPSendCommand["Workflow"] = ExpressionConverter.ConvertO(sAPSendCommandworkflow);
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
            sAPEnterTCode["SAPTCode"] = ExpressionConverter.ConvertO(sAPEnterTCodesAPTCode);
            sAPEnterTCodepropCount++;
            sAPEnterTCode["Workflow"] = ExpressionConverter.ConvertO(sAPEnterTCodeworkflow);
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
            sAPSendVKey["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPSendVKeysearchSAPElementId);
            sAPSendVKeypropCount++;
            sAPSendVKey["SAPVKey"] = ExpressionConverter.ConvertO(sAPSendVKeysAPVKey);
            if (sAPSendVKeydetectParentWindowElement != null)
            {
                sAPSendVKey["DetectParentWindowElement"] = ExpressionConverter.ConvertO(sAPSendVKeydetectParentWindowElement);
                sAPSendVKeypropCount++;
            }

            sAPSendVKeypropCount++;
            sAPSendVKey["Workflow"] = ExpressionConverter.ConvertO(sAPSendVKeyworkflow);
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
            sAPSendEnterVKey["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPSendEnterVKeysearchSAPElementId);
            if (sAPSendEnterVKeydetectParentWindowElement != null)
            {
                sAPSendEnterVKey["DetectParentWindowElement"] = ExpressionConverter.ConvertO(sAPSendEnterVKeydetectParentWindowElement);
                sAPSendEnterVKeypropCount++;
            }

            sAPSendEnterVKeypropCount++;
            sAPSendEnterVKey["Workflow"] = ExpressionConverter.ConvertO(sAPSendEnterVKeyworkflow);
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
            sAPWindowRestore["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPWindowRestoresearchSAPElementId);
            if (sAPWindowRestoredetectParentWindowElement != null)
            {
                sAPWindowRestore["DetectParentWindowElement"] = ExpressionConverter.ConvertO(sAPWindowRestoredetectParentWindowElement);
                sAPWindowRestorepropCount++;
            }

            sAPWindowRestorepropCount++;
            sAPWindowRestore["Workflow"] = ExpressionConverter.ConvertO(sAPWindowRestoreworkflow);
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
            sAPWindowMaximise["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPWindowMaximisesearchSAPElementId);
            if (sAPWindowMaximisedetectParentWindowElement != null)
            {
                sAPWindowMaximise["DetectParentWindowElement"] = ExpressionConverter.ConvertO(sAPWindowMaximisedetectParentWindowElement);
                sAPWindowMaximisepropCount++;
            }

            sAPWindowMaximisepropCount++;
            sAPWindowMaximise["Workflow"] = ExpressionConverter.ConvertO(sAPWindowMaximiseworkflow);
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
            sAPWindowMinimise["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPWindowMinimisesearchSAPElementId);
            if (sAPWindowMinimisedetectParentWindowElement != null)
            {
                sAPWindowMinimise["DetectParentWindowElement"] = ExpressionConverter.ConvertO(sAPWindowMinimisedetectParentWindowElement);
                sAPWindowMinimisepropCount++;
            }

            sAPWindowMinimisepropCount++;
            sAPWindowMinimise["Workflow"] = ExpressionConverter.ConvertO(sAPWindowMinimiseworkflow);
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
            sAPWindowClose["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPWindowClosesearchSAPElementId);
            if (sAPWindowClosedetectParentWindowElement != null)
            {
                sAPWindowClose["DetectParentWindowElement"] = ExpressionConverter.ConvertO(sAPWindowClosedetectParentWindowElement);
                sAPWindowClosepropCount++;
            }

            sAPWindowClosepropCount++;
            sAPWindowClose["Workflow"] = ExpressionConverter.ConvertO(sAPWindowCloseworkflow);
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
            sAPBringWindowToFront["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPBringWindowToFrontsearchSAPElementId);
            if (sAPBringWindowToFronttoggleWindow != null)
            {
                sAPBringWindowToFront["ToggleWindow"] = ExpressionConverter.ConvertO(sAPBringWindowToFronttoggleWindow);
                sAPBringWindowToFrontpropCount++;
            }

            if (sAPBringWindowToFronttoggleUsesGlobalLeftMouseClickAgent != null)
            {
                sAPBringWindowToFront["ToggleUsesGlobalLeftMouseClickAgent"] = ExpressionConverter.ConvertO(sAPBringWindowToFronttoggleUsesGlobalLeftMouseClickAgent);
                sAPBringWindowToFrontpropCount++;
            }

            if (sAPBringWindowToFronttoggleDelay != null)
            {
                sAPBringWindowToFront["ToggleDelay"] = ExpressionConverter.ConvertO(sAPBringWindowToFronttoggleDelay);
                sAPBringWindowToFrontpropCount++;
            }

            if (sAPBringWindowToFrontdetectParentWindowElement != null)
            {
                sAPBringWindowToFront["DetectParentWindowElement"] = ExpressionConverter.ConvertO(sAPBringWindowToFrontdetectParentWindowElement);
                sAPBringWindowToFrontpropCount++;
            }

            sAPBringWindowToFrontpropCount++;
            sAPBringWindowToFront["Workflow"] = ExpressionConverter.ConvertO(sAPBringWindowToFrontworkflow);
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
            sAPGlobalLeftMouseClickOnSAPElement["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGlobalLeftMouseClickOnSAPElementsearchSAPElementId);
            if (sAPGlobalLeftMouseClickOnSAPElementsetElementWindowTopMost != null)
            {
                sAPGlobalLeftMouseClickOnSAPElement["SetElementWindowTopMost"] = ExpressionConverter.ConvertO(sAPGlobalLeftMouseClickOnSAPElementsetElementWindowTopMost);
                sAPGlobalLeftMouseClickOnSAPElementpropCount++;
            }

            if (sAPGlobalLeftMouseClickOnSAPElementbringElementWindowToFront != null)
            {
                sAPGlobalLeftMouseClickOnSAPElement["BringElementWindowToFront"] = ExpressionConverter.ConvertO(sAPGlobalLeftMouseClickOnSAPElementbringElementWindowToFront);
                sAPGlobalLeftMouseClickOnSAPElementpropCount++;
            }

            if (sAPGlobalLeftMouseClickOnSAPElementtoggleWindow != null)
            {
                sAPGlobalLeftMouseClickOnSAPElement["ToggleWindow"] = ExpressionConverter.ConvertO(sAPGlobalLeftMouseClickOnSAPElementtoggleWindow);
                sAPGlobalLeftMouseClickOnSAPElementpropCount++;
            }

            if (sAPGlobalLeftMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent != null)
            {
                sAPGlobalLeftMouseClickOnSAPElement["ToggleUsesGlobalLeftMouseClickAgent"] = ExpressionConverter.ConvertO(sAPGlobalLeftMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent);
                sAPGlobalLeftMouseClickOnSAPElementpropCount++;
            }

            if (sAPGlobalLeftMouseClickOnSAPElementtoggleDelay != null)
            {
                sAPGlobalLeftMouseClickOnSAPElement["ToggleDelay"] = ExpressionConverter.ConvertO(sAPGlobalLeftMouseClickOnSAPElementtoggleDelay);
                sAPGlobalLeftMouseClickOnSAPElementpropCount++;
            }

            if (sAPGlobalLeftMouseClickOnSAPElementclickOffsetX != null)
            {
                sAPGlobalLeftMouseClickOnSAPElement["ClickOffsetX"] = ExpressionConverter.ConvertO(sAPGlobalLeftMouseClickOnSAPElementclickOffsetX);
                sAPGlobalLeftMouseClickOnSAPElementpropCount++;
            }

            if (sAPGlobalLeftMouseClickOnSAPElementclickOffsetY != null)
            {
                sAPGlobalLeftMouseClickOnSAPElement["ClickOffsetY"] = ExpressionConverter.ConvertO(sAPGlobalLeftMouseClickOnSAPElementclickOffsetY);
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
            sAPGlobalRightMouseClickOnSAPElement["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGlobalRightMouseClickOnSAPElementsearchSAPElementId);
            if (sAPGlobalRightMouseClickOnSAPElementsetElementWindowTopMost != null)
            {
                sAPGlobalRightMouseClickOnSAPElement["SetElementWindowTopMost"] = ExpressionConverter.ConvertO(sAPGlobalRightMouseClickOnSAPElementsetElementWindowTopMost);
                sAPGlobalRightMouseClickOnSAPElementpropCount++;
            }

            if (sAPGlobalRightMouseClickOnSAPElementbringElementWindowToFront != null)
            {
                sAPGlobalRightMouseClickOnSAPElement["BringElementWindowToFront"] = ExpressionConverter.ConvertO(sAPGlobalRightMouseClickOnSAPElementbringElementWindowToFront);
                sAPGlobalRightMouseClickOnSAPElementpropCount++;
            }

            if (sAPGlobalRightMouseClickOnSAPElementtoggleWindow != null)
            {
                sAPGlobalRightMouseClickOnSAPElement["ToggleWindow"] = ExpressionConverter.ConvertO(sAPGlobalRightMouseClickOnSAPElementtoggleWindow);
                sAPGlobalRightMouseClickOnSAPElementpropCount++;
            }

            if (sAPGlobalRightMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent != null)
            {
                sAPGlobalRightMouseClickOnSAPElement["ToggleUsesGlobalLeftMouseClickAgent"] = ExpressionConverter.ConvertO(sAPGlobalRightMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent);
                sAPGlobalRightMouseClickOnSAPElementpropCount++;
            }

            if (sAPGlobalRightMouseClickOnSAPElementtoggleDelay != null)
            {
                sAPGlobalRightMouseClickOnSAPElement["ToggleDelay"] = ExpressionConverter.ConvertO(sAPGlobalRightMouseClickOnSAPElementtoggleDelay);
                sAPGlobalRightMouseClickOnSAPElementpropCount++;
            }

            if (sAPGlobalRightMouseClickOnSAPElementclickOffsetX != null)
            {
                sAPGlobalRightMouseClickOnSAPElement["ClickOffsetX"] = ExpressionConverter.ConvertO(sAPGlobalRightMouseClickOnSAPElementclickOffsetX);
                sAPGlobalRightMouseClickOnSAPElementpropCount++;
            }

            if (sAPGlobalRightMouseClickOnSAPElementclickOffsetY != null)
            {
                sAPGlobalRightMouseClickOnSAPElement["ClickOffsetY"] = ExpressionConverter.ConvertO(sAPGlobalRightMouseClickOnSAPElementclickOffsetY);
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
            sAPGlobalMiddleMouseClickOnSAPElement["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGlobalMiddleMouseClickOnSAPElementsearchSAPElementId);
            if (sAPGlobalMiddleMouseClickOnSAPElementsetElementWindowTopMost != null)
            {
                sAPGlobalMiddleMouseClickOnSAPElement["SetElementWindowTopMost"] = ExpressionConverter.ConvertO(sAPGlobalMiddleMouseClickOnSAPElementsetElementWindowTopMost);
                sAPGlobalMiddleMouseClickOnSAPElementpropCount++;
            }

            if (sAPGlobalMiddleMouseClickOnSAPElementbringElementWindowToFront != null)
            {
                sAPGlobalMiddleMouseClickOnSAPElement["BringElementWindowToFront"] = ExpressionConverter.ConvertO(sAPGlobalMiddleMouseClickOnSAPElementbringElementWindowToFront);
                sAPGlobalMiddleMouseClickOnSAPElementpropCount++;
            }

            if (sAPGlobalMiddleMouseClickOnSAPElementtoggleWindow != null)
            {
                sAPGlobalMiddleMouseClickOnSAPElement["ToggleWindow"] = ExpressionConverter.ConvertO(sAPGlobalMiddleMouseClickOnSAPElementtoggleWindow);
                sAPGlobalMiddleMouseClickOnSAPElementpropCount++;
            }

            if (sAPGlobalMiddleMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent != null)
            {
                sAPGlobalMiddleMouseClickOnSAPElement["ToggleUsesGlobalLeftMouseClickAgent"] = ExpressionConverter.ConvertO(sAPGlobalMiddleMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent);
                sAPGlobalMiddleMouseClickOnSAPElementpropCount++;
            }

            if (sAPGlobalMiddleMouseClickOnSAPElementtoggleDelay != null)
            {
                sAPGlobalMiddleMouseClickOnSAPElement["ToggleDelay"] = ExpressionConverter.ConvertO(sAPGlobalMiddleMouseClickOnSAPElementtoggleDelay);
                sAPGlobalMiddleMouseClickOnSAPElementpropCount++;
            }

            if (sAPGlobalMiddleMouseClickOnSAPElementclickOffsetX != null)
            {
                sAPGlobalMiddleMouseClickOnSAPElement["ClickOffsetX"] = ExpressionConverter.ConvertO(sAPGlobalMiddleMouseClickOnSAPElementclickOffsetX);
                sAPGlobalMiddleMouseClickOnSAPElementpropCount++;
            }

            if (sAPGlobalMiddleMouseClickOnSAPElementclickOffsetY != null)
            {
                sAPGlobalMiddleMouseClickOnSAPElement["ClickOffsetY"] = ExpressionConverter.ConvertO(sAPGlobalMiddleMouseClickOnSAPElementclickOffsetY);
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
            sAPGlobalDoubleLeftMouseClickOnSAPElement["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGlobalDoubleLeftMouseClickOnSAPElementsearchSAPElementId);
            if (sAPGlobalDoubleLeftMouseClickOnSAPElementsetElementWindowTopMost != null)
            {
                sAPGlobalDoubleLeftMouseClickOnSAPElement["SetElementWindowTopMost"] = ExpressionConverter.ConvertO(sAPGlobalDoubleLeftMouseClickOnSAPElementsetElementWindowTopMost);
                sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount++;
            }

            if (sAPGlobalDoubleLeftMouseClickOnSAPElementbringElementWindowToFront != null)
            {
                sAPGlobalDoubleLeftMouseClickOnSAPElement["BringElementWindowToFront"] = ExpressionConverter.ConvertO(sAPGlobalDoubleLeftMouseClickOnSAPElementbringElementWindowToFront);
                sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount++;
            }

            if (sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleWindow != null)
            {
                sAPGlobalDoubleLeftMouseClickOnSAPElement["ToggleWindow"] = ExpressionConverter.ConvertO(sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleWindow);
                sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount++;
            }

            if (sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent != null)
            {
                sAPGlobalDoubleLeftMouseClickOnSAPElement["ToggleUsesGlobalLeftMouseClickAgent"] = ExpressionConverter.ConvertO(sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleUsesGlobalLeftMouseClickAgent);
                sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount++;
            }

            if (sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleDelay != null)
            {
                sAPGlobalDoubleLeftMouseClickOnSAPElement["ToggleDelay"] = ExpressionConverter.ConvertO(sAPGlobalDoubleLeftMouseClickOnSAPElementtoggleDelay);
                sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount++;
            }

            if (sAPGlobalDoubleLeftMouseClickOnSAPElementclickOffsetX != null)
            {
                sAPGlobalDoubleLeftMouseClickOnSAPElement["ClickOffsetX"] = ExpressionConverter.ConvertO(sAPGlobalDoubleLeftMouseClickOnSAPElementclickOffsetX);
                sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount++;
            }

            if (sAPGlobalDoubleLeftMouseClickOnSAPElementclickOffsetY != null)
            {
                sAPGlobalDoubleLeftMouseClickOnSAPElement["ClickOffsetY"] = ExpressionConverter.ConvertO(sAPGlobalDoubleLeftMouseClickOnSAPElementclickOffsetY);
                sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount++;
            }

            if (sAPGlobalDoubleLeftMouseClickOnSAPElementoffsetRelativeTo != null)
            {
                sAPGlobalDoubleLeftMouseClickOnSAPElement["OffsetRelativeTo"] = ExpressionConverter.ConvertO(sAPGlobalDoubleLeftMouseClickOnSAPElementoffsetRelativeTo);
                sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount++;
            }

            if (sAPGlobalDoubleLeftMouseClickOnSAPElementdoubleClickDelayInMilliseconds != null)
            {
                sAPGlobalDoubleLeftMouseClickOnSAPElement["DoubleClickDelayInMilliseconds"] = ExpressionConverter.ConvertO(sAPGlobalDoubleLeftMouseClickOnSAPElementdoubleClickDelayInMilliseconds);
                sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount++;
            }

            sAPGlobalDoubleLeftMouseClickOnSAPElementpropCount++;
            sAPGlobalDoubleLeftMouseClickOnSAPElement["Workflow"] = ExpressionConverter.ConvertO(sAPGlobalDoubleLeftMouseClickOnSAPElementworkflow);
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
            sAPGlobalInputTextIntoSAPElement["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGlobalInputTextIntoSAPElementsearchSAPElementId);
            if (sAPGlobalInputTextIntoSAPElementsetElementWindowTopMost != null)
            {
                sAPGlobalInputTextIntoSAPElement["SetElementWindowTopMost"] = ExpressionConverter.ConvertO(sAPGlobalInputTextIntoSAPElementsetElementWindowTopMost);
                sAPGlobalInputTextIntoSAPElementpropCount++;
            }

            if (sAPGlobalInputTextIntoSAPElementbringElementWindowToFront != null)
            {
                sAPGlobalInputTextIntoSAPElement["BringElementWindowToFront"] = ExpressionConverter.ConvertO(sAPGlobalInputTextIntoSAPElementbringElementWindowToFront);
                sAPGlobalInputTextIntoSAPElementpropCount++;
            }

            if (sAPGlobalInputTextIntoSAPElementtoggleWindow != null)
            {
                sAPGlobalInputTextIntoSAPElement["ToggleWindow"] = ExpressionConverter.ConvertO(sAPGlobalInputTextIntoSAPElementtoggleWindow);
                sAPGlobalInputTextIntoSAPElementpropCount++;
            }

            if (sAPGlobalInputTextIntoSAPElementtoggleUsesGlobalLeftMouseClickAgent != null)
            {
                sAPGlobalInputTextIntoSAPElement["ToggleUsesGlobalLeftMouseClickAgent"] = ExpressionConverter.ConvertO(sAPGlobalInputTextIntoSAPElementtoggleUsesGlobalLeftMouseClickAgent);
                sAPGlobalInputTextIntoSAPElementpropCount++;
            }

            if (sAPGlobalInputTextIntoSAPElementtoggleDelay != null)
            {
                sAPGlobalInputTextIntoSAPElement["ToggleDelay"] = ExpressionConverter.ConvertO(sAPGlobalInputTextIntoSAPElementtoggleDelay);
                sAPGlobalInputTextIntoSAPElementpropCount++;
            }

            if (sAPGlobalInputTextIntoSAPElementglobalMouseClickOnElement != null)
            {
                sAPGlobalInputTextIntoSAPElement["GlobalMouseClickOnElement"] = ExpressionConverter.ConvertO(sAPGlobalInputTextIntoSAPElementglobalMouseClickOnElement);
                sAPGlobalInputTextIntoSAPElementpropCount++;
            }

            if (sAPGlobalInputTextIntoSAPElementreplaceExistingValueUsingDoubleClickDelete != null)
            {
                sAPGlobalInputTextIntoSAPElement["ReplaceExistingValueUsingDoubleClickDelete"] = ExpressionConverter.ConvertO(sAPGlobalInputTextIntoSAPElementreplaceExistingValueUsingDoubleClickDelete);
                sAPGlobalInputTextIntoSAPElementpropCount++;
            }

            if (sAPGlobalInputTextIntoSAPElementreplaceExistingValueUsingCTRLADelete != null)
            {
                sAPGlobalInputTextIntoSAPElement["ReplaceExistingValueUsingCTRLADelete"] = ExpressionConverter.ConvertO(sAPGlobalInputTextIntoSAPElementreplaceExistingValueUsingCTRLADelete);
                sAPGlobalInputTextIntoSAPElementpropCount++;
            }

            if (sAPGlobalInputTextIntoSAPElementtextToInput != null)
            {
                sAPGlobalInputTextIntoSAPElement["TextToInput"] = ExpressionConverter.ConvertO(sAPGlobalInputTextIntoSAPElementtextToInput);
                sAPGlobalInputTextIntoSAPElementpropCount++;
            }

            if (sAPGlobalInputTextIntoSAPElementsendKeyEvents != null)
            {
                sAPGlobalInputTextIntoSAPElement["SendKeyEvents"] = ExpressionConverter.ConvertO(sAPGlobalInputTextIntoSAPElementsendKeyEvents);
                sAPGlobalInputTextIntoSAPElementpropCount++;
            }

            if (sAPGlobalInputTextIntoSAPElementkeyIntervalInMilliseconds != null)
            {
                sAPGlobalInputTextIntoSAPElement["KeyIntervalInMilliseconds"] = ExpressionConverter.ConvertO(sAPGlobalInputTextIntoSAPElementkeyIntervalInMilliseconds);
                sAPGlobalInputTextIntoSAPElementpropCount++;
            }

            if (sAPGlobalInputTextIntoSAPElementdoubleClickIntervalInMilliseconds != null)
            {
                sAPGlobalInputTextIntoSAPElement["DoubleClickIntervalInMilliseconds"] = ExpressionConverter.ConvertO(sAPGlobalInputTextIntoSAPElementdoubleClickIntervalInMilliseconds);
                sAPGlobalInputTextIntoSAPElementpropCount++;
            }

            if (sAPGlobalInputTextIntoSAPElementdontInterpretSymbols != null)
            {
                sAPGlobalInputTextIntoSAPElement["DontInterpretSymbols"] = ExpressionConverter.ConvertO(sAPGlobalInputTextIntoSAPElementdontInterpretSymbols);
                sAPGlobalInputTextIntoSAPElementpropCount++;
            }

            sAPGlobalInputTextIntoSAPElementpropCount++;
            sAPGlobalInputTextIntoSAPElement["Workflow"] = ExpressionConverter.ConvertO(sAPGlobalInputTextIntoSAPElementworkflow);
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
            sAPGlobalInputPasswordIntoSAPElement["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGlobalInputPasswordIntoSAPElementsearchSAPElementId);
            if (sAPGlobalInputPasswordIntoSAPElementsetElementWindowTopMost != null)
            {
                sAPGlobalInputPasswordIntoSAPElement["SetElementWindowTopMost"] = ExpressionConverter.ConvertO(sAPGlobalInputPasswordIntoSAPElementsetElementWindowTopMost);
                sAPGlobalInputPasswordIntoSAPElementpropCount++;
            }

            if (sAPGlobalInputPasswordIntoSAPElementbringElementWindowToFront != null)
            {
                sAPGlobalInputPasswordIntoSAPElement["BringElementWindowToFront"] = ExpressionConverter.ConvertO(sAPGlobalInputPasswordIntoSAPElementbringElementWindowToFront);
                sAPGlobalInputPasswordIntoSAPElementpropCount++;
            }

            if (sAPGlobalInputPasswordIntoSAPElementtoggleWindow != null)
            {
                sAPGlobalInputPasswordIntoSAPElement["ToggleWindow"] = ExpressionConverter.ConvertO(sAPGlobalInputPasswordIntoSAPElementtoggleWindow);
                sAPGlobalInputPasswordIntoSAPElementpropCount++;
            }

            if (sAPGlobalInputPasswordIntoSAPElementtoggleUsesGlobalLeftMouseClickAgent != null)
            {
                sAPGlobalInputPasswordIntoSAPElement["ToggleUsesGlobalLeftMouseClickAgent"] = ExpressionConverter.ConvertO(sAPGlobalInputPasswordIntoSAPElementtoggleUsesGlobalLeftMouseClickAgent);
                sAPGlobalInputPasswordIntoSAPElementpropCount++;
            }

            if (sAPGlobalInputPasswordIntoSAPElementtoggleDelay != null)
            {
                sAPGlobalInputPasswordIntoSAPElement["ToggleDelay"] = ExpressionConverter.ConvertO(sAPGlobalInputPasswordIntoSAPElementtoggleDelay);
                sAPGlobalInputPasswordIntoSAPElementpropCount++;
            }

            if (sAPGlobalInputPasswordIntoSAPElementglobalMouseClickOnElement != null)
            {
                sAPGlobalInputPasswordIntoSAPElement["GlobalMouseClickOnElement"] = ExpressionConverter.ConvertO(sAPGlobalInputPasswordIntoSAPElementglobalMouseClickOnElement);
                sAPGlobalInputPasswordIntoSAPElementpropCount++;
            }

            if (sAPGlobalInputPasswordIntoSAPElementreplaceExistingValueUsingDoubleClickDelete != null)
            {
                sAPGlobalInputPasswordIntoSAPElement["ReplaceExistingValueUsingDoubleClickDelete"] = ExpressionConverter.ConvertO(sAPGlobalInputPasswordIntoSAPElementreplaceExistingValueUsingDoubleClickDelete);
                sAPGlobalInputPasswordIntoSAPElementpropCount++;
            }

            if (sAPGlobalInputPasswordIntoSAPElementreplaceExistingValueUsingCTRLADelete != null)
            {
                sAPGlobalInputPasswordIntoSAPElement["ReplaceExistingValueUsingCTRLADelete"] = ExpressionConverter.ConvertO(sAPGlobalInputPasswordIntoSAPElementreplaceExistingValueUsingCTRLADelete);
                sAPGlobalInputPasswordIntoSAPElementpropCount++;
            }

            sAPGlobalInputPasswordIntoSAPElementpropCount++;
            sAPGlobalInputPasswordIntoSAPElement["PasswordToInput"] = ExpressionConverter.ConvertO(sAPGlobalInputPasswordIntoSAPElementpasswordToInput);
            if (sAPGlobalInputPasswordIntoSAPElementsendKeyEvents != null)
            {
                sAPGlobalInputPasswordIntoSAPElement["SendKeyEvents"] = ExpressionConverter.ConvertO(sAPGlobalInputPasswordIntoSAPElementsendKeyEvents);
                sAPGlobalInputPasswordIntoSAPElementpropCount++;
            }

            if (sAPGlobalInputPasswordIntoSAPElementkeyIntervalInMilliseconds != null)
            {
                sAPGlobalInputPasswordIntoSAPElement["KeyIntervalInMilliseconds"] = ExpressionConverter.ConvertO(sAPGlobalInputPasswordIntoSAPElementkeyIntervalInMilliseconds);
                sAPGlobalInputPasswordIntoSAPElementpropCount++;
            }

            if (sAPGlobalInputPasswordIntoSAPElementdoubleClickIntervalInMilliseconds != null)
            {
                sAPGlobalInputPasswordIntoSAPElement["DoubleClickIntervalInMilliseconds"] = ExpressionConverter.ConvertO(sAPGlobalInputPasswordIntoSAPElementdoubleClickIntervalInMilliseconds);
                sAPGlobalInputPasswordIntoSAPElementpropCount++;
            }

            if (sAPGlobalInputPasswordIntoSAPElementdontInterpretSymbols != null)
            {
                sAPGlobalInputPasswordIntoSAPElement["DontInterpretSymbols"] = ExpressionConverter.ConvertO(sAPGlobalInputPasswordIntoSAPElementdontInterpretSymbols);
                sAPGlobalInputPasswordIntoSAPElementpropCount++;
            }

            sAPGlobalInputPasswordIntoSAPElementpropCount++;
            sAPGlobalInputPasswordIntoSAPElement["Workflow"] = ExpressionConverter.ConvertO(sAPGlobalInputPasswordIntoSAPElementworkflow);
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
            sAPGetListSelectionElementItems["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGetListSelectionElementItemssearchSAPElementId);
            sAPGetListSelectionElementItemspropCount++;
            sAPGetListSelectionElementItems["Workflow"] = ExpressionConverter.ConvertO(sAPGetListSelectionElementItemsworkflow);
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
            sAPGetAllChildSAPElementProperties["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGetAllChildSAPElementPropertiessearchSAPElementId);
            if (sAPGetAllChildSAPElementPropertiesfirstItemToReturn != null)
            {
                sAPGetAllChildSAPElementProperties["FirstItemToReturn"] = ExpressionConverter.ConvertO(sAPGetAllChildSAPElementPropertiesfirstItemToReturn);
                sAPGetAllChildSAPElementPropertiespropCount++;
            }

            if (sAPGetAllChildSAPElementPropertiesmaxItemsToReturn != null)
            {
                sAPGetAllChildSAPElementProperties["MaxItemsToReturn"] = ExpressionConverter.ConvertO(sAPGetAllChildSAPElementPropertiesmaxItemsToReturn);
                sAPGetAllChildSAPElementPropertiespropCount++;
            }

            if (sAPGetAllChildSAPElementPropertiessearchSAPElementType != null)
            {
                sAPGetAllChildSAPElementProperties["SearchSAPElementType"] = ExpressionConverter.ConvertO(sAPGetAllChildSAPElementPropertiessearchSAPElementType);
                sAPGetAllChildSAPElementPropertiespropCount++;
            }

            if (sAPGetAllChildSAPElementPropertiesmaxTextLength != null)
            {
                sAPGetAllChildSAPElementProperties["MaxTextLength"] = ExpressionConverter.ConvertO(sAPGetAllChildSAPElementPropertiesmaxTextLength);
                sAPGetAllChildSAPElementPropertiespropCount++;
            }

            sAPGetAllChildSAPElementPropertiespropCount++;
            sAPGetAllChildSAPElementProperties["Workflow"] = ExpressionConverter.ConvertO(sAPGetAllChildSAPElementPropertiesworkflow);
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
                sAPGetSAPSessionTopLevelSAPElementProperties["FirstItemToReturn"] = ExpressionConverter.ConvertO(sAPGetSAPSessionTopLevelSAPElementPropertiesfirstItemToReturn);
                sAPGetSAPSessionTopLevelSAPElementPropertiespropCount++;
            }

            if (sAPGetSAPSessionTopLevelSAPElementPropertiesmaxItemsToReturn != null)
            {
                sAPGetSAPSessionTopLevelSAPElementProperties["MaxItemsToReturn"] = ExpressionConverter.ConvertO(sAPGetSAPSessionTopLevelSAPElementPropertiesmaxItemsToReturn);
                sAPGetSAPSessionTopLevelSAPElementPropertiespropCount++;
            }

            if (sAPGetSAPSessionTopLevelSAPElementPropertiessearchSAPElementType != null)
            {
                sAPGetSAPSessionTopLevelSAPElementProperties["SearchSAPElementType"] = ExpressionConverter.ConvertO(sAPGetSAPSessionTopLevelSAPElementPropertiessearchSAPElementType);
                sAPGetSAPSessionTopLevelSAPElementPropertiespropCount++;
            }

            if (sAPGetSAPSessionTopLevelSAPElementPropertiesmaxTextLength != null)
            {
                sAPGetSAPSessionTopLevelSAPElementProperties["MaxTextLength"] = ExpressionConverter.ConvertO(sAPGetSAPSessionTopLevelSAPElementPropertiesmaxTextLength);
                sAPGetSAPSessionTopLevelSAPElementPropertiespropCount++;
            }

            sAPGetSAPSessionTopLevelSAPElementPropertiespropCount++;
            sAPGetSAPSessionTopLevelSAPElementProperties["Workflow"] = ExpressionConverter.ConvertO(sAPGetSAPSessionTopLevelSAPElementPropertiesworkflow);
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
            sAPGetSAPElementParentId["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGetSAPElementParentIdsearchSAPElementId);
            sAPGetSAPElementParentIdpropCount++;
            sAPGetSAPElementParentId["Workflow"] = ExpressionConverter.ConvertO(sAPGetSAPElementParentIdworkflow);
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
            sAPGetElementPropertiesAsList["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGetElementPropertiesAsListsearchSAPElementId);
            if (sAPGetElementPropertiesAsListmaxTextLength != null)
            {
                sAPGetElementPropertiesAsList["MaxTextLength"] = ExpressionConverter.ConvertO(sAPGetElementPropertiesAsListmaxTextLength);
                sAPGetElementPropertiesAsListpropCount++;
            }

            sAPGetElementPropertiesAsListpropCount++;
            sAPGetElementPropertiesAsList["Workflow"] = ExpressionConverter.ConvertO(sAPGetElementPropertiesAsListworkflow);
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
                sAPOpenConnection["ConnectSynchronous"] = ExpressionConverter.ConvertO(sAPOpenConnectionconnectSynchronous);
                sAPOpenConnectionpropCount++;
            }

            if (sAPOpenConnectionconnectToSession != null)
            {
                sAPOpenConnection["ConnectToSession"] = ExpressionConverter.ConvertO(sAPOpenConnectionconnectToSession);
                sAPOpenConnectionpropCount++;
            }

            sAPOpenConnectionpropCount++;
            sAPOpenConnection["Workflow"] = ExpressionConverter.ConvertO(sAPOpenConnectionworkflow);
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
            sAPGetSAPTableProperties["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGetSAPTablePropertiessearchSAPElementId);
            sAPGetSAPTablePropertiespropCount++;
            sAPGetSAPTableProperties["Workflow"] = ExpressionConverter.ConvertO(sAPGetSAPTablePropertiesworkflow);
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
            sAPGetSAPTableVisibleCellTextContentsAtIndex["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGetSAPTableVisibleCellTextContentsAtIndexsearchSAPElementId);
            if (sAPGetSAPTableVisibleCellTextContentsAtIndexvisibleRowIndex != null)
            {
                sAPGetSAPTableVisibleCellTextContentsAtIndex["VisibleRowIndex"] = ExpressionConverter.ConvertO(sAPGetSAPTableVisibleCellTextContentsAtIndexvisibleRowIndex);
                sAPGetSAPTableVisibleCellTextContentsAtIndexpropCount++;
            }

            if (sAPGetSAPTableVisibleCellTextContentsAtIndexvisibleColumnIndex != null)
            {
                sAPGetSAPTableVisibleCellTextContentsAtIndex["VisibleColumnIndex"] = ExpressionConverter.ConvertO(sAPGetSAPTableVisibleCellTextContentsAtIndexvisibleColumnIndex);
                sAPGetSAPTableVisibleCellTextContentsAtIndexpropCount++;
            }

            if (sAPGetSAPTableVisibleCellTextContentsAtIndexcheckedElementValue != null)
            {
                sAPGetSAPTableVisibleCellTextContentsAtIndex["CheckedElementValue"] = ExpressionConverter.ConvertO(sAPGetSAPTableVisibleCellTextContentsAtIndexcheckedElementValue);
                sAPGetSAPTableVisibleCellTextContentsAtIndexpropCount++;
            }

            sAPGetSAPTableVisibleCellTextContentsAtIndexpropCount++;
            sAPGetSAPTableVisibleCellTextContentsAtIndex["Workflow"] = ExpressionConverter.ConvertO(sAPGetSAPTableVisibleCellTextContentsAtIndexworkflow);
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
            sAPGetSAPTableVisibleCellPropertiesAtIndex["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGetSAPTableVisibleCellPropertiesAtIndexsearchSAPElementId);
            if (sAPGetSAPTableVisibleCellPropertiesAtIndexvisibleRowIndex != null)
            {
                sAPGetSAPTableVisibleCellPropertiesAtIndex["VisibleRowIndex"] = ExpressionConverter.ConvertO(sAPGetSAPTableVisibleCellPropertiesAtIndexvisibleRowIndex);
                sAPGetSAPTableVisibleCellPropertiesAtIndexpropCount++;
            }

            if (sAPGetSAPTableVisibleCellPropertiesAtIndexvisibleColumnIndex != null)
            {
                sAPGetSAPTableVisibleCellPropertiesAtIndex["VisibleColumnIndex"] = ExpressionConverter.ConvertO(sAPGetSAPTableVisibleCellPropertiesAtIndexvisibleColumnIndex);
                sAPGetSAPTableVisibleCellPropertiesAtIndexpropCount++;
            }

            sAPGetSAPTableVisibleCellPropertiesAtIndexpropCount++;
            sAPGetSAPTableVisibleCellPropertiesAtIndex["Workflow"] = ExpressionConverter.ConvertO(sAPGetSAPTableVisibleCellPropertiesAtIndexworkflow);
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
            sAPSetSAPTableVisibleCellTextContentsAtIndex["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPSetSAPTableVisibleCellTextContentsAtIndexsearchSAPElementId);
            if (sAPSetSAPTableVisibleCellTextContentsAtIndexvisibleRowIndex != null)
            {
                sAPSetSAPTableVisibleCellTextContentsAtIndex["VisibleRowIndex"] = ExpressionConverter.ConvertO(sAPSetSAPTableVisibleCellTextContentsAtIndexvisibleRowIndex);
                sAPSetSAPTableVisibleCellTextContentsAtIndexpropCount++;
            }

            if (sAPSetSAPTableVisibleCellTextContentsAtIndexvisibleColumnIndex != null)
            {
                sAPSetSAPTableVisibleCellTextContentsAtIndex["VisibleColumnIndex"] = ExpressionConverter.ConvertO(sAPSetSAPTableVisibleCellTextContentsAtIndexvisibleColumnIndex);
                sAPSetSAPTableVisibleCellTextContentsAtIndexpropCount++;
            }

            if (sAPSetSAPTableVisibleCellTextContentsAtIndextextToInput != null)
            {
                sAPSetSAPTableVisibleCellTextContentsAtIndex["TextToInput"] = ExpressionConverter.ConvertO(sAPSetSAPTableVisibleCellTextContentsAtIndextextToInput);
                sAPSetSAPTableVisibleCellTextContentsAtIndexpropCount++;
            }

            if (sAPSetSAPTableVisibleCellTextContentsAtIndexreplaceExistingValue != null)
            {
                sAPSetSAPTableVisibleCellTextContentsAtIndex["ReplaceExistingValue"] = ExpressionConverter.ConvertO(sAPSetSAPTableVisibleCellTextContentsAtIndexreplaceExistingValue);
                sAPSetSAPTableVisibleCellTextContentsAtIndexpropCount++;
            }

            if (sAPSetSAPTableVisibleCellTextContentsAtIndexinsertPosition != null)
            {
                sAPSetSAPTableVisibleCellTextContentsAtIndex["InsertPosition"] = ExpressionConverter.ConvertO(sAPSetSAPTableVisibleCellTextContentsAtIndexinsertPosition);
                sAPSetSAPTableVisibleCellTextContentsAtIndexpropCount++;
            }

            sAPSetSAPTableVisibleCellTextContentsAtIndexpropCount++;
            sAPSetSAPTableVisibleCellTextContentsAtIndex["Workflow"] = ExpressionConverter.ConvertO(sAPSetSAPTableVisibleCellTextContentsAtIndexworkflow);
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
            sAPCheckSAPTableVisibleCellCheckboxAtIndex["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPCheckSAPTableVisibleCellCheckboxAtIndexsearchSAPElementId);
            if (sAPCheckSAPTableVisibleCellCheckboxAtIndexvisibleRowIndex != null)
            {
                sAPCheckSAPTableVisibleCellCheckboxAtIndex["VisibleRowIndex"] = ExpressionConverter.ConvertO(sAPCheckSAPTableVisibleCellCheckboxAtIndexvisibleRowIndex);
                sAPCheckSAPTableVisibleCellCheckboxAtIndexpropCount++;
            }

            if (sAPCheckSAPTableVisibleCellCheckboxAtIndexvisibleColumnIndex != null)
            {
                sAPCheckSAPTableVisibleCellCheckboxAtIndex["VisibleColumnIndex"] = ExpressionConverter.ConvertO(sAPCheckSAPTableVisibleCellCheckboxAtIndexvisibleColumnIndex);
                sAPCheckSAPTableVisibleCellCheckboxAtIndexpropCount++;
            }

            if (sAPCheckSAPTableVisibleCellCheckboxAtIndexcheckCellElement != null)
            {
                sAPCheckSAPTableVisibleCellCheckboxAtIndex["CheckCellElement"] = ExpressionConverter.ConvertO(sAPCheckSAPTableVisibleCellCheckboxAtIndexcheckCellElement);
                sAPCheckSAPTableVisibleCellCheckboxAtIndexpropCount++;
            }

            sAPCheckSAPTableVisibleCellCheckboxAtIndexpropCount++;
            sAPCheckSAPTableVisibleCellCheckboxAtIndex["Workflow"] = ExpressionConverter.ConvertO(sAPCheckSAPTableVisibleCellCheckboxAtIndexworkflow);
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
            sAPPressSAPTableVisibleCellAtIndex["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPPressSAPTableVisibleCellAtIndexsearchSAPElementId);
            if (sAPPressSAPTableVisibleCellAtIndexvisibleRowIndex != null)
            {
                sAPPressSAPTableVisibleCellAtIndex["VisibleRowIndex"] = ExpressionConverter.ConvertO(sAPPressSAPTableVisibleCellAtIndexvisibleRowIndex);
                sAPPressSAPTableVisibleCellAtIndexpropCount++;
            }

            if (sAPPressSAPTableVisibleCellAtIndexvisibleColumnIndex != null)
            {
                sAPPressSAPTableVisibleCellAtIndex["VisibleColumnIndex"] = ExpressionConverter.ConvertO(sAPPressSAPTableVisibleCellAtIndexvisibleColumnIndex);
                sAPPressSAPTableVisibleCellAtIndexpropCount++;
            }

            sAPPressSAPTableVisibleCellAtIndexpropCount++;
            sAPPressSAPTableVisibleCellAtIndex["Workflow"] = ExpressionConverter.ConvertO(sAPPressSAPTableVisibleCellAtIndexworkflow);
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
            sAPScrollSAPTable["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPScrollSAPTablesearchSAPElementId);
            if (sAPScrollSAPTablemoveHorizontalScrollbar != null)
            {
                sAPScrollSAPTable["MoveHorizontalScrollbar"] = ExpressionConverter.ConvertO(sAPScrollSAPTablemoveHorizontalScrollbar);
                sAPScrollSAPTablepropCount++;
            }

            if (sAPScrollSAPTablehorizontalScrollbarPosition != null)
            {
                sAPScrollSAPTable["HorizontalScrollbarPosition"] = ExpressionConverter.ConvertO(sAPScrollSAPTablehorizontalScrollbarPosition);
                sAPScrollSAPTablepropCount++;
            }

            if (sAPScrollSAPTablemoveVerticalScrollbar != null)
            {
                sAPScrollSAPTable["MoveVerticalScrollbar"] = ExpressionConverter.ConvertO(sAPScrollSAPTablemoveVerticalScrollbar);
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
            sAPGetTableVisibleTextContents["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGetTableVisibleTextContentssearchSAPElementId);
            if (sAPGetTableVisibleTextContentsfirstVisibleRowToReturn != null)
            {
                sAPGetTableVisibleTextContents["FirstVisibleRowToReturn"] = ExpressionConverter.ConvertO(sAPGetTableVisibleTextContentsfirstVisibleRowToReturn);
                sAPGetTableVisibleTextContentspropCount++;
            }

            if (sAPGetTableVisibleTextContentsmaxRowsToReturn != null)
            {
                sAPGetTableVisibleTextContents["MaxRowsToReturn"] = ExpressionConverter.ConvertO(sAPGetTableVisibleTextContentsmaxRowsToReturn);
                sAPGetTableVisibleTextContentspropCount++;
            }

            if (sAPGetTableVisibleTextContentsfirstVisibleColumnToReturn != null)
            {
                sAPGetTableVisibleTextContents["FirstVisibleColumnToReturn"] = ExpressionConverter.ConvertO(sAPGetTableVisibleTextContentsfirstVisibleColumnToReturn);
                sAPGetTableVisibleTextContentspropCount++;
            }

            if (sAPGetTableVisibleTextContentsmaxColumnsToReturn != null)
            {
                sAPGetTableVisibleTextContents["MaxColumnsToReturn"] = ExpressionConverter.ConvertO(sAPGetTableVisibleTextContentsmaxColumnsToReturn);
                sAPGetTableVisibleTextContentspropCount++;
            }

            if (sAPGetTableVisibleTextContentsuseColumnHeadersFromTable != null)
            {
                sAPGetTableVisibleTextContents["UseColumnHeadersFromTable"] = ExpressionConverter.ConvertO(sAPGetTableVisibleTextContentsuseColumnHeadersFromTable);
                sAPGetTableVisibleTextContentspropCount++;
            }

            if (sAPGetTableVisibleTextContentsreturnRowIndexInOutputCollection != null)
            {
                sAPGetTableVisibleTextContents["ReturnRowIndexInOutputCollection"] = ExpressionConverter.ConvertO(sAPGetTableVisibleTextContentsreturnRowIndexInOutputCollection);
                sAPGetTableVisibleTextContentspropCount++;
            }

            if (sAPGetTableVisibleTextContentsnameOfColumnToStoreRowIndex != null)
            {
                sAPGetTableVisibleTextContents["NameOfColumnToStoreRowIndex"] = ExpressionConverter.ConvertO(sAPGetTableVisibleTextContentsnameOfColumnToStoreRowIndex);
                sAPGetTableVisibleTextContentspropCount++;
            }

            if (sAPGetTableVisibleTextContentscheckedElementValue != null)
            {
                sAPGetTableVisibleTextContents["CheckedElementValue"] = ExpressionConverter.ConvertO(sAPGetTableVisibleTextContentscheckedElementValue);
                sAPGetTableVisibleTextContentspropCount++;
            }

            sAPGetTableVisibleTextContentspropCount++;
            sAPGetTableVisibleTextContents["Workflow"] = ExpressionConverter.ConvertO(sAPGetTableVisibleTextContentsworkflow);
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
            sAPSelectSAPTableRow["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPSelectSAPTableRowsearchSAPElementId);
            if (sAPSelectSAPTableRowvisibleRowIndex != null)
            {
                sAPSelectSAPTableRow["VisibleRowIndex"] = ExpressionConverter.ConvertO(sAPSelectSAPTableRowvisibleRowIndex);
                sAPSelectSAPTableRowpropCount++;
            }

            if (sAPSelectSAPTableRowselect != null)
            {
                sAPSelectSAPTableRow["Select"] = ExpressionConverter.ConvertO(sAPSelectSAPTableRowselect);
                sAPSelectSAPTableRowpropCount++;
            }

            sAPSelectSAPTableRowpropCount++;
            sAPSelectSAPTableRow["Workflow"] = ExpressionConverter.ConvertO(sAPSelectSAPTableRowworkflow);
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
            sAPSelectSAPTableColumn["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPSelectSAPTableColumnsearchSAPElementId);
            if (sAPSelectSAPTableColumnvisibleColumnIndex != null)
            {
                sAPSelectSAPTableColumn["VisibleColumnIndex"] = ExpressionConverter.ConvertO(sAPSelectSAPTableColumnvisibleColumnIndex);
                sAPSelectSAPTableColumnpropCount++;
            }

            if (sAPSelectSAPTableColumnselect != null)
            {
                sAPSelectSAPTableColumn["Select"] = ExpressionConverter.ConvertO(sAPSelectSAPTableColumnselect);
                sAPSelectSAPTableColumnpropCount++;
            }

            sAPSelectSAPTableColumnpropCount++;
            sAPSelectSAPTableColumn["Workflow"] = ExpressionConverter.ConvertO(sAPSelectSAPTableColumnworkflow);
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
            sAPGetTreeNodes["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGetTreeNodessearchSAPElementId);
            if (sAPGetTreeNodesparentNodeKey != null)
            {
                sAPGetTreeNodes["ParentNodeKey"] = ExpressionConverter.ConvertO(sAPGetTreeNodesparentNodeKey);
                sAPGetTreeNodespropCount++;
            }

            if (sAPGetTreeNodesprocessSubNodes != null)
            {
                sAPGetTreeNodes["ProcessSubNodes"] = ExpressionConverter.ConvertO(sAPGetTreeNodesprocessSubNodes);
                sAPGetTreeNodespropCount++;
            }

            sAPGetTreeNodespropCount++;
            sAPGetTreeNodes["Workflow"] = ExpressionConverter.ConvertO(sAPGetTreeNodesworkflow);
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
                sAPDoubleClickTreeItem["SearchNodeTextIsRegularExpression"] = ExpressionConverter.ConvertO(sAPDoubleClickTreeItemsearchNodeTextIsRegularExpression);
                sAPDoubleClickTreeItempropCount++;
            }

            if (sAPDoubleClickTreeItemsearchNodeTextIsCaseSensitive != null)
            {
                sAPDoubleClickTreeItem["SearchNodeTextIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPDoubleClickTreeItemsearchNodeTextIsCaseSensitive);
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
                sAPDoubleClickTreeItem["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(sAPDoubleClickTreeItemsearchColumnTitleIsRegularExpression);
                sAPDoubleClickTreeItempropCount++;
            }

            if (sAPDoubleClickTreeItemsearchColumnTitleIsCaseSensitive != null)
            {
                sAPDoubleClickTreeItem["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPDoubleClickTreeItemsearchColumnTitleIsCaseSensitive);
                sAPDoubleClickTreeItempropCount++;
            }

            sAPDoubleClickTreeItempropCount++;
            sAPDoubleClickTreeItem["Workflow"] = ExpressionConverter.ConvertO(sAPDoubleClickTreeItemworkflow);
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
                sAPSelectTreeItem["SearchNodeTextIsRegularExpression"] = ExpressionConverter.ConvertO(sAPSelectTreeItemsearchNodeTextIsRegularExpression);
                sAPSelectTreeItempropCount++;
            }

            if (sAPSelectTreeItemsearchNodeTextIsCaseSensitive != null)
            {
                sAPSelectTreeItem["SearchNodeTextIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPSelectTreeItemsearchNodeTextIsCaseSensitive);
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
                sAPSelectTreeItem["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(sAPSelectTreeItemsearchColumnTitleIsRegularExpression);
                sAPSelectTreeItempropCount++;
            }

            if (sAPSelectTreeItemsearchColumnTitleIsCaseSensitive != null)
            {
                sAPSelectTreeItem["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPSelectTreeItemsearchColumnTitleIsCaseSensitive);
                sAPSelectTreeItempropCount++;
            }

            if (sAPSelectTreeItemselect != null)
            {
                sAPSelectTreeItem["Select"] = ExpressionConverter.ConvertO(sAPSelectTreeItemselect);
                sAPSelectTreeItempropCount++;
            }

            if (sAPSelectTreeItemdeselectAllFirst != null)
            {
                sAPSelectTreeItem["DeselectAllFirst"] = ExpressionConverter.ConvertO(sAPSelectTreeItemdeselectAllFirst);
                sAPSelectTreeItempropCount++;
            }

            sAPSelectTreeItempropCount++;
            sAPSelectTreeItem["Workflow"] = ExpressionConverter.ConvertO(sAPSelectTreeItemworkflow);
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
                sAPExpandTreeNode["SearchNodeTextIsRegularExpression"] = ExpressionConverter.ConvertO(sAPExpandTreeNodesearchNodeTextIsRegularExpression);
                sAPExpandTreeNodepropCount++;
            }

            if (sAPExpandTreeNodesearchNodeTextIsCaseSensitive != null)
            {
                sAPExpandTreeNode["SearchNodeTextIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPExpandTreeNodesearchNodeTextIsCaseSensitive);
                sAPExpandTreeNodepropCount++;
            }

            if (sAPExpandTreeNodeexpand != null)
            {
                sAPExpandTreeNode["Expand"] = ExpressionConverter.ConvertO(sAPExpandTreeNodeexpand);
                sAPExpandTreeNodepropCount++;
            }

            sAPExpandTreeNodepropCount++;
            sAPExpandTreeNode["Workflow"] = ExpressionConverter.ConvertO(sAPExpandTreeNodeworkflow);
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
            sAPDeselectAllTreeNodes["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPDeselectAllTreeNodessearchSAPElementId);
            sAPDeselectAllTreeNodespropCount++;
            sAPDeselectAllTreeNodes["Workflow"] = ExpressionConverter.ConvertO(sAPDeselectAllTreeNodesworkflow);
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
                sAPOpenContextMenuOnTreeItem["SearchNodeTextIsRegularExpression"] = ExpressionConverter.ConvertO(sAPOpenContextMenuOnTreeItemsearchNodeTextIsRegularExpression);
                sAPOpenContextMenuOnTreeItempropCount++;
            }

            if (sAPOpenContextMenuOnTreeItemsearchNodeTextIsCaseSensitive != null)
            {
                sAPOpenContextMenuOnTreeItem["SearchNodeTextIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPOpenContextMenuOnTreeItemsearchNodeTextIsCaseSensitive);
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
                sAPOpenContextMenuOnTreeItem["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(sAPOpenContextMenuOnTreeItemsearchColumnTitleIsRegularExpression);
                sAPOpenContextMenuOnTreeItempropCount++;
            }

            if (sAPOpenContextMenuOnTreeItemsearchColumnTitleIsCaseSensitive != null)
            {
                sAPOpenContextMenuOnTreeItem["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPOpenContextMenuOnTreeItemsearchColumnTitleIsCaseSensitive);
                sAPOpenContextMenuOnTreeItempropCount++;
            }

            sAPOpenContextMenuOnTreeItempropCount++;
            sAPOpenContextMenuOnTreeItem["Workflow"] = ExpressionConverter.ConvertO(sAPOpenContextMenuOnTreeItemworkflow);
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
            sAPGetTreeTextContents["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGetTreeTextContentssearchSAPElementId);
            if (sAPGetTreeTextContentsfirstRowToReturn != null)
            {
                sAPGetTreeTextContents["FirstRowToReturn"] = ExpressionConverter.ConvertO(sAPGetTreeTextContentsfirstRowToReturn);
                sAPGetTreeTextContentspropCount++;
            }

            if (sAPGetTreeTextContentsmaxRowsToReturn != null)
            {
                sAPGetTreeTextContents["MaxRowsToReturn"] = ExpressionConverter.ConvertO(sAPGetTreeTextContentsmaxRowsToReturn);
                sAPGetTreeTextContentspropCount++;
            }

            if (sAPGetTreeTextContentsfirstColumnToReturn != null)
            {
                sAPGetTreeTextContents["FirstColumnToReturn"] = ExpressionConverter.ConvertO(sAPGetTreeTextContentsfirstColumnToReturn);
                sAPGetTreeTextContentspropCount++;
            }

            if (sAPGetTreeTextContentsmaxColumnsToReturn != null)
            {
                sAPGetTreeTextContents["MaxColumnsToReturn"] = ExpressionConverter.ConvertO(sAPGetTreeTextContentsmaxColumnsToReturn);
                sAPGetTreeTextContentspropCount++;
            }

            if (sAPGetTreeTextContentsuseColumnHeadersFromTree != null)
            {
                sAPGetTreeTextContents["UseColumnHeadersFromTree"] = ExpressionConverter.ConvertO(sAPGetTreeTextContentsuseColumnHeadersFromTree);
                sAPGetTreeTextContentspropCount++;
            }

            if (sAPGetTreeTextContentsreturnRowIndexInOutputCollection != null)
            {
                sAPGetTreeTextContents["ReturnRowIndexInOutputCollection"] = ExpressionConverter.ConvertO(sAPGetTreeTextContentsreturnRowIndexInOutputCollection);
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
                sAPSetTreeColumnWidth["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(sAPSetTreeColumnWidthsearchColumnTitleIsRegularExpression);
                sAPSetTreeColumnWidthpropCount++;
            }

            if (sAPSetTreeColumnWidthsearchColumnTitleIsCaseSensitive != null)
            {
                sAPSetTreeColumnWidth["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPSetTreeColumnWidthsearchColumnTitleIsCaseSensitive);
                sAPSetTreeColumnWidthpropCount++;
            }

            if (sAPSetTreeColumnWidthcolumnWidthInPixels != null)
            {
                sAPSetTreeColumnWidth["ColumnWidthInPixels"] = ExpressionConverter.ConvertO(sAPSetTreeColumnWidthcolumnWidthInPixels);
                sAPSetTreeColumnWidthpropCount++;
            }

            sAPSetTreeColumnWidthpropCount++;
            sAPSetTreeColumnWidth["Workflow"] = ExpressionConverter.ConvertO(sAPSetTreeColumnWidthworkflow);
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
                sAPPressButtonOnTreeItem["SearchNodeTextIsRegularExpression"] = ExpressionConverter.ConvertO(sAPPressButtonOnTreeItemsearchNodeTextIsRegularExpression);
                sAPPressButtonOnTreeItempropCount++;
            }

            if (sAPPressButtonOnTreeItemsearchNodeTextIsCaseSensitive != null)
            {
                sAPPressButtonOnTreeItem["SearchNodeTextIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPPressButtonOnTreeItemsearchNodeTextIsCaseSensitive);
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
                sAPPressButtonOnTreeItem["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(sAPPressButtonOnTreeItemsearchColumnTitleIsRegularExpression);
                sAPPressButtonOnTreeItempropCount++;
            }

            if (sAPPressButtonOnTreeItemsearchColumnTitleIsCaseSensitive != null)
            {
                sAPPressButtonOnTreeItem["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPPressButtonOnTreeItemsearchColumnTitleIsCaseSensitive);
                sAPPressButtonOnTreeItempropCount++;
            }

            if (sAPPressButtonOnTreeItemforce != null)
            {
                sAPPressButtonOnTreeItem["Force"] = ExpressionConverter.ConvertO(sAPPressButtonOnTreeItemforce);
                sAPPressButtonOnTreeItempropCount++;
            }

            sAPPressButtonOnTreeItempropCount++;
            sAPPressButtonOnTreeItem["Workflow"] = ExpressionConverter.ConvertO(sAPPressButtonOnTreeItemworkflow);
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
                sAPClickLinkOnTreeItem["SearchNodeTextIsRegularExpression"] = ExpressionConverter.ConvertO(sAPClickLinkOnTreeItemsearchNodeTextIsRegularExpression);
                sAPClickLinkOnTreeItempropCount++;
            }

            if (sAPClickLinkOnTreeItemsearchNodeTextIsCaseSensitive != null)
            {
                sAPClickLinkOnTreeItem["SearchNodeTextIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPClickLinkOnTreeItemsearchNodeTextIsCaseSensitive);
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
                sAPClickLinkOnTreeItem["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(sAPClickLinkOnTreeItemsearchColumnTitleIsRegularExpression);
                sAPClickLinkOnTreeItempropCount++;
            }

            if (sAPClickLinkOnTreeItemsearchColumnTitleIsCaseSensitive != null)
            {
                sAPClickLinkOnTreeItem["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPClickLinkOnTreeItemsearchColumnTitleIsCaseSensitive);
                sAPClickLinkOnTreeItempropCount++;
            }

            if (sAPClickLinkOnTreeItemforce != null)
            {
                sAPClickLinkOnTreeItem["Force"] = ExpressionConverter.ConvertO(sAPClickLinkOnTreeItemforce);
                sAPClickLinkOnTreeItempropCount++;
            }

            sAPClickLinkOnTreeItempropCount++;
            sAPClickLinkOnTreeItem["Workflow"] = ExpressionConverter.ConvertO(sAPClickLinkOnTreeItemworkflow);
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
                sAPCheckTreeItem["SearchNodeTextIsRegularExpression"] = ExpressionConverter.ConvertO(sAPCheckTreeItemsearchNodeTextIsRegularExpression);
                sAPCheckTreeItempropCount++;
            }

            if (sAPCheckTreeItemsearchNodeTextIsCaseSensitive != null)
            {
                sAPCheckTreeItem["SearchNodeTextIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPCheckTreeItemsearchNodeTextIsCaseSensitive);
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
                sAPCheckTreeItem["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(sAPCheckTreeItemsearchColumnTitleIsRegularExpression);
                sAPCheckTreeItempropCount++;
            }

            if (sAPCheckTreeItemsearchColumnTitleIsCaseSensitive != null)
            {
                sAPCheckTreeItem["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPCheckTreeItemsearchColumnTitleIsCaseSensitive);
                sAPCheckTreeItempropCount++;
            }

            if (sAPCheckTreeItemcheckItem != null)
            {
                sAPCheckTreeItem["CheckItem"] = ExpressionConverter.ConvertO(sAPCheckTreeItemcheckItem);
                sAPCheckTreeItempropCount++;
            }

            if (sAPCheckTreeItemforce != null)
            {
                sAPCheckTreeItem["Force"] = ExpressionConverter.ConvertO(sAPCheckTreeItemforce);
                sAPCheckTreeItempropCount++;
            }

            sAPCheckTreeItempropCount++;
            sAPCheckTreeItem["Workflow"] = ExpressionConverter.ConvertO(sAPCheckTreeItemworkflow);
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
            sAPGetTreeColumnHeaders["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGetTreeColumnHeaderssearchSAPElementId);
            sAPGetTreeColumnHeaderspropCount++;
            sAPGetTreeColumnHeaders["Workflow"] = ExpressionConverter.ConvertO(sAPGetTreeColumnHeadersworkflow);
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
                sAPGetTreeItemProperties["SearchNodeTextIsRegularExpression"] = ExpressionConverter.ConvertO(sAPGetTreeItemPropertiessearchNodeTextIsRegularExpression);
                sAPGetTreeItemPropertiespropCount++;
            }

            if (sAPGetTreeItemPropertiessearchNodeTextIsCaseSensitive != null)
            {
                sAPGetTreeItemProperties["SearchNodeTextIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPGetTreeItemPropertiessearchNodeTextIsCaseSensitive);
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
                sAPGetTreeItemProperties["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(sAPGetTreeItemPropertiessearchColumnTitleIsRegularExpression);
                sAPGetTreeItemPropertiespropCount++;
            }

            if (sAPGetTreeItemPropertiessearchColumnTitleIsCaseSensitive != null)
            {
                sAPGetTreeItemProperties["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPGetTreeItemPropertiessearchColumnTitleIsCaseSensitive);
                sAPGetTreeItemPropertiespropCount++;
            }

            sAPGetTreeItemPropertiespropCount++;
            sAPGetTreeItemProperties["Workflow"] = ExpressionConverter.ConvertO(sAPGetTreeItemPropertiesworkflow);
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
            sAPGetShellToolbarElements["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGetShellToolbarElementssearchSAPElementId);
            sAPGetShellToolbarElementspropCount++;
            sAPGetShellToolbarElements["Workflow"] = ExpressionConverter.ConvertO(sAPGetShellToolbarElementsworkflow);
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
                sAPPressShellToolbarElement["SearchToolbarElementIndex"] = ExpressionConverter.ConvertO(sAPPressShellToolbarElementsearchToolbarElementIndex);
                sAPPressShellToolbarElementpropCount++;
            }

            if (sAPPressShellToolbarElementsearchToolbarTextIsRegularExpression != null)
            {
                sAPPressShellToolbarElement["SearchToolbarTextIsRegularExpression"] = ExpressionConverter.ConvertO(sAPPressShellToolbarElementsearchToolbarTextIsRegularExpression);
                sAPPressShellToolbarElementpropCount++;
            }

            if (sAPPressShellToolbarElementsearchToolbarTextIsCaseSensitive != null)
            {
                sAPPressShellToolbarElement["SearchToolbarTextIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPPressShellToolbarElementsearchToolbarTextIsCaseSensitive);
                sAPPressShellToolbarElementpropCount++;
            }

            sAPPressShellToolbarElementpropCount++;
            sAPPressShellToolbarElement["Workflow"] = ExpressionConverter.ConvertO(sAPPressShellToolbarElementworkflow);
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
                sAPPressShellToolbarElementContextButton["SearchToolbarElementIndex"] = ExpressionConverter.ConvertO(sAPPressShellToolbarElementContextButtonsearchToolbarElementIndex);
                sAPPressShellToolbarElementContextButtonpropCount++;
            }

            if (sAPPressShellToolbarElementContextButtonsearchToolbarTextIsRegularExpression != null)
            {
                sAPPressShellToolbarElementContextButton["SearchToolbarTextIsRegularExpression"] = ExpressionConverter.ConvertO(sAPPressShellToolbarElementContextButtonsearchToolbarTextIsRegularExpression);
                sAPPressShellToolbarElementContextButtonpropCount++;
            }

            if (sAPPressShellToolbarElementContextButtonsearchToolbarTextIsCaseSensitive != null)
            {
                sAPPressShellToolbarElementContextButton["SearchToolbarTextIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPPressShellToolbarElementContextButtonsearchToolbarTextIsCaseSensitive);
                sAPPressShellToolbarElementContextButtonpropCount++;
            }

            sAPPressShellToolbarElementContextButtonpropCount++;
            sAPPressShellToolbarElementContextButton["Workflow"] = ExpressionConverter.ConvertO(sAPPressShellToolbarElementContextButtonworkflow);
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
                sAPSelectShellToolbarMenuItem["SearchToolbarElementIndex"] = ExpressionConverter.ConvertO(sAPSelectShellToolbarMenuItemsearchToolbarElementIndex);
                sAPSelectShellToolbarMenuItempropCount++;
            }

            if (sAPSelectShellToolbarMenuItemsearchToolbarTextIsRegularExpression != null)
            {
                sAPSelectShellToolbarMenuItem["SearchToolbarTextIsRegularExpression"] = ExpressionConverter.ConvertO(sAPSelectShellToolbarMenuItemsearchToolbarTextIsRegularExpression);
                sAPSelectShellToolbarMenuItempropCount++;
            }

            if (sAPSelectShellToolbarMenuItemsearchToolbarTextIsCaseSensitive != null)
            {
                sAPSelectShellToolbarMenuItem["SearchToolbarTextIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPSelectShellToolbarMenuItemsearchToolbarTextIsCaseSensitive);
                sAPSelectShellToolbarMenuItempropCount++;
            }

            sAPSelectShellToolbarMenuItempropCount++;
            sAPSelectShellToolbarMenuItem["Workflow"] = ExpressionConverter.ConvertO(sAPSelectShellToolbarMenuItemworkflow);
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
            sAPGetSAPGridViewProperties["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGetSAPGridViewPropertiessearchSAPElementId);
            sAPGetSAPGridViewPropertiespropCount++;
            sAPGetSAPGridViewProperties["Workflow"] = ExpressionConverter.ConvertO(sAPGetSAPGridViewPropertiesworkflow);
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
                sAPGetSAPGridViewCellContentsAtIndex["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitleIsRegularExpression);
                sAPGetSAPGridViewCellContentsAtIndexpropCount++;
            }

            if (sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitleIsCaseSensitive != null)
            {
                sAPGetSAPGridViewCellContentsAtIndex["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPGetSAPGridViewCellContentsAtIndexsearchColumnTitleIsCaseSensitive);
                sAPGetSAPGridViewCellContentsAtIndexpropCount++;
            }

            sAPGetSAPGridViewCellContentsAtIndexpropCount++;
            sAPGetSAPGridViewCellContentsAtIndex["Workflow"] = ExpressionConverter.ConvertO(sAPGetSAPGridViewCellContentsAtIndexworkflow);
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
                sAPGetSAPGridViewCellPropertiesAtIndex["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitleIsRegularExpression);
                sAPGetSAPGridViewCellPropertiesAtIndexpropCount++;
            }

            if (sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitleIsCaseSensitive != null)
            {
                sAPGetSAPGridViewCellPropertiesAtIndex["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPGetSAPGridViewCellPropertiesAtIndexsearchColumnTitleIsCaseSensitive);
                sAPGetSAPGridViewCellPropertiesAtIndexpropCount++;
            }

            sAPGetSAPGridViewCellPropertiesAtIndexpropCount++;
            sAPGetSAPGridViewCellPropertiesAtIndex["Workflow"] = ExpressionConverter.ConvertO(sAPGetSAPGridViewCellPropertiesAtIndexworkflow);
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
                sAPDrawRectangleAroundSAPGridViewCellAtIndex["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression);
                sAPDrawRectangleAroundSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive != null)
            {
                sAPDrawRectangleAroundSAPGridViewCellAtIndex["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPDrawRectangleAroundSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive);
                sAPDrawRectangleAroundSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPDrawRectangleAroundSAPGridViewCellAtIndexpenColour != null)
            {
                sAPDrawRectangleAroundSAPGridViewCellAtIndex["PenColour"] = ExpressionConverter.ConvertO(sAPDrawRectangleAroundSAPGridViewCellAtIndexpenColour);
                sAPDrawRectangleAroundSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPDrawRectangleAroundSAPGridViewCellAtIndexpenThicknessPixels != null)
            {
                sAPDrawRectangleAroundSAPGridViewCellAtIndex["PenThicknessPixels"] = ExpressionConverter.ConvertO(sAPDrawRectangleAroundSAPGridViewCellAtIndexpenThicknessPixels);
                sAPDrawRectangleAroundSAPGridViewCellAtIndexpropCount++;
            }

            sAPDrawRectangleAroundSAPGridViewCellAtIndexpropCount++;
            sAPDrawRectangleAroundSAPGridViewCellAtIndex["Workflow"] = ExpressionConverter.ConvertO(sAPDrawRectangleAroundSAPGridViewCellAtIndexworkflow);
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
                sAPGlobalLeftClickSAPGridViewCellAtIndex["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression);
                sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive != null)
            {
                sAPGlobalLeftClickSAPGridViewCellAtIndex["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPGlobalLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive);
                sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPGlobalLeftClickSAPGridViewCellAtIndexsetElementWindowTopMost != null)
            {
                sAPGlobalLeftClickSAPGridViewCellAtIndex["SetElementWindowTopMost"] = ExpressionConverter.ConvertO(sAPGlobalLeftClickSAPGridViewCellAtIndexsetElementWindowTopMost);
                sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPGlobalLeftClickSAPGridViewCellAtIndexbringElementWindowToFront != null)
            {
                sAPGlobalLeftClickSAPGridViewCellAtIndex["BringElementWindowToFront"] = ExpressionConverter.ConvertO(sAPGlobalLeftClickSAPGridViewCellAtIndexbringElementWindowToFront);
                sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPGlobalLeftClickSAPGridViewCellAtIndextoggleWindow != null)
            {
                sAPGlobalLeftClickSAPGridViewCellAtIndex["ToggleWindow"] = ExpressionConverter.ConvertO(sAPGlobalLeftClickSAPGridViewCellAtIndextoggleWindow);
                sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPGlobalLeftClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent != null)
            {
                sAPGlobalLeftClickSAPGridViewCellAtIndex["ToggleUsesGlobalLeftMouseClickAgent"] = ExpressionConverter.ConvertO(sAPGlobalLeftClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent);
                sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPGlobalLeftClickSAPGridViewCellAtIndextoggleDelay != null)
            {
                sAPGlobalLeftClickSAPGridViewCellAtIndex["ToggleDelay"] = ExpressionConverter.ConvertO(sAPGlobalLeftClickSAPGridViewCellAtIndextoggleDelay);
                sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPGlobalLeftClickSAPGridViewCellAtIndexclickOffsetX != null)
            {
                sAPGlobalLeftClickSAPGridViewCellAtIndex["ClickOffsetX"] = ExpressionConverter.ConvertO(sAPGlobalLeftClickSAPGridViewCellAtIndexclickOffsetX);
                sAPGlobalLeftClickSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPGlobalLeftClickSAPGridViewCellAtIndexclickOffsetY != null)
            {
                sAPGlobalLeftClickSAPGridViewCellAtIndex["ClickOffsetY"] = ExpressionConverter.ConvertO(sAPGlobalLeftClickSAPGridViewCellAtIndexclickOffsetY);
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
                sAPGlobalRightClickSAPGridViewCellAtIndex["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression);
                sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive != null)
            {
                sAPGlobalRightClickSAPGridViewCellAtIndex["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPGlobalRightClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive);
                sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPGlobalRightClickSAPGridViewCellAtIndexsetElementWindowTopMost != null)
            {
                sAPGlobalRightClickSAPGridViewCellAtIndex["SetElementWindowTopMost"] = ExpressionConverter.ConvertO(sAPGlobalRightClickSAPGridViewCellAtIndexsetElementWindowTopMost);
                sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPGlobalRightClickSAPGridViewCellAtIndexbringElementWindowToFront != null)
            {
                sAPGlobalRightClickSAPGridViewCellAtIndex["BringElementWindowToFront"] = ExpressionConverter.ConvertO(sAPGlobalRightClickSAPGridViewCellAtIndexbringElementWindowToFront);
                sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPGlobalRightClickSAPGridViewCellAtIndextoggleWindow != null)
            {
                sAPGlobalRightClickSAPGridViewCellAtIndex["ToggleWindow"] = ExpressionConverter.ConvertO(sAPGlobalRightClickSAPGridViewCellAtIndextoggleWindow);
                sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPGlobalRightClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent != null)
            {
                sAPGlobalRightClickSAPGridViewCellAtIndex["ToggleUsesGlobalLeftMouseClickAgent"] = ExpressionConverter.ConvertO(sAPGlobalRightClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent);
                sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPGlobalRightClickSAPGridViewCellAtIndextoggleDelay != null)
            {
                sAPGlobalRightClickSAPGridViewCellAtIndex["ToggleDelay"] = ExpressionConverter.ConvertO(sAPGlobalRightClickSAPGridViewCellAtIndextoggleDelay);
                sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPGlobalRightClickSAPGridViewCellAtIndexclickOffsetX != null)
            {
                sAPGlobalRightClickSAPGridViewCellAtIndex["ClickOffsetX"] = ExpressionConverter.ConvertO(sAPGlobalRightClickSAPGridViewCellAtIndexclickOffsetX);
                sAPGlobalRightClickSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPGlobalRightClickSAPGridViewCellAtIndexclickOffsetY != null)
            {
                sAPGlobalRightClickSAPGridViewCellAtIndex["ClickOffsetY"] = ExpressionConverter.ConvertO(sAPGlobalRightClickSAPGridViewCellAtIndexclickOffsetY);
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
                sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression);
                sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive != null)
            {
                sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive);
                sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsetElementWindowTopMost != null)
            {
                sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["SetElementWindowTopMost"] = ExpressionConverter.ConvertO(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexsetElementWindowTopMost);
                sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexbringElementWindowToFront != null)
            {
                sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["BringElementWindowToFront"] = ExpressionConverter.ConvertO(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexbringElementWindowToFront);
                sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleWindow != null)
            {
                sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["ToggleWindow"] = ExpressionConverter.ConvertO(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleWindow);
                sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent != null)
            {
                sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["ToggleUsesGlobalLeftMouseClickAgent"] = ExpressionConverter.ConvertO(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleUsesGlobalLeftMouseClickAgent);
                sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleDelay != null)
            {
                sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["ToggleDelay"] = ExpressionConverter.ConvertO(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndextoggleDelay);
                sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexclickOffsetX != null)
            {
                sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["ClickOffsetX"] = ExpressionConverter.ConvertO(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexclickOffsetX);
                sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexclickOffsetY != null)
            {
                sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["ClickOffsetY"] = ExpressionConverter.ConvertO(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexclickOffsetY);
                sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexoffsetRelativeTo != null)
            {
                sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["OffsetRelativeTo"] = ExpressionConverter.ConvertO(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexoffsetRelativeTo);
                sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexdoubleClickDelayInMilliseconds != null)
            {
                sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["DoubleClickDelayInMilliseconds"] = ExpressionConverter.ConvertO(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexdoubleClickDelayInMilliseconds);
                sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
            }

            sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexpropCount++;
            sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex["Workflow"] = ExpressionConverter.ConvertO(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndexworkflow);
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
            sAPGetSAPGridViewColumnHeaders["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGetSAPGridViewColumnHeaderssearchSAPElementId);
            sAPGetSAPGridViewColumnHeaderspropCount++;
            sAPGetSAPGridViewColumnHeaders["Workflow"] = ExpressionConverter.ConvertO(sAPGetSAPGridViewColumnHeadersworkflow);
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
                sAPClickSAPGridViewCellAtIndex["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(sAPClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression);
                sAPClickSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive != null)
            {
                sAPClickSAPGridViewCellAtIndex["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive);
                sAPClickSAPGridViewCellAtIndexpropCount++;
            }

            sAPClickSAPGridViewCellAtIndexpropCount++;
            sAPClickSAPGridViewCellAtIndex["Workflow"] = ExpressionConverter.ConvertO(sAPClickSAPGridViewCellAtIndexworkflow);
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
                sAPDoubleClickSAPGridViewCellAtIndex["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression);
                sAPDoubleClickSAPGridViewCellAtIndexpropCount++;
            }

            if (sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive != null)
            {
                sAPDoubleClickSAPGridViewCellAtIndex["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPDoubleClickSAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive);
                sAPDoubleClickSAPGridViewCellAtIndexpropCount++;
            }

            sAPDoubleClickSAPGridViewCellAtIndexpropCount++;
            sAPDoubleClickSAPGridViewCellAtIndex["Workflow"] = ExpressionConverter.ConvertO(sAPDoubleClickSAPGridViewCellAtIndexworkflow);
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
                sAPPressSAPGridViewCellButtonAtIndex["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitleIsRegularExpression);
                sAPPressSAPGridViewCellButtonAtIndexpropCount++;
            }

            if (sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitleIsCaseSensitive != null)
            {
                sAPPressSAPGridViewCellButtonAtIndex["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPPressSAPGridViewCellButtonAtIndexsearchColumnTitleIsCaseSensitive);
                sAPPressSAPGridViewCellButtonAtIndexpropCount++;
            }

            sAPPressSAPGridViewCellButtonAtIndexpropCount++;
            sAPPressSAPGridViewCellButtonAtIndex["Workflow"] = ExpressionConverter.ConvertO(sAPPressSAPGridViewCellButtonAtIndexworkflow);
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
                sAPCheckSAPGridViewCellCheckboxAtIndex["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitleIsRegularExpression);
                sAPCheckSAPGridViewCellCheckboxAtIndexpropCount++;
            }

            if (sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitleIsCaseSensitive != null)
            {
                sAPCheckSAPGridViewCellCheckboxAtIndex["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPCheckSAPGridViewCellCheckboxAtIndexsearchColumnTitleIsCaseSensitive);
                sAPCheckSAPGridViewCellCheckboxAtIndexpropCount++;
            }

            if (sAPCheckSAPGridViewCellCheckboxAtIndexcheckCellElement != null)
            {
                sAPCheckSAPGridViewCellCheckboxAtIndex["CheckCellElement"] = ExpressionConverter.ConvertO(sAPCheckSAPGridViewCellCheckboxAtIndexcheckCellElement);
                sAPCheckSAPGridViewCellCheckboxAtIndexpropCount++;
            }

            sAPCheckSAPGridViewCellCheckboxAtIndexpropCount++;
            sAPCheckSAPGridViewCellCheckboxAtIndex["Workflow"] = ExpressionConverter.ConvertO(sAPCheckSAPGridViewCellCheckboxAtIndexworkflow);
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
                sAPModifySAPGridViewCellAtIndex["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(sAPModifySAPGridViewCellAtIndexsearchColumnTitleIsRegularExpression);
                sAPModifySAPGridViewCellAtIndexpropCount++;
            }

            if (sAPModifySAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive != null)
            {
                sAPModifySAPGridViewCellAtIndex["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPModifySAPGridViewCellAtIndexsearchColumnTitleIsCaseSensitive);
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
                sAPPressSAPGridViewColumnHeader["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(sAPPressSAPGridViewColumnHeadersearchColumnTitleIsRegularExpression);
                sAPPressSAPGridViewColumnHeaderpropCount++;
            }

            if (sAPPressSAPGridViewColumnHeadersearchColumnTitleIsCaseSensitive != null)
            {
                sAPPressSAPGridViewColumnHeader["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPPressSAPGridViewColumnHeadersearchColumnTitleIsCaseSensitive);
                sAPPressSAPGridViewColumnHeaderpropCount++;
            }

            sAPPressSAPGridViewColumnHeaderpropCount++;
            sAPPressSAPGridViewColumnHeader["Workflow"] = ExpressionConverter.ConvertO(sAPPressSAPGridViewColumnHeaderworkflow);
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
            sAPSelectSAPGridViewRow["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPSelectSAPGridViewRowsearchSAPElementId);
            sAPSelectSAPGridViewRowpropCount++;
            sAPSelectSAPGridViewRow["RowIndex"] = ExpressionConverter.ConvertO(sAPSelectSAPGridViewRowrowIndex);
            if (sAPSelectSAPGridViewRowsetAsCurrentRow != null)
            {
                sAPSelectSAPGridViewRow["SetAsCurrentRow"] = ExpressionConverter.ConvertO(sAPSelectSAPGridViewRowsetAsCurrentRow);
                sAPSelectSAPGridViewRowpropCount++;
            }

            sAPSelectSAPGridViewRowpropCount++;
            sAPSelectSAPGridViewRow["Workflow"] = ExpressionConverter.ConvertO(sAPSelectSAPGridViewRowworkflow);
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
                sAPSetSAPGridViewCurrentColumn["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(sAPSetSAPGridViewCurrentColumnsearchColumnTitleIsRegularExpression);
                sAPSetSAPGridViewCurrentColumnpropCount++;
            }

            if (sAPSetSAPGridViewCurrentColumnsearchColumnTitleIsCaseSensitive != null)
            {
                sAPSetSAPGridViewCurrentColumn["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPSetSAPGridViewCurrentColumnsearchColumnTitleIsCaseSensitive);
                sAPSetSAPGridViewCurrentColumnpropCount++;
            }

            sAPSetSAPGridViewCurrentColumnpropCount++;
            sAPSetSAPGridViewCurrentColumn["Workflow"] = ExpressionConverter.ConvertO(sAPSetSAPGridViewCurrentColumnworkflow);
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
                sAPSetSAPGridViewCurrentCell["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(sAPSetSAPGridViewCurrentCellsearchColumnTitleIsRegularExpression);
                sAPSetSAPGridViewCurrentCellpropCount++;
            }

            if (sAPSetSAPGridViewCurrentCellsearchColumnTitleIsCaseSensitive != null)
            {
                sAPSetSAPGridViewCurrentCell["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPSetSAPGridViewCurrentCellsearchColumnTitleIsCaseSensitive);
                sAPSetSAPGridViewCurrentCellpropCount++;
            }

            sAPSetSAPGridViewCurrentCellpropCount++;
            sAPSetSAPGridViewCurrentCell["Workflow"] = ExpressionConverter.ConvertO(sAPSetSAPGridViewCurrentCellworkflow);
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
                sAPSelectSAPGridViewColumn["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(sAPSelectSAPGridViewColumnsearchColumnTitleIsRegularExpression);
                sAPSelectSAPGridViewColumnpropCount++;
            }

            if (sAPSelectSAPGridViewColumnsearchColumnTitleIsCaseSensitive != null)
            {
                sAPSelectSAPGridViewColumn["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPSelectSAPGridViewColumnsearchColumnTitleIsCaseSensitive);
                sAPSelectSAPGridViewColumnpropCount++;
            }

            if (sAPSelectSAPGridViewColumnselectColumn != null)
            {
                sAPSelectSAPGridViewColumn["SelectColumn"] = ExpressionConverter.ConvertO(sAPSelectSAPGridViewColumnselectColumn);
                sAPSelectSAPGridViewColumnpropCount++;
            }

            if (sAPSelectSAPGridViewColumnsetAsCurrentColumn != null)
            {
                sAPSelectSAPGridViewColumn["SetAsCurrentColumn"] = ExpressionConverter.ConvertO(sAPSelectSAPGridViewColumnsetAsCurrentColumn);
                sAPSelectSAPGridViewColumnpropCount++;
            }

            if (sAPSelectSAPGridViewColumnclearSelectionFirst != null)
            {
                sAPSelectSAPGridViewColumn["ClearSelectionFirst"] = ExpressionConverter.ConvertO(sAPSelectSAPGridViewColumnclearSelectionFirst);
                sAPSelectSAPGridViewColumnpropCount++;
            }

            sAPSelectSAPGridViewColumnpropCount++;
            sAPSelectSAPGridViewColumn["Workflow"] = ExpressionConverter.ConvertO(sAPSelectSAPGridViewColumnworkflow);
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
            sAPGridViewSelectAll["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGridViewSelectAllsearchSAPElementId);
            sAPGridViewSelectAllpropCount++;
            sAPGridViewSelectAll["Workflow"] = ExpressionConverter.ConvertO(sAPGridViewSelectAllworkflow);
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
            sAPGridViewDeselectAll["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGridViewDeselectAllsearchSAPElementId);
            sAPGridViewDeselectAllpropCount++;
            sAPGridViewDeselectAll["Workflow"] = ExpressionConverter.ConvertO(sAPGridViewDeselectAllworkflow);
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
                sAPSetSAPGridViewFirstVisibleColumn["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitleIsRegularExpression);
                sAPSetSAPGridViewFirstVisibleColumnpropCount++;
            }

            if (sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitleIsCaseSensitive != null)
            {
                sAPSetSAPGridViewFirstVisibleColumn["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPSetSAPGridViewFirstVisibleColumnsearchColumnTitleIsCaseSensitive);
                sAPSetSAPGridViewFirstVisibleColumnpropCount++;
            }

            sAPSetSAPGridViewFirstVisibleColumnpropCount++;
            sAPSetSAPGridViewFirstVisibleColumn["Workflow"] = ExpressionConverter.ConvertO(sAPSetSAPGridViewFirstVisibleColumnworkflow);
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
                sAPGridViewOpenContextMenu["SearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(sAPGridViewOpenContextMenusearchColumnTitleIsRegularExpression);
                sAPGridViewOpenContextMenupropCount++;
            }

            if (sAPGridViewOpenContextMenusearchColumnTitleIsCaseSensitive != null)
            {
                sAPGridViewOpenContextMenu["SearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPGridViewOpenContextMenusearchColumnTitleIsCaseSensitive);
                sAPGridViewOpenContextMenupropCount++;
            }

            sAPGridViewOpenContextMenupropCount++;
            sAPGridViewOpenContextMenu["Workflow"] = ExpressionConverter.ConvertO(sAPGridViewOpenContextMenuworkflow);
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
            sAPGetGridViewTextContents["SearchSAPElementId"] = ExpressionConverter.ConvertO(sAPGetGridViewTextContentssearchSAPElementId);
            if (sAPGetGridViewTextContentsfirstRowToReturn != null)
            {
                sAPGetGridViewTextContents["FirstRowToReturn"] = ExpressionConverter.ConvertO(sAPGetGridViewTextContentsfirstRowToReturn);
                sAPGetGridViewTextContentspropCount++;
            }

            if (sAPGetGridViewTextContentsmaxRowsToReturn != null)
            {
                sAPGetGridViewTextContents["MaxRowsToReturn"] = ExpressionConverter.ConvertO(sAPGetGridViewTextContentsmaxRowsToReturn);
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
                sAPGetGridViewTextContents["FirstSearchColumnTitleIsRegularExpression"] = ExpressionConverter.ConvertO(sAPGetGridViewTextContentsfirstSearchColumnTitleIsRegularExpression);
                sAPGetGridViewTextContentspropCount++;
            }

            if (sAPGetGridViewTextContentsfirstSearchColumnTitleIsCaseSensitive != null)
            {
                sAPGetGridViewTextContents["FirstSearchColumnTitleIsCaseSensitive"] = ExpressionConverter.ConvertO(sAPGetGridViewTextContentsfirstSearchColumnTitleIsCaseSensitive);
                sAPGetGridViewTextContentspropCount++;
            }

            if (sAPGetGridViewTextContentsmaxColumnsToReturn != null)
            {
                sAPGetGridViewTextContents["MaxColumnsToReturn"] = ExpressionConverter.ConvertO(sAPGetGridViewTextContentsmaxColumnsToReturn);
                sAPGetGridViewTextContentspropCount++;
            }

            if (sAPGetGridViewTextContentsuseColumnHeadersFromTable != null)
            {
                sAPGetGridViewTextContents["UseColumnHeadersFromTable"] = ExpressionConverter.ConvertO(sAPGetGridViewTextContentsuseColumnHeadersFromTable);
                sAPGetGridViewTextContentspropCount++;
            }

            if (sAPGetGridViewTextContentsreturnRowIndexInOutputCollection != null)
            {
                sAPGetGridViewTextContents["ReturnRowIndexInOutputCollection"] = ExpressionConverter.ConvertO(sAPGetGridViewTextContentsreturnRowIndexInOutputCollection);
                sAPGetGridViewTextContentspropCount++;
            }

            if (sAPGetGridViewTextContentsnameOfColumnToStoreRowIndex != null)
            {
                sAPGetGridViewTextContents["NameOfColumnToStoreRowIndex"] = ExpressionConverter.ConvertO(sAPGetGridViewTextContentsnameOfColumnToStoreRowIndex);
                sAPGetGridViewTextContentspropCount++;
            }

            if (sAPGetGridViewTextContentscheckedElementValue != null)
            {
                sAPGetGridViewTextContents["CheckedElementValue"] = ExpressionConverter.ConvertO(sAPGetGridViewTextContentscheckedElementValue);
                sAPGetGridViewTextContentspropCount++;
            }

            sAPGetGridViewTextContentspropCount++;
            sAPGetGridViewTextContents["Workflow"] = ExpressionConverter.ConvertO(sAPGetGridViewTextContentsworkflow);
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